using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x0200009B RID: 155
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class PriceTable
	{
		/// <summary>
		/// 采购成品表
		/// </summary>
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0002FA72 File Offset: 0x0002DC72
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x0002FA7A File Offset: 0x0002DC7A
		public DataTable DataTable { get; set; }

		/// <summary>
		/// 物料列
		/// </summary>
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0002FA83 File Offset: 0x0002DC83
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x0002FA8B File Offset: 0x0002DC8B
		public string MaterialCol { get; set; }

		/// <summary>
		/// 价格列
		/// </summary>
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x0002FA94 File Offset: 0x0002DC94
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x0002FA9C File Offset: 0x0002DC9C
		public string PriceCol { get; set; }

		// Token: 0x04000190 RID: 400
		[CompilerGenerated]
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000191 RID: 401
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000192 RID: 402
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;
	}
}
