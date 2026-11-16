using System;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1Chart;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x02000517 RID: 1303
	[ComVisible(true)]
	public class ChartSerialCollection
	{
		// Token: 0x0600563B RID: 22075 RVA: 0x0025A95B File Offset: 0x00258B5B
		public ChartSerialCollection(ChartDataSeriesCollection A_0, C1Chart A_1)
		{
			this.oO0Oo._o_O_. = A_0;
			this.oO0Oo._o_O_. = A_1;
		}

		// Token: 0x1700137F RID: 4991
		public ChartSeries this[int Index]
		{
			get
			{
				return new ChartSeries(this.oO0Oo._o_O_.[Index]);
			}
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x0025A984 File Offset: 0x00258B84
		public ChartSeries Add()
		{
			ChartDataSeries chartDataSeries = this.oO0Oo._o_O_..AddNewSeries();
			chartDataSeries.Histogram.IntervalCreationMethod = IntervalMethodEnum.SemiAutomatic;
			chartDataSeries.DataLabel.Compass = LabelCompassEnum.Auto;
			chartDataSeries.DataLabel.Visible = true;
			return new ChartSeries(chartDataSeries);
		}

		// Token: 0x0600563E RID: 22078 RVA: 0x0025A9C8 File Offset: 0x00258BC8
		public void Clear()
		{
			this.oO0Oo._o_O_..RemoveAll();
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x0025A9D5 File Offset: 0x00258BD5
		public void Remove(ChartSeries Series)
		{
			this.oO0Oo._o_O_..Remove(Series.BaseSeries);
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x0025A9E8 File Offset: 0x00258BE8
		public void RemoveAt(int Index)
		{
			this.oO0Oo._o_O_..RemoveAt(Index);
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06005641 RID: 22081 RVA: 0x0025A9F6 File Offset: 0x00258BF6
		public int Count
		{
			get
			{
				return this.oO0Oo._o_O_..Count;
			}
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x0025AA04 File Offset: 0x00258C04
		public void AddGanttSeries(string taskName, DateTime startTime, DateTime endTime)
		{
			ChartDataSeries chartDataSeries = this.oO0Oo._o_O_..AddNewSeries();
			chartDataSeries.Label = taskName;
			chartDataSeries.Y.CopyDataIn(new DateTime[]
			{
				startTime
			});
			chartDataSeries.Y1.CopyDataIn(new DateTime[]
			{
				endTime
			});
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x0025AA58 File Offset: 0x00258C58
		public void AddGanttSeries(string taskName, DateTime[] startTimes, DateTime[] endTimes)
		{
			ChartDataSeries chartDataSeries = this.oO0Oo._o_O_..AddNewSeries();
			chartDataSeries.Label = taskName;
			chartDataSeries.Y.CopyDataIn(startTimes);
			chartDataSeries.Y1.CopyDataIn(endTimes);
		}

		// Token: 0x06005644 RID: 22084 RVA: 0x0025AA88 File Offset: 0x00258C88
		public void AddGanttLabels(string FormatString)
		{
			ChartLabels chartLabels = this.oO0Oo._o_O_..ChartLabels;
			chartLabels.DefaultLabelStyle.BackColor = Color.Transparent;
			chartLabels.DefaultLabelStyle.GradientStyle = GradientStyleEnum.None;
			chartLabels.DefaultLabelStyle.ForeColor = Color.Azure;
			chartLabels.DefaultLabelStyle.HorizontalAlignment = AlignHorzEnum.Far;
			LabelsCollection labelsCollection = chartLabels.LabelsCollection;
			labelsCollection.Clear();
			int count = this.oO0Oo._o_O_..Count;
			int num = this.oO0Oo._o_O_..Count - 1;
			for (int i = 0; i <= num; i++)
			{
				ChartDataSeries chartDataSeries = this.oO0Oo._o_O_.[i];
				int num2 = chartDataSeries.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					Label label = labelsCollection.AddNewLabel();
					DateTime dateTime = Conversions.ToDate(chartDataSeries.Y[j]);
					DateTime dateTime2 = Conversions.ToDate(chartDataSeries.Y1[j]);
					label.Text = dateTime.ToString(FormatString) + "-" + dateTime2.ToString(FormatString);
					label.AttachMethod = AttachMethodEnum.DataIndex;
					label.AttachMethodData.GroupIndex = 0;
					label.AttachMethodData.SeriesIndex = i;
					label.AttachMethodData.PointIndex = j;
					label.Compass = LabelCompassEnum.West;
					label.Offset = 0;
					label.Visible = true;
				}
			}
		}

		// Token: 0x040022C1 RID: 8897
		private ChartDataSeriesCollection <<EMPTY_NAME>>;

		// Token: 0x040022C2 RID: 8898
		private C1Chart <<EMPTY_NAME>>;
	}
}
