using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200031A RID: 794
	[ComVisible(true)]
	[oO0oooo("1438")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RowCollection : IEnumerable<Row>
	{
		// Token: 0x06002B20 RID: 11040 RVA: 0x00132FF8 File Offset: 0x001311F8
		internal RowCollection(Table A_0)
		{
			this.oo0Ooo.o_0__0_. = A_0;
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06002B21 RID: 11041 RVA: 0x00133007 File Offset: 0x00131207
		internal O_0 View
		{
			get
			{
				return this.oo0Ooo.o_0__0_..View;
			}
		}

		// Token: 0x170009A6 RID: 2470
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Row this[int Index]
		{
			get
			{
				return new Row(this.oo0Ooo.o_0__0_., this.View.O0O_0_0__.0O.(Index));
			}
		}

		// Token: 0x170009A7 RID: 2471
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Row this[int Index, bool IncludeGroup]
		{
			get
			{
				Row result;
				if (IncludeGroup)
				{
					result = new Row(this.oo0Ooo.o_0__0_., Index);
				}
				else
				{
					result = new Row(this.oo0Ooo.o_0__0_., this.View.O0O_0_0__.0O.(Index));
				}
				return result;
			}
		}

		/// <summary>
		/// 返回行数
		/// </summary>
		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x00133068 File Offset: 0x00131268
		public int Count
		{
			get
			{
				return this.oo0Ooo.o_0__0_..ooO__oo0O.0.(false);
			}
		}

		/// <summary>
		/// 返回行数
		/// </summary>
		/// <param name="IncludeGroup">是否包括汇总模式下的分组行</param>
		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x00133076 File Offset: 0x00131276
		public int Count
		{
			get
			{
				return this.oo0Ooo.o_0__0_..ooO__oo0O.0.(IncludeGroup);
			}
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x00133084 File Offset: 0x00131284
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<Row> GetEnumerator()
		{
			return new O_0o_0o_o0O_(this.oo0Ooo.o_0__0_.);
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x00133091 File Offset: 0x00131291
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return new O_0o_0o_o0O_(this.oo0Ooo.o_0__0_.);
		}

		/// <summary>
		/// 删除指定位置的行
		/// </summary>
		/// <param name="Index">行位置</param>
		// Token: 0x06002B28 RID: 11048 RVA: 0x0013309E File Offset: 0x0013129E
		public bool Delete(int Index)
		{
			return this[Index].Delete();
		}

		/// <summary>
		/// 在当前诶之插入行
		/// </summary>
		// Token: 0x06002B29 RID: 11049 RVA: 0x001330AC File Offset: 0x001312AC
		public Row InsertNew()
		{
			int topRow = this.oo0Ooo.o_0__0_..foxGrid.TopRow;
			if (this.oo0Ooo.o_0__0_..foxGrid.Editor != null)
			{
				this.oo0Ooo.o_0__0_..foxGrid.FinishEditing();
			}
			Row result;
			if (this.oo0Ooo.o_0__0_..foxGrid.Editor != null)
			{
				result = null;
			}
			else if (!this.oo0Ooo.o_0__0_..O.00O0.())
			{
				result = null;
			}
			else if (!this.oo0Ooo.o_0__0_.())
			{
				result = null;
			}
			else if (!this.oo0Ooo.o_0__0_..View.o_o.O0ooOo.().Columns.Contains("_SortKey"))
			{
				MessageBox.Show("此表不支持插入行功能！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = null;
			}
			else if (Operators.CompareString(this.oo0Ooo.o_0__0_..View.oO_O.o_OOO.(), "", true) > 0)
			{
				MessageBox.Show("不能在排序状态下插入行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = null;
			}
			else
			{
				this.oo0Ooo.o_0__0_..StopRedraw();
				decimal num;
				if (this.oo0Ooo.o_0__0_..Position < 0)
				{
					num = 1m;
				}
				else if (this.oo0Ooo.o_0__0_..Position == 0)
				{
					num = decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.(0)["_SortKey"])), 1m);
				}
				else
				{
					int num2;
					for (int i = this.View.Position; i < this.View.Count; i++)
					{
						num2 = i;
						if (this.View.O0O_0_0__.0O.(i).Row.RowState != DataRowState.Added)
						{
							break;
						}
					}
					int num3;
					for (int i = this.View.Position - 1; i >= 0; i--)
					{
						num3 = i;
						if (this.View.O0O_0_0__.0O.(i).Row.RowState != DataRowState.Added)
						{
							break;
						}
					}
					if (num3 == num2)
					{
						num = decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.View.o_o.O0ooOo.()["_SortKey"])), 1m);
					}
					else
					{
						if (this.View.O0O_0_0__.0O.(num3).Row.RowState == DataRowState.Added && this.View.O0O_0_0__.0O.(num2).Row.RowState == DataRowState.Added)
						{
							decimal num4 = decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.(num2)["_SortKey"])), 1m);
							if (this.View.Position == num2)
							{
								num = num4;
								num4 = decimal.Subtract(num4, 1m);
							}
							Dictionary<DataRow, decimal> dictionary = new Dictionary<DataRow, decimal>();
							int num5 = num2 - 1;
							int num6 = num3;
							for (int j = num5; j >= num6; j += -1)
							{
								dictionary.Add(this.View.O0O_0_0__.0O.(j).Row, num4);
								if (j == this.View.Position)
								{
									num = decimal.Subtract(num4, 1m);
									num4 = decimal.Subtract(num4, 2m);
								}
								else
								{
									num4 = decimal.Subtract(num4, 1m);
								}
							}
							try
							{
								foreach (DataRow dataRow in dictionary.Keys)
								{
									dataRow["_SortKey"] = dictionary[dataRow];
								}
								goto IL_65C;
							}
							finally
							{
								Dictionary<DataRow, decimal>.KeyCollection.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						if (this.View.O0O_0_0__.0O.(num3).Row.RowState == DataRowState.Added)
						{
							decimal num7 = decimal.Subtract(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.(num2)["_SortKey"])), 1m);
							if (this.View.Position == num2)
							{
								num = num7;
								num7 = decimal.Subtract(num7, 1m);
							}
							int num8 = num2 - 1;
							int num9 = num3;
							for (int k = num8; k >= num9; k += -1)
							{
								if (k == this.View.Position)
								{
									num = num7;
									this.View.O0O_0_0__.0O.(k)["_SortKey"] = decimal.Subtract(num7, 1m);
									num7 = decimal.Subtract(num7, 2m);
								}
								else
								{
									this.View.O0O_0_0__.0O.(k)["_SortKey"] = num7;
									num7 = decimal.Subtract(num7, 1m);
								}
							}
						}
						else if (this.View.O0O_0_0__.0O.(num2).Row.RowState == DataRowState.Added)
						{
							decimal num10 = decimal.Add(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.(num3)["_SortKey"])), 1m);
							int num11 = num3 + 1;
							int num12 = num2;
							for (int l = num11; l <= num12; l++)
							{
								if (l == this.View.Position)
								{
									num = num10;
									this.View.O0O_0_0__.0O.(l)["_SortKey"] = decimal.Add(num10, 1m);
									num10 = decimal.Add(num10, 2m);
								}
								else
								{
									this.View.O0O_0_0__.0O.(l)["_SortKey"] = num10;
									num10 = decimal.Add(num10, 1m);
								}
							}
						}
						else
						{
							decimal num13 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.(num3)["_SortKey"]));
							decimal d = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.(num2)["_SortKey"]));
							int num14 = num2 - num3 + 1;
							decimal num15 = Math.Round(decimal.Divide(decimal.Subtract(d, num13), new decimal(num14)), 14);
							decimal num16 = decimal.Add(num13, num15);
							if (num14 == 2)
							{
								num = num16;
							}
							else
							{
								if (this.View.Position == num2)
								{
									num = decimal.Add(num13, decimal.Multiply(num15, new decimal(num14 - 1)));
								}
								int num17 = num3 + 1;
								int num18 = num2 - 1;
								for (int m = num17; m <= num18; m++)
								{
									if (m == this.View.Position)
									{
										num = num16;
										this.View.O0O_0_0__.0O.(m)["_SortKey"] = decimal.Add(num16, num15);
										num16 = decimal.Add(decimal.Add(num16, num15), num15);
									}
									else
									{
										this.View.O0O_0_0__.0O.(m)["_SortKey"] = num16;
										num16 = decimal.Add(num16, num15);
									}
								}
							}
						}
					}
				}
				IL_65C:
				DataRow dataRow2 = this.oo0Ooo.o_0__0_..DataTable.BaseTable.NewRow();
				if (this.oo0Ooo.o_0__0_..IsChild)
				{
					DataRelation dataRelation = this.oo0Ooo.o_0__0_..View.O0O_0_0__.0O.();
					int num19 = dataRelation.ChildColumns.Length - 1;
					for (int n = 0; n <= num19; n++)
					{
						dataRow2[dataRelation.ChildColumns[n].ColumnName] = RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row[dataRelation.ParentColumns[n].ColumnName]);
					}
				}
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable.BaseTable == this.oo0Ooo.o_0__0_..DataTable.BaseTable)
						{
							table.View.SuspendBinding();
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
				dataRow2["_SortKey"] = num;
				this.oo0Ooo.o_0__0_..DataTable.BaseTable.Rows.Add(dataRow2);
				try
				{
					foreach (Table table2 in OO_00oOO.Tables)
					{
						if (table2.DataTable.BaseTable == this.oo0Ooo.o_0__0_..DataTable.BaseTable)
						{
							table2.View.ResumeBinding();
							table2.ResetCurrentItem();
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
				this.oo0Ooo.o_0__0_..Position = this.oo0Ooo.o_0__0_..FindRow(new DataRow(dataRow2));
				this.oo0Ooo.o_0__0_..foxGrid.TopRow = topRow;
				this.oo0Ooo.o_0__0_..ResumeRedraw();
				result = this.oo0Ooo.o_0__0_..Current;
			}
			return result;
		}

		/// <summary>
		/// 增加行
		/// </summary>
		/// <param name="行数">要增加好的行数</param>
		/// <returns></returns>
		// Token: 0x06002B2A RID: 11050 RVA: 0x001338FC File Offset: 0x00131AFC
		public Row AddNew(int count = 1)
		{
			if (this.oo0Ooo.o_0__0_..foxGrid.Editor != null)
			{
				this.oo0Ooo.o_0__0_..foxGrid.FinishEditing();
			}
			Row result;
			if (this.oo0Ooo.o_0__0_..foxGrid.Editor != null)
			{
				result = null;
			}
			else if (!this.oo0Ooo.o_0__0_..O.00O0.())
			{
				result = null;
			}
			else if (!this.oo0Ooo.o_0__0_.())
			{
				result = null;
			}
			else
			{
				string tableName = this.oo0Ooo.o_0__0_..View.o_o.O0ooOo.().TableName;
				DataRow dataRow = null;
				try
				{
					if (count > 5)
					{
						this.oo0Ooo.o_0__0_..foxGrid.BeginUpdate();
					}
					for (int i = 1; i <= count; i++)
					{
						DataRow dataRow2 = this.oo0Ooo.o_0__0_.();
						if (dataRow2 == null)
						{
							return null;
						}
						if (i == 1)
						{
							dataRow = dataRow2;
						}
						if (dataRow2.RowState == DataRowState.Detached)
						{
							break;
						}
						dataRow2.EndEdit();
					}
					if (dataRow.RowState != DataRowState.Detached)
					{
						this.View.Position = this.View.Count - count;
						if (this.View.o_o.O0ooOo.() != null && this.View.o_o.O0ooOo.().Row != dataRow)
						{
							this.View.Position = this.View.o_o.O0ooOo.(dataRow);
						}
					}
					if (this.oo0Ooo.o_0__0_..foxGrid.Row <= this.oo0Ooo.o_0__0_..foxGrid.Rows.Fixed && this.View.o_o.O0ooOo.() != null)
					{
						this.oo0Ooo.o_0__0_..foxGrid.Row = this.oo0Ooo.o_0__0_..foxGrid.Rows.Fixed;
						this.oo0Ooo.o_0__0_..View.o_._0O0o_OoO.();
						this.oo0Ooo.o_0__0_..View.Oo._Oo0OO.();
					}
					if (this.View.o_o.O0ooOo.() != null && this.View.o_o.O0ooOo.().Row == dataRow)
					{
						int position = this.View.Position;
						if (this.oo0Ooo.o_0__0_..GrandTotal && this.View.Count == 1 && this.oo0Ooo.o_0__0_..Grid.Row == this.oo0Ooo.o_0__0_..Grid.Rows.Count - 1)
						{
							this.oo0Ooo.o_0__0_..Grid.Row = this.oo0Ooo.o_0__0_..Grid.Rows.Fixed;
						}
						return new Row(this.oo0Ooo.o_0__0_., this.View.o_o.O0ooOo.());
					}
					if (dataRow != null)
					{
						return new Row(this.oo0Ooo.o_0__0_., dataRow);
					}
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
				finally
				{
					if (count > 5)
					{
						this.oo0Ooo.o_0__0_..foxGrid.EndUpdate();
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x00133BD0 File Offset: 0x00131DD0
		private bool <<EMPTY_NAME>>()
		{
			DataRowEventArgs dataRowEventArgs = new DataRowEventArgs(OO_00oOO.DataTables[this.View.o_o.O0ooOo.().TableName], null);
			string a_ = "BeforeAddDataRow";
			O_O0OO.OoO_o.oO0o0O.(OO_00oOO.DataTables[this.View.o_o.O0ooOo.().TableName].o_0_00_.oo0O0., a_, new object[]
			{
				dataRowEventArgs
			}, false, this.oo0Ooo.o_0__0_..DataTable.Name, false);
			if (!dataRowEventArgs.Cancel && this.oo0Ooo.o_0__0_..DataTable.GlobalHandler.BeforeAddDataRow)
			{
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					dataRowEventArgs
				}, false, "全局表事件", false);
			}
			return !dataRowEventArgs.Cancel;
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x00133C8C File Offset: 0x00131E8C
		private DataRow <<EMPTY_NAME>>()
		{
			string tableName = this.oo0Ooo.o_0__0_..View.o_o.O0ooOo.().TableName;
			DataRow result;
			try
			{
				if (OO_00oOO.DataTables[tableName].BaseTable.PrimaryKey.Length > 0 && !OO_00oOO.DataTables[tableName].frd_AutoIncrement)
				{
					DataRowView dataRowView = (DataRowView)this.oo0Ooo.o_0__0_..View.AddNew();
					if (dataRowView.IsEdit && dataRowView.Row.Table.PrimaryKey.Length == 1 && !dataRowView.Row.IsNull(dataRowView.Row.Table.PrimaryKey[0]))
					{
						dataRowView.EndEdit();
					}
					result = dataRowView.Row;
				}
				else
				{
					DataRow dataRow = this.oo0Ooo.o_0__0_..View.o_o.O0ooOo.().NewRow();
					if (this.oo0Ooo.o_0__0_..IsChild)
					{
						DataRelation dataRelation = this.oo0Ooo.o_0__0_..View.O0O_0_0__.0O.();
						int num = dataRelation.ChildColumns.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							dataRow[dataRelation.ChildColumns[i].ColumnName] = RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row[dataRelation.ParentColumns[i].ColumnName]);
						}
					}
					this.oo0Ooo.o_0__0_..View.o_o.O0ooOo.().Rows.Add(dataRow);
					result = dataRow;
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
				result = null;
			}
			return result;
		}

		/// <summary>
		/// 移除指定位置的行
		/// </summary>
		/// <param name="Index">行位置</param>
		// Token: 0x06002B2D RID: 11053 RVA: 0x00133E30 File Offset: 0x00132030
		public void Remove(int Index)
		{
			this[Index].Remove();
		}

		// Token: 0x040011AD RID: 4525
		private Table <<EMPTY_NAME>>;
	}
}
