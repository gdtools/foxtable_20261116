using System;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020003AA RID: 938
	internal class o0000O : SplitContainer
	{
		// Token: 0x06003D30 RID: 15664 RVA: 0x001BCDAC File Offset: 0x001BAFAC
		public o0_OO0 <<EMPTY_NAME>>()
		{
			return this.o__O0_.o_.;
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x001BCDB4 File Offset: 0x001BAFB4
		public o0_OO0 <<EMPTY_NAME>>()
		{
			return this.oo0oo__0o.O.;
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x001BCDBC File Offset: 0x001BAFBC
		public o0000O()
		{
			base.FixedPanel = FixedPanel.Panel1;
			this.o__O0_.o_. = new o0_OO0();
			this.oo0oo__0o.O. = new o0_OO0();
			base.Controls[0].Controls.Add(this.o__O0_.o_.);
			base.Controls[1].Controls.Add(this.oo0oo__0o.O.);
		}

		// Token: 0x0400191C RID: 6428
		private o0_OO0 <<EMPTY_NAME>>;

		// Token: 0x0400191D RID: 6429
		private o0_OO0 <<EMPTY_NAME>>;
	}
}
