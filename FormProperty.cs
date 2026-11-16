using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000415 RID: 1045
	[OoO0___o("Form")]
	internal class FormProperty
	{
		// Token: 0x060045A1 RID: 17825 RVA: 0x001F1D6C File Offset: 0x001EFF6C
		public FormProperty(o\u3002\u3002\u3000\u3000\u3002 A_0)
		{
			this.o_00.OOO__o_OO. = ToolTipIcon.Info;
			this.OOo0OO00O0.0. = "提示";
			this.o.o0o. = false;
			this.O.OO00OoO0. = true;
			this.O.00_. = true;
			this.oOO00.oo_OoO. = true;
			this.O__._. = 1000;
			this.OOOoO_oo.O. = new PrintPageProperty();
			this.o_00.OOO__o_OO. = TabAlignment.Bottom;
			this.o0.0_0000OO. = "(default)";
			this.OO_0O0.O. = true;
			this.oO.o0o0000OO. = A_0;
			this.FormStyle = FormStyleEnum.停靠;
			this.DockArea = DockAreaEnum.右;
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x060045A2 RID: 17826 RVA: 0x001F1DF8 File Offset: 0x001EFFF8
		[Browsable(false)]
		public o\u3002\u3002\u3000\u3000\u3002 Form
		{
			get
			{
				return this.oO.o0o0000OO.;
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x001F1E00 File Offset: 0x001F0000
		[Browsable(false)]
		[OooO0(true)]
		public PrintPageProperty Page
		{
			get
			{
				return this.OOOoO_oo.O.;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x001F1E08 File Offset: 0x001F0008
		// (set) Token: 0x060045A5 RID: 17829 RVA: 0x001F1E19 File Offset: 0x001F0019
		[DefaultValue("")]
		[Browsable(false)]
		public string PageSetting
		{
			get
			{
				return o_O_o_oOoo__.OOOO_OO._oo.(this.Page, false, '\t', false);
			}
			set
			{
				o_O_o_oOoo__.OOOO_OO._oo.(this.Page, value, '\t');
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x060045A6 RID: 17830 RVA: 0x001F1E29 File Offset: 0x001F0029
		// (set) Token: 0x060045A7 RID: 17831 RVA: 0x001F1E31 File Offset: 0x001F0031
		[TypeConverter(typeof(OoO_O0_OO0))]
		[Category("基本")]
		[DisplayName("所有者表")]
		[OooO0(true)]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(1.0)]
		public string TablName
		{
			get
			{
				return this.o_00.OOO__o_OO.;
			}
			set
			{
				this.o_00.OOO__o_OO. = value;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x060045A8 RID: 17832 RVA: 0x001F1E3A File Offset: 0x001F003A
		// (set) Token: 0x060045A9 RID: 17833 RVA: 0x001F1E47 File Offset: 0x001F0047
		[Category("基本")]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("窗口标题")]
		[MergableProperty(false)]
		[DefaultValue("＊\u3000\u3000\u3000＊")]
		public string Text
		{
			get
			{
				return this.oO.o0o0000OO..Text;
			}
			set
			{
				this.oO.o0o0000OO..Text = value;
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x060045AA RID: 17834 RVA: 0x001F1E55 File Offset: 0x001F0055
		// (set) Token: 0x060045AB RID: 17835 RVA: 0x001F1E5D File Offset: 0x001F005D
		[Description("打开并列窗口后窗口标签显示的位置")]
		[O_Oo00Oo000O0(3.1)]
		[Category("基本")]
		[DisplayName("标题位置")]
		public TabAlignment TabAlignment
		{
			get
			{
				return this.o_00.OOO__o_OO.;
			}
			set
			{
				this.o_00.OOO__o_OO. = value;
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x060045AC RID: 17836 RVA: 0x001F1E66 File Offset: 0x001F0066
		// (set) Token: 0x060045AD RID: 17837 RVA: 0x001F1E70 File Offset: 0x001F0070
		[DisplayName("窗口类型")]
		[Category("基本")]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(3.0)]
		public FormStyleEnum FormStyle
		{
			get
			{
				return this.oO.o0o0000OO.;
			}
			set
			{
				this.oO.o0o0000OO. = value;
				if (value == FormStyleEnum.模式)
				{
					this.AutoOpen = false;
				}
				if (this.Form.o_0O.OO0_0_. != null)
				{
					if (value == FormStyleEnum.DropDownForm)
					{
						if (Conversions.ToInteger(this.Form.o_0O.OO0_0_.["Type"]) != 233)
						{
							this.Form.o_0O.OO0_0_.["Type"] = ControlTypeEnum.DropDownForm;
							return;
						}
					}
					else if (Conversions.ToInteger(this.Form.o_0O.OO0_0_.["Type"]) != 229)
					{
						this.Form.o_0O.OO0_0_.["Type"] = ControlTypeEnum.Form;
					}
				}
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x060045AE RID: 17838 RVA: 0x001F1F24 File Offset: 0x001F0124
		// (set) Token: 0x060045AF RID: 17839 RVA: 0x001F1F2C File Offset: 0x001F012C
		[Description("是否在启动的时候，自动打开此窗口。")]
		[OooO0(true)]
		[Category("基本")]
		[MergableProperty(false)]
		[DefaultValue(false)]
		[DisplayName("自动打开")]
		[O_Oo00Oo000O0(4.0)]
		public bool AutoOpen
		{
			get
			{
				return this.o0o__o._O.;
			}
			set
			{
				this.o0o__o._O. = value;
				if (this.FormStyle == FormStyleEnum.模式)
				{
					this.o0o__o._O. = false;
				}
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x060045B0 RID: 17840 RVA: 0x001F1F45 File Offset: 0x001F0145
		// (set) Token: 0x060045B1 RID: 17841 RVA: 0x001F1F52 File Offset: 0x001F0152
		[O_Oo00Oo000O0(5.2)]
		[Category("基本")]
		[DisplayName("自动滚动")]
		[MergableProperty(true)]
		[DefaultValue(false)]
		public bool AutoScroll
		{
			get
			{
				return this.Form.AutoScroll;
			}
			set
			{
				this.Form.AutoScroll = value;
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x060045B2 RID: 17842 RVA: 0x001F1F60 File Offset: 0x001F0160
		// (set) Token: 0x060045B3 RID: 17843 RVA: 0x001F1F6D File Offset: 0x001F016D
		[Category("基本")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(5.3)]
		[DisplayName("扩展尺寸")]
		public Size ExtendSize
		{
			get
			{
				return this.Form.AutoScrollMinSize;
			}
			set
			{
				this.Form.AutoScrollMinSize = value;
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x001F1F7B File Offset: 0x001F017B
		// (set) Token: 0x060045B5 RID: 17845 RVA: 0x001F1F83 File Offset: 0x001F0183
		[Category("基本")]
		[O_Oo00Oo000O0(6.0)]
		[Description("指定负责此窗口设计的用户")]
		[DisplayName("责任设计者")]
		[TypeConverter(typeof(oO0O_O))]
		public string Developer
		{
			get
			{
				return this.oOoo0._O00__00.;
			}
			set
			{
				this.oOoo0._O00__00. = value;
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x060045B6 RID: 17846 RVA: 0x001F1F8C File Offset: 0x001F018C
		// (set) Token: 0x060045B7 RID: 17847 RVA: 0x001F1F94 File Offset: 0x001F0194
		[O_Oo00Oo000O0(0.0)]
		[Category("外观")]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[MergableProperty(false)]
		[DisplayName("窗口图标")]
		public string ImageFile
		{
			get
			{
				return this.O00_.o00OO0o00.;
			}
			set
			{
				if (Operators.CompareString(value, "", true) > 0 && !value.EndsWith(".ico", StringComparison.CurrentCultureIgnoreCase))
				{
					MessageBox.Show("只有Icon文件才能作为窗口图标！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				this.O00_.o00OO0o00. = value;
				try
				{
					if (Operators.CompareString(value, "", true) > 0)
					{
						this.oO.o0o0000OO..Icon = new Icon(value);
					}
				}
				catch (Exception ex)
				{
					this.oO.o0o0000OO..Icon = null;
				}
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.oO.o0o0000OO..ShowIcon = true;
					return;
				}
				this.oO.o0o0000OO..ShowIcon = false;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x060045B8 RID: 17848 RVA: 0x001F2050 File Offset: 0x001F0250
		// (set) Token: 0x060045B9 RID: 17849 RVA: 0x001F2058 File Offset: 0x001F0258
		[DefaultValue("(default)")]
		[DisplayName("菜单样式")]
		[TypeConverter(typeof(oo__O__O_OoO))]
		[O_Oo00Oo000O0(1.0)]
		[Category("外观")]
		public string MenuTheme
		{
			get
			{
				return this.o0.0_0000OO.;
			}
			set
			{
				this.o0.0_0000OO. = value;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x060045BA RID: 17850 RVA: 0x001F2061 File Offset: 0x001F0261
		// (set) Token: 0x060045BB RID: 17851 RVA: 0x001F206E File Offset: 0x001F026E
		[MergableProperty(false)]
		[O_Oo00Oo000O0(2.0)]
		[Category("外观")]
		[DisplayName("背景颜色")]
		public Color BackColor
		{
			get
			{
				return this.oO.o0o0000OO..BackColor;
			}
			set
			{
				this.oO.o0o0000OO..BackColor = value;
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x060045BC RID: 17852 RVA: 0x001F207C File Offset: 0x001F027C
		// (set) Token: 0x060045BD RID: 17853 RVA: 0x001F2084 File Offset: 0x001F0284
		[Category("外观")]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[MergableProperty(false)]
		[DisplayName("背景图片")]
		[O_Oo00Oo000O0(3.0)]
		public string BackGroundImageFile
		{
			get
			{
				return this.oO._0Ooo.;
			}
			set
			{
				this.oO._0Ooo. = value;
				this.oO.o0o0000OO..BackgroundImage = OO_00oOO.GetImage(value);
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x060045BE RID: 17854 RVA: 0x001F209E File Offset: 0x001F029E
		// (set) Token: 0x060045BF RID: 17855 RVA: 0x001F20AB File Offset: 0x001F02AB
		[DisplayName("背景布局")]
		[O_Oo00Oo000O0(4.0)]
		[DefaultValue(1)]
		[Category("外观")]
		[MergableProperty(false)]
		public ImageLayout BackgroundImageLayout
		{
			get
			{
				return this.oO.o0o0000OO..BackgroundImageLayout;
			}
			set
			{
				this.oO.o0o0000OO..BackgroundImageLayout = value;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x060045C0 RID: 17856 RVA: 0x001F20B9 File Offset: 0x001F02B9
		// (set) Token: 0x060045C1 RID: 17857 RVA: 0x001F20C1 File Offset: 0x001F02C1
		[DefaultValue(1)]
		[O_Oo00Oo000O0(1.0)]
		[Category("位置")]
		[MergableProperty(false)]
		[DisplayName("初始位置")]
		public FormStartPosition StartPosition
		{
			get
			{
				return this.o_00.OOO__o_OO.;
			}
			set
			{
				this.o_00.OOO__o_OO. = value;
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x060045C2 RID: 17858 RVA: 0x001F20CA File Offset: 0x001F02CA
		// (set) Token: 0x060045C3 RID: 17859 RVA: 0x001F20D2 File Offset: 0x001F02D2
		[MergableProperty(false)]
		[Category("位置")]
		[O_Oo00Oo000O0(1.1)]
		[DefaultValue(false)]
		[DisplayName("最顶层")]
		public bool TopMost
		{
			get
			{
				return this.o_0O0O0_._OO.;
			}
			set
			{
				this.o_0O0O0_._OO. = value;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x060045C4 RID: 17860 RVA: 0x001F20DB File Offset: 0x001F02DB
		// (set) Token: 0x060045C5 RID: 17861 RVA: 0x001F20E3 File Offset: 0x001F02E3
		[Category("位置")]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("左")]
		public int Left
		{
			get
			{
				return this.O_O0O.o.;
			}
			set
			{
				this.O_O0O.o. = value;
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x060045C6 RID: 17862 RVA: 0x001F20EC File Offset: 0x001F02EC
		// (set) Token: 0x060045C7 RID: 17863 RVA: 0x001F20F4 File Offset: 0x001F02F4
		[Category("位置")]
		[DisplayName("上")]
		[O_Oo00Oo000O0(3.0)]
		[MergableProperty(false)]
		public int Top
		{
			get
			{
				return this.OOo0OO00O0.0.;
			}
			set
			{
				this.OOo0OO00O0.0. = value;
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x060045C8 RID: 17864 RVA: 0x001F2100 File Offset: 0x001F0300
		// (set) Token: 0x060045C9 RID: 17865 RVA: 0x001F2120 File Offset: 0x001F0320
		[Category("位置")]
		[O_Oo00Oo000O0(4.0)]
		[MergableProperty(false)]
		[DisplayName("宽")]
		public int Width
		{
			get
			{
				return this.oO.o0o0000OO..ClientSize.Width;
			}
			set
			{
				this.oO.o0o0000OO..ClientSize = new Size(value, this.oO.o0o0000OO..ClientSize.Height);
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x060045CA RID: 17866 RVA: 0x001F2154 File Offset: 0x001F0354
		// (set) Token: 0x060045CB RID: 17867 RVA: 0x001F2174 File Offset: 0x001F0374
		[MergableProperty(false)]
		[O_Oo00Oo000O0(5.0)]
		[Category("位置")]
		[DisplayName("高")]
		public int Height
		{
			get
			{
				return this.oO.o0o0000OO..ClientSize.Height;
			}
			set
			{
				this.oO.o0o0000OO..ClientSize = new Size(this.oO.o0o0000OO..ClientSize.Width, value);
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x060045CC RID: 17868 RVA: 0x001F21A5 File Offset: 0x001F03A5
		// (set) Token: 0x060045CD RID: 17869 RVA: 0x001F21AD File Offset: 0x001F03AD
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(false)]
		[DefaultValue(0)]
		[DisplayName("停靠区域")]
		[Category("停靠")]
		public DockAreaEnum DockArea
		{
			get
			{
				return this.oOo.ooo_0OOo0O.;
			}
			set
			{
				this.oOo.ooo_0OOo0O. = value;
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x060045CE RID: 17870 RVA: 0x001F21B6 File Offset: 0x001F03B6
		// (set) Token: 0x060045CF RID: 17871 RVA: 0x001F21BE File Offset: 0x001F03BE
		[DefaultValue(false)]
		[O_Oo00Oo000O0(4.0)]
		[MergableProperty(false)]
		[Category("停靠")]
		[DisplayName("独立停靠")]
		public bool DockTitle
		{
			get
			{
				return this.O00_.o00OO0o00.;
			}
			set
			{
				this.O00_.o00OO0o00. = value;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x060045D0 RID: 17872 RVA: 0x001F21C7 File Offset: 0x001F03C7
		// (set) Token: 0x060045D1 RID: 17873 RVA: 0x001F21CF File Offset: 0x001F03CF
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("显示标题")]
		[Category("停靠")]
		public bool ShowDockCaption
		{
			get
			{
				return this.O.00_.;
			}
			set
			{
				this.O.00_. = value;
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x060045D2 RID: 17874 RVA: 0x001F21D8 File Offset: 0x001F03D8
		// (set) Token: 0x060045D3 RID: 17875 RVA: 0x001F21E0 File Offset: 0x001F03E0
		[DisplayName("允许关闭")]
		[O_Oo00Oo000O0(6.0)]
		[Category("停靠")]
		public bool ShowCloseButton
		{
			get
			{
				return this.oOO00.oo_OoO.;
			}
			set
			{
				this.oOO00.oo_OoO. = value;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x060045D4 RID: 17876 RVA: 0x001F21E9 File Offset: 0x001F03E9
		// (set) Token: 0x060045D5 RID: 17877 RVA: 0x001F21F1 File Offset: 0x001F03F1
		[O_Oo00Oo000O0(6.0)]
		[Category("停靠")]
		[DisplayName("自动隐藏")]
		public bool AutoHide
		{
			get
			{
				return this.OO_o0O.O_0.;
			}
			set
			{
				this.OO_o0O.O_0. = value;
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x060045D6 RID: 17878 RVA: 0x001F21FA File Offset: 0x001F03FA
		// (set) Token: 0x060045D7 RID: 17879 RVA: 0x001F2202 File Offset: 0x001F0402
		[Description("窗口大小发生变化后，是否自动调整控件大小和布局")]
		[DefaultValue(false)]
		[O_Oo00Oo000O0(1.9)]
		[DisplayName("自动调整布局")]
		[Category("杂项")]
		public bool AutoLayout
		{
			get
			{
				return this.OO_o__.OO.;
			}
			set
			{
				this.OO_o__.OO. = value;
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x060045D8 RID: 17880 RVA: 0x001F220B File Offset: 0x001F040B
		// (set) Token: 0x060045D9 RID: 17881 RVA: 0x001F2213 File Offset: 0x001F0413
		[DisplayName("自动调整字体")]
		[Description("窗口大小发生变化后，在调整控件大小的时候，是否同步调整字体大小")]
		[Category("杂项")]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(1.91)]
		public bool AutoResizeFonts
		{
			get
			{
				return this.OO_0O0.O.;
			}
			set
			{
				this.OO_0O0.O. = value;
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x060045DA RID: 17882 RVA: 0x001F221C File Offset: 0x001F041C
		// (set) Token: 0x060045DB RID: 17883 RVA: 0x001F2224 File Offset: 0x001F0424
		[Category("杂项")]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("大小可调")]
		[Description("作为独立窗口时，其大小是否可调。")]
		[DefaultValue(true)]
		public bool AllowResize
		{
			get
			{
				return this.O.OO00OoO0.;
			}
			set
			{
				this.O.OO00OoO0. = value;
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x060045DC RID: 17884 RVA: 0x001F222D File Offset: 0x001F042D
		// (set) Token: 0x060045DD RID: 17885 RVA: 0x001F223A File Offset: 0x001F043A
		[DefaultValue(false)]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("显示图标")]
		[Category("杂项")]
		[MergableProperty(false)]
		public bool ShowIcon
		{
			get
			{
				return this.oO.o0o0000OO..ShowIcon;
			}
			set
			{
				this.oO.o0o0000OO..ShowIcon = value;
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x060045DE RID: 17886 RVA: 0x001F2248 File Offset: 0x001F0448
		// (set) Token: 0x060045DF RID: 17887 RVA: 0x001F2255 File Offset: 0x001F0455
		[MergableProperty(false)]
		[O_Oo00Oo000O0(6.0)]
		[DisplayName("最大化按钮")]
		[Category("杂项")]
		[DefaultValue(false)]
		public bool MaximizeBox
		{
			get
			{
				return this.oO.o0o0000OO..MaximizeBox;
			}
			set
			{
				this.oO.o0o0000OO..MaximizeBox = value;
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x060045E0 RID: 17888 RVA: 0x001F2263 File Offset: 0x001F0463
		// (set) Token: 0x060045E1 RID: 17889 RVA: 0x001F2270 File Offset: 0x001F0470
		[Category("杂项")]
		[O_Oo00Oo000O0(7.0)]
		[DisplayName("最小化按钮")]
		[MergableProperty(false)]
		[DefaultValue(false)]
		public bool MinimizeBox
		{
			get
			{
				return this.oO.o0o0000OO..MinimizeBox;
			}
			set
			{
				this.oO.o0o0000OO..MinimizeBox = value;
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x060045E2 RID: 17890 RVA: 0x001F227E File Offset: 0x001F047E
		// (set) Token: 0x060045E3 RID: 17891 RVA: 0x001F228B File Offset: 0x001F048B
		[DisplayName("显示控制框")]
		[DefaultValue(true)]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(8.0)]
		[Category("杂项")]
		public bool ControlBox
		{
			get
			{
				return this.oO.o0o0000OO..ControlBox;
			}
			set
			{
				this.oO.o0o0000OO..ControlBox = value;
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x060045E4 RID: 17892 RVA: 0x001F2299 File Offset: 0x001F0499
		// (set) Token: 0x060045E5 RID: 17893 RVA: 0x001F22A1 File Offset: 0x001F04A1
		[DisplayName("启用")]
		[Category("计时器")]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(1.0)]
		[Description("是否启用计时器。")]
		[DefaultValue(false)]
		public bool TimerEnabled
		{
			get
			{
				return this.O0_0.0.;
			}
			set
			{
				this.O0_0.0. = value;
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x060045E6 RID: 17894 RVA: 0x001F22AA File Offset: 0x001F04AA
		// (set) Token: 0x060045E7 RID: 17895 RVA: 0x001F22B2 File Offset: 0x001F04B2
		[Description("计时器代码执行间隔，单位为毫秒")]
		[O_Oo00Oo000O0(1.0)]
		[DisplayName("间隔")]
		[Category("计时器")]
		[MergableProperty(false)]
		[DefaultValue(1000)]
		public int TimerInterval
		{
			get
			{
				return this.O__._.;
			}
			set
			{
				this.O__._. = value;
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x060045E8 RID: 17896 RVA: 0x001F22BB File Offset: 0x001F04BB
		// (set) Token: 0x060045E9 RID: 17897 RVA: 0x001F22C3 File Offset: 0x001F04C3
		[MergableProperty(false)]
		[Description("提示信息的图标")]
		[DisplayName("显示图标")]
		[O_Oo00Oo000O0(1.0)]
		[Category("信息提示")]
		public ToolTipIcon ShowToolTipIcon
		{
			get
			{
				return this.o_00.OOO__o_OO.;
			}
			set
			{
				this.o_00.OOO__o_OO. = value;
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x060045EA RID: 17898 RVA: 0x001F22CC File Offset: 0x001F04CC
		// (set) Token: 0x060045EB RID: 17899 RVA: 0x001F22D4 File Offset: 0x001F04D4
		[Description("提示信息的标题")]
		[MergableProperty(false)]
		[DisplayName("提示标题")]
		[Category("信息提示")]
		[DefaultValue("提示")]
		[O_Oo00Oo000O0(2.0)]
		public string TootlTipTitle
		{
			get
			{
				return this.OOo0OO00O0.0.;
			}
			set
			{
				this.OOo0OO00O0.0. = value;
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x060045EC RID: 17900 RVA: 0x001F22DD File Offset: 0x001F04DD
		// (set) Token: 0x060045ED RID: 17901 RVA: 0x001F22E5 File Offset: 0x001F04E5
		[DefaultValue(false)]
		[DisplayName("气球样式")]
		[O_Oo00Oo000O0(3.0)]
		[Description("是否以气球样式显示提示信息")]
		[MergableProperty(false)]
		[Category("信息提示")]
		public bool ToolTipBalloon
		{
			get
			{
				return this.o.o0o.;
			}
			set
			{
				this.o.o0o. = value;
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x060045EE RID: 17902 RVA: 0x001F22EE File Offset: 0x001F04EE
		// (set) Token: 0x060045EF RID: 17903 RVA: 0x001F22F6 File Offset: 0x001F04F6
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0711")]
		[Category("窗口事件")]
		[Description("加载窗口后执行。")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.0)]
		public EventString AfterLoad
		{
			get
			{
				return this.o0.oO00o0o.;
			}
			set
			{
				this.o0.oO00o0o. = value;
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x060045F0 RID: 17904 RVA: 0x001F22FF File Offset: 0x001F04FF
		// (set) Token: 0x060045F1 RID: 17905 RVA: 0x001F2307 File Offset: 0x001F0507
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("窗口显示后执行。")]
		[Category("窗口事件")]
		[oO0oooo("3314")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.01)]
		public EventString AfterShow
		{
			get
			{
				return this.o._OO_o00OO0.;
			}
			set
			{
				this.o._OO_o00OO0. = value;
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x060045F2 RID: 17906 RVA: 0x001F2310 File Offset: 0x001F0510
		// (set) Token: 0x060045F3 RID: 17907 RVA: 0x001F2318 File Offset: 0x001F0518
		[oO0oooo("2114")]
		[Category("窗口事件")]
		[Description("作为下拉窗口显示前执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.05)]
		public EventString DropDownOpening
		{
			get
			{
				return this.ooOOOO_oO_.0OO.;
			}
			set
			{
				this.ooOOOO_oO_.0OO. = value;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x001F2321 File Offset: 0x001F0521
		// (set) Token: 0x060045F5 RID: 17909 RVA: 0x001F2329 File Offset: 0x001F0529
		[oO0oooo("2113")]
		[Category("窗口事件")]
		[Description("作为下拉窗口显示后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.1)]
		public EventString DropDownOpened
		{
			get
			{
				return this.O0_.O0O.;
			}
			set
			{
				this.O0_.O0O. = value;
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x060045F6 RID: 17910 RVA: 0x001F2332 File Offset: 0x001F0532
		// (set) Token: 0x060045F7 RID: 17911 RVA: 0x001F233A File Offset: 0x001F053A
		[Description("作为下拉窗口关闭后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("窗口事件")]
		[oO0oooo("2461")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.11)]
		public EventString DropDownClosed
		{
			get
			{
				return this.oOo._o.;
			}
			set
			{
				this.oOo._o. = value;
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x060045F8 RID: 17912 RVA: 0x001F2343 File Offset: 0x001F0543
		// (set) Token: 0x060045F9 RID: 17913 RVA: 0x001F234B File Offset: 0x001F054B
		[Description("关闭窗口后执行。")]
		[Category("窗口事件")]
		[oO0oooo("1546")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(2.0)]
		public EventString AfterClose
		{
			get
			{
				return this.O.OO00OoO0.;
			}
			set
			{
				this.O.OO00OoO0. = value;
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x001F2354 File Offset: 0x001F0554
		// (set) Token: 0x060045FB RID: 17915 RVA: 0x001F235C File Offset: 0x001F055C
		[Description("关闭窗口前执行。")]
		[oO0oooo("0712")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(4.0)]
		[Category("窗口事件")]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeClose
		{
			get
			{
				return this.o._o_o00_.;
			}
			set
			{
				this.o._o_o00_. = value;
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x060045FC RID: 17916 RVA: 0x001F2365 File Offset: 0x001F0565
		// (set) Token: 0x060045FD RID: 17917 RVA: 0x001F236D File Offset: 0x001F056D
		[oO0oooo("2740")]
		[Category("窗口事件")]
		[Description("窗口大小发生变化后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(4.0)]
		public EventString SizeChanged
		{
			get
			{
				return this.Oo_o._Oo.;
			}
			set
			{
				this.Oo_o._Oo. = value;
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x060045FE RID: 17918 RVA: 0x001F2376 File Offset: 0x001F0576
		// (set) Token: 0x060045FF RID: 17919 RVA: 0x001F237E File Offset: 0x001F057E
		[oO0oooo("1322")]
		[Category("窗口事件")]
		[Description("计时器代码")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(5.0)]
		public EventString TimerTick
		{
			get
			{
				return this.oo___o.0.;
			}
			set
			{
				this.oo___o.0. = value;
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06004600 RID: 17920 RVA: 0x001F2387 File Offset: 0x001F0587
		// (set) Token: 0x06004601 RID: 17921 RVA: 0x001F238F File Offset: 0x001F058F
		[oO0oooo("6020")]
		[Category("窗口事件")]
		[O_Oo00Oo000O0(5.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("自动调整控件大小事执行")]
		[O0O0oOO00_0OO(true)]
		public EventString ResizingControl
		{
			get
			{
				return this.Oo.O__0.;
			}
			set
			{
				this.Oo.O__0. = value;
			}
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06004602 RID: 17922 RVA: 0x001F2398 File Offset: 0x001F0598
		// (set) Token: 0x06004603 RID: 17923 RVA: 0x001F23A0 File Offset: 0x001F05A0
		[oO0oooo("6020")]
		[Category("窗口事件")]
		[Description("自动调整控件字体时执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(5.0)]
		public EventString ResizingFont
		{
			get
			{
				return this.OoO.o_0o0OO_O.;
			}
			set
			{
				this.OoO.o_0o0OO_O. = value;
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06004604 RID: 17924 RVA: 0x001F23A9 File Offset: 0x001F05A9
		// (set) Token: 0x06004605 RID: 17925 RVA: 0x001F23B1 File Offset: 0x001F05B1
		[oO0oooo("0732")]
		[Category("全局事件")]
		[Description("单击控件后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.0)]
		public EventString Click
		{
			get
			{
				return this.o_O.O.;
			}
			set
			{
				this.o_O.O. = value;
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06004606 RID: 17926 RVA: 0x001F23BA File Offset: 0x001F05BA
		// (set) Token: 0x06004607 RID: 17927 RVA: 0x001F23C2 File Offset: 0x001F05C2
		[oO0oooo("0732")]
		[Category("全局事件")]
		[Description("用鼠标单击控件后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.0)]
		public EventString MouseClick
		{
			get
			{
				return this.o.0oo.;
			}
			set
			{
				this.o.0oo. = value;
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06004608 RID: 17928 RVA: 0x001F23CB File Offset: 0x001F05CB
		// (set) Token: 0x06004609 RID: 17929 RVA: 0x001F23D3 File Offset: 0x001F05D3
		[oO0oooo("0733")]
		[Category("全局事件")]
		[Description("双击控件后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.1)]
		public EventString DoubleClick
		{
			get
			{
				return this.o000.oo__.;
			}
			set
			{
				this.o000.oo__. = value;
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x0600460A RID: 17930 RVA: 0x001F23DC File Offset: 0x001F05DC
		// (set) Token: 0x0600460B RID: 17931 RVA: 0x001F23E4 File Offset: 0x001F05E4
		[oO0oooo("0734")]
		[Category("全局事件")]
		[Description("选择控件后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(2.0)]
		public EventString Enter
		{
			get
			{
				return this.Ooo_____.0.;
			}
			set
			{
				this.Ooo_____.0. = value;
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x0600460C RID: 17932 RVA: 0x001F23ED File Offset: 0x001F05ED
		// (set) Token: 0x0600460D RID: 17933 RVA: 0x001F23F5 File Offset: 0x001F05F5
		[Description("离开控件后执行")]
		[oO0oooo("0735")]
		[Category("全局事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(3.0)]
		public EventString Leave
		{
			get
			{
				return this.O0_o._0OO.;
			}
			set
			{
				this.O0_o._0OO. = value;
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x0600460E RID: 17934 RVA: 0x001F23FE File Offset: 0x001F05FE
		// (set) Token: 0x0600460F RID: 17935 RVA: 0x001F2406 File Offset: 0x001F0606
		[oO0oooo("0736")]
		[Category("全局事件")]
		[Description("离开控件前执行，通常用来对输入内容进行校对。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(4.0)]
		public EventString Validating
		{
			get
			{
				return this.oo0._oO0oO0.;
			}
			set
			{
				this.oo0._oO0oO0. = value;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06004610 RID: 17936 RVA: 0x001F240F File Offset: 0x001F060F
		// (set) Token: 0x06004611 RID: 17937 RVA: 0x001F2417 File Offset: 0x001F0617
		[oO0oooo("0769")]
		[Category("全局事件")]
		[Description("值改变后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(4.1)]
		public EventString ValueChanged
		{
			get
			{
				return this.oOoo.ooo.;
			}
			set
			{
				this.oOoo.ooo. = value;
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06004612 RID: 17938 RVA: 0x001F2420 File Offset: 0x001F0620
		// (set) Token: 0x06004613 RID: 17939 RVA: 0x001F2428 File Offset: 0x001F0628
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("文本改变后执行")]
		[oO0oooo("0768")]
		[Category("全局事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(4.2)]
		public EventString TextChanged
		{
			get
			{
				return this.O_ooO0__0Oo._o.;
			}
			set
			{
				this.O_ooO0__0Oo._o. = value;
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06004614 RID: 17940 RVA: 0x001F2431 File Offset: 0x001F0631
		// (set) Token: 0x06004615 RID: 17941 RVA: 0x001F2439 File Offset: 0x001F0639
		[Description("Checked(选中)属性发生变化后执行。")]
		[oO0oooo("0781")]
		[Category("全局事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(4.3)]
		public EventString CheckedChanged
		{
			get
			{
				return this.O_.o0Oo0.;
			}
			set
			{
				this.O_.o0Oo0. = value;
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06004616 RID: 17942 RVA: 0x001F2442 File Offset: 0x001F0642
		// (set) Token: 0x06004617 RID: 17943 RVA: 0x001F244A File Offset: 0x001F064A
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0739")]
		[Category("全局事件")]
		[Description("输入字符时执行")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(6.0)]
		public EventString KeyPress
		{
			get
			{
				return this.o______0oO.Oo_.;
			}
			set
			{
				this.o______0oO.Oo_. = value;
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06004618 RID: 17944 RVA: 0x001F2453 File Offset: 0x001F0653
		// (set) Token: 0x06004619 RID: 17945 RVA: 0x001F245B File Offset: 0x001F065B
		[oO0oooo("0741")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("全局事件")]
		[Description("压下按键时执行")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(7.0)]
		public EventString KeyDown
		{
			get
			{
				return this.o_o0OO_.oo.;
			}
			set
			{
				this.o_o0OO_.oo. = value;
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x0600461A RID: 17946 RVA: 0x001F2464 File Offset: 0x001F0664
		// (set) Token: 0x0600461B RID: 17947 RVA: 0x001F246C File Offset: 0x001F066C
		[oO0oooo("0741")]
		[Category("全局事件")]
		[Description("松开按键执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(8.0)]
		public EventString KeyUp
		{
			get
			{
				return this.o__O0O.O_0.;
			}
			set
			{
				this.o__O0O.O_0. = value;
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x0600461C RID: 17948 RVA: 0x001F2475 File Offset: 0x001F0675
		// (set) Token: 0x0600461D RID: 17949 RVA: 0x001F247D File Offset: 0x001F067D
		[oO0oooo("0743")]
		[Category("全局事件")]
		[Description("鼠标进入控件后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(9.0)]
		public EventString MouseEnter
		{
			get
			{
				return this.O.Oo0_0.;
			}
			set
			{
				this.O.Oo0_0. = value;
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x0600461E RID: 17950 RVA: 0x001F2486 File Offset: 0x001F0686
		// (set) Token: 0x0600461F RID: 17951 RVA: 0x001F248E File Offset: 0x001F068E
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0744")]
		[Category("全局事件")]
		[Description("鼠标离开控件后执行")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(10.0)]
		public EventString MouseLeave
		{
			get
			{
				return this.O_oOo0_oOo.O0.;
			}
			set
			{
				this.O_oOo0_oOo.O0. = value;
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06004620 RID: 17952 RVA: 0x001F2497 File Offset: 0x001F0697
		// (set) Token: 0x06004621 RID: 17953 RVA: 0x001F249F File Offset: 0x001F069F
		[oO0oooo("1320")]
		[Description("在控件上移动鼠标的时候执行")]
		[Category("全局事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(11.0)]
		public EventString MouseMove
		{
			get
			{
				return this.o0o0o.o__.;
			}
			set
			{
				this.o0o0o.o__. = value;
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06004622 RID: 17954 RVA: 0x001F24A8 File Offset: 0x001F06A8
		// (set) Token: 0x06004623 RID: 17955 RVA: 0x001F24B0 File Offset: 0x001F06B0
		[oO0oooo("0745")]
		[Category("全局事件")]
		[Description("鼠标停留在控件上的时候执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(12.0)]
		public EventString MouseHover
		{
			get
			{
				return this.oo0__o.O.;
			}
			set
			{
				this.oo0__o.O. = value;
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06004624 RID: 17956 RVA: 0x001F24B9 File Offset: 0x001F06B9
		// (set) Token: 0x06004625 RID: 17957 RVA: 0x001F24C1 File Offset: 0x001F06C1
		[Description("按下鼠标后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0746")]
		[Category("全局事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(13.0)]
		public EventString MouseDown
		{
			get
			{
				return this.O0_O_O_.O__.;
			}
			set
			{
				this.O0_O_O_.O__. = value;
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06004626 RID: 17958 RVA: 0x001F24CA File Offset: 0x001F06CA
		// (set) Token: 0x06004627 RID: 17959 RVA: 0x001F24D2 File Offset: 0x001F06D2
		[oO0oooo("0747")]
		[Category("全局事件")]
		[Description("松开鼠标后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(14.0)]
		public EventString MouseUp
		{
			get
			{
				return this.O_o.0o.;
			}
			set
			{
				this.O_o.0o. = value;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06004628 RID: 17960 RVA: 0x001F24DB File Offset: 0x001F06DB
		// (set) Token: 0x06004629 RID: 17961 RVA: 0x001F24E8 File Offset: 0x001F06E8
		[OooO0(true)]
		[Browsable(false)]
		public Size Size
		{
			get
			{
				return this.oO.o0o0000OO..Size;
			}
			set
			{
				this.oO.o0o0000OO..Size = value;
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x0600462A RID: 17962 RVA: 0x001F24F6 File Offset: 0x001F06F6
		// (set) Token: 0x0600462B RID: 17963 RVA: 0x001F24FE File Offset: 0x001F06FE
		[oO0oooo("3222")]
		[Description("单击菜单项目后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("菜单事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.0)]
		public EventString ItemClick
		{
			get
			{
				return this.oo0__00.o00_.;
			}
			set
			{
				this.oo0__00.o00_. = value;
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x0600462C RID: 17964 RVA: 0x001F2507 File Offset: 0x001F0707
		// (set) Token: 0x0600462D RID: 17965 RVA: 0x001F250F File Offset: 0x001F070F
		[oO0oooo("3222")]
		[Description("鼠标进入菜单项目后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("菜单事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(5.0)]
		public EventString ItemMouseEnter
		{
			get
			{
				return this.OO0o_0._0_O0_O.;
			}
			set
			{
				this.OO0o_0._0_O0_O. = value;
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x0600462E RID: 17966 RVA: 0x001F2518 File Offset: 0x001F0718
		// (set) Token: 0x0600462F RID: 17967 RVA: 0x001F2520 File Offset: 0x001F0720
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("鼠标离开菜单项目后执行")]
		[oO0oooo("3222")]
		[Category("菜单事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(6.0)]
		public EventString ItemMouseLeave
		{
			get
			{
				return this.oo.oO0O0o0Oo.;
			}
			set
			{
				this.oo.oO0O0o0Oo. = value;
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06004630 RID: 17968 RVA: 0x001F2529 File Offset: 0x001F0729
		// (set) Token: 0x06004631 RID: 17969 RVA: 0x001F2531 File Offset: 0x001F0731
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("菜单事件")]
		[Description("鼠标停留在菜单项目上时执行")]
		[oO0oooo("3222")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(7.0)]
		public EventString ItemMouseHover
		{
			get
			{
				return this.ooO.O_00.;
			}
			set
			{
				this.ooO.O_00. = value;
			}
		}

		// Token: 0x04001C3B RID: 7227
		private o\u3002\u3002\u3000\u3000\u3002 <<EMPTY_NAME>>;

		// Token: 0x04001C3C RID: 7228
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C3D RID: 7229
		private ToolTipIcon <<EMPTY_NAME>>;

		// Token: 0x04001C3E RID: 7230
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C3F RID: 7231
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C40 RID: 7232
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C41 RID: 7233
		private FormStyleEnum <<EMPTY_NAME>>;

		// Token: 0x04001C42 RID: 7234
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C43 RID: 7235
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C44 RID: 7236
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C45 RID: 7237
		private FormStartPosition <<EMPTY_NAME>>;

		// Token: 0x04001C46 RID: 7238
		private int <<EMPTY_NAME>>;

		// Token: 0x04001C47 RID: 7239
		private int <<EMPTY_NAME>>;

		// Token: 0x04001C48 RID: 7240
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C49 RID: 7241
		private DockAreaEnum <<EMPTY_NAME>>;

		// Token: 0x04001C4A RID: 7242
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C4B RID: 7243
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C4C RID: 7244
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C4D RID: 7245
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C4E RID: 7246
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C4F RID: 7247
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C50 RID: 7248
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C51 RID: 7249
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C52 RID: 7250
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C53 RID: 7251
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C54 RID: 7252
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C55 RID: 7253
		private int <<EMPTY_NAME>>;

		// Token: 0x04001C56 RID: 7254
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C57 RID: 7255
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C58 RID: 7256
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C59 RID: 7257
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C5A RID: 7258
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C5B RID: 7259
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C5C RID: 7260
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C5D RID: 7261
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C5E RID: 7262
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C5F RID: 7263
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C60 RID: 7264
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C61 RID: 7265
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C62 RID: 7266
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C63 RID: 7267
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C64 RID: 7268
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C65 RID: 7269
		private PrintPageProperty <<EMPTY_NAME>>;

		// Token: 0x04001C66 RID: 7270
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C67 RID: 7271
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C68 RID: 7272
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C69 RID: 7273
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C6A RID: 7274
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C6B RID: 7275
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C6C RID: 7276
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C6D RID: 7277
		private TabAlignment <<EMPTY_NAME>>;

		// Token: 0x04001C6E RID: 7278
		private string <<EMPTY_NAME>>;

		// Token: 0x04001C6F RID: 7279
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C70 RID: 7280
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001C71 RID: 7281
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C72 RID: 7282
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C73 RID: 7283
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C74 RID: 7284
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C75 RID: 7285
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C76 RID: 7286
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001C77 RID: 7287
		private EventString <<EMPTY_NAME>>;
	}
}
