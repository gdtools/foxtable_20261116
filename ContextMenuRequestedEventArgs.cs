using System;
using System.Collections.Generic;
using System.Drawing;
using Foxtable.WinForm;
using Microsoft.Web.WebView2.Core;

namespace Foxtable
{
	// Token: 0x020000F2 RID: 242
	public class ContextMenuRequestedEventArgs : ControlEventArgs
	{
		// Token: 0x06000DC3 RID: 3523 RVA: 0x00071E3E File Offset: 0x0007003E
		public ContextMenuRequestedEventArgs(WebViewer A_0, Form A_1, CoreWebView2ContextMenuRequestedEventArgs A_2) : base(A_0, A_1)
		{
			this.O.OOO0000_0. = A_2;
			this.O.OOO0000_0. = A_0;
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00071E56 File Offset: 0x00070056
		public CoreWebView2ContextMenuTarget ContextMenuTarget
		{
			get
			{
				return this.O.OOO0000_0..ContextMenuTarget;
			}
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00071E64 File Offset: 0x00070064
		public object GetElementInfo()
		{
			return this.O.OOO0000_0..GetElementInfoFromPoint(this.Location.X, this.Location.Y);
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00071E98 File Offset: 0x00070098
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x00071EA5 File Offset: 0x000700A5
		public bool Handled
		{
			get
			{
				return this.O.OOO0000_0..Handled;
			}
			set
			{
				this.O.OOO0000_0..Handled = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00071EB3 File Offset: 0x000700B3
		public Point Location
		{
			get
			{
				return this.O.OOO0000_0..Location;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00071EC0 File Offset: 0x000700C0
		public IList<CoreWebView2ContextMenuItem> MenuItems
		{
			get
			{
				return this.O.OOO0000_0..MenuItems;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00071ECD File Offset: 0x000700CD
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x00071EDA File Offset: 0x000700DA
		public int SelectedCommandId
		{
			get
			{
				return this.O.OOO0000_0..SelectedCommandId;
			}
			set
			{
				this.O.OOO0000_0..SelectedCommandId = value;
			}
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00071EE8 File Offset: 0x000700E8
		public CoreWebView2Deferral GetDeferral()
		{
			return this.O.OOO0000_0..GetDeferral();
		}

		// Token: 0x04000559 RID: 1369
		private CoreWebView2ContextMenuRequestedEventArgs <<EMPTY_NAME>>;

		// Token: 0x0400055A RID: 1370
		private WebViewer <<EMPTY_NAME>>;
	}
}
