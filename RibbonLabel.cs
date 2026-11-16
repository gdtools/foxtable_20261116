using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x02000499 RID: 1177
	[OoO0___o("RibbonLabel")]
	[oO0oooo("1116")]
	internal class RibbonLabel : RibbonItem
	{
		// Token: 0x06004FCF RID: 20431 RVA: 0x00238ECF File Offset: 0x002370CF
		public RibbonLabel(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06004FD0 RID: 20432 RVA: 0x00238EE0 File Offset: 0x002370E0
		// (set) Token: 0x06004FD1 RID: 20433 RVA: 0x00238EFB File Offset: 0x002370FB
		[O_Oo00Oo000O0(1.1)]
		[DisplayName("标题")]
		[Category("属性")]
		public string Text
		{
			get
			{
				if (this.oo_00OOO_o.0O. == null)
				{
					this.oo_00OOO_o.0O. = "";
				}
				return this.oo_00OOO_o.0O.;
			}
			set
			{
				this.oo_00OOO_o.0O. = value;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06004FD2 RID: 20434 RVA: 0x00238F04 File Offset: 0x00237104
		// (set) Token: 0x06004FD3 RID: 20435 RVA: 0x00238F07 File Offset: 0x00237107
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

		// Token: 0x040020A2 RID: 8354
		private string <<EMPTY_NAME>>;
	}
}
