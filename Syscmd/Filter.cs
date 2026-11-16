using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.Syscmd
{
	/// <summary>
	/// 和筛选相关的系统命令
	/// </summary>
	// Token: 0x02000542 RID: 1346
	[StandardModule]
	public sealed class Filter
	{
		/// <summary>
		/// 高级筛选
		/// </summary>
		// Token: 0x06005A56 RID: 23126 RVA: 0x002658BC File Offset: 0x00263ABC
		[oO0oooo("0126")]
		public static void Advanced()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				try
				{
					IEnumerator enumerator = Application.OpenForms.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (((Form)enumerator.Current) is ef)
						{
							return;
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
				new ef(OO_00oOO.CurrentTable)
				{
					Owner = Main.OO_O.o.
				}.Show();
			}
		}

		/// <summary>
		/// 筛选指定值
		/// </summary>
		/// <param name="Current">设置为True，筛选值为选定单元格的值，设置为False，会出现一个窗口输入筛选值</param>
		// Token: 0x06005A57 RID: 23127 RVA: 0x0026593C File Offset: 0x00263B3C
		[oO0oooo("0126")]
		public static void Equal(bool Current = true)
		{
			if (Current)
			{
				Filter.oo_0o_.___o0O.(" = ");
				return;
			}
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				Col col = table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name];
				if (col.IsString())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.等于);
					return;
				}
				if (col.IsNumeric())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.等于);
					return;
				}
				if (col.IsDate())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.等于);
				}
			}
		}

		/// <summary>
		/// 筛选非指定值的行
		/// </summary>
		/// <param name="Current">设置为True，筛选值为选定单元格的值，设置为False，会出现一个窗口输入筛选值</param>
		// Token: 0x06005A58 RID: 23128 RVA: 0x002659D8 File Offset: 0x00263BD8
		public static void Unequal(bool Current = true)
		{
			if (Current)
			{
				Filter.oo_0o_.___o0O.(" <> ");
				return;
			}
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				Col col = table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name];
				if (col.IsString())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.不等于);
					return;
				}
				if (col.IsNumeric())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不等于);
					return;
				}
				if (col.IsDate())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不等于);
				}
			}
		}

		/// <summary>
		/// 筛选大于指定值的行
		/// </summary>
		/// <param name="Current">设置为True，筛选值为选定单元格的值，设置为False，会出现一个窗口输入筛选值</param>
		// Token: 0x06005A59 RID: 23129 RVA: 0x00265A74 File Offset: 0x00263C74
		public static void MoreThan(bool Current = true)
		{
			if (Current)
			{
				Filter.oo_0o_.___o0O.(" > ");
				return;
			}
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				Col col = table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name];
				if (col.IsNumeric())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.大于);
					return;
				}
				if (col.IsDate())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.晚于);
				}
			}
		}

		/// <summary>
		/// 筛选不大于指定值的行
		/// </summary>
		/// <param name="Current">设置为True，筛选值为选定单元格的值，设置为False，会出现一个窗口输入筛选值</param>
		// Token: 0x06005A5A RID: 23130 RVA: 0x00265B00 File Offset: 0x00263D00
		public static void NotMoreThan(bool Current = true)
		{
			if (Current)
			{
				Filter.oo_0o_.___o0O.(" <= ");
				return;
			}
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				Col col = table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name];
				if (col.IsNumeric())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不大于);
					return;
				}
				if (col.IsDate())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不晚于);
				}
			}
		}

		/// <summary>
		/// 筛选小于指定值的行
		/// </summary>
		/// <param name="Current">设置为True，筛选值为选定单元格的值，设置为False，会出现一个窗口输入筛选值</param>
		// Token: 0x06005A5B RID: 23131 RVA: 0x00265B8C File Offset: 0x00263D8C
		public static void LessThan(bool Current = true)
		{
			if (Current)
			{
				Filter.oo_0o_.___o0O.(" < ");
				return;
			}
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				Col col = table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name];
				if (col.IsNumeric())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.小于);
					return;
				}
				if (col.IsDate())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.早于);
				}
			}
		}

		/// <summary>
		/// 筛选不小于指定值的行
		/// </summary>
		/// <param name="Current">设置为True，筛选值为选定单元格的值，设置为False，会出现一个窗口输入筛选值</param>
		// Token: 0x06005A5C RID: 23132 RVA: 0x00265C18 File Offset: 0x00263E18
		public static void NotLessThan(bool Current = true)
		{
			if (Current)
			{
				Filter.oo_0o_.___o0O.(" >= ");
				return;
			}
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				Col col = table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name];
				if (col.IsNumeric())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不小于);
					return;
				}
				if (col.IsDate())
				{
					Filter.O0O0o.Oo0OO_oO.(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum.不早于);
				}
			}
		}

		/// <summary>
		/// 筛选指定季度的数据
		/// </summary>
		/// <param name="Quarter">季度</param>
		// Token: 0x06005A5D RID: 23133 RVA: 0x00265CA4 File Offset: 0x00263EA4
		public static void FilterByQuarter(int Quarter)
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				DateTime dateTime = Conversions.ToDate(table.Value);
				string name = table.foxGrid.Cols[table.foxGrid.Col].Name;
				DateTime a_ = DateAndTime.DateSerial(dateTime.Year, Quarter * 3 - 2, 1);
				DateTime a_2 = DateAndTime.DateSerial(dateTime.Year, Quarter * 3, DateTime.DaysInMonth(dateTime.Year, Quarter * 3)).AddDays(1.0);
				Filter.O0O0o.Oo0OO_oO.(table, name, a_, a_2, false);
			}
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x00265D58 File Offset: 0x00263F58
		internal static void <<EMPTY_NAME>>(Table A_0, string A_1, DateTime A_2, DateTime A_3, bool A_4 = false)
		{
			bool flag = Oo00.O____0O._0.(A_0);
			string text = "";
			string a_ = string.Concat(new string[]
			{
				"FilterDateBetween\v",
				A_0.Name,
				"\v",
				A_1,
				"\v",
				Conversions.ToString(A_2),
				"\v",
				Conversions.ToString(A_3),
				"\v",
				Conversions.ToString(A_4)
			});
			string text2 = "";
			if (flag)
			{
				if (Operators.CompareString(A_0.DataTable.LoadFilter, "", true) > 0)
				{
					text = "(" + A_0.DataTable.LoadFilter + ") And ";
				}
			}
			else if (Operators.CompareString(A_0.View.get_Filter(), "", true) > 0)
			{
				text = "(" + A_0.Filter + ") And ";
			}
			A_0.ClearEditInfos();
			string text3 = Strings.Format(A_2, "MM/dd/yyyy HH:mm:ss");
			string text4 = Strings.Format(A_3, "MM/dd/yyyy HH:mm:ss");
			string text5;
			if (flag)
			{
				text5 = Oo00.OoOo_oo_.o_o.(A_1, A_0);
			}
			else
			{
				text5 = "[" + A_1 + "]";
			}
			if (flag)
			{
				if (A_0.DataTable.SourceType == 1)
				{
					text2 = string.Concat(new string[]
					{
						text5,
						" >= #",
						text3,
						"# And ",
						text5,
						"  < #",
						text4,
						"#"
					});
				}
				else if (A_0.DataTable.SourceType == 2)
				{
					text2 = string.Concat(new string[]
					{
						text5,
						" >= '",
						text3,
						"' And ",
						text5,
						"  < '",
						text4,
						"'"
					});
				}
				else if (A_0.DataTable.SourceType == 3)
				{
					text2 = string.Concat(new string[]
					{
						text5,
						" >= TO_DATE('",
						text3,
						"', 'MM/DD/YYYY HH24:MI:SS') And ",
						text5,
						"  < TO_DATE('",
						text4,
						"', 'MM/DD/YYYY HH24:MI:SS')"
					});
				}
				if (A_4)
				{
					text2 = "Not (" + text2 + ")";
				}
				text += text2;
				A_0.DataTable.OOO_o_O.OO0o.(text, a_);
				A_0.DataTable.LoadPage = 0;
				A_0.DataTable.o0.o.(true, null);
				if (A_0.O.OoOo_. != null && A_0.O.OoOo_..FindForm() != null)
				{
					A_0.O.OoOo_..oO.Oo0__O_.();
					return;
				}
			}
			else
			{
				text2 = string.Concat(new string[]
				{
					text2,
					text5,
					" >= #",
					text3,
					"# And ",
					text5,
					"  < #",
					text4,
					"#"
				});
				if (A_4)
				{
					text2 = "Not (" + text2 + ")";
				}
				text += text2;
				A_0.Filter = text;
			}
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x00266050 File Offset: 0x00264250
		internal static void <<EMPTY_NAME>>(Table A_0, string A_1, bool A_2 = true)
		{
			bool flag = Oo00.O____0O._0.(A_0);
			string a_ = string.Concat(new string[]
			{
				"FilterByExpression\v",
				A_0.Name,
				"\v",
				A_1,
				"\v",
				Conversions.ToString(A_2)
			});
			A_0.ClearEditInfos();
			if (flag)
			{
				string a_2;
				if (Operators.CompareString(A_0.DataTable.LoadFilter, "", true) > 0)
				{
					if (A_2)
					{
						a_2 = string.Concat(new string[]
						{
							"(",
							A_0.DataTable.LoadFilter,
							") And (",
							A_1,
							")"
						});
					}
					else if (Operators.CompareString(A_0.DataTable.OOOOO._., "", true) > 0)
					{
						a_2 = string.Concat(new string[]
						{
							"(",
							A_0.DataTable.OOOOO._.,
							") And (",
							A_1,
							")"
						});
					}
					else
					{
						a_2 = A_1;
					}
				}
				else
				{
					a_2 = A_1;
				}
				A_0.DataTable.LoadPage = 0;
				A_0.DataTable.OOO_o_O.OO0o.(a_2, a_);
				A_0.DataTable.o0.o.(true, null);
				if (A_0.O.OoOo_. != null && A_0.O.OoOo_..FindForm() != null)
				{
					A_0.O.OoOo_..oO.Oo0__O_.();
					return;
				}
			}
			else
			{
				string a_2;
				if (Operators.CompareString(A_0.View.get_Filter(), "", true) > 0 && A_2)
				{
					a_2 = string.Concat(new string[]
					{
						"(",
						A_0.Filter,
						") And (",
						A_1,
						")"
					});
				}
				else
				{
					a_2 = A_1;
				}
				A_0.Filter = a_2;
			}
		}

		/// <summary>
		/// 筛选指定月份的数据
		/// </summary>
		/// <param name="Month">月份</param>
		// Token: 0x06005A60 RID: 23136 RVA: 0x00266200 File Offset: 0x00264400
		public static void FilterByMonth(int Month)
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				Oo00.O____0O._0.(table);
				DateTime dateTime = Conversions.ToDate(table.Value);
				string name = table.foxGrid.Cols[table.foxGrid.Col].Name;
				DateTime a_ = DateAndTime.DateSerial(dateTime.Year, Month, 1);
				DateTime a_2 = DateAndTime.DateSerial(dateTime.Year, Month, DateTime.DaysInMonth(dateTime.Year, Month)).AddDays(1.0);
				Filter.O0O0o.Oo0OO_oO.(table, name, a_, a_2, false);
			}
		}

		/// <summary>
		/// 逻辑列筛选
		/// </summary>
		/// <param name="Value">设为True，筛选已经选中的行，设为False，筛选未选中的行</param>
		// Token: 0x06005A61 RID: 23137 RVA: 0x002662B4 File Offset: 0x002644B4
		[oO0oooo("0123")]
		public static void FilterBoolean(bool Value)
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				string name = table.foxGrid.Cols[table.foxGrid.Col].Name;
				bool flag = Oo00.O____0O._0.(table);
				string text;
				if (flag)
				{
					text = Oo00.OoOo_oo_.o_o.(name, table);
				}
				else
				{
					text = "[" + name + "]";
				}
				string a_;
				if (Value)
				{
					if (flag)
					{
						if (table.DataTable.SourceType == 1)
						{
							a_ = text + " = True";
						}
						else
						{
							a_ = text + " = 1";
						}
					}
					else
					{
						a_ = text + " = True";
					}
				}
				else if (flag)
				{
					if (table.DataTable.SourceType == 1)
					{
						a_ = string.Concat(new string[]
						{
							"(",
							text,
							" = False Or ",
							text,
							" Is Null)"
						});
					}
					else
					{
						a_ = string.Concat(new string[]
						{
							"(",
							text,
							" = 0 Or ",
							text,
							" Is Null)"
						});
					}
				}
				else
				{
					a_ = string.Concat(new string[]
					{
						"(",
						text,
						" = False Or ",
						text,
						" Is Null)"
					});
				}
				Filter.O0O0o.Oo0OO_oO.(table, a_, true);
			}
		}

		/// <summary>
		/// 根据行的锁定状态进行筛选
		/// </summary>
		/// <param name="Locked">设为True，筛选已经锁定的行，设为False，筛选未选中的行</param>
		// Token: 0x06005A62 RID: 23138 RVA: 0x00266430 File Offset: 0x00264630
		[oO0oooo("0125")]
		public static void LockStatusFilter(bool Locked)
		{
			Table table = OO_00oOO.CurrentTable;
			string text = "";
			string text2 = "";
			if (table != null)
			{
				string text3;
				if (Oo00.O____0O._0.(table) && table.DataTable.O000_00._0_o.)
				{
					if (table.DataTable.SourceType == 1)
					{
						text = "([_Locked] = True)";
						text2 = "([_Locked] = False Or [_Locked] Is Null)";
					}
					else if (table.DataTable.SourceType == 2)
					{
						text = "([_Locked] = 1)";
						text2 = "([_Locked] = 0 Or [_Locked] Is Null)";
					}
					else if (table.DataTable.SourceType == 3)
					{
						text = "(\"_Locked\" = 1)";
						text2 = "(\"_Locked\" = False Or \"_Locked\" Is Null)";
					}
					text3 = table.DataTable.LoadFilter;
				}
				else
				{
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(table.DataTable.frd_Connection))
					{
						text = "([_Locked] IS NOT NULL)";
						text2 = "([_Locked] IS NULL)";
					}
					else
					{
						text = "([_Locked] = True)";
						text2 = "([_Locked] = False Or [_Locked] Is Null)";
					}
					text3 = table.View.get_Filter();
				}
				if (Operators.CompareString(text3, "", true) > 0)
				{
					if (text3.IndexOf("[_Locked]", StringComparison.CurrentCultureIgnoreCase) >= 0)
					{
						if (Locked)
						{
							if (text3.IndexOf(text, StringComparison.CurrentCultureIgnoreCase) >= 0)
							{
								return;
							}
							text3 = ShareLibriay.ReplaceIgnoreCase(text3, text2, text);
						}
						else
						{
							if (text3.IndexOf(text2, StringComparison.CurrentCultureIgnoreCase) >= 0)
							{
								return;
							}
							text3 = ShareLibriay.ReplaceIgnoreCase(text3, text, text2);
						}
					}
					else if (Locked)
					{
						text3 = text3 + " And " + text;
					}
					else
					{
						text3 = text3 + " And " + text2;
					}
				}
				else if (Locked)
				{
					text3 = text;
				}
				else
				{
					text3 = text2;
				}
				if (table.DataTable.O000_00._0_o.)
				{
					Filter.O0O0o.Oo0OO_oO.(table, text3, false);
					return;
				}
				table.ClearEditInfos();
				table.Filter = text3;
			}
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x002665A4 File Offset: 0x002647A4
		private static void <<EMPTY_NAME>>(string A_0)
		{
			string text = "";
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				string name = table.foxGrid.Cols[table.foxGrid.Col].Name;
				Col col = table.Cols[name];
				if (table.foxGrid.Rows[table.foxGrid.Row].DataIndex != -1)
				{
					DataRowView dataRowView = (DataRowView)table.foxGrid.Rows[table.foxGrid.Row].DataSource;
					bool flag = Oo00.O____0O._0.(table);
					string text2;
					if (flag)
					{
						text2 = Oo00.OoOo_oo_.o_o.(name, table);
					}
					else
					{
						text2 = "[" + name + "]";
					}
					if (dataRowView.Row.IsNull(name))
					{
						if (Operators.CompareString(A_0.Trim(), "=", true) == 0)
						{
							text = text2 + " Is Null";
						}
						else
						{
							text = text2 + " Is Not Null";
						}
					}
					else
					{
						string text3 = dataRowView[name].ToString();
						if (col.IsString())
						{
							text = string.Concat(new string[]
							{
								text2,
								A_0,
								"'",
								text3.Replace("'", "''"),
								"'"
							});
						}
						else if (col.IsNumeric())
						{
							text = text2 + A_0 + text3;
						}
						else if (col.IsDate())
						{
							if (flag)
							{
								if (table.DataTable.SourceType == 1)
								{
									text = string.Concat(new string[]
									{
										text2,
										A_0,
										"#",
										text3,
										"#"
									});
								}
								else if (table.DataTable.SourceType == 2)
								{
									text = string.Concat(new string[]
									{
										text2,
										A_0,
										"'",
										text3,
										"'"
									});
								}
								else if (table.DataTable.SourceType == 3)
								{
									string text4 = Strings.Format(Conversions.ToDate(text3), "MM/dd/yyyy HH:mm:ss");
									text = string.Concat(new string[]
									{
										text2,
										" ",
										A_0,
										" TO_DATE('",
										text4,
										"', 'MM/DD/YYYY HH24:MI:SS')"
									});
								}
							}
							else
							{
								text = string.Concat(new string[]
								{
									text2,
									A_0,
									"#",
									text3,
									"#"
								});
							}
						}
						if (Operators.CompareString(A_0, " <> ", true) == 0)
						{
							text = string.Concat(new string[]
							{
								"(",
								text,
								" Or ",
								text2,
								" Is Null)"
							});
						}
					}
					Filter.O0O0o.Oo0OO_oO.(table, text, true);
				}
			}
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x0026689C File Offset: 0x00264A9C
		private static void <<EMPTY_NAME>>(string A_0)
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				string name = table.foxGrid.Cols[table.foxGrid.Col].Name;
				if (table.foxGrid.Rows[table.foxGrid.Row].DataIndex != -1)
				{
					DataRowView dataRowView = (DataRowView)table.foxGrid.Rows[table.foxGrid.Row].DataSource;
					bool flag = Oo00.O____0O._0.(table);
					if (dataRowView.Row.IsNull(name))
					{
						string str;
						if (flag)
						{
							str = Oo00.OoOo_oo_.o_o.(name, table);
						}
						else
						{
							str = "[" + name + "]";
						}
						Filter.O0O0o.Oo0OO_oO.(table, str + " Is Null", true);
						return;
					}
					DateTime dateValue = Conversions.ToDate(dataRowView[name]);
					DateTime dateTime;
					DateTime a_;
					if (Operators.CompareString(A_0, "Y", true) == 0)
					{
						dateTime = DateAndTime.DateSerial(dateValue.Year, 1, 1);
						a_ = DateAndTime.DateAdd(DateInterval.Year, 1.0, dateTime);
					}
					else if (Operators.CompareString(A_0, "Q", true) == 0)
					{
						dateTime = DateAndTime.DateSerial(dateValue.Year, DateAndTime.DatePart(DateInterval.Quarter, dateValue, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) * 3 - 2, 1);
						a_ = DateAndTime.DateAdd(DateInterval.Month, 3.0, dateTime);
					}
					else if (Operators.CompareString(A_0, "M", true) == 0)
					{
						dateTime = DateAndTime.DateSerial(dateValue.Year, dateValue.Month, 1);
						a_ = DateAndTime.DateAdd(DateInterval.Month, 1.0, dateTime);
					}
					else if (Operators.CompareString(A_0, "W", true) == 0)
					{
						dateValue = dateValue.Date;
						if (dateValue.DayOfWeek == DayOfWeek.Sunday)
						{
							dateTime = DateAndTime.DateAdd(DateInterval.Day, -6.0, dateValue);
						}
						else
						{
							dateTime = DateAndTime.DateAdd(DateInterval.Day, (double)(-(double)dateValue.DayOfWeek + 1), dateValue);
						}
						a_ = DateAndTime.DateAdd(DateInterval.Day, 7.0, dateTime);
					}
					else if (Operators.CompareString(A_0, "D", true) == 0)
					{
						dateTime = DateAndTime.DateSerial(dateValue.Year, dateValue.Month, dateValue.Day);
						a_ = DateAndTime.DateAdd(DateInterval.Day, 1.0, dateTime);
					}
					else if (Operators.CompareString(A_0, "H", true) == 0)
					{
						dateTime = DateAndTime.DateSerial(dateValue.Year, dateValue.Month, dateValue.Day);
						dateTime = DateAndTime.DateAdd(DateInterval.Hour, (double)dateValue.Hour, dateTime);
						a_ = DateAndTime.DateAdd(DateInterval.Hour, 1.0, dateTime);
					}
					else if (Operators.CompareString(A_0, "N", true) == 0)
					{
						dateTime = DateAndTime.DateSerial(dateValue.Year, dateValue.Month, dateValue.Day);
						dateTime = DateAndTime.DateAdd(DateInterval.Hour, (double)dateValue.Hour, dateTime);
						dateTime = DateAndTime.DateAdd(DateInterval.Minute, (double)dateValue.Minute, dateTime);
						a_ = DateAndTime.DateAdd(DateInterval.Minute, 1.0, dateTime);
					}
					else if (Operators.CompareString(A_0, "S", true) == 0)
					{
						dateTime = DateAndTime.DateSerial(dateValue.Year, dateValue.Month, dateValue.Day);
						dateTime = DateAndTime.DateAdd(DateInterval.Hour, (double)dateValue.Hour, dateTime);
						dateTime = DateAndTime.DateAdd(DateInterval.Minute, (double)dateValue.Minute, dateTime);
						dateTime = DateAndTime.DateAdd(DateInterval.Second, (double)dateValue.Second, dateTime);
						a_ = DateAndTime.DateAdd(DateInterval.Second, 1.0, dateTime);
					}
					Filter.O0O0o.Oo0OO_oO.(table, name, dateTime, a_, false);
				}
			}
		}

		/// <summary>
		/// 筛选同一年的数据
		/// </summary>
		// Token: 0x06005A65 RID: 23141 RVA: 0x00266C1F File Offset: 0x00264E1F
		public static void SameYear()
		{
			Filter.oo0Oo0Oo.OO.("Y");
		}

		/// <summary>
		/// 筛选同一季度的数据
		/// </summary>
		// Token: 0x06005A66 RID: 23142 RVA: 0x00266C2B File Offset: 0x00264E2B
		public static void SameQuarter()
		{
			Filter.oo0Oo0Oo.OO.("Q");
		}

		/// <summary>
		/// 筛选同一月份的数据
		/// </summary>
		// Token: 0x06005A67 RID: 23143 RVA: 0x00266C37 File Offset: 0x00264E37
		public static void SameMonth()
		{
			Filter.oo0Oo0Oo.OO.("M");
		}

		/// <summary>
		/// 筛选同一天的数据
		/// </summary>
		// Token: 0x06005A68 RID: 23144 RVA: 0x00266C43 File Offset: 0x00264E43
		public static void SameDay()
		{
			Filter.oo0Oo0Oo.OO.("D");
		}

		/// <summary>
		/// 筛选同一星期的数据
		/// </summary>
		// Token: 0x06005A69 RID: 23145 RVA: 0x00266C4F File Offset: 0x00264E4F
		public static void SameWeek()
		{
			Filter.oo0Oo0Oo.OO.("W");
		}

		/// <summary>
		/// 筛选同一小时的数据
		/// </summary>
		// Token: 0x06005A6A RID: 23146 RVA: 0x00266C5B File Offset: 0x00264E5B
		public static void SameHour()
		{
			Filter.oo0Oo0Oo.OO.("H");
		}

		/// <summary>
		/// 筛选同一分钟的数据
		/// </summary>
		// Token: 0x06005A6B RID: 23147 RVA: 0x00266C67 File Offset: 0x00264E67
		public static void SameMinute()
		{
			Filter.oo0Oo0Oo.OO.("N");
		}

		/// <summary>
		/// 筛选同一秒的数据
		/// </summary>
		// Token: 0x06005A6C RID: 23148 RVA: 0x00266C73 File Offset: 0x00264E73
		public static void SameSecond()
		{
			Filter.oo0Oo0Oo.OO.("S");
		}

		/// <summary>
		/// 按值筛选
		/// </summary>
		// Token: 0x06005A6D RID: 23149 RVA: 0x00266C80 File Offset: 0x00264E80
		[oO0oooo("0118")]
		public static void Values()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null && !table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name].IsBoolean())
			{
				new oo\u3000\u30000\u3002\u3000o\u3002(table, table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name]).ShowDialog();
			}
		}

		/// <summary>
		/// 表达式筛选
		/// </summary>
		// Token: 0x06005A6E RID: 23150 RVA: 0x00266D00 File Offset: 0x00264F00
		[oO0oooo("0127")]
		public static void Expression()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				new o\u3000\u3002\u3002\u3002\u3002\u3002O\u3000\u3000\u3000\u3002\u3000(table).ShowDialog();
			}
		}

		/// <summary>
		/// 取消筛选
		/// </summary>
		// Token: 0x06005A6F RID: 23151 RVA: 0x00266D24 File Offset: 0x00264F24
		public static void UnFilter()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				table.ClearEditInfos();
				if (table.DataTable.InBackEndFilterMode)
				{
					table.DataTable.o0o_ooOOo0.OO.();
					return;
				}
				table.Filter = "";
				table.StateFilter = StateFilterEnum.Default;
			}
		}

		/// <summary>
		/// 筛选开头是指定字符的行
		/// </summary>
		// Token: 0x06005A70 RID: 23152 RVA: 0x00266D6B File Offset: 0x00264F6B
		public static void StartsWith()
		{
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.开头是);
		}

		/// <summary>
		/// 筛选开头不是指定字符的行
		/// </summary>
		// Token: 0x06005A71 RID: 23153 RVA: 0x00266D73 File Offset: 0x00264F73
		public static void NotStartsWith()
		{
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.开头不是);
		}

		/// <summary>
		/// 筛选结尾是指定字符的行
		/// </summary>
		// Token: 0x06005A72 RID: 23154 RVA: 0x00266D7B File Offset: 0x00264F7B
		public static void EndsWith()
		{
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.结尾是);
		}

		/// <summary>
		/// 筛选结尾不是指定字符的行
		/// </summary>
		// Token: 0x06005A73 RID: 23155 RVA: 0x00266D83 File Offset: 0x00264F83
		public static void NotEndsWith()
		{
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.结尾不是);
		}

		/// <summary>
		/// 筛选包含指定内容的行
		/// </summary>
		// Token: 0x06005A74 RID: 23156 RVA: 0x00266D8C File Offset: 0x00264F8C
		public static void Contains()
		{
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.包含);
		}

		/// <summary>
		/// 筛选不包含指定内容的行
		/// </summary>
		// Token: 0x06005A75 RID: 23157 RVA: 0x00266D94 File Offset: 0x00264F94
		public static void NotContains()
		{
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.不包含);
		}

		/// <summary>
		/// 筛选类似指定内容的行
		/// </summary>
		// Token: 0x06005A76 RID: 23158 RVA: 0x00266D9C File Offset: 0x00264F9C
		public static void Like()
		{
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.类似);
		}

		/// <summary>
		/// 筛选不类似指定内容的行
		/// </summary>
		// Token: 0x06005A77 RID: 23159 RVA: 0x00266DA4 File Offset: 0x00264FA4
		public static void NotLike()
		{
			Filter.O0O0o.Oo0OO_oO.(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum.不类似);
		}

		/// <summary>
		/// 筛选值在某个范围内的行
		/// </summary>
		// Token: 0x06005A78 RID: 23160 RVA: 0x00266DAC File Offset: 0x00264FAC
		public static void Between()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				Col col = table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name];
				if (col.IsNumeric())
				{
					new o\u3000\u30020\u3000(table, col, false).ShowDialog();
					return;
				}
				if (col.IsDate())
				{
					new o\u3000\u3002\u3002\u3002\u3002_\u3000\u3000\u3002\u3002\u3002\u3002(table, col, false).ShowDialog();
				}
			}
		}

		/// <summary>
		/// 筛选值不在某个范围内的行
		/// </summary>
		// Token: 0x06005A79 RID: 23161 RVA: 0x00266E38 File Offset: 0x00265038
		public static void NotBetween()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				Col col = table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name];
				if (col.IsNumeric())
				{
					new o\u3000\u30020\u3000(table, col, true).ShowDialog();
					return;
				}
				if (col.IsDate())
				{
					new o\u3000\u3002\u3002\u3002\u3002_\u3000\u3000\u3002\u3002\u3002\u3002(table, col, true).ShowDialog();
				}
			}
		}

		/// <summary>
		/// 排除重复值
		/// </summary>
		// Token: 0x06005A7A RID: 23162 RVA: 0x00266EC4 File Offset: 0x002650C4
		[oO0oooo("1478")]
		public static void HideSameValues()
		{
			Filter.O0O0o.Oo0OO_oO.(0);
		}

		/// <summary>
		/// 显示冗余值
		/// </summary>
		// Token: 0x06005A7B RID: 23163 RVA: 0x00266ECC File Offset: 0x002650CC
		[oO0oooo("1478")]
		public static void ShowRedundantValues()
		{
			Filter.O0O0o.Oo0OO_oO.(1);
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x00266ED4 File Offset: 0x002650D4
		private static void <<EMPTY_NAME>>(int A_0)
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				bool backFilter = Oo00.O____0O._0.(table);
				if (table.View.Count > 1)
				{
					table.ClearEditInfos();
					string name = table.foxGrid.Cols[table.foxGrid.Col].Name;
					table.RepeatFilter(name, A_0 + 1, backFilter);
				}
			}
		}

		/// <summary>
		/// 显示重复值
		/// </summary>
		// Token: 0x06005A7D RID: 23165 RVA: 0x00266F34 File Offset: 0x00265134
		[oO0oooo("1478")]
		public static void ShowSameValues()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				bool backFilter = Oo00.O____0O._0.(table);
				if (table.View.Count > 1)
				{
					string name = table.foxGrid.Cols[table.foxGrid.Col].Name;
					table.RepeatFilter(name, 0, backFilter);
				}
			}
		}

		/// <summary>
		/// 显示唯一值
		/// </summary>
		// Token: 0x06005A7E RID: 23166 RVA: 0x00266F8C File Offset: 0x0026518C
		[oO0oooo("1478")]
		public static void ShowUnqiueValues()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				bool backFilter = Oo00.O____0O._0.(table);
				if (table.View.Count > 1)
				{
					string name = table.foxGrid.Cols[table.foxGrid.Col].Name;
					table.RepeatFilter(name, 3, backFilter);
				}
			}
		}

		/// <summary>
		/// 关联筛选
		/// </summary>
		// Token: 0x06005A7F RID: 23167 RVA: 0x00266FE3 File Offset: 0x002651E3
		[oO0oooo("1479")]
		public static void RelationFilter()
		{
			if (O_O0OO.OOOo.oo_OOOO_0.().Tables.Count > 1)
			{
				new oO0\u3002().ShowDialog();
			}
		}

		// Token: 0x06005A80 RID: 23168 RVA: 0x00267004 File Offset: 0x00265204
		private static void <<EMPTY_NAME>>(O\u3000\u3002\u3000o\u3002\u3002.FilterModeEnum A_0)
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				Col col = table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name];
				if (col.IsString())
				{
					new O\u3000\u3002\u3000o\u3002\u3002(table, col, A_0).ShowDialog();
				}
			}
		}

		// Token: 0x06005A81 RID: 23169 RVA: 0x0026707C File Offset: 0x0026527C
		private static void <<EMPTY_NAME>>(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum A_0)
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				Col col = table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name];
				if (col.IsNumeric())
				{
					new O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002(table, col, A_0).ShowDialog();
				}
			}
		}

		// Token: 0x06005A82 RID: 23170 RVA: 0x002670F4 File Offset: 0x002652F4
		private static void <<EMPTY_NAME>>(O\u3002\u3000\u3002\u3000\u3002\u3000\u3000.FilterModeEnum A_0)
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				Col col = table.Cols[table.foxGrid.Cols[table.foxGrid.Col].Name];
				if (col.IsDate())
				{
					new O\u3002\u3000\u3002\u3000\u3002\u3000\u3000(table, col, A_0).ShowDialog();
				}
			}
		}

		/// <summary>
		/// 行状态筛选
		/// </summary>
		/// <param name="Value">行状态</param>
		// Token: 0x06005A83 RID: 23171 RVA: 0x0026716C File Offset: 0x0026536C
		[oO0oooo("0112")]
		public static void StateFilter(StateFilterEnum Value)
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				table.ClearEditInfos();
				table.StateFilter = Value;
			}
		}

		// Token: 0x06005A84 RID: 23172 RVA: 0x00267190 File Offset: 0x00265390
		private static void <<EMPTY_NAME>>(bool A_0)
		{
			string text = "";
			Table table = OO_00oOO.CurrentTable;
			if (table != null && table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
			{
				string name = table.foxGrid.Cols[table.foxGrid.Col].Name;
				string str;
				if (Oo00.O____0O._0.(table))
				{
					str = Oo00.OoOo_oo_.o_o.(name, table);
				}
				else
				{
					str = "[" + name + "]";
				}
				if (A_0)
				{
					text = text + str + " Is Null";
				}
				else
				{
					text = text + str + " Is Not Null";
				}
				Filter.O0O0o.Oo0OO_oO.(table, text, true);
			}
		}

		/// <summary>
		/// 多列重复值筛选
		/// </summary>
		// Token: 0x06005A85 RID: 23173 RVA: 0x00267238 File Offset: 0x00265438
		[oO0oooo("3330")]
		public static void DuplicateValuesFilter()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				new o\u3002\u3000\u30000\u3002\u3000\u3002(table).ShowDialog();
			}
		}

		/// <summary>
		/// 循环引用筛选
		/// </summary>
		// Token: 0x06005A86 RID: 23174 RVA: 0x0026725C File Offset: 0x0026545C
		[oO0oooo("3331")]
		public static void CircularFilter()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				new O\u3000\u3002\u3000(table).ShowDialog();
			}
		}

		/// <summary>
		/// 筛选空值
		/// </summary>
		// Token: 0x06005A87 RID: 23175 RVA: 0x0026727E File Offset: 0x0026547E
		public static void Null()
		{
			Filter.O0O0o.Oo0OO_oO.(true);
		}

		/// <summary>
		/// 筛选非空值
		/// </summary>
		// Token: 0x06005A88 RID: 23176 RVA: 0x00267286 File Offset: 0x00265486
		public static void NotNull()
		{
			Filter.O0O0o.Oo0OO_oO.(false);
		}
	}
}
