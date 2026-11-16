using System;
using System.Collections.Generic;
using System.ComponentModel;
using C1.C1Excel;

namespace Foxtable.XLS
{
	// Token: 0x020004FF RID: 1279
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class b : IEnumerator<Sheet>
	{
		// Token: 0x06005395 RID: 21397 RVA: 0x0025641D File Offset: 0x0025461D
		public b(XLSheetCollection A_0)
		{
			this.Ooo_O__.0. = -1;
			this.Ooo_O__.0. = false;
			this.Ooo_O__.0. = A_0;
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x0025643A File Offset: 0x0025463A
		public Sheet get_Current()
		{
			return new Sheet(this.Ooo_O__.0.[this.Ooo_O__.0.]);
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x00256452 File Offset: 0x00254652
		public object get_Current1()
		{
			return new Sheet(this.Ooo_O__.0.[this.Ooo_O__.0.]);
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x0025646C File Offset: 0x0025466C
		public bool MoveNext()
		{
			this.Ooo_O__.0.++;
			return this.Ooo_O__.0. < this.Ooo_O__.0..Count;
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x002564A1 File Offset: 0x002546A1
		public void Reset()
		{
			this.Ooo_O__.0. = -1;
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x002564AA File Offset: 0x002546AA
		protected virtual void Dispose(bool disposing)
		{
			if (!this.Ooo_O__.0.)
			{
			}
			this.Ooo_O__.0. = true;
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x002564BD File Offset: 0x002546BD
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x040022A5 RID: 8869
		private XLSheetCollection <<EMPTY_NAME>>;

		// Token: 0x040022A6 RID: 8870
		private int <<EMPTY_NAME>>;

		// Token: 0x040022A7 RID: 8871
		private bool <<EMPTY_NAME>>;
	}
}
