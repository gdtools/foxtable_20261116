using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 汇总模式分组
	/// </summary>
	// Token: 0x020000A6 RID: 166
	[ComVisible(true)]
	[oO0oooo("1372")]
	public class SubtotalGroup
	{
		// Token: 0x06000678 RID: 1656 RVA: 0x0003015F File Offset: 0x0002E35F
		public SubtotalGroup()
		{
			this.oO0O_0.ooo00. = "";
			this.oOo0.0_. = "";
			this.O_oo.0oOO. = AggregateEnum.Sum;
			this.O_oo.0oOO. = DateGroupEnum.Month;
		}

		/// <summary>
		/// 指定分组列，如果是总计分组，用星符号(*)表示
		/// </summary>
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0003018B File Offset: 0x0002E38B
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00030193 File Offset: 0x0002E393
		public string GroupOn
		{
			get
			{
				return this.oO0O_0.ooo00.;
			}
			set
			{
				this.oO0O_0.ooo00. = value;
			}
		}

		/// <summary>
		/// 指定统计列，如果要对多列统计，列与列之间用逗号分隔。
		/// </summary>
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x0003019C File Offset: 0x0002E39C
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x000301A4 File Offset: 0x0002E3A4
		public string TotalOn
		{
			get
			{
				return this.oOo0.0_.;
			}
			set
			{
				this.oOo0.0_. = value;
			}
		}

		/// <summary>
		/// 指定统计类型
		/// </summary>
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x000301B0 File Offset: 0x0002E3B0
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x000301E5 File Offset: 0x0002E3E5
		[oO0oooo("3292")]
		public AggregateEnum Aggregate
		{
			get
			{
				AggregateEnum result;
				if (Enum.IsDefined(typeof(AggregateEnum), this.O_oo.0oOO.))
				{
					result = this.O_oo.0oOO.;
				}
				else
				{
					result = AggregateEnum.Sum;
				}
				return result;
			}
			set
			{
				this.O_oo.0oOO. = value;
			}
		}

		/// <summary>
		/// 用于指定标题，用"{0}"表示分组名称
		/// </summary>
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x000301EE File Offset: 0x0002E3EE
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x000301F6 File Offset: 0x0002E3F6
		[oO0oooo("3296")]
		public string Caption
		{
			get
			{
				return this.o.O_0_00__0.;
			}
			set
			{
				this.o.O_0_00__0. = value;
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00030200 File Offset: 0x0002E400
		internal string <<EMPTY_NAME>>(Table A_0)
		{
			string text = "";
			string text2 = "";
			switch (this.Aggregate)
			{
			case AggregateEnum.Sum:
			case AggregateEnum.Percent:
			case AggregateEnum.Count:
				if (this.upto)
				{
					text = "累计";
				}
				else
				{
					text = "小计";
				}
				text2 = "总计";
				break;
			case AggregateEnum.Average:
				text = "平均";
				text2 = "平均";
				break;
			case AggregateEnum.Max:
				text = "最大";
				text2 = "最大";
				break;
			case AggregateEnum.Min:
				text = "最小";
				text2 = "最小";
				break;
			case AggregateEnum.Std:
				text = "标准偏差";
				text2 = "标准偏差";
				break;
			case AggregateEnum.Var:
				text = "采样方差";
				text2 = "采样方差";
				break;
			case AggregateEnum.StdPop:
				text = "总体标准差";
				text2 = "总体标准差";
				break;
			case AggregateEnum.VarPop:
				text = "总体方差";
				text2 = "总体方差";
				break;
			}
			if (Operators.CompareString(this.GroupOn, "*", true) != 0 && A_0.Cols[this.GroupOn].IsDate())
			{
				switch (this.DateGroup)
				{
				case DateGroupEnum.Year:
					text = "{0}年 " + text;
					break;
				case DateGroupEnum.Quarter:
					text = "{0}季 " + text;
					break;
				case DateGroupEnum.Month:
					text = "{0}月 " + text;
					break;
				case DateGroupEnum.Week:
					text = "{0}周 " + text;
					break;
				case DateGroupEnum.Day:
					text = "{0}日 " + text;
					break;
				case DateGroupEnum.Hour:
					text = "{0}时 " + text;
					break;
				case DateGroupEnum.Minute:
					text = "{0}分 " + text;
					break;
				case DateGroupEnum.Second:
					text = "{0}秒 " + text;
					break;
				default:
					text = "{0} " + text;
					break;
				}
			}
			else
			{
				text = "{0} " + text;
			}
			string result;
			if (Operators.CompareString(this.GroupOn, "*", true) == 0)
			{
				result = text2;
			}
			else
			{
				result = text;
			}
			return result;
		}

		/// <summary>
		/// 指定日期列的分组方式
		/// </summary>
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x000303DC File Offset: 0x0002E5DC
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x000303E4 File Offset: 0x0002E5E4
		[oO0oooo("3291")]
		public DateGroupEnum DateGroup
		{
			get
			{
				return this.O_oo.0oOO.;
			}
			set
			{
				this.O_oo.0oOO. = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x000303ED File Offset: 0x0002E5ED
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x000303F5 File Offset: 0x0002E5F5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Level
		{
			get
			{
				return this.oO0O_0.ooo00.;
			}
			set
			{
				this.oO0O_0.ooo00. = value;
			}
		}

		/// <summary>
		/// 是否是截止统计
		/// </summary>
		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x000303FE File Offset: 0x0002E5FE
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00030406 File Offset: 0x0002E606
		[oO0oooo("3293")]
		public bool upto
		{
			get
			{
				return this.oO0O_0.ooo00.;
			}
			set
			{
				this.oO0O_0.ooo00. = value;
			}
		}

		// Token: 0x040001BB RID: 443
		private string <<EMPTY_NAME>>;

		// Token: 0x040001BC RID: 444
		private string <<EMPTY_NAME>>;

		// Token: 0x040001BD RID: 445
		private AggregateEnum <<EMPTY_NAME>>;

		// Token: 0x040001BE RID: 446
		private string <<EMPTY_NAME>>;

		// Token: 0x040001BF RID: 447
		private DateGroupEnum <<EMPTY_NAME>>;

		// Token: 0x040001C0 RID: 448
		private bool <<EMPTY_NAME>>;

		// Token: 0x040001C1 RID: 449
		private int <<EMPTY_NAME>>;

		// Token: 0x040001C2 RID: 450
		internal int <<EMPTY_NAME>>;
	}
}
