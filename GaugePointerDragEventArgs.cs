using System;
using System.ComponentModel;
using System.Windows.Forms;
using C1.Win.C1Gauge;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200015B RID: 347
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class GaugePointerDragEventArgs : GaugeItemMouseEventArgs
	{
		// Token: 0x06001094 RID: 4244 RVA: 0x0007E242 File Offset: 0x0007C442
		public GaugePointerDragEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, PointerDragEventArgs A_2) : base(A_0, A_1, A_2)
		{
			this.O0_O0_.O. = A_2;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x0007E254 File Offset: 0x0007C454
		public C1GaugePointer Pointer
		{
			get
			{
				return this.O0_O0_.O..Pointer;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0007E261 File Offset: 0x0007C461
		public double NewValue
		{
			get
			{
				return this.O0_O0_.O..NewValue;
			}
		}

		// Token: 0x0400066A RID: 1642
		private PointerDragEventArgs <<EMPTY_NAME>>;
	}
}
