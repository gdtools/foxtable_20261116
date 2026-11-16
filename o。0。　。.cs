using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1Input;
using C1.Win.C1Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020004C9 RID: 1225
	[DesignerGenerated]
	internal partial class o\u30020\u3002\u3000\u3002\u3000 : C1RibbonForm
	{
		// Token: 0x06005087 RID: 20615 RVA: 0x00239E70 File Offset: 0x00238070
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OO0.OO_O_oO_0. != null)
				{
					this.OO0.OO_O_oO_0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x00239EB0 File Offset: 0x002380B0
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o._0o___0.(new C1Ribbon());
			this.o._0o___0.(new RibbonApplicationMenu());
			this.o._0o___0.(new RibbonConfigToolBar());
			this.Oooo._O000_.(new RibbonQat());
			this.Oooo._O000_.(new RibbonTopToolBar());
			this.o._0o___0.(new RibbonBottomToolBar());
			this.o._0o___0.(new GroupBox());
			this.o._0o___0.(new LinkLabel());
			this.o._0o___0.(new C1ComboBox());
			this.o._0o___0.(new C1CommandHolder());
			((ISupportInitialize)this.oO.OOo0_.()).BeginInit();
			this.oO.OOo0_.().SuspendLayout();
			((ISupportInitialize)this.oO.OOo0_.()).BeginInit();
			base.SuspendLayout();
			this.oO.OOo0_.().ApplicationMenuHolder = this.oO.OOo0_.();
			this.oO.OOo0_.().BottomToolBarHolder = this.oO.OOo0_.();
			this.oO.OOo0_.().ConfigToolBarHolder = this.oO.OOo0_.();
			this.oO.OOo0_.().Location = new Point(0, 0);
			this.oO.OOo0_.().Name = "C1Ribbon1";
			this.oO.OOo0_.().QatHolder = this.oO.OOo0_.();
			this.oO.OOo0_.().Size = new Size(669, 47);
			this.oO.OOo0_.().TopToolBarHolder = this.o._0o___0.();
			this.oO.OOo0_.().Name = "RibbonApplicationMenu1";
			this.oO.OOo0_.().Name = "RibbonConfigToolBar1";
			this.oO.OOo0_.().Name = "RibbonQat1";
			this.o._0o___0.().Name = "RibbonTopToolBar1";
			this.oO.OOo0_.().Name = "RibbonBottomToolBar1";
			this.oO.OOo0_.().Anchor = AnchorStyles.None;
			this.oO.OOo0_.().Controls.Add(this.oO.OOo0_.());
			this.oO.OOo0_.().Controls.Add(this.oO.OOo0_.());
			this.oO.OOo0_.().Location = new Point(200, 164);
			this.oO.OOo0_.().Name = "GroupBox1";
			this.oO.OOo0_.().Size = new Size(269, 159);
			this.oO.OOo0_.().TabIndex = 2;
			this.oO.OOo0_.().TabStop = false;
			this.oO.OOo0_.().Text = "快捷菜单测试";
			this.oO.OOo0_.().AutoSize = true;
			this.oO.OOo0_.().Location = new Point(54, 86);
			this.oO.OOo0_.().Name = "LinkLabel1";
			this.oO.OOo0_.().Size = new Size(161, 12);
			this.oO.OOo0_.().TabIndex = 1;
			this.oO.OOo0_.().TabStop = true;
			this.oO.OOo0_.().Text = "右击此处测试选定的快捷菜单";
			this.oO.OOo0_.().DropDownStyle = DropDownStyle.DropDownList;
			this.oO.OOo0_.().Location = new Point(52, 30);
			this.oO.OOo0_.().Name = "ContextMenuList";
			this.oO.OOo0_.().Size = new Size(165, 20);
			this.oO.OOo0_.().TabIndex = 0;
			this.oO.OOo0_.().Owner = this;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(669, 487);
			base.Controls.Add(this.oO.OOo0_.());
			base.Controls.Add(this.oO.OOo0_.());
			base.Name = "OOo....o";
			base.ShowInTaskbar = false;
			this.Text = "frmRebbionPreview";
			base.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Windows7;
			((ISupportInitialize)this.oO.OOo0_.()).EndInit();
			this.oO.OOo0_.().ResumeLayout(false);
			this.oO.OOo0_.().PerformLayout();
			((ISupportInitialize)this.oO.OOo0_.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x0023A253 File Offset: 0x00238453
		[CompilerGenerated]
		internal virtual C1Ribbon <<EMPTY_NAME>>()
		{
			return this.Oooo._O000_.;
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x0023A25B File Offset: 0x0023845B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Ribbon A_0)
		{
			this.Oooo._O000_. = A_0;
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x0023A264 File Offset: 0x00238464
		[CompilerGenerated]
		internal virtual RibbonApplicationMenu <<EMPTY_NAME>>()
		{
			return this.Oooo._O000_.;
		}

		// Token: 0x0600508C RID: 20620 RVA: 0x0023A26C File Offset: 0x0023846C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonApplicationMenu A_0)
		{
			this.Oooo._O000_. = A_0;
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x0023A275 File Offset: 0x00238475
		[CompilerGenerated]
		internal virtual RibbonConfigToolBar <<EMPTY_NAME>>()
		{
			return this.Oooo._O000_.;
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x0023A27D File Offset: 0x0023847D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonConfigToolBar A_0)
		{
			this.Oooo._O000_. = A_0;
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x0023A286 File Offset: 0x00238486
		[CompilerGenerated]
		internal virtual RibbonQat <<EMPTY_NAME>>()
		{
			return this.OO0.OO_O_oO_0.;
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x0023A28E File Offset: 0x0023848E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonQat A_0)
		{
			this.OO0.OO_O_oO_0. = A_0;
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x0023A297 File Offset: 0x00238497
		[CompilerGenerated]
		internal virtual GroupBox <<EMPTY_NAME>>()
		{
			return this.Oooo._O000_.;
		}

		// Token: 0x06005092 RID: 20626 RVA: 0x0023A29F File Offset: 0x0023849F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(GroupBox A_0)
		{
			this.Oooo._O000_. = A_0;
		}

		// Token: 0x06005093 RID: 20627 RVA: 0x0023A2A8 File Offset: 0x002384A8
		[CompilerGenerated]
		internal virtual LinkLabel <<EMPTY_NAME>>()
		{
			return this.Oooo._O000_.;
		}

		// Token: 0x06005094 RID: 20628 RVA: 0x0023A2B0 File Offset: 0x002384B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(LinkLabel A_0)
		{
			this.Oooo._O000_. = A_0;
		}

		// Token: 0x06005095 RID: 20629 RVA: 0x0023A2B9 File Offset: 0x002384B9
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.Oooo._O000_.;
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x0023A2C4 File Offset: 0x002384C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.o.OO0o.);
			C1ComboBox oooo._O000_. = this.Oooo._O000_.;
			if (oooo._O000_. != null)
			{
				oooo._O000_..SelectedIndexChanged -= value;
			}
			this.Oooo._O000_. = A_0;
			oooo._O000_. = this.Oooo._O000_.;
			if (oooo._O000_. != null)
			{
				oooo._O000_..SelectedIndexChanged += value;
			}
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x0023A307 File Offset: 0x00238507
		[CompilerGenerated]
		internal virtual C1CommandHolder <<EMPTY_NAME>>()
		{
			return this.Oooo._O000_.;
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x0023A30F File Offset: 0x0023850F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CommandHolder A_0)
		{
			this.Oooo._O000_. = A_0;
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x0023A318 File Offset: 0x00238518
		[CompilerGenerated]
		internal virtual RibbonBottomToolBar <<EMPTY_NAME>>()
		{
			return this.Oooo._O000_.;
		}

		// Token: 0x0600509A RID: 20634 RVA: 0x0023A320 File Offset: 0x00238520
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonBottomToolBar A_0)
		{
			this.Oooo._O000_. = A_0;
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x0023A329 File Offset: 0x00238529
		[CompilerGenerated]
		internal virtual RibbonTopToolBar <<EMPTY_NAME>>()
		{
			return this.OO0.OO_O_oO_0.;
		}

		// Token: 0x0600509C RID: 20636 RVA: 0x0023A331 File Offset: 0x00238531
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonTopToolBar A_0)
		{
			this.OO0.OO_O_oO_0. = A_0;
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x0023A33C File Offset: 0x0023853C
		public o\u30020\u3002\u3000\u3002\u3000()
		{
			base.Load += this.oO.OOo0_.;
			base.FormClosed += this.o_0.o__OOoO.;
			this.OO0.OO_O_oO_0. = new Dictionary<string, o__o_OO_o_>();
			this.o._0o___0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x0600509E RID: 20638 RVA: 0x0023A39C File Offset: 0x0023859C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OO0.OO_O_oO_0..ContainsKey(this.oO.OOo0_.().SelectedItem.ToString()))
			{
				this.oO.OOo0_.().SetC1ContextMenu(this.oO.OOo0_.(), this.OO0.OO_O_oO_0.[this.oO.OOo0_.().SelectedItem.ToString()]);
			}
		}

		// Token: 0x0600509F RID: 20639 RVA: 0x0023A3F2 File Offset: 0x002385F2
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.WindowState = FormWindowState.Maximized;
			this.oO.OOo0_.().VisualStyle = Main.OO_O.o..O.OOO0_OOo.().VisualStyle;
			this.oO.OOo0_.().HideAppMenuWithTHR = true;
		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x0023A421 File Offset: 0x00238621
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04002124 RID: 8484
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04002125 RID: 8485
		[CompilerGenerated]
		private C1Ribbon <<EMPTY_NAME>>;

		// Token: 0x04002126 RID: 8486
		[CompilerGenerated]
		private RibbonApplicationMenu <<EMPTY_NAME>>;

		// Token: 0x04002127 RID: 8487
		[CompilerGenerated]
		private RibbonConfigToolBar <<EMPTY_NAME>>;

		// Token: 0x04002128 RID: 8488
		[CompilerGenerated]
		private RibbonQat <<EMPTY_NAME>>;

		// Token: 0x04002129 RID: 8489
		[CompilerGenerated]
		private GroupBox <<EMPTY_NAME>>;

		// Token: 0x0400212A RID: 8490
		[CompilerGenerated]
		private LinkLabel <<EMPTY_NAME>>;

		// Token: 0x0400212B RID: 8491
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x0400212C RID: 8492
		[CompilerGenerated]
		private C1CommandHolder <<EMPTY_NAME>>;

		// Token: 0x0400212D RID: 8493
		[CompilerGenerated]
		private RibbonBottomToolBar <<EMPTY_NAME>>;

		// Token: 0x0400212E RID: 8494
		[CompilerGenerated]
		private RibbonTopToolBar <<EMPTY_NAME>>;

		// Token: 0x0400212F RID: 8495
		internal Dictionary<string, o__o_OO_o_> <<EMPTY_NAME>>;
	}
}
