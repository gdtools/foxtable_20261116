using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200027D RID: 637
	[DesignerGenerated]
	internal class PictureViewer : UserControl
	{
		// Token: 0x06001FAB RID: 8107 RVA: 0x000DAF54 File Offset: 0x000D9154
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.O0.OO0OO. != null)
				{
					this.O0.OO0OO..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x000DAF94 File Offset: 0x000D9194
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O0.OO0OO. = new Container();
			this.PrevRecord = new Label();
			this.Full = new Label();
			this.Clear = new Label();
			this.Open = new Label();
			this.NextRecord = new Label();
			this.Add = new Label();
			this.Delete = new Label();
			this.C1PictureBox1 = new C1PictureBox();
			this.Panel2 = new Panel();
			this.lblMark = new Label();
			this.Label1 = new Label();
			this.C1PictureBox2 = new C1PictureBox();
			this.PictureSplitContainer = new SplitContainer();
			this.FlowLayoutPanel1 = new FlowLayoutPanel();
			this.SplitContainer = new SplitContainer();
			this.FlowLayoutPanel2 = new FlowLayoutPanel();
			this.Manager = new Label();
			this.Stretch = new Label();
			this.SaveAs = new Label();
			this.lblConnect = new Label();
			this.lblUpdate = new Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.O0.OO0OO.);
			((ISupportInitialize)this.C1PictureBox1).BeginInit();
			this.Panel2.SuspendLayout();
			((ISupportInitialize)this.C1PictureBox2).BeginInit();
			this.PictureSplitContainer.Panel1.SuspendLayout();
			this.PictureSplitContainer.Panel2.SuspendLayout();
			this.PictureSplitContainer.SuspendLayout();
			this.SplitContainer.Panel1.SuspendLayout();
			this.SplitContainer.Panel2.SuspendLayout();
			this.SplitContainer.SuspendLayout();
			this.FlowLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.PrevRecord.AutoSize = true;
			this.PrevRecord.Cursor = Cursors.Hand;
			this.PrevRecord.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.PrevRecord.ForeColor = Color.Blue;
			this.PrevRecord.Location = new Point(165, 2);
			this.PrevRecord.Margin = new Padding(0, 0, 1, 0);
			this.PrevRecord.Name = "PrevRecord";
			this.PrevRecord.Size = new Size(41, 12);
			this.PrevRecord.TabIndex = 3;
			this.PrevRecord.Text = "上一条";
			this.PrevRecord.Visible = false;
			this.Full.AutoSize = true;
			this.Full.Cursor = Cursors.Hand;
			this.Full.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.Full.ForeColor = Color.Blue;
			this.Full.Location = new Point(237, 2);
			this.Full.Margin = new Padding(0, 0, 1, 0);
			this.Full.Name = "Full";
			this.Full.Size = new Size(29, 12);
			this.Full.TabIndex = 7;
			this.Full.Text = "全屏";
			this.Clear.AutoSize = true;
			this.Clear.Cursor = Cursors.Hand;
			this.Clear.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.Clear.ForeColor = Color.Blue;
			this.Clear.Location = new Point(93, 2);
			this.Clear.Margin = new Padding(0, 0, 1, 0);
			this.Clear.Name = "Clear";
			this.Clear.Size = new Size(29, 12);
			this.Clear.TabIndex = 6;
			this.Clear.Text = "清除";
			this.Open.AutoSize = true;
			this.Open.Cursor = Cursors.Hand;
			this.Open.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.Open.ForeColor = Color.Blue;
			this.Open.Location = new Point(30, 2);
			this.Open.Margin = new Padding(0, 0, 1, 0);
			this.Open.Name = "Open";
			this.Open.Size = new Size(29, 12);
			this.Open.TabIndex = 4;
			this.Open.Text = "打开";
			this.NextRecord.AutoSize = true;
			this.NextRecord.Cursor = Cursors.Hand;
			this.NextRecord.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.NextRecord.ForeColor = Color.Blue;
			this.NextRecord.Location = new Point(123, 2);
			this.NextRecord.Margin = new Padding(0, 0, 1, 0);
			this.NextRecord.Name = "NextRecord";
			this.NextRecord.Size = new Size(41, 12);
			this.NextRecord.TabIndex = 2;
			this.NextRecord.Text = "下一条";
			this.NextRecord.Visible = false;
			this.Add.AutoSize = true;
			this.Add.Cursor = Cursors.Hand;
			this.Add.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.Add.ForeColor = Color.Blue;
			this.Add.Location = new Point(0, 2);
			this.Add.Margin = new Padding(0, 0, 1, 0);
			this.Add.Name = "Add";
			this.Add.Size = new Size(29, 12);
			this.Add.TabIndex = 1;
			this.Add.Text = "增加";
			this.Delete.AutoSize = true;
			this.Delete.Cursor = Cursors.Hand;
			this.Delete.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.Delete.ForeColor = Color.Blue;
			this.Delete.Location = new Point(63, 2);
			this.Delete.Margin = new Padding(3, 0, 1, 0);
			this.Delete.Name = "Delete";
			this.Delete.Size = new Size(29, 12);
			this.Delete.TabIndex = 0;
			this.Delete.Text = "删除";
			this.C1PictureBox1.Location = new Point(166, 105);
			this.C1PictureBox1.Name = "C1PictureBox1";
			this.C1PictureBox1.Size = new Size(16, 16);
			this.C1PictureBox1.TabIndex = 0;
			this.C1PictureBox1.TabStop = false;
			this.Panel2.AutoScroll = true;
			this.Panel2.AutoSize = true;
			this.Panel2.BackColor = SystemColors.ControlLightLight;
			this.Panel2.Controls.Add(this.lblMark);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.C1PictureBox2);
			this.Panel2.Controls.Add(this.C1PictureBox1);
			this.Panel2.Dock = DockStyle.Fill;
			this.Panel2.Location = new Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new Size(420, 332);
			this.Panel2.TabIndex = 2;
			this.lblMark.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblMark.AutoSize = true;
			this.lblMark.BackColor = Color.Transparent;
			this.lblMark.Font = new Font("宋体", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.lblMark.ForeColor = Color.Red;
			this.lblMark.Location = new Point(403, 0);
			this.lblMark.Name = "lblMark";
			this.lblMark.Size = new Size(14, 9);
			this.lblMark.TabIndex = 3;
			this.lblMark.Text = "●";
			this.lblMark.Visible = false;
			this.Label1.AutoSize = true;
			this.Label1.Enabled = false;
			this.Label1.Location = new Point(329, 260);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(41, 12);
			this.Label1.TabIndex = 2;
			this.Label1.Tag = "DCZLP7b0/P/TOXCc5S0gmTLOoYufE/B5";
			this.Label1.Text = "label1";
			this.Label1.Visible = false;
			this.C1PictureBox2.Anchor = AnchorStyles.None;
			this.C1PictureBox2.Location = new Point(171, 131);
			this.C1PictureBox2.Name = "C1PictureBox2";
			this.C1PictureBox2.Size = new Size(78, 71);
			this.C1PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
			this.C1PictureBox2.TabIndex = 1;
			this.C1PictureBox2.TabStop = false;
			this.PictureSplitContainer.BackColor = SystemColors.ControlDarkDark;
			this.PictureSplitContainer.Dock = DockStyle.Fill;
			this.PictureSplitContainer.FixedPanel = FixedPanel.Panel2;
			this.PictureSplitContainer.Location = new Point(0, 0);
			this.PictureSplitContainer.Name = "PictureSplitContainer";
			this.PictureSplitContainer.Orientation = Orientation.Horizontal;
			this.PictureSplitContainer.Panel1.Controls.Add(this.Panel2);
			this.PictureSplitContainer.Panel2.AutoScroll = true;
			this.PictureSplitContainer.Panel2.BackColor = SystemColors.ControlLightLight;
			this.PictureSplitContainer.Panel2.Controls.Add(this.FlowLayoutPanel1);
			this.PictureSplitContainer.Panel2Collapsed = true;
			this.PictureSplitContainer.Panel2MinSize = 75;
			this.PictureSplitContainer.Size = new Size(420, 332);
			this.PictureSplitContainer.SplitterDistance = 249;
			this.PictureSplitContainer.TabIndex = 3;
			this.FlowLayoutPanel1.AutoSize = true;
			this.FlowLayoutPanel1.Location = new Point(0, 0);
			this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
			this.FlowLayoutPanel1.Size = new Size(249, 41);
			this.FlowLayoutPanel1.TabIndex = 0;
			this.SplitContainer.Dock = DockStyle.Fill;
			this.SplitContainer.FixedPanel = FixedPanel.Panel2;
			this.SplitContainer.Location = new Point(0, 0);
			this.SplitContainer.Name = "SplitContainer";
			this.SplitContainer.Orientation = Orientation.Horizontal;
			this.SplitContainer.Panel1.Controls.Add(this.PictureSplitContainer);
			this.SplitContainer.Panel1MinSize = 15;
			this.SplitContainer.Panel2.Controls.Add(this.FlowLayoutPanel2);
			this.SplitContainer.Panel2MinSize = 15;
			this.SplitContainer.Size = new Size(420, 354);
			this.SplitContainer.SplitterDistance = 332;
			this.SplitContainer.TabIndex = 4;
			this.FlowLayoutPanel2.Controls.Add(this.Add);
			this.FlowLayoutPanel2.Controls.Add(this.Open);
			this.FlowLayoutPanel2.Controls.Add(this.Delete);
			this.FlowLayoutPanel2.Controls.Add(this.Clear);
			this.FlowLayoutPanel2.Controls.Add(this.NextRecord);
			this.FlowLayoutPanel2.Controls.Add(this.PrevRecord);
			this.FlowLayoutPanel2.Controls.Add(this.Manager);
			this.FlowLayoutPanel2.Controls.Add(this.Full);
			this.FlowLayoutPanel2.Controls.Add(this.Stretch);
			this.FlowLayoutPanel2.Controls.Add(this.SaveAs);
			this.FlowLayoutPanel2.Controls.Add(this.lblConnect);
			this.FlowLayoutPanel2.Controls.Add(this.lblUpdate);
			this.FlowLayoutPanel2.Dock = DockStyle.Fill;
			this.FlowLayoutPanel2.Location = new Point(0, 0);
			this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
			this.FlowLayoutPanel2.Padding = new Padding(0, 2, 0, 0);
			this.FlowLayoutPanel2.Size = new Size(420, 18);
			this.FlowLayoutPanel2.TabIndex = 10;
			this.Manager.AutoSize = true;
			this.Manager.Cursor = Cursors.Hand;
			this.Manager.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.Manager.ForeColor = Color.Blue;
			this.Manager.Location = new Point(207, 2);
			this.Manager.Margin = new Padding(0, 0, 1, 0);
			this.Manager.Name = "Manager";
			this.Manager.Size = new Size(29, 12);
			this.Manager.TabIndex = 8;
			this.Manager.Text = "管理";
			this.Manager.Visible = false;
			this.Stretch.AutoSize = true;
			this.Stretch.Cursor = Cursors.Hand;
			this.Stretch.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.Stretch.ForeColor = Color.Blue;
			this.Stretch.Location = new Point(267, 2);
			this.Stretch.Margin = new Padding(0, 0, 1, 0);
			this.Stretch.Name = "Stretch";
			this.Stretch.Size = new Size(29, 12);
			this.Stretch.TabIndex = 9;
			this.Stretch.Text = "缩放";
			this.SaveAs.AutoSize = true;
			this.SaveAs.Cursor = Cursors.Hand;
			this.SaveAs.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.SaveAs.ForeColor = Color.Blue;
			this.SaveAs.Location = new Point(297, 2);
			this.SaveAs.Margin = new Padding(0, 0, 1, 0);
			this.SaveAs.Name = "SaveAs";
			this.SaveAs.Size = new Size(29, 12);
			this.SaveAs.TabIndex = 10;
			this.SaveAs.Text = "另存";
			this.lblConnect.AutoSize = true;
			this.lblConnect.Cursor = Cursors.Hand;
			this.lblConnect.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.lblConnect.ForeColor = Color.Blue;
			this.lblConnect.Location = new Point(327, 2);
			this.lblConnect.Margin = new Padding(0, 0, 1, 0);
			this.lblConnect.Name = "lblConnect";
			this.lblConnect.Size = new Size(29, 12);
			this.lblConnect.TabIndex = 11;
			this.lblConnect.Text = "重连";
			this.lblUpdate.AutoSize = true;
			this.lblUpdate.Cursor = Cursors.Hand;
			this.lblUpdate.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.lblUpdate.ForeColor = Color.Blue;
			this.lblUpdate.Location = new Point(357, 2);
			this.lblUpdate.Margin = new Padding(0, 0, 1, 0);
			this.lblUpdate.Name = "lblUpdate";
			this.lblUpdate.Size = new Size(29, 12);
			this.lblUpdate.TabIndex = 12;
			this.lblUpdate.Text = "更新";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.AutoScroll = true;
			base.Controls.Add(this.SplitContainer);
			base.Name = "Oo0.O.O.";
			base.Size = new Size(420, 354);
			base.Tag = "";
			((ISupportInitialize)this.C1PictureBox1).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((ISupportInitialize)this.C1PictureBox2).EndInit();
			this.PictureSplitContainer.Panel1.ResumeLayout(false);
			this.PictureSplitContainer.Panel1.PerformLayout();
			this.PictureSplitContainer.Panel2.ResumeLayout(false);
			this.PictureSplitContainer.Panel2.PerformLayout();
			this.PictureSplitContainer.ResumeLayout(false);
			this.SplitContainer.Panel1.ResumeLayout(false);
			this.SplitContainer.Panel2.ResumeLayout(false);
			this.SplitContainer.ResumeLayout(false);
			this.FlowLayoutPanel2.ResumeLayout(false);
			this.FlowLayoutPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x000DC185 File Offset: 0x000DA385
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x000DC18D File Offset: 0x000DA38D
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x000DC196 File Offset: 0x000DA396
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x000DC1A0 File Offset: 0x000DA3A0
		internal virtual Label PrevRecord
		{
			[CompilerGenerated]
			get
			{
				return this.O0.OO0OO.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OoOO.Ooo__.);
				Label o0.OO0OO. = this.O0.OO0OO.;
				if (o0.OO0OO. != null)
				{
					o0.OO0OO..Click -= value2;
				}
				this.O0.OO0OO. = value;
				o0.OO0OO. = this.O0.OO0OO.;
				if (o0.OO0OO. != null)
				{
					o0.OO0OO..Click += value2;
				}
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x000DC1E3 File Offset: 0x000DA3E3
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x000DC1EC File Offset: 0x000DA3EC
		internal virtual Label NextRecord
		{
			[CompilerGenerated]
			get
			{
				return this.o.o0o00Oo_.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.oOOO0.0o_O.);
				Label label = this.o.o0o00Oo_.;
				if (label != null)
				{
					label.Click -= value2;
				}
				this.o.o0o00Oo_. = value;
				label = this.o.o0o00Oo_.;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x000DC22F File Offset: 0x000DA42F
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x000DC238 File Offset: 0x000DA438
		internal virtual Label Add
		{
			[CompilerGenerated]
			get
			{
				return this.oo__oOo0___O.O.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.O0_oooo0OO.Oo.);
				Label label = this.oo__oOo0___O.O.;
				if (label != null)
				{
					label.Click -= value2;
				}
				this.oo__oOo0___O.O. = value;
				label = this.oo__oOo0___O.O.;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x000DC27B File Offset: 0x000DA47B
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x000DC284 File Offset: 0x000DA484
		internal virtual Label Delete
		{
			[CompilerGenerated]
			get
			{
				return this.O.0OoOo_OO.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.o0OO00oo_.o_.);
				Label o.0OoOo_OO. = this.O.0OoOo_OO.;
				if (o.0OoOo_OO. != null)
				{
					o.0OoOo_OO..Click -= value2;
				}
				this.O.0OoOo_OO. = value;
				o.0OoOo_OO. = this.O.0OoOo_OO.;
				if (o.0OoOo_OO. != null)
				{
					o.0OoOo_OO..Click += value2;
				}
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x000DC2C7 File Offset: 0x000DA4C7
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x000DC2D0 File Offset: 0x000DA4D0
		internal virtual Label Open
		{
			[CompilerGenerated]
			get
			{
				return this.O_0.0oOO0.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.oo0_.o___.);
				Label o_0.0oOO0. = this.O_0.0oOO0.;
				if (o_0.0oOO0. != null)
				{
					o_0.0oOO0..Click -= value2;
				}
				this.O_0.0oOO0. = value;
				o_0.0oOO0. = this.O_0.0oOO0.;
				if (o_0.0oOO0. != null)
				{
					o_0.0oOO0..Click += value2;
				}
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x000DC313 File Offset: 0x000DA513
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x000DC31B File Offset: 0x000DA51B
		internal virtual SplitContainer PictureSplitContainer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x000DC324 File Offset: 0x000DA524
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x000DC32C File Offset: 0x000DA52C
		internal virtual FlowLayoutPanel FlowLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x000DC335 File Offset: 0x000DA535
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x000DC340 File Offset: 0x000DA540
		internal virtual C1PictureBox C1PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this.o00_.0_ooO_00.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.O0o0o__oo._o.);
				MouseEventHandler value3 = new MouseEventHandler(this.o.o0o0.);
				MouseEventHandler value4 = new MouseEventHandler(this.OoOo.O00.);
				EventHandler value5 = new EventHandler(this.o.o0o0.);
				C1PictureBox c1PictureBox = this.o00_.0_ooO_00.;
				if (c1PictureBox != null)
				{
					c1PictureBox.MouseDown -= value2;
					c1PictureBox.MouseMove -= value3;
					c1PictureBox.MouseUp -= value4;
					c1PictureBox.DoubleClick -= value5;
				}
				this.o00_.0_ooO_00. = value;
				c1PictureBox = this.o00_.0_ooO_00.;
				if (c1PictureBox != null)
				{
					c1PictureBox.MouseDown += value2;
					c1PictureBox.MouseMove += value3;
					c1PictureBox.MouseUp += value4;
					c1PictureBox.DoubleClick += value5;
				}
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x000DC3E0 File Offset: 0x000DA5E0
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x000DC3E8 File Offset: 0x000DA5E8
		internal virtual Label Clear
		{
			[CompilerGenerated]
			get
			{
				return this.oOoo.0o.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Oo.00Oo_0Oo0O0.);
				Label label = this.oOoo.0o.;
				if (label != null)
				{
					label.Click -= value2;
				}
				this.oOoo.0o. = value;
				label = this.oOoo.0o.;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x000DC42B File Offset: 0x000DA62B
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x000DC434 File Offset: 0x000DA634
		internal virtual Label Full
		{
			[CompilerGenerated]
			get
			{
				return this.OO.__O__00O.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.O0.O__Ooo.);
				Label oo.__O__00O. = this.OO.__O__00O.;
				if (oo.__O__00O. != null)
				{
					oo.__O__00O..Click -= value2;
				}
				this.OO.__O__00O. = value;
				oo.__O__00O. = this.OO.__O__00O.;
				if (oo.__O__00O. != null)
				{
					oo.__O__00O..Click += value2;
				}
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x000DC477 File Offset: 0x000DA677
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x000DC47F File Offset: 0x000DA67F
		internal virtual SplitContainer SplitContainer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x000DC488 File Offset: 0x000DA688
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x000DC490 File Offset: 0x000DA690
		internal virtual Label Manager
		{
			[CompilerGenerated]
			get
			{
				return this.oO_O00.O0.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Oo0._OO_O_O0.);
				Label label = this.oO_O00.O0.;
				if (label != null)
				{
					label.Click -= value2;
				}
				this.oO_O00.O0. = value;
				label = this.oO_O00.O0.;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x000DC4D3 File Offset: 0x000DA6D3
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x000DC4DC File Offset: 0x000DA6DC
		internal virtual Label Stretch
		{
			[CompilerGenerated]
			get
			{
				return this.OooO_0o._0_.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.o__.000___OO.);
				Label oooO_0o._0_. = this.OooO_0o._0_.;
				if (oooO_0o._0_. != null)
				{
					oooO_0o._0_..Click -= value2;
				}
				this.OooO_0o._0_. = value;
				oooO_0o._0_. = this.OooO_0o._0_.;
				if (oooO_0o._0_. != null)
				{
					oooO_0o._0_..Click += value2;
				}
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x000DC51F File Offset: 0x000DA71F
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x000DC527 File Offset: 0x000DA727
		internal virtual FlowLayoutPanel FlowLayoutPanel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x000DC530 File Offset: 0x000DA730
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x000DC538 File Offset: 0x000DA738
		internal virtual Label SaveAs
		{
			[CompilerGenerated]
			get
			{
				return this.oo0_.0.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ooo0O0O.O_.);
				Label label = this.oo0_.0.;
				if (label != null)
				{
					label.Click -= value2;
				}
				this.oo0_.0. = value;
				label = this.oo0_.0.;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x000DC57B File Offset: 0x000DA77B
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x000DC584 File Offset: 0x000DA784
		internal virtual System.Windows.Forms.Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this.O0.OO0OO.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.O.0o__0_.);
				System.Windows.Forms.Timer o0.OO0OO. = this.O0.OO0OO.;
				if (o0.OO0OO. != null)
				{
					o0.OO0OO..Tick -= value2;
				}
				this.O0.OO0OO. = value;
				o0.OO0OO. = this.O0.OO0OO.;
				if (o0.OO0OO. != null)
				{
					o0.OO0OO..Tick += value2;
				}
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x000DC5C7 File Offset: 0x000DA7C7
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x000DC5D0 File Offset: 0x000DA7D0
		internal virtual Label lblConnect
		{
			[CompilerGenerated]
			get
			{
				return this.o_.0O0_.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.O.OOOOOo.);
				Label label = this.o_.0O0_.;
				if (label != null)
				{
					label.Click -= value2;
				}
				this.o_.0O0_. = value;
				label = this.o_.0O0_.;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x000DC613 File Offset: 0x000DA813
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x000DC61C File Offset: 0x000DA81C
		internal virtual Label lblUpdate
		{
			[CompilerGenerated]
			get
			{
				return this.OOOo._OoO_.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.O_.oO.);
				Label oooo._OoO_. = this.OOOo._OoO_.;
				if (oooo._OoO_. != null)
				{
					oooo._OoO_..Click -= value2;
				}
				this.OOOo._OoO_. = value;
				oooo._OoO_. = this.OOOo._OoO_.;
				if (oooo._OoO_. != null)
				{
					oooo._OoO_..Click += value2;
				}
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x000DC65F File Offset: 0x000DA85F
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x000DC668 File Offset: 0x000DA868
		internal virtual C1PictureBox C1PictureBox2
		{
			[CompilerGenerated]
			get
			{
				return this.O.oOOOO0.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.o.o0o0.);
				C1PictureBox o.oOOOO0. = this.O.oOOOO0.;
				if (o.oOOOO0. != null)
				{
					o.oOOOO0..DoubleClick -= value2;
				}
				this.O.oOOOO0. = value;
				o.oOOOO0. = this.O.oOOOO0.;
				if (o.oOOOO0. != null)
				{
					o.oOOOO0..DoubleClick += value2;
				}
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x000DC6AB File Offset: 0x000DA8AB
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x000DC6B3 File Offset: 0x000DA8B3
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x000DC6BC File Offset: 0x000DA8BC
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x000DC6C4 File Offset: 0x000DA8C4
		internal virtual Label lblMark
		{
			[CompilerGenerated]
			get
			{
				return this.Oo0Oo0.OO0_.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.oo._O_o00oO0Oo.);
				Label oo0Oo0.OO0_. = this.Oo0Oo0.OO0_.;
				if (oo0Oo0.OO0_. != null)
				{
					oo0Oo0.OO0_..ForeColorChanged -= value2;
				}
				this.Oo0Oo0.OO0_. = value;
				oo0Oo0.OO0_. = this.Oo0Oo0.OO0_.;
				if (oo0Oo0.OO0_. != null)
				{
					oo0Oo0.OO0_..ForeColorChanged += value2;
				}
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x000DC707 File Offset: 0x000DA907
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x000DC710 File Offset: 0x000DA910
		private virtual FTPClient _FTPClient
		{
			[CompilerGenerated]
			get
			{
				return this.O.0o0o0o_.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				FTPClient.oO_o_0OOo__0 a_ = new FTPClient.oO_o_0OOo__0(this.OO0.___.);
				FTPClient.O__0O000__Oo a_2 = new FTPClient.O__0O000__Oo(this.oOo.o0Oo_.);
				FTPClient.Oo__ a_3 = new FTPClient.Oo__(this.oOo.o0Oo_.);
				FTPClient.OooO_O0O_0_O a_4 = new FTPClient.OooO_O0O_0_O(this.oOo.o0Oo_.);
				FTPClient o.0o0o0o_. = this.O.0o0o0o_.;
				if (o.0o0o0o_. != null)
				{
					o.0o0o0o_..DownloadCompleted -= a_;
					o.0o0o0o_..DownloadError -= a_2;
					o.0o0o0o_..FileCompared -= a_3;
					o.0o0o0o_..ServerConnected -= a_4;
				}
				this.O.0o0o0o_. = value;
				o.0o0o0o_. = this.O.0o0o0o_.;
				if (o.0o0o0o_. != null)
				{
					o.0o0o0o_..DownloadCompleted += a_;
					o.0o0o0o_..DownloadError += a_2;
					o.0o0o0o_..FileCompared += a_3;
					o.0o0o0o_..ServerConnected += a_4;
				}
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x000DC7B0 File Offset: 0x000DA9B0
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x000DC7B8 File Offset: 0x000DA9B8
		private virtual Binding bdm
		{
			[CompilerGenerated]
			get
			{
				return this.o00_.0_ooO_00.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ConvertEventHandler value2 = new ConvertEventHandler(this.oOo.o0Oo_.);
				Binding binding = this.o00_.0_ooO_00.;
				if (binding != null)
				{
					binding.Parse -= value2;
				}
				this.o00_.0_ooO_00. = value;
				binding = this.o00_.0_ooO_00.;
				if (binding != null)
				{
					binding.Parse += value2;
				}
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x000DC7FB File Offset: 0x000DA9FB
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x000DC804 File Offset: 0x000DAA04
		private virtual PictureBox Box
		{
			[CompilerGenerated]
			get
			{
				return this.o00_.0_ooO_00.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				AsyncCompletedEventHandler value2 = new AsyncCompletedEventHandler(this.O__o.0o.);
				PictureBox pictureBox = this.o00_.0_ooO_00.;
				if (pictureBox != null)
				{
					pictureBox.LoadCompleted -= value2;
				}
				this.o00_.0_ooO_00. = value;
				pictureBox = this.o00_.0_ooO_00.;
				if (pictureBox != null)
				{
					pictureBox.LoadCompleted += value2;
				}
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06001FDF RID: 8159 RVA: 0x000DC848 File Offset: 0x000DAA48
		// (remove) Token: 0x06001FE0 RID: 8160 RVA: 0x000DC880 File Offset: 0x000DAA80
		public event PictureViewer.O_O0_0_Ooo SelectedItemChanged
		{
			[CompilerGenerated]
			add
			{
				PictureViewer.O_O0_0_Ooo o_O0_0_Ooo = this.O.0O_o_.;
				PictureViewer.O_O0_0_Ooo o_O0_0_Ooo2;
				do
				{
					o_O0_0_Ooo2 = o_O0_0_Ooo;
					PictureViewer.O_O0_0_Ooo value2 = (PictureViewer.O_O0_0_Ooo)Delegate.Combine(o_O0_0_Ooo2, value);
					o_O0_0_Ooo = Interlocked.CompareExchange<PictureViewer.O_O0_0_Ooo>(ref this.O.0O_o_., value2, o_O0_0_Ooo2);
				}
				while (o_O0_0_Ooo != o_O0_0_Ooo2);
			}
			[CompilerGenerated]
			remove
			{
				PictureViewer.O_O0_0_Ooo o_O0_0_Ooo = this.O.0O_o_.;
				PictureViewer.O_O0_0_Ooo o_O0_0_Ooo2;
				do
				{
					o_O0_0_Ooo2 = o_O0_0_Ooo;
					PictureViewer.O_O0_0_Ooo value2 = (PictureViewer.O_O0_0_Ooo)Delegate.Remove(o_O0_0_Ooo2, value);
					o_O0_0_Ooo = Interlocked.CompareExchange<PictureViewer.O_O0_0_Ooo>(ref this.O.0O_o_., value2, o_O0_0_Ooo2);
				}
				while (o_O0_0_Ooo != o_O0_0_Ooo2);
			}
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x000DC8B8 File Offset: 0x000DAAB8
		internal PictureViewer()
		{
			base.ParentChanged += this.ooOo0o_O.O.;
			this.O0.OO0OO. = new List<string>();
			this.oO0O.o_O_0OO0. = true;
			this.OOo0_00_.oOOo0. = true;
			this.o__O0oO._. = true;
			this.Box = new PictureBox();
			this.O00_.0_ooO_o.();
			this.SizeMode = PictureBoxSizeMode.Zoom;
			this.Label1.Tag = O00.DecryptText(this.Label1.Tag.ToString(), "me", "me");
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x000DC93F File Offset: 0x000DAB3F
		private Binding bd
		{
			get
			{
				if (base.DataBindings.Count > 0)
				{
					this.bdm = base.DataBindings[0];
				}
				else
				{
					this.bdm = null;
				}
				return this.bdm;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x000DC970 File Offset: 0x000DAB70
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x000DC978 File Offset: 0x000DAB78
		internal FTPClient FTPclient
		{
			get
			{
				return this._FTPClient;
			}
			set
			{
				if (value != null)
				{
					this._FTPClient = new FTPClient();
					this._FTPClient.Host = value.Host;
					this._FTPClient.Account = value.Account;
					this._FTPClient.Password = value.Password;
					this._FTPClient.Port = value.Port;
					this._FTPClient.UTF8 = value.UTF8;
					this._FTPClient.RootDir = value.RootDir;
				}
				else
				{
					this._FTPClient = null;
				}
				if (base.Parent != null)
				{
					try
					{
						foreach (object obj in this.FlowLayoutPanel1.Controls)
						{
							((PictureViewer.OOooOoooo)obj).set_Canceled(false);
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
					if (this._FTPClient == null)
					{
						this.lblConnect.Visible = false;
						this.lblUpdate.Visible = false;
					}
					else
					{
						this.lblConnect.Visible = true;
						this.lblUpdate.Visible = true;
						if (!this.AutoDownLoad)
						{
							this.lblUpdate.Visible = false;
						}
					}
				}
				this.Manager.Visible = (value != null);
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x000DCABC File Offset: 0x000DACBC
		private BindingManagerBase bm
		{
			get
			{
				BindingManagerBase result;
				if (base.DataBindings.Count > 0)
				{
					result = base.DataBindings[0].BindingManagerBase;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x000DCAEE File Offset: 0x000DACEE
		// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x000DCAF6 File Offset: 0x000DACF6
		internal bool AutoDownLoad
		{
			get
			{
				return this.OOo0_00_.oOOo0.;
			}
			set
			{
				this.OOo0_00_.oOOo0. = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x000DCAFF File Offset: 0x000DACFF
		// (set) Token: 0x06001FE9 RID: 8169 RVA: 0x000DCB07 File Offset: 0x000DAD07
		internal bool AutoUpdate
		{
			get
			{
				return this.o__O0oO._.;
			}
			set
			{
				this.o__O0oO._. = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x000DCB10 File Offset: 0x000DAD10
		// (set) Token: 0x06001FEB RID: 8171 RVA: 0x000DCB18 File Offset: 0x000DAD18
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.O0.OO0OO.;
			}
			set
			{
				this.O0.OO0OO. = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x000DCB21 File Offset: 0x000DAD21
		// (set) Token: 0x06001FED RID: 8173 RVA: 0x000DCB30 File Offset: 0x000DAD30
		public PictureBoxSizeMode SizeMode
		{
			get
			{
				return this.C1PictureBox1.SizeMode;
			}
			set
			{
				this.C1PictureBox1.SizeMode = value;
				switch (value)
				{
				case PictureBoxSizeMode.Normal:
				case PictureBoxSizeMode.StretchImage:
				case PictureBoxSizeMode.CenterImage:
				case PictureBoxSizeMode.Zoom:
					this.C1PictureBox1.Dock = DockStyle.Fill;
					return;
				case PictureBoxSizeMode.AutoSize:
					this.C1PictureBox1.Dock = DockStyle.None;
					this.o.o0o0.();
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x000DCB85 File Offset: 0x000DAD85
		// (set) Token: 0x06001FEF RID: 8175 RVA: 0x000DCB90 File Offset: 0x000DAD90
		public string ImageFiles
		{
			get
			{
				return this.o_O0.O0O.;
			}
			set
			{
				if (this.lblMark.Parent != null)
				{
					this.lblMark.Parent.Controls.Remove(this.lblMark);
				}
				if (!this.C1PictureBox1.Visible)
				{
					this.C1PictureBox1.Visible = true;
				}
				if (this.C1PictureBox2.Visible)
				{
					this.C1PictureBox2.Visible = false;
				}
				if (Operators.CompareString(this.o_O0.O0O., value, true) != 0)
				{
					this.o_O0.O0O. = value;
					this.O0.OO0OO..Clear();
					if (Operators.CompareString(value, "", true) > 0)
					{
						this.O0.OO0OO..AddRange(value.Split(new char[]
						{
							'\n',
							'\r'
						}, StringSplitOptions.RemoveEmptyEntries));
					}
					if (this.C1PictureBox1.Image != null)
					{
						this.C1PictureBox1.Image.Dispose();
						this.C1PictureBox1.Image = null;
					}
					this.C1PictureBox1.Tag = null;
					if (this.FTPclient != null && this.FTPclient.AsyncState == Oo_0.Oo_o_o.__oo.)
					{
						this.FTPclient.o_0_.__0OO.();
					}
					try
					{
						foreach (object obj in this.FlowLayoutPanel1.Controls)
						{
							PictureViewer.OOooOoooo ooooOoooo = (PictureViewer.OOooOoooo)obj;
							if (ooooOoooo.get_Completed() && ooooOoooo.Image != null && ooooOoooo.Image != O_O0OO.o0_OO.000.() && ooooOoooo.Image != ooooOoooo.ErrorImage)
							{
								ooooOoooo.Image.Dispose();
								ooooOoooo.Image = null;
							}
							ooooOoooo.Dispose();
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
					this.FlowLayoutPanel1.Controls.Clear();
					if (this.FTPclient == null || this.AutoDownLoad)
					{
						this.PictureSplitContainer.Panel2Collapsed = (this.O0.OO0OO..Count <= 1);
					}
					else
					{
						this.PictureSplitContainer.Panel2Collapsed = false;
					}
					this.O_O0.OO. = 0;
					this.O0O.o__0O. = true;
					GC.Collect();
				}
			}
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x000DCD90 File Offset: 0x000DAF90
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num7;
			object obj7;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (base.FindForm() != null && (this.FTPclient == null || !this.FTPclient.O0.o0.))
				{
					goto IL_88;
				}
				IL_26:
				num2 = 3;
				Application.Idle -= this.oo_o000o_oo0.o.;
				IL_39:
				num2 = 4;
				NetworkChange.NetworkAvailabilityChanged -= this.O__o.0o.;
				IL_4C:
				num2 = 5;
				NetworkChange.NetworkAddressChanged -= this.oo_o___._O0.;
				IL_5F:
				num2 = 6;
				if (this.FTPclient == null)
				{
					goto IL_862;
				}
				IL_6C:
				num2 = 7;
				this.FTPclient.Connected = false;
				IL_7A:
				num2 = 8;
				this.FTPclient = null;
				goto IL_862;
				IL_88:
				num2 = 10;
				IEnumerator enumerator = this.FlowLayoutPanel1.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					PictureViewer.OOooOoooo ooooOoooo = (PictureViewer.OOooOoooo)obj;
					IL_AE:
					num2 = 11;
					if (ooooOoooo.Controls.Count > 0)
					{
						IL_C3:
						num2 = 12;
						if (this.C1PictureBox1.Tag == ooooOoooo)
						{
							IL_D5:
							num2 = 13;
							if (ooooOoooo.Controls[0].ForeColor != Color.Blue)
							{
								IL_F6:
								num2 = 14;
								ooooOoooo.Controls[0].ForeColor = Color.Blue;
							}
						}
						else
						{
							IL_112:
							num2 = 16;
							if (ooooOoooo.Controls[0].ForeColor != SystemColors.ControlText)
							{
								IL_133:
								num2 = 17;
								ooooOoooo.Controls[0].ForeColor = SystemColors.ControlText;
							}
						}
					}
					IL_14D:
					num2 = 18;
				}
				IL_15B:
				num2 = 19;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_171:
				num2 = 20;
				if (!base.CanFocus)
				{
					goto IL_862;
				}
				IL_17F:
				num2 = 22;
				if (this.O_O0.OO. > this.O0.OO0OO..Count - 1)
				{
					goto IL_1EE;
				}
				IL_197:
				num2 = 23;
				if (this.FTPclient != null)
				{
					goto IL_1BE;
				}
				IL_1A2:
				num2 = 24;
				this.o_.0o_0o_o.(this.O0.OO0OO.[this.O_O0.OO.]);
				goto IL_1D8;
				IL_1BE:
				num2 = 26;
				this.o.o0o0.(this.O0.OO0OO.[this.O_O0.OO.]);
				IL_1D8:
				num2 = 27;
				this.O_O0.OO.++;
				goto IL_862;
				IL_1EE:
				num2 = 30;
				if (this.C1PictureBox1.Tag != null || this.FTPclient != null)
				{
					goto IL_2CB;
				}
				IL_20C:
				num2 = 31;
				IEnumerator enumerator2 = this.FlowLayoutPanel1.Controls.GetEnumerator();
				int num3;
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					PictureViewer.OOooOoooo ooooOoooo2 = (PictureViewer.OOooOoooo)obj2;
					IL_231:
					num2 = 32;
					if (!ooooOoooo2.get_Canceled())
					{
						IL_23D:
						num2 = 33;
						num3 = 1;
						break;
					}
					IL_245:
					num2 = 35;
				}
				IL_251:
				num2 = 36;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_269:
				num2 = 37;
				if (num3 != 0)
				{
					goto IL_2CB;
				}
				IL_270:
				num2 = 38;
				IEnumerator enumerator3 = this.FlowLayoutPanel1.Controls.GetEnumerator();
				IL_2AA:
				if (enumerator3.MoveNext())
				{
					PictureViewer.OOooOoooo a_ = (PictureViewer.OOooOoooo)enumerator3.Current;
					IL_295:
					num2 = 39;
					this.O__O.o_ooo0Oo_.(a_, new EventArgs());
				}
				IL_2B3:
				num2 = 42;
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
				IL_2CB:
				num2 = 43;
				if (this.o_o_O_Oo.OoOo.)
				{
					goto IL_42F;
				}
				IL_2D9:
				num2 = 44;
				IEnumerator enumerator4 = this.FlowLayoutPanel1.Controls.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					object obj3 = enumerator4.Current;
					PictureViewer.OOooOoooo ooooOoooo3 = (PictureViewer.OOooOoooo)obj3;
					IL_301:
					num2 = 45;
					string text = ooooOoooo3.Tag.ToString();
					IL_312:
					num2 = 46;
					if (this.FTPclient != null)
					{
						IL_31D:
						num2 = 47;
						text = OO_00oOO.ProjectPath + "RemoteFiles\\" + text.Replace("/", "\\").Trim(new char[]
						{
							'\\'
						});
					}
					IL_352:
					num2 = 48;
					if (ooooOoooo3.get_DownLoadState() == PictureViewer.o0o0.DownLoadByOther)
					{
						IL_35F:
						num2 = 49;
						if (OO_00oOO.FileSys.FileExists(text))
						{
							IL_370:
							num2 = 50;
							ooooOoooo3.set_DownLoadState(PictureViewer.o0o0.DownLoaded);
							IL_37B:
							num2 = 51;
							ooooOoooo3.set_Canceled(false);
							IL_386:
							num2 = 52;
							ooooOoooo3.set_Completed(false);
							IL_391:
							num2 = 53;
							ooooOoooo3.set_Compared(true);
							break;
						}
					}
					IL_39E:
					num2 = 55;
					if (!ooooOoooo3.get_Completed() && !ooooOoooo3.get_Canceled() && ooooOoooo3.Tag != null)
					{
						IL_3BC:
						num2 = 56;
						if (OO_00oOO.FileSys.FileExists(text))
						{
							IL_3CD:
							num2 = 57;
							ooooOoooo3.Controls.Clear();
							IL_3DC:
							num2 = 58;
							this.o_o_O_Oo.OoOo. = true;
							IL_3E6:
							num2 = 59;
							this.Box.Tag = ooooOoooo3;
							IL_3F6:
							num2 = 60;
							this.Box.LoadAsync(text);
							break;
						}
					}
					IL_408:
					num2 = 62;
				}
				IL_417:
				num2 = 63;
				if (enumerator4 is IDisposable)
				{
					(enumerator4 as IDisposable).Dispose();
				}
				IL_42F:
				num2 = 64;
				if (base.DataBindings.Count <= 0 || Operators.CompareString(this.Label1.Text, "", true) <= 0)
				{
					goto IL_4E6;
				}
				IL_45F:
				num2 = 65;
				this.Label1.Text = "";
				IL_472:
				num2 = 66;
				int num4 = Oo00.ooO.ooo.();
				IL_47C:
				num2 = 67;
				if (num4 <= 7)
				{
					goto IL_4E6;
				}
				IL_484:
				num2 = 68;
				OleDbCommand oleDbCommand = new OleDbCommand(this.Label1.Tag.ToString() + " [" + ooO0__OO.oo._O.() + "]", O_O0OO.OoO.0OO__0ooo.());
				IL_4B7:
				num2 = 69;
				O_O0OO.OoO.0OO__0ooo.().Open();
				IL_4C4:
				num2 = 70;
				if (O_O0OO.O_oO_o0O.o__.)
				{
					goto IL_4D9;
				}
				IL_4CE:
				num2 = 71;
				oleDbCommand.ExecuteNonQuery();
				IL_4D9:
				num2 = 72;
				O_O0OO.OoO.0OO__0ooo.().Close();
				IL_4E6:
				num2 = 73;
				if (this.o0._0OO. || !this.AutoDownLoad || this.FTPclient == null || this.FTPclient.AsyncState != Oo_0.OOoo0_OO__._o. || this.o.O__00.)
				{
					goto IL_862;
				}
				IL_525:
				num2 = 74;
				int num5 = 0;
				IL_52B:
				num2 = 75;
				IEnumerator enumerator5 = this.FlowLayoutPanel1.Controls.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					object obj4 = enumerator5.Current;
					PictureViewer.OOooOoooo ooooOoooo4 = (PictureViewer.OOooOoooo)obj4;
					IL_550:
					num2 = 76;
					if (ooooOoooo4.get_DownLoadState() == PictureViewer.o0o0.DownLoading)
					{
						IL_55D:
						num2 = 77;
						num5++;
						break;
					}
					IL_568:
					num2 = 79;
				}
				IL_574:
				num2 = 80;
				if (enumerator5 is IDisposable)
				{
					(enumerator5 as IDisposable).Dispose();
				}
				IL_58C:
				num2 = 81;
				if (num5 != 0)
				{
					goto IL_862;
				}
				IL_596:
				num2 = 82;
				IEnumerator enumerator6 = this.FlowLayoutPanel1.Controls.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					object obj5 = enumerator6.Current;
					PictureViewer.OOooOoooo ooooOoooo5 = (PictureViewer.OOooOoooo)obj5;
					IL_5BE:
					num2 = 83;
					if (ooooOoooo5.get_DownLoadState() == PictureViewer.o0o0.Waiting)
					{
						IL_5CD:
						num2 = 84;
						string text2 = ooooOoooo5.Tag.ToString();
						IL_5DE:
						num2 = 85;
						string text3 = OO_00oOO.ProjectPath + "RemoteFiles\\" + text2.Replace("/", "\\").Trim(new char[]
						{
							'\\'
						});
						IL_613:
						num2 = 86;
						if (O_O0OO.oO_00Ooo___0._..Contains(text2.ToLower()))
						{
							IL_629:
							num2 = 87;
							ooooOoooo5.set_DownLoadState(PictureViewer.o0o0.DownLoadByOther);
						}
						else
						{
							IL_639:
							num2 = 89;
							if (!OO_00oOO.FileSys.FileExists(text3) || ooooOoooo5.get_Redownload())
							{
								IL_656:
								num2 = 90;
								string parentPath = OO_00oOO.FileSys.GetParentPath(text3);
								IL_667:
								num2 = 91;
								if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
								{
									IL_678:
									num2 = 92;
									OO_00oOO.FileSys.CreateDirectory(parentPath);
								}
								IL_687:
								num2 = 93;
								ooooOoooo5.Controls.Clear();
								IL_696:
								num2 = 94;
								ooooOoooo5.SizeMode = PictureBoxSizeMode.CenterImage;
								IL_6A1:
								num2 = 95;
								ooooOoooo5.Image = O_O0OO.o0_OO.000.();
								IL_6B0:
								num2 = 96;
								ooooOoooo5.set_DownLoadState(PictureViewer.o0o0.DownLoading);
								IL_6BB:
								num2 = 97;
								this.o.O__00. = true;
								IL_6C5:
								num2 = 98;
								if (this.O0.OO0OO..Count == 1 || this.C1PictureBox1.Tag == ooooOoooo5)
								{
									IL_6E5:
									num2 = 99;
									this.C1PictureBox1.Visible = false;
									IL_6F4:
									num2 = 100;
									this.C1PictureBox2.Visible = true;
									IL_703:
									num2 = 101;
									this.C1PictureBox2.Image = O_O0OO.o0_OO.000.();
								}
								IL_716:
								num2 = 102;
								O_O0OO.oO_00Ooo___0._..Add(text2.ToLower());
								IL_72A:
								num2 = 103;
								this.O.oOOOO0. = text2.ToLower();
								IL_73A:
								num2 = 104;
								this.FTPclient.O_O0Ooo_00.o.(text2, text3, false);
								break;
							}
						}
					}
					IL_74F:
					num2 = 106;
				}
				IL_75E:
				num2 = 107;
				if (enumerator6 is IDisposable)
				{
					(enumerator6 as IDisposable).Dispose();
				}
				IL_776:
				num2 = 108;
				if (this.o.O__00. || !this.AutoUpdate)
				{
					goto IL_862;
				}
				IL_78F:
				num2 = 109;
				IEnumerator enumerator7 = this.FlowLayoutPanel1.Controls.GetEnumerator();
				while (enumerator7.MoveNext())
				{
					object obj6 = enumerator7.Current;
					PictureViewer.OOooOoooo ooooOoooo6 = (PictureViewer.OOooOoooo)obj6;
					IL_7B7:
					num2 = 110;
					if (ooooOoooo6.get_Completed() && !ooooOoooo6.get_Compared())
					{
						IL_7CC:
						num2 = 111;
						string text4 = ooooOoooo6.Tag.ToString();
						IL_7DD:
						num2 = 112;
						string a_2 = OO_00oOO.ProjectPath + "RemoteFiles\\" + text4.Replace("/", "\\").Trim(new char[]
						{
							'\\'
						});
						IL_812:
						num2 = 113;
						ooooOoooo6.set_Compared(true);
						IL_81D:
						num2 = 114;
						this.o.O__00. = true;
						IL_827:
						num2 = 115;
						this.FTPclient.O_O_0_O0.oOO.(text4, a_2);
						break;
					}
					IL_83B:
					num2 = 117;
				}
				IL_84A:
				num2 = 118;
				if (enumerator7 is IDisposable)
				{
					(enumerator7 as IDisposable).Dispose();
				}
				IL_862:
				goto IL_A90;
				IL_2A7:
				num2 = 41;
				goto IL_2AA;
				IL_867:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_A51:
				goto IL_A85;
				IL_A53:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_A63:;
			}
			catch when (endfilter(obj7 is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj8;
				goto IL_A53;
			}
			IL_A85:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_A90:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x000DD854 File Offset: 0x000DBA54
		private void <<EMPTY_NAME>>(object A_0, AsyncCompletedEventArgs A_1)
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
				PictureViewer.OOooOoooo ooooOoooo = (PictureViewer.OOooOoooo)this.Box.Tag;
				IL_1A:
				num2 = 3;
				if (ooooOoooo.FindForm() == null)
				{
					goto IL_1A9;
				}
				IL_27:
				num2 = 4;
				if (A_1.Error != null || A_1.Cancelled)
				{
					goto IL_C6;
				}
				IL_3F:
				num2 = 5;
				ooooOoooo.Controls.Clear();
				IL_4C:
				num2 = 6;
				ooooOoooo.Image = null;
				IL_55:
				num2 = 7;
				ooooOoooo.SizeMode = PictureBoxSizeMode.Zoom;
				IL_5E:
				num2 = 8;
				this.OoOo.O00.(this.Box.Image, (PictureViewer.OOooOoooo)this.Box.Tag);
				IL_81:
				num2 = 9;
				ooooOoooo.set_Canceled(false);
				IL_8B:
				num2 = 10;
				ooooOoooo.set_Completed(true);
				IL_95:
				num2 = 11;
				ooooOoooo.set_DownLoadState(PictureViewer.o0o0.DownLoaded);
				IL_9F:
				num2 = 12;
				this.Box.Image.Dispose();
				IL_B2:
				num2 = 13;
				this.Box.Image = null;
				goto IL_15C;
				IL_C6:
				num2 = 15;
				ooooOoooo.set_Canceled(true);
				IL_D0:
				num2 = 16;
				ooooOoooo.set_Completed(false);
				IL_DA:
				num2 = 17;
				if (this.FTPclient != null)
				{
					goto IL_F6;
				}
				IL_E5:
				num2 = 18;
				ooooOoooo.Image = ooooOoooo.ErrorImage;
				goto IL_15C;
				IL_F6:
				num2 = 20;
				ooooOoooo.Image = null;
				IL_100:
				num2 = 21;
				PictureViewer.oOo_O00 oOo_O = new PictureViewer.oOo_O00(this);
				IL_10B:
				num2 = 22;
				oOo_O.Dock = DockStyle.Fill;
				IL_116:
				num2 = 23;
				oOo_O.AutoSize = false;
				IL_121:
				num2 = 24;
				oOo_O.TextAlign = ContentAlignment.MiddleCenter;
				IL_12D:
				num2 = 25;
				oOo_O.Text = OO_00oOO.FileSys.GetName(ooooOoooo.Tag.ToString());
				IL_14C:
				num2 = 26;
				ooooOoooo.Controls.Add(oOo_O);
				IL_15C:
				num2 = 27;
				if (!this.O0O.o__0O. && this.C1PictureBox1.Tag != this.Box.Tag)
				{
					goto IL_1FB;
				}
				IL_17F:
				num2 = 28;
				this.O__O.o_ooo0Oo_.((PictureViewer.OOooOoooo)this.Box.Tag, new EventArgs());
				IL_19D:
				num2 = 29;
				this.O0O.o__0O. = false;
				goto IL_1FB;
				IL_1A9:
				num2 = 31;
				if (!((ooooOoooo.get_Completed() && ooooOoooo.Image != null && ooooOoooo.Image != O_O0OO.o0_OO.000.()) & ooooOoooo.Image != ooooOoooo.ErrorImage))
				{
					goto IL_1FB;
				}
				IL_1E3:
				num2 = 32;
				ooooOoooo.Image.Dispose();
				IL_1F1:
				num2 = 33;
				ooooOoooo.Image = null;
				IL_1FB:
				ooooOoooo = null;
				IL_1FD:
				num2 = 35;
				this.o_o_O_Oo.OoOo. = false;
				IL_207:
				goto IL_2E9;
				IL_20C:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2AA:
				goto IL_2DE;
				IL_2AC:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2BC:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2AC;
			}
			IL_2DE:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2E9:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x000DDB70 File Offset: 0x000DBD70
		private void <<EMPTY_NAME>>(string A_0)
		{
			string caption = A_0;
			if (Operators.CompareString(this.DataColumn.DefaultFolder, "", true) > 0)
			{
				A_0 = this.DataColumn.DefaultFolder.TrimEnd(new char[]
				{
					'\\'
				}) + "\\" + A_0;
			}
			A_0 = ooO.OoO0o_o___.O.(A_0);
			PictureViewer.OOooOoooo ooooOoooo = new PictureViewer.OOooOoooo();
			ooooOoooo.Tag = A_0;
			Main.OO_O.o..O0o__0_OO.o.().SetToolTip(ooooOoooo, caption);
			ooooOoooo.Size = new Size(56, 56);
			ooooOoooo.BorderStyle = BorderStyle.FixedSingle;
			ooooOoooo.SizeMode = PictureBoxSizeMode.CenterImage;
			ooooOoooo.Click += this.O__O.o_ooo0Oo_.;
			ooooOoooo.DoubleClick += this.OO.O_.;
			this.FlowLayoutPanel1.Controls.Add(ooooOoooo);
			if (Operators.CompareString(A_0, "", true) > 0 && c.OOOOO.o.().FileSystem.FileExists(A_0))
			{
				ooooOoooo.Image = O_O0OO.o0_OO.000.();
				return;
			}
			ooooOoooo.Image = ooooOoooo.ErrorImage;
			ooooOoooo.set_Canceled(true);
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x000DDC78 File Offset: 0x000DBE78
		private void <<EMPTY_NAME>>(string A_0)
		{
			PictureViewer.OOooOoooo ooooOoooo = new PictureViewer.OOooOoooo();
			ooooOoooo.Tag = A_0;
			Main.OO_O.o..O0o__0_OO.o.().SetToolTip(ooooOoooo, OO_00oOO.FileSys.GetName(A_0));
			ooooOoooo.Size = new Size(56, 56);
			ooooOoooo.BorderStyle = BorderStyle.FixedSingle;
			ooooOoooo.SizeMode = PictureBoxSizeMode.CenterImage;
			ooooOoooo.Click += this.O__O.o_ooo0Oo_.;
			ooooOoooo.DoubleClick += this.OO.O_.;
			this.FlowLayoutPanel1.Controls.Add(ooooOoooo);
			A_0 = OO_00oOO.ProjectPath + "RemoteFiles\\" + A_0.Replace("/", "\\").Trim(new char[]
			{
				'\\'
			});
			if (OO_00oOO.FileSys.FileExists(A_0))
			{
				ooooOoooo.Image = O_O0OO.o0_OO.000.();
				return;
			}
			PictureViewer.oOo_O00 oOo_O = new PictureViewer.oOo_O00(this);
			oOo_O.Dock = DockStyle.Fill;
			oOo_O.TextAlign = ContentAlignment.MiddleCenter;
			oOo_O.AutoSize = false;
			oOo_O.Text = OO_00oOO.FileSys.GetName(A_0);
			ooooOoooo.Controls.Add(oOo_O);
			ooooOoooo.set_Canceled(false);
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x000DDD8C File Offset: 0x000DBF8C
		private void <<EMPTY_NAME>>(Image A_0, PictureViewer.OOooOoooo A_1)
		{
			Size clientSize = A_1.ClientSize;
			A_1.Image = A_0.GetThumbnailImage(clientSize.Width, clientSize.Height, null, 0);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x000DDDC4 File Offset: 0x000DBFC4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.C1PictureBox1.Tag = RuntimeHelpers.GetObjectValue(A_0);
			PictureViewer.OOooOoooo ooooOoooo = (PictureViewer.OOooOoooo)A_0;
			if (this.lblMark.Parent != A_0)
			{
				this.lblMark.Top = -2;
				this.lblMark.Left = ooooOoooo.Width - this.lblMark.Width + 2;
				ooooOoooo.Controls.Add(this.lblMark);
				this.lblMark.Visible = true;
			}
			if (this.C1PictureBox1.Image != null)
			{
				this.C1PictureBox1.Image.Dispose();
				this.C1PictureBox1.Image = null;
			}
			if (ooooOoooo.get_Completed())
			{
				this.C1PictureBox1.Visible = true;
				this.C1PictureBox2.Visible = false;
				string text = ooooOoooo.Tag.ToString();
				if (this.FTPclient != null)
				{
					text = OO_00oOO.ProjectPath + "RemoteFiles\\" + text.Replace("/", "\\").Trim(new char[]
					{
						'\\'
					});
				}
				if (OO_00oOO.FileSys.FileExists(text))
				{
					this.C1PictureBox1.Image = OO_00oOO.GetImage(text);
				}
			}
			else if (ooooOoooo.get_DownLoadState() == PictureViewer.o0o0.DownLoading)
			{
				this.C1PictureBox1.Visible = false;
				this.C1PictureBox2.Visible = true;
				this.C1PictureBox2.Image = O_O0OO.o0_OO.000.();
			}
			else if (ooooOoooo.get_Canceled())
			{
				this.C1PictureBox1.Visible = false;
				this.C1PictureBox2.Visible = true;
				this.C1PictureBox2.Image = this.C1PictureBox2.ErrorImage;
			}
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x000DDF58 File Offset: 0x000DC158
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			PictureViewer.OOooOoooo ooooOoooo = (PictureViewer.OOooOoooo)A_0;
			if (this.FTPclient != null)
			{
				if (ooooOoooo.get_Completed() && Control.ModifierKeys == Keys.None)
				{
					this.oo0_.o___.(this.Open, new EventArgs());
				}
				else
				{
					string text = ooooOoooo.Tag.ToString();
					string a_ = OO_00oOO.ProjectPath + "RemoteFiles\\" + text.Replace("/", "\\").Trim(new char[]
					{
						'\\'
					});
					if (O_O0OO.oO_00Ooo___0._..Contains(text.ToLower()))
					{
						ooooOoooo.set_DownLoadState(PictureViewer.o0o0.DownLoadByOther);
						MessageBox.Show("其它进程正在下载此文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					ooooOoooo.set_DownLoadState(PictureViewer.o0o0.Waiting);
					ooooOoooo.set_Redownload(true);
					if (!this.AutoDownLoad)
					{
						O\u3000O\u3000 o_u3000O_u = new O\u3000O\u3000(this.FTPclient, text, a_);
						ooooOoooo.set_DownLoadState(PictureViewer.o0o0.DownLoading);
						O_O0OO.oO_00Ooo___0._..Add(text.ToLower());
						if (o_u3000O_u.ShowDialog() == DialogResult.OK)
						{
							ooooOoooo.set_DownLoadState(PictureViewer.o0o0.DownLoaded);
							ooooOoooo.set_Completed(false);
							ooooOoooo.set_Canceled(false);
						}
						else
						{
							ooooOoooo.set_DownLoadState(PictureViewer.o0o0.Canceled);
							ooooOoooo.set_Completed(false);
							ooooOoooo.set_Canceled(true);
						}
						o_u3000O_u.Dispose();
					}
				}
			}
			else
			{
				this.oo0_.o___.(this.Open, new EventArgs());
			}
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x000DE090 File Offset: 0x000DC290
		private void <<EMPTY_NAME>>()
		{
			if (this.C1PictureBox1.Image != null && this.C1PictureBox1.Dock != DockStyle.Fill)
			{
				int x = Math.Max(0, (int)Math.Round((double)(this.Panel2.ClientSize.Width - this.C1PictureBox1.Size.Width) / 2.0));
				int y = Math.Max(0, (int)Math.Round((double)(this.Panel2.ClientSize.Height - this.C1PictureBox1.Size.Height) / 2.0));
				this.C1PictureBox1.Location = new Point(x, y);
			}
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x000DE150 File Offset: 0x000DC350
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OoOo.O00.())
			{
				string a_;
				if (Operators.CompareString(this.DataColumn.FileFilter, "", true) == 0)
				{
					a_ = O_O0OO.o__._oo0O.();
				}
				else
				{
					a_ = this.DataColumn.FileFilter;
				}
				List<string> list = Oo00.O____0O._0.(this.Table.Current.DataRow, this.DataColumn, this.FTPclient, a_);
				if (list != null && list.Count > 0)
				{
					try
					{
						foreach (string text in list)
						{
							if (Operators.CompareString(text, "", true) > 0 && !this.oOo.o0Oo_.(text))
							{
								break;
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.PictureSplitContainer.Panel2Collapsed = (this.O0.OO0OO..Count <= 1);
				}
			}
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x000DE234 File Offset: 0x000DC434
		internal bool <<EMPTY_NAME>>(string A_0)
		{
			string[] array = new string[]
			{
				"ico",
				"bmp",
				"gif",
				"jpg",
				"png",
				"tif",
				"wmf"
			};
			string text = Path.GetExtension(A_0).Substring(1);
			bool result;
			if (Array.IndexOf<string>(array, text.ToLower()) < 0 && MessageBox.Show("\"" + OO_00oOO.FileSys.GetName(A_0) + "\"并非图片浏览器所支持的文件格式，是否确定要增加？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
			{
				result = false;
			}
			else
			{
				string text2 = this.o_O0.O0O.;
				int maxLength = this.DataColumn.BaseColumn.MaxLength;
				if (Operators.CompareString(this.o_O0.O0O., "", true) > 0)
				{
					this.o_O0.O0O. += "\r\n";
				}
				this.o_O0.O0O. += A_0;
				if (this.o_O0.O0O..Length > maxLength && maxLength > -1)
				{
					this.o_O0.O0O. = text2;
					MessageBox.Show("文件路径长度超过当前列允许输入的最大长度；请在菜单中，执行\"更改列\"命令，调整列的长度属性，或将列类型改为备注型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = false;
				}
				else
				{
					this.O_O0.OO.++;
					this.O0.OO0OO..Add(A_0);
					this.bd.WriteValue();
					if (this.FTPclient == null)
					{
						this.o_.0o_0o_o.(A_0);
					}
					else
					{
						this.o.o0o0.(A_0);
					}
					this.O0O.o__0O. = true;
					this.PictureSplitContainer.Panel2Collapsed = (this.O0.OO0OO..Count <= 1);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x000DE3B4 File Offset: 0x000DC5B4
		internal string SelectedItem
		{
			get
			{
				string result;
				if (this.C1PictureBox1.Tag == null)
				{
					result = null;
				}
				else
				{
					result = ((Control)this.C1PictureBox1.Tag).Tag.ToString();
				}
				return result;
			}
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x000DE3F0 File Offset: 0x000DC5F0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OoOo.O00.() && this.C1PictureBox1.Tag != null)
			{
				PictureViewer.OOooOoooo ooooOoooo = (PictureViewer.OOooOoooo)this.C1PictureBox1.Tag;
				this.oO0__0O0o00._.(ooooOoooo.Tag.ToString());
			}
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x000DE434 File Offset: 0x000DC634
		internal void <<EMPTY_NAME>>(string A_0)
		{
			PictureViewer.OOooOoooo ooooOoooo = null;
			try
			{
				foreach (object obj in this.FlowLayoutPanel1.Controls)
				{
					PictureViewer.OOooOoooo ooooOoooo2 = (PictureViewer.OOooOoooo)obj;
					if (Operators.CompareString(ooooOoooo2.Tag.ToString(), A_0, true) == 0)
					{
						ooooOoooo = ooooOoooo2;
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
			if (ooooOoooo != null)
			{
				int num = this.FlowLayoutPanel1.Controls.IndexOf(ooooOoooo);
				string str = "";
				if (num >= 0)
				{
					DataRow dataRow = this.Table.Current.DataRow;
					DataCol a_ = this.DataColumn;
					if (Oo00.OO.0O0o.(dataRow, a_, A_0))
					{
						this.FlowLayoutPanel1.Controls.Remove(ooooOoooo);
						this.O0.OO0OO..Remove(this.O0.OO0OO.[num]);
						int num2 = this.O0.OO0OO..Count - 1;
						for (int i = 0; i <= num2; i++)
						{
							if (i > 0)
							{
								str += "\r\n";
							}
							str += this.O0.OO0OO.[i];
						}
						this.o_O0.O0O. = str;
						this.bd.WriteValue();
						if (this.FlowLayoutPanel1.Controls.Count == 0)
						{
							this.C1PictureBox1.Image = null;
							this.C1PictureBox1.Tag = null;
						}
						else
						{
							if (this.FlowLayoutPanel1.Controls.Count - 1 < num)
							{
								num = this.FlowLayoutPanel1.Controls.Count - 1;
							}
							ooooOoooo = (PictureViewer.OOooOoooo)this.FlowLayoutPanel1.Controls[num];
							if (ooooOoooo.get_Completed())
							{
								this.O__O.o_ooo0Oo_.(ooooOoooo, new EventArgs());
							}
						}
						this.PictureSplitContainer.Panel2Collapsed = (this.O0.OO0OO..Count <= 1);
					}
				}
			}
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000DE614 File Offset: 0x000DC814
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OoOo.O00.())
			{
				DataRow dataRow = this.Table.Current.DataRow;
				DataCol a_ = this.DataColumn;
				while (this.O0.OO0OO..Count > 0)
				{
					string a_2 = this.O0.OO0OO.[0];
					if (!Oo00.OO.0O0o.(dataRow, a_, a_2))
					{
						break;
					}
					this.O0.OO0OO..RemoveAt(0);
				}
				if (this.O0.OO0OO..Count == 0)
				{
					this.C1PictureBox1.Image = null;
					this.C1PictureBox1.Tag = null;
					this.FlowLayoutPanel1.Controls.Clear();
					this.o_O0.O0O. = "";
					this.bd.WriteValue();
				}
				else
				{
					string text = "";
					int num = this.O0.OO0OO..Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (i > 0)
						{
							text += "\r\n";
						}
						text += this.O0.OO0OO.[i];
					}
					this.ImageFiles = text;
				}
				this.PictureSplitContainer.Panel2Collapsed = (this.O0.OO0OO..Count <= 1);
			}
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x000DE734 File Offset: 0x000DC934
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Open.Enabled && this.C1PictureBox1.Tag != null)
			{
				DataRow dataRow = this.Table.Current.DataRow;
				DataCol a_ = this.DataColumn;
				PictureViewer.OOooOoooo ooooOoooo = (PictureViewer.OOooOoooo)this.C1PictureBox1.Tag;
				string a_2 = ooooOoooo.Tag.ToString();
				if (ooooOoooo.get_Completed() || !this.AutoDownLoad)
				{
					if (this.AutoDownLoad && this.AutoUpdate)
					{
						Oo00.o00O0O_.O.(dataRow, a_, this.FTPclient, a_2, false);
						return;
					}
					Oo00.o00O0O_.O.(dataRow, a_, this.FTPclient, a_2, this.AutoUpdate);
					return;
				}
				else
				{
					if (this.FTPclient != null)
					{
						MessageBox.Show("此文件未下载完成，无法打开！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					MessageBox.Show("此文件不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x000DE80C File Offset: 0x000DCA0C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			BindingManagerBase bindingManagerBase = base.DataBindings[0].BindingManagerBase;
			if (bindingManagerBase.Position >= 1)
			{
				bindingManagerBase.Position--;
			}
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x000DE844 File Offset: 0x000DCA44
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			BindingManagerBase bindingManagerBase = base.DataBindings[0].BindingManagerBase;
			if (bindingManagerBase.Position < bindingManagerBase.Count - 1)
			{
				bindingManagerBase.Position++;
			}
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x000DE884 File Offset: 0x000DCA84
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.DataBindings.Count != 0)
			{
				O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000 o_u3000__u3000_u3002_u3002_u3002_u3000_u = new O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000();
				PictureViewer pictureViewer = o_u3000__u3000_u3002_u3002_u3002_u3000_u.O.oO0_.();
				pictureViewer.FTPclient = this.FTPclient;
				pictureViewer.Add.Enabled = this.Add.Enabled;
				pictureViewer.Delete.Enabled = this.Delete.Enabled;
				pictureViewer.Clear.Enabled = this.Clear.Enabled;
				pictureViewer.Open.Enabled = this.Open.Enabled;
				pictureViewer.SaveAs.Enabled = this.SaveAs.Enabled;
				pictureViewer.Manager.Enabled = this.Manager.Enabled;
				pictureViewer.lblConnect.Enabled = this.lblConnect.Enabled;
				pictureViewer.lblUpdate.Enabled = this.lblUpdate.Enabled;
				pictureViewer.Add.Visible = this.Add.Visible;
				pictureViewer.Delete.Visible = this.Delete.Visible;
				pictureViewer.Clear.Visible = this.Clear.Visible;
				pictureViewer.Open.Visible = this.Open.Visible;
				pictureViewer.SaveAs.Visible = this.SaveAs.Visible;
				pictureViewer.Manager.Visible = this.Manager.Visible;
				pictureViewer.lblConnect.Visible = this.lblConnect.Visible;
				pictureViewer.lblUpdate.Visible = this.lblUpdate.Visible;
				pictureViewer.AutoUpdate = this.AutoUpdate;
				pictureViewer.AutoDownLoad = false;
				base.DataBindings[0].WriteValue();
				o_u3000__u3000_u3002_u3002_u3002_u3000_u.O.oO0_.().DataBindings.Add("ImageFiles", RuntimeHelpers.GetObjectValue(base.DataBindings[0].DataSource), base.DataBindings[0].BindingMemberInfo.BindingMember);
				o_u3000__u3000_u3002_u3002_u3002_u3000_u.ShowDialog();
				o_u3000__u3000_u3002_u3002_u3002_u3000_u.Dispose();
				base.DataBindings[0].ReadValue();
			}
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x000DEAA0 File Offset: 0x000DCCA0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.Parent != null)
			{
				if (this.FTPclient == null)
				{
					this.lblConnect.Visible = false;
					this.lblUpdate.Visible = false;
				}
				else if (!this.AutoDownLoad)
				{
					this.lblUpdate.Visible = false;
				}
				Application.Idle += this.oo_o000o_oo0.o.;
				NetworkChange.NetworkAvailabilityChanged += this.O__o.0o.;
				NetworkChange.NetworkAddressChanged += this.oo_o___._O0.;
				return;
			}
			Application.Idle -= this.oo_o000o_oo0.o.;
			NetworkChange.NetworkAvailabilityChanged -= this.O__o.0o.;
			NetworkChange.NetworkAddressChanged -= this.oo_o___._O0.;
			if (this.FTPclient != null)
			{
				if (this.FTPclient.Connected)
				{
					this.FTPclient.Close();
				}
				this.FTPclient = null;
				if (Operators.CompareString(this.O.oOOOO0., "", true) > 0 && O_O0OO.oO_00Ooo___0._..Contains(this.O.oOOOO0..ToLower()))
				{
					O_O0OO.oO_00Ooo___0._..Remove(this.O.oOOOO0..ToLower());
				}
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x000DEBBC File Offset: 0x000DCDBC
		internal DataCol DataColumn
		{
			get
			{
				DataTable dataTable = ((O_0)this.bd.DataSource).o_o.O0ooOo.();
				return OO_00oOO.DataTables[dataTable.TableName].DataCols[this.bd.BindingMemberInfo.BindingField];
			}
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x000DEC0C File Offset: 0x000DCE0C
		private bool <<EMPTY_NAME>>()
		{
			bool result;
			if (this.bm == null)
			{
				result = false;
			}
			else if (this.bm.Position >= 0)
			{
				switch (this.ReadOnly)
				{
				case BooleanEnum.Default:
					if (!this.Table.AllowEdit)
					{
						result = false;
					}
					else
					{
						DataRow row = ((DataRowView)this.bm.Current).Row;
						string bindingField = base.DataBindings[0].BindingMemberInfo.BindingField;
						bool allowEdit;
						if (this.Table.Cols.Contains(bindingField))
						{
							allowEdit = this.Table.Cols[bindingField].AllowEdit;
						}
						else
						{
							allowEdit = this.Table.DataTable.DataCols[bindingField].AllowEdit;
						}
						result = ((row.IsNull("_Locked") || !Conversions.ToBoolean(row["_Locked"])) && allowEdit);
					}
					break;
				case BooleanEnum.True:
					result = false;
					break;
				case BooleanEnum.False:
					result = true;
					break;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x000DED24 File Offset: 0x000DCF24
		private void <<EMPTY_NAME>>(object A_0, ConvertEventArgs A_1)
		{
			DataRowView dataRowView = (DataRowView)this.bd.BindingManagerBase.Current;
			string bindingField = this.bd.BindingMemberInfo.BindingField;
			if (Operators.CompareString(A_1.Value.ToString(), dataRowView[bindingField].ToString(), true) != 0)
			{
				this.Table.O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.Table, dataRowView.Row, bindingField));
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x000DED9C File Offset: 0x000DCF9C
		private Table Table
		{
			get
			{
				Table result;
				if (base.DataBindings.Count > 0)
				{
					if (((O_0)this.bd.DataSource).o_o.O0ooOo.().DataSet == O_O0OO.OOOo.oo_OOOO_0.())
					{
						result = OO_00oOO.Tables[((O_0)this.bd.DataSource).Oo._Oo0OO.()];
					}
					else
					{
						result = null;
					}
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x000DEE01 File Offset: 0x000DD001
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o00.o0o. == null)
			{
				this.o00.o0o. = this.FTPclient.O_O_0_O0.oOO.();
			}
			this.o00.o0o..OpenManager();
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x000DEE27 File Offset: 0x000DD027
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (A_1.Button == MouseButtons.Left)
			{
				this.O.0O_o_. = A_1.X;
				this.O0O.o__0O. = A_1.Y;
				this.O0.OO0OO. = true;
				this.C1PictureBox1.Cursor = Cursors.Hand;
			}
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x000DEE68 File Offset: 0x000DD068
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			int num = this.Panel2.HorizontalScroll.Value - (A_1.X - this.O.0O_o_.);
			int num2 = this.Panel2.VerticalScroll.Value - (A_1.Y - this.O0O.o__0O.);
			if (this.O0.OO0OO.)
			{
				if (!(num >= 0 & num <= this.Panel2.HorizontalScroll.Maximum))
				{
					num = this.Panel2.HorizontalScroll.Value;
				}
				if (!(num2 >= 0 & num2 <= this.Panel2.VerticalScroll.Maximum))
				{
					num2 = this.Panel2.VerticalScroll.Value;
				}
				this.Panel2.AutoScrollPosition = new Point(num, num2);
			}
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x000DEF2F File Offset: 0x000DD12F
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			this.O0.OO0OO. = false;
			this.C1PictureBox1.Cursor = Cursors.Default;
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x000DEF48 File Offset: 0x000DD148
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.SizeMode == PictureBoxSizeMode.Zoom)
			{
				this.SizeMode = PictureBoxSizeMode.AutoSize;
				return;
			}
			this.SizeMode = PictureBoxSizeMode.Zoom;
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x000DEF64 File Offset: 0x000DD164
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.C1PictureBox1.Tag != null)
			{
				string text = ((Control)this.C1PictureBox1.Tag).Tag.ToString();
				if (this.FTPclient != null)
				{
					text = OO_00oOO.ProjectPath + "RemoteFiles\\" + text.Replace("/", "\\").Trim(new char[]
					{
						'\\'
					});
				}
				if (c.OOOOO.o.().FileSystem.FileExists(text))
				{
					try
					{
						SaveFileDialog saveFileDialog = new SaveFileDialog();
						saveFileDialog.FileName = OO_00oOO.FileSys.GetName(text);
						saveFileDialog.Filter = Path.GetExtension(text).Trim(new char[]
						{
							'.'
						}) + "|*" + Path.GetExtension(text);
						if (saveFileDialog.ShowDialog() == DialogResult.OK)
						{
							OO_00oOO.FileSys.CopyFile(text, saveFileDialog.FileName, true);
						}
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
					}
				}
			}
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x000DF070 File Offset: 0x000DD270
		private void <<EMPTY_NAME>>(object A_0, NetworkAvailabilityEventArgs A_1)
		{
			if (this.FTPclient != null)
			{
				this.o0._0OO. = true;
				this.FTPclient.Connected = false;
				this.O.0O_o_. = DateTime.Now;
			}
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x000DF098 File Offset: 0x000DD298
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.FTPclient != null)
			{
				this.o0._0OO. = true;
				this.FTPclient.Connected = false;
				this.O.0O_o_. = DateTime.Now;
			}
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x000DF0C0 File Offset: 0x000DD2C0
		private void <<EMPTY_NAME>>(string A_0)
		{
			if (O_O0OO.oO_00Ooo___0._..Contains(A_0.ToLower()))
			{
				O_O0OO.oO_00Ooo___0._..Remove(A_0.ToLower());
			}
			if (this.AutoDownLoad)
			{
				this.o.O__00. = false;
				try
				{
					foreach (object obj in this.FlowLayoutPanel1.Controls)
					{
						PictureViewer.OOooOoooo ooooOoooo = (PictureViewer.OOooOoooo)obj;
						if (Operators.CompareString(ooooOoooo.Tag.ToString(), A_0, true) == 0)
						{
							ooooOoooo.set_DownLoadState(PictureViewer.o0o0.DownLoaded);
							ooooOoooo.set_Canceled(false);
							ooooOoooo.set_Completed(false);
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
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x000DF178 File Offset: 0x000DD378
		private void <<EMPTY_NAME>>(string A_0, bool A_1)
		{
			if (O_O0OO.oO_00Ooo___0._..Contains(A_0.ToLower()))
			{
				O_O0OO.oO_00Ooo___0._..Remove(A_0.ToLower());
			}
			if (this.AutoDownLoad)
			{
				this.o.O__00. = false;
				try
				{
					foreach (object obj in this.FlowLayoutPanel1.Controls)
					{
						PictureViewer.OOooOoooo ooooOoooo = (PictureViewer.OOooOoooo)obj;
						if (Operators.CompareString(ooooOoooo.Tag.ToString(), A_0, true) == 0)
						{
							ooooOoooo.set_Canceled(true);
							ooooOoooo.set_Completed(false);
							if (A_1)
							{
								ooooOoooo.set_DownLoadState(PictureViewer.o0o0.Waiting);
							}
							else
							{
								ooooOoooo.set_DownLoadState(PictureViewer.o0o0.Canceled);
							}
							if (base.FindForm() != null && !OO_00oOO.BaseMainForm.IsDisposed && !this.FTPclient.O0.o0. && OO_00oOO.BaseMainForm.IsHandleCreated)
							{
								OO_00oOO.BaseMainForm.Invoke(new PictureViewer.O_0000O(this.oOo.o0Oo_.), new object[]
								{
									ooooOoooo,
									A_0
								});
								break;
							}
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
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x000DF298 File Offset: 0x000DD498
		private void <<EMPTY_NAME>>(string A_0, string A_1, bool A_2)
		{
			this.o.O__00. = false;
			if (!A_2)
			{
				try
				{
					foreach (object obj in this.FlowLayoutPanel1.Controls)
					{
						PictureViewer.OOooOoooo ooooOoooo = (PictureViewer.OOooOoooo)obj;
						if (Operators.CompareString(ooooOoooo.Tag.ToString(), A_0, true) == 0)
						{
							ooooOoooo.set_DownLoadState(PictureViewer.o0o0.Waiting);
							ooooOoooo.set_Redownload(true);
							ooooOoooo.set_Canceled(false);
							ooooOoooo.set_Completed(true);
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
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x000DF330 File Offset: 0x000DD530
		private void <<EMPTY_NAME>>()
		{
			this.o.O__00. = false;
			this.o0._0OO. = false;
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x000DF340 File Offset: 0x000DD540
		private void <<EMPTY_NAME>>(PictureViewer.OOooOoooo A_0, string A_1)
		{
			PictureViewer.oOo_O00 oOo_O = new PictureViewer.oOo_O00(this);
			oOo_O.Dock = DockStyle.Fill;
			oOo_O.TextAlign = ContentAlignment.MiddleCenter;
			oOo_O.AutoSize = false;
			oOo_O.Text = OO_00oOO.FileSys.GetName(A_1);
			A_0.Controls.Add(oOo_O);
			if (this.C1PictureBox2.Visible)
			{
				this.C1PictureBox2.Visible = true;
				this.C1PictureBox1.Visible = false;
				this.C1PictureBox2.Image = this.C1PictureBox2.ErrorImage;
				if (this.C1PictureBox1.Tag == null)
				{
					this.O__O.o_ooo0Oo_.(A_0, new EventArgs());
				}
			}
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x000DF3DC File Offset: 0x000DD5DC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.FTPclient != null && !this.FTPclient.Connected && this.o0._0OO. && (DateTime.Now - this.O.0O_o_.).TotalSeconds > 3.0 && NetworkInterface.GetIsNetworkAvailable())
			{
				if (this.FTPclient.Connect())
				{
					this.o0._0OO. = false;
					return;
				}
				this.O.0O_o_. = DateTime.Now.AddSeconds(8.0);
			}
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x000DF464 File Offset: 0x000DD664
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.FTPclient.Connected = false;
			this.FTPclient.Connect();
			if (this.FTPclient.Connected)
			{
				MessageBox.Show("已经重新连接FTP服务器!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			MessageBox.Show("重新连接FTP服务器失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x000DF4C0 File Offset: 0x000DD6C0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (object obj in this.FlowLayoutPanel1.Controls)
				{
					PictureViewer.OOooOoooo ooooOoooo = (PictureViewer.OOooOoooo)obj;
					if (ooooOoooo.get_DownLoadState() == PictureViewer.o0o0.Waiting || ooooOoooo.get_DownLoadState() == PictureViewer.o0o0.DownLoaded)
					{
						string text = ooooOoooo.Tag.ToString();
						string file = OO_00oOO.ProjectPath + "RemoteFiles\\" + text.Replace("/", "\\").Trim(new char[]
						{
							'\\'
						});
						if (OO_00oOO.FileSys.FileExists(file))
						{
							OO_00oOO.FileSys.DeleteFile(file);
						}
						ooooOoooo.set_DownLoadState(PictureViewer.o0o0.Waiting);
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

		// Token: 0x06002017 RID: 8215 RVA: 0x000DF588 File Offset: 0x000DD788
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.C1PictureBox1.Tag != null)
			{
				this.OO.O_.(RuntimeHelpers.GetObjectValue(this.C1PictureBox1.Tag), A_1);
			}
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x000DF5AE File Offset: 0x000DD7AE
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.lblMark.ForeColor = Color.Red;
		}

		// Token: 0x04000D50 RID: 3408
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000D51 RID: 3409
		[AccessedThroughProperty("Panel2")]
		[CompilerGenerated]
		private Panel <<EMPTY_NAME>>;

		// Token: 0x04000D52 RID: 3410
		[AccessedThroughProperty("PrevRecord")]
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D53 RID: 3411
		[AccessedThroughProperty("NextRecord")]
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D54 RID: 3412
		[CompilerGenerated]
		[AccessedThroughProperty("Add")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D55 RID: 3413
		[CompilerGenerated]
		[AccessedThroughProperty("Delete")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D56 RID: 3414
		[CompilerGenerated]
		[AccessedThroughProperty("Open")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D57 RID: 3415
		[AccessedThroughProperty("PictureSplitContainer")]
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x04000D58 RID: 3416
		[CompilerGenerated]
		[AccessedThroughProperty("FlowLayoutPanel1")]
		private FlowLayoutPanel <<EMPTY_NAME>>;

		// Token: 0x04000D59 RID: 3417
		[CompilerGenerated]
		[AccessedThroughProperty("C1PictureBox1")]
		private C1PictureBox <<EMPTY_NAME>>;

		// Token: 0x04000D5A RID: 3418
		[AccessedThroughProperty("Clear")]
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D5B RID: 3419
		[AccessedThroughProperty("Full")]
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D5C RID: 3420
		[AccessedThroughProperty("SplitContainer")]
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x04000D5D RID: 3421
		[CompilerGenerated]
		[AccessedThroughProperty("Manager")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D5E RID: 3422
		[CompilerGenerated]
		[AccessedThroughProperty("Stretch")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D5F RID: 3423
		[CompilerGenerated]
		[AccessedThroughProperty("FlowLayoutPanel2")]
		private FlowLayoutPanel <<EMPTY_NAME>>;

		// Token: 0x04000D60 RID: 3424
		[AccessedThroughProperty("SaveAs")]
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D61 RID: 3425
		[CompilerGenerated]
		[AccessedThroughProperty("Timer1")]
		private System.Windows.Forms.Timer <<EMPTY_NAME>>;

		// Token: 0x04000D62 RID: 3426
		[CompilerGenerated]
		[AccessedThroughProperty("lblConnect")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D63 RID: 3427
		[CompilerGenerated]
		[AccessedThroughProperty("lblUpdate")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D64 RID: 3428
		[CompilerGenerated]
		[AccessedThroughProperty("C1PictureBox2")]
		private C1PictureBox <<EMPTY_NAME>>;

		// Token: 0x04000D65 RID: 3429
		[AccessedThroughProperty("Label1")]
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D66 RID: 3430
		[AccessedThroughProperty("lblMark")]
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D67 RID: 3431
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000D68 RID: 3432
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000D69 RID: 3433
		private string <<EMPTY_NAME>>;

		// Token: 0x04000D6A RID: 3434
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000D6B RID: 3435
		private int <<EMPTY_NAME>>;

		// Token: 0x04000D6C RID: 3436
		private int <<EMPTY_NAME>>;

		// Token: 0x04000D6D RID: 3437
		private int <<EMPTY_NAME>>;

		// Token: 0x04000D6E RID: 3438
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000D6F RID: 3439
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000D70 RID: 3440
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x04000D71 RID: 3441
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000D72 RID: 3442
		[CompilerGenerated]
		[AccessedThroughProperty("_FTPClient")]
		private FTPClient <<EMPTY_NAME>>;

		// Token: 0x04000D73 RID: 3443
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000D74 RID: 3444
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000D75 RID: 3445
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000D76 RID: 3446
		private string <<EMPTY_NAME>>;

		// Token: 0x04000D77 RID: 3447
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000D78 RID: 3448
		[CompilerGenerated]
		[AccessedThroughProperty("bdm")]
		private Binding <<EMPTY_NAME>>;

		// Token: 0x04000D79 RID: 3449
		[CompilerGenerated]
		[AccessedThroughProperty("Box")]
		private PictureBox <<EMPTY_NAME>>;

		// Token: 0x04000D7A RID: 3450
		[CompilerGenerated]
		private PictureViewer.O_O0_0_Ooo <<EMPTY_NAME>>;

		// Token: 0x04000D7B RID: 3451
		private FTPClient <<EMPTY_NAME>>;

		// Token: 0x0200027E RID: 638
		// (Invoke) Token: 0x0600201C RID: 8220
		public delegate void O_O0_0_Ooo(object A_0, EventArgs A_1);

		// Token: 0x0200027F RID: 639
		internal class OOooOoooo : PictureBox
		{
			// Token: 0x0600201E RID: 8222 RVA: 0x000DF5C8 File Offset: 0x000DD7C8
			internal bool get_Completed()
			{
				return this._Completed;
			}

			// Token: 0x0600201F RID: 8223 RVA: 0x000DF5D0 File Offset: 0x000DD7D0
			internal void set_Completed(bool value)
			{
				this._Completed = value;
			}

			// Token: 0x06002020 RID: 8224 RVA: 0x000DF5D9 File Offset: 0x000DD7D9
			internal bool get_Canceled()
			{
				return this._Canceled;
			}

			// Token: 0x06002021 RID: 8225 RVA: 0x000DF5E1 File Offset: 0x000DD7E1
			internal void set_Canceled(bool value)
			{
				this._Canceled = value;
			}

			// Token: 0x06002022 RID: 8226 RVA: 0x000DF5EA File Offset: 0x000DD7EA
			public PictureViewer.o0o0 get_DownLoadState()
			{
				return this._DownLoadState;
			}

			// Token: 0x06002023 RID: 8227 RVA: 0x000DF5F2 File Offset: 0x000DD7F2
			public void set_DownLoadState(PictureViewer.o0o0 value)
			{
				this._DownLoadState = value;
				if (value == PictureViewer.o0o0.DownLoading)
				{
					this.set_Compared(true);
					this.set_Redownload(false);
				}
			}

			// Token: 0x06002024 RID: 8228 RVA: 0x000DF60D File Offset: 0x000DD80D
			public bool get_Compared()
			{
				return this._Compared;
			}

			// Token: 0x06002025 RID: 8229 RVA: 0x000DF615 File Offset: 0x000DD815
			public void set_Compared(bool value)
			{
				this._Compared = value;
			}

			// Token: 0x06002026 RID: 8230 RVA: 0x000DF61E File Offset: 0x000DD81E
			internal bool get_Redownload()
			{
				return this._Redownload;
			}

			// Token: 0x06002027 RID: 8231 RVA: 0x000DF626 File Offset: 0x000DD826
			internal void set_Redownload(bool value)
			{
				this._Redownload = value;
			}

			// Token: 0x04000D7C RID: 3452
			private bool _Completed;

			// Token: 0x04000D7D RID: 3453
			private bool _Canceled;

			// Token: 0x04000D7E RID: 3454
			private bool _Loading;

			// Token: 0x04000D7F RID: 3455
			private PictureViewer.o0o0 _DownLoadState;

			// Token: 0x04000D80 RID: 3456
			private bool _Compared;

			// Token: 0x04000D81 RID: 3457
			private bool _Redownload;
		}

		// Token: 0x02000280 RID: 640
		internal class oOo_O00 : Label
		{
			// Token: 0x06002028 RID: 8232 RVA: 0x000DF630 File Offset: 0x000DD830
			internal oOo_O00(PictureViewer A_0)
			{
				base.Click += this.MyLabel_Click;
				base.DoubleClick += this.MyLabel_DoubleClick;
				this.piv = A_0;
				Main.OO_O.o..O0o__0_OO.o.().SetToolTip(this, "双击下载或更新文件！");
			}

			// Token: 0x06002029 RID: 8233 RVA: 0x000DF683 File Offset: 0x000DD883
			private void MyLabel_Click(object sender, EventArgs e)
			{
				if (base.Parent != null)
				{
					this.piv.O__O.o_ooo0Oo_.(base.Parent, e);
				}
			}

			// Token: 0x0600202A RID: 8234 RVA: 0x000DF69F File Offset: 0x000DD89F
			private void MyLabel_DoubleClick(object sender, EventArgs e)
			{
				if (base.Parent != null)
				{
					this.piv.OO.O_.(base.Parent, e);
				}
			}

			// Token: 0x04000D82 RID: 3458
			private PictureViewer piv;
		}

		// Token: 0x02000281 RID: 641
		internal enum o0o0
		{
			// Token: 0x04000D84 RID: 3460
			Waiting,
			// Token: 0x04000D85 RID: 3461
			DownLoading,
			// Token: 0x04000D86 RID: 3462
			DownLoaded,
			// Token: 0x04000D87 RID: 3463
			Canceled,
			// Token: 0x04000D88 RID: 3464
			DownLoadByOther
		}

		// Token: 0x02000282 RID: 642
		// (Invoke) Token: 0x0600202E RID: 8238
		public delegate void O_0000O(PictureViewer.OOooOoooo A_0, string A_1);
	}
}
