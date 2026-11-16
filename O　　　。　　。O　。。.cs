using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using ADOX;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200039A RID: 922
	[DesignerGenerated]
	internal partial class O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002 : Form
	{
		// Token: 0x06003C94 RID: 15508 RVA: 0x001B8530 File Offset: 0x001B6730
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oOOOO.O. != null)
				{
					this.oOOOO.O..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x001B8570 File Offset: 0x001B6770
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o0_oO0o.o0O_.(new Label());
			this.ooO000OOO.oo0o.(new TextBox());
			this.ooO000OOO.oo0o.(new CheckedListBox());
			this.O_o._o0_Oo_.(new C1Button());
			this.ooO000OOO.oo0o.(new Label());
			this.oO.0OO_oo_O_.(new C1Button());
			this.Oo0.O__.(new C1Button());
			base.SuspendLayout();
			this.oO.0OO_oo_O_.().AutoSize = true;
			this.oO.0OO_oo_O_.().Location = new Point(14, 15);
			this.oO.0OO_oo_O_.().Name = "Label1";
			this.oO.0OO_oo_O_.().Size = new Size(47, 12);
			this.oO.0OO_oo_O_.().TabIndex = 0;
			this.oO.0OO_oo_O_.().Text = "输出到:";
			this.oO.0OO_oo_O_.().Location = new Point(14, 35);
			this.oO.0OO_oo_O_.().Name = "TextBox1";
			this.oO.0OO_oo_O_.().ReadOnly = true;
			this.oO.0OO_oo_O_.().Size = new Size(270, 21);
			this.oO.0OO_oo_O_.().TabIndex = 1;
			this.oO.0OO_oo_O_.().FormattingEnabled = true;
			this.oO.0OO_oo_O_.().Location = new Point(14, 84);
			this.oO.0OO_oo_O_.().Name = "CheckedListBox1";
			this.oO.0OO_oo_O_.().Size = new Size(302, 180);
			this.oO.0OO_oo_O_.().TabIndex = 2;
			this.O_o._o0_Oo_.().Location = new Point(284, 35);
			this.O_o._o0_Oo_.().Name = "Button1";
			this.O_o._o0_Oo_.().Size = new Size(32, 21);
			this.O_o._o0_Oo_.().TabIndex = 3;
			this.O_o._o0_Oo_.().Text = "...";
			this.O_o._o0_Oo_.().UseVisualStyleBackColor = true;
			this.Oo0.O__.().AutoSize = true;
			this.Oo0.O__.().Location = new Point(14, 64);
			this.Oo0.O__.().Name = "Label2";
			this.Oo0.O__.().Size = new Size(47, 12);
			this.Oo0.O__.().TabIndex = 4;
			this.Oo0.O__.().Text = "选择表:";
			this.o_0Oo.0o00_O.().Location = new Point(87, 280);
			this.o_0Oo.0o00_O.().Name = "btnOK";
			this.o_0Oo.0o00_O.().Size = new Size(75, 23);
			this.o_0Oo.0o00_O.().TabIndex = 5;
			this.o_0Oo.0o00_O.().Text = "确定";
			this.o_0Oo.0o00_O.().UseVisualStyleBackColor = true;
			this.Oo0.O__.().DialogResult = DialogResult.Cancel;
			this.Oo0.O__.().Location = new Point(168, 280);
			this.Oo0.O__.().Name = "Button3";
			this.Oo0.O__.().Size = new Size(75, 23);
			this.Oo0.O__.().TabIndex = 6;
			this.Oo0.O__.().Text = "取消";
			this.Oo0.O__.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(330, 314);
			base.Controls.Add(this.Oo0.O__.());
			base.Controls.Add(this.o_0Oo.0o00_O.());
			base.Controls.Add(this.Oo0.O__.());
			base.Controls.Add(this.O_o._o0_Oo_.());
			base.Controls.Add(this.oO.0OO_oo_O_.());
			base.Controls.Add(this.oO.0OO_oo_O_.());
			base.Controls.Add(this.oO.0OO_oo_O_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O00.0.0.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "生成Access文件";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x001B8966 File Offset: 0x001B6B66
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.ooO000OOO.oo0o.;
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x001B896E File Offset: 0x001B6B6E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.ooO000OOO.oo0o. = A_0;
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x001B8977 File Offset: 0x001B6B77
		[CompilerGenerated]
		internal virtual TextBox <<EMPTY_NAME>>()
		{
			return this.oOOOO.O.;
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x001B897F File Offset: 0x001B6B7F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(TextBox A_0)
		{
			this.oOOOO.O. = A_0;
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x001B8988 File Offset: 0x001B6B88
		[CompilerGenerated]
		internal virtual CheckedListBox <<EMPTY_NAME>>()
		{
			return this.ooO000OOO.oo0o.;
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x001B8990 File Offset: 0x001B6B90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CheckedListBox A_0)
		{
			this.ooO000OOO.oo0o. = A_0;
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x001B8999 File Offset: 0x001B6B99
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooO000OOO.oo0o.;
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x001B89A4 File Offset: 0x001B6BA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0000.0__O.);
			C1Button c1Button = this.ooO000OOO.oo0o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooO000OOO.oo0o. = A_0;
			c1Button = this.ooO000OOO.oo0o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x001B89E7 File Offset: 0x001B6BE7
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0_oO0o.o0O_.;
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x001B89EF File Offset: 0x001B6BEF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0_oO0o.o0O_. = A_0;
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x001B89F8 File Offset: 0x001B6BF8
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0_oO0o.o0O_.;
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x001B8A00 File Offset: 0x001B6C00
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_0Oo.0o00_O.);
			C1Button c1Button = this.o0_oO0o.o0O_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0_oO0o.o0O_. = A_0;
			c1Button = this.o0_oO0o.o0O_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x001B8A43 File Offset: 0x001B6C43
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_oo.__O.;
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x001B8A4B File Offset: 0x001B6C4B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o_oo.__O. = A_0;
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x001B8A54 File Offset: 0x001B6C54
		public O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002()
		{
			base.Load += this.O_O_.o__o0.;
			base.FormClosed += this.o_0Oo.0o00_O.;
			this.oO.0OO_oo_O_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x001B8AA8 File Offset: 0x001B6CA8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.OverwritePrompt = false;
			saveFileDialog.Filter = "Access文件(*.mdb)|*.mdb";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.oO.0OO_oo_O_.().Text = saveFileDialog.FileName;
			}
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x001B8AE8 File Offset: 0x001B6CE8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				foreach (DataTable dataTable in OO_00oOO.DataTables)
				{
					if (dataTable.frd_IsInnerTable)
					{
						this.oO.0OO_oo_O_.().Items.Add(dataTable.Name, true);
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

		// Token: 0x06003CA7 RID: 15527 RVA: 0x001B8B50 File Offset: 0x001B6D50
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (Operators.CompareString(this.oO.0OO_oo_O_.().Text, "", true) == 0)
				{
					goto IL_2AA;
				}
				IL_24:
				num2 = 4;
				List<string> list = new List<string>();
				IL_2C:
				num2 = 5;
				int num3 = this.oO.0OO_oo_O_.().Items.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_47:
					num2 = 6;
					if (this.oO.0OO_oo_O_.().GetItemChecked(i))
					{
						IL_58:
						num2 = 7;
						list.Add(this.oO.0OO_oo_O_.().Items[i].ToString());
					}
					IL_77:
					num2 = 8;
				}
				IL_85:
				num2 = 9;
				OO_00oOO.CompactToAccess(this.oO.0OO_oo_O_.().Text, "");
				IL_9E:
				num2 = 10;
				Catalog catalog = new CatalogClass();
				IL_A8:
				num2 = 11;
				Connection connection = new ConnectionClass();
				IL_B2:
				num2 = 12;
				connection.ConnectionString = Oo00.o_._0OOo.(this.oO.0OO_oo_O_.().Text);
				IL_CC:
				num2 = 13;
				connection.Open("", "", "", -1);
				IL_E6:
				num2 = 14;
				catalog.ActiveConnection = connection;
				IL_F2:
				num2 = 15;
				IEnumerator<DataTable> enumerator = OO_00oOO.DataTables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataTable dataTable = enumerator.Current;
					IL_10F:
					num2 = 16;
					if (dataTable.frd_IsInnerTable)
					{
						IL_11E:
						num2 = 17;
						if (!list.Contains(dataTable.Name))
						{
							IL_130:
							num2 = 18;
							catalog.Tables.Delete(dataTable.Name);
						}
						else
						{
							IL_14B:
							num2 = 20;
							Table table = catalog.Tables[dataTable.Name];
							IL_163:
							num2 = 21;
							table.Indexes.Delete(0);
							IL_178:
							num2 = 22;
							table.Columns.Delete("_Identify");
							IL_18C:
							num2 = 23;
							Column column = new ColumnClass();
							IL_196:
							num2 = 24;
							column.ParentCatalog = catalog;
							IL_1A2:
							num2 = 25;
							column.Name = "_Identify";
							IL_1B1:
							num2 = 26;
							column.Type = ADOX.DataTypeEnum.adInteger;
							IL_1BC:
							num2 = 27;
							column.Properties["AutoIncrement"].Value = true;
							IL_1DB:
							num2 = 28;
							table.Columns.Append(column, ADOX.DataTypeEnum.adVarWChar, 0);
							IL_1F2:
							num2 = 29;
							Index index = new IndexClass();
							IL_1FC:
							num2 = 30;
							index.Name = "PrimaryKey";
							IL_20B:
							num2 = 31;
							index.Columns.Append("_Identify", ADOX.DataTypeEnum.adVarWChar, 0);
							IL_225:
							num2 = 32;
							index.PrimaryKey = true;
							IL_230:
							num2 = 33;
							index.Unique = true;
							IL_23B:
							num2 = 34;
							table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
							IL_256:
							table = null;
						}
					}
					IL_259:
					num2 = 36;
				}
				IL_268:
				num2 = 37;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_276:
				num2 = 38;
				connection.Close();
				IL_280:
				num2 = 39;
				catalog = null;
				IL_286:
				num2 = 40;
				OO_00oOO.CompactAccessFile(this.oO.0OO_oo_O_.().Text, "", false);
				IL_2A0:
				num2 = 41;
				base.DialogResult = DialogResult.OK;
				IL_2AA:
				goto IL_3A4;
				IL_2AF:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_365:
				goto IL_399;
				IL_367:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_377:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_367;
			}
			IL_399:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3A4:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x001B8F28 File Offset: 0x001B7128
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040018ED RID: 6381
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040018EE RID: 6382
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040018EF RID: 6383
		[CompilerGenerated]
		private TextBox <<EMPTY_NAME>>;

		// Token: 0x040018F0 RID: 6384
		[CompilerGenerated]
		private CheckedListBox <<EMPTY_NAME>>;

		// Token: 0x040018F1 RID: 6385
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018F2 RID: 6386
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040018F3 RID: 6387
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018F4 RID: 6388
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
