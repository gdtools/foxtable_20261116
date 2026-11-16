using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000A9 RID: 169
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o__000oO : IComparer<TreeNode>
	{
		// Token: 0x0600069C RID: 1692 RVA: 0x00030C75 File Offset: 0x0002EE75
		public o__000oO(Dictionary<TreeNode, DataRowView> A_0, string A_1, bool A_2)
		{
			this.OO0o0.0OOo_. = A_0;
			this.OO0o0.0OOo_. = new O0_(A_1, A_2);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00030C91 File Offset: 0x0002EE91
		public o__000oO(Dictionary<TreeNode, DataRowView> A_0, string A_1, bool A_2, char A_3)
		{
			this.OO0o0.0OOo_. = A_0;
			this.OO0o0.0OOo_. = new O0_(A_1, A_2, A_3);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00030CB0 File Offset: 0x0002EEB0
		public int <<EMPTY_NAME>>(TreeNode A_0, TreeNode A_1)
		{
			DataRowView dataRowView = null;
			DataRowView dataRowView2 = null;
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
				this.OO0o0.0OOo_..TryGetValue(A_0, out dataRowView);
				this.OO0o0.0OOo_..TryGetValue(A_1, out dataRowView2);
				if (dataRowView == null || dataRowView2 == null)
				{
					result = 0;
				}
				else
				{
					int num = this.OO0o0.0OOo_..Oo_00_oO.00O0O.(dataRowView, dataRowView2);
					if (num == 0)
					{
						result = Comparer.DefaultInvariant.Compare(A_0.Text, A_1.Text);
					}
					else
					{
						result = num;
					}
				}
			}
			return result;
		}

		// Token: 0x040001CE RID: 462
		private Dictionary<TreeNode, DataRowView> <<EMPTY_NAME>>;

		// Token: 0x040001CF RID: 463
		private O0_ <<EMPTY_NAME>>;
	}
}
