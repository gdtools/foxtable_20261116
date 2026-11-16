using System;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1Chart;

namespace Foxtable.WinForm
{
	// Token: 0x02000518 RID: 1304
	[ComVisible(true)]
	public class ChartSeries
	{
		// Token: 0x06005645 RID: 22085 RVA: 0x0025ABCC File Offset: 0x00258DCC
		public ChartSeries(ChartDataSeries A_0)
		{
			this.o0.00O. = A_0;
			this.oO0Oo._o_O_. = new ChartDataArray(this.o0.00O..X);
			this.oOoo__O.o0_o0. = new ChartDataArray(this.o0.00O..Y);
			this.O_.oO_0____. = new ChartDataArray(this.o0.00O..Y1);
			this.O0_o.OO0Oo0___. = new ChartDataArray(this.o0.00O..Y2);
			this.o_0oO00OOo.oo. = new ChartDataArray(this.o0.00O..Y3);
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06005646 RID: 22086 RVA: 0x0025AC54 File Offset: 0x00258E54
		internal ChartDataSeries BaseSeries
		{
			get
			{
				return this.o0.00O.;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06005647 RID: 22087 RVA: 0x0025AC5C File Offset: 0x00258E5C
		// (set) Token: 0x06005648 RID: 22088 RVA: 0x0025AC69 File Offset: 0x00258E69
		[oO0oooo("1035")]
		public string Text
		{
			get
			{
				return this.o0.00O..Label;
			}
			set
			{
				this.o0.00O..Label = value;
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06005649 RID: 22089 RVA: 0x0025AC77 File Offset: 0x00258E77
		// (set) Token: 0x0600564A RID: 22090 RVA: 0x0025AC84 File Offset: 0x00258E84
		[oO0oooo("1036")]
		public string TooltipText
		{
			get
			{
				return this.o0.00O..TooltipText;
			}
			set
			{
				this.o0.00O..TooltipText = value;
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x0600564B RID: 22091 RVA: 0x0025AC92 File Offset: 0x00258E92
		// (set) Token: 0x0600564C RID: 22092 RVA: 0x0025AC9F File Offset: 0x00258E9F
		public string TooltipTextLegend
		{
			get
			{
				return this.o0.00O..TooltipTextLegend;
			}
			set
			{
				this.o0.00O..TooltipTextLegend = value;
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x0600564D RID: 22093 RVA: 0x0025ACAD File Offset: 0x00258EAD
		// (set) Token: 0x0600564E RID: 22094 RVA: 0x0025ACBA File Offset: 0x00258EBA
		public bool LegendEntry
		{
			get
			{
				return this.o0.00O..LegendEntry;
			}
			set
			{
				this.o0.00O..LegendEntry = value;
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x0600564F RID: 22095 RVA: 0x0025ACC8 File Offset: 0x00258EC8
		// (set) Token: 0x06005650 RID: 22096 RVA: 0x0025ACD5 File Offset: 0x00258ED5
		public DisplayTypeEnum DisplayType
		{
			get
			{
				return (DisplayTypeEnum)this.o0.00O..Display;
			}
			set
			{
				this.o0.00O..Display = (SeriesDisplayEnum)value;
			}
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06005651 RID: 22097 RVA: 0x0025ACE3 File Offset: 0x00258EE3
		// (set) Token: 0x06005652 RID: 22098 RVA: 0x0025ACF0 File Offset: 0x00258EF0
		[oO0oooo("1038")]
		public FitTypeEnum FitType
		{
			get
			{
				return (FitTypeEnum)this.o0.00O..FitType;
			}
			set
			{
				this.o0.00O..FitType = (FitTypeEnum)value;
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06005653 RID: 22099 RVA: 0x0025ACFE File Offset: 0x00258EFE
		// (set) Token: 0x06005654 RID: 22100 RVA: 0x0025AD0C File Offset: 0x00258F0C
		[oO0oooo("")]
		public int Length
		{
			get
			{
				return this.o0.00O..Length;
			}
			set
			{
				this.o0.00O..PointData.Length = value;
				this.o0.00O..Y1.Length = value;
				this.o0.00O..Y2.Length = value;
				this.o0.00O..Y3.Length = value;
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06005655 RID: 22101 RVA: 0x0025AD5D File Offset: 0x00258F5D
		// (set) Token: 0x06005656 RID: 22102 RVA: 0x0025AD6F File Offset: 0x00258F6F
		public Color FillColor
		{
			get
			{
				return this.o0.00O..FillStyle.Color1;
			}
			set
			{
				this.o0.00O..FillStyle.Color1 = value;
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06005657 RID: 22103 RVA: 0x0025AD82 File Offset: 0x00258F82
		// (set) Token: 0x06005658 RID: 22104 RVA: 0x0025AD94 File Offset: 0x00258F94
		[oO0oooo("1039")]
		public Color LineColor
		{
			get
			{
				return this.o0.00O..LineStyle.Color;
			}
			set
			{
				this.o0.00O..LineStyle.Color = value;
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06005659 RID: 22105 RVA: 0x0025ADA7 File Offset: 0x00258FA7
		// (set) Token: 0x0600565A RID: 22106 RVA: 0x0025ADB9 File Offset: 0x00258FB9
		public int LineThickNess
		{
			get
			{
				return this.o0.00O..LineStyle.Thickness;
			}
			set
			{
				this.o0.00O..LineStyle.Thickness = value;
			}
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x0600565B RID: 22107 RVA: 0x0025ADCC File Offset: 0x00258FCC
		// (set) Token: 0x0600565C RID: 22108 RVA: 0x0025ADDE File Offset: 0x00258FDE
		[oO0oooo("1041")]
		public LinePatternEnum LinePattern
		{
			get
			{
				return (LinePatternEnum)this.o0.00O..LineStyle.Pattern;
			}
			set
			{
				this.o0.00O..LineStyle.Pattern = (LinePatternEnum)value;
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x0600565D RID: 22109 RVA: 0x0025ADF1 File Offset: 0x00258FF1
		// (set) Token: 0x0600565E RID: 22110 RVA: 0x0025AE03 File Offset: 0x00259003
		[oO0oooo("1043")]
		public Color MarkColor
		{
			get
			{
				return this.o0.00O..SymbolStyle.Color;
			}
			set
			{
				this.o0.00O..SymbolStyle.Color = value;
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x0600565F RID: 22111 RVA: 0x0025AE16 File Offset: 0x00259016
		// (set) Token: 0x06005660 RID: 22112 RVA: 0x0025AE28 File Offset: 0x00259028
		[oO0oooo("1043")]
		public int MarkSize
		{
			get
			{
				return this.o0.00O..SymbolStyle.Size;
			}
			set
			{
				this.o0.00O..SymbolStyle.Size = value;
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06005661 RID: 22113 RVA: 0x0025AE3B File Offset: 0x0025903B
		// (set) Token: 0x06005662 RID: 22114 RVA: 0x0025AE4D File Offset: 0x0025904D
		[oO0oooo("1043")]
		public MarkShapeEnum MarkShape
		{
			get
			{
				return (MarkShapeEnum)this.o0.00O..SymbolStyle.Shape;
			}
			set
			{
				this.o0.00O..SymbolStyle.Shape = (SymbolShapeEnum)value;
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06005663 RID: 22115 RVA: 0x0025AE60 File Offset: 0x00259060
		// (set) Token: 0x06005664 RID: 22116 RVA: 0x0025AE72 File Offset: 0x00259072
		public Color MarkBorderColor
		{
			get
			{
				return this.o0.00O..SymbolStyle.OutlineColor;
			}
			set
			{
				this.o0.00O..SymbolStyle.OutlineColor = value;
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06005665 RID: 22117 RVA: 0x0025AE85 File Offset: 0x00259085
		// (set) Token: 0x06005666 RID: 22118 RVA: 0x0025AE97 File Offset: 0x00259097
		public int MarkBorderWidth
		{
			get
			{
				return this.o0.00O..SymbolStyle.OutlineWidth;
			}
			set
			{
				this.o0.00O..SymbolStyle.OutlineWidth = value;
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06005667 RID: 22119 RVA: 0x0025AEAA File Offset: 0x002590AA
		public ChartDataArray X
		{
			get
			{
				return this.oO0Oo._o_O_.;
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06005668 RID: 22120 RVA: 0x0025AEB2 File Offset: 0x002590B2
		public ChartDataArray Y
		{
			get
			{
				return this.oOoo__O.o0_o0.;
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06005669 RID: 22121 RVA: 0x0025AEBA File Offset: 0x002590BA
		public ChartDataArray Y1
		{
			get
			{
				return this.O_.oO_0____.;
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x0600566A RID: 22122 RVA: 0x0025AEC2 File Offset: 0x002590C2
		public ChartDataArray Y2
		{
			get
			{
				return this.O0_o.OO0Oo0___.;
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x0600566B RID: 22123 RVA: 0x0025AECA File Offset: 0x002590CA
		public ChartDataArray Y3
		{
			get
			{
				return this.o_0oO00OOo.oo.;
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x0600566C RID: 22124 RVA: 0x0025AED2 File Offset: 0x002590D2
		// (set) Token: 0x0600566D RID: 22125 RVA: 0x0025AEDF File Offset: 0x002590DF
		public int Offset
		{
			get
			{
				return this.o0.00O..Offset;
			}
			set
			{
				this.o0.00O..Offset = value;
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x0600566E RID: 22126 RVA: 0x0025AEED File Offset: 0x002590ED
		[oO0oooo("0981")]
		public ChartHistogram Histogram
		{
			get
			{
				if (this.a == null)
				{
					this.a = new ChartHistogram(this.o0.00O.);
				}
				return this.a;
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x0600566F RID: 22127 RVA: 0x0025AF0E File Offset: 0x0025910E
		// (set) Token: 0x06005670 RID: 22128 RVA: 0x0025AF20 File Offset: 0x00259120
		[oO0oooo("0981")]
		public HistogramTypeEnum HistogramType
		{
			get
			{
				return (HistogramTypeEnum)this.o0.00O..Histogram.DisplayType;
			}
			set
			{
				this.o0.00O..Histogram.DisplayType = (DisplayTypeEnum)value;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06005671 RID: 22129 RVA: 0x0025AF33 File Offset: 0x00259133
		// (set) Token: 0x06005672 RID: 22130 RVA: 0x0025AF45 File Offset: 0x00259145
		[oO0oooo("1049")]
		public string DataLabelText
		{
			get
			{
				return this.o0.00O..DataLabel.Text;
			}
			set
			{
				this.o0.00O..DataLabel.Text = value;
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06005673 RID: 22131 RVA: 0x0025AF58 File Offset: 0x00259158
		// (set) Token: 0x06005674 RID: 22132 RVA: 0x0025AF6A File Offset: 0x0025916A
		public bool DataLabelVisible
		{
			get
			{
				return this.o0.00O..DataLabel.Visible;
			}
			set
			{
				this.o0.00O..DataLabel.Visible = value;
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06005675 RID: 22133 RVA: 0x0025AF7D File Offset: 0x0025917D
		// (set) Token: 0x06005676 RID: 22134 RVA: 0x0025AF94 File Offset: 0x00259194
		[oO0oooo("1051")]
		public Color DataLabelBackColor
		{
			get
			{
				return this.o0.00O..DataLabel.Style.BackColor;
			}
			set
			{
				this.o0.00O..DataLabel.Style.BackColor = value;
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06005677 RID: 22135 RVA: 0x0025AFAC File Offset: 0x002591AC
		// (set) Token: 0x06005678 RID: 22136 RVA: 0x0025AFC3 File Offset: 0x002591C3
		[oO0oooo("1051")]
		public Color DataLabelForeColor
		{
			get
			{
				return this.o0.00O..DataLabel.Style.ForeColor;
			}
			set
			{
				this.o0.00O..DataLabel.Style.ForeColor = value;
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06005679 RID: 22137 RVA: 0x0025AFDB File Offset: 0x002591DB
		// (set) Token: 0x0600567A RID: 22138 RVA: 0x0025AFFD File Offset: 0x002591FD
		public bool DataLabelBorder
		{
			get
			{
				return this.o0.00O..DataLabel.Style.Border.BorderStyle != BorderStyleEnum.None;
			}
			set
			{
				if (value)
				{
					this.o0.00O..DataLabel.Style.Border.BorderStyle = BorderStyleEnum.Solid;
					return;
				}
				this.o0.00O..DataLabel.Style.Border.BorderStyle = BorderStyleEnum.None;
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x0600567B RID: 22139 RVA: 0x0025B039 File Offset: 0x00259239
		// (set) Token: 0x0600567C RID: 22140 RVA: 0x0025B055 File Offset: 0x00259255
		public Color DataLabelBorderColor
		{
			get
			{
				return this.o0.00O..DataLabel.Style.Border.Color;
			}
			set
			{
				this.o0.00O..DataLabel.Style.Border.Color = value;
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x0600567D RID: 22141 RVA: 0x0025B072 File Offset: 0x00259272
		// (set) Token: 0x0600567E RID: 22142 RVA: 0x0025B084 File Offset: 0x00259284
		public bool DataLabelConnected
		{
			get
			{
				return this.o0.00O..DataLabel.Connected;
			}
			set
			{
				this.o0.00O..DataLabel.Connected = value;
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x0600567F RID: 22143 RVA: 0x0025B097 File Offset: 0x00259297
		// (set) Token: 0x06005680 RID: 22144 RVA: 0x0025B0A9 File Offset: 0x002592A9
		[oO0oooo("1056")]
		public LabelCompassEnum DataLabelCompass
		{
			get
			{
				return (LabelCompassEnum)this.o0.00O..DataLabel.Compass;
			}
			set
			{
				this.o0.00O..DataLabel.Compass = (LabelCompassEnum)value;
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06005681 RID: 22145 RVA: 0x0025B0C1 File Offset: 0x002592C1
		// (set) Token: 0x06005682 RID: 22146 RVA: 0x0025B0D3 File Offset: 0x002592D3
		[oO0oooo("6010")]
		public int DataLabelOffset
		{
			get
			{
				return this.o0.00O..DataLabel.Offset;
			}
			set
			{
				this.o0.00O..DataLabel.Offset = value;
			}
		}

		// Token: 0x040022C3 RID: 8899
		private ChartDataSeries <<EMPTY_NAME>>;

		// Token: 0x040022C4 RID: 8900
		private ChartDataArray <<EMPTY_NAME>>;

		// Token: 0x040022C5 RID: 8901
		private ChartDataArray <<EMPTY_NAME>>;

		// Token: 0x040022C6 RID: 8902
		private ChartDataArray <<EMPTY_NAME>>;

		// Token: 0x040022C7 RID: 8903
		private ChartDataArray <<EMPTY_NAME>>;

		// Token: 0x040022C8 RID: 8904
		private ChartDataArray <<EMPTY_NAME>>;

		// Token: 0x040022C9 RID: 8905
		private ChartHistogram a;
	}
}
