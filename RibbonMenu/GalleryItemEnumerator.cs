using System;
using System.Collections;
using System.ComponentModel;

namespace Foxtable.RibbonMenu
{
	// Token: 0x0200002D RID: 45
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class GalleryItemEnumerator : IEnumerator
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00003F96 File Offset: 0x00002196
		public GalleryItemEnumerator(GalleryItemCollection A_0)
		{
			this.OO0oOo.O_o0. = -1;
			this.OO0oOo.O_o0. = A_0;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00003FAC File Offset: 0x000021AC
		public object Current
		{
			get
			{
				return this.OO0oOo.O_o0.[this.OO0oOo.O_o0.];
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00003FC0 File Offset: 0x000021C0
		public bool MoveNext()
		{
			this.OO0oOo.O_o0.++;
			return this.OO0oOo.O_o0. < this.OO0oOo.O_o0..Count;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00003FF5 File Offset: 0x000021F5
		public void Reset()
		{
			this.OO0oOo.O_o0. = -1;
		}

		// Token: 0x0400004A RID: 74
		private GalleryItemCollection <<EMPTY_NAME>>;

		// Token: 0x0400004B RID: 75
		private int <<EMPTY_NAME>>;
	}
}
