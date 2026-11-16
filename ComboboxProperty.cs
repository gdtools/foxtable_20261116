using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200040F RID: 1039
	internal class ComboboxProperty : ControlPropertyBase
	{
		// Token: 0x060044E5 RID: 17637 RVA: 0x001F11A8 File Offset: 0x001EF3A8
		public ComboboxProperty(ControlHolder A_0) : base(A_0)
		{
			this.O_.o_. = true;
			this.o0__Oo.0__. = 11;
			this.o_00o.00O0o_0. = true;
			this.O_OO.O0o000o0O. = 6;
			this.oo.O0o0o. = (C1DropDownControl)A_0.ChildControl;
			this.oo.O0o0o..VerticalAlign = VerticalAlignEnum.Middle;
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x001F11F6 File Offset: 0x001EF3F6
		// (set) Token: 0x060044E7 RID: 17639 RVA: 0x001F11FE File Offset: 0x001EF3FE
		[Category("基本")]
		[DisplayName("名称")]
		[O_Oo00Oo000O0(1.0)]
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
					this.oo.O0o0o..Text = value;
				}
			}
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x001F1226 File Offset: 0x001EF426
		// (set) Token: 0x060044E9 RID: 17641 RVA: 0x001F122E File Offset: 0x001EF42E
		[DisplayName("初始值")]
		[Category("基本")]
		[O_Oo00Oo000O0(2.2)]
		[MergableProperty(false)]
		[DefaultValue("")]
		public string Value
		{
			get
			{
				return this.o0O0O._.;
			}
			set
			{
				this.o0O0O._. = value;
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x001F1237 File Offset: 0x001EF437
		// (set) Token: 0x060044EB RID: 17643 RVA: 0x001F123F File Offset: 0x001EF43F
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[MergableProperty(false)]
		[Category("基本")]
		[DisplayName("绑定到")]
		[O_Oo00Oo000O0(2.1)]
		public string BindingField
		{
			get
			{
				return this.O_.o_.;
			}
			set
			{
				this.O_.o_. = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.oo.O0o0o..Text = value;
					return;
				}
				this.oo.O0o0o..Text = this.Name;
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x001F1275 File Offset: 0x001EF475
		// (set) Token: 0x060044ED RID: 17645 RVA: 0x001F127D File Offset: 0x001EF47D
		[MergableProperty(true)]
		[Description("禁止用户修改。")]
		[O_Oo00Oo000O0(2.3)]
		[DisplayName("只读")]
		[DefaultValue(0)]
		[Category("基本")]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.o.0OOO_.;
			}
			set
			{
				this.o.0OOO_. = value;
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x001F1288 File Offset: 0x001EF488
		// (set) Token: 0x060044EF RID: 17647 RVA: 0x001F1296 File Offset: 0x001EF496
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

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x060044F0 RID: 17648 RVA: 0x001F1298 File Offset: 0x001EF498
		// (set) Token: 0x060044F1 RID: 17649 RVA: 0x001F12AA File Offset: 0x001EF4AA
		[TypeConverter(typeof(o00))]
		[O_Oo00Oo000O0(0.0)]
		[DisplayName("样式")]
		[Category("外观")]
		[DefaultValue("(default)")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.oo.O0o0o.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.oo.O0o0o.
				});
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x060044F2 RID: 17650 RVA: 0x001F12C6 File Offset: 0x001EF4C6
		// (set) Token: 0x060044F3 RID: 17651 RVA: 0x001F12D3 File Offset: 0x001EF4D3
		[O_Oo00Oo000O0(1.0)]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("文本位置")]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.oo.O0o0o..TextAlign;
			}
			set
			{
				this.oo.O0o0o..TextAlign = value;
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x060044F4 RID: 17652 RVA: 0x001F12E1 File Offset: 0x001EF4E1
		// (set) Token: 0x060044F5 RID: 17653 RVA: 0x001F12EE File Offset: 0x001EF4EE
		[Category("外观")]
		[O_Oo00Oo000O0(0.4)]
		[DefaultValue(2)]
		[MergableProperty(true)]
		[DisplayName("边框样式")]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.oo.O0o0o..BorderStyle;
			}
			set
			{
				this.oo.O0o0o..BorderStyle = value;
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x060044F6 RID: 17654 RVA: 0x001F12FC File Offset: 0x001EF4FC
		// (set) Token: 0x060044F7 RID: 17655 RVA: 0x001F1309 File Offset: 0x001EF509
		[MergableProperty(true)]
		[DefaultValue(-10197916)]
		[Category("外观")]
		[O_Oo00Oo000O0(0.41)]
		[DisplayName("边框颜色")]
		public Color BorderColor
		{
			get
			{
				return this.oo.O0o0o..BorderColor;
			}
			set
			{
				this.oo.O0o0o..BorderColor = value;
				if (this.oo.O0o0o..BorderStyle != BorderStyle.FixedSingle)
				{
					this.oo.O0o0o..BorderStyle = BorderStyle.FixedSingle;
				}
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x060044F8 RID: 17656 RVA: 0x001F1331 File Offset: 0x001EF531
		// (set) Token: 0x060044F9 RID: 17657 RVA: 0x001F1339 File Offset: 0x001EF539
		[Category("列表项目")]
		[MergableProperty(true)]
		[DefaultValue(true)]
		[Description("允许用户直接输入不在列表项目中的值")]
		[O_Oo00Oo000O0(13.0)]
		[DisplayName("允许直接输入")]
		public bool AllowEditValue
		{
			get
			{
				return this.O_.o_.;
			}
			set
			{
				this.O_.o_. = value;
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x060044FA RID: 17658 RVA: 0x001F1342 File Offset: 0x001EF542
		// (set) Token: 0x060044FB RID: 17659 RVA: 0x001F134A File Offset: 0x001EF54A
		[DisplayName("启用输入助手")]
		[O_Oo00Oo000O0(13.1)]
		[MergableProperty(false)]
		[Category("列表项目")]
		[Description("在手工输入的时候，是否启用输入助手，以提高用户输入效率。")]
		[DefaultValue(false)]
		public bool AutoComplete
		{
			get
			{
				return this.o.o_Oo.;
			}
			set
			{
				this.o.o_Oo. = value;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x001F1353 File Offset: 0x001EF553
		// (set) Token: 0x060044FD RID: 17661 RVA: 0x001F135B File Offset: 0x001EF55B
		[O_Oo00Oo000O0(2.0)]
		[Category("列表项目")]
		[Editor(typeof(ooO0o0_oO0_0), typeof(UITypeEditor))]
		[MergableProperty(true)]
		[DisplayName("自定义项目")]
		public string ComboList
		{
			get
			{
				return this.oo00o_.OooO.;
			}
			set
			{
				this.oo00o_.OooO. = value;
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x060044FE RID: 17662 RVA: 0x001F1364 File Offset: 0x001EF564
		// (set) Token: 0x060044FF RID: 17663 RVA: 0x001F136C File Offset: 0x001EF56C
		[O_Oo00Oo000O0(4.0)]
		[Category("列表项目")]
		[TypeConverter(typeof(oo0OOO_0__))]
		[MergableProperty(false)]
		[DisplayName("显示列")]
		public string DisplayMember
		{
			get
			{
				return this.O_OO.O0o000o0O.;
			}
			set
			{
				this.O_OO.O0o000o0O. = value;
				if (Operators.CompareString(this.oOo.___oOooo0_., "", true) == 0)
				{
					this.oOo.___oOooo0_. = value;
				}
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06004500 RID: 17664 RVA: 0x001F138F File Offset: 0x001EF58F
		// (set) Token: 0x06004501 RID: 17665 RVA: 0x001F1397 File Offset: 0x001EF597
		[Category("列表项目")]
		[DisplayName("取值列")]
		[O_Oo00Oo000O0(5.0)]
		[TypeConverter(typeof(oo0OOO_0__))]
		[MergableProperty(false)]
		public string ValueMember
		{
			get
			{
				return this.oOo.___oOooo0_.;
			}
			set
			{
				this.oOo.___oOooo0_. = value;
				if (Operators.CompareString(this.O_OO.O0o000o0O., "", true) == 0)
				{
					this.O_OO.O0o000o0O. = value;
				}
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06004502 RID: 17666 RVA: 0x001F13BA File Offset: 0x001EF5BA
		// (set) Token: 0x06004503 RID: 17667 RVA: 0x001F13C4 File Offset: 0x001EF5C4
		[Description("候选项目来源表")]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("数据表")]
		[Category("列表项目")]
		[TypeConverter(typeof(OoO_O0_OO0))]
		[MergableProperty(false)]
		public string DataSource
		{
			get
			{
				return this.oo_O_Oo0_.O.;
			}
			set
			{
				this.oo_O_Oo0_.O. = value;
				if (Operators.CompareString(value, "", true) == 0)
				{
					this.ValueMember = "";
					this.DisplayMember = "";
					return;
				}
				if (OO_00oOO.DataTables.Contains(value))
				{
					if (Operators.CompareString(this.DisplayMember, "", true) > 0 && !OO_00oOO.DataTables[value].DataCols.Contains(this.DisplayMember))
					{
						this.DisplayMember = "";
					}
					if (Operators.CompareString(this.ValueMember, "", true) > 0 && !OO_00oOO.DataTables[value].DataCols.Contains(this.ValueMember))
					{
						this.ValueMember = "";
					}
				}
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06004504 RID: 17668 RVA: 0x001F1482 File Offset: 0x001EF682
		// (set) Token: 0x06004505 RID: 17669 RVA: 0x001F148A File Offset: 0x001EF68A
		[O_Oo00Oo000O0(6.0)]
		[MergableProperty(false)]
		[Category("列表项目")]
		[Description("下拉列表来自于数据表时，可用此属性设置过滤条件！")]
		[Editor(typeof(O0O00), typeof(UITypeEditor))]
		[DisplayName("过滤条件")]
		public string DataFilter
		{
			get
			{
				return this.o._o__0o0OOoo_.;
			}
			set
			{
				this.o._o__0o0OOoo_. = value;
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x001F1493 File Offset: 0x001EF693
		// (set) Token: 0x06004507 RID: 17671 RVA: 0x001F149B File Offset: 0x001EF69B
		[O_Oo00Oo000O0(7.0)]
		[Description("是否分多列显示项目。")]
		[DefaultValue(false)]
		[MergableProperty(true)]
		[DisplayName("多列显示")]
		[Category("列表项目")]
		public bool MultiColumn
		{
			get
			{
				return this.o.0o.;
			}
			set
			{
				this.o.0o. = value;
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06004508 RID: 17672 RVA: 0x001F14A4 File Offset: 0x001EF6A4
		// (set) Token: 0x06004509 RID: 17673 RVA: 0x001F14AC File Offset: 0x001EF6AC
		[O_Oo00Oo000O0(8.0)]
		[DefaultValue(0)]
		[DisplayName("每列宽度")]
		[Category("列表项目")]
		[MergableProperty(true)]
		[Description("设置多列显示时，各列的宽度。")]
		public int ColumnWidth
		{
			get
			{
				return this.O_.o_.;
			}
			set
			{
				this.O_.o_. = value;
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x0600450A RID: 17674 RVA: 0x001F14B5 File Offset: 0x001EF6B5
		// (set) Token: 0x0600450B RID: 17675 RVA: 0x001F14BD File Offset: 0x001EF6BD
		[O_Oo00Oo000O0(10.0)]
		[Description("指定下拉列表的宽度，设为0使用默认宽度，最小宽度为60")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("下拉宽度")]
		[Category("列表项目")]
		public int DropDownWidth
		{
			get
			{
				return this.oOo00_._oo__.;
			}
			set
			{
				if (value != 0)
				{
					value = Math.Max(60, value);
				}
				this.oOo00_._oo__. = value;
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x0600450C RID: 17676 RVA: 0x001F14D3 File Offset: 0x001EF6D3
		// (set) Token: 0x0600450D RID: 17677 RVA: 0x001F14DB File Offset: 0x001EF6DB
		[Description("指定下拉列表的高度，设为0使用默认高度，最小高度为28")]
		[O_Oo00Oo000O0(11.0)]
		[DefaultValue(0)]
		[Category("列表项目")]
		[DisplayName("下拉高度")]
		[MergableProperty(true)]
		public int DropDownHeight
		{
			get
			{
				return this.O.oo_o00o__.;
			}
			set
			{
				if (value != 0)
				{
					value = Math.Max(28, value);
				}
				this.O.oo_o00o__. = value;
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x0600450E RID: 17678 RVA: 0x001F14F1 File Offset: 0x001EF6F1
		// (set) Token: 0x0600450F RID: 17679 RVA: 0x001F14F9 File Offset: 0x001EF6F9
		[Description("每次最多显示的下拉项目数，超出范围的项目需要滚动才能显示")]
		[MergableProperty(true)]
		[DefaultValue(11)]
		[DisplayName("最多显示项目数")]
		[O_Oo00Oo000O0(12.0)]
		[Category("列表项目")]
		public int MaxDropDownItems
		{
			get
			{
				return this.o0__Oo.0__.;
			}
			set
			{
				value = Math.Max(1, value);
				this.o0__Oo.0__. = value;
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06004510 RID: 17680 RVA: 0x001F150B File Offset: 0x001EF70B
		// (set) Token: 0x06004511 RID: 17681 RVA: 0x001F1513 File Offset: 0x001EF713
		[Category("列表项目")]
		[DefaultValue(6)]
		[O_Oo00Oo000O0(13.0)]
		[Description("列表项目间距，单位为像素")]
		[MergableProperty(true)]
		[DisplayName("项目间距")]
		public int ItemSpacing
		{
			get
			{
				return this.O_OO.O0o000o0O.;
			}
			set
			{
				this.O_OO.O0o000o0O. = value;
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06004512 RID: 17682 RVA: 0x001F151C File Offset: 0x001EF71C
		// (set) Token: 0x06004513 RID: 17683 RVA: 0x001F1524 File Offset: 0x001EF724
		[O_Oo00Oo000O0(2.0)]
		[Category("输入控制")]
		[MergableProperty(true)]
		[DisplayName("输入掩码")]
		public string EditMask
		{
			get
			{
				return this.o00__O.0.;
			}
			set
			{
				this.o00__O.0. = value;
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06004514 RID: 17684 RVA: 0x001F152D File Offset: 0x001EF72D
		// (set) Token: 0x06004515 RID: 17685 RVA: 0x001F1535 File Offset: 0x001EF735
		[DisplayName("格式符号")]
		[O_Oo00Oo000O0(2.1)]
		[MergableProperty(true)]
		[Category("输入控制")]
		public string FormatString
		{
			get
			{
				return this.oOo00_._oo__.;
			}
			set
			{
				this.oOo00_._oo__. = value;
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06004516 RID: 17686 RVA: 0x001F153E File Offset: 0x001EF73E
		// (set) Token: 0x06004517 RID: 17687 RVA: 0x001F1546 File Offset: 0x001EF746
		[MergableProperty(true)]
		[DefaultValue(0)]
		[Category("输入控制")]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("中文输入")]
		public BooleanEnum ImeMode
		{
			get
			{
				return this.oOo00_._oo__.;
			}
			set
			{
				this.oOo00_._oo__. = value;
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06004518 RID: 17688 RVA: 0x001F154F File Offset: 0x001EF74F
		// (set) Token: 0x06004519 RID: 17689 RVA: 0x001F155C File Offset: 0x001EF75C
		[DefaultValue(32767)]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("最大长度")]
		[Category("输入控制")]
		[Description("允许用户输入的最大字符数。")]
		[MergableProperty(true)]
		public int MaxLength
		{
			get
			{
				return this.oo.O0o0o..MaxLength;
			}
			set
			{
				this.oo.O0o0o..MaxLength = value;
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x0600451A RID: 17690 RVA: 0x001F156A File Offset: 0x001EF76A
		// (set) Token: 0x0600451B RID: 17691 RVA: 0x001F1572 File Offset: 0x001EF772
		[O_Oo00Oo000O0(8.0)]
		[Category("输入控制")]
		[DefaultValue(false)]
		[MergableProperty(true)]
		[DisplayName("删除前空格")]
		public bool TrimStart
		{
			get
			{
				return this.o.0o00OOO_oO0o.;
			}
			set
			{
				this.o.0o00OOO_oO0o. = value;
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x0600451C RID: 17692 RVA: 0x001F157B File Offset: 0x001EF77B
		// (set) Token: 0x0600451D RID: 17693 RVA: 0x001F1583 File Offset: 0x001EF783
		[O_Oo00Oo000O0(9.0)]
		[DefaultValue(true)]
		[MergableProperty(true)]
		[DisplayName("删除尾空格")]
		[Category("输入控制")]
		public bool TrimEnd
		{
			get
			{
				return this.o_00o.00O0o_0.;
			}
			set
			{
				this.o_00o.00O0o_0. = value;
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x0600451E RID: 17694 RVA: 0x001F158C File Offset: 0x001EF78C
		// (set) Token: 0x0600451F RID: 17695 RVA: 0x001F1599 File Offset: 0x001EF799
		[O_Oo00Oo000O0(10.0)]
		[Description("否在字符键入时修改其大小写格式。")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("大小写转换")]
		[Category("输入控制")]
		public CharacterCasing CharacterCasing
		{
			get
			{
				return this.oo.O0o0o..CharacterCasing;
			}
			set
			{
				this.oo.O0o0o..CharacterCasing = value;
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06004520 RID: 17696 RVA: 0x001F15A7 File Offset: 0x001EF7A7
		// (set) Token: 0x06004521 RID: 17697 RVA: 0x001F15B4 File Offset: 0x001EF7B4
		[DisplayName("初始光标位置")]
		[O_Oo00Oo000O0(11.0)]
		[Category("输入控制")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		public InitialSelectionEnum InitialSelection
		{
			get
			{
				return this.oo.O0o0o..InitialSelection;
			}
			set
			{
				this.oo.O0o0o..InitialSelection = value;
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06004522 RID: 17698 RVA: 0x001F15C2 File Offset: 0x001EF7C2
		// (set) Token: 0x06004523 RID: 17699 RVA: 0x001F15CA File Offset: 0x001EF7CA
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
				return this.O00.000Oo00.;
			}
			set
			{
				this.O00.000Oo00. = value;
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06004524 RID: 17700 RVA: 0x001F15D3 File Offset: 0x001EF7D3
		// (set) Token: 0x06004525 RID: 17701 RVA: 0x001F15DB File Offset: 0x001EF7DB
		[oO0oooo("0769")]
		[Description("值改变后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.2)]
		public EventString ValueChanged
		{
			get
			{
				return this.o.0o00OOO_oO0o.;
			}
			set
			{
				this.o.0o00OOO_oO0o. = value;
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06004526 RID: 17702 RVA: 0x001F15E4 File Offset: 0x001EF7E4
		// (set) Token: 0x06004527 RID: 17703 RVA: 0x001F15EC File Offset: 0x001EF7EC
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0937")]
		[Category("事件")]
		[Description("从下拉列表中选择不同项目后执行。")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.3)]
		public EventString SelectedIndexChanged
		{
			get
			{
				return this.o.0OOO_.;
			}
			set
			{
				this.o.0OOO_. = value;
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06004528 RID: 17704 RVA: 0x001F15F5 File Offset: 0x001EF7F5
		// (set) Token: 0x06004529 RID: 17705 RVA: 0x001F15FD File Offset: 0x001EF7FD
		[Category("事件")]
		[Description("格式化列表项目显示值的时候执行！")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0938")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.4)]
		public EventString ListItemFormat
		{
			get
			{
				return this.O.oo_o00o__.;
			}
			set
			{
				this.O.oo_o00o__. = value;
			}
		}

		// Token: 0x04001C00 RID: 7168
		private C1DropDownControl <<EMPTY_NAME>>;

		// Token: 0x04001C01 RID: 7169
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C02 RID: 7170
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C03 RID: 7171
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001C04 RID: 7172
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C05 RID: 7173
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C06 RID: 7174
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C07 RID: 7175
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C08 RID: 7176
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C09 RID: 7177
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C0A RID: 7178
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C0B RID: 7179
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C0C RID: 7180
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C0D RID: 7181
		private int <<EMPTY_NAME>>;

		// Token: 0x04001C0E RID: 7182
		private int <<EMPTY_NAME>>;

		// Token: 0x04001C0F RID: 7183
		private int <<EMPTY_NAME>>;

		// Token: 0x04001C10 RID: 7184
		private int <<EMPTY_NAME>>;

		// Token: 0x04001C11 RID: 7185
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C12 RID: 7186
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C13 RID: 7187
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C14 RID: 7188
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C15 RID: 7189
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C16 RID: 7190
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001C17 RID: 7191
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C18 RID: 7192
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C19 RID: 7193
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C1A RID: 7194
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C1B RID: 7195
		private int <<EMPTY_NAME>>;
	}
}
