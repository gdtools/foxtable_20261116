using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020001BC RID: 444
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Client_BuddyLoginEventArgs
	{
		// Token: 0x060015A8 RID: 5544 RVA: 0x0009928D File Offset: 0x0009748D
		internal Client_BuddyLoginEventArgs(string A_0, IMClient A_1)
		{
			this.oOo___._0___0_. = A_0;
			this.oOo___._0___0_. = A_1;
		}

		/// <summary>
		/// 上线好友名称
		/// </summary>
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x000992A3 File Offset: 0x000974A3
		public string BuddyName
		{
			get
			{
				return this.oOo___._0___0_.;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x000992AB File Offset: 0x000974AB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMClient Client
		{
			get
			{
				return this.oOo___._0___0_.;
			}
		}

		// Token: 0x04000872 RID: 2162
		private string <<EMPTY_NAME>>;

		// Token: 0x04000873 RID: 2163
		private IMClient <<EMPTY_NAME>>;
	}
}
