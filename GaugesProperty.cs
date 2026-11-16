using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using C1.Win.C1Gauge;

namespace Foxtable
{
	// Token: 0x02000175 RID: 373
	internal class GaugesProperty : ControlPropertyBase
	{
		// Token: 0x0600118D RID: 4493 RVA: 0x0007F754 File Offset: 0x0007D954
		internal GaugesProperty(ControlHolder A_0) : base(A_0)
		{
			this.o_0__oo.oo_. = (O0_O_0O)A_0.ChildControl;
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x0007F76E File Offset: 0x0007D96E
		[OooO0(true)]
		[O_Oo00Oo000O0(12.0)]
		[Editor(typeof(o__OO), typeof(UITypeEditor))]
		[Category("基本")]
		[MergableProperty(true)]
		public GaugeCollection Gauges
		{
			get
			{
				return this.o_0__oo.oo_..Gauges;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x0007F77B File Offset: 0x0007D97B
		[OooO0(true)]
		[MergableProperty(true)]
		[Category("杂项")]
		[Editor(typeof(oo_OOOOooO), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(-19.0)]
		public ShapeCollection FaceShapes
		{
			get
			{
				return this.o_0__oo.oo_..FaceShapes;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x0007F788 File Offset: 0x0007D988
		[OooO0(true)]
		[Editor(typeof(oo_OOOOooO), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(-20.0)]
		[MergableProperty(true)]
		[Category("杂项")]
		public ShapeCollection CoverShapes
		{
			get
			{
				return this.o_0__oo.oo_..CoverShapes;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x0007F795 File Offset: 0x0007D995
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x0007F79D File Offset: 0x0007D99D
		[oO0oooo("3920")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("单击某个组件时触发")]
		[O_Oo00Oo000O0(0.5)]
		[DisplayName("ItemClick")]
		[Category("Gauge事件")]
		[O0O0oOO00_0OO(true)]
		public EventString GaugeItemClick
		{
			get
			{
				return this.O_oO.o.;
			}
			set
			{
				this.O_oO.o. = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x0007F7A6 File Offset: 0x0007D9A6
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0007F7AE File Offset: 0x0007D9AE
		[oO0oooo("3920")]
		[O_Oo00Oo000O0(0.6)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("双击某个组件时触发")]
		[Category("Gauge事件")]
		[DisplayName("ItemDoubleClick")]
		[O0O0oOO00_0OO(true)]
		public EventString GaugeItemDoubleClick
		{
			get
			{
				return this.OOoOO_0O._ooO.;
			}
			set
			{
				this.OOoOO_0O._ooO. = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x0007F7B7 File Offset: 0x0007D9B7
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x0007F7BF File Offset: 0x0007D9BF
		[oO0oooo("3920")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(0.7)]
		[Description("当鼠标悬停在某个组件并按下鼠标时触发")]
		[DisplayName("ItemMouseDown")]
		[Category("Gauge事件")]
		[O0O0oOO00_0OO(true)]
		public EventString GaugeItemMouseDown
		{
			get
			{
				return this.oOoo0oO.oooO__.;
			}
			set
			{
				this.oOoo0oO.oooO__. = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x0007F7C8 File Offset: 0x0007D9C8
		// (set) Token: 0x06001198 RID: 4504 RVA: 0x0007F7D0 File Offset: 0x0007D9D0
		[oO0oooo("3920")]
		[DisplayName("ItemMouseUp")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(0.8)]
		[Description("当鼠标悬停在某个组件并松开鼠标时触发")]
		[Category("Gauge事件")]
		[O0O0oOO00_0OO(true)]
		public EventString GaugeItemMouseUp
		{
			get
			{
				return this.O_o0o_o.OOo.;
			}
			set
			{
				this.O_o0o_o.OOo. = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x0007F7D9 File Offset: 0x0007D9D9
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x0007F7E1 File Offset: 0x0007D9E1
		[oO0oooo("3920")]
		[Category("Gauge事件")]
		[DisplayName("ItemMouseEnter")]
		[O_Oo00Oo000O0(0.9)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("当鼠标进入某个组件时触发")]
		[O0O0oOO00_0OO(true)]
		public EventString GaugeItemMouseEnter
		{
			get
			{
				return this.OoO.OOO_OO00_o.;
			}
			set
			{
				this.OoO.OOO_OO00_o. = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x0007F7EA File Offset: 0x0007D9EA
		// (set) Token: 0x0600119C RID: 4508 RVA: 0x0007F7F2 File Offset: 0x0007D9F2
		[oO0oooo("3920")]
		[Category("Gauge事件")]
		[Description("当鼠标离开某个组件时触发")]
		[DisplayName("ItemMouseLeave")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.0)]
		public EventString GaugeItemMouseLeave
		{
			get
			{
				return this.O.__O0o__o.;
			}
			set
			{
				this.O.__O0o__o. = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x0007F7FB File Offset: 0x0007D9FB
		// (set) Token: 0x0600119E RID: 4510 RVA: 0x0007F803 File Offset: 0x0007DA03
		[oO0oooo("3920")]
		[O_Oo00Oo000O0(1.1)]
		[Category("Gauge事件")]
		[DisplayName("ItemMouseMove")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("当鼠标经过某个组件时触发")]
		[O0O0oOO00_0OO(true)]
		public EventString GaugeItemMouseMove
		{
			get
			{
				return this.oo.OO0OOoO.;
			}
			set
			{
				this.oo.OO0OOoO. = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x0007F80C File Offset: 0x0007DA0C
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x0007F814 File Offset: 0x0007DA14
		[oO0oooo("3920")]
		[DisplayName("ItemStateChanged")]
		[Category("Gauge事件")]
		[Description("当某个组件的状态改变时触发")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(1.2)]
		[O0O0oOO00_0OO(true)]
		public EventString GaugeItemStateChanged
		{
			get
			{
				return this.oo_.o0_.;
			}
			set
			{
				this.oo_.o0_. = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x0007F81D File Offset: 0x0007DA1D
		// (set) Token: 0x060011A2 RID: 4514 RVA: 0x0007F825 File Offset: 0x0007DA25
		[oO0oooo("3929")]
		[Description("格式化标签时触发")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[DisplayName("FormatLabel")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.3)]
		[Category("Gauge事件")]
		public EventString GaugeFormatLabel
		{
			get
			{
				return this.oO_oo_.00o_o.;
			}
			set
			{
				this.oO_oo_.00o_o. = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0007F82E File Offset: 0x0007DA2E
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0007F836 File Offset: 0x0007DA36
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("Gauge事件")]
		[oO0oooo("3934")]
		[Description("指针值发生变化后触发")]
		[DisplayName("PointerValueChanged")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.4)]
		public EventString GaugePointerValueChanged
		{
			get
			{
				return this.OO0o.OOO_oo0_.;
			}
			set
			{
				this.OO0o.OOO_oo0_. = value;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x0007F83F File Offset: 0x0007DA3F
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x0007F847 File Offset: 0x0007DA47
		[oO0oooo("3920")]
		[Description("开始拖拽某个指针时触发")]
		[Category("Gauge事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.2)]
		public EventString PointerDragBegin
		{
			get
			{
				return this.o0OoO_000_._o.;
			}
			set
			{
				this.o0OoO_000_._o. = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x0007F850 File Offset: 0x0007DA50
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x0007F858 File Offset: 0x0007DA58
		[oO0oooo("3920")]
		[O_Oo00Oo000O0(0.3)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Description("结束拖拽某个指针时触发")]
		[Category("Gauge事件")]
		public EventString PointerDragEnd
		{
			get
			{
				return this.OO0o0O.0oooO.;
			}
			set
			{
				this.OO0o0O.0oooO. = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x0007F861 File Offset: 0x0007DA61
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x0007F869 File Offset: 0x0007DA69
		[Description("按ESC键取消拖拽某个指针后触发")]
		[O_Oo00Oo000O0(0.4)]
		[Category("Gauge事件")]
		[O0O0oOO00_0OO(true)]
		[oO0oooo("3920")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString PointerDragCancel
		{
			get
			{
				return this.oOOO_.O0o.;
			}
			set
			{
				this.oOOO_.O0o. = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x0007F872 File Offset: 0x0007DA72
		// (set) Token: 0x060011AC RID: 4524 RVA: 0x0007F87A File Offset: 0x0007DA7A
		[Description("在拖拽某个指针的过程中触发")]
		[O_Oo00Oo000O0(0.1)]
		[Category("Gauge事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[oO0oooo("3920")]
		public EventString PointerDragMove
		{
			get
			{
				return this.oo_0oo_O.OO0o.;
			}
			set
			{
				this.oo_0oo_O.OO0o. = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x0007F883 File Offset: 0x0007DA83
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x0007F88B File Offset: 0x0007DA8B
		[MergableProperty(false)]
		[O_Oo00Oo000O0(3.0)]
		[Category("外观")]
		[DisplayName("背景图片")]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		public string BackGroundImageFile
		{
			get
			{
				return this.O_oO.o.;
			}
			set
			{
				this.O_oO.o. = value;
				this.o_0__oo.oo_..BackgroundImage = OO_00oOO.GetImage(value);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x0007F8A5 File Offset: 0x0007DAA5
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x0007F8B2 File Offset: 0x0007DAB2
		[DefaultValue(1)]
		[O_Oo00Oo000O0(4.0)]
		[Category("外观")]
		[MergableProperty(false)]
		[DisplayName("背景布局")]
		public ImageLayout BackgroundImageLayout
		{
			get
			{
				return this.o_0__oo.oo_..BackgroundImageLayout;
			}
			set
			{
				this.o_0__oo.oo_..BackgroundImageLayout = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0007F8C0 File Offset: 0x0007DAC0
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x0007F900 File Offset: 0x0007DB00
		[Browsable(false)]
		public string Settings
		{
			get
			{
				string tempFileName = Path.GetTempFileName();
				this.o_0__oo.oo_..Save(tempFileName, Encoding.UTF8);
				string result = OO_00oOO.FileSys.ReadAllText(tempFileName, Encoding.UTF8);
				OO_00oOO.FileSys.DeleteFile(tempFileName);
				return result;
			}
			set
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(value);
				this.o_0__oo.oo_..Load(xmlDocument);
			}
		}

		// Token: 0x040006BB RID: 1723
		private O0_O_0O <<EMPTY_NAME>>;

		// Token: 0x040006BC RID: 1724
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006BD RID: 1725
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006BE RID: 1726
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006BF RID: 1727
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006C0 RID: 1728
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006C1 RID: 1729
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006C2 RID: 1730
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006C3 RID: 1731
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006C4 RID: 1732
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006C5 RID: 1733
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006C6 RID: 1734
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006C7 RID: 1735
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006C8 RID: 1736
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006C9 RID: 1737
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006CA RID: 1738
		private string <<EMPTY_NAME>>;
	}
}
