using System;
using System.Collections.Generic;
using System.ComponentModel;
using C1.C1Excel;

namespace Foxtable.XLS
{
	// Token: 0x020004F2 RID: 1266
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class a : IEnumerator<Col>
	{
		// Token: 0x06005308 RID: 21256 RVA: 0x0025584C File Offset: 0x00253A4C
		public a(XLColumnCollection A_0)
		{
			this.Index = -1;
			this.disposedValue = false;
			this.Cols = A_0;
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x00255869 File Offset: 0x00253A69
		public Col get_Current()
		{
			return new Col(this.Cols[this.Index]);
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x00255881 File Offset: 0x00253A81
		public object get_Current1()
		{
			return new Col(this.Cols[this.Index]);
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x0025589C File Offset: 0x00253A9C
		public bool MoveNext()
		{
			this.Index++;
			return this.Index < this.Cols.Count;
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x002558D1 File Offset: 0x00253AD1
		public void Reset()
		{
			this.Index = -1;
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x002558DA File Offset: 0x00253ADA
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x002558ED File Offset: 0x00253AED
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0400227A RID: 8826
		private XLColumnCollection Cols;

		// Token: 0x0400227B RID: 8827
		private int Index;

		// Token: 0x0400227C RID: 8828
		private bool disposedValue;
	}
}
