using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200030A RID: 778
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RowColPositionEventArgs
	{
		// Token: 0x06002A0D RID: 10765 RVA: 0x0012B8C3 File Offset: 0x00129AC3
		public RowColPositionEventArgs(Table A_0, int A_1)
		{
			this.oo0Ooo.o_0__0_. = A_0;
			this.oo0Ooo.o_0__0_. = A_1;
		}

		/// <summary>
		/// 触发事件的Table
		/// </summary>
		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002A0E RID: 10766 RVA: 0x0012B8D9 File Offset: 0x00129AD9
		public Table Table
		{
			get
			{
				return this.oo0Ooo.o_0__0_.;
			}
		}

		/// <summary>
		/// 位置
		/// </summary>
		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x0012B8E1 File Offset: 0x00129AE1
		public int Position
		{
			get
			{
				return this.oo0Ooo.o_0__0_.;
			}
		}

		/// <summary>
		/// 设置为True取消本次操作
		/// </summary>
		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002A10 RID: 10768 RVA: 0x0012B8E9 File Offset: 0x00129AE9
		// (set) Token: 0x06002A11 RID: 10769 RVA: 0x0012B8F1 File Offset: 0x00129AF1
		public bool Cancel
		{
			get
			{
				return this.oo0Ooo.o_0__0_.;
			}
			set
			{
				this.oo0Ooo.o_0__0_. = value;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002A12 RID: 10770 RVA: 0x0012B8FA File Offset: 0x00129AFA
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x04001166 RID: 4454
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001167 RID: 4455
		private int <<EMPTY_NAME>>;

		// Token: 0x04001168 RID: 4456
		private bool <<EMPTY_NAME>>;
	}
}
