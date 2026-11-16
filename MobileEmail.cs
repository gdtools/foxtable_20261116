using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x0200023E RID: 574
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class MobileEmail
	{
		// Token: 0x06001B70 RID: 7024 RVA: 0x000C05CB File Offset: 0x000BE7CB
		public MobileEmail()
		{
			this.O0__O0O.0o_. = "";
			this.oOO_.oo. = "";
			this.o.o_oOoo0o. = "";
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x000C05F4 File Offset: 0x000BE7F4
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x000C05FC File Offset: 0x000BE7FC
		[DisplayName("邮件地址")]
		[O_Oo00Oo000O0(1.0)]
		public string TO
		{
			get
			{
				return this.O0__O0O.0o_.;
			}
			set
			{
				this.O0__O0O.0o_. = value;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x000C0605 File Offset: 0x000BE805
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x000C060D File Offset: 0x000BE80D
		[DisplayName("邮件标题")]
		[O_Oo00Oo000O0(2.0)]
		public string SUB
		{
			get
			{
				return this.oOO_.oo.;
			}
			set
			{
				this.oOO_.oo. = value;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x000C0616 File Offset: 0x000BE816
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x000C061E File Offset: 0x000BE81E
		[DisplayName("邮件正文")]
		[O_Oo00Oo000O0(3.0)]
		public string TXT
		{
			get
			{
				return this.o.o_oOoo0o.;
			}
			set
			{
				this.o.o_oOoo0o. = value;
			}
		}

		// Token: 0x04000B8E RID: 2958
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B8F RID: 2959
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B90 RID: 2960
		private string <<EMPTY_NAME>>;
	}
}
