using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Chart;

namespace Foxtable
{
	// Token: 0x020003BB RID: 955
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ChartHistogram
	{
		// Token: 0x06003E1A RID: 15898 RVA: 0x001C01B2 File Offset: 0x001BE3B2
		public ChartHistogram(ChartDataSeries A_0)
		{
			this.OOO.o_oo0o0ooO. = A_0;
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06003E1B RID: 15899 RVA: 0x001C01C1 File Offset: 0x001BE3C1
		// (set) Token: 0x06003E1C RID: 15900 RVA: 0x001C01D3 File Offset: 0x001BE3D3
		[oO0oooo("0981")]
		public double IntervalStart
		{
			get
			{
				return this.OOO.o_oo0o0ooO..Histogram.IntervalStart;
			}
			set
			{
				this.OOO.o_oo0o0ooO..Histogram.IntervalStart = value;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06003E1D RID: 15901 RVA: 0x001C01E6 File Offset: 0x001BE3E6
		// (set) Token: 0x06003E1E RID: 15902 RVA: 0x001C01F8 File Offset: 0x001BE3F8
		[oO0oooo("0981")]
		public double IntervalWidth
		{
			get
			{
				return this.OOO.o_oo0o0ooO..Histogram.IntervalWidth;
			}
			set
			{
				this.OOO.o_oo0o0ooO..Histogram.IntervalWidth = value;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06003E1F RID: 15903 RVA: 0x001C020B File Offset: 0x001BE40B
		// (set) Token: 0x06003E20 RID: 15904 RVA: 0x001C021D File Offset: 0x001BE41D
		[oO0oooo("0981")]
		public int IntervalNumber
		{
			get
			{
				return this.OOO.o_oo0o0ooO..Histogram.IntervalNumber;
			}
			set
			{
				this.OOO.o_oo0o0ooO..Histogram.IntervalNumber = value;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06003E21 RID: 15905 RVA: 0x001C0230 File Offset: 0x001BE430
		[oO0oooo("0981")]
		public double AboveIntervalCount
		{
			get
			{
				return this.OOO.o_oo0o0ooO..Histogram.AboveIntervalCount;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x001C0242 File Offset: 0x001BE442
		[oO0oooo("0981")]
		public double BelowIntervalCount
		{
			get
			{
				return this.OOO.o_oo0o0ooO..Histogram.BelowIntervalCount;
			}
		}

		// Token: 0x04001955 RID: 6485
		private ChartDataSeries <<EMPTY_NAME>>;
	}
}
