using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x0200047F RID: 1151
	[oO0oooo("1092")]
	internal class RibbonApplicationMenu : RibbonDropDownItem
	{
		// Token: 0x06004EA3 RID: 20131 RVA: 0x00238238 File Offset: 0x00236438
		public RibbonApplicationMenu(DataRow A_0) : base(A_0)
		{
			this.oo00OO_0.0o000. = 400;
			this.O_0oO_0o.o_0Oo. = 6;
			this.oo00OO_0.0o000. = "文件";
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
			base.Name = "开始菜单";
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06004EA4 RID: 20132 RVA: 0x00238271 File Offset: 0x00236471
		[Browsable(false)]
		public new string Name
		{
			get
			{
				return "开始菜单";
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06004EA5 RID: 20133 RVA: 0x00238278 File Offset: 0x00236478
		[Browsable(false)]
		public new bool Enabled
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06004EA6 RID: 20134 RVA: 0x0023827B File Offset: 0x0023647B
		[Browsable(false)]
		public new TextImageRelationEnum TextImageRelation
		{
			get
			{
				return TextImageRelationEnum.Automatic;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06004EA7 RID: 20135 RVA: 0x0023827E File Offset: 0x0023647E
		[Browsable(false)]
		public new string LargeImage
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06004EA8 RID: 20136 RVA: 0x00238281 File Offset: 0x00236481
		[Browsable(false)]
		public new string SmallImage
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06004EA9 RID: 20137 RVA: 0x00238284 File Offset: 0x00236484
		// (set) Token: 0x06004EAA RID: 20138 RVA: 0x00238287 File Offset: 0x00236487
		[Browsable(false)]
		public override bool AutoHideText
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06004EAB RID: 20139 RVA: 0x00238289 File Offset: 0x00236489
		// (set) Token: 0x06004EAC RID: 20140 RVA: 0x00238291 File Offset: 0x00236491
		[DisplayName("标题")]
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		public string Text
		{
			get
			{
				return this.oo00OO_0.0o000.;
			}
			set
			{
				this.oo00OO_0.0o000. = value;
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06004EAD RID: 20141 RVA: 0x0023829A File Offset: 0x0023649A
		// (set) Token: 0x06004EAE RID: 20142 RVA: 0x002382A2 File Offset: 0x002364A2
		[DefaultValue(400)]
		[O_Oo00Oo000O0(90.0)]
		[Category("属性")]
		[DisplayName("下拉宽度")]
		public int DropdownWidth
		{
			get
			{
				return this.oo00OO_0.0o000.;
			}
			set
			{
				this.oo00OO_0.0o000. = value;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06004EAF RID: 20143 RVA: 0x002382AB File Offset: 0x002364AB
		// (set) Token: 0x06004EB0 RID: 20144 RVA: 0x002382B3 File Offset: 0x002364B3
		[DisplayName("最近文件个数")]
		[Description("在开始菜单右侧显示最近打开过文件的个数")]
		[DefaultValue(6)]
		[O_Oo00Oo000O0(91.0)]
		[Category("属性")]
		public int RecentFiles
		{
			get
			{
				return this.O_0oO_0o.o_0Oo.;
			}
			set
			{
				this.O_0oO_0o.o_0Oo. = value;
				Main.O0O_.00_O0Oo_.();
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06004EB1 RID: 20145 RVA: 0x002382C1 File Offset: 0x002364C1
		// (set) Token: 0x06004EB2 RID: 20146 RVA: 0x002382C8 File Offset: 0x002364C8
		[Editor(typeof(RibbonItemCollectionEditor), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(102.0)]
		[Category("属性")]
		[DisplayName("右侧项目")]
		public Hashtable RightPaneItems
		{
			get
			{
				return new Hashtable();
			}
			set
			{
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06004EB3 RID: 20147 RVA: 0x002382CA File Offset: 0x002364CA
		// (set) Token: 0x06004EB4 RID: 20148 RVA: 0x002382D1 File Offset: 0x002364D1
		[O_Oo00Oo000O0(103.0)]
		[DisplayName("底部项目")]
		[Editor(typeof(RibbonItemCollectionEditor), typeof(UITypeEditor))]
		[Category("属性")]
		public Hashtable BottomPaneItems
		{
			get
			{
				return new Hashtable();
			}
			set
			{
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06004EB5 RID: 20149 RVA: 0x002382D3 File Offset: 0x002364D3
		// (set) Token: 0x06004EB6 RID: 20150 RVA: 0x002382DB File Offset: 0x002364DB
		[O_Oo00Oo000O0(6.0)]
		[Description("双击鼠标后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Browsable(false)]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString DoubleClick
		{
			get
			{
				return this.oo00OO_0.0o000.;
			}
			set
			{
				this.oo00OO_0.0o000. = value;
			}
		}

		// Token: 0x0400202F RID: 8239
		private int <<EMPTY_NAME>>;

		// Token: 0x04002030 RID: 8240
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002031 RID: 8241
		private int <<EMPTY_NAME>>;

		// Token: 0x04002032 RID: 8242
		private string <<EMPTY_NAME>>;
	}
}
