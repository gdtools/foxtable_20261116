using System;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000431 RID: 1073
	internal class oOOooooO0o00 : O_o_0o
	{
		// Token: 0x060048BD RID: 18621 RVA: 0x001F52FA File Offset: 0x001F34FA
		internal oOOooooO0o00(TreeNode A_0, ControlHolder A_1)
		{
			this.O_0oO0o.OO_. = A_0;
			this.o___oOo.o_OO. = A_0.Parent;
			this.O_0oO0o.OO_. = A_0.TreeView;
			this.O_0oO0o.OO_. = A_1;
			this.O_0oO0o.OO_. = A_0.Index;
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x001F5334 File Offset: 0x001F3534
		internal void <<EMPTY_NAME>>()
		{
			if (this.o___oOo.o_OO. == null)
			{
				this.O_0oO0o.OO_..Nodes.Insert(this.O_0oO0o.OO_., this.O_0oO0o.OO_.);
			}
			else
			{
				this.o___oOo.o_OO..Nodes.Insert(this.O_0oO0o.OO_., this.O_0oO0o.OO_.);
			}
			this.O_0oO0o.OO_..SelectedNode = this.O_0oO0o.OO_.;
			if (!this.O_0oO0o.OO_..Selected)
			{
				this.O_0oO0o.OO_..Selected = true;
			}
		}

		// Token: 0x04001D5F RID: 7519
		private TreeNode <<EMPTY_NAME>>;

		// Token: 0x04001D60 RID: 7520
		private TreeNode <<EMPTY_NAME>>;

		// Token: 0x04001D61 RID: 7521
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x04001D62 RID: 7522
		private int <<EMPTY_NAME>>;

		// Token: 0x04001D63 RID: 7523
		private ControlHolder <<EMPTY_NAME>>;
	}
}
