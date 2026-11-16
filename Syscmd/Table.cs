using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.Syscmd
{
	/// <summary>
	/// 和表相关的系统命令
	/// </summary>
	// Token: 0x02000546 RID: 1350
	[StandardModule]
	public sealed class Table
	{
		// Token: 0x06005AEA RID: 23274 RVA: 0x0026D277 File Offset: 0x0026B477
		internal static bool <<EMPTY_NAME>>()
		{
			return true;
		}

		/// <summary>
		/// 增加数据表
		/// </summary>
		// Token: 0x06005AEB RID: 23275 RVA: 0x0026D27C File Offset: 0x0026B47C
		[oO0oooo("0003")]
		public static void AddDataTable()
		{
			if (Table.OO__OO.0.() && ooO.oo__.O000_o_O.() && OO_00oOO.DataTables.AllowEdit && new O\u3002\u3002().ShowDialog() == DialogResult.OK)
			{
				OO_00oOO.MainTable.foxGrid.Focus();
				try
				{
					foreach (Col col in OO_00oOO.MainTable.Cols)
					{
						col.OpenWindow(0);
					}
				}
				finally
				{
					IEnumerator<Col> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 查看表结构
		/// </summary>
		// Token: 0x06005AEC RID: 23276 RVA: 0x0026D304 File Offset: 0x0026B504
		[oO0oooo("0193")]
		public static void ModiStructure()
		{
			if (ooO.oo__.O000_o_O.())
			{
				new o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002().ShowDialog();
			}
		}

		/// <summary>
		/// 复制表
		/// </summary>
		// Token: 0x06005AED RID: 23277 RVA: 0x0026D318 File Offset: 0x0026B518
		[oO0oooo("0192")]
		public static void Copy()
		{
			if (ooO.oo__.O000_o_O.())
			{
				if (!OO_00oOO.MainTable.DataTable.frd_IsInnerTable && !OO_00oOO.MainTable.DataTable.frd_IsOuterTable)
				{
					MessageBox.Show("只能复制数据表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				new o\u3002\u3000\u3002().ShowDialog();
			}
		}

		/// <summary>
		/// 增加临时表
		/// </summary>
		// Token: 0x06005AEE RID: 23278 RVA: 0x0026D370 File Offset: 0x0026B570
		[oO0oooo("0626")]
		public static void AddTemporaryTable()
		{
			if (Table.OO__OO.0.() && ooO.oo__.O000_o_O.() && OO_00oOO.DataTables.AllowEdit)
			{
				MessageBox.Show("临时表的数据不会永久保存，通常用于在运行过程中临时储存动态生成的数据，例如统计数据。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				O\u3002\u3002 o_u3002_u = new O\u3002\u3002();
				o_u3002_u.ooO__o_O_O.o_.().Enabled = false;
				o_u3002_u.O_oOO.0o__O0. = true;
				o_u3002_u.Text = "增加临时表";
				o_u3002_u.ShowDialog();
			}
		}

		/// <summary>
		/// 打开外部表管理器
		/// </summary>
		// Token: 0x06005AEF RID: 23279 RVA: 0x0026D3D4 File Offset: 0x0026B5D4
		[oO0oooo("1812")]
		public static void OuterTableManager()
		{
			if (ooO.oo__.O000_o_O.() && OO_00oOO.DataTables.AllowEdit)
			{
				OO_00oOO.Forms.ooO0_o._o.();
				if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()].Rows.Count == 0)
				{
					MessageBox.Show("请在数据库功能区执行外部数据源命令，定义好有效的外部数据源，才能添加外部表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				new O\u3000\u3002\u3000\u3002\u3000\u3002
				{
					Owner = Main.OO_O.o.
				}.ShowDialog();
			}
		}

		/// <summary>
		/// 打开查询表管理器
		/// </summary>
		// Token: 0x06005AF0 RID: 23280 RVA: 0x0026D448 File Offset: 0x0026B648
		[oO0oooo("2321")]
		public static void QueryManager()
		{
			if (ooO.oo__.O000_o_O.() && OO_00oOO.DataTables.AllowEdit)
			{
				OO_00oOO.Forms.ooO0_o._o.();
				new O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000
				{
					Owner = Main.OO_O.o.
				}.ShowDialog();
			}
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x0026D47D File Offset: 0x0026B67D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void AddOuterTable()
		{
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x0026D47F File Offset: 0x0026B67F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ModifyOuterTableSetting()
		{
		}

		// Token: 0x06005AF3 RID: 23283 RVA: 0x0026D481 File Offset: 0x0026B681
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void AddOuterQuery()
		{
		}

		// Token: 0x06005AF4 RID: 23284 RVA: 0x0026D483 File Offset: 0x0026B683
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ModifyOuterQuerySetting()
		{
		}

		// Token: 0x06005AF5 RID: 23285 RVA: 0x0026D485 File Offset: 0x0026B685
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void AddInnerQuery()
		{
		}

		// Token: 0x06005AF6 RID: 23286 RVA: 0x0026D487 File Offset: 0x0026B687
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ModifyInnerQuery()
		{
		}

		/// <summary>
		/// 删除表
		/// </summary>
		// Token: 0x06005AF7 RID: 23287 RVA: 0x0026D48C File Offset: 0x0026B68C
		[oO0oooo("0022")]
		public static void Delete()
		{
			if (ooO.oo__.O000_o_O.())
			{
				if (OO_00oOO.CurrentTable.IsRelation)
				{
					MessageBox.Show("不能删除关联表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (OO_00oOO.CurrentTable.TableType == TableTypeEnum.Normal && OO_00oOO.CurrentTable.DataTable.O0o.O_0_O.())
				{
					OO_00oOO.Forms.ooO0_o._o.();
					OO_00oOO.DataTables.OO0o00.0O_0o.(OO_00oOO.CurrentTable.Name, true);
				}
			}
		}

		/// <summary>
		/// 重命名表
		/// </summary>
		// Token: 0x06005AF8 RID: 23288 RVA: 0x0026D500 File Offset: 0x0026B700
		[oO0oooo("0009")]
		public static void Rename()
		{
			if (ooO.oo__.O000_o_O.() && !OO_00oOO.CurrentTable.DataTable.AddByCode)
			{
				if (OO_00oOO.CurrentTable.IsRelation)
				{
					MessageBox.Show("关联表不能重命名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (OO_00oOO.CurrentTable.DataTable.O0o.O_0_O.())
				{
					Table.OO.OO_0o.(OO_00oOO.CurrentTable.DataTable);
				}
			}
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x0026D568 File Offset: 0x0026B768
		internal static void <<EMPTY_NAME>>(DataTable A_0)
		{
			OO_00oOO.Forms.ooO0_o._o.();
			string text = A_0.Name;
			string text2 = A_0.Caption;
			o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u = new o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(text, text2);
			if (o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() == DialogResult.OK && (Operators.CompareString(o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(), text2, true) != 0 || Operators.CompareString(o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.(), text, true) != 0))
			{
				string text3 = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.();
				string text4 = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.();
				A_0.Caption = text4;
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.foxGrid.FindForm() != null && table.DataTable == A_0)
						{
							table._frdTableLayout.OOooOOo_.0_0_o.();
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
				if (Operators.CompareString(text4, text2, true) != 0)
				{
					A_0.OO00_o.ooOO.(false);
				}
				if (Operators.CompareString(text, text3, true) == 0)
				{
					OO_00oOO.Tables[A_0.Name].O__0.0.(text);
					return;
				}
				if (!OO_00oOO.DataTables[text].AddByCode)
				{
					if (OO_00oOO.DataTables[text].frd_IsTemporary)
					{
						DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o_0_000._O.()].Rows.Find(text);
						if (dataRow != null)
						{
							dataRow["Name"] = text3;
						}
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o_0_000._O.()], true);
					}
					else if (OO_00oOO.DataTables[text].frd_IsInnerTable)
					{
						o_oo0 o_oo = new o_oo0(O_O0OO.OoO.0OO__0ooo.(), false, true);
						o_oo.o0_oo0._.().O.0_O.(text).Name = text3;
						o_oo.o0_oo0._.(false, false);
						OO_00oOO.DataTables[text].O0_o_0_.O.("~TMPCLP" + text3);
						o_oo.ooo.0.();
					}
					else
					{
						DataRow dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows.Find(text);
						if (dataRow2 != null)
						{
							dataRow2["Name"] = text3;
						}
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
					}
				}
				OO_00oOO.SystemReady = false;
				ShareLibriay.LockWindowUpdate(Main.OO_O.o..Handle);
				try
				{
					try
					{
						foreach (Table table2 in OO_00oOO.Tables)
						{
							table2.StopRedraw();
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
					List<O_0> list = new List<O_0>();
					DataTable dataTable = OO_00oOO.DataTables[text];
					O_O0OO.OOOo.oo_OOOO_0.().Tables[text].TableName = text3;
					OO_00oOO.DataTables.OoO_00.O.(text);
					OO_00oOO.DataTables.OO0o00.0O_0o.(dataTable);
					try
					{
						foreach (O_0 o_ in O_O0OO.o__.O.().Values)
						{
							string text5 = o_.Oo._Oo0OO.();
							if (Operators.CompareString(o_.Oo._Oo0OO.(), text, true) == 0)
							{
								o_.oO._o0_o.(text3);
							}
							else if (o_.Oo._Oo0OO.().StartsWith(text + "."))
							{
								o_.oO._o0_o.(text3 + o_.Oo._Oo0OO.().Substring(o_.Oo._Oo0OO.().IndexOf(".")));
							}
							else if (o_.Oo._Oo0OO.().EndsWith("." + text))
							{
								o_.oO._o0_o.(o_.Oo._Oo0OO.().Substring(0, o_.Oo._Oo0OO.().LastIndexOf(".") + 1) + text3);
							}
							else if (o_.Oo._Oo0OO.().IndexOf("." + text + ".", StringComparison.CurrentCultureIgnoreCase) > 0)
							{
								o_.oO._o0_o.(o_.Oo._Oo0OO.().Replace("." + text + ".", "." + text3 + "."));
							}
							if (Operators.CompareString(o_.Oo._Oo0OO.(), text5, true) != 0)
							{
								try
								{
									foreach (Table table3 in OO_00oOO.Tables)
									{
										if (table3.View == o_)
										{
											OO_00oOO.Tables.OO._O_o__.(table3);
											OO_00oOO.Tables.Ooo.0OOoO_0.(table3);
											if (Operators.CompareString(o_.DataMember, text, true) == 0)
											{
												o_.DataMember = text3;
											}
											table3.O__0.0.(text5);
											list.Add(o_);
											break;
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
							}
						}
					}
					finally
					{
						Dictionary<string, O_0>.ValueCollection.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					try
					{
						foreach (O_0 o_2 in list)
						{
							try
							{
								foreach (string key in O_O0OO.o__.O.().Keys)
								{
									if (O_O0OO.o__.O.()[key] == o_2)
									{
										O_O0OO.o__.O.().Remove(key);
										O_O0OO.o__.O.().Add(o_2.Oo._Oo0OO.(), o_2);
										break;
									}
								}
							}
							finally
							{
								Dictionary<string, O_0>.KeyCollection.Enumerator enumerator6;
								((IDisposable)enumerator6).Dispose();
							}
						}
					}
					finally
					{
						List<O_0>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
					if (dataTable.frd_IsInnerTable)
					{
						OleDbCommand oleDbCommand = new OleDbCommand("", dataTable.frd_Connection);
						oleDbCommand.CommandText = string.Concat(new string[]
						{
							"Update [",
							ooO0__OO.O00.O__o.(),
							"] Set [Table] = '~TMPCLP",
							text3,
							"' Where [Table] = '~TMPCLP",
							text,
							"'"
						});
						dataTable.frd_Connection.Open();
						oleDbCommand.ExecuteNonQuery();
						dataTable.frd_Connection.Close();
					}
					Table.OO.OO_0o.(text, text3);
					try
					{
						foreach (Table table4 in OO_00oOO.Tables)
						{
							table4.O.__O0o0.(true, false);
							if (table4.DataTable == A_0)
							{
								table4._frdTableLayout.Oo_.oo_oOo_oO.();
							}
							table4.ResumeRedraw();
						}
					}
					finally
					{
						IEnumerator<Table> enumerator7;
						if (enumerator7 != null)
						{
							enumerator7.Dispose();
						}
					}
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
				finally
				{
					ShareLibriay.LockWindowUpdate(IntPtr.Zero);
					OO_00oOO.SystemReady = true;
				}
			}
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x0026DC58 File Offset: 0x0026BE58
		internal static void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			try
			{
				foreach (object obj in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (Operators.CompareString(Conversions.ToString(dataRow["Table"]), A_0, true) == 0)
					{
						dataRow["Table"] = A_1;
					}
					if (Operators.CompareString(Conversions.ToString(dataRow["Table"]), "[" + A_0 + "]", true) == 0)
					{
						dataRow["Table"] = "[" + A_1 + "]";
					}
					if (Operators.CompareString(Conversions.ToString(dataRow["Table"]), "{" + A_0 + "}", true) == 0)
					{
						dataRow["Table"] = "{" + A_1 + "}";
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
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
			try
			{
				foreach (object obj2 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows)
				{
					DataRow dataRow2 = (DataRow)obj2;
					if (Operators.CompareString(Conversions.ToString(dataRow2["Table"]), A_0, true) == 0)
					{
						dataRow2["Table"] = A_1;
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
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
			try
			{
				foreach (object obj3 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()].Rows)
				{
					DataRow dataRow3 = (DataRow)obj3;
					if (!dataRow3.IsNull("Table") && Operators.CompareString(Conversions.ToString(dataRow3["Table"]), A_0, true) == 0)
					{
						dataRow3["Table"] = A_1;
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
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()], true);
			try
			{
				foreach (object obj4 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Rows)
				{
					DataRow dataRow4 = (DataRow)obj4;
					if (Operators.CompareString(Conversions.ToString(dataRow4["Table"]), A_0, true) == 0)
					{
						dataRow4["Table"] = A_1;
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
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()], true);
			try
			{
				foreach (object obj5 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()].Rows)
				{
					DataRow dataRow5 = (DataRow)obj5;
					if (Operators.CompareString(Conversions.ToString(dataRow5["ParentTable"]), A_0, true) == 0)
					{
						dataRow5["ParentTable"] = A_1;
					}
					if (Operators.CompareString(Conversions.ToString(dataRow5["ChildTable"]), A_0, true) == 0)
					{
						dataRow5["ChildTable"] = A_1;
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
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()], true);
			string file = string.Concat(new string[]
			{
				OO_00oOO.ProjectPath,
				"Bin\\",
				o0OoOOoOOo0.oo00o.0OoO.(""),
				".DataTable.",
				A_0,
				".dll"
			});
			if (OO_00oOO.FileSys.FileExists(file))
			{
				OO_00oOO.FileSys.RenameFile(file, o0OoOOoOOo0.oo00o.0OoO.("") + ".DataTable." + A_1 + ".dll");
			}
		}

		/// <summary>
		/// 设置关联
		/// </summary>
		// Token: 0x06005AFB RID: 23291 RVA: 0x0026E0A4 File Offset: 0x0026C2A4
		[oO0oooo("0091")]
		public static void ModifyDataRelation()
		{
			if (ooO.oo__.O000_o_O.())
			{
				if (OO_00oOO.CurrentTable.DataTable.frd_IsTemporary)
				{
					MessageBox.Show("临时表不能建立关联！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				OO_00oOO.Forms.ooO0_o._o.();
				new o\u3000\u3000\u3002\u3000\u3000
				{
					Owner = Main.OO_O.o.
				}.ShowDialog();
				bool flag;
				try
				{
					foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
					{
						DataRelation dataRelation = (DataRelation)obj;
						int num = dataRelation.ChildColumns.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							if (!o_O_o_oOoo__.oO.O_..Contains(dataRelation.ChildColumns[i].ColumnName) && !o_O_o_oOoo__.oO.O_..Contains(dataRelation.ParentColumns[i].ColumnName) && (OO_00oOO.DataTables[dataRelation.ChildTable.TableName].DataCols[dataRelation.ChildColumns[i].ColumnName].oO.O. || OO_00oOO.DataTables[dataRelation.ParentTable.TableName].DataCols[dataRelation.ParentColumns[i].ColumnName].oO.O.))
							{
								flag = true;
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
				if (flag)
				{
					MessageBox.Show("需要重新打开项目，才能确保有关设置生效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Project.Open(OO_00oOO.ProjectFile, new string[0]);
					if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
					{
						Main.OO_O.o..o._oOO0. = true;
					}
				}
			}
		}

		/// <summary>
		/// 设置表属性
		/// </summary>
		// Token: 0x06005AFC RID: 23292 RVA: 0x0026E25C File Offset: 0x0026C45C
		[oO0oooo("0011")]
		public static void ModifyProperty()
		{
			if (ooO.oo__.O000_o_O.() && OO_00oOO.CurrentTable != null && !OO_00oOO.CurrentTable.DataTable.AddByCode && OO_00oOO.CurrentTable.DataTable.O0o.O_0_O.())
			{
				new o\u3002\u3000\u3000\u30000(OO_00oOO.CurrentTable.DataTable).ShowDialog();
			}
		}

		/// <summary>
		/// 自定义样式
		/// </summary>
		// Token: 0x06005AFD RID: 23293 RVA: 0x0026E2AE File Offset: 0x0026C4AE
		[oO0oooo("0656")]
		public static void ModifyUserCellStyle()
		{
			if (ooO.oo__.O000_o_O.() && OO_00oOO.CurrentTable != null && !OO_00oOO.CurrentTable.DataTable.AddByCode)
			{
				new O\u3002\u3002\u3000\u3000\u3000\u3000(OO_00oOO.CurrentTable.DataTable).ShowDialog();
			}
		}

		/// <summary>
		/// 修改表样式
		/// </summary>
		// Token: 0x06005AFE RID: 23294 RVA: 0x0026E2E4 File Offset: 0x0026C4E4
		[oO0oooo("0013")]
		public static void ModifyLookAndFeel()
		{
			if (ooO.oo__.O000_o_O.() && OO_00oOO.CurrentTable != null && !OO_00oOO.CurrentTable.DataTable.AddByCode)
			{
				new O\u30020\u3002O\u3000\u3002\u3002\u3002\u3000(OO_00oOO.CurrentTable.DataTable).ShowDialog();
			}
		}

		/// <summary>
		/// 设置合并模式
		/// </summary>
		// Token: 0x06005AFF RID: 23295 RVA: 0x0026E31A File Offset: 0x0026C51A
		[oO0oooo("0157")]
		public static void SetMergeMode()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				new O\u3000\u3000\u3000\u3000_\u3002(OO_00oOO.CurrentTable).ShowDialog();
			}
		}

		/// <summary>
		/// 切换合并模式
		/// </summary>
		// Token: 0x06005B00 RID: 23296 RVA: 0x0026E334 File Offset: 0x0026C534
		[oO0oooo("0157")]
		public static void ToggleMergeMode()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.ClearEditInfos();
				if (OO_00oOO.CurrentTable.MergeCols.Count > 0)
				{
					OO_00oOO.CurrentTable.AllowMerge = !OO_00oOO.CurrentTable.AllowMerge;
					return;
				}
				Table.SetMergeMode();
			}
		}

		/// <summary>
		/// 打开汇总模式设置窗口，并加载最近一次统计的设置
		/// </summary>
		// Token: 0x06005B01 RID: 23297 RVA: 0x0026E381 File Offset: 0x0026C581
		[oO0oooo("00144")]
		public static void SetSubtotalMode()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				new du(OO_00oOO.CurrentTable, false).ShowDialog();
			}
		}

		/// <summary>
		/// 按上一次的设置，重新生成汇总模式
		/// </summary>
		// Token: 0x06005B02 RID: 23298 RVA: 0x0026E39B File Offset: 0x0026C59B
		[oO0oooo("00144")]
		public static void ReSubtotal()
		{
			if (OO_00oOO.CurrentTable != null && OO_00oOO.CurrentTable.SubtotalGroups.Count > 0)
			{
				if (!OO_00oOO.CurrentTable.IsSubtotal)
				{
					OO_00oOO.CurrentTable.ClearEditInfos();
				}
				OO_00oOO.CurrentTable.Subtotal(false);
			}
		}

		/// <summary>
		/// 打开汇总模式设置窗口，不加载最近一次统计的设置
		/// </summary>
		// Token: 0x06005B03 RID: 23299 RVA: 0x0026E3D7 File Offset: 0x0026C5D7
		[oO0oooo("00144")]
		public static void NewSubtotalMode()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				new du(OO_00oOO.CurrentTable, true).ShowDialog();
			}
		}

		/// <summary>
		/// 切换汇总模式
		/// </summary>
		// Token: 0x06005B04 RID: 23300 RVA: 0x0026E3F4 File Offset: 0x0026C5F4
		[oO0oooo("00144")]
		public static void ToggleSubtotalMode()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.foxGrid;
				if (OO_00oOO.CurrentTable.IsSubtotal)
				{
					OO_00oOO.CurrentTable.Sort = "";
					OO_00oOO.CurrentTable.ClearEditInfos();
					OO_00oOO.CurrentTable.ClearSubtotal();
				}
				else if (OO_00oOO.CurrentTable.SubtotalGroups.Count > 0)
				{
					OO_00oOO.CurrentTable.ClearEditInfos();
					OO_00oOO.CurrentTable.Subtotal(false);
				}
				else
				{
					Table.SetSubtotalMode();
				}
			}
		}

		/// <summary>
		/// 切换合计模式
		/// </summary>
		// Token: 0x06005B05 RID: 23301 RVA: 0x0026E474 File Offset: 0x0026C674
		[oO0oooo("2748")]
		public static void ToggleGrandTotal()
		{
			if (OO_00oOO.CurrentTable != null && !OO_00oOO.CurrentTable.IsSubtotal && !OO_00oOO.CurrentTable.foxGrid.OO.o_o00o.())
			{
				if (!OO_00oOO.CurrentTable.GrandTotal)
				{
					int num;
					try
					{
						foreach (Col col in OO_00oOO.CurrentTable.Cols)
						{
							if (col.GrandTotal && col.IsNumeric())
							{
								num++;
							}
						}
					}
					finally
					{
						IEnumerator<Col> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					if (num != 0)
					{
						OO_00oOO.CurrentTable.ClearSubtotal();
						OO_00oOO.CurrentTable.GrandTotal = true;
						C1FlexGrid c1FlexGrid = OO_00oOO.CurrentTable.Grid;
						c1FlexGrid.TopRow = c1FlexGrid.Rows.Count - 1;
						return;
					}
					if (Operators.CompareString(OO_00oOO.CurrentTable.ooo_O0oOo.0O., "", true) > 0)
					{
						foreach (string text in OO_00oOO.CurrentTable.ooo_O0oOo.0O..Split(new char[]
						{
							','
						}))
						{
							if (OO_00oOO.CurrentTable.Cols.Contains(text) && OO_00oOO.CurrentTable.Cols[text].IsNumeric())
							{
								OO_00oOO.CurrentTable.Cols[text].GrandTotal = true;
								num++;
							}
						}
					}
					if (num == 0)
					{
						Table.SetGrandTotal();
						return;
					}
					OO_00oOO.CurrentTable.ClearSubtotal();
					OO_00oOO.CurrentTable.GrandTotal = true;
					C1FlexGrid c1FlexGrid2 = OO_00oOO.CurrentTable.Grid;
					c1FlexGrid2.TopRow = c1FlexGrid2.Rows.Count - 1;
					return;
				}
				else
				{
					OO_00oOO.CurrentTable.GrandTotal = false;
				}
			}
		}

		/// <summary>
		/// 设置合计模式
		/// </summary>
		// Token: 0x06005B06 RID: 23302 RVA: 0x0026E624 File Offset: 0x0026C824
		[oO0oooo("2748")]
		public static void SetGrandTotal()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				new o\u30000(OO_00oOO.CurrentTable).ShowDialog();
			}
		}

		/// <summary>
		/// 修改表字体
		/// </summary>
		// Token: 0x06005B07 RID: 23303 RVA: 0x0026E640 File Offset: 0x0026C840
		public static void ChangeFont()
		{
			FontDialog fontDialog = new FontDialog();
			fontDialog.Font = OO_00oOO.CurrentTable.Font;
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				OO_00oOO.CurrentTable.Font = fontDialog.Font;
				OO_00oOO.CurrentTable.NeedSaveSetting = true;
			}
		}

		/// <summary>
		/// 修改表的字体名称
		/// </summary>
		/// <param name="FontName">字体名称</param>
		// Token: 0x06005B08 RID: 23304 RVA: 0x0026E688 File Offset: 0x0026C888
		public static void ChangeFontName(string FontName)
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.Font = new Font(FontName, OO_00oOO.CurrentTable.Font.Size, OO_00oOO.CurrentTable.Font.Style);
				O_oOooO_O o_oOooO_O = OO_00oOO.CurrentTable.foxGrid;
				if (o_oOooO_O.TopRow > 0)
				{
					o_oOooO_O.AutoSizeCols(o_oOooO_O.TopRow, 0, o_oOooO_O.BottomRow, 0, 0, AutoSizeFlags.None);
				}
			}
		}

		/// <summary>
		/// 修改表的字体大小
		/// </summary>
		/// <param name="FontSize">字体大小</param>
		// Token: 0x06005B09 RID: 23305 RVA: 0x0026E6F8 File Offset: 0x0026C8F8
		public static void ChangeFontSize(int FontSize)
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.Font = new Font(OO_00oOO.CurrentTable.Font.Name, (float)FontSize, OO_00oOO.CurrentTable.Font.Style);
				O_oOooO_O o_oOooO_O = OO_00oOO.CurrentTable.foxGrid;
				if (o_oOooO_O.TopRow > 0)
				{
					o_oOooO_O.AutoSizeCols(o_oOooO_O.TopRow, 0, o_oOooO_O.BottomRow, 0, 0, AutoSizeFlags.None);
				}
			}
		}

		/// <summary>
		/// 切换表字体的粗体样式
		/// </summary>
		// Token: 0x06005B0A RID: 23306 RVA: 0x0026E767 File Offset: 0x0026C967
		public static void ToggleFontBold()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.Font = new Font(OO_00oOO.CurrentTable.Font, OO_00oOO.CurrentTable.Font.Style ^ FontStyle.Bold);
			}
		}

		/// <summary>
		/// 切换表字体的斜体样式
		/// </summary>
		// Token: 0x06005B0B RID: 23307 RVA: 0x0026E79A File Offset: 0x0026C99A
		public static void ToggleFontItalic()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.Font = new Font(OO_00oOO.CurrentTable.Font, OO_00oOO.CurrentTable.Font.Style ^ FontStyle.Italic);
			}
		}

		/// <summary>
		/// 切换表字体的下划线
		/// </summary>
		// Token: 0x06005B0C RID: 23308 RVA: 0x0026E7CD File Offset: 0x0026C9CD
		public static void ToggleFontUnderLine()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.Font = new Font(OO_00oOO.CurrentTable.Font, OO_00oOO.CurrentTable.Font.Style ^ FontStyle.Underline);
			}
		}

		/// <summary>
		/// 设置背景颜色
		/// </summary>
		/// <param name="color">颜色</param>
		// Token: 0x06005B0D RID: 23309 RVA: 0x0026E800 File Offset: 0x0026CA00
		public static void ChangeBackColor(Color color)
		{
			if (OO_00oOO.CurrentTable != null)
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == OO_00oOO.CurrentTable.DataTable)
						{
							if (table.foxGrid.Styles.Normal.BackColor == table.foxGrid.Styles.Alternate.BackColor)
							{
								table.foxGrid.Styles.Alternate.BackColor = color;
							}
							table.foxGrid.Styles.Normal.BackColor = color;
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
				OO_00oOO.CurrentTable.DataTable.frd_LookAndFeel.BackColor = color;
			}
		}

		/// <summary>
		/// 设置字体颜色
		/// </summary>
		/// <param name="color">颜色</param>
		// Token: 0x06005B0E RID: 23310 RVA: 0x0026E8D4 File Offset: 0x0026CAD4
		public static void ChangeForeColor(Color color)
		{
			if (OO_00oOO.CurrentTable != null)
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == OO_00oOO.CurrentTable.DataTable)
						{
							if (table.foxGrid.Styles.Normal.ForeColor == table.foxGrid.Styles.Alternate.ForeColor)
							{
								table.foxGrid.Styles.Alternate.ForeColor = color;
							}
							table.foxGrid.Styles.Normal.ForeColor = color;
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
				OO_00oOO.CurrentTable.DataTable.frd_LookAndFeel.ForeColor = color;
			}
		}

		/// <summary>
		/// 设置交替行的背景颜色
		/// </summary>
		/// <param name="color"></param>
		// Token: 0x06005B0F RID: 23311 RVA: 0x0026E9A8 File Offset: 0x0026CBA8
		public static void ChangeAlterBackColor(Color color)
		{
			if (OO_00oOO.CurrentTable != null)
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == OO_00oOO.CurrentTable.DataTable)
						{
							if (color == table.foxGrid.Styles.Normal.BackColor)
							{
								table.foxGrid.Styles.Alternate.Clear(StyleElementFlags.BackColor);
							}
							else
							{
								table.foxGrid.Styles.Alternate.BackColor = color;
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
				OO_00oOO.CurrentTable.DataTable.frd_LookAndFeel.AlterRowBackColor = color;
			}
		}

		/// <summary>
		/// 设置网格线颜色
		/// </summary>
		/// <param name="color">颜色</param>
		// Token: 0x06005B10 RID: 23312 RVA: 0x0026EA6C File Offset: 0x0026CC6C
		public static void ChangeGridLineColor(Color color)
		{
			if (OO_00oOO.CurrentTable != null)
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == OO_00oOO.CurrentTable.DataTable)
						{
							table.foxGrid.Styles.Normal.Border.Color = color;
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
				OO_00oOO.CurrentTable.DataTable.frd_LookAndFeel.GridColor = color;
			}
		}

		/// <summary>
		/// 设置网格线方向
		/// </summary>
		/// <param name="Direction">网格线方向</param>
		// Token: 0x06005B11 RID: 23313 RVA: 0x0026EAFC File Offset: 0x0026CCFC
		public static void ChangeGridLineDirection(GridLineDirectionEnum Direction)
		{
			if (OO_00oOO.CurrentTable != null)
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == OO_00oOO.CurrentTable.DataTable)
						{
							if (table.foxGrid.Styles.Normal.Border.Style == BorderStyleEnum.None)
							{
								table.foxGrid.Styles.Normal.Border.Style = BorderStyleEnum.Flat;
							}
							switch (Direction)
							{
							case GridLineDirectionEnum.Both:
								table.foxGrid.Styles.Normal.Border.Direction = BorderDirEnum.Both;
								break;
							case GridLineDirectionEnum.Horizontal:
								table.foxGrid.Styles.Normal.Border.Direction = BorderDirEnum.Horizontal;
								break;
							case GridLineDirectionEnum.Vertical:
								table.foxGrid.Styles.Normal.Border.Direction = BorderDirEnum.Vertical;
								break;
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
				OO_00oOO.CurrentTable.DataTable.frd_LookAndFeel.GridLineDirection = Direction;
			}
		}

		/// <summary>
		/// 切换排序和筛选
		/// </summary>
		// Token: 0x06005B12 RID: 23314 RVA: 0x0026EC20 File Offset: 0x0026CE20
		[oO0oooo("")]
		public static void ToggleSortAndFilter()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				table.ClearEditInfos();
				if (Operators.CompareString(table.View.get_Filter(), "", true) > 0 || Operators.CompareString(table.View.oO_O.o_OOO.(), "", true) > 0 || table.DataTable.InBackEndFilterMode)
				{
					if (Operators.CompareString(table.View.oO_O.o_OOO.(), "", true) > 0)
					{
						table.ApplySort = false;
					}
					else
					{
						table.View.o_O_.00o.("");
						table.View.O00o0.0_0O_.();
					}
					if (Operators.CompareString(table.View.get_Filter(), "", true) > 0)
					{
						table.ApplyFilter = false;
					}
					else
					{
						table.View.Oo._Oo0OO.("");
					}
					if (table.AllowBackEndFilter)
					{
						table.DataTable.OOo_00.oo.();
						return;
					}
				}
				else
				{
					table.ApplySort = true;
					if (table.AllowBackEndFilter)
					{
						table.DataTable.OOo_00.oo.();
						return;
					}
					table.ApplyFilter = true;
				}
			}
		}

		/// <summary>
		/// 锁定表
		/// </summary>
		// Token: 0x06005B13 RID: 23315 RVA: 0x0026ED28 File Offset: 0x0026CF28
		[oO0oooo("0034")]
		public static void Lock()
		{
			if (OO_00oOO.DataTables.AllowEdit && OO_00oOO.CurrentTable != null && !OO_00oOO.CurrentTable.DataTable.frd_IsInnerQuery && !OO_00oOO.CurrentTable.DataTable.frd_IsOuterQuery)
			{
				OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(new O_000O(OO_00oOO.CurrentTable.DataTable));
				OO_00oOO.CurrentTable.DataTable.AllowEdit = false;
			}
		}

		/// <summary>
		/// 取消锁定表
		/// </summary>
		// Token: 0x06005B14 RID: 23316 RVA: 0x0026ED98 File Offset: 0x0026CF98
		[oO0oooo("0034")]
		public static void Unlock()
		{
			if (OO_00oOO.DataTables.AllowEdit && OO_00oOO.CurrentTable != null && !OO_00oOO.CurrentTable.DataTable.frd_IsInnerQuery && !OO_00oOO.CurrentTable.DataTable.frd_IsOuterQuery)
			{
				OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(new O_000O(OO_00oOO.CurrentTable.DataTable));
				OO_00oOO.CurrentTable.DataTable.AllowEdit = true;
			}
		}

		// Token: 0x06005B15 RID: 23317 RVA: 0x0026EE08 File Offset: 0x0026D008
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void GetAllValue()
		{
		}

		/// <summary>
		/// 导出为文本文件
		/// </summary>
		// Token: 0x06005B16 RID: 23318 RVA: 0x0026EE0C File Offset: 0x0026D00C
		[oO0oooo("0180")]
		public static void ExportToText()
		{
			o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000 o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u = new o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000();
			if (o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.O00_0.0o00_.().ShowDialog() == DialogResult.OK)
			{
				o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.o0_0.0OOO_0Oo. = o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.O00_0.0o00_.().FileName;
				o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.Text = o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.Text + " - " + c.OOOOO.o.().FileSystem.GetName(o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.o0_0.0OOO_0Oo.);
				o_u3002_u3000_u3000_u3000_u3002_u3002_u3000_u.ShowDialog();
			}
		}

		/// <summary>
		/// 导出为XML文件
		/// </summary>
		// Token: 0x06005B17 RID: 23319 RVA: 0x0026EE70 File Offset: 0x0026D070
		public static void ExportToXML()
		{
			O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000 o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u = new O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000();
			if (o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.o0_0.0OOO_0Oo.().ShowDialog() == DialogResult.OK)
			{
				o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.oOO.O0_oo_0. = o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.o0_0.0OOO_0Oo.().FileName;
				o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.Text = o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.Text + " - " + c.OOOOO.o.().FileSystem.GetName(o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.oOO.O0_oo_0.);
				o_u3000_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u.ShowDialog();
			}
		}

		/// <summary>
		/// 合并表
		/// </summary>
		// Token: 0x06005B18 RID: 23320 RVA: 0x0026EED4 File Offset: 0x0026D0D4
		[oO0oooo("")]
		public static void Merge()
		{
			O\u3002\u3000\u3000\u3002\u3000\u3002 o_u3002_u3000_u3000_u3002_u3000_u = new O\u3002\u3000\u3000\u3002\u3000\u3002("");
			if (o_u3002_u3000_u3000_u3002_u3000_u.o0_o.__ooo_0_.())
			{
				o_u3002_u3000_u3000_u3002_u3000_u.oo0o_o._.();
				o_u3002_u3000_u3000_u3002_u3000_u.ShowDialog();
			}
		}

		/// <summary>
		/// 快速合并
		/// </summary>
		// Token: 0x06005B19 RID: 23321 RVA: 0x0026EF04 File Offset: 0x0026D104
		[oO0oooo("0187")]
		public static void QuickMerge()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Excel(*.xls,*.xlsx)|*.XLS;*.XLSX|Access(*.mdb,*.accdb)|*.MDB;*.ACCDB|dBASE(*.dbf)|*.DBF|Text(*.txt)|*.TXT";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				new O\u3002\u3000\u3000\u3002\u3000\u3002(openFileDialog.FileName, true).ShowDialog();
			}
		}

		/// <summary>
		/// 从XML文件合并
		/// </summary>
		// Token: 0x06005B1A RID: 23322 RVA: 0x0026EF40 File Offset: 0x0026D140
		public static void MergeFromXML()
		{
			o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002 o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u = new o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002();
			if (o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.OoO_.O.().ShowDialog() == DialogResult.OK)
			{
				o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.O0.__O0O. = o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.OoO_.O.().FileName;
				o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.Text = o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.Text + " - " + c.OOOOO.o.().FileSystem.GetName(o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.O0.__O0O.);
				o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.O0.00_0_.();
				o_u3000_u3002_u3002_u3000_u3000_u3000_u3000_u3000_u3000_u.ShowDialog();
			}
		}

		/// <summary>
		/// 从文本文件合并
		/// </summary>
		// Token: 0x06005B1B RID: 23323 RVA: 0x0026EFAC File Offset: 0x0026D1AC
		[oO0oooo("0187")]
		public static void MergeFromText()
		{
			O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002 o_u3002o_u3000_u3002_u3000_u3000__u3002_u3000_u3002_u = new O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002();
			if (o_u3002o_u3000_u3002_u3000_u3000__u3002_u3000_u3002_u.OoOO.000_o_O.().ShowDialog() == DialogResult.OK)
			{
				o_u3002o_u3000_u3002_u3000_u3000__u3002_u3000_u3002_u.OoO_.O. = o_u3002o_u3000_u3002_u3000_u3000__u3002_u3000_u3002_u.OoOO.000_o_O.().FileName;
				o_u3002o_u3000_u3002_u3000_u3000__u3002_u3000_u3002_u.Oo_0.oooo__.();
				o_u3002o_u3000_u3002_u3000_u3000__u3002_u3000_u3002_u.ShowDialog();
			}
		}

		/// <summary>
		/// 设置停靠位置,仅对关联表有效
		/// </summary>
		// Token: 0x06005B1C RID: 23324 RVA: 0x0026EFEB File Offset: 0x0026D1EB
		[oO0oooo("0094")]
		public static void DockSetting()
		{
			if (ooO.oo__.O000_o_O.() && OO_00oOO.CurrentTable != null && OO_00oOO.CurrentTable.IsRelation)
			{
				new O\u3002\u3002\u3002(OO_00oOO.CurrentTable).ShowDialog();
			}
		}

		// Token: 0x06005B1D RID: 23325 RVA: 0x0026F017 File Offset: 0x0026D217
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void StatusViewer()
		{
		}

		/// <summary>
		/// 保存表视图
		/// </summary>
		// Token: 0x06005B1E RID: 23326 RVA: 0x0026F019 File Offset: 0x0026D219
		[oO0oooo("0191")]
		public static void SaveTableView()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				new O\u3002\u3000\u3002\u3002O\u3002oo\u3002\u3002\u3002(OO_00oOO.CurrentTable).ShowDialog();
			}
		}

		/// <summary>
		/// 打开表视图管理窗口
		/// </summary>
		// Token: 0x06005B1F RID: 23327 RVA: 0x0026F032 File Offset: 0x0026D232
		[oO0oooo("0191")]
		public static void TableViewManager()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				new o\u3002o\u3002\u3002\u3000\u30020\u3002\u3000\u3002\u3002\u3000(OO_00oOO.CurrentTable).ShowDialog();
			}
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x0026F04B File Offset: 0x0026D24B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void Refresh()
		{
			Table.Load();
		}

		/// <summary>
		/// 重新加载表数据
		/// </summary>
		// Token: 0x06005B21 RID: 23329 RVA: 0x0026F054 File Offset: 0x0026D254
		[oO0oooo("0115")]
		public static void Load()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				Main.ProcessForm.o0__.Oo0O_O0O_.("正在同步" + OO_00oOO.CurrentTable.Name + "，请稍候...");
				Main.ProcessForm.Show();
				Application.DoEvents();
				OO_00oOO.CurrentTable.DataTable.o0.o.(true, null);
				Main.ProcessForm.Close();
			}
		}

		/// <summary>
		/// 开分组统计设置窗口，并加载最近一次统计的设置
		/// </summary>
		// Token: 0x06005B22 RID: 23330 RVA: 0x0026F0B5 File Offset: 0x0026D2B5
		[oO0oooo("0158")]
		public static void BuildGroupTable()
		{
			if (Table.OO.OO_0o.())
			{
				new j8(false).ShowDialog();
				OO_00oOO.MainTable.foxGrid.Focus();
			}
		}

		/// <summary>
		/// 打开分组统计设置窗口，不加载最近一次统计的设置
		/// </summary>
		// Token: 0x06005B23 RID: 23331 RVA: 0x0026F0DA File Offset: 0x0026D2DA
		[oO0oooo("0158")]
		public static void NewGroupTable()
		{
			if (Table.OO.OO_0o.())
			{
				new j8(true).ShowDialog();
				OO_00oOO.MainTable.foxGrid.Focus();
			}
		}

		/// <summary>
		/// 根据最近一次的设置，重新生成分组统计表
		/// </summary>
		// Token: 0x06005B24 RID: 23332 RVA: 0x0026F100 File Offset: 0x0026D300
		[oO0oooo("0158")]
		public static void RebuildGroupTable()
		{
			if (Table.OO.OO_0o.())
			{
				GroupTableBuilder o_0._O_0OO000O. = OO_00oOO.CurrentTable.O_0._O_0OO000O.;
				if (o_0._O_0OO000O. != null)
				{
					if (OO_00oOO.CurrentTable.O.OoOo_. != null && OO_00oOO.CurrentTable.O.OoOo_..FindForm() == Main.OO_O.o. && Operators.CompareString(OO_00oOO.CurrentTable.DataTable.LoadTop, "", true) > 0 && OO_00oOO.CurrentTable.AllowBackEndFilter)
					{
						string text = "";
						if (!o_0._O_0OO000O..FromAll)
						{
							text = OO_00oOO.CurrentTable.DataTable.LoadFilter;
						}
						if (Operators.CompareString(o_0._O_0OO000O..ExtendFilter, "", true) > 0)
						{
							if (Operators.CompareString(text, "", true) > 0)
							{
								text = "(" + text + ") And " + o_0._O_0OO000O..ExtendFilter;
							}
							else
							{
								text = o_0._O_0OO000O..ExtendFilter;
							}
						}
						bool fromServer = o_0._O_0OO000O..FromServer;
						o_0._O_0OO000O..FromServer = true;
						o_0._O_0OO000O..Filter = text;
						o_0._O_0OO000O..Build();
						o_0._O_0OO000O..FromServer = fromServer;
					}
					else
					{
						string text2 = Oo00.OoO_.__o.(OO_00oOO.CurrentTable, o_0._O_0OO000O..FromServer);
						if (Operators.CompareString(o_0._O_0OO000O..ExtendFilter, "", true) > 0)
						{
							if (Operators.CompareString(text2, "", true) > 0)
							{
								text2 = "(" + text2 + ") And " + o_0._O_0OO000O..ExtendFilter;
							}
							else
							{
								text2 = o_0._O_0OO000O..ExtendFilter;
							}
						}
						o_0._O_0OO000O..Filter = text2;
						o_0._O_0OO000O..Build();
					}
					if (OO_00oOO.Tables.get_Contains(o_0._O_0OO000O..TableName))
					{
						OO_00oOO.MainTable = OO_00oOO.Tables[o_0._O_0OO000O..TableName];
						return;
					}
				}
				else
				{
					Table.BuildGroupTable();
				}
			}
		}

		/// <summary>
		/// 打开交叉统计设置窗口，并加载最近一次统计的设置
		/// </summary>
		// Token: 0x06005B25 RID: 23333 RVA: 0x0026F294 File Offset: 0x0026D494
		[oO0oooo("0165")]
		public static void BuildCrossTable()
		{
			if (Table.OO.OO_0o.())
			{
				new mf(false).ShowDialog();
				OO_00oOO.MainTable.foxGrid.Focus();
			}
		}

		/// <summary>
		/// 打开交叉统计设置窗口，不加载最近一次统计的设置
		/// </summary>
		// Token: 0x06005B26 RID: 23334 RVA: 0x0026F2B9 File Offset: 0x0026D4B9
		[oO0oooo("0165")]
		public static void NewCrossTable()
		{
			if (Table.OO.OO_0o.())
			{
				new mf(true).ShowDialog();
				OO_00oOO.MainTable.foxGrid.Focus();
			}
		}

		/// <summary>
		/// 根据最近一次的设置，重新生成交叉统计表
		/// </summary>
		// Token: 0x06005B27 RID: 23335 RVA: 0x0026F2E0 File Offset: 0x0026D4E0
		[oO0oooo("0165")]
		public static void RebuildCrossTable()
		{
			if (Table.OO.OO_0o.())
			{
				CrossTableBuilder o_0._O_0OO000O. = OO_00oOO.CurrentTable.O_0._O_0OO000O.;
				if (o_0._O_0OO000O. != null)
				{
					if (OO_00oOO.CurrentTable.O.OoOo_. != null && OO_00oOO.CurrentTable.O.OoOo_..FindForm() == Main.OO_O.o. && Operators.CompareString(OO_00oOO.CurrentTable.DataTable.LoadTop, "", true) > 0 && OO_00oOO.CurrentTable.AllowBackEndFilter)
					{
						string text = "";
						if (!o_0._O_0OO000O..FromAll)
						{
							text = OO_00oOO.CurrentTable.DataTable.LoadFilter;
						}
						if (Operators.CompareString(o_0._O_0OO000O..ExtendFilter, "", true) > 0)
						{
							if (Operators.CompareString(text, "", true) > 0)
							{
								text = "(" + text + ") And " + o_0._O_0OO000O..ExtendFilter;
							}
							else
							{
								text = o_0._O_0OO000O..ExtendFilter;
							}
						}
						bool fromServer = o_0._O_0OO000O..FromServer;
						o_0._O_0OO000O..FromServer = true;
						o_0._O_0OO000O..Filter = text;
						o_0._O_0OO000O..Build();
						o_0._O_0OO000O..FromServer = fromServer;
					}
					else
					{
						string text2 = Oo00.OoO_.__o.(OO_00oOO.CurrentTable, o_0._O_0OO000O..FromServer);
						if (Operators.CompareString(o_0._O_0OO000O..ExtendFilter, "", true) > 0)
						{
							if (Operators.CompareString(text2, "", true) > 0)
							{
								text2 = text2 + " And " + o_0._O_0OO000O..ExtendFilter;
							}
							else
							{
								text2 = o_0._O_0OO000O..ExtendFilter;
							}
						}
						o_0._O_0OO000O..Filter = text2;
						o_0._O_0OO000O..Build();
					}
					if (OO_00oOO.Tables.get_Contains(o_0._O_0OO000O..TableName))
					{
						OO_00oOO.MainTable = OO_00oOO.Tables[o_0._O_0OO000O..TableName];
						return;
					}
				}
				else
				{
					Table.BuildCrossTable();
				}
			}
		}

		// Token: 0x06005B28 RID: 23336 RVA: 0x0026F470 File Offset: 0x0026D670
		internal static bool <<EMPTY_NAME>>()
		{
			bool result;
			if ((OO_00oOO.CurrentTable == null || OO_00oOO.CurrentTable.Rows.Count < 2) && Operators.CompareString(OO_00oOO.CurrentTable.DataTable.LoadFilter, "", true) == 0)
			{
				MessageBox.Show("至少要有多于一行的数据，才能进行分组统计！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06005B29 RID: 23337 RVA: 0x0026F4CC File Offset: 0x0026D6CC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void Move()
		{
			MessageBox.Show("用鼠标左右拖动表标题，即可调整表的位置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		/// <summary>
		/// 打开Excel报表管理器
		/// </summary>
		// Token: 0x06005B2A RID: 23338 RVA: 0x0026F4E1 File Offset: 0x0026D6E1
		[oO0oooo("0199")]
		public static void ExcelReportManager()
		{
			if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
			{
				MessageBox.Show("必须先保存项目，才能管理报表模版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			new o\u3000\u3002o\u3002\u3000\u3002_\u3002\u3000\u3000\u3002().ShowDialog();
		}

		/// <summary>
		/// 打开Word报表管理器
		/// </summary>
		// Token: 0x06005B2B RID: 23339 RVA: 0x0026F514 File Offset: 0x0026D714
		[oO0oooo("2879")]
		public static void WordReportManager()
		{
			if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
			{
				MessageBox.Show("必须先保存项目，才能管理报表模版！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			new o\u3000_\u3000\u3002_\u3002\u3000().ShowDialog();
		}

		/// <summary>
		/// 打开专业报表管理器
		/// </summary>
		// Token: 0x06005B2C RID: 23340 RVA: 0x0026F547 File Offset: 0x0026D747
		public static void CodeReportManager()
		{
			if (ooO.oo__.O000_o_O.())
			{
				new o0\u3002().ShowDialog();
			}
		}

		/// <summary>
		/// 回收已经删除的行
		/// </summary>
		// Token: 0x06005B2D RID: 23341 RVA: 0x0026F55C File Offset: 0x0026D75C
		[oO0oooo("1632")]
		public static void Recyle()
		{
			if (OO_00oOO.CurrentTable.DataTable.BaseTable.Select("", "", DataViewRowState.Deleted).Length == 0)
			{
				MessageBox.Show("没有可回收的删除行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			new O_\u3002\u3000\u3002\u3000(OO_00oOO.CurrentTable.DataTable).ShowDialog();
		}

		/// <summary>
		/// 左移表
		/// </summary>
		// Token: 0x06005B2E RID: 23342 RVA: 0x0026F5B8 File Offset: 0x0026D7B8
		public static void MoveLeft()
		{
			int selectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex;
			if (selectedIndex > 0)
			{
				ShareLibriay.LockWindowUpdate(OO_00oOO.BaseMainForm.Handle);
				OO_00oOO.BaseMainForm.SuspendLayout();
				OO___OO0O_0 oo___OO0O_ = Main.OO_O.o..OO_O_0Oo.___o.();
				oo___OO0O_.SuspendLayout();
				oo___OO0O_.TabPages.Insert(selectedIndex - 1, oo___OO0O_.SelectedTab);
				oo___OO0O_.SelectedIndex = selectedIndex - 1;
				oo___OO0O_.ResumeLayout();
				OO_00oOO.BaseMainForm.ResumeLayout();
				ShareLibriay.LockWindowUpdate(IntPtr.Zero);
			}
		}

		/// <summary>
		/// 右移表
		/// </summary>
		// Token: 0x06005B2F RID: 23343 RVA: 0x0026F640 File Offset: 0x0026D840
		public static void MoveRight()
		{
			int selectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex;
			OO___OO0O_0 oo___OO0O_ = Main.OO_O.o..OO_O_0Oo.___o.();
			if (selectedIndex < oo___OO0O_.TabPages.Count - 1)
			{
				ShareLibriay.LockWindowUpdate(OO_00oOO.BaseMainForm.Handle);
				OO_00oOO.BaseMainForm.SuspendLayout();
				oo___OO0O_.SuspendLayout();
				oo___OO0O_.TabPages.Insert(selectedIndex + 1, oo___OO0O_.SelectedTab);
				oo___OO0O_.SelectedIndex = selectedIndex + 1;
				oo___OO0O_.ResumeLayout();
				OO_00oOO.BaseMainForm.ResumeLayout();
				ShareLibriay.LockWindowUpdate(IntPtr.Zero);
			}
		}

		/// <summary>
		/// 设置标志列
		/// </summary>
		// Token: 0x06005B30 RID: 23344 RVA: 0x0026F6D2 File Offset: 0x0026D8D2
		[oO0oooo("1797")]
		public static void SetFunctionColumn()
		{
			OO_00oOO.DataTables.Save();
			new O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000
			{
				Owner = Main.OO_O.o.
			}.ShowDialog();
		}

		/// <summary>
		/// 内联MRP统计
		/// </summary>
		// Token: 0x06005B31 RID: 23345 RVA: 0x0026F6F5 File Offset: 0x0026D8F5
		[oO0oooo("3337")]
		public static void InlineMRPBuilder()
		{
			new o\u3002\u3000\u3000\u3000\u3002
			{
				Owner = Main.OO_O.o.
			}.ShowDialog();
		}

		/// <summary>
		/// 层级MRP统计
		/// </summary>
		// Token: 0x06005B32 RID: 23346 RVA: 0x0026F70D File Offset: 0x0026D90D
		[oO0oooo("3341")]
		public static void LayersMRPBuilder()
		{
			new di
			{
				Owner = Main.OO_O.o.
			}.ShowDialog();
		}

		/// <summary>
		/// 内联分组统计
		/// </summary>
		// Token: 0x06005B33 RID: 23347 RVA: 0x0026F725 File Offset: 0x0026D925
		[oO0oooo("3342")]
		public static void InlineGroupBuilder()
		{
			new h0
			{
				Owner = Main.OO_O.o.
			}.ShowDialog();
		}

		/// <summary>
		/// 层级分组统计
		/// </summary>
		// Token: 0x06005B34 RID: 23348 RVA: 0x0026F73D File Offset: 0x0026D93D
		[oO0oooo("3347")]
		public static void LayersGroupBuilder()
		{
			new ev
			{
				Owner = Main.OO_O.o.
			}.ShowDialog();
		}

		/// <summary>
		/// 设置折叠模式
		/// </summary>
		// Token: 0x06005B35 RID: 23349 RVA: 0x0026F758 File Offset: 0x0026D958
		[oO0oooo("3318")]
		public static void SetGridTree()
		{
			Table table = OO_00oOO.MainTable;
			if (table != null && new O\u30020\u3000\u3002(table)
			{
				Owner = Main.OO_O.o.
			}.ShowDialog() == DialogResult.OK)
			{
				table.NeedSaveSetting = true;
				table.oo0OO0Ooo._.(true);
			}
		}

		/// <summary>
		/// 关闭折叠模式
		/// </summary>
		// Token: 0x06005B36 RID: 23350 RVA: 0x0026F795 File Offset: 0x0026D995
		public static void CloseGridTree()
		{
			OO_00oOO.MainTable.CloseGridTree();
		}

		/// <summary>
		/// 根据最近一次设置，重新生成折叠模式
		/// </summary>
		// Token: 0x06005B37 RID: 23351 RVA: 0x0026F7A1 File Offset: 0x0026D9A1
		public static void ShowGridTree()
		{
			if (!OO_00oOO.MainTable.ShowGridTree())
			{
				Table.SetGridTree();
			}
		}

		/// <summary>
		/// 批量更新数据
		/// </summary>
		// Token: 0x06005B38 RID: 23352 RVA: 0x0026F7B4 File Offset: 0x0026D9B4
		[oO0oooo("3377")]
		public static void BatchUpdate()
		{
			new o\u3002\u3000\u3002\u3000O\u3002\u3000\u3002\u3000(false)
			{
				Owner = Main.OO_O.o.
			}.ShowDialog();
		}

		/// <summary>
		/// 批量复制数据
		/// </summary>
		// Token: 0x06005B39 RID: 23353 RVA: 0x0026F7CD File Offset: 0x0026D9CD
		[oO0oooo("3378")]
		public static void BatchCopy()
		{
			new o\u3002\u3000\u3002\u3000O\u3002\u3000\u3002\u3000(true)
			{
				Owner = Main.OO_O.o.
			}.ShowDialog();
		}
	}
}
