using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using ADOX;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000246 RID: 582
	[oO0oooo("2122")]
	public class ADOXTable
	{
		// Token: 0x06001BCD RID: 7117 RVA: 0x000C2F74 File Offset: 0x000C1174
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ADOXTable(Table A_0, bool A_1, bool A_2, string A_3)
		{
			this.oooO__O_0o_.o_. = A_0;
			this.oooO__O_0o_.o_. = A_1;
			this.O_.0_O__OOoOo. = A_2;
			try
			{
				foreach (string left in O_O0OO.O._o_.().Keys)
				{
					if (Operators.CompareString(left, A_3, true) == 0)
					{
						this.oooO__O_0o_.o_. = left;
					}
				}
			}
			finally
			{
				Dictionary<string, OleDbConnection>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		/// <summary>
		/// 重命名表
		/// </summary>
		/// <param name="newName">新的表名</param>
		// Token: 0x06001BCE RID: 7118 RVA: 0x000C2FF4 File Offset: 0x000C11F4
		public void Rename(string newName)
		{
			if (this.O_.0_O__OOoOo.)
			{
				this.oooO__O_0o_.o_..Name = "~TMPCLP" + newName;
				return;
			}
			if (!this.oooO__O_0o_.o_.)
			{
				this.oooO__O_0o_.o_..Name = newName;
				return;
			}
			new SQLCommand
			{
				ConnectionName = this.oooO__O_0o_.o_.,
				CommandText = string.Concat(new string[]
				{
					"exec sp_rename '",
					this.oooO__O_0o_.o_..Name,
					"','",
					newName,
					"'"
				})
			}.ExecuteNonQuery();
		}

		/// <summary>
		/// 增加列
		/// </summary>
		/// <param name="Name">列名</param>
		/// <param name="DataType">列类型</param>
		/// <param name="Length">用于设置字符列的最大长度</param>
		// Token: 0x06001BCF RID: 7119 RVA: 0x000C308C File Offset: 0x000C128C
		public void AddColumn(string Name, ADOXType DataType, int Length = 16)
		{
			if (o_O_o_oOoo__.OO_.O.(Name))
			{
				DataTypeEnum type = this.ConertType(DataType);
				Column column = new ColumnClass();
				column.Name = Name;
				column.Type = type;
				if (DataType == ADOXType.String)
				{
					column.DefinedSize = Length;
				}
				if (DataType != ADOXType.Boolean || this.oooO__O_0o_.o_.)
				{
					column.Attributes = ColumnAttributesEnum.adColNullable;
				}
				if (column.Type == DataTypeEnum.adNumeric)
				{
					column.Precision = 28;
					column.NumericScale = 14;
				}
				this.oooO__O_0o_.o_..Columns.Append(column, DataTypeEnum.adVarWChar, 0);
			}
		}

		/// <summary>
		/// 重命名列
		/// </summary>
		/// <param name="OldName">原列名</param>
		/// <param name="NewName">新列名</param>
		// Token: 0x06001BD0 RID: 7120 RVA: 0x000C3110 File Offset: 0x000C1310
		public void RenameColumn(string OldName, string NewName)
		{
			if (!this.oooO__O_0o_.o_.)
			{
				this.oooO__O_0o_.o_..Columns[OldName].Name = NewName;
				return;
			}
			new SQLCommand
			{
				ConnectionName = this.oooO__O_0o_.o_.,
				CommandText = string.Concat(new string[]
				{
					"exec sp_rename '",
					this.oooO__O_0o_.o_..Name,
					".",
					OldName,
					"','",
					NewName,
					"','column'"
				})
			}.ExecuteNonQuery();
		}

		/// <summary>
		/// 删除列
		/// </summary>
		/// <param name="Name">列名</param>
		// Token: 0x06001BD1 RID: 7121 RVA: 0x000C319D File Offset: 0x000C139D
		public void DeleteColumn(string Name)
		{
			this.oooO__O_0o_.o_..Columns.Delete(Name);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000C31B0 File Offset: 0x000C13B0
		private DataTypeEnum ConertType(ADOXType DataType)
		{
			DataTypeEnum result;
			switch (DataType)
			{
			case ADOXType.String:
				result = DataTypeEnum.adVarWChar;
				break;
			case ADOXType.DateTime:
				if (this.oooO__O_0o_.o_.)
				{
					result = DataTypeEnum.adDBTimeStamp;
				}
				else
				{
					result = DataTypeEnum.adDate;
				}
				break;
			case ADOXType.Boolean:
				result = DataTypeEnum.adBoolean;
				break;
			case ADOXType.Text:
				result = DataTypeEnum.adLongVarWChar;
				break;
			case ADOXType.Integer:
				result = DataTypeEnum.adInteger;
				break;
			case ADOXType.Long:
				result = DataTypeEnum.adBigInt;
				break;
			case ADOXType.Short:
				result = DataTypeEnum.adSmallInt;
				break;
			case ADOXType.Byte:
				result = DataTypeEnum.adUnsignedTinyInt;
				break;
			case ADOXType.Double:
				result = DataTypeEnum.adDouble;
				break;
			case ADOXType.Single:
				result = DataTypeEnum.adSingle;
				break;
			case ADOXType.Decimal:
				result = DataTypeEnum.adNumeric;
				break;
			}
			return result;
		}

		// Token: 0x04000BB4 RID: 2996
		internal Table <<EMPTY_NAME>>;

		// Token: 0x04000BB5 RID: 2997
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000BB6 RID: 2998
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000BB7 RID: 2999
		private string <<EMPTY_NAME>>;
	}
}
