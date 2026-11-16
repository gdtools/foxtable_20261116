using System;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x02000103 RID: 259
	public class InitializationCompletedEventArgs : ControlEventArgs
	{
		// Token: 0x06000E5A RID: 3674 RVA: 0x000745BC File Offset: 0x000727BC
		public InitializationCompletedEventArgs(WebViewer A_0, Form A_1, CoreWebView2InitializationCompletedEventArgs A_2) : base(A_0, A_1)
		{
			this.oO._O_0oO__0. = A_2;
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x000745CD File Offset: 0x000727CD
		public bool IsSuccess
		{
			get
			{
				return this.oO._O_0oO__0..IsSuccess;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x000745DA File Offset: 0x000727DA
		public Exception InitializationException
		{
			get
			{
				return this.oO._O_0oO__0..InitializationException;
			}
		}

		// Token: 0x0400058F RID: 1423
		private CoreWebView2InitializationCompletedEventArgs <<EMPTY_NAME>>;
	}
}
