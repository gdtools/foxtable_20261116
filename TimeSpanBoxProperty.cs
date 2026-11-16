using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002C4 RID: 708
	internal class TimeSpanBoxProperty : ControlPropertyBase
	{
		// Token: 0x060026B7 RID: 9911 RVA: 0x0011B060 File Offset: 0x00119260
		public TimeSpanBoxProperty(ControlHolder A_0) : base(A_0)
		{
			this.o.Ooo_0__0Oo. = (C1TextBox)A_0.ChildControl;
			this.o.Ooo_0__0Oo..VerticalAlign = VerticalAlignEnum.Middle;
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060026B8 RID: 9912 RVA: 0x0011B086 File Offset: 0x00119286
		// (set) Token: 0x060026B9 RID: 9913 RVA: 0x0011B08E File Offset: 0x0011928E
		[DisplayName("名称")]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(1.0)]
		[Category("基本")]
		public override string Name
		{
			get
			{
				return base.Name;
			}
			set
			{
				base.Name = value;
				if (Operators.CompareString(this.BindingField, "", true) == 0)
				{
					this.o.Ooo_0__0Oo..Text = value;
				}
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x0011B0B6 File Offset: 0x001192B6
		// (set) Token: 0x060026BB RID: 9915 RVA: 0x0011B0BE File Offset: 0x001192BE
		[DisplayName("初始值")]
		[O_Oo00Oo000O0(2.2)]
		[Category("基本")]
		[MergableProperty(true)]
		[DefaultValue("")]
		public string Value
		{
			get
			{
				return this.O___0O.oo.;
			}
			set
			{
				this.O___0O.oo. = value;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x0011B0C7 File Offset: 0x001192C7
		// (set) Token: 0x060026BD RID: 9917 RVA: 0x0011B0CF File Offset: 0x001192CF
		[O_Oo00Oo000O0(2.1)]
		[MergableProperty(true)]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[Category("基本")]
		[DefaultValue("")]
		[DisplayName("绑定到")]
		public string BindingField
		{
			get
			{
				return this.oo.0oOO.;
			}
			set
			{
				this.oo.0oOO. = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.o.Ooo_0__0Oo..Text = value;
					return;
				}
				this.o.Ooo_0__0Oo..Text = this.Name;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x060026BE RID: 9918 RVA: 0x0011B105 File Offset: 0x00119305
		// (set) Token: 0x060026BF RID: 9919 RVA: 0x0011B10D File Offset: 0x0011930D
		[DefaultValue(0)]
		[O_Oo00Oo000O0(2.3)]
		[DisplayName("只读")]
		[Category("基本")]
		[Description("是否禁止用户修改。")]
		[MergableProperty(true)]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.oo.0oOO.;
			}
			set
			{
				this.oo.0oOO. = value;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x0011B118 File Offset: 0x00119318
		// (set) Token: 0x060026C1 RID: 9921 RVA: 0x0011B126 File Offset: 0x00119326
		[Browsable(false)]
		[OooO0(false)]
		public VisualStyle VisualStyle
		{
			get
			{
				VisualStyle result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x0011B128 File Offset: 0x00119328
		// (set) Token: 0x060026C3 RID: 9923 RVA: 0x0011B13A File Offset: 0x0011933A
		[DefaultValue("(default)")]
		[TypeConverter(typeof(o00))]
		[O_Oo00Oo000O0(0.0)]
		[DisplayName("样式")]
		[Category("外观")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.o.Ooo_0__0Oo.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.o.Ooo_0__0Oo.
				});
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x0011B156 File Offset: 0x00119356
		// (set) Token: 0x060026C5 RID: 9925 RVA: 0x0011B163 File Offset: 0x00119363
		[DisplayName("文本位置")]
		[Category("外观")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(0)]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.o.Ooo_0__0Oo..TextAlign;
			}
			set
			{
				this.o.Ooo_0__0Oo..TextAlign = value;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x0011B171 File Offset: 0x00119371
		// (set) Token: 0x060026C7 RID: 9927 RVA: 0x0011B17E File Offset: 0x0011937E
		[O_Oo00Oo000O0(0.4)]
		[MergableProperty(true)]
		[DefaultValue(2)]
		[Category("外观")]
		[DisplayName("边框样式")]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.o.Ooo_0__0Oo..BorderStyle;
			}
			set
			{
				this.o.Ooo_0__0Oo..BorderStyle = value;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x0011B18C File Offset: 0x0011938C
		// (set) Token: 0x060026C9 RID: 9929 RVA: 0x0011B199 File Offset: 0x00119399
		[Category("外观")]
		[O_Oo00Oo000O0(0.41)]
		[DisplayName("边框颜色")]
		[MergableProperty(true)]
		[DefaultValue(-10197916)]
		public Color BorderColor
		{
			get
			{
				return this.o.Ooo_0__0Oo..BorderColor;
			}
			set
			{
				this.o.Ooo_0__0Oo..BorderColor = value;
				if (this.o.Ooo_0__0Oo..BorderStyle != BorderStyle.FixedSingle)
				{
					this.o.Ooo_0__0Oo..BorderStyle = BorderStyle.FixedSingle;
				}
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x0011B1C1 File Offset: 0x001193C1
		// (set) Token: 0x060026CB RID: 9931 RVA: 0x0011B1C9 File Offset: 0x001193C9
		[O_Oo00Oo000O0(2.0)]
		[MergableProperty(true)]
		[Category("输入控制")]
		[DisplayName("输入掩码")]
		public string EditMask
		{
			get
			{
				return this.o.0O_ooOo00.;
			}
			set
			{
				this.o.0O_ooOo00. = value;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x0011B1D2 File Offset: 0x001193D2
		// (set) Token: 0x060026CD RID: 9933 RVA: 0x0011B1DF File Offset: 0x001193DF
		[DefaultValue(0)]
		[DisplayName("初始光标位置")]
		[O_Oo00Oo000O0(11.0)]
		[Category("输入控制")]
		[MergableProperty(true)]
		public InitialSelectionEnum InitialSelection
		{
			get
			{
				return this.o.Ooo_0__0Oo..InitialSelection;
			}
			set
			{
				this.o.Ooo_0__0Oo..InitialSelection = value;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x0011B1ED File Offset: 0x001193ED
		// (set) Token: 0x060026CF RID: 9935 RVA: 0x0011B1F5 File Offset: 0x001193F5
		[oO0oooo("0769")]
		[Category("事件")]
		[O_Oo00Oo000O0(0.1)]
		[Description("值改变后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString ValueChanged
		{
			get
			{
				return this.O00___._OO_.;
			}
			set
			{
				this.O00___._OO_. = value;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x0011B1FE File Offset: 0x001193FE
		// (set) Token: 0x060026D1 RID: 9937 RVA: 0x0011B206 File Offset: 0x00119406
		[oO0oooo("0768")]
		[O_Oo00Oo000O0(0.2)]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("文本改变后执行")]
		[O0O0oOO00_0OO(true)]
		public EventString TextChanged
		{
			get
			{
				return this.oo.0oOO.;
			}
			set
			{
				this.oo.0oOO. = value;
			}
		}

		// Token: 0x04000FF3 RID: 4083
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000FF4 RID: 4084
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000FF5 RID: 4085
		private string <<EMPTY_NAME>>;

		// Token: 0x04000FF6 RID: 4086
		private string <<EMPTY_NAME>>;

		// Token: 0x04000FF7 RID: 4087
		private string <<EMPTY_NAME>>;

		// Token: 0x04000FF8 RID: 4088
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000FF9 RID: 4089
		private EventString <<EMPTY_NAME>>;
	}
}
