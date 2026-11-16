using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000E7 RID: 231
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class o\u3000\u3000 : Form
	{
		// Token: 0x06000D4A RID: 3402 RVA: 0x0006E787 File Offset: 0x0006C987
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.oo0OO.0O0_0. != null)
			{
				this.oo0OO.0O0_0..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0006E7A8 File Offset: 0x0006C9A8
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.OO_O.O_00.(new C1TextBox());
			this.oO__o0.____O.(new C1Button());
			this.OO_O.O_00.(new C1Button());
			this.OO_O.O_00.(new Label());
			base.SuspendLayout();
			this.o_.o___o.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.o_.o___o.().Location = new Point(12, 77);
			this.o_.o___o.().Name = "TextBox1";
			this.o_.o___o.().Size = new Size(399, 21);
			this.o_.o___o.().TabIndex = 1;
			this.o_.o___o.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.o_.o___o.().Location = new Point(336, 13);
			this.o_.o___o.().Name = "btnAccept";
			this.o_.o___o.().Size = new Size(75, 23);
			this.o_.o___o.().TabIndex = 2;
			this.o_.o___o.().Text = "确定";
			this.o_.o___o.().UseVisualStyleBackColor = true;
			this.O_Oo.oo_O__.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O_Oo.oo_O__.().DialogResult = DialogResult.Cancel;
			this.O_Oo.oo_O__.().Location = new Point(336, 42);
			this.O_Oo.oo_O__.().Name = "btnCancel";
			this.O_Oo.oo_O__.().Size = new Size(75, 23);
			this.O_Oo.oo_O__.().TabIndex = 3;
			this.O_Oo.oo_O__.().Text = "取消";
			this.O_Oo.oo_O__.().UseVisualStyleBackColor = true;
			this.o_.o___o.().AutoSize = true;
			this.o_.o___o.().Location = new Point(12, 23);
			this.o_.o___o.().Name = "Label1";
			this.o_.o___o.().Size = new Size(41, 12);
			this.o_.o___o.().TabIndex = 4;
			this.o_.o___o.().Text = "Label1";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.O_Oo.oo_O__.();
			base.ClientSize = new Size(424, 110);
			base.Controls.Add(this.o_.o___o.());
			base.Controls.Add(this.O_Oo.oo_O__.());
			base.Controls.Add(this.o_.o___o.());
			base.Controls.Add(this.o_.o___o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Tables";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "frmInputText";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0006EA44 File Offset: 0x0006CC44
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO_O.O_00.;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0006EA4C File Offset: 0x0006CC4C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_.o___o.);
			C1Button oo_O.O_00. = this.OO_O.O_00.;
			if (oo_O.O_00. != null)
			{
				oo_O.O_00..Click -= value;
			}
			this.OO_O.O_00. = A_0;
			oo_O.O_00. = this.OO_O.O_00.;
			if (oo_O.O_00. != null)
			{
				oo_O.O_00..Click += value;
			}
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x0006EA8F File Offset: 0x0006CC8F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO__o0.____O.;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0006EA97 File Offset: 0x0006CC97
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oO__o0.____O. = A_0;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0006EAA0 File Offset: 0x0006CCA0
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OO_O.O_00.;
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x0006EAA8 File Offset: 0x0006CCA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OO_O.O_00. = A_0;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0006EAB1 File Offset: 0x0006CCB1
		[CompilerGenerated]
		public virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oo0OO.0O0_0.;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0006EAB9 File Offset: 0x0006CCB9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.oo0OO.0O0_0. = A_0;
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0006EAC4 File Offset: 0x0006CCC4
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(o\u3000\u3000.ooOOO_O_Oo_0 A_0)
		{
			o\u3000\u3000.ooOOO_O_Oo_0 ooOOO_O_Oo_ = this.oo0OO.0O0_0.;
			o\u3000\u3000.ooOOO_O_Oo_0 ooOOO_O_Oo_2;
			do
			{
				ooOOO_O_Oo_2 = ooOOO_O_Oo_;
				o\u3000\u3000.ooOOO_O_Oo_0 value = (o\u3000\u3000.ooOOO_O_Oo_0)Delegate.Combine(ooOOO_O_Oo_2, A_0);
				ooOOO_O_Oo_ = Interlocked.CompareExchange<o\u3000\u3000.ooOOO_O_Oo_0>(ref this.oo0OO.0O0_0., value, ooOOO_O_Oo_2);
			}
			while (ooOOO_O_Oo_ != ooOOO_O_Oo_2);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0006EAFC File Offset: 0x0006CCFC
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(o\u3000\u3000.ooOOO_O_Oo_0 A_0)
		{
			o\u3000\u3000.ooOOO_O_Oo_0 ooOOO_O_Oo_ = this.oo0OO.0O0_0.;
			o\u3000\u3000.ooOOO_O_Oo_0 ooOOO_O_Oo_2;
			do
			{
				ooOOO_O_Oo_2 = ooOOO_O_Oo_;
				o\u3000\u3000.ooOOO_O_Oo_0 value = (o\u3000\u3000.ooOOO_O_Oo_0)Delegate.Remove(ooOOO_O_Oo_2, A_0);
				ooOOO_O_Oo_ = Interlocked.CompareExchange<o\u3000\u3000.ooOOO_O_Oo_0>(ref this.oo0OO.0O0_0., value, ooOOO_O_Oo_2);
			}
			while (ooOOO_O_Oo_ != ooOOO_O_Oo_2);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0006EB34 File Offset: 0x0006CD34
		public o\u3000\u3000(string A_0, string A_1, string A_2)
		{
			base.FormClosed += this.o_.o___o.;
			this.o_.o___o.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.Text = A_0;
			this.o_.o___o.().Text = A_1;
			this.o_.o___o.().Value = A_2;
			this.OO_O.O_00. = A_2;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0006EB9C File Offset: 0x0006CD9C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ValidateInputTextEventArgs validateInputTextEventArgs = new ValidateInputTextEventArgs(this, this.o_.o___o.().Text.Trim(), this.o_.o___o.());
			validateInputTextEventArgs.parentNode = this.oo0OO.0O0_0.;
			o\u3000\u3000.ooOOO_O_Oo_0 ooOOO_O_Oo_ = this.oo0OO.0O0_0.;
			if (ooOOO_O_Oo_ != null)
			{
				ooOOO_O_Oo_(this, validateInputTextEventArgs);
			}
			if (validateInputTextEventArgs.Cancel)
			{
				this.o_.o___o.().Focus();
				return;
			}
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0006EC00 File Offset: 0x0006CE00
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0006EC12 File Offset: 0x0006CE12
		public string <<EMPTY_NAME>>()
		{
			return this.OO_O.O_00.;
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x0006EC1A File Offset: 0x0006CE1A
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x0006EC27 File Offset: 0x0006CE27
		public string Value
		{
			get
			{
				return this.o_.o___o.().Text;
			}
			set
			{
				this.o_.o___o.().Value = this.Text;
			}
		}

		// Token: 0x04000529 RID: 1321
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400052A RID: 1322
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400052B RID: 1323
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400052C RID: 1324
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400052D RID: 1325
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400052E RID: 1326
		[CompilerGenerated]
		private o\u3000\u3000.ooOOO_O_Oo_0 <<EMPTY_NAME>>;

		// Token: 0x0400052F RID: 1327
		private string <<EMPTY_NAME>>;

		// Token: 0x04000530 RID: 1328
		internal TreeNode <<EMPTY_NAME>>;

		// Token: 0x020000E8 RID: 232
		// (Invoke) Token: 0x06000D5F RID: 3423
		public delegate void ooOOO_O_Oo_0(o\u3000\u3000 A_0, ValidateInputTextEventArgs A_1);
	}
}
