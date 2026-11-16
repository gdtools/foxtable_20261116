using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.Sparkline;
using Microsoft.VisualBasic;

namespace Foxtable
{
	// Token: 0x02000091 RID: 145
	[oO0oooo("3740")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CellChart : C1Sparkline
	{
		// Token: 0x06000580 RID: 1408 RVA: 0x0002E02F File Offset: 0x0002C22F
		public CellChart()
		{
			this.Values = new List<double>();
			this.MarkerLineColor = this.AxisColor;
			this.MarkerLineWeight = 1f;
			this.Oo_O._o__. = double.MinValue;
			this.Space = 1;
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0002E06F File Offset: 0x0002C26F
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x0002E077 File Offset: 0x0002C277
		public List<double> Values { get; set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0002E080 File Offset: 0x0002C280
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x0002E088 File Offset: 0x0002C288
		public double MarkerLineValue { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0002E091 File Offset: 0x0002C291
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x0002E099 File Offset: 0x0002C299
		public Color MarkerLineColor { get; set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x0002E0A2 File Offset: 0x0002C2A2
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x0002E0AA File Offset: 0x0002C2AA
		public float MarkerLineWeight { get; set; }

		/// <summary>
		/// 起始值
		/// </summary>
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0002E0B3 File Offset: 0x0002C2B3
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x0002E0BB File Offset: 0x0002C2BB
		[oO0oooo("3754")]
		public double StartingValue
		{
			get
			{
				return this.Oo_O._o__.;
			}
			set
			{
				this.Oo_O._o__. = value;
			}
		}

		/// <summary>
		/// 添加图表数据
		/// </summary>
		/// <param name="values">数据集合</param>
		// Token: 0x0600058B RID: 1419 RVA: 0x0002E0C4 File Offset: 0x0002C2C4
		[oO0oooo("3741")]
		public void AddValues(IEnumerable<object> values)
		{
			try
			{
				foreach (object obj in values)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					this.Values.Add(Conversion.Val(RuntimeHelpers.GetObjectValue(objectValue)));
				}
			}
			finally
			{
				IEnumerator<object> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		/// <summary>
		/// 添加图表数据
		/// </summary>
		/// <param name="values">数据</param>
		// Token: 0x0600058C RID: 1420 RVA: 0x0002E120 File Offset: 0x0002C320
		[oO0oooo("3741")]
		public void AddValues(params object[] values)
		{
			checked
			{
				for (int i = 0; i < values.Length; i++)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(values[i]);
					if (objectValue is IEnumerable<object>)
					{
						this.AddValues((IEnumerable<object>)objectValue);
					}
					else
					{
						this.Values.Add(Conversion.Val(RuntimeHelpers.GetObjectValue(objectValue)));
					}
				}
			}
		}

		/// <summary>
		/// 置X轴颜色
		/// </summary>
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0002E172 File Offset: 0x0002C372
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x0002E17F File Offset: 0x0002C37F
		public Color AxisColor
		{
			get
			{
				return base.Styles.AxisColor;
			}
			set
			{
				base.Styles.AxisColor = value;
			}
		}

		/// <summary>
		/// 柱状图间距
		/// </summary>
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0002E18D File Offset: 0x0002C38D
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0002E19A File Offset: 0x0002C39A
		public int BarDistance
		{
			get
			{
				return base.Styles.BarDistance;
			}
			set
			{
				base.Styles.BarDistance = value;
			}
		}

		/// <summary>
		/// 第一个数据点标记颜色
		/// </summary>
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0002E1A8 File Offset: 0x0002C3A8
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x0002E1B5 File Offset: 0x0002C3B5
		public Color FirstMarkerColor
		{
			get
			{
				return base.Styles.FirstMarkerColor;
			}
			set
			{
				base.Styles.FirstMarkerColor = value;
			}
		}

		/// <summary>
		/// 最大值标记颜色
		/// </summary>
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0002E1C3 File Offset: 0x0002C3C3
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
		public Color HighMarkerColor
		{
			get
			{
				return base.Styles.HighMarkerColor;
			}
			set
			{
				base.Styles.HighMarkerColor = value;
			}
		}

		/// <summary>
		/// 最后一个数据点标记颜色
		/// </summary>
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0002E1DE File Offset: 0x0002C3DE
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x0002E1EB File Offset: 0x0002C3EB
		public Color LastMarkerColor
		{
			get
			{
				return base.Styles.LastMarkerColor;
			}
			set
			{
				base.Styles.LastMarkerColor = value;
			}
		}

		/// <summary>
		/// 最小值标记颜色
		/// </summary>
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0002E1F9 File Offset: 0x0002C3F9
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x0002E206 File Offset: 0x0002C406
		public Color LowMarkerColor
		{
			get
			{
				return base.Styles.LowMarkerColor;
			}
			set
			{
				base.Styles.LowMarkerColor = value;
			}
		}

		/// <summary>
		/// 数据标记颜色
		/// </summary>
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0002E214 File Offset: 0x0002C414
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x0002E221 File Offset: 0x0002C421
		public Color MarkersColor
		{
			get
			{
				return base.Styles.MarkersColor;
			}
			set
			{
				base.Styles.MarkersColor = value;
			}
		}

		/// <summary>
		/// 负值标记颜色
		/// </summary>
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x0002E22F File Offset: 0x0002C42F
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x0002E23C File Offset: 0x0002C43C
		public Color NegativeColor
		{
			get
			{
				return base.Styles.NegativeColor;
			}
			set
			{
				base.Styles.NegativeColor = value;
			}
		}

		/// <summary>
		/// 图表颜色
		/// </summary>
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0002E24A File Offset: 0x0002C44A
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x0002E257 File Offset: 0x0002C457
		public Color SeriesColor
		{
			get
			{
				return base.Styles.SeriesColor;
			}
			set
			{
				base.Styles.SeriesColor = value;
			}
		}

		/// <summary>
		/// 图表线条粗细
		/// </summary>
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0002E265 File Offset: 0x0002C465
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x0002E272 File Offset: 0x0002C472
		public double LineWeight
		{
			get
			{
				return base.Styles.LineWeight;
			}
			set
			{
				base.Styles.LineWeight = value;
			}
		}

		/// <summary>
		/// 图表类型
		/// </summary>
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0002E280 File Offset: 0x0002C480
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x0002E288 File Offset: 0x0002C488
		public SparklineType ChartType
		{
			get
			{
				return base.SparklineType;
			}
			set
			{
				base.SparklineType = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0002E291 File Offset: 0x0002C491
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0002E299 File Offset: 0x0002C499
		public int Space { get; set; }

		// Token: 0x060005A5 RID: 1445 RVA: 0x0002E2A4 File Offset: 0x0002C4A4
		protected virtual void <<EMPTY_NAME>>(PaintEventArgs A_0)
		{
			base.OnPaint(A_0);
			if (this.MarkerLineValue != 0.0 && this.Values.Count > 1)
			{
				Pen pen;
				if (this.MarkerLineColor.A == 255)
				{
					pen = new Pen(Color.FromArgb(168, (int)this.MarkerLineColor.R, (int)this.MarkerLineColor.G, (int)this.MarkerLineColor.B));
				}
				else
				{
					pen = new Pen(this.MarkerLineColor);
				}
				pen.DashStyle = DashStyle.Dot;
				pen.Width = this.MarkerLineWeight;
				double num = double.MinValue;
				double num2 = double.MaxValue;
				try
				{
					foreach (double num3 in this.Values)
					{
						double num4 = num3;
						if (num4 > num)
						{
							num = num4;
						}
						if (num4 < num2)
						{
							num2 = num4;
						}
					}
				}
				finally
				{
					List<double>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (this.MarkerLineValue >= num2 && this.MarkerLineValue <= num && num > num2)
				{
					double num5 = (double)(A_0.ClipRectangle.Height - 6) / (num - num2) * (this.MarkerLineValue - num2) + 3.0;
					num5 = (double)A_0.ClipRectangle.Height - num5;
					if (this.ChartType == SparklineType.Column)
					{
						num5 = Math.Min(num5, (double)(A_0.ClipRectangle.Height - 4));
					}
					A_0.Graphics.DrawLine(pen, new PointF(1f, (float)num5), new PointF((float)A_0.ClipRectangle.Width, (float)num5));
				}
			}
		}

		// Token: 0x04000167 RID: 359
		[CompilerGenerated]
		private List<double> <<EMPTY_NAME>>;

		// Token: 0x04000168 RID: 360
		[CompilerGenerated]
		private double <<EMPTY_NAME>>;

		// Token: 0x04000169 RID: 361
		[CompilerGenerated]
		private Color <<EMPTY_NAME>>;

		// Token: 0x0400016A RID: 362
		[CompilerGenerated]
		private float <<EMPTY_NAME>>;

		// Token: 0x0400016B RID: 363
		private double <<EMPTY_NAME>>;

		// Token: 0x0400016C RID: 364
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;
	}
}
