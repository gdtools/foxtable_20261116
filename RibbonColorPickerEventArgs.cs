using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004BB RID: 1211
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonColorPickerEventArgs
	{
		// Token: 0x06005053 RID: 20563 RVA: 0x002394C4 File Offset: 0x002376C4
		public RibbonColorPickerEventArgs(ColorPicker A_0)
		{
			this.O_o0oO.O00o. = A_0;
		}

		/// <summary>
		/// 返回触发事件的颜色选择框
		/// </summary>
		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06005054 RID: 20564 RVA: 0x002394D3 File Offset: 0x002376D3
		public ColorPicker ColorPicker
		{
			get
			{
				return this.O_o0oO.O00o.;
			}
		}

		// Token: 0x0400210E RID: 8462
		private ColorPicker <<EMPTY_NAME>>;
	}
}
