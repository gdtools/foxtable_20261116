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
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 数据导入工具
	/// </summary>
	// Token: 0x0200034B RID: 843
	[oO0oooo("0684")]
	[ComVisible(true)]
	public class Importer
	{
		// Token: 0x060033A8 RID: 13224 RVA: 0x001610F8 File Offset: 0x0015F2F8
		public Importer()
		{
			this.o.OOo_oO. = true;
		}

		/// <summary>
		/// 指定要导入的数据文件，含路径
		/// </summary>
		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x00161107 File Offset: 0x0015F307
		// (set) Token: 0x060033AA RID: 13226 RVA: 0x0016110F File Offset: 0x0015F30F
		public string SourcePath
		{
			get
			{
				return this.o.OOo_oO.;
			}
			set
			{
				this.o.OOo_oO. = value;
			}
		}

		/// <summary>
		/// 指定要导入的表的名称
		/// </summary>
		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x00161118 File Offset: 0x0015F318
		// (set) Token: 0x060033AC RID: 13228 RVA: 0x00161120 File Offset: 0x0015F320
		public string SourceTableName
		{
			get
			{
				return this.O.Oo_oO0_0.;
			}
			set
			{
				this.O.Oo_oO0_0. = value;
			}
		}

		/// <summary>
		/// 指定导入格
		/// </summary>
		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060033AD RID: 13229 RVA: 0x00161129 File Offset: 0x0015F329
		// (set) Token: 0x060033AE RID: 13230 RVA: 0x00161131 File Offset: 0x0015F331
		public string Format
		{
			get
			{
				return this.o_.__oo0O0oO0o.;
			}
			set
			{
				this.o_.__oo0O0oO0o. = value;
			}
		}

		/// <summary>
		/// 指定要导入的字段(列)，不同的字段，用逗号给开，如果不指定，则导入所有字段
		/// </summary>
		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x060033AF RID: 13231 RVA: 0x0016113A File Offset: 0x0015F33A
		// (set) Token: 0x060033B0 RID: 13232 RVA: 0x00161142 File Offset: 0x0015F342
		public string Fields
		{
			get
			{
				return this.OOoO0O_oo.o.;
			}
			set
			{
				this.OOoO0O_oo.o. = value;
			}
		}

		/// <summary>
		/// 如果要导入有密码的Access文件，可以通过此属性指定密码。
		/// </summary>
		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x060033B1 RID: 13233 RVA: 0x0016114B File Offset: 0x0015F34B
		// (set) Token: 0x060033B2 RID: 13234 RVA: 0x00161153 File Offset: 0x0015F353
		public string PassWord
		{
			get
			{
				return this.O00.O0OO_0oO.;
			}
			set
			{
				this.O00.O0OO_0oO. = value;
			}
		}

		/// <summary>
		/// 指定导入条件
		/// </summary>
		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x060033B3 RID: 13235 RVA: 0x0016115C File Offset: 0x0015F35C
		// (set) Token: 0x060033B4 RID: 13236 RVA: 0x00161164 File Offset: 0x0015F364
		public string Filter
		{
			get
			{
				return this.o00O_O.O.;
			}
			set
			{
				this.o00O_O.O. = value;
			}
		}

		/// <summary>
		/// 指定导入后的表名
		/// </summary>
		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x060033B5 RID: 13237 RVA: 0x0016116D File Offset: 0x0015F36D
		// (set) Token: 0x060033B6 RID: 13238 RVA: 0x00161175 File Offset: 0x0015F375
		public string NewTableName
		{
			get
			{
				return this.oO00._o__0oO.;
			}
			set
			{
				this.oO00._o__0oO. = value;
			}
		}

		/// <summary>
		/// 指定导入后的表标题
		/// </summary>
		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x060033B7 RID: 13239 RVA: 0x0016117E File Offset: 0x0015F37E
		// (set) Token: 0x060033B8 RID: 13240 RVA: 0x00161186 File Offset: 0x0015F386
		public string NewTableCaption
		{
			get
			{
				return this.oOOoOo.0_0.;
			}
			set
			{
				this.oOOoOo.0_0. = value;
			}
		}

		/// <summary>
		/// 如果导入的是文本文件，用此属性指定第一行是否是列名称
		/// </summary>
		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x0016118F File Offset: 0x0015F38F
		// (set) Token: 0x060033BA RID: 13242 RVA: 0x00161197 File Offset: 0x0015F397
		public bool Header
		{
			get
			{
				return this.o.OOo_oO.;
			}
			set
			{
				this.o.OOo_oO. = value;
			}
		}

		/// <summary>
		/// 导入
		/// </summary>
		// Token: 0x060033BB RID: 13243 RVA: 0x001611A0 File Offset: 0x0015F3A0
		public bool Import()
		{
			int num;
			bool result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				OleDbCommand oleDbCommand = new OleDbCommand();
				IL_10:
				num2 = 3;
				string text = OO_00oOO.ProjectFile + ".bak";
				IL_23:
				num2 = 4;
				if (!OO_00oOO.FileSys.FileExists(text))
				{
					goto IL_41;
				}
				IL_33:
				num2 = 5;
				OO_00oOO.FileSys.DeleteFile(text);
				IL_41:
				num2 = 6;
				OO_00oOO.FileSys.CopyFile(OO_00oOO.ProjectFile, text);
				IL_54:
				num2 = 7;
				if (!this.SourcePath.ToLower().EndsWith(".accdb") && !this.SourcePath.ToLower().EndsWith(".xlsx"))
				{
					goto IL_9E;
				}
				IL_84:
				num2 = 8;
				oleDbCommand.Connection = new OleDbConnection(Oo00.OOO_O0O0.o.(OO_00oOO.ProjectFile));
				goto IL_AD;
				IL_9E:
				num2 = 10;
				oleDbCommand.Connection = O_O0OO.OoO.0OO__0ooo.();
				IL_AD:
				num2 = 11;
				if (Operators.CompareString(this.Fields, "", true) != 0)
				{
					goto IL_D1;
				}
				IL_C3:
				num2 = 12;
				this.Fields = "*";
				IL_D1:
				num2 = 13;
				if (Operators.CompareString(this.NewTableName, "", true) != 0)
				{
					goto IL_107;
				}
				IL_E7:
				num2 = 14;
				MessageBox.Show("请指定表名!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_FD:
				num2 = 15;
				result = true;
				goto IL_575;
				IL_107:
				num2 = 16;
				if (!O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(this.NewTableName))
				{
					goto IL_151;
				}
				IL_121:
				num2 = 17;
				MessageBox.Show("已经存在同名表\"" + this.NewTableName + "\"！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_147:
				num2 = 18;
				result = false;
				goto IL_575;
				IL_151:
				num2 = 19;
				string format = this.Format;
				IL_15C:
				num2 = 21;
				if (Operators.CompareString(format, "", true) != 0 && Operators.CompareString(format, "access", true) != 0 && Operators.CompareString(format, "access2007", true) != 0 && Operators.CompareString(format, "access 2007", true) != 0)
				{
					goto IL_243;
				}
				IL_19E:
				num2 = 22;
				if (Operators.CompareString(this.PassWord, "", true) != 0)
				{
					goto IL_1F3;
				}
				IL_1B4:
				num2 = 23;
				string text2 = string.Concat(new string[]
				{
					"[;DATABASE=",
					this.SourcePath,
					"].[",
					this.SourceTableName,
					"]"
				});
				goto IL_54C;
				IL_1F3:
				num2 = 25;
				text2 = string.Concat(new string[]
				{
					"[;DATABASE=",
					this.SourcePath,
					";PWD=",
					this.PassWord,
					"].[",
					this.SourceTableName,
					"]"
				});
				goto IL_54C;
				IL_243:
				num2 = 27;
				if (Operators.CompareString(format, "excel", true) != 0 && Operators.CompareString(format, "excel2007", true) != 0 && Operators.CompareString(format, "excel 2007", true) != 0)
				{
					goto IL_339;
				}
				IL_276:
				num2 = 28;
				if (this.SourceTableName.EndsWith("$", StringComparison.CurrentCultureIgnoreCase))
				{
					goto IL_2A5;
				}
				IL_28C:
				num2 = 29;
				this.SourceTableName += "$";
				IL_2A5:
				num2 = 30;
				if (this.Format.IndexOf("2007") <= 0)
				{
					goto IL_2FA;
				}
				IL_2BB:
				num2 = 31;
				text2 = string.Concat(new string[]
				{
					"[EXCEL 12.0;DATABASE=",
					this.SourcePath,
					"].[",
					this.SourceTableName,
					"]"
				});
				goto IL_54C;
				IL_2FA:
				num2 = 33;
				text2 = string.Concat(new string[]
				{
					"[EXCEL 8.0;DATABASE=",
					this.SourcePath,
					"].[",
					this.SourceTableName,
					"]"
				});
				goto IL_54C;
				IL_339:
				num2 = 35;
				if (Operators.CompareString(format, "dbase", true) != 0)
				{
					goto IL_38A;
				}
				IL_34B:
				num2 = 36;
				text2 = string.Concat(new string[]
				{
					"[dBASE IV;DATABASE=",
					this.SourcePath,
					"].[",
					this.SourceTableName,
					"]"
				});
				goto IL_54C;
				IL_38A:
				num2 = 38;
				if (Operators.CompareString(format, "Fixed", true) != 0)
				{
					goto IL_457;
				}
				IL_39F:
				num2 = 39;
				if (this.SourceTableName.EndsWith("#txt", StringComparison.CurrentCultureIgnoreCase))
				{
					goto IL_3CE;
				}
				IL_3B5:
				num2 = 40;
				this.SourceTableName += "#txt";
				IL_3CE:
				num2 = 41;
				if (!this.Header)
				{
					goto IL_418;
				}
				IL_3D9:
				num2 = 42;
				text2 = string.Concat(new string[]
				{
					"[text;HDR=Yes;FMT=Fixed;DATABASE=",
					this.SourcePath,
					"].[",
					this.SourceTableName,
					"]"
				});
				goto IL_54C;
				IL_418:
				num2 = 44;
				text2 = string.Concat(new string[]
				{
					"[text;HDR=No;FMT=Fixed;DATABASE=",
					this.SourcePath,
					"].[",
					this.SourceTableName,
					"]"
				});
				goto IL_54C;
				IL_457:
				num2 = 46;
				if (this.Format.IndexOf("Delimited", StringComparison.CurrentCultureIgnoreCase) < 0)
				{
					goto IL_545;
				}
				IL_471:
				num2 = 47;
				if (this.SourceTableName.EndsWith("#txt", StringComparison.CurrentCultureIgnoreCase))
				{
					goto IL_4A0;
				}
				IL_487:
				num2 = 48;
				this.SourceTableName += "#txt";
				IL_4A0:
				num2 = 49;
				if (!this.Header)
				{
					goto IL_4F8;
				}
				IL_4AB:
				num2 = 50;
				text2 = string.Concat(new string[]
				{
					"[text;HDR=Yes;FMT=",
					this.Format,
					";DATABASE=",
					this.SourcePath,
					"].[",
					this.SourceTableName,
					"]"
				});
				goto IL_54C;
				IL_4F8:
				num2 = 52;
				text2 = string.Concat(new string[]
				{
					"[text;HDR=No;FMT=",
					this.Format,
					";DATABASE=",
					this.SourcePath,
					"].[",
					this.SourceTableName,
					"]"
				});
				goto IL_54C;
				IL_545:
				num2 = 54;
				result = false;
				goto IL_575;
				IL_54C:
				num2 = 55;
				if (Operators.CompareString(text2, "", true) != 0)
				{
					goto IL_565;
				}
				IL_55E:
				num2 = 56;
				result = false;
				goto IL_575;
				IL_565:
				num2 = 57;
				result = this.o.OOo_oO.(oleDbCommand, text2, text);
				IL_575:
				goto IL_6AF;
				IL_57A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_670:
				goto IL_6A4;
				IL_672:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_682:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_672;
			}
			IL_6A4:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_6AF:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00161884 File Offset: 0x0015FA84
		private bool <<EMPTY_NAME>>(OleDbCommand A_0, string A_1, string A_2)
		{
			bool result;
			try
			{
				DataTable dataTable = new DataTable();
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("", A_0.Connection);
				List<string> list = new List<string>();
				oleDbDataAdapter.SelectCommand.CommandText = "Select " + this.Fields + " From " + A_1;
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				try
				{
					foreach (object obj in dataTable.Columns)
					{
						DataColumn dataColumn = (DataColumn)obj;
						if (o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) || dataColumn.AutoIncrement)
						{
							list.Add(dataColumn.ColumnName);
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
					foreach (string name in list)
					{
						dataTable.Columns.Remove(name);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				if (dataTable.Columns.Count > 253)
				{
					MessageBox.Show("不能导入超过253列的表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = false;
				}
				else
				{
					this.Fields = "";
					try
					{
						foreach (object obj2 in dataTable.Columns)
						{
							DataColumn dataColumn2 = (DataColumn)obj2;
							if (Operators.CompareString(this.Fields, "", true) > 0)
							{
								this.Fields += ",";
							}
							this.Fields = this.Fields + "[" + dataColumn2.ColumnName + "]";
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
					A_0.CommandText = string.Concat(new string[]
					{
						"Select ",
						this.Fields,
						" Into [~TMPCLP",
						this.NewTableName,
						"] From ",
						A_1
					});
					if (Operators.CompareString(this.Filter, "", true) > 0)
					{
						A_0.CommandText = A_0.CommandText + " Where " + this.Filter;
					}
					A_0.Connection.Close();
					A_0.Connection.Open();
					A_0.ExecuteNonQuery();
					A_0.Connection.Close();
					if (!this.CreatePrimaryKey())
					{
						OO_00oOO.FileSys.DeleteFile(OO_00oOO.ProjectFile);
						OO_00oOO.FileSys.RenameFile(A_2, OO_00oOO.FileSys.GetName(OO_00oOO.ProjectFile));
						result = false;
					}
					else
					{
						this.o.OOo_oO.();
						Application.DoEvents();
						result = true;
					}
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
				A_0.Connection.Close();
				result = false;
			}
			return result;
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00161B9C File Offset: 0x0015FD9C
		private bool CreatePrimaryKey()
		{
			Catalog catalog = new CatalogClass();
			Connection connection = new ConnectionClass();
			string text = "~TMPCLP" + this.NewTableName;
			string text2 = "__Identify";
			connection.ConnectionString = O_O0OO.OoO.0OO__0ooo.().ConnectionString;
			connection.Open("", "", "", -1);
			catalog.ActiveConnection = connection;
			Table table = catalog.Tables[text];
			try
			{
				table.Columns.Append("_Locked", ADOX.DataTypeEnum.adBoolean, 0);
				table.Columns.Append("_Identify", ADOX.DataTypeEnum.adInteger, 0);
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
				connection.Close();
				catalog = null;
				return false;
			}
			ColumnClass columnClass = new ColumnClass();
			columnClass.ParentCatalog = catalog;
			columnClass.Type = ADOX.DataTypeEnum.adInteger;
			columnClass.Name = text2;
			columnClass.Properties["AutoIncrement"].Value = true;
			table.Columns.Append(columnClass, ADOX.DataTypeEnum.adInteger, 0);
			_Connection connection2 = connection;
			string commandText = string.Concat(new string[]
			{
				"update [",
				text,
				"] Set [_Identify] = [",
				text2,
				"]"
			});
			object objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			connection2.Execute(commandText, out objectValue, -1);
			catalog.Tables[text].Columns.Delete(text2);
			Index index = new IndexClass();
			index.Name = "PrimaryKey";
			index.Columns.Append("_Identify", ADOX.DataTypeEnum.adVarWChar, 0);
			index.PrimaryKey = true;
			index.Unique = true;
			table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
			_Connection connection3 = connection;
			string commandText2 = string.Concat(new string[]
			{
				"Delete * From [",
				ooO0__OO.O00.O__o.(),
				"] Where [Table]  = '",
				text,
				"'"
			});
			objectValue = RuntimeHelpers.GetObjectValue(Missing.Value);
			connection3.Execute(commandText2, out objectValue, -1);
			connection.Close();
			catalog = null;
			O_O0OO.OoO.0OO__0ooo.().Open();
			OleDbCommand oleDbCommand = new OleDbCommand("Select Max([_Identify]) From [" + text + "]", O_O0OO.OoO.0OO__0ooo.());
			object objectValue2 = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
			int value;
			if (objectValue2 == DBNull.Value)
			{
				value = 1;
			}
			else
			{
				value = Conversions.ToInteger(objectValue2) + 1;
			}
			oleDbCommand.CommandText = string.Concat(new string[]
			{
				"Insert into [",
				ooO0__OO.O00.O__o.(),
				"] ([Table],[Identify]) values ('",
				text,
				"',",
				Conversions.ToString(value),
				")"
			});
			oleDbCommand.ExecuteNonQuery();
			O_O0OO.OoO.0OO__0ooo.().Close();
			return true;
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00161E5C File Offset: 0x0016005C
		private void <<EMPTY_NAME>>()
		{
			O_O0OO.OoO.0OO__0ooo.().Open();
			o0OoOOoOOo0.OO0._Oo0o.(O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.DataTables, O_O0OO.OOOo.oo_OOOO_0.(), "~TMPCLP" + this.NewTableName, true, OO_00oOO.User, O_O0OO.oo0_o_.o., O_O0OO.OoO.0OO__0ooo.(), false);
			OO_00oOO.DataTables[this.NewTableName].o.0O000_.();
			if (Operators.CompareString(this.NewTableCaption, "", true) > 0)
			{
				OO_00oOO.DataTables[this.NewTableName].Caption = this.NewTableCaption;
			}
			O_O0OO.OoO.0OO__0ooo.().Close();
			OO_00oOO.Tables.OO._O_o__.(O_O0OO.o__.O.()[this.NewTableName]);
			Main.OO_O.o..o0_o_o_0.0O.(this.NewTableName, true, false);
			if (Operators.CompareString(this.NewTableCaption, "", true) > 0)
			{
				OO_00oOO.DataTables[this.NewTableName].OO00_o.ooOO.(false);
			}
		}

		// Token: 0x040014BD RID: 5309
		private string <<EMPTY_NAME>>;

		// Token: 0x040014BE RID: 5310
		private string <<EMPTY_NAME>>;

		// Token: 0x040014BF RID: 5311
		private string <<EMPTY_NAME>>;

		// Token: 0x040014C0 RID: 5312
		private string <<EMPTY_NAME>>;

		// Token: 0x040014C1 RID: 5313
		private string <<EMPTY_NAME>>;

		// Token: 0x040014C2 RID: 5314
		private string <<EMPTY_NAME>>;

		// Token: 0x040014C3 RID: 5315
		private string <<EMPTY_NAME>>;

		// Token: 0x040014C4 RID: 5316
		private string <<EMPTY_NAME>>;

		// Token: 0x040014C5 RID: 5317
		private bool <<EMPTY_NAME>>;
	}
}
