using System;
using System.Collections.Generic;
using System.Windows.Forms;
using C1.Win.C1GanttView;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000161 RID: 353
	public class GanttTasksEventArgs : ControlEventArgs
	{
		// Token: 0x060010B6 RID: 4278 RVA: 0x0007E441 File Offset: 0x0007C641
		public GanttTasksEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, CancelTasksArgs A_2) : base(A_0, A_1)
		{
			this.OooOOO0O_0.0. = A_2;
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x0007E454 File Offset: 0x0007C654
		public List<Task> Tasks
		{
			get
			{
				List<Task> list = new List<Task>();
				foreach (BaseTask baseTask in this.OooOOO0O_0.0..Tasks)
				{
					if (baseTask is Task)
					{
						list.Add((Task)baseTask);
					}
				}
				return list;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0007E49A File Offset: 0x0007C69A
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x0007E4A7 File Offset: 0x0007C6A7
		public virtual bool Cancel
		{
			get
			{
				return this.OooOOO0O_0.0..Cancel;
			}
			set
			{
				this.OooOOO0O_0.0..Cancel = true;
			}
		}

		// Token: 0x04000677 RID: 1655
		private CancelTasksArgs <<EMPTY_NAME>>;
	}
}
