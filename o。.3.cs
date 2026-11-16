using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000474 RID: 1140
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class o\u3002\u3000 : Form
	{
		// Token: 0x06004D7E RID: 19838 RVA: 0x0022EBF0 File Offset: 0x0022CDF0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o_O0_O.O_OOO. != null)
				{
					this.o_O0_O.O_OOO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x0022EC30 File Offset: 0x0022CE30
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o_.O0OO.(new C1ComboBox());
			this.o_o_OO.00__.(new Label());
			this.oO0o00.ooOo.(new Label());
			this.o_.O0OO.(new C1NumericEdit());
			this.Ooo0oo_00OoO.o.(new C1Button());
			this.OOO._0o_oO.(new C1Button());
			this.o_.O0OO.(new CheckedListBox());
			this.o_.O0OO.(new Label());
			this.o_.O0OO.(new ListBox());
			this.Ooo.O_0___O.(new Label());
			this.o_.O0OO.(new C1Button());
			this.oO._00_o0_0.(new C1Button());
			this.oO0o00.ooOo.(new C1Button());
			((ISupportInitialize)this.O_o.oOoOOO_0o.()).BeginInit();
			((ISupportInitialize)this.O_oO_o.O0O.()).BeginInit();
			((ISupportInitialize)this.Oo_o0o._o0.()).BeginInit();
			((ISupportInitialize)this.o_OoO_0O_.o_0.()).BeginInit();
			((ISupportInitialize)this.O0o_.__O.()).BeginInit();
			((ISupportInitialize)this.O0oo.OoO.()).BeginInit();
			((ISupportInitialize)this.O_o.oOoOOO_0o.()).BeginInit();
			base.SuspendLayout();
			this.O_o.oOoOOO_0o.().AllowSpinLoop = false;
			this.O_o.oOoOOO_0o.().Cursor = Cursors.Arrow;
			this.O_o.oOoOOO_0o.().DropDownStyle = DropDownStyle.DropDownList;
			this.O_o.oOoOOO_0o.().GapHeight = 0;
			this.O_o.oOoOOO_0o.().ImagePadding = new Padding(0);
			this.O_o.oOoOOO_0o.().ItemsDisplayMember = "";
			this.O_o.oOoOOO_0o.().ItemsValueMember = "";
			this.O_o.oOoOOO_0o.().Location = new System.Drawing.Point(13, 30);
			this.O_o.oOoOOO_0o.().Name = "cmbTables";
			this.O_o.oOoOOO_0o.().Size = new Size(210, 19);
			this.O_o.oOoOOO_0o.().TabIndex = 0;
			this.O_o.oOoOOO_0o.().Tag = null;
			this.O0oo.OoO.().AutoSize = true;
			this.O0oo.OoO.().Location = new System.Drawing.Point(13, 11);
			this.O0oo.OoO.().Name = "Label1";
			this.O0oo.OoO.().Size = new Size(71, 12);
			this.O0oo.OoO.().TabIndex = 1;
			this.O0oo.OoO.().Text = "选择关联表:";
			this.oO._00_o0_0.().AutoSize = true;
			this.oO._00_o0_0.().Location = new System.Drawing.Point(242, 11);
			this.oO._00_o0_0.().Name = "Label3";
			this.oO._00_o0_0.().Size = new Size(59, 12);
			this.oO._00_o0_0.().TabIndex = 4;
			this.oO._00_o0_0.().Text = "打印行数:";
			this.O_oO_o.O0O.().ImagePadding = new Padding(0);
			this.O_oO_o.O0O.().Location = new System.Drawing.Point(244, 30);
			this.O_oO_o.O0O.().Name = "NumericUpDown1";
			ValueIntervalCollection intervals = this.O_oO_o.O0O.().PostValidation.Intervals;
			ValueInterval[] array = new ValueInterval[1];
			int num = 0;
			int[] array2 = new int[4];
			array2[0] = 1;
			object minValue = new decimal(array2);
			int[] array3 = new int[4];
			array3[0] = 100;
			array[num] = new ValueInterval(minValue, new decimal(array3), true, true);
			intervals.AddRange(array);
			this.O_oO_o.O0O.().Size = new Size(117, 19);
			this.O_oO_o.O0O.().TabIndex = 5;
			this.O_oO_o.O0O.().Tag = null;
			C1TextBox c1TextBox = this.O_oO_o.O0O.();
			int[] array4 = new int[4];
			array4[0] = 5;
			c1TextBox.Value = new decimal(array4);
			this.O_oO_o.O0O.().VisibleButtons = DropDownControlButtonFlags.UpDown;
			this.Oo_o0o._o0.().Location = new System.Drawing.Point(281, 367);
			this.Oo_o0o._o0.().Name = "btnOk";
			this.Oo_o0o._o0.().Size = new Size(75, 23);
			this.Oo_o0o._o0.().TabIndex = 6;
			this.Oo_o0o._o0.().Text = "确定";
			this.Oo_o0o._o0.().UseVisualStyleBackColor = true;
			this.o_OoO_0O_.o_0.().Location = new System.Drawing.Point(362, 367);
			this.o_OoO_0O_.o_0.().Name = "btnCancel";
			this.o_OoO_0O_.o_0.().Size = new Size(75, 23);
			this.o_OoO_0O_.o_0.().TabIndex = 7;
			this.o_OoO_0O_.o_0.().Text = "取消";
			this.o_OoO_0O_.o_0.().UseVisualStyleBackColor = true;
			this.O_oO_o.O0O.().CheckOnClick = true;
			this.O_oO_o.O0O.().FormattingEnabled = true;
			this.O_oO_o.O0O.().Location = new System.Drawing.Point(11, 87);
			this.O_oO_o.O0O.().Name = "lstCols";
			this.O_oO_o.O0O.().Size = new Size(212, 260);
			this.O_oO_o.O0O.().TabIndex = 2;
			this.O0o_.__O.().AutoSize = true;
			this.O0o_.__O.().Location = new System.Drawing.Point(11, 68);
			this.O0o_.__O.().Name = "Label2";
			this.O0o_.__O.().Size = new Size(47, 12);
			this.O0o_.__O.().TabIndex = 3;
			this.O0o_.__O.().Text = "选择列:";
			this.O_oO_o.O0O.().FormattingEnabled = true;
			this.O_oO_o.O0O.().IntegralHeight = false;
			this.O_oO_o.O0O.().ItemHeight = 12;
			this.O_oO_o.O0O.().Location = new System.Drawing.Point(229, 87);
			this.O_oO_o.O0O.().Name = "lstFields";
			this.O_oO_o.O0O.().Size = new Size(208, 260);
			this.O_oO_o.O0O.().TabIndex = 9;
			this.O_oO_o.O0O.().AutoSize = true;
			this.O_oO_o.O0O.().Location = new System.Drawing.Point(229, 68);
			this.O_oO_o.O0O.().Name = "Label4";
			this.O_oO_o.O0O.().Size = new Size(47, 12);
			this.O_oO_o.O0O.().TabIndex = 10;
			this.O_oO_o.O0O.().Text = "已选列:";
			this.O0o_.__O.().Image = a.OO.oO__O00.();
			this.O0o_.__O.().Location = new System.Drawing.Point(443, 87);
			this.O0o_.__O.().Name = "btnUp";
			this.O0o_.__O.().Size = new Size(30, 23);
			this.O0o_.__O.().TabIndex = 11;
			this.O0o_.__O.().UseVisualStyleBackColor = true;
			this.O0oo.OoO.().Image = a.OoOoOOOOOO.0_.();
			this.O0oo.OoO.().Location = new System.Drawing.Point(444, 117);
			this.O0oo.OoO.().Name = "btnDown";
			this.O0oo.OoO.().Size = new Size(30, 23);
			this.O0oo.OoO.().TabIndex = 12;
			this.O0oo.OoO.().UseVisualStyleBackColor = true;
			this.O_o.oOoOOO_0o.().Location = new System.Drawing.Point(379, 29);
			this.O_o.oOoOOO_0o.().Name = "btnSelectall";
			this.O_o.oOoOOO_0o.().Size = new Size(95, 23);
			this.O_o.oOoOOO_0o.().TabIndex = 13;
			this.O_o.oOoOOO_0o.().Text = "选择所有列";
			this.O_o.oOoOOO_0o.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(485, 404);
			base.Controls.Add(this.O_o.oOoOOO_0o.());
			base.Controls.Add(this.O0oo.OoO.());
			base.Controls.Add(this.O0o_.__O.());
			base.Controls.Add(this.O_oO_o.O0O.());
			base.Controls.Add(this.O_oO_o.O0O.());
			base.Controls.Add(this.o_OoO_0O_.o_0.());
			base.Controls.Add(this.Oo_o0o._o0.());
			base.Controls.Add(this.O_oO_o.O0O.());
			base.Controls.Add(this.oO._00_o0_0.());
			base.Controls.Add(this.O0o_.__O.());
			base.Controls.Add(this.O_oO_o.O0O.());
			base.Controls.Add(this.O0oo.OoO.());
			base.Controls.Add(this.O_o.oOoOOO_0o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.1.OO._.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "插入关联表";
			((ISupportInitialize)this.O_o.oOoOOO_0o.()).EndInit();
			((ISupportInitialize)this.O_oO_o.O0O.()).EndInit();
			((ISupportInitialize)this.Oo_o0o._o0.()).EndInit();
			((ISupportInitialize)this.o_OoO_0O_.o_0.()).EndInit();
			((ISupportInitialize)this.O0o_.__O.()).EndInit();
			((ISupportInitialize)this.O0oo.OoO.()).EndInit();
			((ISupportInitialize)this.O_o.oOoOOO_0o.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x0022F4B0 File Offset: 0x0022D6B0
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o0OOoO_O.o0_O.;
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x0022F4B8 File Offset: 0x0022D6B8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.oo_.0__O_Ooo0.);
			C1ComboBox c1ComboBox = this.o0OOoO_O.o0_O.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.o0OOoO_O.o0_O. = A_0;
			c1ComboBox = this.o0OOoO_O.o0_O.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x0022F4FB File Offset: 0x0022D6FB
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0OOoO_O.o0_O.;
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x0022F503 File Offset: 0x0022D703
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0OOoO_O.o0_O. = A_0;
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x0022F50C File Offset: 0x0022D70C
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.O_oo0ooO.;
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x0022F514 File Offset: 0x0022D714
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.O_oo0ooO. = A_0;
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x0022F51D File Offset: 0x0022D71D
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.o_O0_O.O_OOO.;
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x0022F525 File Offset: 0x0022D725
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			this.o_O0_O.O_OOO. = A_0;
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x0022F52E File Offset: 0x0022D72E
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0OOoO_O.o0_O.;
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x0022F538 File Offset: 0x0022D738
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.Oo_O.);
			C1Button c1Button = this.o0OOoO_O.o0_O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0OOoO_O.o0_O. = A_0;
			c1Button = this.o0OOoO_O.o0_O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x0022F57B File Offset: 0x0022D77B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.O_oo0ooO.;
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x0022F584 File Offset: 0x0022D784
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0_.00_O.);
			C1Button c1Button = this.o.O_oo0ooO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.O_oo0ooO. = A_0;
			c1Button = this.o.O_oo0ooO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x0022F5C7 File Offset: 0x0022D7C7
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.o_O0_O.O_OOO.;
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x0022F5D0 File Offset: 0x0022D7D0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			ItemCheckEventHandler value = new ItemCheckEventHandler(this.O_oO_o.O0O.);
			CheckedListBox checkedListBox = this.o_O0_O.O_OOO.;
			if (checkedListBox != null)
			{
				checkedListBox.ItemCheck -= value;
			}
			this.o_O0_O.O_OOO. = A_0;
			checkedListBox = this.o_O0_O.O_OOO.;
			if (checkedListBox != null)
			{
				checkedListBox.ItemCheck += value;
			}
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x0022F613 File Offset: 0x0022D813
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo_0.0.;
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x0022F61B File Offset: 0x0022D81B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo_0.0. = A_0;
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x0022F624 File Offset: 0x0022D824
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.o_O0_O.O_OOO.;
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x0022F62C File Offset: 0x0022D82C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.o_O0_O.O_OOO. = A_0;
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x0022F635 File Offset: 0x0022D835
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOOO00._0Oo0Oo.;
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x0022F63D File Offset: 0x0022D83D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOOO00._0Oo0Oo. = A_0;
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x0022F646 File Offset: 0x0022D846
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo_0.0.;
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x0022F650 File Offset: 0x0022D850
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO.o_o0_.);
			C1Button c1Button = this.oo_0.0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo_0.0. = A_0;
			c1Button = this.oo_0.0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x0022F693 File Offset: 0x0022D893
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOOO00._0Oo0Oo.;
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x0022F69C File Offset: 0x0022D89C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0.O00ooO_.);
			C1Button c1Button = this.oOOO00._0Oo0Oo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOOO00._0Oo0Oo. = A_0;
			c1Button = this.oOOO00._0Oo0Oo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x0022F6DF File Offset: 0x0022D8DF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.__0.;
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x0022F6E8 File Offset: 0x0022D8E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.ooo.O_OOO.);
			C1Button o.__0. = this.O.__0.;
			if (o.__0. != null)
			{
				o.__0..Click -= value;
			}
			this.O.__0. = A_0;
			o.__0. = this.O.__0.;
			if (o.__0. != null)
			{
				o.__0..Click += value;
			}
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x0022F72B File Offset: 0x0022D92B
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x0022F734 File Offset: 0x0022D934
		public o\u3002\u3000(Microsoft.Office.Interop.Word.Application A_0, Table A_1)
		{
			base.Load += this.O0_o.O0o0_.;
			base.FormClosed += this.O_o.oOoOOO_0o.;
			this.O_oO_o.O0O.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o_O0_O.O_OOO. = A_1;
			this.o_O0_O.O_OOO. = A_0;
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x0022F794 File Offset: 0x0022D994
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
				{
					DataRelation dataRelation = (DataRelation)obj;
					if (Operators.CompareString(dataRelation.ParentTable.TableName, this.o_O0_O.O_OOO..Name, true) == 0 && !this.O_o.oOoOOO_0o.().Items.Contains(dataRelation.ChildTable.TableName))
					{
						this.O_o.oOoOOO_0o.().Items.Add(dataRelation.ChildTable.TableName);
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (this.O_o.oOoOOO_0o.().Items.Count > 0)
			{
				this.O_o.oOoOOO_0o.().SelectedIndex = 0;
				return;
			}
			MessageBox.Show("不存在可插入的关联子表!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x0022F878 File Offset: 0x0022DA78
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_oO_o.O0O.().Items.Clear();
			try
			{
				foreach (DataCol dataCol in OO_00oOO.DataTables[this.O_o.oOoOOO_0o.().SelectedItem.ToString()].DataCols)
				{
					this.O_oO_o.O0O.().Items.Add(dataCol.Name);
				}
			}
			finally
			{
				IEnumerator<DataCol> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.O_oO_o.O0O.().SelectedIndex = 0;
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x0022F90C File Offset: 0x0022DB0C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.O_o.oOoOOO_0o.().Text, "", true) > 0 && this.O_oO_o.O0O.().Items.Count > 0)
			{
				this.o_O0_O.O_OOO..Selection.TypeParagraph();
				Tables tables = this.o_O0_O.O_OOO..Selection.Document.Tables;
				Range range = this.o_O0_O.O_OOO..Selection.Range;
				int numRows = Math.Max(2, Conversions.ToInteger(this.O_oO_o.O0O.().Value) + 1);
				int count = this.O_oO_o.O0O.().Items.Count;
				object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
				object objectValue2 = RuntimeHelpers.GetObjectValue(Missing.Value);
				Table table = tables.Add(range, numRows, count, ref objectValue, ref objectValue2);
				table.Borders.Enable = 1;
				table.Borders.OutsideLineWidth = WdLineWidth.wdLineWidth050pt;
				table.Rows[1].Alignment = WdRowAlignment.wdAlignRowCenter;
				string text = this.O_o.oOoOOO_0o.().Text;
				int num = this.O_oO_o.O0O.().Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string text2 = this.O_oO_o.O0O.().Items[i].ToString();
					table.Cell(1, i + 1).Range.Text = text2;
					table.Cell(1, i + 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
					int count2 = table.Rows.Count;
					for (int j = 2; j <= count2; j++)
					{
						table.Cell(j, i + 1).Range.Text = string.Concat(new string[]
						{
							"[@",
							text,
							",",
							text2,
							",",
							Conversions.ToString(j - 1),
							"]"
						});
						if (OO_00oOO.Tables[text].Cols[text2].IsNumeric())
						{
							table.Cell(j, i + 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
						}
						else
						{
							table.Cell(j, i + 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
						}
					}
				}
				base.Close();
				return;
			}
			MessageBox.Show("请选择要打印的关联表和列!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06004D9F RID: 19871 RVA: 0x0022FB60 File Offset: 0x0022DD60
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			bool value = this.O_oO_o.O0O.().CheckedItems.Count != this.O_oO_o.O0O.().Items.Count;
			int num = this.O_oO_o.O0O.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				this.O_oO_o.O0O.().SetItemChecked(i, value);
			}
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x0022FBC4 File Offset: 0x0022DDC4
		private void <<EMPTY_NAME>>(object A_0, ItemCheckEventArgs A_1)
		{
			string text = this.O_oO_o.O0O.().Items[A_1.Index].ToString();
			if (A_1.NewValue == CheckState.Checked)
			{
				if (!this.O_oO_o.O0O.().Items.Contains(text))
				{
					this.O_oO_o.O0O.().Items.Add(text);
					return;
				}
			}
			else if (this.O_oO_o.O0O.().Items.Contains(text))
			{
				this.O_oO_o.O0O.().Items.Remove(text);
			}
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x0022FC40 File Offset: 0x0022DE40
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O_oO_o.O0O.().SelectedIndex > 0)
			{
				string item = this.O_oO_o.O0O.().SelectedItem.ToString();
				int num = this.O_oO_o.O0O.().SelectedIndex - 1;
				this.O_oO_o.O0O.().Items.RemoveAt(this.O_oO_o.O0O.().SelectedIndex);
				this.O_oO_o.O0O.().Items.Insert(num, item);
				this.O_oO_o.O0O.().SelectedIndex = num;
			}
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x0022FCB4 File Offset: 0x0022DEB4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O_oO_o.O0O.().SelectedIndex < this.O_oO_o.O0O.().Items.Count - 1)
			{
				string item = this.O_oO_o.O0O.().SelectedItem.ToString();
				int num = this.O_oO_o.O0O.().SelectedIndex + 1;
				this.O_oO_o.O0O.().Items.RemoveAt(this.O_oO_o.O0O.().SelectedIndex);
				this.O_oO_o.O0O.().Items.Insert(num, item);
				this.O_oO_o.O0O.().SelectedIndex = num;
			}
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x0022FD38 File Offset: 0x0022DF38
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001FA5 RID: 8101
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001FA6 RID: 8102
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001FA7 RID: 8103
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001FA8 RID: 8104
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001FA9 RID: 8105
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x04001FAA RID: 8106
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FAB RID: 8107
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FAC RID: 8108
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x04001FAD RID: 8109
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001FAE RID: 8110
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x04001FAF RID: 8111
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001FB0 RID: 8112
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FB1 RID: 8113
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FB2 RID: 8114
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001FB3 RID: 8115
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001FB4 RID: 8116
		private Microsoft.Office.Interop.Word.Application <<EMPTY_NAME>>;
	}
}
