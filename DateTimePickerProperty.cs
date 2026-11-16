using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000413 RID: 1043
	internal class DateTimePickerProperty : ControlPropertyBase
	{
		// Token: 0x0600454F RID: 17743 RVA: 0x001F1885 File Offset: 0x001EFA85
		public DateTimePickerProperty(ControlHolder A_0) : base(A_0)
		{
			this.o.oOOOo___o_. = new Size(1, 1);
			this.ooO_O.O_O. = (C1DropDownControl)A_0.ChildControl;
			this.ooO_O.O_O..ShowUpDownButtons = false;
			this.ooO_O.O_O..VerticalAlign = VerticalAlignEnum.Middle;
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06004550 RID: 17744 RVA: 0x001F18C4 File Offset: 0x001EFAC4
		// (set) Token: 0x06004551 RID: 17745 RVA: 0x001F18CC File Offset: 0x001EFACC
		[DisplayName("名称")]
		[O_Oo00Oo000O0(1.0)]
		[Category("基本")]
		[MergableProperty(false)]
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
					this.ooO_O.O_O..Text = value;
				}
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06004552 RID: 17746 RVA: 0x001F18F4 File Offset: 0x001EFAF4
		// (set) Token: 0x06004553 RID: 17747 RVA: 0x001F18FC File Offset: 0x001EFAFC
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.2)]
		[DisplayName("初始值")]
		[Category("基本")]
		public DateTime Value
		{
			get
			{
				return this.o.oOOOo___o_.;
			}
			set
			{
				this.o.oOOOo___o_. = value;
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06004554 RID: 17748 RVA: 0x001F1905 File Offset: 0x001EFB05
		// (set) Token: 0x06004555 RID: 17749 RVA: 0x001F190D File Offset: 0x001EFB0D
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[MergableProperty(false)]
		[DisplayName("绑定到")]
		[Category("基本")]
		[O_Oo00Oo000O0(2.1)]
		public string BindingField
		{
			get
			{
				return this.o.oOOOo___o_.;
			}
			set
			{
				this.o.oOOOo___o_. = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.ooO_O.O_O..Text = value;
					return;
				}
				this.ooO_O.O_O..Text = this.Name;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06004556 RID: 17750 RVA: 0x001F1943 File Offset: 0x001EFB43
		// (set) Token: 0x06004557 RID: 17751 RVA: 0x001F194B File Offset: 0x001EFB4B
		[Category("基本")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(2.3)]
		[DisplayName("只读")]
		[Description("禁止用户修改。")]
		[MergableProperty(true)]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.o.oOOOo___o_.;
			}
			set
			{
				this.o.oOOOo___o_. = value;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06004558 RID: 17752 RVA: 0x001F1954 File Offset: 0x001EFB54
		// (set) Token: 0x06004559 RID: 17753 RVA: 0x001F195C File Offset: 0x001EFB5C
		[O_Oo00Oo000O0(20.0)]
		[DefaultValue(0)]
		[Category("基本")]
		[DisplayName("日期时间格式")]
		public DateTimeFormatEnum DateTimeFormat
		{
			get
			{
				return this.o.oOOOo___o_.;
			}
			set
			{
				this.o.oOOOo___o_. = value;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x0600455A RID: 17754 RVA: 0x001F1968 File Offset: 0x001EFB68
		// (set) Token: 0x0600455B RID: 17755 RVA: 0x001F1976 File Offset: 0x001EFB76
		[OooO0(false)]
		[Browsable(false)]
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

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x0600455C RID: 17756 RVA: 0x001F1978 File Offset: 0x001EFB78
		// (set) Token: 0x0600455D RID: 17757 RVA: 0x001F198A File Offset: 0x001EFB8A
		[O_Oo00Oo000O0(0.0)]
		[TypeConverter(typeof(o00))]
		[DisplayName("样式")]
		[Category("外观")]
		[DefaultValue("(default)")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.ooO_O.O_O.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.ooO_O.O_O.
				});
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x0600455E RID: 17758 RVA: 0x001F19A6 File Offset: 0x001EFBA6
		// (set) Token: 0x0600455F RID: 17759 RVA: 0x001F19B3 File Offset: 0x001EFBB3
		[Category("外观")]
		[DisplayName("文本位置")]
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[DefaultValue(0)]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.ooO_O.O_O..TextAlign;
			}
			set
			{
				this.ooO_O.O_O..TextAlign = value;
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06004560 RID: 17760 RVA: 0x001F19C1 File Offset: 0x001EFBC1
		// (set) Token: 0x06004561 RID: 17761 RVA: 0x001F19CE File Offset: 0x001EFBCE
		[Category("外观")]
		[O_Oo00Oo000O0(0.2)]
		[DisplayName("边框样式")]
		[MergableProperty(true)]
		[DefaultValue(2)]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.ooO_O.O_O..BorderStyle;
			}
			set
			{
				this.ooO_O.O_O..BorderStyle = value;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06004562 RID: 17762 RVA: 0x001F19DC File Offset: 0x001EFBDC
		// (set) Token: 0x06004563 RID: 17763 RVA: 0x001F19E9 File Offset: 0x001EFBE9
		[DefaultValue(-10197916)]
		[O_Oo00Oo000O0(0.41)]
		[MergableProperty(true)]
		[DisplayName("边框颜色")]
		[Category("外观")]
		public Color BorderColor
		{
			get
			{
				return this.ooO_O.O_O..BorderColor;
			}
			set
			{
				this.ooO_O.O_O..BorderColor = value;
				if (this.ooO_O.O_O..BorderStyle != BorderStyle.FixedSingle)
				{
					this.ooO_O.O_O..BorderStyle = BorderStyle.FixedSingle;
				}
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06004564 RID: 17764 RVA: 0x001F1A11 File Offset: 0x001EFC11
		// (set) Token: 0x06004565 RID: 17765 RVA: 0x001F1A1E File Offset: 0x001EFC1E
		[DefaultValue(true)]
		[MergableProperty(true)]
		[DisplayName("下拉按钮")]
		[Category("输入控制")]
		[O_Oo00Oo000O0(3.0)]
		public bool ShowDropDownButton
		{
			get
			{
				return this.ooO_O.O_O..ShowDropDownButton;
			}
			set
			{
				this.ooO_O.O_O..ShowDropDownButton = value;
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06004566 RID: 17766 RVA: 0x001F1A2C File Offset: 0x001EFC2C
		// (set) Token: 0x06004567 RID: 17767 RVA: 0x001F1A34 File Offset: 0x001EFC34
		[DisplayName("显示周数")]
		[MergableProperty(true)]
		[DefaultValue(false)]
		[O_Oo00Oo000O0(4.0)]
		[Category("输入控制")]
		public bool ShowWeekNumbers
		{
			get
			{
				return this.o.oOOOo___o_.;
			}
			set
			{
				this.o.oOOOo___o_. = value;
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06004568 RID: 17768 RVA: 0x001F1A3D File Offset: 0x001EFC3D
		// (set) Token: 0x06004569 RID: 17769 RVA: 0x001F1A45 File Offset: 0x001EFC45
		[O_Oo00Oo000O0(5.0)]
		[MergableProperty(true)]
		[Category("输入控制")]
		[DisplayName("日历维数")]
		public Size CalendarDimensions
		{
			get
			{
				return this.o.oOOOo___o_.;
			}
			set
			{
				value.Width = Math.Max(1, Math.Min(6, value.Width));
				value.Height = Math.Max(1, Math.Min(6, value.Height));
				this.o.oOOOo___o_. = value;
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x0600456A RID: 17770 RVA: 0x001F1A82 File Offset: 0x001EFC82
		// (set) Token: 0x0600456B RID: 17771 RVA: 0x001F1A8A File Offset: 0x001EFC8A
		[Description("文本改变后执行")]
		[oO0oooo("0768")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.1)]
		public EventString TextChanged
		{
			get
			{
				return this.o.oOOOo___o_.;
			}
			set
			{
				this.o.oOOOo___o_. = value;
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x0600456C RID: 17772 RVA: 0x001F1A93 File Offset: 0x001EFC93
		// (set) Token: 0x0600456D RID: 17773 RVA: 0x001F1A9B File Offset: 0x001EFC9B
		[oO0oooo("0769")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("值改变后执行")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.2)]
		public EventString ValueChanged
		{
			get
			{
				return this.O0_o.0.;
			}
			set
			{
				this.O0_o.0. = value;
			}
		}

		// Token: 0x04001C1F RID: 7199
		private C1DropDownControl <<EMPTY_NAME>>;

		// Token: 0x04001C20 RID: 7200
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001C21 RID: 7201
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C22 RID: 7202
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x04001C23 RID: 7203
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C24 RID: 7204
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C25 RID: 7205
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C26 RID: 7206
		private Size <<EMPTY_NAME>>;

		// Token: 0x04001C27 RID: 7207
		private DateTimeFormatEnum <<EMPTY_NAME>>;
	}
}
