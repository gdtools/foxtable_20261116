using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000256 RID: 598
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ShowErrorMessageEventArgs
	{
		// Token: 0x06001C67 RID: 7271 RVA: 0x000C4C35 File Offset: 0x000C2E35
		public ShowErrorMessageEventArgs(Exception A_0, string A_1)
		{
			this.o0O_.00. = A_0;
			this.o0O_.00. = A_1;
		}

		/// <summary>
		/// 设为True将禁止系统显示错误信息。
		/// </summary>
		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x000C4C4B File Offset: 0x000C2E4B
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x000C4C53 File Offset: 0x000C2E53
		public bool Cancel
		{
			get
			{
				return this.o0O_.00.;
			}
			set
			{
				this.o0O_.00. = value;
			}
		}

		/// <summary>
		/// 返回System.Exception
		/// </summary>
		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x000C4C5C File Offset: 0x000C2E5C
		public Exception ex
		{
			get
			{
				return this.o0O_.00.;
			}
		}

		/// <summary>
		/// 返回发生错误的事件名称，如果错误发生在自定义函数中，则返回函数名
		/// </summary>
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x000C4C64 File Offset: 0x000C2E64
		public string Event
		{
			get
			{
				return this.o0O_.00.;
			}
		}

		/// <summary>
		/// 返回简明错误信息
		/// </summary>
		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x000C4C6C File Offset: 0x000C2E6C
		public string Message1
		{
			get
			{
				return this.ex.Message;
			}
		}

		/// <summary>
		/// 返回详细错误信息
		/// </summary>
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x000C4C79 File Offset: 0x000C2E79
		public string Message2
		{
			get
			{
				return this.ex.ToString();
			}
		}

		// Token: 0x04000C0C RID: 3084
		private Exception <<EMPTY_NAME>>;

		// Token: 0x04000C0D RID: 3085
		private string <<EMPTY_NAME>>;

		// Token: 0x04000C0E RID: 3086
		private bool <<EMPTY_NAME>>;
	}
}
