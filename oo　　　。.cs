using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200038B RID: 907
	[DesignerGenerated]
	internal partial class oo\u3000\u3000\u3000\u3002 : Form
	{
		// Token: 0x06003B0F RID: 15119 RVA: 0x001A9F0C File Offset: 0x001A810C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o_00oO.0. != null)
				{
					this.o_00oO.0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x001A9F4C File Offset: 0x001A814C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o_00oO.0.(new CheckedListBox());
			this.oOOO.0o.(new Label());
			this.oOOO.0o.(new C1Button());
			this.o.O0_O_o.(new C1Button());
			this.o_00oO.0.(new Label());
			base.SuspendLayout();
			this.o.O0_O_o.().CheckOnClick = true;
			this.o.O0_O_o.().FormattingEnabled = true;
			this.o.O0_O_o.().Location = new Point(12, 35);
			this.o.O0_O_o.().Name = "lstTables";
			this.o.O0_O_o.().Size = new Size(241, 260);
			this.o.O0_O_o.().TabIndex = 0;
			this.o.O0_O_o.().AutoSize = true;
			this.o.O0_O_o.().Location = new Point(12, 14);
			this.o.O0_O_o.().Name = "Label1";
			this.o.O0_O_o.().Size = new Size(119, 12);
			this.o.O0_O_o.().TabIndex = 1;
			this.o.O0_O_o.().Text = "请选择要初始化的表:";
			this.Oo0.0000o00__o.().Location = new Point(265, 32);
			this.Oo0.0000o00__o.().Name = "btnOk";
			this.Oo0.0000o00__o.().Size = new Size(75, 23);
			this.Oo0.0000o00__o.().TabIndex = 2;
			this.Oo0.0000o00__o.().Text = "确定";
			this.Oo0.0000o00__o.().UseVisualStyleBackColor = true;
			this.o.O0_O_o.().DialogResult = DialogResult.Cancel;
			this.o.O0_O_o.().Location = new Point(265, 61);
			this.o.O0_O_o.().Name = "btnCancel";
			this.o.O0_O_o.().Size = new Size(75, 23);
			this.o.O0_O_o.().TabIndex = 3;
			this.o.O0_O_o.().Text = "取消";
			this.o.O0_O_o.().UseVisualStyleBackColor = true;
			this.Oo0.0000o00__o.().AutoSize = true;
			this.Oo0.0000o00__o.().Location = new Point(12, 304);
			this.Oo0.0000o00__o.().Name = "Label2";
			this.Oo0.0000o00__o.().Size = new Size(251, 12);
			this.Oo0.0000o00__o.().TabIndex = 4;
			this.Oo0.0000o00__o.().Text = "提示:初始化将直接从后台清除表中所有数据。";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(352, 328);
			base.Controls.Add(this.Oo0.0000o00__o.());
			base.Controls.Add(this.o.O0_O_o.());
			base.Controls.Add(this.Oo0.0000o00__o.());
			base.Controls.Add(this.o.O0_O_o.());
			base.Controls.Add(this.o.O0_O_o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O..0..o.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "初始化项目";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x001AA263 File Offset: 0x001A8463
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.o_00oO.0.;
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x001AA26B File Offset: 0x001A846B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			this.o_00oO.0. = A_0;
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x001AA274 File Offset: 0x001A8474
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_00oO.0.;
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x001AA27C File Offset: 0x001A847C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_00oO.0. = A_0;
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x001AA285 File Offset: 0x001A8485
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_00oO.0.;
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x001AA290 File Offset: 0x001A8490
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o000__OO._.);
			C1Button c1Button = this.o_00oO.0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_00oO.0. = A_0;
			c1Button = this.o_00oO.0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x001AA2D3 File Offset: 0x001A84D3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOOO.0o.;
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x001AA2DB File Offset: 0x001A84DB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oOOO.0o. = A_0;
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x001AA2E4 File Offset: 0x001A84E4
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oOOO.0o.;
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x001AA2EC File Offset: 0x001A84EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oOOO.0o. = A_0;
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x001AA2F8 File Offset: 0x001A84F8
		public oo\u3000\u3000\u3000\u3002()
		{
			base.Load += this.Oo0.0000o00__o.;
			base.FormClosed += this.o.O0_O_o.;
			this.o.O0_O_o.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x001AA34C File Offset: 0x001A854C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (DataTable dataTable in OO_00oOO.DataTables)
				{
					if ((dataTable.frd_IsInnerTable || dataTable.frd_IsOuterTable) && dataTable.AllowInitialize)
					{
						this.o.O0_O_o.().Items.Add(dataTable.Name);
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
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x001AA3C0 File Offset: 0x001A85C0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OO_00oOO.DataTables.Save();
			int num = this.o.O0_O_o.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (this.o.O0_O_o.().GetItemChecked(i))
				{
					DataTable dataTable = OO_00oOO.DataTables[this.o.O0_O_o.().Items[i].ToString()];
					if (MessageBox.Show("[" + dataTable.Name + "]的所有数据将被清除，且不可恢复，是否确定要执行？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					{
						return;
					}
					dataTable.DataRows.Clear(false);
				}
				OO_00oOO.CompactAccessFile(OO_00oOO.ProjectFile, O_O0OO.oO_00Ooo___0._., true);
			}
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x001AA46F File Offset: 0x001A866F
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400183D RID: 6205
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400183E RID: 6206
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x0400183F RID: 6207
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001840 RID: 6208
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001841 RID: 6209
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001842 RID: 6210
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;
	}
}
