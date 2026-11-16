using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x02000486 RID: 1158
	[OoO0___o("RibbonExcelReportList")]
	internal class RibbonCodeReportList : RibbonItem
	{
		// Token: 0x06004EF2 RID: 20210 RVA: 0x0023852A File Offset: 0x0023672A
		public RibbonCodeReportList(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06004EF3 RID: 20211 RVA: 0x0023853B File Offset: 0x0023673B
		// (set) Token: 0x06004EF4 RID: 20212 RVA: 0x00238556 File Offset: 0x00236756
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		[DisplayName("标题")]
		public string Text
		{
			get
			{
				if (this.O_o0oO.O00o. == null)
				{
					this.O_o0oO.O00o. = "";
				}
				return this.O_o0oO.O00o.;
			}
			set
			{
				this.O_o0oO.O00o. = value;
			}
		}

		// Token: 0x0400204A RID: 8266
		private string <<EMPTY_NAME>>;
	}
}
