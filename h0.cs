using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000DA RID: 218
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	internal partial class h0 : Form
	{
		// Token: 0x06000A36 RID: 2614 RVA: 0x000549D9 File Offset: 0x00052BD9
		public h0()
		{
			base.Load += this.oOo_o__o_.0__o.;
			base.FormClosed += this.oo_o.Oo.;
			this.o0_O.00____. = OO_00oOO.MainTable;
			this.OOoOO_O_.0.();
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00054A18 File Offset: 0x00052C18
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o0_O.00____. != null)
				{
					this.o0_O.00____..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00054A58 File Offset: 0x00052C58
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0_O.00____. = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(h0));
			this.OO0._o.(new C1TextBox());
			this.o_oOOO.o0oO0.(new Label());
			this.OO0.O.(new C1ComboBox());
			this.OO0._o.(new Label());
			this.O.00__o.(new Label());
			this.OO___.0.(new C1ComboBox());
			this.o.O0oO0.(new C1CheckBox());
			this.o.0__.(new C1Button());
			this.O00o0._oO.(new C1Button());
			this.oO_._oO.(new C1CheckBox());
			this.oO_0Oo.o_.(new C1CheckBox());
			this.o_oOOO.o0oO0.(new C1TextBox());
			this.OOO__.0o_o_.(new Label());
			this.OO0._o.(new C1FlexGrid());
			this.OO___.0.(new ContextMenuStrip(this.o0_O.00____.));
			this.OO0.O.(new ToolStripMenuItem());
			this.OOO__.0o_o_.(new ToolStripMenuItem());
			this.o_oOOO.o0oO0.(new ToolStripMenuItem());
			this.OO0._o.(new ToolStripMenuItem());
			this.Oo0.0o0_.(new Label());
			this.O.00__o.(new C1TextBox());
			this.o.0__.(new C1CheckBox());
			this.o.o_O_000O.(new C1CheckBox());
			this.OO0.O.(new C1CheckBox());
			this.o.0__.(new C1DockingTab());
			this.O00o0._oO.(new C1DockingTabPage());
			this.o.0__.(new C1DockingTabPage());
			this.OO0.O.(new C1FlexGrid());
			((ISupportInitialize)this.oo_.oo00o0.()).BeginInit();
			((ISupportInitialize)this.o.0_0__.()).BeginInit();
			((ISupportInitialize)this.o00oo_0oo.o.()).BeginInit();
			((ISupportInitialize)this.o.0_0__.()).BeginInit();
			((ISupportInitialize)this.oo_o.Oo.()).BeginInit();
			((ISupportInitialize)this.oO.0_o_o_0_.()).BeginInit();
			((ISupportInitialize)this.O_o__0oooO.OOO.()).BeginInit();
			((ISupportInitialize)this.O.OO00oO.()).BeginInit();
			((ISupportInitialize)this.OOoOO_O_.0.()).BeginInit();
			((ISupportInitialize)this.OOoOO_O_.0.()).BeginInit();
			this.O_O.Oo_oO.().SuspendLayout();
			((ISupportInitialize)this.o_.0OO.()).BeginInit();
			((ISupportInitialize)this.oO0_00O_oo.0.()).BeginInit();
			((ISupportInitialize)this.o00oo_0oo.o.()).BeginInit();
			((ISupportInitialize)this.OO0oo0_.0.()).BeginInit();
			((ISupportInitialize)this.oo_o.Oo.()).BeginInit();
			this.oo_o.Oo.().SuspendLayout();
			this.o00oo_0oo.o.().SuspendLayout();
			this.o.0_0__.().SuspendLayout();
			((ISupportInitialize)this.ooo___o_O_0_.o.()).BeginInit();
			base.SuspendLayout();
			this.oo_.oo00o0.().Location = new Point(65, 24);
			this.oo_.oo00o0.().Margin = new Padding(3, 1, 3, 1);
			this.oo_.oo00o0.().Name = "txtName";
			this.oo_.oo00o0.().Size = new Size(138, 19);
			this.oo_.oo00o0.().TabIndex = 0;
			this.oo_.oo00o0.().Tag = null;
			this.O_O.Oo_oO.().AutoSize = true;
			this.O_O.Oo_oO.().Location = new Point(21, 27);
			this.O_O.Oo_oO.().Name = "Label16";
			this.O_O.Oo_oO.().Size = new Size(35, 12);
			this.O_O.Oo_oO.().TabIndex = 15;
			this.O_O.Oo_oO.().Text = "表名:";
			this.o.0_0__.().AllowSpinLoop = false;
			this.o.0_0__.().Cursor = Cursors.Arrow;
			this.o.0_0__.().DropDownStyle = DropDownStyle.DropDownList;
			this.o.0_0__.().GapHeight = 0;
			this.o.0_0__.().ImagePadding = new Padding(0);
			this.o.0_0__.().ItemsDisplayMember = "";
			this.o.0_0__.().ItemsValueMember = "";
			this.o.0_0__.().Location = new Point(462, 24);
			this.o.0_0__.().Margin = new Padding(3, 1, 3, 1);
			this.o.0_0__.().Name = "cmbKeyCol";
			this.o.0_0__.().Size = new Size(155, 19);
			this.o.0_0__.().TabIndex = 2;
			this.o.0_0__.().Tag = null;
			this.OO_00_o.__O.().AutoSize = true;
			this.OO_00_o.__O.().Location = new Point(421, 27);
			this.OO_00_o.__O.().Name = "Label2";
			this.OO_00_o.__O.().Size = new Size(35, 12);
			this.OO_00_o.__O.().TabIndex = 2;
			this.OO_00_o.__O.().Text = "子列:";
			this.o_O.o__O_.().AutoSize = true;
			this.o_O.o__O_.().Location = new Point(216, 27);
			this.o_O.o__O_.().Name = "Label3";
			this.o_O.o__O_.().Size = new Size(35, 12);
			this.o_O.o__O_.().TabIndex = 4;
			this.o_O.o__O_.().Text = "父列:";
			this.o00oo_0oo.o.().AllowSpinLoop = false;
			this.o00oo_0oo.o.().Cursor = Cursors.Arrow;
			this.o00oo_0oo.o.().DropDownStyle = DropDownStyle.DropDownList;
			this.o00oo_0oo.o.().GapHeight = 0;
			this.o00oo_0oo.o.().ImagePadding = new Padding(0);
			this.o00oo_0oo.o.().ItemsDisplayMember = "";
			this.o00oo_0oo.o.().ItemsValueMember = "";
			this.o00oo_0oo.o.().Location = new Point(257, 24);
			this.o00oo_0oo.o.().Margin = new Padding(3, 1, 3, 1);
			this.o00oo_0oo.o.().Name = "cmbParentCol";
			this.o00oo_0oo.o.().Size = new Size(155, 19);
			this.o00oo_0oo.o.().TabIndex = 1;
			this.o00oo_0oo.o.().Tag = "1";
			this.o.0_0__.().AutoSize = true;
			this.o.0_0__.().BorderStyle = BorderStyle.None;
			this.o.0_0__.().Checked = true;
			this.o.0_0__.().CheckState = CheckState.Checked;
			this.o.0_0__.().Location = new Point(26, 19);
			this.o.0_0__.().Margin = new Padding(3, 1, 3, 1);
			this.o.0_0__.().Name = "chkShowTree";
			this.o.0_0__.().Size = new Size(84, 16);
			this.o.0_0__.().TabIndex = 4;
			this.o.0_0__.().Text = "显示折叠树";
			this.o.0_0__.().UseVisualStyleBackColor = true;
			this.o.0_0__.().Value = true;
			this.oo_o.Oo.().DialogResult = DialogResult.Cancel;
			this.oo_o.Oo.().Location = new Point(330, 425);
			this.oo_o.Oo.().Margin = new Padding(3, 1, 3, 1);
			this.oo_o.Oo.().Name = "btnCancel";
			this.oo_o.Oo.().Size = new Size(75, 23);
			this.oo_o.Oo.().TabIndex = 13;
			this.oo_o.Oo.().Text = "取消";
			this.oo_o.Oo.().UseVisualStyleBackColor = true;
			this.oO.0_o_o_0_.().Location = new Point(234, 425);
			this.oO.0_o_o_0_.().Margin = new Padding(3, 1, 3, 1);
			this.oO.0_o_o_0_.().Name = "Button1";
			this.oO.0_o_o_0_.().Size = new Size(75, 23);
			this.oO.0_o_o_0_.().TabIndex = 12;
			this.oO.0_o_o_0_.().Text = "统计";
			this.oO.0_o_o_0_.().UseVisualStyleBackColor = true;
			this.O_o__0oooO.OOO.().AutoSize = true;
			this.O_o__0oooO.OOO.().BorderStyle = BorderStyle.None;
			this.O_o__0oooO.OOO.().Location = new Point(231, 46);
			this.O_o__0oooO.OOO.().Margin = new Padding(3, 1, 3, 1);
			this.O_o__0oooO.OOO.().Name = "chkOnlyGroups";
			this.O_o__0oooO.OOO.().Size = new Size(96, 16);
			this.O_o__0oooO.OOO.().TabIndex = 9;
			this.O_o__0oooO.OOO.().Text = "仅保留分组行";
			this.O_o__0oooO.OOO.().UseVisualStyleBackColor = true;
			this.O_o__0oooO.OOO.().Value = false;
			this.O.OO00oO.().AutoSize = true;
			this.O.OO00oO.().BorderStyle = BorderStyle.None;
			this.O.OO00oO.().Location = new Point(231, 73);
			this.O.OO00oO.().Margin = new Padding(3, 1, 3, 1);
			this.O.OO00oO.().Name = "chkPreserveTolevel";
			this.O.OO00oO.().Size = new Size(60, 16);
			this.O.OO00oO.().TabIndex = 10;
			this.O.OO00oO.().Text = "保留前";
			this.O.OO00oO.().UseVisualStyleBackColor = true;
			this.O.OO00oO.().Value = false;
			this.OOoOO_O_.0.().DataType = typeof(int);
			this.OOoOO_O_.0.().Enabled = false;
			this.OOoOO_O_.0.().Location = new Point(295, 72);
			this.OOoOO_O_.0.().Margin = new Padding(3, 1, 3, 1);
			this.OOoOO_O_.0.().Name = "txtPreserveTolevel";
			this.OOoOO_O_.0.().Size = new Size(29, 19);
			this.OOoOO_O_.0.().TabIndex = 11;
			this.OOoOO_O_.0.().Tag = null;
			this.OOoOO_O_.0.().TextAlign = HorizontalAlignment.Center;
			this.OOoOO_O_.0.().Value = 0;
			this.OOo.o.().AutoSize = true;
			this.OOo.o.().Location = new Point(331, 73);
			this.OOo.o.().Name = "Label1";
			this.OOo.o.().Size = new Size(41, 12);
			this.OOo.o.().TabIndex = 41;
			this.OOo.o.().Text = "级的行";
			this.OOoOO_O_.0.().AllowDelete = true;
			this.OOoOO_O_.0.().AllowDragging = AllowDraggingEnum.None;
			this.OOoOO_O_.0.().AllowMergingFixed = AllowMergingEnum.None;
			this.OOoOO_O_.0.().AllowSorting = AllowSortingEnum.None;
			this.OOoOO_O_.0.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.OOoOO_O_.0.().ColumnInfo = componentResourceManager.GetString("TotalGrid.ColumnInfo");
			this.OOoOO_O_.0.().ExtendLastCol = true;
			this.OOoOO_O_.0.().HighLight = HighLightEnum.WithFocus;
			this.OOoOO_O_.0.().Location = new Point(23, 61);
			this.OOoOO_O_.0.().Margin = new Padding(3, 2, 3, 2);
			this.OOoOO_O_.0.().Name = "TotalGrid";
			this.OOoOO_O_.0.().Rows.Count = 1;
			this.OOoOO_O_.0.().Rows.DefaultSize = 19;
			this.OOoOO_O_.0.().SelectionMode = SelectionModeEnum.Row;
			this.OOoOO_O_.0.().ShowThemedHeaders = ShowThemedHeadersEnum.None;
			this.OOoOO_O_.0.().Size = new Size(594, 194);
			this.OOoOO_O_.0.().TabIndex = 3;
			this.O_O.Oo_oO.().Items.AddRange(new ToolStripItem[]
			{
				this.o_O.o__O_.(),
				this.OO_00_o.__O.(),
				this.o_.0OO.(),
				this.O_O.Oo_oO.()
			});
			this.O_O.Oo_oO.().Name = "ContextMenuStrip1";
			this.O_O.Oo_oO.().Size = new Size(101, 92);
			this.o_O.o__O_.().Name = "InsertMenuItem";
			this.o_O.o__O_.().Size = new Size(100, 22);
			this.o_O.o__O_.().Text = "插入";
			this.OO_00_o.__O.().Name = "DeleteMenuItem";
			this.OO_00_o.__O.().Size = new Size(100, 22);
			this.OO_00_o.__O.().Text = "删除";
			this.o_.0OO.().Name = "MoveUpMenuItem";
			this.o_.0OO.().Size = new Size(100, 22);
			this.o_.0OO.().Text = "上移";
			this.O_O.Oo_oO.().Name = "MoveDownMenuItem";
			this.O_O.Oo_oO.().Size = new Size(100, 22);
			this.O_O.Oo_oO.().Text = "下移";
			this.ooo___o_O_0_.o.().AutoSize = true;
			this.ooo___o_O_0_.o.().Location = new Point(143, 46);
			this.ooo___o_O_0_.o.().Margin = new Padding(2, 0, 2, 0);
			this.ooo___o_O_0_.o.().Name = "Label5";
			this.ooo___o_O_0_.o.().Size = new Size(17, 12);
			this.ooo___o_O_0_.o.().TabIndex = 45;
			this.ooo___o_O_0_.o.().Text = "级";
			this.o_.0OO.().DataType = typeof(int);
			this.o_.0OO.().Location = new Point(110, 45);
			this.o_.0OO.().Name = "txtExpandLevel";
			this.o_.0OO.().Size = new Size(29, 19);
			this.o_.0OO.().TabIndex = 6;
			this.o_.0OO.().Tag = null;
			this.o_.0OO.().Value = 0;
			this.oO0_00O_oo.0.().AutoSize = true;
			this.oO0_00O_oo.0.().BorderStyle = BorderStyle.None;
			this.oO0_00O_oo.0.().Checked = true;
			this.oO0_00O_oo.0.().CheckState = CheckState.Checked;
			this.oO0_00O_oo.0.().Location = new Point(26, 46);
			this.oO0_00O_oo.0.().Margin = new Padding(2, 1, 2, 1);
			this.oO0_00O_oo.0.().Name = "chkAutoExpand";
			this.oO0_00O_oo.0.().Size = new Size(84, 16);
			this.oO0_00O_oo.0.().TabIndex = 5;
			this.oO0_00O_oo.0.().Text = "默认展开到";
			this.oO0_00O_oo.0.().UseVisualStyleBackColor = true;
			this.oO0_00O_oo.0.().Value = true;
			this.o00oo_0oo.o.().AutoSize = true;
			this.o00oo_0oo.o.().BorderStyle = BorderStyle.None;
			this.o00oo_0oo.o.().Location = new Point(231, 19);
			this.o00oo_0oo.o.().Margin = new Padding(3, 1, 3, 1);
			this.o00oo_0oo.o.().Name = "chkIncludeParentCol";
			this.o00oo_0oo.o.().Size = new Size(84, 16);
			this.o00oo_0oo.o.().TabIndex = 8;
			this.o00oo_0oo.o.().Text = "包括父健列";
			this.o00oo_0oo.o.().UseVisualStyleBackColor = true;
			this.o00oo_0oo.o.().Value = false;
			this.OO0oo0_.0.().AutoSize = true;
			this.OO0oo0_.0.().BorderStyle = BorderStyle.None;
			this.OO0oo0_.0.().Location = new Point(26, 73);
			this.OO0oo0_.0.().Margin = new Padding(3, 1, 3, 1);
			this.OO0oo0_.0.().Name = "chkShowTreeInParentCol";
			this.OO0oo0_.0.().Size = new Size(132, 16);
			this.OO0oo0_.0.().TabIndex = 7;
			this.OO0oo0_.0.().Text = "在父健列显示折叠树";
			this.OO0oo0_.0.().UseVisualStyleBackColor = true;
			this.OO0oo0_.0.().Value = false;
			this.oo_o.Oo.().Controls.Add(this.o00oo_0oo.o.());
			this.oo_o.Oo.().Controls.Add(this.o.0_0__.());
			this.oo_o.Oo.().Location = new Point(23, 270);
			this.oo_o.Oo.().Name = "C1DockingTab1";
			this.oo_o.Oo.().Size = new Size(594, 134);
			this.oo_o.Oo.().TabIndex = 46;
			this.oo_o.Oo.().TabsSpacing = 5;
			this.o00oo_0oo.o.().Controls.Add(this.o.0_0__.());
			this.o00oo_0oo.o.().Controls.Add(this.O_o__0oooO.OOO.());
			this.o00oo_0oo.o.().Controls.Add(this.OO0oo0_.0.());
			this.o00oo_0oo.o.().Controls.Add(this.O.OO00oO.());
			this.o00oo_0oo.o.().Controls.Add(this.o00oo_0oo.o.());
			this.o00oo_0oo.o.().Controls.Add(this.OOoOO_O_.0.());
			this.o00oo_0oo.o.().Controls.Add(this.ooo___o_O_0_.o.());
			this.o00oo_0oo.o.().Controls.Add(this.OOo.o.());
			this.o00oo_0oo.o.().Controls.Add(this.o_.0OO.());
			this.o00oo_0oo.o.().Controls.Add(this.oO0_00O_oo.0.());
			this.o00oo_0oo.o.().Location = new Point(1, 25);
			this.o00oo_0oo.o.().Name = "C1DockingTabPage1";
			this.o00oo_0oo.o.().Size = new Size(592, 108);
			this.o00oo_0oo.o.().TabIndex = 0;
			this.o00oo_0oo.o.().Text = "选项";
			this.o.0_0__.().Controls.Add(this.ooo___o_O_0_.o.());
			this.o.0_0__.().Location = new Point(1, 25);
			this.o.0_0__.().Name = "C1DockingTabPage2";
			this.o.0_0__.().Size = new Size(592, 108);
			this.o.0_0__.().TabIndex = 1;
			this.o.0_0__.().Text = "附加列";
			this.ooo___o_O_0_.o.().AllowDelete = true;
			this.ooo___o_O_0_.o.().AllowDragging = AllowDraggingEnum.None;
			this.ooo___o_O_0_.o.().AllowSorting = AllowSortingEnum.None;
			this.ooo___o_O_0_.o.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.ooo___o_O_0_.o.().ColumnInfo = componentResourceManager.GetString("grdAdditions.ColumnInfo");
			this.ooo___o_O_0_.o.().Dock = DockStyle.Fill;
			this.ooo___o_O_0_.o.().ExtendLastCol = true;
			this.ooo___o_O_0_.o.().HighLight = HighLightEnum.WithFocus;
			this.ooo___o_O_0_.o.().Location = new Point(0, 0);
			this.ooo___o_O_0_.o.().Name = "grdAdditions";
			this.ooo___o_O_0_.o.().Rows.Count = 1;
			this.ooo___o_O_0_.o.().Rows.DefaultSize = 21;
			this.ooo___o_O_0_.o.().SelectionMode = SelectionModeEnum.Row;
			this.ooo___o_O_0_.o.().ShowThemedHeaders = ShowThemedHeadersEnum.None;
			this.ooo___o_O_0_.o.().Size = new Size(592, 108);
			this.ooo___o_O_0_.o.().TabIndex = 17;
			this.ooo___o_O_0_.o.().VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(638, 460);
			base.Controls.Add(this.oo_o.Oo.());
			base.Controls.Add(this.OOoOO_O_.0.());
			base.Controls.Add(this.oo_o.Oo.());
			base.Controls.Add(this.oO.0_o_o_0_.());
			base.Controls.Add(this.o00oo_0oo.o.());
			base.Controls.Add(this.o_O.o__O_.());
			base.Controls.Add(this.o.0_0__.());
			base.Controls.Add(this.OO_00_o.__O.());
			base.Controls.Add(this.oo_.oo00o0.());
			base.Controls.Add(this.O_O.Oo_oO.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(3, 1, 3, 1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.o.o0..0.";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "内联分组统计";
			((ISupportInitialize)this.oo_.oo00o0.()).EndInit();
			((ISupportInitialize)this.o.0_0__.()).EndInit();
			((ISupportInitialize)this.o00oo_0oo.o.()).EndInit();
			((ISupportInitialize)this.o.0_0__.()).EndInit();
			((ISupportInitialize)this.oo_o.Oo.()).EndInit();
			((ISupportInitialize)this.oO.0_o_o_0_.()).EndInit();
			((ISupportInitialize)this.O_o__0oooO.OOO.()).EndInit();
			((ISupportInitialize)this.O.OO00oO.()).EndInit();
			((ISupportInitialize)this.OOoOO_O_.0.()).EndInit();
			((ISupportInitialize)this.OOoOO_O_.0.()).EndInit();
			this.O_O.Oo_oO.().ResumeLayout(false);
			((ISupportInitialize)this.o_.0OO.()).EndInit();
			((ISupportInitialize)this.oO0_00O_oo.0.()).EndInit();
			((ISupportInitialize)this.o00oo_0oo.o.()).EndInit();
			((ISupportInitialize)this.OO0oo0_.0.()).EndInit();
			((ISupportInitialize)this.oo_o.Oo.()).EndInit();
			this.oo_o.Oo.().ResumeLayout(false);
			this.o00oo_0oo.o.().ResumeLayout(false);
			this.o00oo_0oo.o.().PerformLayout();
			this.o.0_0__.().ResumeLayout(false);
			((ISupportInitialize)this.ooo___o_O_0_.o.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00055E19 File Offset: 0x00054019
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O0_00Oo0_._.;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00055E21 File Offset: 0x00054021
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O0_00Oo0_._. = A_0;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00055E2A File Offset: 0x0005402A
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0_00Oo0_._.;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00055E32 File Offset: 0x00054032
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0_00Oo0_._. = A_0;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00055E3B File Offset: 0x0005403B
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o_o_ooo.o.;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00055E43 File Offset: 0x00054043
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.o_o_ooo.o. = A_0;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00055E4C File Offset: 0x0005404C
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oO__0O.O.;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00055E54 File Offset: 0x00054054
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oO__0O.O. = A_0;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00055E5D File Offset: 0x0005405D
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oO_0ooO.O.;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00055E65 File Offset: 0x00054065
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oO_0ooO.O. = A_0;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00055E6E File Offset: 0x0005406E
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o0.O__o_.;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00055E76 File Offset: 0x00054076
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.o0.O__o_. = A_0;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00055E7F File Offset: 0x0005407F
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o_o_ooo.o.;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00055E88 File Offset: 0x00054088
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.oo_o.Oo.);
			C1CheckBox c1CheckBox = this.o_o_ooo.o.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged -= value;
			}
			this.o_o_ooo.o. = A_0;
			c1CheckBox = this.o_o_ooo.o.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged += value;
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00055ECB File Offset: 0x000540CB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_.oo0ooo_0.;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00055ED3 File Offset: 0x000540D3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o_.oo0ooo_0. = A_0;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00055EDC File Offset: 0x000540DC
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_oO0ooO.o_oO.;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00055EE4 File Offset: 0x000540E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO.0_Oo.);
			C1Button o_oO0ooO.o_oO. = this.O_oO0ooO.o_oO.;
			if (o_oO0ooO.o_oO. != null)
			{
				o_oO0ooO.o_oO..Click -= value;
			}
			this.O_oO0ooO.o_oO. = A_0;
			o_oO0ooO.o_oO. = this.O_oO0ooO.o_oO.;
			if (o_oO0ooO.o_oO. != null)
			{
				o_oO0ooO.o_oO..Click += value;
			}
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00055F27 File Offset: 0x00054127
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o0.O__o_.;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00055F2F File Offset: 0x0005412F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o0.O__o_. = A_0;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00055F38 File Offset: 0x00054138
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O0O0O.0O.;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00055F40 File Offset: 0x00054140
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.oO.0_o_o_0_.);
			C1CheckBox o0O0O.0O. = this.O0O0O.0O.;
			if (o0O0O.0O. != null)
			{
				o0O0O.0O..CheckedChanged -= value;
			}
			this.O0O0O.0O. = A_0;
			o0O0O.0O. = this.O0O0O.0O.;
			if (o0O0O.0O. != null)
			{
				o0O0O.0O..CheckedChanged += value;
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00055F83 File Offset: 0x00054183
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.OO0._OO0_0_o.;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00055F8B File Offset: 0x0005418B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.OO0._OO0_0_o. = A_0;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00055F94 File Offset: 0x00054194
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_OOOo._.;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00055F9C File Offset: 0x0005419C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_OOOo._. = A_0;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00055FA5 File Offset: 0x000541A5
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O0_00Oo0_._.;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00055FB0 File Offset: 0x000541B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.o0__O0._0O0_O0.);
			RowColEventHandler value2 = new RowColEventHandler(this.O.0OOo_o00.);
			ValidateEditEventHandler value3 = new ValidateEditEventHandler(this.o_.oo0ooo_0.);
			C1FlexGrid o0_00Oo0_._. = this.O0_00Oo0_._.;
			if (o0_00Oo0_._. != null)
			{
				o0_00Oo0_._..BeforeEdit -= value;
				o0_00Oo0_._..AfterEdit -= value2;
				o0_00Oo0_._..ValidateEdit -= value3;
			}
			this.O0_00Oo0_._. = A_0;
			o0_00Oo0_._. = this.O0_00Oo0_._.;
			if (o0_00Oo0_._. != null)
			{
				o0_00Oo0_._..BeforeEdit += value;
				o0_00Oo0_._..AfterEdit += value2;
				o0_00Oo0_._..ValidateEdit += value3;
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00056029 File Offset: 0x00054229
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.o_o_ooo.o.;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00056031 File Offset: 0x00054231
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.o_o_ooo.o. = A_0;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0005603C File Offset: 0x0005423C
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o_o_ooo.o.;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00056050 File Offset: 0x00054250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.oo_.oo00o0.);
				ToolStripMenuItem toolStripMenuItem = this.o_o_ooo.o.;
				int num = 4;
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
						return;
					case 1:
						toolStripMenuItem.Click -= value;
						num = 5;
						continue;
					case 2:
						toolStripMenuItem.Click += value;
						num = 3;
						continue;
					case 3:
						return;
					case 4:
						if (true)
						{
						}
						if (toolStripMenuItem != null)
						{
							num = 1;
							continue;
						}
						goto IL_62;
					case 5:
						goto IL_62;
					}
					break;
					IL_62:
					this.o_o_ooo.o. = A_0;
					toolStripMenuItem = this.o_o_ooo.o.;
					num = 0;
				}
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x000560FC File Offset: 0x000542FC
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o0.O__o_.;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00056110 File Offset: 0x00054310
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o0._0ooO_0o.);
				ToolStripMenuItem toolStripMenuItem = this.o0.O__o_.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						toolStripMenuItem.Click -= value;
						num = 2;
						continue;
					case 1:
						toolStripMenuItem.Click += value;
						num = 3;
						continue;
					case 2:
						goto IL_62;
					case 3:
						return;
					case 4:
						if (toolStripMenuItem != null)
						{
							num = 1;
							continue;
						}
						return;
					case 5:
						if (toolStripMenuItem != null)
						{
							if (true)
							{
							}
							num = 0;
							continue;
						}
						goto IL_62;
					}
					break;
					IL_62:
					this.o0.O__o_. = A_0;
					toolStripMenuItem = this.o0.O__o_.;
					num = 4;
				}
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x000561BC File Offset: 0x000543BC
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.oO_0ooO.O.;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x000561D0 File Offset: 0x000543D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O0._O_O.);
				ToolStripMenuItem toolStripMenuItem = this.oO_0ooO.O.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_5A;
					case 1:
						if (toolStripMenuItem != null)
						{
							num = 4;
							continue;
						}
						return;
					case 2:
						if (true)
						{
						}
						toolStripMenuItem.Click -= value;
						num = 0;
						continue;
					case 3:
						return;
					case 4:
						toolStripMenuItem.Click += value;
						num = 3;
						continue;
					case 5:
						if (toolStripMenuItem != null)
						{
							num = 2;
							continue;
						}
						goto IL_5A;
					}
					break;
					IL_5A:
					this.oO_0ooO.O. = A_0;
					toolStripMenuItem = this.oO_0ooO.O.;
					num = 1;
				}
			}
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00056278 File Offset: 0x00054478
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O_OOOo._.;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0005628C File Offset: 0x0005448C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.oO_._oO.);
				ToolStripMenuItem o_OOOo._. = this.O_OOOo._.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						o_OOOo._..Click += value;
						num = 0;
						continue;
					case 2:
						goto IL_5A;
					case 3:
						if (o_OOOo._. != null)
						{
							num = 1;
							continue;
						}
						return;
					case 4:
						if (true)
						{
						}
						o_OOOo._..Click -= value;
						num = 2;
						continue;
					case 5:
						if (o_OOOo._. != null)
						{
							num = 4;
							continue;
						}
						goto IL_5A;
					}
					break;
					IL_5A:
					this.O_OOOo._. = A_0;
					o_OOOo._. = this.O_OOOo._.;
					num = 3;
				}
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00056332 File Offset: 0x00054532
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOo._o0_____o.;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0005633A File Offset: 0x0005453A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOo._o0_____o. = A_0;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00056343 File Offset: 0x00054543
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oO_0ooO.O.;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0005634B File Offset: 0x0005454B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.oO_0ooO.O. = A_0;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00056354 File Offset: 0x00054554
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o0__O0._0O0_O0.;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0005635C File Offset: 0x0005455C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.oO.0_o_o_0_.);
			C1CheckBox c1CheckBox = this.o0__O0._0O0_O0.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged -= value;
			}
			this.o0__O0._0O0_O0. = A_0;
			c1CheckBox = this.o0__O0._0O0_O0.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged += value;
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0005639F File Offset: 0x0005459F
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o0_o0_0O.O_O_.;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x000563A7 File Offset: 0x000545A7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o0_o0_0O.O_O_. = A_0;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000563B0 File Offset: 0x000545B0
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O__.0OOOO__.;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000563B8 File Offset: 0x000545B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O__.0OOOO__. = A_0;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x000563C1 File Offset: 0x000545C1
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.o_.oo0ooo_0.;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x000563C9 File Offset: 0x000545C9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			this.o_.oo0ooo_0. = A_0;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x000563D2 File Offset: 0x000545D2
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.o_.oo0ooo_0.;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x000563DA File Offset: 0x000545DA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.o_.oo0ooo_0. = A_0;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x000563E3 File Offset: 0x000545E3
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.O_oO0ooO.o_oO.;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000563EB File Offset: 0x000545EB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.O_oO0ooO.o_oO. = A_0;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000563F4 File Offset: 0x000545F4
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.o0.O__o_.;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x000563FC File Offset: 0x000545FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.o_.0OO.);
			RowColEventHandler value2 = new RowColEventHandler(this.OOoOO_O_.0.);
			C1FlexGrid c1FlexGrid = this.o0.O__o_.;
			if (c1FlexGrid != null)
			{
				c1FlexGrid.AfterEdit -= value;
				c1FlexGrid.BeforeEdit -= value2;
			}
			this.o0.O__o_. = A_0;
			c1FlexGrid = this.o0.O__o_.;
			if (c1FlexGrid != null)
			{
				c1FlexGrid.AfterEdit += value;
				c1FlexGrid.BeforeEdit += value2;
			}
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0005645C File Offset: 0x0005465C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0_O.00____. = OO_00oOO.MainTable;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
			{
				this.oo_o.Oo.()
			});
			if (Operators.CompareString(this.o0_O.00____..O_O0._..TableName, "", true) > 0)
			{
				this.oo_.oo00o0.().Value = this.o0_O.00____..O_O0._..TableName;
			}
			else
			{
				this.oo_.oo00o0.().Value = Oo00.oo0o.O0O_0__.("统计表");
			}
			this.o.0_0__.().Checked = this.o0_O.00____..O_O0._..GridTree;
			this.O_o__0oooO.OOO.().Checked = this.o0_O.00____..O_O0._..OnlyGroupRows;
			this.o00oo_0oo.o.().Checked = this.o0_O.00____..O_O0._..IncludeParentCol;
			if (this.o.0_0__.().Checked)
			{
				this.OO0oo0_.0.().Checked = this.o0_O.00____..O_O0._..ShowTreeInParentCol;
			}
			if (this.o0_O.00____..O_O0._..ExpandTo > -1 && this.o.0_0__.().Checked)
			{
				this.o_.0OO.().Value = this.o0_O.00____..O_O0._..ExpandTo;
				this.oO0_00O_oo.0.().Checked = true;
			}
			if (this.o0_O.00____..O_O0._..PreserveTo > -1)
			{
				this.OOoOO_O_.0.().Value = this.o0_O.00____..O_O0._..PreserveTo;
				this.O.OO00oO.().Checked = true;
			}
			if (this.o0_O.00____..O_O0._..Totals.Count > 0)
			{
				try
				{
					foreach (o0o_ o0o_ in this.o0_O.00____..O_O0._..Totals)
					{
						if (o0o_.o0oO._o_.() == AggregateType.Count)
						{
							this.OOoOO_O_.0.().AddItem(new object[]
							{
								"记录数\t",
								(int)o0o_.o0oO._o_.(),
								(int)o0o_.O0OO_0.O.(),
								o0o_.Oo0oO0oOO_.0_o.()
							});
						}
						else if (this.o0_O.00____..DataTable.BaseTable.Columns.Contains(o0o_.o0oO._o_.()))
						{
							this.OOoOO_O_.0.().AddItem(new object[]
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
			this.ooo___o_O_0_.o.().Cols[0].ComboList = text.Trim(new char[]
			{
				'|'
			});
			try
			{
				foreach (o00_0__O o00_0__O in this.o0_O.00____..O_O0._..Additions)
				{
					this.ooo___o_O_0_.o.().AddItem(new object[]
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
			this.ooo___o_O_0_.o.().AllowAddNew = true;
			string text2 = "";
			try
			{
				foreach (DataCol dataCol in this.o0_O.00____..DataTable.DataCols)
				{
					if (dataCol.IsString)
					{
						this.o00oo_0oo.o.().Items.Add(dataCol.Name);
						this.o.0_0__.().Items.Add(dataCol.Name);
						if (Operators.CompareString(this.o0_O.00____..oo.0___0O00., dataCol.Name, true) == 0)
						{
							this.o00oo_0oo.o.().SelectedIndex = this.o00oo_0oo.o.().Items.Count - 1;
						}
						if (Operators.CompareString(this.o0_O.00____..oOo0.____., dataCol.Name, true) == 0)
						{
							this.o.0_0__.().SelectedIndex = this.o.0_0__.().Items.Count - 1;
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
			this.OOoOO_O_.0.().Cols[0].ComboList = text2;
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary.Add(0, "累计值");
			dictionary.Add(1, "最大值");
			dictionary.Add(2, "最小值");
			dictionary.Add(3, "平均值");
			dictionary.Add(4, "记录数");
			this.OOoOO_O_.0.().Cols[1].DataMap = dictionary;
			dictionary = new Dictionary<int, string>();
			dictionary.Add(0, "本级");
			dictionary.Add(1, "下级");
			dictionary.Add(2, "全部");
			this.OOoOO_O_.0.().Cols[2].DataMap = dictionary;
			this.OOoOO_O_.0.().Col = 0;
			this.OOoOO_O_.0.().ContextMenuStrip = this.O_O.Oo_oO.();
			this.OOoOO_O_.0.().AllowAddNew = true;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00056A24 File Offset: 0x00054C24
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00056A36 File Offset: 0x00054C36
		private string <<EMPTY_NAME>>(string A_0)
		{
			return A_0;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00056A3C File Offset: 0x00054C3C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			InlineGroupTableBuilder inlineGroupTableBuilder = new InlineGroupTableBuilder(this.oo_.oo00o0.().Text.Trim(), OO_00oOO.MainTable.DataTable);
			inlineGroupTableBuilder.Filter = OO_00oOO.MainTable.Filter;
			if (this.o00oo_0oo.o.().SelectedItem != null && this.o.0_0__.().SelectedItem != null)
			{
				inlineGroupTableBuilder.ParentCol = this.o00oo_0oo.o.().SelectedItem.ToString();
				inlineGroupTableBuilder.ChildCol = this.o.0_0__.().SelectedItem.ToString();
				inlineGroupTableBuilder.Filter = this.o0_O.00____..Filter;
				inlineGroupTableBuilder.GridTree = this.o.0_0__.().Checked;
				inlineGroupTableBuilder.OnlyGroupRows = this.O_o__0oooO.OOO.().Checked;
				inlineGroupTableBuilder.IncludeParentCol = this.o00oo_0oo.o.().Checked;
				if (inlineGroupTableBuilder.GridTree)
				{
					inlineGroupTableBuilder.ShowTreeInParentCol = this.OO0oo0_.0.().Checked;
					if (this.oO0_00O_oo.0.().Checked)
					{
						inlineGroupTableBuilder.ExpandTo = Conversions.ToInteger(this.o_.0OO.().Value);
					}
				}
				if (this.O.OO00oO.().Checked)
				{
					inlineGroupTableBuilder.PreserveTo = Conversions.ToInteger(this.OOoOO_O_.0.().Value);
				}
				int num = this.OOoOO_O_.0.().Rows.Count - 2;
				for (int i = 1; i <= num; i++)
				{
					if (this.OOoOO_O_.0.().GetData(i, 0) == null || this.OOoOO_O_.0.().GetData(i, 1) == null || this.OOoOO_O_.0.().GetData(i, 2) == null || this.OOoOO_O_.0.().GetData(i, 3) == null)
					{
						return;
					}
					string column = this.OOoOO_O_.0.(this.OOoOO_O_.0.().GetData(i, 0).ToString());
					AggregateType aggregateType = (AggregateType)Conversions.ToInteger(this.OOoOO_O_.0.().GetData(i, 1));
					AggregateRange aggregateRange = (AggregateRange)Conversions.ToInteger(this.OOoOO_O_.0.().GetData(i, 2));
					string newName = this.OOoOO_O_.0.().GetData(i, 3).ToString();
					if (aggregateType == AggregateType.Count)
					{
						inlineGroupTableBuilder.AddTotal(true, newName, aggregateRange);
					}
					else
					{
						inlineGroupTableBuilder.AddTotal(column, newName, aggregateRange, aggregateType);
					}
				}
				string[] array = new string[4];
				int num2 = this.ooo___o_O_0_.o.().Rows.Count - 1;
				for (int j = 1; j <= num2; j++)
				{
					array[0] = this.ooo___o_O_0_.o.().GetDataDisplay(j, 0);
					array[1] = this.ooo___o_O_0_.o.().GetDataDisplay(j, 1);
					array[2] = this.ooo___o_O_0_.o.().GetDataDisplay(j, 2);
					array[3] = this.ooo___o_O_0_.o.().GetDataDisplay(j, 3);
					if (Operators.CompareString(array[0], "", true) > 0 && Operators.CompareString(array[1], "", true) > 0 && Operators.CompareString(array[2], "", true) > 0 && Operators.CompareString(array[3], "", true) > 0 && OO_00oOO.DataTables.Contains(array[0]) && OO_00oOO.DataTables[array[0]].BaseTable.Columns.Contains(array[1]) && OO_00oOO.DataTables[array[0]].BaseTable.Columns.Contains(array[2]))
					{
						inlineGroupTableBuilder.Additions.Add(OO_00oOO.DataTables[array[0]], array[1], array[2], array[3]);
					}
				}
				if (inlineGroupTableBuilder.Totals.Count > 0 && inlineGroupTableBuilder.Build() != null)
				{
					this.o0_O.00____..O_O0._. = new LayersGroupTableBuilder();
					this.o0_O.00____..O_O0._. = inlineGroupTableBuilder;
					this.o0_O.00____..oo.0___0O00. = inlineGroupTableBuilder.ParentCol;
					this.o0_O.00____..oOo0.____. = inlineGroupTableBuilder.ChildCol;
					this.o0_O.00____..NeedSaveSetting = true;
					this.o0_O.00____..oo0OO0Ooo._.(true);
					base.DialogResult = DialogResult.OK;
					OO_00oOO.MainTable = OO_00oOO.Tables[inlineGroupTableBuilder.TableName];
				}
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00056E08 File Offset: 0x00055008
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Row > 0 && A_1.Col > 0)
			{
				if (this.OOoOO_O_.0.().GetData(A_1.Row, 0) == null)
				{
					A_1.Cancel = true;
					return;
				}
				string left = this.OOoOO_O_.0.().GetData(A_1.Row, 0).ToString();
				if (A_1.Col == 1 && Operators.CompareString(left, "记录数\t", true) == 0)
				{
					A_1.Cancel = true;
				}
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00056E7C File Offset: 0x0005507C
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (this.OOoOO_O_.0.().Col == 0 && this.OOoOO_O_.0.().GetData(A_1.Row, 0) != null)
			{
				string text = this.OOoOO_O_.0.().GetData(A_1.Row, 0).ToString();
				if (Operators.CompareString(text, "记录数\t", true) == 0)
				{
					this.OOoOO_O_.0.()[A_1.Row, 1] = 4;
				}
				else
				{
					this.OOoOO_O_.0.()[A_1.Row, 1] = 0;
				}
				text = text.Trim();
				string text2 = text;
				int num = 1;
				for (;;)
				{
					bool flag = false;
					int num2 = this.OOoOO_O_.0.().Rows.Count - 2;
					for (int i = 1; i <= num2; i++)
					{
						if (this.OOoOO_O_.0.().GetData(i, 3) != null && Operators.CompareString(this.OOoOO_O_.0.().GetData(i, 3).ToString(), text2, true) == 0)
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
				this.OOoOO_O_.0.()[A_1.Row, 3] = text2;
				IL_113:
				this.OOoOO_O_.0.()[A_1.Row, 2] = 2;
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00056FB4 File Offset: 0x000551B4
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

		// Token: 0x06000A78 RID: 2680 RVA: 0x00057020 File Offset: 0x00055220
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

		// Token: 0x06000A79 RID: 2681 RVA: 0x00057078 File Offset: 0x00055278
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

		// Token: 0x06000A7A RID: 2682 RVA: 0x000570D4 File Offset: 0x000552D4
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

		// Token: 0x06000A7B RID: 2683 RVA: 0x00057125 File Offset: 0x00055325
		private void <<EMPTY_NAME>>(object A_0, ValidateEditEventArgs A_1)
		{
			if (A_1.Col == 3 && Operators.CompareString(this.OOoOO_O_.0.().Editor.Text, "", true) == 0)
			{
				A_1.Cancel = true;
			}
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00057154 File Offset: 0x00055354
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_.0OO.().Enabled = this.oO0_00O_oo.0.().Checked;
			this.OOoOO_O_.0.().Enabled = this.O.OO00oO.().Checked;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00057184 File Offset: 0x00055384
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oO0_00O_oo.0.().Enabled = this.o.0_0__.().Checked;
			this.OO0oo0_.0.().Enabled = this.o.0_0__.().Checked;
			if (!this.o.0_0__.().Checked)
			{
				this.oO0_00O_oo.0.().Checked = false;
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000571D8 File Offset: 0x000553D8
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Col == 0)
			{
				int num = this.ooo___o_O_0_.o.().Cols.Count - 1;
				for (int i = 1; i <= num; i++)
				{
					this.ooo___o_O_0_.o.().SetData(A_1.Row, i, null);
				}
				return;
			}
			if (A_1.Col == 2)
			{
				string dataDisplay = this.ooo___o_O_0_.o.().GetDataDisplay(A_1.Row, 2);
				this.ooo___o_O_0_.o.().SetData(A_1.Row, 3, dataDisplay);
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00057254 File Offset: 0x00055454
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Row > 0 && (A_1.Col == 1 || A_1.Col == 2))
			{
				string dataDisplay = this.ooo___o_O_0_.o.().GetDataDisplay(A_1.Row, 0);
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
				this.ooo___o_O_0_.o.().Cols[1].ComboList = text.Trim(new char[]
				{
					'|'
				});
				this.ooo___o_O_0_.o.().Cols[2].ComboList = text.Trim(new char[]
				{
					'|'
				});
			}
		}

		// Token: 0x040003BB RID: 955
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040003BC RID: 956
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040003BD RID: 957
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040003BE RID: 958
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040003BF RID: 959
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040003C0 RID: 960
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040003C1 RID: 961
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040003C2 RID: 962
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040003C3 RID: 963
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003C4 RID: 964
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003C5 RID: 965
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040003C6 RID: 966
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040003C7 RID: 967
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040003C8 RID: 968
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040003C9 RID: 969
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x040003CA RID: 970
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x040003CB RID: 971
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040003CC RID: 972
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040003CD RID: 973
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040003CE RID: 974
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040003CF RID: 975
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040003D0 RID: 976
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040003D1 RID: 977
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040003D2 RID: 978
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040003D3 RID: 979
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040003D4 RID: 980
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x040003D5 RID: 981
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040003D6 RID: 982
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x040003D7 RID: 983
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x040003D8 RID: 984
		private Table <<EMPTY_NAME>>;
	}
}
