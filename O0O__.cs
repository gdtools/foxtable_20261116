using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200026F RID: 623
	[DesignerGenerated]
	internal class O0O__ : UserControl
	{
		// Token: 0x06001E3A RID: 7738 RVA: 0x000D025C File Offset: 0x000CE45C
		public O0O__()
		{
			this.oo0oO_O.oooO0O.();
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x000D026C File Offset: 0x000CE46C
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.oo0oO_O.oooO0O. != null)
				{
					this.oo0oO_O.oooO0O..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x000D02AC File Offset: 0x000CE4AC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.BorderStyle = BorderStyle.Fixed3D;
			base.Name = "o...o.O.";
			base.Size = new Size(154, 203);
			base.ResumeLayout(false);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x000D0309 File Offset: 0x000CE509
		public string <<EMPTY_NAME>>()
		{
			return this.oo0oO_O.oooO0O.;
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x000D0311 File Offset: 0x000CE511
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.oo0oO_O.oooO0O. = A_0;
			base.Invalidate();
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x000D0320 File Offset: 0x000CE520
		protected override void OnPaint(PaintEventArgs e)
		{
			StringFormat stringFormat = new StringFormat();
			string s;
			if (Operators.CompareString(this.oo0oO_O.oooO0O.(), "", true) == 0)
			{
				s = "记录窗口";
			}
			else
			{
				s = "记录窗口(" + this.oo0oO_O.oooO0O.() + ")";
			}
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString(s, this.Font, Brushes.Black, (float)(base.ClientSize.Width / 2), (float)(base.ClientSize.Height / 2), stringFormat);
			base.OnPaint(e);
		}

		// Token: 0x04000CBE RID: 3262
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000CBF RID: 3263
		private string <<EMPTY_NAME>>;
	}
}
