using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using C1.Win.Map;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200016B RID: 363
	public class OwerDrawMarkEventArgs : ControlEventArgs
	{
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x0007EBF0 File Offset: 0x0007CDF0
		public GeoMap GeoMap { get; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x0007EBF8 File Offset: 0x0007CDF8
		public Graphics Graphics { get; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0007EC00 File Offset: 0x0007CE00
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x0007EC08 File Offset: 0x0007CE08
		public RectangleF Bounds { get; set; }

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x0007EC11 File Offset: 0x0007CE11
		public Style Style { get; }

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x0007EC19 File Offset: 0x0007CE19
		public object ShapeTag { get; }

		// Token: 0x060010E5 RID: 4325 RVA: 0x0007EC21 File Offset: 0x0007CE21
		public OwerDrawMarkEventArgs(Map A_0, Form A_1, Graphics A_2, RectangleF A_3, Style A_4, object A_5) : base(A_0.BaseControl, A_1)
		{
			this.GeoMap = (GeoMap)A_0.BaseControl;
			this.Graphics = A_2;
			this.Bounds = A_3;
			this.Style = A_4;
			this.ShapeTag = A_5;
		}

		// Token: 0x04000687 RID: 1671
		[CompilerGenerated]
		private GeoMap <<EMPTY_NAME>>;

		// Token: 0x04000688 RID: 1672
		[CompilerGenerated]
		private Graphics <<EMPTY_NAME>>;

		// Token: 0x04000689 RID: 1673
		[CompilerGenerated]
		private RectangleF <<EMPTY_NAME>>;

		// Token: 0x0400068A RID: 1674
		[CompilerGenerated]
		private Style <<EMPTY_NAME>>;

		// Token: 0x0400068B RID: 1675
		[CompilerGenerated]
		private object <<EMPTY_NAME>>;
	}
}
