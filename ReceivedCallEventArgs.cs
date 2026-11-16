using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000254 RID: 596
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ReceivedCallEventArgs
	{
		// Token: 0x06001C5F RID: 7263 RVA: 0x000C4BC9 File Offset: 0x000C2DC9
		public ReceivedCallEventArgs(string A_0)
		{
			this.O_._0o00_. = A_0;
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x000C4BD8 File Offset: 0x000C2DD8
		public string FromNumber
		{
			get
			{
				return this.O_._0o00_.;
			}
		}

		// Token: 0x04000C06 RID: 3078
		private string <<EMPTY_NAME>>;
	}
}
