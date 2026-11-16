using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1GanttView;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000163 RID: 355
	public class GanttPaintDayEventArgs : ControlEventArgs
	{
		// Token: 0x060010BE RID: 4286 RVA: 0x0007E4F3 File Offset: 0x0007C6F3
		public GanttPaintDayEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, PaintDayEventArgs A_2) : base(A_0, A_1)
		{
			this.O0_.0O0o. = A_2;
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x0007E504 File Offset: 0x0007C704
		public Task Task
		{
			get
			{
				return (Task)this.O0_.0O0o..Task;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x0007E516 File Offset: 0x0007C716
		public DateTime Date
		{
			get
			{
				return this.O0_.0O0o..Date;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x0007E523 File Offset: 0x0007C723
		public DateTime DateTime
		{
			get
			{
				return this.O0_.0O0o..DateTime;
			}
		}

		// Token: 0x170002EF RID: 751
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x0007E530 File Offset: 0x0007C730
		public Color BackColor
		{
			set
			{
				this.O0_.0O0o..BackColor = value;
			}
		}

		// Token: 0x04000679 RID: 1657
		private PaintDayEventArgs <<EMPTY_NAME>>;
	}
}
