using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003A6 RID: 934
	[DesignerGenerated]
	internal class O0___o0_ : UserControl
	{
		// Token: 0x06003D11 RID: 15633 RVA: 0x001BCA1E File Offset: 0x001BAC1E
		public O0___o0_()
		{
			base.Resize += this.o0o0O._o0Oo.;
			this.o0o0O._o0Oo.();
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x001BCA40 File Offset: 0x001BAC40
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.o0o0O._o0Oo. != null)
				{
					this.o0o0O._o0Oo..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x001BCA80 File Offset: 0x001BAC80
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.BorderStyle = BorderStyle.Fixed3D;
			base.Name = "o.....o0";
			base.Size = new Size(146, 146);
			base.ResumeLayout(false);
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x001BCAE0 File Offset: 0x001BACE0
		protected override void OnPaint(PaintEventArgs e)
		{
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString("主表", this.Font, Brushes.Black, (float)(base.ClientSize.Width / 2), (float)(base.ClientSize.Height / 2), stringFormat);
			base.OnPaint(e);
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x001BCB46 File Offset: 0x001BAD46
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Invalidate();
		}

		// Token: 0x04001914 RID: 6420
		private IContainer <<EMPTY_NAME>>;
	}
}
