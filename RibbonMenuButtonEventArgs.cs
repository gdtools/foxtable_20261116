using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004B3 RID: 1203
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonMenuButtonEventArgs
	{
		// Token: 0x06005042 RID: 20546 RVA: 0x00239404 File Offset: 0x00237604
		public RibbonMenuButtonEventArgs(MenuButton A_0)
		{
			this.O.oOOO. = A_0;
		}

		/// <summary>
		/// 返回触发时间的菜单按钮
		/// </summary>
		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06005043 RID: 20547 RVA: 0x00239413 File Offset: 0x00237613
		public MenuButton MenuButton
		{
			get
			{
				return this.O.oOOO.;
			}
		}

		// Token: 0x04002106 RID: 8454
		private MenuButton <<EMPTY_NAME>>;
	}
}
