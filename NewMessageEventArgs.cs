using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000253 RID: 595
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class NewMessageEventArgs
	{
		// Token: 0x06001C59 RID: 7257 RVA: 0x000C4B74 File Offset: 0x000C2D74
		public NewMessageEventArgs(short A_0, short A_1, string A_2, string A_3, DateTime A_4)
		{
			this.Oo_oOO_._Oo_o. = A_0;
			this.o0o_Oo_.o. = A_1;
			this.Oo_oOO_._Oo_o. = A_2;
			this.o0o_Oo_.o. = A_3;
			this.Oo_oOO_._Oo_o. = A_4;
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x000C4BA1 File Offset: 0x000C2DA1
		public short Type
		{
			get
			{
				return this.Oo_oOO_._Oo_o.;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x000C4BA9 File Offset: 0x000C2DA9
		public string Content
		{
			get
			{
				return this.o0o_Oo_.o.;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x000C4BB1 File Offset: 0x000C2DB1
		public short Index
		{
			get
			{
				return this.o0o_Oo_.o.;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x000C4BB9 File Offset: 0x000C2DB9
		public string FromNumber
		{
			get
			{
				return this.Oo_oOO_._Oo_o.;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x000C4BC1 File Offset: 0x000C2DC1
		public DateTime SentTime
		{
			get
			{
				return this.Oo_oOO_._Oo_o.;
			}
		}

		// Token: 0x04000C01 RID: 3073
		private short <<EMPTY_NAME>>;

		// Token: 0x04000C02 RID: 3074
		private short <<EMPTY_NAME>>;

		// Token: 0x04000C03 RID: 3075
		private string <<EMPTY_NAME>>;

		// Token: 0x04000C04 RID: 3076
		private string <<EMPTY_NAME>>;

		// Token: 0x04000C05 RID: 3077
		private DateTime <<EMPTY_NAME>>;
	}
}
