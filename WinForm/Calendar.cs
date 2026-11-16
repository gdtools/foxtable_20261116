using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 月历
	/// </summary>
	// Token: 0x0200050F RID: 1295
	[ComVisible(true)]
	[oO0oooo("2119")]
	public class Calendar : Control
	{
		// Token: 0x0600549D RID: 21661 RVA: 0x00258715 File Offset: 0x00256915
		public Calendar(MonthCalendar A_0) : base(A_0, ControlTypeEnum.Calendar)
		{
			this.OOoo0_0.0__OO. = A_0;
		}

		/// <summary>
		/// 是否在月历的底部显示今天的日期
		/// </summary>
		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x0600549E RID: 21662 RVA: 0x00258727 File Offset: 0x00256927
		// (set) Token: 0x0600549F RID: 21663 RVA: 0x00258734 File Offset: 0x00256934
		public bool ShowToday
		{
			get
			{
				return this.OOoo0_0.0__OO..ShowToday;
			}
			set
			{
				this.OOoo0_0.0__OO..ShowToday = value;
			}
		}

		/// <summary>
		/// 是否在月历中用一个圆圈标出今天的日期
		/// </summary>
		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x060054A0 RID: 21664 RVA: 0x00258742 File Offset: 0x00256942
		// (set) Token: 0x060054A1 RID: 21665 RVA: 0x0025874F File Offset: 0x0025694F
		public bool ShowTodayCircle
		{
			get
			{
				return this.OOoo0_0.0__OO..ShowTodayCircle;
			}
			set
			{
				this.OOoo0_0.0__OO..ShowTodayCircle = value;
			}
		}

		/// <summary>
		/// 是否在月历的左边显示周数
		/// </summary>
		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x060054A2 RID: 21666 RVA: 0x0025875D File Offset: 0x0025695D
		// (set) Token: 0x060054A3 RID: 21667 RVA: 0x0025876A File Offset: 0x0025696A
		public bool ShowWeekNumbers
		{
			get
			{
				return this.OOoo0_0.0__OO..ShowWeekNumbers;
			}
			set
			{
				this.OOoo0_0.0__OO..ShowWeekNumbers = value;
			}
		}

		/// <summary>
		/// 设置在月历中可选择的最大天数
		/// </summary>
		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x060054A4 RID: 21668 RVA: 0x00258778 File Offset: 0x00256978
		// (set) Token: 0x060054A5 RID: 21669 RVA: 0x00258785 File Offset: 0x00256985
		public int MaxSelectionCount
		{
			get
			{
				return this.OOoo0_0.0__OO..MaxSelectionCount;
			}
			set
			{
				this.OOoo0_0.0__OO..MaxSelectionCount = value;
			}
		}

		/// <summary>
		/// 设置月历中每周的第一天
		/// </summary>
		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x00258793 File Offset: 0x00256993
		// (set) Token: 0x060054A7 RID: 21671 RVA: 0x002587A0 File Offset: 0x002569A0
		public Day FirstDayOfWeek
		{
			get
			{
				return this.OOoo0_0.0__OO..FirstDayOfWeek;
			}
			set
			{
				this.OOoo0_0.0__OO..FirstDayOfWeek = value;
			}
		}

		/// <summary>
		/// 设置月历水平方向显示的月数
		/// </summary>
		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x060054A8 RID: 21672 RVA: 0x002587B0 File Offset: 0x002569B0
		// (set) Token: 0x060054A9 RID: 21673 RVA: 0x002587D0 File Offset: 0x002569D0
		public int XMonths
		{
			get
			{
				return this.OOoo0_0.0__OO..CalendarDimensions.Width;
			}
			set
			{
				this.OOoo0_0.0__OO..CalendarDimensions = new Size(value, this.OOoo0_0.0__OO..CalendarDimensions.Height);
			}
		}

		/// <summary>
		/// 设置月历垂直方向显示的月数
		/// </summary>
		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x060054AA RID: 21674 RVA: 0x00258804 File Offset: 0x00256A04
		// (set) Token: 0x060054AB RID: 21675 RVA: 0x00258824 File Offset: 0x00256A24
		public int YMonths
		{
			get
			{
				return this.OOoo0_0.0__OO..CalendarDimensions.Height;
			}
			set
			{
				this.OOoo0_0.0__OO..CalendarDimensions = new Size(this.OOoo0_0.0__OO..CalendarDimensions.Width, value);
			}
		}

		/// <summary>
		/// 设置月历标题区域的背景颜色
		/// </summary>
		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x060054AC RID: 21676 RVA: 0x00258855 File Offset: 0x00256A55
		// (set) Token: 0x060054AD RID: 21677 RVA: 0x00258862 File Offset: 0x00256A62
		public Color TitleBackColor
		{
			get
			{
				return this.OOoo0_0.0__OO..TitleBackColor;
			}
			set
			{
				this.OOoo0_0.0__OO..TitleBackColor = value;
			}
		}

		/// <summary>
		/// 设置月历标题的字体颜色
		/// </summary>
		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x060054AE RID: 21678 RVA: 0x00258870 File Offset: 0x00256A70
		// (set) Token: 0x060054AF RID: 21679 RVA: 0x0025887D File Offset: 0x00256A7D
		public Color TitleForeColor
		{
			get
			{
				return this.OOoo0_0.0__OO..TitleForeColor;
			}
			set
			{
				this.OOoo0_0.0__OO..TitleForeColor = value;
			}
		}

		/// <summary>
		/// 在月历中出现的非本月日期的字体颜色
		/// </summary>
		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x060054B0 RID: 21680 RVA: 0x0025888B File Offset: 0x00256A8B
		// (set) Token: 0x060054B1 RID: 21681 RVA: 0x00258898 File Offset: 0x00256A98
		public Color TrailingForeColor
		{
			get
			{
				return this.OOoo0_0.0__OO..TrailingForeColor;
			}
			set
			{
				this.OOoo0_0.0__OO..TrailingForeColor = value;
			}
		}

		/// <summary>
		/// 返回控件宽度
		/// </summary>
		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x060054B2 RID: 21682 RVA: 0x002588A6 File Offset: 0x00256AA6
		// (set) Token: 0x060054B3 RID: 21683 RVA: 0x002588B3 File Offset: 0x00256AB3
		public virtual int Width
		{
			get
			{
				return this.OOoo0_0.0__OO..Width;
			}
			set
			{
			}
		}

		/// <summary>
		/// 返回控件高度
		/// </summary>
		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x060054B4 RID: 21684 RVA: 0x002588B5 File Offset: 0x00256AB5
		// (set) Token: 0x060054B5 RID: 21685 RVA: 0x002588C2 File Offset: 0x00256AC2
		public virtual int Height
		{
			get
			{
				return this.OOoo0_0.0__OO..Height;
			}
			set
			{
			}
		}

		/// <summary>
		/// 返回或设置Calendar选择的日期
		/// </summary>
		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x060054B6 RID: 21686 RVA: 0x002588C4 File Offset: 0x00256AC4
		// (set) Token: 0x060054B7 RID: 21687 RVA: 0x002588D1 File Offset: 0x00256AD1
		public DateTime Value
		{
			get
			{
				return this.OOoo0_0.0__OO..SelectionStart;
			}
			set
			{
				this.OOoo0_0.0__OO..SelectionStart = value;
			}
		}

		// Token: 0x040022B7 RID: 8887
		private MonthCalendar <<EMPTY_NAME>>;
	}
}
