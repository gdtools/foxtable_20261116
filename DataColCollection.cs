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
	// Token: 0x020002A8 RID: 680
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	[oO0oooo("1428")]
	public class DataColCollection : IEnumerable<DataCol>
	{
		// Token: 0x0600234D RID: 9037 RVA: 0x000F8A18 File Offset: 0x000F6C18
		public DataColCollection(DataTable A_0)
		{
			this.O_0__o.o_0o. = new Dictionary<string, DataCol>();
			this.o.0OoOo. = A_0;
			try
			{
				foreach (object obj in this.o.0OoOo..Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (!o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName))
					{
						this.O_0__o.o_0o..Add(dataColumn.ColumnName, new DataCol(dataColumn));
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

		// Token: 0x0600234E RID: 9038 RVA: 0x000F8AB4 File Offset: 0x000F6CB4
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.O_0__o.o_0o..Remove(A_0);
			this.O_0__o.o_0o..Add(A_0, new DataCol(this.o.0OoOo..Columns[A_0]));
		}

		/// <summary>
		/// 返回列数
		/// </summary>
		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x000F8AE5 File Offset: 0x000F6CE5
		public int Count
		{
			get
			{
				return this.O_0__o.o_0o..Count;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x000F8AF4 File Offset: 0x000F6CF4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataCol Item
		{
			get
			{
				DataCol result;
				if (this.O_0__o.o_0o..ContainsKey(ColumnName))
				{
					result = this.O_0__o.o_0o.[ColumnName];
				}
				else
				{
					try
					{
						foreach (string text in this.O_0__o.o_0o..Keys)
						{
							if (Operators.CompareString(text, ColumnName, true) == 0)
							{
								return this.O_0__o.o_0o.[text];
							}
						}
					}
					finally
					{
						Dictionary<string, DataCol>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					MessageBox.Show(this.o.0OoOo..TableName + "不存在名为 \"" + ColumnName + "\"的列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					result = null;
				}
				return result;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x000F8BA8 File Offset: 0x000F6DA8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataCol Item
		{
			get
			{
				int num = 0;
				try
				{
					foreach (string key in this.O_0__o.o_0o..Keys)
					{
						if (num == idx)
						{
							return this.O_0__o.o_0o.[key];
						}
						num++;
					}
				}
				finally
				{
					Dictionary<string, DataCol>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				MessageBox.Show("列索引超出范围！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return null;
			}
		}

		// Token: 0x170007C6 RID: 1990
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataCol this[object A_0]
		{
			get
			{
				DataCol result;
				if (A_0 is string)
				{
					result = this.get_Item(A_0.ToString());
				}
				else
				{
					int idx = -1;
					if (int.TryParse(A_0.ToString(), out idx))
					{
						result = this.get_Item(idx);
					}
					else
					{
						result = this.get_Item(A_0.ToString());
					}
				}
				return result;
			}
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x000F8C78 File Offset: 0x000F6E78
		internal bool <<EMPTY_NAME>>(string A_0, string A_1)
		{
			try
			{
				this.o.0OoOo..Columns[A_0].ColumnName = A_1;
				DataCol value = this.O_0__o.o_0o.[A_0];
				this.O_0__o.o_0o..Remove(A_0);
				this.O_0__o.o_0o..Add(A_1, value);
			}
			catch (Exception ex)
			{
				MessageBox.Show("无法重命名列\"" + A_0 + "\"，原因：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			return true;
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x000F8D08 File Offset: 0x000F6F08
		internal bool <<EMPTY_NAME>>(string A_0)
		{
			try
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.View.o_o.O0ooOo.() == this.o.0OoOo.)
						{
							table.CloseRecordGrid();
							if (table.Cols.Contains(A_0))
							{
								table.Cols[A_0].CloseWindow();
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
				try
				{
					foreach (Table table2 in OO_00oOO.Tables)
					{
						if (table2.foxGrid.FindForm() != null && Operators.CompareString(table2.DataTable.Name, this.o.0OoOo..TableName, true) == 0)
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
				this.o.0OoOo..Columns.Remove(A_0);
				OO_00oOO.SystemReady = true;
				try
				{
					foreach (Table table3 in OO_00oOO.Tables)
					{
						if (table3.View.o_o.O0ooOo.() == this.o.0OoOo. && table3.Cols.Contains(A_0))
						{
							table3.Cols.Remove(A_0);
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
				this.O_0__o.o_0o..Remove(A_0);
				if (!O_O0OO.o0OoO00OO.00O.)
				{
					this.O_0__o.o_0o.();
				}
				try
				{
					foreach (Table table4 in OO_00oOO.Tables)
					{
						if (table4.foxGrid.FindForm() != null)
						{
							table4.O.__O0o0.(true, true);
							if (Operators.CompareString(table4.DataTable.Name, this.o.0OoOo..TableName, true) == 0)
							{
								table4._frdTableLayout.Oo_.oo_oOo_oO.();
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
			}
			catch (Exception ex)
			{
				MessageBox.Show("无法删除列\"" + A_0 + "\"，原因：" + ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			return true;
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x000F8F98 File Offset: 0x000F7198
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataCol Add(params object[] args)
		{
			string columnName = Conversions.ToString(args[0]);
			Type dataType = ooO.o.O_0000_O.(Conversions.ToString(args[1]));
			DataCol result;
			switch (args.Length)
			{
			case 2:
				result = this.Add(columnName, dataType);
				break;
			case 3:
				if (args[2] is string)
				{
					string expression = Conversions.ToString(args[2]);
					result = this.Add(columnName, dataType, expression);
				}
				else if (args[2] is int)
				{
					int maxLength = Conversions.ToInteger(args[2]);
					result = this.Add(columnName, dataType, maxLength);
				}
				break;
			case 4:
				if (args[2] is string && args[3] is string)
				{
					string expression2 = Conversions.ToString(args[2]);
					string caption = Conversions.ToString(args[3]);
					result = this.Add(columnName, dataType, expression2, caption);
				}
				else if (args[2] is int && args[3] is string)
				{
					int maxLength2 = Conversions.ToInteger(args[2]);
					string expression3 = Conversions.ToString(args[3]);
					result = this.Add(columnName, dataType, maxLength2, expression3);
				}
				break;
			case 5:
			{
				int maxLength3 = Conversions.ToInteger(args[2]);
				string expression4 = Conversions.ToString(args[3]);
				string caption2 = Conversions.ToString(args[4]);
				result = this.Add(columnName, dataType, maxLength3, expression4, caption2);
				break;
			}
			}
			return result;
		}

		/// <summary>
		/// 增加临时列
		/// </summary>
		/// <param name="ColumnName">列名</param>
		/// <param name="DataType">列类型</param>
		// Token: 0x06002356 RID: 9046 RVA: 0x000F90D2 File Offset: 0x000F72D2
		public DataCol Add(string ColumnName, Type DataType)
		{
			return this.Add(ColumnName, DataType, 32, "", "");
		}

		/// <summary>
		/// 增加临时列
		/// </summary>
		/// <param name="ColumnName">列名</param>
		/// <param name="DataType">列类型</param>
		/// <param name="Expression">表达式</param>
		// Token: 0x06002357 RID: 9047 RVA: 0x000F90E8 File Offset: 0x000F72E8
		public DataCol Add(string ColumnName, Type DataType, string Expression)
		{
			return this.Add(ColumnName, DataType, 32, Expression, "");
		}

		/// <summary>
		/// 增加临时列
		/// </summary>
		/// <param name="ColumnName">列名</param>
		/// <param name="DataType">类类型</param>
		/// <param name="Expression">表达式</param>
		/// <param name="Caption">列标题</param>
		// Token: 0x06002358 RID: 9048 RVA: 0x000F90FA File Offset: 0x000F72FA
		public DataCol Add(string ColumnName, Type DataType, string Expression, string Caption)
		{
			return this.Add(ColumnName, DataType, 32, Expression, Caption);
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x000F9109 File Offset: 0x000F7309
		public DataCol Add(string ColumnName, Type DataType, int MaxLength)
		{
			return this.Add(ColumnName, DataType, MaxLength, "", "");
		}

		/// <summary>
		/// 增加临时列
		/// </summary>
		/// <param name="ColumnName">列名</param>
		/// <param name="DataType">列类型</param>
		/// <param name="MaxLength">字符列的最大长度</param>
		/// <param name="Expression">表达式</param>
		/// <returns></returns>
		// Token: 0x0600235A RID: 9050 RVA: 0x000F911E File Offset: 0x000F731E
		public DataCol Add(string ColumnName, Type DataType, int MaxLength, string Expression)
		{
			return this.Add(ColumnName, DataType, MaxLength, Expression, "");
		}

		/// <summary>
		/// 增加临时列
		/// </summary>
		/// <param name="ColumnName">列名</param>
		/// <param name="DataType">数据类型</param>
		/// <param name="MaxLength">字符列的最大长度</param>
		/// <param name="Expression">表达式</param>
		/// <param name="Caption">列标题</param>
		/// <returns></returns>
		// Token: 0x0600235B RID: 9051 RVA: 0x000F9130 File Offset: 0x000F7330
		public DataCol Add(string ColumnName, Type DataType, int MaxLength, string Expression, string Caption)
		{
			DataCol result;
			if (Operators.CompareString(ColumnName, "", true) == 0 || this.Contains(ColumnName))
			{
				MessageBox.Show("列" + ColumnName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = null;
			}
			else
			{
				if (DataType != null)
				{
					try
					{
						DataColumn dataColumn = new DataColumn(ColumnName, DataType);
						if (DataType == typeof(bool))
						{
							dataColumn.DefaultValue = false;
						}
						this.o.0OoOo..Columns.Add(dataColumn);
						if (DataType == typeof(bool))
						{
							dataColumn.DefaultValue = null;
						}
						if (DataType == typeof(string))
						{
							dataColumn.MaxLength = MaxLength;
						}
						try
						{
							OO_00oOO.SystemReady = false;
							if (Operators.CompareString(Expression, "", true) > 0)
							{
								dataColumn.Expression = Expression;
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("无法设置列\"" + ColumnName + "\"的表达式，原因:" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							dataColumn.Expression = "";
						}
						finally
						{
							OO_00oOO.SystemReady = true;
						}
						this.O_0__o.o_0o..Add(ColumnName, new DataCol(dataColumn));
						if (Operators.CompareString(Caption, "", true) > 0)
						{
							this.O_0__o.o_0o.[ColumnName].Caption = Caption;
						}
						this.O_0__o.o_0o.[ColumnName].IsTemporary = true;
						if (!O_O0OO.o0OoO00OO.00O.)
						{
							this.O_0__o.o_0o.();
						}
						try
						{
							foreach (Table table in OO_00oOO.Tables)
							{
								if (table.DataTable.BaseTable == this.o.0OoOo. && (DataType == typeof(double) || DataType == typeof(decimal) || DataType == typeof(float)) && table.foxGrid.Cols.Contains(ColumnName))
								{
									table.foxGrid.Cols[ColumnName].Format = "#0.####";
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
						if (this.o.0OoOo..ChildRelations.Count > 0 || this.o.0OoOo..Rows.Count == 0)
						{
							try
							{
								foreach (Table table2 in OO_00oOO.Tables)
								{
									if (table2.DataTable.BaseTable == this.o.0OoOo. && !table2.foxGrid.Cols.Contains(ColumnName))
									{
										table2._frdTableLayout.OOooOOo_.0_0_o.();
										object objectValue = RuntimeHelpers.GetObjectValue(table2.foxGrid.DataSource);
										table2.foxGrid.SuspendLayout();
										table2.foxGrid.BeginUpdate();
										table2.foxGrid.DataSource = null;
										table2.foxGrid.DataSource = RuntimeHelpers.GetObjectValue(objectValue);
										table2._frdTableLayout.Oo_.oo_oOo_oO.();
										table2.foxGrid.ResumeLayout();
										table2.foxGrid.EndUpdate();
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
						}
						try
						{
							foreach (Table table3 in OO_00oOO.Tables)
							{
								if (table3.foxGrid.FindForm() != null)
								{
									table3.O.__O0o0.(true, true);
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
						return this.O_0__o.o_0o.[ColumnName];
					}
					catch (Exception ex2)
					{
						MessageBox.Show("无法增加列\"" + ColumnName + "\",原因:" + ex2.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x000F9550 File Offset: 0x000F7750
		private void <<EMPTY_NAME>>()
		{
			if (OO_00oOO.Tables != null && O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(this.o.0OoOo..TableName))
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
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
			}
		}

		/// <summary>
		/// 删除临时列
		/// </summary>
		/// <param name="ColumnName">列名</param>
		// Token: 0x0600235D RID: 9053 RVA: 0x000F95C0 File Offset: 0x000F77C0
		public void Delete(string ColumnName)
		{
			string text = "只能删除用代码增加的列，其余列请通过菜单删除！";
			if (!this.Contains(ColumnName))
			{
				MessageBox.Show("没有找到要删除的列\"" + ColumnName + "\"！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (this.o.0OoOo..DataSet != null && !this.O_0__o.o_0o.[ColumnName].IsTemporary)
			{
				MessageBox.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.Find(new object[]
			{
				this.o.0OoOo..TableName,
				ColumnName
			}) != null)
			{
				MessageBox.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			this.O_0__o.o_0o.(ColumnName);
		}

		/// <summary>
		/// 判断是否存在指定名称的列
		/// </summary>
		/// <param name="ColumnName">列名</param>
		// Token: 0x0600235E RID: 9054 RVA: 0x000F9680 File Offset: 0x000F7880
		public bool Contains(string ColumnName)
		{
			bool result;
			if (this.O_0__o.o_0o..ContainsKey(ColumnName))
			{
				result = true;
			}
			else
			{
				try
				{
					Dictionary<string, DataCol>.KeyCollection.Enumerator enumerator = this.O_0__o.o_0o..Keys.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(enumerator.Current, ColumnName, true) == 0)
						{
							return true;
						}
					}
				}
				finally
				{
					Dictionary<string, DataCol>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x000F96F4 File Offset: 0x000F78F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<DataCol> GetEnumerator()
		{
			return (IEnumerator<DataCol>)this.O_0__o.o_0o..Values.GetEnumerator();
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x000F9710 File Offset: 0x000F7910
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return (IEnumerator)this.O_0__o.o_0o..Values.GetEnumerator();
		}

		// Token: 0x04000EB0 RID: 3760
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000EB1 RID: 3761
		internal Dictionary<string, DataCol> <<EMPTY_NAME>>;
	}
}
