using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000097 RID: 151
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o_oo : IComparer<DataRow>
	{
		// Token: 0x060005E7 RID: 1511 RVA: 0x0002F7AE File Offset: 0x0002D9AE
		public o_oo(string A_0, bool A_1)
		{
			this.OO0._o_00000. = A_0;
			this.OO0._o_00000. = A_1;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0002F7C4 File Offset: 0x0002D9C4
		private int <<EMPTY_NAME>>(DataRow A_0, DataRow A_1)
		{
			int num = 0;
			int result;
			if (A_0.IsNull(this.OO0._o_00000.) && A_1.IsNull(this.OO0._o_00000.))
			{
				result = -1;
			}
			else
			{
				if (A_0.IsNull(this.OO0._o_00000.) || A_1.IsNull(this.OO0._o_00000.))
				{
					if (!A_0.IsNull(this.OO0._o_00000.))
					{
						num = 1;
					}
					else if (!A_1.IsNull(this.OO0._o_00000.))
					{
						num = -1;
					}
				}
				else
				{
					num = Comparer.DefaultInvariant.Compare(RuntimeHelpers.GetObjectValue(A_0[this.OO0._o_00000.]), RuntimeHelpers.GetObjectValue(A_1[this.OO0._o_00000.]));
				}
				if (!this.OO0._o_00000.)
				{
					result = num;
				}
				else
				{
					result = -num;
				}
			}
			return result;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0002F870 File Offset: 0x0002DA70
		public int <<EMPTY_NAME>>(DataRow A_0, DataRow A_1)
		{
			int result;
			if (A_0 == null || A_1 == null)
			{
				if (A_0 != null)
				{
					result = 1;
				}
				else if (A_1 != null)
				{
					result = -1;
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = this.OO0._o_00000.(A_0, A_1);
			}
			return result;
		}

		// Token: 0x04000180 RID: 384
		private string <<EMPTY_NAME>>;

		// Token: 0x04000181 RID: 385
		private bool <<EMPTY_NAME>>;
	}
}
