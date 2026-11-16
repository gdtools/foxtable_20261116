using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004C1 RID: 1217
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ContextMenuEventArgs
	{
		// Token: 0x0600505F RID: 20575 RVA: 0x0023954E File Offset: 0x0023774E
		public ContextMenuEventArgs(ContextMenu A_0)
		{
			this.Oo_oo.O0O_0OO0. = A_0;
		}

		/// <summary>
		/// 返回触发事件的快捷菜单
		/// </summary>
		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06005060 RID: 20576 RVA: 0x0023955D File Offset: 0x0023775D
		public ContextMenu ContextMenu
		{
			get
			{
				return this.Oo_oo.O0O_0OO0.;
			}
		}

		// Token: 0x04002114 RID: 8468
		private ContextMenu <<EMPTY_NAME>>;
	}
}
