using System;
using System.Windows.Forms;
using C1.Win.C1GanttView;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000164 RID: 356
	public class GanttTaskBarClickEventArgs : ControlEventArgs
	{
		// Token: 0x060010C3 RID: 4291 RVA: 0x0007E53E File Offset: 0x0007C73E
		public GanttTaskBarClickEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, TaskBarClickEventArgs A_2) : base(A_0, A_1)
		{
			this.O0_.0O0o. = A_2;
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0007E54F File Offset: 0x0007C74F
		public Task Task
		{
			get
			{
				return (Task)this.O0_.0O0o..Task;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x0007E561 File Offset: 0x0007C761
		public MouseButtons Button
		{
			get
			{
				return this.O0_.0O0o..Button;
			}
		}

		// Token: 0x0400067A RID: 1658
		private TaskBarClickEventArgs <<EMPTY_NAME>>;
	}
}
