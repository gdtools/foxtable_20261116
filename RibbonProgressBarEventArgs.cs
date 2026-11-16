using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004B7 RID: 1207
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonProgressBarEventArgs
	{
		// Token: 0x0600504B RID: 20555 RVA: 0x00239468 File Offset: 0x00237668
		public RibbonProgressBarEventArgs(ProgressBar A_0)
		{
			this.O._oo0__0o. = A_0;
		}

		/// <summary>
		/// 返回触发时间的进度条
		/// </summary>
		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x0600504C RID: 20556 RVA: 0x00239477 File Offset: 0x00237677
		public ProgressBar ProgressBar
		{
			get
			{
				return this.O._oo0__0o.;
			}
		}

		// Token: 0x0400210A RID: 8458
		private ProgressBar <<EMPTY_NAME>>;
	}
}
