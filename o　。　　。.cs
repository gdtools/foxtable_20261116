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
	// Token: 0x020004C6 RID: 1222
	[DesignerGenerated]
	internal partial class o\u3000\u3002\u3000\u3000\u3002 : Form
	{
		// Token: 0x06005069 RID: 20585 RVA: 0x002395C4 File Offset: 0x002377C4
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OO._O_00O. != null)
				{
					this.OO._O_00O..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x00239604 File Offset: 0x00237804
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.ooO.0o_o0.(new Label());
			this.oO0.O0_.(new C1CheckBox());
			this.oO0.O0_.(new Label());
			this.oO0.O0_.(new C1Button());
			base.SuspendLayout();
			this.oO0.O0_.().AutoSize = true;
			this.oO0.O0_.().Location = new Point(24, 24);
			this.oO0.O0_.().Name = "Label1";
			this.oO0.O0_.().Size = new Size(257, 12);
			this.oO0.O0_.().TabIndex = 0;
			this.oO0.O0_.().Text = "其他人正在编辑NameValue,请等对方结束编辑。";
			this.oO0.O0_.().TextAlign = ContentAlignment.TopCenter;
			this.oO0.O0_.().AutoSize = true;
			this.oO0.O0_.().Location = new Point(67, 94);
			this.oO0.O0_.().Name = "CheckBox1";
			this.oO0.O0_.().Size = new Size(216, 16);
			this.oO0.O0_.().TabIndex = 1;
			this.oO0.O0_.().Text = "强行编辑NameValue(仅开发者可选!)";
			this.oO0.O0_.().UseVisualStyleBackColor = true;
			this.ooO.0o_o0.().AutoSize = true;
			this.ooO.0o_o0.().Location = new Point(38, 58);
			this.ooO.0o_o0.().Name = "Label2";
			this.ooO.0o_o0.().Size = new Size(191, 12);
			this.ooO.0o_o0.().TabIndex = 4;
			this.ooO.0o_o0.().Text = "若要解决异常导致的死锁，可选择:";
			this.oO0.O0_.().Location = new Point(129, 143);
			this.oO0.O0_.().Name = "Button1";
			this.oO0.O0_.().Size = new Size(75, 23);
			this.oO0.O0_.().TabIndex = 5;
			this.oO0.O0_.().Text = "确定";
			this.oO0.O0_.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(333, 187);
			base.Controls.Add(this.oO0.O0_.());
			base.Controls.Add(this.ooO.0o_o0.());
			base.Controls.Add(this.oO0.O0_.());
			base.Controls.Add(this.oO0.O0_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o0O.....";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "提示";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x002398AC File Offset: 0x00237AAC
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OO._O_00O.;
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x002398B4 File Offset: 0x00237AB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OO._O_00O. = A_0;
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x002398BD File Offset: 0x00237ABD
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.OO._O_00O.;
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x002398C5 File Offset: 0x00237AC5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.OO._O_00O. = A_0;
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x002398CE File Offset: 0x00237ACE
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOO_._.;
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x002398D6 File Offset: 0x00237AD6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOO_._. = A_0;
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x002398DF File Offset: 0x00237ADF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO._O_00O.;
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x002398E8 File Offset: 0x00237AE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_.OOo_.);
			C1Button oo._O_00O. = this.OO._O_00O.;
			if (oo._O_00O. != null)
			{
				oo._O_00O..Click -= value;
			}
			this.OO._O_00O. = A_0;
			oo._O_00O. = this.OO._O_00O.;
			if (oo._O_00O. != null)
			{
				oo._O_00O..Click += value;
			}
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x0023992B File Offset: 0x00237B2B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oO0.O0_.().Checked)
			{
				base.DialogResult = DialogResult.OK;
				return;
			}
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x00239949 File Offset: 0x00237B49
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (OO_00oOO.User.Type != UserTypeEnum.Developer)
			{
				this.oO0.O0_.().Enabled = false;
			}
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x00239964 File Offset: 0x00237B64
		internal o\u3000\u3002\u3000\u3000\u3002(string A_0)
		{
			base.Load += this.oO0.O0_.;
			base.FormClosed += this.o._0O_ooOo0__.;
			this.oO0.O0_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oO0.O0_.().Text = this.oO0.O0_.().Text.Replace("NameValue", A_0);
			this.oO0.O0_.().Text = this.oO0.O0_.().Text.Replace("NameValue", A_0);
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x002399F8 File Offset: 0x00237BF8
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04002119 RID: 8473
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400211A RID: 8474
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400211B RID: 8475
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400211C RID: 8476
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400211D RID: 8477
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
