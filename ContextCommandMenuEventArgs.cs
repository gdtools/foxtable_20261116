using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004C3 RID: 1219
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ContextCommandMenuEventArgs
	{
		// Token: 0x06005063 RID: 20579 RVA: 0x0023957C File Offset: 0x0023777C
		public ContextCommandMenuEventArgs(ContextCommandMenu A_0)
		{
			this.Oo_oo.O0O_0OO0. = A_0;
		}

		/// <summary>
		/// 返回触发事件的子菜单
		/// </summary>
		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06005064 RID: 20580 RVA: 0x0023958B File Offset: 0x0023778B
		public ContextCommandMenu CommandMenu
		{
			get
			{
				return this.Oo_oo.O0O_0OO0.;
			}
		}

		// Token: 0x04002116 RID: 8470
		private ContextCommandMenu <<EMPTY_NAME>>;
	}
}
