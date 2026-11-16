using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000355 RID: 853
	[DesignerGenerated]
	internal partial class g2 : Form
	{
		// Token: 0x060034BF RID: 13503 RVA: 0x0016B790 File Offset: 0x00169990
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_.00_o0ooO. != null)
				{
					this.O_.00_o0ooO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x0016B7D0 File Offset: 0x001699D0
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(g2));
			this.o.000.(new C1Button());
			this.oOooO._oooo.(new C1DockingTabPage());
			this.oOoOOoO0_.oo.(new C1TextBox());
			this.Oo0.o0___00_O.(new Label());
			this.OO.Oo.(new RadioButton());
			this.O_oOOoo.0o0Oo.(new RadioButton());
			this.oO_0.O.(new C1Button());
			this.oOoooo.O0O_.(new C1TextBox());
			this.o0o_00O_.0__o_.(new Label());
			this.oO_0.O.(new C1ComboBox());
			this.o_oO.oO0O_0.(new Label());
			this.oOoooo.O0O_.(new C1ComboBox());
			this.oOoo_o0o_._O_.(new Label());
			this.oO_0.O.(new CheckedListBox());
			this.OO.Oo.(new Label());
			this.O__00O0Oo._oo.(new C1ComboBox());
			this.oO_0.O.(new C1DockingTab());
			this.OO_.O_o0.(new C1DockingTabPage());
			this.o00oO00O.0OOO.(new PropertyGrid());
			this.O.o0oo.(new C1DockingTabPage());
			this.oOOO.O.(new C1Button());
			this.OO__.O.(new C1Button());
			this.O.OoOo0OO0o0.(new C1FlexGrid());
			this.O_o_0.Oo0000o.(new C1DockingTabPage());
			this.O_o_0.Oo0000o.(new C1NumericEdit());
			this.OO_o._oo_.(new Label());
			this.O0oo.o_0O_.(new C1Button());
			this.OO_.O_o0.(new C1NumericEdit());
			this.O_oOOoo.0o0Oo.(new Label());
			this.Oo_OO0o.oOO.(new C1Button());
			this.o00oO00O.0OOO.(new C1NumericEdit());
			this.O0._o0O_.(new Label());
			this.o00oO00O.0OOO.(new C1FlexGrid());
			this.OO.Oo.(new C1DockingTabPage());
			this.OO_o._oo_.(new C1FlexGrid());
			this.oo.O_0Oo00__.(new C1Button());
			this.o00oO00O.0OOO.(new C1CheckBox());
			this.oo._o0O.(new C1Button());
			this.o0oo.oO.(new C1Button());
			((ISupportInitialize)this.OO0_o._o.()).BeginInit();
			this.o0.oo_oO.().SuspendLayout();
			((ISupportInitialize)this.o0O.00_0o_Ooo.()).BeginInit();
			((ISupportInitialize)this.oOO.0O0_00_0O0.()).BeginInit();
			((ISupportInitialize)this.o0.oo_oO.()).BeginInit();
			((ISupportInitialize)this.O0O_o.0_o0O.()).BeginInit();
			((ISupportInitialize)this.o0.oo_oO.()).BeginInit();
			((ISupportInitialize)this.Oo.0o0_O0O.()).BeginInit();
			((ISupportInitialize)this.o0.0o.()).BeginInit();
			this.o0.0o.().SuspendLayout();
			this.O.O__oOo0_.().SuspendLayout();
			this.oOO.0O0_00_0O0.().SuspendLayout();
			((ISupportInitialize)this.o0.0o.()).BeginInit();
			((ISupportInitialize)this.O.Oo_O0o.()).BeginInit();
			((ISupportInitialize)this.oOO.0O0_00_0O0.()).BeginInit();
			this.OoO0o._0O_OO.().SuspendLayout();
			((ISupportInitialize)this.oOO.0.()).BeginInit();
			((ISupportInitialize)this.Ooo_o0.0oo_.()).BeginInit();
			((ISupportInitialize)this.OOoo._Oo_.()).BeginInit();
			((ISupportInitialize)this.o.0___o0_0Oo.()).BeginInit();
			((ISupportInitialize)this.OoO0o._0O_OO.()).BeginInit();
			((ISupportInitialize)this.OoO0o._0O_OO.()).BeginInit();
			this.Ooo.o.().SuspendLayout();
			((ISupportInitialize)this.o__0O_.00O.()).BeginInit();
			((ISupportInitialize)this.ooo0.oO_0.()).BeginInit();
			((ISupportInitialize)this.o0.oo_oO.()).BeginInit();
			((ISupportInitialize)this.oOOO._OO0OO.()).BeginInit();
			((ISupportInitialize)this.o_o0_.Oo_00O0.()).BeginInit();
			base.SuspendLayout();
			this.OO0_o._o.().DialogResult = DialogResult.OK;
			this.OO0_o._o.().Location = new Point(213, 513);
			this.OO0_o._o.().Name = "btnAccept";
			this.OO0_o._o.().Size = new Size(75, 23);
			this.OO0_o._o.().TabIndex = 1;
			this.OO0_o._o.().Text = "确定";
			this.OO0_o._o.().UseVisualStyleBackColor = true;
			this.o0.oo_oO.().Controls.Add(this.o0O.00_0o_Ooo.());
			this.o0.oo_oO.().Controls.Add(this.o00._0o0o.());
			this.o0.oo_oO.().Controls.Add(this.o__0O_.00O.());
			this.o0.oo_oO.().Controls.Add(this.O0O_o.0_o0O.());
			this.o0.oo_oO.().Controls.Add(this.oOO.0O0_00_0O0.());
			this.o0.oo_oO.().Controls.Add(this.o0.oo_oO.());
			this.o0.oo_oO.().Controls.Add(this.Ooo.o.());
			this.o0.oo_oO.().Controls.Add(this.O0O_o.0_o0O.());
			this.o0.oo_oO.().Controls.Add(this.oOO.00.());
			this.o0.oo_oO.().Controls.Add(this.o0.oo_oO.());
			this.o0.oo_oO.().Controls.Add(this.OOoo._Oo_.());
			this.o0.oo_oO.().Controls.Add(this.o__0O_.00O.());
			this.o0.oo_oO.().Controls.Add(this.OoO0o._0O_OO.());
			this.o0.oo_oO.().Controls.Add(this.Oo.0o0_O0O.());
			this.o0.oo_oO.().Location = new Point(1, 25);
			this.o0.oo_oO.().Name = "TableDataMapPage";
			this.o0.oo_oO.().Size = new Size(556, 457);
			this.o0.oo_oO.().TabIndex = 0;
			this.o0.oo_oO.().TabVisible = false;
			this.o0.oo_oO.().Text = "数据字典";
			this.o0O.00_0o_Ooo.().BackColor = Color.FromArgb(232, 234, 236);
			this.o0O.00_0o_Ooo.().BorderColor = Color.FromArgb(169, 177, 184);
			this.o0O.00_0o_Ooo.().BorderStyle = BorderStyle.FixedSingle;
			this.o0O.00_0o_Ooo.().Location = new Point(69, 307);
			this.o0O.00_0o_Ooo.().Name = "txtDropSort";
			this.o0O.00_0o_Ooo.().Size = new Size(430, 19);
			this.o0O.00_0o_Ooo.().TabIndex = 13;
			this.o0O.00_0o_Ooo.().Tag = null;
			this.o00._0o0o.().AutoSize = true;
			this.o00._0o0o.().Location = new Point(12, 311);
			this.o00._0o0o.().Name = "Label1";
			this.o00._0o0o.().Size = new Size(35, 12);
			this.o00._0o0o.().TabIndex = 14;
			this.o00._0o0o.().Text = "排序:";
			this.o__0O_.00O.().AutoSize = true;
			this.o__0O_.00O.().Location = new Point(69, 120);
			this.o__0O_.00O.().Name = "IncludeSomeColumns";
			this.o__0O_.00O.().Size = new Size(89, 16);
			this.o__0O_.00O.().TabIndex = 4;
			this.o__0O_.00O.().TabStop = true;
			this.o__0O_.00O.().Text = "包括以下列:";
			this.o__0O_.00O.().UseVisualStyleBackColor = true;
			this.O0O_o.0_o0O.().AutoSize = true;
			this.O0O_o.0_o0O.().Location = new Point(69, 97);
			this.O0O_o.0_o0O.().Name = "IncludeAllColumns";
			this.O0O_o.0_o0O.().Size = new Size(83, 16);
			this.O0O_o.0_o0O.().TabIndex = 3;
			this.O0O_o.0_o0O.().TabStop = true;
			this.O0O_o.0_o0O.().Text = "包括所有列";
			this.O0O_o.0_o0O.().UseVisualStyleBackColor = true;
			this.oOO.0O0_00_0O0.().Location = new Point(501, 278);
			this.oOO.0O0_00_0O0.().Name = "Button1";
			this.oOO.0O0_00_0O0.().Size = new Size(37, 23);
			this.oOO.0O0_00_0O0.().TabIndex = 7;
			this.oOO.0O0_00_0O0.().Text = "...";
			this.oOO.0O0_00_0O0.().UseVisualStyleBackColor = true;
			this.o0.oo_oO.().BackColor = Color.FromArgb(232, 234, 236);
			this.o0.oo_oO.().BorderColor = Color.FromArgb(169, 177, 184);
			this.o0.oo_oO.().BorderStyle = BorderStyle.FixedSingle;
			this.o0.oo_oO.().Location = new Point(69, 279);
			this.o0.oo_oO.().Name = "txtDropFilter";
			this.o0.oo_oO.().Size = new Size(430, 19);
			this.o0.oo_oO.().TabIndex = 6;
			this.o0.oo_oO.().Tag = null;
			this.Ooo.o.().AutoSize = true;
			this.Ooo.o.().Location = new Point(12, 283);
			this.Ooo.o.().Name = "Label10";
			this.Ooo.o.().Size = new Size(35, 12);
			this.Ooo.o.().TabIndex = 12;
			this.Ooo.o.().Text = "条件:";
			this.O0O_o.0_o0O.().AllowSpinLoop = false;
			this.O0O_o.0_o0O.().BackColor = Color.FromArgb(239, 239, 239);
			this.O0O_o.0_o0O.().BorderColor = Color.FromArgb(179, 199, 225);
			this.O0O_o.0_o0O.().BorderStyle = BorderStyle.FixedSingle;
			this.O0O_o.0_o0O.().Cursor = Cursors.Arrow;
			this.O0O_o.0_o0O.().DropDownStyle = DropDownStyle.DropDownList;
			this.O0O_o.0_o0O.().GapHeight = 0;
			this.O0O_o.0_o0O.().ImagePadding = new Padding(0);
			this.O0O_o.0_o0O.().ItemsDisplayMember = "";
			this.O0O_o.0_o0O.().ItemsValueMember = "";
			this.O0O_o.0_o0O.().Location = new Point(69, 70);
			this.O0O_o.0_o0O.().Name = "DisplayColumn";
			this.O0O_o.0_o0O.().Size = new Size(283, 19);
			this.O0O_o.0_o0O.().TabIndex = 2;
			this.O0O_o.0_o0O.().Tag = null;
			this.oOO.00.().AutoSize = true;
			this.oOO.00.().Location = new Point(12, 74);
			this.oOO.00.().Name = "Label7";
			this.oOO.00.().Size = new Size(47, 12);
			this.oOO.00.().TabIndex = 7;
			this.oOO.00.().Text = "显示列:";
			this.o0.oo_oO.().AllowSpinLoop = false;
			this.o0.oo_oO.().BackColor = Color.FromArgb(239, 239, 239);
			this.o0.oo_oO.().BorderColor = Color.FromArgb(179, 199, 225);
			this.o0.oo_oO.().BorderStyle = BorderStyle.FixedSingle;
			this.o0.oo_oO.().Cursor = Cursors.Arrow;
			this.o0.oo_oO.().DropDownStyle = DropDownStyle.DropDownList;
			this.o0.oo_oO.().GapHeight = 0;
			this.o0.oo_oO.().ImagePadding = new Padding(0);
			this.o0.oo_oO.().ItemsDisplayMember = "";
			this.o0.oo_oO.().ItemsValueMember = "";
			this.o0.oo_oO.().Location = new Point(69, 43);
			this.o0.oo_oO.().Name = "ValueColumn";
			this.o0.oo_oO.().Size = new Size(283, 19);
			this.o0.oo_oO.().TabIndex = 1;
			this.o0.oo_oO.().Tag = null;
			this.OOoo._Oo_.().AutoSize = true;
			this.OOoo._Oo_.().Location = new Point(12, 47);
			this.OOoo._Oo_.().Name = "Label6";
			this.OOoo._Oo_.().Size = new Size(47, 12);
			this.OOoo._Oo_.().TabIndex = 5;
			this.OOoo._Oo_.().Text = "取值列:";
			this.o__0O_.00O.().CheckOnClick = true;
			this.o__0O_.00O.().FormattingEnabled = true;
			this.o__0O_.00O.().IntegralHeight = false;
			this.o__0O_.00O.().Location = new Point(69, 143);
			this.o__0O_.00O.().Name = "DropColumns";
			this.o__0O_.00O.().Size = new Size(283, 129);
			this.o__0O_.00O.().TabIndex = 5;
			this.OoO0o._0O_OO.().AutoSize = true;
			this.OoO0o._0O_OO.().Location = new Point(12, 20);
			this.OoO0o._0O_OO.().Name = "Label5";
			this.OoO0o._0O_OO.().Size = new Size(47, 12);
			this.OoO0o._0O_OO.().TabIndex = 8;
			this.OoO0o._0O_OO.().Text = "数据表:";
			this.Oo.0o0_O0O.().AllowSpinLoop = false;
			this.Oo.0o0_O0O.().BackColor = Color.FromArgb(239, 239, 239);
			this.Oo.0o0_O0O.().BorderColor = Color.FromArgb(179, 199, 225);
			this.Oo.0o0_O0O.().BorderStyle = BorderStyle.FixedSingle;
			this.Oo.0o0_O0O.().Cursor = Cursors.Arrow;
			this.Oo.0o0_O0O.().DropDownStyle = DropDownStyle.DropDownList;
			this.Oo.0o0_O0O.().GapHeight = 0;
			this.Oo.0o0_O0O.().ImagePadding = new Padding(0);
			this.Oo.0o0_O0O.().ItemsDisplayMember = "";
			this.Oo.0o0_O0O.().ItemsValueMember = "";
			this.Oo.0o0_O0O.().Location = new Point(69, 16);
			this.Oo.0o0_O0O.().Name = "DropTable";
			this.Oo.0o0_O0O.().Size = new Size(283, 19);
			this.Oo.0o0_O0O.().TabIndex = 0;
			this.Oo.0o0_O0O.().Tag = null;
			this.o0.0o.().Controls.Add(this.O.O__oOo0_.());
			this.o0.0o.().Controls.Add(this.o0.oo_oO.());
			this.o0.0o.().Controls.Add(this.oOO.0O0_00_0O0.());
			this.o0.0o.().Controls.Add(this.OoO0o._0O_OO.());
			this.o0.0o.().Controls.Add(this.Ooo.o.());
			this.o0.0o.().Location = new Point(12, 12);
			this.o0.0o.().Name = "C1DockingTab1";
			this.o0.0o.().Size = new Size(558, 483);
			this.o0.0o.().TabIndex = 0;
			this.o0.0o.().TabsCanFocus = false;
			this.o0.0o.().TabsSpacing = 0;
			this.o0.0o.().TabStyle = TabStyleEnum.Sloping;
			this.o0.0o.().VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
			this.o0.0o.().VisualStyleBase = C1.Win.C1Command.VisualStyle.Classic;
			this.O.O__oOo0_.().Controls.Add(this.o0.oo_oO.());
			this.O.O__oOo0_.().Location = new Point(1, 25);
			this.O.O__oOo0_.().Name = "PropertyPage";
			this.O.O__oOo0_.().Size = new Size(556, 457);
			this.O.O__oOo0_.().TabIndex = 6;
			this.O.O__oOo0_.().Text = "基本属性";
			this.o0.oo_oO.().Dock = DockStyle.Fill;
			this.o0.oo_oO.().Location = new Point(0, 0);
			this.o0.oo_oO.().Name = "PropertyGrid1";
			this.o0.oo_oO.().Size = new Size(556, 457);
			this.o0.oo_oO.().TabIndex = 0;
			this.o0.oo_oO.().ToolbarVisible = false;
			this.oOO.0O0_00_0O0.().Controls.Add(this.o0.0o.());
			this.oOO.0O0_00_0O0.().Controls.Add(this.O.Oo_O0o.());
			this.oOO.0O0_00_0O0.().Controls.Add(this.oOO.0O0_00_0O0.());
			this.oOO.0O0_00_0O0.().Location = new Point(1, 25);
			this.oOO.0O0_00_0O0.().Name = "DataMapPage";
			this.oOO.0O0_00_0O0.().Size = new Size(556, 457);
			this.oOO.0O0_00_0O0.().TabIndex = 0;
			this.oOO.0O0_00_0O0.().TabVisible = false;
			this.oOO.0O0_00_0O0.().Text = "数据字典";
			this.o0.0o.().Location = new Point(380, 307);
			this.o0.0o.().Name = "btnAddRows";
			this.o0.0o.().Size = new Size(75, 23);
			this.o0.0o.().TabIndex = 1;
			this.o0.0o.().Text = "插入行";
			this.o0.0o.().UseVisualStyleBackColor = true;
			this.O.Oo_O0o.().Location = new Point(461, 307);
			this.O.Oo_O0o.().Name = "btnDeleteRows";
			this.O.Oo_O0o.().Size = new Size(75, 23);
			this.O.Oo_O0o.().TabIndex = 2;
			this.O.Oo_O0o.().Text = "删除行";
			this.O.Oo_O0o.().UseVisualStyleBackColor = true;
			this.oOO.0O0_00_0O0.().AutoClipboard = true;
			this.oOO.0O0_00_0O0.().ColumnInfo = componentResourceManager.GetString("DataMapGrid.ColumnInfo");
			this.oOO.0O0_00_0O0.().ExtendLastCol = true;
			this.oOO.0O0_00_0O0.().Location = new Point(17, 16);
			this.oOO.0O0_00_0O0.().Name = "DataMapGrid";
			this.oOO.0O0_00_0O0.().Rows.Count = 1;
			this.oOO.0O0_00_0O0.().Rows.DefaultSize = 20;
			this.oOO.0O0_00_0O0.().Size = new Size(519, 273);
			this.oOO.0O0_00_0O0.().TabIndex = 0;
			this.OoO0o._0O_OO.().Controls.Add(this.oOO.0.());
			this.OoO0o._0O_OO.().Controls.Add(this.oOO.0.());
			this.OoO0o._0O_OO.().Controls.Add(this.Ooo_o0.0oo_.());
			this.OoO0o._0O_OO.().Controls.Add(this.OOoo._Oo_.());
			this.OoO0o._0O_OO.().Controls.Add(this.O0_o.O.());
			this.OoO0o._0O_OO.().Controls.Add(this.o.0___o0_0Oo.());
			this.OoO0o._0O_OO.().Controls.Add(this.OoO0o._0O_OO.());
			this.OoO0o._0O_OO.().Controls.Add(this.O_.O00oo.());
			this.OoO0o._0O_OO.().Controls.Add(this.OoO0o._0O_OO.());
			this.OoO0o._0O_OO.().Location = new Point(1, 25);
			this.OoO0o._0O_OO.().Name = "MultiDataMapPage";
			this.OoO0o._0O_OO.().Size = new Size(556, 457);
			this.OoO0o._0O_OO.().TabIndex = 7;
			this.OoO0o._0O_OO.().TabVisible = false;
			this.OoO0o._0O_OO.().Text = "数据字典";
			this.oOO.0.().BackColor = Color.FromArgb(232, 234, 236);
			this.oOO.0.().BorderColor = Color.FromArgb(169, 177, 184);
			this.oOO.0.().BorderStyle = BorderStyle.FixedSingle;
			this.oOO.0.().Calculator.BackColor = Color.FromArgb(240, 241, 242);
			this.oOO.0.().Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
			this.oOO.0.().Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
			this.oOO.0.().DataType = typeof(int);
			this.oOO.0.().ImagePadding = new Padding(0);
			this.oOO.0.().Location = new Point(314, 306);
			this.oOO.0.().Name = "MultiDataMapValueCol";
			this.oOO.0.().PostValidation.Intervals.AddRange(new ValueInterval[]
			{
				new ValueInterval(0, 24, true, true)
			});
			this.oOO.0.().Size = new Size(40, 19);
			this.oOO.0.().TabIndex = 9;
			this.oOO.0.().Tag = null;
			this.oOO.0.().VisibleButtons = DropDownControlButtonFlags.UpDown;
			this.oOO.0.().AutoSize = true;
			this.oOO.0.().Location = new Point(237, 310);
			this.oOO.0.().Name = "Label4";
			this.oOO.0.().Size = new Size(71, 12);
			this.oOO.0.().TabIndex = 8;
			this.oOO.0.().Text = "取值列位置:";
			this.Ooo_o0.0oo_.().Location = new Point(393, 305);
			this.Ooo_o0.0oo_.().Name = "btnAdd";
			this.Ooo_o0.0oo_.().Size = new Size(68, 23);
			this.Ooo_o0.0oo_.().TabIndex = 6;
			this.Ooo_o0.0oo_.().Text = "插入行";
			this.Ooo_o0.0oo_.().UseVisualStyleBackColor = true;
			this.OOoo._Oo_.().BackColor = Color.FromArgb(232, 234, 236);
			this.OOoo._Oo_.().BorderColor = Color.FromArgb(169, 177, 184);
			this.OOoo._Oo_.().BorderStyle = BorderStyle.FixedSingle;
			this.OOoo._Oo_.().Calculator.BackColor = Color.FromArgb(240, 241, 242);
			this.OOoo._Oo_.().Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
			this.OOoo._Oo_.().Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
			this.OOoo._Oo_.().DataType = typeof(int);
			this.OOoo._Oo_.().ImagePadding = new Padding(0);
			this.OOoo._Oo_.().Location = new Point(68, 306);
			this.OOoo._Oo_.().Name = "MultiDataMapCols";
			this.OOoo._Oo_.().PostValidation.Intervals.AddRange(new ValueInterval[]
			{
				new ValueInterval(1, 25, true, true)
			});
			this.OOoo._Oo_.().Size = new Size(40, 19);
			this.OOoo._Oo_.().TabIndex = 2;
			this.OOoo._Oo_.().Tag = null;
			this.OOoo._Oo_.().Value = 3;
			this.OOoo._Oo_.().VisibleButtons = DropDownControlButtonFlags.UpDown;
			this.O0_o.O.().AutoSize = true;
			this.O0_o.O.().Location = new Point(15, 310);
			this.O0_o.O.().Name = "Label3";
			this.O0_o.O.().Size = new Size(47, 12);
			this.O0_o.O.().TabIndex = 1;
			this.O0_o.O.().Text = "总列数:";
			this.o.0___o0_0Oo.().Location = new Point(467, 305);
			this.o.0___o0_0Oo.().Name = "btnDelete";
			this.o.0___o0_0Oo.().Size = new Size(68, 23);
			this.o.0___o0_0Oo.().TabIndex = 7;
			this.o.0___o0_0Oo.().Text = "删除行";
			this.o.0___o0_0Oo.().UseVisualStyleBackColor = true;
			this.OoO0o._0O_OO.().BackColor = Color.FromArgb(232, 234, 236);
			this.OoO0o._0O_OO.().BorderColor = Color.FromArgb(169, 177, 184);
			this.OoO0o._0O_OO.().BorderStyle = BorderStyle.FixedSingle;
			this.OoO0o._0O_OO.().Calculator.BackColor = Color.FromArgb(240, 241, 242);
			this.OoO0o._0O_OO.().Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
			this.OoO0o._0O_OO.().Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver;
			this.OoO0o._0O_OO.().DataType = typeof(int);
			this.OoO0o._0O_OO.().ImagePadding = new Padding(0);
			this.OoO0o._0O_OO.().Location = new Point(191, 306);
			this.OoO0o._0O_OO.().Name = "MultiDataMapDisplayCol";
			this.OoO0o._0O_OO.().PostValidation.Intervals.AddRange(new ValueInterval[]
			{
				new ValueInterval(0, 24, true, true)
			});
			this.OoO0o._0O_OO.().Size = new Size(40, 19);
			this.OoO0o._0O_OO.().TabIndex = 4;
			this.OoO0o._0O_OO.().Tag = null;
			this.OoO0o._0O_OO.().VisibleButtons = DropDownControlButtonFlags.UpDown;
			this.O_.O00oo.().AutoSize = true;
			this.O_.O00oo.().Location = new Point(114, 310);
			this.O_.O00oo.().Name = "Label2";
			this.O_.O00oo.().Size = new Size(71, 12);
			this.O_.O00oo.().TabIndex = 3;
			this.O_.O00oo.().Text = "显示列位置:";
			this.OoO0o._0O_OO.().ColumnInfo = "3,0,0,0,0,0,Columns:0{Width:100;}\t1{Width:100;}\t2{Width:100;}\t";
			this.OoO0o._0O_OO.().DrawMode = DrawModeEnum.OwnerDraw;
			this.OoO0o._0O_OO.().Location = new Point(17, 16);
			this.OoO0o._0O_OO.().Name = "MultiDataMapGrid";
			this.OoO0o._0O_OO.().Rows.Count = 1;
			this.OoO0o._0O_OO.().Rows.DefaultSize = 20;
			this.OoO0o._0O_OO.().Size = new Size(518, 272);
			this.OoO0o._0O_OO.().TabIndex = 0;
			this.Ooo.o.().Controls.Add(this.o__0O_.00O.());
			this.Ooo.o.().Controls.Add(this.ooo0.oO_0.());
			this.Ooo.o.().Controls.Add(this.o0.oo_oO.());
			this.Ooo.o.().Controls.Add(this.oOOO._OO0OO.());
			this.Ooo.o.().Location = new Point(1, 25);
			this.Ooo.o.().Name = "ImageMapPage";
			this.Ooo.o.().Size = new Size(556, 457);
			this.Ooo.o.().TabIndex = 5;
			this.Ooo.o.().TabVisible = false;
			this.Ooo.o.().Text = "图片字典";
			this.o__0O_.00O.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.o__0O_.00O.().ColumnInfo = "2,0,0,40,0,0,Columns:0{Width:152;Caption:\"值\";}\t1{Caption:\"图片\";Style:\"ComboList:\"\"...\"\";\";}\t";
			this.o__0O_.00O.().DrawMode = DrawModeEnum.OwnerDraw;
			this.o__0O_.00O.().ExtendLastCol = true;
			this.o__0O_.00O.().Location = new Point(18, 18);
			this.o__0O_.00O.().Name = "ImageMapGrid";
			this.o__0O_.00O.().Rows.Count = 1;
			this.o__0O_.00O.().Rows.DefaultSize = 20;
			this.o__0O_.00O.().Size = new Size(516, 277);
			this.o__0O_.00O.().TabIndex = 0;
			this.ooo0.oO_0.().Location = new Point(376, 311);
			this.ooo0.oO_0.().Name = "btnAddRows2";
			this.ooo0.oO_0.().Size = new Size(75, 23);
			this.ooo0.oO_0.().TabIndex = 2;
			this.ooo0.oO_0.().Text = "插入行";
			this.ooo0.oO_0.().UseVisualStyleBackColor = true;
			this.o0.oo_oO.().AutoSize = true;
			this.o0.oo_oO.().BackColor = Color.Transparent;
			this.o0.oo_oO.().BorderColor = Color.Transparent;
			this.o0.oo_oO.().BorderStyle = BorderStyle.None;
			this.o0.oo_oO.().ForeColor = Color.Black;
			this.o0.oo_oO.().Location = new Point(18, 311);
			this.o0.oo_oO.().Name = "OnlyShowImage";
			this.o0.oo_oO.().Padding = new Padding(1, 1, 1, 1);
			this.o0.oo_oO.().Size = new Size(86, 18);
			this.o0.oo_oO.().TabIndex = 1;
			this.o0.oo_oO.().Text = "仅显示图片";
			this.o0.oo_oO.().UseVisualStyleBackColor = true;
			this.o0.oo_oO.().Value = null;
			this.oOOO._OO0OO.().Location = new Point(457, 311);
			this.oOOO._OO0OO.().Name = "btnDeleteRows2";
			this.oOOO._OO0OO.().Size = new Size(77, 23);
			this.oOOO._OO0OO.().TabIndex = 3;
			this.oOOO._OO0OO.().Text = "删除行";
			this.oOOO._OO0OO.().UseVisualStyleBackColor = true;
			this.o_o0_.Oo_00O0.().DialogResult = DialogResult.Cancel;
			this.o_o0_.Oo_00O0.().Location = new Point(294, 513);
			this.o_o0_.Oo_00O0.().Name = "btnCancel";
			this.o_o0_.Oo_00O0.().Size = new Size(75, 23);
			this.o_o0_.Oo_00O0.().TabIndex = 2;
			this.o_o0_.Oo_00O0.().Text = "取消";
			this.o_o0_.Oo_00O0.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(583, 548);
			base.Controls.Add(this.o_o0_.Oo_00O0.());
			base.Controls.Add(this.OO0_o._o.());
			base.Controls.Add(this.o0.0o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.o_oo.l.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "列属性";
			((ISupportInitialize)this.OO0_o._o.()).EndInit();
			this.o0.oo_oO.().ResumeLayout(false);
			this.o0.oo_oO.().PerformLayout();
			((ISupportInitialize)this.o0O.00_0o_Ooo.()).EndInit();
			((ISupportInitialize)this.oOO.0O0_00_0O0.()).EndInit();
			((ISupportInitialize)this.o0.oo_oO.()).EndInit();
			((ISupportInitialize)this.O0O_o.0_o0O.()).EndInit();
			((ISupportInitialize)this.o0.oo_oO.()).EndInit();
			((ISupportInitialize)this.Oo.0o0_O0O.()).EndInit();
			((ISupportInitialize)this.o0.0o.()).EndInit();
			this.o0.0o.().ResumeLayout(false);
			this.O.O__oOo0_.().ResumeLayout(false);
			this.oOO.0O0_00_0O0.().ResumeLayout(false);
			((ISupportInitialize)this.o0.0o.()).EndInit();
			((ISupportInitialize)this.O.Oo_O0o.()).EndInit();
			((ISupportInitialize)this.oOO.0O0_00_0O0.()).EndInit();
			this.OoO0o._0O_OO.().ResumeLayout(false);
			this.OoO0o._0O_OO.().PerformLayout();
			((ISupportInitialize)this.oOO.0.()).EndInit();
			((ISupportInitialize)this.Ooo_o0.0oo_.()).EndInit();
			((ISupportInitialize)this.OOoo._Oo_.()).EndInit();
			((ISupportInitialize)this.o.0___o0_0Oo.()).EndInit();
			((ISupportInitialize)this.OoO0o._0O_OO.()).EndInit();
			((ISupportInitialize)this.OoO0o._0O_OO.()).EndInit();
			this.Ooo.o.().ResumeLayout(false);
			this.Ooo.o.().PerformLayout();
			((ISupportInitialize)this.o__0O_.00O.()).EndInit();
			((ISupportInitialize)this.ooo0.oO_0.()).EndInit();
			((ISupportInitialize)this.o0.oo_oO.()).EndInit();
			((ISupportInitialize)this.oOOO._OO0OO.()).EndInit();
			((ISupportInitialize)this.o_o0_.Oo_00O0.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x0016D5AD File Offset: 0x0016B7AD
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOoOOoO0_.oo.;
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x0016D5B8 File Offset: 0x0016B7B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_0_o.0oo.);
			C1Button c1Button = this.oOoOOoO0_.oo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOoOOoO0_.oo. = A_0;
			c1Button = this.oOoOOoO0_.oo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x0016D5FB File Offset: 0x0016B7FB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOoooo.O0O_.;
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x0016D604 File Offset: 0x0016B804
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_oO._.);
			C1Button c1Button = this.oOoooo.O0O_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOoooo.O0O_. = A_0;
			c1Button = this.oOoooo.O0O_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x0016D647 File Offset: 0x0016B847
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.O_.00_o0ooO.;
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x0016D64F File Offset: 0x0016B84F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.O_.00_o0ooO. = A_0;
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x0016D658 File Offset: 0x0016B858
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O0o.OOOo00Ooo.;
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x0016D660 File Offset: 0x0016B860
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.O0o.OOOo00Ooo. = A_0;
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x0016D669 File Offset: 0x0016B869
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0.__.;
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x0016D671 File Offset: 0x0016B871
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0.__. = A_0;
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x0016D67A File Offset: 0x0016B87A
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O.O0O_oo_.;
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x0016D682 File Offset: 0x0016B882
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.O.O0O_oo_. = A_0;
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x0016D68B File Offset: 0x0016B88B
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.O_ooOo__oO_.;
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x0016D693 File Offset: 0x0016B893
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.O_ooOo__oO_. = A_0;
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x0016D69C File Offset: 0x0016B89C
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.O0o.OOOo00Ooo.;
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x0016D6A4 File Offset: 0x0016B8A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			this.O0o.OOOo00Ooo. = A_0;
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x0016D6AD File Offset: 0x0016B8AD
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o00O0_O0_O.0.;
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x0016D6B5 File Offset: 0x0016B8B5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o00O0_O0_O.0. = A_0;
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x0016D6BE File Offset: 0x0016B8BE
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.Oo0.Oo___o0.;
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x0016D6C8 File Offset: 0x0016B8C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O.Oo0OoOOoO.);
			C1ComboBox oo0.Oo___o0. = this.Oo0.Oo___o0.;
			if (oo0.Oo___o0. != null)
			{
				oo0.Oo___o0..SelectedIndexChanged -= value;
			}
			this.Oo0.Oo___o0. = A_0;
			oo0.Oo___o0. = this.Oo0.Oo___o0.;
			if (oo0.Oo___o0. != null)
			{
				oo0.Oo___o0..SelectedIndexChanged += value;
			}
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x0016D70B File Offset: 0x0016B90B
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.O0o.OOOo00Ooo.;
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x0016D713 File Offset: 0x0016B913
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			this.O0o.OOOo00Ooo. = A_0;
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x0016D71C File Offset: 0x0016B91C
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.oO.o_o_000_Oo0.;
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x0016D724 File Offset: 0x0016B924
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.oO.o_o_000_Oo0. = A_0;
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x0016D72D File Offset: 0x0016B92D
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O0o.OOOo00Ooo.;
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x0016D735 File Offset: 0x0016B935
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.O0o.OOOo00Ooo. = A_0;
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x0016D73E File Offset: 0x0016B93E
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo0.Oo___o0.;
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x0016D748 File Offset: 0x0016B948
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o__Oo.0OoO_.);
			C1Button oo0.Oo___o0. = this.Oo0.Oo___o0.;
			if (oo0.Oo___o0. != null)
			{
				oo0.Oo___o0..Click -= value;
			}
			this.Oo0.Oo___o0. = A_0;
			oo0.Oo___o0. = this.Oo0.Oo___o0.;
			if (oo0.Oo___o0. != null)
			{
				oo0.Oo___o0..Click += value;
			}
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x0016D78B File Offset: 0x0016B98B
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.o00O0_O0_O.0.;
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x0016D793 File Offset: 0x0016B993
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.o00O0_O0_O.0. = A_0;
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x0016D79C File Offset: 0x0016B99C
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_OOO0O.O.;
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x0016D7A4 File Offset: 0x0016B9A4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo._o0o_.);
			C1Button c1Button = this.o_OOO0O.O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_OOO0O.O. = A_0;
			c1Button = this.o_OOO0O.O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x0016D7E7 File Offset: 0x0016B9E7
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.o.__00Oo0.;
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x0016D7F0 File Offset: 0x0016B9F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.o0.oo_oO.);
			OwnerDrawCellEventHandler value2 = new OwnerDrawCellEventHandler(this.o0O.00_0o_Ooo.);
			C1FlexGrid c1FlexGrid = this.o.__00Oo0.;
			if (c1FlexGrid != null)
			{
				c1FlexGrid.CellButtonClick -= value;
				c1FlexGrid.OwnerDrawCell -= value2;
			}
			this.o.__00Oo0. = A_0;
			c1FlexGrid = this.o.__00Oo0.;
			if (c1FlexGrid != null)
			{
				c1FlexGrid.CellButtonClick += value;
				c1FlexGrid.OwnerDrawCell += value2;
			}
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x0016D84E File Offset: 0x0016BA4E
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0_O_ooO00o_.o.;
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x0016D858 File Offset: 0x0016BA58
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_oo_O._o.);
			C1Button o0_O_ooO00o_.o. = this.O0_O_ooO00o_.o.;
			if (o0_O_ooO00o_.o. != null)
			{
				o0_O_ooO00o_.o..Click -= value;
			}
			this.O0_O_ooO00o_.o. = A_0;
			o0_O_ooO00o_.o. = this.O0_O_ooO00o_.o.;
			if (o0_O_ooO00o_.o. != null)
			{
				o0_O_ooO00o_.o..Click += value;
			}
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x0016D89B File Offset: 0x0016BA9B
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_.00_o0ooO.;
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x0016D8A3 File Offset: 0x0016BAA3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O_.00_o0ooO. = A_0;
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x0016D8AC File Offset: 0x0016BAAC
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.OoO0o.;
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x0016D8B4 File Offset: 0x0016BAB4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.OoO0o. = A_0;
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x0016D8BD File Offset: 0x0016BABD
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O0.__.;
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x0016D8C8 File Offset: 0x0016BAC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.o.000.);
			C1CheckBox o0.__. = this.O0.__.;
			if (o0.__. != null)
			{
				o0.__..CheckedChanged -= value;
			}
			this.O0.__. = A_0;
			o0.__. = this.O0.__.;
			if (o0.__. != null)
			{
				o0.__..CheckedChanged += value;
			}
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x0016D90B File Offset: 0x0016BB0B
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o._0_ooO0o.;
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x0016D913 File Offset: 0x0016BB13
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.o._0_ooO0o. = A_0;
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x0016D91C File Offset: 0x0016BB1C
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o.__00Oo0.;
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x0016D924 File Offset: 0x0016BB24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.o.__00Oo0. = A_0;
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x0016D92D File Offset: 0x0016BB2D
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.ooOO.0O.;
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x0016D935 File Offset: 0x0016BB35
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.ooOO.0O. = A_0;
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x0016D93E File Offset: 0x0016BB3E
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.O0.__.;
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x0016D948 File Offset: 0x0016BB48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyValueChangedEventHandler value = new PropertyValueChangedEventHandler(this.Ooo0oOO0.oO0.);
			PropertyGrid o0.__. = this.O0.__.;
			if (o0.__. != null)
			{
				o0.__..PropertyValueChanged -= value;
			}
			this.O0.__. = A_0;
			o0.__. = this.O0.__.;
			if (o0.__. != null)
			{
				o0.__..PropertyValueChanged += value;
			}
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x0016D98B File Offset: 0x0016BB8B
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O.O0O_oo_.;
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x0016D993 File Offset: 0x0016BB93
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O.O0O_oo_. = A_0;
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x0016D99C File Offset: 0x0016BB9C
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_.__.;
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x0016D9A4 File Offset: 0x0016BBA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_.__. = A_0;
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x0016D9AD File Offset: 0x0016BBAD
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.o_ooo._0O_O0.;
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x0016D9B5 File Offset: 0x0016BBB5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.o_ooo._0O_O0. = A_0;
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x0016D9BE File Offset: 0x0016BBBE
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.OO.o0oo.;
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x0016D9C8 File Offset: 0x0016BBC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			OwnerDrawCellEventHandler value = new OwnerDrawCellEventHandler(this.Ooo0oOO0.oO0.);
			C1FlexGrid oo.o0oo. = this.OO.o0oo.;
			if (oo.o0oo. != null)
			{
				oo.o0oo..OwnerDrawCell -= value;
			}
			this.OO.o0oo. = A_0;
			oo.o0oo. = this.OO.o0oo.;
			if (oo.o0oo. != null)
			{
				oo.o0oo..OwnerDrawCell += value;
			}
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x0016DA0B File Offset: 0x0016BC0B
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.O0.__.;
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x0016DA14 File Offset: 0x0016BC14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			EventHandler value = new EventHandler(this.o__._O0.);
			C1NumericEdit o0.__. = this.O0.__.;
			if (o0.__. != null)
			{
				o0.__..ValueChanged -= value;
			}
			this.O0.__. = A_0;
			o0.__. = this.O0.__.;
			if (o0.__. != null)
			{
				o0.__..ValueChanged += value;
			}
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x0016DA57 File Offset: 0x0016BC57
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Ooo._.;
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x0016DA5F File Offset: 0x0016BC5F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Ooo._. = A_0;
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x0016DA68 File Offset: 0x0016BC68
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.o.O_ooOo__oO_.;
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x0016DA70 File Offset: 0x0016BC70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			EventHandler value = new EventHandler(this.oo.O_0Oo00__.);
			C1NumericEdit c1NumericEdit = this.o.O_ooOo__oO_.;
			if (c1NumericEdit != null)
			{
				c1NumericEdit.ValueChanged -= value;
			}
			this.o.O_ooOo__oO_. = A_0;
			c1NumericEdit = this.o.O_ooOo__oO_.;
			if (c1NumericEdit != null)
			{
				c1NumericEdit.ValueChanged += value;
			}
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x0016DAB3 File Offset: 0x0016BCB3
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.0O0.;
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x0016DABB File Offset: 0x0016BCBB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.0O0. = A_0;
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x0016DAC4 File Offset: 0x0016BCC4
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo_O.o_.;
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x0016DACC File Offset: 0x0016BCCC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO._0.);
			C1Button c1Button = this.oo_O.o_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo_O.o_. = A_0;
			c1Button = this.oo_O.o_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x0016DB0F File Offset: 0x0016BD0F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OoO.oo_0.;
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x0016DB18 File Offset: 0x0016BD18
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOoo.oO0Oo0.);
			C1Button ooO.oo_0. = this.OoO.oo_0.;
			if (ooO.oo_0. != null)
			{
				ooO.oo_0..Click -= value;
			}
			this.OoO.oo_0. = A_0;
			ooO.oo_0. = this.OoO.oo_0.;
			if (ooO.oo_0. != null)
			{
				ooO.oo_0..Click += value;
			}
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x0016DB5B File Offset: 0x0016BD5B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo._Oo0.;
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x0016DB64 File Offset: 0x0016BD64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Ooo__o._o_o0_.);
			C1Button oo._Oo0. = this.Oo._Oo0.;
			if (oo._Oo0. != null)
			{
				oo._Oo0..Click -= value;
			}
			this.Oo._Oo0. = A_0;
			oo._Oo0. = this.Oo._Oo0.;
			if (oo._Oo0. != null)
			{
				oo._Oo0..Click += value;
			}
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x0016DBA7 File Offset: 0x0016BDA7
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.OO.o0oo.;
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x0016DBAF File Offset: 0x0016BDAF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			this.OO.o0oo. = A_0;
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x0016DBB8 File Offset: 0x0016BDB8
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0__0OOO._0.;
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x0016DBC0 File Offset: 0x0016BDC0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0__0OOO._0. = A_0;
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x0016DBC9 File Offset: 0x0016BDC9
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.0_0oO0.;
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x0016DBD4 File Offset: 0x0016BDD4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0_0O_O0.O_O0.);
			C1Button c1Button = this.o.0_0oO0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.0_0oO0. = A_0;
			c1Button = this.o.0_0oO0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x0016DC18 File Offset: 0x0016BE18
		public g2(DataCol A_0)
		{
			base.Load += this.o0O_.oO0_.;
			base.FormClosed += this.Oo._0oOoo0.;
			this.o0.oo_oO.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
			{
				this.o0.0o.()
			});
			foreach (C1FlexGrid c1FlexGrid in new C1FlexGrid[]
			{
				this.oOO.0O0_00_0O0.(),
				this.o__0O_.00O.(),
				this.OoO0o._0O_OO.()
			})
			{
				c1FlexGrid.Styles.SelectedColumnHeader.Clear();
				c1FlexGrid.Styles.Alternate.Clear();
				c1FlexGrid.Styles.Focus.Clear();
				c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal);
				c1FlexGrid.FocusRect = FocusRectEnum.Solid;
				c1FlexGrid.AllowSorting = AllowSortingEnum.None;
			}
			this.O_.00_o0ooO. = A_0.Setting;
			this.O_.00_o0ooO. = A_0;
			this.O_.00_o0ooO. = o_O_o_oOoo__.OOOO_OO._oo.(this.O_.00_o0ooO., false, '\v', false);
			this.O_.00_o0ooO. = this.O_.00_o0ooO..Decimals;
			this.o__0O_.00O.().CellButtonImage = a.O0__0.Oo0oo_.().ToBitmap();
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable == A_0.DataTable)
					{
						table.CloseRecordGrid();
						if (table.Cols.Contains(A_0.Name))
						{
							table.Cols[A_0.Name].CloseWindow();
						}
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x0016DDE0 File Offset: 0x0016BFE0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num13;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.o0.oo_oO.().Value = this.O_.00_o0ooO..DataMapFilter;
				IL_1F:
				num2 = 3;
				this.o0O.00_0o_Ooo.().Value = this.O_.00_o0ooO..DataMapSort;
				IL_37:
				num2 = 4;
				this.o0.oo_oO.().Checked = !this.O_.00_o0ooO..ImageAndText;
				IL_52:
				num2 = 5;
				if (Operators.CompareString(this.O_.00_o0ooO..DataMap, "", true) <= 0)
				{
					goto IL_C9;
				}
				IL_6D:
				num2 = 6;
				string[] array = this.O_.00_o0ooO..DataMap.Split(new char[]
				{
					this.oOO.0O0_00_0O0.().ClipSeparators[1]
				});
				IL_9A:
				num2 = 7;
				int num3 = array.Length - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_A8:
					num2 = 8;
					this.oOO.0O0_00_0O0.().AddItem(array[i]);
					IL_BA:
					num2 = 9;
				}
				IL_C9:
				num2 = 10;
				this.oOO.0O0_00_0O0.().AllowAddNew = true;
				IL_D8:
				num2 = 11;
				if (Operators.CompareString(this.O_.00_o0ooO..MultiDataMap, "", true) <= 0)
				{
					goto IL_218;
				}
				IL_F7:
				num2 = 12;
				string[] array2 = this.O_.00_o0ooO..MultiDataMap.Split(new char[]
				{
					this.OoO0o._0O_OO.().ClipSeparators[1]
				});
				IL_126:
				num2 = 13;
				this.OoO0o._0O_OO.().Cols.Count = array2[0].Split(new char[]
				{
					this.OoO0o._0O_OO.().ClipSeparators[0]
				}).Length;
				IL_15E:
				num2 = 14;
				int num4 = array2.Length - 1;
				for (int j = 0; j <= num4; j++)
				{
					IL_16E:
					num2 = 15;
					this.OoO0o._0O_OO.().AddItem(array2[j]);
					IL_182:
					num2 = 16;
				}
				IL_191:
				num2 = 17;
				int num5 = this.OoO0o._0O_OO.().Cols.Count - 1;
				for (int k = 0; k <= num5; k++)
				{
					IL_1AD:
					num2 = 18;
					if (this.OoO0o._0O_OO.().Cols[k].Width <= 0)
					{
						IL_1CA:
						num2 = 19;
						this.OoO0o._0O_OO.().Cols[k].Width = 100;
					}
					IL_1E6:
					num2 = 20;
				}
				IL_1F5:
				num2 = 21;
				this.OOoo._Oo_.().Value = this.OoO0o._0O_OO.().Cols.Count;
				IL_218:
				num2 = 22;
				this.OoO0o._0O_OO.().AllowAddNew = true;
				IL_227:
				num2 = 23;
				this.OoO0o._0O_OO.().Value = this.O_.00_o0ooO..MultiDataMapDisplayCol;
				IL_245:
				num2 = 24;
				this.oOO.0.().Value = this.O_.00_o0ooO..MultiDataMapValueCol;
				IL_263:
				num2 = 25;
				if (Operators.CompareString(this.O_.00_o0ooO..ImageMap, "", true) <= 0)
				{
					goto IL_2E1;
				}
				IL_27F:
				num2 = 26;
				string[] array3 = this.O_.00_o0ooO..ImageMap.Split(new char[]
				{
					this.o__0O_.00O.().ClipSeparators[1]
				});
				IL_2AE:
				num2 = 27;
				int num6 = array3.Length - 1;
				for (int l = 0; l <= num6; l++)
				{
					IL_2BE:
					num2 = 28;
					this.o__0O_.00O.().AddItem(array3[l]);
					IL_2D2:
					num2 = 29;
				}
				IL_2E1:
				num2 = 30;
				this.o__0O_.00O.().AllowAddNew = true;
				IL_2F0:
				num2 = 31;
				IEnumerator enumerator = O_O0OO.OOOo.oo_OOOO_0.().Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataTable dataTable = (DataTable)obj;
					IL_314:
					num2 = 32;
					this.Oo.0o0_O0O.().Items.Add(dataTable.TableName);
					IL_32F:
					num2 = 33;
					if (Operators.CompareString(dataTable.TableName, this.O_.00_o0ooO..DataMapTable, true) == 0)
					{
						IL_34C:
						num2 = 34;
						this.Oo.0o0_O0O.().SelectedIndex = this.Oo.0o0_O0O.().Items.Count - 1;
					}
					IL_36C:
					num2 = 35;
				}
				IL_378:
				num2 = 36;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_390:
				num2 = 37;
				if (Operators.CompareString(this.O_.00_o0ooO..DataMapListColumns, "", true) != 0)
				{
					goto IL_3BF;
				}
				IL_3AB:
				num2 = 38;
				this.O0O_o.0_o0O.().Checked = true;
				goto IL_47F;
				IL_3BF:
				num2 = 40;
				string[] array4 = this.O_.00_o0ooO..DataMapListColumns.Split(new char[]
				{
					','
				});
				IL_3DF:
				num2 = 41;
				foreach (string text in array4)
				{
					IL_3F2:
					num2 = 42;
					int num7 = this.o__0O_.00O.().Items.Count - 1;
					for (int n = 0; n <= num7; n++)
					{
						IL_40E:
						num2 = 43;
						if (Operators.CompareString(text.ToLower(), this.o__0O_.00O.().Items[n].ToString().ToLower(), true) == 0)
						{
							IL_43C:
							num2 = 44;
							this.o__0O_.00O.().SetItemChecked(n, true);
						}
						IL_44D:
						num2 = 45;
					}
					IL_45C:
					num2 = 46;
				}
				IL_470:
				num2 = 47;
				this.o__0O_.00O.().Checked = true;
				IL_47F:
				num2 = 48;
				if (Operators.CompareString(this.O_.00_o0ooO..DataMapValueColumn, "", true) <= 0)
				{
					goto IL_50F;
				}
				IL_49B:
				num2 = 49;
				int num8 = this.o0.oo_oO.().Items.Count - 1;
				for (int num9 = 0; num9 <= num8; num9++)
				{
					IL_4B7:
					num2 = 50;
					if (Operators.CompareString(this.O_.00_o0ooO..DataMapValueColumn.ToLower(), this.o0.oo_oO.().Items[num9].ToString().ToLower(), true) == 0)
					{
						IL_4EE:
						num2 = 51;
						this.o0.oo_oO.().SelectedIndex = num9;
						break;
					}
					IL_500:
					num2 = 53;
				}
				IL_50F:
				num2 = 54;
				if (Operators.CompareString(this.O_.00_o0ooO..DataMapListColumn, "", true) <= 0)
				{
					goto IL_59F;
				}
				IL_52B:
				num2 = 55;
				int num10 = this.O0O_o.0_o0O.().Items.Count - 1;
				for (int num11 = 0; num11 <= num10; num11++)
				{
					IL_547:
					num2 = 56;
					if (Operators.CompareString(this.O_.00_o0ooO..DataMapListColumn.ToLower(), this.O0O_o.0_o0O.().Items[num11].ToString().ToLower(), true) == 0)
					{
						IL_57E:
						num2 = 57;
						this.O0O_o.0_o0O.().SelectedIndex = num11;
						break;
					}
					IL_590:
					num2 = 59;
				}
				IL_59F:
				num2 = 60;
				if (this.O_.00_o0ooO..ImageMapType != ImageMapTypeEnum.有)
				{
					goto IL_5BF;
				}
				IL_5B0:
				num2 = 61;
				this.Ooo.o.().TabVisible = true;
				IL_5BF:
				num2 = 62;
				if (this.O_.00_o0ooO..DataMapType != DataMapTypeEnum.数据表)
				{
					goto IL_5E4;
				}
				IL_5D0:
				num2 = 63;
				this.o0.oo_oO.().TabVisible = true;
				goto IL_694;
				IL_5E4:
				num2 = 65;
				if (this.O_.00_o0ooO..DataMapType != DataMapTypeEnum.标准 && this.O_.00_o0ooO..DataMapType != DataMapTypeEnum.代码项目)
				{
					goto IL_674;
				}
				IL_603:
				num2 = 66;
				this.oOO.0O0_00_0O0.().TabVisible = true;
				IL_612:
				num2 = 67;
				if (this.O_.00_o0ooO..DataMapType != DataMapTypeEnum.代码项目)
				{
					goto IL_694;
				}
				IL_623:
				num2 = 68;
				this.oOO.0O0_00_0O0.().Cols[0].Caption = "代码";
				IL_641:
				num2 = 69;
				this.oOO.0O0_00_0O0.().Cols[1].Caption = "对应值";
				IL_65F:
				num2 = 70;
				this.oOO.0O0_00_0O0.().Text = "代码项目";
				goto IL_694;
				IL_674:
				num2 = 72;
				if (this.O_.00_o0ooO..DataMapType != DataMapTypeEnum.多列)
				{
					goto IL_694;
				}
				IL_685:
				num2 = 73;
				this.OoO0o._0O_OO.().TabVisible = true;
				IL_694:
				num2 = 74;
				this.o0.oo_oO.().SelectedObject = new o_0oooo_OO(this.O_.00_o0ooO., new string[0], false, false);
				IL_6B5:
				num2 = 75;
				this.o0.0o.().SelectedTab = this.o0.0o.().TabPages[0];
				IL_6D4:
				goto IL_856;
				IL_6D9:
				int num12 = num13 + 1;
				num13 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num12);
				IL_817:
				goto IL_84B;
				IL_819:
				num13 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_829:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num13 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_819;
			}
			IL_84B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_856:
			if (num13 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x0016E668 File Offset: 0x0016C868
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable == this.O_.00_o0ooO..DataTable && table.Grid.Cols.Contains(this.O_.00_o0ooO..Name))
					{
						table.Grid.Cols[this.O_.00_o0ooO..Name].ComboList = null;
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			C1FlexGrid c1FlexGrid = this.oOO.0O0_00_0O0.();
			c1FlexGrid.AllowAddNew = false;
			int num = c1FlexGrid.Rows.Count - 1;
			int @fixed = c1FlexGrid.Rows.Fixed;
			for (int i = num; i >= @fixed; i += -1)
			{
				if (Operators.CompareString(c1FlexGrid.GetDataDisplay(i, 0), "", true) == 0)
				{
					c1FlexGrid.RemoveItem(i);
				}
			}
			if (c1FlexGrid.Rows.Count > c1FlexGrid.Rows.Fixed)
			{
				this.O_.00_o0ooO..DataMap = c1FlexGrid.GetCellRange(c1FlexGrid.Rows.Fixed, c1FlexGrid.Cols.Fixed, c1FlexGrid.Rows.Count - 1, c1FlexGrid.Cols.Count - 1).Clip;
			}
			else
			{
				this.O_.00_o0ooO..DataMap = "";
			}
			this.O_.00_o0ooO..MultiDataMapDisplayCol = Math.Min(Conversions.ToInteger(this.OoO0o._0O_OO.().Value), this.OoO0o._0O_OO.().Cols.Count - 1);
			this.O_.00_o0ooO..MultiDataMapValueCol = Math.Min(Conversions.ToInteger(this.oOO.0.().Value), this.OoO0o._0O_OO.().Cols.Count - 1);
			C1FlexGrid c1FlexGrid2 = this.OoO0o._0O_OO.();
			c1FlexGrid2.AllowAddNew = false;
			int num2 = c1FlexGrid2.Rows.Count - 1;
			int fixed2 = c1FlexGrid2.Rows.Fixed;
			for (int j = num2; j >= fixed2; j += -1)
			{
				if (Operators.CompareString(c1FlexGrid2.GetDataDisplay(j, this.O_.00_o0ooO..MultiDataMapValueCol), "", true) == 0)
				{
					c1FlexGrid2.RemoveItem(j);
				}
			}
			if (c1FlexGrid2.Rows.Count > c1FlexGrid2.Rows.Fixed)
			{
				this.O_.00_o0ooO..MultiDataMap = c1FlexGrid2.GetCellRange(c1FlexGrid2.Rows.Fixed, c1FlexGrid2.Cols.Fixed, c1FlexGrid2.Rows.Count - 1, c1FlexGrid2.Cols.Count - 1).Clip;
			}
			else
			{
				this.O_.00_o0ooO..MultiDataMap = "";
			}
			C1FlexGrid c1FlexGrid3 = this.o__0O_.00O.();
			c1FlexGrid3.AllowAddNew = false;
			int num3 = c1FlexGrid3.Rows.Count - 1;
			int fixed3 = c1FlexGrid3.Rows.Fixed;
			for (int k = num3; k >= fixed3; k += -1)
			{
				if (Operators.CompareString(c1FlexGrid3.GetDataDisplay(k, 0), "", true) == 0)
				{
					c1FlexGrid3.RemoveItem(k);
				}
			}
			if (c1FlexGrid3.Rows.Count > c1FlexGrid3.Rows.Fixed)
			{
				this.O_.00_o0ooO..ImageMap = c1FlexGrid3.GetCellRange(c1FlexGrid3.Rows.Fixed, c1FlexGrid3.Cols.Fixed, c1FlexGrid3.Rows.Count - 1, c1FlexGrid3.Cols.Count - 1).Clip;
			}
			else
			{
				this.O_.00_o0ooO..ImageMap = "";
			}
			this.O_.00_o0ooO..DataMapTable = this.Oo.0o0_O0O.().Text;
			this.O_.00_o0ooO..DataMapValueColumn = this.o0.oo_oO.().Text;
			this.O_.00_o0ooO..DataMapListColumn = this.O0O_o.0_o0O.().Text;
			this.O_.00_o0ooO..DataMapListColumns = "";
			this.O_.00_o0ooO..DataMapFilter = this.o0.oo_oO.().Text;
			this.O_.00_o0ooO..DataMapSort = this.o0O.00_0o_Ooo.().Text;
			if (this.o__0O_.00O.().Checked)
			{
				int num4 = this.o__0O_.00O.().Items.Count - 1;
				for (int l = 0; l <= num4; l++)
				{
					if (this.o__0O_.00O.().GetItemChecked(l))
					{
						if (Operators.CompareString(this.O_.00_o0ooO..DataMapListColumns, "", true) > 0)
						{
							this.O_.00_o0ooO..DataMapListColumns = this.O_.00_o0ooO..DataMapListColumns + ",";
						}
						this.O_.00_o0ooO..DataMapListColumns = this.O_.00_o0ooO..DataMapListColumns + this.o__0O_.00O.().Items[l].ToString();
					}
				}
			}
			this.O_.00_o0ooO..Apply();
			if (this.O_.00_o0ooO. != this.O_.00_o0ooO..Decimals && Operators.CompareString(this.O_.00_o0ooO..DataTable.DataServer, "", true) == 0 && !this.O_.00_o0ooO..IsTemporary && (this.O_.00_o0ooO..DataTable.frd_IsInnerTable || (this.O_.00_o0ooO..DataTable.frd_IsOuterTable && !o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.O_.00_o0ooO..DataTable.frd_Connection))) && this.O_.00_o0ooO..BaseColumn.DataType == typeof(decimal))
			{
				OleDbCommand oleDbCommand = new OleDbCommand();
				oleDbCommand.Connection = this.O_.00_o0ooO..DataTable.frd_Connection;
				if (this.O_.00_o0ooO..DataTable.frd_Connection == O_O0OO.OoO.0OO__0ooo.())
				{
					oleDbCommand.CommandText = string.Concat(new string[]
					{
						"ALTER TABLE [~TMPCLP",
						this.O_.00_o0ooO..DataTable.Name,
						"] ALTER COLUMN [",
						this.O_.00_o0ooO..Name,
						"] DECIMAl(28,",
						Conversions.ToString(this.O_.00_o0ooO..Decimals),
						")"
					});
				}
				else if (o_O_o_oOoo__.OOOO_OO._oo.(this.O_.00_o0ooO..DataTable.frd_Connection))
				{
					oleDbCommand.CommandText = string.Concat(new string[]
					{
						"ALTER TABLE [",
						this.O_.00_o0ooO..DataTable.o._OOO0oOo0__..Trim(new char[]
						{
							'[',
							']'
						}),
						"] ALTER COLUMN [",
						this.O_.00_o0ooO..Name,
						"] numeric(28,",
						Conversions.ToString(this.O_.00_o0ooO..Decimals),
						")"
					});
				}
				else
				{
					oleDbCommand.CommandText = string.Concat(new string[]
					{
						"ALTER TABLE [",
						this.O_.00_o0ooO..DataTable.o._OOO0oOo0__..Trim(new char[]
						{
							'[',
							']'
						}),
						"] ALTER COLUMN [",
						this.O_.00_o0ooO..Name,
						"] DECIMAl(28,",
						Conversions.ToString(this.O_.00_o0ooO..Decimals),
						")"
					});
				}
				try
				{
					this.O_.00_o0ooO..DataTable.frd_Connection.Open();
					oleDbCommand.ExecuteNonQuery();
					this.O_.00_o0ooO..DataTable.O_00_._.();
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
				finally
				{
					this.O_.00_o0ooO..DataTable.frd_Connection.Close();
				}
			}
			if (!this.O_.00_o0ooO..DataTable.AddByCode)
			{
				this.O_.00_o0ooO..O.O_OO.(true);
			}
			if (this.O_.00_o0ooO..AutoOpen)
			{
				OO_00oOO.Tables[this.O_.00_o0ooO..BaseColumn.Table.TableName].Cols[this.O_.00_o0ooO..Name].OpenWindow(0);
			}
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x0016EE5C File Offset: 0x0016D05C
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			if (A_1.KeyChar == '|')
			{
				A_1.Handled = true;
			}
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x0016EE70 File Offset: 0x0016D070
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oOO.0O0_00_0O0.().Selection.TopRow >= 1)
			{
				int topRow = this.oOO.0O0_00_0O0.().Selection.TopRow;
				int bottomRow = this.oOO.0O0_00_0O0.().Selection.BottomRow;
				int num = topRow;
				int num2 = bottomRow;
				for (int i = num; i <= num2; i++)
				{
					this.oOO.0O0_00_0O0.().RemoveItem(topRow);
				}
				this.oOO.0O0_00_0O0.().Focus();
			}
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x0016EEE8 File Offset: 0x0016D0E8
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = O_O0OO.o__._oo0O.();
			openFileDialog.FilterIndex = 0;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string text = ooO.oo__.O000_o_O.(openFileDialog.FileName);
				if (Operators.CompareString(text, "", true) > 0)
				{
					this.o__0O_.00O.().SetData(A_1.Row, A_1.Col, text);
				}
			}
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x0016EF50 File Offset: 0x0016D150
		private void <<EMPTY_NAME>>(object A_0, OwnerDrawCellEventArgs A_1)
		{
			if (A_1.Col == 1 && Operators.CompareString(A_1.Text, "", true) > 0)
			{
				A_1.Image = OO_00oOO.GetImage(A_1.Text);
			}
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x0016EF80 File Offset: 0x0016D180
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o__0O_.00O.().Items.Clear();
			this.o0.oo_oO.().Items.Clear();
			this.O0O_o.0_o0O.().Items.Clear();
			this.O0O_o.0_o0O.().Checked = true;
			DataTable dataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables[this.Oo.0o0_O0O.().Text];
			try
			{
				foreach (object obj in dataTable.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (!o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName))
					{
						this.o__0O_.00O.().Items.Add(dataColumn.ColumnName);
						this.O0O_o.0_o0O.().Items.Add(dataColumn.ColumnName);
						this.o0.oo_oO.().Items.Add(dataColumn.ColumnName);
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
			this.o0.oo_oO.().SelectedIndex = 0;
			this.O0O_o.0_o0O.().SelectedIndex = 0;
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x0016F0A0 File Offset: 0x0016D2A0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.Oo.0o0_O0O.().Text, "", true) != 0 && OO_00oOO.DataTables.Contains(this.Oo.0o0_O0O.().Text))
			{
				this.o0.oo_oO.().Value = OO_00oOO.DataTables[this.Oo.0o0_O0O.().Text].OOoo__00O_.o_O.(this.o0.oo_oO.().Text, true);
			}
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x0016F10D File Offset: 0x0016D30D
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this.O_.00_o0ooO., this.O_.00_o0ooO., '\v');
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x0016F124 File Offset: 0x0016D324
		private void <<EMPTY_NAME>>(object A_0, PropertyValueChangedEventArgs A_1)
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
				if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "DataMapType", true) != 0)
				{
					goto IL_154;
				}
				IL_29:
				num2 = 3;
				this.oOO.0O0_00_0O0.().TabVisible = (this.O_.00_o0ooO..DataMapType == DataMapTypeEnum.标准 || this.O_.00_o0ooO..DataMapType == DataMapTypeEnum.代码项目);
				IL_55:
				num2 = 4;
				this.o0.oo_oO.().TabVisible = (this.O_.00_o0ooO..DataMapType == DataMapTypeEnum.数据表);
				IL_70:
				num2 = 5;
				this.OoO0o._0O_OO.().TabVisible = (this.O_.00_o0ooO..DataMapType == DataMapTypeEnum.多列);
				IL_8B:
				num2 = 6;
				if (!this.oOO.0O0_00_0O0.().TabVisible)
				{
					goto IL_28D;
				}
				IL_9D:
				num2 = 7;
				if (this.O_.00_o0ooO..DataMapType != DataMapTypeEnum.标准)
				{
					goto IL_100;
				}
				IL_AD:
				num2 = 8;
				this.oOO.0O0_00_0O0.().Cols[0].Caption = "数据";
				IL_CA:
				num2 = 9;
				this.oOO.0O0_00_0O0.().Cols[1].Caption = "显示值";
				IL_E8:
				num2 = 10;
				this.oOO.0O0_00_0O0.().Text = "数据字典";
				goto IL_28D;
				IL_100:
				num2 = 12;
				this.oOO.0O0_00_0O0.().Cols[0].Caption = "代码";
				IL_11E:
				num2 = 13;
				this.oOO.0O0_00_0O0.().Cols[1].Caption = "对应值";
				IL_13C:
				num2 = 14;
				this.oOO.0O0_00_0O0.().Text = "代码项目";
				goto IL_28D;
				IL_154:
				num2 = 16;
				if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "ImageMapType", true) != 0)
				{
					goto IL_195;
				}
				IL_174:
				num2 = 17;
				this.Ooo.o.().TabVisible = (this.O_.00_o0ooO..ImageMapType == ImageMapTypeEnum.有);
				goto IL_28D;
				IL_195:
				num2 = 19;
				if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "ExtendColumnType", true) != 0 && Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "Remote", true) != 0)
				{
					goto IL_1F8;
				}
				IL_1D2:
				num2 = 20;
				this.o0.oo_oO.().SelectedObject = new o_0oooo_OO(this.O_.00_o0ooO., new string[0], false, false);
				goto IL_28D;
				IL_1F8:
				num2 = 22;
				if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "DefaultValue", true) != 0)
				{
					goto IL_28D;
				}
				IL_218:
				num2 = 23;
				if (Operators.CompareString(this.O_.00_o0ooO..DefaultValue, "", true) <= 0)
				{
					goto IL_28D;
				}
				IL_234:
				num2 = 24;
				if (Conversions.ToBoolean(OO_00oOO.TryEval(this.O_.00_o0ooO..DefaultValue, this.O_.00_o0ooO..DataTable.DataRows[0])))
				{
					goto IL_28D;
				}
				IL_264:
				num2 = 25;
				this.O_.00_o0ooO..DefaultValue = "";
				IL_277:
				num2 = 26;
				MessageBox.Show("默认值表达式无效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_28D:
				goto IL_34B;
				IL_292:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_30C:
				goto IL_340;
				IL_30E:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_31E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_30E;
			}
			IL_340:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_34B:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x0016F4A0 File Offset: 0x0016D6A0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num = this.oOO.0O0_00_0O0.().Row;
			if (num < 1)
			{
				num = 1;
			}
			this.oOO.0O0_00_0O0.().AddItem("", num);
			this.oOO.0O0_00_0O0.().Row = num;
			this.oOO.0O0_00_0O0.().Focus();
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x0016F4EC File Offset: 0x0016D6EC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OoO0o._0O_OO.().Cols.Count = Conversions.ToInteger(this.OOoo._Oo_.().Value);
			int num = this.OoO0o._0O_OO.().Cols.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (this.OoO0o._0O_OO.().Cols[i].Width <= 0)
				{
					this.OoO0o._0O_OO.().Cols[i].Width = 100;
				}
			}
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x0016F56C File Offset: 0x0016D76C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Conversions.ToInteger(this.OoO0o._0O_OO.().Value) > this.OoO0o._0O_OO.().Cols.Count - 1)
			{
				this.OoO0o._0O_OO.().Value = this.OoO0o._0O_OO.().Cols.Count - 1;
			}
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x0016F5C0 File Offset: 0x0016D7C0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num = this.OoO0o._0O_OO.().Row;
			if (num < 1)
			{
				num = 1;
			}
			this.OoO0o._0O_OO.().AddItem("", num);
			this.OoO0o._0O_OO.().Row = num;
			this.OoO0o._0O_OO.().Focus();
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x0016F60C File Offset: 0x0016D80C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OoO0o._0O_OO.().Selection.TopRow >= 1)
			{
				int topRow = this.OoO0o._0O_OO.().Selection.TopRow;
				int bottomRow = this.OoO0o._0O_OO.().Selection.BottomRow;
				int num = topRow;
				int num2 = bottomRow;
				for (int i = num; i <= num2; i++)
				{
					this.OoO0o._0O_OO.().RemoveItem(topRow);
				}
				this.OoO0o._0O_OO.().Focus();
			}
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x0016F681 File Offset: 0x0016D881
		private void <<EMPTY_NAME>>(object A_0, OwnerDrawCellEventArgs A_1)
		{
			if (A_1.Row == 0)
			{
				A_1.Text = "第" + Conversions.ToString(A_1.Col) + "列";
			}
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x0016F6AB File Offset: 0x0016D8AB
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_.00_o0ooO..ImageAndText = !this.o0.oo_oO.().Checked;
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x0016F6C8 File Offset: 0x0016D8C8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o__0O_.00O.().Selection.TopRow >= 1)
			{
				int topRow = this.o__0O_.00O.().Selection.TopRow;
				int bottomRow = this.o__0O_.00O.().Selection.BottomRow;
				int num = topRow;
				int num2 = bottomRow;
				for (int i = num; i <= num2; i++)
				{
					this.o__0O_.00O.().RemoveItem(topRow);
				}
				this.o__0O_.00O.().Focus();
			}
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x0016F740 File Offset: 0x0016D940
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num = this.o__0O_.00O.().Row;
			if (num < 1)
			{
				num = 1;
			}
			this.o__0O_.00O.().AddItem("", num);
			this.o__0O_.00O.().Row = num;
			this.o__0O_.00O.().Focus();
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x0016F789 File Offset: 0x0016D989
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001535 RID: 5429
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001536 RID: 5430
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001537 RID: 5431
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001538 RID: 5432
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x04001539 RID: 5433
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x0400153A RID: 5434
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400153B RID: 5435
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x0400153C RID: 5436
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400153D RID: 5437
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x0400153E RID: 5438
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400153F RID: 5439
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001540 RID: 5440
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x04001541 RID: 5441
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x04001542 RID: 5442
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001543 RID: 5443
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001544 RID: 5444
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x04001545 RID: 5445
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001546 RID: 5446
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001547 RID: 5447
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001548 RID: 5448
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001549 RID: 5449
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400154A RID: 5450
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400154B RID: 5451
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400154C RID: 5452
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400154D RID: 5453
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x0400154E RID: 5454
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x0400154F RID: 5455
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001550 RID: 5456
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001551 RID: 5457
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x04001552 RID: 5458
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001553 RID: 5459
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x04001554 RID: 5460
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001555 RID: 5461
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x04001556 RID: 5462
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001557 RID: 5463
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001558 RID: 5464
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001559 RID: 5465
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400155A RID: 5466
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x0400155B RID: 5467
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400155C RID: 5468
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400155D RID: 5469
		private DataColumnProperty <<EMPTY_NAME>>;

		// Token: 0x0400155E RID: 5470
		private DataCol <<EMPTY_NAME>>;

		// Token: 0x0400155F RID: 5471
		private string <<EMPTY_NAME>>;

		// Token: 0x04001560 RID: 5472
		private int <<EMPTY_NAME>>;

		// Token: 0x04001561 RID: 5473
		private static Assembly <<EMPTY_NAME>>;
	}
}
