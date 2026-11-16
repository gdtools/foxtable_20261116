using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000276 RID: 630
	[DesignerGenerated]
	internal class FileManager : UserControl
	{
		// Token: 0x06001E81 RID: 7809 RVA: 0x000D18B2 File Offset: 0x000CFAB2
		public FileManager()
		{
			base.ParentChanged += this.ooo_oOOO0.0_.;
			this.o0o___Oo0o_0.0. = true;
			this.OO_00O.ooO0O_. = true;
			this.O.___0_o_0o0_O. = true;
			this.o.0OO00oo0.();
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x000D18E8 File Offset: 0x000CFAE8
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.o0o___Oo0o_0.0. != null)
				{
					this.o0o___Oo0o_0.0..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x000D1928 File Offset: 0x000CFB28
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.ListBox1 = new ListBox();
			this.Clear = new Label();
			this.Open = new Label();
			this.Add = new Label();
			this.Delete = new Label();
			this.SplitContainer1 = new SplitContainer();
			this.FlowLayoutPanel1 = new FlowLayoutPanel();
			this.Folder = new Label();
			this.Manager = new Label();
			this.SaveAs = new Label();
			this.Connect = new Label();
			this.FullView = new Label();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.FlowLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.ListBox1.Dock = DockStyle.Fill;
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.IntegralHeight = false;
			this.ListBox1.ItemHeight = 12;
			this.ListBox1.Location = new Point(0, 0);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new Size(367, 331);
			this.ListBox1.TabIndex = 0;
			this.Clear.AutoSize = true;
			this.Clear.Cursor = Cursors.Hand;
			this.Clear.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.Clear.ForeColor = Color.Blue;
			this.Clear.Location = new Point(120, 2);
			this.Clear.Margin = new Padding(0, 0, 1, 0);
			this.Clear.Name = "Clear";
			this.Clear.Size = new Size(29, 12);
			this.Clear.TabIndex = 6;
			this.Clear.Text = "清除";
			this.Open.AutoSize = true;
			this.Open.Cursor = Cursors.Hand;
			this.Open.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.Open.ForeColor = Color.Blue;
			this.Open.Location = new Point(60, 2);
			this.Open.Margin = new Padding(0, 0, 1, 0);
			this.Open.Name = "Open";
			this.Open.Size = new Size(29, 12);
			this.Open.TabIndex = 4;
			this.Open.Text = "打开";
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
			this.Delete.Location = new Point(90, 2);
			this.Delete.Margin = new Padding(0, 0, 1, 0);
			this.Delete.Name = "Delete";
			this.Delete.Size = new Size(29, 12);
			this.Delete.TabIndex = 0;
			this.Delete.Text = "删除";
			this.SplitContainer1.Dock = DockStyle.Fill;
			this.SplitContainer1.FixedPanel = FixedPanel.Panel2;
			this.SplitContainer1.IsSplitterFixed = true;
			this.SplitContainer1.Location = new Point(0, 0);
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Orientation = Orientation.Horizontal;
			this.SplitContainer1.Panel1.Controls.Add(this.ListBox1);
			this.SplitContainer1.Panel1MinSize = 15;
			this.SplitContainer1.Panel2.Controls.Add(this.FlowLayoutPanel1);
			this.SplitContainer1.Panel2MinSize = 16;
			this.SplitContainer1.Size = new Size(367, 353);
			this.SplitContainer1.SplitterDistance = 331;
			this.SplitContainer1.TabIndex = 3;
			this.FlowLayoutPanel1.Controls.Add(this.Add);
			this.FlowLayoutPanel1.Controls.Add(this.Folder);
			this.FlowLayoutPanel1.Controls.Add(this.Open);
			this.FlowLayoutPanel1.Controls.Add(this.Delete);
			this.FlowLayoutPanel1.Controls.Add(this.Clear);
			this.FlowLayoutPanel1.Controls.Add(this.Manager);
			this.FlowLayoutPanel1.Controls.Add(this.SaveAs);
			this.FlowLayoutPanel1.Controls.Add(this.Connect);
			this.FlowLayoutPanel1.Controls.Add(this.FullView);
			this.FlowLayoutPanel1.Dock = DockStyle.Fill;
			this.FlowLayoutPanel1.Location = new Point(0, 0);
			this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
			this.FlowLayoutPanel1.Padding = new Padding(0, 2, 0, 0);
			this.FlowLayoutPanel1.Size = new Size(367, 18);
			this.FlowLayoutPanel1.TabIndex = 9;
			this.Folder.AutoSize = true;
			this.Folder.Cursor = Cursors.Hand;
			this.Folder.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.Folder.ForeColor = Color.Blue;
			this.Folder.Location = new Point(30, 2);
			this.Folder.Margin = new Padding(0, 0, 1, 0);
			this.Folder.Name = "Folder";
			this.Folder.Size = new Size(29, 12);
			this.Folder.TabIndex = 10;
			this.Folder.Text = "目录";
			this.Manager.AutoSize = true;
			this.Manager.Cursor = Cursors.Hand;
			this.Manager.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.Manager.ForeColor = Color.Blue;
			this.Manager.Location = new Point(150, 2);
			this.Manager.Margin = new Padding(0, 0, 1, 0);
			this.Manager.Name = "Manager";
			this.Manager.Size = new Size(29, 12);
			this.Manager.TabIndex = 7;
			this.Manager.Text = "管理";
			this.Manager.Visible = false;
			this.SaveAs.AutoSize = true;
			this.SaveAs.Cursor = Cursors.Hand;
			this.SaveAs.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.SaveAs.ForeColor = Color.Blue;
			this.SaveAs.Location = new Point(180, 2);
			this.SaveAs.Margin = new Padding(0, 0, 1, 0);
			this.SaveAs.Name = "SaveAs";
			this.SaveAs.Size = new Size(29, 12);
			this.SaveAs.TabIndex = 9;
			this.SaveAs.Text = "另存";
			this.Connect.AutoSize = true;
			this.Connect.Cursor = Cursors.Hand;
			this.Connect.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.Connect.ForeColor = Color.Blue;
			this.Connect.Location = new Point(210, 2);
			this.Connect.Margin = new Padding(0, 0, 1, 0);
			this.Connect.Name = "Connect";
			this.Connect.Size = new Size(29, 12);
			this.Connect.TabIndex = 11;
			this.Connect.Text = "重连";
			this.FullView.AutoSize = true;
			this.FullView.Cursor = Cursors.Hand;
			this.FullView.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 134);
			this.FullView.ForeColor = Color.Blue;
			this.FullView.Location = new Point(240, 2);
			this.FullView.Margin = new Padding(0, 0, 1, 0);
			this.FullView.Name = "FullView";
			this.FullView.Size = new Size(29, 12);
			this.FullView.TabIndex = 12;
			this.FullView.Text = "看图";
			this.FullView.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.SplitContainer1);
			base.Name = "o..O.00.";
			base.Size = new Size(367, 353);
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel2.ResumeLayout(false);
			this.SplitContainer1.ResumeLayout(false);
			this.FlowLayoutPanel1.ResumeLayout(false);
			this.FlowLayoutPanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x000D2386 File Offset: 0x000D0586
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x000D2390 File Offset: 0x000D0590
		internal virtual ListBox ListBox1
		{
			[CompilerGenerated]
			get
			{
				return this.o0o___Oo0o_0.0.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.o_oo0_._O.);
				ListBox listBox = this.o0o___Oo0o_0.0.;
				if (listBox != null)
				{
					listBox.DoubleClick -= value2;
				}
				this.o0o___Oo0o_0.0. = value;
				listBox = this.o0o___Oo0o_0.0.;
				if (listBox != null)
				{
					listBox.DoubleClick += value2;
				}
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x000D23D3 File Offset: 0x000D05D3
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x000D23DC File Offset: 0x000D05DC
		internal virtual Label Clear
		{
			[CompilerGenerated]
			get
			{
				return this.OoO._o_.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.O0O._o000_.);
				Label ooO._o_. = this.OoO._o_.;
				if (ooO._o_. != null)
				{
					ooO._o_..Click -= value2;
				}
				this.OoO._o_. = value;
				ooO._o_. = this.OoO._o_.;
				if (ooO._o_. != null)
				{
					ooO._o_..Click += value2;
				}
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x000D241F File Offset: 0x000D061F
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x000D2428 File Offset: 0x000D0628
		internal virtual Label Open
		{
			[CompilerGenerated]
			get
			{
				return this.OoO.o.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OoOo_0ooO.O_0.);
				Label ooO.o. = this.OoO.o.;
				if (ooO.o. != null)
				{
					ooO.o..Click -= value2;
				}
				this.OoO.o. = value;
				ooO.o. = this.OoO.o.;
				if (ooO.o. != null)
				{
					ooO.o..Click += value2;
				}
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x000D246B File Offset: 0x000D066B
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x000D2474 File Offset: 0x000D0674
		internal virtual Label Add
		{
			[CompilerGenerated]
			get
			{
				return this.O.___0_o_0o0_O.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.o0O__0o.o_o.);
				Label o.___0_o_0o0_O. = this.O.___0_o_0o0_O.;
				if (o.___0_o_0o0_O. != null)
				{
					o.___0_o_0o0_O..Click -= value2;
				}
				this.O.___0_o_0o0_O. = value;
				o.___0_o_0o0_O. = this.O.___0_o_0o0_O.;
				if (o.___0_o_0o0_O. != null)
				{
					o.___0_o_0o0_O..Click += value2;
				}
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x000D24B7 File Offset: 0x000D06B7
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x000D24C0 File Offset: 0x000D06C0
		internal virtual Label Delete
		{
			[CompilerGenerated]
			get
			{
				return this.OoO.Ooo___.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.o_00.oO0.);
				Label ooO.Ooo___. = this.OoO.Ooo___.;
				if (ooO.Ooo___. != null)
				{
					ooO.Ooo___..Click -= value2;
				}
				this.OoO.Ooo___. = value;
				ooO.Ooo___. = this.OoO.Ooo___.;
				if (ooO.Ooo___. != null)
				{
					ooO.Ooo___..Click += value2;
				}
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x000D2503 File Offset: 0x000D0703
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x000D250B File Offset: 0x000D070B
		internal virtual SplitContainer SplitContainer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x000D2514 File Offset: 0x000D0714
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x000D251C File Offset: 0x000D071C
		internal virtual Label Manager
		{
			[CompilerGenerated]
			get
			{
				return this.oO.O0.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.o_._oOo0OOo.);
				Label label = this.oO.O0.;
				if (label != null)
				{
					label.Click -= value2;
				}
				this.oO.O0. = value;
				label = this.oO.O0.;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x000D255F File Offset: 0x000D075F
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x000D2567 File Offset: 0x000D0767
		internal virtual FlowLayoutPanel FlowLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x000D2570 File Offset: 0x000D0770
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x000D2578 File Offset: 0x000D0778
		internal virtual Label SaveAs
		{
			[CompilerGenerated]
			get
			{
				return this.o_O.o_Oo_oO.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.oo._00o_0_O__.);
				Label label = this.o_O.o_Oo_oO.;
				if (label != null)
				{
					label.Click -= value2;
				}
				this.o_O.o_Oo_oO. = value;
				label = this.o_O.o_Oo_oO.;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x000D25BB File Offset: 0x000D07BB
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x000D25C4 File Offset: 0x000D07C4
		internal virtual Label Folder
		{
			[CompilerGenerated]
			get
			{
				return this.Oo._O_0o.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Oo_oo0o0_0.o_O.);
				Label oo._O_0o. = this.Oo._O_0o.;
				if (oo._O_0o. != null)
				{
					oo._O_0o..Click -= value2;
				}
				this.Oo._O_0o. = value;
				oo._O_0o. = this.Oo._O_0o.;
				if (oo._O_0o. != null)
				{
					oo._O_0o..Click += value2;
				}
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x000D2607 File Offset: 0x000D0807
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x000D2610 File Offset: 0x000D0810
		internal virtual Label Connect
		{
			[CompilerGenerated]
			get
			{
				return this.O0_._ooo.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OOOOOO.0O0.);
				Label o0_._ooo. = this.O0_._ooo.;
				if (o0_._ooo. != null)
				{
					o0_._ooo..Click -= value2;
				}
				this.O0_._ooo. = value;
				o0_._ooo. = this.O0_._ooo.;
				if (o0_._ooo. != null)
				{
					o0_._ooo..Click += value2;
				}
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x000D2653 File Offset: 0x000D0853
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x000D265C File Offset: 0x000D085C
		internal virtual Label FullView
		{
			[CompilerGenerated]
			get
			{
				return this.o.0o_OoO_.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.o0O0o_O.O0.);
				Label label = this.o.0o_OoO_.;
				if (label != null)
				{
					label.Click -= value2;
				}
				this.o.0o_OoO_. = value;
				label = this.o.0o_OoO_.;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x000D269F File Offset: 0x000D089F
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x000D26A8 File Offset: 0x000D08A8
		private virtual Binding bdm
		{
			[CompilerGenerated]
			get
			{
				return this.OoO._o_.;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ConvertEventHandler value2 = new ConvertEventHandler(this.O0oO_0._o_.);
				Binding ooO._o_. = this.OoO._o_.;
				if (ooO._o_. != null)
				{
					ooO._o_..Parse -= value2;
				}
				this.OoO._o_. = value;
				ooO._o_. = this.OoO._o_.;
				if (ooO._o_. != null)
				{
					ooO._o_..Parse += value2;
				}
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x000D26EB File Offset: 0x000D08EB
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

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x000D271C File Offset: 0x000D091C
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

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x000D274E File Offset: 0x000D094E
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x000D2756 File Offset: 0x000D0956
		public bool AutoUpdate
		{
			get
			{
				return this.OO_00O.ooO0O_.;
			}
			set
			{
				this.OO_00O.ooO0O_. = value;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x000D275F File Offset: 0x000D095F
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x000D2767 File Offset: 0x000D0967
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.o0o___Oo0o_0.0.;
			}
			set
			{
				this.o0o___Oo0o_0.0. = value;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x000D2770 File Offset: 0x000D0970
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x000D2778 File Offset: 0x000D0978
		internal FTPClient FTPclient
		{
			get
			{
				return this.o0o___Oo0o_0.0.;
			}
			set
			{
				this.o0o___Oo0o_0.0. = value;
				this.Manager.Visible = (value != null);
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x000D2790 File Offset: 0x000D0990
		// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x000D2798 File Offset: 0x000D0998
		public bool DoubleClickOpen
		{
			get
			{
				return this.O.___0_o_0o0_O.;
			}
			set
			{
				this.O.___0_o_0o0_O. = value;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x000D27A1 File Offset: 0x000D09A1
		// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x000D27AC File Offset: 0x000D09AC
		public string FileString
		{
			get
			{
				return this.OoO._o_.;
			}
			set
			{
				if (Operators.CompareString(this.OoO._o_., value, true) != 0)
				{
					this.OoO._o_. = value;
					List<string> list = new List<string>();
					this.ListBox1.Items.Clear();
					if (Operators.CompareString(value, "", true) > 0)
					{
						list.AddRange(value.Split(new char[]
						{
							'\n',
							'\r'
						}, StringSplitOptions.RemoveEmptyEntries));
					}
					this.ListBox1.Items.AddRange(list.ToArray());
					if (this.ListBox1.Items.Count > 0)
					{
						this.ListBox1.SelectedIndex = 0;
					}
				}
			}
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x000D2848 File Offset: 0x000D0A48
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0oO_0._o_.())
			{
				try
				{
					foreach (string a_ in Oo00.O____0O._0.(this.Table.Current.DataRow, this.DataColumn, this.FTPclient, ""))
					{
						if (!this.O0oO_0._o_.(a_))
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
			}
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x000D28C8 File Offset: 0x000D0AC8
		internal bool <<EMPTY_NAME>>(string A_0)
		{
			bool result;
			if (Operators.CompareString(A_0, "", true) > 0)
			{
				string ooO._o_. = this.OoO._o_.;
				if (Operators.CompareString(this.OoO._o_., "", true) > 0)
				{
					this.OoO._o_. += "\r\n";
				}
				this.OoO._o_. += A_0;
				int maxLength = this.DataColumn.BaseColumn.MaxLength;
				if (this.OoO._o_..Length > maxLength && maxLength > -1)
				{
					this.OoO._o_. = ooO._o_.;
					MessageBox.Show("文件路径长度超过当前列允许输入的最大长度；请在菜单中，执行\"更改列\"命令，调整列的长度属性，或将列类型改为备注型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = false;
				}
				else
				{
					this.ListBox1.Items.Add(A_0);
					this.bd.WriteValue();
					this.ListBox1.SelectedIndex = this.ListBox1.Items.Count - 1;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x000D29A8 File Offset: 0x000D0BA8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0oO_0._o_.())
			{
				string text = Oo00.O____0O._0.(this.Table.Current.DataRow, this.DataColumn, this.FTPclient, "");
				if (Operators.CompareString(text, "", true) > 0)
				{
					this.O0oO_0._o_.(text);
				}
			}
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x000D29FC File Offset: 0x000D0BFC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0oO_0._o_.() && this.ListBox1.SelectedIndex >= 0)
			{
				string a_ = this.ListBox1.SelectedItem.ToString();
				this.o0O0o_O.O0.(a_);
			}
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x000D2A38 File Offset: 0x000D0C38
		internal void <<EMPTY_NAME>>(string A_0)
		{
			int num = -1;
			int num2 = this.ListBox1.Items.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (Operators.CompareString(this.ListBox1.Items[i].ToString(), A_0, true) == 0)
				{
					num = i;
					break;
				}
			}
			if (num != -1)
			{
				if (!A_0.StartsWith("[") || !A_0.EndsWith("]"))
				{
					DataRow dataRow = this.Table.Current.DataRow;
					DataCol a_ = this.DataColumn;
					if (!Oo00.OO.0O0o.(dataRow, a_, A_0))
					{
						return;
					}
				}
				this.ListBox1.Items.RemoveAt(num);
				string text = "";
				int num3 = this.ListBox1.Items.Count - 1;
				for (int j = 0; j <= num3; j++)
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += "\r\n";
					}
					text += this.ListBox1.Items[j].ToString();
				}
				this.OoO._o_. = text;
				this.bd.WriteValue();
				if (num <= this.ListBox1.Items.Count - 1)
				{
					this.ListBox1.SelectedIndex = num;
					return;
				}
				if (this.ListBox1.Items.Count > 0)
				{
					this.ListBox1.SelectedIndex = this.ListBox1.Items.Count - 1;
				}
			}
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x000D2BA8 File Offset: 0x000D0DA8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0oO_0._o_.())
			{
				DataRow dataRow = this.Table.Current.DataRow;
				DataCol a_ = this.DataColumn;
				while (this.ListBox1.Items.Count > 0)
				{
					string a_2 = this.ListBox1.Items[0].ToString();
					if (!Oo00.OO.0O0o.(dataRow, a_, a_2))
					{
						break;
					}
					this.ListBox1.Items.RemoveAt(0);
				}
				if (this.ListBox1.Items.Count == 0)
				{
					this.OoO._o_. = "";
				}
				else
				{
					string text = "";
					int num = this.ListBox1.Items.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(text, "", true) > 0)
						{
							text += "\r\n";
						}
						text += this.ListBox1.Items[i].ToString();
					}
					this.OoO._o_. = text;
				}
				this.bd.WriteValue();
			}
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x000D2CB4 File Offset: 0x000D0EB4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Open.Enabled && this.ListBox1.SelectedIndex >= 0)
			{
				DataRow dataRow = this.Table.Current.DataRow;
				DataCol a_ = this.DataColumn;
				string text = this.ListBox1.SelectedItem.ToString();
				if (this.FTPclient != null)
				{
					FTPDownloadEventArgs ftpdownloadEventArgs = new FTPDownloadEventArgs(text, DateTime.MinValue, this.FTPclient.FTPName);
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeDownload", new object[]
					{
						ftpdownloadEventArgs
					}, true, "FTP", false);
					if (ftpdownloadEventArgs.Cancel || ftpdownloadEventArgs.CancelAll)
					{
						return;
					}
				}
				bool flag = Oo00.o00O0O_.O.(dataRow, a_, this.FTPclient, text, this.AutoUpdate);
				if (this.FTPclient != null && flag)
				{
					FTPDownloadEventArgs ftpdownloadEventArgs2 = new FTPDownloadEventArgs(text, DateTime.MinValue, this.FTPclient.FTPName);
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterDownload", new object[]
					{
						ftpdownloadEventArgs2
					}, true, "FTP", false);
				}
			}
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x000D2DB9 File Offset: 0x000D0FB9
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Open.Enabled && this.DoubleClickOpen)
			{
				this.OoOo_0ooO.O_0.(this.Open, new EventArgs());
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x000D2DE4 File Offset: 0x000D0FE4
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

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x000D2E4C File Offset: 0x000D104C
		internal DataCol DataColumn
		{
			get
			{
				DataTable dataTable = ((O_0)this.bd.DataSource).o_o.O0ooOo.();
				return OO_00oOO.DataTables[dataTable.TableName].DataCols[this.bd.BindingMemberInfo.BindingField];
			}
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x000D2E9C File Offset: 0x000D109C
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

		// Token: 0x06001EB5 RID: 7861 RVA: 0x000D2FB4 File Offset: 0x000D11B4
		private void <<EMPTY_NAME>>(object A_0, ConvertEventArgs A_1)
		{
			DataRowView dataRowView = (DataRowView)this.bd.BindingManagerBase.Current;
			string bindingField = this.bd.BindingMemberInfo.BindingField;
			if (Operators.CompareString(A_1.Value.ToString(), dataRowView[bindingField].ToString(), true) != 0)
			{
				this.Table.O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.Table, dataRowView.Row, bindingField));
			}
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x000D302C File Offset: 0x000D122C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O.OO_o0. == null)
			{
				this.O.OO_o0. = this.FTPclient.O_O_0_O0.oOO.();
				this.O.OO_o0..Ooo_Oo_O0.00O. = this.FTPclient.Ooo_Oo_O0.00O.;
			}
			this.O.OO_o0..OpenManager();
			this.FTPclient.Ooo_Oo_O0.00O. = this.O.OO_o0..Ooo_Oo_O0.00O.;
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x000D308C File Offset: 0x000D128C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.ListBox1.SelectedIndex >= 0)
			{
				DataRow dataRow = this.Table.Current.DataRow;
				DataCol a_ = this.DataColumn;
				string text = this.ListBox1.SelectedItem.ToString();
				if (!text.StartsWith("[") || !text.EndsWith("]"))
				{
					Oo00.o0_o._O_.(dataRow, a_, this.FTPclient, text, this.AutoUpdate);
				}
			}
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x000D3100 File Offset: 0x000D1300
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

		// Token: 0x06001EB9 RID: 7865 RVA: 0x000D315C File Offset: 0x000D135C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.FTPclient == null)
			{
				this.Connect.Visible = false;
			}
			if (base.Parent == null && this.FTPclient != null)
			{
				if (this.FTPclient.Connected)
				{
					this.FTPclient.Close();
				}
				this.FTPclient = null;
			}
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x000D31AC File Offset: 0x000D13AC
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
				pictureViewer.Manager.Enabled = this.Manager.Enabled;
				pictureViewer.lblConnect.Enabled = this.Connect.Enabled;
				pictureViewer.Add.Visible = this.Add.Visible;
				pictureViewer.Delete.Visible = this.Delete.Visible;
				pictureViewer.Clear.Visible = this.Clear.Visible;
				pictureViewer.Open.Visible = this.Open.Visible;
				pictureViewer.Manager.Visible = this.Manager.Visible;
				pictureViewer.lblConnect.Visible = this.Connect.Visible;
				base.DataBindings[0].WriteValue();
				o_u3000__u3000_u3002_u3002_u3002_u3000_u.O.oO0_.().DataBindings.Add("ImageFiles", RuntimeHelpers.GetObjectValue(base.DataBindings[0].DataSource), base.DataBindings[0].BindingMemberInfo.BindingMember);
				o_u3000__u3000_u3002_u3002_u3002_u3000_u.ShowDialog();
				o_u3000__u3000_u3002_u3002_u3002_u3000_u.Dispose();
				base.DataBindings[0].ReadValue();
			}
		}

		// Token: 0x04000CDC RID: 3292
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000CDD RID: 3293
		[AccessedThroughProperty("ListBox1")]
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x04000CDE RID: 3294
		[AccessedThroughProperty("Clear")]
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CDF RID: 3295
		[CompilerGenerated]
		[AccessedThroughProperty("Open")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CE0 RID: 3296
		[CompilerGenerated]
		[AccessedThroughProperty("Add")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CE1 RID: 3297
		[CompilerGenerated]
		[AccessedThroughProperty("Delete")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CE2 RID: 3298
		[AccessedThroughProperty("SplitContainer1")]
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x04000CE3 RID: 3299
		[CompilerGenerated]
		[AccessedThroughProperty("Manager")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CE4 RID: 3300
		[AccessedThroughProperty("FlowLayoutPanel1")]
		[CompilerGenerated]
		private FlowLayoutPanel <<EMPTY_NAME>>;

		// Token: 0x04000CE5 RID: 3301
		[CompilerGenerated]
		[AccessedThroughProperty("SaveAs")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CE6 RID: 3302
		[CompilerGenerated]
		[AccessedThroughProperty("Folder")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CE7 RID: 3303
		[CompilerGenerated]
		[AccessedThroughProperty("Connect")]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CE8 RID: 3304
		[AccessedThroughProperty("FullView")]
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CE9 RID: 3305
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000CEA RID: 3306
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000CEB RID: 3307
		private string <<EMPTY_NAME>>;

		// Token: 0x04000CEC RID: 3308
		private FTPClient <<EMPTY_NAME>>;

		// Token: 0x04000CED RID: 3309
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000CEE RID: 3310
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000CEF RID: 3311
		[CompilerGenerated]
		[AccessedThroughProperty("bdm")]
		private Binding <<EMPTY_NAME>>;

		// Token: 0x04000CF0 RID: 3312
		private FTPClient <<EMPTY_NAME>>;
	}
}
