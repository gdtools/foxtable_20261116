using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace Foxtable
{
	// Token: 0x020000EB RID: 235
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class O\u3000\u3002\u30020\u3002\u3000__\u3002 : Form
	{
		// Token: 0x06000D7B RID: 3451 RVA: 0x0006F540 File Offset: 0x0006D740
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o00ooO_00._0. != null)
				{
					this.o00ooO_00._0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0006F580 File Offset: 0x0006D780
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O00O_00.oO__.(new C1ComboBox());
			this.o00ooO_00._0.(new C1TextBox());
			this.o00ooO_00._0.(new RadioButton());
			this.ooO_.oO.(new RadioButton());
			this.O00O_00.oO__.(new C1Button());
			this.ooO_.oO.(new C1Button());
			this.O00O_00.oO__.(new CheckBox());
			base.SuspendLayout();
			this.o0.O0o.().DropDownStyle = DropDownStyle.DropDownList;
			this.o0.O0o.().Location = new Point(15, 36);
			this.o0.O0o.().Name = "ComboBox1";
			this.o0.O0o.().Size = new Size(218, 20);
			this.o0.O0o.().TabIndex = 0;
			this.O00O_00.oO__.().Enabled = false;
			this.O00O_00.oO__.().Location = new Point(15, 96);
			this.O00O_00.oO__.().Name = "TextBox1";
			this.O00O_00.oO__.().Size = new Size(218, 21);
			this.O00O_00.oO__.().TabIndex = 3;
			this.ooO_.oO.().AutoSize = true;
			this.ooO_.oO.().Checked = true;
			this.ooO_.oO.().Location = new Point(15, 14);
			this.ooO_.oO.().Name = "rdoCurrent";
			this.ooO_.oO.().Size = new Size(95, 16);
			this.ooO_.oO.().TabIndex = 4;
			this.ooO_.oO.().TabStop = true;
			this.ooO_.oO.().Text = "选择现有目录";
			this.ooO_.oO.().UseVisualStyleBackColor = true;
			this.o0.O0o.().AutoSize = true;
			this.o0.O0o.().Location = new Point(15, 74);
			this.o0.O0o.().Name = "rdoCreate";
			this.o0.O0o.().Size = new Size(95, 16);
			this.o0.O0o.().TabIndex = 5;
			this.o0.O0o.().TabStop = true;
			this.o0.O0o.().Text = "创建新的目录";
			this.o0.O0o.().UseVisualStyleBackColor = true;
			this.O.o0_o.().Location = new Point(42, 174);
			this.O.o0_o.().Name = "Button1";
			this.O.o0_o.().Size = new Size(75, 23);
			this.O.o0_o.().TabIndex = 6;
			this.O.o0_o.().Text = "确定";
			this.O.o0_o.().UseVisualStyleBackColor = true;
			this.o0.O0o.().DialogResult = DialogResult.Cancel;
			this.o0.O0o.().Location = new Point(132, 174);
			this.o0.O0o.().Name = "Button2";
			this.o0.O0o.().Size = new Size(75, 23);
			this.o0.O0o.().TabIndex = 7;
			this.o0.O0o.().Text = "取消";
			this.o0.O0o.().UseVisualStyleBackColor = true;
			this.o0.O0o.().AutoSize = true;
			this.o0.O0o.().Location = new Point(15, 134);
			this.o0.O0o.().Name = "CheckBox1";
			this.o0.O0o.().Size = new Size(108, 16);
			this.o0.O0o.().TabIndex = 8;
			this.o0.O0o.().Text = "不再显示此窗口";
			this.o0.O0o.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(249, 209);
			base.Controls.Add(this.o0.O0o.());
			base.Controls.Add(this.o0.O0o.());
			base.Controls.Add(this.O.o0_o.());
			base.Controls.Add(this.o0.O0o.());
			base.Controls.Add(this.ooO_.oO.());
			base.Controls.Add(this.O00O_00.oO__.());
			base.Controls.Add(this.o0.O0o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ooo..O.O.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "选择目录";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0006F9BB File Offset: 0x0006DBBB
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o00ooO_00._0.;
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0006F9C3 File Offset: 0x0006DBC3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.o00ooO_00._0. = A_0;
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0006F9CC File Offset: 0x0006DBCC
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o00ooO_00._0.;
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0006F9D4 File Offset: 0x0006DBD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o00ooO_00._0. = A_0;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0006F9DD File Offset: 0x0006DBDD
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o00ooO_00._0.;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0006F9E8 File Offset: 0x0006DBE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.oo000oOo.OOo.);
			RadioButton radioButton = this.o00ooO_00._0.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.o00ooO_00._0. = A_0;
			radioButton = this.o00ooO_00._0.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0006FA2B File Offset: 0x0006DC2B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o00ooO_00._0.;
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0006FA34 File Offset: 0x0006DC34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0.O0o.);
			C1Button c1Button = this.o00ooO_00._0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o00ooO_00._0. = A_0;
			c1Button = this.o00ooO_00._0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0006FA77 File Offset: 0x0006DC77
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.O_Oo__O0.;
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0006FA7F File Offset: 0x0006DC7F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O.O_Oo__O0. = A_0;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0006FA88 File Offset: 0x0006DC88
		[CompilerGenerated]
		public virtual CheckBox <<EMPTY_NAME>>()
		{
			return this.o00ooO_00._0.;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x0006FA90 File Offset: 0x0006DC90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(CheckBox A_0)
		{
			this.o00ooO_00._0. = A_0;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0006FA99 File Offset: 0x0006DC99
		[CompilerGenerated]
		public virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O.O_Oo__O0.;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0006FAA4 File Offset: 0x0006DCA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.o0OOOOOO000._O.);
			RadioButton o.O_Oo__O0. = this.O.O_Oo__O0.;
			if (o.O_Oo__O0. != null)
			{
				o.O_Oo__O0..CheckedChanged -= value;
			}
			this.O.O_Oo__O0. = A_0;
			o.O_Oo__O0. = this.O.O_Oo__O0.;
			if (o.O_Oo__O0. != null)
			{
				o.O_Oo__O0..CheckedChanged += value;
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0006FAE7 File Offset: 0x0006DCE7
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0.O0o.().Enabled = this.ooO_.oO.().Checked;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0006FAFF File Offset: 0x0006DCFF
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O00O_00.oO__.().Enabled = this.o0.O0o.().Checked;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0006FB18 File Offset: 0x0006DD18
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0.O0o.().Items.Add("\\");
			this.o0.O0o.().SelectedIndex = 0;
			try
			{
				foreach (string path in c.OOOOO.o.().FileSystem.GetDirectories(this.oO_o_0_o.0_., SearchOption.SearchTopLevelOnly, new string[0]))
				{
					this.o0.O0o.().Items.Add(c.OOOOO.o.().FileSystem.GetName(path));
					if (Operators.CompareString(c.OOOOO.o.().FileSystem.GetName(path), this.OoO0o_oo0_.0O0., true) == 0)
					{
						this.o0.O0o.().SelectedIndex = this.o0.O0o.().Items.Count - 1;
					}
				}
			}
			finally
			{
				IEnumerator<string> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0006FBF4 File Offset: 0x0006DDF4
		public O\u3000\u3002\u30020\u3002\u3000__\u3002(string A_0, string A_1)
		{
			base.Load += this.O.o0_o.;
			base.FormClosed += this.o0.O0o.;
			this.O00O_00.oO__.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oO_o_0_o.0_. = A_0;
			this.OoO0o_oo0_.0O0. = A_1;
			this.O00O_00.oO__.().Value = A_1;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0006FC60 File Offset: 0x0006DE60
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o0.O0o.().Checked)
			{
				if (Operators.CompareString(this.O00O_00.oO__.().Text.Trim(), "", true) == 0)
				{
					return;
				}
				if (c.OOOOO.o.().FileSystem.DirectoryExists(this.oO_o_0_o.0_. + this.O00O_00.oO__.().Text))
				{
					MessageBox.Show("目录" + this.O00O_00.oO__.().Text + "已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				c.OOOOO.o.().FileSystem.CreateDirectory(this.oO_o_0_o.0_. + this.O00O_00.oO__.().Text);
				this.O0_00._O. = this.oO_o_0_o.0_. + this.O00O_00.oO__.().Text + "\\";
			}
			else if (this.o0.O0o.().SelectedIndex == 0)
			{
				this.O0_00._O. = this.oO_o_0_o.0_.;
			}
			else
			{
				this.O0_00._O. = this.oO_o_0_o.0_. + this.o0.O0o.().SelectedItem.ToString() + "\\";
			}
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0006FD7D File Offset: 0x0006DF7D
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400053E RID: 1342
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400053F RID: 1343
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000540 RID: 1344
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000541 RID: 1345
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04000542 RID: 1346
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000543 RID: 1347
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000544 RID: 1348
		[CompilerGenerated]
		private CheckBox <<EMPTY_NAME>>;

		// Token: 0x04000545 RID: 1349
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04000546 RID: 1350
		private string <<EMPTY_NAME>>;

		// Token: 0x04000547 RID: 1351
		public string <<EMPTY_NAME>>;

		// Token: 0x04000548 RID: 1352
		private string <<EMPTY_NAME>>;
	}
}
