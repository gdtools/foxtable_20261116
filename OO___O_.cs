using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003A3 RID: 931
	[DesignerGenerated]
	internal class OO___O_ : UserControl
	{
		// Token: 0x06003CFA RID: 15610 RVA: 0x001BC806 File Offset: 0x001BAA06
		public OO___O_()
		{
			base.Resize += this.o__.OOO_0Oo.;
			this.o__.OOO_0Oo.();
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x001BC828 File Offset: 0x001BAA28
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.o__.OOO_0Oo. != null)
				{
					this.o__.OOO_0Oo..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x001BC868 File Offset: 0x001BAA68
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.BorderStyle = BorderStyle.FixedSingle;
			base.Name = "O.......";
			base.Size = new Size(148, 148);
			base.ResumeLayout(false);
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x001BC8C8 File Offset: 0x001BAAC8
		protected override void OnPaint(PaintEventArgs e)
		{
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString("图表", this.Font, Brushes.Black, (float)(base.ClientSize.Width / 2), (float)(base.ClientSize.Height / 2), stringFormat);
			base.OnPaint(e);
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x001BC92E File Offset: 0x001BAB2E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Invalidate();
		}

		// Token: 0x0400190E RID: 6414
		private IContainer <<EMPTY_NAME>>;
	}
}
