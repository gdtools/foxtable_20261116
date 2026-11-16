using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x020004A3 RID: 1187
	[OoO0___o("RibbonToggleGroup")]
	[oO0oooo("1128")]
	internal class RibbonToggleGroup : RibbonItemContainer
	{
		// Token: 0x06005010 RID: 20496 RVA: 0x002391A5 File Offset: 0x002373A5
		public RibbonToggleGroup(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x06005011 RID: 20497 RVA: 0x002391B6 File Offset: 0x002373B6
		// (set) Token: 0x06005012 RID: 20498 RVA: 0x002391BE File Offset: 0x002373BE
		[Category("属性")]
		[DisplayName("可单击弹起")]
		[O_Oo00Oo000O0(1.2)]
		[Description("是否允许通过单击分组栏某一按钮，使其弹起。")]
		[DefaultValue(false)]
		public bool AllowAllButtonsUp
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

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x06005013 RID: 20499 RVA: 0x002391C7 File Offset: 0x002373C7
		// (set) Token: 0x06005014 RID: 20500 RVA: 0x002391CF File Offset: 0x002373CF
		[O_Oo00Oo000O0(0.01)]
		[Description("某一个状态按钮的状态改变后执行。")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString PressedButtonChanged
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

		// Token: 0x040020B8 RID: 8376
		private bool <<EMPTY_NAME>>;

		// Token: 0x040020B9 RID: 8377
		private EventString <<EMPTY_NAME>>;
	}
}
