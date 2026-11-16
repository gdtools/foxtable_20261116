using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Foxtable.Syscmd;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200034D RID: 845
	[DesignerGenerated]
	internal partial class O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000 : Form
	{
		// Token: 0x060033D4 RID: 13268 RVA: 0x0016289C File Offset: 0x00160A9C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o_oO.0o0. != null)
				{
					this.o_oO.0o0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x001628DC File Offset: 0x00160ADC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o_oO.0o0.(new C1FlexGrid());
			this.o_oO.0o0.(new C1Button());
			this.o0_.0o_O0.(new C1Button());
			((ISupportInitialize)this.o_oO.0o0.()).BeginInit();
			base.SuspendLayout();
			this.o_oO.0o0.().ColumnInfo = "10,1,0,0,0,0,Columns:";
			this.o_oO.0o0.().Location = new Point(12, 12);
			this.o_oO.0o0.().Name = "C1FlexGrid1";
			this.o_oO.0o0.().Rows.DefaultSize = 19;
			this.o_oO.0o0.().Size = new Size(481, 231);
			this.o_oO.0o0.().TabIndex = 0;
			this.o_0oOo_OO00.oO.().Location = new Point(328, 258);
			this.o_0oOo_OO00.oO.().Name = "Button1";
			this.o_0oOo_OO00.oO.().Size = new Size(75, 23);
			this.o_0oOo_OO00.oO.().TabIndex = 1;
			this.o_0oOo_OO00.oO.().Text = "确定";
			this.o_0oOo_OO00.oO.().UseVisualStyleBackColor = true;
			this.o_oO.0o0.().Location = new Point(418, 258);
			this.o_oO.0o0.().Name = "Button2";
			this.o_oO.0o0.().Size = new Size(75, 23);
			this.o_oO.0o0.().TabIndex = 2;
			this.o_oO.0o0.().Text = "取消";
			this.o_oO.0o0.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(504, 293);
			base.Controls.Add(this.o_oO.0o0.());
			base.Controls.Add(this.o_0oOo_OO00.oO.());
			base.Controls.Add(this.o_oO.0o0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o...0.O.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "标志列设定";
			((ISupportInitialize)this.o_oO.0o0.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x00162B09 File Offset: 0x00160D09
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.o_oO.0o0.;
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x00162B11 File Offset: 0x00160D11
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.o_oO.0o0. = A_0;
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x00162B1A File Offset: 0x00160D1A
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_oO.0o0.;
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x00162B24 File Offset: 0x00160D24
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.0o0o_OO.);
			C1Button c1Button = this.o_oO.0o0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_oO.0o0. = A_0;
			c1Button = this.o_oO.0o0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x00162B67 File Offset: 0x00160D67
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0_.0o_O0.;
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x00162B70 File Offset: 0x00160D70
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_0oOo_OO00.oO.);
			C1Button c1Button = this.o0_.0o_O0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0_.0o_O0. = A_0;
			c1Button = this.o0_.0o_O0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x00162BB4 File Offset: 0x00160DB4
		public O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000()
		{
			base.Load += this.Oo__O.O.;
			base.FormClosed += this.O.0o0o_OO.;
			this.o_oO.0o0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o_oO.0o0.().Styles.SelectedColumnHeader.Clear();
			this.o_oO.0o0.().Styles.Alternate.Clear();
			this.o_oO.0o0.().Styles.Focus.Clear();
			this.o_oO.0o0.().Styles.Focus.MergeWith(this.o_oO.0o0.().Styles.Normal);
			this.o_oO.0o0.().FocusRect = FocusRectEnum.Solid;
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x00162C78 File Offset: 0x00160E78
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.o_oO.0o0.();
			c1FlexGrid.Cols.Count = 3;
			c1FlexGrid.Cols.Fixed = 0;
			c1FlexGrid.Cols[0].DataType = typeof(string);
			c1FlexGrid.Cols[1].DataType = typeof(bool);
			c1FlexGrid.Cols[2].DataType = typeof(bool);
			c1FlexGrid.Cols[0].Name = "数据表";
			c1FlexGrid.Cols[1].Name = "锁定行标志列";
			c1FlexGrid.Cols[2].Name = "插入行标志列";
			c1FlexGrid.Cols[0].Caption = c1FlexGrid.Cols[0].Name;
			c1FlexGrid.Cols[1].Caption = c1FlexGrid.Cols[1].Name;
			c1FlexGrid.Cols[2].Caption = c1FlexGrid.Cols[2].Name;
			c1FlexGrid.Rows.Count = 1;
			c1FlexGrid.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
			try
			{
				foreach (DataTable dataTable in OO_00oOO.DataTables)
				{
					if (dataTable.frd_IsInnerTable || dataTable.frd_IsOuterTable)
					{
						c1FlexGrid.Rows.Count = c1FlexGrid.Rows.Count + 1;
						c1FlexGrid.Rows[c1FlexGrid.Rows.Count - 1][0] = dataTable.Name;
						if (dataTable.O000_00._0_o.)
						{
							c1FlexGrid.Rows[c1FlexGrid.Rows.Count - 1][1] = true;
						}
						if (Operators.CompareString(dataTable.O_.__0., "", true) > 0 && dataTable.BaseTable.Columns.Contains("_SortKey"))
						{
							c1FlexGrid.Rows[c1FlexGrid.Rows.Count - 1][2] = true;
						}
					}
				}
			}
			finally
			{
				IEnumerator<DataTable> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			c1FlexGrid.Cols[0].Width = 240;
			c1FlexGrid.Cols[1].Width = 110;
			c1FlexGrid.Cols[2].Width = 110;
			c1FlexGrid = null;
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x00162F00 File Offset: 0x00161100
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x00162F08 File Offset: 0x00161108
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.o_oO.0o0.();
			int num = c1FlexGrid.Rows.Count - 1;
			for (int i = 1; i <= num; i++)
			{
				string a_ = c1FlexGrid.Rows[i][0].ToString();
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(c1FlexGrid.Rows[i][1])))
				{
					OO_00oOO.DataTables[a_].OO__O_O._O.();
				}
				else
				{
					OO_00oOO.DataTables[a_].OO0_O_.__O.();
				}
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(c1FlexGrid.Rows[i][2])))
				{
					OO_00oOO.DataTables[a_].OoO0OO.O_00.();
				}
				else
				{
					OO_00oOO.DataTables[a_].Oo.__o0oOOO__o.();
				}
			}
			MessageBox.Show("设置完成，需要重新打开项目才能生效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Project.Open(OO_00oOO.ProjectFile, new string[0]);
			base.Close();
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x00163000 File Offset: 0x00161200
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040014D2 RID: 5330
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040014D3 RID: 5331
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x040014D4 RID: 5332
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014D5 RID: 5333
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
