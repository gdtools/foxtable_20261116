using System;
using System.Collections;
using System.ComponentModel;

namespace Foxtable.RibbonMenu
{
	// Token: 0x02000025 RID: 37
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ContextMenuEnumerator : IEnumerator
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00003972 File Offset: 0x00001B72
		public ContextMenuEnumerator(ContextMenuCollection A_0)
		{
			this.o_.o0_o. = -1;
			this.o_.o0_o. = A_0;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00003988 File Offset: 0x00001B88
		public object Current
		{
			get
			{
				return this.o_.o0_o.[this.o_.o0_o.];
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000399C File Offset: 0x00001B9C
		public bool MoveNext()
		{
			this.o_.o0_o.++;
			return this.o_.o0_o. < this.o_.o0_o..Count;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000039D1 File Offset: 0x00001BD1
		public void Reset()
		{
			this.o_.o0_o. = -1;
		}

		// Token: 0x0400003C RID: 60
		private ContextMenuCollection <<EMPTY_NAME>>;

		// Token: 0x0400003D RID: 61
		private int <<EMPTY_NAME>>;
	}
}
