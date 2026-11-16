using System;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x0200042B RID: 1067
	internal class OOO0oO_ : O_o_0o
	{
		// Token: 0x060048B0 RID: 18608 RVA: 0x001F4EDE File Offset: 0x001F30DE
		internal OOO0oO_(C1NavBarPanel A_0)
		{
			this.o.o0. = (C1NavBar)A_0.Parent;
			this.o.o0. = A_0;
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x001F4EFE File Offset: 0x001F30FE
		internal void <<EMPTY_NAME>>()
		{
			this.o.o0..Panels.Remove(this.o.o0.);
		}

		// Token: 0x04001D4C RID: 7500
		private C1NavBar <<EMPTY_NAME>>;

		// Token: 0x04001D4D RID: 7501
		private C1NavBarPanel <<EMPTY_NAME>>;
	}
}
