using System;
using System.Collections.Generic;
using System.ComponentModel;
using C1.Win.C1Command;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003CC RID: 972
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o0_0oo00_o : IEnumerator<TabPage>
	{
		// Token: 0x06003F91 RID: 16273 RVA: 0x001D12F4 File Offset: 0x001CF4F4
		public o0_0oo00_o(C1DockingTabPages A_0)
		{
			this.Index = -1;
			this.disposedValue = false;
			this.Pages = A_0;
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x001D1311 File Offset: 0x001CF511
		public TabPage get_Current()
		{
			return (TabPage)this.Pages[this.Index];
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x001D1329 File Offset: 0x001CF529
		public object get_Current1()
		{
			return (TabPage)this.Pages[this.Index];
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x001D1344 File Offset: 0x001CF544
		public bool MoveNext()
		{
			this.Index++;
			return this.Index < this.Pages.Count;
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x001D1379 File Offset: 0x001CF579
		public void Reset()
		{
			this.Index = -1;
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x001D1382 File Offset: 0x001CF582
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x001D1395 File Offset: 0x001CF595
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x040019E3 RID: 6627
		private C1DockingTabPages Pages;

		// Token: 0x040019E4 RID: 6628
		private int Index;

		// Token: 0x040019E5 RID: 6629
		private bool disposedValue;
	}
}
