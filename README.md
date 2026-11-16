# foxtable20261116 — Foxtable C# Source Snapshot
version: 2026.11.16.1   (Assembly 2026.11.16.01)

> **Foxtable** is a low-code Windows desktop development platform, built on .NET Framework 4.7.2. This repository is a **C# decompiled source snapshot** of the **2026.11.16.1** build — assembly version `2026.11.16.1`, assembly file version `2026.11.16.01` (see `Properties/AssemblyInfo.cs`). Earlier VB.NET source snapshots live in [gdtools/foxtable20261026](https://github.com/gdtools/foxtable20261026) and [gdtools/foxtable-20260803](https://github.com/gdtools/foxtable-20260803).

## Overview

Foxtable enables rapid development of database-driven applications through a visual design surface, an in-memory tabular data engine with SQL-like query capabilities, a full-featured report generation suite, and a component library spanning both desktop WinForms and mobile web interfaces.

**Stats**: 1,576 files · 1,372 C# source files · ~509,000 lines of C#

> **Provenance** — the tree was produced by decompiling the shipped `Foxtable.exe` with **ILSpy**. Because the assembly is obfuscated with **Dotfuscator** (see `DotfuscatorAttribute.cs` and the `[assembly: Dotfuscator(...)]` entry in `Properties/AssemblyInfo.cs`), most internal type names appear as `O0oO*`-style identifiers, generated closures show up as synthetic classes, and `_002E`-escaped identifiers are preserved from the metadata. The meaningfully named public types listed below are the stable surface.

## What's in this build

This is the **2026.11.16.1** build. It carries the AI / WebView2 work from the 2026.8.3.1 line together with the `LLMCaller` client introduced in the 2026.10.26 line:

- **AI Tools** — first-class support for LLM function-calling via `AITool` / `AIParameter` / `AIToolBuilder` (OpenAI-style `tools` JSON). See [AI Tools](#ai-tools) below.
- **LLM Calling** — `LLMCaller` drives chat completions with tool calling and SSE streaming (`SSEStreamHandler`, async state machines, `Newtonsoft.Json.Linq` payloads).
- **WebView2 Embedded Browser** — `WebViewer` sits alongside the legacy IE-based `WebBrowser`, backed by the Chromium engine with a JS message bridge and full navigation / download event hooks.
- **JavaScript Bridge** — `*Js` helpers (`AudioJs`, `ClipBoardJs`, `MessageBoxForJs`, `SendkeysJs`, `PYJS`, …) let web content drive native Foxtable features.
- **HTML/CSS mobile layer** — `CSSStyle` / `cssClassList` / `HElement` / `wElement` / `HStorage` for richer mobile-web styling.
- **Actipro SyntaxEditor still present** — unlike the 2026.10.26 VB snapshot, this C# tree still references `ActiproSoftware.*` in 13 source files, and the 5 Actipro DLL references remain in `Foxtable.csproj`.

---

## Architecture

Foxtable is organized into six core subsystems:

```
┌─────────────────────────────────────────────────────────┐
│                    Application Layer                      │
│  Main.cs  ·  ProjectProperty  ·  Process  ·  FormProperty │
├─────────────────────────────────────────────────────────┤
│                 UI Framework Layer                       │
│  WinForm/  (60+ desktop controls)                       │
│  RibbonMenu/  (ribbon UI framework)                      │
│  w*  (40+ mobile web components)                        │
├──────────────────────┬──────────────────────────────────┤
│   Data Layer         │       Report Engine              │
│  Table, DataTable,    │  Word/  ·  XLS/  ·  PrintDoc    │
│  DataCol, Connection  │  PDFCreator  ·  Report          │
├──────────────────────┼──────────────────────────────────┤
│  Visualization       │       Communication              │
│  Chart, Gantt, Map,   │  FTP/HTTP, IM, SMS, Email,      │
│  Gauge, BarCode       │  WeChat, UDP                    │
└──────────────────────┴──────────────────────────────────┘
```

---

## Core Subsystems

### Data Engine

The foundation of Foxtable — a full in-memory relational data engine with no external database dependency.

| Class | Role |
|-------|------|
| `Table` | Core data container; exposes SQL-like `Select`, `Filter`, `Sort`, `Group` |
| `DataTable` | In-memory table with `Compute`, expression columns, relations |
| `DataCol` / `DataRow` | Column and row abstractions with type validation |
| `Connection` | ADOX/ADODB connection management for Access, SQL Server, etc. |
| `QueryBuilder` | Visual query construction; supports joins, grouping, subtotals |
| `SQLCommand` | Direct SQL execution with parameterized queries |
| `BomTable` / `PriceTable` / `StockTable` / `YieldTable` | Domain-specific table templates |
| `Merger` | Table merge / union operations |

**Table Builders** — specialized query builders that generate structured results:

| Builder | Purpose |
|---------|---------|
| `GroupTableBuilder` / `SQLGroupTableBuilder` | Group rows with auto subtotals |
| `CrossTableBuilder` / `SQlCrossTableBuilder` | Pivot / cross-tabulation |
| `JoinTableBuilder` / `SQLJoinTableBuilder` | Multi-table inner/outer joins |
| `InlineGroupTableBuilder` / `InlineMRPBuilder` | Inline tree + MRP planning |
| `LayersMRPBuilder` / `LayersGroupTableBuilder` | Multi-level hierarchical tables |
| `OuterTableBuilder` | External/outer data source joins |

### UI Framework

Foxtable provides two UI layers: **Desktop (WinForms)** and **Mobile Web**.

#### Desktop Controls — `WinForm/`

60+ WinForm control wrappers that wrap C1 components with Foxtable's property system:

```
Layout      → Form, Panel, SplitContainer, TabControl, TabPage, NavBar, NavPage
             TopicBar, TopicPage, Strip, StripItem
Data        → Table, RecordGrid, ListView, TreeView, FilterTree, LoadTree
             LayersTree, InlineTree
Charts      → Chart (with ChartAxis, ChartSeries, ChartDataArray)
Gantt       → GanttView (with task bars, day painting, tooltips)
Visuals     → Gauges, Map, PictureBox, PictureViewer, WebBrowser
             BarCode, Painter, PDFViewer
Input       → TextBox, Button, CheckBox, ComboBox, ListBox, DateTimePicker
             NumericComboBox, DropDownBox, ColorPicker, FontPicker, TrackBar
Navigation  → ListViewColumn, ListViewRow, TreeNode, TreeNodes
             TopicLink, RecordGrid, ProgressBar, GroupBox
```

#### Ribbon UI — `RibbonMenu/`

A complete ribbon framework mirroring the Microsoft Office ribbon paradigm:

- **Tabs & Groups**: `RibbonTab`, `RibbonTopTab`, `RibbonGroup`, `RibbonMenuButton`
- **Items**: `RibbonButton`, `RibbonToggleButton`, `RibbonSplitButton`, `RibbonCheckBox`, `RibbonComboBox`, `RibbonTextBox`, `RibbonNumericBox`, `RibbonDatePicker`, `RibbonTimePicker`, `RibbonColorPicker`, `RibbonFontComboBox`, `RibbonGallery`, `RibbonProgressBar`
- **Accessories**: `StatusBar`, `RibbonQat` (Quick Access Toolbar), `RibbonSeparator`
- **Lists**: `RibbonTableViewList`, `RibbonWordReportList`, `RibbonExcelReportList`, `RibbonCodeReportList`, `RibbonCrossTableList`, `RibbonPaperList`, `RibbonWindowList`

#### Mobile Web UI — `w*` components

40+ components for mobile-first web application interfaces, all defined in `wui.cs`:

| Category | Components |
|----------|------------|
| **Layout** | `wPage`, `wPanel`, `wPanelGroup`, `wTable`, `wTableRow` |
| **Input** | `wInput`, `wTextArea`, `wSelect`, `wSwitch`, `wUploader`, `wVcodeButton` |
| **Display** | `wLabel`, `wImage`, `wGallery`, `wArticle`, `wProgress`, `wRawHtml` |
| **Navigation** | `wTabbar`, `wTabButton`, `wActionSheet`, `wActionMenu`, `wDialog` |
| **Feedback** | `wToast`, `wToptips`, `wMsgPage`, `wPreview` |
| **Selection** | `wCheck`, `wCheckGroup`, `wRadioGroup`, `wRadion`, `wButtonGroup` |
| **Data** | `wGrid`, `wGridCell`, `wDataList`, `wListGroup`, `wListIem`, `wRowCollection` |
| **Form** | `wForm`, `wInputGroup`, `wInputCell`, `wGroupTitle` |
| **WeChat** | `WeChatMessageReceived`, `WXBizCrypt`, `weMessageReceived` |

### Report Engine

| Module | Description |
|--------|-------------|
| `Word/Report`, `WordCreator`, `WordReport` | Word document report generation via Office Interop |
| `XLS/Report`, `XLS/Book`, `XLS/Sheet`, `XLS/Cell` | Excel spreadsheet creation with full formatting |
| `XLS/Style`, `XLS/AlignHorzEnum`, `XLS/LineStyleEnum` | Rich cell styling |
| `PDFCreator`, `PDFSource`, `PDFViewerProperty` | PDF generation and embedded viewing |
| `PrintDoc`, `PrintInfo`, `PrintPageProperty` | Direct print pipeline |

### Visualization

| Module | Description |
|--------|-------------|
| `ChartBuilder` | 2D charts (bar, line, pie) with histograms (`ChartHistogram`) |
| `GanttView` | Project Gantt with task bars, day painting, tooltips |
| `GaugesProperty` | Analog gauge controls with pointer drag events |
| `BarCodeBuilder` | 1D/2D barcode generation via BarcodeProfessional |
| `GeoMap` | Geographic map component with `GetMapTileEventArgs` |
| `ImageMap` | Static image overlay with hotspots |
| `CustomMarkShape`, `MarkImageShape`, `MarkTextShape` | Custom map overlay shapes |
| `VirtualLayer`, `VirtualTileSource` | Custom map tile layers (via `CustomTileSource`) |

### Communication

| Module | Description |
|--------|-------------|
| `FTPClient` | Full FTP with event-driven callbacks |
| `HttpClient`, `HttpListenter` | HTTP client and built-in HTTP listener/server |
| `IMServer`, `IMClient` | Peer-to-peer IM with buddy and user management |
| `MobileSMS`, `FoxSMSControl` | SMS via COM modem (JinDI) |
| `MobileEmail` | Email sending |
| `MobileURL`, `MobileCard`, `MobileText` | Mobile deep-link and card generation |
| `WeChatMessageReceived`, `WXBizCrypt` | WeChat Official Account message handling |
| `weMessageReceived` | WeChat Enterprise (WeCom) message handling |
| `WXBizMsgCrypt` | WeChat message encryption (native DLL) |
| `UDPClient` | UDP socket networking |
| `UDPClient_MessageReceived` | UDP receive event handler |

### Integration & Extensibility

| Module | Description |
|--------|-------------|
| `TSF.dll` | Text Services Framework for advanced input method support |
| `PY.cs` | Python script execution |
| `FoxFinger.cs` | DPFP biometric fingerprint SDK integration |
| `Camera.cs` | Hardware camera capture |
| `UKey.cs` | USB hardware key / dongle support |
| `MSScriptControl` | VBScript/JScript scripting |
| `ChinesFunctions` | Chinese character conversion utilities |

### Event System

160+ event argument classes following the `*EventArgs` naming convention. Key event categories:

- **Data**: `DataRowEventArgs`, `DataColEventArgs`, `CellClickEventArgs`, `DrawCellEventArgs`, `SortEventArgs`, `FilterEventArgs`
- **UI**: `ControlMouseEventArgs`, `ControlKeyEventArgs`, `BeforeShowContextMenuEventArgs`
- **Communication**: `Client_MessageEventargs`, `Server_MessageEventargs`, `FTPBeforeListDetailsEventArgs`
- **Reporting**: `PageHeaderEventArgs`, `PageFooterEventArgs`, `FormattingEventArgs`, `ChartMouseEventArgs`

### AI Tools

Built-in support for exposing Foxtable functionality to Large Language Models through the OpenAI-style **function-calling** schema. `AIToolBuilder` collects `AITool` definitions (each with a `Name`, `Description` and a list of `AIParameter`s) and serializes them to a `{"type":"function", ...}` JSON `tools` array via `Build()`.

| Class | Role |
|-------|------|
| `AITool` | A callable tool: `Name`, `Description`, `Parameters` (`List(Of AIParameter)`); `AddParameter(name, type, description, isRequired, arrayItemType, enumValues)` |
| `AIParameter` | One parameter: `Name`, `Type`, `Description`, `IsRequired`, `ArrayItemType`, `EnumValues` |
| `AIToolBuilder` | `Dictionary(Of String, AITool)`; `AddFunction(name, description)` → `AITool`; `Build()` → JSON tools array |

### LLM Calling

`LLMCaller` (in `LLMCaller.cs`) is the async LLM client: it builds the chat request with `JObject` / `JArray` payloads, posts it through `HttpClient`, handles tool-call results, and can stream responses through `SSEStreamHandler` when `stream` is enabled. Compiler-generated `IAsyncStateMachine` structs carry the await/resume logic.

### WebView2 Embedded Browser

The legacy IE-based `WebBrowser` control is superseded by **`WebViewer`**, a wrapper around `Microsoft.Web.WebView2.WinForms.WebView2` — the modern Chromium engine. DevTools, Save-As, context menus and accelerator keys are enabled by default, and downloads are managed internally.

| Class | Role |
|-------|------|
| `WebViewer` / `WebViewerProperty` | Chromium embedded browser control + design properties |
| `WebMessageReceivedEventArgs` | Host ↔ page `postMessage` bridge |
| `WebResourceRequestedEventArgs` | Intercept / rewrite outgoing resource requests |
| `WebResourceResponseReceivedEventArgs` | Inspect completed responses |
| `NavigationStartingEventArgs` / `NavigationCompletedEventArgs` | Navigation lifecycle hooks |
| `NewWindowRequestedEventArgs` | Popup / new-window handling |
| `DOMContentLoadedEventArgs` | Page DOM-ready notification |

### JavaScript Bridge

`*Js` helper classes expose native Foxtable capabilities to JavaScript running inside `WebViewer`, so web UIs can drive the desktop runtime:

| Class | Bridge |
|-------|--------|
| `AudioJs` | Play / control audio from script |
| `ClipBoardJs` | Read / write the system clipboard |
| `MessageBoxForJs` | Show native message boxes |
| `SendkeysJs` | Dispatch keystrokes |
| `ColorDialogJs` · `FontDialogJs` · `FolderBrowserDialogForjs` · `OpenFileDialogForjs` · `SaveFileDialogForjs` | Native picker dialogs |
| `DataMapJs` | Map data between page and host |
| `PYJS` | Execute Python from script |
| `RibbonMenuJs` | Drive the ribbon from script |

> The mobile-web layer also gains CSS/HTML element abstractions — `CSSStyle` / `cssClassList` (style & class management), `HElement` / `wElement` (HTML element model) and `HStorage` (web storage).

---

## Technology Stack

- **Language**: C# 11 (decompiled from the original VB.NET assembly)
- **Framework**: .NET Framework 4.7.2
- **Platform**: x86 / Windows
- **IDE**: Visual Studio 2017 (v15.0)

### Dependencies

| Library | Version | Purpose |
|---------|---------|---------|
| ComponentOne Studio for WinForms | v4 | FlexGrid, Ribbon, Chart, Gauge, GanttView, Schedule, Report, Excel, Word, PDF, Zip, Map, Sparkline, Sizer |
| Neodynamic BarcodeProfessional | — | 1D/2D barcode generation |
| Newtonsoft.Json | — | JSON serialization |
| Microsoft.Web.WebView2 | — | Chromium-based embedded browser (`WebViewer` control) |
| Actipro SyntaxEditor | — | Code editor (still referenced in this snapshot) |
| DPFP SDK | — | Fingerprint biometrics |
| TSF (Text Services Framework) | — | Advanced input method support |
| WXBizMsgCrypt | — | WeChat message encryption |
| Foxtable.Lib | — | Native helper library |
| Office 2007 Renderer | — | Office 2007 visual style rendering |
| ADOX / ADODB | — | Database connectivity |

---

## Project Structure

```
foxtable20261116/                         # this repo — decompiled C# tree
├── Foxtable.csproj                       # classic MSBuild project (net472, x86, WinExe)
├── b.cs                                  # Dotfuscator-generated helper structs
├── DotfuscatorAttribute.cs               # Obfuscator marker attribute (root copy)
├── exe.licenses                          # Embedded license manifest
├── README.md
├── Foxtable.ico · app.manifest           # Icon, UAC/DPI manifest
├── Main.cs                               # Application entry point ([STAThread] Main)
├── AITool.cs · AIParameter.cs · AIToolBuilder.cs   # AI Tools function-calling schema
├── LLMCaller.cs                          # LLM client (tool calling + SSE streaming)
├── WebViewer.cs · WebViewerProperty.cs   # WebView2 Chromium control
├── CSSStyle.cs · HElement.cs · wElement.cs · HStorage.cs · wui.cs
│                                         # Mobile HTML/CSS layer
├── *Js.cs                                # JS bridge helpers (AudioJs, ClipBoardJs, …)
├── *.cs                                  # Core source — 1,215 files at root:
│                                         #   data engine, events, comms, charts
├── WinForm/                              # Desktop control wrappers — 66 files
├── RibbonMenu/                           # Ribbon UI framework — 48 files
├── XLS/                                  # Excel report engine — 22 files
├── Syscmd/                               # System command handlers — 8 files
├── My/                                   # My.* namespace extensions — 8 files
├── Word/                                 # Word report engine — 4 files
├── C1/ · O0o0/                           # ComponentOne resources / obfuscated namespace
└── Properties/AssemblyInfo.cs            # Assembly metadata (v2026.11.16.1)
```

---

## Version History

| Version | Assembly | Framework | Highlights |
|---------|----------|-----------|------------|
| 2025.12.18.1 | 2025.12.18.01 | .NET 4.0 | Earlier snapshot (kept in the `Foxtable20251218/` folder of the 2026.8.3.1 repo) |
| 2026.8.3.1 | 2026.08.03.01 | .NET 4.7.2 | AI Tools (`AITool` schema), WebView2 `WebViewer`, `*Js` bridge, mobile HTML/CSS layer; Actipro SyntaxEditor present |
| 2026.10.26.1 | 2026.10.26.01 | .NET 4.7.2 | `LLMCaller` LLM client (tool calling + SSE streaming); Actipro SyntaxEditor removed — see the VB repo |
| 2026.11.9.1 | 2026.11.09.01 | .NET 4.7.2 | C# decompiled snapshot; `LLMCaller` + AI Tools + WebView2 + `*Js` bridge; Actipro references still present |
| **2026.11.16.1** | **2026.11.16.01** | .NET 4.7.2 | **This repo** — refreshed C# decompiled snapshot; same feature set as 2026.11.9.1 |

This C# tree corresponds to **2026.11.16.1**. To diff against the preceding C# snapshot, clone [gdtools/foxtable20261109](https://github.com/gdtools/foxtable20261109) and compare by file/type name:

```
git diff --no-index --stat ../foxtable20261109 .
```

Note: this build is obfuscated (Dotfuscator), so most type names appear as `O0oO*`-style identifiers; the meaningfully named classes listed above are the stable public surface.

---

## Requirements

The snapshot is **not directly buildable** — it ships without the referenced binary dependencies, and `Foxtable.csproj` points `HintPath` entries at a local `..\..\Premium\` folder.

- Windows 7 or later
- .NET Framework 4.7.2
- Microsoft Edge WebView2 Runtime (required by the `WebViewer` control)
- Visual Studio 2017 or later, or any IDE with C# 11 support
- ComponentOne Studio for WinForms v4, Actipro SyntaxEditor, and the other commercial DLLs listed above — all `HintPath`-referenced, not vendored

## License

Proprietary. All rights reserved. The source is published for reference and study only.

## Related Repositories

| Repo | Description |
|------|-------------|
| [gdtools/foxtable_20261116](https://github.com/gdtools/foxtable_20261116) | **This repo** — C# decompiled source of the 2026.11.16.1 build |
| [gdtools/foxtable20261109](https://github.com/gdtools/foxtable20261109) | C# decompiled source of the 2026.11.9.1 build |
| [gdtools/foxtable20261026](https://github.com/gdtools/foxtable20261026) | Original **VB.NET** source of the 2026.10.26.1 build |
| [gdtools/foxtable-20260803](https://github.com/gdtools/foxtable-20260803) | VB.NET source snapshot of 2026.8.3.1, also containing the 2025.12.18.1 tree |
| [gdtools/foxtable_pro](https://github.com/gdtools/foxtable_pro) | Foxtable Pro — enhancement plugin system with Git version control and VS code generation |
| [gdtools/foxtable_docs_20260812](https://github.com/gdtools/foxtable_docs_20260812) | Foxtable development documentation and specifications |
| [gdtools/foxai20260803](https://github.com/gdtools/foxai20260803) | Foxtable development documentation |
