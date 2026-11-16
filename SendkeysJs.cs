using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200012E RID: 302
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class SendkeysJs
	{
		// Token: 0x06000F38 RID: 3896 RVA: 0x0007688A File Offset: 0x00074A8A
		public void Send(string keys)
		{
			SendKeys.Send(keys);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00076892 File Offset: 0x00074A92
		public void SendWait(string keys)
		{
			SendKeys.SendWait(keys);
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0007689A File Offset: 0x00074A9A
		public void Flush()
		{
			SendKeys.Flush();
		}
	}
}
