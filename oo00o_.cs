using System;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x02000093 RID: 147
	internal class oo00o_ : C1DockingTab
	{
		// Token: 0x060005AC RID: 1452 RVA: 0x0002E631 File Offset: 0x0002C831
		public oo00o_()
		{
			base.ParentChanged += this.o.o_.;
			base.VisualStyle = VisualStyle.Custom;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0002E652 File Offset: 0x0002C852
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.FindForm() != null)
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(Main.OO_O.o..o00o_OO_o_._o.(), new object[]
				{
					this
				});
			}
		}
	}
}
