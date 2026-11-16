using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Foxtable.RibbonMenu;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.Syscmd
{
	/// <summary>
	/// 与行相关的系统命令
	/// </summary>
	// Token: 0x02000544 RID: 1348
	[StandardModule]
	public sealed class Row
	{
		/// <summary>
		/// 增加一行
		/// </summary>
		// Token: 0x06005AD5 RID: 23253 RVA: 0x0026C08C File Offset: 0x0026A28C
		[oO0oooo("0109")]
		public static void AddNew()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null && (table.GridTreeVisible || table.foxGrid.OO.o_o00o.()))
			{
				GridTree.AddSlibing();
				return;
			}
			Row.AddNews(1);
		}

		/// <summary>
		/// 增加多行
		/// </summary>
		/// <param name="Rows">要增加行的行数，如果省略，会出现一个窗口用于输入行数</param>
		// Token: 0x06005AD6 RID: 23254 RVA: 0x0026C0C4 File Offset: 0x0026A2C4
		[oO0oooo("0109")]
		public static void AddNews(int Rows = -1)
		{
			if (OO_00oOO.CurrentTable != null && Row.OO.OO_0o.() && !OO_00oOO.CurrentTable.GridTreeVisible && !OO_00oOO.CurrentTable.foxGrid.OO.o_o00o.())
			{
				if (Rows == -1)
				{
					O\u3002\u3000\u3002 o_u3002_u3000_u = new O\u3002\u3000\u3002("新增行", "请输入行数:", 5, 1, 300, "每次最多允许增加300行！");
					if (o_u3002_u3000_u.ShowDialog() == DialogResult.Cancel)
					{
						return;
					}
					Rows = o_u3002_u3000_u.Value;
				}
				if (Rows >= 1)
				{
					try
					{
						DataTable dataTable = OO_00oOO.CurrentTable.View.o_o.O0ooOo.();
						int count = OO_00oOO.CurrentTable.View.Count;
						if (dataTable.Rows.Count > 0)
						{
							DataRow dataRow = dataTable.Rows[dataTable.Rows.Count - 1];
						}
						OO_00oOO.CurrentTable.Rows.AddNew(Rows);
						if (OO_00oOO.CurrentTable.View.Count > count)
						{
							OO_00oOO.CurrentTable.ClearEditInfos();
						}
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
					}
				}
			}
		}

		/// <summary>
		/// 克隆行
		/// </summary>
		// Token: 0x06005AD7 RID: 23255 RVA: 0x0026C1E8 File Offset: 0x0026A3E8
		[oO0oooo("1792")]
		public static void Clone()
		{
			if (OO_00oOO.CurrentTable != null && Row.OO.OO_0o.())
			{
				if (OO_00oOO.CurrentTable.GridTreeVisible || OO_00oOO.CurrentTable.foxGrid.OO.o_o00o.())
				{
					GridTree.Clone();
					return;
				}
				if (OO_00oOO.CurrentTable != null && OO_00oOO.CurrentTable.Current != null)
				{
					DataTable dataTable = OO_00oOO.CurrentTable.View.o_o.O0ooOo.();
					int count = dataTable.Rows.Count;
					if (count > 0)
					{
						DataRow dataRow = dataTable.Rows[dataTable.Rows.Count - 1];
					}
					OO_00oOO.CurrentTable.Current.Clone();
					if (dataTable.Rows.Count > count)
					{
						OO_00oOO.CurrentTable.O_o0OOo_.o0..Clear();
						if (OO_00oOO.CurrentTable.foxGrid.Row <= OO_00oOO.CurrentTable.foxGrid.Rows.Fixed)
						{
							OO_00oOO.CurrentTable.foxGrid.Row = OO_00oOO.CurrentTable.foxGrid.Rows.Fixed;
						}
					}
				}
			}
		}

		/// <summary>
		/// 插入行
		/// </summary>
		// Token: 0x06005AD8 RID: 23256 RVA: 0x0026C2F8 File Offset: 0x0026A4F8
		[oO0oooo("1791")]
		public static void Insert()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null && (table.GridTreeVisible || table.foxGrid.OO.o_o00o.()))
			{
				GridTree.InsertSlibing();
				return;
			}
			if (Row.OO.OO_0o.() && OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.Rows.InsertNew();
			}
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x0026C348 File Offset: 0x0026A548
		internal static bool <<EMPTY_NAME>>()
		{
			bool result;
			if (!OO_00oOO.CurrentTable.AllowEdit)
			{
				result = false;
			}
			else if (OO_00oOO.CurrentTable.View.o_o.O0ooOo.() != null && OO_00oOO.CurrentTable.View.o_o.O0ooOo.().Row.RowState == DataRowState.Detached)
			{
				MessageBox.Show("在当前行输入主键值之前，不能增加新行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (OO_00oOO.CurrentTable.IsSubtotal)
			{
				MessageBox.Show("不能在汇总模式下增加行，请先退出汇总模式！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (!OO_00oOO.CurrentTable.AllowAddNew)
			{
				MessageBox.Show("增加行失败，Table\"" + OO_00oOO.CurrentTable.Name + "\"的AllowAddNew属性为False！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		/// <summary>
		/// 删除行
		/// </summary>
		// Token: 0x06005ADA RID: 23258 RVA: 0x0026C40C File Offset: 0x0026A60C
		[oO0oooo("0110")]
		public static void Delete()
		{
			if (OO_00oOO.CurrentTable.Position >= 0 && OO_00oOO.CurrentTable.AllowEdit)
			{
				if (OO_00oOO.CurrentTable.IsSubtotal)
				{
					MessageBox.Show("不能在汇总模式下删除行，请先退出汇总模式！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (!OO_00oOO.CurrentTable.DataTable.DeleteRowPrompt || MessageBox.Show("是否要删除选定行？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
				{
					if (!OO_00oOO.CurrentTable.AllowDelete)
					{
						MessageBox.Show("删除行失败，Table\"" + OO_00oOO.CurrentTable.Name + "\"的AllowDelete属性为False！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					if (OO_00oOO.CurrentTable.GridTreeVisible)
					{
						O_oOooO_O o_oOooO_O = OO_00oOO.CurrentTable.foxGrid;
						int topRow = o_oOooO_O.Selection.TopRow;
						int bottomRow = o_oOooO_O.Selection.BottomRow;
						int i = topRow;
						while (i <= bottomRow)
						{
							if (!o_oOooO_O.Rows[i].Visible)
							{
								if (MessageBox.Show("选定区域含有不可见的折叠行，是否继续执行删除行操作?", "确定", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
								{
									return;
								}
								break;
							}
							else
							{
								i++;
							}
						}
					}
					List<OoO_O00> list = new List<OoO_O00>();
					OO_00oOO.CurrentTable.ClearEditInfos();
					Foxtable.RibbonMenu.StatusBar.Message1 = "正在删除记录...";
					Application.DoEvents();
					List<DataTable> list2 = new List<DataTable>();
					try
					{
						OO_00oOO.LockBaseMainForm();
						List<DataRow> list3 = new List<DataRow>();
						list2.Add(OO_00oOO.CurrentTable.DataTable.BaseTable);
						Row.OO.OO_0o.(list2, OO_00oOO.CurrentTable.DataTable.BaseTable);
						int topRow2 = OO_00oOO.CurrentTable.foxGrid.Selection.TopRow;
						int bottomRow2 = OO_00oOO.CurrentTable.foxGrid.Selection.BottomRow;
						OO_00oOO.CurrentTable.foxGrid;
						int num = topRow2;
						for (int j = bottomRow2; j >= num; j += -1)
						{
							int dataIndex = OO_00oOO.CurrentTable.foxGrid.Rows[j].DataIndex;
							if (dataIndex >= 0)
							{
								list3.Add(OO_00oOO.CurrentTable.View.O0O_0_0__.0O.(dataIndex).Row);
							}
						}
						if (list3.Count > 1)
						{
							if (OO_00oOO.CurrentTable.GridTreeVisible)
							{
								try
								{
									foreach (DataTable dataTable in list2)
									{
										OO_00oOO.DataTables[dataTable.TableName].IsDeletingRows = true;
									}
									goto IL_2CF;
								}
								finally
								{
									List<DataTable>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
							}
							try
							{
								foreach (DataTable dataTable2 in list2)
								{
									try
									{
										foreach (Table table in OO_00oOO.Tables)
										{
											if (table.View.o_o.O0ooOo.() == dataTable2)
											{
												list.Add(new OoO_O00(table));
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
								}
							}
							finally
							{
								List<DataTable>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
						}
						IL_2CF:
						try
						{
							foreach (DataRow a_ in list3)
							{
								if (!new DataRow(a_).oo.o0oOoooo.())
								{
									break;
								}
							}
						}
						finally
						{
							List<DataRow>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
					catch (Exception a_2)
					{
						ooO.oOo0Oo.o.(a_2, "");
					}
					finally
					{
						Foxtable.RibbonMenu.StatusBar.Message1 = "";
						try
						{
							foreach (OoO_O00 ooO_O in list)
							{
								ooO_O.O._00000.(null);
							}
						}
						finally
						{
							List<OoO_O00>.Enumerator enumerator5;
							((IDisposable)enumerator5).Dispose();
						}
						try
						{
							foreach (DataTable dataTable3 in list2)
							{
								if (OO_00oOO.DataTables[dataTable3.TableName].IsDeletingRows)
								{
									OO_00oOO.DataTables[dataTable3.TableName].IsDeletingRows = false;
									try
									{
										foreach (Table table2 in OO_00oOO.Tables)
										{
											if (table2.View.o_o.O0ooOo.() == dataTable3)
											{
												table2.RaiseCurrentChanged();
												table2.RaisePositionChanged();
											}
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
							}
						}
						finally
						{
							List<DataTable>.Enumerator enumerator6;
							((IDisposable)enumerator6).Dispose();
						}
						OO_00oOO.UnlockBaseMainForm();
					}
				}
			}
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x0026C914 File Offset: 0x0026AB14
		internal static void <<EMPTY_NAME>>(List<DataTable> A_0, DataTable A_1)
		{
			try
			{
				foreach (object obj in A_1.ChildRelations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (!A_0.Contains(dataRelation.ChildTable))
					{
						A_0.Add(dataRelation.ChildTable);
						Row.OO.OO_0o.(A_0, dataRelation.ChildTable);
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

		/// <summary>
		/// 锁定行
		/// </summary>
		// Token: 0x06005ADC RID: 23260 RVA: 0x0026C990 File Offset: 0x0026AB90
		[oO0oooo("0111")]
		public static void Lock()
		{
			if (OO_00oOO.CurrentTable.AllowEdit && OO_00oOO.CurrentTable.Position >= 0)
			{
				if (!OO_00oOO.CurrentTable.AllowLockRow)
				{
					MessageBox.Show("锁定行失败，Table\"" + OO_00oOO.CurrentTable.Name + "\"的AllowLockRow属性为False！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				int num = Math.Min(OO_00oOO.CurrentTable.foxGrid.Row, OO_00oOO.CurrentTable.foxGrid.RowSel);
				int num2 = Math.Max(OO_00oOO.CurrentTable.foxGrid.Row, OO_00oOO.CurrentTable.foxGrid.RowSel);
				oo___ooo oo___ooo = new oo___ooo();
				int num3 = num2;
				for (int i = num; i <= num3; i++)
				{
					int dataIndex = OO_00oOO.CurrentTable.foxGrid.Rows[i].DataIndex;
					if (dataIndex >= 0)
					{
						Row row = OO_00oOO.CurrentTable.Rows[dataIndex];
						if (row.DataRow != null)
						{
							if (!row.Locked)
							{
								oo___ooo.o00.oo0__00.(row.DataRow.BaseRow);
								row.Locked = true;
								Oo00.o0_o._O_.(row.DataRow.BaseRow);
							}
						}
					}
				}
				if (oo___ooo.o00.oo0__00.() > 0)
				{
					OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(oo___ooo);
				}
			}
		}

		/// <summary>
		/// 取消锁定行
		/// </summary>
		// Token: 0x06005ADD RID: 23261 RVA: 0x0026CADC File Offset: 0x0026ACDC
		[oO0oooo("0111")]
		public static void UnLock()
		{
			if (OO_00oOO.CurrentTable.Position >= 0 && OO_00oOO.CurrentTable.AllowEdit)
			{
				if (!OO_00oOO.CurrentTable.AllowUnLockRow)
				{
					MessageBox.Show("取消锁定行失败，Table\"" + OO_00oOO.CurrentTable.Name + "\"的AllowUnlockRow属性为False！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				int num = Math.Min(OO_00oOO.CurrentTable.foxGrid.Row, OO_00oOO.CurrentTable.foxGrid.RowSel);
				int num2 = Math.Max(OO_00oOO.CurrentTable.foxGrid.Row, OO_00oOO.CurrentTable.foxGrid.RowSel);
				oo___ooo oo___ooo = new oo___ooo();
				int num3 = num2;
				for (int i = num; i <= num3; i++)
				{
					int dataIndex = OO_00oOO.CurrentTable.foxGrid.Rows[i].DataIndex;
					if (dataIndex >= 0)
					{
						Row row = OO_00oOO.CurrentTable.Rows[dataIndex];
						if (row.DataRow != null)
						{
							if (row.Locked)
							{
								oo___ooo.o00.oo0__00.(row.DataRow.BaseRow);
								row.Locked = false;
								Oo00.o0_o._O_.(row.DataRow.BaseRow);
							}
						}
					}
				}
				if (oo___ooo.o00.oo0__00.() > 0)
				{
					OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(oo___ooo);
				}
			}
		}

		/// <summary>
		/// 设置行高
		/// </summary>
		// Token: 0x06005ADE RID: 23262 RVA: 0x0026CC25 File Offset: 0x0026AE25
		[oO0oooo("0114")]
		public static void Height()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				new O\u3000_\u3000(OO_00oOO.CurrentTable).ShowDialog();
			}
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x0026CC3E File Offset: 0x0026AE3E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void Refresh()
		{
			Row.Load();
		}

		/// <summary>
		/// 同步行
		/// </summary>
		// Token: 0x06005AE0 RID: 23264 RVA: 0x0026CC48 File Offset: 0x0026AE48
		[oO0oooo("0115")]
		public static void Load()
		{
			if (!OO_00oOO.CurrentTable.DataTable.frd_IsTemporary && OO_00oOO.CurrentTable.foxGrid.Selection.TopRow >= 0)
			{
				List<DataRow> list = new List<DataRow>();
				int topRow = OO_00oOO.CurrentTable.foxGrid.Selection.TopRow;
				int bottomRow = OO_00oOO.CurrentTable.foxGrid.Selection.BottomRow;
				for (int i = topRow; i <= bottomRow; i++)
				{
					if (OO_00oOO.CurrentTable.foxGrid.Rows[i].DataIndex >= 0)
					{
						list.Add(new DataRow(OO_00oOO.CurrentTable.View.O0O_0_0__.0O.(OO_00oOO.CurrentTable.foxGrid.Rows[i].DataIndex).Row));
					}
				}
				if (Operators.CompareString(OO_00oOO.CurrentTable.DataTable.DataServer, "", true) == 0)
				{
					ConnectionState state = OO_00oOO.CurrentTable.DataTable.frd_Connection.State;
					try
					{
						if (state != ConnectionState.Open)
						{
							OO_00oOO.CurrentTable.DataTable.frd_Connection.Open();
						}
						try
						{
							foreach (DataRow dataRow in list)
							{
								if (dataRow.RowState != DataRowState.Added)
								{
									dataRow.Load(true);
								}
							}
						}
						finally
						{
							List<DataRow>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						return;
					}
					catch (Exception ex)
					{
						return;
					}
					finally
					{
						if (state != ConnectionState.Open)
						{
							OO_00oOO.CurrentTable.DataTable.frd_Connection.Close();
						}
					}
				}
				Row row = OO_00oOO.CurrentTable.Current;
				if (row != null)
				{
					row.Load(true);
				}
			}
		}

		/// <summary>
		/// 隐藏未选定航
		/// </summary>
		// Token: 0x06005AE1 RID: 23265 RVA: 0x0026CE14 File Offset: 0x0026B014
		[oO0oooo("1543")]
		public static void HideUnSelectedRows()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.o.O0___OOo0_oO.(1);
			}
		}

		/// <summary>
		/// 隐藏选定行
		/// </summary>
		// Token: 0x06005AE2 RID: 23266 RVA: 0x0026CE28 File Offset: 0x0026B028
		[oO0oooo("1543")]
		public static void HideSelectedRows()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.o.O0___OOo0_oO.(0);
			}
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x0026CE3C File Offset: 0x0026B03C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ShowHideRows()
		{
		}

		/// <summary>
		/// 上移行
		/// </summary>
		// Token: 0x06005AE4 RID: 23268 RVA: 0x0026CE40 File Offset: 0x0026B040
		public static void MoveUp()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				if (table.GridTreeVisible || table.foxGrid.OO.o_o00o.())
				{
					GridTree.MoveUp();
					return;
				}
				try
				{
					Table table2 = table;
					table2.StopRedraw();
					CellRange selection = table2.foxGrid.Selection;
					if (selection.TopRow != -1 && selection.BottomRow != -1)
					{
						if (table2.TopPosition == table2.BottomPosition)
						{
							if (!table2.Current.Move(table2.Position - 1))
							{
								return;
							}
						}
						else if (table2.TopPosition <= 0 || !table2.Rows[table2.TopPosition - 1].Move(table2.BottomPosition))
						{
							return;
						}
						table2.foxGrid.Select(selection.r1 - 1, selection.c1, selection.r2 - 1, selection.c2);
						table2.ClearEditInfos();
					}
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
				finally
				{
					table.ResumeRedraw();
				}
			}
		}

		/// <summary>
		/// 下移行
		/// </summary>
		// Token: 0x06005AE5 RID: 23269 RVA: 0x0026CF68 File Offset: 0x0026B168
		public static void MoveDown()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				if (table.GridTreeVisible || table.foxGrid.OO.o_o00o.())
				{
					GridTree.MoveDown();
					return;
				}
				try
				{
					Table table2 = table;
					table2.StopRedraw();
					CellRange selection = table2.foxGrid.Selection;
					if (selection.TopRow != -1 && selection.BottomRow != -1)
					{
						if (table2.TopPosition == table2.BottomPosition)
						{
							if (!table2.Current.Move(table2.Position + 1))
							{
								return;
							}
						}
						else if (table2.BottomPosition >= table2.ooO__oo0O.0.(false) - 1 || !table2.Rows[table2.BottomPosition + 1].Move(table2.TopPosition))
						{
							return;
						}
						table2.foxGrid.Select(selection.r1 + 1, selection.c1, selection.r2 + 1, selection.c2);
						table2.ClearEditInfos();
					}
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
				finally
				{
					table.ResumeRedraw();
				}
			}
		}
	}
}
