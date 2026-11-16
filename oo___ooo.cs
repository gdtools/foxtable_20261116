using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x020004D4 RID: 1236
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class oo___ooo : Oo0__O__O_0__
	{
		// Token: 0x06005174 RID: 20852 RVA: 0x002448CB File Offset: 0x00242ACB
		public oo___ooo()
		{
			this.o00.oo0__00. = new List<DataRow>();
			this.o00.oo0__00. = new List<object>();
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x002448E9 File Offset: 0x00242AE9
		internal void <<EMPTY_NAME>>(DataRow A_0)
		{
			this.o00.oo0__00..Add(A_0);
			this.o00.oo0__00..Add(RuntimeHelpers.GetObjectValue(A_0["_Locked"]));
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x00244912 File Offset: 0x00242B12
		public void <<EMPTY_NAME>>()
		{
			this.o00.oo0__00.();
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x0024491C File Offset: 0x00242B1C
		public void <<EMPTY_NAME>>()
		{
			int num = this.o00.oo0__00..Count - 1;
			for (int i = 0; i <= num; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.o00.oo0__00.[i]["_Locked"]);
				this.o00.oo0__00.[i]["_Locked"] = RuntimeHelpers.GetObjectValue(this.o00.oo0__00.[i]);
				this.o00.oo0__00.[i] = RuntimeHelpers.GetObjectValue(objectValue);
				if (OO_00oOO.DataTables[this.o00.oo0__00.[i].Table.TableName].frd_IsInnerTable)
				{
					Oo00.o0_o._O_.(this.o00.oo0__00.[i]);
				}
			}
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x002449D6 File Offset: 0x00242BD6
		public int <<EMPTY_NAME>>()
		{
			return this.o00.oo0__00..Count;
		}

		// Token: 0x04002174 RID: 8564
		private List<DataRow> <<EMPTY_NAME>>;

		// Token: 0x04002175 RID: 8565
		private List<object> <<EMPTY_NAME>>;
	}
}
