using System;
using System.Runtime.InteropServices;
using C1.Win.Interop;
using C1.Win.Map;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x0200050B RID: 1291
	[ComVisible(true)]
	public class Map : Control
	{
		// Token: 0x06005437 RID: 21559 RVA: 0x00257589 File Offset: 0x00255789
		public Map(GeoMap A_0) : base(A_0, ControlTypeEnum.Map)
		{
			this.o.oO_oo_O. = A_0;
		}

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x06005438 RID: 21560 RVA: 0x0025759B File Offset: 0x0025579B
		public GeoMap GeoMap
		{
			get
			{
				return this.o.oO_oo_O.;
			}
		}

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x06005439 RID: 21561 RVA: 0x002575A4 File Offset: 0x002557A4
		// (set) Token: 0x0600543A RID: 21562 RVA: 0x00257638 File Offset: 0x00255838
		public TileSoureEnum TileSource
		{
			get
			{
				TileSoureEnum result;
				if (this.o.oO_oo_O..TileLayer.TileSource == null)
				{
					result = TileSoureEnum.None;
				}
				else if (this.o.oO_oo_O..TileLayer.TileSource is VirtualEarthRoadSource)
				{
					result = TileSoureEnum.Road;
				}
				else if (this.o.oO_oo_O..TileLayer.TileSource is VirtualEarthAerialSource)
				{
					result = TileSoureEnum.Aerial;
				}
				else if (this.o.oO_oo_O..TileLayer.TileSource is VirtualEarthHybridSource)
				{
					result = TileSoureEnum.Hybrid;
				}
				else if (this.o.oO_oo_O..TileLayer.TileSource is CustomTileSource)
				{
					result = TileSoureEnum.Custom;
				}
				else
				{
					result = TileSoureEnum.None;
				}
				return result;
			}
			set
			{
				switch (value)
				{
				case TileSoureEnum.None:
					this.o.oO_oo_O..TileLayer.TileSource = null;
					return;
				case TileSoureEnum.Road:
					this.o.oO_oo_O..TileLayer.TileSource = new VirtualEarthRoadSource();
					return;
				case TileSoureEnum.Aerial:
					this.o.oO_oo_O..TileLayer.TileSource = new VirtualEarthAerialSource();
					return;
				case TileSoureEnum.Hybrid:
					this.o.oO_oo_O..TileLayer.TileSource = new VirtualEarthHybridSource();
					return;
				case TileSoureEnum.Custom:
					this.o.oO_oo_O..TileLayer.TileSource = new CustomTileSource(this.o.oO_oo_O.);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x0600543B RID: 21563 RVA: 0x002576D1 File Offset: 0x002558D1
		// (set) Token: 0x0600543C RID: 21564 RVA: 0x002576E9 File Offset: 0x002558E9
		public double Zoom
		{
			get
			{
				return Math.Round(this.o.oO_oo_O..Viewport.Zoom, 6);
			}
			set
			{
				this.o.oO_oo_O..Viewport.Zoom = value;
			}
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x0600543D RID: 21565 RVA: 0x002576FC File Offset: 0x002558FC
		// (set) Token: 0x0600543E RID: 21566 RVA: 0x0025770E File Offset: 0x0025590E
		public double MaxZoom
		{
			get
			{
				return this.o.oO_oo_O..Viewport.MaxZoom;
			}
			set
			{
				this.o.oO_oo_O..Viewport.MaxZoom = value;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x0600543F RID: 21567 RVA: 0x00257721 File Offset: 0x00255921
		// (set) Token: 0x06005440 RID: 21568 RVA: 0x00257733 File Offset: 0x00255933
		public double MinZoom
		{
			get
			{
				return this.o.oO_oo_O..Viewport.MinZoom;
			}
			set
			{
				this.o.oO_oo_O..Viewport.MinZoom = value;
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06005441 RID: 21569 RVA: 0x00257748 File Offset: 0x00255948
		// (set) Token: 0x06005442 RID: 21570 RVA: 0x00257774 File Offset: 0x00255974
		public double CenterX
		{
			get
			{
				return Math.Round(this.o.oO_oo_O..Viewport.Center.X, 6);
			}
			set
			{
				this.o.oO_oo_O..Viewport.Center = new Point(value, this.o.oO_oo_O..Viewport.Center.Y);
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x06005443 RID: 21571 RVA: 0x002577B0 File Offset: 0x002559B0
		// (set) Token: 0x06005444 RID: 21572 RVA: 0x002577DC File Offset: 0x002559DC
		public double CenterY
		{
			get
			{
				return Math.Round(this.o.oO_oo_O..Viewport.Center.Y, 6);
			}
			set
			{
				this.o.oO_oo_O..Viewport.Center = new Point(this.o.oO_oo_O..Viewport.Center.X, value);
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06005445 RID: 21573 RVA: 0x00257818 File Offset: 0x00255A18
		// (set) Token: 0x06005446 RID: 21574 RVA: 0x00257868 File Offset: 0x00255A68
		public string MinX
		{
			get
			{
				string result;
				if (double.IsNaN(this.o.oO_oo_O..Viewport.Limits.MinLong))
				{
					result = "";
				}
				else
				{
					result = this.o.oO_oo_O..Viewport.Limits.MinLong.ToString();
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0 || Operators.CompareString(value, "NaN", true) == 0)
				{
					this.o.oO_oo_O..Viewport.Limits.MinLong = double.NaN;
					return;
				}
				this.o.oO_oo_O..Viewport.Limits.MinLong = Conversion.Val(value);
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06005447 RID: 21575 RVA: 0x002578CC File Offset: 0x00255ACC
		// (set) Token: 0x06005448 RID: 21576 RVA: 0x0025791C File Offset: 0x00255B1C
		public string MaxX
		{
			get
			{
				string result;
				if (double.IsNaN(this.o.oO_oo_O..Viewport.Limits.MaxLong))
				{
					result = "";
				}
				else
				{
					result = this.o.oO_oo_O..Viewport.Limits.MaxLong.ToString();
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0 || Operators.CompareString(value, "NaN", true) == 0)
				{
					this.o.oO_oo_O..Viewport.Limits.MaxLong = double.NaN;
					return;
				}
				this.o.oO_oo_O..Viewport.Limits.MaxLong = Conversion.Val(value);
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06005449 RID: 21577 RVA: 0x00257980 File Offset: 0x00255B80
		// (set) Token: 0x0600544A RID: 21578 RVA: 0x002579D0 File Offset: 0x00255BD0
		public string MinY
		{
			get
			{
				string result;
				if (double.IsNaN(this.o.oO_oo_O..Viewport.Limits.MinLat))
				{
					result = "";
				}
				else
				{
					result = this.o.oO_oo_O..Viewport.Limits.MinLat.ToString();
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0 || Operators.CompareString(value, "NaN", true) == 0)
				{
					this.o.oO_oo_O..Viewport.Limits.MinLat = double.NaN;
					return;
				}
				this.o.oO_oo_O..Viewport.Limits.MinLat = Conversion.Val(value);
			}
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x0600544B RID: 21579 RVA: 0x00257A34 File Offset: 0x00255C34
		// (set) Token: 0x0600544C RID: 21580 RVA: 0x00257A84 File Offset: 0x00255C84
		public string MaxY
		{
			get
			{
				string result;
				if (double.IsNaN(this.o.oO_oo_O..Viewport.Limits.MaxLat))
				{
					result = "";
				}
				else
				{
					result = this.o.oO_oo_O..Viewport.Limits.MaxLat.ToString();
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0 || Operators.CompareString(value, "NaN", true) == 0)
				{
					this.o.oO_oo_O..Viewport.Limits.MaxLat = double.NaN;
					return;
				}
				this.o.oO_oo_O..Viewport.Limits.MaxLat = Conversion.Val(value);
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x0600544D RID: 21581 RVA: 0x00257AE7 File Offset: 0x00255CE7
		// (set) Token: 0x0600544E RID: 21582 RVA: 0x00257AF4 File Offset: 0x00255CF4
		public bool AllowTranslating
		{
			get
			{
				return this.o.oO_oo_O..AllowTranslating;
			}
			set
			{
				this.o.oO_oo_O..AllowTranslating = value;
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x0600544F RID: 21583 RVA: 0x00257B02 File Offset: 0x00255D02
		// (set) Token: 0x06005450 RID: 21584 RVA: 0x00257B0F File Offset: 0x00255D0F
		public bool AllowZooming
		{
			get
			{
				return this.o.oO_oo_O..AllowZooming;
			}
			set
			{
				this.o.oO_oo_O..AllowZooming = value;
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06005451 RID: 21585 RVA: 0x00257B1D File Offset: 0x00255D1D
		// (set) Token: 0x06005452 RID: 21586 RVA: 0x00257B2F File Offset: 0x00255D2F
		public bool ZoomToolVisible
		{
			get
			{
				return this.o.oO_oo_O..ZoomTool.Visible;
			}
			set
			{
				this.o.oO_oo_O..ZoomTool.Visible = value;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06005453 RID: 21587 RVA: 0x00257B42 File Offset: 0x00255D42
		// (set) Token: 0x06005454 RID: 21588 RVA: 0x00257B54 File Offset: 0x00255D54
		public bool PanToolVisible
		{
			get
			{
				return this.o.oO_oo_O..PanTool.Visible;
			}
			set
			{
				this.o.oO_oo_O..PanTool.Visible = value;
			}
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06005455 RID: 21589 RVA: 0x00257B67 File Offset: 0x00255D67
		// (set) Token: 0x06005456 RID: 21590 RVA: 0x00257B79 File Offset: 0x00255D79
		public bool DistanceScaleVisible
		{
			get
			{
				return this.o.oO_oo_O..DistanceScale.Visible;
			}
			set
			{
				this.o.oO_oo_O..DistanceScale.Visible = value;
			}
		}

		// Token: 0x040022B2 RID: 8882
		private GeoMap <<EMPTY_NAME>>;
	}
}
