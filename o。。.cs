using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000343 RID: 835
	[DesignerGenerated]
	internal partial class o\u3002\u3002\u3000 : Form
	{
		// Token: 0x060032E4 RID: 13028 RVA: 0x0015B984 File Offset: 0x00159B84
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_oO.o__0o0. != null)
				{
					this.O_oO.o__0o0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x0015B9C4 File Offset: 0x00159BC4
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0.oO_o00.(new C1TextBox());
			this.oOO0o_oo._oo.(new RadioButton());
			this.Oo_O0._.(new RadioButton());
			this.oo_.Oo_o_.(new RadioButton());
			this.o0.oO_o00.(new C1FlexGrid());
			this.oOO0_00.O_O00O.(new C1Button());
			this.oOO0o_oo._oo.(new C1Button());
			this.o0.oO_o00.(new OpenFileDialog());
			this.o0.oO_o00.(new C1CheckBox());
			this.Oo_O0._.(new C1Button());
			((ISupportInitialize)this.Oo_O0._.()).BeginInit();
			base.SuspendLayout();
			this.Oo_O0._.().AcceptsReturn = true;
			this.Oo_O0._.().Location = new Point(127, 346);
			this.Oo_O0._.().Name = "txtSeparator";
			this.Oo_O0._.().ReadOnly = true;
			this.Oo_O0._.().Size = new Size(100, 21);
			this.Oo_O0._.().TabIndex = 5;
			this.Oo_O0._.().Value = ",";
			this.Ooo.o_O.().AutoSize = true;
			this.Ooo.o_O.().Location = new Point(14, 348);
			this.Ooo.o_O.().Name = "Custom";
			this.Ooo.o_O.().Size = new Size(107, 16);
			this.Ooo.o_O.().TabIndex = 4;
			this.Ooo.o_O.().TabStop = true;
			this.Ooo.o_O.().Text = "自定义列分隔符";
			this.Ooo.o_O.().UseVisualStyleBackColor = true;
			this.o._o0_.().AutoSize = true;
			this.o._o0_.().Location = new Point(133, 316);
			this.o._o0_.().Name = "Comma";
			this.o._o0_.().Size = new Size(95, 16);
			this.o._o0_.().TabIndex = 2;
			this.o._o0_.().Text = "用逗号分割列";
			this.o._o0_.().UseVisualStyleBackColor = true;
			this.oOO0o_oo._oo.().AutoSize = true;
			this.oOO0o_oo._oo.().Checked = true;
			this.oOO0o_oo._oo.().Location = new Point(14, 317);
			this.oOO0o_oo._oo.().Name = "Tab";
			this.oOO0o_oo._oo.().Size = new Size(101, 16);
			this.oOO0o_oo._oo.().TabIndex = 1;
			this.oOO0o_oo._oo.().TabStop = true;
			this.oOO0o_oo._oo.().Text = "用Tab符分隔列";
			this.oOO0o_oo._oo.().UseVisualStyleBackColor = true;
			this.Oo_O0._.().AllowDragging = AllowDraggingEnum.None;
			this.Oo_O0._.().AllowEditing = false;
			this.Oo_O0._.().AllowSorting = AllowSortingEnum.None;
			this.Oo_O0._.().ColumnInfo = "10,1,0,25,0,0,Columns:";
			this.Oo_O0._.().Location = new Point(14, 14);
			this.Oo_O0._.().Name = "Grid";
			this.Oo_O0._.().Rows.DefaultSize = 20;
			this.Oo_O0._.().SelectionMode = SelectionModeEnum.ColumnRange;
			this.Oo_O0._.().Size = new Size(597, 287);
			this.Oo_O0._.().TabIndex = 0;
			this.o0._0o.().Location = new Point(455, 382);
			this.o0._0o.().Name = "Button1";
			this.o0._0o.().Size = new Size(75, 23);
			this.o0._0o.().TabIndex = 7;
			this.o0._0o.().Text = "确定";
			this.o0._0o.().UseVisualStyleBackColor = true;
			this.o._o0_.().DialogResult = DialogResult.OK;
			this.o._o0_.().Location = new Point(536, 382);
			this.o._o0_.().Name = "Button2";
			this.o._o0_.().Size = new Size(75, 23);
			this.o._o0_.().TabIndex = 8;
			this.o._o0_.().Text = "取消";
			this.o._o0_.().UseVisualStyleBackColor = true;
			this.o._o0_.().Filter = "Text文件(*.txt)|*.txt";
			this.o._o0_.().AutoSize = true;
			this.o._o0_.().Checked = true;
			this.o._o0_.().CheckState = CheckState.Checked;
			this.o._o0_.().Location = new Point(527, 317);
			this.o._o0_.().Name = "FirstRowIsFixed";
			this.o._o0_.().Size = new Size(84, 16);
			this.o._o0_.().TabIndex = 3;
			this.o._o0_.().Text = "首行为标题";
			this.o._o0_.().UseVisualStyleBackColor = true;
			this.Ooo.o_O.().Location = new Point(14, 382);
			this.Ooo.o_O.().Name = "Button3";
			this.Ooo.o_O.().Size = new Size(75, 23);
			this.Ooo.o_O.().TabIndex = 6;
			this.Ooo.o_O.().Text = "删除列";
			this.Ooo.o_O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(623, 417);
			base.Controls.Add(this.Ooo.o_O.());
			base.Controls.Add(this.o._o0_.());
			base.Controls.Add(this.o._o0_.());
			base.Controls.Add(this.o0._0o.());
			base.Controls.Add(this.Oo_O0._.());
			base.Controls.Add(this.Oo_O0._.());
			base.Controls.Add(this.Ooo.o_O.());
			base.Controls.Add(this.o._o0_.());
			base.Controls.Add(this.oOO0o_oo._oo.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o0.0.O..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "导入";
			((ISupportInitialize)this.Oo_O0._.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x0015BFC6 File Offset: 0x0015A1C6
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_oO.o__0o0.;
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x0015BFD0 File Offset: 0x0015A1D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			EventHandler value = new EventHandler(this.o.ooo_.);
			C1TextBox o_oO.o__0o0. = this.O_oO.o__0o0.;
			if (o_oO.o__0o0. != null)
			{
				o_oO.o__0o0..TextChanged -= value;
			}
			this.O_oO.o__0o0. = A_0;
			o_oO.o__0o0. = this.O_oO.o__0o0.;
			if (o_oO.o__0o0. != null)
			{
				o_oO.o__0o0..TextChanged += value;
			}
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x0015C013 File Offset: 0x0015A213
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O_oO.o__0o0.;
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x0015C01C File Offset: 0x0015A21C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.O000oo00oOo0.0.);
			RadioButton o_oO.o__0o0. = this.O_oO.o__0o0.;
			if (o_oO.o__0o0. != null)
			{
				o_oO.o__0o0..CheckedChanged -= value;
			}
			this.O_oO.o__0o0. = A_0;
			o_oO.o__0o0. = this.O_oO.o__0o0.;
			if (o_oO.o__0o0. != null)
			{
				o_oO.o__0o0..CheckedChanged += value;
			}
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x0015C05F File Offset: 0x0015A25F
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O.OOo_0oO__.;
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x0015C068 File Offset: 0x0015A268
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.O000oo00oOo0.0.);
			RadioButton o.OOo_0oO__. = this.O.OOo_0oO__.;
			if (o.OOo_0oO__. != null)
			{
				o.OOo_0oO__..CheckedChanged -= value;
			}
			this.O.OOo_0oO__. = A_0;
			o.OOo_0oO__. = this.O.OOo_0oO__.;
			if (o.OOo_0oO__. != null)
			{
				o.OOo_0oO__..CheckedChanged += value;
			}
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x0015C0AB File Offset: 0x0015A2AB
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.OOoo_OO0oO.0o.;
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x0015C0B4 File Offset: 0x0015A2B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.O000oo00oOo0.0.);
			RadioButton oooo_OO0oO.0o. = this.OOoo_OO0oO.0o.;
			if (oooo_OO0oO.0o. != null)
			{
				oooo_OO0oO.0o..CheckedChanged -= value;
			}
			this.OOoo_OO0oO.0o. = A_0;
			oooo_OO0oO.0o. = this.OOoo_OO0oO.0o.;
			if (oooo_OO0oO.0o. != null)
			{
				oooo_OO0oO.0o..CheckedChanged += value;
			}
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x0015C0F7 File Offset: 0x0015A2F7
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O_oO.o__0o0.;
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x0015C0FF File Offset: 0x0015A2FF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.O_oO.o__0o0. = A_0;
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x0015C108 File Offset: 0x0015A308
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0.oO_o00.;
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x0015C110 File Offset: 0x0015A310
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O__.oOO.);
			C1Button c1Button = this.o0.oO_o00.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0.oO_o00. = A_0;
			c1Button = this.o0.oO_o00.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x0015C153 File Offset: 0x0015A353
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo_.Oo_o_.;
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x0015C15B File Offset: 0x0015A35B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oo_.Oo_o_. = A_0;
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x0015C164 File Offset: 0x0015A364
		[CompilerGenerated]
		internal virtual OpenFileDialog <<EMPTY_NAME>>()
		{
			return this.O_oO.o__0o0.;
		}

		// Token: 0x060032F5 RID: 13045 RVA: 0x0015C16C File Offset: 0x0015A36C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(OpenFileDialog A_0)
		{
			this.O_oO.o__0o0. = A_0;
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x0015C175 File Offset: 0x0015A375
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O_oO.o__0o0.;
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x0015C180 File Offset: 0x0015A380
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.O000oo00oOo0.0.);
			C1CheckBox o_oO.o__0o0. = this.O_oO.o__0o0.;
			if (o_oO.o__0o0. != null)
			{
				o_oO.o__0o0..CheckedChanged -= value;
			}
			this.O_oO.o__0o0. = A_0;
			o_oO.o__0o0. = this.O_oO.o__0o0.;
			if (o_oO.o__0o0. != null)
			{
				o_oO.o__0o0..CheckedChanged += value;
			}
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x0015C1C3 File Offset: 0x0015A3C3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.ooo_.;
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x0015C1CC File Offset: 0x0015A3CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOOO0oo000.00o.);
			C1Button c1Button = this.o.ooo_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.ooo_. = A_0;
			c1Button = this.o.ooo_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060032FA RID: 13050 RVA: 0x0015C20F File Offset: 0x0015A40F
		public o\u3002\u3002\u3000()
		{
			base.FormClosed += this.o._o0_.;
			this.Oo_O0._.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x0015C244 File Offset: 0x0015A444
		internal void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.O_oO.o__0o0., "", true) != 0)
			{
				this.Oo_O0._.().AutoResize = true;
				this.Oo_O0._.().Rows.Count = 1;
				this.Oo_O0._.().Cols.Count = 1;
				this.Oo_O0._.().Clear(ClearFlags.All);
				if (this.oOO0o_oo._oo.().Checked)
				{
					if (this.o._o0_.().Checked)
					{
						this.Oo_O0._.().LoadGrid(this.O_oO.o__0o0., FileFormatEnum.TextTab, FileFlags.IncludeFixedCells, Encoding.Default);
						this.Oo_O0._.().Cols.Insert(0);
					}
					else
					{
						this.Oo_O0._.().LoadGrid(this.O_oO.o__0o0., FileFormatEnum.TextTab, FileFlags.None, Encoding.Default);
					}
				}
				else if (this.o._o0_.().Checked)
				{
					if (this.o._o0_.().Checked)
					{
						this.Oo_O0._.().LoadGrid(this.O_oO.o__0o0., FileFormatEnum.TextComma, FileFlags.IncludeFixedCells, Encoding.Default);
						this.Oo_O0._.().Cols.Insert(0);
					}
					else
					{
						this.Oo_O0._.().LoadGrid(this.O_oO.o__0o0., FileFormatEnum.TextComma, FileFlags.None, Encoding.Default);
					}
				}
				else if (Operators.CompareString(this.Oo_O0._.().Text, "", true) > 0)
				{
					this.Oo_O0._.().ClipSeparators = Conversions.ToString(this.Oo_O0._.().Text.ToCharArray()[0]) + "\r";
					if (this.o._o0_.().Checked)
					{
						this.Oo_O0._.().LoadGrid(this.O_oO.o__0o0., FileFormatEnum.TextCustom, FileFlags.IncludeFixedCells, Encoding.Default);
						this.Oo_O0._.().Cols.Insert(0);
					}
					else
					{
						this.Oo_O0._.().LoadGrid(this.O_oO.o__0o0., FileFormatEnum.TextCustom, FileFlags.None, Encoding.Default);
					}
				}
				for (int i = this.Oo_O0._.().Cols.Count - 1; i >= 1; i += -1)
				{
					string text = "";
					if (this.Oo_O0._.()[0, i] != null)
					{
						text = this.Oo_O0._.()[0, i].ToString();
					}
					if (o_O_o_oOoo__.oO.O_..Contains(text))
					{
						this.Oo_O0._.().Cols.Remove(i);
					}
					else
					{
						if (Operators.CompareString(text, "", true) == 0 || !o_O_o_oOoo__.O_o_._o0.(text, true))
						{
							int num = 1;
							while (this.o._o0_.("第" + Conversions.ToString(num) + "列", i))
							{
								num++;
							}
							this.Oo_O0._.()[0, i] = "第" + Conversions.ToString(num) + "列";
							text = "第" + Conversions.ToString(num) + "列";
						}
						this.Oo_O0._.().Cols[i].Name = text;
					}
				}
				this.Oo_O0._.().AutoSizeCols();
				this.Oo_O0._.().Cols[0].Width = 23;
			}
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x0015C528 File Offset: 0x0015A728
		private bool <<EMPTY_NAME>>(string A_0, int A_1)
		{
			int num = this.Oo_O0._.().Cols.Count - 1;
			for (int i = 1; i <= num; i++)
			{
				if (i != A_1 && this.Oo_O0._.()[0, i] != null && Operators.CompareString(this.Oo_O0._.()[0, i].ToString(), A_0, true) == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x0015C589 File Offset: 0x0015A789
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oOO0_00.O_O00O.();
			this.Oo_O0._.().ReadOnly = !this.Ooo.o_O.().Checked;
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x0015C5AA File Offset: 0x0015A7AA
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Oo_O0._.().Text.Length > 0)
			{
				this.oOO0_00.O_O00O.();
			}
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x0015C5C8 File Offset: 0x0015A7C8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Oo_O0._.().Col >= this.Oo_O0._.().Cols.Fixed)
			{
				int leftCol = this.Oo_O0._.().Selection.LeftCol;
				int rightCol = this.Oo_O0._.().Selection.RightCol;
				int num = leftCol;
				int num2 = rightCol;
				for (int i = num; i <= num2; i++)
				{
					this.Oo_O0._.().Cols.Remove(leftCol);
				}
			}
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x0015C640 File Offset: 0x0015A840
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				if (Oo00.O____0O._0.(this.Oo_O0._.(), Path.GetFileNameWithoutExtension(this.O_oO.o__0o0.)))
				{
					base.DialogResult = DialogResult.OK;
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x0015C6BC File Offset: 0x0015A8BC
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001468 RID: 5224
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001469 RID: 5225
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400146A RID: 5226
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400146B RID: 5227
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400146C RID: 5228
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400146D RID: 5229
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x0400146E RID: 5230
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400146F RID: 5231
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001470 RID: 5232
		[CompilerGenerated]
		private OpenFileDialog <<EMPTY_NAME>>;

		// Token: 0x04001471 RID: 5233
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001472 RID: 5234
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001473 RID: 5235
		internal string <<EMPTY_NAME>>;
	}
}
