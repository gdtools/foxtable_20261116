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
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002B6 RID: 694
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal partial class ky : Form
	{
		// Token: 0x060025F1 RID: 9713 RVA: 0x001182DC File Offset: 0x001164DC
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O0_00000.oO0. != null)
				{
					this.O0_00000.oO0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x0011831C File Offset: 0x0011651C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ky));
			this.OO._0O0Oo00.(new C1FlexGrid());
			this.oO.__O0_o__oO.(new C1Button());
			this.o___.0.(new C1Button());
			this.ooo.O__.(new Label());
			this.OO._0O0Oo00.(new C1TextBox());
			this.OO._0O0Oo00.(new Label());
			this.OO._0O0Oo00.(new C1NumericEdit());
			this.OO._0O0Oo00.(new C1CheckBox());
			this.ooO.00oO_0_o0O.(new C1CheckBox());
			this.ooO.00oO_0_o0O.(new Label());
			this.OO._0O0Oo00.(new ComboBox());
			((ISupportInitialize)this.o0_o0_OOO.O.()).BeginInit();
			((ISupportInitialize)this.o_.O0__O.()).BeginInit();
			((ISupportInitialize)this.o0_o0_OOO.O.()).BeginInit();
			((ISupportInitialize)this.oO.__O0_o__oO.()).BeginInit();
			((ISupportInitialize)this.oO.__O0_o__oO.()).BeginInit();
			((ISupportInitialize)this.o_.O0__O.()).BeginInit();
			((ISupportInitialize)this.oO.__O0_o__oO.()).BeginInit();
			base.SuspendLayout();
			this.o0_o0_OOO.O.().AllowSorting = AllowSortingEnum.None;
			this.o0_o0_OOO.O.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.o0_o0_OOO.O.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo");
			this.o0_o0_OOO.O.().ExtendLastCol = true;
			this.o0_o0_OOO.O.().FocusRect = FocusRectEnum.None;
			this.o0_o0_OOO.O.().Font = new Font("宋体", 9f);
			this.o0_o0_OOO.O.().Location = new Point(12, 73);
			this.o0_o0_OOO.O.().Name = "C1FlexGrid1";
			this.o0_o0_OOO.O.().Rows.Count = 1;
			this.o0_o0_OOO.O.().Rows.DefaultSize = 21;
			this.o0_o0_OOO.O.().SelectionMode = SelectionModeEnum.Row;
			this.o0_o0_OOO.O.().Size = new Size(494, 290);
			this.o0_o0_OOO.O.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo");
			this.o0_o0_OOO.O.().TabIndex = 1;
			this.o_.O0__O.().Location = new Point(181, 447);
			this.o_.O0__O.().Name = "Button1";
			this.o_.O0__O.().Size = new Size(75, 23);
			this.o_.O0__O.().TabIndex = 2;
			this.o_.O0__O.().Text = "确定";
			this.o_.O0__O.().UseVisualStyleBackColor = true;
			this.o0_o0_OOO.O.().Location = new Point(262, 447);
			this.o0_o0_OOO.O.().Name = "Button2";
			this.o0_o0_OOO.O.().Size = new Size(75, 23);
			this.o0_o0_OOO.O.().TabIndex = 3;
			this.o0_o0_OOO.O.().Text = "取消";
			this.o0_o0_OOO.O.().UseVisualStyleBackColor = true;
			this.oO.__O0_o__oO.().AutoSize = true;
			this.oO.__O0_o__oO.().Location = new Point(12, 12);
			this.oO.__O0_o__oO.().Name = "Label1";
			this.oO.__O0_o__oO.().Size = new Size(155, 12);
			this.oO.__O0_o__oO.().TabIndex = 8;
			this.oO.__O0_o__oO.().Text = "请选择用于生成加载树的列:";
			this.oO.__O0_o__oO.().Location = new Point(12, 33);
			this.oO.__O0_o__oO.().Name = "TextBox1";
			this.oO.__O0_o__oO.().ReadOnly = true;
			this.oO.__O0_o__oO.().Size = new Size(494, 19);
			this.oO.__O0_o__oO.().TabIndex = 7;
			this.oO.__O0_o__oO.().Tag = null;
			this.o___.0.().AutoSize = true;
			this.o___.0.().Location = new Point(12, 378);
			this.o___.0.().Name = "Label2";
			this.o___.0.().Size = new Size(83, 12);
			this.o___.0.().TabIndex = 9;
			this.o___.0.().Text = "每页加载行数:";
			this.oO.__O0_o__oO.().ImagePadding = new Padding(0);
			this.oO.__O0_o__oO.().Location = new Point(101, 376);
			this.oO.__O0_o__oO.().Name = "NumericUpDown1";
			this.oO.__O0_o__oO.().Size = new Size(84, 19);
			this.oO.__O0_o__oO.().TabIndex = 10;
			this.oO.__O0_o__oO.().Tag = null;
			C1TextBox c1TextBox = this.oO.__O0_o__oO.();
			int[] array = new int[4];
			array[0] = 10000;
			c1TextBox.Value = new decimal(array);
			this.oO.__O0_o__oO.().VisibleButtons = DropDownControlButtonFlags.UpDown;
			this.o_.O0__O.().AutoSize = true;
			this.o_.O0__O.().BorderStyle = BorderStyle.None;
			this.o_.O0__O.().Location = new Point(384, 408);
			this.o_.O0__O.().Name = "chkAutoOpen";
			this.o_.O0__O.().Size = new Size(108, 16);
			this.o_.O0__O.().TabIndex = 11;
			this.o_.O0__O.().Text = "自动显示加载树";
			this.o_.O0__O.().UseVisualStyleBackColor = true;
			this.o_.O0__O.().Value = null;
			this.oO.__O0_o__oO.().AutoSize = true;
			this.oO.__O0_o__oO.().BorderStyle = BorderStyle.None;
			this.oO.__O0_o__oO.().Location = new Point(384, 377);
			this.oO.__O0_o__oO.().Name = "LoadReverse";
			this.oO.__O0_o__oO.().Size = new Size(72, 16);
			this.oO.__O0_o__oO.().TabIndex = 12;
			this.oO.__O0_o__oO.().Text = "降序加载";
			this.oO.__O0_o__oO.().UseVisualStyleBackColor = true;
			this.oO.__O0_o__oO.().Value = null;
			this.O._o0O0oO_000o.().AutoSize = true;
			this.O._o0O0oO_000o.().Location = new Point(12, 410);
			this.O._o0O0oO_000o.().Name = "Label3";
			this.O._o0O0oO_000o.().Size = new Size(83, 12);
			this.O._o0O0oO_000o.().TabIndex = 13;
			this.O._o0O0oO_000o.().Text = "分页加载依据:";
			this.oO.__O0_o__oO.().DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.oO.__O0_o__oO.().FormattingEnabled = true;
			this.oO.__O0_o__oO.().Location = new Point(101, 407);
			this.oO.__O0_o__oO.().Name = "cmbPageOver";
			this.oO.__O0_o__oO.().Size = new Size(196, 20);
			this.oO.__O0_o__oO.().TabIndex = 14;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(518, 484);
			base.Controls.Add(this.oO.__O0_o__oO.());
			base.Controls.Add(this.O._o0O0oO_000o.());
			base.Controls.Add(this.oO.__O0_o__oO.());
			base.Controls.Add(this.o_.O0__O.());
			base.Controls.Add(this.oO.__O0_o__oO.());
			base.Controls.Add(this.o___.0.());
			base.Controls.Add(this.oO.__O0_o__oO.());
			base.Controls.Add(this.oO.__O0_o__oO.());
			base.Controls.Add(this.o0_o0_OOO.O.());
			base.Controls.Add(this.o_.O0__O.());
			base.Controls.Add(this.o0_o0_OOO.O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oO.....00";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "加载树";
			((ISupportInitialize)this.o0_o0_OOO.O.()).EndInit();
			((ISupportInitialize)this.o_.O0__O.()).EndInit();
			((ISupportInitialize)this.o0_o0_OOO.O.()).EndInit();
			((ISupportInitialize)this.oO.__O0_o__oO.()).EndInit();
			((ISupportInitialize)this.oO.__O0_o__oO.()).EndInit();
			((ISupportInitialize)this.o_.O0__O.()).EndInit();
			((ISupportInitialize)this.oO.__O0_o__oO.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x00118AD6 File Offset: 0x00116CD6
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.Oo0oo_O0o_.oo.;
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00118AE0 File Offset: 0x00116CE0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.o_.O0__O.);
			RowColEventHandler value2 = new RowColEventHandler(this.o0_o0_OOO.O.);
			C1FlexGrid oo0oo_O0o_.oo. = this.Oo0oo_O0o_.oo.;
			if (oo0oo_O0o_.oo. != null)
			{
				oo0oo_O0o_.oo..AfterEdit -= value;
				oo0oo_O0o_.oo..BeforeEdit -= value2;
			}
			this.Oo0oo_O0o_.oo. = A_0;
			oo0oo_O0o_.oo. = this.Oo0oo_O0o_.oo.;
			if (oo0oo_O0o_.oo. != null)
			{
				oo0oo_O0o_.oo..AfterEdit += value;
				oo0oo_O0o_.oo..BeforeEdit += value2;
			}
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00118B3E File Offset: 0x00116D3E
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO._0O0Oo00.;
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x00118B48 File Offset: 0x00116D48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OOO000o._00.);
			C1Button oo._0O0Oo00. = this.OO._0O0Oo00.;
			if (oo._0O0Oo00. != null)
			{
				oo._0O0Oo00..Click -= value;
			}
			this.OO._0O0Oo00. = A_0;
			oo._0O0Oo00. = this.OO._0O0Oo00.;
			if (oo._0O0Oo00. != null)
			{
				oo._0O0Oo00..Click += value;
			}
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00118B8B File Offset: 0x00116D8B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.OOoO0O_oO.;
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x00118B94 File Offset: 0x00116D94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OOO.0o_oo_00_.);
			C1Button o.OOoO0O_oO. = this.O.OOoO0O_oO.;
			if (o.OOoO0O_oO. != null)
			{
				o.OOoO0O_oO..Click -= value;
			}
			this.O.OOoO0O_oO. = A_0;
			o.OOoO0O_oO. = this.O.OOoO0O_oO.;
			if (o.OOoO0O_oO. != null)
			{
				o.OOoO0O_oO..Click += value;
			}
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00118BD7 File Offset: 0x00116DD7
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo0oo_O0o_.oo.;
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x00118BDF File Offset: 0x00116DDF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo0oo_O0o_.oo. = A_0;
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x00118BE8 File Offset: 0x00116DE8
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.Oo0oo_O0o_.oo.;
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x00118BF0 File Offset: 0x00116DF0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.Oo0oo_O0o_.oo. = A_0;
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x00118BF9 File Offset: 0x00116DF9
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.OOoO0O_oO.;
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x00118C01 File Offset: 0x00116E01
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.OOoO0O_oO. = A_0;
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x00118C0A File Offset: 0x00116E0A
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.Oo0oo_O0o_.oo.;
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x00118C12 File Offset: 0x00116E12
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			this.Oo0oo_O0o_.oo. = A_0;
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x00118C1B File Offset: 0x00116E1B
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.Oo0oo_O0o_.oo.;
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x00118C23 File Offset: 0x00116E23
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.Oo0oo_O0o_.oo. = A_0;
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00118C2C File Offset: 0x00116E2C
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O.OOoO0O_oO.;
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00118C34 File Offset: 0x00116E34
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O.OOoO0O_oO. = A_0;
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x00118C3D File Offset: 0x00116E3D
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OOOo0O.0_00.;
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00118C45 File Offset: 0x00116E45
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OOOo0O.0_00. = A_0;
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00118C4E File Offset: 0x00116E4E
		[CompilerGenerated]
		internal virtual ComboBox <<EMPTY_NAME>>()
		{
			return this.Oo0oo_O0o_.oo.;
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x00118C56 File Offset: 0x00116E56
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ComboBox A_0)
		{
			this.Oo0oo_O0o_.oo. = A_0;
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00118C60 File Offset: 0x00116E60
		public ky(Table A_0)
		{
			base.Load += this.o_.O0__O.;
			base.FormClosed += this.o0_o0_OOO.O.;
			base.Activated += this.o0_o0_OOO.O.;
			this.O0_00000.oO0. = new Dictionary<string, string>();
			int num2;
			int num5;
			object obj;
			try
			{
				IL_47:
				int num = 1;
				this.oO.__O0_o__oO.();
				IL_4F:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_66:
				num = 3;
				C1FlexGrid c1FlexGrid = this.o0_o0_OOO.O.();
				IL_6F:
				num = 4;
				c1FlexGrid.Styles.SelectedColumnHeader.Clear();
				IL_81:
				num = 5;
				c1FlexGrid.Styles.Alternate.Clear();
				IL_93:
				num = 6;
				c1FlexGrid.FocusRect = FocusRectEnum.None;
				IL_9C:
				num = 7;
				c1FlexGrid.AllowSorting = AllowSortingEnum.None;
				IL_A5:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_AC:
				num = 9;
				this.O0_00000.oO0. = A_0;
				IL_B6:
				num = 10;
				string[] array = new string[0];
				IL_C1:
				num = 11;
				if (Operators.CompareString(A_0.o.Ooo__., "", true) <= 0)
				{
					goto IL_F3;
				}
				IL_D8:
				num = 12;
				array = A_0.o.Ooo__..Split(new char[]
				{
					'|'
				});
				IL_F3:
				num = 13;
				string text = "";
				IL_FD:
				num = 14;
				IEnumerator<Col> enumerator = A_0.Cols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Col col = enumerator.Current;
					IL_11B:
					num = 15;
					if (!col.DataCol.IsTemporary)
					{
						IL_12F:
						num = 17;
						if (!this.O0_00000.oO0..ContainsKey(col.Caption))
						{
							IL_146:
							num = 18;
							this.O0_00000.oO0..Add(col.Caption, col.Name);
							IL_162:
							num = 19;
							this.o0_o0_OOO.O.().AddItem(col.Caption);
						}
						else
						{
							IL_17A:
							num = 21;
							if (!this.O0_00000.oO0..ContainsKey(col.Name))
							{
								IL_191:
								num = 22;
								this.O0_00000.oO0..Add(col.Name, col.Name);
								IL_1AD:
								num = 23;
								this.o0_o0_OOO.O.().AddItem(col.Name);
							}
						}
						IL_1C3:
						num = 24;
						int row = this.o0_o0_OOO.O.().Rows.Count - 1;
						IL_1DA:
						num = 25;
						this.o0_o0_OOO.O.().SetCellCheck(row, 0, CheckEnum.Unchecked);
						IL_1EC:
						num = 26;
						int num3 = array.Length - 1;
						for (int i = 0; i <= num3; i++)
						{
							IL_1FF:
							num = 27;
							if (Operators.CompareString(array[i], col.Name, true) == 0 || array[i].StartsWith(col.Name + " ", StringComparison.CurrentCultureIgnoreCase))
							{
								IL_237:
								num = 28;
								this.o0_o0_OOO.O.().SetCellCheck(row, 0, CheckEnum.Checked);
								IL_249:
								num = 29;
								if (col.IsDate())
								{
									IL_258:
									num = 30;
									if (array[i].EndsWith("Y", StringComparison.CurrentCultureIgnoreCase))
									{
										IL_26D:
										num = 31;
										this.o0_o0_OOO.O.()[row, 1] = true;
									}
									IL_284:
									num = 32;
									if (array[i].EndsWith("YQ", StringComparison.CurrentCultureIgnoreCase))
									{
										IL_299:
										num = 33;
										this.o0_o0_OOO.O.()[row, 2] = true;
									}
									IL_2B0:
									num = 34;
									if (array[i].EndsWith("YM", StringComparison.CurrentCultureIgnoreCase))
									{
										IL_2C5:
										num = 35;
										this.o0_o0_OOO.O.()[row, 3] = true;
									}
									IL_2DC:
									num = 36;
									if (array[i].EndsWith("YW", StringComparison.CurrentCultureIgnoreCase))
									{
										IL_2F1:
										num = 37;
										this.o0_o0_OOO.O.()[row, 4] = true;
									}
									IL_308:
									num = 38;
									if (array[i].EndsWith("YMD", StringComparison.CurrentCultureIgnoreCase))
									{
										IL_31D:
										num = 39;
										this.o0_o0_OOO.O.()[row, 5] = true;
									}
								}
							}
							IL_334:
							num = 40;
						}
					}
					IL_346:
					num = 41;
				}
				IL_355:
				num = 42;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_363:
				num = 43;
				foreach (string text2 in array)
				{
					IL_379:
					num = 44;
					string[] array3 = text2.Split(new char[]
					{
						' '
					});
					IL_390:
					num = 45;
					if (A_0.Cols.Contains(array3[0]))
					{
						IL_3A7:
						num = 46;
						if (!A_0.Cols[array3[0]].DataCol.IsTemporary)
						{
							IL_3C8:
							num = 48;
							Dictionary<string, string>.KeyCollection.Enumerator enumerator2 = this.O0_00000.oO0..Keys.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								string text3 = enumerator2.Current;
								IL_3E8:
								num = 49;
								if (Operators.CompareString(this.O0_00000.oO0.[text3], array3[0], true) == 0)
								{
									IL_404:
									num = 50;
									text += text3;
									break;
								}
								IL_414:
								num = 52;
							}
							IL_420:
							num = 53;
							((IDisposable)enumerator2).Dispose();
							IL_430:
							num = 54;
							if (array3.Length == 2)
							{
								IL_43A:
								num = 55;
								text = text + " " + array3[1];
							}
							IL_44F:
							num = 56;
							text += "|";
						}
					}
					IL_460:
					num = 57;
				}
				IL_474:
				num = 58;
				this.oO.__O0_o__oO.().Value = text.Trim(new char[]
				{
					'|'
				});
				IL_494:
				num = 59;
				this.oO.__O0_o__oO.().Value = this.O0_00000.oO0..o.0__o0.;
				IL_4B2:
				num = 60;
				this.o_.O0__O.().Checked = this.O0_00000.oO0..oo.o_ooO.;
				IL_4CB:
				num = 61;
				this.oO.__O0_o__oO.().Checked = this.O0_00000.oO0..o00Oo.O0O.;
				IL_4E4:
				goto IL_62E;
				IL_4E9:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_5EF:
				goto IL_623;
				IL_5F1:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_601:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_5F1;
			}
			IL_623:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_62E:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x001192C0 File Offset: 0x001174C0
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			int num;
			int num8;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (A_1.Col != 0)
				{
					goto IL_F3;
				}
				IL_14:
				num2 = 3;
				string a_ = this.O0_00000.oO0.[this.o0_o0_OOO.O.().Rows[A_1.Row][0].ToString()];
				IL_44:
				num2 = 4;
				if (!this.O0_00000.oO0..Cols[a_].IsDate())
				{
					goto IL_F3;
				}
				IL_62:
				num2 = 5;
				if (this.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 0) != CheckEnum.Unchecked)
				{
					goto IL_A3;
				}
				IL_79:
				num2 = 6;
				int num3 = 1;
				do
				{
					IL_7E:
					num2 = 7;
					this.o0_o0_OOO.O.().SetCellCheck(A_1.Row, num3, CheckEnum.Unchecked);
					IL_94:
					num2 = 8;
					num3++;
				}
				while (num3 <= 5);
				goto IL_F3;
				IL_A3:
				num2 = 10;
				int num4 = 1;
				bool flag;
				do
				{
					IL_A9:
					num2 = 11;
					if (this.o0_o0_OOO.O.().GetCellCheck(A_1.Row, num4) == CheckEnum.Checked)
					{
						IL_C2:
						num2 = 12;
						flag = true;
					}
					IL_C8:
					num2 = 13;
					num4++;
				}
				while (num4 <= 5);
				IL_D6:
				num2 = 14;
				if (flag)
				{
					goto IL_F3;
				}
				IL_DD:
				num2 = 15;
				this.o0_o0_OOO.O.().SetCellCheck(A_1.Row, 3, CheckEnum.Checked);
				IL_F3:
				num2 = 16;
				if (A_1.Col < 1 || A_1.Col > 5)
				{
					goto IL_15D;
				}
				IL_108:
				num2 = 17;
				if (this.o0_o0_OOO.O.().GetCellCheck(A_1.Row, A_1.Col) != CheckEnum.Checked)
				{
					goto IL_15D;
				}
				IL_125:
				num2 = 18;
				int num5 = 1;
				do
				{
					IL_12B:
					num2 = 19;
					if (A_1.Col != num5)
					{
						IL_138:
						num2 = 20;
						this.o0_o0_OOO.O.().SetCellCheck(A_1.Row, num5, CheckEnum.Unchecked);
					}
					IL_14F:
					num2 = 21;
					num5++;
				}
				while (num5 <= 5);
				IL_15D:
				num2 = 22;
				string text = this.o0_o0_OOO.O.().Rows[A_1.Row][0].ToString();
				IL_182:
				num2 = 23;
				List<string> list = new List<string>();
				IL_18C:
				num2 = 24;
				string item = text;
				IL_192:
				num2 = 25;
				if (Operators.CompareString(this.oO.__O0_o__oO.().Text, "", true) <= 0)
				{
					goto IL_1D3;
				}
				IL_1AE:
				num2 = 26;
				list.AddRange(this.oO.__O0_o__oO.().Text.Split(new char[]
				{
					'|'
				}));
				IL_1D3:
				num2 = 27;
				if (this.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 1) != CheckEnum.Checked)
				{
					goto IL_200;
				}
				IL_1EB:
				num2 = 28;
				item = text + " Y";
				goto IL_2A6;
				IL_200:
				num2 = 30;
				if (this.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 2) != CheckEnum.Checked)
				{
					goto IL_22A;
				}
				IL_218:
				num2 = 31;
				item = text + " YQ";
				goto IL_2A6;
				IL_22A:
				num2 = 33;
				if (this.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 3) != CheckEnum.Checked)
				{
					goto IL_254;
				}
				IL_242:
				num2 = 34;
				item = text + " YM";
				goto IL_2A6;
				IL_254:
				num2 = 36;
				if (this.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 4) != CheckEnum.Checked)
				{
					goto IL_27E;
				}
				IL_26C:
				num2 = 37;
				item = text + " YW";
				goto IL_2A6;
				IL_27E:
				num2 = 39;
				if (this.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 5) != CheckEnum.Checked)
				{
					goto IL_2A6;
				}
				IL_296:
				num2 = 40;
				item = text + " YMD";
				IL_2A6:
				num2 = 41;
				if (A_1.Col != 0)
				{
					goto IL_345;
				}
				IL_2B4:
				num2 = 42;
				List<string>.Enumerator enumerator = list.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text2 = enumerator.Current;
					IL_2CB:
					num2 = 43;
					if (Operators.CompareString(text2, text, true) == 0 || text2.StartsWith(text + " ", StringComparison.CurrentCultureIgnoreCase))
					{
						IL_2EE:
						num2 = 44;
						list.Remove(text2);
						break;
					}
					IL_2FD:
					num2 = 46;
				}
				IL_309:
				num2 = 47;
				((IDisposable)enumerator).Dispose();
				IL_319:
				num2 = 48;
				if (this.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 0) != CheckEnum.Checked)
				{
					goto IL_3CB;
				}
				IL_334:
				num2 = 49;
				list.Add(item);
				goto IL_3CB;
				IL_345:
				num2 = 51;
				if (this.o0_o0_OOO.O.().GetCellCheck(A_1.Row, 0) != CheckEnum.Checked)
				{
					goto IL_3CB;
				}
				IL_35D:
				num2 = 52;
				int num6 = list.Count - 1;
				for (int i = 0; i <= num6; i++)
				{
					IL_370:
					num2 = 53;
					if (Operators.CompareString(list[i], text, true) == 0 || list[i].StartsWith(text + " "))
					{
						IL_3A0:
						num2 = 54;
						list.RemoveAt(i);
						IL_3AC:
						num2 = 55;
						list.Insert(i, item);
						break;
					}
					IL_3BC:
					num2 = 57;
				}
				IL_3CB:
				num2 = 58;
				this.oO.__O0_o__oO.().Value = string.Join("|", list.ToArray());
				IL_3EA:
				goto IL_528;
				IL_3EF:
				int num7 = num8 + 1;
				num8 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7);
				IL_4E9:
				goto IL_51D;
				IL_4EB:
				num8 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_4FB:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num8 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_4EB;
			}
			IL_51D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_528:
			if (num8 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x0011981C File Offset: 0x00117A1C
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Col > 0)
			{
				string a_ = this.O0_00000.oO0.[this.o0_o0_OOO.O.().Rows[A_1.Row][0].ToString()];
				A_1.Cancel = !this.O0_00000.oO0..Cols[a_].IsDate();
			}
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x0011987E File Offset: 0x00117A7E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x00119888 File Offset: 0x00117A88
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
				if (Operators.CompareString(this.oO.__O0_o__oO.().Text.Trim(), "", true) != 0)
				{
					goto IL_4A;
				}
				IL_26:
				num2 = 3;
				this.O0_00000.oO0..o.Ooo__. = "";
				IL_38:
				num2 = 4;
				this.O0_00000.oO0..CloseLoadTree();
				goto IL_239;
				IL_4A:
				num2 = 6;
				string[] array = this.oO.__O0_o__oO.().Text.Trim().Split(new char[]
				{
					'|'
				});
				IL_6D:
				num2 = 7;
				List<string> list = new List<string>();
				IL_76:
				num2 = 8;
				foreach (string text in array)
				{
					IL_8A:
					num2 = 9;
					if (this.O0_00000.oO0..ContainsKey(text))
					{
						IL_9C:
						num2 = 10;
						list.Add(this.O0_00000.oO0.[text]);
					}
					else
					{
						IL_B5:
						num2 = 12;
						string[] array3 = text.Split(new char[]
						{
							' '
						});
						IL_CC:
						num2 = 13;
						text = this.O0_00000.oO0.[array3[0]];
						IL_E0:
						num2 = 14;
						if (array3.Length == 2)
						{
							IL_EA:
							num2 = 15;
							text = text + " " + array3[1];
						}
						IL_FF:
						num2 = 16;
						list.Add(text);
					}
					IL_10B:
					num2 = 17;
				}
				IL_11F:
				num2 = 18;
				this.O0_00000.oO0..o.0__o0. = Conversions.ToInteger(this.oO.__O0_o__oO.().Value);
				IL_13D:
				num2 = 19;
				if (list.Count != 0)
				{
					goto IL_15E;
				}
				IL_149:
				num2 = 20;
				this.O0_00000.oO0..o.Ooo__. = "";
				goto IL_17D;
				IL_15E:
				num2 = 22;
				this.O0_00000.oO0..o.Ooo__. = string.Join("|", list.ToArray());
				IL_17D:
				num2 = 23;
				if (this.oO.__O0_o__oO.().SelectedIndex != 0)
				{
					goto IL_1A2;
				}
				IL_18D:
				num2 = 24;
				this.O0_00000.oO0..O0__O_.O. = "";
				goto IL_1BB;
				IL_1A2:
				num2 = 26;
				this.O0_00000.oO0..O0__O_.O. = this.oO.__O0_o__oO.().Text;
				IL_1BB:
				num2 = 27;
				this.O0_00000.oO0..o00Oo.O0O. = this.oO.__O0_o__oO.().Checked;
				IL_1D4:
				num2 = 28;
				if (Operators.CompareString(this.O0_00000.oO0..o.Ooo__., "", true) != 0)
				{
					goto IL_1FF;
				}
				IL_1EF:
				num2 = 29;
				this.O0_00000.oO0..CloseLoadTree();
				goto IL_239;
				IL_1FF:
				num2 = 31;
				this.O0_00000.oO0..OpenLoadTree(this.O0_00000.oO0..o.Ooo__., 0, 0, false, "-");
				IL_220:
				num2 = 32;
				this.O0_00000.oO0..oo.o_ooO. = this.o_.O0__O.().Checked;
				IL_239:
				num2 = 33;
				base.Close();
				IL_242:
				num2 = 34;
				Application.DoEvents();
				IL_24A:
				num2 = 35;
				this.O0_00000.oO0..NeedSaveSetting = true;
				IL_259:
				num2 = 36;
				this.O0_00000.oO0..oo0OO0Ooo._.(true);
				IL_268:
				num2 = 37;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
				IL_285:
				goto IL_36F;
				IL_28A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_330:
				goto IL_364;
				IL_332:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_342:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_332;
			}
			IL_364:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_36F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00119C28 File Offset: 0x00117E28
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num5;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				OleDbConnection oleDbConnection = this.O0_00000.oO0..DataTable.frd_Connection;
				IL_1A:
				num2 = 3;
				DataTable dataTable = new DataTable();
				IL_23:
				num2 = 4;
				if (Operators.CompareString(this.O0_00000.oO0..DataTable.DataServer, "", true) <= 0)
				{
					goto IL_5E;
				}
				IL_43:
				num2 = 5;
				string str = Oo00.o_0o0O.0_O.(this.O0_00000.oO0..DataTable.HttpSelect);
				goto IL_77;
				IL_5E:
				num2 = 7;
				str = Oo00.o_0o0O.0_O.(this.O0_00000.oO0..DataTable.frd_SelectCommandString);
				IL_77:
				num2 = 8;
				string text = ("Select * from " + str) ?? "";
				IL_90:
				num2 = 9;
				text = Oo00.o0_o._O_.(oleDbConnection, text, false);
				IL_9E:
				num2 = 10;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(text, oleDbConnection);
				IL_AB:
				num2 = 11;
				if (Operators.CompareString(this.O0_00000.oO0..DataTable.DataServer, "", true) <= 0)
				{
					goto IL_129;
				}
				IL_CC:
				num2 = 12;
				HttpClient httpClient = O_O0OO.OoO__.0oO0oo.()[this.O0_00000.oO0..DataTable.ConnectionName].oO0_0.o.();
				IL_F0:
				num2 = 13;
				httpClient.Select = text;
				IL_FC:
				num2 = 14;
				Dictionary<string, string> dictionary = httpClient.FormData;
				string key = "Action";
				int num3 = 12;
				dictionary[key] = num3.ToString();
				IL_11B:
				num2 = 15;
				dataTable = httpClient.GetBaseDataTable();
				goto IL_137;
				IL_129:
				num2 = 17;
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				IL_137:
				num2 = 18;
				this.oO.__O0_o__oO.().Items.Add("默认");
				IL_150:
				num2 = 19;
				this.oO.__O0_o__oO.().SelectedIndex = 0;
				IL_15F:
				num2 = 20;
				if (!o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbConnection))
				{
					goto IL_1E3;
				}
				IL_16A:
				num2 = 21;
				oleDbDataAdapter.Fill(dataTable);
				IL_177:
				num2 = 22;
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					DataRow dataRow = (DataRow)obj;
					IL_198:
					num2 = 23;
					this.oO.__O0_o__oO.().Items.Add(dataRow["COLUMN_NAME"].ToString());
					IL_1BD:
					num2 = 24;
				}
				IL_1C9:
				num2 = 25;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
					goto IL_243;
				}
				goto IL_243;
				IL_1E3:
				num2 = 27;
				IEnumerator enumerator2 = dataTable.Columns.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					DataColumn dataColumn = (DataColumn)obj2;
					IL_204:
					num2 = 28;
					this.oO.__O0_o__oO.().Items.Add(dataColumn.ColumnName);
					IL_21F:
					num2 = 29;
				}
				IL_22B:
				num2 = 30;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_243:
				num2 = 31;
				if (Operators.CompareString(this.O0_00000.oO0..O0__O_.O., "", true) <= 0)
				{
					goto IL_2C9;
				}
				IL_25F:
				num2 = 32;
				num3 = this.oO.__O0_o__oO.().Items.Count - 1;
				for (int i = 1; i <= num3; i++)
				{
					IL_27B:
					num2 = 33;
					if (Operators.CompareString(this.oO.__O0_o__oO.().Items[i].ToString(), this.O0_00000.oO0..O0__O_.O., true) == 0)
					{
						IL_2A8:
						num2 = 34;
						this.oO.__O0_o__oO.().SelectedIndex = i;
						break;
					}
					IL_2BA:
					num2 = 36;
				}
				IL_2C9:
				goto IL_3AF;
				IL_2CE:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_370:
				goto IL_3A4;
				IL_372:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_382:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_372;
			}
			IL_3A4:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3AF:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x0011A008 File Offset: 0x00118208
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x0011A01C File Offset: 0x0011821C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.o0_o0_OOO.O.();
			if (c1FlexGrid.BottomRow < c1FlexGrid.Rows.Count - 1)
			{
				c1FlexGrid.Cols[0].Width = c1FlexGrid.Cols[0].Width - SystemInformation.VerticalScrollBarWidth;
			}
		}

		// Token: 0x04000FB9 RID: 4025
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000FBA RID: 4026
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04000FBB RID: 4027
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000FBC RID: 4028
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000FBD RID: 4029
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000FBE RID: 4030
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000FBF RID: 4031
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000FC0 RID: 4032
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x04000FC1 RID: 4033
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04000FC2 RID: 4034
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04000FC3 RID: 4035
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000FC4 RID: 4036
		[CompilerGenerated]
		private ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000FC5 RID: 4037
		private Table <<EMPTY_NAME>>;

		// Token: 0x04000FC6 RID: 4038
		private Dictionary<string, string> <<EMPTY_NAME>>;
	}
}
