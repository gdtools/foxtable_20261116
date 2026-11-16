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
	// Token: 0x02000094 RID: 148
	[DesignerGenerated]
	internal partial class o\u3000\u3000\u3002\u30020\u3002\u3002\u3000\u3000\u3002\u3000\u3002 : Form
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x0002E67C File Offset: 0x0002C87C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o._Oo0o_Oo_O_o. != null)
				{
					this.o._Oo0o_Oo_O_o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0002E6BC File Offset: 0x0002C8BC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o._o_o.(new C1ComboBox());
			this.ooo.0_0_oOOo_.(new C1TextBox());
			this.o._o_o.(new C1Button());
			this.oO_o.0O0OO__o.(new C1Button());
			this.oo0_0Oo_.0o.(new Label());
			this.o._o_o.(new Label());
			this.oO_o.0O0OO__o.(new Label());
			this.O0._OoOoO.(new C1TextBox());
			base.SuspendLayout();
			this.O0oO0_O0.O.().Location = new Point(12, 32);
			this.O0oO0_O0.O.().Name = "cmbCategory";
			this.O0oO0_O0.O.().Size = new Size(239, 20);
			this.O0oO0_O0.O.().TabIndex = 0;
			this.oO_o.0O0OO__o.().Location = new Point(12, 80);
			this.oO_o.0O0OO__o.().Multiline = true;
			this.oO_o.0O0OO__o.().Name = "txtCode";
			this.oO_o.0O0OO__o.().ScrollBars = ScrollBars.Vertical;
			this.oO_o.0O0OO__o.().Size = new Size(497, 280);
			this.oO_o.0O0OO__o.().TabIndex = 2;
			this.o_00.0O_0.().Location = new Point(178, 369);
			this.o_00.0O_0.().Name = "Button1";
			this.o_00.0O_0.().Size = new Size(75, 23);
			this.o_00.0O_0.().TabIndex = 3;
			this.o_00.0O_0.().Text = "确定";
			this.o_00.0O_0.().UseVisualStyleBackColor = true;
			this.O0oO0_O0.O.().Location = new Point(269, 369);
			this.O0oO0_O0.O.().Name = "Button2";
			this.O0oO0_O0.O.().Size = new Size(75, 23);
			this.O0oO0_O0.O.().TabIndex = 4;
			this.O0oO0_O0.O.().Text = "取消";
			this.O0oO0_O0.O.().UseVisualStyleBackColor = true;
			this.O0oO0_O0.O.().AutoSize = true;
			this.O0oO0_O0.O.().Location = new Point(12, 12);
			this.O0oO0_O0.O.().Name = "Label1";
			this.O0oO0_O0.O.().Size = new Size(35, 12);
			this.O0oO0_O0.O.().TabIndex = 4;
			this.O0oO0_O0.O.().Text = "目录:";
			this.o_00.0O_0.().AutoSize = true;
			this.o_00.0O_0.().Location = new Point(268, 12);
			this.o_00.0O_0.().Name = "Label2";
			this.o_00.0O_0.().Size = new Size(35, 12);
			this.o_00.0O_0.().TabIndex = 6;
			this.o_00.0O_0.().Text = "名称:";
			this.oo0_0Oo_.0o.().AutoSize = true;
			this.oo0_0Oo_.0o.().Location = new Point(12, 60);
			this.oo0_0Oo_.0o.().Name = "Label3";
			this.oo0_0Oo_.0o.().Size = new Size(35, 12);
			this.oo0_0Oo_.0o.().TabIndex = 7;
			this.oo0_0Oo_.0o.().Text = "代码:";
			this.o._o_o.().Location = new Point(270, 32);
			this.o._o_o.().Name = "txtName";
			this.o._o_o.().Size = new Size(239, 21);
			this.o._o_o.().TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(522, 401);
			base.Controls.Add(this.o._o_o.());
			base.Controls.Add(this.oo0_0Oo_.0o.());
			base.Controls.Add(this.o_00.0O_0.());
			base.Controls.Add(this.O0oO0_O0.O.());
			base.Controls.Add(this.O0oO0_O0.O.());
			base.Controls.Add(this.o_00.0O_0.());
			base.Controls.Add(this.oO_o.0O0OO__o.());
			base.Controls.Add(this.O0oO0_O0.O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O0...O..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "代码管理";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0002EB0F File Offset: 0x0002CD0F
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O0._OoOoO.;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0002EB17 File Offset: 0x0002CD17
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.O0._OoOoO. = A_0;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0002EB20 File Offset: 0x0002CD20
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O0._OoOoO.;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0002EB28 File Offset: 0x0002CD28
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O0._OoOoO. = A_0;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0002EB31 File Offset: 0x0002CD31
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0._OoOoO.;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0002EB3C File Offset: 0x0002CD3C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0oO0_O0.O.);
			C1Button o0._OoOoO. = this.O0._OoOoO.;
			if (o0._OoOoO. != null)
			{
				o0._OoOoO..Click -= value;
			}
			this.O0._OoOoO. = A_0;
			o0._OoOoO. = this.O0._OoOoO.;
			if (o0._OoOoO. != null)
			{
				o0._OoOoO..Click += value;
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0002EB7F File Offset: 0x0002CD7F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooo.0_0_oOOo_.;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0002EB88 File Offset: 0x0002CD88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_00.0O_0.);
			C1Button c1Button = this.ooo.0_0_oOOo_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooo.0_0_oOOo_. = A_0;
			c1Button = this.ooo.0_0_oOOo_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0002EBCB File Offset: 0x0002CDCB
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0._OoOoO.;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0002EBD3 File Offset: 0x0002CDD3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0._OoOoO. = A_0;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0002EBDC File Offset: 0x0002CDDC
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.ooo.0_0_oOOo_.;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0002EBE4 File Offset: 0x0002CDE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.ooo.0_0_oOOo_. = A_0;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0002EBED File Offset: 0x0002CDED
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0O.__.;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0002EBF5 File Offset: 0x0002CDF5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0O.__. = A_0;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0002EBFE File Offset: 0x0002CDFE
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.ooo.0_0_oOOo_.;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0002EC06 File Offset: 0x0002CE06
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.ooo.0_0_oOOo_. = A_0;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0002EC10 File Offset: 0x0002CE10
		public o\u3000\u3000\u3002\u30020\u3002\u3002\u3000\u3000\u3002\u3000\u3002(DataRow A_0)
		{
			base.FormClosed += this.O0oO0_O0.O.;
			this.o._o_o.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o._Oo0o_Oo_O_o. = A_0;
			this.O0oO0_O0.O.().Value = A_0["Category"].ToString();
			this.o._o_o.().Value = A_0["Name"].ToString();
			this.oO_o.0O0OO__o.().Value = A_0["Code"].ToString();
			List<string> list = Oo00.O____0O._0.(A_0.Table, "", "", "Category");
			try
			{
				foreach (string value in list)
				{
					this.O0oO0_O0.O.().Items.Add(value);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0002ED10 File Offset: 0x0002CF10
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0002ED1C File Offset: 0x0002CF1C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o._Oo0o_Oo_O_o.["Category"] = this.O0oO0_O0.O.().Text.Trim();
			this.o._Oo0o_Oo_O_o.["Name"] = this.o._o_o.().Text.Trim();
			this.o._Oo0o_Oo_O_o.["Code"] = this.oO_o.0O0OO__o.().Text;
			if (Operators.CompareString(this.o._Oo0o_Oo_O_o.["Code"].ToString(), "", true) == 0 || Operators.CompareString(this.o._Oo0o_Oo_O_o.["Name"].ToString(), "", true) == 0 || Operators.CompareString(this.o._Oo0o_Oo_O_o.["Code"].ToString(), "", true) == 0)
			{
				MessageBox.Show("请输入分类、名称和代码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (this.o._Oo0o_Oo_O_o..RowState == DataRowState.Detached)
			{
				this.o._Oo0o_Oo_O_o..Table.Rows.Add(this.o._Oo0o_Oo_O_o.);
			}
			Oo00.O0Oo_O.0O_0O.(this.o._Oo0o_Oo_O_o.);
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0002EE39 File Offset: 0x0002D039
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400016E RID: 366
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400016F RID: 367
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000170 RID: 368
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000171 RID: 369
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000172 RID: 370
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000173 RID: 371
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000174 RID: 372
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000175 RID: 373
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000176 RID: 374
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000177 RID: 375
		private DataRow <<EMPTY_NAME>>;
	}
}
