using System;
using System.Drawing;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020003B4 RID: 948
	internal class o0O__ooOO00 : Label
	{
		// Token: 0x06003D9E RID: 15774 RVA: 0x001BECD4 File Offset: 0x001BCED4
		public o0O__ooOO00()
		{
			base.Click += this.OO_._0_oO__0.;
			base.ParentChanged += this.o.O_oO.;
			this.BackColor = Color.Blue;
			this.ForeColor = Color.White;
			this.TextAlign = ContentAlignment.MiddleCenter;
			base.Size = new Size(20, 16);
			base.Location = new Point(0, 0);
			base.Visible = false;
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x001BED4C File Offset: 0x001BCF4C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			O0_0_0_0_ o0_0_0_0_;
			if (base.Parent.Parent is PictureBox)
			{
				o0_0_0_0_ = (O0_0_0_0_)base.Parent.Parent.Parent;
			}
			else
			{
				o0_0_0_0_ = (O0_0_0_0_)base.Parent.Parent;
			}
			base.Parent.TabIndex = o0_0_0_0_.O0.o0O_o00_O.();
			o0_0_0_0_.O0.o0O_o00_O.(o0_0_0_0_.O0.o0O_o00_O.() + 1);
			if (o0_0_0_0_.O0.o0O_o00_O.() > o0_0_0_0_.OOO_0_oo0.Oo0_.())
			{
				o0_0_0_0_.O0.o0O_o00_O.(0);
			}
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x001BEDC8 File Offset: 0x001BCFC8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.Text = Convert.ToString(base.Parent.TabIndex);
			base.BringToFront();
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x001BEDE6 File Offset: 0x001BCFE6
		public void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.Text = Convert.ToString(base.Parent.TabIndex);
		}
	}
}
