using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004B8 RID: 1208
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonLabelEventArgs
	{
		// Token: 0x0600504D RID: 20557 RVA: 0x0023947F File Offset: 0x0023767F
		public RibbonLabelEventArgs(Label A_0)
		{
			this.oOoOoOoO._o0. = A_0;
		}

		/// <summary>
		/// 返回触发事件的标签
		/// </summary>
		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x0600504E RID: 20558 RVA: 0x0023948E File Offset: 0x0023768E
		public Label Label
		{
			get
			{
				return this.oOoOoOoO._o0.;
			}
		}

		// Token: 0x0400210B RID: 8459
		private Label <<EMPTY_NAME>>;
	}
}
