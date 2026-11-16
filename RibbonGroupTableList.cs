using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x02000498 RID: 1176
	[OoO0___o("RibbonGroupTableList")]
	internal class RibbonGroupTableList : RibbonItem
	{
		// Token: 0x06004FCC RID: 20428 RVA: 0x00238E9A File Offset: 0x0023709A
		public RibbonGroupTableList(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06004FCD RID: 20429 RVA: 0x00238EAB File Offset: 0x002370AB
		// (set) Token: 0x06004FCE RID: 20430 RVA: 0x00238EC6 File Offset: 0x002370C6
		[DisplayName("标题")]
		[Category("属性")]
		[O_Oo00Oo000O0(1.1)]
		public string Text
		{
			get
			{
				if (this.O0o._0o_O. == null)
				{
					this.O0o._0o_O. = "";
				}
				return this.O0o._0o_O.;
			}
			set
			{
				this.O0o._0o_O. = value;
			}
		}

		// Token: 0x040020A1 RID: 8353
		private string <<EMPTY_NAME>>;
	}
}
