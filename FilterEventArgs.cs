using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000250 RID: 592
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FilterEventArgs
	{
		// Token: 0x06001C48 RID: 7240 RVA: 0x000C4A5B File Offset: 0x000C2C5B
		public FilterEventArgs(Table A_0, string A_1)
		{
			this.O._00000. = A_0;
			this.O._00000. = A_1;
		}

		/// <summary>
		/// 触发事件的Table
		/// </summary>
		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x000C4A71 File Offset: 0x000C2C71
		public Table Table
		{
			get
			{
				return this.O._00000.;
			}
		}

		/// <summary>
		/// 返回或设置筛选条件
		/// </summary>
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x000C4A79 File Offset: 0x000C2C79
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x000C4A81 File Offset: 0x000C2C81
		public string Filter
		{
			get
			{
				return this.O._00000.;
			}
			set
			{
				this.O._00000. = value;
			}
		}

		/// <summary>
		/// 如果设为True，取消本次筛选
		/// </summary>
		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x000C4A8A File Offset: 0x000C2C8A
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x000C4A92 File Offset: 0x000C2C92
		public bool Cancel
		{
			get
			{
				return this.O._00000.;
			}
			set
			{
				this.O._00000. = value;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x000C4A9B File Offset: 0x000C2C9B
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x04000BFA RID: 3066
		private Table <<EMPTY_NAME>>;

		// Token: 0x04000BFB RID: 3067
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BFC RID: 3068
		private bool <<EMPTY_NAME>>;
	}
}
