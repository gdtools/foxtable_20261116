using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003D3 RID: 979
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O_oO__o0 : IEnumerator<Foxtable.WinForm.TreeNode>
	{
		// Token: 0x06003FE1 RID: 16353 RVA: 0x001D1C48 File Offset: 0x001CFE48
		public O_oO__o0(TreeNodeCollection A_0)
		{
			this.Index = -1;
			this.disposedValue = false;
			this.Nodes = A_0;
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x001D1C65 File Offset: 0x001CFE65
		public Foxtable.WinForm.TreeNode get_Current()
		{
			return new Foxtable.WinForm.TreeNode((O_o__00Ooo)this.Nodes[this.Index]);
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x001D1C82 File Offset: 0x001CFE82
		public object get_Current1()
		{
			return new Foxtable.WinForm.TreeNode((O_o__00Ooo)this.Nodes[this.Index]);
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x001D1CA0 File Offset: 0x001CFEA0
		public bool MoveNext()
		{
			this.Index++;
			return this.Index < this.Nodes.Count;
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x001D1CD5 File Offset: 0x001CFED5
		public void Reset()
		{
			this.Index = -1;
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x001D1CDE File Offset: 0x001CFEDE
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x001D1CF1 File Offset: 0x001CFEF1
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x040019F2 RID: 6642
		private TreeNodeCollection Nodes;

		// Token: 0x040019F3 RID: 6643
		private int Index;

		// Token: 0x040019F4 RID: 6644
		private bool disposedValue;
	}
}
