using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000390 RID: 912
	[DesignerGenerated]
	internal partial class o\u3000\u3002\u3002\u3000\u3002\u3002\u3000\u3002\u3002\u3002 : Form
	{
		// Token: 0x06003B7B RID: 15227 RVA: 0x001AEEDF File Offset: 0x001AD0DF
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.O0O__O0oo_._. != null)
			{
				this.O0O__O0oo_._..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x001AEF00 File Offset: 0x001AD100
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oo__0OO_.O__.(new SplitContainer());
			this.oo__0OO_.O__.(new ListBox());
			this.o_.o_oo0O_oo_.(new C1FlexGrid());
			this.o.00_0_0.(new C1Button());
			this.o_.o_oo0O_oo_.(new C1Button());
			this.oo__0OO_.O__.(new Label());
			this.o_.o_oo0O_oo_.().Panel1.SuspendLayout();
			this.o_.o_oo0O_oo_.().Panel2.SuspendLayout();
			this.o_.o_oo0O_oo_.().SuspendLayout();
			((ISupportInitialize)this.o_.o_oo0O_oo_.()).BeginInit();
			base.SuspendLayout();
			this.o_.o_oo0O_oo_.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.o_.o_oo0O_oo_.().FixedPanel = FixedPanel.Panel1;
			this.o_.o_oo0O_oo_.().Location = new Point(0, 0);
			this.o_.o_oo0O_oo_.().Name = "SplitContainer1";
			this.o_.o_oo0O_oo_.().Panel1.Controls.Add(this.o_.o_oo0O_oo_.());
			this.o_.o_oo0O_oo_.().Panel2.Controls.Add(this.o_.o_oo0O_oo_.());
			this.o_.o_oo0O_oo_.().Size = new Size(860, 523);
			this.o_.o_oo0O_oo_.().SplitterDistance = 216;
			this.o_.o_oo0O_oo_.().TabIndex = 0;
			this.o_.o_oo0O_oo_.().Dock = DockStyle.Fill;
			this.o_.o_oo0O_oo_.().FormattingEnabled = true;
			this.o_.o_oo0O_oo_.().IntegralHeight = false;
			this.o_.o_oo0O_oo_.().ItemHeight = 12;
			this.o_.o_oo0O_oo_.().Location = new Point(0, 0);
			this.o_.o_oo0O_oo_.().Name = "TableList";
			this.o_.o_oo0O_oo_.().Size = new Size(216, 523);
			this.o_.o_oo0O_oo_.().TabIndex = 0;
			this.o_.o_oo0O_oo_.().ColumnInfo = "10,1,0,0,0,0,Columns:";
			this.o_.o_oo0O_oo_.().Dock = DockStyle.Fill;
			this.o_.o_oo0O_oo_.().Location = new Point(0, 0);
			this.o_.o_oo0O_oo_.().Name = "C1FlexGrid1";
			this.o_.o_oo0O_oo_.().Rows.DefaultSize = 19;
			this.o_.o_oo0O_oo_.().Size = new Size(640, 523);
			this.o_.o_oo0O_oo_.().TabIndex = 0;
			this.o0oo_o_0OOo_.O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o0oo_o_0OOo_.O.().Location = new Point(86, 537);
			this.o0oo_o_0OOo_.O.().Name = "btnDelete";
			this.o0oo_o_0OOo_.O.().Size = new Size(75, 23);
			this.o0oo_o_0OOo_.O.().TabIndex = 3;
			this.o0oo_o_0OOo_.O.().Text = "删除";
			this.o0oo_o_0OOo_.O.().UseVisualStyleBackColor = true;
			this.o.00_0_0.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.o.00_0_0.().Location = new Point(5, 537);
			this.o.00_0_0.().Name = "btnRename";
			this.o.00_0_0.().Size = new Size(75, 23);
			this.o.00_0_0.().TabIndex = 2;
			this.o.00_0_0.().Text = "重命名";
			this.o.00_0_0.().UseVisualStyleBackColor = true;
			this.o_.o_oo0O_oo_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.o_.o_oo0O_oo_.().AutoSize = true;
			this.o_.o_oo0O_oo_.().ForeColor = Color.Red;
			this.o_.o_oo0O_oo_.().Location = new Point(681, 542);
			this.o_.o_oo0O_oo_.().Name = "Label1";
			this.o_.o_oo0O_oo_.().Size = new Size(167, 12);
			this.o_.o_oo0O_oo_.().TabIndex = 1;
			this.o_.o_oo0O_oo_.().Text = "提示：这里只显示100行的数据";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(860, 566);
			base.Controls.Add(this.o0oo_o_0OOo_.O.());
			base.Controls.Add(this.o_.o_oo0O_oo_.());
			base.Controls.Add(this.o.00_0_0.());
			base.Controls.Add(this.o_.o_oo0O_oo_.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O0..0...";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "数据源预览";
			this.o_.o_oo0O_oo_.().Panel1.ResumeLayout(false);
			this.o_.o_oo0O_oo_.().Panel2.ResumeLayout(false);
			this.o_.o_oo0O_oo_.().ResumeLayout(false);
			((ISupportInitialize)this.o_.o_oo0O_oo_.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x001AF371 File Offset: 0x001AD571
		[CompilerGenerated]
		internal virtual SplitContainer <<EMPTY_NAME>>()
		{
			return this.oo__0OO_.O__.;
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x001AF379 File Offset: 0x001AD579
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SplitContainer A_0)
		{
			this.oo__0OO_.O__. = A_0;
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x001AF382 File Offset: 0x001AD582
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.oo__0OO_.O__.;
		}

		// Token: 0x06003B80 RID: 15232 RVA: 0x001AF38C File Offset: 0x001AD58C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			EventHandler value = new EventHandler(this.O_0OoO.0O.);
			ListBox listBox = this.oo__0OO_.O__.;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged -= value;
			}
			this.oo__0OO_.O__. = A_0;
			listBox = this.oo__0OO_.O__.;
			if (listBox != null)
			{
				listBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x001AF3CF File Offset: 0x001AD5CF
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.oo__0OO_.O__.;
		}

		// Token: 0x06003B82 RID: 15234 RVA: 0x001AF3D7 File Offset: 0x001AD5D7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.oo__0OO_.O__. = A_0;
		}

		// Token: 0x06003B83 RID: 15235 RVA: 0x001AF3E0 File Offset: 0x001AD5E0
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo__0OO_.O__.;
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x001AF3E8 File Offset: 0x001AD5E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo__0OO_.O__. = A_0;
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x001AF3F1 File Offset: 0x001AD5F1
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo__0OO_.O__.;
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x001AF3FC File Offset: 0x001AD5FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.ooo0.);
			C1Button c1Button = this.oo__0OO_.O__.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oo__0OO_.O__. = A_0;
			c1Button = this.oo__0OO_.O__.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x001AF43F File Offset: 0x001AD63F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_.o0Oo.;
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x001AF448 File Offset: 0x001AD648
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0oo_o_0OOo_.O.);
			C1Button o_.o0Oo. = this.O_.o0Oo.;
			if (o_.o0Oo. != null)
			{
				o_.o0Oo..Click -= value;
			}
			this.O_.o0Oo. = A_0;
			o_.o0Oo. = this.O_.o0Oo.;
			if (o_.o0Oo. != null)
			{
				o_.o0Oo..Click += value;
			}
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x001AF48C File Offset: 0x001AD68C
		internal o\u3000\u3002\u3002\u3000\u3002\u3002\u3000\u3002\u3002\u3002(string A_0)
		{
			base.FormClosed += this.o0oo_o_0OOo_.O.;
			this.O0O__O0oo_._. = 10;
			this.o_.o_oo0O_oo_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.O0O__O0oo_._. = A_0.Trim();
			this.o0oo_o_0OOo_.O.().Visible = false;
			this.o.00_0_0.().Visible = false;
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x001AF4F8 File Offset: 0x001AD6F8
		internal o\u3000\u3002\u3002\u3000\u3002\u3002\u3000\u3002\u3002\u3002(OleDbConnection A_0, O0O A_1, string A_2)
		{
			base.FormClosed += this.o0oo_o_0OOo_.O.;
			this.O0O__O0oo_._. = 10;
			this.o_.o_oo0O_oo_.();
			this.O0O__O0oo_._. = A_0;
			this.O0O__O0oo_._. = A_1;
			this.OO0_0oO.o. = A_2;
			if (this.O0O__O0oo_._. == null)
			{
				this.o0oo_o_0OOo_.O.().Visible = false;
				this.o.00_0_0.().Visible = false;
			}
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x001AF560 File Offset: 0x001AD760
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				if (this.O0O__O0oo_._. == null && this.O0O__O0oo_._. == null)
				{
					if (this.O0O__O0oo_._..StartsWith("http://", StringComparison.OrdinalIgnoreCase) || this.O0O__O0oo_._..StartsWith("https://", StringComparison.OrdinalIgnoreCase))
					{
						this.O0O__O0oo_._. = new O0O(this.O0O__O0oo_._.);
					}
					else
					{
						this.O0O__O0oo_._. = new OleDbConnection(this.O0O__O0oo_._.);
					}
				}
				if (this.O0O__O0oo_._. != null)
				{
					this.O0O__O0oo_._..Open();
					DataTable dataTable;
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.O0O__O0oo_._.))
					{
						o_O_o_oOoo__.o.oO0.(this.O0O__O0oo_._..ConnectionString);
						DbDataAdapter dbDataAdapter = new OleDbDataAdapter("select owner,table_name from all_tables where owner not LIKE '%SYS%'", this.O0O__O0oo_._.);
						dataTable = new DataTable();
						dbDataAdapter.Fill(dataTable);
						try
						{
							foreach (object obj in dataTable.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								this.o_.o_oo0O_oo_.().Items.Add(string.Concat(new string[]
								{
									"\"",
									dataRow["OWNER"].ToString(),
									"\".\"",
									dataRow["TABLE_NAME"].ToString(),
									"\""
								}));
							}
							goto IL_23F;
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
					dataTable = this.O0O__O0oo_._..GetSchema("Tables");
					string filterExpression;
					if (this.O0O__O0oo_._. == null)
					{
						filterExpression = "[TABLE_TYPE]='TABLE' Or [TABLE_TYPE]='VIEW'";
					}
					else
					{
						filterExpression = "[TABLE_TYPE]='TABLE'";
					}
					foreach (DataRow dataRow2 in dataTable.Select(filterExpression))
					{
						string text = Conversions.ToString(dataRow2["TABLE_NAME"]);
						if (!dataRow2.IsNull("TABLE_SCHEMA") && Operators.CompareString(dataRow2["TABLE_SCHEMA"].ToString(), "dbo", true) != 0)
						{
							text = string.Concat(new string[]
							{
								"[",
								dataRow2["TABLE_SCHEMA"].ToString(),
								"].[",
								text,
								"]"
							});
						}
						if (!o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text) && !text.StartsWith("~"))
						{
							this.o_.o_oo0O_oo_.().Items.Add(text);
						}
					}
					IL_23F:
					this.O0O__O0oo_._..Close();
				}
				else
				{
					List<string> list = this.O0O__O0oo_._..OO._o_OO.();
					try
					{
						foreach (string text2 in list)
						{
							if (!o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text2) && !text2.StartsWith("~"))
							{
								this.o_.o_oo0O_oo_.().Items.Add(text2);
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				if (this.o_.o_oo0O_oo_.().Items.Count > 0)
				{
					this.o_.o_oo0O_oo_.().SelectedIndex = 0;
				}
				base.ShowDialog();
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
				base.Close();
			}
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x001AF8B8 File Offset: 0x001ADAB8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataTable dataTable = new DataTable();
			if (this.o_.o_oo0O_oo_.().SelectedItem != null)
			{
				string text = Conversions.ToString(this.o_.o_oo0O_oo_.().SelectedItem);
				if (this.O0O__O0oo_._. != null)
				{
					if (!o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.O0O__O0oo_._.) && !text.StartsWith("["))
					{
						text = "[" + text + "]";
					}
					OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.O0O__O0oo_._.))
					{
						oleDbDataAdapter = new OleDbDataAdapter("Select * From " + text + " WHERE ROWNUM <= 100", this.O0O__O0oo_._.);
					}
					else
					{
						oleDbDataAdapter = new OleDbDataAdapter("Select Top 10 * From " + text, this.O0O__O0oo_._.);
					}
					oleDbDataAdapter.Fill(dataTable);
				}
				else
				{
					HttpClient httpClient = this.O0O__O0oo_._..oO0_0.o.();
					httpClient.FormData["Datatable"] = text;
					httpClient.FormData["Top"] = "100";
					httpClient.FormData["Action"] = 2.ToString();
					httpClient.FormData["IgnoreSchema"] = "True";
					dataTable = httpClient.GetBaseDataTable();
					httpClient.Reset();
				}
				this.o_.o_oo0O_oo_.().BeginUpdate();
				this.o_.o_oo0O_oo_.().AutoResize = true;
				this.o_.o_oo0O_oo_.().DataSource = dataTable;
				int num = this.o_.o_oo0O_oo_.().Cols.Count - 1;
				int @fixed = this.o_.o_oo0O_oo_.().Cols.Fixed;
				for (int i = num; i >= @fixed; i += -1)
				{
					if (o_O_o_oOoo__.oO.O_..Contains(this.o_.o_oo0O_oo_.().Cols[i].Name))
					{
						this.o_.o_oo0O_oo_.().Cols.Remove(i);
					}
				}
				this.o_.o_oo0O_oo_.().EndUpdate();
				return;
			}
			this.o_.o_oo0O_oo_.().DataSource = null;
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x001AFA80 File Offset: 0x001ADC80
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o_.o_oo0O_oo_.().SelectedItem != null)
			{
				int selectedIndex = this.o_.o_oo0O_oo_.().SelectedIndex;
				string text = this.o_.o_oo0O_oo_.().SelectedItem.ToString();
				object obj = text;
				if (text.StartsWith("[") && text.EndsWith("]") && text.IndexOf("].[") > 0)
				{
					obj = text.Substring(text.LastIndexOf("].[") + 3).Trim(new char[]
					{
						']'
					});
				}
				if (OO_00oOO.InputValue(ref obj, "重命名", "请输入新的表名:"))
				{
					string text2 = obj.ToString();
					if (Operators.CompareString(text2, "", true) != 0 && Operators.CompareString(text2, text, true) != 0)
					{
						if (o_O_o_oOoo__.OOOO_OO._oo.(this.O0O__O0oo_._.))
						{
							OleDbCommand oleDbCommand = new OleDbCommand(string.Concat(new string[]
							{
								"exec sp_rename '",
								text,
								"','",
								text2,
								"'"
							}), this.O0O__O0oo_._.);
							try
							{
								this.O0O__O0oo_._..Open();
								oleDbCommand.ExecuteNonQuery();
								goto IL_165;
							}
							catch (Exception a_)
							{
								ooO.oOo0Oo.o.(a_, "");
								return;
							}
							finally
							{
								this.O0O__O0oo_._..Close();
							}
						}
						o_oo0 o_oo = new o_oo0(this.O0O__O0oo_._., false, false);
						o_oo.o0_oo0._.().O.0_O.(text).Name = text2;
						if (o_oo.o0_oo0._.(true, false) == 0)
						{
							return;
						}
						IL_165:
						if (text.StartsWith("[") && text.EndsWith("]") && text.IndexOf("].[") > 0)
						{
							text2 = text.Substring(0, text.LastIndexOf("].[")) + "].[" + text2 + "]";
						}
						this.o_.o_oo0O_oo_.().Items.Insert(selectedIndex, text2);
						this.o_.o_oo0O_oo_.().SelectedIndex = selectedIndex;
						this.o_.o_oo0O_oo_.().Items.RemoveAt(selectedIndex + 1);
						try
						{
							foreach (object obj2 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows)
							{
								DataRow dataRow = (DataRow)obj2;
								if (Conversions.ToInteger(dataRow["Type"]) == 0 && Operators.CompareString(dataRow["DataSource"].ToString(), this.OO0_0oO.o., true) == 0)
								{
									OuterTableSetting outerTableSetting = new OuterTableSetting();
									o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, dataRow["Property"].ToString(), '\v');
									if (Operators.CompareString(outerTableSetting.SourceTable, text, true) == 0)
									{
										outerTableSetting.SourceTable = text2;
										dataRow["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, false, '\v', false);
									}
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
						try
						{
							foreach (object obj3 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows)
							{
								DataRow dataRow2 = (DataRow)obj3;
								if (Conversions.ToInteger(dataRow2["Type"]) == 1 && Operators.CompareString(dataRow2["DataSource"].ToString(), this.OO0_0oO.o., true) == 0)
								{
									string text3 = dataRow2["Property"].ToString();
									if (text3.StartsWith("{") && text3.EndsWith("}"))
									{
										JoinTableProperty joinTableProperty = new JoinTableProperty();
										text3 = text3.Trim(new char[]
										{
											'{',
											'}'
										});
										o_O_o_oOoo__.OOOO_OO._oo.(joinTableProperty, text3, '\v');
										if (Operators.CompareString(joinTableProperty.BaseTable, text, true) == 0)
										{
											joinTableProperty.BaseTable = text2;
										}
										if (Operators.CompareString(joinTableProperty.Columns, "", true) > 0)
										{
											joinTableProperty.Columns = joinTableProperty.Columns.Replace("{" + text + "}", "{" + text2 + "}");
										}
										if (Operators.CompareString(joinTableProperty.LinkTables, "", true) > 0)
										{
											string[] array = joinTableProperty.LinkTables.Split(new char[]
											{
												'\n'
											});
											int num = array.Length - 1;
											for (int i = 0; i <= num; i++)
											{
												string[] array2 = array[i].Split(new char[]
												{
													'\t'
												});
												if (Operators.CompareString(array2[0], text, true) == 0)
												{
													array2[0] = text2;
												}
												if (Operators.CompareString(array2[2], text, true) == 0)
												{
													array2[2] = text2;
												}
												array[i] = string.Join("\t", array2);
											}
											joinTableProperty.LinkTables = string.Join("\n", array);
										}
										dataRow2["Property"] = "{" + o_O_o_oOoo__.OOOO_OO._oo.(joinTableProperty, false, '\v', false) + "}";
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
						this.O0O__O0oo_._. = true;
					}
				}
			}
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x001AFFEC File Offset: 0x001AE1EC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o_.o_oo0O_oo_.().SelectedItem != null)
			{
				string text = this.o_.o_oo0O_oo_.().SelectedItem.ToString();
				bool flag = true;
				try
				{
					foreach (object obj in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows)
					{
						DataRow dataRow = (DataRow)obj;
						if (Conversions.ToInteger(dataRow["Type"]) == 0)
						{
							string key = dataRow["DataSource"].ToString();
							if (O_O0OO.O._o_.().ContainsKey(key) && Operators.CompareString(O_O0OO.O._o_.()[key].ConnectionString, this.O0O__O0oo_._..ConnectionString, true) == 0)
							{
								OuterTableSetting outerTableSetting = new OuterTableSetting();
								o_O_o_oOoo__.OOOO_OO._oo.(outerTableSetting, dataRow["Property"].ToString(), '\v');
								if (Operators.CompareString(outerTableSetting.SourceTable, text, true) == 0)
								{
									flag = false;
									break;
								}
							}
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
				if (flag)
				{
					try
					{
						foreach (object obj2 in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].Rows)
						{
							DataRow dataRow2 = (DataRow)obj2;
							if (Conversions.ToInteger(dataRow2["Type"]) == 1)
							{
								string key2 = dataRow2["DataSource"].ToString();
								if (O_O0OO.O._o_.().ContainsKey(key2) && Operators.CompareString(O_O0OO.O._o_.()[key2].ConnectionString, this.O0O__O0oo_._..ConnectionString, true) == 0)
								{
									string text2 = dataRow2["Property"].ToString();
									if (text2.StartsWith("{") && text2.EndsWith("}"))
									{
										JoinTableProperty joinTableProperty = new JoinTableProperty();
										text2 = text2.Trim(new char[]
										{
											'{',
											'}'
										});
										o_O_o_oOoo__.OOOO_OO._oo.(joinTableProperty, text2, '\v');
										if (Operators.CompareString(joinTableProperty.BaseTable, text, true) == 0)
										{
											flag = false;
											break;
										}
										if (Operators.CompareString(joinTableProperty.LinkTables, "", true) > 0)
										{
											string[] array = joinTableProperty.LinkTables.Split(new char[]
											{
												'\n'
											});
											int num = array.Length - 1;
											for (int i = 0; i <= num; i++)
											{
												string[] array2 = array[i].Split(new char[]
												{
													'\t'
												});
												if (Operators.CompareString(array2[0], text, true) == 0)
												{
													flag = false;
													break;
												}
												if (Operators.CompareString(array2[2], text, true) == 0)
												{
													flag = false;
													break;
												}
											}
											if (!flag)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
				if (flag)
				{
					if (MessageBox.Show("删除表是不可撤销的，确定要删除表" + text + "吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
					{
						return;
					}
					try
					{
						this.O0O__O0oo_._..Open();
						new OleDbCommand("Drop Table [" + text + "]", this.O0O__O0oo_._.).ExecuteScalar();
						this.o_.o_oo0O_oo_.().Items.RemoveAt(this.o_.o_oo0O_oo_.().SelectedIndex);
						return;
					}
					catch (Exception a_)
					{
						ooO.oOo0Oo.o.(a_, "");
						return;
					}
					finally
					{
						this.O0O__O0oo_._..Close();
					}
				}
				MessageBox.Show(text + "表已经被当前项目使用，不能删除!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x001B03C4 File Offset: 0x001AE5C4
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001876 RID: 6262
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001877 RID: 6263
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x04001878 RID: 6264
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x04001879 RID: 6265
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x0400187A RID: 6266
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400187B RID: 6267
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400187C RID: 6268
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400187D RID: 6269
		private OleDbConnection <<EMPTY_NAME>>;

		// Token: 0x0400187E RID: 6270
		private O0O <<EMPTY_NAME>>;

		// Token: 0x0400187F RID: 6271
		private string <<EMPTY_NAME>>;

		// Token: 0x04001880 RID: 6272
		private int <<EMPTY_NAME>>;

		// Token: 0x04001881 RID: 6273
		private string <<EMPTY_NAME>>;

		// Token: 0x04001882 RID: 6274
		private HttpClient <<EMPTY_NAME>>;

		// Token: 0x04001883 RID: 6275
		internal bool <<EMPTY_NAME>>;
	}
}
