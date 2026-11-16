using System;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x0200042C RID: 1068
	internal class Oo_0o_o : O_o_0o
	{
		// Token: 0x060048B2 RID: 18610 RVA: 0x001F4F16 File Offset: 0x001F3116
		internal Oo_0o_o(C1DockingTabPage A_0)
		{
			this.o0.0_O0000_O. = (C1DockingTab)A_0.Parent;
			this.o.o0. = A_0;
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x001F4F36 File Offset: 0x001F3136
		internal void <<EMPTY_NAME>>()
		{
			this.o0.0_O0000_O..TabPages.Remove(this.o.o0.);
		}

		// Token: 0x04001D4E RID: 7502
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x04001D4F RID: 7503
		private C1DockingTabPage <<EMPTY_NAME>>;
	}
}
