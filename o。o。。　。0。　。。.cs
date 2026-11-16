using System;
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
	// Token: 0x0200037B RID: 891
	[DesignerGenerated]
	internal partial class o\u3002o\u3002\u3002\u3000\u30020\u3002\u3000\u3002\u3002\u3000 : Form
	{
		// Token: 0x0600393D RID: 14653 RVA: 0x00199700 File Offset: 0x00197900
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o0_O.o_. != null)
				{
					this.o0_O.o_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x00199740 File Offset: 0x00197940
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0_O.o_.(new ListBox());
			this.O0ooO.o_O.(new C1Button());
			this.o_oO0o.o.(new C1Button());
			this.O0_O.oO_ooo.(new C1Button());
			this.o__o.0.(new C1Button());
			base.SuspendLayout();
			this.O0ooO.o_O.().FormattingEnabled = true;
			this.O0ooO.o_O.().ItemHeight = 12;
			this.O0ooO.o_O.().Location = new Point(12, 12);
			this.O0ooO.o_O.().Name = "ListBox1";
			this.O0ooO.o_O.().Size = new Size(169, 208);
			this.O0ooO.o_O.().TabIndex = 0;
			this.O0_O.oO_ooo.().Location = new Point(196, 12);
			this.O0_O.oO_ooo.().Name = "btnRename";
			this.O0_O.oO_ooo.().Size = new Size(75, 23);
			this.O0_O.oO_ooo.().TabIndex = 1;
			this.O0_O.oO_ooo.().Text = "重命名";
			this.O0_O.oO_ooo.().UseVisualStyleBackColor = true;
			this.O0ooO.o_O.().Location = new Point(196, 41);
			this.O0ooO.o_O.().Name = "btnDelete";
			this.O0ooO.o_O.().Size = new Size(75, 23);
			this.O0ooO.o_O.().TabIndex = 2;
			this.O0ooO.o_O.().Text = "删除";
			this.O0ooO.o_O.().UseVisualStyleBackColor = true;
			this.o_oO0o.o.().Location = new Point(196, 197);
			this.o_oO0o.o.().Name = "btnCancel";
			this.o_oO0o.o.().Size = new Size(75, 23);
			this.o_oO0o.o.().TabIndex = 3;
			this.o_oO0o.o.().Text = "取消";
			this.o_oO0o.o.().UseVisualStyleBackColor = true;
			this.o__o.0.().Location = new Point(196, 168);
			this.o__o.0.().Name = "btnOk";
			this.o__o.0.().Size = new Size(75, 23);
			this.o__o.0.().TabIndex = 4;
			this.o__o.0.().Text = "确定";
			this.o__o.0.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(281, 236);
			base.Controls.Add(this.o__o.0.());
			base.Controls.Add(this.o_oO0o.o.());
			base.Controls.Add(this.O0ooO.o_O.());
			base.Controls.Add(this.O0_O.oO_ooo.());
			base.Controls.Add(this.O0ooO.o_O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oO..o...";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "表视图管理";
			base.ResumeLayout(false);
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x00199A45 File Offset: 0x00197C45
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.o0_O.o_.;
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x00199A4D File Offset: 0x00197C4D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.o0_O.o_. = A_0;
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x00199A56 File Offset: 0x00197C56
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0_O.o_.;
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x00199A60 File Offset: 0x00197C60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Ooo_._.);
			C1Button c1Button = this.o0_O.o_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0_O.o_. = A_0;
			c1Button = this.o0_O.o_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x00199AA3 File Offset: 0x00197CA3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.oOo_0.;
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x00199AAC File Offset: 0x00197CAC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo._Oooo_.);
			C1Button o.oOo_0. = this.O.oOo_0.;
			if (o.oOo_0. != null)
			{
				o.oOo_0..Click -= value;
			}
			this.O.oOo_0. = A_0;
			o.oOo_0. = this.O.oOo_0.;
			if (o.oOo_0. != null)
			{
				o.oOo_0..Click += value;
			}
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x00199AEF File Offset: 0x00197CEF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_Oo.O_o0_00_O.;
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x00199AF8 File Offset: 0x00197CF8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOO._.);
			C1Button c1Button = this.o_Oo.O_o0_00_O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_Oo.O_o0_00_O. = A_0;
			c1Button = this.o_Oo.O_o0_00_O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x00199B3B File Offset: 0x00197D3B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0.00_00.;
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x00199B44 File Offset: 0x00197D44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOo.o0ooO0O_O.);
			C1Button c1Button = this.o0.00_00.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0.00_00. = A_0;
			c1Button = this.o0.00_00.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x00199B88 File Offset: 0x00197D88
		public o\u3002o\u3002\u3002\u3000\u30020\u3002\u3000\u3002\u3002\u3000(Table A_0)
		{
			base.FormClosed += this.OoOO._.;
			this.O00oO0_.O. = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
			this.O0ooO.o_O.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.O00oO0_.O. = A_0;
			this.o0_O.o_. = new DataView(this.O00oO0_.O., "[Table] = '" + A_0.DataTable.Name + "' And [Type] = " + Conversions.ToString(0), "", DataViewRowState.CurrentRows);
			this.o0_O.o_. = (CurrencyManager)this.BindingContext[this.o0_O.o_.];
			this.O0ooO.o_O.().DataSource = this.o0_O.o_.;
			this.O0ooO.o_O.().DisplayMember = "Name";
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x00199C5E File Offset: 0x00197E5E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o0_O.o_..Position >= 0)
			{
				((DataRowView)this.o0_O.o_..Current).Delete();
			}
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x00199C84 File Offset: 0x00197E84
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o0_O.o_..Position >= 0)
			{
				o\u3000\u3000 o_u3000_u = new o\u3000\u3000("重命名", "请输入视图名称:", Conversions.ToString(((DataRowView)this.o0_O.o_..Current)["Name"]));
				o_u3000_u.Oo.__0o_0_Oo.(new o\u3000\u3000.ooOOO_O_Oo_0(this.o0_O.o_.));
				if (o_u3000_u.ShowDialog() == DialogResult.OK)
				{
					((DataRowView)this.o0_O.o_..Current)["Name"] = o_u3000_u.Value;
					((DataRowView)this.o0_O.o_..Current).EndEdit();
				}
			}
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x00199D20 File Offset: 0x00197F20
		private void <<EMPTY_NAME>>(o\u3000\u3000 A_0, ValidateInputTextEventArgs A_1)
		{
			if (Operators.CompareString(A_1.Value, "", true) == 0)
			{
				MessageBox.Show("请输入视图名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
				return;
			}
			if (Operators.CompareString(A_1.Value, A_1.OriginalValue, true) != 0 && this.O00oO0_.O..Rows.Find(new object[]
			{
				this.O00oO0_.O..DataTable.Name,
				A_1.Value,
				ExtendTablePropertyTypeEnum.View
			}) != null)
			{
				MessageBox.Show("已经存在同名视图，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
			}
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x00199DC6 File Offset: 0x00197FC6
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Oo00.o0_o._O_.(this.O00oO0_.O., true);
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x00199DDB File Offset: 0x00197FDB
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O00oO0_.O..RejectChanges();
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x00199DEF File Offset: 0x00197FEF
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400176F RID: 5999
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001770 RID: 6000
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x04001771 RID: 6001
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001772 RID: 6002
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001773 RID: 6003
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001774 RID: 6004
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001775 RID: 6005
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04001776 RID: 6006
		private DataView <<EMPTY_NAME>>;

		// Token: 0x04001777 RID: 6007
		private CurrencyManager <<EMPTY_NAME>>;

		// Token: 0x04001778 RID: 6008
		private Table <<EMPTY_NAME>>;
	}
}
