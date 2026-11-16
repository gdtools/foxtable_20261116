using System;
using System.ComponentModel;
using System.Windows.Forms;
using C1.Win.C1Command;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020002BA RID: 698
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TopicPageEventArgs : ControlEventArgs
	{
		// Token: 0x0600261D RID: 9757 RVA: 0x0011A151 File Offset: 0x00118351
		public TopicPageEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, C1TopicBarPageEventArgs A_2) : base(A_0, A_1)
		{
			this.O__.o__. = new TopicPage(A_2.Page);
		}

		/// <summary>
		/// 触发事件的页面
		/// </summary>
		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x0011A16C File Offset: 0x0011836C
		public TopicPage Page
		{
			get
			{
				return this.O__.o__.;
			}
		}

		// Token: 0x04000FCE RID: 4046
		private TopicPage <<EMPTY_NAME>>;
	}
}
