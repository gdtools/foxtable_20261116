using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x02000495 RID: 1173
	[OoO0___o("RibbonExcelReportList")]
	internal class RibbonExcelReportList : RibbonItem
	{
		// Token: 0x06004FAA RID: 20394 RVA: 0x00238D24 File Offset: 0x00236F24
		public RibbonExcelReportList(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06004FAB RID: 20395 RVA: 0x00238D35 File Offset: 0x00236F35
		// (set) Token: 0x06004FAC RID: 20396 RVA: 0x00238D50 File Offset: 0x00236F50
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		[DisplayName("标题")]
		public string Text
		{
			get
			{
				if (this.OO_._O0. == null)
				{
					this.OO_._O0. = "";
				}
				return this.OO_._O0.;
			}
			set
			{
				this.OO_._O0. = value;
			}
		}

		// Token: 0x04002093 RID: 8339
		private string <<EMPTY_NAME>>;
	}
}
