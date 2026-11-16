using System;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 查询表生成器
	/// </summary>
	// Token: 0x0200029C RID: 668
	[oO0oooo("0695")]
	[ComVisible(true)]
	public class QueryBuilder
	{
		// Token: 0x060021D2 RID: 8658 RVA: 0x000F0AC6 File Offset: 0x000EECC6
		public QueryBuilder()
		{
			this.Oo_O.0o0_. = false;
			this.Oo.O0OOo0. = true;
			this.oO0000.OO0oo. = 30;
		}

		/// <param name="TableName">表名</param>
		// Token: 0x060021D3 RID: 8659 RVA: 0x000F0AE4 File Offset: 0x000EECE4
		public QueryBuilder(string A_0)
		{
			this.Oo_O.0o0_. = false;
			this.Oo.O0OOo0. = true;
			this.oO0000.OO0oo. = 30;
			this.TableName = A_0;
		}

		/// <summary>
		/// Select语句
		/// </summary>
		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x000F0B09 File Offset: 0x000EED09
		// (set) Token: 0x060021D5 RID: 8661 RVA: 0x000F0B11 File Offset: 0x000EED11
		public string SelectString
		{
			get
			{
				return this.Oo_O.0o0_.;
			}
			set
			{
				this.Oo_O.0o0_. = value;
			}
		}

		/// <summary>
		/// 数据源名称
		/// </summary>
		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x000F0B1A File Offset: 0x000EED1A
		// (set) Token: 0x060021D7 RID: 8663 RVA: 0x000F0B22 File Offset: 0x000EED22
		public string ConnectionName
		{
			get
			{
				return this.OO.o_Oo.;
			}
			set
			{
				this.OO.o_Oo. = value;
			}
		}

		/// <summary>
		/// 表名
		/// </summary>
		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x000F0B2B File Offset: 0x000EED2B
		// (set) Token: 0x060021D9 RID: 8665 RVA: 0x000F0B33 File Offset: 0x000EED33
		public string TableName
		{
			get
			{
				return this.O.oooo_o.;
			}
			set
			{
				this.O.oooo_o. = value;
			}
		}

		/// <summary>
		/// 表标题
		/// </summary>
		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x000F0B3C File Offset: 0x000EED3C
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x000F0B44 File Offset: 0x000EED44
		public string TableCaption
		{
			get
			{
				return this.o_O.00o.;
			}
			set
			{
				this.o_O.00o. = value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x000F0B4D File Offset: 0x000EED4D
		// (set) Token: 0x060021DD RID: 8669 RVA: 0x000F0B55 File Offset: 0x000EED55
		internal bool IsDataTable
		{
			get
			{
				return this.Oo_O.0o0_.;
			}
			set
			{
				this.Oo_O.0o0_. = value;
			}
		}

		/// <summary>
		/// 设置生成的Table的Visible属性
		/// </summary>
		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x000F0B5E File Offset: 0x000EED5E
		// (set) Token: 0x060021DF RID: 8671 RVA: 0x000F0B66 File Offset: 0x000EED66
		public bool TableVisible
		{
			get
			{
				return this.Oo.O0OOo0.;
			}
			set
			{
				this.Oo.O0OOo0. = value;
			}
		}

		/// <summary>
		/// 超时时限，默认30秒
		/// </summary>
		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x000F0B6F File Offset: 0x000EED6F
		// (set) Token: 0x060021E1 RID: 8673 RVA: 0x000F0B77 File Offset: 0x000EED77
		public int TimeOut
		{
			get
			{
				return this.oO0000.OO0oo.;
			}
			set
			{
				this.oO0000.OO0oo. = value;
			}
		}

		/// <summary>
		/// 生成表
		/// </summary>
		// Token: 0x060021E2 RID: 8674 RVA: 0x000F0B80 File Offset: 0x000EED80
		public DataTable Build()
		{
			string a_ = "";
			DataTable result;
			if (Operators.CompareString(this.TableName, "", true) == 0 || Operators.CompareString(this.SelectString, "", true) == 0)
			{
				result = null;
			}
			else
			{
				if (this.IsDataTable)
				{
					a_ = "?";
				}
				string left = OO_00oOO.MainTable.Name;
				OleDbConnection oleDbConnection = null;
				O0O o0O = null;
				HttpClient httpClient = null;
				if (OO_00oOO.DataTables.Contains(this.TableName))
				{
					if (OO_00oOO.DataTables[this.TableName].AddByCode)
					{
						OO_00oOO.DataTables.Delete(this.TableName);
					}
					if (OO_00oOO.DataTables.Contains(this.TableName))
					{
						MessageBox.Show("表" + this.TableName + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return null;
					}
				}
				if (Operators.CompareString(this.ConnectionName, "", true) > 0)
				{
					if (O_O0OO.O._o_.().ContainsKey(this.ConnectionName))
					{
						oleDbConnection = O_O0OO.O._o_.()[this.ConnectionName];
						this.SelectString = Oo00.o0_o._O_.(oleDbConnection, this.SelectString, false);
					}
					else if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.ConnectionName))
					{
						o0O = O_O0OO.OoO__.0oO0oo.()[this.ConnectionName];
						this.SelectString = Oo00.o0_o._O_.(o0O.OO.OoO0., this.SelectString, false);
						httpClient = o0O.oO0_0.o.();
						httpClient.Select = this.SelectString;
						if (this.IsDataTable)
						{
							httpClient.FormData["Action"] = 1.ToString();
						}
						else
						{
							httpClient.FormData["Action"] = 2.ToString();
						}
					}
					if (oleDbConnection == null && o0O == null)
					{
						MessageBox.Show("不存在名为\"" + this.ConnectionName + "\"的数据源！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return null;
					}
				}
				else
				{
					oleDbConnection = O_O0OO.OoO.0OO__0ooo.();
				}
				o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, this.SelectString, this.TableName, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, a_, true, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), this.TimeOut, null, this.ConnectionName, httpClient);
				if (OO_00oOO.DataTables.Contains(this.TableName))
				{
					OO_00oOO.DataTables[this.TableName].o.0O000_.();
					OO_00oOO.DataTables[this.TableName].AddByCode = true;
					OO_00oOO.DataTables[this.TableName].Caption = this.TableCaption;
					OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[this.TableName]);
					Main.OO_O.o..o0_o_o_0.0O.(this.TableName, this.TableVisible, false);
					if (Operators.CompareString(left, this.TableName, true) == 0)
					{
						OO_00oOO.MainTable = OO_00oOO.Tables[this.TableName];
					}
					result = OO_00oOO.DataTables[this.TableName];
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x04000E1C RID: 3612
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E1D RID: 3613
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E1E RID: 3614
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E1F RID: 3615
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E20 RID: 3616
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E21 RID: 3617
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E22 RID: 3618
		private int <<EMPTY_NAME>>;
	}
}
