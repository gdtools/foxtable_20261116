using System;
using System.Runtime.InteropServices;
using C1.Win.C1FlexGrid;

namespace Foxtable
{
	// Token: 0x02000315 RID: 789
	[ComVisible(true)]
	public class CellRange
	{
		// Token: 0x06002A7C RID: 10876 RVA: 0x0012DB49 File Offset: 0x0012BD49
		public CellRange(Table A_0, CellRange A_1)
		{
			this.O.OoOo00O_. = A_0;
			this.O.OoOo00O_. = A_1;
		}

		/// <summary>
		/// 返回最上边一行位置
		/// </summary>
		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x0012DB5F File Offset: 0x0012BD5F
		public int TopRow
		{
			get
			{
				return this.O.OoOo00O_..TopRow - this.O.OoOo00O_..foxGrid.Rows.Fixed;
			}
		}

		/// <summary>
		/// 返回最下边一行位置
		/// </summary>
		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002A7E RID: 10878 RVA: 0x0012DB82 File Offset: 0x0012BD82
		public int BottomRow
		{
			get
			{
				return this.O.OoOo00O_..BottomRow - this.O.OoOo00O_..foxGrid.Rows.Fixed;
			}
		}

		/// <summary>
		/// 返回最左边一列位置
		/// </summary>
		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x0012DBA5 File Offset: 0x0012BDA5
		public int LeftCol
		{
			get
			{
				return this.O.OoOo00O_..LeftCol - this.O.OoOo00O_..foxGrid.Cols.Fixed;
			}
		}

		/// <summary>
		///  返回最右边一列位置
		/// </summary>
		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06002A80 RID: 10880 RVA: 0x0012DBC8 File Offset: 0x0012BDC8
		public int RightCol
		{
			get
			{
				return this.O.OoOo00O_..RightCol - this.O.OoOo00O_..foxGrid.Cols.Fixed;
			}
		}

		/// <summary>
		/// 返回或设置起始行位置
		/// </summary>
		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06002A81 RID: 10881 RVA: 0x0012DBEB File Offset: 0x0012BDEB
		// (set) Token: 0x06002A82 RID: 10882 RVA: 0x0012DC0E File Offset: 0x0012BE0E
		public int RowSel
		{
			get
			{
				return this.O.OoOo00O_..r1 - this.O.OoOo00O_..foxGrid.Rows.Fixed;
			}
			set
			{
				this.O.OoOo00O_..r1 = value + this.O.OoOo00O_..foxGrid.Rows.Fixed;
			}
		}

		/// <summary>
		/// 返回或设置结束行位置
		/// </summary>
		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002A83 RID: 10883 RVA: 0x0012DC32 File Offset: 0x0012BE32
		// (set) Token: 0x06002A84 RID: 10884 RVA: 0x0012DC55 File Offset: 0x0012BE55
		public int RowEnd
		{
			get
			{
				return this.O.OoOo00O_..r2 - this.O.OoOo00O_..foxGrid.Rows.Fixed;
			}
			set
			{
				this.O.OoOo00O_..r2 = value + this.O.OoOo00O_..foxGrid.Rows.Fixed;
			}
		}

		/// <summary>
		/// 返回或设置起始列位置
		/// </summary>
		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x0012DC79 File Offset: 0x0012BE79
		// (set) Token: 0x06002A86 RID: 10886 RVA: 0x0012DC9C File Offset: 0x0012BE9C
		public int ColSel
		{
			get
			{
				return this.O.OoOo00O_..c1 - this.O.OoOo00O_..foxGrid.Cols.Fixed;
			}
			set
			{
				this.O.OoOo00O_..c1 = value + this.O.OoOo00O_..foxGrid.Cols.Fixed;
			}
		}

		/// <summary>
		/// 返回或设置结束列位置
		/// </summary>
		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002A87 RID: 10887 RVA: 0x0012DCC0 File Offset: 0x0012BEC0
		// (set) Token: 0x06002A88 RID: 10888 RVA: 0x0012DCE3 File Offset: 0x0012BEE3
		public int ColEnd
		{
			get
			{
				return this.O.OoOo00O_..c2 - this.O.OoOo00O_..foxGrid.Cols.Fixed;
			}
			set
			{
				this.O.OoOo00O_..c2 = value + this.O.OoOo00O_..foxGrid.Cols.Fixed;
			}
		}

		// Token: 0x0400118E RID: 4494
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400118F RID: 4495
		private CellRange <<EMPTY_NAME>>;
	}
}
