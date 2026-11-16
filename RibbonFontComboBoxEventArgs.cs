using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004BA RID: 1210
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonFontComboBoxEventArgs
	{
		// Token: 0x06005051 RID: 20561 RVA: 0x002394AD File Offset: 0x002376AD
		public RibbonFontComboBoxEventArgs(FontComboBox A_0)
		{
			this.oO_.OO__OOo_o0. = A_0;
		}

		/// <summary>
		/// 返回触发事件的字体选择框
		/// </summary>
		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06005052 RID: 20562 RVA: 0x002394BC File Offset: 0x002376BC
		public FontComboBox FontComboBox
		{
			get
			{
				return this.oO_.OO__OOo_o0.;
			}
		}

		// Token: 0x0400210D RID: 8461
		private FontComboBox <<EMPTY_NAME>>;
	}
}
