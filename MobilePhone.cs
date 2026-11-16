using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x0200023F RID: 575
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class MobilePhone
	{
		// Token: 0x06001B77 RID: 7031 RVA: 0x000C0627 File Offset: 0x000BE827
		public MobilePhone()
		{
			this.O0__O0O.0o_. = "";
			this.oOO_.oo. = "";
			this.o.o_oOoo0o. = "";
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x000C0650 File Offset: 0x000BE850
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x000C0658 File Offset: 0x000BE858
		[DisplayName("标题")]
		[O_Oo00Oo000O0(1.0)]
		public string SUB
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

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x000C0661 File Offset: 0x000BE861
		// (set) Token: 0x06001B7B RID: 7035 RVA: 0x000C0669 File Offset: 0x000BE869
		[DisplayName("电话")]
		[O_Oo00Oo000O0(2.0)]
		public string TEL
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

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x000C0672 File Offset: 0x000BE872
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x000C067A File Offset: 0x000BE87A
		[DisplayName("手机")]
		[O_Oo00Oo000O0(3.0)]
		public string M
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

		// Token: 0x04000B91 RID: 2961
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B92 RID: 2962
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B93 RID: 2963
		private string <<EMPTY_NAME>>;
	}
}
