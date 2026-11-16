using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000257 RID: 599
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class SortEventArgs
	{
		// Token: 0x06001C6E RID: 7278 RVA: 0x000C4C86 File Offset: 0x000C2E86
		public SortEventArgs(Table A_0, string A_1)
		{
			this.oo.o0O. = A_0;
			this.oo.o0O. = A_1;
		}

		/// <summary>
		/// 触发发事件的Table
		/// </summary>
		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x000C4C9C File Offset: 0x000C2E9C
		public Table Table
		{
			get
			{
				return this.oo.o0O.;
			}
		}

		/// <summary>
		/// 返回或设置新的排序字段
		/// </summary>
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x000C4CA4 File Offset: 0x000C2EA4
		// (set) Token: 0x06001C71 RID: 7281 RVA: 0x000C4CAC File Offset: 0x000C2EAC
		public string Sort
		{
			get
			{
				return this.oo.o0O.;
			}
			set
			{
				this.oo.o0O. = value;
			}
		}

		/// <summary>
		/// 如果设为True，可取消本次排序
		/// </summary>
		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x000C4CB5 File Offset: 0x000C2EB5
		// (set) Token: 0x06001C73 RID: 7283 RVA: 0x000C4CBD File Offset: 0x000C2EBD
		public bool Cancel
		{
			get
			{
				return this.oo.o0O.;
			}
			set
			{
				this.oo.o0O. = value;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x000C4CC6 File Offset: 0x000C2EC6
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x04000C0F RID: 3087
		private Table <<EMPTY_NAME>>;

		// Token: 0x04000C10 RID: 3088
		private string <<EMPTY_NAME>>;

		// Token: 0x04000C11 RID: 3089
		private bool <<EMPTY_NAME>>;
	}
}
