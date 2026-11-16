using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x0200048D RID: 1165
	[oO0oooo("2035")]
	[OoO0___o("RibbonDatePicker")]
	internal class RibbonDatePicker : RibbonItem
	{
		// Token: 0x06004F26 RID: 20262 RVA: 0x0023877B File Offset: 0x0023697B
		public RibbonDatePicker(DataRow A_0) : base(A_0)
		{
			this.O_o._0oo0o0_0. = "日期:";
			this.OO_._O0. = 75;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06004F27 RID: 20263 RVA: 0x0023879F File Offset: 0x0023699F
		// (set) Token: 0x06004F28 RID: 20264 RVA: 0x002387A7 File Offset: 0x002369A7
		[O_Oo00Oo000O0(1.1)]
		[DefaultValue("日期:")]
		[DisplayName("标题")]
		[Category("属性")]
		public string Label
		{
			get
			{
				return this.O_o._0oo0o0_0.;
			}
			set
			{
				this.O_o._0oo0o0_0. = value;
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06004F29 RID: 20265 RVA: 0x002387B0 File Offset: 0x002369B0
		// (set) Token: 0x06004F2A RID: 20266 RVA: 0x002387B8 File Offset: 0x002369B8
		[O_Oo00Oo000O0(1.3)]
		[DisplayName("宽度")]
		[Category("属性")]
		public int TextAreaWidth
		{
			get
			{
				return this.OO_._O0.;
			}
			set
			{
				this.OO_._O0. = value;
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06004F2B RID: 20267 RVA: 0x002387C1 File Offset: 0x002369C1
		// (set) Token: 0x06004F2C RID: 20268 RVA: 0x002387C9 File Offset: 0x002369C9
		[O_Oo00Oo000O0(0.1)]
		[Description("取消修改后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString ChangeCanceled
		{
			get
			{
				return this.O_o._0oo0o0_0.;
			}
			set
			{
				this.O_o._0oo0o0_0. = value;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06004F2D RID: 20269 RVA: 0x002387D2 File Offset: 0x002369D2
		// (set) Token: 0x06004F2E RID: 20270 RVA: 0x002387DA File Offset: 0x002369DA
		[O_Oo00Oo000O0(0.2)]
		[Category("事件")]
		[Description("提交修改后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString ChangeCommitted
		{
			get
			{
				return this.o.o_0o_O0O_.;
			}
			set
			{
				this.o.o_0o_O0O_. = value;
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06004F2F RID: 20271 RVA: 0x002387E3 File Offset: 0x002369E3
		// (set) Token: 0x06004F30 RID: 20272 RVA: 0x002387EB File Offset: 0x002369EB
		[Description("值改变后执行。")]
		[O_Oo00Oo000O0(0.3)]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString ValueChanged
		{
			get
			{
				return this.oo_0.oo__00__.;
			}
			set
			{
				this.oo_0.oo__00__. = value;
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06004F31 RID: 20273 RVA: 0x002387F4 File Offset: 0x002369F4
		// (set) Token: 0x06004F32 RID: 20274 RVA: 0x002387FC File Offset: 0x002369FC
		[O_Oo00Oo000O0(0.4)]
		[Category("事件")]
		[Description("获得输入焦点后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString GotFocus
		{
			get
			{
				return this.ooO_oOoo.oo.;
			}
			set
			{
				this.ooO_oOoo.oo. = value;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06004F33 RID: 20275 RVA: 0x00238805 File Offset: 0x00236A05
		// (set) Token: 0x06004F34 RID: 20276 RVA: 0x0023880D File Offset: 0x00236A0D
		[O_Oo00Oo000O0(0.5)]
		[Category("事件")]
		[Description("失去输入焦点后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString LostFocus
		{
			get
			{
				return this.o_0.0OooO0.;
			}
			set
			{
				this.o_0.0OooO0. = value;
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06004F35 RID: 20277 RVA: 0x00238816 File Offset: 0x00236A16
		// (set) Token: 0x06004F36 RID: 20278 RVA: 0x00238819 File Offset: 0x00236A19
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

		// Token: 0x0400205D RID: 8285
		private string <<EMPTY_NAME>>;

		// Token: 0x0400205E RID: 8286
		private int <<EMPTY_NAME>>;

		// Token: 0x0400205F RID: 8287
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002060 RID: 8288
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002061 RID: 8289
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002062 RID: 8290
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002063 RID: 8291
		private EventString <<EMPTY_NAME>>;
	}
}
