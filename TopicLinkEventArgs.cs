using System;
using System.ComponentModel;
using System.Windows.Forms;
using C1.Win.C1Command;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003F3 RID: 1011
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TopicLinkEventArgs : ControlEventArgs
	{
		// Token: 0x0600417D RID: 16765 RVA: 0x001D8A0C File Offset: 0x001D6C0C
		public TopicLinkEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, C1TopicBarClickEventArgs A_2) : base(A_0, A_1)
		{
			this.O._oooo0__. = new TopicLink(A_2.Link);
			this.O._oooo0__. = new TopicPage(A_2.Page);
		}

		/// <summary>
		/// 所单击的任务
		/// </summary>
		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x0600417E RID: 16766 RVA: 0x001D8A38 File Offset: 0x001D6C38
		public TopicLink Link
		{
			get
			{
				return this.O._oooo0__.;
			}
		}

		/// <summary>
		/// 任务所在的页面
		/// </summary>
		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x001D8A40 File Offset: 0x001D6C40
		public TopicPage Page
		{
			get
			{
				return this.O._oooo0__.;
			}
		}

		// Token: 0x04001A6A RID: 6762
		private TopicLink <<EMPTY_NAME>>;

		// Token: 0x04001A6B RID: 6763
		private TopicPage <<EMPTY_NAME>>;
	}
}
