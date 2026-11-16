using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x020004A6 RID: 1190
	[oO0oooo("3092")]
	[OoO0___o("RibbonTrackBar")]
	internal class RibbonTrackBar : RibbonItem
	{
		// Token: 0x06005018 RID: 20504 RVA: 0x0023920C File Offset: 0x0023740C
		public RibbonTrackBar(DataRow A_0) : base(A_0)
		{
			this.O0.o0__OOo00O. = 50;
			this.o0_o.o. = 100;
			this.oO_O_000.ooo. = 0;
			this.O.Ooo_Oo_oo. = 150;
			this.O_O0oO.0O0OO. = 25;
			this.o0O.o_ooo0_O. = 5;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x06005019 RID: 20505 RVA: 0x00239259 File Offset: 0x00237459
		// (set) Token: 0x0600501A RID: 20506 RVA: 0x00239261 File Offset: 0x00237461
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		[DisplayName("初始值")]
		public int Value
		{
			get
			{
				return this.O0.o0__OOo00O.;
			}
			set
			{
				this.O0.o0__OOo00O. = value;
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x0600501B RID: 20507 RVA: 0x0023926A File Offset: 0x0023746A
		// (set) Token: 0x0600501C RID: 20508 RVA: 0x00239272 File Offset: 0x00237472
		[DisplayName("最小值")]
		[O_Oo00Oo000O0(1.2)]
		[Category("属性")]
		public int Minimum
		{
			get
			{
				return this.oO_O_000.ooo.;
			}
			set
			{
				this.oO_O_000.ooo. = value;
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x0600501D RID: 20509 RVA: 0x0023927B File Offset: 0x0023747B
		// (set) Token: 0x0600501E RID: 20510 RVA: 0x00239283 File Offset: 0x00237483
		[Category("属性")]
		[O_Oo00Oo000O0(1.3)]
		[DisplayName("最大值")]
		public int Maximum
		{
			get
			{
				return this.o0_o.o.;
			}
			set
			{
				this.o0_o.o. = value;
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x0600501F RID: 20511 RVA: 0x0023928C File Offset: 0x0023748C
		// (set) Token: 0x06005020 RID: 20512 RVA: 0x00239294 File Offset: 0x00237494
		[Category("属性")]
		[DisplayName("刻度间隔")]
		[Description("两个刻度之间的间隔值。")]
		[O_Oo00Oo000O0(1.4)]
		public int TickFrequency
		{
			get
			{
				return this.O_O0oO.0O0OO.;
			}
			set
			{
				this.O_O0oO.0O0OO. = value;
			}
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06005021 RID: 20513 RVA: 0x0023929D File Offset: 0x0023749D
		// (set) Token: 0x06005022 RID: 20514 RVA: 0x002392A5 File Offset: 0x002374A5
		[Category("属性")]
		[Description("单击加减按钮时值改变的幅度。")]
		[O_Oo00Oo000O0(1.5)]
		[DisplayName("步长")]
		public int StepFrequency
		{
			get
			{
				return this.o0O.o_ooo0_O.;
			}
			set
			{
				this.o0O.o_ooo0_O. = value;
			}
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06005023 RID: 20515 RVA: 0x002392AE File Offset: 0x002374AE
		// (set) Token: 0x06005024 RID: 20516 RVA: 0x002392B6 File Offset: 0x002374B6
		[O_Oo00Oo000O0(1.6)]
		[DisplayName("宽度")]
		[Category("属性")]
		public int Width
		{
			get
			{
				return this.O.Ooo_Oo_oo.;
			}
			set
			{
				this.O.Ooo_Oo_oo. = value;
			}
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06005025 RID: 20517 RVA: 0x002392BF File Offset: 0x002374BF
		// (set) Token: 0x06005026 RID: 20518 RVA: 0x002392C7 File Offset: 0x002374C7
		[O_Oo00Oo000O0(0.1)]
		[O0O0oOO00_0OO(true)]
		[Category("事件")]
		[Description("当前值改变后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString ValueChanged
		{
			get
			{
				return this.O0.o0__OOo00O.;
			}
			set
			{
				this.O0.o0__OOo00O. = value;
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x06005027 RID: 20519 RVA: 0x002392D0 File Offset: 0x002374D0
		// (set) Token: 0x06005028 RID: 20520 RVA: 0x002392D3 File Offset: 0x002374D3
		[Browsable(false)]
		public new string LargeImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x06005029 RID: 20521 RVA: 0x002392D5 File Offset: 0x002374D5
		// (set) Token: 0x0600502A RID: 20522 RVA: 0x002392D8 File Offset: 0x002374D8
		[Browsable(false)]
		public new string SmallImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x0600502B RID: 20523 RVA: 0x002392DC File Offset: 0x002374DC
		// (set) Token: 0x0600502C RID: 20524 RVA: 0x002392EA File Offset: 0x002374EA
		[Browsable(false)]
		public new bool AutoHideText
		{
			get
			{
				bool result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x0600502D RID: 20525 RVA: 0x002392EC File Offset: 0x002374EC
		// (set) Token: 0x0600502E RID: 20526 RVA: 0x002392FA File Offset: 0x002374FA
		[Browsable(false)]
		public new TextImageRelationEnum TextImageRelation
		{
			get
			{
				TextImageRelationEnum result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x040020BA RID: 8378
		private int <<EMPTY_NAME>>;

		// Token: 0x040020BB RID: 8379
		private int <<EMPTY_NAME>>;

		// Token: 0x040020BC RID: 8380
		private int <<EMPTY_NAME>>;

		// Token: 0x040020BD RID: 8381
		private int <<EMPTY_NAME>>;

		// Token: 0x040020BE RID: 8382
		private int <<EMPTY_NAME>>;

		// Token: 0x040020BF RID: 8383
		private int <<EMPTY_NAME>>;

		// Token: 0x040020C0 RID: 8384
		private EventString <<EMPTY_NAME>>;
	}
}
