using System;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x02000130 RID: 304
	public class NavigationStartingEventArgs : ControlEventArgs
	{
		// Token: 0x06000F40 RID: 3904 RVA: 0x000768E6 File Offset: 0x00074AE6
		public NavigationStartingEventArgs(WebViewer A_0, Form A_1, CoreWebView2NavigationStartingEventArgs A_2) : base(A_0, A_1)
		{
			this.O__0_0Oo.Oo000. = A_2;
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x000768F7 File Offset: 0x00074AF7
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x00076904 File Offset: 0x00074B04
		public virtual bool Cancel
		{
			get
			{
				return this.O__0_0Oo.Oo000..Cancel;
			}
			set
			{
				this.O__0_0Oo.Oo000..Cancel = true;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00076912 File Offset: 0x00074B12
		public bool IsRedirected
		{
			get
			{
				return this.O__0_0Oo.Oo000..IsRedirected;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0007691F File Offset: 0x00074B1F
		public bool IsUserInitiated
		{
			get
			{
				return this.O__0_0Oo.Oo000..IsUserInitiated;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x0007692C File Offset: 0x00074B2C
		public ulong NavigationId
		{
			get
			{
				return this.O__0_0Oo.Oo000..NavigationId;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00076939 File Offset: 0x00074B39
		public CoreWebView2HttpRequestHeaders RequestHeaders
		{
			get
			{
				return this.O__0_0Oo.Oo000..RequestHeaders;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00076946 File Offset: 0x00074B46
		public string Uri
		{
			get
			{
				return this.O__0_0Oo.Oo000..Uri;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x00076953 File Offset: 0x00074B53
		// (set) Token: 0x06000F49 RID: 3913 RVA: 0x00076960 File Offset: 0x00074B60
		public string AdditionalAllowedFrameAncestors
		{
			get
			{
				return this.O__0_0Oo.Oo000..AdditionalAllowedFrameAncestors;
			}
			set
			{
				this.O__0_0Oo.Oo000..AdditionalAllowedFrameAncestors = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x0007696E File Offset: 0x00074B6E
		public CoreWebView2NavigationKind NavigationKind
		{
			get
			{
				return this.O__0_0Oo.Oo000..NavigationKind;
			}
		}

		// Token: 0x04000602 RID: 1538
		private CoreWebView2NavigationStartingEventArgs <<EMPTY_NAME>>;
	}
}
