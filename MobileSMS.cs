using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000240 RID: 576
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class MobileSMS
	{
		// Token: 0x06001B7E RID: 7038 RVA: 0x000C0683 File Offset: 0x000BE883
		public MobileSMS()
		{
			this.O0__O0O.0o_. = "";
			this.oOO_.oo. = "";
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x000C06A1 File Offset: 0x000BE8A1
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x000C06A9 File Offset: 0x000BE8A9
		[DisplayName("手机号码")]
		[O_Oo00Oo000O0(1.0)]
		public string SM
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

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x000C06B2 File Offset: 0x000BE8B2
		// (set) Token: 0x06001B82 RID: 7042 RVA: 0x000C06BA File Offset: 0x000BE8BA
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("短信正文")]
		public string TXT
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

		// Token: 0x04000B94 RID: 2964
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B95 RID: 2965
		private string <<EMPTY_NAME>>;
	}
}
