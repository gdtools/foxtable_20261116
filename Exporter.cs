using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ADODB;
using ADOX;
using C1.C1Excel;
using Foxtable.My;
using Foxtable.XLS;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 数据导出工具
	/// </summary>
	// Token: 0x0200033F RID: 831
	[oO0oooo("0683")]
	[ComVisible(true)]
	public class Exporter
	{
		// Token: 0x06003282 RID: 12930 RVA: 0x00157551 File Offset: 0x00155751
		public Exporter()
		{
			this.O.0o_0o_. = "Access";
			this.oo0oO0__.O0O_. = true;
			this.O_0_O.OoO_0_0O. = new C1XLBook();
		}

		/// <summary>
		/// 要导出的表的名称。
		/// </summary>
		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06003283 RID: 12931 RVA: 0x00157576 File Offset: 0x00155776
		// (set) Token: 0x06003284 RID: 12932 RVA: 0x0015757E File Offset: 0x0015577E
		public string SourceTableName
		{
			get
			{
				return this.oo0oO0__.O0O_.;
			}
			set
			{
				this.oo0oO0__.O0O_. = value;
				this.O_0_O.OoO_0_0O. = OO_00oOO.DataTables[value];
			}
		}

		/// <summary>
		/// 指定导出条件表达式
		/// </summary>
		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06003285 RID: 12933 RVA: 0x00157598 File Offset: 0x00155798
		// (set) Token: 0x06003286 RID: 12934 RVA: 0x001575A0 File Offset: 0x001557A0
		public string Filter
		{
			get
			{
				return this.Oo0.o.;
			}
			set
			{
				this.Oo0.o. = value;
			}
		}

		/// <summary>
		/// 指定导出字段(列)，不同的字段，用逗号隔开，如果不指定，则导出所有字段
		/// </summary>
		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x001575A9 File Offset: 0x001557A9
		// (set) Token: 0x06003288 RID: 12936 RVA: 0x001575B1 File Offset: 0x001557B1
		public string Fields
		{
			get
			{
				return this.O00._0O.;
			}
			set
			{
				this.O00._0O. = value;
			}
		}

		/// <summary>
		/// 指定目标数据库文件名，含文件路径
		/// </summary>
		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06003289 RID: 12937 RVA: 0x001575BA File Offset: 0x001557BA
		// (set) Token: 0x0600328A RID: 12938 RVA: 0x001575C2 File Offset: 0x001557C2
		public string FilePath
		{
			get
			{
				return this.O0._0__oO_.;
			}
			set
			{
				this.O0._0__oO_. = value;
			}
		}

		/// <summary>
		/// 指定导出后的表的名称
		/// </summary>
		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x001575CB File Offset: 0x001557CB
		// (set) Token: 0x0600328C RID: 12940 RVA: 0x001575D3 File Offset: 0x001557D3
		public string NewTableName
		{
			get
			{
				return this.O0.o.;
			}
			set
			{
				this.O0.o. = value;
			}
		}

		/// <summary>
		/// 指定导出文件格式
		/// </summary>
		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x001575DC File Offset: 0x001557DC
		// (set) Token: 0x0600328E RID: 12942 RVA: 0x001575E4 File Offset: 0x001557E4
		public string Format
		{
			get
			{
				return this.O.0o_0o_.;
			}
			set
			{
				this.O.0o_0o_. = value;
			}
		}

		/// <summary>
		/// 如果导出格式是Access，可以用此属性指定目标文件的密码
		/// </summary>
		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x001575ED File Offset: 0x001557ED
		// (set) Token: 0x06003290 RID: 12944 RVA: 0x001575F5 File Offset: 0x001557F5
		public string PassWord
		{
			get
			{
				return this.O0_0Oo.O0Oo_.;
			}
			set
			{
				this.O0_0Oo.O0Oo_. = value;
			}
		}

		/// <summary>
		/// 用于指定导出文本文件的时候，是否包括列名称
		/// </summary>
		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06003291 RID: 12945 RVA: 0x001575FE File Offset: 0x001557FE
		// (set) Token: 0x06003292 RID: 12946 RVA: 0x00157606 File Offset: 0x00155806
		public bool Header
		{
			get
			{
				return this.oo0oO0__.O0O_.;
			}
			set
			{
				this.oo0oO0__.O0O_. = value;
			}
		}

		/// <summary>
		/// 导出数据
		/// </summary>
		// Token: 0x06003293 RID: 12947 RVA: 0x00157610 File Offset: 0x00155810
		public void Export()
		{
			int num;
			int num5;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				Information.Err().Clear();
				IL_13:
				num2 = 3;
				OleDbCommand oleDbCommand = new OleDbCommand();
				IL_1C:
				num2 = 4;
				string text = "";
				IL_25:
				num2 = 5;
				string text2 = OO_00oOO.FileSys.GetParentPath(OO_00oOO.FileSys.GetTempFileName()) + "\\" + OoOo0O.OO_o.0o_O.(6) + ".tmp";
				IL_52:
				num2 = 6;
				string parentPath = OO_00oOO.FileSys.GetParentPath(this.FilePath);
				IL_66:
				num2 = 7;
				if (OO_00oOO.FileSys.DirectoryExists(parentPath))
				{
					goto IL_84;
				}
				IL_76:
				num2 = 8;
				OO_00oOO.FileSys.CreateDirectory(parentPath);
				IL_84:
				num2 = 9;
				if (Operators.CompareString(this.Fields, "", true) != 0)
				{
					goto IL_15F;
				}
				IL_9D:
				num2 = 10;
				IEnumerator<DataCol> enumerator = OO_00oOO.DataTables[this.SourceTableName].DataCols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataCol dataCol = enumerator.Current;
					IL_CA:
					num2 = 11;
					if (!dataCol.IsTemporary || OO_00oOO.DataTables[this.SourceTableName].frd_IsTemporary)
					{
						IL_ED:
						num2 = 12;
						if (Operators.CompareString(this.Fields, "", true) > 0)
						{
							IL_104:
							num2 = 13;
							this.Fields += ",";
						}
						IL_11D:
						num2 = 14;
						this.Fields = this.Fields + "[" + dataCol.Name + "]";
					}
					IL_142:
					num2 = 15;
				}
				IL_151:
				num2 = 16;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_15F:
				num2 = 17;
				if (Operators.CompareString(this.O_0_O.OoO_0_0O..O_.__0., "", true) <= 0 || !this.O_0_O.OoO_0_0O..BaseTable.Columns.Contains("_SortKey") || !this.O_0_O.OoO_0_0O..frd_IsInnerTable)
				{
					goto IL_1AE;
				}
				IL_1A4:
				num2 = 18;
				text = " Order By [_SortKey] ";
				IL_1AE:
				num2 = 19;
				if (Operators.CompareString(this.O_0_O.OoO_0_0O..o._OOO0oOo0__., "", true) <= 0)
				{
					goto IL_1DC;
				}
				IL_1CA:
				num2 = 20;
				string text3 = this.O_0_O.OoO_0_0O..o._OOO0oOo0__.;
				goto IL_1EC;
				IL_1DC:
				num2 = 22;
				text3 = this.O_0_O.OoO_0_0O..Name;
				IL_1EC:
				num2 = 23;
				if (this.O_0_O.OoO_0_0O..frd_Connection != O_O0OO.OoO.0OO__0ooo.() || !this.O_0_O.OoO_0_0O..frd_IsInnerTable || Operators.CompareString(this.O_0_O.OoO_0_0O..DataServer, "", true) != 0)
				{
					goto IL_273;
				}
				IL_226:
				num2 = 24;
				if (!this.Format.EndsWith("2007"))
				{
					goto IL_259;
				}
				IL_23B:
				num2 = 25;
				oleDbCommand.Connection = new OleDbConnection(Oo00.OOO_O0O0.o.(OO_00oOO.ProjectFile));
				goto IL_AAA;
				IL_259:
				num2 = 27;
				oleDbCommand.Connection = this.O_0_O.OoO_0_0O..frd_Connection;
				goto IL_AAA;
				IL_273:
				num2 = 29;
				if (Operators.CompareString(this.O_0_O.OoO_0_0O..DataServer, "", true) != 0 || !this.O_0_O.OoO_0_0O..frd_IsOuterTable || (Operators.CompareString(this.O_0_O.OoO_0_0O..frd_Connection.Provider, "Microsoft.Jet.OLEDB.4.0", true) != 0 && Operators.CompareString(this.O_0_O.OoO_0_0O..frd_Connection.Provider, "Microsoft.ACE.OLEDB.12.0", true) != 0))
				{
					goto IL_333;
				}
				IL_2DB:
				num2 = 30;
				if (!this.Format.EndsWith("2007"))
				{
					goto IL_319;
				}
				IL_2F0:
				num2 = 31;
				oleDbCommand.Connection = new OleDbConnection(Oo00.OOO_O0O0.o.(this.O_0_O.OoO_0_0O..frd_Connection.DataSource));
				goto IL_AAA;
				IL_319:
				num2 = 33;
				oleDbCommand.Connection = this.O_0_O.OoO_0_0O..frd_Connection;
				goto IL_AAA;
				IL_333:
				num2 = 35;
				text3 = this.O_0_O.OoO_0_0O..Name;
				IL_343:
				num2 = 36;
				Catalog catalog = new CatalogClass();
				IL_34D:
				num2 = 37;
				Table table = new TableClass();
				IL_357:
				num2 = 38;
				Index index = new IndexClass();
				IL_361:
				num2 = 39;
				List<string> list = new List<string>();
				IL_36B:
				num2 = 40;
				if (!OO_00oOO.FileSys.FileExists(text2))
				{
					goto IL_38B;
				}
				IL_37C:
				num2 = 41;
				OO_00oOO.FileSys.DeleteFile(text2);
				IL_38B:
				num2 = 42;
				catalog.Create(Oo00.o00.0OO.(text2));
				IL_39D:
				num2 = 43;
				table = new TableClass();
				IL_3A7:
				num2 = 44;
				index = new IndexClass();
				IL_3B1:
				num2 = 45;
				table.Name = text3;
				IL_3BD:
				num2 = 46;
				table.ParentCatalog = catalog;
				IL_3C9:
				num2 = 47;
				list.AddRange(this.Fields.ToLower().Split(new char[]
				{
					',',
					' ',
					'[',
					']'
				}, StringSplitOptions.RemoveEmptyEntries));
				IL_3F5:
				num2 = 48;
				foreach (DataColumn dataColumn in this.O_0_O.OoO_0_0O..BaseTable.PrimaryKey)
				{
					IL_416:
					num2 = 49;
					if (!list.Contains(dataColumn.ColumnName.ToLower()))
					{
						IL_42E:
						num2 = 50;
						list.Add(dataColumn.ColumnName.ToLower());
					}
					IL_444:
					num2 = 51;
				}
				IL_455:
				num2 = 52;
				IEnumerator enumerator2 = this.O_0_O.OoO_0_0O..BaseTable.Columns.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj = enumerator2.Current;
					DataColumn dataColumn2 = (DataColumn)obj;
					IL_482:
					num2 = 53;
					if (list.Contains(dataColumn2.ColumnName.ToLower()))
					{
						IL_49D:
						num2 = 55;
						string name = dataColumn2.DataType.Name;
						IL_4AE:
						num2 = 57;
						if (Operators.CompareString(name, "String", true) == 0)
						{
							IL_4C0:
							num2 = 58;
							if (dataColumn2.MaxLength < 0 || dataColumn2.MaxLength > 255)
							{
								IL_4DB:
								num2 = 59;
								table.Columns.Append(dataColumn2.ColumnName, ADOX.DataTypeEnum.adLongVarWChar, 0);
							}
							else
							{
								IL_4FC:
								num2 = 61;
								table.Columns.Append(dataColumn2.ColumnName, ADOX.DataTypeEnum.adVarWChar, dataColumn2.MaxLength);
							}
						}
						else
						{
							IL_523:
							num2 = 63;
							if (Operators.CompareString(name, "DateTime", true) == 0)
							{
								IL_535:
								num2 = 64;
								table.Columns.Append(dataColumn2.ColumnName, ADOX.DataTypeEnum.adDate, 0);
							}
							else
							{
								IL_552:
								num2 = 66;
								if (Operators.CompareString(name, "Boolean", true) == 0)
								{
									IL_564:
									num2 = 67;
									table.Columns.Append(dataColumn2.ColumnName, ADOX.DataTypeEnum.adBoolean, 0);
								}
								else
								{
									IL_582:
									num2 = 69;
									if (Operators.CompareString(name, "Double", true) == 0)
									{
										IL_594:
										num2 = 70;
										table.Columns.Append(dataColumn2.ColumnName, ADOX.DataTypeEnum.adDouble, 0);
									}
									else
									{
										IL_5B1:
										num2 = 72;
										if (Operators.CompareString(name, "Single", true) == 0)
										{
											IL_5C3:
											num2 = 73;
											table.Columns.Append(dataColumn2.ColumnName, ADOX.DataTypeEnum.adSingle, 0);
										}
										else
										{
											IL_5E0:
											num2 = 75;
											if (Operators.CompareString(name, "Decimal", true) == 0)
											{
												IL_5F2:
												num2 = 76;
												table.Columns.Append(dataColumn2.ColumnName, ADOX.DataTypeEnum.adNumeric, 0);
											}
											else
											{
												IL_613:
												num2 = 78;
												if (Operators.CompareString(name, "Int64", true) == 0)
												{
													IL_625:
													num2 = 79;
													table.Columns.Append(dataColumn2.ColumnName, ADOX.DataTypeEnum.adInteger, 0);
												}
												else
												{
													IL_642:
													num2 = 81;
													if (Operators.CompareString(name, "Int32", true) == 0)
													{
														IL_654:
														num2 = 82;
														table.Columns.Append(dataColumn2.ColumnName, ADOX.DataTypeEnum.adInteger, 0);
													}
													else
													{
														IL_66E:
														num2 = 84;
														if (Operators.CompareString(name, "Int16", true) == 0)
														{
															IL_680:
															num2 = 85;
															table.Columns.Append(dataColumn2.ColumnName, ADOX.DataTypeEnum.adSmallInt, 0);
														}
														else
														{
															IL_69A:
															num2 = 87;
															if (Operators.CompareString(name, "Byte", true) != 0)
															{
																goto IL_759;
															}
															IL_6AF:
															num2 = 88;
															table.Columns.Append(dataColumn2.ColumnName, ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
														}
													}
												}
											}
										}
									}
								}
							}
						}
						IL_6C8:
						num2 = 91;
						Column column = table.Columns[dataColumn2.ColumnName];
						IL_6E0:
						num2 = 92;
						if (column.Type == ADOX.DataTypeEnum.adNumeric)
						{
							IL_6F1:
							num2 = 93;
							column.Precision = 28;
							IL_6FD:
							num2 = 94;
							if (this.O_0_O.OoO_0_0O..DataCols.Contains(dataColumn2.ColumnName))
							{
								IL_719:
								num2 = 95;
								column.NumericScale = (byte)this.O_0_O.OoO_0_0O..DataCols[dataColumn2.ColumnName].Decimals;
							}
						}
						IL_740:
						num2 = 96;
						if (column.Type != ADOX.DataTypeEnum.adBoolean)
						{
							IL_74E:
							num2 = 97;
							column.Attributes = ColumnAttributesEnum.adColNullable;
						}
					}
					IL_759:
					num2 = 98;
				}
				IL_768:
				num2 = 99;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_780:
				num2 = 100;
				index.Name = "PrimaryKey";
				IL_78F:
				num2 = 101;
				if (this.O_0_O.OoO_0_0O..BaseTable.PrimaryKey.Length <= 0)
				{
					goto IL_803;
				}
				IL_7A7:
				num2 = 102;
				int num3 = this.O_0_O.OoO_0_0O..BaseTable.PrimaryKey.Length - 1;
				for (int j = 0; j <= num3; j++)
				{
					IL_7C5:
					num2 = 103;
					index.Columns.Append(this.O_0_O.OoO_0_0O..BaseTable.PrimaryKey[j].ColumnName, ADOX.DataTypeEnum.adVarWChar, 0);
					IL_7F2:
					num2 = 104;
				}
				goto IL_861;
				IL_803:
				num2 = 106;
				table.Columns.Append("_Identify", ADOX.DataTypeEnum.adInteger, 0);
				IL_819:
				num2 = 107;
				index.Columns.Append("_Identify", ADOX.DataTypeEnum.adVarWChar, 0);
				IL_833:
				num2 = 108;
				table.Columns["_Identify"].Properties["AutoIncrement"].Value = true;
				IL_861:
				num2 = 109;
				index.PrimaryKey = true;
				IL_86C:
				num2 = 110;
				index.Unique = true;
				IL_877:
				num2 = 111;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				IL_892:
				num2 = 112;
				catalog.Tables.Append(table);
				IL_8A3:
				num2 = 113;
				((Connection)catalog.ActiveConnection).Close();
				IL_8B7:
				num2 = 114;
				catalog = null;
				IL_8BD:
				num2 = 115;
				if (Information.Err().Number == 0)
				{
					goto IL_8EC;
				}
				IL_8CC:
				num2 = 116;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_12E9;
				IL_8EC:
				num2 = 118;
				if (!this.Format.EndsWith("2007"))
				{
					goto IL_914;
				}
				IL_901:
				num2 = 119;
				OleDbConnection oleDbConnection = new OleDbConnection(Oo00.OOO_O0O0.o.(text2));
				goto IL_925;
				IL_914:
				num2 = 121;
				oleDbConnection = new OleDbConnection(Oo00.o_._0OOo.(text2));
				IL_925:
				num2 = 122;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From [" + this.O_0_O.OoO_0_0O..Name + "]", oleDbConnection);
				IL_94B:
				num2 = 123;
				o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter);
				IL_955:
				num2 = 124;
				DataTable dataTable = new DataTable();
				IL_95F:
				num2 = 125;
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				IL_96D:
				num2 = 126;
				oleDbDataAdapter.Fill(dataTable);
				IL_97A:
				num2 = 127;
				foreach (DataRow dataRow in this.O_0_O.OoO_0_0O..BaseTable.Select(this.Filter, ""))
				{
					IL_9A9:
					num2 = 128;
					DataRow dataRow2 = dataTable.NewRow();
					IL_9B8:
					num2 = 129;
					List<string>.Enumerator enumerator3 = list.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						string columnName = enumerator3.Current;
						IL_9D2:
						num2 = 130;
						dataRow2[columnName] = RuntimeHelpers.GetObjectValue(dataRow[columnName]);
						IL_9EF:
						num2 = 131;
					}
					IL_9FE:
					num2 = 132;
					((IDisposable)enumerator3).Dispose();
					IL_A11:
					num2 = 133;
					dataTable.Rows.Add(dataRow2);
					IL_A25:
					num2 = 134;
				}
				IL_A3C:
				num2 = 135;
				oleDbConnection.Open();
				IL_A49:
				num2 = 136;
				oleDbDataAdapter.Update(dataTable);
				IL_A59:
				num2 = 137;
				oleDbConnection.Close();
				IL_A66:
				num2 = 138;
				oleDbCommand.Connection = oleDbConnection;
				IL_A75:
				num2 = 139;
				if (Information.Err().Number == 0)
				{
					goto IL_AAA;
				}
				IL_A87:
				num2 = 140;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_12E9;
				IL_AAA:
				num2 = 142;
				if (Operators.CompareString(this.NewTableName, "", true) != 0)
				{
					goto IL_AD5;
				}
				IL_AC3:
				num2 = 143;
				this.NewTableName = this.SourceTableName;
				IL_AD5:
				num2 = 144;
				if (!o_O_o_oOoo__.OO0O_0.0O0o0_o.(oleDbCommand.Connection))
				{
					goto IL_B43;
				}
				IL_AE9:
				num2 = 145;
				this.Fields = this.Fields.Replace("[", "\"").Replace("]", "\"");
				IL_B19:
				num2 = 146;
				text = text.Replace("[", "\"").Replace("]", "\"");
				goto IL_B5C;
				IL_B43:
				num2 = 148;
				text3 = "[" + text3 + "]";
				IL_B5C:
				num2 = 149;
				if (Operators.CompareString(this.Format, "", true) != 0 && Operators.CompareString(this.Format, "access", true) != 0 && Operators.CompareString(this.Format, "access2007", true) != 0 && Operators.CompareString(this.Format, "access 2007", true) != 0)
				{
					goto IL_D73;
				}
				IL_BB1:
				num2 = 150;
				if (Foxtable.My.c.OOOOO.o.().FileSystem.FileExists(this.FilePath))
				{
					goto IL_C8D;
				}
				IL_BD1:
				num2 = 151;
				Catalog catalog2 = new CatalogClass();
				IL_BDE:
				num2 = 152;
				if (this.Format.IndexOf("2007") <= 0)
				{
					goto IL_C11;
				}
				IL_BF7:
				num2 = 153;
				string text4 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.FilePath;
				goto IL_C29;
				IL_C11:
				num2 = 155;
				text4 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.FilePath;
				IL_C29:
				num2 = 156;
				if (Operators.CompareString(this.PassWord, "", true) <= 0)
				{
					goto IL_C5D;
				}
				IL_C43:
				num2 = 157;
				text4 = text4 + ";Jet OLEDB:Database Password=" + this.PassWord;
				IL_C5D:
				num2 = 158;
				catalog2.Create(text4);
				IL_C6D:
				num2 = 159;
				((Connection)catalog2.ActiveConnection).Close();
				IL_C84:
				num2 = 160;
				catalog2 = null;
				IL_C8D:
				num2 = 161;
				if (Operators.CompareString(this.PassWord, "", true) != 0)
				{
					goto IL_D03;
				}
				IL_CA6:
				num2 = 162;
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Select ",
					this.Fields,
					" INTO [;DATABASE=",
					this.FilePath,
					"].[",
					this.NewTableName,
					"] From ",
					text3
				});
				goto IL_11C4;
				IL_D03:
				num2 = 164;
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Select ",
					this.Fields,
					" INTO [;DATABASE=",
					this.FilePath,
					";PWD=",
					this.PassWord,
					"].[",
					this.NewTableName,
					"] From ",
					text3
				});
				goto IL_11C4;
				IL_D73:
				num2 = 166;
				if (Operators.CompareString(this.Format, "dbase", true) != 0)
				{
					goto IL_DE9;
				}
				IL_D8C:
				num2 = 167;
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Select ",
					this.Fields,
					" INTO [dBASE IV;DATABASE=",
					this.FilePath,
					"].[",
					this.NewTableName,
					"] From ",
					text3
				});
				goto IL_11C4;
				IL_DE9:
				num2 = 169;
				if (Operators.CompareString(this.Format, "excel", true) != 0)
				{
					goto IL_E5F;
				}
				IL_E02:
				num2 = 170;
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Select ",
					this.Fields,
					" INTO [EXCEL 8.0;DATABASE=",
					this.FilePath,
					"].[",
					this.NewTableName,
					"] From ",
					text3
				});
				goto IL_11C4;
				IL_E5F:
				num2 = 172;
				if (Operators.CompareString(this.Format, "excel2007", true) != 0 && Operators.CompareString(this.Format, "excel 2007", true) != 0)
				{
					goto IL_F3E;
				}
				IL_E8E:
				num2 = 173;
				if (Foxtable.My.c.OOOOO.o.().FileSystem.FileExists(this.FilePath))
				{
					goto IL_EE1;
				}
				IL_EAB:
				num2 = 174;
				this.O_0_O.OoO_0_0O. = new C1XLBook();
				IL_EBC:
				num2 = 175;
				this.O_0_O.OoO_0_0O..Save(this.FilePath, FileFormat.OpenXml);
				IL_ED4:
				num2 = 176;
				this.Oo0.o. = true;
				IL_EE1:
				num2 = 177;
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Select ",
					this.Fields,
					" INTO [EXCEL 12.0;DATABASE=",
					this.FilePath,
					"].[",
					this.NewTableName,
					"] From ",
					text3
				});
				goto IL_11C4;
				IL_F3E:
				num2 = 179;
				string file = Foxtable.My.c.OOOOO.o.().FileSystem.CombinePath(this.FilePath, this.NewTableName);
				IL_F60:
				num2 = 180;
				if (!Foxtable.My.c.OOOOO.o.().FileSystem.FileExists(file))
				{
					goto IL_F8E;
				}
				IL_F78:
				num2 = 181;
				Foxtable.My.c.OOOOO.o.().FileSystem.DeleteFile(file);
				IL_F8E:
				num2 = 182;
				file = Foxtable.My.c.OOOOO.o.().FileSystem.CombinePath(this.FilePath, "schema.ini");
				IL_FAF:
				num2 = 183;
				if (!Foxtable.My.c.OOOOO.o.().FileSystem.FileExists(file))
				{
					goto IL_FDD;
				}
				IL_FC7:
				num2 = 184;
				Foxtable.My.c.OOOOO.o.().FileSystem.DeleteFile(file);
				IL_FDD:
				num2 = 185;
				if (this.Format.IndexOf("Delimited", StringComparison.CurrentCultureIgnoreCase) < 0)
				{
					goto IL_10E8;
				}
				IL_FFA:
				num2 = 186;
				if (!this.Header)
				{
					goto IL_1078;
				}
				IL_1008:
				num2 = 187;
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Select ",
					this.Fields,
					" INTO [text;FMT=",
					this.Format,
					";DATABASE=",
					this.FilePath,
					"].[",
					this.NewTableName,
					"#txt] From ",
					text3
				});
				goto IL_11C4;
				IL_1078:
				num2 = 189;
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Select ",
					this.Fields,
					" INTO [text;HDR=No;FMT=",
					this.Format,
					";DATABASE=",
					this.FilePath,
					"].[",
					this.NewTableName,
					"#txt] From ",
					text3
				});
				goto IL_11C4;
				IL_10E8:
				num2 = 191;
				if (Operators.CompareString(this.Format, "Fixed", true) != 0)
				{
					goto IL_11C4;
				}
				IL_1104:
				num2 = 192;
				if (!this.Header)
				{
					goto IL_116C;
				}
				IL_1112:
				num2 = 193;
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Select ",
					this.Fields,
					" INTO [text;HDR=Yes;FMT=Fixed;DATABASE=",
					this.FilePath,
					"].[",
					this.NewTableName,
					"#txt] From ",
					text3
				});
				goto IL_11C4;
				IL_116C:
				num2 = 195;
				oleDbCommand.CommandText = string.Concat(new string[]
				{
					"Select ",
					this.Fields,
					" INTO [text;HDR=No;FMT=Fixed;DATABASE=",
					this.FilePath,
					"].[",
					this.NewTableName,
					"#txt] From ",
					text3
				});
				IL_11C4:
				num2 = 196;
				if (Operators.CompareString(this.Filter, "", true) <= 0)
				{
					goto IL_1202;
				}
				IL_11DE:
				num2 = 197;
				oleDbCommand.CommandText = oleDbCommand.CommandText + " Where " + this.Filter;
				IL_1202:
				num2 = 198;
				oleDbCommand.CommandText += text;
				IL_121D:
				num2 = 199;
				this.O0o.__O.(oleDbCommand, text2, false);
				IL_122E:
				num2 = 200;
				if (!this.Oo0.o.)
				{
					goto IL_12E9;
				}
				IL_123F:
				num2 = 201;
				Book book = new Book(this.FilePath);
				IL_1252:
				num2 = 202;
				IEnumerator<Sheet> enumerator4 = book.Sheets.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					Sheet sheet = enumerator4.Current;
					IL_1271:
					num2 = 203;
					if (Operators.CompareString(sheet.Name, "Sheet1", true) == 0 || Operators.CompareString(sheet.Name, "Sheet1$", true) == 0)
					{
						IL_129F:
						num2 = 204;
						book.Sheets.Remove(sheet);
						IL_12B3:
						num2 = 205;
						book.Save(this.FilePath);
						break;
					}
					IL_12C9:
					num2 = 207;
				}
				IL_12D8:
				num2 = 208;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
				IL_12E9:
				goto IL_167F;
				IL_12EE:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_1640:
				goto IL_1674;
				IL_1642:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1652:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_1642;
			}
			IL_1674:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_167F:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x00158CC0 File Offset: 0x00156EC0
		private void <<EMPTY_NAME>>(OleDbCommand A_0, string A_1, bool A_2 = false)
		{
			try
			{
				A_0.Connection.Open();
				A_0.ExecuteNonQuery();
			}
			catch (Exception a_)
			{
				if (A_2)
				{
					ooO.oOo0Oo.o.(a_, "");
				}
			}
			finally
			{
				A_0.Connection.Close();
				if (OO_00oOO.FileSys.FileExists(A_1))
				{
					OO_00oOO.FileSys.DeleteFile(A_1);
				}
			}
		}

		// Token: 0x0400143D RID: 5181
		private string <<EMPTY_NAME>>;

		// Token: 0x0400143E RID: 5182
		private string <<EMPTY_NAME>>;

		// Token: 0x0400143F RID: 5183
		private string <<EMPTY_NAME>>;

		// Token: 0x04001440 RID: 5184
		private string <<EMPTY_NAME>>;

		// Token: 0x04001441 RID: 5185
		private string <<EMPTY_NAME>>;

		// Token: 0x04001442 RID: 5186
		private string <<EMPTY_NAME>>;

		// Token: 0x04001443 RID: 5187
		private string <<EMPTY_NAME>>;

		// Token: 0x04001444 RID: 5188
		private string <<EMPTY_NAME>>;

		// Token: 0x04001445 RID: 5189
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001446 RID: 5190
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001447 RID: 5191
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04001448 RID: 5192
		private C1XLBook <<EMPTY_NAME>>;
	}
}
