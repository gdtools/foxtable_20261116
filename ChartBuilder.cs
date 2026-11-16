using System;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1Chart;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003B9 RID: 953
	[ComVisible(true)]
	public class ChartBuilder : Chart
	{
		// Token: 0x06003DB9 RID: 15801 RVA: 0x001BF3BC File Offset: 0x001BD5BC
		public ChartBuilder() : base(new C1Chart())
		{
			this.C1Chart.BackColor = Color.White;
		}
	}
}
