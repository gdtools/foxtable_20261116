using System;

namespace Foxtable
{
	// Token: 0x02000047 RID: 71
	internal class O0o_00oO__0_ : IComparable
	{
		// Token: 0x060002AB RID: 683 RVA: 0x00005E44 File Offset: 0x00004044
		public O0o_00oO__0_(string A_0, double A_1)
		{
			this.O0OOo0_._. = A_0;
			this.O0OOo0_._. = A_1;
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00005E5A File Offset: 0x0000405A
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00005E62 File Offset: 0x00004062
		public string Name
		{
			get
			{
				return this.O0OOo0_._.;
			}
			set
			{
				this.O0OOo0_._. = value;
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00005E6B File Offset: 0x0000406B
		public double <<EMPTY_NAME>>()
		{
			return this.O0OOo0_._.;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00005E73 File Offset: 0x00004073
		public void <<EMPTY_NAME>>(double A_0)
		{
			this.O0OOo0_._. = A_0;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00005E7C File Offset: 0x0000407C
		public int <<EMPTY_NAME>>(object A_0)
		{
			double o0OOo0_._. = ((O0o_00oO__0_)A_0).O0OOo0_._.;
			int result;
			if (o0OOo0_._. == this.O0OOo0_._.)
			{
				string o0OOo0_._.2 = ((O0o_00oO__0_)A_0).O0OOo0_._.;
				result = string.Compare(this.O0OOo0_._., o0OOo0_._.2);
			}
			else if (o0OOo0_._. > this.O0OOo0_._.)
			{
				result = -1;
			}
			else
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x04000066 RID: 102
		private double <<EMPTY_NAME>>;

		// Token: 0x04000067 RID: 103
		private string <<EMPTY_NAME>>;
	}
}
