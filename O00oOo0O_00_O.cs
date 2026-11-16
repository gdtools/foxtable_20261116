using System;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x02000434 RID: 1076
	internal class O00oOo0O_00_O : O_o_0o
	{
		// Token: 0x060048C4 RID: 18628 RVA: 0x001F5530 File Offset: 0x001F3730
		internal O00oOo0O_00_O(C1NavBarPanel A_0)
		{
			this.o.oO0O0OO_o_. = (C1NavBar)A_0.Parent;
			this.o0o.OooOOo0__. = A_0;
			this.o.oO0O0OO_o_. = this.o.oO0O0OO_o_..Panels.IndexOf(this.o0o.OooOOo0__.);
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x001F556C File Offset: 0x001F376C
		internal void <<EMPTY_NAME>>()
		{
			this.o.oO0O0OO_o_..Panels.Insert(this.o.oO0O0OO_o_., this.o0o.OooOOo0__.);
			this.o.oO0O0OO_o_..SelectedButton = this.o0o.OooOOo0__..Button;
		}

		// Token: 0x04001D69 RID: 7529
		private C1NavBar <<EMPTY_NAME>>;

		// Token: 0x04001D6A RID: 7530
		private C1NavBarPanel <<EMPTY_NAME>>;

		// Token: 0x04001D6B RID: 7531
		private int <<EMPTY_NAME>>;
	}
}
