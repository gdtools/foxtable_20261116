using System;
using System.Runtime.InteropServices;

namespace Foxtable
{
	/// <summary>
	/// 外部表生成器
	/// </summary>
	// Token: 0x0200029B RID: 667
	[ComVisible(true)]
	[oO0oooo("1279")]
	public class OuterTableBuilder : QueryBuilder
	{
		// Token: 0x060021D0 RID: 8656 RVA: 0x000F0AA1 File Offset: 0x000EECA1
		public OuterTableBuilder()
		{
			base.IsDataTable = true;
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x000F0AB0 File Offset: 0x000EECB0
		public OuterTableBuilder(string A_0)
		{
			base.TableName = A_0;
			base.IsDataTable = true;
		}
	}
}
