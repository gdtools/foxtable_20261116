using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000354 RID: 852
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	internal partial class mf : Form
	{
		// Token: 0x0600345A RID: 13402 RVA: 0x00166714 File Offset: 0x00164914
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o0_0O_O0.O_O0. != null)
				{
					this.o0_0O_O0.O_O0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x00166754 File Offset: 0x00164954
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0_0O_O0.O_O0. = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(mf));
			this.O000__0.0.(new C1Button());
			this.o0O00O0_O.O0_.(new C1FlexGrid());
			this.Oo0Oo__o0_.o0O.(new ContextMenuStrip(this.o0_0O_O0.O_O0.));
			this.o0.O_oO0oOO0.(new ToolStripMenuItem());
			this.OOO_O0__0o0.0.(new ToolStripMenuItem());
			this.O_O_o.o_O_O.(new ToolStripMenuItem());
			this.o0O00O0_O.O0_.(new ToolStripMenuItem());
			this.O0_O__0.00o0oo.(new C1Button());
			this.O.O00O_Ooo0O_.(new C1Button());
			this.OO0.0.(new C1Button());
			this.O.ooooO.(new C1Button());
			this.OO.O0Oo.(new C1TextBox());
			this.Oo.00o.(new Label());
			this.O_O_o.o_O_O.(new C1TextBox());
			this.o.0_OO0Oo.(new Label());
			this.o.o_00o0_O_O.(new C1Button());
			this.o0O00O0_O.O0_.(new C1TextBox());
			this.o0O_.__O_.(new Label());
			this.o0.O_oO0oOO0.(new Label());
			this.O__O_o0.oo.(new Label());
			this.o.0_OO0Oo.(new C1FlexGrid());
			this.O_.oOO0.(new Label());
			this.oO_OO.00_o.(new C1FlexGrid());
			this.OO.oOo___OOOo.(new C1CheckBox());
			this.O0._oo__.(new C1CheckBox());
			this.oO.000_Oo.(new C1CheckBox());
			this.Oo0Oo__o0_.o0O.(new GroupBox());
			this.O.ooooO.(new C1CheckBox());
			this.Oo0Oo__o0_.o0O.(new C1CheckBox());
			this.OOO_O0__0o0.0.(new C1CheckBox());
			this.OO0.0.(new C1CheckBox());
			this.O0oOo_.oOoOOO.(new Label());
			this.O0oOo_.oOoOOO.(new C1TextBox());
			this.Oo0Oo__o0_.o0O.(new C1NumericEdit());
			this.oO_OO.00_o.(new C1TextBox());
			this.O_oOo_0OO.ooO.(new Label());
			this.O0.0OO_.(new Label());
			this.O_0oo00_.o_0O.(new C1CheckBox());
			this.O.o_O0_00.(new C1CheckBox());
			((ISupportInitialize)this.o_0o00_.o0O_o.()).BeginInit();
			((ISupportInitialize)this.oOo_ooo_0O._o.()).BeginInit();
			this.O0_.o0oo0_0_O0.().SuspendLayout();
			((ISupportInitialize)this.Ooo0OOoo._____.()).BeginInit();
			((ISupportInitialize)this.OoOoo.Oooo00.()).BeginInit();
			((ISupportInitialize)this.O_oo.0OO.()).BeginInit();
			((ISupportInitialize)this.O.0O_Oo.()).BeginInit();
			((ISupportInitialize)this.OO00.OO_0o_0o.()).BeginInit();
			((ISupportInitialize)this.oo0OOO.Oo__00.()).BeginInit();
			((ISupportInitialize)this.O_.O0oOOo.()).BeginInit();
			((ISupportInitialize)this.o_0Oo.O00OOoO.()).BeginInit();
			((ISupportInitialize)this.oO._0O.()).BeginInit();
			((ISupportInitialize)this.o_0Oo.O00OOoO.()).BeginInit();
			((ISupportInitialize)this.O.0O_Oo.()).BeginInit();
			((ISupportInitialize)this.o.oO_.()).BeginInit();
			((ISupportInitialize)this.o.00o0oO_oo_.()).BeginInit();
			this.O0_.o0oo0_0_O0.().SuspendLayout();
			((ISupportInitialize)this.O0_00.oo0.()).BeginInit();
			((ISupportInitialize)this.ooo0._0o00oO_.()).BeginInit();
			((ISupportInitialize)this.OO0OO0O0.o0_.()).BeginInit();
			((ISupportInitialize)this.oo.o0_0o.()).BeginInit();
			((ISupportInitialize)this.o.__oOoo0O.()).BeginInit();
			((ISupportInitialize)this.O0_.o0oo0_0_O0.()).BeginInit();
			((ISupportInitialize)this.o00_.O0.()).BeginInit();
			((ISupportInitialize)this.o_0o00_.o0O_o.()).BeginInit();
			((ISupportInitialize)this.oO.00OOOO__o0.()).BeginInit();
			base.SuspendLayout();
			this.o_0o00_.o0O_o.().Location = new Point(19, 607);
			this.o_0o00_.o0O_o.().Margin = new Padding(4, 3, 4, 3);
			this.o_0o00_.o0O_o.().Name = "btnSave";
			this.o_0o00_.o0O_o.().Size = new Size(100, 28);
			this.o_0o00_.o0O_o.().TabIndex = 9;
			this.o_0o00_.o0O_o.().Text = "保存设置";
			this.o_0o00_.o0O_o.().UseVisualStyleBackColor = true;
			this.oOo_ooo_0O._o.().AllowDelete = true;
			this.oOo_ooo_0O._o.().AllowDragging = AllowDraggingEnum.None;
			this.oOo_ooo_0O._o.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.oOo_ooo_0O._o.().ColumnInfo = componentResourceManager.GetString("TotalGrid.ColumnInfo");
			this.oOo_ooo_0O._o.().ContextMenuStrip = this.O0_.o0oo0_0_O0.();
			this.oOo_ooo_0O._o.().ExtendLastCol = true;
			this.oOo_ooo_0O._o.().HighLight = HighLightEnum.WithFocus;
			this.oOo_ooo_0O._o.().Location = new Point(21, 345);
			this.oOo_ooo_0O._o.().Margin = new Padding(4, 3, 4, 3);
			this.oOo_ooo_0O._o.().Name = "TotalGrid";
			this.oOo_ooo_0O._o.().Rows.Count = 1;
			this.oOo_ooo_0O._o.().Rows.DefaultSize = 19;
			this.oOo_ooo_0O._o.().SelectionMode = SelectionModeEnum.Row;
			this.oOo_ooo_0O._o.().ShowThemedHeaders = ShowThemedHeadersEnum.None;
			this.oOo_ooo_0O._o.().Size = new Size(743, 97);
			this.oOo_ooo_0O._o.().TabIndex = 4;
			this.O0_.o0oo0_0_O0.().ImageScalingSize = new Size(20, 20);
			this.O0_.o0oo0_0_O0.().Items.AddRange(new ToolStripItem[]
			{
				this.Oo0.o_O.(),
				this.oO._0O.(),
				this.oOo_ooo_0O._o.(),
				this.O0OO.oOOo.()
			});
			this.O0_.o0oo0_0_O0.().Name = "ContextMenuStrip1";
			this.O0_.o0oo0_0_O0.().Size = new Size(109, 100);
			this.Oo0.o_O.().Name = "InsertMenuItem";
			this.Oo0.o_O.().Size = new Size(108, 24);
			this.Oo0.o_O.().Text = "插入";
			this.oO._0O.().Name = "DeleteMenuItem";
			this.oO._0O.().Size = new Size(108, 24);
			this.oO._0O.().Text = "删除";
			this.oOo_ooo_0O._o.().Name = "MoveUpMenuItem";
			this.oOo_ooo_0O._o.().Size = new Size(108, 24);
			this.oOo_ooo_0O._o.().Text = "上移";
			this.O0OO.oOOo.().Name = "MoveDownMenuItem";
			this.O0OO.oOOo.().Size = new Size(108, 24);
			this.O0OO.oOOo.().Text = "下移";
			this.Ooo0OOoo._____.().CausesValidation = false;
			this.Ooo0OOoo._____.().DialogResult = DialogResult.Cancel;
			this.Ooo0OOoo._____.().Location = new Point(663, 607);
			this.Ooo0OOoo._____.().Margin = new Padding(4, 3, 4, 3);
			this.Ooo0OOoo._____.().Name = "btnCancel";
			this.Ooo0OOoo._____.().Size = new Size(100, 28);
			this.Ooo0OOoo._____.().TabIndex = 12;
			this.Ooo0OOoo._____.().Text = "取消";
			this.Ooo0OOoo._____.().UseVisualStyleBackColor = true;
			this.OoOoo.Oooo00.().Location = new Point(126, 607);
			this.OoOoo.Oooo00.().Margin = new Padding(4, 3, 4, 3);
			this.OoOoo.Oooo00.().Name = "btnList";
			this.OoOoo.Oooo00.().Size = new Size(100, 28);
			this.OoOoo.Oooo00.().TabIndex = 10;
			this.OoOoo.Oooo00.().Text = "设置管理";
			this.OoOoo.Oooo00.().UseVisualStyleBackColor = true;
			this.O_oo.0OO.().Location = new Point(555, 607);
			this.O_oo.0OO.().Margin = new Padding(4, 3, 4, 3);
			this.O_oo.0OO.().Name = "btnOk";
			this.O_oo.0OO.().Size = new Size(100, 28);
			this.O_oo.0OO.().TabIndex = 11;
			this.O_oo.0OO.().Text = "确定";
			this.O_oo.0OO.().UseVisualStyleBackColor = true;
			this.O.0O_Oo.().Location = new Point(235, 607);
			this.O.0O_Oo.().Margin = new Padding(4, 3, 4, 3);
			this.O.0O_Oo.().Name = "btnViewCode";
			this.O.0O_Oo.().Size = new Size(100, 28);
			this.O.0O_Oo.().TabIndex = 8;
			this.O.0O_Oo.().Text = "查看代码";
			this.O.0O_Oo.().UseVisualStyleBackColor = true;
			this.OO00.OO_0o_0o.().Location = new Point(301, 15);
			this.OO00.OO_0o_0o.().Margin = new Padding(4, 3, 4, 3);
			this.OO00.OO_0o_0o.().Name = "txtCaption";
			this.OO00.OO_0o_0o.().Size = new Size(461, 23);
			this.OO00.OO_0o_0o.().TabIndex = 1;
			this.OO00.OO_0o_0o.().Tag = null;
			this.oOo_ooo_0O._o.().AutoSize = true;
			this.oOo_ooo_0O._o.().Location = new Point(247, 20);
			this.oOo_ooo_0O._o.().Margin = new Padding(4, 0, 4, 0);
			this.oOo_ooo_0O._o.().Name = "Label5";
			this.oOo_ooo_0O._o.().Size = new Size(45, 15);
			this.oOo_ooo_0O._o.().TabIndex = 25;
			this.oOo_ooo_0O._o.().Text = "标题:";
			this.oo0OOO.Oo__00.().Location = new Point(75, 15);
			this.oo0OOO.Oo__00.().Margin = new Padding(4, 3, 4, 3);
			this.oo0OOO.Oo__00.().Name = "txtName";
			this.oo0OOO.Oo__00.().Size = new Size(133, 23);
			this.oo0OOO.Oo__00.().TabIndex = 0;
			this.oo0OOO.Oo__00.().Tag = null;
			this.O0OO.oOOo.().AutoSize = true;
			this.O0OO.oOOo.().Location = new Point(19, 20);
			this.O0OO.oOOo.().Margin = new Padding(4, 0, 4, 0);
			this.O0OO.oOOo.().Name = "Label4";
			this.O0OO.oOOo.().Size = new Size(45, 15);
			this.O0OO.oOOo.().TabIndex = 23;
			this.O0OO.oOOo.().Text = "表名:";
			this.O_.O0oOOo.().Location = new Point(715, 569);
			this.O_.O0oOOo.().Margin = new Padding(4, 3, 4, 3);
			this.O_.O0oOOo.().Name = "btnEditExpression";
			this.O_.O0oOOo.().Size = new Size(48, 28);
			this.O_.O0oOOo.().TabIndex = 7;
			this.O_.O0oOOo.().Text = "...";
			this.O_.O0oOOo.().UseVisualStyleBackColor = true;
			this.o_0Oo.O00OOoO.().Location = new Point(73, 572);
			this.o_0Oo.O00OOoO.().Margin = new Padding(4, 3, 4, 3);
			this.o_0Oo.O00OOoO.().Name = "txtFilter";
			this.o_0Oo.O00OOoO.().Size = new Size(638, 23);
			this.o_0Oo.O00OOoO.().TabIndex = 6;
			this.o_0Oo.O00OOoO.().Tag = null;
			this.O.0o_0O.().AutoSize = true;
			this.O.0o_0O.().Location = new Point(19, 576);
			this.O.0o_0O.().Margin = new Padding(4, 0, 4, 0);
			this.O.0o_0O.().Name = "Label3";
			this.O.0o_0O.().Size = new Size(45, 15);
			this.O.0o_0O.().TabIndex = 20;
			this.O.0o_0O.().Text = "条件:";
			this.OOO.__oO0O_0.().AutoSize = true;
			this.OOO.__oO0O_0.().Location = new Point(19, 321);
			this.OOO.__oO0O_0.().Margin = new Padding(4, 0, 4, 0);
			this.OOO.__oO0O_0.().Name = "Label2";
			this.OOO.__oO0O_0.().Size = new Size(90, 15);
			this.OOO.__oO0O_0.().TabIndex = 19;
			this.OOO.__oO0O_0.().Text = "选择统计列:";
			this.oO._0O.().AutoSize = true;
			this.oO._0O.().Location = new Point(19, 60);
			this.oO._0O.().Margin = new Padding(4, 0, 4, 0);
			this.oO._0O.().Name = "Label1";
			this.oO._0O.().Size = new Size(120, 15);
			this.oO._0O.().TabIndex = 18;
			this.oO._0O.().Text = "选择水平分组列:";
			this.oO._0O.().AllowDelete = true;
			this.oO._0O.().AllowDragging = AllowDraggingEnum.None;
			this.oO._0O.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.oO._0O.().ColumnInfo = componentResourceManager.GetString("HGroupGrid.ColumnInfo");
			this.oO._0O.().ContextMenuStrip = this.O0_.o0oo0_0_O0.();
			this.oO._0O.().ExtendLastCol = true;
			this.oO._0O.().HighLight = HighLightEnum.WithFocus;
			this.oO._0O.().Location = new Point(19, 85);
			this.oO._0O.().Margin = new Padding(4, 3, 4, 3);
			this.oO._0O.().Name = "HGroupGrid";
			this.oO._0O.().Rows.Count = 1;
			this.oO._0O.().Rows.DefaultSize = 19;
			this.oO._0O.().SelectionMode = SelectionModeEnum.Row;
			this.oO._0O.().ShowThemedHeaders = ShowThemedHeadersEnum.None;
			this.oO._0O.().Size = new Size(743, 97);
			this.oO._0O.().TabIndex = 2;
			this.oo.O0ooO_.().AutoSize = true;
			this.oo.O0ooO_.().Location = new Point(19, 191);
			this.oo.O0ooO_.().Margin = new Padding(4, 0, 4, 0);
			this.oo.O0ooO_.().Name = "Label10";
			this.oo.O0ooO_.().Size = new Size(120, 15);
			this.oo.O0ooO_.().TabIndex = 34;
			this.oo.O0ooO_.().Text = "选择垂直分组列:";
			this.o_0Oo.O00OOoO.().AllowDelete = true;
			this.o_0Oo.O00OOoO.().AllowDragging = AllowDraggingEnum.None;
			this.o_0Oo.O00OOoO.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.o_0Oo.O00OOoO.().ColumnInfo = componentResourceManager.GetString("VGroupGrid.ColumnInfo");
			this.o_0Oo.O00OOoO.().ContextMenuStrip = this.O0_.o0oo0_0_O0.();
			this.o_0Oo.O00OOoO.().ExtendLastCol = true;
			this.o_0Oo.O00OOoO.().HighLight = HighLightEnum.WithFocus;
			this.o_0Oo.O00OOoO.().Location = new Point(19, 215);
			this.o_0Oo.O00OOoO.().Margin = new Padding(4, 3, 4, 3);
			this.o_0Oo.O00OOoO.().Name = "VGroupGrid";
			this.o_0Oo.O00OOoO.().Rows.Count = 1;
			this.o_0Oo.O00OOoO.().Rows.DefaultSize = 19;
			this.o_0Oo.O00OOoO.().SelectionMode = SelectionModeEnum.Row;
			this.o_0Oo.O00OOoO.().ShowThemedHeaders = ShowThemedHeadersEnum.None;
			this.o_0Oo.O00OOoO.().Size = new Size(743, 97);
			this.o_0Oo.O00OOoO.().TabIndex = 3;
			this.O.0O_Oo.().AutoSize = true;
			this.O.0O_Oo.().BorderStyle = BorderStyle.None;
			this.O.0O_Oo.().Location = new Point(27, 25);
			this.O.0O_Oo.().Margin = new Padding(4, 3, 4, 3);
			this.O.0O_Oo.().Name = "chkOrderByTotal";
			this.O.0O_Oo.().Size = new Size(224, 19);
			this.O.0O_Oo.().TabIndex = 0;
			this.O.0O_Oo.().Text = "同一统计列的数据排列在一起";
			this.O.0O_Oo.().UseVisualStyleBackColor = true;
			this.O.0O_Oo.().Value = null;
			this.o.oO_.().AutoSize = true;
			this.o.oO_.().BorderStyle = BorderStyle.None;
			this.o.oO_.().Location = new Point(27, 52);
			this.o.oO_.().Margin = new Padding(4, 3, 4, 3);
			this.o.oO_.().Name = "chkHorizontalTotal";
			this.o.oO_.().Size = new Size(149, 19);
			this.o.oO_.().TabIndex = 1;
			this.o.oO_.().Text = "水平方向自动汇总";
			this.o.oO_.().UseVisualStyleBackColor = true;
			this.o.oO_.().Value = null;
			this.o.00o0oO_oo_.().AutoSize = true;
			this.o.00o0oO_oo_.().BorderStyle = BorderStyle.None;
			this.o.00o0oO_oo_.().Location = new Point(27, 80);
			this.o.00o0oO_oo_.().Margin = new Padding(4, 3, 4, 3);
			this.o.00o0oO_oo_.().Name = "chkVerticalTotal";
			this.o.00o0oO_oo_.().Size = new Size(149, 19);
			this.o.00o0oO_oo_.().TabIndex = 2;
			this.o.00o0oO_oo_.().Text = "垂直方向自动汇总";
			this.o.00o0oO_oo_.().UseVisualStyleBackColor = true;
			this.o.00o0oO_oo_.().Value = null;
			this.O0_.o0oo0_0_O0.().Controls.Add(this.O0_00.oo0.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.ooo0._0o00oO_.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.OO0OO0O0.o0_.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.oo.o0_0o.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.oo0o_._00O0O_.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.o.__oOoo0O.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.O0_.o0oo0_0_O0.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.o00_.O0.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.ooo.O0OO_.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.o__.oOOoO.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.o_0o00_.o0O_o.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.oO.00OOOO__o0.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.o.oO_.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.O.0O_Oo.());
			this.O0_.o0oo0_0_O0.().Controls.Add(this.o.00o0oO_oo_.());
			this.O0_.o0oo0_0_O0.().Location = new Point(19, 451);
			this.O0_.o0oo0_0_O0.().Margin = new Padding(4, 3, 4, 3);
			this.O0_.o0oo0_0_O0.().Name = "GroupBox1";
			this.O0_.o0oo0_0_O0.().Padding = new Padding(4, 3, 4, 3);
			this.O0_.o0oo0_0_O0.().Size = new Size(741, 112);
			this.O0_.o0oo0_0_O0.().TabIndex = 5;
			this.O0_.o0oo0_0_O0.().TabStop = false;
			this.O0_.o0oo0_0_O0.().Text = "选项";
			this.O0_00.oo0.().AutoSize = true;
			this.O0_00.oo0.().BorderStyle = BorderStyle.None;
			this.O0_00.oo0.().Location = new Point(381, 82);
			this.O0_00.oo0.().Margin = new Padding(4, 3, 4, 3);
			this.O0_00.oo0.().Name = "ChkCircleGrowth";
			this.O0_00.oo0.().Size = new Size(89, 19);
			this.O0_00.oo0.().TabIndex = 47;
			this.O0_00.oo0.().Text = "生成环比";
			this.O0_00.oo0.().UseVisualStyleBackColor = true;
			this.O0_00.oo0.().Value = null;
			this.ooo0._0o00oO_.().AutoSize = true;
			this.ooo0._0o00oO_.().BorderStyle = BorderStyle.None;
			this.ooo0._0o00oO_.().Location = new Point(275, 82);
			this.ooo0._0o00oO_.().Margin = new Padding(4, 3, 4, 3);
			this.ooo0._0o00oO_.().Name = "chkSameGrowth";
			this.ooo0._0o00oO_.().Size = new Size(89, 19);
			this.ooo0._0o00oO_.().TabIndex = 46;
			this.ooo0._0o00oO_.().Text = "生成同比";
			this.ooo0._0o00oO_.().UseVisualStyleBackColor = true;
			this.ooo0._0o00oO_.().Value = null;
			this.OO0OO0O0.o0_.().AutoSize = true;
			this.OO0OO0O0.o0_.().BorderStyle = BorderStyle.None;
			this.OO0OO0O0.o0_.().Location = new Point(573, 52);
			this.OO0OO0O0.o0_.().Margin = new Padding(4, 3, 4, 3);
			this.OO0OO0O0.o0_.().Name = "chkSubtotal";
			this.OO0OO0O0.o0_.().Size = new Size(149, 19);
			this.OO0OO0O0.o0_.().TabIndex = 45;
			this.OO0OO0O0.o0_.().Text = "自动生成汇总模式";
			this.OO0OO0O0.o0_.().UseVisualStyleBackColor = true;
			this.OO0OO0O0.o0_.().Value = null;
			this.oo.o0_0o.().AutoSize = true;
			this.oo.o0_0o.().BorderStyle = BorderStyle.None;
			this.oo.o0_0o.().Location = new Point(573, 82);
			this.oo.o0_0o.().Margin = new Padding(4, 3, 4, 3);
			this.oo.o0_0o.().Name = "chkFromServer";
			this.oo.o0_0o.().Size = new Size(149, 19);
			this.oo.o0_0o.().TabIndex = 44;
			this.oo.o0_0o.().Text = "直接统计后台数据";
			this.oo.o0_0o.().UseVisualStyleBackColor = true;
			this.oo.o0_0o.().Value = null;
			this.oo0o_._00O0O_.().AutoSize = true;
			this.oo0o_._00O0O_.().Location = new Point(573, 27);
			this.oo0o_._00O0O_.().Margin = new Padding(4, 0, 4, 0);
			this.oo0o_._00O0O_.().Name = "Label8";
			this.oo0o_._00O0O_.().Size = new Size(75, 15);
			this.oo0o_._00O0O_.().TabIndex = 43;
			this.oo0o_._00O0O_.().Text = "小数位数:";
			this.o.__oOoo0O.().Location = new Point(432, 50);
			this.o.__oOoo0O.().Margin = new Padding(4, 3, 4, 3);
			this.o.__oOoo0O.().Name = "txtHorizontalProportionCaption";
			this.o.__oOoo0O.().Size = new Size(92, 23);
			this.o.__oOoo0O.().TabIndex = 6;
			this.o.__oOoo0O.().Tag = null;
			this.O0_.o0oo0_0_O0.().DataType = typeof(int);
			this.O0_.o0oo0_0_O0.().ImagePadding = new Padding(0);
			this.O0_.o0oo0_0_O0.().Location = new Point(660, 22);
			this.O0_.o0oo0_0_O0.().Margin = new Padding(4, 3, 4, 3);
			this.O0_.o0oo0_0_O0.().Name = "Decimals";
			this.O0_.o0oo0_0_O0.().Size = new Size(68, 23);
			this.O0_.o0oo0_0_O0.().TabIndex = 42;
			this.O0_.o0oo0_0_O0.().Tag = null;
			this.O0_.o0oo0_0_O0.().Value = 4;
			this.O0_.o0oo0_0_O0.().VisibleButtons = DropDownControlButtonFlags.UpDown;
			this.o00_.O0.().Location = new Point(432, 22);
			this.o00_.O0.().Margin = new Padding(4, 3, 4, 3);
			this.o00_.O0.().Name = "txtVerticalProportionCaption";
			this.o00_.O0.().Size = new Size(92, 23);
			this.o00_.O0.().TabIndex = 4;
			this.o00_.O0.().Tag = null;
			this.ooo.O0OO_.().AutoSize = true;
			this.ooo.O0OO_.().Location = new Point(379, 55);
			this.ooo.O0OO_.().Margin = new Padding(4, 0, 4, 0);
			this.ooo.O0OO_.().Name = "Label7";
			this.ooo.O0OO_.().Size = new Size(45, 15);
			this.ooo.O0OO_.().TabIndex = 41;
			this.ooo.O0OO_.().Text = "标题:";
			this.o__.oOOoO.().AutoSize = true;
			this.o__.oOOoO.().Location = new Point(379, 27);
			this.o__.oOOoO.().Margin = new Padding(4, 0, 4, 0);
			this.o__.oOOoO.().Name = "Label6";
			this.o__.oOOoO.().Size = new Size(45, 15);
			this.o__.oOOoO.().TabIndex = 40;
			this.o__.oOOoO.().Text = "标题:";
			this.o_0o00_.o0O_o.().AutoSize = true;
			this.o_0o00_.o0O_o.().BorderStyle = BorderStyle.None;
			this.o_0o00_.o0O_o.().Location = new Point(275, 52);
			this.o_0o00_.o0O_o.().Margin = new Padding(4, 3, 4, 3);
			this.o_0o00_.o0O_o.().Name = "chkHorizontalProportion";
			this.o_0o00_.o0O_o.().Size = new Size(89, 19);
			this.o_0o00_.o0O_o.().TabIndex = 5;
			this.o_0o00_.o0O_o.().Text = "水平份额";
			this.o_0o00_.o0O_o.().UseVisualStyleBackColor = true;
			this.o_0o00_.o0O_o.().Value = null;
			this.oO.00OOOO__o0.().AutoSize = true;
			this.oO.00OOOO__o0.().BorderStyle = BorderStyle.None;
			this.oO.00OOOO__o0.().Location = new Point(275, 23);
			this.oO.00OOOO__o0.().Margin = new Padding(4, 3, 4, 3);
			this.oO.00OOOO__o0.().Name = "chkVerticalProportion";
			this.oO.00OOOO__o0.().Size = new Size(89, 19);
			this.oO.00OOOO__o0.().TabIndex = 3;
			this.oO.00OOOO__o0.().Text = "垂直占比";
			this.oO.00OOOO__o0.().UseVisualStyleBackColor = true;
			this.oO.00OOOO__o0.().Value = null;
			base.AutoScaleDimensions = new SizeF(8f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(786, 647);
			base.Controls.Add(this.O0_.o0oo0_0_O0.());
			base.Controls.Add(this.oo.O0ooO_.());
			base.Controls.Add(this.o_0Oo.O00OOoO.());
			base.Controls.Add(this.oOo_ooo_0O._o.());
			base.Controls.Add(this.OO00.OO_0o_0o.());
			base.Controls.Add(this.o_0o00_.o0O_o.());
			base.Controls.Add(this.Ooo0OOoo._____.());
			base.Controls.Add(this.O_oo.0OO.());
			base.Controls.Add(this.OoOoo.Oooo00.());
			base.Controls.Add(this.oOo_ooo_0O._o.());
			base.Controls.Add(this.oo0OOO.Oo__00.());
			base.Controls.Add(this.O.0O_Oo.());
			base.Controls.Add(this.O0OO.oOOo.());
			base.Controls.Add(this.oO._0O.());
			base.Controls.Add(this.O_.O0oOOo.());
			base.Controls.Add(this.OOO.__oO0O_0.());
			base.Controls.Add(this.oO._0O.());
			base.Controls.Add(this.o_0Oo.O00OOoO.());
			base.Controls.Add(this.O.0o_0O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(4, 3, 4, 3);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O1.o.I11.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "交叉统计";
			((ISupportInitialize)this.o_0o00_.o0O_o.()).EndInit();
			((ISupportInitialize)this.oOo_ooo_0O._o.()).EndInit();
			this.O0_.o0oo0_0_O0.().ResumeLayout(false);
			((ISupportInitialize)this.Ooo0OOoo._____.()).EndInit();
			((ISupportInitialize)this.OoOoo.Oooo00.()).EndInit();
			((ISupportInitialize)this.O_oo.0OO.()).EndInit();
			((ISupportInitialize)this.O.0O_Oo.()).EndInit();
			((ISupportInitialize)this.OO00.OO_0o_0o.()).EndInit();
			((ISupportInitialize)this.oo0OOO.Oo__00.()).EndInit();
			((ISupportInitialize)this.O_.O0oOOo.()).EndInit();
			((ISupportInitialize)this.o_0Oo.O00OOoO.()).EndInit();
			((ISupportInitialize)this.oO._0O.()).EndInit();
			((ISupportInitialize)this.o_0Oo.O00OOoO.()).EndInit();
			((ISupportInitialize)this.O.0O_Oo.()).EndInit();
			((ISupportInitialize)this.o.oO_.()).EndInit();
			((ISupportInitialize)this.o.00o0oO_oo_.()).EndInit();
			this.O0_.o0oo0_0_O0.().ResumeLayout(false);
			this.O0_.o0oo0_0_O0.().PerformLayout();
			((ISupportInitialize)this.O0_00.oo0.()).EndInit();
			((ISupportInitialize)this.ooo0._0o00oO_.()).EndInit();
			((ISupportInitialize)this.OO0OO0O0.o0_.()).EndInit();
			((ISupportInitialize)this.oo.o0_0o.()).EndInit();
			((ISupportInitialize)this.o.__oOoo0O.()).EndInit();
			((ISupportInitialize)this.O0_.o0oo0_0_O0.()).EndInit();
			((ISupportInitialize)this.o00_.O0.()).EndInit();
			((ISupportInitialize)this.o_0o00_.o0O_o.()).EndInit();
			((ISupportInitialize)this.oO.00OOOO__o0.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x001682AE File Offset: 0x001664AE
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.___0_00_oo.;
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x001682B8 File Offset: 0x001664B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_O.OOoo.);
			C1Button c1Button = this.o.___0_00_oo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.___0_00_oo. = A_0;
			c1Button = this.o.___0_00_oo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x001682FB File Offset: 0x001664FB
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O_0O_o_0oO0._O.;
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x00168304 File Offset: 0x00166504
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.o.o00_O00.);
			RowColEventHandler value2 = new RowColEventHandler(this.o.___0_00_oo.);
			C1FlexGrid o_0O_o_0oO0._O. = this.O_0O_o_0oO0._O.;
			if (o_0O_o_0oO0._O. != null)
			{
				o_0O_o_0oO0._O..AfterEdit -= value;
				o_0O_o_0oO0._O..BeforeEdit -= value2;
			}
			this.O_0O_o_0oO0._O. = A_0;
			o_0O_o_0oO0._O. = this.O_0O_o_0oO0._O.;
			if (o_0O_o_0oO0._O. != null)
			{
				o_0O_o_0oO0._O..AfterEdit += value;
				o_0O_o_0oO0._O..BeforeEdit += value2;
			}
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x00168362 File Offset: 0x00166562
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.o00_O00.;
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x0016836A File Offset: 0x0016656A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o.o00_O00. = A_0;
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x00168373 File Offset: 0x00166573
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_0Oo.o.;
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x0016837C File Offset: 0x0016657C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O__.O_Oo0o.);
			C1Button o_0Oo.o. = this.O_0Oo.o.;
			if (o_0Oo.o. != null)
			{
				o_0Oo.o..Click -= value;
			}
			this.O_0Oo.o. = A_0;
			o_0Oo.o. = this.O_0Oo.o.;
			if (o_0Oo.o. != null)
			{
				o_0Oo.o..Click += value;
			}
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x001683BF File Offset: 0x001665BF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OoO_Oo0oooO.oO.;
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x001683C8 File Offset: 0x001665C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0.o00_0.);
			C1Button ooO_Oo0oooO.oO. = this.OoO_Oo0oooO.oO.;
			if (ooO_Oo0oooO.oO. != null)
			{
				ooO_Oo0oooO.oO..Click -= value;
			}
			this.OoO_Oo0oooO.oO. = A_0;
			ooO_Oo0oooO.oO. = this.OoO_Oo0oooO.oO.;
			if (ooO_Oo0oooO.oO. != null)
			{
				ooO_Oo0oooO.oO..Click += value;
			}
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x0016840B File Offset: 0x0016660B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO_o__0.oo.;
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x00168414 File Offset: 0x00166614
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0oOO.0.);
			C1Button c1Button = this.oO_o__0.oo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO_o__0.oo. = A_0;
			c1Button = this.oO_o__0.oo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x00168457 File Offset: 0x00166657
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_0O_o_0oO0._O.;
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x0016845F File Offset: 0x0016665F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O_0O_o_0oO0._O. = A_0;
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x00168468 File Offset: 0x00166668
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_0O_o_0oO0._O.;
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x00168470 File Offset: 0x00166670
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_0O_o_0oO0._O. = A_0;
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x00168479 File Offset: 0x00166679
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oOO00.O__0o.;
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00168484 File Offset: 0x00166684
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			CancelEventHandler value = new CancelEventHandler(this.o.___0_00_oo.);
			C1TextBox c1TextBox = this.oOO00.O__0o.;
			if (c1TextBox != null)
			{
				c1TextBox.Validating -= value;
			}
			this.oOO00.O__0o. = A_0;
			c1TextBox = this.oOO00.O__0o.;
			if (c1TextBox != null)
			{
				c1TextBox.Validating += value;
			}
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x001684C7 File Offset: 0x001666C7
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.O_O0.;
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x001684CF File Offset: 0x001666CF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.O_O0. = A_0;
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x001684D8 File Offset: 0x001666D8
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OoO.OoOo__O_O.;
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x001684E0 File Offset: 0x001666E0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O__0oo._0_.);
			C1Button ooO.OoOo__O_O. = this.OoO.OoOo__O_O.;
			if (ooO.OoOo__O_O. != null)
			{
				ooO.OoOo__O_O..Click -= value;
			}
			this.OoO.OoOo__O_O. = A_0;
			ooO.OoOo__O_O. = this.OoO.OoOo__O_O.;
			if (ooO.OoOo__O_O. != null)
			{
				ooO.OoOo__O_O..Click += value;
			}
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x00168523 File Offset: 0x00166723
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oOO.oOOoo_o_Oo.;
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x0016852B File Offset: 0x0016672B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.oOO.oOOoo_o_Oo. = A_0;
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x00168534 File Offset: 0x00166734
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0o0._.;
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x0016853C File Offset: 0x0016673C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0o0._. = A_0;
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x00168545 File Offset: 0x00166745
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_Ooo0.oo.;
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x0016854D File Offset: 0x0016674D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_Ooo0.oo. = A_0;
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x00168556 File Offset: 0x00166756
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Ooo_O_0.ooO.;
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x0016855E File Offset: 0x0016675E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Ooo_O_0.ooO. = A_0;
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x00168567 File Offset: 0x00166767
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O.O_O0.;
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00168570 File Offset: 0x00166770
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.o.__oOoo0O.);
			RowColEventHandler value2 = new RowColEventHandler(this.O_.ooo.);
			C1FlexGrid o.O_O0. = this.O.O_O0.;
			if (o.O_O0. != null)
			{
				o.O_O0..AfterEdit -= value;
				o.O_O0..BeforeEdit -= value2;
			}
			this.O.O_O0. = A_0;
			o.O_O0. = this.O.O_O0.;
			if (o.O_O0. != null)
			{
				o.O_O0..AfterEdit += value;
				o.O_O0..BeforeEdit += value2;
			}
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x001685CE File Offset: 0x001667CE
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OO0oo0o0ooO._O.;
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x001685D6 File Offset: 0x001667D6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OO0oo0o0ooO._O. = A_0;
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x001685DF File Offset: 0x001667DF
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O__o._O0o0o.;
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x001685E8 File Offset: 0x001667E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.o.__oOoo0O.);
			RowColEventHandler value2 = new RowColEventHandler(this.O_.ooo.);
			C1FlexGrid o__o._O0o0o. = this.O__o._O0o0o.;
			if (o__o._O0o0o. != null)
			{
				o__o._O0o0o..AfterEdit -= value;
				o__o._O0o0o..BeforeEdit -= value2;
			}
			this.O__o._O0o0o. = A_0;
			o__o._O0o0o. = this.O__o._O0o0o.;
			if (o__o._O0o0o. != null)
			{
				o__o._O0o0o..AfterEdit += value;
				o__o._O0o0o..BeforeEdit += value2;
			}
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00168646 File Offset: 0x00166846
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.O00_0oo._.;
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x0016864E File Offset: 0x0016684E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.O00_0oo._. = A_0;
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00168658 File Offset: 0x00166858
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.oOo0o._0_O.;
		}

		// Token: 0x06003483 RID: 13443 RVA: 0x0016866C File Offset: 0x0016686C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O00._.);
				ToolStripMenuItem toolStripMenuItem = this.oOo0o._0_O.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						toolStripMenuItem.Click += value;
						num = 3;
						continue;
					case 1:
						if (toolStripMenuItem != null)
						{
							num = 0;
							continue;
						}
						return;
					case 2:
						toolStripMenuItem.Click -= value;
						num = 4;
						continue;
					case 3:
						return;
					case 4:
						goto IL_62;
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
					this.oOo0o._0_O. = A_0;
					toolStripMenuItem = this.oOo0o._0_O.;
					num = 1;
				}
			}
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x00168718 File Offset: 0x00166918
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.Ooo.0.;
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x0016872C File Offset: 0x0016692C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.oo_._.);
				ToolStripMenuItem ooo.0. = this.Ooo.0.;
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_62;
					case 1:
						if (ooo.0. != null)
						{
							num = 4;
							continue;
						}
						return;
					case 2:
						ooo.0..Click -= value;
						num = 0;
						continue;
					case 3:
						if (ooo.0. != null)
						{
							if (true)
							{
							}
							num = 2;
							continue;
						}
						goto IL_62;
					case 4:
						ooo.0..Click += value;
						num = 5;
						continue;
					case 5:
						return;
					}
					break;
					IL_62:
					this.Ooo.0. = A_0;
					ooo.0. = this.Ooo.0.;
					num = 1;
				}
			}
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x001687D8 File Offset: 0x001669D8
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.oOO.oOOoo_o_Oo.;
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x001687EC File Offset: 0x001669EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.OoO__00._OoO0_.);
				ToolStripMenuItem toolStripMenuItem = this.oOO.oOOoo_o_Oo.;
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						toolStripMenuItem.Click += value;
						num = 3;
						continue;
					case 1:
						if (toolStripMenuItem != null)
						{
							num = 0;
							continue;
						}
						return;
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
						if (toolStripMenuItem != null)
						{
							num = 2;
							continue;
						}
						goto IL_5A;
					case 5:
						goto IL_5A;
					}
					break;
					IL_5A:
					this.oOO.oOOoo_o_Oo. = A_0;
					toolStripMenuItem = this.oOO.oOOoo_o_Oo.;
					num = 1;
				}
			}
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00168894 File Offset: 0x00166A94
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O_Ooo0.oo.;
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x001688A8 File Offset: 0x00166AA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o.__oOoo0O.);
				ToolStripMenuItem o_Ooo0.oo. = this.O_Ooo0.oo.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (o_Ooo0.oo. != null)
						{
							num = 3;
							continue;
						}
						return;
					case 1:
						if (true)
						{
						}
						o_Ooo0.oo..Click -= value;
						num = 4;
						continue;
					case 2:
						return;
					case 3:
						o_Ooo0.oo..Click += value;
						num = 2;
						continue;
					case 4:
						goto IL_5A;
					case 5:
						if (o_Ooo0.oo. != null)
						{
							num = 1;
							continue;
						}
						goto IL_5A;
					}
					break;
					IL_5A:
					this.O_Ooo0.oo. = A_0;
					o_Ooo0.oo. = this.O_Ooo0.oo.;
					num = 0;
				}
			}
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x0016894E File Offset: 0x00166B4E
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O00_0oo._.;
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00168956 File Offset: 0x00166B56
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O00_0oo._. = A_0;
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x0016895F File Offset: 0x00166B5F
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.Oo.O___.;
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x00168967 File Offset: 0x00166B67
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.Oo.O___. = A_0;
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x00168970 File Offset: 0x00166B70
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o0oO_o_.o.;
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00168978 File Offset: 0x00166B78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o0oO_o_.o. = A_0;
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x00168981 File Offset: 0x00166B81
		[CompilerGenerated]
		internal virtual GroupBox <<EMPTY_NAME>>()
		{
			return this.oOo0o._0_O.;
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00168989 File Offset: 0x00166B89
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(GroupBox A_0)
		{
			this.oOo0o._0_O. = A_0;
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x00168992 File Offset: 0x00166B92
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.oO0__OOO_.0Oo.;
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x0016899A File Offset: 0x00166B9A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.oO0__OOO_.0Oo. = A_0;
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x001689A3 File Offset: 0x00166BA3
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O0_0OO._O.;
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x001689AB File Offset: 0x00166BAB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O0_0OO._O. = A_0;
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x001689B4 File Offset: 0x00166BB4
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo.0_O.;
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x001689BC File Offset: 0x00166BBC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo.0_O. = A_0;
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x001689C5 File Offset: 0x00166BC5
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo0_oo0_oo_._.;
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x001689CD File Offset: 0x00166BCD
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo0_oo0_oo_._. = A_0;
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x001689D6 File Offset: 0x00166BD6
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oO0.0oo_o0_O_.;
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x001689DE File Offset: 0x00166BDE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.oO0.0oo_o0_O_. = A_0;
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x001689E7 File Offset: 0x00166BE7
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.Ooo__o._o_o0_.;
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x001689EF File Offset: 0x00166BEF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.Ooo__o._o_o0_. = A_0;
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x001689F8 File Offset: 0x00166BF8
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo0.o0.;
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x00168A00 File Offset: 0x00166C00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo0.o0. = A_0;
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x00168A09 File Offset: 0x00166C09
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.oOo0o._0_O.;
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x00168A11 File Offset: 0x00166C11
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			this.oOo0o._0_O. = A_0;
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00168A1A File Offset: 0x00166C1A
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O.Oo0o0O0OO.;
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00168A24 File Offset: 0x00166C24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.O_.0oOoOO0_ooo.);
			C1CheckBox o.Oo0o0O0OO. = this.O.Oo0o0O0OO.;
			if (o.Oo0o0O0OO. != null)
			{
				o.Oo0o0O0OO..CheckedChanged -= value;
			}
			this.O.Oo0o0O0OO. = A_0;
			o.Oo0o0O0OO. = this.O.Oo0o0O0OO.;
			if (o.Oo0o0O0OO. != null)
			{
				o.Oo0o0O0OO..CheckedChanged += value;
			}
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x00168A67 File Offset: 0x00166C67
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o00.00.;
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x00168A6F File Offset: 0x00166C6F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o00.00. = A_0;
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x00168A78 File Offset: 0x00166C78
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O0_o_0._0__.;
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x00168A80 File Offset: 0x00166C80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O0_o_0._0__. = A_0;
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00168A89 File Offset: 0x00166C89
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O0_OO___._o.;
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x00168A91 File Offset: 0x00166C91
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O0_OO___._o. = A_0;
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x00168A9C File Offset: 0x00166C9C
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
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
				C1FlexGrid c1FlexGrid = (C1FlexGrid)A_0;
				IL_10:
				num2 = 3;
				if (Operators.CompareString(c1FlexGrid.Cols[A_1.Col].Name, "Name", true) != 0)
				{
					goto IL_186;
				}
				IL_38:
				num2 = 4;
				if (c1FlexGrid.GetData(A_1.Row, "Name") == null)
				{
					goto IL_266;
				}
				IL_50:
				num2 = 6;
				string text = c1FlexGrid.GetData(A_1.Row, "Name").ToString();
				IL_6A:
				num2 = 7;
				if (Operators.CompareString(text, "", true) == 0)
				{
					goto IL_266;
				}
				IL_7E:
				num2 = 9;
				if (this.o0_0O_O0.O_O0..DataTable.DataCols[text].IsDate)
				{
					goto IL_F4;
				}
				IL_9F:
				num2 = 10;
				c1FlexGrid[A_1.Row, "DateGroup"] = null;
				IL_B4:
				num2 = 11;
				if (c1FlexGrid != this.o_0Oo.O00OOoO.())
				{
					goto IL_DA;
				}
				IL_C0:
				num2 = 12;
				c1FlexGrid[A_1.Row, "Pattern"] = null;
				goto IL_186;
				IL_DA:
				num2 = 14;
				c1FlexGrid[A_1.Row, "NewName"] = null;
				goto IL_186;
				IL_F4:
				num2 = 16;
				if (c1FlexGrid[A_1.Row, "DateGroup"] != null)
				{
					goto IL_186;
				}
				IL_10A:
				num2 = 17;
				c1FlexGrid[A_1.Row, "DateGroup"] = DateGroupEnum.Month;
				IL_124:
				num2 = 18;
				if (c1FlexGrid != this.oO._0O.())
				{
					goto IL_157;
				}
				IL_130:
				num2 = 19;
				c1FlexGrid[A_1.Row, "NewName"] = c1FlexGrid.GetDataDisplay(A_1.Row, "DateGroup");
				goto IL_186;
				IL_157:
				num2 = 21;
				c1FlexGrid[A_1.Row, "Pattern"] = "{0}" + c1FlexGrid.GetDataDisplay(A_1.Row, "DateGroup");
				IL_186:
				num2 = 22;
				if (Operators.CompareString(c1FlexGrid.Cols[A_1.Col].Name, "DateGroup", true) != 0)
				{
					goto IL_266;
				}
				IL_1AF:
				num2 = 23;
				if (Conversions.ToInteger(c1FlexGrid[A_1.Row, "DateGroup"]) == 0)
				{
					goto IL_22E;
				}
				IL_1CA:
				num2 = 24;
				if (c1FlexGrid != this.oO._0O.())
				{
					goto IL_1FD;
				}
				IL_1D6:
				num2 = 25;
				c1FlexGrid[A_1.Row, "NewName"] = c1FlexGrid.GetDataDisplay(A_1.Row, "DateGroup");
				goto IL_266;
				IL_1FD:
				num2 = 27;
				c1FlexGrid[A_1.Row, "Pattern"] = "{0}" + c1FlexGrid.GetDataDisplay(A_1.Row, "DateGroup");
				goto IL_266;
				IL_22E:
				num2 = 29;
				if (c1FlexGrid != this.oO._0O.())
				{
					goto IL_251;
				}
				IL_23A:
				num2 = 30;
				c1FlexGrid[A_1.Row, "NewName"] = null;
				goto IL_266;
				IL_251:
				num2 = 32;
				c1FlexGrid[A_1.Row, "Pattern"] = null;
				IL_266:
				goto IL_33C;
				IL_26B:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2FD:
				goto IL_331;
				IL_2FF:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_30F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2FF;
			}
			IL_331:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_33C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x00168E0C File Offset: 0x0016700C
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Row > 0)
			{
				C1FlexGrid c1FlexGrid = (C1FlexGrid)A_0;
				if (Operators.CompareString(c1FlexGrid.Cols[A_1.Col].Name, "DateGroup", true) == 0)
				{
					if (c1FlexGrid.GetData(A_1.Row, "Name") == null)
					{
						A_1.Cancel = true;
						return;
					}
					string text = c1FlexGrid.GetData(A_1.Row, "Name").ToString();
					if (Operators.CompareString(text, "", true) == 0 || !this.o0_0O_O0.O_O0..DataTable.DataCols[text].IsDate)
					{
						A_1.Cancel = true;
					}
				}
			}
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00168EB4 File Offset: 0x001670B4
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (Operators.CompareString(this.oOo_ooo_0O._o.().Cols[A_1.Col].Name, "Name", true) == 0 && this.oOo_ooo_0O._o.().GetData(A_1.Row, "Name") != null)
			{
				string text = this.oOo_ooo_0O._o.().GetData(A_1.Row, "Name").ToString();
				if (Operators.CompareString(text, "", true) != 0)
				{
					if (!this.o0_0O_O0.O_O0..DataTable.DataCols[text].IsNumeric)
					{
						this.oOo_ooo_0O._o.()[A_1.Row, "Aggregate"] = AggregateEnum.Count;
						return;
					}
					if (this.oOo_ooo_0O._o.()[A_1.Row, "Aggregate"] == null)
					{
						this.oOo_ooo_0O._o.()[A_1.Row, "Aggregate"] = AggregateEnum.Sum;
					}
				}
			}
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x00168FA0 File Offset: 0x001671A0
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Row > 0 && Operators.CompareString(this.oOo_ooo_0O._o.().Cols[A_1.Col].Name, "Aggregate", true) == 0)
			{
				if (this.oOo_ooo_0O._o.().GetData(A_1.Row, "Name") == null)
				{
					A_1.Cancel = true;
					return;
				}
				string text = this.oOo_ooo_0O._o.().GetData(A_1.Row, "Name").ToString();
				if (Operators.CompareString(text, "", true) == 0 || !this.o0_0O_O0.O_O0..DataTable.DataCols[text].IsNumeric)
				{
					A_1.Cancel = true;
				}
			}
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x00169050 File Offset: 0x00167250
		private CrossTableBuilder <<EMPTY_NAME>>()
		{
			int num;
			CrossTableBuilder result;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string text = Oo00.OoO_.__o.(this.o0_0O_O0.O_O0., this.oo.o0_0o.().Checked);
				IL_21:
				num2 = 3;
				if (Operators.CompareString(this.oo0OOO.Oo__00.().Text.Trim(), "", true) != 0)
				{
					goto IL_5E;
				}
				IL_40:
				num2 = 4;
				MessageBox.Show("请输入表名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_55:
				num2 = 5;
				result = null;
				goto IL_6C2;
				IL_5E:
				num2 = 6;
				if (Operators.CompareString(this.o_0Oo.O00OOoO.().Text.Trim(), "", true) <= 0)
				{
					goto IL_C6;
				}
				IL_7E:
				num2 = 7;
				if (Operators.CompareString(text, "", true) != 0)
				{
					goto IL_A5;
				}
				IL_8F:
				num2 = 8;
				text = this.o_0Oo.O00OOoO.().Text.Trim();
				goto IL_C6;
				IL_A5:
				num2 = 10;
				text = text + " And " + this.o_0Oo.O00OOoO.().Text.Trim();
				IL_C6:
				num2 = 11;
				CrossTableBuilder crossTableBuilder = new CrossTableBuilder(this.oo0OOO.Oo__00.().Text, this.o0_0O_O0.O_O0..DataTable, text);
				IL_E8:
				num2 = 12;
				crossTableBuilder.Caption = this.OO00.OO_0o_0o.().Text;
				IL_FD:
				num2 = 13;
				int @fixed = this.oO._0O.().Rows.Fixed;
				int num3 = this.oO._0O.().Rows.Count - 2;
				for (int i = @fixed; i <= num3; i++)
				{
					IL_12B:
					num2 = 14;
					if (this.oO._0O.().GetData(i, "Name") != null)
					{
						IL_145:
						num2 = 15;
						GroupOn groupOn = new GroupOn();
						IL_14F:
						num2 = 16;
						groupOn.Name = this.oO._0O.()[i, "Name"].ToString();
						IL_170:
						num2 = 17;
						if (this.oO._0O.()[i, "DateGroup"] != null)
						{
							IL_187:
							num2 = 18;
							groupOn.DateGroup = (DateGroupEnum)Conversions.ToInteger(this.oO._0O.()[i, "DateGroup"]);
						}
						IL_1A8:
						num2 = 19;
						if (this.oO._0O.()[i, "NewName"] != null)
						{
							IL_1BF:
							num2 = 20;
							groupOn.NewName = this.oO._0O.()[i, "NewName"].ToString();
						}
						IL_1E0:
						num2 = 21;
						if (this.oO._0O.()[i, "NewCaption"] != null)
						{
							IL_1F7:
							num2 = 22;
							groupOn.NewCaption = this.oO._0O.()[i, "NewCaption"].ToString();
						}
						IL_218:
						num2 = 23;
						crossTableBuilder.HGroups.Add(groupOn);
					}
					IL_229:
					num2 = 24;
				}
				IL_23B:
				num2 = 25;
				int fixed2 = this.o_0Oo.O00OOoO.().Rows.Fixed;
				int num4 = this.o_0Oo.O00OOoO.().Rows.Count - 2;
				for (int j = fixed2; j <= num4; j++)
				{
					IL_269:
					num2 = 26;
					if (this.o_0Oo.O00OOoO.().GetData(j, "Name") != null)
					{
						IL_283:
						num2 = 27;
						CrossGroupOn crossGroupOn = new CrossGroupOn();
						IL_28D:
						num2 = 28;
						crossGroupOn.Name = this.o_0Oo.O00OOoO.()[j, "Name"].ToString();
						IL_2AE:
						num2 = 29;
						if (this.o_0Oo.O00OOoO.()[j, "DateGroup"] != null)
						{
							IL_2C5:
							num2 = 30;
							crossGroupOn.DateGroup = (DateGroupEnum)Conversions.ToInteger(this.o_0Oo.O00OOoO.()[j, "DateGroup"]);
						}
						IL_2E6:
						num2 = 31;
						if (this.o_0Oo.O00OOoO.()[j, "Pattern"] != null)
						{
							IL_2FD:
							num2 = 32;
							crossGroupOn.Pattern = this.o_0Oo.O00OOoO.()[j, "Pattern"].ToString();
						}
						IL_31E:
						num2 = 33;
						crossTableBuilder.VGroups.Add(crossGroupOn);
					}
					IL_32F:
					num2 = 34;
				}
				IL_341:
				num2 = 35;
				int fixed3 = this.oOo_ooo_0O._o.().Rows.Fixed;
				int num5 = this.oOo_ooo_0O._o.().Rows.Count - 2;
				for (int k = fixed3; k <= num5; k++)
				{
					IL_36F:
					num2 = 36;
					if (this.oOo_ooo_0O._o.().GetData(k, "Name") != null)
					{
						IL_389:
						num2 = 37;
						CrossTotalOn crossTotalOn = new CrossTotalOn(false);
						IL_394:
						num2 = 38;
						crossTotalOn.Name = this.oOo_ooo_0O._o.()[k, "Name"].ToString();
						IL_3B5:
						num2 = 39;
						if (this.oOo_ooo_0O._o.()[k, "Aggregate"] != null)
						{
							IL_3CC:
							num2 = 40;
							crossTotalOn.Aggregate = (AggregateEnum)Conversions.ToInteger(this.oOo_ooo_0O._o.()[k, "Aggregate"]);
						}
						IL_3ED:
						num2 = 41;
						if (this.oOo_ooo_0O._o.()[k, "NewCaption"] != null)
						{
							IL_404:
							num2 = 42;
							crossTotalOn.Caption = this.oOo_ooo_0O._o.()[k, "NewCaption"].ToString();
						}
						IL_425:
						num2 = 43;
						crossTotalOn.upto = (this.oOo_ooo_0O._o.().GetCellCheck(k, this.oOo_ooo_0O._o.().Cols["upto"].Index) == CheckEnum.Checked);
						IL_459:
						num2 = 44;
						crossTableBuilder.Totals.Add(crossTotalOn);
					}
					IL_46A:
					num2 = 45;
				}
				IL_47C:
				num2 = 46;
				crossTableBuilder.OrderByTotal = this.O.0O_Oo.().Checked;
				IL_491:
				num2 = 47;
				crossTableBuilder.HorizontalTotal = this.o.oO_.().Checked;
				IL_4A6:
				num2 = 48;
				crossTableBuilder.VerticalTotal = this.o.00o0oO_oo_.().Checked;
				IL_4BB:
				num2 = 49;
				crossTableBuilder.HorizontalProportionCaption = this.o.__oOoo0O.().Text;
				IL_4D0:
				num2 = 50;
				crossTableBuilder.HorizontalProportion = this.o_0o00_.o0O_o.().Checked;
				IL_4E5:
				num2 = 51;
				crossTableBuilder.VerticalProportionCaption = this.o00_.O0.().Text;
				IL_4FA:
				num2 = 52;
				crossTableBuilder.VerticalProportion = this.oO.00OOOO__o0.().Checked;
				IL_50F:
				num2 = 53;
				crossTableBuilder.SamePeriodGrowth = this.ooo0._0o00oO_.().Checked;
				IL_524:
				num2 = 54;
				crossTableBuilder.CircleGrowth = this.O0_00.oo0.().Checked;
				IL_539:
				num2 = 55;
				crossTableBuilder.Decimals = Conversions.ToInteger(this.O0_.o0oo0_0_O0.().Value);
				IL_553:
				num2 = 56;
				crossTableBuilder.FromServer = this.oo.o0_0o.().Checked;
				IL_568:
				num2 = 57;
				if (this.o0_0O_O0.O_O0..O.OoOo_. == null || this.o0_0O_O0.O_O0..O.OoOo_..FindForm() != Main.OO_O.o. || Operators.CompareString(this.o0_0O_O0.O_O0..DataTable.LoadTop, "", true) <= 0 || !this.o0_0O_O0.O_O0..AllowBackEndFilter)
				{
					goto IL_68D;
				}
				IL_5C6:
				num2 = 58;
				crossTableBuilder.FromServer = true;
				IL_5D1:
				num2 = 59;
				if (!this.oo.o0_0o.().Checked)
				{
					goto IL_5EE;
				}
				IL_5E1:
				num2 = 60;
				crossTableBuilder.FromAll = true;
				goto IL_608;
				IL_5EE:
				num2 = 62;
				crossTableBuilder.Filter = this.o0_0O_O0.O_O0..DataTable.LoadFilter;
				IL_608:
				num2 = 63;
				if (Operators.CompareString(this.o_0Oo.O00OOoO.().Text.Trim(), "", true) <= 0)
				{
					goto IL_68D;
				}
				IL_629:
				num2 = 64;
				if (Operators.CompareString(crossTableBuilder.Filter, "", true) <= 0)
				{
					goto IL_673;
				}
				IL_641:
				num2 = 65;
				crossTableBuilder.Filter = crossTableBuilder.Filter + " And (" + this.o_0Oo.O00OOoO.().Text.Trim() + ")";
				goto IL_68D;
				IL_673:
				num2 = 67;
				crossTableBuilder.Filter = this.o_0Oo.O00OOoO.().Text.Trim();
				IL_68D:
				num2 = 68;
				crossTableBuilder.Subtotal = this.OO0OO0O0.o0_.().Checked;
				IL_6A2:
				num2 = 69;
				crossTableBuilder.ExtendFilter = this.o_0Oo.O00OOoO.().Text.Trim();
				IL_6BC:
				num2 = 70;
				result = crossTableBuilder;
				IL_6C2:
				goto IL_830;
				IL_6C7:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_7F1:
				goto IL_825;
				IL_7F3:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_803:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_7F3;
			}
			IL_825:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_830:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x001698B4 File Offset: 0x00167AB4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			CrossTableBuilder crossTableBuilder = this.oOo__.oO0.();
			if (crossTableBuilder != null && crossTableBuilder.HGroups.Count > 0 && crossTableBuilder.VGroups.Count > 0 && crossTableBuilder.Totals.Count > 0)
			{
				crossTableBuilder.Build();
				crossTableBuilder.FromServer = this.oo.o0_0o.().Checked;
				this.o0_0O_O0.O_O0..O_0._O_0OO000O. = crossTableBuilder;
				if (OO_00oOO.Tables.get_Contains(crossTableBuilder.TableName))
				{
					OO_00oOO.MainTable = OO_00oOO.Tables[crossTableBuilder.TableName];
				}
				base.DialogResult = DialogResult.OK;
				this.o0_0O_O0.O_O0..NeedSaveSetting = true;
				this.o0_0O_O0.O_O0..oo0OO0Ooo._.(true);
			}
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x00169968 File Offset: 0x00167B68
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

		// Token: 0x060034B1 RID: 13489 RVA: 0x001699D4 File Offset: 0x00167BD4
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

		// Token: 0x060034B2 RID: 13490 RVA: 0x00169A2C File Offset: 0x00167C2C
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

		// Token: 0x060034B3 RID: 13491 RVA: 0x00169A85 File Offset: 0x00167C85
		private void <<EMPTY_NAME>>(object A_0, CancelEventArgs A_1)
		{
			if (Operators.CompareString(this.oo0OOO.Oo__00.().Text, "", true) > 0 && !o_O_o_oOoo__.O_o_._o0.(this.oo0OOO.Oo__00.().Text))
			{
				A_1.Cancel = true;
			}
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00169ABC File Offset: 0x00167CBC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			CrossTableBuilder crossTableBuilder = this.oOo__.oO0.();
			if (crossTableBuilder != null && crossTableBuilder.HGroups.Count > 0 && crossTableBuilder.VGroups.Count > 0 && crossTableBuilder.Totals.Count > 0)
			{
				CrossTableProperty a_ = new CrossTableProperty(crossTableBuilder);
				new O\u3002_\u3002\u3000\u3002(this.o0_0O_O0.O_O0., o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\v', false), ExtendTablePropertyTypeEnum.CrossTable).ShowDialog();
			}
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x00169B20 File Offset: 0x00167D20
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new o\u3000\u3000\u3002\u3002\u3002\u3002o(this.o0_0O_O0.O_O0., ExtendTablePropertyTypeEnum.CrossTable).ShowDialog();
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x00169B34 File Offset: 0x00167D34
		public mf(bool A_0) : this(A_0, OO_00oOO.CurrentTable)
		{
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x00169B44 File Offset: 0x00167D44
		public mf(bool A_0, Table A_1)
		{
			base.Activated += this.O_oo.0OO.;
			base.Load += this.OoOoo.Oooo00.;
			base.FormClosed += this.OoOoo.Oooo00.;
			int num2;
			int num5;
			object obj;
			try
			{
				IL_3C:
				int num = 1;
				this.o_0Oo.O00OOoO.();
				IL_44:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_5B:
				num = 3;
				C1FlexGrid[] array = new C1FlexGrid[]
				{
					this.oOo_ooo_0O._o.(),
					this.oO._0O.(),
					this.o_0Oo.O00OOoO.()
				};
				IL_7F:
				num = 4;
				foreach (C1FlexGrid c1FlexGrid in array)
				{
					IL_90:
					num = 5;
					c1FlexGrid.Styles.SelectedColumnHeader.Clear();
					IL_A3:
					num = 6;
					c1FlexGrid.Styles.Alternate.Clear();
					IL_B6:
					num = 7;
					c1FlexGrid.Styles.Focus.Clear();
					IL_C9:
					num = 8;
					c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal);
					IL_E8:
					num = 9;
					c1FlexGrid.FocusRect = FocusRectEnum.Solid;
					IL_F3:
					num = 10;
					c1FlexGrid.AllowSorting = AllowSortingEnum.None;
					IL_FE:
					num = 11;
				}
				IL_112:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_119:
				num = 13;
				this.o0_0O_O0.O_O0. = A_1;
				IL_123:
				num = 14;
				ListDictionary listDictionary = new ListDictionary();
				IL_12D:
				num = 15;
				ListDictionary listDictionary2 = new ListDictionary();
				IL_137:
				num = 16;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				IL_141:
				num = 17;
				IEnumerator<Col> enumerator = A_1.Cols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Col col = enumerator.Current;
					IL_15C:
					num = 18;
					dictionary.Add(col.Name, col.Caption);
					IL_174:
					num = 19;
				}
				IL_180:
				num = 20;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_18E:
				num = 21;
				this.oO._0O.().Cols["Name"].DataMap = dictionary;
				IL_1AD:
				num = 22;
				this.o_0Oo.O00OOoO.().Cols["Name"].DataMap = dictionary;
				IL_1CC:
				num = 23;
				this.oOo_ooo_0O._o.().Cols["Name"].DataMap = dictionary;
				IL_1EB:
				num = 24;
				listDictionary.Add(AggregateEnum.Sum, "累计值");
				IL_200:
				num = 25;
				listDictionary.Add(AggregateEnum.Average, "平均值");
				IL_215:
				num = 26;
				listDictionary.Add(AggregateEnum.Count, "记录数");
				IL_22A:
				num = 27;
				listDictionary.Add(AggregateEnum.Max, "最大值");
				IL_23F:
				num = 28;
				listDictionary.Add(AggregateEnum.Min, "最小值");
				IL_254:
				num = 29;
				this.oOo_ooo_0O._o.().Cols["Aggregate"].DataMap = listDictionary;
				IL_273:
				num = 30;
				listDictionary2.Add(DateGroupEnum.Month, "月");
				IL_288:
				num = 31;
				listDictionary2.Add(DateGroupEnum.Quarter, "季");
				IL_29D:
				num = 32;
				listDictionary2.Add(DateGroupEnum.Year, "年");
				IL_2B2:
				num = 33;
				listDictionary2.Add(DateGroupEnum.Week, "周");
				IL_2C7:
				num = 34;
				listDictionary2.Add(DateGroupEnum.Day, "日");
				IL_2DC:
				num = 35;
				listDictionary2.Add(DateGroupEnum.Hour, "时");
				IL_2F1:
				num = 36;
				listDictionary2.Add(DateGroupEnum.Minute, "分");
				IL_306:
				num = 37;
				listDictionary2.Add(DateGroupEnum.Second, "秒");
				IL_31B:
				num = 38;
				listDictionary2.Add(DateGroupEnum.DayOfWeek, "周日");
				IL_331:
				num = 39;
				listDictionary2.Add(DateGroupEnum.DayOfYear, "年日");
				IL_347:
				num = 40;
				listDictionary2.Add(DateGroupEnum.None, "无");
				IL_35C:
				num = 41;
				this.oO._0O.().Cols["DateGroup"].DataMap = listDictionary2;
				IL_37B:
				num = 42;
				this.o_0Oo.O00OOoO.().Cols["DateGroup"].DataMap = listDictionary2;
				bool flag;
				int num3;
				do
				{
					IL_39A:
					num = 44;
					flag = false;
					IL_3A0:
					num = 45;
					num3++;
					IL_3A9:
					num = 46;
					string right = "统计表" + Conversions.ToString(num3);
					IL_3BF:
					num = 47;
					IEnumerator<DataTable> enumerator2 = OO_00oOO.DataTables.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataTable dataTable = enumerator2.Current;
						IL_3D9:
						num = 48;
						if (Operators.CompareString(dataTable.Name, right, true) == 0)
						{
							IL_3ED:
							num = 49;
							flag = true;
							break;
						}
						IL_3F5:
						num = 51;
					}
					IL_401:
					num = 52;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
					IL_40F:
					num = 53;
				}
				while (flag);
				IL_416:
				num = 54;
				this.oo0OOO.Oo__00.().Value = "统计表" + Conversions.ToString(num3);
				IL_435:
				num = 55;
				if (A_0 || A_1.O_0._O_0OO000O. == null)
				{
					goto IL_9F7;
				}
				IL_449:
				num = 56;
				CrossTableBuilder crossTableBuilder = A_1.O_0._O_0OO000O.;
				IL_454:
				num = 57;
				this.oo0OOO.Oo__00.().Value = crossTableBuilder.TableName;
				IL_469:
				num = 58;
				this.OO00.OO_0o_0o.().Value = crossTableBuilder.Caption;
				IL_47E:
				num = 59;
				this.o_0Oo.O00OOoO.().Value = crossTableBuilder.ExtendFilter;
				IL_493:
				num = 60;
				this.O.0O_Oo.().Checked = A_1.O_0._O_0OO000O..OrderByTotal;
				IL_4AC:
				num = 61;
				this.o.oO_.().Checked = A_1.O_0._O_0OO000O..HorizontalTotal;
				IL_4C5:
				num = 62;
				this.o.00o0oO_oo_.().Checked = A_1.O_0._O_0OO000O..VerticalTotal;
				IL_4DE:
				num = 63;
				this.o_0o00_.o0O_o.().Checked = A_1.O_0._O_0OO000O..HorizontalProportion;
				IL_4F7:
				num = 64;
				this.oO.00OOOO__o0.().Checked = A_1.O_0._O_0OO000O..VerticalProportion;
				IL_510:
				num = 65;
				this.o.__oOoo0O.().Value = A_1.O_0._O_0OO000O..HorizontalProportionCaption;
				IL_529:
				num = 66;
				this.o00_.O0.().Value = A_1.O_0._O_0OO000O..VerticalProportionCaption;
				IL_542:
				num = 67;
				this.oo.o0_0o.().Checked = A_1.O_0._O_0OO000O..FromServer;
				IL_55B:
				num = 68;
				this.OO0OO0O0.o0_.().Checked = A_1.O_0._O_0OO000O..Subtotal;
				IL_574:
				num = 69;
				this.ooo0._0o00oO_.().Checked = A_1.O_0._O_0OO000O..SamePeriodGrowth;
				IL_58D:
				num = 70;
				this.O0_00.oo0.().Checked = A_1.O_0._O_0OO000O..CircleGrowth;
				IL_5A6:
				num = 71;
				this.O0_.o0oo0_0_O0.().Value = A_1.O_0._O_0OO000O..Decimals;
				IL_5C4:
				num = 72;
				IEnumerator<GroupOn> enumerator3 = crossTableBuilder.HGroups.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					GroupOn groupOn = enumerator3.Current;
					IL_5E3:
					num = 73;
					if (A_1.DataTable.DataCols.Contains(groupOn.Name))
					{
						IL_602:
						num = 75;
						this.oO._0O.().AddItem(string.Concat(new string[]
						{
							groupOn.Name + "\t",
							"\t",
							groupOn.NewName,
							"\t",
							groupOn.NewCaption
						}));
						IL_654:
						num = 76;
						if (A_1.DataTable.DataCols[groupOn.Name].IsDate)
						{
							IL_675:
							num = 77;
							this.oO._0O.()[this.oO._0O.().Rows.Count - 1, "DateGroup"] = groupOn.DateGroup;
						}
						else
						{
							IL_6A8:
							num = 79;
							this.oO._0O.()[this.oO._0O.().Rows.Count - 1, "DateGroup"] = null;
						}
						IL_6CE:
						num = 80;
						if (Operators.CompareString(groupOn.Name, groupOn.NewName, true) != 0)
						{
							IL_6E7:
							num = 81;
							this.oO._0O.()[this.oO._0O.().Rows.Count - 1, "NewName"] = groupOn.NewName;
						}
						else
						{
							IL_715:
							num = 83;
							this.oO._0O.()[this.oO._0O.().Rows.Count - 1, "NewName"] = null;
						}
					}
					IL_73B:
					num = 84;
				}
				IL_74A:
				num = 85;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_758:
				num = 86;
				IEnumerator<CrossGroupOn> enumerator4 = crossTableBuilder.VGroups.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					CrossGroupOn crossGroupOn = enumerator4.Current;
					IL_777:
					num = 87;
					if (A_1.DataTable.DataCols.Contains(crossGroupOn.Name))
					{
						IL_796:
						num = 89;
						this.o_0Oo.O00OOoO.().AddItem(crossGroupOn.Name + "\t" + "\t" + crossGroupOn.Pattern);
						IL_7C7:
						num = 90;
						if (A_1.DataTable.DataCols[crossGroupOn.Name].IsDate)
						{
							IL_7E8:
							num = 91;
							this.o_0Oo.O00OOoO.()[this.o_0Oo.O00OOoO.().Rows.Count - 1, "DateGroup"] = crossGroupOn.DateGroup;
						}
						else
						{
							IL_81B:
							num = 93;
							this.o_0Oo.O00OOoO.()[this.o_0Oo.O00OOoO.().Rows.Count - 1, "DateGroup"] = null;
						}
					}
					IL_841:
					num = 94;
				}
				IL_850:
				num = 95;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
				IL_85E:
				num = 96;
				IEnumerator<CrossTotalOn> enumerator5 = crossTableBuilder.Totals.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					CrossTotalOn crossTotalOn = enumerator5.Current;
					IL_87D:
					num = 97;
					if (A_1.DataTable.DataCols.Contains(crossTotalOn.Name))
					{
						IL_89C:
						num = 98;
						bool expression = false;
						IL_8A2:
						num = 99;
						if (Operators.CompareString(crossTotalOn.Caption, Oo00.OoO_.__o.(crossTotalOn.Aggregate), true) == 0 || Operators.CompareString(crossTotalOn.Caption, crossTotalOn.Name, true) == 0)
						{
							IL_8D6:
							num = 100;
							expression = true;
						}
						else
						{
							IL_8DE:
							num = 102;
							if (Operators.CompareString(crossTotalOn.Caption, crossTotalOn.Name + "_" + Oo00.OoO_.__o.(crossTotalOn.Aggregate), true) == 0)
							{
								IL_90D:
								num = 103;
								expression = true;
							}
						}
						IL_913:
						num = 104;
						this.oOo_ooo_0O._o.().AddItem(crossTotalOn.Name + "\t" + "\t" + "\t" + Interaction.IIf(expression, "", crossTotalOn.Caption).ToString());
						IL_95F:
						num = 105;
						this.oOo_ooo_0O._o.()[this.oOo_ooo_0O._o.().Rows.Count - 1, "Aggregate"] = crossTotalOn.Aggregate;
						IL_990:
						num = 106;
						if (crossTotalOn.upto)
						{
							IL_99C:
							num = 107;
							this.oOo_ooo_0O._o.().SetCellCheck(this.oOo_ooo_0O._o.().Rows.Count - 1, this.oOo_ooo_0O._o.().Cols["upto"].Index, CheckEnum.Checked);
						}
					}
					IL_9D7:
					num = 108;
				}
				IL_9E6:
				num = 109;
				if (enumerator5 != null)
				{
					enumerator5.Dispose();
				}
				IL_9F4:
				crossTableBuilder = null;
				IL_9F7:
				num = 111;
				this.oO._0O.().AllowAddNew = true;
				IL_A06:
				num = 112;
				this.o_0Oo.O00OOoO.().AllowAddNew = true;
				IL_A15:
				num = 113;
				this.oOo_ooo_0O._o.().AllowAddNew = true;
				IL_A24:
				num = 114;
				this.oo.o0_0o.().Enabled = A_1.AllowBackgroundStatistics;
				IL_A38:
				num = 115;
				this.O.0O_Oo.().Visible = (OO_00oOO.User.Type == UserTypeEnum.Developer);
				IL_A53:
				goto IL_C75;
				IL_A58:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_C36:
				goto IL_C6A;
				IL_C38:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_C48:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_C38;
			}
			IL_C6A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_C75:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x0016A7EC File Offset: 0x001689EC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_0Oo.O00OOoO.().Value = this.o0_0O_O0.O_O0..DataTable.OOoo__00O_.o_O.(this.o_0Oo.O00OOoO.().Text, true);
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x0016A818 File Offset: 0x00168A18
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
				CrossTableBuilder crossTableBuilder = this.oOo__.oO0.();
				IL_10:
				num2 = 3;
				if (crossTableBuilder == null)
				{
					goto IL_B33;
				}
				IL_18:
				num2 = 5;
				StringBuilder stringBuilder = new StringBuilder();
				IL_21:
				num2 = 6;
				if (Operators.CompareString(this.o_0Oo.O00OOoO.().Text, "", true) != 0)
				{
					goto IL_81;
				}
				IL_3B:
				num2 = 7;
				stringBuilder.Append(string.Concat(new string[]
				{
					"Dim g As New CrossTableBuilder(\"",
					crossTableBuilder.TableName,
					"\", DataTables(\"",
					crossTableBuilder.SourceDataTable.Name,
					"\"))"
				}));
				goto IL_DC;
				IL_81:
				num2 = 9;
				stringBuilder.Append(string.Concat(new string[]
				{
					"Dim g As New CrossTableBuilder(\"",
					crossTableBuilder.TableName,
					"\", DataTables(\"",
					crossTableBuilder.SourceDataTable.Name,
					"\"), \"",
					this.o_0Oo.O00OOoO.().Text,
					"\")"
				}));
				IL_DC:
				num2 = 10;
				stringBuilder.Append("\r\n");
				IL_EC:
				num2 = 11;
				if (Operators.CompareString(crossTableBuilder.Caption, "", true) <= 0)
				{
					goto IL_133;
				}
				IL_103:
				num2 = 12;
				stringBuilder.Append("g.Caption = \"" + crossTableBuilder.Caption + "\"");
				IL_123:
				num2 = 13;
				stringBuilder.Append("\r\n");
				IL_133:
				num2 = 14;
				IEnumerator<GroupOn> enumerator = crossTableBuilder.HGroups.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GroupOn groupOn = enumerator.Current;
					IL_151:
					num2 = 15;
					string text = "";
					IL_15B:
					num2 = 16;
					if (Operators.CompareString(groupOn.NewName, groupOn.Name, true) != 0)
					{
						IL_174:
						num2 = 17;
						text = groupOn.NewName;
					}
					IL_180:
					num2 = 18;
					if (this.o0_0O_O0.O_O0..DataTable.DataCols[groupOn.Name].IsDate && groupOn.DateGroup != DateGroupEnum.Month)
					{
						IL_1B6:
						num2 = 19;
						string text2 = "DateGroupEnum." + Enum.GetName(typeof(DateGroupEnum), groupOn.DateGroup);
						IL_1E0:
						num2 = 20;
						if (Operators.CompareString(groupOn.NewCaption, "", true) > 0)
						{
							IL_1F8:
							num2 = 21;
							stringBuilder.Append(string.Concat(new string[]
							{
								"g.HGroups.AddDef(\"",
								groupOn.Name,
								"\", ",
								text2,
								", \"",
								text,
								"\", \"",
								groupOn.NewCaption,
								"\")"
							}));
						}
						else
						{
							IL_25A:
							num2 = 23;
							if (Operators.CompareString(text, "", true) > 0)
							{
								IL_26D:
								num2 = 24;
								stringBuilder.Append(string.Concat(new string[]
								{
									"g.HGroups.AddDef(\"",
									groupOn.Name,
									"\", ",
									text2,
									", \"",
									text,
									"\")"
								}));
							}
							else
							{
								IL_2BC:
								num2 = 26;
								stringBuilder.Append(string.Concat(new string[]
								{
									"g.HGroups.AddDef(\"",
									groupOn.Name,
									"\", ",
									text2,
									")"
								}));
							}
						}
					}
					else
					{
						IL_2FE:
						num2 = 28;
						if (Operators.CompareString(groupOn.NewCaption, "", true) > 0)
						{
							IL_316:
							num2 = 29;
							stringBuilder.Append(string.Concat(new string[]
							{
								"g.HGroups.AddDef(\"",
								groupOn.Name,
								"\", \"",
								text,
								"\", \"",
								groupOn.NewCaption,
								"\")"
							}));
						}
						else
						{
							IL_367:
							num2 = 31;
							if (Operators.CompareString(text, "", true) > 0)
							{
								IL_37A:
								num2 = 32;
								stringBuilder.Append(string.Concat(new string[]
								{
									"g.HGroups.AddDef(\"",
									groupOn.Name,
									"\", \"",
									text,
									"\")"
								}));
							}
							else
							{
								IL_3B9:
								num2 = 34;
								stringBuilder.Append("g.HGroups.AddDef(\"" + groupOn.Name + "\")");
							}
						}
					}
					IL_3DA:
					num2 = 35;
					stringBuilder.Append("\r\n");
					IL_3EA:
					num2 = 36;
				}
				IL_3F9:
				num2 = 37;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_407:
				num2 = 38;
				IEnumerator<CrossGroupOn> enumerator2 = crossTableBuilder.VGroups.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					CrossGroupOn crossGroupOn = enumerator2.Current;
					IL_425:
					num2 = 39;
					if (this.o0_0O_O0.O_O0..DataTable.DataCols[crossGroupOn.Name].IsDate && crossGroupOn.DateGroup != DateGroupEnum.Month)
					{
						IL_45B:
						num2 = 40;
						string text3 = "DateGroupEnum." + Enum.GetName(typeof(DateGroupEnum), crossGroupOn.DateGroup);
						IL_485:
						num2 = 41;
						if (Operators.CompareString(crossGroupOn.Pattern, "", true) > 0)
						{
							IL_49D:
							num2 = 42;
							stringBuilder.Append(string.Concat(new string[]
							{
								"g.VGroups.AddDef(\"",
								crossGroupOn.Name,
								"\", ",
								text3,
								", \"",
								crossGroupOn.Pattern,
								"\")"
							}));
						}
						else
						{
							IL_4F1:
							num2 = 44;
							stringBuilder.Append(string.Concat(new string[]
							{
								"g.VGroups.AddDef(\"",
								crossGroupOn.Name,
								"\", ",
								text3,
								")"
							}));
						}
					}
					else
					{
						IL_530:
						num2 = 46;
						if (Operators.CompareString(crossGroupOn.Pattern, "", true) > 0)
						{
							IL_548:
							num2 = 47;
							stringBuilder.Append(string.Concat(new string[]
							{
								"g.VGroups.AddDef(\"",
								crossGroupOn.Name,
								"\", \"",
								crossGroupOn.Pattern,
								"\")"
							}));
						}
						else
						{
							IL_58C:
							num2 = 49;
							stringBuilder.Append("g.VGroups.AddDef(\"" + crossGroupOn.Name + "\")");
						}
					}
					IL_5AD:
					num2 = 50;
					stringBuilder.Append("\r\n");
					IL_5BD:
					num2 = 51;
				}
				IL_5CC:
				num2 = 52;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_5DA:
				num2 = 53;
				IEnumerator<CrossTotalOn> enumerator3 = crossTableBuilder.Totals.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					CrossTotalOn crossTotalOn = enumerator3.Current;
					IL_5F8:
					num2 = 54;
					if (crossTotalOn.Aggregate == AggregateEnum.Sum)
					{
						IL_608:
						num2 = 55;
						if (Operators.CompareString(crossTotalOn.Caption, "", true) > 0)
						{
							IL_620:
							num2 = 56;
							stringBuilder.Append(string.Concat(new string[]
							{
								"g.Totals.AddDef(\"",
								crossTotalOn.Name,
								"\", \"",
								crossTotalOn.Caption,
								"\""
							}));
						}
						else
						{
							IL_667:
							num2 = 58;
							stringBuilder.Append("g.Totals.AddDef(\"" + crossTotalOn.Name + "\"");
						}
					}
					else
					{
						IL_68D:
						num2 = 60;
						string text4 = "AggregateEnum." + Enum.GetName(typeof(AggregateEnum), crossTotalOn.Aggregate);
						IL_6B7:
						num2 = 61;
						if (Operators.CompareString(crossTotalOn.Caption, "", true) > 0)
						{
							IL_6CF:
							num2 = 62;
							stringBuilder.Append(string.Concat(new string[]
							{
								"g.Totals.AddDef(\"",
								crossTotalOn.Name,
								"\", ",
								text4,
								", \"",
								crossTotalOn.Caption,
								"\""
							}));
						}
						else
						{
							IL_720:
							num2 = 64;
							stringBuilder.Append(("g.Totals.AddDef(\"" + crossTotalOn.Name + "\", " + text4) ?? "");
						}
					}
					IL_74C:
					num2 = 65;
					if (crossTotalOn.upto)
					{
						IL_758:
						num2 = 66;
						stringBuilder.Append(", True");
					}
					IL_768:
					num2 = 67;
					stringBuilder.Append(")\r\n");
					IL_778:
					num2 = 68;
				}
				IL_787:
				num2 = 69;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_795:
				num2 = 70;
				if (!this.O.0O_Oo.().Checked)
				{
					goto IL_7C5;
				}
				IL_7A5:
				num2 = 71;
				stringBuilder.Append("g.OrderByTotal = True");
				IL_7B5:
				num2 = 72;
				stringBuilder.Append("\r\n");
				IL_7C5:
				num2 = 73;
				if (!this.o.oO_.().Checked)
				{
					goto IL_7F5;
				}
				IL_7D5:
				num2 = 74;
				stringBuilder.Append("g.HorizontalTotal = True");
				IL_7E5:
				num2 = 75;
				stringBuilder.Append("\r\n");
				IL_7F5:
				num2 = 76;
				if (!this.o.00o0oO_oo_.().Checked)
				{
					goto IL_825;
				}
				IL_805:
				num2 = 77;
				stringBuilder.Append("g.VerticalTotal = True");
				IL_815:
				num2 = 78;
				stringBuilder.Append("\r\n");
				IL_825:
				num2 = 79;
				if (!this.o_0o00_.o0O_o.().Checked)
				{
					goto IL_855;
				}
				IL_835:
				num2 = 80;
				stringBuilder.Append("g.HorizontalProportion = True");
				IL_845:
				num2 = 81;
				stringBuilder.Append("\r\n");
				IL_855:
				num2 = 82;
				if (!this.oO.00OOOO__o0.().Checked)
				{
					goto IL_885;
				}
				IL_865:
				num2 = 83;
				stringBuilder.Append("g.VerticalProportion = True");
				IL_875:
				num2 = 84;
				stringBuilder.Append("\r\n");
				IL_885:
				num2 = 85;
				if (!this.ooo0._0o00oO_.().Checked)
				{
					goto IL_8B5;
				}
				IL_895:
				num2 = 86;
				stringBuilder.Append("g.SamePeriodGrowth = True");
				IL_8A5:
				num2 = 87;
				stringBuilder.Append("\r\n");
				IL_8B5:
				num2 = 88;
				if (!this.O0_00.oo0.().Checked)
				{
					goto IL_8E5;
				}
				IL_8C5:
				num2 = 89;
				stringBuilder.Append("g.CircleGrowth = True");
				IL_8D5:
				num2 = 90;
				stringBuilder.Append("\r\n");
				IL_8E5:
				num2 = 91;
				if (Operators.CompareString(this.o.__oOoo0O.().Text, "", true) <= 0 || Operators.CompareString(this.o.__oOoo0O.().Text, "份额", true) == 0)
				{
					goto IL_94E;
				}
				IL_919:
				num2 = 92;
				stringBuilder.Append("g.HorizontalProportionCaption = \"" + this.o.__oOoo0O.().Text + "\"");
				IL_93E:
				num2 = 93;
				stringBuilder.Append("\r\n");
				IL_94E:
				num2 = 94;
				if (Operators.CompareString(this.o00_.O0.().Text, "", true) <= 0 || Operators.CompareString(this.o00_.O0.().Text, "占比", true) == 0)
				{
					goto IL_9B7;
				}
				IL_982:
				num2 = 95;
				stringBuilder.Append("g.VerticalProportionCaption = \"" + this.o00_.O0.().Text + "\"");
				IL_9A7:
				num2 = 96;
				stringBuilder.Append("\r\n");
				IL_9B7:
				num2 = 97;
				if (Conversions.ToInteger(this.O0_.o0oo0_0_O0.().Value) == 4)
				{
					goto IL_A07;
				}
				IL_9CD:
				num2 = 98;
				stringBuilder.Append("g.Decimals = " + Conversions.ToString(Conversions.ToInteger(this.O0_.o0oo0_0_O0.().Value)));
				IL_9F7:
				num2 = 99;
				stringBuilder.Append("\r\n");
				IL_A07:
				num2 = 100;
				if (Operators.CompareString(this.o_0Oo.O00OOoO.().Text, "", true) <= 0)
				{
					goto IL_A58;
				}
				IL_A23:
				num2 = 101;
				stringBuilder.Append("g.Filter = \"" + this.o_0Oo.O00OOoO.().Text + "\"");
				IL_A48:
				num2 = 102;
				stringBuilder.Append("\r\n");
				IL_A58:
				num2 = 103;
				if (!this.OO0OO0O0.o0_.().Checked)
				{
					goto IL_A88;
				}
				IL_A68:
				num2 = 104;
				stringBuilder.Append("g.Subtotal = True");
				IL_A78:
				num2 = 105;
				stringBuilder.Append("\r\n");
				IL_A88:
				num2 = 106;
				if (!this.oo.o0_0o.().Checked)
				{
					goto IL_AB8;
				}
				IL_A98:
				num2 = 107;
				stringBuilder.Append("g.FromServer = True");
				IL_AA8:
				num2 = 108;
				stringBuilder.Append("\r\n");
				IL_AB8:
				num2 = 109;
				stringBuilder.Append("g.Build()");
				IL_AC8:
				num2 = 110;
				stringBuilder.Append("\r\n");
				IL_AD8:
				num2 = 111;
				stringBuilder.Append("MainTable = Tables(\"" + crossTableBuilder.TableName + "\")");
				IL_AF8:
				num2 = 112;
				o\u3000\u3000\u3002\u3002O o_u3000_u3000_u3002_u3002O = new o\u3000\u3000\u3002\u3002O();
				IL_B02:
				num2 = 113;
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().Text = stringBuilder.ToString();
				IL_B18:
				num2 = 114;
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().SelectionStart = 0;
				IL_B28:
				num2 = 115;
				o_u3000_u3000_u3002_u3002O.ShowDialog();
				IL_B33:
				goto IL_D55;
				IL_B38:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_D16:
				goto IL_D4A;
				IL_D18:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_D28:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_D18;
			}
			IL_D4A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_D55:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x0016B5A0 File Offset: 0x001697A0
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

		// Token: 0x060034BB RID: 13499 RVA: 0x0016B5F4 File Offset: 0x001697F4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oo.o0_0o.().Checked)
			{
				this.O_.O0oOOo.().Enabled = false;
				if (!this.o0_0O_O0.O_O0..DataTable.frd_IsInnerTable && !this.o0_0O_O0.O_O0..DataTable.frd_IsOuterTable && Operators.CompareString(this.o0_0O_O0.O_O0..DataTable.DataServer, "", true) <= 0)
				{
					this.oo.o0_0o.().Checked = false;
					return;
				}
			}
			else
			{
				if (this.o0_0O_O0.O_O0..O.OoOo_. != null && this.o0_0O_O0.O_O0..O.OoOo_..FindForm() == Main.OO_O.o. && Operators.CompareString(this.o0_0O_O0.O_O0..DataTable.LoadTop, "", true) > 0 && this.o0_0O_O0.O_O0..AllowBackEndFilter)
				{
					this.O_.O0oOOo.().Enabled = false;
					return;
				}
				this.O_.O0oOOo.().Enabled = true;
			}
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x0016B6D7 File Offset: 0x001698D7
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.___0_00_oo. == 0)
			{
				this.o.___0_00_oo. = 1;
				this.o0_0O_O0.O_O0..Oo0Oo___.o0o.();
			}
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x0016B6F4 File Offset: 0x001698F4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o0_0O_O0.O_O0..Rows.Count < 2)
			{
				this.oo.o0_0o.().Checked = true;
			}
			if (this.o0_0O_O0.O_O0..O.OoOo_. != null && this.o0_0O_O0.O_O0..O.OoOo_..FindForm() == Main.OO_O.o. && Operators.CompareString(this.o0_0O_O0.O_O0..DataTable.LoadTop, "", true) > 0 && this.o0_0O_O0.O_O0..AllowBackEndFilter)
			{
				this.O_.O0oOOo.().Enabled = false;
			}
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x0016B77B File Offset: 0x0016997B
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400150B RID: 5387
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400150C RID: 5388
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400150D RID: 5389
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x0400150E RID: 5390
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400150F RID: 5391
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001510 RID: 5392
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001511 RID: 5393
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001512 RID: 5394
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001513 RID: 5395
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001514 RID: 5396
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001515 RID: 5397
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001516 RID: 5398
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001517 RID: 5399
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001518 RID: 5400
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001519 RID: 5401
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400151A RID: 5402
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400151B RID: 5403
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x0400151C RID: 5404
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400151D RID: 5405
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x0400151E RID: 5406
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x0400151F RID: 5407
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04001520 RID: 5408
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04001521 RID: 5409
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04001522 RID: 5410
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04001523 RID: 5411
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001524 RID: 5412
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001525 RID: 5413
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001526 RID: 5414
		[CompilerGenerated]
		private GroupBox <<EMPTY_NAME>>;

		// Token: 0x04001527 RID: 5415
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001528 RID: 5416
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001529 RID: 5417
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400152A RID: 5418
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400152B RID: 5419
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400152C RID: 5420
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400152D RID: 5421
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400152E RID: 5422
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x0400152F RID: 5423
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001530 RID: 5424
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001531 RID: 5425
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001532 RID: 5426
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001533 RID: 5427
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001534 RID: 5428
		private int <<EMPTY_NAME>>;
	}
}
