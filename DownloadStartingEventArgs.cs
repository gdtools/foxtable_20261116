using System;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x02000101 RID: 257
	public class DownloadStartingEventArgs : ControlEventArgs
	{
		// Token: 0x06000E45 RID: 3653 RVA: 0x00074432 File Offset: 0x00072632
		public DownloadStartingEventArgs(WebViewer A_0, Form A_1, CoreWebView2DownloadStartingEventArgs A_2) : base(A_0, A_1)
		{
			this.O.o0_oo. = A_2;
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00074443 File Offset: 0x00072643
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x00074450 File Offset: 0x00072650
		public virtual bool Cancel
		{
			get
			{
				return this.O.o0_oo..Cancel;
			}
			set
			{
				this.O.o0_oo..Cancel = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x0007445E File Offset: 0x0007265E
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x0007446B File Offset: 0x0007266B
		public bool Handled
		{
			get
			{
				return this.O.o0_oo..Handled;
			}
			set
			{
				this.O.o0_oo..Handled = true;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00074479 File Offset: 0x00072679
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00074486 File Offset: 0x00072686
		public string ResultFilePath
		{
			get
			{
				return this.O.o0_oo..ResultFilePath;
			}
			set
			{
				this.O.o0_oo..ResultFilePath = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00074494 File Offset: 0x00072694
		public CoreWebView2DownloadOperation DownloadOperation
		{
			get
			{
				return this.O.o0_oo..DownloadOperation;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x000744A1 File Offset: 0x000726A1
		public string Uri
		{
			get
			{
				return this.O.o0_oo..DownloadOperation.Uri;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x000744B4 File Offset: 0x000726B4
		public ulong TotalBytesToReceive
		{
			get
			{
				ulong result;
				if (this.O.o0_oo..DownloadOperation.TotalBytesToReceive != null)
				{
					result = this.O.o0_oo..DownloadOperation.TotalBytesToReceive.Value;
				}
				else
				{
					result = ulong.MaxValue;
				}
				return result;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x000744FA File Offset: 0x000726FA
		public string MimeType
		{
			get
			{
				return this.O.o0_oo..DownloadOperation.MimeType;
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0007450C File Offset: 0x0007270C
		public CoreWebView2Deferral GetDeferral()
		{
			return this.O.o0_oo..GetDeferral();
		}

		// Token: 0x0400058D RID: 1421
		private CoreWebView2DownloadStartingEventArgs <<EMPTY_NAME>>;
	}
}
