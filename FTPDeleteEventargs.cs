using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020000B9 RID: 185
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FTPDeleteEventargs
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x00039A73 File Offset: 0x00037C73
		public FTPDeleteEventargs(string A_0, bool A_1, DateTime A_2, string A_3)
		{
			this.O00_.ooO. = A_0;
			this.O00_.ooO. = A_1;
			this.O00_.ooO. = A_2;
			this.OO0O_000.oO0. = A_3;
		}

		/// <summary>
		/// 如果被删除的是目录，则此属性返回True
		/// </summary>
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00039A98 File Offset: 0x00037C98
		public bool IsFolder
		{
			get
			{
				return this.O00_.ooO.;
			}
		}

		/// <summary>
		/// 要删除的文件名或目录名，含完整路径
		/// </summary>
		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00039AA0 File Offset: 0x00037CA0
		public string FileName
		{
			get
			{
				return this.O00_.ooO.;
			}
		}

		/// <summary>
		/// 返回此文件或目录最近一次修改的日期
		/// </summary>
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00039AA8 File Offset: 0x00037CA8
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
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00039AB0 File Offset: 0x00037CB0
		public string FTPName
		{
			get
			{
				return this.OO0O_000.oO0.;
			}
		}

		/// <summary>
		/// 如果设置为True，将取消此次删除操作
		/// </summary>
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00039AB8 File Offset: 0x00037CB8
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00039AC0 File Offset: 0x00037CC0
		public bool Cancel
		{
			get
			{
				return this.oO.o___.;
			}
			set
			{
				this.oO.o___. = value;
			}
		}

		/// <summary>
		/// 如果设置为True，将取消本次及后续删除操作
		/// </summary>
		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00039AC9 File Offset: 0x00037CC9
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x00039AD1 File Offset: 0x00037CD1
		public bool CancelAll
		{
			get
			{
				return this.o.o00_O0O0__0O.;
			}
			set
			{
				this.o.o00_O0O0__0O. = value;
			}
		}

		// Token: 0x04000255 RID: 597
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000256 RID: 598
		private string <<EMPTY_NAME>>;

		// Token: 0x04000257 RID: 599
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000258 RID: 600
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000259 RID: 601
		private string <<EMPTY_NAME>>;

		// Token: 0x0400025A RID: 602
		private DateTime <<EMPTY_NAME>>;
	}
}
