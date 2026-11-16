using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020004D5 RID: 1237
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OOoO : Oo0__O__O_0__
	{
		// Token: 0x06005179 RID: 20857 RVA: 0x002449E3 File Offset: 0x00242BE3
		public OOoO()
		{
			this.O__O_._. = new List<DataCol>();
			this.O__O_._. = new List<bool>();
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x00244A01 File Offset: 0x00242C01
		internal void <<EMPTY_NAME>>(DataCol A_0)
		{
			this.O__O_._..Add(A_0);
			this.O__O_._..Add(A_0.AllowEdit);
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x00244A20 File Offset: 0x00242C20
		public void <<EMPTY_NAME>>()
		{
			this.O__O_._.();
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x00244A28 File Offset: 0x00242C28
		public void <<EMPTY_NAME>>()
		{
			int num = this.O__O_._..Count - 1;
			for (int i = 0; i <= num; i++)
			{
				bool allowEdit = this.O__O_._.[i].AllowEdit;
				this.O__O_._.[i].AllowEdit = this.O__O_._.[i];
				this.O__O_._.[i] = allowEdit;
			}
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x00244A8B File Offset: 0x00242C8B
		public int <<EMPTY_NAME>>()
		{
			return this.O__O_._..Count;
		}

		// Token: 0x04002176 RID: 8566
		private List<DataCol> <<EMPTY_NAME>>;

		// Token: 0x04002177 RID: 8567
		private List<bool> <<EMPTY_NAME>>;
	}
}
