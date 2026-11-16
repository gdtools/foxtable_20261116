using System;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x02000102 RID: 258
	public class DownloadStateChangedEventArgs : ControlEventArgs
	{
		// Token: 0x06000E51 RID: 3665 RVA: 0x00074519 File Offset: 0x00072719
		public DownloadStateChangedEventArgs(WebViewer A_0, Form A_1, CoreWebView2DownloadOperation A_2) : base(A_0, A_1)
		{
			this.oOOo0_O.OO_. = A_2;
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0007452A File Offset: 0x0007272A
		public string ResultFilePath
		{
			get
			{
				return this.oOOo0_O.OO_..ResultFilePath;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00074537 File Offset: 0x00072737
		public string Uri
		{
			get
			{
				return this.oOOo0_O.OO_..Uri;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00074544 File Offset: 0x00072744
		public string MimeType
		{
			get
			{
				return this.oOOo0_O.OO_..MimeType;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00074551 File Offset: 0x00072751
		public CoreWebView2DownloadState State
		{
			get
			{
				return this.oOOo0_O.OO_..State;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x0007455E File Offset: 0x0007275E
		public long BytesReceived
		{
			get
			{
				return this.oOOo0_O.OO_..BytesReceived;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x0007456B File Offset: 0x0007276B
		public bool CanResume
		{
			get
			{
				return this.oOOo0_O.OO_..CanResume;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00074578 File Offset: 0x00072778
		public ulong TotalBytesToReceive
		{
			get
			{
				ulong result;
				if (this.oOOo0_O.OO_..TotalBytesToReceive != null)
				{
					result = this.oOOo0_O.OO_..TotalBytesToReceive.Value;
				}
				else
				{
					result = ulong.MaxValue;
				}
				return result;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x000745B4 File Offset: 0x000727B4
		public CoreWebView2DownloadOperation DownloadOperation
		{
			get
			{
				return this.oOOo0_O.OO_.;
			}
		}

		// Token: 0x0400058E RID: 1422
		private CoreWebView2DownloadOperation <<EMPTY_NAME>>;
	}
}
