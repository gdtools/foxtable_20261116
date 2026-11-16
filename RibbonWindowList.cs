using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x020004A7 RID: 1191
	[OoO0___o("RibbonWindowList")]
	internal class RibbonWindowList : RibbonItem
	{
		// Token: 0x0600502F RID: 20527 RVA: 0x002392FC File Offset: 0x002374FC
		public RibbonWindowList(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06005030 RID: 20528 RVA: 0x0023930D File Offset: 0x0023750D
		// (set) Token: 0x06005031 RID: 20529 RVA: 0x00239328 File Offset: 0x00237528
		[DisplayName("标题")]
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		public string Text
		{
			get
			{
				if (this.O0.o0__OOo00O. == null)
				{
					this.O0.o0__OOo00O. = "";
				}
				return this.O0.o0__OOo00O.;
			}
			set
			{
				this.O0.o0__OOo00O. = value;
			}
		}

		// Token: 0x040020C1 RID: 8385
		private string <<EMPTY_NAME>>;
	}
}
