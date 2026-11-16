using System;
using System.Collections;
using System.ComponentModel;

namespace Foxtable.RibbonMenu
{
	// Token: 0x02000032 RID: 50
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonTabEnumerator : IEnumerator
	{
		// Token: 0x06000191 RID: 401 RVA: 0x000048CB File Offset: 0x00002ACB
		public RibbonTabEnumerator(RibbonTabCollection A_0)
		{
			this.O_00Oo_.0. = -1;
			this.O_00Oo_.0. = A_0;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000048E1 File Offset: 0x00002AE1
		public object Current
		{
			get
			{
				return this.O_00Oo_.0.[this.O_00Oo_.0.];
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000048F4 File Offset: 0x00002AF4
		public bool MoveNext()
		{
			this.O_00Oo_.0.++;
			return this.O_00Oo_.0. < this.O_00Oo_.0..Count;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00004929 File Offset: 0x00002B29
		public void Reset()
		{
			this.O_00Oo_.0. = -1;
		}

		// Token: 0x04000052 RID: 82
		private RibbonTabCollection <<EMPTY_NAME>>;

		// Token: 0x04000053 RID: 83
		private int <<EMPTY_NAME>>;
	}
}
