using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using C1.FlexMap;
using C1.Win.Map;

namespace Foxtable
{
	// Token: 0x02000147 RID: 327
	[ComVisible(true)]
	public class VectorRecord
	{
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0007D53B File Offset: 0x0007B73B
		public C1.Win.Map.VectorItem VectorItem { get; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x0007D543 File Offset: 0x0007B743
		public IGeoGeometryRecordData Data { get; }

		// Token: 0x0600103E RID: 4158 RVA: 0x0007D54B File Offset: 0x0007B74B
		internal VectorRecord(C1.Win.Map.VectorItem A_0, IGeoGeometryRecordData A_1)
		{
			this.VectorItem = A_0;
			this.Data = A_1;
		}

		// Token: 0x0400064F RID: 1615
		[CompilerGenerated]
		private C1.Win.Map.VectorItem <<EMPTY_NAME>>;

		// Token: 0x04000650 RID: 1616
		[CompilerGenerated]
		private IGeoGeometryRecordData <<EMPTY_NAME>>;
	}
}
