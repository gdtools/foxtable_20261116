using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x0200049B RID: 1179
	[OoO0___o("RibbonPaperList")]
	internal class RibbonPaperList : RibbonItem
	{
		// Token: 0x06004FD9 RID: 20441 RVA: 0x00238F56 File Offset: 0x00237156
		public RibbonPaperList(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06004FDA RID: 20442 RVA: 0x00238F67 File Offset: 0x00237167
		// (set) Token: 0x06004FDB RID: 20443 RVA: 0x00238F82 File Offset: 0x00237182
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		[DisplayName("标题")]
		public string Text
		{
			get
			{
				if (this.o0_.OO. == null)
				{
					this.o0_.OO. = "";
				}
				return this.o0_.OO.;
			}
			set
			{
				this.o0_.OO. = value;
			}
		}

		// Token: 0x040020A5 RID: 8357
		private string <<EMPTY_NAME>>;
	}
}
