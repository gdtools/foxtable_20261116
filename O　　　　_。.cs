using System;
using System.Collections.Generic;
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
	// Token: 0x02000377 RID: 887
	[DesignerGenerated]
	internal partial class O\u3000\u3000\u3000\u3000_\u3002 : Form
	{
		// Token: 0x060038D4 RID: 14548 RVA: 0x00194EFC File Offset: 0x001930FC
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oOO.o. != null)
				{
					this.oOO.o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x00194F3C File Offset: 0x0019313C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(O\u3000\u3000\u3000\u3000_\u3002));
			this.oo00.o0o.(new C1Button());
			this.Ooo.OO0_.(new C1Button());
			this.Ooo.OO0_.(new GroupBox());
			this.o.00oO00_O_.(new RadioButton());
			this.Ooo.OO0_.(new RadioButton());
			this.oO0._o_o_O.(new RadioButton());
			this.oo_O0.Oo.(new Label());
			this.Ooo.OO0_.(new Label());
			this.oo_O0.Oo.(new C1Button());
			this.Ooo.OO0_.(new C1FlexGrid());
			this.o0o0oOo_O.0oo.().SuspendLayout();
			((ISupportInitialize)this.o0o0oOo_O.0oo.()).BeginInit();
			base.SuspendLayout();
			this.ooOo.00o.().Location = new Point(313, 344);
			this.ooOo.00o.().Name = "cmdAccept";
			this.ooOo.00o.().Size = new Size(75, 23);
			this.ooOo.00o.().TabIndex = 3;
			this.ooOo.00o.().Text = "确定";
			this.ooOo.00o.().UseVisualStyleBackColor = true;
			this.ooOoO00.00o.().Location = new Point(394, 344);
			this.ooOoO00.00o.().Name = "cmdCancel";
			this.ooOoO00.00o.().Size = new Size(75, 23);
			this.ooOoO00.00o.().TabIndex = 4;
			this.ooOoO00.00o.().Text = "取消";
			this.ooOoO00.00o.().UseVisualStyleBackColor = true;
			this.o0o0oOo_O.0oo.().Controls.Add(this.ooOo.00o.());
			this.o0o0oOo_O.0oo.().Controls.Add(this.o0o0oOo_O.0oo.());
			this.o0o0oOo_O.0oo.().Controls.Add(this.ooOoO00.00o.());
			this.o0o0oOo_O.0oo.().Location = new Point(13, 241);
			this.o0o0oOo_O.0oo.().Name = "GroupBox2";
			this.o0o0oOo_O.0oo.().Size = new Size(456, 48);
			this.o0o0oOo_O.0oo.().TabIndex = 1;
			this.o0o0oOo_O.0oo.().TabStop = false;
			this.o0o0oOo_O.0oo.().Text = "合并类型";
			this.ooOo.00o.().AutoSize = true;
			this.ooOo.00o.().Location = new Point(113, 19);
			this.ooOo.00o.().Name = "NotMerge";
			this.ooOo.00o.().Size = new Size(59, 16);
			this.ooOo.00o.().TabIndex = 2;
			this.ooOo.00o.().TabStop = true;
			this.ooOo.00o.().Text = "不合并";
			this.ooOo.00o.().UseVisualStyleBackColor = true;
			this.o0o0oOo_O.0oo.().AutoSize = true;
			this.o0o0oOo_O.0oo.().Location = new Point(60, 19);
			this.o0o0oOo_O.0oo.().Name = "Free";
			this.o0o0oOo_O.0oo.().Size = new Size(47, 16);
			this.o0o0oOo_O.0oo.().TabIndex = 1;
			this.o0o0oOo_O.0oo.().TabStop = true;
			this.o0o0oOo_O.0oo.().Text = "自由";
			this.o0o0oOo_O.0oo.().UseVisualStyleBackColor = true;
			this.ooOoO00.00o.().AutoSize = true;
			this.ooOoO00.00o.().Checked = true;
			this.ooOoO00.00o.().Location = new Point(7, 19);
			this.ooOoO00.00o.().Name = "Standard";
			this.ooOoO00.00o.().Size = new Size(47, 16);
			this.ooOoO00.00o.().TabIndex = 0;
			this.ooOoO00.00o.().TabStop = true;
			this.ooOoO00.00o.().Text = "标准";
			this.ooOoO00.00o.().UseVisualStyleBackColor = true;
			this.o0o0oOo_O.0oo.().AutoSize = true;
			this.o0o0oOo_O.0oo.().Location = new Point(13, 14);
			this.o0o0oOo_O.0oo.().Name = "Label1";
			this.o0o0oOo_O.0oo.().Size = new Size(71, 12);
			this.o0o0oOo_O.0oo.().TabIndex = 11;
			this.o0o0oOo_O.0oo.().Text = "选择合并列:";
			this.ooOo.00o.().Location = new Point(13, 307);
			this.ooOo.00o.().Name = "Label2";
			this.ooOo.00o.().Size = new Size(486, 34);
			this.ooOo.00o.().TabIndex = 1;
			this.ooOo.00o.().Text = "提示:对于标准合并，合并列必须从第一列开始，而且是连续的，否则达不到合并效果";
			this.o0o0oOo_O.0oo.().Location = new Point(13, 344);
			this.o0o0oOo_O.0oo.().Name = "btnViewCode";
			this.o0o0oOo_O.0oo.().Size = new Size(75, 23);
			this.o0o0oOo_O.0oo.().TabIndex = 2;
			this.o0o0oOo_O.0oo.().Text = "查看代码";
			this.o0o0oOo_O.0oo.().UseVisualStyleBackColor = true;
			this.o0o0oOo_O.0oo.().AllowSorting = AllowSortingEnum.None;
			this.o0o0oOo_O.0oo.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.o0o0oOo_O.0oo.().ColumnInfo = "2,0,0,20,0,0,Columns:0{Width:362;Caption:\"名称\";}\t1{Width:30;Caption:\"排序\";Style:\"ComboList:\"\"升序|降序|不排序\"\";\";}\t";
			this.o0o0oOo_O.0oo.().ExtendLastCol = true;
			this.o0o0oOo_O.0oo.().FocusRect = FocusRectEnum.None;
			this.o0o0oOo_O.0oo.().Location = new Point(13, 33);
			this.o0o0oOo_O.0oo.().Name = "C1FlexGrid1";
			this.o0o0oOo_O.0oo.().Rows.Count = 1;
			this.o0o0oOo_O.0oo.().Rows.DefaultSize = 19;
			this.o0o0oOo_O.0oo.().SelectionMode = SelectionModeEnum.Row;
			this.o0o0oOo_O.0oo.().Size = new Size(456, 195);
			this.o0o0oOo_O.0oo.().StyleInfo = componentResourceManager.GetString("C1FlexGrid1.StyleInfo");
			this.o0o0oOo_O.0oo.().TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(482, 386);
			base.Controls.Add(this.o0o0oOo_O.0oo.());
			base.Controls.Add(this.o0o0oOo_O.0oo.());
			base.Controls.Add(this.ooOo.00o.());
			base.Controls.Add(this.o0o0oOo_O.0oo.());
			base.Controls.Add(this.o0o0oOo_O.0oo.());
			base.Controls.Add(this.ooOoO00.00o.());
			base.Controls.Add(this.ooOo.00o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O00....O";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "设置合并模式";
			this.o0o0oOo_O.0oo.().ResumeLayout(false);
			this.o0o0oOo_O.0oo.().PerformLayout();
			((ISupportInitialize)this.o0o0oOo_O.0oo.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x001955CE File Offset: 0x001937CE
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_oO._0Oo.;
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x001955D8 File Offset: 0x001937D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.oO0_OoOooO.);
			C1Button o_oO._0Oo. = this.O_oO._0Oo.;
			if (o_oO._0Oo. != null)
			{
				o_oO._0Oo..Click -= value;
			}
			this.O_oO._0Oo. = A_0;
			o_oO._0Oo. = this.O_oO._0Oo.;
			if (o_oO._0Oo. != null)
			{
				o_oO._0Oo..Click += value;
			}
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x0019561B File Offset: 0x0019381B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.00oO00_O_.;
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x00195624 File Offset: 0x00193824
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo__._0__.);
			C1Button c1Button = this.o.00oO00_O_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.00oO00_O_. = A_0;
			c1Button = this.o.00oO00_O_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x00195667 File Offset: 0x00193867
		[CompilerGenerated]
		internal virtual GroupBox <<EMPTY_NAME>>()
		{
			return this.O_oO._0Oo.;
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0019566F File Offset: 0x0019386F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(GroupBox A_0)
		{
			this.O_oO._0Oo. = A_0;
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x00195678 File Offset: 0x00193878
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O_oO._0Oo.;
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x00195680 File Offset: 0x00193880
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O_oO._0Oo. = A_0;
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x00195689 File Offset: 0x00193889
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o0OoO_.oo0Ooo.;
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x00195691 File Offset: 0x00193891
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.o0OoO_.oo0Ooo. = A_0;
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x0019569A File Offset: 0x0019389A
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_oO._0Oo.;
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x001956A2 File Offset: 0x001938A2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_oO._0Oo. = A_0;
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x001956AB File Offset: 0x001938AB
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.Ooo.O_O__o0o.;
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x001956B3 File Offset: 0x001938B3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.Ooo.O_O__o0o. = A_0;
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x001956BC File Offset: 0x001938BC
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.00oO00_O_.;
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x001956C4 File Offset: 0x001938C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.00oO00_O_. = A_0;
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x001956CD File Offset: 0x001938CD
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO0._o_o_O.;
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x001956D8 File Offset: 0x001938D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0_00000.oO0.);
			C1Button c1Button = this.oO0._o_o_O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO0._o_o_O. = A_0;
			c1Button = this.oO0._o_o_O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x0019571B File Offset: 0x0019391B
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O_oO._0Oo.;
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x00195724 File Offset: 0x00193924
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			RangeEventHandler value = new RangeEventHandler(this.O0_00000.oO0.);
			C1FlexGrid o_oO._0Oo. = this.O_oO._0Oo.;
			if (o_oO._0Oo. != null)
			{
				o_oO._0Oo..AfterRowColChange -= value;
			}
			this.O_oO._0Oo. = A_0;
			o_oO._0Oo. = this.O_oO._0Oo.;
			if (o_oO._0Oo. != null)
			{
				o_oO._0Oo..AfterRowColChange += value;
			}
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x00195768 File Offset: 0x00193968
		public O\u3000\u3000\u3000\u3000_\u3002(Table A_0)
		{
			base.Load += this.oOo._0.;
			base.FormClosed += this.O0_00000.oO0.;
			this.oOO.o. = new List<string>();
			this.oOO.o. = "";
			this.oo_O0.Oo.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o0o0oOo_O.0oo.().Styles.SelectedColumnHeader.Clear();
			this.oOO.o. = A_0;
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x001957EC File Offset: 0x001939EC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oOO.o..ClearEditInfos();
			this.Ooo.OO0_.();
			this.oOO.o..MergeCols.Clear();
			try
			{
				foreach (string text in this.oOO.o.)
				{
					this.oOO.o..Cols[text].AllowMerging = true;
					this.oOO.o..MergeCols.Add(text);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.oOO.o..MergeSort = this.oOO.o.;
			this.oOO.o..MergeMode = this.oOO.o.;
			this.oOO.o..AllowMerge = true;
			base.Close();
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x001958B8 File Offset: 0x00193AB8
		private void <<EMPTY_NAME>>()
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
				if (this.oOO.o. == null)
				{
					goto IL_1B3;
				}
				IL_14:
				num2 = 4;
				this.oOO.o..Clear();
				IL_21:
				num2 = 5;
				this.oOO.o. = "";
				IL_2E:
				num2 = 6;
				int num3 = this.o0o0oOo_O.0oo.().Rows.Count - 1;
				for (int i = 1; i <= num3; i++)
				{
					IL_4C:
					num2 = 7;
					int row = i - this.oOO.o..foxGrid.Cols.Fixed + 1;
					IL_69:
					num2 = 8;
					string text = Conversions.ToString(this.o0o0oOo_O.0oo.()[row, 0]);
					IL_7F:
					num2 = 9;
					if (this.o0o0oOo_O.0oo.().GetCellCheck(row, 0) == CheckEnum.Checked)
					{
						IL_95:
						num2 = 10;
						this.oOO.o..Add(text);
						IL_A5:
						num2 = 11;
						string left = Conversions.ToString(this.o0o0oOo_O.0oo.()[row, 1]);
						IL_BC:
						num2 = 13;
						string text2;
						if (Operators.CompareString(left, "升序", true) == 0)
						{
							IL_CE:
							num2 = 14;
							text2 = text;
						}
						else
						{
							IL_D7:
							num2 = 16;
							if (Operators.CompareString(left, "降序", true) == 0)
							{
								IL_E9:
								num2 = 17;
								text2 = text + " DESC";
							}
							else
							{
								IL_FC:
								num2 = 19;
								text2 = "";
							}
						}
						IL_106:
						num2 = 20;
						if (Operators.CompareString(this.oOO.o., "", true) > 0 & Operators.CompareString(text2, "", true) > 0)
						{
							IL_130:
							num2 = 21;
							this.oOO.o. += ",";
						}
						IL_149:
						num2 = 22;
						this.oOO.o. += text2;
					}
					IL_15F:
					num2 = 23;
				}
				IL_171:
				num2 = 24;
				if (!this.ooOoO00.00o.().Checked)
				{
					goto IL_18D;
				}
				IL_181:
				num2 = 25;
				this.oOO.o. = MergeModeEnum.Standard;
				goto IL_1B3;
				IL_18D:
				num2 = 27;
				if (!this.o0o0oOo_O.0oo.().Checked)
				{
					goto IL_1A9;
				}
				IL_19D:
				num2 = 28;
				this.oOO.o. = MergeModeEnum.Free;
				goto IL_1B3;
				IL_1A9:
				num2 = 30;
				this.oOO.o. = MergeModeEnum.None;
				IL_1B3:
				goto IL_281;
				IL_1B8:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_242:
				goto IL_276;
				IL_244:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_254:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_244;
			}
			IL_276:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_281:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x00195B6C File Offset: 0x00193D6C
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
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				IL_10:
				num2 = 3;
				IEnumerator<Col> enumerator = this.oOO.o..Cols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Col col = enumerator.Current;
					IL_2F:
					num2 = 4;
					dictionary.Add(col.Name, col.Caption);
					IL_46:
					num2 = 5;
				}
				IL_51:
				num2 = 6;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_5E:
				num2 = 7;
				this.o0o0oOo_O.0oo.().Cols[0].DataMap = dictionary;
				IL_78:
				num2 = 8;
				this.o0o0oOo_O.0oo.().Rows.Count = this.oOO.o..foxGrid.Cols.Count - this.oOO.o..foxGrid.Cols.Fixed + 1;
				IL_B7:
				num2 = 9;
				int @fixed = this.oOO.o..foxGrid.Cols.Fixed;
				int num3 = this.oOO.o..foxGrid.Cols.Count - 1;
				for (int i = @fixed; i <= num3; i++)
				{
					IL_EF:
					num2 = 10;
					string name = this.oOO.o..foxGrid.Cols[i].Name;
					IL_10F:
					num2 = 11;
					int row = i - this.oOO.o..foxGrid.Cols.Fixed + 1;
					IL_12E:
					num2 = 12;
					this.o0o0oOo_O.0oo.()[row, 0] = name;
					IL_140:
					num2 = 13;
					if (this.oOO.o..O_O__.ooOo..ContainsKey(this.oOO.o..foxGrid.Cols[i].Name.ToLower()) && this.oOO.o..O_O__.ooOo.[this.oOO.o..foxGrid.Cols[i].Name.ToLower()] == ListSortDirection.Descending)
					{
						IL_1AA:
						num2 = 14;
						this.o0o0oOo_O.0oo.()[row, 1] = "降序";
					}
					else
					{
						IL_1C2:
						num2 = 16;
						this.o0o0oOo_O.0oo.()[row, 1] = "升序";
					}
					IL_1D8:
					num2 = 17;
					if (this.oOO.o..foxGrid.Cols[i].AllowMerging)
					{
						IL_1F9:
						num2 = 18;
						this.o0o0oOo_O.0oo.().SetCellCheck(i - this.oOO.o..foxGrid.Cols.Fixed + 1, 0, CheckEnum.Checked);
					}
					else
					{
						IL_225:
						num2 = 20;
						this.o0o0oOo_O.0oo.().SetCellCheck(i - this.oOO.o..foxGrid.Cols.Fixed + 1, 0, CheckEnum.Unchecked);
					}
					IL_24F:
					num2 = 21;
				}
				IL_261:
				num2 = 22;
				if (this.oOO.o..MergeMode != MergeModeEnum.Free)
				{
					goto IL_281;
				}
				IL_272:
				num2 = 23;
				this.o0o0oOo_O.0oo.().Checked = true;
				IL_281:
				num2 = 24;
				this.o0o0oOo_O.0oo.().Styles.Normal.Border.Width = 0;
				IL_29F:
				num2 = 25;
				this.o0o0oOo_O.0oo.().Visible = (OO_00oOO.User.Type == UserTypeEnum.Developer);
				IL_2BA:
				goto IL_374;
				IL_2BF:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_335:
				goto IL_369;
				IL_337:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_347:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_337;
			}
			IL_369:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_374:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x00195F14 File Offset: 0x00194114
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x00195F1C File Offset: 0x0019411C
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
				StringBuilder stringBuilder = new StringBuilder();
				IL_0F:
				num2 = 3;
				string str = "Tables(\"" + this.oOO.o..Name + "\")";
				IL_2D:
				num2 = 4;
				this.Ooo.OO0_.();
				IL_35:
				num2 = 5;
				stringBuilder.Append("With " + str);
				IL_4A:
				num2 = 6;
				stringBuilder.Append("\r\n");
				IL_58:
				num2 = 7;
				stringBuilder.Append("    .MergeMode = MergeModeEnum." + Enum.GetName(this.oOO.o..GetType(), this.oOO.o.));
				IL_8B:
				num2 = 8;
				stringBuilder.Append("\r\n");
				IL_99:
				num2 = 9;
				stringBuilder.Append("    .MergeCols.Clear()");
				IL_A8:
				num2 = 10;
				stringBuilder.Append("\r\n");
				IL_B7:
				num2 = 11;
				List<string>.Enumerator enumerator = this.oOO.o..GetEnumerator();
				while (enumerator.MoveNext())
				{
					string str2 = enumerator.Current;
					IL_D2:
					num2 = 12;
					stringBuilder.Append("    .MergeCols.Add(\"" + str2 + "\")");
					IL_ED:
					num2 = 13;
					stringBuilder.Append("\r\n");
					IL_FC:
					num2 = 14;
				}
				IL_108:
				num2 = 15;
				((IDisposable)enumerator).Dispose();
				IL_118:
				num2 = 16;
				stringBuilder.Append("    .MergeSort = \"" + this.oOO.o. + "\"");
				IL_137:
				num2 = 17;
				stringBuilder.Append("\r\n");
				IL_146:
				num2 = 18;
				stringBuilder.Append("    .AllowMerge = True");
				IL_155:
				num2 = 19;
				stringBuilder.Append("\r\n");
				IL_164:
				num2 = 20;
				stringBuilder.Append("End With");
				IL_173:
				num2 = 21;
				o\u3000\u3000\u3002\u3002O o_u3000_u3000_u3002_u3002O = new o\u3000\u3000\u3002\u3002O();
				IL_17D:
				num2 = 22;
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().Text = stringBuilder.ToString();
				IL_192:
				num2 = 23;
				o_u3000_u3000_u3002_u3002O.o00_.o__0oO_.().SelectionStart = 0;
				IL_1A2:
				num2 = 24;
				o_u3000_u3000_u3002_u3002O.ShowDialog();
				IL_1AD:
				goto IL_263;
				IL_1B2:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_224:
				goto IL_258;
				IL_226:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_236:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_226;
			}
			IL_258:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_263:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x001961B0 File Offset: 0x001943B0
		private void <<EMPTY_NAME>>(object A_0, RangeEventArgs A_1)
		{
			this.o0o0oOo_O.0oo.().Col = 1;
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x001961BE File Offset: 0x001943BE
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x04001748 RID: 5960
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001749 RID: 5961
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400174A RID: 5962
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400174B RID: 5963
		[CompilerGenerated]
		private GroupBox <<EMPTY_NAME>>;

		// Token: 0x0400174C RID: 5964
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400174D RID: 5965
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400174E RID: 5966
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400174F RID: 5967
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001750 RID: 5968
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001751 RID: 5969
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001752 RID: 5970
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001753 RID: 5971
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001754 RID: 5972
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04001755 RID: 5973
		private string <<EMPTY_NAME>>;

		// Token: 0x04001756 RID: 5974
		private MergeModeEnum <<EMPTY_NAME>>;
	}
}
