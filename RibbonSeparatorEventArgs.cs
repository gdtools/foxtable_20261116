using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004C0 RID: 1216
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonSeparatorEventArgs
	{
		// Token: 0x0600505D RID: 20573 RVA: 0x00239537 File Offset: 0x00237737
		public RibbonSeparatorEventArgs(Separator A_0)
		{
			this.O._oo0__0o. = A_0;
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x0600505E RID: 20574 RVA: 0x00239546 File Offset: 0x00237746
		public Separator Separator
		{
			get
			{
				return this.O._oo0__0o.;
			}
		}

		// Token: 0x04002113 RID: 8467
		private Separator <<EMPTY_NAME>>;
	}
}
