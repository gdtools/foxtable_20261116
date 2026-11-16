using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;

namespace Foxtable
{
	// Token: 0x020002AB RID: 683
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O__ : IEnumerator<DataRow>
	{
		// Token: 0x0600239C RID: 9116 RVA: 0x000FD932 File Offset: 0x000FBB32
		public O__(DataRow[] A_0)
		{
			this._Index = -1;
			this.disposedValue = false;
			this._Rows = A_0;
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x000FD94F File Offset: 0x000FBB4F
		public DataRow get_Current()
		{
			return new DataRow(this._Rows[this._Index]);
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x000FD963 File Offset: 0x000FBB63
		public object get_Current1()
		{
			return new DataRow(this._Rows[this._Index]);
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x000FD978 File Offset: 0x000FBB78
		public bool MoveNext()
		{
			this._Index++;
			return this._Index < this._Rows.Length;
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x000FD9AA File Offset: 0x000FBBAA
		public void Reset()
		{
			this._Index = -1;
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x000FD9B3 File Offset: 0x000FBBB3
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x000FD9C6 File Offset: 0x000FBBC6
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000EB7 RID: 3767
		private DataRow[] _Rows;

		// Token: 0x04000EB8 RID: 3768
		private int _Index;

		// Token: 0x04000EB9 RID: 3769
		private bool disposedValue;
	}
}
