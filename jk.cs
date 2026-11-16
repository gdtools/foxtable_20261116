using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using C1.Framework;
using C1.Win.C1Command;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using C1.Win.C1Ribbon;
using C1.Win.C1Themes;
using Foxtable.My;
using Foxtable.RibbonMenu;
using Foxtable.Syscmd;
using Foxtable.WinForm;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace Foxtable
{
	// Token: 0x0200036B RID: 875
	[DesignerGenerated]
	internal partial class jk : C1RibbonForm
	{
		// Token: 0x06003722 RID: 14114 RVA: 0x00183040 File Offset: 0x00181240
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
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
				if (!A_0 || this.oOO0.OOoo0oO. == null)
				{
					goto IL_21;
				}
				IL_14:
				num2 = 3;
				this.oOO0.OOoo0oO..Dispose();
				IL_21:
				num2 = 4;
				base.Dispose(A_0);
				IL_2A:
				goto IL_8D;
				IL_2C:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_4E:
				goto IL_82;
				IL_50:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_60:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_50;
			}
			IL_82:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_8D:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x001830F4 File Offset: 0x001812F4
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oOO0.OOoo0oO. = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(jk));
			C1TopicPage c1TopicPage = new C1TopicPage();
			C1TopicLink c1TopicLink = new C1TopicLink();
			C1TopicLink c1TopicLink2 = new C1TopicLink();
			C1TopicLink c1TopicLink3 = new C1TopicLink();
			C1TopicLink c1TopicLink4 = new C1TopicLink();
			C1TopicLink c1TopicLink5 = new C1TopicLink();
			C1TopicPage c1TopicPage2 = new C1TopicPage();
			C1TopicLink c1TopicLink6 = new C1TopicLink();
			C1TopicLink c1TopicLink7 = new C1TopicLink();
			C1TopicPage c1TopicPage3 = new C1TopicPage();
			C1TopicLink c1TopicLink8 = new C1TopicLink();
			C1TopicLink c1TopicLink9 = new C1TopicLink();
			this.OOoo___.0.(new ImageList(this.oOO0.OOoo0oO.));
			this.Oo__.ooOo00_Oo.(new C1Ribbon());
			this.O0.0000oO.(new RibbonApplicationMenu());
			this.O_o.00.(new RibbonBottomToolBar());
			this.O_o.00.(new RibbonConfigToolBar());
			this.O_o.00.(new RibbonQat());
			this.O_o.00.(new RibbonTab());
			this.O_o.00.(new RibbonGroup());
			this.O_o.00.(new RibbonTopToolBar());
			this.Oo__.ooOo00_Oo.(new C1StatusBar());
			this.Oo_.o__.(new RibbonLabel());
			this.O0.0000oO.(new RibbonProgressBar());
			this.o_o0Oo.00.(new RibbonLabel());
			this.O0.0000oO.(new RibbonLabel());
			this.O_o.00.(new C1CommandDock());
			this.O_o.00.(new oo00o_());
			this.Oo__.ooOo00_Oo.(new C1DockingTabPage());
			this.O0.0000oO.(new o0ooo_0_00oO());
			this.Oo__.ooOo00_Oo.(new C1CommandHolder());
			this.OOoo___.0.(new ToolTip(this.oOO0.OOoo0oO.));
			this.O_o.00.(new System.Windows.Forms.Timer(this.oOO0.OOoo0oO.));
			this.o.O000oo.(new System.Windows.Forms.Timer(this.oOO0.OOoo0oO.));
			this.O0.0000oO.(new OO___OO0O_0());
			this.O0.0000oO.(new C1ThemeController());
			((ISupportInitialize)this.O.OOO0_OOo.()).BeginInit();
			((ISupportInitialize)this.O.OOO0_OOo.()).BeginInit();
			((ISupportInitialize)this.O0o__0_OO.o.()).BeginInit();
			this.O0o__0_OO.o.().SuspendLayout();
			((ISupportInitialize)this.O0o__0_OO.o.()).BeginInit();
			this.O0o__0_OO.o.().SuspendLayout();
			this.O.OOO0_OOo.().SuspendLayout();
			((ISupportInitialize)this.O.OOO0_OOo.()).BeginInit();
			((ISupportInitialize)this.O.OOO0_OOo.()).BeginInit();
			((ISupportInitialize)this.OO_O_0Oo.___o.()).BeginInit();
			((ISupportInitialize)this.O.OOO0_OOo.()).BeginInit();
			base.SuspendLayout();
			this.o0_o_o_0.0O.().ImageStream = (ImageListStreamer)componentResourceManager.GetObject("TopicImageList.ImageStream");
			this.o0_o_o_0.0O.().TransparentColor = Color.Transparent;
			this.o0_o_o_0.0O.().Images.SetKeyName(0, "");
			this.o0_o_o_0.0O.().Images.SetKeyName(1, "");
			this.o0_o_o_0.0O.().Images.SetKeyName(2, "");
			this.o0_o_o_0.0O.().Images.SetKeyName(3, "");
			this.o0_o_o_0.0O.().Images.SetKeyName(4, "");
			this.o0_o_o_0.0O.().Images.SetKeyName(5, "Manul.ico");
			this.o0_o_o_0.0O.().Images.SetKeyName(6, "EmailSupport.ico");
			this.o0_o_o_0.0O.().Images.SetKeyName(7, "Telephone.ico");
			this.o0_o_o_0.0O.().Images.SetKeyName(8, "Accept32.ico");
			this.o0_o_o_0.0O.().Images.SetKeyName(9, "Demo.ico");
			this.O.OOO0_OOo.().ApplicationMenuHolder = this.OO_O_0Oo.___o.();
			this.O.OOO0_OOo.().AutoSizeElement = AutoSizeElement.Width;
			this.O.OOO0_OOo.().BottomToolBarHolder = this.OO_O_0Oo.___o.();
			this.O.OOO0_OOo.().ConfigToolBarHolder = this.OO_O_0Oo.___o.();
			this.O.OOO0_OOo.().Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.O.OOO0_OOo.().Location = new Point(0, 0);
			this.O.OOO0_OOo.().Margin = new Padding(3, 2, 3, 2);
			this.O.OOO0_OOo.().Name = "C1Ribbon1";
			this.O.OOO0_OOo.().QatHolder = this.O0o__0_OO.o.();
			this.O.OOO0_OOo.().Size = new Size(932, 154);
			this.O.OOO0_OOo.().Tabs.Add(this.O0o__0_OO.o.());
			this.O.OOO0_OOo.().TopToolBarHolder = this.O0o__0_OO.o.();
			this.OO_O_0Oo.___o.().Name = "RibbonApplicationMenu1";
			this.OO_O_0Oo.___o.().Name = "RibbonBottomToolBar1";
			this.OO_O_0Oo.___o.().Name = "RibbonConfigToolBar1";
			this.O0o__0_OO.o.().MenuVisible = false;
			this.O0o__0_OO.o.().Name = "RibbonQat1";
			this.O0o__0_OO.o.().Groups.Add(this.OO_O_0Oo.___o.());
			this.O0o__0_OO.o.().Name = "RibbonTab1";
			this.O0o__0_OO.o.().Text = "Tab";
			this.OO_O_0Oo.___o.().Name = "RibbonGroup1";
			this.OO_O_0Oo.___o.().Text = "Group";
			this.O0o__0_OO.o.().Name = "RibbonTopToolBar1";
			this.O.OOO0_OOo.().AutoSizeElement = AutoSizeElement.Width;
			this.O.OOO0_OOo.().LeftPaneItems.Add(this.OO_O_0Oo.___o.());
			this.O.OOO0_OOo.().LeftPaneItems.Add(this.OO_O_0Oo.___o.());
			this.O.OOO0_OOo.().LeftPaneItems.Add(this.o__0_._oOooO_o.());
			this.O.OOO0_OOo.().Location = new Point(0, 613);
			this.O.OOO0_OOo.().Margin = new Padding(3, 2, 3, 2);
			this.O.OOO0_OOo.().Name = "C1StatusBar1";
			this.O.OOO0_OOo.().RightPaneItems.Add(this.oO0_oO.0o.());
			this.O.OOO0_OOo.().RightPaneWidth = 450;
			this.O.OOO0_OOo.().RightToLeft = RightToLeft.Yes;
			this.O.OOO0_OOo.().Size = new Size(932, 23);
			this.OO_O_0Oo.___o.().Name = "Message1";
			this.OO_O_0Oo.___o.().Text = "就绪";
			this.OO_O_0Oo.___o.().Name = "ProgressBar";
			this.OO_O_0Oo.___o.().Visible = false;
			this.o__0_._oOooO_o.().Name = "Message2";
			this.oO0_oO.0o.().Name = "Message3";
			this.O0o__0_OO.o.().AllowFloat = false;
			this.O0o__0_OO.o.().AutoDockBottom = false;
			this.O0o__0_OO.o.().AutoDockLeft = false;
			this.O0o__0_OO.o.().AutoDockRight = false;
			this.O0o__0_OO.o.().AutoDockTop = false;
			this.O0o__0_OO.o.().BackColor = Color.FromArgb(207, 221, 208);
			this.O0o__0_OO.o.().Controls.Add(this.O0o__0_OO.o.());
			this.O0o__0_OO.o.().Dock = DockStyle.Right;
			this.O0o__0_OO.o.().ForeColor = Color.Black;
			this.O0o__0_OO.o.().Id = 2;
			this.O0o__0_OO.o.().Location = new Point(620, 154);
			this.O0o__0_OO.o.().Margin = new Padding(0);
			this.O0o__0_OO.o.().Name = "RightDcokArea";
			this.O0o__0_OO.o.().Size = new Size(312, 459);
			this.O.OOO0_OOo.().SetTheme(this.O0o__0_OO.o.(), "(default)");
			this.O0o__0_OO.o.().Alignment = TabAlignment.Bottom;
			this.O0o__0_OO.o.().BorderStyle = BorderStyle.FixedSingle;
			this.O0o__0_OO.o.().CanAutoHide = true;
			this.O0o__0_OO.o.().CanCloseTabs = true;
			this.O0o__0_OO.o.().Controls.Add(this.O.OOO0_OOo.());
			this.O0o__0_OO.o.().HotTrack = true;
			this.O0o__0_OO.o.().Location = new Point(0, 0);
			this.O0o__0_OO.o.().Margin = new Padding(0);
			this.O0o__0_OO.o.().Name = "RightDockTab";
			this.O0o__0_OO.o.().ShowCaption = true;
			this.O0o__0_OO.o.().ShowSingleTab = false;
			this.O0o__0_OO.o.().Size = new Size(312, 459);
			this.O0o__0_OO.o.().SplitterWidth = 1;
			this.O0o__0_OO.o.().TabIndex = 0;
			this.O0o__0_OO.o.().TabsCanFocus = false;
			this.O0o__0_OO.o.().TabSizeMode = TabSizeModeEnum.Fit;
			this.O0o__0_OO.o.().TabsSpacing = 2;
			this.O.OOO0_OOo.().SetTheme(this.O0o__0_OO.o.(), "(default)");
			this.O0o__0_OO.o.().VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue;
			this.O0o__0_OO.o.().VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue;
			this.O.OOO0_OOo.().CaptionVisible = true;
			this.O.OOO0_OOo.().Controls.Add(this.O.OOO0_OOo.());
			this.O.OOO0_OOo.().Location = new Point(2, 1);
			this.O.OOO0_OOo.().Name = "C1DockingTabPage1";
			this.O.OOO0_OOo.().Size = new Size(309, 457);
			this.O.OOO0_OOo.().TabIndex = 0;
			this.O.OOO0_OOo.().Text = "开始工作";
			this.O.OOO0_OOo.().AutoScrollMinSize = new Size(0, 334);
			this.O.OOO0_OOo.().Dock = DockStyle.Fill;
			this.O.OOO0_OOo.().ImageList = this.o0_o_o_0.0O.();
			this.O.OOO0_OOo.().Location = new Point(0, 23);
			this.O.OOO0_OOo.().Name = "C1TopicBar1";
			this.O.OOO0_OOo.().Padding = new Padding(13, 11, 13, 11);
			this.O.OOO0_OOo.().PagePadding = new Padding(10);
			c1TopicPage.ImageList = this.o0_o_o_0.0O.();
			c1TopicLink.ImageIndex = 5;
			c1TopicLink.Tag = "Help";
			c1TopicLink.Text = "使用指南";
			c1TopicLink2.ImageIndex = 3;
			c1TopicLink2.Tag = "Home";
			c1TopicLink2.Text = "访问主页";
			c1TopicLink3.ImageIndex = 4;
			c1TopicLink3.Tag = "BBS";
			c1TopicLink3.Text = "用户交流";
			c1TopicLink4.ImageIndex = 6;
			c1TopicLink4.Tag = "Feedback";
			c1TopicLink4.Text = "意见反馈";
			c1TopicLink5.ImageIndex = 7;
			c1TopicLink5.Tag = "Order";
			c1TopicLink5.Text = "联系我们";
			c1TopicPage.Links.Add(c1TopicLink);
			c1TopicPage.Links.Add(c1TopicLink2);
			c1TopicPage.Links.Add(c1TopicLink3);
			c1TopicPage.Links.Add(c1TopicLink4);
			c1TopicPage.Links.Add(c1TopicLink5);
			c1TopicPage.Text = "支持";
			c1TopicPage2.ImageList = this.o0_o_o_0.0O.();
			c1TopicLink6.ImageIndex = 0;
			c1TopicLink6.Tag = "Demo";
			c1TopicLink6.Text = "基本功能演示";
			c1TopicLink7.ImageIndex = 9;
			c1TopicLink7.Tag = "presentation";
			c1TopicLink7.Text = "基本功能介绍";
			c1TopicPage2.Links.Add(c1TopicLink6);
			c1TopicPage2.Links.Add(c1TopicLink7);
			c1TopicPage2.Text = "演示";
			c1TopicPage3.ImageList = this.o0_o_o_0.0O.();
			c1TopicLink8.ImageIndex = 1;
			c1TopicLink8.Tag = "New";
			c1TopicLink8.Text = "新建...";
			c1TopicLink9.ImageIndex = 2;
			c1TopicLink9.Tag = "Open";
			c1TopicLink9.Text = "更多...";
			c1TopicPage3.Links.Add(c1TopicLink8);
			c1TopicPage3.Links.Add(c1TopicLink9);
			c1TopicPage3.Text = "项目";
			this.O.OOO0_OOo.().Pages.Add(c1TopicPage);
			this.O.OOO0_OOo.().Pages.Add(c1TopicPage2);
			this.O.OOO0_OOo.().Pages.Add(c1TopicPage3);
			this.O.OOO0_OOo.().Size = new Size(309, 434);
			this.O.OOO0_OOo.().TabIndex = 0;
			this.O.OOO0_OOo.().SetTheme(this.O.OOO0_OOo.(), "(default)");
			this.O.OOO0_OOo.().VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue;
			this.O.OOO0_OOo.().VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue;
			this.O.OOO0_OOo.().Owner = this;
			this.O0o__0_OO.o.().Enabled = true;
			this.O0o__0_OO.o.().Interval = 60000;
			this.o00o_OO_o_._o.().Enabled = true;
			this.o00o_OO_o_._o.().Interval = 200;
			this.OO_O_0Oo.___o.().BackColor = Color.FromArgb(240, 240, 240);
			this.OO_O_0Oo.___o.().BorderStyle = BorderStyle.FixedSingle;
			this.OO_O_0Oo.___o.().CanMoveTabs = true;
			this.OO_O_0Oo.___o.().Dock = DockStyle.Fill;
			this.OO_O_0Oo.___o.().Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.OO_O_0Oo.___o.().HotTrack = true;
			this.OO_O_0Oo.___o.().Location = new Point(0, 154);
			this.OO_O_0Oo.___o.().Margin = new Padding(3, 2, 3, 2);
			this.OO_O_0Oo.___o.().Name = "MainPages";
			this.OO_O_0Oo.___o.().SelectedTabBold = true;
			this.OO_O_0Oo.___o.().ShowTabList = true;
			this.OO_O_0Oo.___o.().ShowToolTips = true;
			this.OO_O_0Oo.___o.().Size = new Size(620, 459);
			this.OO_O_0Oo.___o.().TabIndex = 0;
			this.OO_O_0Oo.___o.().TabsCanFocus = false;
			this.OO_O_0Oo.___o.().TabSizeMode = TabSizeModeEnum.Fit;
			this.OO_O_0Oo.___o.().TabsShowFocusCues = false;
			this.OO_O_0Oo.___o.().TabsSpacing = 2;
			this.OO_O_0Oo.___o.().TabStyle = TabStyleEnum.Office2007;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height);
			base.Controls.Add(this.OO_O_0Oo.___o.());
			base.Controls.Add(this.O0o__0_OO.o.());
			base.Controls.Add(this.O.OOO0_OOo.());
			base.Controls.Add(this.O.OOO0_OOo.());
			this.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.Margin = new Padding(3, 2, 3, 2);
			base.Name = "frmMain";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "frmMain";
			base.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue;
			base.WindowState = FormWindowState.Maximized;
			((ISupportInitialize)this.O.OOO0_OOo.()).EndInit();
			((ISupportInitialize)this.O.OOO0_OOo.()).EndInit();
			((ISupportInitialize)this.O0o__0_OO.o.()).EndInit();
			this.O0o__0_OO.o.().ResumeLayout(false);
			((ISupportInitialize)this.O0o__0_OO.o.()).EndInit();
			this.O0o__0_OO.o.().ResumeLayout(false);
			this.O.OOO0_OOo.().ResumeLayout(false);
			((ISupportInitialize)this.O.OOO0_OOo.()).EndInit();
			((ISupportInitialize)this.O.OOO0_OOo.()).EndInit();
			((ISupportInitialize)this.OO_O_0Oo.___o.()).EndInit();
			((ISupportInitialize)this.O.OOO0_OOo.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x00183F68 File Offset: 0x00182168
		private void <<EMPTY_NAME>>(C1ThemeController A_0, ObjectThemeEventArgs A_1)
		{
			if (A_1.Object is C1FlexGrid)
			{
				C1FlexGrid c1FlexGrid = (C1FlexGrid)A_1.Object;
				if (Operators.CompareString(A_1.ThemeName, "", true) > 0 && A_1.ThemeName.StartsWith("Foxtable", StringComparison.OrdinalIgnoreCase))
				{
					c1FlexGrid.Styles.Highlight.BackColor = Color.FromArgb(0, 120, 215);
					c1FlexGrid.Styles.Highlight.ForeColor = Color.White;
				}
				else if (Operators.CompareString(A_1.ThemeName, "", true) > 0 && A_1.ThemeName.StartsWith("Office2013", StringComparison.OrdinalIgnoreCase))
				{
					c1FlexGrid.Styles.Focus.Clear(StyleElementFlags.BackColor);
					c1FlexGrid.Styles.Focus.Clear(StyleElementFlags.ForeColor);
				}
				else if (Operators.CompareString(A_1.ThemeName, "", true) > 0 && A_1.ThemeName.StartsWith("Office2016", StringComparison.OrdinalIgnoreCase))
				{
					c1FlexGrid.Styles.Alternate.Clear(StyleElementFlags.Font);
				}
				if (!(A_1.Object is O_oOooO_O))
				{
					c1FlexGrid.Styles.Alternate.Clear();
				}
			}
			if (A_1.Object is C1DockingTab && Operators.CompareString(A_1.ThemeName, "System", true) == 0)
			{
				((C1DockingTab)A_1.Object).BorderStyle = BorderStyle.Fixed3D;
			}
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x001840C2 File Offset: 0x001822C2
		private void <<EMPTY_NAME>>(C1ThemeController A_0, ObjectThemeEventArgs A_1)
		{
			if (A_1.Object is C1Button && Operators.CompareString(A_1.ThemeName, "Foxtable经典蓝", true) == 0)
			{
				((C1Button)A_1.Object).VisualStyle = C1.Win.C1Input.VisualStyle.System;
			}
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x001840F5 File Offset: 0x001822F5
		[CompilerGenerated]
		internal virtual C1Ribbon <<EMPTY_NAME>>()
		{
			return this.o_o0o0OO.O.;
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x00184100 File Offset: 0x00182300
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Ribbon A_0)
		{
			RibbonEventHandler value = new RibbonEventHandler(this.Oo._oO0Oo_0.);
			C1Ribbon c1Ribbon = this.o_o0o0OO.O.;
			if (c1Ribbon != null)
			{
				c1Ribbon.RibbonEvent -= value;
			}
			this.o_o0o0OO.O. = A_0;
			c1Ribbon = this.o_o0o0OO.O.;
			if (c1Ribbon != null)
			{
				c1Ribbon.RibbonEvent += value;
			}
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x00184143 File Offset: 0x00182343
		[CompilerGenerated]
		internal virtual RibbonApplicationMenu <<EMPTY_NAME>>()
		{
			return this.OOo0o_oOOo_0._.;
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x0018414B File Offset: 0x0018234B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonApplicationMenu A_0)
		{
			this.OOo0o_oOOo_0._. = A_0;
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x00184154 File Offset: 0x00182354
		[CompilerGenerated]
		internal virtual RibbonConfigToolBar <<EMPTY_NAME>>()
		{
			return this.OOo0o_oOOo_0._.;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x0018415C File Offset: 0x0018235C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonConfigToolBar A_0)
		{
			this.OOo0o_oOOo_0._. = A_0;
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00184165 File Offset: 0x00182365
		[CompilerGenerated]
		internal virtual RibbonGroup <<EMPTY_NAME>>()
		{
			return this.oOO.O_oo.;
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x0018416D File Offset: 0x0018236D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonGroup A_0)
		{
			this.oOO.O_oo. = A_0;
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00184176 File Offset: 0x00182376
		[CompilerGenerated]
		public virtual C1StatusBar <<EMPTY_NAME>>()
		{
			return this.o_o0o0OO.O.;
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x0018417E File Offset: 0x0018237E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(C1StatusBar A_0)
		{
			this.o_o0o0OO.O. = A_0;
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00184187 File Offset: 0x00182387
		[CompilerGenerated]
		internal virtual OO___OO0O_0 <<EMPTY_NAME>>()
		{
			return this.OOo0o_oOOo_0._.;
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00184190 File Offset: 0x00182390
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(OO___OO0O_0 A_0)
		{
			ControlEventHandler value = new ControlEventHandler(this.o0_o_o_0.0O.);
			EventHandler value2 = new EventHandler(this.o.OoO.);
			SelectedIndexChangingEventHandler value3 = new SelectedIndexChangingEventHandler(this.Oo__.ooOo00_Oo.);
			TabPageCancelEventHandler value4 = new TabPageCancelEventHandler(this.Oo__.ooOo00_Oo.);
			OO___OO0O_0 ooo0o_oOOo_0._. = this.OOo0o_oOOo_0._.;
			if (ooo0o_oOOo_0._. != null)
			{
				ooo0o_oOOo_0._..ControlRemoved -= value;
				ooo0o_oOOo_0._..SelectedIndexChanged -= value2;
				ooo0o_oOOo_0._..SelectedIndexChanging -= value3;
				ooo0o_oOOo_0._..TabPageClosing -= value4;
			}
			this.OOo0o_oOOo_0._. = A_0;
			ooo0o_oOOo_0._. = this.OOo0o_oOOo_0._.;
			if (ooo0o_oOOo_0._. != null)
			{
				ooo0o_oOOo_0._..ControlRemoved += value;
				ooo0o_oOOo_0._..SelectedIndexChanged += value2;
				ooo0o_oOOo_0._..SelectedIndexChanging += value3;
				ooo0o_oOOo_0._..TabPageClosing += value4;
			}
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00184230 File Offset: 0x00182430
		[CompilerGenerated]
		internal virtual C1CommandDock <<EMPTY_NAME>>()
		{
			return this.oOO.O_oo.;
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00184238 File Offset: 0x00182438
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CommandDock A_0)
		{
			this.oOO.O_oo. = A_0;
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x00184241 File Offset: 0x00182441
		[CompilerGenerated]
		internal virtual oo00o_ <<EMPTY_NAME>>()
		{
			return this.oOO.O_oo.;
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x0018424C File Offset: 0x0018244C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(oo00o_ A_0)
		{
			TabPageEventHandler value = new TabPageEventHandler(this.Oo._oO0Oo_0.);
			TabPageCancelEventHandler value2 = new TabPageCancelEventHandler(this.O.O00OOOo0_.);
			oo00o_ oo00o_ = this.oOO.O_oo.;
			if (oo00o_ != null)
			{
				oo00o_.TabPageClosed -= value;
				oo00o_.TabPageClosing -= value2;
			}
			this.oOO.O_oo. = A_0;
			oo00o_ = this.oOO.O_oo.;
			if (oo00o_ != null)
			{
				oo00o_.TabPageClosed += value;
				oo00o_.TabPageClosing += value2;
			}
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x001842AA File Offset: 0x001824AA
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.o_o0o0OO.O.;
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x001842B2 File Offset: 0x001824B2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.o_o0o0OO.O. = A_0;
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x001842BB File Offset: 0x001824BB
		[CompilerGenerated]
		internal virtual o0ooo_0_00oO <<EMPTY_NAME>>()
		{
			return this.o_o0o0OO.O.;
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x001842C4 File Offset: 0x001824C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(o0ooo_0_00oO A_0)
		{
			C1TopicBarClickEventHandler value = new C1TopicBarClickEventHandler(this.o0oO_O.0Oo_00.);
			o0ooo_0_00oO o0ooo_0_00oO = this.o_o0o0OO.O.;
			if (o0ooo_0_00oO != null)
			{
				o0ooo_0_00oO.LinkClick -= value;
			}
			this.o_o0o0OO.O. = A_0;
			o0ooo_0_00oO = this.o_o0o0OO.O.;
			if (o0ooo_0_00oO != null)
			{
				o0ooo_0_00oO.LinkClick += value;
			}
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x00184307 File Offset: 0x00182507
		[CompilerGenerated]
		internal virtual C1CommandHolder <<EMPTY_NAME>>()
		{
			return this.o_o0o0OO.O.;
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x0018430F File Offset: 0x0018250F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CommandHolder A_0)
		{
			this.o_o0o0OO.O. = A_0;
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x00184318 File Offset: 0x00182518
		[CompilerGenerated]
		internal virtual ToolTip <<EMPTY_NAME>>()
		{
			return this.oOO.O_oo.;
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x00184320 File Offset: 0x00182520
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolTip A_0)
		{
			this.oOO.O_oo. = A_0;
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x00184329 File Offset: 0x00182529
		[CompilerGenerated]
		internal virtual System.Windows.Forms.Timer <<EMPTY_NAME>>()
		{
			return this.oOO.O_oo.;
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x00184334 File Offset: 0x00182534
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.Timer A_0)
		{
			EventHandler value = new EventHandler(this.O_.oOO_O0_0.);
			System.Windows.Forms.Timer timer = this.oOO.O_oo.;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.oOO.O_oo. = A_0;
			timer = this.oOO.O_oo.;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x00184377 File Offset: 0x00182577
		[CompilerGenerated]
		internal virtual RibbonBottomToolBar <<EMPTY_NAME>>()
		{
			return this.OOo0o_oOOo_0._.;
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x0018437F File Offset: 0x0018257F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonBottomToolBar A_0)
		{
			this.OOo0o_oOOo_0._. = A_0;
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x00184388 File Offset: 0x00182588
		[CompilerGenerated]
		internal virtual RibbonTopToolBar <<EMPTY_NAME>>()
		{
			return this.oOO.O_oo.;
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x00184390 File Offset: 0x00182590
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonTopToolBar A_0)
		{
			this.oOO.O_oo. = A_0;
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x00184399 File Offset: 0x00182599
		[CompilerGenerated]
		internal virtual System.Windows.Forms.Timer <<EMPTY_NAME>>()
		{
			return this.ooO0_O0.O00.;
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x001843A4 File Offset: 0x001825A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.Timer A_0)
		{
			EventHandler value = new EventHandler(this.Oo.oOo_o0Oo0.);
			System.Windows.Forms.Timer timer = this.ooO0_O0.O00.;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.ooO0_O0.O00. = A_0;
			timer = this.ooO0_O0.O00.;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x001843E7 File Offset: 0x001825E7
		[CompilerGenerated]
		private virtual RibbonQat <<EMPTY_NAME>>()
		{
			return this.oOO.O_oo.;
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x001843EF File Offset: 0x001825EF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(RibbonQat A_0)
		{
			this.oOO.O_oo. = A_0;
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x001843F8 File Offset: 0x001825F8
		[CompilerGenerated]
		private virtual RibbonTab <<EMPTY_NAME>>()
		{
			return this.oOO.O_oo.;
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00184400 File Offset: 0x00182600
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(RibbonTab A_0)
		{
			this.oOO.O_oo. = A_0;
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x00184409 File Offset: 0x00182609
		[CompilerGenerated]
		private virtual ImageList <<EMPTY_NAME>>()
		{
			return this.oOO0.OOoo0oO.;
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x00184411 File Offset: 0x00182611
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(ImageList A_0)
		{
			this.oOO0.OOoo0oO. = A_0;
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x0018441A File Offset: 0x0018261A
		[CompilerGenerated]
		private virtual C1ThemeController <<EMPTY_NAME>>()
		{
			return this.o_o0o0OO.O.;
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x00184424 File Offset: 0x00182624
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(C1ThemeController A_0)
		{
			ObjectThemeEventHandler value = new ObjectThemeEventHandler(this.O.O00OOOo0_.);
			ObjectThemeEventHandler value2 = new ObjectThemeEventHandler(this.o0oO_O.0Oo_00.);
			C1ThemeController c1ThemeController = this.o_o0o0OO.O.;
			if (c1ThemeController != null)
			{
				c1ThemeController.ObjectThemeApplied -= value;
				c1ThemeController.ObjectThemeApplying -= value2;
			}
			this.o_o0o0OO.O. = A_0;
			c1ThemeController = this.o_o0o0OO.O.;
			if (c1ThemeController != null)
			{
				c1ThemeController.ObjectThemeApplied += value;
				c1ThemeController.ObjectThemeApplying += value2;
			}
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x00184482 File Offset: 0x00182682
		[CompilerGenerated]
		internal virtual RibbonLabel <<EMPTY_NAME>>()
		{
			return this.OOo0o_oOOo_0._.;
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x0018448A File Offset: 0x0018268A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonLabel A_0)
		{
			this.OOo0o_oOOo_0._. = A_0;
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x00184493 File Offset: 0x00182693
		[CompilerGenerated]
		internal virtual RibbonProgressBar <<EMPTY_NAME>>()
		{
			return this.OOo0o_oOOo_0._.;
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x0018449B File Offset: 0x0018269B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonProgressBar A_0)
		{
			this.OOo0o_oOOo_0._. = A_0;
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x001844A4 File Offset: 0x001826A4
		[CompilerGenerated]
		internal virtual RibbonLabel <<EMPTY_NAME>>()
		{
			return this.o_O_0Oo0.0O0O.;
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x001844AC File Offset: 0x001826AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonLabel A_0)
		{
			this.o_O_0Oo0.0O0O. = A_0;
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x001844B5 File Offset: 0x001826B5
		[CompilerGenerated]
		internal virtual RibbonLabel <<EMPTY_NAME>>()
		{
			return this.O0o_0o0oo.O_.;
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x001844BD File Offset: 0x001826BD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RibbonLabel A_0)
		{
			this.O0o_0o0oo.O_. = A_0;
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x001844C6 File Offset: 0x001826C6
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.o_o0o0OO.O.;
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x001844D0 File Offset: 0x001826D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			TabPageEventHandler value = new TabPageEventHandler(this.Oo._oO0Oo_0.);
			TabPageCancelEventHandler value2 = new TabPageCancelEventHandler(this.O.O00OOOo0_.);
			C1DockingTab c1DockingTab = this.o_o0o0OO.O.;
			if (c1DockingTab != null)
			{
				c1DockingTab.TabPageClosed -= value;
				c1DockingTab.TabPageClosing -= value2;
			}
			this.o_o0o0OO.O. = A_0;
			c1DockingTab = this.o_o0o0OO.O.;
			if (c1DockingTab != null)
			{
				c1DockingTab.TabPageClosed += value;
				c1DockingTab.TabPageClosing += value2;
			}
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x0018452E File Offset: 0x0018272E
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.o_O_0Oo0.0O0O.;
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x00184538 File Offset: 0x00182738
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			TabPageEventHandler value = new TabPageEventHandler(this.Oo._oO0Oo_0.);
			TabPageCancelEventHandler value2 = new TabPageCancelEventHandler(this.O.O00OOOo0_.);
			C1DockingTab c1DockingTab = this.o_O_0Oo0.0O0O.;
			if (c1DockingTab != null)
			{
				c1DockingTab.TabPageClosed -= value;
				c1DockingTab.TabPageClosing -= value2;
			}
			this.o_O_0Oo0.0O0O. = A_0;
			c1DockingTab = this.o_O_0Oo0.0O0O.;
			if (c1DockingTab != null)
			{
				c1DockingTab.TabPageClosed += value;
				c1DockingTab.TabPageClosing += value2;
			}
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x00184596 File Offset: 0x00182796
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.OO0Ooo.ooo_.;
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x001845A0 File Offset: 0x001827A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			TabPageEventHandler value = new TabPageEventHandler(this.Oo._oO0Oo_0.);
			TabPageCancelEventHandler value2 = new TabPageCancelEventHandler(this.O.O00OOOo0_.);
			C1DockingTab oo0Ooo.ooo_. = this.OO0Ooo.ooo_.;
			if (oo0Ooo.ooo_. != null)
			{
				oo0Ooo.ooo_..TabPageClosed -= value;
				oo0Ooo.ooo_..TabPageClosing -= value2;
			}
			this.OO0Ooo.ooo_. = A_0;
			oo0Ooo.ooo_. = this.OO0Ooo.ooo_.;
			if (oo0Ooo.ooo_. != null)
			{
				oo0Ooo.ooo_..TabPageClosed += value;
				oo0Ooo.ooo_..TabPageClosing += value2;
			}
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x001845FE File Offset: 0x001827FE
		[CompilerGenerated]
		internal virtual FileSystemWatcher <<EMPTY_NAME>>()
		{
			return this.o_o0o0OO.O.;
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x00184608 File Offset: 0x00182808
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(FileSystemWatcher A_0)
		{
			FileSystemEventHandler value = new FileSystemEventHandler(this.Oo._oO0Oo_0.);
			FileSystemWatcher fileSystemWatcher = this.o_o0o0OO.O.;
			if (fileSystemWatcher != null)
			{
				fileSystemWatcher.Created -= value;
			}
			this.o_o0o0OO.O. = A_0;
			fileSystemWatcher = this.o_o0o0OO.O.;
			if (fileSystemWatcher != null)
			{
				fileSystemWatcher.Created += value;
			}
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x0018464C File Offset: 0x0018284C
		internal void <<EMPTY_NAME>>()
		{
			int num2;
			int num5;
			object obj2;
			try
			{
				IL_00:
				int num = 1;
				if (this.O.OOO0_OOo.() == null)
				{
					goto IL_2E;
				}
				IL_0A:
				num = 2;
				this.O.OOO0_OOo.().EnableRaisingEvents = false;
				IL_18:
				num = 3;
				this.O.OOO0_OOo.().Dispose();
				IL_25:
				num = 4;
				this.Oo__.ooOo00_Oo.(null);
				IL_2E:
				num = 5;
				this.O0.0000oO.(O_O0OO.O0_00o.o0__o..ControlTheme);
				IL_40:
				num = 6;
				this.OoO_oo00o0.Oo.(O_O0OO.O0_00o.o0__o..RibbonTheme);
				IL_52:
				num = 7;
				if (Operators.CompareString(this.O.OOO0_OOo.().Font.Name, O_O0OO.O0_00o.o0__o..GetRibbonFontName, true) == 0 && this.O.OOO0_OOo.().Font.Size == (float)O_O0OO.O0_00o.o0__o..GetRibbonFontSize)
				{
					goto IL_CA;
				}
				IL_93:
				num = 8;
				this.O.OOO0_OOo.().Font = new Font(O_O0OO.O0_00o.o0__o..GetRibbonFontName, (float)O_O0OO.O0_00o.o0__o..GetRibbonFontSize, this.O.OOO0_OOo.().Font.Style);
				IL_CA:
				num = 9;
				this.oOO0.OOoo0oO. = null;
				IL_D4:
				num = 10;
				if (!base.Visible)
				{
					goto IL_EE;
				}
				IL_DF:
				num = 11;
				ShareLibriay.LockWindowUpdate(base.Handle);
				IL_EE:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_F5:
				num = 13;
				this.OO_O_0Oo.___o.().Visible = false;
				IL_104:
				num = 14;
				if (this.o._oOO0..O0oo_0_.__0__.() == null)
				{
					goto IL_158;
				}
				IL_114:
				num = 15;
				IEnumerator<Foxtable.Table> enumerator = this.o._oOO0..O0oo_0_.__0__.().GetEnumerator();
				while (enumerator.MoveNext())
				{
					Foxtable.Table a_ = enumerator.Current;
					IL_134:
					num = 16;
					o_O_o_oOoo__.oo.O0o0o.(a_);
					IL_13E:
					num = 17;
				}
				IL_14A:
				num = 18;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_158:
				num = 19;
				this.o__OO_.Ooo0_. = true;
				IL_162:
				num = 20;
				if (this.OO_O_0Oo.___o.().TabPages.Count <= 0)
				{
					goto IL_4B1;
				}
				IL_17B:
				num = 21;
				for (int i = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1; i >= 0; i += -1)
				{
					IL_19B:
					num = 22;
					C1DockingTabPage c1DockingTabPage = Main.OO_O.o..OO_O_0Oo.___o.().TabPages[i];
					IL_1B6:
					num = 23;
					Oo0__Oo oo0__Oo = (Oo0__Oo)c1DockingTabPage;
					IL_1C2:
					num = 24;
					Foxtable.Table table = oo0__Oo.O_000__.o.();
					IL_1CE:
					num = 25;
					oo0__Oo.O_000__.o.(null);
					IL_1D9:
					num = 26;
					oo0__Oo.O_000__.o.(null);
					IL_1E4:
					num = 27;
					OO___OO0O_0 oo___OO0O_ = (OO___OO0O_0)oo0__Oo.Controls[0];
					IL_1FB:
					num = 28;
					IEnumerator enumerator2 = oo___OO0O_.TabPages[0].Controls.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
						IL_22A:
						num = 29;
						if (control is o_O0_0O0)
						{
							IL_239:
							num = 30;
							for (int j = control.Controls.Count - 1; j >= 0; j += -1)
							{
								IL_251:
								num = 31;
								System.Windows.Forms.Control control2 = control.Controls[j];
								IL_264:
								num = 32;
								if (control2 is OO___OO0O_0)
								{
									IL_273:
									num = 33;
									OO___OO0O_0 oo___OO0O_2 = (OO___OO0O_0)control2;
									IL_27F:
									num = 34;
									for (int k = oo___OO0O_2.TabPages.Count - 1; k >= 0; k += -1)
									{
										IL_297:
										num = 35;
										C1DockingTabPage c1DockingTabPage2 = oo___OO0O_2.TabPages[k];
										IL_2AA:
										num = 36;
										if (c1DockingTabPage2.Controls.Count > 0 && c1DockingTabPage2.Controls[0] is O_oOooO_O)
										{
											IL_2D3:
											num = 37;
											O_oOooO_O o_oOooO_O = (O_oOooO_O)c1DockingTabPage2.Controls[0];
											IL_2EA:
											num = 38;
											O_0 o_ = o_oOooO_O.o.0O_O0o_..View;
											IL_2FB:
											num = 39;
											o_oOooO_O.o.0O_O0o_..foxGrid = null;
											IL_30B:
											num = 40;
											o_oOooO_O.o.0O_O0o_. = null;
											IL_316:
											num = 41;
											o_oOooO_O.SetDataBinding(null, null);
											IL_322:
											num = 42;
											o_.Dispose();
											IL_32C:
											num = 43;
											o_oOooO_O.o.o0OO00oO_0.();
											IL_336:
											num = 44;
											o_oOooO_O.Controls.Clear();
											IL_345:
											num = 45;
											o_oOooO_O.Dispose();
										}
										IL_34F:
										num = 46;
										c1DockingTabPage2.Controls.Clear();
										IL_35E:
										num = 47;
										((OO___OO0O_0)control2).TabPages.RemoveAt(k);
										IL_374:
										num = 48;
										c1DockingTabPage2.Dispose();
										IL_37E:
										num = 49;
									}
									IL_38F:
									num = 50;
									oo___OO0O_2.TabPages.Clear();
									IL_39E:
									num = 51;
									oo___OO0O_2.Dispose();
									IL_3A8:
									oo___OO0O_2 = null;
								}
								IL_3AB:
								num = 53;
							}
							IL_3BC:
							num = 54;
							o_O0_0O0 o_O0_0O = (o_O0_0O0)control;
							IL_3C8:
							num = 55;
							o_O0_0O.OoOoo_O0o0.0O_.(null);
							IL_3D3:
							o_O0_0O = null;
						}
						IL_3D6:
						num = 57;
					}
					IL_3E5:
					num = 58;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
					IL_3FD:
					num = 59;
					oo0__Oo.Controls.Clear();
					IL_40C:
					num = 60;
					if (table != null)
					{
						IL_413:
						num = 61;
						O_oOooO_O o_oOooO_O2 = table.foxGrid;
						IL_41F:
						num = 62;
						O_0 o_2 = table.View;
						IL_42B:
						num = 63;
						table.foxGrid = null;
						IL_436:
						num = 64;
						o_oOooO_O2.o.0O_O0o_. = null;
						IL_441:
						num = 65;
						o_oOooO_O2.SetDataBinding(null, null);
						IL_44D:
						num = 66;
						o_2.Dispose();
						IL_457:
						num = 67;
						o_oOooO_O2.o.o0OO00oO_0.();
						IL_461:
						num = 68;
						o_oOooO_O2.Controls.Clear();
						IL_470:
						num = 69;
						o_oOooO_O2.Dispose();
					}
					IL_47A:
					oo0__Oo = null;
					IL_47D:
					num = 71;
					Main.OO_O.o..OO_O_0Oo.___o.().TabPages.RemoveAt(i);
					IL_496:
					num = 72;
					c1DockingTabPage.Dispose();
					IL_4A0:
					num = 73;
				}
				IL_4B1:
				num = 74;
				this.o__OO_.Ooo0_. = false;
				IL_4BB:
				num = 75;
				this.o._oOO0..o.o_0O00o0_.();
				IL_4C9:
				num = 76;
				this.OO_O_0Oo.___o.().TabPages.Clear();
				IL_4DC:
				num = 77;
				OO_00oOO.O_0.oooO__O. = null;
				IL_4E5:
				num = 78;
				OO_00oOO.oOO.0_. = null;
				IL_4EE:
				num = 79;
				O_O0OO.O00O0o_O_._O. = true;
				IL_4F7:
				num = 80;
				O_O0OO.O0_00o.o0__o..ApplicationName = o0OO__.O.0ooOoO_0_.("DataView");
				IL_50E:
				num = 81;
				IEnumerator<Foxtable.Table> enumerator3 = OO_00oOO.Tables.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					Foxtable.Table table2 = enumerator3.Current;
					IL_52B:
					num = 82;
					if (!table2.IsRelation)
					{
						IL_53A:
						num = 84;
						if (!table2.Name.StartsWith("_") && Operators.CompareString(o0OoOOoOOo0.o0.ooO_o__O0OO., "", true) > 0)
						{
							IL_563:
							num = 85;
							Main.ProcessForm.o0__.Oo0O_O0O_.(o0OoOOoOOo0.o0.ooO_o__O0OO..Replace("{0}", table2.Name));
						}
						IL_586:
						num = 86;
						Application.DoEvents();
						IL_58E:
						num = 87;
						IEnumerator<Foxtable.Table> enumerator4 = OO_00oOO.Tables.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							Foxtable.Table table3 = enumerator4.Current;
							IL_5AB:
							num = 88;
							if (table3.IsRelation)
							{
								IL_5BA:
								num = 90;
								if (table3.Name.StartsWith(table2.Name + "."))
								{
									IL_5DC:
									num = 91;
									table3.foxGrid.Visible = false;
									IL_5EC:
									num = 92;
									base.Controls.Add(table3.foxGrid);
									IL_601:
									num = 93;
									table3.O.__O0o0.(true);
									IL_60D:
									num = 94;
									base.Controls.Remove(table3.foxGrid);
									IL_622:
									num = 95;
									table3.foxGrid.Visible = true;
									IL_632:
									num = 96;
									table3.foxGrid.Cols.DefaultSize = 98;
								}
							}
							IL_648:
							num = 97;
						}
						IL_657:
						num = 98;
						if (enumerator4 != null)
						{
							enumerator4.Dispose();
						}
						IL_665:
						num = 99;
						Oo0__Oo value = new Oo0__Oo(table2);
						IL_671:
						num = 100;
						this.OO_O_0Oo.___o.().TabPages.Add(value);
						IL_687:
						num = 101;
						table2.oO_o_0o._0oooo.(true);
						IL_692:
						num = 102;
						table2.O.__O0o0.(true);
						IL_69E:
						num = 103;
						table2.foxGrid.o_.o. = table2.foxGrid.BottomRow;
						IL_6B9:
						num = 104;
						table2.foxGrid.Cols.DefaultSize = 98;
					}
					IL_6CF:
					num = 105;
				}
				IL_6DE:
				num = 106;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_6EC:
				num = 107;
				IEnumerator<Foxtable.Table> enumerator5 = OO_00oOO.Tables.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					Foxtable.Table table4 = enumerator5.Current;
					IL_709:
					num = 108;
					if (table4.IsRelation)
					{
						IL_715:
						num = 109;
						if (table4.foxGrid.FindForm() == null)
						{
							IL_729:
							num = 111;
							if (table4._frdAutoOpen)
							{
								IL_735:
								num = 112;
								table4.Visible = true;
							}
							IL_740:
							num = 113;
							table4.foxGrid.o_.o. = table4.foxGrid.BottomRow;
						}
					}
					else
					{
						IL_760:
						num = 115;
						if (table4.TableType == TableTypeEnum.Normal && !table4.View.O0O.o__0.())
						{
							IL_780:
							num = 116;
							IEnumerator<Col> enumerator6 = table4.Cols.GetEnumerator();
							while (enumerator6.MoveNext())
							{
								Col col = enumerator6.Current;
								IL_79C:
								num = 117;
								if (col.DataCol.ExtendType == ExtendTypeEnum.Images || col.DataCol.ExtendType == ExtendTypeEnum.Files || (col.DataCol.IsString && (col.DataCol.MaxLength == -1 || col.DataCol.MaxLength > 2048)))
								{
									IL_7ED:
									num = 118;
									if (col.DataCol.AutoOpen)
									{
										IL_7FE:
										num = 119;
										col.OpenWindow(0);
									}
								}
								IL_809:
								num = 120;
							}
							IL_818:
							num = 121;
							if (enumerator6 != null)
							{
								enumerator6.Dispose();
							}
						}
					}
					IL_826:
					num = 122;
				}
				IL_835:
				num = 123;
				if (enumerator5 != null)
				{
					enumerator5.Dispose();
				}
				IL_843:
				num = 124;
				O_O0OO.O0_00o.o0__o..O_.Oo_o_.();
				IL_850:
				num = 125;
				this.oO_0_.oO. = this.o0_o_o_0.0O.(false);
				IL_860:
				num = 126;
				if (this.oO_0_.oO. == 2)
				{
					goto IL_875;
				}
				IL_86C:
				num = 127;
				this.OOoO0O_o_o.0_0.();
				IL_875:
				num = 128;
				IEnumerator<DataTable> enumerator7 = OO_00oOO.DataTables.GetEnumerator();
				while (enumerator7.MoveNext())
				{
					DataTable dataTable = enumerator7.Current;
					IL_892:
					num = 129;
					dataTable.o._o_O_.();
					IL_89F:
					num = 130;
				}
				IL_8AE:
				num = 131;
				if (enumerator7 != null)
				{
					enumerator7.Dispose();
				}
				IL_8BF:
				num = 132;
				if (this.OO_O_0Oo.___o.().TabPages.Count != 0)
				{
					goto IL_997;
				}
				IL_8DA:
				num = 133;
				string text = "一二三四五六七八九十";
				IL_8E7:
				num = 134;
				DataTableBuilder dataTableBuilder = new DataTableBuilder("表1");
				IL_8F9:
				num = 135;
				int num3 = 1;
				do
				{
					IL_902:
					num = 136;
					dataTableBuilder.AddDef("第" + Conversions.ToString(text[num3 - 1]) + "列", typeof(string), 32);
					IL_93A:
					num = 137;
					num3++;
				}
				while (num3 <= 10);
				IL_94C:
				num = 138;
				dataTableBuilder.Build(false);
				IL_95B:
				num = 139;
				OO_00oOO.Tables["表1"].AddNew(10);
				IL_978:
				num = 140;
				OO_00oOO.DataTables["表1"].BaseTable.AcceptChanges();
				IL_997:
				num = 141;
				this.OO_O_0Oo.___o.().Visible = true;
				IL_9A9:
				num = 142;
				string a_2 = "LoadUserSetting_" + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_9CA:
				num = 143;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_2, null, true, this.o._oOO0., false);
				IL_9E5:
				num = 144;
				this.OO_O_0Oo.___o.().ShowTabs = O_O0OO.O0_00o.o0__o..ShowTableCaption;
				IL_A00:
				num = 145;
				this.OO_O_0Oo.___o.().CanMoveTabs = O_O0OO.O0_00o.o0__o..AllowMoveTable;
				IL_A1B:
				num = 146;
				this.OO_O_0Oo.___o.().ShowTabList = O_O0OO.O0_00o.o0__o..ShowTableList;
				IL_A36:
				num = 147;
				this.OO_O_0Oo.___o.().CanCloseTabs = O_O0OO.O0_00o.o0__o..ShowCloseButton;
				IL_A51:
				num = 148;
				this.OO_O_0Oo.___o.().CloseBox = O_O0OO.O0_00o.o0__o..CloseButton;
				IL_A6C:
				num = 149;
				Dictionary<string, O_0>.ValueCollection.Enumerator enumerator8 = O_O0OO.o__.O.().Values.GetEnumerator();
				while (enumerator8.MoveNext())
				{
					O_0 o_3 = enumerator8.Current;
					IL_A8E:
					num = 150;
					if (o_3.O0OOO_0.o.() && !o_3.O0O_0_0__.0O.().o_oo._0Oo.())
					{
						IL_AAB:
						num = 151;
						o_3.set_Filter(o_3.get_Filter());
					}
					IL_ABF:
					num = 152;
				}
				IL_ACE:
				num = 153;
				((IDisposable)enumerator8).Dispose();
				IL_AE1:
				num = 154;
				IEnumerator<Foxtable.Table> enumerator9 = OO_00oOO.Tables.GetEnumerator();
				while (enumerator9.MoveNext())
				{
					Foxtable.Table table5 = enumerator9.Current;
					IL_AFE:
					num = 155;
					if (table5.Grid.FindForm() != null)
					{
						IL_B12:
						num = 156;
						if (table5.Grid.RowSel == table5.Grid.Rows.Fixed)
						{
							IL_B37:
							num = 157;
							table5.Grid.ScrollPosition = new Point(0, 0);
						}
					}
					IL_B50:
					num = 158;
				}
				IL_B5F:
				num = 159;
				if (enumerator9 != null)
				{
					enumerator9.Dispose();
				}
				IL_B70:
				num = 160;
				O_O0OO.O0_00o.o0__o..o_0.O0o_o00o_. = O00.oO_.0o_oo_0O_.(O_O0OO.O0_00o.o0__o..OO.0O.(), "ribbon", "code");
				IL_B99:
				num = 161;
				O_O0OO.O0_00o.o0__o..O_.0__O_000. = O00.oO_.0o_oo_0O_.(O_O0OO.O0_00o.o0__o..OooO.O0.(), "ribbon", "code");
				IL_BC2:
				num = 162;
				if (!base.Visible)
				{
					goto IL_BE1;
				}
				IL_BD0:
				num = 163;
				ShareLibriay.LockWindowUpdate(IntPtr.Zero);
				IL_BE1:
				num = 164;
				if (this.OO_O_0Oo.___o.().SelectedTab == null)
				{
					goto IL_C29;
				}
				IL_BF4:
				num = 165;
				if (this.OO_O_0Oo.___o.().SelectedTab.Controls.Count <= 0)
				{
					goto IL_C29;
				}
				IL_C12:
				num = 166;
				this.OO_O_0Oo.___o.().SelectedTab.Focus();
				IL_C29:
				num = 167;
				OO_00oOO.Vars["SysUpdatePrintInfo"] = true;
				IL_C44:
				num = 168;
				Main.O0O_.00_O0Oo_.();
				IL_C4F:
				num = 169;
				if (this.O0o__0_OO.o.().TabPages.Count != 0)
				{
					goto IL_C79;
				}
				IL_C67:
				num = 170;
				this.O0o__0_OO.o.().Visible = false;
				IL_C79:
				num = 171;
				this.oOo_000oo_.0.();
				IL_C85:
				num = 172;
				if (O_O0OO.O0_00o.o0__o..MaxForm)
				{
					goto IL_D67;
				}
				IL_C9A:
				num = 173;
				ooO.SetForegroundWindow(base.Handle);
				IL_CAC:
				num = 174;
				if (!O_O0OO.O0_00o.o0__o..AllowResize)
				{
					goto IL_CCD;
				}
				IL_CBE:
				num = 175;
				base.FormBorderStyle = FormBorderStyle.Sizable;
				goto IL_CDA;
				IL_CCD:
				num = 177;
				base.FormBorderStyle = FormBorderStyle.FixedDialog;
				IL_CDA:
				num = 178;
				base.WindowState = FormWindowState.Normal;
				IL_CE7:
				num = 179;
				base.Size = new Size(Math.Max(400, O_O0OO.O0_00o.o0__o..FormWidth), Math.Max(400, O_O0OO.O0_00o.o0__o..FormHeight));
				IL_D20:
				num = 180;
				base.WindowState = FormWindowState.Normal;
				IL_D2D:
				num = 181;
				base.MaximizeBox = O_O0OO.O0_00o.o0__o..MaximizeBox;
				IL_D43:
				num = 182;
				base.MinimizeBox = O_O0OO.O0_00o.o0__o..MinimizeBox;
				IL_D59:
				num = 183;
				base.CenterToScreen();
				goto IL_D86;
				IL_D67:
				num = 185;
				ooO.SetForegroundWindow(base.Handle);
				IL_D79:
				num = 186;
				base.WindowState = FormWindowState.Maximized;
				IL_D86:
				num = 187;
				if (OO_00oOO.User.Type != UserTypeEnum.Developer || !O_O0OO.o00.0.(O_O0OO.O0_00o.o0__o.))
				{
					goto IL_DB1;
				}
				IL_DA4:
				num = 188;
				base.WindowState = FormWindowState.Maximized;
				IL_DB1:
				num = 189;
				this.oOO0.OOoo0oO. = DateTime.Now;
				IL_DC2:
				num = 190;
				this.Oo__.ooOo00_Oo.(new FileSystemWatcher());
				IL_DD3:
				num = 191;
				this.O.OOO0_OOo.().Path = OO_00oOO.ProjectPath + "Bin";
				IL_DF3:
				num = 192;
				this.O.OOO0_OOo.().EnableRaisingEvents = true;
				IL_E05:
				goto IL_115B;
				IL_E0A:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_111C:
				goto IL_1150;
				IL_111E:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_112E:;
			}
			catch when (endfilter(obj2 is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_111E;
			}
			IL_1150:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_115B:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x001857D8 File Offset: 0x001839D8
		internal void <<EMPTY_NAME>>(DataRelation A_0, bool A_1)
		{
			string value = string.Concat(new string[]
			{
				".",
				A_0.ParentTable.TableName,
				".",
				A_0.ChildTable.TableName,
				"."
			});
			string value2 = string.Concat(new string[]
			{
				".",
				A_0.ChildTable.TableName,
				".",
				A_0.ParentTable.TableName,
				"."
			});
			try
			{
				foreach (object obj in this.OO_O_0Oo.___o.().TabPages)
				{
					Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
					try
					{
						foreach (Foxtable.Table table in OO_00oOO.Tables)
						{
							if (table.View.O0O_0_0__.0O.() != null)
							{
								string text = "." + table.View.Oo._Oo0OO.() + ".";
								if ((text.IndexOf(value) >= 0 || (text.IndexOf(value2) >= 0 && table.foxGrid.FindForm() == null)) && table.View.Oo._Oo0OO.().StartsWith(oo0__Oo.Name + ".") && table.foxGrid.FindForm() == null)
								{
									if (A_1)
									{
										oo0__Oo.O._o_00__.().OO_o0_oO.0.(table, false);
									}
									table.O.__O0o0.(true);
									table.foxGrid.Cols.DefaultSize = 98;
								}
							}
						}
					}
					finally
					{
						IEnumerator<Foxtable.Table> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
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
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x001859C0 File Offset: 0x00183BC0
		internal void <<EMPTY_NAME>>()
		{
			if (this.O.OOO0_OOo.().SelectedTab == null && this.O.OOO0_OOo.().Tabs.Count > 0)
			{
				int num = this.O.OOO0_OOo.().Tabs.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (this.O.OOO0_OOo.().Tabs[i].Visible && this.O.OOO0_OOo.().Tabs[i].Enabled)
					{
						this.O.OOO0_OOo.().SelectedTabIndex = i;
						return;
					}
				}
			}
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x00185A4C File Offset: 0x00183C4C
		internal void <<EMPTY_NAME>>()
		{
			OO___OO0O_0 oo___OO0O_ = this.OO_O_0Oo.___o.();
			oo___OO0O_.SuspendLayout();
			oo___OO0O_.Alignment = O_O0OO.O0_00o.o0__o..TabPosition;
			oo___OO0O_.AlignTabs = O_O0OO.O0_00o.o0__o..TabAlign;
			oo___OO0O_.MultiLine = O_O0OO.O0_00o.o0__o..MultiLine;
			oo___OO0O_.TextDirection = O_O0OO.O0_00o.o0__o..TextDirection;
			oo___OO0O_.TabLayout = O_O0OO.O0_00o.o0__o..TabLayout;
			oo___OO0O_.TabsSpacing = O_O0OO.O0_00o.o0__o..TabsSpacing;
			oo___OO0O_.ResumeLayout();
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x00185ACC File Offset: 0x00183CCC
		internal int <<EMPTY_NAME>>(bool A_0 = false)
		{
			bool a_ = OO_00oOO.SystemReady;
			int result;
			try
			{
				OO_00oOO.SystemReady = false;
				if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()].Rows.Count <= 6 || A_0 || (OO_00oOO.User.Type == UserTypeEnum.Developer && OO_00oOO.ModifierKey == Keys.Control))
				{
					if (this.OOO_O_OOO.oooo.)
					{
						if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
						{
							this.Text = "Foxtable - 新项目";
						}
						else
						{
							this.Text = "Foxtable - " + c.OOOOO.o.().FileSystem.GetName(OO_00oOO.ProjectFile);
						}
						return 0;
					}
					OO_00oOO.SystemMenu = true;
					this.OOO_O_OOO.oooo. = true;
					O_O0OO.o0OoO00OO.00O. = null;
					if (!c.OOOOO.o.().FileSystem.FileExists(O_O0OO.O0OO_oOo_._o0_.()))
					{
						MessageBox.Show("系统菜单文件不存在或者已经被删除，无法生成菜单！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return 0;
					}
					O_O0OO.OOo_o.0o. = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath) + "\\Images\\";
					OleDbConnection selectConnection = new OleDbConnection(Oo00.o_._0OOo.(O_O0OO.O0OO_oOo_._o0_.()));
					OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From [" + ooO0__OO.OO0o.OO_OoOO0.() + "]", selectConnection);
					this.oO_0_.oO. = new DataTable();
					oleDbDataAdapter.FillSchema(this.oO_0_.oO., SchemaType.Source);
					oleDbDataAdapter.Fill(this.oO_0_.oO.);
					string text = O_O0OO.o.00O_O.() + "Bin\\Foxtable.Ribbon.dll";
					if (OO_00oOO.FileSys.FileExists(text))
					{
						O_O0OO.o0OoO00OO.00O. = Assembly.Load(File.ReadAllBytes(text));
					}
					else
					{
						O_O0OO.o0OoO00OO.00O. = o0_.Oo_0.OOo0oO0.(this.oO_0_.oO., "", "", new string[]
						{
							"Key"
						}, "Ribbon", text, null, null);
					}
				}
				else
				{
					this.OOO_O_OOO.oooo. = false;
					OO_00oOO.SystemMenu = false;
					string text2 = OO_00oOO.ProjectPath + "Bin\\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Ribbon.dll";
					this.oO_0_.oO. = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.oo._o.()];
					if (OO_00oOO.FileSys.FileExists(text2))
					{
						O_O0OO.o0OoO00OO.00O. = Assembly.Load(File.ReadAllBytes(text2));
					}
					else
					{
						O_O0OO.o0OoO00OO.00O. = o0_.Oo_0.OOo0oO0.(this.oO_0_.oO., "", "", new string[]
						{
							"Key"
						}, "Ribbon", text2, O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], null);
					}
				}
				o_Oo_o0O o_Oo_o0O = new o_Oo_o0O();
				Ribbon ribbon = new Ribbon(this.oO_0_.oO.);
				o_Oo_o0O.o._o0ooOOO.(this.O.OOO0_OOo.(), O_O0OO.o.00O_O.(), this.O.OOO0_OOo.(), ribbon);
				this.O.OOO0_OOo.().HideTabHeaderRow = !this.O.OOO0_OOo.().HideTabHeaderRow;
				this.O.OOO0_OOo.().HideTabHeaderRow = !this.O.OOO0_OOo.().HideTabHeaderRow;
				O_O0OO.OOo_o.0o. = true;
				string a_2 = "Load_" + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_2, new object[0], true, this.o._oOO0., false);
				result = Conversions.ToInteger(Interaction.IIf(ribbon.Minimized, 2, 1));
			}
			catch (Exception a_3)
			{
				ooO.oOo0Oo.o.(a_3, "");
			}
			finally
			{
				OO_00oOO.SystemReady = a_;
				O_O0OO.OOo_o.0o. = c.OOOOO.o.().FileSystem.GetParentPath(OO_00oOO.ProjectFile) + "\\Images\\";
			}
			return result;
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x00185E7C File Offset: 0x0018407C
		internal Oo0__Oo <<EMPTY_NAME>>(string A_0)
		{
			try
			{
				foreach (object obj in this.OO_O_0Oo.___o.().TabPages)
				{
					Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
					if (Operators.CompareString(oo0__Oo.Name, A_0, true) == 0)
					{
						return oo0__Oo;
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
			return null;
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x00185EEC File Offset: 0x001840EC
		internal void <<EMPTY_NAME>>(string A_0, bool A_1 = true, bool A_2 = false)
		{
			OO_00oOO.Tables[A_0].StopRedraw();
			Oo0__Oo oo0__Oo = new Oo0__Oo(OO_00oOO.Tables[A_0]);
			oo0__Oo.TabVisible = A_1;
			this.OO_O_0Oo.___o.().TabPages.Add(oo0__Oo);
			OO_00oOO.Tables[A_0].oO_o_0o._0oooo.(true);
			OO_00oOO.Tables[A_0].O.__O0o0.(A_2);
			OO_00oOO.Tables[A_0].foxGrid.Cols.DefaultSize = 98;
			OO_00oOO.Tables[A_0].ResumeRedraw();
			if (!A_2)
			{
				O_oOooO_O o_oOooO_O = OO_00oOO.Tables[A_0].foxGrid;
				int @fixed = o_oOooO_O.Cols.Fixed;
				int num = o_oOooO_O.Cols.Count - 1;
				for (int i = @fixed; i <= num; i++)
				{
					if (o_oOooO_O.Cols[i].DataType == typeof(double) || o_oOooO_O.Cols[i].DataType == typeof(decimal) || o_oOooO_O.Cols[i].DataType == typeof(float))
					{
						o_oOooO_O.Cols[i].Format = "#0.####";
					}
				}
			}
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x0018602C File Offset: 0x0018422C
		private void <<EMPTY_NAME>>(object A_0, ControlEventArgs A_1)
		{
			if (OO_00oOO.SystemReady)
			{
				this.o_0.O.();
			}
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x0018603C File Offset: 0x0018423C
		internal void <<EMPTY_NAME>>()
		{
			Foxtable.Table table = OO_00oOO.MainTable;
			if (this.OO_O_0Oo.___o.().SelectedTab != null)
			{
				if (this.OO_O_0Oo.___o.().ShowTabs)
				{
					this.oo.0o0. = true;
				}
				if (this.OO_O_0Oo.___o.().SelectedIndex >= 0 && !this.OO_O_0Oo.___o.().SelectedTab.TabVisible)
				{
					int num = this.OO_O_0Oo.___o.().TabPages.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (this.OO_O_0Oo.___o.().TabPages[i].TabVisible)
						{
							this.OO_O_0Oo.___o.().SelectedIndex = i;
							return;
						}
					}
				}
				int selectedIndex = this.OO_O_0Oo.___o.().SelectedIndex;
				C1DockingTabPage c1DockingTabPage = null;
				if (selectedIndex >= 0 && this.OO_O_0Oo.___o.().TabPages[selectedIndex].TabVisible)
				{
					c1DockingTabPage = this.OO_O_0Oo.___o.().TabPages[selectedIndex];
				}
				if (c1DockingTabPage != null && OO_00oOO.Tables != null && OO_00oOO.Tables.get_Contains(c1DockingTabPage.Name))
				{
					O_oOooO_O o_oOooO_O = OO_00oOO.Tables[c1DockingTabPage.Name].foxGrid;
					if (o_oOooO_O.FindForm() != null)
					{
						if (o_oOooO_O.FindForm() is DropDownForm)
						{
							o_oOooO_O.FindForm().Controls.Clear();
						}
						else if (o_oOooO_O.FindForm() != this)
						{
							o_oOooO_O.FindForm().Close();
							oOO0oo_o0.o.O0o000_.(o_oOooO_O);
						}
					}
					Foxtable.Table table2 = OO_00oOO.Tables[c1DockingTabPage.Name];
					if (OO_00oOO.MainTable != table2)
					{
						OO_00oOO.MainTable = table2;
						OO_00oOO.MainTable = OO_00oOO.Tables[c1DockingTabPage.Name];
					}
				}
				else
				{
					OO_00oOO.O_0.oooO__O. = null;
					OO_00oOO.CurrentTable = null;
				}
				if (table != OO_00oOO.MainTable)
				{
					Foxtable.Table table3 = OO_00oOO.MainTable;
					SystemEventTypeEnum[] array = new SystemEventTypeEnum[4];
					RuntimeHelpers.InitializeArray(array, fieldof(global::b.o00_.oO_.).FieldHandle);
					OO_00oOO.RaiseSystemEvent(table3, array);
					if (OO_00oOO.SystemReady && OO_00oOO.MainTable != null)
					{
						OO_00oOO.MainTable.View.o_._0O0o_OoO.();
						OO_00oOO.MainTable.View.Oo._Oo0OO.();
					}
				}
			}
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x00186230 File Offset: 0x00184430
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (OO_00oOO.SystemReady)
			{
				if (this.OO_O_0Oo.___o.().ShowTabs)
				{
					this.oo.0o0. = true;
				}
				this.o_0.O.();
			}
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x00186254 File Offset: 0x00184454
		private void <<EMPTY_NAME>>(object A_0, SelectedIndexChangingEventArgs A_1)
		{
			if (OO_00oOO.SystemReady && OO_00oOO.MainTable != null && A_1.NewIndex != -1)
			{
				string name = this.OO_O_0Oo.___o.().TabPages[A_1.NewIndex].Name;
				string a_ = OO_00oOO.MainTable.Name;
				MaintableChangingEventArgs maintableChangingEventArgs = new MaintableChangingEventArgs(a_, name);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "MainTableChanging", new object[]
				{
					maintableChangingEventArgs
				}, false, "项目", false);
				A_1.Cancel = maintableChangingEventArgs.Cancel;
				if (!A_1.Cancel)
				{
					bool flag;
					do
					{
						flag = false;
						try
						{
							foreach (object obj in Application.OpenForms)
							{
								System.Windows.Forms.Form form = (System.Windows.Forms.Form)obj;
								if (form is ef || form is O\u3002\u3000\u3002\u3002)
								{
									flag = true;
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
					}
					while (flag);
				}
			}
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x00186354 File Offset: 0x00184554
		public jk()
		{
			int a_ = 1;
			base..ctor();
			base.FormClosed += this.o0oO_O.0Oo_00.;
			base.FormClosing += this.o0oO_O.0Oo_00.;
			base.KeyDown += this.o0oO_O.0Oo_00.;
			base.Load += this.oO_oOo_0_.o.;
			base.SizeChanged += this.Oo.O000_oO__o.;
			this.oO_0_.oO. = null;
			this.oOO0.OOoo0oO. = BooleanEnum.Default;
			this.o0O.OO. = false;
			this.o._oOO0. = new oooO0o000O();
			this.o_O_0Oo0.0O0O. = DateTime.Now;
			this.o._oOO0. = O00OOOo_O0_O.b("㡠뎶", a_);
			this.O.0_0O___Oo. = O00OOOo_O0_O.b("㡠뎶쓧", a_);
			try
			{
				foreach (string text in OO_00oOO.FileSys.GetFiles(O_O0OO.o.00O_O.() + O00OOOo_O0_O.b("郣軥跧蟩觫鷭곯", a_), Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, new string[]
				{
					O00OOOo_O0_O.b("컣죥诧\udbe9飫蛭闯鿱釳賵", a_)
				}))
				{
					if (text.IndexOf(O00OOOo_O0_O.b("⮝麴", a_)) <= 0)
					{
						if (Operators.CompareString(OO_00oOO.FileSys.GetName(text), O00OOOo_O0_O.b("ꯣ胥軧菩迫语싯싱엳엵뿷裹駻鯽滿Ⰱ會㜅簇戉椋挍甏树", a_), true) == 0)
						{
							C1ThemeController.UnregisterTheme(O00OOOo_O0_O.b("ꯣ胥軧菩迫语싯싱엳엵뿷裹駻鯽滿", a_));
						}
						C1ThemeController.RegisterTheme(text);
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
			this.oO_0_.oO. = C1ThemeController.GetThemeByName(O00OOOo_O0_O.b("ꯣ胥軧菩迫语싯싱엳엵뿷裹駻鯽滿", a_), false).Children[O00OOOo_O0_O.b("꟣ퟥ뫧菩軫賭鿯鳱", a_)].Children[O00OOOo_O0_O.b("ꏣ铥蟧鿩鳫鷭", a_)].Children[O00OOOo_O0_O.b("ꋣ觥蛧黩", a_)];
			this.OOO.O_Oo0.();
			C1ThemeController.ApplicationTheme = O00OOOo_O0_O.b("닣뗥\udae7\udae9\uddeb\udded럯胱釳鏵雷", a_);
			if (Operators.CompareString(this.O.OOO0_OOo.().Font.Name, O_O0OO.oo_oo_o._., true) != 0 || this.O.OOO0_OOo.().Font.Size != (float)O_O0OO.oO_00Ooo___0._.)
			{
				this.O.OOO0_OOo.().Font = new Font(O_O0OO.oo_oo_o._., (float)O_O0OO.oO_00Ooo___0._., this.O.OOO0_OOo.().Font.Style);
			}
			this.OO_O_0Oo.___o.().TabSizeMode = TabSizeModeEnum.Normal;
			Application.Idle += this.O0oo.o_o__oO0.;
			OO_00oOO.MainTableChanged += this.o_o.0.;
			OO_00oOO.CurrentTableChanged += this.o0._Oo.;
			base.Activate();
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x001865FC File Offset: 0x001847FC
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			int num2;
			int num4;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				Application.Idle -= this.O0oo.o_o__oO0.;
				IL_13:
				num = 2;
				OO_00oOO.MainTableChanged -= this.o_o.0.;
				IL_26:
				num = 3;
				OO_00oOO.CurrentTableChanged -= this.o0._Oo.;
				IL_39:
				num = 4;
				if (DateTime.Compare(Foxtable.My.b.O0o0oO00_.O.().LastDate, DateTime.Today) == 0)
				{
					goto IL_86;
				}
				IL_51:
				num = 5;
				Foxtable.My.b.O0o0oO00_.O.().LastDate = DateTime.Today;
				IL_62:
				num = 6;
				Foxtable.My.b.O0o0oO00_.O.().Count = Foxtable.My.b.O0o0oO00_.O.().Count + 1;
				IL_7A:
				num = 7;
				Foxtable.My.b.O0o0oO00_.O.().Save();
				IL_86:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_8D:
				num = 9;
				base.Controls.Clear();
				IL_9B:
				num = 10;
				base.Dispose();
				IL_A4:
				goto IL_11F;
				IL_A6:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_E0:
				goto IL_114;
				IL_E2:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_F2:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_E2;
			}
			IL_114:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_11F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x00186740 File Offset: 0x00184940
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			A_1.Cancel = false;
			if (!Oo00.OO_O_0O0OO0_.o.())
			{
				A_1.Cancel = true;
				return;
			}
			this.o_O.o__. = true;
			try
			{
				foreach (object obj in Application.OpenForms)
				{
					System.Windows.Forms.Form form = (System.Windows.Forms.Form)obj;
					if (form is O\u3002\u3000\u3002\u3002\u3000\u3002o\u3002o\u3002\u3002 || form is o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3002\u3000)
					{
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
			string keyName = "HKEY_CURRENT_USER\\Software\\" + O00.ooo000o_0.00o0.(o_o_O0OO_0__.O.ooOo__o000OO.().Substring(0, 4), "Tick", "Tick");
			object objectValue = RuntimeHelpers.GetObjectValue(c.OOOOO.o.().Registry.GetValue(keyName, "LastDate", DateTime.Today));
			DateTime t;
			if (objectValue != null)
			{
				DateTime.TryParse(objectValue.ToString(), out t);
			}
			if (DateTime.Compare(t, DateTime.Today) != 0)
			{
				c.OOOOO.o.().Registry.SetValue(keyName, "LastDate", DateTime.Today);
				objectValue = RuntimeHelpers.GetObjectValue(c.OOOOO.o.().Registry.GetValue(keyName, "Count", 0));
				int num;
				if (objectValue != null)
				{
					int.TryParse(objectValue.ToString(), out num);
				}
				num++;
				c.OOOOO.o.().Registry.SetValue(keyName, "Count", num);
			}
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x001868AC File Offset: 0x00184AAC
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (A_1.Control && A_1.Shift && A_1.KeyCode == Keys.F12 && OO_00oOO.User.Type == UserTypeEnum.Developer)
			{
				if (MessageBox.Show("需要回到系统菜单吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Project.OpenSystemMenu();
					return;
				}
			}
			else if (A_1.Control && A_1.Shift && A_1.KeyCode == Keys.F11 && OO_00oOO.User.Type == UserTypeEnum.Developer)
			{
				if (MessageBox.Show("需要回到用户菜单吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Project.OpenUserMenu();
					return;
				}
			}
			else if (!A_1.Shift & !A_1.Control & !A_1.Alt & A_1.KeyCode == Keys.F1)
			{
				OO_00oOO.ShowHelpWindow();
			}
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x0018696C File Offset: 0x00184B6C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.OOO0_OOo.().Selectable = false;
			this.O.OOO0_OOo.().HideAppMenuWithTHR = true;
			if (this.O.OOO0_OOo.() == null && this.O0o__0_OO.o.().TabPages.Count == 0)
			{
				this.O0o__0_OO.o.().Width = 0;
			}
			if (base.WindowState == FormWindowState.Normal)
			{
				base.Size = new Size(Math.Max(400, O_O0OO.O0_00o.o0__o..FormWidth), Math.Max(400, O_O0OO.O0_00o.o0__o..FormHeight));
			}
			base.Activate();
			if (this.O.OOO0_OOo.() != null)
			{
				C1TopicPage c1TopicPage = this.O.OOO0_OOo.().Pages[2];
				int num = O_O0OO.o0OoO00OO.00O..Count - 1;
				int num2 = 0;
				while (num2 <= num && num2 != O_O0OO.o0OoO00OO.00O.)
				{
					C1TopicLink c1TopicLink = new C1TopicLink();
					c1TopicLink.Text = Conversions.ToString(num2 + 1) + "." + c.OOOOO.o.().FileSystem.GetName(O_O0OO.o0OoO00OO.00O.[num2]);
					c1TopicLink.ToolTipText = O_O0OO.o0OoO00OO.00O.[num2];
					c1TopicLink.Tag = "RecenFile";
					c1TopicPage.Links.Add(c1TopicLink);
					num2++;
				}
			}
			if (this.oO_0_.oO. == 1)
			{
				this.O.OOO0_OOo.().Minimized = false;
			}
			else if (this.oO_0_.oO. == 2)
			{
				this.O.OOO0_OOo.().Minimized = true;
			}
			this.o0o_.o. = new ToolTip(this.oOO0.OOoo0oO.);
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x00186AD8 File Offset: 0x00184CD8
		private void <<EMPTY_NAME>>(object A_0, RibbonEventArgs A_1)
		{
			int a_ = 15;
			int num;
			int num4;
			object obj;
			try
			{
				IL_09:
				ProjectData.ClearProjectError();
				num = 1;
				IL_10:
				int num2 = 2;
				Component component = A_1.Item;
				IL_1A:
				num2 = 3;
				if (Main.OO_O.o. == null)
				{
					goto IL_1829;
				}
				IL_26:
				num2 = 5;
				string text = A_1.EventType.ToString() + O00OOOo_O0_O.b("귱", a_);
				IL_51:
				num2 = 6;
				if (OO_00oOO.Forms.ActiveForm == null)
				{
					goto IL_87;
				}
				IL_5F:
				num2 = 7;
				Foxtable.WinForm.Control control = (Foxtable.WinForm.Control)OO_00oOO.Forms.ActiveForm.ActiveControl;
				IL_77:
				num2 = 8;
				if (control == null)
				{
					goto IL_87;
				}
				IL_7D:
				num2 = 9;
				control.WriteValue();
				IL_87:
				num2 = 10;
				if (!(A_1.Item is RibbonListItem) || A_1.EventType != RibbonEventType.Click)
				{
					goto IL_ED;
				}
				IL_A0:
				num2 = 11;
				RibbonListItem ribbonListItem = (RibbonListItem)A_1.Item;
				IL_B0:
				num2 = 12;
				if (ribbonListItem.Tag != null && Operators.CompareString(ribbonListItem.Tag.ToString(), "", true) != 0)
				{
					goto IL_1829;
				}
				IL_D8:
				num2 = 13;
				component = ribbonListItem.Items[0];
				IL_EA:
				ribbonListItem = null;
				IL_ED:
				num2 = 17;
				if (A_1.EventType != RibbonEventType.Click)
				{
					goto IL_111;
				}
				IL_F9:
				num2 = 18;
				if (this.oO__._ooo__.)
				{
					goto IL_1829;
				}
				IL_107:
				num2 = 21;
				this.oO__._ooo__. = true;
				IL_111:
				num2 = 22;
				if (component != this.O.OOO0_OOo.().Qat)
				{
					goto IL_1C4;
				}
				IL_126:
				num2 = 23;
				string a_2 = text + Conversions.ToString(this.O.OOO0_OOo.().Qat.Tag);
				IL_146:
				num2 = 24;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_2, null, false, this.O.0_0O___Oo. + O00OOOo_O0_O.b("᦮䥾ᙢ", a_), false);
				IL_172:
				num2 = 25;
				string a_3 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_18D:
				num2 = 26;
				RibbonEventArgs ribbonEventArgs = new RibbonEventArgs(OO_00oOO.QAT);
				IL_19C:
				num2 = 27;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_3, new object[]
				{
					ribbonEventArgs
				}, false, this.o._oOO0., false);
				goto IL_9F7;
				IL_1C4:
				num2 = 29;
				if (component != this.O.OOO0_OOo.().ApplicationMenu)
				{
					goto IL_277;
				}
				IL_1D9:
				num2 = 30;
				string a_4 = text + Conversions.ToString(this.O.OOO0_OOo.().ApplicationMenu.Tag);
				IL_1F9:
				num2 = 31;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_4, null, false, this.O.0_0O___Oo. + O00OOOo_O0_O.b("曆箭⩶궤", a_), false);
				IL_225:
				num2 = 32;
				string a_5 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_240:
				num2 = 33;
				RibbonEventArgs ribbonEventArgs2 = new RibbonEventArgs(OO_00oOO.ApplicationMenu);
				IL_24F:
				num2 = 34;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_5, new object[]
				{
					ribbonEventArgs2
				}, false, this.o._oOO0., false);
				goto IL_9F7;
				IL_277:
				num2 = 36;
				if (component != this.O.OOO0_OOo.().ConfigToolBar)
				{
					goto IL_32A;
				}
				IL_28C:
				num2 = 37;
				string a_6 = text + Conversions.ToString(this.O.OOO0_OOo.().ConfigToolBar.Tag);
				IL_2AC:
				num2 = 38;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_6, null, false, this.O.0_0O___Oo. + O00OOOo_O0_O.b("뽠验劣", a_), false);
				IL_2D8:
				num2 = 39;
				string a_7 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_2F3:
				num2 = 40;
				RibbonEventArgs ribbonEventArgs3 = new RibbonEventArgs(OO_00oOO.ConfigBar);
				IL_302:
				num2 = 41;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_7, new object[]
				{
					ribbonEventArgs3
				}, false, this.o._oOO0., false);
				goto IL_9F7;
				IL_32A:
				num2 = 43;
				if (component != this.O.OOO0_OOo.().TopToolBar)
				{
					goto IL_3DD;
				}
				IL_33F:
				num2 = 44;
				string a_8 = text + Conversions.ToString(this.O.OOO0_OOo.().TopToolBar.Tag);
				IL_35F:
				num2 = 45;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_8, null, false, this.O.0_0O___Oo. + O00OOOo_O0_O.b("ᆮ膤", a_), false);
				IL_38B:
				num2 = 46;
				string a_9 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_3A6:
				num2 = 47;
				RibbonEventArgs ribbonEventArgs4 = new RibbonEventArgs(OO_00oOO.TopToolBar);
				IL_3B5:
				num2 = 48;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_9, new object[]
				{
					ribbonEventArgs4
				}, false, this.o._oOO0., false);
				goto IL_9F7;
				IL_3DD:
				num2 = 50;
				if (component != this.O.OOO0_OOo.().BottomToolBar)
				{
					goto IL_490;
				}
				IL_3F2:
				num2 = 51;
				string a_10 = text + Conversions.ToString(this.O.OOO0_OOo.().BottomToolBar.Tag);
				IL_412:
				num2 = 52;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_10, null, false, this.O.0_0O___Oo. + O00OOOo_O0_O.b("樂ᆮ膤", a_), false);
				IL_43E:
				num2 = 53;
				string a_11 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_459:
				num2 = 54;
				RibbonEventArgs ribbonEventArgs5 = new RibbonEventArgs(OO_00oOO.BottomToolBar);
				IL_468:
				num2 = 55;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_11, new object[]
				{
					ribbonEventArgs5
				}, false, this.o._oOO0., false);
				goto IL_9F7;
				IL_490:
				num2 = 57;
				if (!(component is RibbonToggleButton))
				{
					goto IL_556;
				}
				IL_49F:
				num2 = 58;
				ToggleButton toggleButton = new ToggleButton((RibbonToggleButton)component);
				IL_4B0:
				num2 = 59;
				RibbonToggleButtonEventArgs ribbonToggleButtonEventArgs = new RibbonToggleButtonEventArgs(toggleButton);
				IL_4BC:
				num2 = 60;
				string a_12 = text + Conversions.ToString(toggleButton.o__Oo__.O__..Tag);
				IL_4D8:
				num2 = 61;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_12, new object[]
				{
					ribbonToggleButtonEventArgs
				}, false, this.O.0_0O___Oo. + toggleButton.Name, false);
				IL_507:
				num2 = 62;
				RibbonEventArgs ribbonEventArgs6 = new RibbonEventArgs(toggleButton);
				IL_513:
				num2 = 63;
				string a_13 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_52E:
				num2 = 64;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_13, new object[]
				{
					ribbonEventArgs6
				}, false, this.o._oOO0., false);
				goto IL_9F7;
				IL_556:
				num2 = 66;
				if (!(component is RibbonCheckBox))
				{
					goto IL_61C;
				}
				IL_565:
				num2 = 67;
				Foxtable.RibbonMenu.CheckBox checkBox = new Foxtable.RibbonMenu.CheckBox((RibbonCheckBox)component);
				IL_576:
				num2 = 68;
				RibbonCheckBoxEventArgs ribbonCheckBoxEventArgs = new RibbonCheckBoxEventArgs(checkBox);
				IL_582:
				num2 = 69;
				string a_14 = text + Conversions.ToString(checkBox.oOoOoOoO._o0..Tag);
				IL_59E:
				num2 = 70;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_14, new object[]
				{
					ribbonCheckBoxEventArgs
				}, false, this.O.0_0O___Oo. + checkBox.Name, false);
				IL_5CD:
				num2 = 71;
				RibbonEventArgs ribbonEventArgs7 = new RibbonEventArgs(checkBox);
				IL_5D9:
				num2 = 72;
				string a_15 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_5F4:
				num2 = 73;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_15, new object[]
				{
					ribbonEventArgs7
				}, false, this.o._oOO0., false);
				goto IL_9F7;
				IL_61C:
				num2 = 75;
				if (!(component is o_o_Oo0__o_0))
				{
					goto IL_802;
				}
				IL_62B:
				num2 = 76;
				Gallery gallery = new Gallery((o_o_Oo0__o_0)component);
				IL_63C:
				num2 = 77;
				RibbonGalleryEventArgs ribbonGalleryEventArgs = new RibbonGalleryEventArgs(gallery, new GalleryItem(((o_o_Oo0__o_0)component).SelectedItem));
				IL_659:
				num2 = 78;
				if (Operators.CompareString(text, O00OOOo_O0_O.b("ꇱ釳髵鷷駹裻鯽擿䬁樃戅洇爉伋昍焏簑猓猕簗䔙", a_), true) != 0)
				{
					goto IL_768;
				}
				IL_676:
				num2 = 79;
				if (!((o_o_Oo0__o_0)component).o.o_.())
				{
					goto IL_70B;
				}
				IL_68A:
				num2 = 80;
				if (((o_o_Oo0__o_0)component).SelectedItem == null)
				{
					goto IL_9F7;
				}
				IL_69E:
				num2 = 81;
				((o_o_Oo0__o_0)component).SelectedIndex = -1;
				IL_6AE:
				num2 = 82;
				string a_16 = O00OOOo_O0_O.b("믱胳鏵闷맹郻韽揿椁嬃", a_) + Conversions.ToString(gallery.o_.o0_o..Tag);
				IL_6D7:
				num2 = 83;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_16, new object[]
				{
					ribbonGalleryEventArgs
				}, false, this.O.0_0O___Oo. + gallery.Name, false);
				goto IL_9F7;
				IL_70B:
				num2 = 85;
				a_16 = O00OOOo_O0_O.b("믱胳鏵闷꧹駻鋽旿愁瀃挅氇唉", a_) + Conversions.ToString(gallery.o_.o0_o..Tag);
				IL_734:
				num2 = 86;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_16, new object[]
				{
					ribbonGalleryEventArgs
				}, false, this.O.0_0O___Oo. + gallery.Name, false);
				goto IL_9F7;
				IL_768:
				num2 = 88;
				string a_17 = text + Conversions.ToString(gallery.o_.o0_o..Tag);
				IL_784:
				num2 = 89;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_17, new object[]
				{
					ribbonGalleryEventArgs
				}, false, this.O.0_0O___Oo. + gallery.Name, false);
				IL_7B3:
				num2 = 90;
				RibbonEventArgs ribbonEventArgs8 = new RibbonEventArgs(gallery);
				IL_7BF:
				num2 = 91;
				string a_18 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_7DA:
				num2 = 92;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_18, new object[]
				{
					ribbonEventArgs8
				}, false, this.o._oOO0., false);
				goto IL_9F7;
				IL_802:
				num2 = 94;
				if (!(component is RibbonButton))
				{
					goto IL_9F7;
				}
				IL_811:
				num2 = 95;
				if (OO_00oOO.CurrentTable == null || Operators.CompareString(A_1.EventType.ToString(), O00OOOo_O0_O.b("뇱飳鿵鯷釹", a_), true) != 0)
				{
					goto IL_873;
				}
				IL_846:
				num2 = 96;
				O_oOooO_O o_oOooO_O = OO_00oOO.CurrentTable.foxGrid;
				IL_855:
				num2 = 97;
				if (o_oOooO_O.Editor == null)
				{
					goto IL_870;
				}
				IL_861:
				num2 = 98;
				if (!o_oOooO_O.FinishEditing())
				{
					goto IL_1829;
				}
				IL_870:
				o_oOooO_O = null;
				IL_873:
				num2 = 101;
				if (base.ActiveControl == null || !(base.ActiveControl.Parent is OooOo0___oO))
				{
					goto IL_8C3;
				}
				IL_890:
				num2 = 102;
				OooOo0___oO oooOo0___oO = (OooOo0___oO)base.ActiveControl.Parent;
				IL_8A5:
				num2 = 103;
				if (oooOo0___oO.Editor == null)
				{
					goto IL_8C0;
				}
				IL_8B1:
				num2 = 104;
				if (!oooOo0___oO.FinishEditing())
				{
					goto IL_1829;
				}
				IL_8C0:
				oooOo0___oO = null;
				IL_8C3:
				num2 = 107;
				Foxtable.RibbonMenu.Button button = new Foxtable.RibbonMenu.Button((RibbonButton)component);
				IL_8D4:
				num2 = 108;
				if (Operators.CompareString(button.Name, O00OOOo_O0_O.b("등鯳軵냷闹釻鯽䋿省瀃爅朇搉", a_), true) == 0)
				{
					goto IL_1829;
				}
				IL_8F7:
				num2 = 110;
				if (!(button.oOoOoOoO._o0..Tag is string))
				{
					goto IL_964;
				}
				IL_90D:
				num2 = 111;
				RibbonButtonEventArgs ribbonButtonEventArgs = new RibbonButtonEventArgs(button);
				IL_919:
				num2 = 112;
				string a_19 = text + Conversions.ToString(button.oOoOoOoO._o0..Tag);
				IL_935:
				num2 = 113;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_19, new object[]
				{
					ribbonButtonEventArgs
				}, false, this.O.0_0O___Oo. + button.Name, false);
				IL_964:
				num2 = 114;
				RibbonEventArgs ribbonEventArgs9 = new RibbonEventArgs(button);
				IL_970:
				num2 = 115;
				string a_20 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_98B:
				num2 = 116;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_20, new object[]
				{
					ribbonEventArgs9
				}, false, this.o._oOO0., false);
				IL_9AE:
				num2 = 117;
				if ((DateTime.Now - this.oOO0.OOoo0oO.).TotalMinutes <= (double)(4 + DateTime.Today.DayOfWeek))
				{
					goto IL_9F7;
				}
				IL_9DD:
				num2 = 118;
				if (this.o0O.OO.)
				{
					goto IL_9F7;
				}
				IL_9E8:
				num2 = 119;
				this.O.OOO0_OOo.().Enabled = false;
				IL_9F7:
				num2 = 120;
				if (!(component is RibbonColorPicker))
				{
					goto IL_ABD;
				}
				IL_A06:
				num2 = 121;
				Foxtable.RibbonMenu.ColorPicker colorPicker = new Foxtable.RibbonMenu.ColorPicker((RibbonColorPicker)component);
				IL_A17:
				num2 = 122;
				RibbonColorPickerEventArgs ribbonColorPickerEventArgs = new RibbonColorPickerEventArgs(colorPicker);
				IL_A23:
				num2 = 123;
				string a_21 = text + Conversions.ToString(colorPicker.oOoOoOoO._o0..Tag);
				IL_A3F:
				num2 = 124;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_21, new object[]
				{
					ribbonColorPickerEventArgs
				}, false, this.O.0_0O___Oo. + colorPicker.Name, false);
				IL_A6E:
				num2 = 125;
				RibbonEventArgs ribbonEventArgs10 = new RibbonEventArgs(colorPicker);
				IL_A7A:
				num2 = 126;
				string a_22 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_A95:
				num2 = 127;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_22, new object[]
				{
					ribbonEventArgs10
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_ABD:
				num2 = 129;
				if (!(component is RibbonSplitButton))
				{
					goto IL_B9B;
				}
				IL_ACF:
				num2 = 130;
				SplitButton splitButton = new SplitButton((RibbonSplitButton)component);
				IL_AE3:
				num2 = 131;
				RibbonSplitButtonEventArgs ribbonSplitButtonEventArgs = new RibbonSplitButtonEventArgs(splitButton);
				IL_AF2:
				num2 = 132;
				string a_23 = text + Conversions.ToString(splitButton.OO0.0OOo__..Tag);
				IL_B11:
				num2 = 133;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_23, new object[]
				{
					ribbonSplitButtonEventArgs
				}, false, this.O.0_0O___Oo. + splitButton.Name, false);
				IL_B43:
				num2 = 134;
				RibbonEventArgs ribbonEventArgs11 = new RibbonEventArgs(splitButton);
				IL_B52:
				num2 = 135;
				string a_24 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_B70:
				num2 = 136;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_24, new object[]
				{
					ribbonEventArgs11
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_B9B:
				num2 = 138;
				if (!(component is RibbonLabel))
				{
					goto IL_C79;
				}
				IL_BAD:
				num2 = 139;
				Foxtable.RibbonMenu.Label label = new Foxtable.RibbonMenu.Label((RibbonLabel)component);
				IL_BC1:
				num2 = 140;
				RibbonLabelEventArgs ribbonLabelEventArgs = new RibbonLabelEventArgs(label);
				IL_BD0:
				num2 = 141;
				string a_25 = text + Conversions.ToString(label.OOo.O_o..Tag);
				IL_BEF:
				num2 = 142;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_25, new object[]
				{
					ribbonLabelEventArgs
				}, false, this.O.0_0O___Oo. + label.Name, false);
				IL_C21:
				num2 = 143;
				RibbonEventArgs ribbonEventArgs12 = new RibbonEventArgs(label);
				IL_C30:
				num2 = 144;
				string a_26 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_C4E:
				num2 = 145;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_26, new object[]
				{
					ribbonEventArgs12
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_C79:
				num2 = 147;
				if (!(component is RibbonTextBox))
				{
					goto IL_D57;
				}
				IL_C8B:
				num2 = 148;
				Foxtable.RibbonMenu.TextBox textBox = new Foxtable.RibbonMenu.TextBox((RibbonTextBox)component);
				IL_C9F:
				num2 = 149;
				RibbonTextBoxEventArgs ribbonTextBoxEventArgs = new RibbonTextBoxEventArgs(textBox);
				IL_CAE:
				num2 = 150;
				string a_27 = text + Conversions.ToString(textBox.o__Oo__.O__..Tag);
				IL_CCD:
				num2 = 151;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_27, new object[]
				{
					ribbonTextBoxEventArgs
				}, false, this.O.0_0O___Oo. + textBox.Name, false);
				IL_CFF:
				num2 = 152;
				RibbonEventArgs ribbonEventArgs13 = new RibbonEventArgs(textBox);
				IL_D0E:
				num2 = 153;
				string a_28 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_D2C:
				num2 = 154;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_28, new object[]
				{
					ribbonEventArgs13
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_D57:
				num2 = 156;
				if (!(component is RibbonDatePicker))
				{
					goto IL_E35;
				}
				IL_D69:
				num2 = 157;
				DatePicker datePicker = new DatePicker((RibbonDatePicker)component);
				IL_D7D:
				num2 = 158;
				RibbonDatePickerEventArgs ribbonDatePickerEventArgs = new RibbonDatePickerEventArgs(datePicker);
				IL_D8C:
				num2 = 159;
				string a_29 = text + Conversions.ToString(datePicker.o_.o0_o..Tag);
				IL_DAB:
				num2 = 160;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_29, new object[]
				{
					ribbonDatePickerEventArgs
				}, false, this.O.0_0O___Oo. + datePicker.Name, false);
				IL_DDD:
				num2 = 161;
				RibbonEventArgs ribbonEventArgs14 = new RibbonEventArgs(datePicker);
				IL_DEC:
				num2 = 162;
				string a_30 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_E0A:
				num2 = 163;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_30, new object[]
				{
					ribbonEventArgs14
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_E35:
				num2 = 165;
				if (!(component is RibbonTimePicker))
				{
					goto IL_F13;
				}
				IL_E47:
				num2 = 166;
				TimePicker timePicker = new TimePicker((RibbonTimePicker)component);
				IL_E5B:
				num2 = 167;
				RibbonTimePickerEventArgs ribbonTimePickerEventArgs = new RibbonTimePickerEventArgs(timePicker);
				IL_E6A:
				num2 = 168;
				string a_31 = text + Conversions.ToString(timePicker.o__Oo__.O__..Tag);
				IL_E89:
				num2 = 169;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_31, new object[]
				{
					ribbonTimePickerEventArgs
				}, false, this.O.0_0O___Oo. + timePicker.Name, false);
				IL_EBB:
				num2 = 170;
				RibbonEventArgs ribbonEventArgs15 = new RibbonEventArgs(timePicker);
				IL_ECA:
				num2 = 171;
				string a_32 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_EE8:
				num2 = 172;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_32, new object[]
				{
					ribbonEventArgs15
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_F13:
				num2 = 174;
				if (!(component is RibbonTrackBar))
				{
					goto IL_FF1;
				}
				IL_F25:
				num2 = 175;
				Foxtable.RibbonMenu.TrackBar trackBar = new Foxtable.RibbonMenu.TrackBar((RibbonTrackBar)component);
				IL_F39:
				num2 = 176;
				RibbonTrackBarEventArgs ribbonTrackBarEventArgs = new RibbonTrackBarEventArgs(trackBar);
				IL_F48:
				num2 = 177;
				string a_33 = text + Conversions.ToString(trackBar.O.oOOO..Tag);
				IL_F67:
				num2 = 178;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_33, new object[]
				{
					ribbonTrackBarEventArgs
				}, false, this.O.0_0O___Oo. + trackBar.Name, false);
				IL_F99:
				num2 = 179;
				RibbonEventArgs ribbonEventArgs16 = new RibbonEventArgs(trackBar);
				IL_FA8:
				num2 = 180;
				string a_34 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_FC6:
				num2 = 181;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_34, new object[]
				{
					ribbonEventArgs16
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_FF1:
				num2 = 183;
				if (!(component is RibbonNumericBox))
				{
					goto IL_10CF;
				}
				IL_1003:
				num2 = 184;
				NumericBox numericBox = new NumericBox((RibbonNumericBox)component);
				IL_1017:
				num2 = 185;
				RibbonNumericBoxEventArgs ribbonNumericBoxEventArgs = new RibbonNumericBoxEventArgs(numericBox);
				IL_1026:
				num2 = 186;
				string a_35 = text + Conversions.ToString(numericBox.OOo.O_o..Tag);
				IL_1045:
				num2 = 187;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_35, new object[]
				{
					ribbonNumericBoxEventArgs
				}, false, this.O.0_0O___Oo. + numericBox.Name, false);
				IL_1077:
				num2 = 188;
				RibbonEventArgs ribbonEventArgs17 = new RibbonEventArgs(numericBox);
				IL_1086:
				num2 = 189;
				string a_36 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_10A4:
				num2 = 190;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_36, new object[]
				{
					ribbonEventArgs17
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_10CF:
				num2 = 192;
				if (!(component is RibbonProgressBar))
				{
					goto IL_11AD;
				}
				IL_10E1:
				num2 = 193;
				Foxtable.RibbonMenu.ProgressBar progressBar = new Foxtable.RibbonMenu.ProgressBar((RibbonProgressBar)component);
				IL_10F5:
				num2 = 194;
				RibbonProgressBarEventArgs ribbonProgressBarEventArgs = new RibbonProgressBarEventArgs(progressBar);
				IL_1104:
				num2 = 195;
				string a_37 = text + Conversions.ToString(progressBar.OOo.O_o..Tag);
				IL_1123:
				num2 = 196;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_37, new object[]
				{
					ribbonProgressBarEventArgs
				}, false, this.O.0_0O___Oo. + progressBar.Name, false);
				IL_1155:
				num2 = 197;
				RibbonEventArgs ribbonEventArgs18 = new RibbonEventArgs(progressBar);
				IL_1164:
				num2 = 198;
				string a_38 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_1182:
				num2 = 199;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_38, new object[]
				{
					ribbonEventArgs18
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_11AD:
				num2 = 201;
				if (!(component is RibbonFontComboBox))
				{
					goto IL_128B;
				}
				IL_11BF:
				num2 = 202;
				FontComboBox fontComboBox = new FontComboBox((RibbonFontComboBox)component);
				IL_11D3:
				num2 = 203;
				RibbonFontComboBoxEventArgs ribbonFontComboBoxEventArgs = new RibbonFontComboBoxEventArgs(fontComboBox);
				IL_11E2:
				num2 = 204;
				string a_39 = text + Conversions.ToString(fontComboBox.o_.o0_o..Tag);
				IL_1201:
				num2 = 205;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_39, new object[]
				{
					ribbonFontComboBoxEventArgs
				}, false, this.O.0_0O___Oo. + fontComboBox.Name, false);
				IL_1233:
				num2 = 206;
				RibbonEventArgs ribbonEventArgs19 = new RibbonEventArgs(fontComboBox);
				IL_1242:
				num2 = 207;
				string a_40 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_1260:
				num2 = 208;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_40, new object[]
				{
					ribbonEventArgs19
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_128B:
				num2 = 210;
				if (!(component is RibbonComboBox))
				{
					goto IL_1369;
				}
				IL_129D:
				num2 = 211;
				Foxtable.RibbonMenu.ComboBox comboBox = new Foxtable.RibbonMenu.ComboBox((RibbonComboBox)component);
				IL_12B1:
				num2 = 212;
				RibbonComboBoxEventArgs ribbonComboBoxEventArgs = new RibbonComboBoxEventArgs(comboBox);
				IL_12C0:
				num2 = 213;
				string a_41 = text + Conversions.ToString(comboBox.oo0OOOO_._..Tag);
				IL_12DF:
				num2 = 214;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_41, new object[]
				{
					ribbonComboBoxEventArgs
				}, false, this.O.0_0O___Oo. + comboBox.Name, false);
				IL_1311:
				num2 = 215;
				RibbonEventArgs ribbonEventArgs20 = new RibbonEventArgs(comboBox);
				IL_1320:
				num2 = 216;
				string a_42 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_133E:
				num2 = 217;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_42, new object[]
				{
					ribbonEventArgs20
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_1369:
				num2 = 219;
				if (!(component is RibbonMenu))
				{
					goto IL_1447;
				}
				IL_137B:
				num2 = 220;
				MenuButton menuButton = new MenuButton((RibbonMenu)component);
				IL_138F:
				num2 = 221;
				RibbonMenuButtonEventArgs ribbonMenuButtonEventArgs = new RibbonMenuButtonEventArgs(menuButton);
				IL_139E:
				num2 = 222;
				string a_43 = text + Conversions.ToString(menuButton.OOo.O_o..Tag);
				IL_13BD:
				num2 = 223;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_43, new object[]
				{
					ribbonMenuButtonEventArgs
				}, false, this.O.0_0O___Oo. + menuButton.Name, false);
				IL_13EF:
				num2 = 224;
				RibbonEventArgs ribbonEventArgs21 = new RibbonEventArgs(menuButton);
				IL_13FE:
				num2 = 225;
				string a_44 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_141C:
				num2 = 226;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_44, new object[]
				{
					ribbonEventArgs21
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_1447:
				num2 = 228;
				if (!(component is RibbonToolBar))
				{
					goto IL_1525;
				}
				IL_1459:
				num2 = 229;
				Foxtable.RibbonMenu.ToolBar toolBar = new Foxtable.RibbonMenu.ToolBar((RibbonToolBar)component);
				IL_146D:
				num2 = 230;
				RibbonToolBarEventArgs ribbonToolBarEventArgs = new RibbonToolBarEventArgs(toolBar);
				IL_147C:
				num2 = 231;
				string a_45 = text + Conversions.ToString(toolBar.o__Oo__.O__..Tag);
				IL_149B:
				num2 = 232;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_45, new object[]
				{
					ribbonToolBarEventArgs
				}, false, this.O.0_0O___Oo. + toolBar.Name, false);
				IL_14CD:
				num2 = 233;
				RibbonEventArgs ribbonEventArgs22 = new RibbonEventArgs(toolBar);
				IL_14DC:
				num2 = 234;
				string a_46 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_14FA:
				num2 = 235;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_46, new object[]
				{
					ribbonEventArgs22
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_1525:
				num2 = 237;
				if (!(component is RibbonToggleGroup))
				{
					goto IL_1603;
				}
				IL_1537:
				num2 = 238;
				ToggleGroup toggleGroup = new ToggleGroup((RibbonToggleGroup)component);
				IL_154B:
				num2 = 239;
				RibbonToggleGroupEventArgs ribbonToggleGroupEventArgs = new RibbonToggleGroupEventArgs(toggleGroup);
				IL_155A:
				num2 = 240;
				string a_47 = text + Conversions.ToString(toggleGroup.o__Oo__.O__..Tag);
				IL_1579:
				num2 = 241;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_47, new object[]
				{
					ribbonToggleGroupEventArgs
				}, false, this.O.0_0O___Oo. + toggleGroup.Name, false);
				IL_15AB:
				num2 = 242;
				RibbonEventArgs ribbonEventArgs23 = new RibbonEventArgs(toggleGroup);
				IL_15BA:
				num2 = 243;
				string a_48 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_15D8:
				num2 = 244;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_48, new object[]
				{
					ribbonEventArgs23
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_1603:
				num2 = 246;
				if (!(component is RibbonGroup))
				{
					goto IL_16E1;
				}
				IL_1615:
				num2 = 247;
				Group group = new Group((RibbonGroup)component);
				IL_1629:
				num2 = 248;
				RibbonGroupEventArgs ribbonGroupEventArgs = new RibbonGroupEventArgs(group);
				IL_1638:
				num2 = 249;
				string a_49 = text + Conversions.ToString(group.OO0oOo.O_o0..Tag);
				IL_1657:
				num2 = 250;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_49, new object[]
				{
					ribbonGroupEventArgs
				}, false, this.O.0_0O___Oo. + group.Name, false);
				IL_1689:
				num2 = 251;
				RibbonEventArgs ribbonEventArgs24 = new RibbonEventArgs(group);
				IL_1698:
				num2 = 252;
				string a_50 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_16B6:
				num2 = 253;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_50, new object[]
				{
					ribbonEventArgs24
				}, false, this.o._oOO0., false);
				goto IL_17BA;
				IL_16E1:
				num2 = 255;
				if (!(component is RibbonTab))
				{
					goto IL_17BA;
				}
				IL_16F3:
				num2 = 256;
				Tab tab = new Tab((RibbonTab)component);
				IL_1707:
				num2 = 257;
				RibbonTabEventArgs ribbonTabEventArgs = new RibbonTabEventArgs(tab);
				IL_1716:
				num2 = 258;
				string a_51 = text + Conversions.ToString(tab.OO0.0OOo__..Tag);
				IL_1735:
				num2 = 259;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_51, new object[]
				{
					ribbonTabEventArgs
				}, false, this.O.0_0O___Oo. + tab.Name, false);
				IL_1767:
				num2 = 260;
				RibbonEventArgs ribbonEventArgs25 = new RibbonEventArgs(tab);
				IL_1776:
				num2 = 261;
				string a_52 = text + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_1794:
				num2 = 262;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_52, new object[]
				{
					ribbonEventArgs25
				}, false, this.o._oOO0., false);
				IL_17BA:
				num2 = 263;
				RibbonEventType eventType = A_1.EventType;
				if (eventType <= RibbonEventType.PressedChanged)
				{
					if (eventType > RibbonEventType.Click && eventType != RibbonEventType.PressedChanged)
					{
						goto IL_180D;
					}
				}
				else if (eventType != RibbonEventType.SelectTab && eventType - RibbonEventType.ChangeCommitted > 1)
				{
					goto IL_180D;
				}
				IL_17E9:
				num2 = 265;
				if (!(component is RibbonCheckBox) && A_1.EventType != RibbonEventType.Click)
				{
					goto IL_180D;
				}
				IL_1801:
				num2 = 266;
				this.O0__O.OOOO.();
				IL_180D:
				num2 = 268;
				if (A_1.EventType != RibbonEventType.Click)
				{
					goto IL_1829;
				}
				IL_181C:
				num2 = 269;
				this.oO__._ooo__. = false;
				IL_1829:
				goto IL_1CB3;
				IL_182E:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1C74:
				goto IL_1CA8;
				IL_1C76:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1C86:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1C76;
			}
			IL_1CA8:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1CB3:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x001887BC File Offset: 0x001869BC
		internal void <<EMPTY_NAME>>()
		{
			if (this.oOO0.OOoo0oO. != null && this.oOO0.OOoo0oO..FindForm() != null && this.oOO0.OOoo0oO. is O000O)
			{
				if (this.oOO0.OOoo0oO..DataBindings.Count > 0)
				{
					if (this.oOO0.OOoo0oO. is C1TextBox)
					{
						((C1TextBox)this.oOO0.OOoo0oO.).UpdateValueWithCurrentText();
					}
					this.oOO0.OOoo0oO..DataBindings[0].WriteValue();
					this.oOO0.OOoo0oO..DataBindings[0].BindingManagerBase.EndCurrentEdit();
				}
				((O000O)this.oOO0.OOoo0oO.).SetReadOnlyProperty();
			}
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00188860 File Offset: 0x00186A60
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
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
				if (this.o._0_o. || !OO_00oOO.SystemReady)
				{
					goto IL_39;
				}
				IL_18:
				num2 = 3;
				this.o._0_o. = true;
				IL_21:
				num2 = 4;
				this.Oo__.ooOo00_Oo.();
				IL_29:
				num2 = 5;
				o0___oO.o0O0o0_o0._0_o.();
				IL_30:
				num2 = 6;
				this.o._0_o. = false;
				IL_39:
				num2 = 7;
				if (this.Oo.oOo_o0Oo0. == null)
				{
					Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.Oo.oOo_o0Oo0., new StaticLocalInitFlag(), null);
				}
				bool flag = false;
				try
				{
					Monitor.Enter(this.Oo.oOo_o0Oo0., ref flag);
					if (this.Oo.oOo_o0Oo0..State == 0)
					{
						this.Oo.oOo_o0Oo0..State = 2;
						this.o0o__.0O000. = 0;
					}
					else if (this.Oo.oOo_o0Oo0..State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.Oo.oOo_o0Oo0..State = 1;
					if (flag)
					{
						Monitor.Exit(this.Oo.oOo_o0Oo0.);
					}
				}
				IL_B7:
				num2 = 8;
				if (this.oo_o0_._o. != 0 || (DateTime.Now - this.oOO0.OOoo0oO.).TotalSeconds <= 1.0 || !OO_00oOO.SystemReady)
				{
					goto IL_1C8;
				}
				IL_F5:
				num2 = 9;
				this.oo_o0_._o. = Conversions.ToInteger(OO_00oOO.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Foxtable", "FirstTime", 0));
				IL_11D:
				num2 = 10;
				if (this.oo_o0_._o. != 0)
				{
					goto IL_1C8;
				}
				IL_12B:
				num2 = 11;
				this.oo_o0_._o. = 1;
				IL_135:
				num2 = 12;
				if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) != 0)
				{
					goto IL_1C8;
				}
				IL_14A:
				num2 = 13;
				OO_00oOO.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Foxtable", "FirstTime", 1);
				IL_167:
				num2 = 14;
				if (!OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "CaseStudy\\基本功能演示" + ooO0__OO.oo.Ooo_00.()))
				{
					goto IL_1C8;
				}
				IL_18A:
				num2 = 15;
				MessageBox.Show("您这是第一次使用Foxtable，为了让您对此产品有一个基本的了解，将打开一个基本功能演示文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_1A0:
				num2 = 16;
				Project.Open(O_O0OO.o.00O_O.() + "CaseStudy\\基本功能演示" + ooO0__OO.oo.Ooo_00.(), new string[0]);
				goto IL_A95;
				IL_1C8:
				num2 = 18;
				if (!this.oo.0o0. || !OO_00oOO.SystemReady)
				{
					goto IL_1FC;
				}
				IL_1DA:
				num2 = 19;
				this.oo.0o0. = false;
				IL_1E4:
				num2 = 20;
				if (!OO_00oOO.TableCaptionVisible)
				{
					goto IL_1FC;
				}
				IL_1EE:
				num2 = 21;
				this.OO_O_0Oo.___o.().ScrollToSelectedTab();
				IL_1FC:
				num2 = 22;
				if (base.ActiveControl == this.O.OOO0_OOo.() || base.ActiveControl == null)
				{
					goto IL_2F2;
				}
				IL_21B:
				num2 = 23;
				if (base.ActiveControl.CanFocus)
				{
					goto IL_2CE;
				}
				IL_22E:
				num2 = 24;
				if (OO_00oOO.CurrentTable == null || !OO_00oOO.CurrentTable.foxGrid.CanFocus || !Main.OO_O.o..Visible)
				{
					goto IL_27F;
				}
				IL_255:
				num2 = 25;
				if (OO_00oOO.CurrentTable.foxGrid.FindForm() != this)
				{
					goto IL_2CE;
				}
				IL_26A:
				num2 = 26;
				OO_00oOO.CurrentTable.foxGrid.Focus();
				goto IL_2CE;
				IL_27F:
				num2 = 28;
				if (OO_00oOO.MainTable == null || !OO_00oOO.MainTable.foxGrid.CanFocus || !Main.OO_O.o..Visible)
				{
					goto IL_2CE;
				}
				IL_2A6:
				num2 = 29;
				if (OO_00oOO.CurrentTable.foxGrid.FindForm() != this)
				{
					goto IL_2CE;
				}
				IL_2BB:
				num2 = 30;
				OO_00oOO.MainTable.foxGrid.Focus();
				IL_2CE:
				num2 = 31;
				if (!base.ActiveControl.CanFocus)
				{
					goto IL_2F2;
				}
				IL_2DE:
				num2 = 32;
				this.oOO0.OOoo0oO. = ooO.o.O_0000_O.(base.Controls);
				IL_2F2:
				num2 = 33;
				if (OO_00oOO.DataTables == null)
				{
					goto IL_397;
				}
				IL_2FF:
				num2 = 34;
				IEnumerator<DataTable> enumerator = OO_00oOO.DataTables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataTable dataTable = enumerator.Current;
					IL_319:
					num2 = 35;
					if (dataTable.O.0_0O.)
					{
						IL_325:
						num2 = 36;
						if (OO_00oOO.SystemReady && !O_O0OO.O_O00OOooo.O_.)
						{
							IL_336:
							num2 = 37;
							dataTable.O.0_0O. = false;
							IL_341:
							num2 = 38;
							dataTable.OO_.0_O0o.();
						}
					}
					IL_34B:
					num2 = 39;
					if (dataTable.o0_OO.o00OO.)
					{
						IL_357:
						num2 = 40;
						if (OO_00oOO.SystemReady && !O_O0OO.O_O00OOooo.O_.)
						{
							IL_368:
							num2 = 41;
							dataTable.o0_OO.o00OO. = false;
							IL_373:
							num2 = 42;
							dataTable.O0.OoO0o_o0o_O.();
						}
					}
					IL_37D:
					num2 = 43;
				}
				IL_389:
				num2 = 44;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_397:
				num2 = 45;
				if (OO_00oOO.MainTable == null || OO_00oOO.CurrentTable == null)
				{
					goto IL_987;
				}
				IL_3AE:
				num2 = 46;
				if (!this.O.ooO0. || this.O_.oOO_O0_0. % 3 != 0)
				{
					goto IL_453;
				}
				IL_3C9:
				num2 = 47;
				this.O.ooO0. = false;
				IL_3D3:
				num2 = 48;
				IEnumerator<Foxtable.WinForm.Form> enumerator2 = OO_00oOO.Forms.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Foxtable.WinForm.Form form = enumerator2.Current;
					IL_3ED:
					num2 = 49;
					if (form.Opened)
					{
						IL_3F9:
						num2 = 50;
						IEnumerator<Foxtable.WinForm.Control> enumerator3 = form.Controls.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							Foxtable.WinForm.Control control = enumerator3.Current;
							IL_415:
							num2 = 51;
							control.RefrshReadonly();
							IL_41F:
							num2 = 52;
						}
						IL_42B:
						num2 = 53;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
					IL_439:
					num2 = 54;
				}
				IL_445:
				num2 = 55;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_453:
				num2 = 56;
				O_oOooO_O o_oOooO_O = OO_00oOO.MainTable.foxGrid;
				IL_462:
				num2 = 57;
				if (o_oOooO_O.Row >= o_oOooO_O.Rows.Fixed || o_oOooO_O.Rows.Count <= o_oOooO_O.Rows.Fixed)
				{
					goto IL_4AA;
				}
				IL_494:
				num2 = 58;
				o_oOooO_O.Row = o_oOooO_O.Rows.Fixed;
				IL_4AA:
				o_oOooO_O = null;
				IL_4AD:
				num2 = 60;
				if (OO_00oOO.MainTable == OO_00oOO.CurrentTable)
				{
					goto IL_519;
				}
				IL_4BC:
				num2 = 61;
				O_oOooO_O o_oOooO_O2 = OO_00oOO.CurrentTable.foxGrid;
				IL_4CB:
				num2 = 62;
				if (!(o_oOooO_O2.Row < o_oOooO_O2.Rows.Fixed & o_oOooO_O2.Rows.Count > o_oOooO_O2.Rows.Fixed))
				{
					goto IL_516;
				}
				IL_500:
				num2 = 63;
				o_oOooO_O2.Row = o_oOooO_O2.Rows.Fixed;
				IL_516:
				o_oOooO_O2 = null;
				IL_519:
				num2 = 65;
				this.O_.oOO_O0_0.++;
				IL_52A:
				num2 = 66;
				if (this.O_.oOO_O0_0. != 1)
				{
					goto IL_5A2;
				}
				IL_536:
				num2 = 67;
				if (!O_O0OO.OOo_o.0o.)
				{
					goto IL_987;
				}
				IL_543:
				num2 = 68;
				string a_ = "SystemIdle_" + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				IL_562:
				num2 = 69;
				if (O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, null, false, "", false))
				{
					goto IL_987;
				}
				IL_57E:
				num2 = 70;
				O_O0OO.OOo_o.0o. = false;
				IL_587:
				num2 = 71;
				MessageBox.Show("菜单的SystemIdle事件执行过程中发生错误，将暂停执行该事件，请及时修改事件代码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				goto IL_987;
				IL_5A2:
				num2 = 73;
				if (this.O_.oOO_O0_0. != 2)
				{
					goto IL_5DE;
				}
				IL_5AE:
				num2 = 74;
				if (!this.o_o0.o_.)
				{
					goto IL_987;
				}
				IL_5BC:
				num2 = 75;
				this.o_o0.o_. = false;
				IL_5C6:
				num2 = 76;
				OO_00oOO.Functions.O__00.__0_O.(false, "");
				goto IL_987;
				IL_5DE:
				num2 = 78;
				if (this.O_.oOO_O0_0. != 3)
				{
					goto IL_719;
				}
				IL_5ED:
				num2 = 79;
				IEnumerator<Foxtable.Table> enumerator4 = OO_00oOO.Tables.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					Foxtable.Table table = enumerator4.Current;
					IL_60A:
					num2 = 80;
					if (table.TableType == TableTypeEnum.Normal && !table.IsRelation && table.foxGrid.FindForm() == null)
					{
						IL_636:
						num2 = 82;
						if (this.OO_O_0Oo.___o.().TabPages[table.Name] != null)
						{
							IL_655:
							num2 = 83;
							int num3 = 0;
							IL_65B:
							num2 = 84;
							IEnumerator enumerator5 = ((Oo0__Oo)this.OO_O_0Oo.___o.().TabPages[table.Name]).O_000__.o.().TabPages[0].Controls.GetEnumerator();
							while (enumerator5.MoveNext())
							{
								object obj = enumerator5.Current;
								System.Windows.Forms.Control control2 = (System.Windows.Forms.Control)obj;
								IL_6A6:
								num2 = 85;
								if (control2 is FormPanel)
								{
									IL_6B2:
									num2 = 86;
									num3 = 1;
									break;
								}
								IL_6BA:
								num2 = 88;
							}
							IL_6C6:
							num2 = 89;
							if (enumerator5 is IDisposable)
							{
								(enumerator5 as IDisposable).Dispose();
							}
							IL_6DE:
							num2 = 90;
							if (num3 == 0)
							{
								IL_6E5:
								num2 = 91;
								oOO0oo_o0.o.O0o000_.(table.foxGrid);
							}
						}
					}
					IL_6F4:
					num2 = 92;
				}
				IL_703:
				num2 = 93;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
					goto IL_987;
				}
				goto IL_987;
				IL_719:
				num2 = 95;
				if (this.O_.oOO_O0_0. != 4)
				{
					goto IL_81A;
				}
				IL_728:
				num2 = 96;
				if (!this.oO__O_oo_0O0.o.)
				{
					goto IL_788;
				}
				IL_733:
				num2 = 97;
				this.oO__O_oo_0O0.o. = false;
				IL_73D:
				num2 = 98;
				string path = OO_00oOO.ProjectPath + "Bin\\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Project.dll";
				IL_760:
				num2 = 99;
				byte[] rawAssembly = File.ReadAllBytes(path);
				IL_76C:
				num2 = 100;
				O_O0OO.oo0_o_.o. = Assembly.Load(rawAssembly);
				IL_77B:
				num2 = 101;
				O_O0OO.O0_00o.o0__o..O_o0__O.o.();
				IL_788:
				num2 = 102;
				if (!OO_00oOO.Forms.OoO___.0_o.)
				{
					goto IL_987;
				}
				IL_79A:
				num2 = 103;
				OO_00oOO.Forms.OoO___.0_o. = false;
				IL_7A8:
				num2 = 104;
				IEnumerator<Foxtable.WinForm.Form> enumerator6 = OO_00oOO.Forms.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					Foxtable.WinForm.Form form2 = enumerator6.Current;
					IL_7C2:
					num2 = 105;
					if (form2.Opened)
					{
						IL_7CE:
						num2 = 106;
						oo_ oo_ = new oo_();
						IL_7D8:
						num2 = 107;
						form2.Panel.Controls.Add(oo_);
						IL_7EE:
						num2 = 108;
						oo_.BringToFront();
					}
					IL_7F8:
					num2 = 109;
				}
				IL_804:
				num2 = 110;
				if (enumerator6 != null)
				{
					enumerator6.Dispose();
					goto IL_987;
				}
				goto IL_987;
				IL_81A:
				num2 = 112;
				if (this.O_.oOO_O0_0. != 5)
				{
					goto IL_876;
				}
				IL_826:
				num2 = 113;
				if (!O_O0OO.O_OO.OO.)
				{
					goto IL_987;
				}
				IL_833:
				num2 = 114;
				if (O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "SystemIdle", null, false, "", false))
				{
					goto IL_987;
				}
				IL_852:
				num2 = 115;
				O_O0OO.O_OO.OO. = false;
				IL_85B:
				num2 = 116;
				MessageBox.Show("项目的SystemIdle事件执行过程中发生错误，将暂停执行该事件，请及时修改事件代码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				goto IL_987;
				IL_876:
				num2 = 118;
				if (this.O_.oOO_O0_0. != 6)
				{
					goto IL_8D5;
				}
				IL_882:
				num2 = 119;
				IEnumerator<DataTable> enumerator7 = OO_00oOO.DataTables.GetEnumerator();
				while (enumerator7.MoveNext())
				{
					DataTable dataTable2 = enumerator7.Current;
					IL_89C:
					num2 = 120;
					if (dataTable2.oOOO.0.)
					{
						IL_8A8:
						num2 = 121;
						dataTable2.o0.0_0OO0o_0o.(false);
					}
					IL_8B3:
					num2 = 122;
				}
				IL_8BF:
				num2 = 123;
				if (enumerator7 != null)
				{
					enumerator7.Dispose();
					goto IL_987;
				}
				goto IL_987;
				IL_8D5:
				num2 = 125;
				if (this.O_.oOO_O0_0. != 7)
				{
					goto IL_987;
				}
				IL_8E4:
				num2 = 126;
				this.oO__.0O0Oo000.++;
				IL_8F5:
				num2 = 127;
				if (this.oO__.0O0Oo000. != 100)
				{
					goto IL_934;
				}
				IL_902:
				num2 = 128;
				this.oO__.0O0Oo000. = 0;
				IL_90F:
				num2 = 129;
				if (o0OO__.O_0_O0_OO.0Ooo.())
				{
					goto IL_934;
				}
				IL_91C:
				num2 = 130;
				if (O_O0OO.O_oO_o0O.o__.)
				{
					goto IL_934;
				}
				IL_929:
				num2 = 131;
				ooO.oo__.O000_o_O.();
				IL_934:
				num2 = 132;
				this.O_.oOO_O0_0. = 0;
				IL_941:
				num2 = 133;
				if ((DateTime.Now - this.o_O_0Oo0.0O0O.).TotalMinutes <= 5.0)
				{
					goto IL_987;
				}
				IL_96B:
				num2 = 134;
				this.o_O_0Oo0.0O0O. = DateTime.Now;
				IL_97C:
				num2 = 135;
				O_O0OO.o00.0.();
				IL_987:
				num2 = 136;
				if (!(base.ActiveControl is C1DockingTabPage))
				{
					goto IL_A0B;
				}
				IL_99A:
				num2 = 137;
				C1DockingTabPage c1DockingTabPage = (C1DockingTabPage)base.ActiveControl;
				IL_9AD:
				num2 = 138;
				if (c1DockingTabPage.Controls.Count <= 0 || !c1DockingTabPage.Controls[0].CanFocus)
				{
					goto IL_A08;
				}
				IL_9D6:
				num2 = 139;
				if (c1DockingTabPage.Controls[0] is o_O0_0O0)
				{
					goto IL_A08;
				}
				IL_9F0:
				num2 = 140;
				c1DockingTabPage.Controls[0].Select();
				IL_A08:
				c1DockingTabPage = null;
				IL_A0B:
				num2 = 142;
				if (!(base.ActiveControl is C1DockingTab))
				{
					goto IL_A6F;
				}
				IL_A1E:
				num2 = 143;
				C1DockingTab c1DockingTab = (C1DockingTab)base.ActiveControl;
				IL_A31:
				num2 = 144;
				if (c1DockingTab.SelectedTab == null)
				{
					goto IL_A6C;
				}
				IL_A40:
				num2 = 145;
				if (c1DockingTab.SelectedTab.Controls.Count <= 0)
				{
					goto IL_A6C;
				}
				IL_A5A:
				num2 = 146;
				c1DockingTab.SelectedTab.Select();
				IL_A6C:
				c1DockingTab = null;
				IL_A6F:
				num2 = 148;
				if (System.Windows.Forms.Control.ModifierKeys != Keys.None)
				{
					goto IL_A95;
				}
				IL_A7C:
				num2 = 149;
				if (!O_O0OO.O0OO_.0.)
				{
					goto IL_A95;
				}
				IL_A89:
				num2 = 150;
				O_O0OO.O0OO_.0. = false;
				IL_A95:
				goto IL_D43;
				IL_A9A:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_D04:
				goto IL_D38;
				IL_D06:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_D16:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_D06;
			}
			IL_D38:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_D43:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x001895EC File Offset: 0x001877EC
		private void <<EMPTY_NAME>>()
		{
			if (OO_00oOO.MainTable != null)
			{
				string a_ = "MainTableChanged_" + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, null, false, this.o._oOO0., false);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "MainTableChanged", null, false, "项目", false);
			}
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x00189648 File Offset: 0x00187848
		private void <<EMPTY_NAME>>()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				string a_ = "CurrentTableChanged_" + Conversions.ToString(this.O.OOO0_OOo.().Tag);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.o0OoO00OO.00O., a_, null, false, this.o._oOO0., false);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "CurrentTableChanged", null, false, "项目", false);
			}
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x001896A4 File Offset: 0x001878A4
		private void <<EMPTY_NAME>>(object A_0, C1TopicBarClickEventArgs A_1)
		{
			if (A_1.Link.Tag != null)
			{
				string left = A_1.Link.Tag.ToString();
				if (Operators.CompareString(left, "Home", true) == 0)
				{
					new Process
					{
						File = "http://www.foxtable.com"
					}.Start();
					return;
				}
				if (Operators.CompareString(left, "BBS", true) == 0)
				{
					new Process
					{
						File = "http://www.foxtable.com/bbs/"
					}.Start();
					return;
				}
				if (Operators.CompareString(left, "Feedback", true) == 0)
				{
					Process.Start("mailto:foxtable@qq.com");
					return;
				}
				if (Operators.CompareString(left, "Order", true) == 0)
				{
					new Process
					{
						File = "http://www.foxtable.com/contact.html"
					}.Start();
					return;
				}
				if (Operators.CompareString(left, "New", true) == 0)
				{
					Project.Create();
					return;
				}
				if (Operators.CompareString(left, "Open", true) == 0)
				{
					Project.Open();
					return;
				}
				if (Operators.CompareString(left, "Help", true) == 0)
				{
					OO_00oOO.ShowHelpWindow();
					return;
				}
				if (Operators.CompareString(left, "RecenFile", true) == 0)
				{
					if (OO_00oOO.FileSys.FileExists(A_1.Link.ToolTipText))
					{
						A_1.Link.TopicBar.Enabled = false;
						Project.Open(A_1.Link.ToolTipText, new string[0]);
						return;
					}
					MessageBox.Show("文件不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				else if (Operators.CompareString(left, "Demo", true) == 0)
				{
					string text = O_O0OO.o.00O_O.() + "CaseStudy\\基本功能演示" + ooO0__OO.oo.Ooo_00.();
					if (OO_00oOO.FileSys.FileExists(text))
					{
						A_1.Link.TopicBar.Enabled = false;
						Project.Open(text, new string[0]);
						return;
					}
				}
				else if (Operators.CompareString(left, "presentation", true) == 0)
				{
					string text2 = O_O0OO.o.00O_O.() + "CaseStudy\\基本功能介绍" + ooO0__OO.oo.Ooo_00.();
					if (OO_00oOO.FileSys.FileExists(text2))
					{
						A_1.Link.TopicBar.Enabled = false;
						Project.Open(text2, new string[0]);
					}
				}
			}
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x00189894 File Offset: 0x00187A94
		private void <<EMPTY_NAME>>(object A_0, TabPageEventArgs A_1)
		{
			try
			{
				A_1.TabPage.Controls.Clear();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x001898D4 File Offset: 0x00187AD4
		private void <<EMPTY_NAME>>(object A_0, TabPageCancelEventArgs A_1)
		{
			C1DockingTabPage tabPage = A_1.TabPage;
			if (tabPage != null)
			{
				System.Windows.Forms.Control control = ooO.o.O_0000_O.(tabPage.Controls);
				if (control != null && control.DataBindings.Count > 0)
				{
					control.DataBindings[0].WriteValue();
				}
			}
			if (tabPage.Controls.Count == 1)
			{
				System.Windows.Forms.Control control2 = tabPage.Controls[0];
				if (control2 is FormPanel)
				{
					Foxtable.WinForm.Form form = OO_00oOO.Forms[control2.Name];
					FormEventArgs formEventArgs = new FormEventArgs(OO_00oOO.Forms[control2.Name]);
					string a_ = "BeforeClose_" + Conversions.ToString(form.O_o_.0o0__o0O.["Key"]);
					O_O0OO.OoO_o.oO0o0O.(OO_00oOO.Forms[control2.Name].O_0.O00o_00_O., a_, new object[]
					{
						formEventArgs
					}, false, form.Name, false);
					if (form.O_0.O00o_00_O.)
					{
						A_1.Cancel = formEventArgs.Cancel;
					}
					if (!A_1.Cancel)
					{
						form.oOO0OO0O.o0oO.();
						form.OoOO_._0.();
					}
				}
			}
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x001899E8 File Offset: 0x00187BE8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num2;
			int num5;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				if (!OO_00oOO.SystemReady)
				{
					goto IL_1B8;
				}
				IL_0C:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_13:
				num = 4;
				if (this.o_o0Oo.oO00. != 1)
				{
					goto IL_10A;
				}
				IL_21:
				num = 5;
				if (this.oOOo.00Oo_O.)
				{
					goto IL_1A7;
				}
				IL_2E:
				num = 6;
				this.oOOo.00Oo_O. = true;
				IL_37:
				num = 7;
				object objectValue = RuntimeHelpers.GetObjectValue(OO_00oOO.Registry.GetValue("HKEY_CURRENT_USER\\Software\\Foxtable", "LastUpdate", ""));
				IL_58:
				num = 8;
				string s = "";
				IL_61:
				num = 9;
				if (objectValue == null)
				{
					goto IL_72;
				}
				IL_67:
				num = 10;
				s = objectValue.ToString();
				IL_72:
				num = 11;
				DateTime today;
				if (DateTime.TryParse(s, out today))
				{
					goto IL_B0;
				}
				IL_80:
				num = 12;
				today = DateTime.Today;
				IL_8A:
				num = 13;
				OO_00oOO.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Foxtable", "LastUpdate", DateTime.Today);
				goto IL_1A7;
				IL_B0:
				num = 15;
				if ((DateTime.Today - today).TotalDays <= 90.0)
				{
					goto IL_1A7;
				}
				IL_D6:
				num = 16;
				if (!o0OO__.OO0oO.o.(4))
				{
					goto IL_1A7;
				}
				IL_E4:
				num = 17;
				OO_00oOO.Registry.SetValue("HKEY_CURRENT_USER\\Software\\Foxtable", "LastUpdate", DateTime.Today);
				goto IL_1A7;
				IL_10A:
				num = 19;
				if (this.o_o0Oo.oO00. != 2)
				{
					goto IL_16E;
				}
				IL_116:
				num = 20;
				int num3 = Foxtable.My.b.O0o0oO00_.O.().Count;
				IL_125:
				num = 21;
				if (num3 <= 60)
				{
					goto IL_137;
				}
				IL_12E:
				num = 22;
				O_O0OO.O_O.OOO_o.(true);
				IL_137:
				num = 23;
				if (!(num3 >= 90 & !this.Oo.oOo_o0Oo0.()))
				{
					goto IL_1A7;
				}
				IL_14F:
				num = 24;
				if (O_O0OO.O_oO_o0O.o__.)
				{
					goto IL_1A7;
				}
				IL_159:
				num = 25;
				Main.OO_O.o..O.OOO0_OOo.().Enabled = false;
				goto IL_1A7;
				IL_16E:
				num = 27;
				if (this.o_o0Oo.oO00. != 4)
				{
					goto IL_1A7;
				}
				IL_17A:
				num = 28;
				if (o0OO__.O.0ooOoO_0_.())
				{
					goto IL_198;
				}
				IL_184:
				num = 29;
				if (O_O0OO.O_oO_o0O.o__.)
				{
					goto IL_198;
				}
				IL_18E:
				num = 30;
				base.Enabled = false;
				IL_198:
				num = 31;
				this.O0o__0_OO.o.().Enabled = false;
				IL_1A7:
				num = 32;
				this.o_o0Oo.oO00.++;
				IL_1B8:
				goto IL_28E;
				IL_1BD:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_24F:
				goto IL_283;
				IL_251:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_261:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_251;
			}
			IL_283:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_28E:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x00189CA8 File Offset: 0x00187EA8
		private bool <<EMPTY_NAME>>()
		{
			int num;
			bool result;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!SystemInformation.TerminalServerSession)
				{
					goto IL_22;
				}
				IL_10:
				num2 = 3;
				this.o0O.OO. = true;
				IL_19:
				num2 = 4;
				result = true;
				goto IL_12D;
				IL_22:
				num2 = 5;
				string text = o_o_O0OO_0__.O0_O_o.o_.();
				IL_2B:
				num2 = 6;
				this.o0O.OO. = true;
				IL_34:
				num2 = 7;
				if (Operators.CompareString(text, "", true) != 0)
				{
					goto IL_4E;
				}
				IL_45:
				num2 = 8;
				result = false;
				goto IL_12D;
				IL_4E:
				num2 = 9;
				string text2 = o_o_O0OO_0__.O.ooOo__o000OO.().Substring(4, 4);
				IL_5F:
				num2 = 10;
				string s = text.Substring(4, 4);
				IL_6D:
				num2 = 11;
				string text3 = "";
				IL_77:
				num2 = 12;
				text2 = Foxtable.WinForm.Form.O_.O__Oo.("EUNumber(" + text2 + ")").ToString();
				IL_97:
				num2 = 13;
				text2 = O00.EncryptText(text2, "fox", "table");
				IL_AD:
				num2 = 14;
				text2 = o0_.o_000Oo0O_.00o.(O_O0OO.OoO._oO0., text2);
				IL_BE:
				num2 = 15;
				text2 = o_o_O0OO_0__.o000oOoo.0.(text2);
				IL_CA:
				num2 = 16;
				int num3 = 0;
				do
				{
					IL_D0:
					num2 = 17;
					text3 += Conversions.ToString((int)((text2[num3] + '\u0001') % '\t' + '\u0001'));
					IL_F1:
					num2 = 18;
					num3++;
				}
				while (num3 <= 3);
				IL_FF:
				num2 = 19;
				int num4;
				int.TryParse(text3, out num4);
				IL_10C:
				num2 = 20;
				int num5;
				int.TryParse(s, out num5);
				IL_119:
				num2 = 21;
				this.o0O.OO. = true;
				IL_123:
				num2 = 22;
				result = (num4 == num5);
				IL_12D:
				goto IL_1DB;
				IL_132:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_19C:
				goto IL_1D0;
				IL_19E:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1AE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_19E;
			}
			IL_1D0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1DB:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x00189EB8 File Offset: 0x001880B8
		private void <<EMPTY_NAME>>(object A_0, TabPageCancelEventArgs A_1)
		{
			A_1.Cancel = true;
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeCloseTable", null, false, "项目", false);
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x00189EDC File Offset: 0x001880DC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (OO_00oOO.Tables != null)
			{
				try
				{
					foreach (Foxtable.Table table in OO_00oOO.Tables)
					{
						if (table.Grid.FindForm() != null && table.Grid.RowSel >= table.Grid.Rows.Fixed && (table.Grid.RowSel < table.Grid.TopRow || table.Grid.RowSel > table.Grid.BottomRow))
						{
							table.Grid.TopRow = table.Grid.RowSel;
						}
					}
				}
				finally
				{
					IEnumerator<Foxtable.Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x00189F9C File Offset: 0x0018819C
		private void <<EMPTY_NAME>>(object A_0, FileSystemEventArgs A_1)
		{
			string right;
			try
			{
				foreach (DataTable dataTable in OO_00oOO.DataTables)
				{
					if (dataTable.OOo0.O.)
					{
						return;
					}
					right = string.Concat(new string[]
					{
						OO_00oOO.ProjectPath,
						"Bin\\",
						o0OoOOoOOo0.oo00o.0OoO.(""),
						".DataTable.",
						o0OoOOoOOo0.OO0._Oo0o.(dataTable.Name),
						".dll"
					});
					if (Operators.CompareString(A_1.FullPath, right, true) == 0)
					{
						dataTable.oOOO.0. = true;
					}
				}
			}
			finally
			{
				IEnumerator<DataTable> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			right = OO_00oOO.ProjectPath + "Bin\\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Project.dll";
			if (Operators.CompareString(A_1.FullPath, right, true) == 0 && !o0_.O0.oO.)
			{
				this.oO__O_oo_0O0.o. = true;
			}
			right = OO_00oOO.ProjectPath + "Bin\\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Function.dll";
			if (Operators.CompareString(A_1.FullPath, right, true) == 0 && !o0_.o0o___.Ooo__Oo.)
			{
				this.o_o0.o_. = true;
			}
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x0018A0C4 File Offset: 0x001882C4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!this.o._0_o. && OO_00oOO.SystemReady)
			{
				this.o._0_o. = true;
				this.o00o_OO_o_._o.().Enabled = false;
				this.Oo__.ooOo00_Oo.();
				o0___oO.o0O0o0_o0._0_o.();
				this.o._0_o. = false;
				this.o00o_OO_o_._o.().Enabled = true;
			}
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x0018A114 File Offset: 0x00188314
		private void <<EMPTY_NAME>>()
		{
			RequestEventArgs requestEventArgs = null;
			int num = 0;
			object o0oo.Oo. = OO_00oOO.HttpServer.o0oo.Oo.;
			lock (o0oo.Oo.)
			{
				while (OO_00oOO.HttpServer.o0oo.Oo..Count > 0 && OO_00oOO.HttpServer.o.oOOoOOO..Count < 10)
				{
					requestEventArgs = OO_00oOO.HttpServer.o0oo.Oo..Dequeue();
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeHttpRequest", new object[]
					{
						requestEventArgs
					}, true, "项目", false);
					if (requestEventArgs.Cancel || requestEventArgs.oo0o.oo_oOoOo0.)
					{
						OO_00oOO.HttpServer.oo._o_oo_..Enqueue(requestEventArgs);
						num++;
						if (num >= 5)
						{
							break;
						}
					}
					else
					{
						OO_00oOO.HttpServer.o.oOOoOOO..Add(requestEventArgs);
						new Thread(new ThreadStart(requestEventArgs.Ooo_oO0.O0.)).Start();
					}
				}
				requestEventArgs = null;
				if (OO_00oOO.HttpServer.oo._o_oo_..Count > 0)
				{
					requestEventArgs = OO_00oOO.HttpServer.oo._o_oo_..Dequeue();
				}
			}
			if (this.o_0.0oo00O0__. == 0)
			{
				if (o0OO__.OO0oO.o.())
				{
					this.o_0.0oo00O0__. = 1;
				}
				else
				{
					this.o_0.0oo00O0__. = 2;
				}
			}
			if (requestEventArgs == null)
			{
				if (O_O0OO.OoO__.0oO0oo.().Count > 0 && this.o_0.0oo00O0__. == 2)
				{
					O_O0OO.OoO__.0oO0oo.().Clear();
					return;
				}
			}
			else
			{
				if (this.o_0.0oo00O0__. == 1 && !requestEventArgs.Cancel && !requestEventArgs.oo0o.oo_oOoOo0.)
				{
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "HttpRequest", new object[]
					{
						requestEventArgs
					}, true, "项目", false);
				}
				if (!requestEventArgs.AsyncExecute)
				{
					requestEventArgs.o0__O0.o_0..Clear();
					requestEventArgs.oo_OO_0._O0O..Clear();
					try
					{
						foreach (string text in requestEventArgs.oo_OO_0._O0O..Keys)
						{
						}
					}
					finally
					{
						Dictionary<string, string>.KeyCollection.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					requestEventArgs.oo_OO_0._O0O..Clear();
					try
					{
						requestEventArgs.Request.InputStream.Close();
						if (!requestEventArgs.oo0o.oo_oOoOo0.)
						{
							if (!requestEventArgs.o._oOOO00_o_0O.)
							{
								requestEventArgs.StatusCode = 404;
								requestEventArgs.StatusDescription = "foxtable web server has started(error 404)";
								new oOo0_o0Oo_00("foxtable web server has started(error 404).", requestEventArgs.Response, "utf-8").Oo000.o00.(null);
							}
							else
							{
								requestEventArgs.Response.OutputStream.Close();
								requestEventArgs.Response.Close();
								requestEventArgs.Response.Abort();
							}
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x0018A3B4 File Offset: 0x001885B4
		public void <<EMPTY_NAME>>(string A_0, params object[] A_1)
		{
			checked
			{
				if (!base.Disposing && !base.IsDisposed)
				{
					for (int i = 0; i < A_1.Length; i++)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(A_1[i]);
						if (objectValue != null)
						{
							if (objectValue is C1FlexGrid)
							{
								C1FlexGrid c1FlexGrid = (C1FlexGrid)objectValue;
								Font font = c1FlexGrid.Font;
								this.O.OOO0_OOo.().SetTheme(RuntimeHelpers.GetObjectValue(objectValue), A_0);
								c1FlexGrid.Font = font;
							}
							else if (C1ThemeController.IsObjectThemeable(RuntimeHelpers.GetObjectValue(objectValue)))
							{
								this.O.OOO0_OOo.().SetTheme(RuntimeHelpers.GetObjectValue(objectValue), A_0);
								if (objectValue is C1DockingTab)
								{
									((C1DockingTab)objectValue).TabSizeMode = TabSizeModeEnum.Normal;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x0018A452 File Offset: 0x00188652
		internal void <<EMPTY_NAME>>(params object[] A_0)
		{
			this.Oo.oOo_o0Oo0.("(default)", A_0);
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x0018A460 File Offset: 0x00188660
		internal void <<EMPTY_NAME>>(params object[] A_0)
		{
			checked
			{
				if (!base.Disposing && !base.IsDisposed)
				{
					for (int i = 0; i < A_0.Length; i++)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(A_0[i]);
						if (C1ThemeController.IsObjectThemeable(RuntimeHelpers.GetObjectValue(objectValue)) && !(objectValue is O00o))
						{
							this.O.OOO0_OOo.().SetTheme(RuntimeHelpers.GetObjectValue(objectValue), null);
						}
					}
				}
			}
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x0018A4BD File Offset: 0x001886BD
		internal string <<EMPTY_NAME>>(object A_0)
		{
			return this.O.OOO0_OOo.().GetTheme(RuntimeHelpers.GetObjectValue(A_0));
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x0018A4D0 File Offset: 0x001886D0
		internal string <<EMPTY_NAME>>()
		{
			return this.O.OOO0_OOo.().Theme;
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x0018A4E0 File Offset: 0x001886E0
		internal void <<EMPTY_NAME>>(string A_0)
		{
			int num2;
			int num4;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				if (Operators.CompareString(A_0, "(default)", true) != 0)
				{
					goto IL_19;
				}
				IL_10:
				num = 2;
				A_0 = O_O0OO.o_.oO_O0.;
				IL_19:
				num = 3;
				if (Operators.CompareString(this.O.OOO0_OOo.().Theme, A_0, true) == 0)
				{
					goto IL_44;
				}
				IL_2F:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_36:
				num = 5;
				this.O.OOO0_OOo.().Theme = A_0;
				IL_44:
				goto IL_AB;
				IL_46:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_6C:
				goto IL_A0;
				IL_6E:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_7E:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_6E;
			}
			IL_A0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_AB:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x0018A5B0 File Offset: 0x001887B0
		internal string <<EMPTY_NAME>>()
		{
			string o_.00.;
			if (Operators.CompareString(this.o_oO.0., "(default)", true) == 0)
			{
				o_.00. = O_O0OO.O_.00.;
			}
			else
			{
				o_.00. = this.o_oO.0.;
			}
			return o_.00.;
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x0018A5E0 File Offset: 0x001887E0
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.o_oO.0. = A_0;
			if (Operators.CompareString(A_0, "(default)", true) == 0)
			{
				A_0 = O_O0OO.O_.00.;
			}
			if (Operators.CompareString(this.o0_o_o_0.0O.(this.O.OOO0_OOo.()), A_0, true) != 0)
			{
				C1Theme themeByName = C1ThemeController.GetThemeByName(A_0, false);
				if (Operators.CompareString(A_0, "", true) > 0 && Operators.CompareString(A_0, "Office2013Green", true) != 0 && !A_0.StartsWith("Foxtable", StringComparison.OrdinalIgnoreCase))
				{
					themeByName.Children["C1Ribbon"].Children["Groups"].Children["Font"].AssignFrom(this.oO_0_.oO.);
				}
				string left = A_0;
				if (Operators.CompareString(left, "Windows8Red", true) == 0 || Operators.CompareString(left, "Windows8Green", true) == 0 || Operators.CompareString(left, "Windows8Gray", true) == 0 || Operators.CompareString(left, "Windows8Brown", true) == 0 || Operators.CompareString(left, "Windows8Blue", true) == 0 || Operators.CompareString(left, "Office2016White", true) == 0 || Operators.CompareString(left, "Office2013Red", true) == 0 || Operators.CompareString(left, "Office2013Green", true) == 0 || Operators.CompareString(left, "Office2013LightGray", true) == 0 || Operators.CompareString(left, "Office2013Gray", true) == 0 || Operators.CompareString(left, "Office2013White", true) == 0 || Operators.CompareString(left, "Office2013DarkGray", true) == 0 || Operators.CompareString(left, "Office2016DarkGray", true) == 0 || Operators.CompareString(left, "Office2016Colorful", true) == 0 || Operators.CompareString(left, "MacBlue", true) == 0 || Operators.CompareString(left, "MacSilver", true) == 0 || Operators.CompareString(left, "MaterialDark", true) == 0 || Operators.CompareString(left, "Office2010Barbie", true) == 0 || Operators.CompareString(left, "VS2013Dark", true) == 0 || Operators.CompareString(left, "Office2010Red", true) == 0 || Operators.CompareString(left, "Office2010Green", true) == 0)
				{
					ThemeItem source = themeByName.Children["C1Ribbon"].Children["AppButton"].Children["Default"].Children["Background"];
					ThemeItem source2 = themeByName.Children["C1Ribbon"].Children["AppButton"].Children["Default"].Children["TextColor"];
					ThemeItem themeItem = themeByName.Children["C1Command"].Children["C1DockingTab"].Children["Tabs"].Children["Selected"];
					themeItem.Children["Background"].AssignFrom(source);
					themeItem.Children["BorderColor"].AssignFrom(source);
					themeItem.Children["BorderColor2"].AssignFrom(source);
					themeItem.Children["ForeColor"].AssignFrom(source2);
					source = themeByName.Children["C1Ribbon"].Children["AppButton"].Children["Hot"].Children["Background"];
					source2 = themeByName.Children["C1Ribbon"].Children["AppButton"].Children["Hot"].Children["TextColor"];
					ThemeItem themeItem2 = themeByName.Children["C1Command"].Children["C1DockingTab"].Children["Tabs"].Children["Hot"];
					themeItem2.Children["Background"].AssignFrom(source);
					themeItem2.Children["BorderColor"].AssignFrom(source);
					themeItem2.Children["BorderColor2"].AssignFrom(source);
					themeItem2.Children["ForeColor"].AssignFrom(source2);
					ThemeItem themeItem3 = themeByName.Children["C1Command"].Children["C1DockingTab"].Children["Tabs"];
					themeItem3.Children["SelectedHot"].AssignFrom(themeItem3.Children["Hot"]);
					themeItem3.Children["Pressed"].AssignFrom(themeItem3.Children["Selected"]);
				}
				foreach (System.Windows.Forms.Control control in new System.Windows.Forms.Control[]
				{
					this,
					this.O.OOO0_OOo.(),
					this.O.OOO0_OOo.(),
					this.OO_O_0Oo.___o.(),
					this.O0o__0_OO.o.(),
					this.o__0_._oOooO_o.(),
					this.O0o__0_OO.o.(),
					this.Oo.O000_oO__o.()
				})
				{
					if (control != null)
					{
						this.o0oO_O.0Oo_00.(new object[]
						{
							control
						});
						themeByName.ApplyThemeToObject(control);
						if (Operators.CompareString(A_0, "System", true) == 0 && control is C1DockingTab)
						{
							((C1DockingTab)control).BorderStyle = BorderStyle.Fixed3D;
						}
						if (control == this.OO_O_0Oo.___o.())
						{
							try
							{
								foreach (object obj in this.OO_O_0Oo.___o.().TabPages)
								{
									Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
									this.o0oO_O.0Oo_00.(new object[]
									{
										oo0__Oo.O_000__.o.()
									});
									themeByName.ApplyThemeToObject(oo0__Oo.O_000__.o.());
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
						}
					}
				}
				if (A_0.StartsWith("Foxtable", StringComparison.OrdinalIgnoreCase))
				{
					this.OO_O_0Oo.___o.().TabAreaSpacing = 0;
				}
				else
				{
					this.OO_O_0Oo.___o.().TabAreaSpacing = 2;
				}
				this.OO_O_0Oo.___o.().TabSizeMode = TabSizeModeEnum.Normal;
			}
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x0018ABE8 File Offset: 0x00188DE8
		public void <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0, string A_1 = "(default)")
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is C1FlexGrid)
					{
						this.Oo.oOo_o0Oo0.(O_O0OO.O0_00o.o0__o..GridThemeName, new object[]
						{
							control
						});
					}
					else
					{
						if (control is PropertyGrid || control is System.Windows.Forms.Label)
						{
							continue;
						}
						if (!(control is System.Windows.Forms.GroupBox) && !(control is System.Windows.Forms.SplitContainer) && !(control is System.Windows.Forms.Panel) && !(control is SplitterPanel) && !(control is oOOoo_0_0o_))
						{
							this.Oo.oOo_o0Oo0.(A_1, new object[]
							{
								control
							});
						}
					}
					if (control.Controls.Count > 0)
					{
						this.OOoo___.0.(control.Controls, A_1);
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
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x0018ACC8 File Offset: 0x00188EC8
		public void <<EMPTY_NAME>>(System.Windows.Forms.Control.ControlCollection A_0)
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is O_oOooO_O)
					{
						O_oOooO_O o_oOooO_O = (O_oOooO_O)control;
						if (o_oOooO_O.o.0O_O0o_..TableType != TableTypeEnum.Normal || o_oOooO_O.o.0O_O0o_..IsCopy)
						{
							this.o0oO_O.0Oo_00.(new object[]
							{
								control
							});
						}
					}
					else
					{
						if (C1ThemeController.IsObjectThemeable(control))
						{
							this.o0oO_O.0Oo_00.(new object[]
							{
								control
							});
						}
						if (control.Controls.Count > 0)
						{
							this.o0oO_O.0Oo_00.(control.Controls);
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
		}

		// Token: 0x04001670 RID: 5744
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001671 RID: 5745
		[CompilerGenerated]
		private C1Ribbon <<EMPTY_NAME>>;

		// Token: 0x04001672 RID: 5746
		[CompilerGenerated]
		private RibbonApplicationMenu <<EMPTY_NAME>>;

		// Token: 0x04001673 RID: 5747
		[CompilerGenerated]
		private RibbonConfigToolBar <<EMPTY_NAME>>;

		// Token: 0x04001674 RID: 5748
		[CompilerGenerated]
		private RibbonGroup <<EMPTY_NAME>>;

		// Token: 0x04001675 RID: 5749
		[CompilerGenerated]
		private C1StatusBar <<EMPTY_NAME>>;

		// Token: 0x04001676 RID: 5750
		[CompilerGenerated]
		private OO___OO0O_0 <<EMPTY_NAME>>;

		// Token: 0x04001677 RID: 5751
		[CompilerGenerated]
		private C1CommandDock <<EMPTY_NAME>>;

		// Token: 0x04001678 RID: 5752
		[CompilerGenerated]
		private oo00o_ <<EMPTY_NAME>>;

		// Token: 0x04001679 RID: 5753
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x0400167A RID: 5754
		[CompilerGenerated]
		private o0ooo_0_00oO <<EMPTY_NAME>>;

		// Token: 0x0400167B RID: 5755
		[CompilerGenerated]
		private C1CommandHolder <<EMPTY_NAME>>;

		// Token: 0x0400167C RID: 5756
		[CompilerGenerated]
		private ToolTip <<EMPTY_NAME>>;

		// Token: 0x0400167D RID: 5757
		[CompilerGenerated]
		private System.Windows.Forms.Timer <<EMPTY_NAME>>;

		// Token: 0x0400167E RID: 5758
		[CompilerGenerated]
		private RibbonBottomToolBar <<EMPTY_NAME>>;

		// Token: 0x0400167F RID: 5759
		[CompilerGenerated]
		private RibbonTopToolBar <<EMPTY_NAME>>;

		// Token: 0x04001680 RID: 5760
		[CompilerGenerated]
		private System.Windows.Forms.Timer <<EMPTY_NAME>>;

		// Token: 0x04001681 RID: 5761
		[CompilerGenerated]
		private RibbonQat <<EMPTY_NAME>>;

		// Token: 0x04001682 RID: 5762
		[CompilerGenerated]
		private RibbonTab <<EMPTY_NAME>>;

		// Token: 0x04001683 RID: 5763
		[CompilerGenerated]
		private ImageList <<EMPTY_NAME>>;

		// Token: 0x04001684 RID: 5764
		[CompilerGenerated]
		private C1ThemeController <<EMPTY_NAME>>;

		// Token: 0x04001685 RID: 5765
		[CompilerGenerated]
		private RibbonLabel <<EMPTY_NAME>>;

		// Token: 0x04001686 RID: 5766
		[CompilerGenerated]
		private RibbonProgressBar <<EMPTY_NAME>>;

		// Token: 0x04001687 RID: 5767
		[CompilerGenerated]
		private RibbonLabel <<EMPTY_NAME>>;

		// Token: 0x04001688 RID: 5768
		[CompilerGenerated]
		private RibbonLabel <<EMPTY_NAME>>;

		// Token: 0x04001689 RID: 5769
		internal System.Windows.Forms.Control <<EMPTY_NAME>>;

		// Token: 0x0400168A RID: 5770
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400168B RID: 5771
		internal DataTable <<EMPTY_NAME>>;

		// Token: 0x0400168C RID: 5772
		internal int <<EMPTY_NAME>>;

		// Token: 0x0400168D RID: 5773
		internal BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x0400168E RID: 5774
		internal C1CommandDock <<EMPTY_NAME>>;

		// Token: 0x0400168F RID: 5775
		internal C1CommandDock <<EMPTY_NAME>>;

		// Token: 0x04001690 RID: 5776
		internal C1CommandDock <<EMPTY_NAME>>;

		// Token: 0x04001691 RID: 5777
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x04001692 RID: 5778
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x04001693 RID: 5779
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x04001694 RID: 5780
		internal DateTime <<EMPTY_NAME>>;

		// Token: 0x04001695 RID: 5781
		private int <<EMPTY_NAME>>;

		// Token: 0x04001696 RID: 5782
		private long <<EMPTY_NAME>>;

		// Token: 0x04001697 RID: 5783
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001698 RID: 5784
		internal ToolTip <<EMPTY_NAME>>;

		// Token: 0x04001699 RID: 5785
		[CompilerGenerated]
		private FileSystemWatcher <<EMPTY_NAME>>;

		// Token: 0x0400169A RID: 5786
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400169B RID: 5787
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400169C RID: 5788
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400169D RID: 5789
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400169E RID: 5790
		internal oooO0o000O <<EMPTY_NAME>>;

		// Token: 0x0400169F RID: 5791
		private ThemeItem <<EMPTY_NAME>>;

		// Token: 0x040016A0 RID: 5792
		private bool <<EMPTY_NAME>>;

		// Token: 0x040016A1 RID: 5793
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040016A2 RID: 5794
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x040016A3 RID: 5795
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040016A4 RID: 5796
		private bool <<EMPTY_NAME>>;

		// Token: 0x040016A5 RID: 5797
		private string <<EMPTY_NAME>>;

		// Token: 0x040016A6 RID: 5798
		private string <<EMPTY_NAME>>;

		// Token: 0x040016A7 RID: 5799
		private bool <<EMPTY_NAME>>;

		// Token: 0x040016A8 RID: 5800
		private string <<EMPTY_NAME>>;

		// Token: 0x040016A9 RID: 5801
		private int <<EMPTY_NAME>>;

		// Token: 0x040016AA RID: 5802
		private int <<EMPTY_NAME>>;

		// Token: 0x040016AB RID: 5803
		private int <<EMPTY_NAME>>;

		// Token: 0x040016AC RID: 5804
		private StaticLocalInitFlag <<EMPTY_NAME>>;

		// Token: 0x040016AD RID: 5805
		private int <<EMPTY_NAME>>;

		// Token: 0x040016AE RID: 5806
		private bool <<EMPTY_NAME>>;

		// Token: 0x040016AF RID: 5807
		private int <<EMPTY_NAME>>;
	}
}
