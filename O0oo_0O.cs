using System;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200043B RID: 1083
	internal class O0oo_0O : O_o_0o
	{
		// Token: 0x060048D4 RID: 18644 RVA: 0x001F588C File Offset: 0x001F3A8C
		internal O0oo_0O(TreeNode A_0, ControlHolder A_1)
		{
			this.o_0_0.O_o__0o. = A_0;
			this.o_0_0.O_o__0o. = A_0.Text;
			this.o_0_0.O_o__0o. = A_1;
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x001F58B0 File Offset: 0x001F3AB0
		internal void <<EMPTY_NAME>>()
		{
			this.o_0_0.O_o__0o..Text = this.o_0_0.O_o__0o.;
			this.o_0_0.O_o__0o..TreeView.SelectedNode = this.o_0_0.O_o__0o.;
			if (!this.o_0_0.O_o__0o..Selected)
			{
				this.o_0_0.O_o__0o..Selected = true;
			}
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x001F58FD File Offset: 0x001F3AFD
		internal string <<EMPTY_NAME>>()
		{
			return this.o_0_0.O_o__0o.;
		}

		// Token: 0x04001D7B RID: 7547
		private TreeNode <<EMPTY_NAME>>;

		// Token: 0x04001D7C RID: 7548
		private ControlHolder <<EMPTY_NAME>>;

		// Token: 0x04001D7D RID: 7549
		private string <<EMPTY_NAME>>;
	}
}
