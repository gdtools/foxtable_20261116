using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000243 RID: 579
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class O\u3000O\u3000 : Form
	{
		// Token: 0x06001B8D RID: 7053 RVA: 0x000C0744 File Offset: 0x000BE944
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o.o0O_. != null)
				{
					this.o.o0O_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x000C0784 File Offset: 0x000BE984
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o.o0O_. = new Container();
			this.o___Oo_oo_.O_.(new ProgressBar());
			this.o___Oo_oo_.O_.(new Label());
			this.o___Oo_oo_.O_.(new C1Button());
			this.o___Oo_oo_.O_.(new Timer(this.o.o0O_.));
			base.SuspendLayout();
			this.o___Oo_oo_.O_.().Location = new Point(12, 80);
			this.o___Oo_oo_.O_.().Name = "ProgressBar1";
			this.o___Oo_oo_.O_.().Size = new Size(453, 23);
			this.o___Oo_oo_.O_.().TabIndex = 0;
			this.o___Oo_oo_.O_.().Location = new Point(12, 18);
			this.o___Oo_oo_.O_.().Name = "Label1";
			this.o___Oo_oo_.O_.().Size = new Size(453, 48);
			this.o___Oo_oo_.O_.().TabIndex = 1;
			this.O._0Ooo0_.().Location = new Point(201, 135);
			this.O._0Ooo0_.().Name = "Button1";
			this.O._0Ooo0_.().Size = new Size(75, 23);
			this.O._0Ooo0_.().TabIndex = 2;
			this.O._0Ooo0_.().Text = "取消";
			this.O._0Ooo0_.().UseVisualStyleBackColor = true;
			this.o___Oo_oo_.O_.().Enabled = true;
			this.o___Oo_oo_.O_.().Interval = 300;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(477, 172);
			base.ControlBox = false;
			base.Controls.Add(this.O._0Ooo0_.());
			base.Controls.Add(this.o___Oo_oo_.O_.());
			base.Controls.Add(this.o___Oo_oo_.O_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O...o0..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "正在下载";
			base.ResumeLayout(false);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000C0996 File Offset: 0x000BEB96
		[CompilerGenerated]
		internal virtual ProgressBar <<EMPTY_NAME>>()
		{
			return this.o.o0O_.;
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000C099E File Offset: 0x000BEB9E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ProgressBar A_0)
		{
			this.o.o0O_. = A_0;
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x000C09A7 File Offset: 0x000BEBA7
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.o0O_.;
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x000C09AF File Offset: 0x000BEBAF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.o0O_. = A_0;
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x000C09B8 File Offset: 0x000BEBB8
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.o0O_.;
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x000C09C0 File Offset: 0x000BEBC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O._0Ooo0_.);
			C1Button c1Button = this.o.o0O_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.o0O_. = A_0;
			c1Button = this.o.o0O_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x000C0A03 File Offset: 0x000BEC03
		[CompilerGenerated]
		internal virtual Timer <<EMPTY_NAME>>()
		{
			return this.o.o0O_.;
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x000C0A0C File Offset: 0x000BEC0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Timer A_0)
		{
			EventHandler value = new EventHandler(this.O_._oo0oO__O_.);
			Timer timer = this.o.o0O_.;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.o.o0O_. = A_0;
			timer = this.o.o0O_.;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x000C0A4F File Offset: 0x000BEC4F
		[CompilerGenerated]
		private virtual FTPClient <<EMPTY_NAME>>()
		{
			return this.o.o0O_.;
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x000C0A58 File Offset: 0x000BEC58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(FTPClient A_0)
		{
			FTPClient.oO_o_0OOo__0 a_ = new FTPClient.oO_o_0OOo__0(this.O.oo0_ooOo.);
			FTPClient.O__0O000__Oo a_2 = new FTPClient.O__0O000__Oo(this.O._0Ooo0_.);
			FTPClient.o0O_O00o_0_o a_3 = new FTPClient.o0O_O00o_0_o(this.O._0Ooo0_.);
			FTPClient.OoO_00_o a_4 = new FTPClient.OoO_00_o(this.O._0Ooo0_.);
			FTPClient.OOOOO00OoOOo a_5 = new FTPClient.OOOOO00OoOOo(this.O._0Ooo0_.);
			FTPClient ftpclient = this.o.o0O_.;
			if (ftpclient != null)
			{
				ftpclient.DownloadCompleted -= a_;
				ftpclient.DownloadError -= a_2;
				ftpclient.DownloadProgressChanged -= a_3;
				ftpclient.ShowError -= a_4;
				ftpclient.ShowMessage -= a_5;
			}
			this.o.o0O_. = A_0;
			ftpclient = this.o.o0O_.;
			if (ftpclient != null)
			{
				ftpclient.DownloadCompleted += a_;
				ftpclient.DownloadError += a_2;
				ftpclient.DownloadProgressChanged += a_3;
				ftpclient.ShowError += a_4;
				ftpclient.ShowMessage += a_5;
			}
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x000C0B18 File Offset: 0x000BED18
		public O\u3000O\u3000(FTPClient A_0, string A_1, string A_2)
		{
			base.Activated += this.OO0.oo0.;
			base.FormClosed += this.O._0Ooo0_.;
			this.o___Oo_oo_.O_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o___Oo_oo_.O_.(A_0);
			this.o_0.o0O. = A_1;
			this.o.o0O_. = A_2;
			this.Text = "下载文件:" + OO_00oOO.FileSys.GetName(A_1);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x000C0B9C File Offset: 0x000BED9C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O_._oo0oO__O_. == 0)
			{
				this.O_._oo0oO__O_. = 1;
				string parentPath = OO_00oOO.FileSys.GetParentPath(this.o.o0O_.);
				if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
				{
					OO_00oOO.FileSys.CreateDirectory(parentPath);
				}
				this.o___Oo_oo_.O_.().O_O0Ooo_00.o.(this.o_0.o0O., this.o.o0O_., false);
			}
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x000C0BFC File Offset: 0x000BEDFC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.OO0OOoO.oo0., "", true) > 0)
			{
				this.o___Oo_oo_.O_.().Text = this.OO0OOoO.oo0.;
				this.o___Oo_oo_.O_.().Value = this.o.00_O_.;
				this.OO0OOoO.oo0. = "";
			}
			if (Operators.CompareString(this.o0.O0o0OOO_., "", true) > 0)
			{
				this.O._0Ooo0_.().Text = this.o0.O0o0OOO_.;
				this.o0.O0o0OOO_. = "";
			}
			lock (this)
			{
				if (base.Visible && this.o.00_O_. && (DateTime.Now - this.o.00_O_.).TotalSeconds > 2.0 && this.o___Oo_oo_.O_.().AsyncState == Oo_0.OOoo0_OO__._o.)
				{
					this.o___Oo_oo_.O_.().O_O0Ooo_00.o.(this.o_0.o0O., this.o.o0O_., false);
					this.o.00_O_. = false;
				}
			}
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x000C0D04 File Offset: 0x000BEF04
		private void <<EMPTY_NAME>>(string A_0)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x000C0D10 File Offset: 0x000BEF10
		private void <<EMPTY_NAME>>(string A_0, bool A_1)
		{
			lock (this)
			{
				if (A_1 && !this.o.00_O_.)
				{
					this.o.00_O_. = true;
					this.o.00_O_. = DateTime.Now;
					this.OO0OOoO.oo0. = "下载过程出现意外错误，正在准备重新尝试....";
				}
				else
				{
					this.o0.O0o0OOO_. = "关闭";
				}
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000C0D7C File Offset: 0x000BEF7C
		private void <<EMPTY_NAME>>(string A_0, long A_1, long A_2, long A_3, TimeSpan A_4)
		{
			this.o.00_O_. = (int)Math.Round(100.0 * Math.Round((double)(A_2 + A_3) / (double)A_1, 4));
			this.OO0OOoO.oo0. = string.Concat(new string[]
			{
				"总大小:",
				Strings.Format((int)Math.Round((double)A_1 / 1024.0), "#,##0"),
				"K, 已完成:",
				Strings.Format((int)Math.Round((double)(A_2 + A_3) / 1024.0), "#,##0"),
				"K, 平均速度:",
				Conversions.ToString((int)Math.Round((double)A_3 / A_4.TotalSeconds / 1024.0)),
				"K/S"
			});
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x000C0E4C File Offset: 0x000BF04C
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			this.OO0OOoO.oo0. = A_0 + "," + A_1;
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x000C0E60 File Offset: 0x000BF060
		private void <<EMPTY_NAME>>(string A_0)
		{
			this.OO0OOoO.oo0. = A_0;
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x000C0E69 File Offset: 0x000BF069
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o___Oo_oo_.O_.().o_0_.__0OO.();
			this.o___Oo_oo_.O_.(null);
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x000C0E84 File Offset: 0x000BF084
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			this.o___Oo_oo_.O_.(null);
			this.o___Oo_oo_.O_.().Enabled = false;
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04000B9A RID: 2970
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000B9B RID: 2971
		[CompilerGenerated]
		private ProgressBar <<EMPTY_NAME>>;

		// Token: 0x04000B9C RID: 2972
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000B9D RID: 2973
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000B9E RID: 2974
		[CompilerGenerated]
		private Timer <<EMPTY_NAME>>;

		// Token: 0x04000B9F RID: 2975
		[CompilerGenerated]
		private FTPClient <<EMPTY_NAME>>;

		// Token: 0x04000BA0 RID: 2976
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BA1 RID: 2977
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BA2 RID: 2978
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BA3 RID: 2979
		private int <<EMPTY_NAME>>;

		// Token: 0x04000BA4 RID: 2980
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000BA5 RID: 2981
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x04000BA6 RID: 2982
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BA7 RID: 2983
		private int <<EMPTY_NAME>>;
	}
}
