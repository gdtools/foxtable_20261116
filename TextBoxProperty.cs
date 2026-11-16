using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002C0 RID: 704
	internal class TextBoxProperty : ControlPropertyBase
	{
		// Token: 0x0600265D RID: 9821 RVA: 0x0011AAA3 File Offset: 0x00118CA3
		public TextBoxProperty(ControlHolder A_0) : base(A_0)
		{
			this.o.00O0o_0o0. = true;
			this.oo0.O. = (C1TextBox)A_0.ChildControl;
			this.oo0.O..VerticalAlign = VerticalAlignEnum.Middle;
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x0011AAD0 File Offset: 0x00118CD0
		// (set) Token: 0x0600265F RID: 9823 RVA: 0x0011AAD8 File Offset: 0x00118CD8
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(false)]
		[Category("基本")]
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
					this.oo0.O..Text = value;
				}
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06002660 RID: 9824 RVA: 0x0011AB00 File Offset: 0x00118D00
		// (set) Token: 0x06002661 RID: 9825 RVA: 0x0011AB0D File Offset: 0x00118D0D
		[DisplayName("多行文本")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(6.0)]
		[Category("输入控制")]
		public bool MultiLine
		{
			get
			{
				return this.oo0.O..Multiline;
			}
			set
			{
				if (this.oo0.O..Multiline != value)
				{
					this.oo0.O..Multiline = value;
					if (value)
					{
						this.VeticalAlign = VerticalAlignEnum.Top;
					}
				}
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x0011AB33 File Offset: 0x00118D33
		// (set) Token: 0x06002663 RID: 9827 RVA: 0x0011AB3B File Offset: 0x00118D3B
		[Editor(typeof(O0_00_oo0oO_), typeof(UITypeEditor))]
		[Category("基本")]
		[O_Oo00Oo000O0(2.2)]
		[DisplayName("初始值")]
		[MergableProperty(true)]
		[DefaultValue("")]
		public string Value
		{
			get
			{
				return this.o0O__OO.oOo0O0.;
			}
			set
			{
				this.o0O__OO.oOo0O0. = value;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x0011AB44 File Offset: 0x00118D44
		// (set) Token: 0x06002665 RID: 9829 RVA: 0x0011AB4C File Offset: 0x00118D4C
		[MergableProperty(true)]
		[Category("基本")]
		[O_Oo00Oo000O0(2.1)]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[DisplayName("绑定到")]
		[DefaultValue("")]
		public string BindingField
		{
			get
			{
				return this.oOOo_o0o0O._.;
			}
			set
			{
				this.oOOo_o0o0O._. = value;
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.oo0.O..Text = value;
					return;
				}
				this.oo0.O..Text = this.Name;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x0011AB82 File Offset: 0x00118D82
		// (set) Token: 0x06002667 RID: 9831 RVA: 0x0011AB8A File Offset: 0x00118D8A
		[O_Oo00Oo000O0(2.3)]
		[Category("基本")]
		[Description("是否禁止用户修改。")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		[DisplayName("只读")]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.oOOo_o0o0O._.;
			}
			set
			{
				this.oOOo_o0o0O._. = value;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x0011AB94 File Offset: 0x00118D94
		// (set) Token: 0x06002669 RID: 9833 RVA: 0x0011ABA2 File Offset: 0x00118DA2
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

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x0011ABA4 File Offset: 0x00118DA4
		// (set) Token: 0x0600266B RID: 9835 RVA: 0x0011ABB6 File Offset: 0x00118DB6
		[Category("外观")]
		[TypeConverter(typeof(o00))]
		[O_Oo00Oo000O0(0.0)]
		[DisplayName("样式")]
		[DefaultValue("(default)")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.oo0.O.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.oo0.O.
				});
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x0011ABD2 File Offset: 0x00118DD2
		// (set) Token: 0x0600266D RID: 9837 RVA: 0x0011ABDF File Offset: 0x00118DDF
		[O_Oo00Oo000O0(1.1)]
		[DisplayName("水平对齐")]
		[Category("外观")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this.oo0.O..TextAlign;
			}
			set
			{
				this.oo0.O..TextAlign = value;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x0011ABED File Offset: 0x00118DED
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x0011ABFA File Offset: 0x00118DFA
		[DisplayName("垂直对齐")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.2)]
		[Category("外观")]
		[DefaultValue(0)]
		public VerticalAlignEnum VeticalAlign
		{
			get
			{
				return this.oo0.O..VerticalAlign;
			}
			set
			{
				this.oo0.O..VerticalAlign = value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002670 RID: 9840 RVA: 0x0011AC08 File Offset: 0x00118E08
		// (set) Token: 0x06002671 RID: 9841 RVA: 0x0011AC15 File Offset: 0x00118E15
		[Category("外观")]
		[O_Oo00Oo000O0(1.3)]
		[MergableProperty(true)]
		[DisplayName("滚动条")]
		public ScrollBars ScrollBars
		{
			get
			{
				return this.oo0.O..ScrollBars;
			}
			set
			{
				this.oo0.O..ScrollBars = value;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x0011AC23 File Offset: 0x00118E23
		// (set) Token: 0x06002673 RID: 9843 RVA: 0x0011AC30 File Offset: 0x00118E30
		[DisplayName("边框样式")]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(1)]
		[O_Oo00Oo000O0(0.4)]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.oo0.O..BorderStyle;
			}
			set
			{
				this.oo0.O..BorderStyle = value;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x0011AC3E File Offset: 0x00118E3E
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x0011AC4B File Offset: 0x00118E4B
		[MergableProperty(true)]
		[O_Oo00Oo000O0(0.41)]
		[DisplayName("边框颜色")]
		[DefaultValue(-10197916)]
		[Category("外观")]
		public Color BorderColor
		{
			get
			{
				return this.oo0.O..BorderColor;
			}
			set
			{
				this.oo0.O..BorderColor = value;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x0011AC59 File Offset: 0x00118E59
		// (set) Token: 0x06002677 RID: 9847 RVA: 0x0011AC66 File Offset: 0x00118E66
		[DisplayName("密码字符")]
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[Category("输入控制")]
		[Description("用于屏蔽输入内容的密码字符。")]
		public char PasswordChar
		{
			get
			{
				return this.oo0.O..PasswordChar;
			}
			set
			{
				this.oo0.O..PasswordChar = value;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x0011AC74 File Offset: 0x00118E74
		// (set) Token: 0x06002679 RID: 9849 RVA: 0x0011AC7C File Offset: 0x00118E7C
		[Category("输入控制")]
		[DisplayName("输入掩码")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.0)]
		public string EditMask
		{
			get
			{
				return this.o.o_OOO__.;
			}
			set
			{
				this.o.o_OOO__. = value;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x0011AC85 File Offset: 0x00118E85
		// (set) Token: 0x0600267B RID: 9851 RVA: 0x0011AC8D File Offset: 0x00118E8D
		[Category("输入控制")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.1)]
		[DisplayName("格式符号")]
		public string FormatString
		{
			get
			{
				return this.o.O0_O_.;
			}
			set
			{
				this.o.O0_O_. = value;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x0011AC96 File Offset: 0x00118E96
		// (set) Token: 0x0600267D RID: 9853 RVA: 0x0011AC9E File Offset: 0x00118E9E
		[Category("输入控制")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("中文输入")]
		[O_Oo00Oo000O0(3.0)]
		public BooleanEnum ImeMode
		{
			get
			{
				return this.o.00O0o_0o0.;
			}
			set
			{
				this.o.00O0o_0o0. = value;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x0011ACA7 File Offset: 0x00118EA7
		// (set) Token: 0x0600267F RID: 9855 RVA: 0x0011ACB4 File Offset: 0x00118EB4
		[DefaultValue(32767)]
		[Category("输入控制")]
		[Description("允许用户输入的最大字符数。")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("最大长度")]
		public int MaxLength
		{
			get
			{
				return this.oo0.O..MaxLength;
			}
			set
			{
				this.oo0.O..MaxLength = value;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x0011ACC2 File Offset: 0x00118EC2
		// (set) Token: 0x06002681 RID: 9857 RVA: 0x0011ACCF File Offset: 0x00118ECF
		[Category("输入控制")]
		[O_Oo00Oo000O0(7.0)]
		[DisplayName("自动换行")]
		[DefaultValue(true)]
		[MergableProperty(true)]
		public bool WordWrap
		{
			get
			{
				return this.oo0.O..WordWrap;
			}
			set
			{
				this.oo0.O..WordWrap = value;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x0011ACDD File Offset: 0x00118EDD
		// (set) Token: 0x06002683 RID: 9859 RVA: 0x0011ACE5 File Offset: 0x00118EE5
		[DisplayName("删除前空格")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(8.0)]
		[Category("输入控制")]
		[DefaultValue(false)]
		public bool TrimStart
		{
			get
			{
				return this.oo0.O.;
			}
			set
			{
				this.oo0.O. = value;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06002684 RID: 9860 RVA: 0x0011ACEE File Offset: 0x00118EEE
		// (set) Token: 0x06002685 RID: 9861 RVA: 0x0011ACF6 File Offset: 0x00118EF6
		[O_Oo00Oo000O0(9.0)]
		[DisplayName("删除尾空格")]
		[Category("输入控制")]
		[MergableProperty(true)]
		[DefaultValue(true)]
		public bool TrimEnd
		{
			get
			{
				return this.o.00O0o_0o0.;
			}
			set
			{
				this.o.00O0o_0o0. = value;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x0011ACFF File Offset: 0x00118EFF
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x0011AD0C File Offset: 0x00118F0C
		[Category("输入控制")]
		[O_Oo00Oo000O0(10.0)]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("大小写转换")]
		[Description("否在字符键入时修改其大小写格式。")]
		public CharacterCasing CharacterCasing
		{
			get
			{
				return this.oo0.O..CharacterCasing;
			}
			set
			{
				this.oo0.O..CharacterCasing = value;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x0011AD1A File Offset: 0x00118F1A
		// (set) Token: 0x06002689 RID: 9865 RVA: 0x0011AD27 File Offset: 0x00118F27
		[O_Oo00Oo000O0(11.0)]
		[DisplayName("初始光标位置")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[Category("输入控制")]
		public InitialSelectionEnum InitialSelection
		{
			get
			{
				return this.oo0.O..InitialSelection;
			}
			set
			{
				this.oo0.O..InitialSelection = value;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x0011AD35 File Offset: 0x00118F35
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x0011AD3D File Offset: 0x00118F3D
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0769")]
		[O_Oo00Oo000O0(0.1)]
		[Description("值改变后执行")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString ValueChanged
		{
			get
			{
				return this.o0O__OO.oOo0O0.;
			}
			set
			{
				this.o0O__OO.oOo0O0. = value;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x0011AD46 File Offset: 0x00118F46
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x0011AD4E File Offset: 0x00118F4E
		[Description("文本改变后执行")]
		[oO0oooo("0768")]
		[O_Oo00Oo000O0(0.2)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString TextChanged
		{
			get
			{
				return this.oOOo_o0o0O._.;
			}
			set
			{
				this.oOOo_o0o0O._. = value;
			}
		}

		// Token: 0x04000FE0 RID: 4064
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x04000FE1 RID: 4065
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000FE2 RID: 4066
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000FE3 RID: 4067
		private string <<EMPTY_NAME>>;

		// Token: 0x04000FE4 RID: 4068
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000FE5 RID: 4069
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000FE6 RID: 4070
		private string <<EMPTY_NAME>>;

		// Token: 0x04000FE7 RID: 4071
		private string <<EMPTY_NAME>>;

		// Token: 0x04000FE8 RID: 4072
		private string <<EMPTY_NAME>>;

		// Token: 0x04000FE9 RID: 4073
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000FEA RID: 4074
		private EventString <<EMPTY_NAME>>;
	}
}
