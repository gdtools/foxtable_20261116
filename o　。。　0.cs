using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1Input;
using Foxtable.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace Foxtable
{
	// Token: 0x0200036C RID: 876
	[DesignerGenerated]
	internal partial class o\u3000\u3002\u3002\u30000\u3000 : Form
	{
		// Token: 0x06003787 RID: 14215 RVA: 0x0018AD88 File Offset: 0x00188F88
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.Oo00oO0_O0.O0. != null)
			{
				this.Oo00oO0_O0.O0..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x0018ADA8 File Offset: 0x00188FA8
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oo0ooOo.Oo.(new Label());
			this.OOO_.OOooO.(new C1TextBox());
			this.OoOo0.o.(new Label());
			this.O0_.O.(new C1TextBox());
			this.OOo00_o__oO.0.(new C1Button());
			this.O._oO000o.(new Label());
			this.ooooO.oo_Oo.(new C1Button());
			this.O_O0._0.(new C1Button());
			this.OoOo0.o.(new FolderBrowserDialog());
			this.OoOo0.o.(new C1CheckBox());
			this.O_o.oo.(new C1DockingTab());
			this.O.00_00O.(new C1DockingTabPage());
			this.O_o.oo.(new C1DockingTabPage());
			this.O00_.o_.(new C1Button());
			this.oo_OO.o0ooOO0_.(new C1Button());
			this.O0Oo_O00.OOO.(new C1Button());
			this.O_0_0_Oo0.__O_.(new C1Button());
			this.O.00_00O.(new C1Button());
			this.oO0OO__.o_.(new C1Button());
			this.OOO_.OOooO.(new C1DockingTab());
			this.OoOo0.o.(new C1DockingTabPage());
			this.O._oO000o.(new oo0_o0o_0o__());
			this.oo_0OOOo.O.(new C1DockingTabPage());
			this.OoOo0.o.(new oo0_o0o_0o__());
			this.O._oO000o.(new C1DockingTabPage());
			this.O0_.O.(new oo0_o0o_0o__());
			((ISupportInitialize)this.Oo_0oO_.oO.()).BeginInit();
			this.Oo_0oO_.oO.().SuspendLayout();
			this.OO_0.O.().SuspendLayout();
			this.Oo_0oO_.oO.().SuspendLayout();
			((ISupportInitialize)this.O_O0._0.()).BeginInit();
			this.O_O0._0.().SuspendLayout();
			this.OoO._O0o0__.().SuspendLayout();
			this.O_0.OOO0OoO_0.().SuspendLayout();
			this.o._00.().SuspendLayout();
			base.SuspendLayout();
			this.OOo__0.oOOoo.().AutoSize = true;
			this.OOo__0.oOOoo.().Location = new Point(23, 22);
			this.OOo__0.oOOoo.().Name = "Label1";
			this.OOo__0.oOOoo.().Size = new Size(59, 12);
			this.OOo__0.oOOoo.().TabIndex = 0;
			this.OOo__0.oOOoo.().Text = "项目名称:";
			this.O_O0._0.().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.O_O0._0.().Location = new Point(23, 37);
			this.O_O0._0.().Name = "txtName";
			this.O_O0._0.().Size = new Size(487, 21);
			this.O_O0._0.().TabIndex = 1;
			this.o._00.().AutoSize = true;
			this.o._00.().Location = new Point(23, 71);
			this.o._00.().Name = "Label2";
			this.o._00.().Size = new Size(59, 12);
			this.o._00.().TabIndex = 2;
			this.o._00.().Text = "项目位置:";
			this.oO0OO__.o_.().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.oO0OO__.o_.().Location = new Point(23, 86);
			this.oO0OO__.o_.().Name = "txtFolder";
			this.oO0OO__.o_.().ReadOnly = true;
			this.oO0OO__.o_.().Size = new Size(487, 21);
			this.oO0OO__.o_.().TabIndex = 3;
			this.O.O00_.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O.O00_.().Location = new Point(516, 84);
			this.O.O00_.().Name = "btnFolderBrowser";
			this.O.O00_.().Size = new Size(65, 23);
			this.O.O00_.().TabIndex = 4;
			this.O.O00_.().Text = "浏览(B)";
			this.O.O00_.().UseVisualStyleBackColor = true;
			this.O_0.OOO0OoO_0.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.O_0.OOO0OoO_0.().Location = new Point(23, 168);
			this.O_0.OOO0OoO_0.().Name = "lblDescription";
			this.O_0.OOO0OoO_0.().Size = new Size(558, 193);
			this.O_0.OOO0OoO_0.().TabIndex = 5;
			this.O_0.OOO0OoO_0.().Text = "提示:";
			this.o_O0__oOo.OoO.().Anchor = AnchorStyles.Bottom;
			this.o_O0__oOo.OoO.().Location = new Point(238, 442);
			this.o_O0__oOo.OoO.().Name = "btnOK";
			this.o_O0__oOo.OoO.().Size = new Size(75, 23);
			this.o_O0__oOo.OoO.().TabIndex = 1;
			this.o_O0__oOo.OoO.().Text = "确定(&O)";
			this.o_O0__oOo.OoO.().UseVisualStyleBackColor = true;
			this.o__.ooooo__0o.().Anchor = AnchorStyles.Bottom;
			this.o__.ooooo__0o.().DialogResult = DialogResult.Cancel;
			this.o__.ooooo__0o.().Location = new Point(319, 442);
			this.o__.ooooo__0o.().Name = "btnCancel";
			this.o__.ooooo__0o.().Size = new Size(75, 23);
			this.o__.ooooo__0o.().TabIndex = 2;
			this.o__.ooooo__0o.().Text = "取消(&X)";
			this.o__.ooooo__0o.().UseVisualStyleBackColor = true;
			this.OOo__0.oOOoo.().Description = "系统位置";
			this.OOo__0.oOOoo.().AutoCheck = false;
			this.OOo__0.oOOoo.().AutoSize = true;
			this.OOo__0.oOOoo.().Checked = true;
			this.OOo__0.oOOoo.().CheckState = CheckState.Checked;
			this.OOo__0.oOOoo.().Location = new Point(23, 124);
			this.OOo__0.oOOoo.().Name = "chkCreateFolder";
			this.OOo__0.oOOoo.().Size = new Size(108, 16);
			this.OOo__0.oOOoo.().TabIndex = 8;
			this.OOo__0.oOOoo.().Text = "创建专用文件夹";
			this.OOo__0.oOOoo.().UseVisualStyleBackColor = true;
			this.Oo_0oO_.oO.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.Oo_0oO_.oO.().Controls.Add(this.OO_0.O.());
			this.Oo_0oO_.oO.().Controls.Add(this.Oo_0oO_.oO.());
			this.Oo_0oO_.oO.().Location = new Point(12, 12);
			this.Oo_0oO_.oO.().Name = "C1DockingTab1";
			this.Oo_0oO_.oO.().Size = new Size(609, 413);
			this.Oo_0oO_.oO.().TabIndex = 0;
			this.Oo_0oO_.oO.().TabsCanFocus = false;
			this.Oo_0oO_.oO.().TabsSpacing = 0;
			this.Oo_0oO_.oO.().TabStyle = TabStyleEnum.WindowsXP;
			this.Oo_0oO_.oO.().VisualStyle = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.Oo_0oO_.oO.().VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.OO_0.O.().Controls.Add(this.oO0OO__.o_.());
			this.OO_0.O.().Controls.Add(this.O_O0._0.());
			this.OO_0.O.().Controls.Add(this.OOo__0.oOOoo.());
			this.OO_0.O.().Controls.Add(this.OOo__0.oOOoo.());
			this.OO_0.O.().Controls.Add(this.O.O00_.());
			this.OO_0.O.().Controls.Add(this.o._00.());
			this.OO_0.O.().Controls.Add(this.O_0.OOO0OoO_0.());
			this.OO_0.O.().Location = new Point(2, 26);
			this.OO_0.O.().Name = "C1DockingTabPage1";
			this.OO_0.O.().Size = new Size(603, 383);
			this.OO_0.O.().TabIndex = 0;
			this.OO_0.O.().Text = "创建项目";
			this.Oo_0oO_.oO.().Controls.Add(this.oo0oOo0o.O.());
			this.Oo_0oO_.oO.().Controls.Add(this.OO_0.O.());
			this.Oo_0oO_.oO.().Controls.Add(this.o_oO.__O0oOO.());
			this.Oo_0oO_.oO.().Controls.Add(this.O_._o0O0_00o.());
			this.Oo_0oO_.oO.().Controls.Add(this.Ooo.Oo0O___O_O.());
			this.Oo_0oO_.oO.().Controls.Add(this.Oo___.oo.());
			this.Oo_0oO_.oO.().Controls.Add(this.O_O0._0.());
			this.Oo_0oO_.oO.().Location = new Point(2, 26);
			this.Oo_0oO_.oO.().Name = "C1DockingTabPage2";
			this.Oo_0oO_.oO.().Size = new Size(603, 383);
			this.Oo_0oO_.oO.().TabIndex = 1;
			this.Oo_0oO_.oO.().Text = "创建表";
			this.oo0oOo0o.O.().Location = new Point(515, 267);
			this.oo0oOo0o.O.().Name = "btnDelete";
			this.oo0oOo0o.O.().Size = new Size(75, 23);
			this.oo0oOo0o.O.().TabIndex = 6;
			this.oo0oOo0o.O.().Text = "删除行";
			this.oo0oOo0o.O.().UseVisualStyleBackColor = true;
			this.OO_0.O.().Location = new Point(515, 237);
			this.OO_0.O.().Name = "btnMoveDown";
			this.OO_0.O.().Size = new Size(75, 23);
			this.OO_0.O.().TabIndex = 5;
			this.OO_0.O.().Text = "下移行";
			this.OO_0.O.().UseVisualStyleBackColor = true;
			this.o_oO.__O0oOO.().Location = new Point(515, 207);
			this.o_oO.__O0oOO.().Name = "btnMoveUp";
			this.o_oO.__O0oOO.().Size = new Size(75, 23);
			this.o_oO.__O0oOO.().TabIndex = 4;
			this.o_oO.__O0oOO.().Text = "上移行";
			this.o_oO.__O0oOO.().UseVisualStyleBackColor = true;
			this.O_._o0O0_00o.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O_._o0O0_00o.().Location = new Point(515, 97);
			this.O_._o0O0_00o.().Name = "btnRename";
			this.O_._o0O0_00o.().Size = new Size(75, 23);
			this.O_._o0O0_00o.().TabIndex = 3;
			this.O_._o0O0_00o.().Tag = "";
			this.O_._o0O0_00o.().Text = "重命名";
			this.O_._o0O0_00o.().UseVisualStyleBackColor = true;
			this.Ooo.Oo0O___O_O.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.Ooo.Oo0O___O_O.().Location = new Point(515, 67);
			this.Ooo.Oo0O___O_O.().Name = "btnDel";
			this.Ooo.Oo0O___O_O.().Size = new Size(75, 23);
			this.Ooo.Oo0O___O_O.().TabIndex = 2;
			this.Ooo.Oo0O___O_O.().Text = "删除表";
			this.Ooo.Oo0O___O_O.().UseVisualStyleBackColor = true;
			this.Oo___.oo.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.Oo___.oo.().Location = new Point(515, 37);
			this.Oo___.oo.().Name = "btnAdd";
			this.Oo___.oo.().Size = new Size(75, 23);
			this.Oo___.oo.().TabIndex = 1;
			this.Oo___.oo.().Text = "增加表";
			this.Oo___.oo.().UseVisualStyleBackColor = true;
			this.O_O0._0.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.O_O0._0.().BorderStyle = BorderStyle.None;
			this.O_O0._0.().Controls.Add(this.OoO._O0o0__.());
			this.O_O0._0.().Controls.Add(this.O_0.OOO0OoO_0.());
			this.O_O0._0.().Controls.Add(this.o._00.());
			this.O_O0._0.().Location = new Point(13, 12);
			this.O_O0._0.().Name = "TablePages";
			this.O_O0._0.().Size = new Size(487, 356);
			this.O_O0._0.().TabIndex = 0;
			this.O_O0._0.().TabsCanFocus = false;
			this.O_O0._0.().TabsSpacing = 0;
			this.O_O0._0.().TabStyle = TabStyleEnum.WindowsXP;
			this.O_O0._0.().VisualStyle = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.O_O0._0.().VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.OoO._O0o0__.().Controls.Add(this.OOo__0.oOOoo.());
			this.OoO._O0o0__.().Location = new Point(0, 25);
			this.OoO._O0o0__.().Name = "C1DockingTabPage3";
			this.OoO._O0o0__.().Size = new Size(487, 331);
			this.OoO._O0o0__.().TabIndex = 0;
			this.OoO._O0o0__.().Text = "表A";
			this.OOo__0.oOOoo.().Dock = DockStyle.Fill;
			this.OOo__0.oOOoo.().Location = new Point(0, 0);
			this.OOo__0.oOOoo.().Name = "StructureEditor1";
			this.OOo__0.oOOoo.().Size = new Size(487, 331);
			this.OOo__0.oOOoo.().TabIndex = 0;
			this.O_0.OOO0OoO_0.().Controls.Add(this.O_O0._0.());
			this.O_0.OOO0OoO_0.().Location = new Point(0, 25);
			this.O_0.OOO0OoO_0.().Name = "C1DockingTabPage4";
			this.O_0.OOO0OoO_0.().Size = new Size(487, 331);
			this.O_0.OOO0OoO_0.().TabIndex = 1;
			this.O_0.OOO0OoO_0.().Text = "表B";
			this.O_O0._0.().Dock = DockStyle.Fill;
			this.O_O0._0.().Location = new Point(0, 0);
			this.O_O0._0.().Name = "StructureEditor2";
			this.O_O0._0.().Size = new Size(487, 331);
			this.O_O0._0.().TabIndex = 1;
			this.o._00.().Controls.Add(this.ooOOO0OO0o.O.());
			this.o._00.().Location = new Point(0, 25);
			this.o._00.().Name = "C1DockingTabPage5";
			this.o._00.().Size = new Size(487, 331);
			this.o._00.().TabIndex = 2;
			this.o._00.().Text = "表C";
			this.ooOOO0OO0o.O.().Dock = DockStyle.Fill;
			this.ooOOO0OO0o.O.().Location = new Point(0, 0);
			this.ooOOO0OO0o.O.().Name = "StructureEditor3";
			this.ooOOO0OO0o.O.().Size = new Size(487, 331);
			this.ooOOO0OO0o.O.().TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(633, 477);
			base.Controls.Add(this.Oo_0oO_.oO.());
			base.Controls.Add(this.o__.ooooo__0o.());
			base.Controls.Add(this.o_O0__oOo.OoO.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "OO....o.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "创建项目";
			((ISupportInitialize)this.Oo_0oO_.oO.()).EndInit();
			this.Oo_0oO_.oO.().ResumeLayout(false);
			this.OO_0.O.().ResumeLayout(false);
			this.OO_0.O.().PerformLayout();
			this.Oo_0oO_.oO.().ResumeLayout(false);
			((ISupportInitialize)this.O_O0._0.()).EndInit();
			this.O_O0._0.().ResumeLayout(false);
			this.OoO._O0o0__.().ResumeLayout(false);
			this.O_0.OOO0OoO_0.().ResumeLayout(false);
			this.o._00.().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x0018BC9F File Offset: 0x00189E9F
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0.0O__o.;
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x0018BCA7 File Offset: 0x00189EA7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0.0O__o. = A_0;
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x0018BCB0 File Offset: 0x00189EB0
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.OOO0_o0OO0_o.;
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x0018BCB8 File Offset: 0x00189EB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.OOO0_o0OO0_o. = A_0;
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x0018BCC1 File Offset: 0x00189EC1
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO0O._O.;
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x0018BCCC File Offset: 0x00189ECC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO.O_0O.);
			C1Button oo0O._O. = this.OO0O._O.;
			if (oo0O._O. != null)
			{
				oo0O._O..Click -= value;
			}
			this.OO0O._O. = A_0;
			oo0O._O. = this.OO0O._O.;
			if (oo0O._O. != null)
			{
				oo0O._O..Click += value;
			}
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x0018BD0F File Offset: 0x00189F0F
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOo.OOo.;
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x0018BD17 File Offset: 0x00189F17
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOo.OOo. = A_0;
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x0018BD20 File Offset: 0x00189F20
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_oO0.o00.;
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x0018BD28 File Offset: 0x00189F28
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O00O__Oo.0O.);
			C1Button c1Button = this.o_oO0.o00.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_oO0.o00. = A_0;
			c1Button = this.o_oO0.o00.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x0018BD6B File Offset: 0x00189F6B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOoOooOo.OOOO.;
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x0018BD73 File Offset: 0x00189F73
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.OOoOooOo.OOOO. = A_0;
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x0018BD7C File Offset: 0x00189F7C
		[CompilerGenerated]
		internal virtual FolderBrowserDialog <<EMPTY_NAME>>()
		{
			return this.o0.0O__o.;
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x0018BD84 File Offset: 0x00189F84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(FolderBrowserDialog A_0)
		{
			this.o0.0O__o. = A_0;
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x0018BD8D File Offset: 0x00189F8D
		[CompilerGenerated]
		public virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.Oo00oO0_O0.O0.;
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x0018BD98 File Offset: 0x00189F98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			KeyPressEventHandler value = new KeyPressEventHandler(this.OOO_.OOooO.);
			EventHandler value2 = new EventHandler(this.oO_O00._o.);
			C1TextBox oo00oO0_O0.O0. = this.Oo00oO0_O0.O0.;
			if (oo00oO0_O0.O0. != null)
			{
				oo00oO0_O0.O0..KeyPress -= value;
				oo00oO0_O0.O0..TextChanged -= value2;
			}
			this.Oo00oO0_O0.O0. = A_0;
			oo00oO0_O0.O0. = this.Oo00oO0_O0.O0.;
			if (oo00oO0_O0.O0. != null)
			{
				oo00oO0_O0.O0..KeyPress += value;
				oo00oO0_O0.O0..TextChanged += value2;
			}
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x0018BDF6 File Offset: 0x00189FF6
		[CompilerGenerated]
		public virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o__00oOo.OOo__.;
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x0018BDFE File Offset: 0x00189FFE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o__00oOo.OOo__. = A_0;
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x0018BE07 File Offset: 0x0018A007
		[CompilerGenerated]
		public virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o0.0O__o.;
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x0018BE0F File Offset: 0x0018A00F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o0.0O__o. = A_0;
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x0018BE18 File Offset: 0x0018A018
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.OO0O._O.;
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x0018BE20 File Offset: 0x0018A020
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			this.OO0O._O. = A_0;
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x0018BE29 File Offset: 0x0018A029
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.OO0O._O.;
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x0018BE31 File Offset: 0x0018A031
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.OO0O._O. = A_0;
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x0018BE3A File Offset: 0x0018A03A
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.o_oO0.o00.;
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x0018BE42 File Offset: 0x0018A042
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.o_oO0.o00. = A_0;
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x0018BE4B File Offset: 0x0018A04B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_.___oO00oO.;
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x0018BE54 File Offset: 0x0018A054
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo0O_OO_.0_.);
			C1Button o_.___oO00oO. = this.O_.___oO00oO.;
			if (o_.___oO00oO. != null)
			{
				o_.___oO00oO..Click -= value;
			}
			this.O_.___oO00oO. = A_0;
			o_.___oO00oO. = this.O_.___oO00oO.;
			if (o_.___oO00oO. != null)
			{
				o_.___oO00oO..Click += value;
			}
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x0018BE97 File Offset: 0x0018A097
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0o0o.o.;
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x0018BEA0 File Offset: 0x0018A0A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo0ooO0._o.);
			C1Button c1Button = this.o0o0o.o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0o0o.o. = A_0;
			c1Button = this.o0o0o.o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x0018BEE3 File Offset: 0x0018A0E3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo_0_._o__0.;
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x0018BEEC File Offset: 0x0018A0EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.ooo0oO0___.Oo.);
			C1Button c1Button = this.oo_0_._o__0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo_0_._o__0. = A_0;
			c1Button = this.oo_0_._o__0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x0018BF2F File Offset: 0x0018A12F
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.O.OOO0_o0OO0_o.;
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x0018BF37 File Offset: 0x0018A137
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			this.O.OOO0_o0OO0_o. = A_0;
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x0018BF40 File Offset: 0x0018A140
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.O_oo.o0OoO__Oo.;
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x0018BF48 File Offset: 0x0018A148
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.O_oo.o0OoO__Oo. = A_0;
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x0018BF51 File Offset: 0x0018A151
		[CompilerGenerated]
		internal virtual oo0_o0o_0o__ <<EMPTY_NAME>>()
		{
			return this.o0.0O__o.;
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x0018BF59 File Offset: 0x0018A159
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(oo0_o0o_0o__ A_0)
		{
			this.o0.0O__o. = A_0;
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x0018BF62 File Offset: 0x0018A162
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.O_.___oO00oO.;
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x0018BF6A File Offset: 0x0018A16A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.O_.___oO00oO. = A_0;
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x0018BF73 File Offset: 0x0018A173
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.Oo.0o_0.;
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x0018BF7B File Offset: 0x0018A17B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.Oo.0o_0. = A_0;
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x0018BF84 File Offset: 0x0018A184
		[CompilerGenerated]
		internal virtual oo0_o0o_0o__ <<EMPTY_NAME>>()
		{
			return this.O.OOO0_o0OO0_o.;
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x0018BF8C File Offset: 0x0018A18C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(oo0_o0o_0o__ A_0)
		{
			this.O.OOO0_o0OO0_o. = A_0;
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x0018BF95 File Offset: 0x0018A195
		[CompilerGenerated]
		internal virtual oo0_o0o_0o__ <<EMPTY_NAME>>()
		{
			return this.oOo.OOo.;
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x0018BF9D File Offset: 0x0018A19D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(oo0_o0o_0o__ A_0)
		{
			this.oOo.OOo. = A_0;
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x0018BFA6 File Offset: 0x0018A1A6
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO_O00._o.;
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x0018BFB0 File Offset: 0x0018A1B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O__o0Oo_o.0.);
			C1Button c1Button = this.oO_O00._o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO_O00._o. = A_0;
			c1Button = this.oO_O00._o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x0018BFF3 File Offset: 0x0018A1F3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_0o._O_O.;
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x0018BFFC File Offset: 0x0018A1FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_O0o_Oo_.o_.);
			C1Button c1Button = this.o_0o._O_O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_0o._O_O. = A_0;
			c1Button = this.o_0o._O_O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x0018C03F File Offset: 0x0018A23F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOO0_.o0o_OO0.;
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x0018C048 File Offset: 0x0018A248
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_0_0._O.);
			C1Button c1Button = this.oOO0_.o0o_OO0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOO0_.o0o_OO0. = A_0;
			c1Button = this.oOO0_.o0o_OO0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x0018C08C File Offset: 0x0018A28C
		public o\u3000\u3002\u3002\u30000\u3000()
		{
			base.Load += this.O._OO_O0o0_.;
			base.FormClosed += this.o__.ooooo__0o.;
			this.O_O0._0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
			{
				this.Oo_0oO_.oO.()
			});
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
			{
				this.O_O0._0.()
			});
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x0018C11A File Offset: 0x0018A31A
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OOo__0.oOOoo.().ShowDialog() == DialogResult.OK)
			{
				this.oO0OO__.o_.().Value = this.OOo__0.oOOoo.().SelectedPath;
				this.oO0OO__.o_.();
				this.ooOOO0OO0o.O.();
			}
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x0018C14C File Offset: 0x0018A34C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OOo__0.oOOoo.().RootFolder = Environment.SpecialFolder.MyComputer;
			this.oO0OO__.o_.().Value = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Foxtable项目";
			this.oO0OO__.o_.();
			this.ooOOO0OO0o.O.();
			this.OOo__0.oOOoo.().O_oo.0oOO. = true;
			this.OOo__0.oOOoo.().o00_0O0.0O_.();
			Oo00.o_o_oo.0o.(this.OOo__0.oOOoo.().O_oo.0oOO.);
			this.O_O0._0.().O_oo.0oOO. = true;
			this.O_O0._0.().o00_0O0.0O_.();
			Oo00.o_o_oo.0o.(this.O_O0._0.().O_oo.0oOO.);
			this.ooOOO0OO0o.O.().O_oo.0oOO. = true;
			this.ooOOO0OO0o.O.().o00_0O0.0O_.();
			Oo00.o_o_oo.0o.(this.ooOOO0OO0o.O.().O_oo.0oOO.);
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x0018C204 File Offset: 0x0018A404
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.oO0OO__.o_.().Text, "", true) == 0 | Operators.CompareString(this.O_O0._0.().Text, "", true) == 0)
			{
				MessageBox.Show("请输入新的项目名称和位置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (c.OOOOO.o.().FileSystem.DirectoryExists(this.oO0OO__.o_.().Text + this.O_O0._0.().Text))
			{
				if (MessageBox.Show("文件夹 " + this.oO0OO__.o_.().Text + this.O_O0._0.().Text + " 已经存在，是否覆盖？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					base.DialogResult = DialogResult.OK;
					return;
				}
			}
			else
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x0018C2CC File Offset: 0x0018A4CC
		private void <<EMPTY_NAME>>()
		{
			int num = 0;
			try
			{
				foreach (string text in c.OOOOO.o.().FileSystem.GetDirectories(this.oO0OO__.o_.().Text, SearchOption.SearchTopLevelOnly, new string[]
				{
					"管理项目*"
				}))
				{
					if (Versioned.IsNumeric(text.Substring(text.LastIndexOf("\\") + "管理项目".Length + 1)))
					{
						num = Convert.ToInt32(Math.Max((double)num, Conversion.Val(text.Substring(text.LastIndexOf("\\") + "管理项目".Length + 1))));
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
			this.Oo00oO0_O0.O0. = "管理项目" + Conversions.ToString(num + 1);
			this.O_O0._0.().Text = this.Oo00oO0_O0.O0.;
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x0018C3B8 File Offset: 0x0018A5B8
		public void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.oO0OO__.o_.().Text, "", true) == 0 | Operators.CompareString(this.O_O0._0.().Text, "", true) == 0)
			{
				this.O_0.OOO0OoO_0.().Text = "";
				return;
			}
			if (!this.oO0OO__.o_.().Text.EndsWith("\\"))
			{
				this.oO0OO__.o_.().Value = this.oO0OO__.o_.().Text + "\\";
			}
			this.O_0.OOO0OoO_0.().Text = string.Concat(new string[]
			{
				"将创建: ",
				this.oO0OO__.o_.().Text,
				this.O_O0._0.().Text,
				"\\",
				this.O_O0._0.().Text,
				ooO0__OO.oo.Ooo_00.()
			});
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x0018C49A File Offset: 0x0018A69A
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			if (A_1.KeyChar == '.')
			{
				A_1.Handled = true;
			}
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x0018C4AD File Offset: 0x0018A6AD
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.ooOOO0OO0o.O.();
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x0018C4B8 File Offset: 0x0018A6B8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u = new o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000("", "");
			o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.o000_oO000o.O. = this.OOo__0.oOOoo.();
			if (o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() == DialogResult.OK)
			{
				string text = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.();
				C1DockingTabPage c1DockingTabPage = new C1DockingTabPage();
				oo0_o0o_0o__ oo0_o0o_0o__ = new oo0_o0o_0o__();
				oo0_o0o_0o__.O_oo.0oOO. = true;
				oo0_o0o_0o__.O_oo.0oOO. = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.();
				c1DockingTabPage.Controls.Add(oo0_o0o_0o__);
				c1DockingTabPage.Controls[0].Dock = DockStyle.Fill;
				c1DockingTabPage.Text = text;
				Main.OO_O.o..OOoo___.0.(oo0_o0o_0o__.Controls, "(default)");
				this.O_O0._0.().TabPages.Add(c1DockingTabPage);
				oo0_o0o_0o__.o00_0O0.0O_.();
				Oo00.o_o_oo.0o.(oo0_o0o_0o__.O_oo.0oOO.);
				this.O_O0._0.().SelectedIndex = this.O_O0._0.().TabPages.Count - 1;
			}
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x0018C594 File Offset: 0x0018A794
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O_O0._0.().TabPages.Count == 1)
			{
				MessageBox.Show("至少要保留一个表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			this.O_O0._0.().TabPages.Remove(this.O_O0._0.().SelectedTab);
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x0018C5E4 File Offset: 0x0018A7E4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u = new o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(this.O_O0._0.().SelectedTab.Text, ((oo0_o0o_0o__)this.O_O0._0.().SelectedTab.Controls[0]).O_oo.0oOO.);
			o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.o000_oO000o.O. = this.OOo__0.oOOoo.();
			if (o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() == DialogResult.OK)
			{
				this.O_O0._0.().SelectedTab.Text = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.();
				((oo0_o0o_0o__)this.O_O0._0.().SelectedTab.Controls[0]).O_oo.0oOO. = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.();
			}
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x0018C678 File Offset: 0x0018A878
		internal List<string> <<EMPTY_NAME>>()
		{
			List<string> list = new List<string>();
			int num = this.O_O0._0.().TabCount - 1;
			for (int i = 0; i <= num; i++)
			{
				list.Add(this.O_O0._0.().TabPages[i].Text);
			}
			return list;
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x0018C6C2 File Offset: 0x0018A8C2
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			((oo0_o0o_0o__)this.O_O0._0.().SelectedTab.Controls[0]).OoO_Oo._o.();
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x0018C6E4 File Offset: 0x0018A8E4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			((oo0_o0o_0o__)this.O_O0._0.().SelectedTab.Controls[0]).O_._O0Oo_o.();
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x0018C706 File Offset: 0x0018A906
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			((oo0_o0o_0o__)this.O_O0._0.().SelectedTab.Controls[0]).O0o.OOoo.();
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x0018C728 File Offset: 0x0018A928
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040016B0 RID: 5808
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040016B1 RID: 5809
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040016B2 RID: 5810
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040016B3 RID: 5811
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040016B4 RID: 5812
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040016B5 RID: 5813
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040016B6 RID: 5814
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040016B7 RID: 5815
		[CompilerGenerated]
		private FolderBrowserDialog <<EMPTY_NAME>>;

		// Token: 0x040016B8 RID: 5816
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040016B9 RID: 5817
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040016BA RID: 5818
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040016BB RID: 5819
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x040016BC RID: 5820
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040016BD RID: 5821
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040016BE RID: 5822
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040016BF RID: 5823
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040016C0 RID: 5824
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040016C1 RID: 5825
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x040016C2 RID: 5826
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040016C3 RID: 5827
		[CompilerGenerated]
		private oo0_o0o_0o__ <<EMPTY_NAME>>;

		// Token: 0x040016C4 RID: 5828
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040016C5 RID: 5829
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040016C6 RID: 5830
		[CompilerGenerated]
		private oo0_o0o_0o__ <<EMPTY_NAME>>;

		// Token: 0x040016C7 RID: 5831
		[CompilerGenerated]
		private oo0_o0o_0o__ <<EMPTY_NAME>>;

		// Token: 0x040016C8 RID: 5832
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040016C9 RID: 5833
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040016CA RID: 5834
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040016CB RID: 5835
		private string <<EMPTY_NAME>>;

		// Token: 0x040016CC RID: 5836
		private const string <<EMPTY_NAME>> = "管理项目";
	}
}
