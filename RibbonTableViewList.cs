using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x020004A1 RID: 1185
	[OoO0___o("RibbonTableViewList")]
	internal class RibbonTableViewList : RibbonItem
	{
		// Token: 0x06005006 RID: 20486 RVA: 0x00239125 File Offset: 0x00237325
		public RibbonTableViewList(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06005007 RID: 20487 RVA: 0x00239136 File Offset: 0x00237336
		// (set) Token: 0x06005008 RID: 20488 RVA: 0x00239151 File Offset: 0x00237351
		[Category("属性")]
		[O_Oo00Oo000O0(1.1)]
		[DisplayName("标题")]
		public string Text
		{
			get
			{
				if (this.O0oo0.o. == null)
				{
					this.O0oo0.o. = "";
				}
				return this.O0oo0.o.;
			}
			set
			{
				this.O0oo0.o. = value;
			}
		}

		// Token: 0x040020B3 RID: 8371
		private string <<EMPTY_NAME>>;
	}
}
