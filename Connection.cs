using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 数据源
	/// </summary>
	// Token: 0x020002A3 RID: 675
	[ComVisible(true)]
	public class Connection
	{
		/// <param name="Name">数据源名称</param>
		/// <param name="ConnectionString">链接字符串</param>
		// Token: 0x06002258 RID: 8792 RVA: 0x000F6425 File Offset: 0x000F4625
		public Connection(string A_0, string A_1)
		{
			this.Oo___.ooooO00. = A_0;
			this.o0_O.00. = A_1;
		}

		/// <summary>
		/// 数据源名称
		/// </summary>
		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x000F643B File Offset: 0x000F463B
		public string Name
		{
			get
			{
				return this.Oo___.ooooO00.;
			}
		}

		/// <summary>
		/// 链接字符串
		/// </summary>
		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x000F6443 File Offset: 0x000F4643
		public string ConnectionString
		{
			get
			{
				return this.o0_O.00.;
			}
		}

		/// <summary>
		/// 如果是WEB数据源，返回1，否则返回0
		/// </summary>
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x000F644C File Offset: 0x000F464C
		public int Type
		{
			get
			{
				int result;
				if (this.ConnectionString.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || this.ConnectionString.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
				{
					result = 1;
				}
				else
				{
					result = 0;
				}
				return result;
			}
		}

		/// <summary>
		/// 用于动态设置WEB数据源的属性
		/// </summary>
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x000F6488 File Offset: 0x000F4688
		[oO0oooo("A286")]
		public Dictionary<string, string> FormData
		{
			get
			{
				Dictionary<string, string> result;
				if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.Name))
				{
					result = O_O0OO.OoO__.0oO0oo.()[this.Name].oOOO.000_O.();
				}
				else
				{
					result = new Dictionary<string, string>();
				}
				return result;
			}
		}

		/// <summary>
		/// 用于动态设置WEB数据源的Cookies
		/// </summary>
		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x000F64C8 File Offset: 0x000F46C8
		[oO0oooo("A286")]
		public Dictionary<string, string> Cookies
		{
			get
			{
				Dictionary<string, string> result;
				if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.Name))
				{
					result = O_O0OO.OoO__.0oO0oo.()[this.Name].oO0_0.o.();
				}
				else
				{
					result = new Dictionary<string, string>();
				}
				return result;
			}
		}

		/// <summary>
		/// WEB数据源的超时时限
		/// </summary>
		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x000F6508 File Offset: 0x000F4708
		// (set) Token: 0x0600225F RID: 8799 RVA: 0x000F653E File Offset: 0x000F473E
		public int TimeOut
		{
			get
			{
				int result;
				if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.Name))
				{
					result = O_O0OO.OoO__.0oO0oo.()[this.Name].OO._o_OO.();
				}
				return result;
			}
			set
			{
				if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.Name))
				{
					O_O0OO.OoO__.0oO0oo.()[this.Name].OO.OoO0.(value);
				}
			}
		}

		/// <summary>
		/// WEB数据源的服务端地址
		/// </summary>
		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x000F6568 File Offset: 0x000F4768
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x000F65A6 File Offset: 0x000F47A6
		[oO0oooo("A286")]
		public string DataServer
		{
			get
			{
				string result;
				if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.Name))
				{
					result = O_O0OO.OoO__.0oO0oo.()[this.Name].oOOO.000_O.();
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.Name))
				{
					O_O0OO.OoO__.0oO0oo.()[this.Name].O_0_O_0_o_.0.(value);
				}
			}
		}

		/// <summary>
		/// 返回一个字符串集合，包括此数据源所有的表名。
		/// </summary>
		// Token: 0x06002262 RID: 8802 RVA: 0x000F65D0 File Offset: 0x000F47D0
		public object GetTableNames()
		{
			List<string> list = new List<string>();
			if (O_O0OO.O._o_.().ContainsKey(this.Name))
			{
				OleDbConnection oleDbConnection = O_O0OO.O._o_.()[this.Name];
				oleDbConnection.Open();
				DataTable dataTable;
				if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection))
				{
					DbDataAdapter dbDataAdapter = new OleDbDataAdapter("select owner,table_name from all_tables where owner not LIKE '%SYS%'", oleDbConnection);
					dataTable = new DataTable();
					dbDataAdapter.Fill(dataTable);
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							list.Add(string.Concat(new string[]
							{
								"\"",
								dataRow["OWNER"].ToString(),
								"\".\"",
								dataRow["TABLE_NAME"].ToString(),
								"\""
							}));
						}
						goto IL_1B3;
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
				dataTable = oleDbConnection.GetSchema("Tables");
				foreach (DataRow dataRow2 in dataTable.Select("[TABLE_TYPE]='TABLE'"))
				{
					string text = Conversions.ToString(dataRow2["TABLE_NAME"]);
					if (!dataRow2.IsNull("TABLE_SCHEMA") && Operators.CompareString(dataRow2["TABLE_SCHEMA"].ToString(), "dbo", true) != 0)
					{
						text = string.Concat(new string[]
						{
							"[",
							dataRow2["TABLE_SCHEMA"].ToString(),
							"].[",
							text,
							"]"
						});
					}
					if (!text.StartsWith("~"))
					{
						list.Add(text);
					}
				}
				IL_1B3:
				oleDbConnection.Close();
			}
			else if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.Name))
			{
				list = O_O0OO.OoO__.0oO0oo.()[this.Name].OO._o_OO.();
			}
			object result;
			if (ooO.o.O_0000_O.())
			{
				result = list.ToArray();
			}
			else
			{
				result = list;
			}
			return result;
		}

		/// <summary>
		/// 返回一个字符串集合，包括此数据源所有的视图名
		/// </summary>
		// Token: 0x06002263 RID: 8803 RVA: 0x000F67E4 File Offset: 0x000F49E4
		public object GetViewNames()
		{
			List<string> list = new List<string>();
			checked
			{
				if (O_O0OO.O._o_.().ContainsKey(this.Name))
				{
					OleDbConnection oleDbConnection = O_O0OO.O._o_.()[this.Name];
					oleDbConnection.Open();
					DataTable dataTable;
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection))
					{
						DbDataAdapter dbDataAdapter = new OleDbDataAdapter("select owner,view_name from all_views where owner not LIKE '%SYS%'", oleDbConnection);
						dataTable = new DataTable();
						dbDataAdapter.Fill(dataTable);
						try
						{
							foreach (object obj in dataTable.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								list.Add(string.Concat(new string[]
								{
									"\"",
									dataRow["OWNER"].ToString(),
									"\".\"",
									dataRow["VIEW_NAME"].ToString(),
									"\""
								}));
							}
							goto IL_13C;
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
					dataTable = oleDbConnection.GetSchema("Tables");
					DataRow[] array = dataTable.Select("[TABLE_TYPE]='VIEW'");
					for (int i = 0; i < array.Length; i++)
					{
						string text = Conversions.ToString(array[i]["TABLE_NAME"]);
						if (!text.StartsWith("~"))
						{
							list.Add(text);
						}
					}
					IL_13C:
					oleDbConnection.Close();
				}
				else
				{
					list = O_O0OO.OoO__.0oO0oo.()[this.Name].O_0_O_0_o_.0.();
				}
				object result;
				if (ooO.o.O_0000_O.())
				{
					result = list.ToArray();
				}
				else
				{
					result = list;
				}
				return result;
			}
		}

		/// <summary>
		/// 返回数据源的类型，1表示Access，2表示SQL Server，3表示Oracle
		/// </summary>
		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x000F6970 File Offset: 0x000F4B70
		public int SourceType
		{
			get
			{
				int result;
				if (O_O0OO.O._o_.().ContainsKey(this.Name))
				{
					result = (int)Oo00.OoO_.__o.(O_O0OO.O._o_.()[this.Name]);
				}
				else if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.Name))
				{
					DataServerTypeEnum oo.OoO0. = O_O0OO.OoO__.0oO0oo.()[this.Name].OO.OoO0.;
					if (oo.OoO0. == DataServerTypeEnum.Access || oo.OoO0. == DataServerTypeEnum.Buildin)
					{
						result = 1;
					}
					else
					{
						result = (int)O_O0OO.OoO__.0oO0oo.()[this.Name].OO.OoO0.;
					}
				}
				return result;
			}
		}

		/// <summary>
		/// 开启事务
		/// </summary>
		// Token: 0x06002265 RID: 8805 RVA: 0x000F69F4 File Offset: 0x000F4BF4
		[oO0oooo("2933")]
		public void BeginTransaction()
		{
			if (this.Oo___.ooooO00.())
			{
				OleDbConnection oleDbConnection = O_O0OO.O._o_.()[this.Name];
				if (!OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbConnection))
				{
					if (oleDbConnection.State != ConnectionState.Open)
					{
						oleDbConnection.Open();
					}
					OleDbTransaction value = oleDbConnection.BeginTransaction();
					OO_00oOO.Connections.Oo___.ooooO00..Add(oleDbConnection, value);
				}
			}
		}

		/// <summary>
		/// 提交事务
		/// </summary>
		// Token: 0x06002266 RID: 8806 RVA: 0x000F6A54 File Offset: 0x000F4C54
		[oO0oooo("2933")]
		public void Commit()
		{
			if (this.Oo___.ooooO00.())
			{
				OleDbConnection oleDbConnection = O_O0OO.O._o_.()[this.Name];
				if (OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbConnection))
				{
					OleDbTransaction oleDbTransaction = OO_00oOO.Connections.Oo___.ooooO00.[oleDbConnection];
					OO_00oOO.Connections.Oo___.ooooO00..Remove(oleDbConnection);
					oleDbTransaction.Commit();
					if (oleDbConnection.State == ConnectionState.Open)
					{
						oleDbConnection.Close();
					}
				}
			}
		}

		/// <summary>
		/// 回滚事务
		/// </summary>
		// Token: 0x06002267 RID: 8807 RVA: 0x000F6AC4 File Offset: 0x000F4CC4
		[oO0oooo("2933")]
		public void Rollback()
		{
			if (this.Oo___.ooooO00.())
			{
				OleDbConnection oleDbConnection = O_O0OO.O._o_.()[this.Name];
				if (OO_00oOO.Connections.Oo___.ooooO00..ContainsKey(oleDbConnection))
				{
					OleDbTransaction oleDbTransaction = OO_00oOO.Connections.Oo___.ooooO00.[oleDbConnection];
					OO_00oOO.Connections.Oo___.ooooO00..Remove(oleDbConnection);
					oleDbTransaction.Rollback();
					if (oleDbConnection.State == ConnectionState.Open)
					{
						oleDbConnection.Close();
					}
				}
			}
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x000F6B34 File Offset: 0x000F4D34
		private bool <<EMPTY_NAME>>()
		{
			bool result;
			if (!O_O0OO.O._o_.().ContainsKey(this.Name))
			{
				if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.Name))
				{
					MessageBox.Show("Web数据源不支持事务", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x04000E48 RID: 3656
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E49 RID: 3657
		private string <<EMPTY_NAME>>;
	}
}
