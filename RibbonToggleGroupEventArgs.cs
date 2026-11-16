using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004BE RID: 1214
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonToggleGroupEventArgs
	{
		// Token: 0x06005059 RID: 20569 RVA: 0x00239509 File Offset: 0x00237709
		public RibbonToggleGroupEventArgs(ToggleGroup A_0)
		{
			this.o_000O_o.oOo0. = A_0;
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x0600505A RID: 20570 RVA: 0x00239518 File Offset: 0x00237718
		public ToggleGroup ToggleGroup
		{
			get
			{
				return this.o_000O_o.oOo0.;
			}
		}

		// Token: 0x04002111 RID: 8465
		private ToggleGroup <<EMPTY_NAME>>;
	}
}
