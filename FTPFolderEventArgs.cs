using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000BB RID: 187
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FTPFolderEventArgs
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x00039B34 File Offset: 0x00037D34
		public FTPFolderEventArgs(string A_0, string A_1)
		{
			this.O_.0O_o. = A_0.TrimEnd(new char[]
			{
				'/'
			});
			if (Operators.CompareString(this.O_.0O_o., "", true) == 0)
			{
				this.O_.0O_o. = "/";
			}
			this.o_OO.00. = A_1;
		}

		/// <summary>
		/// 返回目录名
		/// </summary>
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00039B83 File Offset: 0x00037D83
		public string FolderName
		{
			get
			{
				return this.O_.0O_o.;
			}
		}

		/// <summary>
		/// 返回FTP的FTPName属性
		/// </summary>
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00039B8B File Offset: 0x00037D8B
		public string FTPName
		{
			get
			{
				return this.o_OO.00.;
			}
		}

		/// <summary>
		/// 取消本次操作
		/// </summary>
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00039B93 File Offset: 0x00037D93
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x00039B9B File Offset: 0x00037D9B
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

		// Token: 0x04000260 RID: 608
		private string <<EMPTY_NAME>>;

		// Token: 0x04000261 RID: 609
		private string <<EMPTY_NAME>>;

		// Token: 0x04000262 RID: 610
		private bool <<EMPTY_NAME>>;
	}
}
