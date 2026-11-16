using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000EF RID: 239
	[DesignerGenerated]
	internal class oo00 : UserControl
	{
		// Token: 0x06000DB6 RID: 3510 RVA: 0x00071CA0 File Offset: 0x0006FEA0
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.OOOo_._oO0_O. != null)
				{
					this.OOOo_._oO0_O..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00071CE0 File Offset: 0x0006FEE0
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.OOOo_._oO0_O. = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00071CF4 File Offset: 0x0006FEF4
		protected override void OnPaint(PaintEventArgs e)
		{
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString("WebViewer", this.Font, Brushes.Black, (float)(base.ClientSize.Width / 2), (float)(base.ClientSize.Height / 2), stringFormat);
			base.OnPaint(e);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00071D5A File Offset: 0x0006FF5A
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Invalidate();
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00071D62 File Offset: 0x0006FF62
		public oo00()
		{
			base.Resize += this.OOOo_._oO0_O.;
			this.OOOo_._oO0_O.();
			this.BackColor = Color.White;
		}

		// Token: 0x04000553 RID: 1363
		private IContainer <<EMPTY_NAME>>;
	}
}
