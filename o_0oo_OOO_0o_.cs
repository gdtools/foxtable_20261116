using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020004E0 RID: 1248
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o_0oo_OOO_0o_ : List<Oo0__O__O_0__>
	{
		// Token: 0x060051A1 RID: 20897 RVA: 0x00245B81 File Offset: 0x00243D81
		public o_0oo_OOO_0o_(List<Oo0__O__O_0__> A_0)
		{
			this.RedoInfos = A_0;
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x00245B90 File Offset: 0x00243D90
		public void <<EMPTY_NAME>>(Oo0__O__O_0__ A_0)
		{
			base.Add(A_0);
			if (this.RedoInfos.Count > 0 && A_0 != this.RedoInfos[this.RedoInfos.Count - 1])
			{
				this.RedoInfos.Clear();
			}
			if (base.Count > 100)
			{
				base.RemoveAt(0);
			}
		}

		// Token: 0x04002196 RID: 8598
		private List<Oo0__O__O_0__> RedoInfos;
	}
}
