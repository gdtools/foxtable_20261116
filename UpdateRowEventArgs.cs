using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

namespace Foxtable
{
	// Token: 0x020000A3 RID: 163
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class UpdateRowEventArgs : DataRowEventArgs
	{
		// Token: 0x06000664 RID: 1636 RVA: 0x0002FFAB File Offset: 0x0002E1AB
		public UpdateRowEventArgs(DataTable A_0, DataRow A_1, OleDbRowUpdatedEventArgs A_2) : base(A_0, A_1)
		{
			this.O__00.__0_O. = A_2;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0002FFBC File Offset: 0x0002E1BC
		public UpdateRowEventArgs(DataTable A_0, DataRow A_1, int A_2, int A_3) : base(A_0, A_1)
		{
			this.O__00.__0_O. = A_2;
			this.oO_o_0.0. = A_3;
		}

		/// <summary>
		/// 表示数据行在保存前的状态，0表示新增行,1表示修改行,2表示删除行
		/// </summary>
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0002FFD8 File Offset: 0x0002E1D8
		public int StatementType
		{
			get
			{
				int result;
				if (this.O__00.__0_O. != null)
				{
					switch (this.O__00.__0_O..StatementType)
					{
					case System.Data.StatementType.Insert:
						result = 0;
						break;
					case System.Data.StatementType.Update:
						result = 1;
						break;
					case System.Data.StatementType.Delete:
						result = 2;
						break;
					}
				}
				else
				{
					result = this.O__00.__0_O.;
				}
				return result;
			}
		}

		/// <summary>
		/// 保存成功返回True，否则返回False
		/// </summary>
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x00030024 File Offset: 0x0002E224
		public bool Success
		{
			get
			{
				bool result;
				if (this.O__00.__0_O. != null)
				{
					result = (this.O__00.__0_O..RecordsAffected > 0);
				}
				else
				{
					result = (this.oO_o_0.0. != 0);
				}
				return result;
			}
		}

		// Token: 0x040001B3 RID: 435
		private OleDbRowUpdatedEventArgs <<EMPTY_NAME>>;

		// Token: 0x040001B4 RID: 436
		private int <<EMPTY_NAME>>;

		// Token: 0x040001B5 RID: 437
		private int <<EMPTY_NAME>>;
	}
}
