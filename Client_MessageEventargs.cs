using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001BD RID: 445
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class Client_MessageEventargs
	{
		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x000992B3 File Offset: 0x000974B3
		// (set) Token: 0x060015AC RID: 5548 RVA: 0x000992BB File Offset: 0x000974BB
		public DateTime SendTime { get; set; }

		// Token: 0x060015AD RID: 5549 RVA: 0x000992C4 File Offset: 0x000974C4
		public Client_MessageEventargs(IMClient A_0, string A_1, string A_2)
		{
			this.SendTime = DateTime.MinValue;
			this.oO0OOO.0O. = A_1;
			this.o000.0. = A_2;
			this.O_o.O0. = A_0;
		}

		/// <summary>
		/// 字符型，返回好友名称，如果是服务端(QQServer)发来的信息，则返回空
		/// </summary>
		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x000992EC File Offset: 0x000974EC
		public string UserName
		{
			get
			{
				return this.oO0OOO.0O.;
			}
		}

		/// <summary>
		/// 字符型，收到的消息
		/// </summary>
		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x000992F4 File Offset: 0x000974F4
		public string Message
		{
			get
			{
				return this.o000.0.;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x000992FC File Offset: 0x000974FC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IMClient Client
		{
			get
			{
				return this.O_o.O0.;
			}
		}

		// Token: 0x04000874 RID: 2164
		private IMClient <<EMPTY_NAME>>;

		// Token: 0x04000875 RID: 2165
		private string <<EMPTY_NAME>>;

		// Token: 0x04000876 RID: 2166
		private string <<EMPTY_NAME>>;

		// Token: 0x04000877 RID: 2167
		[CompilerGenerated]
		private DateTime <<EMPTY_NAME>>;
	}
}
