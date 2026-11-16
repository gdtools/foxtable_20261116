using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020001B8 RID: 440
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O0_0oO__oo : IEnumerator<ListViewRow>
	{
		// Token: 0x06001586 RID: 5510 RVA: 0x000990DB File Offset: 0x000972DB
		public O0_0oO__oo(System.Windows.Forms.ListView.ListViewItemCollection A_0)
		{
			this.index = -1;
			this.disposedValue = false;
			this.items = A_0;
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x000990F8 File Offset: 0x000972F8
		public ListViewRow get_Current()
		{
			return new ListViewRow(this.items[this.index]);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00099110 File Offset: 0x00097310
		public object get_Current1()
		{
			return new ListViewRow(this.items[this.index]);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00099128 File Offset: 0x00097328
		public bool MoveNext()
		{
			this.index++;
			return this.index <= this.items.Count - 1;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0009915F File Offset: 0x0009735F
		public void Reset()
		{
			this.index = -1;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00099168 File Offset: 0x00097368
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0009917B File Offset: 0x0009737B
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000861 RID: 2145
		private System.Windows.Forms.ListView.ListViewItemCollection items;

		// Token: 0x04000862 RID: 2146
		private int index;

		// Token: 0x04000863 RID: 2147
		private bool disposedValue;
	}
}
