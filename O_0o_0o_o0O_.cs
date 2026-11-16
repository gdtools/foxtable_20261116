using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x0200031B RID: 795
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class O_0o_0o_o0O_ : IEnumerator<Row>
	{
		// Token: 0x06002B2E RID: 11054 RVA: 0x00133E3E File Offset: 0x0013203E
		internal O_0o_0o_o0O_(Table A_0)
		{
			this.index = -1;
			this.disposedValue = false;
			this.Table = A_0;
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x00133E5B File Offset: 0x0013205B
		public Row get_Current()
		{
			return this.Table[this.index, false];
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x00133E6F File Offset: 0x0013206F
		public object get_Current1()
		{
			return this.Table[this.index, false];
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x00133E84 File Offset: 0x00132084
		public bool MoveNext()
		{
			this.index++;
			return this.index <= this.Table.ooO__oo0O.0.(false) - 1;
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00133EBC File Offset: 0x001320BC
		public void Reset()
		{
			this.index = -1;
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00133EC5 File Offset: 0x001320C5
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00133ED8 File Offset: 0x001320D8
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x040011AE RID: 4526
		private Table Table;

		// Token: 0x040011AF RID: 4527
		private int index;

		// Token: 0x040011B0 RID: 4528
		private bool disposedValue;
	}
}
