using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.Syscmd
{
	/// <summary>
	/// 与列相关的系统命令
	/// </summary>
	// Token: 0x02000540 RID: 1344
	[StandardModule]
	public sealed class Column
	{
		// Token: 0x06005A2B RID: 23083 RVA: 0x002621D4 File Offset: 0x002603D4
		private static bool <<EMPTY_NAME>>(bool A_0)
		{
			bool result;
			if (OO_00oOO.CurrentTable == null)
			{
				result = false;
			}
			else
			{
				DataTable dataTable = OO_00oOO.DataTables[OO_00oOO.CurrentTable.DataTable.Name];
				if ((dataTable.frd_Connection != null && o_O_o_oOoo__.OO0O_0.0O0o0_o.(dataTable.frd_Connection)) & !A_0)
				{
					MessageBox.Show("不能修改来自Oracle的数据表的结构！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = false;
				}
				else if (((dataTable.frd_IsOuterQuery || dataTable.frd_IsInnerQuery) & !A_0 & !dataTable.AddByCode) || dataTable.AddByCode)
				{
					MessageBox.Show("对于查询表以及通过代码生成的临时表，不能直接通过菜单修改其结构。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = false;
				}
				else if ((Operators.CompareString(dataTable.ConnectionName, "", true) > 0 && O_O0OO.OoO__.0oO0oo.().ContainsKey(dataTable.ConnectionName)) & !A_0)
				{
					MessageBox.Show("不能修改来自Web数据源的表的结构!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = false;
				}
				else if (Operators.CompareString(dataTable.o._OOO0oOo0__., "", true) > 0 && dataTable.o._OOO0oOo0__..IndexOf("].[") > 0 && !A_0)
				{
					MessageBox.Show("不能修改非默认架构表的结构", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		/// <summary>
		/// 插入数据列
		/// </summary>
		// Token: 0x06005A2C RID: 23084 RVA: 0x00262310 File Offset: 0x00260510
		public static void InsertDataColumn()
		{
			if (ooO.oo__.O000_o_O.() && Column.oo0Oo0Oo.OO.(false) && OO_00oOO.CurrentTable.DataTable.O0o.O_0_O.())
			{
				OO_00oOO.Forms.ooO0_o._o.();
				new o\u3002\u3000\u3000\u3002\u3000\u3000\u3000(OO_00oOO.CurrentTable.DataTable.Name, true).ShowDialog();
				OO_00oOO.CurrentTable.foxGrid.Invalidate();
			}
		}

		/// <summary>
		/// 增加数据列
		/// </summary>
		// Token: 0x06005A2D RID: 23085 RVA: 0x00262374 File Offset: 0x00260574
		[oO0oooo("0026")]
		public static void AddDataColumn()
		{
			if (ooO.oo__.O000_o_O.() && Column.oo0Oo0Oo.OO.(false) && OO_00oOO.CurrentTable.DataTable.O0o.O_0_O.())
			{
				OO_00oOO.Forms.ooO0_o._o.();
				new o\u3002\u3000\u3000\u3002\u3000\u3000\u3000(OO_00oOO.CurrentTable.DataTable.Name, false).ShowDialog();
				OO_00oOO.CurrentTable.foxGrid.Invalidate();
			}
		}

		/// <summary>
		/// 插入表达式列
		/// </summary>
		// Token: 0x06005A2E RID: 23086 RVA: 0x002623D8 File Offset: 0x002605D8
		[oO0oooo("0025")]
		public static void InsertExpressionColumn()
		{
			if (ooO.oo__.O000_o_O.() && Column.oo0Oo0Oo.OO.(true) && OO_00oOO.CurrentTable.DataTable.O0o.O_0_O.())
			{
				OO_00oOO.Forms.ooO0_o._o.();
				new o\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3000\u3000\u3002(OO_00oOO.CurrentTable.DataTable.Name, true).ShowDialog();
			}
		}

		/// <summary>
		/// 增加表达式列
		/// </summary>
		// Token: 0x06005A2F RID: 23087 RVA: 0x0026242C File Offset: 0x0026062C
		[oO0oooo("0025")]
		public static void AddExpressionColumn()
		{
			if (ooO.oo__.O000_o_O.() && Column.oo0Oo0Oo.OO.(true) && OO_00oOO.CurrentTable.DataTable.O0o.O_0_O.())
			{
				OO_00oOO.Forms.ooO0_o._o.();
				new o\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3000\u3000\u3002(OO_00oOO.CurrentTable.DataTable.Name, false).ShowDialog();
			}
		}

		// Token: 0x06005A30 RID: 23088 RVA: 0x0026247E File Offset: 0x0026067E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void EditGetValueCode()
		{
		}

		/// <summary>
		/// 修改表达式
		/// </summary>
		// Token: 0x06005A31 RID: 23089 RVA: 0x00262480 File Offset: 0x00260680
		[oO0oooo("0031")]
		public static void EditExpression()
		{
			if (ooO.oo__.O000_o_O.() && Column.oo0Oo0Oo.OO.(true) && OO_00oOO.CurrentTable.DataTable.O0o.O_0_O.())
			{
				string a_ = "";
				O_oOooO_O o_oOooO_O = OO_00oOO.CurrentTable.foxGrid;
				if (o_oOooO_O.Cols[o_oOooO_O.Col].DataIndex != -1)
				{
					DataColumn dataColumn = OO_00oOO.CurrentTable.View.o_o.O0ooOo.().Columns[o_oOooO_O.Cols[o_oOooO_O.Col].Name];
					DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.Find(new object[]
					{
						dataColumn.Table.TableName,
						dataColumn.ColumnName
					});
					if (dataRow != null)
					{
						a_ = Conversions.ToString(dataRow["Expression"]);
					}
					if (OO_00oOO.DataTables[dataColumn.Table.TableName].DataCols[dataColumn.ColumnName].IsTemporary)
					{
						if (new O\u3002o\u3002\u3002\u3000(O_O0OO.OOOo.oo_OOOO_0.().Tables[dataColumn.Table.TableName], dataColumn, a_, true).ShowDialog() == DialogResult.OK)
						{
							if (dataRow != null)
							{
								dataRow["Expression"] = dataColumn.Expression;
								Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
							}
							OO_00oOO.CurrentTable.foxGrid.Invalidate();
						}
					}
					else if (MessageBox.Show("只有表达式列才能设置表达式，是否现在增加一个表达式列？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						Column.AddExpressionColumn();
					}
				}
			}
		}

		/// <summary>
		/// 删除列
		/// </summary>
		// Token: 0x06005A32 RID: 23090 RVA: 0x00262618 File Offset: 0x00260818
		[oO0oooo("0030")]
		public static void Delete()
		{
			if (ooO.oo__.O000_o_O.() && OO_00oOO.CurrentTable != null)
			{
				string text = OO_00oOO.CurrentTable.DataTable.Name;
				if (OO_00oOO.CurrentTable.foxGrid.Col > 0)
				{
					string name = OO_00oOO.CurrentTable.foxGrid.Cols[OO_00oOO.CurrentTable.foxGrid.Col].Name;
					if (OO_00oOO.CurrentTable.DataTable.O0o.O_0_O.())
					{
						if (OO_00oOO.CurrentTable.Cols.Count == 1)
						{
							MessageBox.Show("至少要保留一列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return;
						}
						bool flag;
						if (OO_00oOO.DataTables.Contains(text) && OO_00oOO.DataTables[text].DataCols[name].IsTemporary)
						{
							flag = true;
						}
						if (Column.oo0Oo0Oo.OO.(flag))
						{
							if (OO_00oOO.DataTables[text].DataCols[name].o.O__0__Ooo0.())
							{
								MessageBox.Show("请在删除列[" + name + "]之前，先删除有关的表间关联！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								return;
							}
							if (MessageBox.Show("列删除操作是不可撤销的，确定要删除列[" + name + "]吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
							{
								OO_00oOO.Forms.ooO0_o._o.();
								Application.DoEvents();
								if (OO_00oOO.DataTables[text].DataCols.O_0__o.o_0o.(name))
								{
									try
									{
										foreach (Table table in OO_00oOO.Tables)
										{
											table.O.__O0o0.(true, false);
											if (Operators.CompareString(table.View.o_._0O0o_OoO.(), "", true) > 0 && table.View.o_._0O0o_OoO.().IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
											{
												table.ApplySort = false;
												table.View.o_O_.00o.("");
											}
											if (Operators.CompareString(table.View.o0.O0.(), "", true) > 0 && table.View.o0.O0.().IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
											{
												table.ApplyFilter = false;
												table.View.Oo._Oo0OO.("");
											}
										}
									}
									finally
									{
										IEnumerator<Table> enumerator;
										if (enumerator != null)
										{
											enumerator.Dispose();
										}
									}
									try
									{
										foreach (object obj in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows)
										{
											DataRow dataRow = (DataRow)obj;
											if (Operators.CompareString(Conversions.ToString(dataRow["Table"]), text, true) == 0 && !dataRow.IsNull("Column") && Operators.CompareString(Conversions.ToString(dataRow["Column"]), name, true) == 0)
											{
												dataRow.Delete();
												break;
											}
										}
									}
									finally
									{
										IEnumerator enumerator2;
										if (enumerator2 is IDisposable)
										{
											(enumerator2 as IDisposable).Dispose();
										}
									}
									Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
									if (flag)
									{
										DataRow dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.Find(new object[]
										{
											text,
											name
										});
										if (dataRow2 != null)
										{
											dataRow2.Delete();
											Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
										}
										return;
									}
									OleDbConnection oleDbConnection = OO_00oOO.DataTables[text].frd_Connection;
									string a_;
									if (oleDbConnection == O_O0OO.OoO.0OO__0ooo.())
									{
										a_ = text;
									}
									else
									{
										a_ = OO_00oOO.DataTables[text].o._OOO0oOo0__.;
									}
									o_oo0 o_oo = new o_oo0(oleDbConnection, o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection), oleDbConnection == O_O0OO.OoO.0OO__0ooo.());
									o_oo.o0_oo0._.().O.0_O.(a_).o_O00_.00_.().OO00o__OOO.o0_.(name);
									o_oo.o0_oo0._.(false, false);
									OO_00oOO.DataTables[text].O_00_._.();
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x002629F4 File Offset: 0x00260BF4
		[oO0oooo("0036")]
		private static void <<EMPTY_NAME>>()
		{
			if (ooO.oo__.O000_o_O.() && OO_00oOO.CurrentTable.TableType == TableTypeEnum.Normal && OO_00oOO.CurrentTable.DataTable.O0o.O_0_O.())
			{
				OO_00oOO.Forms.ooO0_o._o.();
				DataTable dataTable = OO_00oOO.CurrentTable.DataTable;
				if (OO_00oOO.CurrentTable.foxGrid.Col >= OO_00oOO.CurrentTable.foxGrid.Cols.Fixed)
				{
					DataCol dataCol = dataTable.DataCols[OO_00oOO.CurrentTable.foxGrid.Cols[OO_00oOO.CurrentTable.foxGrid.Col].Name];
					if (!dataTable.AddByCode && OO_00oOO.CurrentTable.TableType == TableTypeEnum.Normal)
					{
						string name = dataCol.Name;
						o\u3002\u3002 o_u3002_u = new o\u3002\u3002(dataTable, dataCol);
						try
						{
							foreach (Table table in OO_00oOO.Tables)
							{
								if (table.DataTable == dataTable)
								{
									table.CloseRecordGrid();
									if (table.Cols.Contains(dataCol.Name))
									{
										table.Cols[dataCol.Name].CloseWindow();
									}
								}
							}
						}
						finally
						{
							IEnumerator<Table> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						if (!dataCol.IsTemporary)
						{
							DataTable dataTable2 = OO_00oOO.CurrentTable.DataTable;
							if (dataTable2.Type == 2 || dataTable2.Type == 4 || (dataTable2.Type == 1 && !dataTable2.o._OOO0oOo0__..EndsWith(dataTable2.Name)) || (Operators.CompareString(dataTable2.ConnectionName, "", true) > 0 && O_O0OO.OoO__.0oO0oo.().ContainsKey(dataTable2.ConnectionName)))
							{
								o_u3002_u.O0.Oo0.().Enabled = false;
								o_u3002_u.oo.0_00_o0.().Enabled = false;
								o_u3002_u.O.0Oo_o.().Enabled = false;
								o_u3002_u.OOO.O_o0_.().Text = "提示：对于查询表，不能直接重命名列和修改列的类型。";
							}
							if (dataCol.o.O__0__Ooo0.())
							{
								o_u3002_u.oo.0_00_o0.().Enabled = false;
								o_u3002_u.OOO.O_o0_.().Text = "提示：当前表已经通过此列和其它表建立关联，在删除关联之前，不能修改此列的列类型。";
							}
						}
						if (o_u3002_u.ShowDialog() != DialogResult.Cancel)
						{
							try
							{
								try
								{
									foreach (Table table2 in OO_00oOO.Tables)
									{
										if (table2.foxGrid.FindForm() != null && table2.DataTable == dataTable)
										{
											table2._frdTableLayout.OOooOOo_.0_0_o.();
										}
									}
								}
								finally
								{
									IEnumerator<Table> enumerator2;
									if (enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
								OO_00oOO.SystemReady = false;
								Application.DoEvents();
								ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle);
								if (o_u3002_u.O0Oo_O_.O_OOO. != o_u3002_u.o_O0OOo0o_.o. || (o_u3002_u.O0Oo_O_.O_OOO. != o_u3002_u.o_O0OOo0o_.o. && o_u3002_u.o_O0OOo0o_.o. == ColumnDataTypeEnum.String))
								{
									Column.oo0Oo0Oo.OO.(dataTable, dataCol, o_u3002_u.o_O0OOo0o_.o., o_u3002_u.O0Oo_O_.O_OOO., o_u3002_u.o_O0OOo0o_.o., o_u3002_u.O0Oo_O_.O_OOO.);
								}
								dataCol = dataTable.DataCols[name];
								if (Operators.CompareString(o_u3002_u.O0Oo_O_.O_OOO., o_u3002_u.Ooo0.0_Oo_., true) != 0 || Operators.CompareString(o_u3002_u.Ooo0oO__._00., o_u3002_u.O00_O._o., true) != 0)
								{
									Column.oo0Oo0Oo.OO.(dataTable, dataCol, o_u3002_u.Ooo0.0_Oo_., o_u3002_u.O0Oo_O_.O_OOO., o_u3002_u.O00_O._o., o_u3002_u.Ooo0oO__._00.);
								}
								OO_00oOO.Tables[dataTable.Name].Cols[dataCol.Name].OpenWindow(0);
								try
								{
									foreach (Table table3 in OO_00oOO.Tables)
									{
										if (table3.DataTable == dataTable)
										{
											table3._frdTableLayout.Oo_.oo_oOo_oO.();
										}
									}
								}
								finally
								{
									IEnumerator<Table> enumerator3;
									if (enumerator3 != null)
									{
										enumerator3.Dispose();
									}
								}
								if (Operators.CompareString(o_u3002_u.O0Oo_O_.O_OOO., o_u3002_u.Ooo0.0_Oo_., true) != 0)
								{
									try
									{
										foreach (Table table4 in OO_00oOO.Tables)
										{
											if (table4.DataTable == dataTable)
											{
												table4.NeedSaveSetting = true;
												table4.Oo._0oO.();
												if (Operators.CompareString(table4.View.o_._0O0o_OoO.(), "", true) > 0 && table4.View.o_._0O0o_OoO.().IndexOf(o_u3002_u.Ooo0.0_Oo_., StringComparison.OrdinalIgnoreCase) >= 0)
												{
													table4.ApplySort = false;
													table4.View.o_O_.00o.("");
												}
												if (Operators.CompareString(table4.View.o0.O0.(), "", true) > 0 && table4.View.o0.O0.().IndexOf(o_u3002_u.Ooo0.0_Oo_., StringComparison.OrdinalIgnoreCase) >= 0)
												{
													table4.ApplyFilter = false;
													table4.View.Oo._Oo0OO.("");
												}
											}
										}
									}
									finally
									{
										IEnumerator<Table> enumerator4;
										if (enumerator4 != null)
										{
											enumerator4.Dispose();
										}
									}
									Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
								}
							}
							catch (Exception a_)
							{
								ooO.oOo0Oo.o.(a_, "");
							}
							finally
							{
								OO_00oOO.SystemReady = true;
								ShareLibriay.LockWindowUpdate(IntPtr.Zero);
								try
								{
									foreach (Table table5 in OO_00oOO.Tables)
									{
										if (table5.foxGrid.FindForm() != null && table5.DataTable == dataTable)
										{
											table5.foxGrid.Invalidate();
										}
									}
								}
								finally
								{
									IEnumerator<Table> enumerator5;
									if (enumerator5 != null)
									{
										enumerator5.Dispose();
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x00262FCC File Offset: 0x002611CC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ChangeType()
		{
			Column.oo0Oo0Oo.OO.();
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x00262FD4 File Offset: 0x002611D4
		private static void <<EMPTY_NAME>>(DataTable A_0, DataCol A_1, ColumnDataTypeEnum A_2, ColumnDataTypeEnum A_3, int A_4, int A_5)
		{
			string text = "";
			string name = A_1.Name;
			bool flag;
			if (A_1.IsTemporary)
			{
				flag = true;
				text = A_1.Expression;
			}
			else
			{
				A_0.Save();
			}
			if (flag)
			{
				if (Operators.CompareString(text, "", true) > 0)
				{
					try
					{
						A_0.BaseTable.Columns.Add("_SysTemporaryColumnForTest", Oo00.OO.0O0o.(A_3), text);
					}
					catch (Exception ex)
					{
						bool flag2 = true;
						return;
					}
					finally
					{
						if (A_0.BaseTable.Columns.Contains("_SysTemporaryColumnForTest"))
						{
							A_0.BaseTable.Columns.Remove("_SysTemporaryColumnForTest");
						}
						try
						{
							foreach (Table table in OO_00oOO.Tables)
							{
								if (table.foxGrid.Cols.Contains("_SysTemporaryColumnForTest"))
								{
									table.foxGrid.Cols.Remove("_SysTemporaryColumnForTest");
								}
								table.O.__O0o0.(true, false);
							}
						}
						finally
						{
							IEnumerator<Table> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
						bool flag2;
						if (flag2)
						{
							MessageBox.Show("更改类类型失败，原因：新的数据类型和原计算公式不匹配！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
					}
				}
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()];
				try
				{
					DataRow dataRow = dataTable.Rows.Find(new object[]
					{
						A_0.Name,
						A_1.Name
					});
					if (dataRow != null)
					{
						dataRow["DataType"] = A_3;
						if (A_3 == ColumnDataTypeEnum.String)
						{
							dataRow["MaxLength"] = A_5;
						}
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
					}
					if (A_3 == ColumnDataTypeEnum.String && A_2 == ColumnDataTypeEnum.String && A_1.BaseColumn.MaxLength <= 255)
					{
						A_1.BaseColumn.MaxLength = A_5;
						return;
					}
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
					return;
				}
			}
			else if (A_2 != A_3 || A_4 != A_5)
			{
				try
				{
					OleDbConnection oleDbConnection = A_0.frd_Connection;
					o_oo0 o_oo = new o_oo0(oleDbConnection, o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection), oleDbConnection == O_O0OO.OoO.0OO__0ooo.());
					string a_2;
					if (oleDbConnection == O_O0OO.OoO.0OO__0ooo.())
					{
						a_2 = A_0.Name;
					}
					else
					{
						a_2 = A_0.o._OOO0oOo0__.;
					}
					o_oo.o0_oo0._.().O.0_O.(a_2).o_O00_.00_.().OO00o__OOO.o0_.(A_1.Name).O_o0.Oo00o0.(A_3);
					if (A_3 == ColumnDataTypeEnum.String)
					{
						o_oo.o0_oo0._.().O.0_O.(a_2).o_O00_.00_.().OO00o__OOO.o0_.(A_1.Name).O_o0.Oo00o0.(A_5);
					}
					if (o_oo.o0_oo0._.(true, false) == 0)
					{
						return;
					}
					if (A_3 == ColumnDataTypeEnum.String && A_2 == ColumnDataTypeEnum.String && A_1.BaseColumn.MaxLength <= 255)
					{
						A_1.BaseColumn.MaxLength = A_5;
						try
						{
							foreach (Table table2 in OO_00oOO.Tables)
							{
								if (table2.DataTable == A_0 && table2.Cols.Contains(A_1.Name))
								{
									table2.Cols[A_1.Name].o0.O.();
								}
							}
						}
						finally
						{
							IEnumerator<Table> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						return;
					}
					A_0.O_00_._.();
				}
				catch (Exception a_3)
				{
					ooO.oOo0Oo.o.(a_3, "");
					return;
				}
			}
			Dictionary<DataColumn, string> dictionary = new Dictionary<DataColumn, string>();
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Tables)
				{
					DataTable dataTable2 = (DataTable)obj;
					try
					{
						foreach (object obj2 in dataTable2.Columns)
						{
							DataColumn dataColumn = (DataColumn)obj2;
							if (Operators.CompareString(dataColumn.Expression, "", true) > 0 && dataColumn != A_1.BaseColumn)
							{
								dictionary.Add(dataColumn, dataColumn.Expression);
								dataColumn.Expression = "";
							}
						}
					}
					finally
					{
						IEnumerator enumerator4;
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator3;
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			try
			{
				Type type = Oo00.OO.0O0o.(A_3);
				A_1.BaseColumn.Unique = false;
				string randString = ShareLibriay.GetRandString(8);
				A_0.OO_.OOo0o0. = randString;
				if (flag)
				{
					A_0.BaseTable.Columns.Add(randString, type);
					if (A_3 == ColumnDataTypeEnum.String)
					{
						A_0.BaseTable.Columns[randString].MaxLength = A_5;
					}
					else if (A_3 == ColumnDataTypeEnum.Text)
					{
						A_0.BaseTable.Columns[randString].MaxLength = -1;
					}
					if (Operators.CompareString(text, "", true) > 0)
					{
						A_0.BaseTable.Columns[randString].Expression = text;
					}
					A_0.BaseTable.Columns.Remove(name);
					A_0.BaseTable.Columns[randString].ColumnName = name;
				}
				else
				{
					A_0.BaseTable.Columns.Add(randString, type);
					if (A_3 == ColumnDataTypeEnum.String)
					{
						A_0.BaseTable.Columns[randString].MaxLength = A_5;
					}
					List<OoO_O00> list = new List<OoO_O00>();
					try
					{
						foreach (Table table3 in OO_00oOO.Tables)
						{
							if (table3.View.o_o.O0ooOo.() == A_0.BaseTable)
							{
								list.Add(new OoO_O00(table3));
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator5;
						if (enumerator5 != null)
						{
							enumerator5.Dispose();
						}
					}
					if (type == typeof(DateTime) && A_0.DataCols[name].IsNumeric)
					{
						try
						{
							foreach (object obj3 in A_0.BaseTable.Rows)
							{
								DataRow dataRow2 = (DataRow)obj3;
								if (!dataRow2.IsNull(name))
								{
									dataRow2[randString] = new DateTime(599264352000000000L).AddDays(Conversions.ToDouble(dataRow2[name]));
								}
							}
							goto IL_9BC;
						}
						finally
						{
							IEnumerator enumerator6;
							if (enumerator6 is IDisposable)
							{
								(enumerator6 as IDisposable).Dispose();
							}
						}
					}
					if (A_0.DataCols[name].IsDate & type != typeof(string))
					{
						try
						{
							foreach (object obj4 in A_0.BaseTable.Rows)
							{
								DataRow dataRow3 = (DataRow)obj4;
								if (!dataRow3.IsNull(name))
								{
									dataRow3[randString] = (Conversions.ToDate(dataRow3[name]) - new DateTime(599264352000000000L)).TotalDays;
								}
							}
							goto IL_9BC;
						}
						finally
						{
							IEnumerator enumerator7;
							if (enumerator7 is IDisposable)
							{
								(enumerator7 as IDisposable).Dispose();
							}
						}
					}
					if (A_0.BaseTable.Columns[randString].DataType == typeof(bool))
					{
						try
						{
							foreach (object obj5 in A_0.BaseTable.Rows)
							{
								DataRow dataRow4 = (DataRow)obj5;
								if (dataRow4.IsNull(name))
								{
									dataRow4[randString] = false;
								}
								else
								{
									dataRow4[randString] = Conversions.ToBoolean(dataRow4[name]);
								}
							}
							goto IL_9BC;
						}
						finally
						{
							IEnumerator enumerator8;
							if (enumerator8 is IDisposable)
							{
								(enumerator8 as IDisposable).Dispose();
							}
						}
					}
					if (A_0.BaseTable.Columns[name].DataType == typeof(DateTime))
					{
						try
						{
							foreach (object obj6 in A_0.BaseTable.Rows)
							{
								DataRow dataRow5 = (DataRow)obj6;
								if (!dataRow5.IsNull(name))
								{
									DateTime dateTime = Conversions.ToDate(dataRow5[name]);
									switch (A_0.DataCols[name].DateTimeFormat)
									{
									case DateTimeFormatEnum.Date:
										dataRow5[randString] = Strings.Format(dateTime, "yyyy-MM-dd");
										break;
									case DateTimeFormatEnum.Time:
										dataRow5[randString] = Strings.Format(dateTime, "HH:mm");
										break;
									case DateTimeFormatEnum.DateTime:
										dataRow5[randString] = Strings.Format(dateTime, "yyyy-MM-dd HH:mm");
										break;
									case DateTimeFormatEnum.DateLongTime:
										dataRow5[randString] = Strings.Format(dateTime, "yyyy-MM-dd HH:mm:ss");
										break;
									}
								}
							}
							goto IL_9BC;
						}
						finally
						{
							IEnumerator enumerator9;
							if (enumerator9 is IDisposable)
							{
								(enumerator9 as IDisposable).Dispose();
							}
						}
					}
					if (o_O_o_oOoo__.OO_.O.(type))
					{
						try
						{
							foreach (object obj7 in A_0.BaseTable.Rows)
							{
								DataRow dataRow6 = (DataRow)obj7;
								if (!dataRow6.IsNull(name) && Operators.CompareString(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataRow6[name])).Trim(), "", true) != 0 && !dataRow6.IsNull(name))
								{
									dataRow6[randString] = Conversions.ToDecimal(dataRow6[name]);
								}
							}
							goto IL_9BC;
						}
						finally
						{
							IEnumerator enumerator10;
							if (enumerator10 is IDisposable)
							{
								(enumerator10 as IDisposable).Dispose();
							}
						}
					}
					try
					{
						foreach (object obj8 in A_0.BaseTable.Rows)
						{
							DataRow dataRow7 = (DataRow)obj8;
							dataRow7[randString] = RuntimeHelpers.GetObjectValue(dataRow7[name]);
						}
					}
					finally
					{
						IEnumerator enumerator11;
						if (enumerator11 is IDisposable)
						{
							(enumerator11 as IDisposable).Dispose();
						}
					}
					IL_9BC:
					A_0.BaseTable.AcceptChanges();
					A_0.BaseTable.Columns.Remove(name);
					A_0.BaseTable.Columns[randString].ColumnName = name;
					try
					{
						foreach (OoO_O00 ooO_O in list)
						{
							ooO_O.O._00000.(null);
						}
					}
					finally
					{
						List<OoO_O00>.Enumerator enumerator12;
						((IDisposable)enumerator12).Dispose();
					}
				}
				A_0.DataCols.O_0__o.o_0o.(name);
				A_1 = A_0.DataCols[name];
				if (flag)
				{
					A_1.IsTemporary = true;
				}
				try
				{
					foreach (DataColumn dataColumn2 in dictionary.Keys)
					{
						dataColumn2.Expression = dictionary[dataColumn2];
					}
				}
				finally
				{
					Dictionary<DataColumn, string>.KeyCollection.Enumerator enumerator13;
					((IDisposable)enumerator13).Dispose();
				}
				A_1.o_.Oo00_O_00_.();
				try
				{
					foreach (Table table4 in OO_00oOO.Tables)
					{
						if (table4.foxGrid.FindForm() != null)
						{
							table4.O.__O0o0.(true, false);
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator14;
					if (enumerator14 != null)
					{
						enumerator14.Dispose();
					}
				}
			}
			catch (Exception a_4)
			{
				ooO.oOo0Oo.o.(a_4, "");
			}
			finally
			{
				OO_00oOO.MainTable.foxGrid.Refresh();
				if (A_1 != null)
				{
					A_1.oO.O. = true;
				}
			}
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x00263CD0 File Offset: 0x00261ED0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void Modify()
		{
			Column.oo0Oo0Oo.OO.();
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x00263CD7 File Offset: 0x00261ED7
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void Rename()
		{
			Column.Modify();
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x00263CE0 File Offset: 0x00261EE0
		private static void <<EMPTY_NAME>>(DataTable A_0, DataCol A_1, string A_2, string A_3, string A_4, string A_5)
		{
			bool flag;
			if (A_1.IsTemporary)
			{
				flag = true;
			}
			if (Operators.CompareString(A_5, A_4, true) != 0)
			{
				A_1.Setting.Caption = A_5;
				A_1.O.O_OO.(true);
				if (Operators.CompareString(A_3, A_2, true) == 0)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (!table.O.__O0o0.(true, false) && table.DataTable == A_0)
							{
								table.O0oO0oo_O_o.Oo.(true);
							}
						}
						return;
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
			if (Operators.CompareString(A_3, A_2, true) != 0 && A_0.DataCols.O_0__o.o_0o.(A_2, A_3))
			{
				if (flag)
				{
					DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.Find(new object[]
					{
						A_0.Name,
						A_2
					});
					if (dataRow != null)
					{
						dataRow["Column"] = A_3;
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
					}
				}
				else
				{
					OleDbConnection oleDbConnection = A_0.frd_Connection;
					if (o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection))
					{
						OleDbCommand oleDbCommand = new OleDbCommand(string.Concat(new string[]
						{
							"exec sp_rename '",
							A_0.o._OOO0oOo0__.,
							".",
							A_2,
							"','",
							A_3,
							"','column'"
						}), oleDbConnection);
						try
						{
							oleDbConnection.Open();
							oleDbCommand.ExecuteScalar();
							goto IL_1E0;
						}
						catch (Exception a_)
						{
							ooO.oOo0Oo.o.(a_, "");
							return;
						}
						finally
						{
							oleDbConnection.Close();
						}
					}
					o_oo0 o_oo = new o_oo0(oleDbConnection, false, oleDbConnection == O_O0OO.OoO.0OO__0ooo.());
					string a_2;
					if (oleDbConnection == O_O0OO.OoO.0OO__0ooo.())
					{
						a_2 = A_0.Name;
					}
					else
					{
						a_2 = A_0.o._OOO0oOo0__.;
					}
					o_oo.o0_oo0._.().O.0_O.(a_2).o_O00_.00_.().OO00o__OOO.o0_.(A_2).Name = A_3;
					if (o_oo.o0_oo0._.(false, false) == 0)
					{
						return;
					}
					IL_1E0:
					A_0.O_00_._.();
				}
				try
				{
					foreach (Table table2 in OO_00oOO.Tables)
					{
						if (table2.DataTable == A_0)
						{
							table2.Cols.RenameColumn(A_2, A_3);
							table2.O.__O0o0.(A_2, A_3);
							table2._frdTableLayout.OOooOOo_.0_0_o.(A_2, A_3);
						}
						table2.O.__O0o0.(true, false);
						table2.foxGrid.Refresh();
					}
				}
				finally
				{
					IEnumerator<Table> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				try
				{
					foreach (object obj in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows)
					{
						DataRow dataRow2 = (DataRow)obj;
						if (Operators.CompareString(Conversions.ToString(dataRow2["Table"]), A_0.Name, true) == 0 && !dataRow2.IsNull("Column") && Operators.CompareString(Conversions.ToString(dataRow2["Column"]), A_2, true) == 0)
						{
							dataRow2["Column"] = A_3;
							break;
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
				try
				{
					foreach (object obj2 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()].Rows)
					{
						DataRow dataRow3 = (DataRow)obj2;
						if (Operators.CompareString(Conversions.ToString(dataRow3["ParentTable"]), A_0.Name, true) == 0)
						{
							string text = "\t" + Conversions.ToString(dataRow3["ParentCols"]) + "\t";
							text = text.Replace("\t" + A_2 + "\t", "\t" + A_3 + "\t");
							text = text.Trim("\t".ToCharArray());
							if (Operators.CompareString(text, Conversions.ToString(dataRow3["ParentCols"]), true) != 0)
							{
								dataRow3["ParentCols"] = text;
							}
						}
						else if (Operators.CompareString(Conversions.ToString(dataRow3["ChildTable"]), A_0.Name, true) == 0)
						{
							string text2 = "\t" + Conversions.ToString(dataRow3["ChildCols"]) + "\t";
							text2 = text2.Replace("\t" + A_2 + "\t", "\t" + A_3 + "\t");
							text2 = text2.Trim("\t".ToCharArray());
							if (Operators.CompareString(text2, Conversions.ToString(dataRow3["ChildCols"]), true) != 0)
							{
								dataRow3["ChildCols"] = text2;
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator4;
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()], true);
				try
				{
					foreach (object obj3 in O_O0OO.OOOo.oo_OOOO_0.().Tables[A_0.Name].Columns)
					{
						DataColumn dataColumn = (DataColumn)obj3;
						if (Operators.CompareString(dataColumn.Expression, "", true) > 0 && dataColumn.Expression.IndexOf(A_2, StringComparison.CurrentCultureIgnoreCase) >= 0)
						{
							try
							{
								string text3 = ShareLibriay.ReplaceFiledIgnoreCase(dataColumn.Expression, A_2, A_3);
								if (Operators.CompareString(dataColumn.Expression, text3, true) != 0)
								{
									dataColumn.Expression = text3;
									DataRow dataRow4 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.Find(new object[]
									{
										A_0.Name,
										dataColumn.ColumnName
									});
									if (dataRow4 != null)
									{
										dataRow4["Expression"] = dataColumn.Expression;
									}
								}
							}
							catch (Exception a_3)
							{
								ooO.oOo0Oo.o.(a_3, "");
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator5;
					if (enumerator5 is IDisposable)
					{
						(enumerator5 as IDisposable).Dispose();
					}
				}
				try
				{
					foreach (object obj4 in O_O0OO.OOOo.oo_OOOO_0.().Relations)
					{
						DataRelation dataRelation = (DataRelation)obj4;
						if (Operators.CompareString(dataRelation.ChildTable.TableName, A_0.Name, true) == 0)
						{
							string text4 = "Child(" + dataRelation.RelationName + ")." + A_2;
							string text5 = string.Concat(new string[]
							{
								"Child([",
								dataRelation.RelationName,
								"]).[",
								A_2,
								"]"
							});
							string text6 = "Child." + A_2;
							string text7 = "Child([" + dataRelation.RelationName + "])." + A_2;
							string text8 = string.Concat(new string[]
							{
								"Child(",
								dataRelation.RelationName,
								").[",
								A_2,
								"]"
							});
							string newValue = "Child(" + dataRelation.RelationName + ")." + A_3;
							string newValue2 = string.Concat(new string[]
							{
								"Child([",
								dataRelation.RelationName,
								"]).[",
								A_3,
								"]"
							});
							string newValue3 = "Child." + A_3;
							string newValue4 = "Child([" + dataRelation.RelationName + "])." + A_3;
							string newValue5 = string.Concat(new string[]
							{
								"Child(",
								dataRelation.RelationName,
								").[",
								A_3,
								"]"
							});
							try
							{
								foreach (object obj5 in dataRelation.ParentTable.Columns)
								{
									DataColumn dataColumn2 = (DataColumn)obj5;
									if (Operators.CompareString(dataColumn2.Expression, "", true) > 0)
									{
										string text9 = dataColumn2.Expression;
										if (text9.IndexOf(text4, StringComparison.CurrentCultureIgnoreCase) > 0 || text9.IndexOf(text5, StringComparison.CurrentCultureIgnoreCase) > 0 || text9.IndexOf(text6, StringComparison.CurrentCultureIgnoreCase) > 0 || text9.IndexOf(text7, StringComparison.CurrentCultureIgnoreCase) >= 0 || text9.IndexOf(text8, StringComparison.CurrentCultureIgnoreCase) >= 0)
										{
											text9 = ShareLibriay.ReplaceFiledIgnoreCase(text9, text4, newValue);
											text9 = ShareLibriay.ReplaceFiledIgnoreCase(text9, text5, newValue2);
											text9 = ShareLibriay.ReplaceFiledIgnoreCase(text9, text6, newValue3);
											text9 = ShareLibriay.ReplaceFiledIgnoreCase(text9, text7, newValue4);
											text9 = ShareLibriay.ReplaceFiledIgnoreCase(text9, text8, newValue5);
											try
											{
												dataColumn2.Expression = text9;
												DataRow dataRow5 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.Find(new object[]
												{
													dataRelation.ParentTable.TableName,
													dataColumn2.ColumnName
												});
												if (dataRow5 != null)
												{
													dataRow5["Expression"] = text9;
												}
											}
											catch (Exception ex)
											{
											}
										}
									}
								}
								continue;
							}
							finally
							{
								IEnumerator enumerator7;
								if (enumerator7 is IDisposable)
								{
									(enumerator7 as IDisposable).Dispose();
								}
							}
						}
						if (Operators.CompareString(dataRelation.ParentTable.TableName, A_0.Name, true) == 0)
						{
							string text4 = "Parent(" + dataRelation.RelationName + ")." + A_2;
							string text5 = string.Concat(new string[]
							{
								"Parent([",
								dataRelation.RelationName,
								"]).[",
								A_2,
								"]"
							});
							string text6 = "Parent." + A_2;
							string text7 = "Parent([" + dataRelation.RelationName + "])." + A_2;
							string text8 = string.Concat(new string[]
							{
								"Parent(",
								dataRelation.RelationName,
								").[",
								A_2,
								"]"
							});
							string newValue = "Parent(" + dataRelation.RelationName + ")." + A_3;
							string newValue2 = string.Concat(new string[]
							{
								"Parent([",
								dataRelation.RelationName,
								"]).[",
								A_3,
								"]"
							});
							string newValue3 = "Parent." + A_3;
							string newValue4 = "Parent([" + dataRelation.RelationName + "])." + A_3;
							string newValue5 = string.Concat(new string[]
							{
								"Parent(",
								dataRelation.RelationName,
								").[",
								A_3,
								"]"
							});
							try
							{
								foreach (object obj6 in dataRelation.ChildTable.Columns)
								{
									DataColumn dataColumn3 = (DataColumn)obj6;
									if (Operators.CompareString(dataColumn3.Expression, "", true) > 0)
									{
										string text10 = dataColumn3.Expression;
										if (text10.IndexOf(text4, StringComparison.CurrentCultureIgnoreCase) >= 0 || text10.IndexOf(text5, StringComparison.CurrentCultureIgnoreCase) >= 0 || text10.IndexOf(text6, StringComparison.CurrentCultureIgnoreCase) >= 0 || text10.IndexOf(text7, StringComparison.CurrentCultureIgnoreCase) >= 0 || text10.IndexOf(text8, StringComparison.CurrentCultureIgnoreCase) >= 0)
										{
											text10 = ShareLibriay.ReplaceFiledIgnoreCase(text10, text4, newValue);
											text10 = ShareLibriay.ReplaceFiledIgnoreCase(text10, text5, newValue2);
											text10 = ShareLibriay.ReplaceFiledIgnoreCase(text10, text6, newValue3);
											text10 = ShareLibriay.ReplaceFiledIgnoreCase(text10, text7, newValue4);
											text10 = ShareLibriay.ReplaceFiledIgnoreCase(text10, text8, newValue5);
											try
											{
												dataColumn3.Expression = text10;
												DataRow dataRow6 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.Find(new object[]
												{
													dataRelation.ChildTable.TableName,
													dataColumn3.ColumnName
												});
												if (dataRow6 != null)
												{
													dataRow6["Expression"] = text10;
												}
											}
											catch (Exception ex2)
											{
											}
										}
									}
								}
							}
							finally
							{
								IEnumerator enumerator8;
								if (enumerator8 is IDisposable)
								{
									(enumerator8 as IDisposable).Dispose();
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator6;
					if (enumerator6 is IDisposable)
					{
						(enumerator6 as IDisposable).Dispose();
					}
				}
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
			}
		}

		/// <summary>
		/// 锁定列
		/// </summary>
		// Token: 0x06005A39 RID: 23097 RVA: 0x00264A18 File Offset: 0x00262C18
		[oO0oooo("0039")]
		public static void Lock()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				OOoO oooO = new OOoO();
				if (table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
				{
					DataTable dataTable = OO_00oOO.CurrentTable.DataTable;
					int leftCol = OO_00oOO.CurrentTable.foxGrid.Selection.LeftCol;
					int rightCol = OO_00oOO.CurrentTable.foxGrid.Selection.RightCol;
					for (int i = leftCol; i <= rightCol; i++)
					{
						string name = table.foxGrid.Cols[i].Name;
						if (!dataTable.DataCols[name].AllowEdit)
						{
							return;
						}
						oooO.O__O_._.(dataTable.DataCols[name]);
						dataTable.DataCols[name].AllowEdit = false;
						table.foxGrid.Rows[table.foxGrid.Rows.Fixed - 1].Invalidate();
					}
				}
				if (oooO.O__O_._.() > 0)
				{
					OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(oooO);
				}
			}
		}

		/// <summary>
		/// 解锁列
		/// </summary>
		// Token: 0x06005A3A RID: 23098 RVA: 0x00264B3C File Offset: 0x00262D3C
		[oO0oooo("0039")]
		public static void UnLock()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				OOoO oooO = new OOoO();
				if (table.foxGrid.Col >= table.foxGrid.Cols.Fixed)
				{
					DataTable dataTable = OO_00oOO.CurrentTable.DataTable;
					int leftCol = OO_00oOO.CurrentTable.foxGrid.Selection.LeftCol;
					int rightCol = OO_00oOO.CurrentTable.foxGrid.Selection.RightCol;
					for (int i = leftCol; i <= rightCol; i++)
					{
						string name = table.foxGrid.Cols[i].Name;
						if (dataTable.DataCols[name].AllowEdit)
						{
							return;
						}
						oooO.O__O_._.(dataTable.DataCols[name]);
						dataTable.DataCols[name].AllowEdit = true;
						table.foxGrid.Rows[table.foxGrid.Rows.Fixed - 1].Invalidate();
					}
				}
				if (oooO.O__O_._.() > 0)
				{
					OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(oooO);
				}
			}
		}

		/// <summary>
		/// 左移列
		/// </summary>
		// Token: 0x06005A3B RID: 23099 RVA: 0x00264C60 File Offset: 0x00262E60
		[oO0oooo("0032")]
		public static void MoveLeft()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				CellRange cellRange = OO_00oOO.CurrentTable.foxGrid.Selection;
				OO_00oOO.CurrentTable.O.__O0o0.(cellRange.c1, cellRange.c2, cellRange.c1 - 1, true);
				OO_00oOO.CurrentTable.NeedSaveSetting = true;
				cellRange = default(CellRange);
			}
		}

		/// <summary>
		/// 右移列
		/// </summary>
		// Token: 0x06005A3C RID: 23100 RVA: 0x00264CBC File Offset: 0x00262EBC
		[oO0oooo("0032")]
		public static void MoveRight()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				CellRange cellRange = OO_00oOO.CurrentTable.foxGrid.Selection;
				OO_00oOO.CurrentTable.O.__O0o0.(cellRange.c1, cellRange.c2, cellRange.c2 + 1, true);
				OO_00oOO.CurrentTable.NeedSaveSetting = true;
				cellRange = default(CellRange);
			}
		}

		/// <summary>
		/// 隐藏列
		/// </summary>
		// Token: 0x06005A3D RID: 23101 RVA: 0x00264D18 File Offset: 0x00262F18
		[oO0oooo("0037")]
		public static void Hide()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				table.O_o0OOo_.o0..O__00.__0_O.(new ooO0O__o_o_O_(table));
				OO_00oOO.CurrentTable.NeedSaveSetting = true;
				int leftCol = table.foxGrid.Selection.LeftCol;
				int rightCol = table.foxGrid.Selection.RightCol;
				for (int i = leftCol; i <= rightCol; i++)
				{
					table.foxGrid.Cols[i].Visible = false;
				}
				int num = table.foxGrid.Selection.RightCol + 1;
				int num2 = table.foxGrid.Cols.Count - 1;
				for (int j = num; j <= num2; j++)
				{
					if (table.foxGrid.Cols[j].Visible)
					{
						table.foxGrid.Col = j;
						return;
					}
				}
				int num3 = table.foxGrid.Selection.LeftCol - 1;
				int @fixed = table.foxGrid.Cols.Fixed;
				for (int k = num3; k >= @fixed; k += -1)
				{
					if (table.foxGrid.Cols[k].Visible)
					{
						table.foxGrid.Col = k;
						return;
					}
				}
			}
		}

		/// <summary>
		/// 取消隐藏列
		/// </summary>
		// Token: 0x06005A3E RID: 23102 RVA: 0x00264E54 File Offset: 0x00263054
		[oO0oooo("0037")]
		public static void UnHide()
		{
			Table a_;
			if (OO_00oOO.CurrentTable != null)
			{
				a_ = OO_00oOO.CurrentTable;
			}
			else
			{
				if (OO_00oOO.CurrentTable == null)
				{
					return;
				}
				a_ = OO_00oOO.CurrentTable;
			}
			TableEventArgs tableEventArgs = new TableEventArgs(OO_00oOO.CurrentTable);
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.CurrentTable.DataTable.o_0_00_.oo0O0., "BeforeUnhideColumn", new object[]
			{
				tableEventArgs
			}, true, OO_00oOO.CurrentTable.DataTable.Name, false);
			new O\u3002\u3000\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3002(a_).ShowDialog();
		}

		/// <summary>
		/// 冻结列
		/// </summary>
		// Token: 0x06005A3F RID: 23103 RVA: 0x00264ECC File Offset: 0x002630CC
		[oO0oooo("0038")]
		public static void Freeze()
		{
			Table table;
			if (OO_00oOO.CurrentTable != null)
			{
				table = OO_00oOO.CurrentTable;
			}
			else
			{
				if (OO_00oOO.CurrentTable == null)
				{
					return;
				}
				table = OO_00oOO.CurrentTable;
			}
			O\u3002\u3000\u3002 o_u3002_u3000_u = new O\u3002\u3000\u3002("冻结列", "冻结列数量:", 2, 0, table.foxGrid.Cols.Count - table.foxGrid.Cols.Fixed, "冻结列数超出范围");
			if (o_u3002_u3000_u.ShowDialog() == DialogResult.OK)
			{
				table.foxGrid.Cols.Frozen = o_u3002_u3000_u.Value;
				table.NeedSaveSetting = true;
			}
		}

		/// <summary>
		/// 取消冻结列
		/// </summary>
		// Token: 0x06005A40 RID: 23104 RVA: 0x00264F54 File Offset: 0x00263154
		[oO0oooo("0038")]
		public static void UnFreeze()
		{
			Table table;
			if (OO_00oOO.CurrentTable != null)
			{
				table = OO_00oOO.CurrentTable;
			}
			else
			{
				if (OO_00oOO.CurrentTable == null)
				{
					return;
				}
				table = OO_00oOO.CurrentTable;
			}
			table.foxGrid.Cols.Frozen = 0;
		}

		/// <summary>
		/// 设置列属性
		/// </summary>
		// Token: 0x06005A41 RID: 23105 RVA: 0x00264F90 File Offset: 0x00263190
		public static void ModifyProperty()
		{
			if (ooO.oo__.O000_o_O.() && OO_00oOO.CurrentTable != null && !OO_00oOO.CurrentTable.DataTable.AddByCode && OO_00oOO.CurrentTable.DataTable.O0o.O_0_O.() && OO_00oOO.CurrentTable.foxGrid.Col >= OO_00oOO.CurrentTable.foxGrid.Cols.Fixed)
			{
				DataCol dataCol = OO_00oOO.CurrentTable.DataTable.DataCols[OO_00oOO.CurrentTable.foxGrid.Cols[OO_00oOO.CurrentTable.foxGrid.Col].Name];
				dataCol.Setting;
				g2 g = new g2(dataCol);
				g.Text = g.Text + " - " + dataCol.Name;
				g.ShowDialog();
			}
		}

		/// <summary>
		/// 设置列宽
		/// </summary>
		// Token: 0x06005A42 RID: 23106 RVA: 0x0026506A File Offset: 0x0026326A
		[oO0oooo("A0042")]
		public static void Width()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				new O\u3002\u3002\u3002\u3002\u3000\u3000(OO_00oOO.CurrentTable).ShowDialog();
			}
		}

		/// <summary>
		/// 修改文本对齐方式
		/// </summary>
		/// <param name="Align">文本对齐方式</param>
		// Token: 0x06005A43 RID: 23107 RVA: 0x00265084 File Offset: 0x00263284
		public static void ChangeTextAlign(TextAlignEnum Align)
		{
			if (OO_00oOO.CurrentTable != null && OO_00oOO.CurrentTable.foxGrid.Col >= OO_00oOO.CurrentTable.foxGrid.Cols.Fixed)
			{
				O_0_Oo o_0_Oo = new O_0_Oo(OO_00oOO.CurrentTable);
				int leftCol = OO_00oOO.CurrentTable.foxGrid.Selection.LeftCol;
				int rightCol = OO_00oOO.CurrentTable.foxGrid.Selection.RightCol;
				for (int i = leftCol; i <= rightCol; i++)
				{
					DataCol dataCol = OO_00oOO.CurrentTable.DataTable.DataCols[OO_00oOO.CurrentTable.foxGrid.Cols[i].Name];
					dataCol.TextAlign = Align;
					dataCol.O.O_OO.(false);
					o_0_Oo.O_oo._o.(dataCol.Name);
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.DataTable == OO_00oOO.CurrentTable.DataTable && table.Cols.Contains(dataCol.Name))
							{
								table.Cols[dataCol.Name].TextAlign = Align;
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				if (o_0_Oo.O_oo._o.() > 0)
				{
					OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(o_0_Oo);
				}
			}
		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x002651F4 File Offset: 0x002633F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void GetAllValue()
		{
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x002651F8 File Offset: 0x002633F8
		private static bool <<EMPTY_NAME>>(DataCol A_0)
		{
			bool result;
			if (!ooO.oo__.O000_o_O.())
			{
				result = false;
			}
			else if (A_0.DataTable.frd_IsInnerQuery || A_0.DataTable.frd_IsOuterQuery || A_0.DataTable.frd_IsTemporary || A_0.DataTable.AddByCode)
			{
				MessageBox.Show("查询表或临时表不能转换列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(A_0.DataTable.frd_Connection))
			{
				MessageBox.Show("来自Oracle的表不能转换列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		/// <summary>
		/// 数据列转为表达式列
		/// </summary>
		// Token: 0x06005A46 RID: 23110 RVA: 0x00265288 File Offset: 0x00263488
		[oO0oooo("2494")]
		public static void DataToExp()
		{
			OO_00oOO.CurrentTable.DataTable.Name;
			if (OO_00oOO.CurrentTable.foxGrid.Col > 0)
			{
				DataCol dataCol = OO_00oOO.CurrentTable.DataTable.DataCols[OO_00oOO.CurrentTable.foxGrid.Cols[OO_00oOO.CurrentTable.foxGrid.Col].Name];
				if (Column.oo0Oo0Oo.OO.(dataCol))
				{
					if (dataCol.o.O__0__Ooo0.())
					{
						MessageBox.Show("不能将关联列转换为表达式列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					if (dataCol.IsTemporary)
					{
						MessageBox.Show("[" + dataCol.Name + "]已经是表达式列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					O\u3002\u3002\u3002\u3002_o\u3000 o_u3002_u3002_u3002_u3002_o_u = new O\u3002\u3002\u3002\u3002_o\u3000();
					o_u3002_u3002_u3002_u3002_o_u.O.0o_0_. = true;
					o_u3002_u3002_u3002_u3002_o_u.O.0o_0_. = dataCol;
					o_u3002_u3002_u3002_u3002_o_u.oOO._o00o00__.().Text = "确定要将[" + dataCol.Name + "]转为表达式列吗？";
					o_u3002_u3002_u3002_u3002_o_u.ShowDialog();
				}
			}
		}

		/// <summary>
		/// 表达式列转为数据列
		/// </summary>
		// Token: 0x06005A47 RID: 23111 RVA: 0x00265384 File Offset: 0x00263584
		[oO0oooo("2494")]
		public static void ExpToData()
		{
			OO_00oOO.CurrentTable.DataTable.Name;
			if (OO_00oOO.CurrentTable.foxGrid.Col > 0)
			{
				DataCol dataCol = OO_00oOO.CurrentTable.DataTable.DataCols[OO_00oOO.CurrentTable.foxGrid.Cols[OO_00oOO.CurrentTable.foxGrid.Col].Name];
				if (Column.oo0Oo0Oo.OO.(dataCol))
				{
					if (!dataCol.IsTemporary)
					{
						MessageBox.Show("[" + dataCol.Name + "]已经是数据列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					O\u3002\u3002\u3002\u3002_o\u3000 o_u3002_u3002_u3002_u3002_o_u = new O\u3002\u3002\u3002\u3002_o\u3000();
					o_u3002_u3002_u3002_u3002_o_u.O_0oo.O0. = true;
					o_u3002_u3002_u3002_u3002_o_u.O.0o_0_. = dataCol;
					o_u3002_u3002_u3002_u3002_o_u.oOO._o00o00__.().Text = "确定要将[" + dataCol.Name + "]转为数据列吗？";
					o_u3002_u3002_u3002_u3002_o_u.ShowDialog();
				}
			}
		}
	}
}
