using System;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200043C RID: 1084
	internal class o0_00Oo0o : O_o_0o
	{
		// Token: 0x060048D7 RID: 18647 RVA: 0x001F5908 File Offset: 0x001F3B08
		internal o0_00Oo0o(TreeNode A_0, ControlHolder A_1)
		{
			this.Node = A_0;
			this.Holder = A_1;
			if (A_0.Parent == null)
			{
				this.ParentNodes = A_0.TreeView.Nodes;
			}
			else
			{
				this.ParentNodes = A_0.Parent.Nodes;
			}
			this.Index = A_0.Index;
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x001F5964 File Offset: 0x001F3B64
		internal void Undo()
		{
			if (this.Node.Parent == null)
			{
				this.Node.TreeView.Nodes.Remove(this.Node);
			}
			else
			{
				this.Node.Parent.Nodes.Remove(this.Node);
			}
			this.ParentNodes.Insert(this.Index, this.Node);
			if (!this.Holder.Selected)
			{
				this.Holder.Selected = true;
			}
		}

		// Token: 0x04001D7E RID: 7550
		private TreeNode Node;

		// Token: 0x04001D7F RID: 7551
		private ControlHolder Holder;

		// Token: 0x04001D80 RID: 7552
		private TreeNodeCollection ParentNodes;

		// Token: 0x04001D81 RID: 7553
		private int Index;
	}
}
