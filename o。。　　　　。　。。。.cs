using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Foxtable.Syscmd;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000399 RID: 921
	[DesignerGenerated]
	internal partial class o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002 : Form
	{
		// Token: 0x06003C6F RID: 15471 RVA: 0x001B70E0 File Offset: 0x001B52E0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oOoO_OOo._. != null)
				{
					this.oOoO_OOo._..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x001B7120 File Offset: 0x001B5320
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002));
			this.o_O_0O.0_.(new C1FlexGrid());
			this.O0._o0oO0O.(new C1Button());
			this.o0___O0O00.0_.(new C1Button());
			this.o_.0O_O.(new C1Button());
			this.O0o00o.OO.(new C1Button());
			this.Oo000o.o.(new C1Button());
			this.ooo000o0.o.(new C1Button());
			this.Oo0OOO.O_O.(new C1Button());
			this.o_OoO.o_OOo.(new C1Button());
			((ISupportInitialize)this.O0._o0oO0O.()).BeginInit();
			((ISupportInitialize)this.O_o0Oo._oOoOO0.()).BeginInit();
			((ISupportInitialize)this.O0__0._0_0.()).BeginInit();
			((ISupportInitialize)this.oo_._OoO.()).BeginInit();
			((ISupportInitialize)this.O0._o0oO0O.()).BeginInit();
			((ISupportInitialize)this.O_Oo._0Oo_oo.()).BeginInit();
			((ISupportInitialize)this.O_O.OoO.()).BeginInit();
			((ISupportInitialize)this.o0___O0O00.0_.()).BeginInit();
			((ISupportInitialize)this.oO_oo.O__o.()).BeginInit();
			base.SuspendLayout();
			this.O0._o0oO0O.().AllowDragging = AllowDraggingEnum.None;
			this.O0._o0oO0O.().AllowEditing = false;
			this.O0._o0oO0O.().AllowSorting = AllowSortingEnum.None;
			this.O0._o0oO0O.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.O0._o0oO0O.().ColumnInfo = "5,0,0,30,0,100,Columns:0{Width:139;Caption:\"列名\";Style:\"ImageAlign:RightCenter;\";}\t1{Width:74;Caption:\"类型\";}\t2{Width:34;Caption:\"长度\";}\t3{Width:261;Caption:\"标题\";}\t4{Width:85;Caption:\"表达式\";}\t";
			this.O0._o0oO0O.().DrawMode = DrawModeEnum.OwnerDraw;
			this.O0._o0oO0O.().ExtendLastCol = true;
			this.O0._o0oO0O.().Font = new Font("宋体", 9f);
			this.O0._o0oO0O.().Location = new Point(11, 12);
			this.O0._o0oO0O.().Name = "C1FlexGrid1";
			this.O0._o0oO0O.().Rows.Count = 1;
			this.O0._o0oO0O.().Rows.DefaultSize = 20;
			this.O0._o0oO0O.().SelectionMode = SelectionModeEnum.Row;
			this.O0._o0oO0O.().Size = new Size(793, 433);
			this.O0._o0oO0O.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo");
			this.O0._o0oO0O.().TabIndex = 0;
			this.O_o0Oo._oOoOO0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O_o0Oo._oOoOO0.().Location = new Point(12, 451);
			this.O_o0Oo._oOoOO0.().Name = "btnAdd";
			this.O_o0Oo._oOoOO0.().Size = new Size(75, 23);
			this.O_o0Oo._oOoOO0.().TabIndex = 1;
			this.O_o0Oo._oOoOO0.().Text = "增加数据列";
			this.O_o0Oo._oOoOO0.().UseVisualStyleBackColor = true;
			this.O0__0._0_0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O0__0._0_0.().Location = new Point(184, 451);
			this.O0__0._0_0.().Name = "btnDelete";
			this.O0__0._0_0.().Size = new Size(75, 23);
			this.O0__0._0_0.().TabIndex = 5;
			this.O0__0._0_0.().Text = "删除列";
			this.O0__0._0_0.().UseVisualStyleBackColor = true;
			this.oo_._OoO.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.oo_._OoO.().Location = new Point(265, 451);
			this.oo_._OoO.().Name = "btnRename";
			this.oo_._OoO.().Size = new Size(75, 23);
			this.oo_._OoO.().TabIndex = 6;
			this.oo_._OoO.().Text = "更改列";
			this.oo_._OoO.().UseVisualStyleBackColor = true;
			this.O0._o0oO0O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O0._o0oO0O.().Location = new Point(93, 451);
			this.O0._o0oO0O.().Name = "Button1";
			this.O0._o0oO0O.().Size = new Size(85, 23);
			this.O0._o0oO0O.().TabIndex = 2;
			this.O0._o0oO0O.().Text = "增加表达式列";
			this.O0._o0oO0O.().UseVisualStyleBackColor = true;
			this.O_Oo._0Oo_oo.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O_Oo._0Oo_oo.().Location = new Point(346, 451);
			this.O_Oo._0Oo_oo.().Name = "Button2";
			this.O_Oo._0Oo_oo.().Size = new Size(75, 23);
			this.O_Oo._0Oo_oo.().TabIndex = 3;
			this.O_Oo._0Oo_oo.().Text = "修改表达式";
			this.O_Oo._0Oo_oo.().UseVisualStyleBackColor = true;
			this.O_O.OoO.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O_O.OoO.().Location = new Point(427, 451);
			this.O_O.OoO.().Name = "Button3";
			this.O_O.OoO.().Size = new Size(75, 23);
			this.O_O.OoO.().TabIndex = 7;
			this.O_O.OoO.().Text = "上移";
			this.O_O.OoO.().UseVisualStyleBackColor = true;
			this.o0___O0O00.0_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o0___O0O00.0_.().Location = new Point(508, 451);
			this.o0___O0O00.0_.().Name = "Button4";
			this.o0___O0O00.0_.().Size = new Size(75, 23);
			this.o0___O0O00.0_.().TabIndex = 8;
			this.o0___O0O00.0_.().Text = "下移";
			this.o0___O0O00.0_.().UseVisualStyleBackColor = true;
			this.oO_oo.O__o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.oO_oo.O__o.().Location = new Point(724, 451);
			this.oO_oo.O__o.().Name = "btnPrint";
			this.oO_oo.O__o.().Size = new Size(75, 23);
			this.oO_oo.O__o.().TabIndex = 11;
			this.oO_oo.O__o.().Text = "打印";
			this.oO_oo.O__o.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(814, 480);
			base.Controls.Add(this.oO_oo.O__o.());
			base.Controls.Add(this.o0___O0O00.0_.());
			base.Controls.Add(this.O_O.OoO.());
			base.Controls.Add(this.O_Oo._0Oo_oo.());
			base.Controls.Add(this.O0._o0oO0O.());
			base.Controls.Add(this.oo_._OoO.());
			base.Controls.Add(this.O0__0._0_0.());
			base.Controls.Add(this.O_o0Oo._oOoOO0.());
			base.Controls.Add(this.O0._o0oO0O.());
			base.MinimizeBox = false;
			base.Name = "o.0O0.OO.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "查看表结构";
			((ISupportInitialize)this.O0._o0oO0O.()).EndInit();
			((ISupportInitialize)this.O_o0Oo._oOoOO0.()).EndInit();
			((ISupportInitialize)this.O0__0._0_0.()).EndInit();
			((ISupportInitialize)this.oo_._OoO.()).EndInit();
			((ISupportInitialize)this.O0._o0oO0O.()).EndInit();
			((ISupportInitialize)this.O_Oo._0Oo_oo.()).EndInit();
			((ISupportInitialize)this.O_O.OoO.()).EndInit();
			((ISupportInitialize)this.o0___O0O00.0_.()).EndInit();
			((ISupportInitialize)this.oO_oo.O__o.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x001B77FD File Offset: 0x001B59FD
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.oOoO_OOo._.;
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x001B7808 File Offset: 0x001B5A08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			EventHandler value = new EventHandler(this.oooo.O.);
			OwnerDrawCellEventHandler value2 = new OwnerDrawCellEventHandler(this.o_00oOO.O__000.);
			C1FlexGrid c1FlexGrid = this.oOoO_OOo._.;
			if (c1FlexGrid != null)
			{
				c1FlexGrid.DoubleClick -= value;
				c1FlexGrid.OwnerDrawCell -= value2;
			}
			this.oOoO_OOo._. = A_0;
			c1FlexGrid = this.oOoO_OOo._.;
			if (c1FlexGrid != null)
			{
				c1FlexGrid.DoubleClick += value;
				c1FlexGrid.OwnerDrawCell += value2;
			}
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x001B7866 File Offset: 0x001B5A66
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_O_0O.0_.;
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x001B7870 File Offset: 0x001B5A70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOOo__00__._0.);
			C1Button c1Button = this.o_O_0O.0_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_O_0O.0_. = A_0;
			c1Button = this.o_O_0O.0_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x001B78B3 File Offset: 0x001B5AB3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo000o.o.;
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x001B78BC File Offset: 0x001B5ABC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OOo0OO.OoO_O_.);
			C1Button oo000o.o. = this.Oo000o.o.;
			if (oo000o.o. != null)
			{
				oo000o.o..Click -= value;
			}
			this.Oo000o.o. = A_0;
			oo000o.o. = this.Oo000o.o.;
			if (oo000o.o. != null)
			{
				oo000o.o..Click += value;
			}
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x001B78FF File Offset: 0x001B5AFF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooo_.oo.;
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x001B7908 File Offset: 0x001B5B08
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0o_o_.O_.);
			C1Button c1Button = this.ooo_.oo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooo_.oo. = A_0;
			c1Button = this.ooo_.oo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x001B794B File Offset: 0x001B5B4B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O00_o00.0O_0O_.;
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x001B7954 File Offset: 0x001B5B54
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_OOO0oO_.O.);
			C1Button o00_o00.0O_0O_. = this.O00_o00.0O_0O_.;
			if (o00_o00.0O_0O_. != null)
			{
				o00_o00.0O_0O_..Click -= value;
			}
			this.O00_o00.0O_0O_. = A_0;
			o00_o00.0O_0O_. = this.O00_o00.0O_0O_.;
			if (o00_o00.0O_0O_. != null)
			{
				o00_o00.0O_0O_..Click += value;
			}
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x001B7997 File Offset: 0x001B5B97
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_00OOOoo0.0o.;
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x001B79A0 File Offset: 0x001B5BA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.OooOo.);
			C1Button oo_00OOOoo0.0o. = this.Oo_00OOOoo0.0o.;
			if (oo_00OOOoo0.0o. != null)
			{
				oo_00OOOoo0.0o..Click -= value;
			}
			this.Oo_00OOOoo0.0o. = A_0;
			oo_00OOOoo0.0o. = this.Oo_00OOOoo0.0o.;
			if (oo_00OOOoo0.0o. != null)
			{
				oo_00OOOoo0.0o..Click += value;
			}
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x001B79E3 File Offset: 0x001B5BE3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.o_oO0o___.;
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x001B79EC File Offset: 0x001B5BEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_._ooOo_o.);
			C1Button o.o_oO0o___. = this.O.o_oO0o___.;
			if (o.o_oO0o___. != null)
			{
				o.o_oO0o___..Click -= value;
			}
			this.O.o_oO0o___. = A_0;
			o.o_oO0o___. = this.O.o_oO0o___.;
			if (o.o_oO0o___. != null)
			{
				o.o_oO0o___..Click += value;
			}
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x001B7A2F File Offset: 0x001B5C2F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0O.0oO0.;
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x001B7A38 File Offset: 0x001B5C38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo_00__o.OO__.);
			C1Button o0O.0oO0. = this.O0O.0oO0.;
			if (o0O.0oO0. != null)
			{
				o0O.0oO0..Click -= value;
			}
			this.O0O.0oO0. = A_0;
			o0O.0oO0. = this.O0O.0oO0.;
			if (o0O.0oO0. != null)
			{
				o0O.0oO0..Click += value;
			}
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x001B7A7B File Offset: 0x001B5C7B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0o00o.OO.;
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x001B7A84 File Offset: 0x001B5C84
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO00O.0O0O0o.);
			C1Button o0o00o.OO. = this.O0o00o.OO.;
			if (o0o00o.OO. != null)
			{
				o0o00o.OO..Click -= value;
			}
			this.O0o00o.OO. = A_0;
			o0o00o.OO. = this.O0o00o.OO.;
			if (o0o00o.OO. != null)
			{
				o0o00o.OO..Click += value;
			}
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x001B7AC8 File Offset: 0x001B5CC8
		public o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002()
		{
			base.Load += this.oo.0O__.;
			base.FormClosed += this.o_00oOO.O__000.;
			this.O_Oo._0Oo_oo.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.O0._o0oO0O.().Styles.SelectedColumnHeader.Clear();
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x001B7B2F File Offset: 0x001B5D2F
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O0._o0oO0O.().Rows.DefaultSize = 25;
			this.O0._o0oO0O.();
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x001B7B4C File Offset: 0x001B5D4C
		private void <<EMPTY_NAME>>()
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
				if (OO_00oOO.CurrentTable == null)
				{
					goto IL_4A0;
				}
				IL_13:
				num2 = 4;
				string right = "";
				IL_1B:
				num2 = 5;
				if (this.O0._o0oO0O.().Row <= 0)
				{
					goto IL_45;
				}
				IL_2B:
				num2 = 6;
				right = this.O0._o0oO0O.().GetDataDisplay(this.O0._o0oO0O.().Row, 0);
				IL_45:
				num2 = 7;
				this.O0._o0oO0O.().Rows.Count = 1;
				IL_58:
				num2 = 8;
				IEnumerator<Col> enumerator = OO_00oOO.CurrentTable.Cols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Col col = enumerator.Current;
					IL_79:
					num2 = 9;
					this.O0._o0oO0O.().Rows.Count = this.O0._o0oO0O.().Rows.Count + 1;
					IL_9E:
					num2 = 10;
					C1FlexGrid c1FlexGrid = this.O0._o0oO0O.();
					IL_A9:
					num2 = 11;
					c1FlexGrid.BeginUpdate();
					IL_B3:
					num2 = 12;
					c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 0, col.Name);
					IL_D4:
					num2 = 13;
					if (col.DataCol.BaseColumn.DataType == typeof(byte))
					{
						IL_F4:
						num2 = 14;
						c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "微整数");
					}
					else
					{
						IL_118:
						num2 = 16;
						if (col.DataCol.BaseColumn.DataType == typeof(short))
						{
							IL_138:
							num2 = 17;
							c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "短整数");
						}
						else
						{
							IL_15C:
							num2 = 19;
							if (col.DataCol.BaseColumn.DataType == typeof(int))
							{
								IL_17C:
								num2 = 20;
								c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "整数");
							}
							else
							{
								IL_1A0:
								num2 = 22;
								if (col.DataCol.BaseColumn.DataType == typeof(long))
								{
									IL_1C0:
									num2 = 23;
									c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "长整数");
								}
								else
								{
									IL_1E4:
									num2 = 25;
									if (col.DataCol.BaseColumn.DataType == typeof(float))
									{
										IL_204:
										num2 = 26;
										c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "单精度小数");
									}
									else
									{
										IL_228:
										num2 = 28;
										if (col.DataCol.BaseColumn.DataType == typeof(double))
										{
											IL_248:
											num2 = 29;
											c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "双精度小数");
										}
										else
										{
											IL_26C:
											num2 = 31;
											if (col.DataCol.BaseColumn.DataType == typeof(decimal))
											{
												IL_28C:
												num2 = 32;
												c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "高精度小数");
											}
											else
											{
												IL_2B0:
												num2 = 34;
												if (col.DataCol.BaseColumn.DataType == typeof(bool))
												{
													IL_2D0:
													num2 = 35;
													c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "逻辑型");
												}
												else
												{
													IL_2F4:
													num2 = 37;
													if (col.DataCol.BaseColumn.DataType == typeof(DateTime))
													{
														IL_314:
														num2 = 38;
														c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "日期时间型");
													}
													else
													{
														IL_338:
														num2 = 40;
														if (col.DataCol.BaseColumn.DataType == typeof(string))
														{
															IL_35B:
															num2 = 41;
															if (col.DataCol.BaseColumn.MaxLength == -1 || col.DataCol.BaseColumn.MaxLength > 255)
															{
																IL_38A:
																num2 = 42;
																c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "备注型");
															}
															else
															{
																IL_3AB:
																num2 = 44;
																c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 1, "字符型");
																IL_3CA:
																num2 = 45;
																c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 2, col.DataCol.BaseColumn.MaxLength);
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					IL_3FA:
					num2 = 46;
					c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 3, col.DataCol.Caption);
					IL_420:
					num2 = 47;
					c1FlexGrid.SetData(c1FlexGrid.Rows.Count - 1, 4, col.DataCol.BaseColumn.Expression);
					IL_44B:
					num2 = 48;
					if (Operators.CompareString(col.Name, right, true) == 0)
					{
						IL_45E:
						num2 = 49;
						c1FlexGrid.Row = c1FlexGrid.Rows.Count - 1;
					}
					IL_476:
					num2 = 50;
					c1FlexGrid.EndUpdate();
					IL_480:
					c1FlexGrid = null;
					IL_483:
					num2 = 52;
				}
				IL_492:
				num2 = 53;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_4A0:
				goto IL_5CA;
				IL_4A5:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_58B:
				goto IL_5BF;
				IL_58D:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_59D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_58D;
			}
			IL_5BF:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_5CA:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x001B8148 File Offset: 0x001B6348
		private bool <<EMPTY_NAME>>()
		{
			bool result;
			if (OO_00oOO.CurrentTable == null)
			{
				result = false;
			}
			else if (this.O0._o0oO0O.().Row > 0)
			{
				string dataDisplay = this.O0._o0oO0O.().GetDataDisplay(this.O0._o0oO0O.().Row, 0);
				O_oOooO_O o_oOooO_O = OO_00oOO.CurrentTable.foxGrid;
				if (o_oOooO_O.Cols.Contains(dataDisplay))
				{
					if (!o_oOooO_O.Cols[dataDisplay].Visible)
					{
						o_oOooO_O.Cols[dataDisplay].Visible = true;
					}
					o_oOooO_O.Select(o_oOooO_O.Row, o_oOooO_O.Cols[dataDisplay].Index, true);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x001B81F4 File Offset: 0x001B63F4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int count = OO_00oOO.CurrentTable.DataTable.DataCols.Count;
			Foxtable.Syscmd.Column.AddDataColumn();
			if (count != OO_00oOO.CurrentTable.DataTable.DataCols.Count)
			{
				this.O0._o0oO0O.();
				this.O0._o0oO0O.().Row = this.O0._o0oO0O.().Rows.Count - 1;
				this.O0._o0oO0O.().ShowCell(this.O0._o0oO0O.().Row, 1);
			}
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x001B826C File Offset: 0x001B646C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int count = OO_00oOO.CurrentTable.DataTable.DataCols.Count;
			Foxtable.Syscmd.Column.AddExpressionColumn();
			if (count != OO_00oOO.CurrentTable.DataTable.DataCols.Count)
			{
				this.O0._o0oO0O.();
				this.O0._o0oO0O.().Row = this.O0._o0oO0O.().Rows.Count - 1;
				this.O0._o0oO0O.().ShowCell(this.O0._o0oO0O.().Row, 1);
			}
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x001B82E2 File Offset: 0x001B64E2
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0._o0oO0O.())
			{
				Foxtable.Syscmd.Column.EditExpression();
				this.O0._o0oO0O.();
			}
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x001B82F7 File Offset: 0x001B64F7
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0._o0oO0O.())
			{
				Foxtable.Syscmd.Column.ChangeType();
				this.O0._o0oO0O.();
			}
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x001B830C File Offset: 0x001B650C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0._o0oO0O.())
			{
				int row = this.O0._o0oO0O.().Row;
				int count = OO_00oOO.CurrentTable.DataTable.DataCols.Count;
				Foxtable.Syscmd.Column.Delete();
				if (count != OO_00oOO.CurrentTable.DataTable.DataCols.Count)
				{
					this.O0._o0oO0O.();
					this.O0._o0oO0O.().Row = Math.Min(this.O0._o0oO0O.().Rows.Count - 1, row);
					this.O0._o0oO0O.().ShowCell(this.O0._o0oO0O.().Row, 1);
				}
			}
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x001B839C File Offset: 0x001B659C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0._o0oO0O.())
			{
				int row = this.O0._o0oO0O.().Row;
				Foxtable.Syscmd.Column.Rename();
				this.O0._o0oO0O.();
				this.O0._o0oO0O.().Row = row;
				this.O0._o0oO0O.().ShowCell(this.O0._o0oO0O.().Row, 1);
			}
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x001B83EB File Offset: 0x001B65EB
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0._o0oO0O.())
			{
				Foxtable.Syscmd.Column.EditGetValueCode();
			}
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x001B83FA File Offset: 0x001B65FA
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0._o0oO0O.())
			{
				Foxtable.Syscmd.Column.MoveLeft();
				this.O0._o0oO0O.();
			}
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x001B840F File Offset: 0x001B660F
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0._o0oO0O.())
			{
				Foxtable.Syscmd.Column.MoveRight();
				this.O0._o0oO0O.();
			}
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x001B8424 File Offset: 0x001B6624
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0._o0oO0O.())
			{
				Foxtable.Syscmd.Column.Rename();
				this.O0._o0oO0O.();
			}
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x001B843C File Offset: 0x001B663C
		private void <<EMPTY_NAME>>(object A_0, OwnerDrawCellEventArgs A_1)
		{
			if (A_1.Col == 0 && A_1.Row > 0 && Operators.CompareString(A_1.Text, "", true) > 0)
			{
				DataCol dataCol = OO_00oOO.CurrentTable.DataTable.DataCols[A_1.Text];
				if ((OO_00oOO.CurrentTable.DataTable.frd_IsInnerTable || OO_00oOO.CurrentTable.DataTable.frd_IsOuterTable) && dataCol.IsTemporary)
				{
					A_1.Image = a.O.o_oo0O_.().ToBitmap();
				}
			}
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x001B84C4 File Offset: 0x001B66C4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O0._o0oO0O.().PrintParameters.PrintGridFlags = PrintGridFlags.FitToPageWidth;
			this.O0._o0oO0O.().PrintParameters.Footer = OO_00oOO.CurrentTable.DataTable.Name;
			this.O0._o0oO0O.().PrintGrid(OO_00oOO.CurrentTable.DataTable.Name);
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x001B851C File Offset: 0x001B671C
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040018E3 RID: 6371
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040018E4 RID: 6372
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x040018E5 RID: 6373
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018E6 RID: 6374
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018E7 RID: 6375
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018E8 RID: 6376
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018E9 RID: 6377
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018EA RID: 6378
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018EB RID: 6379
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018EC RID: 6380
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
