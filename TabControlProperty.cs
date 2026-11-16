using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1Input;

namespace Foxtable
{
	// Token: 0x02000424 RID: 1060
	internal class TabControlProperty : ControlPropertyBase
	{
		// Token: 0x06004779 RID: 18297 RVA: 0x001F3A29 File Offset: 0x001F1C29
		public TabControlProperty(ControlHolder A_0) : base(A_0)
		{
			this.o.O_oO. = (C1DockingTab)A_0.ChildControl;
			this.o.O_oO..TabsCanFocus = false;
			this.o.O_oO..TabLook = ButtonLookFlags.TextAndImage;
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x001F3A5C File Offset: 0x001F1C5C
		// (set) Token: 0x0600477B RID: 18299 RVA: 0x001F3A6A File Offset: 0x001F1C6A
		[Browsable(false)]
		[OooO0(true)]
		public override Color BackColor
		{
			get
			{
				Color result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x0600477C RID: 18300 RVA: 0x001F3A6C File Offset: 0x001F1C6C
		// (set) Token: 0x0600477D RID: 18301 RVA: 0x001F3A7A File Offset: 0x001F1C7A
		[OooO0(false)]
		[Browsable(false)]
		public C1.Win.C1Command.VisualStyle VisualStyle
		{
			get
			{
				C1.Win.C1Command.VisualStyle result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x0600477E RID: 18302 RVA: 0x001F3A7C File Offset: 0x001F1C7C
		// (set) Token: 0x0600477F RID: 18303 RVA: 0x001F3A8E File Offset: 0x001F1C8E
		[TypeConverter(typeof(o00))]
		[O_Oo00Oo000O0(0.0)]
		[DisplayName("样式")]
		[Category("外观")]
		[DefaultValue("(default)")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.o.O_oO.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.o.O_oO.
				});
				this.o.O_oO..TabSizeMode = TabSizeModeEnum.Normal;
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06004780 RID: 18304 RVA: 0x001F3AB6 File Offset: 0x001F1CB6
		// (set) Token: 0x06004781 RID: 18305 RVA: 0x001F3AC3 File Offset: 0x001F1CC3
		[O_Oo00Oo000O0(0.1)]
		[DefaultValue(true)]
		[MergableProperty(true)]
		[Category("页签外观")]
		[DisplayName("显示页签")]
		public bool ShowTabs
		{
			get
			{
				return this.o.O_oO..ShowTabs;
			}
			set
			{
				this.o.O_oO..ShowTabs = value;
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06004782 RID: 18306 RVA: 0x001F3AD1 File Offset: 0x001F1CD1
		// (set) Token: 0x06004783 RID: 18307 RVA: 0x001F3ADE File Offset: 0x001F1CDE
		[O_Oo00Oo000O0(1.0)]
		[Category("页签外观")]
		[MergableProperty(true)]
		[DisplayName("页签位置")]
		[DefaultValue(0)]
		public TabAlignment TabPosition
		{
			get
			{
				return this.o.O_oO..Alignment;
			}
			set
			{
				this.o.O_oO..Alignment = value;
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x001F3AEC File Offset: 0x001F1CEC
		// (set) Token: 0x06004785 RID: 18309 RVA: 0x001F3AF9 File Offset: 0x001F1CF9
		[MergableProperty(true)]
		[DisplayName("页签对齐")]
		[Category("页签外观")]
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(0)]
		public StringAlignment TabAlign
		{
			get
			{
				return this.o.O_oO..AlignTabs;
			}
			set
			{
				this.o.O_oO..AlignTabs = value;
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06004786 RID: 18310 RVA: 0x001F3B07 File Offset: 0x001F1D07
		// (set) Token: 0x06004787 RID: 18311 RVA: 0x001F3B14 File Offset: 0x001F1D14
		[MergableProperty(true)]
		[O_Oo00Oo000O0(3.0)]
		[DefaultValue(false)]
		[DisplayName("多行页签")]
		[Category("页签外观")]
		public bool MultiLine
		{
			get
			{
				return this.o.O_oO..MultiLine;
			}
			set
			{
				this.o.O_oO..MultiLine = value;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06004788 RID: 18312 RVA: 0x001F3B22 File Offset: 0x001F1D22
		// (set) Token: 0x06004789 RID: 18313 RVA: 0x001F3B2F File Offset: 0x001F1D2F
		[MergableProperty(true)]
		[DisplayName("页签文本方向")]
		[Category("页签外观")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(4.0)]
		public TabTextDirectionEnum TextDirection
		{
			get
			{
				return this.o.O_oO..TextDirection;
			}
			set
			{
				this.o.O_oO..TextDirection = value;
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x0600478A RID: 18314 RVA: 0x001F3B3D File Offset: 0x001F1D3D
		// (set) Token: 0x0600478B RID: 18315 RVA: 0x001F3B4A File Offset: 0x001F1D4A
		[DisplayName("页签文本位置")]
		[O_Oo00Oo000O0(5.0)]
		[Category("页签外观")]
		[DefaultValue(0)]
		[MergableProperty(true)]
		public ButtonLayoutEnum TabLayout
		{
			get
			{
				return this.o.O_oO..TabLayout;
			}
			set
			{
				this.o.O_oO..TabLayout = value;
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x0600478C RID: 18316 RVA: 0x001F3B58 File Offset: 0x001F1D58
		// (set) Token: 0x0600478D RID: 18317 RVA: 0x001F3B65 File Offset: 0x001F1D65
		[Description("活动页签的字体是否加粗。")]
		[MergableProperty(true)]
		[Category("页签外观")]
		[DisplayName("粗体显示")]
		[O_Oo00Oo000O0(7.0)]
		[DefaultValue(false)]
		public bool SelectedTabBold
		{
			get
			{
				return this.o.O_oO..SelectedTabBold;
			}
			set
			{
				this.o.O_oO..SelectedTabBold = value;
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x0600478E RID: 18318 RVA: 0x001F3B73 File Offset: 0x001F1D73
		// (set) Token: 0x0600478F RID: 18319 RVA: 0x001F3B80 File Offset: 0x001F1D80
		[DefaultValue(0)]
		[MergableProperty(true)]
		[DisplayName("页签间距")]
		[O_Oo00Oo000O0(8.0)]
		[Category("页签外观")]
		public int TabsSpacing
		{
			get
			{
				return this.o.O_oO..TabsSpacing;
			}
			set
			{
				this.o.O_oO..TabsSpacing = value;
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x001F3B8E File Offset: 0x001F1D8E
		// (set) Token: 0x06004791 RID: 18321 RVA: 0x001F3B9B File Offset: 0x001F1D9B
		[MergableProperty(true)]
		[Category("页签外观")]
		[Description("第一个页签的缩进距离。")]
		[DefaultValue(5)]
		[O_Oo00Oo000O0(9.0)]
		[DisplayName("页签缩进")]
		public int Indent
		{
			get
			{
				return this.o.O_oO..Indent;
			}
			set
			{
				this.o.O_oO..Indent = value;
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x001F3BA9 File Offset: 0x001F1DA9
		// (set) Token: 0x06004793 RID: 18323 RVA: 0x001F3BBB File Offset: 0x001F1DBB
		[MergableProperty(false)]
		[OooO0(true)]
		[DisplayName("页面标题")]
		[Category("选定页面")]
		[O_Oo00Oo000O0(1.0)]
		public string TextOfSelectedTab
		{
			get
			{
				return this.o.O_oO..SelectedTab.Text;
			}
			set
			{
				this.o.O_oO..SelectedTab.Text = value;
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06004794 RID: 18324 RVA: 0x001F3BCE File Offset: 0x001F1DCE
		// (set) Token: 0x06004795 RID: 18325 RVA: 0x001F3BE0 File Offset: 0x001F1DE0
		[Category("选定页面")]
		[OooO0(true)]
		[DisplayName("页面名称")]
		[MergableProperty(false)]
		[O_Oo00Oo000O0(1.0)]
		public string NameOfSelectedTab
		{
			get
			{
				return this.o.O_oO..SelectedTab.Name;
			}
			set
			{
				this.o.O_oO..SelectedTab.Name = value;
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x001F3BF3 File Offset: 0x001F1DF3
		// (set) Token: 0x06004797 RID: 18327 RVA: 0x001F3C0A File Offset: 0x001F1E0A
		[OooO0(true)]
		[DisplayName("页面图标")]
		[Category("选定页面")]
		[O_Oo00Oo000O0(3.0)]
		[MergableProperty(false)]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		public string ImageFileOfSelectedTab
		{
			get
			{
				return ((O_O_)this.o.O_oO..SelectedTab).ImageFile;
			}
			set
			{
				((O_O_)this.o.O_oO..SelectedTab).ImageFile = value;
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x001F3C22 File Offset: 0x001F1E22
		// (set) Token: 0x06004799 RID: 18329 RVA: 0x001F3C2A File Offset: 0x001F1E2A
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("2415")]
		[Category("事件")]
		[Description("选定不同页面前执行。")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.1)]
		public EventString SelectedIndexChanging
		{
			get
			{
				return this.OO_._0_oO__0.;
			}
			set
			{
				this.OO_._0_oO__0. = value;
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x001F3C33 File Offset: 0x001F1E33
		// (set) Token: 0x0600479B RID: 18331 RVA: 0x001F3C3B File Offset: 0x001F1E3B
		[O_Oo00Oo000O0(0.1)]
		[Description("选定不同页面后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0833")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString SelectedIndexChanged
		{
			get
			{
				return this.o.O_oO.;
			}
			set
			{
				this.o.O_oO. = value;
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x0600479C RID: 18332 RVA: 0x001F3C44 File Offset: 0x001F1E44
		// (set) Token: 0x0600479D RID: 18333 RVA: 0x001F3CC0 File Offset: 0x001F1EC0
		[Browsable(false)]
		public string Pages
		{
			get
			{
				string text = null;
				int num = this.o.O_oO..TabPages.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					CustomDockingTabPageProperty a_ = new CustomDockingTabPageProperty((O_O_)this.o.O_oO..TabPages[i]);
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
				this.o.O_oO..TabPages.Clear();
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					O_O_ o_O_ = base.Holder.oo_.o_O.();
					object a_ = new CustomDockingTabPageProperty(o_O_);
					this.o.O_oO..TabPages.Add(o_O_);
					o_O_o_oOoo__.OOOO_OO._oo.(a_, array[i], '\t');
				}
			}
		}

		// Token: 0x04001CD4 RID: 7380
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x04001CD5 RID: 7381
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CD6 RID: 7382
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CD7 RID: 7383
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CD8 RID: 7384
		private C1.Win.C1Input.VisualStyle <<EMPTY_NAME>>;
	}
}
