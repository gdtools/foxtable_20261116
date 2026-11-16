using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000144 RID: 324
	[DesignerGenerated]
	public class o_O0 : UserControl
	{
		// Token: 0x0600101E RID: 4126 RVA: 0x0007CF44 File Offset: 0x0007B144
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.O.0O_oo. != null)
				{
					this.O.0O_oo..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0007CF84 File Offset: 0x0007B184
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O.0O_oo. = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0007CF98 File Offset: 0x0007B198
		protected override void OnPaint(PaintEventArgs e)
		{
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString("PDFViewer", this.Font, Brushes.Black, (float)(base.ClientSize.Width / 2), (float)(base.ClientSize.Height / 2), stringFormat);
			base.OnPaint(e);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0007CFFE File Offset: 0x0007B1FE
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Invalidate();
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0007D006 File Offset: 0x0007B206
		public o_O0()
		{
			base.Resize += this.O.0O_oo.;
			this.O.0O_oo.();
			this.BackColor = Color.White;
		}

		// Token: 0x04000645 RID: 1605
		private IContainer <<EMPTY_NAME>>;
	}
}
