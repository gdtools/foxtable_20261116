using System;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x02000131 RID: 305
	public class NewWindowRequestedEventArgs : ControlEventArgs
	{
		// Token: 0x06000F4B RID: 3915 RVA: 0x0007697B File Offset: 0x00074B7B
		public NewWindowRequestedEventArgs(WebViewer A_0, Form A_1, CoreWebView2NewWindowRequestedEventArgs A_2) : base(A_0, A_1)
		{
			this.OO0o0.0OOo_. = A_2;
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x0007698C File Offset: 0x00074B8C
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x00076999 File Offset: 0x00074B99
		public bool Handled
		{
			get
			{
				return this.OO0o0.0OOo_..Handled;
			}
			set
			{
				this.OO0o0.0OOo_..Handled = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x000769A7 File Offset: 0x00074BA7
		public bool IsUserInitiated
		{
			get
			{
				return this.OO0o0.0OOo_..IsUserInitiated;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x000769B4 File Offset: 0x00074BB4
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x000769C1 File Offset: 0x00074BC1
		public CoreWebView2 NewWindow
		{
			get
			{
				return this.OO0o0.0OOo_..NewWindow;
			}
			set
			{
				this.OO0o0.0OOo_..NewWindow = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x000769CF File Offset: 0x00074BCF
		public string Uri
		{
			get
			{
				return this.OO0o0.0OOo_..Uri;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x000769DC File Offset: 0x00074BDC
		public CoreWebView2WindowFeatures WindowFeatures
		{
			get
			{
				return this.OO0o0.0OOo_..WindowFeatures;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x000769E9 File Offset: 0x00074BE9
		public string Name
		{
			get
			{
				return this.OO0o0.0OOo_..Name;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x000769F6 File Offset: 0x00074BF6
		public CoreWebView2FrameInfo OriginalSourceFrameInfo
		{
			get
			{
				return this.OO0o0.0OOo_..OriginalSourceFrameInfo;
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00076A03 File Offset: 0x00074C03
		public CoreWebView2Deferral GetDeferral()
		{
			return this.OO0o0.0OOo_..GetDeferral();
		}

		// Token: 0x04000603 RID: 1539
		private CoreWebView2NewWindowRequestedEventArgs <<EMPTY_NAME>>;
	}
}
