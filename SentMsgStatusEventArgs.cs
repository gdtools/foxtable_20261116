using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000255 RID: 597
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class SentMsgStatusEventArgs
	{
		// Token: 0x06001C61 RID: 7265 RVA: 0x000C4BE0 File Offset: 0x000C2DE0
		public SentMsgStatusEventArgs(uint A_0, string A_1, string A_2, short A_3, bool A_4)
		{
			this.ooO.o_Oo. = A_0;
			this.ooO.o_Oo. = A_1;
			this.O_oo.0_o_. = A_2;
			this.ooO.o_Oo. = A_3;
			this.ooO.o_Oo. = A_4;
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x000C4C0D File Offset: 0x000C2E0D
		public uint MsgID
		{
			get
			{
				return this.ooO.o_Oo.;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x000C4C15 File Offset: 0x000C2E15
		public string DestNumber
		{
			get
			{
				return this.ooO.o_Oo.;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x000C4C1D File Offset: 0x000C2E1D
		public string Content
		{
			get
			{
				return this.O_oo.0_o_.;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x000C4C25 File Offset: 0x000C2E25
		public short SplitIndex
		{
			get
			{
				return this.ooO.o_Oo.;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x000C4C2D File Offset: 0x000C2E2D
		public bool Succeed
		{
			get
			{
				return this.ooO.o_Oo.;
			}
		}

		// Token: 0x04000C07 RID: 3079
		private uint <<EMPTY_NAME>>;

		// Token: 0x04000C08 RID: 3080
		private string <<EMPTY_NAME>>;

		// Token: 0x04000C09 RID: 3081
		private string <<EMPTY_NAME>>;

		// Token: 0x04000C0A RID: 3082
		private short <<EMPTY_NAME>>;

		// Token: 0x04000C0B RID: 3083
		private bool <<EMPTY_NAME>>;
	}
}
