using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004C2 RID: 1218
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ContextCommandEventArgs
	{
		// Token: 0x06005061 RID: 20577 RVA: 0x00239565 File Offset: 0x00237765
		public ContextCommandEventArgs(ContextCommand A_0)
		{
			this.oOO_._0_00ooo. = A_0;
		}

		/// <summary>
		/// 返回触发时间的快捷菜单命令
		/// </summary>
		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06005062 RID: 20578 RVA: 0x00239574 File Offset: 0x00237774
		public ContextCommand Command
		{
			get
			{
				return this.oOO_._0_00ooo.;
			}
		}

		// Token: 0x04002115 RID: 8469
		private ContextCommand <<EMPTY_NAME>>;
	}
}
