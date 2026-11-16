using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Foxtable
{
	/// <summary>
	/// 根据数据表创建多列数据字典
	/// </summary>
	// Token: 0x02000328 RID: 808
	[oO0oooo("2653")]
	[ComVisible(true)]
	public class TableDataMap
	{
		/// <summary>
		/// 来源表
		/// </summary>
		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002D28 RID: 11560 RVA: 0x0014D344 File Offset: 0x0014B544
		// (set) Token: 0x06002D29 RID: 11561 RVA: 0x0014D34C File Offset: 0x0014B54C
		public string DataTable
		{
			get
			{
				return this.o0O0Oo.OoO_.;
			}
			set
			{
				this.o0O0Oo.OoO_. = value;
			}
		}

		/// <summary>
		/// 取值列
		/// </summary>
		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002D2A RID: 11562 RVA: 0x0014D355 File Offset: 0x0014B555
		// (set) Token: 0x06002D2B RID: 11563 RVA: 0x0014D35D File Offset: 0x0014B55D
		public string ValueCol
		{
			get
			{
				return this.O0o.OOo.;
			}
			set
			{
				this.O0o.OOo. = value;
			}
		}

		/// <summary>
		/// 显示列
		/// </summary>
		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002D2C RID: 11564 RVA: 0x0014D366 File Offset: 0x0014B566
		// (set) Token: 0x06002D2D RID: 11565 RVA: 0x0014D36E File Offset: 0x0014B56E
		public string DisplayCol
		{
			get
			{
				return this.O_oOo._o.;
			}
			set
			{
				this.O_oOo._o. = value;
			}
		}

		/// <summary>
		/// 指定下拉的表格中，要显示哪些列的内容，不同的列之间用逗号隔开
		/// </summary>
		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002D2E RID: 11566 RVA: 0x0014D377 File Offset: 0x0014B577
		// (set) Token: 0x06002D2F RID: 11567 RVA: 0x0014D37F File Offset: 0x0014B57F
		public string ListCols
		{
			get
			{
				return this.oo_.0__O.;
			}
			set
			{
				this.oo_.0__O. = value;
			}
		}

		/// <summary>
		/// 过滤条件表达式，输入的时候，下拉列表只显示符合此条件的行
		/// </summary>
		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002D30 RID: 11568 RVA: 0x0014D388 File Offset: 0x0014B588
		// (set) Token: 0x06002D31 RID: 11569 RVA: 0x0014D390 File Offset: 0x0014B590
		public string Filter
		{
			get
			{
				return this.O__.o_O0o.;
			}
			set
			{
				this.O__.o_O0o. = value;
			}
		}

		/// <summary>
		/// 排序列
		/// </summary>
		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x0014D399 File Offset: 0x0014B599
		// (set) Token: 0x06002D33 RID: 11571 RVA: 0x0014D3A1 File Offset: 0x0014B5A1
		public string Sort
		{
			get
			{
				return this.O0O_._O.;
			}
			set
			{
				this.O0O_._O. = value;
			}
		}

		/// <summary>
		/// 生成多列数据字典
		/// </summary>
		// Token: 0x06002D34 RID: 11572 RVA: 0x0014D3AA File Offset: 0x0014B5AA
		public IDictionary CreateDataMap()
		{
			return Oo00.OO.0O0o.(this.DataTable, this.ListCols, this.ValueCol, this.DisplayCol, this.Filter, this.Sort);
		}

		// Token: 0x0400124B RID: 4683
		private string <<EMPTY_NAME>>;

		// Token: 0x0400124C RID: 4684
		private string <<EMPTY_NAME>>;

		// Token: 0x0400124D RID: 4685
		private string <<EMPTY_NAME>>;

		// Token: 0x0400124E RID: 4686
		private string <<EMPTY_NAME>>;

		// Token: 0x0400124F RID: 4687
		private string <<EMPTY_NAME>>;

		// Token: 0x04001250 RID: 4688
		private string <<EMPTY_NAME>>;
	}
}
