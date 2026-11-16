using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000348 RID: 840
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3002\u3000\u3000\u3002\u3000\u3000 : Form
	{
		// Token: 0x06003365 RID: 13157 RVA: 0x0015F330 File Offset: 0x0015D530
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oO.0O0_0__O0__. != null)
				{
					this.oO.0O0_0__O0__..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x0015F370 File Offset: 0x0015D570
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O0_OO0O.0_o.(new C1Button());
			this.o._OO_O_O.(new C1Button());
			this.o0._Ooo0o.(new Label());
			this.o._OO_O_O.(new CheckedListBox());
			this.o._OO_O_O.(new Label());
			this.o._OO_O_O.(new C1TextBox());
			this.o._OO_O_O.(new CheckBox());
			base.SuspendLayout();
			this.O0_OO0O.0_o.().DialogResult = DialogResult.Cancel;
			this.O0_OO0O.0_o.().Location = new Point(205, 281);
			this.O0_OO0O.0_o.().Name = "btnCancel";
			this.O0_OO0O.0_o.().Size = new Size(75, 23);
			this.O0_OO0O.0_o.().TabIndex = 11;
			this.O0_OO0O.0_o.().Text = "取消";
			this.O0_OO0O.0_o.().UseVisualStyleBackColor = true;
			this.O0O0o0oOO0.o_O.().Location = new Point(123, 281);
			this.O0O0o0oOO0.o_O.().Name = "btnExport";
			this.O0O0o0oOO0.o_O.().Size = new Size(75, 23);
			this.O0O0o0oOO0.o_O.().TabIndex = 10;
			this.O0O0o0oOO0.o_O.().Text = "确定";
			this.O0O0o0oOO0.o_O.().UseVisualStyleBackColor = true;
			this.O0O0o0oOO0.o_O.().AutoSize = true;
			this.O0O0o0oOO0.o_O.().Location = new Point(12, 16);
			this.O0O0o0oOO0.o_O.().Name = "Label1";
			this.O0O0o0oOO0.o_O.().Size = new Size(47, 12);
			this.O0O0o0oOO0.o_O.().TabIndex = 8;
			this.O0O0o0oOO0.o_O.().Text = "选择列:";
			this.O0O0o0oOO0.o_O.().CheckOnClick = true;
			this.O0O0o0oOO0.o_O.().FormattingEnabled = true;
			this.O0O0o0oOO0.o_O.().Location = new Point(12, 38);
			this.O0O0o0oOO0.o_O.().Name = "lstCols";
			this.O0O0o0oOO0.o_O.().Size = new Size(378, 180);
			this.O0O0o0oOO0.o_O.().TabIndex = 9;
			this.O0_OO0O.0_o.().AutoSize = true;
			this.O0_OO0O.0_o.().Location = new Point(12, 226);
			this.O0_OO0O.0_o.().Name = "Label2";
			this.O0_OO0O.0_o.().Size = new Size(59, 12);
			this.O0_OO0O.0_o.().TabIndex = 13;
			this.O0_OO0O.0_o.().Text = "目标表名:";
			this.O0O0o0oOO0.o_O.().Location = new Point(12, 246);
			this.O0O0o0oOO0.o_O.().Name = "txtTableName";
			this.O0O0o0oOO0.o_O.().Size = new Size(378, 21);
			this.O0O0o0oOO0.o_O.().TabIndex = 14;
			this.O0O0o0oOO0.o_O.().AutoSize = true;
			this.O0O0o0oOO0.o_O.().Checked = true;
			this.O0O0o0oOO0.o_O.().CheckState = CheckState.Checked;
			this.O0O0o0oOO0.o_O.().Location = new Point(306, 16);
			this.O0O0o0oOO0.o_O.().Name = "CheckBox1";
			this.O0O0o0oOO0.o_O.().Size = new Size(84, 16);
			this.O0O0o0oOO0.o_O.().TabIndex = 15;
			this.O0O0o0oOO0.o_O.().Text = "选择所有列";
			this.O0O0o0oOO0.o_O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(402, 315);
			base.Controls.Add(this.O0O0o0oOO0.o_O.());
			base.Controls.Add(this.O0O0o0oOO0.o_O.());
			base.Controls.Add(this.O0_OO0O.0_o.());
			base.Controls.Add(this.O0_OO0O.0_o.());
			base.Controls.Add(this.O0O0o0oOO0.o_O.());
			base.Controls.Add(this.O0O0o0oOO0.o_O.());
			base.Controls.Add(this.O0O0o0oOO0.o_O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oo...0..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "高速导出";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x0015F78F File Offset: 0x0015D98F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o._OO_O_O.;
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x0015F798 File Offset: 0x0015D998
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.0OO_.);
			C1Button c1Button = this.o._OO_O_O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o._OO_O_O. = A_0;
			c1Button = this.o._OO_O_O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x0015F7DB File Offset: 0x0015D9DB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0._Ooo0o.;
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x0015F7E4 File Offset: 0x0015D9E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_0_O__0_.0.);
			C1Button c1Button = this.o0._Ooo0o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0._Ooo0o. = A_0;
			c1Button = this.o0._Ooo0o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x0015F827 File Offset: 0x0015DA27
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o._OO_O_O.;
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x0015F82F File Offset: 0x0015DA2F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o._OO_O_O. = A_0;
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x0015F838 File Offset: 0x0015DA38
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.oO.0O0_0__O0__.;
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x0015F840 File Offset: 0x0015DA40
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			this.oO.0O0_0__O0__. = A_0;
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x0015F849 File Offset: 0x0015DA49
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0._0_Oo_O0OO.;
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x0015F851 File Offset: 0x0015DA51
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0._0_Oo_O0OO. = A_0;
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x0015F85A File Offset: 0x0015DA5A
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oO.0O0_0__O0__.;
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x0015F862 File Offset: 0x0015DA62
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.oO.0O0_0__O0__. = A_0;
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x0015F86B File Offset: 0x0015DA6B
		[CompilerGenerated]
		internal virtual CheckBox <<EMPTY_NAME>>()
		{
			return this.o._OO_O_O.;
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x0015F874 File Offset: 0x0015DA74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.ooooooO0.o.);
			CheckBox checkBox = this.o._OO_O_O.;
			if (checkBox != null)
			{
				checkBox.CheckedChanged -= value;
			}
			this.o._OO_O_O. = A_0;
			checkBox = this.o._OO_O_O.;
			if (checkBox != null)
			{
				checkBox.CheckedChanged += value;
			}
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x0015F8B8 File Offset: 0x0015DAB8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (object obj in OO_00oOO.CurrentTable.DataTable.BaseTable.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (!o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName))
					{
						this.O0O0o0oOO0.o_O.().Items.Add(dataColumn.ColumnName, true);
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
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x0015F948 File Offset: 0x0015DB48
		public O\u3002\u3000\u3002\u3000\u3000\u3002\u3000\u3000(string A_0)
		{
			base.Load += this.oo.Oo0oo0_Oo.;
			base.FormClosed += this.ooooooO0.o.;
			this.oO.0O0_0__O0__. = new Exporter();
			this.O0O0o0oOO0.o_O.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oO.0O0_0__O0__. = A_0;
			string extension = Path.GetExtension(A_0);
			if (Operators.CompareString(extension, ".mdb", true) == 0)
			{
				this.oO.0O0_0__O0__..Format = "access";
				this.oO.0O0_0__O0__..FilePath = this.oO.0O0_0__O0__.;
			}
			else if (Operators.CompareString(extension, ".accdb", true) == 0)
			{
				this.oO.0O0_0__O0__..Format = "access2007";
				this.oO.0O0_0__O0__..FilePath = this.oO.0O0_0__O0__.;
			}
			else if (Operators.CompareString(extension, ".xls", true) == 0)
			{
				this.oO.0O0_0__O0__..Format = "excel";
				this.oO.0O0_0__O0__..FilePath = this.oO.0O0_0__O0__.;
			}
			else if (Operators.CompareString(extension, ".xlsx", true) == 0)
			{
				this.oO.0O0_0__O0__..Format = "excel2007";
				this.oO.0O0_0__O0__..FilePath = this.oO.0O0_0__O0__.;
			}
			else if (Operators.CompareString(extension, ".dbf", true) == 0)
			{
				this.oO.0O0_0__O0__..Format = "dbase";
				this.oO.0O0_0__O0__..FilePath = c.OOOOO.o.().FileSystem.GetParentPath(A_0);
				this.oO.0O0_0__O0__..NewTableName = Path.GetFileNameWithoutExtension(A_0);
			}
			else if (Operators.CompareString(extension, ".txt", true) == 0)
			{
				this.oO.0O0_0__O0__..Format = "Delimited";
				this.oO.0O0_0__O0__..FilePath = c.OOOOO.o.().FileSystem.GetParentPath(A_0);
				this.oO.0O0_0__O0__..NewTableName = Path.GetFileNameWithoutExtension(A_0);
			}
			this.oO.0O0_0__O0__..SourceTableName = OO_00oOO.CurrentTable.DataTable.Name;
			if (Operators.CompareString(this.oO.0O0_0__O0__..NewTableName, "", true) == 0)
			{
				this.oO.0O0_0__O0__..NewTableName = OO_00oOO.CurrentTable.DataTable.Name;
			}
			this.O0O0o0oOO0.o_O.().Value = this.oO.0O0_0__O0__..NewTableName;
			if (OO_00oOO.CurrentTable.ApplyFilter)
			{
				this.oO.0O0_0__O0__..Filter = OO_00oOO.CurrentTable.Filter;
			}
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x0015FB9C File Offset: 0x0015DD9C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x0015FBA8 File Offset: 0x0015DDA8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oO.0O0_0__O0__..NewTableName = this.O0O0o0oOO0.o_O.().Text;
			this.oO.0O0_0__O0__..Filter = OO_00oOO.DataTables[this.oO.0O0_0__O0__..SourceTableName].LoadFilter;
			string text = "";
			bool flag = true;
			int num = this.O0O0o0oOO0.o_O.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (!this.O0O0o0oOO0.o_O.().GetItemChecked(i))
				{
					flag = false;
				}
				else
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += ",";
					}
					text = text + "[" + this.O0O0o0oOO0.o_O.().Items[i].ToString() + "]";
				}
			}
			if (flag)
			{
				this.oO.0O0_0__O0__..Fields = "";
			}
			else
			{
				this.oO.0O0_0__O0__..Fields = text;
			}
			string extension = Path.GetExtension(this.oO.0O0_0__O0__.);
			if ((Operators.CompareString(extension, ".dbf", true) == 0 || Operators.CompareString(extension, ".txt", true) == 0) && c.OOOOO.o.().FileSystem.FileExists(this.oO.0O0_0__O0__.))
			{
				c.OOOOO.o.().FileSystem.DeleteFile(this.oO.0O0_0__O0__.);
			}
			this.oO.0O0_0__O0__..Export();
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x0015FCF8 File Offset: 0x0015DEF8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			bool @checked = this.O0O0o0oOO0.o_O.().Checked;
			int num = this.O0O0o0oOO0.o_O.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				this.O0O0o0oOO0.o_O.().SetItemChecked(i, @checked);
			}
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x0015FD3D File Offset: 0x0015DF3D
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400149E RID: 5278
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400149F RID: 5279
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014A0 RID: 5280
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014A1 RID: 5281
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040014A2 RID: 5282
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x040014A3 RID: 5283
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040014A4 RID: 5284
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x040014A5 RID: 5285
		[CompilerGenerated]
		private CheckBox <<EMPTY_NAME>>;

		// Token: 0x040014A6 RID: 5286
		private string <<EMPTY_NAME>>;

		// Token: 0x040014A7 RID: 5287
		private Exporter <<EMPTY_NAME>>;
	}
}
