using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x02000481 RID: 1153
	internal class RibbonBottomToolBar : RibbonItemContainer
	{
		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06004EBE RID: 20158 RVA: 0x00238318 File Offset: 0x00236518
		[Browsable(false)]
		public new string Name
		{
			get
			{
				return "下工具栏";
			}
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x0023831F File Offset: 0x0023651F
		public RibbonBottomToolBar(DataRow A_0) : base(A_0)
		{
			base.Name = "下工具栏";
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}
	}
}
