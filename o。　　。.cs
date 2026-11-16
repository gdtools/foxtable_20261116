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
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000384 RID: 900
	[DesignerGenerated]
	internal partial class o\u3002\u3000\u3000\u3002\u3000\u3000\u3000 : Form
	{
		// Token: 0x06003A19 RID: 14873 RVA: 0x001A072F File Offset: 0x0019E92F
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.O_.O0. != null)
			{
				this.O_.O0..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x001A0750 File Offset: 0x0019E950
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oo0O_O0.OOO_oO.(new C1ComboBox());
			this.O_O00__.0oo0.(new Label());
			this.OO_.o.(new C1TextBox());
			this.O0o.0O0__0___0.(new Label());
			this.oo0O_O0.OOO_oO.(new C1Button());
			this.OO_O_0._O0O_oo.(new C1Button());
			this.O_00_.oOOo.(new Label());
			this.OO_.o.(new C1NumericEdit());
			this.O0o_O00_0oOo.O.(new Label());
			this.OO_.o.(new Label());
			this.O_O00__.0oo0.(new C1TextBox());
			this.o_o.0o0__.(new Label());
			this.o0_ooo.__O.(new Label());
			((ISupportInitialize)this.o0_0oo0.OOo0oo.()).BeginInit();
			((ISupportInitialize)this.OO_O_0._O0O_oo.()).BeginInit();
			((ISupportInitialize)this.o0_0oo0.OOo0oo.()).BeginInit();
			((ISupportInitialize)this.Oo_0o.ooOoo00O.()).BeginInit();
			((ISupportInitialize)this.oo0O_O0.OOO_oO.()).BeginInit();
			((ISupportInitialize)this.oo0O_O0.OOO_oO.()).BeginInit();
			base.SuspendLayout();
			this.o0_0oo0.OOo0oo.().AllowSpinLoop = false;
			this.o0_0oo0.OOo0oo.().Cursor = Cursors.Arrow;
			this.o0_0oo0.OOo0oo.().DropDownStyle = DropDownStyle.DropDownList;
			this.o0_0oo0.OOo0oo.().GapHeight = 0;
			this.o0_0oo0.OOo0oo.().ImagePadding = new Padding(0, 0, 0, 0);
			this.o0_0oo0.OOo0oo.().ItemsDisplayMember = "";
			this.o0_0oo0.OOo0oo.().ItemsValueMember = "";
			this.o0_0oo0.OOo0oo.().Location = new Point(84, 148);
			this.o0_0oo0.OOo0oo.().Margin = new Padding(4, 4, 4, 4);
			this.o0_0oo0.OOo0oo.().Name = "cmbDataType";
			this.o0_0oo0.OOo0oo.().Size = new Size(194, 26);
			this.o0_0oo0.OOo0oo.().TabIndex = 2;
			this.o0_0oo0.OOo0oo.().Tag = null;
			this.O.0_0.().AutoSize = true;
			this.O.0_0.().Location = new Point(18, 154);
			this.O.0_0.().Margin = new Padding(4, 0, 4, 0);
			this.O.0_0.().Name = "Label2";
			this.O.0_0.().Size = new Size(53, 18);
			this.O.0_0.().TabIndex = 11;
			this.O.0_0.().Text = "类型:";
			this.OO_O_0._O0O_oo.().Location = new Point(84, 18);
			this.OO_O_0._O0O_oo.().Margin = new Padding(4, 4, 4, 4);
			this.OO_O_0._O0O_oo.().Name = "txtName";
			this.OO_O_0._O0O_oo.().Size = new Size(465, 26);
			this.OO_O_0._O0O_oo.().TabIndex = 0;
			this.OO_O_0._O0O_oo.().Tag = null;
			this.o0_0oo0.OOo0oo.().AutoSize = true;
			this.o0_0oo0.OOo0oo.().Location = new Point(18, 24);
			this.o0_0oo0.OOo0oo.().Margin = new Padding(4, 0, 4, 0);
			this.o0_0oo0.OOo0oo.().Name = "Label1";
			this.o0_0oo0.OOo0oo.().Size = new Size(53, 18);
			this.o0_0oo0.OOo0oo.().TabIndex = 9;
			this.o0_0oo0.OOo0oo.().Text = "名称:";
			this.o0_0oo0.OOo0oo.().Location = new Point(165, 368);
			this.o0_0oo0.OOo0oo.().Margin = new Padding(4, 4, 4, 4);
			this.o0_0oo0.OOo0oo.().Name = "btnOK";
			this.o0_0oo0.OOo0oo.().Size = new Size(112, 34);
			this.o0_0oo0.OOo0oo.().TabIndex = 4;
			this.o0_0oo0.OOo0oo.().Text = "确定";
			this.o0_0oo0.OOo0oo.().UseVisualStyleBackColor = true;
			this.Oo_0o.ooOoo00O.().CausesValidation = false;
			this.Oo_0o.ooOoo00O.().DialogResult = DialogResult.Cancel;
			this.Oo_0o.ooOoo00O.().Location = new Point(286, 368);
			this.Oo_0o.ooOoo00O.().Margin = new Padding(4, 4, 4, 4);
			this.Oo_0o.ooOoo00O.().Name = "btnCancel";
			this.Oo_0o.ooOoo00O.().Size = new Size(112, 34);
			this.Oo_0o.ooOoo00O.().TabIndex = 5;
			this.Oo_0o.ooOoo00O.().Text = "取消";
			this.Oo_0o.ooOoo00O.().UseVisualStyleBackColor = true;
			this.o0_Oo0._.().AutoSize = true;
			this.o0_Oo0._.().Location = new Point(18, 200);
			this.o0_Oo0._.().Margin = new Padding(4, 0, 4, 0);
			this.o0_Oo0._.().Name = "lblLenght";
			this.o0_Oo0._.().Size = new Size(53, 18);
			this.o0_Oo0._.().TabIndex = 15;
			this.o0_Oo0._.().Text = "长度:";
			this.oo0O_O0.OOO_oO.().DataType = typeof(byte);
			this.oo0O_O0.OOO_oO.().ImagePadding = new Padding(0, 0, 0, 0);
			this.oo0O_O0.OOO_oO.().Location = new Point(84, 194);
			this.oo0O_O0.OOO_oO.().Margin = new Padding(4, 4, 4, 4);
			this.oo0O_O0.OOO_oO.().Name = "Length";
			this.oo0O_O0.OOO_oO.().PostValidation.Intervals.AddRange(new ValueInterval[]
			{
				new ValueInterval(1L, 255L, true, true)
			});
			this.oo0O_O0.OOO_oO.().Size = new Size(105, 26);
			this.oo0O_O0.OOO_oO.().TabIndex = 3;
			this.oo0O_O0.OOO_oO.().Tag = null;
			this.oo0O_O0.OOO_oO.().Value = 16;
			this.oo0O_O0.OOO_oO.().VisibleButtons = DropDownControlButtonFlags.UpDown;
			this.OO.0Ooo_0.().Location = new Point(18, 246);
			this.OO.0Ooo_0.().Margin = new Padding(4, 0, 4, 0);
			this.OO.0Ooo_0.().Name = "Description";
			this.OO.0Ooo_0.().Size = new Size(531, 104);
			this.OO.0Ooo_0.().TabIndex = 17;
			this.OO.0Ooo_0.().Text = "说明:";
			this.o.O0o00O__OO.().AutoSize = true;
			this.o.O0o00O__OO.().Location = new Point(18, 70);
			this.o.O0o00O__OO.().Margin = new Padding(4, 0, 4, 0);
			this.o.O0o00O__OO.().Name = "Label3";
			this.o.O0o00O__OO.().Size = new Size(53, 18);
			this.o.O0o00O__OO.().TabIndex = 18;
			this.o.O0o00O__OO.().Text = "标题:";
			this.oo0O_O0.OOO_oO.().Location = new Point(84, 64);
			this.oo0O_O0.OOO_oO.().Margin = new Padding(4, 4, 4, 4);
			this.oo0O_O0.OOO_oO.().Name = "txtCaption";
			this.oo0O_O0.OOO_oO.().Size = new Size(465, 26);
			this.oo0O_O0.OOO_oO.().TabIndex = 1;
			this.oo0O_O0.OOO_oO.().Tag = null;
			this.Oo_0o.ooOoo00O.().AutoSize = true;
			this.Oo_0o.ooOoo00O.().Location = new Point(198, 200);
			this.Oo_0o.ooOoo00O.().Margin = new Padding(4, 0, 4, 0);
			this.Oo_0o.ooOoo00O.().Name = "Label5";
			this.Oo_0o.ooOoo00O.().Size = new Size(242, 18);
			this.Oo_0o.ooOoo00O.().TabIndex = 21;
			this.Oo_0o.ooOoo00O.().Text = "(字符列允许输入的最大长度)";
			this.oO0OO.O_O.().Location = new Point(80, 100);
			this.oO0OO.O_O.().Margin = new Padding(4, 0, 4, 0);
			this.oO0OO.O_O.().Name = "Label6";
			this.oO0OO.O_O.().Size = new Size(470, 44);
			this.oO0OO.O_O.().TabIndex = 22;
			this.oO0OO.O_O.().Text = "标题是列名更具描述性的表示，可以不输入，直接用列名作为标题。";
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.Oo_0o.ooOoo00O.();
			base.ClientSize = new Size(568, 418);
			base.Controls.Add(this.oO0OO.O_O.());
			base.Controls.Add(this.Oo_0o.ooOoo00O.());
			base.Controls.Add(this.oo0O_O0.OOO_oO.());
			base.Controls.Add(this.o.O0o00O__OO.());
			base.Controls.Add(this.OO.0Ooo_0.());
			base.Controls.Add(this.oo0O_O0.OOO_oO.());
			base.Controls.Add(this.o0_Oo0._.());
			base.Controls.Add(this.Oo_0o.ooOoo00O.());
			base.Controls.Add(this.o0_0oo0.OOo0oo.());
			base.Controls.Add(this.o0_0oo0.OOo0oo.());
			base.Controls.Add(this.O.0_0.());
			base.Controls.Add(this.OO_O_0._O0O_oo.());
			base.Controls.Add(this.o0_0oo0.OOo0oo.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(4, 4, 4, 4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O1.1I.oI";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "增加列";
			((ISupportInitialize)this.o0_0oo0.OOo0oo.()).EndInit();
			((ISupportInitialize)this.OO_O_0._O0O_oo.()).EndInit();
			((ISupportInitialize)this.o0_0oo0.OOo0oo.()).EndInit();
			((ISupportInitialize)this.Oo_0o.ooOoo00O.()).EndInit();
			((ISupportInitialize)this.oo0O_O0.OOO_oO.()).EndInit();
			((ISupportInitialize)this.oo0O_O0.OOO_oO.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x001A10A9 File Offset: 0x0019F2A9
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.oOO0o.0_.;
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x001A10B4 File Offset: 0x0019F2B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O0__.0o0O_O.);
			C1ComboBox c1ComboBox = this.oOO0o.0_.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.oOO0o.0_. = A_0;
			c1ComboBox = this.oOO0o.0_.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x001A10F7 File Offset: 0x0019F2F7
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOO0o.0_.;
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x001A10FF File Offset: 0x0019F2FF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOO0o.0_. = A_0;
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x001A1108 File Offset: 0x0019F308
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_.O0.;
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x001A1110 File Offset: 0x0019F310
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O_.O0. = A_0;
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x001A1119 File Offset: 0x0019F319
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_O_O0oo_O.oo.;
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x001A1121 File Offset: 0x0019F321
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_O_O0oo_O.oo. = A_0;
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x001A112A File Offset: 0x0019F32A
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO_.o.;
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x001A1134 File Offset: 0x0019F334
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O__o.oO.);
			C1Button oo_.o. = this.OO_.o.;
			if (oo_.o. != null)
			{
				oo_.o..Click -= value;
			}
			this.OO_.o. = A_0;
			oo_.o. = this.OO_.o.;
			if (oo_.o. != null)
			{
				oo_.o..Click += value;
			}
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x001A1177 File Offset: 0x0019F377
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_O00__.0oo0.;
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x001A117F File Offset: 0x0019F37F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O_O00__.0oo0. = A_0;
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x001A1188 File Offset: 0x0019F388
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.ooo.oO0.;
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x001A1190 File Offset: 0x0019F390
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.ooo.oO0. = A_0;
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x001A1199 File Offset: 0x0019F399
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.oOO0o.0_.;
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x001A11A1 File Offset: 0x0019F3A1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			this.oOO0o.0_. = A_0;
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x001A11AA File Offset: 0x0019F3AA
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o__o___.0Ooo.;
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x001A11B2 File Offset: 0x0019F3B2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o__o___.0Ooo. = A_0;
		}

		// Token: 0x06003A2D RID: 14893 RVA: 0x001A11BB File Offset: 0x0019F3BB
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0OO0O0_0O_.oO.;
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x001A11C3 File Offset: 0x0019F3C3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0OO0O0_0O_.oO. = A_0;
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x001A11CC File Offset: 0x0019F3CC
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o_O_O0oo_O.oo.;
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x001A11D4 File Offset: 0x0019F3D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o_O_O0oo_O.oo. = A_0;
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x001A11DD File Offset: 0x0019F3DD
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0._0_O.;
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x001A11E5 File Offset: 0x0019F3E5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0._0_O. = A_0;
		}

		// Token: 0x06003A33 RID: 14899 RVA: 0x001A11EE File Offset: 0x0019F3EE
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0_oo_O.oO_0_0.;
		}

		// Token: 0x06003A34 RID: 14900 RVA: 0x001A11F6 File Offset: 0x0019F3F6
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0_oo_O.oO_0_0. = A_0;
		}

		// Token: 0x06003A35 RID: 14901 RVA: 0x001A1200 File Offset: 0x0019F400
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0_0oo0.OOo0oo.().ItemsDisplayMember = "DisplayName";
			this.o0_0oo0.OOo0oo.().ItemsValueMember = "DataType";
			this.o0_0oo0.OOo0oo.().TranslateValue = true;
			if (OO_00oOO.DataTables[this.O_.O0.].frd_IsTemporary || o_O_o_oOoo__.OOOO_OO._oo.(OO_00oOO.DataTables[this.O_.O0.].frd_Connection))
			{
				this.o0_0oo0.OOo0oo.().ItemsDataSource = DataTypePair.CreateDataTypePairs(false);
			}
			else
			{
				this.o0_0oo0.OOo0oo.().ItemsDataSource = DataTypePair.CreateDataTypePairs(true);
			}
			this.o0_0oo0.OOo0oo.().SelectedIndex = 0;
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x001A129C File Offset: 0x0019F49C
		public o\u3002\u3000\u3000\u3002\u3000\u3000\u3000(string A_0, bool A_1)
		{
			base.Load += this.oO0OO.O_O.;
			base.FormClosed += this.O0__.0o0O_O.;
			this.oo0O_O0.OOO_oO.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o0O.o0. = A_0;
			this.O_.O0. = OO_00oOO.Tables[A_0].DataTable.Name;
			this.O_.O0. = A_1;
			if (this.O_.O0.)
			{
				this.Text = "插入列";
			}
			this.Text = this.Text + " - " + this.O_.O0.;
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.foxGrid.FindForm() != null && Operators.CompareString(table.DataTable.Name, this.O_.O0., true) == 0)
					{
						table._frdTableLayout.OOooOOo_.0_0_o.();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x001A13B0 File Offset: 0x0019F5B0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				OO_00oOO.SystemReady = false;
				if (this.o0_0oo0.OOo0oo.().SelectedItem != null && o_O_o_oOoo__.O_o_._o0.(this.OO_O_0._O0O_oo.().Text.Trim(), "列名称", 64, false))
				{
					string text = this.OO_O_0._O0O_oo.().Text.Trim();
					ColumnDataTypeEnum columnDataTypeEnum = (ColumnDataTypeEnum)Conversions.ToInteger(this.o0_0oo0.OOo0oo.().SelectedItem);
					int num = Conversions.ToInteger(this.oo0O_O0.OOO_oO.().Value);
					try
					{
						IEnumerator enumerator = OO_00oOO.DataTables[this.O_.O0.].BaseTable.Columns.GetEnumerator();
						while (enumerator.MoveNext())
						{
							if (Operators.CompareString(((DataColumn)enumerator.Current).ColumnName, text, true) == 0)
							{
								MessageBox.Show("已经存在同名列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								return;
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
					if (Oo00.o.OO0.(this.O_.O0., text))
					{
						if (OO_00oOO.DataTables[this.O_.O0.].frd_IsTemporary)
						{
							DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()];
							DataRow dataRow = dataTable.NewRow();
							dataRow["Table"] = this.O_.O0.;
							dataRow["Column"] = text;
							dataRow["DataType"] = columnDataTypeEnum;
							dataRow["Maxlength"] = num;
							dataRow["Expression"] = "";
							dataTable.Rows.Add(dataRow);
							if (Operators.CompareString(this.oo0O_O0.OOO_oO.().Text.Trim(), "", true) != 0)
							{
								DataRow dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
								{
									this.O_.O0.,
									text
								});
								if (dataRow2 == null)
								{
									dataRow2 = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].NewRow();
									dataRow2["Table"] = this.O_.O0.;
									dataRow2["Column"] = text;
									O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Add(dataRow2);
								}
								dataRow2["Config"] = "Caption\v" + this.oo0O_O0.OOO_oO.().Text.Trim();
								Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
							}
							Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()], true);
						}
						else
						{
							OleDbConnection oleDbConnection = OO_00oOO.DataTables[this.O_.O0.].frd_Connection;
							o_oo0 o_oo = new o_oo0(oleDbConnection, o_O_o_oOoo__.OOOO_OO._oo.(oleDbConnection), oleDbConnection == O_O0OO.OoO.0OO__0ooo.());
							string a_;
							if (oleDbConnection == O_O0OO.OoO.0OO__0ooo.())
							{
								a_ = this.O_.O0.;
							}
							else
							{
								a_ = OO_00oOO.DataTables[this.O_.O0.].o._OOO0oOo0__.;
							}
							O_0O_ o_0O_ = o_oo.o0_oo0._.().O.0_O.(a_);
							if (o_0O_.o_O00_.00_.().O_o0.Oo00o0.(text))
							{
								MessageBox.Show("已经存在同名列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								return;
							}
							o_0O_.o_O00_.00_.().O_o0.Oo00o0.(text, columnDataTypeEnum, int.MinValue);
							if (Operators.CompareString(this.oo0O_O0.OOO_oO.().Text.Trim(), "", true) != 0)
							{
								o_0O_.o_O00_.00_.().OO00o__OOO.o0_.(text).O.0_.(this.oo0O_O0.OOO_oO.().Text.Trim());
							}
							if (columnDataTypeEnum == ColumnDataTypeEnum.String)
							{
								o_0O_.o_O00_.00_.().OO00o__OOO.o0_.(text).O_o0.Oo00o0.(num);
							}
							o_oo.o0_oo0._.(true, false);
							OO_00oOO.DataTables[this.O_.O0.].O_00_._.();
						}
						if (columnDataTypeEnum == ColumnDataTypeEnum.String)
						{
							OO_00oOO.DataTables[this.O_.O0.].DataCols.Add(text, Oo00.OO.0O0o.(columnDataTypeEnum), num, "");
						}
						else
						{
							OO_00oOO.DataTables[this.O_.O0.].DataCols.Add(text, Oo00.OO.0O0o.(columnDataTypeEnum), -1, "");
						}
						if (!OO_00oOO.DataTables[this.O_.O0.].frd_IsTemporary)
						{
							OO_00oOO.DataTables[this.O_.O0.].DataCols[text].IsTemporary = false;
						}
						try
						{
							foreach (Table table in OO_00oOO.Tables)
							{
								if (table.foxGrid.FindForm() != null)
								{
									table.O.__O0o0.(true, true);
									if (Operators.CompareString(table.DataTable.Name, this.O_.O0., true) == 0)
									{
										table._frdTableLayout.Oo_.oo_oOo_oO.();
									}
								}
							}
						}
						finally
						{
							IEnumerator<Table> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						O_oOooO_O o_oOooO_O = OO_00oOO.CurrentTable.foxGrid;
						if (this.O_.O0. && o_oOooO_O.Col > o_oOooO_O.Cols.Fixed - 1 && o_oOooO_O.Cols.Contains(text))
						{
							o_oOooO_O.Cols[text].Move(o_oOooO_O.Col);
						}
						if (o_oOooO_O.Cols.Contains(text))
						{
							o_oOooO_O.Col = o_oOooO_O.Cols.IndexOf(text);
							o_oOooO_O.ShowCell(o_oOooO_O.Row, o_oOooO_O.Col);
						}
						try
						{
							foreach (Table table2 in OO_00oOO.Tables)
							{
								if (Operators.CompareString(table2.DataTable.Name, this.O_.O0., true) == 0)
								{
									if (table2.Cols.Contains(text))
									{
										table2.Cols[text].o0.O.();
										table2.Cols[text].OpenWindow(0);
									}
									table2.NeedSaveSetting = true;
									table2.Oo._0oO.();
								}
							}
						}
						finally
						{
							IEnumerator<Table> enumerator3;
							if (enumerator3 != null)
							{
								enumerator3.Dispose();
							}
						}
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
						base.DialogResult = DialogResult.OK;
					}
				}
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
			finally
			{
				OO_00oOO.SystemReady = true;
			}
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x001A1A50 File Offset: 0x0019FC50
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oo0O_O0.OOO_oO.().Enabled = (Conversions.ToInteger(this.o0_0oo0.OOo0oo.().SelectedItem) == 202);
			this.OO.0Ooo_0.().Text = "说明:" + ooO.oO0__o.0o__.((ColumnDataTypeEnum)Conversions.ToInteger(this.o0_0oo0.OOo0oo.().SelectedItem));
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x001A1AA9 File Offset: 0x0019FCA9
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040017D1 RID: 6097
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040017D2 RID: 6098
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040017D3 RID: 6099
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040017D4 RID: 6100
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040017D5 RID: 6101
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040017D6 RID: 6102
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017D7 RID: 6103
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017D8 RID: 6104
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040017D9 RID: 6105
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x040017DA RID: 6106
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040017DB RID: 6107
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040017DC RID: 6108
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040017DD RID: 6109
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040017DE RID: 6110
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040017DF RID: 6111
		private string <<EMPTY_NAME>>;

		// Token: 0x040017E0 RID: 6112
		private string <<EMPTY_NAME>>;

		// Token: 0x040017E1 RID: 6113
		private bool <<EMPTY_NAME>>;
	}
}
