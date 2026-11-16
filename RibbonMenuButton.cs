using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x0200049A RID: 1178
	[oO0oooo("1105")]
	[OoO0___o("RibbonMenuButton")]
	internal class RibbonMenuButton : RibbonDropDownItem
	{
		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06004FD4 RID: 20436 RVA: 0x00238F09 File Offset: 0x00237109
		// (set) Token: 0x06004FD5 RID: 20437 RVA: 0x00238F24 File Offset: 0x00237124
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		[DisplayName("标题")]
		public string Text
		{
			get
			{
				if (this.O.oOOO. == null)
				{
					this.O.oOOO. = "";
				}
				return this.O.oOOO.;
			}
			set
			{
				this.O.oOOO. = value;
			}
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x00238F2D File Offset: 0x0023712D
		public RibbonMenuButton(DataRow A_0) : base(A_0)
		{
			this.O.oOOO. = true;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06004FD7 RID: 20439 RVA: 0x00238F45 File Offset: 0x00237145
		// (set) Token: 0x06004FD8 RID: 20440 RVA: 0x00238F4D File Offset: 0x0023714D
		[DefaultValue(true)]
		[O_Oo00Oo000O0(1.2)]
		[DisplayName("显示箭头")]
		[Category("属性")]
		public bool ArrowVisible
		{
			get
			{
				return this.O.oOOO.;
			}
			set
			{
				this.O.oOOO. = value;
			}
		}

		// Token: 0x040020A3 RID: 8355
		private string <<EMPTY_NAME>>;

		// Token: 0x040020A4 RID: 8356
		private bool <<EMPTY_NAME>>;
	}
}
