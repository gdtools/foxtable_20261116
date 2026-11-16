using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x02000099 RID: 153
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class StockTable
	{
		/// <summary>
		/// 库存表
		/// </summary>
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0002F9EB File Offset: 0x0002DBEB
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x0002F9F3 File Offset: 0x0002DBF3
		public DataTable DataTable { get; set; }

		/// <summary>
		/// 物料列
		/// </summary>
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0002F9FC File Offset: 0x0002DBFC
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x0002FA04 File Offset: 0x0002DC04
		public string MaterialCol { get; set; }

		/// <summary>
		/// 用量列
		/// </summary>
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0002FA0D File Offset: 0x0002DC0D
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x0002FA15 File Offset: 0x0002DC15
		public string QuantityCol { get; set; }

		/// <summary>
		/// 安全库存列
		/// </summary>
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0002FA1E File Offset: 0x0002DC1E
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x0002FA26 File Offset: 0x0002DC26
		public string MinimumCol { get; set; }

		// Token: 0x04000189 RID: 393
		[CompilerGenerated]
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x0400018A RID: 394
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400018B RID: 395
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400018C RID: 396
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;
	}
}
