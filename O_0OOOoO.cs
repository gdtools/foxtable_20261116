using System;
using System.Collections.Generic;

namespace Foxtable
{
	// Token: 0x020001CA RID: 458
	internal class O_0OOOoO : IMBuddy
	{
		// Token: 0x06001620 RID: 5664 RVA: 0x00099DF0 File Offset: 0x00097FF0
		internal O_0OOOoO(string A_0, string A_1, IMBuddy A_2, string A_3, string A_4) : base(A_0, A_2.WanIP, A_1)
		{
			this.O0O0o_.00O. = A_0;
			this.O.0O__0O0o_O. = A_1;
			this.O0O0o_.00O. = A_2;
			this.O0O0o_.00O. = DateTime.Now;
			this.Oo__O_OO_o_0._. = A_3;
			this.o0oO0O._0_. = A_4;
			this.O0O0o_.00O. = new List<string>();
			this.O0O0o_.00O..AddRange(A_4.Split(new char[]
			{
				','
			}));
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00099E63 File Offset: 0x00098063
		internal string <<EMPTY_NAME>>()
		{
			return this.O0O0o_.00O.;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00099E6B File Offset: 0x0009806B
		internal string <<EMPTY_NAME>>()
		{
			return this.O.0O__0O0o_O.;
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00099E73 File Offset: 0x00098073
		internal IMBuddy <<EMPTY_NAME>>()
		{
			return this.O0O0o_.00O.;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00099E7B File Offset: 0x0009807B
		internal string <<EMPTY_NAME>>()
		{
			return this.Oo__O_OO_o_0._.;
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00099E83 File Offset: 0x00098083
		internal string <<EMPTY_NAME>>()
		{
			return this.o0oO0O._0_.;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00099E8B File Offset: 0x0009808B
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.o0oO0O._0_. = A_0;
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00099E94 File Offset: 0x00098094
		internal DateTime <<EMPTY_NAME>>()
		{
			return this.O0O0o_.00O.;
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00099E9C File Offset: 0x0009809C
		internal void <<EMPTY_NAME>>(DateTime A_0)
		{
			this.O0O0o_.00O. = A_0;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00099EA5 File Offset: 0x000980A5
		internal List<string> <<EMPTY_NAME>>()
		{
			return this.O0O0o_.00O.;
		}

		// Token: 0x040008C2 RID: 2242
		private string <<EMPTY_NAME>>;

		// Token: 0x040008C3 RID: 2243
		private string <<EMPTY_NAME>>;

		// Token: 0x040008C4 RID: 2244
		private IMBuddy <<EMPTY_NAME>>;

		// Token: 0x040008C5 RID: 2245
		private string <<EMPTY_NAME>>;

		// Token: 0x040008C6 RID: 2246
		private string <<EMPTY_NAME>>;

		// Token: 0x040008C7 RID: 2247
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x040008C8 RID: 2248
		private DateTime <<EMPTY_NAME>>;
	}
}
