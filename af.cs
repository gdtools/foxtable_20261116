using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200026C RID: 620
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	public partial class af : Form
	{
		// Token: 0x06001DB2 RID: 7602 RVA: 0x000CC110 File Offset: 0x000CA310
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o.O0_ooo0. != null)
				{
					this.o.O0_ooo0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x000CC150 File Offset: 0x000CA350
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(af));
			this.O0OOo.Oo_o.(new C1ComboBox());
			this.O0OOo.Oo_o.(new Label());
			this.Oo000.0_oO_.(new C1Button());
			this.OO___O.0O0.(new C1Button());
			this.O0OOo.Oo_o.(new C1FlexGrid());
			this.O_.0O__O.(new Label());
			this.Oo.0oo_0oO.(new C1TextBox());
			this.o_OOo0O.o.(new C1Button());
			this.O_0.OoO_.(new C1FlexGrid());
			this.O_0.OoO_.(new Label());
			this.oo0_.0oO.(new C1TextBox());
			this.O_0.OoO_.(new C1CheckBox());
			this.OO_0.OoOO00oo.(new Label());
			this.O._O__o.(new C1TextBox());
			this.O0OOo.Oo_o.(new C1CheckBox());
			this.O_.___oO_O_.(new Label());
			((ISupportInitialize)this.o_0.o.()).BeginInit();
			((ISupportInitialize)this.OO0o0OO_.o.()).BeginInit();
			base.SuspendLayout();
			this.o_O.o_0O.().DropDownStyle = DropDownStyle.DropDownList;
			this.o_O.o_0O.().Location = new Point(68, 12);
			this.o_O.o_0O.().Name = "cmbDataSource";
			this.o_O.o_0O.().Size = new Size(149, 20);
			this.o_O.o_0O.().TabIndex = 6;
			this.OOO0_.__O0_o.().AutoSize = true;
			this.OOO0_.__O0_o.().Location = new Point(15, 16);
			this.OOO0_.__O0_o.().Name = "Label2";
			this.OOO0_.__O0_o.().Size = new Size(47, 12);
			this.OOO0_.__O0_o.().TabIndex = 5;
			this.OOO0_.__O0_o.().Text = "数据源:";
			this.o_O.o_0O.().Location = new Point(621, 531);
			this.o_O.o_0O.().Name = "btnOK";
			this.o_O.o_0O.().Size = new Size(75, 23);
			this.o_O.o_0O.().TabIndex = 9;
			this.o_O.o_0O.().Text = "确定";
			this.o_O.o_0O.().UseVisualStyleBackColor = true;
			this.O.0Oo_0o_Ooo_.().Location = new Point(702, 531);
			this.O.0Oo_0o_Ooo_.().Name = "btnCancel";
			this.O.0Oo_0o_Ooo_.().Size = new Size(75, 23);
			this.O.0Oo_0o_Ooo_.().TabIndex = 10;
			this.O.0Oo_0o_Ooo_.().Text = "取消";
			this.O.0Oo_0o_Ooo_.().UseVisualStyleBackColor = true;
			this.o_0.o.().AllowDelete = true;
			this.o_0.o.().AutoClipboard = true;
			this.o_0.o.().ColumnInfo = componentResourceManager.GetString("grdColumns.ColumnInfo");
			this.o_0.o.().ExtendLastCol = true;
			this.o_0.o.().HighLight = HighLightEnum.Never;
			this.o_0.o.().Location = new Point(14, 163);
			this.o_0.o.().Name = "grdColumns";
			this.o_0.o.().Rows.Count = 1;
			this.o_0.o.().Rows.DefaultSize = 20;
			this.o_0.o.().SelectionMode = SelectionModeEnum.Row;
			this.o_0.o.().ShowThemedHeaders = ShowThemedHeadersEnum.None;
			this.o_0.o.().Size = new Size(765, 233);
			this.o_0.o.().TabIndex = 7;
			this.o.0___0O_Oo__.().AutoSize = true;
			this.o.0___0O_Oo__.().Location = new Point(12, 437);
			this.o.0___0O_Oo__.().Name = "Label1";
			this.o.0___0O_Oo__.().Size = new Size(35, 12);
			this.o.0___0O_Oo__.().TabIndex = 11;
			this.o.0___0O_Oo__.().Text = "条件:";
			this.OO0o0OO_.o.().Location = new Point(47, 433);
			this.OO0o0OO_.o.().Name = "txtFilter";
			this.OO0o0OO_.o.().Size = new Size(730, 21);
			this.OO0o0OO_.o.().TabIndex = 12;
			this.o_0.o.().Location = new Point(540, 531);
			this.o_0.o.().Name = "btnPreview";
			this.o_0.o.().Size = new Size(75, 23);
			this.o_0.o.().TabIndex = 8;
			this.o_0.o.().Text = "预览";
			this.o_0.o.().UseVisualStyleBackColor = true;
			this.OO0o0OO_.o.().AllowDelete = true;
			this.OO0o0OO_.o.().AllowDragging = AllowDraggingEnum.None;
			this.OO0o0OO_.o.().AllowSorting = AllowSortingEnum.None;
			this.OO0o0OO_.o.().AutoClipboard = true;
			this.OO0o0OO_.o.().ColumnInfo = componentResourceManager.GetString("grdTables.ColumnInfo");
			this.OO0o0OO_.o.().ExtendLastCol = true;
			this.OO0o0OO_.o.().HighLight = HighLightEnum.Never;
			this.OO0o0OO_.o.().Location = new Point(14, 40);
			this.OO0o0OO_.o.().Name = "grdTables";
			this.OO0o0OO_.o.().Rows.Count = 1;
			this.OO0o0OO_.o.().Rows.DefaultSize = 20;
			this.OO0o0OO_.o.().SelectionMode = SelectionModeEnum.Row;
			this.OO0o0OO_.o.().ShowThemedHeaders = ShowThemedHeadersEnum.None;
			this.OO0o0OO_.o.().Size = new Size(765, 106);
			this.OO0o0OO_.o.().TabIndex = 0;
			this.OoOO_o00oo.O.().AutoSize = true;
			this.OoOO_o00oo.O.().Location = new Point(12, 468);
			this.OoOO_o00oo.O.().Name = "Label3";
			this.OoOO_o00oo.O.().Size = new Size(35, 12);
			this.OoOO_o00oo.O.().TabIndex = 13;
			this.OoOO_o00oo.O.().Text = "排序:";
			this.oooO00O.0_.().Location = new Point(47, 464);
			this.oooO00O.0_.().Name = "txtOrder";
			this.oooO00O.0_.().Size = new Size(247, 21);
			this.oooO00O.0_.().TabIndex = 14;
			this.o_0.o.().AutoSize = true;
			this.o_0.o.().Location = new Point(693, 479);
			this.o_0.o.().Name = "chkDistinct";
			this.o_0.o.().Size = new Size(84, 16);
			this.o_0.o.().TabIndex = 15;
			this.o_0.o.().Text = "排除重复值";
			this.o_0.o.().UseVisualStyleBackColor = true;
			this.OO0o0OO_.o.().AutoSize = true;
			this.OO0o0OO_.o.().Location = new Point(12, 499);
			this.OO0o0OO_.o.().Name = "Label4";
			this.OO0o0OO_.o.().Size = new Size(35, 12);
			this.OO0o0OO_.o.().TabIndex = 17;
			this.OO0o0OO_.o.().Text = "行数:";
			this.o.0___0O_Oo__.().Location = new Point(47, 495);
			this.o.0___0O_Oo__.().Name = "txtTop";
			this.o.0___0O_Oo__.().Size = new Size(247, 21);
			this.o.0___0O_Oo__.().TabIndex = 18;
			this.o_O.o_0O.().AutoSize = true;
			this.o_O.o_0O.().Checked = true;
			this.o_O.o_0O.().CheckState = CheckState.Checked;
			this.o_O.o_0O.().Location = new Point(693, 12);
			this.o_O.o_0O.().Name = "chkSysColumns";
			this.o_O.o_0O.().Size = new Size(84, 16);
			this.o_O.o_0O.().TabIndex = 19;
			this.o_O.o_0O.().Text = "列出系统列";
			this.o_O.o_0O.().UseVisualStyleBackColor = true;
			this.oooO00O.0_.().AutoSize = true;
			this.oooO00O.0_.().Location = new Point(12, 408);
			this.oooO00O.0_.().Name = "Label5";
			this.oooO00O.0_.().Size = new Size(329, 12);
			this.oooO00O.0_.().TabIndex = 20;
			this.oooO00O.0_.().Text = "提示: 按Delete删除行，按Ctrl+D下移行，按Ctrl+U上移行。";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(789, 565);
			base.Controls.Add(this.oooO00O.0_.());
			base.Controls.Add(this.o_O.o_0O.());
			base.Controls.Add(this.o.0___0O_Oo__.());
			base.Controls.Add(this.OO0o0OO_.o.());
			base.Controls.Add(this.o_0.o.());
			base.Controls.Add(this.oooO00O.0_.());
			base.Controls.Add(this.OoOO_o00oo.O.());
			base.Controls.Add(this.OO0o0OO_.o.());
			base.Controls.Add(this.o.0___0O_Oo__.());
			base.Controls.Add(this.O.0Oo_0o_Ooo_.());
			base.Controls.Add(this.o_O.o_0O.());
			base.Controls.Add(this.o_0.o.());
			base.Controls.Add(this.o_0.o.());
			base.Controls.Add(this.o_O.o_0O.());
			base.Controls.Add(this.OOO0_.__O0_o.());
			base.Controls.Add(this.OO0o0OO_.o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O0..o0O.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "查询表生成器";
			((ISupportInitialize)this.o_0.o.()).EndInit();
			((ISupportInitialize)this.OO0o0OO_.o.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x000CCADA File Offset: 0x000CACDA
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.Oo.0oo_0oO.;
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x000CCAE4 File Offset: 0x000CACE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.Oo_o00__._.);
			C1ComboBox oo.0oo_0oO. = this.Oo.0oo_0oO.;
			if (oo.0oo_0oO. != null)
			{
				oo.0oo_0oO..SelectedIndexChanged -= value;
			}
			this.Oo.0oo_0oO. = A_0;
			oo.0oo_0oO. = this.Oo.0oo_0oO.;
			if (oo.0oo_0oO. != null)
			{
				oo.0oo_0oO..SelectedIndexChanged += value;
			}
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x000CCB27 File Offset: 0x000CAD27
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_O_.oo.;
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x000CCB2F File Offset: 0x000CAD2F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_O_.oo. = A_0;
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x000CCB38 File Offset: 0x000CAD38
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.Oo.0oo_0oO.;
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x000CCB40 File Offset: 0x000CAD40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			EventHandler value = new EventHandler(this.oo.O_Oo.);
			RowColEventHandler value2 = new RowColEventHandler(this.Oo000.0_oO_.);
			KeyEventHandler value3 = new KeyEventHandler(this.Oo000.0_oO_.);
			C1FlexGrid oo.0oo_0oO. = this.Oo.0oo_0oO.;
			if (oo.0oo_0oO. != null)
			{
				oo.0oo_0oO..Enter -= value;
				oo.0oo_0oO..StartEdit -= value2;
				oo.0oo_0oO..KeyDown -= value3;
			}
			this.Oo.0oo_0oO. = A_0;
			oo.0oo_0oO. = this.Oo.0oo_0oO.;
			if (oo.0oo_0oO. != null)
			{
				oo.0oo_0oO..Enter += value;
				oo.0oo_0oO..StartEdit += value2;
				oo.0oo_0oO..KeyDown += value3;
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x000CCBB9 File Offset: 0x000CADB9
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo.0oo_0oO.;
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x000CCBC4 File Offset: 0x000CADC4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.0__Oo_.);
			C1Button oo.0oo_0oO. = this.Oo.0oo_0oO.;
			if (oo.0oo_0oO. != null)
			{
				oo.0oo_0oO..Click -= value;
			}
			this.Oo.0oo_0oO. = A_0;
			oo.0oo_0oO. = this.Oo.0oo_0oO.;
			if (oo.0oo_0oO. != null)
			{
				oo.0oo_0oO..Click += value;
			}
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x000CCC07 File Offset: 0x000CAE07
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O._O__o.;
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x000CCC10 File Offset: 0x000CAE10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo_.000o.);
			C1Button o._O__o. = this.O._O__o.;
			if (o._O__o. != null)
			{
				o._O__o..Click -= value;
			}
			this.O._O__o. = A_0;
			o._O__o. = this.O._O__o.;
			if (o._O__o. != null)
			{
				o._O__o..Click += value;
			}
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x000CCC53 File Offset: 0x000CAE53
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_0O00._ooO0.;
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x000CCC5B File Offset: 0x000CAE5B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_0O00._ooO0. = A_0;
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x000CCC64 File Offset: 0x000CAE64
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_O_.oo.;
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x000CCC6C File Offset: 0x000CAE6C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O_O_.oo. = A_0;
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x000CCC75 File Offset: 0x000CAE75
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo0_.0oO.;
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x000CCC80 File Offset: 0x000CAE80
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO.OoOOo__.);
			C1Button c1Button = this.oo0_.0oO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo0_.0oO. = A_0;
			c1Button = this.oo0_.0oO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x000CCCC3 File Offset: 0x000CAEC3
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.o_0O00._ooO0.;
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x000CCCCC File Offset: 0x000CAECC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.oo.O_Oo.);
			RowColEventHandler value2 = new RowColEventHandler(this.OO___O.0O0.);
			RowColEventHandler value3 = new RowColEventHandler(this.o_OOo0O.o.);
			KeyEventHandler value4 = new KeyEventHandler(this.Oo000.0_oO_.);
			C1FlexGrid c1FlexGrid = this.o_0O00._ooO0.;
			if (c1FlexGrid != null)
			{
				c1FlexGrid.AfterEdit -= value;
				c1FlexGrid.BeforeEdit -= value2;
				c1FlexGrid.StartEdit -= value3;
				c1FlexGrid.KeyDown -= value4;
			}
			this.o_0O00._ooO0. = A_0;
			c1FlexGrid = this.o_0O00._ooO0.;
			if (c1FlexGrid != null)
			{
				c1FlexGrid.AfterEdit += value;
				c1FlexGrid.BeforeEdit += value2;
				c1FlexGrid.StartEdit += value3;
				c1FlexGrid.KeyDown += value4;
			}
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x000CCD6C File Offset: 0x000CAF6C
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOo0_._o_o00.;
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x000CCD74 File Offset: 0x000CAF74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOo0_._o_o00. = A_0;
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x000CCD7D File Offset: 0x000CAF7D
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o_0O00._ooO0.;
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x000CCD85 File Offset: 0x000CAF85
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o_0O00._ooO0. = A_0;
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x000CCD8E File Offset: 0x000CAF8E
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.Oo.0oo_0oO.;
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x000CCD96 File Offset: 0x000CAF96
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.Oo.0oo_0oO. = A_0;
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x000CCD9F File Offset: 0x000CAF9F
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.0__0oo.;
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x000CCDA7 File Offset: 0x000CAFA7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.0__0oo. = A_0;
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x000CCDB0 File Offset: 0x000CAFB0
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oOo0_._o_o00.;
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x000CCDB8 File Offset: 0x000CAFB8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.oOo0_._o_o00. = A_0;
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x000CCDC1 File Offset: 0x000CAFC1
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O._O__o.;
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x000CCDC9 File Offset: 0x000CAFC9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O._O__o. = A_0;
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x000CCDD2 File Offset: 0x000CAFD2
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oO.OOO_00oo0O.;
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x000CCDDA File Offset: 0x000CAFDA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oO.OOO_00oo0O. = A_0;
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x000CCDE4 File Offset: 0x000CAFE4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num5;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.o_O.o_0O.().Items.Add("内部数据源");
				IL_1F:
				num2 = 3;
				IEnumerator enumerator = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()].Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_51:
					num2 = 4;
					this.o_O.o_0O.().Items.Add(Conversions.ToString(dataRow["Name"]));
					IL_75:
					num2 = 5;
				}
				IL_80:
				num2 = 6;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_97:
				num2 = 7;
				this.o_O.o_0O.().SelectedIndex = 0;
				IL_A5:
				num2 = 8;
				if (this.o.O0_ooo0..RowState == DataRowState.Detached)
				{
					goto IL_4C1;
				}
				IL_B8:
				num2 = 9;
				if (this.o.O0_ooo0..IsNull("DataSource") || Operators.CompareString(Conversions.ToString(this.o.O0_ooo0.["DataSource"]), "", true) <= 0)
				{
					goto IL_165;
				}
				IL_F3:
				num2 = 10;
				int num3 = this.o_O.o_0O.().Items.Count - 1;
				for (int i = 1; i <= num3; i++)
				{
					IL_10F:
					num2 = 11;
					if (Operators.CompareString(Conversions.ToString(this.o_O.o_0O.().Items[i]), Conversions.ToString(this.o.O0_ooo0.["DataSource"]), true) == 0)
					{
						IL_146:
						num2 = 12;
						this.o_O.o_0O.().SelectedIndex = i;
					}
					IL_156:
					num2 = 13;
				}
				IL_165:
				num2 = 14;
				if (this.o.O0_ooo0..IsNull("Property") || Operators.CompareString(Conversions.ToString(this.o.O0_ooo0.["Property"]), "", true) <= 0)
				{
					goto IL_491;
				}
				IL_1A3:
				num2 = 15;
				string text = Conversions.ToString(this.o.O0_ooo0.["Property"]);
				IL_1BD:
				num2 = 16;
				text = text.Trim(new char[]
				{
					'{',
					'}'
				});
				IL_1D9:
				num2 = 17;
				JoinTableProperty joinTableProperty = new JoinTableProperty();
				IL_1E3:
				num2 = 18;
				o_O_o_oOoo__.OOOO_OO._oo.(joinTableProperty, text, '\v');
				IL_1F1:
				num2 = 19;
				this.OO0o0OO_.o.().Value = joinTableProperty.Filter;
				IL_206:
				num2 = 20;
				this.oooO00O.0_.().Value = joinTableProperty.Order;
				IL_21B:
				num2 = 21;
				this.o.0___0O_Oo__.().Value = joinTableProperty.Top;
				IL_230:
				num2 = 22;
				this.o_0.o.().Checked = joinTableProperty.Distinct;
				IL_245:
				num2 = 23;
				if (Operators.CompareString(joinTableProperty.LinkTables, "", true) <= 0)
				{
					goto IL_3AA;
				}
				IL_260:
				num2 = 24;
				string[] array = joinTableProperty.LinkTables.Split(new char[]
				{
					'\n'
				});
				IL_27C:
				num2 = 25;
				foreach (string text2 in array)
				{
					IL_292:
					num2 = 26;
					string[] array3 = text2.Split(new char[]
					{
						'\t'
					});
					IL_2A9:
					num2 = 27;
					C1FlexGrid c1FlexGrid = this.OO0o0OO_.o.();
					IL_2B4:
					num2 = 28;
					c1FlexGrid.AddItem(string.Concat(new string[]
					{
						array3[0],
						"\t",
						array3[1],
						"\t",
						array3[2],
						"\t",
						array3[3]
					}));
					IL_2FE:
					num2 = 29;
					switch (Conversions.ToInteger(Enum.Parse(typeof(JoinModeEnum), array3[4])))
					{
					case 0:
						IL_330:
						num2 = 31;
						c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 4, "内连接");
						break;
					case 1:
						IL_351:
						num2 = 33;
						c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 4, "左连接");
						break;
					case 2:
						IL_372:
						num2 = 35;
						c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 4, "右连接");
						break;
					}
					IL_391:
					c1FlexGrid = null;
					IL_394:
					num2 = 38;
				}
				goto IL_3C0;
				IL_3AA:
				num2 = 40;
				this.OO0o0OO_.o.().AddItem(joinTableProperty.BaseTable);
				IL_3C0:
				num2 = 41;
				if (Operators.CompareString(joinTableProperty.Columns, "", true) <= 0)
				{
					goto IL_491;
				}
				IL_3DB:
				num2 = 42;
				string[] array4 = joinTableProperty.Columns.Split(new char[]
				{
					'\n'
				});
				IL_3F7:
				num2 = 43;
				foreach (string text3 in array4)
				{
					IL_40D:
					num2 = 44;
					string[] array6 = text3.Split(new char[]
					{
						'\t'
					});
					IL_424:
					num2 = 45;
					C1FlexGrid c1FlexGrid2 = this.o_0.o.();
					IL_42F:
					num2 = 46;
					c1FlexGrid2.AddItem(array6[0] + "\t" + array6[1]);
					IL_44C:
					num2 = 47;
					if (Operators.CompareString(array6[2], "1", true) == 0)
					{
						IL_460:
						num2 = 48;
						c1FlexGrid2.SetCellCheck(c1FlexGrid2.Rows.Count - 1, 2, CheckEnum.Checked);
					}
					IL_47A:
					c1FlexGrid2 = null;
					IL_47D:
					num2 = 50;
				}
				IL_491:
				num2 = 51;
				this.Text = this.Text + " - " + Conversions.ToString(this.o.O0_ooo0.["Name"]);
				goto IL_4DA;
				IL_4C1:
				num2 = 53;
				this.Text += " - 新建";
				IL_4DA:
				num2 = 54;
				this.OO0o0OO_.o.().Cols[1].Editor = new o0_o_o_0();
				IL_4F8:
				num2 = 55;
				this.OO0o0OO_.o.().Cols[3].Editor = new o0_o_o_0();
				IL_516:
				num2 = 56;
				C1DropDownControl c1DropDownControl = new C1DropDownControl();
				IL_51F:
				num2 = 57;
				c1DropDownControl.ShowUpDownButtons = false;
				IL_529:
				num2 = 58;
				c1DropDownControl.DropDownForm = this.o.O0_ooo0.;
				IL_538:
				num2 = 59;
				this.o_0.o.().Cols[0].Editor = c1DropDownControl;
				IL_552:
				num2 = 60;
				this.OO0o0OO_.o.().AllowAddNew = true;
				IL_561:
				num2 = 61;
				this.o_0.o.().AllowAddNew = true;
				IL_570:
				num2 = 62;
				this.o_0.o.().Rows.DefaultSize = 22;
				IL_585:
				num2 = 63;
				this.OO0o0OO_.o.().Rows.DefaultSize = 22;
				IL_59A:
				num2 = 64;
				this.o_0.o.().Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
				IL_5B3:
				num2 = 65;
				this.OO0o0OO_.o.().Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
				IL_5CC:
				goto IL_726;
				IL_5D1:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_6E7:
				goto IL_71B;
				IL_6E9:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_6F9:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_6E9;
			}
			IL_71B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_726:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x000CD53C File Offset: 0x000CB73C
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
				this.O_O_.oo. = null;
				IL_10:
				num2 = 3;
				this.o.O0_ooo0. = null;
				IL_19:
				num2 = 4;
				if (this.o_O.o_0O.().SelectedIndex != 0)
				{
					goto IL_37;
				}
				IL_28:
				num2 = 5;
				this.O_O_.oo. = O_O0OO.OoO.0OO__0ooo.();
				goto IL_8D;
				IL_37:
				num2 = 7;
				if (!O_O0OO.OoO__.0oO0oo.().ContainsKey(this.o_O.o_0O.().Text))
				{
					goto IL_6F;
				}
				IL_50:
				num2 = 8;
				this.o.O0_ooo0. = O_O0OO.OoO__.0oO0oo.()[this.o_O.o_0O.().Text];
				goto IL_8D;
				IL_6F:
				num2 = 10;
				this.O_O_.oo. = O_O0OO.O._o_.()[this.o_O.o_0O.().Text];
				IL_8D:
				num2 = 11;
				string text = "";
				IL_96:
				num2 = 12;
				if (this.O_O_.oo. == null)
				{
					goto IL_2C8;
				}
				IL_A4:
				num2 = 13;
				this.O_O_.oo..Open();
				IL_B2:
				num2 = 14;
				if (!o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.O_O_.oo.))
				{
					goto IL_191;
				}
				IL_C5:
				num2 = 15;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select owner,table_name from all_tables where owner not LIKE '%SYS%'", this.O_O_.oo.);
				IL_DA:
				num2 = 16;
				DataTable dataTable = new DataTable();
				IL_E4:
				num2 = 17;
				oleDbDataAdapter.Fill(dataTable);
				IL_F1:
				num2 = 18;
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_112:
					num2 = 19;
					text = string.Concat(new string[]
					{
						text,
						"|\"",
						dataRow["OWNER"].ToString(),
						"\".\"",
						dataRow["TABLE_NAME"].ToString(),
						"\""
					});
					IL_165:
					num2 = 20;
				}
				IL_171:
				num2 = 21;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
					goto IL_2B8;
				}
				goto IL_2B8;
				IL_191:
				num2 = 23;
				dataTable = this.O_O_.oo..GetSchema("Tables");
				IL_1A6:
				num2 = 24;
				string filterExpression = "[TABLE_TYPE]='TABLE'";
				IL_1B0:
				num2 = 25;
				foreach (DataRow dataRow2 in dataTable.Select(filterExpression))
				{
					IL_1CD:
					num2 = 26;
					string text2 = Conversions.ToString(dataRow2["TABLE_NAME"]);
					IL_1E3:
					num2 = 27;
					if (!dataRow2.IsNull("TABLE_SCHEMA") && Operators.CompareString(dataRow2["TABLE_SCHEMA"].ToString(), "dbo", true) != 0)
					{
						IL_212:
						num2 = 29;
						text2 = string.Concat(new string[]
						{
							"[",
							dataRow2["TABLE_SCHEMA"].ToString(),
							"].[",
							text2,
							"]"
						});
					}
					IL_253:
					num2 = 30;
					if (!o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text2))
					{
						IL_264:
						num2 = 32;
						if (this.O_O_.oo. == O_O0OO.OoO.0OO__0ooo.())
						{
							IL_274:
							num2 = 33;
							if (text2.StartsWith("~TMPCLP", StringComparison.CurrentCultureIgnoreCase))
							{
								IL_286:
								num2 = 34;
								text2 = text2.Substring(7);
							}
						}
						IL_293:
						num2 = 35;
						text = text + "|" + text2;
					}
					IL_2A4:
					num2 = 36;
				}
				IL_2B8:
				num2 = 37;
				this.O_O_.oo..Close();
				goto IL_2ED;
				IL_2C8:
				num2 = 39;
				List<string> list = this.o.O0_ooo0..OO._o_OO.();
				IL_2D8:
				num2 = 40;
				text = string.Join("|", list.ToArray());
				IL_2ED:
				num2 = 41;
				text = text.Trim(new char[]
				{
					'|'
				});
				IL_302:
				num2 = 42;
				this.OO0o0OO_.o.().Cols[0].ComboList = text;
				IL_31C:
				num2 = 43;
				this.OO0o0OO_.o.().Cols[2].ComboList = text;
				IL_336:
				goto IL_438;
				IL_33B:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_3F9:
				goto IL_42D;
				IL_3FB:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_40B:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_3FB;
			}
			IL_42D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_438:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x000CD9A8 File Offset: 0x000CBBA8
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.OO0o0OO_.o.();
			if (c1FlexGrid.Col == 2 && Operators.CompareString(c1FlexGrid.GetDataDisplay(A_1.Row, 4), "", true) == 0)
			{
				c1FlexGrid.SetData(c1FlexGrid.Row, 4, "内连接");
			}
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x000CD9F4 File Offset: 0x000CBBF4
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			string dataDisplay;
			if (A_1.Col == 1)
			{
				dataDisplay = this.OO0o0OO_.o.().GetDataDisplay(A_1.Row, 0);
			}
			else
			{
				if (A_1.Col != 3)
				{
					return;
				}
				dataDisplay = this.OO0o0OO_.o.().GetDataDisplay(A_1.Row, 2);
			}
			if (Operators.CompareString(dataDisplay, "", true) != 0)
			{
				List<string> list = this.OO0o0OO_.o.(dataDisplay);
				o0_o_o_0 o0_o_o_ = (o0_o_o_0)this.OO0o0OO_.o.().Cols[A_1.Col].Editor;
				o0_o_o_.o.O0.().Clear();
				o0_o_o_.o.O0.().AddRange(list.ToArray());
				o0_o_o_.O.0o0O.(false);
			}
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x000CDA94 File Offset: 0x000CBC94
		private List<string> <<EMPTY_NAME>>(string A_0)
		{
			int num;
			List<string> result;
			int num4;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!this.o.O0_ooo0..ContainsKey(this.o_O.o_0O.().Text + "," + A_0))
				{
					goto IL_55;
				}
				IL_2C:
				num2 = 3;
				result = this.o.O0_ooo0.[this.o_O.o_0O.().Text + "," + A_0];
				goto IL_28D;
				IL_55:
				num2 = 4;
				if ((this.O_O_.oo. == null || !o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.O_O_.oo.)) && (this.o.O0_ooo0. == null || this.o.O0_ooo0..OO.OoO0. != DataServerTypeEnum.Oracle))
				{
					goto IL_D4;
				}
				IL_82:
				num2 = 5;
				string[] array = A_0.Split(new char[]
				{
					'"',
					'.'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_9D:
				num2 = 6;
				string text = string.Concat(new string[]
				{
					"select column_name from all_tab_columns Where table_name = '",
					array[1],
					"' And owner = '",
					array[0],
					"'"
				});
				goto IL_120;
				IL_D4:
				num2 = 8;
				text = "Select * from " + Oo00.o.oo_0.(A_0);
				IL_E8:
				num2 = 9;
				if (this.O_O_.oo. == null)
				{
					goto IL_108;
				}
				IL_F3:
				num2 = 10;
				text = Oo00.o0_o._O_.(this.O_O_.oo., text, false);
				goto IL_120;
				IL_108:
				num2 = 12;
				text = Oo00.o0_o._O_.(this.o.O0_ooo0..OO.OoO0., text, false);
				IL_120:
				num2 = 13;
				DataTable dataTable = new DataTable();
				IL_12A:
				num2 = 14;
				List<string> list = new List<string>();
				IL_134:
				num2 = 15;
				if (this.O_O_.oo. == null)
				{
					goto IL_17E;
				}
				IL_13F:
				num2 = 16;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text, this.O_O_.oo.);
				IL_151:
				num2 = 17;
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				IL_15F:
				num2 = 18;
				if (!o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.O_O_.oo.))
				{
					goto IL_191;
				}
				IL_16F:
				num2 = 19;
				oleDbDataAdapter.Fill(dataTable);
				goto IL_191;
				IL_17E:
				num2 = 21;
				dataTable = this.o.O0_ooo0..O_0_O_0_o_.0.(text, true);
				IL_191:
				num2 = 22;
				if (this.O_O_.oo. == null || !o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.O_O_.oo.))
				{
					goto IL_20B;
				}
				IL_1A9:
				num2 = 23;
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_1CA:
					num2 = 24;
					list.Add(dataRow["COLUMN_NAME"].ToString());
					IL_1E5:
					num2 = 25;
				}
				IL_1F1:
				num2 = 26;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
					goto IL_261;
				}
				goto IL_261;
				IL_20B:
				num2 = 28;
				IEnumerator enumerator2 = dataTable.Columns.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					DataColumn dataColumn = (DataColumn)obj2;
					IL_22C:
					num2 = 29;
					list.Add(dataColumn.ColumnName);
					IL_23D:
					num2 = 30;
				}
				IL_249:
				num2 = 31;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_261:
				num2 = 32;
				this.o.O0_ooo0.[this.o_O.o_0O.().Text + "," + A_0] = list;
				IL_287:
				num2 = 33;
				result = list;
				IL_28D:
				goto IL_367;
				IL_292:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_328:
				goto IL_35C;
				IL_32A:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_33A:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_32A;
			}
			IL_35C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_367:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x000CDE30 File Offset: 0x000CC030
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (this.OO0o0OO_.o.().Editor is o0_o_o_0)
			{
				o0_o_o_0 o0_o_o_ = (o0_o_o_0)this.OO0o0OO_.o.().Editor;
				if (o0_o_o_.oOo_o_o000.o.() == 0)
				{
					o0_o_o_.o_.O_.(15);
				}
				o0_o_o_.Value = RuntimeHelpers.GetObjectValue(this.OO0o0OO_.o.().GetData(A_1.Row, A_1.Col));
			}
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x000CDE94 File Offset: 0x000CC094
		public af(DataRow A_0)
		{
			base.Load += this.o__o.oO.;
			base.FormClosed += this.o_O.o_0O.;
			this.O_O_.oo. = null;
			this.o.O0_ooo0. = null;
			this.o.O0_ooo0. = new O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000();
			this.o.O0_ooo0. = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
			this.Oo000.0_oO_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			foreach (C1FlexGrid c1FlexGrid in new C1FlexGrid[]
			{
				this.OO0o0OO_.o.(),
				this.o_0.o.()
			})
			{
				c1FlexGrid.Styles.SelectedColumnHeader.Clear();
				c1FlexGrid.Styles.Alternate.Clear();
				c1FlexGrid.Styles.Focus.Clear();
				c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal);
				c1FlexGrid.FocusRect = FocusRectEnum.Solid;
				c1FlexGrid.AllowSorting = AllowSortingEnum.None;
			}
			this.o.O0_ooo0. = A_0;
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x000CDF9C File Offset: 0x000CC19C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.o.O0_ooo0..o_O0_O.O_OOO.().Nodes.Clear();
				IL_1E:
				num2 = 3;
				List<string> list = new List<string>();
				IL_26:
				num2 = 4;
				int num3 = this.OO0o0OO_.o.().Rows.Count - 1;
				for (int i = 1; i <= num3; i++)
				{
					IL_44:
					num2 = 5;
					string dataDisplay = this.OO0o0OO_.o.().GetDataDisplay(i, 0);
					IL_56:
					num2 = 6;
					if (Operators.CompareString(dataDisplay, "", true) > 0 && !list.Contains(dataDisplay))
					{
						IL_72:
						num2 = 7;
						list.Add(dataDisplay);
					}
					IL_7C:
					num2 = 8;
					dataDisplay = this.OO0o0OO_.o.().GetDataDisplay(i, 2);
					IL_8E:
					num2 = 9;
					if (Operators.CompareString(dataDisplay, "", true) > 0 && !list.Contains(dataDisplay))
					{
						IL_AB:
						num2 = 10;
						list.Add(dataDisplay);
					}
					IL_B6:
					num2 = 11;
					this.o_0.o.().Cols[0].ComboList = string.Join("|", list.ToArray());
					IL_DF:
					num2 = 12;
				}
				IL_F1:
				num2 = 13;
				List<string>.Enumerator enumerator = list.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					IL_107:
					num2 = 14;
					TreeNode treeNode = this.o.O0_ooo0..o_O0_O.O_OOO.().Nodes.Add(text, text);
					IL_125:
					num2 = 15;
					List<string> list2 = this.OO0o0OO_.o.(text);
					IL_132:
					num2 = 16;
					List<string>.Enumerator enumerator2 = list2.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string text2 = enumerator2.Current;
						IL_149:
						num2 = 17;
						treeNode.Nodes.Add(text2, text2);
						IL_15D:
						num2 = 18;
					}
					IL_169:
					num2 = 19;
					((IDisposable)enumerator2).Dispose();
					IL_179:
					num2 = 20;
				}
				IL_188:
				num2 = 21;
				((IDisposable)enumerator).Dispose();
				IL_198:
				goto IL_242;
				IL_19D:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_203:
				goto IL_237;
				IL_205:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_215:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_205;
			}
			IL_237:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_242:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x000CE210 File Offset: 0x000CC410
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			int num;
			int num5;
			object obj8;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (A_1.Col != 0)
				{
					goto IL_43D;
				}
				IL_14:
				num2 = 3;
				string dataDisplay = this.o_0.o.().GetDataDisplay(A_1.Row, A_1.Col);
				IL_2E:
				num2 = 4;
				string[] array = dataDisplay.Split(new char[]
				{
					','
				});
				IL_43:
				num2 = 5;
				TreeView treeView = this.o.O0_ooo0..o_O0_O.O_OOO.();
				IL_52:
				num2 = 6;
				this.o.O0_ooo0..oo_.000o. = false;
				IL_60:
				num2 = 7;
				IEnumerator enumerator = treeView.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					TreeNode treeNode = (TreeNode)obj;
					IL_80:
					num2 = 8;
					treeNode.Checked = false;
					IL_8A:
					num2 = 9;
					IEnumerator enumerator2 = treeNode.Nodes.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						object obj2 = enumerator2.Current;
						TreeNode treeNode2 = (TreeNode)obj2;
						IL_AB:
						num2 = 10;
						treeNode2.Checked = false;
						IL_B6:
						num2 = 11;
					}
					IL_C2:
					num2 = 12;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
					IL_DA:
					num2 = 13;
				}
				IL_E6:
				num2 = 14;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
				IL_FE:
				num2 = 15;
				foreach (string text in array)
				{
					IL_114:
					num2 = 16;
					if (text.IndexOf("].[") < 0)
					{
						IL_126:
						num2 = 17;
						text = text.Trim(new char[]
						{
							'[',
							']',
							' '
						});
					}
					IL_143:
					num2 = 18;
					if (text.EndsWith(".*"))
					{
						IL_157:
						num2 = 19;
						text = text.Substring(0, text.Length - 2).Trim(new char[]
						{
							'{',
							'}'
						}).Trim();
						IL_187:
						num2 = 20;
						IEnumerator enumerator3 = treeView.Nodes.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							object obj3 = enumerator3.Current;
							TreeNode treeNode3 = (TreeNode)obj3;
							IL_1A8:
							num2 = 21;
							if (Operators.CompareString(treeNode3.Name, text, true) == 0)
							{
								IL_1BC:
								num2 = 22;
								treeNode3.Checked = true;
								break;
							}
							IL_1C9:
							num2 = 24;
						}
						IL_1D5:
						num2 = 25;
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
					else
					{
						IL_1F5:
						num2 = 27;
						if (text.IndexOf('.') > 0)
						{
							IL_207:
							num2 = 28;
							int num3 = text.LastIndexOf(".");
							IL_218:
							num2 = 29;
							string[] array3 = new string[2];
							IL_223:
							num2 = 30;
							array3[0] = text.Substring(0, num3).Trim(new char[]
							{
								'{',
								'}'
							});
							IL_249:
							num2 = 31;
							array3[1] = text.Substring(num3 + 1).Trim(new char[]
							{
								'[',
								']'
							});
							IL_270:
							num2 = 32;
							TreeNode treeNode4 = null;
							IL_276:
							num2 = 33;
							IEnumerator enumerator4 = treeView.Nodes.GetEnumerator();
							while (enumerator4.MoveNext())
							{
								object obj4 = enumerator4.Current;
								TreeNode treeNode5 = (TreeNode)obj4;
								IL_29A:
								num2 = 34;
								if (Operators.CompareString(treeNode5.Name, array3[0], true) == 0)
								{
									IL_2B0:
									num2 = 35;
									IEnumerator enumerator5 = treeNode5.Nodes.GetEnumerator();
									while (enumerator5.MoveNext())
									{
										object obj5 = enumerator5.Current;
										TreeNode treeNode6 = (TreeNode)obj5;
										IL_2D1:
										num2 = 36;
										if (Operators.CompareString(treeNode6.Name, array3[1], true) == 0)
										{
											IL_2E7:
											num2 = 37;
											treeNode4 = treeNode6;
											IL_2EE:
											num2 = 38;
											treeNode6.Checked = true;
											break;
										}
										IL_2FB:
										num2 = 40;
									}
									IL_307:
									num2 = 41;
									if (enumerator5 is IDisposable)
									{
										(enumerator5 as IDisposable).Dispose();
									}
								}
								IL_31F:
								num2 = 42;
								if (treeNode4 != null)
								{
									break;
								}
								IL_326:
								num2 = 44;
							}
							IL_335:
							num2 = 45;
							if (enumerator4 is IDisposable)
							{
								(enumerator4 as IDisposable).Dispose();
							}
						}
						else
						{
							IL_355:
							num2 = 47;
							TreeNode treeNode7 = null;
							IL_35B:
							num2 = 48;
							IEnumerator enumerator6 = treeView.Nodes.GetEnumerator();
							while (enumerator6.MoveNext())
							{
								object obj6 = enumerator6.Current;
								TreeNode treeNode8 = (TreeNode)obj6;
								IL_37F:
								num2 = 49;
								IEnumerator enumerator7 = treeNode8.Nodes.GetEnumerator();
								while (enumerator7.MoveNext())
								{
									object obj7 = enumerator7.Current;
									TreeNode treeNode9 = (TreeNode)obj7;
									IL_3A0:
									num2 = 50;
									if (Operators.CompareString(treeNode9.Name, text, true) == 0)
									{
										IL_3B4:
										num2 = 51;
										treeNode7 = treeNode9;
										IL_3BB:
										num2 = 52;
										treeNode9.Checked = true;
										break;
									}
									IL_3C8:
									num2 = 54;
								}
								IL_3D4:
								num2 = 55;
								if (enumerator7 is IDisposable)
								{
									(enumerator7 as IDisposable).Dispose();
								}
								IL_3EC:
								num2 = 56;
								if (treeNode7 != null)
								{
									break;
								}
								IL_3F3:
								num2 = 58;
							}
							IL_402:
							num2 = 59;
							if (enumerator6 is IDisposable)
							{
								(enumerator6 as IDisposable).Dispose();
							}
						}
					}
					IL_41A:
					num2 = 60;
				}
				IL_42E:
				num2 = 61;
				this.o.O0_ooo0..oo_.000o. = true;
				IL_43D:
				goto IL_587;
				IL_442:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_548:
				goto IL_57C;
				IL_54A:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_55A:;
			}
			catch when (endfilter(obj8 is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj9;
				goto IL_54A;
			}
			IL_57C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_587:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x000CE7C8 File Offset: 0x000CC9C8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			JoinTableProperty a_ = new JoinTableProperty();
			if (this.oo_.000o.(a_))
			{
				string value = "{" + o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\v', false) + "}";
				DataTable dataTable = new DataTable();
				string text = Oo00.OO.0O0o.(a_);
				HttpClient httpClient = null;
				if (this.O_O_.oo. != null)
				{
					text = Oo00.o0_o._O_.(this.O_O_.oo., text, false);
					OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text, this.O_O_.oo.);
					try
					{
						oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
						if (dataTable.Columns.Count == 0)
						{
							MessageBox.Show("语句执行后没有返回数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return;
						}
						goto IL_100;
					}
					catch (Exception a_2)
					{
						ooO.oOo0Oo.o.(a_2, "");
						return;
					}
				}
				text = Oo00.o0_o._O_.(this.o.O0_ooo0..OO.OoO0., text, false);
				dataTable = this.o.O0_ooo0..O_0_O_0_o_.0.(text, true);
				httpClient = this.o.O0_ooo0..oO0_0.o.();
				httpClient.Select = text;
				httpClient.FormData["Action"] = 2.ToString();
				IL_100:
				if (this.o.O0_ooo0..RowState == DataRowState.Detached)
				{
					o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u = new o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000("", "");
					o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(true);
					if (o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() == DialogResult.OK)
					{
						string text2 = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.();
						string text3 = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.();
						this.o.O0_ooo0.["Name"] = text2;
						if (this.o_O.o_0O.().SelectedIndex > 0)
						{
							this.o.O0_ooo0.["DataSource"] = this.o_O.o_0O.().Text;
						}
						this.o.O0_ooo0.["Property"] = value;
						O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows.Add(this.o.O0_ooo0.);
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
						o0OoOOoOOo0.OOOOO.o000.(this.O_O_.oo., text, text2, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, "", true, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, null, this.o_O.o_0O.().Text, httpClient);
						OO_00oOO.DataTables[text2].o.0O000_.();
						OO_00oOO.DataTables[text2].Caption = text3;
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[text2]);
						Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(this.o.O0_ooo0.["Name"]), true, false);
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
						if (Operators.CompareString(text3, "", true) > 0 || O_O0OO.O0_00o.o0__o..DevelopByCreater)
						{
							OO_00oOO.DataTables[text2].Developer = OO_00oOO.User.Name;
							OO_00oOO.DataTables[text2].OO00_o.ooOO.(false);
						}
						O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
					}
				}
				else
				{
					string text4 = Conversions.ToString(this.o.O0_ooo0.["Name"]);
					if (this.o_O.o_0O.().SelectedIndex == 0)
					{
						this.o.O0_ooo0.["DataSource"] = DBNull.Value;
					}
					else
					{
						this.o.O0_ooo0.["DataSource"] = this.o_O.o_0O.().Text;
					}
					this.o.O0_ooo0.["Property"] = value;
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
					if (OO_00oOO.DataTables.Contains(text4))
					{
						Oo00.o00O0O_.O.(this.o.O0_ooo0., OO_00oOO.Tables[text4]);
					}
					else
					{
						o0OoOOoOOo0.OOOOO.o000.(this.O_O_.oo., text, text4, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, "", true, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), 30, null, this.o_O.o_0O.().Text, httpClient);
						OO_00oOO.DataTables[text4].o.0O000_.();
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[text4]);
						Main.OO_O.o..o0_o_o_0.0O.(Conversions.ToString(this.o.O0_ooo0.["Name"]), true, true);
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
					}
				}
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x000CEC2C File Offset: 0x000CCE2C
		private bool <<EMPTY_NAME>>(JoinTableProperty A_0)
		{
			int num;
			bool result;
			int num6;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				C1FlexGrid c1FlexGrid = this.OO0o0OO_.o.();
				IL_11:
				num2 = 3;
				if (Operators.CompareString(c1FlexGrid.GetDataDisplay(1, 0), "", true) <= 0)
				{
					goto IL_3D;
				}
				IL_2A:
				num2 = 4;
				A_0.BaseTable = c1FlexGrid.GetDataDisplay(1, 0);
				IL_53:
				num2 = 8;
				string text = "";
				IL_5C:
				num2 = 9;
				int @fixed = c1FlexGrid.Rows.Fixed;
				int num3 = c1FlexGrid.Rows.Count - 1;
				for (int i = @fixed; i <= num3; i++)
				{
					IL_82:
					num2 = 10;
					if (Operators.CompareString(c1FlexGrid.GetDataDisplay(i, 0), "", true) > 0 && Operators.CompareString(c1FlexGrid.GetDataDisplay(i, 1), "", true) > 0 && Operators.CompareString(c1FlexGrid.GetDataDisplay(i, 2), "", true) > 0 && Operators.CompareString(c1FlexGrid.GetDataDisplay(i, 3), "", true) > 0)
					{
						IL_F1:
						num2 = 11;
						JoinModeEnum joinModeEnum = JoinModeEnum.Inner;
						IL_F7:
						num2 = 12;
						text = string.Concat(new string[]
						{
							text,
							c1FlexGrid.GetDataDisplay(i, 0),
							"\t",
							c1FlexGrid.GetDataDisplay(i, 1),
							"\t",
							c1FlexGrid.GetDataDisplay(i, 2),
							"\t",
							c1FlexGrid.GetDataDisplay(i, 3),
							"\t"
						});
						IL_161:
						num2 = 13;
						string dataDisplay = c1FlexGrid.GetDataDisplay(i, 4);
						IL_170:
						num2 = 15;
						if (Operators.CompareString(dataDisplay, "左连接", true) == 0)
						{
							IL_182:
							num2 = 16;
							joinModeEnum = JoinModeEnum.Left;
						}
						else
						{
							IL_18A:
							num2 = 18;
							if (Operators.CompareString(dataDisplay, "右连接", true) == 0)
							{
								IL_19C:
								num2 = 19;
								joinModeEnum = JoinModeEnum.Right;
							}
						}
						IL_1A2:
						num2 = 20;
						text = text + Enum.GetName(typeof(JoinModeEnum), joinModeEnum) + "\n";
					}
					IL_1C9:
					num2 = 21;
				}
				IL_1DB:
				num2 = 22;
				A_0.LinkTables = text.Trim(new char[]
				{
					'\n'
				});
				IL_1F6:
				c1FlexGrid = null;
				IL_1F9:
				num2 = 24;
				C1FlexGrid c1FlexGrid2 = this.o_0.o.();
				IL_204:
				num2 = 25;
				string text2 = "";
				IL_20E:
				num2 = 26;
				if (Operators.CompareString(c1FlexGrid2.GetDataDisplay(1, 0), "", true) != 0)
				{
					goto IL_23F;
				}
				IL_227:
				num2 = 27;
				MessageBox.Show("至少要指定一列！");
				IL_235:
				num2 = 28;
				result = false;
				goto IL_39C;
				IL_23F:
				num2 = 29;
				int fixed2 = c1FlexGrid2.Rows.Fixed;
				int num4 = c1FlexGrid2.Rows.Count - 1;
				for (int j = fixed2; j <= num4; j++)
				{
					IL_265:
					num2 = 30;
					if (Operators.CompareString(c1FlexGrid2.GetDataDisplay(j, 0), "", true) > 0)
					{
						IL_283:
						num2 = 31;
						Operators.CompareString(c1FlexGrid2.GetDataDisplay(j, 1), "", true);
						IL_29E:
						num2 = 32;
						text2 = text2 + c1FlexGrid2.GetDataDisplay(j, 0) + "\t" + c1FlexGrid2.GetDataDisplay(j, 1);
						IL_2C3:
						num2 = 33;
						if (c1FlexGrid2.GetCellCheck(j, 2) == CheckEnum.Checked)
						{
							IL_2D3:
							num2 = 34;
							text2 += "\t1";
						}
						else
						{
							IL_2E6:
							num2 = 36;
							text2 += "\t0";
						}
						IL_2F7:
						num2 = 37;
						text2 += "\n";
					}
					IL_308:
					num2 = 38;
				}
				IL_31A:
				num2 = 39;
				A_0.Columns = text2.Trim(new char[]
				{
					'\n'
				});
				IL_335:
				c1FlexGrid2 = null;
				IL_338:
				num2 = 41;
				A_0.Filter = this.OO0o0OO_.o.().Text.Trim();
				IL_351:
				num2 = 42;
				A_0.Order = this.oooO00O.0_.().Text.Trim();
				IL_36A:
				num2 = 43;
				A_0.Top = this.o.0___0O_Oo__.().Text.Trim();
				IL_383:
				num2 = 44;
				A_0.Distinct = this.o_0.o.().Checked;
				IL_397:
				num2 = 45;
				result = true;
				goto IL_39C;
				IL_3D:
				num2 = 6;
				MessageBox.Show("至少要指定一个表！");
				IL_4A:
				num2 = 7;
				result = false;
				IL_39C:
				goto IL_4A6;
				IL_3A1:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_467:
				goto IL_49B;
				IL_469:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_479:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_469;
			}
			IL_49B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_4A6:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x000CF104 File Offset: 0x000CD304
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			JoinTableProperty a_ = new JoinTableProperty();
			if (this.oo_.000o.(a_))
			{
				string a_2 = Oo00.OO.0O0o.(a_);
				new O_\u30000_\u3002O\u3002\u3002\u3000\u3000(this.O_O_.oo., a_2, this.o.O0_ooo0.).ShowDialog();
			}
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x000CF140 File Offset: 0x000CD340
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = (C1FlexGrid)A_0;
			if (A_1.Control)
			{
				if (A_1.KeyCode == Keys.D)
				{
					if (c1FlexGrid.Row < c1FlexGrid.Rows.Count - 2)
					{
						c1FlexGrid.Rows[c1FlexGrid.Row].Move(c1FlexGrid.Row + 1);
						return;
					}
				}
				else if (A_1.KeyCode == Keys.U && c1FlexGrid.Row < c1FlexGrid.Rows.Count - 1 && c1FlexGrid.Row > 1)
				{
					c1FlexGrid.Rows[c1FlexGrid.Row].Move(c1FlexGrid.Row - 1);
				}
			}
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x000CF1E3 File Offset: 0x000CD3E3
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000CF1EB File Offset: 0x000CD3EB
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04000CA3 RID: 3235
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000CA4 RID: 3236
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000CA5 RID: 3237
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CA6 RID: 3238
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04000CA7 RID: 3239
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000CA8 RID: 3240
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000CA9 RID: 3241
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CAA RID: 3242
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000CAB RID: 3243
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000CAC RID: 3244
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04000CAD RID: 3245
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CAE RID: 3246
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000CAF RID: 3247
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04000CB0 RID: 3248
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CB1 RID: 3249
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000CB2 RID: 3250
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04000CB3 RID: 3251
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000CB4 RID: 3252
		private OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x04000CB5 RID: 3253
		private O0O <<EMPTY_NAME>>;

		// Token: 0x04000CB6 RID: 3254
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04000CB7 RID: 3255
		private O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000 <<EMPTY_NAME>>;

		// Token: 0x04000CB8 RID: 3256
		private Dictionary<string, List<string>> <<EMPTY_NAME>>;
	}
}
