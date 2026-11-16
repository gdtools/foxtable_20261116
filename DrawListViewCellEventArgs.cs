using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020001A8 RID: 424
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class DrawListViewCellEventArgs : ControlEventArgs
	{
		// Token: 0x060014D7 RID: 5335 RVA: 0x000973B0 File Offset: 0x000955B0
		public DrawListViewCellEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, ListViewRow A_2, int A_3, int A_4, DrawListViewSubItemEventArgs A_5) : base(A_0, A_1)
		{
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000973BA File Offset: 0x000955BA
		public void DrawDefault()
		{
			this.ooo_OOO.O0O..DrawDefault = true;
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x000973C8 File Offset: 0x000955C8
		public void DrawText()
		{
			this.ooo_OOO.O0O..DrawText();
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x000973D5 File Offset: 0x000955D5
		public void DrawBackGroud()
		{
			this.ooo_OOO.O0O..DrawBackground();
		}

		// Token: 0x0400083E RID: 2110
		private ListViewRow <<EMPTY_NAME>>;

		// Token: 0x0400083F RID: 2111
		private int <<EMPTY_NAME>>;

		// Token: 0x04000840 RID: 2112
		private DrawListViewSubItemEventArgs <<EMPTY_NAME>>;
	}
}
