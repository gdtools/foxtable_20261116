using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using C1.C1Preview;
using C1.Win.C1Command;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using C1.Win.C1Ribbon;
using Foxtable.My;
using Foxtable.WinForm;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Neodynamic.WinControls.BarcodeProfessional;

namespace Foxtable
{
	// Token: 0x02000453 RID: 1107
	[StandardModule]
	internal sealed class ooO
	{
		// Token: 0x06004A70 RID: 19056
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int SetForegroundWindow(IntPtr A_0);

		// Token: 0x06004A71 RID: 19057
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int GetLastInputInfo(ref ooO.o0O_ A_0);

		// Token: 0x06004A72 RID: 19058
		[DllImport("shell32.dll", CallingConvention = CallingConvention.StdCall)]
		private static extern uint ExtractIconExW([MarshalAs(UnmanagedType.LPWStr)] [In] string A_0, int A_1, ref IntPtr A_2, ref IntPtr A_3, uint A_4);

		// Token: 0x06004A73 RID: 19059 RVA: 0x0020F964 File Offset: 0x0020DB64
		internal static string <<EMPTY_NAME>>(ColumnDataTypeEnum A_0)
		{
			if (A_0 <= ColumnDataTypeEnum.Long)
			{
				switch (A_0)
				{
				case ColumnDataTypeEnum.Short:
					return "介于 –32,768 到 32,767 之间的短整型";
				case ColumnDataTypeEnum.Integer:
					return "介于 –2,147,483,648 到 2,147,483,647 之间的整数，超过此范围的整数可以考虑用双精度小数代替";
				case ColumnDataTypeEnum.Single:
					return "单精度小数，有效数字为7位，负数范围是从 –3.402823E38 到 –1.401298E-45，正数范围从1.401298E-45 到 3.402823E38";
				case ColumnDataTypeEnum.Double:
					return "双精度小数，有效数字为15位，负数范围是从 –1.79769313486232E308 到 –4.94065645841247E-324，正数范围从 4.94065645841247E-324 到 1.79769313486232E308";
				case (ColumnDataTypeEnum)6:
				case (ColumnDataTypeEnum)8:
				case (ColumnDataTypeEnum)9:
				case (ColumnDataTypeEnum)10:
					break;
				case ColumnDataTypeEnum.DateTime:
					return "日期时间列默认只允许输入日期，如果要输入时间型数据，请在列属性设置中，将\"日期时间格式\"属性设置为\"Time\"或者\"LongTime\"";
				case ColumnDataTypeEnum.Boolean:
					return "逻辑列只有两个值，分别为True(是)和False(否)";
				default:
					if (A_0 == ColumnDataTypeEnum.Byte)
					{
						return "介于 0 到 255 之间的微整数";
					}
					if (A_0 == ColumnDataTypeEnum.Long)
					{
						return "介于 -9,223,372,036,854,775,808 到 9,223,372,036,854,775,807之间的长整数";
					}
					break;
				}
			}
			else
			{
				if (A_0 == ColumnDataTypeEnum.Decimal)
				{
					return "高精度小数，有高达28位的有效数字，适用于要求使用大量有效的整数及小数位数并且没有舍入错误的财务计算，可存储的小数位数默认为4，可根据需要调整。";
				}
				if (A_0 == ColumnDataTypeEnum.String)
				{
					return "字符列用于储存长度少于等于255的字符型数据，如果长度可能超过255，请改用备注型";
				}
				if (A_0 == ColumnDataTypeEnum.Text)
				{
					return "用于输入超过255个字符的文本内容，备注型数据还可以扩展为文档型或者图片性，请在列属性设置中，选择相应的\"扩展类型\"即可";
				}
			}
			return "";
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x0020FA30 File Offset: 0x0020DC30
		internal static string <<EMPTY_NAME>>(string A_0, DataRow A_1, DataCol A_2)
		{
			string result;
			if (Operators.CompareString(A_0, "", true) == 0)
			{
				result = "";
			}
			else
			{
				if (A_2 != null)
				{
					BooleanEnum booleanEnum = A_2.AutoCopyAttachFile;
					if (booleanEnum == BooleanEnum.Default)
					{
						O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002 o_u3000_u3000_u3000_u3000_u3002_u3002_u3000_u3000O_u3002O_u = new O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002();
						o_u3000_u3000_u3000_u3000_u3002_u3002_u3000_u3000O_u3002O_u.ShowDialog();
						if (o_u3000_u3000_u3000_u3000_u3002_u3002_u3000_u3000O_u3002O_u.O.0o_0_.().Checked)
						{
							booleanEnum = BooleanEnum.True;
						}
						else
						{
							booleanEnum = BooleanEnum.False;
						}
						if (o_u3000_u3000_u3000_u3000_u3002_u3002_u3000_u3000O_u3002O_u.O.0o_0_.().Checked)
						{
							A_2.AutoCopyAttachFile = booleanEnum;
						}
					}
					if (booleanEnum == BooleanEnum.False)
					{
						if (A_0.StartsWith(OO_00oOO.AttachPath))
						{
							A_0 = A_0.Substring(OO_00oOO.AttachPath.Length);
						}
						else if (A_0.StartsWith(OO_00oOO.ProjectPath))
						{
							A_0 = A_0.Substring(OO_00oOO.ProjectPath.Length);
						}
						return A_0;
					}
				}
				if (A_0.StartsWith("\\\\"))
				{
					A_0 = ooO.O0ooOOoO.__o.(A_0);
				}
				try
				{
					string text = "";
					string text2 = "";
					string text3 = "";
					if (A_2 != null)
					{
						text = A_2.DefaultFolder;
						BeforeAttachFileEvents beforeAttachFileEvents = new BeforeAttachFileEvents(A_2.DataTable, A_1, A_2, OO_00oOO.FileSys.GetParentPath(A_0), OO_00oOO.FileSys.GetName(A_0), "");
						string a_ = "BeforeAttachFile";
						O_O0OO.OoO_o.oO0o0O.(A_2.DataTable.o_0_00_.oo0O0., a_, new object[]
						{
							beforeAttachFileEvents
						}, false, A_2.DataTable.Name, false);
						if (A_2.DataTable.GlobalHandler.BeforeAttachFile)
						{
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
							{
								beforeAttachFileEvents
							}, false, "全局表事件", false);
						}
						if (beforeAttachFileEvents.Cancel)
						{
							return "";
						}
						text2 = beforeAttachFileEvents.SubFolder;
						text3 = beforeAttachFileEvents.FileName;
					}
					if (Operators.CompareString(text, "", true) > 0)
					{
						if (Operators.CompareString(text.Substring(1, 1), ":", true) != 0)
						{
							if (text.StartsWith("\\\\"))
							{
								text = ooO.O0ooOOoO.__o.(text);
							}
							else
							{
								text = OO_00oOO.AttachPath + text;
							}
						}
					}
					else
					{
						text = OO_00oOO.AttachPath;
					}
					text = text.TrimEnd(new char[]
					{
						'\\'
					}) + "\\";
					if (!A_0.StartsWith(text, StringComparison.CurrentCultureIgnoreCase) || Operators.CompareString(text3, OO_00oOO.FileSys.GetName(A_0), true) != 0 || Operators.CompareString(text2, "", true) > 0)
					{
						string text4;
						if (Operators.CompareString(text2, "", true) > 0)
						{
							text4 = text + text2.Trim(new char[]
							{
								'\\'
							}) + "\\";
						}
						else
						{
							text4 = text;
						}
						if (!OO_00oOO.FileSys.DirectoryExists(text4))
						{
							OO_00oOO.FileSys.CreateDirectory(text4);
						}
						string text5;
						if (Operators.CompareString(text3, "", true) > 0)
						{
							text5 = text4 + text3;
						}
						else
						{
							text5 = text4 + OO_00oOO.FileSys.GetName(A_0);
						}
						if (Operators.CompareString(A_0, text5, true) != 0)
						{
							if (OO_00oOO.FileSys.FileExists(text5))
							{
								o\u3000\u3000\u3002\u3002 o_u3000_u3000_u3002_u = new o\u3000\u3000\u3002\u3002(text5);
								if (o_u3000_u3000_u3002_u.ShowDialog() != DialogResult.OK)
								{
									return "";
								}
								c.OOOOO.o.().FileSystem.CopyFile(A_0, o_u3000_u3000_u3002_u.O0o0o0_00OO.oO., true);
								text5 = o_u3000_u3000_u3002_u.O0o0o0_00OO.oO.;
							}
							else
							{
								c.OOOOO.o.().FileSystem.CopyFile(A_0, text5, true);
							}
						}
						result = text5.Substring(text.Length);
					}
					else
					{
						result = A_0.Substring(text.Length);
					}
				}
				catch (Exception a_2)
				{
					ooO.oOo0Oo.o.(a_2, "");
					result = A_0;
				}
			}
			return result;
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x0020FDAC File Offset: 0x0020DFAC
		private static string <<EMPTY_NAME>>(string A_0)
		{
			string text = A_0.Substring(2);
			if (text.IndexOf("\\") > 0)
			{
				text = text.Substring(0, text.IndexOf("\\"));
			}
			if (Operators.CompareString(text, SysInfo.ComputerName, true) == 0)
			{
				Dictionary<string, string> sharePath = OO_00oOO.HardWareInfo.SharePath;
				string text2 = A_0.Substring(A_0.IndexOf("\\", 2) + 1);
				if (text2.IndexOf("\\") > 0)
				{
					text2 = text2.Substring(0, text2.IndexOf("\\"));
				}
				try
				{
					foreach (string text3 in sharePath.Keys)
					{
						if (Operators.CompareString(text3, text2, true) == 0)
						{
							A_0 = sharePath[text3] + A_0.Substring(("\\\\" + text + "\\" + text2).Length);
						}
					}
				}
				finally
				{
					Dictionary<string, string>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			return A_0;
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x0020FEAC File Offset: 0x0020E0AC
		internal static DialogResult <<EMPTY_NAME>>(DataCol A_0)
		{
			DialogResult result;
			if (A_0.AutoDeleteAttachFile == BooleanEnum.False)
			{
				result = DialogResult.No;
			}
			else if (A_0.AutoDeleteAttachFile == BooleanEnum.True)
			{
				result = DialogResult.Yes;
			}
			else if (A_0.AutoCopyAttachFile == BooleanEnum.False)
			{
				result = DialogResult.No;
			}
			else if (A_0.AutoDeleteAttachFile == BooleanEnum.Default)
			{
				O\u3002\u3002\u3002\u3002\u3000 o_u3002_u3002_u3002_u3002_u = new O\u3002\u3002\u3002\u3002\u3000();
				if (o_u3002_u3002_u3002_u3002_u.ShowDialog() == DialogResult.OK)
				{
					if (o_u3002_u3002_u3002_u3002_u.o_0._00O_0__O_.().Checked)
					{
						if (o_u3002_u3002_u3002_u3002_u.O__ooooo.0.().Checked)
						{
							A_0.AutoDeleteAttachFile = BooleanEnum.True;
						}
						else
						{
							A_0.AutoDeleteAttachFile = BooleanEnum.False;
						}
					}
					if (o_u3002_u3002_u3002_u3002_u.O__ooooo.0.().Checked)
					{
						result = DialogResult.Yes;
					}
					else
					{
						result = DialogResult.No;
					}
				}
				else
				{
					result = DialogResult.Cancel;
				}
			}
			return result;
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x0020FF3C File Offset: 0x0020E13C
		internal static void <<EMPTY_NAME>>(string A_0)
		{
			try
			{
				if (c.OOOOO.o.().FileSystem.FileExists(A_0) && (Operators.CompareString(A_0.Substring(1, 1), ":", true) == 0 || A_0.StartsWith("\\\\")))
				{
					Process.Start(A_0);
				}
				else if (c.OOOOO.o.().FileSystem.FileExists(OO_00oOO.AttachPath + A_0))
				{
					Process.Start(OO_00oOO.AttachPath + A_0);
				}
				else if (c.OOOOO.o.().FileSystem.FileExists(OO_00oOO.ProjectPath + A_0))
				{
					Process.Start(OO_00oOO.ProjectPath + A_0);
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x00210010 File Offset: 0x0020E210
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (A_0.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) || A_0.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase))
			{
				result = A_0;
			}
			else if (!string.IsNullOrEmpty(Path.GetPathRoot(A_0)))
			{
				result = A_0;
			}
			else if (c.OOOOO.o.().FileSystem.FileExists(OO_00oOO.AttachPath + A_0))
			{
				result = OO_00oOO.AttachPath + A_0;
			}
			else if (c.OOOOO.o.().FileSystem.FileExists(OO_00oOO.ProjectPath + A_0))
			{
				result = OO_00oOO.ProjectPath + A_0;
			}
			else if (c.OOOOO.o.().FileSystem.FileExists(O_O0OO.OOo_o.0o. + A_0))
			{
				result = O_O0OO.OOo_o.0o. + A_0;
			}
			else
			{
				result = A_0;
			}
			return result;
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x002100D8 File Offset: 0x0020E2D8
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			if (!OO_00oOO.FileSys.DirectoryExists(O_O0OO.OOo_o.0o.))
			{
				OO_00oOO.FileSys.CreateDirectory(O_O0OO.OOo_o.0o.);
			}
			if (Operators.CompareString(A_0, "", true) > 0 && Operators.CompareString(c.OOOOO.o.().FileSystem.GetParentPath(A_0), "", true) > 0 && Operators.CompareString(A_0.Substring(1, 1), ":", true) == 0)
			{
				if ((c.OOOOO.o.().FileSystem.GetParentPath(A_0) + "\\").StartsWith(O_O0OO.OOo_o.0o., StringComparison.CurrentCultureIgnoreCase))
				{
					A_0 = A_0.Substring(O_O0OO.OOo_o.0o..Length);
				}
				else if ((c.OOOOO.o.().FileSystem.GetParentPath(A_0) + "\\").StartsWith(OO_00oOO.ProjectPath, StringComparison.CurrentCultureIgnoreCase))
				{
					A_0 = A_0.Substring(OO_00oOO.ProjectPath.Length);
				}
				else
				{
					try
					{
						if (c.OOOOO.o.().FileSystem.FileExists(O_O0OO.OOo_o.0o. + c.OOOOO.o.().FileSystem.GetName(A_0)))
						{
							o\u3000\u3000\u3002\u3002 o_u3000_u3000_u3002_u = new o\u3000\u3000\u3002\u3002(O_O0OO.OOo_o.0o. + c.OOOOO.o.().FileSystem.GetName(A_0));
							if (o_u3000_u3000_u3002_u.ShowDialog() != DialogResult.OK)
							{
								return "";
							}
							c.OOOOO.o.().FileSystem.CopyFile(A_0, o_u3000_u3000_u3002_u.O0o0o0_00OO.oO., true);
							A_0 = o_u3000_u3000_u3002_u.O0o0o0_00OO.oO.;
						}
						else
						{
							c.OOOOO.o.().FileSystem.CopyFile(A_0, O_O0OO.OOo_o.0o. + c.OOOOO.o.().FileSystem.GetName(A_0), true);
						}
					}
					catch (Exception ex)
					{
						return "";
					}
					A_0 = c.OOOOO.o.().FileSystem.GetName(A_0);
				}
			}
			return A_0;
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x002102B0 File Offset: 0x0020E4B0
		internal static void <<EMPTY_NAME>>(System.Windows.Forms.Control A_0)
		{
			for (A_0 = A_0.Parent; A_0 != null; A_0 = A_0.Parent)
			{
				if (A_0 is C1DockingTabPage)
				{
					C1DockingTabPage c1DockingTabPage = (C1DockingTabPage)A_0;
					((C1DockingTab)c1DockingTabPage.Parent).SelectedTab = c1DockingTabPage;
					return;
				}
			}
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x002102F4 File Offset: 0x0020E4F4
		internal static string <<EMPTY_NAME>>(AggregateEnum A_0)
		{
			string result = "";
			switch (A_0)
			{
			case AggregateEnum.Sum:
				result = "Sum(";
				break;
			case AggregateEnum.Count:
				result = "Count(";
				break;
			case AggregateEnum.Average:
				result = "Avg(";
				break;
			case AggregateEnum.Max:
				result = "Max(";
				break;
			case AggregateEnum.Min:
				result = "Min(";
				break;
			case AggregateEnum.Std:
				result = "StDev(";
				break;
			case AggregateEnum.Var:
				result = "Var(";
				break;
			}
			return result;
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x00210370 File Offset: 0x0020E570
		internal static System.Windows.Forms.Control <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0)
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control.ContainsFocus)
					{
						if (control.Focused)
						{
							return control;
						}
						if (control.HasChildren)
						{
							return ooO.o.O_0000_O.(control.Controls);
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

		// Token: 0x06004A7D RID: 19069 RVA: 0x002103F0 File Offset: 0x0020E5F0
		internal static CursorEnum <<EMPTY_NAME>>(Cursor A_0)
		{
			CursorEnum result;
			if (A_0 == Cursors.AppStarting)
			{
				result = CursorEnum.AppStarting;
			}
			else if (A_0 == Cursors.Arrow)
			{
				result = CursorEnum.Arrow;
			}
			else if (A_0 == Cursors.Cross)
			{
				result = CursorEnum.Cross;
			}
			else if (A_0 == Cursors.Default)
			{
				result = CursorEnum.Default;
			}
			else if (A_0 == Cursors.Hand)
			{
				result = CursorEnum.Hand;
			}
			else if (A_0 == Cursors.Help)
			{
				result = CursorEnum.Help;
			}
			else if (A_0 == Cursors.HSplit)
			{
				result = CursorEnum.HSplit;
			}
			else if (A_0 == Cursors.IBeam)
			{
				result = CursorEnum.IBeam;
			}
			else if (A_0 == Cursors.No)
			{
				result = CursorEnum.No;
			}
			else if (A_0 == Cursors.NoMove2D)
			{
				result = CursorEnum.NoMove2D;
			}
			else if (A_0 == Cursors.NoMoveHoriz)
			{
				result = CursorEnum.NoMoveHoriz;
			}
			else if (A_0 == Cursors.NoMoveVert)
			{
				result = CursorEnum.NoMoveVert;
			}
			else if (A_0 == Cursors.PanEast)
			{
				result = CursorEnum.PanEast;
			}
			else if (A_0 == Cursors.PanNE)
			{
				result = CursorEnum.PanNE;
			}
			else if (A_0 == Cursors.PanNorth)
			{
				result = CursorEnum.PanNorth;
			}
			else if (A_0 == Cursors.PanNW)
			{
				result = CursorEnum.PanNW;
			}
			else if (A_0 == Cursors.PanSE)
			{
				result = CursorEnum.PanSE;
			}
			else if (A_0 == Cursors.PanSouth)
			{
				result = CursorEnum.PanSouth;
			}
			else if (A_0 == Cursors.PanSW)
			{
				result = CursorEnum.PanSW;
			}
			else if (A_0 == Cursors.PanWest)
			{
				result = CursorEnum.PanWest;
			}
			else if (A_0 == Cursors.SizeAll)
			{
				result = CursorEnum.SizeAll;
			}
			else if (A_0 == Cursors.SizeNESW)
			{
				result = CursorEnum.SizeNESW;
			}
			else if (A_0 == Cursors.SizeNS)
			{
				result = CursorEnum.SizeNS;
			}
			else if (A_0 == Cursors.SizeNWSE)
			{
				result = CursorEnum.SizeNWSE;
			}
			else if (A_0 == Cursors.SizeWE)
			{
				result = CursorEnum.SizeWE;
			}
			else if (A_0 == Cursors.UpArrow)
			{
				result = CursorEnum.UpArrow;
			}
			else if (A_0 == Cursors.VSplit)
			{
				result = CursorEnum.VSplit;
			}
			else if (A_0 == Cursors.WaitCursor)
			{
				result = CursorEnum.WaitCursor;
			}
			return result;
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x0021062C File Offset: 0x0020E82C
		internal static Cursor <<EMPTY_NAME>>(CursorEnum A_0)
		{
			Cursor result;
			switch (A_0)
			{
			case CursorEnum.AppStarting:
				result = Cursors.AppStarting;
				break;
			case CursorEnum.Arrow:
				result = Cursors.Arrow;
				break;
			case CursorEnum.Cross:
				result = Cursors.Cross;
				break;
			case CursorEnum.Default:
				result = Cursors.Default;
				break;
			case CursorEnum.Hand:
				result = Cursors.Hand;
				break;
			case CursorEnum.Help:
				result = Cursors.Help;
				break;
			case CursorEnum.HSplit:
				result = Cursors.HSplit;
				break;
			case CursorEnum.IBeam:
				result = Cursors.IBeam;
				break;
			case CursorEnum.No:
				result = Cursors.No;
				break;
			case CursorEnum.NoMove2D:
				result = Cursors.NoMove2D;
				break;
			case CursorEnum.NoMoveHoriz:
				result = Cursors.NoMoveHoriz;
				break;
			case CursorEnum.NoMoveVert:
				result = Cursors.NoMoveVert;
				break;
			case CursorEnum.PanEast:
				result = Cursors.PanEast;
				break;
			case CursorEnum.PanNE:
				result = Cursors.PanNE;
				break;
			case CursorEnum.PanNorth:
				result = Cursors.PanNorth;
				break;
			case CursorEnum.PanNW:
				result = Cursors.PanNW;
				break;
			case CursorEnum.PanSE:
				result = Cursors.PanSE;
				break;
			case CursorEnum.PanSouth:
				result = Cursors.PanSouth;
				break;
			case CursorEnum.PanSW:
				result = Cursors.PanNW;
				break;
			case CursorEnum.PanWest:
				result = Cursors.PanWest;
				break;
			case CursorEnum.SizeAll:
				result = Cursors.SizeAll;
				break;
			case CursorEnum.SizeNESW:
				result = Cursors.SizeNESW;
				break;
			case CursorEnum.SizeNS:
				result = Cursors.SizeNS;
				break;
			case CursorEnum.SizeNWSE:
				result = Cursors.SizeNWSE;
				break;
			case CursorEnum.SizeWE:
				result = Cursors.SizeWE;
				break;
			case CursorEnum.UpArrow:
				result = Cursors.UpArrow;
				break;
			case CursorEnum.VSplit:
				result = Cursors.VSplit;
				break;
			case CursorEnum.WaitCursor:
				result = Cursors.WaitCursor;
				break;
			default:
				result = Cursors.Default;
				break;
			}
			return result;
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x002107C4 File Offset: 0x0020E9C4
		internal static bool <<EMPTY_NAME>>()
		{
			if (ooO.OO_oOO0O.O00. == null)
			{
				ooO.OO_oOO0O.O00. = new Oo00.oo00Oo0O0O0();
			}
			bool result;
			if (OO_00oOO.User.Type == UserTypeEnum.Developer)
			{
				result = true;
			}
			else if (O_O0OO.O0_00o.o0__o..DisableDevelop)
			{
				MessageBox.Show("本项目的开发功能已经关闭，您无法使用此功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x00210818 File Offset: 0x0020EA18
		internal static void <<EMPTY_NAME>>()
		{
			Process.Start("iexplore.exe", "http://www.foxtable.com");
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x0021082C File Offset: 0x0020EA2C
		internal static void <<EMPTY_NAME>>()
		{
			int num;
			int num4;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				IEnumerator<Table> enumerator = OO_00oOO.Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Table table = enumerator.Current;
					IL_1E:
					num2 = 3;
					table.foxGrid.Enabled = false;
					IL_2D:
					num2 = 4;
					IEnumerator enumerator2 = ((IEnumerable)table.foxGrid.Styles).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						CellStyle cellStyle = (CellStyle)obj;
						IL_52:
						num2 = 5;
						cellStyle.ForeColor = Color.Gray;
						IL_60:
						num2 = 6;
					}
					IL_6B:
					num2 = 7;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
					IL_82:
					num2 = 8;
				}
				IL_8C:
				num2 = 9;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_98:
				num2 = 10;
				IEnumerator<Foxtable.WinForm.Form> enumerator3 = OO_00oOO.Forms.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					Foxtable.WinForm.Form form = enumerator3.Current;
					IL_B2:
					num2 = 11;
					if (form.Opened)
					{
						IL_BE:
						num2 = 12;
						form.Pane.Enabled = false;
					}
					IL_CE:
					num2 = 13;
				}
				IL_DA:
				num2 = 14;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_E8:
				num2 = 15;
				IEnumerator enumerator4 = Main.OO_O.o..O.OOO0_OOo.().Tabs.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					object obj2 = enumerator4.Current;
					RibbonTab ribbonTab = (RibbonTab)obj2;
					IL_111:
					num2 = 16;
					ribbonTab.Enabled = false;
					IL_11C:
					num2 = 17;
				}
				IL_128:
				num2 = 18;
				if (enumerator4 is IDisposable)
				{
					(enumerator4 as IDisposable).Dispose();
				}
				IL_140:
				num2 = 19;
				Main.OO_O.o..O.OOO0_OOo.().Qat.Enabled = false;
				IL_158:
				num2 = 20;
				Main.OO_O.o..O.OOO0_OOo.().ConfigToolBar.Enabled = false;
				IL_170:
				num2 = 21;
				Main.OO_O.o..O.OOO0_OOo.().ApplicationMenu.Enabled = false;
				IL_188:
				num2 = 22;
				O_O0OO.o0OoO00OO.00O. = o0_.Oo_0.OOo0oO0.("", "", O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false, "", true);
				IL_1BA:
				num2 = 23;
				OO_00oOO.SystemReady = false;
				IL_1C3:
				goto IL_275;
				IL_1C8:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_236:
				goto IL_26A;
				IL_238:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_248:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_238;
			}
			IL_26A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_275:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x00210AD4 File Offset: 0x0020ECD4
		internal static void <<EMPTY_NAME>>(Exception A_0)
		{
			ShowErrorMessageEventArgs showErrorMessageEventArgs = new ShowErrorMessageEventArgs(A_0, "");
			if (O_O0OO.oo0_o_.o. != null)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeShowErrorMessage", new object[]
				{
					showErrorMessageEventArgs
				}, true, "项目", false);
			}
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x00210B15 File Offset: 0x0020ED15
		internal static void <<EMPTY_NAME>>(Exception A_0, string A_1 = "")
		{
			if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
			{
				OO_00oOO.BaseMainForm.Invoke(new ooO.o_0_(ooO.OO_oOO0O.O00.), new object[]
				{
					A_0,
					A_1
				});
			}
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x00210B50 File Offset: 0x0020ED50
		internal static void <<EMPTY_NAME>>(Exception A_0, string A_1 = "")
		{
			ShowErrorMessageEventArgs showErrorMessageEventArgs = new ShowErrorMessageEventArgs(A_0, A_1);
			if (O_O0OO.oo0_o_.o. != null)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeShowErrorMessage", new object[]
				{
					showErrorMessageEventArgs
				}, true, "项目", false);
			}
			if (!showErrorMessageEventArgs.Cancel)
			{
				Main.OO_O.o. = SplashFormStateEnum.Hide;
				new O\u3000\u3002\u3002\u3000\u3000(A_1, A_0)
				{
					TopMost = true
				}.ShowDialog();
			}
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x00210BB0 File Offset: 0x0020EDB0
		internal static Image <<EMPTY_NAME>>(C1FlexGrid A_0, CheckEnum A_1)
		{
			switch (A_1)
			{
			case CheckEnum.Checked:
			case CheckEnum.TSChecked:
				return A_0.Glyphs[GlyphEnum.Checked];
			case CheckEnum.Unchecked:
			case CheckEnum.TSUnchecked:
				return A_0.Glyphs[GlyphEnum.Unchecked];
			case CheckEnum.TSGrayed:
				return A_0.Glyphs[GlyphEnum.Grayed];
			}
			return null;
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x00210C14 File Offset: 0x0020EE14
		internal static void <<EMPTY_NAME>>()
		{
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
			{
				"Variables",
				o0_O.O0oO__._0OO00o.
			});
			checked
			{
				if (dataRow != null && !dataRow.IsNull("Config"))
				{
					string[] array = Conversions.ToString(dataRow["Config"]).Split(new char[]
					{
						'\r',
						'\n'
					}, StringSplitOptions.RemoveEmptyEntries);
					for (int i = 0; i < array.Length; i++)
					{
						string[] array2 = array[i].Split(new char[]
						{
							'\t'
						});
						string left = array2[1];
						if (Operators.CompareString(left, "String", true) == 0)
						{
							OO_00oOO.Vars.Add(array2[0], typeof(string), array2[2]);
						}
						else if (Operators.CompareString(left, "Date", true) == 0)
						{
							OO_00oOO.Vars.Add(array2[0], typeof(DateTime), array2[2]);
						}
						else if (Operators.CompareString(left, "Boolean", true) == 0)
						{
							OO_00oOO.Vars.Add(array2[0], typeof(bool), array2[2]);
						}
						else if (Operators.CompareString(left, "Integer", true) == 0)
						{
							OO_00oOO.Vars.Add(array2[0], typeof(int), array2[2]);
						}
						else if (Operators.CompareString(left, "Long", true) == 0)
						{
							OO_00oOO.Vars.Add(array2[0], typeof(long), array2[2]);
						}
						else if (Operators.CompareString(left, "Single", true) == 0)
						{
							OO_00oOO.Vars.Add(array2[0], typeof(float), array2[2]);
						}
						else if (Operators.CompareString(left, "Double", true) == 0)
						{
							OO_00oOO.Vars.Add(array2[0], typeof(double), array2[2]);
						}
						else if (Operators.CompareString(left, "Decimal", true) == 0)
						{
							OO_00oOO.Vars.Add(array2[0], typeof(decimal), array2[2]);
						}
					}
				}
			}
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x00210E24 File Offset: 0x0020F024
		internal static bool <<EMPTY_NAME>>(object A_0, PropertyDescriptor A_1)
		{
			int num;
			bool result;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string category = A_1.Category;
				IL_11:
				num2 = 3;
				string name = A_1.Name;
				IL_1B:
				num2 = 4;
				if (!(A_0 is DataColumnProperty))
				{
					goto IL_7E2;
				}
				IL_28:
				num2 = 5;
				DataColumnProperty dataColumnProperty = (DataColumnProperty)A_0;
				IL_32:
				num2 = 6;
				DataCol oO.OO. = dataColumnProperty.oO.OO.;
				IL_3C:
				num2 = 7;
				string left = name;
				IL_42:
				num2 = 9;
				if (Operators.CompareString(left, "EditMask", true) != 0)
				{
					goto IL_9E;
				}
				IL_54:
				num2 = 10;
				if (dataColumnProperty.oO.OO..DataType == typeof(string) && dataColumnProperty.oO.OO..MaxLength != -1 && dataColumnProperty.oO.OO..MaxLength <= 255)
				{
					goto IL_7DA;
				}
				IL_94:
				num2 = 11;
				result = false;
				goto IL_235A;
				IL_9E:
				num2 = 13;
				if (Operators.CompareString(left, "BooleanFormat", true) != 0)
				{
					goto IL_D8;
				}
				IL_B0:
				num2 = 14;
				if (dataColumnProperty.oO.OO..DataType == typeof(bool))
				{
					goto IL_7DA;
				}
				IL_CE:
				num2 = 15;
				result = false;
				goto IL_235A;
				IL_D8:
				num2 = 17;
				if (Operators.CompareString(left, "DateTimeFormat", true) != 0)
				{
					goto IL_112;
				}
				IL_EA:
				num2 = 18;
				if (dataColumnProperty.oO.OO..DataType == typeof(DateTime))
				{
					goto IL_7DA;
				}
				IL_108:
				num2 = 19;
				result = false;
				goto IL_235A;
				IL_112:
				num2 = 21;
				if (Operators.CompareString(left, "FixedDigits", true) != 0)
				{
					goto IL_167;
				}
				IL_124:
				num2 = 22;
				if (dataColumnProperty.oO.OO..DataType == typeof(int) || dataColumnProperty.oO.OO..DataType == typeof(long))
				{
					goto IL_7DA;
				}
				IL_15D:
				num2 = 23;
				result = false;
				goto IL_235A;
				IL_167:
				num2 = 25;
				if (Operators.CompareString(left, "PercentStyle", true) != 0 && Operators.CompareString(left, "FixedDecimals", true) != 0 && Operators.CompareString(left, "Decimals", true) != 0)
				{
					goto IL_206;
				}
				IL_197:
				num2 = 26;
				if (dataColumnProperty.oO.OO..DataType == typeof(float) || dataColumnProperty.oO.OO..DataType == typeof(double) || dataColumnProperty.oO.OO..DataType == typeof(decimal))
				{
					goto IL_1EC;
				}
				IL_1E2:
				num2 = 27;
				result = false;
				goto IL_235A;
				IL_1EC:
				num2 = 29;
				if (dataColumnProperty.ExtendColumnType != ExtendColumnTypeEnum.时段)
				{
					goto IL_7DA;
				}
				IL_1FC:
				num2 = 30;
				result = false;
				goto IL_235A;
				IL_206:
				num2 = 32;
				if (Operators.CompareString(left, "ThousandSeparator", true) != 0 && Operators.CompareString(left, "CurrencySymbol", true) != 0 && Operators.CompareString(left, "ShowCurrencySymbol", true) != 0)
				{
					goto IL_30E;
				}
				IL_239:
				num2 = 33;
				if (dataColumnProperty.oO.OO..DataType == typeof(float) || dataColumnProperty.oO.OO..DataType == typeof(double) || dataColumnProperty.oO.OO..DataType == typeof(decimal) || dataColumnProperty.oO.OO..DataType == typeof(long) || dataColumnProperty.oO.OO..DataType == typeof(int) || dataColumnProperty.oO.OO..DataType == typeof(short) || dataColumnProperty.oO.OO..DataType == typeof(byte))
				{
					goto IL_2F4;
				}
				IL_2EA:
				num2 = 34;
				result = false;
				goto IL_235A;
				IL_2F4:
				num2 = 36;
				if (dataColumnProperty.ExtendColumnType != ExtendColumnTypeEnum.时段)
				{
					goto IL_7DA;
				}
				IL_304:
				num2 = 37;
				result = false;
				goto IL_235A;
				IL_30E:
				num2 = 39;
				if (Operators.CompareString(left, "ExtendColumnType", true) != 0)
				{
					goto IL_37E;
				}
				IL_320:
				num2 = 40;
				if (dataColumnProperty.oO.OO..DataType == typeof(int) || dataColumnProperty.oO.OO..DataType == typeof(string) || dataColumnProperty.oO.OO..DataType == typeof(double))
				{
					goto IL_7DA;
				}
				IL_374:
				num2 = 41;
				result = false;
				goto IL_235A;
				IL_37E:
				num2 = 43;
				if (Operators.CompareString(left, "Remote", true) != 0 && Operators.CompareString(left, "AutoDeleteAttachFile", true) != 0)
				{
					goto IL_3E5;
				}
				IL_39F:
				num2 = 44;
				if ((dataColumnProperty.ExtendColumnType == ExtendColumnTypeEnum.文件 || dataColumnProperty.ExtendColumnType == ExtendColumnTypeEnum.多文件 || dataColumnProperty.ExtendColumnType == ExtendColumnTypeEnum.图片) && dataColumnProperty.oO.OO..DataType == typeof(string))
				{
					goto IL_7DA;
				}
				IL_3DB:
				num2 = 45;
				result = false;
				goto IL_235A;
				IL_3E5:
				num2 = 47;
				if (Operators.CompareString(left, "Host", true) != 0 && Operators.CompareString(left, "Account", true) != 0 && Operators.CompareString(left, "Password", true) != 0 && Operators.CompareString(left, "RootDir", true) != 0 && Operators.CompareString(left, "UTF8", true) != 0 && Operators.CompareString(left, "AutoDownload", true) != 0 && Operators.CompareString(left, "AutoUpdate", true) != 0 && Operators.CompareString(left, "Port", true) != 0)
				{
					goto IL_4DB;
				}
				IL_460:
				num2 = 48;
				if ((dataColumnProperty.ExtendColumnType == ExtendColumnTypeEnum.文件 || dataColumnProperty.ExtendColumnType == ExtendColumnTypeEnum.多文件 || dataColumnProperty.ExtendColumnType == ExtendColumnTypeEnum.图片) && dataColumnProperty.oO.OO..DataType == typeof(string) && dataColumnProperty.Remote)
				{
					goto IL_4AC;
				}
				IL_4A2:
				num2 = 49;
				result = false;
				goto IL_235A;
				IL_4AC:
				num2 = 51;
				if (Operators.CompareString(name, "AutoDownload", true) != 0)
				{
					goto IL_7DA;
				}
				IL_4C1:
				num2 = 52;
				if (dataColumnProperty.ExtendColumnType == ExtendColumnTypeEnum.图片)
				{
					goto IL_7DA;
				}
				IL_4D1:
				num2 = 53;
				result = false;
				goto IL_235A;
				IL_4DB:
				num2 = 55;
				if (Operators.CompareString(left, "AutoCopyAttachFile", true) != 0 && Operators.CompareString(left, "FileFilter", true) != 0 && Operators.CompareString(left, "FolderName", true) != 0 && Operators.CompareString(left, "SourceFolder", true) != 0)
				{
					goto IL_569;
				}
				IL_51A:
				num2 = 56;
				if ((dataColumnProperty.ExtendColumnType == ExtendColumnTypeEnum.文件 || dataColumnProperty.ExtendColumnType == ExtendColumnTypeEnum.多文件 || dataColumnProperty.ExtendColumnType == ExtendColumnTypeEnum.图片) && dataColumnProperty.oO.OO..DataType == typeof(string) && !dataColumnProperty.Remote)
				{
					goto IL_7DA;
				}
				IL_55F:
				num2 = 57;
				result = false;
				goto IL_235A;
				IL_569:
				num2 = 59;
				if (Operators.CompareString(left, "DockImage", true) != 0 && Operators.CompareString(left, "DockArea", true) != 0 && Operators.CompareString(left, "DockTitle", true) != 0 && Operators.CompareString(left, "AutoOpen", true) != 0 && Operators.CompareString(left, "AutoHide", true) != 0 && Operators.CompareString(left, "ShowCaption", true) != 0 && Operators.CompareString(left, "AllowClose", true) != 0)
				{
					goto IL_633;
				}
				IL_5D5:
				num2 = 60;
				if ((dataColumnProperty.ExtendColumnType == ExtendColumnTypeEnum.多文件 || dataColumnProperty.ExtendColumnType == ExtendColumnTypeEnum.图片 || dataColumnProperty.oO.OO..MaxLength < 0 || dataColumnProperty.oO.OO..MaxLength > 255) && dataColumnProperty.oO.OO..DataType == typeof(string))
				{
					goto IL_7DA;
				}
				IL_629:
				num2 = 61;
				result = false;
				goto IL_235A;
				IL_633:
				num2 = 63;
				if (Operators.CompareString(left, "UsetBuildInEditor", true) != 0)
				{
					goto IL_760;
				}
				IL_648:
				num2 = 64;
				if (dataColumnProperty.oO.OO..DataType == typeof(float) || dataColumnProperty.oO.OO..DataType == typeof(double) || dataColumnProperty.oO.OO..DataType == typeof(decimal) || dataColumnProperty.oO.OO..DataType == typeof(long) || dataColumnProperty.oO.OO..DataType == typeof(int) || dataColumnProperty.oO.OO..DataType == typeof(short) || dataColumnProperty.oO.OO..DataType == typeof(byte) || dataColumnProperty.oO.OO..DataType == typeof(DateTime))
				{
					goto IL_71E;
				}
				IL_714:
				num2 = 65;
				result = false;
				goto IL_235A;
				IL_71E:
				num2 = 66;
				if (dataColumnProperty.oO.OO..DataType != typeof(DateTime))
				{
					goto IL_7DA;
				}
				IL_73C:
				num2 = 67;
				if (dataColumnProperty.DateTimeFormat != DateTimeFormatEnum.Time && dataColumnProperty.DateTimeFormat != DateTimeFormatEnum.LongTime)
				{
					goto IL_7DA;
				}
				IL_756:
				num2 = 68;
				result = false;
				goto IL_235A;
				IL_760:
				num2 = 70;
				if (Operators.CompareString(left, "DataMapType", true) != 0 && Operators.CompareString(left, "ImageMapType", true) != 0 && Operators.CompareString(left, "ItemSpacing", true) != 0)
				{
					goto IL_7AC;
				}
				IL_790:
				num2 = 71;
				if (dataColumnProperty.oO.OO..ExtendColumnType != ExtendColumnTypeEnum.多值字段)
				{
					goto IL_7DA;
				}
				IL_7A2:
				num2 = 72;
				result = false;
				goto IL_235A;
				IL_7AC:
				num2 = 74;
				if (Operators.CompareString(left, "Separator", true) != 0)
				{
					goto IL_7DA;
				}
				IL_7BE:
				num2 = 75;
				if (dataColumnProperty.oO.OO..ExtendColumnType == ExtendColumnTypeEnum.多值字段)
				{
					goto IL_7DA;
				}
				IL_7D0:
				num2 = 76;
				result = false;
				goto IL_235A;
				IL_7DA:
				dataColumnProperty = null;
				goto IL_2352;
				IL_7E2:
				num2 = 79;
				if (!(A_0 is TableGridProperty))
				{
					goto IL_9C1;
				}
				IL_7F0:
				num2 = 80;
				TableGridProperty tableGridProperty = (TableGridProperty)A_0;
				IL_7FB:
				num2 = 81;
				string left2 = name;
				IL_802:
				num2 = 83;
				if (Operators.CompareString(left2, "Connection", true) != 0 && Operators.CompareString(left2, "SelectString", true) != 0)
				{
					goto IL_83C;
				}
				IL_823:
				num2 = 84;
				if (tableGridProperty.TableType != TableTypeEnum.Normal)
				{
					goto IL_8CD;
				}
				IL_832:
				num2 = 85;
				result = false;
				goto IL_235A;
				IL_83C:
				num2 = 87;
				if (Operators.CompareString(left2, "RelationTable", true) != 0 && Operators.CompareString(left2, "IsCopy", true) != 0)
				{
					goto IL_873;
				}
				IL_85D:
				num2 = 88;
				if (tableGridProperty.TableType == TableTypeEnum.Normal)
				{
					goto IL_8CD;
				}
				IL_869:
				num2 = 89;
				result = false;
				goto IL_235A;
				IL_873:
				num2 = 91;
				if (Operators.CompareString(left2, "AllowEdit", true) != 0)
				{
					goto IL_89C;
				}
				IL_885:
				num2 = 92;
				if (tableGridProperty.TableType != TableTypeEnum.SQLQuery)
				{
					goto IL_8CD;
				}
				IL_892:
				num2 = 93;
				result = false;
				goto IL_235A;
				IL_89C:
				num2 = 95;
				if (Operators.CompareString(left2, "Font", true) != 0)
				{
					goto IL_8CD;
				}
				IL_8AE:
				num2 = 96;
				if (tableGridProperty.TableType != TableTypeEnum.Normal || tableGridProperty.IsCopy)
				{
					goto IL_8CD;
				}
				IL_8C3:
				num2 = 97;
				result = false;
				goto IL_235A;
				IL_8CD:
				num2 = 98;
				if (A_1 == null || !O00OOOo_O0_O.Oo_o_o.__oo.(A_1))
				{
					goto IL_9B9;
				}
				IL_8E1:
				num2 = 99;
				if (tableGridProperty.TableType != TableTypeEnum.Normal)
				{
					goto IL_9B9;
				}
				IL_8F0:
				num2 = 100;
				if (!tableGridProperty.IsCopy)
				{
					goto IL_9AF;
				}
				IL_8FF:
				num2 = 101;
				string left3 = name;
				IL_906:
				num2 = 103;
				if (Operators.CompareString(left3, "CurrentChanged", true) == 0 || Operators.CompareString(left3, "PositionChanged", true) == 0 || Operators.CompareString(left3, "DoubleClick", true) == 0 || Operators.CompareString(left3, "KeyUp", true) == 0 || Operators.CompareString(left3, "KeyDown", true) == 0 || Operators.CompareString(left3, "BeforeCheckRow", true) == 0 || Operators.CompareString(left3, "AfterCheckRow", true) == 0 || Operators.CompareString(left3, "AfterScroll", true) == 0 || Operators.CompareString(left3, "Click", true) == 0 || Operators.CompareString(left3, "DoubleClickRowHeader", true) == 0)
				{
					goto IL_9B9;
				}
				IL_9A5:
				num2 = 105;
				result = false;
				goto IL_235A;
				IL_9AF:
				num2 = 107;
				result = false;
				goto IL_235A;
				IL_9B9:
				tableGridProperty = null;
				goto IL_2352;
				IL_9C1:
				num2 = 110;
				if (!(A_0 is FormProperty))
				{
					goto IL_D33;
				}
				IL_9CF:
				num2 = 111;
				if (Operators.CompareString(ooO.oo.00O0__o., OO_00oOO.ProjectFile, true) == 0)
				{
					goto IL_A70;
				}
				IL_9E7:
				num2 = 112;
				ooO.oo.00O0__o. = OO_00oOO.ProjectFile;
				IL_9F4:
				num2 = 113;
				if (O_O0OO.O0_00o.o0__o..LastLogon <= 21)
				{
					goto IL_A70;
				}
				IL_A05:
				num2 = 114;
				if (O_O0OO.oO.__0O0oooo.())
				{
					goto IL_A70;
				}
				IL_A0F:
				num2 = 115;
				if (O_O0OO.O_oO_o0O.o__.)
				{
					goto IL_A70;
				}
				IL_A19:
				num2 = 116;
				IEnumerator enumerator = O_O0OO.OoO.0OO__0ooo.().Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataTable dataTable = (DataTable)obj;
					IL_A3D:
					num2 = 117;
					dataTable.ExtendedProperties.Clear();
					IL_A4C:
					num2 = 118;
				}
				IL_A58:
				num2 = 119;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_A70:
				num2 = 120;
				FormProperty formProperty = (FormProperty)A_0;
				IL_A7B:
				num2 = 121;
				string left4 = category;
				IL_A82:
				num2 = 123;
				if (Operators.CompareString(left4, "停靠", true) != 0)
				{
					goto IL_AF1;
				}
				IL_A94:
				num2 = 124;
				if (Operators.CompareString(A_1.Name, "DockTitle", true) != 0)
				{
					goto IL_AC4;
				}
				IL_AAA:
				num2 = 125;
				if (formProperty.FormStyle == FormStyleEnum.停靠)
				{
					goto IL_D2B;
				}
				IL_ABA:
				num2 = 126;
				result = false;
				goto IL_235A;
				IL_AC4:
				num2 = 128;
				if (formProperty.FormStyle == FormStyleEnum.停靠 || formProperty.FormStyle == FormStyleEnum.共有)
				{
					goto IL_D2B;
				}
				IL_AE4:
				num2 = 129;
				result = false;
				goto IL_235A;
				IL_AF1:
				num2 = 131;
				if (Operators.CompareString(left4, "位置", true) != 0 && Operators.CompareString(left4, "行为", true) != 0)
				{
					goto IL_B81;
				}
				IL_B15:
				num2 = 132;
				if (formProperty.FormStyle == FormStyleEnum.独立 || formProperty.FormStyle == FormStyleEnum.模式 || formProperty.FormStyle == FormStyleEnum.PopupForm)
				{
					goto IL_D2B;
				}
				IL_B42:
				num2 = 133;
				if (Operators.CompareString(A_1.Name, "Height", true) == 0 || Operators.CompareString(A_1.Name, "Width", true) == 0)
				{
					goto IL_D2B;
				}
				IL_B74:
				num2 = 134;
				result = false;
				goto IL_235A;
				IL_B81:
				num2 = 136;
				string name2 = A_1.Name;
				IL_B8F:
				num2 = 138;
				if (Operators.CompareString(name2, "ShowIcon", true) != 0 && Operators.CompareString(name2, "ControlBox", true) != 0)
				{
					goto IL_BED;
				}
				IL_BB3:
				num2 = 139;
				if (formProperty.FormStyle == FormStyleEnum.独立 || formProperty.FormStyle == FormStyleEnum.模式 || formProperty.FormStyle == FormStyleEnum.PopupForm)
				{
					goto IL_D2B;
				}
				IL_BE0:
				num2 = 140;
				result = false;
				goto IL_235A;
				IL_BED:
				num2 = 142;
				if (Operators.CompareString(name2, "MaximizeBox", true) != 0 && Operators.CompareString(name2, "MinimizeBox", true) != 0 && Operators.CompareString(name2, "ResizingControl", true) != 0 && Operators.CompareString(name2, "ResizingFont", true) != 0 && Operators.CompareString(name2, "AutoLayout", true) != 0)
				{
					goto IL_C6B;
				}
				IL_C3E:
				num2 = 143;
				if (formProperty.FormStyle == FormStyleEnum.独立 || formProperty.FormStyle == FormStyleEnum.模式)
				{
					goto IL_D2B;
				}
				IL_C5E:
				num2 = 144;
				result = false;
				goto IL_235A;
				IL_C6B:
				num2 = 146;
				if (Operators.CompareString(name2, "TabAlignment", true) != 0)
				{
					goto IL_C9F;
				}
				IL_C80:
				num2 = 147;
				if (formProperty.FormStyle == FormStyleEnum.并列)
				{
					goto IL_D2B;
				}
				IL_C92:
				num2 = 148;
				result = false;
				goto IL_235A;
				IL_C9F:
				num2 = 150;
				if (Operators.CompareString(name2, "AutoOpen", true) != 0)
				{
					goto IL_CDB;
				}
				IL_CB4:
				num2 = 151;
				if (formProperty.FormStyle != FormStyleEnum.模式 && formProperty.FormStyle != FormStyleEnum.DropDownForm)
				{
					goto IL_D2B;
				}
				IL_CCE:
				num2 = 152;
				result = false;
				goto IL_235A;
				IL_CDB:
				num2 = 154;
				if (Operators.CompareString(name2, "DropDownOpened", true) != 0 && Operators.CompareString(name2, "DropDownOpening", true) != 0 && Operators.CompareString(name2, "DropDownClosed", true) != 0)
				{
					goto IL_D2B;
				}
				IL_D0E:
				num2 = 155;
				if (formProperty.FormStyle == FormStyleEnum.DropDownForm)
				{
					goto IL_D2B;
				}
				IL_D1E:
				num2 = 156;
				result = false;
				goto IL_235A;
				IL_D2B:
				formProperty = null;
				goto IL_2352;
				IL_D33:
				num2 = 159;
				if (!(A_0 is BarCodeProperty) && !(A_0 is BarcodeProfessionalProperty))
				{
					goto IL_153F;
				}
				IL_D4C:
				num2 = 160;
				if (!(A_0 is BarCodeProperty))
				{
					goto IL_D79;
				}
				IL_D5A:
				num2 = 161;
				BarCodeProperty barCodeProperty = (BarCodeProperty)A_0;
				IL_D68:
				num2 = 162;
				Symbology symbology = barCodeProperty.Symbology;
				goto IL_D96;
				IL_D79:
				num2 = 164;
				BarcodeProfessionalProperty barcodeProfessionalProperty = (BarcodeProfessionalProperty)A_0;
				IL_D87:
				num2 = 165;
				symbology = barcodeProfessionalProperty.Symbology;
				IL_D96:
				num2 = 166;
				string left5 = category;
				IL_DA0:
				num2 = 168;
				if (Operators.CompareString(left5, "条码设置 - AztecCode", true) != 0)
				{
					goto IL_DD1;
				}
				IL_DB5:
				num2 = 169;
				if (symbology == Symbology.AztecCode)
				{
					goto IL_2352;
				}
				IL_DC4:
				num2 = 170;
				result = false;
				goto IL_235A;
				IL_DD1:
				num2 = 172;
				if (Operators.CompareString(left5, "条码设置 - Codabar", true) != 0)
				{
					goto IL_E00;
				}
				IL_DE6:
				num2 = 173;
				if (symbology == Symbology.Codabar)
				{
					goto IL_2352;
				}
				IL_DF3:
				num2 = 174;
				result = false;
				goto IL_235A;
				IL_E00:
				num2 = 176;
				if (Operators.CompareString(left5, "条码设置 - Code128", true) != 0)
				{
					goto IL_E30;
				}
				IL_E15:
				num2 = 177;
				if (symbology == Symbology.Code128)
				{
					goto IL_2352;
				}
				IL_E23:
				num2 = 178;
				result = false;
				goto IL_235A;
				IL_E30:
				num2 = 180;
				if (Operators.CompareString(left5, "条码设置 - Code16K", true) != 0)
				{
					goto IL_E60;
				}
				IL_E45:
				num2 = 181;
				if (symbology == Symbology.Code16k)
				{
					goto IL_2352;
				}
				IL_E53:
				num2 = 182;
				result = false;
				goto IL_235A;
				IL_E60:
				num2 = 184;
				if (Operators.CompareString(left5, "条码设置 - DataMatrix", true) != 0)
				{
					goto IL_E90;
				}
				IL_E75:
				num2 = 185;
				if (symbology == Symbology.DataMatrix)
				{
					goto IL_2352;
				}
				IL_E83:
				num2 = 186;
				result = false;
				goto IL_235A;
				IL_E90:
				num2 = 188;
				if (Operators.CompareString(left5, "条码设置 - Ean And Upc", true) != 0)
				{
					goto IL_F28;
				}
				IL_EA8:
				num2 = 189;
				if (symbology <= Symbology.UpcA)
				{
					switch (symbology)
					{
					case Symbology.Ean8:
					case Symbology.Ean13:
					case Symbology.Isbn:
						goto IL_2352;
					case Symbology.Industrial2of5:
					case Symbology.Interleaved2of5:
						break;
					default:
						if (symbology == Symbology.UpcA)
						{
							goto IL_2352;
						}
						break;
					}
				}
				else
				{
					if (symbology == Symbology.UpcE)
					{
						goto IL_2352;
					}
					switch (symbology)
					{
					case Symbology.EanVelocity:
					case Symbology.Jan8:
					case Symbology.Jan13:
					case Symbology.Ean99:
					case Symbology.Issn:
					case Symbology.Ismn:
						goto IL_2352;
					}
				}
				IL_F1B:
				num2 = 202;
				result = false;
				goto IL_235A;
				IL_F28:
				num2 = 205;
				if (Operators.CompareString(left5, "条码设置 - ExpandedStacked", true) != 0)
				{
					goto IL_F68;
				}
				IL_F3D:
				num2 = 206;
				if (!(symbology != Symbology.GS1DataBarExpandedStacked & symbology != Symbology.RssExpandedStacked))
				{
					goto IL_2352;
				}
				IL_F5B:
				num2 = 207;
				result = false;
				goto IL_235A;
				IL_F68:
				num2 = 209;
				if (Operators.CompareString(left5, "条码设置 - HIBC", true) != 0)
				{
					goto IL_FAA;
				}
				IL_F7D:
				num2 = 210;
				switch (symbology)
				{
				case Symbology.HibcLic39:
				case Symbology.HibcLic128:
				case Symbology.HibcPas39:
				case Symbology.HibcPas128:
					IL_2352:
					num2 = 534;
					result = true;
					goto IL_235A;
				default:
					IL_F9D:
					num2 = 216;
					result = false;
					goto IL_235A;
				}
				IL_FAA:
				num2 = 219;
				if (Operators.CompareString(left5, "条码设置 - ISBT", true) != 0)
				{
					goto IL_FDB;
				}
				IL_FBF:
				num2 = 220;
				if (symbology == Symbology.Isbt128)
				{
					goto IL_2352;
				}
				IL_FCE:
				num2 = 221;
				result = false;
				goto IL_235A;
				IL_FDB:
				num2 = 223;
				if (Operators.CompareString(left5, "条码设置 - MaxiCode", true) != 0)
				{
					goto IL_100C;
				}
				IL_FF0:
				num2 = 224;
				if (symbology == Symbology.MaxiCode)
				{
					goto IL_2352;
				}
				IL_FFF:
				num2 = 225;
				result = false;
				goto IL_235A;
				IL_100C:
				num2 = 227;
				if (Operators.CompareString(left5, "条码设置 - MSI", true) != 0)
				{
					goto IL_103D;
				}
				IL_1021:
				num2 = 228;
				if (symbology == Symbology.Msi)
				{
					goto IL_2352;
				}
				IL_1030:
				num2 = 229;
				result = false;
				goto IL_235A;
				IL_103D:
				num2 = 231;
				if (Operators.CompareString(left5, "条码设置 - PDF417", true) != 0)
				{
					goto IL_110B;
				}
				IL_1055:
				num2 = 232;
				string left6 = name;
				IL_105F:
				num2 = 234;
				if (Operators.CompareString(left6, "MicroPdf417Version", true) != 0)
				{
					goto IL_108D;
				}
				IL_1074:
				num2 = 235;
				if (symbology == Symbology.MicroPdf417)
				{
					goto IL_10D9;
				}
				IL_1080:
				num2 = 236;
				result = false;
				goto IL_235A;
				IL_108D:
				num2 = 238;
				if (Operators.CompareString(left6, "Pdf417FileId", true) != 0 && Operators.CompareString(left6, "Pdf417SegmentCount", true) != 0 && Operators.CompareString(left6, "Pdf417SegmentIndex", true) != 0)
				{
					goto IL_10D9;
				}
				IL_10C0:
				num2 = 239;
				if (symbology == Symbology.MacroPdf417)
				{
					goto IL_10D9;
				}
				IL_10CC:
				num2 = 240;
				result = false;
				goto IL_235A;
				IL_10D9:
				num2 = 241;
				if (symbology == Symbology.Pdf417)
				{
					goto IL_2352;
				}
				switch (symbology)
				{
				case Symbology.CompactPdf417:
				case Symbology.MacroPdf417:
				case Symbology.MicroPdf417:
					goto IL_2352;
				default:
					IL_10FE:
					num2 = 247;
					result = false;
					goto IL_235A;
				}
				IL_110B:
				num2 = 250;
				if (Operators.CompareString(left5, "条码设置 - Pharmacode", true) != 0)
				{
					goto IL_113C;
				}
				IL_1120:
				num2 = 251;
				if (symbology == Symbology.Pharmacode)
				{
					goto IL_2352;
				}
				IL_112F:
				num2 = 252;
				result = false;
				goto IL_235A;
				IL_113C:
				num2 = 254;
				if (Operators.CompareString(left5, "条码设置 - Planet", true) != 0)
				{
					goto IL_116D;
				}
				IL_1151:
				num2 = 255;
				if (symbology == Symbology.Planet)
				{
					goto IL_2352;
				}
				IL_1160:
				num2 = 256;
				result = false;
				goto IL_235A;
				IL_116D:
				num2 = 258;
				if (Operators.CompareString(left5, "条码设置 - Postal 4-State", true) != 0)
				{
					goto IL_11EC;
				}
				IL_1182:
				num2 = 259;
				if (Operators.CompareString(name, "Postal4StateAddStartStopChar", true) != 0)
				{
					goto IL_11B6;
				}
				IL_1197:
				num2 = 260;
				if (symbology == Symbology.SingaporePost || symbology == Symbology.RoyalMail)
				{
					goto IL_11B6;
				}
				IL_11A9:
				num2 = 261;
				result = false;
				goto IL_235A;
				IL_11B6:
				num2 = 262;
				switch (symbology)
				{
				case Symbology.UspsOneCode4CB:
				case Symbology.RoyalMail:
				case Symbology.AustraliaPost:
				case Symbology.RoyalTpgPostKix:
					goto IL_2352;
				default:
					if (symbology == Symbology.SingaporePost)
					{
						goto IL_2352;
					}
					IL_11DF:
					num2 = 269;
					result = false;
					goto IL_235A;
				}
				IL_11EC:
				num2 = 272;
				if (Operators.CompareString(left5, "条码设置 - Postnet", true) != 0)
				{
					goto IL_121D;
				}
				IL_1201:
				num2 = 273;
				if (symbology == Symbology.Postnet)
				{
					goto IL_2352;
				}
				IL_1210:
				num2 = 274;
				result = false;
				goto IL_235A;
				IL_121D:
				num2 = 276;
				if (Operators.CompareString(left5, "条码设置 - QR Code", true) != 0)
				{
					goto IL_12C2;
				}
				IL_1235:
				num2 = 277;
				if (!(symbology != Symbology.QRCode & symbology != Symbology.MicroQRCode))
				{
					goto IL_125D;
				}
				IL_1250:
				num2 = 278;
				result = false;
				goto IL_235A;
				IL_125D:
				num2 = 280;
				if (symbology != Symbology.MicroQRCode)
				{
					goto IL_128E;
				}
				IL_1269:
				num2 = 281;
				if (Operators.CompareString(name, "QRCodeVersion", true) != 0)
				{
					goto IL_2352;
				}
				IL_1281:
				num2 = 282;
				result = false;
				goto IL_235A;
				IL_128E:
				num2 = 284;
				if (symbology != Symbology.QRCode)
				{
					goto IL_2352;
				}
				IL_129D:
				num2 = 285;
				if (Operators.CompareString(name, "MicroQRCodeVersion", true) != 0)
				{
					goto IL_2352;
				}
				IL_12B5:
				num2 = 286;
				result = false;
				goto IL_235A;
				IL_12C2:
				num2 = 288;
				if (Operators.CompareString(left5, "条码设置 - Telepen", true) != 0)
				{
					goto IL_12F3;
				}
				IL_12D7:
				num2 = 289;
				if (symbology == Symbology.Telepen)
				{
					goto IL_2352;
				}
				IL_12E6:
				num2 = 290;
				result = false;
				goto IL_235A;
				IL_12F3:
				num2 = 292;
				if (Operators.CompareString(left5, "条码设置 - USPS FIM", true) != 0)
				{
					goto IL_1324;
				}
				IL_1308:
				num2 = 293;
				if (symbology == Symbology.UspsFim)
				{
					goto IL_2352;
				}
				IL_1317:
				num2 = 294;
				result = false;
				goto IL_235A;
				IL_1324:
				num2 = 296;
				if (Operators.CompareString(left5, "条码设置 - USPS Horizontal Bars", true) != 0)
				{
					goto IL_1355;
				}
				IL_1339:
				num2 = 297;
				if (symbology == Symbology.UspsHorizontalBars)
				{
					goto IL_2352;
				}
				IL_1348:
				num2 = 298;
				result = false;
				goto IL_235A;
				IL_1355:
				num2 = 300;
				if (Operators.CompareString(left5, "条码设置 - 文本", true) != 0)
				{
					goto IL_13F6;
				}
				IL_136D:
				num2 = 301;
				if (symbology <= Symbology.Pdf417)
				{
					if (symbology != Symbology.Code16k && symbology != Symbology.DataMatrix && symbology != Symbology.Pdf417)
					{
						goto IL_2352;
					}
				}
				else if (symbology <= Symbology.Semacode)
				{
					if (symbology != Symbology.QRCode && symbology != Symbology.Semacode)
					{
						goto IL_2352;
					}
				}
				else if (symbology - Symbology.AztecCode > 3 && symbology - Symbology.MaxiCode > 1)
				{
					goto IL_2352;
				}
				IL_13B8:
				num2 = 303;
				string left7 = name;
				IL_13C2:
				num2 = 305;
				if (Operators.CompareString(left7, "DisplayChecksum", true) != 0 && Operators.CompareString(left7, "DisplayStartStopChar", true) != 0)
				{
					goto IL_2352;
				}
				IL_13E9:
				num2 = 306;
				result = false;
				goto IL_235A;
				IL_13F6:
				num2 = 309;
				if (Operators.CompareString(left5, "条码设置", true) != 0)
				{
					goto IL_2352;
				}
				IL_140E:
				num2 = 310;
				if (symbology <= Symbology.DataMatrix)
				{
					if (symbology != Symbology.Code16k)
					{
						if (symbology != Symbology.DataMatrix)
						{
							goto IL_2352;
						}
						goto IL_14DA;
					}
				}
				else
				{
					switch (symbology)
					{
					case Symbology.QRCode:
					case Symbology.Semacode:
						goto IL_14DA;
					case Symbology.UspsFim:
					case Symbology.UspsHorizontalBars:
						break;
					case Symbology.Telepen:
					case Symbology.Pharmacode:
						goto IL_2352;
					default:
						if (symbology != Symbology.AztecCode && symbology - Symbology.MaxiCode > 1)
						{
							goto IL_2352;
						}
						goto IL_14DA;
					}
				}
				IL_1463:
				num2 = 312;
				string left8 = name;
				IL_146D:
				num2 = 314;
				if (Operators.CompareString(left8, "CodeType", true) == 0 || Operators.CompareString(left8, "Rotate", true) == 0 || Operators.CompareString(left8, "BarWidth", true) == 0 || Operators.CompareString(left8, "BarHeight", true) == 0 || Operators.CompareString(left8, "QuietZoneWidth", true) == 0)
				{
					goto IL_2352;
				}
				IL_14CD:
				num2 = 316;
				result = false;
				goto IL_235A;
				IL_14DA:
				num2 = 318;
				string left9 = name;
				IL_14E4:
				num2 = 320;
				if (Operators.CompareString(left9, "CodeType", true) == 0 || Operators.CompareString(left9, "Code", true) == 0 || Operators.CompareString(left9, "Rotate", true) == 0 || Operators.CompareString(left9, "QuietZoneWidth", true) == 0)
				{
					goto IL_2352;
				}
				IL_1532:
				num2 = 322;
				result = false;
				goto IL_235A;
				IL_153F:
				num2 = 325;
				if (!(A_0 is TreeViewProperty))
				{
					goto IL_15E0;
				}
				IL_1550:
				num2 = 326;
				System.Windows.Forms.TreeView treeView = (System.Windows.Forms.TreeView)((TreeViewProperty)A_0).o_O0.O_.;
				IL_1568:
				num2 = 327;
				if (!name.StartsWith("Node") || Operators.CompareString(category, "事件", true) == 0 || Operators.CompareString(name, "NodesSettingString", true) == 0)
				{
					goto IL_15B6;
				}
				IL_159A:
				num2 = 328;
				if (treeView.SelectedNode != null)
				{
					goto IL_15B6;
				}
				IL_15A9:
				num2 = 329;
				result = false;
				goto IL_235A;
				IL_15B6:
				num2 = 330;
				if (Operators.CompareString(category, "输出", true) != 0)
				{
					goto IL_15D8;
				}
				IL_15CB:
				num2 = 331;
				result = false;
				goto IL_235A;
				IL_15D8:
				treeView = null;
				goto IL_2352;
				IL_15E0:
				num2 = 334;
				if (!(A_0 is ChartProperty))
				{
					goto IL_1613;
				}
				IL_15EE:
				num2 = 335;
				if (Operators.CompareString(category, "事件", true) != 0)
				{
					goto IL_2352;
				}
				IL_1606:
				num2 = 336;
				result = false;
				goto IL_235A;
				IL_1613:
				num2 = 338;
				if (!(A_0 is FileManagerProperty))
				{
					goto IL_172D;
				}
				IL_1624:
				num2 = 339;
				FileManagerProperty fileManagerProperty = (FileManagerProperty)A_0;
				IL_1632:
				num2 = 340;
				string left10 = name;
				IL_163C:
				num2 = 342;
				if (Operators.CompareString(left10, "Host", true) != 0 && Operators.CompareString(left10, "Account", true) != 0 && Operators.CompareString(left10, "Password", true) != 0 && Operators.CompareString(left10, "RootDir", true) != 0 && Operators.CompareString(left10, "UTF8", true) != 0 && Operators.CompareString(left10, "AutoUpdate", true) != 0 && Operators.CompareString(left10, "Port", true) != 0)
				{
					goto IL_16C7;
				}
				IL_16AB:
				num2 = 343;
				if (fileManagerProperty.Remote)
				{
					goto IL_1725;
				}
				IL_16BA:
				num2 = 344;
				result = false;
				goto IL_235A;
				IL_16C7:
				num2 = 346;
				if (Operators.CompareString(left10, "AutoCopyAttachFile", true) != 0 && Operators.CompareString(left10, "FileFilter", true) != 0 && Operators.CompareString(left10, "FolderName", true) != 0 && Operators.CompareString(left10, "SourceFolder", true) != 0)
				{
					goto IL_1725;
				}
				IL_1709:
				num2 = 347;
				if (!fileManagerProperty.Remote)
				{
					goto IL_1725;
				}
				IL_1718:
				num2 = 348;
				result = false;
				goto IL_235A;
				IL_1725:
				fileManagerProperty = null;
				goto IL_2352;
				IL_172D:
				num2 = 351;
				if (!(A_0 is PictureViewerProperty))
				{
					goto IL_1856;
				}
				IL_173E:
				num2 = 352;
				PictureViewerProperty pictureViewerProperty = (PictureViewerProperty)A_0;
				IL_174C:
				num2 = 353;
				string left11 = name;
				IL_1756:
				num2 = 355;
				if (Operators.CompareString(left11, "Host", true) != 0 && Operators.CompareString(left11, "Account", true) != 0 && Operators.CompareString(left11, "Password", true) != 0 && Operators.CompareString(left11, "RootDir", true) != 0 && Operators.CompareString(left11, "UTF8", true) != 0 && Operators.CompareString(left11, "AutoDownload", true) != 0 && Operators.CompareString(left11, "AutoUpdate", true) != 0 && Operators.CompareString(left11, "Port", true) != 0)
				{
					goto IL_17F0;
				}
				IL_17D4:
				num2 = 356;
				if (pictureViewerProperty.Remote)
				{
					goto IL_184E;
				}
				IL_17E3:
				num2 = 357;
				result = false;
				goto IL_235A;
				IL_17F0:
				num2 = 359;
				if (Operators.CompareString(left11, "AutoCopyAttachFile", true) != 0 && Operators.CompareString(left11, "FileFilter", true) != 0 && Operators.CompareString(left11, "FolderName", true) != 0 && Operators.CompareString(left11, "SourceFolder", true) != 0)
				{
					goto IL_184E;
				}
				IL_1832:
				num2 = 360;
				if (!pictureViewerProperty.Remote)
				{
					goto IL_184E;
				}
				IL_1841:
				num2 = 361;
				result = false;
				goto IL_235A;
				IL_184E:
				pictureViewerProperty = null;
				goto IL_2352;
				IL_1856:
				num2 = 364;
				if (!(A_0 is PictureBoxProperty))
				{
					goto IL_1934;
				}
				IL_1867:
				num2 = 365;
				PictureBoxProperty pictureBoxProperty = (PictureBoxProperty)A_0;
				IL_1875:
				num2 = 366;
				string left12 = name;
				IL_187F:
				num2 = 368;
				if (Operators.CompareString(left12, "Host", true) != 0 && Operators.CompareString(left12, "Account", true) != 0 && Operators.CompareString(left12, "Password", true) != 0 && Operators.CompareString(left12, "UTF8", true) != 0 && Operators.CompareString(left12, "AutoUpdate", true) != 0 && Operators.CompareString(left12, "Port", true) != 0)
				{
					goto IL_18FB;
				}
				IL_18DF:
				num2 = 369;
				if (pictureBoxProperty.Remote)
				{
					goto IL_192C;
				}
				IL_18EE:
				num2 = 370;
				result = false;
				goto IL_235A;
				IL_18FB:
				num2 = 372;
				if (Operators.CompareString(left12, "FolderName", true) != 0)
				{
					goto IL_192C;
				}
				IL_1910:
				num2 = 373;
				if (!pictureBoxProperty.Remote)
				{
					goto IL_192C;
				}
				IL_191F:
				num2 = 374;
				result = false;
				goto IL_235A;
				IL_192C:
				pictureBoxProperty = null;
				goto IL_2352;
				IL_1934:
				num2 = 377;
				if (!(A_0 is ControlPropertyBase))
				{
					goto IL_1FA2;
				}
				IL_1945:
				num2 = 378;
				ControlPropertyBase controlPropertyBase = (ControlPropertyBase)A_0;
				IL_1953:
				num2 = 379;
				if (!(controlPropertyBase.o_O0.O_. is C1TextBox))
				{
					goto IL_1A09;
				}
				IL_196A:
				num2 = 380;
				string left13 = name;
				IL_1974:
				num2 = 382;
				if (Operators.CompareString(left13, "BackColor", true) != 0 && Operators.CompareString(left13, "ForeColor", true) != 0 && Operators.CompareString(left13, "BorderColor", true) != 0 && Operators.CompareString(left13, "BorderStyle", true) != 0)
				{
					goto IL_1A89;
				}
				IL_19B9:
				num2 = 383;
				string left14 = Main.OO_O.o..o0_o_o_0.0O.(controlPropertyBase.o_O0.O_.);
				IL_19D2:
				num2 = 384;
				if (Operators.CompareString(left14, "(none)", true) == 0 || Operators.CompareString(left14, "", true) == 0)
				{
					goto IL_1A89;
				}
				IL_19FC:
				num2 = 385;
				result = false;
				goto IL_235A;
				IL_1A09:
				num2 = 387;
				if (!(controlPropertyBase.o_O0.O_. is oo00))
				{
					goto IL_1A89;
				}
				IL_1A1D:
				num2 = 388;
				string left15 = name;
				IL_1A27:
				num2 = 390;
				if (Operators.CompareString(left15, "Cursor", true) != 0 && Operators.CompareString(left15, "ForeColor", true) != 0 && Operators.CompareString(left15, "Font", true) != 0)
				{
					goto IL_1A67;
				}
				IL_1A5A:
				num2 = 391;
				result = false;
				goto IL_235A;
				IL_1A67:
				num2 = 392;
				if (Operators.CompareString(category, "事件", true) != 0)
				{
					goto IL_1A89;
				}
				IL_1A7C:
				num2 = 393;
				result = false;
				goto IL_235A;
				IL_1A89:
				controlPropertyBase = null;
				IL_1A8C:
				num2 = 395;
				string left16 = name;
				IL_1A96:
				num2 = 397;
				if (Operators.CompareString(left16, "ForeColor", true) != 0 && Operators.CompareString(left16, "Font", true) != 0)
				{
					goto IL_1B91;
				}
				IL_1ABD:
				num2 = 398;
				if (!(A_0 is CheckBoxProperty))
				{
					goto IL_1B07;
				}
				IL_1ACB:
				num2 = 399;
				if (Operators.CompareString(name, "ForeColor", true) != 0)
				{
					goto IL_1F6C;
				}
				IL_1AE3:
				num2 = 400;
				if (((CheckBoxProperty)A_0).Appearance != Appearance.Button)
				{
					goto IL_1F6C;
				}
				IL_1AFA:
				num2 = 401;
				result = false;
				goto IL_235A;
				IL_1B07:
				num2 = 403;
				ControlTypeEnum controlTypeEnum = ((ControlPropertyBase)A_0).Type;
				if (controlTypeEnum <= ControlTypeEnum.PictureBox)
				{
					if (controlTypeEnum != ControlTypeEnum.Button)
					{
						if (controlTypeEnum - ControlTypeEnum.Panel > 2)
						{
							goto IL_1F6C;
						}
						goto IL_1B49;
					}
					IL_1B56:
					num2 = 407;
					if (Operators.CompareString(name, "ForeColor", true) != 0)
					{
						goto IL_1F6C;
					}
					IL_1B6E:
					num2 = 408;
					if (((ButtonProperty)A_0).FlatStyle == FlatStyle.Flat)
					{
						goto IL_1F6C;
					}
					IL_1B84:
					num2 = 409;
					result = false;
					goto IL_235A;
				}
				if (controlTypeEnum != ControlTypeEnum.ColorLabel && controlTypeEnum - ControlTypeEnum.WebBrowser > 1 && controlTypeEnum != ControlTypeEnum.PDFViewer)
				{
					goto IL_1F6C;
				}
				IL_1B49:
				num2 = 405;
				result = false;
				goto IL_235A;
				IL_1B91:
				num2 = 412;
				if (Operators.CompareString(left16, "Cursor", true) != 0)
				{
					goto IL_1BCB;
				}
				IL_1BA6:
				num2 = 413;
				if (((ControlPropertyBase)A_0).Type != ControlTypeEnum.WebBrowser)
				{
					goto IL_1F6C;
				}
				IL_1BBE:
				num2 = 414;
				result = false;
				goto IL_235A;
				IL_1BCB:
				num2 = 416;
				if (Operators.CompareString(left16, "Printable", true) != 0 && Operators.CompareString(left16, "NewPage", true) != 0)
				{
					goto IL_1CB9;
				}
				IL_1BF2:
				num2 = 417;
				ControlTypeEnum controlTypeEnum2 = ((ControlPropertyBase)A_0).Type;
				if (controlTypeEnum2 <= ControlTypeEnum.DropDownBox)
				{
					switch (controlTypeEnum2)
					{
					case ControlTypeEnum.Label:
					case ControlTypeEnum.TextBox:
					case ControlTypeEnum.CheckBox:
					case ControlTypeEnum.RadioButton:
					case ControlTypeEnum.ComboBox:
					case ControlTypeEnum.NumericComboBox:
					case ControlTypeEnum.DateTimePicker:
					case ControlTypeEnum.PictureBox:
						goto IL_1F6C;
					case ControlTypeEnum.Button:
					case ControlTypeEnum.TopicBar:
					case ControlTypeEnum.ListBox:
					case ControlTypeEnum.CheckedListBox:
					case ControlTypeEnum.GroupBox:
					case ControlTypeEnum.Panel:
					case ControlTypeEnum.SplitContainer:
						break;
					default:
						switch (controlTypeEnum2)
						{
						case ControlTypeEnum.Chart:
						case ControlTypeEnum.ColorLabel:
						case ControlTypeEnum.CheckedComboBox:
						case ControlTypeEnum.Painter:
						case ControlTypeEnum.Line:
						case ControlTypeEnum.BarCode:
						case ControlTypeEnum.DropDownBox:
							goto IL_1F6C;
						}
						break;
					}
				}
				else if (controlTypeEnum2 == ControlTypeEnum.TimeSpanBox || controlTypeEnum2 == ControlTypeEnum.Gauges || controlTypeEnum2 == ControlTypeEnum.Map)
				{
					goto IL_1F6C;
				}
				IL_1CAC:
				num2 = 420;
				result = false;
				goto IL_235A;
				IL_1CB9:
				num2 = 423;
				if (Operators.CompareString(left16, "PrintBorder", true) != 0)
				{
					goto IL_1D3C;
				}
				IL_1CCE:
				num2 = 424;
				ControlTypeEnum controlTypeEnum3 = ((ControlPropertyBase)A_0).Type;
				if (controlTypeEnum3 <= ControlTypeEnum.CheckedComboBox)
				{
					switch (controlTypeEnum3)
					{
					case ControlTypeEnum.Label:
					case ControlTypeEnum.TextBox:
					case ControlTypeEnum.ComboBox:
					case ControlTypeEnum.NumericComboBox:
					case ControlTypeEnum.DateTimePicker:
						goto IL_1F6C;
					case ControlTypeEnum.Button:
					case ControlTypeEnum.CheckBox:
					case ControlTypeEnum.RadioButton:
					case ControlTypeEnum.TopicBar:
						break;
					default:
						if (controlTypeEnum3 == ControlTypeEnum.CheckedComboBox)
						{
							goto IL_1F6C;
						}
						break;
					}
				}
				else if (controlTypeEnum3 == ControlTypeEnum.DropDownBox || controlTypeEnum3 == ControlTypeEnum.TimeSpanBox)
				{
					goto IL_1F6C;
				}
				IL_1D2F:
				num2 = 427;
				result = false;
				goto IL_235A;
				IL_1D3C:
				num2 = 430;
				if (Operators.CompareString(left16, "MinRows", true) != 0 && Operators.CompareString(left16, "MaxRows", true) != 0)
				{
					goto IL_1D8C;
				}
				IL_1D60:
				num2 = 431;
				ControlTypeEnum controlTypeEnum4 = ((ControlPropertyBase)A_0).Type;
				if (controlTypeEnum4 == ControlTypeEnum.Table)
				{
					goto IL_1F6C;
				}
				IL_1D7F:
				num2 = 434;
				result = false;
				goto IL_235A;
				IL_1D8C:
				num2 = 437;
				if (Operators.CompareString(left16, "BackColor", true) != 0 && Operators.CompareString(left16, "BorderColor", true) != 0 && Operators.CompareString(left16, "BorderSize", true) != 0 && Operators.CompareString(left16, "MouseDownBackColor", true) != 0 && Operators.CompareString(left16, "MouseOverBackColor", true) != 0)
				{
					goto IL_1E61;
				}
				IL_1DE0:
				num2 = 438;
				if (!(A_0 is ButtonProperty))
				{
					goto IL_1E11;
				}
				IL_1DEE:
				num2 = 439;
				if (((ButtonProperty)A_0).FlatStyle == FlatStyle.Flat)
				{
					goto IL_1F6C;
				}
				IL_1E04:
				num2 = 440;
				result = false;
				goto IL_235A;
				IL_1E11:
				num2 = 442;
				if (!(A_0 is WebBrowserProperty))
				{
					goto IL_1E2C;
				}
				IL_1E1F:
				num2 = 443;
				result = false;
				goto IL_235A;
				IL_1E2C:
				num2 = 445;
				if (!(A_0 is CheckBoxProperty))
				{
					goto IL_1F6C;
				}
				IL_1E3D:
				num2 = 446;
				if (((CheckBoxProperty)A_0).Appearance != Appearance.Button)
				{
					goto IL_1F6C;
				}
				IL_1E54:
				num2 = 447;
				result = false;
				goto IL_235A;
				IL_1E61:
				num2 = 449;
				if (Operators.CompareString(left16, "VisualStyle", true) != 0)
				{
					goto IL_1EAB;
				}
				IL_1E76:
				num2 = 450;
				if (!(A_0 is ButtonProperty))
				{
					goto IL_1F6C;
				}
				IL_1E87:
				num2 = 451;
				if (((ButtonProperty)A_0).FlatStyle == FlatStyle.Standard)
				{
					goto IL_1F6C;
				}
				IL_1E9E:
				num2 = 452;
				result = false;
				goto IL_235A;
				IL_1EAB:
				num2 = 454;
				if (Operators.CompareString(left16, "DataFormat", true) != 0)
				{
					goto IL_1F14;
				}
				IL_1EC0:
				num2 = 455;
				if (A_0 is TextBoxProperty || A_0 is ComboboxProperty || A_0 is CheckedComboBoxProperty || A_0 is NumericComboBoxProperty || A_0 is DateTimePickerProperty || A_0 is TimeSpanBoxProperty || A_0 is LabelProperty)
				{
					goto IL_1F6C;
				}
				IL_1F07:
				num2 = 457;
				result = false;
				goto IL_235A;
				IL_1F14:
				num2 = 459;
				if (Operators.CompareString(left16, "DataParse", true) != 0)
				{
					goto IL_1F6C;
				}
				IL_1F29:
				num2 = 460;
				if (A_0 is TextBoxProperty || A_0 is ComboboxProperty || A_0 is CheckedComboBoxProperty || A_0 is NumericComboBoxProperty || A_0 is DateTimePickerProperty || A_0 is TimeSpanBoxProperty)
				{
					goto IL_1F6C;
				}
				IL_1F5F:
				num2 = 462;
				result = false;
				goto IL_235A;
				IL_1F6C:
				num2 = 463;
				if (Operators.CompareString(category, "外观", true) != 0)
				{
					goto IL_2352;
				}
				IL_1F84:
				num2 = 464;
				if (!(A_0 is ProgressBarProperty))
				{
					goto IL_2352;
				}
				IL_1F95:
				num2 = 465;
				result = false;
				goto IL_235A;
				IL_1FA2:
				num2 = 467;
				if (!(A_0 is RibbonItem))
				{
					goto IL_200C;
				}
				IL_1FB0:
				num2 = 468;
				RibbonItemTypeEnum ribbonItemTypeEnum = (RibbonItemTypeEnum)Conversions.ToInteger(((RibbonItem)A_0).DataRow["Type"]);
				if (ribbonItemTypeEnum != RibbonItemTypeEnum.PaperList && ribbonItemTypeEnum != RibbonItemTypeEnum.WindowList && ribbonItemTypeEnum - RibbonItemTypeEnum.TableViewList > 5)
				{
					goto IL_2352;
				}
				IL_1FE7:
				num2 = 470;
				if (Operators.CompareString(category, "事件", true) != 0)
				{
					goto IL_2352;
				}
				IL_1FFF:
				num2 = 471;
				result = false;
				goto IL_235A;
				IL_200C:
				num2 = 474;
				if (!(A_0 is PrintInfo))
				{
					goto IL_206E;
				}
				IL_201A:
				num2 = 475;
				string left17 = name;
				IL_2024:
				num2 = 477;
				if (Operators.CompareString(left17, "PaperWidth", true) != 0 && Operators.CompareString(left17, "PaperHeight", true) != 0)
				{
					goto IL_2352;
				}
				IL_204B:
				num2 = 478;
				if (((PrintInfo)A_0).PaperRawKind == 0)
				{
					goto IL_2352;
				}
				IL_2061:
				num2 = 479;
				result = false;
				goto IL_235A;
				IL_206E:
				num2 = 481;
				if (!(A_0 is PrintPageProperty))
				{
					goto IL_20D0;
				}
				IL_207C:
				num2 = 482;
				string left18 = name;
				IL_2086:
				num2 = 484;
				if (Operators.CompareString(left18, "Width", true) != 0 && Operators.CompareString(left18, "Height", true) != 0)
				{
					goto IL_2352;
				}
				IL_20AD:
				num2 = 485;
				if (((PrintPageProperty)A_0).PaperKind == PaperKind.Custom)
				{
					goto IL_2352;
				}
				IL_20C3:
				num2 = 486;
				result = false;
				goto IL_235A;
				IL_20D0:
				num2 = 488;
				if (!(A_0 is FormMenuProperty))
				{
					goto IL_2124;
				}
				IL_20DE:
				num2 = 489;
				string left19 = name;
				IL_20E8:
				num2 = 491;
				if (Operators.CompareString(left19, "Dock", true) != 0)
				{
					goto IL_2352;
				}
				IL_2100:
				num2 = 492;
				if (((FormMenuProperty)A_0).Type == StripTypeEnum2.工具栏)
				{
					goto IL_2352;
				}
				IL_2117:
				num2 = 493;
				result = false;
				goto IL_235A;
				IL_2124:
				num2 = 495;
				if (!(A_0 is FormMenuItemProperty))
				{
					goto IL_22F9;
				}
				IL_2135:
				num2 = 496;
				if (((FormMenuItemProperty)A_0).Type != StripItemTypeEnum.Separator)
				{
					goto IL_21C0;
				}
				IL_2149:
				num2 = 497;
				string left20 = name;
				IL_2153:
				num2 = 499;
				if (Operators.CompareString(left20, "Name", true) == 0 || Operators.CompareString(left20, "Alignment", true) == 0 || Operators.CompareString(left20, "Type", true) == 0 || Operators.CompareString(left20, "Type2", true) == 0 || Operators.CompareString(left20, "Enabled", true) == 0 || Operators.CompareString(left20, "Visible", true) == 0)
				{
					goto IL_21C0;
				}
				IL_21B3:
				num2 = 501;
				result = false;
				goto IL_235A;
				IL_21C0:
				num2 = 502;
				string left21 = name;
				IL_21CA:
				num2 = 504;
				if (Operators.CompareString(left21, "Checked", true) != 0)
				{
					goto IL_221B;
				}
				IL_21DF:
				num2 = 505;
				FormMenuItemProperty formMenuItemProperty = (FormMenuItemProperty)A_0;
				IL_21ED:
				num2 = 506;
				if (formMenuItemProperty.Type == StripItemTypeEnum.MenuItem || formMenuItemProperty.Type == StripItemTypeEnum.Button)
				{
					goto IL_2213;
				}
				IL_2206:
				num2 = 507;
				result = false;
				goto IL_235A;
				IL_2213:
				formMenuItemProperty = null;
				goto IL_2352;
				IL_221B:
				num2 = 510;
				if (Operators.CompareString(left21, "ComboList", true) != 0)
				{
					goto IL_2263;
				}
				IL_2230:
				num2 = 511;
				FormMenuItemProperty formMenuItemProperty2 = (FormMenuItemProperty)A_0;
				IL_223E:
				num2 = 512;
				if (formMenuItemProperty2.Type == StripItemTypeEnum.ComboBox)
				{
					goto IL_225B;
				}
				IL_224E:
				num2 = 513;
				result = false;
				goto IL_235A;
				IL_225B:
				formMenuItemProperty2 = null;
				goto IL_2352;
				IL_2263:
				num2 = 516;
				if (Operators.CompareString(left21, "ShortcutKeys", true) != 0)
				{
					goto IL_229B;
				}
				IL_2278:
				num2 = 517;
				if (((FormMenuItemProperty)A_0).Type == StripItemTypeEnum.MenuItem)
				{
					goto IL_2352;
				}
				IL_228E:
				num2 = 518;
				result = false;
				goto IL_235A;
				IL_229B:
				num2 = 520;
				if (Operators.CompareString(left21, "DisplayText", true) != 0 && Operators.CompareString(left21, "TextPosition", true) != 0)
				{
					goto IL_2352;
				}
				IL_22C2:
				num2 = 521;
				FormMenuItemProperty formMenuItemProperty3 = (FormMenuItemProperty)A_0;
				IL_22D0:
				num2 = 522;
				if (formMenuItemProperty3.Type == StripItemTypeEnum.Button || formMenuItemProperty3.Type == StripItemTypeEnum.SplitButton)
				{
					goto IL_22F4;
				}
				IL_22EA:
				num2 = 523;
				result = false;
				goto IL_235A;
				IL_22F4:
				formMenuItemProperty3 = null;
				goto IL_2352;
				IL_22F9:
				num2 = 526;
				if (!(A_0 is ProjectProperty))
				{
					goto IL_2352;
				}
				IL_2307:
				num2 = 527;
				if (!O00OOOo_O0_O.OOoo0_OO__._o.(A_1))
				{
					goto IL_2352;
				}
				IL_2315:
				num2 = 528;
				if (o0OO__.OO0oO.o.())
				{
					goto IL_232C;
				}
				IL_2322:
				num2 = 529;
				result = false;
				goto IL_235A;
				IL_232C:
				num2 = 531;
				Oo00.o0_o_o o0_o_o = new Oo00.o0_o_o();
				IL_2339:
				num2 = 532;
				if (o0_o_o.O0.0_.())
				{
					goto IL_2352;
				}
				IL_2348:
				num2 = 533;
				result = false;
				IL_235A:
				goto IL_2C08;
				IL_235F:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2BC9:
				goto IL_2BFD;
				IL_2BCB:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2BDB:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_2BCB;
			}
			IL_2BFD:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2C08:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x00213A60 File Offset: 0x00211C60
		internal static string <<EMPTY_NAME>>(Font A_0)
		{
			return string.Concat(new string[]
			{
				A_0.Name,
				",",
				Conversions.ToString(A_0.Size),
				",",
				A_0.Style.ToString()
			}).Trim(new char[]
			{
				','
			});
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x00213AC8 File Offset: 0x00211CC8
		internal static string <<EMPTY_NAME>>(Font A_0)
		{
			string text = "New Font(\"" + A_0.Name + "\"," + Conversions.ToString(A_0.Size);
			string[] array = A_0.Style.ToString().Split(new char[]
			{
				','
			});
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (i == 0)
				{
					text += ",";
				}
				else
				{
					text += " Or ";
				}
				string left = array[i].Trim();
				if (Operators.CompareString(left, "Bold", true) == 0)
				{
					text += "FontStyle.Bold";
				}
				else if (Operators.CompareString(left, "Italic", true) == 0)
				{
					text += "FontStyle.Italic";
				}
				else if (Operators.CompareString(left, "Strikeout", true) == 0)
				{
					text += "FontStyle.Strikeout";
				}
				else if (Operators.CompareString(left, "Underline", true) == 0)
				{
					text += "FontStyle.Underline";
				}
			}
			return text.Trim(new char[]
			{
				','
			}) + ")";
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x00213BF0 File Offset: 0x00211DF0
		internal static string <<EMPTY_NAME>>(string A_0)
		{
			string text = "";
			foreach (char c in A_0)
			{
				if (char.IsLetterOrDigit(c))
				{
					text += Conversions.ToString(c);
				}
			}
			return text;
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x00213C34 File Offset: 0x00211E34
		internal static void <<EMPTY_NAME>>(C1PrintDocument A_0)
		{
			RenderText renderText = new RenderText();
			renderText.Text = "www.foxtable.com";
			renderText.Width = "Parent.Width";
			renderText.Height = "Parent.Height";
			renderText.Style.TextAngle = 45f;
			renderText.Style.TextAlignHorz = AlignHorzEnum.Center;
			renderText.Style.TextAlignVert = AlignVertEnum.Center;
			renderText.Style.FontSize = 24f;
			renderText.Style.TextColor = Color.Gray;
			A_0.PageLayout.Watermark = renderText;
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x00213CC8 File Offset: 0x00211EC8
		internal static Bitmap <<EMPTY_NAME>>(string A_0)
		{
			RegistryKey registryKey = OO_00oOO.Registry.ClassesRoot.OpenSubKey(A_0);
			if (registryKey != null)
			{
				string text = (string)registryKey.GetValue(null);
				if (text == null)
				{
					return null;
				}
				RegistryKey registryKey2 = OO_00oOO.Registry.ClassesRoot.OpenSubKey(text);
				if (registryKey2 != null)
				{
					string text2 = (string)registryKey2.GetValue(null);
					RegistryKey registryKey3 = registryKey2.OpenSubKey("DefaultIcon");
					if (registryKey3 != null)
					{
						string[] array = ((string)registryKey3.GetValue(null)).Split(new char[]
						{
							','
						});
						int a_ = 0;
						if (array.Length > 1)
						{
							int.TryParse(array[1], out a_);
						}
						IntPtr intPtr = 0;
						IntPtr handle = 0;
						ooO.ExtractIconExW(array[0].Trim(new char[]
						{
							'"'
						}), a_, ref intPtr, ref handle, 1u);
						if (handle.ToInt32() != 0)
						{
							Icon icon = Icon.FromHandle(handle);
							if (icon != null)
							{
								return icon.ToBitmap();
							}
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x00213DC4 File Offset: 0x00211FC4
		internal static Bitmap <<EMPTY_NAME>>(string A_0)
		{
			RegistryKey registryKey = OO_00oOO.Registry.ClassesRoot.OpenSubKey(A_0);
			if (registryKey != null)
			{
				string text = (string)registryKey.GetValue(null);
				if (text == null)
				{
					Image image = OO_00oOO.GetImage("Unknow.ico");
					if (image != null)
					{
						return new Bitmap(image);
					}
					return null;
				}
				else
				{
					RegistryKey registryKey2 = OO_00oOO.Registry.ClassesRoot.OpenSubKey(text);
					if (registryKey2 != null)
					{
						string text2 = (string)registryKey2.GetValue(null);
						RegistryKey registryKey3 = registryKey2.OpenSubKey("DefaultIcon");
						if (registryKey3 != null)
						{
							string[] array = ((string)registryKey3.GetValue(null)).Split(new char[]
							{
								','
							});
							int a_ = 0;
							if (array.Length > 1)
							{
								int.TryParse(array[1], out a_);
							}
							IntPtr handle = 0;
							IntPtr intPtr = 0;
							ooO.ExtractIconExW(array[0].Trim(new char[]
							{
								'"'
							}), a_, ref handle, ref intPtr, 1u);
							if (handle.ToInt32() != 0)
							{
								Icon icon = Icon.FromHandle(handle);
								if (icon != null)
								{
									return icon.ToBitmap();
								}
							}
						}
					}
				}
			}
			Image image2 = OO_00oOO.GetImage("Unknow.ico");
			Bitmap result;
			if (image2 != null)
			{
				result = new Bitmap(image2);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x00213EF8 File Offset: 0x002120F8
		public static List<string> <<EMPTY_NAME>>()
		{
			List<string> list = new List<string>();
			foreach (IPAddress ipaddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
			{
				if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
				{
					list.Add(ipaddress.ToString());
				}
			}
			return list;
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x00213F44 File Offset: 0x00212144
		internal static Type <<EMPTY_NAME>>(string A_0)
		{
			string left = Microsoft.VisualBasic.Strings.LCase(A_0);
			Type typeFromHandle;
			if (Operators.CompareString(left, "string", true) == 0)
			{
				typeFromHandle = typeof(string);
			}
			else if (Operators.CompareString(left, "date", true) == 0)
			{
				typeFromHandle = typeof(DateTime);
			}
			else if (Operators.CompareString(left, "boolean", true) == 0)
			{
				typeFromHandle = typeof(bool);
			}
			else if (Operators.CompareString(left, "byte", true) == 0)
			{
				typeFromHandle = typeof(byte);
			}
			else if (Operators.CompareString(left, "short", true) == 0)
			{
				typeFromHandle = typeof(short);
			}
			else if (Operators.CompareString(left, "integer", true) == 0)
			{
				typeFromHandle = typeof(int);
			}
			else if (Operators.CompareString(left, "long", true) == 0)
			{
				typeFromHandle = typeof(long);
			}
			else if (Operators.CompareString(left, "single", true) == 0)
			{
				typeFromHandle = typeof(float);
			}
			else if (Operators.CompareString(left, "double", true) == 0)
			{
				typeFromHandle = typeof(double);
			}
			else if (Operators.CompareString(left, "decimal", true) == 0)
			{
				typeFromHandle = typeof(decimal);
			}
			else
			{
				typeFromHandle = typeof(object);
			}
			return typeFromHandle;
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x00214084 File Offset: 0x00212284
		internal static string[] <<EMPTY_NAME>>(object[] A_0)
		{
			List<string> list = new List<string>();
			checked
			{
				for (int i = 0; i < A_0.Length; i++)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(A_0[i]);
					list.Add(Conversions.ToString(objectValue));
				}
				return list.ToArray();
			}
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x002140C4 File Offset: 0x002122C4
		public static bool <<EMPTY_NAME>>()
		{
			bool result;
			try
			{
				new StringBuilder();
				StackFrame[] frames = new StackTrace(true).GetFrames();
				if (frames.Length < 3)
				{
					result = false;
				}
				else
				{
					StackFrame stackFrame = frames[1];
					if (Operators.CompareString(frames[2].GetMethod().Name, "InvokeMethod", true) == 0 && !stackFrame.GetMethod().DeclaringType.FullName.ToLower().Contains("usercode"))
					{
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04001E3B RID: 7739
		private static Oo00.oo00Oo0O0O0 <<EMPTY_NAME>>;

		// Token: 0x04001E3C RID: 7740
		private static string <<EMPTY_NAME>>;

		// Token: 0x02000454 RID: 1108
		internal struct o0O_
		{
			// Token: 0x04001E3D RID: 7741
			public int <<EMPTY_NAME>>;

			// Token: 0x04001E3E RID: 7742
			public int <<EMPTY_NAME>>;
		}

		// Token: 0x02000455 RID: 1109
		// (Invoke) Token: 0x06004A95 RID: 19093
		public delegate void o_0_(Exception A_0, string A_1);
	}
}
