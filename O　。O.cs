using System;
using System.Collections;
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
	// Token: 0x0200037F RID: 895
	[DesignerGenerated]
	internal partial class O\u3000\u3002O : Form
	{
		// Token: 0x060039B4 RID: 14772 RVA: 0x0019D1F4 File Offset: 0x0019B3F4
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_.0O0000_ooo. != null)
				{
					this.O_.0O0000_ooo..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x0019D234 File Offset: 0x0019B434
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O._0_O00.(new Label());
			this.O._0_O00.(new C1TextBox());
			this.O._0_O00.(new C1Button());
			this.O0O_0oo.o.(new C1Button());
			base.SuspendLayout();
			this.O._0_O00.().AutoSize = true;
			this.O._0_O00.().Location = new Point(12, 12);
			this.O._0_O00.().Name = "Label1";
			this.O._0_O00.().Size = new Size(179, 12);
			this.O._0_O00.().TabIndex = 0;
			this.O._0_O00.().Text = "请输入用户分组名称，每行一个:";
			this.O._0_O00.().Location = new Point(14, 30);
			this.O._0_O00.().Multiline = true;
			this.O._0_O00.().Name = "TextBox1";
			this.O._0_O00.().Size = new Size(277, 238);
			this.O._0_O00.().TabIndex = 1;
			this.o__oOO.oO.().DialogResult = DialogResult.OK;
			this.o__oOO.oO.().Location = new Point(74, 285);
			this.o__oOO.oO.().Name = "Button1";
			this.o__oOO.oO.().Size = new Size(75, 23);
			this.o__oOO.oO.().TabIndex = 2;
			this.o__oOO.oO.().Text = "确定";
			this.o__oOO.oO.().UseVisualStyleBackColor = true;
			this.Oo__0o0O._.().DialogResult = DialogResult.Cancel;
			this.Oo__0o0O._.().Location = new Point(155, 285);
			this.Oo__0o0O._.().Name = "Button2";
			this.Oo__0o0O._.().Size = new Size(75, 23);
			this.Oo__0o0O._.().TabIndex = 3;
			this.Oo__0o0O._.().Text = "取消";
			this.Oo__0o0O._.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(305, 322);
			base.Controls.Add(this.Oo__0o0O._.());
			base.Controls.Add(this.o__oOO.oO.());
			base.Controls.Add(this.O._0_O00.());
			base.Controls.Add(this.O._0_O00.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o0...o..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "预定义用户分组";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x0019D4CF File Offset: 0x0019B6CF
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O._0_O00.;
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x0019D4D7 File Offset: 0x0019B6D7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O._0_O00. = A_0;
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x0019D4E0 File Offset: 0x0019B6E0
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O_.0O0000_ooo.;
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x0019D4E8 File Offset: 0x0019B6E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.O_.0O0000_ooo. = A_0;
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x0019D4F1 File Offset: 0x0019B6F1
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O._0_O00.;
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x0019D4FC File Offset: 0x0019B6FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo__0o0O._.);
			C1Button o._0_O00. = this.O._0_O00.;
			if (o._0_O00. != null)
			{
				o._0_O00..Click -= value;
			}
			this.O._0_O00. = A_0;
			o._0_O00. = this.O._0_O00.;
			if (o._0_O00. != null)
			{
				o._0_O00..Click += value;
			}
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x0019D53F File Offset: 0x0019B73F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0O_0oo.o.;
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x0019D547 File Offset: 0x0019B747
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O0O_0oo.o. = A_0;
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x0019D550 File Offset: 0x0019B750
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (object obj in this.O_.0O0000_ooo..Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (!dataRow.IsNull("Type") && Conversions.ToInteger(dataRow["Type"]) == (int)this.O_.0O0000_ooo.)
					{
						this.O_.0O0000_ooo. = dataRow;
						break;
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
			if (this.O_.0O0000_ooo. == null)
			{
				this.O_.0O0000_ooo. = this.O_.0O0000_ooo..NewRow();
				this.O_.0O0000_ooo.["Name"] = Enum.GetName(typeof(UserTypeEnum), this.O_.0O0000_ooo.);
				this.O_.0O0000_ooo.["Type"] = this.O_.0O0000_ooo.;
				this.O_.0O0000_ooo..Rows.Add(this.O_.0O0000_ooo.);
			}
			if (!this.O_.0O0000_ooo..IsNull("Config"))
			{
				this.O._0_O00.().Value = Conversions.ToString(this.O_.0O0000_ooo.["Config"]);
			}
			if (this.O_.0O0000_ooo. == UserTypeEnum.Roles)
			{
				this.Text = "预定义用户角色";
				this.O._0_O00.().Text = "请输入用户角色，每行一个:";
			}
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x0019D6A4 File Offset: 0x0019B8A4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_.0O0000_ooo.["Config"] = this.O._0_O00.().Text.Trim();
			Oo00.o0_o._O_.(this.O_.0O0000_ooo., true);
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x0019D6D4 File Offset: 0x0019B8D4
		public O\u3000\u3002O(UserTypeEnum A_0, DataTable A_1)
		{
			base.Load += this.o__oOO.oO.;
			base.FormClosed += this.Oo__0o0O._.;
			this.O_.0O0000_ooo. = null;
			this.O._0_O00.();
			this.O_.0O0000_ooo. = A_0;
			this.O_.0O0000_ooo. = A_1;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x060039C1 RID: 14785 RVA: 0x0019D73B File Offset: 0x0019B93B
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040017A5 RID: 6053
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040017A6 RID: 6054
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040017A7 RID: 6055
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040017A8 RID: 6056
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017A9 RID: 6057
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040017AA RID: 6058
		private UserTypeEnum <<EMPTY_NAME>>;

		// Token: 0x040017AB RID: 6059
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x040017AC RID: 6060
		private DataRow <<EMPTY_NAME>>;
	}
}
