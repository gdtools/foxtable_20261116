using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Foxtable.My;
using Foxtable.RibbonMenu;
using Microsoft.VisualBasic.CompilerServices;
using MSDASC;

namespace Foxtable
{
	// Token: 0x02000345 RID: 837
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3000\u3002\u3000\u3002 : Form
	{
		// Token: 0x06003316 RID: 13078 RVA: 0x0015CE90 File Offset: 0x0015B090
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.Oo_o0.O0oOOo_. != null)
				{
					this.Oo_o0.O0oOOo_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x0015CED0 File Offset: 0x0015B0D0
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oo0o_o._.(new C1FlexGrid());
			this.oo0o_o._.(new C1ComboBox());
			this.oo0o_o._.(new C1Button());
			this.O0o__o_Oo00.o_.(new C1Button());
			this.O0OOoO0O.__0_.(new RadioButton());
			this.oo0o_o._.(new RadioButton());
			this.O0o__o_Oo00.o_.(new RadioButton());
			((ISupportInitialize)this.OOo.0_O.()).BeginInit();
			base.SuspendLayout();
			this.OOo.0_O.().AllowEditing = false;
			this.OOo.0_O.().ColumnInfo = "10,1,0,0,0,0,Columns:";
			this.OOo.0_O.().Location = new Point(12, 49);
			this.OOo.0_O.().Name = "Grid";
			this.OOo.0_O.().Rows.Count = 1;
			this.OOo.0_O.().Rows.DefaultSize = 20;
			this.OOo.0_O.().SelectionMode = SelectionModeEnum.Column;
			this.OOo.0_O.().Size = new Size(596, 272);
			this.OOo.0_O.().TabIndex = 1;
			this.OOo.0_O.().DropDownStyle = DropDownStyle.DropDownList;
			this.OOo.0_O.().Location = new Point(12, 13);
			this.OOo.0_O.().Name = "lstTables";
			this.OOo.0_O.().Size = new Size(374, 20);
			this.OOo.0_O.().TabIndex = 0;
			this.o0_o.__ooo_0_.().DialogResult = DialogResult.Cancel;
			this.o0_o.__ooo_0_.().Location = new Point(313, 370);
			this.o0_o.__ooo_0_.().Name = "Button3";
			this.o0_o.__ooo_0_.().Size = new Size(75, 23);
			this.o0_o.__ooo_0_.().TabIndex = 6;
			this.o0_o.__ooo_0_.().Text = "取消";
			this.o0_o.__ooo_0_.().UseVisualStyleBackColor = true;
			this.OOo.0_O.().Location = new Point(232, 370);
			this.OOo.0_O.().Name = "Button2";
			this.OOo.0_O.().Size = new Size(75, 23);
			this.OOo.0_O.().TabIndex = 5;
			this.OOo.0_O.().Text = "确定";
			this.OOo.0_O.().UseVisualStyleBackColor = true;
			this.o0_o.__ooo_0_.().AutoSize = true;
			this.o0_o.__ooo_0_.().Location = new Point(12, 338);
			this.o0_o.__ooo_0_.().Name = "UpdateExistRow";
			this.o0_o.__ooo_0_.().Size = new Size(107, 16);
			this.o0_o.__ooo_0_.().TabIndex = 2;
			this.o0_o.__ooo_0_.().Text = "更新同主键记录";
			this.o0_o.__ooo_0_.().UseVisualStyleBackColor = true;
			this.O.__o_.().AutoSize = true;
			this.O.__o_.().Location = new Point(142, 338);
			this.O.__o_.().Name = "SkipExistRow";
			this.O.__o_.().Size = new Size(107, 16);
			this.O.__o_.().TabIndex = 3;
			this.O.__o_.().Text = "跳过同主键记录";
			this.O.__o_.().UseVisualStyleBackColor = true;
			this.OOo.0_O.().AutoSize = true;
			this.OOo.0_O.().Checked = true;
			this.OOo.0_O.().Location = new Point(272, 338);
			this.OOo.0_O.().Name = "IgnorePrimaryKey";
			this.OOo.0_O.().Size = new Size(203, 16);
			this.OOo.0_O.().TabIndex = 4;
			this.OOo.0_O.().TabStop = true;
			this.OOo.0_O.().Text = "合并过程不比较主键(无条件合并)";
			this.OOo.0_O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(620, 407);
			base.Controls.Add(this.OOo.0_O.());
			base.Controls.Add(this.O.__o_.());
			base.Controls.Add(this.o0_o.__ooo_0_.());
			base.Controls.Add(this.OOo.0_O.());
			base.Controls.Add(this.OOo.0_O.());
			base.Controls.Add(this.o0_o.__ooo_0_.());
			base.Controls.Add(this.OOo.0_O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.0o..O.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "合并";
			((ISupportInitialize)this.OOo.0_O.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x0015D362 File Offset: 0x0015B562
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.Oo_o0.O0oOOo_.;
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x0015D36A File Offset: 0x0015B56A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.Oo_o0.O0oOOo_. = A_0;
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x0015D373 File Offset: 0x0015B573
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.Oo_o0.O0oOOo_.;
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x0015D37C File Offset: 0x0015B57C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O0o__o_Oo00.o_.);
			C1ComboBox oo_o0.O0oOOo_. = this.Oo_o0.O0oOOo_.;
			if (oo_o0.O0oOOo_. != null)
			{
				oo_o0.O0oOOo_..SelectedIndexChanged -= value;
			}
			this.Oo_o0.O0oOOo_. = A_0;
			oo_o0.O0oOOo_. = this.Oo_o0.O0oOOo_.;
			if (oo_o0.O0oOOo_. != null)
			{
				oo_o0.O0oOOo_..SelectedIndexChanged += value;
			}
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x0015D3BF File Offset: 0x0015B5BF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_o0.O0oOOo_.;
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x0015D3C7 File Offset: 0x0015B5C7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.Oo_o0.O0oOOo_. = A_0;
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x0015D3D0 File Offset: 0x0015B5D0
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O.oO0o.;
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x0015D3D8 File Offset: 0x0015B5D8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0OO0OoOO0._.);
			C1Button o.oO0o. = this.O.oO0o.;
			if (o.oO0o. != null)
			{
				o.oO0o..Click -= value;
			}
			this.O.oO0o. = A_0;
			o.oO0o. = this.O.oO0o.;
			if (o.oO0o. != null)
			{
				o.oO0o..Click += value;
			}
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x0015D41B File Offset: 0x0015B61B
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.Oo_o0.O0oOOo_.;
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x0015D423 File Offset: 0x0015B623
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.Oo_o0.O0oOOo_. = A_0;
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x0015D42C File Offset: 0x0015B62C
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O.oO0o.;
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x0015D434 File Offset: 0x0015B634
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O.oO0o. = A_0;
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x0015D43D File Offset: 0x0015B63D
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O0OOoO0O.__0_.;
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x0015D445 File Offset: 0x0015B645
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.O0OOoO0O.__0_. = A_0;
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x0015D44E File Offset: 0x0015B64E
		internal string <<EMPTY_NAME>>()
		{
			return this.Oo_o0.O0oOOo_..ConnectionString;
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x0015D45B File Offset: 0x0015B65B
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.Oo_o0.O0oOOo_..ConnectionString = A_0;
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x0015D46C File Offset: 0x0015B66C
		internal bool <<EMPTY_NAME>>()
		{
			checked
			{
				try
				{
					this.Oo_o0.O0oOOo_..Open();
					DataTable dataTable = this.Oo_o0.O0oOOo_..GetSchema("Tables");
					this.OOo.0_O.().Items.Add("请选择要合并的表...");
					string filterExpression = "[TABLE_TYPE]='TABLE'";
					if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.Oo_o0.O0oOOo_.))
					{
						o_O_o_oOoo__.o.oO0.(this.Oo_o0.O0oOOo_..ConnectionString);
						DbDataAdapter dbDataAdapter = new OleDbDataAdapter("select owner,table_name from all_tables where owner not LIKE '%SYS%'", this.Oo_o0.O0oOOo_.);
						dataTable = new DataTable();
						dbDataAdapter.Fill(dataTable);
						try
						{
							foreach (object obj in dataTable.Rows)
							{
								DataRow dataRow = (DataRow)obj;
								this.OOo.0_O.().Items.Add(string.Concat(new string[]
								{
									"\"",
									dataRow["OWNER"].ToString(),
									"\".\"",
									dataRow["TABLE_NAME"].ToString(),
									"\""
								}));
							}
							goto IL_15E;
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
					DataRow[] array = dataTable.Select(filterExpression);
					for (int i = 0; i < array.Length; i++)
					{
						string text = Conversions.ToString(array[i]["TABLE_NAME"]);
						if (!o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text))
						{
							this.OOo.0_O.().Items.Add(text);
						}
					}
					IL_15E:
					if (this.OOo.0_O.().Items.Count > 0)
					{
						this.OOo.0_O.().SelectedIndex = 0;
					}
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
					return false;
				}
				finally
				{
					if (this.Oo_o0.O0oOOo_..State == ConnectionState.Open)
					{
						this.Oo_o0.O0oOOo_..Close();
					}
				}
				return true;
			}
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x0015D680 File Offset: 0x0015B880
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OOo.0_O.().SelectedIndex == 0)
			{
				this.OOo.0_O.().DataSource = null;
				return;
			}
			string selectCommandText;
			if (o_O_o_oOoo__.OO0O_0.0O0o0_o.(this.Oo_o0.O0oOOo_.))
			{
				selectCommandText = "Select * From " + this.OOo.0_O.().SelectedItem.ToString();
			}
			else
			{
				selectCommandText = "Select * From [" + this.OOo.0_O.().SelectedItem.ToString() + "]";
			}
			OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommandText, this.Oo_o0.O0oOOo_.);
			DataTable dataTable = new DataTable();
			oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
			oleDbDataAdapter.Fill(dataTable);
			this.OOo.0_O.().AutoResize = true;
			this.OOo.0_O.().DataSource = dataTable;
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x0015D72C File Offset: 0x0015B92C
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
					this.oo0o_o._.(connection.ConnectionString);
					return true;
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			return false;
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x0015D7B0 File Offset: 0x0015B9B0
		public O\u3002\u3000\u3000\u3002\u3000\u3002(string A_0)
		{
			base.FormClosed += this.OOo.0_O.;
			this.Oo_o0.O0oOOo_. = new OleDbConnection();
			this.oo0o_o._.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oo0o_o._.(A_0);
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x0015D804 File Offset: 0x0015BA04
		public O\u3002\u3000\u3000\u3002\u3000\u3002(string A_0, bool A_1)
		{
			base.FormClosed += this.OOo.0_O.;
			this.Oo_o0.O0oOOo_. = new OleDbConnection();
			this.oo0o_o._.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			string extension = Path.GetExtension(A_0);
			if (Operators.CompareString(extension, ".mdb", true) == 0)
			{
				this.Oo_o0.O0oOOo_..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + A_0 + ";Jet OLEDB:Database Password=";
				this.oo0o_o._.();
				return;
			}
			if (Operators.CompareString(extension, ".accdb", true) == 0)
			{
				this.Oo_o0.O0oOOo_..ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + A_0 + ";Jet OLEDB:Database Password=";
				this.oo0o_o._.();
				return;
			}
			if (Operators.CompareString(extension, ".xls", true) == 0)
			{
				this.Oo_o0.O0oOOo_..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + A_0 + ";Extended Properties=\"Excel 8.0;HDR=YES\"";
				this.oo0o_o._.();
				return;
			}
			if (Operators.CompareString(extension, ".xlsx", true) == 0)
			{
				this.Oo_o0.O0oOOo_..ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + A_0 + ";Extended Properties=\"Excel 12.0;HDR=YES\"";
				this.oo0o_o._.();
				return;
			}
			if (Operators.CompareString(extension, ".dbf", true) == 0)
			{
				this.Oo_o0.O0oOOo_..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + c.OOOOO.o.().FileSystem.GetParentPath(A_0) + ";Extended Properties=dBASE IV";
				this.OOo.0_O.().Items.Add("请选择要合并的表...");
				this.OOo.0_O.().Items.Add(Path.GetFileNameWithoutExtension(A_0));
				this.OOo.0_O.().SelectedIndex = 1;
				return;
			}
			if (Operators.CompareString(extension, ".txt", true) == 0)
			{
				this.Oo_o0.O0oOOo_..ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + c.OOOOO.o.().FileSystem.GetParentPath(A_0) + ";Extended Properties=\"text;HDR=Yes;FMT=Delimited\"";
				this.OOo.0_O.().Items.Add("请选择要合并的表...");
				this.OOo.0_O.().Items.Add(Path.GetFileNameWithoutExtension(A_0) + "#TXT");
				this.OOo.0_O.().SelectedIndex = 1;
			}
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x0015DA08 File Offset: 0x0015BC08
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OOo.0_O.().SelectedIndex >= 1)
			{
				DataTable dataTable = (DataTable)this.OOo.0_O.().DataSource;
				DataTable dataTable2 = OO_00oOO.CurrentTable.DataTable.BaseTable;
				bool flag = true;
				bool flag2 = true;
				bool flag3;
				if (OO_00oOO.CurrentTable.DataTable.frd_IsInnerTable && dataTable.PrimaryKey.Length == 1 && Operators.CompareString(dataTable.PrimaryKey[0].ColumnName, "_Identiify", true) == 0 && (dataTable.PrimaryKey[0].DataType == typeof(int) || dataTable.PrimaryKey[0].DataType == typeof(long)))
				{
					flag3 = true;
				}
				List<string> list;
				checked
				{
					if (!flag3)
					{
						DataColumn[] primaryKey = dataTable2.PrimaryKey;
						int i = 0;
						while (i < primaryKey.Length)
						{
							DataColumn dataColumn = primaryKey[i];
							if (!dataTable.Columns.Contains(dataColumn.ColumnName) || dataTable.Columns[dataColumn.ColumnName].DataType != dataColumn.DataType)
							{
								flag = false;
								if (dataTable2.PrimaryKey.Length != 1 || !dataTable2.PrimaryKey[0].AutoIncrement)
								{
									MessageBox.Show("对于非兼容外部表，如果主键列不是自动增量型，则所有主键列必须在要合并的表中，有同名、同类型的对应列，否则无法合并。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									return;
								}
								break;
							}
							else
							{
								i++;
							}
						}
					}
					if (dataTable2.PrimaryKey.Length == 1 && dataTable2.PrimaryKey[0].AutoIncrement)
					{
						flag2 = true;
					}
					this.OOo.0_O.().BeginUpdate();
					list = new List<string>();
				}
				for (int j = dataTable.Columns.Count - 1; j >= 0; j += -1)
				{
					if (dataTable2.Columns.Contains(dataTable.Columns[j].ColumnName))
					{
						string columnName = dataTable.Columns[j].ColumnName;
						if (!flag2 || Operators.CompareString(dataTable2.PrimaryKey[0].ColumnName, columnName, true) != 0)
						{
							list.Add(dataTable.Columns[j].ColumnName);
						}
					}
				}
				try
				{
					this.Cursor = Cursors.WaitCursor;
					Foxtable.RibbonMenu.StatusBar.Message1 = "正在合并...";
					Application.DoEvents();
					OO_00oOO.CurrentTable.StopRedraw();
					try
					{
						foreach (object obj in dataTable.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							DataRow dataRow2 = null;
							if (flag & !this.OOo.0_O.().Checked)
							{
								object[] array = new object[dataTable2.PrimaryKey.Length - 1 + 1];
								int num = dataTable2.PrimaryKey.Length - 1;
								for (int k = 0; k <= num; k++)
								{
									array[k] = RuntimeHelpers.GetObjectValue(dataRow[dataTable2.PrimaryKey[k].ColumnName]);
								}
								dataRow2 = dataTable2.Rows.Find(array);
							}
							if (this.o0_o.__ooo_0_.().Checked || dataRow2 == null)
							{
								if (dataRow2 == null)
								{
									dataRow2 = dataTable2.NewRow();
								}
								try
								{
									foreach (string columnName2 in list)
									{
										dataRow2[columnName2] = RuntimeHelpers.GetObjectValue(dataRow[columnName2]);
									}
								}
								finally
								{
									List<string>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
								if (dataRow2.RowState == DataRowState.Detached)
								{
									dataTable2.Rows.Add(dataRow2);
								}
								int num2;
								num2++;
								if (num2 % 100 == 0)
								{
									Foxtable.RibbonMenu.StatusBar.Message1 = "正在合并，已经合并" + Conversions.ToString(num2) + "条记录";
									Application.DoEvents();
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
				}
				catch (Exception a_)
				{
					ooO.oOo0Oo.o.(a_, "");
					return;
				}
				finally
				{
					this.Cursor = Cursors.Default;
					Foxtable.RibbonMenu.StatusBar.Message1 = "";
					OO_00oOO.CurrentTable.ResumeRedraw();
				}
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x0015DE20 File Offset: 0x0015C020
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400147D RID: 5245
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400147E RID: 5246
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x0400147F RID: 5247
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001480 RID: 5248
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001481 RID: 5249
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001482 RID: 5250
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001483 RID: 5251
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001484 RID: 5252
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001485 RID: 5253
		private OleDbConnection <<EMPTY_NAME>>;
	}
}
