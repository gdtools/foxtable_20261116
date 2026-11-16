using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004C5 RID: 1221
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonTrackBarEventArgs
	{
		// Token: 0x06005067 RID: 20583 RVA: 0x002395AA File Offset: 0x002377AA
		public RibbonTrackBarEventArgs(TrackBar A_0)
		{
			this.O0.o0__OOo00O. = A_0;
		}

		/// <summary>
		/// 返回触发事件的滑动条
		/// </summary>
		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x002395B9 File Offset: 0x002377B9
		public TrackBar TrackBar
		{
			get
			{
				return this.O0.o0__OOo00O.;
			}
		}

		// Token: 0x04002118 RID: 8472
		private TrackBar <<EMPTY_NAME>>;
	}
}
