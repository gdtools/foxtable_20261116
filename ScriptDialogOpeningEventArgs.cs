using System;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x0200010D RID: 269
	public class ScriptDialogOpeningEventArgs : ControlEventArgs
	{
		// Token: 0x06000E8D RID: 3725 RVA: 0x00074B82 File Offset: 0x00072D82
		public ScriptDialogOpeningEventArgs(WebViewer A_0, Form A_1, CoreWebView2ScriptDialogOpeningEventArgs A_2) : base(A_0, A_1)
		{
			this.o.0o00oo_OOo. = A_2;
			this.o.0o00oo_OOo. = A_0;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00074B9A File Offset: 0x00072D9A
		public void Accept()
		{
			this.o.0o00oo_OOo..Accept();
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00074BA7 File Offset: 0x00072DA7
		public CoreWebView2Deferral GetDeferral()
		{
			return this.o.0o00oo_OOo..GetDeferral();
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00074BB4 File Offset: 0x00072DB4
		public string DefaultText
		{
			get
			{
				return this.o.0o00oo_OOo..DefaultText;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x00074BC1 File Offset: 0x00072DC1
		public CoreWebView2ScriptDialogKind Kind
		{
			get
			{
				return this.o.0o00oo_OOo..Kind;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00074BCE File Offset: 0x00072DCE
		public string Message
		{
			get
			{
				return this.o.0o00oo_OOo..Message;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x00074BDB File Offset: 0x00072DDB
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x00074BE8 File Offset: 0x00072DE8
		public string ResultText
		{
			get
			{
				return this.o.0o00oo_OOo..ResultText;
			}
			set
			{
				this.o.0o00oo_OOo..ResultText = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x00074BF6 File Offset: 0x00072DF6
		public string Uri
		{
			get
			{
				return this.o.0o00oo_OOo..Uri;
			}
		}

		// Token: 0x040005A1 RID: 1441
		private CoreWebView2ScriptDialogOpeningEventArgs <<EMPTY_NAME>>;

		// Token: 0x040005A2 RID: 1442
		private WebViewer <<EMPTY_NAME>>;
	}
}
