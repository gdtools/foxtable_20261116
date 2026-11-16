using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000066 RID: 102
	[DesignerGenerated]
	internal partial class O_\u3000 : Form
	{
		// Token: 0x06000385 RID: 901 RVA: 0x0000D544 File Offset: 0x0000B744
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_o.ooO0oo. != null)
				{
					this.O_o.ooO0oo..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000D584 File Offset: 0x0000B784
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O_0._o_O0o.(new C1Button());
			this.O.__Ooo.(new C1Button());
			this.O_0._o_O0o.(new C1TextBox());
			((ISupportInitialize)this.O.__Ooo.()).BeginInit();
			((ISupportInitialize)this.O_0._o_O0o.()).BeginInit();
			((ISupportInitialize)this.O_0._o_O0o.()).BeginInit();
			base.SuspendLayout();
			this.O.__Ooo.().Anchor = AnchorStyles.Bottom;
			this.O.__Ooo.().DialogResult = DialogResult.Cancel;
			this.O.__Ooo.().Location = new Point(267, 251);
			this.O.__Ooo.().Name = "btnCancel";
			this.O.__Ooo.().Size = new Size(75, 23);
			this.O.__Ooo.().TabIndex = 9;
			this.O.__Ooo.().Text = "取消";
			this.O.__Ooo.().UseVisualStyleBackColor = true;
			this.O_0._o_O0o.().Anchor = AnchorStyles.Bottom;
			this.O_0._o_O0o.().DialogResult = DialogResult.OK;
			this.O_0._o_O0o.().Location = new Point(175, 251);
			this.O_0._o_O0o.().Name = "btnAccept";
			this.O_0._o_O0o.().Size = new Size(75, 23);
			this.O_0._o_O0o.().TabIndex = 8;
			this.O_0._o_O0o.().Text = "确定";
			this.O_0._o_O0o.().UseVisualStyleBackColor = true;
			this.O_0._o_O0o.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.O_0._o_O0o.().Location = new Point(12, 12);
			this.O_0._o_O0o.().Multiline = true;
			this.O_0._o_O0o.().Name = "TextBox1";
			this.O_0._o_O0o.().ScrollBars = ScrollBars.Vertical;
			this.O_0._o_O0o.().Size = new Size(493, 221);
			this.O_0._o_O0o.().TabIndex = 6;
			this.O_0._o_O0o.().Tag = null;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(517, 288);
			base.Controls.Add(this.O.__Ooo.());
			base.Controls.Add(this.O_0._o_O0o.());
			base.Controls.Add(this.O_0._o_O0o.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmTextEditor";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "属性";
			((ISupportInitialize)this.O.__Ooo.()).EndInit();
			((ISupportInitialize)this.O_0._o_O0o.()).EndInit();
			((ISupportInitialize)this.O_0._o_O0o.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000D816 File Offset: 0x0000BA16
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_o.ooO0oo.;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000D81E File Offset: 0x0000BA1E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O_o.ooO0oo. = A_0;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000D827 File Offset: 0x0000BA27
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.__Ooo.;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000D82F File Offset: 0x0000BA2F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O.__Ooo. = A_0;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000D838 File Offset: 0x0000BA38
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_o.ooO0oo.;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000D840 File Offset: 0x0000BA40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O_o.ooO0oo. = A_0;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000D849 File Offset: 0x0000BA49
		public O_\u3000()
		{
			base.FormClosed += this.O_0._o_O0o.;
			this.O_0._o_O0o.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000D87E File Offset: 0x0000BA7E
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040000BB RID: 187
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040000BC RID: 188
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040000BD RID: 189
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040000BE RID: 190
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;
	}
}
