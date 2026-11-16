using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x020004A5 RID: 1189
	internal class RibbonTopToolBar : RibbonItemContainer
	{
		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06005016 RID: 20502 RVA: 0x002391E9 File Offset: 0x002373E9
		[Browsable(false)]
		public new string Name
		{
			get
			{
				return "上工具栏";
			}
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x002391F0 File Offset: 0x002373F0
		public RibbonTopToolBar(DataRow A_0) : base(A_0)
		{
			base.Name = "上工具栏";
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}
	}
}
