using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x0200049F RID: 1183
	[OoO0___o("RibbonTab")]
	[oO0oooo("1086")]
	internal class RibbonTab : RibbonBase
	{
		// Token: 0x06004FEA RID: 20458 RVA: 0x0023901E File Offset: 0x0023721E
		public RibbonTab(DataRow A_0) : base(A_0)
		{
			this.OO.00o___0o. = true;
			this.OO_oOo0oo0.oO. = true;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06004FEB RID: 20459 RVA: 0x0023903D File Offset: 0x0023723D
		// (set) Token: 0x06004FEC RID: 20460 RVA: 0x00239045 File Offset: 0x00237245
		[Category("属性")]
		[DisplayName("功能区组")]
		[TypeConverter(typeof(o0o))]
		[O_Oo00Oo000O0(100.0)]
		public string TopTab
		{
			get
			{
				return this.OO_oOo0oo0.oO.;
			}
			set
			{
				this.OO_oOo0oo0.oO. = value;
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06004FED RID: 20461 RVA: 0x0023904E File Offset: 0x0023724E
		// (set) Token: 0x06004FEE RID: 20462 RVA: 0x00239069 File Offset: 0x00237269
		[DisplayName("标题")]
		[O_Oo00Oo000O0(2.0)]
		[Category("属性")]
		public string Text
		{
			get
			{
				if (this.OO.00o___0o. == null)
				{
					this.OO.00o___0o. = "";
				}
				return this.OO.00o___0o.;
			}
			set
			{
				this.OO.00o___0o. = value;
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06004FEF RID: 20463 RVA: 0x00239072 File Offset: 0x00237272
		// (set) Token: 0x06004FF0 RID: 20464 RVA: 0x0023907A File Offset: 0x0023727A
		[O_Oo00Oo000O0(3.0)]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[Category("属性")]
		[DisplayName("图标")]
		[Description("一个16*16尺寸的图标，或者对应大小的图片。")]
		public string Image
		{
			get
			{
				return this.ooo0_OoO.ooO.;
			}
			set
			{
				this.ooo0_OoO.ooO. = value;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06004FF1 RID: 20465 RVA: 0x00239083 File Offset: 0x00237283
		// (set) Token: 0x06004FF2 RID: 20466 RVA: 0x0023908B File Offset: 0x0023728B
		[O_Oo00Oo000O0(4.0)]
		[Category("属性")]
		[DisplayName("提示")]
		public string ToolTip
		{
			get
			{
				return this.O.o_0o0.;
			}
			set
			{
				this.O.o_0o0. = value;
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x06004FF3 RID: 20467 RVA: 0x00239094 File Offset: 0x00237294
		// (set) Token: 0x06004FF4 RID: 20468 RVA: 0x0023909C File Offset: 0x0023729C
		[O_Oo00Oo000O0(5.0)]
		[Category("属性")]
		[DisplayName("可用")]
		[DefaultValue(true)]
		public bool Enabled
		{
			get
			{
				return this.OO.00o___0o.;
			}
			set
			{
				this.OO.00o___0o. = value;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x06004FF5 RID: 20469 RVA: 0x002390A5 File Offset: 0x002372A5
		// (set) Token: 0x06004FF6 RID: 20470 RVA: 0x002390AD File Offset: 0x002372AD
		[Category("属性")]
		[O_Oo00Oo000O0(6.0)]
		[DisplayName("可见")]
		[DefaultValue(true)]
		public bool Visible
		{
			get
			{
				return this.OO_oOo0oo0.oO.;
			}
			set
			{
				this.OO_oOo0oo0.oO. = value;
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06004FF7 RID: 20471 RVA: 0x002390B6 File Offset: 0x002372B6
		// (set) Token: 0x06004FF8 RID: 20472 RVA: 0x002390BD File Offset: 0x002372BD
		[Editor(typeof(RibbonItemCollectionEditor), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(7.0)]
		[DisplayName("功能组")]
		[Category("属性")]
		public Hashtable Items
		{
			get
			{
				return new Hashtable();
			}
			set
			{
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06004FF9 RID: 20473 RVA: 0x002390BF File Offset: 0x002372BF
		// (set) Token: 0x06004FFA RID: 20474 RVA: 0x002390C7 File Offset: 0x002372C7
		[Description("选择功能区后执行。")]
		[O_Oo00Oo000O0(1.0)]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString SelectTab
		{
			get
			{
				return this.OO_oOo0oo0.oO.;
			}
			set
			{
				this.OO_oOo0oo0.oO. = value;
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06004FFB RID: 20475 RVA: 0x002390D0 File Offset: 0x002372D0
		// (set) Token: 0x06004FFC RID: 20476 RVA: 0x002390D8 File Offset: 0x002372D8
		[O_Oo00Oo000O0(2.0)]
		[Description("离开功能区后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString DeselectTab
		{
			get
			{
				return this.o__._00O0o.;
			}
			set
			{
				this.o__._00O0o. = value;
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06004FFD RID: 20477 RVA: 0x002390E1 File Offset: 0x002372E1
		// (set) Token: 0x06004FFE RID: 20478 RVA: 0x002390E9 File Offset: 0x002372E9
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("双击功能区的时候执行。")]
		[Category("事件")]
		[O_Oo00Oo000O0(3.0)]
		[Browsable(false)]
		[O0O0oOO00_0OO(true)]
		public EventString DoubleClick
		{
			get
			{
				return this.OO.00o___0o.;
			}
			set
			{
				this.OO.00o___0o. = value;
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06004FFF RID: 20479 RVA: 0x002390F2 File Offset: 0x002372F2
		// (set) Token: 0x06005000 RID: 20480 RVA: 0x002390FA File Offset: 0x002372FA
		[Category("事件")]
		[Description("鼠标进入的时候执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(4.0)]
		[O0O0oOO00_0OO(true)]
		public EventString MouseEnter
		{
			get
			{
				return this.ooo0_OoO.ooO.;
			}
			set
			{
				this.ooo0_OoO.ooO. = value;
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06005001 RID: 20481 RVA: 0x00239103 File Offset: 0x00237303
		// (set) Token: 0x06005002 RID: 20482 RVA: 0x0023910B File Offset: 0x0023730B
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(5.0)]
		[Description("鼠标离开的时候执行。")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString MouseLeave
		{
			get
			{
				return this.O0oO0OOoO_.0OO.;
			}
			set
			{
				this.O0oO0OOoO_.0OO. = value;
			}
		}

		// Token: 0x040020A8 RID: 8360
		private string <<EMPTY_NAME>>;

		// Token: 0x040020A9 RID: 8361
		private string <<EMPTY_NAME>>;

		// Token: 0x040020AA RID: 8362
		private string <<EMPTY_NAME>>;

		// Token: 0x040020AB RID: 8363
		private bool <<EMPTY_NAME>>;

		// Token: 0x040020AC RID: 8364
		private bool <<EMPTY_NAME>>;

		// Token: 0x040020AD RID: 8365
		private string <<EMPTY_NAME>>;

		// Token: 0x040020AE RID: 8366
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040020AF RID: 8367
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040020B0 RID: 8368
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040020B1 RID: 8369
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040020B2 RID: 8370
		private EventString <<EMPTY_NAME>>;
	}
}
