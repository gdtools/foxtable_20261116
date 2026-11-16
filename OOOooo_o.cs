using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x02000318 RID: 792
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OOOooo_o : IEnumerator<Col>
	{
		// Token: 0x06002AEB RID: 10987 RVA: 0x00131562 File Offset: 0x0012F762
		internal OOOooo_o(Table A_0)
		{
			this.Index = -1;
			this.disposedValue = false;
			this.Table = A_0;
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x00131580 File Offset: 0x0012F780
		public Col get_Current()
		{
			return this.Table.Cols[this.Table.foxGrid.Cols[this.Index + this.Table.foxGrid.Cols.Fixed].Name];
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x001315D4 File Offset: 0x0012F7D4
		public object get_Current1()
		{
			return this.Table.Cols[this.Table.foxGrid.Cols[this.Index + this.Table.foxGrid.Cols.Fixed].Name];
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x00131628 File Offset: 0x0012F828
		public bool MoveNext()
		{
			this.Index++;
			O_oOooO_O o_oOooO_O = this.Table.foxGrid;
			bool flag;
			if (this.Index + o_oOooO_O.Cols.Fixed > o_oOooO_O.Cols.Count - 1)
			{
				flag = false;
			}
			else
			{
				string name = this.Table.foxGrid.Cols[this.Index + this.Table.foxGrid.Cols.Fixed].Name;
				flag = (!o_O_o_oOoo__.oO.O_..Contains(name) || flag);
			}
			return flag;
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x001316BF File Offset: 0x0012F8BF
		public void Reset()
		{
			this.Index = -1;
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x001316C8 File Offset: 0x0012F8C8
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x001316DB File Offset: 0x0012F8DB
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x040011A6 RID: 4518
		private Table Table;

		// Token: 0x040011A7 RID: 4519
		private int Index;

		// Token: 0x040011A8 RID: 4520
		private bool disposedValue;
	}
}
