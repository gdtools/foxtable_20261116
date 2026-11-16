using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000E6 RID: 230
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal partial class o\u3000\u3002\u3000\u3002\u3000\u3002 : Form
	{
		// Token: 0x06000D0A RID: 3338 RVA: 0x0006C5E4 File Offset: 0x0006A7E4
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o_OO.0O0o0ooO_. != null)
				{
					this.o_OO.0O0o0ooO_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0006C624 File Offset: 0x0006A824
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o__0O_O0._0o.(new C1Button());
			this.o0oo_._0_.(new C1Button());
			this.O_0_.0.(new Label());
			this.o00__oOO_0.0o.(new Label());
			this.O_0_.0.(new C1ComboBox());
			this.OO0o__O.O0o0_O.(new C1ComboBox());
			this.o0O_00.oo_O_O_.(new C1TextBox());
			this.o_.OO0_o.(new RadioButton());
			this.o0O_00.oo_O_O_.(new RadioButton());
			this.OOO0O.__OOo_0.(new Label());
			this.o0O_00.oo_O_O_.(new C1ComboBox());
			this.o.oo____0.(new C1TextBox());
			this.OOOoO._0_o.(new Label());
			this.o_.OO0_o.(new C1TextBox());
			this.o00__oOO_0.0o.(new C1CheckBox());
			this.o00O.oo_o0.(new C1CheckBox());
			this.o__0O_O0._0o.(new C1CheckBox());
			this.O0._O0O.(new C1CheckBox());
			this.OOOOO.oOOo_000.(new Label());
			this.OoOOO0o.__.(new Label());
			this.o_.OO0_o.(new C1ComboBox());
			this.o0oo_._0_.(new C1CheckBox());
			this.OO___o.0_0.(new Label());
			this.o00_0o__._oo_.(new C1ComboBox());
			this.OOOOO.oOOo_000.(new C1CheckBox());
			((ISupportInitialize)this.O._oOOo00__O.()).BeginInit();
			((ISupportInitialize)this.o__O0O00.o.()).BeginInit();
			((ISupportInitialize)this.oo._0_oOo0oo_.()).BeginInit();
			((ISupportInitialize)this.O0oooo00.00O0.()).BeginInit();
			((ISupportInitialize)this.O00Oo._00_.()).BeginInit();
			((ISupportInitialize)this.oOOO.oOOooo___.()).BeginInit();
			((ISupportInitialize)this.O_0.00O.()).BeginInit();
			((ISupportInitialize)this.Ooo_o0.__.()).BeginInit();
			((ISupportInitialize)this.O0oooo00.00O0.()).BeginInit();
			((ISupportInitialize)this.oO.o0o_.()).BeginInit();
			((ISupportInitialize)this.OO0O___O_.0o0.()).BeginInit();
			((ISupportInitialize)this.O._oOOo00__O.()).BeginInit();
			((ISupportInitialize)this.O00Oo._00_.()).BeginInit();
			((ISupportInitialize)this.o__O0O00.o.()).BeginInit();
			((ISupportInitialize)this.Ooo_o0.__.()).BeginInit();
			((ISupportInitialize)this.OO.oOO.()).BeginInit();
			base.SuspendLayout();
			this.O._oOOo00__O.().DialogResult = DialogResult.Cancel;
			this.O._oOOo00__O.().ImageAlign = ContentAlignment.MiddleLeft;
			this.O._oOOo00__O.().Location = new Point(187, 358);
			this.O._oOOo00__O.().Name = "btnCancel";
			this.O._oOOo00__O.().Size = new Size(75, 23);
			this.O._oOOo00__O.().TabIndex = 15;
			this.O._oOOo00__O.().Text = "取消";
			this.O._oOOo00__O.().UseVisualStyleBackColor = true;
			this.o__O0O00.o.().ImageAlign = ContentAlignment.MiddleLeft;
			this.o__O0O00.o.().Location = new Point(96, 358);
			this.o__O0O00.o.().Name = "btnOK";
			this.o__O0O00.o.().Size = new Size(75, 23);
			this.o__O0O00.o.().TabIndex = 14;
			this.o__O0O00.o.().Text = "确定";
			this.o__O0O00.o.().UseVisualStyleBackColor = true;
			this.o.__OOO.().AutoSize = true;
			this.o.__OOO.().Location = new Point(25, 126);
			this.o.__OOO.().Margin = new Padding(2, 0, 2, 0);
			this.o.__OOO.().Name = "Label3";
			this.o.__OOO.().Size = new Size(47, 12);
			this.o.__OOO.().TabIndex = 14;
			this.o.__OOO.().Text = "名称列:";
			this.o.0o_o0.().AutoSize = true;
			this.o.0o_o0.().Location = new Point(25, 23);
			this.o.0o_o0.().Margin = new Padding(2, 0, 2, 0);
			this.o.0o_o0.().Name = "Label1";
			this.o.0o_o0.().Size = new Size(47, 12);
			this.o.0o_o0.().TabIndex = 12;
			this.o.0o_o0.().Text = "层级列:";
			this.oo._0_oOo0oo_.().AllowSpinLoop = false;
			this.oo._0_oOo0oo_.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.oo._0_oOo0oo_.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.oo._0_oOo0oo_.().Cursor = Cursors.Arrow;
			this.oo._0_oOo0oo_.().DropDownStyle = DropDownStyle.DropDownList;
			this.oo._0_oOo0oo_.().GapHeight = 0;
			this.oo._0_oOo0oo_.().ImagePadding = new Padding(0);
			this.oo._0_oOo0oo_.().ItemsDisplayMember = "";
			this.oo._0_oOo0oo_.().ItemsValueMember = "";
			this.oo._0_oOo0oo_.().Location = new Point(87, 123);
			this.oo._0_oOo0oo_.().Name = "lstCaptionCols";
			this.oo._0_oOo0oo_.().Size = new Size(239, 19);
			this.oo._0_oOo0oo_.().TabIndex = 3;
			this.oo._0_oOo0oo_.().Tag = null;
			this.O0oooo00.00O0.().AllowSpinLoop = false;
			this.O0oooo00.00O0.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.O0oooo00.00O0.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.O0oooo00.00O0.().Cursor = Cursors.Arrow;
			this.O0oooo00.00O0.().DropDownStyle = DropDownStyle.DropDownList;
			this.O0oooo00.00O0.().GapHeight = 0;
			this.O0oooo00.00O0.().ImagePadding = new Padding(0);
			this.O0oooo00.00O0.().ItemsDisplayMember = "";
			this.O0oooo00.00O0.().ItemsValueMember = "";
			this.O0oooo00.00O0.().Location = new Point(87, 21);
			this.O0oooo00.00O0.().Name = "lstPathCols";
			this.O0oooo00.00O0.().Size = new Size(239, 19);
			this.O0oooo00.00O0.().TabIndex = 0;
			this.O0oooo00.00O0.().Tag = null;
			this.O00Oo._00_.().Location = new Point(111, 53);
			this.O00Oo._00_.().Margin = new Padding(2, 1, 2, 1);
			this.O00Oo._00_.().Name = "txtSeparator";
			this.O00Oo._00_.().Size = new Size(117, 19);
			this.O00Oo._00_.().TabIndex = 1;
			this.O00Oo._00_.().Tag = null;
			this.O00Oo._00_.().Value = "\\";
			this.Ooo_o0.__.().AutoSize = true;
			this.Ooo_o0.__.().Checked = true;
			this.Ooo_o0.__.().Location = new Point(25, 53);
			this.Ooo_o0.__.().Margin = new Padding(2, 1, 2, 1);
			this.Ooo_o0.__.().Name = "raoSep";
			this.Ooo_o0.__.().Size = new Size(77, 16);
			this.Ooo_o0.__.().TabIndex = 19;
			this.Ooo_o0.__.().TabStop = true;
			this.Ooo_o0.__.().Text = "符号分割:";
			this.Ooo_o0.__.().UseVisualStyleBackColor = true;
			this.O_0.00O.().AutoSize = true;
			this.O_0.00O.().Location = new Point(25, 85);
			this.O_0.00O.().Margin = new Padding(2, 1, 2, 1);
			this.O_0.00O.().Name = "rdoLens";
			this.O_0.00O.().Size = new Size(77, 16);
			this.O_0.00O.().TabIndex = 20;
			this.O_0.00O.().TabStop = true;
			this.O_0.00O.().Text = "长度分割:";
			this.O_0.00O.().UseVisualStyleBackColor = true;
			this.oo.0___oo__oO_.().AutoSize = true;
			this.oo.0___oo__oO_.().Location = new Point(25, 157);
			this.oo.0___oo__oO_.().Margin = new Padding(2, 0, 2, 0);
			this.oo.0___oo__oO_.().Name = "Label2";
			this.oo.0___oo__oO_.().Size = new Size(47, 12);
			this.oo.0___oo__oO_.().TabIndex = 22;
			this.oo.0___oo__oO_.().Text = "数值列:";
			this.oOOO.oOOooo___.().AllowSpinLoop = false;
			this.oOOO.oOOooo___.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.oOOO.oOOooo___.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.oOOO.oOOooo___.().Cursor = Cursors.Arrow;
			this.oOOO.oOOooo___.().DropDownStyle = DropDownStyle.DropDownList;
			this.oOOO.oOOooo___.().GapHeight = 0;
			this.oOOO.oOOooo___.().ImagePadding = new Padding(0);
			this.oOOO.oOOooo___.().ItemsDisplayMember = "";
			this.oOOO.oOOooo___.().ItemsValueMember = "";
			this.oOOO.oOOooo___.().Location = new Point(87, 155);
			this.oOOO.oOOooo___.().Name = "lstValueCols";
			this.oOOO.oOOooo___.().Size = new Size(239, 19);
			this.oOOO.oOOooo___.().TabIndex = 4;
			this.oOOO.oOOooo___.().Tag = null;
			this.O_0.00O.().Enabled = false;
			this.O_0.00O.().Location = new Point(111, 84);
			this.O_0.00O.().Margin = new Padding(2, 1, 2, 1);
			this.O_0.00O.().Name = "txtLengths";
			this.O_0.00O.().Size = new Size(117, 19);
			this.O_0.00O.().TabIndex = 2;
			this.O_0.00O.().Tag = null;
			this.O_0.00O.().Value = "";
			this.O00_oO_00oo.O.().AutoSize = true;
			this.O00_oO_00oo.O.().Location = new Point(205, 313);
			this.O00_oO_00oo.O.().Margin = new Padding(2, 0, 2, 0);
			this.O00_oO_00oo.O.().Name = "Label5";
			this.O00_oO_00oo.O.().Size = new Size(17, 12);
			this.O00_oO_00oo.O.().TabIndex = 29;
			this.O00_oO_00oo.O.().Text = "级";
			this.Ooo_o0.__.().DataType = typeof(int);
			this.Ooo_o0.__.().Enabled = false;
			this.Ooo_o0.__.().Location = new Point(172, 310);
			this.Ooo_o0.__.().Name = "txtLevel";
			this.Ooo_o0.__.().Size = new Size(29, 19);
			this.Ooo_o0.__.().TabIndex = 12;
			this.Ooo_o0.__.().Tag = null;
			this.Ooo_o0.__.().Value = 0;
			this.O0oooo00.00O0.().AutoSize = true;
			this.O0oooo00.00O0.().BorderStyle = BorderStyle.None;
			this.O0oooo00.00O0.().Location = new Point(87, 285);
			this.O0oooo00.00O0.().Margin = new Padding(2, 1, 2, 1);
			this.O0oooo00.00O0.().Name = "chkShowGridTree";
			this.O0oooo00.00O0.().Size = new Size(84, 16);
			this.O0oooo00.00O0.().TabIndex = 9;
			this.O0oooo00.00O0.().Text = "显示折叠树";
			this.O0oooo00.00O0.().UseVisualStyleBackColor = true;
			this.O0oooo00.00O0.().Value = null;
			this.oO.o0o_.().AutoSize = true;
			this.oO.o0o_.().BorderStyle = BorderStyle.None;
			this.oO.o0o_.().Enabled = false;
			this.oO.o0o_.().Location = new Point(87, 311);
			this.oO.o0o_.().Margin = new Padding(2, 1, 2, 1);
			this.oO.o0o_.().Name = "chkAutoFold";
			this.oO.o0o_.().Size = new Size(90, 16);
			this.oO.o0o_.().TabIndex = 11;
			this.oO.o0o_.().Text = "默认展开到:";
			this.oO.o0o_.().UseVisualStyleBackColor = true;
			this.oO.o0o_.().Value = null;
			this.OO0O___O_.0o0.().AutoSize = true;
			this.OO0O___O_.0o0.().BorderStyle = BorderStyle.None;
			this.OO0O___O_.0o0.().Location = new Point(218, 257);
			this.OO0O___O_.0o0.().Margin = new Padding(2, 1, 2, 1);
			this.OO0O___O_.0o0.().Name = "chkAutoSum";
			this.OO0O___O_.0o0.().Size = new Size(108, 16);
			this.OO0O___O_.0o0.().TabIndex = 8;
			this.OO0O___O_.0o0.().Text = "汇总子目录数据";
			this.OO0O___O_.0o0.().UseVisualStyleBackColor = true;
			this.OO0O___O_.0o0.().Value = null;
			this.O._oOOo00__O.().AutoSize = true;
			this.O._oOOo00__O.().BorderStyle = BorderStyle.None;
			this.O._oOOo00__O.().Checked = true;
			this.O._oOOo00__O.().CheckState = CheckState.Checked;
			this.O._oOOo00__O.().Location = new Point(87, 257);
			this.O._oOOo00__O.().Margin = new Padding(2, 1, 2, 1);
			this.O._oOOo00__O.().Name = "chkIncludeSub";
			this.O._oOOo00__O.().Size = new Size(108, 16);
			this.O._oOOo00__O.().TabIndex = 7;
			this.O._oOOo00__O.().Text = "显示子目录内容";
			this.O._oOOo00__O.().UseVisualStyleBackColor = true;
			this.O._oOOo00__O.().Value = true;
			this.oo._0_oOo0oo_.().AutoSize = true;
			this.oo._0_oOo0oo_.().Location = new Point(37, 259);
			this.oo._0_oOo0oo_.().Margin = new Padding(2, 0, 2, 0);
			this.oo._0_oOo0oo_.().Name = "Label4";
			this.oo._0_oOo0oo_.().Size = new Size(35, 12);
			this.oo._0_oOo0oo_.().TabIndex = 30;
			this.oo._0_oOo0oo_.().Text = "选项:";
			this.O0oooo00.00O0.().AutoSize = true;
			this.O0oooo00.00O0.().Location = new Point(25, 190);
			this.O0oooo00.00O0.().Margin = new Padding(2, 0, 2, 0);
			this.O0oooo00.00O0.().Name = "Label6";
			this.O0oooo00.00O0.().Size = new Size(47, 12);
			this.O0oooo00.00O0.().TabIndex = 32;
			this.O0oooo00.00O0.().Text = "排序列:";
			this.O00Oo._00_.().AllowSpinLoop = false;
			this.O00Oo._00_.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.O00Oo._00_.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.O00Oo._00_.().Cursor = Cursors.Arrow;
			this.O00Oo._00_.().DropDownStyle = DropDownStyle.DropDownList;
			this.O00Oo._00_.().GapHeight = 0;
			this.O00Oo._00_.().ImagePadding = new Padding(0);
			this.O00Oo._00_.().ItemsDisplayMember = "";
			this.O00Oo._00_.().ItemsValueMember = "";
			this.O00Oo._00_.().Location = new Point(87, 187);
			this.O00Oo._00_.().Name = "lstSortCols";
			this.O00Oo._00_.().Size = new Size(239, 19);
			this.O00Oo._00_.().TabIndex = 5;
			this.O00Oo._00_.().Tag = null;
			this.o__O0O00.o.().AutoSize = true;
			this.o__O0O00.o.().BorderStyle = BorderStyle.None;
			this.o__O0O00.o.().Enabled = false;
			this.o__O0O00.o.().Location = new Point(278, 311);
			this.o__O0O00.o.().Margin = new Padding(2, 1, 2, 1);
			this.o__O0O00.o.().Name = "chkdesc";
			this.o__O0O00.o.().Size = new Size(48, 16);
			this.o__O0O00.o.().TabIndex = 13;
			this.o__O0O00.o.().Text = "降序";
			this.o__O0O00.o.().UseVisualStyleBackColor = true;
			this.o__O0O00.o.().Value = null;
			this.O_00oO_.0oO0o_.().AutoSize = true;
			this.O_00oO_.0oO0o_.().Location = new Point(25, 222);
			this.O_00oO_.0oO0o_.().Margin = new Padding(2, 0, 2, 0);
			this.O_00oO_.0oO0o_.().Name = "Label8";
			this.O_00oO_.0oO0o_.().Size = new Size(47, 12);
			this.O_00oO_.0oO0o_.().TabIndex = 38;
			this.O_00oO_.0oO0o_.().Text = "树类型:";
			this.Ooo_o0.__.().AllowSpinLoop = false;
			this.Ooo_o0.__.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.Ooo_o0.__.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.Ooo_o0.__.().Cursor = Cursors.Arrow;
			this.Ooo_o0.__.().DropDownStyle = DropDownStyle.DropDownList;
			this.Ooo_o0.__.().GapHeight = 0;
			this.Ooo_o0.__.().ImagePadding = new Padding(0);
			this.Ooo_o0.__.().ItemsDisplayMember = "";
			this.Ooo_o0.__.().ItemsValueMember = "";
			this.Ooo_o0.__.().Location = new Point(87, 219);
			this.Ooo_o0.__.().Name = "lstTreeType";
			this.Ooo_o0.__.().Size = new Size(239, 19);
			this.Ooo_o0.__.().TabIndex = 6;
			this.Ooo_o0.__.().Tag = null;
			this.OO.oOO.().AutoSize = true;
			this.OO.oOO.().BorderStyle = BorderStyle.None;
			this.OO.oOO.().Enabled = false;
			this.OO.oOO.().Location = new Point(254, 285);
			this.OO.oOO.().Margin = new Padding(2, 1, 2, 1);
			this.OO.oOO.().Name = "chkMergeTotal";
			this.OO.oOO.().Size = new Size(72, 16);
			this.OO.oOO.().TabIndex = 10;
			this.OO.oOO.().Text = "合并汇总";
			this.OO.oOO.().UseVisualStyleBackColor = true;
			this.OO.oOO.().Value = null;
			base.AcceptButton = this.o__O0O00.o.();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.O._oOOo00__O.();
			base.ClientSize = new Size(351, 396);
			base.Controls.Add(this.OO.oOO.());
			base.Controls.Add(this.O_00oO_.0oO0o_.());
			base.Controls.Add(this.Ooo_o0.__.());
			base.Controls.Add(this.o__O0O00.o.());
			base.Controls.Add(this.O0oooo00.00O0.());
			base.Controls.Add(this.O00Oo._00_.());
			base.Controls.Add(this.Ooo_o0.__.());
			base.Controls.Add(this.oo._0_oOo0oo_.());
			base.Controls.Add(this.O00_oO_00oo.O.());
			base.Controls.Add(this.O0oooo00.00O0.());
			base.Controls.Add(this.oO.o0o_.());
			base.Controls.Add(this.OO0O___O_.0o0.());
			base.Controls.Add(this.O._oOOo00__O.());
			base.Controls.Add(this.O_0.00O.());
			base.Controls.Add(this.oo.0___oo__oO_.());
			base.Controls.Add(this.oOOO.oOOooo___.());
			base.Controls.Add(this.O_0.00O.());
			base.Controls.Add(this.Ooo_o0.__.());
			base.Controls.Add(this.O00Oo._00_.());
			base.Controls.Add(this.O._oOOo00__O.());
			base.Controls.Add(this.o__O0O00.o.());
			base.Controls.Add(this.o.__OOO.());
			base.Controls.Add(this.o.0o_o0.());
			base.Controls.Add(this.oo._0_oOo0oo_.());
			base.Controls.Add(this.O0oooo00.00O0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(2, 1, 2, 1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oO.....OO";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "设置层级筛选树";
			((ISupportInitialize)this.O._oOOo00__O.()).EndInit();
			((ISupportInitialize)this.o__O0O00.o.()).EndInit();
			((ISupportInitialize)this.oo._0_oOo0oo_.()).EndInit();
			((ISupportInitialize)this.O0oooo00.00O0.()).EndInit();
			((ISupportInitialize)this.O00Oo._00_.()).EndInit();
			((ISupportInitialize)this.oOOO.oOOooo___.()).EndInit();
			((ISupportInitialize)this.O_0.00O.()).EndInit();
			((ISupportInitialize)this.Ooo_o0.__.()).EndInit();
			((ISupportInitialize)this.O0oooo00.00O0.()).EndInit();
			((ISupportInitialize)this.oO.o0o_.()).EndInit();
			((ISupportInitialize)this.OO0O___O_.0o0.()).EndInit();
			((ISupportInitialize)this.O._oOOo00__O.()).EndInit();
			((ISupportInitialize)this.O00Oo._00_.()).EndInit();
			((ISupportInitialize)this.o__O0O00.o.()).EndInit();
			((ISupportInitialize)this.Ooo_o0.__.()).EndInit();
			((ISupportInitialize)this.OO.oOO.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0006D9E0 File Offset: 0x0006BBE0
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0O_00.oo_O_O_.;
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0006D9E8 File Offset: 0x0006BBE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o0O_00.oo_O_O_. = A_0;
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0006D9F1 File Offset: 0x0006BBF1
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.00_.;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0006D9FC File Offset: 0x0006BBFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_00_oO.oO.);
			C1Button c1Button = this.o.00_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.00_. = A_0;
			c1Button = this.o.00_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0006DA3F File Offset: 0x0006BC3F
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_00o_.o.;
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0006DA47 File Offset: 0x0006BC47
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_00o_.o. = A_0;
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0006DA50 File Offset: 0x0006BC50
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.00_.;
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0006DA58 File Offset: 0x0006BC58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.00_. = A_0;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0006DA61 File Offset: 0x0006BC61
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o_000O._.;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0006DA69 File Offset: 0x0006BC69
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.o_000O._. = A_0;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0006DA72 File Offset: 0x0006BC72
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O.0_oOoo.;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0006DA7A File Offset: 0x0006BC7A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.O.0_oOoo. = A_0;
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0006DA83 File Offset: 0x0006BC83
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o_OO.0O0o0ooO_.;
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0006DA8B File Offset: 0x0006BC8B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o_OO.0O0o0ooO_. = A_0;
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0006DA94 File Offset: 0x0006BC94
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o_000O._.;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0006DA9C File Offset: 0x0006BC9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.o00O.oo_o0.);
			RadioButton radioButton = this.o_000O._.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.o_000O._. = A_0;
			radioButton = this.o_000O._.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0006DADF File Offset: 0x0006BCDF
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.Oo0.OO.;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0006DAE8 File Offset: 0x0006BCE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.o00O.oo_o0.);
			RadioButton oo0.OO. = this.Oo0.OO.;
			if (oo0.OO. != null)
			{
				oo0.OO..CheckedChanged -= value;
			}
			this.Oo0.OO. = A_0;
			oo0.OO. = this.Oo0.OO.;
			if (oo0.OO. != null)
			{
				oo0.OO..CheckedChanged += value;
			}
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0006DB2B File Offset: 0x0006BD2B
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0._0_o.;
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0006DB33 File Offset: 0x0006BD33
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0._0_o. = A_0;
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0006DB3C File Offset: 0x0006BD3C
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O__o.0.;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0006DB44 File Offset: 0x0006BD44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.O__o.0. = A_0;
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0006DB4D File Offset: 0x0006BD4D
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.Oo0.OO.;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0006DB55 File Offset: 0x0006BD55
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.Oo0.OO. = A_0;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0006DB5E File Offset: 0x0006BD5E
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0OOo0_0._O.;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0006DB66 File Offset: 0x0006BD66
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0OOo0_0._O. = A_0;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0006DB6F File Offset: 0x0006BD6F
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.OOO000o._00.;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0006DB77 File Offset: 0x0006BD77
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.OOO000o._00. = A_0;
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0006DB80 File Offset: 0x0006BD80
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O_00o_.o.;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0006DB88 File Offset: 0x0006BD88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.OO.o_oOO_.);
			C1CheckBox o_00o_.o. = this.O_00o_.o.;
			if (o_00o_.o. != null)
			{
				o_00o_.o..CheckedChanged -= value;
			}
			this.O_00o_.o. = A_0;
			o_00o_.o. = this.O_00o_.o.;
			if (o_00o_.o. != null)
			{
				o_00o_.o..CheckedChanged += value;
			}
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0006DBCB File Offset: 0x0006BDCB
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o.00_.;
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0006DBD4 File Offset: 0x0006BDD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.OO.o_oOO_.);
			C1CheckBox c1CheckBox = this.o.00_.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged -= value;
			}
			this.o.00_. = A_0;
			c1CheckBox = this.o.00_.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged += value;
			}
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0006DC17 File Offset: 0x0006BE17
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O0._0_o.;
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0006DC20 File Offset: 0x0006BE20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.Oo_o_0.__O0.);
			C1CheckBox o0._0_o. = this.O0._0_o.;
			if (o0._0_o. != null)
			{
				o0._0_o..CheckedChanged -= value;
			}
			this.O0._0_o. = A_0;
			o0._0_o. = this.O0._0_o.;
			if (o0._0_o. != null)
			{
				o0._0_o..CheckedChanged += value;
			}
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0006DC63 File Offset: 0x0006BE63
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.ooo_.__.;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0006DC6B File Offset: 0x0006BE6B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.ooo_.__. = A_0;
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0006DC74 File Offset: 0x0006BE74
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_O0O._O__oO_.;
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0006DC7C File Offset: 0x0006BE7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_O0O._O__oO_. = A_0;
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0006DC85 File Offset: 0x0006BE85
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OOo_0_00o.OOOO.;
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0006DC8D File Offset: 0x0006BE8D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OOo_0_00o.OOOO. = A_0;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0006DC96 File Offset: 0x0006BE96
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O0OOo0_0._O.;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0006DCA0 File Offset: 0x0006BEA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.o0oo_._0_.);
			C1ComboBox o0OOo0_0._O. = this.O0OOo0_0._O.;
			if (o0OOo0_0._O. != null)
			{
				o0OOo0_0._O..SelectedIndexChanged -= value;
			}
			this.O0OOo0_0._O. = A_0;
			o0OOo0_0._O. = this.O0OOo0_0._O.;
			if (o0OOo0_0._O. != null)
			{
				o0OOo0_0._O..SelectedIndexChanged += value;
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0006DCE3 File Offset: 0x0006BEE3
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.OOO_._0_0_.;
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0006DCEB File Offset: 0x0006BEEB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.OOO_._0_0_. = A_0;
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0006DCF4 File Offset: 0x0006BEF4
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_O._o_0.;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0006DCFC File Offset: 0x0006BEFC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_O._o_0. = A_0;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0006DD05 File Offset: 0x0006BF05
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O_O0O._O__oO_.;
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0006DD10 File Offset: 0x0006BF10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O0._O0O.);
			C1ComboBox o_O0O._O__oO_. = this.O_O0O._O__oO_.;
			if (o_O0O._O__oO_. != null)
			{
				o_O0O._O__oO_..SelectedIndexChanged -= value;
			}
			this.O_O0O._O__oO_. = A_0;
			o_O0O._O__oO_. = this.O_O0O._O__oO_.;
			if (o_O0O._O__oO_. != null)
			{
				o_O0O._O__oO_..SelectedIndexChanged += value;
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x0006DD53 File Offset: 0x0006BF53
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O000._oo0O_.;
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0006DD5B File Offset: 0x0006BF5B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O000._oo0O_. = A_0;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x0006DD64 File Offset: 0x0006BF64
		public o\u3000\u3002\u3000\u3002\u3000\u3002(Table A_0, O0_0_0O0___O A_1)
		{
			base.Load += this.Oooo_0.oO0o__.;
			base.FormClosed += this.o__O0O00.o.;
			this.o_OO.0O0o0ooO_. = new Dictionary<string, string>();
			this.O0._O0O.();
			this.o_OO.0O0o0ooO_. = A_0;
			this.o_OO.0O0o0ooO_. = A_1;
			this.Ooo_o0.__.().DataType = typeof(TreeTypeEnum);
			this.Ooo_o0.__.().ItemsDataSource = Enum.GetValues(typeof(TreeTypeEnum));
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0006DDEC File Offset: 0x0006BFEC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oo._0_oOo0oo_.().Items.Add("");
			this.oOOO.oOOooo___.().Items.Add("");
			this.O00Oo._00_.().Items.Add("");
			try
			{
				foreach (DataCol dataCol in this.o_OO.0O0o0ooO_..DataTable.DataCols)
				{
					string left = "";
					if (Operators.CompareString(dataCol.Caption, "", true) > 0 && !this.o_OO.0O0o0ooO_..ContainsKey(dataCol.Caption))
					{
						left = dataCol.Caption;
						this.o_OO.0O0o0ooO_..Add(dataCol.Caption, dataCol.Name);
						this.O00Oo._00_.().Items.Add(dataCol.Caption);
					}
					else
					{
						this.O00Oo._00_.().Items.Add(dataCol.Name);
					}
					if (Operators.CompareString(this.o_OO.0O0o0ooO_..ooo._Ooo., dataCol.Name, true) == 0)
					{
						this.O00Oo._00_.().SelectedIndex = this.O00Oo._00_.().Items.Count - 1;
						this.o__O0O00.o.().Checked = this.o_OO.0O0o0ooO_..O0_.__o00_.;
					}
					if (dataCol.IsString)
					{
						if (Operators.CompareString(left, "", true) > 0)
						{
							this.O0oooo00.00O0.().Items.Add(dataCol.Caption);
							this.oo._0_oOo0oo_.().Items.Add(dataCol.Caption);
						}
						else
						{
							this.O0oooo00.00O0.().Items.Add(dataCol.Name);
							this.oo._0_oOo0oo_.().Items.Add(dataCol.Name);
						}
						if (Operators.CompareString(this.o_OO.0O0o0ooO_..o_O_0._O_., dataCol.Name, true) == 0)
						{
							this.O0oooo00.00O0.().SelectedIndex = this.O0oooo00.00O0.().Items.Count - 1;
						}
						if (Operators.CompareString(this.o_OO.0O0o0ooO_..ooO0o.o_O., dataCol.Name, true) == 0)
						{
							this.oo._0_oOo0oo_.().SelectedIndex = this.oo._0_oOo0oo_.().Items.Count - 1;
						}
					}
					else if (dataCol.IsNumeric)
					{
						if (Operators.CompareString(left, "", true) > 0)
						{
							this.oOOO.oOOooo___.().Items.Add(dataCol.Caption);
						}
						else
						{
							this.oOOO.oOOooo___.().Items.Add(dataCol.Name);
						}
						if (Operators.CompareString(this.o_OO.0O0o0ooO_..Oo_0o_O0._., dataCol.Name, true) == 0)
						{
							this.oOOO.oOOooo___.().SelectedIndex = this.oOOO.oOOooo___.().Items.Count - 1;
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
			if (Operators.CompareString(Conversions.ToString(this.o_OO.0O0o0ooO_..o00oOO00_.ooOo.), "", true) > 0)
			{
				this.O00Oo._00_.().Value = this.o_OO.0O0o0ooO_..o00oOO00_.ooOo.;
			}
			if (Operators.CompareString(this.o_OO.0O0o0ooO_..oo.o0o0O_o_., "", true) > 0)
			{
				this.O_0.00O.().Value = this.o_OO.0O0o0ooO_..oo.o0o0O_o_.;
				this.O_0.00O.().Checked = true;
			}
			this.O._oOOo00__O.().Checked = this.o_OO.0O0o0ooO_..oo_o_.oOO.;
			this.OO0O___O_.0o0.().Checked = this.o_OO.0O0o0ooO_..O.O000.;
			this.OO.oOO.().Checked = this.o_OO.0O0o0ooO_..ooo_Ooo0.__.;
			this.O0oooo00.00O0.().Checked = this.o_OO.0O0o0ooO_..O0oO0_._0.;
			this.Ooo_o0.__.().Value = this.o_OO.0O0o0ooO_..o.0o00ooo_.;
			this.oO.o0o_.().Checked = (this.O0oooo00.00O0.().Checked && this.o_OO.0O0o0ooO_..o.0o00ooo_. >= 0);
			if (this.o_OO.0O0o0ooO_. == O0_0_0O0___O.OOO.__O_oO_.)
			{
				this.Ooo_o0.__.().SelectedItem = TreeTypeEnum.BOM;
				return;
			}
			if (this.o_OO.0O0o0ooO_..OOoOO.OO0.)
			{
				this.Ooo_o0.__.().SelectedItem = TreeTypeEnum.项目;
				return;
			}
			this.Ooo_o0.__.().SelectedItem = TreeTypeEnum.普通;
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x0006E230 File Offset: 0x0006C430
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x0006E244 File Offset: 0x0006C444
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string left = null;
			if (this.O0oooo00.00O0.().SelectedIndex >= 0)
			{
				left = this.O_0.00O.(this.O0oooo00.00O0.().SelectedItem.ToString());
			}
			bool flag;
			if (this.Ooo_o0.__.().Checked)
			{
				if (Operators.CompareString(this.O00Oo._00_.().Text, "", true) > 0 && Operators.CompareString(left, "", true) > 0)
				{
					flag = true;
				}
			}
			else if (Operators.CompareString(this.O_0.00O.().Text, "", true) > 0)
			{
				string[] array = Regex.Split(this.O_0.00O.().Text, "[^\\d]+");
				List<int> list = new List<int>();
				if (array.Length > 0)
				{
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						int item;
						if (int.TryParse(array[i], out item))
						{
							list.Add(item);
						}
					}
					if (list.Count == array.Length)
					{
						flag = true;
					}
					else
					{
						MessageBox.Show("请正确输入用逗号分割的长度，例如:1,3,2");
					}
				}
			}
			if (flag)
			{
				OO_00oOO.LockBaseMainForm();
				this.Oo_o_0.__O0.();
				this.O_0.00O.();
				this.o_OO.0O0o0ooO_..OpenLayersTree();
				base.DialogResult = DialogResult.OK;
				this.o_OO.0O0o0ooO_..NeedSaveSetting = true;
				this.o_OO.0O0o0ooO_..oo0OO0Ooo._.(true);
				OO_00oOO.UnlockBaseMainForm();
			}
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0006E380 File Offset: 0x0006C580
		private void <<EMPTY_NAME>>()
		{
			this.o_OO.0O0o0ooO_..o_O_0._O_. = "";
			this.o_OO.0O0o0ooO_..o00oOO00_.ooOo. = '\0';
			this.o_OO.0O0o0ooO_..oo.o0o0O_o_. = "";
			this.o_OO.0O0o0ooO_..ooO0o.o_O. = "";
			this.o_OO.0O0o0ooO_..Oo_0o_O0._. = "";
			this.o_OO.0O0o0ooO_..oo_o_.oOO. = false;
			this.o_OO.0O0o0ooO_..ooo_Ooo0.__. = true;
			this.o_OO.0O0o0ooO_..O.O000. = false;
			this.o_OO.0O0o0ooO_..O0oO0_._0. = false;
			this.o_OO.0O0o0ooO_..o.0o00ooo_. = -1;
			this.o_OO.0O0o0ooO_..ooo._Ooo. = "";
			this.o_OO.0O0o0ooO_..O0_.__o00_. = false;
			this.o_OO.0O0o0ooO_..OOoOO.OO0. = true;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0006E440 File Offset: 0x0006C640
		private void <<EMPTY_NAME>>()
		{
			this.o_OO.0O0o0ooO_..o_O_0._O_. = this.O_0.00O.(this.O0oooo00.00O0.().SelectedItem.ToString());
			if (this.Ooo_o0.__.().Checked)
			{
				this.o_OO.0O0o0ooO_..o00oOO00_.ooOo. = this.O00Oo._00_.().Text[0];
			}
			else
			{
				this.o_OO.0O0o0ooO_..oo.o0o0O_o_. = this.O_0.00O.().Text;
			}
			if (this.oo._0_oOo0oo_.().SelectedIndex > 0)
			{
				this.o_OO.0O0o0ooO_..ooO0o.o_O. = this.O_0.00O.(this.oo._0_oOo0oo_.().SelectedItem.ToString());
			}
			if (this.oOOO.oOOooo___.().SelectedIndex > 0)
			{
				this.o_OO.0O0o0ooO_..Oo_0o_O0._. = this.O_0.00O.(this.oOOO.oOOooo___.().SelectedItem.ToString());
			}
			if (this.O00Oo._00_.().SelectedIndex > 0)
			{
				this.o_OO.0O0o0ooO_..ooo._Ooo. = this.O_0.00O.(this.O00Oo._00_.().SelectedItem.ToString());
				this.o_OO.0O0o0ooO_..O0_.__o00_. = this.o__O0O00.o.().Checked;
			}
			else
			{
				this.o_OO.0O0o0ooO_..O0_.__o00_. = false;
			}
			this.o_OO.0O0o0ooO_..oo_o_.oOO. = this.O._oOOo00__O.().Checked;
			this.o_OO.0O0o0ooO_..ooo_Ooo0.__. = this.OO.oOO.().Checked;
			this.o_OO.0O0o0ooO_..O.O000. = (this.OO0O___O_.0o0.().Checked && this.o_OO.0O0o0ooO_. == O0_0_0O0___O.oOO___o.0oO.);
			this.o_OO.0O0o0ooO_..O0oO0_._0. = this.O0oooo00.00O0.().Checked;
			if (Conversions.ToInteger(this.Ooo_o0.__.().Value) == 0)
			{
				this.o_OO.0O0o0ooO_..o00oOO00_.ooOo. = O0_0_0O0___O.OOO.__O_oO_.;
				this.o_OO.0O0o0ooO_..OOoOO.OO0. = true;
			}
			else
			{
				this.o_OO.0O0o0ooO_..o00oOO00_.ooOo. = O0_0_0O0___O.oOO___o.0oO.;
				this.o_OO.0O0o0ooO_..OOoOO.OO0. = (Conversions.ToInteger(this.Ooo_o0.__.().Value) == 1);
			}
			if (this.oO.o0o_.().Checked && this.Ooo_o0.__.().Value != null)
			{
				this.o_OO.0O0o0ooO_..o.0o00ooo_. = Conversions.ToInteger(this.Ooo_o0.__.().Value);
				return;
			}
			this.o_OO.0O0o0ooO_..o.0o00ooo_. = -1;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x0006E660 File Offset: 0x0006C860
		private string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (this.o_OO.0O0o0ooO_..ContainsKey(A_0))
			{
				result = this.o_OO.0O0o0ooO_.[A_0];
			}
			else
			{
				result = A_0;
			}
			return result;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x0006E68D File Offset: 0x0006C88D
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oO.o0o_.().Enabled = this.O0oooo00.00O0.().Checked;
			this.Ooo_o0.__.().Enabled = this.oO.o0o_.().Checked;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x0006E6BB File Offset: 0x0006C8BB
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_0.00O.().Enabled = this.O_0.00O.().Checked;
			this.O00Oo._00_.().Enabled = this.Ooo_o0.__.().Checked;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x0006E6EC File Offset: 0x0006C8EC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Conversions.ToInteger(this.Ooo_o0.__.().Value) == 0)
			{
				this.OO0O___O_.0o0.().Enabled = false;
				this.OO0O___O_.0o0.().Checked = false;
				this.OO.oOO.().Enabled = false;
				this.OO.oOO.().Checked = false;
				return;
			}
			this.OO0O___O_.0o0.().Enabled = true;
			this.OO.oOO.().Enabled = true;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0006E754 File Offset: 0x0006C954
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OO.oOO.().Enabled = this.OO0O___O_.0o0.().Checked;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0006E76C File Offset: 0x0006C96C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o__O0O00.o.().Enabled = (this.O00Oo._00_.().SelectedIndex > 0);
		}

		// Token: 0x0400050C RID: 1292
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400050D RID: 1293
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400050E RID: 1294
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400050F RID: 1295
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000510 RID: 1296
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000511 RID: 1297
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000512 RID: 1298
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000513 RID: 1299
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000514 RID: 1300
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04000515 RID: 1301
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04000516 RID: 1302
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000517 RID: 1303
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000518 RID: 1304
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000519 RID: 1305
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400051A RID: 1306
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400051B RID: 1307
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400051C RID: 1308
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400051D RID: 1309
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400051E RID: 1310
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400051F RID: 1311
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000520 RID: 1312
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000521 RID: 1313
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000522 RID: 1314
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04000523 RID: 1315
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000524 RID: 1316
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000525 RID: 1317
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04000526 RID: 1318
		private Table <<EMPTY_NAME>>;

		// Token: 0x04000527 RID: 1319
		private O0_0_0O0___O <<EMPTY_NAME>>;

		// Token: 0x04000528 RID: 1320
		private Dictionary<string, string> <<EMPTY_NAME>>;
	}
}
