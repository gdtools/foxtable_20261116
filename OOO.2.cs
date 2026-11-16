using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020000C3 RID: 195
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OOO : IComparer
	{
		// Token: 0x0600085B RID: 2139 RVA: 0x000422E6 File Offset: 0x000404E6
		public OOO(string A_0, bool A_1, bool A_2)
		{
			this.o_0ooO.Oo. = '\0';
			this.O_OOO.0o. = new O0_(A_0, A_1);
			this.O_OOO.0o. = A_2;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00042309 File Offset: 0x00040509
		public OOO(string A_0, bool A_1, bool A_2, char A_3)
		{
			this.o_0ooO.Oo. = '\0';
			this.O_OOO.0o. = new O0_(A_0, A_1, A_3);
			this.O_OOO.0o. = A_2;
			this.o_0ooO.Oo. = A_3;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00042338 File Offset: 0x00040538
		public int <<EMPTY_NAME>>(object A_0, object A_1)
		{
			if (!this.O_OOO.0o.)
			{
				int num = string.Compare(((TreeNode)A_0).Name, ((TreeNode)A_1).Name);
				if (num != 0)
				{
					return num;
				}
			}
			int num2 = this.O_OOO.0o..Oo_00_oO.00O0O.((DataRowView)((TreeNode)A_0).Tag, (DataRowView)((TreeNode)A_1).Tag);
			int result;
			if (num2 == 0)
			{
				result = string.Compare(((TreeNode)A_0).Text, ((TreeNode)A_1).Text);
			}
			else
			{
				result = num2;
			}
			return result;
		}

		// Token: 0x040002AB RID: 683
		private O0_ <<EMPTY_NAME>>;

		// Token: 0x040002AC RID: 684
		private bool <<EMPTY_NAME>>;

		// Token: 0x040002AD RID: 685
		private char <<EMPTY_NAME>>;
	}
}
