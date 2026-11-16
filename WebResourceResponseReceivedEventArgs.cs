using System;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x02000135 RID: 309
	public class WebResourceResponseReceivedEventArgs : ControlEventArgs
	{
		// Token: 0x06000F64 RID: 3940 RVA: 0x00076AD3 File Offset: 0x00074CD3
		public WebResourceResponseReceivedEventArgs(WebViewer A_0, Form A_1, CoreWebView2WebResourceResponseReceivedEventArgs A_2) : base(A_0, A_1)
		{
			this.Oo0Oo_0oo0.0. = A_2;
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00076AE4 File Offset: 0x00074CE4
		public CoreWebView2WebResourceRequest Request
		{
			get
			{
				return this.Oo0Oo_0oo0.0..Request;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00076AF1 File Offset: 0x00074CF1
		public CoreWebView2WebResourceResponseView Response
		{
			get
			{
				return this.Oo0Oo_0oo0.0..Response;
			}
		}

		// Token: 0x04000607 RID: 1543
		private CoreWebView2WebResourceResponseReceivedEventArgs <<EMPTY_NAME>>;
	}
}
