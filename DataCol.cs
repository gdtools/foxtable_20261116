using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002A7 RID: 679
	[ComVisible(true)]
	[oO0oooo("1356")]
	public class DataCol
	{
		// Token: 0x06002283 RID: 8835 RVA: 0x000F7220 File Offset: 0x000F5420
		internal DataCol(DataColumn A_0)
		{
			this.o_.O___. = new DataColumnProperty(this);
			this.O0O_0_._o__0. = 1;
			this.O_.O0o_00. = true;
			this.o0_o.o__o0_o. = false;
			this.o0oo__o0O.o. = false;
			this.o_O_00._O__. = BooleanEnum.False;
			this.O0.00oOoOO0Oo_. = BooleanEnum.True;
			this.Oo_o.OOO0_0OO0. = BooleanEnum.Default;
			this.O0_O_OOO_.0O. = DateTimeFormatEnum.Date;
			this.ooOo.O_o. = 4;
			this.OO0O._. = false;
			this.ooo_O0oOO._. = 0;
			this.O0_O_OOO_.0O. = DataMapTypeEnum.无;
			this.O_0_OO0___.0oo. = ImageMapTypeEnum.无;
			this.OO0.o0oO. = TextAlignEnum.Default;
			this.O.oO_O_o. = TextAlignEnum.Default;
			this.ooOo.__. = true;
			this.oO.o_OOOO__O0. = ",";
			this.o0o.0_o. = true;
			this.OO0.o0oO. = '\\';
			this.O.oO_O_o. = '|';
			this.oo.0_0_O. = 11;
			this.o0_00O.____. = ExtendColumnTypeEnum.无;
			this.o._0O0Oo00. = 21;
			this.o0_00O.____. = DockAreaEnum.右;
			this.ooo0O0_o00.0o_. = false;
			this.OO.00o_Oo_o0_0. = false;
			this.O_O_0000O.o. = true;
			this.ooo0__o_o_o._. = true;
			this.O__0o0Oo_.O_. = true;
			this.oOo0o0.O000. = true;
			this.OOo.0. = true;
			this.ooo_.O0OO0_o. = 6;
			this.o0O_0_._oo. = A_0;
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
			{
				this.o0O_0_._oo..Table.TableName,
				this.o0O_0_._oo..ColumnName
			});
			if (dataRow != null && !dataRow.IsNull("Config"))
			{
				o_O_o_oOoo__.OOOO_OO._oo.(this.o_.O___., Conversions.ToString(dataRow["Config"]), '\v');
			}
			if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.o0o.o.()].Rows.Find(new object[]
			{
				this.o0O_0_._oo..Table.TableName,
				this.o0O_0_._oo..ColumnName
			}) != null)
			{
				this.o_.O___. = true;
			}
			Type dataType = A_0.DataType;
			typeof(bool);
			if (A_0.ReadOnly && Operators.CompareString(A_0.Expression, "", true) == 0)
			{
				A_0.ReadOnly = false;
			}
			if (A_0.Unique)
			{
				int num = A_0.Table.PrimaryKey.Length - 1;
				bool flag;
				for (int i = 0; i <= num; i++)
				{
					if (A_0 == A_0.Table.PrimaryKey[i])
					{
						flag = true;
						break;
					}
				}
				if (!flag && A_0.Unique)
				{
					A_0.Unique = false;
				}
			}
			if (!A_0.AllowDBNull)
			{
				A_0.AllowDBNull = true;
			}
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x000F747C File Offset: 0x000F567C
		internal void <<EMPTY_NAME>>()
		{
			this.ooOO.oO0o. = null;
			this.O._00_. = null;
			this.O_oo0_00.__0__. = "";
			this.o0_00O.____. = null;
			this.oO0._00o_0. = null;
			if ((this.DataMapType == DataMapTypeEnum.标准 || this.DataMapType == DataMapTypeEnum.代码项目) && this.DataMap != null)
			{
				ListDictionary listDictionary = new ListDictionary();
				foreach (string text in this.DataMap.Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					object obj = null;
					if (this.OOOo_._oO0_O.(text.Substring(0, text.IndexOf('\t')), ref obj))
					{
						listDictionary[RuntimeHelpers.GetObjectValue(obj)] = text.Substring(text.IndexOf('\t') + 1);
					}
				}
				if (listDictionary.Count <= 0)
				{
					goto IL_22D;
				}
				if (this.DataMapType == DataMapTypeEnum.标准)
				{
					this.ooOO.oO0o. = listDictionary;
					goto IL_22D;
				}
				this.oO0._00o_0. = new Dictionary<string, string>();
				try
				{
					foreach (object obj2 in listDictionary.Keys)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj2);
						if (listDictionary[RuntimeHelpers.GetObjectValue(objectValue)] != null)
						{
							this.oO0._00o_0..Add(objectValue.ToString(), listDictionary[RuntimeHelpers.GetObjectValue(objectValue)].ToString());
						}
					}
					goto IL_22D;
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
			if (this.DataMapType == DataMapTypeEnum.多列 && this.MultiDataMap != null)
			{
				MultiDataMap multiDataMap = new MultiDataMap();
				string[] array2 = this.MultiDataMap.Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				multiDataMap.DisplayCol = this.MultiDataMapDisplayCol;
				multiDataMap.ValueCol = this.MultiDataMapValueCol;
				foreach (string text2 in array2)
				{
					multiDataMap.Add(text2.Replace("\t", "|"));
				}
				if (array2.Length > 0)
				{
					this.ooOO.oO0o. = multiDataMap.CreateDataMap();
				}
			}
			else if (this.DataMapType == DataMapTypeEnum.数据表 && this.DataMapTable != null)
			{
				this.ooOO.oO0o. = Oo00.OO.0O0o.(this.DataMapTable, this.DataMapListColumns, this.DataMapValueColumn, this.DataMapListColumn, this.DataMapFilter, this.DataMapSort);
			}
			IL_22D:
			if (this.ImageMapType == ImageMapTypeEnum.有 && this.ImageMap != null)
			{
				ListDictionary listDictionary2 = new ListDictionary();
				string text3 = "";
				foreach (string text4 in this.ImageMap.Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries))
				{
					string text5 = text4.Substring(0, text4.IndexOf('\t'));
					string imageFile = text4.Substring(text4.IndexOf('\t') + 1);
					listDictionary2[text5] = OO_00oOO.GetImage(imageFile);
					if (Operators.CompareString(text3, "", true) > 0)
					{
						text3 += "|";
					}
					text3 += text5;
				}
				this.O._00_. = listDictionary2;
				this.O_oo0_00.__0__. = text3;
			}
			if ((this.ExtendColumnType == ExtendColumnTypeEnum.多文件 || this.ExtendColumnType == ExtendColumnTypeEnum.文件 || this.ExtendColumnType == ExtendColumnTypeEnum.图片) && this.Remote)
			{
				this.FTPClient = new FTPClient();
				FTPClient ftpclient = this.FTPClient;
				ftpclient.Host = this.Host;
				ftpclient.Account = this.Account;
				ftpclient.RootDir = this.RootDir;
				ftpclient.Password = this.Password;
				ftpclient.UTF8 = this.UTF8;
				ftpclient.Port = this.Port;
			}
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x000F780C File Offset: 0x000F5A0C
		private bool <<EMPTY_NAME>>(string A_0, ref object A_1)
		{
			bool result;
			if (this.BaseColumn.DataType == typeof(string))
			{
				A_1 = A_0;
				result = true;
			}
			else if (this.BaseColumn.DataType == typeof(int))
			{
				int num;
				if (int.TryParse(A_0, out num))
				{
					A_1 = num;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			else if (this.BaseColumn.DataType == typeof(long))
			{
				long num2;
				if (long.TryParse(A_0, out num2))
				{
					A_1 = num2;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			else if (this.BaseColumn.DataType == typeof(double))
			{
				double num3;
				if (double.TryParse(A_0, out num3))
				{
					A_1 = num3;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			else if (this.BaseColumn.DataType == typeof(float))
			{
				float num4;
				if (float.TryParse(A_0, out num4))
				{
					A_1 = num4;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			else if (this.BaseColumn.DataType == typeof(short))
			{
				short num5;
				if (short.TryParse(A_0, out num5))
				{
					A_1 = num5;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			else if (this.BaseColumn.DataType == typeof(byte))
			{
				byte b;
				if (byte.TryParse(A_0, out b))
				{
					A_1 = b;
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x000F7974 File Offset: 0x000F5B74
		internal void <<EMPTY_NAME>>(bool A_0 = true)
		{
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
			{
				this.o0O_0_._oo..Table.TableName,
				this.o0O_0_._oo..ColumnName
			});
			if (dataRow == null)
			{
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].NewRow();
				dataRow["Table"] = this.o0O_0_._oo..Table.TableName;
				dataRow["Column"] = this.o0O_0_._oo..ColumnName;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Add(dataRow);
			}
			dataRow["Config"] = o_O_o_oOoo__.OOOO_OO._oo.(this.o_.O___., false, '\v', false);
			if (A_0)
			{
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()], true);
			}
		}

		/// <summary>
		/// 列名
		/// </summary>
		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x000F7A6B File Offset: 0x000F5C6B
		[oO0oooo("0409")]
		public string Name
		{
			get
			{
				return this.o0O_0_._oo..ColumnName;
			}
		}

		/// <summary>
		/// 返回或设置列的计算表达式
		/// </summary>
		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x000F7A78 File Offset: 0x000F5C78
		// (set) Token: 0x06002289 RID: 8841 RVA: 0x000F7A88 File Offset: 0x000F5C88
		[oO0oooo("0417")]
		public string Expression
		{
			get
			{
				return this.o0O_0_._oo..Expression;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0)
				{
					value = string.Empty;
				}
				if (this.IsTemporary)
				{
					this.o0O_0_._oo..Expression = value;
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this.o0O_0_._oo..Table)
							{
								table.foxGrid.Invalidate();
							}
						}
						return;
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				MessageBox.Show("[" + this.Name + "]非表达式列，不能设置计算表达式！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		/// <summary>
		/// 返回或设置列的默认值
		/// </summary>
		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600228A RID: 8842 RVA: 0x000F7B3C File Offset: 0x000F5D3C
		// (set) Token: 0x0600228B RID: 8843 RVA: 0x000F7B44 File Offset: 0x000F5D44
		[oO0oooo("1281")]
		public string DefaultValue
		{
			get
			{
				return this.oO_O_o.O0__.;
			}
			set
			{
				this.oO_O_o.O0__. = value;
			}
		}

		/// <summary>
		/// 是否允许编辑该列
		/// </summary>
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x000F7B4D File Offset: 0x000F5D4D
		// (set) Token: 0x0600228D RID: 8845 RVA: 0x000F7B58 File Offset: 0x000F5D58
		[oO0oooo("0410")]
		public bool AllowEdit
		{
			get
			{
				return this.O_.O0o_00.;
			}
			set
			{
				this.O_.O0o_00. = value;
				if (OO_00oOO.Tables != null)
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.View.o_o.O0ooOo.() == this.o0O_0_._oo..Table && table.Cols.Contains(this.Name) && table.foxGrid.Cols.Contains(this.Name))
							{
								table.foxGrid.Cols[this.Name].Invalidate();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					Main.OO_O.o..O.ooO0. = true;
				}
			}
		}

		/// <summary>
		/// 是否禁止该列输入重复值
		/// </summary>
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x000F7C18 File Offset: 0x000F5E18
		// (set) Token: 0x0600228F RID: 8847 RVA: 0x000F7C20 File Offset: 0x000F5E20
		[oO0oooo("0411")]
		public bool Unique
		{
			get
			{
				return this.o0_o.o__o0_o.;
			}
			set
			{
				this.o0_o.o__o0_o. = value;
			}
		}

		/// <summary>
		/// 设置列的日期时间格式
		/// </summary>
		// Token: 0x06002290 RID: 8848 RVA: 0x000F7C2C File Offset: 0x000F5E2C
		[oO0oooo("1611")]
		public void SetDateTimeFormat(DateTimeFormatEnum format)
		{
			this.DateTimeFormat = format;
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable.BaseTable == this.o0O_0_._oo..Table && table.Loaded && table.Cols.Contains(this.Name))
					{
						table.Cols[this.Name].SetDateTimeFormat(format);
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		/// <summary>
		/// 设置列的显示格式。
		/// </summary>
		/// <param name="fmt"></param>
		// Token: 0x06002291 RID: 8849 RVA: 0x000F7CC4 File Offset: 0x000F5EC4
		[oO0oooo("1659")]
		public void SetFormat(string fmt)
		{
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable.BaseTable == this.o0O_0_._oo..Table && table.Loaded && table.Cols.Contains(this.Name))
					{
						table.foxGrid.Cols[this.Name].Format = fmt;
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000F7D58 File Offset: 0x000F5F58
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Recalc()
		{
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000F7D5A File Offset: 0x000F5F5A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Recalc(DataRow dr)
		{
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x000F7D5C File Offset: 0x000F5F5C
		public Type DataType
		{
			get
			{
				return this.o0O_0_._oo..DataType;
			}
		}

		/// <summary>
		/// 如果是字符列，返回该列允许输入的最大长度，否则返回-1
		/// </summary>
		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x000F7D69 File Offset: 0x000F5F69
		[oO0oooo("0412")]
		public int MaxLength
		{
			get
			{
				return this.o0O_0_._oo..MaxLength;
			}
		}

		/// <summary>
		/// 判断该列是否是数值型
		/// </summary>
		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x000F7D76 File Offset: 0x000F5F76
		[oO0oooo("0413")]
		public bool IsNumeric
		{
			get
			{
				return o_O_o_oOoo__.OO_.O.(this.o0O_0_._oo..DataType);
			}
		}

		/// <summary>
		/// 判断该列是否是日期型
		/// </summary>
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x000F7D88 File Offset: 0x000F5F88
		[oO0oooo("0415")]
		public bool IsDate
		{
			get
			{
				bool result;
				if (this.o0O_0_._oo..DataType == typeof(DateTime))
				{
					result = true;
				}
				return result;
			}
		}

		/// <summary>
		/// 判断该列是否是逻辑型
		/// </summary>
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x000F7DB0 File Offset: 0x000F5FB0
		[oO0oooo("0416")]
		public bool IsBoolean
		{
			get
			{
				bool result;
				if (this.o0O_0_._oo..DataType == typeof(bool))
				{
					result = true;
				}
				return result;
			}
		}

		/// <summary>
		/// 判断该列是否是字符型
		/// </summary>
		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x000F7DD8 File Offset: 0x000F5FD8
		[oO0oooo("0414")]
		public bool IsString
		{
			get
			{
				bool result;
				if (this.o0O_0_._oo..DataType == typeof(string))
				{
					result = true;
				}
				return result;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x000F7DFF File Offset: 0x000F5FFF
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x000F7E07 File Offset: 0x000F6007
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DateTimeFormatEnum DateTimeFormat
		{
			get
			{
				return this.O0_O_OOO_.0O.;
			}
			set
			{
				this.O0_O_OOO_.0O. = value;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x000F7E10 File Offset: 0x000F6010
		[EditorBrowsable(EditorBrowsableState.Never)]
		public oooOooo NumericType
		{
			get
			{
				oooOooo result;
				if (this.o0O_0_._oo..DataType == typeof(decimal))
				{
					result = oooOooo.o___O_0O_O00.O.;
				}
				else if (this.o0O_0_._oo..DataType == typeof(double))
				{
					result = oooOooo.o_O_.Oo_0.;
				}
				else if (this.o0O_0_._oo..DataType == typeof(float))
				{
					result = oooOooo.Ooo00.o0_00o_.;
				}
				else if (this.o0O_0_._oo..DataType == typeof(long))
				{
					result = oooOooo.oo0OO.o.;
				}
				else if (this.o0O_0_._oo..DataType == typeof(int))
				{
					result = oooOooo.O0_.O_.;
				}
				else if (this.o0O_0_._oo..DataType == typeof(short))
				{
					result = oooOooo.oo_O__0O_.O00o.;
				}
				else if (this.o0O_0_._oo..DataType == typeof(byte))
				{
					result = oooOooo.oOo._0O__0.;
				}
				return result;
			}
		}

		/// <summary>
		/// 如果某列被扩展为多文件型，并用于远程文件管理，那么可以用此属性返回一个FTPClient
		/// </summary>
		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x000F7EDF File Offset: 0x000F60DF
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x000F7EE7 File Offset: 0x000F60E7
		[oO0oooo("1477")]
		public FTPClient FTPClient
		{
			get
			{
				return this.o0_00O.____.;
			}
			internal set
			{
				this.o0_00O.____. = value;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x000F7EF0 File Offset: 0x000F60F0
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x000F7EF8 File Offset: 0x000F60F8
		internal string Separator
		{
			get
			{
				return this.oO.o_OOOO__O0.;
			}
			set
			{
				this.oO.o_OOOO__O0. = value;
			}
		}

		/// <summary>
		/// 返回所属的DataTable
		/// </summary>
		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x000F7F01 File Offset: 0x000F6101
		public DataTable DataTable
		{
			get
			{
				return OO_00oOO.DataTables[this.o0O_0_._oo..Table.TableName];
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x000F7F1D File Offset: 0x000F611D
		internal DataColumnProperty Setting
		{
			get
			{
				return this.o_.O___.;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x000F7F28 File Offset: 0x000F6128
		// (set) Token: 0x060022A4 RID: 8868 RVA: 0x000F7F9E File Offset: 0x000F619E
		internal bool IsTemporary
		{
			get
			{
				bool result;
				if (Operators.CompareString(this.DataTable.UpdateServer, "", true) > 0)
				{
					result = !this.DataTable.UpdateColumns.Contains(this.Name.ToLower());
				}
				else
				{
					result = (this.o0O_0_._oo..Table.DataSet == null || this.DataTable.frd_IsTemporary || this.o_.O___.);
				}
				return result;
			}
			set
			{
				if (this.o0O_0_._oo..Table.DataSet != null && !this.DataTable.frd_IsTemporary)
				{
					this.o_.O___. = value;
				}
			}
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x000F7FC8 File Offset: 0x000F61C8
		internal bool <<EMPTY_NAME>>()
		{
			checked
			{
				try
				{
					foreach (object obj in O_O0OO.OOOo.oo_OOOO_0.().Relations)
					{
						DataRelation dataRelation = (DataRelation)obj;
						DataColumn[] parentColumns = dataRelation.ParentColumns;
						for (int i = 0; i < parentColumns.Length; i++)
						{
							if (parentColumns[i] == this.o0O_0_._oo.)
							{
								return true;
							}
						}
						DataColumn[] childColumns = dataRelation.ChildColumns;
						for (int j = 0; j < childColumns.Length; j++)
						{
							if (childColumns[j] == this.o0O_0_._oo.)
							{
								return true;
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
				bool result;
				return result;
			}
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x000F8078 File Offset: 0x000F6278
		internal void <<EMPTY_NAME>>()
		{
			OO_00oOO.DataTables[this.o0O_0_._oo..Table.TableName].DataCols.Delete(this.o0O_0_._oo..ColumnName);
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x000F80A9 File Offset: 0x000F62A9
		internal DataColumn BaseColumn
		{
			get
			{
				return this.o0O_0_._oo.;
			}
		}

		/// <summary>
		/// 返回或设置列标题
		/// </summary>
		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x000F80B1 File Offset: 0x000F62B1
		// (set) Token: 0x060022A9 RID: 8873 RVA: 0x000F80B9 File Offset: 0x000F62B9
		[oO0oooo("1447")]
		public string Caption
		{
			get
			{
				return this.o0O_0_._oo.;
			}
			set
			{
				this.o0O_0_._oo. = value;
			}
		}

		/// <summary>
		/// 字符型，设置在记录窗口显示的缩写标题
		/// </summary>
		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x000F80C2 File Offset: 0x000F62C2
		// (set) Token: 0x060022AB RID: 8875 RVA: 0x000F80CA File Offset: 0x000F62CA
		[oO0oooo("2201")]
		public string ShortCaption
		{
			get
			{
				return this.o.00_OO_O_o.;
			}
			set
			{
				this.o.00_OO_O_o. = value;
			}
		}

		/// <summary>
		/// 是否在记录窗口显示此列
		/// </summary>
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x000F80D3 File Offset: 0x000F62D3
		// (set) Token: 0x060022AD RID: 8877 RVA: 0x000F80DB File Offset: 0x000F62DB
		[oO0oooo("2201")]
		public BooleanEnum ShowInRecordGrid
		{
			get
			{
				return this.o_.O___.;
			}
			set
			{
				this.o_.O___. = value;
			}
		}

		/// <summary>
		/// 设置此列在记录窗口显示时，行高是默认行高的多少倍。
		/// </summary>
		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x000F80E4 File Offset: 0x000F62E4
		// (set) Token: 0x060022AF RID: 8879 RVA: 0x000F80EC File Offset: 0x000F62EC
		[oO0oooo("2201")]
		public int RecordRowHeight
		{
			get
			{
				return this.O0O_0_._o__0.;
			}
			set
			{
				this.O0O_0_._o__0. = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x000F80F5 File Offset: 0x000F62F5
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x000F80FD File Offset: 0x000F62FD
		internal string EditMask
		{
			get
			{
				return this.O.OO0_oo_O0.;
			}
			set
			{
				this.O.OO0_oo_O0. = value;
			}
		}

		/// <summary>
		/// ImeMode
		/// </summary>
		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x000F8106 File Offset: 0x000F6306
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x000F810E File Offset: 0x000F630E
		[oO0oooo("1660")]
		public BooleanEnum ImeMode
		{
			get
			{
				return this.Oo_o.OOO0_0OO0.;
			}
			set
			{
				this.Oo_o.OOO0_0OO0. = value;
			}
		}

		/// <summary>
		/// 返回或设置逻辑格式
		/// </summary>
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x000F8117 File Offset: 0x000F6317
		// (set) Token: 0x060022B5 RID: 8885 RVA: 0x000F811F File Offset: 0x000F631F
		[oO0oooo("1306")]
		internal string BooleanFormat
		{
			get
			{
				return this.OoOo._.;
			}
			set
			{
				this.OoOo._. = value;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x000F8128 File Offset: 0x000F6328
		// (set) Token: 0x060022B7 RID: 8887 RVA: 0x000F8130 File Offset: 0x000F6330
		internal TextAlignEnum TextAlign
		{
			get
			{
				return this.OO0.o0oO.;
			}
			set
			{
				this.OO0.o0oO. = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x000F8139 File Offset: 0x000F6339
		// (set) Token: 0x060022B9 RID: 8889 RVA: 0x000F8141 File Offset: 0x000F6341
		internal TextAlignEnum TextAlignFixed
		{
			get
			{
				return this.O.oO_O_o.;
			}
			set
			{
				this.O.oO_O_o. = value;
			}
		}

		/// <summary>
		/// 是否启用输入助手
		/// </summary>
		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x000F814A File Offset: 0x000F634A
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x000F8152 File Offset: 0x000F6352
		public bool AutoComplete
		{
			get
			{
				return this.O_o00o00O.0o__.;
			}
			set
			{
				this.O_o00o00O.0o__. = value;
			}
		}

		/// <summary>
		/// 手工针对该列触发DataColChanged事件
		/// </summary>
		// Token: 0x060022BC RID: 8892 RVA: 0x000F815B File Offset: 0x000F635B
		[oO0oooo("1468")]
		public void RaiseDataColChanged()
		{
			this.DataTable.oO.o_0.(this);
		}

		/// <summary>
		/// 手工针对该列触发DataColChanged事件
		/// </summary>
		/// <param name="dataRow">指定触发事件的行</param>
		// Token: 0x060022BD RID: 8893 RVA: 0x000F8169 File Offset: 0x000F6369
		[oO0oooo("1468")]
		public void RaiseDataColChanged(DataRow dataRow)
		{
			this.DataTable.oO.o_0.(this, dataRow);
		}

		/// <summary>
		/// 手工针对该列触发DataColChanged事件
		/// </summary>
		/// <param name="Filter">指定触发条件</param>
		// Token: 0x060022BE RID: 8894 RVA: 0x000F8178 File Offset: 0x000F6378
		[oO0oooo("1468")]
		public void RaiseDataColChanged(string Filter)
		{
			try
			{
				foreach (DataRow a_ in this.DataTable.Select(Filter))
				{
					this.DataTable.oO.o_0.(this, a_);
				}
			}
			finally
			{
				List<DataRow>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x000F81D8 File Offset: 0x000F63D8
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x000F81E0 File Offset: 0x000F63E0
		internal string ComboList
		{
			get
			{
				return this.oO__.o_oOoO.;
			}
			set
			{
				this.oO__.o_oOoO. = value;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x000F81E9 File Offset: 0x000F63E9
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x000F81F1 File Offset: 0x000F63F1
		internal string DisplayMember
		{
			get
			{
				return this.OOoo_.00oOo0o.;
			}
			set
			{
				this.OOoo_.00oOo0o. = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x000F81FA File Offset: 0x000F63FA
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x000F8202 File Offset: 0x000F6402
		internal string ValueMember
		{
			get
			{
				return this.OOO.o.;
			}
			set
			{
				this.OOO.o. = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x000F820B File Offset: 0x000F640B
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x000F8213 File Offset: 0x000F6413
		internal string DataSource
		{
			get
			{
				return this.OO_0_00.O0.;
			}
			set
			{
				this.OO_0_00.O0. = value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x000F821C File Offset: 0x000F641C
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x000F8224 File Offset: 0x000F6424
		internal string DataFilter
		{
			get
			{
				return this.O.__O00o0_O.;
			}
			set
			{
				this.O.__O00o0_O. = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x000F822D File Offset: 0x000F642D
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x000F8235 File Offset: 0x000F6435
		internal string DataSort
		{
			get
			{
				return this.O_0_.0OO.;
			}
			set
			{
				this.O_0_.0OO. = value;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x000F823E File Offset: 0x000F643E
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x000F8246 File Offset: 0x000F6446
		internal bool AllowEditValue
		{
			get
			{
				return this.o0o.0_o.;
			}
			set
			{
				this.o0o.0_o. = value;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x000F824F File Offset: 0x000F644F
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x000F8257 File Offset: 0x000F6457
		internal bool MultiColumn
		{
			get
			{
				return this.oO0.oO0_0.;
			}
			set
			{
				this.oO0.oO0_0. = value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x000F8260 File Offset: 0x000F6460
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x000F8268 File Offset: 0x000F6468
		internal int ColumnWidth
		{
			get
			{
				return this.o00ooO0Oo.oo0O.;
			}
			set
			{
				this.o00ooO0Oo.oo0O. = value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x000F8271 File Offset: 0x000F6471
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x000F8279 File Offset: 0x000F6479
		internal int DropDownWidth
		{
			get
			{
				return this.OO0O._.;
			}
			set
			{
				this.OO0O._. = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x000F8282 File Offset: 0x000F6482
		// (set) Token: 0x060022D4 RID: 8916 RVA: 0x000F828A File Offset: 0x000F648A
		internal int DropDownHeight
		{
			get
			{
				return this.Oo0O0Ooo0.0o.;
			}
			set
			{
				this.Oo0O0Ooo0.0o. = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x000F8293 File Offset: 0x000F6493
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x000F829B File Offset: 0x000F649B
		internal int MaxDropDownItems
		{
			get
			{
				return this.oo.0_0_O.;
			}
			set
			{
				value = Math.Max(1, value);
				this.oo.0_0_O. = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x000F82AD File Offset: 0x000F64AD
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x000F82B5 File Offset: 0x000F64B5
		internal int ItemSpacing
		{
			get
			{
				return this.ooo_.O0OO0_o.;
			}
			set
			{
				this.ooo_.O0OO0_o. = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x000F82BE File Offset: 0x000F64BE
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x000F82C6 File Offset: 0x000F64C6
		internal string TreeFile
		{
			get
			{
				return this.o._Oo0.;
			}
			set
			{
				this.o._Oo0. = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x000F82CF File Offset: 0x000F64CF
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x000F82D7 File Offset: 0x000F64D7
		internal string TreeReceiveCols
		{
			get
			{
				return this.o.oO.;
			}
			set
			{
				this.o.oO. = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x000F82E0 File Offset: 0x000F64E0
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x000F82E8 File Offset: 0x000F64E8
		internal string TreeSourceTable
		{
			get
			{
				return this.oO.O.;
			}
			set
			{
				this.oO.O. = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x000F82F1 File Offset: 0x000F64F1
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x000F82F9 File Offset: 0x000F64F9
		internal string TreeBuildCols
		{
			get
			{
				return this.O0o.oo_O0o.;
			}
			set
			{
				this.O0o.oo_O0o. = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x000F8302 File Offset: 0x000F6502
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x000F830A File Offset: 0x000F650A
		internal string TreeFilter
		{
			get
			{
				return this.OO.O00O0_o.;
			}
			set
			{
				this.OO.O00O0_o. = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x000F8313 File Offset: 0x000F6513
		// (set) Token: 0x060022E4 RID: 8932 RVA: 0x000F831B File Offset: 0x000F651B
		internal string TreeSourceCols
		{
			get
			{
				return this.Oo0_0__o_.O0.;
			}
			set
			{
				this.Oo0_0__o_.O0. = value;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x000F8324 File Offset: 0x000F6524
		// (set) Token: 0x060022E6 RID: 8934 RVA: 0x000F832C File Offset: 0x000F652C
		internal char TreePathSeparator
		{
			get
			{
				return this.OO0.o0oO.;
			}
			set
			{
				if (Operators.CompareString(Conversions.ToString(value), "", true) == 0)
				{
					value = '\\';
				}
				this.OO0.o0oO. = value;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x000F834C File Offset: 0x000F654C
		// (set) Token: 0x060022E8 RID: 8936 RVA: 0x000F8354 File Offset: 0x000F6554
		internal char TreeContentSeparator
		{
			get
			{
				return this.O.oO_O_o.;
			}
			set
			{
				if (Operators.CompareString(Conversions.ToString(value), "", true) == 0)
				{
					value = '|';
				}
				this.O.oO_O_o. = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x000F8374 File Offset: 0x000F6574
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x000F837C File Offset: 0x000F657C
		internal bool TreeSeparateContent
		{
			get
			{
				return this.OoO.oOo.;
			}
			set
			{
				this.OoO.oOo. = value;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x000F8385 File Offset: 0x000F6585
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x000F838D File Offset: 0x000F658D
		internal DataMapTypeEnum DataMapType
		{
			get
			{
				return this.O0_O_OOO_.0O.;
			}
			set
			{
				this.O0_O_OOO_.0O. = value;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x000F8396 File Offset: 0x000F6596
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x000F839E File Offset: 0x000F659E
		internal ImageMapTypeEnum ImageMapType
		{
			get
			{
				return this.O_0_OO0___.0oo.;
			}
			set
			{
				this.O_0_OO0___.0oo. = value;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x000F83A7 File Offset: 0x000F65A7
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x000F83AF File Offset: 0x000F65AF
		internal bool ImageAndText
		{
			get
			{
				return this.ooOo.__.;
			}
			set
			{
				this.ooOo.__. = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x000F83B8 File Offset: 0x000F65B8
		// (set) Token: 0x060022F2 RID: 8946 RVA: 0x000F83C0 File Offset: 0x000F65C0
		internal ExtendColumnTypeEnum ExtendColumnType
		{
			get
			{
				return this.o0_00O.____.;
			}
			set
			{
				if (this.o0O_0_._oo. != null)
				{
					ExtendColumnTypeEnum extendColumnTypeEnum = value;
					if (extendColumnTypeEnum != ExtendColumnTypeEnum.无)
					{
						if (extendColumnTypeEnum != ExtendColumnTypeEnum.色彩)
						{
							if (extendColumnTypeEnum != ExtendColumnTypeEnum.时段)
							{
								if (this.o0O_0_._oo..DataType != typeof(string))
								{
									if (OO_00oOO.SystemReady)
									{
										MessageBox.Show("只有字符列或者备注列才能扩展为" + value.ToString() + "列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
										return;
									}
									return;
								}
							}
							else if (this.o0O_0_._oo..DataType != typeof(double))
							{
								if (OO_00oOO.SystemReady)
								{
									MessageBox.Show("只有双精度小数列才能扩展为时段列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
									return;
								}
								return;
							}
						}
						else if (this.o0O_0_._oo..DataType != typeof(int))
						{
							if (OO_00oOO.SystemReady)
							{
								MessageBox.Show("只有整数列才能扩展为色彩列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								return;
							}
							return;
						}
					}
				}
				this.o0_00O.____. = value;
			}
		}

		/// <summary>
		/// 返回或设置设置列的扩展类型。
		/// </summary>
		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x000F84A4 File Offset: 0x000F66A4
		// (set) Token: 0x060022F4 RID: 8948 RVA: 0x000F84AC File Offset: 0x000F66AC
		[oO0oooo("1656")]
		public ExtendTypeEnum ExtendType
		{
			get
			{
				return (ExtendTypeEnum)this.o0_00O.____.;
			}
			set
			{
				this.o0_00O.____. = (ExtendColumnTypeEnum)value;
				if (this.o0O_0_._oo..Table.DataSet == O_O0OO.OOOo.oo_OOOO_0.())
				{
					try
					{
						foreach (Table table in OO_00oOO.Tables)
						{
							if (table.DataTable == this.DataTable && table.Cols.Contains(this.Name))
							{
								table.Cols[this.Name].o0.O.();
							}
						}
					}
					finally
					{
						IEnumerator<Table> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
		}

		/// <summary>
		/// 是否采用远程FTP管理文件
		/// </summary>
		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x000F8548 File Offset: 0x000F6748
		// (set) Token: 0x060022F6 RID: 8950 RVA: 0x000F8550 File Offset: 0x000F6750
		[oO0oooo("2040")]
		public bool Remote
		{
			get
			{
				return this.oO00O_.00_O00_.;
			}
			set
			{
				this.oO00O_.00_O00_. = value;
				if ((this.o0O_0_._oo..Table.DataSet != O_O0OO.OOOo.oo_OOOO_0.() || (O_O0OO.OOOo.oo_OOOO_0.() == this.DataTable.BaseTable.DataSet && OO_00oOO.SystemReady)) && ((this.ExtendType == ExtendTypeEnum.File || this.ExtendType == ExtendTypeEnum.Files || this.ExtendType == ExtendTypeEnum.Images) & this.Remote))
				{
					this.o_.Oo00_O_00_.();
				}
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x000F85C6 File Offset: 0x000F67C6
		// (set) Token: 0x060022F8 RID: 8952 RVA: 0x000F85CE File Offset: 0x000F67CE
		internal string Host
		{
			get
			{
				return this.O_o__o_.O.;
			}
			set
			{
				this.O_o__o_.O. = value;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x000F85D7 File Offset: 0x000F67D7
		// (set) Token: 0x060022FA RID: 8954 RVA: 0x000F85DF File Offset: 0x000F67DF
		internal string Account
		{
			get
			{
				return this.O.Oo0o.;
			}
			set
			{
				this.O.Oo0o. = value;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x000F85E8 File Offset: 0x000F67E8
		// (set) Token: 0x060022FC RID: 8956 RVA: 0x000F85F0 File Offset: 0x000F67F0
		internal string Password
		{
			get
			{
				return this.OoO_.0O0.;
			}
			set
			{
				this.OoO_.0O0. = value;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x000F85F9 File Offset: 0x000F67F9
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x000F8601 File Offset: 0x000F6801
		internal bool UTF8
		{
			get
			{
				return this.oO00O0O0.00_Oo.;
			}
			set
			{
				this.oO00O0O0.00_Oo. = value;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x000F860A File Offset: 0x000F680A
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x000F8612 File Offset: 0x000F6812
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Port
		{
			get
			{
				return this.o._0O0Oo00.;
			}
			set
			{
				this.o._0O0Oo00. = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x000F861B File Offset: 0x000F681B
		// (set) Token: 0x06002302 RID: 8962 RVA: 0x000F8623 File Offset: 0x000F6823
		internal string RootDir
		{
			get
			{
				return this.O__oO.o0oO00.;
			}
			set
			{
				this.O__oO.o0oO00. = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x000F862C File Offset: 0x000F682C
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x000F8634 File Offset: 0x000F6834
		internal bool AutoDownload
		{
			get
			{
				return this.oOo0o0.O000.;
			}
			set
			{
				this.oOo0o0.O000. = value;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x000F863D File Offset: 0x000F683D
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x000F8645 File Offset: 0x000F6845
		internal bool AutoUpdate
		{
			get
			{
				return this.OOo.0.;
			}
			set
			{
				this.OOo.0. = value;
			}
		}

		/// <summary>
		/// 对于扩展类型为图片、文件或者多文件的列，可以用此属性设置文件类型
		/// </summary>
		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x000F864E File Offset: 0x000F684E
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x000F8656 File Offset: 0x000F6856
		[oO0oooo("2047")]
		public string FileFilter
		{
			get
			{
				return this.o__O.o0O0o0OoO.;
			}
			set
			{
				this.o__O.o0O0o0OoO. = value;
			}
		}

		/// <summary>
		/// 如果列的扩展类型为图片、文件、或者多文件，可以用此属性指定文件的存储位置
		/// </summary>
		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x000F865F File Offset: 0x000F685F
		// (set) Token: 0x0600230A RID: 8970 RVA: 0x000F8667 File Offset: 0x000F6867
		[oO0oooo("2043")]
		public string DefaultFolder
		{
			get
			{
				return this.O_0.oO.;
			}
			set
			{
				this.O_0.oO. = value;
			}
		}

		/// <summary>
		///
		/// </summary>
		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x000F8670 File Offset: 0x000F6870
		// (set) Token: 0x0600230C RID: 8972 RVA: 0x000F8678 File Offset: 0x000F6878
		[oO0oooo("2499")]
		public string SourceFolder
		{
			get
			{
				return this.O_o_0OO0.0Oo.;
			}
			set
			{
				this.O_o_0OO0.0Oo. = value;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x000F8681 File Offset: 0x000F6881
		// (set) Token: 0x0600230E RID: 8974 RVA: 0x000F8689 File Offset: 0x000F6889
		internal string LastFolder
		{
			get
			{
				return this.oo00_0o_0Oo.O.;
			}
			set
			{
				this.oo00_0o_0Oo.O. = value;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x000F8692 File Offset: 0x000F6892
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x000F869A File Offset: 0x000F689A
		internal bool UsetBuildInEditor
		{
			get
			{
				return this.o0oo__o0O.o.;
			}
			set
			{
				this.o0oo__o0O.o. = value;
			}
		}

		/// <summary>
		/// 返回或设置数值列允许输入的最大小数位数
		/// </summary>
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x000F86A3 File Offset: 0x000F68A3
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x000F86AB File Offset: 0x000F68AB
		[oO0oooo("2046")]
		public int Decimals
		{
			get
			{
				return this.ooOo.O_o.;
			}
			set
			{
				if (value > 28)
				{
					value = 28;
				}
				else if (value < 0)
				{
					value = 0;
				}
				this.ooOo.O_o. = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x000F86C6 File Offset: 0x000F68C6
		internal IDictionary DataDictionary
		{
			get
			{
				return this.ooOO.oO0o.;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x000F86CE File Offset: 0x000F68CE
		internal IDictionary imageDictionary
		{
			get
			{
				return this.O._00_.;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x000F86D6 File Offset: 0x000F68D6
		internal string imageValues
		{
			get
			{
				return this.O_oo0_00.__0__.;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x000F86DE File Offset: 0x000F68DE
		// (set) Token: 0x06002317 RID: 8983 RVA: 0x000F86E6 File Offset: 0x000F68E6
		internal bool FixedDecimals
		{
			get
			{
				return this.OO0O._.;
			}
			set
			{
				this.OO0O._. = value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x000F86EF File Offset: 0x000F68EF
		// (set) Token: 0x06002319 RID: 8985 RVA: 0x000F86F7 File Offset: 0x000F68F7
		internal int FixedDigits
		{
			get
			{
				return this.ooo_O0oOO._.;
			}
			set
			{
				this.ooo_O0oOO._. = value;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x000F8700 File Offset: 0x000F6900
		// (set) Token: 0x0600231B RID: 8987 RVA: 0x000F8708 File Offset: 0x000F6908
		internal bool ThousandSeparator
		{
			get
			{
				return this.OoO0.O_.;
			}
			set
			{
				this.OoO0.O_. = value;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x000F8711 File Offset: 0x000F6911
		// (set) Token: 0x0600231D RID: 8989 RVA: 0x000F8719 File Offset: 0x000F6919
		internal bool PercentStyle
		{
			get
			{
				return this.OoO00O.00.;
			}
			set
			{
				this.OoO00O.00. = value;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x000F8722 File Offset: 0x000F6922
		// (set) Token: 0x0600231F RID: 8991 RVA: 0x000F872A File Offset: 0x000F692A
		internal bool ShowCurrencySymbol
		{
			get
			{
				return this.o0oo_.0o.;
			}
			set
			{
				this.o0oo_.0o. = value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x000F8733 File Offset: 0x000F6933
		// (set) Token: 0x06002321 RID: 8993 RVA: 0x000F873B File Offset: 0x000F693B
		internal string CurrencySymbol
		{
			get
			{
				return this.o0.0OOO_0OOO_o.;
			}
			set
			{
				this.o0.0OOO_0OOO_o. = value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x000F8744 File Offset: 0x000F6944
		// (set) Token: 0x06002323 RID: 8995 RVA: 0x000F874C File Offset: 0x000F694C
		internal string DataMap
		{
			get
			{
				return this.O.ooO_oOOO.;
			}
			set
			{
				this.O.ooO_oOOO. = value;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x000F8755 File Offset: 0x000F6955
		// (set) Token: 0x06002325 RID: 8997 RVA: 0x000F875D File Offset: 0x000F695D
		internal string ImageMap
		{
			get
			{
				return this.ooOo.__.;
			}
			set
			{
				this.ooOo.__. = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x000F8766 File Offset: 0x000F6966
		// (set) Token: 0x06002327 RID: 8999 RVA: 0x000F876E File Offset: 0x000F696E
		internal string DataMapTable
		{
			get
			{
				return this.o.00__O.;
			}
			set
			{
				this.o.00__O. = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x000F8777 File Offset: 0x000F6977
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x000F877F File Offset: 0x000F697F
		internal string DataMapListColumns
		{
			get
			{
				return this.o0o_oO.ooo0O_o.;
			}
			set
			{
				this.o0o_oO.ooo0O_o. = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x000F8788 File Offset: 0x000F6988
		// (set) Token: 0x0600232B RID: 9003 RVA: 0x000F8790 File Offset: 0x000F6990
		internal string DataMapValueColumn
		{
			get
			{
				return this.O00.O0O_.;
			}
			set
			{
				this.O00.O0O_. = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x000F8799 File Offset: 0x000F6999
		// (set) Token: 0x0600232D RID: 9005 RVA: 0x000F87A1 File Offset: 0x000F69A1
		internal string DataMapListColumn
		{
			get
			{
				return this.O.00.;
			}
			set
			{
				this.O.00. = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x000F87AA File Offset: 0x000F69AA
		// (set) Token: 0x0600232F RID: 9007 RVA: 0x000F87B2 File Offset: 0x000F69B2
		internal string DataMapFilter
		{
			get
			{
				return this.oO._oo.;
			}
			set
			{
				this.oO._oo. = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x000F87BB File Offset: 0x000F69BB
		// (set) Token: 0x06002331 RID: 9009 RVA: 0x000F87C3 File Offset: 0x000F69C3
		internal string DataMapSort
		{
			get
			{
				return this.O0o0o0__0.o_.;
			}
			set
			{
				this.O0o0o0__0.o_. = value;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x000F87CC File Offset: 0x000F69CC
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x000F87D4 File Offset: 0x000F69D4
		internal string MultiDataMap
		{
			get
			{
				return this.o.0O_o00O.;
			}
			set
			{
				this.o.0O_o00O. = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x000F87DD File Offset: 0x000F69DD
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x000F87E5 File Offset: 0x000F69E5
		internal bool MultiDataMapAutoKeys
		{
			get
			{
				return this.Oo_0Ooo.O_O0o.;
			}
			set
			{
				this.Oo_0Ooo.O_O0o. = value;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000F87EE File Offset: 0x000F69EE
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x000F87F6 File Offset: 0x000F69F6
		internal int MultiDataMapDisplayCol
		{
			get
			{
				return this.ooO.O.;
			}
			set
			{
				this.ooO.O. = value;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x000F87FF File Offset: 0x000F69FF
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x000F8807 File Offset: 0x000F6A07
		internal int MultiDataMapValueCol
		{
			get
			{
				return this.O0.Oo0__O_O.;
			}
			set
			{
				this.O0.Oo0__O_O. = value;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x000F8810 File Offset: 0x000F6A10
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x000F8818 File Offset: 0x000F6A18
		internal DockAreaEnum DockArea
		{
			get
			{
				return this.o0_00O.____.;
			}
			set
			{
				this.o0_00O.____. = value;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x000F8821 File Offset: 0x000F6A21
		// (set) Token: 0x0600233D RID: 9021 RVA: 0x000F8829 File Offset: 0x000F6A29
		internal bool DockTitle
		{
			get
			{
				return this.ooo0O0_o00.0o_.;
			}
			set
			{
				this.ooo0O0_o00.0o_. = value;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x000F8832 File Offset: 0x000F6A32
		// (set) Token: 0x0600233F RID: 9023 RVA: 0x000F883A File Offset: 0x000F6A3A
		internal bool AutoHide
		{
			get
			{
				return this.OO.00o_Oo_o0_0.;
			}
			set
			{
				this.OO.00o_Oo_o0_0. = value;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x000F8843 File Offset: 0x000F6A43
		// (set) Token: 0x06002341 RID: 9025 RVA: 0x000F884B File Offset: 0x000F6A4B
		internal bool ShowCaption
		{
			get
			{
				return this.O_O_0000O.o.;
			}
			set
			{
				this.O_O_0000O.o. = value;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x000F8854 File Offset: 0x000F6A54
		// (set) Token: 0x06002343 RID: 9027 RVA: 0x000F885C File Offset: 0x000F6A5C
		internal bool AllowClose
		{
			get
			{
				return this.ooo0__o_o_o._.;
			}
			set
			{
				this.ooo0__o_o_o._. = value;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x000F8865 File Offset: 0x000F6A65
		// (set) Token: 0x06002345 RID: 9029 RVA: 0x000F886D File Offset: 0x000F6A6D
		internal string CustomImage
		{
			get
			{
				return this.O0._o_.;
			}
			set
			{
				this.O0._o_. = value;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x000F8876 File Offset: 0x000F6A76
		// (set) Token: 0x06002347 RID: 9031 RVA: 0x000F887E File Offset: 0x000F6A7E
		internal bool AutoOpen
		{
			get
			{
				return this.O__0o0Oo_.O_.;
			}
			set
			{
				this.O__0o0Oo_.O_. = value;
			}
		}

		/// <summary>
		/// 是否自动删除附件
		/// </summary>
		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x000F8887 File Offset: 0x000F6A87
		// (set) Token: 0x06002349 RID: 9033 RVA: 0x000F888F File Offset: 0x000F6A8F
		[oO0oooo("0088")]
		public BooleanEnum AutoDeleteAttachFile
		{
			get
			{
				return this.o_O_00._O__.;
			}
			set
			{
				this.o_O_00._O__. = value;
			}
		}

		/// <summary>
		/// 是否自动复制附件
		/// </summary>
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x000F8898 File Offset: 0x000F6A98
		// (set) Token: 0x0600234B RID: 9035 RVA: 0x000F88A0 File Offset: 0x000F6AA0
		[oO0oooo("0088")]
		public BooleanEnum AutoCopyAttachFile
		{
			get
			{
				return this.O0.00oOoOO0Oo_.;
			}
			set
			{
				this.O0.00oOoOO0Oo_. = value;
			}
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x000F88AC File Offset: 0x000F6AAC
		internal void <<EMPTY_NAME>>(string A_0)
		{
			if (Operators.CompareString(A_0.Substring(1, 1), ":", true) != 0 && !A_0.StartsWith("\\\\"))
			{
				if (this.Remote)
				{
					A_0 = OO_00oOO.ProjectPath + "RemoteFiles\\" + A_0.Replace("/", "\\").Trim(new char[]
					{
						'\\'
					});
				}
				else
				{
					if (Operators.CompareString(this.DefaultFolder, "", true) > 0)
					{
						A_0 = this.DefaultFolder.TrimEnd(new char[]
						{
							'\\'
						}) + "\\" + A_0;
						if (Operators.CompareString(A_0.Substring(1, 1), ":", true) != 0 && !A_0.StartsWith("\\\\"))
						{
							A_0 = OO_00oOO.ProjectPath + "Attachments\\" + A_0.Trim(new char[]
							{
								'\\'
							});
						}
					}
					else
					{
						A_0 = ooO.OoO0o_o___.O.(A_0);
					}
					if (!A_0.StartsWith(OO_00oOO.ProjectPath, StringComparison.CurrentCultureIgnoreCase) && (Operators.CompareString(this.DefaultFolder, "", true) <= 0 || !A_0.StartsWith(this.DefaultFolder, StringComparison.CurrentCultureIgnoreCase)))
					{
						return;
					}
				}
			}
			if (c.OOOOO.o.().FileSystem.FileExists(A_0))
			{
				try
				{
					c.OOOOO.o.().FileSystem.DeleteFile(A_0);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x04000E50 RID: 3664
		private DataColumn <<EMPTY_NAME>>;

		// Token: 0x04000E51 RID: 3665
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E52 RID: 3666
		private DataColumnProperty <<EMPTY_NAME>>;

		// Token: 0x04000E53 RID: 3667
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E54 RID: 3668
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E55 RID: 3669
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000E56 RID: 3670
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E57 RID: 3671
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E58 RID: 3672
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E59 RID: 3673
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E5A RID: 3674
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E5B RID: 3675
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000E5C RID: 3676
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000E5D RID: 3677
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000E5E RID: 3678
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E5F RID: 3679
		private DateTimeFormatEnum <<EMPTY_NAME>>;

		// Token: 0x04000E60 RID: 3680
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E61 RID: 3681
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E62 RID: 3682
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E63 RID: 3683
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E64 RID: 3684
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E65 RID: 3685
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E66 RID: 3686
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E67 RID: 3687
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E68 RID: 3688
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E69 RID: 3689
		private DataMapTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04000E6A RID: 3690
		private ImageMapTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04000E6B RID: 3691
		private TextAlignEnum <<EMPTY_NAME>>;

		// Token: 0x04000E6C RID: 3692
		private TextAlignEnum <<EMPTY_NAME>>;

		// Token: 0x04000E6D RID: 3693
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E6E RID: 3694
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E6F RID: 3695
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E70 RID: 3696
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E71 RID: 3697
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E72 RID: 3698
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E73 RID: 3699
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E74 RID: 3700
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E75 RID: 3701
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E76 RID: 3702
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E77 RID: 3703
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E78 RID: 3704
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E79 RID: 3705
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E7A RID: 3706
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E7B RID: 3707
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E7C RID: 3708
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E7D RID: 3709
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E7E RID: 3710
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E7F RID: 3711
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E80 RID: 3712
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E81 RID: 3713
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E82 RID: 3714
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E83 RID: 3715
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E84 RID: 3716
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E85 RID: 3717
		private char <<EMPTY_NAME>>;

		// Token: 0x04000E86 RID: 3718
		private char <<EMPTY_NAME>>;

		// Token: 0x04000E87 RID: 3719
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E88 RID: 3720
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E89 RID: 3721
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E8A RID: 3722
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E8B RID: 3723
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E8C RID: 3724
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E8D RID: 3725
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E8E RID: 3726
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E8F RID: 3727
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E90 RID: 3728
		private ExtendColumnTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04000E91 RID: 3729
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E92 RID: 3730
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E93 RID: 3731
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E94 RID: 3732
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E95 RID: 3733
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E96 RID: 3734
		private FTPClient <<EMPTY_NAME>>;

		// Token: 0x04000E97 RID: 3735
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E98 RID: 3736
		private int <<EMPTY_NAME>>;

		// Token: 0x04000E99 RID: 3737
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E9A RID: 3738
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E9B RID: 3739
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E9C RID: 3740
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E9D RID: 3741
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E9E RID: 3742
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E9F RID: 3743
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EA0 RID: 3744
		private DockAreaEnum <<EMPTY_NAME>>;

		// Token: 0x04000EA1 RID: 3745
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EA2 RID: 3746
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EA3 RID: 3747
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EA4 RID: 3748
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EA5 RID: 3749
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EA6 RID: 3750
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EA7 RID: 3751
		private IDictionary <<EMPTY_NAME>>;

		// Token: 0x04000EA8 RID: 3752
		private IDictionary <<EMPTY_NAME>>;

		// Token: 0x04000EA9 RID: 3753
		private string <<EMPTY_NAME>>;

		// Token: 0x04000EAA RID: 3754
		internal Control <<EMPTY_NAME>>;

		// Token: 0x04000EAB RID: 3755
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000EAC RID: 3756
		internal Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x04000EAD RID: 3757
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EAE RID: 3758
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000EAF RID: 3759
		private int <<EMPTY_NAME>>;
	}
}
