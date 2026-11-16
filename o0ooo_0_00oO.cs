using System;
using System.Windows.Forms;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x02000090 RID: 144
	internal class o0ooo_0_00oO : C1TopicBar
	{
		// Token: 0x0600057D RID: 1405 RVA: 0x0002DF81 File Offset: 0x0002C181
		public o0ooo_0_00oO()
		{
			base.ParentChanged += this.OO0_0oOo.o.;
			base.VisualStyle = VisualStyle.Custom;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0002DFA2 File Offset: 0x0002C1A2
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.FindForm() != null)
			{
				Main.OO_O.o..o.O000oo.(new object[]
				{
					this
				});
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0002DFC0 File Offset: 0x0002C1C0
		protected virtual void <<EMPTY_NAME>>(PaintEventArgs A_0)
		{
			if (base.LinkStyle.NormalPage.PressedLink.ForeColor != base.LinkStyle.NormalPage.NormalLink.ForeColor)
			{
				base.LinkStyle.NormalPage.PressedLink.ForeColor = base.LinkStyle.NormalPage.NormalLink.ForeColor;
			}
			base.OnPaint(A_0);
		}
	}
}
