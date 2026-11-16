using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020002C5 RID: 709
	internal class TrackBarProperty : ControlPropertyBase
	{
		// Token: 0x060026D2 RID: 9938 RVA: 0x0011B20F File Offset: 0x0011940F
		public TrackBarProperty(ControlHolder A_0) : base(A_0)
		{
			this.Oo_o0O00O.o0O. = (TrackBar)A_0.ChildControl;
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x0011B229 File Offset: 0x00119429
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x0011B231 File Offset: 0x00119431
		[O_Oo00Oo000O0(2.1)]
		[DefaultValue("")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[MergableProperty(true)]
		[DisplayName("绑定到")]
		[Category("基本")]
		public string BindingField
		{
			get
			{
				return this.Oo_o0O00O.o0O.;
			}
			set
			{
				this.Oo_o0O00O.o0O. = value;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x0011B23A File Offset: 0x0011943A
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x0011B247 File Offset: 0x00119447
		[Category("数据")]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("最大值")]
		[MergableProperty(true)]
		public int Maximum
		{
			get
			{
				return this.Oo_o0O00O.o0O..Maximum;
			}
			set
			{
				this.Oo_o0O00O.o0O..Maximum = value;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x0011B255 File Offset: 0x00119455
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x0011B262 File Offset: 0x00119462
		[DisplayName("最小值")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.0)]
		[Category("数据")]
		public int Minimum
		{
			get
			{
				return this.Oo_o0O00O.o0O..Minimum;
			}
			set
			{
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x0011B264 File Offset: 0x00119464
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x0011B271 File Offset: 0x00119471
		[DisplayName("当前值")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.0)]
		[Category("数据")]
		public int Value
		{
			get
			{
				return this.Oo_o0O00O.o0O..Value;
			}
			set
			{
				this.Oo_o0O00O.o0O..Value = value;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x0011B27F File Offset: 0x0011947F
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x0011B28C File Offset: 0x0011948C
		[DisplayName("步进(大)")]
		[Description("按下PageUp、PageDown时，滑块移动的位置数。")]
		[MergableProperty(true)]
		[Category("数据")]
		[O_Oo00Oo000O0(4.0)]
		public int LargeChange
		{
			get
			{
				return this.Oo_o0O00O.o0O..LargeChange;
			}
			set
			{
				this.Oo_o0O00O.o0O..LargeChange = value;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x0011B29A File Offset: 0x0011949A
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x0011B2A7 File Offset: 0x001194A7
		[Category("数据")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("步进(小)")]
		[Description("按下箭头键时，滑块移动的位置数。")]
		public int SmallChange
		{
			get
			{
				return this.Oo_o0O00O.o0O..SmallChange;
			}
			set
			{
				this.Oo_o0O00O.o0O..SmallChange = value;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x0011B2B5 File Offset: 0x001194B5
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x0011B2C2 File Offset: 0x001194C2
		[DisplayName("刻度间隔")]
		[Category("外观")]
		[O_Oo00Oo000O0(3.1)]
		[MergableProperty(true)]
		public int TickFrequency
		{
			get
			{
				return this.Oo_o0O00O.o0O..TickFrequency;
			}
			set
			{
				this.Oo_o0O00O.o0O..TickFrequency = value;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x0011B2D0 File Offset: 0x001194D0
		// (set) Token: 0x060026E2 RID: 9954 RVA: 0x0011B2DD File Offset: 0x001194DD
		[MergableProperty(true)]
		[DisplayName("刻度样式")]
		[O_Oo00Oo000O0(3.2)]
		[Category("外观")]
		public TickStyle TickStyle
		{
			get
			{
				return this.Oo_o0O00O.o0O..TickStyle;
			}
			set
			{
				this.Oo_o0O00O.o0O..TickStyle = value;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x0011B2EB File Offset: 0x001194EB
		// (set) Token: 0x060026E4 RID: 9956 RVA: 0x0011B2F8 File Offset: 0x001194F8
		[DisplayName("方向")]
		[Category("外观")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.3)]
		public Orientation Orientation
		{
			get
			{
				return this.Oo_o0O00O.o0O..Orientation;
			}
			set
			{
				if (this.Oo_o0O00O.o0O..Orientation != value)
				{
					if (this.Oo_o0O00O.o0O..Orientation == Orientation.Horizontal)
					{
						int width = this.Oo_o0O00O.o0O..Parent.Width;
						this.Oo_o0O00O.o0O..Orientation = Orientation.Vertical;
						this.Oo_o0O00O.o0O..Parent.Height = width;
						return;
					}
					int height = this.Oo_o0O00O.o0O..Parent.Height;
					this.Oo_o0O00O.o0O..Orientation = Orientation.Horizontal;
					this.Oo_o0O00O.o0O..Parent.Width = height;
				}
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x0011B37D File Offset: 0x0011957D
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x0011B385 File Offset: 0x00119585
		[O0O0oOO00_0OO(true)]
		[Description("移动滑块后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(0.1)]
		[Category("事件")]
		public EventString Scroll
		{
			get
			{
				return this.Oo_o0O00O.o0O.;
			}
			set
			{
				this.Oo_o0O00O.o0O. = value;
			}
		}

		// Token: 0x04000FFA RID: 4090
		private TrackBar <<EMPTY_NAME>>;

		// Token: 0x04000FFB RID: 4091
		private string <<EMPTY_NAME>>;

		// Token: 0x04000FFC RID: 4092
		private EventString <<EMPTY_NAME>>;
	}
}
