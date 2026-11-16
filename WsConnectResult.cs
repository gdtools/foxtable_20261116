using System;
using System.Net.WebSockets;

namespace Foxtable
{
	// Token: 0x02000205 RID: 517
	public class WsConnectResult
	{
		// Token: 0x0600199B RID: 6555 RVA: 0x000B71DC File Offset: 0x000B53DC
		public WsConnectResult(string A_0, WebSocket A_1)
		{
			this.ErrMsg = A_0;
			this.WebSocket = A_1;
		}

		// Token: 0x04000AA4 RID: 2724
		public string ErrMsg;

		// Token: 0x04000AA5 RID: 2725
		public WebSocket WebSocket;
	}
}
