using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 层级数据设置
	/// </summary>
	// Token: 0x020000B4 RID: 180
	[ComVisible(true)]
	public class LayerTreeSetting
	{
		// Token: 0x06000781 RID: 1921 RVA: 0x000395DE File Offset: 0x000377DE
		public LayerTreeSetting()
		{
			this.IncludeSub = true;
			this.ExpandTo = 0;
			this.Unique = true;
		}

		/// <summary>
		/// 层级列
		/// </summary>
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x000395FB File Offset: 0x000377FB
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00039603 File Offset: 0x00037803
		public string PathCol { get; set; }

		/// <summary>
		/// 标题列
		/// </summary>
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0003960C File Offset: 0x0003780C
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00039614 File Offset: 0x00037814
		public string TextCol { get; set; }

		/// <summary>
		/// 在设置折叠树的时候，用于指定折叠树显示列，如果不设置，默认显示在层级列
		/// </summary>
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0003961D File Offset: 0x0003781D
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00039625 File Offset: 0x00037825
		public string TreeCol { get; set; }

		/// <summary>
		/// 数量列
		/// </summary>
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0003962E File Offset: 0x0003782E
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00039636 File Offset: 0x00037836
		public string ValueCol { get; set; }

		/// <summary>
		/// 是否显示子目录数据
		/// </summary>
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0003963F File Offset: 0x0003783F
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x00039647 File Offset: 0x00037847
		public bool IncludeSub { get; set; }

		/// <summary>
		/// 使用层级筛选树时，是否自动汇总子目录数据
		/// </summary>
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00039650 File Offset: 0x00037850
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x00039658 File Offset: 0x00037858
		public bool Subtotal { get; set; }

		/// <summary>
		/// 层级列内容分割符
		/// </summary>
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00039661 File Offset: 0x00037861
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x0003966E File Offset: 0x0003786E
		public string Separator
		{
			get
			{
				return Conversions.ToString(this.Separator2);
			}
			set
			{
				if (value.Length > 0)
				{
					this.Separator2 = value[0];
				}
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00039686 File Offset: 0x00037886
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x0003968E File Offset: 0x0003788E
		internal char Separator2 { get; set; }

		/// <summary>
		/// 整数型数组，用于指定层级列各列长度
		/// </summary>
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00039698 File Offset: 0x00037898
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x000396EC File Offset: 0x000378EC
		public object[] Lengths
		{
			get
			{
				List<object> list = new List<object>();
				if (this.Lengths2 != null && this.Lengths2.Length > 0)
				{
					foreach (int num in this.Lengths2)
					{
						list.Add(num);
					}
				}
				return list.ToArray();
			}
			set
			{
				List<int> list = new List<int>();
				checked
				{
					for (int i = 0; i < value.Length; i++)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(value[i]);
						if (objectValue is int)
						{
							list.Add(Conversions.ToInteger(objectValue));
						}
					}
					this.Lengths2 = list.ToArray();
				}
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00039738 File Offset: 0x00037938
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x00039740 File Offset: 0x00037940
		internal int[] Lengths2 { get; set; }

		/// <summary>
		/// 是否自动开启折叠模式
		/// </summary>
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00039749 File Offset: 0x00037949
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00039751 File Offset: 0x00037951
		public bool GridTree { get; set; }

		/// <summary>
		/// 设置折叠树默认展开级别
		/// </summary>
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0003975A File Offset: 0x0003795A
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00039762 File Offset: 0x00037962
		public int ExpandTo { get; set; }

		/// <summary>
		/// 指定要汇总的列
		/// </summary>
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0003976B File Offset: 0x0003796B
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x00039773 File Offset: 0x00037973
		public object[] AggregateCols { get; set; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x0003977C File Offset: 0x0003797C
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x00039784 File Offset: 0x00037984
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ValueCols { get; set; }

		/// <summary>
		/// 是否不允许重复行
		/// </summary>
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x0003978D File Offset: 0x0003798D
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00039795 File Offset: 0x00037995
		public bool Unique { get; set; }

		/// <summary>
		/// 排序列
		/// </summary>
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0003979E File Offset: 0x0003799E
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x000397A6 File Offset: 0x000379A6
		public string SortCol { get; set; }

		/// <summary>
		/// 是否降序排序
		/// </summary>
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x000397AF File Offset: 0x000379AF
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x000397B7 File Offset: 0x000379B7
		public bool SortDesc { get; set; }

		/// <summary>
		/// 是否使用样式区分分组行
		/// </summary>
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x000397C0 File Offset: 0x000379C0
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x000397C8 File Offset: 0x000379C8
		public bool UseStyle { get; set; }

		/// <summary>
		/// 是否合并显示统计结果
		/// </summary>
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x000397D1 File Offset: 0x000379D1
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x000397D9 File Offset: 0x000379D9
		public bool MergeTotal { get; set; }

		// Token: 0x04000236 RID: 566
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000237 RID: 567
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000238 RID: 568
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000239 RID: 569
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400023A RID: 570
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400023B RID: 571
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400023C RID: 572
		[CompilerGenerated]
		private char <<EMPTY_NAME>>;

		// Token: 0x0400023D RID: 573
		[CompilerGenerated]
		private int[] <<EMPTY_NAME>>;

		// Token: 0x0400023E RID: 574
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400023F RID: 575
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;

		// Token: 0x04000240 RID: 576
		[CompilerGenerated]
		private object[] <<EMPTY_NAME>>;

		// Token: 0x04000241 RID: 577
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000242 RID: 578
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000243 RID: 579
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000244 RID: 580
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000245 RID: 581
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000246 RID: 582
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;
	}
}
