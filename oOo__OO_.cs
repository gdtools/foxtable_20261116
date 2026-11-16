using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003AC RID: 940
	[DesignerGenerated]
	internal class oOo__OO_ : UserControl
	{
		// Token: 0x06003D3C RID: 15676 RVA: 0x001BCEFD File Offset: 0x001BB0FD
		public oOo__OO_()
		{
			this.ooO.Oo000_.();
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x001BCF0C File Offset: 0x001BB10C
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.ooO.Oo000_. != null)
				{
					this.ooO.Oo000_..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x001BCF4C File Offset: 0x001BB14C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.BorderStyle = BorderStyle.Fixed3D;
			base.Name = "o..OO..o";
			base.Size = new Size(197, 145);
			base.ResumeLayout(false);
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x001BCFA9 File Offset: 0x001BB1A9
		public string <<EMPTY_NAME>>()
		{
			return this.ooO.Oo000_.;
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x001BCFB1 File Offset: 0x001BB1B1
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.ooO.Oo000_. = A_0;
			base.Invalidate();
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x001BCFC0 File Offset: 0x001BB1C0
		protected override void OnPaint(PaintEventArgs e)
		{
			StringFormat stringFormat = new StringFormat();
			string s;
			if (Operators.CompareString(this.ooO.Oo000_.(), "", true) == 0)
			{
				s = "表";
			}
			else
			{
				s = "表(" + this.ooO.Oo000_.() + ")";
			}
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString(s, this.Font, Brushes.Black, (float)(base.ClientSize.Width / 2), (float)(base.ClientSize.Height / 2), stringFormat);
			base.OnPaint(e);
		}

		// Token: 0x04001920 RID: 6432
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001921 RID: 6433
		private string <<EMPTY_NAME>>;
	}
}
