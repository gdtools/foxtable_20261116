using System;
using System.Collections.Generic;
using System.ComponentModel;
using C1.C1Excel;

namespace Foxtable.XLS
{
	// Token: 0x020004FC RID: 1276
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class c : IEnumerator<Row>
	{
		// Token: 0x06005364 RID: 21348 RVA: 0x00256076 File Offset: 0x00254276
		public c(XLRowCollection A_0)
		{
			this.Index = -1;
			this.disposedValue = false;
			this.Rows = A_0;
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x00256093 File Offset: 0x00254293
		public Row get_Current()
		{
			return new Row(this.Rows[this.Index]);
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x002560AB File Offset: 0x002542AB
		public object get_Current1()
		{
			return new Row(this.Rows[this.Index]);
		}

		// Token: 0x06005367 RID: 21351 RVA: 0x002560C4 File Offset: 0x002542C4
		public bool MoveNext()
		{
			this.Index++;
			return this.Index < this.Rows.Count;
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x002560F9 File Offset: 0x002542F9
		public void Reset()
		{
			this.Index = -1;
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x00256102 File Offset: 0x00254302
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x00256115 File Offset: 0x00254315
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0400229D RID: 8861
		private XLRowCollection Rows;

		// Token: 0x0400229E RID: 8862
		private int Index;

		// Token: 0x0400229F RID: 8863
		private bool disposedValue;
	}
}
