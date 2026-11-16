using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000191 RID: 401
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Client_ChangeUserPasswordEventArgs
	{
		// Token: 0x0600131A RID: 4890 RVA: 0x00083D47 File Offset: 0x00081F47
		public Client_ChangeUserPasswordEventArgs(IMClient A_0)
		{
			this.O_o.O0. = A_0;
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x00083D56 File Offset: 0x00081F56
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMClient Client
		{
			get
			{
				return this.O_o.O0.;
			}
		}

		// Token: 0x0400076A RID: 1898
		private IMClient <<EMPTY_NAME>>;
	}
}
