using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x0200048C RID: 1164
	[OoO0___o("RibbonCrossTableList")]
	internal class RibbonCrossTableList : RibbonItem
	{
		// Token: 0x06004F23 RID: 20259 RVA: 0x00238746 File Offset: 0x00236946
		public RibbonCrossTableList(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06004F24 RID: 20260 RVA: 0x00238757 File Offset: 0x00236957
		// (set) Token: 0x06004F25 RID: 20261 RVA: 0x00238772 File Offset: 0x00236972
		[DisplayName("标题")]
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		public string Text
		{
			get
			{
				if (this.O_o._0oo0o0_0. == null)
				{
					this.O_o._0oo0o0_0. = "";
				}
				return this.O_o._0oo0o0_0.;
			}
			set
			{
				this.O_o._0oo0o0_0. = value;
			}
		}

		// Token: 0x0400205C RID: 8284
		private string <<EMPTY_NAME>>;
	}
}
