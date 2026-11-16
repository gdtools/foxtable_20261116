using System;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x020000F0 RID: 240
	public class ContentLoadingEventArgs : ControlEventArgs
	{
		// Token: 0x06000DBB RID: 3515 RVA: 0x00071D8D File Offset: 0x0006FF8D
		public ContentLoadingEventArgs(WebViewer A_0, Form A_1, CoreWebView2ContentLoadingEventArgs A_2) : base(A_0, A_1)
		{
			this.Oo___.ooooO00. = A_2;
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x00071D9E File Offset: 0x0006FF9E
		public bool IsErrorPage
		{
			get
			{
				return this.Oo___.ooooO00..IsErrorPage;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x00071DAB File Offset: 0x0006FFAB
		public ulong NavigationId
		{
			get
			{
				return this.Oo___.ooooO00..NavigationId;
			}
		}

		// Token: 0x04000554 RID: 1364
		private CoreWebView2ContentLoadingEventArgs <<EMPTY_NAME>>;
	}
}
