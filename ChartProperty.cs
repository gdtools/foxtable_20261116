using System;
using System.ComponentModel;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x0200040A RID: 1034
	internal class ChartProperty : ControlPropertyBase
	{
		// Token: 0x0600444A RID: 17482 RVA: 0x001F0769 File Offset: 0x001EE969
		public ChartProperty(ControlHolder A_0) : base(A_0)
		{
			this.o000o.OOoOoo. = (OO___O_)A_0.ChildControl;
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x0600444B RID: 17483 RVA: 0x001F0783 File Offset: 0x001EE983
		// (set) Token: 0x0600444C RID: 17484 RVA: 0x001F078B File Offset: 0x001EE98B
		[Description("单击某个图系或数据点后执行")]
		[oO0oooo("6014")]
		[Category("鼠标")]
		[DisplayName("Click")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.0)]
		public EventString ChartClick
		{
			get
			{
				return this.o000o.OOoOoo.;
			}
			set
			{
				this.o000o.OOoOoo. = value;
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x0600444D RID: 17485 RVA: 0x001F0794 File Offset: 0x001EE994
		// (set) Token: 0x0600444E RID: 17486 RVA: 0x001F079C File Offset: 0x001EE99C
		[DisplayName("DoubleClick")]
		[Category("鼠标")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("双击某个图系或数据点后执行")]
		[oO0oooo("6014")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(2.0)]
		public EventString ChartDoubleClick
		{
			get
			{
				return this.O_0.OO.;
			}
			set
			{
				this.O_0.OO. = value;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x0600444F RID: 17487 RVA: 0x001F07A5 File Offset: 0x001EE9A5
		// (set) Token: 0x06004450 RID: 17488 RVA: 0x001F07AD File Offset: 0x001EE9AD
		[DisplayName("MouseHover")]
		[oO0oooo("6014")]
		[Category("鼠标")]
		[Description("鼠标悬停在某个图系或数据点后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(3.0)]
		public EventString ChartMouseHover
		{
			get
			{
				return this.OOO.0O__OOO00_.;
			}
			set
			{
				this.OOO.0O__OOO00_. = value;
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06004451 RID: 17489 RVA: 0x001F07B6 File Offset: 0x001EE9B6
		// (set) Token: 0x06004452 RID: 17490 RVA: 0x001F07BE File Offset: 0x001EE9BE
		[oO0oooo("6014")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("鼠标")]
		[DisplayName("MouseDown")]
		[Description("在某个图系或数据点上按下鼠标后执行")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(4.0)]
		public EventString ChartMouseDown
		{
			get
			{
				return this.oo_.o0.;
			}
			set
			{
				this.oo_.o0. = value;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06004453 RID: 17491 RVA: 0x001F07C7 File Offset: 0x001EE9C7
		// (set) Token: 0x06004454 RID: 17492 RVA: 0x001F07CF File Offset: 0x001EE9CF
		[oO0oooo("6014")]
		[Description("在某个图系或数据点上松开鼠标后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("鼠标")]
		[DisplayName("MouseUp")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(5.0)]
		public EventString ChartMouseUp
		{
			get
			{
				return this.o_o_o.o_00.;
			}
			set
			{
				this.o_o_o.o_00. = value;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06004455 RID: 17493 RVA: 0x001F07D8 File Offset: 0x001EE9D8
		// (set) Token: 0x06004456 RID: 17494 RVA: 0x001F07E0 File Offset: 0x001EE9E0
		[oO0oooo("6014")]
		[O_Oo00Oo000O0(6.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("鼠标")]
		[O0O0oOO00_0OO(true)]
		[Description("鼠标经过某个图系或数据点时执行")]
		[DisplayName("MouseMove")]
		public EventString ChartMouseMove
		{
			get
			{
				return this.o0.0oOO0.;
			}
			set
			{
				this.o0.0oOO0. = value;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06004457 RID: 17495 RVA: 0x001F07E9 File Offset: 0x001EE9E9
		// (set) Token: 0x06004458 RID: 17496 RVA: 0x001F07F1 File Offset: 0x001EE9F1
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("6014")]
		[Category("提示")]
		[DisplayName("ShowTooltip")]
		[Description("显示提示信息时执行")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(6.0)]
		public EventString ChartShowTooltip
		{
			get
			{
				return this.o_0.o_.;
			}
			set
			{
				this.o_0.o_. = value;
			}
		}

		// Token: 0x04001BC9 RID: 7113
		private OO___O_ <<EMPTY_NAME>>;

		// Token: 0x04001BCA RID: 7114
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001BCB RID: 7115
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001BCC RID: 7116
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001BCD RID: 7117
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001BCE RID: 7118
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001BCF RID: 7119
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001BD0 RID: 7120
		private EventString <<EMPTY_NAME>>;
	}
}
