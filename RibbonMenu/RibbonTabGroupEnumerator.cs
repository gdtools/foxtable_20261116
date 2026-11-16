using System;
using System.Collections;
using System.ComponentModel;

namespace Foxtable.RibbonMenu
{
	// Token: 0x02000036 RID: 54
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonTabGroupEnumerator : IEnumerator
	{
		// Token: 0x060001CA RID: 458 RVA: 0x00004EBC File Offset: 0x000030BC
		public RibbonTabGroupEnumerator(RibbonTabGroupCollection A_0)
		{
			this.OO0.0OOo__. = -1;
			this.OO0.0OOo__. = A_0;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00004ED2 File Offset: 0x000030D2
		public object Current
		{
			get
			{
				return this.OO0.0OOo__.[this.OO0.0OOo__.];
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00004EE8 File Offset: 0x000030E8
		public bool MoveNext()
		{
			this.OO0.0OOo__.++;
			return this.OO0.0OOo__. < this.OO0.0OOo__..Count;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00004F1D File Offset: 0x0000311D
		public void Reset()
		{
			this.OO0.0OOo__. = -1;
		}

		// Token: 0x04000058 RID: 88
		private RibbonTabGroupCollection <<EMPTY_NAME>>;

		// Token: 0x04000059 RID: 89
		private int <<EMPTY_NAME>>;
	}
}
