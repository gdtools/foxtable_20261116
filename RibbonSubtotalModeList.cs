using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x0200049E RID: 1182
	[OoO0___o("RibbbonSubtotalModeList")]
	internal class RibbonSubtotalModeList : RibbonItem
	{
		// Token: 0x06004FE7 RID: 20455 RVA: 0x00238FE9 File Offset: 0x002371E9
		public RibbonSubtotalModeList(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06004FE8 RID: 20456 RVA: 0x00238FFA File Offset: 0x002371FA
		// (set) Token: 0x06004FE9 RID: 20457 RVA: 0x00239015 File Offset: 0x00237215
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

		// Token: 0x040020A7 RID: 8359
		private string <<EMPTY_NAME>>;
	}
}
