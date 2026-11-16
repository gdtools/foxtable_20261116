using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000371 RID: 881
	[DesignerGenerated]
	internal partial class oO0\u3002 : Form
	{
		// Token: 0x06003841 RID: 14401 RVA: 0x00190928 File Offset: 0x0018EB28
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O0._0O0O. != null)
				{
					this.O0._0O0O..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x00190968 File Offset: 0x0018EB68
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oooo.0000_o.(new C1ComboBox());
			this.Ooo.00_OO.(new C1ComboBox());
			this.OOOO0o0o.Oo00.(new C1ComboBox());
			this.Ooo.00_OO.(new RadioButton());
			this.OOOO0o0o.Oo00.(new RadioButton());
			this.OOOO0o0o.Oo00.(new Label());
			this.oOO._0O.(new C1Button());
			this.oo_OO.ooo_.(new C1Button());
			base.SuspendLayout();
			this.O_Ooo__0.o_0.().DropDownStyle = DropDownStyle.DropDownList;
			this.O_Ooo__0.o_0.().Location = new Point(19, 17);
			this.O_Ooo__0.o_0.().Name = "ComboBox1";
			this.O_Ooo__0.o_0.().Size = new Size(157, 20);
			this.O_Ooo__0.o_0.().TabIndex = 0;
			this.oo_OO.ooo_.().DropDownStyle = DropDownStyle.DropDownList;
			this.oo_OO.ooo_.().Location = new Point(19, 74);
			this.oo_OO.ooo_.().Name = "ComboBox2";
			this.oo_OO.ooo_.().Size = new Size(157, 20);
			this.oo_OO.ooo_.().TabIndex = 1;
			this.oOO._0O.().DropDownStyle = DropDownStyle.DropDownList;
			this.oOO._0O.().Location = new Point(187, 74);
			this.oOO._0O.().Name = "ComboBox3";
			this.oOO._0O.().Size = new Size(154, 20);
			this.oOO._0O.().TabIndex = 2;
			this.oOO._0O.().AutoSize = true;
			this.oOO._0O.().Checked = true;
			this.oOO._0O.().Location = new Point(19, 112);
			this.oOO._0O.().Name = "RadioButton1";
			this.oOO._0O.().Size = new Size(71, 16);
			this.oOO._0O.().TabIndex = 3;
			this.oOO._0O.().TabStop = true;
			this.oOO._0O.().Text = "有对应值";
			this.oOO._0O.().UseVisualStyleBackColor = true;
			this.oo_OO.ooo_.().AutoSize = true;
			this.oo_OO.ooo_.().Location = new Point(105, 112);
			this.oo_OO.ooo_.().Name = "RadioButton2";
			this.oo_OO.ooo_.().Size = new Size(71, 16);
			this.oo_OO.ooo_.().TabIndex = 4;
			this.oo_OO.ooo_.().TabStop = true;
			this.oo_OO.ooo_.().Text = "无对应值";
			this.oo_OO.ooo_.().UseVisualStyleBackColor = true;
			this.oOO._0O.().AutoSize = true;
			this.oOO._0O.().Location = new Point(17, 50);
			this.oOO._0O.().Name = "Label1";
			this.oOO._0O.().Size = new Size(113, 12);
			this.oOO._0O.().TabIndex = 5;
			this.oOO._0O.().Text = "在指定的表和列中：";
			this.OoOO0O.0.().Location = new Point(95, 160);
			this.OoOO0O.0.().Name = "Button1";
			this.OoOO0O.0.().Size = new Size(75, 23);
			this.OoOO0O.0.().TabIndex = 6;
			this.OoOO0O.0.().Text = "筛选";
			this.OoOO0O.0.().UseVisualStyleBackColor = true;
			this.oOO._0O.().DialogResult = DialogResult.Cancel;
			this.oOO._0O.().Location = new Point(189, 160);
			this.oOO._0O.().Name = "Button2";
			this.oOO._0O.().Size = new Size(75, 23);
			this.oOO._0O.().TabIndex = 7;
			this.oOO._0O.().Text = "关闭";
			this.oOO._0O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(358, 195);
			base.Controls.Add(this.oOO._0O.());
			base.Controls.Add(this.OoOO0O.0.());
			base.Controls.Add(this.oOO._0O.());
			base.Controls.Add(this.oo_OO.ooo_.());
			base.Controls.Add(this.oOO._0O.());
			base.Controls.Add(this.oOO._0O.());
			base.Controls.Add(this.oo_OO.ooo_.());
			base.Controls.Add(this.O_Ooo__0.o_0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O..o....";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "关联筛选";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00190DFF File Offset: 0x0018EFFF
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.OOOO0o0o.Oo00.;
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x00190E08 File Offset: 0x0018F008
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.OoOO0O.0.);
			C1ComboBox oooo0o0o.Oo00. = this.OOOO0o0o.Oo00.;
			if (oooo0o0o.Oo00. != null)
			{
				oooo0o0o.Oo00..SelectedIndexChanged -= value;
			}
			this.OOOO0o0o.Oo00. = A_0;
			oooo0o0o.Oo00. = this.OOOO0o0o.Oo00.;
			if (oooo0o0o.Oo00. != null)
			{
				oooo0o0o.Oo00..SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x00190E4B File Offset: 0x0018F04B
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.Ooo.00_OO.;
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x00190E54 File Offset: 0x0018F054
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.o0o._Oo_o0O.);
			C1ComboBox ooo.00_OO. = this.Ooo.00_OO.;
			if (ooo.00_OO. != null)
			{
				ooo.00_OO..SelectedIndexChanged -= value;
			}
			this.Ooo.00_OO. = A_0;
			ooo.00_OO. = this.Ooo.00_OO.;
			if (ooo.00_OO. != null)
			{
				ooo.00_OO..SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x00190E97 File Offset: 0x0018F097
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.oOO.OO.;
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x00190E9F File Offset: 0x0018F09F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.oOO.OO. = A_0;
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x00190EA8 File Offset: 0x0018F0A8
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O0._0O0O.;
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x00190EB0 File Offset: 0x0018F0B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O0._0O0O. = A_0;
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x00190EB9 File Offset: 0x0018F0B9
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.oO.OOo0_Ooo_0.;
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x00190EC1 File Offset: 0x0018F0C1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.oO.OOo0_Ooo_0. = A_0;
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x00190ECA File Offset: 0x0018F0CA
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0._0O0O.;
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x00190ED2 File Offset: 0x0018F0D2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0._0O0O. = A_0;
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x00190EDB File Offset: 0x0018F0DB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOOO0o0o.Oo00.;
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x00190EE4 File Offset: 0x0018F0E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO0.__.);
			C1Button oooo0o0o.Oo00. = this.OOOO0o0o.Oo00.;
			if (oooo0o0o.Oo00. != null)
			{
				oooo0o0o.Oo00..Click -= value;
			}
			this.OOOO0o0o.Oo00. = A_0;
			oooo0o0o.Oo00. = this.OOOO0o0o.Oo00.;
			if (oooo0o0o.Oo00. != null)
			{
				oooo0o0o.Oo00..Click += value;
			}
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x00190F27 File Offset: 0x0018F127
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Ooo.00_OO.;
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x00190F2F File Offset: 0x0018F12F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.Ooo.00_OO. = A_0;
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x00190F38 File Offset: 0x0018F138
		public oO0\u3002()
		{
			base.Load += this.OoOo._O.;
			base.FormClosed += this.OO0.__.;
			this.oOO._0O.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x00190F8C File Offset: 0x0018F18C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string name = OO_00oOO.CurrentTable.Cols[OO_00oOO.CurrentTable.ColSel].Name;
			try
			{
				foreach (DataCol dataCol in OO_00oOO.CurrentTable.DataTable.DataCols)
				{
					this.O_Ooo__0.o_0.().Items.Add(dataCol.Name);
					if (Operators.CompareString(dataCol.Name, name, true) == 0)
					{
						this.O_Ooo__0.o_0.().SelectedIndex = this.O_Ooo__0.o_0.().Items.Count - 1;
					}
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
			try
			{
				foreach (DataTable dataTable in OO_00oOO.DataTables)
				{
					if (Operators.CompareString(dataTable.Name, OO_00oOO.CurrentTable.Name, true) != 0)
					{
						this.oo_OO.ooo_.().Items.Add(dataTable.Name);
					}
				}
			}
			finally
			{
				IEnumerator<DataTable> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			this.oo_OO.ooo_.().SelectedIndex = 0;
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x001910B8 File Offset: 0x0018F2B8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataTable dataTable = OO_00oOO.DataTables[this.oo_OO.ooo_.().Text];
			Type dataType = OO_00oOO.CurrentTable.DataTable.DataCols[this.O_Ooo__0.o_0.().Text].BaseColumn.DataType;
			this.oOO._0O.().Items.Clear();
			try
			{
				foreach (DataCol dataCol in dataTable.DataCols)
				{
					if (dataCol.BaseColumn.DataType == dataType)
					{
						this.oOO._0O.().Items.Add(dataCol.Name);
					}
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
			if (this.oOO._0O.().Items.Count > 0)
			{
				this.oOO._0O.().SelectedIndex = 0;
			}
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x00191194 File Offset: 0x0018F394
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oo_OO.ooo_.().SelectedIndex >= 0)
			{
				this.o0o._Oo_o0O.(this.oo_OO.ooo_.(), new EventArgs());
			}
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x001911B8 File Offset: 0x0018F3B8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O_Ooo__0.o_0.().SelectedIndex >= 0 && this.oo_OO.ooo_.().SelectedIndex >= 0 && this.oOO._0O.().SelectedIndex >= 0)
			{
				Table table = OO_00oOO.CurrentTable;
				table.ClearEditInfos();
				string text = this.O_Ooo__0.o_0.().Text;
				DataTable dataTable = table.DataTable.BaseTable;
				string text2 = this.oOO._0O.().Text;
				DataTable dataTable2 = OO_00oOO.DataTables[this.oo_OO.ooo_.().Text].BaseTable;
				new List<OoO_O00>();
				if (dataTable2.Columns[text2].DataType != dataTable.Columns[text].DataType)
				{
					MessageBox.Show("数据类型不匹配！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				bool backFilter = Oo00.O____0O._0.(table);
				table.RelationFilter(text, dataTable2.TableName, text2, this.oOO._0O.().Checked, backFilter);
			}
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x001912A7 File Offset: 0x0018F4A7
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001704 RID: 5892
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001705 RID: 5893
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001706 RID: 5894
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001707 RID: 5895
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001708 RID: 5896
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001709 RID: 5897
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400170A RID: 5898
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400170B RID: 5899
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400170C RID: 5900
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
