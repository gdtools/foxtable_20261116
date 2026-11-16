using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Chart;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000153 RID: 339
	public class ChartEventArgs : ControlEventArgs
	{
		// Token: 0x06001068 RID: 4200 RVA: 0x0007DDC0 File Offset: 0x0007BFC0
		public ChartEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1) : base(A_0, A_1)
		{
			this.o.OO. = -1;
			this.o0OO.000_o. = -1;
			this.O.o_Ooooo0OO_. = -1;
			this.o.OO. = (C1Chart)A_0;
			int num = -1;
			Point p = System.Windows.Forms.Control.MousePosition;
			p = this.o.OO..PointToClient(p);
			this.ooo_.Oo_. = p.X;
			this.O.0oO. = p.Y;
			if (this.o.OO..ChartGroups[0].CoordToDataIndex(p.X, p.Y, CoordinateFocusEnum.XandYCoord, ref this.o.OO., ref this.o0OO.000_o., ref num))
			{
				if (num <= 6)
				{
					this.O.o_Ooooo0OO_. = 0;
					return;
				}
				this.o.OO. = -1;
				this.o0OO.000_o. = -1;
			}
			if (this.o.OO..ChartGroups[1].CoordToDataIndex(p.X, p.Y, CoordinateFocusEnum.XandYCoord, ref this.o.OO., ref this.o0OO.000_o., ref num))
			{
				if (num <= 6)
				{
					this.O.o_Ooooo0OO_. = 1;
					return;
				}
				this.o.OO. = -1;
				this.o0OO.000_o. = -1;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x0007DEC3 File Offset: 0x0007C0C3
		public int SeriesIndex
		{
			get
			{
				return this.o.OO.;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x0007DECB File Offset: 0x0007C0CB
		public int PointsIndex
		{
			get
			{
				return this.o0OO.000_o.;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x0007DED3 File Offset: 0x0007C0D3
		public int GroupsIndex
		{
			get
			{
				return this.O.o_Ooooo0OO_.;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x0007DEDB File Offset: 0x0007C0DB
		public int X
		{
			get
			{
				return this.ooo_.Oo_.;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x0007DEE3 File Offset: 0x0007C0E3
		public int Y
		{
			get
			{
				return this.O.0oO.;
			}
		}

		// Token: 0x04000657 RID: 1623
		private C1Chart <<EMPTY_NAME>>;

		// Token: 0x04000658 RID: 1624
		private readonly int <<EMPTY_NAME>>;

		// Token: 0x04000659 RID: 1625
		private readonly int <<EMPTY_NAME>>;

		// Token: 0x0400065A RID: 1626
		private readonly int <<EMPTY_NAME>>;

		// Token: 0x0400065B RID: 1627
		private int <<EMPTY_NAME>>;

		// Token: 0x0400065C RID: 1628
		private int <<EMPTY_NAME>>;
	}
}
