using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using ADOX;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Foxtable.RibbonMenu;
using Microsoft.VisualBasic.CompilerServices;
using MSDASC;

namespace Foxtable
{
	// Token: 0x02000342 RID: 834
	[DesignerGenerated]
	internal partial class O_\u3000\u3000 : Form
	{
		// Token: 0x060032C6 RID: 12998 RVA: 0x0015A288 File Offset: 0x00158488
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O__.oOO. != null)
				{
					this.O__.oOO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x0015A2C8 File Offset: 0x001584C8
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Ooo000_OO00.o.(new C1Button());
			this.O.OOo_.(new C1ComboBox());
			this.O.OOo_.(new C1Button());
			this.Ooo.0O_O0.(new C1Button());
			this.O.OOo_.(new System.Windows.Forms.Label());
			this.O.OOo_.(new C1TextBox());
			this.O.OOo_.(new C1CheckBox());
			this.O.OOo_.(new C1FlexGrid());
			((ISupportInitialize)this.ooO_o_.oo.()).BeginInit();
			((ISupportInitialize)this.oO0O.OO_.()).BeginInit();
			((ISupportInitialize)this.OOOo000._o.()).BeginInit();
			((ISupportInitialize)this.O0OO.o.()).BeginInit();
			((ISupportInitialize)this.oO0O.OO_.()).BeginInit();
			((ISupportInitialize)this.O0OO.o.()).BeginInit();
			((ISupportInitialize)this.O0OO.o.()).BeginInit();
			base.SuspendLayout();
			this.ooO_o_.oo.().Location = new Point(18, 548);
			this.ooO_o_.oo.().Margin = new Padding(4);
			this.ooO_o_.oo.().Name = "Button1";
			this.ooO_o_.oo.().Size = new Size(112, 34);
			this.ooO_o_.oo.().TabIndex = 4;
			this.ooO_o_.oo.().Text = "删除列";
			this.ooO_o_.oo.().UseVisualStyleBackColor = true;
			this.oO0O.OO_.().AllowSpinLoop = false;
			this.oO0O.OO_.().Cursor = Cursors.Arrow;
			this.oO0O.OO_.().DropDownStyle = DropDownStyle.DropDownList;
			this.oO0O.OO_.().GapHeight = 0;
			this.oO0O.OO_.().ImagePadding = new Padding(0);
			this.oO0O.OO_.().ItemsDisplayMember = "";
			this.oO0O.OO_.().ItemsValueMember = "";
			this.oO0O.OO_.().Location = new Point(22, 19);
			this.oO0O.OO_.().Margin = new Padding(4);
			this.oO0O.OO_.().Name = "lstTables";
			this.oO0O.OO_.().Size = new Size(561, 26);
			this.oO0O.OO_.().TabIndex = 0;
			this.oO0O.OO_.().Tag = null;
			this.OOOo000._o.().DialogResult = DialogResult.Cancel;
			this.OOOo000._o.().Location = new Point(806, 548);
			this.OOOo000._o.().Margin = new Padding(4);
			this.OOOo000._o.().Name = "Button3";
			this.OOOo000._o.().Size = new Size(112, 34);
			this.OOOo000._o.().TabIndex = 6;
			this.OOOo000._o.().Text = "取消";
			this.OOOo000._o.().UseVisualStyleBackColor = true;
			this.O0OO.o.().Location = new Point(684, 548);
			this.O0OO.o.().Margin = new Padding(4);
			this.O0OO.o.().Name = "Button2";
			this.O0OO.o.().Size = new Size(112, 34);
			this.O0OO.o.().TabIndex = 5;
			this.O0OO.o.().Text = "确定";
			this.O0OO.o.().UseVisualStyleBackColor = true;
			this.oO0O.OO_.().AutoSize = true;
			this.oO0O.OO_.().Location = new Point(608, 23);
			this.oO0O.OO_.().Margin = new Padding(4, 0, 4, 0);
			this.oO0O.OO_.().Name = "Label2";
			this.oO0O.OO_.().Size = new Size(53, 18);
			this.oO0O.OO_.().TabIndex = 43;
			this.oO0O.OO_.().Text = "行数:";
			this.oO0O.OO_.().Location = new Point(669, 19);
			this.oO0O.OO_.().Margin = new Padding(4);
			this.oO0O.OO_.().Name = "TextBox1";
			this.oO0O.OO_.().Size = new Size(102, 26);
			this.oO0O.OO_.().TabIndex = 1;
			this.oO0O.OO_.().Tag = null;
			this.oO0O.OO_.().Value = "10";
			this.O0OO.o.().AutoSize = true;
			this.O0OO.o.().BorderStyle = BorderStyle.None;
			this.O0OO.o.().Location = new Point(806, 21);
			this.O0OO.o.().Margin = new Padding(4);
			this.O0OO.o.().Name = "chkAll";
			this.O0OO.o.().Size = new Size(106, 22);
			this.O0OO.o.().TabIndex = 2;
			this.O0OO.o.().Text = "全部导入";
			this.O0OO.o.().UseVisualStyleBackColor = true;
			this.O0OO.o.().Value = null;
			this.O0OO.o.().AllowDragging = AllowDraggingEnum.None;
			this.O0OO.o.().AllowEditing = false;
			this.O0OO.o.().AllowSorting = AllowSortingEnum.None;
			this.O0OO.o.().ColumnInfo = "0,0,0,0,0,135,Columns:";
			this.O0OO.o.().Location = new Point(18, 64);
			this.O0OO.o.().Name = "grid";
			this.O0OO.o.().Rows.Count = 2;
			this.O0OO.o.().Rows.DefaultSize = 19;
			this.O0OO.o.().SelectionMode = SelectionModeEnum.Column;
			this.O0OO.o.().Size = new Size(894, 450);
			this.O0OO.o.().TabIndex = 44;
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(940, 600);
			base.Controls.Add(this.O0OO.o.());
			base.Controls.Add(this.O0OO.o.());
			base.Controls.Add(this.oO0O.OO_.());
			base.Controls.Add(this.oO0O.OO_.());
			base.Controls.Add(this.ooO_o_.oo.());
			base.Controls.Add(this.oO0O.OO_.());
			base.Controls.Add(this.OOOo000._o.());
			base.Controls.Add(this.O0OO.o.());
			base.Margin = new Padding(4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "_o......o";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "导入";
			((ISupportInitialize)this.ooO_o_.oo.()).EndInit();
			((ISupportInitialize)this.oO0O.OO_.()).EndInit();
			((ISupportInitialize)this.OOOo000._o.()).EndInit();
			((ISupportInitialize)this.O0OO.o.()).EndInit();
			((ISupportInitialize)this.oO0O.OO_.()).EndInit();
			((ISupportInitialize)this.O0OO.o.()).EndInit();
			((ISupportInitialize)this.O0OO.o.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x0015A93A File Offset: 0x00158B3A
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.OOo_.;
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x0015A944 File Offset: 0x00158B44
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_.0__oo_O.);
			C1Button o.OOo_. = this.O.OOo_.;
			if (o.OOo_. != null)
			{
				o.OOo_..Click -= value;
			}
			this.O.OOo_. = A_0;
			o.OOo_. = this.O.OOo_.;
			if (o.OOo_. != null)
			{
				o.OOo_..Click += value;
			}
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x0015A987 File Offset: 0x00158B87
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.O__.oOO.;
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x0015A990 File Offset: 0x00158B90
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.o_0.o_oo0_OO.);
			C1ComboBox o__.oOO. = this.O__.oOO.;
			if (o__.oOO. != null)
			{
				o__.oOO..SelectedIndexChanged -= value;
			}
			this.O__.oOO. = A_0;
			o__.oOO. = this.O__.oOO.;
			if (o__.oOO. != null)
			{
				o__.oOO..SelectedIndexChanged += value;
			}
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x0015A9D3 File Offset: 0x00158BD3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOOO0oo000.00o.;
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x0015A9DB File Offset: 0x00158BDB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oOOO0oo000.00o. = A_0;
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x0015A9E4 File Offset: 0x00158BE4
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0O0_.Oo0o.;
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x0015A9EC File Offset: 0x00158BEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo_ooOo0oo.OOo.);
			C1Button c1Button = this.o0O0_.Oo0o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0O0_.Oo0o. = A_0;
			c1Button = this.o0O0_.Oo0o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x0015AA2F File Offset: 0x00158C2F
		[CompilerGenerated]
		internal virtual System.Windows.Forms.Label <<EMPTY_NAME>>()
		{
			return this.O__.oOO.;
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x0015AA37 File Offset: 0x00158C37
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.Label A_0)
		{
			this.O__.oOO. = A_0;
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x0015AA40 File Offset: 0x00158C40
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.O__.oOO.;
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x0015AA48 File Offset: 0x00158C48
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			EventHandler value = new EventHandler(this.O.OOo_.);
			C1TextBox o__.oOO. = this.O__.oOO.;
			if (o__.oOO. != null)
			{
				o__.oOO..Validated -= value;
			}
			this.O__.oOO. = A_0;
			o__.oOO. = this.O__.oOO.;
			if (o__.oOO. != null)
			{
				o__.oOO..Validated += value;
			}
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x0015AA8B File Offset: 0x00158C8B
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O__.oOO.;
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x0015AA94 File Offset: 0x00158C94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.OOOo000._o.);
			C1CheckBox o__.oOO. = this.O__.oOO.;
			if (o__.oOO. != null)
			{
				o__.oOO..CheckedChanged -= value;
			}
			this.O__.oOO. = A_0;
			o__.oOO. = this.O__.oOO.;
			if (o__.oOO. != null)
			{
				o__.oOO..CheckedChanged += value;
			}
		}

		// Token: 0x060032D6 RID: 13014 RVA: 0x0015AAD7 File Offset: 0x00158CD7
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.O__.oOO.;
		}

		// Token: 0x060032D7 RID: 13015 RVA: 0x0015AADF File Offset: 0x00158CDF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.O__.oOO. = A_0;
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x0015AAE8 File Offset: 0x00158CE8
		internal string <<EMPTY_NAME>>()
		{
			return this.O__.oOO..ConnectionString;
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x0015AAF5 File Offset: 0x00158CF5
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.O__.oOO..ConnectionString = A_0;
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x0015AB04 File Offset: 0x00158D04
		internal bool <<EMPTY_NAME>>()
		{
			checked
			{
				try
				{
					this.O__.oOO..Open();
					this.oO0O.OO_.().Items.Add("请选择要导入的表...");
					string filterExpression = "[TABLE_TYPE]='TABLE' Or [TABLE_TYPE]='VIEW'";
					DataTable dataTable;
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.O__.oOO.))
					{
						o_O_o_oOoo__.o.oO0.(this.O__.oOO..ConnectionString);
						DbDataAdapter dbDataAdapter = new OleDbDataAdapter("select owner,table_name from all_tables where owner not LIKE '%SYS%'", this.O__.oOO.);
						dataTable = new DataTable();
						dbDataAdapter.Fill(dataTable);
						try
						{
							foreach (object obj in dataTable.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								this.oO0O.OO_.().Items.Add(string.Concat(new string[]
								{
									"\"",
									dataRow["OWNER"].ToString(),
									"\".\"",
									dataRow["TABLE_NAME"].ToString(),
									"\""
								}));
							}
							goto IL_16F;
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
					dataTable = this.O__.oOO..GetSchema("Tables");
					DataRow[] array = dataTable.Select(filterExpression);
					for (int i = 0; i < array.Length; i++)
					{
						string text = Conversions.ToString(array[i]["TABLE_NAME"]);
						if (!o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text) && !text.StartsWith("~"))
						{
							this.oO0O.OO_.().Items.Add(text);
						}
					}
					IL_16F:
					if (this.oO0O.OO_.().Items.Count > 0)
					{
						this.oO0O.OO_.().SelectedIndex = 0;
					}
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
					return false;
				}
				finally
				{
					if (this.O__.oOO..State == ConnectionState.Open)
					{
						this.O__.oOO..Close();
					}
				}
				return true;
			}
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x0015AD28 File Offset: 0x00158F28
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oO0O.OO_.().SelectedIndex == 0)
			{
				this.O0OO.o.().DataSource = null;
				return;
			}
			int value;
			if (!int.TryParse(this.oO0O.OO_.().Text, out value))
			{
				value = 10;
			}
			OleDbDataAdapter oleDbDataAdapter;
			if (!this.O0OO.o.().Checked)
			{
				string selectCommandText;
				if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.O__.oOO.))
				{
					selectCommandText = "Select * From " + this.oO0O.OO_.().SelectedItem.ToString() + " Where ROWNUM <= " + Conversions.ToString(value);
				}
				else
				{
					selectCommandText = string.Concat(new string[]
					{
						"Select Top ",
						Conversions.ToString(value),
						" * From [",
						this.oO0O.OO_.().SelectedItem.ToString(),
						"]"
					});
				}
				oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, this.O__.oOO.);
			}
			else
			{
				string selectCommandText2;
				if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.O__.oOO.))
				{
					selectCommandText2 = "Select * From " + this.oO0O.OO_.().SelectedItem.ToString();
				}
				else
				{
					selectCommandText2 = "Select * From [" + this.oO0O.OO_.().SelectedItem.ToString() + "]";
				}
				oleDbDataAdapter = new OleDbDataAdapter(selectCommandText2, this.O__.oOO.);
			}
			DataTable dataTable = new DataTable();
			oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
			oleDbDataAdapter.Fill(dataTable);
			this.O0OO.o.().DataSource = dataTable;
			this.O0OO.o.().AutoSizeCols(15);
		}

		// Token: 0x060032DC RID: 13020 RVA: 0x0015AE84 File Offset: 0x00159084
		internal bool <<EMPTY_NAME>>()
		{
			Connection connection = new ConnectionClass();
			DataLinks dataLinks = new DataLinksClass();
			connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;";
			try
			{
				IDataSourceLocator dataSourceLocator = dataLinks;
				object obj = connection;
				if (dataSourceLocator.PromptEdit(ref obj) && Operators.CompareString(connection.ConnectionString, "Provider=Microsoft.Jet.OLEDB.4.0;", true) != 0)
				{
					this.O.OOo_.(connection.ConnectionString);
					return true;
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			return false;
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x0015AF08 File Offset: 0x00159108
		public O_\u3000\u3000(string A_0)
		{
			base.FormClosed += this.O0OO.o.;
			this.O__.oOO. = new OleDbConnection();
			this.oO0O.OO_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.O.OOo_.(A_0);
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x0015AF5C File Offset: 0x0015915C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oO0O.OO_.().SelectedIndex >= 1)
			{
				if (this.O0OO.o.().Cols.Fixed == this.O0OO.o.().Cols.Count)
				{
					MessageBox.Show("没有数据可导入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u = new o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(this.oO0O.OO_.().SelectedItem.ToString(), "");
				o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.(true);
				string str = "_Identify";
				List<string> list = new List<string>();
				if (o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() == DialogResult.OK)
				{
					string text = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.();
					string text2 = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.Ooo___0oo._o_o.();
					o_oo0 o_oo = new o_oo0(O_O0OO.OoO.0OO__0ooo.(), false, true);
					try
					{
						this.Cursor = Cursors.WaitCursor;
						Foxtable.RibbonMenu.StatusBar.Message1 = "正在导入...";
						Application.DoEvents();
						o_oo.o0_oo0._.().Open("", "", "", -1);
						o_oo.o0_oo0._.().ActiveConnection = o_oo.o0_oo0._.();
						Table table = new TableClass();
						Index index = new IndexClass();
						table.Name = "~TMPCLP" + text;
						table.Columns.Append("_Identify", ADOX.DataTypeEnum.adInteger, 0);
						table.Columns.Append("_Locked", ADOX.DataTypeEnum.adBoolean, 0);
						index.Name = "PrimaryKey";
						index.Columns.Append("_Identify", ADOX.DataTypeEnum.adVarWChar, 0);
						index.PrimaryKey = true;
						index.Unique = true;
						table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
						int @fixed = this.O0OO.o.().Cols.Fixed;
						int num = this.O0OO.o.().Cols.Count - 1;
						for (int i = @fixed; i <= num; i++)
						{
							DataColumn dataColumn = ((DataTable)this.O0OO.o.().DataSource).Columns[this.O0OO.o.().Cols[i].Name];
							if (!o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName))
							{
								string left = dataColumn.DataType.Name.ToLower();
								if (Operators.CompareString(left, "string", true) == 0)
								{
									if (dataColumn.MaxLength == -1 | dataColumn.MaxLength > 255)
									{
										table.Columns.Append(dataColumn.ColumnName, ADOX.DataTypeEnum.adLongVarWChar, 0);
									}
									else
									{
										table.Columns.Append(dataColumn.ColumnName, ADOX.DataTypeEnum.adVarWChar, dataColumn.MaxLength);
									}
								}
								else if (Operators.CompareString(left, "datetime", true) == 0)
								{
									table.Columns.Append(dataColumn.ColumnName, ADOX.DataTypeEnum.adDate, 0);
								}
								else if (Operators.CompareString(left, "boolean", true) == 0)
								{
									table.Columns.Append(dataColumn.ColumnName, ADOX.DataTypeEnum.adBoolean, 0);
								}
								else if (Operators.CompareString(left, "byte", true) == 0)
								{
									table.Columns.Append(dataColumn.ColumnName, ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
								}
								else if (Operators.CompareString(left, "int16", true) == 0)
								{
									table.Columns.Append(dataColumn.ColumnName, ADOX.DataTypeEnum.adSmallInt, 0);
								}
								else if (Operators.CompareString(left, "int32", true) == 0)
								{
									table.Columns.Append(dataColumn.ColumnName, ADOX.DataTypeEnum.adInteger, 0);
								}
								else if (Operators.CompareString(left, "int64", true) == 0)
								{
									if (this.O0OO.o.().IndexOf("Microsoft.Jet.OLEDB.4.0", StringComparison.CurrentCultureIgnoreCase) >= 0 || this.O0OO.o.().IndexOf("Microsoft.ACE.OLEDB.12.0", StringComparison.CurrentCultureIgnoreCase) >= 0)
									{
										table.Columns.Append(dataColumn.ColumnName, ADOX.DataTypeEnum.adDouble, 0);
									}
									else
									{
										table.Columns.Append(dataColumn.ColumnName, ADOX.DataTypeEnum.adBigInt, 0);
									}
								}
								else if (Operators.CompareString(left, "single", true) == 0)
								{
									table.Columns.Append(dataColumn.ColumnName, ADOX.DataTypeEnum.adSingle, 0);
								}
								else if (Operators.CompareString(left, "double", true) == 0)
								{
									table.Columns.Append(dataColumn.ColumnName, ADOX.DataTypeEnum.adDouble, 0);
								}
								else
								{
									if (Operators.CompareString(left, "decimal", true) != 0)
									{
										goto IL_4B0;
									}
									table.Columns.Append(dataColumn.ColumnName, ADOX.DataTypeEnum.adNumeric, 0);
									table.Columns[dataColumn.ColumnName].Precision = 28;
									table.Columns[dataColumn.ColumnName].NumericScale = this.oO0O.OO_.(dataColumn.ColumnName);
								}
								if (dataColumn.DataType != typeof(bool))
								{
									table.Columns[dataColumn.ColumnName].Attributes = ColumnAttributesEnum.adColNullable;
								}
								str = str + "," + dataColumn.ColumnName;
								list.Add(dataColumn.ColumnName);
							}
							IL_4B0:;
						}
						_Connection connection = o_oo.o0_oo0._.();
						string commandText = string.Concat(new string[]
						{
							"Delete * From [",
							ooO0__OO.O00.O__o.(),
							"] Where [Table]  = '",
							table.Name,
							"'"
						});
						object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
						connection.Execute(commandText, out objectValue, -1);
						_Connection connection2 = o_oo.o0_oo0._.();
						string commandText2 = string.Concat(new string[]
						{
							"Insert into [",
							ooO0__OO.O00.O__o.(),
							"] ([Table],[Identify]) values ('",
							table.Name,
							"', 1)"
						});
						objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
						connection2.Execute(commandText2, out objectValue, -1);
						o_oo.o0_oo0._.().Tables.Append(table);
						o_oo.o0_oo0._.().Close();
						O_O0OO.OoO.0OO__0ooo.().Open();
						o0OoOOoOOo0.OO0._Oo0o.(O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.DataTables, O_O0OO.OOOo.oo_OOOO_0.(), "~TMPCLP" + text, true, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), false);
						O_O0OO.OoO.0OO__0ooo.().Close();
						OO_00oOO.DataTables[text].o.0O000_.();
						try
						{
							foreach (object obj in ((DataTable)this.O0OO.o.().DataSource).Rows)
							{
								DataRow dataRow = (DataRow)obj;
								DataTable dataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables[text];
								DataRow dataRow2 = dataTable.NewRow();
								int num2;
								num2++;
								try
								{
									foreach (string columnName in list)
									{
										dataRow2[columnName] = RuntimeHelpers.GetObjectValue(dataRow[columnName]);
									}
								}
								finally
								{
									List<string>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
								dataTable.Rows.Add(dataRow2);
								dataTable = null;
								if (num2 % 100 == 0)
								{
									Foxtable.RibbonMenu.StatusBar.Message1 = "正在导入，已经完成" + Conversions.ToString(num2) + "条记录...";
									Application.DoEvents();
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
						Foxtable.RibbonMenu.StatusBar.Message1 = "导入完成，正在保存数据...";
						Application.DoEvents();
						OO_00oOO.DataTables[text].oO.o_0.(false, true);
						OO_00oOO.DataTables[text].Caption = text2;
						OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[text]);
						Main.OO_O.o..o0_o_o_0.0O.(text, true, false);
						Main.OO_O.o..OO_O_0Oo.___o.().SelectedIndex = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.Count - 1;
						if (Operators.CompareString(text2, "", true) > 0)
						{
							OO_00oOO.DataTables[text].OO00_o.ooOO.(false);
						}
						O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
						o_oo.ooo.0.();
						if (MessageBox.Show("已经成功导入，是否继续导入其它表？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						{
							base.DialogResult = DialogResult.OK;
						}
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
					}
					finally
					{
						if (o_oo.o0_oo0._.().State == 1)
						{
							o_oo.o0_oo0._.().Close();
						}
						if (O_O0OO.OoO.0OO__0ooo.().State == ConnectionState.Open)
						{
							O_O0OO.OoO.0OO__0ooo.().Close();
						}
						Foxtable.RibbonMenu.StatusBar.Message1 = "";
						this.Cursor = Cursors.Default;
					}
				}
			}
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x0015B7BC File Offset: 0x001599BC
		private byte <<EMPTY_NAME>>(string A_0)
		{
			Catalog catalog = new CatalogClass();
			Connection connection = new ConnectionClass();
			try
			{
				connection.ConnectionString = this.O__.oOO..ConnectionString;
				connection.Open("", "", "", -1);
				catalog.ActiveConnection = connection;
				string text = this.oO0O.OO_.().SelectedItem.ToString();
				string provider = connection.Provider;
				if (provider.StartsWith("OraOLEDB", StringComparison.CurrentCultureIgnoreCase) || provider.StartsWith("MSDAORA", StringComparison.CurrentCultureIgnoreCase))
				{
					text = text.Replace("\"", "");
					text = text.Substring(text.IndexOf(".") + 1);
				}
				return catalog.Tables[text].Columns[A_0].NumericScale;
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				if (connection.State == 1)
				{
					connection.Close();
				}
			}
			return 4;
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x0015B8CC File Offset: 0x00159ACC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0OO.o.().Col >= this.O0OO.o.().Cols.Fixed)
			{
				int leftCol = this.O0OO.o.().Selection.LeftCol;
				int rightCol = this.O0OO.o.().Selection.RightCol;
				int num = leftCol;
				int num2 = rightCol;
				for (int i = num; i <= num2; i++)
				{
					this.O0OO.o.().Cols.Remove(leftCol);
				}
			}
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x0015B942 File Offset: 0x00159B42
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_0.o_oo0_OO.(null, null);
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x0015B94C File Offset: 0x00159B4C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oO0O.OO_.().Modified)
			{
				this.o_0.o_oo0_OO.(null, null);
				this.oO0O.OO_.().Modified = false;
			}
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x0015B96F File Offset: 0x00159B6F
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400145E RID: 5214
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400145F RID: 5215
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001460 RID: 5216
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001461 RID: 5217
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001462 RID: 5218
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001463 RID: 5219
		[CompilerGenerated]
		private System.Windows.Forms.Label <<EMPTY_NAME>>;

		// Token: 0x04001464 RID: 5220
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04001465 RID: 5221
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001466 RID: 5222
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001467 RID: 5223
		private OleDbConnection <<EMPTY_NAME>>;
	}
}
