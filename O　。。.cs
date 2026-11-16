using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000EC RID: 236
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class O\u3000\u3002\u3002\u3000\u3000 : Form
	{
		// Token: 0x06000D91 RID: 3473 RVA: 0x0006FD90 File Offset: 0x0006DF90
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_000o.0. != null)
				{
					this.O_000o.0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0006FDD0 File Offset: 0x0006DFD0
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O_000o.0.(new C1Button());
			this.O_000o.0.(new C1TextBox());
			this.O_000o.0.(new C1CheckBox());
			base.SuspendLayout();
			this.OoO_O0o.O0__O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.OoO_O0o.O0__O.().Location = new Point(351, 229);
			this.OoO_O0o.O0__O.().Name = "Button1";
			this.OoO_O0o.O0__O.().Size = new Size(95, 23);
			this.OoO_O0o.O0__O.().TabIndex = 1;
			this.OoO_O0o.O0__O.().Text = "复制详细信息";
			this.OoO_O0o.O0__O.().UseVisualStyleBackColor = true;
			this.OoO_O0o.O0__O.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.OoO_O0o.O0__O.().Location = new Point(13, 15);
			this.OoO_O0o.O0__O.().Multiline = true;
			this.OoO_O0o.O0__O.().Name = "TextBox1";
			this.OoO_O0o.O0__O.().ReadOnly = true;
			this.OoO_O0o.O0__O.().ScrollBars = ScrollBars.Vertical;
			this.OoO_O0o.O0__O.().Size = new Size(433, 204);
			this.OoO_O0o.O0__O.().TabIndex = 2;
			this.OoO_O0o.O0__O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.OoO_O0o.O0__O.().AutoSize = true;
			this.OoO_O0o.O0__O.().Location = new Point(13, 236);
			this.OoO_O0o.O0__O.().Name = "CheckBox1";
			this.OoO_O0o.O0__O.().Size = new Size(96, 16);
			this.OoO_O0o.O0__O.().TabIndex = 3;
			this.OoO_O0o.O0__O.().Text = "显示详细信息";
			this.OoO_O0o.O0__O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(459, 264);
			base.Controls.Add(this.OoO_O0o.O0__O.());
			base.Controls.Add(this.OoO_O0o.O0__O.());
			base.Controls.Add(this.OoO_O0o.O0__O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Oooo.O.O.";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "运行错误";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0007001E File Offset: 0x0006E21E
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_000o.0.;
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00070028 File Offset: 0x0006E228
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO.0__0__00_o.);
			C1Button o_000o.0. = this.O_000o.0.;
			if (o_000o.0. != null)
			{
				o_000o.0..Click -= value;
			}
			this.O_000o.0. = A_0;
			o_000o.0. = this.O_000o.0.;
			if (o_000o.0. != null)
			{
				o_000o.0..Click += value;
			}
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0007006B File Offset: 0x0006E26B
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_000o.0.;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00070073 File Offset: 0x0006E273
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O_000o.0. = A_0;
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0007007C File Offset: 0x0006E27C
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O_000o.0.;
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00070084 File Offset: 0x0006E284
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.o0Ooo.0O0_0.);
			C1CheckBox o_000o.0. = this.O_000o.0.;
			if (o_000o.0. != null)
			{
				o_000o.0..CheckedChanged -= value;
			}
			this.O_000o.0. = A_0;
			o_000o.0. = this.O_000o.0.;
			if (o_000o.0. != null)
			{
				o_000o.0..CheckedChanged += value;
			}
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x000700C8 File Offset: 0x0006E2C8
		public O\u3000\u3002\u3002\u3000\u3000(string A_0, Exception A_1)
		{
			base.Activated += this.OoO_O0o.O0__O.;
			base.FormClosed += this.OoO_O0o.O0__O.;
			this.OoO_O0o.O0__O.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.O_000o.0. = ".NET Framework 版本：" + Environment.Version.ToString() + "\r\n";
			this.O_000o.0. = this.O_000o.0. + "Foxtable 版本：" + c.Oo.__O0.().Info.Version.ToString() + "\r\n";
			this.O_000o.0. = this.O_000o.0. + "错误所在事件：" + A_0 + "\r\n";
			this.O_000o.0. += "详细错误信息：\r\n";
			Exception ex = A_1;
			do
			{
				this.O_000o.0. = this.O_000o.0. + ex.Message + "\r\n";
				ex = ex.InnerException;
			}
			while (ex != null);
			this.O_000o.0. = A_1;
			if (Control.ModifierKeys == Keys.Control)
			{
				this.OoO_O0o.O0__O.().Value = this.O_000o.0.;
				this.OoO_O0o.O0__O.().Checked = true;
				return;
			}
			this.OoO_O0o.O0__O.().Value = A_1.Message;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00070204 File Offset: 0x0006E404
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OoO_O0o.O0__O.().Checked)
			{
				this.OoO_O0o.O0__O.().Value = this.O_000o.0.;
				return;
			}
			this.OoO_O0o.O0__O.().Value = this.O_000o.0..Message;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0007023B File Offset: 0x0006E43B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Clipboard.SetText(this.O_000o.0.);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00070248 File Offset: 0x0006E448
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.BringToFront();
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00070250 File Offset: 0x0006E450
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04000549 RID: 1353
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400054A RID: 1354
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400054B RID: 1355
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400054C RID: 1356
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400054D RID: 1357
		private string <<EMPTY_NAME>>;

		// Token: 0x0400054E RID: 1358
		private Exception <<EMPTY_NAME>>;
	}
}
