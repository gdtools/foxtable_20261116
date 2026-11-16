using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.RibbonMenu;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices;

namespace Foxtable
{
	// Token: 0x020001E1 RID: 481
	[ComVisible(true)]
	public class DataToTable
	{
		// Token: 0x0600172F RID: 5935 RVA: 0x000A9670 File Offset: 0x000A7870
		public DataToTable(WebViewer A_0)
		{
			this.O.0_o0. = new List<Assembly>();
			this.Oo_00_oO.00O0O. = new List<string>();
			this.Oo_00_oO.00O0O. = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);
			this.AccessData = true;
			this.O.0_o0..Add(Assembly.GetExecutingAssembly());
			this.Oo_00_oO.00O0O..Add("Foxtable");
			this.O.0_o0..Add(typeof(DateGroupEnum).Assembly);
			this.Oo_00_oO.00O0O..Add("Foxtable");
			this.Oo_00_oO.00O0O. = A_0;
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x000A9701 File Offset: 0x000A7901
		public void Add(Assembly assembly, string SpaceName)
		{
			this.O.0_o0..Add(assembly);
			this.Oo_00_oO.00O0O..Add(SpaceName);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x000A971C File Offset: 0x000A791C
		private Type <<EMPTY_NAME>>(string A_0)
		{
			Type result;
			if (this.Oo_00_oO.00O0O..ContainsKey(A_0))
			{
				result = this.Oo_00_oO.00O0O.[A_0];
			}
			else
			{
				Type type = null;
				string left = A_0.ToLower();
				if (Operators.CompareString(left, "color", true) == 0)
				{
					type = typeof(Color);
				}
				else if (Operators.CompareString(left, "dialogresult", true) == 0)
				{
					type = typeof(DialogResult);
				}
				else if (Operators.CompareString(left, "messageboxbuttons", true) == 0)
				{
					type = typeof(MessageBoxButtons);
				}
				else if (Operators.CompareString(left, "messageboxicon", true) == 0)
				{
					type = typeof(MessageBoxIcon);
				}
				else if (Operators.CompareString(left, "messageboxdefaultbutton", true) == 0)
				{
					type = typeof(MessageBoxDefaultButton);
				}
				else if (Operators.CompareString(left, "FontStyle", true) == 0)
				{
					type = typeof(FontStyle);
				}
				else if (Operators.CompareString(left, "AudioPlayMode", true) == 0)
				{
					type = typeof(AudioPlayMode);
				}
				else
				{
					if (Operators.CompareString(left, "viewmode", true) == 0)
					{
						return typeof(View);
					}
					if (Operators.CompareString(left, "textimagerelation", true) == 0)
					{
						return typeof(TextImageRelation);
					}
					if (Operators.CompareString(left, "flatstyle", true) == 0)
					{
						return typeof(FlatStyle);
					}
					if (Operators.CompareString(left, "horizontalalignment", true) == 0)
					{
						return typeof(HorizontalAlignment);
					}
					if (Operators.CompareString(left, "appearance", true) == 0)
					{
						return typeof(Appearance);
					}
					if (Operators.CompareString(left, "borderstyle", true) == 0)
					{
						return typeof(BorderStyle);
					}
					if (Operators.CompareString(left, "mousebuttons", true) == 0)
					{
						return typeof(MouseButtons);
					}
					if (Operators.CompareString(left, "imagelayout", true) == 0)
					{
						return typeof(ImageLayout);
					}
					if (Operators.CompareString(left, "ivisualstyle", true) == 0)
					{
						return typeof(VisualStyle);
					}
					if (Operators.CompareString(left, "keys", true) == 0)
					{
						return typeof(Keys);
					}
					if (Operators.CompareString(left, "textdataformat", true) == 0)
					{
						return typeof(TextDataFormat);
					}
					int num = this.O.0_o0..Count - 1;
					for (int i = 0; i <= num; i++)
					{
						type = this.O.0_o0.[i].GetType(this.Oo_00_oO.00O0O.[i] + "." + A_0, false, true);
						if (type != null)
						{
							break;
						}
					}
				}
				if (type != null)
				{
					this.Oo_00_oO.00O0O..Add(A_0, type);
					result = type;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x17000499 RID: 1177
		public object this[string A_0]
		{
			get
			{
				Type type = this.O_oooooO.0.(A_0);
				object result;
				if (type != null)
				{
					result = new DyncMemberAccessor(type);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x000A99F4 File Offset: 0x000A7BF4
		public IEnumerator GetEnumerator()
		{
			return Enumerable.Empty<object>().GetEnumerator();
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x000A9A00 File Offset: 0x000A7C00
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x000A9A08 File Offset: 0x000A7C08
		public bool AccessData { get; set; }

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x000A9A14 File Offset: 0x000A7C14
		public DataTableCollection DataTables
		{
			get
			{
				DataTableCollection result;
				if (this.AccessData)
				{
					result = OO_00oOO.DataTables;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x000A9A34 File Offset: 0x000A7C34
		public TableCollection Tables
		{
			get
			{
				TableCollection result;
				if (this.AccessData)
				{
					result = OO_00oOO.Tables;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x000A9A54 File Offset: 0x000A7C54
		public Randjs Rand
		{
			get
			{
				if (this.O.0_o0. == null)
				{
					this.O.0_o0. = new Randjs();
				}
				return this.O.0_o0.;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x000A9A6F File Offset: 0x000A7C6F
		public PYJS PY
		{
			get
			{
				if (this.O.0_o0. == null)
				{
					this.O.0_o0. = new PYJS();
				}
				return this.O.0_o0.;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x000A9A8A File Offset: 0x000A7C8A
		public MRPTableCols MRP
		{
			get
			{
				return OO_00oOO.MRP;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x000A9A91 File Offset: 0x000A7C91
		public MRPTableCols MRPCols
		{
			get
			{
				return OO_00oOO.MRPCols;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x000A9A98 File Offset: 0x000A7C98
		public List<object> OpenFileArgs
		{
			get
			{
				return OO_00oOO.OpenFileArgs;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x000A9A9F File Offset: 0x000A7C9F
		public FormCollection Forms
		{
			get
			{
				return OO_00oOO.Forms;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x000A9AA6 File Offset: 0x000A7CA6
		public ReportCollection Reports
		{
			get
			{
				return OO_00oOO.Reports;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x000A9AAD File Offset: 0x000A7CAD
		public UserFunctions Functions
		{
			get
			{
				return OO_00oOO.Functions;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x000A9AB4 File Offset: 0x000A7CB4
		public HardWare HardWareInfo
		{
			get
			{
				return OO_00oOO.HardWareInfo;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x000A9ABB File Offset: 0x000A7CBB
		// (set) Token: 0x06001742 RID: 5954 RVA: 0x000A9AC2 File Offset: 0x000A7CC2
		public string ProjectFile
		{
			get
			{
				return OO_00oOO.ProjectFile;
			}
			set
			{
				OO_00oOO.ProjectFile = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x000A9ACA File Offset: 0x000A7CCA
		public string ApplicationPath
		{
			get
			{
				return OO_00oOO.ApplicationPath;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x000A9AD1 File Offset: 0x000A7CD1
		public string ProjectPath
		{
			get
			{
				return OO_00oOO.ProjectPath;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x000A9AD8 File Offset: 0x000A7CD8
		public string AttachPath
		{
			get
			{
				return OO_00oOO.AttachPath;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x000A9AE0 File Offset: 0x000A7CE0
		public Table CurrentTable
		{
			get
			{
				Table result;
				if (this.AccessData)
				{
					result = OO_00oOO.CurrentTable;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x000A9B00 File Offset: 0x000A7D00
		// (set) Token: 0x06001748 RID: 5960 RVA: 0x000A9B20 File Offset: 0x000A7D20
		public Table MainTable
		{
			get
			{
				Table result;
				if (this.AccessData)
				{
					result = OO_00oOO.MainTable;
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				OO_00oOO.MainTable = value;
			}
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000A9B28 File Offset: 0x000A7D28
		public void RaiseSystemEvent(Table Table, params SystemEventTypeEnum[] EventType)
		{
			OO_00oOO.RaiseSystemEvent(Table, EventType);
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x000A9B31 File Offset: 0x000A7D31
		public DataRelationCollection Relations
		{
			get
			{
				return OO_00oOO.Relations;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x000A9B38 File Offset: 0x000A7D38
		public ConnectionCollection Connections
		{
			get
			{
				return OO_00oOO.Connections;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x000A9B3F File Offset: 0x000A7D3F
		public FileSystemWatcher FileWatcher
		{
			get
			{
				return OO_00oOO.FileWatcher;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x000A9B46 File Offset: 0x000A7D46
		public MyPortCollections Ports
		{
			get
			{
				return OO_00oOO.Ports;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x000A9B4D File Offset: 0x000A7D4D
		public ContextMenuCollection ContextMenus
		{
			get
			{
				return OO_00oOO.ContextMenus;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x000A9B54 File Offset: 0x000A7D54
		public RibbonTabCollection RibbonTabs
		{
			get
			{
				return OO_00oOO.RibbonTabs;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x000A9B5B File Offset: 0x000A7D5B
		public RibbonTabGroupCollection RibbonTabGroups
		{
			get
			{
				return OO_00oOO.RibbonTabGroups;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x000A9B62 File Offset: 0x000A7D62
		public ApplicationMenu ApplicationMenu
		{
			get
			{
				return OO_00oOO.ApplicationMenu;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x000A9B69 File Offset: 0x000A7D69
		public Qat QAT
		{
			get
			{
				return OO_00oOO.QAT;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x000A9B70 File Offset: 0x000A7D70
		public ConfigBar ConfigBar
		{
			get
			{
				return OO_00oOO.ConfigBar;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x000A9B77 File Offset: 0x000A7D77
		public TopToolBar TopToolBar
		{
			get
			{
				return OO_00oOO.TopToolBar;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x000A9B7E File Offset: 0x000A7D7E
		public BottomToolBar BottomToolBar
		{
			get
			{
				return OO_00oOO.BottomToolBar;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x000A9B85 File Offset: 0x000A7D85
		public UserInfo User
		{
			get
			{
				return OO_00oOO.User;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x000A9B8C File Offset: 0x000A7D8C
		public Keys ModifierKey
		{
			get
			{
				return OO_00oOO.ModifierKey;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x000A9B93 File Offset: 0x000A7D93
		public MouseButtons MouseButton
		{
			get
			{
				return OO_00oOO.MouseButton;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x000A9B9A File Offset: 0x000A7D9A
		public TimerCollection MyTimers
		{
			get
			{
				return OO_00oOO.MyTimers;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x000A9BA1 File Offset: 0x000A7DA1
		public VarsCollection Vars
		{
			get
			{
				return OO_00oOO.Vars;
			}
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000A9BA8 File Offset: 0x000A7DA8
		public Image GetImage(string ImageFile)
		{
			return OO_00oOO.GetImage(ImageFile);
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x000A9BB0 File Offset: 0x000A7DB0
		public DataView BindTables
		{
			get
			{
				return OO_00oOO.O___OOOoo.o.(A_0);
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x000A9BB8 File Offset: 0x000A7DB8
		public AudioJs Audio
		{
			get
			{
				if (this.O.0_o0. == null)
				{
					this.O.0_o0. = new AudioJs();
				}
				return this.O.0_o0.;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x000A9BD3 File Offset: 0x000A7DD3
		public FileSystemProxy FileSys
		{
			get
			{
				return OO_00oOO.FileSys;
			}
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x000A9BDA File Offset: 0x000A7DDA
		public double InTax(double x)
		{
			return OO_00oOO.InTax(x);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000A9BE2 File Offset: 0x000A7DE2
		public object Eval(string Expr, Row Row)
		{
			return OO_00oOO.Eval(Expr, Row);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x000A9BEB File Offset: 0x000A7DEB
		public object Eval(string Expr, DataRow DataRow)
		{
			return OO_00oOO.Eval(Expr, DataRow);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x000A9BF4 File Offset: 0x000A7DF4
		public object Eval(string Expr)
		{
			return OO_00oOO.Eval(Expr);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x000A9BFC File Offset: 0x000A7DFC
		public object Eval2(string Expr, Row Row)
		{
			return OO_00oOO.Eval2(Expr, Row);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x000A9C05 File Offset: 0x000A7E05
		public object Eval2(string Expr, DataRow DataRow)
		{
			return OO_00oOO.Eval2(Expr, DataRow);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000A9C0E File Offset: 0x000A7E0E
		public object Eval2(string Expr)
		{
			return OO_00oOO.Eval2(Expr);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000A9C16 File Offset: 0x000A7E16
		public object TryEval(string Expr, Row Row)
		{
			return OO_00oOO.TryEval(Expr, Row);
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000A9C1F File Offset: 0x000A7E1F
		public object TryEval(string Expr, DataRow DataRow)
		{
			return OO_00oOO.TryEval(Expr, DataRow);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000A9C28 File Offset: 0x000A7E28
		public object TryEval(string Expr)
		{
			return OO_00oOO.TryEval(Expr);
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x000A9C30 File Offset: 0x000A7E30
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x000A9C37 File Offset: 0x000A7E37
		public VisualStyleEnum VisualStyle
		{
			get
			{
				return OO_00oOO.VisualStyle;
			}
			set
			{
				OO_00oOO.VisualStyle = value;
			}
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x000A9C3F File Offset: 0x000A7E3F
		public void ShowHelpWindow()
		{
			OO_00oOO.ShowHelpWindow();
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x000A9C46 File Offset: 0x000A7E46
		public void ShowHelpWindow(string Topic)
		{
			OO_00oOO.ShowHelpWindow(Topic);
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x000A9C4E File Offset: 0x000A7E4E
		public void ShowHelpWindow2()
		{
			OO_00oOO.ShowHelpWindow2();
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000A9C55 File Offset: 0x000A7E55
		public object ExecuteCode(string Code, bool ReturnValue)
		{
			return OO_00oOO.ExecuteCode(Code, ReturnValue);
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x000A9C5E File Offset: 0x000A7E5E
		public void AddConnection(string ConnName, string ConnString)
		{
			OO_00oOO.AddConnection(ConnName, ConnString);
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x000A9C67 File Offset: 0x000A7E67
		public void DeleteConnection(string ConnName)
		{
			OO_00oOO.DeleteConnection(ConnName);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x000A9C6F File Offset: 0x000A7E6F
		public bool ContainsConnection(string Connname)
		{
			return OO_00oOO.ContainsConnection(Connname);
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x000A9C77 File Offset: 0x000A7E77
		public string ApplicationVertion()
		{
			return OO_00oOO.ApplicationVertion();
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x000A9C7E File Offset: 0x000A7E7E
		// (set) Token: 0x06001774 RID: 6004 RVA: 0x000A9C85 File Offset: 0x000A7E85
		public string ApplicationTitle
		{
			get
			{
				return OO_00oOO.ApplicationTitle;
			}
			set
			{
				OO_00oOO.ApplicationTitle = value;
			}
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x000A9C8D File Offset: 0x000A7E8D
		public DateTime PublishDate()
		{
			return OO_00oOO.PublishDate();
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x000A9C94 File Offset: 0x000A7E94
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x000A9C9B File Offset: 0x000A7E9B
		public string UpdatePath
		{
			get
			{
				return OO_00oOO.UpdatePath;
			}
			set
			{
				OO_00oOO.UpdatePath = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x000A9CA3 File Offset: 0x000A7EA3
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x000A9CAA File Offset: 0x000A7EAA
		public bool RemoteUpdate
		{
			get
			{
				return OO_00oOO.RemoteUpdate;
			}
			set
			{
				OO_00oOO.RemoteUpdate = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x000A9CB2 File Offset: 0x000A7EB2
		public string ComputerId
		{
			get
			{
				return o_o_O0OO_0__.oo00_.0oO_.();
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x000A9CB9 File Offset: 0x000A7EB9
		public List<string> InstalledPrinters
		{
			get
			{
				return OO_00oOO.InstalledPrinters;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x000A9CC0 File Offset: 0x000A7EC0
		public string DefaultPrinter
		{
			get
			{
				return OO_00oOO.DefaultPrinter;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x000A9CC7 File Offset: 0x000A7EC7
		public List<string> GetPaperSources
		{
			get
			{
				return OO_00oOO.oooo_0_OO0o._0.(A_0);
			}
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x000A9CCF File Offset: 0x000A7ECF
		public void CloseSplashForm()
		{
			OO_00oOO.CloseSplashForm();
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x000A9CD6 File Offset: 0x000A7ED6
		// (set) Token: 0x06001780 RID: 6016 RVA: 0x000A9CDD File Offset: 0x000A7EDD
		public bool MarkModifedCell
		{
			get
			{
				return OO_00oOO.MarkModifedCell;
			}
			set
			{
				OO_00oOO.MarkModifedCell = value;
			}
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x000A9CE5 File Offset: 0x000A7EE5
		public string EditConnectionString(string ConnectionString = "")
		{
			return OO_00oOO.EditConnectionString(ConnectionString);
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x000A9CED File Offset: 0x000A7EED
		public List<string> GetTableNamesFromConnection(string ConnectionName)
		{
			return OO_00oOO.GetTableNamesFromConnection(ConnectionName);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x000A9CF5 File Offset: 0x000A7EF5
		public double Round2(double x, int y)
		{
			return OO_00oOO.Round2(x, y);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x000A9CFE File Offset: 0x000A7EFE
		public string HardDiskId()
		{
			return OO_00oOO.HardDiskId();
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x000A9D05 File Offset: 0x000A7F05
		public string IssueName()
		{
			return OO_00oOO.IssueName();
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x000A9D0C File Offset: 0x000A7F0C
		public void ExportStructure()
		{
			OO_00oOO.ExportStructure();
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x000A9D13 File Offset: 0x000A7F13
		public void ExportEventCode(OO_00oOO.OoOO tpe = OO_00oOO.OoOO.O_Oo_0.0., string nm = "")
		{
			OO_00oOO.oo0oOO.o.(tpe, nm);
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x000A9D1C File Offset: 0x000A7F1C
		public RegistryProxy Registry
		{
			get
			{
				return OO_00oOO.Registry;
			}
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x000A9D24 File Offset: 0x000A7F24
		public string InputPassword(ref string passWord, string Text, string Description)
		{
			string result;
			if (OO_00oOO.InputPassword(ref passWord, Text, Description))
			{
				result = passWord;
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x000A9D48 File Offset: 0x000A7F48
		public string InputValue(params object[] args)
		{
			if (args.Length >= 3)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(args[0]);
				string text = args[1].ToString();
				string description = args[2].ToString();
				if (args.Length == 3)
				{
					if (OO_00oOO.InputValue(ref objectValue, text, description))
					{
						return objectValue.ToString();
					}
					return null;
				}
				else if (args.Length >= 4)
				{
					if (args[3] is bool)
					{
						if (OO_00oOO.InputValue(ref objectValue, text, description, Conversions.ToBoolean(args[3])))
						{
							return objectValue.ToString();
						}
						return null;
					}
					else if (args[3] is string)
					{
						if (args.Length == 4)
						{
							if (OO_00oOO.InputValue(ref objectValue, text, description, args[3].ToString()))
							{
								return objectValue.ToString();
							}
							return null;
						}
						else if (args.Length >= 5 && args[4] is bool)
						{
							bool multiSelect = Conversions.ToBoolean(args[4]);
							if (OO_00oOO.InputValue(ref objectValue, text, description, args[3].ToString(), multiSelect))
							{
								return objectValue.ToString();
							}
							return null;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x000A9E3F File Offset: 0x000A803F
		public bool FileIsOpened(string FName)
		{
			return OO_00oOO.FileIsOpened(FName);
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x000A9E47 File Offset: 0x000A8047
		public Form BaseMainForm
		{
			get
			{
				return OO_00oOO.BaseMainForm;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x000A9E4E File Offset: 0x000A804E
		// (set) Token: 0x0600178E RID: 6030 RVA: 0x000A9E55 File Offset: 0x000A8055
		public bool TableCaptionVisible
		{
			get
			{
				return OO_00oOO.TableCaptionVisible;
			}
			set
			{
				OO_00oOO.TableCaptionVisible = value;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x000A9E5D File Offset: 0x000A805D
		// (set) Token: 0x06001790 RID: 6032 RVA: 0x000A9E64 File Offset: 0x000A8064
		public bool ShowCloseButton
		{
			get
			{
				return OO_00oOO.ShowCloseButton;
			}
			set
			{
				OO_00oOO.ShowCloseButton = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x000A9E6C File Offset: 0x000A806C
		public long LastInputTickCount
		{
			get
			{
				return OO_00oOO.LastInputTickCount;
			}
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x000A9E73 File Offset: 0x000A8073
		public void CreateBlankAccessFile()
		{
			OO_00oOO.CreateBlankAccessFile();
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x000A9E7A File Offset: 0x000A807A
		public UserInfos Users
		{
			get
			{
				return OO_00oOO.Users;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x000A9E81 File Offset: 0x000A8081
		public FoxSMSControl FoxSMS
		{
			get
			{
				return OO_00oOO.FoxSMS;
			}
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x000A9E88 File Offset: 0x000A8088
		public bool CompactAccessFile(string FileName, string PassWord = "", bool backup = true)
		{
			return OO_00oOO.CompactAccessFile(FileName, PassWord, backup);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x000A9E92 File Offset: 0x000A8092
		public bool CompactToAccess(string FileName, string Password)
		{
			return OO_00oOO.CompactToAccess(FileName, Password);
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x000A9E9B File Offset: 0x000A809B
		public bool TryConnectHost(string address)
		{
			return OO_00oOO.TryConnectHost(address);
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x000A9EA3 File Offset: 0x000A80A3
		public int FindAppWindow(string Caption)
		{
			return OO_00oOO.FindAppWindow(Caption);
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x000A9EAB File Offset: 0x000A80AB
		public bool ShowAppWindow(string Caption, int State)
		{
			return OO_00oOO.ShowAppWindow(Caption, State);
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x000A9EB4 File Offset: 0x000A80B4
		public void LockBaseMainForm()
		{
			OO_00oOO.LockBaseMainForm();
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x000A9EBB File Offset: 0x000A80BB
		public void UnlockBaseMainForm()
		{
			OO_00oOO.UnlockBaseMainForm();
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x000A9EC2 File Offset: 0x000A80C2
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x000A9EC9 File Offset: 0x000A80C9
		public bool SystemMenu
		{
			get
			{
				return OO_00oOO.SystemMenu;
			}
			set
			{
				OO_00oOO.SystemMenu = value;
			}
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x000A9ED1 File Offset: 0x000A80D1
		public string CExp(string expr, params string[] values)
		{
			return OO_00oOO.CExp(expr, values);
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x000A9EDA File Offset: 0x000A80DA
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x000A9EE1 File Offset: 0x000A80E1
		public bool SystemReady
		{
			get
			{
				return OO_00oOO.SystemReady;
			}
			set
			{
				OO_00oOO.SystemReady = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x000A9EE9 File Offset: 0x000A80E9
		public IMServerCollections IMServers
		{
			get
			{
				return OO_00oOO.IMServers;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x000A9EF0 File Offset: 0x000A80F0
		public IMClientCollections IMClients
		{
			get
			{
				return OO_00oOO.IMClients;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x000A9EF7 File Offset: 0x000A80F7
		public IMServerCollections QQServers
		{
			get
			{
				return OO_00oOO.QQServers;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x000A9EFE File Offset: 0x000A80FE
		public IMClientCollections QQClients
		{
			get
			{
				return OO_00oOO.QQClients;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x000A9F05 File Offset: 0x000A8105
		public oO_OO_o0_ UDPClients
		{
			get
			{
				return OO_00oOO.UDPClients;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x000A9F0C File Offset: 0x000A810C
		public IMServer QQServer
		{
			get
			{
				return OO_00oOO.QQServer;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x000A9F13 File Offset: 0x000A8113
		public IMClient QQClient
		{
			get
			{
				return OO_00oOO.QQClient;
			}
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x000A9F1A File Offset: 0x000A811A
		public string GetPinYin(string hzStr, int mode = 0)
		{
			return OO_00oOO.GetPinYin(hzStr, mode);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x000A9F23 File Offset: 0x000A8123
		public DateTime ReadBirthDay(string PIN)
		{
			return ChinesFunctions.ReadBirthDay(PIN);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x000A9F2B File Offset: 0x000A812B
		public string ReadSex(string PIN)
		{
			return ChinesFunctions.ReadSex(PIN);
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x000A9F33 File Offset: 0x000A8133
		public bool ValidPIN(string PIN)
		{
			return ChinesFunctions.ValidPIN(PIN);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x000A9F3B File Offset: 0x000A813B
		public string CLDate(DateTime value)
		{
			return ChinesFunctions.CLDate(value);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x000A9F43 File Offset: 0x000A8143
		public string CUDate(DateTime Value)
		{
			return ChinesFunctions.CUDate(Value);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x000A9F4B File Offset: 0x000A814B
		public string CCDate(DateTime value)
		{
			return ChinesFunctions.CCDate(value);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x000A9F53 File Offset: 0x000A8153
		public string CUMoney(string Value)
		{
			return ChinesFunctions.CUMoney(Value);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x000A9F5B File Offset: 0x000A815B
		public string CUNumber(string value)
		{
			return ChinesFunctions.CUNumber(value);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x000A9F63 File Offset: 0x000A8163
		public string CUNUM(int value)
		{
			return ChinesFunctions.CUNUM(value);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x000A9F6B File Offset: 0x000A816B
		public string CLNUM(int value)
		{
			return ChinesFunctions.CLNUM(value);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x000A9F73 File Offset: 0x000A8173
		public string CCNumber(string Value)
		{
			return ChinesFunctions.CCNumber(Value);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x000A9F7B File Offset: 0x000A817B
		public string EUMoney(string Value)
		{
			return ChinesFunctions.EUMoney(Value);
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x000A9F83 File Offset: 0x000A8183
		public string EUNumber(string Value)
		{
			return ChinesFunctions.EUMoney(Value);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x000A9F8C File Offset: 0x000A818C
		public char GetDigit(params object[] args)
		{
			char digit;
			if (args.Length == 2)
			{
				digit = ChinesFunctions.GetDigit(Conversions.ToString(args[0]), Conversions.ToInteger(args[1]), '￥');
			}
			else if (args.Length == 3)
			{
				digit = ChinesFunctions.GetDigit(Conversions.ToString(args[0]), Conversions.ToInteger(args[1]), Conversions.ToChar(args[2]));
			}
			return digit;
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x000A9FE1 File Offset: 0x000A81E1
		public string StrToWide(string str)
		{
			return ChinesFunctions.StrToWide(str);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x000A9FE9 File Offset: 0x000A81E9
		public string StrToNarrow(string str)
		{
			return ChinesFunctions.StrToNarrow(str);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x000A9FF1 File Offset: 0x000A81F1
		public string StrToSimplified(string str)
		{
			return ChinesFunctions.StrToSimplified(str);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000A9FF9 File Offset: 0x000A81F9
		public string StrToTraditional(string str)
		{
			return ChinesFunctions.StrToTraditional(str);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x000AA001 File Offset: 0x000A8201
		public void DateYMD(DateTime dt1, DateTime dt2, ref int y, ref int m, ref int d)
		{
			ChinesFunctions.DateYMD(dt1, dt2, ref y, ref m, ref d);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x000AA00F File Offset: 0x000A820F
		public string DecToBin(long Dec)
		{
			return ChinesFunctions.DecToBin(Dec);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x000AA017 File Offset: 0x000A8217
		public string DecToHex(long Dec)
		{
			return ChinesFunctions.DecToHex(Dec);
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x000AA01F File Offset: 0x000A821F
		public string DecToOct(long Dec)
		{
			return ChinesFunctions.DecToOct(Dec);
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x000AA027 File Offset: 0x000A8227
		public long HexToDec(string value)
		{
			return ChinesFunctions.HexToDec(value);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000AA02F File Offset: 0x000A822F
		public long OctToDec(string value)
		{
			return ChinesFunctions.OctToDec(value);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x000AA037 File Offset: 0x000A8237
		public long BinToDec(string value)
		{
			return this.BinToDec(value);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x000AA040 File Offset: 0x000A8240
		public string EncryptText(string Text, string Key, string IV)
		{
			return O00.EncryptText(Text, Key, IV);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x000AA04A File Offset: 0x000A824A
		public string DecryptText(string Text, string Key, string IV)
		{
			return O00.DecryptText(Text, Key, IV);
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x000AA054 File Offset: 0x000A8254
		public string MD5Encrypt(string strToHash)
		{
			return O00.MD5Encrypt(strToHash);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x000AA05C File Offset: 0x000A825C
		public string CRCCheckFile(string FileName)
		{
			return O00.CRCCheckFile(FileName);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x000AA064 File Offset: 0x000A8264
		public string CRCCheckString(string strValue)
		{
			return O00.CRCCheckString(strValue);
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x000AA06C File Offset: 0x000A826C
		public bool EncryptFile(string InFile, string OutFile, string PassWord)
		{
			return O00.EncryptFile(InFile, OutFile, PassWord);
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x000AA076 File Offset: 0x000A8276
		public bool DecryptFile(string InFile, string OutFile, string PassWord)
		{
			return O00.DecryptFile(InFile, OutFile, PassWord);
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x000AA080 File Offset: 0x000A8280
		public HttpListenter HttpServer
		{
			get
			{
				return OO_00oOO.HttpServer;
			}
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x000AA087 File Offset: 0x000A8287
		public void PopMessage(string Message, string Caption = "提示", PopiconEnum Icon = PopiconEnum.Infomation, int Duration = -1)
		{
			OO_00oOO.PopMessage(Message, Caption, Icon, Duration);
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x000AA093 File Offset: 0x000A8293
		public string DongleID
		{
			get
			{
				return OO_00oOO.DongleID;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x000AA09A File Offset: 0x000A829A
		public string ProjectID
		{
			get
			{
				return OO_00oOO.ProjectID;
			}
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x000AA0A1 File Offset: 0x000A82A1
		public void Sleep(int msec)
		{
			OO_00oOO.Sleep(msec);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x000AA0A9 File Offset: 0x000A82A9
		public int OSVersion()
		{
			return OO_00oOO.OSVersion();
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x000AA0B0 File Offset: 0x000A82B0
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x000AA0B7 File Offset: 0x000A82B7
		public string ControlTheme
		{
			get
			{
				return OO_00oOO.ControlTheme;
			}
			set
			{
				OO_00oOO.ControlTheme = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x000AA0BF File Offset: 0x000A82BF
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x000AA0C6 File Offset: 0x000A82C6
		public string RibbonTheme
		{
			get
			{
				return OO_00oOO.RibbonTheme;
			}
			set
			{
				OO_00oOO.RibbonTheme = value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x000AA0CE File Offset: 0x000A82CE
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x000AA0D5 File Offset: 0x000A82D5
		public string GridTheme
		{
			get
			{
				return OO_00oOO.GridTheme;
			}
			set
			{
				OO_00oOO.GridTheme = value;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x000AA0DD File Offset: 0x000A82DD
		public List<string> Themes
		{
			get
			{
				return OO_00oOO.Themes;
			}
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x000AA0E4 File Offset: 0x000A82E4
		public bool isUserColdeRunning()
		{
			return OO_00oOO.isUserColdeRunning();
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x000AA0EC File Offset: 0x000A82EC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public GroupTableBuilder GroupTableBuilder(string TableName, params object[] args)
		{
			GroupTableBuilder result;
			try
			{
				int num = args.Length;
				if (num != 1)
				{
					if (num == 2)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(args[0]);
						object objectValue2 = RuntimeHelpers.GetObjectValue(args[1]);
						if (objectValue is DataTable && objectValue2 is string)
						{
							DataTable a_ = (DataTable)objectValue;
							string a_2 = Conversions.ToString(objectValue2);
							return new GroupTableBuilder(TableName, a_, a_2);
						}
						if (objectValue is string && objectValue2 is string)
						{
							string a_3 = Conversions.ToString(objectValue);
							string a_4 = Conversions.ToString(objectValue2);
							return new GroupTableBuilder(TableName, a_3, a_4);
						}
					}
				}
				else
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(args[0]);
					if (objectValue3 is DataTable)
					{
						DataTable a_5 = (DataTable)objectValue3;
						return new GroupTableBuilder(TableName, a_5);
					}
					if (objectValue3 is string)
					{
						string a_6 = Conversions.ToString(objectValue3);
						return new GroupTableBuilder(TableName, a_6);
					}
				}
				throw new Exception("传入的参数组合不匹配GroupTableBuilder的任何构造函数，请检查参数类型和个数！");
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(string.Format("创建GroupTableBuilder失败：{0}", ex.Message), MsgBoxStyle.OkOnly, null);
				result = null;
			}
			return result;
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x000AA20C File Offset: 0x000A840C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public CrossTableBuilder CrossTableBuilder(string TableName, params object[] args)
		{
			int num = args.Length;
			if (num != 1)
			{
				if (num == 2)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(args[0]);
					object objectValue2 = RuntimeHelpers.GetObjectValue(args[1]);
					if (objectValue is DataTable && objectValue2 is string)
					{
						DataTable a_ = (DataTable)objectValue;
						string a_2 = Conversions.ToString(objectValue2);
						return new CrossTableBuilder(TableName, a_, a_2);
					}
					if (objectValue is string && objectValue2 is string)
					{
						string a_3 = Conversions.ToString(objectValue);
						string a_4 = Conversions.ToString(objectValue2);
						return new CrossTableBuilder(TableName, a_3, a_4);
					}
				}
			}
			else
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(args[0]);
				if (objectValue3 is DataTable)
				{
					DataTable a_5 = (DataTable)objectValue3;
					return new CrossTableBuilder(TableName, a_5);
				}
				if (objectValue3 is string)
				{
					string a_6 = Conversions.ToString(objectValue3);
					return new CrossTableBuilder(TableName, a_6);
				}
			}
			return null;
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x000AA2E8 File Offset: 0x000A84E8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public SQLCrossTableBuilder SQLCrossTableBuilder(string TableName, params object[] args)
		{
			int num = args.Length;
			if (num != 1)
			{
				if (num == 2)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(args[0]);
					object objectValue2 = RuntimeHelpers.GetObjectValue(args[1]);
					if (objectValue is string && objectValue2 is string)
					{
						string a_ = Conversions.ToString(objectValue);
						string a_2 = Conversions.ToString(objectValue2);
						return new SQLCrossTableBuilder(TableName, a_, a_2);
					}
				}
			}
			else
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(args[0]);
				if (objectValue3 is string)
				{
					string a_3 = Conversions.ToString(objectValue3);
					return new SQLCrossTableBuilder(TableName, a_3);
				}
			}
			return null;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x000AA370 File Offset: 0x000A8570
		[EditorBrowsable(EditorBrowsableState.Never)]
		public SQLGroupTableBuilder SQLGroupTableBuilder(string TableName, params object[] args)
		{
			int num = args.Length;
			if (num != 1)
			{
				if (num == 2)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(args[0]);
					object objectValue2 = RuntimeHelpers.GetObjectValue(args[1]);
					if (objectValue is string && objectValue2 is string)
					{
						string a_ = Conversions.ToString(objectValue);
						string a_2 = Conversions.ToString(objectValue2);
						return new SQLGroupTableBuilder(TableName, a_, a_2);
					}
				}
			}
			else
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(args[0]);
				if (objectValue3 is string)
				{
					string a_3 = Conversions.ToString(objectValue3);
					return new SQLGroupTableBuilder(TableName, a_3);
				}
			}
			return null;
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x000AA3F5 File Offset: 0x000A85F5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public SQLJoinTableBuilder SQLJoinTableBuilder(string TableName, string BaseTable)
		{
			return new SQLJoinTableBuilder(TableName, BaseTable);
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x000AA400 File Offset: 0x000A8600
		[EditorBrowsable(EditorBrowsableState.Never)]
		public SQLCommand SQLCommand(params object[] args)
		{
			SQLCommand result;
			if (args.Length == 0)
			{
				result = new SQLCommand();
			}
			else if (args.Length == 1)
			{
				result = new SQLCommand(Conversions.ToString(args[0]));
			}
			else if (args.Length == 2)
			{
				result = new SQLCommand(Conversions.ToString(args[0]), Conversions.ToString(args[1]));
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x000AA451 File Offset: 0x000A8651
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DropTreeBuilder DropTreeBuilder()
		{
			return new DropTreeBuilder();
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x000AA458 File Offset: 0x000A8658
		[EditorBrowsable(EditorBrowsableState.Never)]
		public QueryBuilder QueryBuilder(params object[] args)
		{
			QueryBuilder result;
			if (args.Length == 0)
			{
				result = new QueryBuilder();
			}
			else if (args.Length == 1)
			{
				result = new QueryBuilder(Conversions.ToString(args[0]));
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x000AA48C File Offset: 0x000A868C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public OuterTableBuilder OuterTableBuilder(params object[] args)
		{
			OuterTableBuilder result;
			if (args.Length == 0)
			{
				result = new OuterTableBuilder();
			}
			else if (args.Length == 1)
			{
				result = new OuterTableBuilder(Conversions.ToString(args[0]));
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x000AA4C0 File Offset: 0x000A86C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public InlineMRPBuilder InlineMRPBuilder(params object[] args)
		{
			InlineMRPBuilder result;
			if (args.Length == 0)
			{
				result = new InlineMRPBuilder();
			}
			else if (args.Length == 1)
			{
				result = new InlineMRPBuilder(Conversions.ToString(args[0]));
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x000AA4F4 File Offset: 0x000A86F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public LayersMRPBuilder LayersMRPBuilder(params object[] args)
		{
			LayersMRPBuilder result;
			if (args.Length == 0)
			{
				result = new LayersMRPBuilder();
			}
			else if (args.Length == 1)
			{
				result = new LayersMRPBuilder(Conversions.ToString(args[0]));
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x000AA527 File Offset: 0x000A8727
		[EditorBrowsable(EditorBrowsableState.Never)]
		public InlineTreeSetting InlineTreeSetting()
		{
			return new InlineTreeSetting();
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x000AA52E File Offset: 0x000A872E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public LayerTreeSetting LayerTreeSetting()
		{
			return new LayerTreeSetting();
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x000AA535 File Offset: 0x000A8735
		[EditorBrowsable(EditorBrowsableState.Never)]
		public GroupTreeSetting GroupTreeSetting()
		{
			return new GroupTreeSetting();
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x000AA53C File Offset: 0x000A873C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Exporter Exporter()
		{
			return new Exporter();
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x000AA543 File Offset: 0x000A8743
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Importer Importer()
		{
			return new Importer();
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x000AA54A File Offset: 0x000A874A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Merger Merger()
		{
			return new Merger();
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x000AA551 File Offset: 0x000A8751
		[EditorBrowsable(EditorBrowsableState.Never)]
		public SaveFileDialogForjs SaveFileDialog()
		{
			return new SaveFileDialogForjs(this.Oo_00_oO.00O0O.);
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x000AA55E File Offset: 0x000A875E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public OpenFileDialogForjs OpenFileDialog()
		{
			return new OpenFileDialogForjs(this.Oo_00_oO.00O0O.);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x000AA56B File Offset: 0x000A876B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public FolderBrowserDialogForjs FolderBrowserDialog()
		{
			return new FolderBrowserDialogForjs(this.Oo_00_oO.00O0O.);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x000AA578 File Offset: 0x000A8778
		public ColorDialogJs ColorDialog()
		{
			return new ColorDialogJs(this.Oo_00_oO.00O0O.);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x000AA585 File Offset: 0x000A8785
		public FontDialogJs FontDialog()
		{
			return new FontDialogJs(this.Oo_00_oO.00O0O.);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000AA592 File Offset: 0x000A8792
		public MessageBoxForJs MessageBox()
		{
			return new MessageBoxForJs(this.Oo_00_oO.00O0O.);
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x000AA59F File Offset: 0x000A879F
		public FileInfo FileInfo(string file)
		{
			return new FileInfo(file);
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x000AA5A8 File Offset: 0x000A87A8
		public Font Font(params object[] args)
		{
			Font result;
			if (args.Length == 2)
			{
				result = new Font(Conversions.ToString(args[0]), (float)Conversions.ToInteger(args[1]));
			}
			else
			{
				result = new Font(Conversions.ToString(args[0]), (float)Conversions.ToInteger(args[1]), (FontStyle)Conversions.ToInteger(args[2]));
			}
			return result;
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x000AA5F4 File Offset: 0x000A87F4
		public DataTableBuilder DataTableBuilder(string TableName)
		{
			return new DataTableBuilder(TableName);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x000AA5FC File Offset: 0x000A87FC
		public SubtotalGroup SubtotalGroup()
		{
			return new SubtotalGroup();
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x000AA603 File Offset: 0x000A8803
		public ImageMap ImageMap()
		{
			return new ImageMap();
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x000AA60A File Offset: 0x000A880A
		public MultiDataMap MultiDataMap()
		{
			return new MultiDataMap();
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x000AA611 File Offset: 0x000A8811
		public Process Process()
		{
			return new Process();
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x000AA618 File Offset: 0x000A8818
		public TableDataMap TableDataMap()
		{
			return new TableDataMap();
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x000AA61F File Offset: 0x000A881F
		public DataMapJs DataMap()
		{
			return new DataMapJs();
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x000AA628 File Offset: 0x000A8828
		public FTPClient FTPClient(params object[] args)
		{
			FTPClient result;
			if (args.Length == 0)
			{
				result = new FTPClient();
			}
			else
			{
				if (args.Length >= 3)
				{
					string a_ = Conversions.ToString(args[0]);
					string a_2 = Conversions.ToString(args[1]);
					string a_3 = Conversions.ToString(args[2]);
					switch (args.Length)
					{
					case 3:
						return new FTPClient(a_, a_2, a_3, null);
					case 4:
					{
						Encoding encoding = Encoding.GetEncoding(Conversions.ToString(args[3]));
						return new FTPClient(a_, a_2, a_3, encoding);
					}
					case 5:
					case 6:
					{
						int a_4 = Conversions.ToInteger(args[3]);
						int a_5 = Conversions.ToInteger(args[4]);
						if (args.Length == 5)
						{
							return new FTPClient(a_, a_2, a_3, a_4, a_5, null);
						}
						Encoding encoding2 = Encoding.GetEncoding(Conversions.ToString(args[5]));
						return new FTPClient(a_, a_2, a_3, a_4, a_5, encoding2);
					}
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x000AA6FE File Offset: 0x000A88FE
		public InlineGroupTableBuilder InlineGroupTableBuilder(string TableName)
		{
			return new InlineGroupTableBuilder(TableName);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x000AA706 File Offset: 0x000A8906
		public LayersGroupTableBuilder LayersGroupTableBuilder(string TableName)
		{
			return new LayersGroupTableBuilder(TableName);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x000AA70E File Offset: 0x000A890E
		public MailSender MailSender()
		{
			return new MailSender();
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x000AA715 File Offset: 0x000A8915
		public RibbonMenuJs RibbonMenu
		{
			get
			{
				if (this.Oo_00_oO.00O0O. == null)
				{
					this.Oo_00_oO.00O0O. = new RibbonMenuJs();
				}
				return this.Oo_00_oO.00O0O.;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x000AA730 File Offset: 0x000A8930
		public SendkeysJs SendKeys
		{
			get
			{
				if (this.Oo_00_oO.00O0O. == null)
				{
					this.Oo_00_oO.00O0O. = new SendkeysJs();
				}
				return this.Oo_00_oO.00O0O.;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x000AA74B File Offset: 0x000A894B
		public ClipBoardJs ClipBoard
		{
			get
			{
				if (this.O.0_o0. == null)
				{
					this.O.0_o0. = new ClipBoardJs();
				}
				return this.O.0_o0.;
			}
		}

		// Token: 0x0400099D RID: 2461
		private readonly List<Assembly> <<EMPTY_NAME>>;

		// Token: 0x0400099E RID: 2462
		private readonly List<string> <<EMPTY_NAME>>;

		// Token: 0x0400099F RID: 2463
		private readonly Dictionary<string, Type> <<EMPTY_NAME>>;

		// Token: 0x040009A0 RID: 2464
		private WebViewer <<EMPTY_NAME>>;

		// Token: 0x040009A1 RID: 2465
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040009A2 RID: 2466
		private Randjs <<EMPTY_NAME>>;

		// Token: 0x040009A3 RID: 2467
		private PYJS <<EMPTY_NAME>>;

		// Token: 0x040009A4 RID: 2468
		private AudioJs <<EMPTY_NAME>>;

		// Token: 0x040009A5 RID: 2469
		private RibbonMenuJs <<EMPTY_NAME>>;

		// Token: 0x040009A6 RID: 2470
		private SendkeysJs <<EMPTY_NAME>>;

		// Token: 0x040009A7 RID: 2471
		private ClipBoardJs <<EMPTY_NAME>>;
	}
}
