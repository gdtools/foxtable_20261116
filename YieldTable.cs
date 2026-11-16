using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x0200009A RID: 154
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class YieldTable
	{
		/// <summary>
		/// 成品率表
		/// </summary>
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0002FA37 File Offset: 0x0002DC37
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x0002FA3F File Offset: 0x0002DC3F
		public DataTable DataTable { get; set; }

		/// <summary>
		/// 物料列
		/// </summary>
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0002FA48 File Offset: 0x0002DC48
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x0002FA50 File Offset: 0x0002DC50
		public string MaterialCol { get; set; }

		/// <summary>
		/// 成品率列
		/// </summary>
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0002FA59 File Offset: 0x0002DC59
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x0002FA61 File Offset: 0x0002DC61
		public string YieldCol { get; set; }

		// Token: 0x0400018D RID: 397
		[CompilerGenerated]
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x0400018E RID: 398
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400018F RID: 399
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;
	}
}
