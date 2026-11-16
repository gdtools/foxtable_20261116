using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004BD RID: 1213
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonToolBarEventArgs
	{
		// Token: 0x06005057 RID: 20567 RVA: 0x002394F2 File Offset: 0x002376F2
		public RibbonToolBarEventArgs(ToolBar A_0)
		{
			this.o00o.0o0_0. = A_0;
		}

		/// <summary>
		/// 返回触发事件的工具栏
		/// </summary>
		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x06005058 RID: 20568 RVA: 0x00239501 File Offset: 0x00237701
		public ToolBar ToolBar
		{
			get
			{
				return this.o00o.0o0_0.;
			}
		}

		// Token: 0x04002110 RID: 8464
		private ToolBar <<EMPTY_NAME>>;
	}
}
