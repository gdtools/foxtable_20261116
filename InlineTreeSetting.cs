using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x020000B0 RID: 176
	[ComVisible(true)]
	public class InlineTreeSetting
	{
		// Token: 0x060006FB RID: 1787 RVA: 0x000333AB File Offset: 0x000315AB
		public InlineTreeSetting()
		{
			this.TreeType = O0_0_0O0___O.OOO.__O_oO_.;
			this.IncludeSub = true;
			this.ExpandTo = 0;
			this.Unique = true;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000333CF File Offset: 0x000315CF
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x000333D7 File Offset: 0x000315D7
		[EditorBrowsable(EditorBrowsableState.Never)]
		public O0_0_0O0___O TreeType { get; set; }

		/// <summary>
		/// 父列名称
		/// </summary>
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x000333E0 File Offset: 0x000315E0
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x000333E8 File Offset: 0x000315E8
		public string ParentCol { get; set; }

		/// <summary>
		/// ChildCol
		/// </summary>
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x000333F1 File Offset: 0x000315F1
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x000333F9 File Offset: 0x000315F9
		public string ChildCol { get; set; }

		/// <summary>
		/// 数值列名称
		/// </summary>
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00033402 File Offset: 0x00031602
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x0003340A File Offset: 0x0003160A
		public string ValueCol { get; set; }

		/// <summary>
		/// 标题列名称
		/// </summary>
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00033413 File Offset: 0x00031613
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x0003341B File Offset: 0x0003161B
		public string TextCol { get; set; }

		/// <summary>
		/// 是否显示子目录数据
		/// </summary>
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00033424 File Offset: 0x00031624
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x0003342C File Offset: 0x0003162C
		public bool IncludeSub { get; set; }

		/// <summary>
		/// 使用内联筛选树时，是否自动汇总子目录数据
		/// </summary>
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00033435 File Offset: 0x00031635
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x0003343D File Offset: 0x0003163D
		public bool Subtotal { get; set; }

		/// <summary>
		/// 是否自动开启折叠模式
		/// </summary>
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00033446 File Offset: 0x00031646
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x0003344E File Offset: 0x0003164E
		public bool GridTree { get; set; }

		/// <summary>
		/// 在设置折叠树的时候，用于指定折叠树显示列，如果不设置，默认显示在层级列
		/// </summary>
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00033457 File Offset: 0x00031657
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x0003345F File Offset: 0x0003165F
		public string TreeCol { get; set; }

		/// <summary>
		/// 设置折叠树默认展开级别
		/// </summary>
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00033468 File Offset: 0x00031668
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00033470 File Offset: 0x00031670
		public int ExpandTo { get; set; }

		/// <summary>
		/// 指定要汇总的列
		/// </summary>
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00033479 File Offset: 0x00031679
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00033481 File Offset: 0x00031681
		public object[] AggregateCols { get; set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0003348A File Offset: 0x0003168A
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x00033492 File Offset: 0x00031692
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ValueCols { get; set; }

		/// <summary>
		/// 是否不允许重复行
		/// </summary>
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0003349B File Offset: 0x0003169B
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x000334A3 File Offset: 0x000316A3
		public bool Unique { get; set; }

		/// <summary>
		/// 排序列
		/// </summary>
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x000334AC File Offset: 0x000316AC
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x000334B4 File Offset: 0x000316B4
		public string SortCol { get; set; }

		/// <summary>
		/// 是否降序排序
		/// </summary>
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x000334BD File Offset: 0x000316BD
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x000334C5 File Offset: 0x000316C5
		public bool SortDesc { get; set; }

		/// <summary>
		/// 是否使用样式区分分组行
		/// </summary>
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x000334CE File Offset: 0x000316CE
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x000334D6 File Offset: 0x000316D6
		public bool UseStyle { get; set; }

		/// <summary>
		/// 是否合并显示统计结果
		/// </summary>
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000334DF File Offset: 0x000316DF
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x000334E7 File Offset: 0x000316E7
		public bool MergeTotal { get; set; }

		// Token: 0x040001FC RID: 508
		[CompilerGenerated]
		private O0_0_0O0___O <<EMPTY_NAME>>;

		// Token: 0x040001FD RID: 509
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001FE RID: 510
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001FF RID: 511
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000200 RID: 512
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000201 RID: 513
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000202 RID: 514
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000203 RID: 515
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000204 RID: 516
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000205 RID: 517
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;

		// Token: 0x04000206 RID: 518
		[CompilerGenerated]
		private object[] <<EMPTY_NAME>>;

		// Token: 0x04000207 RID: 519
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000208 RID: 520
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000209 RID: 521
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400020A RID: 522
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400020B RID: 523
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400020C RID: 524
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;
	}
}
