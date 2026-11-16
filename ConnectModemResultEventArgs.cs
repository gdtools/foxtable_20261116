using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x0200024F RID: 591
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ConnectModemResultEventArgs
	{
		// Token: 0x06001C46 RID: 7238 RVA: 0x000C4A44 File Offset: 0x000C2C44
		public ConnectModemResultEventArgs(bool A_0)
		{
			this.Oo___.ooooO00. = A_0;
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x000C4A53 File Offset: 0x000C2C53
		public bool Succeed
		{
			get
			{
				return this.Oo___.ooooO00.;
			}
		}

		// Token: 0x04000BF9 RID: 3065
		private bool <<EMPTY_NAME>>;
	}
}
