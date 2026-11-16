using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020004CF RID: 1231
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class DataReceivedEventArgs
	{
		// Token: 0x0600515E RID: 20830 RVA: 0x00244669 File Offset: 0x00242869
		public DataReceivedEventArgs(Port A_0)
		{
			this.oo._Oo0. = A_0;
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x0600515F RID: 20831 RVA: 0x00244678 File Offset: 0x00242878
		public Port Port
		{
			get
			{
				return this.oo._Oo0.;
			}
		}

		// Token: 0x04002172 RID: 8562
		private Port <<EMPTY_NAME>>;
	}
}
