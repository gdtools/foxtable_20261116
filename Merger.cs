using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 数据合并工具
	/// </summary>
	// Token: 0x0200034C RID: 844
	[ComVisible(true)]
	[oO0oooo("0685")]
	public class Merger
	{
		// Token: 0x060033BF RID: 13247 RVA: 0x00161F4C File Offset: 0x0016014C
		public Merger()
		{
			this.o_O00_O.Oo. = true;
			this.o_O00_O.Oo. = new Dictionary<string, string>();
			this.o.o_oo0OoO. = new DataTable();
		}

		/// <summary>
		/// 指定要要合并的数据库文件，含路径
		/// </summary>
		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060033C0 RID: 13248 RVA: 0x00161F71 File Offset: 0x00160171
		// (set) Token: 0x060033C1 RID: 13249 RVA: 0x00161F79 File Offset: 0x00160179
		public string SourcePath
		{
			get
			{
				return this.o_O00_O.Oo.;
			}
			set
			{
				this.o_O00_O.Oo. = value;
			}
		}

		/// <summary>
		/// 指定数据源名称，从此数据源中合并数据。
		/// </summary>
		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060033C2 RID: 13250 RVA: 0x00161F82 File Offset: 0x00160182
		// (set) Token: 0x060033C3 RID: 13251 RVA: 0x00161F8A File Offset: 0x0016018A
		public string ConnectionName
		{
			get
			{
				return this.oo_o.ooO0_o.;
			}
			set
			{
				this.oo_o.ooO0_o. = value;
			}
		}

		/// <summary>
		/// 指定要合并的表的名称
		/// </summary>
		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060033C4 RID: 13252 RVA: 0x00161F93 File Offset: 0x00160193
		// (set) Token: 0x060033C5 RID: 13253 RVA: 0x00161F9B File Offset: 0x0016019B
		public string SourceTableName
		{
			get
			{
				return this.oO__.o.;
			}
			set
			{
				this.oO__.o. = value;
			}
		}

		/// <summary>
		/// 指定要合并的文件的格式
		/// </summary>
		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060033C6 RID: 13254 RVA: 0x00161FA4 File Offset: 0x001601A4
		// (set) Token: 0x060033C7 RID: 13255 RVA: 0x00161FAC File Offset: 0x001601AC
		public string Format
		{
			get
			{
				return this.o_0_o_0_0.o.;
			}
			set
			{
				this.o_0_o_0_0.o. = value;
			}
		}

		/// <summary>
		/// 指定要合并的字段(列)，不同的字段用逗号隔开，如果不指定，则合并所有字段
		/// </summary>
		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060033C8 RID: 13256 RVA: 0x00161FB5 File Offset: 0x001601B5
		// (set) Token: 0x060033C9 RID: 13257 RVA: 0x00161FBD File Offset: 0x001601BD
		public string Fields
		{
			get
			{
				return this.O_o0OO0.O0O_.;
			}
			set
			{
				this.O_o0OO0.O0O_. = value;
			}
		}

		/// <summary>
		///  如果要合并有密码的Access文件，可以通过此属性指定密码。
		/// </summary>
		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060033CA RID: 13258 RVA: 0x00161FC6 File Offset: 0x001601C6
		// (set) Token: 0x060033CB RID: 13259 RVA: 0x00161FCE File Offset: 0x001601CE
		public string PassWord
		{
			get
			{
				return this.O_OoOoO.oo0o_.;
			}
			set
			{
				this.O_OoOoO.oo0o_. = value;
			}
		}

		/// <summary>
		/// 指定合并条件
		/// </summary>
		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060033CC RID: 13260 RVA: 0x00161FD7 File Offset: 0x001601D7
		// (set) Token: 0x060033CD RID: 13261 RVA: 0x00161FDF File Offset: 0x001601DF
		public string Filter
		{
			get
			{
				return this.o_oo00.o_oo.;
			}
			set
			{
				this.o_oo00.o_oo. = value;
			}
		}

		/// <summary>
		/// 指定接收合并数据的数据表的名称，这个表必须是当前项目中已经存在的表
		/// </summary>
		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060033CE RID: 13262 RVA: 0x00161FE8 File Offset: 0x001601E8
		// (set) Token: 0x060033CF RID: 13263 RVA: 0x00161FF0 File Offset: 0x001601F0
		public string DataTableName
		{
			get
			{
				return this.OO0.0O_000.;
			}
			set
			{
				this.OO0.0O_000. = value;
			}
		}

		/// <summary>
		/// 如果合并的是文本文件，用此属性指定第一行是否是列名称
		/// </summary>
		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060033D0 RID: 13264 RVA: 0x00161FF9 File Offset: 0x001601F9
		// (set) Token: 0x060033D1 RID: 13265 RVA: 0x00162001 File Offset: 0x00160201
		public bool Header
		{
			get
			{
				return this.o_O00_O.Oo.;
			}
			set
			{
				this.o_O00_O.Oo. = value;
			}
		}

		/// <summary>
		/// 用于指定两个表之间字段的对应关系
		/// </summary>
		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060033D2 RID: 13266 RVA: 0x0016200A File Offset: 0x0016020A
		public Dictionary<string, string> FieldMaps
		{
			get
			{
				return this.o_O00_O.Oo.;
			}
		}

		/// <summary>
		/// 合并数据
		/// </summary>
		// Token: 0x060033D3 RID: 13267 RVA: 0x00162014 File Offset: 0x00160214
		public void Merge()
		{
			if (Operators.CompareString(this.Fields, "", true) == 0)
			{
				this.Fields = "*";
			}
			if (Operators.CompareString(this.ConnectionName, "", true) == 0)
			{
				string format = this.Format;
				string text;
				if (Operators.CompareString(format, "", true) == 0 || Operators.CompareString(format, "access", true) == 0 || Operators.CompareString(format, "access2007", true) == 0 || Operators.CompareString(format, "access 2007", true) == 0)
				{
					if (Operators.CompareString(this.PassWord, "", true) == 0)
					{
						text = string.Concat(new string[]
						{
							"[;DATABASE=",
							this.SourcePath,
							"].[",
							this.SourceTableName,
							"]"
						});
					}
					else
					{
						text = string.Concat(new string[]
						{
							"[;DATABASE=",
							this.SourcePath,
							";PWD=",
							this.PassWord,
							"].[",
							this.SourceTableName,
							"]"
						});
					}
				}
				else if (Operators.CompareString(format, "excel", true) == 0)
				{
					text = string.Concat(new string[]
					{
						"[EXCEL 8.0;DATABASE=",
						this.SourcePath,
						"].[",
						this.SourceTableName,
						"]"
					});
				}
				else if (Operators.CompareString(format, "excel2007", true) == 0 || Operators.CompareString(format, "excel 2007", true) == 0)
				{
					text = string.Concat(new string[]
					{
						"[EXCEL 12.0;DATABASE=",
						this.SourcePath,
						"].[",
						this.SourceTableName,
						"]"
					});
				}
				else if (Operators.CompareString(format, "dbase", true) == 0)
				{
					text = string.Concat(new string[]
					{
						"[dBASE IV;DATABASE=",
						this.SourcePath,
						"].[",
						this.SourceTableName,
						"]"
					});
				}
				else if (Operators.CompareString(format, "Delimited", true) == 0)
				{
					if (this.Header)
					{
						text = string.Concat(new string[]
						{
							"[text;HDR=Yes;FMT=Delimited;DATABASE=",
							this.SourcePath,
							"].[",
							this.SourceTableName,
							"#txt]"
						});
					}
					else
					{
						text = string.Concat(new string[]
						{
							"[text;HDR=No;FMT=Delimited;DATABASE=",
							this.SourcePath,
							"].[",
							this.SourceTableName,
							"#txt]"
						});
					}
				}
				else
				{
					if (Operators.CompareString(format, "Fixed", true) != 0)
					{
						return;
					}
					if (this.Header)
					{
						text = string.Concat(new string[]
						{
							"[text;HDR=Yes;FMT=Fixed;DATABASE=",
							this.SourcePath,
							"].[",
							this.SourceTableName,
							"#txt]"
						});
					}
					else
					{
						text = string.Concat(new string[]
						{
							"[text;HDR=No;FMT=Fixed;DATABASE=",
							this.SourcePath,
							"].[",
							this.SourceTableName,
							"#txt]"
						});
					}
				}
				text = "Select " + this.Fields + " From " + text;
				if (Operators.CompareString(this.Filter, "", true) > 0)
				{
					text = text + " Where " + this.Filter;
				}
				if (this.SourcePath.ToLower().EndsWith(".accdb") || this.SourcePath.ToLower().EndsWith(".xlsx"))
				{
					this.o.o_oo0OoO. = new OleDbDataAdapter("", Oo00.OOO_O0O0.o.(OO_00oOO.ProjectFile));
				}
				else
				{
					this.o.o_oo0OoO. = new OleDbDataAdapter("", O_O0OO.OoO.0OO__0ooo.());
				}
				this.o.o_oo0OoO..SelectCommand.CommandText = text;
			}
			else
			{
				string text = "Select " + this.Fields + " From " + this.SourceTableName;
				if (Operators.CompareString(this.Filter, "", true) > 0)
				{
					text = text + " Where " + this.Filter;
				}
				this.o.o_oo0OoO. = new OleDbDataAdapter(text, O_O0OO.O._o_.()[this.ConnectionName]);
			}
			try
			{
				List<string> list = new List<string>();
				new Dictionary<string, string>();
				this.o.o_oo0OoO..Fill(this.o.o_oo0OoO.);
				try
				{
					foreach (object obj in this.o.o_oo0OoO..Columns)
					{
						DataColumn dataColumn = (DataColumn)obj;
						if (o_O_o_oOoo__.oO.O_..Contains(dataColumn.ColumnName) && Operators.CompareString(dataColumn.ColumnName, "_SortKey", true) != 0)
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
						this.o.o_oo0OoO..Columns.Remove(name);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				list.Clear();
				try
				{
					foreach (object obj2 in this.o.o_oo0OoO..Columns)
					{
						DataColumn dataColumn2 = (DataColumn)obj2;
						if (this.FieldMaps.ContainsKey(dataColumn2.ColumnName))
						{
							dataColumn2.Caption = this.FieldMaps[dataColumn2.ColumnName];
						}
						else if (O_O0OO.OOOo.oo_OOOO_0.().Tables[this.DataTableName].Columns.Contains(dataColumn2.ColumnName))
						{
							if (!this.FieldMaps.ContainsValue(dataColumn2.ColumnName))
							{
								dataColumn2.Caption = dataColumn2.ColumnName;
							}
							else
							{
								list.Add(dataColumn2.ColumnName);
							}
						}
						else
						{
							list.Add(dataColumn2.ColumnName);
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
				try
				{
					foreach (string name2 in list)
					{
						this.o.o_oo0OoO..Columns.Remove(name2);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
				OO_00oOO.DataTables[this.DataTableName].StopRedraw();
				DataTable dataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables[this.DataTableName];
				List<DataRow> list2 = new List<DataRow>();
				DataRow[] array;
				if (this.o.o_oo0OoO..Columns.Contains("_SortKey"))
				{
					array = this.o.o_oo0OoO..Select("", "[_SortKey]");
				}
				else
				{
					array = this.o.o_oo0OoO..Select();
				}
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					list2.Add(dataTable.NewRow());
				}
				try
				{
					foreach (object obj3 in this.o.o_oo0OoO..Columns)
					{
						DataColumn dataColumn3 = (DataColumn)obj3;
						string caption = dataColumn3.Caption;
						if (Operators.CompareString(caption, "_SortKey", true) != 0)
						{
							int num2 = list2.Count - 1;
							for (int j = 0; j <= num2; j++)
							{
								list2[j][caption] = RuntimeHelpers.GetObjectValue(array[j][dataColumn3]);
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator5;
					if (enumerator5 is IDisposable)
					{
						(enumerator5 as IDisposable).Dispose();
					}
				}
				try
				{
					foreach (DataRow row in list2)
					{
						dataTable.Rows.Add(row);
					}
				}
				finally
				{
					List<DataRow>.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
				dataTable = null;
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				OO_00oOO.DataTables[this.DataTableName].ResumeRedraw();
			}
		}

		// Token: 0x040014C6 RID: 5318
		private string <<EMPTY_NAME>>;

		// Token: 0x040014C7 RID: 5319
		private string <<EMPTY_NAME>>;

		// Token: 0x040014C8 RID: 5320
		private string <<EMPTY_NAME>>;

		// Token: 0x040014C9 RID: 5321
		private string <<EMPTY_NAME>>;

		// Token: 0x040014CA RID: 5322
		private string <<EMPTY_NAME>>;

		// Token: 0x040014CB RID: 5323
		private string <<EMPTY_NAME>>;

		// Token: 0x040014CC RID: 5324
		private string <<EMPTY_NAME>>;

		// Token: 0x040014CD RID: 5325
		private bool <<EMPTY_NAME>>;

		// Token: 0x040014CE RID: 5326
		private Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x040014CF RID: 5327
		private string <<EMPTY_NAME>>;

		// Token: 0x040014D0 RID: 5328
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x040014D1 RID: 5329
		private OleDbDataAdapter <<EMPTY_NAME>>;
	}
}
