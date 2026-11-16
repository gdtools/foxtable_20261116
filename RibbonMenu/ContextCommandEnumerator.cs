using System;
using System.Collections;
using System.ComponentModel;

namespace Foxtable.RibbonMenu
{
	// Token: 0x0200002A RID: 42
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ContextCommandEnumerator : IEnumerator
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00003CD2 File Offset: 0x00001ED2
		public ContextCommandEnumerator(ContextCommandCollection A_0)
		{
			this.o_o_0oO_.o_o. = -1;
			this.o_o_0oO_.o_o. = A_0;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00003CE8 File Offset: 0x00001EE8
		public object Current
		{
			get
			{
				return this.o_o_0oO_.o_o.[this.o_o_0oO_.o_o.];
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00003CFC File Offset: 0x00001EFC
		public bool MoveNext()
		{
			this.o_o_0oO_.o_o.++;
			return this.o_o_0oO_.o_o. < this.o_o_0oO_.o_o..Count;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00003D31 File Offset: 0x00001F31
		public void Reset()
		{
			this.o_o_0oO_.o_o. = -1;
		}

		// Token: 0x04000045 RID: 69
		private ContextCommandCollection <<EMPTY_NAME>>;

		// Token: 0x04000046 RID: 70
		private int <<EMPTY_NAME>>;
	}
}
