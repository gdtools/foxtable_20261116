using System;
using System.Collections.Generic;
using System.ComponentModel;
using C1.Win.C1Command;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003D2 RID: 978
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OO___ : IEnumerator<TopicPage>
	{
		// Token: 0x06003FDA RID: 16346 RVA: 0x001D1B99 File Offset: 0x001CFD99
		public OO___(C1TopicPageCollection A_0)
		{
			this.Index = -1;
			this.disposedValue = false;
			this.Pages = A_0;
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x001D1BB6 File Offset: 0x001CFDB6
		public TopicPage get_Current()
		{
			return new TopicPage(this.Pages[this.Index]);
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x001D1BCE File Offset: 0x001CFDCE
		public object get_Current1()
		{
			return new TopicPage(this.Pages[this.Index]);
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x001D1BE8 File Offset: 0x001CFDE8
		public bool MoveNext()
		{
			this.Index++;
			return this.Index < this.Pages.Count;
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x001D1C1D File Offset: 0x001CFE1D
		public void Reset()
		{
			this.Index = -1;
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x001D1C26 File Offset: 0x001CFE26
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x001D1C39 File Offset: 0x001CFE39
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x040019EF RID: 6639
		private C1TopicPageCollection Pages;

		// Token: 0x040019F0 RID: 6640
		private int Index;

		// Token: 0x040019F1 RID: 6641
		private bool disposedValue;
	}
}
