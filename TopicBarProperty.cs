using System;
using System.ComponentModel;
using System.Drawing.Design;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x02000426 RID: 1062
	internal class TopicBarProperty : ControlPropertyBase
	{
		// Token: 0x0600485F RID: 18527 RVA: 0x001F4526 File Offset: 0x001F2726
		public TopicBarProperty(ControlHolder A_0) : base(A_0)
		{
			this.O._oooo0__. = (Oo_)A_0.ChildControl;
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x001F4540 File Offset: 0x001F2740
		// (set) Token: 0x06004861 RID: 18529 RVA: 0x001F454E File Offset: 0x001F274E
		[OooO0(false)]
		[Browsable(false)]
		public VisualStyle VisualStyle
		{
			get
			{
				VisualStyle result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06004862 RID: 18530 RVA: 0x001F4550 File Offset: 0x001F2750
		// (set) Token: 0x06004863 RID: 18531 RVA: 0x001F4562 File Offset: 0x001F2762
		[DisplayName("样式")]
		[TypeConverter(typeof(o00))]
		[O_Oo00Oo000O0(0.0)]
		[Category("外观")]
		[DefaultValue("(default)")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.O._oooo0__.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.O._oooo0__.
				});
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06004864 RID: 18532 RVA: 0x001F457E File Offset: 0x001F277E
		// (set) Token: 0x06004865 RID: 18533 RVA: 0x001F4586 File Offset: 0x001F2786
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("单击命令连接后执行")]
		[oO0oooo("0869")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.0)]
		public EventString TopicLinkClick
		{
			get
			{
				return this.o.Ooo_0__0Oo.;
			}
			set
			{
				this.o.Ooo_0__0Oo. = value;
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06004866 RID: 18534 RVA: 0x001F458F File Offset: 0x001F278F
		// (set) Token: 0x06004867 RID: 18535 RVA: 0x001F4597 File Offset: 0x001F2797
		[Description("展开页面后执行")]
		[oO0oooo("2133")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.0)]
		public EventString TopicPageExpanded
		{
			get
			{
				return this.O00___._OO_.;
			}
			set
			{
				this.O00___._OO_. = value;
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06004868 RID: 18536 RVA: 0x001F45A0 File Offset: 0x001F27A0
		// (set) Token: 0x06004869 RID: 18537 RVA: 0x001F45A8 File Offset: 0x001F27A8
		[oO0oooo("2134")]
		[Category("事件")]
		[Description("收缩页面后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(0.0)]
		[O0O0oOO00_0OO(true)]
		public EventString TopicPageCollapsed
		{
			get
			{
				return this.O0_.__o_.;
			}
			set
			{
				this.O0_.__o_. = value;
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x0600486A RID: 18538 RVA: 0x001F45B1 File Offset: 0x001F27B1
		// (set) Token: 0x0600486B RID: 18539 RVA: 0x001F45B9 File Offset: 0x001F27B9
		[Browsable(false)]
		public string Setting
		{
			get
			{
				return this.o.Ooo_0__0Oo.;
			}
			set
			{
				this.o.Ooo_0__0Oo. = value;
				oOO0oo_o0.O.ooooo.(this.O._oooo0__., value);
			}
		}

		// Token: 0x04001D32 RID: 7474
		internal Oo_ <<EMPTY_NAME>>;

		// Token: 0x04001D33 RID: 7475
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D34 RID: 7476
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D35 RID: 7477
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D36 RID: 7478
		private string <<EMPTY_NAME>>;
	}
}
