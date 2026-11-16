using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000289 RID: 649
	[DefaultMember("Items")]
	internal class oOo_ : IEnumerable<O_0O_>
	{
		// Token: 0x06002076 RID: 8310 RVA: 0x000E114F File Offset: 0x000DF34F
		internal oOo_(o_oo0 A_0)
		{
			this.O.0_O. = A_0;
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x000E1160 File Offset: 0x000DF360
		internal O_0O_ <<EMPTY_NAME>>(string A_0)
		{
			foreach (DataRow dataRow in this.O.0_O..oo__._..Select("", "", DataViewRowState.CurrentRows))
			{
				if (Operators.CompareString(A_0, Conversions.ToString(dataRow["TableName"]), true) == 0)
				{
					return new O_0O_(dataRow);
				}
			}
			MessageBox.Show("表[" + A_0 + "]不存在，或者已经被删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return null;
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x000E11E0 File Offset: 0x000DF3E0
		internal O_0O_ <<EMPTY_NAME>>(int A_0)
		{
			int num = 0;
			foreach (DataRow a_ in this.O.0_O..oo__._..Select("", "", DataViewRowState.CurrentRows))
			{
				if (num == A_0)
				{
					return new O_0O_(a_);
				}
				num++;
			}
			MessageBox.Show("表索引超出范围！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return null;
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x000E1248 File Offset: 0x000DF448
		internal void <<EMPTY_NAME>>(string A_0)
		{
			if (!this.oooO__O_0o_.o_.(A_0))
			{
				MessageBox.Show("表[" + A_0 + "]不存在，或者已经被删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			foreach (DataRow dataRow in this.O.0_O..oo__._..Select("", "", DataViewRowState.CurrentRows))
			{
				if (Operators.CompareString(A_0, Conversions.ToString(dataRow["TableName"]), true) == 0)
				{
					dataRow.Delete();
					return;
				}
			}
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x000E12CC File Offset: 0x000DF4CC
		internal O_0O_ <<EMPTY_NAME>>(string A_0)
		{
			O_0O_ result;
			if (this.oooO__O_0o_.o_.(A_0))
			{
				MessageBox.Show("表[" + A_0 + "]已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = null;
			}
			else if (!o_O_o_oOoo__.O_o_._o0.(A_0))
			{
				result = null;
			}
			else
			{
				DataRow dataRow = this.O.0_O..oo__._..NewRow();
				dataRow["TableName"] = A_0;
				this.O.0_O..oo__._..Rows.Add(dataRow);
				result = new O_0O_(dataRow);
			}
			return result;
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x000E134B File Offset: 0x000DF54B
		internal int <<EMPTY_NAME>>()
		{
			return this.O.0_O..oo__._..Select("", "", DataViewRowState.CurrentRows).Length;
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x000E136C File Offset: 0x000DF56C
		internal bool <<EMPTY_NAME>>(string A_0)
		{
			DataRow[] array = this.O.0_O..oo__._..Select("", "", DataViewRowState.CurrentRows);
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (Operators.CompareString(Conversions.ToString(array[i]["TableName"]), A_0, true) == 0)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x000E13C6 File Offset: 0x000DF5C6
		internal IEnumerator <<EMPTY_NAME>>()
		{
			return new o_OO_OOO_(this);
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x000E13CE File Offset: 0x000DF5CE
		internal IEnumerator<O_0O_> <<EMPTY_NAME>>()
		{
			return new o_OO_OOO_(this);
		}

		// Token: 0x04000D9C RID: 3484
		private o_oo0 <<EMPTY_NAME>>;
	}
}
