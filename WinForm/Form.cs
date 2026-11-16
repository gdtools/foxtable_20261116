using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.C1Preview;
using C1.Win.C1Chart;
using C1.Win.C1Command;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1GanttView;
using C1.Win.C1Gauge;
using C1.Win.C1Input;
using C1.Win.C1Sizer;
using C1.Win.FlexViewer;
using Foxtable.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.Core;
using MSScriptControl;
using O0o0.00;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 用户窗口
	/// </summary>
	// Token: 0x020003C5 RID: 965
	[ComVisible(true)]
	[oO0oooo("0703")]
	public class Form
	{
		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06003E32 RID: 15922 RVA: 0x001C07E4 File Offset: 0x001BE9E4
		// (set) Token: 0x06003E33 RID: 15923 RVA: 0x001C07EC File Offset: 0x001BE9EC
		internal virtual FormPanel Pane
		{
			[CompilerGenerated]
			get
			{
				return this.oO0.O_OO_OO_.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.O.0o00__.);
				EventHandler value3 = new EventHandler(this.o_.o_oOo0O.);
				FormPanel formPanel = this.oO0.O_OO_OO_.;
				if (formPanel != null)
				{
					formPanel.ParentChanged -= value2;
					formPanel.SizeChanged -= value3;
				}
				this.oO0.O_OO_OO_. = value;
				formPanel = this.oO0.O_OO_OO_.;
				if (formPanel != null)
				{
					formPanel.ParentChanged += value2;
					formPanel.SizeChanged += value3;
				}
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06003E34 RID: 15924 RVA: 0x001C084A File Offset: 0x001BEA4A
		// (set) Token: 0x06003E35 RID: 15925 RVA: 0x001C0854 File Offset: 0x001BEA54
		private virtual Timer Timer
		{
			[CompilerGenerated]
			get
			{
				return this.o_0.o0.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.o0O._OOOo0.);
				Timer timer = this.o_0.o0.;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this.o_0.o0. = value;
				timer = this.o_0.o0.;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06003E36 RID: 15926 RVA: 0x001C0897 File Offset: 0x001BEA97
		// (set) Token: 0x06003E37 RID: 15927 RVA: 0x001C08A0 File Offset: 0x001BEAA0
		private virtual C1SizerLight sizer
		{
			[CompilerGenerated]
			get
			{
				return this.o_0.o0.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				C1SizerLightEventHandler value2 = new C1SizerLightEventHandler(this.oOOo.00O__0oO.);
				C1SizerLightEventHandler value3 = new C1SizerLightEventHandler(this.o0o_._0O__OoO.);
				C1SizerLight c1SizerLight = this.o_0.o0.;
				if (c1SizerLight != null)
				{
					c1SizerLight.ResizingControl -= value2;
					c1SizerLight.ResizingFont -= value3;
				}
				this.o_0.o0. = value;
				c1SizerLight = this.o_0.o0.;
				if (c1SizerLight != null)
				{
					c1SizerLight.ResizingControl += value2;
					c1SizerLight.ResizingFont += value3;
				}
			}
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x001C0900 File Offset: 0x001BEB00
		public Form(DataRow A_0, bool A_1)
		{
			this.O_0.O00o_00_O. = true;
			this.o_0.o0. = FormStartPosition.CenterScreen;
			this.o._oOO_o. = true;
			this.O._o_oO. = true;
			this.Oo._0O0OoOO_o0. = true;
			this.oOo.O0__0Oo0. = true;
			this.oO0.O_OO_OO_. = new PrintPageProperty();
			this.o0_o.0_o_. = false;
			this.o_0.o0. = new Dictionary<Control, string>();
			this.o_0.o0. = TabAlignment.Bottom;
			this.O_0.O00o_00_O. = new Dictionary<string, ToolStrip>();
			this.OoO.0_Oo00Ooo. = null;
			this.O0__OO_0.o_oo. = true;
			this.PrintAutoMoveByLine = true;
			this.PrintAutoMoveByTable = true;
			this.OoO._O_Oo00__. = "(default)";
			this.O_o_.0o0__o0O. = A_0;
			this.oOO_0_oo.Oo0. = A_1;
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x001C09A4 File Offset: 0x001BEBA4
		internal static object <<EMPTY_NAME>>(string A_0)
		{
			if (Form.oO0.O_OO_OO_. == null)
			{
				Form.oO0.O_OO_OO_. = new ScriptControlClass();
				Form.oO0.O_OO_OO_..Language = "VBScript";
				string code = O00.oO_.0o_oo_0O_.(a.O0_.o0__.(), "vb", "net");
				Form.oO0.O_OO_OO_..AddCode(code);
			}
			return Form.oO0.O_OO_OO_..Eval(A_0);
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x001C09FC File Offset: 0x001BEBFC
		internal void <<EMPTY_NAME>>()
		{
			this.O_0.O00o_00_O. = this.oO0._o0__o_o_O.(false);
			this.Pane = new FormPanel();
			this.Pane.Name = this.Name;
			this.Pane.ParentChanged += this.o_oOo_0o_.0.;
			if (!this.O_o_.0o0__o0O..IsNull("Property"))
			{
				this.DockArea = DockAreaEnum.右;
				o_O_o_oOoo__.OOOO_OO._oo.(this, Conversions.ToString(this.O_o_.0o0__o0O.["Property"]), '\v');
			}
			this.ooOO0__._0O. = new ControlCollection(this, this.Pane.Controls);
			this.o0000o_Oo0.0_.(this.Pane.Controls, this.O_o_.0o0__o0O., -1);
			this.OoO.O_.();
			if (this.oOO_0_oo.Oo0.)
			{
				OO_00oOO.Forms.O.o_0oOo_O00. = this;
			}
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x001C0AC8 File Offset: 0x001BECC8
		internal Assembly <<EMPTY_NAME>>(bool A_0)
		{
			string text = Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
			string text2 = string.Concat(new string[]
			{
				OO_00oOO.ProjectPath,
				"Bin\\",
				o0OoOOoOOo0.oo00o.0OoO.(""),
				".Form.",
				text,
				".dll"
			});
			Assembly result;
			if (OO_00oOO.FileSys.FileExists(text2) && !A_0)
			{
				result = Assembly.Load(File.ReadAllBytes(text2));
			}
			else
			{
				if (OO_00oOO.FileSys.FileExists(text2))
				{
					OO_00oOO.FileSys.DeleteFile(text2);
				}
				result = o0_.Oo_0.OOo0oO0.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()], "", "", new string[]
				{
					"Key"
				}, "WinForm", text2, O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], this.O_o_.0o0__o0O.);
			}
			return result;
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06003E3C RID: 15932 RVA: 0x001C0BB1 File Offset: 0x001BEDB1
		// (set) Token: 0x06003E3D RID: 15933 RVA: 0x001C0BBE File Offset: 0x001BEDBE
		internal OoOO0ooo PrintSettings
		{
			get
			{
				return this.Pane.PrintPropExtender1;
			}
			private set
			{
				this.Pane.PrintPropExtender1 = value;
			}
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x001C0BCC File Offset: 0x001BEDCC
		private void <<EMPTY_NAME>>(Control.ControlCollection A_0, DataRow A_1, int A_2)
		{
			int num;
			int num6;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				foreach (DataRow dataRow in A_1.GetChildRows("Component"))
				{
					IL_23:
					num2 = 3;
					ControlTypeEnum controlTypeEnum = (ControlTypeEnum)Conversions.ToInteger(dataRow["Type"]);
					IL_38:
					num2 = 4;
					Table table = null;
					IL_3D:
					num2 = 5;
					if (A_2 < 0 || Conversions.ToInteger(dataRow["Page"]) == A_2)
					{
						IL_5A:
						num2 = 7;
						Control control;
						Control control2;
						switch (controlTypeEnum)
						{
						case ControlTypeEnum.Label:
							IL_174:
							num2 = 15;
							control = new OO_0o_O_O();
							IL_17E:
							num2 = 16;
							((System.Windows.Forms.Label)control).AutoSize = true;
							IL_18E:
							num2 = 17;
							control2 = new Foxtable.WinForm.Label((OO_0o_O_O)control);
							break;
						case ControlTypeEnum.TextBox:
							IL_25A:
							num2 = 36;
							control = new O0O_O0();
							IL_264:
							num2 = 37;
							((O0O_O0)control).DataType = typeof(string);
							IL_27D:
							num2 = 38;
							control2 = new TextBox((O0O_O0)control);
							break;
						case ControlTypeEnum.Button:
							IL_229:
							num2 = 32;
							control = new O00_O00();
							IL_233:
							num2 = 33;
							((Button)control).ImageAlign = ContentAlignment.MiddleLeft;
							IL_244:
							num2 = 34;
							control2 = new Button((C1Button)control);
							break;
						case ControlTypeEnum.CheckBox:
							IL_37C:
							num2 = 60;
							control = new CustomCheckBox();
							IL_386:
							num2 = 61;
							control2 = new CheckBox((CustomCheckBox)control);
							break;
						case ControlTypeEnum.RadioButton:
							IL_39C:
							num2 = 63;
							control = new oO00O0oO0o000();
							IL_3A6:
							num2 = 64;
							control2 = new RadioButton((oO00O0oO0o000)control);
							break;
						case ControlTypeEnum.ComboBox:
							IL_2CC:
							num2 = 44;
							control = new OoOO0Oo_oo0oO();
							IL_2D6:
							num2 = 45;
							control2 = new ComboBox((OoOO0Oo_oo0oO)control);
							break;
						case ControlTypeEnum.NumericComboBox:
							IL_3BC:
							num2 = 66;
							control = new ooOOO();
							IL_3C6:
							num2 = 67;
							control2 = new NumericComboBox((ooOOO)control);
							break;
						case ControlTypeEnum.TopicBar:
							IL_134:
							num2 = 9;
							control = new Oo_();
							IL_13E:
							num2 = 10;
							control2 = new TopicBar((Oo_)control);
							break;
						case ControlTypeEnum.DateTimePicker:
							IL_3DC:
							num2 = 69;
							control = new O_0oOoOo();
							IL_3E6:
							num2 = 70;
							control2 = new DateTimePicker((O_0oOoOo)control);
							break;
						case ControlTypeEnum.ListBox:
							IL_32C:
							num2 = 53;
							control = new CustomListBox();
							IL_336:
							num2 = 54;
							control2 = new ListBox((CustomListBox)control);
							break;
						case ControlTypeEnum.CheckedListBox:
							IL_34C:
							num2 = 56;
							control = new CustomCheckedListBox();
							IL_356:
							num2 = 57;
							((CustomCheckedListBox)control).CheckOnClick = true;
							IL_366:
							num2 = 58;
							control2 = new CheckedListBox((CustomCheckedListBox)control);
							break;
						case ControlTypeEnum.GroupBox:
							IL_3FC:
							num2 = 72;
							control = new O0oO0o0o();
							IL_406:
							num2 = 73;
							control2 = new GroupBox((GroupBox)control);
							break;
						case ControlTypeEnum.Panel:
							IL_41C:
							num2 = 75;
							control = new OO0o__();
							IL_426:
							num2 = 76;
							control2 = new Panel((Panel)control);
							break;
						case ControlTypeEnum.SplitContainer:
							IL_45D:
							num2 = 81;
							control = new SplitContainer();
							IL_467:
							num2 = 82;
							((SplitContainer)control).FixedPanel = FixedPanel.Panel1;
							IL_477:
							num2 = 83;
							control2 = new SplitContainer((SplitContainer)control);
							break;
						case ControlTypeEnum.PictureBox:
							IL_43C:
							num2 = 78;
							control = new CustomPictureBox(this);
							IL_447:
							num2 = 79;
							control2 = new PictureBox((CustomPictureBox)control);
							break;
						case ControlTypeEnum.TabControl:
							IL_48D:
							num2 = 85;
							control = new o_o0();
							IL_497:
							num2 = 86;
							control2 = new TabControl((C1DockingTab)control);
							break;
						case ControlTypeEnum.TreeView:
							IL_4AD:
							num2 = 88;
							control = new O__oO_o0_o_o();
							IL_4B7:
							num2 = 89;
							control2 = new TreeView((TreeView)control);
							break;
						case ControlTypeEnum.ProgressBar:
							IL_54D:
							num2 = 103;
							control = new o_O_O0O__();
							IL_557:
							num2 = 104;
							control2 = new ProgressBar((o_O_O0O__)control);
							break;
						case ControlTypeEnum.Chart:
							IL_E7A:
							num2 = 242;
							control = new C1Chart();
							IL_E87:
							num2 = 243;
							control2 = new Chart((C1Chart)control);
							IL_E9B:
							num2 = 244;
							((Chart)control2).Oo_0O0.oo00.();
							break;
						case ControlTypeEnum.PictureViewer:
							IL_64D:
							num2 = 127;
							control = new PictureViewer();
							IL_657:
							num2 = 128;
							control2 = new PictureViewer((PictureViewer)control);
							break;
						case ControlTypeEnum.FileManager:
							IL_62D:
							num2 = 124;
							control = new FileManager();
							IL_637:
							num2 = 125;
							control2 = new FileManager((FileManager)control);
							break;
						case ControlTypeEnum.ColorLabel:
							IL_209:
							num2 = 29;
							control = new CustomColorLabel();
							IL_213:
							num2 = 30;
							control2 = new ColorLabel((CustomColorLabel)control);
							break;
						case ControlTypeEnum.CheckedComboBox:
							IL_2EC:
							num2 = 47;
							control = new O0oo000oO0oo_();
							IL_2F6:
							num2 = 48;
							control2 = new CheckedComboBox((O0oo000oO0oo_)control);
							break;
						case ControlTypeEnum.NavBar:
							IL_154:
							num2 = 12;
							control = new O_OOO();
							IL_15E:
							num2 = 13;
							control2 = new NavBar((O_OOO)control);
							break;
						case ControlTypeEnum.DataList:
						case ControlTypeEnum.QRCode1:
						case ControlTypeEnum.FullPath:
							goto IL_1B3E;
						case ControlTypeEnum.WebBrowser:
							IL_58D:
							num2 = 109;
							control = new OOO0_();
							IL_597:
							num2 = 110;
							control2 = new WebBrowser((OOO0_)control);
							break;
						case ControlTypeEnum.Painter:
							IL_5AD:
							num2 = 112;
							control = new O_oo();
							IL_5B7:
							num2 = 113;
							control2 = new Painter((O_oo)control);
							break;
						case ControlTypeEnum.Line:
							IL_1E9:
							num2 = 26;
							control = new LineControl();
							IL_1F3:
							num2 = 27;
							control2 = new Line((LineControl)control);
							break;
						case ControlTypeEnum.BarCode:
							IL_60D:
							num2 = 121;
							control = new OOo00o_0o0_();
							IL_617:
							num2 = 122;
							control2 = new BarCode((OOo00o_0o0_)control);
							break;
						case ControlTypeEnum.DropDownBox:
							IL_30C:
							num2 = 50;
							control = new OooO00O();
							IL_316:
							num2 = 51;
							control2 = new DropDownBox((OooO00O)control);
							break;
						case ControlTypeEnum.Calendar:
						{
							IL_1A4:
							num2 = 19;
							control = new MonthCalendar();
							IL_1AE:
							num2 = 20;
							MonthCalendar monthCalendar = (MonthCalendar)control;
							IL_1BA:
							num2 = 21;
							monthCalendar.FirstDayOfWeek = Day.Monday;
							IL_1C5:
							num2 = 22;
							monthCalendar.MaxSelectionCount = 1;
							IL_1D0:
							monthCalendar = null;
							IL_1D3:
							num2 = 24;
							control2 = new Calendar((MonthCalendar)control);
							break;
						}
						case ControlTypeEnum.TrackBar:
							IL_56D:
							num2 = 106;
							control = new OoOoo00();
							IL_577:
							num2 = 107;
							control2 = new TrackBar((OoOoo00)control);
							break;
						case ControlTypeEnum.RecordGrid:
							IL_670:
							num2 = 130;
							control = new OooOo0___oO();
							IL_67D:
							num2 = 131;
							control2 = new RecordGrid((OooOo0___oO)control);
							break;
						case ControlTypeEnum.TimeSpanBox:
							IL_293:
							num2 = 40;
							control = new o__0OoO_();
							IL_29D:
							num2 = 41;
							((o__0OoO_)control).DataType = typeof(string);
							IL_2B6:
							num2 = 42;
							control2 = new TimeSpanBox((o__0OoO_)control);
							break;
						case ControlTypeEnum.ListView:
							IL_F1C:
							num2 = 255;
							control = new o_OO_oOOO0o();
							IL_F29:
							num2 = 256;
							control2 = new ListView((o_OO_oOOO0o)control);
							break;
						case ControlTypeEnum.FilterTree:
							IL_4CD:
							num2 = 91;
							control = new o_o0ooOooO();
							IL_4D7:
							num2 = 92;
							control2 = new FilterTree((o_o0ooOooO)control);
							break;
						case ControlTypeEnum.LoadTree:
							IL_4ED:
							num2 = 94;
							control = new o_0();
							IL_4F7:
							num2 = 95;
							control2 = new LoadTree((o_0)control);
							break;
						case ControlTypeEnum.InlineTree:
							IL_50D:
							num2 = 97;
							control = new oo__();
							IL_517:
							num2 = 98;
							control2 = new InlineTree((oo__)control);
							break;
						case ControlTypeEnum.LayersTree:
							IL_52D:
							num2 = 100;
							control = new oO_oo0Oo();
							IL_537:
							num2 = 101;
							control2 = new LayersTree((oO_oo0Oo)control);
							break;
						case ControlTypeEnum.FontPicker:
							IL_6BC:
							num2 = 136;
							control = new O00o();
							IL_6C9:
							num2 = 137;
							control2 = new FontPicker((O00o)control);
							break;
						case ControlTypeEnum.ColorPicker:
							IL_696:
							num2 = 133;
							control = new oOO();
							IL_6A3:
							num2 = 134;
							control2 = new ColorPicker((oOO)control);
							break;
						case ControlTypeEnum.Gauges:
							IL_EB2:
							num2 = 246;
							control = new O0_O_0O();
							IL_EBF:
							num2 = 247;
							control2 = new Gauges((O0_O_0O)control);
							break;
						case ControlTypeEnum.GanttView:
							IL_ED5:
							num2 = 249;
							control = new GanttView(false);
							IL_EE3:
							num2 = 250;
							control2 = new GanttView((GanttView)control);
							break;
						case ControlTypeEnum.PDFViewer:
							IL_5CD:
							num2 = 115;
							control = new C1FlexViewer();
							IL_5D7:
							num2 = 116;
							control2 = new PDFViewer((C1FlexViewer)control);
							break;
						case ControlTypeEnum.Map:
							IL_EF9:
							num2 = 252;
							control = new GeoMap();
							IL_F06:
							num2 = 253;
							control2 = new Map((GeoMap)control);
							break;
						case ControlTypeEnum.WebViewer:
							IL_5ED:
							num2 = 118;
							control = new WebViewer();
							IL_5F7:
							num2 = 119;
							control2 = new WebViewer((WebViewer)control);
							break;
						default:
						{
							if (controlTypeEnum != ControlTypeEnum.Table)
							{
								goto IL_1B3E;
							}
							IL_6E2:
							num2 = 139;
							TempBindingTable tempBindingTable = ooO_0O.o_O0.O_.(dataRow);
							IL_6F1:
							num2 = 140;
							string text = tempBindingTable.RelationTable;
							IL_700:
							num2 = 141;
							bool isCopy = tempBindingTable.IsCopy;
							IL_70F:
							num2 = 142;
							if (tempBindingTable.TableType == TableTypeEnum.Normal)
							{
								IL_721:
								num2 = 143;
								if (!OO_00oOO.Tables.get_Contains(text))
								{
									IL_738:
									num2 = 144;
									DataTable dataTable = this.O.OOo0O.();
									IL_746:
									num2 = 145;
									dataTable.TableName = this.Name + "_" + dataRow["Name"].ToString();
									IL_774:
									num2 = 146;
									O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable);
									IL_78B:
									num2 = 147;
									OO_00oOO.DataTables.OO0o00.0O_0o.(new DataTable(dataTable, null, null, null, O_O0OO.OoO.0OO__0ooo.()));
									IL_7AA:
									num2 = 148;
									OO_00oOO.DataTables[dataTable.TableName].o.0O000_.();
									IL_7C6:
									num2 = 149;
									OO_00oOO.DataTables[dataTable.TableName].AddByCode = true;
									IL_7E3:
									num2 = 150;
									O_0 a_ = new O_0(O_O0OO.o__.O.(), dataTable);
									IL_7F7:
									num2 = 151;
									Table table2 = new Table(a_);
									IL_806:
									num2 = 152;
									table2.TableType = TableTypeEnum.SQLQuery;
									IL_814:
									num2 = 153;
									control = table2.foxGrid;
									IL_823:
									num2 = 154;
									control2 = new Table(table2.foxGrid);
									IL_837:
									num2 = 155;
									table = table2;
									IL_841:
									num2 = 156;
									OO_00oOO.Tables.Ooo.0OOoO_0.(table2);
								}
								else
								{
									IL_858:
									num2 = 158;
									if (isCopy)
									{
										IL_865:
										num2 = 159;
										if (text.IndexOf(".") > 0)
										{
											IL_87A:
											num2 = 160;
											text = text.Substring(text.LastIndexOf(".") + 1);
										}
										IL_897:
										num2 = 161;
										O_0 a_2 = new O_0(O_O0OO.OOOo.oo_OOOO_0.().Tables[text], this.Name + "_" + dataRow["Name"].ToString());
										IL_8D6:
										num2 = 162;
										Table table3 = new Table(a_2);
										IL_8E5:
										num2 = 163;
										control = table3.foxGrid;
										IL_8F4:
										num2 = 164;
										control2 = new Table(table3.foxGrid);
										IL_908:
										num2 = 165;
										table = table3;
										IL_912:
										num2 = 166;
										OO_00oOO.Tables.Ooo.0OOoO_0.(table3);
										IL_924:
										num2 = 167;
										IEnumerator enumerator = ((IEnumerable)OO_00oOO.Tables[text].foxGrid.Styles).GetEnumerator();
										while (enumerator.MoveNext())
										{
											object obj = enumerator.Current;
											CellStyle cellStyle = (CellStyle)obj;
											IL_957:
											num2 = 168;
											if (!table3.foxGrid.Styles.Contains(cellStyle.Name))
											{
												IL_977:
												num2 = 169;
												table3.foxGrid.Styles.Add(cellStyle.Name, cellStyle);
											}
											else
											{
												IL_99A:
												num2 = 171;
												table3.foxGrid.Styles[cellStyle.Name].MergeWith(cellStyle);
											}
											IL_9BF:
											num2 = 172;
										}
										IL_9D1:
										num2 = 173;
										if (enumerator is IDisposable)
										{
											(enumerator as IDisposable).Dispose();
										}
									}
									else
									{
										IL_9F4:
										num2 = 175;
										table = OO_00oOO.Tables[text];
										IL_A08:
										num2 = 176;
										control = OO_00oOO.Tables[text].foxGrid;
										IL_A21:
										num2 = 177;
										control2 = new Table(OO_00oOO.Tables[text].foxGrid);
										IL_A3F:
										num2 = 178;
										if (table.IsRelation)
										{
											IL_A51:
											num2 = 179;
											Control parent = control.Parent;
											for (;;)
											{
												IL_AA8:
												num2 = 181;
												if (parent == null)
												{
													goto Block_6;
												}
												IL_A62:
												num2 = 182;
												if (!(parent is FormPanel))
												{
													IL_A71:
													num2 = 184;
													if (parent is o_O0_0O0)
													{
														break;
													}
												}
												IL_A99:
												num2 = 187;
												parent = parent.Parent;
											}
											IL_A80:
											num2 = 185;
											((o_O0_0O0)parent).o_o.O___0o.(control);
											Block_6:;
										}
									}
								}
							}
							else
							{
								IL_AB7:
								num2 = 190;
								OleDbConnection oleDbConnection = null;
								IL_AC0:
								num2 = 191;
								O0O o0O = null;
								IL_AC9:
								num2 = 192;
								HttpClient httpClient = null;
								IL_AD2:
								num2 = 193;
								string a_3 = "";
								IL_ADF:
								num2 = 194;
								text = this.Name + "_" + dataRow["Name"].ToString();
								IL_B08:
								num2 = 195;
								if (Operators.CompareString(tempBindingTable.Connection, "", true) > 0)
								{
									IL_B23:
									num2 = 196;
									if (O_O0OO.O._o_.().ContainsKey(tempBindingTable.Connection))
									{
										IL_B3C:
										num2 = 197;
										oleDbConnection = O_O0OO.O._o_.()[tempBindingTable.Connection];
									}
									else
									{
										IL_B57:
										num2 = 199;
										if (O_O0OO.OoO__.0oO0oo.().ContainsKey(tempBindingTable.Connection))
										{
											IL_B70:
											num2 = 200;
											o0O = O_O0OO.OoO__.0oO0oo.()[tempBindingTable.Connection];
										}
									}
								}
								else
								{
									IL_B8B:
									num2 = 202;
									oleDbConnection = O_O0OO.OoO.0OO__0ooo.();
								}
								IL_B98:
								num2 = 203;
								if ((oleDbConnection == null & o0O == null) || Operators.CompareString(tempBindingTable.SelectString, "", true) == 0)
								{
									IL_BC2:
									num2 = 204;
									DataTable dataTable2 = this.O.OOo0O.();
									IL_BD0:
									num2 = 205;
									dataTable2.TableName = text;
									IL_BDF:
									num2 = 206;
									O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable2);
									IL_BF6:
									num2 = 207;
									OO_00oOO.DataTables.OO0o00.0O_0o.(new DataTable(dataTable2, null, null, null, O_O0OO.OoO.0OO__0ooo.()));
									IL_C15:
									num2 = 208;
									OO_00oOO.DataTables[text].o.0O000_.();
									IL_C2C:
									num2 = 209;
									OO_00oOO.DataTables[text].AddByCode = true;
									IL_C44:
									num2 = 210;
									O_0 a_4 = new O_0(O_O0OO.o__.O.(), dataTable2);
									IL_C58:
									num2 = 211;
									Table table4 = new Table(a_4);
									IL_C67:
									num2 = 212;
									table4.TableType = TableTypeEnum.SQLQuery;
									IL_C75:
									num2 = 213;
									control = table4.foxGrid;
									IL_C84:
									num2 = 214;
									control2 = new Table(table4.foxGrid);
									IL_C98:
									num2 = 215;
									table = table4;
									IL_CA2:
									num2 = 216;
									OO_00oOO.Tables.Ooo.0OOoO_0.(table4);
								}
								else
								{
									IL_CB9:
									num2 = 218;
									if (tempBindingTable.TableType == TableTypeEnum.SQLTable)
									{
										IL_CC9:
										num2 = 219;
										a_3 = "?";
									}
									IL_CD6:
									num2 = 220;
									string text2;
									if (oleDbConnection != null)
									{
										IL_CE0:
										num2 = 221;
										text2 = Oo00.o0_o._O_.(oleDbConnection, tempBindingTable.SelectString, false);
									}
									else
									{
										IL_CFC:
										num2 = 223;
										text2 = Oo00.o0_o._O_.(o0O.OO.OoO0., tempBindingTable.SelectString, false);
										IL_D18:
										num2 = 224;
										httpClient = o0O.oO0_0.o.();
										IL_D27:
										num2 = 225;
										httpClient.Select = text2;
										IL_D36:
										num2 = 226;
										if (tempBindingTable.TableType == TableTypeEnum.SQLTable)
										{
											IL_D46:
											num2 = 227;
											Dictionary<string, string> dictionary = httpClient.FormData;
											string key = "Action";
											int num3 = 1;
											dictionary[key] = num3.ToString();
										}
										else
										{
											IL_D69:
											num2 = 229;
											Dictionary<string, string> dictionary2 = httpClient.FormData;
											string key2 = "Action";
											int num3 = 2;
											dictionary2[key2] = num3.ToString();
										}
									}
									IL_D8A:
									num2 = 230;
									o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, text2, text, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, a_3, true, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, null, tempBindingTable.Connection, httpClient);
									IL_DC3:
									num2 = 231;
									if (!OO_00oOO.DataTables.Contains(text))
									{
										goto IL_1B3E;
									}
									IL_DDA:
									num2 = 233;
									OO_00oOO.DataTables[text].o.0O000_.();
									IL_DF1:
									num2 = 234;
									OO_00oOO.DataTables[text].AddByCode = true;
									IL_E09:
									num2 = 235;
									Table table5 = new Table(O_O0OO.o__.O.()[text]);
									IL_E22:
									num2 = 236;
									table5.TableType = tempBindingTable.TableType;
									IL_E36:
									num2 = 237;
									control = table5.foxGrid;
									IL_E45:
									num2 = 238;
									control2 = new Table(table5.foxGrid);
									IL_E59:
									num2 = 239;
									table = table5;
									IL_E63:
									num2 = 240;
									OO_00oOO.Tables.Ooo.0OOoO_0.(table5);
								}
							}
							break;
						}
						}
						IL_F3D:
						num2 = 260;
						control.Tag = RuntimeHelpers.GetObjectValue(dataRow["key"]);
						IL_F5B:
						num2 = 261;
						Control control3 = control;
						IL_F65:
						num2 = 262;
						control3.Font = new Font(control3.Font.Name, control3.Font.Size, control3.Font.Style);
						IL_F9B:
						control3 = null;
						IL_F9E:
						num2 = 264;
						control.ForeColor = control.ForeColor;
						IL_FB2:
						num2 = 265;
						A_0.Add(control);
						IL_FC0:
						num2 = 266;
						if (table != null)
						{
							IL_FCD:
							num2 = 267;
							table.oO_o_0o._0oooo.(true);
							IL_FDB:
							num2 = 268;
							string text3 = string.Concat(new string[]
							{
								OO_00oOO.ProjectPath,
								"Bin\\",
								o0OoOOoOOo0.oo00o.0OoO.(""),
								".Table.",
								Conversions.ToString(dataRow["Key"]),
								".dll"
							});
							IL_102F:
							num2 = 269;
							if (OO_00oOO.FileSys.FileExists(text3))
							{
								IL_1046:
								num2 = 270;
								byte[] rawAssembly = File.ReadAllBytes(text3);
								IL_1055:
								num2 = 271;
								if (table.TableType != TableTypeEnum.Normal || table.IsCopy)
								{
									IL_106D:
									num2 = 272;
									table.o0__OOo0._oO. = Assembly.Load(rawAssembly);
								}
								IL_1081:
								num2 = 273;
								if (table.TableType != TableTypeEnum.Normal)
								{
									IL_1090:
									num2 = 274;
									table.DataTable.o_0_00_.oo0O0. = Assembly.Load(rawAssembly);
									IL_10A9:
									num2 = 275;
									table.DataTable.o0O.O_0.(table.DataTable.o_0_00_.oo0O0.);
								}
							}
						}
						IL_10C7:
						num2 = 276;
						control2.o.__O0O. = this;
						IL_10D5:
						num2 = 277;
						control2.Printable = true;
						IL_10E3:
						num2 = 278;
						control.Dock = DockStyle.None;
						IL_10F1:
						num2 = 279;
						o_O_o_oOoo__.OOOO_OO._oo.(control2, Conversions.ToString(dataRow["Property"]), '\v');
						IL_1111:
						num2 = 280;
						if (control2 is PictureViewer)
						{
							IL_1123:
							num2 = 281;
							PictureViewer pictureViewer = (PictureViewer)control2;
							IL_1132:
							num2 = 282;
							if (pictureViewer.Remote && Operators.CompareString(pictureViewer.Host, "", true) > 0)
							{
								IL_115C:
								num2 = 283;
								PictureViewer pictureViewer2 = (PictureViewer)control;
								IL_116B:
								num2 = 284;
								FTPClient ftpclient = new FTPClient();
								IL_1178:
								num2 = 285;
								ftpclient.Host = pictureViewer.Host;
								IL_118C:
								num2 = 286;
								ftpclient.Account = pictureViewer.Account;
								IL_11A0:
								num2 = 287;
								ftpclient.RootDir = pictureViewer.RootDir;
								IL_11B4:
								num2 = 288;
								ftpclient.Password = pictureViewer.Password;
								IL_11C8:
								num2 = 289;
								ftpclient.UTF8 = pictureViewer.UTF8;
								IL_11DC:
								num2 = 290;
								ftpclient.Port = pictureViewer.Port;
								IL_11F0:
								num2 = 291;
								pictureViewer2.FTPclient = ftpclient;
							}
							IL_11FF:
							num2 = 292;
							if (this.o_0.o0..ContainsKey(control2))
							{
								IL_1217:
								num2 = 293;
								string a_5 = this.o_0.o0.[control2];
								IL_122C:
								num2 = 294;
								DataCol dataCol = Oo00.ooO.ooo.(a_5);
								IL_123B:
								num2 = 295;
								if (dataCol != null)
								{
									IL_1245:
									num2 = 296;
									dataCol.DefaultFolder = pictureViewer.FolderName;
									IL_1259:
									num2 = 297;
									dataCol.SourceFolder = pictureViewer.SourceFolder;
									IL_126D:
									num2 = 298;
									dataCol.FileFilter = pictureViewer.FileFilter;
									IL_1281:
									num2 = 299;
									dataCol.AutoCopyAttachFile = pictureViewer.AutoCopyAttachFile;
									IL_1295:
									num2 = 300;
									dataCol.AutoDeleteAttachFile = pictureViewer.AutoDeleteAttachFile;
								}
							}
							IL_12A9:
							pictureViewer = null;
						}
						IL_12AC:
						num2 = 302;
						if (control2 is FileManager)
						{
							IL_12BE:
							num2 = 303;
							FileManager fileManager = (FileManager)control2;
							IL_12CD:
							num2 = 304;
							if (fileManager.Remote && Operators.CompareString(fileManager.Host, "", true) > 0)
							{
								IL_12F7:
								num2 = 305;
								FileManager fileManager2 = (FileManager)control;
								IL_1306:
								num2 = 306;
								FTPClient ftpclient2 = new FTPClient();
								IL_1313:
								num2 = 307;
								ftpclient2.Host = fileManager.Host;
								IL_1327:
								num2 = 308;
								ftpclient2.Account = fileManager.Account;
								IL_133B:
								num2 = 309;
								ftpclient2.RootDir = fileManager.RootDir;
								IL_134F:
								num2 = 310;
								ftpclient2.Password = fileManager.Password;
								IL_1363:
								num2 = 311;
								ftpclient2.UTF8 = fileManager.UTF8;
								IL_1377:
								num2 = 312;
								ftpclient2.Port = fileManager.Port;
								IL_138B:
								num2 = 313;
								fileManager2.FTPclient = ftpclient2;
							}
							IL_139A:
							num2 = 314;
							if (this.o_0.o0..ContainsKey(control2))
							{
								IL_13B2:
								num2 = 315;
								string a_6 = this.o_0.o0.[control2];
								IL_13C7:
								num2 = 316;
								DataCol dataCol2 = Oo00.ooO.ooo.(a_6);
								IL_13D6:
								num2 = 317;
								if (dataCol2 != null)
								{
									IL_13E0:
									num2 = 318;
									dataCol2.DefaultFolder = fileManager.FolderName;
									IL_13F4:
									num2 = 319;
									dataCol2.SourceFolder = fileManager.SourceFolder;
									IL_1408:
									num2 = 320;
									dataCol2.FileFilter = fileManager.FileFilter;
									IL_141C:
									num2 = 321;
									dataCol2.AutoCopyAttachFile = fileManager.AutoCopyAttachFile;
									IL_1430:
									num2 = 322;
									dataCol2.AutoDeleteAttachFile = fileManager.AutoDeleteAttachFile;
								}
							}
							IL_1444:
							fileManager = null;
						}
						IL_1447:
						num2 = 324;
						if (control2 is PictureBox)
						{
							IL_1459:
							num2 = 325;
							PictureBox pictureBox = (PictureBox)control2;
							IL_1468:
							num2 = 326;
							if (pictureBox.Remote && Operators.CompareString(pictureBox.Host, "", true) > 0)
							{
								IL_1492:
								num2 = 327;
								CustomPictureBox customPictureBox = (CustomPictureBox)control;
								IL_14A1:
								num2 = 328;
								FTPClient ftpclient3 = new FTPClient();
								IL_14AE:
								num2 = 329;
								ftpclient3.Host = pictureBox.Host;
								IL_14C2:
								num2 = 330;
								ftpclient3.Account = pictureBox.Account;
								IL_14D6:
								num2 = 331;
								ftpclient3.Password = pictureBox.Password;
								IL_14EA:
								num2 = 332;
								ftpclient3.UTF8 = pictureBox.UTF8;
								IL_14FE:
								num2 = 333;
								ftpclient3.Port = pictureBox.Port;
								IL_1512:
								num2 = 334;
								customPictureBox.FTPClient = ftpclient3;
							}
							IL_1521:
							num2 = 335;
							if (this.o_0.o0..ContainsKey(control2))
							{
								IL_1536:
								num2 = 336;
								string a_7 = this.o_0.o0.[control2];
								IL_154B:
								num2 = 337;
								DataCol dataCol3 = Oo00.ooO.ooo.(a_7);
								IL_155A:
								num2 = 338;
								if (dataCol3 != null)
								{
									IL_1564:
									num2 = 339;
									dataCol3.DefaultFolder = pictureBox.FolderName;
								}
							}
							IL_1578:
							pictureBox = null;
						}
						IL_157B:
						num2 = 341;
						this.O.00oo_OO0O.(control, controlTypeEnum);
						IL_158B:
						num2 = 342;
						if (!(control is CustomPictureBox))
						{
							IL_159A:
							num2 = 343;
							this.Pane.ToolTip1.SetToolTip(control, control2.ToolTipText);
						}
						IL_15B9:
						num2 = 344;
						if (controlTypeEnum <= ControlTypeEnum.NavBar)
						{
							if (controlTypeEnum == ControlTypeEnum.Button)
							{
								IL_184D:
								num2 = 378;
								((Button)control).UseVisualStyleBackColor = true;
								goto IL_1B3E;
							}
							switch (controlTypeEnum)
							{
							case ControlTypeEnum.GroupBox:
							case ControlTypeEnum.Panel:
								break;
							case ControlTypeEnum.SplitContainer:
							{
								IL_166D:
								num2 = 350;
								SplitContainer splitContainer = (SplitContainer)control;
								IL_167C:
								num2 = 351;
								splitContainer.SplitterDistance = ((SplitContainer)control2).SplitterDistance2;
								IL_1695:
								num2 = 352;
								splitContainer.FixedPanel = ((SplitContainer)control2).FixedPanel2;
								IL_16AE:
								num2 = 353;
								this.o0000o_Oo0.0_.(splitContainer.Panel1.Controls, dataRow, 1);
								IL_16C9:
								num2 = 354;
								this.o0000o_Oo0.0_.(splitContainer.Panel2.Controls, dataRow, 2);
								IL_16E4:
								splitContainer = null;
								goto IL_1B3E;
							}
							case ControlTypeEnum.PictureBox:
								IL_1648:
								num2 = 348;
								this.o0000o_Oo0.0_.(((CustomPictureBox)control).PictureBox1.Controls, dataRow, -1);
								goto IL_1B3E;
							case ControlTypeEnum.TabControl:
							{
								IL_16EC:
								num2 = 357;
								C1DockingTab c1DockingTab = (C1DockingTab)control;
								IL_16FB:
								num2 = 358;
								int num3 = c1DockingTab.TabPages.Count - 1;
								for (int j = 0; j <= num3; j++)
								{
									IL_1716:
									num2 = 359;
									this.o0000o_Oo0.0_.(c1DockingTab.TabPages[j].Controls, dataRow, j);
									IL_1739:
									num2 = 360;
								}
								IL_174B:
								c1DockingTab = null;
								goto IL_1B3E;
							}
							default:
							{
								if (controlTypeEnum != ControlTypeEnum.NavBar)
								{
									goto IL_1B3E;
								}
								IL_1753:
								num2 = 363;
								C1NavBar c1NavBar = (C1NavBar)control;
								IL_1762:
								num2 = 364;
								int num4 = c1NavBar.Panels.Count - 1;
								for (int k = 0; k <= num4; k++)
								{
									IL_177D:
									num2 = 365;
									this.o0000o_Oo0.0_.(c1NavBar.Panels[k].Controls, dataRow, k);
									IL_17A0:
									num2 = 366;
								}
								IL_17B2:
								c1NavBar = null;
								goto IL_1B3E;
							}
							}
						}
						else if (controlTypeEnum <= ControlTypeEnum.Gauges)
						{
							if (controlTypeEnum == ControlTypeEnum.RecordGrid)
							{
								IL_1865:
								num2 = 380;
								OooOo0___oO oooOo0___oO = (OooOo0___oO)control;
								IL_1874:
								num2 = 381;
								oooOo0___oO.Ooo_oO._0O.();
								IL_1881:
								num2 = 382;
								oooOo0___oO.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
								IL_188F:
								oooOo0___oO = null;
								goto IL_1B3E;
							}
							if (controlTypeEnum != ControlTypeEnum.Gauges)
							{
								goto IL_1B3E;
							}
							IL_1897:
							num2 = 385;
							C1Gauge c1Gauge = (C1Gauge)control;
							IL_18A6:
							num2 = 386;
							c1Gauge.ItemClick += this.Oo.o__00_.;
							IL_18BF:
							num2 = 387;
							c1Gauge.ItemDoubleClick += this.o_.0_o0_O_000.;
							IL_18D8:
							num2 = 388;
							c1Gauge.ItemStateChanged += this.Oo0_OOOo.Oo.;
							IL_18F1:
							num2 = 389;
							c1Gauge.ItemMouseDown += this.o0oo_o.OO.;
							IL_190A:
							num2 = 390;
							c1Gauge.ItemMouseUp += this.Oo0_OOOo.Oo.;
							IL_1923:
							num2 = 391;
							c1Gauge.ItemMouseEnter += this.o0oo_o.OO.;
							IL_193C:
							num2 = 392;
							c1Gauge.ItemMouseLeave += this.O_00.o.;
							IL_1955:
							num2 = 393;
							c1Gauge.ItemMouseMove += this.O_00.o.;
							IL_196E:
							c1Gauge = null;
							IL_1971:
							num2 = 395;
							IEnumerator enumerator2 = ((C1Gauge)control).Gauges.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								object obj2 = enumerator2.Current;
								C1GaugeBase c1GaugeBase = (C1GaugeBase)obj2;
								IL_199D:
								num2 = 396;
								c1GaugeBase.PointerDragMove += this.o_.0_o000o.;
								IL_19B6:
								num2 = 397;
								c1GaugeBase.PointerDragBegin += this.O.0o00__.;
								IL_19CF:
								num2 = 398;
								c1GaugeBase.PointerDragEnd += this.o_.o_oOo0O.;
								IL_19E8:
								num2 = 399;
								c1GaugeBase.PointerDragCancel += this.oO_.0_0.;
								IL_1A01:
								num2 = 400;
								c1GaugeBase.ItemClick += this.Oo.o__00_.;
								IL_1A1A:
								num2 = 401;
								c1GaugeBase.ItemDoubleClick += this.o_.0_o0_O_000.;
								IL_1A33:
								num2 = 402;
								c1GaugeBase.ItemStateChanged += this.Oo0_OOOo.Oo.;
								IL_1A4C:
								num2 = 403;
								c1GaugeBase.ItemMouseDown += this.o0oo_o.OO.;
								IL_1A65:
								num2 = 404;
								c1GaugeBase.ItemMouseUp += this.Oo0_OOOo.Oo.;
								IL_1A7E:
								num2 = 405;
								c1GaugeBase.ItemMouseEnter += this.o0oo_o.OO.;
								IL_1A97:
								num2 = 406;
								c1GaugeBase.ItemMouseLeave += this.O_00.o.;
								IL_1AB0:
								num2 = 407;
								c1GaugeBase.ItemMouseMove += this.O_00.o.;
								IL_1AC9:
								num2 = 408;
								c1GaugeBase.FormatLabel += this.O_.O__Oo.;
								IL_1AE2:
								num2 = 409;
								c1GaugeBase.PointerValueChanged += this.O_00.o.;
								IL_1AFB:
								num2 = 410;
							}
							IL_1B0D:
							num2 = 411;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
							IL_1B28:
							num2 = 412;
							this.o0000o_Oo0.0_.(control.Controls, dataRow, -1);
							goto IL_1B3E;
						}
						else if (controlTypeEnum != ControlTypeEnum.Map)
						{
							if (controlTypeEnum != ControlTypeEnum.Table)
							{
								goto IL_1B3E;
							}
							IL_17BA:
							num2 = 369;
							Table table6 = (Table)control2;
							IL_17C9:
							num2 = 370;
							if (Operators.CompareString(table6.ColumnList, "", true) > 0)
							{
								IL_17E4:
								num2 = 371;
								table.SetColVisibleWidth(table6.ColumnList);
							}
							IL_17F8:
							num2 = 372;
							table.FocusRect = table6.FocusRect;
							IL_180C:
							num2 = 373;
							if (table.TableType == TableTypeEnum.SQLQuery)
							{
								IL_181C:
								num2 = 374;
								table.DataTable.AllowEdit = false;
								goto IL_1B3E;
							}
							IL_1834:
							num2 = 376;
							table.AllowEdit = table6.AllowEdit;
							goto IL_1B3E;
						}
						IL_162D:
						num2 = 346;
						this.o0000o_Oo0.0_.(control.Controls, dataRow, -1);
					}
					IL_1B3E:
					num2 = 414;
				}
				IL_1B54:
				goto IL_2222;
				IL_1B59:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_21E3:
				goto IL_2217;
				IL_21E5:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_21F5:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_21E5;
			}
			IL_2217:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2222:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x001C2E20 File Offset: 0x001C1020
		private DataTable <<EMPTY_NAME>>()
		{
			DataTable dataTable = new DataTable();
			string text = "一二三四五六七八九十";
			int num = 0;
			do
			{
				dataTable.Columns.Add("第" + Conversions.ToString(text[num]) + "列", typeof(string));
				num++;
			}
			while (num <= 9);
			int num2 = 0;
			do
			{
				dataTable.Rows.Add(dataTable.NewRow());
				num2++;
			}
			while (num2 <= 9);
			dataTable.AcceptChanges();
			return dataTable;
		}

		/// <summary>
		/// 关闭窗口
		/// </summary>
		// Token: 0x06003E40 RID: 15936 RVA: 0x001C2E98 File Offset: 0x001C1098
		[oO0oooo("0710")]
		public void Close()
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.Pane == null || this.Pane.IsDisposed || this.Pane.Parent == null)
				{
					goto IL_34D;
				}
				IL_34:
				num2 = 5;
				if (this.Pane.FindForm() != null && this.FormStyle != FormStyleEnum.DropDownForm)
				{
					goto IL_80;
				}
				IL_4C:
				num2 = 6;
				if (this.Pane.Parent == null)
				{
					goto IL_34D;
				}
				IL_5E:
				num2 = 7;
				this.Pane.Parent.Controls.Remove(this.Pane);
				goto IL_34D;
				IL_80:
				num2 = 9;
				this.Pane.O00O00o_oOo.o_. = 1;
				IL_8F:
				num2 = 10;
				if (!this.IsMain && this.FormStyle != FormStyleEnum.并列)
				{
					goto IL_11B;
				}
				IL_A2:
				num2 = 11;
				FormEventArgs formEventArgs = new FormEventArgs(this);
				IL_AC:
				num2 = 12;
				string a_ = "BeforeClose_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				IL_D0:
				num2 = 13;
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					formEventArgs
				}, false, this.mmname, false);
				IL_F3:
				num2 = 14;
				if (formEventArgs.Cancel && this.O_0.O00o_00_O.)
				{
					goto IL_34D;
				}
				IL_109:
				num2 = 17;
				this.oOO0OO0O.o0oO.();
				IL_112:
				num2 = 18;
				this.OoOO_._0.();
				IL_11B:
				num2 = 19;
				if (!this.IsMain)
				{
					goto IL_18E;
				}
				IL_126:
				num2 = 20;
				if (this.Pane.FindForm() == Main.OO_O.o.)
				{
					goto IL_153;
				}
				IL_13B:
				num2 = 21;
				this.Pane.FindForm().Close();
				goto IL_326;
				IL_153:
				num2 = 23;
				this.Pane.Parent.Text = "主窗口";
				IL_16B:
				num2 = 24;
				this.Pane.Parent.Controls.Remove(this.Pane);
				goto IL_326;
				IL_18E:
				num2 = 26;
				if (this.FormStyle != FormStyleEnum.停靠 && this.FormStyle != FormStyleEnum.共有)
				{
					goto IL_1DA;
				}
				IL_1A3:
				num2 = 27;
				if (this.O_0.O00o_00_O. == null || this.O_0.O00o_00_O..FindForm() == null)
				{
					goto IL_1DA;
				}
				IL_1BB:
				num2 = 28;
				if (!this.O_0.O00o_00_O..AutoHiding)
				{
					goto IL_1DA;
				}
				IL_1CB:
				num2 = 29;
				this.O_0.O00o_00_O..AutoHiding = false;
				IL_1DA:
				num2 = 30;
				switch (this.FormStyle)
				{
				case FormStyleEnum.并列:
				{
					IL_293:
					num2 = 43;
					Control parent = this.Pane.Parent;
					IL_2A3:
					num2 = 44;
					parent.Controls.Remove(this.Pane);
					IL_2B8:
					num2 = 45;
					parent.Parent.Controls.Remove(parent);
					IL_2CE:
					num2 = 46;
					parent.Dispose();
					break;
				}
				case FormStyleEnum.停靠:
				{
					IL_243:
					num2 = 34;
					Control parent2 = this.Pane.Parent;
					for (;;)
					{
						IL_287:
						num2 = 36;
						if (parent2 == null)
						{
							goto Block_10;
						}
						IL_255:
						num2 = 37;
						if (parent2 is o_O0_0O0)
						{
							break;
						}
						IL_27B:
						num2 = 40;
						parent2 = parent2.Parent;
					}
					IL_261:
					num2 = 38;
					((o_O0_0O0)parent2).o_o.O___0o.(this.Pane);
					Block_10:
					break;
				}
				case FormStyleEnum.独立:
				case FormStyleEnum.模式:
				case FormStyleEnum.PopupForm:
				{
					IL_2DA:
					num2 = 48;
					Form form = this.Pane.FindForm();
					IL_2EA:
					num2 = 49;
					if (form.Visible)
					{
						goto IL_302;
					}
					IL_2F6:
					num2 = 50;
					this.O_.O__Oo.(form, null);
					IL_302:
					num2 = 51;
					form.Close();
					IL_30C:
					num2 = 52;
					if (this.o0_o.0_o_.)
					{
						break;
					}
					IL_317:
					num2 = 53;
					form.Controls.Clear();
					break;
				}
				case FormStyleEnum.共有:
					IL_211:
					num2 = 32;
					((C1DockingTab)this.Pane.Parent.Parent).Close((C1DockingTabPage)this.Pane.Parent);
					break;
				}
				IL_326:
				num2 = 55;
				if (this.Pane == null || this.Pane.IsDisposed)
				{
					goto IL_34D;
				}
				IL_33E:
				num2 = 57;
				this.Pane.O00O00o_oOo.o_. = 0;
				IL_34D:
				goto IL_487;
				IL_352:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_448:
				goto IL_47C;
				IL_44A:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_45A:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_44A;
			}
			IL_47C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_487:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x001C3350 File Offset: 0x001C1550
		private oo00o_ <<EMPTY_NAME>>()
		{
			return new oo00o_
			{
				ShowSingleTab = false,
				ShowCaption = true,
				Alignment = TabAlignment.Bottom,
				CanCloseTabs = true,
				CanAutoHide = true
			};
		}

		/// <summary>
		/// 在非所有者表打开窗口
		/// </summary>
		/// <param name="OtherTableName">指定目标表名</param>
		/// <param name="Width">指定停靠区域的宽度或高度，单位为像素，如果目标停靠区域已经有窗口打开，则此参数无效</param>
		// Token: 0x06003E42 RID: 15938 RVA: 0x001C337C File Offset: 0x001C157C
		[oO0oooo("2139")]
		public void OpenTo(string OtherTableName, int Width = 2147483647)
		{
			int num2;
			int num4;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				if (this.OooO.__.)
				{
					goto IL_A3;
				}
				IL_0D:
				num = 3;
				this.OooO.__. = true;
				IL_16:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_1D:
				num = 5;
				if (!this.Opened || Operators.CompareString(this.o_o0__00._., OtherTableName, true) == 0)
				{
					goto IL_3E;
				}
				IL_36:
				num = 6;
				this.Close();
				IL_3E:
				num = 7;
				if (!OO_00oOO.Tables.get_Contains(OtherTableName) || OO_00oOO.Tables[OtherTableName].TableType != TableTypeEnum.Normal || OO_00oOO.Tables[OtherTableName].IsCopy)
				{
					goto IL_8F;
				}
				IL_71:
				num = 8;
				Oo0__Oo a_ = Main.OO_O.o..o0_o_o_0.0O.(OtherTableName);
				IL_7F:
				num = 9;
				this.ooO0O.00.(a_, Width, int.MaxValue);
				IL_8F:
				num = 10;
				this.OooO.__. = false;
				IL_99:
				num = 11;
				this.o_o0__00._. = OtherTableName;
				IL_A3:
				goto IL_122;
				IL_A5:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_E3:
				goto IL_117;
				IL_E5:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_F5:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_E5;
			}
			IL_117:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_122:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x001C34C4 File Offset: 0x001C16C4
		public System.Threading.Tasks.Task OpenAsync(params object[] args)
		{
			Form.o0OO o0OO = default(Form.o0OO);
			o0OO.o.0_O_. = this;
			o0OO.o.0_O_. = args;
			o0OO.o.0_O_. = -1;
			o0OO.o.0_O_. = AsyncTaskMethodBuilder.Create();
			o0OO.o.0_O_..Start<Form.o0OO>(ref o0OO);
			return o0OO.o.0_O_..Task;
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x001C3518 File Offset: 0x001C1718
		public void CloseAsync()
		{
			Form.O_o0000O_ o_o0000O_ = default(Form.O_o0000O_);
			o_o0000O_.O.O__00. = this;
			o_o0000O_.O.O__00. = -1;
			o_o0000O_.O.O__00. = AsyncVoidMethodBuilder.Create();
			o_o0000O_.O.O__00..Start<Form.O_o0000O_>(ref o_o0000O_);
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x001C3558 File Offset: 0x001C1758
		public void MoveAsync(int x, int y)
		{
			Form.O_O_0OO o_O_0OO = default(Form.O_O_0OO);
			o_O_0OO.o00o_0.0o_0oo0. = this;
			o_O_0OO.o0__O._O0O. = x;
			o_O_0OO.OO_0.o_O. = y;
			o_O_0OO.O.O__00. = -1;
			o_O_0OO.O.O__00. = AsyncVoidMethodBuilder.Create();
			o_O_0OO.O.O__00..Start<Form.O_O_0OO>(ref o_O_0OO);
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x001C35A8 File Offset: 0x001C17A8
		public void Open(params object[] args)
		{
			if (args.Length == 0)
			{
				this.Open(int.MaxValue, int.MaxValue);
				return;
			}
			if (args.Length == 1)
			{
				this.Open(Conversions.ToInteger(args[0]), int.MaxValue);
				return;
			}
			if (args.Length == 2)
			{
				this.Open(Conversions.ToInteger(args[0]), Conversions.ToInteger(args[1]));
			}
		}

		/// <summary>
		/// 打开窗口
		/// </summary>
		/// <param name="x">用户设置独立窗口或模式窗口的水平位置，单位为像素，默认居中</param>
		/// <param name="y">用户设置独立窗口或模式窗口的垂直位置，单位为像素，默认居中</param>
		// Token: 0x06003E47 RID: 15943 RVA: 0x001C3604 File Offset: 0x001C1804
		[oO0oooo("0708")]
		public void Open(int x = 2147483647, int y = 2147483647)
		{
			int num2;
			int num4;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				if (this.OooO.__.)
				{
					goto IL_9F;
				}
				IL_0D:
				num = 3;
				this.OooO.__. = true;
				IL_16:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_1D:
				num = 5;
				if (!this.Opened || Operators.CompareString(this.o_o0__00._., this.TableName, true) == 0)
				{
					goto IL_43;
				}
				IL_3B:
				num = 6;
				this.Close();
				IL_43:
				num = 7;
				Oo0__Oo oo0__Oo = Main.OO_O.o..o0_o_o_0.0O.(this.TableName);
				IL_56:
				num = 8;
				if (oo0__Oo != null || OO_00oOO.MainTable == null)
				{
					goto IL_7A;
				}
				IL_62:
				num = 9;
				oo0__Oo = Main.OO_O.o..o0_o_o_0.0O.(OO_00oOO.MainTable.Name);
				IL_7A:
				num = 10;
				this.ooO0O.00.(oo0__Oo, x, y);
				IL_86:
				num = 11;
				this.OooO.__. = false;
				IL_90:
				num = 12;
				this.o_o0__00._. = this.TableName;
				IL_9F:
				goto IL_125;
				IL_A4:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_E6:
				goto IL_11A;
				IL_E8:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_F8:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_E8;
			}
			IL_11A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_125:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x001C3750 File Offset: 0x001C1950
		private void <<EMPTY_NAME>>(Oo0__Oo A_0, int A_1 = 2147483647, int A_2 = 2147483647)
		{
			int num2;
			int num4;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				FormStyleEnum formStyle = this.FormStyle;
				if (formStyle > FormStyleEnum.停靠 && formStyle != FormStyleEnum.主窗口)
				{
					goto IL_54;
				}
				IL_11:
				num = 3;
				if (A_0 != null || Operators.CompareString(this.TableName, "", true) <= 0)
				{
					goto IL_54;
				}
				IL_2A:
				num = 4;
				MessageBox.Show("窗口[" + this.Name + "]指定的所有者表不存在，无法打开此窗口!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_E9B;
				IL_54:
				num = 7;
				this.O_0.O00o_00_O. = null;
				IL_5D:
				num = 8;
				this.O_0.O00o_00_O. = true;
				IL_66:
				num = 9;
				if (this.Pane != null && !this.Pane.IsDisposed)
				{
					goto IL_87;
				}
				IL_7E:
				num = 10;
				this.o.0_o00O.();
				IL_87:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_8E:
				num = 12;
				if (this.Pane.FindForm() != null)
				{
					goto IL_E9B;
				}
				IL_A1:
				num = 14;
				if (this.FormStyle != FormStyleEnum.DropDownForm)
				{
					goto IL_C6;
				}
				IL_AD:
				num = 15;
				this.o_oOo_0o_.0.(this.Pane, new EventArgs());
				goto IL_E9B;
				IL_C6:
				num = 17;
				if (!this.oOO_0_oo.Oo0.)
				{
					goto IL_DB;
				}
				IL_D1:
				num = 18;
				this.FormStyle = FormStyleEnum.模式;
				IL_DB:
				num = 19;
				if (this.FormStyle == FormStyleEnum.模式)
				{
					goto IL_FA;
				}
				IL_E7:
				num = 20;
				ShareLibriay.LockWindowUpdate(OO_00oOO.BaseMainForm.Handle);
				IL_FA:
				num = 21;
				this.O_o_.0o0__o0O.["Table"].ToString();
				IL_113:
				num = 22;
				if (A_0 == null && (this.FormStyle == FormStyleEnum.并列 || this.FormStyle == FormStyleEnum.停靠))
				{
					goto IL_E9B;
				}
				IL_130:
				num = 24;
				if (!this.IsMain)
				{
					goto IL_30F;
				}
				IL_13E:
				num = 25;
				IEnumerator<Form> enumerator = OO_00oOO.Forms.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Form form = enumerator.Current;
					IL_158:
					num = 26;
					if (form.IsMain && Operators.CompareString(form.TableName, this.TableName, true) == 0)
					{
						IL_179:
						num = 27;
						form.Close();
					}
					IL_183:
					num = 28;
				}
				IL_18F:
				num = 29;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_19D:
				num = 30;
				C1DockingTabPage c1DockingTabPage = A_0.O_000__.o.().TabPages[0];
				IL_1B3:
				num = 31;
				c1DockingTabPage.SuspendLayout();
				IL_1BD:
				num = 32;
				this.Pane.Visible = false;
				IL_1CC:
				num = 33;
				this.Pane.SendToBack();
				IL_1DA:
				num = 34;
				c1DockingTabPage.Controls.Add(this.Pane);
				IL_1EF:
				num = 35;
				this.Pane.Dock = DockStyle.Fill;
				IL_1FE:
				num = 36;
				c1DockingTabPage.Text = this.Text;
				IL_20E:
				num = 37;
				if (!OO_00oOO.FileSys.FileExists(O_O0OO.OOo_o.0o. + this.ImageFile))
				{
					goto IL_244;
				}
				IL_22D:
				num = 38;
				c1DockingTabPage.Image = OO_00oOO.GetImage(this.ImageFile);
				goto IL_24F;
				IL_244:
				num = 40;
				c1DockingTabPage.Image = null;
				IL_24F:
				num = 41;
				if (!this.Oo0Oo0000.__.())
				{
					goto IL_2EB;
				}
				IL_25D:
				num = 42;
				this.Pane.BringToFront();
				IL_26B:
				num = 43;
				this.Pane.Visible = true;
				IL_27A:
				num = 44;
				for (int i = c1DockingTabPage.Controls.Count - 1; i >= 0; i += -1)
				{
					IL_28F:
					num = 45;
					if (c1DockingTabPage.Controls[i] != this.Pane)
					{
						IL_2A8:
						num = 47;
						if (!(c1DockingTabPage.Controls[i] is o_O0_0O0))
						{
							IL_2C0:
							num = 49;
							c1DockingTabPage.Controls.Remove(c1DockingTabPage.Controls[i]);
						}
					}
					IL_2DD:
					num = 50;
				}
				IL_2EB:
				num = 51;
				c1DockingTabPage.ResumeLayout();
				IL_2F5:
				c1DockingTabPage = null;
				IL_2F8:
				num = 53;
				this.oO._0oOo.();
				IL_301:
				num = 54;
				this.Oo_O__o0o.0_.();
				goto IL_E5F;
				IL_30F:
				num = 56;
				switch (this.FormStyle)
				{
				case FormStyleEnum.并列:
				{
					IL_346:
					num = 58;
					if (A_0.O_000__.o.().TabPages.Count != 1)
					{
						goto IL_3A5;
					}
					IL_35C:
					num = 59;
					A_0.O_000__.o.().TextDirection = TabTextDirectionEnum.Horizontal;
					IL_36B:
					num = 60;
					A_0.O_000__.o.().Alignment = this.TabAlignment;
					IL_37F:
					num = 61;
					Main.OO_O.o..Oo.oOo_o0Oo0.(Main.OO_O.o..o00o_OO_o_._o.(), new object[]
					{
						A_0.O_000__.o.()
					});
					IL_3A5:
					num = 62;
					O0_OoOoO o0_OoOoO = new O0_OoOoO();
					IL_3AF:
					num = 63;
					o0_OoOoO.Text = this.Text;
					IL_3BF:
					num = 64;
					o0_OoOoO.Controls.Add(this.Pane);
					IL_3D4:
					num = 65;
					A_0.O_000__.o.().TabPages.Add(o0_OoOoO);
					IL_3EA:
					num = 66;
					if (!OO_00oOO.FileSys.FileExists(O_O0OO.OOo_o.0o. + this.ImageFile))
					{
						goto IL_41E;
					}
					IL_409:
					num = 67;
					o0_OoOoO.Image = OO_00oOO.GetImage(this.ImageFile);
					IL_41E:
					num = 68;
					this.Pane.Dock = DockStyle.Fill;
					IL_42D:
					num = 69;
					this.o_0._O.();
					IL_436:
					num = 70;
					if (!this.Oo0Oo0000.__.())
					{
						goto IL_E9B;
					}
					IL_444:
					num = 73;
					if (this.Pane == null)
					{
						break;
					}
					IL_452:
					num = 74;
					this.oO._0oOo.();
					IL_45B:
					num = 75;
					this.Oo_O__o0o.0_.();
					break;
				}
				case FormStyleEnum.停靠:
				{
					IL_92B:
					num = 147;
					o_O0_0O0 o_O0_0O;
					switch (this.DockArea)
					{
					case DockAreaEnum.右:
						IL_962:
						num = 151;
						o_O0_0O = A_0.o__0_.o0OoOOO.();
						goto IL_990;
					case DockAreaEnum.左:
						IL_952:
						num = 149;
						o_O0_0O = A_0.O__O.o_oOO.();
						goto IL_990;
					case DockAreaEnum.上:
						IL_972:
						num = 153;
						o_O0_0O = A_0.O_000__.o.();
						goto IL_990;
					}
					IL_982:
					num = 155;
					o_O0_0O = A_0.O._o_00__.();
					IL_990:
					num = 157;
					if (A_1 == 2147483647 || A_2 != 2147483647)
					{
						goto IL_9B6;
					}
					IL_9A6:
					num = 158;
					o_O0_0O.OoOoo_O0o0.0O_.(A_1);
					goto IL_A0F;
					IL_9B6:
					num = 160;
					switch (this.DockArea)
					{
					case DockAreaEnum.右:
					case DockAreaEnum.左:
						IL_9DD:
						num = 162;
						o_O0_0O.OoOoo_O0o0.0O_.(this.Pane.Width);
						break;
					case DockAreaEnum.底:
					case DockAreaEnum.上:
						IL_9F7:
						num = 164;
						o_O0_0O.OoOoo_O0o0.0O_.(this.Pane.Height);
						break;
					}
					IL_A0F:
					num = 166;
					C1DockingTabPage c1DockingTabPage2 = o_O0_0O.OO_o0_oO.0.(this.Pane, this.Text, this.DockTitle, OO_00oOO.GetImage(this.ImageFile), null, false);
					IL_A3D:
					num = 167;
					if (!this.Oo0Oo0000.__.())
					{
						goto IL_E9B;
					}
					IL_A4E:
					num = 170;
					c1DockingTabPage2.TabVisible = true;
					IL_A5C:
					num = 171;
					c1DockingTabPage2.Parent.Visible = true;
					IL_A6F:
					num = 172;
					this.oO._0oOo.();
					IL_A7B:
					num = 173;
					this.Oo_O__o0o.0_.();
					break;
				}
				case FormStyleEnum.独立:
				case FormStyleEnum.模式:
				case FormStyleEnum.PopupForm:
				{
					IL_A8C:
					num = 175;
					if (this.FormStyle != FormStyleEnum.PopupForm)
					{
						goto IL_AAA;
					}
					IL_A9B:
					num = 176;
					Form form2 = new oOo_O_0O();
					goto IL_AB7;
					IL_AAA:
					num = 178;
					form2 = new O0oO_0();
					IL_AB7:
					num = 179;
					form2.FormClosed += this.O_.O__Oo.;
					IL_AD0:
					num = 180;
					form2.FormClosing += this.O_.O__Oo.;
					IL_AE9:
					num = 181;
					form2.Activated += this.o_.oo_0.;
					IL_B02:
					num = 182;
					form2.Deactivate += this.ooo._O__oO.;
					IL_B1B:
					num = 183;
					form2.MinimizeBox = false;
					IL_B29:
					num = 184;
					form2.MaximizeBox = false;
					IL_B37:
					num = 185;
					form2.Text = this.Text;
					IL_B4A:
					num = 186;
					form2.StartPosition = this.StartPosition;
					IL_B5D:
					num = 187;
					if (this.FormStyle != FormStyleEnum.模式)
					{
						goto IL_BB1;
					}
					IL_B6C:
					num = 188;
					if (Main.OO_O.o..Disposing || Main.OO_O.o..IsDisposed)
					{
						goto IL_BC4;
					}
					IL_B8A:
					num = 190;
					if (!Main.OO_O.o..Visible)
					{
						goto IL_BC4;
					}
					IL_B9C:
					num = 191;
					form2.TopMost = this.TopMost;
					goto IL_BC4;
					IL_BB1:
					num = 193;
					form2.TopMost = this.TopMost;
					IL_BC4:
					num = 194;
					form2.ShowIcon = this.ShowIcon;
					IL_BD7:
					num = 195;
					form2.ControlBox = this.ControlBox;
					IL_BEA:
					num = 196;
					form2.MaximizeBox = this.MaximizeBox;
					IL_BFD:
					num = 197;
					form2.MinimizeBox = this.MinimizeBox;
					IL_C10:
					num = 198;
					form2.ClientSize = new Size(this.Pane.Width, this.Pane.Height);
					IL_C38:
					num = 199;
					if (this.AllowResize)
					{
						goto IL_C54;
					}
					IL_C46:
					num = 200;
					form2.FormBorderStyle = FormBorderStyle.FixedDialog;
					IL_C54:
					num = 201;
					if (Operators.CompareString(this.ImageFile, "", true) <= 0)
					{
						goto IL_CB2;
					}
					IL_C6E:
					num = 202;
					if (!OO_00oOO.FileSys.FileExists(O_O0OO.OOo_o.0o. + this.ImageFile))
					{
						goto IL_CB2;
					}
					IL_C90:
					num = 203;
					form2.Icon = new Icon(O_O0OO.OOo_o.0o. + this.ImageFile);
					IL_CB2:
					num = 204;
					if (A_1 == 2147483647 || A_2 == 2147483647)
					{
						goto IL_CF0;
					}
					IL_CC8:
					num = 205;
					form2.StartPosition = FormStartPosition.Manual;
					IL_CD6:
					num = 206;
					this.Left = A_1;
					IL_CE3:
					num = 207;
					this.Top = A_2;
					IL_CF0:
					num = 208;
					if (form2.StartPosition != FormStartPosition.Manual)
					{
						goto IL_D1D;
					}
					IL_CFF:
					num = 209;
					form2.Location = new Point(this.Left, this.Top);
					IL_D1D:
					num = 210;
					form2.Controls.Add(this.Pane);
					IL_D35:
					num = 211;
					this.Pane.Dock = DockStyle.Fill;
					IL_D47:
					num = 212;
					form2.ShowInTaskbar = false;
					IL_D55:
					num = 213;
					if (!this.Oo0Oo0000.__.())
					{
						goto IL_E9B;
					}
					IL_D66:
					num = 215;
					if (!this.AutoLayout)
					{
						goto IL_DB0;
					}
					IL_D74:
					num = 216;
					this.sizer = new C1SizerLight();
					IL_D85:
					num = 217;
					this.sizer.SetAutoResize(form2, true);
					IL_D99:
					num = 218;
					this.sizer.ResizeFonts = this.AutoResizeFonts;
					IL_DB0:
					num = 219;
					if (this.FormStyle != FormStyleEnum.PopupForm)
					{
						goto IL_DDB;
					}
					IL_DBF:
					num = 220;
					form2.MaximizeBox = false;
					IL_DCD:
					num = 221;
					form2.MinimizeBox = false;
					IL_DDB:
					num = 222;
					if (this.FormStyle != FormStyleEnum.独立 && this.FormStyle != FormStyleEnum.PopupForm)
					{
						goto IL_E14;
					}
					IL_DF3:
					num = 223;
					form2.Owner = Main.OO_O.o.;
					IL_E05:
					num = 224;
					form2.Show();
					break;
					IL_E14:
					num = 226;
					if (!this.oOO_0_oo.Oo0.)
					{
						goto IL_E51;
					}
					IL_E22:
					num = 227;
					form2.ShowInTaskbar = true;
					IL_E30:
					num = 228;
					form2.ShowDialog();
					IL_E3E:
					num = 229;
					OO_00oOO.Forms.O.o_0oOo_O00. = null;
					break;
					IL_E51:
					num = 231;
					form2.ShowDialog();
					break;
				}
				case FormStyleEnum.共有:
				{
					IL_469:
					num = 77;
					C1DockingTabPage c1DockingTabPage3 = new C1DockingTabPage();
					IL_473:
					num = 78;
					C1DockingTab c1DockingTab = null;
					IL_479:
					num = 79;
					c1DockingTabPage3.Text = this.Text;
					IL_489:
					num = 80;
					Main.OO_O.o..SuspendLayout();
					IL_496:
					num = 81;
					switch (this.DockArea)
					{
					case DockAreaEnum.右:
						IL_7BD:
						num = 122;
						Main.OO_O.o..O0o__0_OO.o.();
						IL_7CB:
						num = 123;
						c1DockingTab = Main.OO_O.o..O0o__0_OO.o.();
						IL_7DA:
						num = 124;
						Main.OO_O.o..O0o__0_OO.o.().Width = this.Pane.Width;
						IL_7F7:
						num = 125;
						Main.OO_O.o..O0o__0_OO.o.();
						IL_805:
						num = 126;
						c1DockingTab = Main.OO_O.o..O0o__0_OO.o.();
						break;
					case DockAreaEnum.底:
					{
						IL_5BA:
						num = 96;
						if (Main.OO_O.o..oo_o0_._o. != null)
						{
							goto IL_678;
						}
						IL_5CC:
						num = 97;
						Main.OO_O.o..oo_o0_._o. = new C1CommandDock();
						IL_5DE:
						num = 98;
						Main.OO_O.o..oo_o0_._o..Dock = DockStyle.Bottom;
						IL_5F1:
						num = 99;
						Main.OO_O.o..oo_o0_._o..AllowFloat = false;
						IL_604:
						num = 100;
						Main.OO_O.o..Controls.Add(Main.OO_O.o..oo_o0_._o.);
						IL_620:
						num = 101;
						Main.OO_O.o..o_o.0.(this.O.OOo0O.());
						IL_633:
						num = 102;
						Main.OO_O.o..oo_o0_._o..Controls.Add(Main.OO_O.o..Oo.O000_oO__o.());
						IL_654:
						num = 103;
						Main.OO_O.o..oo_o0_._o..BringToFront();
						IL_666:
						num = 104;
						Main.OO_O.o..OO_O_0Oo.___o.().BringToFront();
						IL_678:
						num = 105;
						Main.OO_O.o..Oo.O000_oO__o.().Height = this.Pane.Height + SystemInformation.HorizontalScrollBarHeight;
						IL_69B:
						num = 106;
						C1CommandDock oo_o0_._o. = Main.OO_O.o..oo_o0_._o.;
						IL_6A9:
						num = 107;
						c1DockingTab = Main.OO_O.o..Oo.O000_oO__o.();
						break;
					}
					case DockAreaEnum.左:
					{
						IL_4BD:
						num = 83;
						if (Main.OO_O.o..o_o0.o_. != null)
						{
							goto IL_57B;
						}
						IL_4CF:
						num = 84;
						Main.OO_O.o..o_o0.o_. = new C1CommandDock();
						IL_4E1:
						num = 85;
						Main.OO_O.o..o_o0.o_..Dock = DockStyle.Left;
						IL_4F4:
						num = 86;
						Main.OO_O.o..o_o0.o_..AllowFloat = false;
						IL_507:
						num = 87;
						Main.OO_O.o..Controls.Add(Main.OO_O.o..o_o0.o_.);
						IL_523:
						num = 88;
						Main.OO_O.o..o_o0Oo.00.(this.O.OOo0O.());
						IL_536:
						num = 89;
						Main.OO_O.o..o_o0.o_..Controls.Add(Main.OO_O.o..o__0_._oOooO_o.());
						IL_557:
						num = 90;
						Main.OO_O.o..o_o0.o_..BringToFront();
						IL_569:
						num = 91;
						Main.OO_O.o..OO_O_0Oo.___o.().BringToFront();
						IL_57B:
						num = 92;
						Main.OO_O.o..o__0_._oOooO_o.().Width = this.Pane.Width;
						IL_598:
						num = 93;
						C1CommandDock o_o0.o_. = Main.OO_O.o..o_o0.o_.;
						IL_5A6:
						num = 94;
						c1DockingTab = Main.OO_O.o..o__0_._oOooO_o.();
						break;
					}
					case DockAreaEnum.上:
					{
						IL_6BD:
						num = 109;
						if (Main.OO_O.o..o_0_o.O. != null)
						{
							goto IL_77B;
						}
						IL_6CF:
						num = 110;
						Main.OO_O.o..o_0_o.O. = new C1CommandDock();
						IL_6E1:
						num = 111;
						Main.OO_O.o..o_0_o.O..Dock = DockStyle.Top;
						IL_6F4:
						num = 112;
						Main.OO_O.o..o_0_o.O..AllowFloat = false;
						IL_707:
						num = 113;
						Main.OO_O.o..Controls.Add(Main.OO_O.o..o_0_o.O.);
						IL_723:
						num = 114;
						Main.OO_O.o..OOoo___.0.(this.O.OOo0O.());
						IL_736:
						num = 115;
						Main.OO_O.o..o_0_o.O..Controls.Add(Main.OO_O.o..O0o__0_OO.o.());
						IL_757:
						num = 116;
						Main.OO_O.o..o_0_o.O..BringToFront();
						IL_769:
						num = 117;
						Main.OO_O.o..OO_O_0Oo.___o.().BringToFront();
						IL_77B:
						num = 118;
						Main.OO_O.o..O0o__0_OO.o.().Height = this.Pane.Height + SystemInformation.HorizontalScrollBarHeight;
						IL_79E:
						num = 119;
						C1CommandDock o_0_o.O. = Main.OO_O.o..o_0_o.O.;
						IL_7AC:
						num = 120;
						c1DockingTab = Main.OO_O.o..O0o__0_OO.o.();
						break;
					}
					}
					IL_814:
					num = 128;
					c1DockingTabPage3.Controls.Add(this.Pane);
					IL_82C:
					num = 129;
					if (this.Pane == null)
					{
						goto IL_E9B;
					}
					IL_83D:
					num = 131;
					c1DockingTabPage3.TabVisible = false;
					IL_84B:
					num = 132;
					c1DockingTab.TabPages.Add(c1DockingTabPage3);
					IL_860:
					num = 133;
					this.Pane.Dock = DockStyle.Fill;
					IL_872:
					num = 134;
					c1DockingTab.ShowCaption = this.ShowDockCaption;
					IL_885:
					num = 135;
					c1DockingTab.CanCloseTabs = this.ShowCloseButton;
					IL_898:
					num = 136;
					c1DockingTab.AutoHiding = this.AutoHide;
					IL_8AB:
					num = 137;
					if (!this.Oo0Oo0000.__.())
					{
						goto IL_8E4;
					}
					IL_8B9:
					num = 138;
					c1DockingTabPage3.TabVisible = true;
					IL_8C7:
					num = 139;
					c1DockingTab.Visible = true;
					IL_8D5:
					num = 140;
					c1DockingTab.SelectedTab = c1DockingTabPage3;
					IL_8E4:
					num = 141;
					this.o_0._O.();
					IL_8F0:
					num = 142;
					Main.OO_O.o..ResumeLayout();
					IL_900:
					num = 143;
					this.O_0.O00o_00_O. = c1DockingTab;
					IL_90E:
					num = 144;
					this.oO._0oOo.();
					IL_91A:
					num = 145;
					this.Oo_O__o0o.0_.();
					break;
				}
				}
				IL_E5F:
				num = 233;
				if (this.FormStyle == FormStyleEnum.模式)
				{
					goto IL_E7F;
				}
				IL_E6E:
				num = 234;
				ShareLibriay.LockWindowUpdate(IntPtr.Zero);
				IL_E7F:
				num = 235;
				Application.DoEvents();
				IL_E8A:
				num = 236;
				Main.OO_O.o..O.ooO0. = true;
				IL_E9B:
				goto IL_12A1;
				IL_EA0:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1262:
				goto IL_1296;
				IL_1264:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_1274:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1264;
			}
			IL_1296:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_12A1:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x001C4A24 File Offset: 0x001C2C24
		private bool <<EMPTY_NAME>>()
		{
			FormEventArgs formEventArgs = new FormEventArgs(this);
			string a_ = "AfterLoad_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				formEventArgs
			}, true, this.mmname, false);
			return this.Pane != null;
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x001C4A80 File Offset: 0x001C2C80
		private void <<EMPTY_NAME>>()
		{
			ShareLibriay.LockWindowUpdate(IntPtr.Zero);
			Application.DoEvents();
			FormEventArgs formEventArgs = new FormEventArgs(this);
			string a_ = "AfterShow_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				formEventArgs
			}, true, this.mmname, false);
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x001C4AE4 File Offset: 0x001C2CE4
		public void ShowAsync(params object[] args)
		{
			Form.O_O_0 o_O_ = default(Form.O_O_0);
			o_O_.o00o_0.0o_0oo0. = this;
			o_O_.o00o_0.0o_0oo0. = args;
			o_O_.o00o_0.0o_0oo0. = -1;
			o_O_.o00o_0.0o_0oo0. = AsyncVoidMethodBuilder.Create();
			o_O_.o00o_0.0o_0oo0..Start<Form.O_O_0>(ref o_O_);
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x001C4B2C File Offset: 0x001C2D2C
		public void Show(params object[] args)
		{
			if (args.Length == 0)
			{
				this.Show(int.MaxValue, int.MaxValue);
				return;
			}
			if (args.Length == 1)
			{
				this.Show(Conversions.ToInteger(args[0]), int.MaxValue);
				return;
			}
			if (args.Length == 2)
			{
				this.Show(Conversions.ToInteger(args[0]), Conversions.ToInteger(args[1]));
			}
		}

		/// <summary>
		/// 打开并显示窗口
		/// </summary>
		/// <param name="x">用户设置独立窗口或模式窗口的水平位置，单位为像素，默认居中</param>
		/// <param name="y">用户设置独立窗口或模式窗口的垂直位置，单位为像素，默认居中</param>
		// Token: 0x06003E4D RID: 15949 RVA: 0x001C4B88 File Offset: 0x001C2D88
		[oO0oooo("0709")]
		public void Show(int x = 2147483647, int y = 2147483647)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.Open(x, y);
				IL_11:
				num2 = 3;
				if (this.FormStyle == FormStyleEnum.模式)
				{
					goto IL_225;
				}
				IL_1F:
				num2 = 5;
				if (this.Pane == null || this.Pane.FindForm() == null || this.Pane.IsDisposed)
				{
					goto IL_225;
				}
				IL_4C:
				num2 = 7;
				if (!this.IsMain && this.FormStyle != FormStyleEnum.并列)
				{
					goto IL_8A;
				}
				IL_5E:
				num2 = 8;
				C1DockingTabPage c1DockingTabPage = (C1DockingTabPage)this.Pane.Parent;
				IL_71:
				num2 = 9;
				((C1DockingTab)c1DockingTabPage.Parent).SelectedTab = c1DockingTabPage;
				goto IL_206;
				IL_8A:
				num2 = 11;
				switch (this.FormStyle)
				{
				case FormStyleEnum.停靠:
				{
					IL_10E:
					num2 = 16;
					Control parent = this.Pane.Parent;
					for (;;)
					{
						IL_1CE:
						num2 = 18;
						if (parent == null)
						{
							break;
						}
						IL_123:
						num2 = 19;
						if (parent is C1DockingTabPage)
						{
							IL_12F:
							num2 = 20;
							if (((C1DockingTabPage)parent).Parent is C1DockingTab)
							{
								IL_145:
								num2 = 21;
								((C1DockingTab)parent.Parent).SelectedTab = (C1DockingTabPage)parent;
							}
						}
						else
						{
							IL_162:
							num2 = 23;
							if (parent is C1NavBarPanel)
							{
								IL_16E:
								num2 = 24;
								((C1NavBar)parent.Parent).SelectedButton = ((C1NavBarPanel)parent).Button;
							}
							else
							{
								IL_190:
								num2 = 26;
								if (parent is C1DockingTab)
								{
									IL_19C:
									num2 = 27;
									C1DockingTab c1DockingTab = (C1DockingTab)parent;
									IL_1A8:
									num2 = 28;
									if (c1DockingTab.AutoHiding)
									{
										IL_1B4:
										num2 = 29;
										c1DockingTab.AutoHiding = false;
									}
									IL_1BF:
									c1DockingTab = null;
								}
							}
						}
						IL_1C2:
						num2 = 31;
						parent = parent.Parent;
					}
					break;
				}
				case FormStyleEnum.独立:
				case FormStyleEnum.PopupForm:
					IL_1DA:
					num2 = 34;
					if (this.Pane == null || this.Pane.IsDisposed)
					{
						break;
					}
					IL_1F2:
					num2 = 35;
					this.Pane.FindForm().Visible = true;
					break;
				case FormStyleEnum.共有:
					IL_BF:
					num2 = 13;
					if (!(this.Pane.Parent.Parent is C1DockingTab))
					{
						break;
					}
					IL_DC:
					num2 = 14;
					((C1DockingTab)this.Pane.Parent.Parent).SelectedTab = (C1DockingTabPage)this.Pane.Parent;
					break;
				}
				IL_206:
				num2 = 37;
				if (!this.Pane.CanFocus)
				{
					goto IL_225;
				}
				IL_216:
				num2 = 38;
				this.Pane.Focus();
				IL_225:
				goto IL_313;
				IL_22A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2D4:
				goto IL_308;
				IL_2D6:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2E6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2D6;
			}
			IL_308:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_313:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 逻辑型，仅对已经打开的独立型窗口有效，设为False，临时隐藏窗口，设为True，重新显示已经隐藏的窗口
		/// </summary>
		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06003E4E RID: 15950 RVA: 0x001C4ECC File Offset: 0x001C30CC
		// (set) Token: 0x06003E4F RID: 15951 RVA: 0x001C4F16 File Offset: 0x001C3116
		public bool Visible
		{
			get
			{
				return (this.FormStyle == FormStyleEnum.独立 || this.FormStyle == FormStyleEnum.PopupForm) && this.Pane != null && !this.Pane.IsDisposed && this.Pane.FindForm().Visible;
			}
			set
			{
				if ((this.FormStyle == FormStyleEnum.独立 || this.FormStyle == FormStyleEnum.PopupForm) && this.Pane != null && !this.Pane.IsDisposed)
				{
					this.Pane.FindForm().Visible = value;
				}
			}
		}

		/// <summary>
		/// 判断是否存在指定名称的控件
		/// </summary>
		/// <param name="Name">控件名</param>
		// Token: 0x06003E50 RID: 15952 RVA: 0x001C4F50 File Offset: 0x001C3150
		[oO0oooo("1409")]
		public bool ExistControl(string Name)
		{
			Control control = null;
			if (this.Pane != null && !this.Pane.IsDisposed)
			{
				control = this.o_._o000O.(this.Pane.Controls, Name);
			}
			return control != null;
		}

		/// <summary>
		/// 控件集合，包括窗口所有的控件，可以返回指定名称的控件
		/// </summary>
		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06003E51 RID: 15953 RVA: 0x001C4F8B File Offset: 0x001C318B
		[oO0oooo("0706")]
		public ControlCollection Controls
		{
			get
			{
				return this.ooOO0__._0O.;
			}
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x001C4F94 File Offset: 0x001C3194
		private Control <<EMPTY_NAME>>(ControlTypeEnum A_0, string A_1)
		{
			switch (A_0)
			{
			case ControlTypeEnum.Label:
				return new Foxtable.WinForm.Label(new OO_0o_O_O());
			case ControlTypeEnum.TextBox:
				return new TextBox(new O0O_O0());
			case ControlTypeEnum.Button:
				return new Button(new C1Button
				{
					FlatStyle = FlatStyle.Standard,
					VisualStyle = C1.Win.C1Input.VisualStyle.System,
					UseVisualStyleBackColor = true
				});
			case ControlTypeEnum.CheckBox:
				return new CheckBox(new CustomCheckBox());
			case ControlTypeEnum.RadioButton:
				return new RadioButton(new oO00O0oO0o000());
			case ControlTypeEnum.ComboBox:
				return new ComboBox(new OoOO0Oo_oo0oO
				{
					O.oO. = this
				});
			case ControlTypeEnum.NumericComboBox:
				return new NumericComboBox(new ooOOO());
			case ControlTypeEnum.TopicBar:
				return new TopicBar(new Oo_
				{
					Size = new Size(221, 250),
					Padding = new Padding(10)
				});
			case ControlTypeEnum.DateTimePicker:
				return new DateTimePicker(new O_0oOoOo());
			case ControlTypeEnum.ListBox:
				return new ListBox(new CustomListBox());
			case ControlTypeEnum.CheckedListBox:
				return new CheckedListBox(new CustomCheckedListBox
				{
					CheckOnClick = true
				});
			case ControlTypeEnum.GroupBox:
				return new GroupBox(new GroupBox());
			case ControlTypeEnum.Panel:
				return new Panel(new Panel());
			case ControlTypeEnum.SplitContainer:
				return new SplitContainer(new SplitContainer());
			case ControlTypeEnum.PictureBox:
				return new PictureBox(new CustomPictureBox(this));
			case ControlTypeEnum.TabControl:
				return new TabControl(new o_o0());
			case ControlTypeEnum.TreeView:
				return new TreeView(new O__oO_o0_o_o
				{
					Size = new Size(221, 250)
				});
			case ControlTypeEnum.ProgressBar:
				return new ProgressBar(new o_O_O0O__());
			case ControlTypeEnum.Chart:
			{
				C1Chart a_ = new C1Chart();
				new Chart(a_).Oo_0O0.oo00.();
				return new Chart(a_);
			}
			case ControlTypeEnum.PictureViewer:
				return new PictureViewer(new PictureViewer
				{
					Size = new Size(221, 250)
				});
			case ControlTypeEnum.FileManager:
				return new FileManager(new FileManager
				{
					Size = new Size(221, 250)
				});
			case ControlTypeEnum.ColorLabel:
				return new ColorLabel(new CustomColorLabel());
			case ControlTypeEnum.CheckedComboBox:
				return new CheckedComboBox(new O0oo000oO0oo_());
			case ControlTypeEnum.NavBar:
			{
				O_OOO o_OOO = new O_OOO();
				o_OOO.Panels.Clear();
				return new NavBar(o_OOO);
			}
			case ControlTypeEnum.WebBrowser:
				return new WebBrowser(new OOO0_());
			case ControlTypeEnum.Painter:
				return new Painter(new O_oo());
			case ControlTypeEnum.Line:
				return new Line(new LineControl());
			case ControlTypeEnum.BarCode:
				return new BarCode(new OOo00o_0o0_
				{
					Size = new Size(221, 40)
				});
			case ControlTypeEnum.DropDownBox:
				return new DropDownBox(new OooO00O());
			case ControlTypeEnum.Calendar:
				return new Calendar(new MonthCalendar
				{
					FirstDayOfWeek = Day.Monday
				});
			case ControlTypeEnum.TrackBar:
				return new TrackBar(new OoOoo00());
			case ControlTypeEnum.RecordGrid:
				return new RecordGrid(new OooOo0___oO
				{
					Size = new Size(200, 250)
				});
			case ControlTypeEnum.TimeSpanBox:
				return new TimeSpanBox(new o__0OoO_());
			case ControlTypeEnum.ListView:
				return new ListView(new o_OO_oOOO0o());
			case ControlTypeEnum.FilterTree:
				return new FilterTree(new o_o0ooOooO
				{
					Size = new Size(221, 250)
				});
			case ControlTypeEnum.LoadTree:
				return new LoadTree(new o_0
				{
					Size = new Size(221, 250)
				});
			case ControlTypeEnum.InlineTree:
				return new InlineTree(new oo__
				{
					Size = new Size(221, 250)
				});
			case ControlTypeEnum.LayersTree:
				return new LayersTree(new oO_oo0Oo
				{
					Size = new Size(221, 250)
				});
			case ControlTypeEnum.FontPicker:
				return new FontPicker(new O00o());
			case ControlTypeEnum.ColorPicker:
				return new ColorPicker(new oOO());
			case ControlTypeEnum.Gauges:
			{
				O0_O_0O a_2 = new O0_O_0O();
				new Gauges(a_2);
				return new Gauges(a_2);
			}
			case ControlTypeEnum.GanttView:
			{
				GanttView ganttView = new GanttView(false);
				new GanttView(ganttView);
				ganttView.LoadXml(OO_00oOO.FileSys.GetParentPath(Application.ExecutablePath) + "\\ganttview.default.xml");
				return new GanttView(ganttView);
			}
			case ControlTypeEnum.PDFViewer:
				return new PDFViewer(new C1FlexViewer());
			case ControlTypeEnum.Map:
			{
				GeoMap a_3 = new GeoMap();
				new Map(a_3);
				return new Map(a_3);
			}
			case ControlTypeEnum.WebViewer:
				return new WebViewer(new WebViewer());
			}
			return null;
		}

		/// <summary>
		/// 新建控件
		/// </summary>
		/// <param name="Name">新建控件的名称</param>
		/// <param name="Type">新建控件的类型</param>
		// Token: 0x06003E53 RID: 15955 RVA: 0x001C5498 File Offset: 0x001C3698
		[oO0oooo("1409")]
		public object CreateControl(string Name, ControlTypeEnum Type)
		{
			Control control = this.O.OOo0O.(Type, Name);
			control.BaseControl.Tag = "AddbyUserCode";
			control.Name = Name;
			control.o.__O0O. = this;
			this.oO__.o0.(control.BaseControl);
			Main.OO_O.o..o.O000oo.(new object[]
			{
				control.BaseControl
			});
			return control;
		}

		/// <summary>
		/// 新建Normal型Table控件
		/// </summary>
		/// <param name="Name">控件名</param>
		/// <param name="TableName">数据表名</param>
		/// <param name="IsCopy">是否作为副本</param>
		// Token: 0x06003E54 RID: 15956 RVA: 0x001C54F4 File Offset: 0x001C36F4
		[oO0oooo("1919")]
		public Table CreateTable(string Name, string TableName, bool IsCopy)
		{
			Table result;
			if (!OO_00oOO.Tables.get_Contains(TableName))
			{
				result = null;
			}
			else
			{
				Table table2;
				if (IsCopy)
				{
					if (TableName.IndexOf(".") > 0)
					{
						TableName = TableName.Substring(TableName.LastIndexOf(".") + 1);
					}
					O_0 a_ = new O_0(O_O0OO.OOOo.oo_OOOO_0.().Tables[TableName], this.Name + "_" + Name);
					Table table = new Table(a_);
					table.foxGrid.Name = Name;
					table2 = new Table(table.foxGrid);
					OO_00oOO.Tables.Ooo.0OOoO_0.(table);
				}
				else
				{
					table2 = new Table(OO_00oOO.Tables[TableName].foxGrid);
					Control baseControl = table2.BaseControl;
					baseControl.Name = Name;
					if (OO_00oOO.Tables[TableName].IsRelation)
					{
						for (Control parent = baseControl.Parent; parent != null; parent = parent.Parent)
						{
							if (!(parent is FormPanel) && parent is o_O0_0O0)
							{
								((o_O0_0O0)parent).o_o.O___0o.(baseControl);
								break;
							}
						}
					}
				}
				table2.BaseControl.Dock = DockStyle.None;
				result = table2;
			}
			return result;
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x001C5610 File Offset: 0x001C3810
		internal Table <<EMPTY_NAME>>(string A_0, bool A_1, string A_2, string A_3)
		{
			OleDbConnection a_ = null;
			string text = this.Name + "_" + A_0;
			string a_2 = "";
			HttpClient httpClient = null;
			if (Operators.CompareString(A_3, "", true) > 0)
			{
				if (O_O0OO.O._o_.().ContainsKey(A_3))
				{
					a_ = O_O0OO.O._o_.()[A_3];
					A_2 = Oo00.o0_o._O_.(a_, A_2, false);
				}
				else
				{
					if (!O_O0OO.OoO__.0oO0oo.().ContainsKey(A_3))
					{
						throw new Exception("没有找到数据源\"" + A_3 + "!\"");
					}
					O0O o0O = O_O0OO.OoO__.0oO0oo.()[A_3];
					A_2 = Oo00.o0_o._O_.(o0O.OO.OoO0., A_2, false);
					httpClient = o0O.oO0_0.o.();
					httpClient.Select = A_2;
					if (!A_1)
					{
						httpClient.FormData["Action"] = 1.ToString();
					}
					else
					{
						httpClient.FormData["Action"] = 2.ToString();
					}
				}
			}
			else
			{
				a_ = O_O0OO.OoO.0OO__0ooo.();
			}
			if (!A_1)
			{
				a_2 = "?";
			}
			o0OoOOoOOo0.OOOOO.o000.(a_, A_2, text, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, a_2, true, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, null, "", httpClient);
			OO_00oOO.DataTables[text].o.0O000_.();
			Table table = new Table(O_O0OO.o__.O.()[text]);
			if (A_1)
			{
				table.TableType = TableTypeEnum.SQLQuery;
				table.DataTable.AllowEdit = false;
			}
			else
			{
				table.TableType = TableTypeEnum.SQLTable;
			}
			OO_00oOO.Tables.Ooo.0OOoO_0.(table);
			table.foxGrid.Dock = DockStyle.None;
			table.foxGrid.Name = A_0;
			return new Table(table.foxGrid);
		}

		/// <summary>
		/// 新建SQLTable类型的Table
		/// </summary>
		/// <param name="Name">控件名</param>
		/// <param name="SqlText">用于获取数据的SQL语句</param>
		/// <param name="ConnectionName">数据源名称</param>
		// Token: 0x06003E56 RID: 15958 RVA: 0x001C57AF File Offset: 0x001C39AF
		[oO0oooo("1919")]
		public Table CreateSQLTable(string Name, string SqlText, string ConnectionName)
		{
			return this.Oo_O00ooo.OO_.(Name, false, SqlText, ConnectionName);
		}

		/// <summary>
		/// 新建SQLQuery类型的Table
		/// </summary>
		/// <param name="Name">控件名</param>
		/// <param name="SqlText">用于获取数据的SQL语句</param>
		/// <param name="ConnectionName">数据源名称</param>
		// Token: 0x06003E57 RID: 15959 RVA: 0x001C57BB File Offset: 0x001C39BB
		[oO0oooo("1919")]
		public Table CreateSQLQuery(string Name, string SqlText, string ConnectionName)
		{
			return this.Oo_O00ooo.OO_.(Name, true, SqlText, ConnectionName);
		}

		/// <summary>
		/// 将控件加入到窗口中
		/// </summary>
		/// <param name="Control">要加入到窗口的控件</param>
		// Token: 0x06003E58 RID: 15960 RVA: 0x001C57C8 File Offset: 0x001C39C8
		[oO0oooo("1409")]
		public void AddControl(Control Control)
		{
			this.Pane.Controls.Add(Control.BaseControl);
			if (Control.BaseControl is O_oOooO_O)
			{
				Table o.0O_O0o_. = ((O_oOooO_O)Control.BaseControl).o.0O_O0o_.;
				if (o.0O_O0o_..TableType != TableTypeEnum.Normal || o.0O_O0o_..IsCopy)
				{
					o.0O_O0o_..oO_o_0o._0oooo.(true);
				}
			}
			Control.TopMost = true;
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x001C582C File Offset: 0x001C3A2C
		internal void <<EMPTY_NAME>>(Control A_0)
		{
			if (A_0 is CustomPictureBox)
			{
				A_0 = ((CustomPictureBox)A_0).PictureBox1;
				A_0.Tag = RuntimeHelpers.GetObjectValue(A_0.Parent.Tag);
			}
			Control control = A_0;
			control.Enter += this.O0_oO.0_O0.;
			control.Leave += this.oo_.o_oo.;
			control.Validating += this.OOO0.OOOoO.;
			control.KeyPress += this.O0O.OO0OO0.;
			control.KeyDown += this.o_.oo_o_00_.;
			control.KeyUp += this.O0O.OO0OO0.;
			control.Click += this.oo0.OOooo_.;
			control.MouseClick += this.o_oo.O_O_.;
			control.DoubleClick += this.o00_.__00.;
			control.MouseEnter += this.Oo.Oooo0o_.;
			control.MouseLeave += this.oo0OOo0_o.oOoo.;
			control.MouseHover += this.o_ooO0.o___0.;
			control.MouseMove += this.O_0OO._.;
			control.MouseDown += this.o._0_0_o_o0O.;
			control.MouseUp += this.O_OOo.o_0o.;
			if (A_0 is C1TextBox)
			{
				C1TextBox c1TextBox = (C1TextBox)A_0;
				c1TextBox.ValueChanged += this.Oo_0o_oOo0oO.o.;
				c1TextBox.TextChanged += this.oo__o.o0.;
			}
			if (A_0 is CheckBox)
			{
				((CheckBox)A_0).CheckedChanged += this.OooO_._oO_0.;
			}
			if (A_0 is RadioButton)
			{
				((RadioButton)A_0).CheckedChanged += this.OooO_._oO_0.;
			}
		}

		/// <summary>
		/// 从窗口删除指定名称的控件
		/// </summary>
		/// <param name="Name">要删除的控件名称</param>
		// Token: 0x06003E5A RID: 15962 RVA: 0x001C59EC File Offset: 0x001C3BEC
		[oO0oooo("1409")]
		public void RemoveControl(string Name)
		{
			Control control = this.o_._o000O.(this.Pane.Controls, Name);
			if (control != null)
			{
				Control baseControl = control.BaseControl;
				oOO0oo_o0.O00OO_O_oO_.o.(baseControl.Parent.Controls, baseControl);
			}
			this.PrintSettings.Refresh();
		}

		/// <summary>
		/// 删除所有控件
		/// </summary>
		// Token: 0x06003E5B RID: 15963 RVA: 0x001C5A34 File Offset: 0x001C3C34
		public void ClearControl()
		{
			for (int i = this.Pane.Controls.Count - 1; i >= 0; i += -1)
			{
				Control a_ = this.Pane.Controls[i];
				oOO0oo_o0.O00OO_O_oO_.o.(this.Pane.Controls, a_);
			}
			this.PrintSettings.Refresh();
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x001C5A8C File Offset: 0x001C3C8C
		internal Control <<EMPTY_NAME>>(Control.ControlCollection A_0, string A_1)
		{
			try
			{
				foreach (object obj in A_0)
				{
					Control control = (Control)obj;
					if (Operators.CompareString(control.Name, A_1, true) == 0)
					{
						Control control2 = ooO_0O.o_O0.O_.(control);
						if (control2 != null)
						{
							return control2;
						}
					}
					Control control3 = null;
					if (control.Controls.Count > 0 && !(control is PictureViewer) && !(control is FileManager))
					{
						control3 = this.o_._o000O.(control.Controls, A_1);
					}
					if (control3 != null)
					{
						return control3;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return null;
		}

		/// <summary>
		/// 返回有输入焦点的控件
		/// </summary>
		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06003E5D RID: 15965 RVA: 0x001C5B34 File Offset: 0x001C3D34
		public object ActiveControl
		{
			get
			{
				object result;
				if (this.Pane == null)
				{
					result = null;
				}
				else if (this.Pane.IsDisposed || this.Pane.Disposing)
				{
					result = null;
				}
				else
				{
					result = this.o_._o000O.(this.Pane.Controls);
				}
				return result;
			}
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x001C5B80 File Offset: 0x001C3D80
		private object <<EMPTY_NAME>>(Control.ControlCollection A_0)
		{
			try
			{
				foreach (object obj in A_0)
				{
					Control control = (Control)obj;
					if (control.Focused || control.ContainsFocus)
					{
						if (control.Controls.Count == 0 || control is FileManager || control is PictureViewer || control is O_oOooO_O || control is OooOo0___oO)
						{
							object obj2 = ooO_0O.o_O0.O_.(control);
							if (obj2 != null)
							{
								return obj2;
							}
						}
						else if (control.Controls.Count > 0)
						{
							object obj2 = RuntimeHelpers.GetObjectValue(this.o_._o000O.(control.Controls));
							if (obj2 != null)
							{
								return obj2;
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return null;
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x001C5C48 File Offset: 0x001C3E48
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Pane.Parent == null)
			{
				try
				{
					foreach (object obj in Application.OpenForms)
					{
						Form form = (Form)obj;
						if (form is ef)
						{
							ef ef = (ef)form;
							if (ef.OO.____oo. != null && ef.OO.____oo..Form == this)
							{
								ef.Close();
								break;
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				FormEventArgs formEventArgs = new FormEventArgs(this);
				string a_ = "AfterClose_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					formEventArgs
				}, true, this.mmname, false);
				this.O_0.O00o_00_O. = null;
				if (this.Pane != null)
				{
					this.Pane.ToolTip1.Dispose();
					this.Pane.ToolTip1 = null;
					this.Pane.ErrorProvider1.Dispose();
					this.Pane.ErrorProvider1 = null;
					this.Pane.PrintPropExtender1.Clear();
					oOO0oo_o0.O00OO_O_oO_.o.(this.Pane.Controls);
				}
				this.PrintSettings.Clear();
				this.PrintSettings = null;
				this.Pane.Controls.Clear();
				this.Pane.ooOo.o_. = null;
				this.Pane.PrintPropExtender1 = null;
				this.Pane.Dispose();
				this.Pane = null;
				this.O_0.O00o_00_O..Clear();
				if (this.Timer != null)
				{
					this.Timer.Enabled = false;
					this.Timer.Dispose();
				}
			}
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x001C5E04 File Offset: 0x001C4004
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!this.o.Ooo_0_o0oo_.)
			{
				this.o.Ooo_0_o0oo_. = true;
				Control control = ooO.o.O_0000_O.(((Form)A_0).Controls);
				if (control != null)
				{
					if (control is O000O)
					{
						((O000O)control).SetReadOnlyProperty();
					}
					if (ooO_0O.o_O0.O_.(control) != null)
					{
						this.O0_oO.0_O0.(control, new EventArgs());
					}
					if (!(control is OoOO0Oo_oo0oO))
					{
						O0oo000oO0oo_ o0oo000oO0oo_ = control as O0oo000oO0oo_;
					}
				}
				this.oO._0oOo.();
				this.Oo_O__o0o.0_.();
			}
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x001C5E78 File Offset: 0x001C4078
		private void <<EMPTY_NAME>>()
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				Control control = (Control)this.ActiveControl;
				IL_15:
				num2 = 3;
				if (control == null)
				{
					goto IL_34;
				}
				IL_1A:
				num2 = 4;
				control.Enabled = false;
				IL_23:
				num2 = 5;
				control.Enabled = true;
				IL_2C:
				num2 = 6;
				control.Select();
				IL_34:
				goto IL_9F;
				IL_36:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_60:
				goto IL_94;
				IL_62:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_72:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_62;
			}
			IL_94:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_9F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x001C5F3C File Offset: 0x001C413C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Form form = (Form)A_0;
			Control control = ooO.o.O_0000_O.(form.Controls);
			if (control is O_0oOoOo && ((C1TextBox)control).ReadOnly)
			{
				form.SelectNextControl(control, true, false, true, true);
			}
			if (control != null)
			{
				if (control is C1FlexGrid)
				{
					C1FlexGrid c1FlexGrid = (C1FlexGrid)control;
					if (c1FlexGrid.Editor != null)
					{
						c1FlexGrid.FinishEditing();
					}
				}
				else if (control.DataBindings.Count > 0)
				{
					this.OOO0.OOOoO.(control);
				}
			}
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x001C5FBC File Offset: 0x001C41BC
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			int num2;
			int num4;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				this.o.Ooo_0_o0oo_. = false;
				IL_09:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_10:
				num = 3;
				this.oOO0OO0O.o0oO.();
				IL_18:
				num = 4;
				Form form = (Form)A_0;
				IL_21:
				num = 5;
				form.Controls.Clear();
				IL_2E:
				num = 6;
				if (this.Pane == null || this.Pane.IsDisposed)
				{
					goto IL_5B;
				}
				IL_45:
				num = 7;
				this.Pane.Dispose();
				IL_52:
				num = 8;
				this.Pane = null;
				IL_5B:
				num = 9;
				if (!Main.OO_O.o..CanFocus)
				{
					goto IL_78;
				}
				IL_6A:
				num = 10;
				Main.OO_O.o..Focus();
				IL_78:
				goto IL_F3;
				IL_7A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_B4:
				goto IL_E8;
				IL_B6:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_C6:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_B6;
			}
			IL_E8:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_F3:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x001C60D4 File Offset: 0x001C42D4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Pane != null && this.Pane.FindForm() != null && !this.Pane.IsDisposed)
			{
				FormEventArgs formEventArgs = new FormEventArgs(this);
				string a_ = "TimerTick_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					formEventArgs
				}, false, this.mmname, false);
			}
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x001C614C File Offset: 0x001C434C
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			this.o0_o.0_o_. = false;
			if (this.Pane != null)
			{
				try
				{
					foreach (DataTable dataTable in OO_00oOO.DataTables)
					{
						if (dataTable.Name.ToLower().StartsWith(this.Name.ToLower() + "_") && dataTable.o00o.00oO___0.)
						{
							MessageBox.Show("正在加载数据的过程中，暂不能关闭窗口!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							A_1.Cancel = true;
							return;
						}
					}
				}
				finally
				{
					IEnumerator<DataTable> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				Form form = this.Pane.FindForm();
				if (form != null)
				{
					if (!form.ControlBox && Control.ModifierKeys == Keys.Alt)
					{
						this.o0_o.0_o_. = true;
						A_1.Cancel = true;
						return;
					}
					if (this.ActiveControl != null)
					{
						Control control = (Control)this.ActiveControl;
						if (control.BaseControl is O_oOooO_O)
						{
							O_oOooO_O o_oOooO_O = (O_oOooO_O)control.BaseControl;
							if (o_oOooO_O.Editor != null)
							{
								o_oOooO_O.FinishEditing();
								if (o_oOooO_O.Editor != null)
								{
									A_1.Cancel = true;
									this.o0_o.0_o_. = true;
									return;
								}
							}
						}
						else
						{
							control.WriteValue();
						}
					}
					if (form != Main.OO_O.o.)
					{
						FormEventArgs formEventArgs = new FormEventArgs(this);
						string a_ = "BeforeClose_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
						O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
						{
							formEventArgs
						}, false, this.mmname, false);
						if (this.O_0.O00o_00_O.)
						{
							A_1.Cancel = formEventArgs.Cancel;
							this.o0_o.0_o_. = formEventArgs.Cancel;
						}
						if (!A_1.Cancel)
						{
							this.OoOO_._0.();
						}
					}
				}
			}
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x001C630C File Offset: 0x001C450C
		internal void <<EMPTY_NAME>>(Control A_0, ControlTypeEnum A_1)
		{
			if (!(A_0 is O_oOooO_O))
			{
				if (A_0 is CustomPictureBox)
				{
					A_0 = ((CustomPictureBox)A_0).PictureBox1;
					A_0.Tag = RuntimeHelpers.GetObjectValue(A_0.Parent.Tag);
				}
				if (A_0 is C1Chart)
				{
					A_0.Click += this.OOo000o.0OO_O0.;
					A_0.DoubleClick += this.oOoo000O.0_.;
					A_0.MouseHover += this.O_o00_._Oo0O.;
					A_0.MouseMove += this.OoOO_o.00_.;
					A_0.MouseDown += this.oo.0O0___0.;
					A_0.MouseUp += this.O.OOo0O.;
					((C1Chart)A_0).ShowTooltip += this.O.OOo0O.;
				}
				else
				{
					A_0.Enter += this.O0_oO.0_O0.;
					A_0.Leave += this.oo_.o_oo.;
					A_0.Validating += this.OOO0.OOOoO.;
					A_0.KeyPress += this.O0O.OO0OO0.;
					A_0.KeyDown += this.o_.oo_o_00_.;
					A_0.KeyUp += this.O0O.OO0OO0.;
					A_0.Click += this.oo0.OOooo_.;
					A_0.MouseClick += this.o_oo.O_O_.;
					A_0.DoubleClick += this.o00_.__00.;
					A_0.MouseEnter += this.Oo.Oooo0o_.;
					A_0.MouseLeave += this.oo0OOo0_o.oOoo.;
					A_0.MouseHover += this.o_ooO0.o___0.;
					A_0.MouseMove += this.O_0OO._.;
					A_0.MouseDown += this.o._0_0_o_o0O.;
					A_0.MouseUp += this.O_OOo.o_0o.;
				}
				if (A_0 is C1TextBox)
				{
					A_0.LostFocus += this.o0000o_Oo0.0_.;
					C1TextBox c1TextBox = (C1TextBox)A_0;
					string a_ = "DataFormat_" + Conversions.ToString(A_0.Tag);
					if (this.O0O.OO0OO0.(a_))
					{
						c1TextBox.DisplayFormat.FormatType = FormatTypeEnum.UseEvent;
						c1TextBox.Formatting += this.Oo_O00ooo.OO_.;
					}
					a_ = "DataParse_" + Conversions.ToString(A_0.Tag);
					if (this.O0O.OO0OO0.(a_))
					{
						c1TextBox.ParseInfo.FormatType = FormatTypeEnum.UseEvent;
						c1TextBox.ParseInfo.CustomFormat = "";
						c1TextBox.Parsing += this.Oo_O00ooo.OO_.;
					}
				}
				if (A_0 is C1Label)
				{
					C1Label c1Label = (C1Label)A_0;
					string a_2 = "DataFormat_" + Conversions.ToString(A_0.Tag);
					if (this.O0O.OO0OO0.(a_2))
					{
						c1Label.FormatType = FormatTypeEnum.UseEvent;
						c1Label.CustomFormat = "";
						c1Label.Formatting += this.Oo_O00ooo.OO_.;
					}
				}
				if (A_0 is C1NumericEdit)
				{
					C1NumericEdit c1NumericEdit = (C1NumericEdit)A_0;
					c1NumericEdit.TextChanged += this.oo__o.o0.;
					c1NumericEdit.ValueChanged += this.Oo_0o_oOo0oO.o.;
					return;
				}
				if (A_0 is O_0oOoOo)
				{
					O_0oOoOo o_0oOoOo = (O_0oOoOo)A_0;
					o_0oOoOo.TextChanged += this.oo__o.o0.;
					o_0oOoOo.ValueChanged += this.Oo_0o_oOo0oO.o.;
					return;
				}
				if (A_0 is O00o)
				{
					((O00o)A_0).ValueChanged += this.Oo_0o_oOo0oO.o.;
					return;
				}
				if (A_0 is oOO)
				{
					((oOO)A_0).ValueChanged += this.Oo_0o_oOo0oO.o.;
					return;
				}
				if (A_0 is O0O_O0)
				{
					if (!(A_0 is O__o))
					{
						O0O_O0 o0O_O = (O0O_O0)A_0;
						o0O_O.TextChanged += this.oo__o.o0.;
						o0O_O.ValueChanged += this.Oo_0o_oOo0oO.o.;
						return;
					}
				}
				else
				{
					if (A_0 is CustomColorLabel)
					{
						((CustomColorLabel)A_0).BackColorChanged += this.Oo_0o_oOo0oO.o.;
						return;
					}
					if (A_0 is O_0oOoOo)
					{
						O_0oOoOo o_0oOoOo2 = (O_0oOoOo)A_0;
						o_0oOoOo2.TextChanged += this.oo__o.o0.;
						o_0oOoOo2.ValueChanged += this.Oo_0o_oOo0oO.o.;
						return;
					}
					if (A_0 is OooO00O)
					{
						OooO00O oooO00O = (OooO00O)A_0;
						oooO00O.TextChanged += this.oo__o.o0.;
						oooO00O.ValueChanged += this.Oo_0o_oOo0oO.o.;
						oooO00O.UpDownButtonClick += this.OOO0.OOOoO.;
						oooO00O.ModalButtonClick += this.o0.ooo.;
						return;
					}
					if (A_0 is OoOO0Oo_oo0oO)
					{
						OoOO0Oo_oo0oO ooOO0Oo_oo0oO = (OoOO0Oo_oo0oO)A_0;
						ooOO0Oo_oo0oO.oOOO_.o.(true);
						ooOO0Oo_oo0oO.TextChanged += this.oo__o.o0.;
						ooOO0Oo_oo0oO.ValueChanged += this.Oo_0o_oOo0oO.o.;
						ooOO0Oo_oo0oO.O_O_OoOoOo.o0_.(new OoOO0Oo_oo0oO.o0__0(this.o_._O__O.));
						ooOO0Oo_oo0oO.O.oO. = this;
						return;
					}
					if (A_0 is O0oo000oO0oo_)
					{
						O0oo000oO0oo_ o0oo000oO0oo_ = (O0oo000oO0oo_)A_0;
						o0oo000oO0oo_.O.o00OOo_.(true);
						o0oo000oO0oo_.TextChanged += this.oo__o.o0.;
						o0oo000oO0oo_.ValueChanged += this.Oo_0o_oOo0oO.o.;
						o0oo000oO0oo_.O0Oo.oOOoOoO__.(new O0oo000oO0oo_.o0_00__ooOo(this.o_._O__O.));
						o0oo000oO0oo_.O__O.o_.(new O0oo000oO0oo_.oO0__(this.o0000o_Oo0.0_.));
						return;
					}
					if (A_0 is CustomCheckedListBox)
					{
						CustomCheckedListBox customCheckedListBox = (CustomCheckedListBox)A_0;
						customCheckedListBox.FormattingEnabled = true;
						customCheckedListBox.SelectedIndexChanged += this.o_._O__O.;
						customCheckedListBox.Format += this.o0000o_Oo0.0_.;
						customCheckedListBox.ItemCheck += this.o_.oo_o_00_.;
						return;
					}
					if (A_0 is CustomListBox)
					{
						CustomListBox customListBox = (CustomListBox)A_0;
						customListBox.FormattingEnabled = true;
						customListBox.SelectedIndexChanged += this.o_._O__O.;
						customListBox.O.00_Oo. = this;
						return;
					}
					if (A_0 is CustomCheckBox)
					{
						((CheckBox)A_0).CheckedChanged += this.OooO_._oO_0.;
						return;
					}
					if (A_0 is oO00O0oO0o000)
					{
						((oO00O0oO0o000)A_0).CheckedChanged += this.OooO_._oO_0.;
						return;
					}
					if (A_0 is SplitContainer)
					{
						((SplitContainer)A_0).SplitterMoved += this.o.o0oO__0__00_.;
						return;
					}
					if (A_0 is C1DockingTab)
					{
						C1DockingTab c1DockingTab = (C1DockingTab)A_0;
						c1DockingTab.SelectedIndexChanged += this.o_._O__O.;
						c1DockingTab.SelectedIndexChanging += this.o.o0oO__0__00_.;
						return;
					}
					if (A_0 is O_OOO)
					{
						((O_OOO)A_0).SelectedPanelChanged += this.o_._O__O.;
						return;
					}
					if (A_0 is TreeView)
					{
						TreeView treeView = (TreeView)A_0;
						if (!(A_0 is oo__) && !(A_0 is oO_oo0Oo) && !(A_0 is o_o0ooOooO))
						{
							treeView.AfterSelect += this.O_OoO_.Oo_0_o.;
							treeView.AfterLabelEdit += this.oooO.0o00_.;
							treeView.BeforeLabelEdit += this.Oo_OoO.o_.;
							treeView.AfterCheck += this.O.00oo_OO0O.;
							treeView.BeforeSelect += this.O_0.oOO.;
							treeView.AfterExpand += this.O__0._o.;
							treeView.AfterCollapse += this.oooO.0o00_.;
							treeView.BeforeExpand += this.Oo_OoO.o_.;
							treeView.NodeMouseClick += this.O_OOo.o_0o.;
							treeView.NodeMouseDoubleClick += this.ooO0O.00.;
							treeView.NodeMouseHover += this.ooO0O.00.;
						}
						return;
					}
					if (A_0 is o_OO_oOOO0o)
					{
						ListView listView = (ListView)A_0;
						listView.RetrieveVirtualItem += this.Oo0Oo0000.__.;
						listView.CacheVirtualItems += this.oO0._o0__o_o_O.;
						listView.ItemActivate += this.O00.0_OO00oO_.;
						listView.BeforeLabelEdit += this.oO0._o0__o_o_O.;
						listView.AfterLabelEdit += this.oooO.0o00_.;
						listView.ItemSelectionChanged += this.O0O.OO0OO0.;
						listView.ItemCheck += this.o0000o_Oo0.0_.;
						listView.ItemChecked += this.o0000o_Oo0.0_.;
						listView.DrawSubItem += this.Oo_O00ooo.OO_.;
						listView.DrawColumnHeader += this.Oo_O00ooo.OO_.;
						return;
					}
					if (A_0 is C1TopicBar)
					{
						C1TopicBar c1TopicBar = (C1TopicBar)A_0;
						c1TopicBar.LinkClick += this.OOO0.OOOoO.;
						c1TopicBar.PageCollapsed += this.OOo0O0.0.;
						c1TopicBar.PageExpanded += this.OOO0.OOOoO.;
						return;
					}
					if (A_0 is MonthCalendar)
					{
						MonthCalendar monthCalendar = (MonthCalendar)A_0;
						monthCalendar.DateChanged += this.oOo_0o_o_0_.O.;
						monthCalendar.DateSelected += this.Oo_O00ooo.OO_.;
						return;
					}
					if (A_0 is OoOoo00)
					{
						((OoOoo00)A_0).Scroll += this.O000_0O__o._.;
						return;
					}
					if (A_0 is Panel)
					{
						((Panel)A_0).Scroll += this.oO_.0_0.;
						return;
					}
					if (A_0 is GanttView)
					{
						GanttView ganttView = (GanttView)A_0;
						((ToolStrip)ganttView.Controls[4]).ItemClicked += this.O_.O__Oo.;
						ganttView.AfterEditTask += this.O_OoO_.Oo_0_o.;
						ganttView.BeforeEditTask += this.O__0._o.;
						ganttView.BeforeAddTask += this.oooO.0o00_.;
						ganttView.BeforeRemoveTask += this.oO0._o0__o_o_O.;
						ganttView.TaskBarTooltip += this.o.o0oO__0__00_.;
						ganttView.BeforeMoveTasks += this.oO0._o0__o_o_O.;
						ganttView.TaskBarClick += this.o.o0oO__0__00_.;
						ganttView.PaintDay += this.oO_.0_0.;
						ganttView.SelectedIndexChanged += this.Oo.o__00_.;
						return;
					}
					if (A_0 is GeoMap)
					{
						GeoMap geoMap = (GeoMap)A_0;
						geoMap.ZoomChanged += this.o_.O_00OOOo0_O.;
						geoMap.CenterChanged += this.Oo._0O0_.;
						return;
					}
					if (A_0 is WebViewer)
					{
						WebViewer webViewer = (WebViewer)A_0;
						webViewer.CoreWebView2InitializationCompleted += this.O0O0.O.;
						webViewer.ZoomFactorChanged += this.o._oOO_o.;
					}
				}
			}
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x001C6D48 File Offset: 0x001C4F48
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Pane.ooOo.o_. != null)
			{
				if (this.Pane.ooOo.o_..FindForm() != null)
				{
					this.Pane.ErrorProvider1.SetError(this.Pane.ooOo.o_., this.Pane.ooOo.o_.);
				}
				this.Pane.ooOo.o_. = null;
				this.Pane.ooOo.o_. = null;
			}
			Control control = (Control)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
			string a_ = "Enter_" + Conversions.ToString(control.Tag);
			if (control.FindForm() != null)
			{
				this.OOOo._. = control.Name;
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname + "," + control.Name, false);
				if (!control.Disposing && !control.IsDisposed && !controlEventArgs.Cancel)
				{
					a_ = "Enter_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
					O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
					{
						controlEventArgs
					}, false, this.mmname, false);
				}
			}
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x001C6E74 File Offset: 0x001C5074
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num6;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				Control control = (Control)A_0;
				IL_10:
				num2 = 3;
				ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
				IL_1B:
				num2 = 4;
				string a_ = "Leave_" + Conversions.ToString(control.Tag);
				IL_34:
				num2 = 5;
				if (control.FindForm() == null)
				{
					goto IL_302;
				}
				IL_41:
				num2 = 7;
				if (control.DataBindings.Count <= 0)
				{
					goto IL_267;
				}
				IL_54:
				num2 = 8;
				if (!(control is C1TextBox))
				{
					goto IL_1F0;
				}
				IL_61:
				num2 = 9;
				if (!((C1TextBox)control).UpdateValueWithCurrentText())
				{
					goto IL_215;
				}
				IL_74:
				num2 = 10;
				Binding binding = control.DataBindings[0];
				IL_85:
				num2 = 11;
				bool flag = false;
				IL_8B:
				num2 = 12;
				if (!(binding.DataSource is O_0))
				{
					goto IL_1DD;
				}
				IL_9F:
				num2 = 13;
				string text = ((O_0)binding.DataSource).Oo._Oo0OO.();
				IL_B5:
				num2 = 14;
				if (!OO_00oOO.Tables.get_Contains(text))
				{
					goto IL_1DD;
				}
				IL_C9:
				num2 = 15;
				if (!OO_00oOO.Tables[text].IsCopy && !OO_00oOO.Tables[text].IsRelation)
				{
					goto IL_1DD;
				}
				IL_F5:
				num2 = 16;
				control.DataBindings.Remove(binding);
				IL_105:
				num2 = 17;
				string bindingField = binding.BindingMemberInfo.BindingField;
				IL_11A:
				num2 = 18;
				int num3 = text.Length - text.Replace(".", "").Length;
				IL_13D:
				num2 = 19;
				int num4 = OO_00oOO.Tables[text].Position;
				IL_153:
				num2 = 20;
				if (OO_00oOO.Tables[text].Current == null)
				{
					goto IL_194;
				}
				IL_169:
				num2 = 21;
				OO_00oOO.Tables[text].Current[bindingField] = RuntimeHelpers.GetObjectValue(((C1TextBox)control).Value);
				IL_194:
				num2 = 22;
				control.DataBindings.Add(binding);
				IL_1A4:
				num2 = 23;
				flag = true;
				IL_1AA:
				num2 = 24;
				if (num3 < 2 || OO_00oOO.Tables[text].Position == num4)
				{
					goto IL_1DD;
				}
				IL_1C7:
				num2 = 25;
				OO_00oOO.Tables[text].Position = num4;
				IL_1DD:
				num2 = 26;
				if (flag)
				{
					goto IL_215;
				}
				IL_1E4:
				num2 = 27;
				this.OOO0.OOOoO.(control);
				goto IL_215;
				IL_1F0:
				num2 = 29;
				if (control.DataBindings.Count <= 0)
				{
					goto IL_215;
				}
				IL_201:
				num2 = 30;
				control.DataBindings[0].WriteValue();
				IL_215:
				num2 = 31;
				if (control.DataBindings[0].BindingManagerBase.Position < 0)
				{
					goto IL_267;
				}
				IL_231:
				num2 = 32;
				object objectValue = RuntimeHelpers.GetObjectValue(control.DataBindings[0].BindingManagerBase.Current);
				IL_251:
				num2 = 33;
				if (objectValue == null)
				{
					goto IL_267;
				}
				IL_258:
				num2 = 34;
				((DataRowView)objectValue).EndEdit();
				IL_267:
				num2 = 35;
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname + "," + control.Name, false);
				IL_29B:
				num2 = 36;
				if (control.Disposing || control.IsDisposed)
				{
					goto IL_302;
				}
				IL_2AE:
				num2 = 38;
				if (controlEventArgs.Cancel)
				{
					goto IL_302;
				}
				IL_2BA:
				num2 = 39;
				a_ = "Leave_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				IL_2DE:
				num2 = 40;
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname, false);
				IL_302:
				goto IL_3F8;
				IL_307:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_3B9:
				goto IL_3ED;
				IL_3BB:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_3CB:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3BB;
			}
			IL_3ED:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3F8:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x001C72A0 File Offset: 0x001C54A0
		private void <<EMPTY_NAME>>(object A_0, CancelEventArgs A_1)
		{
			this.Pane.ooOo.o_. = null;
			this.Pane.ooOo.o_. = null;
			Control control = (Control)A_0;
			if (control is C1TextBox && !((C1TextBox)control).UpdateValueWithCurrentText())
			{
				A_1.Cancel = true;
				return;
			}
			ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
			string a_ = "Validating_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + control.Name, false);
			if (!controlEventArgs.Cancel)
			{
				a_ = "Validating_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname, false);
			}
			A_1.Cancel = controlEventArgs.Cancel;
			oOO0oo_o0.O00OO_O_oO_.o.(control);
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x001C7390 File Offset: 0x001C5590
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlKeyPressEventArgs controlKeyPressEventArgs = new ControlKeyPressEventArgs(control, this, Conversions.ToString(A_1.KeyChar));
			string a_ = "KeyPress_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlKeyPressEventArgs
			}, false, this.mmname + "," + control.Name, false);
			if (!control.Disposing && !control.IsDisposed && !controlKeyPressEventArgs.Cancel)
			{
				a_ = "KeyPress_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlKeyPressEventArgs
				}, false, this.mmname, false);
			}
			A_1.KeyChar = controlKeyPressEventArgs.KeyChar[0];
			A_1.Handled = controlKeyPressEventArgs.Cancel;
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x001C7474 File Offset: 0x001C5674
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlKeyEventArgs controlKeyEventArgs = new ControlKeyEventArgs(control, this, A_1.KeyData);
			controlKeyEventArgs.Cancel = A_1.Handled;
			string a_ = "KeyDown_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlKeyEventArgs
			}, false, this.mmname + "," + control.Name, false);
			if (control.Disposing || control.IsDisposed)
			{
				A_1.Handled = true;
				return;
			}
			if (!controlKeyEventArgs.Cancel)
			{
				a_ = "KeyDown_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlKeyEventArgs
				}, false, this.mmname, false);
			}
			A_1.Handled = controlKeyEventArgs.Cancel;
			if (A_1.Handled)
			{
				A_1.SuppressKeyPress = true;
				return;
			}
			if (!(control is o_OO_oOOO0o) && A_1.KeyCode == Keys.Return && !A_1.Control && !A_1.Alt && !A_1.Shift)
			{
				if (control is O0O_O0)
				{
					if (((O0O_O0)control).Multiline)
					{
						return;
					}
				}
				else if (control is Button)
				{
					return;
				}
				A_1.Handled = true;
				A_1.SuppressKeyPress = true;
				SendKeys.Send("{TAB}");
			}
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x001C75C4 File Offset: 0x001C57C4
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlKeyEventArgs controlKeyEventArgs = new ControlKeyEventArgs(control, this, A_1.KeyData);
			string a_ = "KeyUp_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlKeyEventArgs
			}, false, this.mmname + "," + control.Name, false);
			if (!control.Disposing && !control.IsDisposed && !controlKeyEventArgs.Cancel)
			{
				a_ = "KeyUp_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlKeyEventArgs
				}, false, this.mmname, false);
			}
			A_1.Handled = controlKeyEventArgs.Cancel;
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x001C7690 File Offset: 0x001C5890
		internal void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				Control control = (Control)A_0;
				if (Operators.CompareString(this.OoO.0_Oo00Ooo., control.Tag.ToString(), true) != 0)
				{
					this.OoO.0_Oo00Ooo. = control.Tag.ToString();
					ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
					string a_ = "Click_" + Conversions.ToString(control.Tag);
					O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
					{
						controlEventArgs
					}, false, this.mmname + "," + control.Name, false);
					if (!control.Disposing && !control.IsDisposed)
					{
						if (!controlEventArgs.Cancel)
						{
							a_ = "Click_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
							O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
							{
								controlEventArgs
							}, false, this.mmname, false);
						}
					}
				}
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
			finally
			{
				this.OoO.0_Oo00Ooo. = null;
			}
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x001C77B8 File Offset: 0x001C59B8
		internal void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
			string a_ = "ZoomChanged_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x001C781C File Offset: 0x001C5A1C
		internal void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
			string a_ = "CenterChanged_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x001C7880 File Offset: 0x001C5A80
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			try
			{
				Control control = (Control)A_0;
				if (Operators.CompareString(this.OoO.0_Oo00Ooo., control.Tag.ToString(), true) != 0)
				{
					this.OoO.0_Oo00Ooo. = control.Tag.ToString();
					ControlMouseEventArgs controlMouseEventArgs = new ControlMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, this);
					string a_ = "MouseClick_" + Conversions.ToString(control.Tag);
					O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
					{
						controlMouseEventArgs
					}, false, this.mmname + "," + control.Name, false);
					if (!control.Disposing && !control.IsDisposed)
					{
						if (!controlMouseEventArgs.Cancel)
						{
							a_ = "MouseClick_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
							O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
							{
								controlMouseEventArgs
							}, false, this.mmname, false);
						}
					}
				}
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
			finally
			{
				this.OoO.0_Oo00Ooo. = null;
			}
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x001C79E0 File Offset: 0x001C5BE0
		internal void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				Control control = (Control)A_0;
				if (Operators.CompareString(this.OoO.0_Oo00Ooo., control.Tag.ToString(), true) != 0)
				{
					this.OoO.0_Oo00Ooo. = control.Tag.ToString();
					ChartEventArgs chartEventArgs = new ChartEventArgs(control, this);
					string a_ = "ChartClick_" + Conversions.ToString(control.Tag);
					O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
					{
						chartEventArgs
					}, false, this.mmname + "," + control.Name, false);
				}
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
			finally
			{
				this.OoO.0_Oo00Ooo. = null;
			}
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x001C7AB0 File Offset: 0x001C5CB0
		internal void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
			string a_ = "Click_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + control.Name, false);
			if (!control.Disposing && !control.IsDisposed && !controlEventArgs.Cancel)
			{
				a_ = "Click_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname, false);
			}
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x001C7B68 File Offset: 0x001C5D68
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
			string a_ = "DoubleClick_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + control.Name, false);
			if (!control.Disposing && !control.IsDisposed && !controlEventArgs.Cancel)
			{
				a_ = "DoubleClick_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname, false);
			}
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x001C7C20 File Offset: 0x001C5E20
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			ChartEventArgs chartEventArgs = new ChartEventArgs(control, this);
			string a_ = "ChartDoubleClick_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				chartEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x001C7C84 File Offset: 0x001C5E84
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
			string a_ = "MouseEnter_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + control.Name, false);
			if (!controlEventArgs.Cancel)
			{
				a_ = "MouseEnter_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname, false);
			}
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x001C7D2C File Offset: 0x001C5F2C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
			string a_ = "MouseLeave_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + control.Name, false);
			if (!controlEventArgs.Cancel)
			{
				a_ = "MouseLeave_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname, false);
			}
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x001C7DD4 File Offset: 0x001C5FD4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
			string a_ = "MouseHover_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + control.Name, false);
			if (!controlEventArgs.Cancel)
			{
				a_ = "MouseHover_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname, false);
			}
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x001C7E7C File Offset: 0x001C607C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			ChartEventArgs chartEventArgs = new ChartEventArgs(control, this);
			string a_ = "ChartMouseHover_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				chartEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x001C7EE0 File Offset: 0x001C60E0
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlMouseEventArgs controlMouseEventArgs = new ControlMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, this);
			string a_ = "MouseMove_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlMouseEventArgs
			}, false, this.mmname + "," + control.Name, false);
			if (!control.Disposing && !control.IsDisposed)
			{
				a_ = "MouseMove_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlMouseEventArgs
				}, false, this.mmname, false);
			}
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x001C7FB0 File Offset: 0x001C61B0
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			Control control = (Control)A_0;
			ChartMouseEventArgs chartMouseEventArgs = new ChartMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, this);
			string a_ = "ChartMouseMove_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				chartMouseEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x001C8030 File Offset: 0x001C6230
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control is TreeView && !(control is oo__) && !(control is oO_oo0Oo))
			{
				TreeView treeView = (TreeView)control;
				if (treeView.GetNodeAt(A_1.X, A_1.Y) != null)
				{
					treeView.SelectedNode = treeView.GetNodeAt(A_1.X, A_1.Y);
				}
			}
			ControlMouseEventArgs controlMouseEventArgs = new ControlMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, this);
			string a_ = "MouseDown_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlMouseEventArgs
			}, false, this.mmname + "," + control.Name, false);
			if (!control.Disposing && !control.IsDisposed)
			{
				a_ = "MouseDown_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlMouseEventArgs
				}, false, this.mmname, false);
			}
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x001C814C File Offset: 0x001C634C
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			Control control = (Control)A_0;
			ChartMouseEventArgs chartMouseEventArgs = new ChartMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, this);
			string a_ = "ChartMouseDown_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				chartMouseEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x001C81CC File Offset: 0x001C63CC
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlMouseEventArgs controlMouseEventArgs = new ControlMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, this);
			string a_ = "MouseUp_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlMouseEventArgs
			}, false, this.mmname + "," + control.Name, false);
			if (!control.Disposing && !control.IsDisposed)
			{
				a_ = "MouseUp_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlMouseEventArgs
				}, false, this.mmname, false);
			}
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x001C829C File Offset: 0x001C649C
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			Control control = (Control)A_0;
			ChartMouseEventArgs chartMouseEventArgs = new ChartMouseEventArgs(control, A_1.Button, A_1.Clicks, A_1.X, A_1.Y, A_1.Delta, this);
			string a_ = "ChartMouseUp_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				chartMouseEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x001C831C File Offset: 0x001C651C
		private void <<EMPTY_NAME>>(object A_0, ShowTooltipEventArgs A_1)
		{
			ChartDataSeries chartDataSeries = (ChartDataSeries)A_0;
			C1Chart c1Chart = null;
			try
			{
				foreach (Control control in this.Controls)
				{
					if (control is Chart)
					{
						C1Chart c1Chart2 = (C1Chart)control.BaseControl;
						if (c1Chart2.ChartGroups[0] == chartDataSeries.Group || c1Chart2.ChartGroups[1] == chartDataSeries.Group)
						{
							c1Chart = c1Chart2;
							break;
						}
					}
				}
			}
			finally
			{
				IEnumerator<Control> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			ChartToolTipEventArgs chartToolTipEventArgs = new ChartToolTipEventArgs(c1Chart, this, A_1);
			string a_ = "ChartShowTooltip_" + Conversions.ToString(c1Chart.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				chartToolTipEventArgs
			}, false, this.mmname + "," + c1Chart.Name, false);
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x001C8408 File Offset: 0x001C6608
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				this.O_o_.0o0__o0O. = control;
				ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
				string a_ = "TextChanged_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname + "," + control.Name, false);
				if (!control.Disposing && !control.IsDisposed && !controlEventArgs.Cancel)
				{
					a_ = "TextChanged_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
					O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
					{
						controlEventArgs
					}, false, this.mmname, false);
				}
				this.O_o_.0o0__o0O. = null;
			}
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x001C84DC File Offset: 0x001C66DC
		private bool <<EMPTY_NAME>>(string A_0)
		{
			bool result;
			if (this.O_0.O00o_00_O. == null)
			{
				result = false;
			}
			else
			{
				A_0 = o0OoOOoOOo0.OO0._Oo0o.(A_0);
				result = (this.O_0.O00o_00_O..GetType("UserCode").GetMethod(A_0) != null);
			}
			return result;
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x001C8518 File Offset: 0x001C6718
		private void <<EMPTY_NAME>>(object A_0, FormatEventArgs A_1)
		{
			Control control = (Control)A_0;
			FormattingEventArgs formattingEventArgs = new FormattingEventArgs(control, this, A_1);
			string a_ = "DataFormat_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				formattingEventArgs
			}, true, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x001C857C File Offset: 0x001C677C
		private void <<EMPTY_NAME>>(object A_0, ParseEventArgs A_1)
		{
			Control control = (Control)A_0;
			ParsingEventArgs parsingEventArgs = new ParsingEventArgs(control, this, A_1);
			string a_ = "DataParse_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				parsingEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x001C85E0 File Offset: 0x001C67E0
		private void <<EMPTY_NAME>>(object A_0, ScrollEventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
				string a_ = "AfterScroll_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname + "," + control.Name, false);
			}
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x001C864C File Offset: 0x001C684C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				if (control.DataBindings.Count > 0 && control.DataBindings[0].BindingManagerBase.Count > 0)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(control.DataBindings[0].BindingManagerBase.Current);
					if (objectValue is DataRowView)
					{
						DataRow row = ((DataRowView)objectValue).Row;
						string bindingField = control.DataBindings[0].BindingMemberInfo.BindingField;
						if (control is C1TextBox)
						{
							C1TextBox c1TextBox = (C1TextBox)control;
							if (Operators.CompareString(row[bindingField].ToString(), c1TextBox.Text, true) != 0)
							{
								c1TextBox.UpdateValueWithCurrentText();
								control.DataBindings[0].WriteValue();
								((DataRowView)objectValue).Row.EndEdit();
							}
						}
					}
				}
				ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
				string a_ = "SelectedIndexChanged_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname + "," + control.Name, false);
			}
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x001C8788 File Offset: 0x001C6988
		private void <<EMPTY_NAME>>(object A_0, SelectedIndexChangingEventArgs A_1)
		{
			Control control = (Control)A_0;
			TabPageChangingEventArgs tabPageChangingEventArgs = new TabPageChangingEventArgs(control, this, A_1);
			string a_ = "SelectedIndexChanging_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				tabPageChangingEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x001C87EC File Offset: 0x001C69EC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
				string a_ = "SelectionChangeCommitted_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname + "," + control.Name, false);
			}
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x001C8858 File Offset: 0x001C6A58
		private void <<EMPTY_NAME>>(object A_0, ListControlConvertEventArgs A_1)
		{
			if (A_1.ListItem is DataRowView)
			{
				Control control = (Control)A_0;
				ListItemFormatEventArgs listItemFormatEventArgs = new ListItemFormatEventArgs(control, this, (DataRowView)A_1.ListItem);
				string a_ = "ListItemFormat_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					listItemFormatEventArgs
				}, false, this.mmname + "," + control.Name, false);
				if (Operators.CompareString(listItemFormatEventArgs.Text, "", true) > 0)
				{
					A_1.Value = listItemFormatEventArgs.Text;
				}
			}
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x001C88F4 File Offset: 0x001C6AF4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				if (control.DataBindings.Count > 0 && control.Focused)
				{
					control.DataBindings[0].WriteValue();
				}
				ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
				string a_ = "CheckedChanged_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname + "," + control.Name, false);
				if (!control.Disposing && !control.IsDisposed && !controlEventArgs.Cancel)
				{
					a_ = "CheckedChanged_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
					O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
					{
						controlEventArgs
					}, false, this.mmname, false);
				}
			}
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x001C89E0 File Offset: 0x001C6BE0
		private void <<EMPTY_NAME>>(object A_0, ItemCheckEventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				ItemCheckEventArgs itemCheckEventArgs = new ItemCheckEventArgs(control, this, A_1);
				string a_ = "ItemCheck_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					itemCheckEventArgs
				}, false, this.mmname + "," + control.Name, false);
			}
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x001C8A4C File Offset: 0x001C6C4C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				this.O_o_.0o0__o0O. = control;
				ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
				string a_ = "ValueChanged_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname + "," + control.Name, false);
				if (!control.Disposing && !control.IsDisposed && !controlEventArgs.Cancel)
				{
					a_ = "ValueChanged_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
					O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
					{
						controlEventArgs
					}, false, this.mmname, false);
				}
				this.O_o_.0o0__o0O. = null;
			}
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x001C8B20 File Offset: 0x001C6D20
		private void <<EMPTY_NAME>>(object A_0, SplitterEventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
				string a_ = "SplitterMoved_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname + "," + control.Name, false);
			}
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x001C8B8C File Offset: 0x001C6D8C
		private void <<EMPTY_NAME>>(object A_0, NodeLabelEditEventArgs A_1)
		{
			((TreeView)A_0).LabelEdit = false;
			if (A_1.Label != null)
			{
				Control control = (Control)A_0;
				TreeNodeEditEventArgs treeNodeEditEventArgs = new TreeNodeEditEventArgs(control, this, new TreeNode((O_o__00Ooo)A_1.Node), A_1.Label);
				string a_ = "AfterEditNode_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					treeNodeEditEventArgs
				}, false, this.mmname + "," + control.Name, false);
				A_1.CancelEdit = treeNodeEditEventArgs.Cancel;
			}
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x001C8C24 File Offset: 0x001C6E24
		private void <<EMPTY_NAME>>(object A_0, NodeLabelEditEventArgs A_1)
		{
			Control control = (Control)A_0;
			TreeNodeEditEventArgs treeNodeEditEventArgs = new TreeNodeEditEventArgs(control, this, new TreeNode((O_o__00Ooo)A_1.Node), A_1.Label);
			string a_ = "BeforeEditNode_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				treeNodeEditEventArgs
			}, false, this.mmname + "," + control.Name, false);
			A_1.CancelEdit = treeNodeEditEventArgs.Cancel;
			if (treeNodeEditEventArgs.Cancel)
			{
				TreeView treeView = (TreeView)A_0;
				treeView.SelectedNode.EndEdit(true);
				treeView.LabelEdit = false;
			}
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x001C8CCC File Offset: 0x001C6ECC
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				TreeViewEventArgs treeViewEventArgs = new TreeViewEventArgs(control, this, new TreeNode((O_o__00Ooo)A_1.Node));
				string a_ = "AfterSelectNode_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					treeViewEventArgs
				}, false, this.mmname + "," + control.Name, false);
			}
		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x001C8D48 File Offset: 0x001C6F48
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				TreeViewEventArgs treeViewEventArgs = new TreeViewEventArgs(control, this, new TreeNode((O_o__00Ooo)A_1.Node));
				string a_ = "AfterExpandNode_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					treeViewEventArgs
				}, false, this.mmname + "," + control.Name, false);
			}
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x001C8DC4 File Offset: 0x001C6FC4
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				TreeViewEventArgs treeViewEventArgs = new TreeViewEventArgs(control, this, new TreeNode((O_o__00Ooo)A_1.Node));
				string a_ = "AfterCollapseNode_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					treeViewEventArgs
				}, false, this.mmname + "," + control.Name, false);
			}
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x001C8E40 File Offset: 0x001C7040
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				O__oO_o0_o_o o__oO_o0_o_o = (O__oO_o0_o_o)A_0;
				if (!((A_1.Action != TreeViewAction.ByKeyboard && A_1.Action != TreeViewAction.ByMouse) & !o__oO_o0_o_o.Ooo__.ooO_0.()))
				{
					TreeViewEventArgs treeViewEventArgs = new TreeViewEventArgs(control, this, new TreeNode((O_o__00Ooo)A_1.Node));
					string a_ = "AfterCheckNode_" + Conversions.ToString(control.Tag);
					O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
					{
						treeViewEventArgs
					}, false, this.mmname + "," + control.Name, false);
				}
			}
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x001C8EE8 File Offset: 0x001C70E8
		private void <<EMPTY_NAME>>(object A_0, TreeViewCancelEventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				TreeView treeView = (TreeView)A_0;
				TreeViewEventArgs treeViewEventArgs = new TreeViewEventArgs(control, this, new TreeNode((O_o__00Ooo)A_1.Node));
				string a_ = "BeforeSelectNode_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					treeViewEventArgs
				}, false, this.mmname + "," + control.Name, false);
				A_1.Cancel = treeViewEventArgs.Cancel;
			}
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x001C8F74 File Offset: 0x001C7174
		private void <<EMPTY_NAME>>(object A_0, TreeViewCancelEventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				TreeViewEventArgs treeViewEventArgs = new TreeViewEventArgs(control, this, new TreeNode((O_o__00Ooo)A_1.Node));
				string a_ = "BeforeExpandNode_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					treeViewEventArgs
				}, false, this.mmname + "," + control.Name, false);
				A_1.Cancel = treeViewEventArgs.Cancel;
			}
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x001C8FFC File Offset: 0x001C71FC
		private void <<EMPTY_NAME>>(object A_0, TreeNodeMouseClickEventArgs A_1)
		{
			try
			{
				TreeView treeView = (TreeView)A_0;
				if (treeView.HitTest(A_1.X, A_1.Y).Location == TreeViewHitTestLocations.Label || treeView.HitTest(A_1.X, A_1.Y).Location == TreeViewHitTestLocations.Image)
				{
					Control control = (Control)A_0;
					if (Operators.CompareString(this.OoO.0_Oo00Ooo., control.Tag.ToString(), true) != 0)
					{
						this.OoO.0_Oo00Ooo. = control.Tag.ToString();
						TreeViewEventArgs treeViewEventArgs = new TreeViewEventArgs(control, this, new TreeNode((O_o__00Ooo)A_1.Node));
						string a_ = "NodeMouseClick_" + Conversions.ToString(control.Tag);
						O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
						{
							treeViewEventArgs
						}, false, this.mmname + "," + control.Name, false);
					}
				}
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
			finally
			{
				this.OoO.0_Oo00Ooo. = null;
			}
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x001C9120 File Offset: 0x001C7320
		private void <<EMPTY_NAME>>(object A_0, TreeNodeMouseClickEventArgs A_1)
		{
			Control control = (Control)A_0;
			TreeView treeView = (TreeView)control;
			TreeNode treeNode;
			if (treeView.SelectedNode != null)
			{
				treeNode = treeView.SelectedNode;
			}
			else
			{
				treeNode = A_1.Node;
			}
			TreeViewEventArgs treeViewEventArgs = new TreeViewEventArgs(control, this, new TreeNode((O_o__00Ooo)treeNode));
			string a_ = "NodeMouseDoubleClick_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				treeViewEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E97 RID: 16023 RVA: 0x001C91B4 File Offset: 0x001C73B4
		private void <<EMPTY_NAME>>(object A_0, TreeNodeMouseHoverEventArgs A_1)
		{
			Control control = (Control)A_0;
			TreeViewEventArgs treeViewEventArgs = new TreeViewEventArgs(control, this, new TreeNode((O_o__00Ooo)A_1.Node));
			string a_ = "NodeMouseHover_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				treeViewEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E98 RID: 16024 RVA: 0x001C9228 File Offset: 0x001C7428
		private void <<EMPTY_NAME>>(object A_0, C1TopicBarClickEventArgs A_1)
		{
			try
			{
				Control control = (Control)A_0;
				if (Operators.CompareString(this.OoO.0_Oo00Ooo., control.Tag.ToString(), true) != 0)
				{
					this.OoO.0_Oo00Ooo. = control.Tag.ToString();
					TopicLinkEventArgs topicLinkEventArgs = new TopicLinkEventArgs(control, this, A_1);
					string a_ = "TopicLinkClick_" + Conversions.ToString(control.Tag);
					O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
					{
						topicLinkEventArgs
					}, false, this.mmname + "," + control.Name, false);
				}
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
			finally
			{
				this.OoO.0_Oo00Ooo. = null;
			}
		}

		// Token: 0x06003E99 RID: 16025 RVA: 0x001C92F8 File Offset: 0x001C74F8
		private void <<EMPTY_NAME>>(object A_0, C1TopicBarPageEventArgs A_1)
		{
			Control control = (Control)A_0;
			TopicPageEventArgs topicPageEventArgs = new TopicPageEventArgs(control, this, A_1);
			string a_ = "TopicPageCollapsed_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				topicPageEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E9A RID: 16026 RVA: 0x001C935C File Offset: 0x001C755C
		private void <<EMPTY_NAME>>(object A_0, C1TopicBarPageEventArgs A_1)
		{
			Control control = (Control)A_0;
			TopicPageEventArgs topicPageEventArgs = new TopicPageEventArgs(control, this, A_1);
			string a_ = "TopicPageExpanded_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				topicPageEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E9B RID: 16027 RVA: 0x001C93C0 File Offset: 0x001C75C0
		private void <<EMPTY_NAME>>(object A_0, UpDownButtonClickEventArgs A_1)
		{
			Control control = (Control)A_0;
			UpDownButtonClickEventArgs upDownButtonClickEventArgs = new UpDownButtonClickEventArgs(control, this, A_1.Delta);
			string a_ = "UpDownButtonClick_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				upDownButtonClickEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E9C RID: 16028 RVA: 0x001C9428 File Offset: 0x001C7628
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
			string a_ = "ModalButtonClick_" + Conversions.ToString(control.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + control.Name, false);
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x001C948C File Offset: 0x001C768C
		private void <<EMPTY_NAME>>(object A_0, DateRangeEventArgs A_1)
		{
			MonthCalendar monthCalendar = (MonthCalendar)A_0;
			monthCalendar.SelectionEnd = monthCalendar.SelectionStart;
			ControlEventArgs controlEventArgs = new ControlEventArgs(monthCalendar, this);
			string a_ = "DateChanged_" + Conversions.ToString(monthCalendar.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + monthCalendar.Name, false);
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x001C94FC File Offset: 0x001C76FC
		private void <<EMPTY_NAME>>(object A_0, DateRangeEventArgs A_1)
		{
			MonthCalendar monthCalendar = (MonthCalendar)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(monthCalendar, this);
			string a_ = "DateSelected_" + Conversions.ToString(monthCalendar.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + monthCalendar.Name, false);
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x001C9560 File Offset: 0x001C7760
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Control control = (Control)A_0;
			if (control.FindForm() != null)
			{
				ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
				string a_ = "Scroll_" + Conversions.ToString(control.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname + "," + control.Name, false);
			}
		}

		/// <summary>
		/// 窗口名
		/// </summary>
		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06003EA0 RID: 16032 RVA: 0x001C95C9 File Offset: 0x001C77C9
		public string Name
		{
			get
			{
				return this.O_o_.0o0__o0O.["Name"].ToString();
			}
		}

		// Token: 0x06003EA1 RID: 16033 RVA: 0x001C95E0 File Offset: 0x001C77E0
		private void <<EMPTY_NAME>>(object A_0, LabelEditEventArgs A_1)
		{
			if (A_1.Label == null)
			{
				A_1.CancelEdit = true;
				return;
			}
			o_OO_oOOO0o o_OO_oOOO0o = (o_OO_oOOO0o)A_0;
			ListViewEditEventArgs listViewEditEventArgs = new ListViewEditEventArgs(o_OO_oOOO0o, this, new ListViewRow(o_OO_oOOO0o.Items[A_1.Item]), A_1.Label);
			string a_ = "AfterEdit_" + Conversions.ToString(o_OO_oOOO0o.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				listViewEditEventArgs
			}, false, this.mmname + "," + o_OO_oOOO0o.Name, false);
			if (listViewEditEventArgs.Cancel)
			{
				A_1.CancelEdit = true;
			}
		}

		// Token: 0x06003EA2 RID: 16034 RVA: 0x001C967C File Offset: 0x001C787C
		private void <<EMPTY_NAME>>(object A_0, LabelEditEventArgs A_1)
		{
			o_OO_oOOO0o o_OO_oOOO0o = (o_OO_oOOO0o)A_0;
			ListViewEditEventArgs listViewEditEventArgs = new ListViewEditEventArgs(o_OO_oOOO0o, this, new ListViewRow(o_OO_oOOO0o.Items[A_1.Item]), A_1.Label);
			string a_ = "BeforeEdit_" + Conversions.ToString(o_OO_oOOO0o.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				listViewEditEventArgs
			}, false, this.mmname + "," + o_OO_oOOO0o.Name, false);
			if (listViewEditEventArgs.Cancel)
			{
				A_1.CancelEdit = true;
			}
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x001C9708 File Offset: 0x001C7908
		private void <<EMPTY_NAME>>(object A_0, RetrieveVirtualItemEventArgs A_1)
		{
			o_OO_oOOO0o o_OO_oOOO0o = (o_OO_oOOO0o)A_0;
			this.Oo_O00ooo.OO_.(o_OO_oOOO0o, A_1.ItemIndex);
			A_1.Item = o_OO_oOOO0o.o0__o.O0.[A_1.ItemIndex].BaseItem;
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x001C9748 File Offset: 0x001C7948
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o_OO_oOOO0o o_OO_oOOO0o = (o_OO_oOOO0o)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(o_OO_oOOO0o, this);
			string a_ = "RowActivate_" + Conversions.ToString(o_OO_oOOO0o.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + o_OO_oOOO0o.Name, false);
		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x001C97AC File Offset: 0x001C79AC
		private void <<EMPTY_NAME>>(object A_0, ListViewItemSelectionChangedEventArgs A_1)
		{
			o_OO_oOOO0o o_OO_oOOO0o = (o_OO_oOOO0o)A_0;
			ListViewRowEventArgs listViewRowEventArgs = new ListViewRowEventArgs(o_OO_oOOO0o, this, new ListViewRow(A_1.Item), A_1.ItemIndex);
			string a_ = "RowSelectionChanged_" + Conversions.ToString(o_OO_oOOO0o.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				listViewRowEventArgs
			}, false, this.mmname + "," + o_OO_oOOO0o.Name, false);
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x001C9820 File Offset: 0x001C7A20
		private void <<EMPTY_NAME>>(object A_0, ItemCheckEventArgs A_1)
		{
			if (A_1.NewValue != A_1.CurrentValue)
			{
				o_OO_oOOO0o o_OO_oOOO0o = (o_OO_oOOO0o)A_0;
				ListViewRowEventArgs listViewRowEventArgs = new ListViewRowEventArgs(o_OO_oOOO0o, this, new ListViewRow(o_OO_oOOO0o.Items[A_1.Index]), A_1.Index);
				string a_ = "RowChecking_" + Conversions.ToString(o_OO_oOOO0o.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					listViewRowEventArgs
				}, false, this.mmname + "," + o_OO_oOOO0o.Name, false);
				if (listViewRowEventArgs.Cancel)
				{
					A_1.NewValue = A_1.CurrentValue;
				}
			}
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x001C98C4 File Offset: 0x001C7AC4
		private void <<EMPTY_NAME>>(object A_0, ItemCheckedEventArgs A_1)
		{
			o_OO_oOOO0o o_OO_oOOO0o = (o_OO_oOOO0o)A_0;
			ListViewRowEventArgs listViewRowEventArgs = new ListViewRowEventArgs(o_OO_oOOO0o, this, new ListViewRow(A_1.Item), A_1.Item.Index);
			string a_ = "RowChecked_" + Conversions.ToString(o_OO_oOOO0o.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				listViewRowEventArgs
			}, false, this.mmname + "," + o_OO_oOOO0o.Name, false);
		}

		// Token: 0x06003EA8 RID: 16040 RVA: 0x001C993C File Offset: 0x001C7B3C
		private void <<EMPTY_NAME>>(object A_0, DrawListViewSubItemEventArgs A_1)
		{
			o_OO_oOOO0o o_OO_oOOO0o = (o_OO_oOOO0o)A_0;
			ListViewRow a_ = new ListViewRow(A_1.Item);
			ListViewColumn a_2 = new ListViewColumn(A_1.Header);
			ListViewDrawCellEventArgs listViewDrawCellEventArgs = new ListViewDrawCellEventArgs(o_OO_oOOO0o, this, a_, a_2, A_1);
			string a_3 = "DrawViewCell_" + Conversions.ToString(o_OO_oOOO0o.Tag);
			A_1.DrawDefault = true;
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_3, new object[]
			{
				listViewDrawCellEventArgs
			}, false, this.mmname + "," + o_OO_oOOO0o.Name, false);
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x001C99C4 File Offset: 0x001C7BC4
		private void <<EMPTY_NAME>>(object A_0, C1.Win.C1Gauge.ItemEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Container;
			GaugeItemEventArgs gaugeItemEventArgs = new GaugeItemEventArgs(o0_O_0O, this, A_1);
			string a_ = "GaugeItemClick_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugeItemEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x001C9A2C File Offset: 0x001C7C2C
		private void <<EMPTY_NAME>>(object A_0, C1.Win.C1Gauge.ItemEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Container;
			GaugeItemEventArgs gaugeItemEventArgs = new GaugeItemEventArgs(o0_O_0O, this, A_1);
			string a_ = "GaugeItemDoubleClick_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugeItemEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x001C9A94 File Offset: 0x001C7C94
		private void <<EMPTY_NAME>>(object A_0, C1.Win.C1Gauge.ItemEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Container;
			GaugeItemEventArgs gaugeItemEventArgs = new GaugeItemEventArgs(o0_O_0O, this, A_1);
			string a_ = "GaugeItemStateChanged_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugeItemEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x001C9AFC File Offset: 0x001C7CFC
		private void <<EMPTY_NAME>>(object A_0, ItemMouseEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Container;
			GaugeItemMouseEventArgs gaugeItemMouseEventArgs = new GaugeItemMouseEventArgs(o0_O_0O, this, A_1);
			string a_ = "GaugeItemMouseUp_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugeItemMouseEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x001C9B64 File Offset: 0x001C7D64
		private void <<EMPTY_NAME>>(object A_0, ItemMouseEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Container;
			GaugeItemMouseEventArgs gaugeItemMouseEventArgs = new GaugeItemMouseEventArgs(o0_O_0O, this, A_1);
			string a_ = "GaugeItemMouseDown_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugeItemMouseEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x001C9BCC File Offset: 0x001C7DCC
		private void <<EMPTY_NAME>>(object A_0, C1.Win.C1Gauge.ItemEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Container;
			GaugeItemEventArgs gaugeItemEventArgs = new GaugeItemEventArgs(o0_O_0O, this, A_1);
			string a_ = "GaugeItemMouseEnter_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugeItemEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x001C9C34 File Offset: 0x001C7E34
		private void <<EMPTY_NAME>>(object A_0, C1.Win.C1Gauge.ItemEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Container;
			GaugeItemEventArgs gaugeItemEventArgs = new GaugeItemEventArgs(o0_O_0O, this, A_1);
			string a_ = "GaugeItemMouseLeave_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugeItemEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x001C9C9C File Offset: 0x001C7E9C
		private void <<EMPTY_NAME>>(object A_0, ItemMouseEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Container;
			GaugeItemMouseEventArgs gaugeItemMouseEventArgs = new GaugeItemMouseEventArgs(o0_O_0O, this, A_1);
			string a_ = "GaugeItemMouseMove_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugeItemMouseEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x001C9D04 File Offset: 0x001C7F04
		private void <<EMPTY_NAME>>(object A_0, PointerValueChangedEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Pointer.Owner.Owner;
			GaugePointerValueChangedEventArgs gaugePointerValueChangedEventArgs = new GaugePointerValueChangedEventArgs(o0_O_0O, this, A_1.Pointer.Owner, o0_O_0O, A_1.Pointer);
			string a_ = "GaugePointerValueChanged_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugePointerValueChangedEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x001C9D88 File Offset: 0x001C7F88
		private void <<EMPTY_NAME>>(object A_0, PointerDragEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Container;
			GaugePointerDragEventArgs gaugePointerDragEventArgs = new GaugePointerDragEventArgs(o0_O_0O, this, A_1);
			string a_ = "PointerDragMove_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugePointerDragEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x001C9DF0 File Offset: 0x001C7FF0
		private void <<EMPTY_NAME>>(object A_0, PointerDragEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Container;
			GaugePointerDragEventArgs gaugePointerDragEventArgs = new GaugePointerDragEventArgs(o0_O_0O, this, A_1);
			string a_ = "PointerDragBegin_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugePointerDragEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x001C9E58 File Offset: 0x001C8058
		private void <<EMPTY_NAME>>(object A_0, FormatLabelEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Decorator.Owner.Owner;
			GaugeFormatLabelEventArgs gaugeFormatLabelEventArgs = new GaugeFormatLabelEventArgs(o0_O_0O, this, A_1);
			string a_ = "GaugeFormatLabel_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugeFormatLabelEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x001C9ECC File Offset: 0x001C80CC
		private void <<EMPTY_NAME>>(object A_0, PointerDragEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Container;
			GaugePointerDragEventArgs gaugePointerDragEventArgs = new GaugePointerDragEventArgs(o0_O_0O, this, A_1);
			string a_ = "PointerDragEnd_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugePointerDragEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x001C9F34 File Offset: 0x001C8134
		private void <<EMPTY_NAME>>(object A_0, PointerDragEventArgs A_1)
		{
			O0_O_0O o0_O_0O = (O0_O_0O)A_1.Container;
			GaugePointerDragEventArgs gaugePointerDragEventArgs = new GaugePointerDragEventArgs(o0_O_0O, this, A_1);
			string a_ = "PointerDragCancel_" + Conversions.ToString(o0_O_0O.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				gaugePointerDragEventArgs
			}, false, this.mmname + "," + o0_O_0O.Name, false);
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x001C9F9C File Offset: 0x001C819C
		private void <<EMPTY_NAME>>(object A_0, CancelTaskArgs A_1)
		{
			GanttView ganttView = (GanttView)A_0;
			GanttTaskEventArgs ganttTaskEventArgs = new GanttTaskEventArgs(ganttView, this, A_1);
			string a_ = "AfterEditTask_" + Conversions.ToString(ganttView.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				ganttTaskEventArgs
			}, false, this.mmname + "," + ganttView.Name, false);
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x001CA000 File Offset: 0x001C8200
		private void <<EMPTY_NAME>>(object A_0, CancelTaskArgs A_1)
		{
			GanttView ganttView = (GanttView)A_0;
			GanttTaskEventArgs ganttTaskEventArgs = new GanttTaskEventArgs(ganttView, this, A_1);
			string a_ = "BeforeEditTask_" + Conversions.ToString(ganttView.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				ganttTaskEventArgs
			}, false, this.mmname + "," + ganttView.Name, false);
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x001CA064 File Offset: 0x001C8264
		private void <<EMPTY_NAME>>(object A_0, CancelTaskArgs A_1)
		{
			GanttView ganttView = (GanttView)A_0;
			GanttTaskEventArgs ganttTaskEventArgs = new GanttTaskEventArgs(ganttView, this, A_1);
			string a_ = "BeforeAddTask_" + Conversions.ToString(ganttView.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				ganttTaskEventArgs
			}, false, this.mmname + "," + ganttView.Name, false);
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x001CA0C8 File Offset: 0x001C82C8
		private void <<EMPTY_NAME>>(object A_0, CancelTaskArgs A_1)
		{
			GanttView ganttView = (GanttView)A_0;
			GanttTaskEventArgs ganttTaskEventArgs = new GanttTaskEventArgs(ganttView, this, A_1);
			string a_ = "BeforeRemoveTask_" + Conversions.ToString(ganttView.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				ganttTaskEventArgs
			}, false, this.mmname + "," + ganttView.Name, false);
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x001CA12C File Offset: 0x001C832C
		private void <<EMPTY_NAME>>(object A_0, CancelTasksArgs A_1)
		{
			GanttView ganttView = (GanttView)A_0;
			GanttTasksEventArgs ganttTasksEventArgs = new GanttTasksEventArgs(ganttView, this, A_1);
			string a_ = "BeforeMoveTasks_" + Conversions.ToString(ganttView.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				ganttTasksEventArgs
			}, false, this.mmname + "," + ganttView.Name, false);
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x001CA190 File Offset: 0x001C8390
		private void <<EMPTY_NAME>>(object A_0, TaskBarTooltipEventArgs A_1)
		{
			GanttView ganttView = (GanttView)A_0;
			GanttTaskBarTooltipEventArgs ganttTaskBarTooltipEventArgs = new GanttTaskBarTooltipEventArgs(ganttView, this, A_1);
			string a_ = "TaskBarTooltip_" + Conversions.ToString(ganttView.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				ganttTaskBarTooltipEventArgs
			}, false, this.mmname + "," + ganttView.Name, false);
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x001CA1F4 File Offset: 0x001C83F4
		private void <<EMPTY_NAME>>(object A_0, TaskBarClickEventArgs A_1)
		{
			GanttView ganttView = (GanttView)A_0;
			if ((DateTime.Now - ganttView.oo0ooO000O.O.).TotalSeconds <= 0.6)
			{
				GanttTaskBarClickEventArgs ganttTaskBarClickEventArgs = new GanttTaskBarClickEventArgs(ganttView, this, A_1);
				string a_ = "TaskBarClick_" + Conversions.ToString(ganttView.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					ganttTaskBarClickEventArgs
				}, false, this.mmname + "," + ganttView.Name, false);
			}
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x001CA27C File Offset: 0x001C847C
		private void <<EMPTY_NAME>>(object A_0, PaintDayEventArgs A_1)
		{
			GanttView ganttView = (GanttView)A_0;
			GanttPaintDayEventArgs ganttPaintDayEventArgs = new GanttPaintDayEventArgs(ganttView, this, A_1);
			string a_ = "PaintDay_" + Conversions.ToString(ganttView.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				ganttPaintDayEventArgs
			}, false, this.mmname + "," + ganttView.Name, false);
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x001CA2E0 File Offset: 0x001C84E0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			GanttView ganttView = (GanttView)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(ganttView, this);
			string a_ = "SelectedIndexChanged_" + Conversions.ToString(ganttView.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + ganttView.Name, false);
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x001CA344 File Offset: 0x001C8544
		private void <<EMPTY_NAME>>(object A_0, ToolStripItemClickedEventArgs A_1)
		{
			if (!A_1.ClickedItem.Name.StartsWith("ts"))
			{
				Control parent = this.o_.oo_o_00_.(A_1.ClickedItem).Parent;
				GannttStripItemClikEventArgs gannttStripItemClikEventArgs = new GannttStripItemClikEventArgs(parent, this, A_1);
				string a_ = "GannttStripItemClik_" + Conversions.ToString(parent.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					gannttStripItemClikEventArgs
				}, false, this.mmname + "," + parent.Name, false);
			}
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x001CA3C8 File Offset: 0x001C85C8
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2InitializationCompletedEventArgs A_1)
		{
			WebViewer webViewer = (WebViewer)A_0;
			if (webViewer.CoreWebView2 != null)
			{
				webViewer.CoreWebView2.Settings.AreDevToolsEnabled = webViewer.AreDevToolsEnabled;
				webViewer.CoreWebView2.Settings.AreDefaultContextMenusEnabled = webViewer.AreDefaultContextMenusEnabled;
				webViewer.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = webViewer.AreBrowserAcceleratorKeysEnabled;
				webViewer.CoreWebView2.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.All);
				webViewer.CoreWebView2.Settings.AreHostObjectsAllowed = true;
				webViewer.CoreWebView2.Settings.IsWebMessageEnabled = true;
				webViewer.CoreWebView2.NavigationStarting += this.O0O0.O.;
				webViewer.CoreWebView2.NavigationCompleted += this.O0O0.O.;
				webViewer.CoreWebView2.ContentLoading += this.OOO0.OOOoO.;
				webViewer.CoreWebView2.SourceChanged += this.O0O0.O.;
				webViewer.CoreWebView2.DOMContentLoaded += this.O0O0.O.;
				webViewer.CoreWebView2.ScriptDialogOpening += this.OO.OoO_o.;
				webViewer.CoreWebView2.StatusBarTextChanged += this.O0_0O.__0_.;
				webViewer.CoreWebView2.ContextMenuRequested += this.OOO0.OOOoO.;
				webViewer.CoreWebView2.HistoryChanged += this.O0O0.O.;
				webViewer.CoreWebView2.WebMessageReceived += this.OO.OoO_o.;
				webViewer.CoreWebView2.NewWindowRequested += this.O0O0.O.;
				webViewer.CoreWebView2.WebResourceRequested += this.OO.OoO_o.;
				webViewer.CoreWebView2.WebResourceResponseReceived += this.OO.OoO_o.;
				webViewer.CoreWebView2.SaveAsUIShowing += this.O0O0.O.;
				webViewer.CoreWebView2.DownloadStarting += this.O0O0.O.;
				webViewer.CoreWebView2.PermissionRequested += this.O0O0.O.;
			}
			InitializationCompletedEventArgs initializationCompletedEventArgs = new InitializationCompletedEventArgs(webViewer, this, A_1);
			string a_ = "InitializationCompleted_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				initializationCompletedEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x001CA61C File Offset: 0x001C881C
		private WebViewer <<EMPTY_NAME>>(CoreWebView2 A_0)
		{
			try
			{
				foreach (Control control in this.Controls)
				{
					if (control.BaseControl is WebViewer && ((WebViewer)control.BaseControl).CoreWebView2 == A_0)
					{
						return (WebViewer)control.BaseControl;
					}
				}
			}
			finally
			{
				IEnumerator<Control> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return null;
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x001CA694 File Offset: 0x001C8894
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2NavigationStartingEventArgs A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			NavigationStartingEventArgs navigationStartingEventArgs = new NavigationStartingEventArgs(webViewer, this, A_1);
			string a_2 = "NavigationStarting_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				navigationStartingEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x001CA700 File Offset: 0x001C8900
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2NavigationCompletedEventArgs A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			NavigationCompletedEventArgs navigationCompletedEventArgs = new NavigationCompletedEventArgs(webViewer, this, A_1);
			string a_2 = "NavigationCompleted_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				navigationCompletedEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x001CA76C File Offset: 0x001C896C
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2ContentLoadingEventArgs A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			ContentLoadingEventArgs contentLoadingEventArgs = new ContentLoadingEventArgs(webViewer, this, A_1);
			string a_2 = "ContentLoading_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				contentLoadingEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x001CA7D8 File Offset: 0x001C89D8
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2SourceChangedEventArgs A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			SourceChangedEventArgs sourceChangedEventArgs = new SourceChangedEventArgs(webViewer, this, A_1);
			string a_2 = "SourceChanged_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				sourceChangedEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x001CA844 File Offset: 0x001C8A44
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2DOMContentLoadedEventArgs A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			DOMContentLoadedEventArgs domcontentLoadedEventArgs = new DOMContentLoadedEventArgs(webViewer, this, A_1);
			string a_2 = "DOMContentLoaded_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				domcontentLoadedEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x001CA8B0 File Offset: 0x001C8AB0
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2ScriptDialogOpeningEventArgs A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			ScriptDialogOpeningEventArgs scriptDialogOpeningEventArgs = new ScriptDialogOpeningEventArgs(webViewer, this, A_1);
			string a_2 = "ScriptDialogOpening_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				scriptDialogOpeningEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x001CA91C File Offset: 0x001C8B1C
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2ContextMenuRequestedEventArgs A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			ContextMenuRequestedEventArgs contextMenuRequestedEventArgs = new ContextMenuRequestedEventArgs(webViewer, this, A_1);
			string a_2 = "ContextMenuRequested_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				contextMenuRequestedEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x001CA988 File Offset: 0x001C8B88
		private void <<EMPTY_NAME>>(object A_0, object A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			ControlEventArgs controlEventArgs = new ControlEventArgs(webViewer, this);
			string a_2 = "StatusBarTextChanged_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x001CA9F4 File Offset: 0x001C8BF4
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2DownloadStartingEventArgs A_1)
		{
			Form.ooOOO_oOOo ooOOO_oOOo = new Form.ooOOO_oOOo();
			ooOOO_oOOo.O_.__ooooo. = this;
			CoreWebView2 a_ = (CoreWebView2)A_0;
			ooOOO_oOOo.O_.__ooooo. = this.O0O.OO0OO0.(a_);
			DownloadStartingEventArgs downloadStartingEventArgs = new DownloadStartingEventArgs(ooOOO_oOOo.O_.__ooooo., this, A_1);
			ooOOO_oOOo.O_.__ooooo. = "DownloadStarting_" + Conversions.ToString(ooOOO_oOOo.O_.__ooooo..Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., ooOOO_oOOo.O_.__ooooo., new object[]
			{
				downloadStartingEventArgs
			}, false, this.mmname + "," + ooOOO_oOOo.O_.__ooooo..Name, false);
			ooOOO_oOOo.O_.__ooooo. = A_1.DownloadOperation;
			if (ooOOO_oOOo.O_.__ooooo..oo_.0oOOOoooo. != null)
			{
				ooOOO_oOOo.O_.__ooooo..oo_.0oOOOoooo.[ooOOO_oOOo.O_.__ooooo.] = new TaskCompletionSource<int>();
				ooOOO_oOOo.O_.__ooooo..oo_.0oOOOoooo..SetResult(ooOOO_oOOo.O_.__ooooo.);
			}
			if (!A_1.Cancel)
			{
				Form.oo0o_oo oo0o_oo = new Form.oo0o_oo();
				oo0o_oo.O_.__ooooo. = ooOOO_oOOo;
				oo0o_oo.O_o_.0o0__o0O. = DateTime.MinValue;
				oo0o_oo.O_o_.0o0__o0O. = new EventHandler<object>(oo0o_oo.O_o_.0o0__o0O.);
				oo0o_oo.oOO_0_oo.Oo0. = new EventHandler<object>(oo0o_oo.oOO_0_oo.Oo0.);
				oo0o_oo.O_.__ooooo..O_.__ooooo..OoO.oOOoo..TryAdd(oo0o_oo.O_.__ooooo..O_.__ooooo., oo0o_oo.O_o_.0o0__o0O.);
				oo0o_oo.O_.__ooooo..O_.__ooooo..oo_.0oOOOoooo..TryAdd(oo0o_oo.O_.__ooooo..O_.__ooooo., oo0o_oo.oOO_0_oo.Oo0.);
				oo0o_oo.O_.__ooooo..O_.__ooooo..BytesReceivedChanged += oo0o_oo.O_o_.0o0__o0O.;
				oo0o_oo.O_.__ooooo..O_.__ooooo..StateChanged += oo0o_oo.oOO_0_oo.Oo0.;
			}
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x001CAB94 File Offset: 0x001C8D94
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			WebViewer webViewer = (WebViewer)A_0;
			ControlEventArgs controlEventArgs = new ControlEventArgs(webViewer, this);
			string a_ = "ZoomFactorChanged_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x001CABF8 File Offset: 0x001C8DF8
		private void <<EMPTY_NAME>>(object A_0, object A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			ControlEventArgs controlEventArgs = new ControlEventArgs(webViewer, this);
			string a_2 = "HistoryChanged_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				controlEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x001CAC64 File Offset: 0x001C8E64
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2WebMessageReceivedEventArgs A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			WebMessageReceivedEventArgs webMessageReceivedEventArgs = new WebMessageReceivedEventArgs(webViewer, this, A_1);
			string a_2 = "WebMessageReceived_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				webMessageReceivedEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x001CACD0 File Offset: 0x001C8ED0
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2NewWindowRequestedEventArgs A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			NewWindowRequestedEventArgs newWindowRequestedEventArgs = new NewWindowRequestedEventArgs(webViewer, this, A_1);
			string a_2 = "NewWindowRequested_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				newWindowRequestedEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x001CAD3C File Offset: 0x001C8F3C
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2WebResourceRequestedEventArgs A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			WebResourceRequestedEventArgs webResourceRequestedEventArgs = new WebResourceRequestedEventArgs(webViewer, this, A_1);
			string a_2 = "WebResourceRequested_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				webResourceRequestedEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x001CADA8 File Offset: 0x001C8FA8
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2WebResourceResponseReceivedEventArgs A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			WebViewer webViewer = this.O0O.OO0OO0.(a_);
			WebResourceResponseReceivedEventArgs webResourceResponseReceivedEventArgs = new WebResourceResponseReceivedEventArgs(webViewer, this, A_1);
			string a_2 = "WebResourceResponseReceived_" + Conversions.ToString(webViewer.Tag);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
			{
				webResourceResponseReceivedEventArgs
			}, false, this.mmname + "," + webViewer.Name, false);
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x001CAE14 File Offset: 0x001C9014
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2SaveAsUIShowingEventArgs A_1)
		{
			CoreWebView2 a_ = (CoreWebView2)A_0;
			if (!this.O0O.OO0OO0.(a_).AreSaveAsEnabled)
			{
				A_1.Cancel = true;
			}
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x001CAE3D File Offset: 0x001C903D
		private void <<EMPTY_NAME>>(object A_0, CoreWebView2PermissionRequestedEventArgs A_1)
		{
			if (A_1.PermissionKind == CoreWebView2PermissionKind.MultipleAutomaticDownloads)
			{
				A_1.State = CoreWebView2PermissionState.Allow;
				A_1.SavesInProfile = true;
				A_1.Handled = true;
			}
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x001CAE5D File Offset: 0x001C905D
		private void <<EMPTY_NAME>>(object A_0, DrawListViewColumnHeaderEventArgs A_1)
		{
			A_1.DrawDefault = true;
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x001CAE66 File Offset: 0x001C9066
		private void <<EMPTY_NAME>>(object A_0, DrawListViewItemEventArgs A_1)
		{
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x001CAE68 File Offset: 0x001C9068
		private void <<EMPTY_NAME>>(object A_0, CacheVirtualItemsEventArgs A_1)
		{
			o_OO_oOOO0o a_ = (o_OO_oOOO0o)A_0;
			int startIndex = A_1.StartIndex;
			int endIndex = A_1.EndIndex;
			for (int i = startIndex; i <= endIndex; i++)
			{
				this.Oo_O00ooo.OO_.(a_, i);
			}
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x001CAE9C File Offset: 0x001C909C
		private void <<EMPTY_NAME>>(o_OO_oOOO0o A_0, int A_1)
		{
			if (!A_0.o0__o.O0..ContainsKey(A_1))
			{
				ooO0__O0_O ooO0__O0_O = new ooO0__O0_O();
				ooO0__O0_O.o0.oooO.(A_0.O_O.0Oo_o.());
				if (A_0.Columns.Count > 0)
				{
					int num = A_0.Columns.Count - 1;
					for (int i = 1; i <= num; i++)
					{
						ooO0__O0_O.SubItems.Add("").Name = A_0.Columns[i].Name;
					}
				}
				ListViewRowEventArgs listViewRowEventArgs = new ListViewRowEventArgs(A_0, this, new ListViewRow(ooO0__O0_O), A_1);
				string a_ = "RetrieveVirtualRow_" + Conversions.ToString(A_0.Tag);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					listViewRowEventArgs
				}, false, this.mmname + "," + A_0.Name, false);
				if (Operators.CompareString(ooO0__O0_O.ImageKey, "", true) > 0)
				{
					int num2 = A_0.SmallImageList.Images.IndexOfKey(ooO0__O0_O.ImageKey);
					if (num2 >= 0)
					{
						ooO0__O0_O.ImageIndex = num2;
					}
					else
					{
						num2 = A_0.LargeImageList.Images.IndexOfKey(ooO0__O0_O.ImageKey);
						if (num2 >= 0)
						{
							ooO0__O0_O.ImageIndex = num2;
						}
					}
				}
				if (A_0.CheckBoxes && !ooO0__O0_O.Checked)
				{
					ooO0__O0_O.Checked = true;
					ooO0__O0_O.Checked = false;
				}
				A_0.o0__o.O0..Add(A_1, new ListViewRow(ooO0__O0_O));
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06003ED8 RID: 16088 RVA: 0x001CB003 File Offset: 0x001C9203
		public FormPanel Panel
		{
			get
			{
				return this.Pane;
			}
		}

		/// <summary>
		/// 返回底层的System.Windows.Forms.Form
		/// </summary>
		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06003ED9 RID: 16089 RVA: 0x001CB00C File Offset: 0x001C920C
		public Form BaseForm
		{
			get
			{
				Form result;
				if (this.Pane != null && this.Pane.FindForm() != Main.OO_O.o.)
				{
					result = this.Pane.FindForm();
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x001CB044 File Offset: 0x001C9244
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AutoOpen
		{
			get
			{
				return Convert.ToBoolean(RuntimeHelpers.GetObjectValue(this.O_o_.0o0__o0O.["AutoOpen"]));
			}
		}

		/// <summary>
		/// 返回所有者表的表名
		/// </summary>
		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06003EDB RID: 16091 RVA: 0x001CB060 File Offset: 0x001C9260
		public string TableName
		{
			get
			{
				return this.O_o_.0o0__o0O.["Table"].ToString();
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x001CB077 File Offset: 0x001C9277
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Category
		{
			get
			{
				return this.O_o_.0o0__o0O.["pth"].ToString();
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06003EDD RID: 16093 RVA: 0x001CB08E File Offset: 0x001C928E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool IsMain
		{
			get
			{
				return this.FormStyle == FormStyleEnum.主窗口;
			}
		}

		/// <summary>
		/// 判断窗口是否已经打开
		/// </summary>
		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06003EDE RID: 16094 RVA: 0x001CB099 File Offset: 0x001C9299
		[oO0oooo("0705")]
		public bool Opened
		{
			get
			{
				return this.Pane != null && this.Pane.FindForm() != null;
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06003EDF RID: 16095 RVA: 0x001CB0B3 File Offset: 0x001C92B3
		// (set) Token: 0x06003EE0 RID: 16096 RVA: 0x001CB0BB File Offset: 0x001C92BB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public FormStyleEnum FormStyle
		{
			get
			{
				return this.ooOO0__._0O.;
			}
			set
			{
				this.ooOO0__._0O. = value;
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06003EE1 RID: 16097 RVA: 0x001CB0C4 File Offset: 0x001C92C4
		// (set) Token: 0x06003EE2 RID: 16098 RVA: 0x001CB0CC File Offset: 0x001C92CC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShowIcon
		{
			get
			{
				return this.O0_.0O0__0OO.;
			}
			set
			{
				this.O0_.0O0__0OO. = value;
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06003EE3 RID: 16099 RVA: 0x001CB0D5 File Offset: 0x001C92D5
		// (set) Token: 0x06003EE4 RID: 16100 RVA: 0x001CB0DD File Offset: 0x001C92DD
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ControlBox
		{
			get
			{
				return this.oOo.O0__0Oo0.;
			}
			set
			{
				this.oOo.O0__0Oo0. = value;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06003EE5 RID: 16101 RVA: 0x001CB0E6 File Offset: 0x001C92E6
		// (set) Token: 0x06003EE6 RID: 16102 RVA: 0x001CB0EE File Offset: 0x001C92EE
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool MaximizeBox
		{
			get
			{
				return this.OOO.0__oO.;
			}
			set
			{
				this.OOO.0__oO. = value;
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06003EE7 RID: 16103 RVA: 0x001CB0F7 File Offset: 0x001C92F7
		// (set) Token: 0x06003EE8 RID: 16104 RVA: 0x001CB0FF File Offset: 0x001C92FF
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool MinimizeBox
		{
			get
			{
				return this.oO.oo_.;
			}
			set
			{
				this.oO.oo_. = value;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06003EE9 RID: 16105 RVA: 0x001CB108 File Offset: 0x001C9308
		// (set) Token: 0x06003EEA RID: 16106 RVA: 0x001CB110 File Offset: 0x001C9310
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool DockTitle
		{
			get
			{
				return this.O._0O0__0_0o_0.;
			}
			set
			{
				this.O._0O0__0_0o_0. = value;
			}
		}

		/// <summary>
		/// 窗口标题
		/// </summary>
		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06003EEB RID: 16107 RVA: 0x001CB119 File Offset: 0x001C9319
		// (set) Token: 0x06003EEC RID: 16108 RVA: 0x001CB124 File Offset: 0x001C9324
		public string Text
		{
			get
			{
				return this.o_0.o0.;
			}
			set
			{
				this.o_0.o0. = value;
				if (this.Pane != null && this.Pane.FindForm() != null)
				{
					if (this.Pane.FindForm() != Main.OO_O.o.)
					{
						this.Pane.FindForm().Text = value;
						return;
					}
					if (this.Pane.Parent != null)
					{
						this.Pane.Parent.Text = value;
					}
				}
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06003EED RID: 16109 RVA: 0x001CB18F File Offset: 0x001C938F
		// (set) Token: 0x06003EEE RID: 16110 RVA: 0x001CB197 File Offset: 0x001C9397
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TabAlignment TabAlignment
		{
			get
			{
				return this.o_0.o0.;
			}
			set
			{
				this.o_0.o0. = value;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06003EEF RID: 16111 RVA: 0x001CB1A0 File Offset: 0x001C93A0
		// (set) Token: 0x06003EF0 RID: 16112 RVA: 0x001CB1A8 File Offset: 0x001C93A8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ImageFile
		{
			get
			{
				return this.Oooo_.__OO00o.;
			}
			set
			{
				this.Oooo_.__OO00o. = value;
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06003EF1 RID: 16113 RVA: 0x001CB1B1 File Offset: 0x001C93B1
		// (set) Token: 0x06003EF2 RID: 16114 RVA: 0x001CB1BE File Offset: 0x001C93BE
		public Color BackColor
		{
			get
			{
				return this.Pane.BackColor;
			}
			set
			{
				this.Pane.BackColor = value;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06003EF3 RID: 16115 RVA: 0x001CB1CC File Offset: 0x001C93CC
		// (set) Token: 0x06003EF4 RID: 16116 RVA: 0x001CB1CF File Offset: 0x001C93CF
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string BackGroundImageFile
		{
			get
			{
				return null;
			}
			set
			{
				this.Pane.BackgroundImage = OO_00oOO.GetImage(value);
			}
		}

		/// <summary>
		/// 背景图片
		/// </summary>
		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06003EF5 RID: 16117 RVA: 0x001CB1E2 File Offset: 0x001C93E2
		// (set) Token: 0x06003EF6 RID: 16118 RVA: 0x001CB1EF File Offset: 0x001C93EF
		public Image Image
		{
			get
			{
				return this.Pane.BackgroundImage;
			}
			set
			{
				this.Pane.BackgroundImage = value;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06003EF7 RID: 16119 RVA: 0x001CB1FD File Offset: 0x001C93FD
		// (set) Token: 0x06003EF8 RID: 16120 RVA: 0x001CB20A File Offset: 0x001C940A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ImageLayout BackgroundImageLayout
		{
			get
			{
				return this.Pane.BackgroundImageLayout;
			}
			set
			{
				this.Pane.BackgroundImageLayout = value;
			}
		}

		/// <summary>
		/// 背景图片的排列方式
		/// </summary>
		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06003EF9 RID: 16121 RVA: 0x001CB218 File Offset: 0x001C9418
		// (set) Token: 0x06003EFA RID: 16122 RVA: 0x001CB225 File Offset: 0x001C9425
		public ImageLayout ImageLayout
		{
			get
			{
				return this.Pane.BackgroundImageLayout;
			}
			set
			{
				this.Pane.BackgroundImageLayout = value;
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06003EFB RID: 16123 RVA: 0x001CB233 File Offset: 0x001C9433
		// (set) Token: 0x06003EFC RID: 16124 RVA: 0x001CB23B File Offset: 0x001C943B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public FormStartPosition StartPosition
		{
			get
			{
				return this.o_0.o0.;
			}
			set
			{
				this.o_0.o0. = value;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06003EFD RID: 16125 RVA: 0x001CB244 File Offset: 0x001C9444
		// (set) Token: 0x06003EFE RID: 16126 RVA: 0x001CB24C File Offset: 0x001C944C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool TopMost
		{
			get
			{
				return this.OOo__.oo.;
			}
			set
			{
				this.OOo__.oo. = value;
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06003EFF RID: 16127 RVA: 0x001CB255 File Offset: 0x001C9455
		// (set) Token: 0x06003F00 RID: 16128 RVA: 0x001CB25D File Offset: 0x001C945D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Left
		{
			get
			{
				return this.ooOO0__._0O.;
			}
			set
			{
				this.ooOO0__._0O. = value;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06003F01 RID: 16129 RVA: 0x001CB266 File Offset: 0x001C9466
		// (set) Token: 0x06003F02 RID: 16130 RVA: 0x001CB26E File Offset: 0x001C946E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Top
		{
			get
			{
				return this.O__O_Oo__o.0.;
			}
			set
			{
				this.O__O_Oo__o.0. = value;
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06003F03 RID: 16131 RVA: 0x001CB277 File Offset: 0x001C9477
		// (set) Token: 0x06003F04 RID: 16132 RVA: 0x001CB284 File Offset: 0x001C9484
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Width
		{
			get
			{
				return this.Pane.Width;
			}
			set
			{
				this.Pane.Width = value;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06003F05 RID: 16133 RVA: 0x001CB292 File Offset: 0x001C9492
		// (set) Token: 0x06003F06 RID: 16134 RVA: 0x001CB29F File Offset: 0x001C949F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Height
		{
			get
			{
				return this.Pane.Height;
			}
			set
			{
				this.Pane.Height = value;
			}
		}

		/// <summary>
		/// 用于设置窗口的位置和大小，仅对独立窗口和模式窗口有效
		/// </summary>
		/// <param name="x">水平位置</param>
		/// <param name="y">垂直位置</param>
		/// <param name="Width">宽度</param>
		/// <param name="Height">高度</param>
		// Token: 0x06003F07 RID: 16135 RVA: 0x001CB2AD File Offset: 0x001C94AD
		[oO0oooo("2312")]
		public void SetBounds(int x, int y, int Width, int Height)
		{
			if (this.Pane.FindForm() != Main.OO_O.o.)
			{
				Form form = this.Pane.FindForm();
				form.ClientSize = new Size(Width, Height);
				form.Location = new Point(x, y);
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06003F08 RID: 16136 RVA: 0x001CB2E8 File Offset: 0x001C94E8
		// (set) Token: 0x06003F09 RID: 16137 RVA: 0x001CB2F0 File Offset: 0x001C94F0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DockAreaEnum DockArea
		{
			get
			{
				return this.ooOO0__._0O.;
			}
			set
			{
				this.ooOO0__._0O. = value;
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06003F0A RID: 16138 RVA: 0x001CB2F9 File Offset: 0x001C94F9
		// (set) Token: 0x06003F0B RID: 16139 RVA: 0x001CB301 File Offset: 0x001C9501
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AllowResize
		{
			get
			{
				return this.o._oOO_o.;
			}
			set
			{
				this.o._oOO_o. = value;
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x001CB30A File Offset: 0x001C950A
		// (set) Token: 0x06003F0D RID: 16141 RVA: 0x001CB312 File Offset: 0x001C9512
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AutoLayout
		{
			get
			{
				return this.O.O0Oo_.;
			}
			set
			{
				this.O.O0Oo_. = value;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x001CB31B File Offset: 0x001C951B
		// (set) Token: 0x06003F0F RID: 16143 RVA: 0x001CB323 File Offset: 0x001C9523
		public bool AutoResizeFonts
		{
			get
			{
				return this.O0__OO_0.o_oo.;
			}
			set
			{
				this.O0__OO_0.o_oo. = value;
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x001CB32C File Offset: 0x001C952C
		// (set) Token: 0x06003F11 RID: 16145 RVA: 0x001CB334 File Offset: 0x001C9534
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShowDockCaption
		{
			get
			{
				return this.O._o_oO.;
			}
			set
			{
				this.O._o_oO. = value;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06003F12 RID: 16146 RVA: 0x001CB33D File Offset: 0x001C953D
		// (set) Token: 0x06003F13 RID: 16147 RVA: 0x001CB345 File Offset: 0x001C9545
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShowCloseButton
		{
			get
			{
				return this.Oo._0O0OoOO_o0.;
			}
			set
			{
				this.Oo._0O0OoOO_o0. = value;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x001CB34E File Offset: 0x001C954E
		// (set) Token: 0x06003F15 RID: 16149 RVA: 0x001CB356 File Offset: 0x001C9556
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AutoHide
		{
			get
			{
				return this.o0.Ooo_oo0.;
			}
			set
			{
				this.o0.Ooo_oo0. = value;
			}
		}

		/// <summary>
		/// 是否启用计时器
		/// </summary>
		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06003F16 RID: 16150 RVA: 0x001CB360 File Offset: 0x001C9560
		// (set) Token: 0x06003F17 RID: 16151 RVA: 0x001CB388 File Offset: 0x001C9588
		public bool TimerEnabled
		{
			get
			{
				return this.Timer != null && this.Timer.Enabled;
			}
			set
			{
				if (value && this.Timer == null)
				{
					this.Timer = new Timer();
					if (this.TimerInterval > 0)
					{
						this.Timer.Interval = this.TimerInterval;
					}
					else
					{
						this.Timer.Interval = 1000;
					}
				}
				if (this.Timer != null)
				{
					this.Timer.Enabled = value;
				}
			}
		}

		/// <summary>
		/// 设定计时器的执行间隔，单位为毫秒
		/// </summary>
		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06003F18 RID: 16152 RVA: 0x001CB3EB File Offset: 0x001C95EB
		// (set) Token: 0x06003F19 RID: 16153 RVA: 0x001CB3F3 File Offset: 0x001C95F3
		public int TimerInterval
		{
			get
			{
				return this.O0000OO.o.;
			}
			set
			{
				if (this.Timer != null)
				{
					this.Timer.Interval = value;
				}
				this.O0000OO.o. = value;
			}
		}

		/// <summary>
		/// 当窗口中的控件位置或大小超出窗口范围时，是否自动出现滚动条
		/// </summary>
		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06003F1A RID: 16154 RVA: 0x001CB410 File Offset: 0x001C9610
		// (set) Token: 0x06003F1B RID: 16155 RVA: 0x001CB41D File Offset: 0x001C961D
		public bool AutoScroll
		{
			get
			{
				return this.Pane.AutoScroll;
			}
			set
			{
				this.Pane.AutoScroll = value;
			}
		}

		/// <summary>
		/// 设置扩展尺寸
		/// </summary>
		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06003F1C RID: 16156 RVA: 0x001CB42B File Offset: 0x001C962B
		// (set) Token: 0x06003F1D RID: 16157 RVA: 0x001CB438 File Offset: 0x001C9638
		[oO0oooo("1853")]
		public Size ExtendSize
		{
			get
			{
				return this.Pane.AutoScrollMinSize;
			}
			set
			{
				this.Pane.AutoScrollMinSize = value;
			}
		}

		/// <summary>
		/// 停止绘制窗口
		/// </summary>
		// Token: 0x06003F1E RID: 16158 RVA: 0x001CB446 File Offset: 0x001C9646
		[oO0oooo("1574")]
		public void StopRedraw()
		{
			ShareLibriay.LockWindowUpdate(this.Pane.Handle);
		}

		/// <summary>
		/// 恢复绘制窗口
		/// </summary>
		// Token: 0x06003F1F RID: 16159 RVA: 0x001CB459 File Offset: 0x001C9659
		[oO0oooo("1574")]
		public void ResumeRedraw()
		{
			ShareLibriay.LockWindowUpdate(IntPtr.Zero);
		}

		/// <summary>
		/// 刷新窗口
		/// </summary>
		// Token: 0x06003F20 RID: 16160 RVA: 0x001CB466 File Offset: 0x001C9666
		public void Refresh()
		{
			this.Pane.Refresh();
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06003F21 RID: 16161 RVA: 0x001CB473 File Offset: 0x001C9673
		// (set) Token: 0x06003F22 RID: 16162 RVA: 0x001CB484 File Offset: 0x001C9684
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string PageSetting
		{
			get
			{
				return o_O_o_oOoo__.OOOO_OO._oo.(this.oO0.O_OO_OO_., false, '\t', false);
			}
			set
			{
				this.Oo0oo000_._OO. = value;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06003F23 RID: 16163 RVA: 0x001CB48D File Offset: 0x001C968D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public PrintPageProperty Page
		{
			get
			{
				if (Operators.CompareString(this.Oo0oo000_._OO., "", true) > 0)
				{
					o_O_o_oOoo__.OOOO_OO._oo.(this.oO0.O_OO_OO_., this.Oo0oo000_._OO., '\t');
					this.Oo0oo000_._OO. = "";
				}
				return this.oO0.O_OO_OO_.;
			}
		}

		/// <summary>
		/// 生成窗口打印文档
		/// </summary>
		// Token: 0x06003F24 RID: 16164 RVA: 0x001CB4C7 File Offset: 0x001C96C7
		[oO0oooo("1590")]
		public PrintDoc GernatePrintDoc()
		{
			return this.GernatePrintDoc(this.Pane);
		}

		/// <summary>
		/// 针对某个控件生成打印文档
		/// </summary>
		/// <param name="Control"></param>
		// Token: 0x06003F25 RID: 16165 RVA: 0x001CB4D8 File Offset: 0x001C96D8
		[oO0oooo("2437")]
		public PrintDoc GernatePrintDoc(object Control)
		{
			PrintDoc result;
			if (Control is GroupBox)
			{
				result = this.GernatePrintDoc(((GroupBox)Control).BaseControl);
			}
			else if (Control is Panel)
			{
				result = this.GernatePrintDoc(((Panel)Control).BaseControl);
			}
			else if (Control is TabPage)
			{
				result = this.GernatePrintDoc((TabPage)Control);
			}
			else if (Control is SplitPanel)
			{
				result = this.GernatePrintDoc(((SplitPanel)Control).BaseControl);
			}
			else if (Control is NavPage)
			{
				result = this.GernatePrintDoc((NavPage)Control);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06003F26 RID: 16166 RVA: 0x001CB56A File Offset: 0x001C976A
		// (set) Token: 0x06003F27 RID: 16167 RVA: 0x001CB572 File Offset: 0x001C9772
		public bool PrintAutoMoveByLine { get; set; }

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06003F28 RID: 16168 RVA: 0x001CB57B File Offset: 0x001C977B
		// (set) Token: 0x06003F29 RID: 16169 RVA: 0x001CB583 File Offset: 0x001C9783
		public bool PrintAutoMoveByTable { get; set; }

		// Token: 0x06003F2A RID: 16170 RVA: 0x001CB58C File Offset: 0x001C978C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public PrintDoc GernatePrintDoc(Control Container)
		{
			int num;
			PrintDoc result;
			int num19;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				PrintDoc printDoc = new PrintDoc();
				IL_10:
				num2 = 3;
				DataTable dataTable = new DataTable();
				IL_19:
				num2 = 4;
				this.Oo0oo000_._OO. = 0;
				IL_22:
				num2 = 5;
				printDoc.ResolvedUnit = UnitTypeEnum.Mm;
				IL_2C:
				num2 = 6;
				dataTable.Columns.Add("Name", typeof(string));
				IL_4A:
				num2 = 7;
				dataTable.Columns.Add("Control", typeof(Control));
				IL_68:
				num2 = 8;
				dataTable.Columns.Add("Left", typeof(double));
				IL_86:
				num2 = 9;
				dataTable.Columns.Add("Top", typeof(double));
				IL_A5:
				num2 = 10;
				dataTable.Columns.Add("Width", typeof(double));
				IL_C4:
				num2 = 11;
				dataTable.Columns.Add("Height", typeof(double));
				IL_E3:
				num2 = 12;
				dataTable.Columns.Add("Right", typeof(double));
				IL_102:
				num2 = 13;
				dataTable.Columns.Add("Bottom", typeof(double));
				IL_121:
				num2 = 14;
				dataTable.Columns.Add("MinRows", typeof(int));
				IL_140:
				num2 = 15;
				dataTable.Columns.Add("MaxRows", typeof(int));
				IL_15F:
				num2 = 16;
				dataTable.Columns.Add("NewPage", typeof(bool));
				IL_17E:
				num2 = 17;
				dataTable.Columns.Add("PrintRowNumber", typeof(int));
				IL_19D:
				num2 = 18;
				dataTable.Columns.Add("PrintBorder", typeof(bool));
				IL_1BC:
				num2 = 19;
				dataTable.Columns.Add("Index", typeof(double));
				IL_1DB:
				num2 = 20;
				printDoc.PrinterName = this.Page.PrinterName;
				IL_1F0:
				num2 = 21;
				C1PageSettings c1PageSettings = printDoc.PageSetting;
				IL_1FC:
				num2 = 22;
				c1PageSettings.PaperKind = this.Page.PaperKind;
				IL_211:
				num2 = 23;
				if (!this.Page.Landscape)
				{
					goto IL_22C;
				}
				IL_221:
				num2 = 24;
				c1PageSettings.Landscape = true;
				IL_22C:
				num2 = 25;
				if (this.Page.Width <= 0.0 || this.Page.Height <= 0.0)
				{
					goto IL_28F;
				}
				IL_25B:
				num2 = 26;
				c1PageSettings.Width = this.Page.Width;
				IL_275:
				num2 = 27;
				c1PageSettings.Height = this.Page.Height;
				IL_28F:
				num2 = 28;
				c1PageSettings.LeftMargin = this.Page.LeftMargin;
				IL_2A9:
				num2 = 29;
				c1PageSettings.RightMargin = this.Page.RightMargin;
				IL_2C3:
				num2 = 30;
				c1PageSettings.TopMargin = this.Page.TopMargin;
				IL_2DD:
				num2 = 31;
				c1PageSettings.BottomMargin = this.Page.BottomMargin;
				IL_2F7:
				c1PageSettings = null;
				IL_2FA:
				num2 = 33;
				IEnumerator enumerator = Container.Controls.GetEnumerator();
				int num4;
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Control control = (Control)obj;
					IL_31D:
					num2 = 34;
					if (this.PrintSettings.CanExtend(control))
					{
						IL_332:
						num2 = 35;
						if (this.PrintSettings.GetPrintable(control))
						{
							IL_347:
							num2 = 37;
							DataRow dataRow = dataTable.NewRow();
							IL_353:
							num2 = 38;
							Control control2 = ooO_0O.o_O0.O_.(control);
							IL_35F:
							num2 = 39;
							control2.o.__O0O. = this;
							IL_36A:
							num2 = 40;
							dataRow["Name"] = control2.Name;
							IL_380:
							num2 = 41;
							dataRow["Control"] = control2;
							IL_391:
							num2 = 42;
							dataRow["Left"] = (double)((float)control.Left / SysInfo.ScreenDpiX) * 25.4 + this.Page.LeftMargin;
							IL_3CA:
							num2 = 43;
							dataRow["Top"] = (double)((float)control.Top / SysInfo.ScreenDpiY) * 25.4 + this.Page.TopMargin;
							IL_403:
							num2 = 44;
							dataRow["Width"] = (double)((float)control.Width / SysInfo.ScreenDpiX) * 25.4;
							IL_430:
							num2 = 45;
							dataRow["Height"] = (double)((float)control.Height / SysInfo.ScreenDpiY) * 25.4;
							IL_45D:
							num2 = 46;
							dataRow["Right"] = (double)((float)(control.Left + control.Width) / SysInfo.ScreenDpiX) * 25.4 + this.Page.LeftMargin;
							IL_49E:
							num2 = 47;
							dataRow["Bottom"] = (double)((float)(control.Top + control.Height) / SysInfo.ScreenDpiY) * 25.4 + this.Page.TopMargin;
							IL_4DF:
							num2 = 48;
							dataRow["MinRows"] = this.PrintSettings.GetMinRows(control);
							IL_500:
							num2 = 49;
							dataRow["NewPage"] = this.PrintSettings.GetNewPage(control);
							IL_521:
							num2 = 50;
							dataRow["PrintBorder"] = this.PrintSettings.O0O.o____o00.(control);
							IL_542:
							num2 = 51;
							if (control2.o.__O0O. == ControlTypeEnum.Table)
							{
								IL_553:
								num2 = 52;
								int num3 = ((C1FlexGrid)control).Rows.Count - ((C1FlexGrid)control).Rows.Fixed;
								IL_57B:
								num2 = 53;
								int maxRows = this.PrintSettings.GetMaxRows(control);
								IL_58D:
								num2 = 54;
								dataRow["MaxRows"] = maxRows;
								IL_5A3:
								num2 = 55;
								if (maxRows > 0)
								{
									IL_5AB:
									num2 = 56;
									num4 = (int)Math.Round(Math.Max((double)num4, Math.Ceiling((double)num3 / (double)maxRows)));
								}
							}
							IL_5CA:
							num2 = 57;
							dataRow["PrintRowNumber"] = this.PrintSettings.GetPrintRowNumber(control);
							IL_5EB:
							num2 = 58;
							dataTable.Rows.Add(dataRow);
						}
					}
					IL_5FC:
					num2 = 59;
				}
				IL_60B:
				num2 = 60;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_623:
				num2 = 61;
				DataRow[] array = dataTable.Select("", "Top,Left", DataViewRowState.CurrentRows);
				IL_63B:
				num2 = 62;
				int num5 = array.Length - 1;
				for (int i = 0; i <= num5; i++)
				{
					IL_64B:
					num2 = 63;
					array[i]["Index"] = i;
					IL_664:
					num2 = 64;
				}
				IL_673:
				num2 = 65;
				array = dataTable.Select("", "index", DataViewRowState.CurrentRows);
				IL_68B:
				num2 = 66;
				int num6 = array.Length - 1;
				for (int j = 0; j <= num6; j++)
				{
					IL_69E:
					num2 = 67;
					if ((array[j]["Control"] is Table && this.PrintAutoMoveByTable) || (array[j]["Control"] is Line && this.PrintAutoMoveByLine))
					{
						IL_6E3:
						num2 = 68;
						bool flag = Conversions.ToBoolean(array[j]["NewPage"]);
						IL_6FC:
						num2 = 69;
						DataRow[] array2 = dataTable.Select(string.Concat(new string[]
						{
							"[Top] >= ",
							array[j]["Top"].ToString(),
							" And [Top] <= ",
							array[j]["Bottom"].ToString(),
							" And [Name] <> '",
							array[j]["Name"].ToString(),
							"'"
						}), "Index");
						IL_77D:
						num2 = 70;
						if (array2.Length > 0)
						{
							IL_78A:
							num2 = 71;
							array[j]["NewPage"] = false;
							IL_7A2:
							num2 = 72;
							int num7 = array2.Length - 1;
							int k = 0;
							while (k <= num7)
							{
								IL_7B5:
								num2 = 73;
								if (!(array2[k]["Control"] is Line))
								{
									goto IL_7FE;
								}
								IL_7CE:
								num2 = 74;
								if (Conversions.ToDouble(array2[k]["Bottom"]) <= Conversions.ToDouble(array[j]["Bottom"]))
								{
									IL_7FB:
									num2 = 77;
									goto IL_7FE;
								}
								IL_868:
								num2 = 82;
								k++;
								continue;
								IL_7FE:
								num2 = 78;
								array2[k]["Index"] = Conversions.ToDouble(array[j]["Index"]) - 1.0 + (double)(k + 1) * 1E-06;
								IL_843:
								num2 = 79;
								if (flag)
								{
									IL_84A:
									num2 = 80;
									flag = false;
									IL_850:
									num2 = 81;
									array2[k]["NewPage"] = true;
									goto IL_868;
								}
								goto IL_868;
							}
						}
					}
					IL_87A:
					num2 = 83;
				}
				IL_88C:
				num2 = 84;
				dataTable.AcceptChanges();
				IL_896:
				num2 = 85;
				if (num4 != 0)
				{
					goto IL_8A3;
				}
				IL_89D:
				num2 = 86;
				num4 = 1;
				IL_8A3:
				num2 = 87;
				int num8 = num4;
				for (int l = 1; l <= num8; l++)
				{
					IL_8B2:
					num2 = 88;
					array = dataTable.Select("", "index", DataViewRowState.CurrentRows);
					IL_8CA:
					num2 = 89;
					int num9 = array.Length - 1;
					for (int m = 0; m <= num9; m++)
					{
						IL_8DD:
						num2 = 90;
						if (Conversions.ToBoolean(array[m]["NewPage"]))
						{
							IL_8F9:
							num2 = 91;
							double num10 = Conversions.ToDouble(array[m]["Top"]) - printDoc.PageSetting.TopMargin.Value;
							IL_928:
							num2 = 92;
							int num11 = m;
							int num12 = array.Length - 1;
							for (int n = num11; n <= num12; n++)
							{
								IL_939:
								num2 = 93;
								array[n]["Top"] = Conversions.ToDouble(array[n]["Top"]) - num10;
								IL_967:
								num2 = 94;
								array[n]["Bottom"] = Conversions.ToDouble(array[n]["Bottom"]) - num10;
								IL_995:
								num2 = 95;
							}
						}
						IL_9A4:
						num2 = 96;
						object obj2;
						if (m == 0 || Conversions.ToBoolean(array[m]["NewPage"]))
						{
							IL_9C1:
							num2 = 97;
							obj2 = Conversions.ToDouble(array[m]["Top"]);
						}
						else
						{
							IL_9E4:
							num2 = 99;
							double num13 = Conversions.ToDouble(array[m]["Top"]);
							IL_9FD:
							num2 = 100;
							double num14 = Conversions.ToDouble(array[m - 1]["Top"]);
							IL_A18:
							num2 = 101;
							double num15 = Conversions.ToDouble(array[m - 1]["Bottom"]);
							IL_A33:
							num2 = 102;
							if (array[m]["Control"] is Line)
							{
								IL_A4C:
								num2 = 103;
								obj2 = "Prev.Bottom + " + Conversions.ToString(num13 - num15);
							}
							else
							{
								IL_A67:
								num2 = 105;
								if (num13 < num15)
								{
									IL_A70:
									num2 = 106;
									obj2 = "Prev.Top + " + Conversions.ToString(num13 - num14);
								}
								else
								{
									IL_A8B:
									num2 = 108;
									obj2 = "Prev.Bottom + " + Conversions.ToString(num13 - num15);
								}
							}
						}
						IL_AA4:
						num2 = 109;
						if (Conversions.ToBoolean(array[m]["NewPage"]))
						{
							IL_ABD:
							num2 = 110;
							int num16 = this.Oo0oo000_._OO. - 1;
							for (int num17 = 0; num17 <= num16; num17++)
							{
								IL_ACF:
								num2 = 111;
								RenderEmpty renderEmpty = new RenderEmpty();
								IL_AD9:
								num2 = 112;
								renderEmpty.BreakAfter = BreakEnum.Page;
								IL_AE4:
								num2 = 113;
								printDoc.Body.Children.Add(renderEmpty);
								IL_AFB:
								num2 = 114;
							}
							IL_B0A:
							num2 = 115;
							this.Oo0oo000_._OO. = 0;
						}
						IL_B14:
						num2 = 116;
						this.Oo0Oo0000.__.(printDoc, array[m], l, obj2.ToString(), Conversions.ToBoolean(array[m]["NewPage"]), Conversions.ToBoolean(array[m]["PrintBorder"]));
						IL_B55:
						num2 = 117;
					}
					IL_B67:
					num2 = 118;
					dataTable.RejectChanges();
					IL_B71:
					num2 = 119;
					if (l < num4)
					{
						IL_B7A:
						num2 = 120;
						RenderEmpty renderEmpty2 = new RenderEmpty();
						IL_B84:
						num2 = 121;
						renderEmpty2.BreakAfter = BreakEnum.Page;
						IL_B8F:
						num2 = 122;
						printDoc.Body.Children.Add(renderEmpty2);
					}
					IL_BA6:
					num2 = 123;
				}
				IL_BB8:
				num2 = 124;
				printDoc.AutoRotate = false;
				IL_BC3:
				num2 = 125;
				result = printDoc;
				IL_BC9:
				goto IL_E13;
				IL_BCE:
				int num18 = num19 + 1;
				num19 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num18);
				IL_DD4:
				goto IL_E08;
				IL_DD6:
				num19 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_DE6:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num19 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_DD6;
			}
			IL_E08:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_E13:
			if (num19 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x001CC3D4 File Offset: 0x001CA5D4
		private void <<EMPTY_NAME>>(C1PrintDocument A_0, DataRow A_1, int A_2, string A_3, bool A_4, bool A_5)
		{
			int num;
			int num31;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				Control control = (Control)A_1["Control"];
				IL_1A:
				num2 = 3;
				ControlTypeEnum o.__O0O. = control.o.__O0O.;
				if (o.__O0O. <= ControlTypeEnum.Gauges)
				{
					switch (o.__O0O.)
					{
					case ControlTypeEnum.Label:
					case ControlTypeEnum.TextBox:
					case ControlTypeEnum.ComboBox:
					case ControlTypeEnum.NumericComboBox:
					case ControlTypeEnum.DateTimePicker:
					case ControlTypeEnum.CheckedComboBox:
					case ControlTypeEnum.DropDownBox:
					case ControlTypeEnum.TimeSpanBox:
					{
						IL_E8:
						num2 = 5;
						RenderText renderText = new RenderText();
						IL_F1:
						num2 = 6;
						renderText.Text = control.BaseControl.Text;
						IL_105:
						num2 = 7;
						renderText.X = Conversions.ToDouble(A_1["Left"]);
						IL_123:
						num2 = 8;
						renderText.Y = A_3;
						IL_133:
						num2 = 9;
						renderText.Height = Conversions.ToDouble(A_1["Height"]);
						IL_152:
						num2 = 10;
						renderText.Width = Conversions.ToDouble(A_1["Width"]);
						IL_171:
						num2 = 11;
						renderText.Style.Font = control.BaseControl.Font;
						IL_18B:
						num2 = 12;
						renderText.Style.TextColor = control.BaseControl.ForeColor;
						IL_1A5:
						num2 = 13;
						if (!A_4)
						{
							goto IL_1D7;
						}
						IL_1AC:
						num2 = 14;
						RenderEmpty renderEmpty = new RenderEmpty();
						IL_1B6:
						num2 = 15;
						renderEmpty.BreakAfter = BreakEnum.Page;
						IL_1C1:
						num2 = 16;
						A_0.Body.Children.Add(renderEmpty);
						IL_1D7:
						num2 = 17;
						ControlTypeEnum o.__O0O.2 = control.o.__O0O.;
						switch (o.__O0O.2)
						{
						case ControlTypeEnum.Label:
						{
							IL_224:
							num2 = 19;
							C1Label c1Label = (C1Label)control.BaseControl;
							IL_234:
							num2 = 20;
							ContentAlignment textAlign = c1Label.TextAlign;
							if (textAlign <= ContentAlignment.MiddleCenter)
							{
								switch (textAlign)
								{
								case ContentAlignment.TopLeft:
									goto IL_2AD;
								case ContentAlignment.TopCenter:
									break;
								case (ContentAlignment)3:
									goto IL_2CF;
								case ContentAlignment.TopRight:
									goto IL_2BF;
								default:
									if (textAlign == ContentAlignment.MiddleLeft)
									{
										goto IL_2AD;
									}
									if (textAlign != ContentAlignment.MiddleCenter)
									{
										goto IL_2CF;
									}
									break;
								}
							}
							else if (textAlign <= ContentAlignment.BottomLeft)
							{
								if (textAlign == ContentAlignment.MiddleRight)
								{
									goto IL_2BF;
								}
								if (textAlign != ContentAlignment.BottomLeft)
								{
									goto IL_2CF;
								}
								goto IL_2AD;
							}
							else if (textAlign != ContentAlignment.BottomCenter)
							{
								if (textAlign != ContentAlignment.BottomRight)
								{
									goto IL_2CF;
								}
								goto IL_2BF;
							}
							IL_29B:
							num2 = 22;
							renderText.Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center;
							goto IL_2CF;
							IL_2AD:
							num2 = 24;
							renderText.Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left;
							goto IL_2CF;
							IL_2BF:
							num2 = 26;
							renderText.Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right;
							IL_2CF:
							num2 = 28;
							ContentAlignment textAlign2 = c1Label.TextAlign;
							if (textAlign2 > ContentAlignment.MiddleCenter)
							{
								if (textAlign2 <= ContentAlignment.BottomLeft)
								{
									if (textAlign2 == ContentAlignment.MiddleRight)
									{
										goto IL_340;
									}
									if (textAlign2 != ContentAlignment.BottomLeft)
									{
										goto IL_362;
									}
								}
								else if (textAlign2 != ContentAlignment.BottomCenter && textAlign2 != ContentAlignment.BottomRight)
								{
									goto IL_362;
								}
								IL_32E:
								num2 = 30;
								renderText.Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Bottom;
								goto IL_362;
							}
							if (textAlign2 <= ContentAlignment.TopRight)
							{
								if (textAlign2 - ContentAlignment.TopLeft > 1 && textAlign2 != ContentAlignment.TopRight)
								{
									goto IL_362;
								}
								IL_352:
								num2 = 34;
								renderText.Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Top;
								goto IL_362;
							}
							if (textAlign2 != ContentAlignment.MiddleLeft && textAlign2 != ContentAlignment.MiddleCenter)
							{
								goto IL_362;
							}
							IL_340:
							num2 = 32;
							renderText.Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Center;
							IL_362:
							num2 = 36;
							if (!A_5)
							{
								goto IL_397;
							}
							IL_369:
							num2 = 37;
							renderText.Style.Borders.All = new LineDef(0.1, c1Label.BorderColor);
							IL_397:
							c1Label = null;
							goto IL_4E9;
						}
						case ControlTypeEnum.TextBox:
						case ControlTypeEnum.ComboBox:
						case ControlTypeEnum.NumericComboBox:
						case ControlTypeEnum.DateTimePicker:
							break;
						case ControlTypeEnum.Button:
						case ControlTypeEnum.CheckBox:
						case ControlTypeEnum.RadioButton:
						case ControlTypeEnum.TopicBar:
							goto IL_4E9;
						default:
							if (o.__O0O.2 != ControlTypeEnum.DropDownBox && o.__O0O.2 != ControlTypeEnum.TimeSpanBox)
							{
								goto IL_4E9;
							}
							break;
						}
						IL_39F:
						num2 = 40;
						renderText.Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Center;
						IL_3AF:
						num2 = 41;
						C1TextBox c1TextBox = (C1TextBox)control.BaseControl;
						IL_3BF:
						num2 = 42;
						if (!c1TextBox.Multiline)
						{
							goto IL_3DD;
						}
						IL_3CB:
						num2 = 43;
						renderText.Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Top;
						goto IL_3ED;
						IL_3DD:
						num2 = 45;
						renderText.Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Center;
						IL_3ED:
						num2 = 46;
						switch (c1TextBox.TextAlign)
						{
						case HorizontalAlignment.Left:
							IL_420:
							num2 = 50;
							renderText.Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left;
							break;
						case HorizontalAlignment.Right:
							IL_432:
							num2 = 52;
							renderText.Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right;
							break;
						case HorizontalAlignment.Center:
							IL_40E:
							num2 = 48;
							renderText.Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center;
							break;
						}
						IL_442:
						num2 = 54;
						switch (c1TextBox.VerticalAlign)
						{
						case VerticalAlignEnum.Top:
							IL_463:
							num2 = 56;
							renderText.Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Top;
							break;
						case VerticalAlignEnum.Middle:
							IL_475:
							num2 = 58;
							renderText.Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Center;
							break;
						case VerticalAlignEnum.Bottom:
							IL_487:
							num2 = 60;
							renderText.Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Bottom;
							break;
						}
						IL_497:
						num2 = 62;
						if (!A_5)
						{
							goto IL_4E6;
						}
						IL_49E:
						num2 = 63;
						renderText.Style.Padding.Left = 1;
						IL_4B8:
						num2 = 64;
						renderText.Style.Borders.All = new LineDef(0.1, c1TextBox.BorderColor);
						IL_4E6:
						c1TextBox = null;
						IL_4E9:
						num2 = 67;
						A_0.Body.Children.Add(renderText);
						goto IL_215B;
					}
					case ControlTypeEnum.Button:
					case ControlTypeEnum.TopicBar:
					case ControlTypeEnum.ListBox:
					case ControlTypeEnum.CheckedListBox:
					case ControlTypeEnum.GroupBox:
					case ControlTypeEnum.Panel:
					case ControlTypeEnum.SplitContainer:
					case ControlTypeEnum.TabControl:
					case ControlTypeEnum.TreeView:
					case ControlTypeEnum.ProgressBar:
					case ControlTypeEnum.FileManager:
					case ControlTypeEnum.NavBar:
					case ControlTypeEnum.DataList:
					case ControlTypeEnum.WebBrowser:
					case ControlTypeEnum.QRCode1:
					case ControlTypeEnum.Calendar:
					case ControlTypeEnum.TrackBar:
						goto IL_215B;
					case ControlTypeEnum.CheckBox:
					{
						IL_BC2:
						num2 = 172;
						RenderInputCheckBox renderInputCheckBox = new RenderInputCheckBox();
						IL_BCF:
						num2 = 173;
						CheckBox checkBox = (CheckBox)control.BaseControl;
						IL_BE2:
						num2 = 174;
						renderInputCheckBox.X = Conversions.ToDouble(A_1["Left"]);
						IL_C04:
						num2 = 175;
						renderInputCheckBox.Y = A_3;
						IL_C18:
						num2 = 176;
						renderInputCheckBox.Width = Conversions.ToDouble(A_1["Width"]);
						IL_C3A:
						num2 = 177;
						renderInputCheckBox.Height = Conversions.ToDouble(A_1["Height"]);
						IL_C5C:
						num2 = 178;
						renderInputCheckBox.Text = checkBox.Text;
						IL_C70:
						num2 = 179;
						renderInputCheckBox.Checked = checkBox.Checked;
						IL_C84:
						num2 = 180;
						renderInputCheckBox.CheckAlign = checkBox.CheckAlign;
						IL_C98:
						num2 = 181;
						renderInputCheckBox.ReadOnly = true;
						IL_CA6:
						num2 = 182;
						renderInputCheckBox.Style.Font = checkBox.Font;
						IL_CBF:
						num2 = 183;
						if (!A_4)
						{
							goto IL_CFD;
						}
						IL_CC9:
						num2 = 184;
						RenderEmpty renderEmpty2 = new RenderEmpty();
						IL_CD6:
						num2 = 185;
						renderEmpty2.BreakAfter = BreakEnum.Page;
						IL_CE4:
						num2 = 186;
						A_0.Body.Children.Add(renderEmpty2);
						IL_CFD:
						num2 = 187;
						A_0.Body.Children.Add(renderInputCheckBox);
						goto IL_215B;
					}
					case ControlTypeEnum.RadioButton:
					{
						IL_D1B:
						num2 = 189;
						RenderInputRadioButton renderInputRadioButton = new RenderInputRadioButton();
						IL_D28:
						num2 = 190;
						RadioButton radioButton = (RadioButton)control.BaseControl;
						IL_D3B:
						num2 = 191;
						renderInputRadioButton.X = Conversions.ToDouble(A_1["Left"]);
						IL_D5D:
						num2 = 192;
						renderInputRadioButton.Y = A_3;
						IL_D71:
						num2 = 193;
						renderInputRadioButton.Width = Conversions.ToDouble(A_1["Width"]);
						IL_D93:
						num2 = 194;
						renderInputRadioButton.Height = Conversions.ToDouble(A_1["Height"]);
						IL_DB5:
						num2 = 195;
						renderInputRadioButton.Text = radioButton.Text;
						IL_DC9:
						num2 = 196;
						renderInputRadioButton.Checked = radioButton.Checked;
						IL_DDD:
						num2 = 197;
						renderInputRadioButton.CheckAlign = radioButton.CheckAlign;
						IL_DF1:
						num2 = 198;
						renderInputRadioButton.ReadOnly = true;
						IL_DFF:
						num2 = 199;
						renderInputRadioButton.Style.Font = radioButton.Font;
						IL_E18:
						num2 = 200;
						if (!A_4)
						{
							goto IL_E56;
						}
						IL_E22:
						num2 = 201;
						RenderEmpty renderEmpty3 = new RenderEmpty();
						IL_E2F:
						num2 = 202;
						renderEmpty3.BreakAfter = BreakEnum.Page;
						IL_E3D:
						num2 = 203;
						A_0.Body.Children.Add(renderEmpty3);
						IL_E56:
						num2 = 204;
						A_0.Body.Children.Add(renderInputRadioButton);
						goto IL_215B;
					}
					case ControlTypeEnum.PictureBox:
					case ControlTypeEnum.Chart:
					case ControlTypeEnum.PictureViewer:
					case ControlTypeEnum.Painter:
						break;
					case ControlTypeEnum.ColorLabel:
					{
						IL_504:
						num2 = 69;
						RenderText renderText2 = new RenderText();
						IL_50E:
						num2 = 70;
						renderText2.Text = control.BaseControl.Text;
						IL_523:
						num2 = 71;
						renderText2.X = Conversions.ToDouble(A_1["Left"]);
						IL_542:
						num2 = 72;
						renderText2.Y = A_3;
						IL_553:
						num2 = 73;
						renderText2.Height = Conversions.ToDouble(A_1["Height"]);
						IL_572:
						num2 = 74;
						renderText2.Width = Conversions.ToDouble(A_1["Width"]);
						IL_591:
						num2 = 75;
						renderText2.Style.BackColor = control.BackColor;
						IL_5A6:
						num2 = 76;
						if (!A_4)
						{
							goto IL_5D8;
						}
						IL_5AD:
						num2 = 77;
						RenderEmpty renderEmpty4 = new RenderEmpty();
						IL_5B7:
						num2 = 78;
						renderEmpty4.BreakAfter = BreakEnum.Page;
						IL_5C2:
						num2 = 79;
						A_0.Body.Children.Add(renderEmpty4);
						IL_5D8:
						num2 = 80;
						A_0.Body.Children.Add(renderText2);
						goto IL_215B;
					}
					case ControlTypeEnum.Line:
					{
						IL_5F3:
						num2 = 82;
						LineControl lineControl = (LineControl)control.BaseControl;
						IL_603:
						num2 = 83;
						LineDef shapeLine = new LineDef((double)((float)lineControl.Thickness / SysInfo.ScreenDpiX) * 25.4, lineControl.ForeColor, (DashStyle)lineControl.DashStyle);
						IL_639:
						num2 = 84;
						double num3 = Conversions.ToDouble(A_1["Width"]);
						IL_64E:
						num2 = 85;
						double num4 = Conversions.ToDouble(A_1["Height"]);
						IL_663:
						num2 = 86;
						double num5;
						double num6;
						double value;
						double value2;
						switch (lineControl.Direction)
						{
						case LineDirectionEnum.Horizontal:
							IL_68B:
							num2 = 88;
							num5 = 0.0;
							IL_699:
							num2 = 89;
							num6 = num4 / 2.0;
							IL_6AA:
							num2 = 90;
							value = num3;
							IL_6B1:
							num2 = 91;
							value2 = num6;
							break;
						case LineDirectionEnum.Vertical:
							IL_6BD:
							num2 = 93;
							num5 = num3 / 2.0;
							IL_6CE:
							num2 = 94;
							num6 = 0.0;
							IL_6DC:
							num2 = 95;
							value = num5;
							IL_6E3:
							num2 = 96;
							value2 = num4;
							break;
						case LineDirectionEnum.DiagonalDescending:
							IL_6EC:
							num2 = 98;
							num5 = 0.0;
							IL_6FA:
							num2 = 99;
							num6 = 0.0;
							IL_708:
							num2 = 100;
							value = 0.0 + num3;
							IL_719:
							num2 = 101;
							value2 = num4;
							break;
						case LineDirectionEnum.DiagonalAscending:
							IL_722:
							num2 = 103;
							num5 = 0.0;
							IL_730:
							num2 = 104;
							num6 = num4;
							IL_737:
							num2 = 105;
							value = num3;
							IL_73E:
							num2 = 106;
							value2 = 0.0;
							break;
						}
						IL_74C:
						num2 = 108;
						RenderLine renderLine = new RenderLine(num5, num6, value, value2, shapeLine);
						IL_774:
						num2 = 109;
						renderLine.X = Conversions.ToDouble(A_1["Left"]);
						IL_793:
						num2 = 110;
						renderLine.Y = A_3;
						IL_7A4:
						num2 = 111;
						renderLine.Height = Conversions.ToDouble(A_1["Height"]);
						IL_7C3:
						num2 = 112;
						renderLine.Width = Conversions.ToDouble(A_1["Width"]);
						IL_7E2:
						num2 = 113;
						if (!A_4)
						{
							goto IL_814;
						}
						IL_7E9:
						num2 = 114;
						RenderEmpty renderEmpty5 = new RenderEmpty();
						IL_7F3:
						num2 = 115;
						renderEmpty5.BreakAfter = BreakEnum.Page;
						IL_7FE:
						num2 = 116;
						A_0.Body.Children.Add(renderEmpty5);
						IL_814:
						num2 = 117;
						A_0.Body.Children.Add(renderLine);
						goto IL_215B;
					}
					case ControlTypeEnum.BarCode:
					{
						IL_82F:
						num2 = 119;
						RenderGraphics renderGraphics = new RenderGraphics();
						IL_839:
						num2 = 120;
						renderGraphics.X = Conversions.ToDouble(A_1["Left"]);
						IL_858:
						num2 = 121;
						renderGraphics.Y = A_3;
						IL_869:
						num2 = 122;
						renderGraphics.Height = "Auto";
						IL_87D:
						num2 = 123;
						renderGraphics.Width = "Auto";
						IL_891:
						num2 = 124;
						BarCode barCode = (BarCode)control;
						IL_89C:
						num2 = 125;
						barCode.DrawOnCanvas(renderGraphics.Graphics, 0.1f, 0.1f);
						IL_8B7:
						barCode = null;
						IL_8BA:
						num2 = 127;
						if (!A_4)
						{
							goto IL_8F5;
						}
						IL_8C1:
						num2 = 128;
						RenderEmpty renderEmpty6 = new RenderEmpty();
						IL_8CE:
						num2 = 129;
						renderEmpty6.BreakAfter = BreakEnum.Page;
						IL_8DC:
						num2 = 130;
						A_0.Body.Children.Add(renderEmpty6);
						IL_8F5:
						num2 = 131;
						A_0.Body.Children.Add(renderGraphics);
						goto IL_215B;
					}
					case ControlTypeEnum.RecordGrid:
					{
						IL_E74:
						num2 = 206;
						C1FlexGrid c1FlexGrid = (C1FlexGrid)control.BaseControl;
						IL_E87:
						num2 = 207;
						RenderTable renderTable = new RenderTable();
						IL_E94:
						num2 = 208;
						renderTable.Cols.Count = 2;
						IL_EA7:
						num2 = 209;
						renderTable.Width = Conversions.ToString((double)((float)c1FlexGrid.Width / SysInfo.ScreenDpiX) * 25.4) + "mm";
						IL_EE1:
						num2 = 210;
						renderTable.CellStyle.Spacing.All = 0.7;
						IL_F06:
						num2 = 211;
						renderTable.Style.GridLines.All = new LineDef(Color.DarkGray);
						IL_F27:
						num2 = 212;
						renderTable.Style.Font = c1FlexGrid.Font;
						IL_F40:
						num2 = 213;
						renderTable.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded;
						IL_F4E:
						num2 = 214;
						renderTable.X = Conversions.ToDouble(A_1["Left"]);
						IL_F70:
						num2 = 215;
						renderTable.Y = A_3;
						IL_F84:
						num2 = 216;
						renderTable.Cols[0].Width = Conversions.ToString((double)((float)c1FlexGrid.Cols[0].WidthDisplay / SysInfo.ScreenDpiX) * 25.4) + "mm";
						IL_FD4:
						num2 = 217;
						renderTable.Cols[1].Width = Conversions.ToString((double)((float)(c1FlexGrid.Width - c1FlexGrid.Cols[0].WidthDisplay) / SysInfo.ScreenDpiX) * 25.4) + "mm";
						IL_102C:
						num2 = 218;
						renderTable.CellStyle.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left;
						IL_103F:
						num2 = 219;
						renderTable.CellStyle.TextAlignVert = C1.C1Preview.AlignVertEnum.Center;
						IL_1052:
						num2 = 220;
						int num7 = c1FlexGrid.Rows.Count - 1;
						for (int i = 0; i <= num7; i++)
						{
							IL_106D:
							num2 = 221;
							int num8;
							renderTable.Cells[num8, 0].Text = c1FlexGrid.GetDataDisplay(i, 0);
							IL_1091:
							num2 = 222;
							renderTable.Cells[num8, 1].Text = c1FlexGrid.GetDataDisplay(i, 1);
							IL_10B5:
							num2 = 223;
							num8++;
							IL_10C1:
							num2 = 224;
						}
						IL_10D3:
						num2 = 225;
						if (!A_4)
						{
							goto IL_1111;
						}
						IL_10DD:
						num2 = 226;
						RenderEmpty renderEmpty7 = new RenderEmpty();
						IL_10EA:
						num2 = 227;
						renderEmpty7.BreakAfter = BreakEnum.Page;
						IL_10F8:
						num2 = 228;
						A_0.Body.Children.Add(renderEmpty7);
						IL_1111:
						num2 = 229;
						A_0.Generate();
						IL_111E:
						num2 = 230;
						int count = A_0.Pages.Count;
						IL_1131:
						num2 = 231;
						A_0.Body.Children.Add(renderTable);
						IL_114A:
						num2 = 232;
						A_0.Generate();
						IL_1157:
						num2 = 233;
						int count2 = A_0.Pages.Count;
						IL_116A:
						num2 = 234;
						this.Oo0oo000_._OO. = this.Oo0oo000_._OO. + count2 - count;
						goto IL_215B;
					}
					default:
						if (o.__O0O. != ControlTypeEnum.Gauges)
						{
							goto IL_215B;
						}
						break;
					}
				}
				else if (o.__O0O. != ControlTypeEnum.Map)
				{
					if (o.__O0O. != ControlTypeEnum.Table)
					{
						goto IL_215B;
					}
					IL_1187:
					num2 = 236;
					C1FlexGrid c1FlexGrid2 = (C1FlexGrid)control.BaseControl;
					IL_119A:
					num2 = 237;
					RenderTable renderTable2 = new RenderTable();
					IL_11A7:
					num2 = 238;
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					IL_11B4:
					num2 = 239;
					renderTable2.Style.Spacing.All = "0";
					IL_11D5:
					num2 = 240;
					renderTable2.Style.GridLines.All = new LineDef(c1FlexGrid2.Styles.Normal.Border.Color);
					IL_1207:
					num2 = 241;
					renderTable2.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded;
					IL_1215:
					num2 = 242;
					renderTable2.CellStyle.Spacing.All = 0.7;
					IL_123A:
					num2 = 243;
					renderTable2.Width = "Auto";
					IL_1251:
					num2 = 244;
					renderTable2.Style.Font = c1FlexGrid2.Font;
					IL_126A:
					num2 = 245;
					if (!A_4)
					{
						goto IL_12A8;
					}
					IL_1274:
					num2 = 246;
					RenderEmpty renderEmpty8 = new RenderEmpty();
					IL_1281:
					num2 = 247;
					renderEmpty8.BreakAfter = BreakEnum.Page;
					IL_128F:
					num2 = 248;
					A_0.Body.Children.Add(renderEmpty8);
					IL_12A8:
					num2 = 249;
					renderTable2.X = Conversions.ToDouble(A_1["Left"]);
					IL_12CA:
					num2 = 250;
					renderTable2.Y = A_3;
					IL_12DE:
					num2 = 251;
					int num9 = c1FlexGrid2.Cols.Count - 1;
					int num10;
					for (int j = 1; j <= num9; j++)
					{
						IL_12FC:
						num2 = 252;
						if (c1FlexGrid2.Cols[j].Visible)
						{
							IL_131A:
							num2 = 253;
							num10++;
							IL_1326:
							num2 = 256;
							dictionary.Add(num10, j);
							IL_1337:
							num2 = 257;
							switch (c1FlexGrid2.Cols[j].StyleDisplay.TextAlign)
							{
							case TextAlignEnum.LeftTop:
							case TextAlignEnum.LeftCenter:
							case TextAlignEnum.LeftBottom:
								IL_13B7:
								num2 = 261;
								renderTable2.Cols[num10].Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left;
								break;
							case TextAlignEnum.CenterTop:
							case TextAlignEnum.CenterCenter:
							case TextAlignEnum.CenterBottom:
								IL_1393:
								num2 = 259;
								renderTable2.Cols[num10].Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center;
								break;
							case TextAlignEnum.RightTop:
							case TextAlignEnum.RightCenter:
							case TextAlignEnum.RightBottom:
								IL_13DB:
								num2 = 263;
								renderTable2.Cols[num10].Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right;
								break;
							case TextAlignEnum.GeneralTop:
							case TextAlignEnum.GeneralCenter:
							case TextAlignEnum.GeneralBottom:
								IL_13FF:
								num2 = 265;
								if (c1FlexGrid2.Cols[j].DataType == typeof(string) || c1FlexGrid2.Cols[j].DataType == typeof(DateTime))
								{
									IL_1443:
									num2 = 266;
									renderTable2.Cols[num10].Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left;
								}
								else
								{
									IL_1464:
									num2 = 268;
									renderTable2.Cols[num10].Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right;
								}
								break;
							}
							IL_1483:
							num2 = 270;
							renderTable2.Cols[num10].Width = (double)((float)c1FlexGrid2.Cols[j].WidthDisplay / SysInfo.ScreenDpiX) * 25.4;
							IL_14C6:
							num2 = 271;
							renderTable2.Cols[num10].Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Center;
							IL_14E5:
							num2 = 272;
							renderTable2.Cols[num10].Style.ImageAlign.AlignHorz = ImageAlignHorzEnum.Center;
							IL_1509:
							num2 = 273;
							renderTable2.Cols[num10].Style.ImageAlign.AlignVert = ImageAlignVertEnum.Center;
						}
						IL_152D:
						num2 = 274;
					}
					IL_1542:
					num2 = 275;
					renderTable2.Cols[0].Width = (double)((float)c1FlexGrid2.Cols[0].WidthDisplay / SysInfo.ScreenDpiX) * 25.4;
					IL_1583:
					num2 = 276;
					renderTable2.Cols[0].Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center;
					IL_15A1:
					num2 = 277;
					renderTable2.Cols[0].Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Center;
					IL_15BF:
					num2 = 278;
					int num11 = c1FlexGrid2.Rows.Fixed - 1;
					for (int k = 0; k <= num11; k++)
					{
						IL_15DD:
						num2 = 279;
						renderTable2.Rows[k].Height = (double)((float)c1FlexGrid2.Rows[k].HeightDisplay / SysInfo.ScreenDpiY) * 25.4;
						IL_1620:
						num2 = 280;
						int num12 = num10;
						for (int l = 1; l <= num12; l++)
						{
							IL_1632:
							num2 = 281;
							int num13 = dictionary[l];
							IL_1643:
							num2 = 282;
							CellRange mergedRange = c1FlexGrid2.GetMergedRange(k, num13, false);
							IL_1657:
							num2 = 283;
							int num14 = 0;
							for (;;)
							{
								IL_1678:
								num2 = 285;
								if (mergedRange.c1 >= mergedRange.c2 || c1FlexGrid2.Cols[mergedRange.c1].Visible)
								{
									break;
								}
								IL_1662:
								num2 = 286;
								mergedRange.c1++;
							}
							IL_16A8:
							num2 = 288;
							int c = mergedRange.c1;
							int c2 = mergedRange.c2;
							for (int m = c; m <= c2; m++)
							{
								IL_16C2:
								num2 = 289;
								if (!c1FlexGrid2.Cols[m].Visible)
								{
									IL_16DD:
									num2 = 290;
									num14++;
								}
								IL_16E9:
								num2 = 291;
							}
							IL_16FB:
							num2 = 292;
							mergedRange.c2 -= num14;
							IL_1712:
							num2 = 293;
							if (mergedRange.IsSingleCell)
							{
								IL_1721:
								num2 = 294;
								renderTable2.Cells[k, l].Text = c1FlexGrid2.GetDataDisplay(k, num13);
							}
							else
							{
								IL_174C:
								num2 = 296;
								if (!(num13 > mergedRange.c1 | k > mergedRange.r1))
								{
									IL_176B:
									num2 = 298;
									renderTable2.Cells[k, l].Text = c1FlexGrid2.GetDataDisplay(k, num13);
									IL_1791:
									num2 = 299;
									renderTable2.Cells[k, l].SpanCols = mergedRange.c2 - mergedRange.c1 + 1;
									IL_17BD:
									num2 = 300;
									renderTable2.Cells[k, l].SpanRows = mergedRange.r2 - mergedRange.r1 + 1;
								}
							}
							IL_17E9:
							num2 = 301;
							CellRange cellRange = c1FlexGrid2.GetCellRange(k, num13);
							IL_17FC:
							num2 = 302;
							switch (cellRange.StyleDisplay.TextAlign)
							{
							case TextAlignEnum.LeftTop:
							case TextAlignEnum.LeftCenter:
							case TextAlignEnum.LeftBottom:
								IL_186F:
								num2 = 306;
								renderTable2.Cells[k, l].Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left;
								break;
							case TextAlignEnum.CenterTop:
							case TextAlignEnum.CenterCenter:
							case TextAlignEnum.CenterBottom:
								IL_184C:
								num2 = 304;
								renderTable2.Cells[k, l].Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center;
								break;
							case TextAlignEnum.RightTop:
							case TextAlignEnum.RightCenter:
							case TextAlignEnum.RightBottom:
								IL_1892:
								num2 = 308;
								renderTable2.Cells[k, l].Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right;
								break;
							case TextAlignEnum.GeneralTop:
							case TextAlignEnum.GeneralCenter:
							case TextAlignEnum.GeneralBottom:
								IL_18B5:
								num2 = 310;
								renderTable2.Cells[k, l].Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center;
								break;
							}
							IL_18D6:
							num2 = 312;
							renderTable2.Cells[k, l].Style.TextColor = cellRange.StyleDisplay.ForeColor;
							IL_1902:
							num2 = 313;
							renderTable2.Cells[k, l].Style.BackColor = cellRange.StyleDisplay.BackColor;
							IL_192E:
							num2 = 314;
						}
						IL_1943:
						num2 = 315;
					}
					IL_1958:
					num2 = 316;
					renderTable2.RowGroups[0, c1FlexGrid2.Rows.Fixed].Header = TableHeaderEnum.All;
					IL_197D:
					num2 = 317;
					int num15 = c1FlexGrid2.Rows.Fixed;
					IL_1991:
					num2 = 318;
					int num16 = c1FlexGrid2.Rows.Count - 1;
					IL_19A7:
					num2 = 319;
					if (A_1.IsNull("MaxRows"))
					{
						goto IL_19D2;
					}
					IL_19BA:
					num2 = 320;
					int num17 = Conversions.ToInteger(A_1["MaxRows"]);
					IL_19D2:
					num2 = 321;
					if (num17 <= 0)
					{
						goto IL_1A26;
					}
					IL_19DD:
					num2 = 322;
					num15 = c1FlexGrid2.Rows.Fixed + (A_2 - 1) * num17;
					IL_19F8:
					num2 = 323;
					num16 = Math.Min(c1FlexGrid2.Rows.Fixed + A_2 * num17 - 1, c1FlexGrid2.Rows.Count - 1);
					IL_1A26:
					num2 = 324;
					int num18 = num15;
					int num19 = num16;
					for (int n = num18; n <= num19; n++)
					{
						IL_1A39:
						num2 = 325;
						int num20 = n - num15 + c1FlexGrid2.Rows.Fixed;
						IL_1A53:
						num2 = 326;
						renderTable2.Rows[num20].Height = (double)((float)c1FlexGrid2.Rows[n].HeightDisplay / SysInfo.ScreenDpiY) * 25.4;
						IL_1A96:
						num2 = 327;
						int num21;
						if (c1FlexGrid2.Rows[n].DataIndex >= 0)
						{
							IL_1AB2:
							num2 = 328;
							TableCell tableCell = renderTable2.Cells[num20, 0];
							num21 = c1FlexGrid2.Rows[n].DataIndex + 1;
							tableCell.Text = num21.ToString();
						}
						IL_1AEA:
						num2 = 329;
						num21 = num10;
						for (int num22 = 1; num22 <= num21; num22++)
						{
							IL_1AFC:
							num2 = 330;
							int num23 = dictionary[num22];
							IL_1B0D:
							num2 = 331;
							CellRange mergedRange2 = c1FlexGrid2.GetMergedRange(n, num23, false);
							IL_1B21:
							num2 = 332;
							if (mergedRange2.IsSingleCell || mergedRange2.r1 == n)
							{
								IL_1B3E:
								num2 = 333;
								CellStyle cellStyle = null;
								IL_1B47:
								num2 = 334;
								Bitmap bitmap = new Bitmap(c1FlexGrid2.Cols[num23].WidthDisplay, c1FlexGrid2.Rows[n].HeightDisplay);
								IL_1B7A:
								num2 = 335;
								Image image = null;
								IL_1B83:
								num2 = 336;
								Image image2 = null;
								IL_1B8C:
								num2 = 337;
								CheckEnum a_ = CheckEnum.None;
								IL_1B95:
								num2 = 338;
								string text = c1FlexGrid2.GetDataDisplay(n, num23, out image2, out a_);
								IL_1BAC:
								num2 = 339;
								Graphics graphics = Graphics.FromImage(bitmap);
								IL_1BBB:
								num2 = 340;
								if (c1FlexGrid2.Cols[num23].DataType == typeof(bool))
								{
									IL_1BE0:
									num2 = 341;
									image = ooO.oO0__o.0o__.(c1FlexGrid2, a_);
								}
								IL_1BF1:
								num2 = 342;
								OwnerDrawCellEventArgs ownerDrawCellEventArgs = new OwnerDrawCellEventArgs(null, graphics, n, num23, null, new Rectangle(0, 0, bitmap.Width, bitmap.Height), text, image2);
								IL_1C1F:
								num2 = 343;
								if (control.BaseControl is O_oOooO_O)
								{
									IL_1C32:
									num2 = 344;
									O_oOooO_O o_oOooO_O = (O_oOooO_O)control.BaseControl;
									object a_2 = c1FlexGrid2;
									OwnerDrawCellEventArgs a_3 = ownerDrawCellEventArgs;
									bool a_4 = true;
									bool a_5 = true;
									bool flag = false;
									o_oOooO_O.OO_.00oO0Oo.(a_2, a_3, a_4, a_5, ref flag);
								}
								IL_1C53:
								num2 = 345;
								graphics.Dispose();
								IL_1C60:
								num2 = 346;
								if (ownerDrawCellEventArgs.Image != null)
								{
									IL_1C6F:
									num2 = 347;
									image2 = ownerDrawCellEventArgs.Image;
								}
								IL_1C7E:
								num2 = 348;
								text = ownerDrawCellEventArgs.Text;
								IL_1C8D:
								num2 = 349;
								if (ownerDrawCellEventArgs.Style != null)
								{
									IL_1C9C:
									num2 = 350;
									cellStyle = ownerDrawCellEventArgs.Style;
								}
								IL_1CAB:
								num2 = 351;
								if (image != null)
								{
									IL_1CB5:
									num2 = 352;
									renderTable2.Cells[num20, num22].Image = image;
								}
								else
								{
									IL_1CD7:
									num2 = 354;
									if (image2 != null)
									{
										IL_1CE4:
										num2 = 355;
										if (Operators.CompareString(text, "", true) > 0)
										{
											IL_1CFD:
											num2 = 356;
											RenderImage renderImage = new RenderImage(image2);
											IL_1D0C:
											num2 = 357;
											renderImage.Style.ImageAlign.AlignHorz = ImageAlignHorzEnum.Left;
											IL_1D24:
											num2 = 358;
											renderImage.Style.ImageAlign.AlignVert = ImageAlignVertEnum.Center;
											IL_1D3C:
											num2 = 359;
											renderImage.Style.ImageAlign.StretchHorz = false;
											IL_1D54:
											num2 = 360;
											renderImage.Style.ImageAlign.StretchVert = false;
											IL_1D6C:
											num2 = 361;
											renderImage.Style.Spacing.Left = (double)(2f / SysInfo.ScreenDpiX) * 25.4;
											IL_1D9E:
											num2 = 362;
											renderImage.Style.Spacing.Right = (double)(2f / SysInfo.ScreenDpiX) * 25.4;
											IL_1DD0:
											num2 = 363;
											renderImage.Height = "parent.height";
											IL_1DE7:
											num2 = 364;
											RenderArea renderArea = new RenderArea();
											IL_1DF4:
											num2 = 365;
											RenderText renderText3 = new RenderText();
											IL_1E01:
											num2 = 366;
											renderArea.Height = "parent.height";
											IL_1E18:
											num2 = 367;
											renderArea.Stacking = StackingRulesEnum.BlockLeftToRight;
											IL_1E26:
											num2 = 368;
											renderText3.Height = "parent.height";
											IL_1E3D:
											num2 = 369;
											renderText3.Text = text;
											IL_1E4C:
											num2 = 370;
											renderArea.Children.Add(renderImage);
											IL_1E61:
											num2 = 371;
											renderArea.Children.Add(renderText3);
											IL_1E76:
											num2 = 372;
											renderTable2.Cells[num20, num22].RenderObject = renderArea;
										}
										else
										{
											IL_1E98:
											num2 = 374;
											renderTable2.Cells[num20, num22].Image = image2;
										}
									}
									else
									{
										IL_1EBA:
										num2 = 376;
										renderTable2.Cells[num20, num22].Text = text;
										IL_1ED7:
										num2 = 377;
										renderTable2.Cells[num20, num22].Style.BackgroundImage = bitmap;
										IL_1EF9:
										num2 = 378;
										if (cellStyle != null)
										{
											IL_1F03:
											num2 = 379;
											renderTable2.Cells[num20, num22].Style.TextColor = cellStyle.ForeColor;
											IL_1F2A:
											num2 = 380;
											renderTable2.Cells[num20, num22].Style.BackColor = cellStyle.BackColor;
										}
									}
								}
								IL_1F51:
								num2 = 381;
								if (!mergedRange2.IsSingleCell)
								{
									IL_1F60:
									num2 = 382;
									renderTable2.Cells[num20, num22].SpanRows = mergedRange2.r2 - mergedRange2.r1 + 1;
								}
							}
							IL_1F8C:
							num2 = 383;
						}
						IL_1FA1:
						num2 = 384;
					}
					IL_1FB6:
					num2 = 385;
					int num24 = Conversions.ToInteger(A_1["MinRows"]);
					IL_1FCE:
					num2 = 386;
					if (num24 <= 0 || num16 - num15 + 1 >= num24)
					{
						goto IL_20B9;
					}
					IL_1FEA:
					num2 = 387;
					int num25 = num24 - Math.Max(0, num16 - num15 + 1);
					IL_2002:
					num2 = 388;
					int num26 = num16 + 1;
					int num27 = num16 + num25;
					for (int num28 = num26; num28 <= num27; num28++)
					{
						IL_201A:
						num2 = 389;
						int num29 = num28 - num15 + c1FlexGrid2.Rows.Fixed;
						IL_2034:
						num2 = 390;
						renderTable2.Rows[num29].Height = (double)((float)c1FlexGrid2.Rows.DefaultSize / SysInfo.ScreenDpiY) * 25.4;
						IL_2070:
						num2 = 391;
						renderTable2.Cells[num29, 0].Text = (num28 - c1FlexGrid2.Rows.Fixed + 1).ToString();
						IL_20A4:
						num2 = 392;
					}
					IL_20B9:
					num2 = 393;
					A_0.Generate();
					IL_20C6:
					num2 = 394;
					int count3 = A_0.Pages.Count;
					IL_20D9:
					num2 = 395;
					A_0.Body.Children.Add(renderTable2);
					IL_20F2:
					num2 = 396;
					A_0.Generate();
					IL_20FF:
					num2 = 397;
					int count4 = A_0.Pages.Count;
					IL_2112:
					num2 = 398;
					this.Oo0oo000_._OO. = this.Oo0oo000_._OO. + count4 - count3;
					IL_212A:
					num2 = 399;
					if (Conversions.ToBoolean(A_1["PrintRowNumber"]))
					{
						goto IL_215B;
					}
					IL_2142:
					num2 = 400;
					renderTable2.Cols[0].Visible = false;
					goto IL_215B;
				}
				IL_913:
				num2 = 133;
				Image image3 = null;
				IL_91C:
				num2 = 134;
				RenderImage renderImage2 = new RenderImage();
				IL_929:
				num2 = 135;
				if (control.o.__O0O. != ControlTypeEnum.PictureBox)
				{
					goto IL_980;
				}
				IL_939:
				num2 = 136;
				if (((PictureBox)control).BorderStyle == BorderStyle.None)
				{
					goto IL_968;
				}
				IL_94C:
				num2 = 137;
				renderImage2.Style.Borders.All = LineDef.Default;
				IL_968:
				num2 = 138;
				image3 = ((PictureBox)control).Image;
				goto IL_A5C;
				IL_980:
				num2 = 140;
				if (control.o.__O0O. != ControlTypeEnum.Chart)
				{
					goto IL_9A8;
				}
				IL_990:
				num2 = 141;
				image3 = ((Chart)control).GetImage();
				goto IL_A5C;
				IL_9A8:
				num2 = 143;
				if (control.o.__O0O. != ControlTypeEnum.Painter)
				{
					goto IL_9D0;
				}
				IL_9B8:
				num2 = 144;
				image3 = ((Painter)control).Image;
				goto IL_A5C;
				IL_9D0:
				num2 = 146;
				if (control.o.__O0O. != ControlTypeEnum.PictureViewer)
				{
					goto IL_9FF;
				}
				IL_9E0:
				num2 = 147;
				image3 = ((PictureViewer)control.BaseControl).C1PictureBox1.Image;
				goto IL_A5C;
				IL_9FF:
				num2 = 149;
				if (control.o.__O0O. != ControlTypeEnum.Gauges)
				{
					goto IL_A29;
				}
				IL_A0F:
				num2 = 150;
				image3 = ((O0_O_0O)control.BaseControl).GetImage();
				goto IL_A5C;
				IL_A29:
				num2 = 152;
				if (control.o.__O0O. != ControlTypeEnum.Map)
				{
					goto IL_A5C;
				}
				IL_A39:
				num2 = 153;
				GeoMap geoMap = (GeoMap)control.BaseControl;
				IL_A4C:
				num2 = 154;
				image3 = geoMap.GetBitmap(false);
				IL_A5C:
				num2 = 155;
				IL_A65:
				num2 = 156;
				renderImage2.Image = image3;
				IL_A74:
				num2 = 157;
				renderImage2.X = Conversions.ToDouble(A_1["Left"]);
				IL_A96:
				num2 = 158;
				renderImage2.Y = A_3;
				IL_AAA:
				num2 = 159;
				renderImage2.Style.ImageAlign.AlignHorz = ImageAlignHorzEnum.Center;
				IL_AC2:
				num2 = 160;
				renderImage2.Style.ImageAlign.AlignVert = ImageAlignVertEnum.Center;
				IL_ADA:
				num2 = 161;
				renderImage2.Style.ImageAlign.StretchHorz = true;
				IL_AF2:
				num2 = 162;
				renderImage2.Style.ImageAlign.StretchVert = true;
				IL_B0A:
				num2 = 163;
				renderImage2.Style.ImageAlign.KeepAspectRatio = true;
				IL_B22:
				num2 = 164;
				renderImage2.Height = Conversions.ToDouble(A_1["Height"]);
				IL_B44:
				num2 = 165;
				renderImage2.Width = Conversions.ToDouble(A_1["Width"]);
				IL_B66:
				num2 = 166;
				if (!A_4)
				{
					goto IL_BA4;
				}
				IL_B70:
				num2 = 167;
				RenderEmpty renderEmpty9 = new RenderEmpty();
				IL_B7D:
				num2 = 168;
				renderEmpty9.BreakAfter = BreakEnum.Page;
				IL_B8B:
				num2 = 169;
				A_0.Body.Children.Add(renderEmpty9);
				IL_BA4:
				num2 = 170;
				A_0.Body.Children.Add(renderImage2);
				IL_215B:
				goto IL_27F5;
				IL_2160:
				int num30 = num31 + 1;
				num31 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num30);
				IL_27B6:
				goto IL_27EA;
				IL_27B8:
				num31 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_27C8:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num31 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_27B8;
			}
			IL_27EA:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_27F5:
			if (num31 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 将输入焦点移到此窗口
		/// </summary>
		// Token: 0x06003F2C RID: 16172 RVA: 0x001CEBFC File Offset: 0x001CCDFC
		public void Select()
		{
			if (this.Pane.CanFocus)
			{
				this.Pane.Focus();
			}
		}

		/// <summary>
		/// 如果是下拉窗口，可通过此属性获取展开此下拉窗口的DropDownBox
		/// </summary>
		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06003F2D RID: 16173 RVA: 0x001CEC18 File Offset: 0x001CCE18
		[oO0oooo("2112")]
		public DropDownBox DropDownBox
		{
			get
			{
				DropDownBox result;
				if (this.Pane == null || this.Pane.ooOo.o_. == null)
				{
					result = null;
				}
				else
				{
					result = new DropDownBox(this.Pane.ooOo.o_.);
				}
				return result;
			}
		}

		/// <summary>
		///  如果是下拉窗口，可通过此属性获取展开此下拉窗口的Table
		/// </summary>
		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06003F2E RID: 16174 RVA: 0x001CEC50 File Offset: 0x001CCE50
		[oO0oooo("2704")]
		public Table DropTable
		{
			get
			{
				return this.Pane.ooOo.o_.;
			}
		}

		/// <summary>
		///  如果是下拉窗口，可通过此属性获取展开此下拉窗口的Col
		/// </summary>
		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06003F2F RID: 16175 RVA: 0x001CEC5D File Offset: 0x001CCE5D
		[oO0oooo("2704")]
		public Col DropCol
		{
			get
			{
				return this.Pane.O00O00o_oOo.o_.;
			}
		}

		/// <summary>
		/// 禁用模式窗口和独立窗口的标题栏的关闭按钮
		/// </summary>
		// Token: 0x06003F30 RID: 16176 RVA: 0x001CEC6C File Offset: 0x001CCE6C
		[oO0oooo("2217")]
		public void DisableXButton()
		{
			Form baseForm = this.BaseForm;
			if (baseForm != null)
			{
				ShareLibriay.RemoveXButton((int)baseForm.Handle);
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06003F31 RID: 16177 RVA: 0x001CEC94 File Offset: 0x001CCE94
		internal string mmname
		{
			get
			{
				return "窗口," + this.Name;
			}
		}

		/// <summary>
		/// 返回顶层控件集合
		/// </summary>
		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06003F32 RID: 16178 RVA: 0x001CECA6 File Offset: 0x001CCEA6
		[oO0oooo("2442")]
		public ChildrenCollection children
		{
			get
			{
				return oOO0oo_o0.o.O0o000_.(this.Pane);
			}
		}

		/// <summary>
		/// 设置默认按钮名称
		/// </summary>
		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06003F33 RID: 16179 RVA: 0x001CECB4 File Offset: 0x001CCEB4
		// (set) Token: 0x06003F34 RID: 16180 RVA: 0x001CED1C File Offset: 0x001CCF1C
		[oO0oooo("2500")]
		public string AcceptButton
		{
			get
			{
				string result;
				if (this.Pane.FindForm() != Main.OO_O.o. && this.Pane.FindForm().AcceptButton != null && this.Pane.FindForm().AcceptButton is Button)
				{
					result = ((Button)this.Pane.FindForm().AcceptButton).Name;
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (this.Pane.FindForm() != Main.OO_O.o.)
				{
					Control control = this.o_._o000O.(this.Pane.Controls, value);
					if (control != null && control is Button)
					{
						this.Pane.FindForm().AcceptButton = (Button)control.BaseControl;
					}
				}
			}
		}

		/// <summary>
		/// 设置取消按钮名称
		/// </summary>
		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06003F35 RID: 16181 RVA: 0x001CED74 File Offset: 0x001CCF74
		// (set) Token: 0x06003F36 RID: 16182 RVA: 0x001CEDDC File Offset: 0x001CCFDC
		[oO0oooo("2501")]
		public string CancelButton
		{
			get
			{
				string result;
				if (this.Pane.FindForm() != Main.OO_O.o. && this.Pane.FindForm().CancelButton != null && this.Pane.FindForm().CancelButton is Button)
				{
					result = ((Button)this.Pane.FindForm().CancelButton).Name;
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (this.Pane.FindForm() != Main.OO_O.o.)
				{
					Control control = this.o_._o000O.(this.Pane.Controls, value);
					if (control != null && control is Button)
					{
						this.Pane.FindForm().CancelButton = (Button)control.BaseControl;
					}
				}
			}
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x001CEE34 File Offset: 0x001CD034
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetTheme(string theme, bool Form)
		{
			if (Form)
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(theme, new object[]
				{
					this,
					this.Panel
				});
			}
			try
			{
				foreach (Control control in this.Controls)
				{
					if (!(control.BaseControl is O_oOooO_O) && Operators.CompareString(Main.OO_O.o..o0_o_o_0.0O.(control.BaseControl), "(none)", true) != 0)
					{
						control.Theme = theme;
					}
				}
			}
			finally
			{
				IEnumerator<Control> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		/// <summary>
		/// 设置窗口样式
		/// </summary>
		/// <param name="theme">样式名</param>
		// Token: 0x06003F38 RID: 16184 RVA: 0x001CEED0 File Offset: 0x001CD0D0
		[oO0oooo("3305")]
		public void SetTheme(string theme)
		{
			this.SetTheme(theme, false);
		}

		/// <summary>
		/// 设置提示信息的图标
		/// </summary>
		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06003F39 RID: 16185 RVA: 0x001CEEDA File Offset: 0x001CD0DA
		// (set) Token: 0x06003F3A RID: 16186 RVA: 0x001CEEEC File Offset: 0x001CD0EC
		public ToolTipIcon ShowToolTipIcon
		{
			get
			{
				return this.Pane.ToolTip1.ToolTipIcon;
			}
			set
			{
				this.Pane.ToolTip1.ToolTipIcon = value;
			}
		}

		/// <summary>
		/// 设置提示信息的标题
		/// </summary>
		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06003F3B RID: 16187 RVA: 0x001CEEFF File Offset: 0x001CD0FF
		// (set) Token: 0x06003F3C RID: 16188 RVA: 0x001CEF11 File Offset: 0x001CD111
		public string TootlTipTitle
		{
			get
			{
				return this.Pane.ToolTip1.ToolTipTitle;
			}
			set
			{
				this.Pane.ToolTip1.ToolTipTitle = value;
			}
		}

		/// <summary>
		/// 是否使用气球状提示
		/// </summary>
		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06003F3D RID: 16189 RVA: 0x001CEF24 File Offset: 0x001CD124
		// (set) Token: 0x06003F3E RID: 16190 RVA: 0x001CEF36 File Offset: 0x001CD136
		public bool ToolTipBalloon
		{
			get
			{
				return this.Pane.ToolTip1.IsBalloon;
			}
			set
			{
				this.Pane.ToolTip1.IsBalloon = value;
			}
		}

		/// <summary>
		/// 清除所有错误提示
		/// </summary>
		// Token: 0x06003F3F RID: 16191 RVA: 0x001CEF49 File Offset: 0x001CD149
		[oO0oooo("2677")]
		public void ClearErrors()
		{
			this.Pane.ErrorProvider1.Clear();
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x001CEF5B File Offset: 0x001CD15B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_0._O.();
			this.Pane.ooOo.o_. = null;
			this.Pane.ooOo.o_. = null;
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x001CEF7C File Offset: 0x001CD17C
		internal void <<EMPTY_NAME>>()
		{
			if (this.Pane.FindForm() != null)
			{
				try
				{
					foreach (Control control in this.o_0.o0..Keys)
					{
						((OoO_)control).O_o.o__.(this.o_0.o0.[control]);
					}
				}
				finally
				{
					Dictionary<Control, string>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.o_0.o0..Clear();
			}
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x001CEFFC File Offset: 0x001CD1FC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Pane.FindForm() != null)
			{
				FormEventArgs formEventArgs = new FormEventArgs(this);
				string a_ = "SizeChanged_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					formEventArgs
				}, true, this.mmname, false);
			}
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x001CF05C File Offset: 0x001CD25C
		internal void <<EMPTY_NAME>>()
		{
			this.O_0.O00o_00_O..Clear();
			this.o_0.o0. = null;
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
			{
				this.O_o_.0o0__o0O.["Key"].ToString(),
				o0_O.oo0_.O0Oo_o.
			});
			if (dataRow != null)
			{
				string a_ = dataRow["Config"].ToString();
				OO_ oo_ = new OO_(a_, this);
				oo_.o.__o_O.();
				this.O_0.O00o_00_O. = oo_.o.__o_O.;
				List<string> list = new List<string>();
				list.AddRange(this.O_0.O00o_00_O..Keys);
				for (int i = list.Count - 1; i >= 0; i += -1)
				{
					ToolStrip toolStrip = this.O_0.O00o_00_O.[list[i]];
					if (!(toolStrip is ContextMenuStrip))
					{
						this.Pane.Controls.Add(toolStrip);
					}
				}
				this.o_0.o0. = new StripCollection(this.O_0.O00o_00_O., this);
			}
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x001CF169 File Offset: 0x001CD369
		private ToolStrip <<EMPTY_NAME>>(ToolStripItem A_0)
		{
			while (A_0.OwnerItem != null && !(A_0.OwnerItem is ToolStripOverflowButton))
			{
				A_0 = A_0.OwnerItem;
			}
			ToolStrip owner = A_0.Owner;
			return A_0.Owner;
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x001CF198 File Offset: 0x001CD398
		internal void <<EMPTY_NAME>>(object A_0, ToolStripItemClickedEventArgs A_1)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (A_1.ClickedItem is ToolStripSplitButton)
				{
					goto IL_313;
				}
				IL_19:
				num2 = 4;
				if (OO_00oOO.Forms.ActiveForm == null)
				{
					goto IL_75;
				}
				IL_27:
				num2 = 5;
				Control control = (Control)OO_00oOO.Forms.ActiveForm.ActiveControl;
				IL_3F:
				num2 = 6;
				if (control == null)
				{
					goto IL_75;
				}
				IL_45:
				num2 = 7;
				Control baseControl = control.BaseControl;
				IL_50:
				num2 = 8;
				if (!(baseControl is C1TextBox))
				{
					goto IL_6B;
				}
				IL_5B:
				num2 = 9;
				((C1TextBox)baseControl).UpdateValueWithCurrentText();
				IL_6B:
				num2 = 10;
				control.WriteValue();
				IL_75:
				num2 = 11;
				if (this.Pane.FindForm() != Main.OO_O.o.)
				{
					goto IL_F6;
				}
				IL_8A:
				num2 = 12;
				if (Main.OO_O.o..ActiveControl == null)
				{
					goto IL_F6;
				}
				IL_99:
				num2 = 13;
				if (!(Main.OO_O.o..ActiveControl is C1TextBox))
				{
					goto IL_F6;
				}
				IL_AD:
				num2 = 14;
				C1TextBox c1TextBox = (C1TextBox)Main.OO_O.o..ActiveControl;
				IL_C1:
				num2 = 15;
				c1TextBox.UpdateValueWithCurrentText();
				IL_CC:
				num2 = 16;
				if (c1TextBox.DataBindings.Count <= 0)
				{
					goto IL_F3;
				}
				IL_DE:
				num2 = 17;
				c1TextBox.DataBindings[0].WriteValue();
				IL_F3:
				c1TextBox = null;
				IL_F6:
				num2 = 19;
				if (this.Pane == null || this.Pane.Disposing || this.Pane.IsDisposed || !this.Opened || this.Pane.ActiveControl == null)
				{
					goto IL_171;
				}
				IL_130:
				num2 = 20;
				Control control2 = (Control)this.ActiveControl;
				IL_140:
				num2 = 21;
				if (control2 == null)
				{
					goto IL_171;
				}
				IL_147:
				num2 = 22;
				if (!(control2.BaseControl is C1FlexGrid))
				{
					goto IL_171;
				}
				IL_158:
				num2 = 23;
				if (!((C1FlexGrid)control2.BaseControl).FinishEditing())
				{
					goto IL_313;
				}
				IL_171:
				num2 = 25;
				ToolStrip a_ = this.o_.oo_o_00_.(A_1.ClickedItem);
				IL_181:
				num2 = 26;
				ToolStripItem ownerItem = A_1.ClickedItem.OwnerItem;
				IL_191:
				num2 = 27;
				StripItemEventArgs stripItemEventArgs = new StripItemEventArgs(a_, A_1.ClickedItem, ownerItem, this);
				IL_1A5:
				num2 = 28;
				string a_2 = "ItemClick_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				IL_1C9:
				num2 = 29;
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_2, new object[]
				{
					stripItemEventArgs
				}, true, this.mmname, false);
				IL_1ED:
				num2 = 30;
				if (this.Pane == null || this.Pane.Disposing || this.Pane.IsDisposed || !this.Opened || this.Pane.ActiveControl == null)
				{
					goto IL_313;
				}
				IL_236:
				num2 = 31;
				Control control3 = (Control)this.ActiveControl;
				IL_246:
				num2 = 32;
				if (control3 == null)
				{
					goto IL_313;
				}
				IL_250:
				num2 = 33;
				if (!(control3.BaseControl is C1TextBox))
				{
					goto IL_313;
				}
				IL_264:
				num2 = 34;
				this.StopRedraw();
				IL_26D:
				num2 = 35;
				int num3 = -1;
				IL_273:
				num2 = 36;
				int length = -1;
				IL_279:
				num2 = 37;
				if (!(control3.BaseControl is C1TextBox))
				{
					goto IL_2B6;
				}
				IL_28A:
				num2 = 38;
				C1TextBox c1TextBox2 = (C1TextBox)control3.BaseControl;
				IL_29B:
				num2 = 39;
				num3 = c1TextBox2.SelectionStart;
				IL_2A7:
				num2 = 40;
				length = c1TextBox2.SelectionLength;
				IL_2B3:
				c1TextBox2 = null;
				IL_2B6:
				num2 = 42;
				control3.Enabled = false;
				IL_2C1:
				num2 = 43;
				control3.Enabled = true;
				IL_2CC:
				num2 = 44;
				control3.Select();
				IL_2D6:
				num2 = 45;
				if (num3 < 0)
				{
					goto IL_300;
				}
				IL_2DE:
				num2 = 46;
				C1TextBox c1TextBox3 = (C1TextBox)control3.BaseControl;
				IL_2EF:
				num2 = 47;
				c1TextBox3.Select(num3, length);
				IL_2FD:
				c1TextBox3 = null;
				IL_300:
				num2 = 49;
				control3.Select();
				IL_30A:
				num2 = 50;
				this.ResumeRedraw();
				IL_313:
				goto IL_431;
				IL_318:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_3F2:
				goto IL_426;
				IL_3F4:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_404:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3F4;
			}
			IL_426:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_431:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x001CF5FC File Offset: 0x001CD7FC
		internal void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_._o000O.((ToolStripItem)A_0);
			ToolStripItem ownerItem = ((ToolStripItem)A_0).OwnerItem;
			StripItemEventArgs stripItemEventArgs = new StripItemEventArgs(this.o_._o000O.((ToolStripItem)A_0), (ToolStripItem)A_0, ownerItem, this);
			string a_ = "ItemMouseEnter_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				stripItemEventArgs
			}, true, this.mmname, false);
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x001CF67C File Offset: 0x001CD87C
		internal void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_._o000O.((ToolStripItem)A_0);
			ToolStripItem ownerItem = ((ToolStripItem)A_0).OwnerItem;
			StripItemEventArgs stripItemEventArgs = new StripItemEventArgs(this.o_._o000O.((ToolStripItem)A_0), (ToolStripItem)A_0, ownerItem, this);
			string a_ = "ItemMouseLeave_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				stripItemEventArgs
			}, true, this.mmname, false);
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x001CF6FC File Offset: 0x001CD8FC
		internal void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_._o000O.((ToolStripItem)A_0);
			ToolStripItem ownerItem = ((ToolStripItem)A_0).OwnerItem;
			StripItemEventArgs stripItemEventArgs = new StripItemEventArgs(this.o_._o000O.((ToolStripItem)A_0), (ToolStripItem)A_0, ownerItem, this);
			string a_ = "ItemMouseHover_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
			O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
			{
				stripItemEventArgs
			}, true, this.mmname, false);
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x001CF77C File Offset: 0x001CD97C
		private ToolStrip <<EMPTY_NAME>>(ToolStripItem A_0)
		{
			while (A_0.Owner == null || A_0.OwnerItem != null)
			{
				if (A_0.OwnerItem == null)
				{
					return null;
				}
				A_0 = A_0.OwnerItem;
			}
			return A_0.Owner;
		}

		/// <summary>
		/// 返回窗口的所有菜单，包括主菜单、工具栏、快捷菜单和状态栏
		/// </summary>
		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06003F4A RID: 16202 RVA: 0x001CF7B7 File Offset: 0x001CD9B7
		[oO0oooo("Strips")]
		public StripCollection Strips
		{
			get
			{
				if (this.o_0.o0. == null)
				{
					this.o_0.o0. = new StripCollection(this.O_0.O00o_00_O., this);
				}
				return this.o_0.o0.;
			}
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x001CF7DC File Offset: 0x001CD9DC
		internal void <<EMPTY_NAME>>()
		{
			List<ListView> list = new List<ListView>();
			try
			{
				foreach (Control control in this.Controls)
				{
					control.BaseControl.Tag = "";
					if (control.BaseControl is C1TopicBar)
					{
						C1TopicBar c1TopicBar = (C1TopicBar)control.BaseControl;
						c1TopicBar.Visible = true;
						if (c1TopicBar.Pages.Count > 0)
						{
							c1TopicBar.Pages[0].PageVisible = true;
						}
					}
					else if (control.BaseControl is ListView)
					{
						list.Add((ListView)control.BaseControl);
					}
				}
			}
			finally
			{
				IEnumerator<Control> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (ListView listView in list)
				{
					listView.Enabled = false;
					listView.Parent.Controls.Remove(listView);
				}
			}
			finally
			{
				List<ListView>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			this.Pane.ActiveControl = null;
			Application.DoEvents();
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x001CF904 File Offset: 0x001CDB04
		internal void <<EMPTY_NAME>>()
		{
			this.StopRedraw();
			Main.OO_O.o..o0oO_O.0Oo_00.(this.Panel.Controls);
			try
			{
				foreach (ToolStrip toolStrip in this.O_0.O00o_00_O..Values)
				{
					Main.OO_O.o..o0oO_O.0Oo_00.(new object[]
					{
						toolStrip
					});
				}
			}
			finally
			{
				Dictionary<string, ToolStrip>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (Control control in this.Controls)
				{
					if (control is PictureBox)
					{
						((PictureBox)control).ImageFile = "";
					}
					this.o0o_._O0.(control.BaseControl);
				}
			}
			finally
			{
				IEnumerator<Control> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x001CF9E0 File Offset: 0x001CDBE0
		private void <<EMPTY_NAME>>(Control A_0)
		{
			if (!(A_0 is O_oOooO_O))
			{
				if (A_0 is C1Chart)
				{
					A_0.Click -= this.OOo000o.0OO_O0.;
					A_0.DoubleClick -= this.oOoo000O.0_.;
					A_0.MouseHover -= this.O_o00_._Oo0O.;
					A_0.MouseMove -= this.OoOO_o.00_.;
					A_0.MouseDown -= this.oo.0O0___0.;
					A_0.MouseUp -= this.O.OOo0O.;
					((C1Chart)A_0).ShowTooltip -= this.O.OOo0O.;
				}
				else
				{
					A_0.Enter -= this.O0_oO.0_O0.;
					A_0.Leave -= this.oo_.o_oo.;
					A_0.Validating -= this.OOO0.OOOoO.;
					A_0.KeyPress -= this.O0O.OO0OO0.;
					A_0.KeyDown -= this.o_.oo_o_00_.;
					A_0.KeyUp -= this.O0O.OO0OO0.;
					A_0.Click -= this.oo0.OOooo_.;
					A_0.MouseClick -= this.o_oo.O_O_.;
					A_0.DoubleClick -= this.o00_.__00.;
					A_0.MouseEnter -= this.Oo.Oooo0o_.;
					A_0.MouseLeave -= this.oo0OOo0_o.oOoo.;
					A_0.MouseHover -= this.o_ooO0.o___0.;
					A_0.MouseMove -= this.O_0OO._.;
					A_0.MouseDown -= this.o._0_0_o_o0O.;
					A_0.MouseUp -= this.O_OOo.o_0o.;
				}
				if (A_0 is C1TextBox)
				{
					C1TextBox c1TextBox = (C1TextBox)A_0;
					c1TextBox.Formatting -= this.Oo_O00ooo.OO_.;
					c1TextBox.Parsing -= this.Oo_O00ooo.OO_.;
				}
				if (A_0 is C1Label)
				{
					((C1Label)A_0).Formatting -= this.Oo_O00ooo.OO_.;
				}
				if (A_0 is C1NumericEdit)
				{
					C1NumericEdit c1NumericEdit = (C1NumericEdit)A_0;
					c1NumericEdit.TextChanged -= this.oo__o.o0.;
					c1NumericEdit.ValueChanged -= this.Oo_0o_oOo0oO.o.;
					return;
				}
				if (A_0 is O_0oOoOo)
				{
					O_0oOoOo o_0oOoOo = (O_0oOoOo)A_0;
					o_0oOoOo.TextChanged -= this.oo__o.o0.;
					o_0oOoOo.ValueChanged -= this.Oo_0o_oOo0oO.o.;
					return;
				}
				if (A_0 is O00o)
				{
					((O00o)A_0).ValueChanged -= this.Oo_0o_oOo0oO.o.;
					return;
				}
				if (A_0 is oOO)
				{
					((oOO)A_0).ValueChanged -= this.Oo_0o_oOo0oO.o.;
					return;
				}
				if (A_0 is O0O_O0)
				{
					if (!(A_0 is O__o))
					{
						O0O_O0 o0O_O = (O0O_O0)A_0;
						o0O_O.TextChanged -= this.oo__o.o0.;
						o0O_O.ValueChanged -= this.Oo_0o_oOo0oO.o.;
						return;
					}
				}
				else
				{
					if (A_0 is CustomColorLabel)
					{
						((CustomColorLabel)A_0).BackColorChanged -= this.Oo_0o_oOo0oO.o.;
						return;
					}
					if (A_0 is O_0oOoOo)
					{
						O_0oOoOo o_0oOoOo2 = (O_0oOoOo)A_0;
						o_0oOoOo2.TextChanged -= this.oo__o.o0.;
						o_0oOoOo2.ValueChanged -= this.Oo_0o_oOo0oO.o.;
						if (o_0oOoOo2.oO._0o_O__. != null)
						{
							o_0oOoOo2.DropDownForm = null;
							Main.OO_O.o..o0oO_O.0Oo_00.(new object[]
							{
								o_0oOoOo2.oO._0o_O__..o.O_OO.()
							});
							o_0oOoOo2.oO._0o_O__..Controls.Clear();
							o_0oOoOo2.oO._0o_O__..Close();
							o_0oOoOo2.oO._0o_O__..Dispose();
							o_0oOoOo2.oO._0o_O__. = null;
						}
						return;
					}
					if (A_0 is OooO00O)
					{
						OooO00O oooO00O = (OooO00O)A_0;
						oooO00O.TextChanged -= this.oo__o.o0.;
						oooO00O.ValueChanged -= this.Oo_0o_oOo0oO.o.;
						oooO00O.UpDownButtonClick -= this.OOO0.OOOoO.;
						oooO00O.ModalButtonClick -= this.o0.ooo.;
						return;
					}
					if (A_0 is OoOO0Oo_oo0oO)
					{
						OoOO0Oo_oo0oO ooOO0Oo_oo0oO = (OoOO0Oo_oo0oO)A_0;
						ooOO0Oo_oo0oO.TextChanged -= this.oo__o.o0.;
						ooOO0Oo_oo0oO.ValueChanged -= this.Oo_0o_oOo0oO.o.;
						ooOO0Oo_oo0oO.oOOO_.o.(new OoOO0Oo_oo0oO.o0__0(this.o_._O__O.));
						ooOO0Oo_oo0oO.O.oO. = null;
						return;
					}
					if (A_0 is O0oo000oO0oo_)
					{
						O0oo000oO0oo_ o0oo000oO0oo_ = (O0oo000oO0oo_)A_0;
						o0oo000oO0oo_.TextChanged -= this.oo__o.o0.;
						o0oo000oO0oo_.ValueChanged -= this.Oo_0o_oOo0oO.o.;
						o0oo000oO0oo_.o0OO0._0.(new O0oo000oO0oo_.o0_00__ooOo(this.o_._O__O.));
						o0oo000oO0oo_.o0OO0._0.(new O0oo000oO0oo_.oO0__(this.o0000o_Oo0.0_.));
						return;
					}
					if (A_0 is CustomCheckedListBox)
					{
						CustomCheckedListBox customCheckedListBox = (CustomCheckedListBox)A_0;
						customCheckedListBox.SelectedIndexChanged -= this.o_._O__O.;
						customCheckedListBox.Format -= this.o0000o_Oo0.0_.;
						customCheckedListBox.ItemCheck -= this.o_.oo_o_00_.;
						return;
					}
					if (A_0 is CustomListBox)
					{
						CustomListBox customListBox = (CustomListBox)A_0;
						customListBox.SelectedIndexChanged -= this.o_._O__O.;
						customListBox.O.00_Oo. = null;
						return;
					}
					if (A_0 is CustomCheckBox)
					{
						((CheckBox)A_0).CheckedChanged -= this.OooO_._oO_0.;
						return;
					}
					if (A_0 is oO00O0oO0o000)
					{
						((oO00O0oO0o000)A_0).CheckedChanged -= this.OooO_._oO_0.;
						return;
					}
					if (A_0 is SplitContainer)
					{
						((SplitContainer)A_0).SplitterMoved -= this.o.o0oO__0__00_.;
						return;
					}
					if (A_0 is C1DockingTab)
					{
						C1DockingTab c1DockingTab = (C1DockingTab)A_0;
						c1DockingTab.SelectedIndexChanged -= this.o_._O__O.;
						c1DockingTab.SelectedIndexChanging -= this.o.o0oO__0__00_.;
						return;
					}
					if (A_0 is O_OOO)
					{
						((O_OOO)A_0).SelectedPanelChanged -= this.o_._O__O.;
						return;
					}
					if (A_0 is TreeView)
					{
						TreeView treeView = (TreeView)A_0;
						treeView.AfterSelect -= this.O_OoO_.Oo_0_o.;
						treeView.AfterLabelEdit -= this.oooO.0o00_.;
						treeView.BeforeLabelEdit -= this.Oo_OoO.o_.;
						treeView.AfterCheck -= this.O.00oo_OO0O.;
						treeView.BeforeSelect -= this.O_0.oOO.;
						treeView.AfterExpand -= this.O__0._o.;
						treeView.AfterCollapse -= this.oooO.0o00_.;
						treeView.BeforeExpand -= this.Oo_OoO.o_.;
						treeView.NodeMouseClick -= this.O_OOo.o_0o.;
						treeView.NodeMouseDoubleClick -= this.ooO0O.00.;
						treeView.NodeMouseHover -= this.ooO0O.00.;
						return;
					}
					if (A_0 is o_OO_oOOO0o)
					{
						ListView listView = (ListView)A_0;
						listView.RetrieveVirtualItem -= this.Oo0Oo0000.__.;
						listView.CacheVirtualItems -= this.oO0._o0__o_o_O.;
						listView.ItemActivate -= this.O00.0_OO00oO_.;
						listView.BeforeLabelEdit -= this.oO0._o0__o_o_O.;
						listView.AfterLabelEdit -= this.oooO.0o00_.;
						listView.ItemSelectionChanged -= this.O0O.OO0OO0.;
						listView.ItemCheck -= this.o0000o_Oo0.0_.;
						listView.ItemChecked -= this.o0000o_Oo0.0_.;
						listView.DrawSubItem -= this.Oo_O00ooo.OO_.;
						listView.DrawColumnHeader -= this.Oo_O00ooo.OO_.;
						return;
					}
					if (A_0 is C1TopicBar)
					{
						C1TopicBar c1TopicBar = (C1TopicBar)A_0;
						c1TopicBar.LinkClick -= this.OOO0.OOOoO.;
						c1TopicBar.PageCollapsed -= this.OOo0O0.0.;
						c1TopicBar.PageExpanded -= this.OOO0.OOOoO.;
						return;
					}
					if (A_0 is MonthCalendar)
					{
						MonthCalendar monthCalendar = (MonthCalendar)A_0;
						monthCalendar.DateChanged -= this.oOo_0o_o_0_.O.;
						monthCalendar.DateSelected -= this.Oo_O00ooo.OO_.;
						return;
					}
					if (A_0 is OoOoo00)
					{
						((OoOoo00)A_0).Scroll -= this.O000_0O__o._.;
						return;
					}
					if (A_0 is Panel)
					{
						((Panel)A_0).Scroll -= this.oO_.0_0.;
						return;
					}
					if (A_0 is O0_O_0O)
					{
						C1Gauge c1Gauge = (C1Gauge)A_0;
						c1Gauge.ItemClick -= this.Oo.o__00_.;
						c1Gauge.ItemDoubleClick -= this.o_.0_o0_O_000.;
						c1Gauge.ItemStateChanged -= this.Oo0_OOOo.Oo.;
						c1Gauge.ItemMouseDown -= this.o0oo_o.OO.;
						c1Gauge.ItemMouseUp -= this.Oo0_OOOo.Oo.;
						c1Gauge.ItemMouseEnter -= this.o0oo_o.OO.;
						c1Gauge.ItemMouseLeave -= this.O_00.o.;
						c1Gauge.ItemMouseMove -= this.O_00.o.;
						try
						{
							foreach (object obj in ((C1Gauge)A_0).Gauges)
							{
								C1GaugeBase c1GaugeBase = (C1GaugeBase)obj;
								c1GaugeBase.PointerDragMove -= this.o_.0_o000o.;
								c1GaugeBase.PointerDragBegin -= this.O.0o00__.;
								c1GaugeBase.PointerDragEnd -= this.o_.o_oOo0O.;
								c1GaugeBase.PointerDragCancel -= this.oO_.0_0.;
								c1GaugeBase.ItemClick -= this.Oo.o__00_.;
								c1GaugeBase.ItemDoubleClick -= this.o_.0_o0_O_000.;
								c1GaugeBase.ItemStateChanged -= this.Oo0_OOOo.Oo.;
								c1GaugeBase.ItemMouseDown -= this.o0oo_o.OO.;
								c1GaugeBase.ItemMouseUp -= this.Oo0_OOOo.Oo.;
								c1GaugeBase.ItemMouseEnter -= this.o0oo_o.OO.;
								c1GaugeBase.ItemMouseLeave -= this.O_00.o.;
								c1GaugeBase.ItemMouseMove -= this.O_00.o.;
								c1GaugeBase.FormatLabel -= this.O_.O__Oo.;
								c1GaugeBase.PointerValueChanged -= this.O_00.o.;
							}
							return;
						}
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
					}
					if (A_0 is GanttView)
					{
						GanttView ganttView = (GanttView)A_0;
						((ToolStrip)ganttView.Controls[4]).ItemClicked -= this.O_.O__Oo.;
						ganttView.AfterEditTask -= this.O_OoO_.Oo_0_o.;
						ganttView.BeforeEditTask -= this.O__0._o.;
						ganttView.BeforeRemoveTask -= this.oO0._o0__o_o_O.;
						ganttView.BeforeRemoveTask -= this.oO0._o0__o_o_O.;
						ganttView.TaskBarTooltip -= this.o.o0oO__0__00_.;
						ganttView.BeforeMoveTasks -= this.oO0._o0__o_o_O.;
						ganttView.TaskBarClick -= this.o.o0oO__0__00_.;
						ganttView.PaintDay -= this.oO_.0_0.;
						ganttView.SelectedIndexChanged -= this.Oo.o__00_.;
						return;
					}
					if (A_0 is GeoMap)
					{
						GeoMap geoMap = (GeoMap)A_0;
						geoMap.ZoomChanged -= this.o_.O_00OOOo0_O.;
						geoMap.CenterChanged -= this.Oo._0O0_.;
						return;
					}
					if (A_0 is WebViewer)
					{
						WebViewer webViewer = (WebViewer)A_0;
						webViewer.Oo0Oo_0oo0.0.();
						webViewer.CoreWebView2InitializationCompleted -= this.O0O0.O.;
						webViewer.ZoomFactorChanged -= this.o._oOO_o.;
						if (webViewer.CoreWebView2 != null)
						{
							webViewer.Stop();
							webViewer.CoreWebView2.NavigationStarting -= this.O0O0.O.;
							webViewer.CoreWebView2.NavigationCompleted -= this.O0O0.O.;
							webViewer.CoreWebView2.ContentLoading -= this.OOO0.OOOoO.;
							webViewer.CoreWebView2.SourceChanged -= this.O0O0.O.;
							webViewer.CoreWebView2.DOMContentLoaded -= this.O0O0.O.;
							webViewer.CoreWebView2.ScriptDialogOpening -= this.OO.OoO_o.;
							webViewer.CoreWebView2.StatusBarTextChanged -= this.O0_0O.__0_.;
							webViewer.CoreWebView2.ContextMenuRequested -= this.OOO0.OOOoO.;
							webViewer.CoreWebView2.HistoryChanged -= this.O0O0.O.;
							webViewer.CoreWebView2.WebMessageReceived -= this.OO.OoO_o.;
							webViewer.CoreWebView2.NewWindowRequested -= this.O0O0.O.;
							webViewer.CoreWebView2.WebResourceRequested -= this.OO.OoO_o.;
							webViewer.CoreWebView2.WebResourceResponseReceived -= this.OO.OoO_o.;
							webViewer.CoreWebView2.SaveAsUIShowing -= this.O0O0.O.;
							webViewer.CoreWebView2.DownloadStarting -= this.O0O0.O.;
							webViewer.CoreWebView2.PermissionRequested -= this.O0O0.O.;
						}
					}
				}
			}
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x001D06E0 File Offset: 0x001CE8E0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (A_0 is C1TextBox)
			{
				this.OOO0.OOOoO.((C1TextBox)A_0);
			}
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x001D06F8 File Offset: 0x001CE8F8
		private void <<EMPTY_NAME>>(Control A_0)
		{
			Control control = ooO_0O.o_O0.O_.(A_0);
			if (control != null)
			{
				O000O o000O = A_0 as O000O;
				if (o000O != null)
				{
					if (!o000O.OoO.Oo0O0o.())
					{
						o000O.OoO.Oo0O0o.(true);
						control.WriteValue();
						o000O.OoO.Oo0O0o.(false);
						return;
					}
				}
				else
				{
					control.WriteValue();
				}
			}
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x001D073C File Offset: 0x001CE93C
		private void <<EMPTY_NAME>>(object A_0, C1SizerLightEventArgs A_1)
		{
			Control control = A_1.Control;
			if (control != null)
			{
				ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
				string a_ = "ResizingControl_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname + "," + control.Name, false);
				A_1.Cancel = controlEventArgs.Cancel;
			}
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x001D07B8 File Offset: 0x001CE9B8
		private void <<EMPTY_NAME>>(object A_0, C1SizerLightEventArgs A_1)
		{
			Control control = A_1.Control;
			if (control != null)
			{
				ControlEventArgs controlEventArgs = new ControlEventArgs(control, this);
				string a_ = "ResizingFont_" + Conversions.ToString(this.O_o_.0o0__o0O.["Key"]);
				O_O0OO.OoO_o.oO0o0O.(this.O_0.O00o_00_O., a_, new object[]
				{
					controlEventArgs
				}, false, this.mmname + "," + control.Name, false);
				A_1.Cancel = controlEventArgs.Cancel;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06003F52 RID: 16210 RVA: 0x001D0832 File Offset: 0x001CEA32
		// (set) Token: 0x06003F53 RID: 16211 RVA: 0x001D083A File Offset: 0x001CEA3A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MenuTheme
		{
			get
			{
				return this.OoO._O_Oo00__.;
			}
			set
			{
				this.OoO._O_Oo00__. = value;
			}
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x001D0843 File Offset: 0x001CEA43
		[CompilerGenerated]
		private void <<EMPTY_NAME>>()
		{
			if (OO_00oOO.BaseMainForm != null)
			{
				OO_00oOO.BaseMainForm.Invoke(new $UNNAMED_TYPE$(this.O.00oo_OO0O.));
			}
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x001D0863 File Offset: 0x001CEA63
		[CompilerGenerated]
		private void <<EMPTY_NAME>>()
		{
			this.Close();
		}

		// Token: 0x040019A5 RID: 6565
		internal DataRow <<EMPTY_NAME>>;

		// Token: 0x040019A6 RID: 6566
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040019A7 RID: 6567
		[CompilerGenerated]
		[AccessedThroughProperty("Pane")]
		private FormPanel <<EMPTY_NAME>>;

		// Token: 0x040019A8 RID: 6568
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019A9 RID: 6569
		private FormStyleEnum <<EMPTY_NAME>>;

		// Token: 0x040019AA RID: 6570
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019AB RID: 6571
		private string <<EMPTY_NAME>>;

		// Token: 0x040019AC RID: 6572
		private FormStartPosition <<EMPTY_NAME>>;

		// Token: 0x040019AD RID: 6573
		private int <<EMPTY_NAME>>;

		// Token: 0x040019AE RID: 6574
		private int <<EMPTY_NAME>>;

		// Token: 0x040019AF RID: 6575
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019B0 RID: 6576
		private DockAreaEnum <<EMPTY_NAME>>;

		// Token: 0x040019B1 RID: 6577
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019B2 RID: 6578
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019B3 RID: 6579
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019B4 RID: 6580
		private string <<EMPTY_NAME>>;

		// Token: 0x040019B5 RID: 6581
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019B6 RID: 6582
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019B7 RID: 6583
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019B8 RID: 6584
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019B9 RID: 6585
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019BA RID: 6586
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019BB RID: 6587
		private static ScriptControl <<EMPTY_NAME>>;

		// Token: 0x040019BC RID: 6588
		[AccessedThroughProperty("Timer")]
		[CompilerGenerated]
		private Timer <<EMPTY_NAME>>;

		// Token: 0x040019BD RID: 6589
		private int <<EMPTY_NAME>>;

		// Token: 0x040019BE RID: 6590
		private string <<EMPTY_NAME>>;

		// Token: 0x040019BF RID: 6591
		private PrintPageProperty <<EMPTY_NAME>>;

		// Token: 0x040019C0 RID: 6592
		private ControlCollection <<EMPTY_NAME>>;

		// Token: 0x040019C1 RID: 6593
		private string <<EMPTY_NAME>>;

		// Token: 0x040019C2 RID: 6594
		private int <<EMPTY_NAME>>;

		// Token: 0x040019C3 RID: 6595
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019C4 RID: 6596
		internal string <<EMPTY_NAME>>;

		// Token: 0x040019C5 RID: 6597
		internal Dictionary<Control, string> <<EMPTY_NAME>>;

		// Token: 0x040019C6 RID: 6598
		internal C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x040019C7 RID: 6599
		private TabAlignment <<EMPTY_NAME>>;

		// Token: 0x040019C8 RID: 6600
		internal Assembly <<EMPTY_NAME>>;

		// Token: 0x040019C9 RID: 6601
		internal Dictionary<string, ToolStrip> <<EMPTY_NAME>>;

		// Token: 0x040019CA RID: 6602
		internal StripCollection <<EMPTY_NAME>>;

		// Token: 0x040019CB RID: 6603
		internal Control <<EMPTY_NAME>>;

		// Token: 0x040019CC RID: 6604
		internal string <<EMPTY_NAME>>;

		// Token: 0x040019CD RID: 6605
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040019CE RID: 6606
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040019CF RID: 6607
		[CompilerGenerated]
		[AccessedThroughProperty("sizer")]
		private C1SizerLight <<EMPTY_NAME>>;

		// Token: 0x040019D0 RID: 6608
		private string <<EMPTY_NAME>>;

		// Token: 0x040019D1 RID: 6609
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019D2 RID: 6610
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019D3 RID: 6611
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019D4 RID: 6612
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040019D5 RID: 6613
		private string <<EMPTY_NAME>>;

		// Token: 0x02000521 RID: 1313
		[CompilerGenerated]
		internal sealed class O_oO_00_O
		{
			// Token: 0x060057FA RID: 22522 RVA: 0x0025D5E0 File Offset: 0x0025B7E0
			internal void <<EMPTY_NAME>>()
			{
				if (OO_00oOO.BaseMainForm != null)
				{
					OO_00oOO.BaseMainForm.Invoke((this.O_.__ooooo. == null) ? (this.O_.__ooooo. = new $UNNAMED_TYPE$(this.o__.00OO0_O_o0.)) : this.O_.__ooooo.);
				}
			}

			// Token: 0x060057FB RID: 22523 RVA: 0x0025D624 File Offset: 0x0025B824
			internal void <<EMPTY_NAME>>()
			{
				if (this.O_.__ooooo..Length == 0)
				{
					this.O_.__ooooo..Open(int.MaxValue, int.MaxValue);
					return;
				}
				if (this.O_.__ooooo..Length == 2)
				{
					int x = Conversions.ToInteger(this.O_.__ooooo.[0]);
					int y = Conversions.ToInteger(this.O_.__ooooo.[1]);
					this.O_.__ooooo..Open(x, y);
				}
			}

			// Token: 0x040022DE RID: 8926
			public object[] <<EMPTY_NAME>>;

			// Token: 0x040022DF RID: 8927
			public Form <<EMPTY_NAME>>;

			// Token: 0x040022E0 RID: 8928
			public $UNNAMED_TYPE$ <<EMPTY_NAME>>;
		}

		// Token: 0x02000524 RID: 1316
		[CompilerGenerated]
		internal sealed class OO00o__o
		{
			// Token: 0x06005801 RID: 22529 RVA: 0x0025D868 File Offset: 0x0025BA68
			internal void <<EMPTY_NAME>>()
			{
				if (OO_00oOO.BaseMainForm != null)
				{
					OO_00oOO.BaseMainForm.Invoke((this.OOO._0o0_0. == null) ? (this.OOO._0o0_0. = new $UNNAMED_TYPE$(this.oOOo.o00oOOo.)) : this.OOO._0o0_0.);
				}
			}

			// Token: 0x06005802 RID: 22530 RVA: 0x0025D8AC File Offset: 0x0025BAAC
			internal void <<EMPTY_NAME>>()
			{
				Point location = this.OOO._0o0_0..BaseForm.Location;
				this.OOO._0o0_0..BaseForm.Location = new Point(location.X + this.OOO._0o0_0., location.Y + this.oOOo.o00oOOo.);
			}

			// Token: 0x040022EA RID: 8938
			public int <<EMPTY_NAME>>;

			// Token: 0x040022EB RID: 8939
			public int <<EMPTY_NAME>>;

			// Token: 0x040022EC RID: 8940
			public Form <<EMPTY_NAME>>;

			// Token: 0x040022ED RID: 8941
			public $UNNAMED_TYPE$ <<EMPTY_NAME>>;
		}

		// Token: 0x02000526 RID: 1318
		[CompilerGenerated]
		internal sealed class o0__
		{
			// Token: 0x06005806 RID: 22534 RVA: 0x0025DA08 File Offset: 0x0025BC08
			internal void <<EMPTY_NAME>>()
			{
				if (OO_00oOO.BaseMainForm != null)
				{
					OO_00oOO.BaseMainForm.Invoke((this.OOO._0o0_0. == null) ? (this.OOO._0o0_0. = new $UNNAMED_TYPE$(this.oOOo.o00oOOo.)) : this.OOO._0o0_0.);
				}
			}

			// Token: 0x06005807 RID: 22535 RVA: 0x0025DA4C File Offset: 0x0025BC4C
			internal void <<EMPTY_NAME>>()
			{
				if (this.OOO._0o0_0..Length == 0)
				{
					this.o.0_O_..Show(int.MaxValue, int.MaxValue);
					return;
				}
				if (this.OOO._0o0_0..Length == 2)
				{
					int x = Conversions.ToInteger(this.OOO._0o0_0.[0]);
					int y = Conversions.ToInteger(this.OOO._0o0_0.[1]);
					this.o.0_O_..Show(x, y);
				}
			}

			// Token: 0x040022F4 RID: 8948
			public object[] <<EMPTY_NAME>>;

			// Token: 0x040022F5 RID: 8949
			public Form <<EMPTY_NAME>>;

			// Token: 0x040022F6 RID: 8950
			public $UNNAMED_TYPE$ <<EMPTY_NAME>>;
		}

		// Token: 0x02000528 RID: 1320
		[CompilerGenerated]
		internal sealed class oo0o_oo
		{
			// Token: 0x0600580B RID: 22539 RVA: 0x0025DBB0 File Offset: 0x0025BDB0
			internal void <<EMPTY_NAME>>(object A_0, object A_1)
			{
				if ((DateTime.Now - this.O_o_.0o0__o0O.).TotalSeconds >= 1.0)
				{
					this.O_o_.0o0__o0O. = DateTime.Now;
					this.O_.__ooooo..O_.__ooooo. = "DownloadProgressChanged_" + Conversions.ToString(this.O_.__ooooo..O_.__ooooo..Tag);
					DownloadStateChangedEventArgs downloadStateChangedEventArgs = new DownloadStateChangedEventArgs(this.O_.__ooooo..O_.__ooooo., this.O_.__ooooo..O_.__ooooo., this.O_.__ooooo..O_.__ooooo.);
					O_O0OO.OoO_o.oO0o0O.(this.O_.__ooooo..O_.__ooooo..O_0.O00o_00_O., this.O_.__ooooo..O_.__ooooo., new object[]
					{
						downloadStateChangedEventArgs
					}, false, this.O_.__ooooo..O_.__ooooo..mmname + "," + this.O_.__ooooo..O_.__ooooo..Name, false);
				}
			}

			// Token: 0x0600580C RID: 22540 RVA: 0x0025DC98 File Offset: 0x0025BE98
			internal void <<EMPTY_NAME>>(object A_0, object A_1)
			{
				if (this.O_.__ooooo..O_.__ooooo..State == CoreWebView2DownloadState.Completed || (this.O_.__ooooo..O_.__ooooo..State == CoreWebView2DownloadState.Interrupted && !this.O_.__ooooo..O_.__ooooo..CanResume))
				{
					EventHandler<object> eventHandler = null;
					if (this.O_.__ooooo..O_.__ooooo..OoO.oOOoo..TryRemove(this.O_.__ooooo..O_.__ooooo., out eventHandler))
					{
						this.O_.__ooooo..O_.__ooooo..BytesReceivedChanged -= this.O_o_.0o0__o0O.;
					}
					if (this.O_.__ooooo..O_.__ooooo..oo_.0oOOOoooo..TryRemove(this.O_.__ooooo..O_.__ooooo., out eventHandler))
					{
						this.O_.__ooooo..O_.__ooooo..StateChanged -= this.oOO_0_oo.Oo0.;
					}
					if (this.O_.__ooooo..O_.__ooooo..oo_.0oOOOoooo..ContainsKey(this.O_.__ooooo..O_.__ooooo.))
					{
						this.O_.__ooooo..O_.__ooooo..oo_.0oOOOoooo.[this.O_.__ooooo..O_.__ooooo.].SetResult(0);
						TaskCompletionSource<int> taskCompletionSource = null;
						this.O_.__ooooo..O_.__ooooo..oo_.0oOOOoooo..TryRemove(this.O_.__ooooo..O_.__ooooo., out taskCompletionSource);
					}
				}
				this.O_.__ooooo..O_.__ooooo. = "DownloadStateChanged_" + Conversions.ToString(this.O_.__ooooo..O_.__ooooo..Tag);
				DownloadStateChangedEventArgs downloadStateChangedEventArgs = new DownloadStateChangedEventArgs(this.O_.__ooooo..O_.__ooooo., this.O_.__ooooo..O_.__ooooo., this.O_.__ooooo..O_.__ooooo.);
				O_O0OO.OoO_o.oO0o0O.(this.O_.__ooooo..O_.__ooooo..O_0.O00o_00_O., this.O_.__ooooo..O_.__ooooo., new object[]
				{
					downloadStateChangedEventArgs
				}, false, this.O_.__ooooo..O_.__ooooo..mmname + "," + this.O_.__ooooo..O_.__ooooo..Name, false);
			}

			// Token: 0x040022FC RID: 8956
			public DateTime <<EMPTY_NAME>>;

			// Token: 0x040022FD RID: 8957
			public EventHandler<object> <<EMPTY_NAME>>;

			// Token: 0x040022FE RID: 8958
			public EventHandler<object> <<EMPTY_NAME>>;

			// Token: 0x040022FF RID: 8959
			public Form.ooOOO_oOOo <<EMPTY_NAME>>;
		}

		// Token: 0x02000529 RID: 1321
		[CompilerGenerated]
		internal sealed class ooOOO_oOOo
		{
			// Token: 0x04002300 RID: 8960
			public string <<EMPTY_NAME>>;

			// Token: 0x04002301 RID: 8961
			public WebViewer <<EMPTY_NAME>>;

			// Token: 0x04002302 RID: 8962
			public CoreWebView2DownloadOperation <<EMPTY_NAME>>;

			// Token: 0x04002303 RID: 8963
			public Form <<EMPTY_NAME>>;
		}
	}
}
