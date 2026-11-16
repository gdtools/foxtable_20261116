using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020001B1 RID: 433
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O0o : IEnumerator<ListViewColumn>
	{
		// Token: 0x06001524 RID: 5412 RVA: 0x00098499 File Offset: 0x00096699
		public O0o(System.Windows.Forms.ListView.ColumnHeaderCollection A_0)
		{
			this.Index = -1;
			this.disposedValue = false;
			this.Columns = A_0;
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000984B6 File Offset: 0x000966B6
		public ListViewColumn get_Current()
		{
			return new ListViewColumn(this.Columns[this.Index]);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000984CE File Offset: 0x000966CE
		public object get_Current1()
		{
			return new ListViewColumn(this.Columns[this.Index]);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000984E8 File Offset: 0x000966E8
		public bool MoveNext()
		{
			this.Index++;
			return this.Index <= this.Columns.Count - 1;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0009851F File Offset: 0x0009671F
		public void Reset()
		{
			this.Index = -1;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00098528 File Offset: 0x00096728
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0009853B File Offset: 0x0009673B
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000853 RID: 2131
		private System.Windows.Forms.ListView.ColumnHeaderCollection Columns;

		// Token: 0x04000854 RID: 2132
		private int Index;

		// Token: 0x04000855 RID: 2133
		private bool disposedValue;
	}
}
