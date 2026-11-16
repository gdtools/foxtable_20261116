using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000458 RID: 1112
	[DesignerGenerated]
	internal partial class k2 : Form
	{
		// Token: 0x06004AC0 RID: 19136 RVA: 0x0021B6F4 File Offset: 0x002198F4
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oo.oo__o_. != null)
				{
					this.oo.oo__o_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x0021B734 File Offset: 0x00219934
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oo.oo__o_. = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(k2));
			this.o0O0o_O.0O0O.(new C1FlexGrid());
			this.o00.____O_ooo_.(new C1Button());
			this.o._0oO.(new C1Button());
			this.O_000.o0O___o.(new C1Button());
			this.O_.o_oO.(new C1Button());
			this.o_.OOo0.(new C1Button());
			this.o_0OO.o_.(new C1TextBox());
			this.oo00Oo_.o.(new C1Button());
			this.o_0OO.o_.(new C1FlexGrid());
			this.o_0OO.o_.(new Timer(this.oo.oo__o_.));
			this.o0O0o_O.0O0O.(new C1TextBox());
			this.o0O0o_O.0O0O.(new Label());
			this.o.oO0000.(new C1Button());
			this.O0Oo0_O__OoO.o.(new C1Button());
			this.o_0OO.o_.(new Label());
			this.o_0OO.o_.(new C1ComboBox());
			((ISupportInitialize)this.OO_._.()).BeginInit();
			((ISupportInitialize)this.o_O0.O__.()).BeginInit();
			base.SuspendLayout();
			this.OO_._.().AllowDragging = AllowDraggingEnum.None;
			this.OO_._.().AllowEditing = false;
			this.OO_._.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.OO_._.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo");
			this.OO_._.().ExtendLastCol = true;
			this.OO_._.().FocusRect = FocusRectEnum.None;
			this.OO_._.().Location = new Point(13, 41);
			this.OO_._.().Name = "C1FlexGrid1";
			this.OO_._.().Rows.Count = 2;
			this.OO_._.().Rows.DefaultSize = 19;
			this.OO_._.().SelectionMode = SelectionModeEnum.ListBox;
			this.OO_._.().Size = new Size(661, 280);
			this.OO_._.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo");
			this.OO_._.().TabIndex = 0;
			this.OO_._.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
			this.OOOO0.oOo_O_.().Image = (Image)componentResourceManager.GetObject("btnUpload.Image");
			this.OOOO0.oOo_O_.().ImageAlign = ContentAlignment.MiddleLeft;
			this.OOOO0.oOo_O_.().Location = new Point(12, 327);
			this.OOOO0.oOo_O_.().Name = "btnUpload";
			this.OOOO0.oOo_O_.().Size = new Size(75, 23);
			this.OOOO0.oOo_O_.().TabIndex = 1;
			this.OOOO0.oOo_O_.().Text = "上传";
			this.OOOO0.oOo_O_.().UseVisualStyleBackColor = true;
			this.o_O0.O__.().Image = (Image)componentResourceManager.GetObject("btnDownload.Image");
			this.o_O0.O__.().ImageAlign = ContentAlignment.MiddleLeft;
			this.o_O0.O__.().Location = new Point(93, 327);
			this.o_O0.O__.().Name = "btnDownload";
			this.o_O0.O__.().Size = new Size(75, 23);
			this.o_O0.O__.().TabIndex = 2;
			this.o_O0.O__.().Text = "下载";
			this.o_O0.O__.().UseVisualStyleBackColor = true;
			this.o_._O_.().Location = new Point(336, 327);
			this.o_._O_.().Name = "btnRename";
			this.o_._O_.().Size = new Size(75, 23);
			this.o_._O_.().TabIndex = 3;
			this.o_._O_.().Text = "重命名";
			this.o_._O_.().UseVisualStyleBackColor = true;
			this.O._o__.().Location = new Point(255, 327);
			this.O._o__.().Name = "btnDelete";
			this.O._o__.().Size = new Size(75, 23);
			this.O._o__.().TabIndex = 4;
			this.O._o__.().Text = "删除";
			this.O._o__.().UseVisualStyleBackColor = true;
			this.o.00O.().Location = new Point(417, 327);
			this.o.00O.().Name = "btnMakeDir";
			this.o.00O.().Size = new Size(75, 23);
			this.o.00O.().TabIndex = 6;
			this.o.00O.().Text = "新建目录";
			this.o.00O.().UseVisualStyleBackColor = true;
			this.ooooOoo.0OOo0.().BackColor = SystemColors.Window;
			this.ooooOoo.0OOo0.().ForeColor = Color.Blue;
			this.ooooOoo.0OOo0.().Location = new Point(13, 356);
			this.ooooOoo.0OOo0.().Multiline = true;
			this.ooooOoo.0OOo0.().Name = "TextBox1";
			this.ooooOoo.0OOo0.().ReadOnly = true;
			this.ooooOoo.0OOo0.().ScrollBars = ScrollBars.Vertical;
			this.ooooOoo.0OOo0.().Size = new Size(661, 84);
			this.ooooOoo.0OOo0.().TabIndex = 7;
			this.OO_._.().Image = (Image)componentResourceManager.GetObject("btnRefresh.Image");
			this.OO_._.().ImageAlign = ContentAlignment.MiddleLeft;
			this.OO_._.().Location = new Point(599, 327);
			this.OO_._.().Name = "btnRefresh";
			this.OO_._.().Size = new Size(75, 23);
			this.OO_._.().TabIndex = 10;
			this.OO_._.().Text = "刷新";
			this.OO_._.().UseVisualStyleBackColor = true;
			this.o_O0.O__.().AllowDragging = AllowDraggingEnum.None;
			this.o_O0.O__.().AllowEditing = false;
			this.o_O0.O__.().AllowResizing = AllowResizingEnum.None;
			this.o_O0.O__.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.o_O0.O__.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid2.ColumnInfo");
			this.o_O0.O__.().ExtendLastCol = true;
			this.o_O0.O__.().HighLight = HighLightEnum.WithFocus;
			this.o_O0.O__.().Location = new Point(13, 446);
			this.o_O0.O__.().Name = "C1FlexGrid2";
			this.o_O0.O__.().Rows.Count = 1;
			this.o_O0.O__.().Rows.DefaultSize = 19;
			this.o_O0.O__.().SelectionMode = SelectionModeEnum.Cell;
			this.o_O0.O__.().Size = new Size(662, 105);
			this.o_O0.O__.().StyleInfo = componentResourceManager.GetString("C1FlexGrid2.StyleInfo");
			this.o_O0.O__.().TabIndex = 11;
			this.o_O0.O__.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
			this.oo.O_0_O00_O0_.().Enabled = true;
			this.oo.O_0_O00_O0_.().Interval = 300;
			this.oo.O_0_O00_O0_.().Location = new Point(77, 559);
			this.oo.O_0_O00_O0_.().Name = "txtLocFolder";
			this.oo.O_0_O00_O0_.().ReadOnly = true;
			this.oo.O_0_O00_O0_.().Size = new Size(555, 21);
			this.oo.O_0_O00_O0_.().TabIndex = 13;
			this.oo.O_0_O00_O0_.().AutoSize = true;
			this.oo.O_0_O00_O0_.().Location = new Point(12, 562);
			this.oo.O_0_O00_O0_.().Name = "Label1";
			this.oo.O_0_O00_O0_.().Size = new Size(59, 12);
			this.oo.O_0_O00_O0_.().TabIndex = 15;
			this.oo.O_0_O00_O0_.().Text = "本地路径:";
			this.O0oO.00OO0O000.().Location = new Point(638, 557);
			this.O0oO.00OO0O000.().Name = "btnOpenLocFolder";
			this.O0oO.00OO0O000.().Size = new Size(37, 23);
			this.O0oO.00OO0O000.().TabIndex = 16;
			this.O0oO.00OO0O000.().UseVisualStyleBackColor = true;
			this.OOo_.0o0.().ImageAlign = ContentAlignment.MiddleLeft;
			this.OOo_.0o0.().Location = new Point(174, 327);
			this.OOo_.0o0.().Name = "btnOpen";
			this.OOo_.0o0.().Size = new Size(75, 23);
			this.OOo_.0o0.().TabIndex = 17;
			this.OOo_.0o0.().Text = "打开";
			this.OOo_.0o0.().UseVisualStyleBackColor = true;
			this.ooooOoo.0OOo0.().AutoSize = true;
			this.ooooOoo.0OOo0.().Location = new Point(11, 15);
			this.ooooOoo.0OOo0.().Name = "Label2";
			this.ooooOoo.0OOo0.().Size = new Size(53, 12);
			this.ooooOoo.0OOo0.().TabIndex = 18;
			this.ooooOoo.0OOo0.().Text = "FTP路径:";
			this.oo.O_0_O00_O0_.().Location = new Point(70, 12);
			this.oo.O_0_O00_O0_.().Name = "cmbFTPPath";
			this.oo.O_0_O00_O0_.().Size = new Size(604, 20);
			this.oo.O_0_O00_O0_.().TabIndex = 19;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(687, 590);
			base.Controls.Add(this.oo.O_0_O00_O0_.());
			base.Controls.Add(this.ooooOoo.0OOo0.());
			base.Controls.Add(this.OOo_.0o0.());
			base.Controls.Add(this.O0oO.00OO0O000.());
			base.Controls.Add(this.oo.O_0_O00_O0_.());
			base.Controls.Add(this.oo.O_0_O00_O0_.());
			base.Controls.Add(this.o_O0.O__.());
			base.Controls.Add(this.OO_._.());
			base.Controls.Add(this.ooooOoo.0OOo0.());
			base.Controls.Add(this.OOOO0.oOo_O_.());
			base.Controls.Add(this.o.00O.());
			base.Controls.Add(this.o_O0.O__.());
			base.Controls.Add(this.OO_._.());
			base.Controls.Add(this.o_._O_.());
			base.Controls.Add(this.O._o__.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.O.....";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "远程文件管理器";
			((ISupportInitialize)this.OO_._.()).EndInit();
			((ISupportInitialize)this.o_O0.O__.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x0021C158 File Offset: 0x0021A358
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O__O0.o_o.;
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x0021C160 File Offset: 0x0021A360
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			SortColEventHandler value = new SortColEventHandler(this.oO_Oo.00o.);
			EventHandler value2 = new EventHandler(this.OO.o_O_0o0OO.);
			KeyEventHandler value3 = new KeyEventHandler(this.o_000._.);
			OwnerDrawCellEventHandler value4 = new OwnerDrawCellEventHandler(this.O0.o0O0_.);
			C1FlexGrid o__O0.o_o. = this.O__O0.o_o.;
			if (o__O0.o_o. != null)
			{
				o__O0.o_o..AfterSort -= value;
				o__O0.o_o..DoubleClick -= value2;
				o__O0.o_o..KeyDown -= value3;
				o__O0.o_o..OwnerDrawCell -= value4;
			}
			this.O__O0.o_o. = A_0;
			o__O0.o_o. = this.O__O0.o_o.;
			if (o__O0.o_o. != null)
			{
				o__O0.o_o..AfterSort += value;
				o__O0.o_o..DoubleClick += value2;
				o__O0.o_o..KeyDown += value3;
				o__O0.o_o..OwnerDrawCell += value4;
			}
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x0021C200 File Offset: 0x0021A400
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O__O0.o_o.;
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x0021C208 File Offset: 0x0021A408
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo000.0.);
			C1Button o__O0.o_o. = this.O__O0.o_o.;
			if (o__O0.o_o. != null)
			{
				o__O0.o_o..Click -= value;
			}
			this.O__O0.o_o. = A_0;
			o__O0.o_o. = this.O__O0.o_o.;
			if (o__O0.o_o. != null)
			{
				o__O0.o_o..Click += value;
			}
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x0021C24B File Offset: 0x0021A44B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_.Oo.;
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x0021C254 File Offset: 0x0021A454
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_0_o0.o.);
			C1Button c1Button = this.o_.Oo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_.Oo. = A_0;
			c1Button = this.o_.Oo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x0021C297 File Offset: 0x0021A497
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O._o0o__o0O_0O.;
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x0021C2A0 File Offset: 0x0021A4A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO_O.0_oOoO.);
			C1Button o._o0o__o0O_0O. = this.O._o0o__o0O_0O.;
			if (o._o0o__o0O_0O. != null)
			{
				o._o0o__o0O_0O..Click -= value;
			}
			this.O._o0o__o0O_0O. = A_0;
			o._o0o__o0O_0O. = this.O._o0o__o0O_0O.;
			if (o._o0o__o0O_0O. != null)
			{
				o._o0o__o0O_0O..Click += value;
			}
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x0021C2E3 File Offset: 0x0021A4E3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO__o._o__oO00.;
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x0021C2EC File Offset: 0x0021A4EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Ooo0o._O.);
			C1Button c1Button = this.oO__o._o__oO00.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO__o._o__oO00. = A_0;
			c1Button = this.oO__o._o__oO00.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x0021C32F File Offset: 0x0021A52F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO0.O__0_o.;
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x0021C338 File Offset: 0x0021A538
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0Oo_0_O_o.O.);
			C1Button c1Button = this.oO0.O__0_o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO0.O__0_o. = A_0;
			c1Button = this.oO0.O__0_o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x0021C37B File Offset: 0x0021A57B
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O__O0.o_o.;
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x0021C383 File Offset: 0x0021A583
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O__O0.o_o. = A_0;
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x0021C38C File Offset: 0x0021A58C
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O00.___.;
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x0021C394 File Offset: 0x0021A594
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OOo._O0o0O0_0.);
			C1Button o00.___. = this.O00.___.;
			if (o00.___. != null)
			{
				o00.___..Click -= value;
			}
			this.O00.___. = A_0;
			o00.___. = this.O00.___.;
			if (o00.___. != null)
			{
				o00.___..Click += value;
			}
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x0021C3D7 File Offset: 0x0021A5D7
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.Oo.____o0_.;
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x0021C3E0 File Offset: 0x0021A5E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			KeyEventHandler value = new KeyEventHandler(this.o00_.___.);
			OwnerDrawCellEventHandler value2 = new OwnerDrawCellEventHandler(this.o__o0O0_._0.);
			C1FlexGrid oo.____o0_. = this.Oo.____o0_.;
			if (oo.____o0_. != null)
			{
				oo.____o0_..KeyDown -= value;
				oo.____o0_..OwnerDrawCell -= value2;
			}
			this.Oo.____o0_. = A_0;
			oo.____o0_. = this.Oo.____o0_.;
			if (oo.____o0_. != null)
			{
				oo.____o0_..KeyDown += value;
				oo.____o0_..OwnerDrawCell += value2;
			}
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x0021C43E File Offset: 0x0021A63E
		[CompilerGenerated]
		internal virtual Timer <<EMPTY_NAME>>()
		{
			return this.O__O0.o_o.;
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x0021C448 File Offset: 0x0021A648
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Timer A_0)
		{
			EventHandler value = new EventHandler(this.O00.___.);
			Timer o__O0.o_o. = this.O__O0.o_o.;
			if (o__O0.o_o. != null)
			{
				o__O0.o_o..Tick -= value;
			}
			this.O__O0.o_o. = A_0;
			o__O0.o_o. = this.O__O0.o_o.;
			if (o__O0.o_o. != null)
			{
				o__O0.o_o..Tick += value;
			}
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x0021C48B File Offset: 0x0021A68B
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O0O0OO0_oO0.o0.;
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x0021C493 File Offset: 0x0021A693
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O0O0OO0_oO0.o0. = A_0;
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x0021C49C File Offset: 0x0021A69C
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O__O0.o_o.;
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x0021C4A4 File Offset: 0x0021A6A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O__O0.o_o. = A_0;
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x0021C4AD File Offset: 0x0021A6AD
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOO__OOoo0.O.;
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x0021C4B8 File Offset: 0x0021A6B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OOo__._00O00OO.);
			C1Button c1Button = this.oOO__OOoo0.O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOO__OOoo0.O. = A_0;
			c1Button = this.oOO__OOoo0.O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x0021C4FB File Offset: 0x0021A6FB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO_.oo_O_0_.;
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x0021C504 File Offset: 0x0021A704
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_000._.);
			C1Button c1Button = this.oO_.oo_O_0_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO_.oo_O_0_. = A_0;
			c1Button = this.oO_.oo_O_0_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x0021C547 File Offset: 0x0021A747
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo.____o0_.;
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x0021C54F File Offset: 0x0021A74F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo.____o0_. = A_0;
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x0021C558 File Offset: 0x0021A758
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O__O0.o_o.;
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x0021C560 File Offset: 0x0021A760
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.o00_.___.);
			KeyEventHandler value2 = new KeyEventHandler(this.o__o0O0_._0.);
			KeyPressEventHandler value3 = new KeyPressEventHandler(this.o__o0O0_._0.);
			EventHandler value4 = new EventHandler(this.o__o0O0_._0.);
			C1ComboBox o__O0.o_o. = this.O__O0.o_o.;
			if (o__O0.o_o. != null)
			{
				o__O0.o_o..Enter -= value;
				o__O0.o_o..KeyDown -= value2;
				o__O0.o_o..KeyPress -= value3;
				o__O0.o_o..SelectedIndexChanged -= value4;
			}
			this.O__O0.o_o. = A_0;
			o__O0.o_o. = this.O__O0.o_o.;
			if (o__O0.o_o. != null)
			{
				o__O0.o_o..Enter += value;
				o__O0.o_o..KeyDown += value2;
				o__O0.o_o..KeyPress += value3;
				o__O0.o_o..SelectedIndexChanged += value4;
			}
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x0021C600 File Offset: 0x0021A800
		[CompilerGenerated]
		private virtual FTPClient <<EMPTY_NAME>>()
		{
			return this.O__O0.o_o.;
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x0021C608 File Offset: 0x0021A808
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(FTPClient A_0)
		{
			FTPClient.OooO_O0O_0_O a_ = new FTPClient.OooO_O0O_0_O(this.Oo_o_o0.O__oOo.);
			FTPClient.OoO_00_o a_2 = new FTPClient.OoO_00_o(this.O00_0.o00OO.);
			FTPClient.OOOOO00OoOOo a_3 = new FTPClient.OOOOO00OoOOo(this.O00_0.o00OO.);
			FTPClient o__O0.o_o. = this.O__O0.o_o.;
			if (o__O0.o_o. != null)
			{
				o__O0.o_o..ServerConnected -= a_;
				o__O0.o_o..ShowError -= a_2;
				o__O0.o_o..ShowMessage -= a_3;
			}
			this.O__O0.o_o. = A_0;
			o__O0.o_o. = this.O__O0.o_o.;
			if (o__O0.o_o. != null)
			{
				o__O0.o_o..ServerConnected += a_;
				o__O0.o_o..ShowError += a_2;
				o__O0.o_o..ShowMessage += a_3;
			}
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x0021C681 File Offset: 0x0021A881
		[CompilerGenerated]
		private virtual FTPClient <<EMPTY_NAME>>()
		{
			return this.Oo.____o0_.;
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x0021C68C File Offset: 0x0021A88C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(FTPClient A_0)
		{
			FTPClient.O__0O000__Oo a_ = new FTPClient.O__0O000__Oo(this.Oo_o_o0.O__oOo.);
			FTPClient.oO_o_0OOo__0 a_2 = new FTPClient.oO_o_0OOo__0(this.O00oO_o.OO.);
			FTPClient.o0O_O00o_0_o a_3 = new FTPClient.o0O_O00o_0_o(this.Oo_o_o0.O__oOo.);
			FTPClient.o0_O_0_0 a_4 = new FTPClient.o0_O_0_0(this.Oo_o_o0.O__oOo.);
			FTPClient.OoO_00_o a_5 = new FTPClient.OoO_00_o(this.O00_0.o00OO.);
			FTPClient.OOOOO00OoOOo a_6 = new FTPClient.OOOOO00OoOOo(this.O00_0.o00OO.);
			FTPClient.ooo__O a_7 = new FTPClient.ooo__O(this.Oo_o_o0.O__oOo.);
			FTPClient.oO___ a_8 = new FTPClient.oO___(this.Oo_o_o0.O__oOo.);
			FTPClient oo.____o0_. = this.Oo.____o0_.;
			if (oo.____o0_. != null)
			{
				oo.____o0_..DownloadError -= a_;
				oo.____o0_..DownloadCompleted -= a_2;
				oo.____o0_..DownloadProgressChanged -= a_3;
				oo.____o0_..UploadProgressChanged -= a_4;
				oo.____o0_..ShowError -= a_5;
				oo.____o0_..ShowMessage -= a_6;
				oo.____o0_..UploadError -= a_7;
				oo.____o0_..UploadCompleted -= a_8;
			}
			this.Oo.____o0_. = A_0;
			oo.____o0_. = this.Oo.____o0_.;
			if (oo.____o0_. != null)
			{
				oo.____o0_..DownloadError += a_;
				oo.____o0_..DownloadCompleted += a_2;
				oo.____o0_..DownloadProgressChanged += a_3;
				oo.____o0_..UploadProgressChanged += a_4;
				oo.____o0_..ShowError += a_5;
				oo.____o0_..ShowMessage += a_6;
				oo.____o0_..UploadError += a_7;
				oo.____o0_..UploadCompleted += a_8;
			}
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x0021C7AC File Offset: 0x0021A9AC
		public k2(FTPClient A_0, string A_1)
		{
			base.Activated += this.oOoOo___oO.o_.;
			base.FormClosed += this.Oo_o_o0.O__oOo.;
			base.FormClosing += this.Oo_o_o0.O__oOo.;
			this.ooooOoo.0OOo0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.ooooOoo.0OOo0.().BackColor = Color.White;
			this.ooooOoo.0OOo0.().ForeColor = SystemColors.WindowText;
			this.OO_._.().Styles.SelectedColumnHeader.Clear();
			this.o_0OO.o_.(A_0);
			this.oo.oo__o_. = A_1;
			this.OO_._.().Styles.Focus.MergeWith(this.OO_._.().Styles.Highlight);
			this.OO_._.().DrawMode = DrawModeEnum.OwnerDraw;
			this.o_O0.O__.().DrawMode = DrawModeEnum.OwnerDraw;
			this.OO_._.().Cols[1].Format = "yyyy-MM-dd HH:mm";
			this.OOOO0.oOo_O_.().Enabled = A_0.UploadEnabled;
			this.o_O0.O__.().Enabled = A_0.DownloadEnabled;
			this.o_._O_.().Enabled = A_0.RenameEnabled;
			this.O._o__.().Enabled = A_0.DeleteEnabled;
			this.o.00O.().Enabled = A_0.MakerDirEnabled;
			this.OOo_.0o0.().Enabled = A_0.OpenFileEnabled;
			this.o0O0o_O.0O0O.(new FTPClient());
			this.oo.O_0_O00_O0_.().Host = this.ooooOoo.0OOo0.().Host;
			this.oo.O_0_O00_O0_.().Account = this.ooooOoo.0OOo0.().Account;
			this.oo.O_0_O00_O0_.().Password = this.ooooOoo.0OOo0.().Password;
			this.oo.O_0_O00_O0_.().Port = this.ooooOoo.0OOo0.().Port;
			this.oo.O_0_O00_O0_.().UTF8 = this.ooooOoo.0OOo0.().UTF8;
			this.oo.O_0_O00_O0_.().FTPName = this.ooooOoo.0OOo0.().FTPName;
			this.oo.O_0_O00_O0_.().O_OO.OOO_OOO. = false;
			this.o_O0.O__.().Styles.Add("error", this.o_O0.O__.().Styles.Normal).ForeColor = Color.Red;
			NetworkChange.NetworkAvailabilityChanged += this.o.oO0000.;
			NetworkChange.NetworkAddressChanged += this.o._0oO.;
			this.O0oO.00OO0O000.().Image = a.O00o_Ooo.0.();
			this.oo.O_0_O00_O0_.().Value = OO_00oOO.ProjectPath + "RemoteFiles";
			if (!OO_00oOO.FileSys.DirectoryExists(this.oo.O_0_O00_O0_.().Text))
			{
				OO_00oOO.FileSys.CreateDirectory(this.oo.O_0_O00_O0_.().Text);
			}
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x0021CA54 File Offset: 0x0021AC54
		private void <<EMPTY_NAME>>(string A_0)
		{
			if (this.ooooOoo.0OOo0.().FindForm() != null && !this.ooooOoo.0OOo0.().FindForm().IsDisposed)
			{
				if (Operators.CompareString(this.ooooOoo.0OOo0.().Text, "", true) > 0)
				{
					this.ooooOoo.0OOo0.().AppendText("\r\n");
					this.ooooOoo.0OOo0.().AppendText(A_0.Trim());
					return;
				}
				this.ooooOoo.0OOo0.().AppendText(A_0.Trim());
			}
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x0021CACC File Offset: 0x0021ACCC
		private void <<EMPTY_NAME>>(string A_0)
		{
			int num = this.o_O0.O__.().FindRow(A_0, 1, 0, false, true, false);
			if (num > 0)
			{
				string left = "";
				if (this.o_O0.O__.().GetData(num, 5) != null)
				{
					left = this.o_O0.O__.().GetData(num, 5).ToString();
				}
				A_0 = this.o_O0.O__.().GetData(num, 4).ToString();
				this.o_O0.O__.().RemoveItem(num);
				if (Operators.CompareString(left, "1", true) == 0)
				{
					Process.Start(A_0);
				}
			}
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x0021CB4C File Offset: 0x0021AD4C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Application.DoEvents();
			if (this.O0_O0._OO_. == 0 && this.ooooOoo.0OOo0.().Connect())
			{
				this.O0_O0._OO_. = 1;
				if (Operators.CompareString(this.oo.oo__o_., "", true) > 0)
				{
					this.ooooOoo.0OOo0.().ChangeDir(this.oo.oo__o_.);
					this.oo.oo__o_. = "";
				}
				this.ooooOoo.0OOo0.(false);
				this.oo.O_0_O00_O0_.().Value = this.ooooOoo.0OOo0.().CurrentDir;
			}
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x0021CBC8 File Offset: 0x0021ADC8
		private void <<EMPTY_NAME>>(bool A_0)
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
				if (!this.ooooOoo.0OOo0.().Ooo_Oo_O0.00O..ContainsKey(this.ooooOoo.0OOo0.().CurrentDir) || A_0)
				{
					goto IL_49;
				}
				IL_29:
				num2 = 3;
				List<string> a_ = this.ooooOoo.0OOo0.().Ooo_Oo_O0.00O.[this.ooooOoo.0OOo0.().CurrentDir];
				goto IL_5C;
				IL_49:
				num2 = 5;
				a_ = this.ooooOoo.0OOo0.().GetDetailList("");
				IL_5C:
				num2 = 6;
				FTPBeforeListDetailsEventArgs ftpbeforeListDetailsEventArgs = new FTPBeforeListDetailsEventArgs(this.ooooOoo.0OOo0.().CurrentDir, a_, this.ooooOoo.0OOo0.().FTPName);
				IL_7C:
				num2 = 7;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeListDetails", new object[]
				{
					ftpbeforeListDetailsEventArgs
				}, true, "FTP", false);
				IL_A0:
				num2 = 8;
				string[] array = ftpbeforeListDetailsEventArgs.RemovedItems;
				IL_AB:
				num2 = 9;
				this.OO_._.().Rows.Count = 1;
				IL_BF:
				num2 = 10;
				this.OO_._.().BeginUpdate();
				IL_CD:
				num2 = 11;
				List<string[]>.Enumerator enumerator = ftpbeforeListDetailsEventArgs.Infos.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string[] array2 = enumerator.Current;
					IL_EC:
					num2 = 12;
					if (Operators.CompareString(array2[2], "D", true) == 0)
					{
						IL_100:
						num2 = 14;
						if (Array.BinarySearch<string>(array, array2[0]) < 0)
						{
							IL_111:
							num2 = 16;
							this.OO_._.().AddItem(string.Concat(new string[]
							{
								array2[0],
								"\t",
								array2[1],
								"\t \t",
								Conversions.ToString(1)
							}));
							IL_152:
							num2 = 17;
							this.OO_._.().SetCellImage(this.OO_._.().Rows.Count - 1, 0, a.oO0O_O.__oo.().ToBitmap());
						}
					}
					IL_17D:
					num2 = 18;
				}
				IL_18C:
				num2 = 19;
				((IDisposable)enumerator).Dispose();
				IL_19C:
				num2 = 20;
				List<string[]>.Enumerator enumerator2 = ftpbeforeListDetailsEventArgs.Infos.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string[] array3 = enumerator2.Current;
					IL_1BB:
					num2 = 21;
					if (Operators.CompareString(array3[2], "D", true) != 0)
					{
						IL_1D2:
						num2 = 23;
						if (Array.BinarySearch<string>(array, array3[0]) < 0)
						{
							IL_1E6:
							num2 = 25;
							this.OO_._.().AddItem(string.Concat(new string[]
							{
								array3[0],
								"\t",
								array3[1],
								"\t",
								array3[2],
								"\t",
								Conversions.ToString(2)
							}));
							IL_236:
							num2 = 26;
							string text = array3[0];
							IL_23F:
							num2 = 27;
							Bitmap bitmap = O_O0OO.O0_00o.o0__o.;
							IL_249:
							num2 = 28;
							if (text.LastIndexOf(".") > 0)
							{
								IL_25B:
								num2 = 29;
								text = text.Substring(text.LastIndexOf(".")).ToLower();
								IL_278:
								num2 = 30;
								if (O_O0OO.O0_00o.o0__o..ContainsKey(text))
								{
									IL_289:
									num2 = 31;
									bitmap = O_O0OO.O0_00o.o0__o.[text];
								}
								else
								{
									IL_29C:
									num2 = 33;
									bitmap = ooO.OoO_0._oO00_o.(text);
									IL_2A8:
									num2 = 34;
									if (bitmap == null)
									{
										IL_2AF:
										num2 = 35;
										bitmap = O_O0OO.O0_00o.o0__o.;
									}
									IL_2B9:
									num2 = 36;
									O_O0OO.O0_00o.o0__o..Add(text, bitmap);
								}
							}
							IL_2CA:
							num2 = 37;
							this.OO_._.().SetCellImage(this.OO_._.().Rows.Count - 1, 0, bitmap);
						}
					}
					IL_2ED:
					num2 = 38;
				}
				IL_2FC:
				num2 = 39;
				((IDisposable)enumerator2).Dispose();
				IL_30C:
				num2 = 40;
				if (Operators.CompareString(this.ooooOoo.0OOo0.().CurrentDir, "/", true) == 0)
				{
					goto IL_39F;
				}
				IL_327:
				num2 = 41;
				this.OO_._.().AddItem("..", 1);
				IL_33C:
				num2 = 42;
				this.OO_._.().SetData(1, 3, 0);
				IL_353:
				num2 = 43;
				this.OO_._.().SetCellImage(1, 0, a.o___o.00Oo__.().ToBitmap());
				IL_36D:
				num2 = 44;
				if (this.OO_._.().Rows.Count <= 2)
				{
					goto IL_3CF;
				}
				IL_383:
				num2 = 45;
				this.OO_._.().Rows[2].Selected = true;
				goto IL_3CF;
				IL_39F:
				num2 = 47;
				if (this.OO_._.().Rows.Count <= 1)
				{
					goto IL_3CF;
				}
				IL_3B5:
				num2 = 48;
				this.OO_._.().Rows[1].Selected = true;
				IL_3CF:
				num2 = 49;
				this.OO_._.().EndUpdate();
				IL_3DD:
				goto IL_4F7;
				IL_3E2:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_4B8:
				goto IL_4EC;
				IL_4BA:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_4CA:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_4BA;
			}
			IL_4EC:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_4F7:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x0021D0F0 File Offset: 0x0021B2F0
		private void <<EMPTY_NAME>>(object A_0, SortColEventArgs A_1)
		{
			if (this.OO_._.().Row > 0)
			{
				this.OO_._.().Sort(SortFlags.Ascending, 3);
				this.OO_._.().ShowCell(this.OO_._.().Row, this.OO_._.().Col);
			}
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x0021D130 File Offset: 0x0021B330
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
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
				if (!this.ooooOoo.0OOo0.().Connect())
				{
					goto IL_43C;
				}
				IL_19:
				num2 = 4;
				if (this.OO_._.().Row <= 0)
				{
					goto IL_43C;
				}
				IL_2C:
				num2 = 5;
				if (Operators.CompareString(this.OO_._.()[this.OO_._.().Row, 3].ToString(), "1", true) != 0)
				{
					goto IL_E3;
				}
				IL_5A:
				num2 = 6;
				string text = this.OO_._.()[this.OO_._.().Row, 0].ToString();
				IL_79:
				num2 = 7;
				if (!this.o._O0o_.(this.ooooOoo.0OOo0.().CurrentDir.TrimEnd(new char[]
				{
					'/'
				}) + "/" + text))
				{
					goto IL_43C;
				}
				IL_AC:
				num2 = 9;
				this.ooooOoo.0OOo0.().ChangeDir(text);
				IL_BB:
				num2 = 10;
				this.ooooOoo.0OOo0.(false);
				IL_C5:
				num2 = 11;
				this.oo.O_0_O00_O0_.().Value = this.ooooOoo.0OOo0.().CurrentDir;
				goto IL_43C;
				IL_E3:
				num2 = 13;
				if (Operators.CompareString(this.OO_._.()[this.OO_._.().Row, 3].ToString(), "0", true) != 0)
				{
					goto IL_21D;
				}
				IL_112:
				num2 = 14;
				string text2 = this.ooooOoo.0OOo0.().CurrentDir;
				IL_122:
				num2 = 15;
				string[] array = text2.Split(new char[]
				{
					'/'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_13A:
				num2 = 16;
				if (array.Length <= 0)
				{
					goto IL_1F5;
				}
				IL_147:
				num2 = 17;
				text2 = text2.Substring(0, text2.LastIndexOf("/") + 1);
				IL_162:
				num2 = 18;
				if (Operators.CompareString(this.ooooOoo.0OOo0.().RootDir, "", true) <= 0)
				{
					goto IL_1C9;
				}
				IL_17E:
				num2 = 19;
				if (text2.Length >= this.ooooOoo.0OOo0.().RootDir.Length || !this.ooooOoo.0OOo0.().RootDir.StartsWith(text2))
				{
					goto IL_1C9;
				}
				IL_1AE:
				num2 = 20;
				MessageBox.Show("您无权访问上级目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_43C;
				IL_1C9:
				num2 = 22;
				if (!this.o._O0o_.(text2))
				{
					goto IL_43C;
				}
				IL_1D9:
				num2 = 24;
				this.ooooOoo.0OOo0.().ChangeDir(text2);
				IL_1E9:
				num2 = 25;
				this.ooooOoo.0OOo0.(false);
				goto IL_1FF;
				IL_1F5:
				num2 = 27;
				this.ooooOoo.0OOo0.(false);
				IL_1FF:
				num2 = 28;
				this.oo.O_0_O00_O0_.().Value = this.ooooOoo.0OOo0.().CurrentDir;
				goto IL_43C;
				IL_21D:
				num2 = 30;
				if (Operators.CompareString(this.OO_._.()[this.OO_._.().Row, 3].ToString(), "2", true) != 0)
				{
					goto IL_43C;
				}
				IL_24C:
				num2 = 31;
				if (!this.o_O0.O__.().Enabled)
				{
					goto IL_43C;
				}
				IL_25F:
				num2 = 32;
				C1FlexGrid c1FlexGrid = this.OO_._.();
				IL_26A:
				num2 = 33;
				string text3 = this.ooooOoo.0OOo0.().CurrentDir.TrimEnd(new char[]
				{
					'/'
				}) + "/" + c1FlexGrid[c1FlexGrid.Row, 0].ToString();
				IL_2A8:
				num2 = 34;
				FTPDownloadEventArgs ftpdownloadEventArgs = new FTPDownloadEventArgs(text3, Conversions.ToDate(c1FlexGrid[c1FlexGrid.Row, 1].ToString()), this.ooooOoo.0OOo0.().FTPName);
				IL_2D8:
				num2 = 35;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeDownload", new object[]
				{
					ftpdownloadEventArgs
				}, true, "FTP", false);
				IL_2FD:
				num2 = 36;
				if (ftpdownloadEventArgs.Cancel)
				{
					goto IL_43C;
				}
				IL_30C:
				num2 = 38;
				if (this.o_O0.O__.().FindRow(text3, 1, 0, false, true, false) <= 0)
				{
					goto IL_33F;
				}
				IL_324:
				num2 = 39;
				MessageBox.Show("此文件已经在下载队列中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_43C;
				IL_33F:
				num2 = 41;
				string text4 = this.oo.O_0_O00_O0_.().Text.Trim(new char[]
				{
					'\\'
				}) + "\\" + text3.Replace("/", "\\").Trim(new char[]
				{
					'\\'
				});
				IL_38A:
				num2 = 42;
				string parentPath = OO_00oOO.FileSys.GetParentPath(text4);
				IL_39B:
				num2 = 43;
				if (OO_00oOO.FileSys.FileExists(parentPath))
				{
					goto IL_3BB;
				}
				IL_3AC:
				num2 = 44;
				OO_00oOO.FileSys.CreateDirectory(parentPath);
				IL_3BB:
				num2 = 45;
				if (this.o_O0.O__.().FindRow(text4, 1, 4, false, true, false) >= 0)
				{
					goto IL_423;
				}
				IL_3D3:
				num2 = 46;
				this.o_O0.O__.().AddItem(text3 + "\t" + c1FlexGrid[c1FlexGrid.Row, 2].ToString() + "\t等待中\t" + "\t" + text4 + "\t0").UserData = "down";
				goto IL_439;
				IL_423:
				num2 = 48;
				MessageBox.Show("此文件已经在下载队列中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_439:
				c1FlexGrid = null;
				IL_43C:
				goto IL_556;
				IL_441:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_517:
				goto IL_54B;
				IL_519:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_529:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_519;
			}
			IL_54B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_556:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x0021D6B8 File Offset: 0x0021B8B8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o__o0O0_._0.(false);
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x0021D6C4 File Offset: 0x0021B8C4
		private void <<EMPTY_NAME>>(bool A_0)
		{
			if (this.ooooOoo.0OOo0.().Connect())
			{
				string text = this.oo.O_0_O00_O0_.().Text;
				C1FlexGrid c1FlexGrid = this.OO_._.();
				int num = c1FlexGrid.Rows.Count - 1;
				for (int i = 1; i <= num; i++)
				{
					if (c1FlexGrid.Rows[i].Selected && Operators.CompareString(c1FlexGrid.GetData(i, 3).ToString(), "2", true) == 0)
					{
						string text2 = this.ooooOoo.0OOo0.().CurrentDir.TrimEnd(new char[]
						{
							'/'
						}) + "/" + c1FlexGrid.GetData(i, 0).ToString();
						FTPDownloadEventArgs ftpdownloadEventArgs = new FTPDownloadEventArgs(text2, Conversions.ToDate(c1FlexGrid.GetData(i, 1).ToString()), this.ooooOoo.0OOo0.().FTPName);
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeDownload", new object[]
						{
							ftpdownloadEventArgs
						}, true, "FTP", false);
						if (ftpdownloadEventArgs.CancelAll)
						{
							break;
						}
						if (!ftpdownloadEventArgs.Cancel)
						{
							string text3 = c1FlexGrid.GetData(i, 0).ToString();
							if (this.o_O0.O__.().FindRow(text2, 1, 0, false, true, false) > 0)
							{
								MessageBox.Show("文件[" + text3 + "]已经在下载队列中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							}
							else
							{
								text3 = text.Trim(new char[]
								{
									'\\'
								}) + "\\" + text2.Replace("/", "\\").Trim(new char[]
								{
									'\\'
								});
								string parentPath = OO_00oOO.FileSys.GetParentPath(text3);
								if (!OO_00oOO.FileSys.FileExists(parentPath))
								{
									OO_00oOO.FileSys.CreateDirectory(parentPath);
								}
								if (this.o_O0.O__.().FindRow(text3, 1, 4, false, true, false) < 0)
								{
									this.o_O0.O__.().AddItem(string.Concat(new string[]
									{
										text2 + "\t" + c1FlexGrid[i, 2].ToString() + "\t等待中\t",
										"\t",
										text3,
										"\t",
										Interaction.IIf(A_0, 1, 0).ToString()
									})).UserData = "down";
								}
								else
								{
									MessageBox.Show("文件[" + OO_00oOO.FileSys.GetName(text3) + "]已经在下载队列中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x0021D93C File Offset: 0x0021BB3C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.ooooOoo.0OOo0.().Connect())
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Multiselect = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					foreach (string text in openFileDialog.FileNames)
					{
						FTPUploadEventArgs ftpuploadEventArgs = new FTPUploadEventArgs(text, this.ooooOoo.0OOo0.().CurrentDir, this.ooooOoo.0OOo0.().FTPName);
						O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeUpload", new object[]
						{
							ftpuploadEventArgs
						}, true, "FTP", false);
						if (ftpuploadEventArgs.CancelAll)
						{
							break;
						}
						if (!ftpuploadEventArgs.Cancel)
						{
							string text2 = "/" + this.ooooOoo.0OOo0.().CurrentDir.Trim(new char[]
							{
								'/'
							}) + "/" + OO_00oOO.FileSys.GetName(text);
							FileInfo fileInfo = new FileInfo(text);
							if (text2.StartsWith("//"))
							{
								text2 = text2.Substring(1);
							}
							if (this.o_O0.O__.().FindRow(text, 1, 0, false, true, false) < 0 && this.o_O0.O__.().FindRow(text2, 1, 4, false, true, false) < 0)
							{
								this.o_O0.O__.().AddItem(text + "\t" + Conversions.ToString(fileInfo.Length) + "\t等待中\t" + "\t" + text2).UserData = "up";
							}
							else
							{
								MessageBox.Show("此文件已经在上传队列中！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							}
						}
					}
				}
			}
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x0021DABC File Offset: 0x0021BCBC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.ooooOoo.0OOo0.().Connect())
			{
				C1FlexGrid c1FlexGrid = this.OO_._.();
				if (Operators.CompareString(c1FlexGrid.GetData(c1FlexGrid.Row, 3).ToString(), "0", true) != 0 && MessageBox.Show("确定要删除选定项目吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
				{
					int num = c1FlexGrid.Rows.Count - 1;
					int num2;
					for (int i = 1; i <= num; i++)
					{
						if (c1FlexGrid.Rows[i].Selected && (Operators.CompareString(c1FlexGrid.GetData(i, 3).ToString(), "1", true) == 0 || Operators.CompareString(c1FlexGrid.GetData(i, 3).ToString(), "2", true) == 0))
						{
							string str = c1FlexGrid.GetData(i, 0).ToString();
							bool a_ = Operators.CompareString(this.OO_._.()[i, 3].ToString(), "1", true) == 0;
							FTPDeleteEventargs ftpdeleteEventargs = new FTPDeleteEventargs(this.ooooOoo.0OOo0.().CurrentDir.TrimEnd(new char[]
							{
								'/'
							}) + "/" + str, a_, Conversions.ToDate(c1FlexGrid.GetData(i, 1).ToString()), this.ooooOoo.0OOo0.().FTPName);
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeDelete", new object[]
							{
								ftpdeleteEventargs
							}, true, "FTP", false);
							if (ftpdeleteEventargs.CancelAll)
							{
								break;
							}
							if (!ftpdeleteEventargs.Cancel)
							{
								if (Operators.CompareString(c1FlexGrid.GetData(i, 3).ToString(), "1", true) == 0)
								{
									string dirName = c1FlexGrid.GetData(i, 0).ToString();
									this.ooooOoo.0OOo0.().DeleteDir(dirName, true);
								}
								else if (Operators.CompareString(c1FlexGrid.GetData(i, 3).ToString(), "2", true) == 0)
								{
									string fileName = c1FlexGrid.GetData(i, 0).ToString();
									this.ooooOoo.0OOo0.().DeleteFile(fileName);
								}
								O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterDelete", new object[]
								{
									ftpdeleteEventargs
								}, true, "FTP", false);
								num2++;
							}
						}
					}
					if (num2 > 0)
					{
						this.ooooOoo.0OOo0.(true);
					}
				}
			}
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x0021DCE4 File Offset: 0x0021BEE4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.ooooOoo.0OOo0.().Connect())
			{
				C1FlexGrid c1FlexGrid = this.OO_._.();
				if (c1FlexGrid.Row > 0 && (Operators.CompareString(c1FlexGrid.GetData(c1FlexGrid.Row, 3).ToString(), "1", true) == 0 || Operators.CompareString(c1FlexGrid.GetData(c1FlexGrid.Row, 3).ToString(), "2", true) == 0))
				{
					string text = this.ooooOoo.0OOo0.().CurrentDir.TrimEnd(new char[]
					{
						'/'
					}) + "/" + c1FlexGrid.GetData(c1FlexGrid.Row, 0).ToString();
					DateTime a_ = Conversions.ToDate(c1FlexGrid.GetData(c1FlexGrid.Row, 1).ToString());
					bool a_2 = Operators.CompareString(this.OO_._.()[this.OO_._.().Row, 3].ToString(), "1", true) == 0;
					FTPRenameEventArgs ftprenameEventArgs = new FTPRenameEventArgs(text, "", a_2, a_, this.ooooOoo.0OOo0.().FTPName);
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeRename", new object[]
					{
						ftprenameEventArgs
					}, true, "FTP", false);
					if (!ftprenameEventArgs.Cancel)
					{
						o\u3000\u3000 o_u3000_u = new o\u3000\u3000("重命名", "输入新名称:", c1FlexGrid.GetData(c1FlexGrid.Row, 0).ToString());
						if (o_u3000_u.ShowDialog() == DialogResult.OK && Operators.CompareString(text, o_u3000_u.Value, true) != 0 && Operators.CompareString(o_u3000_u.Value, "", true) > 0)
						{
							string text2 = o_u3000_u.Value;
							if (this.ooooOoo.0OOo0.().Rename(text, text2))
							{
								string currentDir = this.ooooOoo.0OOo0.().CurrentDir;
								if (this.ooooOoo.0OOo0.().Ooo_Oo_O0.00O..ContainsKey(currentDir))
								{
									this.ooooOoo.0OOo0.(true);
								}
								int @fixed = c1FlexGrid.Rows.Fixed;
								int num = c1FlexGrid.Rows.Count - 1;
								for (int i = @fixed; i <= num; i++)
								{
									if (Operators.CompareString(c1FlexGrid.GetData(i, 0).ToString(), text2, true) == 0)
									{
										c1FlexGrid.Row = i;
										break;
									}
								}
							}
							ftprenameEventArgs = new FTPRenameEventArgs(text, text2, a_2, a_, this.ooooOoo.0OOo0.().FTPName);
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterRename", new object[]
							{
								ftprenameEventArgs
							}, true, "FTP", false);
						}
					}
				}
			}
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x0021DF3B File Offset: 0x0021C13B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x0021DF44 File Offset: 0x0021C144
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.ooooOoo.0OOo0.().Connect())
			{
				this.OO_._.();
				o\u3000\u3000 o_u3000_u = new o\u3000\u3000("新建目录", "输入目录名称:", "");
				if (o_u3000_u.ShowDialog() == DialogResult.OK && Operators.CompareString(o_u3000_u.Value, "", true) > 0)
				{
					string a_ = this.ooooOoo.0OOo0.().CurrentDir.TrimEnd(new char[]
					{
						'/'
					}) + "/" + o_u3000_u.Value;
					FTPFolderEventArgs ftpfolderEventArgs = new FTPFolderEventArgs(a_, this.ooooOoo.0OOo0.().FTPName);
					O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeCreateFolder", new object[]
					{
						ftpfolderEventArgs
					}, true, "FTP", false);
					if (!ftpfolderEventArgs.Cancel)
					{
						if (this.ooooOoo.0OOo0.().MakeDir(o_u3000_u.Value))
						{
							this.ooooOoo.0OOo0.(true);
							O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterCreateFolder", new object[]
							{
								ftpfolderEventArgs
							}, true, "FTP", false);
						}
					}
				}
			}
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x0021E044 File Offset: 0x0021C244
		private void <<EMPTY_NAME>>(string A_0, bool A_1)
		{
			int num = this.o_O0.O__.().Rows.Count - 1;
			for (int i = 1; i <= num; i++)
			{
				if (Operators.CompareString(this.o_O0.O__.().GetData(i, 0).ToString(), A_0, true) == 0)
				{
					if (A_1)
					{
						this.o_O0.O__.()[i, 2] = "下载中断";
					}
					else
					{
						this.o_O0.O__.()[i, 2] = "下载失败";
					}
					this.o_O0.O__.()[i, 3] = "";
					this.o_O0.O__.().Rows[i].UserData = "down";
				}
			}
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x0021E0E4 File Offset: 0x0021C2E4
		private void <<EMPTY_NAME>>(string A_0)
		{
			if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
			{
				OO_00oOO.BaseMainForm.Invoke(new k2.OooOO_o(this.oo_.OOO_.), new object[]
				{
					A_0
				});
			}
			FTPDownloadEventArgs ftpdownloadEventArgs = new FTPDownloadEventArgs(A_0, DateTime.MinValue, this.ooooOoo.0OOo0.().FTPName);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterDownload", new object[]
			{
				ftpdownloadEventArgs
			}, true, "FTP", false);
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x0021E160 File Offset: 0x0021C360
		private void <<EMPTY_NAME>>(string A_0, long A_1, long A_2, long A_3, TimeSpan A_4)
		{
			C1FlexGrid c1FlexGrid = this.o_O0.O__.();
			int num = c1FlexGrid.FindRow(A_0, 1, 0, false, true, false);
			if (num > 0)
			{
				c1FlexGrid[num, 2] = Math.Round((double)(A_2 + A_3) / (double)A_1, 4);
				c1FlexGrid[num, 3] = (int)Math.Round((double)A_3 / A_4.TotalSeconds / 1024.0);
			}
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x0021E1C8 File Offset: 0x0021C3C8
		private void <<EMPTY_NAME>>()
		{
			this.ooooOoo.0OOo0.(false);
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x0021E1D4 File Offset: 0x0021C3D4
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
			{
				OO_00oOO.BaseMainForm.Invoke(new k2.O_Oo(this.oO0.O__0_o.), new object[]
				{
					string.Concat(new string[]
					{
						"[",
						Strings.Format(DateTime.Now, "HH:mm:ss"),
						"] ",
						A_0,
						",",
						A_1,
						"\r\n"
					})
				});
			}
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x0021E260 File Offset: 0x0021C460
		private void <<EMPTY_NAME>>(string A_0)
		{
			if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
			{
				OO_00oOO.BaseMainForm.Invoke(new k2.O_Oo(this.oO0.O__0_o.), new object[]
				{
					string.Concat(new string[]
					{
						"[",
						Strings.Format(DateTime.Now, "HH:mm:ss"),
						"] ",
						A_0,
						"\r\n"
					})
				});
			}
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x0021E2DE File Offset: 0x0021C4DE
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.ooooOoo.0OOo0.(true);
		}

		// Token: 0x06004AFB RID: 19195 RVA: 0x0021E2E7 File Offset: 0x0021C4E7
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (A_1.KeyCode == Keys.Delete)
			{
				this.O._o__.().PerformClick();
			}
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x0021E300 File Offset: 0x0021C500
		private void <<EMPTY_NAME>>(object A_0, OwnerDrawCellEventArgs A_1)
		{
			if (A_1.Row > 0 && A_1.Col == 2)
			{
				string text = A_1.Text;
				if (Operators.CompareString(text, "", true) > 0 && Versioned.IsNumeric(text))
				{
					long num = Conversions.ToLong(text);
					if (num == 0L)
					{
						A_1.Text = "0 KB";
						return;
					}
					if (num <= 1024L)
					{
						A_1.Text = "1 KB";
						return;
					}
					A_1.Text = Strings.Format((int)Math.Round((double)num / 1024.0), "#,##0") + " KB";
				}
			}
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x0021E39C File Offset: 0x0021C59C
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.o_O0.O__.();
			if (c1FlexGrid.Row > 0)
			{
				if (Operators.CompareString(c1FlexGrid.Rows[c1FlexGrid.Row].UserData.ToString(), "{down}", true) == 0)
				{
					if (MessageBox.Show("文件正在下载中，确定要终止下载并从队列中移除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						this.oo.O_0_O00_O0_.().o_0_.__0OO.();
						c1FlexGrid.Rows.Remove(c1FlexGrid.Row);
					}
				}
				else if (Operators.CompareString(c1FlexGrid.Rows[c1FlexGrid.Row].UserData.ToString(), "{up}", true) == 0)
				{
					if (MessageBox.Show("文件正在上传中，确定要终止上传并从队列中移除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						this.oo.O_0_O00_O0_.().o_0_.__0OO.();
						c1FlexGrid.Rows.Remove(c1FlexGrid.Row);
					}
				}
				else
				{
					c1FlexGrid.Rows.Remove(c1FlexGrid.Row);
				}
			}
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x0021E48C File Offset: 0x0021C68C
		private void <<EMPTY_NAME>>(object A_0, OwnerDrawCellEventArgs A_1)
		{
			if (A_1.Row > 0 && A_1.Col == 1)
			{
				string text = A_1.Text;
				if (Operators.CompareString(text, "", true) > 0 && Versioned.IsNumeric(text))
				{
					long num = Conversions.ToLong(text);
					if (num == 0L)
					{
						A_1.Text = "0 KB";
						return;
					}
					if (num <= 1024L)
					{
						A_1.Text = "1 KB";
						return;
					}
					A_1.Text = Strings.Format((int)Math.Round((double)num / 1024.0), "#,##0") + " KB";
					return;
				}
			}
			else if (A_1.Row > 0 && A_1.Col == 0)
			{
				if (Operators.CompareString(A_1.Text, "", true) > 0)
				{
					A_1.Text = OO_00oOO.FileSys.GetName(A_1.Text);
				}
				if (this.o_O0.O__.().Rows[A_1.Row].UserData.ToString().IndexOf("down") >= 0)
				{
					A_1.Image = a.OoOoOOOOOO.0_.();
					return;
				}
				if (this.o_O0.O__.().Rows[A_1.Row].UserData.ToString().IndexOf("up") >= 0)
				{
					A_1.Image = a.OO.oO__O00.();
					return;
				}
			}
			else if (A_1.Row > 0 && A_1.Col == 3)
			{
				if (Operators.CompareString(A_1.Text, "", true) > 0)
				{
					A_1.Text += " KB/S";
					return;
				}
			}
			else if (A_1.Row > 0 && A_1.Col == 2)
			{
				if (Versioned.IsNumeric(A_1.Text))
				{
					double num2 = Conversions.ToDouble(A_1.Text);
					A_1.Text = Conversions.ToString(Math.Round(num2 * 100.0, 2)) + "%";
					A_1.DrawCell(DrawCellFlags.Background | DrawCellFlags.Border);
					int width = (int)Math.Round((double)(A_1.Bounds.Width - 2) * num2);
					A_1.Graphics.FillRectangle(Brushes.Lavender, A_1.Bounds.X + 1, A_1.Bounds.Y + 1, width, A_1.Bounds.Height - 2);
					A_1.DrawCell(DrawCellFlags.Content);
					A_1.Handled = true;
					return;
				}
				if (A_1.Text.EndsWith("失败") || A_1.Text.EndsWith("中断"))
				{
					A_1.Style = this.o_O0.O__.().Styles["error"];
				}
			}
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x0021E738 File Offset: 0x0021C938
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
			this.oo.O_0_O00_O0_.().Enabled = false;
			NetworkChange.NetworkAvailabilityChanged -= this.o.oO0000.;
			NetworkChange.NetworkAddressChanged -= this.o._0oO.;
			if (this.oo.O_0_O00_O0_.().Connected)
			{
				this.oo.O_0_O00_O0_.().Connected = false;
				this.oo.O_0_O00_O0_.().Close();
			}
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x0021E7A8 File Offset: 0x0021C9A8
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			if (this.oo.O_0_O00_O0_.().AsyncState != Oo_0.OOoo0_OO__._o.)
			{
				if (MessageBox.Show("有文件未下载完成，是否退出?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.oo.O_0_O00_O0_.().Enabled = false;
					this.oo.O_0_O00_O0_.().o_0_.__0OO.();
					return;
				}
				A_1.Cancel = true;
			}
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x0021E7F8 File Offset: 0x0021C9F8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.ooooOoo.0OOo0.().Connected || !this.oo.oo__o_. || (DateTime.Now - this.oo.oo__o_.).TotalSeconds <= 3.0)
				{
					goto IL_8E;
				}
				IL_41:
				num2 = 3;
				if (!NetworkInterface.GetIsNetworkAvailable())
				{
					goto IL_534;
				}
				IL_4D:
				num2 = 4;
				if (!this.ooooOoo.0OOo0.().Connect())
				{
					goto IL_6A;
				}
				IL_5C:
				num2 = 5;
				this.oo.oo__o_. = false;
				goto IL_534;
				IL_6A:
				num2 = 7;
				this.oo.oo__o_. = DateTime.Now.AddSeconds(8.0);
				goto IL_534;
				IL_8E:
				num2 = 9;
				if (!this.ooooOoo.0OOo0.().Connected)
				{
					goto IL_534;
				}
				IL_A1:
				num2 = 11;
				if (this.oo.O_0_O00_O0_.().AsyncState != Oo_0.OOoo0_OO__._o.)
				{
					goto IL_534;
				}
				IL_B4:
				num2 = 12;
				int num3 = -1;
				IL_BA:
				num2 = 13;
				int num4 = this.o_O0.O__.().Rows.Count - 1;
				for (int i = 1; i <= num4; i++)
				{
					IL_D6:
					num2 = 14;
					if (!this.o_O0.O__.().GetData(i, 2).ToString().EndsWith("中断") && !this.o_O0.O__.().GetData(i, 2).ToString().EndsWith("失败"))
					{
						IL_117:
						num2 = 15;
						num3 = i;
						break;
					}
					IL_120:
					num2 = 17;
				}
				IL_12F:
				num2 = 18;
				if (num3 != -1)
				{
					goto IL_18D;
				}
				IL_137:
				num2 = 19;
				int num5 = this.o_O0.O__.().Rows.Count - 1;
				for (int j = 1; j <= num5; j++)
				{
					IL_153:
					num2 = 20;
					if (this.o_O0.O__.().GetData(j, 2).ToString().EndsWith("中断"))
					{
						IL_175:
						num2 = 21;
						num3 = j;
						break;
					}
					IL_17E:
					num2 = 23;
				}
				IL_18D:
				num2 = 24;
				if (num3 <= 0)
				{
					goto IL_500;
				}
				IL_198:
				num2 = 25;
				if (this.oo.O_0_O00_O0_.().Connected)
				{
					goto IL_1BC;
				}
				IL_1A8:
				num2 = 26;
				this.oo.O_0_O00_O0_.().Connect();
				goto IL_534;
				IL_1BC:
				num2 = 28;
				string a_ = this.o_O0.O__.().GetData(num3, 0).ToString();
				IL_1D4:
				num2 = 29;
				string text = this.o_O0.O__.().GetData(num3, 4).ToString();
				IL_1EC:
				num2 = 30;
				if (Operators.CompareString(this.o_O0.O__.().Rows[num3].UserData.ToString(), "down", true) != 0)
				{
					goto IL_24F;
				}
				IL_218:
				num2 = 31;
				this.o_O0.O__.().Rows[num3].UserData = "{down}";
				IL_237:
				num2 = 32;
				this.oo.O_0_O00_O0_.().O_O0Ooo_00.o.(a_, text, false);
				goto IL_534;
				IL_24F:
				num2 = 34;
				if (Operators.CompareString(this.o_O0.O__.().Rows[num3].UserData.ToString(), "up", true) != 0)
				{
					goto IL_45C;
				}
				IL_27E:
				num2 = 35;
				this.o_O0.O__.().Rows[num3].UserData = "{up}";
				IL_29D:
				num2 = 36;
				if (this.oo.oo__o_. == k2.o_0O.O_oO_00_OO_.0. || !this.oo.O_0_O00_O0_.().FileExists(text))
				{
					goto IL_3E3;
				}
				IL_2BE:
				num2 = 37;
				if (this.oo.oo__o_. != k2.o_0O.o_oO_0oO_0.0.)
				{
					goto IL_2E5;
				}
				IL_2CA:
				num2 = 38;
				this.o_O0.O__.().Rows.Remove(num3);
				goto IL_534;
				IL_2E5:
				num2 = 40;
				if (this.o_O0.O__.().Rows.Count != 2)
				{
					goto IL_347;
				}
				IL_2FB:
				num2 = 41;
				if (MessageBox.Show("文件\"" + OO_00oOO.FileSys.GetName(text) + "\"已经存在，是否覆盖?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
				{
					goto IL_3E3;
				}
				IL_32C:
				num2 = 42;
				this.o_O0.O__.().Rows.Remove(num3);
				goto IL_534;
				IL_347:
				num2 = 45;
				O\u3000\u3002\u3002 o_u3000_u3002_u = new O\u3000\u3002\u3002(this);
				IL_352:
				num2 = 46;
				o_u3000_u3002_u.OO__O_0O0.0oO_.().Text = "文件" + OO_00oOO.FileSys.GetName(text) + o_u3000_u3002_u.OO__O_0O0.0oO_.().Text;
				IL_383:
				num2 = 47;
				o_u3000_u3002_u.ShowDialog();
				IL_38E:
				num2 = 48;
				if (this.oo.oo__o_. != k2.o_0O.Oo000._0OO_O_. && this.oo.oo__o_. != k2.o_0O.o_oO_0oO_0.0.)
				{
					goto IL_3BE;
				}
				IL_3A3:
				num2 = 49;
				this.o_O0.O__.().Rows.Remove(num3);
				goto IL_534;
				IL_3BE:
				num2 = 51;
				if (this.oo.oo__o_. != k2.o_0O.o.oO_000.)
				{
					goto IL_3E3;
				}
				IL_3CA:
				num2 = 52;
				this.o_O0.O__.().Rows.Count = 1;
				goto IL_534;
				IL_3E3:
				num2 = 54;
				this.oo.O_0_O00_O0_.().o0O_0_.00_oooo.(a_, text, false);
				IL_3F6:
				num2 = 55;
				if (Operators.CompareString(this.ooooOoo.0OOo0.().CurrentDir, OO_00oOO.FileSys.GetParentPath(text).Replace("\\", "/"), true) == 0)
				{
					goto IL_534;
				}
				IL_42A:
				num2 = 56;
				if (this.ooooOoo.0OOo0.().Ooo_Oo_O0.00O..ContainsKey(this.ooooOoo.0OOo0.().CurrentDir))
				{
					goto IL_534;
				}
				IL_44D:
				num2 = 57;
				this.ooooOoo.0OOo0.(true);
				goto IL_534;
				IL_45C:
				num2 = 59;
				if (!this.o_O0.O__.().Rows[num3].UserData.ToString().StartsWith("up "))
				{
					goto IL_534;
				}
				IL_48A:
				num2 = 60;
				string value = this.o_O0.O__.().Rows[num3].UserData.ToString().Substring(3);
				IL_4B1:
				num2 = 61;
				DateTime d = Conversions.ToDate(value);
				IL_4BD:
				num2 = 62;
				if ((DateTime.Now - d).TotalSeconds <= 30.0)
				{
					goto IL_534;
				}
				IL_4DF:
				num2 = 63;
				this.o_O0.O__.().Rows[num3].UserData = "up";
				goto IL_534;
				IL_500:
				num2 = 65;
				if (this.ooooOoo.0OOo0.().Ooo_Oo_O0.00O..ContainsKey(this.ooooOoo.0OOo0.().CurrentDir))
				{
					goto IL_52A;
				}
				IL_520:
				num2 = 66;
				this.ooooOoo.0OOo0.(true);
				IL_52A:
				num2 = 67;
				this.oo.oo__o_. = k2.o_0O.oo.oo__o_.;
				IL_534:
				goto IL_696;
				IL_539:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_657:
				goto IL_68B;
				IL_659:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_669:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_659;
			}
			IL_68B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_696:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x0021EEC0 File Offset: 0x0021D0C0
		private void <<EMPTY_NAME>>(object A_0, NetworkAvailabilityEventArgs A_1)
		{
			this.oo.oo__o_. = true;
			this.ooooOoo.0OOo0.().Connected = false;
			this.oo.O_0_O00_O0_.().Connected = false;
			this.oo.oo__o_. = DateTime.Now;
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x0021EEEC File Offset: 0x0021D0EC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oo.oo__o_. = true;
			this.ooooOoo.0OOo0.().Connected = false;
			this.oo.O_0_O00_O0_.().Connected = false;
			this.oo.oo__o_. = DateTime.Now;
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x0021EF18 File Offset: 0x0021D118
		private void <<EMPTY_NAME>>(string A_0)
		{
			int num = this.o_O0.O__.().Rows.Count - 1;
			for (int i = 1; i <= num; i++)
			{
				if (Operators.CompareString(this.o_O0.O__.().GetData(i, 0).ToString(), A_0, true) == 0)
				{
					this.o_O0.O__.()[i, 2] = "上传中断";
					this.o_O0.O__.()[i, 3] = "";
					this.o_O0.O__.().Rows[i].UserData = "up " + Conversions.ToString(DateTime.Now);
				}
			}
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x0021EFB0 File Offset: 0x0021D1B0
		private void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (OO_00oOO.BaseMainForm != null && OO_00oOO.BaseMainForm.IsHandleCreated)
			{
				OO_00oOO.BaseMainForm.Invoke(new k2.OooOO_o(this.oo_.OOO_.), new object[]
				{
					A_0
				});
			}
			string key = OO_00oOO.FileSys.GetParentPath(A_1).Replace("\\", "/");
			if (this.ooooOoo.0OOo0.().Ooo_Oo_O0.00O..ContainsKey(key))
			{
				this.ooooOoo.0OOo0.().Ooo_Oo_O0.00O..Remove(key);
			}
			FTPUploadEventArgs ftpuploadEventArgs = new FTPUploadEventArgs(A_0, OO_00oOO.FileSys.GetParentPath(A_1), this.ooooOoo.0OOo0.().FTPName);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "AfterUpload", new object[]
			{
				ftpuploadEventArgs
			}, true, "FTP", false);
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x0021F06F File Offset: 0x0021D26F
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Process.Start(this.oo.O_0_O00_O0_.().Text + "\\");
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x0021F08C File Offset: 0x0021D28C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o__o0O0_._0.(true);
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x0021F098 File Offset: 0x0021D298
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string[] array = this.oo.O_0_O00_O0_.().Text.Split(new char[]
			{
				'/'
			}, StringSplitOptions.RemoveEmptyEntries);
			this.oo.O_0_O00_O0_.().Items.Clear();
			this.oo.O_0_O00_O0_.().Items.Add("/");
			string text = "/";
			foreach (string str in array)
			{
				text = text + str + "/";
				this.oo.O_0_O00_O0_.().Items.Add(text);
			}
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x0021F11F File Offset: 0x0021D31F
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			A_1.Handled = true;
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x0021F128 File Offset: 0x0021D328
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			A_1.Handled = true;
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x0021F134 File Offset: 0x0021D334
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OO_._.().Focus();
			string text = this.oo.O_0_O00_O0_.().SelectedItem.ToString();
			if (Operators.CompareString(this.ooooOoo.0OOo0.().CurrentDir.Trim(new char[]
			{
				'/'
			}), text.Trim(new char[]
			{
				'/'
			}), true) != 0)
			{
				if (Operators.CompareString(this.ooooOoo.0OOo0.().RootDir, "", true) > 0 && text.Length < this.ooooOoo.0OOo0.().RootDir.Length && this.ooooOoo.0OOo0.().RootDir.StartsWith(text))
				{
					this.oo.O_0_O00_O0_.().SelectedItem = this.ooooOoo.0OOo0.().CurrentDir + "/";
					MessageBox.Show("您无权访问此目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (this.o._O0o_.(text))
				{
					this.ooooOoo.0OOo0.().ChangeDir(text);
					this.ooooOoo.0OOo0.(false);
				}
			}
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x0021F22C File Offset: 0x0021D42C
		private bool <<EMPTY_NAME>>(string A_0)
		{
			FTPFolderEventArgs ftpfolderEventArgs = new FTPFolderEventArgs(A_0, this.ooooOoo.0OOo0.().FTPName);
			O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., "BeforeEnterFolder", new object[]
			{
				ftpfolderEventArgs
			}, true, "FTP", false);
			return !ftpfolderEventArgs.Cancel;
		}

		// Token: 0x04001E61 RID: 7777
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001E62 RID: 7778
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001E63 RID: 7779
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E64 RID: 7780
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E65 RID: 7781
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E66 RID: 7782
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E67 RID: 7783
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E68 RID: 7784
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001E69 RID: 7785
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E6A RID: 7786
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001E6B RID: 7787
		[CompilerGenerated]
		private Timer <<EMPTY_NAME>>;

		// Token: 0x04001E6C RID: 7788
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001E6D RID: 7789
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001E6E RID: 7790
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E6F RID: 7791
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001E70 RID: 7792
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001E71 RID: 7793
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001E72 RID: 7794
		[CompilerGenerated]
		private FTPClient <<EMPTY_NAME>>;

		// Token: 0x04001E73 RID: 7795
		[CompilerGenerated]
		private FTPClient <<EMPTY_NAME>>;

		// Token: 0x04001E74 RID: 7796
		private string <<EMPTY_NAME>>;

		// Token: 0x04001E75 RID: 7797
		internal k2.o_0O <<EMPTY_NAME>>;

		// Token: 0x04001E76 RID: 7798
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001E77 RID: 7799
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x04001E78 RID: 7800
		private int <<EMPTY_NAME>>;

		// Token: 0x02000459 RID: 1113
		// (Invoke) Token: 0x06004B10 RID: 19216
		public delegate void O_Oo(string A_0);

		// Token: 0x0200045A RID: 1114
		// (Invoke) Token: 0x06004B14 RID: 19220
		public delegate void OooOO_o(string A_0);

		// Token: 0x0200045B RID: 1115
		public enum o_0O
		{
			// Token: 0x04001E7A RID: 7802
			<<EMPTY_NAME>>,
			// Token: 0x04001E7B RID: 7803
			<<EMPTY_NAME>>,
			// Token: 0x04001E7C RID: 7804
			<<EMPTY_NAME>>,
			// Token: 0x04001E7D RID: 7805
			<<EMPTY_NAME>>,
			// Token: 0x04001E7E RID: 7806
			<<EMPTY_NAME>>,
			// Token: 0x04001E7F RID: 7807
			<<EMPTY_NAME>>
		}
	}
}
