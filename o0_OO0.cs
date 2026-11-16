using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020003AB RID: 939
	internal class o0_OO0 : Panel, O0_0_0_0_
	{
		// Token: 0x06003D33 RID: 15667 RVA: 0x001BCE24 File Offset: 0x001BB024
		public o0_OO0()
		{
			this.Dock = DockStyle.Fill;
			this.BackColor = Color.Transparent;
			base.ResizeRedraw = true;
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x001BCE48 File Offset: 0x001BB048
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (((o0000O)base.Parent.Parent).BorderStyle == BorderStyle.None)
			{
				Graphics graphics = e.Graphics;
				Pen pen = new Pen(SystemColors.ControlDark);
				Rectangle rect = new Rectangle(0, 0, base.Width - 1, base.Height - 1);
				pen.DashStyle = DashStyle.Dash;
				graphics.DrawRectangle(pen, rect);
				graphics.Dispose();
			}
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x001BCEB1 File Offset: 0x001BB0B1
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			base.Invalidate();
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x001BCEC0 File Offset: 0x001BB0C0
		public int <<EMPTY_NAME>>()
		{
			return this.o__O0_.o_.;
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x001BCEC8 File Offset: 0x001BB0C8
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.o__O0_.o_. = A_0;
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x001BCED1 File Offset: 0x001BB0D1
		public int <<EMPTY_NAME>>()
		{
			return this.oo0oo__0o.O.;
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x001BCED9 File Offset: 0x001BB0D9
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.oo0oo__0o.O. = A_0;
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x001BCEE2 File Offset: 0x001BB0E2
		public void <<EMPTY_NAME>>()
		{
			oOO0oo_o0.O00OO_O_oO_.o.(this, base.Controls);
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x001BCEF0 File Offset: 0x001BB0F0
		public void <<EMPTY_NAME>>()
		{
			oOO0oo_o0.O._0O0__o.(base.Controls);
		}

		// Token: 0x0400191E RID: 6430
		private int <<EMPTY_NAME>>;

		// Token: 0x0400191F RID: 6431
		private int <<EMPTY_NAME>>;
	}
}
