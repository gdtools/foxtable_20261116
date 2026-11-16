using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020002FD RID: 765
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CellRangeChangeEventArgs
	{
		// Token: 0x06002994 RID: 10644 RVA: 0x0012ACC5 File Offset: 0x00128EC5
		public CellRangeChangeEventArgs(Table A_0, CellRange A_1, CellRange A_2)
		{
			this.oOO.oO_____OO_. = A_0;
			this.oOO.oO_____OO_. = A_1;
			this.Oo_O._o__. = A_2;
		}

		/// <summary>
		/// 触发事件的Table
		/// </summary>
		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06002995 RID: 10645 RVA: 0x0012ACE2 File Offset: 0x00128EE2
		public Table Table
		{
			get
			{
				return this.oOO.oO_____OO_.;
			}
		}

		/// <summary>
		/// 操作前选定的区域
		/// </summary>
		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x0012ACEA File Offset: 0x00128EEA
		public CellRange OldRange
		{
			get
			{
				return this.oOO.oO_____OO_.;
			}
		}

		/// <summary>
		/// 操作后选定的区域
		/// </summary>
		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06002997 RID: 10647 RVA: 0x0012ACF2 File Offset: 0x00128EF2
		public CellRange NewRange
		{
			get
			{
				return this.Oo_O._o__.;
			}
		}

		/// <summary>
		/// 取消本次操作
		/// </summary>
		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x0012ACFA File Offset: 0x00128EFA
		// (set) Token: 0x06002999 RID: 10649 RVA: 0x0012AD02 File Offset: 0x00128F02
		public bool Cancel
		{
			get
			{
				return this.O.OoOo00O_.;
			}
			set
			{
				this.O.OoOo00O_. = value;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x0600299A RID: 10650 RVA: 0x0012AD0B File Offset: 0x00128F0B
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x0400112E RID: 4398
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400112F RID: 4399
		private CellRange <<EMPTY_NAME>>;

		// Token: 0x04001130 RID: 4400
		private CellRange <<EMPTY_NAME>>;

		// Token: 0x04001131 RID: 4401
		private bool <<EMPTY_NAME>>;
	}
}
