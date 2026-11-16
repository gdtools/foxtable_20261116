using System;
using System.ComponentModel;
using System.Drawing.Design;
using C1.Win.Interop;
using C1.Win.Map;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000176 RID: 374
	internal class MapProperty : ControlPropertyBase
	{
		// Token: 0x060011B3 RID: 4531 RVA: 0x0007F926 File Offset: 0x0007DB26
		internal MapProperty(ControlHolder A_0) : base(A_0)
		{
			this.O_.OOO_O_. = TileSoureEnum.None;
			this.O_.OOO_O_. = (GeoMap)A_0.ChildControl;
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x0007F947 File Offset: 0x0007DB47
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x0007F950 File Offset: 0x0007DB50
		[DisplayName("地图来源")]
		[Category("地图")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(1.0)]
		public TileSoureEnum TileSource
		{
			get
			{
				return this.O_.OOO_O_.;
			}
			set
			{
				this.O_.OOO_O_. = value;
				switch (value)
				{
				case TileSoureEnum.None:
				case TileSoureEnum.Custom:
					this.O_.OOO_O_..TileLayer.TileSource = null;
					return;
				case TileSoureEnum.Road:
					this.O_.OOO_O_..TileLayer.TileSource = new VirtualEarthRoadSource();
					return;
				case TileSoureEnum.Aerial:
					this.O_.OOO_O_..TileLayer.TileSource = new VirtualEarthAerialSource();
					return;
				case TileSoureEnum.Hybrid:
					this.O_.OOO_O_..TileLayer.TileSource = new VirtualEarthHybridSource();
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x0007F9D4 File Offset: 0x0007DBD4
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x0007F9DC File Offset: 0x0007DBDC
		[Description("获取地图瓦片的时候执行")]
		[O_Oo00Oo000O0(1.0)]
		[oO0oooo("")]
		[O0O0oOO00_0OO(true)]
		[Category("地图")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString GetMapTile
		{
			get
			{
				return this.Oo._oooO.;
			}
			set
			{
				this.Oo._oooO. = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x0007F9E5 File Offset: 0x0007DBE5
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x0007F9ED File Offset: 0x0007DBED
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("绘制自定义标记的时候执行")]
		[oO0oooo("")]
		[Category("地图")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(2.0)]
		public EventString OwerDrawMark
		{
			get
			{
				return this.OO__Oo_oo_._.;
			}
			set
			{
				this.OO__Oo_oo_._. = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x0007F9F6 File Offset: 0x0007DBF6
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x0007F9FE File Offset: 0x0007DBFE
		[oO0oooo("")]
		[O_Oo00Oo000O0(4.0)]
		[Description("获取自定义形状的绘制区域时执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Category("地图")]
		public EventString GetDrawingBounds
		{
			get
			{
				return this.oooOOo._oOo__0.;
			}
			set
			{
				this.oooOOo._oOo__0. = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x0007FA07 File Offset: 0x0007DC07
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x0007FA0F File Offset: 0x0007DC0F
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("")]
		[Description("绘制虚拟矢量层的时候执行")]
		[O_Oo00Oo000O0(3.0)]
		[Category("地图")]
		[O0O0oOO00_0OO(true)]
		public EventString GetVirtualItems
		{
			get
			{
				return this.Oo_o._O00O.;
			}
			set
			{
				this.Oo_o._O00O. = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x0007FA18 File Offset: 0x0007DC18
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x0007FA20 File Offset: 0x0007DC20
		[oO0oooo("")]
		[O_Oo00Oo000O0(5.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("地图中心位置发生改变的时候执行")]
		[Category("地图")]
		[O0O0oOO00_0OO(true)]
		public EventString CenterChanged
		{
			get
			{
				return this.O_oOooooo.00O.;
			}
			set
			{
				this.O_oOooooo.00O. = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0007FA29 File Offset: 0x0007DC29
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x0007FA31 File Offset: 0x0007DC31
		[Category("地图")]
		[oO0oooo("")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(5.0)]
		[Description("地图中心位置发生改变的时候执行")]
		public EventString ZoomChanged
		{
			get
			{
				return this.ooOo__0o0._oO.;
			}
			set
			{
				this.ooOo__0o0._oO. = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x0007FA3A File Offset: 0x0007DC3A
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x0007FA52 File Offset: 0x0007DC52
		[O_Oo00Oo000O0(2.0)]
		[Category("地图")]
		[DisplayName("缩放级别")]
		public double Zoom
		{
			get
			{
				return Math.Round(this.O_.OOO_O_..Viewport.Zoom, 6);
			}
			set
			{
				this.O_.OOO_O_..Viewport.Zoom = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x0007FA65 File Offset: 0x0007DC65
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x0007FA77 File Offset: 0x0007DC77
		[Category("地图")]
		[DisplayName("最大缩放")]
		[O_Oo00Oo000O0(3.0)]
		public double MaxZoom
		{
			get
			{
				return this.O_.OOO_O_..Viewport.MaxZoom;
			}
			set
			{
				this.O_.OOO_O_..Viewport.MaxZoom = Math.Min(value, 20.0);
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x0007FA98 File Offset: 0x0007DC98
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x0007FAAA File Offset: 0x0007DCAA
		[DefaultValue(0)]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("最小缩放")]
		[Category("地图")]
		public double MinZoom
		{
			get
			{
				return this.O_.OOO_O_..Viewport.MinZoom;
			}
			set
			{
				this.O_.OOO_O_..Viewport.MinZoom = Math.Max(0.0, value);
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x0007FACC File Offset: 0x0007DCCC
		// (set) Token: 0x060011C9 RID: 4553 RVA: 0x0007FAF8 File Offset: 0x0007DCF8
		[DefaultValue(103.72)]
		[Category("地图")]
		[DisplayName("中心经度")]
		[O_Oo00Oo000O0(5.0)]
		public double CenterX
		{
			get
			{
				return Math.Round(this.O_.OOO_O_..Viewport.Center.X, 6);
			}
			set
			{
				this.O_.OOO_O_..Viewport.Center = new Point(value, this.O_.OOO_O_..Viewport.Center.Y);
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x0007FB34 File Offset: 0x0007DD34
		// (set) Token: 0x060011CB RID: 4555 RVA: 0x0007FB60 File Offset: 0x0007DD60
		[DefaultValue(34.5)]
		[O_Oo00Oo000O0(6.0)]
		[Category("地图")]
		[DisplayName("中心维度")]
		public double CenterY
		{
			get
			{
				return Math.Round(this.O_.OOO_O_..Viewport.Center.Y, 6);
			}
			set
			{
				this.O_.OOO_O_..Viewport.Center = new Point(this.O_.OOO_O_..Viewport.Center.X, value);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x0007FB9C File Offset: 0x0007DD9C
		// (set) Token: 0x060011CD RID: 4557 RVA: 0x0007FBEC File Offset: 0x0007DDEC
		[O_Oo00Oo000O0(7.0)]
		[Category("地图")]
		[DisplayName("最小经度")]
		[DefaultValue("")]
		public string MinX
		{
			get
			{
				string result;
				if (double.IsNaN(this.O_.OOO_O_..Viewport.Limits.MinLong))
				{
					result = "";
				}
				else
				{
					result = this.O_.OOO_O_..Viewport.Limits.MinLong.ToString();
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0 || Operators.CompareString(value, "NaN", true) == 0)
				{
					this.O_.OOO_O_..Viewport.Limits.MinLong = double.NaN;
					return;
				}
				this.O_.OOO_O_..Viewport.Limits.MinLong = Conversion.Val(value);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x0007FC50 File Offset: 0x0007DE50
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x0007FCA0 File Offset: 0x0007DEA0
		[DisplayName("最大经度")]
		[O_Oo00Oo000O0(8.0)]
		[DefaultValue("")]
		[Category("地图")]
		public string MaxX
		{
			get
			{
				string result;
				if (double.IsNaN(this.O_.OOO_O_..Viewport.Limits.MaxLong))
				{
					result = "";
				}
				else
				{
					result = this.O_.OOO_O_..Viewport.Limits.MaxLong.ToString();
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0 || Operators.CompareString(value, "NaN", true) == 0)
				{
					this.O_.OOO_O_..Viewport.Limits.MaxLong = double.NaN;
					return;
				}
				this.O_.OOO_O_..Viewport.Limits.MaxLong = Conversion.Val(value);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x0007FD04 File Offset: 0x0007DF04
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x0007FD54 File Offset: 0x0007DF54
		[Category("地图")]
		[DefaultValue("")]
		[DisplayName("最小纬度")]
		[O_Oo00Oo000O0(9.0)]
		public string MinY
		{
			get
			{
				string result;
				if (double.IsNaN(this.O_.OOO_O_..Viewport.Limits.MinLat))
				{
					result = "";
				}
				else
				{
					result = this.O_.OOO_O_..Viewport.Limits.MinLat.ToString();
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0 || Operators.CompareString(value, "NaN", true) == 0)
				{
					this.O_.OOO_O_..Viewport.Limits.MinLat = double.NaN;
					return;
				}
				this.O_.OOO_O_..Viewport.Limits.MinLat = Conversion.Val(value);
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x0007FDB8 File Offset: 0x0007DFB8
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x0007FE08 File Offset: 0x0007E008
		[Category("地图")]
		[O_Oo00Oo000O0(10.0)]
		[DefaultValue("")]
		[DisplayName("最大纬度")]
		public string MaxY
		{
			get
			{
				string result;
				if (double.IsNaN(this.O_.OOO_O_..Viewport.Limits.MaxLat))
				{
					result = "";
				}
				else
				{
					result = this.O_.OOO_O_..Viewport.Limits.MaxLat.ToString();
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0 || Operators.CompareString(value, "NaN", true) == 0)
				{
					this.O_.OOO_O_..Viewport.Limits.MaxLat = double.NaN;
					return;
				}
				this.O_.OOO_O_..Viewport.Limits.MaxLat = Conversion.Val(value);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x0007FE6B File Offset: 0x0007E06B
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x0007FE78 File Offset: 0x0007E078
		[O_Oo00Oo000O0(11.0)]
		[Category("地图")]
		[DefaultValue(true)]
		[DisplayName("允许平移")]
		public bool AllowTranslating
		{
			get
			{
				return this.O_.OOO_O_..AllowTranslating;
			}
			set
			{
				this.O_.OOO_O_..AllowTranslating = value;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0007FE86 File Offset: 0x0007E086
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x0007FE93 File Offset: 0x0007E093
		[DefaultValue(true)]
		[Category("地图")]
		[DisplayName("允许缩放")]
		[O_Oo00Oo000O0(12.0)]
		public bool AllowZooming
		{
			get
			{
				return this.O_.OOO_O_..AllowZooming;
			}
			set
			{
				this.O_.OOO_O_..AllowZooming = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x0007FEA1 File Offset: 0x0007E0A1
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x0007FEB3 File Offset: 0x0007E0B3
		[DisplayName("显示缩放工具")]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(13.0)]
		[Category("地图")]
		public bool ZoomToolVisible
		{
			get
			{
				return this.O_.OOO_O_..ZoomTool.Visible;
			}
			set
			{
				this.O_.OOO_O_..ZoomTool.Visible = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0007FEC6 File Offset: 0x0007E0C6
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x0007FED8 File Offset: 0x0007E0D8
		[DisplayName("显示平移工具")]
		[O_Oo00Oo000O0(14.0)]
		[DefaultValue(true)]
		[Category("地图")]
		public bool PanToolVisible
		{
			get
			{
				return this.O_.OOO_O_..PanTool.Visible;
			}
			set
			{
				this.O_.OOO_O_..PanTool.Visible = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x0007FEEB File Offset: 0x0007E0EB
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x0007FEFD File Offset: 0x0007E0FD
		[Category("地图")]
		[DisplayName("显示比例尺")]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(15.0)]
		public bool DistanceScaleVisible
		{
			get
			{
				return this.O_.OOO_O_..DistanceScale.Visible;
			}
			set
			{
				this.O_.OOO_O_..DistanceScale.Visible = value;
			}
		}

		// Token: 0x040006CB RID: 1739
		private GeoMap <<EMPTY_NAME>>;

		// Token: 0x040006CC RID: 1740
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006CD RID: 1741
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006CE RID: 1742
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006CF RID: 1743
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006D0 RID: 1744
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006D1 RID: 1745
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006D2 RID: 1746
		private TileSoureEnum <<EMPTY_NAME>>;
	}
}
