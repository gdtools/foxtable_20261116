using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020000BA RID: 186
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FTPDownloadEventArgs
	{
		// Token: 0x060007CC RID: 1996 RVA: 0x00039ADA File Offset: 0x00037CDA
		public FTPDownloadEventArgs(string A_0, DateTime A_1, string A_2)
		{
			this.O00_.ooO. = A_0;
			this.O00_.ooO. = A_1;
			this.OO0O_000.oO0. = A_2;
		}

		/// <summary>
		/// 要下载的文件名，含路径
		/// </summary>
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00039AF7 File Offset: 0x00037CF7
		public string File
		{
			get
			{
				return this.O00_.ooO.;
			}
		}

		/// <summary>
		/// 返回此文件或目录最近一次修改的日期
		/// </summary>
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x00039AFF File Offset: 0x00037CFF
		public DateTime ModifyTime
		{
			get
			{
				return this.O00_.ooO.;
			}
		}

		/// <summary>
		/// 返回FTP的FTPName属性
		/// </summary>
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00039B07 File Offset: 0x00037D07
		public string FTPName
		{
			get
			{
				return this.OO0O_000.oO0.;
			}
		}

		/// <summary>
		/// 设置为True取消本次下载操作
		/// </summary>
		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00039B0F File Offset: 0x00037D0F
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00039B17 File Offset: 0x00037D17
		public bool Cancel
		{
			get
			{
				return this.O00_.ooO.;
			}
			set
			{
				this.O00_.ooO. = value;
			}
		}

		/// <summary>
		/// 设置为True取消本次及后续上传操作
		/// </summary>
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00039B20 File Offset: 0x00037D20
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00039B28 File Offset: 0x00037D28
		public bool CancelAll
		{
			get
			{
				return this.OO0O_000.oO0.;
			}
			set
			{
				this.OO0O_000.oO0. = value;
			}
		}

		// Token: 0x0400025B RID: 603
		private string <<EMPTY_NAME>>;

		// Token: 0x0400025C RID: 604
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400025D RID: 605
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400025E RID: 606
		private string <<EMPTY_NAME>>;

		// Token: 0x0400025F RID: 607
		private DateTime <<EMPTY_NAME>>;
	}
}
