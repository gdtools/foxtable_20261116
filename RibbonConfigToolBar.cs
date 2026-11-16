using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x0200048B RID: 1163
	[oO0oooo("1098")]
	internal class RibbonConfigToolBar : RibbonItemContainer
	{
		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06004F21 RID: 20257 RVA: 0x00238723 File Offset: 0x00236923
		[Browsable(false)]
		public new string Name
		{
			get
			{
				return "配置栏";
			}
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x0023872A File Offset: 0x0023692A
		public RibbonConfigToolBar(DataRow A_0) : base(A_0)
		{
			base.Name = "配置栏";
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}
	}
}
