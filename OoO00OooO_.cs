using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200017E RID: 382
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class OoO00OooO_ : IEnumerator<Strip>
	{
		// Token: 0x0600122C RID: 4652 RVA: 0x00080B79 File Offset: 0x0007ED79
		public OoO00OooO_(List<ToolStrip> A_0, Foxtable.WinForm.Form A_1)
		{
			this.O._0o0O_oo_o. = -1;
			this.O._0o0O_oo_o. = false;
			this.O._0o0O_oo_o. = A_0;
			this.O._0o0O_oo_o. = A_1;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00080B9D File Offset: 0x0007ED9D
		public Strip <<EMPTY_NAME>>()
		{
			return new Strip(this.O._0o0O_oo_o.[this.O._0o0O_oo_o.], this.O._0o0O_oo_o.);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00080BBB File Offset: 0x0007EDBB
		public object <<EMPTY_NAME>>()
		{
			return new Strip(this.O._0o0O_oo_o.[this.O._0o0O_oo_o.], this.O._0o0O_oo_o.);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00080BDC File Offset: 0x0007EDDC
		public bool <<EMPTY_NAME>>()
		{
			this.O._0o0O_oo_o.++;
			return this.O._0o0O_oo_o. < this.O._0o0O_oo_o..Count;
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00080C11 File Offset: 0x0007EE11
		public void <<EMPTY_NAME>>()
		{
			this.O._0o0O_oo_o. = -1;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00080C1A File Offset: 0x0007EE1A
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (!this.O._0o0O_oo_o.)
			{
			}
			this.O._0o0O_oo_o. = true;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00080C2D File Offset: 0x0007EE2D
		public void <<EMPTY_NAME>>()
		{
			this.O._0o0O_oo_o.(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x040006F8 RID: 1784
		private List<ToolStrip> <<EMPTY_NAME>>;

		// Token: 0x040006F9 RID: 1785
		private int <<EMPTY_NAME>>;

		// Token: 0x040006FA RID: 1786
		internal Foxtable.WinForm.Form <<EMPTY_NAME>>;

		// Token: 0x040006FB RID: 1787
		private bool <<EMPTY_NAME>>;
	}
}
