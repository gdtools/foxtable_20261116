using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200019F RID: 415
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class f4 : Form
	{
		// Token: 0x06001390 RID: 5008 RVA: 0x00086680 File Offset: 0x00084880
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o0o._O. != null)
				{
					this.o0o._O..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x000866C0 File Offset: 0x000848C0
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0o._O. = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(f4));
			this.o0.00.(new SplitContainer());
			this.O0O.00_O.(new OO___OO0O_0());
			this.O0O.00_O.(new C1DockingTabPage());
			this.Oo.OO__.(new o0ooo_0_00oO());
			this.oOO0o.OO0.(new ImageList(this.o0o._O.));
			this.O0O.0o.(new C1DockingTabPage());
			this.O0O.00_O.(new o0ooo_0_00oO());
			this.o_0_.o00_.(new Label());
			this.Oo.OO__.(new OO___OO0O_0());
			this.Oo.OO__.(new C1DockingTabPage());
			this.O.Oo_O0.(new SplitContainer());
			this.oOO0o.OO0.(new Oo0O());
			this.o0.oo_o__00O.(new C1Button());
			this.o0OoO0.o0__.(new C1Button());
			this.O___.__OOOOOO0.(new Panel());
			this.oOO0o.OO0.(new Label());
			this.oOOO.o0_Oo00O.(new Panel());
			this.O0O._O_oO0.(new Label());
			this.O_o0_o__.000.(new Panel());
			this.o0o_O00_.o.(new Label());
			this.OO0Oo_.0oO_.(new Label());
			this.oOO_._0_0o_0.(new C1Button());
			this.O0.OoooO.(new C1Button());
			this.OO0oOOO._O_.(new C1Button());
			this.OO0o.O.(new C1Button());
			this.o0_O.O.(new C1Button());
			this.oOO0o_.o_.(new C1Button());
			this.O00Oo_o.00_oO.(new C1Button());
			this.O_0.oOo_o0OO0.(new C1Button());
			this.O.Oo_O0.(new C1TextBox());
			this.O_0O.Oo.(new C1DockingTabPage());
			this.O___.__OOOOOO0.(new RadioButton());
			this.oOOO.o0_Oo00O.(new RadioButton());
			this.O_o0_o__.000.(new RadioButton());
			this.o0.00.(new C1TextBox());
			this.O0O0_0o0_O_.00.(new C1Button());
			this.OOoO0o0oo.o_.(new C1Button());
			this.OOo.__o_o.(new C1Button());
			this.oo0O__.o_OOo.(new C1Button());
			this.O0O._O_oO0.(new Oo0O());
			this.O.Oo_O0.(new ToolTip(this.o0o._O.));
			this.oO.__0.(new ContextMenuStrip(this.o0o._O.));
			this.O0_o0._oO.(new ToolStripMenuItem());
			this.OO0Oo_.0oO_.(new ToolStripMenuItem());
			this.OO_0O_0o_._o0.(new ContextMenuStrip(this.o0o._O.));
			this.OO0O0.O__0oo.(new ToolStripMenuItem());
			this.o_0_.o00_.(new ToolStripMenuItem());
			this.OoOo0_O0oO.000.(new ContextMenuStrip(this.o0o._O.));
			this.oO.__0.(new ToolStripMenuItem());
			this.o.oo00oO0O0oO.(new ToolStripMenuItem());
			this.ooo0.o.(new ToolStripSeparator());
			this.ooo0.o.(new ToolStripMenuItem());
			this.O.Oo_O0.(new System.Windows.Forms.Timer(this.o0o._O.));
			this.O0_o0._oO.(new ContextMenuStrip(this.o0o._O.));
			this.o0o_.0oOo.(new ToolStripMenuItem());
			this.o_o0_.0o0ooO.(new ToolStripMenuItem());
			this.O_o0_o__.000.(new ContextMenuStrip(this.o0o._O.));
			this.OoOo_._0o.(new ToolStripMenuItem());
			this.O._OoO.(new ToolStripMenuItem());
			this.OO.O00o0oo_O.(new ToolStripMenuItem());
			this.O._o_O0O.().Panel1.SuspendLayout();
			this.O._o_O0O.().Panel2.SuspendLayout();
			this.O._o_O0O.().SuspendLayout();
			((ISupportInitialize)this.oOOoo._.()).BeginInit();
			this.oOOoo._.().SuspendLayout();
			this.ooO.0o00__0.().SuspendLayout();
			((ISupportInitialize)this.Oo.Oo00__oooo.()).BeginInit();
			this.OO0_O0.o.().SuspendLayout();
			((ISupportInitialize)this.O_0oOOO_.OO.()).BeginInit();
			((ISupportInitialize)this.ooO.0o00__0.()).BeginInit();
			this.ooO.0o00__0.().SuspendLayout();
			this.O_o._o0___.().SuspendLayout();
			this.o.o00_0O0o.().Panel1.SuspendLayout();
			this.o.o00_0O0o.().Panel2.SuspendLayout();
			this.o.o00_0O0o.().SuspendLayout();
			((ISupportInitialize)this.O_0oOOO_.OO.()).BeginInit();
			((ISupportInitialize)this.oO____oooO.0_O.()).BeginInit();
			((ISupportInitialize)this.oOOoo._.()).BeginInit();
			this.o.o00_0O0o.().SuspendLayout();
			this.o_oO__.0.().SuspendLayout();
			this.o.0_o0_00.().SuspendLayout();
			((ISupportInitialize)this.o_O.O000o__.()).BeginInit();
			((ISupportInitialize)this.oOO____o.0o.()).BeginInit();
			((ISupportInitialize)this.Oo_._O0.()).BeginInit();
			((ISupportInitialize)this.oOo00_.0Oo.()).BeginInit();
			((ISupportInitialize)this.Oo_oo._O_.()).BeginInit();
			((ISupportInitialize)this.oOO._O.()).BeginInit();
			((ISupportInitialize)this.O_OO0.oo.()).BeginInit();
			((ISupportInitialize)this.OO0_O0.o.()).BeginInit();
			this.Oo.Oo00__oooo.().SuspendLayout();
			((ISupportInitialize)this.Oo.Oo00__oooo.()).BeginInit();
			this.O.ooO_0_.().SuspendLayout();
			this.ooOoo___0.oO0.().SuspendLayout();
			this.O0oO_Oo0oO_.o.().SuspendLayout();
			this.o_oO__.0.().SuspendLayout();
			this.o.0_o0_00.().SuspendLayout();
			base.SuspendLayout();
			this.O._o_O0O.().Dock = DockStyle.Fill;
			this.O._o_O0O.().Location = new Point(0, 0);
			this.O._o_O0O.().Name = "SplitContainer1";
			this.O._o_O0O.().Panel1.Controls.Add(this.oOOoo._.());
			this.O._o_O0O.().Panel2.Controls.Add(this.O.O_O0__0_0.());
			this.O._o_O0O.().Panel2.Controls.Add(this.ooO.0o00__0.());
			this.O._o_O0O.().Size = new Size(825, 555);
			this.O._o_O0O.().SplitterDistance = 193;
			this.O._o_O0O.().TabIndex = 0;
			this.oOOoo._.().Controls.Add(this.ooO.0o00__0.());
			this.oOOoo._.().Controls.Add(this.OO0_O0.o.());
			this.oOOoo._.().Dock = DockStyle.Fill;
			this.oOOoo._.().Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.oOOoo._.().ImageList = this.O_0oOOO_.OO.();
			this.oOOoo._.().Location = new Point(0, 0);
			this.oOOoo._.().Name = "C1DockingTab1";
			this.oOOoo._.().Size = new Size(193, 555);
			this.oOOoo._.().TabIndex = 0;
			this.oOOoo._.().TabsCanFocus = false;
			this.oOOoo._.().TabsSpacing = 5;
			this.oOOoo._.().TabStyle = TabStyleEnum.Office2007;
			this.oOOoo._.().VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue;
			this.oOOoo._.().VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue;
			this.ooO.0o00__0.().Controls.Add(this.Oo.Oo00__oooo.());
			this.ooO.0o00__0.().ImageIndex = 3;
			this.ooO.0o00__0.().Location = new Point(1, 25);
			this.ooO.0o00__0.().Name = "C1DockingTabPage2";
			this.ooO.0o00__0.().Size = new Size(191, 529);
			this.ooO.0o00__0.().TabIndex = 0;
			this.ooO.0o00__0.().Text = "好友";
			this.Oo.Oo00__oooo.().AutoScrollMinSize = new Size(0, 20);
			this.Oo.Oo00__oooo.().BackColor = Color.FromArgb(239, 246, 253);
			this.Oo.Oo00__oooo.().Dock = DockStyle.Fill;
			this.Oo.Oo00__oooo.().ImageList = this.O_0oOOO_.OO.();
			this.Oo.Oo00__oooo.().Location = new Point(0, 0);
			this.Oo.Oo00__oooo.().Name = "c1UserGroups";
			this.Oo.Oo00__oooo.().Padding = new Padding(5, 15, 5, 5);
			this.Oo.Oo00__oooo.().PageOffset = 5;
			this.Oo.Oo00__oooo.().PagePadding = new Padding(10);
			this.Oo.Oo00__oooo.().Size = new Size(191, 529);
			this.Oo.Oo00__oooo.().TabIndex = 0;
			this.Oo.Oo00__oooo.().VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
			this.Oo.Oo00__oooo.().VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue;
			this.O_0oOOO_.OO.().ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
			this.O_0oOOO_.OO.().TransparentColor = Color.Transparent;
			this.O_0oOOO_.OO.().Images.SetKeyName(0, "online");
			this.O_0oOOO_.OO.().Images.SetKeyName(1, "offline");
			this.O_0oOOO_.OO.().Images.SetKeyName(2, "talk.png");
			this.O_0oOOO_.OO.().Images.SetKeyName(3, "Users");
			this.O_0oOOO_.OO.().Images.SetKeyName(4, "history");
			this.O_0oOOO_.OO.().Images.SetKeyName(5, "font");
			this.O_0oOOO_.OO.().Images.SetKeyName(6, "face");
			this.O_0oOOO_.OO.().Images.SetKeyName(7, "file");
			this.O_0oOOO_.OO.().Images.SetKeyName(8, "color");
			this.O_0oOOO_.OO.().Images.SetKeyName(9, "Meeting");
			this.O_0oOOO_.OO.().Images.SetKeyName(10, "group");
			this.O_0oOOO_.OO.().Images.SetKeyName(11, "online2");
			this.O_0oOOO_.OO.().Images.SetKeyName(12, "offline2");
			this.O_0oOOO_.OO.().Images.SetKeyName(13, "meeting2");
			this.O_0oOOO_.OO.().Images.SetKeyName(14, "capture");
			this.O_0oOOO_.OO.().Images.SetKeyName(15, "Setting");
			this.O_0oOOO_.OO.().Images.SetKeyName(16, "upload");
			this.O_0oOOO_.OO.().Images.SetKeyName(17, "Cancel");
			this.O_0oOOO_.OO.().Images.SetKeyName(18, "info");
			this.O_0oOOO_.OO.().Images.SetKeyName(19, "ok");
			this.O_0oOOO_.OO.().Images.SetKeyName(20, "WeChat");
			this.OO0_O0.o.().Controls.Add(this.O_0oOOO_.OO.());
			this.OO0_O0.o.().ImageIndex = 9;
			this.OO0_O0.o.().Location = new Point(1, 25);
			this.OO0_O0.o.().Name = "C1DockingTabPage1";
			this.OO0_O0.o.().Size = new Size(191, 529);
			this.OO0_O0.o.().TabIndex = 2;
			this.OO0_O0.o.().TabVisible = false;
			this.OO0_O0.o.().Text = "会议";
			this.O_0oOOO_.OO.().AutoScrollMinSize = new Size(0, 20);
			this.O_0oOOO_.OO.().Dock = DockStyle.Fill;
			this.O_0oOOO_.OO.().ImageList = this.O_0oOOO_.OO.();
			this.O_0oOOO_.OO.().Location = new Point(0, 0);
			this.O_0oOOO_.OO.().Name = "c1Meetings";
			this.O_0oOOO_.OO.().Padding = new Padding(5, 15, 5, 5);
			this.O_0oOOO_.OO.().PageOffset = 5;
			this.O_0oOOO_.OO.().PagePadding = new Padding(10);
			this.O_0oOOO_.OO.().Size = new Size(191, 529);
			this.O_0oOOO_.OO.().TabIndex = 0;
			this.O_0oOOO_.OO.().VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue;
			this.O_0oOOO_.OO.().VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue;
			this.O.O_O0__0_0.().Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.O.O_O0__0_0.().BackColor = Color.FromArgb(187, 206, 230);
			this.O.O_O0__0_0.().ImageKey = "Setting";
			this.O.O_O0__0_0.().ImageList = this.O_0oOOO_.OO.();
			this.O.O_O0__0_0.().Location = new Point(600, 2);
			this.O.O_O0__0_0.().Name = "lblSetting";
			this.O.O_O0__0_0.().Size = new Size(18, 18);
			this.O.O_O0__0_0.().TabIndex = 1;
			this.ooO.0o00__0.().Controls.Add(this.O_o._o0___.());
			this.ooO.0o00__0.().Controls.Add(this.Oo.Oo00__oooo.());
			this.ooO.0o00__0.().Dock = DockStyle.Fill;
			this.ooO.0o00__0.().Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.ooO.0o00__0.().ImageList = this.O_0oOOO_.OO.();
			this.ooO.0o00__0.().Location = new Point(0, 0);
			this.ooO.0o00__0.().Name = "C1DockingTab2";
			this.ooO.0o00__0.().Size = new Size(628, 555);
			this.ooO.0o00__0.().TabIndex = 0;
			this.ooO.0o00__0.().TabsCanFocus = false;
			this.ooO.0o00__0.().TabsSpacing = 5;
			this.ooO.0o00__0.().TabStyle = TabStyleEnum.Office2010;
			this.ooO.0o00__0.().VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue;
			this.ooO.0o00__0.().VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue;
			this.O_o._o0___.().Controls.Add(this.o.o00_0O0o.());
			this.O_o._o0___.().ImageIndex = 2;
			this.O_o._o0___.().Location = new Point(1, 25);
			this.O_o._o0___.().Name = "C1DockingTabPage3";
			this.O_o._o0___.().Size = new Size(626, 529);
			this.O_o._o0___.().TabIndex = 0;
			this.O_o._o0___.().Text = "会话";
			this.o.o00_0O0o.().BackColor = Color.FromArgb(239, 246, 253);
			this.o.o00_0O0o.().Dock = DockStyle.Fill;
			this.o.o00_0O0o.().Location = new Point(0, 0);
			this.o.o00_0O0o.().Name = "SplitContainer2";
			this.o.o00_0O0o.().Orientation = Orientation.Horizontal;
			this.o.o00_0O0o.().Panel1.Controls.Add(this.O_0oOOO_.OO.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.oO____oooO.0_O.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.oOOoo._.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.o.o00_0O0o.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.o_oO__.0.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.o.0_o0_00.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.o_O.O000o__.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.oOO____o.0o.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.Oo_._O0.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.oOo00_.0Oo.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.Oo_oo._O_.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.oOO._O.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.O_OO0.oo.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.OO0_O0.o.());
			this.o.o00_0O0o.().Panel2.Controls.Add(this.O._o_O0O.());
			this.o.o00_0O0o.().Size = new Size(626, 529);
			this.o.o00_0O0o.().SplitterDistance = 386;
			this.o.o00_0O0o.().TabIndex = 5;
			this.O_0oOOO_.OO.().AllowEditing = false;
			this.O_0oOOO_.OO.().AutoClipboard = true;
			this.O_0oOOO_.OO.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			this.O_0oOOO_.OO.().ColumnInfo = "2,0,0,0,0,90,Columns:";
			this.O_0oOOO_.OO.().Dock = DockStyle.Fill;
			this.O_0oOOO_.OO.().ExtendLastCol = true;
			this.O_0oOOO_.OO.().FocusRect = FocusRectEnum.None;
			this.O_0oOOO_.OO.().Font = new Font("宋体", 9f);
			this.O_0oOOO_.OO.().HighLight = HighLightEnum.WithFocus;
			this.O_0oOOO_.OO.().Location = new Point(0, 0);
			this.O_0oOOO_.OO.().Margin = new Padding(8, 3, 3, 3);
			this.O_0oOOO_.OO.().Name = "gridChat";
			this.O_0oOOO_.OO.().Rows.Count = 0;
			this.O_0oOOO_.OO.().Rows.DefaultSize = 18;
			this.O_0oOOO_.OO.().Rows.Fixed = 0;
			this.O_0oOOO_.OO.().Size = new Size(626, 386);
			this.O_0oOOO_.OO.().StyleInfo = componentResourceManager.GetString("gridChat.StyleInfo");
			this.O_0oOOO_.OO.().TabIndex = 0;
			this.O_0oOOO_.OO.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
			this.oO____oooO.0_O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.oO____oooO.0_O.().Location = new Point(243, 112);
			this.oO____oooO.0_O.().Name = "btnCapture2";
			this.oO____oooO.0_O.().Size = new Size(18, 23);
			this.oO____oooO.0_O.().TabIndex = 12;
			this.oO____oooO.0_O.().Text = "∨";
			this.oO____oooO.0_O.().TextAlign = ContentAlignment.BottomCenter;
			this.oO____oooO.0_O.().UseVisualStyleBackColor = true;
			this.oO____oooO.0_O.().VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
			this.oOOoo._.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.oOOoo._.().Enabled = false;
			this.oOOoo._.().Location = new Point(604, 112);
			this.oOOoo._.().Name = "btnSend2";
			this.oOOoo._.().Size = new Size(18, 23);
			this.oOOoo._.().TabIndex = 11;
			this.oOOoo._.().Text = "∨";
			this.oOOoo._.().TextAlign = ContentAlignment.BottomCenter;
			this.oOOoo._.().UseVisualStyleBackColor = true;
			this.oOOoo._.().VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
			this.o.o00_0O0o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o.o00_0O0o.().BackColor = Color.Transparent;
			this.o.o00_0O0o.().Controls.Add(this.o_o0oO.oo_0_O.());
			this.o.o00_0O0o.().Location = new Point(350, 57);
			this.o.o00_0O0o.().Name = "panelResend";
			this.o.o00_0O0o.().Size = new Size(35, 22);
			this.o.o00_0O0o.().TabIndex = 10;
			this.o.o00_0O0o.().Visible = false;
			this.o_o0oO.oo_0_O.().AutoSize = true;
			this.o_o0oO.oo_0_O.().Cursor = Cursors.Hand;
			this.o_o0oO.oo_0_O.().ForeColor = Color.CornflowerBlue;
			this.o_o0oO.oo_0_O.().Location = new Point(0, 9);
			this.o_o0oO.oo_0_O.().Name = "lblResend";
			this.o_o0oO.oo_0_O.().Size = new Size(29, 12);
			this.o_o0oO.oo_0_O.().TabIndex = 0;
			this.o_o0oO.oo_0_O.().Text = "重发";
			this.o_oO__.0.().BackColor = Color.Transparent;
			this.o_oO__.0.().Controls.Add(this.O_o._o0___.());
			this.o_oO__.0.().Location = new Point(255, 58);
			this.o_oO__.0.().Name = "panelOfflineFiles";
			this.o_oO__.0.().Size = new Size(45, 22);
			this.o_oO__.0.().TabIndex = 9;
			this.o_oO__.0.().Visible = false;
			this.O_o._o0___.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O_o._o0___.().AutoSize = true;
			this.O_o._o0___.().Cursor = Cursors.Hand;
			this.O_o._o0___.().ForeColor = Color.CornflowerBlue;
			this.O_o._o0___.().Location = new Point(0, 9);
			this.O_o._o0___.().Name = "lblRemoteFile";
			this.O_o._o0___.().Size = new Size(29, 12);
			this.O_o._o0___.().TabIndex = 0;
			this.O_o._o0___.().Text = "下载";
			this.o.0_o0_00.().BackColor = Color.Transparent;
			this.o.0_o0_00.().Controls.Add(this.o.o__0o.());
			this.o.0_o0_00.().Controls.Add(this.Oo.Oo00__oooo.());
			this.o.0_o0_00.().Location = new Point(100, 36);
			this.o.0_o0_00.().Name = "panelLocalFile";
			this.o.0_o0_00.().Size = new Size(116, 22);
			this.o.0_o0_00.().TabIndex = 1;
			this.o.0_o0_00.().Visible = false;
			this.o.o__0o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o.o__0o.().AutoSize = true;
			this.o.o__0o.().Cursor = Cursors.Hand;
			this.o.o__0o.().ForeColor = Color.CornflowerBlue;
			this.o.o__0o.().Location = new Point(40, 9);
			this.o.o__0o.().Name = "lblOpenFolder";
			this.o.o__0o.().Size = new Size(65, 12);
			this.o.o__0o.().TabIndex = 1;
			this.o.o__0o.().Text = "打开文件夹";
			this.Oo.Oo00__oooo.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Oo.Oo00__oooo.().AutoSize = true;
			this.Oo.Oo00__oooo.().Cursor = Cursors.Hand;
			this.Oo.Oo00__oooo.().ForeColor = Color.CornflowerBlue;
			this.Oo.Oo00__oooo.().Location = new Point(0, 9);
			this.Oo.Oo00__oooo.().Name = "lblOpenFile";
			this.Oo.Oo00__oooo.().Size = new Size(29, 12);
			this.Oo.Oo00__oooo.().TabIndex = 0;
			this.Oo.Oo00__oooo.().Text = "打开";
			this.o_O.O000o__.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o_O.O000o__.().Enabled = false;
			this.o_O.O000o__.().ImageKey = "capture";
			this.o_O.O000o__.().ImageList = this.O_0oOOO_.OO.();
			this.o_O.O000o__.().Location = new Point(209, 112);
			this.o_O.O000o__.().Name = "btnCapture";
			this.o_O.O000o__.().Size = new Size(35, 23);
			this.o_O.O000o__.().TabIndex = 6;
			this.O._o_O0O.().SetToolTip(this.o_O.O000o__.(), "截图(Ctrl+Shift+O)");
			this.o_O.O000o__.().UseVisualStyleBackColor = true;
			this.o_O.O000o__.().VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
			this.oOO____o.0o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.oOO____o.0o.().ImageIndex = 9;
			this.oOO____o.0o.().ImageList = this.O_0oOOO_.OO.();
			this.oOO____o.0o.().Location = new Point(86, 112);
			this.oOO____o.0o.().Name = "btnMeeting";
			this.oOO____o.0o.().Size = new Size(35, 23);
			this.oOO____o.0o.().TabIndex = 2;
			this.O._o_O0O.().SetToolTip(this.oOO____o.0o.(), "召开会议");
			this.oOO____o.0o.().UseVisualStyleBackColor = true;
			this.oOO____o.0o.().VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
			this.Oo_._O0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Oo_._O0.().ImageKey = "color";
			this.Oo_._O0.().ImageList = this.O_0oOOO_.OO.();
			this.Oo_._O0.().Location = new Point(45, 112);
			this.Oo_._O0.().Name = "btnColor";
			this.Oo_._O0.().Size = new Size(35, 23);
			this.Oo_._O0.().TabIndex = 1;
			this.O._o_O0O.().SetToolTip(this.Oo_._O0.(), "选择颜色");
			this.Oo_._O0.().UseVisualStyleBackColor = true;
			this.Oo_._O0.().VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
			this.oOo00_.0Oo.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.oOo00_.0Oo.().Enabled = false;
			this.oOo00_.0Oo.().ImageKey = "upload";
			this.oOo00_.0Oo.().ImageList = this.O_0oOOO_.OO.();
			this.oOo00_.0Oo.().Location = new Point(168, 112);
			this.oOo00_.0Oo.().Name = "btnFile";
			this.oOo00_.0Oo.().Size = new Size(35, 23);
			this.oOo00_.0Oo.().TabIndex = 5;
			this.O._o_O0O.().SetToolTip(this.oOo00_.0Oo.(), "发送文件");
			this.oOo00_.0Oo.().UseVisualStyleBackColor = true;
			this.oOo00_.0Oo.().VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
			this.Oo_oo._O_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.Oo_oo._O_.().Enabled = false;
			this.Oo_oo._O_.().Location = new Point(447, 112);
			this.Oo_oo._O_.().Name = "btnCloseChat";
			this.Oo_oo._O_.().Size = new Size(76, 23);
			this.Oo_oo._O_.().TabIndex = 7;
			this.Oo_oo._O_.().Text = "关闭会话";
			this.Oo_oo._O_.().UseVisualStyleBackColor = true;
			this.Oo_oo._O_.().VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
			this.oOO._O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.oOO._O.().Enabled = false;
			this.oOO._O.().ImageKey = "face";
			this.oOO._O.().ImageList = this.O_0oOOO_.OO.();
			this.oOO._O.().Location = new Point(127, 112);
			this.oOO._O.().Name = "btnFace";
			this.oOO._O.().Size = new Size(35, 23);
			this.oOO._O.().TabIndex = 6;
			this.O._o_O0O.().SetToolTip(this.oOO._O.(), "发送表情");
			this.oOO._O.().UseVisualStyleBackColor = true;
			this.oOO._O.().VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
			this.O_OO0.oo.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O_OO0.oo.().ImageKey = "font";
			this.O_OO0.oo.().ImageList = this.O_0oOOO_.OO.();
			this.O_OO0.oo.().Location = new Point(4, 112);
			this.O_OO0.oo.().Name = "btnFont";
			this.O_OO0.oo.().Size = new Size(35, 23);
			this.O_OO0.oo.().TabIndex = 0;
			this.O._o_O0O.().SetToolTip(this.O_OO0.oo.(), "选择字体");
			this.O_OO0.oo.().UseVisualStyleBackColor = true;
			this.O_OO0.oo.().VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
			this.OO0_O0.o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.OO0_O0.o.().Enabled = false;
			this.OO0_O0.o.().Location = new Point(529, 112);
			this.OO0_O0.o.().Name = "btnSend";
			this.OO0_O0.o.().Size = new Size(76, 23);
			this.OO0_O0.o.().TabIndex = 8;
			this.OO0_O0.o.().Text = "发送(&S)";
			this.OO0_O0.o.().UseVisualStyleBackColor = true;
			this.OO0_O0.o.().VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
			this.O._o_O0O.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.O._o_O0O.().Enabled = false;
			this.O._o_O0O.().Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.O._o_O0O.().Location = new Point(0, 3);
			this.O._o_O0O.().Multiline = true;
			this.O._o_O0O.().Name = "txtSender";
			this.O._o_O0O.().Size = new Size(625, 103);
			this.O._o_O0O.().TabIndex = 0;
			this.Oo.Oo00__oooo.().Controls.Add(this.O._o_O0O.());
			this.Oo.Oo00__oooo.().Controls.Add(this.o.o00_0O0o.());
			this.Oo.Oo00__oooo.().Controls.Add(this.O0O_o.O_O.());
			this.Oo.Oo00__oooo.().Controls.Add(this.o.o00_0O0o.());
			this.Oo.Oo00__oooo.().Controls.Add(this.O0Oo0O_.O_oooO.());
			this.Oo.Oo00__oooo.().Controls.Add(this.ooO.0o00__0.());
			this.Oo.Oo00__oooo.().Controls.Add(this.oOo_O_._.());
			this.Oo.Oo00__oooo.().Controls.Add(this.Ooo.O_OOOo00.());
			this.Oo.Oo00__oooo.().Controls.Add(this.Oo.Oo00__oooo.());
			this.Oo.Oo00__oooo.().ImageIndex = 4;
			this.Oo.Oo00__oooo.().Location = new Point(1, 25);
			this.Oo.Oo00__oooo.().Name = "C1DockingTabPage4";
			this.Oo.Oo00__oooo.().Size = new Size(626, 529);
			this.Oo.Oo00__oooo.().TabIndex = 1;
			this.Oo.Oo00__oooo.().Text = "记录";
			this.O._o_O0O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O._o_O0O.().AutoSize = true;
			this.O._o_O0O.().BackColor = Color.Transparent;
			this.O._o_O0O.().Location = new Point(109, 506);
			this.O._o_O0O.().Name = "rdoFiles";
			this.O._o_O0O.().Size = new Size(47, 16);
			this.O._o_O0O.().TabIndex = 14;
			this.O._o_O0O.().Text = "文件";
			this.O._o_O0O.().UseVisualStyleBackColor = false;
			this.o.o00_0O0o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o.o00_0O0o.().AutoSize = true;
			this.o.o00_0O0o.().BackColor = Color.Transparent;
			this.o.o00_0O0o.().Location = new Point(56, 506);
			this.o.o00_0O0o.().Name = "rdoPicture";
			this.o.o00_0O0o.().Size = new Size(47, 16);
			this.o.o00_0O0o.().TabIndex = 13;
			this.o.o00_0O0o.().Text = "图片";
			this.o.o00_0O0o.().UseVisualStyleBackColor = false;
			this.O0O_o.O_O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O0O_o.O_O.().AutoSize = true;
			this.O0O_o.O_O.().BackColor = Color.Transparent;
			this.O0O_o.O_O.().Checked = true;
			this.O0O_o.O_O.().Location = new Point(3, 506);
			this.O0O_o.O_O.().Name = "rdoAll";
			this.O0O_o.O_O.().Size = new Size(47, 16);
			this.O0O_o.O_O.().TabIndex = 12;
			this.O0O_o.O_O.().TabStop = true;
			this.O0O_o.O_O.().Text = "全部";
			this.O0O_o.O_O.().UseVisualStyleBackColor = false;
			this.o.o00_0O0o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.o.o00_0O0o.().Location = new Point(520, 502);
			this.o.o00_0O0o.().Name = "txtPages";
			this.o.o00_0O0o.().Size = new Size(65, 21);
			this.o.o00_0O0o.().TabIndex = 11;
			this.o.o00_0O0o.().TextAlign = HorizontalAlignment.Center;
			this.O0Oo0O_.O_oooO.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O0Oo0O_.O_oooO.().FlatAppearance.BorderSize = 0;
			this.O0Oo0O_.O_oooO.().FlatStyle = FlatStyle.Flat;
			this.O0Oo0O_.O_oooO.().Location = new Point(491, 506);
			this.O0Oo0O_.O_oooO.().Name = "btnFirst";
			this.O0Oo0O_.O_oooO.().Size = new Size(11, 12);
			this.O0Oo0O_.O_oooO.().TabIndex = 7;
			this.O0Oo0O_.O_oooO.().UseVisualStyleBackColor = false;
			this.ooO.0o00__0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.ooO.0o00__0.().FlatAppearance.BorderSize = 0;
			this.ooO.0o00__0.().FlatStyle = FlatStyle.Flat;
			this.ooO.0o00__0.().Location = new Point(590, 506);
			this.ooO.0o00__0.().Name = "btnNext";
			this.ooO.0o00__0.().Size = new Size(8, 12);
			this.ooO.0o00__0.().TabIndex = 10;
			this.ooO.0o00__0.().UseVisualStyleBackColor = false;
			this.oOo_O_._.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.oOo_O_._.().FlatAppearance.BorderSize = 0;
			this.oOo_O_._.().FlatStyle = FlatStyle.Flat;
			this.oOo_O_._.().Location = new Point(507, 506);
			this.oOo_O_._.().Name = "btnPrev";
			this.oOo_O_._.().Size = new Size(8, 12);
			this.oOo_O_._.().TabIndex = 9;
			this.oOo_O_._.().UseVisualStyleBackColor = false;
			this.Ooo.O_OOOo00.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.Ooo.O_OOOo00.().FlatAppearance.BorderSize = 0;
			this.Ooo.O_OOOo00.().FlatStyle = FlatStyle.Flat;
			this.Ooo.O_OOOo00.().Location = new Point(603, 506);
			this.Ooo.O_OOOo00.().Name = "btnLast";
			this.Ooo.O_OOOo00.().Size = new Size(11, 12);
			this.Ooo.O_OOOo00.().TabIndex = 8;
			this.Ooo.O_OOOo00.().UseVisualStyleBackColor = false;
			this.Oo.Oo00__oooo.().AllowEditing = false;
			this.Oo.Oo00__oooo.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.Oo.Oo00__oooo.().AutoClipboard = true;
			this.Oo.Oo00__oooo.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			this.Oo.Oo00__oooo.().ColumnInfo = "2,0,0,0,0,90,Columns:";
			this.Oo.Oo00__oooo.().ExtendLastCol = true;
			this.Oo.Oo00__oooo.().FocusRect = FocusRectEnum.None;
			this.Oo.Oo00__oooo.().Font = new Font("宋体", 9f);
			this.Oo.Oo00__oooo.().HighLight = HighLightEnum.WithFocus;
			this.Oo.Oo00__oooo.().Location = new Point(0, 0);
			this.Oo.Oo00__oooo.().Name = "gridHistory";
			this.Oo.Oo00__oooo.().Rows.Count = 0;
			this.Oo.Oo00__oooo.().Rows.DefaultSize = 18;
			this.Oo.Oo00__oooo.().Rows.Fixed = 0;
			this.Oo.Oo00__oooo.().Size = new Size(624, 496);
			this.Oo.Oo00__oooo.().StyleInfo = componentResourceManager.GetString("gridHistory.StyleInfo");
			this.Oo.Oo00__oooo.().TabIndex = 0;
			this.Oo.Oo00__oooo.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
			this.O.ooO_0_.().Items.AddRange(new ToolStripItem[]
			{
				this.O_o_0.oo0.(),
				this.o0oo0.O0O0.()
			});
			this.O.ooO_0_.().Name = "ContextMenuStrip1";
			this.O.ooO_0_.().Size = new Size(134, 48);
			this.O_o_0.oo0.().Name = "menuMyFont";
			this.O_o_0.oo0.().Size = new Size(133, 22);
			this.O_o_0.oo0.().Text = "我方字体...";
			this.o0oo0.O0O0.().Name = "menuBudyFont";
			this.o0oo0.O0O0.().Size = new Size(133, 22);
			this.o0oo0.O0O0.().Text = "对方字体...";
			this.ooOoo___0.oO0.().Items.AddRange(new ToolStripItem[]
			{
				this.oo_o00O._.(),
				this.o0O_o_0Oo.OO_.()
			});
			this.ooOoo___0.oO0.().Name = "ContextMenuStrip1";
			this.ooOoo___0.oO0.().Size = new Size(134, 48);
			this.oo_o00O._.().Name = "menuMyColor";
			this.oo_o00O._.().Size = new Size(133, 22);
			this.oo_o00O._.().Text = "我方颜色...";
			this.o0O_o_0Oo.OO_.().Name = "MenuBudyColor";
			this.o0O_o_0Oo.OO_.().Size = new Size(133, 22);
			this.o0O_o_0Oo.OO_.().Text = "对方颜色...";
			this.O0oO_Oo0oO_.o.().Items.AddRange(new ToolStripItem[]
			{
				this.ooOoo___0.oO0.(),
				this.o_oO__.0.(),
				this.o.0_o0_00.(),
				this.O0_O_0__o._.()
			});
			this.O0oO_Oo0oO_.o.().Name = "ContextMenuStrip1";
			this.O0oO_Oo0oO_.o.().Size = new Size(146, 76);
			this.ooOoo___0.oO0.().Name = "MenuFinishMeeting";
			this.ooOoo___0.oO0.().Size = new Size(145, 22);
			this.ooOoo___0.oO0.().Text = "结束此会议...";
			this.o_oO__.0.().Name = "MenuSelectMeetingUser";
			this.o_oO__.0.().Size = new Size(145, 22);
			this.o_oO__.0.().Text = "重选与会者...";
			this.o.0_o0_00.().Name = "menuSeparator";
			this.o.0_o0_00.().Size = new Size(142, 6);
			this.O0_O_0__o._.().Name = "menuChangePassword";
			this.O0_O_0__o._.().Size = new Size(145, 22);
			this.O0_O_0__o._.().Text = "修改密码...";
			this.O._o_O0O.().Enabled = true;
			this.O._o_O0O.().Interval = 1000;
			this.o_oO__.0.().Items.AddRange(new ToolStripItem[]
			{
				this.oOoo0__oO0.Oo.(),
				this.oO_.oO000.()
			});
			this.o_oO__.0.().Name = "MenuSend";
			this.o_oO__.0.().Size = new Size(125, 48);
			this.oOoo0__oO0.Oo.().Name = "常规发送ToolStripMenuItem";
			this.oOoo0__oO0.Oo.().Size = new Size(124, 22);
			this.oOoo0__oO0.Oo.().Text = "常规发送";
			this.oO_.oO000.().Name = "弹窗发送ToolStripMenuItem";
			this.oO_.oO000.().Size = new Size(124, 22);
			this.oO_.oO000.().Text = "弹窗发送";
			this.o.0_o0_00.().Items.AddRange(new ToolStripItem[]
			{
				this.OooO0.0OOoO_.(),
				this.O_.O0ooO.(),
				this.o.0_o0_00.()
			});
			this.o.0_o0_00.().Name = "mnuCapture";
			this.o.0_o0_00.().Size = new Size(197, 70);
			this.OooO0.0OOoO_.().Name = "mnuItemCapture";
			this.OooO0.0OOoO_.().ShortcutKeys = (Keys)393295;
			this.OooO0.0OOoO_.().ShowShortcutKeys = false;
			this.OooO0.0OOoO_.().Size = new Size(196, 22);
			this.OooO0.0OOoO_.().Text = "屏幕截图 Ctrl+Alt+O";
			this.O_.O0ooO.().Name = "mnuHideWindow";
			this.O_.O0ooO.().Size = new Size(196, 22);
			this.O_.O0ooO.().Text = "截图时隐藏会话窗口";
			this.o.0_o0_00.().Name = "mnuHideMainWindow";
			this.o.0_o0_00.().Size = new Size(196, 22);
			this.o.0_o0_00.().Text = "截图时隐藏主界面窗口";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(825, 555);
			base.Controls.Add(this.O._o_O0O.());
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "o0OO...o";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "OpenQQ 2019";
			this.O._o_O0O.().Panel1.ResumeLayout(false);
			this.O._o_O0O.().Panel2.ResumeLayout(false);
			this.O._o_O0O.().ResumeLayout(false);
			((ISupportInitialize)this.oOOoo._.()).EndInit();
			this.oOOoo._.().ResumeLayout(false);
			this.ooO.0o00__0.().ResumeLayout(false);
			((ISupportInitialize)this.Oo.Oo00__oooo.()).EndInit();
			this.OO0_O0.o.().ResumeLayout(false);
			((ISupportInitialize)this.O_0oOOO_.OO.()).EndInit();
			((ISupportInitialize)this.ooO.0o00__0.()).EndInit();
			this.ooO.0o00__0.().ResumeLayout(false);
			this.O_o._o0___.().ResumeLayout(false);
			this.o.o00_0O0o.().Panel1.ResumeLayout(false);
			this.o.o00_0O0o.().Panel2.ResumeLayout(false);
			this.o.o00_0O0o.().Panel2.PerformLayout();
			this.o.o00_0O0o.().ResumeLayout(false);
			((ISupportInitialize)this.O_0oOOO_.OO.()).EndInit();
			((ISupportInitialize)this.oO____oooO.0_O.()).EndInit();
			((ISupportInitialize)this.oOOoo._.()).EndInit();
			this.o.o00_0O0o.().ResumeLayout(false);
			this.o.o00_0O0o.().PerformLayout();
			this.o_oO__.0.().ResumeLayout(false);
			this.o_oO__.0.().PerformLayout();
			this.o.0_o0_00.().ResumeLayout(false);
			this.o.0_o0_00.().PerformLayout();
			((ISupportInitialize)this.o_O.O000o__.()).EndInit();
			((ISupportInitialize)this.oOO____o.0o.()).EndInit();
			((ISupportInitialize)this.Oo_._O0.()).EndInit();
			((ISupportInitialize)this.oOo00_.0Oo.()).EndInit();
			((ISupportInitialize)this.Oo_oo._O_.()).EndInit();
			((ISupportInitialize)this.oOO._O.()).EndInit();
			((ISupportInitialize)this.O_OO0.oo.()).EndInit();
			((ISupportInitialize)this.OO0_O0.o.()).EndInit();
			this.Oo.Oo00__oooo.().ResumeLayout(false);
			this.Oo.Oo00__oooo.().PerformLayout();
			((ISupportInitialize)this.Oo.Oo00__oooo.()).EndInit();
			this.O.ooO_0_.().ResumeLayout(false);
			this.ooOoo___0.oO0.().ResumeLayout(false);
			this.O0oO_Oo0oO_.o.().ResumeLayout(false);
			this.o_oO__.0.().ResumeLayout(false);
			this.o.0_o0_00.().ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00088EA1 File Offset: 0x000870A1
		[CompilerGenerated]
		internal virtual SplitContainer <<EMPTY_NAME>>()
		{
			return this.o0o._O.;
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00088EA9 File Offset: 0x000870A9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SplitContainer A_0)
		{
			this.o0o._O. = A_0;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00088EB2 File Offset: 0x000870B2
		[CompilerGenerated]
		internal virtual Oo0O <<EMPTY_NAME>>()
		{
			return this.O_0O00.___.;
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00088EBC File Offset: 0x000870BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Oo0O A_0)
		{
			RangeEventHandler value = new RangeEventHandler(this.oO_.oO000.);
			RangeEventHandler value2 = new RangeEventHandler(this.oo_.oOOoO.);
			BeforeMouseDownEventHandler value3 = new BeforeMouseDownEventHandler(this.o0__.O_Ooo_.);
			EventHandler value4 = new EventHandler(this.o000O.Oo_Oooo.);
			EventHandler value5 = new EventHandler(this.Ooo.0oOOoO.);
			EventHandler value6 = new EventHandler(this.oo_.oOOoO.);
			Oo0O o_0O00.___. = this.O_0O00.___.;
			if (o_0O00.___. != null)
			{
				o_0O00.___..AfterScroll -= value;
				o_0O00.___..AfterSelChange -= value2;
				o_0O00.___..BeforeMouseDown -= value3;
				o_0O00.___..DoubleClick -= value4;
				o_0O00.___..GotFocus -= value5;
				o_0O00.___..LostFocus -= value6;
			}
			this.O_0O00.___. = A_0;
			o_0O00.___. = this.O_0O00.___.;
			if (o_0O00.___. != null)
			{
				o_0O00.___..AfterScroll += value;
				o_0O00.___..AfterSelChange += value2;
				o_0O00.___..BeforeMouseDown += value3;
				o_0O00.___..DoubleClick += value4;
				o_0O00.___..GotFocus += value5;
				o_0O00.___..LostFocus += value6;
			}
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00088F9C File Offset: 0x0008719C
		[CompilerGenerated]
		internal virtual ImageList <<EMPTY_NAME>>()
		{
			return this.O_0O00.___.;
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00088FA4 File Offset: 0x000871A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ImageList A_0)
		{
			this.O_0O00.___. = A_0;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00088FAD File Offset: 0x000871AD
		[CompilerGenerated]
		internal virtual OO___OO0O_0 <<EMPTY_NAME>>()
		{
			return this.oooO.O000_O_.;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00088FB8 File Offset: 0x000871B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(OO___OO0O_0 A_0)
		{
			EventHandler value = new EventHandler(this.O_O0O0OoOO_.o.);
			OO___OO0O_0 oo___OO0O_ = this.oooO.O000_O_.;
			if (oo___OO0O_ != null)
			{
				oo___OO0O_.SelectedIndexChanged -= value;
			}
			this.oooO.O000_O_. = A_0;
			oo___OO0O_ = this.oooO.O000_O_.;
			if (oo___OO0O_ != null)
			{
				oo___OO0O_.SelectedIndexChanged += value;
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00088FFB File Offset: 0x000871FB
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.oooO.O000_O_.;
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00089003 File Offset: 0x00087203
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.oooO.O000_O_. = A_0;
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0008900C File Offset: 0x0008720C
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.O.oO0O.;
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00089014 File Offset: 0x00087214
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.O.oO0O. = A_0;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0008901D File Offset: 0x0008721D
		[CompilerGenerated]
		internal virtual Oo0O <<EMPTY_NAME>>()
		{
			return this.OOoOOO_o_.o0_.;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00089028 File Offset: 0x00087228
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Oo0O A_0)
		{
			RangeEventHandler value = new RangeEventHandler(this.oO_.oO000.);
			RangeEventHandler value2 = new RangeEventHandler(this.oo_.oOOoO.);
			BeforeMouseDownEventHandler value3 = new BeforeMouseDownEventHandler(this.o0__.O_Ooo_.);
			EventHandler value4 = new EventHandler(this.o000O.Oo_Oooo.);
			EventHandler value5 = new EventHandler(this.Ooo.0oOOoO.);
			EventHandler value6 = new EventHandler(this.OooOoo.O_.);
			EventHandler value7 = new EventHandler(this.OooOoo.O_.);
			EventHandler value8 = new EventHandler(this.oo_.oOOoO.);
			Oo0O oooOOO_o_.o0_. = this.OOoOOO_o_.o0_.;
			if (oooOOO_o_.o0_. != null)
			{
				oooOOO_o_.o0_..AfterScroll -= value;
				oooOOO_o_.o0_..AfterSelChange -= value2;
				oooOOO_o_.o0_..BeforeMouseDown -= value3;
				oooOOO_o_.o0_..DoubleClick -= value4;
				oooOOO_o_.o0_..GotFocus -= value5;
				oooOOO_o_.o0_..SizeChanged -= value6;
				oooOOO_o_.o0_..SizeChanged -= value7;
				oooOOO_o_.o0_..LostFocus -= value8;
			}
			this.OOoOOO_o_.o0_. = A_0;
			oooOOO_o_.o0_. = this.OOoOOO_o_.o0_.;
			if (oooOOO_o_.o0_. != null)
			{
				oooOOO_o_.o0_..AfterScroll += value;
				oooOOO_o_.o0_..AfterSelChange += value2;
				oooOOO_o_.o0_..BeforeMouseDown += value3;
				oooOOO_o_.o0_..DoubleClick += value4;
				oooOOO_o_.o0_..GotFocus += value5;
				oooOOO_o_.o0_..SizeChanged += value6;
				oooOOO_o_.o0_..SizeChanged += value7;
				oooOOO_o_.o0_..LostFocus += value8;
			}
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00089148 File Offset: 0x00087348
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o0o._O.;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00089150 File Offset: 0x00087350
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			KeyEventHandler value = new KeyEventHandler(this.o000_._o.);
			C1TextBox c1TextBox = this.o0o._O.;
			if (c1TextBox != null)
			{
				c1TextBox.KeyDown -= value;
			}
			this.o0o._O. = A_0;
			c1TextBox = this.o0o._O.;
			if (c1TextBox != null)
			{
				c1TextBox.KeyDown += value;
			}
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00089193 File Offset: 0x00087393
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oooO.O000_O_.;
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0008919C File Offset: 0x0008739C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Ooo0_O_00oo.O.);
			C1Button c1Button = this.oooO.O000_O_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oooO.O000_O_. = A_0;
			c1Button = this.oooO.O000_O_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x000891DF File Offset: 0x000873DF
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.Ooo.o_0oOo0_0.;
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x000891E8 File Offset: 0x000873E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			KeyEventHandler value = new KeyEventHandler(this.ooOo00_o0o.Ooo.);
			C1TextBox ooo.o_0oOo0_0. = this.Ooo.o_0oOo0_0.;
			if (ooo.o_0oOo0_0. != null)
			{
				ooo.o_0oOo0_0..KeyDown -= value;
			}
			this.Ooo.o_0oOo0_0. = A_0;
			ooo.o_0oOo0_0. = this.Ooo.o_0oOo0_0.;
			if (ooo.o_0oOo0_0. != null)
			{
				ooo.o_0oOo0_0..KeyDown += value;
			}
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0008922B File Offset: 0x0008742B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooO.O_OOo0o.;
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00089234 File Offset: 0x00087434
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0O0OO.o__O.);
			C1Button c1Button = this.ooO.O_OOo0o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooO.O_OOo0o. = A_0;
			c1Button = this.ooO.O_OOo0o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00089277 File Offset: 0x00087477
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo000._o0O0O.;
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00089280 File Offset: 0x00087480
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo0O_.__.);
			C1Button oo000._o0O0O. = this.Oo000._o0O0O.;
			if (oo000._o0O0O. != null)
			{
				oo000._o0O0O..Click -= value;
			}
			this.Oo000._o0O0O. = A_0;
			oo000._o0O0O. = this.Oo000._o0O0O.;
			if (oo000._o0O0O. != null)
			{
				oo000._o0O0O..Click += value;
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x000892C3 File Offset: 0x000874C3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOoo0_0O_._Oo0.;
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x000892CC File Offset: 0x000874CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0o0.Oo_.);
			C1Button oooo0_0O_._Oo0. = this.OOoo0_0O_._Oo0.;
			if (oooo0_0O_._Oo0. != null)
			{
				oooo0_0O_._Oo0..Click -= value;
			}
			this.OOoo0_0O_._Oo0. = A_0;
			oooo0_0O_._Oo0. = this.OOoo0_0O_._Oo0.;
			if (oooo0_0O_._Oo0. != null)
			{
				oooo0_0O_._Oo0..Click += value;
			}
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0008930F File Offset: 0x0008750F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_.__0o_Ooo.;
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00089318 File Offset: 0x00087518
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_0.OO_.);
			C1Button oo_.__0o_Ooo. = this.Oo_.__0o_Ooo.;
			if (oo_.__0o_Ooo. != null)
			{
				oo_.__0o_Ooo..Click -= value;
			}
			this.Oo_.__0o_Ooo. = A_0;
			oo_.__0o_Ooo. = this.Oo_.__0o_Ooo.;
			if (oo_.__0o_Ooo. != null)
			{
				oo_.__0o_Ooo..Click += value;
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0008935B File Offset: 0x0008755B
		[CompilerGenerated]
		internal virtual OO___OO0O_0 <<EMPTY_NAME>>()
		{
			return this.O.oO0O.;
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00089363 File Offset: 0x00087563
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(OO___OO0O_0 A_0)
		{
			this.O.oO0O. = A_0;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0008936C File Offset: 0x0008756C
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.O_0.ooo0_Oo0.;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00089374 File Offset: 0x00087574
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.O_0.ooo0_Oo0. = A_0;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0008937D File Offset: 0x0008757D
		[CompilerGenerated]
		internal virtual o0ooo_0_00oO <<EMPTY_NAME>>()
		{
			return this.oooO.O000_O_.;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00089388 File Offset: 0x00087588
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(o0ooo_0_00oO A_0)
		{
			C1TopicBarClickEventHandler value = new C1TopicBarClickEventHandler(this.o0_o0o.0o0O0_o.);
			o0ooo_0_00oO o0ooo_0_00oO = this.oooO.O000_O_.;
			if (o0ooo_0_00oO != null)
			{
				o0ooo_0_00oO.LinkClick -= value;
			}
			this.oooO.O000_O_. = A_0;
			o0ooo_0_00oO = this.oooO.O000_O_.;
			if (o0ooo_0_00oO != null)
			{
				o0ooo_0_00oO.LinkClick += value;
			}
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x000893CB File Offset: 0x000875CB
		[CompilerGenerated]
		internal virtual SplitContainer <<EMPTY_NAME>>()
		{
			return this.Ooo.o_0oOo0_0.;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x000893D3 File Offset: 0x000875D3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SplitContainer A_0)
		{
			this.Ooo.o_0oOo0_0. = A_0;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x000893DC File Offset: 0x000875DC
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_000OO0O.OO__.;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x000893E4 File Offset: 0x000875E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0OO.O_.);
			C1Button c1Button = this.o_000OO0O.OO__.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_000OO0O.OO__. = A_0;
			c1Button = this.o_000OO0O.OO__.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00089427 File Offset: 0x00087627
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0O0_0OO0.0.;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00089430 File Offset: 0x00087630
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0OOooO._.);
			C1Button c1Button = this.o0O0_0OO0.0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0O0_0OO0.0. = A_0;
			c1Button = this.o0O0_0OO0.0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00089473 File Offset: 0x00087673
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOoO00O00.00__.;
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0008947C File Offset: 0x0008767C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_O._OO0__O.);
			C1Button oooO00O00.00__. = this.OOoO00O00.00__.;
			if (oooO00O00.00__. != null)
			{
				oooO00O00.00__..Click -= value;
			}
			this.OOoO00O00.00__. = A_0;
			oooO00O00.00__. = this.OOoO00O00.00__.;
			if (oooO00O00.00__. != null)
			{
				oooO00O00.00__..Click += value;
			}
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x000894BF File Offset: 0x000876BF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_o0._OO0O.;
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x000894C8 File Offset: 0x000876C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_00_oOOoOOo.0.);
			C1Button c1Button = this.o_o0._OO0O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_o0._OO0O. = A_0;
			c1Button = this.o_o0._OO0O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0008950B File Offset: 0x0008770B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_o.____O_o.;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00089514 File Offset: 0x00087714
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0o_.O0O_.);
			C1Button o_o.____O_o. = this.O_o.____O_o.;
			if (o_o.____O_o. != null)
			{
				o_o.____O_o..Click -= value;
			}
			this.O_o.____O_o. = A_0;
			o_o.____O_o. = this.O_o.____O_o.;
			if (o_o.____O_o. != null)
			{
				o_o.____O_o..Click += value;
			}
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00089557 File Offset: 0x00087757
		[CompilerGenerated]
		internal virtual ToolTip <<EMPTY_NAME>>()
		{
			return this.o0o._O.;
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0008955F File Offset: 0x0008775F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolTip A_0)
		{
			this.o0o._O. = A_0;
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00089568 File Offset: 0x00087768
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.O_OO0o__o_.00O.;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00089570 File Offset: 0x00087770
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.O_OO0o__o_.00O. = A_0;
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0008957C File Offset: 0x0008777C
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O_OO0o__o_.00O.;
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00089590 File Offset: 0x00087790
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.ooO_.__O_0O0o.);
				ToolStripMenuItem o_OO0o__o_.00O. = this.O_OO0o__o_.00O.;
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						o_OO0o__o_.00O..Click -= value;
						num = 4;
						continue;
					case 2:
						if (o_OO0o__o_.00O. != null)
						{
							num = 5;
							continue;
						}
						return;
					case 3:
						if (true)
						{
						}
						if (o_OO0o__o_.00O. != null)
						{
							num = 1;
							continue;
						}
						goto IL_62;
					case 4:
						goto IL_62;
					case 5:
						o_OO0o__o_.00O..Click += value;
						num = 0;
						continue;
					}
					break;
					IL_62:
					this.O_OO0o__o_.00O. = A_0;
					o_OO0o__o_.00O. = this.O_OO0o__o_.00O.;
					num = 2;
				}
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0008963C File Offset: 0x0008783C
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O0o0_0_oO._.;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00089650 File Offset: 0x00087850
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.Oo._O0OoO_.);
				ToolStripMenuItem o0o0_0_oO._. = this.O0o0_0_oO._.;
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						o0o0_0_oO._..Click += value;
						num = 2;
						continue;
					case 1:
						o0o0_0_oO._..Click -= value;
						num = 4;
						continue;
					case 2:
						return;
					case 3:
						if (o0o0_0_oO._. != null)
						{
							if (true)
							{
							}
							num = 1;
							continue;
						}
						goto IL_62;
					case 4:
						goto IL_62;
					case 5:
						if (o0o0_0_oO._. != null)
						{
							num = 0;
							continue;
						}
						return;
					}
					break;
					IL_62:
					this.O0o0_0_oO._. = A_0;
					o0o0_0_oO._. = this.O0o0_0_oO._.;
					num = 5;
				}
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x000896F9 File Offset: 0x000878F9
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.O0o0_0_oO._.;
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00089701 File Offset: 0x00087901
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.O0o0_0_oO._. = A_0;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0008970C File Offset: 0x0008790C
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o_oO00._Oo00__.;
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00089720 File Offset: 0x00087920
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.OoO0_oOO_.ooO.);
				ToolStripMenuItem toolStripMenuItem = this.o_oO00._Oo00__.;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (toolStripMenuItem != null)
						{
							num = 2;
							continue;
						}
						goto IL_5A;
					case 1:
						return;
					case 2:
						if (true)
						{
						}
						toolStripMenuItem.Click -= value;
						num = 4;
						continue;
					case 3:
						toolStripMenuItem.Click += value;
						num = 1;
						continue;
					case 4:
						goto IL_5A;
					case 5:
						if (toolStripMenuItem != null)
						{
							num = 3;
							continue;
						}
						return;
					}
					break;
					IL_5A:
					this.o_oO00._Oo00__. = A_0;
					toolStripMenuItem = this.o_oO00._Oo00__.;
					num = 5;
				}
			}
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x000897C8 File Offset: 0x000879C8
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O0O0._o.;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x000897DC File Offset: 0x000879DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O00.00__o.);
				ToolStripMenuItem o0O0._o. = this.O0O0._o.;
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (o0O0._o. != null)
						{
							num = 1;
							continue;
						}
						return;
					case 1:
						o0O0._o..Click += value;
						num = 5;
						continue;
					case 2:
						if (true)
						{
						}
						o0O0._o..Click -= value;
						num = 3;
						continue;
					case 3:
						goto IL_5A;
					case 4:
						if (o0O0._o. != null)
						{
							num = 2;
							continue;
						}
						goto IL_5A;
					case 5:
						return;
					}
					break;
					IL_5A:
					this.O0O0._o. = A_0;
					o0O0._o. = this.O0O0._o.;
					num = 0;
				}
			}
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00089882 File Offset: 0x00087A82
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0o_.0OOo.;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0008988C File Offset: 0x00087A8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOOo0_.0OO0__.);
			C1Button o0o_.0OOo. = this.O0o_.0OOo.;
			if (o0o_.0OOo. != null)
			{
				o0o_.0OOo..Click -= value;
			}
			this.O0o_.0OOo. = A_0;
			o0o_.0OOo. = this.O0o_.0OOo.;
			if (o0o_.0OOo. != null)
			{
				o0o_.0OOo..Click += value;
			}
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x000898CF File Offset: 0x00087ACF
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.oOoO._OOo_O0.;
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x000898D7 File Offset: 0x00087AD7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.oOoO._OOo_O0. = A_0;
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x000898E0 File Offset: 0x00087AE0
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O_OoO.OO_0_.;
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x000898F4 File Offset: 0x00087AF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O__oOoOO.OO0.);
				ToolStripMenuItem o_OoO.OO_0_. = this.O_OoO.OO_0_.;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (o_OoO.OO_0_. != null)
						{
							num = 1;
							continue;
						}
						goto IL_5A;
					case 1:
						o_OoO.OO_0_..Click -= value;
						num = 5;
						continue;
					case 2:
						if (true)
						{
						}
						if (o_OoO.OO_0_. != null)
						{
							num = 4;
							continue;
						}
						return;
					case 3:
						return;
					case 4:
						o_OoO.OO_0_..Click += value;
						num = 3;
						continue;
					case 5:
						goto IL_5A;
					}
					break;
					IL_5A:
					this.O_OoO.OO_0_. = A_0;
					o_OoO.OO_0_. = this.O_OoO.OO_0_.;
					num = 2;
				}
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x000899A0 File Offset: 0x00087BA0
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O_o.O.;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x000899B4 File Offset: 0x00087BB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O0oO_0o0__.o_.);
				ToolStripMenuItem o_o.O. = this.O_o.O.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (o_o.O. != null)
						{
							num = 3;
							continue;
						}
						return;
					case 1:
						goto IL_62;
					case 2:
						return;
					case 3:
						o_o.O..Click += value;
						num = 2;
						continue;
					case 4:
						o_o.O..Click -= value;
						num = 1;
						continue;
					case 5:
						if (o_o.O. != null)
						{
							if (true)
							{
							}
							num = 4;
							continue;
						}
						goto IL_62;
					}
					break;
					IL_62:
					this.O_o.O. = A_0;
					o_o.O. = this.O_o.O.;
					num = 0;
				}
			}
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00089A5D File Offset: 0x00087C5D
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.OO00O_0._00O_.;
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00089A65 File Offset: 0x00087C65
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.OO00O_0._00O_. = A_0;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00089A6E File Offset: 0x00087C6E
		[CompilerGenerated]
		internal virtual o0ooo_0_00oO <<EMPTY_NAME>>()
		{
			return this.O.oO0O.;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00089A78 File Offset: 0x00087C78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(o0ooo_0_00oO A_0)
		{
			C1TopicBarClickEventHandler value = new C1TopicBarClickEventHandler(this.O_.__OO0o.);
			o0ooo_0_00oO o.oO0O. = this.O.oO0O.;
			if (o.oO0O. != null)
			{
				o.oO0O..LinkClick -= value;
			}
			this.O.oO0O. = A_0;
			o.oO0O. = this.O.oO0O.;
			if (o.oO0O. != null)
			{
				o.oO0O..LinkClick += value;
			}
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00089ABB File Offset: 0x00087CBB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O___o0_o_OO._.;
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00089AC4 File Offset: 0x00087CC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_.__O0.);
			C1Button o___o0_o_OO._. = this.O___o0_o_OO._.;
			if (o___o0_o_OO._. != null)
			{
				o___o0_o_OO._..Click -= value;
			}
			this.O___o0_o_OO._. = A_0;
			o___o0_o_OO._. = this.O___o0_o_OO._.;
			if (o___o0_o_OO._. != null)
			{
				o___o0_o_OO._..Click += value;
			}
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00089B07 File Offset: 0x00087D07
		[CompilerGenerated]
		internal virtual System.Windows.Forms.Timer <<EMPTY_NAME>>()
		{
			return this.o0o._O.;
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00089B10 File Offset: 0x00087D10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.Timer A_0)
		{
			EventHandler value = new EventHandler(this.oO_.0o_.);
			System.Windows.Forms.Timer timer = this.o0o._O.;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			this.o0o._O. = A_0;
			timer = this.o0o._O.;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00089B53 File Offset: 0x00087D53
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_0O00.___.;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00089B5C File Offset: 0x00087D5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			EventHandler value = new EventHandler(this.OOoo0_O.o_O.);
			EventHandler value2 = new EventHandler(this.oo.0_0_.);
			MouseEventHandler value3 = new MouseEventHandler(this.o_0_.Ooo__OOoo.);
			Label o_0O00.___. = this.O_0O00.___.;
			if (o_0O00.___. != null)
			{
				o_0O00.___..MouseEnter -= value;
				o_0O00.___..MouseLeave -= value2;
				o_0O00.___..MouseDown -= value3;
			}
			this.O_0O00.___. = A_0;
			o_0O00.___. = this.O_0O00.___.;
			if (o_0O00.___. != null)
			{
				o_0O00.___..MouseEnter += value;
				o_0O00.___..MouseLeave += value2;
				o_0O00.___..MouseDown += value3;
			}
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00089BD5 File Offset: 0x00087DD5
		[CompilerGenerated]
		internal virtual Panel <<EMPTY_NAME>>()
		{
			return this.O0_Oo_O__._o.;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00089BDD File Offset: 0x00087DDD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Panel A_0)
		{
			this.O0_Oo_O__._o. = A_0;
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00089BE6 File Offset: 0x00087DE6
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OOoOOO_o_.o0_.;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00089BF0 File Offset: 0x00087DF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			EventHandler value = new EventHandler(this.oO_._O0OOOoO0.);
			Label oooOOO_o_.o0_. = this.OOoOOO_o_.o0_.;
			if (oooOOO_o_.o0_. != null)
			{
				oooOOO_o_.o0_..Click -= value;
			}
			this.OOoOOO_o_.o0_. = A_0;
			oooOOO_o_.o0_. = this.OOoOOO_o_.o0_.;
			if (oooOOO_o_.o0_. != null)
			{
				oooOOO_o_.o0_..Click += value;
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00089C33 File Offset: 0x00087E33
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_Oo0.oO_00_.;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00089C3C File Offset: 0x00087E3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			EventHandler value = new EventHandler(this.O_.OOO000o.);
			Label label = this.o_Oo0.oO_00_.;
			if (label != null)
			{
				label.Click -= value;
			}
			this.o_Oo0.oO_00_. = A_0;
			label = this.o_Oo0.oO_00_.;
			if (label != null)
			{
				label.Click += value;
			}
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00089C7F File Offset: 0x00087E7F
		[CompilerGenerated]
		internal virtual Panel <<EMPTY_NAME>>()
		{
			return this.oO_O0o0.o.;
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00089C87 File Offset: 0x00087E87
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Panel A_0)
		{
			this.oO_O0o0.o. = A_0;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00089C90 File Offset: 0x00087E90
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0O0._o.;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00089C98 File Offset: 0x00087E98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			EventHandler value = new EventHandler(this.Oo.Oo.);
			Label o0O0._o. = this.O0O0._o.;
			if (o0O0._o. != null)
			{
				o0O0._o..Click -= value;
			}
			this.O0O0._o. = A_0;
			o0O0._o. = this.O0O0._o.;
			if (o0O0._o. != null)
			{
				o0O0._o..Click += value;
			}
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00089CDB File Offset: 0x00087EDB
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O0_Oo_O__._o.;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00089CE4 File Offset: 0x00087EE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.oO.O00.);
			RadioButton o0_Oo_O__._o. = this.O0_Oo_O__._o.;
			if (o0_Oo_O__._o. != null)
			{
				o0_Oo_O__._o..CheckedChanged -= value;
			}
			this.O0_Oo_O__._o. = A_0;
			o0_Oo_O__._o. = this.O0_Oo_O__._o.;
			if (o0_Oo_O__._o. != null)
			{
				o0_Oo_O__._o..CheckedChanged += value;
			}
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00089D27 File Offset: 0x00087F27
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.Ooo.o_0oOo0_0.;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00089D30 File Offset: 0x00087F30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.oOO00.O.);
			RadioButton ooo.o_0oOo0_0. = this.Ooo.o_0oOo0_0.;
			if (ooo.o_0oOo0_0. != null)
			{
				ooo.o_0oOo0_0..CheckedChanged -= value;
			}
			this.Ooo.o_0oOo0_0. = A_0;
			ooo.o_0oOo0_0. = this.Ooo.o_0oOo0_0.;
			if (ooo.o_0oOo0_0. != null)
			{
				ooo.o_0oOo0_0..CheckedChanged += value;
			}
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00089D73 File Offset: 0x00087F73
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.oOoO._OOo_O0.;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00089D7C File Offset: 0x00087F7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.oOOOOoOo.00_0o.);
			RadioButton radioButton = this.oOoO._OOo_O0.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.oOoO._OOo_O0. = A_0;
			radioButton = this.oOoO._OOo_O0.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00089DBF File Offset: 0x00087FBF
		[CompilerGenerated]
		internal virtual Panel <<EMPTY_NAME>>()
		{
			return this.oOoO._OOo_O0.;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00089DC7 File Offset: 0x00087FC7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Panel A_0)
		{
			this.oOoO._OOo_O0. = A_0;
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00089DD0 File Offset: 0x00087FD0
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_o0_OOO0_0_.O.;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00089DD8 File Offset: 0x00087FD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			EventHandler value = new EventHandler(this.oO0.O0_00oO00_.);
			Label o_o0_OOO0_0_.O. = this.O_o0_OOO0_0_.O.;
			if (o_o0_OOO0_0_.O. != null)
			{
				o_o0_OOO0_0_.O..Click -= value;
			}
			this.O_o0_OOO0_0_.O. = A_0;
			o_o0_OOO0_0_.O. = this.O_o0_OOO0_0_.O.;
			if (o_o0_OOO0_0_.O. != null)
			{
				o_o0_OOO0_0_.O..Click += value;
			}
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00089E1B File Offset: 0x0008801B
		[CompilerGenerated]
		internal virtual ToolStripSeparator <<EMPTY_NAME>>()
		{
			return this.O_OO0o__o_.00O.;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00089E23 File Offset: 0x00088023
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripSeparator A_0)
		{
			this.O_OO0o__o_.00O. = A_0;
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00089E2C File Offset: 0x0008802C
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.OO0__0.O.;
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00089E40 File Offset: 0x00088040
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o_0O___o.0.);
				ToolStripMenuItem oo0__0.O. = this.OO0__0.O.;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (true)
						{
						}
						if (oo0__0.O. != null)
						{
							num = 3;
							continue;
						}
						goto IL_62;
					case 1:
						oo0__0.O..Click += value;
						num = 5;
						continue;
					case 2:
						if (oo0__0.O. != null)
						{
							num = 1;
							continue;
						}
						return;
					case 3:
						oo0__0.O..Click -= value;
						num = 4;
						continue;
					case 4:
						goto IL_62;
					case 5:
						return;
					}
					break;
					IL_62:
					this.OO0__0.O. = A_0;
					oo0__0.O. = this.OO0__0.O.;
					num = 2;
				}
			}
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00089EE9 File Offset: 0x000880E9
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.oOo_O.;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00089EF4 File Offset: 0x000880F4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			MouseEventHandler value = new MouseEventHandler(this.O_.__OO0o.);
			C1Button o.oOo_O. = this.O.oOo_O.;
			if (o.oOo_O. != null)
			{
				o.oOo_O..MouseDown -= value;
			}
			this.O.oOo_O. = A_0;
			o.oOo_O. = this.O.oOo_O.;
			if (o.oOo_O. != null)
			{
				o.oOo_O..MouseDown += value;
			}
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00089F37 File Offset: 0x00088137
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.OO.OO0_o_000.;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00089F3F File Offset: 0x0008813F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.OO.OO0_o_000. = A_0;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00089F48 File Offset: 0x00088148
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O_.0____.;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00089F5C File Offset: 0x0008815C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.OooO_o.___o.);
				ToolStripMenuItem o_.0____. = this.O_.0____.;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						o_.0____..Click -= value;
						num = 1;
						continue;
					case 1:
						goto IL_5A;
					case 2:
						if (o_.0____. != null)
						{
							num = 0;
							continue;
						}
						goto IL_5A;
					case 3:
						return;
					case 4:
						if (o_.0____. != null)
						{
							num = 5;
							continue;
						}
						return;
					case 5:
						o_.0____..Click += value;
						num = 3;
						continue;
					}
					break;
					IL_5A:
					this.O_.0____. = A_0;
					o_.0____. = this.O_.0____.;
					if (true)
					{
					}
					num = 4;
				}
			}
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0008A008 File Offset: 0x00088208
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.OoOo._OOO0_o0.;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x0008A01C File Offset: 0x0008821C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O0_Ooo.ooo.);
				ToolStripMenuItem ooOo._OOO0_o0. = this.OoOo._OOO0_o0.;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (true)
						{
						}
						if (ooOo._OOO0_o0. != null)
						{
							num = 3;
							continue;
						}
						goto IL_62;
					case 1:
						goto IL_62;
					case 2:
						return;
					case 3:
						ooOo._OOO0_o0..Click -= value;
						num = 1;
						continue;
					case 4:
						if (ooOo._OOO0_o0. != null)
						{
							num = 5;
							continue;
						}
						return;
					case 5:
						ooOo._OOO0_o0..Click += value;
						num = 2;
						continue;
					}
					break;
					IL_62:
					this.OoOo._OOO0_o0. = A_0;
					ooOo._OOO0_o0. = this.OoOo._OOO0_o0.;
					num = 4;
				}
			}
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0008A0C5 File Offset: 0x000882C5
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.O_oO0OOo00o_.O.;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0008A0CD File Offset: 0x000882CD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.O_oO0OOo00o_.O. = A_0;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0008A0D8 File Offset: 0x000882D8
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.oO_0.o0OO__o.;
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0008A0EC File Offset: 0x000882EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.oO_o_.___ooOO.);
				ToolStripMenuItem toolStripMenuItem = this.oO_0.o0OO__o.;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (toolStripMenuItem != null)
						{
							num = 3;
							continue;
						}
						goto IL_5A;
					case 1:
						return;
					case 2:
						goto IL_5A;
					case 3:
						if (true)
						{
						}
						toolStripMenuItem.Click -= value;
						num = 2;
						continue;
					case 4:
						toolStripMenuItem.Click += value;
						num = 1;
						continue;
					case 5:
						if (toolStripMenuItem != null)
						{
							num = 4;
							continue;
						}
						return;
					}
					break;
					IL_5A:
					this.oO_0.o0OO__o. = A_0;
					toolStripMenuItem = this.oO_0.o0OO__o.;
					num = 5;
				}
			}
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0008A194 File Offset: 0x00088394
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.oO_00.0O.;
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0008A1A8 File Offset: 0x000883A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.OoO_oOoo.o0.);
				ToolStripMenuItem toolStripMenuItem = this.oO_00.0O.;
				int num = 0;
				for (;;)
				{
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						if (toolStripMenuItem != null)
						{
							num = 3;
							continue;
						}
						goto IL_62;
					case 1:
						toolStripMenuItem.Click += value;
						num = 2;
						continue;
					case 2:
						return;
					case 3:
						toolStripMenuItem.Click -= value;
						num = 4;
						continue;
					case 4:
						goto IL_62;
					case 5:
						if (toolStripMenuItem != null)
						{
							num = 1;
							continue;
						}
						return;
					}
					break;
					IL_62:
					this.oO_00.0O. = A_0;
					toolStripMenuItem = this.oO_00.0O.;
					num = 5;
				}
			}
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0008A251 File Offset: 0x00088451
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.o_OO0oo_.;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0008A25C File Offset: 0x0008845C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Ooo._o_00.);
			C1Button o.o_OO0oo_. = this.O.o_OO0oo_.;
			if (o.o_OO0oo_. != null)
			{
				o.o_OO0oo_..Click -= value;
			}
			this.O.o_OO0oo_. = A_0;
			o.o_OO0oo_. = this.O.o_OO0oo_.;
			if (o.o_OO0oo_. != null)
			{
				o.o_OO0oo_..Click += value;
			}
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0008A2A0 File Offset: 0x000884A0
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O0.__o__00O0.;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0008A2B4 File Offset: 0x000884B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o_o0o_o.O.);
				ToolStripMenuItem o0.__o__00O0. = this.O0.__o__00O0.;
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (o0.__o__00O0. != null)
						{
							num = 5;
							continue;
						}
						return;
					case 2:
						goto IL_62;
					case 3:
						if (o0.__o__00O0. != null)
						{
							if (true)
							{
							}
							num = 4;
							continue;
						}
						goto IL_62;
					case 4:
						o0.__o__00O0..Click -= value;
						num = 2;
						continue;
					case 5:
						o0.__o__00O0..Click += value;
						num = 0;
						continue;
					}
					break;
					IL_62:
					this.O0.__o__00O0. = A_0;
					o0.__o__00O0. = this.O0.__o__00O0.;
					num = 1;
				}
			}
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0008A360 File Offset: 0x00088560
		public f4(IMClient A_0)
		{
			base.Activated += this.o.0OOo.;
			base.FormClosed += this.o0__.O_Ooo_.;
			base.FormClosing += this.o0__.O_Ooo_.;
			base.KeyDown += this.o_O__o_o_0.O.;
			base.Load += this.O._O00O.;
			this.O_0O00.___. = new DataTable();
			this.O.Oo_0O0_0OO_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			foreach (C1FlexGrid c1FlexGrid in new C1FlexGrid[]
			{
				this.O_0oOOO_.OO.(),
				this.Oo.Oo00__oooo.()
			})
			{
				c1FlexGrid.Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None;
				c1FlexGrid.Styles.EmptyArea.BackColor = this.O_0oOOO_.OO.().Styles.Normal.BackColor;
				c1FlexGrid.Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None;
			}
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
			{
				this.oOOoo._.()
			});
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
			{
				this.ooO.0o00__0.()
			});
			this.o.0_0_Ooo. = A_0;
			C1TopicPage c1TopicPage = new C1TopicPage();
			c1TopicPage.Text = "正在会话";
			c1TopicPage.ImageList = this.O_0oOOO_.OO.();
			this.Oo.Oo00__oooo.().Pages.Add(c1TopicPage);
			try
			{
				foreach (ooo0 ooo in A_0.oo.___oo__0_O..Values)
				{
					C1TopicLink c1TopicLink = new C1TopicLink();
					c1TopicLink = new C1TopicLink();
					if (ooo.oo.0o_0O0_0. > 0)
					{
						c1TopicLink.Text = ooo.oo.o0.() + "(" + Conversions.ToString(ooo.oo.0o_0O0_0.) + ")";
					}
					else
					{
						c1TopicLink.Text = ooo.oo.o0.();
					}
					c1TopicLink.Tag = ooo;
					c1TopicLink.ImageIndex = 9;
					c1TopicPage.Links.Add(c1TopicLink);
				}
			}
			finally
			{
				Dictionary<string, ooo0>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (O_0OOOoO o_0OOOoO in A_0.oo.___oo__0_O..Values)
				{
					C1TopicLink c1TopicLink2 = new C1TopicLink();
					c1TopicLink2 = new C1TopicLink();
					if (o_0OOOoO.oo.0o_0O0_0. > 0)
					{
						c1TopicLink2.Text = o_0OOOoO.oo_.__OoOO0OO0.() + "(" + Conversions.ToString(o_0OOOoO.oo.0o_0O0_0.) + ")";
					}
					else
					{
						c1TopicLink2.Text = o_0OOOoO.oo_.__OoOO0OO0.();
					}
					c1TopicLink2.Tag = o_0OOOoO;
					c1TopicLink2.ImageIndex = 9;
					c1TopicPage.Links.Add(c1TopicLink2);
				}
			}
			finally
			{
				Dictionary<string, O_0OOOoO>.ValueCollection.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			try
			{
				foreach (IMBuddy imbuddy in A_0.Buddies)
				{
					C1TopicPage c1TopicPage2 = this.Oo.Oo00__oooo.().FindPage(imbuddy.UserGroup);
					if (c1TopicPage2 == null && Operators.CompareString(imbuddy.Name, "[System]", true) != 0)
					{
						c1TopicPage2 = new C1TopicPage();
						c1TopicPage2.Text = imbuddy.UserGroup;
						c1TopicPage2.Collapsed = true;
						c1TopicPage2.ImageList = this.O_0oOOO_.OO.();
						this.Oo.Oo00__oooo.().Pages.Add(c1TopicPage2);
					}
					C1TopicLink c1TopicLink3 = new C1TopicLink();
					c1TopicLink3.Text = imbuddy.SimpleName;
					c1TopicLink3.Tag = imbuddy;
					if (Operators.CompareString(imbuddy.Name, "[System]", true) == 0)
					{
						if (imbuddy.oo.0o_0O0_0. > 0)
						{
							c1TopicLink3.Text = imbuddy.SimpleName + "(" + Conversions.ToString(imbuddy.oo.0o_0O0_0.) + ")";
						}
						else
						{
							c1TopicLink3.Text = imbuddy.SimpleName;
						}
						c1TopicLink3.ImageIndex = 18;
						c1TopicPage.Links.Add(c1TopicLink3);
					}
					else
					{
						if (imbuddy.FromWeChat)
						{
							c1TopicLink3.ImageIndex = 20;
						}
						else if (imbuddy.OnLine)
						{
							c1TopicLink3.ImageIndex = 11;
						}
						else
						{
							c1TopicLink3.ImageIndex = 12;
						}
						c1TopicPage2.Links.Add(c1TopicLink3);
						if (A_0.oOOOo0.oo0OoO0..Select("Name = '" + imbuddy.Name + "'", "").Length > 0)
						{
							c1TopicLink3 = new C1TopicLink();
							if (imbuddy.oo.0o_0O0_0. > 0)
							{
								c1TopicLink3.Text = imbuddy.SimpleName + "(" + Conversions.ToString(imbuddy.oo.0o_0O0_0.) + ")";
							}
							else
							{
								c1TopicLink3.Text = imbuddy.SimpleName;
							}
							c1TopicLink3.Tag = imbuddy;
							if (imbuddy.FromWeChat)
							{
								c1TopicLink3.ImageIndex = 20;
							}
							else if (imbuddy.OnLine)
							{
								c1TopicLink3.ImageIndex = 0;
							}
							else
							{
								c1TopicLink3.ImageIndex = 1;
							}
							c1TopicPage.Links.Add(c1TopicLink3);
						}
					}
				}
			}
			finally
			{
				IEnumerator<IMBuddy> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			try
			{
				foreach (object obj in this.Oo.Oo00__oooo.().Pages)
				{
					C1TopicPage c1TopicPage3 = (C1TopicPage)obj;
					List<C1TopicLink> list = new List<C1TopicLink>();
					try
					{
						foreach (object obj2 in c1TopicPage3.Links)
						{
							C1TopicLink c1TopicLink4 = (C1TopicLink)obj2;
							if (((IMBuddy)c1TopicLink4.Tag).OnLine || c1TopicLink4.Tag is ooo0 || c1TopicLink4.Tag is O_0OOOoO)
							{
								list.Add(c1TopicLink4);
							}
						}
					}
					finally
					{
						IEnumerator enumerator5;
						if (enumerator5 is IDisposable)
						{
							(enumerator5 as IDisposable).Dispose();
						}
					}
					if (list.Count > 0)
					{
						int num = list.Count - 1;
						for (int j = 0; j <= num; j++)
						{
							c1TopicPage3.Links.Remove(list[j]);
							c1TopicPage3.Links.Insert(j, list[j]);
						}
					}
					list.Clear();
				}
			}
			finally
			{
				IEnumerator enumerator4;
				if (enumerator4 is IDisposable)
				{
					(enumerator4 as IDisposable).Dispose();
				}
			}
			if (c1TopicPage.Links.Count == 0)
			{
				c1TopicPage.PageVisible = false;
			}
			this.O0Oo0O_.O_oooO.().Image = OO_00oOO.GetImage("first.ico");
			this.oOo_O_._.().Image = OO_00oOO.GetImage("prev.ico");
			this.ooO.0o00__0.().Image = OO_00oOO.GetImage("next.ico");
			this.Ooo.O_OOOo00.().Image = OO_00oOO.GetImage("last.ico");
			this.Text = this.Text + "(" + A_0.UserName + ")";
			this.O_0oOOO_.OO.().Styles.Add("Sender", this.O_0oOOO_.OO.().Styles.Normal).ForeColor = Color.Green;
			this.O_0oOOO_.OO.().Styles.Add("Receiver", this.O_0oOOO_.OO.().Styles.Normal).ForeColor = Color.Blue;
			CellStyle cellStyle = this.O_0oOOO_.OO.().Styles.Add("Date", this.O_0oOOO_.OO.().Styles.Normal);
			cellStyle.TextAlign = TextAlignEnum.CenterCenter;
			cellStyle.ForeColor = Color.DarkOrange;
			CellStyle cellStyle2 = this.O_0oOOO_.OO.().Styles.Add("SendContent", this.O_0oOOO_.OO.().Styles.Normal);
			cellStyle2.TextAlign = TextAlignEnum.LeftCenter;
			cellStyle2.ImageAlign = ImageAlignEnum.LeftCenter;
			CellStyle cellStyle3 = this.O_0oOOO_.OO.().Styles.Add("ReceiveContent", this.O_0oOOO_.OO.().Styles.Normal);
			cellStyle3.TextAlign = TextAlignEnum.LeftCenter;
			cellStyle3.ImageAlign = ImageAlignEnum.LeftCenter;
			CellStyle cellStyle4 = this.O_0oOOO_.OO.().Styles.Add("MeetingTitle", this.O_0oOOO_.OO.().Styles.Normal);
			cellStyle4.TextAlign = TextAlignEnum.LeftCenter;
			cellStyle4.ForeColor = Color.Salmon;
			CellStyle cellStyle5 = this.O_0oOOO_.OO.().Styles.Add("Loading", this.O_0oOOO_.OO.().Styles.Normal);
			cellStyle5.ForeColor = Color.LightSalmon;
			cellStyle5.Font = new Font("Arial", 12f, FontStyle.Bold);
			this.O_0oOOO_.OO.().Styles.Add("System", this.O_0oOOO_.OO.().Styles.Normal).ForeColor = Color.DarkGray;
			this.Oo.Oo00__oooo.().Styles.Add("Sender", this.O_0oOOO_.OO.().Styles.Normal).ForeColor = Color.Green;
			this.Oo.Oo00__oooo.().Styles.Add("Receiver", this.O_0oOOO_.OO.().Styles.Normal).ForeColor = Color.Blue;
			CellStyle cellStyle6 = this.Oo.Oo00__oooo.().Styles.Add("Date", this.O_0oOOO_.OO.().Styles.Normal);
			cellStyle6.TextAlign = TextAlignEnum.CenterCenter;
			cellStyle6.ForeColor = Color.DarkOrange;
			CellStyle cellStyle7 = this.Oo.Oo00__oooo.().Styles.Add("SendContent", this.O_0oOOO_.OO.().Styles.Normal);
			cellStyle7.TextAlign = TextAlignEnum.LeftCenter;
			cellStyle7.ImageAlign = ImageAlignEnum.LeftCenter;
			CellStyle cellStyle8 = this.Oo.Oo00__oooo.().Styles.Add("ReceiveContent", this.O_0oOOO_.OO.().Styles.Normal);
			cellStyle8.TextAlign = TextAlignEnum.LeftCenter;
			cellStyle8.ImageAlign = ImageAlignEnum.LeftCenter;
			CellStyle cellStyle9 = this.Oo.Oo00__oooo.().Styles.Add("MeetingTitle", this.O_0oOOO_.OO.().Styles.Normal);
			cellStyle9.TextAlign = TextAlignEnum.LeftCenter;
			cellStyle9.ForeColor = Color.Salmon;
			CellStyle cellStyle10 = this.Oo.Oo00__oooo.().Styles.Add("Loading", this.O_0oOOO_.OO.().Styles.Normal);
			cellStyle10.ForeColor = Color.LightSalmon;
			cellStyle10.Font = new Font("Arial", 12f, FontStyle.Bold);
			this.Oo.Oo00__oooo.().Styles.Add("System", this.O_0oOOO_.OO.().Styles.Normal).ForeColor = Color.DarkGray;
			this.O_0oOOO_.OO.().Styles.Normal.WordWrap = true;
			this.Oo.Oo00__oooo.().Styles.Normal.WordWrap = true;
			this.O_0oOOO_.OO.().Cols[0].Width = 8;
			this.Oo.Oo00__oooo.().Cols[0].Width = 8;
			IMFontProperty imfontProperty = new IMFontProperty(this.O_0oOOO_.OO.().Styles["SendContent"], this.O_0oOOO_.OO.().Styles["ReceiveContent"]);
			IMFontProperty imfontProperty2 = new IMFontProperty(this.Oo.Oo00__oooo.().Styles["SendContent"], this.Oo.Oo00__oooo.().Styles["ReceiveContent"]);
			string file = OO_00oOO.ProjectPath + "QQClient\\" + this.o.0_0_Ooo..UserName + ".cfg";
			if (OO_00oOO.FileSys.FileExists(file))
			{
				string a_ = OO_00oOO.FileSys.ReadAllText(file);
				o_O_o_oOoo__.OOOO_OO._oo.(imfontProperty, a_, '\v');
				o_O_o_oOoo__.OOOO_OO._oo.(imfontProperty2, a_, '\v');
				imfontProperty.O00.O0.();
				imfontProperty2.O00.O0.();
			}
			this.O._o_O0O.().Font = this.O_0oOOO_.OO.().Styles["SendContent"].Font;
			this.O._o_O0O.().ForeColor = this.O_0oOOO_.OO.().Styles["SendContent"].ForeColor;
			this.o.0_0_Ooo. = new OleDbDataAdapter("Select * From Messages Where [_Identify] is null", A_0.oOO0O.O0O0.);
			this.o.0_0_Ooo..FillSchema(this.O_0O00.___., SchemaType.Source);
			this.o.0_0_Ooo. = new DataTable(this.O_0O00.___., this.o.0_0_Ooo., A_0.oOO0O.O0O0., "Messages", null);
			foreach (DataRow dataRow in this.o.0_0_Ooo..oo00000_0o0.oO..Select("", "[DateTime] Desc"))
			{
				this.o0__.O_Ooo_.(dataRow["MeetingName"].ToString(), dataRow["MeetingKey"].ToString(), dataRow["Hostess"].ToString(), dataRow["Description"].ToString(), dataRow["Members"].ToString(), Conversions.ToDate(dataRow["DateTime"]), -1);
			}
			this.o.0_o0_00.().Parent.Controls.Remove(this.o.0_o0_00.());
			base.KeyPreview = true;
			this.o_0_o000O_0.O0.();
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0008B04C File Offset: 0x0008924C
		internal void <<EMPTY_NAME>>(C1TopicLink A_0)
		{
			C1TopicBarClickEventArgs a_ = new C1TopicBarClickEventArgs(A_0.TopicPage, A_0);
			this.o0_o0o.0o0O0_o.(this.Oo.Oo00__oooo.(), a_);
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0008B074 File Offset: 0x00089274
		private void <<EMPTY_NAME>>(object A_0, C1TopicBarClickEventArgs A_1)
		{
			if (this.o.0_0_Ooo. != A_1.Link)
			{
				if (this.o.0_0_Ooo. != null)
				{
					if (this.o.0_0_Ooo..Tag is IMBuddy)
					{
						this.o.0_0_Ooo..Text = ((IMBuddy)this.o.0_0_Ooo..Tag).SimpleName;
					}
					else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
					{
						this.o.0_0_Ooo..Text = ((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).oOO_00_0.o.();
					}
				}
				A_1.Link.Text = ((IMBuddy)A_1.Link.Tag).SimpleName + "←";
				bool flag;
				if (this.o.0_0_Ooo. == null)
				{
					flag = true;
				}
				else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
				{
					if ((!(A_1.Link.Tag is ooo0) || Operators.CompareString(((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).OO.O_o__.(), ((ooo0)A_1.Link.Tag).Oo_0__o.o.(), true) != 0) && (!(A_1.Link.Tag is O_0OOOoO) || Operators.CompareString(((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).OO.O_o__.(), ((O_0OOOoO)A_1.Link.Tag).O_O0_o._O0o0O.(), true) != 0))
					{
						flag = true;
					}
				}
				else if (this.o.0_0_Ooo..Tag != A_1.Link.Tag)
				{
					flag = true;
				}
				this.o.0_0_Ooo. = A_1.Link;
				if (flag)
				{
					this.O_0oOOO_.OO.().Rows.Count = 0;
					this.Oo.Oo00__oooo.().Rows.Count = 0;
					this.O_0oOOO_.OO.().O_O0_.__O.(default(DateTime));
					this.Oo.Oo00__oooo.().O_O0_.__O.(default(DateTime));
					if (A_1.Link.Tag is ooo0)
					{
						ooo0 ooo = (ooo0)A_1.Link.Tag;
						this.O_0.00o.(this.O_0oOOO_.OO.(), ooo.oo.o0.(), this.o.0_0_Ooo..UserName, ooo.O0_.OO.(), ooo.o0oO0O._0_.(), ooo.O0_.OO.());
					}
					if (A_1.Link.Tag is O_0OOOoO)
					{
						O_0OOOoO o_0OOOoO = (O_0OOOoO)A_1.Link.Tag;
						this.O_0.00o.(this.O_0oOOO_.OO.(), o_0OOOoO.oo_.__OoOO0OO0.(), o_0OOOoO.o0O0OOo._ooO_O.().Name, o_0OOOoO.o0O0OOo._ooO_O.(), o_0OOOoO.O_Oo0O.0_OooO.(), o_0OOOoO.o0O0OOo._ooO_O.());
					}
					this.o_0_.Ooo__OOoo.();
					if (this.ooO.0o00__0.().SelectedIndex == 0)
					{
						this.o.0_0_Ooo. = true;
					}
					else
					{
						this.o.0_0_Ooo. = false;
						this.oo_0.OOoo__.(-1, false, false);
					}
				}
				this.O._o_O0O.().Value = "";
				if (!this.OO0_O0.o.().Enabled)
				{
					this.oOOoo._.().Enabled = true;
					this.oOO._O.().Enabled = true;
					this.oOo00_.0Oo.().Enabled = true;
					this.Oo_oo._O_.().Enabled = true;
					this.OO0_O0.o.().Enabled = true;
					this.O._o_O0O.().Enabled = true;
					this.o_O.O000o__.().Enabled = true;
				}
			}
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0008B391 File Offset: 0x00089591
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_OO0.oo.().Focus();
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0008B39F File Offset: 0x0008959F
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			this.o.0_0_Ooo..ooOooo.oO. = null;
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x0008B3BD File Offset: 0x000895BD
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.Return && A_1.Control)
			{
				this.OO0_O0.o.().PerformClick();
			}
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x0008B3DC File Offset: 0x000895DC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0_Ooo. != null && Operators.CompareString(this.O._o_O0O.().Text, "", true) != 0)
			{
				if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
				{
					if (((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).O_oO._O.())
					{
						return;
					}
					this.oooo_0ooOo0.0O.();
				}
				else
				{
					this.OooOO_o0O0_._.();
				}
				string text = o0___oO.o0__.0.(this.O._o_O0O.().Text).Replace("\u0002", "");
				if (Operators.CompareString(text, "", true) != 0)
				{
					if (this.o.0_0_Ooo..Tag is ooo0)
					{
						this.o.0_0_Ooo..o00O0._0O.(((ooo0)this.o.0_0_Ooo..Tag).Oo_0__o.o.(), text, true);
					}
					else if (this.o.0_0_Ooo..Tag is O_0OOOoO)
					{
						this.o.0_0_Ooo..o00O0._0O.(((O_0OOOoO)this.o.0_0_Ooo..Tag).O_O0_o._O0o0O.(), text, true);
					}
					else
					{
						if (!(this.o.0_0_Ooo..Tag is IMBuddy))
						{
							return;
						}
						IMBuddy imbuddy = (IMBuddy)this.o.0_0_Ooo..Tag;
						if (Operators.CompareString(imbuddy.Name, "[System]", true) == 0)
						{
							return;
						}
						if (imbuddy.OnLine)
						{
							this.o.0_0_Ooo..O_._00O0_. = this.o.0_0_Ooo..O_._00O0_. + 1;
							this.o.0_0_Ooo..ooOo.oO0..Add(this.o.0_0_Ooo..O_._00O0_., new O0o000(imbuddy, text));
							if (Control.ModifierKeys == Keys.Control)
							{
								this.o.0_0_Ooo..Send(imbuddy.Name, string.Concat(new string[]
								{
									"={",
									text,
									"\u0004",
									this.o.0_0_Ooo..O_._00O0_..ToString(),
									"}="
								}), true, true);
							}
							else
							{
								this.o.0_0_Ooo..Send(imbuddy.Name, string.Concat(new string[]
								{
									"={",
									text,
									"\u0004",
									this.o.0_0_Ooo..O_._00O0_..ToString(),
									"}="
								}), true, false);
							}
						}
						else
						{
							this.o.0_0_Ooo..Send(imbuddy.Name, "={" + text + "}=", true, false);
						}
						if (text.StartsWith("{!}"))
						{
							text = text.Substring(3);
						}
						this.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy.Name, text, 2, 1, null);
					}
					this.O._o_O0O.().Value = "";
				}
			}
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0008B678 File Offset: 0x00089878
		internal void <<EMPTY_NAME>>(string A_0)
		{
			if (this.o.0_0_Ooo. != null)
			{
				if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
				{
					if (((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).O_oO._O.())
					{
						return;
					}
					this.oooo_0ooOo0.0O.();
				}
				else
				{
					this.OooOO_o0O0_._.();
				}
				if (Operators.CompareString(A_0, "", true) != 0)
				{
					string text = "\u0002=[" + A_0 + "]=";
					if (this.o.0_0_Ooo..Tag is ooo0)
					{
						this.o.0_0_Ooo..o00O0._0O.(((ooo0)this.o.0_0_Ooo..Tag).Oo_0__o.o.(), text, true);
						return;
					}
					if (this.o.0_0_Ooo..Tag is O_0OOOoO)
					{
						this.o.0_0_Ooo..o00O0._0O.(((O_0OOOoO)this.o.0_0_Ooo..Tag).O_O0_o._O0o0O.(), text, true);
						return;
					}
					if (this.o.0_0_Ooo..Tag is IMBuddy)
					{
						IMBuddy imbuddy = (IMBuddy)this.o.0_0_Ooo..Tag;
						if (Operators.CompareString(imbuddy.Name, "[System]", true) != 0)
						{
							if (imbuddy.OnLine)
							{
								this.o.0_0_Ooo..O_._00O0_. = this.o.0_0_Ooo..O_._00O0_. + 1;
								this.o.0_0_Ooo..ooOo.oO0..Add(this.o.0_0_Ooo..O_._00O0_., new O0o000(imbuddy, text));
								if (Control.ModifierKeys == Keys.Control)
								{
									this.o.0_0_Ooo..Send(imbuddy.Name, string.Concat(new string[]
									{
										"={",
										text,
										"\u0004",
										this.o.0_0_Ooo..O_._00O0_..ToString(),
										"}="
									}), true, true);
								}
								else
								{
									this.o.0_0_Ooo..Send(imbuddy.Name, string.Concat(new string[]
									{
										"={",
										text,
										"\u0004",
										this.o.0_0_Ooo..O_._00O0_..ToString(),
										"}="
									}), true, false);
								}
							}
							else
							{
								this.o.0_0_Ooo..Send(imbuddy.Name, "={" + text + "}=", true, false);
							}
							this.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy.Name, text, 2, 1, null);
						}
					}
				}
			}
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0008B8C0 File Offset: 0x00089AC0
		private void <<EMPTY_NAME>>()
		{
			string text = ((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).OO.O_o__.();
			bool flag;
			try
			{
				foreach (object obj in this.Oo.Oo00__oooo.().Pages[0].Links)
				{
					C1TopicLink c1TopicLink = (C1TopicLink)obj;
					if ((c1TopicLink.Tag is ooo0 && Operators.CompareString(((ooo0)c1TopicLink.Tag).Oo_0__o.o.(), text, true) == 0) || (c1TopicLink.Tag is O_0OOOoO && Operators.CompareString(((O_0OOOoO)c1TopicLink.Tag).O_O0_o._O0o0O.(), text, true) == 0))
					{
						if (this.o.0_0_Ooo. != null)
						{
							if (this.o.0_0_Ooo..Tag is IMBuddy)
							{
								this.o.0_0_Ooo..Text = ((IMBuddy)this.o.0_0_Ooo..Tag).SimpleName;
							}
							else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
							{
								this.o.0_0_Ooo..Text = ((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).oOO_00_0.o.();
							}
						}
						this.o.0_0_Ooo. = c1TopicLink;
						this.o.0_0_Ooo..Text = ((IMBuddy)this.o.0_0_Ooo..Tag).SimpleName + "←";
						this.oOOoo._.().SelectedIndex = 0;
						flag = true;
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
			if (!flag)
			{
				IMBuddy imbuddy;
				if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(text))
				{
					imbuddy = this.o.0_0_Ooo..oo.___oo__0_O.[text];
				}
				else
				{
					if (!this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(text))
					{
						return;
					}
					imbuddy = this.o.0_0_Ooo..oo.___oo__0_O.[text];
				}
				C1TopicLink c1TopicLink2 = new C1TopicLink();
				c1TopicLink2.ImageIndex = 9;
				c1TopicLink2.Tag = imbuddy;
				c1TopicLink2.Text = imbuddy.SimpleName + "←";
				this.Oo.Oo00__oooo.().Pages[0].Links.Add(c1TopicLink2);
				this.oOOoo._.().SelectedIndex = 0;
				this.o.0_0_Ooo..Text = imbuddy.SimpleName;
				this.o.0_0_Ooo. = c1TopicLink2;
				if (!this.Oo.Oo00__oooo.().Pages[0].PageVisible)
				{
					this.Oo.Oo00__oooo.().Pages[0].PageVisible = true;
				}
			}
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0008BB4C File Offset: 0x00089D4C
		internal void <<EMPTY_NAME>>(Oo0O A_0, DataRow A_1)
		{
			if (A_0.Tag == null)
			{
				A_0.Tag = new Dictionary<int, int>();
			}
			A_0.Rows.Count = A_0.Rows.Count + 1;
			DateTime dateTime = Conversions.ToDate(A_1["Time"]);
			if (DateTime.Compare(dateTime.Date.Date, A_0.O_O0_.__O.().Date) != 0 || A_0.Rows.Count == 1)
			{
				A_0[A_0.Rows.Count - 1, 1] = Strings.Format(dateTime, "yyyy年M月d日");
				A_0.Rows[A_0.Rows.Count - 1].Style = A_0.Styles["Date"];
				A_0.O_O0_.__O.(dateTime);
			}
			else if (A_0.Rows.Count == 1)
			{
				A_0.Rows[A_0.Rows.Count - 1].Height = 8;
			}
			else
			{
				A_0.Rows[A_0.Rows.Count - 1].Height = 3;
			}
			A_0.Rows[A_0.Rows.Count - 1].UserData = "0";
			string text = A_1["Content"].ToString();
			if (text.StartsWith("\u0002(") && text.EndsWith(")\u0002"))
			{
				A_0.AddItem("\t" + Strings.Format(RuntimeHelpers.GetObjectValue(A_1["Time"]), "HH:mm:ss"));
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, this.O_0oOOO_.OO.().Images["info"]);
			}
			else if (text.StartsWith("\u0002{") && text.EndsWith("}\u0002"))
			{
				A_0.AddItem("\t" + Strings.Format(RuntimeHelpers.GetObjectValue(A_1["Time"]), "HH:mm:ss"));
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, this.O_0oOOO_.OO.().Images["Cancel"]);
			}
			else if (text.StartsWith("\u0002[") && text.EndsWith("]\u0002"))
			{
				A_0.AddItem("\t" + Strings.Format(RuntimeHelpers.GetObjectValue(A_1["Time"]), "HH:mm:ss"));
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, this.O_0oOOO_.OO.().Images["ok"]);
			}
			else if (text.StartsWith("\u0002/") && text.EndsWith("\\\u0002"))
			{
				A_0.AddItem("\t" + Strings.Format(RuntimeHelpers.GetObjectValue(A_1["Time"]), "HH:mm:ss"));
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, this.O_0oOOO_.OO.().Images["Cancel"]);
			}
			else if (Operators.CompareString(text, "", true) > 0 && text.StartsWith("\u0002<?") && text.EndsWith("?>"))
			{
				A_0.AddItem("\t" + Strings.Format(RuntimeHelpers.GetObjectValue(A_1["Time"]), "HH:mm:ss"));
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, this.O_0oOOO_.OO.().Images["ok"]);
			}
			else if (text.StartsWith("\u0002|") && text.EndsWith("|\u0002"))
			{
				A_0.AddItem("\t" + Strings.Format(RuntimeHelpers.GetObjectValue(A_1["Time"]), "HH:mm:ss"));
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, this.O_0oOOO_.OO.().Images["ok"]);
			}
			else if (!text.StartsWith("\u0002<") || !text.EndsWith(">\u0002"))
			{
				if (Operators.CompareString(A_1["Type"].ToString(), "1", true) == 0)
				{
					if (A_1.IsNull("MeetingSender"))
					{
						string text2 = A_1["Name"].ToString();
						if (Operators.CompareString(text2, "[System]", true) == 0)
						{
							text2 = "系统";
						}
						if (this.o.0_0_Ooo..Buddies.Contains(text2) && this.o.0_0_Ooo..Buddies[text2].FromWeChat)
						{
							text2 = this.o.0_0_Ooo..Buddies[text2].SimpleName;
						}
						A_0.AddItem("\t" + text2 + " " + Strings.Format(RuntimeHelpers.GetObjectValue(A_1["Time"]), "HH:mm:ss"));
					}
					else
					{
						A_0.AddItem("\t" + A_1["MeetingSender"].ToString() + " " + Strings.Format(RuntimeHelpers.GetObjectValue(A_1["Time"]), "HH:mm:ss"));
					}
				}
				else if (A_1.IsNull("MeetingSender"))
				{
					A_0.AddItem("\t" + this.o.0_0_Ooo..UserName + " " + Strings.Format(RuntimeHelpers.GetObjectValue(A_1["Time"]), "HH:mm:ss"));
				}
				else
				{
					A_0.AddItem("\t" + A_1["MeetingSender"].ToString() + " " + Strings.Format(RuntimeHelpers.GetObjectValue(A_1["Time"]), "HH:mm:ss"));
				}
			}
			A_0.Rows[A_0.Rows.Count - 1].UserData = "1";
			if (!A_0.O__OO.o..ContainsKey(A_0.Rows.Count - 1))
			{
				A_0.O__OO.o..Add(A_0.Rows.Count - 1, A_1);
			}
			A_0.Rows.Count = A_0.Rows.Count + 1;
			bool flag;
			bool flag3;
			if (Operators.CompareString(text, "", true) > 0 && text.StartsWith("\u0002=[") && text.EndsWith("]="))
			{
				text = O_O0OO.o.00O_O.() + "faces\\" + text.Substring(3, text.Length - 5);
				if (OO_00oOO.FileSys.FileExists(text))
				{
					A_0.SetCellImage(A_0.Rows.Count - 1, 1, OO_00oOO.GetImage(text));
				}
				else
				{
					A_0[A_0.Rows.Count - 1, 1] = A_1["Content"].ToString();
				}
			}
			else if (Operators.CompareString(text, "", true) > 0 && text.StartsWith("\u0002=(") && text.EndsWith(")="))
			{
				text = text.Substring(3, text.Length - 5);
				if (Operators.CompareString(text, "fail.png", true) != 0)
				{
					if (Operators.CompareString(A_1["Type"].ToString(), "1", true) == 0)
					{
						text = OO_00oOO.ProjectPath + "QQClient\\ReceivedFiles\\" + text;
					}
					else
					{
						text = OO_00oOO.ProjectPath + "QQClient\\CaptureFiles\\" + text;
					}
					if (!OO_00oOO.FileSys.FileExists(text))
					{
						text = "fail.png";
					}
				}
				while (A_0.O000.o..ContainsKey(A_0.Rows.Count - 1))
				{
					A_0.Rows.Count = A_0.Rows.Count + 1;
					A_0.Rows[A_0.Rows.Count - 1].Visible = false;
				}
				A_0.SetCellImage(A_0.Rows.Count - 1, 1, OO_00oOO.GetImage(text));
				A_0.O000.o..Add(A_0.Rows.Count - 1, text);
			}
			else
			{
				if (Operators.CompareString(text, "", true) > 0 && text.StartsWith("\u0002=?") && text.EndsWith("?="))
				{
					flag = true;
					string text3 = text.Substring(3, text.Length - 5);
					A_0[A_0.Rows.Count - 1, 1] = "正在加载.";
					A_0.Rows[A_0.Rows.Count - 1].Style = A_0.Styles["Loading"];
					((Dictionary<int, int>)A_0.Tag).Add(Conversions.ToInteger(A_1["_Identify"]), A_0.Rows.Count - 1);
					if (Operators.CompareString(A_1.RowError, "1", true) == 0)
					{
						goto IL_1337;
					}
					A_1.RowError = "1";
					object[] array = new object[4];
					array[0] = text3;
					if (this.o.0_0_Ooo..Tag is IMBuddy)
					{
						array[1] = (IMBuddy)this.o.0_0_Ooo..Tag;
					}
					else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
					{
						string key = ((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).OO.O_o__.();
						if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(key))
						{
							array[1] = this.o.0_0_Ooo..oo.___oo__0_O.[key];
						}
						else if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(key))
						{
							array[1] = this.o.0_0_Ooo..oo.___oo__0_O.[key];
						}
						else
						{
							array[1] = null;
						}
					}
					else
					{
						array[1] = null;
					}
					array[2] = A_1;
					array[3] = SendTypeEnum.Capture;
					int item = Conversions.ToInteger(A_1["_Identify"]);
					object ooOooo.oO. = this.o.0_0_Ooo..ooOooo.oO.;
					lock (ooOooo.oO.)
					{
						if (!this.o.0_0_Ooo..ooOooo.oO..Contains(item))
						{
							this.o.0_0_Ooo..O00.O0..Add(array);
							this.o.0_0_Ooo..ooOooo.oO..Add(item);
						}
						goto IL_1337;
					}
				}
				if (text.StartsWith("\u0002(") && text.EndsWith(")\u0002"))
				{
					A_0[A_0.Rows.Count - 1, 1] = text.Substring(2, text.Length - 4);
					flag3 = true;
				}
				else if (text.StartsWith("\u0002{") && text.EndsWith("}\u0002"))
				{
					A_0[A_0.Rows.Count - 1, 1] = text.Substring(2, text.Length - 4);
					flag3 = true;
				}
				else if (text.StartsWith("\u0002[") && text.EndsWith("]\u0002"))
				{
					A_0[A_0.Rows.Count - 1, 1] = text.Substring(2, text.Length - 4);
					flag3 = true;
				}
				else if (text.StartsWith("\u0002<") && text.EndsWith(">\u0002"))
				{
					text = text.Substring(2, text.Length - 4);
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (array2.Length == 2)
					{
						A_0.SetCellImage(A_0.Rows.Count - 1, 1, ooO.o.O_0000_O.(Path.GetExtension(array2[0])));
						text = OO_00oOO.FileSys.GetName(array2[0]) + "\r\n" + array2[1];
						A_0[A_0.Rows.Count - 1, 1] = text;
					}
					A_0.O000.o..Add(A_0.Rows.Count - 1, A_1);
					flag3 = true;
				}
				else if (text.StartsWith("\u0002/") && text.EndsWith("\\\u0002"))
				{
					A_0.Rows[A_0.Rows.Count - 2].Style = A_0.Styles["System"];
					int row = A_0.Rows.Count - 1;
					A_0.Rows[A_0.Rows.Count - 1].UserData = "2";
					A_0.Rows[A_0.Rows.Count - 1].Style = A_0.Styles["System"];
					A_0.Rows.Count = A_0.Rows.Count + 1;
					A_0.Rows[A_0.Rows.Count - 1].UserData = "1";
					A_0.Rows[A_0.Rows.Count - 1].Height = 3;
					A_0.Rows.Count = A_0.Rows.Count + 1;
					text = text.Substring(2, text.Length - 4);
					if (text.StartsWith("\u0002=[") && text.EndsWith("]="))
					{
						A_0[row, 1] = "以下表情可能发送失败";
						text = O_O0OO.o.00O_O.() + "faces\\" + text.Substring(3, text.Length - 5);
						if (OO_00oOO.FileSys.FileExists(text))
						{
							A_0.SetCellImage(A_0.Rows.Count - 1, 1, OO_00oOO.GetImage(text));
						}
					}
					else if (text.StartsWith("\u0002=(") && text.EndsWith(")="))
					{
						A_0[row, 1] = "以下图片可能发送失败";
						text = text.Substring(3, text.Length - 5);
						text = OO_00oOO.ProjectPath + "QQClient\\CaptureFiles\\" + text;
						if (OO_00oOO.FileSys.FileExists(text))
						{
							A_0.SetCellImage(A_0.Rows.Count - 1, 1, OO_00oOO.GetImage(text));
							A_0.O000.o..Add(A_0.Rows.Count - 1, text);
						}
					}
					else
					{
						A_0[row, 1] = "以下信息可能发送失败";
						A_0[A_0.Rows.Count - 1, 1] = text;
					}
					A_0.oO0Oo00o.00..Add(A_0.Rows.Count - 1, A_1);
				}
				else if (text.StartsWith("\u0002|") && text.EndsWith("|\u0002"))
				{
					A_0.Rows[A_0.Rows.Count - 2].Style = A_0.Styles["System"];
					if (A_1.IsNull("MeetingSender"))
					{
						A_0[A_0.Rows.Count - 1, 1] = "对方发来离线文件";
					}
					else
					{
						A_0[A_0.Rows.Count - 1, 1] = A_1["MeetingSender"].ToString() + "分享了文件";
					}
					A_0.Rows[A_0.Rows.Count - 1].UserData = "2";
					A_0.Rows[A_0.Rows.Count - 1].Style = A_0.Styles["System"];
					A_0.Rows.Count = A_0.Rows.Count + 1;
					A_0.Rows[A_0.Rows.Count - 1].UserData = "1";
					A_0.Rows[A_0.Rows.Count - 1].Height = 1;
					A_0.Rows.Count = A_0.Rows.Count + 1;
					text = text.Substring(2, text.Length - 4);
					string[] array3 = text.Split(new char[]
					{
						'\t'
					});
					if (array3.Length >= 2)
					{
						A_0.SetCellImage(A_0.Rows.Count - 1, 1, ooO.o.O_0000_O.(Path.GetExtension(array3[0])));
						text = OO_00oOO.FileSys.GetName(array3[0]) + "\r\n" + array3[1];
						if (array3.Length == 3)
						{
							text = text + "\r\n" + Strings.Format(Conversions.ToDate(array3[2]), "yyyy年MM月dd日 HH:mm:ss") + "下载成功!";
						}
						A_0[A_0.Rows.Count - 1, 1] = text;
					}
					A_0.O000.o..Add(A_0.Rows.Count - 1, A_1);
					flag3 = true;
				}
				else if (Operators.CompareString(text, "", true) > 0 && text.StartsWith("\u0002<?") && text.EndsWith("?>"))
				{
					A_0.Rows[A_0.Rows.Count - 2].Style = A_0.Styles["System"];
					if (A_1.IsNull("MeetingSender"))
					{
						A_0[A_0.Rows.Count - 1, 1] = "对方发来离线文件";
					}
					else
					{
						A_0[A_0.Rows.Count - 1, 1] = A_1["MeetingSender"].ToString() + "分享了文件";
					}
					A_0.Rows[A_0.Rows.Count - 1].UserData = "2";
					A_0.Rows[A_0.Rows.Count - 1].Style = A_0.Styles["System"];
					A_0.Rows.Count = A_0.Rows.Count + 1;
					A_0.Rows[A_0.Rows.Count - 1].UserData = "1";
					A_0.Rows[A_0.Rows.Count - 1].Height = 1;
					A_0.Rows.Count = A_0.Rows.Count + 1;
					text = text.Substring(3, text.Length - 5);
					string[] array4 = text.Split(new char[]
					{
						'\t'
					});
					bool flag4;
					if (array4.Length >= 2)
					{
						A_0.SetCellImage(A_0.Rows.Count - 1, 1, ooO.o.O_0000_O.(Path.GetExtension(array4[0])));
						text = OO_00oOO.FileSys.GetName(array4[0]) + "\r\n" + array4[1];
						if (array4.Length == 3)
						{
							if (Operators.CompareString(array4[2], "Deleted", true) == 0)
							{
								text += "\r\n服务器已删除此离线文件,无法下载!";
								flag4 = true;
							}
							else
							{
								text = text + "\r\n" + Strings.Format(Conversions.ToDate(array4[2]), "yyyy年MM月dd日 HH:mm:ss") + "下载失败!";
							}
						}
						A_0[A_0.Rows.Count - 1, 1] = text;
					}
					if (!flag4)
					{
						A_0.oOO00oo.O..Add(A_0.Rows.Count - 1, A_1);
					}
					flag3 = true;
				}
				else
				{
					A_0[A_0.Rows.Count - 1, 1] = text;
					if (text.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) || text.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase) || (text.StartsWith("www", StringComparison.CurrentCultureIgnoreCase) && text.Length - text.Replace(".", "").Length >= 2))
					{
						A_0.oOO00oo.O..Add(A_0.Rows.Count - 1, A_1);
					}
				}
			}
			IL_1337:
			A_0.Rows[A_0.Rows.Count - 1].UserData = "2";
			if (!A_0.O__OO.o..ContainsKey(A_0.Rows.Count - 1))
			{
				A_0.O__OO.o..Add(A_0.Rows.Count - 1, A_1);
			}
			if (flag3)
			{
				A_0.Rows[A_0.Rows.Count - 2].Style = A_0.Styles["System"];
				A_0.Rows[A_0.Rows.Count - 1].Style = A_0.Styles["System"];
			}
			else if (!flag)
			{
				if (Operators.CompareString(A_1["Type"].ToString(), "1", true) == 0)
				{
					A_0.Rows[A_0.Rows.Count - 2].Style = A_0.Styles["Receiver"];
					A_0.Rows[A_0.Rows.Count - 1].Style = A_0.Styles["ReceiveContent"];
				}
				else
				{
					A_0.Rows[A_0.Rows.Count - 2].Style = A_0.Styles["Sender"];
					A_0.Rows[A_0.Rows.Count - 1].Style = A_0.Styles["SendContent"];
				}
			}
			A_0.AutoSizeRow(A_0.Rows.Count - 2);
			A_0.AutoSizeRow(A_0.Rows.Count - 1);
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0008D058 File Offset: 0x0008B258
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0_Ooo..o_oo0.O0Oo__oO. < 3)
			{
				object obj = null;
				object ooOooo.oO. = this.o.0_0_Ooo..ooOooo.oO.;
				lock (ooOooo.oO.)
				{
					if (this.o.0_0_Ooo..O00.O0..Count > 0)
					{
						obj = RuntimeHelpers.GetObjectValue(this.o.0_0_Ooo..O00.O0.[0]);
						this.o.0_0_Ooo..O00.O0..RemoveAt(0);
					}
				}
				if (obj != null)
				{
					object oo.___oo__0_O. = this.o.0_0_Ooo..oo.___oo__0_O.;
					ObjectFlowControl.CheckForSyncLockOnValueType(oo.___oo__0_O.);
					lock (oo.___oo__0_O.)
					{
						this.o.0_0_Ooo..o_oo0.O0Oo__oO. = this.o.0_0_Ooo..o_oo0.O0Oo__oO. + 1;
					}
					new Thread(new ParameterizedThreadStart(this.o0__.O_Ooo_.)).Start(RuntimeHelpers.GetObjectValue(obj));
				}
			}
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0008D154 File Offset: 0x0008B354
		internal void <<EMPTY_NAME>>(object A_0)
		{
			object[] array = (object[])A_0;
			string text = array[0].ToString();
			IMBuddy imbuddy = null;
			if (array[1] != null)
			{
				imbuddy = (IMBuddy)array[1];
			}
			DataRow dataRow = (DataRow)array[2];
			SendTypeEnum sendTypeEnum = (SendTypeEnum)Conversions.ToInteger(array[3]);
			if (this.o.0_0_Ooo..O0_OOo.O. || dataRow.RowState == DataRowState.Detached)
			{
				if (sendTypeEnum != SendTypeEnum.Capture)
				{
					return;
				}
				object oo.___oo__0_O. = this.o.0_0_Ooo..oo.___oo__0_O.;
				ObjectFlowControl.CheckForSyncLockOnValueType(oo.___oo__0_O.);
				lock (oo.___oo__0_O.)
				{
					this.o.0_0_Ooo..o_oo0.O0Oo__oO. = this.o.0_0_Ooo..o_oo0.O0Oo__oO. - 1;
					return;
				}
			}
			string text2 = "\v";
			UdpClient udpClient = new UdpClient(0);
			o0___oO.O.oOo0O0O.(udpClient);
			udpClient.Client.ReceiveBufferSize = 81920;
			string s = string.Concat(new string[]
			{
				"%4",
				text2,
				this.o.0_0_Ooo..UserName,
				text2,
				this.o.0_0_Ooo..o_oo0Oooo.OOO_.,
				text2,
				text
			});
			byte[] bytes = Encoding.Unicode.GetBytes(s);
			udpClient.Send(bytes, bytes.Length, this.o.0_0_Ooo..ooOo.oO0.);
			DateTime now = DateTime.Now;
			try
			{
				while (DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0)
				{
					if (udpClient.Available > 0)
					{
						IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
						byte[] bytes2 = udpClient.Receive(ref ipendPoint);
						int num;
						if (int.TryParse(Encoding.Unicode.GetString(bytes2), out num))
						{
							if (num == -1)
							{
								if (sendTypeEnum == SendTypeEnum.Capture)
								{
									dataRow["Content"] = "\u0002=(fail.png)=";
									this.o.0_0_Ooo..oOOOo0.oo0OoO0..Update(new DataRow[]
									{
										dataRow
									});
									base.Invoke(new f4.OO00OoOo_(this.o0.00.), new object[]
									{
										dataRow
									});
								}
								else
								{
									string text3 = dataRow["Content"].ToString();
									text3 = text3.Substring(3, text3.Length - 5);
									string[] array2 = text3.Split(new char[]
									{
										'\t'
									});
									text3 = string.Concat(new string[]
									{
										"\u0002<?",
										array2[0],
										"\t",
										array2[1],
										"\tDeleted?>"
									});
									dataRow["Content"] = text3;
									this.o.0_0_Ooo..oOOOo0.oo0OoO0..Update(new DataRow[]
									{
										dataRow
									});
									base.Invoke(new f4.OO00OoOo_(this.ooOo00_o0o.Ooo.), new object[]
									{
										dataRow
									});
								}
								udpClient.Close();
								break;
							}
							IPEndPoint ipendPoint2 = new IPEndPoint(this.o.0_0_Ooo..ooOo.oO0..Address, num);
							bytes = Encoding.Unicode.GetBytes("Ping");
							udpClient.Send(bytes, bytes.Length, ipendPoint2);
							ooOoO ooOoO = new ooOoO(this.o.0_0_Ooo., udpClient, ipendPoint2, OO_00oOO.FileSys.GetName(text), null, dataRow["_Identify"].ToString(), sendTypeEnum);
							ooOoO.o0_.OO0O_o.(dataRow);
							if (sendTypeEnum != SendTypeEnum.Capture && OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
							{
								OO_00oOO.BaseMainForm.Invoke(new f4.Oo000(this.ooOo00_o0o.Ooo.), new object[]
								{
									imbuddy,
									text,
									ooOoO
								});
							}
							object ooOooo.oO. = this.o.0_0_Ooo..ooOooo.oO.;
							lock (ooOooo.oO.)
							{
								this.o.0_0_Ooo..ooOooo.oO..Add(ooOoO.o0OO._0.(), ooOoO);
							}
							bool flag3 = true;
							ooOoO.O_OOOooo_0.O.();
							break;
						}
					}
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				bool flag3;
				if (!flag3 && sendTypeEnum == SendTypeEnum.Capture)
				{
					object oo.___oo__0_O.2 = this.o.0_0_Ooo..oo.___oo__0_O.;
					ObjectFlowControl.CheckForSyncLockOnValueType(oo.___oo__0_O.2);
					lock (oo.___oo__0_O.2)
					{
						this.o.0_0_Ooo..o_oo0.O0Oo__oO. = this.o.0_0_Ooo..o_oo0.O0Oo__oO. - 1;
					}
				}
				if (dataRow != null)
				{
					int item = Conversions.ToInteger(dataRow["_Identify"]);
					object oOO0_O.O__0_0. = this.o.0_0_Ooo..oOO0_O.O__0_0.;
					lock (oOO0_O.O__0_0.)
					{
						if (this.o.0_0_Ooo..oOO0_O.O__0_0..Contains(item))
						{
							this.o.0_0_Ooo..oOO0_O.O__0_0..Remove(item);
						}
					}
				}
			}
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0008D674 File Offset: 0x0008B874
		private void <<EMPTY_NAME>>(IMBuddy A_0, string A_1, ooOoO A_2)
		{
			Oo0O__ oo0O__ = new Oo0O__(this.o.0_0_Ooo., A_0, A_1, A_2.o0OO._0.());
			oo0O__.o_0.Oo_0O0_. = true;
			oo0O__.o.o_oo.().Text = OO_00oOO.FileSys.GetName(A_1);
			oo0O__.OOOO_.0O0o0.().Visible = false;
			if (this.o.0_0_Ooo..ooOooo.oO. == null)
			{
				this.o.0_0_Ooo..ooOooo.oO. = new o\u3000\u3002\u3000\u3002\u3000(this.o.0_0_Ooo.);
				this.o.0_0_Ooo..ooOooo.oO..Owner = OO_00oOO.BaseMainForm;
			}
			this.o.0_0_Ooo..ooOooo.oO..O_0O_o.0.(oo0O__);
			this.o.0_0_Ooo..ooOooo.oO..Show();
			A_2.O0__00OoOo_O.o. = oo0O__;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0008D720 File Offset: 0x0008B920
		private void <<EMPTY_NAME>>(DataRow A_0)
		{
			foreach (C1FlexGrid c1FlexGrid in new C1FlexGrid[]
			{
				this.o.0_0_Ooo..ooOooo.oO..O_0oOOO_.OO.(),
				this.o.0_0_Ooo..ooOooo.oO..Oo.Oo00__oooo.()
			})
			{
				if (c1FlexGrid.Tag != null)
				{
					Dictionary<int, int> dictionary = (Dictionary<int, int>)c1FlexGrid.Tag;
					int key = Conversions.ToInteger(A_0["_Identify"]);
					if (dictionary.ContainsKey(key))
					{
						int row = dictionary[key];
						dictionary.Remove(key);
						c1FlexGrid[row, 1] = null;
						c1FlexGrid.SetCellImage(row, 1, OO_00oOO.GetImage("fail.png"));
						c1FlexGrid.AutoSizeRow(row);
					}
				}
			}
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0008D7D4 File Offset: 0x0008B9D4
		private void <<EMPTY_NAME>>(DataRow A_0)
		{
			foreach (Oo0O oo0O in new Oo0O[]
			{
				this.o.0_0_Ooo..ooOooo.oO..O_0oOOO_.OO.(),
				this.o.0_0_Ooo..ooOooo.oO..Oo.Oo00__oooo.()
			})
			{
				try
				{
					foreach (int num in oo0O.oOO00oo.O..Keys)
					{
						if (oo0O.oOO00oo.O.[num] == A_0)
						{
							string text = A_0["Content"].ToString();
							text = text.Substring(3, text.Length - 5);
							string[] array2 = text.Split(new char[]
							{
								'\t'
							});
							text = array2[0] + "\r\n" + array2[1] + "\r\n服务器已删除此离线文件，无法下载！";
							oo0O[num, 1] = text;
							oo0O.AutoSizeRow(num);
							if (this.o_oO__.0.().Visible && this.o_oO__.0.().Parent == oo0O && Conversions.ToInteger(this.o_oO__.0.().Tag) == num)
							{
								this.o_oO__.0.().Visible = false;
							}
						}
					}
				}
				finally
				{
					Dictionary<int, DataRow>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0008D924 File Offset: 0x0008BB24
		internal void <<EMPTY_NAME>>()
		{
			if (this.o.0_0_Ooo..TopicBar == this.Oo.Oo00__oooo.() && this.o.0_0_Ooo..TopicPage.Index != 0)
			{
				IMBuddy imbuddy = (IMBuddy)this.o.0_0_Ooo..Tag;
				C1TopicLink c1TopicLink = this.Oo.Oo00__oooo.().Pages[0].FindLinkByTag(RuntimeHelpers.GetObjectValue(this.o.0_0_Ooo..Tag));
				if (c1TopicLink == null)
				{
					c1TopicLink = new C1TopicLink();
					c1TopicLink.Tag = RuntimeHelpers.GetObjectValue(this.o.0_0_Ooo..Tag);
					c1TopicLink.Text = imbuddy.SimpleName + "←";
					if (imbuddy.FromWeChat)
					{
						c1TopicLink.ImageIndex = 20;
					}
					else if (imbuddy.OnLine)
					{
						c1TopicLink.ImageIndex = 0;
					}
					else
					{
						c1TopicLink.ImageIndex = 1;
					}
					this.Oo.Oo00__oooo.().Pages[0].Links.Add(c1TopicLink);
					if (!this.Oo.Oo00__oooo.().Pages[0].PageVisible)
					{
						this.Oo.Oo00__oooo.().Pages[0].PageVisible = true;
					}
				}
				else
				{
					c1TopicLink.Text = ((IMBuddy)c1TopicLink.Tag).SimpleName + "←";
				}
				this.o.0_0_Ooo..Text = imbuddy.SimpleName;
				this.o.0_0_Ooo. = c1TopicLink;
			}
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0008DA7C File Offset: 0x0008BC7C
		private void <<EMPTY_NAME>>(object A_0, RangeEventArgs A_1)
		{
			try
			{
				if (this.o.0_o0_00.().Visible && this.o.0_o0_00.().Parent == A_0)
				{
					Oo0O oo0O = (Oo0O)A_0;
					int index = Conversions.ToInteger(this.o.0_o0_00.().Tag);
					int x = oo0O.Width - this.o.0_o0_00.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible == ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0));
					int y = oo0O.Rows[index].Bottom - this.o.0_o0_00.().Height + oo0O.ScrollPosition.Y;
					this.o.0_o0_00.().Location = new Point(x, y);
				}
				if (this.o.o00_0O0o.().Visible && this.o.o00_0O0o.().Parent == A_0)
				{
					Oo0O oo0O2 = (Oo0O)A_0;
					int index2 = Conversions.ToInteger(this.o.o00_0O0o.().Tag);
					int x2 = oo0O2.Width - this.o.o00_0O0o.().Width - Conversions.ToInteger(Interaction.IIf(oo0O2.ScrollBarsVisible == ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0));
					int y2 = oo0O2.Rows[index2].Top - this.o.o00_0O0o.().Height + oo0O2.ScrollPosition.Y - 5;
					this.o.o00_0O0o.().Location = new Point(x2, y2);
				}
				if (this.o_oO__.0.().Visible && this.o_oO__.0.().Parent == A_0)
				{
					Oo0O oo0O3 = (Oo0O)A_0;
					int index3 = Conversions.ToInteger(this.o_oO__.0.().Tag);
					int x3 = oo0O3.Width - this.o_oO__.0.().Width - Conversions.ToInteger(Interaction.IIf(oo0O3.ScrollBarsVisible == ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0));
					int y3 = oo0O3.Rows[index3].Bottom - this.o_oO__.0.().Height + oo0O3.ScrollPosition.Y;
					this.o_oO__.0.().Location = new Point(x3, y3);
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0008DCEC File Offset: 0x0008BEEC
		private void <<EMPTY_NAME>>(object A_0, RangeEventArgs A_1)
		{
			try
			{
				this.o.0_o0_00.().Visible = false;
				this.o_oO__.0.().Visible = false;
				this.o.o00_0O0o.().Visible = false;
				Oo0O oo0O = (Oo0O)A_0;
				int num = oo0O.Selection.TopRow;
				int num2 = oo0O.Selection.BottomRow;
				if (num >= 0 && num2 >= 0 && oo0O.Rows[num].UserData != null && oo0O.Rows[num2].UserData != null)
				{
					if (Operators.CompareString(oo0O.Rows[num].UserData.ToString(), "2", true) == 0)
					{
						num--;
					}
					if (Operators.CompareString(oo0O.Rows[num2].UserData.ToString(), "1", true) == 0)
					{
						num2++;
					}
					if (num != oo0O.Selection.TopRow || num2 != oo0O.Selection.BottomRow)
					{
						oo0O.Select(num, 1, num2, 1);
						return;
					}
				}
				if (oo0O.O000.o..ContainsKey(num2))
				{
					oo0O.BeginUpdate();
					int x = oo0O.Width - this.o.0_o0_00.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible == ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0));
					int y = oo0O.Rows[num2].Bottom - this.o.0_o0_00.().Height + oo0O.ScrollPosition.Y;
					this.o.0_o0_00.().Location = new Point(x, y);
					this.o.0_o0_00.().Tag = num2;
					this.o.0_o0_00.().Anchor = AnchorStyles.Right;
					oo0O.Controls.Add(this.o.0_o0_00.());
					this.o.0_o0_00.().Visible = true;
					oo0O.EndUpdate();
				}
				if (oo0O.oO0Oo00o.00..ContainsKey(num2))
				{
					oo0O.BeginUpdate();
					int x2 = oo0O.Width - this.o.o00_0O0o.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible == ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0));
					int y2 = oo0O.Rows[num2].Top - this.o.o00_0O0o.().Height + oo0O.ScrollPosition.Y - 5;
					this.o.o00_0O0o.().Location = new Point(x2, y2);
					this.o.o00_0O0o.().Tag = num2;
					this.o.o00_0O0o.().Anchor = AnchorStyles.Right;
					oo0O.Controls.Add(this.o.o00_0O0o.());
					this.o.o00_0O0o.().Visible = true;
					oo0O.EndUpdate();
				}
				if (oo0O.oOO00oo.O..ContainsKey(num2))
				{
					oo0O.BeginUpdate();
					int x3 = oo0O.Width - this.o_oO__.0.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible == ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0));
					int y3 = oo0O.Rows[num2].Bottom - this.o_oO__.0.().Height + oo0O.ScrollPosition.Y;
					this.o_oO__.0.().Location = new Point(x3, y3);
					this.o_oO__.0.().Tag = num2;
					this.o_oO__.0.().Anchor = AnchorStyles.Right;
					string text = oo0O.oOO00oo.O.[num2]["Content"].ToString();
					bool flag;
					if (text.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) || text.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase) || text.EndsWith(".com", StringComparison.CurrentCultureIgnoreCase) || text.EndsWith(".cn", StringComparison.CurrentCultureIgnoreCase) || text.EndsWith(".net", StringComparison.CurrentCultureIgnoreCase))
					{
						flag = true;
					}
					if (this.o.0_0_Ooo..oOO0_O.O__0_0..Contains(Conversions.ToInteger(oo0O.oOO00oo.O.[num2]["_Identify"])))
					{
						this.O_o._o0___.().Text = "下载中...";
						this.O_o._o0___.().Cursor = Cursors.Default;
					}
					else if (flag)
					{
						this.O_o._o0___.().Text = "打开";
						this.O_o._o0___.().Cursor = Cursors.Hand;
					}
					else
					{
						this.O_o._o0___.().Text = "下载";
						this.O_o._o0___.().Cursor = Cursors.Hand;
					}
					oo0O.Controls.Add(this.o_oO__.0.());
					this.o_oO__.0.().Visible = true;
					oo0O.EndUpdate();
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0008E1AC File Offset: 0x0008C3AC
		private void <<EMPTY_NAME>>(object A_0, BeforeMouseDownEventArgs A_1)
		{
			try
			{
				C1FlexGrid c1FlexGrid = (C1FlexGrid)A_0;
				int mouseRow = c1FlexGrid.MouseRow;
				if (mouseRow >= 0 && (c1FlexGrid.Rows[mouseRow].UserData == null || Operators.CompareString(c1FlexGrid.Rows[mouseRow].UserData.ToString(), "0", true) == 0))
				{
					A_1.Cancel = true;
					c1FlexGrid.Focus();
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0008E23C File Offset: 0x0008C43C
		private void <<EMPTY_NAME>>()
		{
			if (this.o.0_o0_00.().Parent == this.O_0oOOO_.OO.())
			{
				this.o.0_o0_00.().Visible = false;
				this.o.0_o0_00.().Parent.Controls.Remove(this.o.0_o0_00.());
			}
			if (this.o_oO__.0.().Parent == this.O_0oOOO_.OO.())
			{
				this.o_oO__.0.().Visible = false;
				this.o_oO__.0.().Parent.Controls.Remove(this.o_oO__.0.());
			}
			string text;
			if (this.o.0_0_Ooo..Tag is ooo0)
			{
				text = ((ooo0)this.o.0_0_Ooo..Tag).Oo_0__o.o.();
			}
			else if (this.o.0_0_Ooo..Tag is O_0OOOoO)
			{
				text = ((O_0OOOoO)this.o.0_0_Ooo..Tag).O_O0_o._O0o0O.();
			}
			else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
			{
				text = ((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).OO.O_o__.();
			}
			else
			{
				text = ((IMBuddy)this.o.0_0_Ooo..Tag).Name;
			}
			DataTable oOOOo0.oo0OoO0. = this.o.0_0_Ooo..oOOOo0.oo0OoO0.;
			Oo0O oo0O = this.O_0oOOO_.OO.();
			if (oo0O.Tag == null)
			{
				oo0O.Tag = new Dictionary<int, int>();
			}
			((Dictionary<int, int>)oo0O.Tag).Clear();
			oo0O.O000.o..Clear();
			oo0O.oOO00oo.O..Clear();
			oo0O.O000.o..Clear();
			oo0O.oO0Oo00o.00..Clear();
			oo0O.O__OO.o..Clear();
			DataRow[] array = this.o.0_0_Ooo..oOOOo0.oo0OoO0..Select("[Name] = '" + text + "'", "Time");
			if (array.Length != 0)
			{
				oo0O.BeginUpdate();
				foreach (DataRow dataRow in array)
				{
					this.O_0.00o.(oo0O, dataRow);
					if (Operators.CompareString(dataRow["Read"].ToString(), "0", true) == 0)
					{
						dataRow["Read"] = 1;
					}
				}
				oo0O.EndUpdate();
				this.o.0_0_Ooo..oOOOo0.oo0OoO0..Update(array);
				oo0O.ShowCell(oo0O.Rows.Count - 1, 0);
				oo0O.Row = -1;
				if (this.o.0_0_Ooo..Tag is IMBuddy)
				{
					((IMBuddy)this.o.0_0_Ooo..Tag).oo.0o_0O0_0. = 0;
					return;
				}
				if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(text))
				{
					this.o.0_0_Ooo..oo.___oo__0_O.[text].oo.0o_0O0_0. = 0;
				}
				if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(text))
				{
					this.o.0_0_Ooo..oo.___oo__0_O.[text].oo.0o_0O0_0. = 0;
				}
			}
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0008E4F8 File Offset: 0x0008C6F8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0_Ooo. == null)
			{
				this.o.0_0_Ooo. = new O\u3000\u3002\u3002\u3002_\u3002\u3000\u3000(this);
				this.o.0_0_Ooo..Owner = OO_00oOO.BaseMainForm;
			}
			int y = this.oOO._O.().Top - this.o.0_0_Ooo..Height;
			int left = this.oOO._O.().Left;
			Point point = new Point(left, y);
			point = this.o.o00_0O0o.().Panel2.PointToScreen(point);
			this.o.0_0_Ooo..Location = point;
			this.o.0_0_Ooo..Show();
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0008E57F File Offset: 0x0008C77F
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.ooO_0_.().Show(this.O_OO0.oo.(), new Point(0, this.O_OO0.oo.().Height));
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0008E5A3 File Offset: 0x0008C7A3
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.ooOoo___0.oO0.().Show(this.Oo_._O0.(), new Point(0, this.Oo_._O0.().Height));
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0008E5C8 File Offset: 0x0008C7C8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			FontDialog fontDialog = new FontDialog();
			fontDialog.Font = this.O_0oOOO_.OO.().Styles["SendContent"].Font;
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				this.O_0oOOO_.OO.().Styles["SendContent"].Font = fontDialog.Font;
				this.Oo.Oo00__oooo.().Styles["SendContent"].Font = fontDialog.Font;
				this.O_0oOOO_.OO.().AutoSizeRows();
				this.Oo.Oo00__oooo.().AutoSizeRows();
				this.O._o_O0O.().Font = this.O_0oOOO_.OO.().Styles["SendContent"].Font;
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0008E680 File Offset: 0x0008C880
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			FontDialog fontDialog = new FontDialog();
			fontDialog.Font = this.O_0oOOO_.OO.().Styles["ReceiveContent"].Font;
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				this.O_0oOOO_.OO.().Styles["ReceiveContent"].Font = fontDialog.Font;
				this.Oo.Oo00__oooo.().Styles["ReceiveContent"].Font = fontDialog.Font;
				this.O_0oOOO_.OO.().AutoSizeRows();
				this.Oo.Oo00__oooo.().AutoSizeRows();
			}
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0008E714 File Offset: 0x0008C914
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = this.O_0oOOO_.OO.().Styles["SendContent"].ForeColor;
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				this.O_0oOOO_.OO.().Styles["SendContent"].ForeColor = colorDialog.Color;
				this.Oo.Oo00__oooo.().Styles["SendContent"].ForeColor = colorDialog.Color;
				this.O._o_O0O.().ForeColor = this.O_0oOOO_.OO.().Styles["SendContent"].ForeColor;
			}
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0008E7B8 File Offset: 0x0008C9B8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = this.O_0oOOO_.OO.().Styles["ReceiveContent"].ForeColor;
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				this.O_0oOOO_.OO.().Styles["ReceiveContent"].ForeColor = colorDialog.Color;
				this.Oo.Oo00__oooo.().Styles["ReceiveContent"].ForeColor = colorDialog.Color;
			}
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0008E834 File Offset: 0x0008CA34
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			this.Oo0_O0o.o_. = false;
			Application.Idle -= this.o_o0_0_.O.;
			string text = o_O_o_oOoo__.OOOO_OO._oo.(new IMFontProperty(this.O_0oOOO_.OO.().Styles["SendContent"], this.O_0oOOO_.OO.().Styles["ReceiveContent"]), false, '\v', false);
			OO_00oOO.FileSys.WriteAllText(OO_00oOO.ProjectPath + "QQClient\\" + this.o.0_0_Ooo..UserName + ".cfg", text, false);
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0008E8C0 File Offset: 0x0008CAC0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0_Ooo. != null)
			{
				if (this.o.0_0_Ooo..TopicBar == this.Oo.Oo00__oooo.() && this.o.0_0_Ooo..TopicPage != this.Oo.Oo00__oooo.().Pages[0])
				{
					C1TopicLink c1TopicLink = this.Oo.Oo00__oooo.().Pages[0].FindLinkByTag(RuntimeHelpers.GetObjectValue(this.o.0_0_Ooo..Tag));
					if (c1TopicLink == null)
					{
						return;
					}
					this.o.0_0_Ooo..Text = ((IMBuddy)this.o.0_0_Ooo..Tag).SimpleName;
					this.o.0_0_Ooo. = c1TopicLink;
				}
				else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
				{
					string key = ((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).OO.O_o__.();
					IMBuddy imbuddy = null;
					if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(key))
					{
						imbuddy = this.o.0_0_Ooo..oo.___oo__0_O.[key];
					}
					if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(key))
					{
						imbuddy = this.o.0_0_Ooo..oo.___oo__0_O.[key];
					}
					if (imbuddy == null)
					{
						return;
					}
					C1TopicLink c1TopicLink2 = this.Oo.Oo00__oooo.().Pages[0].FindLinkByTag(imbuddy);
					if (c1TopicLink2 == null)
					{
						return;
					}
					this.o.0_0_Ooo..Text = imbuddy.SimpleName;
					this.o.0_0_Ooo. = c1TopicLink2;
				}
				int num = this.o.0_0_Ooo..Index;
				if (Operators.CompareString(((IMBuddy)this.o.0_0_Ooo..Tag).Name, "[System]", true) != 0)
				{
					DataTable oOOOo0.oo0OoO0. = this.o.0_0_Ooo..oOOOo0.oo0OoO0.;
					string str;
					if (this.o.0_0_Ooo..Tag is ooo0)
					{
						str = ((ooo0)this.o.0_0_Ooo..Tag).Oo_0__o.o.();
					}
					else if (this.o.0_0_Ooo..Tag is O_0OOOoO)
					{
						str = ((O_0OOOoO)this.o.0_0_Ooo..Tag).O_O0_o._O0o0O.();
					}
					else
					{
						str = ((IMBuddy)this.o.0_0_Ooo..Tag).Name;
					}
					foreach (DataRow row in this.o.0_0_Ooo..oOOOo0.oo0OoO0..Select("[Name] = '" + str + "'", "Time"))
					{
						oOOOo0.oo0OoO0..Rows.Remove(row);
					}
					this.Oo.Oo00__oooo.().Pages[0].Links.Remove(this.o.0_0_Ooo.);
					this.o.0_0_Ooo. = null;
					this.O_0oOOO_.OO.().Rows.Count = 0;
					this.Oo.Oo00__oooo.().Rows.Count = 0;
					if (this.Oo.Oo00__oooo.().Pages[0].Links.Count == 0)
					{
						this.Oo.Oo00__oooo.().Pages[0].PageVisible = false;
						this.oOO._O.().Enabled = false;
						this.oOo00_.0Oo.().Enabled = false;
						this.Oo_oo._O_.().Enabled = false;
						this.OO0_O0.o.().Enabled = false;
						this.oOOoo._.().Enabled = false;
						this.O._o_O0O.().Enabled = false;
						this.o_O.O000o__.().Enabled = false;
						this.O._o_O0O.().Value = "";
						return;
					}
					num = Math.Min(num, this.Oo.Oo00__oooo.().Pages[0].Links.Count - 1);
					this.o.0_0_Ooo. = this.Oo.Oo00__oooo.().Pages[0].Links[num];
					this.o.0_0_Ooo..Text = ((IMBuddy)this.o.0_0_Ooo..Tag).SimpleName + "←";
					this.O_0oOOO_.OO.().O_O0_.__O.(default(DateTime));
					this.Oo.Oo00__oooo.().O_O0_.__O.(default(DateTime));
					this.o_0_.Ooo__OOoo.();
					this.o.0_0_Ooo. = true;
				}
			}
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0008ECA4 File Offset: 0x0008CEA4
		private void <<EMPTY_NAME>>(int A_0, bool A_1, bool A_2 = false)
		{
			try
			{
				if (this.o.0_o0_00.().Parent == this.Oo.Oo00__oooo.())
				{
					this.o.0_o0_00.().Visible = false;
					this.o.0_o0_00.().Parent.Controls.Remove(this.o.0_o0_00.());
				}
				if (this.o_oO__.0.().Parent == this.Oo.Oo00__oooo.())
				{
					this.o_oO__.0.().Visible = false;
					this.o_oO__.0.().Parent.Controls.Remove(this.o_oO__.0.());
				}
				if (this.o.0_0_Ooo. != null)
				{
					this.Oo.Oo00__oooo.().O000.o..Clear();
					this.Oo.Oo00__oooo.().oOO00oo.O..Clear();
					this.Oo.Oo00__oooo.().O000.o..Clear();
					this.Oo.Oo00__oooo.().oO0Oo00o.00..Clear();
					this.Oo.Oo00__oooo.().O__OO.o..Clear();
					string text;
					if (this.o.0_0_Ooo..Tag is ooo0)
					{
						text = ((ooo0)this.o.0_0_Ooo..Tag).Oo_0__o.o.();
					}
					else if (this.o.0_0_Ooo..Tag is O_0OOOoO)
					{
						text = ((O_0OOOoO)this.o.0_0_Ooo..Tag).O_O0_o._O0o0O.();
					}
					else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
					{
						text = ((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).OO.O_o__.();
					}
					else
					{
						text = ((IMBuddy)this.o.0_0_Ooo..Tag).Name;
					}
					if (this.Oo.Oo00__oooo.().Tag == null)
					{
						this.Oo.Oo00__oooo.().Tag = new Dictionary<int, int>();
					}
					((Dictionary<int, int>)this.Oo.Oo00__oooo.().Tag).Clear();
					string text2 = "";
					if (this.O0O_o.O_O.().Checked)
					{
						text2 = "";
					}
					else if (this.o.o00_0O0o.().Checked)
					{
						text2 = "[Content] Like '\u0002=(%)=' Or [Content] Like '\u0002=?%?='";
					}
					else if (this.O._o_O0O.().Checked)
					{
						text2 = "[Content] Like '\u0002|%|\u0002' Or [Content] Like '\u0002<?%?>'";
					}
					if (Operators.CompareString(text2, "", true) == 0)
					{
						this.o.0_0_Ooo..LoadFilter = "[Name] = '" + text + "'";
					}
					else
					{
						this.o.0_0_Ooo..LoadFilter = string.Concat(new string[]
						{
							"[Name] = '",
							text,
							"' And (",
							text2,
							")"
						});
					}
					this.o.0_0_Ooo..LoadTop = "30";
					int num = (int)Math.Round(this.o.0_0_Ooo..TotalPages);
					if (A_0 == -1)
					{
						A_0 = num - 1;
					}
					ShareLibriay.LockWindowUpdate(base.Handle);
					if ((A_0 >= 0 && A_0 < num) || A_2)
					{
						this.Oo.Oo00__oooo.().Rows.Count = 0;
						if (A_0 == 0)
						{
							if (this.o.0_0_Ooo..Tag is ooo0)
							{
								ooo0 ooo = (ooo0)this.o.0_0_Ooo..Tag;
								this.O_0.00o.(this.Oo.Oo00__oooo.(), ooo.oo.o0.(), this.o.0_0_Ooo..UserName, ooo.O0_.OO.(), ooo.o0oO0O._0_.(), ooo.O0_.OO.());
							}
							else if (this.o.0_0_Ooo..Tag is O_0OOOoO)
							{
								O_0OOOoO o_0OOOoO = (O_0OOOoO)this.o.0_0_Ooo..Tag;
								this.O_0.00o.(this.Oo.Oo00__oooo.(), o_0OOOoO.oo_.__OoOO0OO0.(), o_0OOOoO.o0O0OOo._ooO_O.().Name, o_0OOOoO.o0O0OOo._ooO_O.(), o_0OOOoO.O_Oo0O.0_OooO.(), o_0OOOoO.o0O0OOo._ooO_O.());
							}
							else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
							{
								o0o0_oo00Oo o0o0_oo00Oo = (o0o0_oo00Oo)this.o.0_0_Ooo..Tag;
								this.O_0.00o.(this.Oo.Oo00__oooo.(), o0o0_oo00Oo.oOO_00_0.o.(), o0o0_oo00Oo.O_oO._O.(), o0o0_oo00Oo.OO0_o.Oo0O.(), o0o0_oo00Oo.o_0o.oo_o_.(), o0o0_oo00Oo.o.oo_o0O.());
							}
						}
						this.o.0_0_Ooo..LoadPage = A_0;
						this.o.0_0_Ooo..o0.o.(true, null);
						this.o.o00_0O0o.().Value = Conversions.ToString(A_0 + 1) + "/" + Conversions.ToString(num);
						if (this.o.0_0_Ooo..DataRows.Count > 0)
						{
							Oo0O oo0O = this.Oo.Oo00__oooo.();
							oo0O.BeginUpdate();
							foreach (DataRow dataRow in this.O_0O00.___..Select("", "Time"))
							{
								this.O_0.00o.(oo0O, dataRow);
								if (Operators.CompareString(dataRow["Read"].ToString(), "0", true) == 0)
								{
									dataRow["Read"] = 1;
								}
							}
							oo0O.EndUpdate();
							if (oo0O.Rows.Count > 0)
							{
								if (!A_1)
								{
									oo0O.ShowCell(oo0O.Rows.Count - 1, 0);
								}
								else
								{
									oo0O.ShowCell(0, 0);
								}
							}
							oo0O.Row = -1;
							if (this.O_0O00.___..GetChanges() != null)
							{
								this.o.0_0_Ooo..oOOOo0.oo0OoO0..Update(this.O_0O00.___.);
							}
						}
					}
					ShareLibriay.LockWindowUpdate(IntPtr.Zero);
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0008F1C4 File Offset: 0x0008D3C4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0_Ooo.)
			{
				this.o.0_0_Ooo. = false;
				this.oo_0.OOoo__.(-1, false, false);
			}
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0008F1DE File Offset: 0x0008D3DE
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0_Ooo..DataRows.Count > 0 && this.o.0_0_Ooo..LoadPage > 0)
			{
				this.oo_0.OOoo__.(0, false, false);
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0008F20A File Offset: 0x0008D40A
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0_Ooo..DataRows.Count > 0 && this.o.0_0_Ooo..LoadPage > 0)
			{
				this.oo_0.OOoo__.(this.o.0_0_Ooo..LoadPage - 1, false, false);
			}
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0008F244 File Offset: 0x0008D444
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0_Ooo..DataRows.Count > 0 && (double)this.o.0_0_Ooo..LoadPage < this.o.0_0_Ooo..TotalPages - 1.0)
			{
				this.oo_0.OOoo__.(this.o.0_0_Ooo..LoadPage + 1, true, false);
			}
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0008F29C File Offset: 0x0008D49C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num = (int)Math.Round(this.o.0_0_Ooo..TotalPages);
			if (this.o.0_0_Ooo..DataRows.Count > 0 && this.o.0_0_Ooo..LoadPage < num - 1)
			{
				this.oo_0.OOoo__.(num - 1, true, false);
			}
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0008F2EC File Offset: 0x0008D4EC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o\u3002\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000 o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u = new o\u3002\u3000\u3002\u3002\u3000\u3000\u3002\u3000\u3002\u3000(this.o.0_0_Ooo., this.O_0oOOO_.OO.());
			if (o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u.ShowDialog() == DialogResult.OK)
			{
				Application.DoEvents();
				string text = OoOo0O.OO_o.0o_O.(10);
				ooo0 ooo = new ooo0(o0___oO.o0__.0.(o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u.o.00oOo_.().Text).Replace("\f", ""), this.o.0_0_Ooo..ooOo.oO0., text, o0___oO.o0__.0.(o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u.oo00O._.().Text));
				ooo.O0_.OO.(o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u.o0o.o0oO_.);
				string text2 = this.o.0_0_Ooo..UserName;
				try
				{
					foreach (IMBuddy imbuddy in o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u.o0o.o0oO_.)
					{
						text2 = text2 + "," + imbuddy.Name;
					}
				}
				finally
				{
					List<IMBuddy>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				text2 = text2.Trim(new char[]
				{
					','
				});
				ooo.O0_.OO.(text2);
				string text3 = "\v";
				string s = string.Concat(new string[]
				{
					"*",
					text3,
					this.o.0_0_Ooo..UserName,
					text3,
					this.o.0_0_Ooo..o_oo0Oooo.OOO_.,
					text3,
					ooo.oo.o0.(),
					text3,
					o_u3002_u3000_u3002_u3002_u3000_u3000_u3002_u3000_u3002_u.oo00O._.().Text.Trim(),
					text3,
					ooo.Oo_0__o.o.(),
					text3,
					text2
				});
				byte[] bytes = Encoding.Unicode.GetBytes(s);
				this.o.0_0_Ooo..O00._Oo..Send(bytes, bytes.Length, this.o.0_0_Ooo..ooOo.oO0.);
				DateTime now = DateTime.Now;
				bool flag;
				while (DateTime.Compare(DateTime.Now, now.AddSeconds(5.0)) < 0)
				{
					if (this.o.0_0_Ooo..O00._Oo..Available > 0)
					{
						double totalSeconds = (DateTime.Now - now).TotalSeconds;
						IPEndPoint ipendPoint = new IPEndPoint(IPAddress.Any, 0);
						byte[] bytes2 = this.o.0_0_Ooo..O00._Oo..Receive(ref ipendPoint);
						if (Operators.CompareString(Encoding.Unicode.GetString(bytes2), "{OK}", true) == 0)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					DataRow dataRow = this.o.0_0_Ooo..oo00000_0o0.oO..NewRow();
					dataRow["MeetingKey"] = ooo.Oo_0__o.o.();
					dataRow["Hostess"] = this.o.0_0_Ooo..UserName;
					dataRow["MeetingName"] = ooo.oo.o0.();
					dataRow["DateTime"] = ooo.O0_.OO.();
					dataRow["Description"] = ooo.O0_.OO.();
					dataRow["Members"] = ooo.o0oO0O._0_.();
					dataRow["Finish"] = false;
					this.o.0_0_Ooo..oo00000_0o0.oO..Rows.Add(dataRow);
					this.o.0_0_Ooo..oo00000_0o0.oO..Update(new DataRow[]
					{
						dataRow
					});
					C1TopicLink c1TopicLink = new C1TopicLink();
					c1TopicLink.Tag = ooo;
					c1TopicLink.Text = ooo.oo.o0.();
					c1TopicLink.ImageIndex = 9;
					this.Oo.Oo00__oooo.().Pages[0].Links.Add(c1TopicLink);
					if (this.o.0_0_Ooo. != null)
					{
						if (this.o.0_0_Ooo..Tag is IMBuddy)
						{
							this.o.0_0_Ooo..Text = ((IMBuddy)this.o.0_0_Ooo..Tag).SimpleName;
						}
						else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
						{
							this.o.0_0_Ooo..Text = ((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).oOO_00_0.o.();
						}
					}
					this.O_0oOOO_.OO.().Rows.Count = 0;
					this.Oo.Oo00__oooo.().Rows.Count = 0;
					this.O_0oOOO_.OO.().O_O0_.__O.(default(DateTime));
					this.Oo.Oo00__oooo.().O_O0_.__O.(default(DateTime));
					this.o.0_0_Ooo. = c1TopicLink;
					c1TopicLink.Text += "←";
					if (!this.Oo.Oo00__oooo.().Pages[0].PageVisible)
					{
						this.Oo.Oo00__oooo.().Pages[0].PageVisible = true;
					}
					this.o.0_0_Ooo..oo.___oo__0_O..Add(text, ooo);
					this.O_0.00o.(this.O_0oOOO_.OO.(), ooo.oo.o0.(), this.o.0_0_Ooo..UserName, ooo.O0_.OO.(), text2, DateTime.Now);
					if (!this.OO0_O0.o.().Enabled)
					{
						this.oOO._O.().Enabled = true;
						this.oOo00_.0Oo.().Enabled = true;
						this.Oo_oo._O_.().Enabled = true;
						this.OO0_O0.o.().Enabled = true;
						this.oOOoo._.().Enabled = true;
						this.O._o_O0O.().Enabled = true;
						this.o_O.O000o__.().Enabled = true;
					}
					this.o0__.O_Ooo_.(ooo.oo.o0.(), ooo.Oo_0__o.o.(), this.o.0_0_Ooo..UserName, ooo.O0_.OO.(), ooo.o0oO0O._0_.(), ooo.O0_.OO.(), 0);
					this.o_0_.Ooo__OOoo.();
				}
			}
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0008F824 File Offset: 0x0008DA24
		private void <<EMPTY_NAME>>(Oo0O A_0, string A_1, string A_2, string A_3, string A_4, DateTime A_5)
		{
			A_0.BeginUpdate();
			A_0.Rows.Count = A_0.Rows.Count + 1;
			A_0[A_0.Rows.Count - 1, 1] = Strings.Format(A_5, "yyyy年M月d日");
			A_0.Rows[A_0.Rows.Count - 1].Style = A_0.Styles["Date"];
			A_0.Rows[A_0.Rows.Count - 1].UserData = "0";
			A_0.Rows.Count = A_0.Rows.Count + 1;
			A_0[A_0.Rows.Count - 1, 1] = "会议开始:";
			A_0.Rows[A_0.Rows.Count - 1].UserData = "1";
			A_0.Rows.Count = A_0.Rows.Count + 1;
			A_0[A_0.Rows.Count - 1, 1] = string.Concat(new string[]
			{
				"名称:",
				A_1,
				"\r\n主题:",
				A_3,
				"\r\n时间:",
				Strings.Format(A_5, "yyyy-MM-dd HH:mm"),
				"\r\n召集人:",
				A_2,
				"\r\n参与者:",
				A_4
			});
			A_0.Rows[A_0.Rows.Count - 1].UserData = "2";
			A_0.O_O0_.__O.(A_5.Date);
			A_0.Rows[A_0.Rows.Count - 2].Style = A_0.Styles["ReceiveContent"];
			A_0.Rows[A_0.Rows.Count - 1].Style = A_0.Styles["ReceiveContent"];
			A_0.AutoSizeRow(A_0.Rows.Count - 2);
			A_0.AutoSizeRow(A_0.Rows.Count - 1);
			A_0.EndUpdate();
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0008FA54 File Offset: 0x0008DC54
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				ooo0 ooo = null;
				if (this.o.0_0_Ooo..Tag is ooo0)
				{
					ooo = (ooo0)this.o.0_0_Ooo..Tag;
				}
				else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
				{
					o0o0_oo00Oo o0o0_oo00Oo = (o0o0_oo00Oo)this.o.0_0_Ooo..Tag;
					if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(o0o0_oo00Oo.OO.O_o__.()))
					{
						ooo = this.o.0_0_Ooo..oo.___oo__0_O.[o0o0_oo00Oo.OO.O_o__.()];
					}
				}
				if (ooo != null)
				{
					if (MessageBox.Show("确定要结束会议\"" + ooo.oo.o0.() + "\"吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
					{
						char value = '\v';
						string a_ = string.Concat(new string[]
						{
							"*2",
							Conversions.ToString(value),
							this.o.0_0_Ooo..UserName,
							Conversions.ToString(value),
							this.o.0_0_Ooo..o_oo0Oooo.OOO_.,
							Conversions.ToString(value),
							ooo.Oo_0__o.o.()
						});
						this.o.0_0_Ooo..O.00O0_O_o_oO.(a_);
						DataRow[] array = this.o.0_0_Ooo..oo00000_0o0.oO..Select("[MeetingKey] = '" + ooo.Oo_0__o.o.() + "'", "");
						checked
						{
							for (int i = 0; i < array.Length; i++)
							{
								array[i]["Finish"] = true;
							}
							new OleDbCommand("Update Meetings Set [Finish] = True Where [MeetingKey] = '" + ooo.Oo_0__o.o.() + "'", this.o.0_0_Ooo..oOO0O.O0O0.).ExecuteNonQuery();
						}
						if (this.o.0_0_Ooo. != null && this.o.0_0_Ooo..Tag is ooo0)
						{
							this.Oo_oo._O_.().PerformClick();
							this.o.0_0_Ooo..oo.___oo__0_O..Remove(ooo.Oo_0__o.o.());
							if (this.O_0oOOO_.OO.().Pages.Count > 0)
							{
								int num = this.O_0oOOO_.OO.().Pages.Count - 1;
								for (int j = 0; j <= num; j++)
								{
									C1TopicPage c1TopicPage = this.O_0oOOO_.OO.().Pages[j];
									try
									{
										foreach (object obj in c1TopicPage.Links)
										{
											C1TopicLink c1TopicLink = (C1TopicLink)obj;
											if (Operators.CompareString(((o0o0_oo00Oo)c1TopicLink.Tag).OO.O_o__.(), ooo.Oo_0__o.o.(), true) == 0)
											{
												c1TopicLink.ImageIndex = 13;
												((o0o0_oo00Oo)c1TopicLink.Tag).o.oo_o0O.(true);
												if (this.o.0_0_Ooo. == null || this.o.0_0_Ooo. == c1TopicLink)
												{
													this.oOO._O.().Enabled = false;
													this.oOo00_.0Oo.().Enabled = false;
													this.Oo_oo._O_.().Enabled = false;
													this.OO0_O0.o.().Enabled = false;
													this.oOOoo._.().Enabled = false;
													this.O._o_O0O.().Enabled = false;
													this.o_O.O000o__.().Enabled = false;
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
							}
						}
					}
				}
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0008FDC0 File Offset: 0x0008DFC0
		internal void <<EMPTY_NAME>>(string A_0, string A_1, string A_2, string A_3, string A_4, DateTime A_5, int A_6 = -1)
		{
			bool flag = true;
			string text = Strings.Format(A_5, "yyyy年MM月");
			if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(A_1) || this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(A_1))
			{
				flag = false;
			}
			if (this.O_0oOOO_.OO.().FindPage(text) == null)
			{
				C1TopicPage c1TopicPage = new C1TopicPage();
				c1TopicPage.Text = text;
				this.O_0oOOO_.OO.().Pages.Add(c1TopicPage);
				c1TopicPage.ImageList = this.O_0oOOO_.OO.();
			}
			o0o0_oo00Oo tag = new o0o0_oo00Oo(A_0, A_1, A_2, A_3, A_4, flag);
			C1TopicLink c1TopicLink = new C1TopicLink();
			c1TopicLink.Tag = tag;
			c1TopicLink.Text = A_0;
			if (flag)
			{
				c1TopicLink.ImageIndex = 13;
			}
			else
			{
				c1TopicLink.ImageIndex = 9;
			}
			C1TopicPage c1TopicPage2 = this.O_0oOOO_.OO.().FindPage(text);
			if (A_6 == -1)
			{
				c1TopicPage2.Links.Add(c1TopicLink);
			}
			else
			{
				c1TopicPage2.Links.Insert(0, c1TopicLink);
			}
			if (!this.oOOoo._.().TabPages[1].TabVisible)
			{
				this.oOOoo._.().TabPages[1].TabVisible = true;
			}
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0008FEE0 File Offset: 0x0008E0E0
		private void <<EMPTY_NAME>>(object A_0, C1TopicBarClickEventArgs A_1)
		{
			if (this.o.0_0_Ooo. != A_1.Link)
			{
				if (this.o.0_0_Ooo. != null)
				{
					if (this.o.0_0_Ooo..Tag is IMBuddy)
					{
						this.o.0_0_Ooo..Text = ((IMBuddy)this.o.0_0_Ooo..Tag).SimpleName;
					}
					else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
					{
						this.o.0_0_Ooo..Text = ((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).oOO_00_0.o.();
					}
				}
				A_1.Link.Text = ((o0o0_oo00Oo)A_1.Link.Tag).oOO_00_0.o.() + "←";
				string text = ((o0o0_oo00Oo)A_1.Link.Tag).OO.O_o__.();
				if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(text))
				{
					C1TopicLink c1TopicLink = this.Oo.Oo00__oooo.().Pages[0].FindLinkByTag(this.o.0_0_Ooo..oo.___oo__0_O.[text]);
					if (c1TopicLink != null)
					{
						c1TopicLink.Text = this.o.0_0_Ooo..oo.___oo__0_O.[text].oo.o0.();
					}
				}
				if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(text))
				{
					C1TopicLink c1TopicLink2 = this.Oo.Oo00__oooo.().Pages[0].FindLinkByTag(this.o.0_0_Ooo..oo.___oo__0_O.[text]);
					if (c1TopicLink2 != null)
					{
						c1TopicLink2.Text = this.o.0_0_Ooo..oo.___oo__0_O.[text].oo_.__OoOO0OO0.();
					}
				}
				if (this.o.0_0_Ooo. != null && this.o.0_0_Ooo..Tag is ooo0 && Operators.CompareString(((ooo0)this.o.0_0_Ooo..Tag).Oo_0__o.o.(), text, true) == 0)
				{
					this.o.0_0_Ooo. = A_1.Link;
					return;
				}
				if (this.o.0_0_Ooo. != null && this.o.0_0_Ooo..Tag is O_0OOOoO && Operators.CompareString(((O_0OOOoO)this.o.0_0_Ooo..Tag).O_O0_o._O0o0O.(), text, true) == 0)
				{
					this.o.0_0_Ooo. = A_1.Link;
					return;
				}
				bool flag;
				if (this.o.0_0_Ooo. == null)
				{
					flag = true;
				}
				else if (this.o.0_0_Ooo..Tag != A_1.Link.Tag)
				{
					flag = true;
				}
				this.o.0_0_Ooo. = A_1.Link;
				if (flag)
				{
					this.O_0oOOO_.OO.().Rows.Count = 0;
					this.Oo.Oo00__oooo.().Rows.Count = 0;
					this.O_0oOOO_.OO.().O_O0_.__O.(default(DateTime));
					this.Oo.Oo00__oooo.().O_O0_.__O.(default(DateTime));
					this.o.0_0_Ooo. = false;
					this.o_0_.Ooo__OOoo.();
					this.oo_0.OOoo__.(-1, false, false);
				}
				bool flag2 = !((o0o0_oo00Oo)A_1.Link.Tag).O_oO._O.();
				this.oOO._O.().Enabled = flag2;
				this.oOo00_.0Oo.().Enabled = flag2;
				this.Oo_oo._O_.().Enabled = flag2;
				this.OO0_O0.o.().Enabled = flag2;
				this.oOOoo._.().Enabled = true;
				this.O._o_O0O.().Enabled = flag2;
				this.o_O.O000o__.().Enabled = flag2;
				if (!flag2)
				{
					this.ooO.0o00__0.().SelectedIndex = 1;
				}
			}
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00090200 File Offset: 0x0008E400
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0_Ooo. != null)
			{
				FormWindowState windowState = OO_00oOO.BaseMainForm.WindowState;
				bool flag;
				if (Control.ModifierKeys == Keys.Control)
				{
					flag = true;
				}
				if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
				{
					if (((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).O_oO._O.())
					{
						return;
					}
					this.oooo_0ooOo0.0O.();
				}
				else
				{
					this.OooOO_o0O0_._.();
				}
				if (Operators.CompareString(((IMBuddy)this.o.0_0_Ooo..Tag).Name, "[System]", true) != 0)
				{
					if (((IMBuddy)this.o.0_0_Ooo..Tag).oOo.o0__0Oo0oO. == 0 || ((IMBuddy)this.o.0_0_Ooo..Tag).O00OO.o_. == 0 || this.o.0_0_Ooo..ThroughServer)
					{
						flag = true;
					}
					if (this.O_.O0ooO.().Checked)
					{
						base.WindowState = FormWindowState.Minimized;
						base.Hide();
						Application.DoEvents();
					}
					else if (this.o.0_o0_00.().Checked)
					{
						base.WindowState = FormWindowState.Minimized;
						OO_00oOO.BaseMainForm.WindowState = FormWindowState.Minimized;
						OO_00oOO.BaseMainForm.Hide();
						Application.DoEvents();
					}
					try
					{
						string text = O_O0OO.o.00O_O.() + "capture.exe";
						if (OO_00oOO.FileSys.FileExists(text))
						{
							Image image = Clipboard.GetImage();
							if (image != null)
							{
								Clipboard.Clear();
							}
							Process process = new Process();
							process.File = text;
							process.Start();
							process.WaitForExit();
							Image image2 = Clipboard.GetImage();
							if (image2 == null)
							{
								if (image != null)
								{
									Clipboard.SetImage(image);
								}
							}
							else
							{
								string tempFileName = Path.GetTempFileName();
								string tempFileName2 = Path.GetTempFileName();
								image2.Save(tempFileName, ImageFormat.Png);
								image2.Save(tempFileName2, ImageFormat.Jpeg);
								FileInfo fileInfo = new FileInfo(tempFileName);
								FileInfo fileInfo2 = new FileInfo(tempFileName2);
								string text2;
								if (fileInfo.Length < fileInfo2.Length)
								{
									text2 = ".png";
									OO_00oOO.FileSys.DeleteFile(tempFileName2);
								}
								else
								{
									text2 = ".jpg";
									OO_00oOO.FileSys.DeleteFile(tempFileName);
								}
								string text3 = string.Concat(new string[]
								{
									OO_00oOO.ProjectPath,
									"QQClient\\CaptureFiles\\",
									Strings.Format(DateTime.Today, "yyyyMM"),
									"\\",
									OoOo0O.OO_o.0o_O.(10),
									text2
								});
								string parentPath = OO_00oOO.FileSys.GetParentPath(text3);
								if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
								{
									OO_00oOO.FileSys.CreateDirectory(parentPath);
								}
								if (Operators.CompareString(text2, ".png", true) == 0)
								{
									OO_00oOO.FileSys.MoveFile(tempFileName, text3);
								}
								else
								{
									OO_00oOO.FileSys.MoveFile(tempFileName2, text3);
								}
								this.oO_o_.___ooOO.(text3.Substring((OO_00oOO.ProjectPath + "QQClient\\CaptureFiles\\").Length));
								if (this.o.0_0_Ooo..Tag is IMBuddy)
								{
									IMBuddy imbuddy = (IMBuddy)this.o.0_0_Ooo..Tag;
									object[] parameter = new object[]
									{
										imbuddy,
										text3,
										SendTypeEnum.Capture,
										null,
										flag
									};
									new Thread(new ParameterizedThreadStart(this.o.0_0_Ooo..O00__O._O_00o.)).Start(parameter);
								}
							}
						}
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
					}
					finally
					{
						if (!OO_00oOO.BaseMainForm.Visible)
						{
							OO_00oOO.BaseMainForm.Show();
						}
						if (!base.Visible)
						{
							base.Show(OO_00oOO.BaseMainForm);
						}
						if (OO_00oOO.BaseMainForm.WindowState == FormWindowState.Minimized)
						{
							OO_00oOO.BaseMainForm.WindowState = windowState;
						}
						if (base.WindowState == FormWindowState.Minimized)
						{
							base.WindowState = FormWindowState.Normal;
						}
					}
				}
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x000905C0 File Offset: 0x0008E7C0
		internal void <<EMPTY_NAME>>(string A_0)
		{
			try
			{
				if (this.o.0_0_Ooo. != null)
				{
					if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
					{
						if (((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).O_oO._O.())
						{
							return;
						}
						this.oooo_0ooOo0.0O.();
					}
					else
					{
						this.OooOO_o0O0_._.();
					}
					if (Operators.CompareString(A_0, "", true) != 0)
					{
						string a_ = "\u0002=(" + A_0 + ")=";
						string a_2 = null;
						string a_3;
						if (this.o.0_0_Ooo..Tag is ooo0)
						{
							a_3 = ((ooo0)this.o.0_0_Ooo..Tag).Oo_0__o.o.();
							a_2 = this.o.0_0_Ooo..UserName;
						}
						else if (this.o.0_0_Ooo..Tag is O_0OOOoO)
						{
							a_3 = ((O_0OOOoO)this.o.0_0_Ooo..Tag).O_O0_o._O0o0O.();
							a_2 = this.o.0_0_Ooo..UserName;
						}
						else
						{
							if (!(this.o.0_0_Ooo..Tag is IMBuddy))
							{
								return;
							}
							a_3 = ((IMBuddy)this.o.0_0_Ooo..Tag).Name;
						}
						this.o.0_0_Ooo..O.00O0_O_o_oO.(a_3, a_, 2, 1, a_2);
					}
				}
			}
			catch (Exception a_4)
			{
				ooO.oOo0Oo.o.(a_4, "");
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00090720 File Offset: 0x0008E920
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			foreach (C1FlexGrid c1FlexGrid in new C1FlexGrid[]
			{
				this.O_0oOOO_.OO.(),
				this.Oo.Oo00__oooo.()
			})
			{
				if (c1FlexGrid.Tag == null)
				{
					break;
				}
				Dictionary<int, int> dictionary = (Dictionary<int, int>)c1FlexGrid.Tag;
				try
				{
					foreach (int row in dictionary.Values)
					{
						string text = c1FlexGrid[row, 1].ToString();
						int num;
						if (text.IndexOf(".") < 0)
						{
							num = 1;
						}
						else
						{
							num = text.Length - text.IndexOf(".");
							if (num == 6)
							{
								num = 1;
							}
							else
							{
								num++;
							}
						}
						c1FlexGrid[row, 1] = "正在加载 " + ".".PadRight(num, '.');
					}
				}
				finally
				{
					Dictionary<int, int>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00090824 File Offset: 0x0008EA24
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.O && (Control.ModifierKeys & Keys.Control) == Keys.Control && (Control.ModifierKeys & Keys.Shift) == Keys.Shift)
			{
				this.o_O.O000o__.().PerformClick();
			}
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0009085F File Offset: 0x0008EA5F
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.Oo0_O0o.o_. = true;
			Application.Idle += this.o_o0_0_.O.;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0009087C File Offset: 0x0008EA7C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0_Ooo..AllowSendFile)
			{
				try
				{
					if (this.o.0_0_Ooo. != null)
					{
						if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
						{
							if (((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).O_oO._O.())
							{
								return;
							}
							this.oooo_0ooOo0.0O.();
						}
						else
						{
							this.OooOO_o0O0_._.();
						}
						IMBuddy imbuddy = (IMBuddy)this.o.0_0_Ooo..Tag;
						if (Operators.CompareString(imbuddy.Name, "[System]", true) != 0)
						{
							bool flag;
							if (Control.ModifierKeys == Keys.Control)
							{
								flag = true;
							}
							OpenFileDialog openFileDialog = new OpenFileDialog();
							openFileDialog.Multiselect = true;
							if (openFileDialog.ShowDialog() == DialogResult.OK)
							{
								if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
								{
									if (((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).O_oO._O.())
									{
										return;
									}
									this.oooo_0ooOo0.0O.();
								}
								else
								{
									this.OooOO_o0O0_._.();
								}
								string text = "\v";
								foreach (string text2 in openFileDialog.FileNames)
								{
									oO0 oO = new oO0(this.o.0_0_Ooo., imbuddy, text2, SendTypeEnum.ManualFile);
									oO.OO_.0OOo.().Text = OO_00oOO.FileSys.GetName(text2);
									FileInfo fileInfo = new FileInfo(text2);
									string text3;
									if (fileInfo.Length / 1024L < 1000L)
									{
										text3 = (fileInfo.Length / 1024L).ToString() + "K";
									}
									else
									{
										text3 = Strings.Format((double)fileInfo.Length / 1024.0 / 1024.0, "0.00") + "M";
									}
									oO.o_0O.00.().Text = text3;
									if (this.o.0_0_Ooo..ooOooo.oO. == null)
									{
										this.o.0_0_Ooo..ooOooo.oO. = new o\u3000\u3002\u3000\u3002\u3000(this.o.0_0_Ooo.);
										this.o.0_0_Ooo..ooOooo.oO..Owner = OO_00oOO.BaseMainForm;
									}
									this.o.0_0_Ooo..ooOooo.oO..O_0O_o.0.(oO);
									this.o.0_0_Ooo..ooOooo.oO..Show();
									if (((IMBuddy)this.o.0_0_Ooo..Tag).oOo.o0__0Oo0oO. == 0 || ((IMBuddy)this.o.0_0_Ooo..Tag).O00OO.o_. == 0 || flag)
									{
										object[] parameter = new object[]
										{
											imbuddy,
											text2,
											SendTypeEnum.ManualFile,
											oO,
											flag
										};
										oO.o.oo00_.().Visible = false;
										new Thread(new ParameterizedThreadStart(this.o.0_0_Ooo..O00__O._O_00o.)).Start(parameter);
										if (imbuddy is ooo0 || imbuddy is O_0OOOoO)
										{
											string a_ = string.Concat(new string[]
											{
												"\u0002(我方开始上传文件\"",
												OO_00oOO.FileSys.GetName(text2),
												"\"(",
												text3,
												"))\u0002"
											});
											this.o.0_0_Ooo..O.00O0_O_o_oO.(o0___oO.o0__.0.(imbuddy), a_, 2, 1, this.o.0_0_Ooo..UserName);
										}
										else
										{
											string a_ = string.Concat(new string[]
											{
												"\u0002(我方开始离线发送文件\"",
												OO_00oOO.FileSys.GetName(text2),
												"\"(",
												text3,
												"))\u0002"
											});
											this.o.0_0_Ooo..O.00O0_O_o_oO.(o0___oO.o0__.0.(imbuddy), a_, 2, 1, null);
										}
									}
									else
									{
										string a_2 = string.Concat(new string[]
										{
											"%5",
											text,
											this.o.0_0_Ooo..UserName,
											text,
											this.o.0_0_Ooo..o_oo0Oooo.OOO_.,
											text,
											oO.o0O.Oo.,
											text,
											OO_00oOO.FileSys.GetName(text2),
											text,
											text3
										});
										this.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy.Name, a_2);
										a_2 = string.Concat(new string[]
										{
											"\u0002(我方请求发送文件\"",
											OO_00oOO.FileSys.GetName(text2),
											"\"(",
											text3,
											"))\u0002"
										});
										this.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy.Name, a_2, 2, 1, null);
									}
								}
							}
						}
					}
				}
				catch (Exception a_3)
				{
					ooO.oOo0Oo.o.(a_3, "");
				}
			}
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00090CFC File Offset: 0x0008EEFC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooo0 ooo = null;
			if (this.o.0_0_Ooo..Tag is ooo0)
			{
				ooo = (ooo0)this.o.0_0_Ooo..Tag;
			}
			else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
			{
				o0o0_oo00Oo o0o0_oo00Oo = (o0o0_oo00Oo)this.o.0_0_Ooo..Tag;
				if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(o0o0_oo00Oo.OO.O_o__.()))
				{
					ooo = this.o.0_0_Ooo..oo.___oo__0_O.[o0o0_oo00Oo.OO.O_o__.()];
				}
			}
			if (ooo != null)
			{
				o\u3000\u3002o\u3000\u3002\u3002\u3002\u3002\u3000 o_u3000_u3002o_u3000_u3002_u3002_u3002_u3002_u = new o\u3000\u3002o\u3000\u3002\u3002\u3002\u3002\u3000(this.o.0_0_Ooo., this.O_0oOOO_.OO.(), ooo.O0_.OO.());
				if (o_u3000_u3002o_u3000_u3002_u3002_u3002_u3002_u.ShowDialog() == DialogResult.OK)
				{
					string text = "\v";
					string text2 = "";
					string text3 = "";
					string text4 = string.Concat(new string[]
					{
						"*2",
						text,
						this.o.0_0_Ooo..UserName,
						text,
						this.o.0_0_Ooo..o_oo0Oooo.OOO_.,
						text,
						ooo.Oo_0__o.o.()
					});
					try
					{
						foreach (IMBuddy imbuddy in ooo.O0_.OO.())
						{
							if (!o_u3000_u3002o_u3000_u3002_u3002_u3002_u3002_u.oo.ooOOoo..Contains(imbuddy))
							{
								text3 = text3 + "," + imbuddy.Name;
								if (imbuddy.OnLine)
								{
									this.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy.Name, text4);
								}
							}
						}
					}
					finally
					{
						List<IMBuddy>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					string text5 = this.o.0_0_Ooo..UserName;
					try
					{
						foreach (IMBuddy imbuddy2 in o_u3000_u3002o_u3000_u3002_u3002_u3002_u3002_u.oo.ooOOoo.)
						{
							text5 = text5 + "," + imbuddy2.Name;
						}
					}
					finally
					{
						List<IMBuddy>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					text5 = text5.Trim(new char[]
					{
						','
					});
					text4 = string.Concat(new string[]
					{
						"*",
						text,
						this.o.0_0_Ooo..UserName,
						text,
						ooo.oo.o0.(),
						text,
						ooo.O0_.OO.(),
						text,
						ooo.Oo_0__o.o.(),
						text,
						text5,
						text,
						Strings.Format(ooo.O0_.OO.(), "MM/dd/yyyy HH:ss")
					});
					try
					{
						foreach (IMBuddy imbuddy3 in o_u3000_u3002o_u3000_u3002_u3002_u3002_u3002_u.oo.ooOOoo.)
						{
							if (!ooo.O0_.OO.().Contains(imbuddy3))
							{
								text2 = text2 + "," + imbuddy3.Name;
								if (imbuddy3.OnLine)
								{
									this.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy3.Name, text4);
								}
							}
							else
							{
								this.o.0_0_Ooo..Send(imbuddy3.Name, string.Concat(new string[]
								{
									text,
									this.o.0_0_Ooo..UserName,
									text,
									ooo.oo.o0.(),
									text,
									text5
								}), false, false);
							}
						}
					}
					finally
					{
						List<IMBuddy>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					ooo.O0_.OO.(o_u3000_u3002o_u3000_u3002_u3002_u3002_u3002_u.oo.ooOOoo.);
					ooo.O0_.OO.(text5);
					text4 = string.Concat(new string[]
					{
						"*3",
						text,
						this.o.0_0_Ooo..UserName,
						text,
						this.o.0_0_Ooo..o_oo0Oooo.OOO_.,
						text,
						ooo.Oo_0__o.o.(),
						text,
						text5
					});
					this.o.0_0_Ooo..O.00O0_O_o_oO.(text4);
					text4 = string.Concat(new string[]
					{
						"*3",
						text,
						this.o.0_0_Ooo..UserName,
						text,
						this.o.0_0_Ooo..o_oo0Oooo.OOO_.,
						text,
						ooo.Oo_0__o.o.(),
						text,
						text2.Trim(new char[]
						{
							','
						}),
						text,
						text3.Trim(new char[]
						{
							','
						})
					});
					try
					{
						foreach (IMBuddy imbuddy4 in ooo.O0_.OO.())
						{
							if (imbuddy4.OnLine)
							{
								this.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy4.Name, text4);
							}
						}
					}
					finally
					{
						List<IMBuddy>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					if (Operators.CompareString(text2.Trim(new char[]
					{
						','
					}), "", true) > 0)
					{
						text4 = "\u0002(有新用户加入会议:\r\n" + text2.Trim(new char[]
						{
							','
						}) + ")\u0002";
						this.o.0_0_Ooo..O.00O0_O_o_oO.(ooo.Oo_0__o.o.(), text4, 2, 1, this.o.0_0_Ooo..UserName);
					}
					if (Operators.CompareString(text3.Trim(new char[]
					{
						','
					}), "", true) > 0)
					{
						text4 = "\u0002(有用户被请出会议:\r\n" + text3.Trim(new char[]
						{
							','
						}) + ")\u0002";
						this.o.0_0_Ooo..O.00O0_O_o_oO.(ooo.Oo_0__o.o.(), text4, 2, 1, this.o.0_0_Ooo..UserName);
					}
				}
			}
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00091250 File Offset: 0x0008F450
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.O_O0__0_0.().BackColor = Color.FromArgb(241, 248, 254);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00091271 File Offset: 0x0008F471
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.O_O0__0_0.().BackColor = Color.FromArgb(187, 206, 230);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00091294 File Offset: 0x0008F494
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			this.O00oO0_.O.();
			bool visible;
			if (this.o.0_0_Ooo. != null)
			{
				if (this.o.0_0_Ooo..Tag is ooo0)
				{
					visible = true;
				}
				else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
				{
					o0o0_oo00Oo o0o0_oo00Oo = (o0o0_oo00Oo)this.o.0_0_Ooo..Tag;
					if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(o0o0_oo00Oo.OO.O_o__.()))
					{
						visible = true;
					}
				}
			}
			this.ooOoo___0.oO0.().Visible = visible;
			this.o_oO__.0.().Visible = visible;
			this.o.0_o0_00.().Visible = visible;
			this.O0oO_Oo0oO_.o.().Show(this.O.O_O0__0_0.(), 0, this.O.O_O0__0_0.().Height);
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00091344 File Offset: 0x0008F544
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Oo0O oo0O = (Oo0O)A_0;
			if (oo0O.O000.o..ContainsKey(oo0O.RowSel) && OO_00oOO.FileSys.FileExists(oo0O.O000.o.[oo0O.RowSel]))
			{
				Process.Start(oo0O.O000.o.[oo0O.RowSel]);
			}
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x000913A0 File Offset: 0x0008F5A0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_o._o0___.().ForeColor = this.O_0oOOO_.OO.().Styles.Highlight.ForeColor;
			this.Oo.Oo00__oooo.().ForeColor = this.O_0oOOO_.OO.().Styles.Highlight.ForeColor;
			this.o.o__0o.().ForeColor = this.O_0oOOO_.OO.().Styles.Highlight.ForeColor;
			try
			{
				Oo0O oo0O = (Oo0O)A_0;
				if (oo0O.Rows.Count != 0)
				{
					int bottomRow = oo0O.Selection.BottomRow;
					if ((!this.o.0_o0_00.().Visible || this.o.0_o0_00.().Parent != A_0) && oo0O.O000.o..ContainsKey(bottomRow))
					{
						oo0O.BeginUpdate();
						this.o.0_o0_00.().Visible = false;
						int x = oo0O.Width - this.o.0_o0_00.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible == ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0));
						int y = oo0O.Rows[bottomRow].Bottom - this.o.0_o0_00.().Height + oo0O.ScrollPosition.Y;
						this.o.0_o0_00.().Location = new Point(x, y);
						this.o.0_o0_00.().Tag = bottomRow;
						this.o.0_o0_00.().Anchor = AnchorStyles.Right;
						oo0O.Controls.Add(this.o.0_o0_00.());
						this.o.0_o0_00.().Visible = true;
						oo0O.EndUpdate();
					}
					if ((!this.o.o00_0O0o.().Visible || this.o.o00_0O0o.().Parent != A_0) && oo0O.oO0Oo00o.00..ContainsKey(bottomRow))
					{
						oo0O.BeginUpdate();
						this.o.o00_0O0o.().Visible = false;
						int x2 = oo0O.Width - this.o.o00_0O0o.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible == ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0));
						int y2 = oo0O.Rows[bottomRow].Top - this.o.o00_0O0o.().Height + oo0O.ScrollPosition.Y - 5;
						this.o.o00_0O0o.().Location = new Point(x2, y2);
						this.o.o00_0O0o.().Tag = bottomRow;
						this.o.o00_0O0o.().Anchor = AnchorStyles.Right;
						oo0O.Controls.Add(this.o.o00_0O0o.());
						this.o.o00_0O0o.().Visible = true;
						oo0O.EndUpdate();
					}
					if ((!this.o_oO__.0.().Visible || this.o_oO__.0.().Parent != A_0) && oo0O.oOO00oo.O..ContainsKey(bottomRow))
					{
						oo0O.BeginUpdate();
						this.o_oO__.0.().Visible = false;
						int x3 = oo0O.Width - this.o_oO__.0.().Width - Conversions.ToInteger(Interaction.IIf(oo0O.ScrollBarsVisible == ScrollBars.Vertical, SystemInformation.VerticalScrollBarWidth, 0));
						int y3 = oo0O.Rows[bottomRow].Bottom - this.o_oO__.0.().Height + oo0O.ScrollPosition.Y;
						this.o_oO__.0.().Location = new Point(x3, y3);
						this.o_oO__.0.().Tag = bottomRow;
						this.o_oO__.0.().Anchor = AnchorStyles.Right;
						oo0O.Controls.Add(this.o_oO__.0.());
						this.o_oO__.0.().Visible = true;
						oo0O.EndUpdate();
					}
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00091764 File Offset: 0x0008F964
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Oo0O oo0O = (Oo0O)this.o.0_o0_00.().Parent;
			int key = Conversions.ToInteger(this.o.0_o0_00.().Tag);
			if (oo0O.O000.o..ContainsKey(key))
			{
				string text = oo0O.O000.o.[key]["Content"].ToString();
				text = text.Substring(2, text.Length - 4);
				string[] array = text.Split(new char[]
				{
					'\t'
				});
				text = OO_00oOO.ProjectPath + "QQClient\\ReceivedFiles\\" + array[0];
				if (OO_00oOO.FileSys.FileExists(text))
				{
					new Process
					{
						StartInfo = 
						{
							FileName = text
						}
					}.Start();
				}
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00091818 File Offset: 0x0008FA18
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Oo0O oo0O = (Oo0O)this.o.0_o0_00.().Parent;
			int key = Conversions.ToInteger(this.o.0_o0_00.().Tag);
			if (oo0O.O000.o..ContainsKey(key))
			{
				string text = oo0O.O000.o.[key]["Content"].ToString();
				text = text.Substring(2, text.Length - 4);
				string[] array = text.Split(new char[]
				{
					'\t'
				});
				text = OO_00oOO.ProjectPath + "QQClient\\ReceivedFiles\\" + array[0];
				if (OO_00oOO.FileSys.FileExists(text))
				{
					Process.Start("explorer.exe", "/select," + text);
				}
			}
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000918CC File Offset: 0x0008FACC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Oo0O oo0O = (Oo0O)this.o_oO__.0.().Parent;
			int key = Conversions.ToInteger(this.o_oO__.0.().Tag);
			try
			{
				if (oo0O.oOO00oo.O..ContainsKey(key))
				{
					DataRow dataRow = oo0O.oOO00oo.O.[key];
					int item = Conversions.ToInteger(dataRow["_Identify"]);
					object oOO0_O.O__0_0. = this.o.0_0_Ooo..oOO0_O.O__0_0.;
					lock (oOO0_O.O__0_0.)
					{
						if (!this.o.0_0_Ooo..oOO0_O.O__0_0..Contains(item))
						{
							string text = dataRow["Content"].ToString();
							if (text.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) || text.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase) || text.EndsWith(".com", StringComparison.CurrentCultureIgnoreCase) || text.EndsWith(".cn", StringComparison.CurrentCultureIgnoreCase) || text.EndsWith(".net", StringComparison.CurrentCultureIgnoreCase))
							{
								Process.Start(text);
							}
							else
							{
								text = text.Substring(3, text.Length - 5);
								string[] array = text.Split(new char[]
								{
									'\t'
								});
								if (array.Length >= 2)
								{
									object[] array2 = new object[5];
									array2[0] = array[0];
									if (this.o.0_0_Ooo..Tag is IMBuddy)
									{
										array2[1] = (IMBuddy)this.o.0_0_Ooo..Tag;
									}
									else if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
									{
										string key2 = ((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).OO.O_o__.();
										if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(key2))
										{
											array2[1] = this.o.0_0_Ooo..oo.___oo__0_O.[key2];
										}
										else if (this.o.0_0_Ooo..oo.___oo__0_O..ContainsKey(key2))
										{
											array2[1] = this.o.0_0_Ooo..oo.___oo__0_O.[key2];
										}
										else
										{
											array2[1] = null;
										}
									}
									else
									{
										array2[1] = null;
									}
									array2[2] = dataRow;
									array2[3] = SendTypeEnum.ManualFile;
									array2[4] = array[1];
									this.O_o._o0___.().Text = "下载中...";
									this.O_o._o0___.().Cursor = Cursors.Default;
									this.o.0_0_Ooo..oOO0_O.O__0_0..Add(Conversions.ToInteger(dataRow["_Identify"]));
									new Thread(new ParameterizedThreadStart(this.o0__.O_Ooo_.)).Start(array2);
								}
							}
						}
					}
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00091B8C File Offset: 0x0008FD8C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.0_o0_00.().Visible = false;
			this.o_oO__.0.().Visible = false;
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00091BA6 File Offset: 0x0008FDA6
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0O_o.O_O.().Checked)
			{
				this.oo_0.OOoo__.(0, false, true);
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00091BBE File Offset: 0x0008FDBE
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.o00_0O0o.().Checked)
			{
				this.oo_0.OOoo__.(0, false, true);
			}
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00091BD6 File Offset: 0x0008FDD6
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O._o_O0O.().Checked)
			{
				this.oo_0.OOoo__.(0, false, true);
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00091BF0 File Offset: 0x0008FDF0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0_0_Ooo. != null)
			{
				bool flag;
				if (Control.ModifierKeys == Keys.Control)
				{
					flag = true;
				}
				if (!(this.o.0_0_Ooo..Tag is o0o0_oo00Oo) && !(this.o.0_0_Ooo..Tag is ooo0) && !(this.o.0_0_Ooo..Tag is O_0OOOoO))
				{
					this.OooOO_o0O0_._.();
					IMBuddy imbuddy = (IMBuddy)this.o.0_0_Ooo..Tag;
					Oo0O oo0O = (Oo0O)this.o.o00_0O0o.().Parent;
					int key = Conversions.ToInteger(this.o.o00_0O0o.().Tag);
					string text = oo0O.oO0Oo00o.00.[key]["Content"].ToString();
					text = text.Substring(2, text.Length - 4);
					if (text.StartsWith("\u0002=(") && text.EndsWith(")="))
					{
						string text2 = OO_00oOO.ProjectPath + "QQClient\\CaptureFiles\\" + text.Substring(3, text.Length - 5);
						if (OO_00oOO.FileSys.FileExists(text2))
						{
							this.oO_o_.___ooOO.(text.Substring(3, text.Length - 5));
							object[] parameter = new object[]
							{
								imbuddy,
								text2,
								SendTypeEnum.Capture,
								null,
								flag
							};
							new Thread(new ParameterizedThreadStart(this.o.0_0_Ooo..O00__O._O_00o.)).Start(parameter);
							return;
						}
					}
					else
					{
						if (imbuddy.OnLine)
						{
							this.o.0_0_Ooo..O_._00O0_. = this.o.0_0_Ooo..O_._00O0_. + 1;
							this.o.0_0_Ooo..ooOo.oO0..Add(this.o.0_0_Ooo..O_._00O0_., new O0o000(imbuddy, text));
							if (Control.ModifierKeys == Keys.Control)
							{
								this.o.0_0_Ooo..Send(imbuddy.Name, string.Concat(new string[]
								{
									"={",
									text,
									"\u0004",
									this.o.0_0_Ooo..O_._00O0_..ToString(),
									"}="
								}), true, true);
							}
							else
							{
								this.o.0_0_Ooo..Send(imbuddy.Name, string.Concat(new string[]
								{
									"={",
									text,
									"\u0004",
									this.o.0_0_Ooo..O_._00O0_..ToString(),
									"}="
								}), true, false);
							}
						}
						else
						{
							this.o.0_0_Ooo..Send(imbuddy.Name, "={" + text + "}=", true, false);
						}
						this.o.0_0_Ooo..O.00O0_O_o_oO.(imbuddy.Name, text, 2, 1, null);
					}
				}
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00091E94 File Offset: 0x00090094
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			int num;
			if (A_1.KeyCode == Keys.Return && Operators.CompareString(this.o.o00_0O0o.().Text, "", true) > 0 && int.TryParse(this.o.o00_0O0o.().Text.Trim(), out num))
			{
				num--;
				if (this.o.0_0_Ooo..LoadPage != num && num >= 0 && (double)num < this.o.0_0_Ooo..TotalPages)
				{
					this.oo_0.OOoo__.(num, true, true);
				}
			}
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00091F0C File Offset: 0x0009010C
		internal void <<EMPTY_NAME>>(string A_0)
		{
			Oo0O oo0O = this.O_0oOOO_.OO.();
			oo0O.AddItem("\t" + Strings.Format(DateTime.Now, "HH:mm:ss"));
			oo0O.SetCellImage(oo0O.Rows.Count - 1, 1, this.O_0oOOO_.OO.().Images["info"]);
			oo0O.Rows[oo0O.Rows.Count - 1].UserData = "1";
			oo0O.Rows.Count = oo0O.Rows.Count + 1;
			this.O_0oOOO_.OO.()[oo0O.Rows.Count - 1, 1] = A_0;
			oo0O.Rows[oo0O.Rows.Count - 1].UserData = "2";
			oo0O.Rows[oo0O.Rows.Count - 2].Style = oo0O.Styles["System"];
			oo0O.Rows[oo0O.Rows.Count - 1].Style = oo0O.Styles["System"];
			oo0O.ShowCell(oo0O.Rows.Count - 1, 1);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00092054 File Offset: 0x00090254
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Client_ChangeUserPasswordEventArgs client_ChangeUserPasswordEventArgs = new Client_ChangeUserPasswordEventArgs(this.o.0_0_Ooo.);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "Client_UserChangePassword", new object[]
			{
				client_ChangeUserPasswordEventArgs
			}, true, "项目", false);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0009208E File Offset: 0x0009028E
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			this.o_oO__.0.().Show(this.oOOoo._.(), 0, this.oOOoo._.().Height);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x000920AD File Offset: 0x000902AD
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OO0_O0.o.().PerformClick();
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x000920BC File Offset: 0x000902BC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.O._o_O0O.().Text, "", true) > 0)
			{
				base.SuspendLayout();
				string text = this.O._o_O0O.().Text;
				this.O._o_O0O.().Value = "{!}" + text;
				this.OO0_O0.o.().PerformClick();
				if (Operators.CompareString(this.O._o_O0O.().Text, "", true) > 0)
				{
					this.O._o_O0O.().Value = text;
				}
				base.ResumeLayout();
			}
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00092140 File Offset: 0x00090340
		internal void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.o.0_0_Ooo..MenuItems, "", true) > 0)
			{
				this.O0oO_Oo0oO_.o.().Items.Clear();
				if (this.o.0_0_Ooo..MenuItems.StartsWith("|"))
				{
					this.O0oO_Oo0oO_.o.().Items.Add(this.ooOoo___0.oO0.());
					this.O0oO_Oo0oO_.o.().Items.Add(this.o_oO__.0.());
					this.O0oO_Oo0oO_.o.().Items.Add(this.o.0_o0_00.());
					this.O0oO_Oo0oO_.o.().Items.Add(this.O0_O_0__o._.());
				}
				foreach (string text in this.o.0_0_Ooo..MenuItems.Split(new char[]
				{
					'|'
				}))
				{
					if (Operators.CompareString(text.Trim(), "", true) > 0)
					{
						this.O0oO_Oo0oO_.o.().Items.Add(text).Click += this.o0_oo.o_0o_O0_.;
					}
				}
			}
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00092250 File Offset: 0x00090450
		private void <<EMPTY_NAME>>()
		{
			this.oo_.oOOoO.(0, "");
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0009225E File Offset: 0x0009045E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oo_.oOOoO.(1, ((ToolStripItem)A_0).Text);
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00092274 File Offset: 0x00090474
		private void <<EMPTY_NAME>>(int A_0, string A_1)
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			Oo0O oo0O;
			if (this.ooO.0o00__0.().SelectedIndex == 0)
			{
				oo0O = this.O_0oOOO_.OO.();
			}
			else
			{
				oo0O = this.Oo.Oo00__oooo.();
			}
			if (this.o.0_0_Ooo. != null && this.o.0_0_Ooo. != null)
			{
				if (this.o.0_0_Ooo..Tag is o0o0_oo00Oo)
				{
					text = ((o0o0_oo00Oo)this.o.0_0_Ooo..Tag).oOO_00_0.o.();
				}
				else if (this.o.0_0_Ooo..Tag is ooo0)
				{
					text = ((ooo0)this.o.0_0_Ooo..Tag).oo.o0.();
				}
				else if (this.o.0_0_Ooo..Tag is O_0OOOoO)
				{
					text = ((O_0OOOoO)this.o.0_0_Ooo..Tag).oo_.__OoOO0OO0.();
				}
				else
				{
					text = ((IMBuddy)this.o.0_0_Ooo..Tag).Name;
				}
			}
			DateTime dateTime;
			int num;
			if (oo0O.Row >= 0 && oo0O.O__OO.o..ContainsKey(oo0O.Row))
			{
				DataRow dataRow = oo0O.O__OO.o.[oo0O.Row];
				if (Conversions.ToInteger(dataRow["Type"]) == 1)
				{
					text3 = dataRow["Name"].ToString();
				}
				else
				{
					text3 = this.o.0_0_Ooo..Name;
				}
				dateTime = Conversions.ToDate(dataRow["Time"]);
				text2 = dataRow["Content"].ToString();
				if (Operators.CompareString(text2, "", true) > 0 && text2.StartsWith("\u0002=[") && text2.EndsWith("]="))
				{
					text2 = text2.Substring(3, text2.Length - 5);
					num = 1;
				}
				else if (Operators.CompareString(text2, "", true) > 0 && text2.StartsWith("\u0002=(") && text2.EndsWith(")="))
				{
					text2 = text2.Substring(3, text2.Length - 5);
					num = 2;
				}
				else if (text2.StartsWith("\u0002<") && text2.EndsWith(">\u0002"))
				{
					num = 3;
					text2 = text2.Substring(2, text2.Length - 4);
				}
				else if (text2.StartsWith("\u0002|") && text2.EndsWith("|\u0002"))
				{
					num = 4;
					text2 = text2.Substring(2, text2.Length - 4);
				}
				else if (Operators.CompareString(text2, "", true) > 0 && text2.StartsWith("\u0002=?") && text2.EndsWith("?="))
				{
					num = 5;
					text2 = text2.Substring(3, text2.Length - 5);
				}
				else if (Operators.CompareString(text2, "", true) > 0 && text2.StartsWith("\u0002<?") && text2.EndsWith("?>"))
				{
					num = 6;
					text2 = text2.Substring(3, text2.Length - 5);
				}
				else if (text2.StartsWith("\u0002(") && text2.EndsWith(")\u0002"))
				{
					num = 7;
					text2 = text2.Substring(2, text2.Length - 4);
				}
				else if (text2.StartsWith("\u0002{") && text2.EndsWith("}\u0002"))
				{
					num = 8;
					text2 = text2.Substring(2, text2.Length - 4);
				}
				else if (text2.StartsWith("\u0002[") && text2.EndsWith("]\u0002"))
				{
					num = 9;
					text2 = text2.Substring(2, text2.Length - 4);
				}
				else if (text2.StartsWith("\u0002/") && text2.EndsWith("\\\u0002"))
				{
					num = 10;
					text2 = text2.Substring(2, text2.Length - 4);
				}
				else if (text2.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) || text2.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase) || (text2.StartsWith("www", StringComparison.CurrentCultureIgnoreCase) && text2.Length - text2.Replace(".", "").Length >= 2))
				{
					num = 11;
				}
			}
			if (A_0 == 1)
			{
				CustomMenuClickEventArgs customMenuClickEventArgs = new CustomMenuClickEventArgs(A_1, text, text2, num, text3, dateTime);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "CustomMenuClick", new object[]
				{
					customMenuClickEventArgs
				}, true, "项目", false);
			}
			if (A_0 == 0)
			{
				OpenQQMenuEventArgs openQQMenuEventArgs = new OpenQQMenuEventArgs(text, text2, num, text3, dateTime);
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeShowMenu", new object[]
				{
					openQQMenuEventArgs
				}, true, "项目", false);
			}
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x000926C3 File Offset: 0x000908C3
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.0_o0_00.().Show(this.oO____oooO.0_O.(), 0, this.oO____oooO.0_O.().Height);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x000926E2 File Offset: 0x000908E2
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_.O0ooO.().Checked = !this.O_.O0ooO.().Checked;
			if (this.O_.O0ooO.().Checked)
			{
				this.o.0_o0_00.().Checked = false;
			}
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00092716 File Offset: 0x00090916
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_O.O000o__.().PerformClick();
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00092723 File Offset: 0x00090923
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.0_o0_00.().Checked = !this.o.0_o0_00.().Checked;
			if (this.o.0_o0_00.().Checked)
			{
				this.O_.O0ooO.().Checked = false;
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00092757 File Offset: 0x00090957
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_o._o0___.().ForeColor = Color.CornflowerBlue;
			this.Oo.Oo00__oooo.().ForeColor = Color.CornflowerBlue;
			this.o.o__0o.().ForeColor = Color.CornflowerBlue;
		}

		// Token: 0x040007CF RID: 1999
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040007D0 RID: 2000
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x040007D1 RID: 2001
		[CompilerGenerated]
		private Oo0O <<EMPTY_NAME>>;

		// Token: 0x040007D2 RID: 2002
		[CompilerGenerated]
		private ImageList <<EMPTY_NAME>>;

		// Token: 0x040007D3 RID: 2003
		[CompilerGenerated]
		private OO___OO0O_0 <<EMPTY_NAME>>;

		// Token: 0x040007D4 RID: 2004
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040007D5 RID: 2005
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040007D6 RID: 2006
		[CompilerGenerated]
		private Oo0O <<EMPTY_NAME>>;

		// Token: 0x040007D7 RID: 2007
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040007D8 RID: 2008
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007D9 RID: 2009
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040007DA RID: 2010
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007DB RID: 2011
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007DC RID: 2012
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007DD RID: 2013
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007DE RID: 2014
		[CompilerGenerated]
		private OO___OO0O_0 <<EMPTY_NAME>>;

		// Token: 0x040007DF RID: 2015
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040007E0 RID: 2016
		[CompilerGenerated]
		private o0ooo_0_00oO <<EMPTY_NAME>>;

		// Token: 0x040007E1 RID: 2017
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x040007E2 RID: 2018
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007E3 RID: 2019
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007E4 RID: 2020
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007E5 RID: 2021
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007E6 RID: 2022
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007E7 RID: 2023
		[CompilerGenerated]
		private ToolTip <<EMPTY_NAME>>;

		// Token: 0x040007E8 RID: 2024
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x040007E9 RID: 2025
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040007EA RID: 2026
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040007EB RID: 2027
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x040007EC RID: 2028
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040007ED RID: 2029
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040007EE RID: 2030
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007EF RID: 2031
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x040007F0 RID: 2032
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040007F1 RID: 2033
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040007F2 RID: 2034
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040007F3 RID: 2035
		[CompilerGenerated]
		private o0ooo_0_00oO <<EMPTY_NAME>>;

		// Token: 0x040007F4 RID: 2036
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040007F5 RID: 2037
		[CompilerGenerated]
		private System.Windows.Forms.Timer <<EMPTY_NAME>>;

		// Token: 0x040007F6 RID: 2038
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040007F7 RID: 2039
		[CompilerGenerated]
		private Panel <<EMPTY_NAME>>;

		// Token: 0x040007F8 RID: 2040
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040007F9 RID: 2041
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040007FA RID: 2042
		[CompilerGenerated]
		private Panel <<EMPTY_NAME>>;

		// Token: 0x040007FB RID: 2043
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040007FC RID: 2044
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x040007FD RID: 2045
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x040007FE RID: 2046
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x040007FF RID: 2047
		[CompilerGenerated]
		private Panel <<EMPTY_NAME>>;

		// Token: 0x04000800 RID: 2048
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000801 RID: 2049
		[CompilerGenerated]
		private ToolStripSeparator <<EMPTY_NAME>>;

		// Token: 0x04000802 RID: 2050
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000803 RID: 2051
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000804 RID: 2052
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x04000805 RID: 2053
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000806 RID: 2054
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000807 RID: 2055
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x04000808 RID: 2056
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000809 RID: 2057
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x0400080A RID: 2058
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400080B RID: 2059
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x0400080C RID: 2060
		private IMClient <<EMPTY_NAME>>;

		// Token: 0x0400080D RID: 2061
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x0400080E RID: 2062
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x0400080F RID: 2063
		private OleDbDataAdapter <<EMPTY_NAME>>;

		// Token: 0x04000810 RID: 2064
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000811 RID: 2065
		internal C1TopicLink <<EMPTY_NAME>>;

		// Token: 0x04000812 RID: 2066
		internal O\u3000\u3002\u3002\u3002_\u3002\u3000\u3000 <<EMPTY_NAME>>;

		// Token: 0x04000813 RID: 2067
		internal bool <<EMPTY_NAME>>;

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x06001458 RID: 5208
		private delegate void Oo000(IMBuddy A_0, string A_1, ooOoO A_2);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x0600145C RID: 5212
		public delegate void OO00OoOo_(DataRow A_0);
	}
}
