using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020000BC RID: 188
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FTPRenameEventArgs
	{
		// Token: 0x060007D9 RID: 2009 RVA: 0x00039BA4 File Offset: 0x00037DA4
		public FTPRenameEventArgs(string A_0, string A_1, bool A_2, DateTime A_3, string A_4)
		{
			this.O_.0O_o. = A_0;
			this.o_OO.00. = A_1;
			this.O_.0O_o. = A_2;
			this.O_.0O_o. = A_3;
			this.O0_00O0O_.0. = A_4;
		}

		/// <summary>
		/// 如果要重命名的是目录，则此属性返回True
		/// </summary>
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00039BD1 File Offset: 0x00037DD1
		public bool IsFolder
		{
			get
			{
				return this.O_.0O_o.;
			}
		}

		/// <summary>
		/// 新文件名或目录名
		/// </summary>
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x00039BD9 File Offset: 0x00037DD9
		public string NewName
		{
			get
			{
				return this.o_OO.00.;
			}
		}

		/// <summary>
		/// 原文件名或目录名
		/// </summary>
		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00039BE1 File Offset: 0x00037DE1
		public string OldName
		{
			get
			{
				return this.O_.0O_o.;
			}
		}

		/// <summary>
		/// 返回FTP的FTPName属性
		/// </summary>
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x00039BE9 File Offset: 0x00037DE9
		public string FTPName
		{
			get
			{
				return this.O0_00O0O_.0.;
			}
		}

		/// <summary>
		/// 返回此文件或目录最近一次修改的日期
		/// </summary>
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00039BF1 File Offset: 0x00037DF1
		public DateTime ModifyTime
		{
			get
			{
				return this.O_.0O_o.;
			}
		}

		/// <summary>
		/// 如果设置为True，将取消此次重命名操作
		/// </summary>
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00039BF9 File Offset: 0x00037DF9
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00039C01 File Offset: 0x00037E01
		public bool Cancel
		{
			get
			{
				return this.o_OO.00.;
			}
			set
			{
				this.o_OO.00. = value;
			}
		}

		// Token: 0x04000263 RID: 611
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000264 RID: 612
		private string <<EMPTY_NAME>>;

		// Token: 0x04000265 RID: 613
		private string <<EMPTY_NAME>>;

		// Token: 0x04000266 RID: 614
		private string <<EMPTY_NAME>>;

		// Token: 0x04000267 RID: 615
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000268 RID: 616
		private DateTime <<EMPTY_NAME>>;
	}
}
