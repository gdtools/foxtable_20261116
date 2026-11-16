using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000E5 RID: 229
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal partial class o\u30000 : Form
	{
		// Token: 0x06000CF2 RID: 3314 RVA: 0x0006BCA0 File Offset: 0x00069EA0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oOO_.o_0O. != null)
				{
					this.oOO_.o_0O..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0006BCE0 File Offset: 0x00069EE0
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o00_0_o._0_.(new C1Button());
			this.OO.0_00o.(new C1Button());
			this.OO.0_00o.(new CheckedListBox());
			this.O.Oo_00.(new C1Button());
			this.o0O_.0.(new C1Button());
			this.OO.0_00o.(new Label());
			this.OO.0_00o.(new C1CheckBox());
			base.SuspendLayout();
			this.O0O0o.o.().Location = new Point(295, 335);
			this.O0O0o.o.().Name = "Button4";
			this.O0O0o.o.().Size = new Size(75, 23);
			this.O0O0o.o.().TabIndex = 10;
			this.O0O0o.o.().Text = "反选";
			this.O0O0o.o.().UseVisualStyleBackColor = true;
			this.o0O._o__.().Location = new Point(295, 306);
			this.o0O._o__.().Name = "Button3";
			this.o0O._o__.().Size = new Size(75, 23);
			this.o0O._o__.().TabIndex = 9;
			this.o0O._o__.().Text = "全选";
			this.o0O._o__.().UseVisualStyleBackColor = true;
			this.oo_O_.O0___.().CheckOnClick = true;
			this.oo_O_.O0___.().FormattingEnabled = true;
			this.oo_O_.O0___.().Location = new Point(12, 36);
			this.oo_O_.O0___.().Name = "CheckedListBox1";
			this.oo_O_.O0___.().Size = new Size(266, 324);
			this.oo_O_.O0___.().TabIndex = 5;
			this.oo_O_.O0___.().Location = new Point(295, 65);
			this.oo_O_.O0___.().Name = "Button2";
			this.oo_O_.O0___.().Size = new Size(75, 23);
			this.oo_O_.O0___.().TabIndex = 8;
			this.oo_O_.O0___.().Text = "取消";
			this.oo_O_.O0___.().UseVisualStyleBackColor = true;
			this.o0__ooo0.O0.().Location = new Point(295, 36);
			this.o0__ooo0.O0.().Name = "Button1";
			this.o0__ooo0.O0.().Size = new Size(75, 23);
			this.o0__ooo0.O0.().TabIndex = 6;
			this.o0__ooo0.O0.().Text = "确定";
			this.o0__ooo0.O0.().UseVisualStyleBackColor = true;
			this.oo_O_.O0___.().AutoSize = true;
			this.oo_O_.O0___.().Location = new Point(10, 13);
			this.oo_O_.O0___.().Name = "Label1";
			this.oo_O_.O0___.().Size = new Size(107, 12);
			this.oo_O_.O0___.().TabIndex = 7;
			this.oo_O_.O0___.().Text = "请选择要合计的列:";
			this.oo_O_.O0___.().AutoSize = true;
			this.oo_O_.O0___.().Location = new Point(13, 367);
			this.oo_O_.O0___.().Name = "CheckBox1";
			this.oo_O_.O0___.().Size = new Size(120, 16);
			this.oo_O_.O0___.().TabIndex = 11;
			this.oo_O_.O0___.().Text = "自动进入合计模式";
			this.oo_O_.O0___.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(380, 397);
			base.Controls.Add(this.oo_O_.O0___.());
			base.Controls.Add(this.O0O0o.o.());
			base.Controls.Add(this.o0O._o__.());
			base.Controls.Add(this.oo_O_.O0___.());
			base.Controls.Add(this.oo_O_.O0___.());
			base.Controls.Add(this.o0__ooo0.O0.());
			base.Controls.Add(this.oo_O_.O0___.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o..ooO..";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "设置合计模式";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0006C0F4 File Offset: 0x0006A2F4
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOO_.o_0O.;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0006C0FC File Offset: 0x0006A2FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_.ooO.);
			C1Button c1Button = this.oOO_.o_0O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOO_.o_0O. = A_0;
			c1Button = this.oOO_.o_0O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0006C13F File Offset: 0x0006A33F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO_o_0O.O.;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0006C148 File Offset: 0x0006A348
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO.o_O_OO.);
			C1Button c1Button = this.oO_o_0O.O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO_o_0O.O. = A_0;
			c1Button = this.oO_o_0O.O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0006C18B File Offset: 0x0006A38B
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.oOO_.o_0O.;
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0006C193 File Offset: 0x0006A393
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			this.oOO_.o_0O. = A_0;
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0006C19C File Offset: 0x0006A39C
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0.0O_o_.;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0006C1A4 File Offset: 0x0006A3A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O__O00.__o.);
			C1Button o0.0O_o_. = this.O0.0O_o_.;
			if (o0.0O_o_. != null)
			{
				o0.0O_o_..Click -= value;
			}
			this.O0.0O_o_. = A_0;
			o0.0O_o_. = this.O0.0O_o_.;
			if (o0.0O_o_. != null)
			{
				o0.0O_o_..Click += value;
			}
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0006C1E7 File Offset: 0x0006A3E7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.Oo_00.;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0006C1F0 File Offset: 0x0006A3F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_O0.oOOo_00oO.);
			C1Button o.Oo_00. = this.O.Oo_00.;
			if (o.Oo_00. != null)
			{
				o.Oo_00..Click -= value;
			}
			this.O.Oo_00. = A_0;
			o.Oo_00. = this.O.Oo_00.;
			if (o.Oo_00. != null)
			{
				o.Oo_00..Click += value;
			}
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0006C233 File Offset: 0x0006A433
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOO_.o_0O.;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0006C23B File Offset: 0x0006A43B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOO_.o_0O. = A_0;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x0006C244 File Offset: 0x0006A444
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.oOO_.o_0O.;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0006C24C File Offset: 0x0006A44C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.oOO_.o_0O. = A_0;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0006C255 File Offset: 0x0006A455
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OO.0_00o. == 0)
			{
				this.OO.0_00o. = 1;
				this.oOO_.o_0O..Oo0Oo___.o0o.();
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0006C274 File Offset: 0x0006A474
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			List<string> list = new List<string>();
			if (Operators.CompareString(this.oOO_.o_0O..ooo_O0oOo.0O., "", true) > 0)
			{
				list.AddRange(this.oOO_.o_0O..ooo_O0oOo.0O..Split(new char[]
				{
					','
				}));
			}
			try
			{
				foreach (Col col in this.oOO_.o_0O..Cols)
				{
					if (col.IsNumeric())
					{
						this.oo_O_.O0___.().Items.Add(col.Name);
						if (list.Contains(col.Name))
						{
							this.oo_O_.O0___.().SetItemChecked(this.oo_O_.O0___.().Items.Count - 1, true);
						}
					}
				}
			}
			finally
			{
				IEnumerator<Col> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.oo_O_.O0___.().Checked = this.oOO_.o_0O..Oo.Oo0OoOOoo_.;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0006C364 File Offset: 0x0006A564
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num = this.oo_O_.O0___.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				this.oo_O_.O0___.().SetItemChecked(i, true);
			}
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0006C3A0 File Offset: 0x0006A5A0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num = this.oo_O_.O0___.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				this.oo_O_.O0___.().SetItemChecked(i, false);
			}
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0006C3D9 File Offset: 0x0006A5D9
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0006C3E4 File Offset: 0x0006A5E4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = "";
			int num = this.oo_O_.O0___.().Items.Count - 1;
			int num2;
			for (int i = 0; i <= num; i++)
			{
				if (this.oo_O_.O0___.().GetItemChecked(i))
				{
					this.oOO_.o_0O..Cols[this.oo_O_.O0___.().Items[i].ToString()].GrandTotal = true;
					num2++;
					text = text + this.oo_O_.O0___.().Items[i].ToString() + ",";
				}
				else
				{
					this.oOO_.o_0O..Cols[this.oo_O_.O0___.().Items[i].ToString()].GrandTotal = false;
				}
			}
			if (num2 == 0)
			{
				MessageBox.Show("至少要选择一个需要合计的列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			this.oOO_.o_0O..Oo.Oo0OoOOoo_. = this.oo_O_.O0___.().Checked;
			this.oOO_.o_0O..ClearSubtotal();
			this.oOO_.o_0O..ooo_O0oOo.0O. = text.Trim(new char[]
			{
				','
			});
			this.oOO_.o_0O..GrandTotal = true;
			base.Close();
			C1FlexGrid c1FlexGrid = this.oOO_.o_0O..Grid;
			c1FlexGrid.TopRow = c1FlexGrid.Rows.Count - 1;
			this.oOO_.o_0O..NeedSaveSetting = true;
			this.oOO_.o_0O..oo0OO0Ooo._.(true);
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0006C564 File Offset: 0x0006A764
		public o\u30000(Table A_0)
		{
			base.Activated += this.oOo.O0OO__O_.;
			base.Load += this.o0o0O.o0o0.;
			base.FormClosed += this.oo_O_.O0___.;
			this.OO.0_00o.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oOO_.o_0O. = A_0;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0006C5CF File Offset: 0x0006A7CF
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04000502 RID: 1282
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000503 RID: 1283
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000504 RID: 1284
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000505 RID: 1285
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x04000506 RID: 1286
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000507 RID: 1287
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000508 RID: 1288
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000509 RID: 1289
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400050A RID: 1290
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400050B RID: 1291
		private int <<EMPTY_NAME>>;
	}
}
