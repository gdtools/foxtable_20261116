using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000488 RID: 1160
	[oO0oooo("1107")]
	[OoO0___o("RibbonSplitButton")]
	internal class RibbonSplitButton : RibbonDropDownItem
	{
		// Token: 0x06004EFC RID: 20220 RVA: 0x002385A2 File Offset: 0x002367A2
		public RibbonSplitButton(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06004EFD RID: 20221 RVA: 0x002385B3 File Offset: 0x002367B3
		// (set) Token: 0x06004EFE RID: 20222 RVA: 0x002385CE File Offset: 0x002367CE
		[DisplayName("标题")]
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		public string Text
		{
			get
			{
				if (this.O._oo0__0o. == null)
				{
					this.O._oo0__0o. = "";
				}
				return this.O._oo0__0o.;
			}
			set
			{
				this.O._oo0__0o. = value;
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06004EFF RID: 20223 RVA: 0x002385D7 File Offset: 0x002367D7
		// (set) Token: 0x06004F00 RID: 20224 RVA: 0x002385DF File Offset: 0x002367DF
		[O_Oo00Oo000O0(0.1)]
		[Category("事件")]
		[Description("单击按钮后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString Click
		{
			get
			{
				return this.O._oo0__0o.;
			}
			set
			{
				this.O._oo0__0o. = value;
			}
		}

		// Token: 0x0400204D RID: 8269
		private string <<EMPTY_NAME>>;

		// Token: 0x0400204E RID: 8270
		private EventString <<EMPTY_NAME>>;
	}
}
