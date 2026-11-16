using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000286 RID: 646
	[DefaultMember("Item")]
	internal class OOOO : IEnumerable<o_0OO0_>
	{
		// Token: 0x0600205F RID: 8287 RVA: 0x000E0C7E File Offset: 0x000DEE7E
		internal OOOO(DataRow A_0)
		{
			this.OO00o__OOO.o0_. = A_0;
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x000E0C90 File Offset: 0x000DEE90
		internal o_0OO0_ <<EMPTY_NAME>>(string A_0)
		{
			foreach (DataRow dataRow in this.OO00o__OOO.o0_..GetChildRows("Re1", DataRowVersion.Current))
			{
				if (Operators.CompareString(Conversions.ToString(dataRow["ColumnName"]), A_0, true) == 0)
				{
					return new o_0OO0_(dataRow);
				}
			}
			MessageBox.Show("列[" + A_0 + "]不存在，或者已经被删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return null;
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000E0D08 File Offset: 0x000DEF08
		internal o_0OO0_ <<EMPTY_NAME>>(int A_0)
		{
			DataRow[] childRows = this.OO00o__OOO.o0_..GetChildRows("Re1", DataRowVersion.Current);
			o_0OO0_ result;
			if (childRows.Length > A_0 && A_0 >= 0)
			{
				result = new o_0OO0_(childRows[A_0]);
			}
			else
			{
				MessageBox.Show("列索引超出范围！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = null;
			}
			return result;
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000E0D56 File Offset: 0x000DEF56
		internal int <<EMPTY_NAME>>()
		{
			return this.OO00o__OOO.o0_..GetChildRows("Re1", DataRowVersion.Current).Length;
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000E0D70 File Offset: 0x000DEF70
		internal bool <<EMPTY_NAME>>(string A_0)
		{
			checked
			{
				bool result;
				if (o_O_o_oOoo__.oO.O_..Contains(A_0))
				{
					result = false;
				}
				else
				{
					DataRow[] childRows = this.OO00o__OOO.o0_..GetChildRows("Re1", DataRowVersion.Current);
					for (int i = 0; i < childRows.Length; i++)
					{
						if (Operators.CompareString(Conversions.ToString(childRows[i]["ColumnName"]), A_0, true) == 0)
						{
							return true;
						}
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000E0DD4 File Offset: 0x000DEFD4
		internal o_0OO0_ <<EMPTY_NAME>>(string A_0, ColumnDataTypeEnum A_1, int A_2 = -2147483648)
		{
			o_0OO0_ result;
			if (this.O_o0.Oo00o0.(A_0))
			{
				MessageBox.Show("列[" + A_0 + "]已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = null;
			}
			else if (!o_O_o_oOoo__.OO_.O.(A_0))
			{
				result = null;
			}
			else if (A_2 != -2147483648 && !o_0OO0_.O_o0.Oo00o0.(A_2))
			{
				result = null;
			}
			else
			{
				DataRow dataRow = this.OO00o__OOO.o0_..Table.DataSet.Tables["tblColumns"].NewRow();
				dataRow["TableName"] = RuntimeHelpers.GetObjectValue(this.OO00o__OOO.o0_.["TableName"]);
				dataRow["ColumnName"] = A_0;
				dataRow["DataType"] = A_1;
				if (A_2 != -2147483648)
				{
					dataRow["MaxLength"] = A_2;
				}
				else
				{
					dataRow["MaxLength"] = 16;
				}
				this.OO00o__OOO.o0_..Table.DataSet.Tables["tblColumns"].Rows.Add(dataRow);
				result = new o_0OO0_(dataRow);
			}
			return result;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000E0EF8 File Offset: 0x000DF0F8
		internal void <<EMPTY_NAME>>(string A_0)
		{
			foreach (DataRow dataRow in this.OO00o__OOO.o0_..GetChildRows("Re1", DataRowVersion.Current))
			{
				if (Operators.CompareString(Conversions.ToString(dataRow["ColumnName"]), A_0, true) == 0)
				{
					dataRow.Delete();
				}
			}
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000E0F4C File Offset: 0x000DF14C
		internal void <<EMPTY_NAME>>(int A_0)
		{
			DataRow[] childRows = this.OO00o__OOO.o0_..GetChildRows("Re1", DataRowVersion.Current);
			if (childRows.Length > A_0 & A_0 >= 0)
			{
				childRows[A_0].Delete();
			}
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000E0F87 File Offset: 0x000DF187
		internal IEnumerator <<EMPTY_NAME>>()
		{
			return new oOO0_Oo0oO(this);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000E0F8F File Offset: 0x000DF18F
		internal IEnumerator<o_0OO0_> <<EMPTY_NAME>>()
		{
			return new oOO0_Oo0oO(this);
		}

		// Token: 0x04000D96 RID: 3478
		private DataRow <<EMPTY_NAME>>;
	}
}
