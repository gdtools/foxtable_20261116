using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using C1.Win.C1Input;
using C1.Win.Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000E3 RID: 227
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	internal partial class O\u30020\u3000\u3002 : Form
	{
		// Token: 0x06000C71 RID: 3185 RVA: 0x000676B4 File Offset: 0x000658B4
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_.0O_O_. != null)
				{
					this.O_.0O_O_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000676F4 File Offset: 0x000658F4
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o_O_.__o.(new C1Button());
			this.o.o0OO.(new C1Button());
			this.O__0_0_o_.ooO.(new Label());
			this.OO00O0_.o0OooO.(new Label());
			this.o_._o0ooOO_o.(new C1ComboBox());
			this.O.000_O.(new C1ComboBox());
			this.Oo0o0.O0.(new RadioButton());
			this.O0._0oo0O__.(new RadioButton());
			this.Ooo0_Oo.0_.(new Label());
			this.Ooo0_Oo.0_.(new Panel());
			this.OOOo.O0o_.(new Panel());
			this.Oo0_OO_O.o.(new C1TextBox());
			this.o_OoooO.O0_0O_.(new RadioButton());
			this.Oo0_OO_O.o.(new RadioButton());
			this.OOo.O___.(new C1TextBox());
			this.o__00.oO_.(new Label());
			this.OoO_o0OOO_.Oo.(new C1ComboBox());
			this.OOOo.O0o_.(new Label());
			this.O0._0oo0O__.(new C1TextBox());
			this.O__OOo_.OoOO00.(new Label());
			this.o___O0O___.O.(new C1ComboBox());
			this.O__.O000_0_0_O.(new Label());
			this.OOo.O___.(new RadioButton());
			this.o___O0O___.O.(new C1MultiSelect());
			this.oo0O_oO.o0oOOo.(new Label());
			this.O____o.0O__o.(new C1ComboBox());
			this.oo___O0o0.00o0.(new Label());
			this.o_O_.__o.(new C1CheckBox());
			this.O__o_.o0___0OO.(new Label());
			this.OoO_o0OOO_.Oo.(new C1MultiSelect());
			this.OoO_o0OOO_.Oo.(new C1CheckBox());
			((ISupportInitialize)this.oO.O__0.()).BeginInit();
			((ISupportInitialize)this.o_0O0.O0.()).BeginInit();
			((ISupportInitialize)this.o_0O0.O0.()).BeginInit();
			((ISupportInitialize)this.o_o00oO_O.0.()).BeginInit();
			this.o_oO_0o.00_O_0.().SuspendLayout();
			this.OO_0o0O.O_O00.().SuspendLayout();
			((ISupportInitialize)this.oO.00_.()).BeginInit();
			((ISupportInitialize)this.o.o0OO.()).BeginInit();
			((ISupportInitialize)this.o_o_000o_.Oo.()).BeginInit();
			((ISupportInitialize)this.o_O_.__o.()).BeginInit();
			((ISupportInitialize)this.O_00OOO.o0O.()).BeginInit();
			((ISupportInitialize)this.O_.000__O_0o.()).BeginInit();
			((ISupportInitialize)this.oO.O__0.()).BeginInit();
			((ISupportInitialize)this.o_0O0.O0.()).BeginInit();
			base.SuspendLayout();
			this.oO.O__0.().DialogResult = DialogResult.Cancel;
			this.oO.O__0.().ImageAlign = ContentAlignment.MiddleLeft;
			this.oO.O__0.().Location = new Point(252, 389);
			this.oO.O__0.().Margin = new Padding(4, 4, 4, 4);
			this.oO.O__0.().Name = "btnCancel";
			this.oO.O__0.().Size = new Size(100, 29);
			this.oO.O__0.().TabIndex = 9;
			this.oO.O__0.().Text = "取消";
			this.oO.O__0.().UseVisualStyleBackColor = true;
			this.o_0O0.O0.().ImageAlign = ContentAlignment.MiddleLeft;
			this.o_0O0.O0.().Location = new Point(129, 389);
			this.o_0O0.O0.().Margin = new Padding(4, 4, 4, 4);
			this.o_0O0.O0.().Name = "btnOK";
			this.o_0O0.O0.().Size = new Size(100, 29);
			this.o_0O0.O0.().TabIndex = 8;
			this.o_0O0.O0.().Text = "确定";
			this.o_0O0.O0.().UseVisualStyleBackColor = true;
			this.O._0oo.().AutoSize = true;
			this.O._0oo.().Location = new Point(33, 48);
			this.O._0oo.().Name = "Label2";
			this.O._0oo.().Size = new Size(45, 15);
			this.O._0oo.().TabIndex = 19;
			this.O._0oo.().Text = "子列:";
			this.OO_.oOoO0.().AutoSize = true;
			this.OO_.oOoO0.().Location = new Point(33, 5);
			this.OO_.oOoO0.().Name = "Label1";
			this.OO_.oOoO0.().Size = new Size(45, 15);
			this.OO_.oOoO0.().TabIndex = 17;
			this.OO_.oOoO0.().Text = "父列:";
			this.o_0O0.O0.().AllowSpinLoop = false;
			this.o_0O0.O0.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.o_0O0.O0.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.o_0O0.O0.().Cursor = Cursors.Arrow;
			this.o_0O0.O0.().DropDownStyle = DropDownStyle.DropDownList;
			this.o_0O0.O0.().GapHeight = 0;
			this.o_0O0.O0.().ImagePadding = new Padding(0);
			this.o_0O0.O0.().ItemsDisplayMember = "";
			this.o_0O0.O0.().ItemsValueMember = "";
			this.o_0O0.O0.().Location = new Point(108, 44);
			this.o_0O0.O0.().Margin = new Padding(4, 4, 4, 4);
			this.o_0O0.O0.().Name = "cmbChildCol";
			this.o_0O0.O0.().Size = new Size(321, 23);
			this.o_0O0.O0.().TabIndex = 1;
			this.o_0O0.O0.().Tag = null;
			this.o_o00oO_O.0.().AllowSpinLoop = false;
			this.o_o00oO_O.0.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.o_o00oO_O.0.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.o_o00oO_O.0.().Cursor = Cursors.Arrow;
			this.o_o00oO_O.0.().DropDownStyle = DropDownStyle.DropDownList;
			this.o_o00oO_O.0.().GapHeight = 0;
			this.o_o00oO_O.0.().ImagePadding = new Padding(0);
			this.o_o00oO_O.0.().ItemsDisplayMember = "";
			this.o_o00oO_O.0.().ItemsValueMember = "";
			this.o_o00oO_O.0.().Location = new Point(108, 1);
			this.o_o00oO_O.0.().Margin = new Padding(4, 4, 4, 4);
			this.o_o00oO_O.0.().Name = "cmbParentCol";
			this.o_o00oO_O.0.().Size = new Size(321, 23);
			this.o_o00oO_O.0.().TabIndex = 0;
			this.o_o00oO_O.0.().Tag = null;
			this.OO_0o0O.O_O00.().AutoSize = true;
			this.OO_0o0O.O_O00.().Checked = true;
			this.OO_0o0O.O_O00.().Location = new Point(151, 30);
			this.OO_0o0O.O_O00.().Margin = new Padding(3, 1, 3, 1);
			this.OO_0o0O.O_O00.().Name = "rdoInline";
			this.OO_0o0O.O_O00.().Size = new Size(73, 19);
			this.OO_0o0O.O_O00.().TabIndex = 0;
			this.OO_0o0O.O_O00.().TabStop = true;
			this.OO_0o0O.O_O00.().Text = "内联型";
			this.OO_0o0O.O_O00.().UseVisualStyleBackColor = true;
			this.o_oO_0o.00_O_0.().AutoSize = true;
			this.o_oO_0o.00_O_0.().Location = new Point(251, 30);
			this.o_oO_0o.00_O_0.().Margin = new Padding(3, 1, 3, 1);
			this.o_oO_0o.00_O_0.().Name = "rdoLayers";
			this.o_oO_0o.00_O_0.().Size = new Size(73, 19);
			this.o_oO_0o.00_O_0.().TabIndex = 1;
			this.o_oO_0o.00_O_0.().Text = "层级型";
			this.o_oO_0o.00_O_0.().UseVisualStyleBackColor = true;
			this.O.o_0o_.().AutoSize = true;
			this.O.o_0o_.().Location = new Point(33, 31);
			this.O.o_0o_.().Name = "Label3";
			this.O.o_0o_.().Size = new Size(90, 15);
			this.O.o_0o_.().TabIndex = 24;
			this.O.o_0o_.().Text = "折叠表类型:";
			this.o_oO_0o.00_O_0.().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.o_oO_0o.00_O_0.().Controls.Add(this.OO_.oOoO0.());
			this.o_oO_0o.00_O_0.().Controls.Add(this.o_o00oO_O.0.());
			this.o_oO_0o.00_O_0.().Controls.Add(this.o_0O0.O0.());
			this.o_oO_0o.00_O_0.().Controls.Add(this.O._0oo.());
			this.o_oO_0o.00_O_0.().Location = new Point(0, 104);
			this.o_oO_0o.00_O_0.().Margin = new Padding(3, 1, 3, 1);
			this.o_oO_0o.00_O_0.().Name = "Panel1";
			this.o_oO_0o.00_O_0.().Size = new Size(465, 71);
			this.o_oO_0o.00_O_0.().TabIndex = 3;
			this.OO_0o0O.O_O00.().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.OO_0o0O.O_O00.().Controls.Add(this.oO.00_.());
			this.OO_0o0O.O_O00.().Controls.Add(this.OO.0Ooo0OO0O.());
			this.OO_0o0O.O_O00.().Controls.Add(this.o.__o_0___.());
			this.OO_0o0O.O_O00.().Controls.Add(this.o.o0OO.());
			this.OO_0o0O.O_O00.().Controls.Add(this.O_00OOO.o0O.());
			this.OO_0o0O.O_O00.().Controls.Add(this.o_o_000o_.Oo.());
			this.OO_0o0O.O_O00.().Location = new Point(12, 104);
			this.OO_0o0O.O_O00.().Margin = new Padding(3, 1, 3, 1);
			this.OO_0o0O.O_O00.().Name = "Panel2";
			this.OO_0o0O.O_O00.().Size = new Size(465, 104);
			this.OO_0o0O.O_O00.().TabIndex = 4;
			this.OO_0o0O.O_O00.().Visible = false;
			this.oO.00_.().Location = new Point(135, 76);
			this.oO.00_.().Margin = new Padding(3, 1, 3, 1);
			this.oO.00_.().Name = "txtLengths";
			this.oO.00_.().Size = new Size(160, 23);
			this.oO.00_.().TabIndex = 2;
			this.oO.00_.().Tag = null;
			this.oO.00_.().Value = "";
			this.OO.0Ooo0OO0O.().AutoSize = true;
			this.OO.0Ooo0OO0O.().Location = new Point(28, 78);
			this.OO.0Ooo0OO0O.().Margin = new Padding(3, 1, 3, 1);
			this.OO.0Ooo0OO0O.().Name = "rdoLens";
			this.OO.0Ooo0OO0O.().Size = new Size(96, 19);
			this.OO.0Ooo0OO0O.().TabIndex = 25;
			this.OO.0Ooo0OO0O.().TabStop = true;
			this.OO.0Ooo0OO0O.().Text = "长度分割:";
			this.OO.0Ooo0OO0O.().UseVisualStyleBackColor = true;
			this.o.__o_0___.().AutoSize = true;
			this.o.__o_0___.().Checked = true;
			this.o.__o_0___.().Location = new Point(28, 40);
			this.o.__o_0___.().Margin = new Padding(3, 1, 3, 1);
			this.o.__o_0___.().Name = "raoSep";
			this.o.__o_0___.().Size = new Size(96, 19);
			this.o.__o_0___.().TabIndex = 0;
			this.o.__o_0___.().TabStop = true;
			this.o.__o_0___.().Text = "符号分割:";
			this.o.__o_0___.().UseVisualStyleBackColor = true;
			this.o.o0OO.().Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.o.o0OO.().Location = new Point(135, 39);
			this.o.o0OO.().Margin = new Padding(3, 1, 3, 1);
			this.o.o0OO.().Name = "txtSeparator";
			this.o.o0OO.().Size = new Size(160, 25);
			this.o.o0OO.().TabIndex = 1;
			this.o.o0OO.().Tag = null;
			this.o.o0OO.().Value = "\\";
			this.O_00OOO.o0O.().AutoSize = true;
			this.O_00OOO.o0O.().Location = new Point(21, 5);
			this.O_00OOO.o0O.().Name = "Label4";
			this.O_00OOO.o0O.().Size = new Size(60, 15);
			this.O_00OOO.o0O.().TabIndex = 22;
			this.O_00OOO.o0O.().Text = "层级列:";
			this.o_o_000o_.Oo.().AllowSpinLoop = false;
			this.o_o_000o_.Oo.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.o_o_000o_.Oo.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.o_o_000o_.Oo.().Cursor = Cursors.Arrow;
			this.o_o_000o_.Oo.().DropDownStyle = DropDownStyle.DropDownList;
			this.o_o_000o_.Oo.().GapHeight = 0;
			this.o_o_000o_.Oo.().ImagePadding = new Padding(0);
			this.o_o_000o_.Oo.().ItemsDisplayMember = "";
			this.o_o_000o_.Oo.().ItemsValueMember = "";
			this.o_o_000o_.Oo.().Location = new Point(96, 0);
			this.o_o_000o_.Oo.().Margin = new Padding(4, 4, 4, 4);
			this.o_o_000o_.Oo.().Name = "cmbPathCol";
			this.o_o_000o_.Oo.().Size = new Size(321, 23);
			this.o_o_000o_.Oo.().TabIndex = 0;
			this.o_o_000o_.Oo.().Tag = null;
			this.oO00_o_.Oo_.().AutoSize = true;
			this.oO00_o_.Oo_.().Location = new Point(215, 69);
			this.oO00_o_.Oo_.().Name = "Label5";
			this.oO00_o_.Oo_.().Size = new Size(22, 15);
			this.oO00_o_.Oo_.().TabIndex = 29;
			this.oO00_o_.Oo_.().Text = "级";
			this.o_O_.__o.().DataType = typeof(int);
			this.o_O_.__o.().Location = new Point(151, 66);
			this.o_O_.__o.().Margin = new Padding(4, 4, 4, 4);
			this.o_O_.__o.().Name = "txtLevel";
			this.o_O_.__o.().Size = new Size(57, 23);
			this.o_O_.__o.().TabIndex = 3;
			this.o_O_.__o.().Tag = null;
			this.o_O_.__o.().TextAlign = HorizontalAlignment.Center;
			this.o_O_.__o.().Value = 0;
			this.ooO._oO_.().AutoSize = true;
			this.ooO._oO_.().Location = new Point(33, 70);
			this.ooO._oO_.().Name = "Label6";
			this.ooO._oO_.().Size = new Size(90, 15);
			this.ooO._oO_.().TabIndex = 30;
			this.ooO._oO_.().Text = "默认展开到:";
			this.O_00OOO.o0O.().AllowSpinLoop = false;
			this.O_00OOO.o0O.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.O_00OOO.o0O.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.O_00OOO.o0O.().Cursor = Cursors.Arrow;
			this.O_00OOO.o0O.().DropDownStyle = DropDownStyle.DropDownList;
			this.O_00OOO.o0O.().GapHeight = 0;
			this.O_00OOO.o0O.().ImagePadding = new Padding(0);
			this.O_00OOO.o0O.().ItemsDisplayMember = "";
			this.O_00OOO.o0O.().ItemsValueMember = "";
			this.O_00OOO.o0O.().Location = new Point(108, 190);
			this.O_00OOO.o0O.().Margin = new Padding(4, 4, 4, 4);
			this.O_00OOO.o0O.().Name = "cmbTreeCol";
			this.O_00OOO.o0O.().Size = new Size(321, 23);
			this.O_00OOO.o0O.().TabIndex = 7;
			this.O_00OOO.o0O.().Tag = null;
			this.O0_0000.o.().AutoSize = true;
			this.O0_0000.o.().Location = new Point(33, 194);
			this.O0_0000.o.().Name = "lblTree";
			this.O0_0000.o.().Size = new Size(60, 15);
			this.O0_0000.o.().TabIndex = 21;
			this.O0_0000.o.().Text = "树位置:";
			this.o00oo.o_.().AutoSize = true;
			this.o00oo.o_.().Location = new Point(351, 30);
			this.o00oo.o_.().Margin = new Padding(3, 1, 3, 1);
			this.o00oo.o_.().Name = "rdoGroup";
			this.o00oo.o_.().Size = new Size(73, 19);
			this.o00oo.o_.().TabIndex = 2;
			this.o00oo.o_.().Text = "分组型";
			this.o00oo.o_.().UseVisualStyleBackColor = true;
			this.oO.O__0.().Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.oO.O__0.().Location = new Point(108, 112);
			this.oO.O__0.().Margin = new Padding(4, 4, 4, 4);
			this.oO.O__0.().Name = "cmbGroups";
			this.oO.O__0.().Size = new Size(321, 35);
			this.oO.O__0.().Styles.CheckList.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.oO.O__0.().TabIndex = 32;
			this.oO.O__0.().Visible = false;
			this.oO__.oo000O0o0.().AutoSize = true;
			this.oO__.oo000O0o0.().Location = new Point(33, 122);
			this.oO__.oo000O0o0.().Margin = new Padding(4, 0, 4, 0);
			this.oO__.oo000O0o0.().Name = "lblGroup";
			this.oO__.oo000O0o0.().Size = new Size(60, 15);
			this.oO__.oo000O0o0.().TabIndex = 33;
			this.oO__.oo000O0o0.().Text = "分组列:";
			this.oO__.oo000O0o0.().Visible = false;
			this.O_.000__O_0o.().AllowSpinLoop = false;
			this.O_.000__O_0o.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.O_.000__O_0o.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.O_.000__O_0o.().Cursor = Cursors.Arrow;
			this.O_.000__O_0o.().DropDownStyle = DropDownStyle.DropDownList;
			this.O_.000__O_0o.().GapHeight = 0;
			this.O_.000__O_0o.().ImagePadding = new Padding(0);
			this.O_.000__O_0o.().ItemsDisplayMember = "";
			this.O_.000__O_0o.().ItemsValueMember = "";
			this.O_.000__O_0o.().Location = new Point(108, 231);
			this.O_.000__O_0o.().Margin = new Padding(4, 4, 4, 4);
			this.O_.000__O_0o.().Name = "cmbSortCols";
			this.O_.000__O_0o.().Size = new Size(321, 23);
			this.O_.000__O_0o.().TabIndex = 34;
			this.O_.000__O_0o.().Tag = null;
			this.o.__o_0___.().AutoSize = true;
			this.o.__o_0___.().Location = new Point(33, 236);
			this.o.__o_0___.().Name = "lblSort";
			this.o.__o_0___.().Size = new Size(60, 15);
			this.o.__o_0___.().TabIndex = 35;
			this.o.__o_0___.().Text = "排序列:";
			this.oO.O__0.().BorderStyle = BorderStyle.None;
			this.oO.O__0.().Location = new Point(365, 62);
			this.oO.O__0.().Margin = new Padding(4, 4, 4, 4);
			this.oO.O__0.().Name = "chkSortDesc";
			this.oO.O__0.().Size = new Size(73, 30);
			this.oO.O__0.().TabIndex = 5;
			this.oO.O__0.().Text = "降序";
			this.oO.O__0.().UseVisualStyleBackColor = true;
			this.oO.O__0.().Value = null;
			this.O0_.o_o_.().AutoSize = true;
			this.O0_.o_o_.().Location = new Point(33, 285);
			this.O0_.o_o_.().Margin = new Padding(4, 0, 4, 0);
			this.O0_.o_o_.().Name = "lblValueCols";
			this.O0_.o_o_.().Size = new Size(60, 15);
			this.O0_.o_o_.().TabIndex = 38;
			this.O0_.o_o_.().Text = "统计列:";
			this.oO__.oo000O0o0.().Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.oO__.oo000O0o0.().Location = new Point(108, 275);
			this.oO__.oo000O0o0.().Margin = new Padding(4, 4, 4, 4);
			this.oO__.oo000O0o0.().Name = "cmbValueCols";
			this.oO__.oo000O0o0.().Size = new Size(321, 35);
			this.oO__.oo000O0o0.().Styles.CheckList.Font = new Font("微软雅黑", 9f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.oO__.oo000O0o0.().TabIndex = 37;
			this.o_0O0.O0.().BorderStyle = BorderStyle.None;
			this.o_0O0.O0.().Location = new Point(282, 62);
			this.o_0O0.O0.().Margin = new Padding(4);
			this.o_0O0.O0.().Name = "chkStyle";
			this.o_0O0.O0.().Size = new Size(73, 30);
			this.o_0O0.O0.().TabIndex = 4;
			this.o_0O0.O0.().Text = "样式";
			this.o_0O0.O0.().UseVisualStyleBackColor = true;
			this.o_0O0.O0.().Value = null;
			base.AutoScaleDimensions = new SizeF(8f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(471, 436);
			base.Controls.Add(this.o_0O0.O0.());
			base.Controls.Add(this.O0_.o_o_.());
			base.Controls.Add(this.oO__.oo000O0o0.());
			base.Controls.Add(this.oO.O__0.());
			base.Controls.Add(this.O_.000__O_0o.());
			base.Controls.Add(this.o.__o_0___.());
			base.Controls.Add(this.oO__.oo000O0o0.());
			base.Controls.Add(this.oO.O__0.());
			base.Controls.Add(this.o00oo.o_.());
			base.Controls.Add(this.O_00OOO.o0O.());
			base.Controls.Add(this.O0_0000.o.());
			base.Controls.Add(this.ooO._oO_.());
			base.Controls.Add(this.oO00_o_.Oo_.());
			base.Controls.Add(this.o_O_.__o.());
			base.Controls.Add(this.O.o_0o_.());
			base.Controls.Add(this.o_oO_0o.00_O_0.());
			base.Controls.Add(this.OO_0o0O.O_O00.());
			base.Controls.Add(this.oO.O__0.());
			base.Controls.Add(this.o_0O0.O0.());
			base.Controls.Add(this.o_oO_0o.00_O_0.());
			base.Controls.Add(this.OO_0o0O.O_O00.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(4, 4, 4, 4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oO...0..";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "设置折叠模式";
			((ISupportInitialize)this.oO.O__0.()).EndInit();
			((ISupportInitialize)this.o_0O0.O0.()).EndInit();
			((ISupportInitialize)this.o_0O0.O0.()).EndInit();
			((ISupportInitialize)this.o_o00oO_O.0.()).EndInit();
			this.o_oO_0o.00_O_0.().ResumeLayout(false);
			this.o_oO_0o.00_O_0.().PerformLayout();
			this.OO_0o0O.O_O00.().ResumeLayout(false);
			this.OO_0o0O.O_O00.().PerformLayout();
			((ISupportInitialize)this.oO.00_.()).EndInit();
			((ISupportInitialize)this.o.o0OO.()).EndInit();
			((ISupportInitialize)this.o_o_000o_.Oo.()).EndInit();
			((ISupportInitialize)this.o_O_.__o.()).EndInit();
			((ISupportInitialize)this.O_00OOO.o0O.()).EndInit();
			((ISupportInitialize)this.O_.000__O_0o.()).EndInit();
			((ISupportInitialize)this.oO.O__0.()).EndInit();
			((ISupportInitialize)this.o_0O0.O0.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00068DE8 File Offset: 0x00066FE8
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOo.O___.;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00068DF0 File Offset: 0x00066FF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.OOo.O___. = A_0;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00068DF9 File Offset: 0x00066FF9
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0._0oo0O__.;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00068E04 File Offset: 0x00067004
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOO_.o_0O.);
			C1Button o0._0oo0O__. = this.O0._0oo0O__.;
			if (o0._0oo0O__. != null)
			{
				o0._0oo0O__..Click -= value;
			}
			this.O0._0oo0O__. = A_0;
			o0._0oo0O__. = this.O0._0oo0O__.;
			if (o0._0oo0O__. != null)
			{
				o0._0oo0O__..Click += value;
			}
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00068E47 File Offset: 0x00067047
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O___._0O.;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00068E4F File Offset: 0x0006704F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O___._0O. = A_0;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00068E58 File Offset: 0x00067058
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OoOoO0.o00.;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00068E60 File Offset: 0x00067060
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OoOoO0.o00. = A_0;
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00068E69 File Offset: 0x00067069
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o0oo0o._0.;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00068E71 File Offset: 0x00067071
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.o0oo0o._0. = A_0;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00068E7A File Offset: 0x0006707A
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.OoOoO0.o00.;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00068E82 File Offset: 0x00067082
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.OoOoO0.o00. = A_0;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00068E8B File Offset: 0x0006708B
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.Oo._0o0o0o_.;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00068E94 File Offset: 0x00067094
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.o._oo0O0O.);
			RadioButton oo._0o0o0o_. = this.Oo._0o0o0o_.;
			if (oo._0o0o0o_. != null)
			{
				oo._0o0o0o_..CheckedChanged -= value;
			}
			this.Oo._0o0o0o_. = A_0;
			oo._0o0o0o_. = this.Oo._0o0o0o_.;
			if (oo._0o0o0o_. != null)
			{
				oo._0o0o0o_..CheckedChanged += value;
			}
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00068ED7 File Offset: 0x000670D7
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o._oo_O00__.;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00068EE0 File Offset: 0x000670E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.o._oo0O0O.);
			RadioButton radioButton = this.o._oo_O00__.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.o._oo_O00__. = A_0;
			radioButton = this.o._oo_O00__.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00068F23 File Offset: 0x00067123
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.ooOOOO_.;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00068F2B File Offset: 0x0006712B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.ooOOOO_. = A_0;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00068F34 File Offset: 0x00067134
		[CompilerGenerated]
		internal virtual Panel <<EMPTY_NAME>>()
		{
			return this.O___._0O.;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00068F3C File Offset: 0x0006713C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Panel A_0)
		{
			this.O___._0O. = A_0;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00068F45 File Offset: 0x00067145
		[CompilerGenerated]
		internal virtual Panel <<EMPTY_NAME>>()
		{
			return this.o._oo_O00__.;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00068F4D File Offset: 0x0006714D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Panel A_0)
		{
			this.o._oo_O00__. = A_0;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00068F56 File Offset: 0x00067156
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.Oo._0o0o0o_.;
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00068F5E File Offset: 0x0006715E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.Oo._0o0o0o_. = A_0;
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00068F67 File Offset: 0x00067167
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O_ooo0o_0.o.;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00068F70 File Offset: 0x00067170
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.oO.00_.);
			RadioButton o_ooo0o_0.o. = this.O_ooo0o_0.o.;
			if (o_ooo0o_0.o. != null)
			{
				o_ooo0o_0.o..CheckedChanged -= value;
			}
			this.O_ooo0o_0.o. = A_0;
			o_ooo0o_0.o. = this.O_ooo0o_0.o.;
			if (o_ooo0o_0.o. != null)
			{
				o_ooo0o_0.o..CheckedChanged += value;
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00068FB3 File Offset: 0x000671B3
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O_O._0_O0.;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00068FBC File Offset: 0x000671BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.oO.00_.);
			RadioButton o_O._0_O0. = this.O_O._0_O0.;
			if (o_O._0_O0. != null)
			{
				o_O._0_O0..CheckedChanged -= value;
			}
			this.O_O._0_O0. = A_0;
			o_O._0_O0. = this.O_O._0_O0.;
			if (o_O._0_O0. != null)
			{
				o_O._0_O0..CheckedChanged += value;
			}
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00068FFF File Offset: 0x000671FF
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o._oo_O00__.;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00069007 File Offset: 0x00067207
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o._oo_O00__. = A_0;
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00069010 File Offset: 0x00067210
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oO__O00.0O_0_.;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00069018 File Offset: 0x00067218
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oO__O00.0O_0_. = A_0;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00069021 File Offset: 0x00067221
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.OOo0o0o0O.o0oo.;
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00069029 File Offset: 0x00067229
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.OOo0o0o0O.o0oo. = A_0;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00069032 File Offset: 0x00067232
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0O_.000_0.;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0006903A File Offset: 0x0006723A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0O_.000_0. = A_0;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00069043 File Offset: 0x00067243
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_ooo0o_0.o.;
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0006904B File Offset: 0x0006724B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O_ooo0o_0.o. = A_0;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00069054 File Offset: 0x00067254
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0OO_.o_0o_.;
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x0006905C File Offset: 0x0006725C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0OO_.o_0o_. = A_0;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00069065 File Offset: 0x00067265
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O0__oo_.o.;
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x0006906D File Offset: 0x0006726D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.O0__oo_.o. = A_0;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00069076 File Offset: 0x00067276
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.Oooo.;
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0006907E File Offset: 0x0006727E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.Oooo. = A_0;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00069087 File Offset: 0x00067287
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O0oO0_oO_.0_.;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0006908F File Offset: 0x0006728F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O0oO0_oO_.0_. = A_0;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00069098 File Offset: 0x00067298
		[CompilerGenerated]
		internal virtual C1MultiSelect <<EMPTY_NAME>>()
		{
			return this.o0oo0o._0.;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000690A0 File Offset: 0x000672A0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1MultiSelect A_0)
		{
			this.o0oo0o._0. = A_0;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x000690A9 File Offset: 0x000672A9
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.oO0_ooo_.;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x000690B1 File Offset: 0x000672B1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.oO0_ooo_. = A_0;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x000690BA File Offset: 0x000672BA
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O.0OO0O__OoO.;
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x000690C2 File Offset: 0x000672C2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.O.0OO0O__OoO. = A_0;
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000690CB File Offset: 0x000672CB
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0_oOooOoo._.;
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000690D3 File Offset: 0x000672D3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0_oOooOoo._. = A_0;
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x000690DC File Offset: 0x000672DC
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o0oo0o._0.;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x000690E4 File Offset: 0x000672E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o0oo0o._0. = A_0;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x000690ED File Offset: 0x000672ED
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0Oo__._.;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000690F5 File Offset: 0x000672F5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0Oo__._. = A_0;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x000690FE File Offset: 0x000672FE
		[CompilerGenerated]
		internal virtual C1MultiSelect <<EMPTY_NAME>>()
		{
			return this.OoOoO0.o00.;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00069106 File Offset: 0x00067306
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1MultiSelect A_0)
		{
			this.OoOoO0.o00. = A_0;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0006910F File Offset: 0x0006730F
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.OoOoO0.o00.;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00069117 File Offset: 0x00067317
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.OoOoO0.o00. = A_0;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00069120 File Offset: 0x00067320
		public O\u30020\u3000\u3002(Table A_0)
		{
			base.Load += this.oO.O__0.;
			base.FormClosed += this.o_0O0.O0.;
			this.Oo._0o0o0o_. = new Dictionary<string, string>();
			this.O_.0O_O_. = OO_00oOO.MainTable;
			this.o.o0OO.();
			this.O_.0O_O_. = A_0;
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0006917C File Offset: 0x0006737C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_oO_0o.00_O_0.().Visible = this.OO_0o0O.O_O00.().Checked;
			this.OO_0o0O.O_O00.().Visible = this.o_oO_0o.00_O_0.().Checked;
			this.O0_0000.o.().Visible = !this.o00oo.o_.().Checked;
			this.O_00OOO.o0O.().Visible = !this.o00oo.o_.().Checked;
			this.oO__.oo000O0o0.().Visible = this.o00oo.o_.().Checked;
			this.oO.O__0.().Visible = this.o00oo.o_.().Checked;
			this.o_0O0.O0.().Visible = !this.o00oo.o_.().Checked;
			if (this.o00oo.o_.().Checked)
			{
				this.O0_.o_o_.().Top = 140;
				this.oO__.oo000O0o0.().Top = 132;
				this.o.__o_0___.().Top = 178;
				this.O_.000__O_0o.().Top = 174;
				return;
			}
			if (this.OO_0o0O.O_O00.().Checked)
			{
				this.O0_0000.o.().Top = 155;
				this.O_00OOO.o0O.().Top = 152;
				this.o.__o_0___.().Top = 189;
				this.O_.000__O_0o.().Top = 185;
				this.O0_.o_o_.().Top = 226;
				this.oO__.oo000O0o0.().Top = 218;
				return;
			}
			if (this.o_oO_0o.00_O_0.().Checked)
			{
				this.O0_0000.o.().Top = 179;
				this.O_00OOO.o0O.().Top = 176;
				this.o.__o_0___.().Top = 213;
				this.O_.000__O_0o.().Top = 209;
				this.O0_.o_o_.().Top = 250;
				this.oO__.oo000O0o0.().Top = 242;
			}
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00069355 File Offset: 0x00067555
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.o0OO.().Enabled = this.o.__o_0___.().Checked;
			this.oO.00_.().Enabled = !this.o.__o_0___.().Checked;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00069388 File Offset: 0x00067588
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_.0O_O_. = OO_00oOO.MainTable;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o_O_.__o.().Value = this.O_.0O_O_..o__.O0o.;
			this.oO.00_.().Value = this.O_.0O_O_..O_OO.oO0_.;
			this.o.o0OO.().Value = this.O_.0O_O_..oO0.00.;
			this.oO.O__0.().Checked = this.O_.0O_O_..oO_.ooo0o.;
			this.o_0O0.O0.().Checked = this.O_.0O_O_..oO._o.;
			this.O_00OOO.o0O.().Items.Add("");
			this.O_.000__O_0o.().Items.Add("");
			try
			{
				foreach (DataCol dataCol in this.O_.0O_O_..DataTable.DataCols)
				{
					string left = "";
					if (Operators.CompareString(dataCol.Caption, "", true) > 0 && !this.Oo._0o0o0o_..ContainsKey(dataCol.Caption))
					{
						left = dataCol.Caption;
						this.Oo._0o0o0o_..Add(dataCol.Caption, dataCol.Name);
					}
					C1ComboBox[] array = new C1ComboBox[]
					{
						this.o_o00oO_O.0.(),
						this.o_0O0.O0.(),
						this.o_o_000o_.Oo.(),
						this.O_00OOO.o0O.(),
						this.O_.000__O_0o.()
					};
					string[] array2 = new string[]
					{
						this.O_.0O_O_..oooo00O.o__0O.,
						this.O_.0O_O_..O___o0.Oo.,
						this.O_.0O_O_..O_.oOoOO0o.,
						this.O_.0O_O_..O000__.o_ooo_O.,
						this.O_.0O_O_..O0_O.0oOO0Oo0.
					};
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if ((array[i] != this.O_.0O_O_..O_.oOoOO0o. || dataCol.DataType == typeof(string)) && (array[i] == this.O_.000__O_0o.() || array[i] == this.O_00OOO.o0O.() || o_O_o_oOoo__.OOOO_OO._oo.(dataCol.BaseColumn.DataType)))
						{
							C1ComboBox c1ComboBox = array[i];
							if (Operators.CompareString(left, "", true) > 0)
							{
								c1ComboBox.Items.Add(dataCol.Caption);
							}
							else
							{
								c1ComboBox.Items.Add(dataCol.Name);
							}
							if (Operators.CompareString(array2[i], dataCol.Name, true) == 0)
							{
								c1ComboBox.SelectedIndex = c1ComboBox.Items.Count - 1;
							}
						}
					}
					if (dataCol.IsString || dataCol.IsNumeric)
					{
						C1CheckListItem c1CheckListItem = new C1CheckListItem();
						if (Operators.CompareString(left, "", true) > 0)
						{
							c1CheckListItem.Value = dataCol.Caption;
						}
						else
						{
							c1CheckListItem.Value = dataCol.Name;
						}
						if (o_O_o_oOoo__.OOOO_OO._oo.(dataCol.DataType))
						{
							this.oO.O__0.().Items.Add(c1CheckListItem);
						}
						if (dataCol.IsNumeric)
						{
							C1CheckListItem item = new C1CheckListItem(RuntimeHelpers.GetObjectValue(c1CheckListItem.Value));
							this.oO__.oo000O0o0.().Items.Add(item);
						}
					}
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
			if (Operators.CompareString(this.O_.0O_O_..O_.oOoOO0o., "", true) > 0)
			{
				this.o_oO_0o.00_O_0.().Checked = true;
				if (Operators.CompareString(this.O_.0O_O_..oO0.00., "", true) == 0 && Operators.CompareString(this.O_.0O_O_..O_OO.oO0_., "", true) > 0)
				{
					this.OO.0Ooo0OO0O.().Checked = true;
				}
			}
			if (Operators.CompareString(this.O_.0O_O_..o_oO__O.0_., "", true) > 0)
			{
				this.o00oo.o_.().Checked = true;
				List<string> list = new List<string>();
				list.AddRange(this.O_.0O_O_..o_oO__O.0_..Split(new char[]
				{
					','
				}));
				try
				{
					foreach (C1CheckListItem c1CheckListItem2 in this.oO.O__0.().Items)
					{
						if (list.Contains(this.o.o0OO.(c1CheckListItem2.Value.ToString())))
						{
							c1CheckListItem2.Selected = true;
						}
					}
				}
				finally
				{
					IEnumerator<C1CheckListItem> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
			}
			if (Operators.CompareString(this.O_.0O_O_..oOoo____oo.O0., "", true) > 0)
			{
				List<string> list2 = new List<string>();
				list2.AddRange(this.O_.0O_O_..oOoo____oo.O0..Split(new char[]
				{
					','
				}));
				try
				{
					foreach (C1CheckListItem c1CheckListItem3 in this.oO__.oo000O0o0.().Items)
					{
						if (list2.Contains(this.o.o0OO.(c1CheckListItem3.Value.ToString())))
						{
							c1CheckListItem3.Selected = true;
						}
					}
				}
				finally
				{
					IEnumerator<C1CheckListItem> enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
			}
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000698B4 File Offset: 0x00067AB4
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000698C8 File Offset: 0x00067AC8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num = -1;
			string text = "";
			string o0_O.0oOO0Oo0. = "";
			if (this.O_00OOO.o0O.().SelectedIndex > 0)
			{
				text = this.o.o0OO.(this.O_00OOO.o0O.().SelectedItem.ToString());
			}
			if (this.O_.000__O_0o.().SelectedIndex > 0)
			{
				o0_O.0oOO0Oo0. = this.o.o0OO.(this.O_.000__O_0o.().SelectedItem.ToString());
			}
			if (this.o_O_.__o.().Value != null)
			{
				num = Conversions.ToInteger(this.o_O_.__o.().Value);
			}
			this.O_.0O_O_..oooo00O.o__0O. = null;
			this.O_.0O_O_..O___o0.Oo. = null;
			this.O_.0O_O_..O_.oOoOO0o. = null;
			this.O_.0O_O_..O000__.o_ooo_O. = text;
			this.O_.0O_O_..O0_O.0oOO0Oo0. = o0_O.0oOO0Oo0.;
			this.O_.0O_O_..oO0.00. = null;
			this.O_.0O_O_..O_OO.oO0_. = null;
			this.O_.0O_O_..o__.O0o. = num;
			this.O_.0O_O_..o_oO__O.0_. = null;
			this.O_.0O_O_..oOoo____oo.O0. = null;
			this.O_.0O_O_..oO_.ooo0o. = this.oO.O__0.().Checked;
			this.O_.0O_O_..oO._o. = this.o_0O0.O0.().Checked;
			List<string> list = new List<string>();
			try
			{
				foreach (C1CheckListItem c1CheckListItem in this.oO__.oo000O0o0.().SelectedItems)
				{
					list.Add(this.o.o0OO.(c1CheckListItem.Value.ToString()));
				}
			}
			finally
			{
				IEnumerator<C1CheckListItem> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			string text2 = string.Join(",", list);
			if (this.OO_0o0O.O_O00.().Checked)
			{
				if (this.o_o00oO_O.0.().SelectedIndex > -1 && this.o_0O0.O0.().SelectedIndex > -1)
				{
					string text3 = this.o.o0OO.(this.o_o00oO_O.0.().SelectedItem.ToString());
					string text4 = this.o.o0OO.(this.o_0O0.O0.().SelectedItem.ToString());
					this.O_.0O_O_..oooo00O.o__0O. = text3;
					this.O_.0O_O_..O___o0.Oo. = text4;
					this.O_.0O_O_..oOoo____oo.O0. = text2;
					this.O_.0O_O_..OOo0_Oo._OOo.(text3, text4, text, text2, num);
					this.O_.0O_O_..O_O0.0_o.(num);
					base.DialogResult = DialogResult.OK;
					return;
				}
			}
			else if (this.o_oO_0o.00_O_0.().Checked && this.o_o_000o_.Oo.().SelectedIndex > -1)
			{
				string text5 = this.o.o0OO.(this.o_o_000o_.Oo.().SelectedItem.ToString());
				this.O_.0O_O_..O_.oOoOO0o. = text5;
				if (this.o.__o_0___.().Checked)
				{
					if (Operators.CompareString(this.o.o0OO.().Text, "", true) > 0)
					{
						char c = this.o.o0OO.().Text[0];
						this.O_.0O_O_..oO0.00. = Conversions.ToString(c);
						this.O_.0O_O_..oOoo____oo.O0. = text2;
						this.O_.0O_O_..O_.o__ooo.(text5, text, c, text2, num);
						this.O_.0O_O_..O_O0.0_o.(num);
						base.DialogResult = DialogResult.OK;
						return;
					}
				}
				else if (this.o_oO_0o.00_O_0.().Checked && Operators.CompareString(this.oO.00_.().Text, "", true) > 0)
				{
					string[] array = Regex.Split(this.oO.00_.().Text, "[^\\d]+");
					int[] array2 = new int[array.Length - 1 + 1];
					if (array.Length > 0)
					{
						int num2 = array.Length - 1;
						for (int i = 0; i <= num2; i++)
						{
							int num3;
							if (!int.TryParse(array[i], out num3))
							{
								return;
							}
							array2[i] = num3;
						}
					}
					if (array2.Length > 0 && array2.Length == array.Length)
					{
						this.O_.0O_O_..O_OO.oO0_. = string.Join<int>(",", array2);
						this.O_.0O_O_..oOoo____oo.O0. = text2;
						this.O_.0O_O_..OOo0_Oo._OOo.(text5, text, array2, text2, num);
						this.O_.0O_O_..O_O0.0_o.(num);
						base.DialogResult = DialogResult.OK;
						return;
					}
				}
			}
			else if (this.o00oo.o_.().Checked & this.oO.O__0.().SelectedItems.Count > 0)
			{
				List<string> list2 = new List<string>();
				try
				{
					foreach (C1CheckListItem c1CheckListItem2 in this.oO.O__0.().SelectedItems)
					{
						list2.Add(c1CheckListItem2.Value.ToString());
					}
				}
				finally
				{
					IEnumerator<C1CheckListItem> enumerator2;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
				}
				base.DialogResult = DialogResult.OK;
				Application.DoEvents();
				this.O_.0O_O_..OOo0_Oo._OOo.(list2.ToArray(), text2, this.O_.0O_O_..O0_O.0oOO0Oo0., this.O_.0O_O_..oO_.ooo0o., num);
				this.O_.0O_O_..o_oO__O.0_. = string.Join(",", list2);
				this.O_.0O_O_..oOoo____oo.O0. = text2;
				this.O_.0O_O_..NeedSaveSetting = true;
				this.O_.0O_O_..oo0OO0Ooo._.(true);
			}
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00069DB4 File Offset: 0x00067FB4
		private string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (this.Oo._0o0o0o_..ContainsKey(A_0))
			{
				result = this.Oo._0o0o0o_.[A_0];
			}
			else
			{
				result = A_0;
			}
			return result;
		}

		// Token: 0x040004C5 RID: 1221
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040004C6 RID: 1222
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040004C7 RID: 1223
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040004C8 RID: 1224
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004C9 RID: 1225
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004CA RID: 1226
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040004CB RID: 1227
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040004CC RID: 1228
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x040004CD RID: 1229
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x040004CE RID: 1230
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004CF RID: 1231
		[CompilerGenerated]
		private Panel <<EMPTY_NAME>>;

		// Token: 0x040004D0 RID: 1232
		[CompilerGenerated]
		private Panel <<EMPTY_NAME>>;

		// Token: 0x040004D1 RID: 1233
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040004D2 RID: 1234
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x040004D3 RID: 1235
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x040004D4 RID: 1236
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040004D5 RID: 1237
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004D6 RID: 1238
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040004D7 RID: 1239
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004D8 RID: 1240
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040004D9 RID: 1241
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004DA RID: 1242
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040004DB RID: 1243
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004DC RID: 1244
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x040004DD RID: 1245
		[CompilerGenerated]
		private C1MultiSelect <<EMPTY_NAME>>;

		// Token: 0x040004DE RID: 1246
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004DF RID: 1247
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040004E0 RID: 1248
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004E1 RID: 1249
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040004E2 RID: 1250
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040004E3 RID: 1251
		[CompilerGenerated]
		private C1MultiSelect <<EMPTY_NAME>>;

		// Token: 0x040004E4 RID: 1252
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040004E5 RID: 1253
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x040004E6 RID: 1254
		private Table <<EMPTY_NAME>>;
	}
}
