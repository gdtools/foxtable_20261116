using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003E2 RID: 994
	[DesignerGenerated]
	internal class O_oo : UserControl
	{
		// Token: 0x060040DC RID: 16604 RVA: 0x001D5E54 File Offset: 0x001D4054
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.o.oO00_. != null)
				{
					this.o.oO00_..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x001D5E94 File Offset: 0x001D4094
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o.oO00_. = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x001D5EA8 File Offset: 0x001D40A8
		protected override void OnPaint(PaintEventArgs e)
		{
			if (this.o.oO00_. != null)
			{
				this.BackgroundImage = this.o.oO00_.;
			}
			else
			{
				this.BackgroundImage = null;
			}
			base.OnPaint(e);
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x001D5ECE File Offset: 0x001D40CE
		public Bitmap <<EMPTY_NAME>>()
		{
			return this.o.oO00_.;
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x001D5ED6 File Offset: 0x001D40D6
		public void <<EMPTY_NAME>>(Bitmap A_0)
		{
			this.o.oO00_. = A_0;
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x001D5EDF File Offset: 0x001D40DF
		public O_oo()
		{
			base.SizeChanged += this.o.oO00_.;
			this.o.oO00_.();
			this.DoubleBuffered = true;
			this.BackgroundImageLayout = ImageLayout.None;
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x001D5F10 File Offset: 0x001D4110
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.oO00_. != null)
			{
				Bitmap image;
				if (base.AutoScrollMinSize.IsEmpty)
				{
					image = new Bitmap(Math.Max(base.ClientSize.Width, 1), Math.Max(1, base.ClientSize.Height));
				}
				else
				{
					image = new Bitmap(base.AutoScrollMinSize.Width, base.AutoScrollMinSize.Height);
				}
				Graphics graphics = Graphics.FromImage(image);
				graphics.DrawImage(this.o.oO00_., 0, 0);
				graphics.Dispose();
				this.o.oO00_..Dispose();
				this.o.oO00_. = image;
				this.BackgroundImage = this.o.oO00_.;
			}
		}

		// Token: 0x04001A2E RID: 6702
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001A2F RID: 6703
		private Bitmap <<EMPTY_NAME>>;
	}
}
