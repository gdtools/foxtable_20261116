using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000492 RID: 1170
	[OoO0___o("RibbonTimePicker")]
	[oO0oooo("3090")]
	internal class RibbonTimePicker : RibbonItem
	{
		// Token: 0x06004F85 RID: 20357 RVA: 0x00238B94 File Offset: 0x00236D94
		public RibbonTimePicker(DataRow A_0) : base(A_0)
		{
			this.OOoo_o00.O___0. = "标题:";
			this.OOoo_o00.O___0. = 60;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06004F86 RID: 20358 RVA: 0x00238BB8 File Offset: 0x00236DB8
		// (set) Token: 0x06004F87 RID: 20359 RVA: 0x00238BD3 File Offset: 0x00236DD3
		[Category("属性")]
		[DefaultValue("标题:")]
		[O_Oo00Oo000O0(1.1)]
		[DisplayName("标题")]
		public string Label
		{
			get
			{
				if (this.OOoo_o00.O___0. == null)
				{
					this.OOoo_o00.O___0. = "";
				}
				return this.OOoo_o00.O___0.;
			}
			set
			{
				this.OOoo_o00.O___0. = value;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06004F88 RID: 20360 RVA: 0x00238BDC File Offset: 0x00236DDC
		// (set) Token: 0x06004F89 RID: 20361 RVA: 0x00238BE4 File Offset: 0x00236DE4
		[Category("属性")]
		[DisplayName("初始值")]
		[O_Oo00Oo000O0(1.2)]
		public TimeSpan Value
		{
			get
			{
				return this.OOoo_o00.O___0.;
			}
			set
			{
				this.OOoo_o00.O___0. = value;
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06004F8A RID: 20362 RVA: 0x00238BED File Offset: 0x00236DED
		// (set) Token: 0x06004F8B RID: 20363 RVA: 0x00238BF5 File Offset: 0x00236DF5
		[Category("属性")]
		[O_Oo00Oo000O0(1.3)]
		[DisplayName("宽度")]
		public int TextAreaWidth
		{
			get
			{
				return this.OOoo_o00.O___0.;
			}
			set
			{
				this.OOoo_o00.O___0. = value;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06004F8C RID: 20364 RVA: 0x00238BFE File Offset: 0x00236DFE
		// (set) Token: 0x06004F8D RID: 20365 RVA: 0x00238C06 File Offset: 0x00236E06
		[Category("属性")]
		[DisplayName("长时间格式")]
		[O_Oo00Oo000O0(1.4)]
		public bool LongTimeFormat
		{
			get
			{
				return this.OOoo_o00.O___0.;
			}
			set
			{
				this.OOoo_o00.O___0. = value;
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06004F8E RID: 20366 RVA: 0x00238C0F File Offset: 0x00236E0F
		// (set) Token: 0x06004F8F RID: 20367 RVA: 0x00238C17 File Offset: 0x00236E17
		[Description("取消修改后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(0.1)]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString ChangeCanceled
		{
			get
			{
				return this.OOoo_o00.O___0.;
			}
			set
			{
				this.OOoo_o00.O___0. = value;
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06004F90 RID: 20368 RVA: 0x00238C20 File Offset: 0x00236E20
		// (set) Token: 0x06004F91 RID: 20369 RVA: 0x00238C28 File Offset: 0x00236E28
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O_Oo00Oo000O0(0.2)]
		[Description("提交修改后执行。")]
		[O0O0oOO00_0OO(true)]
		public EventString ChangeCommitted
		{
			get
			{
				return this.OoOO000_0O_.o.;
			}
			set
			{
				this.OoOO000_0O_.o. = value;
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06004F92 RID: 20370 RVA: 0x00238C31 File Offset: 0x00236E31
		// (set) Token: 0x06004F93 RID: 20371 RVA: 0x00238C39 File Offset: 0x00236E39
		[Category("事件")]
		[O_Oo00Oo000O0(0.3)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("值改变后执行。")]
		[O0O0oOO00_0OO(true)]
		public EventString ValueChanged
		{
			get
			{
				return this.O_.OOo0.;
			}
			set
			{
				this.O_.OOo0. = value;
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06004F94 RID: 20372 RVA: 0x00238C42 File Offset: 0x00236E42
		// (set) Token: 0x06004F95 RID: 20373 RVA: 0x00238C4A File Offset: 0x00236E4A
		[O_Oo00Oo000O0(0.4)]
		[Description("获得输入焦点后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString GotFocus
		{
			get
			{
				return this.o0.0o_ooOO_o.;
			}
			set
			{
				this.o0.0o_ooOO_o. = value;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06004F96 RID: 20374 RVA: 0x00238C53 File Offset: 0x00236E53
		// (set) Token: 0x06004F97 RID: 20375 RVA: 0x00238C5B File Offset: 0x00236E5B
		[Description("失去输入焦点后执行。")]
		[O_Oo00Oo000O0(0.5)]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString LostFocus
		{
			get
			{
				return this.oOO_.O.;
			}
			set
			{
				this.oOO_.O. = value;
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06004F98 RID: 20376 RVA: 0x00238C64 File Offset: 0x00236E64
		// (set) Token: 0x06004F99 RID: 20377 RVA: 0x00238C67 File Offset: 0x00236E67
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

		// Token: 0x04002084 RID: 8324
		private string <<EMPTY_NAME>>;

		// Token: 0x04002085 RID: 8325
		private TimeSpan <<EMPTY_NAME>>;

		// Token: 0x04002086 RID: 8326
		private int <<EMPTY_NAME>>;

		// Token: 0x04002087 RID: 8327
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002088 RID: 8328
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002089 RID: 8329
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400208A RID: 8330
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400208B RID: 8331
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400208C RID: 8332
		private bool <<EMPTY_NAME>>;
	}
}
