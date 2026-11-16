using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x0200041A RID: 1050
	internal class NavBarProperty : ControlPropertyBase
	{
		// Token: 0x06004670 RID: 18032 RVA: 0x001F29D4 File Offset: 0x001F0BD4
		public NavBarProperty(ControlHolder A_0) : base(A_0)
		{
			this.oO_o.0_o0_. = (O_OOO)A_0.ChildControl;
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06004671 RID: 18033 RVA: 0x001F29F0 File Offset: 0x001F0BF0
		// (set) Token: 0x06004672 RID: 18034 RVA: 0x001F29FE File Offset: 0x001F0BFE
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

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06004673 RID: 18035 RVA: 0x001F2A00 File Offset: 0x001F0C00
		// (set) Token: 0x06004674 RID: 18036 RVA: 0x001F2A12 File Offset: 0x001F0C12
		[O_Oo00Oo000O0(0.0)]
		[TypeConverter(typeof(o00))]
		[DisplayName("样式")]
		[Category("外观")]
		[DefaultValue("(default)")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.oO_o.0_o0_.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.oO_o.0_o0_.
				});
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06004675 RID: 18037 RVA: 0x001F2A2E File Offset: 0x001F0C2E
		// (set) Token: 0x06004676 RID: 18038 RVA: 0x001F2A3B File Offset: 0x001F0C3B
		[DisplayName("按钮字体")]
		[O_Oo00Oo000O0(4.0)]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue("宋体,9")]
		public Font ButtonFont
		{
			get
			{
				return this.oO_o.0_o0_..ButtonFont;
			}
			set
			{
				this.oO_o.0_o0_..ButtonFont = value;
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06004677 RID: 18039 RVA: 0x001F2A49 File Offset: 0x001F0C49
		// (set) Token: 0x06004678 RID: 18040 RVA: 0x001F2A56 File Offset: 0x001F0C56
		[O_Oo00Oo000O0(5.0)]
		[Category("外观")]
		[MergableProperty(true)]
		[DisplayName("按钮高度")]
		[DefaultValue(32)]
		public int ButtonHeight
		{
			get
			{
				return this.oO_o.0_o0_..ButtonHeight;
			}
			set
			{
				this.oO_o.0_o0_..ButtonHeight = value;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06004679 RID: 18041 RVA: 0x001F2A64 File Offset: 0x001F0C64
		// (set) Token: 0x0600467A RID: 18042 RVA: 0x001F2A71 File Offset: 0x001F0C71
		[MergableProperty(true)]
		[O_Oo00Oo000O0(6.0)]
		[DisplayName("图标大小")]
		[Category("外观")]
		public Size ButtonImageSize
		{
			get
			{
				return this.oO_o.0_o0_..ImageScalingSize;
			}
			set
			{
				this.oO_o.0_o0_..ImageScalingSize = value;
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x0600467B RID: 18043 RVA: 0x001F2A7F File Offset: 0x001F0C7F
		// (set) Token: 0x0600467C RID: 18044 RVA: 0x001F2A8C File Offset: 0x001F0C8C
		[O_Oo00Oo000O0(7.0)]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue("宋体,9")]
		[DisplayName("标题字体")]
		public Font HeaderFont
		{
			get
			{
				return this.oO_o.0_o0_..PanelHeaderFont;
			}
			set
			{
				this.oO_o.0_o0_..PanelHeaderFont = value;
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x0600467D RID: 18045 RVA: 0x001F2A9A File Offset: 0x001F0C9A
		// (set) Token: 0x0600467E RID: 18046 RVA: 0x001F2AA7 File Offset: 0x001F0CA7
		[MergableProperty(true)]
		[O_Oo00Oo000O0(8.0)]
		[DefaultValue(24)]
		[Category("外观")]
		[DisplayName("标题高度")]
		public int HeaderHeight
		{
			get
			{
				return this.oO_o.0_o0_..PanelHeaderHeight;
			}
			set
			{
				this.oO_o.0_o0_..PanelHeaderHeight = value;
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x0600467F RID: 18047 RVA: 0x001F2AB5 File Offset: 0x001F0CB5
		// (set) Token: 0x06004680 RID: 18048 RVA: 0x001F2AC2 File Offset: 0x001F0CC2
		[DefaultValue(5)]
		[Category("外观")]
		[O_Oo00Oo000O0(9.0)]
		[MergableProperty(true)]
		[Description("多余的按钮显示在水平栏，设为-1会显示所有按钮。")]
		[DisplayName("显示按钮数")]
		public int StackButtonCount
		{
			get
			{
				return this.oO_o.0_o0_..StackButtonCount;
			}
			set
			{
				this.oO_o.0_o0_..StackButtonCount = value;
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06004681 RID: 18049 RVA: 0x001F2AD0 File Offset: 0x001F0CD0
		// (set) Token: 0x06004682 RID: 18050 RVA: 0x001F2ADD File Offset: 0x001F0CDD
		[DefaultValue(30)]
		[Description("如果不需要在水平栏显示内容，可设为0")]
		[DisplayName("水平栏高度")]
		[O_Oo00Oo000O0(10.0)]
		[Category("外观")]
		[MergableProperty(true)]
		public int StripHeight
		{
			get
			{
				return this.oO_o.0_o0_..StripHeight;
			}
			set
			{
				this.oO_o.0_o0_..StripHeight = value;
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06004683 RID: 18051 RVA: 0x001F2AEB File Offset: 0x001F0CEB
		// (set) Token: 0x06004684 RID: 18052 RVA: 0x001F2AFD File Offset: 0x001F0CFD
		[DisplayName("页面名称")]
		[OooO0(true)]
		[Category("选定页面")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(0.0)]
		public string SelectedPageNamet
		{
			get
			{
				return this.oO_o.0_o0_..SelectedPanel.Name;
			}
			set
			{
				this.oO_o.0_o0_..SelectedPanel.Name = value;
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06004685 RID: 18053 RVA: 0x001F2B10 File Offset: 0x001F0D10
		// (set) Token: 0x06004686 RID: 18054 RVA: 0x001F2B22 File Offset: 0x001F0D22
		[MergableProperty(true)]
		[DisplayName("页面标题")]
		[OooO0(true)]
		[Category("选定页面")]
		[O_Oo00Oo000O0(1.0)]
		public string SelectedHeaderText
		{
			get
			{
				return this.oO_o.0_o0_..SelectedButton.PanelHeader;
			}
			set
			{
				this.oO_o.0_o0_..SelectedButton.PanelHeader = value;
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06004687 RID: 18055 RVA: 0x001F2B35 File Offset: 0x001F0D35
		// (set) Token: 0x06004688 RID: 18056 RVA: 0x001F2B47 File Offset: 0x001F0D47
		[MergableProperty(true)]
		[DisplayName("按钮标题")]
		[OooO0(true)]
		[Category("选定页面")]
		[O_Oo00Oo000O0(2.0)]
		public string SelectedButtonText
		{
			get
			{
				return this.oO_o.0_o0_..SelectedButton.Text;
			}
			set
			{
				this.oO_o.0_o0_..SelectedButton.Text = value;
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06004689 RID: 18057 RVA: 0x001F2B5A File Offset: 0x001F0D5A
		// (set) Token: 0x0600468A RID: 18058 RVA: 0x001F2B71 File Offset: 0x001F0D71
		[OooO0(true)]
		[DisplayName("按钮图标")]
		[O_Oo00Oo000O0(3.0)]
		[Category("选定页面")]
		[MergableProperty(true)]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		public string SelectedButtonImage
		{
			get
			{
				return ((oO_0)this.oO_o.0_o0_..SelectedPanel).ImageFile;
			}
			set
			{
				((oO_0)this.oO_o.0_o0_..SelectedPanel).ImageFile = value;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x0600468B RID: 18059 RVA: 0x001F2B89 File Offset: 0x001F0D89
		// (set) Token: 0x0600468C RID: 18060 RVA: 0x001F2BA0 File Offset: 0x001F0DA0
		[MergableProperty(true)]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[OooO0(true)]
		[DisplayName("按钮小图标")]
		[Category("选定页面")]
		[O_Oo00Oo000O0(4.0)]
		public string SelectedButtonSmallImage
		{
			get
			{
				return ((oO_0)this.oO_o.0_o0_..SelectedPanel).oOo_._0__0o_0o.();
			}
			set
			{
				((oO_0)this.oO_o.0_o0_..SelectedPanel).oOo_._0__0o_0o.(value);
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x0600468D RID: 18061 RVA: 0x001F2BB8 File Offset: 0x001F0DB8
		// (set) Token: 0x0600468E RID: 18062 RVA: 0x001F2BC0 File Offset: 0x001F0DC0
		[Category("事件")]
		[oO0oooo("0876")]
		[O_Oo00Oo000O0(0.1)]
		[Description("选定不同页面后执行。")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString SelectedIndexChanged
		{
			get
			{
				return this.oO_o.0_o0_.;
			}
			set
			{
				this.oO_o.0_o0_. = value;
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x0600468F RID: 18063 RVA: 0x001F2BCC File Offset: 0x001F0DCC
		// (set) Token: 0x06004690 RID: 18064 RVA: 0x001F2C48 File Offset: 0x001F0E48
		[Browsable(false)]
		public string Panels
		{
			get
			{
				string text = null;
				int num = this.oO_o.0_o0_..Panels.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					CustomNavBarPanelProperty a_ = new CustomNavBarPanelProperty((oO_0)this.oO_o.0_o0_..Panels[i]);
					if (i > 0)
					{
						text += "\f";
					}
					text += o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\t', false).Replace("\f", "");
				}
				return text;
			}
			set
			{
				string[] array = value.Split(new char[]
				{
					'\f'
				});
				this.oO_o.0_o0_..Panels.Clear();
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					oO_0 oO_ = base.Holder.oo_.o_O.();
					object a_ = new CustomNavBarPanelProperty(oO_);
					this.oO_o.0_o0_..Panels.Add(oO_);
					o_O_o_oOoo__.OOOO_OO._oo.(a_, array[i], '\t');
				}
			}
		}

		// Token: 0x04001C89 RID: 7305
		private O_OOO <<EMPTY_NAME>>;

		// Token: 0x04001C8A RID: 7306
		private EventString <<EMPTY_NAME>>;
	}
}
