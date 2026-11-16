using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using ADODB;
using ADOX;

namespace Foxtable
{
	// Token: 0x02000245 RID: 581
	[oO0oooo("2122")]
	public class ADOXBuilder
	{
		/// <param name="ConnectionName">数据源名称</param>
		// Token: 0x06001BC5 RID: 7109 RVA: 0x000C2C54 File Offset: 0x000C0E54
		public ADOXBuilder(string A_0)
		{
			this.o0.0_O0000_O. = new ConnectionClass();
			this.o0.0_O0000_O. = "";
			this.o0.0_O0000_O..ConnectionString = OO_00oOO.Connections[A_0].ConnectionString;
			this.o0.0_O0000_O. = (this.o0.0_O0000_O..Provider.IndexOf("SQLOLEDB", StringComparison.CurrentCultureIgnoreCase) >= 0 | this.o0.0_O0000_O..Provider.IndexOf("SQLNCLI", StringComparison.CurrentCultureIgnoreCase) >= 0);
			this.o.oo. = A_0;
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000C2CE0 File Offset: 0x000C0EE0
		public ADOXBuilder()
		{
			this.o0.0_O0000_O. = new ConnectionClass();
			this.o0.0_O0000_O. = "";
			this.o0.0_O0000_O..ConnectionString = O_O0OO.OoO.0OO__0ooo.().ConnectionString;
			this.o0.0_O0000_O. = "~TMPCLP";
			this.o.oo. = true;
		}

		/// <summary>
		/// 打开
		/// </summary>
		// Token: 0x06001BC7 RID: 7111 RVA: 0x000C2D30 File Offset: 0x000C0F30
		public void Open()
		{
			this.o0.0_O0000_O. = new CatalogClass();
			this.o0.0_O0000_O..Open("", "", "", -1);
			this.o0.0_O0000_O..ActiveConnection = this.o0.0_O0000_O.;
		}

		/// <summary>
		/// 关闭
		/// </summary>
		// Token: 0x06001BC8 RID: 7112 RVA: 0x000C2D69 File Offset: 0x000C0F69
		public void Close()
		{
			this.o0.0_O0000_O..Close();
			this.o0.0_O0000_O. = null;
		}

		/// <summary>
		/// 创建数据表
		/// </summary>
		/// <param name="Name">表名</param>
		// Token: 0x06001BC9 RID: 7113 RVA: 0x000C2D80 File Offset: 0x000C0F80
		public ADOXTable NewTable(string Name)
		{
			ADOXTable result;
			if (!o_O_o_oOoo__.O_o_._o0.(Name))
			{
				result = null;
			}
			else
			{
				result = new ADOXTable(new TableClass
				{
					Name = this.o0.0_O0000_O. + Name,
					ParentCatalog = this.o0.0_O0000_O.
				}, this.o0.0_O0000_O., this.o.oo., this.o.oo.);
			}
			return result;
		}

		/// <summary>
		/// 增加数据表
		/// </summary>
		/// <param name="ADOXTable">要增加的表</param>
		/// <param name="AddLockColumn">是否增加_Locked列</param>
		/// <param name="AddSortColumn">是否增加_SortKey列</param>
		// Token: 0x06001BCA RID: 7114 RVA: 0x000C2DD8 File Offset: 0x000C0FD8
		public void AddTable(ADOXTable ADOXTable, bool AddLockColumn = false, bool AddSortColumn = false)
		{
			Table oooO__O_0o_.o_. = ADOXTable.oooO__O_0o_.o_.;
			if (AddLockColumn | this.o.oo.)
			{
				oooO__O_0o_.o_..Columns.Append("_Locked", ADOX.DataTypeEnum.adBoolean, 0);
				if (this.o0.0_O0000_O.)
				{
					oooO__O_0o_.o_..Columns["_Locked"].Attributes = ColumnAttributesEnum.adColNullable;
				}
			}
			if (AddSortColumn | this.o.oo.)
			{
				oooO__O_0o_.o_..Columns.Append("_SortKey", ADOX.DataTypeEnum.adNumeric, 0);
				Column column = oooO__O_0o_.o_..Columns["_SortKey"];
				column.Precision = 28;
				column.NumericScale = 14;
				column.Attributes = ColumnAttributesEnum.adColNullable;
			}
			oooO__O_0o_.o_..Columns.Append("_Identify", ADOX.DataTypeEnum.adInteger, 0);
			if (!this.o.oo.)
			{
				oooO__O_0o_.o_..Columns["_Identify"].Properties["AutoIncrement"].Value = true;
			}
			Index index = new IndexClass();
			index.Name = oooO__O_0o_.o_..Name + "_PrimaryKey";
			index.Columns.Append("_Identify", ADOX.DataTypeEnum.adVarWChar, 0);
			index.PrimaryKey = true;
			index.Unique = true;
			oooO__O_0o_.o_..Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
			this.o0.0_O0000_O..Tables.Append(ADOXTable.oooO__O_0o_.o_.);
		}

		/// <summary>
		/// 删除指定名称的表
		/// </summary>
		/// <param name="Name">表名</param>
		// Token: 0x06001BCB RID: 7115 RVA: 0x000C2F21 File Offset: 0x000C1121
		public void DeleteTable(string Name)
		{
			this.o0.0_O0000_O..Tables.Delete(this.o0.0_O0000_O. + Name);
		}

		/// <summary>
		/// 获取指定名称的表
		/// </summary>
		/// <param name="Name">表名</param>
		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x000C2F3F File Offset: 0x000C113F
		public ADOXTable Tables
		{
			get
			{
				return new ADOXTable(this.o0.0_O0000_O..Tables[this.o0.0_O0000_O. + Name], this.o0.0_O0000_O., this.o.oo., this.o.oo.);
			}
		}

		// Token: 0x04000BAE RID: 2990
		private Catalog <<EMPTY_NAME>>;

		// Token: 0x04000BAF RID: 2991
		private Connection <<EMPTY_NAME>>;

		// Token: 0x04000BB0 RID: 2992
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000BB1 RID: 2993
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BB2 RID: 2994
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000BB3 RID: 2995
		private string <<EMPTY_NAME>>;
	}
}
