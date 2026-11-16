using System;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x02000435 RID: 1077
	internal class o_O0oO_0 : O_o_0o
	{
		// Token: 0x060048C6 RID: 18630 RVA: 0x001F55A0 File Offset: 0x001F37A0
		internal o_O0oO_0(C1DockingTabPage A_0)
		{
			this.o0o.OooOOo0__. = (C1DockingTab)A_0.Parent;
			this.o0o.OooOOo0__. = A_0;
			this.o0o.OooOOo0__. = this.o0o.OooOOo0__..TabPages.IndexOf(this.o0o.OooOOo0__.);
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x001F55DC File Offset: 0x001F37DC
		internal void <<EMPTY_NAME>>()
		{
			this.o0o.OooOOo0__..TabPages.Insert(this.o0o.OooOOo0__., this.o0o.OooOOo0__.);
			this.o0o.OooOOo0__..SelectedTab = this.o0o.OooOOo0__.;
		}

		// Token: 0x04001D6C RID: 7532
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x04001D6D RID: 7533
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x04001D6E RID: 7534
		private int <<EMPTY_NAME>>;
	}
}
