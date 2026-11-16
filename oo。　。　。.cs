using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1Input;
using Foxtable.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000E2 RID: 226
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal partial class oo\u3002\u3000\u3002\u3000\u3002 : Form
	{
		// Token: 0x06000C40 RID: 3136 RVA: 0x00065C7C File Offset: 0x00063E7C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OOo__o_0OO.0. != null)
				{
					this.OOo__o_0OO.0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00065CBC File Offset: 0x00063EBC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o__.Oo_0.(new C1DockingTab());
			this.ooO._00Oooo_.(new C1DockingTabPage());
			this.o__.Oo_0.(new C1Button());
			this.o.O0o_0O.(new C1TextBox());
			this.ooO._00Oooo_.(new Label());
			this.o____oO_.Oo00.(new C1Button());
			this.O0O_0O_O__oo.0.(new C1Button());
			this.o.O0o_0O.(new ListBox());
			this.o__.Oo_0.(new C1DockingTabPage());
			this.o__.Oo_0.(new Label());
			this.o.o0o_.(new C1TextBox());
			this.Oo__.0_O00o.(new Label());
			this.oo000_.O_.(new C1TextBox());
			this.OoOo._o00O.(new C1Button());
			this.O0OOo.__O__0_o.(new C1Button());
			this.oo000_.O_.(new ListBox());
			this.o.o00OOoO0O00.(new C1Button());
			this.O0_0o0oo.0.(new C1Button());
			((ISupportInitialize)this.o__000.O.()).BeginInit();
			this.o__000.O.().SuspendLayout();
			this.oOO0__O_.oo00.().SuspendLayout();
			this.o__000.O.().SuspendLayout();
			base.SuspendLayout();
			this.o__000.O.().Controls.Add(this.oOO0__O_.oo00.());
			this.o__000.O.().Controls.Add(this.o__000.O.());
			this.o__000.O.().Location = new Point(12, 12);
			this.o__000.O.().Name = "C1DockingTab1";
			this.o__000.O.().Size = new Size(368, 501);
			this.o__000.O.().TabIndex = 0;
			this.o__000.O.().TabsSpacing = 0;
			this.o__000.O.().TabStyle = TabStyleEnum.WindowsXP;
			this.o__000.O.().VisualStyle = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.o__000.O.().VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.oOO0__O_.oo00.().Controls.Add(this.OOooo._o.());
			this.oOO0__O_.oo00.().Controls.Add(this.O0O_0O_O__oo.0.());
			this.oOO0__O_.oo00.().Controls.Add(this.O0O_0O_O__oo.0.());
			this.oOO0__O_.oo00.().Controls.Add(this.OO0o.o.());
			this.oOO0__O_.oo00.().Controls.Add(this.O_00_0_0.O0_oo.());
			this.oOO0__O_.oo00.().Controls.Add(this.OoOo._o00O.());
			this.oOO0__O_.oo00.().Location = new Point(2, 26);
			this.oOO0__O_.oo00.().Name = "C1DockingTabPage1";
			this.oOO0__O_.oo00.().Size = new Size(362, 471);
			this.oOO0__O_.oo00.().TabIndex = 0;
			this.oOO0__O_.oo00.().Text = "引用";
			this.OOooo._o.().Location = new Point(16, 436);
			this.OOooo._o.().Name = "btnSelectFile";
			this.OOooo._o.().Size = new Size(75, 23);
			this.OOooo._o.().TabIndex = 3;
			this.OOooo._o.().Text = "浏览...";
			this.OOooo._o.().UseVisualStyleBackColor = true;
			this.O0O_0O_O__oo.0.().Location = new Point(16, 405);
			this.O0O_0O_O__oo.0.().Name = "txtFile";
			this.O0O_0O_O__oo.0.().Size = new Size(330, 21);
			this.O0O_0O_O__oo.0.().TabIndex = 2;
			this.O0O_0O_O__oo.0.().AutoSize = true;
			this.O0O_0O_O__oo.0.().Location = new Point(16, 383);
			this.O0O_0O_O__oo.0.().Name = "Label3";
			this.O0O_0O_O__oo.0.().Size = new Size(35, 12);
			this.O0O_0O_O__oo.0.().TabIndex = 1;
			this.O0O_0O_O__oo.0.().Text = "引用:";
			this.OO0o.o.().Location = new Point(271, 436);
			this.OO0o.o.().Name = "btnDeleteRefrence";
			this.OO0o.o.().Size = new Size(75, 23);
			this.OO0o.o.().TabIndex = 5;
			this.OO0o.o.().Text = "删除";
			this.OO0o.o.().UseVisualStyleBackColor = true;
			this.O_00_0_0.O0_oo.().Location = new Point(190, 436);
			this.O_00_0_0.O0_oo.().Name = "btnAddRefrence";
			this.O_00_0_0.O0_oo.().Size = new Size(75, 23);
			this.O_00_0_0.O0_oo.().TabIndex = 4;
			this.O_00_0_0.O0_oo.().Text = "添加";
			this.O_00_0_0.O0_oo.().UseVisualStyleBackColor = true;
			this.OoOo._o00O.().FormattingEnabled = true;
			this.OoOo._o00O.().IntegralHeight = false;
			this.OoOo._o00O.().ItemHeight = 12;
			this.OoOo._o00O.().Location = new Point(16, 17);
			this.OoOo._o00O.().Name = "lstRefrence";
			this.OoOo._o00O.().Size = new Size(330, 352);
			this.OoOo._o00O.().TabIndex = 0;
			this.o__000.O.().Controls.Add(this.oOO0__O_.oo00.());
			this.o__000.O.().Controls.Add(this.Oo.O_0o0000.());
			this.o__000.O.().Controls.Add(this.o__000.O.());
			this.o__000.O.().Controls.Add(this.OoOo._o00O.());
			this.o__000.O.().Controls.Add(this.OOO_oo.__00.());
			this.o__000.O.().Controls.Add(this.O.0o__00oO0.());
			this.o__000.O.().Controls.Add(this.Oo.O_0o0000.());
			this.o__000.O.().Location = new Point(2, 26);
			this.o__000.O.().Name = "C1DockingTabPage2";
			this.o__000.O.().Size = new Size(362, 471);
			this.o__000.O.().TabIndex = 1;
			this.o__000.O.().Text = "命名空间";
			this.oOO0__O_.oo00.().AutoSize = true;
			this.oOO0__O_.oo00.().Location = new Point(16, 406);
			this.oOO0__O_.oo00.().Name = "Label2";
			this.oOO0__O_.oo00.().Size = new Size(59, 12);
			this.oOO0__O_.oo00.().TabIndex = 10;
			this.oOO0__O_.oo00.().Text = "空间别名:";
			this.Oo.O_0o0000.().Location = new Point(81, 402);
			this.Oo.O_0o0000.().Name = "txtAlias";
			this.Oo.O_0o0000.().Size = new Size(265, 21);
			this.Oo.O_0o0000.().TabIndex = 2;
			this.o__000.O.().AutoSize = true;
			this.o__000.O.().Location = new Point(16, 373);
			this.o__000.O.().Name = "Label1";
			this.o__000.O.().Size = new Size(59, 12);
			this.o__000.O.().TabIndex = 8;
			this.o__000.O.().Text = "命名空间:";
			this.OoOo._o00O.().Location = new Point(81, 369);
			this.OoOo._o00O.().Name = "txtSpace";
			this.OoOo._o00O.().Size = new Size(265, 21);
			this.OoOo._o00O.().TabIndex = 1;
			this.OOO_oo.__00.().Location = new Point(271, 435);
			this.OOO_oo.__00.().Name = "btnDeleteNameSpace";
			this.OOO_oo.__00.().Size = new Size(75, 23);
			this.OOO_oo.__00.().TabIndex = 4;
			this.OOO_oo.__00.().Text = "删除";
			this.OOO_oo.__00.().UseVisualStyleBackColor = true;
			this.O.0o__00oO0.().Location = new Point(190, 435);
			this.O.0o__00oO0.().Name = "btnAddNameSpace";
			this.O.0o__00oO0.().Size = new Size(75, 23);
			this.O.0o__00oO0.().TabIndex = 3;
			this.O.0o__00oO0.().Text = "添加";
			this.O.0o__00oO0.().UseVisualStyleBackColor = true;
			this.Oo.O_0o0000.().FormattingEnabled = true;
			this.Oo.O_0o0000.().IntegralHeight = false;
			this.Oo.O_0o0000.().ItemHeight = 12;
			this.Oo.O_0o0000.().Location = new Point(16, 17);
			this.Oo.O_0o0000.().Name = "lstNameSpace";
			this.Oo.O_0o0000.().Size = new Size(330, 337);
			this.Oo.O_0o0000.().TabIndex = 0;
			this.o__000.O.().Location = new Point(220, 527);
			this.o__000.O.().Name = "Button5";
			this.o__000.O.().Size = new Size(75, 23);
			this.o__000.O.().TabIndex = 0;
			this.o__000.O.().Text = "确定";
			this.o__000.O.().UseVisualStyleBackColor = true;
			this.oOO0__O_.oo00.().Location = new Point(301, 527);
			this.oOO0__O_.oo00.().Name = "Button6";
			this.oOO0__O_.oo00.().Size = new Size(75, 23);
			this.oOO0__O_.oo00.().TabIndex = 1;
			this.oOO0__O_.oo00.().Text = "取消";
			this.oOO0__O_.oo00.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(393, 562);
			base.Controls.Add(this.oOO0__O_.oo00.());
			base.Controls.Add(this.o__000.O.());
			base.Controls.Add(this.o__000.O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.....o.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "外部引用";
			((ISupportInitialize)this.o__000.O.()).EndInit();
			this.o__000.O.().ResumeLayout(false);
			this.oOO0__O_.oo00.().ResumeLayout(false);
			this.oOO0__O_.oo00.().PerformLayout();
			this.o__000.O.().ResumeLayout(false);
			this.o__000.O.().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x000666D6 File Offset: 0x000648D6
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.O_.O0_.;
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x000666DE File Offset: 0x000648DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			this.O_.O0_. = A_0;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000666E7 File Offset: 0x000648E7
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.O_.O0_.;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x000666EF File Offset: 0x000648EF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.O_.O0_. = A_0;
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x000666F8 File Offset: 0x000648F8
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.o_oo0.Ooo__O.;
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00066700 File Offset: 0x00064900
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.o_oo0.Ooo__O. = A_0;
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00066709 File Offset: 0x00064909
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.OOo__o_0OO.0.;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00066711 File Offset: 0x00064911
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.OOo__o_0OO.0. = A_0;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0006671A File Offset: 0x0006491A
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.O0o_0O.;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00066724 File Offset: 0x00064924
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo_oO.o00O0.);
			C1Button c1Button = this.o.O0o_0O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.O0o_0O. = A_0;
			c1Button = this.o.O0o_0O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00066767 File Offset: 0x00064967
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo000_.O_.;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00066770 File Offset: 0x00064970
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_o__0_oO.o_.);
			C1Button c1Button = this.oo000_.O_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo000_.O_. = A_0;
			c1Button = this.oo000_.O_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000667B3 File Offset: 0x000649B3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.o0o_.;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000667BC File Offset: 0x000649BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o__.oO.);
			C1Button c1Button = this.o.o0o_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.o0o_. = A_0;
			c1Button = this.o.o0o_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000667FF File Offset: 0x000649FF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOO_.O0_0.;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00066808 File Offset: 0x00064A08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_o0.O__0_00O0.);
			C1Button ooo_.O0_0. = this.OOO_.O0_0.;
			if (ooo_.O0_0. != null)
			{
				ooo_.O0_0..Click -= value;
			}
			this.OOO_.O0_0. = A_0;
			ooo_.O0_0. = this.OOO_.O0_0.;
			if (ooo_.O0_0. != null)
			{
				ooo_.O0_0..Click += value;
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0006684B File Offset: 0x00064A4B
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.o_oo0.Ooo__O.;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00066853 File Offset: 0x00064A53
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.o_oo0.Ooo__O. = A_0;
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0006685C File Offset: 0x00064A5C
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.OOo__o_0OO.0.;
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00066864 File Offset: 0x00064A64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.OOo__o_0OO.0. = A_0;
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0006686D File Offset: 0x00064A6D
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_.O0_.;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00066875 File Offset: 0x00064A75
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_.O0_. = A_0;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0006687E File Offset: 0x00064A7E
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO_.0OO.;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00066888 File Offset: 0x00064A88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_oO.O0O.);
			C1Button c1Button = this.oO_.0OO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO_.0OO. = A_0;
			c1Button = this.oO_.0OO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000668CB File Offset: 0x00064ACB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o__oO_o_0o.oOo.;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000668D4 File Offset: 0x00064AD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.0o__00oO0.);
			C1Button c1Button = this.o__oO_o_0o.oOo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o__oO_o_0o.oOo. = A_0;
			c1Button = this.o__oO_o_0o.oOo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00066917 File Offset: 0x00064B17
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_oo0.Ooo__O.;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0006691F File Offset: 0x00064B1F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_oo0.Ooo__O. = A_0;
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00066928 File Offset: 0x00064B28
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O.00oo0.;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00066930 File Offset: 0x00064B30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O.00oo0. = A_0;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00066939 File Offset: 0x00064B39
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o0o_O0.ooo_o0.;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00066941 File Offset: 0x00064B41
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o0o_O0.ooo_o0. = A_0;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0006694A File Offset: 0x00064B4A
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O._oOO_O.;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00066952 File Offset: 0x00064B52
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O._oOO_O. = A_0;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0006695B File Offset: 0x00064B5B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0_._o0_0.;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00066964 File Offset: 0x00064B64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_oO.O0O_.);
			C1Button o0_._o0_0. = this.O0_._o0_0.;
			if (o0_._o0_0. != null)
			{
				o0_._o0_0..Click -= value;
			}
			this.O0_._o0_0. = A_0;
			o0_._o0_0. = this.O0_._o0_0.;
			if (o0_._o0_0. != null)
			{
				o0_._o0_0..Click += value;
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x000669A8 File Offset: 0x00064BA8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num6;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				foreach (string item in SysInfo.referFiles.Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					IL_32:
					num2 = 3;
					this.OoOo._o00O.().Items.Add(item);
					IL_47:
					num2 = 4;
				}
				IL_57:
				num2 = 5;
				foreach (string item2 in SysInfo.spaceNames.Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					IL_82:
					num2 = 6;
					this.Oo.O_0o0000.().Items.Add(item2);
					IL_97:
					num2 = 7;
				}
				IL_A7:
				num2 = 8;
				this.OOo__o_0OO.0. = this.OoOo._o00O.().Items.Count;
				IL_BF:
				num2 = 9;
				this.O.00oo0. = this.Oo.O_0o0000.().Items.Count;
				IL_D8:
				num2 = 10;
				DataRow dataRow = this.OOo__o_0OO.0..Rows.Find(new object[]
				{
					"Refrence",
					o0_O.oOO0.oO0O0__.
				});
				IL_104:
				num2 = 11;
				if (dataRow == null || dataRow.IsNull("Config"))
				{
					goto IL_17A;
				}
				IL_117:
				num2 = 12;
				string[] array3 = dataRow["Config"].ToString().Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_142:
				num2 = 13;
				int num3 = array3.Length - 1;
				for (int k = 0; k <= num3; k++)
				{
					IL_152:
					num2 = 14;
					this.OoOo._o00O.().Items.Add(array3[k]);
					IL_16B:
					num2 = 15;
				}
				IL_17A:
				num2 = 16;
				dataRow = this.OOo__o_0OO.0..Rows.Find(new object[]
				{
					"Space",
					o0_O.oo0o_OoO_.Oo.
				});
				IL_1A6:
				num2 = 17;
				if (dataRow == null || dataRow.IsNull("Config"))
				{
					goto IL_21C;
				}
				IL_1B9:
				num2 = 18;
				string[] array4 = dataRow["Config"].ToString().Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_1E4:
				num2 = 19;
				int num4 = array4.Length - 1;
				for (int l = 0; l <= num4; l++)
				{
					IL_1F4:
					num2 = 20;
					this.Oo.O_0o0000.().Items.Add(array4[l]);
					IL_20D:
					num2 = 21;
				}
				IL_21C:
				goto IL_2C6;
				IL_221:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_287:
				goto IL_2BB;
				IL_289:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_299:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_289;
			}
			IL_2BB:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2C6:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00066CA0 File Offset: 0x00064EA0
		public oo\u3002\u3000\u3002\u3000\u3002(DataTable A_0)
		{
			base.Load += this.o0_0.oo0O00.;
			base.FormClosed += this.o__.oO.;
			this.Oo.O_0o0000.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
			{
				this.o__000.O.()
			});
			this.OOo__o_0OO.0. = A_0;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00066D18 File Offset: 0x00064F18
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = this.O0O_0O_O__oo.0.().Text.Trim();
			if (Operators.CompareString(text, "", true) > 0)
			{
				try
				{
					foreach (object value in this.OoOo._o00O.().Items)
					{
						string right = Conversions.ToString(value);
						if (Operators.CompareString(text, right, true) == 0)
						{
							MessageBox.Show("此文件已经引用！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return;
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
				if (this.o.O0o_0O.(text, true))
				{
					this.OoOo._o00O.().Items.Add(text);
				}
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00066DD0 File Offset: 0x00064FD0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OoOo._o00O.().SelectedIndex >= this.OOo__o_0OO.0.)
			{
				string file = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\\" + this.OoOo._o00O.().SelectedItem.ToString();
				c.OOOOO.o.().FileSystem.FileExists(file);
				this.OoOo._o00O.().Items.RemoveAt(this.OoOo._o00O.().SelectedIndex);
				return;
			}
			MessageBox.Show("此为必要的引用，不能删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00066E60 File Offset: 0x00065060
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Dll文件|*.Dll";
			openFileDialog.InitialDirectory = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath);
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (Operators.CompareString(c.OOOOO.o.().FileSystem.GetParentPath(openFileDialog.FileName), c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath), true) != 0)
				{
					c.OOOOO.o.().FileSystem.CopyFile(openFileDialog.FileName, c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\\" + c.OOOOO.o.().FileSystem.GetName(openFileDialog.FileName), true);
				}
				this.O0O_0O_O__oo.0.().Value = c.OOOOO.o.().FileSystem.GetName(openFileDialog.FileName);
				if (this.o.O0o_0O.(this.O0O_0O_O__oo.0.().Text, true))
				{
					this.O_00_0_0.O0_oo.().PerformClick();
					return;
				}
				c.OOOOO.o.().FileSystem.DeleteFile(c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\\" + this.O0O_0O_O__oo.0.().Text);
			}
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00066F96 File Offset: 0x00065196
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00066FA0 File Offset: 0x000651A0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num6;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				DataRow dataRow = this.OOo__o_0OO.0..Rows.Find(new object[]
				{
					"Refrence",
					o0_O.oOO0.oO0O0__.
				});
				IL_32:
				num2 = 3;
				if (this.OoOo._o00O.().Items.Count == this.OOo__o_0OO.0.)
				{
					goto IL_128;
				}
				IL_4F:
				num2 = 4;
				if (dataRow != null)
				{
					goto IL_9B;
				}
				IL_54:
				num2 = 5;
				dataRow = this.OOo__o_0OO.0..NewRow();
				IL_62:
				num2 = 6;
				dataRow["Name"] = "Refrence";
				IL_74:
				num2 = 7;
				dataRow["Type"] = o0_O.oOO0.oO0O0__.;
				IL_88:
				num2 = 8;
				this.OOo__o_0OO.0..Rows.Add(dataRow);
				IL_9B:
				num2 = 9;
				string text = "";
				IL_A5:
				num2 = 10;
				int ooo__o_0OO.0. = this.OOo__o_0OO.0.;
				int num3 = this.OoOo._o00O.().Items.Count - 1;
				for (int i = ooo__o_0OO.0.; i <= num3; i++)
				{
					IL_C6:
					num2 = 11;
					if (i > this.OOo__o_0OO.0.)
					{
						IL_D3:
						num2 = 12;
						text += "\r\n";
					}
					IL_E4:
					num2 = 13;
					text += this.OoOo._o00O.().Items[i].ToString();
					IL_107:
					num2 = 14;
				}
				IL_116:
				num2 = 15;
				dataRow["Config"] = text;
				goto IL_141;
				IL_128:
				num2 = 17;
				if (dataRow == null)
				{
					goto IL_141;
				}
				IL_12E:
				num2 = 18;
				dataRow["Config"] = "";
				IL_141:
				num2 = 19;
				dataRow = this.OOo__o_0OO.0..Rows.Find(new object[]
				{
					"Space",
					o0_O.oo0o_OoO_.Oo.
				});
				IL_16D:
				num2 = 20;
				if (this.Oo.O_0o0000.().Items.Count == this.O.00oo0.)
				{
					goto IL_269;
				}
				IL_18B:
				num2 = 21;
				if (dataRow != null)
				{
					goto IL_1DC;
				}
				IL_191:
				num2 = 22;
				dataRow = this.OOo__o_0OO.0..NewRow();
				IL_1A0:
				num2 = 23;
				dataRow["Name"] = "Space";
				IL_1B3:
				num2 = 24;
				dataRow["Type"] = o0_O.oo0o_OoO_.Oo.;
				IL_1C8:
				num2 = 25;
				this.OOo__o_0OO.0..Rows.Add(dataRow);
				IL_1DC:
				num2 = 26;
				string text2 = "";
				IL_1E6:
				num2 = 27;
				int o.00oo0. = this.O.00oo0.;
				int num4 = this.Oo.O_0o0000.().Items.Count - 1;
				for (int j = o.00oo0.; j <= num4; j++)
				{
					IL_207:
					num2 = 28;
					if (j > this.O.00oo0.)
					{
						IL_214:
						num2 = 29;
						text2 += "\r\n";
					}
					IL_225:
					num2 = 30;
					text2 += this.Oo.O_0o0000.().Items[j].ToString();
					IL_248:
					num2 = 31;
				}
				IL_257:
				num2 = 32;
				dataRow["Config"] = text2;
				goto IL_282;
				IL_269:
				num2 = 34;
				if (dataRow == null)
				{
					goto IL_282;
				}
				IL_26F:
				num2 = 35;
				dataRow["Config"] = "";
				IL_282:
				num2 = 36;
				base.DialogResult = DialogResult.OK;
				IL_28C:
				goto IL_372;
				IL_291:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_333:
				goto IL_367;
				IL_335:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_345:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_335;
			}
			IL_367:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_372:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00067344 File Offset: 0x00065544
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = this.OoOo._o00O.().Text.Trim();
			string text2 = this.Oo.O_0o0000.().Text.Trim();
			if (Operators.CompareString(text, "", true) != 0)
			{
				if (Operators.CompareString(text2, "", true) == 0)
				{
					MessageBox.Show("必须指定别名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				try
				{
					foreach (object value in this.Oo.O_0o0000.().Items)
					{
						string text3 = Conversions.ToString(value);
						if (Operators.CompareString(text3, text, true) == 0 || text3.StartsWith(text + "(", StringComparison.CurrentCultureIgnoreCase) || text3.EndsWith("(" + text2 + ")", StringComparison.CurrentCultureIgnoreCase))
						{
							MessageBox.Show("此命名空间已经引入，或者别名和现有命名空间冲突！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return;
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
				text = text + "(" + text2 + ")";
				if (this.o.O0o_0O.(text, false))
				{
					this.Oo.O_0o0000.().Items.Add(text);
				}
			}
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00067470 File Offset: 0x00065670
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ListBox listBox = this.Oo.O_0o0000.();
			if (listBox.SelectedIndex >= this.O.00oo0.)
			{
				listBox.Items.RemoveAt(listBox.SelectedIndex);
			}
			else
			{
				MessageBox.Show("此为必要的命名空间，不能删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000674BC File Offset: 0x000656BC
		private bool <<EMPTY_NAME>>(string A_0, bool A_1)
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
				VBCodeProvider vbcodeProvider = new VBCodeProvider();
				IL_10:
				num2 = 3;
				CompilerParameters compilerParameters = new CompilerParameters();
				IL_19:
				num2 = 4;
				string text = "Public Class User\r\nPrivate sub Test\r\nDim i As Integer = 123\r\nEnd Sub\r\nEnd Class";
				IL_22:
				num2 = 5;
				if (!A_1)
				{
					goto IL_7A;
				}
				IL_27:
				num2 = 6;
				if (A_0.StartsWith("system.", StringComparison.CurrentCultureIgnoreCase))
				{
					goto IL_67;
				}
				IL_37:
				num2 = 7;
				compilerParameters.ReferencedAssemblies.Add(c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\\" + A_0);
				goto IL_B2;
				IL_67:
				num2 = 9;
				compilerParameters.ReferencedAssemblies.Add(A_0);
				goto IL_B2;
				IL_7A:
				num2 = 11;
				string[] array = A_0.Split(new char[]
				{
					'(',
					')'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_96:
				num2 = 12;
				text = "Imports " + array[1] + " = " + array[0];
				IL_B2:
				num2 = 13;
				CompilerResults compilerResults = vbcodeProvider.CompileAssemblyFromSource(compilerParameters, new string[]
				{
					text
				});
				IL_CB:
				num2 = 14;
				if (compilerResults.Errors.Count <= 0)
				{
					goto IL_107;
				}
				IL_DD:
				num2 = 15;
				MessageBox.Show(compilerResults.Errors[0].ErrorText, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_100:
				num2 = 16;
				result = false;
				goto IL_10C;
				IL_107:
				num2 = 18;
				result = true;
				IL_10C:
				goto IL_1AA;
				IL_111:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_16B:
				goto IL_19F;
				IL_16D:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_17D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_16D;
			}
			IL_19F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1AA:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00067698 File Offset: 0x00065898
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(new object[]
			{
				base.Controls
			});
		}

		// Token: 0x040004AF RID: 1199
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040004B0 RID: 1200
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x040004B1 RID: 1201
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040004B2 RID: 1202
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040004B3 RID: 1203
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x040004B4 RID: 1204
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040004B5 RID: 1205
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040004B6 RID: 1206
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040004B7 RID: 1207
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040004B8 RID: 1208
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x040004B9 RID: 1209
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040004BA RID: 1210
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004BB RID: 1211
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040004BC RID: 1212
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040004BD RID: 1213
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004BE RID: 1214
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040004BF RID: 1215
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040004C0 RID: 1216
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004C1 RID: 1217
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040004C2 RID: 1218
		private int <<EMPTY_NAME>>;

		// Token: 0x040004C3 RID: 1219
		private int <<EMPTY_NAME>>;

		// Token: 0x040004C4 RID: 1220
		private DataTable <<EMPTY_NAME>>;
	}
}
