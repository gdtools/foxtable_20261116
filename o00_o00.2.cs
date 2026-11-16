using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001A5 RID: 421
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o00_o00 : UserControl
	{
		// Token: 0x060014C6 RID: 5318 RVA: 0x00096FD0 File Offset: 0x000951D0
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

		// Token: 0x060014C7 RID: 5319 RVA: 0x00097010 File Offset: 0x00095210
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0o0O._o0Oo. = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00097024 File Offset: 0x00095224
		protected override void OnPaint(PaintEventArgs e)
		{
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString("ListView", this.Font, Brushes.Black, (float)(base.ClientSize.Width / 2), (float)(base.ClientSize.Height / 2), stringFormat);
			base.OnPaint(e);
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0009708A File Offset: 0x0009528A
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Invalidate();
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00097092 File Offset: 0x00095292
		public o00_o00()
		{
			base.Resize += this.O.00_Oo.;
			this.o0o0O._o0Oo.();
			this.BackColor = Color.White;
		}

		// Token: 0x0400083A RID: 2106
		private IContainer <<EMPTY_NAME>>;
	}
}
