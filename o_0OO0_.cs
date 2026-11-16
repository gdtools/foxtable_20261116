using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000285 RID: 645
	internal class o_0OO0_
	{
		// Token: 0x06002055 RID: 8277 RVA: 0x000E0A7D File Offset: 0x000DEC7D
		internal o_0OO0_(DataRow A_0)
		{
			this.O_o0.Oo00o0. = A_0;
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x000E0A8C File Offset: 0x000DEC8C
		// (set) Token: 0x06002057 RID: 8279 RVA: 0x000E0AA4 File Offset: 0x000DECA4
		internal string Name
		{
			get
			{
				return Conversions.ToString(this.O_o0.Oo00o0.["ColumnName"]);
			}
			set
			{
				value = value.Replace("＿", "_");
				if (o_O_o_oOoo__.OO_.O.(value))
				{
					foreach (DataRow dataRow in this.O_o0.Oo00o0..Table.Select("TableName = '" + Conversions.ToString(this.O_o0.Oo00o0.["TableName"]) + "'"))
					{
						if (dataRow != this.O_o0.Oo00o0. && Operators.CompareString(Conversions.ToString(this.O_o0.Oo00o0.["ColumnName"]), Conversions.ToString(dataRow["ColumnName"]), true) == 0)
						{
							MessageBox.Show("列[" + value + "]已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return;
						}
					}
					this.O_o0.Oo00o0.["ColumnName"] = value;
				}
			}
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x000E0B7C File Offset: 0x000DED7C
		internal string <<EMPTY_NAME>>()
		{
			string result;
			if (this.O_o0.Oo00o0..IsNull("Caption"))
			{
				result = "";
			}
			else
			{
				result = Conversions.ToString(this.O_o0.Oo00o0.["Caption"]);
			}
			return result;
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000E0BBA File Offset: 0x000DEDBA
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.O_o0.Oo00o0.["Caption"] = A_0;
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x000E0BCD File Offset: 0x000DEDCD
		internal int <<EMPTY_NAME>>()
		{
			return Conversions.ToInteger(this.O_o0.Oo00o0.["MaxLength"]);
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x000E0BE4 File Offset: 0x000DEDE4
		internal void <<EMPTY_NAME>>(int A_0)
		{
			if (o_0OO0_.O_o0.Oo00o0.(A_0))
			{
				this.O_o0.Oo00o0.["Maxlength"] = A_0;
			}
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x000E0C04 File Offset: 0x000DEE04
		internal ColumnDataTypeEnum <<EMPTY_NAME>>()
		{
			return (ColumnDataTypeEnum)Conversions.ToInteger(this.O_o0.Oo00o0.["DataType"]);
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x000E0C1B File Offset: 0x000DEE1B
		internal void <<EMPTY_NAME>>(ColumnDataTypeEnum A_0)
		{
			this.O_o0.Oo00o0.["DataType"] = A_0;
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000E0C34 File Offset: 0x000DEE34
		internal static bool <<EMPTY_NAME>>(int A_0)
		{
			bool result;
			if (A_0 > 255)
			{
				MessageBox.Show("字符列长度不能超过255！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else if (A_0 < 1)
			{
				MessageBox.Show("字符列长度不能小于1！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x04000D95 RID: 3477
		private DataRow <<EMPTY_NAME>>;
	}
}
