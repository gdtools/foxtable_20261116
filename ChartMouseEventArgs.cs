using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Chart;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000154 RID: 340
	public class ChartMouseEventArgs : ControlMouseEventArgs
	{
		// Token: 0x0600106E RID: 4206 RVA: 0x0007DEEC File Offset: 0x0007C0EC
		public ChartMouseEventArgs(System.Windows.Forms.Control A_0, MouseButtons A_1, int A_2, int A_3, int A_4, int A_5, Foxtable.WinForm.Form A_6) : base(A_0, A_1, A_2, A_3, A_4, A_5, A_6)
		{
			this.OOO.o_oo0o0ooO. = -1;
			this.oOo_.Oo. = -1;
			this.OOO.o_oo0o0ooO. = (C1Chart)A_0;
			int num = -1;
			Point p = System.Windows.Forms.Control.MousePosition;
			p = this.OOO.o_oo0o0ooO..PointToClient(p);
			if (this.OOO.o_oo0o0ooO..ChartGroups[0].CoordToDataIndex(p.X, p.Y, CoordinateFocusEnum.XandYCoord, ref this.OOO.o_oo0o0ooO., ref this.oOo_.Oo., ref num) && num > 6)
			{
				this.OOO.o_oo0o0ooO. = -1;
				this.oOo_.Oo. = -1;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x0007DF80 File Offset: 0x0007C180
		public int SeriesIndex
		{
			get
			{
				return this.OOO.o_oo0o0ooO.;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x0007DF88 File Offset: 0x0007C188
		public int PointsIndex
		{
			get
			{
				return this.oOo_.Oo.;
			}
		}

		// Token: 0x0400065D RID: 1629
		private C1Chart <<EMPTY_NAME>>;

		// Token: 0x0400065E RID: 1630
		private readonly int <<EMPTY_NAME>>;

		// Token: 0x0400065F RID: 1631
		private readonly int <<EMPTY_NAME>>;
	}
}
