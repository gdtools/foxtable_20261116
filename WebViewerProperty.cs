using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000178 RID: 376
	internal class WebViewerProperty : ControlPropertyBase
	{
		// Token: 0x060011E3 RID: 4579 RVA: 0x0007FF5A File Offset: 0x0007E15A
		public WebViewerProperty(ControlHolder A_0) : base(A_0)
		{
			this.AreDevToolsEnabled = true;
			this.AreSaveAsEnabled = true;
			this.AreDefaultContextMenusEnabled = true;
			this.AreBrowserAcceleratorKeysEnabled = true;
			this.o_0o0.0OOOo. = (oo00)A_0.ChildControl;
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x0007FF90 File Offset: 0x0007E190
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x0007FF98 File Offset: 0x0007E198
		[Category("基本")]
		[O_Oo00Oo000O0(8.0)]
		[DefaultValue(true)]
		[DisplayName("允许开发者模式")]
		public bool AreDevToolsEnabled { get; set; }

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0007FFA1 File Offset: 0x0007E1A1
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x0007FFA9 File Offset: 0x0007E1A9
		[Category("基本")]
		[DisplayName("允许另存为")]
		[O_Oo00Oo000O0(9.0)]
		[DefaultValue(true)]
		public bool AreSaveAsEnabled { get; set; }

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0007FFB2 File Offset: 0x0007E1B2
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x0007FFBA File Offset: 0x0007E1BA
		[Category("基本")]
		[O_Oo00Oo000O0(10.0)]
		[DisplayName("允许快捷菜单")]
		[DefaultValue(true)]
		public bool AreDefaultContextMenusEnabled { get; set; }

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0007FFC3 File Offset: 0x0007E1C3
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x0007FFCB File Offset: 0x0007E1CB
		[DefaultValue(true)]
		[O_Oo00Oo000O0(11.0)]
		[Category("基本")]
		[DisplayName("允许快捷键")]
		public bool AreBrowserAcceleratorKeysEnabled { get; set; }

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x0007FFD4 File Offset: 0x0007E1D4
		// (set) Token: 0x060011ED RID: 4589 RVA: 0x0007FFDC File Offset: 0x0007E1DC
		[O_Oo00Oo000O0(1.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("导航开始时执行")]
		[oO0oooo("6207")]
		[O0O0oOO00_0OO(true)]
		[Category("导航")]
		public EventString NavigationStarting
		{
			get
			{
				return this.oOooO.ooO_O00.;
			}
			set
			{
				this.oOooO.ooO_O00. = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x0007FFE5 File Offset: 0x0007E1E5
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x0007FFED File Offset: 0x0007E1ED
		[Description("导航结束时执行")]
		[oO0oooo("6213")]
		[O_Oo00Oo000O0(5.0)]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("导航")]
		public EventString NavigationCompleted
		{
			get
			{
				return this.O.O_O0O_0.;
			}
			set
			{
				this.O.O_O0O_0. = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x0007FFF6 File Offset: 0x0007E1F6
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x0007FFFE File Offset: 0x0007E1FE
		[oO0oooo("6209")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(2.0)]
		[Description("Source属性发生变化后触发")]
		[O0O0oOO00_0OO(true)]
		[Category("导航")]
		public EventString SourceChanged
		{
			get
			{
				return this.oO0O_O0.0O.;
			}
			set
			{
				this.oO0O_O0.0O. = value;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x00080007 File Offset: 0x0007E207
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0008000F File Offset: 0x0007E20F
		[Description("发送单个资源请求前触发")]
		[Category("导航")]
		[O_Oo00Oo000O0(2.5)]
		[oO0oooo("6214")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString WebResourceRequested
		{
			get
			{
				return this.o00O00O._.;
			}
			set
			{
				this.o00O00O._. = value;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x00080018 File Offset: 0x0007E218
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x00080020 File Offset: 0x0007E220
		[Description("收到单个资源后执行")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(2.6)]
		[oO0oooo("6224")]
		[Category("导航")]
		public EventString WebResourceResponseReceived
		{
			get
			{
				return this.o0_o__O_O.00.;
			}
			set
			{
				this.o0_o__O_O.00. = value;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00080029 File Offset: 0x0007E229
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x00080031 File Offset: 0x0007E231
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("6212")]
		[Description("页面 DOM 解析完成后触发")]
		[O_Oo00Oo000O0(4.0)]
		[Category("导航")]
		[O0O0oOO00_0OO(true)]
		public EventString DOMContentLoaded
		{
			get
			{
				return this.O0O_Oo_o.o.;
			}
			set
			{
				this.O0O_Oo_o.o. = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0008003A File Offset: 0x0007E23A
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x00080042 File Offset: 0x0007E242
		[oO0oooo("6210")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("导航")]
		[Description("页面内容开始加载时触发")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(3.0)]
		public EventString ContentLoading
		{
			get
			{
				return this.o_O0o.__.;
			}
			set
			{
				this.o_O0o.__. = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x0008004B File Offset: 0x0007E24B
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x00080053 File Offset: 0x0007E253
		[oO0oooo("")]
		[O_Oo00Oo000O0(7.0)]
		[Description("网页缩放倍数发生变化后触发")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Category("导航")]
		public EventString ZoomFactorChanged
		{
			get
			{
				return this.O0O00._0_O000.;
			}
			set
			{
				this.O0O00._0_O000. = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0008005C File Offset: 0x0007E25C
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x00080064 File Offset: 0x0007E264
		[oO0oooo("6211")]
		[Category("导航")]
		[Description("网页缩放倍数发生变化后触发")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(8.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString HistoryChanged
		{
			get
			{
				return this.Ooo000_o_o._.;
			}
			set
			{
				this.Ooo000_o_o._. = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0008006D File Offset: 0x0007E26D
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x00080075 File Offset: 0x0007E275
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(1.1)]
		[oO0oooo("6208")]
		[Category("导航")]
		[Description("需要打开新的浏览器窗口时触发")]
		[O0O0oOO00_0OO(true)]
		public EventString NewWindowRequested
		{
			get
			{
				return this.o_o00O._.;
			}
			set
			{
				this.o_o00O._. = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x0008007E File Offset: 0x0007E27E
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x00080086 File Offset: 0x0007E286
		[oO0oooo("6225")]
		[Description("收到网页端发来的信息时触发")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("交互")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.0)]
		public EventString WebMessageReceived
		{
			get
			{
				return this.oO.O0_o_Oo____.;
			}
			set
			{
				this.oO.O0_o_Oo____. = value;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x0008008F File Offset: 0x0007E28F
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x00080097 File Offset: 0x0007E297
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(1.0)]
		[Description("即将显示上下文菜单时触发")]
		[Category("交互")]
		[O0O0oOO00_0OO(true)]
		[oO0oooo("6397")]
		public EventString ContextMenuRequested
		{
			get
			{
				return this.o.oo0o.;
			}
			set
			{
				this.o.oo0o. = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x000800A0 File Offset: 0x0007E2A0
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x000800A8 File Offset: 0x0007E2A8
		[Category("交互")]
		[oO0oooo("6269")]
		[O_Oo00Oo000O0(2.0)]
		[Description("状态栏文本发生变化时执行")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString StatusBarTextChanged
		{
			get
			{
				return this.O__0._O.;
			}
			set
			{
				this.O__0._O. = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x000800B1 File Offset: 0x0007E2B1
		// (set) Token: 0x06001207 RID: 4615 RVA: 0x000800B9 File Offset: 0x0007E2B9
		[oO0oooo("6270")]
		[Category("交互")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(3.0)]
		[Description("JavaScript对话框显示前执行")]
		[O0O0oOO00_0OO(true)]
		public EventString ScriptDialogOpening
		{
			get
			{
				return this.o_.Oooo_O0o.;
			}
			set
			{
				this.o_.Oooo_O0o. = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x000800C2 File Offset: 0x0007E2C2
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x000800CA File Offset: 0x0007E2CA
		[Category("下载")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("6991")]
		[Description("开始下载文件时触发")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(1.0)]
		public EventString DownloadStarting
		{
			get
			{
				return this.OO._oOo0o0OO.;
			}
			set
			{
				this.OO._oOo0o0OO. = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x000800D3 File Offset: 0x0007E2D3
		// (set) Token: 0x0600120B RID: 4619 RVA: 0x000800DB File Offset: 0x0007E2DB
		[Category("下载")]
		[Description("文件下载状态发生改变后触发")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("6990")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(2.0)]
		public EventString DownloadStateChanged
		{
			get
			{
				return this.O0_o.o_00_0oO.;
			}
			set
			{
				this.O0_o.o_00_0oO. = value;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x000800E4 File Offset: 0x0007E2E4
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x000800EC File Offset: 0x0007E2EC
		[Category("下载")]
		[O0O0oOO00_0OO(true)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("6989")]
		[O_Oo00Oo000O0(3.0)]
		[Description("下载进度发生变化后触发，1秒最多触发1次")]
		public EventString DownloadProgressChanged
		{
			get
			{
				return this.o00_oo.Oo0Oo_.;
			}
			set
			{
				this.o00_oo.Oo0Oo_. = value;
			}
		}

		// Token: 0x040006D6 RID: 1750
		private oo00 <<EMPTY_NAME>>;

		// Token: 0x040006D7 RID: 1751
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006D8 RID: 1752
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006D9 RID: 1753
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006DA RID: 1754
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006DB RID: 1755
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006DC RID: 1756
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006DD RID: 1757
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006DE RID: 1758
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006DF RID: 1759
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006E0 RID: 1760
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006E1 RID: 1761
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006E2 RID: 1762
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006E3 RID: 1763
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006E4 RID: 1764
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006E5 RID: 1765
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006E6 RID: 1766
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006E7 RID: 1767
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006E8 RID: 1768
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006E9 RID: 1769
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006EA RID: 1770
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040006EB RID: 1771
		private EventString <<EMPTY_NAME>>;
	}
}
