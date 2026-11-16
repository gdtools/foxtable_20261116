using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x0200018E RID: 398
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class AfterReceiveFileEventArgs
	{
		// Token: 0x0600130A RID: 4874 RVA: 0x00083C77 File Offset: 0x00081E77
		public AfterReceiveFileEventArgs(string A_0, string A_1, bool A_2)
		{
			this.O0o00_0__.___0. = A_0;
			this.O___o.O_0__OoO. = A_1;
			this.O0o00_0__.___0. = A_2;
		}

		/// <summary>
		/// 逻辑型，如果接收成功，返回True，否则返回False
		/// </summary>
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00083C94 File Offset: 0x00081E94
		public bool Success
		{
			get
			{
				return this.O0o00_0__.___0.;
			}
		}

		/// <summary>
		/// 返回发送方名称，如果是服务器发来文件，则返回空
		/// </summary>
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x00083C9C File Offset: 0x00081E9C
		public string UserName
		{
			get
			{
				return this.O0o00_0__.___0.;
			}
		}

		/// <summary>
		/// 返回收到的文件名，含路径
		/// </summary>
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x00083CA4 File Offset: 0x00081EA4
		public string FileName
		{
			get
			{
				return this.O___o.O_0__OoO.;
			}
		}

		// Token: 0x0400075E RID: 1886
		private string <<EMPTY_NAME>>;

		// Token: 0x0400075F RID: 1887
		private string <<EMPTY_NAME>>;

		// Token: 0x04000760 RID: 1888
		private bool <<EMPTY_NAME>>;
	}
}
