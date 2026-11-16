using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.Syscmd;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000363 RID: 867
	[DesignerGenerated]
	internal partial class o\u3000\u30020\u3000 : Form
	{
		// Token: 0x06003632 RID: 13874 RVA: 0x00178840 File Offset: 0x00176A40
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OO0.__. != null)
				{
					this.OO0.__..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x00178880 File Offset: 0x00176A80
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.ooOo.0_.(new Label());
			this.Oo___O0O_.o_.(new C1Button());
			this.oo_00Oo.o.(new C1Button());
			this.Oo___O0O_.o_.(new C1NumericEdit());
			this.oo_o0__00.O00o.(new C1NumericEdit());
			this.oo_o0__00.O00o.(new Label());
			((ISupportInitialize)this.Oo___O0O_.o_.()).BeginInit();
			((ISupportInitialize)this.oo_00Oo.o.()).BeginInit();
			base.SuspendLayout();
			this.oo_00Oo.o.().AutoSize = true;
			this.oo_00Oo.o.().Location = new Point(157, 35);
			this.oo_00Oo.o.().Name = "Label2";
			this.oo_00Oo.o.().Size = new Size(23, 12);
			this.oo_00Oo.o.().TabIndex = 1;
			this.oo_00Oo.o.().Text = "至:";
			this.oo_00Oo.o.().Location = new Point(89, 77);
			this.oo_00Oo.o.().Name = "Button1";
			this.oo_00Oo.o.().Size = new Size(75, 23);
			this.oo_00Oo.o.().TabIndex = 2;
			this.oo_00Oo.o.().Text = "确定";
			this.oo_00Oo.o.().UseVisualStyleBackColor = true;
			this.Oo___O0O_.o_.().DialogResult = DialogResult.Cancel;
			this.Oo___O0O_.o_.().Location = new Point(170, 77);
			this.Oo___O0O_.o_.().Name = "Button2";
			this.Oo___O0O_.o_.().Size = new Size(75, 23);
			this.Oo___O0O_.o_.().TabIndex = 3;
			this.Oo___O0O_.o_.().Text = "取消";
			this.Oo___O0O_.o_.().UseVisualStyleBackColor = true;
			this.Oo___O0O_.o_.().Location = new Point(14, 32);
			this.Oo___O0O_.o_.().Name = "C1NumericEdit1";
			this.Oo___O0O_.o_.().Size = new Size(137, 21);
			this.Oo___O0O_.o_.().TabIndex = 0;
			this.Oo___O0O_.o_.().Tag = null;
			this.oo_00Oo.o.().Location = new Point(186, 32);
			this.oo_00Oo.o.().Name = "C1NumericEdit2";
			this.oo_00Oo.o.().Size = new Size(137, 21);
			this.oo_00Oo.o.().TabIndex = 1;
			this.oo_00Oo.o.().Tag = null;
			this.Oo___O0O_.o_.().AutoSize = true;
			this.Oo___O0O_.o_.().Location = new Point(12, 9);
			this.Oo___O0O_.o_.().Name = "Label1";
			this.Oo___O0O_.o_.().Size = new Size(41, 12);
			this.Oo___O0O_.o_.().TabIndex = 6;
			this.Oo___O0O_.o_.().Text = "Label1";
			base.AcceptButton = this.oo_00Oo.o.();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.Oo___O0O_.o_.();
			base.ClientSize = new Size(334, 112);
			base.Controls.Add(this.Oo___O0O_.o_.());
			base.Controls.Add(this.oo_00Oo.o.());
			base.Controls.Add(this.Oo___O0O_.o_.());
			base.Controls.Add(this.Oo___O0O_.o_.());
			base.Controls.Add(this.oo_00Oo.o.());
			base.Controls.Add(this.oo_00Oo.o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o....o..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "数值筛选";
			((ISupportInitialize)this.Oo___O0O_.o_.()).EndInit();
			((ISupportInitialize)this.oo_00Oo.o.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00178C35 File Offset: 0x00176E35
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.ooOo.0_.;
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x00178C3D File Offset: 0x00176E3D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.ooOo.0_. = A_0;
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x00178C46 File Offset: 0x00176E46
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooOo.0_.;
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x00178C50 File Offset: 0x00176E50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo000.ooOOO___.);
			C1Button c1Button = this.ooOo.0_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooOo.0_. = A_0;
			c1Button = this.ooOo.0_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00178C93 File Offset: 0x00176E93
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo_o0__00.O00o.;
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x00178C9B File Offset: 0x00176E9B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oo_o0__00.O00o. = A_0;
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x00178CA4 File Offset: 0x00176EA4
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.ooOo.0_.;
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x00178CAC File Offset: 0x00176EAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			this.ooOo.0_. = A_0;
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00178CB5 File Offset: 0x00176EB5
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.oo_o0__00.O00o.;
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x00178CBD File Offset: 0x00176EBD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			this.oo_o0__00.O00o. = A_0;
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00178CC6 File Offset: 0x00176EC6
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo_o0__00.O00o.;
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x00178CCE File Offset: 0x00176ECE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo_o0__00.O00o. = A_0;
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00178CD8 File Offset: 0x00176ED8
		public o\u3000\u30020\u3000(Table A_0, Col A_1, bool A_2)
		{
			base.FormClosed += this.oo000.ooOOO___.;
			this.Oo___O0O_.o_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.OO0.__. = A_0;
			this.ooOo.0_. = A_1;
			this.OO0.__. = A_2;
			if (A_2)
			{
				this.Oo___O0O_.o_.().Text = A_1.Name + " 在以下范围之外:";
			}
			else
			{
				this.Oo___O0O_.o_.().Text = A_1.Name + " 在以下范围之内:";
			}
			this.Oo___O0O_.o_.().DataType = A_0.foxGrid.Cols[A_1.Name].DataType;
			this.oo_00Oo.o.().DataType = A_0.foxGrid.Cols[A_1.Name].DataType;
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x00178DB4 File Offset: 0x00176FB4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				bool flag = Oo00.O____0O._0.(this.OO0.__.);
				IL_15:
				num2 = 3;
				if (!flag)
				{
					goto IL_36;
				}
				IL_1A:
				num2 = 4;
				string text = Oo00.OoOo_oo_.o_o.(this.ooOo.0_..Name, this.OO0.__.);
				goto IL_54;
				IL_36:
				num2 = 6;
				text = "[" + this.ooOo.0_..Name + "]";
				IL_54:
				num2 = 7;
				if (this.Oo___O0O_.o_.().Value == DBNull.Value || this.oo_00Oo.o.().Value == DBNull.Value)
				{
					goto IL_158;
				}
				IL_80:
				num2 = 9;
				if (!this.OO0.__.)
				{
					goto IL_E5;
				}
				IL_8B:
				num2 = 10;
				string a_ = string.Concat(new string[]
				{
					text,
					" < ",
					this.Oo___O0O_.o_.().Value.ToString(),
					" Or ",
					text,
					" > ",
					this.oo_00Oo.o.().Value.ToString()
				});
				goto IL_13D;
				IL_E5:
				num2 = 12;
				a_ = string.Concat(new string[]
				{
					text,
					" >= ",
					this.Oo___O0O_.o_.().Value.ToString(),
					" And ",
					text,
					" <= ",
					this.oo_00Oo.o.().Value.ToString()
				});
				IL_13D:
				num2 = 13;
				Filter.O0O0o.Oo0OO_oO.(this.OO0.__., a_, true);
				IL_14E:
				num2 = 14;
				base.DialogResult = DialogResult.OK;
				IL_158:
				goto IL_1E6;
				IL_15D:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1A7:
				goto IL_1DB;
				IL_1A9:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1B9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1A9;
			}
			IL_1DB:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1E6:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x00178FCC File Offset: 0x001771CC
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040015F2 RID: 5618
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040015F3 RID: 5619
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040015F4 RID: 5620
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015F5 RID: 5621
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015F6 RID: 5622
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x040015F7 RID: 5623
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x040015F8 RID: 5624
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040015F9 RID: 5625
		private Table <<EMPTY_NAME>>;

		// Token: 0x040015FA RID: 5626
		private Col <<EMPTY_NAME>>;

		// Token: 0x040015FB RID: 5627
		private bool <<EMPTY_NAME>>;
	}
}
