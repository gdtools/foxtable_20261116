using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x020004A2 RID: 1186
	[oO0oooo("1110")]
	[OoO0___o("RibbonToggleButton")]
	internal class RibbonToggleButton : RibbonButton
	{
		// Token: 0x06005009 RID: 20489 RVA: 0x0023915A File Offset: 0x0023735A
		public RibbonToggleButton(DataRow A_0) : base(A_0)
		{
			this.O_._0____0OO_0. = true;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x0600500A RID: 20490 RVA: 0x00239172 File Offset: 0x00237372
		// (set) Token: 0x0600500B RID: 20491 RVA: 0x0023917A File Offset: 0x0023737A
		[DefaultValue(false)]
		[O_Oo00Oo000O0(1.2)]
		[Description("ToggleButton有两个状态，分别是按下和按起，此属性决定按钮是否处于按下状态。")]
		[Category("属性")]
		[DisplayName("按下")]
		public bool Pressed
		{
			get
			{
				return this.o_000O_o.oOo0.;
			}
			set
			{
				this.o_000O_o.oOo0. = value;
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x0600500C RID: 20492 RVA: 0x00239183 File Offset: 0x00237383
		// (set) Token: 0x0600500D RID: 20493 RVA: 0x0023918B File Offset: 0x0023738B
		[O_Oo00Oo000O0(1.202)]
		[Category("属性")]
		[DisplayName("所属分组名")]
		[Description("分组名相同的状态按钮，在同一时候只能有一个被按下，也就是说，按下其中一个按钮，之前被按下的按钮将自动弹起")]
		public string GroupName
		{
			get
			{
				return this.o_000O_o.oOo0.;
			}
			set
			{
				this.o_000O_o.oOo0. = value;
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x0600500E RID: 20494 RVA: 0x00239194 File Offset: 0x00237394
		// (set) Token: 0x0600500F RID: 20495 RVA: 0x0023919C File Offset: 0x0023739C
		[Category("事件")]
		[O_Oo00Oo000O0(1.1)]
		[Description("按钮状态(按下或按起)改变后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString PressedChanged
		{
			get
			{
				return this.o_000O_o.oOo0.;
			}
			set
			{
				this.o_000O_o.oOo0. = value;
			}
		}

		// Token: 0x040020B4 RID: 8372
		private bool <<EMPTY_NAME>>;

		// Token: 0x040020B5 RID: 8373
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040020B6 RID: 8374
		private string <<EMPTY_NAME>>;

		// Token: 0x040020B7 RID: 8375
		private bool <<EMPTY_NAME>>;
	}
}
