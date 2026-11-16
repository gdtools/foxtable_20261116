using System;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 加载树
	/// </summary>
	// Token: 0x02000505 RID: 1285
	[oO0oooo("3370")]
	public class LoadTree : Control
	{
		// Token: 0x060053F4 RID: 21492 RVA: 0x00256BE0 File Offset: 0x00254DE0
		internal LoadTree(o_0 A_0) : base(A_0, ControlTypeEnum.LoadTree)
		{
			this.O.oo_oO. = A_0;
			A_0.oOo0O.___ooOO0. = true;
		}

		/// <summary>
		/// 生成加载树
		/// </summary>
		/// <param name="Table">基于这个Table生成加载树</param>
		/// <param name="ColNames">指定分组列，不同的列之间用符号"|"隔开，例如"产品|客户"</param>
		/// <param name="PageRows">每页加载行数</param>
		/// <param name="DefaultFilter">初始加载条件</param>
		// Token: 0x060053F5 RID: 21493 RVA: 0x00256BFC File Offset: 0x00254DFC
		public void Build(Table Table, string ColNames, int PageRows, string DefaultFilter = "")
		{
			this.O.oo_oO..O__O_._. = Table;
			this.O.oo_oO..O_OOo0.0ooO. = ColNames;
			this.O.oo_oO..oOo0O.___ooOO0. = DefaultFilter;
			Table.o.0__o0. = PageRows;
			Table.O0__O_.O. = Table.DataTable.LoadOver;
			this.O.oo_oO..o000.oO0.(ColNames);
			if (this.O.oo_oO..O.0O_o0.() != null)
			{
				this.O.oo_oO..O.0O_o0.().Visible = true;
			}
		}

		// Token: 0x040022AD RID: 8877
		private o_0 <<EMPTY_NAME>>;
	}
}
