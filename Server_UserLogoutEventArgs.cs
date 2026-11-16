using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020001C4 RID: 452
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Server_UserLogoutEventArgs
	{
		// Token: 0x060015D9 RID: 5593 RVA: 0x0009972F File Offset: 0x0009792F
		public Server_UserLogoutEventArgs(string A_0, IMServer A_1, int A_2)
		{
			this.OoO.Oo0O0o. = A_0;
			this.OoO.Oo0O0o. = A_1;
			this.o_o._O0O_. = A_2;
		}

		/// <summary>
		/// 返回退出登录用户名
		/// </summary>
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x0009974C File Offset: 0x0009794C
		public string UserName
		{
			get
			{
				return this.OoO.Oo0O0o.;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x00099754 File Offset: 0x00097954
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMServer Server
		{
			get
			{
				return this.OoO.Oo0O0o.;
			}
		}

		/// <summary>
		/// 整数型，返回用户退出登录的原因
		/// </summary>
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x0009975C File Offset: 0x0009795C
		public int Mode
		{
			get
			{
				return this.o_o._O0O_.;
			}
		}

		// Token: 0x04000891 RID: 2193
		private string <<EMPTY_NAME>>;

		// Token: 0x04000892 RID: 2194
		private IMServer <<EMPTY_NAME>>;

		// Token: 0x04000893 RID: 2195
		private int <<EMPTY_NAME>>;
	}
}
