using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.My;
using Foxtable.RibbonMenu;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000340 RID: 832
	[DesignerGenerated]
	internal partial class o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000 : Form
	{
		// Token: 0x06003295 RID: 12949 RVA: 0x00158D40 File Offset: 0x00156F40
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o0_0.0OOO_0Oo. != null)
				{
					this.o0_0.0OOO_0Oo..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x00158D80 File Offset: 0x00156F80
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oo_.oO.(new RadioButton());
			this.O00_O.O0.(new RadioButton());
			this.O00_O.O0.(new CheckedListBox());
			this.O00_O.O0.(new System.Windows.Forms.Label());
			this.o_o_O0_.O.(new C1Button());
			this.O0o.o.(new C1Button());
			this.O00_O.O0.(new SaveFileDialog());
			this.oo_.oO.(new C1CheckBox());
			this.O00_O.O0.(new C1CheckBox());
			this.o0__oo._o.(new RadioButton());
			this.O00_O.O0.(new C1TextBox());
			base.SuspendLayout();
			this.oo_0O.O0oo_o.().AutoSize = true;
			this.oo_0O.O0oo_o.().Checked = true;
			this.oo_0O.O0oo_o.().Location = new Point(14, 320);
			this.oo_0O.O0oo_o.().Name = "Tab";
			this.oo_0O.O0oo_o.().Size = new Size(101, 16);
			this.oo_0O.O0oo_o.().TabIndex = 1;
			this.oo_0O.O0oo_o.().TabStop = true;
			this.oo_0O.O0oo_o.().Text = "用Tab符分隔列";
			this.oo_0O.O0oo_o.().UseVisualStyleBackColor = true;
			this.O00_0.0o00_.().AutoSize = true;
			this.O00_0.0o00_.().Location = new Point(14, 342);
			this.O00_0.0o00_.().Name = "Comma";
			this.O00_0.0o00_.().Size = new Size(95, 16);
			this.O00_0.0o00_.().TabIndex = 2;
			this.O00_0.0o00_.().Text = "用逗号分割列";
			this.O00_0.0o00_.().UseVisualStyleBackColor = true;
			this.O0o.o.().FormattingEnabled = true;
			this.O0o.o.().Location = new Point(12, 28);
			this.O0o.o.().Name = "lstColumns";
			this.O0o.o.().Size = new Size(471, 276);
			this.O0o.o.().TabIndex = 0;
			this.O0o.o.().AutoSize = true;
			this.O0o.o.().Location = new Point(12, 9);
			this.O0o.o.().Name = "Label1";
			this.O0o.o.().Size = new Size(47, 12);
			this.O0o.o.().TabIndex = 33;
			this.O0o.o.().Text = "选择列:";
			this.O00_0.0o00_.().DialogResult = DialogResult.OK;
			this.O00_0.0o00_.().Location = new Point(164, 408);
			this.O00_0.0o00_.().Name = "Button2";
			this.O00_0.0o00_.().Size = new Size(75, 23);
			this.O00_0.0o00_.().TabIndex = 7;
			this.O00_0.0o00_.().Text = "确定";
			this.O00_0.0o00_.().UseVisualStyleBackColor = true;
			this.Oo_.Oo0.().DialogResult = DialogResult.Cancel;
			this.Oo_.Oo0.().Location = new Point(255, 408);
			this.Oo_.Oo0.().Name = "Button3";
			this.Oo_.Oo0.().Size = new Size(75, 23);
			this.Oo_.Oo0.().TabIndex = 8;
			this.Oo_.Oo0.().Text = "取消";
			this.Oo_.Oo0.().UseVisualStyleBackColor = true;
			this.O00_0.0o00_.().Filter = "文本文件(*.txt)|*.txt";
			this.O0o.o.().AutoSize = true;
			this.O0o.o.().Location = new Point(388, 342);
			this.O0o.o.().Name = "OnlySelected";
			this.O0o.o.().Size = new Size(72, 16);
			this.O0o.o.().TabIndex = 6;
			this.O0o.o.().Text = "仅选定行";
			this.O0o.o.().UseVisualStyleBackColor = true;
			this.o_o_O0_.O.().AutoSize = true;
			this.o_o_O0_.O.().Checked = true;
			this.o_o_O0_.O.().CheckState = CheckState.Checked;
			this.o_o_O0_.O.().Location = new Point(388, 321);
			this.o_o_O0_.O.().Name = "IncludeFixed";
			this.o_o_O0_.O.().Size = new Size(72, 16);
			this.o_o_O0_.O.().TabIndex = 5;
			this.o_o_O0_.O.().Text = "含标题行";
			this.o_o_O0_.O.().UseVisualStyleBackColor = true;
			this.Oo_.Oo0.().AutoSize = true;
			this.Oo_.Oo0.().Location = new Point(14, 364);
			this.Oo_.Oo0.().Name = "Custom";
			this.Oo_.Oo0.().Size = new Size(107, 16);
			this.Oo_.Oo0.().TabIndex = 3;
			this.Oo_.Oo0.().TabStop = true;
			this.Oo_.Oo0.().Text = "自定义列分隔符";
			this.Oo_.Oo0.().UseVisualStyleBackColor = true;
			this.O0o.o.().AcceptsReturn = true;
			this.O0o.o.().Location = new Point(127, 359);
			this.O0o.o.().Name = "txtSeparator";
			this.O0o.o.().ReadOnly = true;
			this.O0o.o.().Size = new Size(100, 21);
			this.O0o.o.().TabIndex = 4;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(495, 443);
			base.Controls.Add(this.O0o.o.());
			base.Controls.Add(this.Oo_.Oo0.());
			base.Controls.Add(this.o_o_O0_.O.());
			base.Controls.Add(this.O0o.o.());
			base.Controls.Add(this.Oo_.Oo0.());
			base.Controls.Add(this.O00_0.0o00_.());
			base.Controls.Add(this.O0o.o.());
			base.Controls.Add(this.O0o.o.());
			base.Controls.Add(this.O00_0.0o00_.());
			base.Controls.Add(this.oo_0O.O0oo_o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.O....O";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "导出";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x001593AB File Offset: 0x001575AB
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o0oO.o0_0.;
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x001593B3 File Offset: 0x001575B3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.o0oO.o0_0. = A_0;
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x001593BC File Offset: 0x001575BC
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O_0O.oO_0O_oOO.;
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x001593C4 File Offset: 0x001575C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O_0O.oO_0O_oOO. = A_0;
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x001593CD File Offset: 0x001575CD
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.o0oO.o0_0.;
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x001593D8 File Offset: 0x001575D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			ItemCheckEventHandler value = new ItemCheckEventHandler(this.O0o.o.);
			CheckedListBox checkedListBox = this.o0oO.o0_0.;
			if (checkedListBox != null)
			{
				checkedListBox.ItemCheck -= value;
			}
			this.o0oO.o0_0. = A_0;
			checkedListBox = this.o0oO.o0_0.;
			if (checkedListBox != null)
			{
				checkedListBox.ItemCheck += value;
			}
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x0015941B File Offset: 0x0015761B
		[CompilerGenerated]
		internal virtual System.Windows.Forms.Label <<EMPTY_NAME>>()
		{
			return this.o0oO.o0_0.;
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x00159423 File Offset: 0x00157623
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.Label A_0)
		{
			this.o0oO.o0_0. = A_0;
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x0015942C File Offset: 0x0015762C
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O00_O.O0.;
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x00159434 File Offset: 0x00157634
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo_.Oo0.);
			C1Button o00_O.O0. = this.O00_O.O0.;
			if (o00_O.O0. != null)
			{
				o00_O.O0..Click -= value;
			}
			this.O00_O.O0. = A_0;
			o00_O.O0. = this.O00_O.O0.;
			if (o00_O.O0. != null)
			{
				o00_O.O0..Click += value;
			}
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x00159477 File Offset: 0x00157677
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_0O.oO_0O_oOO.;
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x0015947F File Offset: 0x0015767F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O_0O.oO_0O_oOO. = A_0;
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00159488 File Offset: 0x00157688
		[CompilerGenerated]
		internal virtual SaveFileDialog <<EMPTY_NAME>>()
		{
			return this.o0oO.o0_0.;
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x00159490 File Offset: 0x00157690
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SaveFileDialog A_0)
		{
			this.o0oO.o0_0. = A_0;
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x00159499 File Offset: 0x00157699
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o0oO.o0_0.;
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x001594A1 File Offset: 0x001576A1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o0oO.o0_0. = A_0;
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x001594AA File Offset: 0x001576AA
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O_0O.oO_0O_oOO.;
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x001594B2 File Offset: 0x001576B2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.O_0O.oO_0O_oOO. = A_0;
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x001594BB File Offset: 0x001576BB
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O.0___o0oO0.;
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x001594C4 File Offset: 0x001576C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.O00_0.0o00_.);
			RadioButton o.0___o0oO0. = this.O.0___o0oO0.;
			if (o.0___o0oO0. != null)
			{
				o.0___o0oO0..CheckedChanged -= value;
			}
			this.O.0___o0oO0. = A_0;
			o.0___o0oO0. = this.O.0___o0oO0.;
			if (o.0___o0oO0. != null)
			{
				o.0___o0oO0..CheckedChanged += value;
			}
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x00159507 File Offset: 0x00157707
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o0oO.o0_0.;
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x0015950F File Offset: 0x0015770F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.o0oO.o0_0. = A_0;
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x00159518 File Offset: 0x00157718
		public o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000()
		{
			base.Load += this.oo.00O_O0.;
			base.FormClosed += this.O00_0.0o00_.;
			this.O0o.o.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x0015956C File Offset: 0x0015776C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Table table = OO_00oOO.CurrentTable;
			this.O0o.o.().Items.Add("全选", true);
			int @fixed = table.foxGrid.Cols.Fixed;
			int num = table.foxGrid.Cols.Count - 1;
			for (int i = @fixed; i <= num; i++)
			{
				this.O0o.o.().Items.Add(table.foxGrid.Cols[i].Name, true);
			}
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x001595EC File Offset: 0x001577EC
		private void <<EMPTY_NAME>>(object A_0, ItemCheckEventArgs A_1)
		{
			if (this.O0o.o.().GetItemRectangle(A_1.Index).Contains(this.O0o.o.().PointToClient(Control.MousePosition)) && A_1.Index == 0)
			{
				bool value = A_1.NewValue == CheckState.Checked;
				int num = this.O0o.o.().Items.Count - 1;
				for (int i = 1; i <= num; i++)
				{
					this.O0o.o.().SetItemChecked(i, value);
				}
			}
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x00159664 File Offset: 0x00157864
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			List<string> list = new List<string>();
			OO_00oOO.CurrentTable.DataTable.BaseTable;
			StringBuilder stringBuilder = new StringBuilder();
			char value;
			if (this.oo_0O.O0oo_o.().Checked)
			{
				value = '\t';
			}
			else if (this.O00_0.0o00_.().Checked)
			{
				value = ',';
			}
			else
			{
				if (Operators.CompareString(this.O0o.o.().Text, "", true) == 0)
				{
					MessageBox.Show("请输入列分隔符！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				value = this.O0o.o.().Text.ToCharArray()[0];
			}
			this.Cursor = Cursors.WaitCursor;
			Foxtable.RibbonMenu.StatusBar.Message1 = "正在导出...";
			Application.DoEvents();
			int num = this.O0o.o.().Items.Count - 1;
			for (int i = 1; i <= num; i++)
			{
				if (this.O0o.o.().GetItemChecked(i))
				{
					list.Add(this.O0o.o.().Items[i].ToString());
				}
			}
			if (this.o_o_O0_.O.().Checked)
			{
				int num2 = list.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					stringBuilder.Append(list[j]);
					if (j < list.Count - 1)
					{
						stringBuilder.Append(value);
					}
				}
			}
			int num3 = OO_00oOO.CurrentTable.foxGrid.Rows.Fixed;
			int num4 = OO_00oOO.CurrentTable.foxGrid.Rows.Count - 1;
			if (this.O0o.o.().Checked)
			{
				num3 = OO_00oOO.CurrentTable.foxGrid.Selection.TopRow;
				num4 = OO_00oOO.CurrentTable.foxGrid.Selection.BottomRow;
			}
			int num5 = num3;
			int num6 = num4;
			for (int k = num5; k <= num6; k++)
			{
				if (OO_00oOO.CurrentTable.foxGrid.Rows[k].DataIndex >= 0)
				{
					DataRowView dataRowView = OO_00oOO.CurrentTable.View.O0O_0_0__.0O.(OO_00oOO.CurrentTable.foxGrid.Rows[k].DataIndex);
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append("\r\n");
					}
					int num7 = list.Count - 1;
					for (int l = 0; l <= num7; l++)
					{
						if (!dataRowView.Row.IsNull(list[l]))
						{
							string text = "";
							if (OO_00oOO.CurrentTable.Cols.Contains(list[l]))
							{
								text = OO_00oOO.CurrentTable.foxGrid.Cols[list[l]].Format;
							}
							if (Operators.CompareString(text, "", true) > 0)
							{
								stringBuilder.Append(Strings.Format(RuntimeHelpers.GetObjectValue(dataRowView[list[l]]), text));
							}
							else
							{
								stringBuilder.Append(dataRowView[list[l]].ToString());
							}
						}
						if (l < list.Count - 1)
						{
							stringBuilder.Append(value);
						}
					}
				}
			}
			c.OOOOO.o.().FileSystem.WriteAllText(this.o0_0.0OOO_0Oo., stringBuilder.ToString(), false);
			this.Cursor = Cursors.Default;
			Foxtable.RibbonMenu.StatusBar.Message1 = "";
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x001599A1 File Offset: 0x00157BA1
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O0o.o.().ReadOnly = !this.Oo_.Oo0.().Checked;
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x001599BC File Offset: 0x00157BBC
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001449 RID: 5193
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400144A RID: 5194
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400144B RID: 5195
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400144C RID: 5196
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x0400144D RID: 5197
		[CompilerGenerated]
		private System.Windows.Forms.Label <<EMPTY_NAME>>;

		// Token: 0x0400144E RID: 5198
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400144F RID: 5199
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001450 RID: 5200
		[CompilerGenerated]
		private SaveFileDialog <<EMPTY_NAME>>;

		// Token: 0x04001451 RID: 5201
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001452 RID: 5202
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001453 RID: 5203
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001454 RID: 5204
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001455 RID: 5205
		internal string <<EMPTY_NAME>>;
	}
}
