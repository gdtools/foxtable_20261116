using System;
using System.ComponentModel;
using Foxtable.XLS;

namespace Foxtable
{
	// Token: 0x020002F6 RID: 758
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class DetailEventArgs : BuildEventArgs
	{
		// Token: 0x06002964 RID: 10596 RVA: 0x0012AA1B File Offset: 0x00128C1B
		public DetailEventArgs(Book A_0, string A_1, DataRow A_2) : base(A_0)
		{
			this.OO_.0o_0. = A_1;
			this.OO_.0o_0. = A_2;
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002965 RID: 10597 RVA: 0x0012AA32 File Offset: 0x00128C32
		public DataRow DataRow
		{
			get
			{
				return this.OO_.0o_0.;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x0012AA3A File Offset: 0x00128C3A
		public string Region
		{
			get
			{
				return this.OO_.0o_0.;
			}
		}

		// Token: 0x04001117 RID: 4375
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04001118 RID: 4376
		private string <<EMPTY_NAME>>;
	}
}
