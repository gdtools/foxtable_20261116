using System;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x0200012F RID: 303
	public class NavigationCompletedEventArgs : ControlEventArgs
	{
		// Token: 0x06000F3B RID: 3899 RVA: 0x000768A1 File Offset: 0x00074AA1
		public NavigationCompletedEventArgs(WebViewer A_0, Form A_1, CoreWebView2NavigationCompletedEventArgs A_2) : base(A_0, A_1)
		{
			this.oO_o.0_o0_. = A_2;
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x000768B2 File Offset: 0x00074AB2
		public bool IsSuccess
		{
			get
			{
				return this.oO_o.0_o0_..IsSuccess;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x000768BF File Offset: 0x00074ABF
		public ulong NavigationId
		{
			get
			{
				return this.oO_o.0_o0_..NavigationId;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x000768CC File Offset: 0x00074ACC
		public CoreWebView2WebErrorStatus WebErrorStatus
		{
			get
			{
				return this.oO_o.0_o0_..WebErrorStatus;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000768D9 File Offset: 0x00074AD9
		public int HttpStatusCode
		{
			get
			{
				return this.oO_o.0_o0_..HttpStatusCode;
			}
		}

		// Token: 0x04000601 RID: 1537
		private CoreWebView2NavigationCompletedEventArgs <<EMPTY_NAME>>;
	}
}
