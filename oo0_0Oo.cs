using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020003A9 RID: 937
	internal class oo0_0Oo : Panel, O0_0_0_0_
	{
		// Token: 0x06003D26 RID: 15654 RVA: 0x001BCCC5 File Offset: 0x001BAEC5
		public oo0_0Oo()
		{
			base.MouseMove += this.oO0O0.o.;
			base.MouseUp += this.O0___oo._0O00.;
			base.ResizeRedraw = true;
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x001BCCF8 File Offset: 0x001BAEF8
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (base.BorderStyle == BorderStyle.None)
			{
				Graphics graphics = e.Graphics;
				Pen pen = new Pen(SystemColors.ControlDark);
				Rectangle rect = new Rectangle(0, 0, base.Width - 1, base.Height - 1);
				pen.DashStyle = DashStyle.Dash;
				graphics.DrawRectangle(pen, rect);
				graphics.Dispose();
			}
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x001BCD52 File Offset: 0x001BAF52
		public int <<EMPTY_NAME>>()
		{
			return this.O0___oo._0O00.;
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x001BCD5A File Offset: 0x001BAF5A
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.O0___oo._0O00. = A_0;
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x001BCD63 File Offset: 0x001BAF63
		public int <<EMPTY_NAME>>()
		{
			return this.oO_._o.;
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x001BCD6B File Offset: 0x001BAF6B
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.oO_._o. = A_0;
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x001BCD74 File Offset: 0x001BAF74
		public void <<EMPTY_NAME>>()
		{
			oOO0oo_o0.O00OO_O_oO_.o.(this, base.Controls);
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x001BCD82 File Offset: 0x001BAF82
		public void <<EMPTY_NAME>>()
		{
			oOO0oo_o0.O._0O0__o.(base.Controls);
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x001BCD8F File Offset: 0x001BAF8F
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (A_1.Button == MouseButtons.Left)
			{
				this.Refresh();
			}
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x001BCDA4 File Offset: 0x001BAFA4
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			this.Refresh();
		}

		// Token: 0x0400191A RID: 6426
		private int <<EMPTY_NAME>>;

		// Token: 0x0400191B RID: 6427
		private int <<EMPTY_NAME>>;
	}
}
