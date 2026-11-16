using System;
using System.Runtime.CompilerServices;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200015E RID: 350
	public class GetMapTileEventArgs : ControlEventArgs
	{
		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0007E307 File Offset: 0x0007C507
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x0007E30F File Offset: 0x0007C50F
		public int Z { get; set; }

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0007E318 File Offset: 0x0007C518
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x0007E320 File Offset: 0x0007C520
		public int X { get; set; }

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x0007E329 File Offset: 0x0007C529
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x0007E331 File Offset: 0x0007C531
		public int Y { get; set; }

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x0007E33A File Offset: 0x0007C53A
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x0007E342 File Offset: 0x0007C542
		public string URI { get; set; }

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x0007E34B File Offset: 0x0007C54B
		// (set) Token: 0x060010AB RID: 4267 RVA: 0x0007E353 File Offset: 0x0007C553
		public object Image
		{
			[CompilerGenerated]
			get
			{
				return this.oO_Oo.___.;
			}
			[CompilerGenerated]
			set
			{
				this.oO_Oo.___. = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0007E364 File Offset: 0x0007C564
		public GetMapTileEventArgs(Map A_0, Form A_1, int A_2, int A_3, int A_4, ref string A_5, ref object A_6) : base(A_0.BaseControl, A_1)
		{
			this.oO_Oo.___. = (GeoMap)A_0.BaseControl;
			this.X = A_2;
			this.Y = A_3;
			this.Z = A_4;
			this.URI = A_5;
			this.Image = RuntimeHelpers.GetObjectValue(A_6);
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x0007E3BD File Offset: 0x0007C5BD
		public GeoMap GeoMap
		{
			get
			{
				return this.oO_Oo.___.;
			}
		}

		// Token: 0x0400066F RID: 1647
		private GeoMap <<EMPTY_NAME>>;

		// Token: 0x04000670 RID: 1648
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;

		// Token: 0x04000671 RID: 1649
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;

		// Token: 0x04000672 RID: 1650
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;

		// Token: 0x04000673 RID: 1651
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x04000674 RID: 1652
		[CompilerGenerated]
		private object <<EMPTY_NAME>>;
	}
}
