using System;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200043D RID: 1085
	internal class oOO_O_ : O_o_0o
	{
		// Token: 0x060048D9 RID: 18649 RVA: 0x001F59E6 File Offset: 0x001F3BE6
		internal oOO_O_(TreeNode A_0, ControlHolder A_1)
		{
			this.Node = A_0;
			this.Holder = A_1;
			this.Index = A_0.Index;
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x001F5A08 File Offset: 0x001F3C08
		internal void Undo()
		{
			TreeNodeCollection nodes;
			if (this.Node.Parent == null)
			{
				nodes = this.Node.TreeView.Nodes;
			}
			else
			{
				nodes = this.Node.Parent.Nodes;
			}
			nodes.Remove(this.Node);
			nodes.Insert(this.Index, this.Node);
			this.Node.TreeView.SelectedNode = this.Node;
			if (!this.Holder.Selected)
			{
				this.Holder.Selected = true;
			}
		}

		// Token: 0x04001D82 RID: 7554
		private TreeNode Node;

		// Token: 0x04001D83 RID: 7555
		private ControlHolder Holder;

		// Token: 0x04001D84 RID: 7556
		private int Index;
	}
}
