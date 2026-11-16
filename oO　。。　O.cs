using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200019A RID: 410
	[DesignerGenerated]
	internal partial class oO\u3000\u3002\u3002\u3000O\u3000 : Form
	{
		// Token: 0x0600134D RID: 4941 RVA: 0x000848F4 File Offset: 0x00082AF4
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OOo._o0__0Ooo_. != null)
				{
					this.OOo._o0__0Ooo_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00084934 File Offset: 0x00082B34
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.OOo._o0__0Ooo_. = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(oO\u3000\u3002\u3002\u3000O\u3000));
			this.o___.O0OOOO.(new PictureBox());
			this.o0_o.oO.(new Label());
			this.o___.O0OOOO.(new Label());
			this.O_.0OOOOO0o0.(new Label());
			this.o___.O0OOOO.(new C1Button());
			this.oO000._0OO0.(new Timer(this.OOo._o0__0Ooo_.));
			((ISupportInitialize)this.o___.O0OOOO.()).BeginInit();
			base.SuspendLayout();
			this.o___.O0OOOO.().Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.o___.O0OOOO.().Location = new Point(12, 12);
			this.o___.O0OOOO.().Name = "PictureBox1";
			this.o___.O0OOOO.().Size = new Size(48, 43);
			this.o___.O0OOOO.().TabIndex = 0;
			this.o___.O0OOOO.().TabStop = false;
			this.OO0.OO_O_oO_0.().AutoSize = true;
			this.OO0.OO_O_oO_0.().Location = new Point(66, 12);
			this.OO0.OO_O_oO_0.().Name = "Label1";
			this.OO0.OO_O_oO_0.().Size = new Size(95, 12);
			this.OO0.OO_O_oO_0.().TabIndex = 1;
			this.OO0.OO_O_oO_0.().Text = "OpenQQ失去连接!";
			this.O_.0OOOOO0o0.().AutoSize = true;
			this.O_.0OOOOO0o0.().Location = new Point(66, 34);
			this.O_.0OOOOO0o0.().Name = "Label2";
			this.O_.0OOOOO0o0.().Size = new Size(239, 12);
			this.O_.0OOOOO0o0.().TabIndex = 2;
			this.O_.0OOOOO0o0.().Text = "由于网络问题，OpenQQ失去和服务器的连接!";
			this.o0_o.oO.().AutoSize = true;
			this.o0_o.oO.().Location = new Point(66, 55);
			this.o0_o.oO.().Name = "Label3";
			this.o0_o.oO.().Size = new Size(119, 12);
			this.o0_o.oO.().TabIndex = 3;
			this.o0_o.oO.().Text = "正在重新连接服务器.";
			this.OO0.OO_O_oO_0.().Location = new Point(119, 91);
			this.OO0.OO_O_oO_0.().Name = "Button1";
			this.OO0.OO_O_oO_0.().Size = new Size(75, 23);
			this.OO0.OO_O_oO_0.().TabIndex = 4;
			this.OO0.OO_O_oO_0.().Text = "取消";
			this.OO0.OO_O_oO_0.().UseVisualStyleBackColor = true;
			this.OO0.OO_O_oO_0.().VisualStyleBaseStyle = VisualStyle.Office2007Black;
			this.o___.O0OOOO.().Enabled = true;
			this.o___.O0OOOO.().Interval = 1000;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(239, 246, 253);
			base.ClientSize = new Size(312, 126);
			base.ControlBox = false;
			base.Controls.Add(this.OO0.OO_O_oO_0.());
			base.Controls.Add(this.o0_o.oO.());
			base.Controls.Add(this.O_.0OOOOO0o0.());
			base.Controls.Add(this.OO0.OO_O_oO_0.());
			base.Controls.Add(this.o___.O0OOOO.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Name = "Oo0o....";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "提示";
			((ISupportInitialize)this.o___.O0OOOO.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00084CB2 File Offset: 0x00082EB2
		[CompilerGenerated]
		internal virtual PictureBox <<EMPTY_NAME>>()
		{
			return this.oO000._0OO0.;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00084CBA File Offset: 0x00082EBA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PictureBox A_0)
		{
			this.oO000._0OO0. = A_0;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00084CC3 File Offset: 0x00082EC3
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oO000._0OO0.;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00084CCB File Offset: 0x00082ECB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oO000._0OO0. = A_0;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00084CD4 File Offset: 0x00082ED4
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O___O_0O_O_.O.;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00084CDC File Offset: 0x00082EDC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O___O_0O_O_.O. = A_0;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00084CE5 File Offset: 0x00082EE5
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo___O___O_.O_.;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00084CED File Offset: 0x00082EED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo___O___O_.O_. = A_0;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00084CF6 File Offset: 0x00082EF6
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO000._0OO0.;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00084D00 File Offset: 0x00082F00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO0.OO_O_oO_0.);
			C1Button c1Button = this.oO000._0OO0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO000._0OO0. = A_0;
			c1Button = this.oO000._0OO0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00084D43 File Offset: 0x00082F43
		[CompilerGenerated]
		internal virtual Timer <<EMPTY_NAME>>()
		{
			return this.oO000._0OO0.;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00084D4C File Offset: 0x00082F4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Timer A_0)
		{
			EventHandler value = new EventHandler(this.O___O_0O_O_.O.);
			Timer timer = this.oO000._0OO0.;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.oO000._0OO0. = A_0;
			timer = this.oO000._0OO0.;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00084D90 File Offset: 0x00082F90
		internal oO\u3000\u3002\u3002\u3000O\u3000(IMClient A_0, IPEndPoint A_1)
		{
			base.FormClosing += this.OO0.OO_O_oO_0.;
			base.Load += this.Oo.Oo_O0_O0.;
			this.OOo._o0__0Ooo_. = "\u0004" + OoOo0O.OO_o.0o_O.(3) + "\u0004";
			this.O_.0o_o0o. = DateTime.Now;
			this.o___.O0OOOO.();
			this.OOo._o0__0Ooo_. = A_0;
			this.O_OooO.0oOOO0. = A_1;
			this.O_OooO.0oOOO0. = new UdpClient(0);
			o0___oO.O.oOo0O0O.(this.O_OooO.0oOOO0.);
		}

		// Token: 0x0600135C RID: 4956
		[DllImport("user32")]
		private static extern bool AnimateWindow(IntPtr A_0, int A_1, int A_2);

		// Token: 0x0600135D RID: 4957 RVA: 0x00084E18 File Offset: 0x00083018
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			this.o___.O0OOOO.().Enabled = false;
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00084E28 File Offset: 0x00083028
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int x = Screen.PrimaryScreen.WorkingArea.Right - base.Width;
			int y = Screen.PrimaryScreen.WorkingArea.Bottom - base.Height;
			base.Location = new Point(x, y);
			oO\u3000\u3002\u3002\u3000O\u3000.AnimateWindow(base.Handle, 300, 393224);
			base.TopMost = true;
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00084E94 File Offset: 0x00083094
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = this.o0_o.oO.().Text;
			string text2 = this.o0_o.oO.().Text.Replace(".", "");
			if (text.Length - text2.Length >= 6)
			{
				this.o0_o.oO.().Text = text2 + ".";
			}
			else
			{
				this.o0_o.oO.().Text = text + ".";
			}
			if (!OO_00oOO.IMClients.ContainsKey(this.OOo._o0__0Ooo_..Name))
			{
				base.Close();
				return;
			}
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				this.O_.0o_o0o. = DateTime.Now;
				return;
			}
			try
			{
				if (this.OOo._o0__0Ooo_.)
				{
					if ((DateTime.Now - this.O_OooO.0oOOO0.).TotalSeconds >= 2.0 && !this.OOo._o0__0Ooo_..Ready && this.OOo._o0__0Ooo_..Start(5))
					{
						base.Close();
					}
				}
				else if ((DateTime.Now - this.O_.0o_o0o.).TotalSeconds >= 3.0)
				{
					string s = "\u0005\v\u0005";
					byte[] bytes = Encoding.Unicode.GetBytes(s);
					this.O_OooO.0oOOO0..Send(bytes, bytes.Length, this.O_OooO.0oOOO0.);
					if (this.O_OooO.0oOOO0..Available > 0)
					{
						IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
						this.O_OooO.0oOOO0..Receive(ref ipendPoint);
						if (Operators.CompareString(ipendPoint.ToString(), this.O_OooO.0oOOO0..ToString(), true) == 0)
						{
							this.OOo._o0__0Ooo_. = true;
							this.O_OooO.0oOOO0. = DateTime.Now;
						}
					}
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00085074 File Offset: 0x00083274
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x04000794 RID: 1940
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000795 RID: 1941
		[CompilerGenerated]
		private PictureBox <<EMPTY_NAME>>;

		// Token: 0x04000796 RID: 1942
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000797 RID: 1943
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000798 RID: 1944
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000799 RID: 1945
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400079A RID: 1946
		[CompilerGenerated]
		private Timer <<EMPTY_NAME>>;

		// Token: 0x0400079B RID: 1947
		private const int <<EMPTY_NAME>> = 2;

		// Token: 0x0400079C RID: 1948
		private const int <<EMPTY_NAME>> = 4;

		// Token: 0x0400079D RID: 1949
		private const int <<EMPTY_NAME>> = 8;

		// Token: 0x0400079E RID: 1950
		private const int <<EMPTY_NAME>> = 16;

		// Token: 0x0400079F RID: 1951
		private const int <<EMPTY_NAME>> = 65536;

		// Token: 0x040007A0 RID: 1952
		private const int <<EMPTY_NAME>> = 131072;

		// Token: 0x040007A1 RID: 1953
		private const int <<EMPTY_NAME>> = 262144;

		// Token: 0x040007A2 RID: 1954
		private const int <<EMPTY_NAME>> = 524288;

		// Token: 0x040007A3 RID: 1955
		private IMClient <<EMPTY_NAME>>;

		// Token: 0x040007A4 RID: 1956
		private IPEndPoint <<EMPTY_NAME>>;

		// Token: 0x040007A5 RID: 1957
		private string <<EMPTY_NAME>>;

		// Token: 0x040007A6 RID: 1958
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x040007A7 RID: 1959
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x040007A8 RID: 1960
		private bool <<EMPTY_NAME>>;

		// Token: 0x040007A9 RID: 1961
		private UdpClient <<EMPTY_NAME>>;
	}
}
