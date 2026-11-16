using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001DF RID: 479
	internal class oO0 : UserControl
	{
		// Token: 0x06001714 RID: 5908 RVA: 0x000A8B08 File Offset: 0x000A6D08
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.ooO._OoO0_0.;
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000A8B10 File Offset: 0x000A6D10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.ooO._OoO0_0. = A_0;
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x000A8B19 File Offset: 0x000A6D19
		[CompilerGenerated]
		internal virtual ProgressBar <<EMPTY_NAME>>()
		{
			return this.O_oo__._O.;
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x000A8B21 File Offset: 0x000A6D21
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ProgressBar A_0)
		{
			this.O_oo__._O. = A_0;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x000A8B2A File Offset: 0x000A6D2A
		[CompilerGenerated]
		internal virtual PictureBox <<EMPTY_NAME>>()
		{
			return this.O_oo__._O.;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x000A8B32 File Offset: 0x000A6D32
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PictureBox A_0)
		{
			this.O_oo__._O. = A_0;
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x000A8B3B File Offset: 0x000A6D3B
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O._oooooooOO.;
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000A8B44 File Offset: 0x000A6D44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			EventHandler value = new EventHandler(this.O0O_0O0.Oo.);
			Label o._oooooooOO. = this.O._oooooooOO.;
			if (o._oooooooOO. != null)
			{
				o._oooooooOO..Click -= value;
			}
			this.O._oooooooOO. = A_0;
			o._oooooooOO. = this.O._oooooooOO.;
			if (o._oooooooOO. != null)
			{
				o._oooooooOO..Click += value;
			}
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x000A8B87 File Offset: 0x000A6D87
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0Oo0O0.0__0oo.;
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x000A8B8F File Offset: 0x000A6D8F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0Oo0O0.0__0oo. = A_0;
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x000A8B98 File Offset: 0x000A6D98
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOo0.oo__0_oo.;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x000A8BA0 File Offset: 0x000A6DA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			EventHandler value = new EventHandler(this.o_.0o0O__.);
			Label label = this.oOo0.oo__0_oo.;
			if (label != null)
			{
				label.Click -= value;
			}
			this.oOo0.oo__0_oo. = A_0;
			label = this.oOo0.oo__0_oo.;
			if (label != null)
			{
				label.Click += value;
			}
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x000A8BE3 File Offset: 0x000A6DE3
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.O__0O_O_O.;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x000A8BEB File Offset: 0x000A6DEB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.O__0O_O_O. = A_0;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x000A8BF4 File Offset: 0x000A6DF4
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_o_O.0.;
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x000A8BFC File Offset: 0x000A6DFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			EventHandler value = new EventHandler(this.o.oo00_.);
			Label label = this.o_o_O.0.;
			if (label != null)
			{
				label.SizeChanged -= value;
			}
			this.o_o_O.0. = A_0;
			label = this.o_o_O.0.;
			if (label != null)
			{
				label.SizeChanged += value;
			}
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x000A8C40 File Offset: 0x000A6E40
		internal oO0(IMClient A_0, IMBuddy A_1, string A_2, SendTypeEnum A_3)
		{
			this.o_.0o0O__.();
			this.o_o0_0.o_o_0. = A_0;
			this.O_oo__._O. = A_1;
			this.O_oo__._O. = A_2;
			this.o_.0o0O__.().Image = ooO.o.O_0000_O.(Path.GetExtension(A_2));
			this.o0O.Oo. = OoOo0O.OO_o.0o_O.(10);
			this.O_oo__._O. = A_3;
			if (A_1 == null)
			{
				this.Oo_.OO.().Text = "向服务器发送文件:";
			}
			else if (A_1 is ooo0 || A_1 is O_0OOOoO)
			{
				this.Oo_.OO.().Text = "向" + A_1.SimpleName + "分享:";
			}
			else
			{
				this.Oo_.OO.().Text = "向" + A_1.SimpleName + "发送文件:";
			}
			this.o_.0o0O__.().Minimum = 0;
			this.o_.0o0O__.().Maximum = 100;
			if (this.O_oo__._O. == null || this.O_oo__._O. is ooo0 || this.O_oo__._O. is O_0OOOoO)
			{
				this.o.oo00_.().Visible = false;
			}
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x000A8D47 File Offset: 0x000A6F47
		public SendTypeEnum <<EMPTY_NAME>>()
		{
			return this.O_oo__._O.;
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x000A8D50 File Offset: 0x000A6F50
		private void <<EMPTY_NAME>>()
		{
			this.o.0_oOOooo.(new Label());
			this.ooO._OoO0_0.(new ProgressBar());
			this.ooO._OoO0_0.(new PictureBox());
			this.oOO.o00O00O0o_.(new Label());
			this.ooO._OoO0_0.(new Label());
			this.O00_o_0_.o.(new Label());
			this.O._oooooooOO.(new Label());
			this.ooo_.o___o.(new Label());
			((ISupportInitialize)this.o_.0o0O__.()).BeginInit();
			base.SuspendLayout();
			this.Oo_.OO.().AutoSize = true;
			this.Oo_.OO.().ForeColor = Color.DarkGray;
			this.Oo_.OO.().Location = new Point(44, 4);
			this.Oo_.OO.().Name = "lblBuddy";
			this.Oo_.OO.().Size = new Size(77, 12);
			this.Oo_.OO.().TabIndex = 0;
			this.Oo_.OO.().Text = "发送文件请求";
			this.o_.0o0O__.().Anchor = (AnchorStyles.Left | AnchorStyles.Right);
			this.o_.0o0O__.().Location = new Point(0, 44);
			this.o_.0o0O__.().Name = "ProgressBar1";
			this.o_.0o0O__.().Size = new Size(261, 10);
			this.o_.0o0O__.().TabIndex = 1;
			this.o_.0o0O__.().Location = new Point(2, 2);
			this.o_.0o0O__.().Name = "PictureBox1";
			this.o_.0o0O__.().Size = new Size(32, 32);
			this.o_.0o0O__.().SizeMode = PictureBoxSizeMode.StretchImage;
			this.o_.0o0O__.().TabIndex = 3;
			this.o_.0o0O__.().TabStop = false;
			this.OO0.oo_o00o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.OO0.oo_o00o.().AutoSize = true;
			this.OO0.oo_o00o.().Cursor = Cursors.Hand;
			this.OO0.oo_o00o.().ForeColor = SystemColors.MenuHighlight;
			this.OO0.oo_o00o.().Location = new Point(228, 80);
			this.OO0.oo_o00o.().Name = "lblCancel";
			this.OO0.oo_o00o.().Size = new Size(29, 12);
			this.OO0.oo_o00o.().TabIndex = 4;
			this.OO0.oo_o00o.().Text = "取消";
			this.OO_.0OOo.().AutoSize = true;
			this.OO_.0OOo.().ForeColor = SystemColors.ControlText;
			this.OO_.0OOo.().Location = new Point(44, 21);
			this.OO_.0OOo.().Name = "lblFileName";
			this.OO_.0OOo.().Size = new Size(77, 12);
			this.OO_.0OOo.().TabIndex = 5;
			this.OO_.0OOo.().Text = "foxtable.exe";
			this.o.oo00_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.o.oo00_.().AutoSize = true;
			this.o.oo00_.().Cursor = Cursors.Hand;
			this.o.oo00_.().ForeColor = SystemColors.MenuHighlight;
			this.o.oo00_.().Location = new Point(146, 80);
			this.o.oo00_.().Name = "lblSendOffline";
			this.o.oo00_.().Size = new Size(77, 12);
			this.o.oo00_.().TabIndex = 6;
			this.o.oo00_.().Text = "发送离线文件";
			this.o_.0o0O__.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o_.0o0O__.().AutoSize = true;
			this.o_.0o0O__.().ForeColor = SystemColors.ControlText;
			this.o_.0o0O__.().Location = new Point(2, 60);
			this.o_.0o0O__.().Name = "lblSpeed";
			this.o_.0o0O__.().Size = new Size(0, 12);
			this.o_.0o0O__.().TabIndex = 8;
			this.o_0O.00.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.o_0O.00.().AutoSize = true;
			this.o_0O.00.().ForeColor = SystemColors.ControlText;
			this.o_0O.00.().Location = new Point(228, 60);
			this.o_0O.00.().Name = "lblProgress";
			this.o_0O.00.().Size = new Size(29, 12);
			this.o_0O.00.().TabIndex = 9;
			this.o_0O.00.().Text = "进度";
			this.BackColor = Color.FromArgb(239, 246, 253);
			base.Controls.Add(this.o_0O.00.());
			base.Controls.Add(this.o_.0o0O__.());
			base.Controls.Add(this.o.oo00_.());
			base.Controls.Add(this.OO_.0OOo.());
			base.Controls.Add(this.OO0.oo_o00o.());
			base.Controls.Add(this.o_.0o0O__.());
			base.Controls.Add(this.o_.0o0O__.());
			base.Controls.Add(this.Oo_.OO.());
			base.Name = "O..OO.o.";
			base.Size = new Size(261, 96);
			((ISupportInitialize)this.o_.0o0O__.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x000A9234 File Offset: 0x000A7434
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			((o\u3000\u3002\u3000\u3002\u3000)base.FindForm()).oOOOO.O.(this);
			string str = "\v";
			string text = "%5" + str + this.o0O.Oo.;
			if (this.O_oo__._O. == null || this.O_oo__._O. is ooo0 || this.O_oo__._O. is O_0OOOoO)
			{
				this.o_o0_0.o_o_0..O.00O0_O_o_oO.(text);
			}
			else
			{
				this.o_o0_0.o_o_0..O.00O0_O_o_oO.(this.O_oo__._O..Name, text);
			}
			bool flag;
			bool expression;
			try
			{
				foreach (O_0__O_o_O o_0__O_o_O in this.o_o0_0.o_o_0..ooOooo.oO..Values)
				{
					if (Operators.CompareString(o_0__O_o_O.O_OO.o0o_o0.(), this.o0O.Oo., true) == 0)
					{
						o_0__O_o_O.O0.0O0o_O. = true;
						if (o_0__O_o_O.o_0.Oo_0O0_.() is ooo0 || o_0__O_o_O.o_0.Oo_0O0_.() is O_0OOOoO)
						{
							flag = true;
						}
						if (Operators.CompareString(o_0__O_o_O.o_OoO._.(), "", true) > 0)
						{
							expression = true;
							break;
						}
						break;
					}
				}
			}
			finally
			{
				Dictionary<string, O_0__O_o_O>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			string a_;
			if (flag)
			{
				a_ = "\u0002{我方取消上传文件\"" + OO_00oOO.FileSys.GetName(this.O_oo__._O.) + "\"}\u0002";
				this.o_o0_0.o_o_0..O.00O0_O_o_oO.(o0___oO.o0__.0.(this.O_oo__._O.), a_, 2, 1, this.o_o0_0.o_o_0..UserName);
				return;
			}
			a_ = string.Concat(new string[]
			{
				"\u0002{我方取消",
				Interaction.IIf(expression, "离线", "").ToString(),
				"发送文件\"",
				OO_00oOO.FileSys.GetName(this.O_oo__._O.),
				"\"}\u0002"
			});
			this.o_o0_0.o_o_0..O.00O0_O_o_oO.(o0___oO.o0__.0.(this.O_oo__._O.), a_, 2, 1, null);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x000A9408 File Offset: 0x000A7608
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_0O.00.().Left = base.Width - this.o_0O.00.().Width - 4;
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x000A942C File Offset: 0x000A762C
		internal void <<EMPTY_NAME>>()
		{
			this.O_oo__._O. = true;
			object[] parameter = new object[]
			{
				this.O_oo__._O.,
				this.O_oo__._O.,
				this.o_.0o0O__.(),
				this
			};
			new Thread(new ParameterizedThreadStart(this.o_o0_0.o_o_0..O00__O._O_00o.)).Start(parameter);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x000A9488 File Offset: 0x000A7688
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!this.O_oo__._O.)
			{
				this.O_oo__._O. = true;
				string str = "\v";
				string a_ = "%7" + str + this.o0O.Oo.;
				this.o_o0_0.o_o_0..O.00O0_O_o_oO.(this.O_oo__._O..Name, a_);
				object[] parameter = new object[]
				{
					this.O_oo__._O.,
					this.O_oo__._O.,
					this.o_.0o0O__.(),
					this,
					true
				};
				new Thread(new ParameterizedThreadStart(this.o_o0_0.o_o_0..O00__O._O_00o.)).Start(parameter);
				string a_2 = "\u0002(我方选择离线发送文件\"" + OO_00oOO.FileSys.GetName(this.O_oo__._O.) + "\")\u0002";
				this.o_o0_0.o_o_0..O.00O0_O_o_oO.(o0___oO.o0__.0.(this.O_oo__._O.), a_2, 2, 1, null);
			}
		}

		// Token: 0x0400098C RID: 2444
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400098D RID: 2445
		[CompilerGenerated]
		private ProgressBar <<EMPTY_NAME>>;

		// Token: 0x0400098E RID: 2446
		[CompilerGenerated]
		private PictureBox <<EMPTY_NAME>>;

		// Token: 0x0400098F RID: 2447
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000990 RID: 2448
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000991 RID: 2449
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000992 RID: 2450
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000993 RID: 2451
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000994 RID: 2452
		internal IMClient <<EMPTY_NAME>>;

		// Token: 0x04000995 RID: 2453
		internal IMBuddy <<EMPTY_NAME>>;

		// Token: 0x04000996 RID: 2454
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000997 RID: 2455
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000998 RID: 2456
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000999 RID: 2457
		internal SendTypeEnum <<EMPTY_NAME>>;
	}
}
