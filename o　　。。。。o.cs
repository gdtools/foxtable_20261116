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
	// Token: 0x0200035B RID: 859
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal partial class o\u3000\u3000\u3002\u3002\u3002\u3002o : Form
	{
		// Token: 0x0600358A RID: 13706 RVA: 0x00172AE0 File Offset: 0x00170CE0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.Oo0___.o000_. != null)
				{
					this.Oo0___.o000_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00172B20 File Offset: 0x00170D20
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O0oo_o0oo0._.(new C1Button());
			this.O0___Oo.O_00o.(new C1Button());
			this.OO0O__00o00O._.(new C1Button());
			this.Oo0___.o000_.(new C1Button());
			this.Oo0___.o000_.(new ListBox());
			base.SuspendLayout();
			this.o.OO0Oo_0.().Location = new Point(197, 170);
			this.o.OO0Oo_0.().Name = "btnOk";
			this.o.OO0Oo_0.().Size = new Size(75, 23);
			this.o.OO0Oo_0.().TabIndex = 14;
			this.o.OO0Oo_0.().Text = "确定";
			this.o.OO0Oo_0.().UseVisualStyleBackColor = true;
			this.OO0O__00o00O._.().Location = new Point(197, 199);
			this.OO0O__00o00O._.().Name = "btnCancel";
			this.OO0O__00o00O._.().Size = new Size(75, 23);
			this.OO0O__00o00O._.().TabIndex = 13;
			this.OO0O__00o00O._.().Text = "取消";
			this.OO0O__00o00O._.().UseVisualStyleBackColor = true;
			this.O.oO_.().Location = new Point(197, 43);
			this.O.oO_.().Name = "btnDelete";
			this.O.oO_.().Size = new Size(75, 23);
			this.O.oO_.().TabIndex = 12;
			this.O.oO_.().Text = "删除";
			this.O.oO_.().UseVisualStyleBackColor = true;
			this.O0___Oo.O_00o.().Location = new Point(197, 14);
			this.O0___Oo.O_00o.().Name = "btnRename";
			this.O0___Oo.O_00o.().Size = new Size(75, 23);
			this.O0___Oo.O_00o.().TabIndex = 11;
			this.O0___Oo.O_00o.().Text = "重命名";
			this.O0___Oo.O_00o.().UseVisualStyleBackColor = true;
			this.O.oO_.().FormattingEnabled = true;
			this.O.oO_.().ItemHeight = 12;
			this.O.oO_.().Location = new Point(13, 14);
			this.O.oO_.().Name = "ListBox1";
			this.O.oO_.().Size = new Size(169, 208);
			this.O.oO_.().TabIndex = 10;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(285, 236);
			base.Controls.Add(this.o.OO0Oo_0.());
			base.Controls.Add(this.OO0O__00o00O._.());
			base.Controls.Add(this.O.oO_.());
			base.Controls.Add(this.O0___Oo.O_00o.());
			base.Controls.Add(this.O.oO_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.....O.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "设置管理";
			base.ResumeLayout(false);
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00172E31 File Offset: 0x00171031
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo0___.o000_.;
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00172E3C File Offset: 0x0017103C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O__oo.0.);
			C1Button oo0___.o000_. = this.Oo0___.o000_.;
			if (oo0___.o000_. != null)
			{
				oo0___.o000_..Click -= value;
			}
			this.Oo0___.o000_. = A_0;
			oo0___.o000_. = this.Oo0___.o000_.;
			if (oo0___.o000_. != null)
			{
				oo0___.o000_..Click += value;
			}
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x00172E7F File Offset: 0x0017107F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0o_.O.;
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x00172E88 File Offset: 0x00171088
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_Oo00oo.Ooo.);
			C1Button c1Button = this.o0o_.O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0o_.O. = A_0;
			c1Button = this.o0o_.O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00172ECB File Offset: 0x001710CB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o__o.0_O_O__O_.;
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00172ED4 File Offset: 0x001710D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_.o_.);
			C1Button c1Button = this.o__o.0_O_O__O_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o__o.0_O_O__O_. = A_0;
			c1Button = this.o__o.0_O_O__O_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00172F17 File Offset: 0x00171117
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0oo_o0oo0._.;
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x00172F20 File Offset: 0x00171120
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo_oOoOO_oo0.0.);
			C1Button o0oo_o0oo0._. = this.O0oo_o0oo0._.;
			if (o0oo_o0oo0._. != null)
			{
				o0oo_o0oo0._..Click -= value;
			}
			this.O0oo_o0oo0._. = A_0;
			o0oo_o0oo0._. = this.O0oo_o0oo0._.;
			if (o0oo_o0oo0._. != null)
			{
				o0oo_o0oo0._..Click += value;
			}
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x00172F63 File Offset: 0x00171163
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.Oo0___.o000_.;
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x00172F6B File Offset: 0x0017116B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.Oo0___.o000_. = A_0;
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x00172F74 File Offset: 0x00171174
		public o\u3000\u3000\u3002\u3002\u3002\u3002o(Table A_0, ExtendTablePropertyTypeEnum A_1)
		{
			base.FormClosed += this.O.oO_.;
			this.O__0O.OO0Oo. = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
			this.O.oO_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.O__0O.OO0Oo. = A_0;
			this.O__0O.OO0Oo. = A_1;
			this.O__0O.OO0Oo. = new DataView(this.O__0O.OO0Oo., "[Table] = '" + A_0.DataTable.Name + "' And [Type] = " + Conversions.ToString((int)A_1), "", DataViewRowState.CurrentRows);
			this.O__0O.OO0Oo. = (CurrencyManager)this.BindingContext[this.O__0O.OO0Oo.];
			this.O.oO_.().DataSource = this.O__0O.OO0Oo.;
			this.O.oO_.().DisplayMember = "Name";
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x00173051 File Offset: 0x00171251
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O__0O.OO0Oo..Position >= 0)
			{
				((DataRowView)this.O__0O.OO0Oo..Current).Delete();
			}
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x00173078 File Offset: 0x00171278
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O__0O.OO0Oo..Position >= 0)
			{
				o\u3000\u3000 o_u3000_u = new o\u3000\u3000("重命名", "请输入新的名称:", Conversions.ToString(((DataRowView)this.O__0O.OO0Oo..Current)["Name"]));
				o_u3000_u.Oo.__0o_0_Oo.(new o\u3000\u3000.ooOOO_O_Oo_0(this.Oo0___.o000_.));
				if (o_u3000_u.ShowDialog() == DialogResult.OK)
				{
					((DataRowView)this.O__0O.OO0Oo..Current)["Name"] = o_u3000_u.Value;
					((DataRowView)this.O__0O.OO0Oo..Current).EndEdit();
				}
			}
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x00173114 File Offset: 0x00171314
		private void <<EMPTY_NAME>>(o\u3000\u3000 A_0, ValidateInputTextEventArgs A_1)
		{
			if (Operators.CompareString(A_1.Value, "", true) == 0)
			{
				MessageBox.Show("请输入设置名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
				return;
			}
			if (Operators.CompareString(A_1.Value, A_1.OriginalValue, true) != 0 && this.O__0O.OO0Oo..Rows.Find(new object[]
			{
				this.O__0O.OO0Oo..DataTable.Name,
				A_1.Value,
				ExtendTablePropertyTypeEnum.CrossTable
			}) != null)
			{
				MessageBox.Show("已经存在同名设置，请输入其它名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
			}
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x001731BA File Offset: 0x001713BA
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Oo00.o0_o._O_.(this.O__0O.OO0Oo., true);
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x001731CF File Offset: 0x001713CF
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O__0O.OO0Oo..RejectChanges();
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x001731E3 File Offset: 0x001713E3
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001592 RID: 5522
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001593 RID: 5523
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001594 RID: 5524
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001595 RID: 5525
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001596 RID: 5526
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001597 RID: 5527
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x04001598 RID: 5528
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04001599 RID: 5529
		private DataView <<EMPTY_NAME>>;

		// Token: 0x0400159A RID: 5530
		private CurrencyManager <<EMPTY_NAME>>;

		// Token: 0x0400159B RID: 5531
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400159C RID: 5532
		private ExtendTablePropertyTypeEnum <<EMPTY_NAME>>;
	}
}
