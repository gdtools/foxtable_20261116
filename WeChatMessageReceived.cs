using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000195 RID: 405
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class WeChatMessageReceived
	{
		// Token: 0x0600132B RID: 4907 RVA: 0x00083E74 File Offset: 0x00082074
		public WeChatMessageReceived(IMServer A_0, string A_1, string A_2, string A_3, int A_4, bool A_5)
		{
			this.Oo0_0.o. = A_0;
			this.Oo0_0.o. = A_1;
			this.o0_O0_o_o0O._o. = A_2.Trim(new char[]
			{
				'"'
			});
			this.oO0O_O0.0O. = A_3;
			this.o_0o0.0OOOo. = A_4;
			this.o_0o0.0OOOo. = A_5;
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x00083EC4 File Offset: 0x000820C4
		public string Sender
		{
			get
			{
				return this.Oo0_0.o.;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x00083ECC File Offset: 0x000820CC
		public string WeChatID
		{
			get
			{
				return this.o0_O0_o_o0O._o.;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00083ED4 File Offset: 0x000820D4
		public string Content
		{
			get
			{
				return this.oO0O_O0.0O.;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x00083EDC File Offset: 0x000820DC
		public int ContentType
		{
			get
			{
				return this.o_0o0.0OOOo.;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x00083EE4 File Offset: 0x000820E4
		public IMServer Server
		{
			get
			{
				return this.Oo0_0.o.;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x00083EEC File Offset: 0x000820EC
		public bool Buildin
		{
			get
			{
				return this.o_0o0.0OOOo.;
			}
		}

		// Token: 0x04000774 RID: 1908
		private IMServer <<EMPTY_NAME>>;

		// Token: 0x04000775 RID: 1909
		private string <<EMPTY_NAME>>;

		// Token: 0x04000776 RID: 1910
		private string <<EMPTY_NAME>>;

		// Token: 0x04000777 RID: 1911
		private string <<EMPTY_NAME>>;

		// Token: 0x04000778 RID: 1912
		private int <<EMPTY_NAME>>;

		// Token: 0x04000779 RID: 1913
		private bool <<EMPTY_NAME>>;
	}
}
