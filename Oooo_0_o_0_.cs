using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000C2 RID: 194
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Oooo_0_o_0_ : IComparer<TreeNode>
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x00042234 File Offset: 0x00040434
		public Oooo_0_o_0_(bool A_0)
		{
			this.OO0o0.0OOo_. = A_0;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00042244 File Offset: 0x00040444
		public int <<EMPTY_NAME>>(TreeNode A_0, TreeNode A_1)
		{
			int result;
			if (Operators.CompareString(A_0.Text, "显示所有行", true) == 0)
			{
				result = -1;
			}
			else if (Operators.CompareString(A_1.Text, "显示所有行", true) == 0)
			{
				result = 1;
			}
			else
			{
				int x;
				int y;
				int num;
				if (int.TryParse(A_0.Name, out x) && int.TryParse(A_1.Name, out y))
				{
					num = Comparer<int>.Default.Compare(x, y);
				}
				else
				{
					num = Comparer<string>.Default.Compare(A_0.Name, A_1.Name);
				}
				if (num == 0)
				{
					num = string.Compare(A_0.OO_.O.(), A_1.OO_.O.());
				}
				if (this.OO0o0.0OOo_.)
				{
					num = -num;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x040002AA RID: 682
		private bool <<EMPTY_NAME>>;
	}
}
