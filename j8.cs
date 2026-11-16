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
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000368 RID: 872
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal partial class j8 : Form
	{
		// Token: 0x06003691 RID: 13969 RVA: 0x0017C068 File Offset: 0x0017A268
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OO_OO0O.o. != null)
				{
					this.OO_OO0O.o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x0017C0A8 File Offset: 0x0017A2A8
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.OO_OO0O.o. = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(j8));
			this.O._O_0.(new C1FlexGrid());
			this.O._O_0.(new ContextMenuStrip(this.OO_OO0O.o.));
			this.OOO_O._.(new ToolStripMenuItem());
			this.O0O0.o0ooO.(new ToolStripMenuItem());
			this.OOOo_0o.o__.(new ToolStripMenuItem());
			this.O._o0_.(new ToolStripMenuItem());
			this.O0o.O0.(new Label());
			this.O0_0o_0.O_o00O.(new Label());
			this.OOOo_0o.o__.(new Label());
			this.O.00o__oo.(new C1TextBox());
			this.O0_O0.oO00_oo0.(new C1Button());
			this.O_O00o.o.(new Label());
			this.Oo.o_0ooOO0_.(new C1TextBox());
			this.OO_000_.oO.(new Label());
			this.OOOo_0o.o__.(new C1TextBox());
			this.o0o_O.O_OOOO.(new C1Button());
			this.O000.oO.(new C1Button());
			this.o.O_o__o.(new C1Button());
			this.O0_.oOo0_.(new C1Button());
			this.O0_0o_0.O_o00O.(new C1FlexGrid());
			this.o0O.0o00.(new C1Button());
			this.OOO_O._.(new C1CheckBox());
			this.oO00Oo0_.O.(new C1CheckBox());
			this.O000.oO.(new C1CheckBox());
			this.O0_.oOo0_.(new C1CheckBox());
			this.O_OoO0o.O.(new C1CheckBox());
			this.O._O_0.(new GroupBox());
			this.O._O_0.(new C1CheckBox());
			this.o0o_O.O_OOOO.(new C1CheckBox());
			this.O._o0_.(new Label());
			this.O._O_0.(new NumericUpDown());
			((ISupportInitialize)this.Oo0o_.oo00O0.()).BeginInit();
			this.O_Oo.OOO00o_O.().SuspendLayout();
			((ISupportInitialize)this.O_0._O0o0.()).BeginInit();
			this.O.O0O0oOOoO0O.().SuspendLayout();
			((ISupportInitialize)this.O_Oo.OOO00o_O.()).BeginInit();
			base.SuspendLayout();
			this.Oo0o_.oo00O0.().AllowDelete = true;
			this.Oo0o_.oo00O0.().AllowDragging = AllowDraggingEnum.None;
			this.Oo0o_.oo00O0.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.Oo0o_.oo00O0.().ColumnInfo = componentResourceManager.GetString("GroupGrid.ColumnInfo");
			this.Oo0o_.oo00O0.().ContextMenuStrip = this.O_Oo.OOO00o_O.();
			this.Oo0o_.oo00O0.().ExtendLastCol = true;
			this.Oo0o_.oo00O0.().HighLight = HighLightEnum.WithFocus;
			this.Oo0o_.oo00O0.().Location = new Point(15, 73);
			this.Oo0o_.oo00O0.().Name = "GroupGrid";
			this.Oo0o_.oo00O0.().Rows.Count = 1;
			this.Oo0o_.oo00O0.().Rows.DefaultSize = 21;
			this.Oo0o_.oo00O0.().SelectionMode = SelectionModeEnum.Row;
			this.Oo0o_.oo00O0.().ShowThemedHeaders = ShowThemedHeadersEnum.None;
			this.Oo0o_.oo00O0.().Size = new Size(558, 92);
			this.Oo0o_.oo00O0.().TabIndex = 2;
			this.O_Oo.OOO00o_O.().Items.AddRange(new ToolStripItem[]
			{
				this.OO_oO_0o0.__.(),
				this.OooooO_.O0.(),
				this.O.00O0oo0o_o_o.(),
				this.O.O0O0oOOoO0O.()
			});
			this.O_Oo.OOO00o_O.().Name = "ContextMenuStrip1";
			this.O_Oo.OOO00o_O.().Size = new Size(101, 92);
			this.OO_oO_0o0.__.().Name = "InsertMenuItem";
			this.OO_oO_0o0.__.().Size = new Size(100, 22);
			this.OO_oO_0o0.__.().Text = "插入";
			this.OooooO_.O0.().Name = "DeleteMenuItem";
			this.OooooO_.O0.().Size = new Size(100, 22);
			this.OooooO_.O0.().Text = "删除";
			this.O.00O0oo0o_o_o.().Name = "MoveUpMenuItem";
			this.O.00O0oo0o_o_o.().Size = new Size(100, 22);
			this.O.00O0oo0o_o_o.().Text = "上移";
			this.O.O0O0oOOoO0O.().Name = "MoveDownMenuItem";
			this.O.O0O0oOOoO0O.().Size = new Size(100, 22);
			this.O.O0O0oOOoO0O.().Text = "下移";
			this.Oo0o_.oo00O0.().AutoSize = true;
			this.Oo0o_.oo00O0.().Location = new Point(15, 53);
			this.Oo0o_.oo00O0.().Name = "Label1";
			this.Oo0o_.oo00O0.().Size = new Size(71, 12);
			this.Oo0o_.oo00O0.().TabIndex = 1;
			this.Oo0o_.oo00O0.().Text = "选择分组列:";
			this.O0OOO__oO_O.00.().AutoSize = true;
			this.O0OOO__oO_O.00.().Location = new Point(13, 172);
			this.O0OOO__oO_O.00.().Name = "Label2";
			this.O0OOO__oO_O.00.().Size = new Size(71, 12);
			this.O0OOO__oO_O.00.().TabIndex = 3;
			this.O0OOO__oO_O.00.().Text = "选择统计列:";
			this.OOO0o.O.().AutoSize = true;
			this.OOO0o.O.().Location = new Point(15, 381);
			this.OOO0o.O.().Name = "Label3";
			this.OOO0o.O.().Size = new Size(35, 12);
			this.OOO0o.O.().TabIndex = 4;
			this.OOO0o.O.().Text = "条件:";
			this.O_0._O0o0.().Location = new Point(15, 401);
			this.O_0._O0o0.().Name = "txtFilter";
			this.O_0._O0o0.().Size = new Size(521, 21);
			this.O_0._O0o0.().TabIndex = 5;
			this.oo.0O.().Location = new Point(537, 400);
			this.oo.0O.().Name = "btnEditExpression";
			this.oo.0O.().Size = new Size(36, 23);
			this.oo.0O.().TabIndex = 6;
			this.oo.0O.().Text = "...";
			this.oo.0O.().UseVisualStyleBackColor = true;
			this.O.O0O0oOOoO0O.().AutoSize = true;
			this.O.O0O0oOOoO0O.().Location = new Point(15, 18);
			this.O.O0O0oOOoO0O.().Name = "Label4";
			this.O.O0O0oOOoO0O.().Size = new Size(35, 12);
			this.O.O0O0oOOoO0O.().TabIndex = 7;
			this.O.O0O0oOOoO0O.().Text = "表名:";
			this.o.0O_O0_0OO.().Location = new Point(57, 14);
			this.o.0O_O0_0OO.().Name = "txtName";
			this.o.0O_O0_0OO.().Size = new Size(100, 21);
			this.o.0O_O0_0OO.().TabIndex = 0;
			this.O_oO__Oo_0.00.().AutoSize = true;
			this.O_oO__Oo_0.00.().Location = new Point(186, 18);
			this.O_oO__Oo_0.00.().Name = "Label5";
			this.O_oO__Oo_0.00.().Size = new Size(35, 12);
			this.O_oO__Oo_0.00.().TabIndex = 9;
			this.O_oO__Oo_0.00.().Text = "标题:";
			this.O.00O0oo0o_o_o.().Location = new Point(227, 14);
			this.O.00O0oo0o_o_o.().Name = "txtCaption";
			this.O.00O0oo0o_o_o.().Size = new Size(346, 21);
			this.O.00O0oo0o_o_o.().TabIndex = 1;
			this.O.O_0o0oo_o0.().Location = new Point(176, 443);
			this.O.O_0o0oo_o0.().Name = "btnViewCode";
			this.O.O_0o0oo_o0.().Size = new Size(75, 23);
			this.O.O_0o0oo_o0.().TabIndex = 7;
			this.O.O_0o0oo_o0.().Text = "查看代码";
			this.O.O_0o0oo_o0.().UseVisualStyleBackColor = true;
			this.o_o_O.OO_o0o0.().Location = new Point(418, 443);
			this.o_o_O.OO_o0o0.().Name = "btnOk";
			this.o_o_O.OO_o0o0.().Size = new Size(75, 23);
			this.o_o_O.OO_o0o0.().TabIndex = 10;
			this.o_o_O.OO_o0o0.().Text = "确定";
			this.o_o_O.OO_o0o0.().UseVisualStyleBackColor = true;
			this.O0__.00_oo0O0_.().CausesValidation = false;
			this.O0__.00_oo0O0_.().DialogResult = DialogResult.Cancel;
			this.O0__.00_oo0O0_.().Location = new Point(499, 443);
			this.O0__.00_oo0O0_.().Name = "btnCancel";
			this.O0__.00_oo0O0_.().Size = new Size(75, 23);
			this.O0__.00_oo0O0_.().TabIndex = 11;
			this.O0__.00_oo0O0_.().Text = "取消";
			this.O0__.00_oo0O0_.().UseVisualStyleBackColor = true;
			this.o.0_O_0O_Oo.().Location = new Point(95, 443);
			this.o.0_O_0O_Oo.().Name = "btnList";
			this.o.0_O_0O_Oo.().Size = new Size(75, 23);
			this.o.0_O_0O_Oo.().TabIndex = 9;
			this.o.0_O_0O_Oo.().Text = "设置管理";
			this.o.0_O_0O_Oo.().UseVisualStyleBackColor = true;
			this.O_0._O0o0.().AllowDelete = true;
			this.O_0._O0o0.().AllowDragging = AllowDraggingEnum.None;
			this.O_0._O0o0.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.O_0._O0o0.().ColumnInfo = componentResourceManager.GetString("TotalGrid.ColumnInfo");
			this.O_0._O0o0.().ContextMenuStrip = this.O_Oo.OOO00o_O.();
			this.O_0._O0o0.().ExtendLastCol = true;
			this.O_0._O0o0.().HighLight = HighLightEnum.WithFocus;
			this.O_0._O0o0.().Location = new Point(13, 192);
			this.O_0._O0o0.().Name = "TotalGrid";
			this.O_0._O0o0.().Rows.Count = 1;
			this.O_0._O0o0.().Rows.DefaultSize = 21;
			this.O_0._O0o0.().SelectionMode = SelectionModeEnum.Row;
			this.O_0._O0o0.().ShowThemedHeaders = ShowThemedHeadersEnum.None;
			this.O_0._O0o0.().Size = new Size(558, 92);
			this.O_0._O0o0.().TabIndex = 3;
			this.OoOo0.oo.().Location = new Point(14, 443);
			this.OoOo0.oo.().Name = "btnSave";
			this.OoOo0.oo.().Size = new Size(75, 23);
			this.OoOo0.oo.().TabIndex = 8;
			this.OoOo0.oo.().Text = "保存设置";
			this.OoOo0.oo.().UseVisualStyleBackColor = true;
			this.o00_.oo0O_.().AutoSize = true;
			this.o00_.oo0O_.().Location = new Point(220, 47);
			this.o00_.oo0O_.().Name = "chkVerticalTotal";
			this.o00_.oo0O_.().Size = new Size(120, 16);
			this.o00_.oo0O_.().TabIndex = 0;
			this.o00_.oo0O_.().Text = "垂直方向自动汇总";
			this.o00_.oo0O_.().UseVisualStyleBackColor = true;
			this.Oo__.O0_o0OOoO.().AutoSize = true;
			this.Oo__.O0_o0OOoO.().Location = new Point(15, 47);
			this.Oo__.O0_o0OOoO.().Name = "chkGroupProportion";
			this.Oo__.O0_o0OOoO.().Size = new Size(84, 16);
			this.Oo__.O0_o0OOoO.().TabIndex = 1;
			this.Oo__.O0_o0OOoO.().Text = "生成分占比";
			this.Oo__.O0_o0OOoO.().UseVisualStyleBackColor = true;
			this.o0o_0o00.0o.().AutoSize = true;
			this.o0o_0o00.0o.().Location = new Point(15, 22);
			this.o0o_0o00.0o.().Name = "ChkGrandProportion";
			this.o0o_0o00.0o.().Size = new Size(84, 16);
			this.o0o_0o00.0o.().TabIndex = 2;
			this.o0o_0o00.0o.().Text = "生成总占比";
			this.o0o_0o00.0o.().UseVisualStyleBackColor = true;
			this.o_O._.().AutoSize = true;
			this.o_O._.().Location = new Point(125, 22);
			this.o_O._.().Name = "chkCircleGrowth";
			this.o_O._.().Size = new Size(72, 16);
			this.o_O._.().TabIndex = 3;
			this.o_O._.().Text = "生成环比";
			this.o_O._.().UseVisualStyleBackColor = true;
			this.OooooO_.O0.().AutoSize = true;
			this.OooooO_.O0.().Location = new Point(125, 47);
			this.OooooO_.O0.().Name = "chkSamePeriodGrowth";
			this.OooooO_.O0.().Size = new Size(72, 16);
			this.OooooO_.O0.().TabIndex = 4;
			this.OooooO_.O0.().Text = "生成同比";
			this.OooooO_.O0.().UseVisualStyleBackColor = true;
			this.O.O0O0oOOoO0O.().Controls.Add(this.O_Oo.OOO00o_O.());
			this.O.O0O0oOOoO0O.().Controls.Add(this.o._ooO.());
			this.O.O0O0oOOoO0O.().Controls.Add(this.OO_oO_0o0.__.());
			this.O.O0O0oOOoO0O.().Controls.Add(this.O_Oo.OOO00o_O.());
			this.O.O0O0oOOoO0O.().Controls.Add(this.o00_.oo0O_.());
			this.O.O0O0oOOoO0O.().Controls.Add(this.OooooO_.O0.());
			this.O.O0O0oOOoO0O.().Controls.Add(this.Oo__.O0_o0OOoO.());
			this.O.O0O0oOOoO0O.().Controls.Add(this.o_O._.());
			this.O.O0O0oOOoO0O.().Controls.Add(this.o0o_0o00.0o.());
			this.O.O0O0oOOoO0O.().Location = new Point(14, 290);
			this.O.O0O0oOOoO0O.().Name = "GroupBox1";
			this.O.O0O0oOOoO0O.().Size = new Size(556, 74);
			this.O.O0O0oOOoO0O.().TabIndex = 4;
			this.O.O0O0oOOoO0O.().TabStop = false;
			this.O.O0O0oOOoO0O.().Text = "统计选项";
			this.O_Oo.OOO00o_O.().AutoSize = true;
			this.O_Oo.OOO00o_O.().Location = new Point(220, 22);
			this.O_Oo.OOO00o_O.().Name = "chkSubtotal";
			this.O_Oo.OOO00o_O.().Size = new Size(120, 16);
			this.O_Oo.OOO00o_O.().TabIndex = 8;
			this.O_Oo.OOO00o_O.().Text = "自动生成汇总模式";
			this.O_Oo.OOO00o_O.().UseVisualStyleBackColor = true;
			this.o._ooO.().AutoSize = true;
			this.o._ooO.().Location = new Point(414, 20);
			this.o._ooO.().Name = "chkFromServer";
			this.o._ooO.().Size = new Size(120, 16);
			this.o._ooO.().TabIndex = 7;
			this.o._ooO.().Text = "直接统计后台数据";
			this.o._ooO.().UseVisualStyleBackColor = true;
			this.OO_oO_0o0.__.().AutoSize = true;
			this.OO_oO_0o0.__.().Location = new Point(400, 49);
			this.OO_oO_0o0.__.().Name = "Label6";
			this.OO_oO_0o0.__.().Size = new Size(59, 12);
			this.OO_oO_0o0.__.().TabIndex = 6;
			this.OO_oO_0o0.__.().Text = "小数位数:";
			this.O_Oo.OOO00o_O.().Location = new Point(471, 45);
			this.O_Oo.OOO00o_O.().Name = "Decimals";
			this.O_Oo.OOO00o_O.().Size = new Size(63, 21);
			this.O_Oo.OOO00o_O.().TabIndex = 5;
			NumericUpDown numericUpDown = this.O_Oo.OOO00o_O.();
			int[] array = new int[4];
			array[0] = 4;
			numericUpDown.Value = new decimal(array);
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(588, 476);
			base.Controls.Add(this.O.O0O0oOOoO0O.());
			base.Controls.Add(this.O_0._O0o0.());
			base.Controls.Add(this.OoOo0.oo.());
			base.Controls.Add(this.O.00O0oo0o_o_o.());
			base.Controls.Add(this.O0__.00_oo0O0_.());
			base.Controls.Add(this.o_o_O.OO_o0o0.());
			base.Controls.Add(this.O_oO__Oo_0.00.());
			base.Controls.Add(this.o.0_O_0O_Oo.());
			base.Controls.Add(this.o.0O_O0_0OO.());
			base.Controls.Add(this.O.O0O0oOOoO0O.());
			base.Controls.Add(this.O.O_0o0oo_o0.());
			base.Controls.Add(this.oo.0O.());
			base.Controls.Add(this.O_0._O0o0.());
			base.Controls.Add(this.OOO0o.O.());
			base.Controls.Add(this.Oo0o_.oo00O0.());
			base.Controls.Add(this.O0OOO__oO_O.00.());
			base.Controls.Add(this.Oo0o_.oo00O0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ooO.o00.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "分组统计";
			((ISupportInitialize)this.Oo0o_.oo00O0.()).EndInit();
			this.O_Oo.OOO00o_O.().ResumeLayout(false);
			((ISupportInitialize)this.O_0._O0o0.()).EndInit();
			this.O.O0O0oOOoO0O.().ResumeLayout(false);
			this.O.O0O0oOOoO0O.().PerformLayout();
			((ISupportInitialize)this.O_Oo.OOO00o_O.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x0017D16E File Offset: 0x0017B36E
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.Oo.O_000O.;
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x0017D178 File Offset: 0x0017B378
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.oO_0ooOoo0o.__.);
			RowColEventHandler value2 = new RowColEventHandler(this.o.0O_O0_0OO.);
			C1FlexGrid oo.O_000O. = this.Oo.O_000O.;
			if (oo.O_000O. != null)
			{
				oo.O_000O..AfterEdit -= value;
				oo.O_000O..BeforeEdit -= value2;
			}
			this.Oo.O_000O. = A_0;
			oo.O_000O. = this.Oo.O_000O.;
			if (oo.O_000O. != null)
			{
				oo.O_000O..AfterEdit += value;
				oo.O_000O..BeforeEdit += value2;
			}
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x0017D1D6 File Offset: 0x0017B3D6
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo.O_000O.;
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x0017D1DE File Offset: 0x0017B3DE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo.O_000O. = A_0;
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x0017D1E7 File Offset: 0x0017B3E7
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo0_.o.;
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x0017D1EF File Offset: 0x0017B3EF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo0_.o. = A_0;
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x0017D1F8 File Offset: 0x0017B3F8
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OO.0oooO00Oo.;
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x0017D200 File Offset: 0x0017B400
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OO.0oooO00Oo. = A_0;
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x0017D209 File Offset: 0x0017B409
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.OO_OO0O.o.;
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x0017D211 File Offset: 0x0017B411
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.OO_OO0O.o. = A_0;
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x0017D21A File Offset: 0x0017B41A
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.00o__oo.;
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x0017D224 File Offset: 0x0017B424
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o00_o0o.oOOo.);
			C1Button o.00o__oo. = this.O.00o__oo.;
			if (o.00o__oo. != null)
			{
				o.00o__oo..Click -= value;
			}
			this.O.00o__oo. = A_0;
			o.00o__oo. = this.O.00o__oo.;
			if (o.00o__oo. != null)
			{
				o.00o__oo..Click += value;
			}
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x0017D267 File Offset: 0x0017B467
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Ooo0o0o0_o.0.;
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x0017D26F File Offset: 0x0017B46F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Ooo0o0o0_o.0. = A_0;
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x0017D278 File Offset: 0x0017B478
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.Oo._Oo0_OOO_.;
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x0017D280 File Offset: 0x0017B480
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			CancelEventHandler value = new CancelEventHandler(this.O.00o__oo.);
			C1TextBox oo._Oo0_OOO_. = this.Oo._Oo0_OOO_.;
			if (oo._Oo0_OOO_. != null)
			{
				oo._Oo0_OOO_..Validating -= value;
			}
			this.Oo._Oo0_OOO_. = A_0;
			oo._Oo0_OOO_. = this.Oo._Oo0_OOO_.;
			if (oo._Oo0_OOO_. != null)
			{
				oo._Oo0_OOO_..Validating += value;
			}
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x0017D2C3 File Offset: 0x0017B4C3
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0.o_.;
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x0017D2CB File Offset: 0x0017B4CB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0.o_. = A_0;
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x0017D2D4 File Offset: 0x0017B4D4
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o_.0__oo_O.;
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x0017D2DC File Offset: 0x0017B4DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o_.0__oo_O. = A_0;
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x0017D2E5 File Offset: 0x0017B4E5
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O._oo.;
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x0017D2F0 File Offset: 0x0017B4F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o___OoO.o.);
			C1Button o._oo. = this.O._oo.;
			if (o._oo. != null)
			{
				o._oo..Click -= value;
			}
			this.O._oo. = A_0;
			o._oo. = this.O._oo.;
			if (o._oo. != null)
			{
				o._oo..Click += value;
			}
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x0017D333 File Offset: 0x0017B533
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_O0Oo.o.;
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x0017D33C File Offset: 0x0017B53C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.o___O00.);
			C1Button oo_O0Oo.o. = this.Oo_O0Oo.o.;
			if (oo_O0Oo.o. != null)
			{
				oo_O0Oo.o..Click -= value;
			}
			this.Oo_O0Oo.o. = A_0;
			oo_O0Oo.o. = this.Oo_O0Oo.o.;
			if (oo_O0Oo.o. != null)
			{
				oo_O0Oo.o..Click += value;
			}
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x0017D37F File Offset: 0x0017B57F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0_._.;
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x0017D387 File Offset: 0x0017B587
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O0_._. = A_0;
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x0017D390 File Offset: 0x0017B590
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_O__Oo0._0.;
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x0017D398 File Offset: 0x0017B598
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOOOo._O0O.);
			C1Button c1Button = this.o_O__Oo0._0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_O__Oo0._0. = A_0;
			c1Button = this.o_O__Oo0._0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x0017D3DB File Offset: 0x0017B5DB
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.Oo._Oo0_OOO_.;
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x0017D3E4 File Offset: 0x0017B5E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.Oo.o_0ooOO0_.);
			RowColEventHandler value2 = new RowColEventHandler(this.O.00o__oo.);
			C1FlexGrid oo._Oo0_OOO_. = this.Oo._Oo0_OOO_.;
			if (oo._Oo0_OOO_. != null)
			{
				oo._Oo0_OOO_..AfterEdit -= value;
				oo._Oo0_OOO_..BeforeEdit -= value2;
			}
			this.Oo._Oo0_OOO_. = A_0;
			oo._Oo0_OOO_. = this.Oo._Oo0_OOO_.;
			if (oo._Oo0_OOO_. != null)
			{
				oo._Oo0_OOO_..AfterEdit += value;
				oo._Oo0_OOO_..BeforeEdit += value2;
			}
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x0017D442 File Offset: 0x0017B642
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.Oooo.Oo_oo0.;
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x0017D44A File Offset: 0x0017B64A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.Oooo.Oo_oo0. = A_0;
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x0017D454 File Offset: 0x0017B654
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.Oo.O_000O.;
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x0017D468 File Offset: 0x0017B668
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o0OoO_0O_.Ooo.);
				ToolStripMenuItem oo.O_000O. = this.Oo.O_000O.;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (true)
						{
						}
						if (oo.O_000O. != null)
						{
							num = 2;
							continue;
						}
						goto IL_62;
					case 2:
						oo.O_000O..Click -= value;
						num = 4;
						continue;
					case 3:
						oo.O_000O..Click += value;
						num = 0;
						continue;
					case 4:
						goto IL_62;
					case 5:
						if (oo.O_000O. != null)
						{
							num = 3;
							continue;
						}
						return;
					}
					break;
					IL_62:
					this.Oo.O_000O. = A_0;
					oo.O_000O. = this.Oo.O_000O.;
					num = 5;
				}
			}
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x0017D514 File Offset: 0x0017B714
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.Oo._Oo0_OOO_.;
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x0017D528 File Offset: 0x0017B728
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O____0.o0_.);
				ToolStripMenuItem oo._Oo0_OOO_. = this.Oo._Oo0_OOO_.;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (oo._Oo0_OOO_. != null)
						{
							if (true)
							{
							}
							num = 3;
							continue;
						}
						goto IL_62;
					case 1:
						goto IL_62;
					case 2:
						if (oo._Oo0_OOO_. != null)
						{
							num = 5;
							continue;
						}
						return;
					case 3:
						oo._Oo0_OOO_..Click -= value;
						num = 1;
						continue;
					case 4:
						return;
					case 5:
						oo._Oo0_OOO_..Click += value;
						num = 4;
						continue;
					}
					break;
					IL_62:
					this.Oo._Oo0_OOO_. = A_0;
					oo._Oo0_OOO_. = this.Oo._Oo0_OOO_.;
					num = 2;
				}
			}
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x0017D5D4 File Offset: 0x0017B7D4
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o_.0__oo_O.;
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x0017D5E8 File Offset: 0x0017B7E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o__.ooOOoO00.);
				ToolStripMenuItem toolStripMenuItem = this.o_.0__oo_O.;
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						toolStripMenuItem.Click += value;
						num = 0;
						continue;
					case 2:
						if (toolStripMenuItem != null)
						{
							num = 1;
							continue;
						}
						return;
					case 3:
						if (toolStripMenuItem != null)
						{
							num = 4;
							continue;
						}
						goto IL_5A;
					case 4:
						if (true)
						{
						}
						toolStripMenuItem.Click -= value;
						num = 5;
						continue;
					case 5:
						goto IL_5A;
					}
					break;
					IL_5A:
					this.o_.0__oo_O. = A_0;
					toolStripMenuItem = this.o_.0__oo_O.;
					num = 2;
				}
			}
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x0017D68E File Offset: 0x0017B88E
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo._Oooo.;
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x0017D698 File Offset: 0x0017B898
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0.O__o__00_O.);
			C1Button oo._Oooo. = this.Oo._Oooo.;
			if (oo._Oooo. != null)
			{
				oo._Oooo..Click -= value;
			}
			this.Oo._Oooo. = A_0;
			oo._Oooo. = this.Oo._Oooo.;
			if (oo._Oooo. != null)
			{
				oo._Oooo..Click += value;
			}
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x0017D6DC File Offset: 0x0017B8DC
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.Ooo0o0o0_o.0.;
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x0017D6F0 File Offset: 0x0017B8F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.oO_0ooOoo0o.__.);
				ToolStripMenuItem ooo0o0o0_o.0. = this.Ooo0o0o0_o.0.;
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (ooo0o0o0_o.0. != null)
						{
							num = 1;
							continue;
						}
						return;
					case 1:
						ooo0o0o0_o.0..Click += value;
						num = 2;
						continue;
					case 2:
						return;
					case 3:
						if (ooo0o0o0_o.0. != null)
						{
							num = 4;
							continue;
						}
						goto IL_5A;
					case 4:
						if (true)
						{
						}
						ooo0o0o0_o.0..Click -= value;
						num = 5;
						continue;
					case 5:
						goto IL_5A;
					}
					break;
					IL_5A:
					this.Ooo0o0o0_o.0. = A_0;
					ooo0o0o0_o.0. = this.Ooo0o0o0_o.0.;
					num = 0;
				}
			}
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x0017D796 File Offset: 0x0017B996
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.Oooo.Oo_oo0.;
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x0017D79E File Offset: 0x0017B99E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.Oooo.Oo_oo0. = A_0;
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x0017D7A7 File Offset: 0x0017B9A7
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O._oo.;
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x0017D7AF File Offset: 0x0017B9AF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O._oo. = A_0;
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x0017D7B8 File Offset: 0x0017B9B8
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o.Oo_o_O.;
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x0017D7C0 File Offset: 0x0017B9C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o.Oo_o_O. = A_0;
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x0017D7C9 File Offset: 0x0017B9C9
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o_oOOo._0oO.;
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x0017D7D1 File Offset: 0x0017B9D1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o_oOOo._0oO. = A_0;
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x0017D7DA File Offset: 0x0017B9DA
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O0oo00_0._.;
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x0017D7E2 File Offset: 0x0017B9E2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O0oo00_0._. = A_0;
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x0017D7EB File Offset: 0x0017B9EB
		[CompilerGenerated]
		internal virtual GroupBox <<EMPTY_NAME>>()
		{
			return this.Oo.O_000O.;
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x0017D7F3 File Offset: 0x0017B9F3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(GroupBox A_0)
		{
			this.Oo.O_000O. = A_0;
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x0017D7FC File Offset: 0x0017B9FC
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_o_0._.;
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x0017D804 File Offset: 0x0017BA04
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_o_0._. = A_0;
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x0017D80D File Offset: 0x0017BA0D
		[CompilerGenerated]
		internal virtual NumericUpDown <<EMPTY_NAME>>()
		{
			return this.Oo.O_000O.;
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x0017D815 File Offset: 0x0017BA15
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(NumericUpDown A_0)
		{
			this.Oo.O_000O. = A_0;
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x0017D81E File Offset: 0x0017BA1E
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.Oo._Oooo.;
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x0017D828 File Offset: 0x0017BA28
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.o0O__o.oO_.);
			C1CheckBox oo._Oooo. = this.Oo._Oooo.;
			if (oo._Oooo. != null)
			{
				oo._Oooo..CheckedChanged -= value;
			}
			this.Oo._Oooo. = A_0;
			oo._Oooo. = this.Oo._Oooo.;
			if (oo._Oooo. != null)
			{
				oo._Oooo..CheckedChanged += value;
			}
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x0017D86B File Offset: 0x0017BA6B
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.Oo.000O000OO.;
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x0017D873 File Offset: 0x0017BA73
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.Oo.000O000OO. = A_0;
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x0017D87C File Offset: 0x0017BA7C
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
				if (Operators.CompareString(this.Oo0o_.oo00O0.().Cols[A_1.Col].Name, "Name", true) != 0)
				{
					goto IL_14B;
				}
				IL_34:
				num2 = 3;
				if (this.Oo0o_.oo00O0.().GetData(A_1.Row, "Name") == null)
				{
					goto IL_1E1;
				}
				IL_51:
				num2 = 5;
				string text = this.Oo0o_.oo00O0.().GetData(A_1.Row, "Name").ToString();
				IL_6F:
				num2 = 6;
				if (Operators.CompareString(text, "", true) == 0)
				{
					goto IL_1E1;
				}
				IL_82:
				num2 = 8;
				if (this.OO_OO0O.o..DataTable.DataCols[text].IsDate)
				{
					goto IL_DA;
				}
				IL_A1:
				num2 = 9;
				this.Oo0o_.oo00O0.()[A_1.Row, "DateGroup"] = null;
				IL_BB:
				num2 = 10;
				this.Oo0o_.oo00O0.()[A_1.Row, "NewName"] = null;
				goto IL_1E1;
				IL_DA:
				num2 = 12;
				if (this.Oo0o_.oo00O0.()[A_1.Row, "DateGroup"] != null)
				{
					goto IL_1E1;
				}
				IL_F8:
				num2 = 13;
				this.Oo0o_.oo00O0.()[A_1.Row, "DateGroup"] = DateGroupEnum.Month;
				IL_117:
				num2 = 14;
				this.Oo0o_.oo00O0.()[A_1.Row, "NewName"] = this.Oo0o_.oo00O0.().GetDataDisplay(A_1.Row, "DateGroup");
				goto IL_1E1;
				IL_14B:
				num2 = 16;
				if (Operators.CompareString(this.Oo0o_.oo00O0.().Cols[A_1.Col].Name, "DateGroup", true) != 0)
				{
					goto IL_1E1;
				}
				IL_176:
				num2 = 17;
				if (Conversions.ToInteger(this.Oo0o_.oo00O0.()[A_1.Row, "DateGroup"]) != 0)
				{
					goto IL_1B2;
				}
				IL_196:
				num2 = 18;
				this.Oo0o_.oo00O0.()[A_1.Row, "NewName"] = null;
				goto IL_1E1;
				IL_1B2:
				num2 = 20;
				this.Oo0o_.oo00O0.()[A_1.Row, "NewName"] = this.Oo0o_.oo00O0.().GetDataDisplay(A_1.Row, "DateGroup");
				IL_1E1:
				goto IL_287;
				IL_1E6:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_248:
				goto IL_27C;
				IL_24A:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_25A:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_24A;
			}
			IL_27C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_287:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x0017DB34 File Offset: 0x0017BD34
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Row > 0 && Operators.CompareString(this.Oo0o_.oo00O0.().Cols[A_1.Col].Name, "DateGroup", true) == 0)
			{
				if (this.Oo0o_.oo00O0.().GetData(A_1.Row, "Name") == null)
				{
					A_1.Cancel = true;
					return;
				}
				string text = this.Oo0o_.oo00O0.().GetData(A_1.Row, "Name").ToString();
				if (Operators.CompareString(text, "", true) == 0 || !this.OO_OO0O.o..DataTable.DataCols[text].IsDate)
				{
					A_1.Cancel = true;
				}
			}
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x0017DBE4 File Offset: 0x0017BDE4
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (Operators.CompareString(this.O_0._O0o0.().Cols[A_1.Col].Name, "Name", true) == 0 && this.O_0._O0o0.().GetData(A_1.Row, "Name") != null)
			{
				string text = this.O_0._O0o0.().GetData(A_1.Row, "Name").ToString();
				if (Operators.CompareString(text, "", true) != 0)
				{
					if (!this.OO_OO0O.o..DataTable.DataCols[text].IsNumeric)
					{
						this.O_0._O0o0.()[A_1.Row, "Aggregate"] = AggregateEnum.Count;
						return;
					}
					if (this.O_0._O0o0.()[A_1.Row, "Aggregate"] == null)
					{
						this.O_0._O0o0.()[A_1.Row, "Aggregate"] = AggregateEnum.Sum;
					}
				}
			}
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x0017DCD0 File Offset: 0x0017BED0
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Row > 0 && Operators.CompareString(this.O_0._O0o0.().Cols[A_1.Col].Name, "Aggregate", true) == 0)
			{
				if (this.O_0._O0o0.().GetData(A_1.Row, "Name") == null)
				{
					A_1.Cancel = true;
					return;
				}
				string text = this.O_0._O0o0.().GetData(A_1.Row, "Name").ToString();
				if (Operators.CompareString(text, "", true) == 0 || !this.OO_OO0O.o..DataTable.DataCols[text].IsNumeric)
				{
					A_1.Cancel = true;
				}
			}
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x0017DD80 File Offset: 0x0017BF80
		private GroupTableBuilder <<EMPTY_NAME>>()
		{
			int num;
			GroupTableBuilder result;
			int num6;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string text = Oo00.OoO_.__o.(this.OO_OO0O.o., this.o._ooO.().Checked);
				IL_21:
				num2 = 3;
				if (Operators.CompareString(this.o.0O_O0_0OO.().Text.Trim(), "", true) != 0)
				{
					goto IL_5E;
				}
				IL_40:
				num2 = 4;
				MessageBox.Show("请输入表名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_55:
				num2 = 5;
				result = null;
				goto IL_5DC;
				IL_5E:
				num2 = 6;
				int index = this.O_0._O0o0.().Cols["upto"].Index;
				IL_7C:
				num2 = 7;
				if (Operators.CompareString(this.O_0._O0o0.().Text.Trim(), "", true) <= 0)
				{
					goto IL_E5;
				}
				IL_9C:
				num2 = 8;
				if (Operators.CompareString(text, "", true) != 0)
				{
					goto IL_C4;
				}
				IL_AD:
				num2 = 9;
				text = this.O_0._O0o0.().Text.Trim();
				goto IL_E5;
				IL_C4:
				num2 = 11;
				text = text + " And " + this.O_0._O0o0.().Text.Trim();
				IL_E5:
				num2 = 12;
				GroupTableBuilder groupTableBuilder = new GroupTableBuilder(this.o.0O_O0_0OO.().Text, this.OO_OO0O.o..DataTable, text);
				IL_107:
				num2 = 13;
				groupTableBuilder.Caption = this.O.00O0oo0o_o_o.().Text;
				IL_11C:
				num2 = 14;
				int @fixed = this.Oo0o_.oo00O0.().Rows.Fixed;
				int num3 = this.Oo0o_.oo00O0.().Rows.Count - 2;
				for (int i = @fixed; i <= num3; i++)
				{
					IL_14A:
					num2 = 15;
					if (Operators.CompareString(this.Oo0o_.oo00O0.().GetDataDisplay(i, "Name"), "", true) > 0)
					{
						IL_170:
						num2 = 16;
						GroupOn groupOn = new GroupOn();
						IL_17A:
						num2 = 17;
						groupOn.Name = this.Oo0o_.oo00O0.()[i, "Name"].ToString();
						IL_19B:
						num2 = 18;
						if (this.Oo0o_.oo00O0.()[i, "DateGroup"] != null)
						{
							IL_1B2:
							num2 = 19;
							groupOn.DateGroup = (DateGroupEnum)Conversions.ToInteger(this.Oo0o_.oo00O0.()[i, "DateGroup"]);
						}
						IL_1D3:
						num2 = 20;
						if (this.Oo0o_.oo00O0.()[i, "NewName"] != null)
						{
							IL_1EA:
							num2 = 21;
							groupOn.NewName = this.Oo0o_.oo00O0.()[i, "NewName"].ToString();
						}
						IL_20B:
						num2 = 22;
						if (this.Oo0o_.oo00O0.()[i, "NewCaption"] != null)
						{
							IL_222:
							num2 = 23;
							groupOn.NewCaption = this.Oo0o_.oo00O0.()[i, "NewCaption"].ToString();
						}
						IL_243:
						num2 = 24;
						groupTableBuilder.Groups.Add(groupOn);
					}
					IL_254:
					num2 = 25;
				}
				IL_266:
				num2 = 26;
				int fixed2 = this.O_0._O0o0.().Rows.Fixed;
				int num4 = this.O_0._O0o0.().Rows.Count - 2;
				for (int j = fixed2; j <= num4; j++)
				{
					IL_294:
					num2 = 27;
					if (Operators.CompareString(this.O_0._O0o0.().GetDataDisplay(j, "Name"), "", true) > 0)
					{
						IL_2BA:
						num2 = 28;
						TotalOn totalOn = new TotalOn();
						IL_2C4:
						num2 = 29;
						totalOn.Name = this.O_0._O0o0.()[j, "Name"].ToString();
						IL_2E5:
						num2 = 30;
						if (this.O_0._O0o0.()[j, "Aggregate"] != null)
						{
							IL_2FC:
							num2 = 31;
							totalOn.Aggregate = (AggregateEnum)Conversions.ToInteger(this.O_0._O0o0.()[j, "Aggregate"]);
						}
						IL_31D:
						num2 = 32;
						if (this.O_0._O0o0.()[j, "NewName"] != null)
						{
							IL_334:
							num2 = 33;
							totalOn.NewName = this.O_0._O0o0.()[j, "NewName"].ToString();
						}
						IL_355:
						num2 = 34;
						if (this.O_0._O0o0.()[j, "NewCaption"] != null)
						{
							IL_36C:
							num2 = 35;
							totalOn.NewCaption = this.O_0._O0o0.()[j, "NewCaption"].ToString();
						}
						IL_38D:
						num2 = 36;
						if (this.O_0._O0o0.().GetCellCheck(j, index) == CheckEnum.Checked)
						{
							IL_3A2:
							num2 = 37;
							totalOn.upto = true;
						}
						IL_3AD:
						num2 = 38;
						groupTableBuilder.Totals.Add(totalOn);
					}
					IL_3BE:
					num2 = 39;
				}
				IL_3D0:
				num2 = 40;
				groupTableBuilder.VerticalTotal = this.o00_.oo0O_.().Checked;
				IL_3E5:
				num2 = 41;
				groupTableBuilder.GrandProportion = this.o0o_0o00.0o.().Checked;
				IL_3FA:
				num2 = 42;
				groupTableBuilder.GroupProportion = this.Oo__.O0_o0OOoO.().Checked;
				IL_40F:
				num2 = 43;
				groupTableBuilder.CircleGrowth = this.o_O._.().Checked;
				IL_424:
				num2 = 44;
				groupTableBuilder.SamePeriodGrowth = this.OooooO_.O0.().Checked;
				IL_439:
				num2 = 45;
				groupTableBuilder.Decimals = Convert.ToInt32(this.O_Oo.OOO00o_O.().Value);
				IL_453:
				num2 = 46;
				groupTableBuilder.FromServer = this.o._ooO.().Checked;
				IL_468:
				num2 = 47;
				if (this.OO_OO0O.o..O.OoOo_. == null || this.OO_OO0O.o..O.OoOo_..FindForm() != Main.OO_O.o. || Operators.CompareString(this.OO_OO0O.o..DataTable.LoadTop, "", true) <= 0 || !this.OO_OO0O.o..AllowBackEndFilter)
				{
					goto IL_5A7;
				}
				IL_4C6:
				num2 = 48;
				groupTableBuilder.FromServer = true;
				IL_4D1:
				num2 = 49;
				if (!this.o._ooO.().Checked)
				{
					goto IL_4EE;
				}
				IL_4E1:
				num2 = 50;
				groupTableBuilder.FromAll = true;
				goto IL_508;
				IL_4EE:
				num2 = 52;
				groupTableBuilder.Filter = this.OO_OO0O.o..DataTable.LoadFilter;
				IL_508:
				num2 = 53;
				if (Operators.CompareString(this.O_0._O0o0.().Text.Trim(), "", true) <= 0)
				{
					goto IL_5A7;
				}
				IL_529:
				num2 = 54;
				if (Operators.CompareString(groupTableBuilder.Filter, "", true) <= 0)
				{
					goto IL_58D;
				}
				IL_541:
				num2 = 55;
				groupTableBuilder.Filter = string.Concat(new string[]
				{
					"(",
					groupTableBuilder.Filter,
					") And (",
					this.O_0._O0o0.().Text.Trim(),
					")"
				});
				goto IL_5A7;
				IL_58D:
				num2 = 57;
				groupTableBuilder.Filter = this.O_0._O0o0.().Text.Trim();
				IL_5A7:
				num2 = 58;
				groupTableBuilder.ExtendFilter = this.O_0._O0o0.().Text.Trim();
				IL_5C1:
				num2 = 59;
				groupTableBuilder.Subtotal = this.O_Oo.OOO00o_O.().Checked;
				IL_5D6:
				num2 = 60;
				result = groupTableBuilder;
				IL_5DC:
				goto IL_722;
				IL_5E1:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_6E3:
				goto IL_717;
				IL_6E5:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_6F5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_6E5;
			}
			IL_717:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_722:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x0017E4D4 File Offset: 0x0017C6D4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			GroupTableBuilder groupTableBuilder = this.oO0Ooo.00O_.();
			if (groupTableBuilder != null && groupTableBuilder.Groups.Count > 0 && groupTableBuilder.Totals.Count > 0)
			{
				groupTableBuilder.Build();
				groupTableBuilder.FromServer = this.o._ooO.().Checked;
				this.OO_OO0O.o..O_0._O_0OO000O. = groupTableBuilder;
				if (OO_00oOO.Tables.get_Contains(groupTableBuilder.TableName))
				{
					OO_00oOO.MainTable = OO_00oOO.Tables[groupTableBuilder.TableName];
				}
				base.DialogResult = DialogResult.OK;
				this.OO_OO0O.o..NeedSaveSetting = true;
				this.OO_OO0O.o..oo0OO0Ooo._.(true);
			}
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x0017E574 File Offset: 0x0017C774
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

		// Token: 0x060036D8 RID: 14040 RVA: 0x0017E5E0 File Offset: 0x0017C7E0
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

		// Token: 0x060036D9 RID: 14041 RVA: 0x0017E638 File Offset: 0x0017C838
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

		// Token: 0x060036DA RID: 14042 RVA: 0x0017E691 File Offset: 0x0017C891
		private void <<EMPTY_NAME>>(object A_0, CancelEventArgs A_1)
		{
			if (Operators.CompareString(this.o.0O_O0_0OO.().Text, "", true) > 0 && !o_O_o_oOoo__.O_o_._o0.(this.o.0O_O0_0OO.().Text))
			{
				A_1.Cancel = true;
			}
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x0017E6C8 File Offset: 0x0017C8C8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			GroupTableBuilder groupTableBuilder = this.oO0Ooo.00O_.();
			if (groupTableBuilder != null && groupTableBuilder.Groups.Count > 0 && groupTableBuilder.Totals.Count > 0)
			{
				GroupTableProperty a_ = new GroupTableProperty(groupTableBuilder);
				new O\u3002_\u3002\u3000\u3002(this.OO_OO0O.o., o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\v', false), ExtendTablePropertyTypeEnum.GroupTable).ShowDialog();
			}
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x0017E71E File Offset: 0x0017C91E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new o\u3000\u3000\u3002\u3002\u3002\u3002o(this.OO_OO0O.o., ExtendTablePropertyTypeEnum.GroupTable).ShowDialog();
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x0017E732 File Offset: 0x0017C932
		public j8(bool A_0) : this(A_0, OO_00oOO.CurrentTable)
		{
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x0017E740 File Offset: 0x0017C940
		public j8(bool A_0, Table A_1)
		{
			base.Activated += this.OoOo0.oo.;
			base.Load += this.O.O_0o0oo_o0.;
			base.FormClosed += this.O.O_0o0oo_o0.;
			int num2;
			int num5;
			object obj;
			try
			{
				IL_3C:
				int num = 1;
				this.O_0._O0o0.();
				IL_44:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_5B:
				num = 3;
				C1FlexGrid[] array = new C1FlexGrid[]
				{
					this.Oo0o_.oo00O0.(),
					this.O_0._O0o0.()
				};
				IL_76:
				num = 4;
				foreach (C1FlexGrid c1FlexGrid in array)
				{
					IL_87:
					num = 5;
					c1FlexGrid.Styles.SelectedColumnHeader.Clear();
					IL_9A:
					num = 6;
					c1FlexGrid.Styles.Alternate.Clear();
					IL_AD:
					num = 7;
					c1FlexGrid.Styles.Focus.Clear();
					IL_C0:
					num = 8;
					c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal);
					IL_DF:
					num = 9;
					c1FlexGrid.FocusRect = FocusRectEnum.Solid;
					IL_EA:
					num = 10;
					c1FlexGrid.AllowSorting = AllowSortingEnum.None;
					IL_F5:
					num = 11;
				}
				IL_109:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_110:
				num = 13;
				this.OO_OO0O.o. = A_1;
				IL_11A:
				num = 14;
				ListDictionary listDictionary = new ListDictionary();
				IL_124:
				num = 15;
				ListDictionary listDictionary2 = new ListDictionary();
				IL_12E:
				num = 16;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				IL_138:
				num = 17;
				IEnumerator<Col> enumerator = A_1.Cols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Col col = enumerator.Current;
					IL_153:
					num = 18;
					dictionary.Add(col.Name, col.Caption);
					IL_16B:
					num = 19;
				}
				IL_177:
				num = 20;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_185:
				num = 21;
				this.Oo0o_.oo00O0.().Cols["Name"].DataMap = dictionary;
				IL_1A4:
				num = 22;
				this.O_0._O0o0.().Cols["Name"].DataMap = dictionary;
				IL_1C3:
				num = 23;
				listDictionary.Add(AggregateEnum.Sum, "累计值");
				IL_1D8:
				num = 24;
				listDictionary.Add(AggregateEnum.Average, "平均值");
				IL_1ED:
				num = 25;
				listDictionary.Add(AggregateEnum.Count, "记录数");
				IL_202:
				num = 26;
				listDictionary.Add(AggregateEnum.Max, "最大值");
				IL_217:
				num = 27;
				listDictionary.Add(AggregateEnum.Min, "最小值");
				IL_22C:
				num = 28;
				this.O_0._O0o0.().Cols["Aggregate"].DataMap = listDictionary;
				IL_24B:
				num = 29;
				listDictionary2.Add(DateGroupEnum.Month, "月");
				IL_260:
				num = 30;
				listDictionary2.Add(DateGroupEnum.Quarter, "季");
				IL_275:
				num = 31;
				listDictionary2.Add(DateGroupEnum.Year, "年");
				IL_28A:
				num = 32;
				listDictionary2.Add(DateGroupEnum.Week, "周");
				IL_29F:
				num = 33;
				listDictionary2.Add(DateGroupEnum.Day, "日");
				IL_2B4:
				num = 34;
				listDictionary2.Add(DateGroupEnum.Hour, "时");
				IL_2C9:
				num = 35;
				listDictionary2.Add(DateGroupEnum.Minute, "分");
				IL_2DE:
				num = 36;
				listDictionary2.Add(DateGroupEnum.Second, "秒");
				IL_2F3:
				num = 37;
				listDictionary2.Add(DateGroupEnum.DayOfWeek, "周日");
				IL_309:
				num = 38;
				listDictionary2.Add(DateGroupEnum.DayOfYear, "年日");
				IL_31F:
				num = 39;
				listDictionary2.Add(DateGroupEnum.None, "无");
				IL_334:
				num = 40;
				this.Oo0o_.oo00O0.().Cols["DateGroup"].DataMap = listDictionary2;
				bool flag;
				int num3;
				do
				{
					IL_353:
					num = 42;
					flag = false;
					IL_359:
					num = 43;
					num3++;
					IL_362:
					num = 44;
					string right = "统计表" + Conversions.ToString(num3);
					IL_378:
					num = 45;
					IEnumerator<DataTable> enumerator2 = OO_00oOO.DataTables.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataTable dataTable = enumerator2.Current;
						IL_392:
						num = 46;
						if (Operators.CompareString(dataTable.Name, right, true) == 0)
						{
							IL_3A6:
							num = 47;
							flag = true;
							break;
						}
						IL_3AE:
						num = 49;
					}
					IL_3BA:
					num = 50;
					if (enumerator2 != null)
					{
						enumerator2.Dispose();
					}
					IL_3C8:
					num = 51;
				}
				while (flag);
				IL_3CF:
				num = 52;
				this.o.0O_O0_0OO.().Value = "统计表" + Conversions.ToString(num3);
				IL_3EE:
				num = 53;
				if (A_0 || A_1.O_0._O_0OO000O. == null)
				{
					goto IL_8F2;
				}
				IL_402:
				num = 54;
				GroupTableBuilder groupTableBuilder = A_1.O_0._O_0OO000O.;
				IL_40D:
				num = 55;
				this.o.0O_O0_0OO.().Value = groupTableBuilder.TableName;
				IL_422:
				num = 56;
				this.O.00O0oo0o_o_o.().Value = groupTableBuilder.Caption;
				IL_437:
				num = 57;
				this.O_0._O0o0.().Value = groupTableBuilder.ExtendFilter;
				IL_44C:
				num = 58;
				this.o00_.oo0O_.().Checked = A_1.O_0._O_0OO000O..VerticalTotal;
				IL_465:
				num = 59;
				this.O_Oo.OOO00o_O.().Checked = A_1.O_0._O_0OO000O..Subtotal;
				IL_47E:
				num = 60;
				this.o0o_0o00.0o.().Checked = A_1.O_0._O_0OO000O..GrandProportion;
				IL_497:
				num = 61;
				this.Oo__.O0_o0OOoO.().Checked = A_1.O_0._O_0OO000O..GroupProportion;
				IL_4B0:
				num = 62;
				this.OooooO_.O0.().Checked = A_1.O_0._O_0OO000O..SamePeriodGrowth;
				IL_4C9:
				num = 63;
				this.o_O._.().Checked = A_1.O_0._O_0OO000O..CircleGrowth;
				IL_4E2:
				num = 64;
				this.O_Oo.OOO00o_O.().Value = new decimal(A_1.O_0._O_0OO000O..Decimals);
				IL_500:
				num = 65;
				this.o._ooO.().Checked = A_1.O_0._O_0OO000O..FromServer;
				IL_519:
				num = 66;
				IEnumerator<GroupOn> enumerator3 = groupTableBuilder.Groups.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					GroupOn groupOn = enumerator3.Current;
					IL_538:
					num = 67;
					if (A_1.DataTable.DataCols.Contains(groupOn.Name))
					{
						IL_557:
						num = 69;
						this.Oo0o_.oo00O0.().AddItem(string.Concat(new string[]
						{
							groupOn.Name + "\t",
							"\t",
							groupOn.NewName,
							"\t",
							groupOn.NewCaption
						}));
						IL_5A9:
						num = 70;
						if (A_1.DataTable.DataCols[groupOn.Name].IsDate)
						{
							IL_5CA:
							num = 71;
							this.Oo0o_.oo00O0.()[this.Oo0o_.oo00O0.().Rows.Count - 1, "DateGroup"] = groupOn.DateGroup;
						}
						else
						{
							IL_5FD:
							num = 73;
							this.Oo0o_.oo00O0.()[this.Oo0o_.oo00O0.().Rows.Count - 1, "DateGroup"] = null;
						}
						IL_623:
						num = 74;
						if (Operators.CompareString(groupOn.Name, groupOn.NewName, true) != 0)
						{
							IL_63C:
							num = 75;
							this.Oo0o_.oo00O0.()[this.Oo0o_.oo00O0.().Rows.Count - 1, "NewName"] = groupOn.NewName;
						}
						else
						{
							IL_66A:
							num = 77;
							this.Oo0o_.oo00O0.()[this.Oo0o_.oo00O0.().Rows.Count - 1, "NewName"] = null;
						}
						IL_690:
						num = 78;
						if (Operators.CompareString(groupOn.NewCaption, "", true) > 0)
						{
							IL_6A8:
							num = 79;
							this.Oo0o_.oo00O0.()[this.Oo0o_.oo00O0.().Rows.Count - 1, "NewCaption"] = groupOn.NewCaption;
						}
					}
					IL_6D4:
					num = 80;
				}
				IL_6E3:
				num = 81;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_6F1:
				num = 82;
				IEnumerator<TotalOn> enumerator4 = groupTableBuilder.Totals.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					TotalOn totalOn = enumerator4.Current;
					IL_710:
					num = 83;
					if (Operators.CompareString(totalOn.NewName, totalOn.Name + "_" + Oo00.OoO_.__o.(totalOn.Aggregate), true) == 0)
					{
						IL_73F:
						num = 84;
						totalOn.NewName = "";
					}
					IL_74E:
					num = 85;
					if (A_1.DataTable.DataCols.Contains(totalOn.Name))
					{
						IL_76D:
						num = 86;
						this.O_0._O0o0.().AddItem(string.Concat(new string[]
						{
							totalOn.Name + "\t",
							"\t",
							totalOn.NewName,
							"\t",
							totalOn.NewCaption
						}));
						IL_7BF:
						num = 87;
						this.O_0._O0o0.()[this.O_0._O0o0.().Rows.Count - 1, "Aggregate"] = totalOn.Aggregate;
						IL_7F0:
						num = 88;
						if (Operators.CompareString(totalOn.Name, totalOn.NewName, true) != 0)
						{
							IL_809:
							num = 89;
							this.O_0._O0o0.()[this.O_0._O0o0.().Rows.Count - 1, "NewName"] = totalOn.NewName;
						}
						else
						{
							IL_837:
							num = 91;
							this.O_0._O0o0.()[this.O_0._O0o0.().Rows.Count - 1, "NewName"] = null;
						}
						IL_85D:
						num = 92;
						if (Operators.CompareString(totalOn.NewCaption, "", true) > 0)
						{
							IL_875:
							num = 93;
							this.O_0._O0o0.()[this.O_0._O0o0.().Rows.Count - 1, "NewCaption"] = totalOn.NewCaption;
						}
						IL_8A1:
						num = 94;
						this.O_0._O0o0.()[this.O_0._O0o0.().Rows.Count - 1, "upto"] = totalOn.upto;
					}
					IL_8D2:
					num = 95;
				}
				IL_8E1:
				num = 96;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
				IL_8EF:
				groupTableBuilder = null;
				IL_8F2:
				num = 98;
				this.Oo0o_.oo00O0.().AllowAddNew = true;
				IL_901:
				num = 99;
				this.O_0._O0o0.().AllowAddNew = true;
				IL_910:
				num = 100;
				this.O.O_0o0oo_o0.().Visible = (OO_00oOO.User.Type == UserTypeEnum.Developer);
				IL_92B:
				num = 101;
				this.o._ooO.().Enabled = A_1.AllowBackgroundStatistics;
				IL_93F:
				goto IL_B29;
				IL_944:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_AEA:
				goto IL_B1E;
				IL_AEC:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_AFC:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_AEC;
			}
			IL_B1E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_B29:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x0017F29C File Offset: 0x0017D49C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_0._O0o0.().Value = this.OO_OO0O.o..DataTable.OOoo__00O_.o_O.(this.O_0._O0o0.().Text, true);
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x0017F2C8 File Offset: 0x0017D4C8
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
				GroupTableBuilder groupTableBuilder = this.oO0Ooo.00O_.();
				IL_10:
				num2 = 3;
				if (groupTableBuilder == null)
				{
					goto IL_8EB;
				}
				IL_18:
				num2 = 5;
				StringBuilder stringBuilder = new StringBuilder();
				IL_21:
				num2 = 6;
				stringBuilder.Append(string.Concat(new string[]
				{
					"Dim g As New GroupTableBuilder(\"",
					groupTableBuilder.TableName,
					"\", DataTables(\"",
					groupTableBuilder.SourceDataTable.Name,
					"\"))"
				}));
				IL_65:
				num2 = 7;
				stringBuilder.Append("\r\n");
				IL_74:
				num2 = 8;
				if (Operators.CompareString(groupTableBuilder.Caption, "", true) <= 0)
				{
					goto IL_BA;
				}
				IL_8A:
				num2 = 9;
				stringBuilder.Append("g.Caption = \"" + groupTableBuilder.Caption + "\"");
				IL_AA:
				num2 = 10;
				stringBuilder.Append("\r\n");
				IL_BA:
				num2 = 11;
				IEnumerator<GroupOn> enumerator = groupTableBuilder.Groups.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GroupOn groupOn = enumerator.Current;
					IL_D8:
					num2 = 12;
					string text = "";
					IL_E2:
					num2 = 13;
					if (Operators.CompareString(groupOn.NewName, groupOn.Name, true) != 0)
					{
						IL_FB:
						num2 = 14;
						text = groupOn.NewName;
					}
					IL_107:
					num2 = 15;
					if (this.OO_OO0O.o..DataTable.DataCols[groupOn.Name].IsDate && groupOn.DateGroup != DateGroupEnum.Month)
					{
						IL_13D:
						num2 = 16;
						string text2 = "DateGroupEnum." + Enum.GetName(typeof(DateGroupEnum), groupOn.DateGroup);
						IL_167:
						num2 = 17;
						if (Operators.CompareString(groupOn.NewCaption, "", true) > 0)
						{
							IL_17F:
							num2 = 18;
							stringBuilder.Append(string.Concat(new string[]
							{
								"g.Groups.AddDef(\"",
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
							IL_1E1:
							num2 = 20;
							if (Operators.CompareString(text, "", true) > 0)
							{
								IL_1F4:
								num2 = 21;
								stringBuilder.Append(string.Concat(new string[]
								{
									"g.Groups.AddDef(\"",
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
								IL_243:
								num2 = 23;
								stringBuilder.Append(string.Concat(new string[]
								{
									"g.Groups.AddDef(\"",
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
						IL_285:
						num2 = 25;
						if (Operators.CompareString(groupOn.NewCaption, "", true) > 0)
						{
							IL_29D:
							num2 = 26;
							stringBuilder.Append(string.Concat(new string[]
							{
								"g.Groups.AddDef(\"",
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
							IL_2EE:
							num2 = 28;
							if (Operators.CompareString(text, "", true) > 0)
							{
								IL_301:
								num2 = 29;
								stringBuilder.Append(string.Concat(new string[]
								{
									"g.Groups.AddDef(\"",
									groupOn.Name,
									"\", \"",
									text,
									"\")"
								}));
							}
							else
							{
								IL_340:
								num2 = 31;
								stringBuilder.Append("g.Groups.AddDef(\"" + groupOn.Name + "\")");
							}
						}
					}
					IL_361:
					num2 = 32;
					stringBuilder.Append("\r\n");
					IL_371:
					num2 = 33;
				}
				IL_380:
				num2 = 34;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_38E:
				num2 = 35;
				IEnumerator<TotalOn> enumerator2 = groupTableBuilder.Totals.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					TotalOn totalOn = enumerator2.Current;
					IL_3AC:
					num2 = 36;
					string text3 = "";
					IL_3B6:
					num2 = 37;
					if (Operators.CompareString(totalOn.NewName, totalOn.Name, true) != 0)
					{
						IL_3CF:
						num2 = 38;
						text3 = totalOn.NewName;
					}
					IL_3DB:
					num2 = 39;
					if (totalOn.Aggregate == AggregateEnum.Sum)
					{
						IL_3EB:
						num2 = 40;
						if (Operators.CompareString(totalOn.NewCaption, "", true) > 0)
						{
							IL_403:
							num2 = 41;
							stringBuilder.Append(string.Concat(new string[]
							{
								"g.Totals.AddDef(\"",
								totalOn.Name,
								"\", \"",
								text3,
								"\", \"",
								totalOn.NewCaption,
								"\""
							}));
						}
						else
						{
							IL_457:
							num2 = 43;
							if (Operators.CompareString(text3, "", true) > 0)
							{
								IL_46A:
								num2 = 44;
								stringBuilder.Append(string.Concat(new string[]
								{
									"g.Totals.AddDef(\"",
									totalOn.Name,
									"\", \"",
									text3,
									"\""
								}));
							}
							else
							{
								IL_4AC:
								num2 = 46;
								stringBuilder.Append("g.Totals.AddDef(\"" + totalOn.Name + "\"");
							}
						}
					}
					else
					{
						IL_4D2:
						num2 = 48;
						string text4 = "AggregateEnum." + Enum.GetName(typeof(AggregateEnum), totalOn.Aggregate);
						IL_4FC:
						num2 = 49;
						if (Operators.CompareString(totalOn.NewCaption, "", true) > 0)
						{
							IL_514:
							num2 = 50;
							stringBuilder.Append(string.Concat(new string[]
							{
								"g.Totals.AddDef(\"",
								totalOn.Name,
								"\", ",
								text4,
								", \"",
								text3,
								"\", \"",
								totalOn.NewCaption,
								"\""
							}));
						}
						else
						{
							IL_576:
							num2 = 52;
							if (Operators.CompareString(text3, "", true) > 0)
							{
								IL_589:
								num2 = 53;
								stringBuilder.Append(string.Concat(new string[]
								{
									"g.Totals.AddDef(\"",
									totalOn.Name,
									"\", ",
									text4,
									", \"",
									text3,
									"\""
								}));
							}
							else
							{
								IL_5D5:
								num2 = 55;
								stringBuilder.Append("g.Totals.AddDef(\"" + totalOn.Name + "\", " + text4);
							}
						}
					}
					IL_5F8:
					num2 = 56;
					if (totalOn.upto)
					{
						IL_604:
						num2 = 57;
						stringBuilder.Append(",True");
					}
					IL_614:
					num2 = 58;
					stringBuilder = stringBuilder.Append(")");
					IL_625:
					num2 = 59;
					stringBuilder.Append("\r\n");
					IL_635:
					num2 = 60;
				}
				IL_644:
				num2 = 61;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_652:
				num2 = 62;
				if (!this.o00_.oo0O_.().Checked)
				{
					goto IL_682;
				}
				IL_662:
				num2 = 63;
				stringBuilder.Append("g.VerticalTotal = True");
				IL_672:
				num2 = 64;
				stringBuilder.Append("\r\n");
				IL_682:
				num2 = 65;
				if (!this.O_Oo.OOO00o_O.().Checked)
				{
					goto IL_6B2;
				}
				IL_692:
				num2 = 66;
				stringBuilder.Append("g.SubTotal = True");
				IL_6A2:
				num2 = 67;
				stringBuilder.Append("\r\n");
				IL_6B2:
				num2 = 68;
				if (!this.Oo__.O0_o0OOoO.().Checked)
				{
					goto IL_6E2;
				}
				IL_6C2:
				num2 = 69;
				stringBuilder.Append("g.GroupProportion = True");
				IL_6D2:
				num2 = 70;
				stringBuilder.Append("\r\n");
				IL_6E2:
				num2 = 71;
				if (!this.o0o_0o00.0o.().Checked)
				{
					goto IL_712;
				}
				IL_6F2:
				num2 = 72;
				stringBuilder.Append("g.GrandProportion = True");
				IL_702:
				num2 = 73;
				stringBuilder.Append("\r\n");
				IL_712:
				num2 = 74;
				if (!this.OooooO_.O0.().Checked)
				{
					goto IL_742;
				}
				IL_722:
				num2 = 75;
				stringBuilder.Append("g.SamePeriodGrowth = True");
				IL_732:
				num2 = 76;
				stringBuilder.Append("\r\n");
				IL_742:
				num2 = 77;
				if (!this.o_O._.().Checked)
				{
					goto IL_772;
				}
				IL_752:
				num2 = 78;
				stringBuilder.Append("g.CircleGrowth = True");
				IL_762:
				num2 = 79;
				stringBuilder.Append("\r\n");
				IL_772:
				num2 = 80;
				if (decimal.Compare(this.O_Oo.OOO00o_O.().Value, 4m) == 0)
				{
					goto IL_7C8;
				}
				IL_78E:
				num2 = 81;
				stringBuilder.Append("g.Decimals = " + Conversions.ToString(Convert.ToInt32(this.O_Oo.OOO00o_O.().Value)));
				IL_7B8:
				num2 = 82;
				stringBuilder.Append("\r\n");
				IL_7C8:
				num2 = 83;
				if (!this.o._ooO.().Checked)
				{
					goto IL_81F;
				}
				IL_7D8:
				num2 = 84;
				if (!this.OO_OO0O.o..DataTable.frd_IsInnerTable && !this.OO_OO0O.o..DataTable.frd_IsOuterTable)
				{
					goto IL_81F;
				}
				IL_7FF:
				num2 = 85;
				stringBuilder.Append("g.FromServer = True");
				IL_80F:
				num2 = 86;
				stringBuilder.Append("\r\n");
				IL_81F:
				num2 = 87;
				if (Operators.CompareString(this.O_0._O0o0.().Text, "", true) <= 0)
				{
					goto IL_870;
				}
				IL_83B:
				num2 = 88;
				stringBuilder.Append("g.Filter = \"" + this.O_0._O0o0.().Text + "\"");
				IL_860:
				num2 = 89;
				stringBuilder.Append("\r\n");
				IL_870:
				num2 = 90;
				stringBuilder.Append("g.Build()");
				IL_880:
				num2 = 91;
				stringBuilder.Append("\r\n");
				IL_890:
				num2 = 92;
				stringBuilder.Append("MainTable = Tables(\"" + groupTableBuilder.TableName + "\")");
				IL_8B0:
				num2 = 93;
				o\u3000\u3000\u3002\u3002O o_u3000_u3000_u3002_u3002O = new o\u3000\u3000\u3002\u3002O();
				IL_8BA:
				num2 = 94;
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().Text = stringBuilder.ToString();
				IL_8D0:
				num2 = 95;
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().SelectionStart = 0;
				IL_8E0:
				num2 = 96;
				o_u3000_u3000_u3002_u3002O.ShowDialog();
				IL_8EB:
				goto IL_AC1;
				IL_8F0:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_A82:
				goto IL_AB6;
				IL_A84:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_A94:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_A84;
			}
			IL_AB6:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_AC1:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x0017FDBC File Offset: 0x0017DFBC
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

		// Token: 0x060036E2 RID: 14050 RVA: 0x0017FE10 File Offset: 0x0017E010
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o._ooO.().Checked)
			{
				this.oo.0O.().Enabled = false;
				if (!this.OO_OO0O.o..DataTable.frd_IsInnerTable)
				{
					this.OO_OO0O.o..DataTable.frd_IsOuterTable;
					return;
				}
			}
			else
			{
				if (this.OO_OO0O.o..O.OoOo_. != null && this.OO_OO0O.o..O.OoOo_..FindForm() == Main.OO_O.o. && Operators.CompareString(this.OO_OO0O.o..DataTable.LoadTop, "", true) > 0 && this.OO_OO0O.o..AllowBackEndFilter)
				{
					this.oo.0O.().Enabled = false;
					return;
				}
				this.oo.0O.().Enabled = true;
			}
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x0017FEC2 File Offset: 0x0017E0C2
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O.00o__oo. == 0)
			{
				this.O.00o__oo. = 1;
				this.OO_OO0O.o..Oo0Oo___.o0o.();
			}
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x0017FEE0 File Offset: 0x0017E0E0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OO_OO0O.o..Rows.Count < 2)
			{
				this.o._ooO.().Checked = true;
			}
			if (this.OO_OO0O.o..O.OoOo_. != null && this.OO_OO0O.o..O.OoOo_..FindForm() == Main.OO_O.o. && Operators.CompareString(this.OO_OO0O.o..DataTable.LoadTop, "", true) > 0 && this.OO_OO0O.o..AllowBackEndFilter)
			{
				this.oo.0O.().Enabled = false;
			}
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x0017FF67 File Offset: 0x0017E167
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400162D RID: 5677
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400162E RID: 5678
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x0400162F RID: 5679
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001630 RID: 5680
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001631 RID: 5681
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001632 RID: 5682
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001633 RID: 5683
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001634 RID: 5684
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001635 RID: 5685
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001636 RID: 5686
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001637 RID: 5687
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001638 RID: 5688
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001639 RID: 5689
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400163A RID: 5690
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400163B RID: 5691
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400163C RID: 5692
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x0400163D RID: 5693
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x0400163E RID: 5694
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x0400163F RID: 5695
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04001640 RID: 5696
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04001641 RID: 5697
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001642 RID: 5698
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04001643 RID: 5699
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001644 RID: 5700
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001645 RID: 5701
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001646 RID: 5702
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001647 RID: 5703
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001648 RID: 5704
		[CompilerGenerated]
		private GroupBox <<EMPTY_NAME>>;

		// Token: 0x04001649 RID: 5705
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400164A RID: 5706
		[CompilerGenerated]
		private NumericUpDown <<EMPTY_NAME>>;

		// Token: 0x0400164B RID: 5707
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400164C RID: 5708
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400164D RID: 5709
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400164E RID: 5710
		private int <<EMPTY_NAME>>;
	}
}
