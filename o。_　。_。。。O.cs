using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020004CA RID: 1226
	[DesignerGenerated]
	internal partial class o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000 : Form
	{
		// Token: 0x060050A1 RID: 20641 RVA: 0x0023A434 File Offset: 0x00238634
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O.o0OO. != null)
				{
					this.O.o0OO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x0023A474 File Offset: 0x00238674
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O.o0OO. = new Container();
			this.oO.o0.(new SplitContainer());
			this.O_0__o_._oo0__.(new C1Button());
			this.oO_oo0._.(new C1Button());
			this.OO_O.o00.(new C1Button());
			this.o_00O0.oo0_.(new C1Button());
			this.Ooo0oO._00OOo.(new C1Button());
			this.O0OOOo.__oOOO.(new C1Button());
			this.OOoo0o.00.(new ListBox());
			this.oO_oo0._.(new C1DockingTab());
			this.O._0000Oo_O.(new C1DockingTabPage());
			this.OOoo0o.00.(new PropertyGrid());
			this.oO_oo0._.(new C1DockingTabPage());
			this.OOoo0o.00.(new SplitContainer());
			this.oO.o0.(new PropertyGrid());
			this.OOoo0o.00.(new RichTextBox());
			this.Ooo0.ooOOO0_.(new C1Button());
			this.OOoo0o.00.(new ContextMenuStrip(this.O.o0OO.));
			this.O0O0_0.__0.(new C1Button());
			this.oO0Oo.o.(new C1Button());
			this.oO.o0.(new ContextMenuStrip(this.O.o0OO.));
			this.oO.0OOo.(new C1Button());
			this.o_oo_.O.().Panel1.SuspendLayout();
			this.o_oo_.O.().Panel2.SuspendLayout();
			this.o_oo_.O.().SuspendLayout();
			((ISupportInitialize)this.o_oo_.O.()).BeginInit();
			this.o_oo_.O.().SuspendLayout();
			this.O.oooo0.().SuspendLayout();
			this.o_oo_.O.().SuspendLayout();
			this.o_00O0.oo0_.().Panel1.SuspendLayout();
			this.o_00O0.oo0_.().Panel2.SuspendLayout();
			this.o_00O0.oo0_.().SuspendLayout();
			base.SuspendLayout();
			this.o_oo_.O.().Location = new Point(12, 12);
			this.o_oo_.O.().Name = "SplitContainer1";
			this.o_oo_.O.().Panel1.Controls.Add(this.O00Oo.OO.());
			this.o_oo_.O.().Panel1.Controls.Add(this.O_o._O_OOo.());
			this.o_oo_.O.().Panel1.Controls.Add(this.OO_.__.());
			this.o_oo_.O.().Panel1.Controls.Add(this.O.O0O0oO.());
			this.o_oo_.O.().Panel1.Controls.Add(this.O__.__OOo.());
			this.o_oo_.O.().Panel1.Controls.Add(this.O00O.0_o_Oo.());
			this.o_oo_.O.().Panel1.Controls.Add(this.o_oo_.O.());
			this.o_oo_.O.().Panel2.Controls.Add(this.o_oo_.O.());
			this.o_oo_.O.().Size = new Size(564, 351);
			this.o_oo_.O.().SplitterDistance = 220;
			this.o_oo_.O.().TabIndex = 0;
			this.O00Oo.OO.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O00Oo.OO.().Location = new Point(171, 138);
			this.O00Oo.OO.().Name = "btnCopy";
			this.O00Oo.OO.().Size = new Size(44, 23);
			this.O00Oo.OO.().TabIndex = 6;
			this.O00Oo.OO.().Text = "复制";
			this.O00Oo.OO.().UseVisualStyleBackColor = true;
			this.O_o._O_OOo.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O_o._O_OOo.().Location = new Point(171, 110);
			this.O_o._O_OOo.().Name = "btnMove";
			this.O_o._O_OOo.().Size = new Size(44, 23);
			this.O_o._O_OOo.().TabIndex = 5;
			this.O_o._O_OOo.().Text = "转移";
			this.O_o._O_OOo.().UseVisualStyleBackColor = true;
			this.OO_.__.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.OO_.__.().Location = new Point(171, 29);
			this.OO_.__.().Name = "btnDelete";
			this.OO_.__.().Size = new Size(44, 22);
			this.OO_.__.().TabIndex = 4;
			this.OO_.__.().Text = "删除";
			this.OO_.__.().UseVisualStyleBackColor = true;
			this.O.O0O0oO.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O.O0O0oO.().Location = new Point(171, 0);
			this.O.O0O0oO.().Name = "btnAddItem";
			this.O.O0O0oO.().Size = new Size(44, 24);
			this.O.O0O0oO.().TabIndex = 3;
			this.O.O0O0oO.().Text = "增加";
			this.O.O0O0oO.().UseVisualStyleBackColor = true;
			this.O__.__OOo.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O__.__OOo.().Location = new Point(171, 83);
			this.O__.__OOo.().Name = "btnMoveDown";
			this.O__.__OOo.().Size = new Size(44, 22);
			this.O__.__OOo.().TabIndex = 2;
			this.O__.__OOo.().UseVisualStyleBackColor = true;
			this.O00O.0_o_Oo.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O00O.0_o_Oo.().Location = new Point(171, 56);
			this.O00O.0_o_Oo.().Name = "btnMoveUp";
			this.O00O.0_o_Oo.().Size = new Size(44, 22);
			this.O00O.0_o_Oo.().TabIndex = 1;
			this.O00O.0_o_Oo.().UseVisualStyleBackColor = true;
			this.o_oo_.O.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.o_oo_.O.().FormattingEnabled = true;
			this.o_oo_.O.().IntegralHeight = false;
			this.o_oo_.O.().ItemHeight = 12;
			this.o_oo_.O.().Location = new Point(0, 0);
			this.o_oo_.O.().Name = "ItemList";
			this.o_oo_.O.().Size = new Size(169, 351);
			this.o_oo_.O.().TabIndex = 0;
			this.o_oo_.O.().BorderStyle = BorderStyle.None;
			this.o_oo_.O.().Controls.Add(this.O.oooo0.());
			this.o_oo_.O.().Controls.Add(this.o_oo_.O.());
			this.o_oo_.O.().Dock = DockStyle.Fill;
			this.o_oo_.O.().Location = new Point(0, 0);
			this.o_oo_.O.().Name = "C1DockingTab1";
			this.o_oo_.O.().Size = new Size(340, 351);
			this.o_oo_.O.().TabIndex = 0;
			this.o_oo_.O.().TabsSpacing = 0;
			this.o_oo_.O.().TabStyle = TabStyleEnum.WindowsXP;
			this.o_oo_.O.().VisualStyle = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.o_oo_.O.().VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.O.oooo0.().Controls.Add(this.o_oo_.O.());
			this.O.oooo0.().Location = new Point(0, 25);
			this.O.oooo0.().Name = "C1DockingTabPage1";
			this.O.oooo0.().Size = new Size(340, 326);
			this.O.oooo0.().TabIndex = 0;
			this.O.oooo0.().Text = "属性";
			this.o_oo_.O.().Dock = DockStyle.Fill;
			this.o_oo_.O.().Location = new Point(0, 0);
			this.o_oo_.O.().Name = "PropertyGrid1";
			this.o_oo_.O.().Size = new Size(340, 326);
			this.o_oo_.O.().TabIndex = 0;
			this.o_oo_.O.().ToolbarVisible = false;
			this.o_oo_.O.().Controls.Add(this.o_00O0.oo0_.());
			this.o_oo_.O.().Location = new Point(0, 25);
			this.o_oo_.O.().Name = "C1DockingTabPage2";
			this.o_oo_.O.().Size = new Size(340, 326);
			this.o_oo_.O.().TabIndex = 1;
			this.o_oo_.O.().Text = "事件";
			this.o_00O0.oo0_.().Dock = DockStyle.Fill;
			this.o_00O0.oo0_.().Location = new Point(0, 0);
			this.o_00O0.oo0_.().Name = "SplitContainer2";
			this.o_00O0.oo0_.().Orientation = Orientation.Horizontal;
			this.o_00O0.oo0_.().Panel1.Controls.Add(this.O.oooo0.());
			this.o_00O0.oo0_.().Panel2.Controls.Add(this.ooO0.0o__0o.());
			this.o_00O0.oo0_.().Size = new Size(340, 326);
			this.o_00O0.oo0_.().SplitterDistance = 209;
			this.o_00O0.oo0_.().TabIndex = 1;
			this.O.oooo0.().Dock = DockStyle.Fill;
			this.O.oooo0.().Location = new Point(0, 0);
			this.O.oooo0.().Name = "PropertyGrid2";
			this.O.oooo0.().Size = new Size(340, 209);
			this.O.oooo0.().TabIndex = 1;
			this.O.oooo0.().ToolbarVisible = false;
			this.ooO0.0o__0o.().BorderStyle = BorderStyle.FixedSingle;
			this.ooO0.0o__0o.().Dock = DockStyle.Fill;
			this.ooO0.0o__0o.().Location = new Point(0, 0);
			this.ooO0.0o__0o.().Name = "txtCode";
			this.ooO0.0o__0o.().ReadOnly = true;
			this.ooO0.0o__0o.().Size = new Size(340, 113);
			this.ooO0.0o__0o.().TabIndex = 0;
			this.ooO0.0o__0o.().Text = "";
			this.ooO0.0o__0o.().WordWrap = false;
			this.O_o.0o_00oO.().Location = new Point(12, 383);
			this.O_o.0o_00oO.().Name = "btnPreview";
			this.O_o.0o_00oO.().Size = new Size(75, 23);
			this.O_o.0o_00oO.().TabIndex = 3;
			this.O_o.0o_00oO.().Text = "预览";
			this.O_o.0o_00oO.().UseVisualStyleBackColor = true;
			this.o_oo_.O.().Name = "ContextMenuStrip1";
			this.o_oo_.O.().Size = new Size(61, 4);
			this.o._Oo_0_o___.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.o._Oo_0_o___.().Location = new Point(501, 383);
			this.o._Oo_0_o___.().Name = "btnClose";
			this.o._Oo_0_o___.().Size = new Size(75, 23);
			this.o._Oo_0_o___.().TabIndex = 17;
			this.o._Oo_0_o___.().Tag = "pF5mMoKwO0QA4YUf9VDPmQ==";
			this.o._Oo_0_o___.().Text = "取消";
			this.o._Oo_0_o___.().UseVisualStyleBackColor = true;
			this.oo__o0o0O._Oo.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.oo__o0o0O._Oo.().Location = new Point(420, 383);
			this.oo__o0o0O._Oo.().Name = "btnOK";
			this.oo__o0o0O._Oo.().Size = new Size(75, 23);
			this.oo__o0o0O._Oo.().TabIndex = 16;
			this.oo__o0o0O._Oo.().Text = "确定";
			this.oo__o0o0O._Oo.().UseVisualStyleBackColor = true;
			this.O.oooo0.().Name = "ContextMenuStrip2";
			this.O.oooo0.().Size = new Size(61, 4);
			this.Oo_0.0O_oooO0o.().Location = new Point(94, 383);
			this.Oo_0.0O_oooO0o.().Name = "btnApply";
			this.Oo_0.0O_oooO0o.().Size = new Size(75, 23);
			this.Oo_0.0O_oooO0o.().TabIndex = 18;
			this.Oo_0.0O_oooO0o.().Text = "应用";
			this.Oo_0.0O_oooO0o.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(588, 418);
			base.Controls.Add(this.Oo_0.0O_oooO0o.());
			base.Controls.Add(this.o._Oo_0_o___.());
			base.Controls.Add(this.oo__o0o0O._Oo.());
			base.Controls.Add(this.o_oo_.O.());
			base.Controls.Add(this.O_o.0o_00oO.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.0_O.0O.0.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.Tag = "fUHg6lDLPWmmLJJ7+Cy6fsEib2L104N4STXJohiFow0SHiC7Tlg7tA==";
			this.Text = "RibbonMenu项目设计器";
			this.o_oo_.O.().Panel1.ResumeLayout(false);
			this.o_oo_.O.().Panel2.ResumeLayout(false);
			this.o_oo_.O.().ResumeLayout(false);
			((ISupportInitialize)this.o_oo_.O.()).EndInit();
			this.o_oo_.O.().ResumeLayout(false);
			this.O.oooo0.().ResumeLayout(false);
			this.o_oo_.O.().ResumeLayout(false);
			this.o_00O0.oo0_.().Panel1.ResumeLayout(false);
			this.o_00O0.oo0_.().Panel2.ResumeLayout(false);
			this.o_00O0.oo0_.().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x0023B11D File Offset: 0x0023931D
		[CompilerGenerated]
		internal virtual SplitContainer <<EMPTY_NAME>>()
		{
			return this.O.o0OO.;
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x0023B125 File Offset: 0x00239325
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SplitContainer A_0)
		{
			this.O.o0OO. = A_0;
		}

		// Token: 0x060050A5 RID: 20645 RVA: 0x0023B12E File Offset: 0x0023932E
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.o0.o__.;
		}

		// Token: 0x060050A6 RID: 20646 RVA: 0x0023B136 File Offset: 0x00239336
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.o0.o__. = A_0;
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x0023B13F File Offset: 0x0023933F
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.o0.o__.;
		}

		// Token: 0x060050A8 RID: 20648 RVA: 0x0023B147 File Offset: 0x00239347
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			this.o0.o__. = A_0;
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x0023B150 File Offset: 0x00239350
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.o0.o__.;
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x0023B158 File Offset: 0x00239358
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.o0.o__. = A_0;
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x0023B161 File Offset: 0x00239361
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.o0.o__.;
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x0023B16C File Offset: 0x0023936C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyValueChangedEventHandler value = new PropertyValueChangedEventHandler(this.ooO0.0o__0o.);
			PropertyGrid propertyGrid = this.o0.o__.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyValueChanged -= value;
			}
			this.o0.o__. = A_0;
			propertyGrid = this.o0.o__.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyValueChanged += value;
			}
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x0023B1AF File Offset: 0x002393AF
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.o_0._oo.;
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x0023B1B7 File Offset: 0x002393B7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.o_0._oo. = A_0;
		}

		// Token: 0x060050AF RID: 20655 RVA: 0x0023B1C0 File Offset: 0x002393C0
		[CompilerGenerated]
		internal virtual SplitContainer <<EMPTY_NAME>>()
		{
			return this.oO.o00o00Oo_O.;
		}

		// Token: 0x060050B0 RID: 20656 RVA: 0x0023B1C8 File Offset: 0x002393C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SplitContainer A_0)
		{
			this.oO.o00o00Oo_O. = A_0;
		}

		// Token: 0x060050B1 RID: 20657 RVA: 0x0023B1D1 File Offset: 0x002393D1
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.o_0._oo.;
		}

		// Token: 0x060050B2 RID: 20658 RVA: 0x0023B1DC File Offset: 0x002393DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyValueChangedEventHandler value = new PropertyValueChangedEventHandler(this.ooO0.0o__0o.);
			SelectedGridItemChangedEventHandler value2 = new SelectedGridItemChangedEventHandler(this.ooO0.0o__0o.);
			PropertyGrid propertyGrid = this.o_0._oo.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyValueChanged -= value;
				propertyGrid.SelectedGridItemChanged -= value2;
			}
			this.o_0._oo. = A_0;
			propertyGrid = this.o_0._oo.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyValueChanged += value;
				propertyGrid.SelectedGridItemChanged += value2;
			}
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x0023B23A File Offset: 0x0023943A
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0.o__.;
		}

		// Token: 0x060050B4 RID: 20660 RVA: 0x0023B244 File Offset: 0x00239444
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo._o__o_0ooo.);
			C1Button c1Button = this.o0.o__.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0.o__. = A_0;
			c1Button = this.o0.o__.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x0023B287 File Offset: 0x00239487
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_._00_o.;
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x0023B290 File Offset: 0x00239490
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOOo0o_oo.oo_o.);
			C1Button c1Button = this.o_._00_o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_._00_o. = A_0;
			c1Button = this.o_._00_o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x0023B2D3 File Offset: 0x002394D3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O__o__O_.0_0o.;
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x0023B2DC File Offset: 0x002394DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.00__.);
			C1Button o__o__O_.0_0o. = this.O__o__O_.0_0o.;
			if (o__o__O_.0_0o. != null)
			{
				o__o__O_.0_0o..Click -= value;
			}
			this.O__o__O_.0_0o. = A_0;
			o__o__O_.0_0o. = this.O__o__O_.0_0o.;
			if (o__o__O_.0_0o. != null)
			{
				o__o__O_.0_0o..Click += value;
			}
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x0023B31F File Offset: 0x0023951F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOoOooo.__.;
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x0023B328 File Offset: 0x00239528
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_Oo.O.);
			C1Button oooOooo.__. = this.OOoOooo.__.;
			if (oooOooo.__. != null)
			{
				oooOooo.__..Click -= value;
			}
			this.OOoOooo.__. = A_0;
			oooOooo.__. = this.OOoOooo.__.;
			if (oooOooo.__. != null)
			{
				oooOooo.__..Click += value;
			}
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x0023B36B File Offset: 0x0023956B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO0_OO0.0_O_o.;
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x0023B374 File Offset: 0x00239574
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_o.ooo0.);
			C1Button c1Button = this.oO0_OO0.0_O_o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO0_OO0.0_O_o. = A_0;
			c1Button = this.oO0_OO0.0_O_o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060050BD RID: 20669 RVA: 0x0023B3B7 File Offset: 0x002395B7
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.o0.o__.;
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x0023B3C0 File Offset: 0x002395C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			ToolStripItemClickedEventHandler value = new ToolStripItemClickedEventHandler(this.Oo.ooO.);
			ContextMenuStrip contextMenuStrip = this.o0.o__.;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.ItemClicked -= value;
			}
			this.o0.o__. = A_0;
			contextMenuStrip = this.o0.o__.;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.ItemClicked += value;
			}
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x0023B403 File Offset: 0x00239603
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.O__O00O00.;
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x0023B40C File Offset: 0x0023960C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO.oOoo.);
			C1Button o.O__O00O00. = this.O.O__O00O00.;
			if (o.O__O00O00. != null)
			{
				o.O__O00O00..Click -= value;
			}
			this.O.O__O00O00. = A_0;
			o.O__O00O00. = this.O.O__O00O00.;
			if (o.O__O00O00. != null)
			{
				o.O__O00O00..Click += value;
			}
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x0023B44F File Offset: 0x0023964F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0o0_.o__O_.;
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x0023B458 File Offset: 0x00239658
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0OOO0_.__.);
			C1Button c1Button = this.o0o0_.o__O_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0o0_.o__O_. = A_0;
			c1Button = this.o0o0_.o__O_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x0023B49B File Offset: 0x0023969B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO_.0oo__oo.;
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x0023B4A4 File Offset: 0x002396A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_Oo.0___o.);
			C1Button c1Button = this.oO_.0oo__oo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO_.0oo__oo. = A_0;
			c1Button = this.oO_.0oo__oo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x0023B4E7 File Offset: 0x002396E7
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.o_0._oo.;
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x0023B4F0 File Offset: 0x002396F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			ToolStripItemClickedEventHandler value = new ToolStripItemClickedEventHandler(this.OOoO00._o0O_0O.);
			ContextMenuStrip contextMenuStrip = this.o_0._oo.;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.ItemClicked -= value;
			}
			this.o_0._oo. = A_0;
			contextMenuStrip = this.o_0._oo.;
			if (contextMenuStrip != null)
			{
				contextMenuStrip.ItemClicked += value;
			}
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x0023B533 File Offset: 0x00239733
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooOO.oo_.;
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x0023B53C File Offset: 0x0023973C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.OoOOo0_0.);
			C1Button c1Button = this.ooOO.oo_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooOO.oo_. = A_0;
			c1Button = this.ooOO.oo_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x0023B57F File Offset: 0x0023977F
		[CompilerGenerated]
		internal virtual RichTextBox <<EMPTY_NAME>>()
		{
			return this.O.o0OO.;
		}

		// Token: 0x060050CA RID: 20682 RVA: 0x0023B587 File Offset: 0x00239787
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RichTextBox A_0)
		{
			this.O.o0OO. = A_0;
		}

		// Token: 0x060050CB RID: 20683 RVA: 0x0023B590 File Offset: 0x00239790
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.0__0_O.;
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x0023B598 File Offset: 0x00239798
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo0_O000o._0.);
			C1Button c1Button = this.o.0__0_O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.0__0_O. = A_0;
			c1Button = this.o.0__0_O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x0023B5DB File Offset: 0x002397DB
		[CompilerGenerated]
		private virtual CurrencyManager <<EMPTY_NAME>>()
		{
			return this.o0.o__.;
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x0023B5E4 File Offset: 0x002397E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(CurrencyManager A_0)
		{
			EventHandler value = new EventHandler(this.oO.oO00o_oo0.);
			CurrencyManager currencyManager = this.o0.o__.;
			if (currencyManager != null)
			{
				currencyManager.CurrentChanged -= value;
			}
			this.o0.o__. = A_0;
			currencyManager = this.o0.o__.;
			if (currencyManager != null)
			{
				currencyManager.CurrentChanged += value;
			}
		}

		// Token: 0x060050CF RID: 20687 RVA: 0x0023B628 File Offset: 0x00239828
		public o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000(DataRow A_0, RibbonPaneEnum A_1, Form A_2)
		{
			base.Activated += this.o0_.__o00.;
			base.FormClosed += this.OOoO00._o0O_0O.;
			base.FormClosing += this.OOoO00._o0O_0O.;
			base.Load += this.Oo0O0_.O.;
			this.O.o0OO. = new DataSet();
			this.ooO.Oo_. = RibbonPaneEnum.Left;
			int num2;
			int num4;
			object obj;
			try
			{
				IL_60:
				int num = 1;
				this.O0oOO._.();
				IL_68:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_7F:
				num = 3;
				Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
				{
					this.o_oo_.O.()
				});
				IL_9F:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_A6:
				num = 5;
				this.oO.o00o00Oo_O. = A_2;
				IL_AF:
				num = 6;
				this.ooO.Oo_. = A_0;
				IL_B8:
				num = 7;
				this.ooO.Oo_. = A_1;
				IL_C1:
				num = 8;
				if (A_0 != null)
				{
					goto IL_195;
				}
				IL_C9:
				num = 9;
				this.O.o0OO. = o_\u3002\u3002\u3000\u3000\u3002.oOoo_0O.oo00oO..oOoo_0O.oo00oO..DataTable.DefaultView.ToTable();
				IL_EB:
				num = 10;
				if (A_1 != RibbonPaneEnum.Left)
				{
					goto IL_11E;
				}
				IL_F1:
				num = 11;
				this.O.o0OO. = new DataView(this.O.o0OO., "[Type] = " + Conversions.ToString(5), "Index", DataViewRowState.CurrentRows);
				goto IL_189;
				IL_11E:
				num = 13;
				if (A_1 != RibbonPaneEnum.Right)
				{
					goto IL_156;
				}
				IL_125:
				num = 14;
				this.O.o0OO. = new DataView(this.O.o0OO., "[Type] = " + Conversions.ToString(128), "Index", DataViewRowState.CurrentRows);
				goto IL_189;
				IL_156:
				num = 16;
				if (A_1 != RibbonPaneEnum.Bottom)
				{
					goto IL_189;
				}
				IL_15D:
				num = 17;
				this.O.o0OO. = new DataView(this.O.o0OO., "[Type] = " + Conversions.ToString(37), "Index", DataViewRowState.CurrentRows);
				IL_189:
				num = 18;
				this.ooO.Oo_. = RibbonItemTypeEnum.Ribbon;
				goto IL_20C;
				IL_195:
				num = 20;
				this.O.o0OO. = A_0.Table.DefaultView.ToTable();
				IL_1AE:
				num = 21;
				this.O.o0OO. = new DataView(this.O.o0OO., "[ParentKey] = '" + this.ooO.Oo_.["Key"].ToString() + "' And [Pane] = " + Conversions.ToString((int)A_1), "Index", DataViewRowState.CurrentRows);
				IL_1F3:
				num = 22;
				this.ooO.Oo_. = (RibbonItemTypeEnum)Conversions.ToInteger(A_0["Type"]);
				IL_20C:
				num = 23;
				Thread thread = new Thread(new ThreadStart(o0OoOOoOOo0.o_OOo_0.0O.));
				IL_221:
				num = 24;
				thread.Start();
				IL_22A:
				num = 25;
				this.O.o0OO..PrimaryKey = new DataColumn[]
				{
					this.O.o0OO..Columns["Key"]
				};
				IL_256:
				num = 26;
				this.O.o0OO..Tables.Add(this.O.o0OO.);
				IL_26F:
				num = 27;
				this.O.o0OO..Relations.Add("Ribbon", this.O.o0OO..Columns["Key"], this.O.o0OO..Columns["ParentKey"]);
				IL_2B2:
				num = 28;
				this.o_oo_.O.().DataSource = this.O.o0OO.;
				IL_2C6:
				num = 29;
				this.o_oo_.O.().DisplayMember = "Name";
				IL_2D9:
				num = 30;
				this.OOoo0o.00.((CurrencyManager)this.BindingContext[this.O.o0OO.]);
				IL_2F8:
				num = 31;
				this.O.o0OO..AcceptChanges();
				IL_306:
				num = 32;
				if (this.ooO.Oo_. != null)
				{
					goto IL_32F;
				}
				IL_311:
				num = 33;
				this.O_o._O_OOo.().Visible = false;
				IL_320:
				num = 34;
				this.O00Oo.OO.().Visible = false;
				IL_32F:
				goto IL_40D;
				IL_334:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_3CE:
				goto IL_402;
				IL_3D0:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_3E0:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3D0;
			}
			IL_402:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_40D:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x0023BA68 File Offset: 0x00239C68
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O.o0OO.)
			{
				this.O.o0OO. = false;
				if (this.ooO.Oo_. != null)
				{
					o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000 o_u3002__u3000_u3002__u3002_u3002_u3002O_u = (o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)this.ooO.Oo_.;
					o_u3002__u3000_u3002__u3002_u3002_u3002O_u.O.o0OO. = true;
					o_u3002__u3000_u3002__u3002_u3002_u3002O_u.ShowDialog();
				}
			}
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x0023BA9C File Offset: 0x00239C9C
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			int num2;
			int num5;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				if (this.oO.o00o00Oo_O.)
				{
					goto IL_1D1;
				}
				IL_0D:
				num = 3;
				Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
				IL_1F:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_26:
				num = 5;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					O00.oO_.0o_oo_0O_.(base.Tag.ToString(), "Ribbon", "Ribbon"),
					o0_O.O00__0OO_o.o0O.
				});
				IL_74:
				num = 6;
				if (dataRow == null)
				{
					goto IL_1D1;
				}
				IL_7C:
				num = 7;
				string s = dataRow["Config"].ToString();
				IL_90:
				num = 8;
				int num3;
				int.TryParse(s, out num3);
				IL_9C:
				num = 9;
				int length = MethodBase.GetCurrentMethod().Name.Length;
				IL_B0:
				num = 10;
				if (num3 <= length / 4 - 10)
				{
					goto IL_1D1;
				}
				IL_C1:
				num = 11;
				MethodInfo method = typeof(Table).GetMethod(O00.oO_.0o_oo_0O_.(this.o._Oo_0_o___.().Tag.ToString(), "Ribbon", "Ribbon"), BindingFlags.Static | BindingFlags.NonPublic);
				IL_F6:
				num = 12;
				if (Conversions.ToBoolean(method.Invoke(null, null)))
				{
					goto IL_1D1;
				}
				IL_10C:
				num = 13;
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._O.()];
				IL_125:
				num = 14;
				dataTable.DataSet.EnforceConstraints = false;
				IL_135:
				num = 15;
				DataRow[] array = dataTable.Select("[Type] = " + Conversions.ToString(229));
				IL_155:
				num = 16;
				foreach (DataRow dataRow2 in array)
				{
					IL_168:
					num = 17;
					dataRow2["Type"] = byte.MaxValue;
					IL_181:
					num = 18;
				}
				IL_192:
				num = 19;
				dataRow["Config"] = num3 - 5;
				IL_1A9:
				num = 20;
				Oo00.o0_o._O_.(dataTable, true);
				IL_1B4:
				num = 21;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				IL_1D1:
				goto IL_27B;
				IL_1D6:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_23C:
				goto IL_270;
				IL_23E:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_24E:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_23E;
			}
			IL_270:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_27B:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x0023BD48 File Offset: 0x00239F48
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			if (A_1.CloseReason == CloseReason.UserClosing && !this.oO.o00o00Oo_O.)
			{
				this.oo__o0o0O._Oo.().PerformClick();
			}
		}

		// Token: 0x060050D3 RID: 20691 RVA: 0x0023BD68 File Offset: 0x00239F68
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!this.oO.o00o00Oo_O.)
			{
				this.O00O.0_o_Oo.().Image = a.o0oO_0.O_oOO_.().ToBitmap();
				this.O__.__OOo.().Image = a.O0o00_____.oOO.().ToBitmap();
				this.oO.oO00o_oo0.(null, null);
				this.O.o0OO..AcceptChanges();
				return;
			}
			this.oO.o00o00Oo_O. = false;
		}

		// Token: 0x060050D4 RID: 20692 RVA: 0x0023BDC4 File Offset: 0x00239FC4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ContextMenuStrip contextMenuStrip = this.o_oo_.O.();
			contextMenuStrip.Items.Clear();
			RibbonItemTypeEnum ribbonItemTypeEnum = this.ooO.Oo_.;
			if (ribbonItemTypeEnum <= RibbonItemTypeEnum.Gallery)
			{
				switch (ribbonItemTypeEnum)
				{
				case RibbonItemTypeEnum.Ribbon:
					if (this.ooO.Oo_. == RibbonPaneEnum.Left)
					{
						this.OO00o0_.O0.(RibbonItemTypeEnum.Tab);
						return;
					}
					if (this.ooO.Oo_. == RibbonPaneEnum.Right)
					{
						this.OO00o0_.O0.(RibbonItemTypeEnum.ContextMenu);
						return;
					}
					if (this.ooO.Oo_. == RibbonPaneEnum.Bottom)
					{
						this.OO00o0_.O0.(RibbonItemTypeEnum.TopTab);
						return;
					}
					return;
				case RibbonItemTypeEnum.ApplicationMenu:
					switch (this.ooO.Oo_.)
					{
					case RibbonPaneEnum.Left:
						contextMenuStrip.Items.Add("标准按钮").Tag = RibbonItemTypeEnum.Button;
						contextMenuStrip.Items.Add("组合按钮").Tag = RibbonItemTypeEnum.SplitButton;
						contextMenuStrip.Items.Add("状态按钮").Tag = RibbonItemTypeEnum.ToggleButton;
						contextMenuStrip.Items.Add("菜单按钮").Tag = RibbonItemTypeEnum.MenuButton;
						contextMenuStrip.Items.Add("分割条").Tag = RibbonItemTypeEnum.Separator;
						contextMenuStrip.Items.Add("标签").Tag = RibbonItemTypeEnum.Label;
						this.Oo.ooO.();
						this.o_oo_.O.().Show(this.O.O0O0oO.(), new Point(0, this.O.O0O0oO.().Height));
						return;
					case RibbonPaneEnum.Right:
						contextMenuStrip.Items.Add("标准按钮").Tag = RibbonItemTypeEnum.Button;
						contextMenuStrip.Items.Add("标签").Tag = RibbonItemTypeEnum.Label;
						contextMenuStrip.Items.Add("分割条").Tag = RibbonItemTypeEnum.Separator;
						this.o_oo_.O.().Show(this.O.O0O0oO.(), new Point(0, this.O.O0O0oO.().Height));
						return;
					case RibbonPaneEnum.Bottom:
						this.OO00o0_.O0.(RibbonItemTypeEnum.Button);
						return;
					default:
						return;
					}
					break;
				case RibbonItemTypeEnum.QAT:
					contextMenuStrip.Items.Add("标准按钮").Tag = RibbonItemTypeEnum.Button;
					contextMenuStrip.Items.Add("组合按钮").Tag = RibbonItemTypeEnum.SplitButton;
					contextMenuStrip.Items.Add("状态按钮").Tag = RibbonItemTypeEnum.ToggleButton;
					contextMenuStrip.Items.Add("菜单按钮").Tag = RibbonItemTypeEnum.MenuButton;
					contextMenuStrip.Items.Add("分割条").Tag = RibbonItemTypeEnum.Separator;
					contextMenuStrip.Items.Add("组合框").Tag = RibbonItemTypeEnum.ComboBox;
					contextMenuStrip.Items.Add("颜色选取按钮").Tag = RibbonItemTypeEnum.ColorPicker;
					contextMenuStrip.Items.Add("字体选择框").Tag = RibbonItemTypeEnum.FontComboBox;
					contextMenuStrip.Items.Add("检查框").Tag = RibbonItemTypeEnum.CheckBox;
					this.Oo.ooO.();
					this.o_oo_.O.().Show(this.O.O0O0oO.(), new Point(0, this.O.O0O0oO.().Height));
					return;
				case RibbonItemTypeEnum.ConfigBar:
				case RibbonItemTypeEnum.Group:
				case RibbonItemTypeEnum.ToolBar:
					break;
				case RibbonItemTypeEnum.PaperList:
				case RibbonItemTypeEnum.WindowList:
				case RibbonItemTypeEnum.Button:
				case RibbonItemTypeEnum.CheckBox:
				case RibbonItemTypeEnum.ColorPicker:
				case RibbonItemTypeEnum.TextBox:
				case RibbonItemTypeEnum.Label:
				case RibbonItemTypeEnum.Separator:
					return;
				case RibbonItemTypeEnum.Tab:
					this.OO00o0_.O0.(RibbonItemTypeEnum.Group);
					return;
				case RibbonItemTypeEnum.ToggleGroup:
					this.OO00o0_.O0.(RibbonItemTypeEnum.ToggleButton);
					return;
				case RibbonItemTypeEnum.ComboBox:
				{
					RibbonPaneEnum ribbonPaneEnum = this.ooO.Oo_.;
					if (ribbonPaneEnum == RibbonPaneEnum.Left)
					{
						contextMenuStrip.Items.Add("标准按钮").Tag = RibbonItemTypeEnum.Button;
						contextMenuStrip.Items.Add("标签").Tag = RibbonItemTypeEnum.Label;
						this.o_oo_.O.().Show(this.O.O0O0oO.(), new Point(0, this.O.O0O0oO.().Height));
						return;
					}
					if (ribbonPaneEnum != RibbonPaneEnum.Right)
					{
						return;
					}
					contextMenuStrip.Items.Add("标准按钮").Tag = RibbonItemTypeEnum.Button;
					contextMenuStrip.Items.Add("组合按钮").Tag = RibbonItemTypeEnum.SplitButton;
					contextMenuStrip.Items.Add("状态按钮").Tag = RibbonItemTypeEnum.ToggleButton;
					contextMenuStrip.Items.Add("菜单按钮").Tag = RibbonItemTypeEnum.MenuButton;
					contextMenuStrip.Items.Add("分割条").Tag = RibbonItemTypeEnum.Separator;
					contextMenuStrip.Items.Add("标签").Tag = RibbonItemTypeEnum.Label;
					contextMenuStrip.Items.Add("组合框").Tag = RibbonItemTypeEnum.ComboBox;
					contextMenuStrip.Items.Add("颜色选取按钮").Tag = RibbonItemTypeEnum.ColorPicker;
					this.o_oo_.O.().Show(this.O.O0O0oO.(), new Point(0, this.O.O0O0oO.().Height));
					return;
				}
				case RibbonItemTypeEnum.FontComboBox:
					contextMenuStrip.Items.Add("标准按钮").Tag = RibbonItemTypeEnum.Button;
					contextMenuStrip.Items.Add("组合按钮").Tag = RibbonItemTypeEnum.SplitButton;
					contextMenuStrip.Items.Add("状态按钮").Tag = RibbonItemTypeEnum.ToggleButton;
					contextMenuStrip.Items.Add("菜单按钮").Tag = RibbonItemTypeEnum.MenuButton;
					contextMenuStrip.Items.Add("分割条").Tag = RibbonItemTypeEnum.Separator;
					contextMenuStrip.Items.Add("标签").Tag = RibbonItemTypeEnum.Label;
					contextMenuStrip.Items.Add("颜色选取按钮").Tag = RibbonItemTypeEnum.ColorPicker;
					this.o_oo_.O.().Show(this.O.O0O0oO.(), new Point(0, this.O.O0O0oO.().Height));
					return;
				case RibbonItemTypeEnum.MenuButton:
				case RibbonItemTypeEnum.SplitButton:
					contextMenuStrip.Items.Add("标准按钮").Tag = RibbonItemTypeEnum.Button;
					contextMenuStrip.Items.Add("组合按钮").Tag = RibbonItemTypeEnum.SplitButton;
					contextMenuStrip.Items.Add("状态按钮").Tag = RibbonItemTypeEnum.ToggleButton;
					contextMenuStrip.Items.Add("菜单按钮").Tag = RibbonItemTypeEnum.MenuButton;
					contextMenuStrip.Items.Add("Gallery").Tag = RibbonItemTypeEnum.Gallery;
					contextMenuStrip.Items.Add("分割条").Tag = RibbonItemTypeEnum.Separator;
					contextMenuStrip.Items.Add("标签").Tag = RibbonItemTypeEnum.Label;
					contextMenuStrip.Items.Add("组合框").Tag = RibbonItemTypeEnum.ComboBox;
					contextMenuStrip.Items.Add("颜色选取按钮").Tag = RibbonItemTypeEnum.ColorPicker;
					this.Oo.ooO.();
					this.o_oo_.O.().Show(this.O.O0O0oO.(), new Point(0, this.O.O0O0oO.().Height));
					return;
				default:
				{
					if (ribbonItemTypeEnum != RibbonItemTypeEnum.Gallery)
					{
						return;
					}
					RibbonPaneEnum ribbonPaneEnum2 = this.ooO.Oo_.;
					if (ribbonPaneEnum2 == RibbonPaneEnum.Left)
					{
						contextMenuStrip.Items.Add("标准按钮").Tag = RibbonItemTypeEnum.Button;
						contextMenuStrip.Items.Add("组合按钮").Tag = RibbonItemTypeEnum.SplitButton;
						contextMenuStrip.Items.Add("状态按钮").Tag = RibbonItemTypeEnum.ToggleButton;
						contextMenuStrip.Items.Add("菜单按钮").Tag = RibbonItemTypeEnum.MenuButton;
						contextMenuStrip.Items.Add("Gallery").Tag = RibbonItemTypeEnum.Gallery;
						contextMenuStrip.Items.Add("分割条").Tag = RibbonItemTypeEnum.Separator;
						contextMenuStrip.Items.Add("标签").Tag = RibbonItemTypeEnum.Label;
						contextMenuStrip.Items.Add("组合框").Tag = RibbonItemTypeEnum.ComboBox;
						contextMenuStrip.Items.Add("颜色选取按钮").Tag = RibbonItemTypeEnum.ColorPicker;
						this.Oo.ooO.();
						this.o_oo_.O.().Show(this.O.O0O0oO.(), new Point(0, this.O.O0O0oO.().Height));
						return;
					}
					if (ribbonPaneEnum2 == RibbonPaneEnum.Right)
					{
						this.OO00o0_.O0.(RibbonItemTypeEnum.GalleryItem);
						return;
					}
					return;
				}
				}
			}
			else if (ribbonItemTypeEnum - RibbonItemTypeEnum.TopToolBar > 1)
			{
				switch (ribbonItemTypeEnum)
				{
				case RibbonItemTypeEnum.ContextMenu:
				case RibbonItemTypeEnum.ContextCommandMenu:
					contextMenuStrip.Items.Add("标准项目").Tag = RibbonItemTypeEnum.ContextCommand;
					contextMenuStrip.Items.Add("子菜单").Tag = RibbonItemTypeEnum.ContextCommandMenu;
					this.o_oo_.O.().Show(this.O.O0O0oO.(), new Point(0, this.O.O0O0oO.().Height));
					return;
				case RibbonItemTypeEnum.ContextCommand:
					this.OO00o0_.O0.(RibbonItemTypeEnum.ContextCommand);
					return;
				default:
					return;
				}
			}
			contextMenuStrip.Items.Add("标准按钮").Tag = RibbonItemTypeEnum.Button;
			contextMenuStrip.Items.Add("组合按钮").Tag = RibbonItemTypeEnum.SplitButton;
			contextMenuStrip.Items.Add("状态按钮").Tag = RibbonItemTypeEnum.ToggleButton;
			contextMenuStrip.Items.Add("菜单按钮").Tag = RibbonItemTypeEnum.MenuButton;
			contextMenuStrip.Items.Add("分割条").Tag = RibbonItemTypeEnum.Separator;
			contextMenuStrip.Items.Add("标签").Tag = RibbonItemTypeEnum.Label;
			contextMenuStrip.Items.Add("组合框").Tag = RibbonItemTypeEnum.ComboBox;
			contextMenuStrip.Items.Add("检查框").Tag = RibbonItemTypeEnum.CheckBox;
			contextMenuStrip.Items.Add("文本框").Tag = RibbonItemTypeEnum.TextBox;
			contextMenuStrip.Items.Add("日期输入框").Tag = RibbonItemTypeEnum.DatePicker;
			contextMenuStrip.Items.Add("数值输入框").Tag = RibbonItemTypeEnum.NumericBox;
			contextMenuStrip.Items.Add("时间输入框").Tag = RibbonItemTypeEnum.TimePicker;
			contextMenuStrip.Items.Add("字体选择框").Tag = RibbonItemTypeEnum.FontComboBox;
			contextMenuStrip.Items.Add("颜色选取按钮").Tag = RibbonItemTypeEnum.ColorPicker;
			contextMenuStrip.Items.Add("滑动条").Tag = RibbonItemTypeEnum.TrackBar;
			contextMenuStrip.Items.Add("进度条").Tag = RibbonItemTypeEnum.ProgressBar;
			if (this.ooO.Oo_. == RibbonItemTypeEnum.Group)
			{
				contextMenuStrip.Items.Add("工具栏").Tag = RibbonItemTypeEnum.ToolBar;
			}
			contextMenuStrip.Items.Add("Gallery").Tag = RibbonItemTypeEnum.Gallery;
			this.Oo.ooO.();
			this.o_oo_.O.().Show(this.O.O0O0oO.(), new Point(0, this.O.O0O0oO.().Height));
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x0023C8F0 File Offset: 0x0023AAF0
		private void <<EMPTY_NAME>>()
		{
			ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem("自动列表");
			ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem("窗口列表");
			toolStripMenuItem2.Tag = RibbonItemTypeEnum.WindowList;
			toolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
			ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem("纸张类型");
			toolStripMenuItem3.Tag = RibbonItemTypeEnum.PaperList;
			toolStripMenuItem.DropDownItems.Add(toolStripMenuItem3);
			ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem("视图列表");
			toolStripMenuItem4.Tag = RibbonItemTypeEnum.TableViewList;
			toolStripMenuItem.DropDownItems.Add(toolStripMenuItem4);
			ToolStripMenuItem toolStripMenuItem5 = new ToolStripMenuItem("分组统计列历史表");
			toolStripMenuItem5.Tag = RibbonItemTypeEnum.GroupTableList;
			toolStripMenuItem.DropDownItems.Add(toolStripMenuItem5);
			ToolStripMenuItem toolStripMenuItem6 = new ToolStripMenuItem("交叉统计历史列表");
			toolStripMenuItem6.Tag = RibbonItemTypeEnum.CrossTableList;
			toolStripMenuItem.DropDownItems.Add(toolStripMenuItem6);
			ToolStripMenuItem toolStripMenuItem7 = new ToolStripMenuItem("汇总模式历史列表");
			toolStripMenuItem7.Tag = RibbonItemTypeEnum.SubtotalModeList;
			toolStripMenuItem.DropDownItems.Add(toolStripMenuItem7);
			ToolStripMenuItem toolStripMenuItem8 = new ToolStripMenuItem("Excel报表列表");
			toolStripMenuItem8.Tag = RibbonItemTypeEnum.ExcelReportList;
			toolStripMenuItem.DropDownItems.Add(toolStripMenuItem8);
			ToolStripMenuItem toolStripMenuItem9 = new ToolStripMenuItem("word文章列表");
			toolStripMenuItem9.Tag = RibbonItemTypeEnum.WordReportList;
			toolStripMenuItem.DropDownItems.Add(toolStripMenuItem9);
			ToolStripMenuItem toolStripMenuItem10 = new ToolStripMenuItem("专业报表列表");
			toolStripMenuItem10.Tag = RibbonItemTypeEnum.CodeReportList;
			toolStripMenuItem.DropDownItems.Add(toolStripMenuItem10);
			toolStripMenuItem2.Click += this.o_O_o0o_00.O.;
			toolStripMenuItem3.Click += this.o_O_o0o_00.O.;
			toolStripMenuItem4.Click += this.o_O_o0o_00.O.;
			toolStripMenuItem5.Click += this.o_O_o0o_00.O.;
			toolStripMenuItem6.Click += this.o_O_o0o_00.O.;
			toolStripMenuItem7.Click += this.o_O_o0o_00.O.;
			toolStripMenuItem8.Click += this.o_O_o0o_00.O.;
			toolStripMenuItem10.Click += this.o_O_o0o_00.O.;
			toolStripMenuItem9.Click += this.o_O_o0o_00.O.;
			this.o_oo_.O.().Items.Add(toolStripMenuItem);
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x0023CB20 File Offset: 0x0023AD20
		private void <<EMPTY_NAME>>(RibbonItemTypeEnum A_0)
		{
			DataRow dataRow = this.O.o0OO..NewRow();
			dataRow["Key"] = ShareLibriay.GetRandString(8);
			dataRow["Type"] = A_0;
			dataRow["Pane"] = this.ooO.Oo_.;
			dataRow["Code"] = "";
			object objectValue = RuntimeHelpers.GetObjectValue(this.O.o0OO..Compute("max(index)", ""));
			if (objectValue != DBNull.Value)
			{
				dataRow["Index"] = Conversions.ToInteger(objectValue) + 1;
			}
			else
			{
				dataRow["Index"] = 1;
			}
			dataRow["Name"] = o_O_o_oOoo__.OO_O0oO0.oooO_.(this.O.o0OO., this.O.o0OO..Columns["Name"], RibbonBase.o0o__0.OO0O.(A_0));
			dataRow["Property"] = "Text\v" + dataRow["Name"].ToString();
			if (this.ooO.Oo_. != null)
			{
				dataRow["ParentKey"] = RuntimeHelpers.GetObjectValue(this.ooO.Oo_.["Key"]);
			}
			this.O.o0OO..Rows.Add(dataRow);
			this.o_oo_.O.().SelectedIndex = this.o_oo_.O.().Items.Count - 1;
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x0023CC7B File Offset: 0x0023AE7B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OO00o0_.O0.((RibbonItemTypeEnum)Conversions.ToInteger(((ToolStripMenuItem)A_0).Tag));
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x0023CC93 File Offset: 0x0023AE93
		private void <<EMPTY_NAME>>(object A_0, ToolStripItemClickedEventArgs A_1)
		{
			if (A_1.ClickedItem.Tag != null)
			{
				this.OO00o0_.O0.((RibbonItemTypeEnum)Conversions.ToInteger(A_1.ClickedItem.Tag));
			}
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x0023CCB8 File Offset: 0x0023AEB8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o_oo_.O.().Position < 0 || this.o_oo_.O.().Current == null)
			{
				this.o_oo_.O.().SelectedObject = null;
				this.O.oooo0.().SelectedObject = null;
				return;
			}
			object obj = null;
			DataRow row = ((DataRowView)this.o_oo_.O.().Current).Row;
			RibbonItemTypeEnum ribbonItemTypeEnum = (RibbonItemTypeEnum)Conversions.ToInteger(row["Type"]);
			switch (ribbonItemTypeEnum)
			{
			case RibbonItemTypeEnum.PaperList:
				obj = new RibbonPaperList(row);
				break;
			case RibbonItemTypeEnum.Tab:
				obj = new RibbonTab(row);
				break;
			case RibbonItemTypeEnum.WindowList:
				obj = new RibbonWindowList(row);
				break;
			case RibbonItemTypeEnum.Group:
				obj = new RibbonGroup(row);
				break;
			case RibbonItemTypeEnum.ToggleGroup:
				obj = new RibbonToggleGroup(row);
				break;
			case RibbonItemTypeEnum.ToolBar:
				obj = new RibbonToolBar(row);
				break;
			case RibbonItemTypeEnum.Button:
				obj = new RibbonButton(row);
				break;
			case RibbonItemTypeEnum.CheckBox:
				obj = new RibbonCheckBox(row);
				break;
			case RibbonItemTypeEnum.ColorPicker:
				obj = new RibbonColorPicker(row);
				break;
			case RibbonItemTypeEnum.ComboBox:
				obj = new RibbonComboBox(row);
				break;
			case RibbonItemTypeEnum.TextBox:
				obj = new RibbonTextBox(row);
				break;
			case RibbonItemTypeEnum.FontComboBox:
				obj = new RibbonFontComboBox(row);
				break;
			case RibbonItemTypeEnum.Label:
				obj = new RibbonLabel(row);
				break;
			case RibbonItemTypeEnum.MenuButton:
				obj = new RibbonMenuButton(row);
				break;
			case RibbonItemTypeEnum.Separator:
				obj = new RibbonSeparator(row);
				break;
			case RibbonItemTypeEnum.SplitButton:
				obj = new RibbonSplitButton(row);
				break;
			case RibbonItemTypeEnum.ToggleButton:
				obj = new RibbonToggleButton(row);
				break;
			case RibbonItemTypeEnum.TableViewList:
				obj = new RibbonTableViewList(row);
				break;
			case RibbonItemTypeEnum.GroupTableList:
				obj = new RibbonGroupTableList(row);
				break;
			case RibbonItemTypeEnum.CrossTableList:
				obj = new RibbonCrossTableList(row);
				break;
			case RibbonItemTypeEnum.SubtotalModeList:
				obj = new RibbonSubtotalModeList(row);
				break;
			case RibbonItemTypeEnum.ExcelReportList:
				obj = new RibbonExcelReportList(row);
				break;
			case RibbonItemTypeEnum.CodeReportList:
				obj = new RibbonCodeReportList(row);
				break;
			case RibbonItemTypeEnum.DatePicker:
				obj = new RibbonDatePicker(row);
				break;
			case RibbonItemTypeEnum.NumericBox:
				obj = new RibbonNumericBox(row);
				break;
			case RibbonItemTypeEnum.ProgressBar:
				obj = new RibbonProgressBar(row);
				break;
			case RibbonItemTypeEnum.WordReportList:
				obj = new RibbonWordReportList(row);
				break;
			case RibbonItemTypeEnum.Gallery:
				obj = new RibbonGallery(row);
				break;
			case RibbonItemTypeEnum.GalleryItem:
				obj = new RibbonGalleryItem(row);
				break;
			case RibbonItemTypeEnum.TimePicker:
				obj = new RibbonTimePicker(row);
				break;
			case RibbonItemTypeEnum.TrackBar:
				obj = new RibbonTrackBar(row);
				break;
			case RibbonItemTypeEnum.TopToolBar:
			case RibbonItemTypeEnum.BottomToolBar:
				break;
			case RibbonItemTypeEnum.TopTab:
				obj = new RibbonTopTab(row);
				break;
			default:
				switch (ribbonItemTypeEnum)
				{
				case RibbonItemTypeEnum.ContextMenu:
					obj = new ContextMenu(row);
					break;
				case RibbonItemTypeEnum.ContextCommand:
					obj = new ContextCommand(row);
					break;
				case RibbonItemTypeEnum.ContextCommandMenu:
					obj = new ContextCommandMenu(row);
					break;
				}
				break;
			}
			try
			{
				if (obj != null)
				{
					this.o_oo_.O.().SelectedObject = new o_0oooo_OO(RuntimeHelpers.GetObjectValue(obj), new string[0], false, false);
					this.O.oooo0.().SelectedObject = new o_0oooo_OO(RuntimeHelpers.GetObjectValue(obj), new string[0], false, true);
				}
				else
				{
					this.o_oo_.O.().SelectedObject = null;
					this.O.oooo0.().SelectedObject = null;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x0023CFC0 File Offset: 0x0023B1C0
		private void <<EMPTY_NAME>>(object A_0, PropertyValueChangedEventArgs A_1)
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
				if (A_0 != this.O.oooo0.())
				{
					goto IL_31;
				}
				IL_12:
				num2 = 3;
				this.ooO0.0o__0o.(RuntimeHelpers.GetObjectValue(A_0), new SelectedGridItemChangedEventArgs(null, this.O.oooo0.().SelectedGridItem));
				IL_31:
				num2 = 4;
				DataRow row = ((DataRowView)this.o_oo_.O.().Current).Row;
				IL_49:
				num2 = 5;
				if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "LargeImage", true) != 0 && Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "SmallImage", true) != 0)
				{
					goto IL_13D;
				}
				IL_88:
				num2 = 6;
				RibbonItem ribbonItem = (RibbonItem)((o_0oooo_OO)this.o_oo_.O.().SelectedObject).Oo._o.();
				IL_A6:
				num2 = 7;
				if (Operators.CompareString(ribbonItem.LargeImage, "", true) <= 0 || Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "LargeImage", true) != 0)
				{
					goto IL_E6;
				}
				IL_DA:
				num2 = 8;
				ribbonItem.TextImageRelation = TextImageRelationEnum.Automatic;
				goto IL_13A;
				IL_E6:
				num2 = 10;
				if (Operators.CompareString(ribbonItem.LargeImage, "", true) != 0 || Operators.CompareString(ribbonItem.SmallImage, "", true) <= 0 || Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "SmallImage", true) != 0)
				{
					goto IL_13A;
				}
				IL_12F:
				num2 = 11;
				ribbonItem.TextImageRelation = TextImageRelationEnum.ImageBeforeText;
				IL_13A:
				ribbonItem = null;
				IL_13D:
				num2 = 13;
				if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "Name", true) != 0)
				{
					goto IL_29F;
				}
				IL_160:
				num2 = 14;
				if (Operators.CompareString(A_1.OldValue.ToString(), A_1.ChangedItem.Value.ToString(), true) == 0)
				{
					goto IL_27C;
				}
				IL_189:
				num2 = 15;
				DataColumn[] a_ = new DataColumn[]
				{
					this.O.o0OO..Columns["ParentKey"],
					this.O.o0OO..Columns["Pane"],
					this.O.o0OO..Columns["Name"]
				};
				IL_1DC:
				num2 = 16;
				string[] a_2 = new string[]
				{
					row["ParentKey"].ToString(),
					row["Pane"].ToString(),
					A_1.ChangedItem.Value.ToString()
				};
				IL_220:
				num2 = 17;
				if (!o_O_o_oOoo__.oo.O0o0o.(this.O.o0OO., a_, a_2))
				{
					goto IL_27C;
				}
				IL_234:
				num2 = 18;
				MessageBox.Show("重命名无效，相同名称的项目已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				IL_24A:
				num2 = 19;
				((RibbonBase)((o_0oooo_OO)this.o_oo_.O.().SelectedObject).Oo._o.()).Name = A_1.OldValue.ToString();
				goto IL_386;
				IL_27C:
				num2 = 21;
				row["Name"] = RuntimeHelpers.GetObjectValue(A_1.ChangedItem.Value);
				goto IL_386;
				IL_29F:
				num2 = 23;
				row["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(((o_0oooo_OO)this.o_oo_.O.().SelectedObject).Oo._o.()), false, '\v', false);
				IL_2D0:
				num2 = 24;
				string text = o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(((o_0oooo_OO)this.o_oo_.O.().SelectedObject).Oo._o.()), true, '\v', false);
				IL_2F8:
				num2 = 25;
				if (Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_36E;
				}
				IL_30B:
				num2 = 26;
				string a_3 = ooO0__OO.O_Oo00oO.Ooo.();
				IL_315:
				num2 = 27;
				string str = "";
				IL_31F:
				num2 = 28;
				string str2 = "";
				IL_329:
				num2 = 29;
				str = "{";
				IL_333:
				num2 = 30;
				str2 = "}";
				IL_33D:
				num2 = 31;
				a_3 = Oo00.ooO.ooo.();
				IL_347:
				num2 = 32;
				row["Code"] = str + O00.ooo000o_0.00o0.(text, ooO0__OO.O_Oo00oO.Ooo.(), a_3) + str2;
				goto IL_37D;
				IL_36E:
				num2 = 34;
				row["Code"] = null;
				IL_37D:
				num2 = 35;
				row.EndEdit();
				IL_386:
				goto IL_468;
				IL_38B:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_429:
				goto IL_45D;
				IL_42B:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_43B:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_42B;
			}
			IL_45D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_468:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x0023D45C File Offset: 0x0023B65C
		private void <<EMPTY_NAME>>(object A_0, SelectedGridItemChangedEventArgs A_1)
		{
			if (A_1.NewSelection == null || A_1.NewSelection.Value == null)
			{
				this.ooO0.0o__0o.().Text = "";
				return;
			}
			EventString eventString = (EventString)A_1.NewSelection.Value;
			if (eventString.Count > 0)
			{
				this.ooO0.0o__0o.().Text = eventString[0];
				return;
			}
			this.ooO0.0o__0o.().Text = "";
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x0023D4CC File Offset: 0x0023B6CC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o_oo_.O.().Position >= 0)
			{
				((DataRowView)this.o_oo_.O.().Current).Delete();
			}
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x0023D4F4 File Offset: 0x0023B6F4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o_oo_.O.().Position > 0)
			{
				DataRow row = this.O.o0OO.[this.o_oo_.O.().Position - 1].Row;
				DataRow row2 = this.O.o0OO.[this.o_oo_.O.().Position].Row;
				int num = Conversions.ToInteger(row["Index"]);
				int num2 = Conversions.ToInteger(row2["Index"]);
				row["Index"] = num2;
				row2["Index"] = num;
				row.EndEdit();
			}
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x0023D594 File Offset: 0x0023B794
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o_oo_.O.().Position < this.o_oo_.O.().Count - 1)
			{
				DataRow row = this.O.o0OO.[this.o_oo_.O.().Position + 1].Row;
				DataRow row2 = this.O.o0OO.[this.o_oo_.O.().Position].Row;
				int num = Conversions.ToInteger(row["Index"]);
				int num2 = Conversions.ToInteger(row2["Index"]);
				row["Index"] = num2;
				row2["Index"] = num;
				row.EndEdit();
			}
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x0023D640 File Offset: 0x0023B840
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.ooO.Oo_. = null;
			bool a_ = OO_00oOO.SystemReady;
			OO_00oOO.SystemReady = false;
			o_Oo_o0O o_Oo_o0O = new o_Oo_o0O();
			Ribbon ribbon = new Ribbon(this.O.o0OO.);
			o_Oo_o0O.o._o0ooOOO.(Main.OO_O.o..O.OOO0_OOo.(), O_O0OO.o.00O_O.(), Main.OO_O.o..O.OOO0_OOo.(), ribbon);
			Main.OO_O.o..O.OOO0_OOo.().HideTabHeaderRow = !Main.OO_O.o..O.OOO0_OOo.().HideTabHeaderRow;
			Main.OO_O.o..O.OOO0_OOo.().HideTabHeaderRow = !Main.OO_O.o..O.OOO0_OOo.().HideTabHeaderRow;
			O_O0OO.o0OoO00OO.00O. = o0_.Oo_0.OOo0oO0.(this.O.o0OO., "", "", new string[]
			{
				"Key"
			}, "Ribbon", null, null, null);
			OO_00oOO.SystemReady = a_;
			Main.OO_O.o..OOO_O_OOO.oooo. = false;
			O_O0OO.OOo_o.0o. = true;
			string a_2 = "Load_" + Conversions.ToString(Main.OO_O.o..O.OOO0_OOo.().Tag);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_2, new object[0], true, "菜单", false);
			if (Conversions.ToInteger(Interaction.IIf(ribbon.Minimized, 2, 1)) != 2)
			{
				Main.OO_O.o..OOoO0O_o_o.0_0.();
			}
			this.oO0_OO0.0_O_o.();
			for (Form form = this.oO.o00o00Oo_O.; form != null; form = ((o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)form).oO.o00o00Oo_O.)
			{
				if (form is o_\u3002\u3002\u3000\u3000\u3002)
				{
					((o_\u3002\u3002\u3000\u3000\u3002)form).o_O0_0Oo0._. = true;
					return;
				}
			}
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x0023D7B0 File Offset: 0x0023B9B0
		internal void <<EMPTY_NAME>>()
		{
			this.oO.o00o00Oo_O. = true;
			base.Close();
			if (this.oO.o00o00Oo_O. != null)
			{
				if (this.oO.o00o00Oo_O. is o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)
				{
					((o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)this.oO.o00o00Oo_O.).oO0_OO0.0_O_o.();
				}
				if (this.oO.o00o00Oo_O. is o_\u3002\u3002\u3000\u3000\u3002)
				{
					((o_\u3002\u3002\u3000\u3000\u3002)this.oO.o00o00Oo_O.).o_.o0O___0.();
				}
			}
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x0023D80C File Offset: 0x0023BA0C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O.o0OO..GetChanges() == null || MessageBox.Show(Main.OO_O.o., "确定要放弃修改吗", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.No)
			{
				base.DialogResult = DialogResult.Cancel;
			}
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x0023D841 File Offset: 0x0023BA41
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OOoO__Oo_oo.O_.();
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x0023D850 File Offset: 0x0023BA50
		internal void <<EMPTY_NAME>>()
		{
			this.oO.o00o00Oo_O. = false;
			DataTable dataTable;
			if (this.ooO.Oo_. == null)
			{
				dataTable = o_\u3002\u3002\u3000\u3000\u3002.oOoo_0O.oo00oO..oOoo_0O.oo00oO..DataTable;
			}
			else
			{
				dataTable = this.ooO.Oo_..Table;
			}
			DataTable dataTable2 = dataTable;
			dataTable.BeginLoadData();
			try
			{
				foreach (object obj in this.O.o0OO..Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (dataRow.RowState == DataRowState.Added)
					{
						dataTable2.LoadDataRow(dataRow.ItemArray, false);
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
			dataTable.EndLoadData();
			foreach (DataRow dataRow2 in this.O.o0OO..Select("", "", DataViewRowState.ModifiedCurrent))
			{
				DataRow dataRow3 = dataTable2.Rows.Find(RuntimeHelpers.GetObjectValue(dataRow2["Key"]));
				if (dataRow3 != null)
				{
					dataRow3["Name"] = RuntimeHelpers.GetObjectValue(dataRow2["Name"]);
					dataRow3["Index"] = RuntimeHelpers.GetObjectValue(dataRow2["Index"]);
					dataRow3["Property"] = RuntimeHelpers.GetObjectValue(dataRow2["Property"]);
					dataRow3["Code"] = RuntimeHelpers.GetObjectValue(dataRow2["Code"]);
					dataRow3["ParentKey"] = RuntimeHelpers.GetObjectValue(dataRow2["ParentKey"]);
					dataRow3["Pane"] = RuntimeHelpers.GetObjectValue(dataRow2["Pane"]);
				}
			}
			foreach (DataRow dataRow4 in this.O.o0OO..Select("", "", DataViewRowState.Deleted))
			{
				DataRow dataRow5 = dataTable2.Rows.Find(RuntimeHelpers.GetObjectValue(dataRow4["Key", DataRowVersion.Original]));
				if (dataRow5 != null && dataRow5.RowState != DataRowState.Deleted)
				{
					dataRow5.Delete();
				}
			}
			if (this.oO.o00o00Oo_O. != null)
			{
				if (this.oO.o00o00Oo_O. is o_\u3002\u3002\u3000\u3000\u3002)
				{
					((o_\u3002\u3002\u3000\u3000\u3002)this.oO.o00o00Oo_O.).oOoo_0O.oo00oO. = null;
				}
				if (this.oO.o00o00Oo_O. is o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)
				{
					((o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)this.oO.o00o00Oo_O.).ooO.Oo_. = null;
				}
			}
			this.oO.o00o00Oo_O. = null;
			this.ooO.Oo_. = null;
			dataTable2 = null;
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x0023DACC File Offset: 0x0023BCCC
		private void <<EMPTY_NAME>>()
		{
			if (this.ooO.Oo_. != null && this.o_oo_.O.().Position >= 0)
			{
				DataRow row = this.O.o0OO.[this.o_oo_.O.().Position].Row;
				this.O.oooo0.().Items.Clear();
				try
				{
					foreach (object obj in this.O.o0OO..Rows)
					{
						DataRow dataRow = (DataRow)obj;
						if (dataRow.RowState != DataRowState.Deleted)
						{
							RibbonItemTypeEnum ribbonItemTypeEnum = (RibbonItemTypeEnum)Conversions.ToInteger(dataRow["Type"]);
							if (ribbonItemTypeEnum == RibbonItemTypeEnum.ApplicationMenu)
							{
								if (this.OOoO00._o0O_0O.(dataRow, row, RibbonPaneEnum.Left))
								{
									o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_ tag = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_(dataRow, RibbonPaneEnum.Left);
									string text = "开始菜单";
									this.O.oooo0.().Items.Add(text).Tag = tag;
								}
								if (this.OOoO00._o0O_0O.(dataRow, row, RibbonPaneEnum.Right))
								{
									o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_ tag = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_(dataRow, RibbonPaneEnum.Right);
									string text = "开始菜单(右侧项目)";
									this.O.oooo0.().Items.Add(text).Tag = tag;
								}
								if (this.OOoO00._o0O_0O.(dataRow, row, RibbonPaneEnum.Bottom))
								{
									o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_ tag = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_(dataRow, RibbonPaneEnum.Bottom);
									string text = "开始菜单(底部项目)";
									this.O.oooo0.().Items.Add(text).Tag = tag;
								}
							}
							else if (this.OOoO00._o0O_0O.(dataRow, row, RibbonPaneEnum.Left))
							{
								o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_ tag = new o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_(dataRow, RibbonPaneEnum.Left);
								string text;
								if (ribbonItemTypeEnum == RibbonItemTypeEnum.QAT)
								{
									text = "快速访问栏";
								}
								else if (ribbonItemTypeEnum == RibbonItemTypeEnum.ConfigBar)
								{
									text = "配置栏";
								}
								else if (ribbonItemTypeEnum == RibbonItemTypeEnum.TopToolBar)
								{
									text = "上工具栏";
								}
								else if (ribbonItemTypeEnum == RibbonItemTypeEnum.BottomToolBar)
								{
									text = "下工具栏";
								}
								else
								{
									text = dataRow["Name"].ToString();
								}
								this.O.oooo0.().Items.Add(text).Tag = tag;
							}
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
				if (this.O.oooo0.().Items.Count > 0)
				{
					this.O.oooo0.().Show(this.O_o._O_OOo.(), new Point(0, this.O_o._O_OOo.().Height));
				}
			}
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x0023DCFC File Offset: 0x0023BEFC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.oooo0.().Tag = "Move";
			this.OOoo0o.00.();
		}

		// Token: 0x060050E6 RID: 20710 RVA: 0x0023DD14 File Offset: 0x0023BF14
		private void <<EMPTY_NAME>>(object A_0, ToolStripItemClickedEventArgs A_1)
		{
			DataRow row = this.O.o0OO.[this.o_oo_.O.().Position].Row;
			DataColumn[] a_ = new DataColumn[]
			{
				this.O.o0OO..Columns["ParentKey"],
				this.O.o0OO..Columns["Pane"],
				this.O.o0OO..Columns["Name"]
			};
			o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_ o0O_ = (o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_)A_1.ClickedItem.Tag;
			string[] a_2 = new string[]
			{
				o0O_.ooO.Oo_.["Key"].ToString(),
				o0O_.ooO.Oo_.["Pane"].ToString(),
				row["Name"].ToString()
			};
			if (o_O_o_oOoo__.oo.O0o0o.(this.O.o0OO., a_, a_2))
			{
				MessageBox.Show("复制失败，目标区已经存在相同名称的项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (Operators.CompareString(this.O.oooo0.().Tag.ToString(), "Move", true) == 0)
			{
				o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_ o0O_2 = (o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_)A_1.ClickedItem.Tag;
				row["ParentKey"] = RuntimeHelpers.GetObjectValue(o0O_2.ooO.Oo_.["Key"]);
				row["Pane"] = o0O_2.ooO.Oo_.;
				return;
			}
			DataRow dataRow = this.O.o0OO..NewRow();
			dataRow["Name"] = o_O_o_oOoo__.OO_O0oO0.oooO_.(this.O.o0OO., this.O.o0OO..Columns["Name"], row["Name"].ToString());
			dataRow["Key"] = ShareLibriay.GetRandString(8);
			dataRow["ParentKey"] = RuntimeHelpers.GetObjectValue(((o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_)A_1.ClickedItem.Tag).ooO.Oo_.["Key"]);
			dataRow["Type"] = RuntimeHelpers.GetObjectValue(row["Type"]);
			dataRow["Pane"] = ((o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000.O0O_)A_1.ClickedItem.Tag).ooO.Oo_.;
			dataRow["Code"] = RuntimeHelpers.GetObjectValue(row["Code"]);
			dataRow["Property"] = RuntimeHelpers.GetObjectValue(row["Property"]);
			object objectValue = RuntimeHelpers.GetObjectValue(this.O.o0OO..Compute("max(index)", ""));
			if (objectValue != DBNull.Value)
			{
				dataRow["Index"] = Conversions.ToInteger(objectValue) + 1;
			}
			else
			{
				dataRow["Index"] = 1;
			}
			this.O.o0OO..Rows.Add(dataRow);
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x0023DFE4 File Offset: 0x0023C1E4
		private bool <<EMPTY_NAME>>(DataRow A_0, DataRow A_1, RibbonPaneEnum A_2)
		{
			RibbonItemTypeEnum ribbonItemTypeEnum = (RibbonItemTypeEnum)Conversions.ToInteger(A_0["Type"]);
			RibbonItemTypeEnum ribbonItemTypeEnum2 = (RibbonItemTypeEnum)Conversions.ToInteger(A_1["Type"]);
			bool result;
			if (A_0 == A_1.GetParentRow("Ribbon") && A_2 == this.ooO.Oo_.)
			{
				result = false;
			}
			else
			{
				while (A_0 != A_0.GetParentRow("Ribbon"))
				{
					A_0 = A_0.GetParentRow("Ribbon");
					if (A_0 == A_1)
					{
						return false;
					}
					if (A_0 == null)
					{
						if (ribbonItemTypeEnum <= RibbonItemTypeEnum.SplitButton)
						{
							switch (ribbonItemTypeEnum)
							{
							case RibbonItemTypeEnum.ApplicationMenu:
								switch (A_2)
								{
								case RibbonPaneEnum.Left:
									switch (ribbonItemTypeEnum2)
									{
									case RibbonItemTypeEnum.WindowList:
									case RibbonItemTypeEnum.Button:
									case RibbonItemTypeEnum.Label:
									case RibbonItemTypeEnum.MenuButton:
									case RibbonItemTypeEnum.Separator:
									case RibbonItemTypeEnum.SplitButton:
									case RibbonItemTypeEnum.ToggleButton:
									case RibbonItemTypeEnum.TableViewList:
									case RibbonItemTypeEnum.GroupTableList:
									case RibbonItemTypeEnum.CrossTableList:
									case RibbonItemTypeEnum.SubtotalModeList:
									case RibbonItemTypeEnum.ExcelReportList:
									case RibbonItemTypeEnum.CodeReportList:
										return true;
									case RibbonItemTypeEnum.Group:
									case RibbonItemTypeEnum.ToggleGroup:
									case RibbonItemTypeEnum.ToolBar:
									case RibbonItemTypeEnum.CheckBox:
									case RibbonItemTypeEnum.ColorPicker:
									case RibbonItemTypeEnum.ComboBox:
									case RibbonItemTypeEnum.TextBox:
									case RibbonItemTypeEnum.FontComboBox:
										goto IL_346;
									default:
										goto IL_346;
									}
									break;
								case RibbonPaneEnum.Right:
									if (ribbonItemTypeEnum2 == RibbonItemTypeEnum.Button || ribbonItemTypeEnum2 == RibbonItemTypeEnum.Label || ribbonItemTypeEnum2 == RibbonItemTypeEnum.Separator)
									{
										return true;
									}
									goto IL_346;
								case RibbonPaneEnum.Bottom:
									if (ribbonItemTypeEnum2 == RibbonItemTypeEnum.Button)
									{
										return true;
									}
									goto IL_346;
								default:
									goto IL_346;
								}
								break;
							case RibbonItemTypeEnum.QAT:
								switch (ribbonItemTypeEnum2)
								{
								case RibbonItemTypeEnum.PaperList:
								case RibbonItemTypeEnum.WindowList:
								case RibbonItemTypeEnum.ToggleGroup:
								case RibbonItemTypeEnum.Button:
								case RibbonItemTypeEnum.CheckBox:
								case RibbonItemTypeEnum.ColorPicker:
								case RibbonItemTypeEnum.ComboBox:
								case RibbonItemTypeEnum.FontComboBox:
								case RibbonItemTypeEnum.MenuButton:
								case RibbonItemTypeEnum.Separator:
								case RibbonItemTypeEnum.SplitButton:
								case RibbonItemTypeEnum.ToggleButton:
								case RibbonItemTypeEnum.TableViewList:
								case RibbonItemTypeEnum.GroupTableList:
								case RibbonItemTypeEnum.CrossTableList:
								case RibbonItemTypeEnum.SubtotalModeList:
								case RibbonItemTypeEnum.ExcelReportList:
								case RibbonItemTypeEnum.CodeReportList:
									return true;
								case RibbonItemTypeEnum.Tab:
								case RibbonItemTypeEnum.Group:
								case RibbonItemTypeEnum.ToolBar:
								case RibbonItemTypeEnum.TextBox:
								case RibbonItemTypeEnum.Label:
									goto IL_346;
								default:
									goto IL_346;
								}
								break;
							case RibbonItemTypeEnum.ConfigBar:
							case RibbonItemTypeEnum.Group:
							case RibbonItemTypeEnum.ToolBar:
								break;
							case RibbonItemTypeEnum.PaperList:
							case RibbonItemTypeEnum.WindowList:
								goto IL_346;
							case RibbonItemTypeEnum.Tab:
								if (ribbonItemTypeEnum2 == RibbonItemTypeEnum.Group)
								{
									return true;
								}
								goto IL_346;
							case RibbonItemTypeEnum.ToggleGroup:
								if (ribbonItemTypeEnum2 == RibbonItemTypeEnum.ToggleButton)
								{
									return true;
								}
								goto IL_346;
							default:
								if (ribbonItemTypeEnum != RibbonItemTypeEnum.MenuButton && ribbonItemTypeEnum != RibbonItemTypeEnum.SplitButton)
								{
									goto IL_346;
								}
								goto IL_21F;
							}
						}
						else if (ribbonItemTypeEnum <= RibbonItemTypeEnum.BottomToolBar)
						{
							if (ribbonItemTypeEnum == RibbonItemTypeEnum.Gallery)
							{
								goto IL_21F;
							}
							if (ribbonItemTypeEnum - RibbonItemTypeEnum.TopToolBar > 1)
							{
								goto IL_346;
							}
						}
						else
						{
							if (ribbonItemTypeEnum != RibbonItemTypeEnum.ContextMenu && ribbonItemTypeEnum != RibbonItemTypeEnum.ContextCommandMenu)
							{
								goto IL_346;
							}
							if (ribbonItemTypeEnum2 - RibbonItemTypeEnum.ContextCommand <= 1)
							{
								return true;
							}
							goto IL_346;
						}
						switch (ribbonItemTypeEnum2)
						{
						case RibbonItemTypeEnum.PaperList:
						case RibbonItemTypeEnum.WindowList:
						case RibbonItemTypeEnum.ToggleGroup:
						case RibbonItemTypeEnum.Button:
						case RibbonItemTypeEnum.CheckBox:
						case RibbonItemTypeEnum.ColorPicker:
						case RibbonItemTypeEnum.ComboBox:
						case RibbonItemTypeEnum.TextBox:
						case RibbonItemTypeEnum.FontComboBox:
						case RibbonItemTypeEnum.Label:
						case RibbonItemTypeEnum.MenuButton:
						case RibbonItemTypeEnum.Separator:
						case RibbonItemTypeEnum.SplitButton:
						case RibbonItemTypeEnum.ToggleButton:
						case RibbonItemTypeEnum.TableViewList:
						case RibbonItemTypeEnum.GroupTableList:
						case RibbonItemTypeEnum.CrossTableList:
						case RibbonItemTypeEnum.SubtotalModeList:
						case RibbonItemTypeEnum.ExcelReportList:
						case RibbonItemTypeEnum.CodeReportList:
						case RibbonItemTypeEnum.DatePicker:
						case RibbonItemTypeEnum.NumericBox:
						case RibbonItemTypeEnum.ProgressBar:
						case RibbonItemTypeEnum.TimePicker:
						case RibbonItemTypeEnum.TrackBar:
							return true;
						case RibbonItemTypeEnum.Tab:
						case RibbonItemTypeEnum.Group:
						case RibbonItemTypeEnum.WordReportList:
						case RibbonItemTypeEnum.GalleryItem:
							goto IL_346;
						case RibbonItemTypeEnum.ToolBar:
						case RibbonItemTypeEnum.Gallery:
							return ribbonItemTypeEnum == RibbonItemTypeEnum.Group;
						default:
							goto IL_346;
						}
						IL_21F:
						switch (ribbonItemTypeEnum2)
						{
						case RibbonItemTypeEnum.PaperList:
						case RibbonItemTypeEnum.WindowList:
						case RibbonItemTypeEnum.ToggleGroup:
						case RibbonItemTypeEnum.Button:
						case RibbonItemTypeEnum.ColorPicker:
						case RibbonItemTypeEnum.ComboBox:
						case RibbonItemTypeEnum.Label:
						case RibbonItemTypeEnum.MenuButton:
						case RibbonItemTypeEnum.Separator:
						case RibbonItemTypeEnum.SplitButton:
						case RibbonItemTypeEnum.ToggleButton:
						case RibbonItemTypeEnum.TableViewList:
						case RibbonItemTypeEnum.GroupTableList:
						case RibbonItemTypeEnum.CrossTableList:
						case RibbonItemTypeEnum.SubtotalModeList:
						case RibbonItemTypeEnum.ExcelReportList:
						case RibbonItemTypeEnum.CodeReportList:
						case RibbonItemTypeEnum.Gallery:
							return true;
						case RibbonItemTypeEnum.GalleryItem:
							return ribbonItemTypeEnum == RibbonItemTypeEnum.Gallery;
						}
						IL_346:
						return false;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x0023E33A File Offset: 0x0023C53A
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.oooo0.().Tag = "Copy";
			this.OOoo0o.00.();
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x0023E354 File Offset: 0x0023C554
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Form form = this.oO.o00o00Oo_O.;
			this.oo__o0o0O._Oo.().PerformClick();
			if (form != null)
			{
				if (form is o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)
				{
					((o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)form).Oo_0.0O_oooO0o.().PerformClick();
				}
				if (form is o_\u3002\u3002\u3000\u3000\u3002)
				{
					((o_\u3002\u3002\u3000\u3000\u3002)form).oO.oO0oO__o.().PerformClick();
				}
			}
		}

		// Token: 0x04002130 RID: 8496
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04002131 RID: 8497
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x04002132 RID: 8498
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x04002133 RID: 8499
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x04002134 RID: 8500
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x04002135 RID: 8501
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x04002136 RID: 8502
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x04002137 RID: 8503
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x04002138 RID: 8504
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x04002139 RID: 8505
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400213A RID: 8506
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400213B RID: 8507
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400213C RID: 8508
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400213D RID: 8509
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400213E RID: 8510
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x0400213F RID: 8511
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04002140 RID: 8512
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04002141 RID: 8513
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04002142 RID: 8514
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x04002143 RID: 8515
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04002144 RID: 8516
		[CompilerGenerated]
		private RichTextBox <<EMPTY_NAME>>;

		// Token: 0x04002145 RID: 8517
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04002146 RID: 8518
		private DataSet <<EMPTY_NAME>>;

		// Token: 0x04002147 RID: 8519
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04002148 RID: 8520
		internal DataTable <<EMPTY_NAME>>;

		// Token: 0x04002149 RID: 8521
		private DataView <<EMPTY_NAME>>;

		// Token: 0x0400214A RID: 8522
		private RibbonItemTypeEnum <<EMPTY_NAME>>;

		// Token: 0x0400214B RID: 8523
		private RibbonPaneEnum <<EMPTY_NAME>>;

		// Token: 0x0400214C RID: 8524
		[CompilerGenerated]
		private CurrencyManager <<EMPTY_NAME>>;

		// Token: 0x0400214D RID: 8525
		internal Form <<EMPTY_NAME>>;

		// Token: 0x0400214E RID: 8526
		internal Form <<EMPTY_NAME>>;

		// Token: 0x0400214F RID: 8527
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04002150 RID: 8528
		internal bool <<EMPTY_NAME>>;

		// Token: 0x020004CB RID: 1227
		private class O0O_
		{
			// Token: 0x060050EA RID: 20714 RVA: 0x0023E3A6 File Offset: 0x0023C5A6
			internal O0O_(DataRow A_0, RibbonPaneEnum A_1)
			{
				this.ooO.Oo_. = A_0;
				this.ooO.Oo_. = A_1;
			}

			// Token: 0x04002151 RID: 8529
			internal readonly DataRow <<EMPTY_NAME>>;

			// Token: 0x04002152 RID: 8530
			internal readonly RibbonPaneEnum <<EMPTY_NAME>>;
		}
	}
}
