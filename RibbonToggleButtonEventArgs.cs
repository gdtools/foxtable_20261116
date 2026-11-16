using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004B0 RID: 1200
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonToggleButtonEventArgs
	{
		// Token: 0x0600503C RID: 20540 RVA: 0x002393BF File Offset: 0x002375BF
		public RibbonToggleButtonEventArgs(ToggleButton A_0)
		{
			this.o_000O_o.oOo0. = A_0;
		}

		/// <summary>
		/// 返回触发事件的状态按钮
		/// </summary>
		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x0600503D RID: 20541 RVA: 0x002393CE File Offset: 0x002375CE
		public ToggleButton ToggleButton
		{
			get
			{
				return this.o_000O_o.oOo0.;
			}
		}

		// Token: 0x04002103 RID: 8451
		private ToggleButton <<EMPTY_NAME>>;
	}
}
