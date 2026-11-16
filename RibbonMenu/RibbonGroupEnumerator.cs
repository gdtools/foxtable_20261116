using System;
using System.Collections;
using System.ComponentModel;

namespace Foxtable.RibbonMenu
{
	// Token: 0x02000030 RID: 48
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonGroupEnumerator : IEnumerator
	{
		// Token: 0x06000180 RID: 384 RVA: 0x000046F9 File Offset: 0x000028F9
		public RibbonGroupEnumerator(RibbonGroupCollection A_0)
		{
			this.oOo_.0o_O_O_0. = -1;
			this.oOo_.0o_O_O_0. = A_0;
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000470F File Offset: 0x0000290F
		public object Current
		{
			get
			{
				return this.oOo_.0o_O_O_0.[this.oOo_.0o_O_O_0.];
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00004724 File Offset: 0x00002924
		public bool MoveNext()
		{
			this.oOo_.0o_O_O_0.++;
			return this.oOo_.0o_O_O_0. < this.oOo_.0o_O_O_0..Count;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00004759 File Offset: 0x00002959
		public void Reset()
		{
			this.oOo_.0o_O_O_0. = -1;
		}

		// Token: 0x0400004F RID: 79
		private RibbonGroupCollection <<EMPTY_NAME>>;

		// Token: 0x04000050 RID: 80
		private int <<EMPTY_NAME>>;
	}
}
