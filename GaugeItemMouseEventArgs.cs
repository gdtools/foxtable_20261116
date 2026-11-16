using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Gauge;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200015A RID: 346
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class GaugeItemMouseEventArgs : GaugeItemEventArgs
	{
		// Token: 0x0600108E RID: 4238 RVA: 0x0007E1EF File Offset: 0x0007C3EF
		public GaugeItemMouseEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, ItemMouseEventArgs A_2) : base(A_0, A_1, A_2)
		{
			this.O0_O0_.O. = A_2;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x0007E201 File Offset: 0x0007C401
		public MouseButtons Button
		{
			get
			{
				return this.O0_O0_.O..Button;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x0007E20E File Offset: 0x0007C40E
		public int Clicks
		{
			get
			{
				return this.O0_O0_.O..Clicks;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0007E21B File Offset: 0x0007C41B
		public Point Location
		{
			get
			{
				return this.O0_O0_.O..Location;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x0007E228 File Offset: 0x0007C428
		public int X
		{
			get
			{
				return this.O0_O0_.O..X;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x0007E235 File Offset: 0x0007C435
		public int Y
		{
			get
			{
				return this.O0_O0_.O..Y;
			}
		}

		// Token: 0x04000669 RID: 1641
		private ItemMouseEventArgs <<EMPTY_NAME>>;
	}
}
