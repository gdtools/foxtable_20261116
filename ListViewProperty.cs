using System;
using System.ComponentModel;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x020001BA RID: 442
	internal class ListViewProperty : ControlPropertyBase
	{
		// Token: 0x06001590 RID: 5520 RVA: 0x000991A3 File Offset: 0x000973A3
		public ListViewProperty(ControlHolder A_0) : base(A_0)
		{
			this.O._OOOO0_. = (o00_o00)A_0.ChildControl;
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x000991BD File Offset: 0x000973BD
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x000991C5 File Offset: 0x000973C5
		[oO0oooo("2872")]
		[Description("双击某行或在某行按回车键后触发！")]
		[Category("事件")]
		[O_Oo00Oo000O0(0.1)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString RowActivate
		{
			get
			{
				return this.oOO_O_.OOO0o_.;
			}
			set
			{
				this.oOO_O_.OOO0o_. = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x000991CE File Offset: 0x000973CE
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x000991D6 File Offset: 0x000973D6
		[Category("事件")]
		[oO0oooo("2789")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(0.2)]
		[Description("行的复选框状态即将改变时触发！")]
		[O0O0oOO00_0OO(true)]
		public EventString RowChecking
		{
			get
			{
				return this.oO._oooooO0oo0.;
			}
			set
			{
				this.oO._oooooO0oo0. = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x000991DF File Offset: 0x000973DF
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x000991E7 File Offset: 0x000973E7
		[Description("行的复选框状态改变后触发！")]
		[oO0oooo("2790")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.3)]
		public EventString RowChecked
		{
			get
			{
				return this.o_o__000O.o.;
			}
			set
			{
				this.o_o__000O.o. = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x000991F0 File Offset: 0x000973F0
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x000991F8 File Offset: 0x000973F8
		[oO0oooo("2786")]
		[O_Oo00Oo000O0(0.4)]
		[Description("行的选中状态发生变化后触发！")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString RowSelectionChanged
		{
			get
			{
				return this.o_.o_OO_O.;
			}
			set
			{
				this.o_.o_OO_O. = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x00099201 File Offset: 0x00097401
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x00099209 File Offset: 0x00097409
		[oO0oooo("2787")]
		[O_Oo00Oo000O0(0.5)]
		[Description("编辑标题前触发！")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeEdit
		{
			get
			{
				return this.o._ooO0.;
			}
			set
			{
				this.o._ooO0. = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00099212 File Offset: 0x00097412
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x0009921A File Offset: 0x0009741A
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("2788")]
		[Description("编辑标题前触发！")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.6)]
		public EventString AfterEdit
		{
			get
			{
				return this.o_OOOOO_.0ooo.;
			}
			set
			{
				this.o_OOOOO_.0ooo. = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x00099223 File Offset: 0x00097423
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x0009922B File Offset: 0x0009742B
		[oO0oooo("2783")]
		[Description("在虚拟模式下生成指定位置的行时触发！")]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.7)]
		public EventString RetrieveVirtualRow
		{
			get
			{
				return this.Oo.O0_oOOoo0.;
			}
			set
			{
				this.Oo.O0_oOOoo0. = value;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x00099234 File Offset: 0x00097434
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x0009923C File Offset: 0x0009743C
		[O_Oo00Oo000O0(0.71)]
		[Description("开始拖动行前触发！")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("2784")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeDragRow
		{
			get
			{
				return this.o0OO.o.;
			}
			set
			{
				this.o0OO.o. = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x00099245 File Offset: 0x00097445
		// (set) Token: 0x060015A2 RID: 5538 RVA: 0x0009924D File Offset: 0x0009744D
		[oO0oooo("2785")]
		[O_Oo00Oo000O0(0.71)]
		[Category("事件")]
		[Description("接收到拖动过来的行前触发！")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString BeforeDropRow
		{
			get
			{
				return this.ooO0o00O_.ooo0.;
			}
			set
			{
				this.ooO0o00O_.ooo0. = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x00099256 File Offset: 0x00097456
		// (set) Token: 0x060015A4 RID: 5540 RVA: 0x0009925E File Offset: 0x0009745E
		[O0O0oOO00_0OO(true)]
		[Category("事件")]
		[Description("绘制单元格的时候触发")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("2874")]
		[O_Oo00Oo000O0(0.72)]
		public EventString DrawViewCell
		{
			get
			{
				return this.O.0OOO__oO_0_.;
			}
			set
			{
				this.O.0OOO__oO_0_. = value;
			}
		}

		// Token: 0x04000865 RID: 2149
		private o00_o00 <<EMPTY_NAME>>;

		// Token: 0x04000866 RID: 2150
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000867 RID: 2151
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000868 RID: 2152
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04000869 RID: 2153
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400086A RID: 2154
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400086B RID: 2155
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400086C RID: 2156
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400086D RID: 2157
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400086E RID: 2158
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400086F RID: 2159
		private EventString <<EMPTY_NAME>>;
	}
}
