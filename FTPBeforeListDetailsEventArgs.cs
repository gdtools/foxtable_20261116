using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020000B8 RID: 184
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FTPBeforeListDetailsEventArgs
	{
		// Token: 0x060007BD RID: 1981 RVA: 0x000399A8 File Offset: 0x00037BA8
		public FTPBeforeListDetailsEventArgs(string A_0, List<string> A_1, string A_2)
		{
			this.o_._Ooo_o_O_O. = new List<string[]>();
			this.o_._Ooo_o_O_O. = new List<string>();
			this.o_._Ooo_o_O_O. = A_0;
			this.O0_.000. = A_2;
			try
			{
				foreach (string text in A_1)
				{
					this.Infos.Add(text.Split(new char[]
					{
						'*'
					}));
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		/// <summary>
		/// FTP的当前目录，文件将被上传到此目录
		/// </summary>
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00039A38 File Offset: 0x00037C38
		public string CurFolder
		{
			get
			{
				return this.o_._Ooo_o_O_O.;
			}
		}

		/// <summary>
		/// 集合，包括即将显示的文件和目录信息
		/// </summary>
		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00039A40 File Offset: 0x00037C40
		public List<string[]> Infos
		{
			get
			{
				return this.o_._Ooo_o_O_O.;
			}
		}

		/// <summary>
		/// 返回FTP的FTPName属性
		/// </summary>
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00039A48 File Offset: 0x00037C48
		public string FTPName
		{
			get
			{
				return this.O0_.000.;
			}
		}

		/// <summary>
		/// 将某个文件或目录从显示内容中排除掉
		/// </summary>
		/// <param name="Item"></param>
		// Token: 0x060007C1 RID: 1985 RVA: 0x00039A50 File Offset: 0x00037C50
		public void Remove(string[] Item)
		{
			this.o_._Ooo_o_O_O..Add(Item[0]);
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00039A60 File Offset: 0x00037C60
		internal string[] RemovedItems
		{
			get
			{
				string[] array = this.o_._Ooo_o_O_O..ToArray();
				Array.Sort<string>(array);
				return array;
			}
		}

		// Token: 0x04000251 RID: 593
		private string <<EMPTY_NAME>>;

		// Token: 0x04000252 RID: 594
		private string <<EMPTY_NAME>>;

		// Token: 0x04000253 RID: 595
		private List<string[]> <<EMPTY_NAME>>;

		// Token: 0x04000254 RID: 596
		private List<string> <<EMPTY_NAME>>;
	}
}
