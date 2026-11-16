using System;
using System.ComponentModel;
using System.Windows.Forms;
using C1.Win.C1Gauge;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000159 RID: 345
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class GaugeItemEventArgs : ControlEventArgs
	{
		// Token: 0x06001087 RID: 4231 RVA: 0x0007E190 File Offset: 0x0007C390
		public GaugeItemEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, ItemEventArgs A_2) : base(A_0, A_1)
		{
			this.ooo.0_. = A_2;
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0007E1A1 File Offset: 0x0007C3A1
		public C1GaugeBase Gauge
		{
			get
			{
				return this.ooo.0_..Gauge;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0007E1AE File Offset: 0x0007C3AE
		public C1Gauge Container
		{
			get
			{
				return this.ooo.0_..Container;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600108A RID: 4234 RVA: 0x0007E1BB File Offset: 0x0007C3BB
		public object Item
		{
			get
			{
				return this.ooo.0_..Item;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x0007E1C8 File Offset: 0x0007C3C8
		public bool ItemEnabled
		{
			get
			{
				return this.ooo.0_..ItemEnabled;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x0007E1D5 File Offset: 0x0007C3D5
		public bool ItemHot
		{
			get
			{
				return this.ooo.0_..ItemHot;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x0007E1E2 File Offset: 0x0007C3E2
		public bool ItemPressed
		{
			get
			{
				return this.ooo.0_..ItemPressed;
			}
		}

		// Token: 0x04000668 RID: 1640
		private ItemEventArgs <<EMPTY_NAME>>;
	}
}
