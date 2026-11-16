using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using ADODB;
using ADOX;
using C1.Win.C1Input;
using C1.Win.C1Themes;
using Foxtable.My;
using Foxtable.RibbonMenu;
using Foxtable.Syscmd;
using JRO;
using Microsoft.International.Converters.PinYinConverter;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using MSScriptControl;

namespace Foxtable
{
	// Token: 0x020004E4 RID: 1252
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StandardModule]
	public sealed class OO_00oOO
	{
		// Token: 0x0600520B RID: 21003
		[DllImport("wininet.dll")]
		private static extern bool InternetGetConnectedState(ref int A_0, int A_1);

		// Token: 0x0600520C RID: 21004
		[DllImport("user32")]
		private static extern int EnumWindows(OO_00oOO.o_O_0ooO A_0, int A_1);

		// Token: 0x0600520D RID: 21005
		[DllImport("user32.dll")]
		internal static extern IntPtr SendMessage(IntPtr A_0, int A_1, int A_2, int A_3);

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600520E RID: 21006 RVA: 0x00249870 File Offset: 0x00247A70
		// (remove) Token: 0x0600520F RID: 21007 RVA: 0x002498A4 File Offset: 0x00247AA4
		internal static event OO_00oOO.oo_00_O0_0O CurrentTableChanged
		{
			[CompilerGenerated]
			add
			{
				OO_00oOO.oo_00_O0_0O oo_00_O0_0O = OO_00oOO.O0o_00Oo0.o_o.;
				OO_00oOO.oo_00_O0_0O oo_00_O0_0O2;
				do
				{
					oo_00_O0_0O2 = oo_00_O0_0O;
					OO_00oOO.oo_00_O0_0O value2 = (OO_00oOO.oo_00_O0_0O)Delegate.Combine(oo_00_O0_0O2, value);
					oo_00_O0_0O = Interlocked.CompareExchange<OO_00oOO.oo_00_O0_0O>(ref OO_00oOO.O0o_00Oo0.o_o., value2, oo_00_O0_0O2);
				}
				while (oo_00_O0_0O != oo_00_O0_0O2);
			}
			[CompilerGenerated]
			remove
			{
				OO_00oOO.oo_00_O0_0O oo_00_O0_0O = OO_00oOO.O0o_00Oo0.o_o.;
				OO_00oOO.oo_00_O0_0O oo_00_O0_0O2;
				do
				{
					oo_00_O0_0O2 = oo_00_O0_0O;
					OO_00oOO.oo_00_O0_0O value2 = (OO_00oOO.oo_00_O0_0O)Delegate.Remove(oo_00_O0_0O2, value);
					oo_00_O0_0O = Interlocked.CompareExchange<OO_00oOO.oo_00_O0_0O>(ref OO_00oOO.O0o_00Oo0.o_o., value2, oo_00_O0_0O2);
				}
				while (oo_00_O0_0O != oo_00_O0_0O2);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06005210 RID: 21008 RVA: 0x002498D8 File Offset: 0x00247AD8
		// (remove) Token: 0x06005211 RID: 21009 RVA: 0x0024990C File Offset: 0x00247B0C
		internal static event OO_00oOO.oo0O0__O__oO MainTableChanged
		{
			[CompilerGenerated]
			add
			{
				OO_00oOO.oo0O0__O__oO oo0O0__O__oO = OO_00oOO.O0o_00Oo0.o_o.;
				OO_00oOO.oo0O0__O__oO oo0O0__O__oO2;
				do
				{
					oo0O0__O__oO2 = oo0O0__O__oO;
					OO_00oOO.oo0O0__O__oO value2 = (OO_00oOO.oo0O0__O__oO)Delegate.Combine(oo0O0__O__oO2, value);
					oo0O0__O__oO = Interlocked.CompareExchange<OO_00oOO.oo0O0__O__oO>(ref OO_00oOO.O0o_00Oo0.o_o., value2, oo0O0__O__oO2);
				}
				while (oo0O0__O__oO != oo0O0__O__oO2);
			}
			[CompilerGenerated]
			remove
			{
				OO_00oOO.oo0O0__O__oO oo0O0__O__oO = OO_00oOO.O0o_00Oo0.o_o.;
				OO_00oOO.oo0O0__O__oO oo0O0__O__oO2;
				do
				{
					oo0O0__O__oO2 = oo0O0__O__oO;
					OO_00oOO.oo0O0__O__oO value2 = (OO_00oOO.oo0O0__O__oO)Delegate.Remove(oo0O0__O__oO2, value);
					oo0O0__O__oO = Interlocked.CompareExchange<OO_00oOO.oo0O0__O__oO>(ref OO_00oOO.O0o_00Oo0.o_o., value2, oo0O0__O__oO2);
				}
				while (oo0O0__O__oO != oo0O0__O__oO2);
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06005212 RID: 21010 RVA: 0x0024993F File Offset: 0x00247B3F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static MRPTableCols MRP
		{
			get
			{
				return OO_00oOO.O_0.oooO__O.;
			}
		}

		/// <summary>
		/// 设置MRP统计结果表的默认列名称
		/// </summary>
		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06005213 RID: 21011 RVA: 0x00249946 File Offset: 0x00247B46
		[oO0oooo("3388")]
		public static MRPTableCols MRPCols
		{
			get
			{
				return OO_00oOO.O_0.oooO__O.;
			}
		}

		// Token: 0x06005214 RID: 21012
		[DllImport("Foxtable.IO.dll")]
		private static extern bool GetHardDiskId(StringBuilder A_0, int A_1);

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06005215 RID: 21013 RVA: 0x0024994D File Offset: 0x00247B4D
		// (set) Token: 0x06005216 RID: 21014 RVA: 0x00249954 File Offset: 0x00247B54
		[oO0oooo("0365")]
		public static DataTableCollection DataTables
		{
			get
			{
				return OO_00oOO.OO._ooO.;
			}
			internal set
			{
				OO_00oOO.OO._ooO. = value;
			}
		}

		/// <summary>
		/// 字符串集合，返回项打开项目的参数
		/// </summary>
		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06005217 RID: 21015 RVA: 0x0024995C File Offset: 0x00247B5C
		[oO0oooo("2495")]
		public static List<object> OpenFileArgs
		{
			get
			{
				return OO_00oOO.O_0.oooO__O.;
			}
		}

		/// <summary>
		/// Table集合 
		/// </summary>
		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06005218 RID: 21016 RVA: 0x00249963 File Offset: 0x00247B63
		// (set) Token: 0x06005219 RID: 21017 RVA: 0x0024996A File Offset: 0x00247B6A
		[oO0oooo("0437")]
		public static TableCollection Tables
		{
			get
			{
				return OO_00oOO.O0o_00Oo0.o_o.;
			}
			internal set
			{
				OO_00oOO.O0o_00Oo0.o_o. = value;
			}
		}

		/// <summary>
		/// 用户窗口集合
		/// </summary>
		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x0600521A RID: 21018 RVA: 0x00249972 File Offset: 0x00247B72
		[oO0oooo("0703")]
		public static FormCollection Forms
		{
			get
			{
				return OO_00oOO.OO._ooO.;
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x0600521B RID: 21019 RVA: 0x00249979 File Offset: 0x00247B79
		public static ReportCollection Reports
		{
			get
			{
				return OO_00oOO.o0O._o__O0.;
			}
		}

		/// <summary>
		/// 自定义函数集合
		/// </summary>
		/// <returns></returns>
		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x0600521C RID: 21020 RVA: 0x00249980 File Offset: 0x00247B80
		[oO0oooo("1486")]
		public static UserFunctions Functions
		{
			get
			{
				return OO_00oOO.O_0.oooO__O.;
			}
		}

		/// <summary>
		/// 用于获取计算机的硬件信息
		/// </summary>
		/// <returns></returns>
		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x0600521D RID: 21021 RVA: 0x00249987 File Offset: 0x00247B87
		public static HardWare HardWareInfo
		{
			get
			{
				return OO_00oOO.O_0.oooO__O.;
			}
		}

		/// <summary>
		/// 返回已经打开的项目文件名
		/// </summary>
		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x0600521E RID: 21022 RVA: 0x0024998E File Offset: 0x00247B8E
		// (set) Token: 0x0600521F RID: 21023 RVA: 0x00249998 File Offset: 0x00247B98
		public static string ProjectFile
		{
			get
			{
				return OO_00oOO.oO_Oo._o0o.;
			}
			internal set
			{
				OO_00oOO.oO_Oo._o0o. = value;
				OO_00oOO.OOo._O___. = c.OOOOO.o.().FileSystem.GetParentPath(OO_00oOO.oO_Oo._o0o.) + "\\";
				OO_00oOO.O0.0oo0_. = c.OOOOO.o.().FileSystem.GetParentPath(OO_00oOO.oO_Oo._o0o.) + "\\Attachments\\";
				if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) != 0)
				{
					int num = Main.OO_O.o..O0o__0_OO.o.().TabPages.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Main.OO_O.o..O0o__0_OO.o.().TabPages[i].Controls.Count == 1 && Main.OO_O.o..O0o__0_OO.o.().TabPages[i].Controls[0] == Main.OO_O.o..O.OOO0_OOo.())
						{
							Main.OO_O.o..O0o__0_OO.o.().Close(Main.OO_O.o..O0o__0_OO.o.().TabPages[i]);
							break;
						}
					}
					if (Main.OO_O.o..O.OOO0_OOo.() != null)
					{
						Main.OO_O.o..O0.0000oO.(null);
					}
				}
			}
		}

		/// <summary>
		/// 字符型，返回FoxTable主程序所在目录
		/// </summary>
		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06005220 RID: 21024 RVA: 0x00249AB4 File Offset: 0x00247CB4
		[oO0oooo("1439")]
		public static string ApplicationPath
		{
			get
			{
				return c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\\";
			}
		}

		/// <summary>
		/// 字符型，返回项目文件所在目录
		/// </summary>
		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06005221 RID: 21025 RVA: 0x00249AD4 File Offset: 0x00247CD4
		[oO0oooo("1439")]
		public static string ProjectPath
		{
			get
			{
				return OO_00oOO.OOo._O___.;
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06005222 RID: 21026 RVA: 0x00249ADB File Offset: 0x00247CDB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string AttachPath
		{
			get
			{
				return OO_00oOO.O0.0oo0_.;
			}
		}

		/// <summary>
		/// 返回当前表，也称为活动表，指的是当前输入焦点所在的表
		/// </summary>
		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06005223 RID: 21027 RVA: 0x00249AE4 File Offset: 0x00247CE4
		// (set) Token: 0x06005224 RID: 21028 RVA: 0x00249B35 File Offset: 0x00247D35
		[oO0oooo("0436")]
		public static Foxtable.Table CurrentTable
		{
			get
			{
				Foxtable.Table result;
				if (OO_00oOO.oOO.0_. != null && OO_00oOO.oOO.0_..Grid != null && !OO_00oOO.oOO.0_..Grid.IsDisposed && !OO_00oOO.oOO.0_..Grid.Disposing)
				{
					result = OO_00oOO.oOO.0_.;
				}
				else
				{
					result = OO_00oOO.MainTable;
				}
				return result;
			}
			internal set
			{
				if (value == null)
				{
					OO_00oOO.oOO.0_. = null;
					return;
				}
				if (value.foxGrid.CanFocus || !OO_00oOO.CurrentTable.foxGrid.CanFocus)
				{
					OO_00oOO.oOO.0_. = value;
				}
			}
		}

		/// <summary>
		/// 返回当前主表，也就是通过表标题选择的表
		/// </summary>
		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06005225 RID: 21029 RVA: 0x00249B65 File Offset: 0x00247D65
		// (set) Token: 0x06005226 RID: 21030 RVA: 0x00249B6C File Offset: 0x00247D6C
		[oO0oooo("0436")]
		public static Foxtable.Table MainTable
		{
			get
			{
				return OO_00oOO.O_0.oooO__O.;
			}
			set
			{
				if ((value == null || !value.IsRelation) && value != null && (OO_00oOO.O_0.oooO__O. != value || OO_00oOO.O_0.oooO__O. == null))
				{
					if (value == null)
					{
						OO_00oOO.O_0.oooO__O. = null;
						return;
					}
					if (value.TableType == TableTypeEnum.Normal && !value.IsCopy)
					{
						try
						{
							foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
							{
								Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
								if (oo0__Oo.O_000__.o.() == value)
								{
									if (!oo0__Oo.TabVisible)
									{
										oo0__Oo.TabVisible = true;
									}
									if (Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab == oo0__Oo)
									{
										OO_00oOO.O_0.oooO__O. = value;
										OO_00oOO.oOO.0_. = value;
										break;
									}
									Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab = oo0__Oo;
									if (Main.OO_O.o..OO_O_0Oo.___o.().SelectedTab != oo0__Oo)
									{
										break;
									}
									OO_00oOO.O_0.oooO__O. = value;
									OO_00oOO.oOO.0_. = value;
									if (value.foxGrid.FindForm() == Main.OO_O.o.)
									{
										Main.OO_O.o..ActiveControl = value.foxGrid;
										break;
									}
									break;
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
					}
				}
			}
		}

		/// <summary>
		/// 强行触发指定的表事件
		/// </summary>
		/// <param name="Table">要触发事件的表</param>
		/// <param name="EventType">要触发事件的类型</param>
		// Token: 0x06005227 RID: 21031 RVA: 0x00249CA4 File Offset: 0x00247EA4
		public static void RaiseSystemEvent(Foxtable.Table Table, params SystemEventTypeEnum[] EventType)
		{
			if (OO_00oOO.SystemReady)
			{
				int num = EventType.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					SystemEventTypeEnum systemEventTypeEnum = EventType[i];
					if (systemEventTypeEnum <= SystemEventTypeEnum.PositionChanged)
					{
						switch (systemEventTypeEnum)
						{
						case SystemEventTypeEnum.None:
						{
							OO_00oOO.oo0O0__O__oO o0o_00Oo0.o_o. = OO_00oOO.O0o_00Oo0.o_o.;
							if (o0o_00Oo0.o_o. != null)
							{
								o0o_00Oo0.o_o.();
							}
							break;
						}
						case SystemEventTypeEnum.CurrentTableChanged:
						{
							OO_00oOO.oo_00_O0_0O o0o_00Oo0.o_o.2 = OO_00oOO.O0o_00Oo0.o_o.;
							if (o0o_00Oo0.o_o.2 != null)
							{
								o0o_00Oo0.o_o.2();
							}
							break;
						}
						case (SystemEventTypeEnum)2:
						case (SystemEventTypeEnum)3:
							break;
						case SystemEventTypeEnum.CurrentChanged:
							if (Table != null)
							{
								Table.View.o_._0O0o_OoO.();
							}
							break;
						default:
							if (systemEventTypeEnum == SystemEventTypeEnum.PositionChanged)
							{
								if (Table != null)
								{
									Table.View.Oo._Oo0OO.();
								}
							}
							break;
						}
					}
					else if (systemEventTypeEnum != SystemEventTypeEnum.AfterSelRangeChange)
					{
						if (systemEventTypeEnum == SystemEventTypeEnum.AfterSelChange)
						{
							if (Table != null)
							{
								Table.foxGrid.o0O.o__O0Oo0.();
							}
						}
					}
					else if (Table != null)
					{
						Table.foxGrid.OooooOO.0_.();
					}
				}
			}
		}

		/// <summary>
		/// 一个集合，包括所有关联
		/// </summary>
		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x06005228 RID: 21032 RVA: 0x00249D6A File Offset: 0x00247F6A
		[oO0oooo("1942")]
		public static DataRelationCollection Relations
		{
			get
			{
				return OO_00oOO.o0O._o__O0.;
			}
		}

		/// <summary>
		/// 数据源集合
		/// </summary>
		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06005229 RID: 21033 RVA: 0x00249D71 File Offset: 0x00247F71
		[oO0oooo("1944")]
		public static ConnectionCollection Connections
		{
			get
			{
				return OO_00oOO.OO._ooO.;
			}
		}

		/// <summary>
		/// 文件监视器
		/// </summary>
		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x0600522A RID: 21034 RVA: 0x00249D78 File Offset: 0x00247F78
		[oO0oooo("1963")]
		public static FileSystemWatcher FileWatcher
		{
			get
			{
				return OO_00oOO.OO._ooO.;
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x0600522B RID: 21035 RVA: 0x00249D7F File Offset: 0x00247F7F
		[oO0oooo("1968")]
		public static MyPortCollections Ports
		{
			get
			{
				return OO_00oOO.O_0.oooO__O.;
			}
		}

		/// <summary>
		/// 快捷菜单
		/// </summary>
		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x0600522C RID: 21036 RVA: 0x00249D86 File Offset: 0x00247F86
		[oO0oooo("1324")]
		public static ContextMenuCollection ContextMenus
		{
			get
			{
				if (OO_00oOO.OO._ooO. == null)
				{
					OO_00oOO.OO._ooO. = new ContextMenuCollection(O_O0OO.o.00O_O.());
				}
				return OO_00oOO.OO._ooO.;
			}
		}

		/// <summary>
		/// 功能区
		/// </summary>
		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x0600522D RID: 21037 RVA: 0x00249DA3 File Offset: 0x00247FA3
		[oO0oooo("2483")]
		public static RibbonTabCollection RibbonTabs
		{
			get
			{
				if (OO_00oOO.o0O._o__O0. == null)
				{
					OO_00oOO.o0O._o__O0. = new RibbonTabCollection(Main.OO_O.o..O.OOO0_OOo.().Tabs);
				}
				return OO_00oOO.o0O._o__O0.;
			}
		}

		/// <summary>
		/// 功能区组
		/// </summary>
		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x0600522E RID: 21038 RVA: 0x00249DCA File Offset: 0x00247FCA
		[oO0oooo("3088")]
		public static RibbonTabGroupCollection RibbonTabGroups
		{
			get
			{
				if (OO_00oOO.o0O._o__O0. == null)
				{
					OO_00oOO.o0O._o__O0. = new RibbonTabGroupCollection(Main.OO_O.o..O.OOO0_OOo.().ContextualTabGroups);
				}
				return OO_00oOO.o0O._o__O0.;
			}
		}

		/// <summary>
		/// 程序菜单
		/// </summary>
		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x0600522F RID: 21039 RVA: 0x00249DF1 File Offset: 0x00247FF1
		[oO0oooo("1091")]
		public static ApplicationMenu ApplicationMenu
		{
			get
			{
				return new ApplicationMenu(Main.OO_O.o..O.OOO0_OOo.().ApplicationMenu);
			}
		}

		/// <summary>
		/// 快速访问栏
		/// </summary>
		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06005230 RID: 21040 RVA: 0x00249E07 File Offset: 0x00248007
		[oO0oooo("1094")]
		public static Qat QAT
		{
			get
			{
				return new Qat(Main.OO_O.o..O.OOO0_OOo.().Qat);
			}
		}

		/// <summary>
		/// 配置栏
		/// </summary>
		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06005231 RID: 21041 RVA: 0x00249E1D File Offset: 0x0024801D
		[oO0oooo("1097")]
		public static ConfigBar ConfigBar
		{
			get
			{
				return new ConfigBar(Main.OO_O.o..O.OOO0_OOo.().ConfigToolBar);
			}
		}

		/// <summary>
		/// 上工具栏
		/// </summary>
		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06005232 RID: 21042 RVA: 0x00249E33 File Offset: 0x00248033
		[oO0oooo("3086")]
		public static TopToolBar TopToolBar
		{
			get
			{
				return new TopToolBar(Main.OO_O.o..O.OOO0_OOo.().TopToolBar);
			}
		}

		/// <summary>
		/// 下工具栏
		/// </summary>
		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06005233 RID: 21043 RVA: 0x00249E49 File Offset: 0x00248049
		[oO0oooo("3087")]
		public static BottomToolBar BottomToolBar
		{
			get
			{
				return new BottomToolBar(Main.OO_O.o..O.OOO0_OOo.().BottomToolBar);
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06005234 RID: 21044 RVA: 0x00249E5F File Offset: 0x0024805F
		// (set) Token: 0x06005235 RID: 21045 RVA: 0x00249E66 File Offset: 0x00248066
		[oO0oooo("0609")]
		public static UserInfo User
		{
			get
			{
				return OO_00oOO.O0o_00Oo0.o_o.;
			}
			internal set
			{
				if (!OO_00oOO.isUserColdeRunning())
				{
					OO_00oOO.O0o_00Oo0.o_o. = value;
				}
			}
		}

		/// <summary>
		/// Keys型枚举，用于判断Control、Shift、Alt三个按键的状态
		/// </summary>
		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x06005236 RID: 21046 RVA: 0x00249E75 File Offset: 0x00248075
		[oO0oooo("0356")]
		public static System.Windows.Forms.Keys ModifierKey
		{
			get
			{
				return Control.ModifierKeys;
			}
		}

		/// <summary>
		/// 返回当前鼠标按键的状态
		/// </summary>
		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x06005237 RID: 21047 RVA: 0x00249E7C File Offset: 0x0024807C
		[oO0oooo("0355")]
		public static MouseButtons MouseButton
		{
			get
			{
				return Control.MouseButtons;
			}
		}

		/// <summary>
		/// 计划集合
		/// </summary>
		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06005238 RID: 21048 RVA: 0x00249E83 File Offset: 0x00248083
		[oO0oooo("0658")]
		public static TimerCollection MyTimers
		{
			get
			{
				return OO_00oOO.O0o_00Oo0.o_o.;
			}
		}

		/// <summary>
		/// Var变量集合
		/// </summary>
		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06005239 RID: 21049 RVA: 0x00249E8A File Offset: 0x0024808A
		[oO0oooo("0325")]
		public static VarsCollection Vars
		{
			get
			{
				return OO_00oOO.O0o_00Oo0.o_o.;
			}
		}

		/// <summary>
		/// 根据指定的文件获取图片
		/// </summary>
		/// <param name="ImageFile">图片文件，含路径</param>
		// Token: 0x0600523A RID: 21050 RVA: 0x00249E94 File Offset: 0x00248094
		public static Image GetImage(string ImageFile)
		{
			Image image = null;
			Image result;
			if (Operators.CompareString(ImageFile, "", true) == 0)
			{
				result = null;
			}
			else
			{
				ImageFile = ImageFile.ToLower();
				try
				{
					if (string.IsNullOrEmpty(Path.GetPathRoot(ImageFile)))
					{
						if (OO_00oOO.FileSys.FileExists(O_O0OO.OOo_o.0o. + ImageFile))
						{
							ImageFile = O_O0OO.OOo_o.0o. + ImageFile;
						}
						else
						{
							ImageFile = ooO.OoO0o_o___.O.(ImageFile);
							if (!File.Exists(ImageFile))
							{
								ImageFile = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\\images\\" + c.OOOOO.o.().FileSystem.GetName(ImageFile);
							}
						}
					}
					if (!File.Exists(ImageFile))
					{
						return null;
					}
					if (Operators.CompareString(Path.GetExtension(ImageFile).ToUpper(), ".ICO", true) == 0)
					{
						byte[] buffer = OO_00oOO.FileSys.ReadAllBytes(ImageFile);
						image = new Icon(new MemoryStream(buffer)).ToBitmap();
					}
					else
					{
						byte[] buffer2 = OO_00oOO.FileSys.ReadAllBytes(ImageFile);
						image = Image.FromStream(new MemoryStream(buffer2));
					}
				}
				catch (Exception ex)
				{
				}
				result = image;
			}
			return result;
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x0600523B RID: 21051 RVA: 0x00249FB4 File Offset: 0x002481B4
		public static DataView BindTables
		{
			get
			{
				return OO_00oOO.Tables[A_0].View.o_o.O0ooOo.();
			}
		}

		/// <summary>
		/// 用于播放声音文件
		/// </summary>
		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x0600523C RID: 21052 RVA: 0x00249FCB File Offset: 0x002481CB
		[oO0oooo("0330")]
		public static Audio Audio
		{
			get
			{
				return c.OOOOO.o.().Audio;
			}
		}

		/// <summary>
		/// 用于管理文件和目录
		/// </summary>
		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x0600523D RID: 21053 RVA: 0x00249FD7 File Offset: 0x002481D7
		[oO0oooo("0331")]
		public static FileSystemProxy FileSys
		{
			get
			{
				return c.OOOOO.o.().FileSystem;
			}
		}

		/// <summary>
		/// 计算个人所得税
		/// </summary>
		/// <param name="x">应税收入减去起征点之后的值</param>
		// Token: 0x0600523E RID: 21054 RVA: 0x00249FE4 File Offset: 0x002481E4
		[oO0oooo("0675")]
		public static double InTax(double x)
		{
			double[] array = new double[]
			{
				80000.0,
				55000.0,
				35000.0,
				25000.0,
				12000.0,
				3000.0,
				0.0
			};
			double[] array2 = new double[]
			{
				0.45,
				0.35,
				0.3,
				0.25,
				0.2,
				0.1,
				0.03
			};
			int num = array.Length - 1;
			double num3;
			for (int i = 0; i <= num; i++)
			{
				double num2 = x - array[i];
				if (num2 > 0.0)
				{
					num3 += num2 * array2[i];
					x -= num2;
				}
				if (x < 0.0)
				{
					break;
				}
			}
			return Math.Round(num3, 2, MidpointRounding.AwayFromZero);
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x0600523F RID: 21055 RVA: 0x0024A064 File Offset: 0x00248264
		private static string IIFCode
		{
			get
			{
				if (Operators.CompareString(OO_00oOO.O__0o0.o., "", true) == 0)
				{
					OO_00oOO.O__0o0.o. = "Function IIF(expression, true_value, false_value)\r\n";
					OO_00oOO.O__0o0.o. += "IIF = false_value\r\n";
					OO_00oOO.O__0o0.o. += "If expression Then IIF = true_value\r\n";
					OO_00oOO.O__0o0.o. += "End Function";
				}
				return OO_00oOO.O__0o0.o.;
			}
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x0024A0D0 File Offset: 0x002482D0
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			string text = "<>()+-*/,&\\=[]";
			string text2 = "＜＞（）＋－＊／，＆\\＝［］";
			int num = text.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				A_0 = A_0.Replace(text2[i], text[i]);
			}
			return A_0;
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x0024A118 File Offset: 0x00248318
		internal static object <<EMPTY_NAME>>(string A_0, DataRow A_1, bool A_2, bool A_3, bool A_4)
		{
			if (OO_00oOO.a == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref OO_00oOO.a, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(OO_00oOO.a, ref flag);
				if (OO_00oOO.a.State == 0)
				{
					OO_00oOO.a.State = 2;
					OO_00oOO.a = null;
				}
				else if (OO_00oOO.a.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				OO_00oOO.a.State = 1;
				if (flag)
				{
					Monitor.Exit(OO_00oOO.a);
				}
			}
			A_0 = OO_00oOO.o___O.0oOoO_.(A_0);
			if (OO_00oOO.a == null)
			{
				OO_00oOO.a = new ScriptControlClass();
				OO_00oOO.a.Language = "VBScript";
				OO_00oOO.a = new Dictionary<string, string>();
			}
			OO_00oOO.a.Reset();
			OO_00oOO.a.Clear();
			OO_00oOO.a.AddCode(string.Concat(new string[]
			{
				OO_00oOO.IIFCode,
				"\r\n",
				SysInfo.ChineseScript,
				"\r\n",
				SysInfo.FormatCode
			}));
			DataRow dataRow;
			DataTable dataTable;
			if (A_1 != null)
			{
				dataRow = A_1.BaseRow;
				dataTable = dataRow.Table;
			}
			else
			{
				dataRow = null;
				dataTable = null;
			}
			int num;
			for (int i = A_0.IndexOf("["); i >= 0; i = A_0.IndexOf("[", num + 1))
			{
				num = A_0.IndexOf("]", i + 1);
				string text = A_0.Substring(i + 1, num - i - 1);
				if (A_1 != null && dataTable.Columns.Contains(text) && !OO_00oOO.a.ContainsValue(text))
				{
					OO_00oOO.a.Add("a" + Conversions.ToString(OO_00oOO.a.Count), text);
					if (!dataRow.IsNull(text))
					{
						if (dataTable.Columns[text].DataType == typeof(string))
						{
							OO_00oOO.a.ExecuteStatement(string.Concat(new string[]
							{
								"a",
								Conversions.ToString(OO_00oOO.a.Count - 1),
								" = \"",
								dataRow[text].ToString().Replace("\r\n", "").Replace("\"", "\"\""),
								"\""
							}));
						}
						else if (dataTable.Columns[text].DataType == typeof(DateTime))
						{
							OO_00oOO.a.ExecuteStatement(string.Concat(new string[]
							{
								"a",
								Conversions.ToString(OO_00oOO.a.Count - 1),
								" = #",
								dataRow[text].ToString(),
								"#"
							}));
						}
						else
						{
							OO_00oOO.a.ExecuteStatement("a" + Conversions.ToString(OO_00oOO.a.Count - 1) + " = " + dataRow[text].ToString());
						}
					}
				}
				else if (text.StartsWith("@"))
				{
					if (text.IndexOf(",") < 0)
					{
						continue;
					}
					text = text.Substring(1);
					string[] array = text.Split(new char[]
					{
						','
					});
					string text2 = array[0].Trim();
					string text3 = array[1].Trim();
					int num2 = -1;
					DataRow dataRow2 = null;
					if (array.Length == 3 && !int.TryParse(array[2], out num2))
					{
						num2 = -1;
					}
					if (OO_00oOO.Tables.get_Contains(text2) && OO_00oOO.Tables[text2].Cols.Contains(text3))
					{
						OO_00oOO.a.Add("a" + Conversions.ToString(OO_00oOO.a.Count), "@" + text);
						if (num2 == -1)
						{
							if (OO_00oOO.Tables[text2].Current != null)
							{
								dataRow2 = OO_00oOO.Tables[text2].Current.BaseDataRow;
							}
						}
						else
						{
							if (array[2].StartsWith("+"))
							{
								num2 = OO_00oOO.Tables[text2].Position + num2;
							}
							if (num2 >= 0 && num2 < OO_00oOO.Tables[text2].Rows.Count)
							{
								dataRow2 = OO_00oOO.Tables[text2].Rows[num2].BaseDataRow;
							}
						}
						if (dataRow2 != null && !dataRow2.IsNull(text3))
						{
							if (dataRow2.Table.Columns[text3].DataType == typeof(string))
							{
								OO_00oOO.a.ExecuteStatement(string.Concat(new string[]
								{
									"a",
									Conversions.ToString(OO_00oOO.a.Count - 1),
									" = \"",
									dataRow2[text3].ToString(),
									"\""
								}));
							}
							else if (dataRow2.Table.Columns[text3].DataType == typeof(DateTime))
							{
								OO_00oOO.a.ExecuteStatement(string.Concat(new string[]
								{
									"a",
									Conversions.ToString(OO_00oOO.a.Count - 1),
									" = #",
									dataRow2[text3].ToString(),
									"#"
								}));
							}
							else
							{
								OO_00oOO.a.ExecuteStatement("a" + Conversions.ToString(OO_00oOO.a.Count - 1) + " = " + dataRow2[text3].ToString());
							}
						}
					}
				}
				else if (text.StartsWith("!"))
				{
					text = text.Substring(1);
					if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
					{
						OO_00oOO.a.Add("a" + Conversions.ToString(OO_00oOO.a.Count), "!" + text);
						if (OO_00oOO.Vars[text] != null)
						{
							if (OO_00oOO.Vars.VariableTable.Columns[text].DataType == typeof(string))
							{
								OO_00oOO.a.ExecuteStatement(string.Concat(new string[]
								{
									"a",
									Conversions.ToString(OO_00oOO.a.Count - 1),
									" = \"",
									OO_00oOO.Vars[text].ToString(),
									"\""
								}));
							}
							else if (OO_00oOO.Vars.VariableTable.Columns[text].DataType == typeof(DateTime))
							{
								OO_00oOO.a.ExecuteStatement(string.Concat(new string[]
								{
									"a",
									Conversions.ToString(OO_00oOO.a.Count - 1),
									" = #",
									OO_00oOO.Vars[text].ToString(),
									"#"
								}));
							}
							else
							{
								OO_00oOO.a.ExecuteStatement("a" + Conversions.ToString(OO_00oOO.a.Count - 1) + " = " + OO_00oOO.Vars[text].ToString());
							}
						}
					}
				}
				else if (A_1 != null && text.IndexOf(",") > 0)
				{
					string[] array2 = text.Split(new char[]
					{
						','
					});
					string text4 = array2[1].Trim();
					string[] array3 = array2[0].Split(new char[]
					{
						'.'
					});
					DataRow dataRow3 = dataRow;
					int num3 = array3.Length - 1;
					bool flag2;
					for (int j = 0; j <= num3; j++)
					{
						string right = array3[j].Trim();
						flag2 = false;
						try
						{
							foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
							{
								DataRelation dataRelation = (DataRelation)obj;
								if (Operators.CompareString(dataRelation.ParentTable.TableName, right, true) == 0 && Operators.CompareString(dataRelation.ChildTable.TableName, dataRow3.Table.TableName, true) == 0)
								{
									flag2 = true;
									dataRow3 = dataRow3.GetParentRow(dataRelation.RelationName);
									if (dataRow3 == null)
									{
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
						if (!flag2)
						{
							break;
						}
					}
					if (flag2 && dataRow3 != null && dataRow3 != dataRow && dataRow3.Table.Columns.Contains(text4))
					{
						OO_00oOO.a.Add("a" + Conversions.ToString(OO_00oOO.a.Count), text);
						if (!dataRow3.IsNull(text4))
						{
							if (dataRow3.Table.Columns[text4].DataType == typeof(string))
							{
								OO_00oOO.a.ExecuteStatement(string.Concat(new string[]
								{
									"a",
									Conversions.ToString(OO_00oOO.a.Count - 1),
									" = \"",
									dataRow3[text4].ToString(),
									"\""
								}));
							}
							else if (dataTable.Columns[text4].DataType == typeof(DateTime))
							{
								OO_00oOO.a.ExecuteStatement(string.Concat(new string[]
								{
									"a",
									Conversions.ToString(OO_00oOO.a.Count - 1),
									" = #",
									dataRow3[text4].ToString(),
									"#"
								}));
							}
							else
							{
								OO_00oOO.a.ExecuteStatement("a" + Conversions.ToString(OO_00oOO.a.Count - 1) + " = " + dataRow3[text4].ToString());
							}
						}
					}
				}
			}
			try
			{
				foreach (string text5 in OO_00oOO.a.Keys)
				{
					A_0 = A_0.Replace("[" + OO_00oOO.a[text5] + "]", text5);
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			object result;
			try
			{
				object objectValue;
				if (A_2)
				{
					A_0 = "Function Eval() \r\n" + A_0 + "\r\nEnd  Function";
					OO_00oOO.a.AddCode(A_0);
					IScriptControl scriptControl = OO_00oOO.a;
					string procedureName = "Eval";
					object[] array4 = new object[0];
					objectValue = RuntimeHelpers.GetObjectValue(scriptControl.Run(procedureName, ref array4));
				}
				else
				{
					objectValue = RuntimeHelpers.GetObjectValue(OO_00oOO.a.Eval(A_0));
				}
				if (A_3)
				{
					result = true;
				}
				else
				{
					result = objectValue;
				}
			}
			catch (Exception a_)
			{
				if (A_3)
				{
					result = false;
				}
				else
				{
					if (!A_4)
					{
						ooO.oOo0Oo.o.(a_, "Eval函数计算错误，表达式为：" + A_0);
					}
					result = null;
				}
			}
			return result;
		}

		/// <summary>
		/// 表达式求值
		/// </summary>
		/// <param name="Expr">表达式</param>
		/// <param name="Row">用于取值的Row</param>
		// Token: 0x06005242 RID: 21058 RVA: 0x0024AC44 File Offset: 0x00248E44
		[oO0oooo("1277")]
		public static object Eval(string Expr, Row Row)
		{
			return OO_00oOO.oo0oOO.o.(Expr, Row.DataRow, false, false, false);
		}

		/// <summary>
		/// 表达式求值
		/// </summary>
		/// <param name="Expr">表达式</param>
		/// <param name="DataRow">用于取值的DataRow</param>
		// Token: 0x06005243 RID: 21059 RVA: 0x0024AC55 File Offset: 0x00248E55
		[oO0oooo("1277")]
		public static object Eval(string Expr, DataRow DataRow)
		{
			return OO_00oOO.oo0oOO.o.(Expr, DataRow, false, false, false);
		}

		/// <summary>
		/// 表达式求值
		/// </summary>
		/// <param name="Expr">表达式</param>
		// Token: 0x06005244 RID: 21060 RVA: 0x0024AC61 File Offset: 0x00248E61
		[oO0oooo("1277")]
		public static object Eval(string Expr)
		{
			return OO_00oOO.oo0oOO.o.(Expr, null, false, false, false);
		}

		/// <summary>
		/// 表达式求值
		/// </summary>
		/// <param name="Expr">表达式</param>
		/// <param name="Row">用于取值的Row</param>
		// Token: 0x06005245 RID: 21061 RVA: 0x0024AC6D File Offset: 0x00248E6D
		[oO0oooo("1277")]
		public static object Eval2(string Expr, Row Row)
		{
			return OO_00oOO.oo0oOO.o.(Expr, Row.DataRow, false, false, true);
		}

		/// <summary>
		/// 表达式求值
		/// </summary>
		/// <param name="Expr">表达式</param>
		/// <param name="DataRow">用于取值的DataRow</param>
		// Token: 0x06005246 RID: 21062 RVA: 0x0024AC7E File Offset: 0x00248E7E
		[oO0oooo("1277")]
		public static object Eval2(string Expr, DataRow DataRow)
		{
			return OO_00oOO.oo0oOO.o.(Expr, DataRow, false, false, true);
		}

		/// <summary>
		/// 表达式求值
		/// </summary>
		/// <param name="Expr">表达式</param>
		// Token: 0x06005247 RID: 21063 RVA: 0x0024AC8A File Offset: 0x00248E8A
		[oO0oooo("1277")]
		public static object Eval2(string Expr)
		{
			return OO_00oOO.oo0oOO.o.(Expr, null, false, false, true);
		}

		/// <summary>
		/// 用于检测表达式，如果此表达式正确则返回True，否则返回False
		/// </summary>
		/// <param name="Expr">表达式</param>
		/// <param name="Row">用于取值的Row</param>
		// Token: 0x06005248 RID: 21064 RVA: 0x0024AC96 File Offset: 0x00248E96
		[oO0oooo("1277")]
		public static object TryEval(string Expr, Row Row)
		{
			return OO_00oOO.oo0oOO.o.(Expr, Row.DataRow, false, true, false);
		}

		/// <summary>
		/// 用于检测表达式，如果此表达式正确则返回True，否则返回False
		/// </summary>
		/// <param name="Expr">表达式</param>
		/// <param name="DataRow">用于取值的DataRow</param>
		// Token: 0x06005249 RID: 21065 RVA: 0x0024ACA7 File Offset: 0x00248EA7
		[oO0oooo("1277")]
		public static object TryEval(string Expr, DataRow DataRow)
		{
			return OO_00oOO.oo0oOO.o.(Expr, DataRow, false, true, false);
		}

		/// <summary>
		/// 用于检测表达式，如果此表达式正确则返回True，否则返回False
		/// </summary>
		/// <param name="Expr">表达式</param>
		// Token: 0x0600524A RID: 21066 RVA: 0x0024ACB3 File Offset: 0x00248EB3
		[oO0oooo("1277")]
		public static object TryEval(string Expr)
		{
			return OO_00oOO.oo0oOO.o.(Expr, null, false, true, false);
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x0600524B RID: 21067 RVA: 0x0024ACC0 File Offset: 0x00248EC0
		// (set) Token: 0x0600524C RID: 21068 RVA: 0x0024ACCE File Offset: 0x00248ECE
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static VisualStyleEnum VisualStyle
		{
			get
			{
				VisualStyleEnum result;
				return result;
			}
			set
			{
			}
		}

		/// <summary>
		/// 打开帮助文件
		/// </summary>
		// Token: 0x0600524D RID: 21069 RVA: 0x0024ACD0 File Offset: 0x00248ED0
		[oO0oooo("2293")]
		public static void ShowHelpWindow()
		{
			if (OO_00oOO.OO_.000_0_O_O. == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref OO_00oOO.OO_.000_0_O_O., new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(OO_00oOO.OO_.000_0_O_O., ref flag);
				if (OO_00oOO.OO_.000_0_O_O..State == 0)
				{
					OO_00oOO.OO_.000_0_O_O..State = 2;
					OO_00oOO.O.OoO__0O_oO. = "";
				}
				else if (OO_00oOO.OO_.000_0_O_O..State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				OO_00oOO.OO_.000_0_O_O..State = 1;
				if (flag)
				{
					Monitor.Exit(OO_00oOO.OO_.000_0_O_O.);
				}
			}
			if (OO_00oOO.oOO0o_Oo00.O. == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref OO_00oOO.oOO0o_Oo00.O., new StaticLocalInitFlag(), null);
			}
			bool flag2 = false;
			try
			{
				Monitor.Enter(OO_00oOO.oOO0o_Oo00.O., ref flag2);
				if (OO_00oOO.oOO0o_Oo00.O..State == 0)
				{
					OO_00oOO.oOO0o_Oo00.O..State = 2;
					OO_00oOO.ooo.__O0O0O0O. = "";
				}
				else if (OO_00oOO.oOO0o_Oo00.O..State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				OO_00oOO.oOO0o_Oo00.O..State = 1;
				if (flag2)
				{
					Monitor.Exit(OO_00oOO.oOO0o_Oo00.O.);
				}
			}
			if (OO_00oOO.O_0__O.o_ooo. == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref OO_00oOO.O_0__O.o_ooo., new StaticLocalInitFlag(), null);
			}
			bool flag3 = false;
			try
			{
				Monitor.Enter(OO_00oOO.O_0__O.o_ooo., ref flag3);
				if (OO_00oOO.O_0__O.o_ooo..State == 0)
				{
					OO_00oOO.O_0__O.o_ooo..State = 2;
					OO_00oOO.O0o_.ooo000o0O. = new Process();
				}
				else if (OO_00oOO.O_0__O.o_ooo..State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				OO_00oOO.O_0__O.o_ooo..State = 1;
				if (flag3)
				{
					Monitor.Exit(OO_00oOO.O_0__O.o_ooo.);
				}
			}
			if (OO_00oOO.FileSys.FileExists(OO_00oOO.ProjectPath + Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile) + ".chm"))
			{
				OO_00oOO.O.OoO__0O_oO. = OO_00oOO.ProjectPath + Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile) + ".chm";
			}
			else
			{
				if (!OO_00oOO.FileSys.FileExists(Main.OO_O.o.))
				{
					return;
				}
				OO_00oOO.O.OoO__0O_oO. = Main.OO_O.o.;
			}
			if (Operators.CompareString(OO_00oOO.O.OoO__0O_oO., OO_00oOO.ooo.__O0O0O0O., true) == 0 && Operators.CompareString(OO_00oOO.O.OoO__0O_oO., "", true) > 0 && !OO_00oOO.O0o_.ooo000o0O..HasExited)
			{
				ooO.SetForegroundWindow(OO_00oOO.O0o_.ooo000o0O..MainWindowHandle);
				return;
			}
			OO_00oOO.O0o_.ooo000o0O..File = OO_00oOO.O.OoO__0O_oO.;
			OO_00oOO.O0o_.ooo000o0O..Start();
			OO_00oOO.ooo.__O0O0O0O. = OO_00oOO.O.OoO__0O_oO.;
		}

		/// <summary>
		/// 打开帮助文件
		/// </summary>
		/// <param name="Topic">指定要显示的页面名称</param>
		// Token: 0x0600524E RID: 21070 RVA: 0x0024AF30 File Offset: 0x00249130
		[oO0oooo("2293")]
		public static void ShowHelpWindow(string Topic)
		{
			if (OO_00oOO.FileSys.FileExists(OO_00oOO.ProjectPath + Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile) + ".chm"))
			{
				Help.ShowHelp(null, OO_00oOO.ProjectPath + Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile) + ".chm", Topic);
				return;
			}
			if (OO_00oOO.FileSys.FileExists(Main.OO_O.o.))
			{
				Help.ShowHelp(null, Main.OO_O.o., Topic);
			}
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x0024AFA0 File Offset: 0x002491A0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ShowHelpWindow2()
		{
			if (OO_00oOO.o_.o_O. == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref OO_00oOO.o_.o_O., new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(OO_00oOO.o_.o_O., ref flag);
				if (OO_00oOO.o_.o_O..State == 0)
				{
					OO_00oOO.o_.o_O..State = 2;
					OO_00oOO.oO.o_0_o00O_O0. = "";
				}
				else if (OO_00oOO.o_.o_O..State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				OO_00oOO.o_.o_O..State = 1;
				if (flag)
				{
					Monitor.Exit(OO_00oOO.o_.o_O.);
				}
			}
			if (OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "foxmobile.chm"))
			{
				if (Operators.CompareString(OO_00oOO.oO.o_0_o00O_O0., "", true) == 0)
				{
					OO_00oOO.oO.o_0_o00O_O0. = O_O0OO.o.00O_O.() + "foxmobile.chm";
					OO_00oOO.oOO.0_. = new Process();
				}
				else if (OO_00oOO.oOO.0_. != null && !OO_00oOO.oOO.0_..HasExited)
				{
					ooO.SetForegroundWindow(OO_00oOO.oOO.0_..MainWindowHandle);
					return;
				}
				OO_00oOO.oOO.0_..File = OO_00oOO.oO.o_0_o00O_O0.;
				OO_00oOO.oOO.0_..Start();
			}
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x0024B0C0 File Offset: 0x002492C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static object ExecuteCode(string Code, bool ReturnValue)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (Operators.CompareString(Code, "", true) > 0)
			{
				Code = Code.Trim(new char[]
				{
					' ',
					'\n',
					'\r',
					'\t',
					'\u3000'
				});
			}
			if (ReturnValue)
			{
				stringBuilder.Append("Public Function Test() As Object");
			}
			else if (Code.StartsWith("'''async", StringComparison.OrdinalIgnoreCase))
			{
				stringBuilder.Append("Public Async Sub Test()");
			}
			else
			{
				stringBuilder.Append("Public Sub Test()");
			}
			stringBuilder.Append("\r\n");
			stringBuilder.Append(Code);
			stringBuilder.Append("\r\n");
			if (ReturnValue)
			{
				stringBuilder.Append("End Function");
			}
			else
			{
				stringBuilder.Append("End Sub");
			}
			Assembly assembly = o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), "", O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false, "", true);
			if (assembly != null)
			{
				MethodInfo method = assembly.GetType("UserCode").GetMethod("Test");
				try
				{
					if (ReturnValue)
					{
						return method.Invoke(null, null);
					}
					method.Invoke(null, null);
				}
				catch (Exception ex)
				{
					MessageBox.Show("代码执行出错，错误信息：\r\n\r\n" + ex.InnerException.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			return null;
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x0024B218 File Offset: 0x00249418
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void AddConnection(string ConnName, string ConnString)
		{
			OO_00oOO.Connections.Add(ConnName, ConnString);
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x0024B226 File Offset: 0x00249426
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void DeleteConnection(string ConnName)
		{
			OO_00oOO.Connections.Delete(ConnName);
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x0024B233 File Offset: 0x00249433
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool ContainsConnection(string Connname)
		{
			return OO_00oOO.Connections.Contains(Connname);
		}

		/// <summary>
		/// 返货Foxtable主程序的版本
		/// </summary>
		// Token: 0x06005254 RID: 21076 RVA: 0x0024B240 File Offset: 0x00249440
		public static string ApplicationVertion()
		{
			Version version = c.Oo.__O0.().Info.Version;
			return string.Concat(new string[]
			{
				Conversions.ToString(version.Major),
				"-",
				Conversions.ToString(version.Minor),
				"-",
				Conversions.ToString(version.Build)
			});
		}

		/// <summary>
		/// 返回或设置Foxtable主窗口的标题
		/// </summary>
		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x06005255 RID: 21077 RVA: 0x0024B2A2 File Offset: 0x002494A2
		// (set) Token: 0x06005256 RID: 21078 RVA: 0x0024B2AE File Offset: 0x002494AE
		public static string ApplicationTitle
		{
			get
			{
				return Main.OO_O.o..Text;
			}
			set
			{
				Main.OO_O.o..Text = value;
			}
		}

		/// <summary>
		/// 日期型变量，返回在项目属性中设置的项目发布日期
		/// </summary>
		// Token: 0x06005257 RID: 21079 RVA: 0x0024B2BB File Offset: 0x002494BB
		public static DateTime PublishDate()
		{
			return O_O0OO.O0_00o.o0__o..PublishDate;
		}

		/// <summary>
		/// 字符型，用于设置或返回在线升级路径
		/// </summary>
		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06005258 RID: 21080 RVA: 0x0024B2C7 File Offset: 0x002494C7
		// (set) Token: 0x06005259 RID: 21081 RVA: 0x0024B2D3 File Offset: 0x002494D3
		public static string UpdatePath
		{
			get
			{
				return O_O0OO.O0_00o.o0__o..UpdatePath;
			}
			set
			{
				O_O0OO.O0_00o.o0__o..UpdatePath = value;
			}
		}

		/// <summary>
		/// 是否通过互联网升级
		/// </summary>
		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x0600525A RID: 21082 RVA: 0x0024B2E0 File Offset: 0x002494E0
		// (set) Token: 0x0600525B RID: 21083 RVA: 0x0024B2EC File Offset: 0x002494EC
		public static bool RemoteUpdate
		{
			get
			{
				return O_O0OO.O0_00o.o0__o..RemoteUpdate;
			}
			set
			{
				O_O0OO.O0_00o.o0__o..RemoteUpdate = value;
			}
		}

		/// <summary>
		/// 获取计算机的硬件ID
		/// </summary>
		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x0600525C RID: 21084 RVA: 0x0024B2F9 File Offset: 0x002494F9
		[oO0oooo("1545")]
		public static string ComputerId
		{
			get
			{
				return o_o_O0OO_0__.oo00_.0oO_.();
			}
		}

		/// <summary>
		/// 一个集合，包括所有已经安装的打印机的名称
		/// </summary>
		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x0600525D RID: 21085 RVA: 0x0024B300 File Offset: 0x00249500
		[oO0oooo("1601")]
		public static List<string> InstalledPrinters
		{
			get
			{
				List<string> list = new List<string>();
				try
				{
					foreach (object value in PrinterSettings.InstalledPrinters)
					{
						string item = Conversions.ToString(value);
						list.Add(item);
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
				return list;
			}
		}

		/// <summary>
		/// 返回默认打印机的名称
		/// </summary>
		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x0600525E RID: 21086 RVA: 0x0024B364 File Offset: 0x00249564
		public static string DefaultPrinter
		{
			get
			{
				return new PrinterSettings().PrinterName;
			}
		}

		/// <summary>
		/// 获取指定打印机所有可用的纸张类型
		/// </summary>
		/// <param name="PrinterName">打印机名称</param>
		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x0600525F RID: 21087 RVA: 0x0024B370 File Offset: 0x00249570
		public static List<string> GetPaperSources
		{
			get
			{
				PrinterSettings printerSettings = new PrinterSettings();
				printerSettings.PrinterName = A_0;
				List<string> list = new List<string>();
				int num = printerSettings.PaperSources.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					list.Add(printerSettings.PaperSources[i].SourceName);
				}
				return list;
			}
		}

		/// <summary>
		/// 关闭启动的呢过面
		/// </summary>
		// Token: 0x06005260 RID: 21088 RVA: 0x0024B3C2 File Offset: 0x002495C2
		public static void CloseSplashForm()
		{
			Main.OO_O.o. = SplashFormStateEnum.Hide;
		}

		/// <summary>
		/// 是否标记出已经编辑过的单元格
		/// </summary>
		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06005261 RID: 21089 RVA: 0x0024B3CA File Offset: 0x002495CA
		// (set) Token: 0x06005262 RID: 21090 RVA: 0x0024B3D1 File Offset: 0x002495D1
		public static bool MarkModifedCell
		{
			get
			{
				return OO_00oOO.OO.O_O0.;
			}
			set
			{
				OO_00oOO.OO.O_O0. = value;
			}
		}

		/// <summary>
		/// 生成一个数据源链接字符串
		/// </summary>
		/// <param name="ConnectionString">可选参数，用于指定原来的链接字符串</param>
		// Token: 0x06005263 RID: 21091 RVA: 0x0024B3DC File Offset: 0x002495DC
		public static string EditConnectionString(string ConnectionString = "")
		{
			bool visible = Main.ProcessForm.Visible;
			O\u3002\u3000\u3000 o_u3002_u3000_u = new O\u3002\u3000\u3000();
			o_u3002_u3000_u.OO._000_O0o_.().Text = ConnectionString;
			o_u3002_u3000_u.OO._000_O0o_.().Text = "请输入链接字符串:";
			o_u3002_u3000_u.OO._000_O0o_.().Height = o_u3002_u3000_u.OO._000_O0o_.().Height + 30;
			o_u3002_u3000_u.OO_._o_o0_00.().Text = "";
			Main.ProcessForm.Hide();
			Main.OO_O.o. = SplashFormStateEnum.Hide;
			if (o_u3002_u3000_u.ShowDialog() == DialogResult.OK)
			{
				ConnectionString = o_u3002_u3000_u.OO._000_O0o_.().Text;
			}
			return ConnectionString;
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x0024B466 File Offset: 0x00249666
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static List<string> GetTableNamesFromConnection(string ConnectionName)
		{
			return (List<string>)OO_00oOO.Connections[ConnectionName].GetTableNames();
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x0024B47D File Offset: 0x0024967D
		public static double Round2(double value, int decimals)
		{
			return OO_00oOO.O_Oo000.o.(new decimal(value), decimals);
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x0024B48B File Offset: 0x0024968B
		private static double <<EMPTY_NAME>>(decimal A_0, int A_1)
		{
			return Convert.ToDouble(Math.Round(A_0, A_1, MidpointRounding.AwayFromZero));
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x0024B49A File Offset: 0x0024969A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ActiveFoxtable()
		{
			o_o_O0OO_0__.O0_O_o.o_.();
		}

		/// <summary>
		/// 获取硬盘序列号
		/// </summary>
		// Token: 0x06005268 RID: 21096 RVA: 0x0024B4A4 File Offset: 0x002496A4
		public static string HardDiskId()
		{
			StringBuilder stringBuilder = new StringBuilder(0, 500);
			string result;
			try
			{
				if (OO_00oOO.GetHardDiskId(stringBuilder, 0))
				{
					result = stringBuilder.ToString().Trim();
				}
				else if (OO_00oOO.GetHardDiskId(stringBuilder, 1))
				{
					result = stringBuilder.ToString().Trim();
				}
				else if (OO_00oOO.GetHardDiskId(stringBuilder, 2))
				{
					result = stringBuilder.ToString().Trim();
				}
				else if (OO_00oOO.GetHardDiskId(stringBuilder, 3))
				{
					result = stringBuilder.ToString().Trim();
				}
				else
				{
					result = "-1";
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x0024B53C File Offset: 0x0024973C
		public static string IssueName()
		{
			return "开发版";
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x0024B550 File Offset: 0x00249750
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ExportStructure()
		{
			int num;
			int num5;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				StringBuilder stringBuilder = new StringBuilder();
				IL_0F:
				num2 = 3;
				IL_11:
				num2 = 4;
				string text = "\n";
				IL_1A:
				num2 = 5;
				IEnumerator<Foxtable.Table> enumerator = OO_00oOO.Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Foxtable.Table table = enumerator.Current;
					IL_36:
					num2 = 6;
					if (!table.IsRelation)
					{
						IL_44:
						num2 = 8;
						string str = table.Name;
						IL_4F:
						num2 = 9;
						stringBuilder.Append("## [" + str + "]表" + text);
						IL_6C:
						num2 = 10;
						stringBuilder.Append("| 列名 | 列标题 | 列类型 | 长度 | 表达式 |" + text);
						IL_82:
						num2 = 11;
						stringBuilder.Append("| --- | --- |--- | --- | --- |" + text);
						IL_98:
						num2 = 12;
						IEnumerator<Col> enumerator2 = table.Cols.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							Col col = enumerator2.Current;
							IL_B7:
							num2 = 13;
							DataCol dataCol = col.DataCol;
							IL_C3:
							num2 = 14;
							stringBuilder.Append("| " + dataCol.Name + " | ");
							IL_E3:
							num2 = 15;
							if (Operators.CompareString(dataCol.Caption, dataCol.Name, true) != 0)
							{
								IL_FC:
								num2 = 16;
								stringBuilder.Append(dataCol.Caption + " | ");
							}
							else
							{
								IL_119:
								num2 = 18;
								stringBuilder.Append("无 | ");
							}
							IL_128:
							num2 = 19;
							if (dataCol.DataType == typeof(string))
							{
								IL_13E:
								num2 = 20;
								if (dataCol.MaxLength == -1)
								{
									IL_14B:
									num2 = 21;
									stringBuilder.Append("备注型 | - | ");
								}
								else
								{
									IL_15F:
									num2 = 23;
									stringBuilder.Append("字符串型 | " + Conversions.ToString(dataCol.MaxLength) + " | ");
								}
							}
							else
							{
								IL_189:
								num2 = 25;
								if (dataCol.DataType == typeof(DateTime))
								{
									IL_19F:
									num2 = 26;
									stringBuilder.Append("日期型 | - | ");
								}
								else
								{
									IL_1B3:
									num2 = 28;
									if (dataCol.DataType == typeof(bool))
									{
										IL_1C9:
										num2 = 29;
										stringBuilder.Append("逻辑型 | - | ");
									}
									else
									{
										IL_1DD:
										num2 = 31;
										if (dataCol.DataType == typeof(byte))
										{
											IL_1F3:
											num2 = 32;
											stringBuilder.Append("微整数 | - | ");
										}
										else
										{
											IL_207:
											num2 = 34;
											if (dataCol.DataType == typeof(short))
											{
												IL_21D:
												num2 = 35;
												stringBuilder.Append("短整) | - | ");
											}
											else
											{
												IL_231:
												num2 = 37;
												if (dataCol.DataType == typeof(int))
												{
													IL_247:
													num2 = 38;
													stringBuilder.Append("整数 | - | ");
												}
												else
												{
													IL_25B:
													num2 = 40;
													if (dataCol.DataType == typeof(long))
													{
														IL_271:
														num2 = 41;
														stringBuilder.Append("长整数 | - | ");
													}
													else
													{
														IL_282:
														num2 = 43;
														if (dataCol.DataType == typeof(float))
														{
															IL_298:
															num2 = 44;
															stringBuilder.Append("单精度小数 | - | ");
														}
														else
														{
															IL_2A9:
															num2 = 46;
															if (dataCol.DataType == typeof(double))
															{
																IL_2BF:
																num2 = 47;
																stringBuilder.Append("双精度小数 | - | ");
															}
															else
															{
																IL_2D0:
																num2 = 49;
																if (dataCol.DataType == typeof(decimal))
																{
																	IL_2E6:
																	num2 = 50;
																	stringBuilder.Append("高精度小数 | - | ");
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
							IL_2F5:
							num2 = 51;
							if (Operators.CompareString(dataCol.Expression, "", true) > 0)
							{
								IL_30D:
								num2 = 52;
								stringBuilder.Append(dataCol.Expression);
							}
							IL_31E:
							num2 = 53;
							stringBuilder.Append(" |" + text);
							IL_334:
							num2 = 54;
						}
						IL_343:
						num2 = 55;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					IL_351:
					num2 = 56;
				}
				IL_360:
				num2 = 57;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_36E:
				num2 = 58;
				IEnumerator enumerator3 = O_O0OO.OOOo.oo_OOOO_0.().Relations.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					object obj = enumerator3.Current;
					DataRelation dataRelation = (DataRelation)obj;
					IL_395:
					num2 = 59;
					stringBuilder.Append("### 关联名称: " + dataRelation.RelationName + text + text);
					IL_3B4:
					num2 = 60;
					stringBuilder.Append("父表: " + dataRelation.ParentTable.TableName + text);
					IL_3D6:
					num2 = 61;
					stringBuilder.Append("子表: " + dataRelation.ChildTable.TableName + text);
					IL_3F8:
					num2 = 62;
					string text2 = "";
					IL_402:
					num2 = 63;
					string str2 = "";
					IL_40C:
					num2 = 64;
					int num3 = dataRelation.ParentColumns.Length - 1;
					for (int i = 0; i <= num3; i++)
					{
						IL_421:
						num2 = 65;
						text2 = text2 + "," + dataRelation.ParentColumns[i].ColumnName;
						IL_441:
						num2 = 66;
						str2 = str2 + "," + dataRelation.ChildColumns[i].ColumnName;
						IL_461:
						num2 = 67;
					}
					IL_470:
					num2 = 68;
					stringBuilder.Append("父表关联列: " + text2.Trim(new char[]
					{
						','
					}) + text);
					IL_498:
					num2 = 69;
					stringBuilder.Append("父表关联列: " + text2.Trim(new char[]
					{
						','
					}) + text);
					IL_4C0:
					num2 = 70;
				}
				IL_4CF:
				num2 = 71;
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
				IL_4E7:
				num2 = 72;
				OO_00oOO.FileSys.WriteAllText(OO_00oOO.ProjectPath + "Structure.md", stringBuilder.ToString(), false);
				IL_50A:
				num2 = 73;
				Process.Start(OO_00oOO.ProjectPath + "Structure.md");
				IL_522:
				goto IL_69C;
				IL_527:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_65D:
				goto IL_691;
				IL_65F:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_66F:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_65F;
			}
			IL_691:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_69C:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x0024BC20 File Offset: 0x00249E20
		internal static void <<EMPTY_NAME>>(OO_00oOO.OoOO A_0 = OO_00oOO.OoOO.O_Oo_0.0., string A_1 = "")
		{
			int num;
			int num8;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!O_O0OO.O0_00o.o0__o..o0o_oO0_o.O.)
				{
					goto IL_38;
				}
				IL_15:
				num2 = 3;
				if (Project.oOOoOOOo._O.())
				{
					goto IL_38;
				}
				IL_1E:
				num2 = 4;
				MessageBox.Show(O_O0OO.OO0._0.(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_E3B;
				IL_38:
				num2 = 6;
				StringBuilder stringBuilder = new StringBuilder();
				IL_41:
				num2 = 7;
				ProjectProperty projectProperty = new ProjectProperty();
				IL_4A:
				num2 = 8;
				string text = "\r\n\r\n";
				IL_53:
				num2 = 9;
				string text2 = "\r\n";
				IL_5D:
				num2 = 10;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"ProjectCode",
					o0_O.O_o000_O.0.
				});
				IL_97:
				num2 = 11;
				if (A_0 != OO_00oOO.OoOO.O_Oo_0.0. && A_0 != OO_00oOO.OoOO.OO__oo0_O.O0_O.)
				{
					goto IL_20D;
				}
				IL_A4:
				num2 = 12;
				if (dataRow == null)
				{
					goto IL_DC;
				}
				IL_AB:
				num2 = 13;
				string text3 = Conversions.ToString(dataRow["Config"]);
				IL_C1:
				num2 = 14;
				text3 = O_O0OO.OoO_00._.(text3, null);
				IL_CE:
				num2 = 15;
				o_O_o_oOoo__.OOOO_OO._oo.(projectProperty, text3, '\v');
				IL_DC:
				num2 = 16;
				PropertyInfo[] properties = projectProperty.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
				IL_EF:
				num2 = 17;
				bool flag;
				foreach (PropertyInfo propertyInfo in properties)
				{
					IL_105:
					num2 = 18;
					if (propertyInfo.GetSetMethod() != null && !O00OOOo_O0_O.O.0o_0_o.(propertyInfo))
					{
						IL_120:
						num2 = 19;
						if (O00OOOo_O0_O.oO00o0._OoO00o.(propertyInfo))
						{
							IL_12F:
							num2 = 20;
							string text4 = "";
							IL_139:
							num2 = 21;
							EventString eventString = (EventString)propertyInfo.GetValue(projectProperty, null);
							IL_14D:
							num2 = 22;
							if (eventString != null && eventString.Count > 0)
							{
								IL_15E:
								num2 = 23;
								text4 = eventString[0].Trim();
							}
							IL_170:
							num2 = 24;
							if (Operators.CompareString(text4, "", true) != 0)
							{
								IL_182:
								num2 = 26;
								if (!flag)
								{
									IL_188:
									num2 = 27;
									stringBuilder.Append("# 项目事件" + text);
									IL_19F:
									num2 = 28;
									flag = true;
								}
								IL_1A4:
								num2 = 29;
								stringBuilder.Append("#### [" + propertyInfo.Name + "]事件:" + text);
								IL_1C7:
								num2 = 30;
								stringBuilder.Append("```vbnet" + text2 + text4 + text2);
								IL_1E2:
								num2 = 31;
								stringBuilder.Append("```" + text2);
							}
						}
					}
					IL_1F9:
					num2 = 32;
				}
				IL_20D:
				num2 = 33;
				flag = false;
				IL_212:
				num2 = 34;
				if (A_0 != OO_00oOO.OoOO.O_Oo_0.0. && A_0 != OO_00oOO.OoOO.O_0Ooo0o._.)
				{
					goto IL_377;
				}
				IL_21F:
				num2 = 35;
				DataRow[] array2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Select("[Type] = " + Conversions.ToString(3));
				IL_24D:
				num2 = 36;
				foreach (DataRow dataRow2 in array2)
				{
					IL_263:
					num2 = 37;
					TimerProperty timerProperty = new TimerProperty();
					IL_26D:
					num2 = 38;
					if (!dataRow2.IsNull("Config"))
					{
						IL_27E:
						num2 = 39;
						o_O_o_oOoo__.OOOO_OO._oo.(timerProperty, O00.oO_.0o_oo_0O_.(Conversions.ToString(dataRow2["Config"]), "Timer", O_O0OO.O_O._Oo.()), '\v');
					}
					IL_2AA:
					num2 = 40;
					if (timerProperty.Tick != null && Operators.CompareString(timerProperty.Tick[0], "", true) > 0)
					{
						IL_2D7:
						num2 = 41;
						if (!flag)
						{
							IL_2DD:
							num2 = 42;
							stringBuilder.Append("# 计划管理" + text);
							IL_2F4:
							num2 = 43;
							flag = true;
						}
						IL_2F9:
						num2 = 44;
						stringBuilder.Append("#### [" + Conversions.ToString(dataRow2["Name"]) + "]事件:" + text);
						IL_326:
						num2 = 45;
						stringBuilder.Append("```vbnet " + text2 + timerProperty.Tick[0] + text2);
						IL_34C:
						num2 = 46;
						stringBuilder.Append("```" + text2);
					}
					IL_363:
					num2 = 47;
				}
				IL_377:
				num2 = 48;
				flag = false;
				IL_37C:
				num2 = 49;
				if (A_0 != OO_00oOO.OoOO.O_Oo_0.0. && A_0 != OO_00oOO.OoOO.oOo_o.oO0oo0o.)
				{
					goto IL_5BD;
				}
				IL_389:
				num2 = 50;
				IEnumerator<DataTable> enumerator = OO_00oOO.DataTables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataTable dataTable = enumerator.Current;
					IL_3A6:
					num2 = 51;
					flag = false;
					IL_3AB:
					num2 = 52;
					if (Operators.CompareString(A_1, "", true) <= 0 || Operators.CompareString(dataTable.Name, A_1, true) == 0)
					{
						IL_3D0:
						num2 = 54;
						DataTableProperty dataTableProperty = new DataTableProperty();
						IL_3DA:
						num2 = 55;
						DataRow dataRow3 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
						{
							dataTable.Name,
							""
						});
						IL_415:
						num2 = 56;
						if (dataRow3 != null && !dataRow3.IsNull("Code"))
						{
							IL_430:
							num2 = 57;
							text3 = Conversions.ToString(dataRow3["Code"]);
							IL_446:
							num2 = 58;
							text3 = DataTable.o.o00O.(text3);
							IL_452:
							num2 = 59;
							o_O_o_oOoo__.OOOO_OO._oo.(dataTableProperty, text3, '\v');
							IL_460:
							num2 = 62;
							properties = dataTableProperty.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
							IL_473:
							num2 = 63;
							foreach (PropertyInfo propertyInfo in properties)
							{
								IL_489:
								num2 = 64;
								if (propertyInfo.GetSetMethod() != null && !O00OOOo_O0_O.O.0o_0_o.(propertyInfo))
								{
									IL_4A4:
									num2 = 65;
									if (O00OOOo_O0_O.oO00o0._OoO00o.(propertyInfo))
									{
										IL_4B3:
										num2 = 66;
										string text5 = "";
										IL_4BD:
										num2 = 67;
										EventString eventString2 = (EventString)propertyInfo.GetValue(dataTableProperty, null);
										IL_4D1:
										num2 = 68;
										if (eventString2 != null && eventString2.Count > 0)
										{
											IL_4E2:
											num2 = 69;
											text5 = eventString2[0].Trim();
										}
										IL_4F4:
										num2 = 70;
										if (Operators.CompareString(text5, "", true) != 0)
										{
											IL_509:
											num2 = 72;
											if (!flag)
											{
												IL_50F:
												num2 = 73;
												flag = true;
												IL_514:
												num2 = 74;
												stringBuilder.Append("# [" + dataTable.Name + "]表" + text);
											}
											IL_537:
											num2 = 75;
											stringBuilder.Append("#### [" + propertyInfo.Name + "]事件:" + text);
											IL_55A:
											num2 = 76;
											stringBuilder.Append("```vbnet " + text2 + text5 + text2);
											IL_575:
											num2 = 77;
											stringBuilder.Append("```" + text2);
										}
									}
								}
								IL_58C:
								num2 = 78;
							}
						}
					}
					IL_5A0:
					num2 = 79;
				}
				IL_5AF:
				num2 = 80;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_5BD:
				num2 = 81;
				flag = false;
				IL_5C2:
				num2 = 82;
				DataTable dataTable2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()];
				IL_5DB:
				num2 = 83;
				DataTable dataTable3 = new DataTable();
				IL_5E5:
				num2 = 84;
				dataTable3.Columns.Add("Name", typeof(string));
				IL_604:
				num2 = 85;
				dataTable3.Columns.Add("Code", typeof(string));
				IL_623:
				num2 = 86;
				if (A_0 != OO_00oOO.OoOO.O_Oo_0.0. && A_0 != OO_00oOO.OoOO.Oo__Ooo0_.o_0o.)
				{
					goto IL_71B;
				}
				IL_630:
				num2 = 87;
				DataRow[] array5 = dataTable2.Select("[Type] = " + Conversions.ToString(229) + "or [Type] = " + Conversions.ToString(233));
				IL_65F:
				num2 = 88;
				foreach (DataRow dataRow4 in array5)
				{
					IL_675:
					num2 = 89;
					string text6 = dataRow4["Name"].ToString();
					IL_68B:
					num2 = 90;
					if (Operators.CompareString(A_1, "", true) <= 0 || Operators.CompareString(text6, A_1, true) == 0)
					{
						IL_6A8:
						num2 = 92;
						stringBuilder.Append("# [" + text6 + "]窗口" + text);
						IL_6C6:
						num2 = 93;
						int length = stringBuilder.Length;
						IL_6D2:
						num2 = 94;
						OO_00oOO.oo0oOO.o.(stringBuilder, dataRow4, dataTable3, text6);
						IL_6E2:
						num2 = 95;
						if (stringBuilder.Length == length)
						{
							IL_6F0:
							num2 = 96;
							stringBuilder.Append("无代码" + text2);
						}
					}
					IL_707:
					num2 = 97;
				}
				IL_71B:
				num2 = 98;
				if (A_0 != OO_00oOO.OoOO.O_Oo_0.0. && A_0 != OO_00oOO.OoOO.Oooo00o.Oo0O.)
				{
					goto IL_8F8;
				}
				IL_728:
				num2 = 99;
				stringBuilder.Append("# 自定义函数" + text);
				IL_73F:
				num2 = 100;
				DataRow[] array7 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o.00_0o0__OoO.()].Select("[Type] = " + Conversions.ToString(9) + " And (SubString([name],1,2) = '![' And SubString([name],len([Name])-1,2) = ']!') = False", "", DataViewRowState.CurrentRows);
				IL_77A:
				num2 = 101;
				foreach (DataRow dataRow5 in array7)
				{
					IL_790:
					num2 = 102;
					if (!dataRow5.IsNull("Config"))
					{
						IL_7A4:
						num2 = 103;
						if (!dataRow5.IsNull("Path"))
						{
							IL_7B5:
							num2 = 104;
							stringBuilder.Append("## 类别[ " + dataRow5["Path"].ToString().Replace("\t", "\\") + "\\" + text);
						}
						IL_7F1:
						num2 = 105;
						stringBuilder.Append("#### [" + dataRow5["name"].ToString() + "]函数" + text);
						IL_81E:
						num2 = 106;
						string text7 = dataRow5["Config"].ToString();
						IL_834:
						num2 = 107;
						string a_ = O_O0OO.O_O._Oo.();
						IL_83E:
						num2 = 108;
						if (text7.StartsWith("[") && text7.EndsWith("]"))
						{
							IL_85D:
							num2 = 109;
							a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5);
							IL_87F:
							num2 = 110;
							text7 = text7.TrimStart(new char[]
							{
								'['
							}).TrimEnd(new char[]
							{
								']'
							});
						}
						IL_8A6:
						num2 = 111;
						stringBuilder.Append("```vbnet " + text2 + O00.oO_.0o_oo_0O_.(text7, "UserFunction", a_) + text2);
						IL_8CD:
						num2 = 112;
						stringBuilder.Append("```" + text2);
					}
					IL_8E4:
					num2 = 113;
				}
				IL_8F8:
				num2 = 114;
				if (A_0 != OO_00oOO.OoOO.O_Oo_0.0. && A_0 != OO_00oOO.OoOO.O_oOO0._O_0.)
				{
					goto IL_A88;
				}
				IL_905:
				num2 = 115;
				stringBuilder.Append("# 全局代码" + text);
				IL_91C:
				num2 = 116;
				DataRow[] array9 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Select("[Type] = " + Conversions.ToString(19), "", DataViewRowState.CurrentRows);
				IL_952:
				num2 = 117;
				foreach (DataRow dataRow6 in array9)
				{
					IL_968:
					num2 = 118;
					if (!dataRow6.IsNull("Config"))
					{
						IL_97C:
						num2 = 119;
						stringBuilder.Append("#### " + dataRow6["Name"].ToString() + text);
						IL_9A4:
						num2 = 120;
						text3 = dataRow6["Config"].ToString();
						IL_9BA:
						num2 = 121;
						string a_2 = O_O0OO.O_O._Oo.();
						IL_9C4:
						num2 = 122;
						if (text3.StartsWith("[") && text3.EndsWith("]"))
						{
							IL_9E3:
							num2 = 123;
							text3 = text3.TrimStart(new char[]
							{
								'['
							}).TrimEnd(new char[]
							{
								']'
							});
							IL_A0A:
							num2 = 124;
							a_2 = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5);
						}
						IL_A2C:
						num2 = 125;
						text3 = O00.oO_.0o_oo_0O_.(text3, "API", a_2);
						IL_A3F:
						num2 = 126;
						stringBuilder.Append("```vbnet " + text2 + text3 + text2);
						IL_A5A:
						num2 = 127;
						stringBuilder.Append("```" + text2);
					}
					IL_A71:
					num2 = 128;
				}
				IL_A88:
				num2 = 129;
				if (A_0 != OO_00oOO.OoOO.O_Oo_0.0. && A_0 != OO_00oOO.OoOO.o.0_O.)
				{
					goto IL_DF9;
				}
				IL_A98:
				num2 = 130;
				stringBuilder.Append("# 菜单事件" + text);
				IL_AB2:
				num2 = 131;
				dataTable2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()];
				IL_ACE:
				num2 = 132;
				foreach (DataRow dataRow7 in dataTable2.Select("", "", DataViewRowState.CurrentRows))
				{
					IL_AF8:
					num2 = 133;
					string text8 = "";
					IL_B05:
					num2 = 134;
					if (!dataRow7.IsNull("Code"))
					{
						IL_B1C:
						num2 = 135;
						text8 = Conversions.ToString(dataRow7["Code"]);
						IL_B35:
						num2 = 136;
						string a_3 = ooO0__OO.O_Oo00oO.Ooo.();
						IL_B42:
						num2 = 137;
						if (text8.StartsWith("{") && text8.EndsWith("}"))
						{
							IL_B64:
							num2 = 138;
							text8 = text8.TrimStart(new char[]
							{
								'{'
							}).TrimEnd(new char[]
							{
								'}'
							});
							IL_B8E:
							num2 = 139;
							a_3 = Oo00.ooO.ooo.();
						}
						IL_B9B:
						num2 = 140;
						text8 = O00.oO_.0o_oo_0O_.(text8, ooO0__OO.O_Oo00oO.Ooo.(), a_3);
					}
					IL_BB1:
					num2 = 141;
					if (Operators.CompareString(text8, "", true) != 0)
					{
						IL_BC9:
						num2 = 143;
						string[] array12 = text8.Split(new char[]
						{
							'\v'
						});
						IL_BE3:
						num2 = 144;
						int num4 = array12.Length - 2;
						for (int num5 = 0; num5 <= num4; num5 += 2)
						{
							IL_BF9:
							num2 = 145;
							if (Operators.CompareString(array12[num5 + 1].Trim(new char[]
							{
								'\n',
								'\r',
								' '
							}), "", true) != 0)
							{
								IL_C29:
								num2 = 147;
								DataRow dataRow8 = dataTable3.NewRow();
								IL_C38:
								num2 = 148;
								dataRow8["Name"] = array12[num5];
								IL_C4F:
								num2 = 149;
								dataRow8["Code"] = array12[num5 + 1] + text;
								IL_C6F:
								num2 = 150;
								dataTable3.Rows.Add(dataRow8);
							}
							IL_C83:
							num2 = 151;
						}
						IL_C98:
						num2 = 152;
						if (dataTable3.Rows.Count > 0)
						{
							IL_CAD:
							num2 = 153;
							stringBuilder.Append(string.Concat(new string[]
							{
								"## 名称 [",
								dataRow7["Name"].ToString(),
								"] ,类型[",
								((RibbonItemTypeEnum)Conversions.ToInteger(dataRow7["Type"])).ToString(),
								"]",
								text
							}));
						}
						IL_D1A:
						num2 = 154;
						foreach (DataRow dataRow9 in dataTable3.Select("", "Name"))
						{
							IL_D42:
							num2 = 155;
							stringBuilder.Append("#### 事件[" + dataRow9["Name"].ToString() + "]" + text);
							IL_D72:
							num2 = 156;
							stringBuilder.Append("```vbnet " + text2 + dataRow9["Code"].ToString() + text2);
							IL_D9F:
							num2 = 157;
							stringBuilder.Append("```" + text2);
							IL_DB9:
							num2 = 158;
						}
						IL_DD0:
						num2 = 159;
						dataTable3.Rows.Clear();
					}
					IL_DE2:
					num2 = 160;
				}
				IL_DF9:
				num2 = 161;
				OO_00oOO.FileSys.WriteAllText(OO_00oOO.ProjectPath + "EventCode.md", stringBuilder.ToString(), false);
				IL_E20:
				num2 = 162;
				Process.Start(OO_00oOO.ProjectPath + "EventCode.md");
				IL_E3B:
				goto IL_1119;
				IL_E40:
				int num7 = num8 + 1;
				num8 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7);
				IL_10DA:
				goto IL_110E;
				IL_10DC:
				num8 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_10EC:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num8 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_10DC;
			}
			IL_110E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1119:
			if (num8 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x0024CD6C File Offset: 0x0024AF6C
		private static void <<EMPTY_NAME>>(StringBuilder A_0, DataRow A_1, DataTable A_2, string A_3)
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
				string text = "\r\n\r\n";
				IL_0F:
				num2 = 3;
				string text2 = "\r\n";
				IL_18:
				num2 = 4;
				string text3 = "";
				IL_21:
				num2 = 5;
				string a_ = "";
				IL_2A:
				num2 = 6;
				if (A_1.IsNull("Code"))
				{
					goto IL_BC;
				}
				IL_3C:
				num2 = 7;
				text3 = Conversions.ToString(A_1["Code"]);
				IL_50:
				num2 = 8;
				a_ = ooO0__OO.O_Oo00oO.Ooo.();
				IL_59:
				num2 = 9;
				if (!text3.StartsWith("{") || !text3.EndsWith("}"))
				{
					goto IL_A9;
				}
				IL_78:
				num2 = 10;
				text3 = text3.TrimStart(new char[]
				{
					'{'
				}).TrimEnd(new char[]
				{
					'}'
				});
				IL_9F:
				num2 = 11;
				a_ = Oo00.ooO.ooo.();
				IL_A9:
				num2 = 12;
				text3 = O00.oO_.0o_oo_0O_.(text3, ooO0__OO.O_Oo00oO.Ooo.(), a_);
				IL_BC:
				num2 = 13;
				if (Operators.CompareString(text3, "", true) == 0)
				{
					goto IL_2E5;
				}
				IL_D1:
				num2 = 15;
				string[] array = text3.Split(new char[]
				{
					'\v'
				});
				IL_E8:
				num2 = 16;
				int num3 = array.Length - 2;
				for (int i = 0; i <= num3; i += 2)
				{
					IL_F8:
					num2 = 17;
					if (Operators.CompareString(array[i + 1].Trim(new char[]
					{
						'\n',
						'\r',
						' '
					}), "", true) != 0)
					{
						IL_125:
						num2 = 19;
						DataRow dataRow = A_2.NewRow();
						IL_130:
						num2 = 20;
						dataRow["Name"] = array[i];
						IL_144:
						num2 = 21;
						dataRow["Code"] = array[i + 1];
						IL_15A:
						num2 = 22;
						A_2.Rows.Add(dataRow);
					}
					IL_16A:
					num2 = 23;
				}
				IL_17C:
				num2 = 24;
				if (A_2.Rows.Count <= 0)
				{
					goto IL_238;
				}
				IL_190:
				num2 = 25;
				if (Conversions.ToInteger(A_1["type"]) == 229 || Conversions.ToInteger(A_1["type"]) == 233)
				{
					goto IL_238;
				}
				IL_1C4:
				num2 = 27;
				string str = string.Concat(new string[]
				{
					"控件名称[",
					A_1["Name"].ToString(),
					"], 控件类型[",
					((ControlTypeEnum)Conversions.ToInteger(A_1["type"])).ToString(),
					"]"
				});
				IL_221:
				num2 = 28;
				A_0.Append("## " + str + text);
				IL_238:
				num2 = 29;
				foreach (DataRow dataRow2 in A_2.Select("", "Name"))
				{
					IL_259:
					num2 = 30;
					A_0.Append("#### [" + dataRow2["Name"].ToString() + "]事件:" + text);
					IL_284:
					num2 = 31;
					A_0.Append("```vbnet " + text2 + dataRow2["Code"].ToString() + text2);
					IL_2AD:
					num2 = 32;
					A_0.Append("```" + text2);
					IL_2C3:
					num2 = 33;
				}
				IL_2D7:
				num2 = 34;
				A_2.Rows.Clear();
				IL_2E5:
				num2 = 35;
				DataRow[] childRows = A_1.GetChildRows("Component", DataRowVersion.Current);
				IL_2FA:
				num2 = 36;
				foreach (DataRow a_2 in childRows)
				{
					IL_30D:
					num2 = 37;
					OO_00oOO.oo0oOO.o.(A_0, a_2, A_2, A_3);
					IL_31A:
					num2 = 38;
				}
				IL_32B:
				goto IL_419;
				IL_330:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_3DA:
				goto IL_40E;
				IL_3DC:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_3EC:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3DC;
			}
			IL_40E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_419:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x0600526D RID: 21101 RVA: 0x0024D1B8 File Offset: 0x0024B3B8
		[oO0oooo("2051")]
		public static RegistryProxy Registry
		{
			get
			{
				return c.OOOOO.o.().Registry;
			}
		}

		/// <summary>
		/// 用于显示一个对话框，用于输入密码
		/// </summary>
		/// <param name="passWord">用于接收密码的变量</param>
		/// <param name="Text">对话框标题</param>
		/// <param name="Description">设置对话框说明</param>
		// Token: 0x0600526E RID: 21102 RVA: 0x0024D1C4 File Offset: 0x0024B3C4
		[oO0oooo("2435")]
		public static bool InputPassword(ref string passWord, string Text, string Description)
		{
			o\u30000\u3002 o_u30000_u = new o\u30000\u3002();
			C1TextBox c1TextBox = new C1TextBox();
			c1TextBox.Width = 399;
			c1TextBox.Location = new Point(12, 77);
			c1TextBox.PasswordChar = '*';
			o_u30000_u.Controls.Add(c1TextBox);
			o_u30000_u.Text = Text;
			o_u30000_u.oo0OO.0O0_0.().Text = Description;
			c1TextBox.Value = passWord;
			c1TextBox.Select();
			Main.OO_O.o..OOoo___.0.(o_u30000_u.Controls, "(default)");
			bool result;
			if (o_u30000_u.ShowDialog() == DialogResult.OK)
			{
				if (c1TextBox.Value == DBNull.Value)
				{
					passWord = null;
				}
				else
				{
					passWord = c1TextBox.Text;
				}
				Main.OO_O.o..o0oO_O.0Oo_00.(o_u30000_u.Controls);
				result = true;
			}
			else
			{
				Main.OO_O.o..o0oO_O.0Oo_00.(o_u30000_u.Controls);
				result = false;
			}
			return result;
		}

		/// <summary>
		/// 显示一个对话框，获得用户输入的单个值
		/// </summary>
		/// <param name="Value">用于接收设置的变量</param>
		/// <param name="Text">对话框标题</param>
		/// <param name="Description">设置对话框说明</param>
		// Token: 0x0600526F RID: 21103 RVA: 0x0024D28B File Offset: 0x0024B48B
		[oO0oooo("2063")]
		public static bool InputValue(ref object Value, string Text, string Description)
		{
			return OO_00oOO.OOOoo_._o.(ref Value, Text, Description, false, "", false);
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x0024D29C File Offset: 0x0024B49C
		[oO0oooo("2063")]
		public static bool InputValue(ref object Value, string Text, string Description, bool MultiLine)
		{
			return OO_00oOO.OOOoo_._o.(ref Value, Text, Description, MultiLine, "", false);
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x0024D2AD File Offset: 0x0024B4AD
		[oO0oooo("2063")]
		public static bool InputValue(ref object Value, string Text, string Description, string Items)
		{
			return OO_00oOO.OOOoo_._o.(ref Value, Text, Description, false, Items, false);
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x0024D2BA File Offset: 0x0024B4BA
		[oO0oooo("2063")]
		public static bool InputValue(ref object Value, string Text, string Description, string Items, bool MultiSelect)
		{
			return OO_00oOO.OOOoo_._o.(ref Value, Text, Description, false, Items, MultiSelect);
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x0024D2C8 File Offset: 0x0024B4C8
		[oO0oooo("2063")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		private static bool <<EMPTY_NAME>>(ref object A_0, string A_1, string A_2, bool A_3, string A_4, bool A_5)
		{
			o\u30000\u3002 o_u30000_u = new o\u30000\u3002();
			C1TextBox c1TextBox;
			if (A_0 == null)
			{
				c1TextBox = new C1TextBox();
			}
			else
			{
				string name = A_0.GetType().Name;
				if (Operators.CompareString(name, "DateTime", true) == 0)
				{
					c1TextBox = new O0OO_oo0o();
				}
				else if (Operators.CompareString(name, "Byte", true) == 0 || Operators.CompareString(name, "Int16", true) == 0 || Operators.CompareString(name, "Int32", true) == 0 || Operators.CompareString(name, "Int64", true) == 0 || Operators.CompareString(name, "Single", true) == 0 || Operators.CompareString(name, "Double", true) == 0 || Operators.CompareString(name, "Decimal", true) == 0)
				{
					c1TextBox = new C1NumericEdit();
				}
				else if (Operators.CompareString(A_4, "", true) > 0)
				{
					if (!A_5)
					{
						C1ComboBox c1ComboBox = new C1ComboBox();
						foreach (string value in A_4.Split(new char[]
						{
							'|'
						}))
						{
							c1ComboBox.Items.Add(value);
						}
						c1TextBox = c1ComboBox;
					}
					else
					{
						O0oo000oO0oo_ o0oo000oO0oo_ = new O0oo000oO0oo_();
						o0oo000oO0oo_.Height += 3;
						foreach (string item in A_4.Split(new char[]
						{
							'|'
						}))
						{
							o0oo000oO0oo_.o_0Oo.o_.().Add(item);
						}
						c1TextBox = o0oo000oO0oo_;
					}
				}
				else
				{
					c1TextBox = new C1TextBox();
				}
			}
			if (A_3 && Operators.CompareString(c1TextBox.GetType().Name, "C1TextBox", true) == 0)
			{
				c1TextBox.Multiline = true;
				o_u30000_u.Height = o_u30000_u.Height + 60 - c1TextBox.Height;
				c1TextBox.Height = 60;
				o_u30000_u.AcceptButton = null;
			}
			c1TextBox.Width = 399;
			c1TextBox.Location = new Point(12, 77);
			o_u30000_u.Controls.Add(c1TextBox);
			Main.OO_O.o..OOoo___.0.(o_u30000_u.Controls, "(default)");
			o_u30000_u.Text = A_1;
			o_u30000_u.oo0OO.0O0_0.().Text = A_2;
			c1TextBox.Value = RuntimeHelpers.GetObjectValue(A_0);
			c1TextBox.Select();
			bool result;
			if (o_u30000_u.ShowDialog() == DialogResult.OK)
			{
				if (c1TextBox.Value == DBNull.Value)
				{
					A_0 = null;
				}
				else
				{
					A_0 = RuntimeHelpers.GetObjectValue(c1TextBox.Value);
				}
				Main.OO_O.o..o0oO_O.0Oo_00.(o_u30000_u.Controls);
				result = true;
			}
			else
			{
				Main.OO_O.o..o0oO_O.0Oo_00.(o_u30000_u.Controls);
				result = false;
			}
			return result;
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x0024D534 File Offset: 0x0024B734
		private static bool <<EMPTY_NAME>>(ref object A_0, string A_1, string A_2, bool A_3, string A_4)
		{
			return 100 - DateTime.Now.Second > 60;
		}

		/// <summary>
		/// 用于判断文件是否已经打开
		/// </summary>
		/// <param name="FName">文件名，含路径</param>
		// Token: 0x06005275 RID: 21109 RVA: 0x0024D558 File Offset: 0x0024B758
		[oO0oooo("2126")]
		public static bool FileIsOpened(string FName)
		{
			if (OO_00oOO.FileSys.FileExists(FName))
			{
				try
				{
					FileStream fileStream = new FileStream(FName, FileMode.Open, FileAccess.Read, FileShare.None);
					fileStream.Close();
					fileStream.Dispose();
				}
				catch (Exception ex)
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// 返回底层主窗口
		/// </summary>
		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06005276 RID: 21110 RVA: 0x0024D5AC File Offset: 0x0024B7AC
		public static Form BaseMainForm
		{
			get
			{
				return Main.OO_O.o.;
			}
		}

		/// <summary>
		/// 一个逻辑型的全局变量，用于设置是否显示表标题
		/// </summary>
		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06005277 RID: 21111 RVA: 0x0024D5B3 File Offset: 0x0024B7B3
		// (set) Token: 0x06005278 RID: 21112 RVA: 0x0024D5C4 File Offset: 0x0024B7C4
		[oO0oooo("2306")]
		public static bool TableCaptionVisible
		{
			get
			{
				return Main.OO_O.o..OO_O_0Oo.___o.().ShowTabs;
			}
			set
			{
				Main.OO_O.o..OO_O_0Oo.___o.().ShowTabs = value;
			}
		}

		/// <summary>
		/// 是否显示关闭表按钮
		/// </summary>
		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06005279 RID: 21113 RVA: 0x0024D5D6 File Offset: 0x0024B7D6
		// (set) Token: 0x0600527A RID: 21114 RVA: 0x0024D5E7 File Offset: 0x0024B7E7
		[oO0oooo("2765")]
		public static bool ShowCloseButton
		{
			get
			{
				return Main.OO_O.o..OO_O_0Oo.___o.().CanCloseTabs;
			}
			set
			{
				Main.OO_O.o..OO_O_0Oo.___o.().CanCloseTabs = value;
			}
		}

		/// <summary>
		/// 返回一个整数，单位为毫秒，表示用户已经有多长时间没有操作计算机
		/// </summary>
		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x0600527B RID: 21115 RVA: 0x0024D5FC File Offset: 0x0024B7FC
		[oO0oooo("0665")]
		public static long LastInputTickCount
		{
			get
			{
				ooO.o0O_ o0O_;
				o0O_.oo.00O0__o. = Microsoft.VisualBasic.Strings.Len(o0O_);
				long result;
				if (ooO.GetLastInputInfo(ref o0O_) != 0)
				{
					result = (long)(Environment.TickCount - o0O_.O.0_O0O.);
				}
				return result;
			}
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x0024D634 File Offset: 0x0024B834
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void CreateBlankAccessFile()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Access(*.mdb)|*.MDB";
			if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
			{
				if (c.OOOOO.o.().FileSystem.FileExists(saveFileDialog.FileName))
				{
					c.OOOOO.o.().FileSystem.DeleteFile(saveFileDialog.FileName);
				}
				CatalogClass catalogClass = new CatalogClass();
				((_Catalog)catalogClass).Create(Oo00.o00.0OO.(saveFileDialog.FileName));
				((Connection)((_Catalog)catalogClass).ActiveConnection).Close();
			}
		}

		/// <summary>
		/// 一个集合，包括所有用户
		/// </summary>
		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x0600527D RID: 21117 RVA: 0x0024D6AD File Offset: 0x0024B8AD
		[oO0oooo("0609")]
		public static UserInfos Users
		{
			get
			{
				if (OO_00oOO.a == null)
				{
					OO_00oOO.a = new UserInfos();
				}
				return OO_00oOO.a;
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x0600527E RID: 21118 RVA: 0x0024D6C5 File Offset: 0x0024B8C5
		public static FoxSMSControl FoxSMS
		{
			get
			{
				if (OO_00oOO.OO._ooO. == null)
				{
					OO_00oOO.OO._ooO. = new FoxSMSControl();
				}
				return OO_00oOO.OO._ooO.;
			}
		}

		/// <summary>
		/// 压缩指定的Access文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		/// <param name="PassWord">可选参数，用于设置Access文件的密码</param>
		/// <param name="backup">可选参数，是否在压缩前备份文件</param>
		// Token: 0x0600527F RID: 21119 RVA: 0x0024D6E0 File Offset: 0x0024B8E0
		[oO0oooo("1272")]
		public static bool CompactAccessFile(string FileName, string PassWord = "", bool backup = true)
		{
			JetEngine jetEngine = new JetEngineClass();
			string tempFileName = c.OOOOO.o.().FileSystem.GetTempFileName();
			string extension = Path.GetExtension(FileName);
			if (backup)
			{
				c.OOOOO.o.().FileSystem.CopyFile(FileName, FileName + ".bak", true);
			}
			string text;
			if (Operators.CompareString(extension, ".accdb", true) == 0)
			{
				text = "Microsoft.ACE.OLEDB.12.0";
			}
			else
			{
				text = "Microsoft.Jet.OLEDB.4.0";
			}
			string sourceConnection = string.Concat(new string[]
			{
				"Provider=",
				text,
				";Data Source=",
				FileName,
				";Jet OLEDB:Database Password=",
				PassWord
			});
			OleDbConnectionStringBuilder oleDbConnectionStringBuilder = new OleDbConnectionStringBuilder();
			oleDbConnectionStringBuilder.Provider = text;
			oleDbConnectionStringBuilder.DataSource = tempFileName;
			oleDbConnectionStringBuilder.Add("Jet OLEDB:Database Password", PassWord);
			oleDbConnectionStringBuilder.Add("Jet OLEDB:Engine Type", 5);
			string connectionString = oleDbConnectionStringBuilder.ConnectionString;
			try
			{
				c.OOOOO.o.().FileSystem.DeleteFile(tempFileName);
				jetEngine.CompactDatabase(sourceConnection, connectionString);
				if (c.OOOOO.o.().FileSystem.FileExists(FileName))
				{
					c.OOOOO.o.().FileSystem.DeleteFile(FileName);
				}
				c.OOOOO.o.().FileSystem.MoveFile(tempFileName, FileName);
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
				return false;
			}
			finally
			{
				if (c.OOOOO.o.().FileSystem.FileExists(tempFileName))
				{
					c.OOOOO.o.().FileSystem.DeleteFile(tempFileName);
				}
			}
			return true;
		}

		/// <summary>
		/// 将当前项目中的内部表全部保存为一个Access文件
		/// </summary>
		/// <param name="FileName">目标文件名,含路径</param>
		/// <param name="Password">为目标文件设置的密码</param>
		// Token: 0x06005280 RID: 21120 RVA: 0x0024D85C File Offset: 0x0024BA5C
		[oO0oooo("0686")]
		public static bool CompactToAccess(string FileName, string Password)
		{
			JetEngine jetEngine = new JetEngineClass();
			OleDbConnectionStringBuilder oleDbConnectionStringBuilder = new OleDbConnectionStringBuilder();
			string tempFileName = c.OOOOO.o.().FileSystem.GetTempFileName();
			if (!c.OOOOO.o.().FileSystem.DirectoryExists(c.OOOOO.o.().FileSystem.GetParentPath(FileName)))
			{
				c.OOOOO.o.().FileSystem.CreateDirectory(c.OOOOO.o.().FileSystem.GetParentPath(FileName));
			}
			string sourceConnection = O_O0OO.OoO.0OO__0ooo.().ConnectionString;
			oleDbConnectionStringBuilder.DataSource = tempFileName;
			oleDbConnectionStringBuilder.Provider = "Microsoft.Jet.OLEDB.4.0";
			oleDbConnectionStringBuilder.Add("Jet OLEDB:Engine Type", 5);
			if (Operators.CompareString(Password, "", true) > 0)
			{
				oleDbConnectionStringBuilder.Add("Jet OLEDB:Database Password", Password);
			}
			string connectionString = oleDbConnectionStringBuilder.ConnectionString;
			try
			{
				if (c.OOOOO.o.().FileSystem.FileExists(tempFileName))
				{
					c.OOOOO.o.().FileSystem.DeleteFile(tempFileName);
				}
				jetEngine.CompactDatabase(sourceConnection, connectionString);
				Connection connection = new ConnectionClass();
				Catalog catalog = new CatalogClass();
				connection.ConnectionString = oleDbConnectionStringBuilder.ConnectionString;
				connection.Open("", "", "", -1);
				catalog.ActiveConnection = connection;
				for (int i = catalog.Tables.Count - 1; i >= 0; i += -1)
				{
					if (catalog.Tables[i].Name.StartsWith("~TMPCLP") && o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(catalog.Tables[i].Name))
					{
						catalog.Tables.Delete(catalog.Tables[i].Name);
					}
				}
				try
				{
					foreach (object obj in catalog.Tables)
					{
						ADOX.Table table = (ADOX.Table)obj;
						if (table.Name.StartsWith("~TMPCLP"))
						{
							table.Name = table.Name.Substring(7);
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
				connection.Close();
				sourceConnection = connectionString;
				oleDbConnectionStringBuilder.DataSource = FileName;
				connectionString = oleDbConnectionStringBuilder.ConnectionString;
				if (c.OOOOO.o.().FileSystem.FileExists(FileName))
				{
					c.OOOOO.o.().FileSystem.DeleteFile(FileName);
				}
				jetEngine.CompactDatabase(sourceConnection, connectionString);
				c.OOOOO.o.().FileSystem.DeleteFile(tempFileName);
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
				return false;
			}
			return true;
		}

		/// <summary>
		/// 用于判断服务器的地址是否可以解析
		/// </summary>
		/// <param name="address">服务器地址</param>
		// Token: 0x06005281 RID: 21121 RVA: 0x0024DB20 File Offset: 0x0024BD20
		[oO0oooo("2709")]
		public static bool TryConnectHost(string address)
		{
			bool result;
			try
			{
				int num = 0;
				if (OO_00oOO.InternetGetConnectedState(ref num, 0))
				{
					if (Dns.GetHostAddresses(address)[0].ToString().Length <= 6)
					{
						result = false;
					}
					else
					{
						result = true;
					}
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x0024DB7C File Offset: 0x0024BD7C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static int FindAppWindow(string Caption)
		{
			OO_00oOO.O_Oo_0.0. = IntPtr.Zero;
			OO_00oOO.O_Oo_0.0. = Caption.ToLower();
			OO_00oOO.EnumWindows(new OO_00oOO.o_O_0ooO(OO_00oOO.Oo.0Oo00OO0.), 0);
			return (int)OO_00oOO.O_Oo_0.0.;
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x0024DBB0 File Offset: 0x0024BDB0
		internal static bool <<EMPTY_NAME>>(IntPtr A_0, int A_1)
		{
			StringBuilder stringBuilder = new StringBuilder(512);
			OoO0o.GetWindowText(A_0, stringBuilder, stringBuilder.Capacity);
			bool result;
			if (LikeOperator.LikeString(stringBuilder.ToString().ToLower(), "*" + OO_00oOO.O_Oo_0.0. + "*", CompareMethod.Text))
			{
				OO_00oOO.O_Oo_0.0. = A_0;
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		/// <summary>
		/// 查找指定标题的外部应用程序窗口，并显示、隐藏或关闭之
		/// </summary>
		/// <param name="Caption">字符型，查找窗口标题包括的字符</param>
		/// <param name="State">指定窗口状态</param>
		// Token: 0x06005284 RID: 21124 RVA: 0x0024DC0A File Offset: 0x0024BE0A
		[oO0oooo("2713")]
		public static bool ShowAppWindow(string Caption, int State)
		{
			OO_00oOO.O_Oo_0.0. = IntPtr.Zero;
			OO_00oOO.O_Oo_0.0. = Caption.ToLower();
			OO_00oOO.O0o_00Oo0.o_o. = State;
			OO_00oOO.EnumWindows(new OO_00oOO.o_O_0ooO(OO_00oOO.OOOoo_._o.), 0);
			return OO_00oOO.O_Oo_0.0. != IntPtr.Zero;
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x0024DC4C File Offset: 0x0024BE4C
		internal static bool <<EMPTY_NAME>>(IntPtr A_0, int A_1)
		{
			StringBuilder stringBuilder = new StringBuilder(512);
			OoO0o.GetWindowText(A_0, stringBuilder, stringBuilder.Capacity);
			bool result;
			if (LikeOperator.LikeString(stringBuilder.ToString().ToLower(), "*" + OO_00oOO.O_Oo_0.0. + "*", CompareMethod.Text))
			{
				switch (OO_00oOO.O0o_00Oo0.o_o.)
				{
				case 1:
					OoO0o.ShowWindow(A_0, 1);
					break;
				case 2:
					OoO0o.ShowWindow(A_0, 3);
					break;
				case 3:
					OoO0o.ShowWindow(A_0, 6);
					break;
				case 4:
					OoO0o.ShowWindow(A_0, 0);
					break;
				case 5:
					OO_00oOO.SendMessage(A_0, 16, 0, 0);
					break;
				}
				if (OO_00oOO.O0o_00Oo0.o_o. != 5)
				{
					ooO.SetForegroundWindow(A_0);
					OO_00oOO.O_Oo_0.0. = A_0;
				}
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		/// <summary>
		/// 停止绘制主窗口
		/// </summary>
		// Token: 0x06005286 RID: 21126 RVA: 0x0024DD0C File Offset: 0x0024BF0C
		public static void LockBaseMainForm()
		{
			ShareLibriay.LockWindowUpdate(OO_00oOO.BaseMainForm.Handle);
		}

		/// <summary>
		/// 恢复绘制主窗口
		/// </summary>
		// Token: 0x06005287 RID: 21127 RVA: 0x0024DD1E File Offset: 0x0024BF1E
		public static void UnlockBaseMainForm()
		{
			ShareLibriay.LockWindowUpdate(IntPtr.Zero);
		}

		/// <summary>
		/// 逻辑型，当前菜单为系统菜单
		/// </summary>
		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x06005288 RID: 21128 RVA: 0x0024DD2B File Offset: 0x0024BF2B
		// (set) Token: 0x06005289 RID: 21129 RVA: 0x0024DD32 File Offset: 0x0024BF32
		[oO0oooo("1466")]
		public static bool SystemMenu
		{
			get
			{
				return OO_00oOO.O0_.oO0__O.;
			}
			internal set
			{
				OO_00oOO.O0_.oO0__O. = value;
			}
		}

		/// <summary>
		/// 用于动态合成表达式
		/// </summary>
		/// <param name="expr">表达式</param>
		/// <param name="values">用于替换位置标记的值</param>
		// Token: 0x0600528A RID: 21130 RVA: 0x0024DD3C File Offset: 0x0024BF3C
		[oO0oooo("2919")]
		public static string CExp(string expr, params string[] values)
		{
			int num = values.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				expr = expr.Replace("{" + Conversions.ToString(i) + "}", values[i]);
			}
			return expr;
		}

		/// <summary>
		/// 默认为True，设置为False，可暂停执行事件代码
		/// </summary>
		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x0600528B RID: 21131 RVA: 0x0024DD7C File Offset: 0x0024BF7C
		// (set) Token: 0x0600528C RID: 21132 RVA: 0x0024DD9B File Offset: 0x0024BF9B
		[oO0oooo("2218")]
		public static bool SystemReady
		{
			get
			{
				return !O_O0OO.o0OoO00OO.00O. && OO_00oOO.O0o_00Oo0.o_o.;
			}
			set
			{
				OO_00oOO.O0o_00Oo0.o_o. = value;
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x0024DDA3 File Offset: 0x0024BFA3
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IMServerCollections IMServers
		{
			get
			{
				return OO_00oOO.O_0.oooO__O.;
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x0600528E RID: 21134 RVA: 0x0024DDAA File Offset: 0x0024BFAA
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IMClientCollections IMClients
		{
			get
			{
				return OO_00oOO.O_0.oooO__O.;
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x0600528F RID: 21135 RVA: 0x0024DDB1 File Offset: 0x0024BFB1
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IMServerCollections QQServers
		{
			get
			{
				return OO_00oOO.O_0.oooO__O.;
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x06005290 RID: 21136 RVA: 0x0024DDB8 File Offset: 0x0024BFB8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IMClientCollections QQClients
		{
			get
			{
				return OO_00oOO.O_0.oooO__O.;
			}
		}

		/// <summary>
		/// UDPClient集合
		/// </summary>
		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x0024DDBF File Offset: 0x0024BFBF
		public static oO_OO_o0_ UDPClients
		{
			get
			{
				return OO_00oOO.O0o_00Oo0.o_o.;
			}
		}

		/// <summary>
		/// OpenQQ服务端
		/// </summary>
		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x06005292 RID: 21138 RVA: 0x0024DDC8 File Offset: 0x0024BFC8
		[oO0oooo("A2979")]
		public static IMServer QQServer
		{
			get
			{
				IMServer result;
				if (OO_00oOO.IMServers.Count == 0)
				{
					string text = "QQServer";
					OO_00oOO.IMServers.Add(text);
					result = OO_00oOO.IMServers[text];
				}
				else
				{
					try
					{
						Dictionary<string, IMServer>.KeyCollection.Enumerator enumerator = OO_00oOO.IMServers.Keys.GetEnumerator();
						if (enumerator.MoveNext())
						{
							string key = enumerator.Current;
							return OO_00oOO.IMServers[key];
						}
					}
					finally
					{
						Dictionary<string, IMServer>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// OpenQQ客户端
		/// </summary>
		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x0024DE58 File Offset: 0x0024C058
		[oO0oooo("A2987")]
		public static IMClient QQClient
		{
			get
			{
				IMClient result;
				if (OO_00oOO.IMClients.Count == 0)
				{
					string text = OoOo0O.OO_o.0o_O.(5);
					OO_00oOO.IMClients.Add(text);
					result = OO_00oOO.IMClients[text];
				}
				else
				{
					try
					{
						Dictionary<string, IMClient>.KeyCollection.Enumerator enumerator = OO_00oOO.IMClients.Keys.GetEnumerator();
						if (enumerator.MoveNext())
						{
							string key = enumerator.Current;
							return OO_00oOO.IMClients[key];
						}
					}
					finally
					{
						Dictionary<string, IMClient>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 将汉字转换为拼音
		/// </summary>
		/// <param name="hzStr">汉字</param>
		/// <param name="mode">转换方式</param>
		// Token: 0x06005294 RID: 21140 RVA: 0x0024DEE8 File Offset: 0x0024C0E8
		[oO0oooo("1270")]
		public static string GetPinYin(string hzStr, int mode = 0)
		{
			string text = "";
			foreach (char c in hzStr)
			{
				if (ChineseChar.IsValidChar(c))
				{
					ChineseChar chineseChar = new ChineseChar(c);
					int index = 0;
					if (c <= '家')
					{
						if (c == '地' || c == '塔' || c == '家')
						{
							goto IL_69;
						}
					}
					else if (c != '广')
					{
						if (c == '洋')
						{
							goto IL_69;
						}
						if (c == '选')
						{
							index = 3;
						}
					}
					else
					{
						index = 2;
					}
					IL_76:
					if (mode == 0)
					{
						text = text + " " + chineseChar.Pinyins[index].Substring(0, chineseChar.Pinyins[index].Length - 1);
						goto IL_FB;
					}
					if (mode == 1)
					{
						text += chineseChar.Pinyins[index].Substring(0, 1);
						goto IL_FB;
					}
					text = text + " " + chineseChar.Pinyins[index];
					goto IL_FB;
					IL_69:
					index = 1;
					goto IL_76;
				}
				text += Conversions.ToString(c);
				IL_FB:;
			}
			return text.Trim().ToLower();
		}

		/// <summary>
		/// HTTP服务器端
		/// </summary>
		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x06005295 RID: 21141 RVA: 0x0024E00B File Offset: 0x0024C20B
		// (set) Token: 0x06005296 RID: 21142 RVA: 0x0024E012 File Offset: 0x0024C212
		[oO0oooo("A0143")]
		public static HttpListenter HttpServer
		{
			get
			{
				return OO_00oOO.O_0.oooO__O.;
			}
			internal set
			{
				OO_00oOO.O_0.oooO__O. = value;
			}
		}

		/// <summary>
		/// 以弹窗形式，在屏幕右下角显示提示信息
		/// </summary>
		/// <param name="Message">字符型，用于指定要显示的信息</param>
		/// <param name="Caption">可选参数，字符型，用于指定窗口标题</param>
		/// <param name="Icon"> 可选参数，用于指定图标</param>
		/// <param name="Duration">整数型，单位为秒，用于设置信息窗口显示的时长，如果省略此参数，窗口会一直显示，直到用户关闭窗口</param>
		// Token: 0x06005297 RID: 21143 RVA: 0x0024E01A File Offset: 0x0024C21A
		[oO0oooo("3043")]
		public static void PopMessage(string Message, string Caption = "提示", PopiconEnum Icon = PopiconEnum.Infomation, int Duration = -1)
		{
			if (O_O0OO.o.0__0_O_. == null)
			{
				O_O0OO.o.0__0_O_. = new O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002();
				O_O0OO.o.0__0_O_..Owner = OO_00oOO.BaseMainForm;
			}
			if (Icon < PopiconEnum.Infomation || Icon > PopiconEnum.Question)
			{
				Icon = PopiconEnum.Infomation;
			}
			O_O0OO.o.0__0_O_..o.oOoO__o.(Message, Caption, (int)Icon, Duration);
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x0024E055 File Offset: 0x0024C255
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static object ParseJSON(string json)
		{
			return null;
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x0024E058 File Offset: 0x0024C258
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			return HttpUtility.UrlEncode(A_0);
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x0024E060 File Offset: 0x0024C260
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			return HttpUtility.UrlDecode(A_0);
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x0024E068 File Offset: 0x0024C268
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			return HttpUtility.HtmlEncode(A_0);
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x0024E070 File Offset: 0x0024C270
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			return HttpUtility.HtmlDecode(A_0);
		}

		/// <summary>
		/// 获取加密狗ID
		/// </summary>
		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x0600529D RID: 21149 RVA: 0x0024E078 File Offset: 0x0024C278
		public static string DongleID
		{
			get
			{
				string str = null;
				string str2 = null;
				o0OO__.oOO.o_.(ref str, ref str2);
				return Microsoft.VisualBasic.Strings.Format(Conversions.ToLong(str + str2), "0000-0000-0000-0000");
			}
		}

		/// <summary>
		/// 获取项目ID
		/// </summary>
		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x0600529E RID: 21150 RVA: 0x0024E0AD File Offset: 0x0024C2AD
		public static string ProjectID
		{
			get
			{
				return O_O0OO.O_O._Oo.();
			}
		}

		/// <summary>
		/// 暂停当前线程
		/// </summary>
		/// <param name="msec">整数型，指定暂停时长，单位为毫秒</param>
		// Token: 0x0600529F RID: 21151 RVA: 0x0024E0B4 File Offset: 0x0024C2B4
		public static void Sleep(int msec)
		{
			Thread.Sleep(msec);
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x060052A0 RID: 21152 RVA: 0x0024E0BC File Offset: 0x0024C2BC
		internal static string HttpUpdatePath
		{
			get
			{
				return "http://www.foxtable.com/update/newversion.txt";
			}
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x0024E0C4 File Offset: 0x0024C2C4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static int OSVersion()
		{
			if (OO_00oOO.O.OoO__0O_oO. == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref OO_00oOO.O.OoO__0O_oO., new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(OO_00oOO.O.OoO__0O_oO., ref flag);
				if (OO_00oOO.O.OoO__0O_oO..State == 0)
				{
					OO_00oOO.O.OoO__0O_oO..State = 2;
					OO_00oOO.OO_.000_0_O_O. = -1;
				}
				else if (OO_00oOO.O.OoO__0O_oO..State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				OO_00oOO.O.OoO__0O_oO..State = 1;
				if (flag)
				{
					Monitor.Exit(OO_00oOO.O.OoO__0O_oO.);
				}
			}
			if (OO_00oOO.OO_.000_0_O_O. == -1)
			{
				OO_00oOO.OO_.000_0_O_O. = Environment.OSVersion.Version.Major;
			}
			return OO_00oOO.OO_.000_0_O_O.;
		}

		/// <summary>
		/// 控件样式
		/// </summary>
		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x060052A2 RID: 21154 RVA: 0x0024E178 File Offset: 0x0024C378
		// (set) Token: 0x060052A3 RID: 21155 RVA: 0x0024E184 File Offset: 0x0024C384
		[oO0oooo("3305")]
		public static string ControlTheme
		{
			get
			{
				return Main.OO_O.o..O.OOO0_OOo.();
			}
			set
			{
				Main.OO_O.o..O0.0000oO.(value);
			}
		}

		/// <summary>
		/// 菜单样式
		/// </summary>
		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x060052A4 RID: 21156 RVA: 0x0024E191 File Offset: 0x0024C391
		// (set) Token: 0x060052A5 RID: 21157 RVA: 0x0024E19D File Offset: 0x0024C39D
		[oO0oooo("3305")]
		public static string RibbonTheme
		{
			get
			{
				return Main.OO_O.o..o00o_OO_o_._o.();
			}
			set
			{
				Main.OO_O.o..OoO_oo00o0.Oo.(value);
			}
		}

		/// <summary>
		/// 表样式
		/// </summary>
		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x060052A6 RID: 21158 RVA: 0x0024E1AA File Offset: 0x0024C3AA
		// (set) Token: 0x060052A7 RID: 21159 RVA: 0x0024E1B8 File Offset: 0x0024C3B8
		[oO0oooo("3305")]
		public static string GridTheme
		{
			get
			{
				return O_O0OO.O0_00o.o0__o..GridTheme;
			}
			set
			{
				O_O0OO.O0_00o.o0__o..GridTheme = value;
				try
				{
					foreach (DataTable dataTable in OO_00oOO.DataTables)
					{
						dataTable.oOoOO0_o.O0_0.();
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
			}
		}

		/// <summary>
		/// 一个集合，包括所有样式名
		/// </summary>
		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x060052A8 RID: 21160 RVA: 0x0024E20C File Offset: 0x0024C40C
		public static List<string> Themes
		{
			get
			{
				if (OO_00oOO.oo0._0oO_O_0. == null)
				{
					Interlocked.CompareExchange<StaticLocalInitFlag>(ref OO_00oOO.oo0._0oO_O_0., new StaticLocalInitFlag(), null);
				}
				bool flag = false;
				try
				{
					Monitor.Enter(OO_00oOO.oo0._0oO_O_0., ref flag);
					if (OO_00oOO.oo0._0oO_O_0..State == 0)
					{
						OO_00oOO.oo0._0oO_O_0..State = 2;
						OO_00oOO.o_oo.0o. = null;
					}
					else if (OO_00oOO.oo0._0oO_O_0..State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					OO_00oOO.oo0._0oO_O_0..State = 1;
					if (flag)
					{
						Monitor.Exit(OO_00oOO.oo0._0oO_O_0.);
					}
				}
				if (OO_00oOO.o_oo.0o. == null)
				{
					OO_00oOO.o_oo.0o. = new List<string>(C1ThemeController.GetThemes());
					OO_00oOO.o_oo.0o..Remove("Foxtable经典蓝");
					OO_00oOO.o_oo.0o..Remove("Foxtable经典银");
					OO_00oOO.o_oo.0o..Remove("Foxtable经典黑");
					OO_00oOO.o_oo.0o..Add("Foxtable经典蓝");
					OO_00oOO.o_oo.0o..Add("Foxtable经典银");
					OO_00oOO.o_oo.0o..Add("Foxtable经典黑");
				}
				return OO_00oOO.o_oo.0o.;
			}
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x0024E314 File Offset: 0x0024C514
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool isUserColdeRunning()
		{
			StackTrace stackTrace = new StackTrace(true);
			int num = stackTrace.FrameCount - 1;
			for (int i = 0; i <= num; i++)
			{
				string name = stackTrace.GetFrame(i).GetMethod().Module.Name;
				if (name.StartsWith("<") && name.EndsWith(">"))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x040021F5 RID: 8693
		private static string <<EMPTY_NAME>>;

		// Token: 0x040021F6 RID: 8694
		private static int <<EMPTY_NAME>>;

		// Token: 0x040021F7 RID: 8695
		private static IntPtr <<EMPTY_NAME>> = IntPtr.Zero;

		// Token: 0x040021F8 RID: 8696
		private static bool <<EMPTY_NAME>>;

		// Token: 0x040021F9 RID: 8697
		private static List<object> <<EMPTY_NAME>> = new List<object>();

		// Token: 0x040021FA RID: 8698
		private static DataTableCollection <<EMPTY_NAME>>;

		// Token: 0x040021FB RID: 8699
		private static TableCollection <<EMPTY_NAME>>;

		// Token: 0x040021FC RID: 8700
		private static string <<EMPTY_NAME>>;

		// Token: 0x040021FD RID: 8701
		private static string <<EMPTY_NAME>>;

		// Token: 0x040021FE RID: 8702
		private static string <<EMPTY_NAME>>;

		// Token: 0x040021FF RID: 8703
		internal static UserInfo <<EMPTY_NAME>>;

		// Token: 0x04002200 RID: 8704
		internal static Foxtable.Table <<EMPTY_NAME>>;

		// Token: 0x04002201 RID: 8705
		internal static Foxtable.Table <<EMPTY_NAME>>;

		// Token: 0x04002202 RID: 8706
		private static DataRelationCollection <<EMPTY_NAME>> = new DataRelationCollection();

		// Token: 0x04002203 RID: 8707
		private static ConnectionCollection <<EMPTY_NAME>> = new ConnectionCollection();

		// Token: 0x04002204 RID: 8708
		private static UserFunctions <<EMPTY_NAME>> = new UserFunctions();

		// Token: 0x04002205 RID: 8709
		private static RibbonTabCollection <<EMPTY_NAME>>;

		// Token: 0x04002206 RID: 8710
		private static RibbonTabGroupCollection <<EMPTY_NAME>>;

		// Token: 0x04002207 RID: 8711
		private static ContextMenuCollection <<EMPTY_NAME>>;

		// Token: 0x04002208 RID: 8712
		private static Foxtable.RibbonMenu.StatusBar <<EMPTY_NAME>>;

		// Token: 0x04002209 RID: 8713
		private static VarsCollection <<EMPTY_NAME>> = new VarsCollection();

		// Token: 0x0400220A RID: 8714
		private static TimerCollection <<EMPTY_NAME>> = new TimerCollection();

		// Token: 0x0400220B RID: 8715
		private static FormCollection <<EMPTY_NAME>> = new FormCollection();

		// Token: 0x0400220C RID: 8716
		private static ReportCollection <<EMPTY_NAME>> = new ReportCollection();

		// Token: 0x0400220D RID: 8717
		private static HardWare <<EMPTY_NAME>> = new HardWare();

		// Token: 0x0400220E RID: 8718
		private static bool <<EMPTY_NAME>>;

		// Token: 0x0400220F RID: 8719
		internal static bool <<EMPTY_NAME>>;

		// Token: 0x04002210 RID: 8720
		private static bool <<EMPTY_NAME>>;

		// Token: 0x04002211 RID: 8721
		private static FileSystemWatcher <<EMPTY_NAME>> = new FileSystemWatcher();

		// Token: 0x04002212 RID: 8722
		private static MyPortCollections <<EMPTY_NAME>> = new MyPortCollections();

		// Token: 0x04002213 RID: 8723
		internal static FoxSMSControl <<EMPTY_NAME>>;

		// Token: 0x04002214 RID: 8724
		[CompilerGenerated]
		private static OO_00oOO.oo_00_O0_0O <<EMPTY_NAME>>;

		// Token: 0x04002215 RID: 8725
		[CompilerGenerated]
		private static OO_00oOO.oo0O0__O__oO <<EMPTY_NAME>>;

		// Token: 0x04002216 RID: 8726
		private static IMServerCollections <<EMPTY_NAME>> = new IMServerCollections();

		// Token: 0x04002217 RID: 8727
		private static IMClientCollections <<EMPTY_NAME>> = new IMClientCollections();

		// Token: 0x04002218 RID: 8728
		private static oO_OO_o0_ <<EMPTY_NAME>> = new oO_OO_o0_();

		// Token: 0x04002219 RID: 8729
		private static IMServer <<EMPTY_NAME>>;

		// Token: 0x0400221A RID: 8730
		private static IMClient <<EMPTY_NAME>>;

		// Token: 0x0400221B RID: 8731
		private static HttpListenter <<EMPTY_NAME>> = new HttpListenter();

		// Token: 0x0400221C RID: 8732
		private static MRPTableCols <<EMPTY_NAME>> = new MRPTableCols();

		// Token: 0x0400221D RID: 8733
		private static string <<EMPTY_NAME>>;

		// Token: 0x0400221E RID: 8734
		private static ScriptControl a;

		// Token: 0x0400221F RID: 8735
		private static StaticLocalInitFlag a;

		// Token: 0x04002220 RID: 8736
		private static Dictionary<string, string> a;

		// Token: 0x04002221 RID: 8737
		private static string <<EMPTY_NAME>>;

		// Token: 0x04002222 RID: 8738
		private static StaticLocalInitFlag <<EMPTY_NAME>>;

		// Token: 0x04002223 RID: 8739
		private static string <<EMPTY_NAME>>;

		// Token: 0x04002224 RID: 8740
		private static StaticLocalInitFlag <<EMPTY_NAME>>;

		// Token: 0x04002225 RID: 8741
		private static Process <<EMPTY_NAME>>;

		// Token: 0x04002226 RID: 8742
		private static StaticLocalInitFlag <<EMPTY_NAME>>;

		// Token: 0x04002227 RID: 8743
		private static string <<EMPTY_NAME>>;

		// Token: 0x04002228 RID: 8744
		private static StaticLocalInitFlag <<EMPTY_NAME>>;

		// Token: 0x04002229 RID: 8745
		private static Process <<EMPTY_NAME>>;

		// Token: 0x0400222A RID: 8746
		private static UserInfos a;

		// Token: 0x0400222B RID: 8747
		private static int <<EMPTY_NAME>>;

		// Token: 0x0400222C RID: 8748
		private static StaticLocalInitFlag <<EMPTY_NAME>>;

		// Token: 0x0400222D RID: 8749
		private static List<string> <<EMPTY_NAME>>;

		// Token: 0x0400222E RID: 8750
		private static StaticLocalInitFlag <<EMPTY_NAME>>;

		// Token: 0x020004E5 RID: 1253
		// (Invoke) Token: 0x060052AD RID: 21165
		private delegate bool o_O_0ooO(IntPtr A_0, int A_1);

		// Token: 0x020004E6 RID: 1254
		// (Invoke) Token: 0x060052B1 RID: 21169
		internal delegate void oo_00_O0_0O();

		// Token: 0x020004E7 RID: 1255
		// (Invoke) Token: 0x060052B5 RID: 21173
		internal delegate void oo0O0__O__oO();

		// Token: 0x020004E8 RID: 1256
		[EditorBrowsable(EditorBrowsableState.Never)]
		public enum OoOO
		{
			// Token: 0x04002230 RID: 8752
			<<EMPTY_NAME>>,
			// Token: 0x04002231 RID: 8753
			<<EMPTY_NAME>>,
			// Token: 0x04002232 RID: 8754
			<<EMPTY_NAME>>,
			// Token: 0x04002233 RID: 8755
			<<EMPTY_NAME>>,
			// Token: 0x04002234 RID: 8756
			<<EMPTY_NAME>>,
			// Token: 0x04002235 RID: 8757
			<<EMPTY_NAME>>,
			// Token: 0x04002236 RID: 8758
			<<EMPTY_NAME>>,
			// Token: 0x04002237 RID: 8759
			<<EMPTY_NAME>>
		}
	}
}
