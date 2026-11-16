using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using ADOX;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200028B RID: 651
	internal class o_oo0
	{
		// Token: 0x06002086 RID: 8326 RVA: 0x000E1480 File Offset: 0x000DF680
		internal o_oo0(OleDbConnection A_0, bool A_1, bool A_2)
		{
			this.oo.oo0o0. = new CatalogClass();
			this.oo.oo0o0. = new ConnectionClass();
			this.oo.oo0o0. = A_1;
			this.o0o0.0O0o00O00. = A_2;
			this.oo.oo0o0. = A_0;
			this.oo.oo0o0..ConnectionString = this.oo.oo0o0..ConnectionString;
			this.oo.oo0o0. = new oOo_(this);
			this.oo.oo0o0. = new DataSet();
			this.oo__._. = new DataTable();
			this.o0o0.0O0o00O00. = new DataTable();
			this.oo__._..TableName = "tblTables";
			this.o0o0.0O0o00O00..TableName = "tblColumns";
			DataTable dataTable = this.oo__._.;
			dataTable.Columns.Add("TableName", typeof(string));
			dataTable.Columns.Add("TableCaption", typeof(string));
			DataTable dataTable2 = this.o0o0.0O0o00O00.;
			dataTable2.Columns.Add("TableName", typeof(string));
			dataTable2.Columns.Add("ColumnName", typeof(string));
			dataTable2.Columns.Add("DataType", typeof(ColumnDataTypeEnum));
			dataTable2.Columns.Add("MaxLength", typeof(int));
			dataTable2.Columns.Add("Caption", typeof(string));
			this.oo.oo0o0..Tables.Add(this.o0o0.0O0o00O00.);
			this.oo.oo0o0..Tables.Add(this.oo__._.);
			this.oo.oo0o0..Relations.Add("Re1", this.oo__._..Columns["TableName"], this.o0o0.0O0o00O00..Columns["TableName"]);
			this.ooo.0.();
			if (A_2)
			{
				this.oo.oo0o0. = "~TMPCLP";
			}
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x000E166C File Offset: 0x000DF86C
		internal oOo_ <<EMPTY_NAME>>()
		{
			return this.oo.oo0o0.;
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x000E1674 File Offset: 0x000DF874
		internal Catalog <<EMPTY_NAME>>()
		{
			return this.oo.oo0o0.;
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x000E167C File Offset: 0x000DF87C
		internal Connection <<EMPTY_NAME>>()
		{
			return this.oo.oo0o0.;
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x000E1684 File Offset: 0x000DF884
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				this.oo.oo0o0..Open("", "", "", -1);
				this.oo.oo0o0..ActiveConnection = this.oo.oo0o0.;
				this.o0o0.0O0o00O00..Clear();
				this.oo__._..Rows.Clear();
				List<string> list = new List<string>();
				try
				{
					foreach (object obj in this.oo.oo0o0..Tables)
					{
						Table table = (Table)obj;
						if (list.Contains(table.Name))
						{
							list.Remove(table.Name);
						}
						else
						{
							list.Add(table.Name);
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
					foreach (object obj2 in this.oo.oo0o0..Tables)
					{
						Table table2 = (Table)obj2;
						if (list.Contains(table2.Name))
						{
							string text = table2.Name;
							if (Operators.CompareString(table2.Type, "TABLE", true) == 0)
							{
								if (this.o0o0.0O0o00O00.)
								{
									if (o_O_o_oOoo__.Oo_0.OOo0oO0..Contains(text) || !text.StartsWith("~TMPCLP"))
									{
										continue;
									}
									text = text.Substring(7);
								}
								this.oo__._..Rows.Add(new object[]
								{
									text
								});
								try
								{
									foreach (object obj3 in table2.Columns)
									{
										Column column = (Column)obj3;
										if (!o_O_o_oOoo__.oO.O_..Contains(column.Name))
										{
											this.o0o0.0O0o00O00..Rows.Add(new object[]
											{
												text,
												column.Name,
												column.Type,
												column.DefinedSize
											});
										}
									}
								}
								finally
								{
									IEnumerator enumerator3;
									if (enumerator3 is IDisposable)
									{
										(enumerator3 as IDisposable).Dispose();
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
				this.oo__._..AcceptChanges();
				this.o0o0.0O0o00O00..AcceptChanges();
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				this.oo.oo0o0..Close();
			}
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x000E195C File Offset: 0x000DFB5C
		internal int <<EMPTY_NAME>>(bool A_0 = true, bool A_1 = false)
		{
			if (A_0)
			{
				OO_00oOO.DataTables.Save();
			}
			this.oo.oo0o0..Open("", "", "", -1);
			this.oo.oo0o0..ActiveConnection = this.oo.oo0o0.;
			int num2;
			foreach (DataRow dataRow in this.oo__._..Select("", "", DataViewRowState.Added))
			{
				string text = Conversions.ToString(dataRow["TableName"]);
				string text2 = dataRow["TableCaption"].ToString();
				Table table = new TableClass();
				table.ParentCatalog = this.oo.oo0o0.;
				Index index = new IndexClass();
				table.Name = this.oo.oo0o0. + text;
				table.Columns.Append("_Identify", ADOX.DataTypeEnum.adInteger, 0);
				table.Columns.Append("_Locked", ADOX.DataTypeEnum.adBoolean, 0);
				table.Columns.Append("_SortKey", ADOX.DataTypeEnum.adNumeric, 0);
				Column column = table.Columns["_SortKey"];
				column.Precision = 28;
				column.NumericScale = 14;
				column.Attributes = ColumnAttributesEnum.adColNullable;
				if (!this.o0o0.0O0o00O00.)
				{
					table.Columns["_Identify"].Properties["AutoIncrement"].Value = true;
				}
				if (this.oo.oo0o0.)
				{
					table.Columns["_Locked"].Attributes = ColumnAttributesEnum.adColNullable;
				}
				if (this.oo.oo0o0.)
				{
					index.Name = "PrimaryKey_" + text;
				}
				else
				{
					index.Name = "PrimaryKey";
				}
				index.Columns.Append("_Identify", ADOX.DataTypeEnum.adVarWChar, 0);
				index.PrimaryKey = true;
				index.Unique = true;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				this.oo.oo0o0..Tables.Append(table);
				int num = 1;
				do
				{
					if (this.o0o0.0O0o00O00.)
					{
						_Connection connection = this.oo.oo0o0.;
						string commandText = string.Concat(new string[]
						{
							"Insert into [",
							table.Name,
							"] ([_Identify],[_SortKey])  values(",
							Conversions.ToString(num),
							",",
							Conversions.ToString(num),
							")"
						});
						object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
						connection.Execute(commandText, out objectValue, -1);
					}
					else
					{
						_Connection connection2 = this.oo.oo0o0.;
						string commandText2 = string.Concat(new string[]
						{
							"Insert into [",
							table.Name,
							"] ([_SortKey])  values(",
							Conversions.ToString(num),
							")"
						});
						object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
						connection2.Execute(commandText2, out objectValue, -1);
					}
					num++;
				}
				while (num <= 10);
				if (this.o0o0.0O0o00O00.)
				{
					_Connection connection3 = this.oo.oo0o0.;
					string commandText3 = string.Concat(new string[]
					{
						"Delete * From [",
						ooO0__OO.O00.O__o.(),
						"] Where [Table]  = '",
						table.Name,
						"'"
					});
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					connection3.Execute(commandText3, out objectValue, -1);
					_Connection connection4 = this.oo.oo0o0.;
					string commandText4 = string.Concat(new string[]
					{
						"Insert into [",
						ooO0__OO.O00.O__o.(),
						"] ([Table],[Identify]) values ('",
						table.Name,
						"', 11)"
					});
					objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					connection4.Execute(commandText4, out objectValue, -1);
				}
				if (Operators.CompareString(text2, "", true) > 0)
				{
					_Connection connection5 = this.oo.oo0o0.;
					string commandText5 = string.Concat(new string[]
					{
						"Delete * From [",
						ooO0__OO.O0O.0o0.(),
						"] Where [Table]  = '",
						text,
						"'"
					});
					object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					connection5.Execute(commandText5, out objectValue, -1);
					_Connection connection6 = this.oo.oo0o0.;
					string commandText6 = string.Concat(new string[]
					{
						"Insert into [",
						ooO0__OO.O0O.0o0.(),
						"] ([Table],[Column],[Code],[Config]) Values('",
						text,
						"','', '','Caption\v",
						text2,
						"')"
					});
					objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
					connection6.Execute(commandText6, out objectValue, -1);
				}
				num2++;
			}
			if (!this.oo.oo0o0.)
			{
				try
				{
					foreach (object obj in this.oo__._..Rows)
					{
						DataRow dataRow2 = (DataRow)obj;
						if (!(dataRow2.RowState == DataRowState.Added | dataRow2.RowState == DataRowState.Deleted) && Operators.CompareString(Conversions.ToString(dataRow2["TableName", DataRowVersion.Original]), Conversions.ToString(dataRow2["TableName", DataRowVersion.Current]), true) != 0)
						{
							this.oo.oo0o0..Tables[this.oo.oo0o0. + Conversions.ToString(dataRow2["TableName", DataRowVersion.Original])].Name = this.oo.oo0o0. + Conversions.ToString(dataRow2["TableName", DataRowVersion.Current]);
							num2++;
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
			foreach (DataRow dataRow3 in this.o0o0.0O0o00O00..Select("", "", DataViewRowState.Added))
			{
				Column column2 = new ColumnClass();
				ADOX.DataTypeEnum dataTypeEnum = (ADOX.DataTypeEnum)Conversions.ToInteger(dataRow3["DataType"]);
				if (dataTypeEnum == ADOX.DataTypeEnum.adDate && this.oo.oo0o0.)
				{
					dataTypeEnum = ADOX.DataTypeEnum.adDBTimeStamp;
				}
				if (dataTypeEnum == ADOX.DataTypeEnum.adBigInt && !this.oo.oo0o0.)
				{
					dataTypeEnum = ADOX.DataTypeEnum.adInteger;
				}
				column2.Name = Conversions.ToString(dataRow3["ColumnName"]);
				column2.Type = dataTypeEnum;
				if (column2.Type == ADOX.DataTypeEnum.adVarWChar)
				{
					column2.DefinedSize = Conversions.ToInteger(dataRow3["MaxLength"]);
				}
				if (column2.Type == ADOX.DataTypeEnum.adNumeric)
				{
					column2.Precision = 28;
					column2.NumericScale = 4;
				}
				if (column2.Type != ADOX.DataTypeEnum.adBoolean || this.oo.oo0o0.)
				{
					column2.Attributes = ColumnAttributesEnum.adColNullable;
				}
				this.oo.oo0o0..Tables[this.oo.oo0o0. + Conversions.ToString(dataRow3["TableName"])].Columns.Append(column2, ADOX.DataTypeEnum.adVarWChar, 0);
				if (dataTypeEnum == ADOX.DataTypeEnum.adBoolean)
				{
					if (this.oo.oo0o0.)
					{
						_Connection connection7 = this.oo.oo0o0.;
						string commandText7 = string.Concat(new string[]
						{
							"update [",
							this.oo.oo0o0.,
							Conversions.ToString(dataRow3["TableName"]),
							"] Set [",
							column2.Name,
							"] = 0"
						});
						object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
						connection7.Execute(commandText7, out objectValue, -1);
					}
					else
					{
						_Connection connection8 = this.oo.oo0o0.;
						string commandText8 = string.Concat(new string[]
						{
							"update [",
							this.oo.oo0o0.,
							Conversions.ToString(dataRow3["TableName"]),
							"] Set [",
							column2.Name,
							"] = False"
						});
						object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
						connection8.Execute(commandText8, out objectValue, -1);
					}
				}
				num2++;
			}
			if (!this.oo.oo0o0.)
			{
				try
				{
					foreach (object obj2 in this.o0o0.0O0o00O00..Rows)
					{
						DataRow dataRow4 = (DataRow)obj2;
						if (dataRow4.RowState == DataRowState.Modified && Operators.CompareString(Conversions.ToString(dataRow4["ColumnName", DataRowVersion.Original]), Conversions.ToString(dataRow4["ColumnName", DataRowVersion.Current]), true) != 0)
						{
							this.oo.oo0o0..Tables[this.oo.oo0o0. + Conversions.ToString(dataRow4["TableName"])].Columns[Conversions.ToString(dataRow4["ColumnName", DataRowVersion.Original])].Name = Conversions.ToString(dataRow4["ColumnName", DataRowVersion.Current]);
							num2++;
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
			foreach (DataRow dataRow5 in this.o0o0.0O0o00O00..Select("", "", DataViewRowState.Deleted))
			{
				this.oo.oo0o0..Tables[this.oo.oo0o0. + Conversions.ToString(dataRow5["TableName", DataRowVersion.Original])].Columns.Delete(Conversions.ToString(dataRow5["ColumnName", DataRowVersion.Original]));
				num2++;
			}
			foreach (DataRow dataRow6 in this.oo__._..Select("", "", DataViewRowState.Deleted))
			{
				this.oo.oo0o0..Tables.Delete(this.oo.oo0o0. + Conversions.ToString(dataRow6["TableName", DataRowVersion.Original]));
				num2++;
			}
			this.oo.oo0o0..Close();
			OleDbCommand oleDbCommand = new OleDbCommand();
			oleDbCommand.Connection = this.oo.oo0o0.;
			this.oo.oo0o0..Open();
			try
			{
				try
				{
					foreach (object obj3 in this.o0o0.0O0o00O00..Rows)
					{
						DataRow dataRow7 = (DataRow)obj3;
						if (dataRow7.RowState == DataRowState.Modified)
						{
							if (Conversions.ToInteger(dataRow7["DataType", DataRowVersion.Original]) != Conversions.ToInteger(dataRow7["DataType", DataRowVersion.Current]))
							{
								oleDbCommand.CommandText = string.Concat(new string[]
								{
									"Alter Table [",
									this.oo.oo0o0.,
									Conversions.ToString(dataRow7["TableName"]),
									"] ALTER COLUMN [",
									Conversions.ToString(dataRow7["ColumnName"]),
									"] "
								});
								if (this.oo.oo0o0.)
								{
									ColumnDataTypeEnum columnDataTypeEnum = (ColumnDataTypeEnum)Conversions.ToInteger(dataRow7["DataType", DataRowVersion.Current]);
									if (columnDataTypeEnum <= ColumnDataTypeEnum.Long)
									{
										switch (columnDataTypeEnum)
										{
										case ColumnDataTypeEnum.Short:
											oleDbCommand.CommandText += " smallint";
											break;
										case ColumnDataTypeEnum.Integer:
											oleDbCommand.CommandText += " int";
											break;
										case ColumnDataTypeEnum.Single:
											oleDbCommand.CommandText += " real";
											break;
										case ColumnDataTypeEnum.Double:
											oleDbCommand.CommandText += " float";
											break;
										case (ColumnDataTypeEnum)6:
										case (ColumnDataTypeEnum)8:
										case (ColumnDataTypeEnum)9:
										case (ColumnDataTypeEnum)10:
											break;
										case ColumnDataTypeEnum.DateTime:
											oleDbCommand.CommandText += " datetime";
											break;
										case ColumnDataTypeEnum.Boolean:
											oleDbCommand.CommandText += " bit";
											break;
										default:
											if (columnDataTypeEnum != ColumnDataTypeEnum.Byte)
											{
												if (columnDataTypeEnum == ColumnDataTypeEnum.Long)
												{
													oleDbCommand.CommandText += " bigint";
												}
											}
											else
											{
												oleDbCommand.CommandText += " tinyint";
											}
											break;
										}
									}
									else if (columnDataTypeEnum != ColumnDataTypeEnum.Decimal)
									{
										if (columnDataTypeEnum != ColumnDataTypeEnum.String)
										{
											if (columnDataTypeEnum == ColumnDataTypeEnum.Text)
											{
												oleDbCommand.CommandText += " ntext";
											}
										}
										else
										{
											oleDbCommand.CommandText = oleDbCommand.CommandText + " nvarchar(" + Conversions.ToString(Conversions.ToInteger(dataRow7["Maxlength"])) + ")";
										}
									}
									else
									{
										int value = 4;
										try
										{
											foreach (DataTable dataTable in OO_00oOO.DataTables)
											{
												if (dataTable.frd_Connection == this.oo.oo0o0. && Operators.CompareString(dataTable.o._OOO0oOo0__., Conversions.ToString(dataRow7["TableName"]), true) == 0 && dataTable.DataCols.Contains(Conversions.ToString(dataRow7["ColumnName"])))
												{
													value = dataTable.DataCols[Conversions.ToString(dataRow7["ColumnName"])].Decimals;
													break;
												}
											}
										}
										finally
										{
											IEnumerator<DataTable> enumerator4;
											if (enumerator4 != null)
											{
												enumerator4.Dispose();
											}
										}
										oleDbCommand.CommandText = oleDbCommand.CommandText + " numeric(28," + Conversions.ToString(value) + ")";
									}
								}
								else
								{
									ColumnDataTypeEnum columnDataTypeEnum2 = (ColumnDataTypeEnum)Conversions.ToInteger(dataRow7["DataType", DataRowVersion.Current]);
									if (columnDataTypeEnum2 <= ColumnDataTypeEnum.Long)
									{
										switch (columnDataTypeEnum2)
										{
										case ColumnDataTypeEnum.Short:
											oleDbCommand.CommandText += " SMALLINT";
											break;
										case ColumnDataTypeEnum.Integer:
											oleDbCommand.CommandText += " INTEGER";
											break;
										case ColumnDataTypeEnum.Single:
											oleDbCommand.CommandText += " SINGLE";
											break;
										case ColumnDataTypeEnum.Double:
											oleDbCommand.CommandText += " DOUBLE";
											break;
										case (ColumnDataTypeEnum)6:
										case (ColumnDataTypeEnum)8:
										case (ColumnDataTypeEnum)9:
										case (ColumnDataTypeEnum)10:
											break;
										case ColumnDataTypeEnum.DateTime:
											oleDbCommand.CommandText += " DATETIME";
											break;
										case ColumnDataTypeEnum.Boolean:
											oleDbCommand.CommandText += " BIT";
											break;
										default:
											if (columnDataTypeEnum2 != ColumnDataTypeEnum.Byte)
											{
												if (columnDataTypeEnum2 == ColumnDataTypeEnum.Long)
												{
													continue;
												}
											}
											else
											{
												oleDbCommand.CommandText += " TINYINT";
											}
											break;
										}
									}
									else if (columnDataTypeEnum2 != ColumnDataTypeEnum.Decimal)
									{
										if (columnDataTypeEnum2 != ColumnDataTypeEnum.String)
										{
											if (columnDataTypeEnum2 == ColumnDataTypeEnum.Text)
											{
												oleDbCommand.CommandText += " TEXT";
											}
										}
										else
										{
											oleDbCommand.CommandText = oleDbCommand.CommandText + " TEXT(" + Conversions.ToString(Conversions.ToInteger(dataRow7["Maxlength"])) + ")";
										}
									}
									else
									{
										int value2 = 4;
										try
										{
											foreach (DataTable dataTable2 in OO_00oOO.DataTables)
											{
												if (dataTable2.frd_Connection == this.oo.oo0o0. && ((!this.o0o0.0O0o00O00. && Operators.CompareString(dataTable2.o._OOO0oOo0__., Conversions.ToString(dataRow7["TableName"]), true) == 0) || (this.o0o0.0O0o00O00. && Operators.CompareString(dataTable2.Name, Conversions.ToString(dataRow7["TableName"]), true) == 0)) && dataTable2.DataCols.Contains(Conversions.ToString(dataRow7["ColumnName"])))
												{
													value2 = dataTable2.DataCols[Conversions.ToString(dataRow7["ColumnName"])].Decimals;
													break;
												}
											}
										}
										finally
										{
											IEnumerator<DataTable> enumerator5;
											if (enumerator5 != null)
											{
												enumerator5.Dispose();
											}
										}
										oleDbCommand.CommandText = oleDbCommand.CommandText + " DECIMAL(28," + Conversions.ToString(value2) + ")";
									}
								}
								try
								{
									oleDbCommand.ExecuteNonQuery();
									num2++;
									continue;
								}
								catch (Exception a_)
								{
									ooO.oOo0Oo.o.(a_, "");
									MessageBox.Show("修改[" + Conversions.ToString(dataRow7["ColumnName"]) + "]的列类型失败，现有数据可能无法转换为新的类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									continue;
								}
							}
							if (Conversions.ToInteger(dataRow7["Maxlength", DataRowVersion.Current]) != Conversions.ToInteger(dataRow7["Maxlength", DataRowVersion.Original]) && Conversions.ToInteger(dataRow7["DataType"]) == 202)
							{
								if (this.oo.oo0o0.)
								{
									oleDbCommand.CommandText = string.Concat(new string[]
									{
										"Alter Table [",
										this.oo.oo0o0.,
										Conversions.ToString(dataRow7["TableName"]),
										"] ALTER COLUMN [",
										Conversions.ToString(dataRow7["ColumnName"]),
										"] nvarchar(",
										Conversions.ToString(Conversions.ToInteger(dataRow7["Maxlength"])),
										")"
									});
								}
								else
								{
									oleDbCommand.CommandText = string.Concat(new string[]
									{
										"Alter Table [",
										this.oo.oo0o0.,
										Conversions.ToString(dataRow7["TableName"]),
										"] ALTER COLUMN [",
										Conversions.ToString(dataRow7["ColumnName"]),
										"] Text(",
										Conversions.ToString(Conversions.ToInteger(dataRow7["Maxlength"])),
										")"
									});
								}
								try
								{
									oleDbCommand.ExecuteNonQuery();
									num2++;
								}
								catch (Exception a_2)
								{
									ooO.oOo0Oo.o.(a_2, "");
									MessageBox.Show("修改[" + Conversions.ToString(dataRow7["ColumnName"]) + "]的长度失败，所设置的大小可能无法容纳现有数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
			}
			catch (Exception a_3)
			{
				ooO.oOo0Oo.o.(a_3, "");
			}
			finally
			{
				if (this.oo.oo0o0..State == ConnectionState.Open)
				{
					this.oo.oo0o0..Close();
				}
			}
			this.o0_oo0._.(A_1);
			this.o0o0.0O0o00O00..Rows.Clear();
			this.oo__._..Rows.Clear();
			this.ooo.0.();
			if (O_O0OO.OoO.0OO__0ooo.() != null && O_O0OO.OoO.0OO__0ooo.().Tables.Contains(ooO0__OO.O0O.0o0.()))
			{
				o_O_o_oOoo__.OOOO_OO._oo.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()]);
			}
			return num2;
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x000E2C20 File Offset: 0x000E0E20
		private void <<EMPTY_NAME>>(bool A_0)
		{
			OleDbConnection oleDbConnection;
			if (!A_0)
			{
				oleDbConnection = O_O0OO.OoO.0OO__0ooo.();
			}
			else
			{
				oleDbConnection = this.oo.oo0o0.;
			}
			if (O_O0OO.OoO.0OO__0ooo.() != null)
			{
				oleDbConnection.Open();
				try
				{
					foreach (object obj in this.o0o0.0O0o00O00..Rows)
					{
						DataRow dataRow = (DataRow)obj;
						if (dataRow.RowState != DataRowState.Deleted && !dataRow.IsNull("Caption") && Operators.CompareString(Conversions.ToString(dataRow["Caption"]), "", true) > 0)
						{
							string text = "Caption\v" + Conversions.ToString(dataRow["Caption"]);
							new OleDbCommand
							{
								Connection = oleDbConnection,
								CommandText = string.Concat(new string[]
								{
									"Insert Into [",
									ooO0__OO.O0O.0o0.(),
									"] ([Table],[Column],[Config]) Values('",
									Conversions.ToString(dataRow["TableName"]),
									"','",
									Conversions.ToString(dataRow["ColumnName"]),
									"','",
									text,
									"')"
								})
							}.ExecuteNonQuery();
							dataRow["Caption"] = DBNull.Value;
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
				oleDbConnection.Close();
			}
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x000E2DA0 File Offset: 0x000E0FA0
		internal void <<EMPTY_NAME>>()
		{
			this.o0o0.0O0o00O00..Rows.Clear();
			this.oo__._..Rows.Clear();
			this.ooo.0.();
		}

		// Token: 0x04000DA0 RID: 3488
		private oOo_ <<EMPTY_NAME>>;

		// Token: 0x04000DA1 RID: 3489
		private Catalog <<EMPTY_NAME>>;

		// Token: 0x04000DA2 RID: 3490
		private Connection <<EMPTY_NAME>>;

		// Token: 0x04000DA3 RID: 3491
		private DataSet <<EMPTY_NAME>>;

		// Token: 0x04000DA4 RID: 3492
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DA5 RID: 3493
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DA6 RID: 3494
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DA7 RID: 3495
		internal DataTable <<EMPTY_NAME>>;

		// Token: 0x04000DA8 RID: 3496
		internal DataTable <<EMPTY_NAME>>;

		// Token: 0x04000DA9 RID: 3497
		private OleDbConnection <<EMPTY_NAME>>;
	}
}
