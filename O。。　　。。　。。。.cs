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
	// Token: 0x02000063 RID: 99
	[DesignerGenerated]
	internal partial class O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002 : Form
	{
		// Token: 0x06000358 RID: 856 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O_O.0. != null)
				{
					this.O_O.0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000C010 File Offset: 0x0000A210
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o_OO._.(new C1Button());
			this.O__O.Oo.(new C1Button());
			this.O__O.Oo.(new C1ComboBox());
			this.o_OO._.(new C1ComboBox());
			this.O__O.Oo.(new Label());
			this.o_OO._.(new Label());
			base.SuspendLayout();
			this.OO.__oOooo0o_.().Location = new Point(60, 95);
			this.OO.__oOooo0o_.().Name = "Button1";
			this.OO.__oOooo0o_.().Size = new Size(75, 23);
			this.OO.__oOooo0o_.().TabIndex = 0;
			this.OO.__oOooo0o_.().Text = "确定";
			this.OO.__oOooo0o_.().UseVisualStyleBackColor = true;
			this.O0OO.o00O00o.().DialogResult = DialogResult.Cancel;
			this.O0OO.o00O00o.().Location = new Point(141, 95);
			this.O0OO.o00O00o.().Name = "Button2";
			this.O0OO.o00O00o.().Size = new Size(75, 23);
			this.O0OO.o00O00o.().TabIndex = 1;
			this.O0OO.o00O00o.().Text = "取消";
			this.O0OO.o00O00o.().UseVisualStyleBackColor = true;
			this.OO.__oOooo0o_.().DropDownStyle = DropDownStyle.DropDownList;
			this.OO.__oOooo0o_.().Location = new Point(68, 20);
			this.OO.__oOooo0o_.().Name = "ComboBox1";
			this.OO.__oOooo0o_.().Size = new Size(171, 20);
			this.OO.__oOooo0o_.().TabIndex = 2;
			this.o_OO._.().DropDownStyle = DropDownStyle.DropDownList;
			this.o_OO._.().Location = new Point(68, 47);
			this.o_OO._.().Name = "ComboBox2";
			this.o_OO._.().Size = new Size(171, 20);
			this.o_OO._.().TabIndex = 3;
			this.o_OO._.().AutoSize = true;
			this.o_OO._.().Location = new Point(15, 24);
			this.o_OO._.().Name = "Label1";
			this.o_OO._.().Size = new Size(47, 12);
			this.o_OO._.().TabIndex = 4;
			this.o_OO._.().Text = "选择表:";
			this.O__O.Oo.().AutoSize = true;
			this.O__O.Oo.().Location = new Point(15, 51);
			this.O__O.Oo.().Name = "Label2";
			this.O__O.Oo.().Size = new Size(47, 12);
			this.O__O.Oo.().TabIndex = 5;
			this.O__O.Oo.().Text = "选择列:";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(269, 131);
			base.Controls.Add(this.O__O.Oo.());
			base.Controls.Add(this.o_OO._.());
			base.Controls.Add(this.o_OO._.());
			base.Controls.Add(this.OO.__oOooo0o_.());
			base.Controls.Add(this.O0OO.o00O00o.());
			base.Controls.Add(this.OO.__oOooo0o_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.O.o.o.";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "来自于列";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000C377 File Offset: 0x0000A577
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_O.0.;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000C380 File Offset: 0x0000A580
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0OO.o00O00o.);
			C1Button o_O.0. = this.O_O.0.;
			if (o_O.0. != null)
			{
				o_O.0..Click -= value;
			}
			this.O_O.0. = A_0;
			o_O.0. = this.O_O.0.;
			if (o_O.0. != null)
			{
				o_O.0..Click += value;
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000C3C3 File Offset: 0x0000A5C3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo.O00.;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000C3CB File Offset: 0x0000A5CB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oo.O00. = A_0;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O_O.0.;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000C3DC File Offset: 0x0000A5DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.OO.__oOooo0o_.);
			C1ComboBox o_O.0. = this.O_O.0.;
			if (o_O.0. != null)
			{
				o_O.0..SelectedIndexChanged -= value;
			}
			this.O_O.0. = A_0;
			o_O.0. = this.O_O.0.;
			if (o_O.0. != null)
			{
				o_O.0..SelectedIndexChanged += value;
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000C41F File Offset: 0x0000A61F
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.oo.O00.;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000C427 File Offset: 0x0000A627
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.oo.O00. = A_0;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000C430 File Offset: 0x0000A630
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O_O.0.;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000C438 File Offset: 0x0000A638
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O_O.0. = A_0;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000C441 File Offset: 0x0000A641
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo.O00.;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000C449 File Offset: 0x0000A649
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo.O00. = A_0;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000C454 File Offset: 0x0000A654
		public O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002()
		{
			base.Load += this.O_.OoO0O0_o0_.;
			base.FormClosed += this.O0OO.o00O00o.;
			this.o_OO._.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000C4A8 File Offset: 0x0000A6A8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (DataTable dataTable in OO_00oOO.DataTables)
				{
					this.OO.__oOooo0o_.().Items.Add(dataTable.Name);
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
			this.OO.__oOooo0o_.().SelectedIndex = 0;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000C510 File Offset: 0x0000A710
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OO.__oOooo0o_.().SelectedItem != null)
			{
				DataTable dataTable = OO_00oOO.DataTables[this.OO.__oOooo0o_.().SelectedItem.ToString()];
				this.o_OO._.().Items.Clear();
				try
				{
					foreach (DataCol dataCol in dataTable.DataCols)
					{
						this.o_OO._.().Items.Add(dataCol.Name);
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
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OO.__oOooo0o_.().SelectedItem != null && this.o_OO._.().SelectedItem != null)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000C5CB File Offset: 0x0000A7CB
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040000A7 RID: 167
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040000A8 RID: 168
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040000A9 RID: 169
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040000AA RID: 170
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040000AB RID: 171
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040000AC RID: 172
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040000AD RID: 173
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;
	}
}
