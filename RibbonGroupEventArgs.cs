using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004BC RID: 1212
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonGroupEventArgs
	{
		// Token: 0x06005055 RID: 20565 RVA: 0x002394DB File Offset: 0x002376DB
		public RibbonGroupEventArgs(Group A_0)
		{
			this.O0o._0o_O. = A_0;
		}

		/// <summary>
		/// 返回触发事件的功能组
		/// </summary>
		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06005056 RID: 20566 RVA: 0x002394EA File Offset: 0x002376EA
		public Group Group
		{
			get
			{
				return this.O0o._0o_O.;
			}
		}

		// Token: 0x0400210F RID: 8463
		private Group <<EMPTY_NAME>>;
	}
}
