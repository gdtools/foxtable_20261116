using System;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x02000132 RID: 306
	public class SourceChangedEventArgs : ControlEventArgs
	{
		// Token: 0x06000F56 RID: 3926 RVA: 0x00076A10 File Offset: 0x00074C10
		public SourceChangedEventArgs(WebViewer A_0, Form A_1, CoreWebView2SourceChangedEventArgs A_2) : base(A_0, A_1)
		{
			this.oo.o0O. = A_2;
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x00076A21 File Offset: 0x00074C21
		public bool IsNewDocument
		{
			get
			{
				return this.oo.o0O..IsNewDocument;
			}
		}

		// Token: 0x04000604 RID: 1540
		private CoreWebView2SourceChangedEventArgs <<EMPTY_NAME>>;
	}
}
