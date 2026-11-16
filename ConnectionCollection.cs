using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002A4 RID: 676
	[oO0oooo("1944")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class ConnectionCollection : IEnumerable<Connection>
	{
		// Token: 0x06002269 RID: 8809 RVA: 0x000F6B7F File Offset: 0x000F4D7F
		public ConnectionCollection()
		{
			this.Oo___.ooooO00. = new Dictionary<OleDbConnection, OleDbTransaction>();
		}

		/// <summary>
		/// 数据源的数量
		/// </summary>
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x000F6B92 File Offset: 0x000F4D92
		public int Count
		{
			get
			{
				return O_O0OO.O._o_.().Count + O_O0OO.OoO__.0oO0oo.().Count;
			}
		}

		/// <summary>
		/// 判断是否包括指定名称的数据源
		/// </summary>
		/// <param name="ConnectionName">数据源名称</param>
		// Token: 0x0600226B RID: 8811 RVA: 0x000F6BAC File Offset: 0x000F4DAC
		public bool Contains(string ConnectionName)
		{
			bool result;
			if (O_O0OO.O._o_.().ContainsKey(ConnectionName) || O_O0OO.OoO__.0oO0oo.().ContainsKey(ConnectionName))
			{
				result = true;
			}
			else
			{
				try
				{
					Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator = O_O0OO.O._o_.().Keys.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(enumerator.Current, ConnectionName, true) == 0)
						{
							return true;
						}
					}
				}
				finally
				{
					Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					Dictionary<string, O0O>.KeyCollection.Enumerator enumerator2 = O_O0OO.OoO__.0oO0oo.().Keys.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						if (Operators.CompareString(enumerator2.Current, ConnectionName, true) == 0)
						{
							return true;
						}
					}
				}
				finally
				{
					Dictionary<string, O0O>.KeyCollection.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x17000758 RID: 1880
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Connection this[object A_0]
		{
			get
			{
				int index = -1;
				Connection result;
				if (int.TryParse(A_0.ToString(), out index))
				{
					result = this.get_Item(index);
				}
				else
				{
					result = this.get_Item(A_0.ToString());
				}
				return result;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x000F6CB4 File Offset: 0x000F4EB4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Connection Item
		{
			get
			{
				Connection result;
				if (O_O0OO.O._o_.().ContainsKey(ConnectionName))
				{
					OleDbConnection oleDbConnection = O_O0OO.O._o_.()[ConnectionName];
					result = new Connection(ConnectionName, oleDbConnection.ConnectionString);
				}
				else if (O_O0OO.OoO__.0oO0oo.().ContainsKey(ConnectionName))
				{
					result = new Connection(ConnectionName, O_O0OO.OoO__.0oO0oo.()[ConnectionName].oO0_0.o.());
				}
				else
				{
					try
					{
						foreach (string text in O_O0OO.O._o_.().Keys)
						{
							if (Operators.CompareString(text, ConnectionName, true) == 0)
							{
								OleDbConnection oleDbConnection2 = O_O0OO.O._o_.()[text];
								return new Connection(text, oleDbConnection2.ConnectionString);
							}
						}
					}
					finally
					{
						Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					try
					{
						foreach (string text2 in O_O0OO.OoO__.0oO0oo.().Keys)
						{
							if (Operators.CompareString(text2, ConnectionName, true) == 0)
							{
								return new Connection(text2, O_O0OO.OoO__.0oO0oo.()[text2].oO0_0.o.());
							}
						}
					}
					finally
					{
						Dictionary<string, O0O>.KeyCollection.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					MessageBox.Show("不存在名为\"" + ConnectionName + "\"的数据源！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = null;
				}
				return result;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x000F6E0C File Offset: 0x000F500C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Connection Item
		{
			get
			{
				if (Index <= O_O0OO.O._o_.().Count + O_O0OO.OoO__.0oO0oo.().Count - 1)
				{
					int num;
					try
					{
						foreach (string text in O_O0OO.O._o_.().Keys)
						{
							if (num == Index)
							{
								OleDbConnection oleDbConnection = O_O0OO.O._o_.()[text];
								return new Connection(text, oleDbConnection.ConnectionString);
							}
							num++;
						}
					}
					finally
					{
						Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					try
					{
						foreach (string text2 in O_O0OO.OoO__.0oO0oo.().Keys)
						{
							if (num == Index)
							{
								return new Connection(text2, O_O0OO.OoO__.0oO0oo.()[text2].oO0_0.o.());
							}
							num++;
						}
					}
					finally
					{
						Dictionary<string, O0O>.KeyCollection.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				return null;
			}
		}

		/// <summary>
		/// 删除指定名称的额数据源
		/// </summary>
		/// <param name="ConnectionName">数据源名称</param>
		// Token: 0x0600226F RID: 8815 RVA: 0x000F6F08 File Offset: 0x000F5108
		public void Delete(string ConnectionName)
		{
			try
			{
				IEnumerator<DataTable> enumerator = OO_00oOO.DataTables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (Operators.CompareString(enumerator.Current.ConnectionName, ConnectionName, true) == 0)
					{
						MessageBox.Show("该数据源仍在使用，不能被删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
			}
			finally
			{
				IEnumerator<DataTable> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			O_O0OO.O._o_.().Remove(ConnectionName);
			O_O0OO.o_Oo_000_.0o_0.().Remove(ConnectionName);
			O_O0OO.OoO__.0oO0oo.().Remove(ConnectionName);
		}

		/// <summary>
		/// 增加数据源
		/// </summary>
		/// <param name="ConnectionName">数据源名称</param>
		/// <param name="ConnectionString">连接字符串</param>
		// Token: 0x06002270 RID: 8816 RVA: 0x000F6F94 File Offset: 0x000F5194
		public void Add(string ConnectionName, string ConnectionString)
		{
			try
			{
				Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator = O_O0OO.O._o_.().Keys.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (Operators.CompareString(enumerator.Current, ConnectionName, true) == 0)
					{
						MessageBox.Show("数据连接\"" + ConnectionName + "\"已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
				}
			}
			finally
			{
				Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				if (ConnectionString.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || ConnectionString.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
				{
					O0O o0O = new O0O(ConnectionString);
					if (o0O.OO._o_OO.())
					{
						O_O0OO.OoO__.0oO0oo.().Add(ConnectionName, o0O);
					}
				}
				else
				{
					O_0oOo_OO o_0oOo_OO = new O_0oOo_OO();
					OleDbConnection oleDbConnection = new OleDbConnection(ConnectionString);
					oleDbConnection.Open();
					o_0oOo_OO.oo.00O0__o.(true);
					oleDbConnection.Close();
					O_O0OO.O._o_.().Add(ConnectionName, oleDbConnection);
					O_O0OO.o_Oo_000_.0o_0.().Add(ConnectionName, o_0oOo_OO);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("创建外部连接\"" + ConnectionName + "\"失败，原因：\r\n\r\n" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x000F70C4 File Offset: 0x000F52C4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool TestConnString(string ConnectionString, ref string ErrMsg = "")
		{
			bool result;
			try
			{
				if (ConnectionString.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || ConnectionString.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
				{
					result = new O0O(ConnectionString).OO._o_OO.();
				}
				else
				{
					OleDbConnection oleDbConnection = new OleDbConnection(ConnectionString);
					oleDbConnection.Open();
					oleDbConnection.Close();
					result = true;
				}
			}
			catch (Exception ex)
			{
				ErrMsg = ex.Message;
				result = false;
			}
			return result;
		}

		/// <summary>
		/// 测试指定的连接字符串能否连通
		/// </summary>
		/// <param name="ConnectionString">连接字符串</param>
		/// <param name="ErrMsg">指定一个字符串变量，用于获取导致数据源无法连接的错误原因</param>
		// Token: 0x06002272 RID: 8818 RVA: 0x000F713C File Offset: 0x000F533C
		public bool TryConnect(string ConnectionString, ref string ErrMsg = "")
		{
			return this.TestConnString(ConnectionString, ref ErrMsg);
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x000F7146 File Offset: 0x000F5346
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<Connection> GetEnumerator()
		{
			return new oO0OOo0o__();
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x000F714D File Offset: 0x000F534D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return new oO0OOo0o__();
		}

		// Token: 0x04000E4A RID: 3658
		internal Dictionary<OleDbConnection, OleDbTransaction> <<EMPTY_NAME>>;
	}
}
