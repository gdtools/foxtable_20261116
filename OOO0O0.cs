using System;
using System.Collections.Generic;
using System.ComponentModel;
using C1.Win.C1Command;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003C9 RID: 969
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OOO0O0 : IEnumerator<NavPage>
	{
		// Token: 0x06003F74 RID: 16244 RVA: 0x001D0EBC File Offset: 0x001CF0BC
		public OOO0O0(C1NavBarPanel.PanelCollection A_0)
		{
			this.Index = -1;
			this.disposedValue = false;
			this.panels = A_0;
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x001D0ED9 File Offset: 0x001CF0D9
		public NavPage get_Current()
		{
			return (NavPage)this.panels[this.Index];
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x001D0EF1 File Offset: 0x001CF0F1
		public object get_Current1()
		{
			return (NavPage)this.panels[this.Index];
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x001D0F0C File Offset: 0x001CF10C
		public bool MoveNext()
		{
			this.Index++;
			return this.Index < this.panels.Count;
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x001D0F41 File Offset: 0x001CF141
		public void Reset()
		{
			this.Index = -1;
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x001D0F4A File Offset: 0x001CF14A
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposedValue)
			{
			}
			this.disposedValue = true;
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x001D0F5D File Offset: 0x001CF15D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x040019DE RID: 6622
		private C1NavBarPanel.PanelCollection panels;

		// Token: 0x040019DF RID: 6623
		private int Index;

		// Token: 0x040019E0 RID: 6624
		private bool disposedValue;
	}
}
