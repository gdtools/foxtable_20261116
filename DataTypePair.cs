using System;
using System.Collections.Generic;

namespace Foxtable
{
	// Token: 0x020002AE RID: 686
	internal class DataTypePair
	{
		// Token: 0x060024D3 RID: 9427 RVA: 0x0010D0B0 File Offset: 0x0010B2B0
		public DataTypePair(string A_0, ColumnDataTypeEnum A_1)
		{
			this.Oo_00_oO.00O0O. = A_0;
			this.Oo_00_oO.00O0O. = A_1;
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x0010D0C6 File Offset: 0x0010B2C6
		public string DisplayName
		{
			get
			{
				return this.Oo_00_oO.00O0O.;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x060024D5 RID: 9429 RVA: 0x0010D0CE File Offset: 0x0010B2CE
		public ColumnDataTypeEnum DataType
		{
			get
			{
				return this.Oo_00_oO.00O0O.;
			}
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x0010D0D8 File Offset: 0x0010B2D8
		public static List<DataTypePair> CreateDataTypePairs(bool IsADOX)
		{
			List<DataTypePair> list = new List<DataTypePair>();
			list.Add(new DataTypePair("字符", ColumnDataTypeEnum.String));
			list.Add(new DataTypePair("日期时间", ColumnDataTypeEnum.DateTime));
			list.Add(new DataTypePair("逻辑", ColumnDataTypeEnum.Boolean));
			list.Add(new DataTypePair("整数", ColumnDataTypeEnum.Integer));
			if (!IsADOX)
			{
				list.Add(new DataTypePair("长整数", ColumnDataTypeEnum.Long));
			}
			list.Add(new DataTypePair("短整数", ColumnDataTypeEnum.Short));
			list.Add(new DataTypePair("微整数", ColumnDataTypeEnum.Byte));
			list.Add(new DataTypePair("双精度小数", ColumnDataTypeEnum.Double));
			list.Add(new DataTypePair("单精度小数", ColumnDataTypeEnum.Single));
			list.Add(new DataTypePair("高精度小数", ColumnDataTypeEnum.Decimal));
			list.Add(new DataTypePair("备注", ColumnDataTypeEnum.Text));
			return list;
		}

		// Token: 0x04000F2F RID: 3887
		private string <<EMPTY_NAME>>;

		// Token: 0x04000F30 RID: 3888
		private ColumnDataTypeEnum <<EMPTY_NAME>>;
	}
}
