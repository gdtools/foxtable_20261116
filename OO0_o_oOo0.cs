using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020001B4 RID: 436
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OO0_o_oOo0 : IEnumerator<Foxtable.WinForm.ListViewGroup>
	{
		// Token: 0x06001541 RID: 5441 RVA: 0x00098740 File Offset: 0x00096940
		public OO0_o_oOo0(ListViewGroupCollection A_0)
		{
			this.Index = -1;
			this.disposedValue = false;
			this.Groups = A_0;
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0009875D File Offset: 0x0009695D
		public Foxtable.WinForm.ListViewGroup get_Current()
		{
			return new Foxtable.WinForm.ListViewGroup(this.Groups[this.Index]);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00098775 File Offset: 0x00096975
		public object get_Current1()
		{
			return new Foxtable.WinForm.ListViewGroup(this.Groups[this.Index]);
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00098790 File Offset: 0x00096990
		public bool MoveNext()
		{
			this.Index++;
			return this.Index <= this.Groups.Count - 1;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x000987C7 File Offset: 0x000969C7
		public void Reset()
		{
			this.Index = -1;
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x000987D0 File Offset: 0x000969D0
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x000987E3 File Offset: 0x000969E3
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000858 RID: 2136
		private ListViewGroupCollection Groups;

		// Token: 0x04000859 RID: 2137
		private int Index;

		// Token: 0x0400085A RID: 2138
		private bool disposedValue;
	}
}
