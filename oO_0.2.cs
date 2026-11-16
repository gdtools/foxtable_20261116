using System;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x020003A7 RID: 935
	internal class oO_0 : C1NavBarPanel, O0_0_0_0_
	{
		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x001BCB56 File Offset: 0x001BAD56
		// (set) Token: 0x06003D18 RID: 15640 RVA: 0x001BCB5E File Offset: 0x001BAD5E
		public string ImageFile
		{
			get
			{
				return this.oOo_._0__0o_0o.;
			}
			set
			{
				this.oOo_._0__0o_0o. = value;
				base.Button.Image = OO_00oOO.GetImage(value);
			}
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x001BCB78 File Offset: 0x001BAD78
		public string <<EMPTY_NAME>>()
		{
			return this.o_0_0_._.;
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x001BCB80 File Offset: 0x001BAD80
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.o_0_0_._. = A_0;
			base.Button.SmallImage = OO_00oOO.GetImage(A_0);
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x001BCB9A File Offset: 0x001BAD9A
		public int <<EMPTY_NAME>>()
		{
			return this.OO_o_O_.o.;
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x001BCBA2 File Offset: 0x001BADA2
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.OO_o_O_.o. = A_0;
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x001BCBAB File Offset: 0x001BADAB
		public int <<EMPTY_NAME>>()
		{
			return this.o_0_0_._.;
		}

		// Token: 0x06003D1E RID: 15646 RVA: 0x001BCBB3 File Offset: 0x001BADB3
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.o_0_0_._. = A_0;
		}

		// Token: 0x06003D1F RID: 15647 RVA: 0x001BCBBC File Offset: 0x001BADBC
		public void <<EMPTY_NAME>>()
		{
			oOO0oo_o0.O00OO_O_oO_.o.(this, base.Controls);
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x001BCBCA File Offset: 0x001BADCA
		public void <<EMPTY_NAME>>()
		{
			oOO0oo_o0.O._0O0__o.(base.Controls);
		}

		// Token: 0x04001915 RID: 6421
		private string <<EMPTY_NAME>>;

		// Token: 0x04001916 RID: 6422
		private string <<EMPTY_NAME>>;

		// Token: 0x04001917 RID: 6423
		private int <<EMPTY_NAME>>;

		// Token: 0x04001918 RID: 6424
		private int <<EMPTY_NAME>>;
	}
}
