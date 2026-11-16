using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using C1.Win.C1GanttView;

namespace Foxtable
{
	// Token: 0x02000173 RID: 371
	internal class GanttViewProperty : ControlPropertyBase
	{
		// Token: 0x060010F4 RID: 4340 RVA: 0x0007EECA File Offset: 0x0007D0CA
		internal GanttViewProperty(ControlHolder A_0) : base(A_0)
		{
			this.O0_oO0.o_o. = (GanttView)A_0.ChildControl;
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x0007EEE4 File Offset: 0x0007D0E4
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x0007EF24 File Offset: 0x0007D124
		[Browsable(false)]
		public string Settings
		{
			get
			{
				string tempFileName = Path.GetTempFileName();
				this.O0_oO0.o_o..SaveXml(tempFileName, Encoding.UTF8);
				string result = OO_00oOO.FileSys.ReadAllText(tempFileName, Encoding.UTF8);
				OO_00oOO.FileSys.DeleteFile(tempFileName);
				return result;
			}
			set
			{
				((ISupportInitialize)this.O0_oO0.o_o.).BeginInit();
				this.O0_oO0.o_o..BeginUpdate();
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(value);
				this.O0_oO0.o_o..LoadXml(xmlDocument);
				this.O0_oO0.o_o..EndUpdate();
				((ISupportInitialize)this.O0_oO0.o_o.).EndInit();
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0007EF76 File Offset: 0x0007D176
		[Category("基本")]
		[OooO0(true)]
		[Editor("C1.Win.C1GanttView.Design.ColumnCollectionEditor, C1.Win.C1GanttView.4.Design", typeof(UITypeEditor))]
		[DisplayName("表格列")]
		[O_Oo00Oo000O0(5.0)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ColumnCollection Columns
		{
			get
			{
				return this.O0_oO0.o_o..Columns;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x0007EF83 File Offset: 0x0007D183
		[OooO0(true)]
		[O_Oo00Oo000O0(6.0)]
		[Editor("C1.Win.C1GanttView.Design.BarStyleCollectionEditor, C1.Win.C1GanttView.4.Design", typeof(UITypeEditor))]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Category("基本")]
		[DisplayName("默认样式")]
		public BarStyleCollection BarStyles
		{
			get
			{
				return this.O0_oO0.o_o..BarStyles;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0007EF90 File Offset: 0x0007D190
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x0007EF9D File Offset: 0x0007D19D
		[OooO0(true)]
		[O_Oo00Oo000O0(6.9)]
		[Category("基本")]
		[DisplayName("表格宽度")]
		public int GridWidth
		{
			get
			{
				return this.O0_oO0.o_o..GridWidth;
			}
			set
			{
				this.O0_oO0.o_o..GridWidth = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0007EFAB File Offset: 0x0007D1AB
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x0007EFB8 File Offset: 0x0007D1B8
		[O_Oo00Oo000O0(7.0)]
		[Category("基本")]
		[DisplayName("显示工具栏")]
		public bool ShowToolBar
		{
			get
			{
				return this.O0_oO0.o_o..ShowToolbar;
			}
			set
			{
				this.O0_oO0.o_o..ShowToolbar = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0007EFC6 File Offset: 0x0007D1C6
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0007EFD3 File Offset: 0x0007D1D3
		[DisplayName("边框")]
		[Category("外观")]
		[OooO0(true)]
		[O_Oo00Oo000O0(0.0)]
		public BorderStyle BorderStyle
		{
			get
			{
				return this.O0_oO0.o_o..BorderStyle;
			}
			set
			{
				this.O0_oO0.o_o..BorderStyle = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0007EFE1 File Offset: 0x0007D1E1
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x0007EFEE File Offset: 0x0007D1EE
		[Description("显示前驱任务和后续任务之间的连接线")]
		[O_Oo00Oo000O0(1.0)]
		[OooO0(true)]
		[Category("配色")]
		public bool ShowLinks
		{
			get
			{
				return this.O0_oO0.o_o..ShowLinks;
			}
			set
			{
				this.O0_oO0.o_o..ShowLinks = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x0007EFFC File Offset: 0x0007D1FC
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x0007F009 File Offset: 0x0007D209
		[Description("是否用不同的背景颜色绘制非工作日")]
		[OooO0(true)]
		[O_Oo00Oo000O0(2.0)]
		[Category("配色")]
		public bool ShowNonworkingTime
		{
			get
			{
				return this.O0_oO0.o_o..ShowNonworkingTime;
			}
			set
			{
				this.O0_oO0.o_o..ShowNonworkingTime = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x0007F017 File Offset: 0x0007D217
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x0007F024 File Offset: 0x0007D224
		[O_Oo00Oo000O0(3.0)]
		[Category("配色")]
		[Description("是否高亮显示项目的起始日期和结束日期")]
		[OooO0(true)]
		public bool ShowStartFinish
		{
			get
			{
				return this.O0_oO0.o_o..ShowStartFinish;
			}
			set
			{
				this.O0_oO0.o_o..ShowStartFinish = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x0007F032 File Offset: 0x0007D232
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x0007F03F File Offset: 0x0007D23F
		[Description("是否高亮显示今天的日期")]
		[Category("配色")]
		[O_Oo00Oo000O0(4.0)]
		[OooO0(true)]
		public bool ShowToday
		{
			get
			{
				return this.O0_oO0.o_o..ShowToday;
			}
			set
			{
				this.O0_oO0.o_o..ShowToday = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x0007F04D File Offset: 0x0007D24D
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x0007F05A File Offset: 0x0007D25A
		[Description("任务条文本字体")]
		[Category("配色")]
		[O_Oo00Oo000O0(5.0)]
		[OooO0(true)]
		public Font BarTextFont
		{
			get
			{
				return this.O0_oO0.o_o..BarTextFont;
			}
			set
			{
				this.O0_oO0.o_o..BarTextFont = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0007F068 File Offset: 0x0007D268
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x0007F075 File Offset: 0x0007D275
		[Category("配色")]
		[Description("表格文字颜色")]
		[O_Oo00Oo000O0(7.2)]
		public Color GridForeColor
		{
			get
			{
				return this.O0_oO0.o_o..GridForeColor;
			}
			set
			{
				this.O0_oO0.o_o..GridForeColor = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x0007F083 File Offset: 0x0007D283
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x0007F090 File Offset: 0x0007D290
		[Category("配色")]
		[O_Oo00Oo000O0(8.0)]
		[Description("列标题和行号颜色")]
		public Color FixedForeColor
		{
			get
			{
				return this.O0_oO0.o_o..FixedForeColor;
			}
			set
			{
				this.O0_oO0.o_o..FixedForeColor = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x0007F09E File Offset: 0x0007D29E
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x0007F0AB File Offset: 0x0007D2AB
		[O_Oo00Oo000O0(9.0)]
		[Category("配色")]
		[Description("列标题和行号背景颜色")]
		public Color FixedBackColor
		{
			get
			{
				return this.O0_oO0.o_o..FixedBackColor;
			}
			set
			{
				this.O0_oO0.o_o..FixedBackColor = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x0007F0B9 File Offset: 0x0007D2B9
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x0007F0C6 File Offset: 0x0007D2C6
		[Description("表格线颜色")]
		[O_Oo00Oo000O0(9.1)]
		[Category("配色")]
		public Color CellBorderColor
		{
			get
			{
				return this.O0_oO0.o_o..CellBorderColor;
			}
			set
			{
				this.O0_oO0.o_o..CellBorderColor = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x0007F0D4 File Offset: 0x0007D2D4
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x0007F0E1 File Offset: 0x0007D2E1
		[Description("标题行和行号的表格线颜色")]
		[O_Oo00Oo000O0(9.1)]
		[Category("配色")]
		public Color FixedCellBorderColor
		{
			get
			{
				return this.O0_oO0.o_o..FixedCellBorderColor;
			}
			set
			{
				this.O0_oO0.o_o..FixedCellBorderColor = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x0007F0EF File Offset: 0x0007D2EF
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x0007F0FC File Offset: 0x0007D2FC
		[Description("任务条文字颜色")]
		[OooO0(true)]
		[Category("配色")]
		[O_Oo00Oo000O0(11.0)]
		public Color BarTextForeColor
		{
			get
			{
				return this.O0_oO0.o_o..BarTextForeColor;
			}
			set
			{
				this.O0_oO0.o_o..BarTextForeColor = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x0007F10A File Offset: 0x0007D30A
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x0007F117 File Offset: 0x0007D317
		[O_Oo00Oo000O0(12.0)]
		[OooO0(true)]
		[Category("配色")]
		[Description("分组行的背景颜色")]
		public Color GroupBackColor
		{
			get
			{
				return this.O0_oO0.o_o..GroupBackColor;
			}
			set
			{
				this.O0_oO0.o_o..GroupBackColor = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x0007F125 File Offset: 0x0007D325
		// (set) Token: 0x06001118 RID: 4376 RVA: 0x0007F132 File Offset: 0x0007D332
		[O_Oo00Oo000O0(14.0)]
		[Category("配色")]
		[Description("空白区背景颜色")]
		public Color EmptyAreaBackColor
		{
			get
			{
				return this.O0_oO0.o_o..EmptyAreaBackColor;
			}
			set
			{
				this.O0_oO0.o_o..EmptyAreaBackColor = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x0007F140 File Offset: 0x0007D340
		// (set) Token: 0x0600111A RID: 4378 RVA: 0x0007F14D File Offset: 0x0007D34D
		[O_Oo00Oo000O0(16.0)]
		[Category("配色")]
		[Description("高亮区背景颜色")]
		public Color HighlightBackColor
		{
			get
			{
				return this.O0_oO0.o_o..HighlightBackColor;
			}
			set
			{
				this.O0_oO0.o_o..HighlightBackColor = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x0007F15B File Offset: 0x0007D35B
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x0007F168 File Offset: 0x0007D368
		[Category("配色")]
		[O_Oo00Oo000O0(17.0)]
		[Description("高亮区文字颜色")]
		public Color HighlightForeColor
		{
			get
			{
				return this.O0_oO0.o_o..HighlightForeColor;
			}
			set
			{
				this.O0_oO0.o_o..HighlightForeColor = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x0007F176 File Offset: 0x0007D376
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x0007F183 File Offset: 0x0007D383
		[O_Oo00Oo000O0(18.0)]
		[Category("配色")]
		[Description("拖动任务条时拖动框的颜色")]
		[OooO0(true)]
		public Color MarqueeColor
		{
			get
			{
				return this.O0_oO0.o_o..MarqueeColor;
			}
			set
			{
				this.O0_oO0.o_o..MarqueeColor = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x0007F191 File Offset: 0x0007D391
		// (set) Token: 0x06001120 RID: 4384 RVA: 0x0007F19E File Offset: 0x0007D39E
		[O_Oo00Oo000O0(19.0)]
		[OooO0(true)]
		[Category("配色")]
		[Description("非工作日的背景颜色")]
		public Color NonworkingTimeColor
		{
			get
			{
				return this.O0_oO0.o_o..NonworkingTimeColor;
			}
			set
			{
				this.O0_oO0.o_o..NonworkingTimeColor = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x0007F1AC File Offset: 0x0007D3AC
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x0007F1B9 File Offset: 0x0007D3B9
		[OooO0(true)]
		[O_Oo00Oo000O0(20.0)]
		[Category("配色")]
		[Description("项目开始日线和结束日线的颜色")]
		public Color StartFinishLineColor
		{
			get
			{
				return this.O0_oO0.o_o..StartFinishLineColor;
			}
			set
			{
				this.O0_oO0.o_o..StartFinishLineColor = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0007F1C7 File Offset: 0x0007D3C7
		// (set) Token: 0x06001124 RID: 4388 RVA: 0x0007F1D4 File Offset: 0x0007D3D4
		[O_Oo00Oo000O0(21.0)]
		[Category("配色")]
		[Description("今日时间线的颜色")]
		[OooO0(true)]
		public Color TodayLineColor
		{
			get
			{
				return this.O0_oO0.o_o..TodayLineColor;
			}
			set
			{
				this.O0_oO0.o_o..TodayLineColor = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0007F1E2 File Offset: 0x0007D3E2
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x0007F1EF File Offset: 0x0007D3EF
		[O_Oo00Oo000O0(22.0)]
		[Category("配色")]
		[Description("工具栏背景颜色")]
		public Color ToolbarBackColor
		{
			get
			{
				return this.O0_oO0.o_o..ToolbarBackColor;
			}
			set
			{
				this.O0_oO0.o_o..ToolbarBackColor = value;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0007F1FD File Offset: 0x0007D3FD
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x0007F20A File Offset: 0x0007D40A
		[Category("配色")]
		[O_Oo00Oo000O0(23.0)]
		[Description("表格和甘特图之间的分隔条的颜色")]
		public Color SplitterColor
		{
			get
			{
				return this.O0_oO0.o_o..SplitterColor;
			}
			set
			{
				this.O0_oO0.o_o..SplitterColor = value;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0007F218 File Offset: 0x0007D418
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x0007F220 File Offset: 0x0007D420
		[Description("编辑任务后触发")]
		[O_Oo00Oo000O0(1.0)]
		[Category("GanttView事件")]
		[O0O0oOO00_0OO(true)]
		[oO0oooo("4043")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		public EventString AfterEditTask
		{
			get
			{
				return this.oOo.00.;
			}
			set
			{
				this.oOo.00. = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0007F229 File Offset: 0x0007D429
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0007F231 File Offset: 0x0007D431
		[Category("GanttView事件")]
		[oO0oooo("4043")]
		[O_Oo00Oo000O0(2.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("编辑任务前触发")]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeEditTask
		{
			get
			{
				return this.oO__00o_0o._.;
			}
			set
			{
				this.oO__00o_0o._. = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x0007F23A File Offset: 0x0007D43A
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x0007F242 File Offset: 0x0007D442
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(3.0)]
		[Category("GanttView事件")]
		[oO0oooo("4043")]
		[Description("增加任务前触发")]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeAddTask
		{
			get
			{
				return this.oOoO.____0_O_O.;
			}
			set
			{
				this.oOoO.____0_O_O. = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x0007F24B File Offset: 0x0007D44B
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x0007F253 File Offset: 0x0007D453
		[oO0oooo("4043")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("删除任务前触发")]
		[O_Oo00Oo000O0(4.0)]
		[Category("GanttView事件")]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeRemoveTask
		{
			get
			{
				return this.OO0O0_.O0oo_o.;
			}
			set
			{
				this.OO0O0_.O0oo_o. = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0007F25C File Offset: 0x0007D45C
		// (set) Token: 0x06001132 RID: 4402 RVA: 0x0007F264 File Offset: 0x0007D464
		[Category("GanttView事件")]
		[oO0oooo("4043")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(5.0)]
		[Description("移动任务前触发")]
		public EventString BeforeMoveTasks
		{
			get
			{
				return this.OoO_.0_0O.;
			}
			set
			{
				this.OoO_.0_0O. = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x0007F26D File Offset: 0x0007D46D
		// (set) Token: 0x06001134 RID: 4404 RVA: 0x0007F275 File Offset: 0x0007D475
		[oO0oooo("4043")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("GanttView事件")]
		[Description("单击任务条后触发")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(6.0)]
		public EventString TaskBarClick
		{
			get
			{
				return this.o0o.0o_o0o__00.;
			}
			set
			{
				this.o0o.0o_o0o__00. = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x0007F27E File Offset: 0x0007D47E
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x0007F286 File Offset: 0x0007D486
		[Category("GanttView事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("单击任务条后触发")]
		[oO0oooo("4043")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(7.0)]
		public EventString SelectedIndexChanged
		{
			get
			{
				return this.OO._o0_o0O000.;
			}
			set
			{
				this.OO._o0_o0O000. = value;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x0007F28F File Offset: 0x0007D48F
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x0007F297 File Offset: 0x0007D497
		[oO0oooo("4043")]
		[Category("GanttView事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(7.0)]
		[O0O0oOO00_0OO(true)]
		[Description("显示任务提示信息时触发")]
		public EventString TaskBarTooltip
		{
			get
			{
				return this.O_oO__o.O_.;
			}
			set
			{
				this.O_oO__o.O_. = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0007F2A0 File Offset: 0x0007D4A0
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x0007F2A8 File Offset: 0x0007D4A8
		[Category("GanttView事件")]
		[O_Oo00Oo000O0(8.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("4043")]
		[Description("绘制单元格时触发")]
		[O0O0oOO00_0OO(true)]
		public EventString PaintDay
		{
			get
			{
				return this.ooO._O0_O.;
			}
			set
			{
				this.ooO._O0_O. = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x0007F2B1 File Offset: 0x0007D4B1
		// (set) Token: 0x0600113C RID: 4412 RVA: 0x0007F2B9 File Offset: 0x0007D4B9
		[oO0oooo("4043")]
		[Description("单击工具栏按钮后触发")]
		[Category("GanttView事件")]
		[DisplayName("StripItemClik")]
		[O_Oo00Oo000O0(9.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString GannttStripItemClik
		{
			get
			{
				return this.OOO.Oo.;
			}
			set
			{
				this.OOO.Oo. = value;
			}
		}

		// Token: 0x04000693 RID: 1683
		internal GanttView <<EMPTY_NAME>>;

		// Token: 0x04000694 RID: 1684
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000695 RID: 1685
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000696 RID: 1686
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000697 RID: 1687
		public EventString <<EMPTY_NAME>>;

		// Token: 0x04000698 RID: 1688
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000699 RID: 1689
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400069A RID: 1690
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400069B RID: 1691
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400069C RID: 1692
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400069D RID: 1693
		private EventString <<EMPTY_NAME>>;
	}
}
