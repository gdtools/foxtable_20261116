using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using ADOX;
using C1.Win.C1Command;
using C1.Win.C1Input;
using Foxtable.My;
using Foxtable.Syscmd;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020004CC RID: 1228
	[DesignerGenerated]
	internal partial class o_\u3002\u3002\u3000\u3000\u3002 : Form
	{
		// Token: 0x060050EB RID: 20715 RVA: 0x0023E3BC File Offset: 0x0023C5BC
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oOoo_0O.oo00oO. != null)
				{
					this.oOoo_0O.oo00oO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x0023E3FC File Offset: 0x0023C5FC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oOoo_0O.oo00oO. = new Container();
			TreeNode treeNode = new TreeNode("功能区");
			TreeNode treeNode2 = new TreeNode("程序菜单");
			TreeNode treeNode3 = new TreeNode("快速访问栏");
			TreeNode treeNode4 = new TreeNode("配置栏");
			TreeNode treeNode5 = new TreeNode("上工具栏");
			TreeNode treeNode6 = new TreeNode("下工具栏");
			TreeNode treeNode7 = new TreeNode("功能区组");
			TreeNode treeNode8 = new TreeNode("主菜单", new TreeNode[]
			{
				treeNode,
				treeNode2,
				treeNode3,
				treeNode4,
				treeNode5,
				treeNode6,
				treeNode7
			});
			TreeNode treeNode9 = new TreeNode("快捷菜单");
			this.OoOoo__0.o.(new C1Button());
			this.o_0o0.oOo0.(new C1Button());
			this.O0_OO_00O_o.O0.(new SplitContainer());
			this.O_0OO00.Oo00.(new TreeView());
			this.O___.0_.(new C1DockingTab());
			this.o_0o0.oOo0.(new C1DockingTabPage());
			this.O_0OO00.Oo00.(new PropertyGrid());
			this.O___.0_.(new C1DockingTabPage());
			this.O_0OO00.Oo00.(new SplitContainer());
			this.O0_OO_00O_o.O0.(new PropertyGrid());
			this.O_0OO00.Oo00.(new RichTextBox());
			this.O___.0_.(new C1Button());
			this.O__.oOo.(new C1Button());
			this.O_0OO00.Oo00.(new ContextMenuStrip(this.oOoo_0O.oo00oO.));
			this.O0_OO_00O_o.O0.(new ToolStripMenuItem());
			this.O_0OO00.Oo00.(new ToolStripMenuItem());
			this.oO0o0o0._o.(new C1Button());
			this.Ooo_o._.(new C1Button());
			this.O_o0._00oOO.().Panel1.SuspendLayout();
			this.O_o0._00oOO.().Panel2.SuspendLayout();
			this.O_o0._00oOO.().SuspendLayout();
			((ISupportInitialize)this.O_o0._00oOO.()).BeginInit();
			this.O_o0._00oOO.().SuspendLayout();
			this.OO_.00oOO.().SuspendLayout();
			this.O_o0._00oOO.().SuspendLayout();
			this.OO_.00oOO.().Panel1.SuspendLayout();
			this.OO_.00oOO.().Panel2.SuspendLayout();
			this.OO_.00oOO.().SuspendLayout();
			this.O_o0._00oOO.().SuspendLayout();
			base.SuspendLayout();
			this.OO0OO0O.0O0_oO.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.OO0OO0O.0O0_oO.().Location = new Point(616, 359);
			this.OO0OO0O.0O0_oO.().Name = "cmdCancel";
			this.OO0OO0O.0O0_oO.().Size = new Size(75, 23);
			this.OO0OO0O.0O0_oO.().TabIndex = 7;
			this.OO0OO0O.0O0_oO.().Text = "关闭";
			this.OO0OO0O.0O0_oO.().UseVisualStyleBackColor = true;
			this.OOOO_Oo._O0_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.OOOO_Oo._O0_.().Location = new Point(12, 401);
			this.OOOO_Oo._O0_.().Name = "btnTemplate";
			this.OOOO_Oo._O0_.().Size = new Size(75, 23);
			this.OOOO_Oo._O0_.().TabIndex = 10;
			this.OOOO_Oo._O0_.().Text = "模板";
			this.OOOO_Oo._O0_.().UseVisualStyleBackColor = true;
			this.O_o0._00oOO.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.O_o0._00oOO.().Location = new Point(12, 12);
			this.O_o0._00oOO.().Name = "SplitContainer1";
			this.O_o0._00oOO.().Panel1.Controls.Add(this.O0.o_0.());
			this.O_o0._00oOO.().Panel2.Controls.Add(this.O_o0._00oOO.());
			this.O_o0._00oOO.().Size = new Size(579, 380);
			this.O_o0._00oOO.().SplitterDistance = 193;
			this.O_o0._00oOO.().TabIndex = 13;
			this.O0.o_0.().Dock = DockStyle.Fill;
			this.O0.o_0.().HideSelection = false;
			this.O0.o_0.().Location = new Point(0, 0);
			this.O0.o_0.().Name = "TreeView1";
			treeNode.Name = "节点0";
			treeNode.Tag = "Tab";
			treeNode.Text = "功能区";
			treeNode2.Name = "节点4";
			treeNode2.Tag = "ApplicationMenu";
			treeNode2.Text = "程序菜单";
			treeNode3.Name = "节点2";
			treeNode3.Tag = "QAT";
			treeNode3.Text = "快速访问栏";
			treeNode4.Name = "节点3";
			treeNode4.Tag = "ConfigToolBar";
			treeNode4.Text = "配置栏";
			treeNode5.Name = "TopToolBar";
			treeNode5.Tag = "TopToolBar";
			treeNode5.Text = "上工具栏";
			treeNode6.Name = "BottomToolBar";
			treeNode6.Tag = "BottomToolBar";
			treeNode6.Text = "下工具栏";
			treeNode7.Name = "TabGroups";
			treeNode7.Tag = "TabGroups";
			treeNode7.Text = "功能区组";
			treeNode8.Name = "节点0";
			treeNode8.Tag = "Ribbon";
			treeNode8.Text = "主菜单";
			treeNode9.Name = "节点1";
			treeNode9.Tag = "ContextMenu";
			treeNode9.Text = "快捷菜单";
			this.O0.o_0.().Nodes.AddRange(new TreeNode[]
			{
				treeNode8,
				treeNode9
			});
			this.O0.o_0.().Size = new Size(193, 380);
			this.O0.o_0.().TabIndex = 0;
			this.O_o0._00oOO.().BorderStyle = BorderStyle.None;
			this.O_o0._00oOO.().Controls.Add(this.OO_.00oOO.());
			this.O_o0._00oOO.().Controls.Add(this.O_o0._00oOO.());
			this.O_o0._00oOO.().Dock = DockStyle.Fill;
			this.O_o0._00oOO.().Location = new Point(0, 0);
			this.O_o0._00oOO.().Name = "C1DockingTab1";
			this.O_o0._00oOO.().Size = new Size(382, 380);
			this.O_o0._00oOO.().TabIndex = 0;
			this.O_o0._00oOO.().TabsSpacing = 0;
			this.O_o0._00oOO.().TabStyle = TabStyleEnum.WindowsXP;
			this.O_o0._00oOO.().VisualStyle = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.O_o0._00oOO.().VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.OO_.00oOO.().Controls.Add(this.O_o0._00oOO.());
			this.OO_.00oOO.().Location = new Point(0, 25);
			this.OO_.00oOO.().Name = "C1DockingTabPage1";
			this.OO_.00oOO.().Size = new Size(382, 355);
			this.OO_.00oOO.().TabIndex = 0;
			this.OO_.00oOO.().Text = "属性";
			this.O_o0._00oOO.().Dock = DockStyle.Fill;
			this.O_o0._00oOO.().Location = new Point(0, 0);
			this.O_o0._00oOO.().Name = "PropertyGrid1";
			this.O_o0._00oOO.().Size = new Size(382, 355);
			this.O_o0._00oOO.().TabIndex = 3;
			this.O_o0._00oOO.().ToolbarVisible = false;
			this.O_o0._00oOO.().Controls.Add(this.OO_.00oOO.());
			this.O_o0._00oOO.().Location = new Point(0, 25);
			this.O_o0._00oOO.().Name = "C1DockingTabPage2";
			this.O_o0._00oOO.().Size = new Size(382, 355);
			this.O_o0._00oOO.().TabIndex = 1;
			this.O_o0._00oOO.().Text = "事件";
			this.OO_.00oOO.().Dock = DockStyle.Fill;
			this.OO_.00oOO.().Location = new Point(0, 0);
			this.OO_.00oOO.().Name = "SplitContainer2";
			this.OO_.00oOO.().Orientation = Orientation.Horizontal;
			this.OO_.00oOO.().Panel1.Controls.Add(this.OO_.00oOO.());
			this.OO_.00oOO.().Panel1.RightToLeft = RightToLeft.No;
			this.OO_.00oOO.().Panel2.Controls.Add(this.O0.o_0.());
			this.OO_.00oOO.().Panel2.RightToLeft = RightToLeft.No;
			this.OO_.00oOO.().Size = new Size(382, 355);
			this.OO_.00oOO.().SplitterDistance = 227;
			this.OO_.00oOO.().TabIndex = 0;
			this.OO_.00oOO.().Dock = DockStyle.Fill;
			this.OO_.00oOO.().Location = new Point(0, 0);
			this.OO_.00oOO.().Name = "PropertyGrid2";
			this.OO_.00oOO.().Size = new Size(382, 227);
			this.OO_.00oOO.().TabIndex = 1;
			this.OO_.00oOO.().ToolbarVisible = false;
			this.O0.o_0.().BorderStyle = BorderStyle.FixedSingle;
			this.O0.o_0.().Dock = DockStyle.Fill;
			this.O0.o_0.().Location = new Point(0, 0);
			this.O0.o_0.().Name = "txtCode";
			this.O0.o_0.().ReadOnly = true;
			this.O0.o_0.().Size = new Size(382, 124);
			this.O0.o_0.().TabIndex = 0;
			this.O0.o_0.().Text = "";
			this.O0.o_0.().WordWrap = false;
			this.oO.oO0oO__o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.oO.oO0oO__o.().Location = new Point(435, 401);
			this.oO.oO0oO__o.().Name = "btnOK";
			this.oO.oO0oO__o.().Size = new Size(75, 23);
			this.oO.oO0oO__o.().TabIndex = 14;
			this.oO.oO0oO__o.().Text = "确定";
			this.oO.oO0oO__o.().UseVisualStyleBackColor = true;
			this.O0O.O_____O__o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O0O.O_____O__o.().Location = new Point(516, 401);
			this.O0O.O_____O__o.().Name = "btnClose";
			this.O0O.O_____O__o.().Size = new Size(75, 23);
			this.O0O.O_____O__o.().TabIndex = 15;
			this.O0O.O_____O__o.().Text = "取消";
			this.O0O.O_____O__o.().UseVisualStyleBackColor = true;
			this.O_o0._00oOO.().Items.AddRange(new ToolStripItem[]
			{
				this.oO0.00O__.(),
				this.O0.o_0.()
			});
			this.O_o0._00oOO.().Name = "ContextMenuStrip1";
			this.O_o0._00oOO.().Size = new Size(146, 48);
			this.oO0.00O__.().Name = "ToolStripMenuItemSave";
			this.oO0.00O__.().Size = new Size(145, 22);
			this.oO0.00O__.().Text = "保存为模板...";
			this.O0.o_0.().Name = "ToolStripMenuItemOpen";
			this.O0.o_0.().Size = new Size(145, 22);
			this.O0.o_0.().Text = "从模板生成...";
			this.OO0._O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.OO0._O.().Location = new Point(94, 401);
			this.OO0._O.().Name = "Button1";
			this.OO0._O.().Size = new Size(75, 23);
			this.OO0._O.().TabIndex = 16;
			this.OO0._O.().Text = "输出代码";
			this.OO0._O.().UseVisualStyleBackColor = true;
			this.oO0_o.O0oO000.().Location = new Point(176, 401);
			this.oO0_o.O0oO000.().Name = "btnPreview";
			this.oO0_o.O0oO000.().Size = new Size(75, 23);
			this.oO0_o.O0oO000.().TabIndex = 17;
			this.oO0_o.O0oO000.().Text = "预览";
			this.oO0_o.O0oO000.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(605, 436);
			base.Controls.Add(this.oO0_o.O0oO000.());
			base.Controls.Add(this.O_o0._00oOO.());
			base.Controls.Add(this.O0O.O_____O__o.());
			base.Controls.Add(this.OO0._O.());
			base.Controls.Add(this.oO.oO0oO__o.());
			base.Controls.Add(this.OO0OO0O.0O0_oO.());
			base.Controls.Add(this.OOOO_Oo._O0_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.0.o...";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "RibbonMenu 设计器";
			this.O_o0._00oOO.().Panel1.ResumeLayout(false);
			this.O_o0._00oOO.().Panel2.ResumeLayout(false);
			this.O_o0._00oOO.().ResumeLayout(false);
			((ISupportInitialize)this.O_o0._00oOO.()).EndInit();
			this.O_o0._00oOO.().ResumeLayout(false);
			this.OO_.00oOO.().ResumeLayout(false);
			this.O_o0._00oOO.().ResumeLayout(false);
			this.OO_.00oOO.().Panel1.ResumeLayout(false);
			this.OO_.00oOO.().Panel2.ResumeLayout(false);
			this.OO_.00oOO.().ResumeLayout(false);
			this.O_o0._00oOO.().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x0023F0E4 File Offset: 0x0023D2E4
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooO_00oo._0o_.;
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x0023F0EC File Offset: 0x0023D2EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.ooO_00oo._0o_. = A_0;
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x0023F0F5 File Offset: 0x0023D2F5
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.00__0o_.;
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x0023F100 File Offset: 0x0023D300
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O00_0O_.0_0o.);
			C1Button c1Button = this.o.00__0o_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.00__0o_. = A_0;
			c1Button = this.o.00__0o_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x0023F143 File Offset: 0x0023D343
		[CompilerGenerated]
		internal virtual SplitContainer <<EMPTY_NAME>>()
		{
			return this.ooO_00oo._0o_.;
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x0023F14B File Offset: 0x0023D34B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SplitContainer A_0)
		{
			this.ooO_00oo._0o_. = A_0;
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x0023F154 File Offset: 0x0023D354
		[CompilerGenerated]
		internal virtual TreeView <<EMPTY_NAME>>()
		{
			return this.oOoo_0O.oo00oO.;
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x0023F15C File Offset: 0x0023D35C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(TreeView A_0)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.O.ooo_O0OOO0Oo.);
			TreeView treeView = this.oOoo_0O.oo00oO.;
			if (treeView != null)
			{
				treeView.AfterSelect -= value;
			}
			this.oOoo_0O.oo00oO. = A_0;
			treeView = this.oOoo_0O.oo00oO.;
			if (treeView != null)
			{
				treeView.AfterSelect += value;
			}
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x0023F19F File Offset: 0x0023D39F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0_00O.0O.;
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x0023F1A8 File Offset: 0x0023D3A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO._ooo0oO0o0.);
			C1Button o0_00O.0O. = this.O0_00O.0O.;
			if (o0_00O.0O. != null)
			{
				o0_00O.0O..Click -= value;
			}
			this.O0_00O.0O. = A_0;
			o0_00O.0O. = this.O0_00O.0O.;
			if (o0_00O.0O. != null)
			{
				o0_00O.0O..Click += value;
			}
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x0023F1EB File Offset: 0x0023D3EB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO_0_O_O0.0__O.;
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x0023F1F4 File Offset: 0x0023D3F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo__OO00.O_.);
			C1Button oo_0_O_O0.0__O. = this.OO_0_O_O0.0__O.;
			if (oo_0_O_O0.0__O. != null)
			{
				oo_0_O_O0.0__O..Click -= value;
			}
			this.OO_0_O_O0.0__O. = A_0;
			oo_0_O_O0.0__O. = this.OO_0_O_O0.0__O.;
			if (oo_0_O_O0.0__O. != null)
			{
				oo_0_O_O0.0__O..Click += value;
			}
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x0023F237 File Offset: 0x0023D437
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.O.ooo_O0OOO0Oo.;
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x0023F23F File Offset: 0x0023D43F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			this.O.ooo_O0OOO0Oo. = A_0;
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x0023F248 File Offset: 0x0023D448
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.ooO_00oo._0o_.;
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x0023F250 File Offset: 0x0023D450
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.ooO_00oo._0o_. = A_0;
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x0023F259 File Offset: 0x0023D459
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.ooO_00oo._0o_.;
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x0023F264 File Offset: 0x0023D464
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyValueChangedEventHandler value = new PropertyValueChangedEventHandler(this.O0.o_0.);
			PropertyGrid propertyGrid = this.ooO_00oo._0o_.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyValueChanged -= value;
			}
			this.ooO_00oo._0o_. = A_0;
			propertyGrid = this.ooO_00oo._0o_.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyValueChanged += value;
			}
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x0023F2A7 File Offset: 0x0023D4A7
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.OOO0O_.o00.;
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x0023F2AF File Offset: 0x0023D4AF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.OOO0O_.o00. = A_0;
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x0023F2B8 File Offset: 0x0023D4B8
		[CompilerGenerated]
		internal virtual SplitContainer <<EMPTY_NAME>>()
		{
			return this.OOO0O_.o00.;
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x0023F2C0 File Offset: 0x0023D4C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SplitContainer A_0)
		{
			this.OOO0O_.o00. = A_0;
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x0023F2C9 File Offset: 0x0023D4C9
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.OOO0O_.o00.;
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x0023F2D4 File Offset: 0x0023D4D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyValueChangedEventHandler value = new PropertyValueChangedEventHandler(this.O0.o_0.);
			SelectedGridItemChangedEventHandler value2 = new SelectedGridItemChangedEventHandler(this.O0.o_0.);
			EventHandler value3 = new EventHandler(this.OoOOO00Oo_.0_O.);
			PropertyGrid ooo0O_.o00. = this.OOO0O_.o00.;
			if (ooo0O_.o00. != null)
			{
				ooo0O_.o00..PropertyValueChanged -= value;
				ooo0O_.o00..SelectedGridItemChanged -= value2;
				ooo0O_.o00..SelectedObjectsChanged -= value3;
			}
			this.OOO0O_.o00. = A_0;
			ooo0O_.o00. = this.OOO0O_.o00.;
			if (ooo0O_.o00. != null)
			{
				ooo0O_.o00..PropertyValueChanged += value;
				ooo0O_.o00..SelectedGridItemChanged += value2;
				ooo0O_.o00..SelectedObjectsChanged += value3;
			}
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x0023F34D File Offset: 0x0023D54D
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.ooO_00oo._0o_.;
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x0023F355 File Offset: 0x0023D555
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.ooO_00oo._0o_. = A_0;
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x0023F360 File Offset: 0x0023D560
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.ooO_00oo._0o_.;
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x0023F374 File Offset: 0x0023D574
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o_.o0O___0.);
				ToolStripMenuItem toolStripMenuItem = this.ooO_00oo._0o_.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						toolStripMenuItem.Click += value;
						num = 4;
						continue;
					case 1:
						goto IL_62;
					case 2:
						toolStripMenuItem.Click -= value;
						num = 1;
						continue;
					case 3:
						if (toolStripMenuItem != null)
						{
							num = 0;
							continue;
						}
						return;
					case 4:
						return;
					case 5:
						if (true)
						{
						}
						if (toolStripMenuItem != null)
						{
							num = 2;
							continue;
						}
						goto IL_62;
					}
					break;
					IL_62:
					this.ooO_00oo._0o_. = A_0;
					toolStripMenuItem = this.ooO_00oo._0o_.;
					num = 3;
				}
			}
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x0023F420 File Offset: 0x0023D620
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.OOO0O_.o00.;
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x0023F434 File Offset: 0x0023D634
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.oo_o0Oo.oO0O.);
				ToolStripMenuItem ooo0O_.o00. = this.OOO0O_.o00.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (ooo0O_.o00. != null)
						{
							num = 4;
							continue;
						}
						return;
					case 1:
						goto IL_62;
					case 2:
						return;
					case 3:
						ooo0O_.o00..Click -= value;
						num = 1;
						continue;
					case 4:
						ooo0O_.o00..Click += value;
						num = 2;
						continue;
					case 5:
						if (ooo0O_.o00. != null)
						{
							if (true)
							{
							}
							num = 3;
							continue;
						}
						goto IL_62;
					}
					break;
					IL_62:
					this.OOO0O_.o00. = A_0;
					ooo0O_.o00. = this.OOO0O_.o00.;
					num = 0;
				}
			}
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x0023F4DD File Offset: 0x0023D6DD
		[CompilerGenerated]
		internal virtual RichTextBox <<EMPTY_NAME>>()
		{
			return this.oOoo_0O.oo00oO.;
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x0023F4E5 File Offset: 0x0023D6E5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RichTextBox A_0)
		{
			this.oOoo_0O.oo00oO. = A_0;
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x0023F4EE File Offset: 0x0023D6EE
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_.o0O___0.;
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x0023F4F8 File Offset: 0x0023D6F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OOOO_Oo._O0_.);
			C1Button c1Button = this.o_.o0O___0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_.o0O___0. = A_0;
			c1Button = this.o_.o0O___0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x0023F53B File Offset: 0x0023D73B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo_o0Oo.oO0O.;
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x0023F544 File Offset: 0x0023D744
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.ooO.Oo_.);
			C1Button c1Button = this.oo_o0Oo.oO0O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo_o0Oo.oO0O. = A_0;
			c1Button = this.oo_o0Oo.oO0O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x0023F588 File Offset: 0x0023D788
		internal o_\u3002\u3002\u3000\u3000\u3002()
		{
			base.Activated += this.oO____00_O_O.O.;
			base.FormClosed += this.oO.oO0oO__o.;
			base.FormClosing += this.oO.oO0oO__o.;
			this.oOoo_0O.oo00oO. = false;
			this.OoOOO00Oo_.0_O.();
			o_\u3002\u3002\u3000\u3000\u3002.oOoo_0O.oo00oO. = this;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
			{
				this.O_o0._00oOO.()
			});
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x0023F617 File Offset: 0x0023D817
		internal void <<EMPTY_NAME>>(Ribbon A_0)
		{
			this.oOoo_0O.oo00oO. = A_0;
			this.O0.o_0.().Nodes[0].Expand();
			this.O0.o_0.().SelectedNode = this.O0.o_0.().Nodes[0];
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x0023F652 File Offset: 0x0023D852
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0.0000OOO0_oo.)
			{
				this.O0.0000OOO0_oo. = false;
				if (this.oOoo_0O.oo00oO. != null)
				{
					o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000 o_u3002__u3000_u3002__u3002_u3002_u3002O_u = (o\u3002_\u3000\u3002_\u3002\u3002\u3002O\u3000)this.oOoo_0O.oo00oO.;
					o_u3002__u3000_u3002__u3002_u3002_u3002O_u.O.o0OO. = true;
					o_u3002__u3000_u3002__u3002_u3002_u3002O_u.ShowDialog();
				}
			}
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x0023F685 File Offset: 0x0023D885
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			if (!this.oO0.o0_0.)
			{
				this.oOoo_0O.oo00oO. = null;
			}
			this.oO0.o0_0. = false;
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x0023F6AD File Offset: 0x0023D8AD
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			if (A_1.CloseReason == CloseReason.UserClosing && !this.oO0.o0_0.)
			{
				this.oO.oO0oO__o.().PerformClick();
			}
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x0023F6CC File Offset: 0x0023D8CC
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			string left = A_1.Node.Tag.ToString();
			if (Operators.CompareString(left, "Ribbon", true) == 0)
			{
				this.O_o0._00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO., new string[0], false, false);
				this.OO_.00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO., new string[0], false, true);
				return;
			}
			if (Operators.CompareString(left, "ApplicationMenu", true) == 0)
			{
				this.O_o0._00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO..O0o.O00., new string[0], false, false);
				this.OO_.00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO..O0o.O00., new string[0], false, true);
				return;
			}
			if (Operators.CompareString(left, "QAT", true) == 0)
			{
				this.O_o0._00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO..O0o.O00., new string[0], false, false);
				this.OO_.00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO..O0o.O00., new string[0], false, true);
				return;
			}
			if (Operators.CompareString(left, "ConfigToolBar", true) == 0)
			{
				this.O_o0._00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO..O0o.O00., new string[0], false, false);
				this.OO_.00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO..O0o.O00., new string[0], false, true);
				return;
			}
			if (Operators.CompareString(left, "TopToolBar", true) == 0)
			{
				this.O_o0._00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO..oo00OO_0.0o000., new string[0], false, false);
				this.OO_.00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO..oo00OO_0.0o000., new string[0], false, true);
				return;
			}
			if (Operators.CompareString(left, "BottomToolBar", true) == 0)
			{
				this.O_o0._00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO..O0o.O00., new string[0], false, false);
				this.OO_.00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO..O0o.O00., new string[0], false, true);
				return;
			}
			if (Operators.CompareString(left, "ContextMenu", true) == 0)
			{
				this.O_o0._00oOO.().SelectedObject = this.oOoo_0O.oo00oO..O0o.O00.;
				this.OO_.00oOO.().SelectedObject = null;
				return;
			}
			if (Operators.CompareString(left, "Tab", true) == 0)
			{
				this.O_o0._00oOO.().SelectedObject = this.oOoo_0O.oo00oO..oo00OO_0.0o000.;
				this.OO_.00oOO.().SelectedObject = null;
				return;
			}
			if (Operators.CompareString(left, "TabGroups", true) == 0)
			{
				this.O_o0._00oOO.().SelectedObject = this.oOoo_0O.oo00oO..oo00OO_0.0o000.;
				this.OO_.00oOO.().SelectedObject = null;
			}
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x0023F970 File Offset: 0x0023DB70
		private void <<EMPTY_NAME>>(object A_0, PropertyValueChangedEventArgs A_1)
		{
			int num2;
			int num4;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				this.O0.o_0.(RuntimeHelpers.GetObjectValue(A_0), new SelectedGridItemChangedEventArgs(null, this.OO_.00oOO.().SelectedGridItem));
				IL_1F:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_26:
				num = 3;
				if (this.O_o0._00oOO.().SelectedObject == this.oOoo_0O.oo00oO..O0o.O00. || this.O_o0._00oOO.().SelectedObject == this.oOoo_0O.oo00oO..oo00OO_0.0o000. || this.O_o0._00oOO.().SelectedObject == this.oOoo_0O.oo00oO..oo00OO_0.0o000.)
				{
					goto IL_146;
				}
				IL_79:
				num = 5;
				if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "Developer", true) != 0 || OO_00oOO.User.Type == UserTypeEnum.Developer)
				{
					goto IL_11E;
				}
				IL_A7:
				num = 6;
				if (A_1.OldValue != null)
				{
					goto IL_D9;
				}
				IL_B1:
				num = 7;
				((Ribbon)((o_0oooo_OO)this.O_o0._00oOO.().SelectedObject).Oo._o.()).Developer = "";
				goto IL_106;
				IL_D9:
				num = 9;
				((Ribbon)((o_0oooo_OO)this.O_o0._00oOO.().SelectedObject).Oo._o.()).Developer = A_1.OldValue.ToString();
				IL_106:
				num = 10;
				MessageBox.Show("非开发者不能更改设计者属性!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_146;
				IL_11E:
				num = 12;
				this.oOoo_0O.oo00oO..oo0o.oo_oOoOo0.(RuntimeHelpers.GetObjectValue(((o_0oooo_OO)this.O_o0._00oOO.().SelectedObject).Oo._o.()));
				IL_146:
				goto IL_1CC;
				IL_14B:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_18D:
				goto IL_1C1;
				IL_18F:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_19F:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_18F;
			}
			IL_1C1:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1CC:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x0023FB70 File Offset: 0x0023DD70
		private void <<EMPTY_NAME>>(object A_0, SelectedGridItemChangedEventArgs A_1)
		{
			if (A_1.NewSelection == null || A_1.NewSelection.Value == null)
			{
				this.O0.o_0.().Text = "";
				return;
			}
			EventString eventString = (EventString)A_1.NewSelection.Value;
			if (eventString.Count > 0)
			{
				this.O0.o_0.().Text = eventString[0];
				return;
			}
			this.O0.o_0.().Text = "";
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x0023FBE0 File Offset: 0x0023DDE0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num3;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				goto IL_5E;
				IL_09:
				int num2 = num3 + 1;
				num3 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_1F:
				goto IL_53;
				IL_21:
				int num4;
				num3 = num4;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_31:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_21;
			}
			IL_53:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_5E:
			if (num3 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x0023FC64 File Offset: 0x0023DE64
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oOoo_0O.oo00oO..DataTable.GetChanges() == null || MessageBox.Show(Main.OO_O.o., "确定要放弃修改吗", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.No)
			{
				base.DialogResult = DialogResult.Cancel;
				if (this.o_O0_0Oo0._.)
				{
					Project.OpenSystemMenu();
				}
			}
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x0023FCB6 File Offset: 0x0023DEB6
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.Ooo_o._.();
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x0023FCC8 File Offset: 0x0023DEC8
		internal void <<EMPTY_NAME>>()
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
				if (base.Visible || !this.oO0.o0_0.)
				{
					goto IL_2B;
				}
				IL_19:
				num2 = 3;
				this.oOoo_0O.oo00oO. = null;
				IL_22:
				num2 = 4;
				this.oO0.o0_0. = false;
				IL_2B:
				num2 = 5;
				if (this.oOoo_0O.oo00oO..DataTable.GetChanges() == null)
				{
					goto IL_48;
				}
				IL_3F:
				num2 = 6;
				this.oOoo_0O.oo00oO. = true;
				IL_48:
				num2 = 7;
				Oo00.o0_o._O_.(this.oOoo_0O.oo00oO..DataTable, true);
				IL_5B:
				num2 = 8;
				if (this.oOoo_0O.oo00oO..DataTable != O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()])
				{
					goto IL_F4;
				}
				IL_7E:
				num2 = 9;
				string file = OO_00oOO.ProjectPath + "Bin\\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Ribbon.dll";
				IL_A0:
				num2 = 10;
				if (!OO_00oOO.FileSys.FileExists(file))
				{
					goto IL_BE;
				}
				IL_B0:
				num2 = 11;
				OO_00oOO.FileSys.DeleteFile(file);
				IL_BE:
				num2 = 12;
				Main.OO_O.o..SuspendLayout();
				IL_CB:
				num2 = 13;
				Main.OO_O.o..o0_o_o_0.0O.(false);
				IL_DA:
				num2 = 14;
				Main.OO_O.o..OOoO0O_o_o.0_0.();
				IL_E7:
				num2 = 15;
				Main.OO_O.o..ResumeLayout();
				IL_F4:
				num2 = 16;
				Main.O0O_.00_O0Oo_.();
				IL_FC:
				num2 = 17;
				if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()].Rows.Count > 6 || O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()].Rows.Count <= 4)
				{
					goto IL_157;
				}
				IL_141:
				num2 = 18;
				MessageBox.Show("自定义菜单需要有3个以上的组件才会生效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_157:
				num2 = 19;
				this.oOoo_0O.oo00oO. = null;
				IL_161:
				goto IL_203;
				IL_166:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1C4:
				goto IL_1F8;
				IL_1C6:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1D6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1C6;
			}
			IL_1F8:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_203:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x0023FEFC File Offset: 0x0023E0FC
		internal void <<EMPTY_NAME>>()
		{
			this.oO0.o0_0. = true;
			base.Close();
			new O\u3002\u3000\u3002_\u3002\u3000\u3000\u3002\u3000\u3002\u3000(this)
			{
				Owner = Main.OO_O.o.,
				Location = new Point(388, 300)
			}.Show();
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x0023FF38 File Offset: 0x0023E138
		private void <<EMPTY_NAME>>()
		{
			int num;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!O_O0OO.O0_00o.o0__o..oOO0_o_._ooO.)
				{
					goto IL_38;
				}
				IL_15:
				num2 = 3;
				if (Project.oOOoOOOo._O.())
				{
					goto IL_38;
				}
				IL_1E:
				num2 = 4;
				MessageBox.Show(O_O0OO.OO0._0.(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_473;
				IL_38:
				num2 = 6;
				Information.Err().Clear();
				IL_44:
				num2 = 7;
				Catalog catalog = new CatalogClass();
				IL_4C:
				num2 = 8;
				ADOX.Table table = new TableClass();
				IL_55:
				num2 = 9;
				Index index = new IndexClass();
				IL_5F:
				num2 = 10;
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				IL_69:
				num2 = 11;
				saveFileDialog.Filter = "菜单文件(*" + ooO0__OO.o_0O._OO__.() + ")|*" + ooO0__OO.o_0O._OO__.();
				IL_8C:
				num2 = 12;
				saveFileDialog.OverwritePrompt = true;
				IL_97:
				num2 = 13;
				saveFileDialog.AddExtension = true;
				IL_A2:
				num2 = 14;
				saveFileDialog.CheckPathExists = true;
				IL_AD:
				num2 = 15;
				if (saveFileDialog.ShowDialog() != DialogResult.OK)
				{
					goto IL_473;
				}
				IL_BD:
				num2 = 16;
				string fileName = saveFileDialog.FileName;
				IL_C9:
				num2 = 19;
				if (!c.OOOOO.o.().FileSystem.FileExists(fileName))
				{
					goto IL_F3;
				}
				IL_DF:
				num2 = 20;
				c.OOOOO.o.().FileSystem.DeleteFile(fileName);
				IL_F3:
				num2 = 21;
				catalog.Create(Oo00.o00.0OO.(fileName));
				IL_104:
				num2 = 22;
				table = new TableClass();
				IL_10E:
				num2 = 23;
				index = new IndexClass();
				IL_118:
				num2 = 24;
				table.Name = ooO0__OO.OO0o.OO_OoOO0.();
				IL_127:
				num2 = 25;
				table.Columns.Append("Key", ADOX.DataTypeEnum.adVarWChar, 8);
				IL_141:
				num2 = 26;
				table.Columns.Append("ParentKey", ADOX.DataTypeEnum.adVarWChar, 8);
				IL_15B:
				num2 = 27;
				table.Columns.Append("Name", ADOX.DataTypeEnum.adVarWChar, 32);
				IL_176:
				num2 = 28;
				table.Columns.Append("Index", ADOX.DataTypeEnum.adInteger, 0);
				IL_18C:
				num2 = 29;
				table.Columns.Append("Type", ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				IL_1A3:
				num2 = 30;
				table.Columns.Append("Pane", ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				IL_1BA:
				num2 = 31;
				table.Columns.Append("Property", ADOX.DataTypeEnum.adLongVarWChar, 0);
				IL_1D4:
				num2 = 32;
				table.Columns.Append("Code", ADOX.DataTypeEnum.adLongVarWChar, 0);
				IL_1EE:
				num2 = 33;
				table.Columns["ParentKey"].Attributes = ColumnAttributesEnum.adColNullable;
				IL_208:
				num2 = 34;
				table.Columns["Name"].Attributes = ColumnAttributesEnum.adColNullable;
				IL_222:
				num2 = 35;
				table.Columns["Index"].Attributes = ColumnAttributesEnum.adColNullable;
				IL_23C:
				num2 = 36;
				table.Columns["Pane"].Attributes = ColumnAttributesEnum.adColNullable;
				IL_256:
				num2 = 37;
				table.Columns["Property"].Attributes = ColumnAttributesEnum.adColNullable;
				IL_270:
				num2 = 38;
				table.Columns["Code"].Attributes = ColumnAttributesEnum.adColNullable;
				IL_28A:
				num2 = 39;
				index.Name = "PrimaryKey";
				IL_299:
				num2 = 40;
				index.Columns.Append("Key", ADOX.DataTypeEnum.adVarWChar, 0);
				IL_2B3:
				num2 = 41;
				index.PrimaryKey = true;
				IL_2BE:
				num2 = 42;
				index.Unique = true;
				IL_2C9:
				num2 = 43;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				IL_2E4:
				num2 = 44;
				catalog.Tables.Append(table);
				IL_2F4:
				num2 = 45;
				((Connection)catalog.ActiveConnection).Close();
				IL_307:
				num2 = 46;
				catalog = null;
				IL_30C:
				num2 = 47;
				OleDbConnection oleDbConnection = new OleDbConnection(Oo00.o_._0OOo.(fileName));
				IL_31D:
				num2 = 48;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From [" + ooO0__OO.OO0o.OO_OoOO0.() + "]", oleDbConnection);
				IL_33D:
				num2 = 49;
				DataTable dataTable = this.oOoo_0O.oo00oO..DataTable.Copy();
				IL_352:
				num2 = 50;
				dataTable.AcceptChanges();
				IL_35C:
				num2 = 51;
				o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter);
				IL_366:
				num2 = 52;
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_387:
					num2 = 53;
					dataRow.SetAdded();
					IL_391:
					num2 = 54;
				}
				IL_39D:
				num2 = 55;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_3B5:
				num2 = 56;
				DataRow dataRow2 = dataTable.NewRow();
				IL_3C1:
				num2 = 57;
				dataRow2["Name"] = "_Identify_";
				IL_3D5:
				num2 = 58;
				dataRow2["Type"] = RibbonItemTypeEnum.Identify;
				IL_3EE:
				num2 = 59;
				dataRow2["key"] = OoOo0O.OO_o.0o_O.(8);
				IL_403:
				num2 = 60;
				dataRow2["Property"] = O_O0OO.O_O._Oo.();
				IL_417:
				num2 = 61;
				dataTable.Rows.Add(dataRow2);
				IL_428:
				num2 = 62;
				oleDbConnection.Open();
				IL_432:
				num2 = 63;
				oleDbDataAdapter.Update(dataTable);
				IL_43F:
				num2 = 64;
				oleDbConnection.Close();
				IL_449:
				num2 = 65;
				if (Information.Err().Number == 0)
				{
					goto IL_473;
				}
				IL_458:
				num2 = 66;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_473:
				goto IL_5D5;
				IL_478:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_596:
				goto IL_5CA;
				IL_598:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_5A8:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_598;
			}
			IL_5CA:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_5D5:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x00240540 File Offset: 0x0023E740
		private void <<EMPTY_NAME>>()
		{
			int num;
			int num5;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				Information.Err().Clear();
				IL_13:
				num2 = 3;
				OpenFileDialog openFileDialog = new OpenFileDialog();
				IL_1B:
				num2 = 4;
				string text = "";
				IL_24:
				num2 = 5;
				openFileDialog.CheckFileExists = true;
				IL_2D:
				num2 = 6;
				openFileDialog.Filter = "菜单文件(*" + ooO0__OO.o_0O._OO__.() + ")|*" + ooO0__OO.o_0O._OO__.();
				IL_4E:
				num2 = 7;
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					goto IL_401;
				}
				IL_5C:
				num2 = 8;
				string fileName = openFileDialog.FileName;
				IL_66:
				num2 = 11;
				if (MessageBox.Show("如果应用模板，当前的菜单设计将全部丢失，且不可恢复，确定要应用模板吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					goto IL_401;
				}
				IL_81:
				num2 = 13;
				OleDbConnection oleDbConnection = new OleDbConnection(Oo00.o_._0OOo.(fileName));
				IL_92:
				num2 = 14;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From [" + ooO0__OO.OO0o.OO_OoOO0.() + "]", oleDbConnection);
				IL_B2:
				num2 = 15;
				oleDbConnection.Open();
				IL_BC:
				num2 = 16;
				this.oOoo_0O.oo00oO..DataTable.BeginLoadData();
				IL_CF:
				num2 = 17;
				this.oOoo_0O.oo00oO..DataTable.RejectChanges();
				IL_E2:
				num2 = 18;
				int num3 = this.oOoo_0O.oo00oO..DataTable.Rows.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_103:
					num2 = 19;
					this.oOoo_0O.oo00oO..DataTable.Rows[i].Delete();
					IL_122:
					num2 = 20;
				}
				IL_131:
				num2 = 21;
				Oo00.o0_o._O_.(this.oOoo_0O.oo00oO..DataTable, true);
				IL_145:
				num2 = 22;
				oleDbDataAdapter.Fill(this.oOoo_0O.oo00oO..DataTable);
				IL_15B:
				num2 = 23;
				DataTable dataTable = this.oOoo_0O.oo00oO..DataTable;
				IL_16B:
				num2 = 24;
				if (dataTable.Rows.Count <= 0)
				{
					goto IL_1E7;
				}
				IL_17D:
				num2 = 25;
				DataRow dataRow = dataTable.Rows[dataTable.Rows.Count - 1];
				IL_19C:
				num2 = 26;
				if (Conversions.ToInteger(dataRow["Type"]) != 250)
				{
					goto IL_1E7;
				}
				IL_1B7:
				num2 = 27;
				text = dataRow["Property"].ToString();
				IL_1CD:
				num2 = 28;
				text = o0OO__.O.0ooOoO_0_.(text);
				IL_1D9:
				num2 = 29;
				text = text.Substring(0, 6);
				IL_1E7:
				dataTable = null;
				IL_1EA:
				num2 = 31;
				IEnumerator enumerator = this.oOoo_0O.oo00oO..DataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow2 = (DataRow)obj;
					IL_217:
					num2 = 32;
					dataRow2.SetAdded();
					IL_221:
					num2 = 33;
					if (Operators.CompareString(text, "", true) > 0 && !dataRow2.IsNull("Code"))
					{
						IL_248:
						num2 = 34;
						string text2 = dataRow2["code"].ToString();
						IL_25E:
						num2 = 35;
						if (text2.StartsWith("{") && text2.EndsWith("}"))
						{
							IL_27D:
							num2 = 36;
							text2 = text2.TrimStart(new char[]
							{
								'{'
							}).TrimEnd(new char[]
							{
								'}'
							});
							IL_2A4:
							num2 = 37;
							text2 = O00.oO_.0o_oo_0O_.(text2, ooO0__OO.O_Oo00oO.Ooo.(), text);
							IL_2B7:
							num2 = 38;
							text2 = "{" + O00.ooo000o_0.00o0.(text2, ooO0__OO.O_Oo00oO.Ooo.(), Oo00.ooO.ooo.()) + "}";
							IL_2DC:
							num2 = 39;
							dataRow2["code"] = text2;
						}
					}
					IL_2ED:
					num2 = 40;
				}
				IL_2FC:
				num2 = 41;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_314:
				num2 = 42;
				this.oOoo_0O.oo00oO..DataTable.EndLoadData();
				IL_327:
				num2 = 43;
				this.oOoo_0O.oo00oO..oo0o.oo_oOoOo0.();
				IL_335:
				num2 = 44;
				if (this.O0.o_0.().SelectedNode == this.O0.o_0.().Nodes[0])
				{
					goto IL_377;
				}
				IL_356:
				num2 = 45;
				this.O0.o_0.().SelectedNode = this.O0.o_0.().Nodes[0];
				goto IL_3B9;
				IL_377:
				num2 = 47;
				this.O_o0._00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO., new string[0], false, false);
				IL_398:
				num2 = 48;
				this.OO_.00oOO.().SelectedObject = new o_0oooo_OO(this.oOoo_0O.oo00oO., new string[0], false, true);
				IL_3B9:
				num2 = 49;
				oleDbConnection.Close();
				IL_3C3:
				num2 = 50;
				Oo00.o0_o._O_.(this.oOoo_0O.oo00oO..DataTable, true);
				IL_3D7:
				num2 = 51;
				if (Information.Err().Number == 0)
				{
					goto IL_401;
				}
				IL_3E6:
				num2 = 52;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_401:
				goto IL_52B;
				IL_406:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_4EC:
				goto IL_520;
				IL_4EE:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_4FE:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_4EE;
			}
			IL_520:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_52B:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06005120 RID: 20768 RVA: 0x00240A9C File Offset: 0x0023EC9C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O0.o_0.();
		}

		// Token: 0x06005121 RID: 20769 RVA: 0x00240AA4 File Offset: 0x0023ECA4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_0o0.oOo0.();
		}

		// Token: 0x06005122 RID: 20770 RVA: 0x00240AAC File Offset: 0x0023ECAC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_o0._00oOO.().Show(this.OOOO_Oo._O0_.(), new Point(0, this.OOOO_Oo._O0_.().Height));
		}

		// Token: 0x06005123 RID: 20771 RVA: 0x00240AD0 File Offset: 0x0023ECD0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O0.o_0.().Text = "";
		}

		// Token: 0x06005124 RID: 20772 RVA: 0x00240AE2 File Offset: 0x0023ECE2
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OO_00oOO.oo0oOO.o.(OO_00oOO.OoOO.o.0_O., "");
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x00240AF0 File Offset: 0x0023ECF0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oOoo_0O.oo00oO. = null;
			bool a_ = OO_00oOO.SystemReady;
			OO_00oOO.SystemReady = false;
			new o_Oo_o0O().o._o0ooOOO.(Main.OO_O.o..O.OOO0_OOo.(), O_O0OO.o.00O_O.(), Main.OO_O.o..O.OOO0_OOo.(), this.oOoo_0O.oo00oO.);
			Main.OO_O.o..O.OOO0_OOo.().HideTabHeaderRow = !Main.OO_O.o..O.OOO0_OOo.().HideTabHeaderRow;
			Main.OO_O.o..O.OOO0_OOo.().HideTabHeaderRow = !Main.OO_O.o..O.OOO0_OOo.().HideTabHeaderRow;
			O_O0OO.o0OoO00OO.00O. = o0_.Oo_0.OOo0oO0.(this.oOoo_0O.oo00oO..DataTable, "", "", new string[]
			{
				"Key"
			}, "Ribbon", null, null, null);
			OO_00oOO.SystemReady = a_;
			Main.OO_O.o..OOO_O_OOO.oooo. = false;
			O_O0OO.OOo_o.0o. = true;
			string a_2 = "Load_" + Conversions.ToString(Main.OO_O.o..O.OOO0_OOo.().Tag);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_2, new object[0], true, "菜单", false);
			if (Conversions.ToInteger(Interaction.IIf(this.oOoo_0O.oo00oO..Minimized, 2, 1)) != 2)
			{
				Main.OO_O.o..OOoO0O_o_o.0_0.();
			}
			this.o_.o0O___0.();
			this.o_O0_0Oo0._. = true;
		}

		// Token: 0x04002153 RID: 8531
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04002154 RID: 8532
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04002155 RID: 8533
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04002156 RID: 8534
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x04002157 RID: 8535
		[CompilerGenerated]
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x04002158 RID: 8536
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04002159 RID: 8537
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400215A RID: 8538
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x0400215B RID: 8539
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x0400215C RID: 8540
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x0400215D RID: 8541
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x0400215E RID: 8542
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x0400215F RID: 8543
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x04002160 RID: 8544
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x04002161 RID: 8545
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04002162 RID: 8546
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04002163 RID: 8547
		[CompilerGenerated]
		private RichTextBox <<EMPTY_NAME>>;

		// Token: 0x04002164 RID: 8548
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04002165 RID: 8549
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04002166 RID: 8550
		internal Ribbon <<EMPTY_NAME>>;

		// Token: 0x04002167 RID: 8551
		internal static o_\u3002\u3002\u3000\u3000\u3002 <<EMPTY_NAME>>;

		// Token: 0x04002168 RID: 8552
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04002169 RID: 8553
		internal Form <<EMPTY_NAME>>;

		// Token: 0x0400216A RID: 8554
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400216B RID: 8555
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400216C RID: 8556
		internal bool <<EMPTY_NAME>>;
	}
}
