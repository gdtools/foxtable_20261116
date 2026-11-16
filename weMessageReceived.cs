using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000196 RID: 406
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class weMessageReceived
	{
		// Token: 0x06001332 RID: 4914 RVA: 0x00083EF4 File Offset: 0x000820F4
		public weMessageReceived(IMClient A_0, string A_1, int A_2, string A_3)
		{
			this.Oo0_0.o. = A_0;
			this.o.O___oOOOOoo. = A_1;
			this.o.O___oOOOOoo. = A_2;
			this.o0_O0_o_o0O._o. = A_3;
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x00083F19 File Offset: 0x00082119
		public IMClient Client
		{
			get
			{
				return this.Oo0_0.o.;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x00083F21 File Offset: 0x00082121
		public string WeChatID
		{
			get
			{
				return this.o.O___oOOOOoo.;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x00083F29 File Offset: 0x00082129
		public int ContentType
		{
			get
			{
				return this.o.O___oOOOOoo.;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x00083F31 File Offset: 0x00082131
		public string Content
		{
			get
			{
				return this.o0_O0_o_o0O._o.;
			}
		}

		// Token: 0x0400077A RID: 1914
		private IMClient <<EMPTY_NAME>>;

		// Token: 0x0400077B RID: 1915
		private string <<EMPTY_NAME>>;

		// Token: 0x0400077C RID: 1916
		private int <<EMPTY_NAME>>;

		// Token: 0x0400077D RID: 1917
		private string <<EMPTY_NAME>>;
	}
}
