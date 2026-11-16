using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020002A5 RID: 677
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class oO0OOo0o__ : IEnumerator<Connection>
	{
		// Token: 0x06002275 RID: 8821 RVA: 0x000F7154 File Offset: 0x000F5354
		public oO0OOo0o__()
		{
			this.index = -1;
			this.disposedValue = false;
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000F716A File Offset: 0x000F536A
		public Connection get_Current()
		{
			return OO_00oOO.Connections[this.index];
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x000F7181 File Offset: 0x000F5381
		public object get_Current1()
		{
			return OO_00oOO.Connections[this.index];
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x000F7198 File Offset: 0x000F5398
		public bool MoveNext()
		{
			this.index++;
			return this.index < OO_00oOO.Connections.Count;
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x000F71BA File Offset: 0x000F53BA
		public void Reset()
		{
			this.index = -1;
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x000F71C3 File Offset: 0x000F53C3
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x000F71D6 File Offset: 0x000F53D6
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000E4B RID: 3659
		private int index;

		// Token: 0x04000E4C RID: 3660
		private bool disposedValue;
	}
}
