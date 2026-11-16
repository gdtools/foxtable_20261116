using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using ADOX;
using C1.Win.C1Input;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000349 RID: 841
	[DesignerGenerated]
	internal partial class O\u3000\u3000\u3000\u3002\u3002\u3002\u3002_\u3000\u3000\u3002\u3000 : Form
	{
		// Token: 0x0600337B RID: 13179 RVA: 0x0015FD50 File Offset: 0x0015DF50
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o_0.o__OOoO. != null)
				{
					this.o_0.o__OOoO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x0015FD90 File Offset: 0x0015DF90
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oO.__.(new CheckedListBox());
			this.oo__.0_Ooooo.(new Label());
			this.oo__.0_Ooooo.(new C1Button());
			this.oO.__.(new C1Button());
			this.oO.__.(new Label());
			this.oO.__.(new C1ComboBox());
			this.oO.__.(new C1CheckBox());
			((ISupportInitialize)this.O0O_.o_O00o.()).BeginInit();
			((ISupportInitialize)this.oO0o.o0.()).BeginInit();
			((ISupportInitialize)this.oO0o.o0.()).BeginInit();
			((ISupportInitialize)this.oO0o.o0.()).BeginInit();
			base.SuspendLayout();
			this.oO0o.o0.().CheckOnClick = true;
			this.oO0o.o0.().FormattingEnabled = true;
			this.oO0o.o0.().Location = new Point(14, 85);
			this.oO0o.o0.().Name = "lstCols";
			this.oO0o.o0.().Size = new Size(378, 180);
			this.oO0o.o0.().TabIndex = 3;
			this.oO0o.o0.().AutoSize = true;
			this.oO0o.o0.().Location = new Point(14, 66);
			this.oO0o.o0.().Name = "Label1";
			this.oO0o.o0.().Size = new Size(47, 12);
			this.oO0o.o0.().TabIndex = 2;
			this.oO0o.o0.().Text = "选择列:";
			this.O0O_.o_O00o.().Location = new Point(125, 279);
			this.O0O_.o_O00o.().Name = "btnImport";
			this.O0O_.o_O00o.().Size = new Size(75, 23);
			this.O0O_.o_O00o.().TabIndex = 6;
			this.O0O_.o_O00o.().Text = "确定";
			this.O0O_.o_O00o.().UseVisualStyleBackColor = true;
			this.oO0o.o0.().DialogResult = DialogResult.Cancel;
			this.oO0o.o0.().Location = new Point(207, 279);
			this.oO0o.o0.().Name = "btnCancel";
			this.oO0o.o0.().Size = new Size(75, 23);
			this.oO0o.o0.().TabIndex = 7;
			this.oO0o.o0.().Text = "取消";
			this.oO0o.o0.().UseVisualStyleBackColor = true;
			this.O0O_.o_O00o.().AutoSize = true;
			this.O0O_.o_O00o.().Location = new Point(14, 11);
			this.O0O_.o_O00o.().Name = "Label2";
			this.O0O_.o_O00o.().Size = new Size(47, 12);
			this.O0O_.o_O00o.().TabIndex = 0;
			this.O0O_.o_O00o.().Text = "选择表:";
			this.oO0o.o0.().AllowSpinLoop = false;
			this.oO0o.o0.().Cursor = Cursors.Arrow;
			this.oO0o.o0.().DropDownStyle = DropDownStyle.DropDownList;
			this.oO0o.o0.().GapHeight = 0;
			this.oO0o.o0.().ImagePadding = new Padding(0, 0, 0, 0);
			this.oO0o.o0.().ItemsDisplayMember = "";
			this.oO0o.o0.().ItemsValueMember = "";
			this.oO0o.o0.().Location = new Point(14, 30);
			this.oO0o.o0.().Name = "lstTable";
			this.oO0o.o0.().Size = new Size(378, 19);
			this.oO0o.o0.().TabIndex = 1;
			this.oO0o.o0.().Tag = null;
			this.oO0o.o0.().AutoSize = true;
			this.oO0o.o0.().BorderStyle = BorderStyle.None;
			this.oO0o.o0.().Checked = true;
			this.oO0o.o0.().CheckState = CheckState.Checked;
			this.oO0o.o0.().Location = new Point(308, 63);
			this.oO0o.o0.().Name = "CheckBox1";
			this.oO0o.o0.().Size = new Size(84, 16);
			this.oO0o.o0.().TabIndex = 8;
			this.oO0o.o0.().Text = "选择所有列";
			this.oO0o.o0.().UseVisualStyleBackColor = true;
			this.oO0o.o0.().Value = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(406, 314);
			base.Controls.Add(this.oO0o.o0.());
			base.Controls.Add(this.oO0o.o0.());
			base.Controls.Add(this.O0O_.o_O00o.());
			base.Controls.Add(this.oO0o.o0.());
			base.Controls.Add(this.O0O_.o_O00o.());
			base.Controls.Add(this.oO0o.o0.());
			base.Controls.Add(this.oO0o.o0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o_o......o";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "高速导入";
			((ISupportInitialize)this.O0O_.o_O00o.()).EndInit();
			((ISupportInitialize)this.oO0o.o0.()).EndInit();
			((ISupportInitialize)this.oO0o.o0.()).EndInit();
			((ISupportInitialize)this.oO0o.o0.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x00160293 File Offset: 0x0015E493
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.o_0.o__OOoO.;
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x0016029B File Offset: 0x0015E49B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			this.o_0.o__OOoO. = A_0;
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x001602A4 File Offset: 0x0015E4A4
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_0.o__OOoO.;
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x001602AC File Offset: 0x0015E4AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_0.o__OOoO. = A_0;
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x001602B5 File Offset: 0x0015E4B5
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO.__.;
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x001602C0 File Offset: 0x0015E4C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0._0_Oo_O0OO.);
			C1Button c1Button = this.oO.__.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO.__. = A_0;
			c1Button = this.oO.__.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00160303 File Offset: 0x0015E503
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo__.0_Ooooo.;
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x0016030B File Offset: 0x0015E50B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oo__.0_Ooooo. = A_0;
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x00160314 File Offset: 0x0015E514
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.OO0o.;
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x0016031C File Offset: 0x0015E51C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.OO0o. = A_0;
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x00160325 File Offset: 0x0015E525
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o_0.o__OOoO.;
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x00160330 File Offset: 0x0015E530
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O0o00._0O.);
			C1ComboBox c1ComboBox = this.o_0.o__OOoO.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.o_0.o__OOoO. = A_0;
			c1ComboBox = this.o_0.o__OOoO.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x00160373 File Offset: 0x0015E573
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.oO.__.;
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x0016037C File Offset: 0x0015E57C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.oO.0O0_0__O0__.);
			C1CheckBox c1CheckBox = this.oO.__.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged -= value;
			}
			this.oO.__. = A_0;
			c1CheckBox = this.oO.__.;
			if (c1CheckBox != null)
			{
				c1CheckBox.CheckedChanged += value;
			}
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x001603C0 File Offset: 0x0015E5C0
		public O\u3000\u3000\u3000\u3002\u3002\u3002\u3002_\u3000\u3000\u3002\u3000(string A_0)
		{
			base.FormClosed += this.oO.0O0_0__O0__.;
			this.o_0.o__OOoO. = new Importer();
			this.o_0.o__OOoO. = new OleDbConnection();
			this.oO0o.o0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			string extension = Path.GetExtension(A_0);
			string left = extension;
			if (Operators.CompareString(left, ".mdb", true) == 0 || Operators.CompareString(left, ".accdb", true) == 0)
			{
				this.o_0.o__OOoO..Format = "access";
				this.o_0.o__OOoO..SourcePath = A_0;
				if (Operators.CompareString(extension, ".accdb", true) == 0)
				{
					this.o_0.o__OOoO..ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + A_0;
				}
				else
				{
					this.o_0.o__OOoO..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + A_0;
				}
				this.O0O_.o_O00o.();
			}
			else if (Operators.CompareString(left, ".xls", true) == 0 || Operators.CompareString(left, ".xlsx", true) == 0)
			{
				this.o_0.o__OOoO..Format = "excel";
				this.o_0.o__OOoO..SourcePath = A_0;
				if (Operators.CompareString(extension, ".xlsx", true) == 0)
				{
					this.o_0.o__OOoO..ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + A_0 + ";Extended Properties=\"Excel 12.0;HDR=YES\"";
				}
				else
				{
					this.o_0.o__OOoO..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + A_0 + ";Extended Properties=\"Excel 8.0;HDR=YES\"";
				}
				this.O0O_.o_O00o.();
			}
			else if (Operators.CompareString(left, ".dbf", true) == 0)
			{
				this.o_0.o__OOoO..Format = "dbase";
				this.o_0.o__OOoO..SourcePath = c.OOOOO.o.().FileSystem.GetParentPath(A_0);
				this.o_0.o__OOoO..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + c.OOOOO.o.().FileSystem.GetParentPath(A_0) + ";Extended Properties=dBASE IV";
				this.oO0o.o0.().Items.Add(Path.GetFileNameWithoutExtension(A_0));
			}
			else if (Operators.CompareString(left, ".txt", true) == 0)
			{
				this.o_0.o__OOoO..Format = "Delimited";
				this.o_0.o__OOoO..SourcePath = c.OOOOO.o.().FileSystem.GetParentPath(A_0);
				this.o_0.o__OOoO..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + c.OOOOO.o.().FileSystem.GetParentPath(A_0) + ";Extended Properties=\"text;HDR=Yes;FMT=Delimited\"";
				this.oO0o.o0.().Items.Add(Path.GetFileNameWithoutExtension(A_0) + "#TXT");
			}
			this.oO0o.o0.().SelectedIndex = 0;
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x00160638 File Offset: 0x0015E838
		public void <<EMPTY_NAME>>()
		{
			Catalog catalog = new CatalogClass();
			Connection connection = new ConnectionClass();
			connection.ConnectionString = this.o_0.o__OOoO..ConnectionString;
			connection.Open("", "", "", -1);
			catalog.ActiveConnection = connection;
			try
			{
				foreach (object obj in catalog.Tables)
				{
					Table table = (Table)obj;
					if ((Operators.CompareString(table.Type, "View", true) == 0 || Operators.CompareString(table.Type, "Table", true) == 0) && !table.Name.StartsWith("~TMPCLP", StringComparison.CurrentCultureIgnoreCase))
					{
						this.oO0o.o0.().Items.Add(table.Name);
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
			connection.Close();
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x00160720 File Offset: 0x0015E920
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_0.o__OOoO..SourceTableName = this.oO0o.o0.().SelectedItem.ToString().Trim(new char[]
			{
				'\''
			});
			DataTable dataTable = new DataTable();
			new OleDbDataAdapter("", this.o_0.o__OOoO.)
			{
				SelectCommand = 
				{
					CommandText = "Select * From [" + this.o_0.o__OOoO..SourceTableName + "]"
				}
			}.FillSchema(dataTable, SchemaType.Source);
			this.oO0o.o0.().Items.Clear();
			try
			{
				foreach (object obj in dataTable.Columns)
				{
					DataColumn dataColumn = (DataColumn)obj;
					if (!o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) && !dataColumn.AutoIncrement)
					{
						this.oO0o.o0.().Items.Add(dataColumn.ColumnName, true);
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

		// Token: 0x0600338E RID: 13198 RVA: 0x00160828 File Offset: 0x0015EA28
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = "";
			o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u = new o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(this.oO0o.o0.().Text, "");
			o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(true);
			int num = this.oO0o.o0.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (this.oO0o.o0.().GetItemChecked(i))
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += ",";
					}
					text = text + "[" + this.oO0o.o0.().Items[i].ToString() + "]";
				}
			}
			this.o_0.o__OOoO..Fields = text;
			if (o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() == DialogResult.OK)
			{
				this.o_0.o__OOoO..NewTableName = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.();
				this.o_0.o__OOoO..NewTableCaption = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.();
				if (this.o_0.o__OOoO..Import() && MessageBox.Show("已经成功导入，是否继续导入其它表？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					base.DialogResult = DialogResult.OK;
				}
			}
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x00160928 File Offset: 0x0015EB28
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			bool @checked = this.oO0o.o0.().Checked;
			int num = this.oO0o.o0.().Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				this.oO0o.o0.().SetItemChecked(i, @checked);
			}
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x0016096D File Offset: 0x0015EB6D
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040014A8 RID: 5288
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040014A9 RID: 5289
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x040014AA RID: 5290
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040014AB RID: 5291
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014AC RID: 5292
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014AD RID: 5293
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040014AE RID: 5294
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040014AF RID: 5295
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040014B0 RID: 5296
		internal Importer <<EMPTY_NAME>>;

		// Token: 0x040014B1 RID: 5297
		private OleDbConnection <<EMPTY_NAME>>;
	}
}
