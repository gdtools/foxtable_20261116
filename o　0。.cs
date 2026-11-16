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
	// Token: 0x020000E9 RID: 233
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class o\u30000\u3002 : Form
	{
		// Token: 0x06000D60 RID: 3424 RVA: 0x0006EC3A File Offset: 0x0006CE3A
		public o\u30000\u3002()
		{
			this.oo0OO.0O0_0.();
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0006EC48 File Offset: 0x0006CE48
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.Oo.___00_0. != null)
				{
					this.Oo.___00_0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0006EC88 File Offset: 0x0006CE88
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Oo.___00_0.(new Label());
			this.oo0OO.0O0_0.(new C1Button());
			this.O0_0_.___0oO.(new C1Button());
			base.SuspendLayout();
			this.oo0OO.0O0_0.().AutoSize = true;
			this.oo0OO.0O0_0.().Location = new Point(12, 23);
			this.oo0OO.0O0_0.().Name = "Label1";
			this.oo0OO.0O0_0.().Size = new Size(65, 12);
			this.oo0OO.0O0_0.().TabIndex = 0;
			this.oo0OO.0O0_0.().Text = "请输入值：";
			this.O_O_.Oo.().DialogResult = DialogResult.OK;
			this.O_O_.Oo.().Location = new Point(336, 13);
			this.O_O_.Oo.().Name = "Button1";
			this.O_O_.Oo.().Size = new Size(75, 23);
			this.O_O_.Oo.().TabIndex = 2;
			this.O_O_.Oo.().Text = "确定";
			this.O_O_.Oo.().UseVisualStyleBackColor = true;
			this.oo0OO.0O0_0.().DialogResult = DialogResult.Abort;
			this.oo0OO.0O0_0.().Location = new Point(336, 42);
			this.oo0OO.0O0_0.().Name = "Button2";
			this.oo0OO.0O0_0.().Size = new Size(75, 23);
			this.oo0OO.0O0_0.().TabIndex = 3;
			this.oo0OO.0O0_0.().Text = "取消";
			this.oo0OO.0O0_0.().UseVisualStyleBackColor = true;
			base.AcceptButton = this.O_O_.Oo.();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.oo0OO.0O0_0.();
			base.ClientSize = new Size(424, 110);
			base.Controls.Add(this.oo0OO.0O0_0.());
			base.Controls.Add(this.O_O_.Oo.());
			base.Controls.Add(this.oo0OO.0O0_0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.oo.O.O.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "输入";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0006EEC0 File Offset: 0x0006D0C0
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo.___00_0.;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0006EEC8 File Offset: 0x0006D0C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.Oo.___00_0. = A_0;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0006EED1 File Offset: 0x0006D0D1
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0_0_.___0oO.;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0006EED9 File Offset: 0x0006D0D9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O0_0_.___0oO. = A_0;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0006EEE2 File Offset: 0x0006D0E2
		[CompilerGenerated]
		public virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo.___00_0.;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0006EEEA File Offset: 0x0006D0EA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo.___00_0. = A_0;
		}

		// Token: 0x04000531 RID: 1329
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000532 RID: 1330
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000533 RID: 1331
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000534 RID: 1332
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;
	}
}
