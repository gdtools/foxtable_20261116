using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020002C1 RID: 705
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RecordGridProperty : PropertyBase
	{
		// Token: 0x0600268E RID: 9870 RVA: 0x0011AD57 File Offset: 0x00118F57
		internal RecordGridProperty(ControlHolder A_0) : base(A_0)
		{
			this.O.OOoo_o0. = true;
			this.oo_.000o0Oo0. = true;
			this.oo.o_O_Oo. = false;
			this.O.OOoo_o0. = (O0O__)A_0.ChildControl;
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x0600268F RID: 9871 RVA: 0x0011AD86 File Offset: 0x00118F86
		// (set) Token: 0x06002690 RID: 9872 RVA: 0x0011AD8E File Offset: 0x00118F8E
		[O_Oo00Oo000O0(2.0)]
		[Category("基本")]
		[TypeConverter(typeof(ooo_0O0))]
		[DisplayName("绑定表")]
		public string TableName
		{
			get
			{
				return this.O.OOoo_o0.;
			}
			set
			{
				this.O.OOoo_o0. = value;
				this.O.OOoo_o0..oo0oO_O.oooO0O.(value);
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06002691 RID: 9873 RVA: 0x0011ADA3 File Offset: 0x00118FA3
		// (set) Token: 0x06002692 RID: 9874 RVA: 0x0011ADAB File Offset: 0x00118FAB
		[O_Oo00Oo000O0(2.01)]
		[Editor(typeof(O00_), typeof(UITypeEditor))]
		[DisplayName("显示列")]
		[Category("基本")]
		public string Columns
		{
			get
			{
				return this.oo_.000o0Oo0.;
			}
			set
			{
				this.oo_.000o0Oo0. = value;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x0011ADB4 File Offset: 0x00118FB4
		// (set) Token: 0x06002694 RID: 9876 RVA: 0x0011ADBC File Offset: 0x00118FBC
		[DisplayName("允许打印")]
		[O_Oo00Oo000O0(10.0)]
		[DefaultValue(true)]
		[Category("输出")]
		[MergableProperty(true)]
		[Description("打印窗口时是否打印此控件。")]
		public bool Printable
		{
			get
			{
				return this.oo_.000o0Oo0.;
			}
			set
			{
				this.oo_.000o0Oo0. = value;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06002695 RID: 9877 RVA: 0x0011ADC5 File Offset: 0x00118FC5
		// (set) Token: 0x06002696 RID: 9878 RVA: 0x0011ADCD File Offset: 0x00118FCD
		[DefaultValue(false)]
		[O_Oo00Oo000O0(10.1)]
		[Description("打印时是否从此控件开始另起一页。")]
		[Category("输出")]
		[DisplayName("另起一页")]
		[MergableProperty(true)]
		public bool NewPage
		{
			get
			{
				return this.oo.o_O_Oo.;
			}
			set
			{
				this.oo.o_O_Oo. = value;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x0011ADD6 File Offset: 0x00118FD6
		// (set) Token: 0x06002698 RID: 9880 RVA: 0x0011ADDE File Offset: 0x00118FDE
		[DefaultValue(true)]
		[Category("杂项")]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("可见")]
		[MergableProperty(true)]
		public bool Visible
		{
			get
			{
				return this.O.OOoo_o0.;
			}
			set
			{
				this.O.OOoo_o0. = value;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x0011ADE7 File Offset: 0x00118FE7
		// (set) Token: 0x0600269A RID: 9882 RVA: 0x0011ADF4 File Offset: 0x00118FF4
		[MergableProperty(false)]
		[Description("确定用户按Tab键时，该控件获得焦点的顺序。")]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("Tab键顺序")]
		[Category("杂项")]
		public int TabIndex
		{
			get
			{
				return this.o_0_.Oo..TabIndex;
			}
			set
			{
				this.o_0_.Oo..TabIndex = value;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x0011AE02 File Offset: 0x00119002
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x0011AE14 File Offset: 0x00119014
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("字体")]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue("宋体,9")]
		public virtual Font Font
		{
			get
			{
				return this.o_0_.Oo..ChildControl.Font;
			}
			set
			{
				this.o_0_.Oo..ChildControl.Font = (Font)value.Clone();
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x0011AE31 File Offset: 0x00119031
		// (set) Token: 0x0600269E RID: 9886 RVA: 0x0011AE3E File Offset: 0x0011903E
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("左")]
		[Category("位置")]
		[MergableProperty(true)]
		public int Left
		{
			get
			{
				return this.o_0_.Oo..Left;
			}
			set
			{
				this.o_0_.Oo..Left = value;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x0011AE4C File Offset: 0x0011904C
		// (set) Token: 0x060026A0 RID: 9888 RVA: 0x0011AE59 File Offset: 0x00119059
		[O_Oo00Oo000O0(2.0)]
		[MergableProperty(true)]
		[Category("位置")]
		[DisplayName("上")]
		public int Top
		{
			get
			{
				return this.o_0_.Oo..Top;
			}
			set
			{
				this.o_0_.Oo..Top = value;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x0011AE67 File Offset: 0x00119067
		// (set) Token: 0x060026A2 RID: 9890 RVA: 0x0011AE74 File Offset: 0x00119074
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("宽")]
		[Category("位置")]
		[MergableProperty(true)]
		public int Width
		{
			get
			{
				return this.o_0_.Oo..Width;
			}
			set
			{
				if (!this.o_0_.Oo..IsFixedWidth)
				{
					this.o_0_.Oo..Width = value;
				}
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x0011AE8F File Offset: 0x0011908F
		// (set) Token: 0x060026A4 RID: 9892 RVA: 0x0011AE9C File Offset: 0x0011909C
		[MergableProperty(true)]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("高")]
		[Category("位置")]
		public int Height
		{
			get
			{
				return this.o_0_.Oo..Height;
			}
			set
			{
				if (!this.o_0_.Oo..IsFixedHeight)
				{
					this.o_0_.Oo..Height = value;
				}
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x0011AEB7 File Offset: 0x001190B7
		// (set) Token: 0x060026A6 RID: 9894 RVA: 0x0011AEC4 File Offset: 0x001190C4
		[MergableProperty(true)]
		[Description("在调整容器大小时，使控件的指定边缘和容器边缘的距离保持不变。")]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("锚定")]
		[Category("位置")]
		public AnchorStyles Anchor
		{
			get
			{
				return this.o_0_.Oo..Anchor;
			}
			set
			{
				this.o_0_.Oo..Anchor = value;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x0011AED2 File Offset: 0x001190D2
		// (set) Token: 0x060026A8 RID: 9896 RVA: 0x0011AEDF File Offset: 0x001190DF
		[Category("位置")]
		[Description("停靠到容器的指定边框。")]
		[O_Oo00Oo000O0(5.1)]
		[MergableProperty(false)]
		[DisplayName("停靠")]
		public DockStyle Dock
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

		// Token: 0x04000FEB RID: 4075
		private O0O__ <<EMPTY_NAME>>;

		// Token: 0x04000FEC RID: 4076
		private string <<EMPTY_NAME>>;

		// Token: 0x04000FED RID: 4077
		private string <<EMPTY_NAME>>;

		// Token: 0x04000FEE RID: 4078
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000FEF RID: 4079
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000FF0 RID: 4080
		private bool <<EMPTY_NAME>>;
	}
}
