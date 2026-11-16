using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000BD RID: 189
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FTPUploadEventArgs
	{
		// Token: 0x060007E1 RID: 2017 RVA: 0x00039C0C File Offset: 0x00037E0C
		public FTPUploadEventArgs(string A_0, string A_1, string A_2)
		{
			this.oo0__.0Oo0o_. = A_0;
			this.o.O0_o. = A_1.TrimEnd(new char[]
			{
				'/'
			});
			if (Operators.CompareString(this.o.O0_o., "", true) == 0)
			{
				this.o.O0_o. = "/";
			}
			this.oOO___O.0Ooo. = A_2;
		}

		/// <summary>
		/// 要上传的本地文件，含路径
		/// </summary>
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00039C62 File Offset: 0x00037E62
		public string LocalFile
		{
			get
			{
				return this.oo0__.0Oo0o_.;
			}
		}

		/// <summary>
		/// FTP的当前目录，文件将被上传到此目录
		/// </summary>
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00039C6A File Offset: 0x00037E6A
		public string CurFolder
		{
			get
			{
				return this.o.O0_o.;
			}
		}

		/// <summary>
		/// 返回FTP的FTPName属性
		/// </summary>
		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00039C72 File Offset: 0x00037E72
		public string FTPName
		{
			get
			{
				return this.oOO___O.0Ooo.;
			}
		}

		/// <summary>
		/// 设置为True将取消本次上传操作
		/// </summary>
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00039C7A File Offset: 0x00037E7A
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00039C82 File Offset: 0x00037E82
		public bool Cancel
		{
			get
			{
				return this.O_.0O_o.;
			}
			set
			{
				this.O_.0O_o. = true;
			}
		}

		/// <summary>
		/// 设置为True取消本次及后续上传操作
		/// </summary>
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00039C8B File Offset: 0x00037E8B
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00039C93 File Offset: 0x00037E93
		public bool CancelAll
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

		// Token: 0x04000269 RID: 617
		private string <<EMPTY_NAME>>;

		// Token: 0x0400026A RID: 618
		private string <<EMPTY_NAME>>;

		// Token: 0x0400026B RID: 619
		private string <<EMPTY_NAME>>;

		// Token: 0x0400026C RID: 620
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400026D RID: 621
		private bool <<EMPTY_NAME>>;
	}
}
