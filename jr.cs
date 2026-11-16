using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	// Token: 0x020002B5 RID: 693
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	internal partial class jr : Form
	{
		// Token: 0x060025DC RID: 9692 RVA: 0x00116DA8 File Offset: 0x00114FA8
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o_O0.oOOo_00oO. != null)
				{
					this.o_O0.oOOo_00oO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00116DE8 File Offset: 0x00114FE8
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(jr));
			this.Ooo_o_OO.O0_O.(new Label());
			this.Ooo_o_OO.O0_O.(new C1TextBox());
			this.oO0__.ooo.(new C1Button());
			this.Ooo_o_OO.O0_O.(new C1Button());
			this.Ooo_o_OO.O0_O.(new C1FlexGrid());
			this.Ooo_o_OO.O0_O.(new C1CheckBox());
			((ISupportInitialize)this.ooooO_.OoO_0O.()).BeginInit();
			((ISupportInitialize)this.ooooO_.OoO_0O.()).BeginInit();
			((ISupportInitialize)this.oO0___0o0O.0.()).BeginInit();
			((ISupportInitialize)this.ooooO_.OoO_0O.()).BeginInit();
			((ISupportInitialize)this.ooooO_.OoO_0O.()).BeginInit();
			base.SuspendLayout();
			this.ooooO_.OoO_0O.().AutoSize = true;
			this.ooooO_.OoO_0O.().Location = new Point(12, 14);
			this.ooooO_.OoO_0O.().Name = "Label1";
			this.ooooO_.OoO_0O.().Size = new Size(155, 12);
			this.ooooO_.OoO_0O.().TabIndex = 15;
			this.ooooO_.OoO_0O.().Text = "请选择用于生成筛选树的列:";
			this.ooooO_.OoO_0O.().Location = new Point(12, 35);
			this.ooooO_.OoO_0O.().Name = "TextBox1";
			this.ooooO_.OoO_0O.().ReadOnly = true;
			this.ooooO_.OoO_0O.().Size = new Size(494, 19);
			this.ooooO_.OoO_0O.().TabIndex = 14;
			this.ooooO_.OoO_0O.().Tag = null;
			this.ooooO_.OoO_0O.().Location = new Point(263, 408);
			this.ooooO_.OoO_0O.().Name = "Button2";
			this.ooooO_.OoO_0O.().Size = new Size(75, 23);
			this.ooooO_.OoO_0O.().TabIndex = 13;
			this.ooooO_.OoO_0O.().Text = "取消";
			this.ooooO_.OoO_0O.().UseVisualStyleBackColor = true;
			this.oO0___0o0O.0.().Location = new Point(182, 408);
			this.oO0___0o0O.0.().Name = "Button1";
			this.oO0___0o0O.0.().Size = new Size(75, 23);
			this.oO0___0o0O.0.().TabIndex = 12;
			this.oO0___0o0O.0.().Text = "确定";
			this.oO0___0o0O.0.().UseVisualStyleBackColor = true;
			this.ooooO_.OoO_0O.().AllowSorting = AllowSortingEnum.None;
			this.ooooO_.OoO_0O.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.ooooO_.OoO_0O.().ColumnInfo = componentResourceManager.GetString("C1FlexGrid1.ColumnInfo");
			this.ooooO_.OoO_0O.().ExtendLastCol = true;
			this.ooooO_.OoO_0O.().FocusRect = FocusRectEnum.None;
			this.ooooO_.OoO_0O.().Font = new Font("宋体", 9f);
			this.ooooO_.OoO_0O.().Location = new Point(12, 75);
			this.ooooO_.OoO_0O.().Name = "C1FlexGrid1";
			this.ooooO_.OoO_0O.().Rows.Count = 1;
			this.ooooO_.OoO_0O.().Rows.DefaultSize = 21;
			this.ooooO_.OoO_0O.().SelectionMode = SelectionModeEnum.Row;
			this.ooooO_.OoO_0O.().Size = new Size(494, 290);
			this.ooooO_.OoO_0O.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo");
			this.ooooO_.OoO_0O.().TabIndex = 11;
			this.ooooO_.OoO_0O.().AutoSize = true;
			this.ooooO_.OoO_0O.().BorderStyle = BorderStyle.None;
			this.ooooO_.OoO_0O.().Location = new Point(12, 372);
			this.ooooO_.OoO_0O.().Name = "CheckBox1";
			this.ooooO_.OoO_0O.().Size = new Size(108, 16);
			this.ooooO_.OoO_0O.().TabIndex = 16;
			this.ooooO_.OoO_0O.().Text = "自动显示筛选树";
			this.ooooO_.OoO_0O.().UseVisualStyleBackColor = true;
			this.ooooO_.OoO_0O.().Value = null;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(520, 443);
			base.Controls.Add(this.ooooO_.OoO_0O.());
			base.Controls.Add(this.ooooO_.OoO_0O.());
			base.Controls.Add(this.ooooO_.OoO_0O.());
			base.Controls.Add(this.ooooO_.OoO_0O.());
			base.Controls.Add(this.oO0___0o0O.0.());
			base.Controls.Add(this.ooooO_.OoO_0O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o..ooO..o";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "筛选树";
			((ISupportInitialize)this.ooooO_.OoO_0O.()).EndInit();
			((ISupportInitialize)this.ooooO_.OoO_0O.()).EndInit();
			((ISupportInitialize)this.oO0___0o0O.0.()).EndInit();
			((ISupportInitialize)this.ooooO_.OoO_0O.()).EndInit();
			((ISupportInitialize)this.ooooO_.OoO_0O.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x001172A2 File Offset: 0x001154A2
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_O0.oOOo_00oO.;
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x001172AA File Offset: 0x001154AA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_O0.oOOo_00oO. = A_0;
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x001172B3 File Offset: 0x001154B3
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o_O0.oOOo_00oO.;
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x001172BB File Offset: 0x001154BB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o_O0.oOOo_00oO. = A_0;
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x001172C4 File Offset: 0x001154C4
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Ooo_o_OO.O0_O.;
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x001172CC File Offset: 0x001154CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_00_O.0o__.);
			C1Button ooo_o_OO.O0_O. = this.Ooo_o_OO.O0_O.;
			if (ooo_o_OO.O0_O. != null)
			{
				ooo_o_OO.O0_O..Click -= value;
			}
			this.Ooo_o_OO.O0_O. = A_0;
			ooo_o_OO.O0_O. = this.Ooo_o_OO.O0_O.;
			if (ooo_o_OO.O0_O. != null)
			{
				ooo_o_OO.O0_O..Click += value;
			}
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x0011730F File Offset: 0x0011550F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO0__.ooo.;
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00117318 File Offset: 0x00115518
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO_OoOOo0oOo.O.);
			C1Button c1Button = this.oO0__.ooo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO0__.ooo. = A_0;
			c1Button = this.oO0__.ooo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x0011735B File Offset: 0x0011555B
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.Ooo_o_OO.O0_O.;
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00117364 File Offset: 0x00115564
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.OO_OoOOo0oOo.O.);
			RowColEventHandler value2 = new RowColEventHandler(this.oO.0_0.);
			C1FlexGrid ooo_o_OO.O0_O. = this.Ooo_o_OO.O0_O.;
			if (ooo_o_OO.O0_O. != null)
			{
				ooo_o_OO.O0_O..AfterEdit -= value;
				ooo_o_OO.O0_O..BeforeEdit -= value2;
			}
			this.Ooo_o_OO.O0_O. = A_0;
			ooo_o_OO.O0_O. = this.Ooo_o_OO.O0_O.;
			if (ooo_o_OO.O0_O. != null)
			{
				ooo_o_OO.O0_O..AfterEdit += value;
				ooo_o_OO.O0_O..BeforeEdit += value2;
			}
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x001173C2 File Offset: 0x001155C2
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.Ooo_o_OO.O0_O.;
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x001173CA File Offset: 0x001155CA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.Ooo_o_OO.O0_O. = A_0;
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x001173D4 File Offset: 0x001155D4
		public jr(Table A_0)
		{
			base.FormClosed += this.ooooO_.OoO_0O.;
			base.Activated += this.ooooO_.OoO_0O.;
			this.o_O0.oOOo_00oO. = new Dictionary<string, string>();
			int num2;
			int num5;
			object obj;
			try
			{
				IL_35:
				int num = 1;
				this.ooooO_.OoO_0O.();
				IL_3D:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_54:
				num = 3;
				C1FlexGrid c1FlexGrid = this.ooooO_.OoO_0O.();
				IL_5D:
				num = 4;
				c1FlexGrid.Styles.SelectedColumnHeader.Clear();
				IL_6F:
				num = 5;
				c1FlexGrid.Styles.Alternate.Clear();
				IL_81:
				num = 6;
				c1FlexGrid.FocusRect = FocusRectEnum.None;
				IL_8A:
				num = 7;
				c1FlexGrid.AllowSorting = AllowSortingEnum.None;
				IL_93:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_9A:
				num = 9;
				this.o_O0.oOOo_00oO. = A_0;
				IL_A4:
				num = 10;
				string[] array = new string[0];
				IL_AF:
				num = 11;
				if (Operators.CompareString(A_0.O00.o_0OO__., "", true) <= 0)
				{
					goto IL_E1;
				}
				IL_C6:
				num = 12;
				array = A_0.O00.o_0OO__..Split(new char[]
				{
					'|'
				});
				IL_E1:
				num = 13;
				string text = "";
				IL_EB:
				num = 14;
				IEnumerator<Col> enumerator = A_0.Cols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Col col = enumerator.Current;
					IL_109:
					num = 15;
					if (!this.o_O0.oOOo_00oO..ContainsKey(col.Caption))
					{
						IL_120:
						num = 16;
						this.o_O0.oOOo_00oO..Add(col.Caption, col.Name);
						IL_13C:
						num = 17;
						this.ooooO_.OoO_0O.().AddItem(col.Caption);
					}
					else
					{
						IL_154:
						num = 19;
						if (!this.o_O0.oOOo_00oO..ContainsKey(col.Name))
						{
							IL_16B:
							num = 20;
							this.o_O0.oOOo_00oO..Add(col.Name, col.Name);
							IL_187:
							num = 21;
							this.ooooO_.OoO_0O.().AddItem(col.Name);
						}
					}
					IL_19D:
					num = 22;
					int row = this.ooooO_.OoO_0O.().Rows.Count - 1;
					IL_1B4:
					num = 23;
					this.ooooO_.OoO_0O.().SetCellCheck(row, 0, CheckEnum.Unchecked);
					IL_1C6:
					num = 24;
					int num3 = array.Length - 1;
					for (int i = 0; i <= num3; i++)
					{
						IL_1D9:
						num = 25;
						if (Operators.CompareString(array[i], col.Name, true) == 0 || array[i].StartsWith(col.Name + " ", StringComparison.CurrentCultureIgnoreCase))
						{
							IL_211:
							num = 26;
							this.ooooO_.OoO_0O.().SetCellCheck(row, 0, CheckEnum.Checked);
							IL_223:
							num = 27;
							if (col.IsDate())
							{
								IL_232:
								num = 28;
								if (array[i].EndsWith("Y", StringComparison.CurrentCultureIgnoreCase))
								{
									IL_247:
									num = 29;
									this.ooooO_.OoO_0O.()[row, 1] = true;
								}
								IL_25E:
								num = 30;
								if (array[i].EndsWith("YQ", StringComparison.CurrentCultureIgnoreCase))
								{
									IL_273:
									num = 31;
									this.ooooO_.OoO_0O.()[row, 2] = true;
								}
								IL_28A:
								num = 32;
								if (array[i].EndsWith("YM", StringComparison.CurrentCultureIgnoreCase))
								{
									IL_29F:
									num = 33;
									this.ooooO_.OoO_0O.()[row, 3] = true;
								}
								IL_2B6:
								num = 34;
								if (array[i].EndsWith("YW", StringComparison.CurrentCultureIgnoreCase))
								{
									IL_2CB:
									num = 35;
									this.ooooO_.OoO_0O.()[row, 4] = true;
								}
								IL_2E2:
								num = 36;
								if (array[i].EndsWith("YMD", StringComparison.CurrentCultureIgnoreCase))
								{
									IL_2F7:
									num = 37;
									this.ooooO_.OoO_0O.()[row, 5] = true;
								}
							}
						}
						IL_30E:
						num = 38;
					}
					IL_320:
					num = 39;
				}
				IL_32F:
				num = 40;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_33D:
				num = 41;
				foreach (string text2 in array)
				{
					IL_353:
					num = 42;
					string[] array3 = text2.Split(new char[]
					{
						' '
					});
					IL_36A:
					num = 43;
					if (A_0.Cols.Contains(array3[0]))
					{
						IL_381:
						num = 44;
						Dictionary<string, string>.KeyCollection.Enumerator enumerator2 = this.o_O0.oOOo_00oO..Keys.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							string text3 = enumerator2.Current;
							IL_3A1:
							num = 45;
							if (Operators.CompareString(this.o_O0.oOOo_00oO.[text3], array3[0], true) == 0)
							{
								IL_3BD:
								num = 46;
								text += text3;
								break;
							}
							IL_3CD:
							num = 48;
						}
						IL_3D9:
						num = 49;
						((IDisposable)enumerator2).Dispose();
						IL_3E9:
						num = 50;
						if (array3.Length == 2)
						{
							IL_3F3:
							num = 51;
							text = text + " " + array3[1];
						}
						IL_408:
						num = 52;
						text += "|";
					}
					IL_419:
					num = 53;
				}
				IL_42D:
				num = 54;
				this.ooooO_.OoO_0O.().Value = text.Trim(new char[]
				{
					'|'
				});
				IL_44D:
				num = 55;
				this.ooooO_.OoO_0O.().Checked = this.o_O0.oOOo_00oO..o0o0oOOo0__.o.;
				IL_466:
				goto IL_598;
				IL_46B:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_559:
				goto IL_58D;
				IL_55B:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_56B:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_55B;
			}
			IL_58D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_598:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x001179A0 File Offset: 0x00115BA0
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
				string a_ = this.o_O0.oOOo_00oO.[this.ooooO_.OoO_0O.().Rows[A_1.Row][0].ToString()];
				IL_44:
				num2 = 4;
				if (!this.o_O0.oOOo_00oO..Cols[a_].IsDate())
				{
					goto IL_F3;
				}
				IL_62:
				num2 = 5;
				if (this.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 0) != CheckEnum.Unchecked)
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
					this.ooooO_.OoO_0O.().SetCellCheck(A_1.Row, num3, CheckEnum.Unchecked);
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
					if (this.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, num4) == CheckEnum.Checked)
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
				this.ooooO_.OoO_0O.().SetCellCheck(A_1.Row, 3, CheckEnum.Checked);
				IL_F3:
				num2 = 16;
				if (A_1.Col < 1 || A_1.Col > 5)
				{
					goto IL_15D;
				}
				IL_108:
				num2 = 17;
				if (this.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, A_1.Col) != CheckEnum.Checked)
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
						this.ooooO_.OoO_0O.().SetCellCheck(A_1.Row, num5, CheckEnum.Unchecked);
					}
					IL_14F:
					num2 = 21;
					num5++;
				}
				while (num5 <= 5);
				IL_15D:
				num2 = 22;
				string text = this.ooooO_.OoO_0O.().Rows[A_1.Row][0].ToString();
				IL_182:
				num2 = 23;
				List<string> list = new List<string>();
				IL_18C:
				num2 = 24;
				string item = text;
				IL_192:
				num2 = 25;
				if (Operators.CompareString(this.ooooO_.OoO_0O.().Text, "", true) <= 0)
				{
					goto IL_1D3;
				}
				IL_1AE:
				num2 = 26;
				list.AddRange(this.ooooO_.OoO_0O.().Text.Split(new char[]
				{
					'|'
				}));
				IL_1D3:
				num2 = 27;
				if (this.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 1) != CheckEnum.Checked)
				{
					goto IL_200;
				}
				IL_1EB:
				num2 = 28;
				item = text + " Y";
				goto IL_2A6;
				IL_200:
				num2 = 30;
				if (this.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 2) != CheckEnum.Checked)
				{
					goto IL_22A;
				}
				IL_218:
				num2 = 31;
				item = text + " YQ";
				goto IL_2A6;
				IL_22A:
				num2 = 33;
				if (this.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 3) != CheckEnum.Checked)
				{
					goto IL_254;
				}
				IL_242:
				num2 = 34;
				item = text + " YM";
				goto IL_2A6;
				IL_254:
				num2 = 36;
				if (this.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 4) != CheckEnum.Checked)
				{
					goto IL_27E;
				}
				IL_26C:
				num2 = 37;
				item = text + " YW";
				goto IL_2A6;
				IL_27E:
				num2 = 39;
				if (this.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 5) != CheckEnum.Checked)
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
				if (this.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 0) != CheckEnum.Checked)
				{
					goto IL_3CB;
				}
				IL_334:
				num2 = 49;
				list.Add(item);
				goto IL_3CB;
				IL_345:
				num2 = 51;
				if (this.ooooO_.OoO_0O.().GetCellCheck(A_1.Row, 0) != CheckEnum.Checked)
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
				this.ooooO_.OoO_0O.().Value = string.Join("|", list.ToArray());
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

		// Token: 0x060025EC RID: 9708 RVA: 0x00117EFC File Offset: 0x001160FC
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Col > 0)
			{
				string a_ = this.o_O0.oOOo_00oO.[this.ooooO_.OoO_0O.().Rows[A_1.Row][0].ToString()];
				A_1.Cancel = !this.o_O0.oOOo_00oO..Cols[a_].IsDate();
			}
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x00117F5E File Offset: 0x0011615E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00117F68 File Offset: 0x00116168
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
				if (Operators.CompareString(this.ooooO_.OoO_0O.().Text.Trim(), "", true) != 0)
				{
					goto IL_4A;
				}
				IL_26:
				num2 = 3;
				this.o_O0.oOOo_00oO..O00.o_0OO__. = "";
				IL_38:
				num2 = 4;
				this.o_O0.oOOo_00oO..CloseFilterTree();
				goto IL_1BD;
				IL_4A:
				num2 = 6;
				string[] array = this.ooooO_.OoO_0O.().Text.Trim().Split(new char[]
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
					if (!this.o_O0.oOOo_00oO..ContainsKey(text))
					{
						IL_9C:
						num2 = 10;
						string[] array3 = text.Split(new char[]
						{
							' '
						});
						IL_B3:
						num2 = 11;
						text = this.o_O0.oOOo_00oO.[array3[0]];
						IL_C7:
						num2 = 12;
						if (array3.Length == 2)
						{
							IL_D1:
							num2 = 13;
							text = text + " " + array3[1];
						}
						IL_E6:
						num2 = 14;
						list.Add(text);
					}
					else
					{
						IL_F4:
						num2 = 16;
						list.Add(this.o_O0.oOOo_00oO.[text]);
					}
					IL_10B:
					num2 = 17;
				}
				IL_11F:
				num2 = 18;
				if (list.Count != 0)
				{
					goto IL_140;
				}
				IL_12B:
				num2 = 19;
				this.o_O0.oOOo_00oO..O00.o_0OO__. = "";
				goto IL_15F;
				IL_140:
				num2 = 21;
				this.o_O0.oOOo_00oO..O00.o_0OO__. = string.Join("|", list.ToArray());
				IL_15F:
				num2 = 22;
				if (Operators.CompareString(this.o_O0.oOOo_00oO..O00.o_0OO__., "", true) != 0)
				{
					goto IL_18A;
				}
				IL_17A:
				num2 = 23;
				this.o_O0.oOOo_00oO..CloseFilterTree();
				goto IL_1BD;
				IL_18A:
				num2 = 25;
				this.o_O0.oOOo_00oO..OpenFilterTree(this.o_O0.oOOo_00oO..O00.o_0OO__., 0);
				IL_1A4:
				num2 = 26;
				this.o_O0.oOOo_00oO..o0o0oOOo0__.o. = this.ooooO_.OoO_0O.().Checked;
				IL_1BD:
				num2 = 27;
				base.Close();
				IL_1C6:
				num2 = 28;
				Application.DoEvents();
				IL_1CE:
				num2 = 29;
				this.o_O0.oOOo_00oO..NeedSaveSetting = true;
				IL_1DD:
				num2 = 30;
				this.o_O0.oOOo_00oO..oo0OO0Ooo._.(true);
				IL_1EC:
				num2 = 31;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
				IL_209:
				goto IL_2DB;
				IL_20E:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_29C:
				goto IL_2D0;
				IL_29E:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2AE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_29E;
			}
			IL_2D0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2DB:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00118274 File Offset: 0x00116474
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00118288 File Offset: 0x00116488
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.ooooO_.OoO_0O.();
			if (c1FlexGrid.BottomRow < c1FlexGrid.Rows.Count - 1)
			{
				c1FlexGrid.Cols[0].Width = c1FlexGrid.Cols[0].Width - SystemInformation.VerticalScrollBarWidth;
			}
		}

		// Token: 0x04000FB0 RID: 4016
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000FB1 RID: 4017
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000FB2 RID: 4018
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000FB3 RID: 4019
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000FB4 RID: 4020
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000FB5 RID: 4021
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04000FB6 RID: 4022
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04000FB7 RID: 4023
		private Table <<EMPTY_NAME>>;

		// Token: 0x04000FB8 RID: 4024
		private Dictionary<string, string> <<EMPTY_NAME>>;
	}
}
