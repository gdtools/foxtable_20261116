using System;
using System.ComponentModel;
using System.Windows.Forms;
using C1.Win.C1Command;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020002B9 RID: 697
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TabPageChangingEventArgs : ControlEventArgs
	{
		// Token: 0x06002619 RID: 9753 RVA: 0x0011A118 File Offset: 0x00118318
		public TabPageChangingEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, SelectedIndexChangingEventArgs A_2) : base(A_0, A_1)
		{
			this.Oo_._O0oOOOo. = A_2;
		}

		/// <summary>
		/// 新页面的位置
		/// </summary>
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x0011A129 File Offset: 0x00118329
		public int NewIndex
		{
			get
			{
				return this.Oo_._O0oOOOo..NewIndex;
			}
		}

		/// <summary>
		/// 是否取消本次操作
		/// </summary>
		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x0011A136 File Offset: 0x00118336
		// (set) Token: 0x0600261C RID: 9756 RVA: 0x0011A143 File Offset: 0x00118343
		public new bool Cancel
		{
			get
			{
				return this.Oo_._O0oOOOo..Cancel;
			}
			set
			{
				this.Oo_._O0oOOOo..Cancel = value;
			}
		}

		// Token: 0x04000FCD RID: 4045
		private SelectedIndexChangingEventArgs <<EMPTY_NAME>>;
	}
}
