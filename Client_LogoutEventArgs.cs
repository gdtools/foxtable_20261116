using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020001BB RID: 443
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Client_LogoutEventArgs
	{
		// Token: 0x060015A5 RID: 5541 RVA: 0x00099267 File Offset: 0x00097467
		public Client_LogoutEventArgs(IMClient A_0, int A_1)
		{
			this.O_o.O0. = A_1;
			this.O_o.O0. = A_0;
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x0009927D File Offset: 0x0009747D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMClient Client
		{
			get
			{
				return this.O_o.O0.;
			}
		}

		/// <summary>
		/// 整数型，返回连接中断的原因
		/// </summary>
		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00099285 File Offset: 0x00097485
		public int Mode
		{
			get
			{
				return this.O_o.O0.;
			}
		}

		// Token: 0x04000870 RID: 2160
		private IMClient <<EMPTY_NAME>>;

		// Token: 0x04000871 RID: 2161
		private int <<EMPTY_NAME>>;
	}
}
