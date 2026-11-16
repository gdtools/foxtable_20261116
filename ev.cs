using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000DD RID: 221
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	internal partial class ev : Form
	{
		// Token: 0x06000AA7 RID: 2727 RVA: 0x0005854B File Offset: 0x0005674B
		public ev()
		{
			base.Load += this.Oo__o__oo_O.OO.;
			base.FormClosed += this.OOooO.__0Ooooo.;
			this.oooo00o.o0__. = OO_00oOO.MainTable;
			this.O___oooo_0.oO.();
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00058588 File Offset: 0x00056788
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oooo00o.o0__. != null)
				{
					this.oooo00o.o0__..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x000585C8 File Offset: 0x000567C8
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oooo00o.o0__. = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ev));
			this.OO_o._.(new C1CheckBox());
			this.OO_O0oO0.O.(new C1Button());
			this.o_oO_.0o_00.(new C1Button());
			this.o0o___oo.o.(new C1CheckBox());
			this.o0oOO0.o00_.(new C1CheckBox());
			this.Oo_o0OoO.OoO.(new C1TextBox());
			this.Oo.0o.(new Label());
			this.Oooo.oOO0oO.(new ContextMenuStrip(this.oooo00o.o0__.));
			this.o.O0Oo.(new ToolStripMenuItem());
			this.Oo.0o.(new ToolStripMenuItem());
			this.o_.OO0oO0__0o.(new ToolStripMenuItem());
			this.OO_O.oO_O.(new ToolStripMenuItem());
			this.O.OO_O0.(new Label());
			this.o_.OO0oO0__0o.(new C1TextBox());
			this.OO_O0oO0.O.(new C1CheckBox());
			this.OO_O.oO_O.(new C1FlexGrid());
			this.O.OO_O0.(new C1TextBox());
			this.OO_O.oO_O.(new RadioButton());
			this.o_.o__.(new RadioButton());
			this.O_o_O.O.(new C1TextBox());
			this.Oooo.oOO0oO.(new C1ComboBox());
			this.o_.o__.(new Label());
			this.o.O0Oo.(new C1ComboBox());
			this.Oooo.oOO0oO.(new Label());
			this.o0OO0O.0OoooOo.(new C1TextBox());
			this.o.0OOOo_o.(new Label());
			this.o.O0Oo.(new C1CheckBox());
			this.OO_O0oO0.O.(new C1DockingTab());
			this.o_oO_.0o_00.(new C1DockingTabPage());
			this.OO_O0oO0.O.(new C1DockingTabPage());
			this.o.O0Oo.(new C1FlexGrid());
			((ISupportInitialize)this.O0_0O_0.Oo00O0.()).BeginInit();
			((ISupportInitialize)this.OOooO.__0Ooooo.()).BeginInit();
			((ISupportInitialize)this.O0o00o._0o0.()).BeginInit();
			((ISupportInitialize)this.O_0.oO__.()).BeginInit();
			((ISupportInitialize)this.O0o00o._0o0.()).BeginInit();
			((ISupportInitialize)this.O___oooo_0.oO.()).BeginInit();
			this.O0_0O_0.Oo00O0.().SuspendLayout();
			((ISupportInitialize)this.OOO___.OoO.()).BeginInit();
			((ISupportInitialize)this.o0_0_oo0.0O_.()).BeginInit();
			((ISupportInitialize)this.O0000.O.()).BeginInit();
			((ISupportInitialize)this.O_0._.()).BeginInit();
			((ISupportInitialize)this.o0.O00.()).BeginInit();
			((ISupportInitialize)this.O00.OO.()).BeginInit();
			((ISupportInitialize)this.O0_0O_0.Oo00O0.()).BeginInit();
			((ISupportInitialize)this.Oo0._o_ooo_0o.()).BeginInit();
			((ISupportInitialize)this.o_.Ooo0o_.()).BeginInit();
			((ISupportInitialize)this.OOooO.__0Ooooo.()).BeginInit();
			this.OOooO.__0Ooooo.().SuspendLayout();
			this.O0o00o._0o0.().SuspendLayout();
			this.OOooO.__0Ooooo.().SuspendLayout();
			((ISupportInitialize)this.O00.OO.()).BeginInit();
			base.SuspendLayout();
			this.O0_0O_0.Oo00O0.().AutoSize = true;
			this.O0_0O_0.Oo00O0.().BorderStyle = BorderStyle.None;
			this.O0_0O_0.Oo00O0.().Checked = true;
			this.O0_0O_0.Oo00O0.().CheckState = CheckState.Checked;
			this.O0_0O_0.Oo00O0.().Location = new Point(17, 15);
			this.O0_0O_0.Oo00O0.().Margin = new Padding(3, 1, 3, 1);
			this.O0_0O_0.Oo00O0.().Name = "chkShowTree";
			this.O0_0O_0.Oo00O0.().Size = new Size(84, 16);
			this.O0_0O_0.Oo00O0.().TabIndex = 8;
			this.O0_0O_0.Oo00O0.().Text = "显示折叠树";
			this.O0_0O_0.Oo00O0.().UseVisualStyleBackColor = true;
			this.O0_0O_0.Oo00O0.().Value = true;
			this.OOooO.__0Ooooo.().DialogResult = DialogResult.Cancel;
			this.OOooO.__0Ooooo.().Location = new Point(328, 464);
			this.OOooO.__0Ooooo.().Margin = new Padding(3, 1, 3, 1);
			this.OOooO.__0Ooooo.().Name = "btnCancel";
			this.OOooO.__0Ooooo.().Size = new Size(75, 23);
			this.OOooO.__0Ooooo.().TabIndex = 13;
			this.OOooO.__0Ooooo.().Text = "取消";
			this.OOooO.__0Ooooo.().UseVisualStyleBackColor = true;
			this.O0o00o._0o0.().Location = new Point(232, 464);
			this.O0o00o._0o0.().Margin = new Padding(3, 1, 3, 1);
			this.O0o00o._0o0.().Name = "Button1";
			this.O0o00o._0o0.().Size = new Size(75, 23);
			this.O0o00o._0o0.().TabIndex = 12;
			this.O0o00o._0o0.().Text = "统计";
			this.O0o00o._0o0.().UseVisualStyleBackColor = true;
			this.O_0.oO__.().AutoSize = true;
			this.O_0.oO__.().BorderStyle = BorderStyle.None;
			this.O_0.oO__.().Location = new Point(212, 15);
			this.O_0.oO__.().Margin = new Padding(3, 1, 3, 1);
			this.O_0.oO__.().Name = "chkOnlyGroups";
			this.O_0.oO__.().Size = new Size(96, 16);
			this.O_0.oO__.().TabIndex = 6;
			this.O_0.oO__.().Text = "仅保留分组行";
			this.O_0.oO__.().UseVisualStyleBackColor = true;
			this.O_0.oO__.().Value = false;
			this.O0o00o._0o0.().AutoSize = true;
			this.O0o00o._0o0.().BorderStyle = BorderStyle.None;
			this.O0o00o._0o0.().Location = new Point(212, 41);
			this.O0o00o._0o0.().Margin = new Padding(3, 1, 3, 1);
			this.O0o00o._0o0.().Name = "chkPreserveTolevel";
			this.O0o00o._0o0.().Size = new Size(60, 16);
			this.O0o00o._0o0.().TabIndex = 39;
			this.O0o00o._0o0.().Text = "保留前";
			this.O0o00o._0o0.().UseVisualStyleBackColor = true;
			this.O0o00o._0o0.().Value = false;
			this.O___oooo_0.oO.().DataType = typeof(int);
			this.O___oooo_0.oO.().Enabled = false;
			this.O___oooo_0.oO.().Location = new Point(276, 40);
			this.O___oooo_0.oO.().Margin = new Padding(3, 1, 3, 1);
			this.O___oooo_0.oO.().Name = "txtPreserveTolevel";
			this.O___oooo_0.oO.().Size = new Size(29, 19);
			this.O___oooo_0.oO.().TabIndex = 7;
			this.O___oooo_0.oO.().Tag = null;
			this.O___oooo_0.oO.().TextAlign = HorizontalAlignment.Center;
			this.O___oooo_0.oO.().Value = 0;
			this.O0_0O_0.Oo00O0.().AutoSize = true;
			this.O0_0O_0.Oo00O0.().Location = new Point(312, 43);
			this.O0_0O_0.Oo00O0.().Name = "Label1";
			this.O0_0O_0.Oo00O0.().Size = new Size(41, 12);
			this.O0_0O_0.Oo00O0.().TabIndex = 41;
			this.O0_0O_0.Oo00O0.().Text = "级的行";
			this.O0_0O_0.Oo00O0.().Items.AddRange(new ToolStripItem[]
			{
				this.OOo_0_0O.00.(),
				this.O_._o_.(),
				this.O0_0oo0O._O_.(),
				this.O0000.O.()
			});
			this.O0_0O_0.Oo00O0.().Name = "ContextMenuStrip1";
			this.O0_0O_0.Oo00O0.().Size = new Size(101, 92);
			this.OOo_0_0O.00.().Name = "InsertMenuItem";
			this.OOo_0_0O.00.().Size = new Size(100, 22);
			this.OOo_0_0O.00.().Text = "插入";
			this.O_._o_.().Name = "DeleteMenuItem";
			this.O_._o_.().Size = new Size(100, 22);
			this.O_._o_.().Text = "删除";
			this.O0_0oo0O._O_.().Name = "MoveUpMenuItem";
			this.O0_0oo0O._O_.().Size = new Size(100, 22);
			this.O0_0oo0O._O_.().Text = "上移";
			this.O0000.O.().Name = "MoveDownMenuItem";
			this.O0000.O.().Size = new Size(100, 22);
			this.O0000.O.().Text = "下移";
			this.O0_0oo0O._O_.().AutoSize = true;
			this.O0_0oo0O._O_.().Location = new Point(134, 43);
			this.O0_0oo0O._O_.().Margin = new Padding(2, 0, 2, 0);
			this.O0_0oo0O._O_.().Name = "Label5";
			this.O0_0oo0O._O_.().Size = new Size(17, 12);
			this.O0_0oo0O._O_.().TabIndex = 45;
			this.O0_0oo0O._O_.().Text = "级";
			this.OOO___.OoO.().DataType = typeof(int);
			this.OOO___.OoO.().Location = new Point(101, 40);
			this.OOO___.OoO.().Name = "txtExpandLevel";
			this.OOO___.OoO.().Size = new Size(29, 19);
			this.OOO___.OoO.().TabIndex = 10;
			this.OOO___.OoO.().Tag = null;
			this.OOO___.OoO.().Value = 0;
			this.o0_0_oo0.0O_.().AutoSize = true;
			this.o0_0_oo0.0O_.().BorderStyle = BorderStyle.None;
			this.o0_0_oo0.0O_.().Checked = true;
			this.o0_0_oo0.0O_.().CheckState = CheckState.Checked;
			this.o0_0_oo0.0O_.().Location = new Point(17, 41);
			this.o0_0_oo0.0O_.().Margin = new Padding(2, 1, 2, 1);
			this.o0_0_oo0.0O_.().Name = "chkAutoExpand";
			this.o0_0_oo0.0O_.().Size = new Size(84, 16);
			this.o0_0_oo0.0O_.().TabIndex = 9;
			this.o0_0_oo0.0O_.().Text = "默认展开到";
			this.o0_0_oo0.0O_.().UseVisualStyleBackColor = true;
			this.o0_0_oo0.0O_.().Value = true;
			this.O0000.O.().AllowDelete = true;
			this.O0000.O.().AllowDragging = AllowDraggingEnum.None;
			this.O0000.O.().AllowMergingFixed = AllowMergingEnum.None;
			this.O0000.O.().AllowSorting = AllowSortingEnum.None;
			this.O0000.O.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.O0000.O.().ColumnInfo = componentResourceManager.GetString("TotalGrid.ColumnInfo");
			this.O0000.O.().ExtendLastCol = true;
			this.O0000.O.().HighLight = HighLightEnum.WithFocus;
			this.O0000.O.().Location = new Point(21, 88);
			this.O0000.O.().Margin = new Padding(3, 2, 3, 2);
			this.O0000.O.().Name = "TotalGrid";
			this.O0000.O.().Rows.Count = 1;
			this.O0000.O.().Rows.DefaultSize = 19;
			this.O0000.O.().SelectionMode = SelectionModeEnum.Row;
			this.O0000.O.().ShowThemedHeaders = ShowThemedHeadersEnum.None;
			this.O0000.O.().Size = new Size(594, 199);
			this.O0000.O.().TabIndex = 5;
			this.O_0._.().Enabled = false;
			this.O_0._.().Location = new Point(295, 54);
			this.O_0._.().Margin = new Padding(2, 1, 2, 1);
			this.O_0._.().Name = "txtLengths";
			this.O_0._.().Size = new Size(180, 19);
			this.O_0._.().TabIndex = 4;
			this.O_0._.().Tag = null;
			this.O_0._.().Value = "";
			this.O0000.O.().AutoSize = true;
			this.O0000.O.().Location = new Point(216, 55);
			this.O0000.O.().Margin = new Padding(2, 1, 2, 1);
			this.O0000.O.().Name = "rdoLens";
			this.O0000.O.().Size = new Size(77, 16);
			this.O0000.O.().TabIndex = 55;
			this.O0000.O.().TabStop = true;
			this.O0000.O.().Text = "长度分割:";
			this.O0000.O.().UseVisualStyleBackColor = true;
			this.O0_0oo0O._O_.().AutoSize = true;
			this.O0_0oo0O._O_.().Checked = true;
			this.O0_0oo0O._O_.().Location = new Point(21, 55);
			this.O0_0oo0O._O_.().Margin = new Padding(2, 1, 2, 1);
			this.O0_0oo0O._O_.().Name = "raoSep";
			this.O0_0oo0O._O_.().Size = new Size(77, 16);
			this.O0_0oo0O._O_.().TabIndex = 54;
			this.O0_0oo0O._O_.().TabStop = true;
			this.O0_0oo0O._O_.().Text = "符号分割:";
			this.O0_0oo0O._O_.().UseVisualStyleBackColor = true;
			this.o0.O00.().Location = new Point(100, 54);
			this.o0.O00.().Margin = new Padding(2, 1, 2, 1);
			this.o0.O00.().Name = "txtSeparator";
			this.o0.O00.().Size = new Size(96, 19);
			this.o0.O00.().TabIndex = 3;
			this.o0.O00.().Tag = null;
			this.o0.O00.().Value = "\\";
			this.O00.OO.().AllowSpinLoop = false;
			this.O00.OO.().Cursor = Cursors.Arrow;
			this.O00.OO.().DropDownStyle = DropDownStyle.DropDownList;
			this.O00.OO.().GapHeight = 0;
			this.O00.OO.().ImagePadding = new Padding(0);
			this.O00.OO.().ItemsDisplayMember = "";
			this.O00.OO.().ItemsValueMember = "";
			this.O00.OO.().Location = new Point(270, 19);
			this.O00.OO.().Margin = new Padding(3, 1, 3, 1);
			this.O00.OO.().Name = "cmbPathCol";
			this.O00.OO.().Size = new Size(130, 19);
			this.O00.OO.().TabIndex = 1;
			this.O00.OO.().Tag = "1";
			this.O_0._.().AutoSize = true;
			this.O_0._.().Location = new Point(214, 22);
			this.O_0._.().Name = "Label3";
			this.O_0._.().Size = new Size(47, 12);
			this.O_0._.().TabIndex = 60;
			this.O_0._.().Text = "层级列:";
			this.O0_0O_0.Oo00O0.().AllowSpinLoop = false;
			this.O0_0O_0.Oo00O0.().Cursor = Cursors.Arrow;
			this.O0_0O_0.Oo00O0.().DropDownStyle = DropDownStyle.DropDownList;
			this.O0_0O_0.Oo00O0.().GapHeight = 0;
			this.O0_0O_0.Oo00O0.().ImagePadding = new Padding(0);
			this.O0_0O_0.Oo00O0.().ItemsDisplayMember = "";
			this.O0_0O_0.Oo00O0.().ItemsValueMember = "";
			this.O0_0O_0.Oo00O0.().Location = new Point(475, 19);
			this.O0_0O_0.Oo00O0.().Margin = new Padding(3, 1, 3, 1);
			this.O0_0O_0.Oo00O0.().Name = "cmbKeyCol";
			this.O0_0O_0.Oo00O0.().Size = new Size(140, 19);
			this.O0_0O_0.Oo00O0.().TabIndex = 2;
			this.O0_0O_0.Oo00O0.().Tag = null;
			this.OOO___.OoO.().AutoSize = true;
			this.OOO___.OoO.().Location = new Point(419, 22);
			this.OOO___.OoO.().Name = "Label2";
			this.OOO___.OoO.().Size = new Size(47, 12);
			this.OOO___.OoO.().TabIndex = 58;
			this.OOO___.OoO.().Text = "名称列:";
			this.Oo0._o_ooo_0o.().Location = new Point(63, 19);
			this.Oo0._o_ooo_0o.().Margin = new Padding(3, 1, 3, 1);
			this.Oo0._o_ooo_0o.().Name = "txtName";
			this.Oo0._o_ooo_0o.().Size = new Size(133, 19);
			this.Oo0._o_ooo_0o.().TabIndex = 0;
			this.Oo0._o_ooo_0o.().Tag = null;
			this.OOo_0_0O.00.().AutoSize = true;
			this.OOo_0_0O.00.().Location = new Point(19, 22);
			this.OOo_0_0O.00.().Name = "Label16";
			this.OOo_0_0O.00.().Size = new Size(35, 12);
			this.OOo_0_0O.00.().TabIndex = 61;
			this.OOo_0_0O.00.().Text = "表名:";
			this.o_.Ooo0o_.().AutoSize = true;
			this.o_.Ooo0o_.().BorderStyle = BorderStyle.None;
			this.o_.Ooo0o_.().Location = new Point(17, 67);
			this.o_.Ooo0o_.().Margin = new Padding(3, 1, 3, 1);
			this.o_.Ooo0o_.().Name = "chkShowTreeInPathCol";
			this.o_.Ooo0o_.().Size = new Size(132, 16);
			this.o_.Ooo0o_.().TabIndex = 62;
			this.o_.Ooo0o_.().Text = "在层级列显示折叠树";
			this.o_.Ooo0o_.().UseVisualStyleBackColor = true;
			this.o_.Ooo0o_.().Value = false;
			this.OOooO.__0Ooooo.().Controls.Add(this.O0o00o._0o0.());
			this.OOooO.__0Ooooo.().Controls.Add(this.OOooO.__0Ooooo.());
			this.OOooO.__0Ooooo.().Location = new Point(21, 305);
			this.OOooO.__0Ooooo.().Name = "C1DockingTab1";
			this.OOooO.__0Ooooo.().Size = new Size(594, 134);
			this.OOooO.__0Ooooo.().TabIndex = 63;
			this.OOooO.__0Ooooo.().TabsSpacing = 5;
			this.O0o00o._0o0.().Controls.Add(this.O0_0O_0.Oo00O0.());
			this.O0o00o._0o0.().Controls.Add(this.O_0.oO__.());
			this.O0o00o._0o0.().Controls.Add(this.o_.Ooo0o_.());
			this.O0o00o._0o0.().Controls.Add(this.O0o00o._0o0.());
			this.O0o00o._0o0.().Controls.Add(this.O___oooo_0.oO.());
			this.O0o00o._0o0.().Controls.Add(this.O0_0O_0.Oo00O0.());
			this.O0o00o._0o0.().Controls.Add(this.o0_0_oo0.0O_.());
			this.O0o00o._0o0.().Controls.Add(this.OOO___.OoO.());
			this.O0o00o._0o0.().Controls.Add(this.O0_0oo0O._O_.());
			this.O0o00o._0o0.().Location = new Point(1, 25);
			this.O0o00o._0o0.().Name = "C1DockingTabPage1";
			this.O0o00o._0o0.().Size = new Size(592, 108);
			this.O0o00o._0o0.().TabIndex = 0;
			this.O0o00o._0o0.().Text = "选项";
			this.OOooO.__0Ooooo.().Controls.Add(this.O00.OO.());
			this.OOooO.__0Ooooo.().Location = new Point(1, 25);
			this.OOooO.__0Ooooo.().Name = "C1DockingTabPage2";
			this.OOooO.__0Ooooo.().Size = new Size(592, 108);
			this.OOooO.__0Ooooo.().TabIndex = 1;
			this.OOooO.__0Ooooo.().Text = "附加列";
			this.O00.OO.().AllowDelete = true;
			this.O00.OO.().AllowDragging = AllowDraggingEnum.None;
			this.O00.OO.().AllowSorting = AllowSortingEnum.None;
			this.O00.OO.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.O00.OO.().ColumnInfo = componentResourceManager.GetString("grdAdditions.ColumnInfo");
			this.O00.OO.().Dock = DockStyle.Fill;
			this.O00.OO.().ExtendLastCol = true;
			this.O00.OO.().HighLight = HighLightEnum.WithFocus;
			this.O00.OO.().Location = new Point(0, 0);
			this.O00.OO.().Name = "grdAdditions";
			this.O00.OO.().Rows.Count = 1;
			this.O00.OO.().Rows.DefaultSize = 21;
			this.O00.OO.().SelectionMode = SelectionModeEnum.Row;
			this.O00.OO.().ShowThemedHeaders = ShowThemedHeadersEnum.None;
			this.O00.OO.().Size = new Size(592, 108);
			this.O00.OO.().TabIndex = 17;
			this.O00.OO.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(634, 503);
			base.Controls.Add(this.OOooO.__0Ooooo.());
			base.Controls.Add(this.O00.OO.());
			base.Controls.Add(this.O_0._.());
			base.Controls.Add(this.O0_0O_0.Oo00O0.());
			base.Controls.Add(this.OOO___.OoO.());
			base.Controls.Add(this.Oo0._o_ooo_0o.());
			base.Controls.Add(this.OOo_0_0O.00.());
			base.Controls.Add(this.O_0._.());
			base.Controls.Add(this.O0000.O.());
			base.Controls.Add(this.O0_0oo0O._O_.());
			base.Controls.Add(this.o0.O00.());
			base.Controls.Add(this.O0000.O.());
			base.Controls.Add(this.OOooO.__0Ooooo.());
			base.Controls.Add(this.O0o00o._0o0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(3, 1, 3, 1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.new";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "层级数据分组统计";
			((ISupportInitialize)this.O0_0O_0.Oo00O0.()).EndInit();
			((ISupportInitialize)this.OOooO.__0Ooooo.()).EndInit();
			((ISupportInitialize)this.O0o00o._0o0.()).EndInit();
			((ISupportInitialize)this.O_0.oO__.()).EndInit();
			((ISupportInitialize)this.O0o00o._0o0.()).EndInit();
			((ISupportInitialize)this.O___oooo_0.oO.()).EndInit();
			this.O0_0O_0.Oo00O0.().ResumeLayout(false);
			((ISupportInitialize)this.OOO___.OoO.()).EndInit();
			((ISupportInitialize)this.o0_0_oo0.0O_.()).EndInit();
			((ISupportInitialize)this.O0000.O.()).EndInit();
			((ISupportInitialize)this.O_0._.()).EndInit();
			((ISupportInitialize)this.o0.O00.()).EndInit();
			((ISupportInitialize)this.O00.OO.()).EndInit();
			((ISupportInitialize)this.O0_0O_0.Oo00O0.()).EndInit();
			((ISupportInitialize)this.Oo0._o_ooo_0o.()).EndInit();
			((ISupportInitialize)this.o_.Ooo0o_.()).EndInit();
			((ISupportInitialize)this.OOooO.__0Ooooo.()).EndInit();
			this.OOooO.__0Ooooo.().ResumeLayout(false);
			this.O0o00o._0o0.().ResumeLayout(false);
			this.O0o00o._0o0.().PerformLayout();
			this.OOooO.__0Ooooo.().ResumeLayout(false);
			((ISupportInitialize)this.O00.OO.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00059B74 File Offset: 0x00057D74
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o_oo0.O.;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00059B7C File Offset: 0x00057D7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.OO._0_.);
			C1CheckBox c1CheckBox = this.o_oo0.O.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged -= value;
			}
			this.o_oo0.O. = A_0;
			c1CheckBox = this.o_oo0.O.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged += value;
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00059BBF File Offset: 0x00057DBF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_o0OoO.OoO.;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00059BC7 File Offset: 0x00057DC7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.Oo_o0OoO.OoO. = A_0;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00059BD0 File Offset: 0x00057DD0
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_o_O.O.;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00059BD8 File Offset: 0x00057DD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0.o0O_.);
			C1Button o_o_O.O. = this.O_o_O.O.;
			if (o_o_O.O. != null)
			{
				o_o_O.O..Click -= value;
			}
			this.O_o_O.O. = A_0;
			o_o_O.O. = this.O_o_O.O.;
			if (o_o_O.O. != null)
			{
				o_o_O.O..Click += value;
			}
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00059C1B File Offset: 0x00057E1B
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o_O.OO.;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00059C23 File Offset: 0x00057E23
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o_O.OO. = A_0;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00059C2C File Offset: 0x00057E2C
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o0o__000o_o.OO.;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00059C34 File Offset: 0x00057E34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.O00oO0_o.00.);
			C1CheckBox c1CheckBox = this.o0o__000o_o.OO.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged -= value;
			}
			this.o0o__000o_o.OO. = A_0;
			c1CheckBox = this.o0o__000o_o.OO.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged += value;
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00059C77 File Offset: 0x00057E77
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oooo00o.o0__.;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00059C7F File Offset: 0x00057E7F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.oooo00o.o0__. = A_0;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00059C88 File Offset: 0x00057E88
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_0.0O__OO0.;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00059C90 File Offset: 0x00057E90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_0.0O__OO0. = A_0;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00059C99 File Offset: 0x00057E99
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.o_oo0.O.;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00059CA1 File Offset: 0x00057EA1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.o_oo0.O. = A_0;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00059CAC File Offset: 0x00057EAC
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o_0.0O__OO0.;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00059CC0 File Offset: 0x00057EC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.Oo0._o_ooo_0o.);
				ToolStripMenuItem toolStripMenuItem = this.o_0.0O__OO0.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (toolStripMenuItem != null)
						{
							num = 1;
							continue;
						}
						return;
					case 1:
						toolStripMenuItem.Click += value;
						num = 4;
						continue;
					case 2:
						goto IL_62;
					case 3:
						toolStripMenuItem.Click -= value;
						num = 2;
						continue;
					case 4:
						return;
					case 5:
						if (true)
						{
						}
						if (toolStripMenuItem != null)
						{
							num = 3;
							continue;
						}
						goto IL_62;
					}
					break;
					IL_62:
					this.o_0.0O__OO0. = A_0;
					toolStripMenuItem = this.o_0.0O__OO0.;
					num = 0;
				}
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00059D6C File Offset: 0x00057F6C
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o_O.OO.;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00059D80 File Offset: 0x00057F80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O0o.000o0oo_0_.);
				ToolStripMenuItem toolStripMenuItem = this.o_O.OO.;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (toolStripMenuItem != null)
						{
							if (true)
							{
							}
							num = 3;
							continue;
						}
						goto IL_62;
					case 1:
						toolStripMenuItem.Click += value;
						num = 5;
						continue;
					case 2:
						goto IL_62;
					case 3:
						toolStripMenuItem.Click -= value;
						num = 2;
						continue;
					case 4:
						if (toolStripMenuItem != null)
						{
							num = 1;
							continue;
						}
						return;
					case 5:
						return;
					}
					break;
					IL_62:
					this.o_O.OO. = A_0;
					toolStripMenuItem = this.o_O.OO.;
					num = 4;
				}
			}
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00059E2C File Offset: 0x0005802C
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.OOO.___oO_o_O0.;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00059E40 File Offset: 0x00058040
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.oO_o_._.);
				ToolStripMenuItem ooo.___oO_o_O0. = this.OOO.___oO_o_O0.;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (ooo.___oO_o_O0. != null)
						{
							num = 5;
							continue;
						}
						goto IL_5A;
					case 1:
						goto IL_5A;
					case 2:
						return;
					case 3:
						ooo.___oO_o_O0..Click += value;
						num = 2;
						continue;
					case 4:
						if (ooo.___oO_o_O0. != null)
						{
							num = 3;
							continue;
						}
						return;
					case 5:
						if (true)
						{
						}
						ooo.___oO_o_O0..Click -= value;
						num = 1;
						continue;
					}
					break;
					IL_5A:
					this.OOO.___oO_o_O0. = A_0;
					ooo.___oO_o_O0. = this.OOO.___oO_o_O0.;
					num = 4;
				}
			}
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00059EE8 File Offset: 0x000580E8
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o.00_o_o_0O.;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00059EFC File Offset: 0x000580FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o.o__Oo0_O0.);
				ToolStripMenuItem toolStripMenuItem = this.o.00_o_o_0O.;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (toolStripMenuItem != null)
						{
							num = 4;
							continue;
						}
						return;
					case 1:
						if (toolStripMenuItem != null)
						{
							num = 2;
							continue;
						}
						goto IL_5A;
					case 2:
						if (true)
						{
						}
						toolStripMenuItem.Click -= value;
						num = 5;
						continue;
					case 3:
						return;
					case 4:
						toolStripMenuItem.Click += value;
						num = 3;
						continue;
					case 5:
						goto IL_5A;
					}
					break;
					IL_5A:
					this.o.00_o_o_0O. = A_0;
					toolStripMenuItem = this.o.00_o_o_0O.;
					num = 0;
				}
			}
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00059FA2 File Offset: 0x000581A2
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O00o__._o_o00_.;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00059FAA File Offset: 0x000581AA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O00o__._o_o00_. = A_0;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00059FB3 File Offset: 0x000581B3
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o.00OO_0o.;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00059FBB File Offset: 0x000581BB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o.00OO_0o. = A_0;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00059FC4 File Offset: 0x000581C4
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O_O.o__oOo.;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00059FCC File Offset: 0x000581CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.O00oO0_o.00.);
			C1CheckBox o_O.o__oOo. = this.O_O.o__oOo.;
			if (o_O.o__oOo. != null)
			{
				o_O.o__oOo..CheckedChanged -= value;
			}
			this.O_O.o__oOo. = A_0;
			o_O.o__oOo. = this.O_O.o__oOo.;
			if (o_O.o__oOo. != null)
			{
				o_O.o__oOo..CheckedChanged += value;
			}
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0005A00F File Offset: 0x0005820F
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.oooo00o.o0__.;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0005A018 File Offset: 0x00058218
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.Ooo00.__.);
			RowColEventHandler value2 = new RowColEventHandler(this.oO.O0oo0_.);
			ValidateEditEventHandler value3 = new ValidateEditEventHandler(this.Oo_o0OoO.OoO.);
			C1FlexGrid c1FlexGrid = this.oooo00o.o0__.;
			if (c1FlexGrid != null)
			{
				c1FlexGrid.BeforeEdit -= value;
				c1FlexGrid.AfterEdit -= value2;
				c1FlexGrid.ValidateEdit -= value3;
			}
			this.oooo00o.o0__. = A_0;
			c1FlexGrid = this.oooo00o.o0__.;
			if (c1FlexGrid != null)
			{
				c1FlexGrid.BeforeEdit += value;
				c1FlexGrid.AfterEdit += value2;
				c1FlexGrid.ValidateEdit += value3;
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0005A091 File Offset: 0x00058291
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.OO.0oo__.;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0005A099 File Offset: 0x00058299
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.OO.0oo__. = A_0;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0005A0A2 File Offset: 0x000582A2
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o_0.0O__OO0.;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0005A0AC File Offset: 0x000582AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.OO_O0oO0.O.);
			RadioButton radioButton = this.o_0.0O__OO0.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.o_0.0O__OO0. = A_0;
			radioButton = this.o_0.0O__OO0.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0005A0EF File Offset: 0x000582EF
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O00o__._o_o00_.;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0005A0F8 File Offset: 0x000582F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.OO_O0oO0.O.);
			RadioButton o00o__._o_o00_. = this.O00o__._o_o00_.;
			if (o00o__._o_o00_. != null)
			{
				o00o__._o_o00_..CheckedChanged -= value;
			}
			this.O00o__._o_o00_. = A_0;
			o00o__._o_o00_. = this.O00o__._o_o00_.;
			if (o00o__._o_o00_. != null)
			{
				o00o__._o_o00_..CheckedChanged += value;
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0005A13B File Offset: 0x0005833B
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o.o_0O_0o0____.;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0005A143 File Offset: 0x00058343
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o.o_0O_0o0____. = A_0;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0005A14C File Offset: 0x0005834C
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o_oo0.O.;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0005A154 File Offset: 0x00058354
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.o_oo0.O. = A_0;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0005A15D File Offset: 0x0005835D
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OOO.___oO_o_O0.;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0005A165 File Offset: 0x00058365
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OOO.___oO_o_O0. = A_0;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0005A16E File Offset: 0x0005836E
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o_O.OO.;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0005A176 File Offset: 0x00058376
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.o_O.OO. = A_0;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0005A17F File Offset: 0x0005837F
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.00_o_o_0O.;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0005A187 File Offset: 0x00058387
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.00_o_o_0O. = A_0;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0005A190 File Offset: 0x00058390
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oOoo_0o.__o0_o.;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0005A198 File Offset: 0x00058398
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.oOoo_0o.__o0_o. = A_0;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0005A1A1 File Offset: 0x000583A1
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_0_O.oo0.;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0005A1A9 File Offset: 0x000583A9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_0_O.oo0. = A_0;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0005A1B2 File Offset: 0x000583B2
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o_._OO_O0Oo.;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0005A1BA File Offset: 0x000583BA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o_._OO_O0Oo. = A_0;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0005A1C3 File Offset: 0x000583C3
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.Oo_o0OoO.OoO.;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0005A1CB File Offset: 0x000583CB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			this.Oo_o0OoO.OoO. = A_0;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0005A1D4 File Offset: 0x000583D4
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.Oo_o0OoO.OoO.;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0005A1DC File Offset: 0x000583DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.Oo_o0OoO.OoO. = A_0;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0005A1E5 File Offset: 0x000583E5
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.O_o_O.O.;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0005A1ED File Offset: 0x000583ED
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.O_o_O.O. = A_0;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0005A1F6 File Offset: 0x000583F6
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.o_O.OO.;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0005A200 File Offset: 0x00058400
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.o0.O00.);
			RowColEventHandler value2 = new RowColEventHandler(this.O___oooo_0.oO.);
			C1FlexGrid c1FlexGrid = this.o_O.OO.;
			if (c1FlexGrid != null)
			{
				c1FlexGrid.AfterEdit -= value;
				c1FlexGrid.BeforeEdit -= value2;
			}
			this.o_O.OO. = A_0;
			c1FlexGrid = this.o_O.OO.;
			if (c1FlexGrid != null)
			{
				c1FlexGrid.AfterEdit += value;
				c1FlexGrid.BeforeEdit += value2;
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0005A260 File Offset: 0x00058460
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oooo00o.o0__. = OO_00oOO.MainTable;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
			{
				this.OOooO.__0Ooooo.()
			});
			if (Operators.CompareString(this.oooo00o.o0__..O_O0._..TableName, "", true) > 0)
			{
				this.Oo0._o_ooo_0o.().Value = this.oooo00o.o0__..O_O0._..TableName;
			}
			else
			{
				this.Oo0._o_ooo_0o.().Value = Oo00.oo0o.O0O_0__.("统计表");
			}
			this.O0_0O_0.Oo00O0.().Checked = this.oooo00o.o0__..O_O0._..GridTree;
			this.O_0.oO__.().Checked = this.oooo00o.o0__..O_O0._..OnlyGroupRows;
			if (this.O0_0O_0.Oo00O0.().Checked)
			{
				this.o_.Ooo0o_.().Checked = this.oooo00o.o0__..O_O0._..ShowTreeInPathCol;
			}
			if (this.oooo00o.o0__..O_O0._..ExpandTo > -1 && this.O0_0O_0.Oo00O0.().Checked)
			{
				this.OOO___.OoO.().Value = this.oooo00o.o0__..O_O0._..ExpandTo;
				this.o0_0_oo0.0O_.().Checked = true;
			}
			if (this.oooo00o.o0__..O_O0._..PreserveTo > -1)
			{
				this.O___oooo_0.oO.().Value = this.oooo00o.o0__..O_O0._..PreserveTo;
				this.O0o00o._0o0.().Checked = true;
			}
			if (this.oooo00o.o0__..O_O0._..Totals.Count > 0)
			{
				try
				{
					foreach (o0o_ o0o_ in this.oooo00o.o0__..O_O0._..Totals)
					{
						if (o0o_.o0oO._o_.() == AggregateType.Count)
						{
							this.O0000.O.().AddItem(new object[]
							{
								"记录数\t",
								(int)o0o_.o0oO._o_.(),
								(int)o0o_.O0OO_0.O.(),
								o0o_.Oo0oO0oOO_.0_o.()
							});
						}
						else if (this.oooo00o.o0__..DataTable.BaseTable.Columns.Contains(o0o_.o0oO._o_.()))
						{
							this.O0000.O.().AddItem(new object[]
							{
								o0o_.o0oO._o_.(),
								(int)o0o_.o0oO._o_.(),
								(int)o0o_.O0OO_0.O.(),
								o0o_.Oo0oO0oOO_.0_o.()
							});
						}
					}
				}
				finally
				{
					List<o0o_>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			if (Operators.CompareString(Conversions.ToString(this.oooo00o.o0__..o00oOO00_.ooOo.), "", true) > 0)
			{
				this.o0.O00.().Value = this.oooo00o.o0__..o00oOO00_.ooOo.;
			}
			if (Operators.CompareString(this.oooo00o.o0__..oo.o0o0O_o_., "", true) > 0)
			{
				this.O_0._.().Value = this.oooo00o.o0__..oo.o0o0O_o_.;
				this.O0000.O.().Checked = true;
			}
			string text = "";
			try
			{
				foreach (DataTable dataTable in OO_00oOO.DataTables)
				{
					text = text + "|" + dataTable.Name;
				}
			}
			finally
			{
				IEnumerator<DataTable> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			this.O00.OO.().Cols[0].ComboList = text.Trim(new char[]
			{
				'|'
			});
			try
			{
				foreach (o00_0__O o00_0__O in this.oooo00o.o0__..O_O0._..Additions)
				{
					this.O00.OO.().AddItem(new object[]
					{
						o00_0__O.oo__.0O00.().Name,
						o00_0__O.oooO00__.o0.(),
						o00_0__O.oooO00.o00O.(),
						o00_0__O.o.oOo_Oo0O.()
					});
				}
			}
			finally
			{
				IEnumerator<o00_0__O> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			this.O00.OO.().AllowAddNew = true;
			string text2 = "";
			this.O0_0O_0.Oo00O0.().Items.Add("");
			try
			{
				foreach (DataCol dataCol in this.oooo00o.o0__..DataTable.DataCols)
				{
					if (dataCol.IsString)
					{
						this.O00.OO.().Items.Add(dataCol.Name);
						this.O0_0O_0.Oo00O0.().Items.Add(dataCol.Name);
						if (Operators.CompareString(this.oooo00o.o0__..o_O_0._O_., dataCol.Name, true) == 0)
						{
							this.O00.OO.().SelectedIndex = this.O00.OO.().Items.Count - 1;
						}
						if (Operators.CompareString(this.oooo00o.o0__..ooO0o.o_O., dataCol.Name, true) == 0)
						{
							this.O0_0O_0.Oo00O0.().SelectedIndex = this.O0_0O_0.Oo00O0.().Items.Count - 1;
						}
					}
					else if (dataCol.IsNumeric)
					{
						text2 = text2 + dataCol.Name + "|";
					}
				}
			}
			finally
			{
				IEnumerator<DataCol> enumerator4;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
			}
			text2 += "记录数\t";
			this.O0000.O.().Cols[0].ComboList = text2;
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary.Add(0, "累计值");
			dictionary.Add(1, "最大值");
			dictionary.Add(2, "最小值");
			dictionary.Add(3, "平均值");
			dictionary.Add(4, "记录数");
			this.O0000.O.().Cols[1].DataMap = dictionary;
			dictionary = new Dictionary<int, string>();
			dictionary.Add(0, "本级");
			dictionary.Add(1, "下级");
			dictionary.Add(2, "全部");
			this.O0000.O.().Cols[2].DataMap = dictionary;
			this.O0000.O.().Col = 0;
			this.O0000.O.().ContextMenuStrip = this.O0_0O_0.Oo00O0.();
			this.O0000.O.().AllowAddNew = true;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0005A898 File Offset: 0x00058A98
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0005A8AA File Offset: 0x00058AAA
		private string <<EMPTY_NAME>>(string A_0)
		{
			return A_0;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0005A8B0 File Offset: 0x00058AB0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			LayersGroupTableBuilder layersGroupTableBuilder = new LayersGroupTableBuilder(this.Oo0._o_ooo_0o.().Text.Trim(), OO_00oOO.MainTable.DataTable);
			layersGroupTableBuilder.Filter = OO_00oOO.MainTable.Filter;
			if (this.O00.OO.().SelectedItem != null)
			{
				layersGroupTableBuilder.PathCol = this.O00.OO.().SelectedItem.ToString();
				if (this.O0_0O_0.Oo00O0.().SelectedItem != null)
				{
					layersGroupTableBuilder.NameCol = this.O0_0O_0.Oo00O0.().SelectedItem.ToString();
				}
				layersGroupTableBuilder.Filter = this.oooo00o.o0__..Filter;
				layersGroupTableBuilder.GridTree = this.O0_0O_0.Oo00O0.().Checked;
				layersGroupTableBuilder.OnlyGroupRows = this.O_0.oO__.().Checked;
				if (layersGroupTableBuilder.GridTree)
				{
					layersGroupTableBuilder.ShowTreeInPathCol = this.o_.Ooo0o_.().Checked;
					if (this.o0_0_oo0.0O_.().Checked)
					{
						layersGroupTableBuilder.ExpandTo = Conversions.ToInteger(this.OOO___.OoO.().Value);
					}
				}
				if (this.O0o00o._0o0.().Checked)
				{
					layersGroupTableBuilder.PreserveTo = Conversions.ToInteger(this.O___oooo_0.oO.().Value);
				}
				if (this.O0_0oo0O._O_.().Checked && Operators.CompareString(this.o0.O00.().Text, "", true) > 0)
				{
					layersGroupTableBuilder.Separator = Conversions.ToString(this.o0.O00.().Text[0]);
				}
				else
				{
					if (!this.O0000.O.().Checked || Operators.CompareString(this.O_0._.().Text, "", true) <= 0)
					{
						return;
					}
					string[] array = Regex.Split(this.O_0._.().Text, "[^\\d]+");
					List<object> list = new List<object>();
					if (array.Length > 0)
					{
						int num = array.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							int num2;
							if (int.TryParse(array[i], out num2))
							{
								list.Add(num2);
							}
						}
						if (list.Count == array.Length)
						{
							layersGroupTableBuilder.lengths = list.ToArray();
						}
						else
						{
							MessageBox.Show("请正确输入用逗号分割的长度，例如:1,3,2");
						}
					}
				}
				int num3 = this.O0000.O.().Rows.Count - 2;
				for (int j = 1; j <= num3; j++)
				{
					if (this.O0000.O.().GetData(j, 0) == null || this.O0000.O.().GetData(j, 1) == null || this.O0000.O.().GetData(j, 2) == null || this.O0000.O.().GetData(j, 3) == null)
					{
						return;
					}
					string column = this.O___oooo_0.oO.(this.O0000.O.().GetData(j, 0).ToString());
					AggregateType aggregateType = (AggregateType)Conversions.ToInteger(this.O0000.O.().GetData(j, 1));
					AggregateRange aggregateRange = (AggregateRange)Conversions.ToInteger(this.O0000.O.().GetData(j, 2));
					string newName = this.O0000.O.().GetData(j, 3).ToString();
					if (aggregateType == AggregateType.Count)
					{
						layersGroupTableBuilder.AddTotal(true, newName, aggregateRange);
					}
					else
					{
						layersGroupTableBuilder.AddTotal(column, newName, aggregateRange, aggregateType);
					}
				}
				string[] array2 = new string[4];
				int num4 = this.O00.OO.().Rows.Count - 1;
				for (int k = 1; k <= num4; k++)
				{
					array2[0] = this.O00.OO.().GetDataDisplay(k, 0);
					array2[1] = this.O00.OO.().GetDataDisplay(k, 1);
					array2[2] = this.O00.OO.().GetDataDisplay(k, 2);
					array2[3] = this.O00.OO.().GetDataDisplay(k, 3);
					if (Operators.CompareString(array2[0], "", true) > 0 && Operators.CompareString(array2[1], "", true) > 0 && Operators.CompareString(array2[2], "", true) > 0 && Operators.CompareString(array2[3], "", true) > 0 && OO_00oOO.DataTables.Contains(array2[0]) && OO_00oOO.DataTables[array2[0]].BaseTable.Columns.Contains(array2[1]) && OO_00oOO.DataTables[array2[0]].BaseTable.Columns.Contains(array2[2]))
					{
						layersGroupTableBuilder.Additions.Add(OO_00oOO.DataTables[array2[0]], array2[1], array2[2], array2[3]);
					}
				}
				if (layersGroupTableBuilder.Totals.Count > 0 && layersGroupTableBuilder.Build() != null)
				{
					this.oooo00o.o0__..O_O0._. = new InlineGroupTableBuilder();
					this.oooo00o.o0__..O_O0._. = layersGroupTableBuilder;
					this.oooo00o.o0__..o_O_0._O_. = layersGroupTableBuilder.PathCol;
					this.oooo00o.o0__..ooO0o.o_O. = layersGroupTableBuilder.NameCol;
					this.oooo00o.o0__..o00oOO00_.ooOo. = layersGroupTableBuilder.Separator2;
					this.oooo00o.o0__..oo.o0o0O_o_. = this.O_0._.().Text;
					this.oooo00o.o0__..NeedSaveSetting = true;
					this.oooo00o.o0__..oo0OO0Ooo._.(true);
					base.DialogResult = DialogResult.OK;
					OO_00oOO.MainTable = OO_00oOO.Tables[layersGroupTableBuilder.TableName];
				}
			}
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0005AD90 File Offset: 0x00058F90
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Row > 0 && A_1.Col > 0)
			{
				if (this.O0000.O.().GetData(A_1.Row, 0) == null)
				{
					A_1.Cancel = true;
					return;
				}
				string left = this.O0000.O.().GetData(A_1.Row, 0).ToString();
				if (A_1.Col == 1 && Operators.CompareString(left, "记录数\t", true) == 0)
				{
					A_1.Cancel = true;
				}
			}
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0005AE04 File Offset: 0x00059004
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (this.O0000.O.().Col == 0 && this.O0000.O.().GetData(A_1.Row, 0) != null)
			{
				string text = this.O0000.O.().GetData(A_1.Row, 0).ToString();
				if (Operators.CompareString(text, "记录数\t", true) == 0)
				{
					this.O0000.O.()[A_1.Row, 1] = 4;
				}
				else
				{
					this.O0000.O.()[A_1.Row, 1] = 0;
				}
				text = text.Trim();
				string text2 = text;
				int num = 1;
				for (;;)
				{
					bool flag = false;
					int num2 = this.O0000.O.().Rows.Count - 2;
					for (int i = 1; i <= num2; i++)
					{
						if (this.O0000.O.().GetData(i, 3) != null && Operators.CompareString(this.O0000.O.().GetData(i, 3).ToString(), text2, true) == 0)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						break;
					}
					text2 = text + Conversions.ToString(num);
					num++;
					if (num > 1000)
					{
						goto IL_113;
					}
				}
				this.O0000.O.()[A_1.Row, 3] = text2;
				IL_113:
				this.O0000.O.()[A_1.Row, 2] = 2;
			}
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0005AF3C File Offset: 0x0005913C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.ActiveControl is C1FlexGrid)
			{
				C1FlexGrid c1FlexGrid = (C1FlexGrid)base.ActiveControl;
				int topRow = c1FlexGrid.Selection.TopRow;
				int bottomRow = c1FlexGrid.Selection.BottomRow;
				int num = topRow;
				while (num <= bottomRow && num != c1FlexGrid.Rows.Count - 1)
				{
					c1FlexGrid.Rows.Remove(num);
					num++;
				}
			}
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0005AFA8 File Offset: 0x000591A8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.ActiveControl is C1FlexGrid)
			{
				C1FlexGrid c1FlexGrid = (C1FlexGrid)base.ActiveControl;
				if (c1FlexGrid.Row > c1FlexGrid.Rows.Fixed)
				{
					c1FlexGrid.Rows[c1FlexGrid.Row].Move(c1FlexGrid.Row - 1);
				}
			}
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0005B000 File Offset: 0x00059200
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.ActiveControl is C1FlexGrid)
			{
				C1FlexGrid c1FlexGrid = (C1FlexGrid)base.ActiveControl;
				if (c1FlexGrid.Row < c1FlexGrid.Rows.Count - 2)
				{
					c1FlexGrid.Rows[c1FlexGrid.Row].Move(c1FlexGrid.Row + 1);
				}
			}
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0005B05C File Offset: 0x0005925C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.ActiveControl is C1FlexGrid)
			{
				C1FlexGrid c1FlexGrid = (C1FlexGrid)base.ActiveControl;
				int num = Math.Max(c1FlexGrid.Row, c1FlexGrid.Rows.Fixed);
				c1FlexGrid.Rows.Insert(num);
				c1FlexGrid.Row = num;
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0005B0AD File Offset: 0x000592AD
		private void <<EMPTY_NAME>>(object A_0, ValidateEditEventArgs A_1)
		{
			if (A_1.Col == 3 && Operators.CompareString(this.O0000.O.().Editor.Text, "", true) == 0)
			{
				A_1.Cancel = true;
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0005B0DC File Offset: 0x000592DC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OOO___.OoO.().Enabled = this.o0_0_oo0.0O_.().Checked;
			this.O___oooo_0.oO.().Enabled = this.O0o00o._0o0.().Checked;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0005B10C File Offset: 0x0005930C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0_0_oo0.0O_.().Enabled = this.O0_0O_0.Oo00O0.().Checked;
			this.o_.Ooo0o_.().Enabled = this.O0_0O_0.Oo00O0.().Checked;
			if (!this.O0_0O_0.Oo00O0.().Checked)
			{
				this.o0_0_oo0.0O_.().Checked = false;
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0005B15E File Offset: 0x0005935E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_0._.().Enabled = this.O0000.O.().Checked;
			this.o0.O00.().Enabled = this.O0_0oo0O._O_.().Checked;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0005B18C File Offset: 0x0005938C
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Col == 0)
			{
				int num = this.O00.OO.().Cols.Count - 1;
				for (int i = 1; i <= num; i++)
				{
					this.O00.OO.().SetData(A_1.Row, i, null);
				}
				return;
			}
			if (A_1.Col == 2)
			{
				string dataDisplay = this.O00.OO.().GetDataDisplay(A_1.Row, 2);
				this.O00.OO.().SetData(A_1.Row, 3, dataDisplay);
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0005B208 File Offset: 0x00059408
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Row > 0 && (A_1.Col == 1 || A_1.Col == 2))
			{
				string dataDisplay = this.O00.OO.().GetDataDisplay(A_1.Row, 0);
				string text = "";
				if (OO_00oOO.DataTables.Contains(dataDisplay))
				{
					try
					{
						foreach (DataCol dataCol in OO_00oOO.DataTables[dataDisplay].DataCols)
						{
							text = text + "|" + dataCol.Name;
						}
					}
					finally
					{
						IEnumerator<DataCol> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				this.O00.OO.().Cols[1].ComboList = text.Trim(new char[]
				{
					'|'
				});
				this.O00.OO.().Cols[2].ComboList = text.Trim(new char[]
				{
					'|'
				});
			}
		}

		// Token: 0x040003EC RID: 1004
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040003ED RID: 1005
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040003EE RID: 1006
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003EF RID: 1007
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003F0 RID: 1008
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040003F1 RID: 1009
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040003F2 RID: 1010
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040003F3 RID: 1011
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040003F4 RID: 1012
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x040003F5 RID: 1013
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040003F6 RID: 1014
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040003F7 RID: 1015
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040003F8 RID: 1016
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040003F9 RID: 1017
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040003FA RID: 1018
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040003FB RID: 1019
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040003FC RID: 1020
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x040003FD RID: 1021
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040003FE RID: 1022
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x040003FF RID: 1023
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04000400 RID: 1024
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000401 RID: 1025
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000402 RID: 1026
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000403 RID: 1027
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000404 RID: 1028
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000405 RID: 1029
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000406 RID: 1030
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000407 RID: 1031
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04000408 RID: 1032
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x04000409 RID: 1033
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x0400040A RID: 1034
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x0400040B RID: 1035
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x0400040C RID: 1036
		private Table <<EMPTY_NAME>>;
	}
}
