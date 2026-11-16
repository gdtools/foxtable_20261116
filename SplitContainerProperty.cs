using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000423 RID: 1059
	internal class SplitContainerProperty : ControlPropertyBase
	{
		// Token: 0x06004758 RID: 18264 RVA: 0x001F3844 File Offset: 0x001F1A44
		public SplitContainerProperty(ControlHolder A_0) : base(A_0)
		{
			this.O00o.__OOo_. = FixedPanel.Panel1;
			this.O00o.__OOo_. = (o0000O)A_0.ChildControl;
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06004759 RID: 18265 RVA: 0x001F3865 File Offset: 0x001F1A65
		// (set) Token: 0x0600475A RID: 18266 RVA: 0x001F3872 File Offset: 0x001F1A72
		[Description("停靠到容器的指定边框。")]
		[O_Oo00Oo000O0(5.1)]
		[DisplayName("停靠")]
		[Category("位置")]
		[MergableProperty(false)]
		[DefaultValue(0)]
		public new DockStyle Dock
		{
			get
			{
				return this.o_0_.Oo..Dock;
			}
			set
			{
				this.o_0_.Oo..Dock = value;
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x0600475B RID: 18267 RVA: 0x001F3880 File Offset: 0x001F1A80
		// (set) Token: 0x0600475C RID: 18268 RVA: 0x001F388D File Offset: 0x001F1A8D
		[O_Oo00Oo000O0(3.2)]
		[Description("指示水平分割还是垂直分割")]
		[MergableProperty(true)]
		[DefaultValue(1)]
		[Category("基本")]
		[DisplayName("方向")]
		public Orientation Orientation
		{
			get
			{
				return this.O00o.__OOo_..Orientation;
			}
			set
			{
				this.O00o.__OOo_..Orientation = value;
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x0600475D RID: 18269 RVA: 0x001F389B File Offset: 0x001F1A9B
		// (set) Token: 0x0600475E RID: 18270 RVA: 0x001F38AD File Offset: 0x001F1AAD
		[DefaultValue("(none)")]
		[Category("外观")]
		[O_Oo00Oo000O0(0.0)]
		[TypeConverter(typeof(o00))]
		[DisplayName("样式")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.O00o.__OOo_.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.O00o.__OOo_.
				});
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x0600475F RID: 18271 RVA: 0x001F38C9 File Offset: 0x001F1AC9
		// (set) Token: 0x06004760 RID: 18272 RVA: 0x001F38D6 File Offset: 0x001F1AD6
		[Category("外观")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.1)]
		[DefaultValue(0)]
		[DisplayName("边框")]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.O00o.__OOo_..BorderStyle;
			}
			set
			{
				this.O00o.__OOo_..BorderStyle = value;
				this.O00o.__OOo_..Invalidate();
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x001F38EF File Offset: 0x001F1AEF
		// (set) Token: 0x06004762 RID: 18274 RVA: 0x001F38FC File Offset: 0x001F1AFC
		[DisplayName("分割条宽度")]
		[DefaultValue(4)]
		[O_Oo00Oo000O0(3.4)]
		[Category("外观")]
		[MergableProperty(true)]
		public int SplitterWidth
		{
			get
			{
				return this.O00o.__OOo_..SplitterWidth;
			}
			set
			{
				this.O00o.__OOo_..SplitterWidth = value;
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x001F390A File Offset: 0x001F1B0A
		// (set) Token: 0x06004764 RID: 18276 RVA: 0x001F3912 File Offset: 0x001F1B12
		[DefaultValue(false)]
		[Description("是否禁止移动分割条。")]
		[DisplayName("固定分割条")]
		[Category("外观")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.5)]
		public bool IsSplitterFixed
		{
			get
			{
				return this.O00o.__OOo_.;
			}
			set
			{
				this.O00o.__OOo_. = value;
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06004765 RID: 18277 RVA: 0x001F391B File Offset: 0x001F1B1B
		// (set) Token: 0x06004766 RID: 18278 RVA: 0x001F3928 File Offset: 0x001F1B28
		[Description("固定其中一个分区的大小，使得其大小不随分区面板大小的调整而调整。")]
		[DefaultValue(1)]
		[OooO0(true)]
		[DisplayName("固定分区")]
		[Category("外观")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.6)]
		public FixedPanel FixedPanel
		{
			get
			{
				return this.O00o.__OOo_..FixedPanel;
			}
			set
			{
				this.O00o.__OOo_..FixedPanel = value;
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06004767 RID: 18279 RVA: 0x001F3936 File Offset: 0x001F1B36
		// (set) Token: 0x06004768 RID: 18280 RVA: 0x001F3948 File Offset: 0x001F1B48
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[DisplayName("背景颜色")]
		[Category("外观(Panel1)")]
		public Color BackColorOfPanel1
		{
			get
			{
				return this.O00o.__OOo_..oo0oO_O.oooO0O.().BackColor;
			}
			set
			{
				this.O00o.__OOo_..oo0oO_O.oooO0O.().BackColor = value;
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06004769 RID: 18281 RVA: 0x001F395B File Offset: 0x001F1B5B
		// (set) Token: 0x0600476A RID: 18282 RVA: 0x001F396D File Offset: 0x001F1B6D
		[DefaultValue(false)]
		[Category("外观(Panel1)")]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("自动滚动")]
		public bool Panel1IsAutoScroll
		{
			get
			{
				return this.O00o.__OOo_..oo0oO_O.oooO0O.().AutoScroll;
			}
			set
			{
				this.O00o.__OOo_..oo0oO_O.oooO0O.().AutoScroll = value;
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x0600476B RID: 18283 RVA: 0x001F3980 File Offset: 0x001F1B80
		// (set) Token: 0x0600476C RID: 18284 RVA: 0x001F3988 File Offset: 0x001F1B88
		[O_Oo00Oo000O0(5.0)]
		[Category("外观(Panel1)")]
		[MergableProperty(false)]
		[DefaultValue(false)]
		[DisplayName("默认隐藏")]
		public bool Panel1Collapsed
		{
			get
			{
				return this.O.Oo_.;
			}
			set
			{
				this.O.Oo_. = value;
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x0600476D RID: 18285 RVA: 0x001F3991 File Offset: 0x001F1B91
		// (set) Token: 0x0600476E RID: 18286 RVA: 0x001F39A3 File Offset: 0x001F1BA3
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("背景颜色")]
		[Category("外观(Panel2)")]
		public Color BackColorOfPanel2
		{
			get
			{
				return this.O00o.__OOo_..o.Oo0oo000O.().BackColor;
			}
			set
			{
				this.O00o.__OOo_..o.Oo0oo000O.().BackColor = value;
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x0600476F RID: 18287 RVA: 0x001F39B6 File Offset: 0x001F1BB6
		// (set) Token: 0x06004770 RID: 18288 RVA: 0x001F39C8 File Offset: 0x001F1BC8
		[O_Oo00Oo000O0(4.0)]
		[Category("外观(Panel2)")]
		[MergableProperty(false)]
		[DisplayName("自动滚动")]
		[DefaultValue(false)]
		public bool Panel2IsAutoScroll
		{
			get
			{
				return this.O00o.__OOo_..o.Oo0oo000O.().AutoScroll;
			}
			set
			{
				this.O00o.__OOo_..o.Oo0oo000O.().AutoScroll = value;
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06004771 RID: 18289 RVA: 0x001F39DB File Offset: 0x001F1BDB
		// (set) Token: 0x06004772 RID: 18290 RVA: 0x001F39E3 File Offset: 0x001F1BE3
		[DefaultValue(false)]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("默认隐藏")]
		[Category("外观(Panel2)")]
		[MergableProperty(false)]
		public bool Panel2Collapsed
		{
			get
			{
				return this.Ooo0_O0._OO.;
			}
			set
			{
				this.Ooo0_O0._OO. = value;
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06004773 RID: 18291 RVA: 0x001F39EC File Offset: 0x001F1BEC
		// (set) Token: 0x06004774 RID: 18292 RVA: 0x001F39F9 File Offset: 0x001F1BF9
		[O_Oo00Oo000O0(400.0)]
		[Browsable(false)]
		public int SplitterDistance2
		{
			get
			{
				return this.O00o.__OOo_..SplitterDistance;
			}
			set
			{
				this.O00o.__OOo_. = value;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06004775 RID: 18293 RVA: 0x001F3A02 File Offset: 0x001F1C02
		// (set) Token: 0x06004776 RID: 18294 RVA: 0x001F3A0F File Offset: 0x001F1C0F
		[DefaultValue(1)]
		[O_Oo00Oo000O0(400.0)]
		[Browsable(false)]
		public FixedPanel FixedPanel2
		{
			get
			{
				return this.O00o.__OOo_..FixedPanel;
			}
			set
			{
				this.O00o.__OOo_. = value;
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06004777 RID: 18295 RVA: 0x001F3A18 File Offset: 0x001F1C18
		// (set) Token: 0x06004778 RID: 18296 RVA: 0x001F3A20 File Offset: 0x001F1C20
		[Description("移动分割条之后执行")]
		[Category("事件")]
		[oO0oooo("0829")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.1)]
		public EventString SplitterMoved
		{
			get
			{
				return this.O00o.__OOo_.;
			}
			set
			{
				this.O00o.__OOo_. = value;
			}
		}

		// Token: 0x04001CCB RID: 7371
		private o0000O <<EMPTY_NAME>>;

		// Token: 0x04001CCC RID: 7372
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CCD RID: 7373
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CCE RID: 7374
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CCF RID: 7375
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CD0 RID: 7376
		internal int <<EMPTY_NAME>>;

		// Token: 0x04001CD1 RID: 7377
		internal FixedPanel <<EMPTY_NAME>>;

		// Token: 0x04001CD2 RID: 7378
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CD3 RID: 7379
		private string <<EMPTY_NAME>>;
	}
}
