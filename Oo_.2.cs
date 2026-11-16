using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x0200014F RID: 335
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Oo_ : C1TopicBar
	{
		// Token: 0x0600105C RID: 4188 RVA: 0x0007DACB File Offset: 0x0007BCCB
		internal Oo_()
		{
			base.Padding = new Padding(6);
			base.VisualStyle = VisualStyle.Custom;
			Main.OO_O.o..o.O000oo.(new object[]
			{
				this
			});
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0007DAFA File Offset: 0x0007BCFA
		public virtual Font <<EMPTY_NAME>>()
		{
			return base.Font;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0007DB04 File Offset: 0x0007BD04
		public virtual void <<EMPTY_NAME>>(Font A_0)
		{
			base.Font = A_0;
			base.LinkStyle.NormalPage.DisabledLink.Font = A_0;
			base.LinkStyle.NormalPage.MouseOverLink.Font = new Font((Font)A_0.Clone(), this.O_o.0.().Style | FontStyle.Underline);
			base.LinkStyle.NormalPage.NormalLink.Font = A_0;
			base.LinkStyle.NormalPage.PressedLink.Font = A_0;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0007DB8C File Offset: 0x0007BD8C
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
