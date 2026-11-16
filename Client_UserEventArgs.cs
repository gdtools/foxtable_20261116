using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000192 RID: 402
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Client_UserEventArgs
	{
		// Token: 0x0600131C RID: 4892 RVA: 0x00083D5E File Offset: 0x00081F5E
		public Client_UserEventArgs(IMClient A_0)
		{
			this.oO0OOO.0O. = A_0;
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x00083D6D File Offset: 0x00081F6D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMClient Client
		{
			get
			{
				return this.oO0OOO.0O.;
			}
		}

		// Token: 0x0400076B RID: 1899
		private IMClient <<EMPTY_NAME>>;
	}
}
