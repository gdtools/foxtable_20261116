using System;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000158 RID: 344
	public class GannttStripItemClikEventArgs : ControlEventArgs
	{
		// Token: 0x06001084 RID: 4228 RVA: 0x0007E153 File Offset: 0x0007C353
		public GannttStripItemClikEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, ToolStripItemClickedEventArgs A_2) : base(A_0, A_1)
		{
			this.Oo.0_O00_. = A_2;
			this.Oo.0_O00_. = (GanttView)A_0;
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x0007E170 File Offset: 0x0007C370
		public GanttView GanttView
		{
			get
			{
				return this.Oo.0_O00_.;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x0007E178 File Offset: 0x0007C378
		public StripItem StripItem
		{
			get
			{
				return new StripItem(this.Oo.0_O00_..ClickedItem, base.Form);
			}
		}

		// Token: 0x04000666 RID: 1638
		private ToolStripItemClickedEventArgs <<EMPTY_NAME>>;

		// Token: 0x04000667 RID: 1639
		private GanttView <<EMPTY_NAME>>;
	}
}
