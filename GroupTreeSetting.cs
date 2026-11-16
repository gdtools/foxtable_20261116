using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x020000A8 RID: 168
	[ComVisible(true)]
	public class GroupTreeSetting
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00030C13 File Offset: 0x0002EE13
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00030C1B File Offset: 0x0002EE1B
		public object[] GroupCols { get; set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00030C24 File Offset: 0x0002EE24
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00030C2C File Offset: 0x0002EE2C
		public object[] AggregateCols { get; set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00030C35 File Offset: 0x0002EE35
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00030C3D File Offset: 0x0002EE3D
		public string[] ValueCols { get; set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00030C46 File Offset: 0x0002EE46
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00030C4E File Offset: 0x0002EE4E
		public string SortCol { get; set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00030C57 File Offset: 0x0002EE57
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00030C5F File Offset: 0x0002EE5F
		public bool SortDesc { get; set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00030C68 File Offset: 0x0002EE68
		internal string[] GroupCols2
		{
			get
			{
				return ooO.oO0__o.0o__.(this.GroupCols);
			}
		}

		// Token: 0x040001C9 RID: 457
		[CompilerGenerated]
		private object[] <<EMPTY_NAME>>;

		// Token: 0x040001CA RID: 458
		[CompilerGenerated]
		private object[] <<EMPTY_NAME>>;

		// Token: 0x040001CB RID: 459
		[CompilerGenerated]
		private string[] <<EMPTY_NAME>>;

		// Token: 0x040001CC RID: 460
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001CD RID: 461
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;
	}
}
