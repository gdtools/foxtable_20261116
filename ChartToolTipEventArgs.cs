using System;
using System.Windows.Forms;
using C1.Win.C1Chart;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000156 RID: 342
	public class ChartToolTipEventArgs : ControlEventArgs
	{
		// Token: 0x06001079 RID: 4217 RVA: 0x0007E02F File Offset: 0x0007C22F
		public ChartToolTipEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, ShowTooltipEventArgs A_2) : base(A_0, A_1)
		{
			this.O_O0_.__O. = A_2;
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x0007E040 File Offset: 0x0007C240
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x0007E04D File Offset: 0x0007C24D
		public string ToolTipText
		{
			get
			{
				return this.O_O0_.__O..TooltipText;
			}
			set
			{
				this.O_O0_.__O..TooltipText = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x0007E05B File Offset: 0x0007C25B
		public int GroupIndex
		{
			get
			{
				return this.O_O0_.__O..GroupIndex;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x0007E068 File Offset: 0x0007C268
		public int SeriesIndex
		{
			get
			{
				return this.O_O0_.__O..SeriesIndex;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x0007E075 File Offset: 0x0007C275
		public int PointIndex
		{
			get
			{
				return this.O_O0_.__O..PointIndex;
			}
		}

		// Token: 0x04000664 RID: 1636
		private ShowTooltipEventArgs <<EMPTY_NAME>>;
	}
}
