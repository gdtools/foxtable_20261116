using System;
using System.Windows.Forms;
using C1.Win.C1GanttView;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000160 RID: 352
	public class GanttTaskEventArgs : ControlEventArgs
	{
		// Token: 0x060010B2 RID: 4274 RVA: 0x0007E403 File Offset: 0x0007C603
		public GanttTaskEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, CancelTaskArgs A_2) : base(A_0, A_1)
		{
			this.OooOOO0O_0.0. = A_2;
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0007E414 File Offset: 0x0007C614
		public Task Task
		{
			get
			{
				return (Task)this.OooOOO0O_0.0..Task;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0007E426 File Offset: 0x0007C626
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x0007E433 File Offset: 0x0007C633
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

		// Token: 0x04000676 RID: 1654
		private CancelTaskArgs <<EMPTY_NAME>>;
	}
}
