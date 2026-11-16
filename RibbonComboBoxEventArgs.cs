using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004B9 RID: 1209
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonComboBoxEventArgs
	{
		// Token: 0x0600504F RID: 20559 RVA: 0x00239496 File Offset: 0x00237696
		public RibbonComboBoxEventArgs(ComboBox A_0)
		{
			this.O_o0oO.O00o. = A_0;
		}

		/// <summary>
		/// 返回触发事件的组合框
		/// </summary>
		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06005050 RID: 20560 RVA: 0x002394A5 File Offset: 0x002376A5
		public ComboBox ComboBox
		{
			get
			{
				return this.O_o0oO.O00o.;
			}
		}

		// Token: 0x0400210C RID: 8460
		private ComboBox <<EMPTY_NAME>>;
	}
}
