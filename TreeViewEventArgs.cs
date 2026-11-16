using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003F4 RID: 1012
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TreeViewEventArgs : ControlEventArgs
	{
		// Token: 0x06004180 RID: 16768 RVA: 0x001D8A48 File Offset: 0x001D6C48
		public TreeViewEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, Foxtable.WinForm.TreeNode A_2) : base(A_0, A_1)
		{
			this.O_.oOO_oO_. = A_2;
		}

		/// <summary>
		/// 触发事件的节点
		/// </summary>
		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06004181 RID: 16769 RVA: 0x001D8A59 File Offset: 0x001D6C59
		public Foxtable.WinForm.TreeNode Node
		{
			get
			{
				return this.O_.oOO_oO_.;
			}
		}

		// Token: 0x04001A6C RID: 6764
		private Foxtable.WinForm.TreeNode <<EMPTY_NAME>>;
	}
}
