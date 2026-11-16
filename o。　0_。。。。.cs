using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000391 RID: 913
	[DesignerGenerated]
	internal partial class o\u3002\u30000_\u3002\u3002\u3002\u3002 : Form
	{
		// Token: 0x06003B90 RID: 15248 RVA: 0x001B03D6 File Offset: 0x001AE5D6
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.o_oOoOo_.O_o_O. != null)
			{
				this.o_oOoOo_.O_o_O..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x001B03F8 File Offset: 0x001AE5F8
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(o\u3002\u30000_\u3002\u3002\u3002\u3002));
			this.oO__.O.(new C1ComboBox());
			this.OO._O_.(new C1Button());
			this.o_Oo.O0o.(new C1Button());
			this.oO__.O.(new C1Button());
			this.O_o0OO_o_O.o.(new Label());
			this.oOOo._O_o000oO.(new C1TextBox());
			this.oO__.O.(new C1DockingTab());
			this.oO_O0__0_00.00.(new C1DockingTabPage());
			this.oO__.O.(new GroupBox());
			this.OOoOOO.OOo.(new C1TextBox());
			this.o_o._0_o0o_0__.(new Label());
			this.o._o0_o_0O0_0O.(new Panel());
			this.o._o0_o_0O0_0O.(new RadioButton());
			this.o0OOo.0O0Oo.(new RadioButton());
			this.OOoo_O_00oO0._.(new RadioButton());
			this.OOoOOO.OOo.(new C1NumericEdit());
			this.oO_O0__0_00.00.(new RadioButton());
			this.oo_o_ooO0O.00.(new C1Button());
			this.O_0o0._0oO_O0.(new RadioButton());
			this.OOoo_O_00oO0._.(new C1TextBox());
			this.oO_O0__0_00.00.(new Label());
			this.o0oO.o0o.(new C1ComboBox());
			this.oO__.O.(new Label());
			this.o._o0_o_0O0_0O.(new C1DockingTabPage());
			this.o0o.o_o.(new Label());
			this.o0OOo.0O0Oo.(new C1TextBox());
			this.o_0oO__0o0o.__.(new Label());
			this.oo.OO.(new Label());
			((ISupportInitialize)this.O0000_O.O.()).BeginInit();
			this.O0000_O.O.().SuspendLayout();
			this.o00OO.0_00__0.().SuspendLayout();
			this.o000O0o._O.().SuspendLayout();
			this.O0OOOO.O0o0_.().SuspendLayout();
			((ISupportInitialize)this.OOo.00_.()).BeginInit();
			this.O0OOOO.O0o0_.().SuspendLayout();
			base.SuspendLayout();
			this.O_00__.oo.().DropDownStyle = DropDownStyle.DropDownList;
			this.O_00__.oo.().Location = new Point(76, 56);
			this.O_00__.oo.().Name = "cmbSourceTable";
			this.O_00__.oo.().Size = new Size(356, 20);
			this.O_00__.oo.().TabIndex = 1;
			this.oO.O00_O_0o_O.().Location = new Point(412, 482);
			this.oO.O00_O_0o_O.().Name = "btnAccept";
			this.oO.O00_O_0o_O.().Size = new Size(75, 23);
			this.oO.O00_O_0o_O.().TabIndex = 2;
			this.oO.O00_O_0o_O.().Text = "确定";
			this.oO.O00_O_0o_O.().UseVisualStyleBackColor = true;
			this.Oo.__0__0.().DialogResult = DialogResult.Cancel;
			this.Oo.__0__0.().Location = new Point(493, 482);
			this.Oo.__0__0.().Name = "btnCancel";
			this.Oo.__0__0.().Size = new Size(75, 23);
			this.Oo.__0__0.().TabIndex = 3;
			this.Oo.__0__0.().Text = "取消";
			this.Oo.__0__0.().UseVisualStyleBackColor = true;
			this.o.o0_0.().Location = new Point(22, 482);
			this.o.o0_0.().Name = "btnPreview";
			this.o.o0_0.().Size = new Size(75, 23);
			this.o.o0_0.().TabIndex = 1;
			this.o.o0_0.().Text = "预览";
			this.o.o0_0.().UseVisualStyleBackColor = true;
			this.O0_.0o0O.().AutoSize = true;
			this.O0_.0o0O.().Location = new Point(23, 30);
			this.O0_.0o0O.().Name = "Label3";
			this.O0_.0o0O.().Size = new Size(59, 12);
			this.O0_.0o0O.().TabIndex = 0;
			this.O0_.0o0O.().Text = "过滤条件:";
			this.OOo.00_.().Location = new Point(25, 51);
			this.OOo.00_.().Multiline = true;
			this.OOo.00_.().Name = "txtFilter";
			this.OOo.00_.().ScrollBars = ScrollBars.Vertical;
			this.OOo.00_.().Size = new Size(490, 168);
			this.OOo.00_.().TabIndex = 1;
			this.O0000_O.O.().Controls.Add(this.o00OO.0_00__0.());
			this.O0000_O.O.().Controls.Add(this.O0OOOO.O0o0_.());
			this.O0000_O.O.().Location = new Point(22, 12);
			this.O0000_O.O.().Name = "C1DockingTab1";
			this.O0000_O.O.().Size = new Size(546, 455);
			this.O0000_O.O.().TabIndex = 0;
			this.O0000_O.O.().TabsSpacing = 0;
			this.O0000_O.O.().TabStyle = TabStyleEnum.WindowsXP;
			this.O0000_O.O.().VisualStyle = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.O0000_O.O.().VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.o00OO.0_00__0.().Controls.Add(this.o000O0o._O.());
			this.o00OO.0_00__0.().Controls.Add(this.O_0oO.0.());
			this.o00OO.0_00__0.().Controls.Add(this.o000O0o._O.());
			this.o00OO.0_00__0.().Controls.Add(this.O00_OO_.00.());
			this.o00OO.0_00__0.().Controls.Add(this.O_00__.oo.());
			this.o00OO.0_00__0.().Location = new Point(2, 26);
			this.o00OO.0_00__0.().Name = "pageDataSource";
			this.o00OO.0_00__0.().Size = new Size(540, 425);
			this.o00OO.0_00__0.().TabIndex = 1;
			this.o00OO.0_00__0.().Text = "数据源";
			this.o000O0o._O.().Controls.Add(this.OO._O_.());
			this.o000O0o._O.().Controls.Add(this.o000O0o._O.());
			this.o000O0o._O.().Controls.Add(this.O0OOOO.O0o0_.());
			this.o000O0o._O.().Controls.Add(this.O0O0O.0_.());
			this.o000O0o._O.().Controls.Add(this.O0000_O.O.());
			this.o000O0o._O.().Controls.Add(this.o00OO.0_00__0.());
			this.o000O0o._O.().Controls.Add(this.o0_o_0O_0O_.o.());
			this.o000O0o._O.().Location = new Point(25, 92);
			this.o000O0o._O.().Name = "GroupBox1";
			this.o000O0o._O.().Size = new Size(490, 317);
			this.o000O0o._O.().TabIndex = 26;
			this.o000O0o._O.().TabStop = false;
			this.o000O0o._O.().Text = "选项";
			this.OO._O_.().Location = new Point(324, 45);
			this.OO._O_.().Name = "txtSEQUENCE";
			this.OO._O_.().Size = new Size(137, 21);
			this.OO._O_.().TabIndex = 39;
			this.o000O0o._O.().AutoSize = true;
			this.o000O0o._O.().Location = new Point(324, 24);
			this.o000O0o._O.().Name = "Label1";
			this.o000O0o._O.().Size = new Size(83, 12);
			this.o000O0o._O.().TabIndex = 38;
			this.o000O0o._O.().Text = "主键序列名称:";
			this.O0OOOO.O0o0_.().Controls.Add(this.OO0.oO_o.());
			this.O0OOOO.O0o0_.().Controls.Add(this.O0OOOO.O0o0_.());
			this.O0OOOO.O0o0_.().Controls.Add(this.o0_o_0O_0O_.o.());
			this.O0OOOO.O0o0_.().Controls.Add(this.OOo.00_.());
			this.O0OOOO.O0o0_.().Location = new Point(9, 24);
			this.O0OOOO.O0o0_.().Name = "Panel1";
			this.O0OOOO.O0o0_.().Size = new Size(290, 80);
			this.O0OOOO.O0o0_.().TabIndex = 37;
			this.OO0.oO_o.().AutoSize = true;
			this.OO0.oO_o.().Location = new Point(17, 56);
			this.OO0.oO_o.().Name = "rdoAllRows";
			this.OO0.oO_o.().Size = new Size(83, 16);
			this.OO0.oO_o.().TabIndex = 0;
			this.OO0.oO_o.().Text = "加载所有行";
			this.OO0.oO_o.().UseVisualStyleBackColor = true;
			this.O0OOOO.O0o0_.().AutoSize = true;
			this.O0OOOO.O0o0_.().Location = new Point(17, 31);
			this.O0OOOO.O0o0_.().Name = "rdoRowsPercent";
			this.O0OOOO.O0o0_.().Size = new Size(113, 16);
			this.O0OOOO.O0o0_.().TabIndex = 2;
			this.O0OOOO.O0o0_.().Text = "默认加载百分比:";
			this.O0OOOO.O0o0_.().UseVisualStyleBackColor = true;
			this.o0_o_0O_0O_.o.().AutoSize = true;
			this.o0_o_0O_0O_.o.().Checked = true;
			this.o0_o_0O_0O_.o.().Location = new Point(17, 6);
			this.o0_o_0O_0O_.o.().Name = "rdoRows";
			this.o0_o_0O_0O_.o.().Size = new Size(101, 16);
			this.o0_o_0O_0O_.o.().TabIndex = 1;
			this.o0_o_0O_0O_.o.().TabStop = true;
			this.o0_o_0O_0O_.o.().Text = "默认加载行数:";
			this.o0_o_0O_0O_.o.().UseVisualStyleBackColor = true;
			this.OOo.00_.().DataType = typeof(int);
			this.OOo.00_.().ErrorInfo.ShowErrorMessage = false;
			this.OOo.00_.().Location = new Point(158, 29);
			this.OOo.00_.().Name = "txtTop";
			this.OOo.00_.().PostValidation.Intervals.AddRange(new ValueInterval[]
			{
				new ValueInterval(1L, RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("txtTop.PostValidation.Intervals")), true, true)
			});
			this.OOo.00_.().Size = new Size(114, 21);
			this.OOo.00_.().TabIndex = 0;
			this.OOo.00_.().Tag = null;
			this.OOo.00_.().Value = 10;
			this.O0O0O.0_.().AutoSize = true;
			this.O0O0O.0_.().Checked = true;
			this.O0O0O.0_.().Location = new Point(28, 114);
			this.O0O0O.0_.().Name = "rdoAllFields";
			this.O0O0O.0_.().Size = new Size(83, 16);
			this.O0O0O.0_.().TabIndex = 1;
			this.O0O0O.0_.().TabStop = true;
			this.O0O0O.0_.().Text = "包括所有列";
			this.O0O0O.0_.().UseVisualStyleBackColor = true;
			this.O0000_O.O.().Enabled = false;
			this.O0000_O.O.().Location = new Point(386, 107);
			this.O0000_O.O.().Name = "btnSelectColumns";
			this.O0000_O.O.().Size = new Size(75, 23);
			this.O0000_O.O.().TabIndex = 4;
			this.O0000_O.O.().Text = "选择列";
			this.O0000_O.O.().UseVisualStyleBackColor = true;
			this.o00OO.0_00__0.().AutoSize = true;
			this.o00OO.0_00__0.().Location = new Point(122, 114);
			this.o00OO.0_00__0.().Name = "rdoInclude";
			this.o00OO.0_00__0.().Size = new Size(83, 16);
			this.o00OO.0_00__0.().TabIndex = 2;
			this.o00OO.0_00__0.().Text = "包括以下列";
			this.o00OO.0_00__0.().UseVisualStyleBackColor = true;
			this.o0_o_0O_0O_.o.().Location = new Point(26, 144);
			this.o0_o_0O_0O_.o.().Multiline = true;
			this.o0_o_0O_0O_.o.().Name = "txtFields";
			this.o0_o_0O_0O_.o.().ReadOnly = true;
			this.o0_o_0O_0O_.o.().ScrollBars = ScrollBars.Vertical;
			this.o0_o_0O_0O_.o.().Size = new Size(435, 149);
			this.o0_o_0O_0O_.o.().TabIndex = 5;
			this.O_0oO.0.().AutoSize = true;
			this.O_0oO.0.().Location = new Point(23, 30);
			this.O_0oO.0.().Name = "Label2";
			this.O_0oO.0.().Size = new Size(47, 12);
			this.O_0oO.0.().TabIndex = 2;
			this.O_0oO.0.().Text = "数据源:";
			this.o000O0o._O.().DropDownStyle = DropDownStyle.DropDownList;
			this.o000O0o._O.().Location = new Point(76, 27);
			this.o000O0o._O.().Name = "cmbDataSource";
			this.o000O0o._O.().Size = new Size(356, 20);
			this.o000O0o._O.().TabIndex = 0;
			this.O00_OO_.00.().AutoSize = true;
			this.O00_OO_.00.().Location = new Point(23, 58);
			this.O00_OO_.00.().Name = "Label10";
			this.O00_OO_.00.().Size = new Size(47, 12);
			this.O00_OO_.00.().TabIndex = 20;
			this.O00_OO_.00.().Text = "数据表:";
			this.O0OOOO.O0o0_.().Controls.Add(this.O__O.o.());
			this.O0OOOO.O0o0_.().Controls.Add(this.o_Oo.O0o.());
			this.O0OOOO.O0o0_.().Controls.Add(this.OO____O0.00.());
			this.O0OOOO.O0o0_.().Controls.Add(this.OOo.00_.());
			this.O0OOOO.O0o0_.().Controls.Add(this.O0_.0o0O.());
			this.O0OOOO.O0o0_.().Controls.Add(this.o00OO.0_00__0.());
			this.O0OOOO.O0o0_.().Location = new Point(2, 26);
			this.O0OOOO.O0o0_.().Name = "PageFilter";
			this.O0OOOO.O0o0_.().Size = new Size(540, 425);
			this.O0OOOO.O0o0_.().TabIndex = 0;
			this.O0OOOO.O0o0_.().Text = "过滤/排序";
			this.O__O.o.().Location = new Point(22, 316);
			this.O__O.o.().Name = "Label11";
			this.O__O.o.().Size = new Size(493, 50);
			this.O__O.o.().TabIndex = 4;
			this.O__O.o.().Text = "提示:直接输入排序的列名称，各列用逗号分割，如果降序排列，列名称后加上DESC，例如： OrderId DESC，表示根据OrderID降序排序";
			this.o_Oo.O0o.().Location = new Point(25, 286);
			this.o_Oo.O0o.().Name = "txtOrder";
			this.o_Oo.O0o.().Size = new Size(490, 21);
			this.o_Oo.O0o.().TabIndex = 3;
			this.OO____O0.00.().AutoSize = true;
			this.OO____O0.00.().Location = new Point(25, 229);
			this.OO____O0.00.().Name = "Label12";
			this.OO____O0.00.().Size = new Size(473, 12);
			this.OO____O0.00.().TabIndex = 10;
			this.OO____O0.00.().Text = "提示：过滤条件的语法基本相同，但是函数和数据源的类型有关，具体请参考相关文档。";
			this.o00OO.0_00__0.().AutoSize = true;
			this.o00OO.0_00__0.().Location = new Point(23, 268);
			this.o00OO.0_00__0.().Name = "Label5";
			this.o00OO.0_00__0.().Size = new Size(59, 12);
			this.o00OO.0_00__0.().TabIndex = 2;
			this.o00OO.0_00__0.().Text = "排序规则:";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(590, 515);
			base.Controls.Add(this.O0000_O.O.());
			base.Controls.Add(this.o.o0_0.());
			base.Controls.Add(this.Oo.__0__0.());
			base.Controls.Add(this.oO.O00_O_0o_O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O..Oo...";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "设置外部表";
			((ISupportInitialize)this.O0000_O.O.()).EndInit();
			this.O0000_O.O.().ResumeLayout(false);
			this.o00OO.0_00__0.().ResumeLayout(false);
			this.o00OO.0_00__0.().PerformLayout();
			this.o000O0o._O.().ResumeLayout(false);
			this.o000O0o._O.().PerformLayout();
			this.O0OOOO.O0o0_.().ResumeLayout(false);
			this.O0OOOO.O0o0_.().PerformLayout();
			((ISupportInitialize)this.OOo.00_.()).EndInit();
			this.O0OOOO.O0o0_.().ResumeLayout(false);
			this.O0OOOO.O0o0_.().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x001B1436 File Offset: 0x001AF636
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O.o_oO.;
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x001B143E File Offset: 0x001AF63E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.O.o_oO. = A_0;
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x001B1447 File Offset: 0x001AF647
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOOo._O_o000oO.;
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x001B1450 File Offset: 0x001AF650
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0_o_.____O.);
			C1Button c1Button = this.oOOo._O_o000oO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOOo._O_o000oO. = A_0;
			c1Button = this.oOOo._O_o000oO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x001B1493 File Offset: 0x001AF693
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOoOOO.OOo.;
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x001B149B File Offset: 0x001AF69B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.OOoOOO.OOo. = A_0;
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x001B14A4 File Offset: 0x001AF6A4
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.0000o.;
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x001B14AC File Offset: 0x001AF6AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOO._.);
			C1Button o.0000o. = this.O.0000o.;
			if (o.0000o. != null)
			{
				o.0000o..Click -= value;
			}
			this.O.0000o. = A_0;
			o.0000o. = this.O.0000o.;
			if (o.0000o. != null)
			{
				o.0000o..Click += value;
			}
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x001B14EF File Offset: 0x001AF6EF
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_OOo._O_O_0.;
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x001B14F7 File Offset: 0x001AF6F7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_OOo._O_O_0. = A_0;
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x001B1500 File Offset: 0x001AF700
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o_oOoOo_.O_o_O.;
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x001B1508 File Offset: 0x001AF708
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o_oOoOo_.O_o_O. = A_0;
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x001B1511 File Offset: 0x001AF711
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.O.o_oO.;
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x001B1519 File Offset: 0x001AF719
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			this.O.o_oO. = A_0;
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x001B1522 File Offset: 0x001AF722
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.O.o_oO.;
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x001B152A File Offset: 0x001AF72A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			this.O.o_oO. = A_0;
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x001B1533 File Offset: 0x001AF733
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.O_OOo._O_O_0.;
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x001B153B File Offset: 0x001AF73B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.O_OOo._O_O_0. = A_0;
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x001B1544 File Offset: 0x001AF744
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.ooo_o_O00.oO.;
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x001B154C File Offset: 0x001AF74C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.ooo_o_O00.oO. = A_0;
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x001B1555 File Offset: 0x001AF755
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.OoOO.oOo_o_O.;
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x001B155D File Offset: 0x001AF75D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.OoOO.oOo_o_O. = A_0;
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x001B1566 File Offset: 0x001AF766
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O._OOo_O.;
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x001B156E File Offset: 0x001AF76E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O._OOo_O. = A_0;
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x001B1577 File Offset: 0x001AF777
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.ooo_o_O00.oO.;
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x001B1580 File Offset: 0x001AF780
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.o_o_O.ooo0o_o.);
			C1ComboBox c1ComboBox = this.ooo_o_O00.oO.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.ooo_o_O00.oO. = A_0;
			c1ComboBox = this.ooo_o_O00.oO.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x001B15C3 File Offset: 0x001AF7C3
		[CompilerGenerated]
		internal virtual GroupBox <<EMPTY_NAME>>()
		{
			return this.O.o_oO.;
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x001B15CB File Offset: 0x001AF7CB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(GroupBox A_0)
		{
			this.O.o_oO. = A_0;
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x001B15D4 File Offset: 0x001AF7D4
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O_OOo._O_O_0.;
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x001B15DC File Offset: 0x001AF7DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.o_Oo.O0o.);
			RadioButton o_OOo._O_O_0. = this.O_OOo._O_O_0.;
			if (o_OOo._O_O_0. != null)
			{
				o_OOo._O_O_0..CheckedChanged -= value;
			}
			this.O_OOo._O_O_0. = A_0;
			o_OOo._O_O_0. = this.O_OOo._O_O_0.;
			if (o_OOo._O_O_0. != null)
			{
				o_OOo._O_O_0..CheckedChanged += value;
			}
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x001B161F File Offset: 0x001AF81F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooOOO0o0.O_.;
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x001B1628 File Offset: 0x001AF828
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO.O00_O_0o_O.);
			C1Button c1Button = this.ooOOO0o0.O_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooOOO0o0.O_. = A_0;
			c1Button = this.ooOOO0o0.O_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x001B166B File Offset: 0x001AF86B
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.OoOO.oOo_o_O.;
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x001B1674 File Offset: 0x001AF874
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.OOo.00_.);
			RadioButton ooOO.oOo_o_O. = this.OoOO.oOo_o_O.;
			if (ooOO.oOo_o_O. != null)
			{
				ooOO.oOo_o_O..CheckedChanged -= value;
			}
			this.OoOO.oOo_o_O. = A_0;
			ooOO.oOo_o_O. = this.OoOO.oOo_o_O.;
			if (ooOO.oOo_o_O. != null)
			{
				ooOO.oOo_o_O..CheckedChanged += value;
			}
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x001B16B7 File Offset: 0x001AF8B7
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_.oO00O.;
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x001B16BF File Offset: 0x001AF8BF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O_.oO00O. = A_0;
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x001B16C8 File Offset: 0x001AF8C8
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.O_.oO00O.;
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x001B16D0 File Offset: 0x001AF8D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			this.O_.oO00O. = A_0;
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x001B16D9 File Offset: 0x001AF8D9
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0_ooo.0o.;
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x001B16E1 File Offset: 0x001AF8E1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0_ooo.0o. = A_0;
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x001B16EA File Offset: 0x001AF8EA
		[CompilerGenerated]
		internal virtual Panel <<EMPTY_NAME>>()
		{
			return this.O_OOo._O_O_0.;
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x001B16F2 File Offset: 0x001AF8F2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Panel A_0)
		{
			this.O_OOo._O_O_0. = A_0;
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x001B16FB File Offset: 0x001AF8FB
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o0.O_.;
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x001B1703 File Offset: 0x001AF903
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.o0.O_. = A_0;
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x001B170C File Offset: 0x001AF90C
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.oo_O.__oO_.;
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x001B1714 File Offset: 0x001AF914
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.oo_O.__oO_. = A_0;
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x001B171D File Offset: 0x001AF91D
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0o_O.00o.;
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x001B1725 File Offset: 0x001AF925
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0o_O.00o. = A_0;
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x001B172E File Offset: 0x001AF92E
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo.0O0oOOO0.;
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x001B1736 File Offset: 0x001AF936
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo.0O0oOOO0. = A_0;
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x001B173F File Offset: 0x001AF93F
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o0.O_.;
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x001B1747 File Offset: 0x001AF947
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o0.O_. = A_0;
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x001B1750 File Offset: 0x001AF950
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O00_00_.oO0O00.;
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x001B1758 File Offset: 0x001AF958
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O00_00_.oO0O00. = A_0;
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x001B1761 File Offset: 0x001AF961
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oo_O.__oO_.;
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x001B1769 File Offset: 0x001AF969
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.oo_O.__oO_. = A_0;
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x001B1772 File Offset: 0x001AF972
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oO_.00oo00.;
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x001B177A File Offset: 0x001AF97A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oO_.00oo00. = A_0;
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x001B1784 File Offset: 0x001AF984
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.o000O0o._O.().ItemsDataSource = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()];
				IL_28:
				num2 = 3;
				this.o000O0o._O.().ItemsDisplayMember = "Name";
				IL_3A:
				num2 = 4;
				this.o000O0o._O.().ItemsValueMember = "Name";
				IL_4C:
				num2 = 5;
				if (this.o_oOoOo_.O_o_O..RowState == DataRowState.Detached)
				{
					goto IL_346;
				}
				IL_5F:
				num2 = 6;
				if (this.o_oOoOo_.O_o_O..IsNull("DataSource") || Operators.CompareString(Conversions.ToString(this.o_oOoOo_.O_o_O.["DataSource"]), "", true) <= 0)
				{
					goto IL_141;
				}
				IL_9C:
				num2 = 7;
				IEnumerator enumerator = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()].DefaultView.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRowView dataRowView = (DataRowView)obj;
					IL_CE:
					num2 = 8;
					if (Operators.CompareString(Conversions.ToString(dataRowView["Name"]), Conversions.ToString(this.o_oOoOo_.O_o_O.["DataSource"]), true) == 0)
					{
						IL_FE:
						num2 = 9;
						this.o000O0o._O.().SelectedItem = RuntimeHelpers.GetObjectValue(dataRowView["Name"]);
					}
					IL_11D:
					num2 = 10;
				}
				IL_129:
				num2 = 11;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_141:
				num2 = 12;
				if (this.o_oOoOo_.O_o_O..IsNull("Property") || Operators.CompareString(Conversions.ToString(this.o_oOoOo_.O_o_O.["Property"]), "", true) <= 0)
				{
					goto IL_291;
				}
				IL_17F:
				num2 = 13;
				OuterTableSetting outerTableSetting = new OuterTableSetting();
				IL_189:
				num2 = 14;
				o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, Conversions.ToString(this.o_oOoOo_.O_o_O.["Property"]), '\v');
				IL_1AA:
				num2 = 15;
				this.O_00__.oo.().SelectedItem = outerTableSetting.SourceTable;
				IL_1BF:
				num2 = 16;
				this.OOo.00_.().Value = outerTableSetting.Top;
				IL_1D9:
				num2 = 17;
				this.o_Oo.O0o.().Value = outerTableSetting.Order;
				IL_1EE:
				num2 = 18;
				this.OOo.00_.().Value = outerTableSetting.Filter;
				IL_203:
				num2 = 19;
				this.o0_o_0O_0O_.o.().Value = outerTableSetting.Fields;
				IL_218:
				num2 = 20;
				this.o00OO.0_00__0.().Checked = outerTableSetting.Include;
				IL_22D:
				num2 = 21;
				if (!outerTableSetting.Include)
				{
					goto IL_248;
				}
				IL_239:
				num2 = 22;
				this.O0000_O.O.().Enabled = true;
				IL_248:
				num2 = 23;
				if (!outerTableSetting.AllRows)
				{
					goto IL_265;
				}
				IL_254:
				num2 = 24;
				this.OO0.oO_o.().Checked = true;
				goto IL_291;
				IL_265:
				num2 = 26;
				if (!outerTableSetting.Percent)
				{
					goto IL_282;
				}
				IL_271:
				num2 = 27;
				this.O0OOOO.O0o0_.().Checked = true;
				goto IL_291;
				IL_282:
				num2 = 29;
				this.o0_o_0O_0O_.o.().Checked = true;
				IL_291:
				num2 = 30;
				this.Text = this.Text + " - " + Conversions.ToString(this.o_oOoOo_.O_o_O.["Name"]);
				IL_2BF:
				num2 = 31;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Rows.Find(new object[]
				{
					Conversions.ToString(this.o_oOoOo_.O_o_O.["Name"]),
					"SEQUENCE",
					ExtendTablePropertyTypeEnum.SEQUENCE
				});
				IL_310:
				num2 = 32;
				if (dataRow == null)
				{
					goto IL_35F;
				}
				IL_316:
				num2 = 33;
				if (dataRow.IsNull("Property"))
				{
					goto IL_35F;
				}
				IL_326:
				num2 = 34;
				this.OO._O_.().Value = dataRow["Property"].ToString();
				goto IL_35F;
				IL_346:
				num2 = 36;
				this.Text += " - 新建";
				IL_35F:
				num2 = 37;
				if (this.o000O0o._O.().SelectedIndex >= 0)
				{
					goto IL_395;
				}
				IL_370:
				num2 = 38;
				if (this.o000O0o._O.().Items.Count <= 0)
				{
					goto IL_395;
				}
				IL_386:
				num2 = 39;
				this.o000O0o._O.().SelectedIndex = 0;
				IL_395:
				goto IL_487;
				IL_39A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_448:
				goto IL_47C;
				IL_44A:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_45A:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_44A;
			}
			IL_47C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_487:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x001B1C3C File Offset: 0x001AFE3C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o000O0o._O.().SelectedItem == null)
			{
				this.O_00__.oo.().Items.Clear();
				return;
			}
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()].Rows.Find(RuntimeHelpers.GetObjectValue(this.o000O0o._O.().SelectedItem));
			this.O_00__.oo.().Items.Clear();
			if (!dataRow.IsNull("ConnectionString"))
			{
				try
				{
					string text = O00.oO_.0o_oo_0O_.(Conversions.ToString(dataRow["ConnectionString"]), O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.());
					if (text.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || text.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
					{
						List<string> list = new O0O(text).OO._o_OO.();
						try
						{
							foreach (string text2 in list)
							{
								if (!o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text2) && !text2.StartsWith("~"))
								{
									this.O_00__.oo.().Items.Add(text2);
								}
							}
							goto IL_2FE;
						}
						finally
						{
							List<string>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					this.o_oOoOo_.O_o_O. = new OleDbConnection(O00.oO_.0o_oo_0O_.(Conversions.ToString(dataRow["ConnectionString"]), O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.()));
					this.o_oOoOo_.O_o_O..Open();
					DataTable dataTable;
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.o_oOoOo_.O_o_O.))
					{
						DbDataAdapter dbDataAdapter = new OleDbDataAdapter("select owner,table_name from all_tables where owner not LIKE '%SYS%'", this.o_oOoOo_.O_o_O.);
						dataTable = new DataTable();
						dbDataAdapter.Fill(dataTable);
						try
						{
							foreach (object obj in dataTable.Rows)
							{
								DataRow dataRow2 = (DataRow)obj;
								this.O_00__.oo.().Items.Add(string.Concat(new string[]
								{
									"\"",
									dataRow2["OWNER"].ToString(),
									"\".\"",
									dataRow2["TABLE_NAME"].ToString(),
									"\""
								}));
							}
							goto IL_2F3;
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
					}
					dataTable = this.o_oOoOo_.O_o_O..GetSchema("Tables");
					string filterExpression = "[TABLE_TYPE]='TABLE'";
					foreach (DataRow dataRow3 in dataTable.Select(filterExpression))
					{
						string text3 = Conversions.ToString(dataRow3["TABLE_NAME"]);
						if (!dataRow3.IsNull("TABLE_SCHEMA") && Operators.CompareString(dataRow3["TABLE_SCHEMA"].ToString(), "dbo", true) != 0)
						{
							text3 = string.Concat(new string[]
							{
								"[",
								dataRow3["TABLE_SCHEMA"].ToString(),
								"].[",
								text3,
								"]"
							});
						}
						if (!text3.StartsWith("~"))
						{
							this.O_00__.oo.().Items.Add(text3);
						}
					}
					IL_2F3:
					this.o_oOoOo_.O_o_O..Close();
					IL_2FE:;
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
			}
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x001B1FB0 File Offset: 0x001B01B0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OuterTableSetting outerTableSetting = this.OOo.00_.();
			OleDbConnection oleDbConnection = null;
			if (!string.IsNullOrEmpty(outerTableSetting.SourceTable))
			{
				string text = this.o000O0o._O.().Text;
				if (O_O0OO.O._o_.().ContainsKey(text))
				{
					oleDbConnection = O_O0OO.O._o_.()[text];
					new O_\u30000_\u3002O\u3002\u3002\u3000\u3000(oleDbConnection, o_O_o_oOoo__.OO_O0oO0.oooO_.(outerTableSetting, oleDbConnection), null).ShowDialog();
					return;
				}
				if (O_O0OO.OoO__.0oO0oo.().ContainsKey(text))
				{
					new O_\u30000_\u3002O\u3002\u3002\u3000\u3000(oleDbConnection, o_O_o_oOoo__.OO_O0oO0.oooO_.(outerTableSetting, O_O0OO.OoO__.0oO0oo.()[text].OO.OoO0.), O_O0OO.OoO__.0oO0oo.()[text]).ShowDialog();
				}
			}
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x001B2048 File Offset: 0x001B0248
		private OuterTableSetting <<EMPTY_NAME>>()
		{
			return new OuterTableSetting
			{
				SourceTable = Conversions.ToString(this.O_00__.oo.().SelectedItem),
				Filter = this.OOo.00_.().Text.Trim(),
				Top = Conversions.ToInteger(this.OOo.00_.().Value),
				Percent = this.O0OOOO.O0o0_.().Checked,
				Fields = this.o0_o_0O_0O_.o.().Text.Trim(),
				Include = this.o00OO.0_00__0.().Checked,
				Order = this.o_Oo.O0o.().Text.Trim(),
				AllFields = this.O0O0O.0_.().Checked,
				AllRows = this.OO0.oO_o.().Checked
			};
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x001B210C File Offset: 0x001B030C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OuterTableSetting outerTableSetting = this.OOo.00_.();
			if (!string.IsNullOrEmpty(outerTableSetting.SourceTable))
			{
				DataTable dataTable = new DataTable();
				HttpClient httpClient = null;
				OleDbConnection oleDbConnection = null;
				string text = this.o000O0o._O.().Text;
				string text2 = "";
				if (O_O0OO.O._o_.().ContainsKey(text))
				{
					oleDbConnection = O_O0OO.O._o_.()[text];
					text2 = o_O_o_oOoo__.OO_O0oO0.oooO_.(outerTableSetting, oleDbConnection);
					OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text2, oleDbConnection);
					try
					{
						oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
						goto IL_100;
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
						return;
					}
				}
				if (O_O0OO.OoO__.0oO0oo.().ContainsKey(text))
				{
					text2 = o_O_o_oOoo__.OO_O0oO0.oooO_.(outerTableSetting, O_O0OO.OoO__.0oO0oo.()[text].OO.OoO0.);
					dataTable = O_O0OO.OoO__.0oO0oo.()[text].O_0_O_0_o_.0.(text2, true);
					httpClient = O_O0OO.OoO__.0oO0oo.()[text].oO0_0.o.();
					httpClient.Select = text2;
					httpClient.FormData["Action"] = 1.ToString();
				}
				IL_100:
				if (dataTable.PrimaryKey.Length == 0)
				{
					MessageBox.Show("要加载的外部数据表没有设置主键，请使用添加外部查询表的命令加载！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (this.o_oOoOo_.O_o_O..RowState == DataRowState.Detached)
				{
					string text3 = this.O_00__.oo.().Text.Trim();
					text3 = text3.Replace("\"", "");
					if (text3.IndexOf('.') > 0)
					{
						text3 = text3.Substring(text3.IndexOf('.') + 1);
					}
					text3 = text3.Trim(new char[]
					{
						'['
					}).Trim(new char[]
					{
						']'
					});
					o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u = new o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(text3, "");
					o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(true);
					if (o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() != DialogResult.OK)
					{
						return;
					}
					string text4 = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.();
					string text5 = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.();
					this.o_oOoOo_.O_o_O.["Name"] = text4;
					this.o_oOoOo_.O_o_O.["DataSource"] = this.o000O0o._O.().Text;
					this.o_oOoOo_.O_o_O.["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, false, '\v', false);
					O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows.Add(this.o_oOoOo_.O_o_O.);
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
					o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, text2, text4, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, outerTableSetting.SourceTable, true, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, null, text, httpClient);
					OO_00oOO.DataTables[text4].o.0O000_.();
					OO_00oOO.DataTables[text4].Caption = text5;
					OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[text4]);
					Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(this.o_oOoOo_.O_o_O.["Name"]), true, false);
					Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
					if (Operators.CompareString(text5, "", true) > 0 || O_O0OO.O0_00o.o0__o..DevelopByCreater)
					{
						OO_00oOO.DataTables[text4].Developer = OO_00oOO.User.Name;
						OO_00oOO.DataTables[text4].OO00_o.ooOO.(false);
					}
					O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
				}
				else
				{
					string text6 = Conversions.ToString(this.o_oOoOo_.O_o_O.["Name"]);
					if (OO_00oOO.DataTables.Contains(text6))
					{
						if (!OO_00oOO.DataTables[text6].OOoo__00O_.o_O.(dataTable).o_O__.0O.)
						{
							return;
						}
						this.o_oOoOo_.O_o_O.["DataSource"] = this.o000O0o._O.().Text;
						this.o_oOoOo_.O_o_O.["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, false, '\v', false);
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
						Oo00.o00O0O_.O.(this.o_oOoOo_.O_o_O., OO_00oOO.Tables[text6]);
					}
					else
					{
						this.o_oOoOo_.O_o_O.["DataSource"] = text;
						this.o_oOoOo_.O_o_O.["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, false, '\v', false);
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
						o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, text2, text6, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, outerTableSetting.SourceTable, true, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, null, text, httpClient);
						OO_00oOO.DataTables[text6].o.0O000_.();
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[text6]);
						Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(this.o_oOoOo_.O_o_O.["Name"]), true, true);
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
						O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
					}
				}
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Rows.Find(new object[]
				{
					Conversions.ToString(this.o_oOoOo_.O_o_O.["Name"]),
					"SEQUENCE",
					ExtendTablePropertyTypeEnum.SEQUENCE
				});
				if (Operators.CompareString(this.OO._O_.().Text.Trim(), "", true) == 0)
				{
					if (dataRow != null)
					{
						dataRow["Property"] = "";
					}
				}
				else
				{
					if (dataRow == null)
					{
						dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].NewRow();
						dataRow["Table"] = Conversions.ToString(this.o_oOoOo_.O_o_O.["Name"]);
						dataRow["Name"] = "SEQUENCE";
						dataRow["Type"] = ExtendTablePropertyTypeEnum.SEQUENCE;
						O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Rows.Add(dataRow);
					}
					dataRow["Property"] = this.OO._O_.().Text.Trim();
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()], true);
				}
				OO_00oOO.DataTables[Conversions.ToString(this.o_oOoOo_.O_o_O.["Name"])].SEQUENCE = this.OO._O_.().Text.Trim();
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x001B27A0 File Offset: 0x001B09A0
		private void <<EMPTY_NAME>>(o\u3000\u3000 A_0, ValidateInputTextEventArgs A_1)
		{
			if (Operators.CompareString(A_1.Value, A_1.OriginalValue, true) != 0 && !Oo00.o.O0_O0.(A_1.Value))
			{
				A_1.Cancel = true;
			}
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x001B27CC File Offset: 0x001B09CC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.O_00__.oo.().Text, "", true) == 0)
			{
				MessageBox.Show("请先选择数据表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			O0O a_ = null;
			string text = this.o000O0o._O.().Text;
			if (O_O0OO.O._o_.().ContainsKey(text))
			{
				OleDbConnection oleDbConnection = O_O0OO.O._o_.()[text];
			}
			else if (O_O0OO.OoO__.0oO0oo.().ContainsKey(text))
			{
				a_ = O_O0OO.OoO__.0oO0oo.()[text];
			}
			O\u3000\u3000\u3002\u3000\u3002\u3002\u30020 o_u3000_u3000_u3002_u3000_u3002_u3002_u = new O\u3000\u3000\u3002\u3000\u3002\u3002\u30020(this.o_oOoOo_.O_o_O., a_, this.O_00__.oo.().Text, this.o0_o_0O_0O_.o.().Text);
			if (o_u3000_u3000_u3002_u3000_u3002_u3002_u.ShowDialog() == DialogResult.OK)
			{
				this.o0_o_0O_0O_.o.().Value = o_u3000_u3000_u3002_u3000_u3002_u3002_u.O0Oo.O.();
			}
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x001B2884 File Offset: 0x001B0A84
		public o\u3002\u30000_\u3002\u3002\u3002\u3002(DataRow A_0)
		{
			base.Load += this.o.OO0O.;
			base.FormClosed += this.O0000_O.O.;
			this.OOo.00_.();
			this.o_oOoOo_.O_o_O. = A_0;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
			{
				this.O0000_O.O.()
			});
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x001B28FC File Offset: 0x001B0AFC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0O0O.0_.().Checked)
			{
				if (Operators.CompareString(this.o0_o_0O_0O_.o.().Text, "", true) > 0)
				{
					this.o0_o_0O_0O_.o.().Value = "";
				}
				this.O0000_O.O.().Enabled = false;
			}
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x001B294B File Offset: 0x001B0B4B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o00OO.0_00__0.().Checked)
			{
				this.O0000_O.O.().Enabled = true;
			}
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x001B2966 File Offset: 0x001B0B66
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001884 RID: 6276
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001885 RID: 6277
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001886 RID: 6278
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001887 RID: 6279
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001888 RID: 6280
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001889 RID: 6281
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400188A RID: 6282
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400188B RID: 6283
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x0400188C RID: 6284
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x0400188D RID: 6285
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x0400188E RID: 6286
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400188F RID: 6287
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x04001890 RID: 6288
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001891 RID: 6289
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001892 RID: 6290
		[CompilerGenerated]
		private GroupBox <<EMPTY_NAME>>;

		// Token: 0x04001893 RID: 6291
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001894 RID: 6292
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001895 RID: 6293
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001896 RID: 6294
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001897 RID: 6295
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x04001898 RID: 6296
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001899 RID: 6297
		[CompilerGenerated]
		private Panel <<EMPTY_NAME>>;

		// Token: 0x0400189A RID: 6298
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400189B RID: 6299
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400189C RID: 6300
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400189D RID: 6301
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400189E RID: 6302
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400189F RID: 6303
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x040018A0 RID: 6304
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040018A1 RID: 6305
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040018A2 RID: 6306
		private OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x040018A3 RID: 6307
		private O0O <<EMPTY_NAME>>;

		// Token: 0x040018A4 RID: 6308
		private DataRow <<EMPTY_NAME>>;
	}
}
