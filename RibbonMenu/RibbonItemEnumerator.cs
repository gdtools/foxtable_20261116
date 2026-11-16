using System;
using System.Collections;
using System.ComponentModel;

namespace Foxtable.RibbonMenu
{
	// Token: 0x0200002C RID: 44
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonItemEnumerator : IEnumerator
	{
		// Token: 0x0600015C RID: 348 RVA: 0x00003F2E File Offset: 0x0000212E
		public RibbonItemEnumerator(RibbonItemCollection A_0)
		{
			this.oOo_.0o_O_O_0. = -1;
			this.O_00Oo_.0. = A_0;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00003F44 File Offset: 0x00002144
		public object Current
		{
			get
			{
				return this.O_00Oo_.0.[this.oOo_.0o_O_O_0.];
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00003F58 File Offset: 0x00002158
		public bool MoveNext()
		{
			this.oOo_.0o_O_O_0.++;
			return this.oOo_.0o_O_O_0. < this.O_00Oo_.0..Count;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00003F8D File Offset: 0x0000218D
		public void Reset()
		{
			this.oOo_.0o_O_O_0. = -1;
		}

		// Token: 0x04000048 RID: 72
		private RibbonItemCollection <<EMPTY_NAME>>;

		// Token: 0x04000049 RID: 73
		private int <<EMPTY_NAME>>;
	}
}
