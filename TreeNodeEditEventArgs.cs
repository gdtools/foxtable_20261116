using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020002BB RID: 699
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TreeNodeEditEventArgs : ControlEventArgs
	{
		// Token: 0x0600261F RID: 9759 RVA: 0x0011A174 File Offset: 0x00118374
		public TreeNodeEditEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, Foxtable.WinForm.TreeNode A_2, string A_3) : base(A_0, A_1)
		{
			this.o_0_0.O_o__0o. = A_2;
			this.o_0_0.O_o__0o. = A_3;
		}

		/// <summary>
		/// 被编辑的节点
		/// </summary>
		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x0011A18D File Offset: 0x0011838D
		public Foxtable.WinForm.TreeNode Node
		{
			get
			{
				return this.o_0_0.O_o__0o.;
			}
		}

		/// <summary>
		/// 输入的新标题
		/// </summary>
		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x0011A195 File Offset: 0x00118395
		public string NewText
		{
			get
			{
				return this.o_0_0.O_o__0o.;
			}
		}

		// Token: 0x04000FCF RID: 4047
		private Foxtable.WinForm.TreeNode <<EMPTY_NAME>>;

		// Token: 0x04000FD0 RID: 4048
		private string <<EMPTY_NAME>>;
	}
}
