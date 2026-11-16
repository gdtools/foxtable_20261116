using System;
using System.ComponentModel;
using System.Text;

namespace Foxtable
{
	// Token: 0x0200022B RID: 555
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wRawHtml : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A79 RID: 6777 RVA: 0x000BBF7C File Offset: 0x000BA17C
		internal wRawHtml(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.OO.oO00. = A_2;
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x000BBF8D File Offset: 0x000BA18D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			A_0.AppendLine(this.OO.oO00.);
		}

		// Token: 0x04000B2C RID: 2860
		private string <<EMPTY_NAME>>;
	}
}
