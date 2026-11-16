using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000425 RID: 1061
	[EditorBrowsable(EditorBrowsableState.Never)]
	[OoO0___o("Table")]
	public class TableGridProperty : PropertyBase
	{
		// Token: 0x0600479E RID: 18334 RVA: 0x001F3D30 File Offset: 0x001F1F30
		internal TableGridProperty(ControlHolder A_0) : base(A_0)
		{
			this.OOooOOo_.0_0_o. = true;
			this.o0__o.ooO. = true;
			this.O_0_._0o. = true;
			this.o_0o0_._0. = true;
			this.oOo_0o0.O00o. = GridLineDirectionEnum.Both;
			this.oOo_0o0.O00o. = SystemColors.Control;
			this.O_0_._0o. = "(default)";
			this.o00o_0_o_.O0. = Color.FloralWhite;
			this.O0O0Ooo.0oO. = SystemColors.ControlText;
			this.O0.0O__OOOOOOO. = true;
			this.o_o_._O. = true;
			this.O0O0Ooo.0oO. = 1;
			this.OOooOOo_.0_0_o. = (oOo__OO_)A_0.ChildControl;
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x0600479F RID: 18335 RVA: 0x001F3DB9 File Offset: 0x001F1FB9
		// (set) Token: 0x060047A0 RID: 18336 RVA: 0x001F3DC1 File Offset: 0x001F1FC1
		[O_Oo00Oo000O0(5.1)]
		[Category("外观")]
		[Description("是否突出显示选定行")]
		[DisplayName("整行突出")]
		public bool ListMode
		{
			get
			{
				return this.o_o.___.;
			}
			set
			{
				this.o_o.___. = value;
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x060047A1 RID: 18337 RVA: 0x001F3DCA File Offset: 0x001F1FCA
		// (set) Token: 0x060047A2 RID: 18338 RVA: 0x001F3DD7 File Offset: 0x001F1FD7
		[MergableProperty(false)]
		[DisplayName("Tab键顺序")]
		[Description("确定用户按Tab键时，该控件获得焦点的顺序。")]
		[O_Oo00Oo000O0(3.0)]
		[Category("杂项")]
		public int TabIndex
		{
			get
			{
				return this.o_0_.Oo..TabIndex;
			}
			set
			{
				this.o_0_.Oo..TabIndex = value;
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x060047A3 RID: 18339 RVA: 0x001F3DE5 File Offset: 0x001F1FE5
		// (set) Token: 0x060047A4 RID: 18340 RVA: 0x001F3DED File Offset: 0x001F1FED
		[DefaultValue(0)]
		[O_Oo00Oo000O0(1.9)]
		[Category("基本")]
		[DisplayName("类型")]
		public TableTypeEnum TableType
		{
			get
			{
				return this.O0Oooo_.O00_o_.;
			}
			set
			{
				this.O0Oooo_.O00_o_. = value;
				if (value == TableTypeEnum.SQLQuery)
				{
					this.o_o_._O. = false;
				}
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x060047A5 RID: 18341 RVA: 0x001F3E01 File Offset: 0x001F2001
		// (set) Token: 0x060047A6 RID: 18342 RVA: 0x001F3E09 File Offset: 0x001F2009
		[O_Oo00Oo000O0(2.0)]
		[Category("基本")]
		[TypeConverter(typeof(ooo_0O0))]
		[DisplayName("绑定表")]
		public string RelationTable
		{
			get
			{
				return this.O0Oooo_.O00_o_.;
			}
			set
			{
				this.O0Oooo_.O00_o_. = value;
				this.OOooOOo_.0_0_o..ooO.Oo000_.(value);
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x060047A7 RID: 18343 RVA: 0x001F3E1E File Offset: 0x001F201E
		// (set) Token: 0x060047A8 RID: 18344 RVA: 0x001F3E26 File Offset: 0x001F2026
		[TypeConverter(typeof(OOO__oooOOo))]
		[O_Oo00Oo000O0(2.1)]
		[Category("基本")]
		[DisplayName("数据源")]
		public string Connection
		{
			get
			{
				return this.o00o_0_o_.O0.;
			}
			set
			{
				this.o00o_0_o_.O0. = value;
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x060047A9 RID: 18345 RVA: 0x001F3E2F File Offset: 0x001F202F
		// (set) Token: 0x060047AA RID: 18346 RVA: 0x001F3E37 File Offset: 0x001F2037
		[O_Oo00Oo000O0(2.2)]
		[Editor(typeof(o0O_O__o000), typeof(UITypeEditor))]
		[DisplayName("Select语句")]
		[Category("基本")]
		public string SelectString
		{
			get
			{
				return this.o0_.oo__0__00o.;
			}
			set
			{
				this.o0_.oo__0__00o. = value;
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x060047AB RID: 18347 RVA: 0x001F3E40 File Offset: 0x001F2040
		// (set) Token: 0x060047AC RID: 18348 RVA: 0x001F3E96 File Offset: 0x001F2096
		[O_Oo00Oo000O0(2.3)]
		[DisplayName("作为副本")]
		[DefaultValue(false)]
		[Category("基本")]
		public bool IsCopy
		{
			get
			{
				return (Operators.CompareString(this.RelationTable, "", true) <= 0 || !OO_00oOO.Tables.get_Contains(this.RelationTable) || !OO_00oOO.Tables[this.RelationTable].IsRelation) && this.oOOooo0.0.;
			}
			set
			{
				this.oOOooo0.0. = value;
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x060047AD RID: 18349 RVA: 0x001F3E9F File Offset: 0x001F209F
		// (set) Token: 0x060047AE RID: 18350 RVA: 0x001F3EA7 File Offset: 0x001F20A7
		[DisplayName("允许编辑")]
		[Category("基本")]
		[O_Oo00Oo000O0(2.4)]
		public bool AllowEdit
		{
			get
			{
				return this.o_o_._O.;
			}
			set
			{
				this.o_o_._O. = value;
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x060047AF RID: 18351 RVA: 0x001F3EB0 File Offset: 0x001F20B0
		// (set) Token: 0x060047B0 RID: 18352 RVA: 0x001F3EB8 File Offset: 0x001F20B8
		[O_Oo00Oo000O0(2.5)]
		[DisplayName("允许单击排序")]
		[Category("杂项")]
		[Description("是否启动单击列标题自动排序的功能")]
		public bool AllowClickSort
		{
			get
			{
				return this.o_O00oO_o.OO.;
			}
			set
			{
				this.o_O00oO_o.OO. = value;
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x060047B1 RID: 18353 RVA: 0x001F3EC1 File Offset: 0x001F20C1
		// (set) Token: 0x060047B2 RID: 18354 RVA: 0x001F3EC9 File Offset: 0x001F20C9
		[Editor(typeof(O0_OoO_O), typeof(UITypeEditor))]
		[DisplayName("显示列")]
		[O_Oo00Oo000O0(5.0)]
		[Category("基本")]
		[MergableProperty(false)]
		[Description("批量设置要显示的列及其列宽，例如：日期|90|产品|120|客户|120|数量|60。")]
		public string ColumnList
		{
			get
			{
				return this.O_.0Oo_O.;
			}
			set
			{
				this.O_.0Oo_O. = value;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x060047B3 RID: 18355 RVA: 0x001F3ED2 File Offset: 0x001F20D2
		// (set) Token: 0x060047B4 RID: 18356 RVA: 0x001F3EDA File Offset: 0x001F20DA
		[DefaultValue("(default)")]
		[O_Oo00Oo000O0(0.0)]
		[Category("外观")]
		[TypeConverter(typeof(o00))]
		[DisplayName("样式")]
		public string Theme
		{
			get
			{
				return this.O_0_._0o.;
			}
			set
			{
				this.O_0_._0o. = value;
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x060047B5 RID: 18357 RVA: 0x001F3EE3 File Offset: 0x001F20E3
		// (set) Token: 0x060047B6 RID: 18358 RVA: 0x001F3EF5 File Offset: 0x001F20F5
		[DefaultValue("宋体,9")]
		[Category("外观")]
		[DisplayName("字体")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(1.0)]
		public virtual Font Font
		{
			get
			{
				return this.o_0_.Oo..ChildControl.Font;
			}
			set
			{
				this.o_0_.Oo..ChildControl.Font = (Font)value.Clone();
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x060047B7 RID: 18359 RVA: 0x001F3F12 File Offset: 0x001F2112
		// (set) Token: 0x060047B8 RID: 18360 RVA: 0x001F3F1A File Offset: 0x001F211A
		[DisplayName("显示行号列")]
		[O_Oo00Oo000O0(2.0)]
		[Category("外观")]
		public bool RowHeaderVisible
		{
			get
			{
				return this.o_0o0_._0.;
			}
			set
			{
				this.o_0o0_._0. = value;
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x060047B9 RID: 18361 RVA: 0x001F3F23 File Offset: 0x001F2123
		// (set) Token: 0x060047BA RID: 18362 RVA: 0x001F3F2B File Offset: 0x001F212B
		[Category("外观")]
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("显示复选框")]
		public bool ShowCheckBox
		{
			get
			{
				return this.oo_O.oOo_0o_O.;
			}
			set
			{
				this.oo_O.oOo_0o_O. = value;
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x060047BB RID: 18363 RVA: 0x001F3F34 File Offset: 0x001F2134
		// (set) Token: 0x060047BC RID: 18364 RVA: 0x001F3F3C File Offset: 0x001F213C
		[DisplayName("网格线方向")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(4.0)]
		[Category("外观")]
		public GridLineDirectionEnum GridLineDirection
		{
			get
			{
				return this.oOo_0o0.O00o.;
			}
			set
			{
				this.oOo_0o0.O00o. = value;
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x001F3F45 File Offset: 0x001F2145
		// (set) Token: 0x060047BE RID: 18366 RVA: 0x001F3F4D File Offset: 0x001F214D
		[Category("外观")]
		[DisplayName("网格线颜色")]
		[O_Oo00Oo000O0(5.0)]
		public Color GridColor
		{
			get
			{
				return this.oOo_0o0.O00o.;
			}
			set
			{
				this.oOo_0o0.O00o. = value;
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x060047BF RID: 18367 RVA: 0x001F3F56 File Offset: 0x001F2156
		// (set) Token: 0x060047C0 RID: 18368 RVA: 0x001F3F5E File Offset: 0x001F215E
		[DisplayName("网格线宽度")]
		[O_Oo00Oo000O0(5.01)]
		[DefaultValue(1)]
		[Category("外观")]
		public int BorderWidth
		{
			get
			{
				return this.O0O0Ooo.0oO.;
			}
			set
			{
				this.O0O0Ooo.0oO. = value;
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x001F3F67 File Offset: 0x001F2167
		// (set) Token: 0x060047C2 RID: 18370 RVA: 0x001F3F6F File Offset: 0x001F216F
		[Category("外观")]
		[O_Oo00Oo000O0(5.11)]
		[DisplayName("显示焦点框")]
		[Description("是否显示焦点框")]
		public bool FocusRect
		{
			get
			{
				return this.O0.0O__OOOOOOO.;
			}
			set
			{
				this.O0.0O__OOOOOOO. = value;
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x060047C3 RID: 18371 RVA: 0x001F3F78 File Offset: 0x001F2178
		// (set) Token: 0x060047C4 RID: 18372 RVA: 0x001F3F80 File Offset: 0x001F2180
		[O_Oo00Oo000O0(6.0)]
		[Category("外观")]
		[DisplayName("选定行背景颜色")]
		[Description("列表模式下的选定行背景颜色。")]
		public Color CurrentRowBackColor
		{
			get
			{
				return this.o00o_0_o_.O0.;
			}
			set
			{
				this.o00o_0_o_.O0. = value;
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x060047C5 RID: 18373 RVA: 0x001F3F89 File Offset: 0x001F2189
		// (set) Token: 0x060047C6 RID: 18374 RVA: 0x001F3F91 File Offset: 0x001F2191
		[DisplayName("选定行字体颜色")]
		[O_Oo00Oo000O0(7.0)]
		[Category("外观")]
		[Description("列表模式下的选定行字体颜色。")]
		public Color CurrentRowForeColor
		{
			get
			{
				return this.O0O0Ooo.0oO.;
			}
			set
			{
				this.O0O0Ooo.0oO. = value;
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x060047C7 RID: 18375 RVA: 0x001F3F9A File Offset: 0x001F219A
		// (set) Token: 0x060047C8 RID: 18376 RVA: 0x001F3FA2 File Offset: 0x001F21A2
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.0)]
		[DefaultValue(true)]
		[Category("杂项")]
		[DisplayName("可见")]
		public bool Visible
		{
			get
			{
				return this.OOooOOo_.0_0_o.;
			}
			set
			{
				this.OOooOOo_.0_0_o. = value;
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x060047C9 RID: 18377 RVA: 0x001F3FAB File Offset: 0x001F21AB
		// (set) Token: 0x060047CA RID: 18378 RVA: 0x001F3FB8 File Offset: 0x001F21B8
		[Category("位置")]
		[O_Oo00Oo000O0(1.0)]
		[MergableProperty(true)]
		[DisplayName("左")]
		public int Left
		{
			get
			{
				return this.o_0_.Oo..Left;
			}
			set
			{
				this.o_0_.Oo..Left = value;
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x060047CB RID: 18379 RVA: 0x001F3FC6 File Offset: 0x001F21C6
		// (set) Token: 0x060047CC RID: 18380 RVA: 0x001F3FD3 File Offset: 0x001F21D3
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("上")]
		[MergableProperty(true)]
		[Category("位置")]
		public int Top
		{
			get
			{
				return this.o_0_.Oo..Top;
			}
			set
			{
				this.o_0_.Oo..Top = value;
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x060047CD RID: 18381 RVA: 0x001F3FE1 File Offset: 0x001F21E1
		// (set) Token: 0x060047CE RID: 18382 RVA: 0x001F3FEE File Offset: 0x001F21EE
		[DisplayName("宽")]
		[O_Oo00Oo000O0(3.0)]
		[MergableProperty(true)]
		[Category("位置")]
		public int Width
		{
			get
			{
				return this.o_0_.Oo..Width;
			}
			set
			{
				if (!this.o_0_.Oo..IsFixedWidth)
				{
					this.o_0_.Oo..Width = value;
				}
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x060047CF RID: 18383 RVA: 0x001F4009 File Offset: 0x001F2209
		// (set) Token: 0x060047D0 RID: 18384 RVA: 0x001F4016 File Offset: 0x001F2216
		[Category("位置")]
		[O_Oo00Oo000O0(4.0)]
		[MergableProperty(true)]
		[DisplayName("高")]
		public int Height
		{
			get
			{
				return this.o_0_.Oo..Height;
			}
			set
			{
				if (!this.o_0_.Oo..IsFixedHeight)
				{
					this.o_0_.Oo..Height = value;
				}
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x060047D1 RID: 18385 RVA: 0x001F4031 File Offset: 0x001F2231
		// (set) Token: 0x060047D2 RID: 18386 RVA: 0x001F403E File Offset: 0x001F223E
		[DefaultValue(5)]
		[DisplayName("锚定")]
		[O_Oo00Oo000O0(5.0)]
		[Description("在调整容器大小时，使控件的指定边缘和容器边缘的距离保持不变。")]
		[Category("位置")]
		[MergableProperty(true)]
		public AnchorStyles Anchor
		{
			get
			{
				return this.o_0_.Oo..Anchor;
			}
			set
			{
				this.o_0_.Oo..Anchor = value;
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x060047D3 RID: 18387 RVA: 0x001F404C File Offset: 0x001F224C
		// (set) Token: 0x060047D4 RID: 18388 RVA: 0x001F4059 File Offset: 0x001F2259
		[O_Oo00Oo000O0(5.1)]
		[DefaultValue(0)]
		[MergableProperty(true)]
		[DisplayName("停靠")]
		[Category("位置")]
		[Description("停靠到容器的指定边框。")]
		public DockStyle Dock
		{
			get
			{
				return this.o_0_.Oo..Dock;
			}
			set
			{
				this.o_0_.Oo..Dock = value;
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x060047D5 RID: 18389 RVA: 0x001F4067 File Offset: 0x001F2267
		// (set) Token: 0x060047D6 RID: 18390 RVA: 0x001F406F File Offset: 0x001F226F
		[Description("打印窗口时是否打印此控件。")]
		[DisplayName("允许打印")]
		[O_Oo00Oo000O0(10.0)]
		[DefaultValue(true)]
		[Category("输出")]
		[MergableProperty(true)]
		public bool Printable
		{
			get
			{
				return this.o0__o.ooO.;
			}
			set
			{
				this.o0__o.ooO. = value;
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x060047D7 RID: 18391 RVA: 0x001F4078 File Offset: 0x001F2278
		// (set) Token: 0x060047D8 RID: 18392 RVA: 0x001F4080 File Offset: 0x001F2280
		[Category("输出")]
		[MergableProperty(true)]
		[Description("打印时是否从此控件开始另起一页。")]
		[DefaultValue(false)]
		[DisplayName("另起一页")]
		[O_Oo00Oo000O0(10.1)]
		public bool NewPage
		{
			get
			{
				return this.oOo.0OO0O_O.;
			}
			set
			{
				this.oOo.0OO0O_O. = value;
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x060047D9 RID: 18393 RVA: 0x001F4089 File Offset: 0x001F2289
		// (set) Token: 0x060047DA RID: 18394 RVA: 0x001F4091 File Offset: 0x001F2291
		[Description("设置最少行数，不够自动补空行。")]
		[DisplayName("最少行数")]
		[O_Oo00Oo000O0(12.0)]
		[DefaultValue(0)]
		[Category("输出")]
		[MergableProperty(true)]
		public int MinRows
		{
			get
			{
				return this.o.00OO.;
			}
			set
			{
				this.o.00OO. = value;
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x060047DB RID: 18395 RVA: 0x001F409A File Offset: 0x001F229A
		// (set) Token: 0x060047DC RID: 18396 RVA: 0x001F40A2 File Offset: 0x001F22A2
		[DefaultValue(0)]
		[O_Oo00Oo000O0(12.1)]
		[DisplayName("最大行数")]
		[Category("输出")]
		[MergableProperty(true)]
		[Description("设置每页最大打印行数，如果设为0，则不限制。")]
		public int MaxRows
		{
			get
			{
				return this.o0__o.ooO.;
			}
			set
			{
				this.o0__o.ooO. = value;
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x060047DD RID: 18397 RVA: 0x001F40AB File Offset: 0x001F22AB
		// (set) Token: 0x060047DE RID: 18398 RVA: 0x001F40B3 File Offset: 0x001F22B3
		[MergableProperty(true)]
		[O_Oo00Oo000O0(13.0)]
		[Category("输出")]
		[DisplayName("打印行号")]
		public bool PrintRowNumber
		{
			get
			{
				return this.O_0_._0o.;
			}
			set
			{
				this.O_0_._0o. = value;
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x060047DF RID: 18399 RVA: 0x001F40BC File Offset: 0x001F22BC
		// (set) Token: 0x060047E0 RID: 18400 RVA: 0x001F40C4 File Offset: 0x001F22C4
		[DefaultValue(false)]
		[O_Oo00Oo000O0(4.001)]
		[Category("杂项")]
		[MergableProperty(true)]
		[DisplayName("最顶层")]
		[Description("设置控件是否位于其它控件之上。")]
		public bool TopMost
		{
			get
			{
				return this.OOOo_OO_0o.0o.;
			}
			set
			{
				this.OOOo_OO_0o.0o. = value;
				if (value)
				{
					this.BackMost = false;
					base.Holder.BringToFront();
				}
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x060047E1 RID: 18401 RVA: 0x001F40E2 File Offset: 0x001F22E2
		// (set) Token: 0x060047E2 RID: 18402 RVA: 0x001F40EA File Offset: 0x001F22EA
		[Category("杂项")]
		[DisplayName("最底层")]
		[MergableProperty(true)]
		[Description("设置控件是否位于其它控件之下。")]
		[O_Oo00Oo000O0(4.002)]
		[DefaultValue(false)]
		public bool BackMost
		{
			get
			{
				return this.oO0_._.;
			}
			set
			{
				this.oO0_._. = value;
				if (value)
				{
					this.TopMost = false;
					base.Holder.SendToBack();
				}
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x060047E3 RID: 18403 RVA: 0x001F4108 File Offset: 0x001F2308
		// (set) Token: 0x060047E4 RID: 18404 RVA: 0x001F4110 File Offset: 0x001F2310
		[Description("进入单元格，准备编辑的时候执行。")]
		[Category("A.编辑")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0605")]
		[O_Oo00Oo000O0(1.0)]
		[O0O0oOO00_0OO(true)]
		public EventString PrepareEdit
		{
			get
			{
				return this.o.00OO.;
			}
			set
			{
				this.o.00OO. = value;
			}
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x060047E5 RID: 18405 RVA: 0x001F4119 File Offset: 0x001F2319
		// (set) Token: 0x060047E6 RID: 18406 RVA: 0x001F4121 File Offset: 0x001F2321
		[oO0oooo("0615")]
		[Description("真正有了编辑单元格动作的时候执行，例如用户通过键盘输入内容，或者用鼠标单击了下拉按钮。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("A.编辑")]
		[O_Oo00Oo000O0(2.0)]
		[O0O0oOO00_0OO(true)]
		public EventString StartEdit
		{
			get
			{
				return this.oo._Oo_.;
			}
			set
			{
				this.oo._Oo_. = value;
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x001F412A File Offset: 0x001F232A
		// (set) Token: 0x060047E8 RID: 18408 RVA: 0x001F4132 File Offset: 0x001F2332
		[Browsable(false)]
		[O0O0oOO00_0OO(true)]
		[Category("A.编辑")]
		[Description("单元格真正进入编辑状态之前执行，此时编辑框(Editor)已经初始化，可以设置其属性。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(2.1)]
		public EventString SetupEditor
		{
			get
			{
				return this.o0_.oo__0__00o.;
			}
			set
			{
				this.o0_.oo__0__00o. = value;
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x060047E9 RID: 18409 RVA: 0x001F413B File Offset: 0x001F233B
		// (set) Token: 0x060047EA RID: 18410 RVA: 0x001F4143 File Offset: 0x001F2343
		[oO0oooo("0617")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("A.编辑")]
		[Description("结束编辑单元格前执行，通常用于验证输入的内容。")]
		[O_Oo00Oo000O0(3.0)]
		[O0O0oOO00_0OO(true)]
		public EventString ValidateEdit
		{
			get
			{
				return this.oo.0_oOO0_O_.;
			}
			set
			{
				this.oo.0_oOO0_O_. = value;
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x060047EB RID: 18411 RVA: 0x001F414C File Offset: 0x001F234C
		// (set) Token: 0x060047EC RID: 18412 RVA: 0x001F4154 File Offset: 0x001F2354
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("结束编辑单元格后执行，通常用于执行一些特定的操作和计算。")]
		[oO0oooo("0616")]
		[Category("A.编辑")]
		[O_Oo00Oo000O0(4.0)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterEdit
		{
			get
			{
				return this.ooO0_._O_o.;
			}
			set
			{
				this.ooO0_._O_o. = value;
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x060047ED RID: 18413 RVA: 0x001F415D File Offset: 0x001F235D
		// (set) Token: 0x060047EE RID: 18414 RVA: 0x001F4165 File Offset: 0x001F2365
		[oO0oooo("0619")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("编辑框中内容发生变化时执行。")]
		[Category("A.编辑")]
		[O_Oo00Oo000O0(4.1)]
		[O0O0oOO00_0OO(true)]
		public EventString ChangeEdit
		{
			get
			{
				return this.o0._0o0o.;
			}
			set
			{
				this.o0._0o0o. = value;
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x060047EF RID: 18415 RVA: 0x001F416E File Offset: 0x001F236E
		// (set) Token: 0x060047F0 RID: 18416 RVA: 0x001F4176 File Offset: 0x001F2376
		[oO0oooo("0620")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("A.编辑")]
		[Description("在编辑框(Editor)输入一字符键时执行。")]
		[O_Oo00Oo000O0(4.2)]
		[O0O0oOO00_0OO(true)]
		public EventString KeyPressEdit
		{
			get
			{
				return this.O_Oo.OOO0_0O00.;
			}
			set
			{
				this.O_Oo.OOO0_0O00. = value;
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x060047F1 RID: 18417 RVA: 0x001F417F File Offset: 0x001F237F
		// (set) Token: 0x060047F2 RID: 18418 RVA: 0x001F4187 File Offset: 0x001F2387
		[oO0oooo("0622")]
		[Category("A.编辑")]
		[Description("在编辑状态时，按下一按键时执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(4.3)]
		[O0O0oOO00_0OO(true)]
		public EventString KeyDownEdit
		{
			get
			{
				return this.O0.0O__OOOOOOO.;
			}
			set
			{
				this.O0.0O__OOOOOOO. = value;
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x060047F3 RID: 18419 RVA: 0x001F4190 File Offset: 0x001F2390
		// (set) Token: 0x060047F4 RID: 18420 RVA: 0x001F4198 File Offset: 0x001F2398
		[Description("在编辑状态时，松开一按键时执行。")]
		[oO0oooo("0623")]
		[Category("A.编辑")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(4.4)]
		[O0O0oOO00_0OO(true)]
		public EventString KeyUpEdit
		{
			get
			{
				return this.o_0ooo._.;
			}
			set
			{
				this.o_0ooo._. = value;
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x060047F5 RID: 18421 RVA: 0x001F41A1 File Offset: 0x001F23A1
		// (set) Token: 0x060047F6 RID: 18422 RVA: 0x001F41A9 File Offset: 0x001F23A9
		[oO0oooo("0642")]
		[Category("A.编辑")]
		[Description("单击单元格按钮后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(4.5)]
		[O0O0oOO00_0OO(true)]
		public EventString CellButtonClick
		{
			get
			{
				return this.OOO0_0_.oo.;
			}
			set
			{
				this.OOO0_0_.oo. = value;
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x060047F7 RID: 18423 RVA: 0x001F41B2 File Offset: 0x001F23B2
		// (set) Token: 0x060047F8 RID: 18424 RVA: 0x001F41BA File Offset: 0x001F23BA
		[oO0oooo("0624")]
		[Description("某一列的内容变化前执行，通常用户验证该列内容。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("B.数据")]
		[DisplayName("DataColChanging")]
		[O_Oo00Oo000O0(5.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataColChanging
		{
			get
			{
				return this.o.OO0o0___.;
			}
			set
			{
				this.o.OO0o0___. = value;
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x060047F9 RID: 18425 RVA: 0x001F41C3 File Offset: 0x001F23C3
		// (set) Token: 0x060047FA RID: 18426 RVA: 0x001F41CB File Offset: 0x001F23CB
		[oO0oooo("0625")]
		[DisplayName("DataColChanged")]
		[Description("某一列的内容变化后执行，通常用于执行一些特定的操作和计算。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("B.数据")]
		[O_Oo00Oo000O0(6.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataColChanged
		{
			get
			{
				return this.O__._OO0.;
			}
			set
			{
				this.O__._OO0. = value;
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x060047FB RID: 18427 RVA: 0x001F41D4 File Offset: 0x001F23D4
		// (set) Token: 0x060047FC RID: 18428 RVA: 0x001F41DC File Offset: 0x001F23DC
		[Description("保存某一行之前执行，通常用于对数据进行保存前的验证！。")]
		[oO0oooo("0628")]
		[Category("B.数据")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(6.1)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeSaveDataRow
		{
			get
			{
				return this.oo0._OOOo.;
			}
			set
			{
				this.oo0._OOOo. = value;
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x060047FD RID: 18429 RVA: 0x001F41E5 File Offset: 0x001F23E5
		// (set) Token: 0x060047FE RID: 18430 RVA: 0x001F41ED File Offset: 0x001F23ED
		[oO0oooo("3755")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("B.数据")]
		[Description("保存某一行之后执行，通常用于对数据进行保存前的验证！。")]
		[O_Oo00Oo000O0(6.1)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterSaveDataRow
		{
			get
			{
				return this.o.O0o0o_0_o.;
			}
			set
			{
				this.o.O0o0o_0_o. = value;
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x060047FF RID: 18431 RVA: 0x001F41F6 File Offset: 0x001F23F6
		// (set) Token: 0x06004800 RID: 18432 RVA: 0x001F41FE File Offset: 0x001F23FE
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0629")]
		[Category("C.增加行")]
		[Description("增加行之前执行。")]
		[O_Oo00Oo000O0(8.1)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeAddDataRow
		{
			get
			{
				return this.oo0OO.0o.;
			}
			set
			{
				this.oo0OO.0o. = value;
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06004801 RID: 18433 RVA: 0x001F4207 File Offset: 0x001F2407
		// (set) Token: 0x06004802 RID: 18434 RVA: 0x001F420F File Offset: 0x001F240F
		[Description("增加一行时执行，此时DataRow还处于孤立状态，并未真正增加到DataTable中。")]
		[oO0oooo("0630")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("C.增加行")]
		[O_Oo00Oo000O0(9.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataRowAdding
		{
			get
			{
				return this.O00o.0o_0o_.;
			}
			set
			{
				this.O00o.0o_0o_. = value;
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x001F4218 File Offset: 0x001F2418
		// (set) Token: 0x06004804 RID: 18436 RVA: 0x001F4220 File Offset: 0x001F2420
		[oO0oooo("0631")]
		[Category("C.增加行")]
		[Description("增加一行后执行，此时DataRow已经真正增加到DataTable中。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(10.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataRowAdded
		{
			get
			{
				return this.oO_.oOO_oo0o.;
			}
			set
			{
				this.oO_.oOO_oo0o. = value;
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x001F4229 File Offset: 0x001F2429
		// (set) Token: 0x06004806 RID: 18438 RVA: 0x001F4231 File Offset: 0x001F2431
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("删除行之前执行。")]
		[oO0oooo("0632")]
		[Category("D.删除行")]
		[O_Oo00Oo000O0(10.1)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeDeleteDataRow
		{
			get
			{
				return this.oOOo._Oooo_o_.;
			}
			set
			{
				this.oOOo._Oooo_o_. = value;
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06004807 RID: 18439 RVA: 0x001F423A File Offset: 0x001F243A
		// (set) Token: 0x06004808 RID: 18440 RVA: 0x001F4242 File Offset: 0x001F2442
		[Category("D.删除行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("删除某一行时执行。")]
		[oO0oooo("0633")]
		[O_Oo00Oo000O0(11.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataRowDeleting
		{
			get
			{
				return this.O00.Ooo0oO__o.;
			}
			set
			{
				this.O00.Ooo0oO__o. = value;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06004809 RID: 18441 RVA: 0x001F424B File Offset: 0x001F244B
		// (set) Token: 0x0600480A RID: 18442 RVA: 0x001F4253 File Offset: 0x001F2453
		[oO0oooo("0634")]
		[Category("D.删除行")]
		[Description("删除某一行之后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(12.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataRowDeleted
		{
			get
			{
				return this.oo._0_ooO000o.;
			}
			set
			{
				this.oo._0_ooO000o. = value;
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x001F425C File Offset: 0x001F245C
		// (set) Token: 0x0600480C RID: 18444 RVA: 0x001F4264 File Offset: 0x001F2464
		[oO0oooo("0635")]
		[Category("E.锁定行")]
		[Description("行的锁定状态发生变化之前执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(13.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataRowLockedChanging
		{
			get
			{
				return this.oOoO.o____o_0.;
			}
			set
			{
				this.oOoO.o____o_0. = value;
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x001F426D File Offset: 0x001F246D
		// (set) Token: 0x0600480E RID: 18446 RVA: 0x001F4275 File Offset: 0x001F2475
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0636")]
		[Category("E.锁定行")]
		[Description("行的锁定状态发生变化之后执行。")]
		[O_Oo00Oo000O0(14.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DataRowLockedChanged
		{
			get
			{
				return this.Oo0.0oo_.;
			}
			set
			{
				this.Oo0.0oo_. = value;
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x0600480F RID: 18447 RVA: 0x001F427E File Offset: 0x001F247E
		// (set) Token: 0x06004810 RID: 18448 RVA: 0x001F4286 File Offset: 0x001F2486
		[oO0oooo("0641")]
		[Category("F.选择")]
		[Description("选择不同记录后执行，也就是Current属性发生变化后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(14.0)]
		[O0O0oOO00_0OO(true)]
		public EventString CurrentChanged
		{
			get
			{
				return this.o0oO._0.;
			}
			set
			{
				this.o0oO._0. = value;
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x001F428F File Offset: 0x001F248F
		// (set) Token: 0x06004812 RID: 18450 RVA: 0x001F4297 File Offset: 0x001F2497
		[Description("选择不同行后执行，也就是Position属性发生变化后执行")]
		[oO0oooo("0640")]
		[Category("F.选择")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(15.0)]
		[O0O0oOO00_0OO(true)]
		public EventString PositionChanged
		{
			get
			{
				return this.oO._O0oo_00.;
			}
			set
			{
				this.oO._O0oo_00. = value;
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06004813 RID: 18451 RVA: 0x001F42A0 File Offset: 0x001F24A0
		// (set) Token: 0x06004814 RID: 18452 RVA: 0x001F42A8 File Offset: 0x001F24A8
		[oO0oooo("0644")]
		[Description("选择不同的单元格前执行，也就是表的RowSel、ColSel属性发生变化前执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("F.选择")]
		[O_Oo00Oo000O0(16.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeSelChange
		{
			get
			{
				return this.oO0._0O_O0oO.;
			}
			set
			{
				this.oO0._0O_O0oO. = value;
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06004815 RID: 18453 RVA: 0x001F42B1 File Offset: 0x001F24B1
		// (set) Token: 0x06004816 RID: 18454 RVA: 0x001F42B9 File Offset: 0x001F24B9
		[oO0oooo("0645")]
		[Category("F.选择")]
		[Description("选择不同的单元格后执行，也就是表的RowSel、ColSel属性发生变化后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(16.1)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterSelChange
		{
			get
			{
				return this.O0O0__.o.;
			}
			set
			{
				this.O0O0__.o. = value;
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06004817 RID: 18455 RVA: 0x001F42C2 File Offset: 0x001F24C2
		// (set) Token: 0x06004818 RID: 18456 RVA: 0x001F42CA File Offset: 0x001F24CA
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0646")]
		[Category("F.选择")]
		[Description("选择不同的区域前执行，也就是表的TopRow、LeftCol、BottomRow、RightCol等属性发生变化前执行。")]
		[O_Oo00Oo000O0(17.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeSelRangeChange
		{
			get
			{
				return this.O.00_oO_OooOoO.;
			}
			set
			{
				this.O.00_oO_OooOoO. = value;
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x001F42D3 File Offset: 0x001F24D3
		// (set) Token: 0x0600481A RID: 18458 RVA: 0x001F42DB File Offset: 0x001F24DB
		[oO0oooo("0647")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("F.选择")]
		[Description("选择不同的区域后执行，也就是表的TopRow、LeftCol、BottomRow、RightCol等属性发生变化后执行。")]
		[O_Oo00Oo000O0(17.1)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterSelRangeChange
		{
			get
			{
				return this.O0o_.o_O.;
			}
			set
			{
				this.O0o_.o_O. = value;
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x0600481B RID: 18459 RVA: 0x001F42E4 File Offset: 0x001F24E4
		// (set) Token: 0x0600481C RID: 18460 RVA: 0x001F42EC File Offset: 0x001F24EC
		[oO0oooo("1639")]
		[Description("修改行复选框状态前执行。")]
		[Category("G.复选")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(19.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeCheckRow
		{
			get
			{
				return this.OO.0_O_OO.;
			}
			set
			{
				this.OO.0_O_OO. = value;
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x0600481D RID: 18461 RVA: 0x001F42F5 File Offset: 0x001F24F5
		// (set) Token: 0x0600481E RID: 18462 RVA: 0x001F42FD File Offset: 0x001F24FD
		[oO0oooo("1640")]
		[Category("G.复选")]
		[Description("修改行复选框状态后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(19.1)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterCheckRow
		{
			get
			{
				return this.Oo.OoO0.;
			}
			set
			{
				this.Oo.OoO0. = value;
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x0600481F RID: 18463 RVA: 0x001F4306 File Offset: 0x001F2506
		// (set) Token: 0x06004820 RID: 18464 RVA: 0x001F430E File Offset: 0x001F250E
		[oO0oooo("1847")]
		[Category("H.调整")]
		[Description("移动行后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(18.0)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterMoveRow
		{
			get
			{
				return this.o0000oO_oo.__o.;
			}
			set
			{
				this.o0000oO_oo.__o. = value;
			}
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06004821 RID: 18465 RVA: 0x001F4317 File Offset: 0x001F2517
		// (set) Token: 0x06004822 RID: 18466 RVA: 0x001F431F File Offset: 0x001F251F
		[oO0oooo("2271")]
		[Category("H.调整")]
		[Description("移动行前执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(17.9)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeMoveRow
		{
			get
			{
				return this.ooO0._oOoo.;
			}
			set
			{
				this.ooO0._oOoo. = value;
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x001F4328 File Offset: 0x001F2528
		// (set) Token: 0x06004824 RID: 18468 RVA: 0x001F4330 File Offset: 0x001F2530
		[oO0oooo("0648")]
		[Category("H.调整")]
		[Description("拖动列之前发生。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(19.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeDragColumn
		{
			get
			{
				return this.Oo_O.__0o_o__O.;
			}
			set
			{
				this.Oo_O.__0o_o__O. = value;
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06004825 RID: 18469 RVA: 0x001F4339 File Offset: 0x001F2539
		// (set) Token: 0x06004826 RID: 18470 RVA: 0x001F4341 File Offset: 0x001F2541
		[oO0oooo("0649")]
		[Category("H.调整")]
		[Description("拖动列之后发生。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(20.0)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterDragColumn
		{
			get
			{
				return this.o.00Oo__oO_o0o.;
			}
			set
			{
				this.o.00Oo__oO_o0o. = value;
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06004827 RID: 18471 RVA: 0x001F434A File Offset: 0x001F254A
		// (set) Token: 0x06004828 RID: 18472 RVA: 0x001F4352 File Offset: 0x001F2552
		[oO0oooo("0650")]
		[Category("H.调整")]
		[Description("调整冻结区之前发生。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(21.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeFreezeColumn
		{
			get
			{
				return this.Oo0oo0.0O0o.;
			}
			set
			{
				this.Oo0oo0.0O0o. = value;
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06004829 RID: 18473 RVA: 0x001F435B File Offset: 0x001F255B
		// (set) Token: 0x0600482A RID: 18474 RVA: 0x001F4363 File Offset: 0x001F2563
		[oO0oooo("0651")]
		[Category("H.调整")]
		[Description("调整冻结区之后发生。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(22.0)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterFreezeColumn
		{
			get
			{
				return this.O_O0o0.Oo__0O.;
			}
			set
			{
				this.O_O0o0.Oo__0O. = value;
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x0600482B RID: 18475 RVA: 0x001F436C File Offset: 0x001F256C
		// (set) Token: 0x0600482C RID: 18476 RVA: 0x001F4374 File Offset: 0x001F2574
		[oO0oooo("0652")]
		[Category("H.调整")]
		[Description("调整列宽之前发生。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(23.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeResizeColumn
		{
			get
			{
				return this.o0._O_.;
			}
			set
			{
				this.o0._O_. = value;
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x0600482D RID: 18477 RVA: 0x001F437D File Offset: 0x001F257D
		// (set) Token: 0x0600482E RID: 18478 RVA: 0x001F4385 File Offset: 0x001F2585
		[oO0oooo("0653")]
		[Category("H.调整")]
		[Description("调整列宽之后发生。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(24.0)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterResizeColumn
		{
			get
			{
				return this.O___oo.O_00O.;
			}
			set
			{
				this.O___oo.O_00O. = value;
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x001F438E File Offset: 0x001F258E
		// (set) Token: 0x06004830 RID: 18480 RVA: 0x001F4396 File Offset: 0x001F2596
		[oO0oooo("0654")]
		[Category("H.调整")]
		[Description("调整行高之前发生。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(25.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeResizeRow
		{
			get
			{
				return this.oO.o0_.;
			}
			set
			{
				this.oO.o0_. = value;
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x001F439F File Offset: 0x001F259F
		// (set) Token: 0x06004832 RID: 18482 RVA: 0x001F43A7 File Offset: 0x001F25A7
		[oO0oooo("0655")]
		[Category("H.调整")]
		[Description("调整行高之后发生。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(26.0)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterResizeRow
		{
			get
			{
				return this.O.oO_o_oOoo_.;
			}
			set
			{
				this.O.oO_o_oOoo_. = value;
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06004833 RID: 18483 RVA: 0x001F43B0 File Offset: 0x001F25B0
		// (set) Token: 0x06004834 RID: 18484 RVA: 0x001F43B8 File Offset: 0x001F25B8
		[Description("绘制某一单元格的时候执行，该事件执行非常频繁，对性能影响极大，代码必需简洁高效,不能有耗时的计算和操作。")]
		[oO0oooo("0656")]
		[Category("I.绘制")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(28.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DrawCell
		{
			get
			{
				return this.OO0_o_0oOO.0.;
			}
			set
			{
				this.OO0_o_0oOO.0. = value;
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06004835 RID: 18485 RVA: 0x001F43C1 File Offset: 0x001F25C1
		// (set) Token: 0x06004836 RID: 18486 RVA: 0x001F43C9 File Offset: 0x001F25C9
		[oO0oooo("1952")]
		[Category("I.绘制")]
		[Description("绘制某一行之前执行，通常用于动态设置行高。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(28.1)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeDrawRow
		{
			get
			{
				return this.OoO0.O__0o.;
			}
			set
			{
				this.OoO0.O__0o. = value;
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x001F43D2 File Offset: 0x001F25D2
		// (set) Token: 0x06004838 RID: 18488 RVA: 0x001F43DA File Offset: 0x001F25DA
		[oO0oooo("2057")]
		[Category("J.加载")]
		[Description("重新加载数据之前执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(29.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeLoad
		{
			get
			{
				return this.Oo__O.o.;
			}
			set
			{
				this.Oo__O.o. = value;
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x001F43E3 File Offset: 0x001F25E3
		// (set) Token: 0x0600483A RID: 18490 RVA: 0x001F43EB File Offset: 0x001F25EB
		[oO0oooo("2058")]
		[Category("J.加载")]
		[Description("重新加载数据之后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(30.0)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterLoad
		{
			get
			{
				return this.oO.0oo0Oo.;
			}
			set
			{
				this.oO.0oo0Oo. = value;
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x0600483B RID: 18491 RVA: 0x001F43F4 File Offset: 0x001F25F4
		// (set) Token: 0x0600483C RID: 18492 RVA: 0x001F43FC File Offset: 0x001F25FC
		[oO0oooo("2059")]
		[Category("K.筛选")]
		[Description("筛选数据之前执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(31.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeFilter
		{
			get
			{
				return this.o0_00O.0o00__.;
			}
			set
			{
				this.o0_00O.0o00__. = value;
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x001F4405 File Offset: 0x001F2605
		// (set) Token: 0x0600483E RID: 18494 RVA: 0x001F440D File Offset: 0x001F260D
		[oO0oooo("2060")]
		[Category("K.筛选")]
		[Description("筛选数据之后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(32.0)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterFilter
		{
			get
			{
				return this.o000o.o0_0o.;
			}
			set
			{
				this.o000o.o0_0o. = value;
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x0600483F RID: 18495 RVA: 0x001F4416 File Offset: 0x001F2616
		// (set) Token: 0x06004840 RID: 18496 RVA: 0x001F441E File Offset: 0x001F261E
		[oO0oooo("2061")]
		[Category("L.排序")]
		[Description("数据排序之前执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(33.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeSort
		{
			get
			{
				return this.OOooOo_0_.O_O_.;
			}
			set
			{
				this.OOooOo_0_.O_O_. = value;
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x06004841 RID: 18497 RVA: 0x001F4427 File Offset: 0x001F2627
		// (set) Token: 0x06004842 RID: 18498 RVA: 0x001F442F File Offset: 0x001F262F
		[oO0oooo("2062")]
		[Category("L.排序")]
		[Description("数据排序之后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(34.0)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterSort
		{
			get
			{
				return this.o_0ooo.OoO.;
			}
			set
			{
				this.o_0ooo.OoO. = value;
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06004843 RID: 18499 RVA: 0x001F4438 File Offset: 0x001F2638
		// (set) Token: 0x06004844 RID: 18500 RVA: 0x001F4440 File Offset: 0x001F2640
		[Description("双击单元格后执行。")]
		[oO0oooo("1499")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("M.鼠标与键盘")]
		[O_Oo00Oo000O0(37.0)]
		[O0O0oOO00_0OO(true)]
		public EventString DoubleClick
		{
			get
			{
				return this.OO0_oO.o000o_O.;
			}
			set
			{
				this.OO0_oO.o000o_O. = value;
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06004845 RID: 18501 RVA: 0x001F4449 File Offset: 0x001F2649
		// (set) Token: 0x06004846 RID: 18502 RVA: 0x001F4451 File Offset: 0x001F2651
		[Category("M.鼠标与键盘")]
		[oO0oooo("2386")]
		[Description("单击单元格后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(37.0)]
		[O0O0oOO00_0OO(true)]
		public EventString Click
		{
			get
			{
				return this.o0o00.O.;
			}
			set
			{
				this.o0o00.O. = value;
			}
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06004847 RID: 18503 RVA: 0x001F445A File Offset: 0x001F265A
		// (set) Token: 0x06004848 RID: 18504 RVA: 0x001F4462 File Offset: 0x001F2662
		[oO0oooo("2678")]
		[Category("M.鼠标与键盘")]
		[Description("鼠标进入某个单元格的时候执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(37.5)]
		[O0O0oOO00_0OO(true)]
		public EventString MouseEnterCell
		{
			get
			{
				return this.oO00._o0O_.;
			}
			set
			{
				this.oO00._o0O_. = value;
			}
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06004849 RID: 18505 RVA: 0x001F446B File Offset: 0x001F266B
		// (set) Token: 0x0600484A RID: 18506 RVA: 0x001F4473 File Offset: 0x001F2673
		[oO0oooo("2679")]
		[Category("M.鼠标与键盘")]
		[Description("鼠标离开某个单元格的时候执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(37.51)]
		[O0O0oOO00_0OO(true)]
		public EventString MouseLeaveCell
		{
			get
			{
				return this.o00OO.o0.;
			}
			set
			{
				this.o00OO.o0. = value;
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x001F447C File Offset: 0x001F267C
		// (set) Token: 0x0600484C RID: 18508 RVA: 0x001F4484 File Offset: 0x001F2684
		[oO0oooo("3750")]
		[Category("M.鼠标与键盘")]
		[Description("鼠标停留在某个单元格的时候执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(37.55)]
		[O0O0oOO00_0OO(true)]
		public EventString MouseHoverCell
		{
			get
			{
				return this.O.O0oo00oO.;
			}
			set
			{
				this.O.O0oo00oO. = value;
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x0600484D RID: 18509 RVA: 0x001F448D File Offset: 0x001F268D
		// (set) Token: 0x0600484E RID: 18510 RVA: 0x001F4495 File Offset: 0x001F2695
		[oO0oooo("1642")]
		[Category("M.鼠标与键盘")]
		[Description("压下按键时执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(38.0)]
		public EventString KeyDown
		{
			get
			{
				return this.O.0_0_0Oo00.;
			}
			set
			{
				this.O.0_0_0Oo00. = value;
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x0600484F RID: 18511 RVA: 0x001F449E File Offset: 0x001F269E
		// (set) Token: 0x06004850 RID: 18512 RVA: 0x001F44A6 File Offset: 0x001F26A6
		[oO0oooo("1643")]
		[Category("M.鼠标与键盘")]
		[Description("松开按键执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(39.0)]
		public EventString KeyUp
		{
			get
			{
				return this.oo0OO.___0__0.;
			}
			set
			{
				this.oo0OO.___0__0. = value;
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06004851 RID: 18513 RVA: 0x001F44AF File Offset: 0x001F26AF
		// (set) Token: 0x06004852 RID: 18514 RVA: 0x001F44B7 File Offset: 0x001F26B7
		[oO0oooo("2929")]
		[Category("M.鼠标与键盘")]
		[Description("双击行头时执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(37.6)]
		[O0O0oOO00_0OO(true)]
		public EventString DoubleClickRowHeader
		{
			get
			{
				return this.oooo_0_.O_O0.;
			}
			set
			{
				this.oooo_0_.O_O0. = value;
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06004853 RID: 18515 RVA: 0x001F44C0 File Offset: 0x001F26C0
		// (set) Token: 0x06004854 RID: 18516 RVA: 0x001F44C8 File Offset: 0x001F26C8
		[oO0oooo("2210")]
		[Category("N.附件")]
		[Description("向图片列或文件列添加文件的时候执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(35.1)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeAttachFile
		{
			get
			{
				return this.OoooO.0O_o.;
			}
			set
			{
				this.OoooO.0O_o. = value;
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06004855 RID: 18517 RVA: 0x001F44D1 File Offset: 0x001F26D1
		// (set) Token: 0x06004856 RID: 18518 RVA: 0x001F44D9 File Offset: 0x001F26D9
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Description("打开附件文件或者图片的时候执行")]
		[Category("N.附件")]
		[oO0oooo("2637")]
		[O_Oo00Oo000O0(35.2)]
		public EventString BeforeOpenFile
		{
			get
			{
				return this.o.0_oOoo.;
			}
			set
			{
				this.o.0_oOoo. = value;
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06004857 RID: 18519 RVA: 0x001F44E2 File Offset: 0x001F26E2
		// (set) Token: 0x06004858 RID: 18520 RVA: 0x001F44EA File Offset: 0x001F26EA
		[oO0oooo("2638")]
		[Category("N.附件")]
		[Description("添加附件文件或者图片的时候执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(35.0)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeAddFile
		{
			get
			{
				return this.oo.oOo_oo0O_.;
			}
			set
			{
				this.oo.oOo_oo0O_. = value;
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06004859 RID: 18521 RVA: 0x001F44F3 File Offset: 0x001F26F3
		// (set) Token: 0x0600485A RID: 18522 RVA: 0x001F44FB File Offset: 0x001F26FB
		[oO0oooo("2716")]
		[Category("N.附件")]
		[Description("删除附件文件或图片的时候执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(35.3)]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeDeleteFile
		{
			get
			{
				return this.O0_0_0o._OoO00.;
			}
			set
			{
				this.O0_0_0o._OoO00. = value;
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x001F4504 File Offset: 0x001F2704
		// (set) Token: 0x0600485C RID: 18524 RVA: 0x001F450C File Offset: 0x001F270C
		[oO0oooo("0662")]
		[Category("O.杂项")]
		[Description("显示快捷菜单之前执行，可以在此禁止显示快捷菜单，或更改要显示的快捷菜单。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(36.0)]
		public EventString BeforeShowContextMenu
		{
			get
			{
				return this.oO0OOO.O_.;
			}
			set
			{
				this.oO0OOO.O_. = value;
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x0600485D RID: 18525 RVA: 0x001F4515 File Offset: 0x001F2715
		// (set) Token: 0x0600485E RID: 18526 RVA: 0x001F451D File Offset: 0x001F271D
		[Description("滚动表格后执行")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(40.0)]
		[Category("O.杂项")]
		[oO0oooo("2357")]
		[O0O0oOO00_0OO(true)]
		public EventString AfterScroll
		{
			get
			{
				return this.o_oO.O_O.;
			}
			set
			{
				this.o_oO.O_O. = value;
			}
		}

		// Token: 0x04001CD9 RID: 7385
		private oOo__OO_ <<EMPTY_NAME>>;

		// Token: 0x04001CDA RID: 7386
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CDB RID: 7387
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CDC RID: 7388
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CDD RID: 7389
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CDE RID: 7390
		private int <<EMPTY_NAME>>;

		// Token: 0x04001CDF RID: 7391
		private int <<EMPTY_NAME>>;

		// Token: 0x04001CE0 RID: 7392
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CE1 RID: 7393
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CE2 RID: 7394
		private TableTypeEnum <<EMPTY_NAME>>;

		// Token: 0x04001CE3 RID: 7395
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CE4 RID: 7396
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CE5 RID: 7397
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CE6 RID: 7398
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CE7 RID: 7399
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CE8 RID: 7400
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CE9 RID: 7401
		private GridLineDirectionEnum <<EMPTY_NAME>>;

		// Token: 0x04001CEA RID: 7402
		private Color <<EMPTY_NAME>>;

		// Token: 0x04001CEB RID: 7403
		private string <<EMPTY_NAME>>;

		// Token: 0x04001CEC RID: 7404
		private Color <<EMPTY_NAME>>;

		// Token: 0x04001CED RID: 7405
		private Color <<EMPTY_NAME>>;

		// Token: 0x04001CEE RID: 7406
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001CEF RID: 7407
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CF0 RID: 7408
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CF1 RID: 7409
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CF2 RID: 7410
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CF3 RID: 7411
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CF4 RID: 7412
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CF5 RID: 7413
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CF6 RID: 7414
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CF7 RID: 7415
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CF8 RID: 7416
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CF9 RID: 7417
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CFA RID: 7418
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CFB RID: 7419
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CFC RID: 7420
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CFD RID: 7421
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CFE RID: 7422
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001CFF RID: 7423
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D00 RID: 7424
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D01 RID: 7425
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D02 RID: 7426
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D03 RID: 7427
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D04 RID: 7428
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D05 RID: 7429
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D06 RID: 7430
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D07 RID: 7431
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D08 RID: 7432
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D09 RID: 7433
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D0A RID: 7434
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D0B RID: 7435
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D0C RID: 7436
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D0D RID: 7437
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D0E RID: 7438
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D0F RID: 7439
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D10 RID: 7440
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D11 RID: 7441
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D12 RID: 7442
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D13 RID: 7443
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D14 RID: 7444
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D15 RID: 7445
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D16 RID: 7446
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D17 RID: 7447
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D18 RID: 7448
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D19 RID: 7449
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D1A RID: 7450
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D1B RID: 7451
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D1C RID: 7452
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D1D RID: 7453
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D1E RID: 7454
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D1F RID: 7455
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D20 RID: 7456
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D21 RID: 7457
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D22 RID: 7458
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D23 RID: 7459
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D24 RID: 7460
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D25 RID: 7461
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D26 RID: 7462
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D27 RID: 7463
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D28 RID: 7464
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D29 RID: 7465
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D2A RID: 7466
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D2B RID: 7467
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D2C RID: 7468
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04001D2D RID: 7469
		private string <<EMPTY_NAME>>;

		// Token: 0x04001D2E RID: 7470
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001D2F RID: 7471
		private int <<EMPTY_NAME>>;

		// Token: 0x04001D30 RID: 7472
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001D31 RID: 7473
		private bool <<EMPTY_NAME>>;
	}
}
