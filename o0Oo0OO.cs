using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003A8 RID: 936
	[DesignerGenerated]
	internal class o0Oo0OO : UserControl
	{
		// Token: 0x06003D21 RID: 15649 RVA: 0x001BCBD8 File Offset: 0x001BADD8
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.O0___oo._0O00. != null)
				{
					this.O0___oo._0O00..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x001BCC18 File Offset: 0x001BAE18
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O0___oo._0O00. = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x001BCC2C File Offset: 0x001BAE2C
		protected override void OnPaint(PaintEventArgs e)
		{
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString("绘图板", this.Font, Brushes.Black, (float)(base.ClientSize.Width / 2), (float)(base.ClientSize.Height / 2), stringFormat);
			base.OnPaint(e);
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x001BCC92 File Offset: 0x001BAE92
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Invalidate();
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x001BCC9A File Offset: 0x001BAE9A
		public o0Oo0OO()
		{
			base.Resize += this.o00.Oo_OO0.;
			this.o00.Oo_OO0.();
			this.BackColor = Color.White;
		}

		// Token: 0x04001919 RID: 6425
		private IContainer <<EMPTY_NAME>>;
	}
}
