using System;
using System.Collections.Generic;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x02000133 RID: 307
	public class WebMessageReceivedEventArgs : ControlEventArgs
	{
		// Token: 0x06000F58 RID: 3928 RVA: 0x00076A2E File Offset: 0x00074C2E
		public WebMessageReceivedEventArgs(WebViewer A_0, Form A_1, CoreWebView2WebMessageReceivedEventArgs A_2) : base(A_0, A_1)
		{
			this.o.oOoO___o__oO. = A_2;
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00076A3F File Offset: 0x00074C3F
		public string Source
		{
			get
			{
				return this.o.oOoO___o__oO..Source;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00076A4C File Offset: 0x00074C4C
		public string WebMessageAsJson
		{
			get
			{
				return this.o.oOoO___o__oO..WebMessageAsJson;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00076A59 File Offset: 0x00074C59
		public IReadOnlyList<object> AdditionalObjects
		{
			get
			{
				return this.o.oOoO___o__oO..AdditionalObjects;
			}
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00076A66 File Offset: 0x00074C66
		public string TryGetWebMessageAsString()
		{
			return this.o.oOoO___o__oO..TryGetWebMessageAsString();
		}

		// Token: 0x04000605 RID: 1541
		private CoreWebView2WebMessageReceivedEventArgs <<EMPTY_NAME>>;
	}
}
