using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using C1.Win.C1Chart;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x02000516 RID: 1302
	[ComVisible(true)]
	public class ChartDataArray
	{
		// Token: 0x06005630 RID: 22064 RVA: 0x0025A897 File Offset: 0x00258A97
		public ChartDataArray(ChartDataArray A_0)
		{
			this.oO0Oo._o_O_. = A_0;
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06005631 RID: 22065 RVA: 0x0025A8A6 File Offset: 0x00258AA6
		// (set) Token: 0x06005632 RID: 22066 RVA: 0x0025A8B3 File Offset: 0x00258AB3
		public string DataField
		{
			get
			{
				return this.oO0Oo._o_O_..DataField;
			}
			set
			{
				this.oO0Oo._o_O_..DataField = value;
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06005633 RID: 22067 RVA: 0x0025A8C1 File Offset: 0x00258AC1
		// (set) Token: 0x06005634 RID: 22068 RVA: 0x0025A8CE File Offset: 0x00258ACE
		public Type DataType
		{
			get
			{
				return this.oO0Oo._o_O_..DataType;
			}
			set
			{
				this.oO0Oo._o_O_..DataType = value;
			}
		}

		// Token: 0x1700137A RID: 4986
		public object this[int Index]
		{
			get
			{
				return this.oO0Oo._o_O_.[Index];
			}
			set
			{
				if (value is byte)
				{
					value = Conversions.ToInteger(value);
				}
				this.oO0Oo._o_O_.[Index] = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06005637 RID: 22071 RVA: 0x0025A913 File Offset: 0x00258B13
		public double Mean
		{
			get
			{
				return this.oO0Oo._o_O_..Statistics.Mean;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06005638 RID: 22072 RVA: 0x0025A925 File Offset: 0x00258B25
		public double Median
		{
			get
			{
				return this.oO0Oo._o_O_..Statistics.Median;
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06005639 RID: 22073 RVA: 0x0025A937 File Offset: 0x00258B37
		public double StdDev
		{
			get
			{
				return this.oO0Oo._o_O_..Statistics.StdDev;
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x0600563A RID: 22074 RVA: 0x0025A949 File Offset: 0x00258B49
		public double Variance
		{
			get
			{
				return this.oO0Oo._o_O_..Statistics.Variance;
			}
		}

		// Token: 0x040022C0 RID: 8896
		private ChartDataArray <<EMPTY_NAME>>;
	}
}
