using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x020000A5 RID: 165
	[ComVisible(true)]
	public class SubtotalGroupCollection : IEnumerable<SubtotalGroup>
	{
		// Token: 0x06000670 RID: 1648 RVA: 0x000300E9 File Offset: 0x0002E2E9
		public SubtotalGroupCollection()
		{
			this.oO0O_0.ooo00. = new List<SubtotalGroup>();
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x000300FC File Offset: 0x0002E2FC
		public void Add(SubtotalGroup item)
		{
			this.oO0O_0.ooo00..Add(item);
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0003010A File Offset: 0x0002E30A
		public int Count
		{
			get
			{
				return this.oO0O_0.ooo00..Count;
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00030117 File Offset: 0x0002E317
		public void Clear()
		{
			this.oO0O_0.ooo00..Clear();
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00030124 File Offset: 0x0002E324
		public IEnumerator<SubtotalGroup> GetEnumerator()
		{
			return (IEnumerator<SubtotalGroup>)this.oO0O_0.ooo00..GetEnumerator();
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0003013B File Offset: 0x0002E33B
		IEnumerator IEnumerable.IEnumerable_GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x17000173 RID: 371
		public SubtotalGroup this[int A_0]
		{
			get
			{
				return this.oO0O_0.ooo00.[A_0];
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00030151 File Offset: 0x0002E351
		public void AddRange(IEnumerable<SubtotalGroup> items)
		{
			this.oO0O_0.ooo00..AddRange(items);
		}

		// Token: 0x040001BA RID: 442
		private List<SubtotalGroup> <<EMPTY_NAME>>;
	}
}
