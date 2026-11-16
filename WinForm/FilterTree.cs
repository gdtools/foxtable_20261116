using System;
using System.Runtime.InteropServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 筛选树
	/// </summary>
	// Token: 0x02000504 RID: 1284
	[ComVisible(true)]
	[oO0oooo("3369")]
	public class FilterTree : Control
	{
		// Token: 0x060053F2 RID: 21490 RVA: 0x00256B75 File Offset: 0x00254D75
		internal FilterTree(o_o0ooOooO A_0) : base(A_0, ControlTypeEnum.FilterTree)
		{
			this.O.00oo_OO0O. = A_0;
			A_0.O_.o__. = true;
		}

		/// <summary>
		/// 生成筛选树
		/// </summary>
		/// <param name="Table">要筛选的Table</param>
		/// <param name="ColNames">指定分组列，不同的列之间用符号"|"隔开，例如"产品|客户"</param>
		// Token: 0x060053F3 RID: 21491 RVA: 0x00256B90 File Offset: 0x00254D90
		public void Build(Table Table, string ColNames)
		{
			this.O.00oo_OO0O..OOO_.00. = Table;
			this.O.00oo_OO0O..OOO_.00. = ColNames;
			this.O.00oo_OO0O..O0o.0oo0_.(ColNames);
			if (this.O.00oo_OO0O..O0o.0oo0_.() != null)
			{
				this.O.00oo_OO0O..O0o.0oo0_.().Visible = true;
			}
		}

		// Token: 0x040022AC RID: 8876
		private o_o0ooOooO <<EMPTY_NAME>>;
	}
}
