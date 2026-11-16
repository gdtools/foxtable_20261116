using System;
using System.Runtime.InteropServices;
using C1.Win.Map;

namespace Foxtable
{
	// Token: 0x0200016C RID: 364
	[ComVisible(true)]
	public class VirtualLayer : VirtualLayer
	{
		// Token: 0x060010E6 RID: 4326 RVA: 0x0007EC60 File Offset: 0x0007CE60
		internal VirtualLayer(GeoMap A_0, double A_1)
		{
			base.MinZoom = A_1;
			base.Slices.Add(new MapSlice(0.0, 1, 1));
			base.Slices.Add(new MapSlice(base.MinZoom, 720, 720));
			base.ItemsSource = new VirtualTileSource(A_0, this);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0007ECC2 File Offset: 0x0007CEC2
		internal VirtualLayer(GeoMap A_0, double A_1, double A_2) : this(A_0, A_1)
		{
			base.MaxZoom = A_2;
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0007ECD3 File Offset: 0x0007CED3
		public void SetSlices(int longSlices, int latSlices)
		{
			base.Slices.Clear();
			base.Slices.Add(new MapSlice(0.0, 1, 1));
			base.Slices.Add(new MapSlice(base.MinZoom, latSlices, longSlices));
		}
	}
}
