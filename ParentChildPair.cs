using System;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000436 RID: 1078
	internal class ParentChildPair
	{
		// Token: 0x060048C8 RID: 18632 RVA: 0x001F560B File Offset: 0x001F380B
		internal ParentChildPair(ControlHolder A_0)
		{
			this.Holder = A_0;
			this.Parent = A_0.Parent;
		}

		// Token: 0x04001D6F RID: 7535
		internal ControlHolder Holder;

		// Token: 0x04001D70 RID: 7536
		internal Control Parent;
	}
}
