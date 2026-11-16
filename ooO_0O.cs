using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using C1.Win.C1Chart;
using C1.Win.C1Command;
using C1.Win.C1Input;
using C1.Win.FlexViewer;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003D5 RID: 981
	[StandardModule]
	internal sealed class ooO_0O
	{
		// Token: 0x06004006 RID: 16390 RVA: 0x001D2258 File Offset: 0x001D0458
		internal static Foxtable.WinForm.Control <<EMPTY_NAME>>(System.Windows.Forms.Control A_0)
		{
			Foxtable.WinForm.Control result;
			if (A_0 is O0oo000oO0oo_)
			{
				result = new CheckedComboBox((O0oo000oO0oo_)A_0);
			}
			else if (A_0 is OoOO0Oo_oo0oO)
			{
				result = new Foxtable.WinForm.ComboBox((OoOO0Oo_oo0oO)A_0);
			}
			else if (A_0 is OooO00O)
			{
				result = new DropDownBox((OooO00O)A_0);
			}
			else if (A_0 is ooOOO)
			{
				result = new NumericComboBox((ooOOO)A_0);
			}
			else if (A_0 is O_0oOoOo)
			{
				result = new Foxtable.WinForm.DateTimePicker((O_0oOoOo)A_0);
			}
			else if (A_0 is O0O_O0)
			{
				result = new Foxtable.WinForm.TextBox((O0O_O0)A_0);
			}
			else if (A_0 is o__0OoO_)
			{
				result = new TimeSpanBox((o__0OoO_)A_0);
			}
			else if (A_0 is CustomCheckedListBox)
			{
				result = new Foxtable.WinForm.CheckedListBox((CustomCheckedListBox)A_0);
			}
			else if (A_0 is CustomListBox)
			{
				result = new Foxtable.WinForm.ListBox((CustomListBox)A_0);
			}
			else if (A_0 is CustomCheckBox)
			{
				result = new Foxtable.WinForm.CheckBox((CustomCheckBox)A_0);
			}
			else if (A_0 is oO00O0oO0o000)
			{
				result = new Foxtable.WinForm.RadioButton((oO00O0oO0o000)A_0);
			}
			else if (A_0 is CustomColorLabel)
			{
				result = new ColorLabel((CustomColorLabel)A_0);
			}
			else if (A_0 is C1Label)
			{
				result = new Foxtable.WinForm.Label((OO_0o_O_O)A_0);
			}
			else if (A_0 is LineControl)
			{
				result = new Line((LineControl)A_0);
			}
			else if (A_0 is C1Button)
			{
				result = new Foxtable.WinForm.Button((C1Button)A_0);
			}
			else if (A_0 is System.Windows.Forms.GroupBox)
			{
				result = new Foxtable.WinForm.GroupBox((System.Windows.Forms.GroupBox)A_0);
			}
			else if (A_0 is CustomPictureBox)
			{
				result = new Foxtable.WinForm.PictureBox((CustomPictureBox)A_0);
			}
			else if (A_0 is System.Windows.Forms.Panel)
			{
				result = new Foxtable.WinForm.Panel((System.Windows.Forms.Panel)A_0);
			}
			else if (A_0 is System.Windows.Forms.SplitContainer)
			{
				result = new Foxtable.WinForm.SplitContainer((System.Windows.Forms.SplitContainer)A_0);
			}
			else if (A_0 is C1DockingTab)
			{
				result = new Foxtable.WinForm.TabControl((C1DockingTab)A_0);
			}
			else if (A_0 is o_o0ooOooO)
			{
				result = new FilterTree((o_o0ooOooO)A_0);
			}
			else if (A_0 is o_0)
			{
				result = new LoadTree((o_0)A_0);
			}
			else if (A_0 is oo__)
			{
				result = new InlineTree((oo__)A_0);
			}
			else if (A_0 is oO_oo0Oo)
			{
				result = new LayersTree((oO_oo0Oo)A_0);
			}
			else if (A_0 is System.Windows.Forms.TreeView)
			{
				result = new Foxtable.WinForm.TreeView((System.Windows.Forms.TreeView)A_0);
			}
			else if (A_0 is o_O_O0O__)
			{
				result = new Foxtable.WinForm.ProgressBar((o_O_O0O__)A_0);
			}
			else if (A_0 is OoOoo00)
			{
				result = new Foxtable.WinForm.TrackBar((OoOoo00)A_0);
			}
			else if (A_0 is FileManager)
			{
				result = new FileManager((FileManager)A_0);
			}
			else if (A_0 is PictureViewer)
			{
				result = new PictureViewer((PictureViewer)A_0);
			}
			else if (A_0 is O_oOooO_O)
			{
				result = new Table((O_oOooO_O)A_0);
			}
			else if (A_0 is Oo_)
			{
				result = new TopicBar((Oo_)A_0);
			}
			else if (A_0 is O_OOO)
			{
				result = new NavBar((O_OOO)A_0);
			}
			else if (A_0 is C1Chart)
			{
				result = new Chart((C1Chart)A_0);
			}
			else if (A_0 is o_OO_oOOO0o)
			{
				result = new Foxtable.WinForm.ListView((o_OO_oOOO0o)A_0);
			}
			else if (A_0 is OOO0_)
			{
				result = new Foxtable.WinForm.WebBrowser((OOO0_)A_0);
			}
			else if (A_0 is WebViewer)
			{
				result = new WebViewer((WebViewer)A_0);
			}
			else if (A_0 is O_oo)
			{
				result = new Painter((O_oo)A_0);
			}
			else if (A_0 is C1FlexViewer)
			{
				result = new PDFViewer((C1FlexViewer)A_0);
			}
			else if (A_0 is OOo00o_0o0_)
			{
				result = new BarCode((OOo00o_0o0_)A_0);
			}
			else if (A_0 is MonthCalendar)
			{
				result = new Calendar((MonthCalendar)A_0);
			}
			else if (A_0 is OooOo0___oO)
			{
				result = new RecordGrid((OooOo0___oO)A_0);
			}
			else if (A_0 is oOO)
			{
				result = new ColorPicker((oOO)A_0);
			}
			else if (A_0 is O00o)
			{
				result = new FontPicker((O00o)A_0);
			}
			else if (A_0 is O0_O_0O)
			{
				result = new Gauges((O0_O_0O)A_0);
			}
			else if (A_0 is GanttView)
			{
				result = new GanttView((GanttView)A_0);
			}
			else if (A_0 is GeoMap)
			{
				result = new Map((GeoMap)A_0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x001D26D4 File Offset: 0x001D08D4
		internal static bool <<EMPTY_NAME>>(ControlTypeEnum A_0, string A_1, DataCol A_2 = null)
		{
			bool result;
			if (Operators.CompareString(A_1, "", true) == 0 || A_1.IndexOf('.') <= 0)
			{
				result = false;
			}
			else
			{
				if (A_1.StartsWith("全局变量"))
				{
					string text = A_1.Substring(A_1.LastIndexOf('.') + 1);
					if (Operators.CompareString(text, "", true) == 0)
					{
						return false;
					}
					if (!OO_00oOO.Vars.VariableTable.Columns.Contains(text))
					{
						return false;
					}
					Type dataType = OO_00oOO.Vars.VariableTable.Columns[text].DataType;
					if (A_0 <= ControlTypeEnum.TrackBar)
					{
						switch (A_0)
						{
						case ControlTypeEnum.CheckBox:
						case ControlTypeEnum.RadioButton:
							if (dataType != typeof(bool))
							{
								return false;
							}
							goto IL_381;
						case ControlTypeEnum.ComboBox:
						case ControlTypeEnum.TopicBar:
						case ControlTypeEnum.ListBox:
							goto IL_381;
						case ControlTypeEnum.NumericComboBox:
							break;
						case ControlTypeEnum.DateTimePicker:
							if (dataType != typeof(DateTime))
							{
								return false;
							}
							goto IL_381;
						case ControlTypeEnum.CheckedListBox:
							goto IL_158;
						default:
							switch (A_0)
							{
							case ControlTypeEnum.ProgressBar:
							case ControlTypeEnum.ColorLabel:
								break;
							case ControlTypeEnum.Chart:
								goto IL_381;
							case ControlTypeEnum.PictureViewer:
							case ControlTypeEnum.FileManager:
							case ControlTypeEnum.CheckedComboBox:
								goto IL_158;
							default:
								if (A_0 != ControlTypeEnum.TrackBar)
								{
									goto IL_381;
								}
								break;
							}
							break;
						}
					}
					else if (A_0 != ControlTypeEnum.TimeSpanBox)
					{
						if (A_0 == ControlTypeEnum.FontPicker)
						{
							goto IL_158;
						}
						if (A_0 != ControlTypeEnum.ColorPicker)
						{
							goto IL_381;
						}
					}
					if (dataType == typeof(string) || dataType == typeof(DateTime) || dataType == typeof(bool))
					{
						return false;
					}
					goto IL_381;
					IL_158:
					if (dataType != typeof(string))
					{
						return false;
					}
				}
				else
				{
					string text2 = A_1.Substring(0, A_1.LastIndexOf('.'));
					string text3 = A_1.Substring(A_1.LastIndexOf('.') + 1);
					DataColumn dataColumn;
					if (A_2 != null)
					{
						dataColumn = A_2.BaseColumn;
					}
					else
					{
						if (Operators.CompareString(text3, "", true) == 0)
						{
							return false;
						}
						if (!OO_00oOO.Tables.get_Contains(text2))
						{
							return false;
						}
						if (!OO_00oOO.Tables[text2].DataTable.BaseTable.Columns.Contains(text3))
						{
							return false;
						}
						dataColumn = OO_00oOO.Tables[text2].DataTable.BaseTable.Columns[text3];
					}
					if (dataColumn != null)
					{
						string name = Enum.GetName(typeof(ControlTypeEnum), A_0);
						if (A_0 <= ControlTypeEnum.TrackBar)
						{
							switch (A_0)
							{
							case ControlTypeEnum.CheckBox:
							case ControlTypeEnum.RadioButton:
								if (dataColumn.DataType != typeof(bool))
								{
									MessageBox.Show(name + "控件只能绑定到逻辑列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									return false;
								}
								goto IL_381;
							case ControlTypeEnum.ComboBox:
							case ControlTypeEnum.TopicBar:
							case ControlTypeEnum.ListBox:
								goto IL_381;
							case ControlTypeEnum.NumericComboBox:
								break;
							case ControlTypeEnum.DateTimePicker:
								if (dataColumn.DataType != typeof(DateTime))
								{
									MessageBox.Show(name + "控件只能绑定到日期列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									return false;
								}
								goto IL_381;
							case ControlTypeEnum.CheckedListBox:
								goto IL_350;
							default:
								switch (A_0)
								{
								case ControlTypeEnum.ProgressBar:
								case ControlTypeEnum.ColorLabel:
									break;
								case ControlTypeEnum.Chart:
									goto IL_381;
								case ControlTypeEnum.PictureViewer:
								case ControlTypeEnum.FileManager:
								case ControlTypeEnum.CheckedComboBox:
									goto IL_350;
								default:
									if (A_0 != ControlTypeEnum.TrackBar)
									{
										goto IL_381;
									}
									break;
								}
								break;
							}
						}
						else if (A_0 != ControlTypeEnum.TimeSpanBox)
						{
							if (A_0 == ControlTypeEnum.FontPicker)
							{
								goto IL_350;
							}
							if (A_0 != ControlTypeEnum.ColorPicker)
							{
								goto IL_381;
							}
						}
						if (!o_O_o_oOoo__.OO_.O.(dataColumn.DataType))
						{
							MessageBox.Show(name + "控件只能绑定到数值列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return false;
						}
						goto IL_381;
						IL_350:
						if (dataColumn.DataType != typeof(string))
						{
							MessageBox.Show(name + "控件只能绑定到字符列或备注列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return false;
						}
					}
				}
				IL_381:
				result = true;
			}
			return result;
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x001D2A65 File Offset: 0x001D0C65
		internal static ooO_0O.BindindField <<EMPTY_NAME>>(DataRow A_0)
		{
			ooO_0O.BindindField bindindField = new ooO_0O.BindindField();
			o_O_o_oOoo__.OOOO_OO._oo.(bindindField, Conversions.ToString(A_0["Property"]), '\v');
			return bindindField;
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x001D2A84 File Offset: 0x001D0C84
		internal static TempBindingTable <<EMPTY_NAME>>(DataRow A_0)
		{
			TempBindingTable tempBindingTable = new TempBindingTable();
			o_O_o_oOoo__.OOOO_OO._oo.(tempBindingTable, Conversions.ToString(A_0["Property"]), '\v');
			return tempBindingTable;
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x001D2AA4 File Offset: 0x001D0CA4
		internal static void <<EMPTY_NAME>>(C1TextBox A_0, BooleanEnum A_1)
		{
			switch (A_1)
			{
			case BooleanEnum.Default:
				if (A_0.DataBindings.Count == 0)
				{
					A_0.ReadOnly = false;
					return;
				}
				if (A_0.DataBindings.Count > 0)
				{
					BindingMemberInfo bindingMemberInfo = A_0.DataBindings[0].BindingMemberInfo;
					if (A_0.DataBindings[0].DataSource is O_0)
					{
						string text = ((O_0)A_0.DataBindings[0].DataSource).Oo._Oo0OO.();
						if (OO_00oOO.Tables.get_Contains(text))
						{
							OO_00oOO.Tables[text];
							if (OO_00oOO.Tables[text].Cols.Contains(bindingMemberInfo.BindingField))
							{
								if (!OO_00oOO.Tables[text].AllowEdit)
								{
									A_0.ReadOnly = true;
								}
								else if (!OO_00oOO.Tables[text].Cols[bindingMemberInfo.BindingField].AllowEdit)
								{
									A_0.ReadOnly = true;
								}
								else if (OO_00oOO.Tables[text].Current != null && OO_00oOO.Tables[text].Current.Locked)
								{
									A_0.ReadOnly = true;
								}
								else
								{
									A_0.ReadOnly = false;
								}
							}
							else
							{
								DataTable dataTable = OO_00oOO.Tables[text].DataTable;
								if (!dataTable.AllowEdit)
								{
									A_0.ReadOnly = true;
								}
								else if (!dataTable.DataCols.Contains(bindingMemberInfo.BindingField) || !dataTable.DataCols[bindingMemberInfo.BindingField].AllowEdit)
								{
									A_0.ReadOnly = true;
								}
								else if (OO_00oOO.Tables[text].Current != null && OO_00oOO.Tables[text].Current.Locked)
								{
									A_0.ReadOnly = true;
								}
								else
								{
									A_0.ReadOnly = false;
								}
							}
							bindingMemberInfo = default(BindingMemberInfo);
							return;
						}
					}
				}
				break;
			case BooleanEnum.True:
				A_0.ReadOnly = true;
				return;
			case BooleanEnum.False:
				A_0.ReadOnly = false;
				break;
			default:
				return;
			}
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x001D2CAC File Offset: 0x001D0EAC
		internal static void <<EMPTY_NAME>>(TreeNodeCollection A_0, List<Foxtable.WinForm.TreeNode> A_1)
		{
			try
			{
				foreach (object obj in A_0)
				{
					O_o__00Ooo o_o__00Ooo = (O_o__00Ooo)obj;
					A_1.Add(new Foxtable.WinForm.TreeNode(o_o__00Ooo));
					if (o_o__00Ooo.Nodes.Count > 0)
					{
						ooO_0O.o_O0.O_.(o_o__00Ooo.Nodes, A_1);
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

		// Token: 0x020003D6 RID: 982
		internal class BindindField
		{
			// Token: 0x17000D89 RID: 3465
			// (get) Token: 0x0600400D RID: 16397 RVA: 0x001D2D2C File Offset: 0x001D0F2C
			// (set) Token: 0x0600400E RID: 16398 RVA: 0x001D2D34 File Offset: 0x001D0F34
			public string BindingField
			{
				get
				{
					return this.OOOOO_0._o0O0o.;
				}
				set
				{
					this.OOOOO_0._o0O0o. = value;
				}
			}

			// Token: 0x040019F8 RID: 6648
			private string <<EMPTY_NAME>>;
		}
	}
}
