using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001E7 RID: 487
	public class AIParameter
	{
		// Token: 0x06001848 RID: 6216 RVA: 0x000AC851 File Offset: 0x000AAA51
		public AIParameter()
		{
			this.ArrayItemType = "string";
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x000AC864 File Offset: 0x000AAA64
		// (set) Token: 0x0600184A RID: 6218 RVA: 0x000AC86C File Offset: 0x000AAA6C
		public string Name { get; set; }

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x000AC875 File Offset: 0x000AAA75
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x000AC87D File Offset: 0x000AAA7D
		public string Type { get; set; }

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x000AC886 File Offset: 0x000AAA86
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x000AC88E File Offset: 0x000AAA8E
		public string Description { get; set; }

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x000AC897 File Offset: 0x000AAA97
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x000AC89F File Offset: 0x000AAA9F
		public bool IsRequired { get; set; }

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x000AC8A8 File Offset: 0x000AAAA8
		// (set) Token: 0x06001852 RID: 6226 RVA: 0x000AC8B0 File Offset: 0x000AAAB0
		public string ArrayItemType { get; set; }

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x000AC8B9 File Offset: 0x000AAAB9
		// (set) Token: 0x06001854 RID: 6228 RVA: 0x000AC8C1 File Offset: 0x000AAAC1
		public IEnumerable<object> EnumValues { get; set; }

		// Token: 0x040009AF RID: 2479
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009B0 RID: 2480
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009B1 RID: 2481
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009B2 RID: 2482
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040009B3 RID: 2483
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040009B4 RID: 2484
		[CompilerGenerated]
		private IEnumerable<object> <<EMPTY_NAME>>;
	}
}
