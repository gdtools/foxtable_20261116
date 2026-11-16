using System;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x020000F3 RID: 243
	public class DOMContentLoadedEventArgs : ControlEventArgs
	{
		// Token: 0x06000DCD RID: 3533 RVA: 0x00071EF5 File Offset: 0x000700F5
		public DOMContentLoadedEventArgs(WebViewer A_0, Form A_1, CoreWebView2DOMContentLoadedEventArgs A_2) : base(A_0, A_1)
		{
			this.OO_.0o_0. = A_2;
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00071F06 File Offset: 0x00070106
		public ulong NavigationId
		{
			get
			{
				return this.OO_.0o_0..NavigationId;
			}
		}

		// Token: 0x0400055B RID: 1371
		private CoreWebView2DOMContentLoadedEventArgs <<EMPTY_NAME>>;
	}
}
