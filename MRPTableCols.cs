using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x0200009C RID: 156
	[ComVisible(true)]
	[oO0oooo("3388")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class MRPTableCols
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x0002FAA8 File Offset: 0x0002DCA8
		public MRPTableCols()
		{
			this.MaterialCol = "物料";
			this.StockCol = "库存数量";
			this.MinimumCol = "最低库存";
			this.QuantityCol = "计划_需求数量";
			this.FromStockCol = "计划_来自库存";
			this.PurchaseCol = "计划_需要采购";
			this.PurchasePriceCol = "计划_采购单价";
			this.PurchaseCostCol = "计划_采购成本";
			this.ProductionCol = "计划_需要生产";
			this.SCPriceCol = "计划_加工单价";
			this.SCCostCol = "计划_加工成本";
			this.ReplenishCol = "计划_补充库存";
			this.RemainingCol = "剩余库存";
			this.AssembleCol = "计划_用于生产";
			this.MaintenanceCol = "计划_用于售后";
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0002FB60 File Offset: 0x0002DD60
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x0002FB68 File Offset: 0x0002DD68
		public string MaterialCol { get; set; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0002FB71 File Offset: 0x0002DD71
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x0002FB79 File Offset: 0x0002DD79
		public string StockCol { get; set; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0002FB82 File Offset: 0x0002DD82
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x0002FB8A File Offset: 0x0002DD8A
		public string MinimumCol { get; set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0002FB93 File Offset: 0x0002DD93
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x0002FB9B File Offset: 0x0002DD9B
		public string QuantityCol { get; set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0002FBA4 File Offset: 0x0002DDA4
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x0002FBAC File Offset: 0x0002DDAC
		public string FromStockCol { get; set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0002FBB5 File Offset: 0x0002DDB5
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x0002FBBD File Offset: 0x0002DDBD
		public string PurchaseCol { get; set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0002FBC6 File Offset: 0x0002DDC6
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x0002FBCE File Offset: 0x0002DDCE
		public string PurchasePriceCol { get; set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0002FBD7 File Offset: 0x0002DDD7
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x0002FBDF File Offset: 0x0002DDDF
		public string PurchaseCostCol { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0002FBE8 File Offset: 0x0002DDE8
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x0002FBF0 File Offset: 0x0002DDF0
		public string ProductionCol { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0002FBF9 File Offset: 0x0002DDF9
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x0002FC01 File Offset: 0x0002DE01
		public string SCPriceCol { get; set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x0002FC0A File Offset: 0x0002DE0A
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x0002FC12 File Offset: 0x0002DE12
		public string SCCostCol { get; set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0002FC1B File Offset: 0x0002DE1B
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x0002FC23 File Offset: 0x0002DE23
		public string ReplenishCol { get; set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0002FC2C File Offset: 0x0002DE2C
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x0002FC34 File Offset: 0x0002DE34
		public string RemainingCol { get; set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0002FC3D File Offset: 0x0002DE3D
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x0002FC45 File Offset: 0x0002DE45
		public string AssembleCol { get; set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0002FC4E File Offset: 0x0002DE4E
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x0002FC56 File Offset: 0x0002DE56
		public string MaintenanceCol { get; set; }

		// Token: 0x04000193 RID: 403
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000194 RID: 404
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000195 RID: 405
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000196 RID: 406
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000197 RID: 407
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000198 RID: 408
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000199 RID: 409
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400019A RID: 410
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400019B RID: 411
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400019C RID: 412
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400019D RID: 413
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400019E RID: 414
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400019F RID: 415
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001A0 RID: 416
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001A1 RID: 417
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;
	}
}
