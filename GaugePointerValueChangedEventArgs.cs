using System;
using System.ComponentModel;
using System.Windows.Forms;
using C1.Win.C1Gauge;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200015C RID: 348
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class GaugePointerValueChangedEventArgs : ControlEventArgs
	{
		// Token: 0x06001097 RID: 4247 RVA: 0x0007E26E File Offset: 0x0007C46E
		public GaugePointerValueChangedEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, C1GaugeBase A_2, C1Gauge A_3, C1GaugePointer A_4) : base(A_0, A_1)
		{
			this.O0_O0_.O. = A_2;
			this.O0_O0_.O. = A_3;
			this.O0__._0o. = A_4;
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x0007E28F File Offset: 0x0007C48F
		public C1GaugeBase Gauge
		{
			get
			{
				return this.O0_O0_.O.;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0007E297 File Offset: 0x0007C497
		public C1Gauge Container
		{
			get
			{
				return this.O0_O0_.O.;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0007E29F File Offset: 0x0007C49F
		public C1GaugePointer Pointer
		{
			get
			{
				return this.O0__._0o.;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0007E2A7 File Offset: 0x0007C4A7
		public bool IsMainPointer
		{
			get
			{
				return this.O0__._0o..IsMainPointer;
			}
		}

		// Token: 0x0400066B RID: 1643
		private C1GaugeBase <<EMPTY_NAME>>;

		// Token: 0x0400066C RID: 1644
		private C1Gauge <<EMPTY_NAME>>;

		// Token: 0x0400066D RID: 1645
		private C1GaugePointer <<EMPTY_NAME>>;
	}
}
