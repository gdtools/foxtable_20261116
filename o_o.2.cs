using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000C8 RID: 200
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o_o : IComparer<TreeNode>
	{
		// Token: 0x0600090A RID: 2314 RVA: 0x0004A54D File Offset: 0x0004874D
		public o_o(bool A_0)
		{
			this.OO0o0.0OOo_. = A_0;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0004A55C File Offset: 0x0004875C
		public int <<EMPTY_NAME>>(TreeNode A_0, TreeNode A_1)
		{
			string text = A_0.Text;
			string text2 = A_1.Text;
			int result;
			if (Operators.CompareString(text, "显示所有行", true) == 0)
			{
				result = -1;
			}
			else if (Operators.CompareString(text2, "显示所有行", true) == 0)
			{
				result = 1;
			}
			else
			{
				if (text.IndexOf("(") > 0 && text.EndsWith(")"))
				{
					text = text.Substring(0, text.IndexOf("("));
				}
				if (text2.IndexOf("(") > 0 && text2.EndsWith(")"))
				{
					text2 = text2.Substring(0, text2.IndexOf("("));
				}
				if (this.OO0o0.0OOo_.)
				{
					result = -string.Compare(A_0.Text, A_1.Text, true);
				}
				else
				{
					result = string.Compare(A_0.Text, A_1.Text, true);
				}
			}
			return result;
		}

		// Token: 0x0400032C RID: 812
		private bool <<EMPTY_NAME>>;
	}
}
