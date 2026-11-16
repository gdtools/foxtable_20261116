using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x0200009F RID: 159
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class MRPExtendTables : IEnumerable<o00_0__O>
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x0002FE47 File Offset: 0x0002E047
		public MRPExtendTables()
		{
			this.oOO.0_O0. = new Collection<o00_0__O>();
		}

		/// <summary>
		/// 附加数据列
		/// </summary>
		/// <param name="DataTable">附加列所在数据表</param>
		/// <param name="MaterialCol">物料列名称 ，也就是关联列，DataTable参数指定的数据表通过此列和BOM表的物料列建立关联</param>
		/// <param name="QuantityCol">附加列名称</param>
		/// <param name="NewName">出现在MRP中的新列名 </param>
		// Token: 0x0600064A RID: 1610 RVA: 0x0002FE5A File Offset: 0x0002E05A
		public void Add(DataTable DataTable, string MaterialCol, string QuantityCol, string NewName)
		{
			this.oOO.0_O0..Add(new o00_0__O(DataTable, MaterialCol, QuantityCol, NewName));
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0002FE71 File Offset: 0x0002E071
		public int Count
		{
			get
			{
				return this.oOO.0_O0..Count;
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0002FE7E File Offset: 0x0002E07E
		public void Clear()
		{
			this.oOO.0_O0..Clear();
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0002FE8B File Offset: 0x0002E08B
		public IEnumerator<o00_0__O> GetEnumerator()
		{
			return this.oOO.0_O0..GetEnumerator();
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0002FE98 File Offset: 0x0002E098
		IEnumerator IEnumerable.<<EMPTY_NAME>>()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040001A9 RID: 425
		private Collection<o00_0__O> <<EMPTY_NAME>>;
	}
}
