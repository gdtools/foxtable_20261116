using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020001AC RID: 428
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ListViewRowEventArgs : ControlEventArgs
	{
		// Token: 0x060014F3 RID: 5363 RVA: 0x00097579 File Offset: 0x00095779
		public ListViewRowEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, ListViewRow A_2, int A_3) : base(A_0, A_1)
		{
			this.O._OOOO0_. = A_2;
			this.O._OOOO0_. = A_3;
		}

		/// <summary>
		/// 触发事件的行
		/// </summary>
		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x00097592 File Offset: 0x00095792
		public ListViewRow Row
		{
			get
			{
				return this.O._OOOO0_.;
			}
		}

		/// <summary>
		/// 行位置
		/// </summary>
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x0009759A File Offset: 0x0009579A
		public int Index
		{
			get
			{
				return this.O._OOOO0_.;
			}
		}

		// Token: 0x0400084A RID: 2122
		private ListViewRow <<EMPTY_NAME>>;

		// Token: 0x0400084B RID: 2123
		private int <<EMPTY_NAME>>;

		// Token: 0x0400084C RID: 2124
		private bool <<EMPTY_NAME>>;
	}
}
