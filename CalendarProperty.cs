using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020002BE RID: 702
	internal class CalendarProperty : ControlPropertyBase
	{
		// Token: 0x06002635 RID: 9781 RVA: 0x0011A83B File Offset: 0x00118A3B
		public CalendarProperty(ControlHolder A_0) : base(A_0)
		{
			this.o.o___O0O_O. = (MonthCalendar)A_0.ChildControl;
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x0011A855 File Offset: 0x00118A55
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x0011A862 File Offset: 0x00118A62
		[MergableProperty(true)]
		[O_Oo00Oo000O0(0.1)]
		[DisplayName("显示今天")]
		[Category("外观")]
		[DefaultValue(true)]
		public bool ShowToday
		{
			get
			{
				return this.o.o___O0O_O..ShowToday;
			}
			set
			{
				this.o.o___O0O_O..ShowToday = value;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x0011A870 File Offset: 0x00118A70
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x0011A87D File Offset: 0x00118A7D
		[DisplayName("标出今天")]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(0.2)]
		[Category("外观")]
		[MergableProperty(true)]
		public bool ShowTodayCircle
		{
			get
			{
				return this.o.o___O0O_O..ShowTodayCircle;
			}
			set
			{
				this.o.o___O0O_O..ShowTodayCircle = value;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x0011A88B File Offset: 0x00118A8B
		// (set) Token: 0x0600263B RID: 9787 RVA: 0x0011A898 File Offset: 0x00118A98
		[MergableProperty(true)]
		[DisplayName("显示周数")]
		[Category("外观")]
		[O_Oo00Oo000O0(0.3)]
		[DefaultValue(false)]
		public bool ShowWeekNumbers
		{
			get
			{
				return this.o.o___O0O_O..ShowWeekNumbers;
			}
			set
			{
				this.o.o___O0O_O..ShowWeekNumbers = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x0011A8A6 File Offset: 0x00118AA6
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x0011A8B3 File Offset: 0x00118AB3
		[DisplayName("每周第一天")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(0.5)]
		[Category("外观")]
		[DefaultValue(0)]
		public Day FirstDayOfWeek
		{
			get
			{
				return this.o.o___O0O_O..FirstDayOfWeek;
			}
			set
			{
				this.o.o___O0O_O..FirstDayOfWeek = value;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x0011A8C4 File Offset: 0x00118AC4
		// (set) Token: 0x0600263F RID: 9791 RVA: 0x0011A8E4 File Offset: 0x00118AE4
		[O_Oo00Oo000O0(0.6)]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(1)]
		[DisplayName("水平月数")]
		public int XMonths
		{
			get
			{
				return this.o.o___O0O_O..CalendarDimensions.Width;
			}
			set
			{
				this.o.o___O0O_O..CalendarDimensions = new Size(value, this.o.o___O0O_O..CalendarDimensions.Height);
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x0011A918 File Offset: 0x00118B18
		// (set) Token: 0x06002641 RID: 9793 RVA: 0x0011A938 File Offset: 0x00118B38
		[MergableProperty(true)]
		[O_Oo00Oo000O0(0.7)]
		[DisplayName("垂直月数")]
		[DefaultValue(1)]
		[Category("外观")]
		public int YMonths
		{
			get
			{
				return this.o.o___O0O_O..CalendarDimensions.Height;
			}
			set
			{
				this.o.o___O0O_O..CalendarDimensions = new Size(this.o.o___O0O_O..CalendarDimensions.Width, value);
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x0011A969 File Offset: 0x00118B69
		// (set) Token: 0x06002643 RID: 9795 RVA: 0x0011A976 File Offset: 0x00118B76
		[DisplayName("标题背景颜色")]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(-16777216)]
		[O_Oo00Oo000O0(2.1)]
		public Color TitleBackColor
		{
			get
			{
				return this.o.o___O0O_O..TitleBackColor;
			}
			set
			{
				this.o.o___O0O_O..TitleBackColor = value;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x0011A984 File Offset: 0x00118B84
		// (set) Token: 0x06002645 RID: 9797 RVA: 0x0011A991 File Offset: 0x00118B91
		[DefaultValue(-16777216)]
		[O_Oo00Oo000O0(2.2)]
		[DisplayName("标题字体颜色")]
		[Category("外观")]
		[MergableProperty(true)]
		public Color TitleForeColor
		{
			get
			{
				return this.o.o___O0O_O..TitleForeColor;
			}
			set
			{
				this.o.o___O0O_O..TitleForeColor = value;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x0011A99F File Offset: 0x00118B9F
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x0011A9AC File Offset: 0x00118BAC
		[O_Oo00Oo000O0(2.3)]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(-16777216)]
		[DisplayName("非本月日期颜色")]
		public Color TrailingForeColor
		{
			get
			{
				return this.o.o___O0O_O..TrailingForeColor;
			}
			set
			{
				this.o.o___O0O_O..TrailingForeColor = value;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x0011A9BA File Offset: 0x00118BBA
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x0011A9C2 File Offset: 0x00118BC2
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("选定日期发生变化后执行")]
		[oO0oooo("2120")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.2)]
		public EventString DateChanged
		{
			get
			{
				return this.OO0_0oOo.o.;
			}
			set
			{
				this.OO0_0oOo.o. = value;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x0011A9CB File Offset: 0x00118BCB
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x0011A9D3 File Offset: 0x00118BD3
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("用鼠标选定日期后执行")]
		[oO0oooo("2120")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.2)]
		public EventString DateSelected
		{
			get
			{
				return this.ooO_.0O00.;
			}
			set
			{
				this.ooO_.0O00. = value;
			}
		}

		// Token: 0x04000FD8 RID: 4056
		private MonthCalendar <<EMPTY_NAME>>;

		// Token: 0x04000FD9 RID: 4057
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000FDA RID: 4058
		private EventString <<EMPTY_NAME>>;
	}
}
