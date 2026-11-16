using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.EditActions;
using C1.Win.C1Command;
using C1.Win.C1Input;
using Foxtable.Syscmd;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000060 RID: 96
	[DesignerGenerated]
	internal partial class O\u3000\u3002\u3000\u3000 : Form
	{
		// Token: 0x06000313 RID: 787 RVA: 0x00009A27 File Offset: 0x00007C27
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.O0o__._oo0oo_. != null)
			{
				this.O0o__._oo0oo_..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00009A48 File Offset: 0x00007C48
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O.O_0o_Oo_.(new C1Button());
			this.oO0.oOO0o00.(new C1Button());
			this.O.0_0_o_.(new C1Button());
			this.OO_._OO.(new C1Button());
			this.O0O0.0__o0.(new OOo_o());
			this.oOo0o.o0.(new C1Button());
			this.oOo0.O0000_o.(new C1Button());
			this.o_ooo000Oo.0O_.(new C1Button());
			this.Oo.0_OO0o.(new C1Button());
			((ISupportInitialize)this.OOooo.Oo0OOO_0.()).BeginInit();
			((ISupportInitialize)this.o.o0o_o_o0____.()).BeginInit();
			((ISupportInitialize)this.o.OOo0O.()).BeginInit();
			((ISupportInitialize)this.OO0_.o.()).BeginInit();
			((ISupportInitialize)this.o0O_._o.()).BeginInit();
			((ISupportInitialize)this.O.O_0o_Oo_.()).BeginInit();
			((ISupportInitialize)this.Oo.0_ooo_0O.()).BeginInit();
			((ISupportInitialize)this.O0.0oO0o.()).BeginInit();
			base.SuspendLayout();
			this.OOooo.Oo0OOO_0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.OOooo.Oo0OOO_0.().Location = new Point(897, 563);
			this.OOooo.Oo0OOO_0.().Name = "Button1";
			this.OOooo.Oo0OOO_0.().Size = new Size(75, 24);
			this.OOooo.Oo0OOO_0.().TabIndex = 5;
			this.OOooo.Oo0OOO_0.().Text = "确定";
			this.OOooo.Oo0OOO_0.().UseVisualStyleBackColor = true;
			this.o.o0o_o_o0____.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.o.o0o_o_o0____.().Location = new Point(816, 563);
			this.o.o0o_o_o0____.().Name = "Button3";
			this.o.o0o_o_o0____.().Size = new Size(75, 24);
			this.o.o0o_o_o0____.().TabIndex = 4;
			this.o.o0o_o_o0____.().Text = "帮助";
			this.o.o0o_o_o0____.().UseVisualStyleBackColor = true;
			this.o.OOo0O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o.OOo0O.().Location = new Point(12, 563);
			this.o.OOo0O.().Name = "Button5";
			this.o.OOo0O.().Size = new Size(85, 24);
			this.o.OOo0O.().TabIndex = 1;
			this.o.OOo0O.().Text = "查找替换";
			this.o.OOo0O.().UseVisualStyleBackColor = true;
			this.OO0_.o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.OO0_.o.().Location = new Point(104, 563);
			this.OO0_.o.().Name = "btnCommand";
			this.OO0_.o.().Size = new Size(85, 24);
			this.OO0_.o.().TabIndex = 2;
			this.OO0_.o.().Text = "命令窗口";
			this.OO0_.o.().UseVisualStyleBackColor = true;
			this.O.O_0o_Oo_.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.O.O_0o_Oo_.().oo.O0ooOo00_0.(null);
			this.O.O_0o_Oo_.().Location = new Point(12, 12);
			this.O.O_0o_Oo_.().Margin = new Padding(4);
			this.O.O_0o_Oo_.().Name = "MyCodeEditor1";
			this.O.O_0o_Oo_.().Size = new Size(960, 533);
			this.O.O_0o_Oo_.().O00O.0_0Oo.("");
			this.O.O_0o_Oo_.().TabIndex = 0;
			this.o0O_._o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o0O_._o.().Location = new Point(196, 563);
			this.o0O_._o.().Name = "btnSQL";
			this.o0O_._o.().Size = new Size(85, 24);
			this.o0O_._o.().TabIndex = 7;
			this.o0O_._o.().Text = "执行SQL";
			this.o0O_._o.().UseVisualStyleBackColor = true;
			this.O.O_0o_Oo_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O.O_0o_Oo_.().Location = new Point(380, 563);
			this.O.O_0o_Oo_.().Name = "C1Button2";
			this.O.O_0o_Oo_.().Size = new Size(85, 24);
			this.O.O_0o_Oo_.().TabIndex = 12;
			this.O.O_0o_Oo_.().Text = "隐藏帮助";
			this.O.O_0o_Oo_.().UseVisualStyleBackColor = true;
			this.Oo.0_ooo_0O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Oo.0_ooo_0O.().Location = new Point(288, 563);
			this.Oo.0_ooo_0O.().Name = "btnOrientation";
			this.Oo.0_ooo_0O.().Size = new Size(85, 24);
			this.Oo.0_ooo_0O.().TabIndex = 11;
			this.Oo.0_ooo_0O.().Text = "纵向";
			this.Oo.0_ooo_0O.().UseVisualStyleBackColor = true;
			this.O0.0oO0o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O0.0oO0o.().Location = new Point(735, 562);
			this.O0.0oO0o.().Name = "C1Button1";
			this.O0.0oO0o.().Size = new Size(75, 24);
			this.O0.0oO0o.().TabIndex = 13;
			this.O0.0oO0o.().Text = "重排";
			this.O0.0oO0o.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(984, 598);
			base.Controls.Add(this.O0.0oO0o.());
			base.Controls.Add(this.O.O_0o_Oo_.());
			base.Controls.Add(this.Oo.0_ooo_0O.());
			base.Controls.Add(this.o0O_._o.());
			base.Controls.Add(this.OO0_.o.());
			base.Controls.Add(this.o.OOo0O.());
			base.Controls.Add(this.o.o0o_o_o0____.());
			base.Controls.Add(this.O.O_0o_Oo_.());
			base.Controls.Add(this.OOooo.Oo0OOO_0.());
			base.KeyPreview = true;
			base.Name = "o..o...O.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "代码编辑器";
			((ISupportInitialize)this.OOooo.Oo0OOO_0.()).EndInit();
			((ISupportInitialize)this.o.o0o_o_o0____.()).EndInit();
			((ISupportInitialize)this.o.OOo0O.()).EndInit();
			((ISupportInitialize)this.OO0_.o.()).EndInit();
			((ISupportInitialize)this.o0O_._o.()).EndInit();
			((ISupportInitialize)this.O.O_0o_Oo_.()).EndInit();
			((ISupportInitialize)this.Oo.0_ooo_0O.()).EndInit();
			((ISupportInitialize)this.O0.0oO0o.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000A085 File Offset: 0x00008285
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0O0.0__o0.;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000A090 File Offset: 0x00008290
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo0.OoO.);
			C1Button o0O0.0__o0. = this.O0O0.0__o0.;
			if (o0O0.0__o0. != null)
			{
				o0O0.0__o0..Click -= value;
			}
			this.O0O0.0__o0. = A_0;
			o0O0.0__o0. = this.O0O0.0__o0.;
			if (o0O0.0__o0. != null)
			{
				o0O0.0__o0..Click += value;
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000A0D3 File Offset: 0x000082D3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0_.o_O0_O.;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000A0DC File Offset: 0x000082DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOoO.o.);
			C1Button c1Button = this.o0_.o_O0_O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0_.o_O0_O. = A_0;
			c1Button = this.o0_.o_O0_O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000A11F File Offset: 0x0000831F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_o_.0.;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000A128 File Offset: 0x00008328
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo0O.O__o.);
			C1Button o_o_.0. = this.O_o_.0.;
			if (o_o_.0. != null)
			{
				o_o_.0..Click -= value;
			}
			this.O_o_.0. = A_0;
			o_o_.0. = this.O_o_.0.;
			if (o_o_.0. != null)
			{
				o_o_.0..Click += value;
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000A16B File Offset: 0x0000836B
		[CompilerGenerated]
		internal virtual OOo_o <<EMPTY_NAME>>()
		{
			return this.O0o__._oo0oo_.;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000A173 File Offset: 0x00008373
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(OOo_o A_0)
		{
			this.O0o__._oo0oo_. = A_0;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000A17C File Offset: 0x0000837C
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOO_._O_0___0_.;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000A184 File Offset: 0x00008384
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O._O_OOo0_o0.);
			C1Button ooo_._O_0___0_. = this.OOO_._O_0___0_.;
			if (ooo_._O_0___0_. != null)
			{
				ooo_._O_0___0_..Click -= value;
			}
			this.OOO_._O_0___0_. = A_0;
			ooo_._O_0___0_. = this.OOO_._O_0___0_.;
			if (ooo_._O_0___0_. != null)
			{
				ooo_._O_0___0_..Click += value;
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000A1C7 File Offset: 0x000083C7
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOo0.O0000_o.;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000A1D0 File Offset: 0x000083D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_o.oo0.);
			C1Button c1Button = this.oOo0.O0000_o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOo0.O0000_o. = A_0;
			c1Button = this.oOo0.O0000_o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000A213 File Offset: 0x00008413
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0oO.o_o____OO.;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000A21C File Offset: 0x0000841C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo_o__oo.oO.);
			C1Button c1Button = this.o0oO.o_o____OO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0oO.o_o____OO. = A_0;
			c1Button = this.o0oO.o_o____OO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000A25F File Offset: 0x0000845F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.oO__.;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000A268 File Offset: 0x00008468
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0O.oO.);
			C1Button o.oO__. = this.O.oO__.;
			if (o.oO__. != null)
			{
				o.oO__..Click -= value;
			}
			this.O.oO__. = A_0;
			o.oO__. = this.O.oO__.;
			if (o.oO__. != null)
			{
				o.oO__..Click += value;
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000A2AB File Offset: 0x000084AB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_oo.O.;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000A2B4 File Offset: 0x000084B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO0._O_00_OOo0.);
			C1Button oo_oo.O. = this.Oo_oo.O.;
			if (oo_oo.O. != null)
			{
				oo_oo.O..Click -= value;
			}
			this.Oo_oo.O. = A_0;
			oo_oo.O. = this.Oo_oo.O.;
			if (oo_oo.O. != null)
			{
				oo_oo.O..Click += value;
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000A2F8 File Offset: 0x000084F8
		public O\u3000\u3002\u3000\u3000(string A_0, string A_1, string A_2 = null)
		{
			base.FormClosing += this.O.oOoo_00.;
			base.KeyDown += this.O.oOoo_00.;
			base.Closed += this.O_O._00o0.;
			base.Load += this.OOooo.Oo0OOO_0.;
			this.O0oO0_O0.O. = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
			this.O.O_0o_Oo_.();
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
			{
				this.O.O_0o_Oo_.().OO.o00.()
			});
			try
			{
				foreach (object obj in this.O.O_0o_Oo_.().OO.o00.().TabPages)
				{
					C1DockingTabPage c1DockingTabPage = (C1DockingTabPage)obj;
					Main.OO_O.o..OOoo___.0.(c1DockingTabPage.Controls, "(default)");
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			try
			{
				foreach (object obj2 in base.Controls)
				{
					Control control = (Control)obj2;
					if (control != this.O.O_0o_Oo_.())
					{
						Main.OO_O.o..o.O000oo.(new object[]
						{
							control
						});
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			this.OO_oo_o_OO.o00. = A_1;
			this.O0o__._oo0oo_. = A_0;
			this.O.O_0o_Oo_.().O_oo__o.___oO. = A_0;
			this.O.O_0o_Oo_.().ooOO00O0o.00O0. = A_1;
			if (Operators.CompareString(A_0, "Global", true) == 0)
			{
				this.Text = "全局代码 - " + A_1;
			}
			else
			{
				this.Text = this.Text + " - " + A_1;
				this.Text = this.Text + " - " + Interaction.IIf(Operators.CompareString(this.O0o__._oo0oo_., "table", true) == 0, "表事件", this.O0o__._oo0oo_.).ToString();
			}
			this.O0o__._oo0oo_. = this.O.O_0o_Oo_.().ooo_O0_0.o_.();
			if (Operators.CompareString(A_0, "Global", true) == 0)
			{
				this.O0o__._oo0oo_..o0o_O_._. = false;
			}
			this.O0o__._oo0oo_..O.00_O. = A_2;
			this.O0o__._oo0oo_..O0O._O_oOo0O_.();
			this.O.O_0o_Oo_.().oooo.oO_0_.();
			if (Operators.CompareString(A_0, "UserFunction", true) == 0)
			{
				this.O0o__._oo0oo_..o_.0ooOooOoo00.("Public Function Test(ByVal Args() As Object) As Object");
				this.O0o__._oo0oo_..OOoO.o.("End Function");
			}
			else if (Operators.CompareString(A_0, "Global", true) == 0)
			{
				string a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], this.OO_oo_o_OO.o00.);
				this.O0o__._oo0oo_..o_.0ooOooOoo00.(a_);
				this.O0o__._oo0oo_..OOoO.o.("");
			}
			else if (Operators.CompareString(this.O0o__._oo0oo_..O.00_O., "", true) > 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				string str = o0_.o_000Oo0O_.00o.(this.O0o__._oo0oo_., this.OO_oo_o_OO.o00., true);
				stringBuilder.AppendLine("<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>");
				stringBuilder.AppendLine("Public Class tempCalss");
				stringBuilder.AppendLine("Inherits " + str);
				stringBuilder.AppendLine("''' <summary>");
				stringBuilder.AppendLine("''' 返回触发事件的控件");
				stringBuilder.AppendLine("''' </summary>");
				stringBuilder.AppendLine("Public Shadows Property Sender As " + this.O0o__._oo0oo_..O.00_O.);
				stringBuilder.AppendLine("End Class");
				stringBuilder.AppendLine("Public Async Sub Test(ByVal e As tempCalss)");
				this.O0o__._oo0oo_..o_.0ooOooOoo00.(stringBuilder.ToString());
				this.O0o__._oo0oo_..OOoO.o.("End Sub");
			}
			else
			{
				this.O0o__._oo0oo_..o_.0ooOooOoo00.("Public Async Sub Test(" + o0_.o_000Oo0O_.00o.(this.O0o__._oo0oo_., this.OO_oo_o_OO.o00., false) + ")");
				this.O0o__._oo0oo_..OOoO.o.("End Sub");
			}
			this.O0o__._oo0oo_..Oo000.0O.();
			if (Operators.CompareString(A_1, "", true) > 0)
			{
				this.O.O_0o_Oo_.().O_oO__OO._o_0.().Items.Add(A_1);
			}
			if (Operators.CompareString(A_0, "UserFunction", true) == 0 && Operators.CompareString(A_1, "test", true) == 0)
			{
				this.O.O_0o_Oo_.().o__0.O0OoOo_o.().Enabled = false;
				this.O.O_0o_Oo_.().o__O._.().Enabled = false;
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000A758 File Offset: 0x00008958
		internal string <<EMPTY_NAME>>()
		{
			return this.O.O_0o_Oo_.().o0O0O.O_o0OOO.();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000A765 File Offset: 0x00008965
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.O.O_0o_Oo_.().O00O.0_0Oo.(A_0);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000A775 File Offset: 0x00008975
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0O0.0__o0.())
			{
				this.O.O_0o_Oo_.().o_0_0O_0oo_.0_.(false);
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000A794 File Offset: 0x00008994
		private bool <<EMPTY_NAME>>()
		{
			int num;
			bool result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (Operators.CompareString(this.O0o__._oo0oo_., "Global", true) != 0)
				{
					goto IL_1E2;
				}
				IL_1F:
				num2 = 3;
				string text = "";
				IL_28:
				num2 = 4;
				foreach (DataRow dataRow in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Select("[Type] = " + Conversions.ToString(19)))
				{
					IL_65:
					num2 = 5;
					string a_ = O_O0OO.O_O._Oo.();
					IL_6E:
					num2 = 6;
					string text2 = "";
					IL_77:
					num2 = 7;
					if (Operators.CompareString(dataRow["Name"].ToString(), this.OO_oo_o_OO.o00., true) == 0)
					{
						IL_98:
						num2 = 8;
						text2 = this.O.O_0o_Oo_.();
					}
					else
					{
						IL_A7:
						num2 = 10;
						text2 = dataRow["Config"].ToString();
						IL_BD:
						num2 = 11;
						if (text2.StartsWith("[") && text2.EndsWith("]"))
						{
							IL_DC:
							num2 = 12;
							text2 = text2.TrimStart(new char[]
							{
								'['
							}).TrimEnd(new char[]
							{
								']'
							});
							IL_103:
							num2 = 13;
							a_ = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., O_O0OO.O_O._Oo.().Substring(0, 5)).Substring(0, 5);
						}
						IL_125:
						num2 = 14;
						text2 = O00.oO_.0o_oo_0O_.(text2, "API", a_);
					}
					IL_138:
					num2 = 15;
					text = text + text2 + "\r\n";
					IL_14B:
					num2 = 16;
				}
				IL_15F:
				num2 = 17;
				if (o0_.Oo_0.OOo0oO0.(text, "", O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true, "", true) == null)
				{
					goto IL_1D8;
				}
				IL_18B:
				num2 = 18;
				string file = OO_00oOO.ProjectPath + "Bin\\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Public.dll";
				IL_1AE:
				num2 = 19;
				if (!OO_00oOO.FileSys.FileExists(file))
				{
					goto IL_1CE;
				}
				IL_1BF:
				num2 = 20;
				OO_00oOO.FileSys.DeleteFile(file);
				IL_1CE:
				num2 = 21;
				result = true;
				goto IL_499;
				IL_1D8:
				num2 = 23;
				result = false;
				goto IL_499;
				IL_1E2:
				num2 = 25;
				StringBuilder stringBuilder = new StringBuilder();
				IL_1EC:
				num2 = 26;
				string text3 = this.O0o__._oo0oo_..Text;
				IL_1FC:
				num2 = 27;
				if (Operators.CompareString(text3, "", true) <= 0)
				{
					goto IL_22C;
				}
				IL_20F:
				num2 = 28;
				text3 = text3.Trim(new char[]
				{
					' ',
					'\n',
					'\r',
					'\t',
					'\u3000'
				});
				IL_22C:
				num2 = 29;
				if (Operators.CompareString(this.O0o__._oo0oo_., "UserFunction", true) != 0)
				{
					goto IL_28E;
				}
				IL_242:
				num2 = 30;
				if (Operators.CompareString(text3, "", true) <= 0 || !text3.StartsWith("'''async", StringComparison.OrdinalIgnoreCase))
				{
					goto IL_279;
				}
				IL_264:
				num2 = 31;
				stringBuilder.Append("Public Async Function Test(ByVal Args() As Object) As Threading.Tasks.Task(Of Object)");
				goto IL_30F;
				IL_279:
				num2 = 33;
				stringBuilder.Append("Public Function Test(ByVal Args() As Object) As Object");
				goto IL_30F;
				IL_28E:
				num2 = 35;
				if (Operators.CompareString(text3, "", true) <= 0 || !text3.Trim().StartsWith("'''async", StringComparison.OrdinalIgnoreCase))
				{
					goto IL_2E3;
				}
				IL_2B5:
				num2 = 36;
				stringBuilder.Append("Public Async Sub Test(" + o0_.o_000Oo0O_.00o.(this.O0o__._oo0oo_., this.OO_oo_o_OO.o00., false) + ")");
				goto IL_30F;
				IL_2E3:
				num2 = 38;
				stringBuilder.Append("Public Sub Test(" + o0_.o_000Oo0O_.00o.(this.O0o__._oo0oo_., this.OO_oo_o_OO.o00., false) + ")");
				IL_30F:
				num2 = 39;
				stringBuilder.Append("\r\n");
				IL_31F:
				num2 = 40;
				stringBuilder.Append(text3);
				IL_32C:
				num2 = 41;
				stringBuilder.Append("\r\n");
				IL_33C:
				num2 = 42;
				stringBuilder.Append(O_o00o_.o_O.0.);
				IL_34C:
				num2 = 43;
				stringBuilder.Append("\r\n");
				IL_35C:
				num2 = 44;
				if (Operators.CompareString(this.O0o__._oo0oo_., "UserFunction", true) != 0)
				{
					goto IL_384;
				}
				IL_372:
				num2 = 45;
				stringBuilder.Append("End Function");
				goto IL_394;
				IL_384:
				num2 = 47;
				stringBuilder.Append("End Sub");
				IL_394:
				num2 = 48;
				if (o0_.Oo_0.OOo0oO0.(stringBuilder.ToString(), "", O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false, "", true) != null)
				{
					goto IL_3CF;
				}
				IL_3C5:
				num2 = 49;
				result = false;
				goto IL_499;
				IL_3CF:
				num2 = 51;
				if (OO_00oOO.Forms.Count <= 12)
				{
					goto IL_494;
				}
				IL_3E3:
				num2 = 52;
				string text4 = o0OO__.OO0oO.o.(1450, 50, false).Trim();
				IL_3FA:
				num2 = 53;
				string str = "";
				IL_404:
				num2 = 54;
				string str2 = "";
				IL_40E:
				num2 = 55;
				o0OO__.oOO.o_.(ref str, ref str2);
				IL_41A:
				num2 = 56;
				text4 = text4.Replace("?", "").Trim();
				IL_435:
				num2 = 57;
				if (o0OO__.oOO.o_.() < 10)
				{
					goto IL_47A;
				}
				IL_441:
				num2 = 58;
				if (Operators.CompareString(text4, o0OO__.OO0oO.o.(str + str2), true) == 0 && Operators.CompareString(o0OO__.OO0oO.o.("abc"), "6A82F2AEC603834C", true) == 0)
				{
					goto IL_494;
				}
				IL_473:
				num2 = 59;
				result = false;
				goto IL_499;
				IL_47A:
				num2 = 61;
				if (Operators.CompareString(text4, "", true) <= 0)
				{
					goto IL_494;
				}
				IL_48D:
				num2 = 62;
				result = false;
				goto IL_499;
				IL_494:
				num2 = 63;
				result = true;
				IL_499:
				goto IL_5EB;
				IL_49E:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_5AC:
				goto IL_5E0;
				IL_5AE:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_5BE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_5AE;
			}
			IL_5E0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_5EB:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000ADB4 File Offset: 0x00008FB4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.O_0o_Oo_.().o_0_0O_0oo_.0_.(false);
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000ADCC File Offset: 0x00008FCC
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			if (this.O.O_0o_Oo_.().ooo.O_O_o0.())
			{
				DialogResult dialogResult = MessageBox.Show("保存修改吗？", "确认", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (dialogResult != DialogResult.Cancel)
				{
					if (dialogResult != DialogResult.Yes)
					{
						if (dialogResult == DialogResult.No)
						{
							base.DialogResult = DialogResult.Cancel;
						}
					}
					else if (this.O0O0.0__o0.())
					{
						this.O.O_0o_Oo_.().o_0_0O_0oo_.0_.(false);
						base.DialogResult = DialogResult.OK;
					}
					else
					{
						A_1.Cancel = true;
					}
				}
				else
				{
					A_1.Cancel = true;
				}
			}
			DataRow dataRow = O_O0OO.O0_00o.o0__o..Rows.Find("CodeEditor");
			if (dataRow == null)
			{
				dataRow = O_O0OO.O0_00o.o0__o..NewRow();
				dataRow["Name"] = "CodeEditor";
				O_O0OO.O0_00o.o0__o..Rows.Add(dataRow);
			}
			if (base.WindowState == FormWindowState.Normal)
			{
				dataRow["Config"] = string.Concat(new string[]
				{
					Conversions.ToString(base.Left),
					",",
					Conversions.ToString(base.Top),
					",",
					Conversions.ToString(base.Width),
					",",
					Conversions.ToString(base.Height),
					",",
					Conversions.ToString((int)this.O.O_0o_Oo_.().Oo0o__O.o.().Orientation),
					",",
					Conversions.ToString(this.O.O_0o_Oo_.().Oo0o__O.o.().SplitterDistance)
				});
				return;
			}
			dataRow["Config"] = Conversions.ToString((int)this.O.O_0o_Oo_.().Oo0o__O.o.().Orientation) + "," + Conversions.ToString(this.O.O_0o_Oo_.().Oo0o__O.o.().SplitterDistance);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000AF74 File Offset: 0x00009174
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OO_00oOO.ShowHelpWindow();
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000AF7B File Offset: 0x0000917B
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (!A_1.Shift & !A_1.Control & !A_1.Alt & A_1.KeyCode == Keys.F1)
			{
				OO_00oOO.FileSys.FileExists(Main.OO_O.o.);
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000AFB8 File Offset: 0x000091B8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					if (form is oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000)
					{
						((oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000)form).a = true;
						form.Close();
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Project.CommandWindow();
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000B030 File Offset: 0x00009230
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new O\u3002o_\u3002\u3002\u3002\u3000\u3002o().ShowDialog();
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000B03D File Offset: 0x0000923D
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
			this.O0o__._oo0oo_..O0.oOOO_o0..AssemblyReferences.Clear();
			GC.Collect();
			GC.Collect();
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000B070 File Offset: 0x00009270
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O.O_0o_Oo_.().Oo0o__O.o.().Orientation == Orientation.Vertical)
			{
				this.O.O_0o_Oo_.().Oo0o__O.o.().Orientation = Orientation.Horizontal;
				this.Oo.0_ooo_0O.().Text = "纵向(&V)";
				this.O.O_0o_Oo_.().Oo0o__O.o.().SplitterDistance = (int)Math.Round((double)this.O.O_0o_Oo_.().Oo0o__O.o.().Height / 3.0 * 2.0);
				return;
			}
			this.O.O_0o_Oo_.().Oo0o__O.o.().Orientation = Orientation.Vertical;
			this.Oo.0_ooo_0O.().Text = "横向(&V)";
			this.O.O_0o_Oo_.().Oo0o__O.o.().SplitterDistance = (int)Math.Round((double)this.O.O_0o_Oo_.().Oo0o__O.o.().Width / 2.0);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000B140 File Offset: 0x00009340
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.O_0o_Oo_.().Oo0o__O.o.().Panel2Collapsed = !this.O.O_0o_Oo_.().Oo0o__O.o.().Panel2Collapsed;
			if (this.O.O_0o_Oo_.().Oo0o__O.o.().Panel2Collapsed)
			{
				this.O.O_0o_Oo_.().Text = "显示帮助(&H)";
				return;
			}
			this.O.O_0o_Oo_.().Text = "隐藏帮助(&H)";
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000B1A4 File Offset: 0x000093A4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataRow dataRow = O_O0OO.O0_00o.o0__o..Rows.Find("CodeEditor");
			if (dataRow != null)
			{
				string[] array = dataRow["Config"].ToString().Split(new char[]
				{
					','
				});
				try
				{
					if (array.Length == 2)
					{
						base.WindowState = FormWindowState.Maximized;
						if (Operators.CompareString(array[0], "1", true) == 0)
						{
							this.O.O_0o_Oo_.().Oo0o__O.o.().Orientation = Orientation.Vertical;
						}
						this.O.O_0o_Oo_.().Oo0o__O.o.().SplitterDistance = Conversions.ToInteger(array[1]);
					}
					else
					{
						base.SetBounds(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]), int.Parse(array[3]));
						if (Operators.CompareString(array[4], "1", true) == 0)
						{
							this.O.O_0o_Oo_.().Oo0o__O.o.().Orientation = Orientation.Vertical;
						}
						this.O.O_0o_Oo_.().Oo0o__O.o.().SplitterDistance = Conversions.ToInteger(array[5]);
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000B2B4 File Offset: 0x000094B4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.O_0o_Oo_.().ooo_O0_0.o_.().ActiveView.ExecuteEditAction(new FindAction());
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000B2D1 File Offset: 0x000094D1
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.O_0o_Oo_.().ooo_O0_0.o_.().O_.__O0__000O.().PerformClick();
		}

		// Token: 0x0400008A RID: 138
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400008B RID: 139
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400008C RID: 140
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400008D RID: 141
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400008E RID: 142
		[CompilerGenerated]
		private OOo_o <<EMPTY_NAME>>;

		// Token: 0x0400008F RID: 143
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000090 RID: 144
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000091 RID: 145
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000092 RID: 146
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000093 RID: 147
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000094 RID: 148
		private string <<EMPTY_NAME>>;

		// Token: 0x04000095 RID: 149
		private string <<EMPTY_NAME>>;

		// Token: 0x04000096 RID: 150
		private O_o00o_ <<EMPTY_NAME>>;

		// Token: 0x04000097 RID: 151
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000098 RID: 152
		internal Dictionary<string, List<string>> <<EMPTY_NAME>>;

		// Token: 0x04000099 RID: 153
		internal Control <<EMPTY_NAME>>;
	}
}
