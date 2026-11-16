using System;
using System.ComponentModel;
using System.Windows.Forms;
using C1.Win.C1Gauge;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200015D RID: 349
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class GaugeFormatLabelEventArgs : ControlEventArgs
	{
		// Token: 0x0600109C RID: 4252 RVA: 0x0007E2B4 File Offset: 0x0007C4B4
		public GaugeFormatLabelEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, FormatLabelEventArgs A_2) : base(A_0, A_1)
		{
			this.O0_oO0.o_o. = A_2;
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0007E2C5 File Offset: 0x0007C4C5
		public C1GaugeDecorator Decorator
		{
			get
			{
				return this.O0_oO0.o_o..Decorator;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x0007E2D2 File Offset: 0x0007C4D2
		public double Value
		{
			get
			{
				return this.O0_oO0.o_o..Value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x0007E2DF File Offset: 0x0007C4DF
		public double ScaledValue
		{
			get
			{
				return this.O0_oO0.o_o..ScaledValue;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x0007E2EC File Offset: 0x0007C4EC
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x0007E2F9 File Offset: 0x0007C4F9
		public string Text
		{
			get
			{
				return this.O0_oO0.o_o..Text;
			}
			set
			{
				this.O0_oO0.o_o..Text = value;
			}
		}

		// Token: 0x0400066E RID: 1646
		private FormatLabelEventArgs <<EMPTY_NAME>>;
	}
}
