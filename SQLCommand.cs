using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace Foxtable
{
	/// <summary>
	/// 用于执行SQL语句
	/// </summary>
	// Token: 0x0200029D RID: 669
	[oO0oooo("0696")]
	[ComVisible(true)]
	public class SQLCommand
	{
		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x000F0E77 File Offset: 0x000EF077
		// (set) Token: 0x060021E4 RID: 8676 RVA: 0x000F0E7F File Offset: 0x000EF07F
		public bool ThrowException { get; set; }

		// Token: 0x060021E5 RID: 8677 RVA: 0x000F0E88 File Offset: 0x000EF088
		public SQLCommand()
		{
			this.OO__00.__. = 30;
			this.Oo_oO00.0_. = new oooOo_0oo();
			this.ThrowException = false;
		}

		/// <summary>
		/// 开始事务
		/// </summary>
		// Token: 0x060021E6 RID: 8678 RVA: 0x000F0EAC File Offset: 0x000EF0AC
		[oO0oooo("3312")]
		public void BeginTransaction()
		{
			OleDbConnection oleDbConnection = null;
			O0O o0O = null;
			this.O_O_Oo00o_.00_.(ref oleDbConnection, ref o0O);
			if (oleDbConnection != null)
			{
				if (!this.AsyncExecute || o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection))
				{
					this.OO__00.__. = new OleDbConnection(oleDbConnection.ConnectionString);
					this.OO__00.__..Open();
					this.Oo_oO00.0_. = this.OO__00.__..BeginTransaction();
					return;
				}
				throw new NotSupportedException("只有SQL Server数据源才支持多线程事务!");
			}
			else
			{
				if (o0O != null)
				{
					throw new NotSupportedException("WEB数据源不支持事务!");
				}
				return;
			}
		}

		/// <summary>
		/// 提交事务
		/// </summary>
		// Token: 0x060021E7 RID: 8679 RVA: 0x000F0F21 File Offset: 0x000EF121
		[oO0oooo("3312")]
		public void Commit()
		{
			if (this.OO__00.__. != null)
			{
				if (this.Oo_oO00.0_. != null)
				{
					this.Oo_oO00.0_..Commit();
					this.Oo_oO00.0_. = null;
				}
				this.OO__00.__..Close();
				this.OO__00.__. = null;
			}
		}

		/// <summary>
		/// 回滚事务
		/// </summary>
		// Token: 0x060021E8 RID: 8680 RVA: 0x000F0F57 File Offset: 0x000EF157
		[oO0oooo("3312")]
		public void Rollback()
		{
			if (this.OO__00.__. != null)
			{
				if (this.Oo_oO00.0_. != null)
				{
					this.Oo_oO00.0_..Rollback();
					this.Oo_oO00.0_. = null;
				}
				this.OO__00.__..Close();
				this.OO__00.__. = null;
			}
		}

		/// <param name="CommandText">要执行的SQL语句</param>
		// Token: 0x060021E9 RID: 8681 RVA: 0x000F0F8D File Offset: 0x000EF18D
		public SQLCommand(string A_0)
		{
			this.OO__00.__. = 30;
			this.Oo_oO00.0_. = new oooOo_0oo();
			this.ThrowException = false;
			this.Oo._000O0O0. = A_0;
		}

		/// <param name="CommandText">要执行的SQL语句</param>
		/// <param name="ConnectionName">数据源名称</param>
		// Token: 0x060021EA RID: 8682 RVA: 0x000F0FB6 File Offset: 0x000EF1B6
		public SQLCommand(string A_0, string A_1)
		{
			this.OO__00.__. = 30;
			this.Oo_oO00.0_. = new oooOo_0oo();
			this.ThrowException = false;
			this.Oo._000O0O0. = A_0;
			this.OO__00.__. = A_1;
		}

		/// <summary>
		/// 数据源名称
		/// </summary>
		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060021EB RID: 8683 RVA: 0x000F0FE6 File Offset: 0x000EF1E6
		// (set) Token: 0x060021EC RID: 8684 RVA: 0x000F0FEE File Offset: 0x000EF1EE
		public string ConnectionName
		{
			get
			{
				return this.OO__00.__.;
			}
			set
			{
				this.OO__00.__. = value;
			}
		}

		/// <summary>
		/// SQL语句
		/// </summary>
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x000F0FF7 File Offset: 0x000EF1F7
		// (set) Token: 0x060021EE RID: 8686 RVA: 0x000F0FFF File Offset: 0x000EF1FF
		public string CommandText
		{
			get
			{
				return this.Oo._000O0O0.;
			}
			set
			{
				this.Oo._000O0O0. = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060021EF RID: 8687 RVA: 0x000F1008 File Offset: 0x000EF208
		internal bool AsyncExecute
		{
			get
			{
				return Thread.CurrentThread.ManagedThreadId != Main.OO_O.o.;
			}
		}

		/// <summary>
		/// 参数集合
		/// </summary>
		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x000F101E File Offset: 0x000EF21E
		[oO0oooo("3266")]
		public oooOo_0oo Parameters
		{
			get
			{
				return this.Oo_oO00.0_.;
			}
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x000F1028 File Offset: 0x000EF228
		private void <<EMPTY_NAME>>(ref OleDbConnection A_0, ref O0O A_1)
		{
			if (Operators.CompareString(this.ConnectionName, "", true) == 0)
			{
				A_0 = O_O0OO.OoO.0OO__0ooo.();
				return;
			}
			if (O_O0OO.O._o_.().ContainsKey(this.ConnectionName))
			{
				A_0 = O_O0OO.O._o_.()[this.ConnectionName];
				return;
			}
			if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.ConnectionName))
			{
				A_1 = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName];
				return;
			}
			MessageBox.Show("指定的数据源名称\"" + this.ConnectionName + "\"错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		/// <summary>
		/// 用于执行返回单个值的命令
		/// </summary>
		// Token: 0x060021F2 RID: 8690 RVA: 0x000F10C0 File Offset: 0x000EF2C0
		public object ExecuteScalar()
		{
			object result;
			if (this.OO__00.__. != null)
			{
				result = this.ExecuteScalar2();
			}
			else
			{
				OleDbConnection oleDbConnection = null;
				O0O o0O = null;
				this.O_O_Oo00o_.00_.(ref oleDbConnection, ref o0O);
				if (oleDbConnection != null)
				{
					if (oleDbConnection != O_O0OO.OoO.0OO__0ooo.() && !this.AsyncExecute && this.OO__00.__. == null && O_O0OO.O._o_.().ContainsKey(this.ConnectionName) && OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbConnection))
					{
						result = this.ExecuteScalar2();
					}
					else
					{
						OleDbCommand oleDbCommand = this.O_O_Oo00o_.00_.();
						if (oleDbCommand != null)
						{
							ConnectionState state = oleDbCommand.Connection.State;
							try
							{
								if (oleDbCommand.Connection.State != ConnectionState.Open)
								{
									oleDbCommand.Connection.Open();
								}
								object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
								this.OO__00.__.(oleDbCommand);
								if (objectValue == DBNull.Value)
								{
									return null;
								}
								return objectValue;
							}
							catch (Exception ex)
							{
								if (this.ThrowException)
								{
									if (ex.InnerException != null)
									{
										throw ex.InnerException;
									}
									throw ex;
								}
								else
								{
									ooO.oOo0Oo.o.(ex, "");
								}
							}
							finally
							{
								if (this.OO__00.__. == null)
								{
									if (this.AsyncExecute)
									{
										oleDbCommand.Connection.Close();
									}
									else if (state != ConnectionState.Open && !OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbCommand.Connection))
									{
										oleDbCommand.Connection.Close();
									}
								}
							}
						}
						result = null;
					}
				}
				else if (o0O != null)
				{
					this.Oo_oO00.0_. = o0O.oO0_0.o.();
					this.CommandText = Oo00.o0_o._O_.(o0O.OO.OoO0., this.CommandText, false);
					this.O_O_Oo00o_.00_.();
					this.Oo_oO00.0_..FormData["Action"] = 15.ToString();
					this.Oo_oO00.0_..Select = this.CommandText;
					if (this.CommandTimeOut != 30)
					{
						this.Oo_oO00.0_..ReadWriteTimeout = this.CommandTimeOut;
					}
					if (this.StoredProcedure)
					{
						this.Oo_oO00.0_..FormData["StoredProcedure"] = "True";
					}
					DataSet dataSet = this.Oo_oO00.0_..oOO.__.();
					if (dataSet != null && dataSet.Tables.Count > 0)
					{
						DataTable dataTable = dataSet.Tables[0];
						DataRow dataRow = dataTable.Rows[0];
						int num = dataTable.Columns.Count - 1;
						for (int i = 1; i <= num; i++)
						{
							DataColumn dataColumn = dataTable.Columns[i];
							if (dataRow.IsNull(dataColumn))
							{
								this.Parameters[dataColumn.ColumnName] = null;
							}
							else
							{
								this.Parameters[dataColumn.ColumnName] = RuntimeHelpers.GetObjectValue(dataRow[dataColumn]);
							}
						}
						if (dataRow.IsNull(0))
						{
							result = null;
						}
						else
						{
							result = dataRow[0];
						}
					}
					else
					{
						result = null;
					}
				}
			}
			return result;
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x000F13AC File Offset: 0x000EF5AC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object ExecuteScalar2()
		{
			OleDbCommand oleDbCommand = this.O_O_Oo00o_.00_.();
			object result;
			if (oleDbCommand != null)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
				if (objectValue == DBNull.Value)
				{
					result = null;
				}
				else
				{
					result = objectValue;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		/// <summary>
		/// 用于执行不返回任何值的SQL命令，例如DELETE和UPDATE命令
		/// </summary>
		// Token: 0x060021F4 RID: 8692 RVA: 0x000F13E4 File Offset: 0x000EF5E4
		public int ExecuteNonQuery()
		{
			int result;
			if (this.OO__00.__. != null)
			{
				result = this.ExecuteNonQuery2();
			}
			else
			{
				OleDbConnection oleDbConnection = null;
				O0O o0O = null;
				this.O_O_Oo00o_.00_.(ref oleDbConnection, ref o0O);
				if (oleDbConnection != null)
				{
					if (oleDbConnection != O_O0OO.OoO.0OO__0ooo.() && !this.AsyncExecute && this.OO__00.__. == null && O_O0OO.O._o_.().ContainsKey(this.ConnectionName) && OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbConnection))
					{
						result = this.ExecuteNonQuery2();
					}
					else
					{
						OleDbCommand oleDbCommand = this.O_O_Oo00o_.00_.();
						if (oleDbCommand != null)
						{
							ConnectionState state = oleDbCommand.Connection.State;
							try
							{
								if (oleDbCommand.Connection.State != ConnectionState.Open)
								{
									oleDbCommand.Connection.Open();
								}
								int result2 = oleDbCommand.ExecuteNonQuery();
								this.OO__00.__.(oleDbCommand);
								return result2;
							}
							catch (Exception ex)
							{
								if (this.ThrowException)
								{
									if (ex.InnerException != null)
									{
										throw ex.InnerException;
									}
									throw ex;
								}
								else
								{
									ooO.oOo0Oo.o.(ex, "");
								}
							}
							finally
							{
								if (this.OO__00.__. == null)
								{
									if (this.AsyncExecute)
									{
										oleDbCommand.Connection.Close();
									}
									else if (state != ConnectionState.Open && !OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbCommand.Connection))
									{
										oleDbCommand.Connection.Close();
									}
								}
							}
						}
						result = -1;
					}
				}
				else if (o0O != null)
				{
					this.Oo_oO00.0_. = o0O.oO0_0.o.();
					this.CommandText = Oo00.o0_o._O_.(o0O.OO.OoO0., this.CommandText, false);
					this.O_O_Oo00o_.00_.();
					this.Oo_oO00.0_..FormData["Action"] = 16.ToString();
					this.Oo_oO00.0_..Select = this.CommandText;
					if (this.CommandTimeOut != 30)
					{
						this.Oo_oO00.0_..ReadWriteTimeout = this.CommandTimeOut;
					}
					if (this.StoredProcedure)
					{
						this.Oo_oO00.0_..FormData["StoredProcedure"] = "True";
					}
					DataSet dataSet = this.Oo_oO00.0_..oOO.__.();
					if (dataSet != null && dataSet.Tables.Count > 0)
					{
						DataTable dataTable = dataSet.Tables[0];
						DataRow dataRow = dataTable.Rows[0];
						int num = dataTable.Columns.Count - 1;
						for (int i = 1; i <= num; i++)
						{
							DataColumn dataColumn = dataTable.Columns[i];
							if (dataRow.IsNull(dataColumn))
							{
								this.Parameters[dataColumn.ColumnName] = null;
							}
							else
							{
								this.Parameters[dataColumn.ColumnName] = RuntimeHelpers.GetObjectValue(dataRow[dataColumn]);
							}
						}
						if (dataRow.IsNull(0))
						{
							result = 0;
						}
						else
						{
							result = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow[0])));
						}
					}
					else
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x000F16C8 File Offset: 0x000EF8C8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int ExecuteNonQuery2()
		{
			OleDbCommand oleDbCommand = this.O_O_Oo00o_.00_.();
			int result;
			if (oleDbCommand != null)
			{
				result = oleDbCommand.ExecuteNonQuery();
			}
			return result;
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x000F16E8 File Offset: 0x000EF8E8
		private void <<EMPTY_NAME>>(DataTable A_0)
		{
			if (A_0.PrimaryKey.Length == 1 && Operators.CompareString(A_0.PrimaryKey[0].ColumnName, "_Identify", true) == 0)
			{
				A_0.Columns["_Identify"].AutoIncrement = true;
				A_0.Columns["_Identify"].AutoIncrementStep = 1L;
				A_0.Columns["_Identify"].AutoIncrementSeed = 1L;
				if (A_0.Rows.Count > 0 && A_0.Rows.Count > 0)
				{
					A_0.Columns["_Identify"].AutoIncrementSeed = (long)(Conversions.ToInteger(A_0.Compute("Max([_Identify])", "")) + 1);
				}
			}
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x000F17B0 File Offset: 0x000EF9B0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataTable <<EMPTY_NAME>>(bool A_0 = false)
		{
			DataTable dataTable = new DataTable();
			OleDbCommand oleDbCommand = this.O_O_Oo00o_.00_.(A_0);
			string a_ = "";
			DataTable result;
			if (oleDbCommand == null)
			{
				result = null;
			}
			else
			{
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
				if (A_0)
				{
					oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				}
				oleDbDataAdapter.Fill(dataTable);
				this.OO__00.__.(oleDbCommand);
				if (A_0)
				{
					o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter);
					if (dataTable.PrimaryKey.Length > 0)
					{
						dataTable.PrimaryKey[0].ReadOnly = false;
					}
					a_ = oleDbDataAdapter.UpdateCommand.CommandText.Split(new char[]
					{
						' '
					}, StringSplitOptions.RemoveEmptyEntries)[1].Trim(new char[]
					{
						'[',
						']',
						'"'
					});
				}
				DataTable dataTable2 = new DataTable(dataTable, oleDbDataAdapter, oleDbCommand.Connection, a_, O_O0OO.OoO.0OO__0ooo.());
				dataTable2.o.OOO_oO0_0O_o. = true;
				dataTable2.AddByCode = true;
				dataTable2.o.0O000_.();
				if (A_0 & Operators.CompareString(this.OO__00.__., "", true) == 0)
				{
					dataTable2.oOo.oO. = true;
					this.Oo._000O0O0.(dataTable);
				}
				result = dataTable2;
			}
			return result;
		}

		/// <summary>
		/// 用于执行Select语句并返回一个临时的DataTable
		/// </summary>
		/// <param name="Save">生成的DataTable是否可以编辑保存</param>
		// Token: 0x060021F8 RID: 8696 RVA: 0x000F18B4 File Offset: 0x000EFAB4
		public DataTable ExecuteReader(bool Save = false)
		{
			DataTable result;
			if (this.OO__00.__. != null)
			{
				result = this.O_O_Oo00o_.00_.(Save);
			}
			else
			{
				OleDbConnection oleDbConnection = null;
				O0O o0O = null;
				this.O_O_Oo00o_.00_.(ref oleDbConnection, ref o0O);
				if (oleDbConnection != null)
				{
					DataTable dataTable = new DataTable();
					OleDbCommand oleDbCommand = this.O_O_Oo00o_.00_.(Save);
					string a_ = "";
					if (oleDbCommand == null)
					{
						result = null;
					}
					else
					{
						OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
						try
						{
							if (Save)
							{
								oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
							}
							oleDbDataAdapter.Fill(dataTable);
							this.OO__00.__.(oleDbCommand);
						}
						catch (Exception ex)
						{
							if (!this.ThrowException)
							{
								ooO.oOo0Oo.o.(ex, "");
								return null;
							}
							if (ex.InnerException != null)
							{
								throw ex.InnerException;
							}
							throw ex;
						}
						finally
						{
							if (this.OO__00.__. == null && this.AsyncExecute)
							{
								oleDbCommand.Connection.Close();
							}
						}
						if (Save)
						{
							o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter);
							if (dataTable.PrimaryKey.Length > 0)
							{
								dataTable.PrimaryKey[0].ReadOnly = false;
							}
							a_ = oleDbDataAdapter.UpdateCommand.CommandText.Split(new char[]
							{
								' '
							}, StringSplitOptions.RemoveEmptyEntries)[1].Trim(new char[]
							{
								'[',
								']',
								'"'
							});
						}
						DataTable dataTable2 = new DataTable(dataTable, oleDbDataAdapter, oleDbCommand.Connection, a_, O_O0OO.OoO.0OO__0ooo.());
						dataTable2.o.OOO_oO0_0O_o. = true;
						dataTable2.AddByCode = true;
						dataTable2.o.0O000_.();
						if (Save & Operators.CompareString(this.OO__00.__., "", true) == 0)
						{
							dataTable2.oOo.oO. = true;
							this.Oo._000O0O0.(dataTable);
						}
						result = dataTable2;
					}
				}
				else
				{
					if (o0O != null)
					{
						this.Oo_oO00.0_. = o0O.oO0_0.o.();
						this.CommandText = Oo00.o0_o._O_.(o0O.OO.OoO0., this.CommandText, false);
						this.O_O_Oo00o_.00_.();
						this.Oo_oO00.0_..FormData["Action"] = 17.ToString();
						this.Oo_oO00.0_..Select = this.CommandText;
						if (this.CommandTimeOut != 30)
						{
							this.Oo_oO00.0_..ReadWriteTimeout = this.CommandTimeOut;
						}
						if (this.StoredProcedure)
						{
							this.Oo_oO00.0_..FormData["StoredProcedure"] = "True";
						}
						if (!Save)
						{
							this.Oo_oO00.0_..FormData["IgnoreSchema"] = "True";
						}
						DataSet dataSet = this.Oo_oO00.0_..oOO.__.();
						if (dataSet != null && dataSet.Tables.Count > 0)
						{
							DataTable dataTable3 = new DataTable(dataSet.Tables[0], null, null, null, null);
							dataTable3.o.OOO_oO0_0O_o. = true;
							dataTable3.AddByCode = true;
							dataTable3.o.0O000_.();
							dataTable3.ConnectionName = this.ConnectionName;
							dataTable3.DataServer = this.Oo_oO00.0_..Oo_0oO0Oo0_.O_.;
							dataTable3.HttpSelect = this.CommandText;
							if (dataSet.Tables.Count > 1)
							{
								DataTable dataTable4 = dataSet.Tables[1];
								DataRow dataRow = dataTable4.Rows[0];
								if (!dataRow.IsNull(0))
								{
									string[] collection = dataRow[0].ToString().Split(new char[]
									{
										'|'
									});
									List<string> list = new List<string>();
									list.AddRange(collection);
									dataTable3.UpdateServer = dataTable3.DataServer;
									dataTable3.UpdateColumns = list;
									string text = Oo00.oo_0__0.o.(this.CommandText);
									dataTable3.o._OOO0oOo0__. = text.Trim(new char[]
									{
										'[',
										']',
										'"'
									});
								}
								int num = dataTable4.Columns.Count - 1;
								for (int i = 1; i <= num; i++)
								{
									DataColumn dataColumn = dataTable4.Columns[i];
									if (dataRow.IsNull(dataColumn))
									{
										this.Parameters[dataColumn.ColumnName] = null;
									}
									else
									{
										this.Parameters[dataColumn.ColumnName] = RuntimeHelpers.GetObjectValue(dataRow[dataColumn]);
									}
								}
							}
							if (Save && dataTable3.BaseTable.PrimaryKey.Length > 0)
							{
								dataTable3.BaseTable.PrimaryKey[0].ReadOnly = false;
							}
							dataSet.Tables.Clear();
							return dataTable3;
						}
					}
					result = null;
				}
			}
			return result;
		}

		/// <summary>
		/// 用于执行一次返回多个值的命令
		/// </summary>
		// Token: 0x060021F9 RID: 8697 RVA: 0x000F1CF8 File Offset: 0x000EFEF8
		public Dictionary<string, object> ExecuteValues()
		{
			return this.ExcuteValues();
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x000F1D00 File Offset: 0x000EFF00
		private Dictionary<string, object> <<EMPTY_NAME>>()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
			OleDbDataReader oleDbDataReader = this.O_O_Oo00o_.00_.().ExecuteReader(CommandBehavior.SingleRow);
			if (oleDbDataReader.HasRows)
			{
				int fieldCount = oleDbDataReader.FieldCount;
				oleDbDataReader.Read();
				int num = fieldCount - 1;
				for (int i = 0; i <= num; i++)
				{
					dictionary.Add(oleDbDataReader.GetName(i), RuntimeHelpers.GetObjectValue(oleDbDataReader[i]));
				}
				oleDbDataReader.Close();
			}
			return dictionary;
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x000F1D6C File Offset: 0x000EFF6C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dictionary<string, object> ExcuteValues()
		{
			Dictionary<string, object> result;
			if (this.OO__00.__. != null)
			{
				result = this.O_O_Oo00o_.00_.();
			}
			else
			{
				OleDbConnection oleDbConnection = null;
				O0O o0O = null;
				this.O_O_Oo00o_.00_.(ref oleDbConnection, ref o0O);
				Dictionary<string, object> dictionary = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
				if (oleDbConnection != null)
				{
					OleDbCommand oleDbCommand = this.O_O_Oo00o_.00_.();
					if (oleDbCommand != null)
					{
						ConnectionState state = oleDbCommand.Connection.State;
						try
						{
							if (oleDbCommand.Connection.State != ConnectionState.Open)
							{
								oleDbCommand.Connection.Open();
							}
							OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.SingleRow);
							if (oleDbDataReader.HasRows)
							{
								int fieldCount = oleDbDataReader.FieldCount;
								oleDbDataReader.Read();
								int num = fieldCount - 1;
								for (int i = 0; i <= num; i++)
								{
									dictionary.Add(oleDbDataReader.GetName(i), RuntimeHelpers.GetObjectValue(oleDbDataReader[i]));
								}
								oleDbDataReader.Close();
							}
						}
						catch (Exception ex)
						{
							if (this.ThrowException)
							{
								if (ex.InnerException != null)
								{
									throw ex.InnerException;
								}
								throw ex;
							}
							else
							{
								ooO.oOo0Oo.o.(ex, "");
							}
						}
						finally
						{
							if (this.OO__00.__. == null)
							{
								if (this.AsyncExecute)
								{
									oleDbCommand.Connection.Close();
								}
								else if (state != ConnectionState.Open && !OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbCommand.Connection))
								{
									oleDbCommand.Connection.Close();
								}
							}
						}
					}
					result = dictionary;
				}
				else if (o0O != null)
				{
					this.Oo_oO00.0_. = o0O.oO0_0.o.();
					this.CommandText = Oo00.o0_o._O_.(o0O.OO.OoO0., this.CommandText, false);
					this.O_O_Oo00o_.00_.();
					this.Oo_oO00.0_..FormData["Action"] = 18.ToString();
					this.Oo_oO00.0_..Select = this.CommandText;
					if (this.CommandTimeOut != 30)
					{
						this.Oo_oO00.0_..ReadWriteTimeout = this.CommandTimeOut;
					}
					if (this.StoredProcedure)
					{
						this.Oo_oO00.0_..FormData["StoredProcedure"] = "True";
					}
					DataSet dataSet = this.Oo_oO00.0_..oOO.__.();
					if (dataSet != null)
					{
						if (dataSet.Tables.Count == 2)
						{
							DataTable dataTable = dataSet.Tables[1];
							DataRow dataRow = dataTable.Rows[0];
							int num2 = dataTable.Columns.Count - 1;
							for (int j = 0; j <= num2; j++)
							{
								DataColumn dataColumn = dataTable.Columns[j];
								if (dataRow.IsNull(dataColumn))
								{
									this.Parameters[dataColumn.ColumnName] = null;
								}
								else
								{
									this.Parameters[dataColumn.ColumnName] = RuntimeHelpers.GetObjectValue(dataRow[dataColumn]);
								}
							}
						}
						if (dataSet.Tables.Count > 0)
						{
							DataTable dataTable2 = dataSet.Tables[0];
							DataRow dataRow2 = dataTable2.Rows[0];
							try
							{
								foreach (object obj in dataTable2.Columns)
								{
									DataColumn dataColumn2 = (DataColumn)obj;
									if (dataRow2.IsNull(dataColumn2))
									{
										dictionary.Add(dataColumn2.ColumnName, null);
									}
									else
									{
										dictionary.Add(dataColumn2.ColumnName, RuntimeHelpers.GetObjectValue(dataRow2[dataColumn2]));
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
					}
					result = dictionary;
				}
			}
			return result;
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x000F20EC File Offset: 0x000F02EC
		internal DataTable <<EMPTY_NAME>>()
		{
			OleDbConnection oleDbConnection = null;
			O0O o0O = null;
			this.O_O_Oo00o_.00_.(ref oleDbConnection, ref o0O);
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = null;
			if (oleDbConnection != null)
			{
				OleDbCommand oleDbCommand = this.O_O_Oo00o_.00_.();
				if (oleDbCommand == null)
				{
					return null;
				}
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
				try
				{
					oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
					return null;
				}
				finally
				{
					if (this.OO__00.__. == null && this.AsyncExecute)
					{
						oleDbCommand.Connection.Close();
					}
				}
				dataTable2 = new DataTable(dataTable, null, null, null, null);
			}
			else if (o0O != null)
			{
				this.Oo_oO00.0_. = o0O.oO0_0.o.();
				this.CommandText = Oo00.o0_o._O_.(o0O.OO.OoO0., this.CommandText, false);
				this.Oo_oO00.0_..FormData["Action"] = 12.ToString();
				this.Oo_oO00.0_..Select = this.CommandText;
				if (this.CommandTimeOut != 30)
				{
					this.Oo_oO00.0_..ReadWriteTimeout = this.CommandTimeOut;
				}
				this.Oo_oO00.0_..FormData["IgnoreSchema"] = "True";
				dataTable = this.Oo_oO00.0_..GetBaseDataTable();
				dataTable2 = new DataTable(dataTable, null, null, null, null);
			}
			dataTable2.AddByCode = true;
			dataTable2.o.0O000_.();
			return dataTable2;
		}

		/// <summary>
		/// 是否是存储过程
		/// </summary>
		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x000F2260 File Offset: 0x000F0460
		// (set) Token: 0x060021FE RID: 8702 RVA: 0x000F2268 File Offset: 0x000F0468
		[oO0oooo("3267")]
		public bool StoredProcedure
		{
			get
			{
				return this.Oo_oO00.0_.;
			}
			set
			{
				this.Oo_oO00.0_. = value;
			}
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x000F2271 File Offset: 0x000F0471
		private OleDbCommand <<EMPTY_NAME>>()
		{
			return this.O_O_Oo00o_.00_.(false);
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x000F227C File Offset: 0x000F047C
		private OleDbCommand <<EMPTY_NAME>>(bool A_0 = false)
		{
			int num;
			OleDbCommand result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				OleDbCommand oleDbCommand = new OleDbCommand();
				IL_10:
				num2 = 3;
				OleDbConnection oleDbConnection = null;
				IL_15:
				num2 = 4;
				string text = this.CommandText;
				IL_1F:
				num2 = 5;
				if (Operators.CompareString(this.ConnectionName, "", true) <= 0)
				{
					goto IL_C6;
				}
				IL_38:
				num2 = 6;
				if (!O_O0OO.O._o_.().ContainsKey(this.ConnectionName))
				{
					goto IL_65;
				}
				IL_4C:
				num2 = 7;
				oleDbConnection = O_O0OO.O._o_.()[this.ConnectionName];
				goto IL_112;
				IL_65:
				num2 = 9;
				Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator = O_O0OO.O._o_.().Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text2 = enumerator.Current;
					IL_84:
					num2 = 10;
					if (Operators.CompareString(text2, this.ConnectionName, true) == 0)
					{
						IL_97:
						num2 = 11;
						oleDbConnection = O_O0OO.O._o_.()[text2];
					}
					IL_A8:
					num2 = 12;
				}
				IL_B4:
				num2 = 13;
				((IDisposable)enumerator).Dispose();
				goto IL_112;
				IL_C6:
				num2 = 15;
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.();
				IL_D0:
				num2 = 16;
				if (Operators.CompareString(text, "", true) <= 0 || !text.StartsWith("create ", StringComparison.CurrentCultureIgnoreCase))
				{
					goto IL_112;
				}
				IL_F2:
				num2 = 17;
				MessageBox.Show("内部表禁止执行Create语句!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_108:
				num2 = 18;
				result = null;
				goto IL_3D2;
				IL_112:
				num2 = 19;
				text = Oo00.o0_o._O_.(oleDbConnection, text, false);
				IL_121:
				num2 = 20;
				if (oleDbConnection != null && Operators.CompareString(text, "", true) != 0)
				{
					goto IL_141;
				}
				IL_137:
				num2 = 21;
				result = null;
				goto IL_3D2;
				IL_141:
				num2 = 22;
				if (this.OO__00.__. == null)
				{
					goto IL_159;
				}
				IL_14C:
				num2 = 23;
				oleDbConnection = this.OO__00.__.;
				goto IL_175;
				IL_159:
				num2 = 25;
				if (!this.AsyncExecute)
				{
					goto IL_175;
				}
				IL_164:
				num2 = 26;
				oleDbConnection = new OleDbConnection(oleDbConnection.ConnectionString);
				IL_175:
				num2 = 27;
				oleDbCommand.Connection = oleDbConnection;
				IL_181:
				num2 = 28;
				oleDbCommand.CommandText = text;
				IL_18D:
				num2 = 29;
				oleDbCommand.CommandTimeout = this.CommandTimeOut;
				IL_19D:
				num2 = 30;
				if (this.Oo_oO00.0_. == null)
				{
					goto IL_1BA;
				}
				IL_1A8:
				num2 = 31;
				oleDbCommand.Transaction = this.Oo_oO00.0_.;
				goto IL_1F3;
				IL_1BA:
				num2 = 33;
				if (this.AsyncExecute || !OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbConnection))
				{
					goto IL_1F3;
				}
				IL_1D8:
				num2 = 34;
				oleDbCommand.Transaction = OO_00oOO.Connections.Oo___.ooooO00.[oleDbConnection];
				IL_1F3:
				num2 = 35;
				if (!this.StoredProcedure)
				{
					goto IL_20B;
				}
				IL_1FE:
				num2 = 36;
				oleDbCommand.CommandType = CommandType.StoredProcedure;
				goto IL_216;
				IL_20B:
				num2 = 38;
				oleDbCommand.CommandType = CommandType.Text;
				IL_216:
				num2 = 39;
				if (this.Parameters.Count <= 0)
				{
					goto IL_3CC;
				}
				IL_22A:
				num2 = 40;
				Dictionary<string, object>.KeyCollection.Enumerator enumerator2 = this.Parameters.Keys.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string text3 = enumerator2.Current;
					IL_24D:
					num2 = 41;
					OleDbParameter oleDbParameter;
					if (!A_0)
					{
						IL_253:
						num2 = 42;
						oleDbParameter = oleDbCommand.Parameters.AddWithValue(text3, RuntimeHelpers.GetObjectValue(this.Parameters[text3]));
					}
					else
					{
						IL_27A:
						num2 = 44;
						oleDbParameter = oleDbCommand.Parameters.Add(text3, this.O_O_Oo00o_.00_.(RuntimeHelpers.GetObjectValue(this.Parameters[text3])));
						IL_2A5:
						num2 = 45;
						if (this.Parameters[text3] is string)
						{
							IL_2BC:
							num2 = 46;
							oleDbParameter.Size = this.Parameters[text3].ToString().Length;
						}
						IL_2DD:
						num2 = 47;
						oleDbParameter.Value = RuntimeHelpers.GetObjectValue(this.Parameters[text3]);
					}
					IL_2F9:
					num2 = 48;
					if (this.Parameters.o0O___o_o_0o.o.(text3))
					{
						IL_30B:
						num2 = 49;
						oleDbParameter.Direction = ParameterDirection.InputOutput;
						IL_316:
						num2 = 50;
						if (typeof(string) == this.Parameters[text3].GetType())
						{
							IL_337:
							num2 = 51;
							oleDbParameter.Size = this.Parameters.oO_0o_.oOO0.[text3];
						}
					}
					IL_353:
					num2 = 52;
					if (this.Parameters.oO_0o_.oOO0.(text3))
					{
						IL_365:
						num2 = 53;
						oleDbParameter.Direction = ParameterDirection.ReturnValue;
						IL_370:
						num2 = 54;
						if (typeof(string) == this.Parameters[text3].GetType())
						{
							IL_391:
							num2 = 55;
							oleDbParameter.Size = this.Parameters.oO_0o_.oOO0.[text3];
						}
					}
					IL_3AD:
					num2 = 56;
				}
				IL_3BC:
				num2 = 57;
				((IDisposable)enumerator2).Dispose();
				IL_3CC:
				num2 = 58;
				result = oleDbCommand;
				IL_3D2:
				goto IL_510;
				IL_3D7:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_4D1:
				goto IL_505;
				IL_4D3:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_4E3:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_4D3;
			}
			IL_505:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_510:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		/// <summary>
		/// 超时时限，默认为30秒
		/// </summary>
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x000F27C0 File Offset: 0x000F09C0
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x000F27C8 File Offset: 0x000F09C8
		public int CommandTimeOut
		{
			get
			{
				return this.OO__00.__.;
			}
			set
			{
				this.OO__00.__. = value;
			}
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x000F27D4 File Offset: 0x000F09D4
		private void <<EMPTY_NAME>>(OleDbCommand A_0)
		{
			try
			{
				foreach (object obj in A_0.Parameters)
				{
					OleDbParameter oleDbParameter = (OleDbParameter)obj;
					if (((oleDbParameter.Direction == ParameterDirection.InputOutput | oleDbParameter.Direction == ParameterDirection.Output) || oleDbParameter.Direction == ParameterDirection.ReturnValue) && this.Parameters.ContainsKey(oleDbParameter.ParameterName))
					{
						this.Parameters[oleDbParameter.ParameterName] = RuntimeHelpers.GetObjectValue(oleDbParameter.Value);
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

		// Token: 0x06002204 RID: 8708 RVA: 0x000F2878 File Offset: 0x000F0A78
		private void <<EMPTY_NAME>>()
		{
			if (this.Parameters.Count > 0 && this.Oo_oO00.0_. != null)
			{
				try
				{
					foreach (string text in this.Parameters.Keys)
					{
						JObject jobject = new JObject();
						jobject["Name"] = text;
						jobject["Value"] = this.Parameters[text].ToString();
						jobject["Type"] = (int)Information.VarType(RuntimeHelpers.GetObjectValue(this.Parameters[text]));
						if (this.Parameters.oO_0o_.oOO0.(text))
						{
							jobject["Return"] = this.Parameters.o0O___o_o_0o.o.[text];
						}
						if (this.Parameters.o0O___o_o_0o.o.(text))
						{
							jobject["Output"] = this.Parameters.oO_0o_.oOO0.[text];
						}
						this.Oo_oO00.0_..FormData.Add("@{" + text + "}", HttpFunctions.CompressJson(jobject));
					}
				}
				finally
				{
					Dictionary<string, object>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x000F29DC File Offset: 0x000F0BDC
		private void <<EMPTY_NAME>>(DataTable A_0)
		{
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x000F29E0 File Offset: 0x000F0BE0
		private OleDbType <<EMPTY_NAME>>(object A_0)
		{
			Type type = A_0.GetType();
			OleDbType result;
			if (type == typeof(string))
			{
				result = OleDbType.VarWChar;
			}
			else if (type == typeof(char))
			{
				result = OleDbType.VarWChar;
			}
			else if (type == typeof(DateTime))
			{
				result = OleDbType.Date;
			}
			else if (type == typeof(decimal))
			{
				result = OleDbType.Numeric;
			}
			else if (type == typeof(double))
			{
				result = OleDbType.Double;
			}
			else if (type == typeof(float))
			{
				result = OleDbType.Single;
			}
			else if (type == typeof(long))
			{
				result = OleDbType.Integer;
			}
			else if (type == typeof(int))
			{
				result = OleDbType.Integer;
			}
			else if (type == typeof(short))
			{
				result = OleDbType.SmallInt;
			}
			else if (type == typeof(byte))
			{
				result = OleDbType.TinyInt;
			}
			else if (type == typeof(byte[]))
			{
				result = OleDbType.Binary;
			}
			else if (type == typeof(bool))
			{
				result = OleDbType.Boolean;
			}
			return result;
		}

		// Token: 0x04000E23 RID: 3619
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E24 RID: 3620
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E25 RID: 3621
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E26 RID: 3622
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E27 RID: 3623
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E28 RID: 3624
		private oooOo_0oo <<EMPTY_NAME>>;

		// Token: 0x04000E29 RID: 3625
		private HttpClient <<EMPTY_NAME>>;

		// Token: 0x04000E2A RID: 3626
		private OleDbTransaction <<EMPTY_NAME>>;

		// Token: 0x04000E2B RID: 3627
		private OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x04000E2C RID: 3628
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;
	}
}
