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
	// Token: 0x02000467 RID: 1127
	[DesignerGenerated]
	internal partial class o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000 : Form
	{
		// Token: 0x06004C91 RID: 19601 RVA: 0x00229338 File Offset: 0x00227538
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.Oo0._. != null)
				{
					this.Oo0._..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x00229378 File Offset: 0x00227578
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Oo0._.(new C1Button());
			this.Oo0._.(new Label());
			base.SuspendLayout();
			this.Ooo_oo._o.().DialogResult = DialogResult.Cancel;
			this.Ooo_oo._o.().Location = new Point(102, 65);
			this.Ooo_oo._o.().Name = "Button1";
			this.Ooo_oo._o.().Size = new Size(75, 23);
			this.Ooo_oo._o.().TabIndex = 0;
			this.Ooo_oo._o.().Text = "取消";
			this.Ooo_oo._o.().UseVisualStyleBackColor = true;
			this.Oo0._.().Location = new Point(12, 28);
			this.Oo0._.().Name = "Label1";
			this.Oo0._.().Size = new Size(264, 21);
			this.Oo0._.().TabIndex = 1;
			this.Oo0._.().Text = "打印准备中...";
			this.Oo0._.().TextAlign = ContentAlignment.MiddleCenter;
			base.AcceptButton = this.Ooo_oo._o.();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.Ooo_oo._o.();
			base.ClientSize = new Size(288, 109);
			base.ControlBox = false;
			base.Controls.Add(this.Oo0._.());
			base.Controls.Add(this.Ooo_oo._o.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.0....O";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "打印进程";
			base.TopMost = true;
			base.ResumeLayout(false);
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x00229527 File Offset: 0x00227727
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo0._.;
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x00229530 File Offset: 0x00227730
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Ooo_oo._o.);
			C1Button oo0._. = this.Oo0._.;
			if (oo0._. != null)
			{
				oo0._..Click -= value;
			}
			this.Oo0._. = A_0;
			oo0._. = this.Oo0._.;
			if (oo0._. != null)
			{
				oo0._..Click += value;
			}
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x00229573 File Offset: 0x00227773
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo0._.;
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x0022957B File Offset: 0x0022777B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo0._. = A_0;
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x00229584 File Offset: 0x00227784
		public o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000()
		{
			base.FormClosed += this.Ooo_oo._o.;
			this.Oo0._.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06004C98 RID: 19608 RVA: 0x002295B9 File Offset: 0x002277B9
		public bool <<EMPTY_NAME>>()
		{
			return this.Oo0._.;
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x002295C1 File Offset: 0x002277C1
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.Oo0._. = A_0;
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x002295CA File Offset: 0x002277CA
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.Oo0._.().Text = A_0;
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x002295D8 File Offset: 0x002277D8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.Ooo_oo._o.().Enabled = false;
			this.Oo._ooo.(true);
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x002295ED File Offset: 0x002277ED
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001F39 RID: 7993
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001F3A RID: 7994
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001F3B RID: 7995
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001F3C RID: 7996
		private bool <<EMPTY_NAME>>;
	}
}
