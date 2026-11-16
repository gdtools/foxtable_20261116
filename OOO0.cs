using System;

namespace Foxtable
{
	// Token: 0x0200003D RID: 61
	[AttributeUsage(AttributeTargets.Property)]
	internal class OOO0 : Attribute
	{
		// Token: 0x06000292 RID: 658 RVA: 0x00005BD7 File Offset: 0x00003DD7
		public OOO0(string A_0, string A_1)
		{
			this.o.0_OoO_. = A_0;
			this.oo.0_. = A_1;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00005BED File Offset: 0x00003DED
		public string <<EMPTY_NAME>>()
		{
			return this.o.0_OoO_.;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00005BF5 File Offset: 0x00003DF5
		public string <<EMPTY_NAME>>()
		{
			return this.oo.0_.;
		}

		// Token: 0x0400005D RID: 93
		private string <<EMPTY_NAME>>;

		// Token: 0x0400005E RID: 94
		private string <<EMPTY_NAME>>;
	}
}
