using System;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x02000134 RID: 308
	public class WebResourceRequestedEventArgs : ControlEventArgs
	{
		// Token: 0x06000F5D RID: 3933 RVA: 0x00076A73 File Offset: 0x00074C73
		public WebResourceRequestedEventArgs(WebViewer A_0, Form A_1, CoreWebView2WebResourceRequestedEventArgs A_2) : base(A_0, A_1)
		{
			this.Oo0Oo_0oo0.0. = A_2;
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00076A84 File Offset: 0x00074C84
		public CoreWebView2WebResourceRequest Request
		{
			get
			{
				return this.Oo0Oo_0oo0.0..Request;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00076A91 File Offset: 0x00074C91
		public CoreWebView2WebResourceContext ResourceContext
		{
			get
			{
				return this.Oo0Oo_0oo0.0..ResourceContext;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00076A9E File Offset: 0x00074C9E
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x00076AAB File Offset: 0x00074CAB
		public CoreWebView2WebResourceResponse Response
		{
			get
			{
				return this.Oo0Oo_0oo0.0..Response;
			}
			set
			{
				this.Oo0Oo_0oo0.0..Response = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00076AB9 File Offset: 0x00074CB9
		public CoreWebView2WebResourceRequestSourceKinds RequestedSourceKind
		{
			get
			{
				return this.Oo0Oo_0oo0.0..RequestedSourceKind;
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00076AC6 File Offset: 0x00074CC6
		public CoreWebView2Deferral GetDeferral()
		{
			return this.Oo0Oo_0oo0.0..GetDeferral();
		}

		// Token: 0x04000606 RID: 1542
		private CoreWebView2WebResourceRequestedEventArgs <<EMPTY_NAME>>;
	}
}
