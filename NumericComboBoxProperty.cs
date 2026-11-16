using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200041B RID: 1051
	internal class NumericComboBoxProperty : ControlPropertyBase
	{
		// Token: 0x06004691 RID: 18065 RVA: 0x001F2CB7 File Offset: 0x001F0EB7
		public NumericComboBoxProperty(ControlHolder A_0) : base(A_0)
		{
			this.o0.OOOo. = (C1DropDownControl)A_0.ChildControl;
			this.o0.OOOo..VerticalAlign = VerticalAlignEnum.Middle;
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06004692 RID: 18066 RVA: 0x001F2CDD File Offset: 0x001F0EDD
		// (set) Token: 0x06004693 RID: 18067 RVA: 0x001F2CE5 File Offset: 0x001F0EE5
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(false)]
		[DisplayName("名称")]
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
					this.o0.OOOo..Text = value;
				}
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06004694 RID: 18068 RVA: 0x001F2D0D File Offset: 0x001F0F0D
		// (set) Token: 0x06004695 RID: 18069 RVA: 0x001F2D18 File Offset: 0x001F0F18
		[MergableProperty(true)]
		[Category("基本")]
		[DisplayName("初始值")]
		[O_Oo00Oo000O0(2.2)]
		public string Value
		{
			get
			{
				return this.oo_._o_0_OO_00.;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0)
				{
					this.oo_._o_0_OO_00. = "";
					return;
				}
				decimal num = 0m;
				if (decimal.TryParse(value, out num))
				{
					this.oo_._o_0_OO_00. = value;
				}
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06004696 RID: 18070 RVA: 0x001F2D58 File Offset: 0x001F0F58
		// (set) Token: 0x06004697 RID: 18071 RVA: 0x001F2D60 File Offset: 0x001F0F60
		[DisplayName("绑定到")]
		[O_Oo00Oo000O0(2.1)]
		[Category("基本")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[MergableProperty(false)]
		public string BindingField
		{
			get
			{
				return this.OO__0o_.0.;
			}
			set
			{
				this.OO__0o_.0. = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.o0.OOOo..Text = value;
					return;
				}
				this.o0.OOOo..Text = this.Name;
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06004698 RID: 18072 RVA: 0x001F2D96 File Offset: 0x001F0F96
		// (set) Token: 0x06004699 RID: 18073 RVA: 0x001F2D9E File Offset: 0x001F0F9E
		[DisplayName("只读")]
		[Description("禁止用户修改。")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.3)]
		[Category("基本")]
		[DefaultValue(0)]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.o0.OOOo.;
			}
			set
			{
				this.o0.OOOo. = value;
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x0600469A RID: 18074 RVA: 0x001F2DA8 File Offset: 0x001F0FA8
		// (set) Token: 0x0600469B RID: 18075 RVA: 0x001F2DB6 File Offset: 0x001F0FB6
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

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x0600469C RID: 18076 RVA: 0x001F2DB8 File Offset: 0x001F0FB8
		// (set) Token: 0x0600469D RID: 18077 RVA: 0x001F2DCA File Offset: 0x001F0FCA
		[TypeConverter(typeof(o00))]
		[DefaultValue("(default)")]
		[O_Oo00Oo000O0(0.0)]
		[DisplayName("样式")]
		[Category("外观")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.o0.OOOo.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.o0.OOOo.
				});
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x0600469E RID: 18078 RVA: 0x001F2DE6 File Offset: 0x001F0FE6
		// (set) Token: 0x0600469F RID: 18079 RVA: 0x001F2DF3 File Offset: 0x001F0FF3
		[O_Oo00Oo000O0(0.2)]
		[DefaultValue(2)]
		[MergableProperty(true)]
		[DisplayName("边框样式")]
		[Category("外观")]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.o0.OOOo..BorderStyle;
			}
			set
			{
				this.o0.OOOo..BorderStyle = value;
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x060046A0 RID: 18080 RVA: 0x001F2E01 File Offset: 0x001F1001
		// (set) Token: 0x060046A1 RID: 18081 RVA: 0x001F2E0E File Offset: 0x001F100E
		[O_Oo00Oo000O0(0.41)]
		[DisplayName("边框颜色")]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(-10197916)]
		public Color BorderColor
		{
			get
			{
				return this.o0.OOOo..BorderColor;
			}
			set
			{
				this.o0.OOOo..BorderColor = value;
				if (this.o0.OOOo..BorderStyle != BorderStyle.FixedSingle)
				{
					this.o0.OOOo..BorderStyle = BorderStyle.FixedSingle;
				}
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x001F2E36 File Offset: 0x001F1036
		// (set) Token: 0x060046A3 RID: 18083 RVA: 0x001F2E43 File Offset: 0x001F1043
		[Category("外观")]
		[DisplayName("文本位置")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.0)]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.o0.OOOo..TextAlign;
			}
			set
			{
				this.o0.OOOo..TextAlign = value;
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x060046A4 RID: 18084 RVA: 0x001F2E51 File Offset: 0x001F1051
		// (set) Token: 0x060046A5 RID: 18085 RVA: 0x001F2E59 File Offset: 0x001F1059
		[DisplayName("格式符号")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.1)]
		[Category("输入控制")]
		public string FormatString
		{
			get
			{
				return this.o0.OOOo.;
			}
			set
			{
				this.o0.OOOo. = value;
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x060046A6 RID: 18086 RVA: 0x001F2E62 File Offset: 0x001F1062
		// (set) Token: 0x060046A7 RID: 18087 RVA: 0x001F2E6F File Offset: 0x001F106F
		[Category("输入控制")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(true)]
		[DisplayName("微调按钮")]
		public bool ShowUpDownButtons
		{
			get
			{
				return this.o0.OOOo..ShowUpDownButtons;
			}
			set
			{
				this.o0.OOOo..ShowUpDownButtons = value;
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x001F2E7D File Offset: 0x001F107D
		// (set) Token: 0x060046A9 RID: 18089 RVA: 0x001F2E8A File Offset: 0x001F108A
		[DefaultValue(true)]
		[DisplayName("下拉按钮")]
		[Category("输入控制")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.0)]
		public bool ShowDropDownButton
		{
			get
			{
				return this.o0.OOOo..ShowDropDownButton;
			}
			set
			{
				this.o0.OOOo..ShowDropDownButton = value;
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x060046AA RID: 18090 RVA: 0x001F2E98 File Offset: 0x001F1098
		// (set) Token: 0x060046AB RID: 18091 RVA: 0x001F2EA0 File Offset: 0x001F10A0
		[Category("输入控制")]
		[DisplayName("微调增量")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(4.0)]
		[DefaultValue(1)]
		[Description("单击微调按钮时，增加或减少的值。")]
		public int Increment
		{
			get
			{
				return this.o0.OOOo.;
			}
			set
			{
				this.o0.OOOo. = value;
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x060046AC RID: 18092 RVA: 0x001F2EA9 File Offset: 0x001F10A9
		// (set) Token: 0x060046AD RID: 18093 RVA: 0x001F2EB1 File Offset: 0x001F10B1
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0768")]
		[Description("文本改变后执行")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.1)]
		public EventString TextChanged
		{
			get
			{
				return this.o0.OOOo.;
			}
			set
			{
				this.o0.OOOo. = value;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x001F2EBA File Offset: 0x001F10BA
		// (set) Token: 0x060046AF RID: 18095 RVA: 0x001F2EC2 File Offset: 0x001F10C2
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O_Oo00Oo000O0(0.2)]
		[Description("值改变后执行")]
		[oO0oooo("0769")]
		[O0O0oOO00_0OO(true)]
		public EventString ValueChanged
		{
			get
			{
				return this.OO__0o_.0.;
			}
			set
			{
				this.OO__0o_.0. = value;
			}
		}

		// Token: 0x04001C8B RID: 7307
		private C1DropDownControl <<EMPTY_NAME>>;

		// Token: 0x04001C8C RID: 7308
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001C8D RID: 7309
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C8E RID: 7310
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C8F RID: 7311
		private int <<EMPTY_NAME>>;

		// Token: 0x04001C90 RID: 7312
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C91 RID: 7313
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C92 RID: 7314
		private EventString <<EMPTY_NAME>>;
	}
}
