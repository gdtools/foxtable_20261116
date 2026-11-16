using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200019C RID: 412
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class o\u3000\u3002\u3000\u3002\u3000 : Form
	{
		// Token: 0x06001363 RID: 4963 RVA: 0x000852F8 File Offset: 0x000834F8
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o00oO__o_.O__. != null)
				{
					this.o00oO__o_.O__..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00085338 File Offset: 0x00083538
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(261, 98);
			base.ControlBox = false;
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Name = "Forms";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "文件传输状态";
			base.ResumeLayout(false);
		}

		// Token: 0x06001365 RID: 4965
		[DllImport("user32")]
		private static extern bool AnimateWindow(IntPtr A_0, int A_1, int A_2);

		// Token: 0x06001366 RID: 4966 RVA: 0x000853B4 File Offset: 0x000835B4
		internal void <<EMPTY_NAME>>(Control A_0)
		{
			base.SuspendLayout();
			A_0.Width = base.ClientSize.Width;
			A_0.Height = 96;
			A_0.Top = base.Controls.Count * 96;
			A_0.Left = 0;
			base.Controls.Add(A_0);
			if (base.Controls.Count > 1)
			{
				base.Height += 96;
				base.Top -= 96;
			}
			base.ResumeLayout();
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0008543C File Offset: 0x0008363C
		internal void <<EMPTY_NAME>>(Control A_0)
		{
			int top = A_0.Top;
			base.Controls.Remove(A_0);
			if (base.Controls.Count > 0)
			{
				base.SuspendLayout();
				try
				{
					foreach (object obj in base.Controls)
					{
						Control control = (Control)obj;
						if (control.Top > top)
						{
							control.Top -= 96;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				base.Height -= 96;
				base.Top += 96;
				base.ResumeLayout();
				return;
			}
			base.Close();
			this.o00oO__o_.O__..ooOooo.oO. = null;
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00085508 File Offset: 0x00083708
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int x = Screen.PrimaryScreen.WorkingArea.Right - base.Width;
			int y = Screen.PrimaryScreen.WorkingArea.Bottom - base.Height;
			base.Location = new Point(x, y);
			o\u3000\u3002\u3000\u3002\u3000.AnimateWindow(base.Handle, 300, 393224);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0008556C File Offset: 0x0008376C
		public o\u3000\u3002\u3000\u3002\u3000(IMClient A_0)
		{
			base.Load += this.oOOOO.O.;
			this.oOOOO.O.();
			this.o00oO__o_.O__. = A_0;
			base.TopMost = true;
		}

		// Token: 0x040007B2 RID: 1970
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040007B3 RID: 1971
		private const int <<EMPTY_NAME>> = 1;

		// Token: 0x040007B4 RID: 1972
		private const int <<EMPTY_NAME>> = 2;

		// Token: 0x040007B5 RID: 1973
		private const int <<EMPTY_NAME>> = 4;

		// Token: 0x040007B6 RID: 1974
		private const int <<EMPTY_NAME>> = 8;

		// Token: 0x040007B7 RID: 1975
		private const int <<EMPTY_NAME>> = 16;

		// Token: 0x040007B8 RID: 1976
		private const int <<EMPTY_NAME>> = 65536;

		// Token: 0x040007B9 RID: 1977
		private const int <<EMPTY_NAME>> = 131072;

		// Token: 0x040007BA RID: 1978
		private const int <<EMPTY_NAME>> = 262144;

		// Token: 0x040007BB RID: 1979
		private const int <<EMPTY_NAME>> = 524288;

		// Token: 0x040007BC RID: 1980
		private IMClient <<EMPTY_NAME>>;
	}
}
