using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000198 RID: 408
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002 : Form
	{
		// Token: 0x0600133C RID: 4924 RVA: 0x00084383 File Offset: 0x00082583
		public O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002()
		{
			base.FormClosing += this.O.oO0_.;
			base.Load += this.O_.O0_oo0.;
			this.ooo0.oO0_. = new Stack<O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002.oooO0o00>();
			this.o.o0Oo_Ooo_0O.();
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x000843C0 File Offset: 0x000825C0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.ooo0.oO0_. != null)
				{
					this.ooo0.oO0_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00084400 File Offset: 0x00082600
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.ooo0.oO0_. = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002));
			this.o.o0Oo_Ooo_0O.(new ImageList(this.ooo0.oO0_.));
			this.O_.O0_oo0.(new Label());
			this.o.o0Oo_Ooo_0O.(new Label());
			this.o.o0Oo_Ooo_0O.(new Timer(this.ooo0.oO0_.));
			base.SuspendLayout();
			this.o.o0Oo_Ooo_0O.().ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
			this.o.o0Oo_Ooo_0O.().TransparentColor = Color.Transparent;
			this.o.o0Oo_Ooo_0O.().Images.SetKeyName(0, "info");
			this.o.o0Oo_Ooo_0O.().Images.SetKeyName(1, "OK");
			this.o.o0Oo_Ooo_0O.().Images.SetKeyName(2, "alert");
			this.o.o0Oo_Ooo_0O.().Images.SetKeyName(3, "error");
			this.o.o0Oo_Ooo_0O.().Images.SetKeyName(4, "question");
			this.o.o0Oo_Ooo_0O.().ImageIndex = 0;
			this.o.o0Oo_Ooo_0O.().ImageList = this.o.o0Oo_Ooo_0O.();
			this.o.o0Oo_Ooo_0O.().Location = new Point(10, 24);
			this.o.o0Oo_Ooo_0O.().Name = "lblIcon";
			this.o.o0Oo_Ooo_0O.().Size = new Size(28, 28);
			this.o.o0Oo_Ooo_0O.().TabIndex = 0;
			this.O_.O0_oo0.().Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.O_.O0_oo0.().Location = new Point(50, 22);
			this.O_.O0_oo0.().Name = "lblMessage";
			this.O_.O0_oo0.().Size = new Size(237, 62);
			this.O_.O0_oo0.().TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(239, 246, 253);
			base.ClientSize = new Size(299, 93);
			base.Controls.Add(this.O_.O0_oo0.());
			base.Controls.Add(this.o.o0Oo_Ooo_0O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.O.O.0.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "信息";
			base.ResumeLayout(false);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00084672 File Offset: 0x00082872
		[CompilerGenerated]
		internal virtual ImageList <<EMPTY_NAME>>()
		{
			return this.o.oOoO__o.;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0008467A File Offset: 0x0008287A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ImageList A_0)
		{
			this.o.oOoO__o. = A_0;
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00084683 File Offset: 0x00082883
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.oOoO__o.;
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0008468B File Offset: 0x0008288B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.oOoO__o. = A_0;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00084694 File Offset: 0x00082894
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.o0O_0OO__O.;
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0008469C File Offset: 0x0008289C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.o0O_0OO__O. = A_0;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x000846A5 File Offset: 0x000828A5
		[CompilerGenerated]
		internal virtual Timer <<EMPTY_NAME>>()
		{
			return this.o.oOoO__o.;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000846B0 File Offset: 0x000828B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Timer A_0)
		{
			EventHandler value = new EventHandler(this.o.oOoO__o.);
			Timer timer = this.o.oOoO__o.;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.o.oOoO__o. = A_0;
			timer = this.o.oOoO__o.;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06001347 RID: 4935
		[DllImport("user32")]
		private static extern bool AnimateWindow(IntPtr A_0, int A_1, int A_2);

		// Token: 0x06001348 RID: 4936 RVA: 0x000846F4 File Offset: 0x000828F4
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			if (this.ooo0.oO0_..Count > 0)
			{
				this.ooo0.oO0_. = this.ooo0.oO0_..Pop();
				this.o.o0Oo_Ooo_0O.().ImageIndex = this.ooo0.oO0_..ooo0.oO0_.;
				this.O_.O0_oo0.().Text = this.ooo0.oO0_..oOooOoOo._0Oo.;
				this.Text = this.ooo0.oO0_..o_o0_0OO.OoOO.;
				if (this.ooo0.oO0_..o_o0_0OO.OoOO. > 0)
				{
					this.o.o0Oo_Ooo_0O.().Interval = this.ooo0.oO0_..o_o0_0OO.OoOO. * 1000;
					this.o.o0Oo_Ooo_0O.().Enabled = true;
				}
				else
				{
					this.o.o0Oo_Ooo_0O.().Enabled = false;
				}
				A_1.Cancel = true;
				return;
			}
			this.ooo0.oO0_. = null;
			O_O0OO.o.0__0_O_. = null;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x000847BC File Offset: 0x000829BC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int x = Screen.PrimaryScreen.WorkingArea.Right - base.Width;
			int y = Screen.PrimaryScreen.WorkingArea.Bottom - base.Height;
			base.Location = new Point(x, y);
			O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002.AnimateWindow(base.Handle, 1000, 393224);
			base.TopMost = true;
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00084828 File Offset: 0x00082A28
		internal void <<EMPTY_NAME>>(string A_0, string A_1, int A_2, int A_3)
		{
			if (this.ooo0.oO0_. != null)
			{
				this.ooo0.oO0_..Push(this.ooo0.oO0_.);
			}
			this.ooo0.oO0_. = new O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002.oooO0o00(A_0, A_1, A_2, A_3);
			this.o.o0Oo_Ooo_0O.().ImageIndex = A_2;
			this.O_.O0_oo0.().Text = A_0;
			this.Text = A_1;
			base.Show();
			if (A_3 > 0)
			{
				this.o.o0Oo_Ooo_0O.().Interval = A_3 * 1000;
				this.o.o0Oo_Ooo_0O.().Enabled = true;
				return;
			}
			this.o.o0Oo_Ooo_0O.().Enabled = false;
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x000848B4 File Offset: 0x00082AB4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.o0Oo_Ooo_0O.().Enabled = false;
			base.Close();
		}

		// Token: 0x04000781 RID: 1921
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000782 RID: 1922
		[CompilerGenerated]
		private ImageList <<EMPTY_NAME>>;

		// Token: 0x04000783 RID: 1923
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000784 RID: 1924
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000785 RID: 1925
		[CompilerGenerated]
		private Timer <<EMPTY_NAME>>;

		// Token: 0x04000786 RID: 1926
		private const int <<EMPTY_NAME>> = 2;

		// Token: 0x04000787 RID: 1927
		private const int <<EMPTY_NAME>> = 4;

		// Token: 0x04000788 RID: 1928
		private const int <<EMPTY_NAME>> = 8;

		// Token: 0x04000789 RID: 1929
		private const int <<EMPTY_NAME>> = 16;

		// Token: 0x0400078A RID: 1930
		private const int <<EMPTY_NAME>> = 65536;

		// Token: 0x0400078B RID: 1931
		private const int <<EMPTY_NAME>> = 131072;

		// Token: 0x0400078C RID: 1932
		private const int <<EMPTY_NAME>> = 262144;

		// Token: 0x0400078D RID: 1933
		private const int <<EMPTY_NAME>> = 524288;

		// Token: 0x0400078E RID: 1934
		private Stack<O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002.oooO0o00> <<EMPTY_NAME>>;

		// Token: 0x0400078F RID: 1935
		private O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002.oooO0o00 <<EMPTY_NAME>>;

		// Token: 0x02000199 RID: 409
		private class oooO0o00
		{
			// Token: 0x0600134C RID: 4940 RVA: 0x000848C8 File Offset: 0x00082AC8
			internal oooO0o00(string A_0, string A_1, int A_2, int A_3)
			{
				this.o_o0_0OO.OoOO. = -1;
				this.oOooOoOo._0Oo. = A_0;
				this.o_o0_0OO.OoOO. = A_1;
				this.ooo0.oO0_. = A_2;
				this.o_o0_0OO.OoOO. = A_3;
			}

			// Token: 0x04000790 RID: 1936
			internal string <<EMPTY_NAME>>;

			// Token: 0x04000791 RID: 1937
			internal string <<EMPTY_NAME>>;

			// Token: 0x04000792 RID: 1938
			internal int <<EMPTY_NAME>>;

			// Token: 0x04000793 RID: 1939
			internal int <<EMPTY_NAME>>;
		}
	}
}
