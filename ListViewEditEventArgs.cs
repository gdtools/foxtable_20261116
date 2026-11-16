using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020001AB RID: 427
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ListViewEditEventArgs : ListViewRowEventArgs
	{
		// Token: 0x060014F1 RID: 5361 RVA: 0x00097558 File Offset: 0x00095758
		public ListViewEditEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, ListViewRow A_2, string A_3) : base(A_0, A_1, A_2, A_2.Index)
		{
			this.oo.oO_. = A_3;
		}

		/// <summary>
		/// 编辑后的标题内容
		/// </summary>
		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x00097571 File Offset: 0x00095771
		public string NewText
		{
			get
			{
				return this.oo.oO_.;
			}
		}

		// Token: 0x04000849 RID: 2121
		private string <<EMPTY_NAME>>;
	}
}
