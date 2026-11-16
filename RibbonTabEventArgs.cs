using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004BF RID: 1215
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonTabEventArgs
	{
		// Token: 0x0600505B RID: 20571 RVA: 0x00239520 File Offset: 0x00237720
		public RibbonTabEventArgs(Tab A_0)
		{
			this.O0oo0.o. = A_0;
		}

		/// <summary>
		/// 返回触发事件的功能区
		/// </summary>
		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x0600505C RID: 20572 RVA: 0x0023952F File Offset: 0x0023772F
		public Tab Tab
		{
			get
			{
				return this.O0oo0.o.;
			}
		}

		// Token: 0x04002112 RID: 8466
		private Tab <<EMPTY_NAME>>;
	}
}
