using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002A9 RID: 681
	[oO0oooo("1358")]
	[ComVisible(true)]
	public class DataRow
	{
		// Token: 0x06002361 RID: 9057 RVA: 0x000F972C File Offset: 0x000F792C
		public DataRow(DataRow A_0)
		{
			this.OO0._o_00000. = true;
			this.OO0._o_00000. = A_0;
		}

		// Token: 0x170007C7 RID: 1991
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string ColumnName]
		{
			get
			{
				DataRowVersion version = DataRowVersion.Default;
				if (this.OO0._o_00000..RowState == DataRowState.Deleted)
				{
					version = DataRowVersion.Original;
				}
				object result;
				if (this.OO0._o_00000.[ColumnName, version] == DBNull.Value)
				{
					Type dataType = this.BaseRow.Table.Columns[ColumnName].DataType;
					if (dataType == typeof(string))
					{
						result = "";
					}
					else if (dataType == typeof(bool))
					{
						result = false;
					}
					else if (dataType == typeof(DateTime))
					{
						result = default(DateTime);
					}
					else
					{
						result = 0;
					}
				}
				else
				{
					if (this.OO0._o_00000..Table.Columns[ColumnName].DataType == typeof(DateTime))
					{
						DateTime dateTime = Conversions.ToDate(this.OO0._o_00000.[ColumnName, version]);
						if (this.OO0._o_00000..Table.DataSet == null || this.OO0._o_00000..Table.DataSet != O_O0OO.OOOo.oo_OOOO_0.())
						{
							return dateTime;
						}
						switch (OO_00oOO.DataTables[this.OO0._o_00000..Table.TableName].DataCols[ColumnName].DateTimeFormat)
						{
						case DateTimeFormatEnum.Date:
							return dateTime.Date;
						case DateTimeFormatEnum.Time:
							dateTime = new DateTime(dateTime.Ticks - dateTime.Date.Ticks);
							return dateTime.AddSeconds((double)(-(double)dateTime.Second));
						case DateTimeFormatEnum.LongTime:
							return new DateTime(dateTime.Ticks - dateTime.Date.Ticks);
						case DateTimeFormatEnum.DateTime:
							return dateTime.AddSeconds((double)(-(double)dateTime.Second));
						case DateTimeFormatEnum.DateLongTime:
							return dateTime;
						}
					}
					result = this.OO0._o_00000.[ColumnName, version];
				}
				return result;
			}
			set
			{
				if (value != null && value.GetType() == typeof(DateTime) && DateTime.Compare(Conversions.ToDate(value), DateTime.MinValue) == 0)
				{
					value = null;
				}
				if (!o_O_o_oOoo__.oO.O_..Contains(ColumnName) && this.OO0._o_00000..RowState != DataRowState.Deleted)
				{
					if (value == null)
					{
						value = DBNull.Value;
					}
					if (this.OO0._o_00000..Table.DataSet != O_O0OO.OOOo.oo_OOOO_0.() || Operators.CompareString(ColumnName, this.DataTable.O_.__0., true) != 0)
					{
						if (this.OO0._o_00000..HasVersion(DataRowVersion.Proposed) && this.OO0._o_00000..RowState != DataRowState.Detached)
						{
							this.OO0._o_00000..EndEdit();
							if (this.OO0._o_00000..HasVersion(DataRowVersion.Proposed))
							{
								return;
							}
						}
						if (string.Compare(this.OO0._o_00000.[ColumnName].ToString(), value.ToString(), false) != 0)
						{
							this.OO0._o_00000.[ColumnName] = RuntimeHelpers.GetObjectValue(value);
						}
					}
				}
			}
		}

		// Token: 0x170007C8 RID: 1992
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[DataCol Column]
		{
			get
			{
				return this[Column.Name];
			}
			set
			{
				this[Column.Name] = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 以字符串集合的形式返回或设置单元格内容。
		/// </summary>
		/// <param name="ColumnName">列名</param>
		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x000F9A7C File Offset: 0x000F7C7C
		// (set) Token: 0x06002367 RID: 9063 RVA: 0x000F9AEC File Offset: 0x000F7CEC
		[oO0oooo("2718")]
		public List<string> Lines
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this[ColumnName]);
				List<string> result;
				if (objectValue is string)
				{
					List<string> list = new List<string>();
					if (this.get_IsNull(ColumnName))
					{
						result = list;
					}
					else
					{
						string text = objectValue.ToString();
						list.AddRange(text.Split(new string[]
						{
							"\r\n",
							"\r",
							"\n"
						}, StringSplitOptions.None));
						result = list;
					}
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				string[] value2 = value.ToArray();
				this[ColumnName] = string.Join("\r\n", value2);
			}
		}

		/// <summary>
		/// 以字符串集合的形式返回或设置单元格内容。
		/// </summary>
		/// <param name="Column">列</param>
		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x000F9B12 File Offset: 0x000F7D12
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x000F9B20 File Offset: 0x000F7D20
		[oO0oooo("2718")]
		public List<string> Lines
		{
			get
			{
				return this.get_Lines(Column.Name);
			}
			set
			{
				this.set_Lines(Column.Name, value);
			}
		}

		/// <summary>
		/// 以字符串集合的形式返回或设置单元格内容。
		/// </summary>
		/// <param name="ColumnName">列名</param>
		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x000F9B2F File Offset: 0x000F7D2F
		[oO0oooo("0426")]
		public bool IsNull
		{
			get
			{
				return this.OO0._o_00000..IsNull(ColumnName);
			}
		}

		/// <summary>
		/// 以字符串集合的形式返回或设置单元格内容。
		/// </summary>
		/// <param name="Column">列</param>
		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x000F9B3D File Offset: 0x000F7D3D
		[oO0oooo("0426")]
		public bool IsNull
		{
			get
			{
				return this.OO0._o_00000..IsNull(Column.Name);
			}
		}

		/// <summary>
		/// 返回行的状态
		/// </summary>
		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x000F9B50 File Offset: 0x000F7D50
		[oO0oooo("0428")]
		public DataRowState RowState
		{
			get
			{
				return (DataRowState)this.OO0._o_00000..RowState;
			}
		}

		/// <summary>
		/// 返回或设置行的锁定状态
		/// </summary>
		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x000F9B60 File Offset: 0x000F7D60
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x000F9BB0 File Offset: 0x000F7DB0
		[oO0oooo("0427")]
		public bool Locked
		{
			get
			{
				return this.OO0._o_00000..Table.DataSet != null && !this.OO0._o_00000..IsNull("_Locked") && Conversions.ToBoolean(this.OO0._o_00000.["_Locked"]);
			}
			set
			{
				if (this.Locked != value)
				{
					if (this.OO0._o_00000..Table.Columns["_Locked"].DataType != typeof(bool))
					{
						if (value)
						{
							this.OO0._o_00000.["_Locked"] = 1;
						}
						else
						{
							this.OO0._o_00000.["_Locked"] = DBNull.Value;
						}
					}
					else
					{
						this.OO0._o_00000.["_Locked"] = value;
					}
					if (value == this.Locked)
					{
						DataTable dataTable = this.DataTable;
						if (dataTable == null || this.OO0._o_00000..RowState == DataRowState.Detached)
						{
							return;
						}
						DataRowEventArgs dataRowEventArgs = new DataRowEventArgs(dataTable, new DataRow(this.OO0._o_00000.));
						if (dataTable.O0__oo_0O_.__. != null && OO_00oOO.SystemReady)
						{
							try
							{
								dataTable.O0__oo_0O_.__..Invoke(null, new object[]
								{
									dataRowEventArgs
								});
							}
							catch (Exception a_)
							{
								ooO.oOo0Oo.o.(a_, "表，" + dataTable.Name + "，DataRowLockedChanged");
							}
						}
						if (dataTable.GlobalHandler.DataRowLockedChanged)
						{
							try
							{
								if (O_O0OO.O0_00o.o0__o..O____O_.00. != null && OO_00oOO.SystemReady)
								{
									O_O0OO.O0_00o.o0__o..O____O_.00..Invoke(null, new object[]
									{
										dataRowEventArgs
									});
								}
							}
							catch (Exception a_2)
							{
								ooO.oOo0Oo.o.(a_2, "全局表事件，DataRowLockedChanged");
							}
						}
					}
					Main.OO_O.o..O.ooO0. = true;
				}
			}
		}

		/// <summary>
		/// 返回一个DataRow集合，集合中包括指定子表中和该行对应的全部关联行
		/// </summary>
		/// <param name="ChildTableName">子表名称</param>
		// Token: 0x0600236F RID: 9071 RVA: 0x000F9D48 File Offset: 0x000F7F48
		[oO0oooo("0431")]
		public List<DataRow> GetChildRows(string ChildTableName)
		{
			List<DataRow> list = new List<DataRow>();
			DataRelation dataRelation = null;
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
				{
					DataRelation dataRelation2 = (DataRelation)obj;
					if (dataRelation2.ParentTable == this.OO0._o_00000..Table & Operators.CompareString(dataRelation2.ChildTable.TableName, ChildTableName, true) == 0)
					{
						dataRelation = dataRelation2;
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
			List<DataRow> result;
			if (dataRelation == null)
			{
				result = list;
			}
			else
			{
				DataRow[] childRows = this.OO0._o_00000..GetChildRows(dataRelation);
				if (childRows.Length == 0)
				{
					result = list;
				}
				else
				{
					int num = childRows.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (childRows[i].RowState != DataRowState.Deleted)
						{
							list.Add(new DataRow(childRows[i]));
						}
					}
					result = list;
				}
			}
			return result;
		}

		/// <summary>
		/// 返回该行在指定父表中对应的关联行
		/// </summary>
		/// <param name="ParentTableName">父表名称</param>
		// Token: 0x06002370 RID: 9072 RVA: 0x000F9E34 File Offset: 0x000F8034
		[oO0oooo("0432")]
		public DataRow GetParentRow(string ParentTableName)
		{
			DataRelation dataRelation = null;
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
				{
					DataRelation dataRelation2 = (DataRelation)obj;
					if (dataRelation2.ChildTable == this.OO0._o_00000..Table & Operators.CompareString(dataRelation2.ParentTable.TableName, ParentTableName, true) == 0)
					{
						dataRelation = dataRelation2;
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
			DataRow parentRow = this.OO0._o_00000..GetParentRow(dataRelation.RelationName);
			DataRow result;
			if (parentRow == null)
			{
				result = null;
			}
			else
			{
				result = new DataRow(parentRow);
			}
			return result;
		}

		/// <summary>
		/// 如果关联是多对多关联，可以用此方法获得一个集合，该集合包括该行在指定父表中所有对应的关联行
		/// </summary>
		/// <param name="ParentTableName">父表名称</param>
		// Token: 0x06002371 RID: 9073 RVA: 0x000F9EE4 File Offset: 0x000F80E4
		[oO0oooo("0433")]
		public List<DataRow> GetParentRows(string ParentTableName)
		{
			List<DataRow> list = new List<DataRow>();
			DataRelation dataRelation = null;
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
				{
					DataRelation dataRelation2 = (DataRelation)obj;
					if (dataRelation2.ChildTable == this.OO0._o_00000..Table & Operators.CompareString(dataRelation2.ParentTable.TableName, ParentTableName, true) == 0)
					{
						dataRelation = dataRelation2;
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
			List<DataRow> result;
			if (dataRelation == null)
			{
				result = list;
			}
			else
			{
				DataRow[] parentRows = this.OO0._o_00000..GetParentRows(dataRelation);
				if (parentRows.Length == 0)
				{
					result = list;
				}
				else
				{
					int num = parentRows.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						list.Add(new DataRow(parentRows[i]));
					}
					result = list;
				}
			}
			return result;
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x000F9FC4 File Offset: 0x000F81C4
		internal bool <<EMPTY_NAME>>()
		{
			this.OO0._o_00000. = true;
			this.Delete();
			return this.OO0._o_00000.;
		}

		/// <summary>
		/// 删除行
		/// </summary>
		// Token: 0x06002373 RID: 9075 RVA: 0x000F9FDC File Offset: 0x000F81DC
		[oO0oooo("0429")]
		public bool Delete()
		{
			bool result;
			if (this.Locked)
			{
				result = false;
			}
			else
			{
				if (this.OO0._o_00000..RowState != DataRowState.Detached)
				{
					if (this.OO0._o_00000..Table.DataSet == O_O0OO.OOOo.oo_OOOO_0.())
					{
						DataTable dataTable = OO_00oOO.DataTables[this.OO0._o_00000..Table.TableName];
						DataRowEventArgs dataRowEventArgs = new DataRowEventArgs(OO_00oOO.DataTables[this.OO0._o_00000..Table.TableName], new DataRow(this.OO0._o_00000.));
						if (dataTable.O.oO0_00. != null && OO_00oOO.SystemReady)
						{
							try
							{
								dataTable.O.oO0_00..Invoke(null, new object[]
								{
									dataRowEventArgs
								});
							}
							catch (Exception a_)
							{
								ooO.oOo0Oo.o.(a_, "表，" + this.OO0._o_00000..Table.TableName + "，BeforeDeleteDataRow");
							}
						}
						if (!dataRowEventArgs.Cancel && this.DataTable.GlobalHandler.BeforeDeleteDataRow && OO_00oOO.SystemReady && O_O0OO.O0_00o.o0__o..ooO.0O. != null)
						{
							try
							{
								O_O0OO.O0_00o.o0__o..ooO.0O..Invoke(null, new object[]
								{
									dataRowEventArgs
								});
							}
							catch (Exception a_2)
							{
								ooO.oOo0Oo.o.(a_2, "全局表事件,BeforeDeleteDataRow");
							}
						}
						this.OO0._o_00000. = dataRowEventArgs.Continue;
						if (dataRowEventArgs.Cancel)
						{
							return false;
						}
					}
					this.OO0._o_00000..Delete();
				}
				else
				{
					O_oOooO_O o_oOooO_O = OO_00oOO.Tables[this.OO0._o_00000..Table.TableName].foxGrid;
					o_oOooO_O.RemoveItem(o_oOooO_O.Rows.Count - 1);
				}
				result = (this.OO0._o_00000..RowState == DataRowState.Deleted || this.OO0._o_00000..RowState == DataRowState.Detached);
			}
			return result;
		}

		/// <summary>
		/// 移除行
		/// </summary>
		// Token: 0x06002374 RID: 9076 RVA: 0x000FA1C0 File Offset: 0x000F83C0
		[oO0oooo("2096")]
		public void Remove()
		{
			this.OO0._o_00000..RowError = "a";
			this.OO0._o_00000..Table.Rows.Remove(this.OO0._o_00000.);
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x000FA1ED File Offset: 0x000F83ED
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Refresh()
		{
			this.Load(true);
		}

		/// <summary>
		/// 重新加载行
		/// </summary>
		/// <param name="blnSave">是否先保存数据</param>
		// Token: 0x06002376 RID: 9078 RVA: 0x000FA1F8 File Offset: 0x000F83F8
		[oO0oooo("0430")]
		public void Load(bool blnSave = true)
		{
			OleDbCommand oleDbCommand = new OleDbCommand("", OO_00oOO.DataTables[this.OO0._o_00000..Table.TableName].frd_Connection);
			StringBuilder stringBuilder = new StringBuilder();
			DataTable dataTable = OO_00oOO.DataTables[this.OO0._o_00000..Table.TableName];
			if ((!dataTable.frd_IsOuterQuery && !dataTable.frd_IsInnerQuery && !dataTable.frd_IsTemporary && dataTable.BaseTable.PrimaryKey.Length != 0) || Operators.CompareString(this.DataTable.UpdateServer, "", true) != 0)
			{
				bool flag = false;
				if (this.OO0._o_00000..RowState == DataRowState.Added)
				{
					flag = true;
				}
				if (blnSave)
				{
					if (Operators.CompareString(this.DataTable.DataServer, "", true) == 0)
					{
						if (dataTable._Adapter != null && dataTable._Adapter.UpdateCommand != null)
						{
							dataTable._Adapter.Update(new DataRow[]
							{
								this.OO0._o_00000.
							});
						}
					}
					else
					{
						this.Save();
					}
				}
				if (!flag)
				{
					int num = this.OO0._o_00000..Table.PrimaryKey.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append(" And ");
						}
						if (this.OO0._o_00000..Table.PrimaryKey[i].DataType == typeof(string))
						{
							stringBuilder.Append(string.Concat(new string[]
							{
								"[",
								this.OO0._o_00000..Table.PrimaryKey[i].ColumnName,
								"] = '",
								this.OO0._o_00000.[this.OO0._o_00000..Table.PrimaryKey[i].ColumnName].ToString(),
								"'"
							}));
						}
						else if (this.OO0._o_00000..Table.PrimaryKey[i].DataType == typeof(DateTime))
						{
							stringBuilder.Append(string.Concat(new string[]
							{
								"[",
								this.OO0._o_00000..Table.PrimaryKey[i].ColumnName,
								"] = #",
								this.OO0._o_00000.[this.OO0._o_00000..Table.PrimaryKey[i].ColumnName].ToString(),
								"#"
							}));
						}
						else
						{
							stringBuilder.Append("[" + this.OO0._o_00000..Table.PrimaryKey[i].ColumnName + "] = " + this.OO0._o_00000.[this.OO0._o_00000..Table.PrimaryKey[i].ColumnName].ToString());
						}
					}
					if (Operators.CompareString(this.DataTable.DataServer, "", true) == 0)
					{
						ConnectionState state = oleDbCommand.Connection.State;
						try
						{
							if (state != ConnectionState.Open)
							{
								oleDbCommand.Connection.Open();
							}
							string o._OOO0oOo0__. = OO_00oOO.DataTables[this.OO0._o_00000..Table.TableName].o._OOO0oOo0__.;
							string text = "Select * From [" + o._OOO0oOo0__. + "] Where " + stringBuilder.ToString();
							if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbCommand.Connection))
							{
								text = text.Replace("[" + o._OOO0oOo0__. + "]", o._OOO0oOo0__.);
								text = text.Replace("[", "\"").Replace("]", "\"");
							}
							oleDbCommand.CommandText = text;
							OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
							if (oleDbDataReader.Read())
							{
								int num2 = oleDbDataReader.FieldCount - 1;
								for (int j = 0; j <= num2; j++)
								{
									if (this.OO0._o_00000..Table.Columns.Contains(oleDbDataReader.GetName(j)))
									{
										DataColumn dataColumn = this.OO0._o_00000..Table.Columns[oleDbDataReader.GetName(j)];
										if (Operators.CompareString(dataColumn.ColumnName, "_Identify", true) != 0)
										{
											this.OO0._o_00000.[dataColumn] = RuntimeHelpers.GetObjectValue(oleDbDataReader[j]);
										}
									}
								}
							}
							oleDbDataReader.Close();
							this.OO0._o_00000..AcceptChanges();
							return;
						}
						catch (Exception a_)
						{
							ooO.oOo0Oo.o.(a_, "");
							return;
						}
						finally
						{
							if (state != ConnectionState.Open)
							{
								oleDbCommand.Connection.Close();
							}
						}
					}
					string str = Oo00.oo_0__0.o.(this.DataTable.HttpSelect);
					string a_2 = "Select * From " + str + " Where " + stringBuilder.ToString();
					HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.DataTable.ConnectionName].oO0_0.o.();
					httpClient.FormData.Add("IgnoreSchema", "True");
					httpClient.Select = a_2;
					httpClient.FormData["Action"] = 2.ToString();
					DataTable baseDataTable = httpClient.GetBaseDataTable();
					if (baseDataTable != null && baseDataTable.Rows.Count > 0)
					{
						this.DataTable.BaseTable.Merge(baseDataTable, false, MissingSchemaAction.Ignore);
						baseDataTable.Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 返回底层的System.Data.DatRow
		/// </summary>
		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x000FA754 File Offset: 0x000F8954
		public DataRow BaseRow
		{
			get
			{
				return this.OO0._o_00000.;
			}
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x000FA75C File Offset: 0x000F895C
		public bool Equals(DataRow dr1)
		{
			return dr1.BaseRow == this.OO0._o_00000.;
		}

		/// <summary>
		/// 返回所属的DataTable
		/// </summary>
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x000FA76C File Offset: 0x000F896C
		public DataTable DataTable
		{
			get
			{
				DataTable result;
				if (this.OO0._o_00000. != null)
				{
					result = this.OO0._o_00000.;
				}
				else if (this.OO0._o_00000..Table.DataSet == O_O0OO.OOOo.oo_OOOO_0.() && OO_00oOO.DataTables.Contains(this.OO0._o_00000..Table.TableName))
				{
					result = OO_00oOO.DataTables[this.OO0._o_00000..Table.TableName];
				}
				else if (this.OO0._o_00000..Table.ExtendedProperties.Contains("foxtable.datatable"))
				{
					result = (DataTable)this.OO0._o_00000..Table.ExtendedProperties["foxtable.datatable"];
				}
				else if (this.OO0._o_00000..Table.ExtendedProperties.Contains("MirrorFromDataTable"))
				{
					result = (DataTable)this.OO0._o_00000..Table.ExtendedProperties["MirrorFromDataTable"];
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 撤销自打开文件或最近一次保存以来，对该行做出的修改
		/// </summary>
		// Token: 0x0600237A RID: 9082 RVA: 0x000FA85C File Offset: 0x000F8A5C
		[oO0oooo("1537")]
		public void Reject()
		{
			this.RejectChanges();
		}

		/// <summary>
		/// 接受此行的所有修改,在此之前做的任何修改都不会保存
		/// </summary>
		// Token: 0x0600237B RID: 9083 RVA: 0x000FA864 File Offset: 0x000F8A64
		[oO0oooo("2366")]
		public void Accept()
		{
			this.OO0._o_00000..AcceptChanges();
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x000FA874 File Offset: 0x000F8A74
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void RejectChanges()
		{
			if (this.OO0._o_00000..RowState == DataRowState.Modified)
			{
				List<DataColumn> list = new List<DataColumn>();
				try
				{
					foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
					{
						DataRelation dataRelation = (DataRelation)obj;
						if (dataRelation.ParentTable == this.OO0._o_00000..Table && OO_00oOO.Relations[dataRelation.RelationName].CascadeUpdate)
						{
							foreach (DataColumn item in dataRelation.ParentColumns)
							{
								if (!list.Contains(item))
								{
									list.Add(item);
								}
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
				try
				{
					foreach (DataColumn dataColumn in list)
					{
						if (Operators.CompareString(dataColumn.Expression, "", true) <= 0)
						{
							this.OO0._o_00000.[dataColumn] = RuntimeHelpers.GetObjectValue(this.OO0._o_00000.[dataColumn, DataRowVersion.Original]);
						}
					}
					goto IL_1D1;
				}
				finally
				{
					List<DataColumn>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			if (this.OO0._o_00000..RowState == DataRowState.Added)
			{
				try
				{
					foreach (object obj2 in O_O0OO.OOOo.oo_OOOO_0.().Relations)
					{
						DataRelation dataRelation2 = (DataRelation)obj2;
						if (dataRelation2.ParentTable == this.OO0._o_00000..Table && OO_00oOO.Relations[dataRelation2.RelationName].CascadeDelete)
						{
							foreach (DataRow dataRow in this.OO0._o_00000..GetChildRows(dataRelation2))
							{
								if (dataRow.RowState == DataRowState.Added)
								{
									dataRow.RejectChanges();
								}
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
			}
			IL_1D1:
			this.OO0._o_00000..RejectChanges();
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable.BaseTable == this.OO0._o_00000..Table)
					{
						table.ClearEditInfos();
					}
					if (table.Current != null && table.Current.DataRow.BaseRow == this.OO0._o_00000. && table.o00oOO00_.ooOo. != null && table.o00oOO00_.ooOo..FindForm() != null)
					{
						table.o00oOO00_.ooOo..Oo0o__.OO0o__O.();
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
			if (O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(this.OO0._o_00000..Table.TableName))
			{
				OO_00oOO.Tables[this.OO0._o_00000..Table.TableName].RefreshChildTables();
			}
		}

		/// <summary>
		/// 单独保存此行
		/// </summary>
		// Token: 0x0600237D RID: 9085 RVA: 0x000FAB64 File Offset: 0x000F8D64
		public void Save()
		{
			bool flag = false;
			if (this.DataTable != null && this.DataTable._Adapter != null && this.DataTable._Adapter.UpdateCommand != null)
			{
				flag = true;
			}
			if (this.BaseRow.RowState == DataRowState.Detached && Operators.CompareString(this.BaseRow.RowError, "Mirror", true) == 0)
			{
				this.BaseRow.RowError = null;
				this.BaseRow.Table.Rows.Add(this.BaseRow);
			}
			if (!flag && this.BaseRow.Table.DataSet == null && this.OO0._o_00000. == null)
			{
				if (this.BaseRow.Table.ExtendedProperties.ContainsKey("MirrorFromDataTable"))
				{
					if (Operators.CompareString(this.DataTable.UpdateServer, "", true) > 0)
					{
						DataRow baseRow = this.BaseRow;
						DataRowState rowState = baseRow.RowState;
						if (rowState == DataRowState.Added)
						{
							oOO0oO000_0_0.o__o.OOO__.(this.DataTable, new DataRow[]
							{
								baseRow
							});
							return;
						}
						if (rowState != DataRowState.Modified)
						{
							return;
						}
						oOO0oO000_0_0.oOoOo_o.__.(this.DataTable, new DataRow[]
						{
							baseRow
						});
						return;
					}
				}
				else if (this.BaseRow.Table.ExtendedProperties.Contains("DataAdapter"))
				{
					((OleDbDataAdapter)this.BaseRow.Table.ExtendedProperties["DataAdapter"]).Update(new DataRow[]
					{
						this.BaseRow
					});
				}
				else if (this.BaseRow.Table.ExtendedProperties.Contains("foxtable.datatable"))
				{
					DataTable dataTable = (DataTable)this.BaseRow.Table.ExtendedProperties["foxtable.datatable"];
					if (dataTable._Adapter != null)
					{
						dataTable._Adapter.Update(new DataRow[]
						{
							this.BaseRow
						});
					}
					else
					{
						DataRow baseRow2 = this.BaseRow;
						if (Operators.CompareString(this.DataTable.UpdateServer, "", true) > 0)
						{
							DataRowState rowState2 = baseRow2.RowState;
							if (rowState2 != DataRowState.Added)
							{
								if (rowState2 != DataRowState.Deleted)
								{
									if (rowState2 == DataRowState.Modified)
									{
										oOO0oO000_0_0.oOoOo_o.__.(this.DataTable, new DataRow[]
										{
											baseRow2
										});
									}
								}
								else
								{
									oOO0oO000_0_0.OO.OoO0.(this.DataTable, new DataRow[]
									{
										baseRow2
									});
								}
							}
							else
							{
								oOO0oO000_0_0.o__o.OOO__.(this.DataTable, new DataRow[]
								{
									baseRow2
								});
							}
						}
					}
				}
				if (this.BaseRow.Table.ExtendedProperties.Contains("Mirror") && Conversions.ToBoolean(this.BaseRow.Table.ExtendedProperties["Mirror"]))
				{
					this.BaseRow.Table.Rows.Remove(this.BaseRow);
					return;
				}
			}
			else
			{
				if ((this.BaseRow.RowState == DataRowState.Added || this.BaseRow.RowState == DataRowState.Modified) && this.OO0._o_00000..Table.DataSet == O_O0OO.OOOo.oo_OOOO_0.())
				{
					DataRowEventArgs dataRowEventArgs = new DataRowEventArgs(this.DataTable, this);
					if (this.DataTable.o.__Oo_Oo_. != null && OO_00oOO.SystemReady)
					{
						try
						{
							this.DataTable.o.__Oo_Oo_..Invoke(null, new object[]
							{
								dataRowEventArgs
							});
						}
						catch (Exception a_)
						{
							ooO.oOo0Oo.o.(a_, "表，" + this.DataTable.Name + "，BeforeSaveDataRow");
						}
					}
					if (!dataRowEventArgs.Cancel && this.DataTable.GlobalHandler.BeforeSaveDataRow && OO_00oOO.SystemReady && O_O0OO.O0_00o.o0__o..O__0o._O_oo. != null)
					{
						try
						{
							O_O0OO.O0_00o.o0__o..O__0o._O_oo..Invoke(null, new object[]
							{
								dataRowEventArgs
							});
						}
						catch (Exception a_2)
						{
							ooO.oOo0Oo.o.(a_2, "全局表事件, BeforeSaveDataRow");
						}
					}
					if (dataRowEventArgs.Cancel)
					{
						return;
					}
				}
				if (Operators.CompareString(this.DataTable.DataServer, "", true) > 0)
				{
					DataRow baseRow3 = this.BaseRow;
					if (Operators.CompareString(this.DataTable.UpdateServer, "", true) > 0)
					{
						DataRowState rowState3 = baseRow3.RowState;
						if (rowState3 == DataRowState.Added)
						{
							oOO0oO000_0_0.o__o.OOO__.(this.DataTable, new DataRow[]
							{
								baseRow3
							});
							return;
						}
						if (rowState3 == DataRowState.Deleted)
						{
							oOO0oO000_0_0.OO.OoO0.(this.DataTable, new DataRow[]
							{
								baseRow3
							});
							return;
						}
						if (rowState3 != DataRowState.Modified)
						{
							return;
						}
						oOO0oO000_0_0.oOoOo_o.__.(this.DataTable, new DataRow[]
						{
							baseRow3
						});
						return;
					}
				}
				else
				{
					DataRowState rowState4 = this.BaseRow.RowState;
					if (rowState4 == DataRowState.Added)
					{
						this.DataTable.oo_.0oo_.(new DataRow[]
						{
							this.BaseRow
						});
						return;
					}
					if (rowState4 != DataRowState.Deleted)
					{
						if (rowState4 != DataRowState.Modified)
						{
							return;
						}
						this.DataTable.O0_0oOO.0.(new DataRow[]
						{
							this.BaseRow
						});
						return;
					}
					else
					{
						this.DataTable.oO.o_0.(new DataRow[]
						{
							this.BaseRow
						});
					}
				}
			}
		}

		/// <summary>
		/// 判断某列的原始值是否为空
		/// </summary>
		/// <param name="ColumnName">列名</param>
		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x000FB078 File Offset: 0x000F9278
		[oO0oooo("2411")]
		public bool OriginalIsNull
		{
			get
			{
				bool result;
				if (this.BaseRow == null)
				{
					result = true;
				}
				else if (this.BaseRow.RowState == DataRowState.Added)
				{
					result = true;
				}
				else
				{
					DataRow baseRow = this.BaseRow;
					DataColumn column = this.BaseRow.Table.Columns[ColumnName];
					result = this.BaseRow.IsNull(column, DataRowVersion.Original);
				}
				return result;
			}
		}

		/// <summary>
		/// 获得指定列的原始值
		/// </summary>
		/// <param name="ColumnName">列名</param>
		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x000FB0D4 File Offset: 0x000F92D4
		[oO0oooo("2369")]
		public object OriginalValue
		{
			get
			{
				object result;
				if (this.BaseRow == null)
				{
					result = null;
				}
				else if (this.BaseRow.RowState == DataRowState.Added)
				{
					result = null;
				}
				else
				{
					DataRow baseRow = this.BaseRow;
					DataColumn column = this.BaseRow.Table.Columns[ColumnName];
					if (this.BaseRow.IsNull(column, DataRowVersion.Original))
					{
						Type dataType = this.BaseRow.Table.Columns[ColumnName].DataType;
						if (dataType == typeof(string))
						{
							result = "";
						}
						else if (dataType == typeof(bool))
						{
							result = false;
						}
						else if (dataType == typeof(DateTime))
						{
							result = default(DateTime);
						}
						else
						{
							result = 0;
						}
					}
					else
					{
						if (this.BaseRow.Table.Columns[ColumnName].DataType == typeof(DateTime))
						{
							DateTime dateTime = Conversions.ToDate(this.BaseRow[ColumnName, DataRowVersion.Original]);
							switch (OO_00oOO.DataTables[this.BaseRow.Table.TableName].DataCols[ColumnName].DateTimeFormat)
							{
							case DateTimeFormatEnum.Date:
								return dateTime.Date;
							case DateTimeFormatEnum.Time:
								dateTime = new DateTime(dateTime.Ticks - dateTime.Date.Ticks);
								return dateTime.AddSeconds((double)(-(double)dateTime.Second));
							case DateTimeFormatEnum.LongTime:
								return new DateTime(dateTime.Ticks - dateTime.Date.Ticks);
							case DateTimeFormatEnum.DateTime:
								return dateTime.AddSeconds((double)(-(double)dateTime.Second));
							case DateTimeFormatEnum.DateLongTime:
								return dateTime;
							}
						}
						result = this.BaseRow[ColumnName, DataRowVersion.Original];
					}
				}
				return result;
			}
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x000FB2E4 File Offset: 0x000F94E4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dictionary<string, object> LoadPhysicalValue()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			OleDbCommand oleDbCommand = new OleDbCommand("", OO_00oOO.DataTables[this.OO0._o_00000..Table.TableName].frd_Connection);
			StringBuilder stringBuilder = new StringBuilder();
			Dictionary<string, object> result;
			if (this.OO0._o_00000..RowState == DataRowState.Added)
			{
				result = dictionary;
			}
			else
			{
				if (dictionary == null)
				{
					dictionary = new Dictionary<string, object>();
				}
				else
				{
					dictionary.Clear();
				}
				DataTable dataTable = OO_00oOO.DataTables[this.OO0._o_00000..Table.TableName];
				if (dataTable.frd_IsOuterQuery || dataTable.frd_IsInnerQuery || dataTable.frd_IsTemporary || dataTable.BaseTable.PrimaryKey.Length == 0)
				{
					result = dictionary;
				}
				else
				{
					int num = this.OO0._o_00000..Table.PrimaryKey.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append(" And ");
						}
						if (this.OO0._o_00000..Table.PrimaryKey[i].DataType == typeof(string))
						{
							stringBuilder.Append(string.Concat(new string[]
							{
								"[",
								this.OO0._o_00000..Table.PrimaryKey[i].ColumnName,
								"] = '",
								this.OO0._o_00000.[this.OO0._o_00000..Table.PrimaryKey[i].ColumnName].ToString(),
								"'"
							}));
						}
						else if (this.OO0._o_00000..Table.PrimaryKey[i].DataType == typeof(DateTime))
						{
							stringBuilder.Append(string.Concat(new string[]
							{
								"[",
								this.OO0._o_00000..Table.PrimaryKey[i].ColumnName,
								"] = #",
								this.OO0._o_00000.[this.OO0._o_00000..Table.PrimaryKey[i].ColumnName].ToString(),
								"#"
							}));
						}
						else
						{
							stringBuilder.Append("[" + this.OO0._o_00000..Table.PrimaryKey[i].ColumnName + "] = " + this.OO0._o_00000.[this.OO0._o_00000..Table.PrimaryKey[i].ColumnName].ToString());
						}
					}
					ConnectionState state = oleDbCommand.Connection.State;
					try
					{
						if (state != ConnectionState.Open)
						{
							oleDbCommand.Connection.Open();
						}
						string o._OOO0oOo0__. = OO_00oOO.DataTables[this.OO0._o_00000..Table.TableName].o._OOO0oOo0__.;
						string text = "Select * From [" + o._OOO0oOo0__. + "] Where " + stringBuilder.ToString();
						if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbCommand.Connection))
						{
							text = text.Replace("[" + o._OOO0oOo0__. + "]", o._OOO0oOo0__.);
							text = text.Replace("[", "\"").Replace("]", "\"");
						}
						oleDbCommand.CommandText = text;
						OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
						if (oleDbDataReader.Read())
						{
							int num2 = oleDbDataReader.FieldCount - 1;
							for (int j = 0; j <= num2; j++)
							{
								object obj = RuntimeHelpers.GetObjectValue(oleDbDataReader[j]);
								string name = oleDbDataReader.GetName(j);
								if (obj == DBNull.Value)
								{
									obj = null;
								}
								else if (this.BaseRow.Table.Columns.Contains(name) && this.BaseRow.Table.Columns[name].DataType == typeof(DateTime))
								{
									DateTime dateTime = Conversions.ToDate(obj);
									switch (OO_00oOO.DataTables[this.BaseRow.Table.TableName].DataCols[name].DateTimeFormat)
									{
									case DateTimeFormatEnum.Date:
										obj = dateTime.Date;
										break;
									case DateTimeFormatEnum.Time:
										dateTime = new DateTime(dateTime.Ticks - dateTime.Date.Ticks);
										obj = dateTime.AddSeconds((double)(-(double)dateTime.Second));
										break;
									case DateTimeFormatEnum.LongTime:
										obj = new DateTime(dateTime.Ticks - dateTime.Date.Ticks);
										break;
									case DateTimeFormatEnum.DateTime:
										obj = dateTime.AddSeconds((double)(-(double)dateTime.Second));
										break;
									case DateTimeFormatEnum.DateLongTime:
										obj = dateTime;
										break;
									}
								}
								dictionary.Add(oleDbDataReader.GetName(j), RuntimeHelpers.GetObjectValue(obj));
							}
						}
						oleDbDataReader.Close();
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
					}
					finally
					{
						if (state != ConnectionState.Open)
						{
							oleDbCommand.Connection.Close();
						}
					}
					result = dictionary;
				}
			}
			return result;
		}

		/// <summary>
		/// 克隆行
		/// </summary>
		// Token: 0x06002381 RID: 9089 RVA: 0x000FB824 File Offset: 0x000F9A24
		public DataRow Clone()
		{
			DataRow dataRow = this.DataTable.NewRow();
			if (dataRow != null)
			{
				try
				{
					foreach (object obj in this.BaseRow.Table.Columns)
					{
						DataColumn dataColumn = (DataColumn)obj;
						if (!o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) && dataRow.get_IsNull(dataColumn.ColumnName))
						{
							dataRow[dataColumn.ColumnName] = RuntimeHelpers.GetObjectValue(this.BaseRow[dataColumn]);
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
				this.BaseRow.Table.Rows.Add(dataRow.BaseRow);
			}
			return dataRow;
		}

		/// <summary>
		/// 给该行的指定列设置错误信息
		/// </summary>
		/// <param name="ColumnName">列名</param>
		/// <param name="[Error]">错误信息</param>
		// Token: 0x06002382 RID: 9090 RVA: 0x000FB8F0 File Offset: 0x000F9AF0
		[oO0oooo("2682")]
		public void SetError(string ColumnName, string Error)
		{
			this.BaseRow.SetColumnError(ColumnName, Error);
		}

		/// <summary>
		/// 给该行的指定列设置错误信息
		/// </summary>
		/// <param name="DataCol">列</param>
		/// <param name="[Error]">错误信息</param>
		// Token: 0x06002383 RID: 9091 RVA: 0x000FB8FF File Offset: 0x000F9AFF
		[oO0oooo("2682")]
		public void SetError(DataCol DataCol, string Error)
		{
			this.BaseRow.SetColumnError(DataCol.Name, Error);
		}

		/// <summary>
		/// 获取此行指定列的错误信息
		/// </summary>
		/// <param name="ColumnName"></param>
		// Token: 0x06002384 RID: 9092 RVA: 0x000FB913 File Offset: 0x000F9B13
		[oO0oooo("2683")]
		public string GetError(string ColumnName)
		{
			return this.BaseRow.GetColumnError(ColumnName);
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x000FB921 File Offset: 0x000F9B21
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string GetError(DataCol DataCol, string info)
		{
			return this.BaseRow.GetColumnError(DataCol.Name);
		}

		/// <summary>
		/// 清除此行所有列的错误信息
		/// </summary>
		// Token: 0x06002386 RID: 9094 RVA: 0x000FB934 File Offset: 0x000F9B34
		[oO0oooo("2684")]
		public void ClearErrors()
		{
			this.BaseRow.ClearErrors();
		}

		/// <summary>
		/// 从二进制列中提取图片
		/// </summary>
		/// <param name="Filed">列名</param>
		// Token: 0x06002387 RID: 9095 RVA: 0x000FB944 File Offset: 0x000F9B44
		[oO0oooo("2953")]
		public Image SQLLoadImage(string Filed)
		{
			int num;
			Image result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.OO0._o_00000.())
				{
					goto IL_1A;
				}
				IL_11:
				num2 = 3;
				result = null;
				goto IL_2C5;
				IL_1A:
				num2 = 4;
				if (Operators.CompareString(this.DataTable.DataServer, "", true) != 0)
				{
					goto IL_1B5;
				}
				IL_37:
				num2 = 5;
				OleDbConnection oleDbConnection = this.DataTable.frd_Connection;
				IL_46:
				num2 = 6;
				string text = this.DataTable.o._OOO0oOo0__.;
				IL_55:
				num2 = 7;
				if (Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_7E;
				}
				IL_67:
				num2 = 8;
				text = "[" + text + "]";
				goto IL_9D;
				IL_7E:
				num2 = 10;
				text = Oo00.oo_0__0.o.(this.DataTable._Adapter.SelectCommand.CommandText);
				IL_9D:
				num2 = 11;
				string text2 = string.Concat(new string[]
				{
					"Select [",
					Filed,
					"] From ",
					text,
					" Where ",
					this.OO0._o_00000.()
				});
				IL_D7:
				num2 = 12;
				if (this.DataTable.DataServerType != DataServerTypeEnum.Oracle)
				{
					goto IL_10D;
				}
				IL_E8:
				num2 = 13;
				text2 = text2.Replace("[", "\"").Replace("]", "\"");
				IL_10D:
				num2 = 14;
				OleDbCommand oleDbCommand = new OleDbCommand(text2, oleDbConnection);
				IL_11B:
				num2 = 15;
				Image image = null;
				IL_121:
				num2 = 16;
				oleDbConnection.Open();
				IL_12B:
				num2 = 17;
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				IL_137:
				num2 = 18;
				if (!oleDbDataReader.Read())
				{
					goto IL_16C;
				}
				IL_143:
				num2 = 19;
				if (oleDbDataReader.IsDBNull(0))
				{
					goto IL_16C;
				}
				IL_150:
				num2 = 20;
				image = Image.FromStream(new MemoryStream((byte[])oleDbDataReader[Filed]));
				IL_16C:
				num2 = 21;
				oleDbDataReader.Close();
				IL_176:
				num2 = 22;
				oleDbConnection.Close();
				IL_180:
				num2 = 23;
				if (Information.Err().Number == 0)
				{
					goto IL_1AA;
				}
				IL_18F:
				num2 = 24;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_1AA:
				num2 = 25;
				result = image;
				goto IL_2C5;
				IL_1B5:
				num2 = 27;
				string text3 = Oo00.oo_0__0.o.(this.DataTable.HttpSelect);
				IL_1CA:
				num2 = 28;
				string text4 = string.Concat(new string[]
				{
					"Select [",
					Filed,
					"] From ",
					text3,
					" Where ",
					this.OO0._o_00000.()
				});
				IL_204:
				num2 = 29;
				if (this.DataTable.DataServerType != DataServerTypeEnum.Oracle)
				{
					goto IL_23A;
				}
				IL_215:
				num2 = 30;
				text4 = text4.Replace("[", "\"").Replace("]", "\"");
				IL_23A:
				num2 = 31;
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.DataTable.ConnectionName].oO0_0.o.();
				IL_259:
				num2 = 32;
				httpClient.Select = text4;
				IL_265:
				num2 = 33;
				httpClient.FormData.Add("Action", 13.ToString());
				IL_284:
				num2 = 34;
				MemoryStream memoryStream = new MemoryStream();
				IL_28E:
				num2 = 35;
				bool memStream = httpClient.GetMemStream(memoryStream);
				IL_29C:
				num2 = 36;
				Image image2 = null;
				IL_2A2:
				num2 = 37;
				if (!memStream)
				{
					goto IL_2BF;
				}
				IL_2A9:
				num2 = 38;
				image2 = Image.FromStream(memoryStream);
				IL_2B5:
				num2 = 39;
				memoryStream.Dispose();
				IL_2BF:
				num2 = 40;
				result = image2;
				IL_2C5:
				goto IL_3BB;
				IL_2CA:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_37C:
				goto IL_3B0;
				IL_37E:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_38E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_37E;
			}
			IL_3B0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3BB:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x000FBD34 File Offset: 0x000F9F34
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool SQLInsertImage(string Field, Image Image)
		{
			int num;
			bool result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.OO0._o_00000.())
				{
					goto IL_1A;
				}
				IL_11:
				num2 = 3;
				result = false;
				goto IL_20D;
				IL_1A:
				num2 = 4;
				if (Operators.CompareString(this.DataTable.DataServer, "", true) != 0)
				{
					goto IL_17B;
				}
				IL_37:
				num2 = 5;
				MemoryStream memoryStream = new MemoryStream();
				IL_40:
				num2 = 6;
				Image.Save(memoryStream, ImageFormat.Png);
				IL_4F:
				num2 = 7;
				OleDbConnection oleDbConnection = this.DataTable.frd_Connection;
				IL_5E:
				num2 = 8;
				string o._OOO0oOo0__. = this.DataTable.o._OOO0oOo0__.;
				IL_6D:
				num2 = 9;
				string text = string.Concat(new string[]
				{
					"Update [",
					o._OOO0oOo0__.,
					"] Set [",
					Field,
					"] = ? Where ",
					this.OO0._o_00000.()
				});
				IL_A7:
				num2 = 10;
				if (this.DataTable.DataServerType != DataServerTypeEnum.Oracle)
				{
					goto IL_DD;
				}
				IL_B8:
				num2 = 11;
				text = text.Replace("[", "\"").Replace("]", "\"");
				IL_DD:
				num2 = 12;
				OleDbCommand oleDbCommand = new OleDbCommand(text, oleDbConnection);
				IL_EB:
				num2 = 13;
				oleDbCommand.Parameters.Add("@" + Field, OleDbType.Binary, (int)memoryStream.Length).Value = memoryStream.ToArray();
				IL_11E:
				num2 = 14;
				oleDbConnection.Open();
				IL_128:
				num2 = 15;
				oleDbCommand.ExecuteNonQuery();
				IL_133:
				num2 = 16;
				oleDbConnection.Close();
				IL_13D:
				num2 = 17;
				if (Information.Err().Number == 0)
				{
					goto IL_171;
				}
				IL_14C:
				num2 = 18;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_167:
				num2 = 19;
				result = false;
				goto IL_20D;
				IL_171:
				num2 = 21;
				result = true;
				goto IL_20D;
				IL_17B:
				num2 = 23;
				if (Operators.CompareString(this.DataTable.UpdateServer, "", true) <= 0)
				{
					goto IL_20D;
				}
				IL_197:
				num2 = 24;
				if (OO_00oOO.FileSys.DirectoryExists(OO_00oOO.ProjectPath + "Bin\\TempFiles"))
				{
					goto IL_1D1;
				}
				IL_1B5:
				num2 = 25;
				OO_00oOO.FileSys.CreateDirectory(OO_00oOO.ProjectPath + "Bin\\TempFiles");
				IL_1D1:
				num2 = 26;
				string text2 = OO_00oOO.ProjectPath + "Bin\\TempFiles\\" + OoOo0O.OO_o.0o_O.(8) + ".png";
				IL_1F0:
				num2 = 27;
				Image.Save(text2, ImageFormat.Png);
				IL_200:
				num2 = 28;
				this.SQLInsertFile(Field, text2);
				IL_20D:
				goto IL_2D3;
				IL_212:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_294:
				goto IL_2C8;
				IL_296:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2A6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_296;
			}
			IL_2C8:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2D3:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		/// <summary>
		/// 从二进制列中提取文件。
		/// </summary>
		/// <param name="Filed">列名</param>
		/// <param name="FileName">文件名</param>
		// Token: 0x06002389 RID: 9097 RVA: 0x000FC03C File Offset: 0x000FA23C
		[oO0oooo("2952")]
		public bool SQLLoadFile(string Filed, string FileName)
		{
			int num;
			bool result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.OO0._o_00000.())
				{
					goto IL_1A;
				}
				IL_11:
				num2 = 3;
				result = false;
				goto IL_2DC;
				IL_1A:
				num2 = 4;
				if (Operators.CompareString(this.DataTable.DataServer, "", true) != 0)
				{
					goto IL_1FA;
				}
				IL_37:
				num2 = 5;
				OleDbConnection oleDbConnection = this.DataTable.frd_Connection;
				IL_46:
				num2 = 6;
				string text = this.DataTable.o._OOO0oOo0__.;
				IL_55:
				num2 = 7;
				if (Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_7E;
				}
				IL_67:
				num2 = 8;
				text = "[" + text + "]";
				goto IL_9D;
				IL_7E:
				num2 = 10;
				text = Oo00.oo_0__0.o.(this.DataTable._Adapter.SelectCommand.CommandText);
				IL_9D:
				num2 = 11;
				string text2 = string.Concat(new string[]
				{
					"Select [",
					Filed,
					"] From ",
					text,
					" Where ",
					this.OO0._o_00000.()
				});
				IL_D7:
				num2 = 12;
				if (this.DataTable.DataServerType != DataServerTypeEnum.Oracle)
				{
					goto IL_10D;
				}
				IL_E8:
				num2 = 13;
				text2 = text2.Replace("[", "\"").Replace("]", "\"");
				IL_10D:
				num2 = 14;
				OleDbCommand oleDbCommand = new OleDbCommand(text2, oleDbConnection);
				IL_11B:
				num2 = 15;
				MemoryStream memoryStream = null;
				IL_121:
				num2 = 16;
				oleDbConnection.Open();
				IL_12B:
				num2 = 17;
				OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
				IL_137:
				num2 = 18;
				if (!oleDbDataReader.Read())
				{
					goto IL_167;
				}
				IL_143:
				num2 = 19;
				if (oleDbDataReader.IsDBNull(0))
				{
					goto IL_167;
				}
				IL_150:
				num2 = 20;
				memoryStream = new MemoryStream((byte[])oleDbDataReader[Filed]);
				IL_167:
				num2 = 21;
				oleDbDataReader.Close();
				IL_171:
				num2 = 22;
				oleDbConnection.Close();
				IL_17B:
				num2 = 23;
				if (memoryStream != null)
				{
					goto IL_18C;
				}
				IL_182:
				num2 = 24;
				result = false;
				goto IL_2DC;
				IL_18C:
				num2 = 25;
				FileStream fileStream = new FileStream(FileName, FileMode.Create);
				IL_198:
				num2 = 26;
				fileStream.Write(memoryStream.ToArray(), 0, (int)memoryStream.Length);
				IL_1B2:
				num2 = 27;
				fileStream.Close();
				IL_1BC:
				num2 = 28;
				if (Information.Err().Number == 0)
				{
					goto IL_1F0;
				}
				IL_1CB:
				num2 = 29;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_1E6:
				num2 = 30;
				result = false;
				goto IL_2DC;
				IL_1F0:
				num2 = 32;
				result = true;
				goto IL_2DC;
				IL_1FA:
				num2 = 34;
				string text3 = Oo00.oo_0__0.o.(this.DataTable.HttpSelect);
				IL_20F:
				num2 = 35;
				string text4 = string.Concat(new string[]
				{
					"Select [",
					Filed,
					"] From ",
					text3,
					" Where ",
					this.OO0._o_00000.()
				});
				IL_249:
				num2 = 36;
				if (this.DataTable.DataServerType != DataServerTypeEnum.Oracle)
				{
					goto IL_27F;
				}
				IL_25A:
				num2 = 37;
				text4 = text4.Replace("[", "\"").Replace("]", "\"");
				IL_27F:
				num2 = 38;
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.DataTable.ConnectionName].oO0_0.o.();
				IL_29E:
				num2 = 39;
				httpClient.Select = text4;
				IL_2AA:
				num2 = 40;
				httpClient.FormData.Add("Action", 13.ToString());
				IL_2C9:
				num2 = 41;
				bool file = httpClient.GetFile(FileName);
				IL_2D6:
				num2 = 42;
				result = file;
				IL_2DC:
				goto IL_3DA;
				IL_2E1:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_39B:
				goto IL_3CF;
				IL_39D:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_3AD:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_39D;
			}
			IL_3CF:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3DA:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		/// <summary>
		/// 向二进制列中插入文件
		/// </summary>
		/// <param name="Field">列名</param>
		/// <param name="FileName">文件名</param>
		// Token: 0x0600238A RID: 9098 RVA: 0x000FC448 File Offset: 0x000FA648
		[oO0oooo("2951")]
		public bool SQLInsertFile(string Field, string FileName)
		{
			int num;
			bool result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.OO0._o_00000.())
				{
					goto IL_1A;
				}
				IL_11:
				num2 = 3;
				result = false;
				goto IL_2E0;
				IL_1A:
				num2 = 4;
				if (Operators.CompareString(this.DataTable.DataServer, "", true) != 0)
				{
					goto IL_1A7;
				}
				IL_37:
				num2 = 5;
				FileStream fileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
				IL_43:
				num2 = 6;
				BinaryReader binaryReader = new BinaryReader(fileStream);
				IL_4E:
				num2 = 7;
				binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
				IL_60:
				num2 = 8;
				byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
				IL_78:
				num2 = 9;
				OleDbConnection oleDbConnection = this.DataTable.frd_Connection;
				IL_88:
				num2 = 10;
				string o._OOO0oOo0__. = this.DataTable.o._OOO0oOo0__.;
				IL_98:
				num2 = 11;
				string text = string.Concat(new string[]
				{
					"Update [",
					o._OOO0oOo0__.,
					"] Set [",
					Field,
					"] = ? Where ",
					this.OO0._o_00000.()
				});
				IL_D2:
				num2 = 12;
				if (this.DataTable.DataServerType != DataServerTypeEnum.Oracle)
				{
					goto IL_108;
				}
				IL_E3:
				num2 = 13;
				text = text.Replace("[", "\"").Replace("]", "\"");
				IL_108:
				num2 = 14;
				OleDbCommand oleDbCommand = new OleDbCommand(text, oleDbConnection);
				IL_116:
				num2 = 15;
				oleDbCommand.Parameters.Add("@" + Field, OleDbType.Binary, array.Length).Value = array;
				IL_140:
				num2 = 16;
				oleDbConnection.Open();
				IL_14A:
				num2 = 17;
				oleDbCommand.ExecuteNonQuery();
				IL_155:
				num2 = 18;
				oleDbConnection.Close();
				IL_15F:
				num2 = 19;
				fileStream.Close();
				IL_169:
				num2 = 20;
				if (Information.Err().Number == 0)
				{
					goto IL_19D;
				}
				IL_178:
				num2 = 21;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_193:
				num2 = 22;
				result = false;
				goto IL_2E0;
				IL_19D:
				num2 = 24;
				result = true;
				goto IL_2E0;
				IL_1A7:
				num2 = 26;
				if (Operators.CompareString(this.DataTable.UpdateServer, "", true) <= 0)
				{
					goto IL_2E0;
				}
				IL_1C6:
				num2 = 27;
				string text2 = Oo00.o.Oo0oO.(this.DataTable.HttpSelect);
				IL_1DB:
				num2 = 28;
				string text3 = string.Concat(new string[]
				{
					"Update ",
					text2,
					" Set [",
					Field,
					"] = ? Where ",
					this.OO0._o_00000.()
				});
				IL_215:
				num2 = 29;
				if (this.DataTable.DataServerType != DataServerTypeEnum.Oracle)
				{
					goto IL_24B;
				}
				IL_226:
				num2 = 30;
				text3 = text3.Replace("[", "\"").Replace("]", "\"");
				IL_24B:
				num2 = 31;
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.DataTable.ConnectionName].oO0_0.o.();
				IL_26A:
				num2 = 32;
				httpClient.Select = text3;
				IL_276:
				num2 = 33;
				httpClient.FormData.Add("Action", 14.ToString());
				IL_295:
				num2 = 34;
				httpClient.Files.Add("InsertFile", FileName);
				IL_2AA:
				num2 = 35;
				object data = httpClient.GetData();
				IL_2B6:
				num2 = 36;
				if (data == null || Conversion.Val(RuntimeHelpers.GetObjectValue(data)) != 1.0)
				{
					goto IL_2DB;
				}
				IL_2D4:
				num2 = 37;
				result = true;
				goto IL_2E0;
				IL_2DB:
				num2 = 39;
				result = false;
				IL_2E0:
				goto IL_3D2;
				IL_2E5:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_393:
				goto IL_3C7;
				IL_395:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_3A5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_395;
			}
			IL_3C7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3D2:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		/// <summary>
		/// 从后台某列提取数据
		/// </summary>
		/// <param name="Field">列名</param>
		/// <param name="Value">值</param>
		// Token: 0x0600238B RID: 9099 RVA: 0x000FC84C File Offset: 0x000FAA4C
		[oO0oooo("2956")]
		public bool SQLSetValue(string Field, object Value)
		{
			int num;
			bool result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.OO0._o_00000.())
				{
					goto IL_1A;
				}
				IL_11:
				num2 = 3;
				result = false;
				goto IL_348;
				IL_1A:
				num2 = 4;
				OleDbConnection oleDbConnection = null;
				IL_1F:
				num2 = 5;
				if (Operators.CompareString(this.DataTable.DataServer, "", true) <= 0)
				{
					goto IL_62;
				}
				IL_3A:
				num2 = 6;
				bool flag = this.DataTable.DataServerType == DataServerTypeEnum.SqlServer;
				IL_4C:
				num2 = 7;
				string text = Oo00.oo_0__0.o.(this.DataTable.HttpSelect);
				goto IL_8E;
				IL_62:
				num2 = 9;
				oleDbConnection = this.DataTable.frd_Connection;
				IL_72:
				num2 = 10;
				text = this.DataTable.o._OOO0oOo0__.;
				IL_82:
				num2 = 11;
				flag = o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection);
				IL_8E:
				num2 = 12;
				if (text.StartsWith("("))
				{
					goto IL_D4;
				}
				IL_9F:
				num2 = 14;
				if (text.StartsWith("[") || text.EndsWith("]"))
				{
					goto IL_D4;
				}
				IL_BE:
				num2 = 15;
				text = "[" + text + "]";
				IL_D4:
				num2 = 16;
				string text2 = string.Concat(new string[]
				{
					"Update ",
					text,
					" Set [",
					Field,
					"] = ??? Where ",
					this.OO0._o_00000.()
				});
				IL_10E:
				num2 = 17;
				if (this.DataTable.DataServerType != DataServerTypeEnum.Oracle)
				{
					goto IL_144;
				}
				IL_11F:
				num2 = 18;
				text2 = text2.Replace("[", "\"").Replace("]", "\"");
				IL_144:
				num2 = 19;
				if (Value != null)
				{
					goto IL_165;
				}
				IL_14A:
				num2 = 20;
				text2 = text2.Replace("???", "Null");
				goto IL_228;
				IL_165:
				num2 = 22;
				if (Value.GetType() != typeof(string))
				{
					goto IL_1A5;
				}
				IL_17A:
				num2 = 23;
				text2 = text2.Replace("???", "'" + Value.ToString() + "'");
				goto IL_228;
				IL_1A5:
				num2 = 25;
				if (Value.GetType() != typeof(DateTime))
				{
					goto IL_211;
				}
				IL_1BA:
				num2 = 26;
				if (!flag)
				{
					goto IL_1E9;
				}
				IL_1C1:
				num2 = 27;
				text2 = text2.Replace("???", "'" + Value.ToString() + "'");
				goto IL_228;
				IL_1E9:
				num2 = 29;
				text2 = text2.Replace("???", "#" + Value.ToString() + "#");
				goto IL_228;
				IL_211:
				num2 = 31;
				text2 = text2.Replace("???", Value.ToString());
				IL_228:
				num2 = 32;
				if (Operators.CompareString(this.DataTable.DataServer, "", true) != 0)
				{
					goto IL_2AE;
				}
				IL_243:
				num2 = 33;
				OleDbCommand oleDbCommand = new OleDbCommand(text2, oleDbConnection);
				IL_251:
				num2 = 34;
				oleDbConnection.Open();
				IL_25B:
				num2 = 35;
				oleDbCommand.ExecuteNonQuery();
				IL_266:
				num2 = 36;
				oleDbConnection.Close();
				IL_270:
				num2 = 37;
				if (Information.Err().Number == 0)
				{
					goto IL_2A4;
				}
				IL_27F:
				num2 = 38;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_29A:
				num2 = 39;
				result = false;
				goto IL_348;
				IL_2A4:
				num2 = 41;
				result = true;
				goto IL_348;
				IL_2AE:
				num2 = 43;
				if (Operators.CompareString(this.DataTable.UpdateServer, "", true) <= 0)
				{
					goto IL_348;
				}
				IL_2CA:
				num2 = 44;
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.DataTable.ConnectionName].oO0_0.o.();
				IL_2E9:
				num2 = 45;
				httpClient.Select = text2;
				IL_2F5:
				num2 = 46;
				httpClient.FormData.Add("Action", 7.ToString());
				IL_313:
				num2 = 47;
				object data = httpClient.GetData();
				IL_31F:
				num2 = 48;
				if (data == null)
				{
					goto IL_343;
				}
				IL_326:
				num2 = 49;
				result = (Conversion.Val(RuntimeHelpers.GetObjectValue(data)) == 1.0);
				goto IL_348;
				IL_343:
				num2 = 51;
				result = false;
				IL_348:
				goto IL_46A;
				IL_34D:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_42B:
				goto IL_45F;
				IL_42D:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_43D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_42D;
			}
			IL_45F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_46A:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		/// <summary>
		/// 从后台某列提取数据
		/// </summary>
		/// <param name="Field">列名</param>
		// Token: 0x0600238C RID: 9100 RVA: 0x000FCCE8 File Offset: 0x000FAEE8
		[oO0oooo("2955")]
		public object SQLGetValue(string Field)
		{
			int num;
			object result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.OO0._o_00000.())
				{
					goto IL_1A;
				}
				IL_11:
				num2 = 3;
				result = null;
				goto IL_25F;
				IL_1A:
				num2 = 4;
				if (Operators.CompareString(this.DataTable.DataServer, "", true) != 0)
				{
					goto IL_17F;
				}
				IL_37:
				num2 = 5;
				OleDbConnection oleDbConnection = this.DataTable.frd_Connection;
				IL_46:
				num2 = 6;
				string text = this.DataTable.o._OOO0oOo0__.;
				IL_55:
				num2 = 7;
				if (Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_7E;
				}
				IL_67:
				num2 = 8;
				text = "[" + text + "]";
				goto IL_9D;
				IL_7E:
				num2 = 10;
				text = Oo00.oo_0__0.o.(this.DataTable._Adapter.SelectCommand.CommandText);
				IL_9D:
				num2 = 11;
				string text2 = string.Concat(new string[]
				{
					" Select [",
					Field,
					"] From ",
					text,
					" Where ",
					this.OO0._o_00000.()
				});
				IL_D7:
				num2 = 12;
				if (this.DataTable.DataServerType != DataServerTypeEnum.Oracle)
				{
					goto IL_10D;
				}
				IL_E8:
				num2 = 13;
				text2 = text2.Replace("[", "\"").Replace("]", "\"");
				IL_10D:
				num2 = 14;
				OleDbCommand oleDbCommand = new OleDbCommand(text2, oleDbConnection);
				IL_11B:
				num2 = 15;
				oleDbConnection.Open();
				IL_125:
				num2 = 16;
				object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
				IL_136:
				num2 = 17;
				oleDbConnection.Close();
				IL_140:
				num2 = 18;
				if (Information.Err().Number == 0)
				{
					goto IL_174;
				}
				IL_14F:
				num2 = 19;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_16A:
				num2 = 20;
				result = null;
				goto IL_25F;
				IL_174:
				num2 = 22;
				result = objectValue;
				goto IL_25F;
				IL_17F:
				num2 = 24;
				string text3 = Oo00.oo_0__0.o.(this.DataTable.HttpSelect);
				IL_194:
				num2 = 25;
				string text4 = string.Concat(new string[]
				{
					"Select [",
					Field,
					"] From ",
					text3,
					" Where ",
					this.OO0._o_00000.()
				});
				IL_1CE:
				num2 = 26;
				if (this.DataTable.DataServerType != DataServerTypeEnum.Oracle)
				{
					goto IL_204;
				}
				IL_1DF:
				num2 = 27;
				text4 = text4.Replace("[", "\"").Replace("]", "\"");
				IL_204:
				num2 = 28;
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.DataTable.ConnectionName].oO0_0.o.();
				IL_223:
				num2 = 29;
				httpClient.Select = text4;
				IL_22F:
				num2 = 30;
				httpClient.FormData.Add("Action", 6.ToString());
				IL_24D:
				num2 = 31;
				object data = httpClient.GetData();
				IL_259:
				num2 = 32;
				result = data;
				IL_25F:
				goto IL_335;
				IL_264:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2F6:
				goto IL_32A;
				IL_2F8:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_308:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2F8;
			}
			IL_32A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_335:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x000FD050 File Offset: 0x000FB250
		private string <<EMPTY_NAME>>()
		{
			int num;
			string result;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.OO0._o_00000. == null)
				{
					goto IL_22;
				}
				IL_11:
				num2 = 3;
				DataTable dataTable = this.OO0._o_00000..BaseTable;
				goto IL_31;
				IL_22:
				num2 = 5;
				dataTable = this.OO0._o_00000..Table;
				IL_31:
				num2 = 6;
				if (Operators.CompareString(this.DataTable.DataServer, "", true) <= 0)
				{
					goto IL_60;
				}
				IL_4C:
				num2 = 7;
				bool flag = this.DataTable.DataServerType == DataServerTypeEnum.SqlServer;
				goto IL_7C;
				IL_60:
				num2 = 9;
				OleDbConnection a_ = this.DataTable.frd_Connection;
				IL_70:
				num2 = 10;
				flag = o_O_o_oOoo__.OOOO_OO._oo.(a_);
				IL_7C:
				num2 = 11;
				StringBuilder stringBuilder = new StringBuilder();
				IL_86:
				num2 = 12;
				int num3 = dataTable.PrimaryKey.Length - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_9E:
					num2 = 13;
					if (stringBuilder.Length > 0)
					{
						IL_AB:
						num2 = 14;
						stringBuilder.Append(" And ");
					}
					IL_BB:
					num2 = 15;
					if (dataTable.PrimaryKey[i].DataType == typeof(string))
					{
						IL_D9:
						num2 = 16;
						stringBuilder.Append(string.Concat(new string[]
						{
							"[",
							dataTable.PrimaryKey[i].ColumnName,
							"] = '",
							this.OO0._o_00000.[dataTable.PrimaryKey[i].ColumnName].ToString(),
							"'"
						}));
					}
					else
					{
						IL_140:
						num2 = 18;
						if (dataTable.PrimaryKey[i].DataType == typeof(DateTime))
						{
							IL_161:
							num2 = 19;
							if (flag)
							{
								IL_168:
								num2 = 20;
								stringBuilder.Append(string.Concat(new string[]
								{
									"[",
									dataTable.PrimaryKey[i].ColumnName,
									"] = '",
									this.OO0._o_00000.[dataTable.PrimaryKey[i].ColumnName].ToString(),
									"'"
								}));
							}
							else
							{
								IL_1CF:
								num2 = 22;
								stringBuilder.Append(string.Concat(new string[]
								{
									"[",
									dataTable.PrimaryKey[i].ColumnName,
									"] = #",
									this.OO0._o_00000.[dataTable.PrimaryKey[i].ColumnName].ToString(),
									"#"
								}));
							}
						}
						else
						{
							IL_233:
							num2 = 24;
							stringBuilder.Append("[" + dataTable.PrimaryKey[i].ColumnName + "] = " + this.OO0._o_00000.[dataTable.PrimaryKey[i].ColumnName].ToString());
						}
					}
					IL_27B:
					num2 = 25;
				}
				IL_28D:
				num2 = 26;
				result = stringBuilder.ToString();
				IL_298:
				goto IL_356;
				IL_29D:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_317:
				goto IL_34B;
				IL_319:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_329:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_319;
			}
			IL_34B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_356:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x000FD3D8 File Offset: 0x000FB5D8
		private bool <<EMPTY_NAME>>()
		{
			bool result;
			if (this.OO0._o_00000..RowState == DataRowState.Added)
			{
				MessageBox.Show("新增行必须先保存,才能提取或设置后台数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x000FD40D File Offset: 0x000FB60D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>()
		{
			this.OO0._o_00000..EndEdit();
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x000FD41C File Offset: 0x000FB61C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object GetValue(string colname)
		{
			DataRow baseRow = this.BaseRow;
			object result;
			if (baseRow == null)
			{
				result = null;
			}
			else if (!OO_00oOO.Tables.get_Contains(this.DataTable.Name))
			{
				result = baseRow[colname];
			}
			else
			{
				Table table = OO_00oOO.Tables[this.DataTable.Name];
				if (table.GridTreeVisible && table.o.0ooOO_0__..Contains(colname))
				{
					if (table.o.0ooOO_0__..ContainsKey(baseRow))
					{
						result = table.o.0ooOO_0__.[baseRow][colname];
					}
					else
					{
						result = baseRow[colname];
					}
				}
				else
				{
					result = baseRow[colname];
				}
			}
			return result;
		}

		// Token: 0x04000EB2 RID: 3762
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04000EB3 RID: 3763
		internal DataTable <<EMPTY_NAME>>;

		// Token: 0x04000EB4 RID: 3764
		private bool <<EMPTY_NAME>>;
	}
}
