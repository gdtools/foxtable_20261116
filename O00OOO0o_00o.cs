using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020004DC RID: 1244
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O00OOO0o_00o : Oo0__O__O_0__
	{
		// Token: 0x06005193 RID: 20883 RVA: 0x002456EC File Offset: 0x002438EC
		public O00OOO0o_00o(Table A_0, int A_1, int A_2)
		{
			this.O.OooO. = A_0;
			this.O.OooO. = A_1;
			if (A_2 == -1)
			{
				this.o._Oo__. = A_0.foxGrid.Rows.DefaultSize;
				return;
			}
			this.o._Oo__. = A_2;
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x00245724 File Offset: 0x00243924
		public void <<EMPTY_NAME>>()
		{
			this.O.OooO.();
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x0024572C File Offset: 0x0024392C
		public void <<EMPTY_NAME>>()
		{
			O_oOooO_O o_oOooO_O = this.O.OooO..foxGrid;
			int num;
			if (o_oOooO_O.Rows[this.O.OooO.].Height == -1)
			{
				num = o_oOooO_O.Rows.DefaultSize;
			}
			else
			{
				num = o_oOooO_O.Rows[this.O.OooO.].Height;
			}
			o_oOooO_O.Rows[this.O.OooO.].Height = this.o._Oo__.;
			this.o._Oo__. = num;
		}

		// Token: 0x0400218B RID: 8587
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400218C RID: 8588
		private int <<EMPTY_NAME>>;

		// Token: 0x0400218D RID: 8589
		private int <<EMPTY_NAME>>;
	}
}
