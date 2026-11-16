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
	// Token: 0x020002D8 RID: 728
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class o\u3002\u3000\u3002\u3002\u3000 : Form
	{
		// Token: 0x06002813 RID: 10259 RVA: 0x0012201C File Offset: 0x0012021C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OoOoO.OO. != null)
				{
					this.OoOoO.OO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x0012205C File Offset: 0x0012025C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.OoOoO.OO. = new Container();
			this.O.OooOO__O_.(new ProgressBar());
			this.O.OooOO__O_.(new Label());
			this.O.OooOO__O_.(new C1Button());
			this.O.OooOO__O_.(new Timer(this.OoOoO.OO.));
			base.SuspendLayout();
			this.o.0o__0O0.().Location = new Point(12, 80);
			this.o.0o__0O0.().Name = "ProgressBar1";
			this.o.0o__0O0.().Size = new Size(453, 23);
			this.o.0o__0O0.().TabIndex = 0;
			this.o.0o__0O0.().Location = new Point(12, 18);
			this.o.0o__0O0.().Name = "Label1";
			this.o.0o__0O0.().Size = new Size(453, 48);
			this.o.0o__0O0.().TabIndex = 1;
			this.o.0o__0O0.().Location = new Point(201, 135);
			this.o.0o__0O0.().Name = "Button1";
			this.o.0o__0O0.().Size = new Size(75, 23);
			this.o.0o__0O0.().TabIndex = 2;
			this.o.0o__0O0.().Text = "取消";
			this.o.0o__0O0.().UseVisualStyleBackColor = true;
			this.o.0o__0O0.().Enabled = true;
			this.o.0o__0O0.().Interval = 300;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(477, 172);
			base.ControlBox = false;
			base.Controls.Add(this.o.0o__0O0.());
			base.Controls.Add(this.o.0o__0O0.());
			base.Controls.Add(this.o.0o__0O0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O0......";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "正在上传";
			base.ResumeLayout(false);
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0012226E File Offset: 0x0012046E
		[CompilerGenerated]
		internal virtual ProgressBar <<EMPTY_NAME>>()
		{
			return this.OoOoO.OO.;
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00122276 File Offset: 0x00120476
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ProgressBar A_0)
		{
			this.OoOoO.OO. = A_0;
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x0012227F File Offset: 0x0012047F
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.OooOO__O_.;
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x00122287 File Offset: 0x00120487
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.OooOO__O_. = A_0;
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00122290 File Offset: 0x00120490
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.OooOO__O_.;
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00122298 File Offset: 0x00120498
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.O_0_0.);
			C1Button o.OooOO__O_. = this.O.OooOO__O_.;
			if (o.OooOO__O_. != null)
			{
				o.OooOO__O_..Click -= value;
			}
			this.O.OooOO__O_. = A_0;
			o.OooOO__O_. = this.O.OooOO__O_.;
			if (o.OooOO__O_. != null)
			{
				o.OooOO__O_..Click += value;
			}
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x001222DB File Offset: 0x001204DB
		[CompilerGenerated]
		internal virtual Timer <<EMPTY_NAME>>()
		{
			return this.OoOoO.OO.;
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x001222E4 File Offset: 0x001204E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Timer A_0)
		{
			EventHandler value = new EventHandler(this.o_0O0.0OOo.);
			Timer ooOoO.OO. = this.OoOoO.OO.;
			if (ooOoO.OO. != null)
			{
				ooOoO.OO..Tick -= value;
			}
			this.OoOoO.OO. = A_0;
			ooOoO.OO. = this.OoOoO.OO.;
			if (ooOoO.OO. != null)
			{
				ooOoO.OO..Tick += value;
			}
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x00122327 File Offset: 0x00120527
		[CompilerGenerated]
		private virtual FTPClient <<EMPTY_NAME>>()
		{
			return this.O.OooOO__O_.;
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00122330 File Offset: 0x00120530
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(FTPClient A_0)
		{
			FTPClient.oO___ a_ = new FTPClient.oO___(this.oO0oO_O.00OOO_.);
			FTPClient.ooo__O a_2 = new FTPClient.ooo__O(this.oO0oO_O.00OOO_.);
			FTPClient.o0_O_0_0 a_3 = new FTPClient.o0_O_0_0(this.o.0o__0O0.);
			FTPClient.OoO_00_o a_4 = new FTPClient.OoO_00_o(this.o.O_0_0.);
			FTPClient.OOOOO00OoOOo a_5 = new FTPClient.OOOOO00OoOOo(this.o.0o__0O0.);
			FTPClient o.OooOO__O_. = this.O.OooOO__O_.;
			if (o.OooOO__O_. != null)
			{
				o.OooOO__O_..UploadCompleted -= a_;
				o.OooOO__O_..UploadError -= a_2;
				o.OooOO__O_..UploadProgressChanged -= a_3;
				o.OooOO__O_..ShowError -= a_4;
				o.OooOO__O_..ShowMessage -= a_5;
			}
			this.O.OooOO__O_. = A_0;
			o.OooOO__O_. = this.O.OooOO__O_.;
			if (o.OooOO__O_. != null)
			{
				o.OooOO__O_..UploadCompleted += a_;
				o.OooOO__O_..UploadError += a_2;
				o.OooOO__O_..UploadProgressChanged += a_3;
				o.OooOO__O_..ShowError += a_4;
				o.OooOO__O_..ShowMessage += a_5;
			}
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x001223F0 File Offset: 0x001205F0
		public o\u3002\u3000\u3002\u3002\u3000(FTPClient A_0, string A_1, string A_2)
		{
			base.Activated += this.O0_o__o.oo0.;
			base.FormClosed += this.o.O_0_0.;
			this.o.0o__0O0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.O.OooOO__O_.(A_0);
			this.OoOoO.OO. = A_1;
			this.oOO._o0O. = A_2;
			this.Text = "上传文件:" + OO_00oOO.FileSys.GetName(A_1);
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x00122472 File Offset: 0x00120672
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o_0O0.0OOo. == 0)
			{
				this.o_0O0.0OOo. = 1;
				this.o.0o__0O0.().o0O_0_.00_oooo.(this.OoOoO.OO., this.oOO._o0O., false);
			}
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0012249C File Offset: 0x0012069C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.o0.0o00o_0o0., "", true) > 0)
			{
				this.o.0o__0O0.().Text = this.o0.0o00o_0o0.;
				this.o.0o__0O0.().Value = this.OoOoO.OO.;
				this.o0.0o00o_0o0. = "";
			}
			if (Operators.CompareString(this.O00o0o.o., "", true) > 0)
			{
				this.o.0o__0O0.().Text = this.O00o0o.o.;
				this.O00o0o.o. = "";
			}
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x0012251A File Offset: 0x0012071A
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00122523 File Offset: 0x00120723
		private void <<EMPTY_NAME>>(string A_0)
		{
			this.o0.0o00o_0o0. = "上传过程出现意外错误，上传失败....";
			this.O00o0o.o. = "关闭";
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x0012253C File Offset: 0x0012073C
		private void <<EMPTY_NAME>>(string A_0, long A_1, long A_2, long A_3, TimeSpan A_4)
		{
			this.OoOoO.OO. = (int)Math.Round(100.0 * Math.Round((double)(A_2 + A_3) / (double)A_1, 4));
			this.o0.0o00o_0o0. = string.Concat(new string[]
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

		// Token: 0x06002825 RID: 10277 RVA: 0x0012260C File Offset: 0x0012080C
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			this.o0.0o00o_0o0. = A_0 + "," + A_1;
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x00122620 File Offset: 0x00120820
		private void <<EMPTY_NAME>>(string A_0)
		{
			this.o0.0o00o_0o0. = A_0;
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x00122629 File Offset: 0x00120829
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.0o__0O0.().o_0_.__0OO.();
			this.O.OooOO__O_.(null);
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00122644 File Offset: 0x00120844
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			this.O.OooOO__O_.(null);
			this.o.0o__0O0.().Enabled = false;
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400108A RID: 4234
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400108B RID: 4235
		[CompilerGenerated]
		private ProgressBar <<EMPTY_NAME>>;

		// Token: 0x0400108C RID: 4236
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400108D RID: 4237
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400108E RID: 4238
		[CompilerGenerated]
		private Timer <<EMPTY_NAME>>;

		// Token: 0x0400108F RID: 4239
		[CompilerGenerated]
		private FTPClient <<EMPTY_NAME>>;

		// Token: 0x04001090 RID: 4240
		private string <<EMPTY_NAME>>;

		// Token: 0x04001091 RID: 4241
		private string <<EMPTY_NAME>>;

		// Token: 0x04001092 RID: 4242
		private string <<EMPTY_NAME>>;

		// Token: 0x04001093 RID: 4243
		private int <<EMPTY_NAME>>;

		// Token: 0x04001094 RID: 4244
		private string <<EMPTY_NAME>>;

		// Token: 0x04001095 RID: 4245
		private int <<EMPTY_NAME>>;
	}
}
