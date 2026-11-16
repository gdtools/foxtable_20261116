using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using C1.Win.Interop;
using C1.Win.Map;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000146 RID: 326
	public class GetVirtualItemsEventArgs : ControlEventArgs
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x0007D441 File Offset: 0x0007B641
		// (set) Token: 0x06001031 RID: 4145 RVA: 0x0007D449 File Offset: 0x0007B649
		private Point lowerLeft { get; set; }

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x0007D452 File Offset: 0x0007B652
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x0007D45A File Offset: 0x0007B65A
		private Point upperRight { get; set; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0007D463 File Offset: 0x0007B663
		public List<VectorItem> Items { get; }

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x0007D46B File Offset: 0x0007B66B
		public VirtualLayer Layer { get; }

		// Token: 0x06001036 RID: 4150 RVA: 0x0007D474 File Offset: 0x0007B674
		internal GetVirtualItemsEventArgs(Map A_0, VirtualLayer A_1, Form A_2, Point A_3, Point A_4) : base(A_0.BaseControl, A_2)
		{
			this.Items = new List<VectorItem>();
			this.Layer = A_1;
			this.o0o0_O.0O__O_. = (GeoMap)A_0.BaseControl;
			this.lowerLeft = A_3;
			this.upperRight = A_4;
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x0007D4C1 File Offset: 0x0007B6C1
		public GeoMap GeoMap
		{
			get
			{
				return this.o0o0_O.0O__O_.;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x0007D4CC File Offset: 0x0007B6CC
		public double X1
		{
			get
			{
				return this.lowerLeft.X;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x0007D4E8 File Offset: 0x0007B6E8
		public double X2
		{
			get
			{
				return this.upperRight.X;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x0007D504 File Offset: 0x0007B704
		public double Y1
		{
			get
			{
				return this.lowerLeft.Y;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x0007D520 File Offset: 0x0007B720
		public double Y2
		{
			get
			{
				return this.upperRight.Y;
			}
		}

		// Token: 0x0400064A RID: 1610
		private GeoMap <<EMPTY_NAME>>;

		// Token: 0x0400064B RID: 1611
		[CompilerGenerated]
		private Point <<EMPTY_NAME>>;

		// Token: 0x0400064C RID: 1612
		[CompilerGenerated]
		private Point <<EMPTY_NAME>>;

		// Token: 0x0400064D RID: 1613
		[CompilerGenerated]
		private List<VectorItem> <<EMPTY_NAME>>;

		// Token: 0x0400064E RID: 1614
		[CompilerGenerated]
		private VirtualLayer <<EMPTY_NAME>>;
	}
}
