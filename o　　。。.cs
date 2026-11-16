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
	// Token: 0x020000EA RID: 234
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class o\u3000\u3000\u3002\u3002 : Form
	{
		// Token: 0x06000D69 RID: 3433 RVA: 0x0006EEF4 File Offset: 0x0006D0F4
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O._0O0OO0_o00_. != null)
				{
					this.O._0O0OO0_o00_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0006EF34 File Offset: 0x0006D134
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oOoo.o0_00o_o.(new Label());
			this.Oo_.O__0o.(new RadioButton());
			this.O._0O0OO0_o00_.(new RadioButton());
			this.O._0O0OO0_o00_.(new C1TextBox());
			this.oOoo.o0_00o_o.(new C1Button());
			this.O0_o._O0oo.(new C1Button());
			base.SuspendLayout();
			this.oOoo.o0_00o_o.().AutoSize = true;
			this.oOoo.o0_00o_o.().Location = new Point(13, 18);
			this.oOoo.o0_00o_o.().Name = "Label1";
			this.oOoo.o0_00o_o.().Size = new Size(119, 12);
			this.oOoo.o0_00o_o.().TabIndex = 0;
			this.oOoo.o0_00o_o.().Text = "文件已存在，请选择:";
			this.oOoo.o0_00o_o.().AutoSize = true;
			this.oOoo.o0_00o_o.().Checked = true;
			this.oOoo.o0_00o_o.().Location = new Point(31, 42);
			this.oOoo.o0_00o_o.().Name = "rdoOverWrite";
			this.oOoo.o0_00o_o.().Size = new Size(95, 16);
			this.oOoo.o0_00o_o.().TabIndex = 1;
			this.oOoo.o0_00o_o.().TabStop = true;
			this.oOoo.o0_00o_o.().Text = "覆盖现有文件";
			this.oOoo.o0_00o_o.().UseVisualStyleBackColor = true;
			this.O0_o._O0oo.().AutoSize = true;
			this.O0_o._O0oo.().Location = new Point(31, 65);
			this.O0_o._O0oo.().Name = "rdoRename";
			this.O0_o._O0oo.().Size = new Size(113, 16);
			this.O0_o._O0oo.().TabIndex = 2;
			this.O0_o._O0oo.().Text = "将文件重命名为:";
			this.O0_o._O0oo.().UseVisualStyleBackColor = true;
			this.oOoo.o0_00o_o.().Enabled = false;
			this.oOoo.o0_00o_o.().Location = new Point(31, 87);
			this.oOoo.o0_00o_o.().Name = "TextBox1";
			this.oOoo.o0_00o_o.().Size = new Size(245, 21);
			this.oOoo.o0_00o_o.().TabIndex = 4;
			this.Oo__.O_O__oO.().Location = new Point(69, 126);
			this.Oo__.O_O__oO.().Name = "Button1";
			this.Oo__.O_O__oO.().Size = new Size(75, 23);
			this.Oo__.O_O__oO.().TabIndex = 5;
			this.Oo__.O_O__oO.().Text = "确定";
			this.Oo__.O_O__oO.().UseVisualStyleBackColor = true;
			this.oOoo.o0_00o_o.().DialogResult = DialogResult.Cancel;
			this.oOoo.o0_00o_o.().Location = new Point(159, 126);
			this.oOoo.o0_00o_o.().Name = "Button2";
			this.oOoo.o0_00o_o.().Size = new Size(75, 23);
			this.oOoo.o0_00o_o.().TabIndex = 6;
			this.oOoo.o0_00o_o.().Text = "取消";
			this.oOoo.o0_00o_o.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(304, 169);
			base.Controls.Add(this.oOoo.o0_00o_o.());
			base.Controls.Add(this.Oo__.O_O__oO.());
			base.Controls.Add(this.oOoo.o0_00o_o.());
			base.Controls.Add(this.O0_o._O0oo.());
			base.Controls.Add(this.oOoo.o0_00o_o.());
			base.Controls.Add(this.oOoo.o0_00o_o.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MainTable";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "提示";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0006F2D8 File Offset: 0x0006D4D8
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O._0O0OO0_o00_.;
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0006F2E0 File Offset: 0x0006D4E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O._0O0OO0_o00_. = A_0;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0006F2E9 File Offset: 0x0006D4E9
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O._0O0OO0_o00_.;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0006F2F1 File Offset: 0x0006D4F1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O._0O0OO0_o00_. = A_0;
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0006F2FA File Offset: 0x0006D4FA
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O._0O0OO0_o00_.;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0006F304 File Offset: 0x0006D504
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo__.O_O__oO.);
			C1Button o._0O0OO0_o00_. = this.O._0O0OO0_o00_.;
			if (o._0O0OO0_o00_. != null)
			{
				o._0O0OO0_o00_..Click -= value;
			}
			this.O._0O0OO0_o00_. = A_0;
			o._0O0OO0_o00_. = this.O._0O0OO0_o00_.;
			if (o._0O0OO0_o00_. != null)
			{
				o._0O0OO0_o00_..Click += value;
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0006F347 File Offset: 0x0006D547
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_.O__0o.;
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0006F34F File Offset: 0x0006D54F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.Oo_.O__0o. = A_0;
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0006F358 File Offset: 0x0006D558
		[CompilerGenerated]
		public virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O._0O0OO0_o00_.;
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0006F360 File Offset: 0x0006D560
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O._0O0OO0_o00_. = A_0;
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0006F369 File Offset: 0x0006D569
		[CompilerGenerated]
		public virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.Oo_.O__0o.;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0006F374 File Offset: 0x0006D574
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.oOoo.o0_00o_o.);
			RadioButton oo_.O__0o. = this.Oo_.O__0o.;
			if (oo_.O__0o. != null)
			{
				oo_.O__0o..CheckedChanged -= value;
			}
			this.Oo_.O__0o. = A_0;
			oo_.O__0o. = this.Oo_.O__0o.;
			if (oo_.O__0o. != null)
			{
				oo_.O__0o..CheckedChanged += value;
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0006F3B8 File Offset: 0x0006D5B8
		public o\u3000\u3000\u3002\u3002(string A_0)
		{
			base.FormClosed += this.oo0_O0Oo._.;
			this.oOoo.o0_00o_o.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oOoo.o0_00o_o.().Value = c.OOOOO.o.().FileSystem.GetName(A_0);
			this.O0o0o0_00OO.oO. = A_0;
			this.OooO_0.o00O. = c.OOOOO.o.().FileSystem.GetParentPath(A_0);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0006F430 File Offset: 0x0006D630
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0_o._O0oo.().Checked)
			{
				if (Operators.CompareString(this.oOoo.o0_00o_o.().Text.Trim(), "", true) == 0)
				{
					return;
				}
				if (c.OOOOO.o.().FileSystem.FileExists(this.OooO_0.o00O. + "\\" + this.oOoo.o0_00o_o.().Text.Trim()))
				{
					MessageBox.Show("文件已经存在，请输入新的文件名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
			}
			else
			{
				try
				{
					c.OOOOO.o.().FileSystem.DeleteFile(this.O0o0o0_00OO.oO.);
				}
				catch (Exception ex)
				{
					return;
				}
			}
			this.O0o0o0_00OO.oO. = this.OooO_0.o00O. + "\\" + this.oOoo.o0_00o_o.().Text.Trim();
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0006F514 File Offset: 0x0006D714
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oOoo.o0_00o_o.().Enabled = this.O0_o._O0oo.().Checked;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0006F52C File Offset: 0x0006D72C
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04000535 RID: 1333
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000536 RID: 1334
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000537 RID: 1335
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000538 RID: 1336
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000539 RID: 1337
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400053A RID: 1338
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400053B RID: 1339
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400053C RID: 1340
		private string <<EMPTY_NAME>>;

		// Token: 0x0400053D RID: 1341
		public string <<EMPTY_NAME>>;
	}
}
