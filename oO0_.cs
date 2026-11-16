using System;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x02000430 RID: 1072
	internal class oO0_ : O_o_0o
	{
		// Token: 0x060048BB RID: 18619 RVA: 0x001F5284 File Offset: 0x001F3484
		internal oO0_(C1DockingTabPage A_0)
		{
			this.OOOOOoOO.o. = (C1DockingTab)A_0.Parent;
			this.OOOOOoOO.o. = A_0;
			this.OOOOOoOO.o. = this.OOOOOoOO.o..TabPages.IndexOf(this.OOOOOoOO.o.);
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x001F52C0 File Offset: 0x001F34C0
		internal void <<EMPTY_NAME>>()
		{
			this.OOOOOoOO.o..TabPages.Insert(this.OOOOOoOO.o., this.OOOOOoOO.o.);
			this.OOOOOoOO.o..ooO_O.O_O.();
			this.OOOOOoOO.o..SelectedTab = this.OOOOOoOO.o.;
		}

		// Token: 0x04001D5B RID: 7515
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x04001D5C RID: 7516
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x04001D5D RID: 7517
		private int <<EMPTY_NAME>>;

		// Token: 0x04001D5E RID: 7518
		internal ooo_0o <<EMPTY_NAME>>;
	}
}
