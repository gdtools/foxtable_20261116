using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020001BE RID: 446
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Client_BuddyLogoutEventArgs
	{
		// Token: 0x060015B1 RID: 5553 RVA: 0x00099304 File Offset: 0x00097504
		internal Client_BuddyLogoutEventArgs(string A_0, IMClient A_1, int A_2)
		{
			this.O_o.O0. = A_0;
			this.O_o.O0. = A_2;
			this.O_o.O0. = A_1;
		}

		/// <summary>
		/// 下线好友名称
		/// </summary>
		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x00099321 File Offset: 0x00097521
		public string BuddyName
		{
			get
			{
				return this.O_o.O0.;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00099329 File Offset: 0x00097529
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMClient Client
		{
			get
			{
				return this.O_o.O0.;
			}
		}

		/// <summary>
		/// 整数型，返回好友下线原因
		/// </summary>
		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00099331 File Offset: 0x00097531
		public int Mode
		{
			get
			{
				return this.O_o.O0.;
			}
		}

		// Token: 0x04000878 RID: 2168
		private string <<EMPTY_NAME>>;

		// Token: 0x04000879 RID: 2169
		private IMClient <<EMPTY_NAME>>;

		// Token: 0x0400087A RID: 2170
		private int <<EMPTY_NAME>>;
	}
}
