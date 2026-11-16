using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200040C RID: 1036
	internal class CheckedComboBoxProperty : ControlPropertyBase
	{
		// Token: 0x06004476 RID: 17526 RVA: 0x001F09B8 File Offset: 0x001EEBB8
		public CheckedComboBoxProperty(ControlHolder A_0) : base(A_0)
		{
			this.O_oO0._o_0. = true;
			this.o0Oo._0O. = ',';
			this.ooo.oo. = 11;
			this.O.0000_. = true;
			this.o0_oo._O_O. = true;
			this.o0Oo._0O. = (C1DropDownControl)A_0.ChildControl;
			this.o0Oo._0O..VerticalAlign = VerticalAlignEnum.Middle;
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x001F0A0E File Offset: 0x001EEC0E
		// (set) Token: 0x06004478 RID: 17528 RVA: 0x001F0A16 File Offset: 0x001EEC16
		[Category("基本")]
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(false)]
		[DisplayName("名称")]
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
					this.o0Oo._0O..Text = value;
				}
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06004479 RID: 17529 RVA: 0x001F0A3E File Offset: 0x001EEC3E
		// (set) Token: 0x0600447A RID: 17530 RVA: 0x001F0A46 File Offset: 0x001EEC46
		[MergableProperty(true)]
		[DisplayName("初始值")]
		[O_Oo00Oo000O0(2.2)]
		[Category("基本")]
		public string Value
		{
			get
			{
				return this.oOo00_ooo._.;
			}
			set
			{
				this.oOo00_ooo._. = value;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x0600447B RID: 17531 RVA: 0x001F0A4F File Offset: 0x001EEC4F
		// (set) Token: 0x0600447C RID: 17532 RVA: 0x001F0A57 File Offset: 0x001EEC57
		[MergableProperty(false)]
		[Category("基本")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[DisplayName("绑定到")]
		[O_Oo00Oo000O0(2.1)]
		public string BindingField
		{
			get
			{
				return this.O_oO0._o_0.;
			}
			set
			{
				this.O_oO0._o_0. = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.o0Oo._0O..Text = value;
					return;
				}
				this.o0Oo._0O..Text = this.Name;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x001F0A8D File Offset: 0x001EEC8D
		// (set) Token: 0x0600447E RID: 17534 RVA: 0x001F0A95 File Offset: 0x001EEC95
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.3)]
		[DisplayName("只读")]
		[Category("基本")]
		[Description("禁止用户修改。")]
		[DefaultValue(0)]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.o0Oo._0O.;
			}
			set
			{
				this.o0Oo._0O. = value;
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x0600447F RID: 17535 RVA: 0x001F0AA0 File Offset: 0x001EECA0
		// (set) Token: 0x06004480 RID: 17536 RVA: 0x001F0AAE File Offset: 0x001EECAE
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

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06004481 RID: 17537 RVA: 0x001F0AB0 File Offset: 0x001EECB0
		// (set) Token: 0x06004482 RID: 17538 RVA: 0x001F0AC2 File Offset: 0x001EECC2
		[DisplayName("样式")]
		[DefaultValue("(default)")]
		[TypeConverter(typeof(o00))]
		[O_Oo00Oo000O0(0.0)]
		[Category("外观")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.o0Oo._0O.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.o0Oo._0O.
				});
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06004483 RID: 17539 RVA: 0x001F0ADE File Offset: 0x001EECDE
		// (set) Token: 0x06004484 RID: 17540 RVA: 0x001F0AEB File Offset: 0x001EECEB
		[DisplayName("文本位置")]
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(0)]
		[Category("外观")]
		[MergableProperty(true)]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.o0Oo._0O..TextAlign;
			}
			set
			{
				this.o0Oo._0O..TextAlign = value;
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06004485 RID: 17541 RVA: 0x001F0AF9 File Offset: 0x001EECF9
		// (set) Token: 0x06004486 RID: 17542 RVA: 0x001F0B06 File Offset: 0x001EED06
		[DefaultValue(2)]
		[O_Oo00Oo000O0(0.4)]
		[Category("外观")]
		[MergableProperty(true)]
		[DisplayName("边框样式")]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.o0Oo._0O..BorderStyle;
			}
			set
			{
				this.o0Oo._0O..BorderStyle = value;
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x001F0B14 File Offset: 0x001EED14
		// (set) Token: 0x06004488 RID: 17544 RVA: 0x001F0B21 File Offset: 0x001EED21
		[DisplayName("边框颜色")]
		[Category("外观")]
		[O_Oo00Oo000O0(0.41)]
		[MergableProperty(true)]
		[DefaultValue(-10197916)]
		public Color BorderColor
		{
			get
			{
				return this.o0Oo._0O..BorderColor;
			}
			set
			{
				this.o0Oo._0O..BorderColor = value;
				if (this.o0Oo._0O..BorderStyle != BorderStyle.FixedSingle)
				{
					this.o0Oo._0O..BorderStyle = BorderStyle.FixedSingle;
				}
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x001F0B49 File Offset: 0x001EED49
		// (set) Token: 0x0600448A RID: 17546 RVA: 0x001F0B51 File Offset: 0x001EED51
		[Editor(typeof(ooO0o0_oO0_0), typeof(UITypeEditor))]
		[MergableProperty(false)]
		[Category("列表项目")]
		[DisplayName("自定义项目")]
		[O_Oo00Oo000O0(1.0)]
		public string ComboList
		{
			get
			{
				return this.oO0.O.;
			}
			set
			{
				this.oO0.O. = value;
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x001F0B5A File Offset: 0x001EED5A
		// (set) Token: 0x0600448C RID: 17548 RVA: 0x001F0B62 File Offset: 0x001EED62
		[TypeConverter(typeof(oo0OOO_0__))]
		[DisplayName("显示列")]
		[O_Oo00Oo000O0(3.0)]
		[Category("列表项目")]
		[MergableProperty(false)]
		public string DisplayMember
		{
			get
			{
				return this.OOO0o.oO000.;
			}
			set
			{
				this.OOO0o.oO000. = value;
				if (Operators.CompareString(this.O.00oOoooo., "", true) == 0)
				{
					this.O.00oOoooo. = value;
				}
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x001F0B85 File Offset: 0x001EED85
		// (set) Token: 0x0600448E RID: 17550 RVA: 0x001F0B8D File Offset: 0x001EED8D
		[MergableProperty(false)]
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("取值列")]
		[Category("列表项目")]
		[TypeConverter(typeof(oo0OOO_0__))]
		public string ValueMember
		{
			get
			{
				return this.O.00oOoooo.;
			}
			set
			{
				this.O.00oOoooo. = value;
				if (Operators.CompareString(this.OOO0o.oO000., "", true) == 0)
				{
					this.OOO0o.oO000. = value;
				}
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x0600448F RID: 17551 RVA: 0x001F0BB0 File Offset: 0x001EEDB0
		// (set) Token: 0x06004490 RID: 17552 RVA: 0x001F0BB8 File Offset: 0x001EEDB8
		[O_Oo00Oo000O0(2.0)]
		[Category("列表项目")]
		[Description("候选项目来源表")]
		[MergableProperty(false)]
		[TypeConverter(typeof(OoO_O0_OO0))]
		[DisplayName("数据表")]
		public string DataSource
		{
			get
			{
				return this.OO.0O0.;
			}
			set
			{
				this.OO.0O0. = value;
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

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x001F0C76 File Offset: 0x001EEE76
		// (set) Token: 0x06004492 RID: 17554 RVA: 0x001F0C7E File Offset: 0x001EEE7E
		[Category("列表项目")]
		[O_Oo00Oo000O0(5.0)]
		[Description("下拉列表来自于数据表时，可用此属性设置过滤条件！")]
		[Editor(typeof(O0O00), typeof(UITypeEditor))]
		[MergableProperty(false)]
		[DisplayName("过滤条件")]
		public string DataFilter
		{
			get
			{
				return this.O0o_o0__._.;
			}
			set
			{
				this.O0o_o0__._. = value;
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x001F0C87 File Offset: 0x001EEE87
		// (set) Token: 0x06004494 RID: 17556 RVA: 0x001F0C8F File Offset: 0x001EEE8F
		[Description("用于分隔值的符号")]
		[MergableProperty(true)]
		[DefaultValue(',')]
		[Category("列表项目")]
		[O_Oo00Oo000O0(6.0)]
		[DisplayName("分隔符")]
		public char Separator
		{
			get
			{
				return this.o0Oo._0O.;
			}
			set
			{
				if (Operators.CompareString(Conversions.ToString(value), "", true) != 0)
				{
					this.o0Oo._0O. = value;
				}
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x001F0CAB File Offset: 0x001EEEAB
		// (set) Token: 0x06004496 RID: 17558 RVA: 0x001F0CB3 File Offset: 0x001EEEB3
		[DefaultValue(false)]
		[O_Oo00Oo000O0(7.0)]
		[MergableProperty(true)]
		[DisplayName("多列显示")]
		[Category("列表项目")]
		[Description("是否分多列显示项目。")]
		public bool MultiColumn
		{
			get
			{
				return this.ooOOo.0O0O0o0.;
			}
			set
			{
				this.ooOOo.0O0O0o0. = value;
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x001F0CBC File Offset: 0x001EEEBC
		// (set) Token: 0x06004498 RID: 17560 RVA: 0x001F0CC4 File Offset: 0x001EEEC4
		[O_Oo00Oo000O0(8.0)]
		[DisplayName("每列宽度")]
		[Category("列表项目")]
		[Description("设置多列显示时，各列的宽度。")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		public int ColumnWidth
		{
			get
			{
				return this.O_oO0._o_0.;
			}
			set
			{
				this.O_oO0._o_0. = value;
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06004499 RID: 17561 RVA: 0x001F0CCD File Offset: 0x001EEECD
		// (set) Token: 0x0600449A RID: 17562 RVA: 0x001F0CD5 File Offset: 0x001EEED5
		[O_Oo00Oo000O0(9.0)]
		[DefaultValue(0)]
		[Description("指定下拉列表的宽度，设为0使用默认宽度，最小宽度为130")]
		[DisplayName("下拉宽度")]
		[Category("列表项目")]
		[MergableProperty(true)]
		public int DropDownWidth
		{
			get
			{
				return this.ooOOo.0O0O0o0.;
			}
			set
			{
				if (value != 0)
				{
					value = Math.Max(130, value);
				}
				this.ooOOo.0O0O0o0. = value;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x001F0CEE File Offset: 0x001EEEEE
		// (set) Token: 0x0600449C RID: 17564 RVA: 0x001F0CF6 File Offset: 0x001EEEF6
		[MergableProperty(true)]
		[Category("列表项目")]
		[DisplayName("下拉高度")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(10.0)]
		[Description("指定下拉列表的高度，设为0使用默认高度，最小高度为52，仅在多列显示的时候有效")]
		public int DropDownHeight
		{
			get
			{
				return this.OOO0_o0_O._0o.;
			}
			set
			{
				if (value != 0)
				{
					value = Math.Max(52, value);
				}
				this.OOO0_o0_O._0o. = value;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x0600449D RID: 17565 RVA: 0x001F0D0C File Offset: 0x001EEF0C
		// (set) Token: 0x0600449E RID: 17566 RVA: 0x001F0D14 File Offset: 0x001EEF14
		[DisplayName("最多显示项目数")]
		[O_Oo00Oo000O0(11.0)]
		[Category("列表项目")]
		[Description("每次最多显示的下拉项目数，超出范围的项目需要滚动才能显示，仅在单列显示的时候有效")]
		[MergableProperty(true)]
		[DefaultValue(11)]
		public int MaxDropDownItems
		{
			get
			{
				return this.ooo.oo.;
			}
			set
			{
				value = Math.Max(1, value);
				this.ooo.oo. = value;
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x0600449F RID: 17567 RVA: 0x001F0D26 File Offset: 0x001EEF26
		// (set) Token: 0x060044A0 RID: 17568 RVA: 0x001F0D2E File Offset: 0x001EEF2E
		[O_Oo00Oo000O0(12.0)]
		[Category("列表项目")]
		[Description("允许用户直接输入不在列表项目中的值")]
		[DefaultValue(true)]
		[MergableProperty(true)]
		[DisplayName("允许直接输入")]
		public bool AllowEditValue
		{
			get
			{
				return this.O_oO0._o_0.;
			}
			set
			{
				this.O_oO0._o_0. = value;
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x001F0D37 File Offset: 0x001EEF37
		// (set) Token: 0x060044A2 RID: 17570 RVA: 0x001F0D3F File Offset: 0x001EEF3F
		[Description("复选框是否在首次单击某项时切换。")]
		[O_Oo00Oo000O0(13.0)]
		[DefaultValue(true)]
		[MergableProperty(true)]
		[DisplayName("自动选中")]
		[Category("列表项目")]
		public bool CheckOnClick
		{
			get
			{
				return this.O.0000_.;
			}
			set
			{
				this.O.0000_. = value;
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x001F0D48 File Offset: 0x001EEF48
		// (set) Token: 0x060044A4 RID: 17572 RVA: 0x001F0D50 File Offset: 0x001EEF50
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("输入掩码")]
		[Category("输入控制")]
		[MergableProperty(true)]
		public string EditMask
		{
			get
			{
				return this.OOOo0oOOO_o.O.;
			}
			set
			{
				this.OOOo0oOOO_o.O. = value;
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x001F0D59 File Offset: 0x001EEF59
		// (set) Token: 0x060044A6 RID: 17574 RVA: 0x001F0D61 File Offset: 0x001EEF61
		[O_Oo00Oo000O0(2.1)]
		[Category("输入控制")]
		[MergableProperty(true)]
		[DisplayName("格式符号")]
		public string FormatString
		{
			get
			{
				return this.ooOOo.0O0O0o0.;
			}
			set
			{
				this.ooOOo.0O0O0o0. = value;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x060044A7 RID: 17575 RVA: 0x001F0D6A File Offset: 0x001EEF6A
		// (set) Token: 0x060044A8 RID: 17576 RVA: 0x001F0D72 File Offset: 0x001EEF72
		[Category("输入控制")]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("中文输入")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		public BooleanEnum ImeMode
		{
			get
			{
				return this.ooOOo.0O0O0o0.;
			}
			set
			{
				this.ooOOo.0O0O0o0. = value;
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x060044A9 RID: 17577 RVA: 0x001F0D7B File Offset: 0x001EEF7B
		// (set) Token: 0x060044AA RID: 17578 RVA: 0x001F0D88 File Offset: 0x001EEF88
		[O_Oo00Oo000O0(5.0)]
		[Description("允许用户输入的最大字符数。")]
		[MergableProperty(true)]
		[DefaultValue(32767)]
		[DisplayName("最大长度")]
		[Category("输入控制")]
		public int MaxLength
		{
			get
			{
				return this.o0Oo._0O..MaxLength;
			}
			set
			{
				this.o0Oo._0O..MaxLength = value;
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x060044AB RID: 17579 RVA: 0x001F0D96 File Offset: 0x001EEF96
		// (set) Token: 0x060044AC RID: 17580 RVA: 0x001F0D9E File Offset: 0x001EEF9E
		[O_Oo00Oo000O0(8.0)]
		[MergableProperty(true)]
		[DisplayName("删除前空格")]
		[Category("输入控制")]
		[DefaultValue(false)]
		public bool TrimStart
		{
			get
			{
				return this.O0.0.;
			}
			set
			{
				this.O0.0. = value;
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x060044AD RID: 17581 RVA: 0x001F0DA7 File Offset: 0x001EEFA7
		// (set) Token: 0x060044AE RID: 17582 RVA: 0x001F0DAF File Offset: 0x001EEFAF
		[Category("输入控制")]
		[DisplayName("删除尾空格")]
		[O_Oo00Oo000O0(9.0)]
		[DefaultValue(true)]
		[MergableProperty(true)]
		public bool TrimEnd
		{
			get
			{
				return this.o0_oo._O_O.;
			}
			set
			{
				this.o0_oo._O_O. = value;
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x060044AF RID: 17583 RVA: 0x001F0DB8 File Offset: 0x001EEFB8
		// (set) Token: 0x060044B0 RID: 17584 RVA: 0x001F0DC5 File Offset: 0x001EEFC5
		[DefaultValue(0)]
		[Category("输入控制")]
		[Description("否在字符键入时修改其大小写格式。")]
		[O_Oo00Oo000O0(10.0)]
		[DisplayName("大小写转换")]
		[MergableProperty(true)]
		public CharacterCasing CharacterCasing
		{
			get
			{
				return this.o0Oo._0O..CharacterCasing;
			}
			set
			{
				this.o0Oo._0O..CharacterCasing = value;
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x060044B1 RID: 17585 RVA: 0x001F0DD3 File Offset: 0x001EEFD3
		// (set) Token: 0x060044B2 RID: 17586 RVA: 0x001F0DE0 File Offset: 0x001EEFE0
		[O_Oo00Oo000O0(11.0)]
		[Category("输入控制")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("初始光标位置")]
		public InitialSelectionEnum InitialSelection
		{
			get
			{
				return this.o0Oo._0O..InitialSelection;
			}
			set
			{
				this.o0Oo._0O..InitialSelection = value;
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x060044B3 RID: 17587 RVA: 0x001F0DEE File Offset: 0x001EEFEE
		// (set) Token: 0x060044B4 RID: 17588 RVA: 0x001F0DF6 File Offset: 0x001EEFF6
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0937")]
		[Category("事件")]
		[Description("选择不同项目后执行。")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.1)]
		public EventString SelectedIndexChanged
		{
			get
			{
				return this.o0Oo._0O.;
			}
			set
			{
				this.o0Oo._0O. = value;
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x060044B5 RID: 17589 RVA: 0x001F0DFF File Offset: 0x001EEFFF
		// (set) Token: 0x060044B6 RID: 17590 RVA: 0x001F0E07 File Offset: 0x001EF007
		[oO0oooo("0768")]
		[Category("事件")]
		[Description("内容改变后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.3)]
		public EventString TextChanged
		{
			get
			{
				return this.OO_OO.Oo_o0.;
			}
			set
			{
				this.OO_OO.Oo_o0. = value;
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x060044B7 RID: 17591 RVA: 0x001F0E10 File Offset: 0x001EF010
		// (set) Token: 0x060044B8 RID: 17592 RVA: 0x001F0E18 File Offset: 0x001EF018
		[Description("格式化列表项目显示值的时候执行！")]
		[oO0oooo("0938")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.4)]
		public EventString ListItemFormat
		{
			get
			{
				return this.OOO0_o0_O._0o.;
			}
			set
			{
				this.OOO0_o0_O._0o. = value;
			}
		}

		// Token: 0x04001BD6 RID: 7126
		private C1DropDownControl <<EMPTY_NAME>>;

		// Token: 0x04001BD7 RID: 7127
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BD8 RID: 7128
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BD9 RID: 7129
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001BDA RID: 7130
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BDB RID: 7131
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001BDC RID: 7132
		private char <<EMPTY_NAME>>;

		// Token: 0x04001BDD RID: 7133
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BDE RID: 7134
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001BDF RID: 7135
		private int <<EMPTY_NAME>>;

		// Token: 0x04001BE0 RID: 7136
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BE1 RID: 7137
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BE2 RID: 7138
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BE3 RID: 7139
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BE4 RID: 7140
		private int <<EMPTY_NAME>>;

		// Token: 0x04001BE5 RID: 7141
		private int <<EMPTY_NAME>>;

		// Token: 0x04001BE6 RID: 7142
		private int <<EMPTY_NAME>>;

		// Token: 0x04001BE7 RID: 7143
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001BE8 RID: 7144
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001BE9 RID: 7145
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001BEA RID: 7146
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001BEB RID: 7147
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001BEC RID: 7148
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BED RID: 7149
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001BEE RID: 7150
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001BEF RID: 7151
		private bool <<EMPTY_NAME>>;
	}
}
