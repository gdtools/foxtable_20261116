using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002AA RID: 682
	[oO0oooo("0419")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class DataRowCollection : IEnumerable<DataRow>
	{
		// Token: 0x06002391 RID: 9105 RVA: 0x000FD4C4 File Offset: 0x000FB6C4
		public DataRowCollection(DataTable A_0)
		{
			lock (A_0)
			{
				this._Rows = A_0.Select("", "", DataViewRowState.CurrentRows);
				this._DataTable = A_0;
			}
		}

		/// <summary>
		/// 返回行数
		/// </summary>
		/// <returns></returns>
		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x000FD520 File Offset: 0x000FB720
		public int Count
		{
			get
			{
				return this._Rows.Length;
			}
		}

		/// <summary>
		/// 清除数据，即刻生效，且不能撤销，慎重使用
		/// </summary>
		/// <param name="ReLoad">清除数据之后，是否刷新数据</param>
		// Token: 0x06002393 RID: 9107 RVA: 0x000FD52C File Offset: 0x000FB72C
		public void Clear(bool ReLoad = true)
		{
			DataTable dataTable = OO_00oOO.DataTables[this._DataTable.TableName];
			if (dataTable.frd_IsTemporary)
			{
				this._DataTable.Rows.Clear();
				object dataTable2 = this._DataTable;
				lock (dataTable2)
				{
					this._Rows = this._DataTable.Select("", "", DataViewRowState.CurrentRows);
					goto IL_31E;
				}
			}
			if (dataTable.frd_IsInnerTable || dataTable.frd_IsOuterTable)
			{
				if (dataTable.frd_Connection != null)
				{
					OleDbCommand oleDbCommand = new OleDbCommand();
					string commandText;
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(dataTable.frd_Connection))
					{
						commandText = "Delete From " + dataTable.o._OOO0oOo0__.;
					}
					else
					{
						commandText = "Delete From [" + dataTable.o._OOO0oOo0__..Trim(new char[]
						{
							'[',
							']'
						}) + "]";
					}
					oleDbCommand.Connection = dataTable.frd_Connection;
					oleDbCommand.CommandText = commandText;
					if (Operators.CompareString(dataTable.LoadFilter, "", true) > 0)
					{
						oleDbCommand.CommandText = oleDbCommand.CommandText + " Where " + dataTable.LoadFilter;
					}
					ConnectionState state = dataTable.frd_Connection.State;
					try
					{
						dataTable.frd_Connection.Open();
						oleDbCommand.ExecuteNonQuery();
						if (dataTable.frd_IsInnerTable)
						{
							oleDbCommand.CommandText = string.Concat(new string[]
							{
								"Delete * From [",
								ooO0__OO.O00.O__o.(),
								"] Where [Table]  = '",
								dataTable.o._OOO0oOo0__.,
								"'"
							});
							oleDbCommand.ExecuteNonQuery();
							oleDbCommand.CommandText = string.Concat(new string[]
							{
								"Insert into [",
								ooO0__OO.O00.O__o.(),
								"] ([Table],[Identify]) values ('",
								dataTable.o._OOO0oOo0__.,
								"', 1)"
							});
							oleDbCommand.ExecuteNonQuery();
						}
						if (ReLoad)
						{
							this._DataTable.Rows.Clear();
							dataTable.o0.o.(true, null);
						}
						goto IL_31E;
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
						goto IL_31E;
					}
					finally
					{
						if (state != ConnectionState.Open)
						{
							dataTable.frd_Connection.Close();
						}
					}
				}
				if (Operators.CompareString(dataTable.UpdateServer, "", true) > 0)
				{
					O0O o0O = O_O0OO.OoO__.0oO0oo.()[dataTable.ConnectionName];
					HttpClient httpClient = o0O.oO0_0.o.();
					string text;
					if (o0O.OO.OoO0. == DataServerTypeEnum.Oracle)
					{
						text = "Delete From " + dataTable.o._OOO0oOo0__.;
					}
					else
					{
						text = "Delete From [" + dataTable.o._OOO0oOo0__..Trim(new char[]
						{
							'[',
							']'
						}) + "]";
					}
					if (Operators.CompareString(dataTable.LoadFilter, "", true) > 0)
					{
						text = text + " Where " + dataTable.LoadFilter;
					}
					httpClient.Select = text;
					httpClient.FormData["Action"] = 7.ToString();
					try
					{
						httpClient.GetData();
						if (ReLoad)
						{
							this._DataTable.Rows.Clear();
							dataTable.o0.o.(true, null);
						}
					}
					catch (Exception a_2)
					{
						ooO.oOo0Oo.o.(a_2, "");
					}
				}
			}
			IL_31E:
			dataTable = null;
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x000FD890 File Offset: 0x000FBA90
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataRow Add()
		{
			return OO_00oOO.DataTables[this._DataTable.TableName].AddNew(1);
		}

		/// <summary>
		/// 增加行
		/// </summary>
		// Token: 0x06002395 RID: 9109 RVA: 0x000FD8AD File Offset: 0x000FBAAD
		public DataRow AddNew()
		{
			return this.Add();
		}

		/// <summary>
		/// 增加多行
		/// </summary>
		/// <param name="Count">要增加的行数</param>
		// Token: 0x06002396 RID: 9110 RVA: 0x000FD8B5 File Offset: 0x000FBAB5
		public DataRow AddNew(int Count)
		{
			return OO_00oOO.DataTables[this._DataTable.TableName].AddNew(Count);
		}

		/// <summary>
		/// 删除指定位置的行
		/// </summary>
		/// <param name="Index">行位置</param>
		// Token: 0x06002397 RID: 9111 RVA: 0x000FD8D2 File Offset: 0x000FBAD2
		public bool Delete(int Index)
		{
			return this[Index].Delete();
		}

		/// <summary>
		/// 移除指定位置的行
		/// </summary>
		/// <param name="Index">行位置</param>
		// Token: 0x06002398 RID: 9112 RVA: 0x000FD8E0 File Offset: 0x000FBAE0
		public void Remove(int Index)
		{
			this[Index].BaseRow.RowError = "a";
			this._DataTable.Rows.RemoveAt(Index);
		}

		// Token: 0x170007D4 RID: 2004
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataRow this[int Index]
		{
			get
			{
				return new DataRow(this._Rows[Index]);
			}
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x000FD918 File Offset: 0x000FBB18
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<DataRow> GetEnumerator()
		{
			return new O__(this._Rows);
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x000FD925 File Offset: 0x000FBB25
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return new O__(this._Rows);
		}

		// Token: 0x04000EB5 RID: 3765
		private DataTable _DataTable;

		// Token: 0x04000EB6 RID: 3766
		internal DataRow[] _Rows;
	}
}
