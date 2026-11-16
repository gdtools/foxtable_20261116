using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000372 RID: 882
	[DesignerGenerated]
	internal partial class O\u3000_\u3000 : Form
	{
		// Token: 0x06003859 RID: 14425 RVA: 0x001912BC File Offset: 0x0018F4BC
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_0.ooO0O. != null)
				{
					this.O_0.ooO0O..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x001912FC File Offset: 0x0018F4FC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Ooo0.O.(new CheckedListBox());
			this.o_00oo00.O00.(new Label());
			this.Ooo0.O.(new C1CheckBox());
			this.Ooo0.O.(new C1Button());
			this.Oo0o0OO.00OO0.(new C1Button());
			this.o._0o.(new Label());
			this.o_00oo00.O00.(new RadioButton());
			this.Ooo0.O.(new RadioButton());
			this.o._0o.(new C1TextBox());
			((ISupportInitialize)this.O0oO._Ooo_.()).BeginInit();
			((ISupportInitialize)this.O0oO._Ooo_.()).BeginInit();
			((ISupportInitialize)this.o0.0_O.()).BeginInit();
			((ISupportInitialize)this.Ooo0.O.()).BeginInit();
			base.SuspendLayout();
			this.O0oO._Ooo_.().CheckOnClick = true;
			this.O0oO._Ooo_.().FormattingEnabled = true;
			this.O0oO._Ooo_.().Location = new Point(16, 102);
			this.O0oO._Ooo_.().Margin = new Padding(4, 4, 4, 4);
			this.O0oO._Ooo_.().Name = "CheckedListBox1";
			this.O0oO._Ooo_.().Size = new Size(416, 224);
			this.O0oO._Ooo_.().TabIndex = 4;
			this.Ooo0.O.().AutoSize = true;
			this.Ooo0.O.().Location = new Point(16, 75);
			this.Ooo0.O.().Margin = new Padding(4, 0, 4, 0);
			this.Ooo0.O.().Name = "Label1";
			this.Ooo0.O.().Size = new Size(180, 15);
			this.Ooo0.O.().TabIndex = 3;
			this.Ooo0.O.().Text = "根据以下列内容调整高度:";
			this.O0oO._Ooo_.().AutoSize = true;
			this.O0oO._Ooo_.().BorderStyle = BorderStyle.None;
			this.O0oO._Ooo_.().Checked = true;
			this.O0oO._Ooo_.().CheckState = CheckState.Checked;
			this.O0oO._Ooo_.().Location = new Point(16, 335);
			this.O0oO._Ooo_.().Margin = new Padding(4, 4, 4, 4);
			this.O0oO._Ooo_.().Name = "chkSameHeight";
			this.O0oO._Ooo_.().Size = new Size(89, 19);
			this.O0oO._Ooo_.().TabIndex = 5;
			this.O0oO._Ooo_.().Text = "相等行高";
			this.O0oO._Ooo_.().UseVisualStyleBackColor = true;
			this.O0oO._Ooo_.().Value = true;
			this.O0oO._Ooo_.().DialogResult = DialogResult.OK;
			this.O0oO._Ooo_.().Location = new Point(121, 400);
			this.O0oO._Ooo_.().Margin = new Padding(4, 4, 4, 4);
			this.O0oO._Ooo_.().Name = "btnOK";
			this.O0oO._Ooo_.().Size = new Size(100, 29);
			this.O0oO._Ooo_.().TabIndex = 7;
			this.O0oO._Ooo_.().Text = "确定";
			this.O0oO._Ooo_.().UseVisualStyleBackColor = true;
			this.o0.0_O.().DialogResult = DialogResult.Cancel;
			this.o0.0_O.().Location = new Point(229, 400);
			this.o0.0_O.().Margin = new Padding(4, 4, 4, 4);
			this.o0.0_O.().Name = "Button2";
			this.o0.0_O.().Size = new Size(100, 29);
			this.o0.0_O.().TabIndex = 8;
			this.o0.0_O.().Text = "取消";
			this.o0.0_O.().UseVisualStyleBackColor = true;
			this.Oo0o0OO.00OO0.().AutoSize = true;
			this.Oo0o0OO.00OO0.().Location = new Point(16, 359);
			this.Oo0o0OO.00OO0.().Margin = new Padding(4, 0, 4, 0);
			this.Oo0o0OO.00OO0.().Name = "Label2";
			this.Oo0o0OO.00OO0.().Size = new Size(397, 15);
			this.Oo0o0OO.00OO0.().TabIndex = 6;
			this.Oo0o0OO.00OO0.().Text = "提示：如果未选择特定列，将根据所有列的内容调整行高。";
			this.Ooo0.O.().AutoSize = true;
			this.Ooo0.O.().Checked = true;
			this.Ooo0.O.().Location = new Point(16, 18);
			this.Ooo0.O.().Margin = new Padding(4, 4, 4, 4);
			this.Ooo0.O.().Name = "EnterRowHeight";
			this.Ooo0.O.().Size = new Size(88, 19);
			this.Ooo0.O.().TabIndex = 0;
			this.Ooo0.O.().TabStop = true;
			this.Ooo0.O.().Text = "指定行高";
			this.Ooo0.O.().UseVisualStyleBackColor = true;
			this.o0.0_O.().AutoSize = true;
			this.o0.0_O.().Location = new Point(16, 49);
			this.o0.0_O.().Margin = new Padding(4, 4, 4, 4);
			this.o0.0_O.().Name = "AutoRowHeight";
			this.o0.0_O.().Size = new Size(118, 19);
			this.o0.0_O.().TabIndex = 2;
			this.o0.0_O.().Text = "自动调整行高";
			this.o0.0_O.().UseVisualStyleBackColor = true;
			this.Ooo0.O.().DataType = typeof(int);
			this.Ooo0.O.().Location = new Point(121, 15);
			this.Ooo0.O.().Margin = new Padding(4, 4, 4, 4);
			this.Ooo0.O.().Name = "txtRowHeight";
			this.Ooo0.O.().Size = new Size(133, 23);
			this.Ooo0.O.().TabIndex = 1;
			this.Ooo0.O.().Tag = null;
			base.AutoScaleDimensions = new SizeF(8f, 15f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(451, 445);
			base.Controls.Add(this.Ooo0.O.());
			base.Controls.Add(this.o0.0_O.());
			base.Controls.Add(this.Ooo0.O.());
			base.Controls.Add(this.Oo0o0OO.00OO0.());
			base.Controls.Add(this.o0.0_O.());
			base.Controls.Add(this.O0oO._Ooo_.());
			base.Controls.Add(this.O0oO._Ooo_.());
			base.Controls.Add(this.Ooo0.O.());
			base.Controls.Add(this.O0oO._Ooo_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(4, 4, 4, 4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Oll.lo.1.";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "行高";
			((ISupportInitialize)this.O0oO._Ooo_.()).EndInit();
			((ISupportInitialize)this.O0oO._Ooo_.()).EndInit();
			((ISupportInitialize)this.o0.0_O.()).EndInit();
			((ISupportInitialize)this.Ooo0.O.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x001919A5 File Offset: 0x0018FBA5
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.o._0o.;
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x001919B0 File Offset: 0x0018FBB0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			ItemCheckEventHandler value = new ItemCheckEventHandler(this.O0oO._Ooo_.);
			CheckedListBox checkedListBox = this.o._0o.;
			if (checkedListBox != null)
			{
				checkedListBox.ItemCheck -= value;
			}
			this.o._0o. = A_0;
			checkedListBox = this.o._0o.;
			if (checkedListBox != null)
			{
				checkedListBox.ItemCheck += value;
			}
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x001919F3 File Offset: 0x0018FBF3
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_0.ooO0O.;
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x001919FB File Offset: 0x0018FBFB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_0.ooO0O. = A_0;
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x00191A04 File Offset: 0x0018FC04
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o._0o.;
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x00191A0C File Offset: 0x0018FC0C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o._0o. = A_0;
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x00191A15 File Offset: 0x0018FC15
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o._0o.;
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x00191A20 File Offset: 0x0018FC20
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0oO._Ooo_.);
			C1Button c1Button = this.o._0o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o._0o. = A_0;
			c1Button = this.o._0o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x00191A63 File Offset: 0x0018FC63
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_00oo00.O00.;
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x00191A6B File Offset: 0x0018FC6B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o_00oo00.O00. = A_0;
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x00191A74 File Offset: 0x0018FC74
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_o00.o0O0o.;
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x00191A7C File Offset: 0x0018FC7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_o00.o0O0o. = A_0;
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x00191A85 File Offset: 0x0018FC85
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o._0o.;
		}

		// Token: 0x06003868 RID: 14440 RVA: 0x00191A8D File Offset: 0x0018FC8D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.o._0o. = A_0;
		}

		// Token: 0x06003869 RID: 14441 RVA: 0x00191A96 File Offset: 0x0018FC96
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o_00oo00.O00.;
		}

		// Token: 0x0600386A RID: 14442 RVA: 0x00191A9E File Offset: 0x0018FC9E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.o_00oo00.O00. = A_0;
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x00191AA7 File Offset: 0x0018FCA7
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_0.ooO0O.;
		}

		// Token: 0x0600386C RID: 14444 RVA: 0x00191AAF File Offset: 0x0018FCAF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O_0.ooO0O. = A_0;
		}

		// Token: 0x0600386D RID: 14445 RVA: 0x00191AB8 File Offset: 0x0018FCB8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int @fixed = this.O_0.ooO0O..Cols.Fixed;
			int num = this.O_0.ooO0O..Cols.Count - 1;
			for (int i = @fixed; i <= num; i++)
			{
				this.O0oO._Ooo_.().Items.Add(this.O_0.ooO0O..Cols[i].Name);
			}
			this.Ooo0.O.().Value = this.O_0.ooO0O..Rows.DefaultSize.ToString();
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x00191B40 File Offset: 0x0018FD40
		public O\u3000_\u3000(Table A_0)
		{
			base.Load += this.o0.0_O.;
			base.FormClosed += this.O0oO._Ooo_.;
			this.Ooo0.O.();
			this.O_0.ooO0O. = A_0;
			this.O_0.ooO0O. = A_0.foxGrid;
			this.O0oO._Ooo_.().Checked = !A_0.AllowResizeSingleRow;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x00191BBC File Offset: 0x0018FDBC
		private void <<EMPTY_NAME>>(object A_0, ItemCheckEventArgs A_1)
		{
			if (A_1.NewValue == CheckState.Checked)
			{
				int num = this.O0oO._Ooo_.().Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (i != A_1.Index)
					{
						this.O0oO._Ooo_.().SetItemChecked(i, false);
					}
				}
			}
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x00191C08 File Offset: 0x0018FE08
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!this.o0.0_O.().Checked)
				{
					goto IL_1D7;
				}
				IL_19:
				num2 = 3;
				int num3 = this.O0oO._Ooo_.().Items.Count - 1;
				int index;
				for (int i = 0; i <= num3; i++)
				{
					IL_34:
					num2 = 4;
					if (this.O0oO._Ooo_.().GetItemChecked(i))
					{
						IL_45:
						num2 = 5;
						index = this.O_0.ooO0O..Cols[this.O0oO._Ooo_.().Items[i].ToString()].Index;
					}
					IL_74:
					num2 = 6;
				}
				IL_82:
				num2 = 7;
				C1FlexGrid c1FlexGrid = this.O_0.ooO0O.;
				IL_8C:
				num2 = 8;
				c1FlexGrid.BeginUpdate();
				IL_95:
				num2 = 9;
				c1FlexGrid.Rows.DefaultSize = c1FlexGrid.Font.Height + 4;
				IL_B2:
				num2 = 10;
				if (index <= 0)
				{
					goto IL_12B;
				}
				IL_B9:
				num2 = 11;
				if (!this.O0oO._Ooo_.().Checked)
				{
					goto IL_FA;
				}
				IL_C9:
				num2 = 12;
				this.O_0.ooO0O..AutoSizeRows(c1FlexGrid.Rows.Fixed, index, c1FlexGrid.Rows.Count - 1, index, 2, AutoSizeFlags.SameSize | AutoSizeFlags.IgnoreHidden | AutoSizeFlags.IgnoreMerged);
				goto IL_1C5;
				IL_FA:
				num2 = 14;
				this.O_0.ooO0O..AutoSizeRows(c1FlexGrid.Rows.Fixed, index, c1FlexGrid.Rows.Count - 1, index, 2, AutoSizeFlags.IgnoreHidden | AutoSizeFlags.IgnoreMerged);
				goto IL_1C5;
				IL_12B:
				num2 = 16;
				if (!this.O0oO._Ooo_.().Checked)
				{
					goto IL_181;
				}
				IL_13B:
				num2 = 17;
				this.O_0.ooO0O..AutoSizeRows(c1FlexGrid.Rows.Fixed, c1FlexGrid.Cols.Fixed, c1FlexGrid.Rows.Count - 1, c1FlexGrid.Cols.Count - 1, 2, AutoSizeFlags.SameSize | AutoSizeFlags.IgnoreHidden | AutoSizeFlags.IgnoreMerged);
				goto IL_1C5;
				IL_181:
				num2 = 19;
				this.O_0.ooO0O..AutoSizeRows(c1FlexGrid.Rows.Fixed, c1FlexGrid.Cols.Fixed, c1FlexGrid.Rows.Count - 1, c1FlexGrid.Cols.Count - 1, 2, AutoSizeFlags.IgnoreHidden | AutoSizeFlags.IgnoreMerged);
				IL_1C5:
				num2 = 20;
				c1FlexGrid.EndUpdate();
				IL_1CF:
				c1FlexGrid = null;
				goto IL_34E;
				IL_1D7:
				num2 = 23;
				if ((int)Math.Round(Conversion.Val(this.Ooo0.O.().Text)) <= 0)
				{
					goto IL_34E;
				}
				IL_1F6:
				num2 = 24;
				if (this.O_0.ooO0O..Rows.Fixed >= this.O_0.ooO0O..Rows.Count)
				{
					goto IL_26E;
				}
				IL_21B:
				num2 = 25;
				this.O_0.ooO0O..O_o0OOo_.o0..O__00.__0_O.(new o_o0_(this.O_0.ooO0O., this.O_0.ooO0O..Rows.Fixed, this.O_0.ooO0O..Rows[this.O_0.ooO0O..Rows.Fixed].Height));
				IL_26E:
				num2 = 26;
				C1FlexGrid c1FlexGrid2 = this.O_0.ooO0O.;
				IL_279:
				num2 = 27;
				c1FlexGrid2.BeginUpdate();
				IL_283:
				num2 = 28;
				int num4 = c1FlexGrid2.Rows.Fixed - 1;
				for (int j = 0; j <= num4; j++)
				{
					IL_29B:
					num2 = 29;
					c1FlexGrid2.Rows[j].Height = c1FlexGrid2.Rows[j].HeightDisplay;
					IL_2C4:
					num2 = 30;
				}
				IL_2D3:
				num2 = 31;
				c1FlexGrid2.Rows.DefaultSize = (int)Math.Round(Conversion.Val(this.Ooo0.O.().Text));
				IL_2F8:
				num2 = 32;
				int @fixed = c1FlexGrid2.Rows.Fixed;
				int num5 = c1FlexGrid2.Rows.Count - 1;
				for (int k = @fixed; k <= num5; k++)
				{
					IL_31B:
					num2 = 33;
					c1FlexGrid2.Rows[k].Height = -1;
					IL_332:
					num2 = 34;
				}
				IL_341:
				num2 = 35;
				c1FlexGrid2.EndUpdate();
				IL_34B:
				c1FlexGrid2 = null;
				IL_34E:
				goto IL_434;
				IL_353:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_3F5:
				goto IL_429;
				IL_3F7:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_407:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3F7;
			}
			IL_429:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_434:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x00192070 File Offset: 0x00190270
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400170D RID: 5901
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400170E RID: 5902
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x0400170F RID: 5903
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001710 RID: 5904
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001711 RID: 5905
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001712 RID: 5906
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001713 RID: 5907
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001714 RID: 5908
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001715 RID: 5909
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001716 RID: 5910
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001717 RID: 5911
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001718 RID: 5912
		private Table <<EMPTY_NAME>>;
	}
}
