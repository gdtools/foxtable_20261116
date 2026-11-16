using System;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000439 RID: 1081
	internal class o00OOoo : O_o_0o
	{
		// Token: 0x060048D0 RID: 18640 RVA: 0x001F575D File Offset: 0x001F395D
		internal o00OOoo(ControlHolder A_0)
		{
			this.O00o.__OOo_. = A_0;
			this.O_O_Oo00o_.00_. = ((SplitContainer)this.O00o.__OOo_..ChildControl).SplitterDistance;
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x001F5787 File Offset: 0x001F3987
		internal void <<EMPTY_NAME>>()
		{
			((SplitContainer)this.O00o.__OOo_..ChildControl).SplitterDistance = this.O_O_Oo00o_.00_.;
			this.O00o.__OOo_..Selected = true;
		}

		// Token: 0x04001D75 RID: 7541
		private ControlHolder <<EMPTY_NAME>>;

		// Token: 0x04001D76 RID: 7542
		private int <<EMPTY_NAME>>;
	}
}
