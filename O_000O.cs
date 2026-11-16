using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020004DE RID: 1246
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O_000O : Oo0__O__O_0__
	{
		// Token: 0x06005199 RID: 20889 RVA: 0x002458D9 File Offset: 0x00243AD9
		public O_000O(DataTable A_0)
		{
			this.DataTable = A_0;
			this.AllowEdit = A_0.AllowEdit;
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x002458F4 File Offset: 0x00243AF4
		public void <<EMPTY_NAME>>()
		{
			this.o00.oo0__00.();
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x002458FC File Offset: 0x00243AFC
		public void <<EMPTY_NAME>>()
		{
			bool allowEdit = this.DataTable.AllowEdit;
			this.DataTable.AllowEdit = this.AllowEdit;
			this.AllowEdit = allowEdit;
		}

		// Token: 0x04002191 RID: 8593
		private DataTable DataTable;

		// Token: 0x04002192 RID: 8594
		private bool AllowEdit;
	}
}
