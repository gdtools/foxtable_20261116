using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020000A2 RID: 162
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RowColEventArgs
	{
		// Token: 0x06000658 RID: 1624 RVA: 0x0002FF1F File Offset: 0x0002E11F
		public RowColEventArgs(Table A_0, Row A_1, Col A_2, RecordGrid A_3)
		{
			this.o_O0oOoo.ooOoo. = true;
			this.oo0Ooo.o_0__0_. = A_0;
			this.oo_.o_O_OO0. = A_1;
			this.oo_.o_O_OO0. = A_2;
			this.oo_.o_O_OO0. = A_3;
		}

		/// <summary>
		/// 触发事件的Table
		/// </summary>
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0002FF4B File Offset: 0x0002E14B
		public Table Table
		{
			get
			{
				return this.oo0Ooo.o_0__0_.;
			}
		}

		/// <summary>
		/// 触发事件的Row
		/// </summary>
		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0002FF53 File Offset: 0x0002E153
		public Row Row
		{
			get
			{
				return this.oo_.o_O_OO0.;
			}
		}

		/// <summary>
		/// 触发事件的Col
		/// </summary>
		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0002FF5B File Offset: 0x0002E15B
		public Col Col
		{
			get
			{
				return this.oo_.o_O_OO0.;
			}
		}

		/// <summary>
		/// 是否取消本次操作
		/// </summary>
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0002FF63 File Offset: 0x0002E163
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x0002FF6B File Offset: 0x0002E16B
		public bool Cancel
		{
			get
			{
				return this.oo_.o_O_OO0.;
			}
			set
			{
				this.oo_.o_O_OO0. = value;
			}
		}

		/// <summary>
		/// 是否是焦点单元格
		/// </summary>
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0002FF74 File Offset: 0x0002E174
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x0002FF7C File Offset: 0x0002E17C
		public bool IsFocusCell
		{
			get
			{
				return this.oO._o_00.;
			}
			internal set
			{
				this.oO._o_00. = value;
			}
		}

		/// <summary>
		/// 如果是在记录窗口编辑，可以通过此属性获取RecordGrid控件
		/// </summary>
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0002FF85 File Offset: 0x0002E185
		public RecordGrid RecordGrid
		{
			get
			{
				return this.oo_.o_O_OO0.;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0002FF8D File Offset: 0x0002E18D
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		/// <summary>
		/// 如果本次单元格针对了多个单元格，将此属性设置为True，将中断后续单元格的操作，仅对BeforeEdit和StartEdit事件有效。
		/// </summary>
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0002FF9A File Offset: 0x0002E19A
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x0002FFA2 File Offset: 0x0002E1A2
		public bool Continue
		{
			get
			{
				return this.o_O0oOoo.ooOoo.;
			}
			set
			{
				this.o_O0oOoo.ooOoo. = value;
			}
		}

		// Token: 0x040001AC RID: 428
		private Table <<EMPTY_NAME>>;

		// Token: 0x040001AD RID: 429
		private Row <<EMPTY_NAME>>;

		// Token: 0x040001AE RID: 430
		private Col <<EMPTY_NAME>>;

		// Token: 0x040001AF RID: 431
		private bool <<EMPTY_NAME>>;

		// Token: 0x040001B0 RID: 432
		private bool <<EMPTY_NAME>>;

		// Token: 0x040001B1 RID: 433
		private RecordGrid <<EMPTY_NAME>>;

		// Token: 0x040001B2 RID: 434
		private bool <<EMPTY_NAME>>;
	}
}
