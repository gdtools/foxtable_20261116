using System;

namespace Foxtable
{
	// Token: 0x02000322 RID: 802
	internal class ColumnLayoutSetting
	{
		// Token: 0x06002CF8 RID: 11512 RVA: 0x0014CD98 File Offset: 0x0014AF98
		internal ColumnLayoutSetting(string A_0, int A_1, bool A_2, bool A_3)
		{
			this.O0._ooOO. = A_0;
			this.O0._ooOO. = A_1;
			this.Oo.0O. = A_3;
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x0014CDB6 File Offset: 0x0014AFB6
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x0014CDBE File Offset: 0x0014AFBE
		internal string Name
		{
			get
			{
				return this.O0._ooOO.;
			}
			set
			{
				this.O0._ooOO. = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x0014CDC7 File Offset: 0x0014AFC7
		internal int Width
		{
			get
			{
				return this.O0._ooOO.;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x0014CDCF File Offset: 0x0014AFCF
		internal bool Visible
		{
			get
			{
				return this.Oo.0O.;
			}
		}

		// Token: 0x0400123F RID: 4671
		private string <<EMPTY_NAME>>;

		// Token: 0x04001240 RID: 4672
		private int <<EMPTY_NAME>>;

		// Token: 0x04001241 RID: 4673
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001242 RID: 4674
		private bool <<EMPTY_NAME>>;
	}
}
