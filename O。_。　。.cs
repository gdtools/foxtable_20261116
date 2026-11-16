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
	// Token: 0x02000374 RID: 884
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	internal partial class O\u3002_\u3002\u3000\u3002 : Form
	{
		// Token: 0x06003892 RID: 14482 RVA: 0x00193100 File Offset: 0x00191300
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oO_0_0O0.o0__0. != null)
				{
					this.oO_0_0O0.o0__0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003893 RID: 14483 RVA: 0x00193140 File Offset: 0x00191340
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O.o000OO_O0.(new C1Button());
			this.oO_0_0O0.o0__0.(new C1Button());
			this.oO_0_0O0.o0__0.(new C1ComboBox());
			this.oO_0_0O0.o0__0.(new Label());
			base.SuspendLayout();
			this.O____0_0.0OO_0.().DialogResult = DialogResult.Cancel;
			this.O____0_0.0OO_0.().Location = new Point(138, 73);
			this.O____0_0.0OO_0.().Name = "btnCancel";
			this.O____0_0.0OO_0.().Size = new Size(75, 23);
			this.O____0_0.0OO_0.().TabIndex = 12;
			this.O____0_0.0OO_0.().Tag = "";
			this.O____0_0.0OO_0.().Text = "取消";
			this.O____0_0.0OO_0.().UseVisualStyleBackColor = true;
			this.O__.__O_.().Location = new Point(57, 73);
			this.O__.__O_.().Name = "btnOK";
			this.O__.__O_.().Size = new Size(75, 23);
			this.O__.__O_.().TabIndex = 11;
			this.O__.__O_.().Text = "确定";
			this.O__.__O_.().UseVisualStyleBackColor = true;
			this.O__.__O_.().Location = new Point(14, 36);
			this.O__.__O_.().Name = "ComboBox1";
			this.O__.__O_.().Size = new Size(243, 20);
			this.O__.__O_.().TabIndex = 10;
			this.O__.__O_.().AutoSize = true;
			this.O__.__O_.().Location = new Point(14, 15);
			this.O__.__O_.().Name = "Label1";
			this.O__.__O_.().Size = new Size(59, 12);
			this.O__.__O_.().TabIndex = 9;
			this.O__.__O_.().Text = "设置名称:";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(272, 114);
			base.Controls.Add(this.O____0_0.0OO_0.());
			base.Controls.Add(this.O__.__O_.());
			base.Controls.Add(this.O__.__O_.());
			base.Controls.Add(this.O__.__O_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O...0..0";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "保存设置";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x001933C1 File Offset: 0x001915C1
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO_0_0O0.o0__0.;
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x001933C9 File Offset: 0x001915C9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oO_0_0O0.o0__0. = A_0;
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x001933D2 File Offset: 0x001915D2
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.o000OO_O0.;
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x001933DC File Offset: 0x001915DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O__.__O_.);
			C1Button o.o000OO_O0. = this.O.o000OO_O0.;
			if (o.o000OO_O0. != null)
			{
				o.o000OO_O0..Click -= value;
			}
			this.O.o000OO_O0. = A_0;
			o.o000OO_O0. = this.O.o000OO_O0.;
			if (o.o000OO_O0. != null)
			{
				o.o000OO_O0..Click += value;
			}
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x0019341F File Offset: 0x0019161F
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.oO_0_0O0.o0__0.;
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x00193427 File Offset: 0x00191627
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.oO_0_0O0.o0__0. = A_0;
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x00193430 File Offset: 0x00191630
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oO_0_0O0.o0__0.;
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x00193438 File Offset: 0x00191638
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oO_0_0O0.o0__0. = A_0;
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x00193444 File Offset: 0x00191644
		public O\u3002_\u3002\u3000\u3002(Table A_0, string A_1, ExtendTablePropertyTypeEnum A_2)
		{
			base.FormClosed += this.O__.__O_.;
			this.oO_0_0O0.o0__0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.O00O_.__. = A_0;
			this.O00O_.__. = A_1;
			this.O00O_.__. = A_2;
			foreach (DataRow dataRow in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Select("[Table] = '" + A_0.DataTable.Name + "' And [Type] = " + Conversions.ToString((int)A_2), "", DataViewRowState.CurrentRows))
			{
				this.O__.__O_.().Items.Add(dataRow["Name"].ToString());
			}
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x00193510 File Offset: 0x00191710
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.O__.__O_.().Text.Trim(), "", true) != 0)
			{
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()];
				DataRow dataRow = dataTable.Rows.Find(new object[]
				{
					this.O00O_.__..DataTable.Name,
					this.O__.__O_.().Text.Trim(),
					this.O00O_.__.
				});
				if (dataRow == null)
				{
					dataRow = dataTable.NewRow();
					dataRow["Table"] = this.O00O_.__..DataTable.Name;
					dataRow["Type"] = this.O00O_.__.;
					dataRow["Name"] = this.O__.__O_.().Text.Trim();
					dataTable.Rows.Add(dataRow);
				}
				else if (MessageBox.Show("设置" + this.O__.__O_.().Text.Trim() + "已经存在，是否覆盖？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					return;
				}
				dataRow["Property"] = this.O00O_.__.;
				Oo00.o0_o._O_.(dataTable, true);
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x0019364A File Offset: 0x0019184A
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001726 RID: 5926
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001727 RID: 5927
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001728 RID: 5928
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001729 RID: 5929
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x0400172A RID: 5930
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400172B RID: 5931
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400172C RID: 5932
		private ExtendTablePropertyTypeEnum <<EMPTY_NAME>>;

		// Token: 0x0400172D RID: 5933
		private string <<EMPTY_NAME>>;
	}
}
