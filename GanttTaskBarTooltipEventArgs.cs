using System;
using System.Windows.Forms;
using C1.Win.C1GanttView;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000162 RID: 354
	public class GanttTaskBarTooltipEventArgs : ControlEventArgs
	{
		// Token: 0x060010BA RID: 4282 RVA: 0x0007E4B5 File Offset: 0x0007C6B5
		public GanttTaskBarTooltipEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, TaskBarTooltipEventArgs A_2) : base(A_0, A_1)
		{
			this.O0_.0O0o. = A_2;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x0007E4C6 File Offset: 0x0007C6C6
		public Task Task
		{
			get
			{
				return (Task)this.O0_.0O0o..Task;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x0007E4D8 File Offset: 0x0007C6D8
		// (set) Token: 0x060010BD RID: 4285 RVA: 0x0007E4E5 File Offset: 0x0007C6E5
		public string Tooltip
		{
			get
			{
				return this.O0_.0O0o..Tooltip;
			}
			set
			{
				this.O0_.0O0o..Tooltip = value;
			}
		}

		// Token: 0x04000678 RID: 1656
		private TaskBarTooltipEventArgs <<EMPTY_NAME>>;
	}
}
