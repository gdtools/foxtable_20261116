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
using Foxtable.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000378 RID: 888
	[DesignerGenerated]
	internal partial class du : Form
	{
		// Token: 0x060038F2 RID: 14578 RVA: 0x001961D8 File Offset: 0x001943D8
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_Oo_._0O_O. != null)
				{
					this.O_Oo_._0O_O..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x00196218 File Offset: 0x00194418
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(du));
			this.oOO_oo.O_O.(new C1FlexGrid());
			this.OO.O00O_.(new C1Button());
			this.O._O0O.(new C1Button());
			this.O0o.Ooo_oOO.(new C1CheckBox());
			this.o_O.oOO.(new C1CheckBox());
			this.O_.oooo_.(new C1Button());
			this.o0_Oooo.o_o.(new C1Button());
			this.OoO_o.o.(new C1Button());
			this.OO_O0.oO00.(new C1Button());
			this.ooOo0O0o.O0_OO.(new C1Button());
			this.O0o.Ooo_oOO.(new C1Button());
			this.ooo0.oO_o0___.(new C1Button());
			this.OOo0O00._o.(new C1Button());
			this.ooo_.O.(new C1Button());
			this.oOO_oo.O_O.(new C1CheckBox());
			((ISupportInitialize)this.Ooo_o_._o0_O.()).BeginInit();
			base.SuspendLayout();
			this.Ooo_o_._o0_O.().AllowDragging = AllowDraggingEnum.None;
			this.Ooo_o_._o0_O.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.Ooo_o_._o0_O.().ColumnInfo = componentResourceManager.GetString("SubtotalGrid.ColumnInfo");
			this.Ooo_o_._o0_O.().ExtendLastCol = true;
			this.Ooo_o_._o0_O.().Location = new Point(12, 12);
			this.Ooo_o_._o0_O.().Name = "SubtotalGrid";
			this.Ooo_o_._o0_O.().Rows.Count = 1;
			this.Ooo_o_._o0_O.().Rows.DefaultSize = 21;
			this.Ooo_o_._o0_O.().SelectionMode = SelectionModeEnum.Cell;
			this.Ooo_o_._o0_O.().Size = new Size(712, 286);
			this.Ooo_o_._o0_O.().StyleInfo = componentResourceManager.GetString("SubtotalGrid.StyleInfo");
			this.Ooo_o_._o0_O.().TabIndex = 0;
			this.O_O.O0_O_.().Location = new Point(568, 388);
			this.O_O.O0_O_.().Name = "btnOk";
			this.O_O.O0_O_.().Size = new Size(75, 23);
			this.O_O.O0_O_.().TabIndex = 10;
			this.O_O.O0_O_.().Text = "确定";
			this.O_O.O0_O_.().UseVisualStyleBackColor = true;
			this.O_O._0.().Location = new Point(649, 388);
			this.O_O._0.().Name = "btnCancel";
			this.O_O._0.().Size = new Size(75, 23);
			this.O_O._0.().TabIndex = 11;
			this.O_O._0.().Text = "取消";
			this.O_O._0.().UseVisualStyleBackColor = true;
			this.O0_oo0OoO_o.o.().AutoSize = true;
			this.O0_oo0OoO_o.o.().CheckAlign = ContentAlignment.MiddleRight;
			this.O0_oo0OoO_o.o.().Location = new Point(639, 333);
			this.O0_oo0OoO_o.o.().Name = "TreeVisible";
			this.O0_oo0OoO_o.o.().Size = new Size(84, 16);
			this.O0_oo0OoO_o.o.().TabIndex = 7;
			this.O0_oo0OoO_o.o.().Text = "显示目录树";
			this.O0_oo0OoO_o.o.().UseVisualStyleBackColor = true;
			this.o__.O0.().AutoSize = true;
			this.o__.O0.().CheckAlign = ContentAlignment.MiddleRight;
			this.o__.O0.().Location = new Point(579, 311);
			this.o__.O0.().Name = "GroupAbove";
			this.o__.O0.().Size = new Size(144, 16);
			this.o__.O0.().TabIndex = 6;
			this.o__.O0.().Text = "分组行位于数据行之上";
			this.o__.O0.().UseVisualStyleBackColor = true;
			this.o_0O.o_000_0.().Location = new Point(174, 388);
			this.o_0O.o_000_0.().Name = "btnViewCode";
			this.o_0O.o_000_0.().Size = new Size(75, 23);
			this.o_0O.o_000_0.().TabIndex = 8;
			this.o_0O.o_000_0.().Text = "查看代码";
			this.o_0O.o_000_0.().UseVisualStyleBackColor = true;
			this.o0o__.0_O___.().Location = new Point(174, 311);
			this.o0o__.0_O___.().Name = "Button4";
			this.o0o__.0_O___.().Size = new Size(75, 23);
			this.o0o__.0_O___.().TabIndex = 3;
			this.o0o__.0_O___.().Text = "删除分组";
			this.o0o__.0_O___.().UseVisualStyleBackColor = true;
			this.oo0______0_.o.().Location = new Point(12, 311);
			this.oo0______0_.o.().Name = "Button5";
			this.oo0______0_.o.().Size = new Size(75, 23);
			this.oo0______0_.o.().TabIndex = 1;
			this.oo0______0_.o.().Text = "增加分组";
			this.oo0______0_.o.().UseVisualStyleBackColor = true;
			this.oo__o0.0.().Location = new Point(93, 311);
			this.oo__o0.0.().Name = "Button6";
			this.oo__o0.0.().Size = new Size(75, 23);
			this.oo__o0.0.().TabIndex = 2;
			this.oo__o0.0.().Text = "插入分组";
			this.oo__o0.0.().UseVisualStyleBackColor = true;
			this.o_oo_0OOO0.O0_.().Location = new Point(256, 311);
			this.o_oo_0OOO0.O0_.().Name = "Button7";
			this.o_oo_0OOO0.O0_.().Size = new Size(75, 23);
			this.o_oo_0OOO0.O0_.().TabIndex = 4;
			this.o_oo_0OOO0.O0_.().Text = "上移";
			this.o_oo_0OOO0.O0_.().UseVisualStyleBackColor = true;
			this.oO0Oo.oO.().Location = new Point(337, 311);
			this.oO0Oo.oO.().Name = "Button8";
			this.oO0Oo.oO.().Size = new Size(75, 23);
			this.oO0Oo.oO.().TabIndex = 5;
			this.oO0Oo.oO.().Text = "下移";
			this.oO0Oo.oO.().UseVisualStyleBackColor = true;
			this.OO00____o.0.().Location = new Point(487, 388);
			this.OO00____o.0.().Name = "btnApply";
			this.OO00____o.0.().Size = new Size(75, 23);
			this.OO00____o.0.().TabIndex = 9;
			this.OO00____o.0.().Text = "应用";
			this.OO00____o.0.().UseVisualStyleBackColor = true;
			this.o__.o0_oo0.().Location = new Point(12, 388);
			this.o__.o0_oo0.().Name = "btnSave";
			this.o__.o0_oo0.().Size = new Size(75, 23);
			this.o__.o0_oo0.().TabIndex = 12;
			this.o__.o0_oo0.().Text = "保存设置";
			this.o__.o0_oo0.().UseVisualStyleBackColor = true;
			this.o0.0o00_oO_O__.().Location = new Point(93, 388);
			this.o0.0o00_oO_O__.().Name = "btnList";
			this.o0.0o00_oO_O__.().Size = new Size(75, 23);
			this.o0.0o00_oO_O__.().TabIndex = 13;
			this.o0.0o00_oO_O__.().Text = "设置管理";
			this.o0.0o00_oO_O__.().UseVisualStyleBackColor = true;
			this.Ooo_o_._o0_O.().AutoSize = true;
			this.Ooo_o_._o0_O.().CheckAlign = ContentAlignment.MiddleRight;
			this.Ooo_o_._o0_O.().Location = new Point(639, 356);
			this.Ooo_o_._o0_O.().Name = "chkSpill";
			this.Ooo_o_._o0_O.().Size = new Size(84, 16);
			this.Ooo_o_._o0_O.().TabIndex = 14;
			this.Ooo_o_._o0_O.().Text = "合并单元格";
			this.Ooo_o_._o0_O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(735, 423);
			base.Controls.Add(this.Ooo_o_._o0_O.());
			base.Controls.Add(this.o__.o0_oo0.());
			base.Controls.Add(this.o0.0o00_oO_O__.());
			base.Controls.Add(this.OO00____o.0.());
			base.Controls.Add(this.oO0Oo.oO.());
			base.Controls.Add(this.o_oo_0OOO0.O0_.());
			base.Controls.Add(this.oo__o0.0.());
			base.Controls.Add(this.oo0______0_.o.());
			base.Controls.Add(this.o0o__.0_O___.());
			base.Controls.Add(this.o_0O.o_000_0.());
			base.Controls.Add(this.Ooo_o_._o0_O.());
			base.Controls.Add(this.o__.O0.());
			base.Controls.Add(this.O0_oo0OoO_o.o.());
			base.Controls.Add(this.O_O._0.());
			base.Controls.Add(this.O_O.O0_O_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.00.O..";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "设置汇总模式";
			((ISupportInitialize)this.Ooo_o_._o0_O.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x00196B11 File Offset: 0x00194D11
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O_Oo_._0O_O.;
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x00196B1C File Offset: 0x00194D1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.O0o.Ooo_oOO.);
			RowColEventHandler value2 = new RowColEventHandler(this.o_O.oOO.);
			RowColEventHandler value3 = new RowColEventHandler(this.oOO_oo.O_O.);
			C1FlexGrid o_Oo_._0O_O. = this.O_Oo_._0O_O.;
			if (o_Oo_._0O_O. != null)
			{
				o_Oo_._0O_O..AfterEdit -= value;
				o_Oo_._0O_O..BeforeEdit -= value2;
				o_Oo_._0O_O..CellButtonClick -= value3;
			}
			this.O_Oo_._0O_O. = A_0;
			o_Oo_._0O_O. = this.O_Oo_._0O_O.;
			if (o_Oo_._0O_O. != null)
			{
				o_Oo_._0O_O..AfterEdit += value;
				o_Oo_._0O_O..BeforeEdit += value2;
				o_Oo_._0O_O..CellButtonClick += value3;
			}
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x00196B95 File Offset: 0x00194D95
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO___O.0.;
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x00196BA0 File Offset: 0x00194DA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOOO.o.);
			C1Button oo___O.0. = this.OO___O.0.;
			if (oo___O.0. != null)
			{
				oo___O.0..Click -= value;
			}
			this.OO___O.0. = A_0;
			oo___O.0. = this.OO___O.0.;
			if (oo___O.0. != null)
			{
				oo___O.0..Click += value;
			}
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x00196BE3 File Offset: 0x00194DE3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO0O0.___oo.;
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x00196BEC File Offset: 0x00194DEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.0___0.);
			C1Button oo0O0.___oo. = this.OO0O0.___oo.;
			if (oo0O0.___oo. != null)
			{
				oo0O0.___oo..Click -= value;
			}
			this.OO0O0.___oo. = A_0;
			oo0O0.___oo. = this.OO0O0.___oo.;
			if (oo0O0.___oo. != null)
			{
				oo0O0.___oo..Click += value;
			}
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x00196C2F File Offset: 0x00194E2F
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O_Oo_._0O_O.;
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x00196C37 File Offset: 0x00194E37
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O_Oo_._0O_O. = A_0;
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x00196C40 File Offset: 0x00194E40
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.oo0_.O0oO_.;
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x00196C48 File Offset: 0x00194E48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.oo0_.O0oO_. = A_0;
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x00196C51 File Offset: 0x00194E51
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.oO_OOO00.;
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x00196C5C File Offset: 0x00194E5C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO0_.OO.);
			C1Button c1Button = this.o.oO_OOO00.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.oO_OOO00. = A_0;
			c1Button = this.o.oO_OOO00.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x00196C9F File Offset: 0x00194E9F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.0_oOO.;
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x00196CA8 File Offset: 0x00194EA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo0_0o._O.);
			C1Button o.0_oOO. = this.O.0_oOO.;
			if (o.0_oOO. != null)
			{
				o.0_oOO..Click -= value;
			}
			this.O.0_oOO. = A_0;
			o.0_oOO. = this.O.0_oOO.;
			if (o.0_oOO. != null)
			{
				o.0_oOO..Click += value;
			}
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x00196CEB File Offset: 0x00194EEB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOo_OO.O_00.;
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x00196CF4 File Offset: 0x00194EF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO_Oo0.OO_OOo0.);
			C1Button ooo_OO.O_00. = this.OOo_OO.O_00.;
			if (ooo_OO.O_00. != null)
			{
				ooo_OO.O_00..Click -= value;
			}
			this.OOo_OO.O_00. = A_0;
			ooo_OO.O_00. = this.OOo_OO.O_00.;
			if (ooo_OO.O_00. != null)
			{
				ooo_OO.O_00..Click += value;
			}
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x00196D37 File Offset: 0x00194F37
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0.O00OOO.;
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x00196D40 File Offset: 0x00194F40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO0OO_.o00_0_.);
			C1Button o0.O00OOO. = this.O0.O00OOO.;
			if (o0.O00OOO. != null)
			{
				o0.O00OOO..Click -= value;
			}
			this.O0.O00OOO. = A_0;
			o0.O00OOO. = this.O0.O00OOO.;
			if (o0.O00OOO. != null)
			{
				o0.O00OOO..Click += value;
			}
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x00196D83 File Offset: 0x00194F83
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo_.oo_oO.;
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x00196D8C File Offset: 0x00194F8C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o__.O0oOOo00O.);
			C1Button c1Button = this.oo_.oo_oO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo_.oo_oO. = A_0;
			c1Button = this.oo_.oo_oO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x00196DCF File Offset: 0x00194FCF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOoO.0.;
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x00196DD8 File Offset: 0x00194FD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.0O_o0o_OOOo.);
			C1Button oooO.0. = this.OOoO.0.;
			if (oooO.0. != null)
			{
				oooO.0..Click -= value;
			}
			this.OOoO.0. = A_0;
			oooO.0. = this.OOoO.0.;
			if (oooO.0. != null)
			{
				oooO.0..Click += value;
			}
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x00196E1B File Offset: 0x0019501B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0O.O0O_0O_.;
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x00196E24 File Offset: 0x00195024
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Ooo.O_O__o0o.);
			C1Button c1Button = this.o0O.O0O_0O_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0O.O0O_0O_. = A_0;
			c1Button = this.o0O.O0O_0O_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x00196E67 File Offset: 0x00195067
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O__O0000_O._.;
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x00196E70 File Offset: 0x00195070
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO.o___O.);
			C1Button o__O0000_O._. = this.O__O0000_O._.;
			if (o__O0000_O._. != null)
			{
				o__O0000_O._..Click -= value;
			}
			this.O__O0000_O._. = A_0;
			o__O0000_O._. = this.O__O0000_O._.;
			if (o__O0000_O._. != null)
			{
				o__O0000_O._..Click += value;
			}
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x00196EB3 File Offset: 0x001950B3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0.o0o_o.;
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x00196EBC File Offset: 0x001950BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o00O0O._.);
			C1Button c1Button = this.o0.o0o_o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0.o0o_o. = A_0;
			c1Button = this.o0.o0o_o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x00196EFF File Offset: 0x001950FF
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O.000O.;
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x00196F07 File Offset: 0x00195107
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O.000O. = A_0;
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x00196F10 File Offset: 0x00195110
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x00196F18 File Offset: 0x00195118
		public du(Table A_0, bool A_1)
		{
			base.FormClosed += this.o__.o0_oo0.;
			int num2;
			int num5;
			object obj;
			try
			{
				IL_18:
				int num = 1;
				this.o__.O0.();
				IL_20:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_37:
				num = 3;
				this.Ooo_o_._o0_O.().Styles.SelectedColumnHeader.Clear();
				IL_4E:
				num = 4;
				this.Ooo_o_._o0_O.().SelectionMode = SelectionModeEnum.Row;
				IL_5C:
				num = 5;
				this.Ooo_o_._o0_O.().Styles.Focus.Clear();
				IL_73:
				num = 6;
				this.Ooo_o_._o0_O.().Styles.Focus.MergeWith(this.Ooo_o_._o0_O.().Styles.Normal);
				IL_9A:
				num = 7;
				this.Ooo_o_._o0_O.().FocusRect = FocusRectEnum.Solid;
				IL_A8:
				num = 8;
				this.Ooo_o_._o0_O.().AllowDelete = true;
				IL_B6:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_BD:
				num = 10;
				this.O_Oo_._0O_O. = A_0;
				IL_C7:
				num = 11;
				ListDictionary listDictionary = new ListDictionary();
				IL_D0:
				num = 12;
				ListDictionary listDictionary2 = new ListDictionary();
				IL_DA:
				num = 13;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				IL_E4:
				num = 14;
				listDictionary.Add(AggregateEnum.Sum, "累计值");
				IL_F8:
				num = 15;
				listDictionary.Add(AggregateEnum.Average, "平均值");
				IL_10C:
				num = 16;
				listDictionary.Add(AggregateEnum.Count, "记录数");
				IL_120:
				num = 17;
				listDictionary.Add(AggregateEnum.Max, "最大值");
				IL_134:
				num = 18;
				listDictionary.Add(AggregateEnum.Min, "最小值");
				IL_148:
				num = 19;
				listDictionary.Add(AggregateEnum.Percent, "百分比");
				IL_15C:
				num = 20;
				listDictionary.Add(AggregateEnum.Std, "标准偏差");
				IL_171:
				num = 21;
				listDictionary.Add(AggregateEnum.StdPop, "总体标准差");
				IL_186:
				num = 22;
				listDictionary.Add(AggregateEnum.Var, "采样方差");
				IL_19B:
				num = 23;
				listDictionary.Add(AggregateEnum.VarPop, "总体方差");
				IL_1B0:
				num = 24;
				listDictionary2.Add(DateGroupEnum.Month, "月");
				IL_1C5:
				num = 25;
				listDictionary2.Add(DateGroupEnum.Quarter, "季");
				IL_1DA:
				num = 26;
				listDictionary2.Add(DateGroupEnum.Year, "年");
				IL_1EF:
				num = 27;
				listDictionary2.Add(DateGroupEnum.Week, "周");
				IL_204:
				num = 28;
				listDictionary2.Add(DateGroupEnum.Day, "日");
				IL_219:
				num = 29;
				listDictionary2.Add(DateGroupEnum.Hour, "时");
				IL_22E:
				num = 30;
				listDictionary2.Add(DateGroupEnum.Minute, "分");
				IL_243:
				num = 31;
				listDictionary2.Add(DateGroupEnum.Second, "秒");
				IL_258:
				num = 32;
				listDictionary2.Add(DateGroupEnum.None, "无");
				IL_26D:
				num = 33;
				IEnumerator<Col> enumerator = A_0.Cols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Col col = enumerator.Current;
					IL_288:
					num = 34;
					dictionary.Add(col.Name, col.Caption);
					IL_2A0:
					num = 35;
				}
				IL_2AC:
				num = 36;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_2BA:
				num = 37;
				dictionary.Add("*", "-总计-");
				IL_2CE:
				num = 38;
				this.Ooo_o_._o0_O.().Cols["Aggregate"].DataMap = listDictionary;
				IL_2EC:
				num = 39;
				this.Ooo_o_._o0_O.().Cols["DateGroup"].DataMap = listDictionary2;
				IL_30B:
				num = 40;
				this.Ooo_o_._o0_O.().Cols["GroupOn"].DataMap = dictionary;
				IL_32A:
				num = 41;
				this.Ooo_o_._o0_O.().Cols["TotalOn"].ComboList = "...";
				IL_34C:
				num = 42;
				this.Ooo_o_._o0_O.().CellButtonImage = a.O0__0.Oo0oo_.().ToBitmap();
				IL_364:
				num = 43;
				if (A_0.SubtotalGroups.Count != 0 && !A_1)
				{
					goto IL_385;
				}
				IL_377:
				num = 44;
				this.oOO.o.();
				goto IL_5A6;
				IL_385:
				num = 46;
				int num3 = A_0.SubtotalGroups.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_39F:
					num = 47;
					this.Ooo_o_._o0_O.().AddItem("");
					IL_3B3:
					num = 48;
					this.Ooo_o_._o0_O.()[this.Ooo_o_._o0_O.().Rows.Fixed + i, "GroupOn"] = A_0.SubtotalGroups[i].GroupOn;
					IL_3EB:
					num = 49;
					this.Ooo_o_._o0_O.()[this.Ooo_o_._o0_O.().Rows.Fixed + i, "TotalOn"] = A_0.SubtotalGroups[i].TotalOn;
					IL_423:
					num = 50;
					this.Ooo_o_._o0_O.()[this.Ooo_o_._o0_O.().Rows.Fixed + i, "Aggregate"] = A_0.SubtotalGroups[i].Aggregate;
					IL_460:
					num = 51;
					this.Ooo_o_._o0_O.()[this.Ooo_o_._o0_O.().Rows.Fixed + i, "Caption"] = A_0.SubtotalGroups[i].Caption;
					IL_498:
					num = 52;
					this.Ooo_o_._o0_O.()[this.Ooo_o_._o0_O.().Rows.Fixed + i, "upto"] = A_0.SubtotalGroups[i].upto;
					IL_4D5:
					num = 53;
					if (Operators.CompareString(A_0.SubtotalGroups[i].GroupOn, "", true) > 0 && A_0.foxGrid.Cols.Contains(A_0.SubtotalGroups[i].GroupOn) && A_0.View.o_o.O0ooOo.().Columns[A_0.SubtotalGroups[i].GroupOn].DataType == typeof(DateTime))
					{
						IL_557:
						num = 54;
						this.Ooo_o_._o0_O.()[this.Ooo_o_._o0_O.().Rows.Fixed + i, "DateGroup"] = A_0.SubtotalGroups[i].DateGroup;
					}
					IL_594:
					num = 55;
				}
				IL_5A6:
				num = 56;
				this.Ooo_o_._o0_O.().Col = 0;
				IL_5B5:
				num = 57;
				this.O0_oo0OoO_o.o.().Checked = A_0.TreeVisible;
				IL_5C9:
				num = 58;
				this.o__.O0.().Checked = A_0.GroupAboveData;
				IL_5DD:
				num = 59;
				this.Ooo_o_._o0_O.().Checked = A_0.SpillNode;
				IL_5F1:
				num = 60;
				this.o_0O.o_000_0.().Visible = (OO_00oOO.User.Type == UserTypeEnum.Developer);
				IL_60C:
				goto IL_752;
				IL_611:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_713:
				goto IL_747;
				IL_715:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_725:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_715;
			}
			IL_747:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_752:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x0019769C File Offset: 0x0019589C
		private void <<EMPTY_NAME>>()
		{
			this.O_Oo_._0O_O..ClearEditInfos();
			this.O_Oo_._0O_O..SubtotalGroups.Clear();
			this.O_Oo_._0O_O..SubtotalGroups.AddRange(this.o__.o0_oo0.());
			this.O_Oo_._0O_O..GroupAboveData = this.o__.O0.().Checked;
			if (this.O_Oo_._0O_O..o.Oo_o_o_0oo. != this.O0_oo0OoO_o.o.().Checked)
			{
				this.O_Oo_._0O_O..o.Oo_o_o_0oo. = this.O0_oo0OoO_o.o.().Checked;
			}
			this.O_Oo_._0O_O..SpillNode = this.Ooo_o_._o0_O.().Checked;
			this.O_Oo_._0O_O..Subtotal(false);
			this.O_Oo_._0O_O..NeedSaveSetting = true;
			this.O_Oo_._0O_O..oo0OO0Ooo._.(true);
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x00197758 File Offset: 0x00195958
		private SubtotalGroupCollection <<EMPTY_NAME>>()
		{
			int num;
			SubtotalGroupCollection result;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				SubtotalGroupCollection subtotalGroupCollection = new SubtotalGroupCollection();
				IL_10:
				num2 = 3;
				int index = this.Ooo_o_._o0_O.().Cols["upto"].Index;
				IL_2E:
				num2 = 4;
				int num3 = this.Ooo_o_._o0_O.().Rows.Count - 1;
				for (int i = 1; i <= num3; i++)
				{
					IL_4C:
					num2 = 5;
					SubtotalGroup subtotalGroup = new SubtotalGroup();
					IL_55:
					num2 = 6;
					subtotalGroup.Aggregate = (AggregateEnum)Conversions.ToInteger(this.Ooo_o_._o0_O.()[i, "Aggregate"]);
					IL_75:
					num2 = 7;
					subtotalGroup.GroupOn = this.Ooo_o_._o0_O.()[i, "GroupOn"].ToString();
					IL_95:
					num2 = 8;
					if (this.Ooo_o_._o0_O.()[i, "TotalOn"] != null)
					{
						IL_AB:
						num2 = 9;
						subtotalGroup.TotalOn = this.Ooo_o_._o0_O.()[i, "TotalOn"].ToString();
					}
					IL_CC:
					num2 = 10;
					if (this.Ooo_o_._o0_O.()[i, "Caption"] != null)
					{
						IL_E3:
						num2 = 11;
						subtotalGroup.Caption = this.Ooo_o_._o0_O.()[i, "Caption"].ToString();
					}
					IL_104:
					num2 = 12;
					if (this.Ooo_o_._o0_O.()[i, "DateGroup"] != null)
					{
						IL_11B:
						num2 = 13;
						subtotalGroup.DateGroup = (DateGroupEnum)Conversions.ToInteger(this.Ooo_o_._o0_O.()[i, "DateGroup"]);
					}
					IL_13C:
					num2 = 14;
					subtotalGroup.upto = (this.Ooo_o_._o0_O.().GetCellCheck(i, index) == CheckEnum.Checked);
					IL_158:
					num2 = 15;
					subtotalGroupCollection.Add(subtotalGroup);
					IL_164:
					num2 = 16;
				}
				IL_176:
				num2 = 17;
				result = subtotalGroupCollection;
				IL_17C:
				goto IL_216;
				IL_181:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_1D7:
				goto IL_20B;
				IL_1D9:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1E9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1D9;
			}
			IL_20B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_216:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x001979A0 File Offset: 0x00195BA0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0OoO_.oo0Ooo.();
			base.Close();
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x001979B0 File Offset: 0x00195BB0
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (Operators.CompareString(this.Ooo_o_._o0_O.().Cols[A_1.Col].Name, "GroupOn", true) == 0)
			{
				if (this.ooo0.oO_o0___.(A_1.Row))
				{
					this.Ooo_o_._o0_O.()[A_1.Row, "DateGroup"] = DateGroupEnum.Month;
				}
				else
				{
					this.Ooo_o_._o0_O.()[A_1.Row, "DateGroup"] = null;
				}
			}
			if (Operators.CompareString(this.Ooo_o_._o0_O.().Cols[A_1.Col].Name, "Aggregate", true) == 0 || Operators.CompareString(this.Ooo_o_._o0_O.().Cols[A_1.Col].Name, "GroupOn", true) == 0 || Operators.CompareString(this.Ooo_o_._o0_O.().Cols[A_1.Col].Name, "DateGroup", true) == 0 || Operators.CompareString(this.Ooo_o_._o0_O.().Cols[A_1.Col].Name, "upto", true) == 0)
			{
				this.Ooo_o_._o0_O.(A_1.Row);
			}
			Operators.CompareString(this.Ooo_o_._o0_O.().Cols[A_1.Col].Name, "TotalOn", true);
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x00197AFC File Offset: 0x00195CFC
		private bool <<EMPTY_NAME>>(int A_0)
		{
			string text = Conversions.ToString(this.Ooo_o_._o0_O.()[A_0, "GroupOn"]);
			return Operators.CompareString(text, "*", true) != 0 && this.O_Oo_._0O_O..foxGrid.Cols[text].DataType == typeof(DateTime);
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x00197B5C File Offset: 0x00195D5C
		private void <<EMPTY_NAME>>(int A_0)
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
				string text = "";
				IL_0F:
				num2 = 3;
				string value = "";
				IL_18:
				num2 = 4;
				AggregateEnum aggregateEnum = (AggregateEnum)Conversions.ToInteger(this.Ooo_o_._o0_O.()[A_0, "Aggregate"]);
				IL_32:
				num2 = 5;
				int index = this.Ooo_o_._o0_O.().Cols["upto"].Index;
				IL_50:
				num2 = 6;
				if (this.Ooo_o_._o0_O.().GetCellCheck(A_0, index) != CheckEnum.Checked)
				{
					goto IL_68;
				}
				IL_63:
				num2 = 7;
				bool flag = true;
				IL_68:
				num2 = 8;
				switch (aggregateEnum)
				{
				case AggregateEnum.Sum:
				case AggregateEnum.Percent:
				case AggregateEnum.Count:
					IL_A4:
					num2 = 10;
					if (!flag)
					{
						goto IL_B6;
					}
					IL_AB:
					num2 = 11;
					text = "累计";
					goto IL_BF;
					IL_B6:
					num2 = 13;
					text = "小计";
					IL_BF:
					num2 = 14;
					value = "总计";
					break;
				case AggregateEnum.Average:
					IL_122:
					num2 = 28;
					text = "平均";
					IL_12B:
					num2 = 29;
					value = "平均";
					break;
				case AggregateEnum.Max:
					IL_137:
					num2 = 31;
					text = "最大";
					IL_140:
					num2 = 32;
					value = "最大";
					break;
				case AggregateEnum.Min:
					IL_14C:
					num2 = 34;
					text = "最小";
					IL_155:
					num2 = 35;
					value = "最小";
					break;
				case AggregateEnum.Std:
					IL_CE:
					num2 = 16;
					text = "标准偏差";
					IL_D7:
					num2 = 17;
					value = "标准偏差";
					break;
				case AggregateEnum.Var:
					IL_E3:
					num2 = 19;
					text = "采样方差";
					IL_EC:
					num2 = 20;
					value = "采样方差";
					break;
				case AggregateEnum.StdPop:
					IL_F8:
					num2 = 22;
					text = "总体标准差";
					IL_101:
					num2 = 23;
					value = "总体标准差";
					break;
				case AggregateEnum.VarPop:
					IL_10D:
					num2 = 25;
					text = "总体方差";
					IL_116:
					num2 = 26;
					value = "总体方差";
					break;
				}
				IL_15F:
				num2 = 37;
				if (this.Ooo_o_._o0_O.()[A_0, "DateGroup"] == null || Conversions.ToInteger(this.Ooo_o_._o0_O.()[A_0, "DateGroup"]) == 0)
				{
					goto IL_1B4;
				}
				IL_18D:
				num2 = 38;
				text = "{0}" + this.Ooo_o_._o0_O.().GetDataDisplay(A_0, "DateGroup") + " " + text;
				goto IL_1C3;
				IL_1B4:
				num2 = 40;
				text = "{0} " + text;
				IL_1C3:
				num2 = 41;
				if (Operators.CompareString(this.Ooo_o_._o0_O.()[A_0, "GroupOn"].ToString(), "*", true) != 0)
				{
					goto IL_201;
				}
				IL_1E9:
				num2 = 42;
				this.Ooo_o_._o0_O.()[A_0, "Caption"] = value;
				goto IL_216;
				IL_201:
				num2 = 44;
				this.Ooo_o_._o0_O.()[A_0, "Caption"] = text;
				IL_216:
				goto IL_31C;
				IL_21B:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2DD:
				goto IL_311;
				IL_2DF:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2EF:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2DF;
			}
			IL_311:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_31C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x00197EAC File Offset: 0x001960AC
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Row > 0 && Operators.CompareString(this.Ooo_o_._o0_O.().Cols[A_1.Col].Name, "DateGroup", true) == 0 && !this.ooo0.oO_o0___.(A_1.Row))
			{
				A_1.Cancel = true;
			}
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x00197F00 File Offset: 0x00196100
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			string a_ = Conversions.ToString(this.Ooo_o_._o0_O.()[A_1.Row, "TotalOn"]);
			AggregateEnum a_2 = (AggregateEnum)Conversions.ToInteger(this.Ooo_o_._o0_O.()[A_1.Row, "Aggregate"]);
			O\u3002\u3000\u3002\u3000 o_u3002_u3000_u3002_u = new O\u3002\u3000\u3002\u3000(this.O_Oo_._0O_O., a_, a_2);
			if (o_u3002_u3000_u3002_u.ShowDialog() == DialogResult.OK)
			{
				this.Ooo_o_._o0_O.()[A_1.Row, "TotalOn"] = o_u3002_u3000_u3002_u.oO.0_0.;
				if (this.Ooo_o_._o0_O.()[A_1.Row, A_1.Col] != null)
				{
					string value = this.Ooo_o_._o0_O.()[A_1.Row, A_1.Col].ToString();
					int @fixed = this.Ooo_o_._o0_O.().Rows.Fixed;
					int num = this.Ooo_o_._o0_O.().Rows.Count - 1;
					for (int i = @fixed; i <= num; i++)
					{
						if (this.Ooo_o_._o0_O.()[i, "TotalOn"] == null)
						{
							this.Ooo_o_._o0_O.()[i, "TotalOn"] = value;
						}
					}
				}
			}
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x0019800C File Offset: 0x0019620C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oOO.o.();
			this.Ooo_o_._o0_O.().Row = this.Ooo_o_._o0_O.().Rows.Count - 1;
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x00198034 File Offset: 0x00196234
		private void <<EMPTY_NAME>>()
		{
			this.Ooo_o_._o0_O.();
			this.Ooo_o_._o0_O.().Rows.Count = this.Ooo_o_._o0_O.().Rows.Count + 1;
			int num = this.Ooo_o_._o0_O.().Rows.Count - 1;
			this.Ooo_o_._o0_O.()[num, "GroupOn"] = "*";
			if (num == 1)
			{
				this.Ooo_o_._o0_O.()[num, "Aggregate"] = AggregateEnum.Sum;
			}
			else
			{
				this.Ooo_o_._o0_O.()[num, "Aggregate"] = RuntimeHelpers.GetObjectValue(this.Ooo_o_._o0_O.()[num - 1, "Aggregate"]);
				this.Ooo_o_._o0_O.()[num, "TotalOn"] = RuntimeHelpers.GetObjectValue(this.Ooo_o_._o0_O.()[num - 1, "TotalOn"]);
			}
			this.Ooo_o_._o0_O.(num);
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x0019810B File Offset: 0x0019630B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Ooo_o_._o0_O.().Row > 0)
			{
				this.Ooo_o_._o0_O.().RemoveItem(this.Ooo_o_._o0_O.().Row);
			}
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x00198134 File Offset: 0x00196334
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oOO.o.();
			this.Ooo_o_._o0_O.().Rows[this.Ooo_o_._o0_O.().Rows.Count - 1].Move(this.Ooo_o_._o0_O.().Row);
			this.Ooo_o_._o0_O.().Row = this.Ooo_o_._o0_O.().Row - 1;
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x00198191 File Offset: 0x00196391
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Ooo_o_._o0_O.().Row > 1)
			{
				this.Ooo_o_._o0_O.().Rows[this.Ooo_o_._o0_O.().Row].Move(this.Ooo_o_._o0_O.().Row - 1);
			}
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x001981D0 File Offset: 0x001963D0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Ooo_o_._o0_O.().Row < this.Ooo_o_._o0_O.().Rows.Count - 1 && this.Ooo_o_._o0_O.().Row > 0)
			{
				this.Ooo_o_._o0_O.().Rows[this.Ooo_o_._o0_O.().Row].Move(this.Ooo_o_._o0_O.().Row + 1);
			}
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x00198238 File Offset: 0x00196438
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
				int index = this.Ooo_o_._o0_O.().Cols["upto"].Index;
				IL_24:
				num2 = 3;
				StringBuilder stringBuilder = new StringBuilder();
				IL_2D:
				num2 = 4;
				string str = "Tables(\"" + this.O_Oo_._0O_O..Name + "\")";
				IL_4B:
				num2 = 5;
				stringBuilder.Append("Dim t As Table = " + str);
				IL_61:
				num2 = 6;
				stringBuilder.Append("\r\n");
				IL_70:
				num2 = 7;
				stringBuilder.Append("Dim g As SubtotalGroup");
				IL_7F:
				num2 = 8;
				stringBuilder.Append("\r\n");
				IL_8E:
				num2 = 9;
				stringBuilder.Append("t.SubtotalGroups.Clear()");
				IL_9E:
				num2 = 10;
				stringBuilder.Append("\r\n");
				IL_AE:
				num2 = 11;
				stringBuilder.Append("t.GroupAboveData = " + this.o__.O0.().Checked.ToString());
				IL_D7:
				num2 = 12;
				stringBuilder.Append("\r\n");
				IL_E7:
				num2 = 13;
				stringBuilder.Append("t.TreeVisible = " + this.O0_oo0OoO_o.o.().Checked.ToString());
				IL_110:
				num2 = 14;
				stringBuilder.Append("\r\n");
				IL_120:
				num2 = 15;
				stringBuilder.Append("t.SpillNode = " + this.Ooo_o_._o0_O.().Checked.ToString());
				IL_149:
				num2 = 16;
				stringBuilder.Append("\r\n");
				IL_159:
				num2 = 17;
				stringBuilder.Append("\r\n");
				IL_169:
				num2 = 18;
				int num3 = this.Ooo_o_._o0_O.().Rows.Count - 1;
				for (int i = 1; i <= num3; i++)
				{
					IL_188:
					num2 = 19;
					stringBuilder.Append("g = New SubtotalGroup");
					IL_198:
					num2 = 20;
					stringBuilder.Append("\r\n");
					IL_1A8:
					num2 = 21;
					stringBuilder.Append("g.Aggregate = AggregateEnum." + Enum.GetName(typeof(AggregateEnum), (AggregateEnum)Conversions.ToInteger(this.Ooo_o_._o0_O.()[i, "Aggregate"])));
					IL_1E8:
					num2 = 22;
					stringBuilder.Append("\r\n");
					IL_1F8:
					num2 = 23;
					stringBuilder.Append("g.GroupOn = \"" + this.Ooo_o_._o0_O.()[i, "GroupOn"].ToString() + "\"");
					IL_229:
					num2 = 24;
					stringBuilder.Append("\r\n");
					IL_239:
					num2 = 25;
					if (this.Ooo_o_._o0_O.()[i, "TotalOn"] != null)
					{
						IL_250:
						num2 = 26;
						stringBuilder.Append("g.TotalOn = \"" + this.Ooo_o_._o0_O.()[i, "TotalOn"].ToString() + "\"");
						IL_281:
						num2 = 27;
						stringBuilder.Append("\r\n");
					}
					IL_291:
					num2 = 28;
					if (this.Ooo_o_._o0_O.()[i, "Caption"] != null)
					{
						IL_2A8:
						num2 = 29;
						stringBuilder.Append("g.Caption = \"" + this.Ooo_o_._o0_O.()[i, "Caption"].ToString() + "\"");
						IL_2D9:
						num2 = 30;
						stringBuilder.Append("\r\n");
					}
					IL_2E9:
					num2 = 31;
					if (this.Ooo_o_._o0_O.()[i, "DateGroup"] != null)
					{
						IL_300:
						num2 = 32;
						stringBuilder.Append("g.DateGroup = DateGroupEnum." + Enum.GetName(typeof(DateGroupEnum), (DateGroupEnum)Conversions.ToInteger(this.Ooo_o_._o0_O.()[i, "DateGroup"])));
						IL_340:
						num2 = 33;
						stringBuilder.Append("\r\n");
					}
					IL_350:
					num2 = 34;
					if (this.Ooo_o_._o0_O.().GetCellCheck(i, index) == CheckEnum.Checked)
					{
						IL_364:
						num2 = 35;
						stringBuilder.Append("g.upto = True");
						IL_374:
						num2 = 36;
						stringBuilder.Append("\r\n");
					}
					IL_384:
					num2 = 37;
					stringBuilder.Append("t.SubtotalGroups.Add(g)");
					IL_394:
					num2 = 38;
					stringBuilder.Append("\r\n");
					IL_3A4:
					num2 = 39;
					stringBuilder.Append("\r\n");
					IL_3B4:
					num2 = 40;
				}
				IL_3C6:
				num2 = 41;
				stringBuilder.Append("t.Subtotal()");
				IL_3D6:
				num2 = 42;
				o\u3000\u3000\u3002\u3002O o_u3000_u3000_u3002_u3002O = new o\u3000\u3000\u3002\u3002O();
				IL_3E0:
				num2 = 43;
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().Text = stringBuilder.ToString();
				IL_3F6:
				num2 = 44;
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().SelectionStart = 0;
				IL_406:
				num2 = 45;
				o_u3000_u3000_u3002_u3002O.ShowDialog();
				IL_411:
				goto IL_51B;
				IL_416:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_4DC:
				goto IL_510;
				IL_4DE:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_4EE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_4DE;
			}
			IL_510:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_51B:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x00198784 File Offset: 0x00196984
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0OoO_.oo0Ooo.();
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x0019878C File Offset: 0x0019698C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			SubtotalModeProperty a_ = new SubtotalModeProperty(this.o__.o0_oo0.(), this.o__.O0.().Checked, this.O0_oo0OoO_o.o.().Checked, this.Ooo_o_._o0_O.().Checked);
			new O\u3002_\u3002\u3000\u3002(this.O_Oo_._0O_O., o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\v', false), ExtendTablePropertyTypeEnum.SubtotalMode).ShowDialog();
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x001987E2 File Offset: 0x001969E2
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new o\u3000\u3000\u3002\u3002\u3002\u3002o(this.O_Oo_._0O_O., ExtendTablePropertyTypeEnum.SubtotalMode).ShowDialog();
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x001987F6 File Offset: 0x001969F6
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001757 RID: 5975
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001758 RID: 5976
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001759 RID: 5977
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400175A RID: 5978
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400175B RID: 5979
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400175C RID: 5980
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400175D RID: 5981
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400175E RID: 5982
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400175F RID: 5983
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001760 RID: 5984
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001761 RID: 5985
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001762 RID: 5986
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001763 RID: 5987
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001764 RID: 5988
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001765 RID: 5989
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001766 RID: 5990
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001767 RID: 5991
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001768 RID: 5992
		private int <<EMPTY_NAME>>;
	}
}
