using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020001C1 RID: 449
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Server_UserEventArgs
	{
		// Token: 0x060015C3 RID: 5571 RVA: 0x00099433 File Offset: 0x00097633
		public Server_UserEventArgs(string A_0, IMServer A_1)
		{
			this.oo_O._. = A_0;
			this.o__.O0_0. = A_1;
		}

		/// <summary>
		/// 用户名
		/// </summary>
		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x00099449 File Offset: 0x00097649
		public string UserName
		{
			get
			{
				return this.oo_O._.;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x00099451 File Offset: 0x00097651
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMServer Server
		{
			get
			{
				return this.o__.O0_0.;
			}
		}

		// Token: 0x04000882 RID: 2178
		private string <<EMPTY_NAME>>;

		// Token: 0x04000883 RID: 2179
		private IMServer <<EMPTY_NAME>>;
	}
}
