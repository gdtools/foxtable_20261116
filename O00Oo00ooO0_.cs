using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000181 RID: 385
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O00Oo00ooO0_ : IEnumerator<StripItem>
	{
		// Token: 0x0600125E RID: 4702 RVA: 0x00081369 File Offset: 0x0007F569
		public O00Oo00ooO0_(ToolStripItemCollection A_0, Foxtable.WinForm.Form A_1)
		{
			this.Ooo0.o. = -1;
			this.Ooo0.o. = false;
			this.Ooo0.o. = A_0;
			this.Ooo0.o. = A_1;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0008138D File Offset: 0x0007F58D
		public StripItem <<EMPTY_NAME>>()
		{
			return new StripItem(this.Ooo0.o.[this.Ooo0.o.], this.Ooo0.o.);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000813AB File Offset: 0x0007F5AB
		public object <<EMPTY_NAME>>()
		{
			return new StripItem(this.Ooo0.o.[this.Ooo0.o.], this.Ooo0.o.);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000813CC File Offset: 0x0007F5CC
		public bool <<EMPTY_NAME>>()
		{
			this.Ooo0.o.++;
			return this.Ooo0.o. < this.Ooo0.o..Count;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00081401 File Offset: 0x0007F601
		public void <<EMPTY_NAME>>()
		{
			this.Ooo0.o. = -1;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0008140A File Offset: 0x0007F60A
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (!this.Ooo0.o.)
			{
			}
			this.Ooo0.o. = true;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x0008141D File Offset: 0x0007F61D
		public void <<EMPTY_NAME>>()
		{
			this.OOOOO.Oo_Oo.(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000700 RID: 1792
		private ToolStripItemCollection <<EMPTY_NAME>>;

		// Token: 0x04000701 RID: 1793
		private int <<EMPTY_NAME>>;

		// Token: 0x04000702 RID: 1794
		private Foxtable.WinForm.Form <<EMPTY_NAME>>;

		// Token: 0x04000703 RID: 1795
		private bool <<EMPTY_NAME>>;
	}
}
