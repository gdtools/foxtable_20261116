using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000396 RID: 918
	[DesignerGenerated]
	internal partial class o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 : Form
	{
		// Token: 0x06003C3F RID: 15423 RVA: 0x001B5BCC File Offset: 0x001B3DCC
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o000_oO000o.O. != null)
				{
					this.o000_oO000o.O..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x001B5C0C File Offset: 0x001B3E0C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O_O.OO0O_oO__.(new C1Button());
			this.Ooo___0oo._o_o.(new C1Button());
			this.o000OO.O__O.(new Label());
			this.o000OO.O__O.(new C1TextBox());
			this.o0o0_00o.O_OoO.(new C1TextBox());
			this.o0o0_00o.O_OoO.(new Label());
			this.OO0.___oo___.(new Label());
			base.SuspendLayout();
			this.O0o0o0_00OO.oO.().DialogResult = DialogResult.Cancel;
			this.O0o0o0_00OO.oO.().Location = new Point(205, 166);
			this.O0o0o0_00OO.oO.().Name = "btnCancel";
			this.O0o0o0_00OO.oO.().Size = new Size(75, 23);
			this.O0o0o0_00OO.oO.().TabIndex = 10;
			this.O0o0o0_00OO.oO.().Text = "取消";
			this.O0o0o0_00OO.oO.().UseVisualStyleBackColor = true;
			this.OooO_0.o00O.().Location = new Point(124, 166);
			this.OooO_0.o00O.().Name = "btnAccept";
			this.OooO_0.o00O.().Size = new Size(75, 23);
			this.OooO_0.o00O.().TabIndex = 9;
			this.OooO_0.o00O.().Text = "确定";
			this.OooO_0.o00O.().UseVisualStyleBackColor = true;
			this.OO0.___oo___.().Location = new Point(14, 106);
			this.OO0.___oo___.().Name = "Label3";
			this.OO0.___oo___.().Size = new Size(388, 37);
			this.OO0.___oo___.().TabIndex = 11;
			this.OO0.___oo___.().Text = "提示:标题是表名更具描述性的表示，可以不输入，直接用表名作为标题。";
			this.O_O.OO0O_oO__.().Location = new Point(12, 78);
			this.O_O.OO0O_oO__.().Name = "txtCaption";
			this.O_O.OO0O_oO__.().Size = new Size(390, 21);
			this.O_O.OO0O_oO__.().TabIndex = 8;
			this.Ooo___0oo._o_o.().Location = new Point(12, 24);
			this.Ooo___0oo._o_o.().Name = "txtName";
			this.Ooo___0oo._o_o.().Size = new Size(390, 21);
			this.Ooo___0oo._o_o.().TabIndex = 5;
			this.O0o0o0_00OO.oO.().AutoSize = true;
			this.O0o0o0_00OO.oO.().Location = new Point(12, 63);
			this.O0o0o0_00OO.oO.().Name = "Label2";
			this.O0o0o0_00OO.oO.().Size = new Size(95, 12);
			this.O0o0o0_00OO.oO.().TabIndex = 7;
			this.O0o0o0_00OO.oO.().Text = "请输入新的标题:";
			this.OooO_0.o00O.().AutoSize = true;
			this.OooO_0.o00O.().Location = new Point(12, 9);
			this.OooO_0.o00O.().Name = "Label1";
			this.OooO_0.o00O.().Size = new Size(95, 12);
			this.OooO_0.o00O.().TabIndex = 6;
			this.OooO_0.o00O.().Text = "请输入新的表名:";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(416, 201);
			base.Controls.Add(this.O0o0o0_00OO.oO.());
			base.Controls.Add(this.OooO_0.o00O.());
			base.Controls.Add(this.OO0.___oo___.());
			base.Controls.Add(this.O_O.OO0O_oO__.());
			base.Controls.Add(this.Ooo___0oo._o_o.());
			base.Controls.Add(this.O0o0o0_00OO.oO.());
			base.Controls.Add(this.OooO_0.o00O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.0..0..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "重命名表";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x001B5FDE File Offset: 0x001B41DE
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0o0_00o.O_OoO.;
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x001B5FE6 File Offset: 0x001B41E6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o0o0_00o.O_OoO. = A_0;
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x001B5FEF File Offset: 0x001B41EF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o000OO.O__O.;
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x001B5FF8 File Offset: 0x001B41F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OooO_0.o00O.);
			C1Button c1Button = this.o000OO.O__O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o000OO.O__O. = A_0;
			c1Button = this.o000OO.O__O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x001B603B File Offset: 0x001B423B
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o000_oO000o.O.;
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x001B6043 File Offset: 0x001B4243
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o000_oO000o.O. = A_0;
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x001B604C File Offset: 0x001B424C
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o000_oO000o.O.;
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x001B6054 File Offset: 0x001B4254
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o000_oO000o.O. = A_0;
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x001B605D File Offset: 0x001B425D
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O0O_000.oOOo_0.;
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x001B6065 File Offset: 0x001B4265
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O0O_000.oOOo_0. = A_0;
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x001B606E File Offset: 0x001B426E
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o000OO.O__O.;
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x001B6076 File Offset: 0x001B4276
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o000OO.O__O. = A_0;
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x001B607F File Offset: 0x001B427F
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo_._.;
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x001B6087 File Offset: 0x001B4287
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo_._. = A_0;
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x001B6090 File Offset: 0x001B4290
		private bool <<EMPTY_NAME>>()
		{
			string text = this.Ooo___0oo._o_o.().Text.Trim();
			if (this.o000_oO000o.O. == null)
			{
				if (this.O0o0o0_00OO.oO.() || Operators.CompareString(text, this.o000_oO000o.O., true) != 0 || Operators.CompareString(text, "", true) == 0)
				{
					return Oo00.o.O0_O0.(text);
				}
			}
			else if (Operators.CompareString(text, this.o000_oO000o.O., true) != 0 || Operators.CompareString(text, "", true) == 0)
			{
				if (this.o000_oO000o.O..Contains(text))
				{
					MessageBox.Show("已经存在同名表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return false;
				}
				return o_O_o_oOoo__.O_o_._o0.(text);
			}
			return true;
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x001B6132 File Offset: 0x001B4332
		public bool <<EMPTY_NAME>>()
		{
			return this.o0o0_00o.O_OoO.;
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x001B613A File Offset: 0x001B433A
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.o0o0_00o.O_OoO. = A_0;
			if (A_0)
			{
				this.Text = "增加表";
				this.OooO_0.o00O.().Text = "请输入表名:";
				this.O0o0o0_00OO.oO.().Text = "请输入标题:";
			}
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x001B6171 File Offset: 0x001B4371
		internal string <<EMPTY_NAME>>()
		{
			return this.Ooo___0oo._o_o.().Text.Trim();
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x001B6183 File Offset: 0x001B4383
		internal string <<EMPTY_NAME>>()
		{
			return this.O_O.OO0O_oO__.().Text.Trim();
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x001B6195 File Offset: 0x001B4395
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o0o0_00o.O_OoO.())
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x001B61A8 File Offset: 0x001B43A8
		public o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(string A_0, string A_1)
		{
			base.FormClosed += this.OooO_0.o00O.;
			this.O_O.OO0O_oO__.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o000_oO000o.O. = A_0;
			this.Ooo___0oo._o_o.().Value = A_0;
			this.O_O.OO0O_oO__.().Value = A_1;
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x001B6207 File Offset: 0x001B4407
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040018CD RID: 6349
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040018CE RID: 6350
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018CF RID: 6351
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018D0 RID: 6352
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040018D1 RID: 6353
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040018D2 RID: 6354
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040018D3 RID: 6355
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040018D4 RID: 6356
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040018D5 RID: 6357
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040018D6 RID: 6358
		private string <<EMPTY_NAME>>;

		// Token: 0x040018D7 RID: 6359
		internal List<string> <<EMPTY_NAME>>;
	}
}
