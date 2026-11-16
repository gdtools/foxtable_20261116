using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;
using MSDASC;

namespace Foxtable
{
	// Token: 0x0200038E RID: 910
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000\u3002 : Form
	{
		// Token: 0x06003B52 RID: 15186 RVA: 0x001ADA5A File Offset: 0x001ABC5A
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.OO.o_000o. != null)
			{
				this.OO.o_000o..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x001ADA7C File Offset: 0x001ABC7C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o.oo_oo_.(new C1TextBox());
			this.o.OO0o_o_oOoo.(new C1Button());
			this.o.oo_oo_.(new C1Button());
			this.O._00__o00o.(new C1Button());
			this.oO0OOO000.o00O.(new C1Button());
			this.o.oo_oo_.(new Label());
			base.SuspendLayout();
			this.OO.0O_.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.OO.0O_.().Location = new Point(12, 38);
			this.OO.0O_.().Multiline = true;
			this.OO.0O_.().Name = "TextBox1";
			this.OO.0O_.().ScrollBars = ScrollBars.Vertical;
			this.OO.0O_.().Size = new Size(630, 295);
			this.OO.0O_.().TabIndex = 0;
			this.oO00o0._O_Oo.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.oO00o0._O_Oo.().Location = new Point(12, 351);
			this.oO00o0._O_Oo.().Name = "btnCreator";
			this.oO00o0._O_Oo.().Size = new Size(75, 23);
			this.oO00o0._O_Oo.().TabIndex = 1;
			this.oO00o0._O_Oo.().Text = "生成器";
			this.oO00o0._O_Oo.().UseVisualStyleBackColor = true;
			this.OO.0O_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.OO.0O_.().Location = new Point(486, 351);
			this.OO.0O_.().Name = "btnOK";
			this.OO.0O_.().Size = new Size(75, 23);
			this.OO.0O_.().TabIndex = 3;
			this.OO.0O_.().Text = "确定";
			this.OO.0O_.().UseVisualStyleBackColor = true;
			this.OO00o.OoooOo0o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.OO00o.OoooOo0o.().DialogResult = DialogResult.Cancel;
			this.OO00o.OoooOo0o.().Location = new Point(567, 351);
			this.OO00o.OoooOo0o.().Name = "btnCancel";
			this.OO00o.OoooOo0o.().Size = new Size(75, 23);
			this.OO00o.OoooOo0o.().TabIndex = 4;
			this.OO00o.OoooOo0o.().Text = "取消";
			this.OO00o.OoooOo0o.().UseVisualStyleBackColor = true;
			this.Oo_.0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Oo_.0.().Location = new Point(94, 351);
			this.Oo_.0.().Name = "Button1";
			this.Oo_.0.().Size = new Size(75, 23);
			this.Oo_.0.().TabIndex = 2;
			this.Oo_.0.().Text = "预览";
			this.Oo_.0.().UseVisualStyleBackColor = true;
			this.OO.0O_.().AutoSize = true;
			this.OO.0O_.().Location = new Point(10, 16);
			this.OO.0O_.().Name = "Label1";
			this.OO.0O_.().Size = new Size(107, 12);
			this.OO.0O_.().TabIndex = 5;
			this.OO.0O_.().Text = "请输入连接字符串:";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(655, 387);
			base.Controls.Add(this.OO.0O_.());
			base.Controls.Add(this.Oo_.0.());
			base.Controls.Add(this.OO00o.OoooOo0o.());
			base.Controls.Add(this.OO.0O_.());
			base.Controls.Add(this.oO00o0._O_Oo.());
			base.Controls.Add(this.OO.0O_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o....0..";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "外部数据源";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x001ADE54 File Offset: 0x001AC054
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.OO.o_000o.;
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x001ADE5C File Offset: 0x001AC05C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.OO.o_000o. = A_0;
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x001ADE65 File Offset: 0x001AC065
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.oo_oo_.;
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x001ADE70 File Offset: 0x001AC070
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0_._0O_0.);
			C1Button c1Button = this.o.oo_oo_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.oo_oo_. = A_0;
			c1Button = this.o.oo_oo_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x001ADEB3 File Offset: 0x001AC0B3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.OO0o_o_oOoo.;
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x001ADEBC File Offset: 0x001AC0BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo_0oooo.00O_O.);
			C1Button c1Button = this.o.OO0o_o_oOoo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.OO0o_o_oOoo. = A_0;
			c1Button = this.o.OO0o_o_oOoo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x001ADEFF File Offset: 0x001AC0FF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O._00__o00o.;
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x001ADF07 File Offset: 0x001AC107
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.O._00__o00o. = A_0;
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x001ADF10 File Offset: 0x001AC110
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooO.O0_o_0.;
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x001ADF18 File Offset: 0x001AC118
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO00o0._O_Oo.);
			C1Button c1Button = this.ooO.O0_o_0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooO.O0_o_0. = A_0;
			c1Button = this.ooO.O0_o_0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x001ADF5B File Offset: 0x001AC15B
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OO.o_000o.;
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x001ADF63 File Offset: 0x001AC163
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OO.o_000o. = A_0;
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x001ADF6C File Offset: 0x001AC16C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Connection connection = new ConnectionClass();
			DataLinks dataLinks = new DataLinksClass();
			if (Operators.CompareString(this.OO.0O_.().Text, "", true) > 0)
			{
				if (this.OO.0O_.().Text.Trim().StartsWith("http://", StringComparison.OrdinalIgnoreCase) || this.OO.0O_.().Text.Trim().StartsWith("https://", StringComparison.OrdinalIgnoreCase))
				{
					MessageBox.Show("Web数据源无法使用生成器生成!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				connection.ConnectionString = this.OO.0O_.().Text;
			}
			else
			{
				connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;";
			}
			try
			{
				IDataSourceLocator dataSourceLocator = dataLinks;
				object obj = connection;
				if (dataSourceLocator.PromptEdit(ref obj) && Operators.CompareString(connection.ConnectionString, "Provider=Microsoft.Jet.OLEDB.4.0;", true) != 0)
				{
					this.OO.0O_.().Value = connection.ConnectionString;
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x001AE068 File Offset: 0x001AC268
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Operators.CompareString(this.OO.0O_.().Text.Trim(), "", true) != 0)
			{
				new o\u3000\u3002\u3002\u3000\u3002\u3002\u3000\u3002\u3002\u3002(this.OO.0O_.().Text).o.00_0_0.();
			}
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x001AE09C File Offset: 0x001AC29C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OleDbConnection oleDbConnection = null;
			O0O o0O = null;
			string text = this.OO.0O_.().Text.Trim();
			if (Operators.CompareString(text, "", true) != 0)
			{
				try
				{
					if (text.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || text.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
					{
						o0O = new O0O(text);
						if (!o0O.OO._o_OO.())
						{
							return;
						}
					}
					else
					{
						oleDbConnection = new OleDbConnection(this.OO.0O_.().Text);
						oleDbConnection.Open();
						oleDbConnection.Close();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("无法连接数据源,错误:\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (this.OO.o_000o. == null)
				{
					o\u3000\u3000 o_u3000_u = new o\u3000\u3000("新建数据源", "请输入数据源名称:", "");
					o_u3000_u.Oo.__0o_0_Oo.(new o\u3000\u3000.ooOOO_O_Oo_0(this.o.oo_oo_.));
					if (o_u3000_u.ShowDialog() != DialogResult.OK)
					{
						return;
					}
					DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()].NewRow();
					dataRow["Name"] = o_u3000_u.Value;
					dataRow["ConnectionString"] = O00.ooo000o_0.00o0.(text, O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.());
					O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()].Rows.Add(dataRow);
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()], true);
					o0OoOOoOOo0.OOOOO.o000.(O_O0OO.O._o_.(), O_O0OO.OoO__.0oO0oo.(), O_O0OO.o_Oo_000_.0o_0.(), O_O0OO.OoO.0OO__0ooo.(), dataRow, O_O0OO.oo0_o_.o., OO_00oOO.ProjectFile, OO_00oOO.User, O_O0OO.O0_00o.o0__o.);
				}
				else
				{
					if (string.Compare(O00.oO_.0o_oo_0O_.(Conversions.ToString(this.OO.o_000o.["ConnectionString"]), O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.()), text) == 0)
					{
						base.DialogResult = DialogResult.OK;
						return;
					}
					if (Operators.CompareString(this.OO.o_000o., "", true) > 0)
					{
						try
						{
							foreach (DataTable dataTable in OO_00oOO.DataTables)
							{
								if (Operators.CompareString(dataTable.ConnectionName, this.OO.o_000o., true) == 0)
								{
									this.OO.o_000o. = true;
									DataTable dataTable2 = new DataTable();
									string text2;
									if (Operators.CompareString(dataTable.DataServer, "", true) > 0)
									{
										text2 = dataTable.HttpSelect;
									}
									else
									{
										text2 = dataTable.frd_SelectCommandString;
									}
									if (oleDbConnection != null)
									{
										new OleDbDataAdapter(text2, oleDbConnection).FillSchema(dataTable2, SchemaType.Source);
									}
									else
									{
										dataTable2 = o0O.O_0_O_0_o_.0.(text2, true);
										if (dataTable2 == null)
										{
											return;
										}
									}
									if (dataTable2 == null || dataTable2.Columns.Count == 0)
									{
										MessageBox.Show("无法加载表\"" + dataTable.Name + "\"，请检查新的数据源中是否包括该表!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
										return;
									}
									if (!dataTable.OOoo__00O_.o_O.(dataTable2).o_O__.0O.)
									{
										return;
									}
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
						this.OO.o_000o.["ConnectionString"] = O00.ooo000o_0.00o0.(text, O_O0OO.O_O._Oo.(), ooO0__OO.o0O._ooo_O_.());
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()], true);
						if (!this.OO.o_000o.)
						{
							if (O_O0OO.OoO__.0oO0oo.().ContainsKey(this.OO.o_000o.))
							{
								O_O0OO.OoO__.0oO0oo.().Remove(this.OO.o_000o.);
							}
							if (O_O0OO.O._o_.().ContainsKey(this.OO.o_000o.))
							{
								O_O0OO.O._o_.().Remove(this.OO.o_000o.);
							}
							if (O_O0OO.o_Oo_000_.0o_0.().ContainsKey(this.OO.o_000o.))
							{
								O_O0OO.o_Oo_000_.0o_0.().Remove(this.OO.o_000o.);
							}
							o0OoOOoOOo0.OOOOO.o000.(O_O0OO.O._o_.(), O_O0OO.OoO__.0oO0oo.(), O_O0OO.o_Oo_000_.0o_0.(), O_O0OO.OoO.0OO__0ooo.(), this.OO.o_000o., O_O0OO.oo0_o_.o., OO_00oOO.ProjectFile, OO_00oOO.User, O_O0OO.O0_00o.o0__o.);
						}
					}
				}
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x001AE494 File Offset: 0x001AC694
		private void <<EMPTY_NAME>>(o\u3000\u3000 A_0, ValidateInputTextEventArgs A_1)
		{
			if (Operators.CompareString(A_1.Value, "", true) == 0)
			{
				MessageBox.Show("请输入数据源名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
				return;
			}
			if (o_O_o_oOoo__.oo.O0o0o.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0O._ooo_O_.()].Columns["Name"], A_1.Value))
			{
				MessageBox.Show("已经存在同名数据源！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				A_1.Cancel = true;
			}
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x001AE51C File Offset: 0x001AC71C
		public O\u3002\u3000\u3002\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000\u3002(DataRow A_0)
		{
			base.FormClosed += this.OO.0O_.;
			this.OO.0O_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.OO.o_000o. = A_0;
			if (A_0 != null)
			{
				this.OO.o_000o. = Conversions.ToString(A_0["Name"]);
			}
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x001AE57C File Offset: 0x001AC77C
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001864 RID: 6244
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001865 RID: 6245
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001866 RID: 6246
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001867 RID: 6247
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001868 RID: 6248
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001869 RID: 6249
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400186A RID: 6250
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400186B RID: 6251
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x0400186C RID: 6252
		private string <<EMPTY_NAME>>;

		// Token: 0x0400186D RID: 6253
		internal bool <<EMPTY_NAME>>;
	}
}
