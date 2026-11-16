using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x0200028D RID: 653
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CrossExpressionGroup
	{
		// Token: 0x06002091 RID: 8337 RVA: 0x000E2DF4 File Offset: 0x000E0FF4
		public CrossExpressionGroup(string A_0, string A_1, string A_2)
		{
			this.OOOOO_0._o0O0o. = A_0;
			this.o_OO0oo.____o. = A_1;
			this.oO.O00o_. = A_2;
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06002092 RID: 8338 RVA: 0x000E2E11 File Offset: 0x000E1011
		// (set) Token: 0x06002093 RID: 8339 RVA: 0x000E2E19 File Offset: 0x000E1019
		public string Name
		{
			get
			{
				return this.OOOOO_0._o0O0o.;
			}
			set
			{
				this.OOOOO_0._o0O0o. = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x000E2E22 File Offset: 0x000E1022
		// (set) Token: 0x06002095 RID: 8341 RVA: 0x000E2E2A File Offset: 0x000E102A
		public string Pattern
		{
			get
			{
				return this.oO.O00o_.;
			}
			set
			{
				this.oO.O00o_. = value;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x000E2E33 File Offset: 0x000E1033
		// (set) Token: 0x06002097 RID: 8343 RVA: 0x000E2E3B File Offset: 0x000E103B
		public string Expression
		{
			get
			{
				return this.o_OO0oo.____o.;
			}
			set
			{
				this.o_OO0oo.____o. = value;
			}
		}

		// Token: 0x04000DAA RID: 3498
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DAB RID: 3499
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DAC RID: 3500
		private string <<EMPTY_NAME>>;
	}
}
