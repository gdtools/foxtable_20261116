using System;
using System.ComponentModel;
using System.Drawing.Design;
using C1.Win.C1Input;

namespace Foxtable
{
	// Token: 0x020002BF RID: 703
	internal class DropDownBoxProperty : TextBoxProperty
	{
		// Token: 0x0600264C RID: 9804 RVA: 0x0011A9DC File Offset: 0x00118BDC
		public DropDownBoxProperty(ControlHolder A_0) : base(A_0)
		{
			this.o.O_OO. = true;
			this.oO.0. = (C1DropDownControl)A_0.ChildControl;
			this.oO.0..VerticalAlign = VerticalAlignEnum.Middle;
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x0011AA09 File Offset: 0x00118C09
		// (set) Token: 0x0600264E RID: 9806 RVA: 0x0011AA11 File Offset: 0x00118C11
		[Category("基本")]
		[O_Oo00Oo000O0(2.9)]
		[TypeConverter(typeof(O__000__Oo0))]
		[DisplayName("下拉窗口")]
		[MergableProperty(true)]
		public string DropFormName
		{
			get
			{
				return this.o.O_OO.;
			}
			set
			{
				this.o.O_OO. = value;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x0600264F RID: 9807 RVA: 0x0011AA1A File Offset: 0x00118C1A
		// (set) Token: 0x06002650 RID: 9808 RVA: 0x0011AA27 File Offset: 0x00118C27
		[Category("基本")]
		[DisplayName("显示下拉按钮")]
		[MergableProperty(true)]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(3.0)]
		public bool ShowDropDownButton
		{
			get
			{
				return this.oO.0..ShowDropDownButton;
			}
			set
			{
				this.oO.0..ShowDropDownButton = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06002651 RID: 9809 RVA: 0x0011AA35 File Offset: 0x00118C35
		// (set) Token: 0x06002652 RID: 9810 RVA: 0x0011AA42 File Offset: 0x00118C42
		[Category("基本")]
		[O_Oo00Oo000O0(4.0)]
		[MergableProperty(true)]
		[DefaultValue(false)]
		[DisplayName("显示微调按钮")]
		public bool ShowUpDownButtons
		{
			get
			{
				return this.oO.0..ShowUpDownButtons;
			}
			set
			{
				this.oO.0..ShowUpDownButtons = value;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06002653 RID: 9811 RVA: 0x0011AA50 File Offset: 0x00118C50
		// (set) Token: 0x06002654 RID: 9812 RVA: 0x0011AA5D File Offset: 0x00118C5D
		[O_Oo00Oo000O0(5.0)]
		[MergableProperty(true)]
		[DefaultValue(false)]
		[DisplayName("显示命令按钮")]
		[Category("基本")]
		public bool ShowModalButton
		{
			get
			{
				return this.oO.0..ShowModalButton;
			}
			set
			{
				this.oO.0..ShowModalButton = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x0011AA6B File Offset: 0x00118C6B
		// (set) Token: 0x06002656 RID: 9814 RVA: 0x0011AA73 File Offset: 0x00118C73
		[Description("是否允许用户直接输入内容")]
		[O_Oo00Oo000O0(6.0)]
		[MergableProperty(true)]
		[DefaultValue(true)]
		[DisplayName("允许直接输入")]
		[Category("基本")]
		public bool AllowEditValue
		{
			get
			{
				return this.o.O_OO.;
			}
			set
			{
				this.o.O_OO. = value;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x0011AA7C File Offset: 0x00118C7C
		// (set) Token: 0x06002658 RID: 9816 RVA: 0x0011AA84 File Offset: 0x00118C84
		[oO0oooo("2109")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("单击向上微调按钮后执行")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.2)]
		public EventString UpDownButtonClick
		{
			get
			{
				return this.oO.0.;
			}
			set
			{
				this.oO.0. = value;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x0011AA8D File Offset: 0x00118C8D
		// (set) Token: 0x0600265A RID: 9818 RVA: 0x0011AA95 File Offset: 0x00118C95
		[oO0oooo("2110")]
		[Category("事件")]
		[Description("单击命令按钮后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.3)]
		public EventString ModalButtonClick
		{
			get
			{
				return this.OO0__.O0oO0o_o.;
			}
			set
			{
				this.OO0__.O0oO0o_o. = value;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x0600265B RID: 9819 RVA: 0x0011AA9E File Offset: 0x00118C9E
		// (set) Token: 0x0600265C RID: 9820 RVA: 0x0011AAA1 File Offset: 0x00118CA1
		[OooO0(true)]
		[Browsable(false)]
		public new bool MultiLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x04000FDB RID: 4059
		private C1DropDownControl <<EMPTY_NAME>>;

		// Token: 0x04000FDC RID: 4060
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000FDD RID: 4061
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000FDE RID: 4062
		private string <<EMPTY_NAME>>;

		// Token: 0x04000FDF RID: 4063
		private bool <<EMPTY_NAME>>;
	}
}
