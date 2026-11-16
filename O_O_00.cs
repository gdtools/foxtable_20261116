using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003AE RID: 942
	[DesignerGenerated]
	internal class O_O_00 : UserControl
	{
		// Token: 0x06003D48 RID: 15688 RVA: 0x001BD3F0 File Offset: 0x001BB5F0
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.Ooo__.ooO_0. != null)
				{
					this.Ooo__.ooO_0..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x001BD430 File Offset: 0x001BB630
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Ooo__.ooO_0. = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x001BD444 File Offset: 0x001BB644
		protected override void OnPaint(PaintEventArgs e)
		{
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString("网页浏览器(已过时)", this.Font, Brushes.Black, (float)(base.ClientSize.Width / 2), (float)(base.ClientSize.Height / 2), stringFormat);
			base.OnPaint(e);
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x001BD4AA File Offset: 0x001BB6AA
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Invalidate();
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x001BD4B2 File Offset: 0x001BB6B2
		public O_O_00()
		{
			base.Resize += this.Ooo__.ooO_0.;
			this.Ooo__.ooO_0.();
			this.BackColor = Color.White;
		}

		// Token: 0x04001924 RID: 6436
		private IContainer <<EMPTY_NAME>>;
	}
}
