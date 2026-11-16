using System;
using System.Collections.Generic;
using System.ComponentModel;
using C1.Win.C1Command;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003CF RID: 975
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OoOoOO0O_O_o : IEnumerator<TopicLink>
	{
		// Token: 0x06003FB5 RID: 16309 RVA: 0x001D1750 File Offset: 0x001CF950
		public OoOoOO0O_O_o(C1TopicLinkCollection A_0)
		{
			this.Index = -1;
			this.disposedValue = false;
			this.Links = A_0;
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x001D176D File Offset: 0x001CF96D
		public TopicLink get_Current()
		{
			return new TopicLink(this.Links[this.Index]);
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x001D1785 File Offset: 0x001CF985
		public object get_Current1()
		{
			return new TopicLink(this.Links[this.Index]);
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x001D17A0 File Offset: 0x001CF9A0
		public bool MoveNext()
		{
			this.Index++;
			return this.Index < this.Links.Count;
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x001D17D5 File Offset: 0x001CF9D5
		public void Reset()
		{
			this.Index = -1;
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x001D17DE File Offset: 0x001CF9DE
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x001D17F1 File Offset: 0x001CF9F1
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x040019E8 RID: 6632
		private C1TopicLinkCollection Links;

		// Token: 0x040019E9 RID: 6633
		private int Index;

		// Token: 0x040019EA RID: 6634
		private bool disposedValue;
	}
}
