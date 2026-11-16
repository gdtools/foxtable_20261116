using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x0200043F RID: 1087
	internal class WebBrowserProperty : ControlPropertyBase
	{
		// Token: 0x060048DD RID: 18653 RVA: 0x001F5B70 File Offset: 0x001F3D70
		public WebBrowserProperty(ControlHolder A_0) : base(A_0)
		{
			this.O___oOO0o.0o. = (O_O_00)A_0.ChildControl;
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x060048DE RID: 18654 RVA: 0x001F5B8A File Offset: 0x001F3D8A
		// (set) Token: 0x060048DF RID: 18655 RVA: 0x001F5B92 File Offset: 0x001F3D92
		[O_Oo00Oo000O0(2.1)]
		[DefaultValue(2)]
		[MergableProperty(true)]
		[DisplayName("地址")]
		[Category("基本")]
		public string Address
		{
			get
			{
				return this.O___oOO0o.0o.;
			}
			set
			{
				this.O___oOO0o.0o. = value;
			}
		}

		// Token: 0x04001D89 RID: 7561
		private O_O_00 <<EMPTY_NAME>>;

		// Token: 0x04001D8A RID: 7562
		private string <<EMPTY_NAME>>;
	}
}
