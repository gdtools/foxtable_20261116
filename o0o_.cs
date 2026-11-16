using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000AE RID: 174
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o0o_
	{
		// Token: 0x060006D1 RID: 1745 RVA: 0x000326C8 File Offset: 0x000308C8
		[CompilerGenerated]
		public AggregateType <<EMPTY_NAME>>()
		{
			return this.O0OO_0.O.;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000326D0 File Offset: 0x000308D0
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(AggregateType A_0)
		{
			this.O0OO_0.O. = A_0;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000326D9 File Offset: 0x000308D9
		[CompilerGenerated]
		public string <<EMPTY_NAME>>()
		{
			return this.O0OO_0.O.;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000326E1 File Offset: 0x000308E1
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.O0OO_0.O. = A_0;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000326EA File Offset: 0x000308EA
		[CompilerGenerated]
		public AggregateRange <<EMPTY_NAME>>()
		{
			return this.O0OO_0.O.;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000326F2 File Offset: 0x000308F2
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(AggregateRange A_0)
		{
			this.O0OO_0.O. = A_0;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000326FC File Offset: 0x000308FC
		public string <<EMPTY_NAME>>()
		{
			string result;
			if (Operators.CompareString(this.O0_O00.o., "", true) == 0)
			{
				result = this.o0oO._o_.();
			}
			else
			{
				result = this.O0_O00.o.;
			}
			return result;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0003272D File Offset: 0x0003092D
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.O0_O00.o. = A_0;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00032736 File Offset: 0x00030936
		public o0o_(string A_0) : this(A_0, A_0)
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00032740 File Offset: 0x00030940
		public o0o_(string A_0, string A_1) : this(A_0, A_1, AggregateRange.Both)
		{
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0003274B File Offset: 0x0003094B
		public o0o_(string A_0, string A_1, AggregateRange A_2) : this(A_0, A_1, A_2, AggregateType.Sum)
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00032757 File Offset: 0x00030957
		public o0o_(string A_0, string A_1, AggregateRange A_2, AggregateType A_3)
		{
			this.O0OO_0.O.(AggregateType.Sum);
			this.O0OO_0.O.(AggregateRange.Both);
			this.O0_O00.o.(A_0);
			this.O0OO_0.O.(A_1);
			this.O0OO_0.O.(A_2);
			this.O0OO_0.O.(A_3);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0003278A File Offset: 0x0003098A
		public o0o_(bool A_0, string A_1) : this(true, A_1, AggregateRange.Both)
		{
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00032795 File Offset: 0x00030995
		public o0o_(bool A_0, string A_1, AggregateRange A_2)
		{
			this.O0OO_0.O.(AggregateType.Sum);
			this.O0OO_0.O.(AggregateRange.Both);
			this.O0OO_0.O.(A_1);
			this.O0OO_0.O.(AggregateType.Count);
			this.O0OO_0.O.(A_2);
		}

		// Token: 0x040001EB RID: 491
		[CompilerGenerated]
		private AggregateType <<EMPTY_NAME>>;

		// Token: 0x040001EC RID: 492
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001ED RID: 493
		[CompilerGenerated]
		private AggregateRange <<EMPTY_NAME>>;

		// Token: 0x040001EE RID: 494
		private string <<EMPTY_NAME>>;
	}
}
