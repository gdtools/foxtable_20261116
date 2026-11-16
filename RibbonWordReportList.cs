using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x020004A8 RID: 1192
	[OoO0___o("RibbonWordReportList")]
	internal class RibbonWordReportList : RibbonItem
	{
		// Token: 0x06005032 RID: 20530 RVA: 0x00239331 File Offset: 0x00237531
		public RibbonWordReportList(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06005033 RID: 20531 RVA: 0x00239342 File Offset: 0x00237542
		// (set) Token: 0x06005034 RID: 20532 RVA: 0x0023935D File Offset: 0x0023755D
		[DisplayName("标题")]
		[Category("属性")]
		[O_Oo00Oo000O0(1.1)]
		public string Text
		{
			get
			{
				if (this.O0.o0__OOo00O. == null)
				{
					this.O0.o0__OOo00O. = "";
				}
				return this.O0.o0__OOo00O.;
			}
			set
			{
				this.O0.o0__OOo00O. = value;
			}
		}

		// Token: 0x040020C2 RID: 8386
		private string <<EMPTY_NAME>>;
	}
}
