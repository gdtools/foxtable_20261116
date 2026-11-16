using System;
using System.Runtime.InteropServices;

namespace Foxtable.WinForm
{
	// Token: 0x02000502 RID: 1282
	[ComVisible(true)]
	public class WebViewer : Control
	{
		// Token: 0x060053D3 RID: 21459 RVA: 0x00256919 File Offset: 0x00254B19
		internal WebViewer(WebViewer A_0) : base(A_0, ControlTypeEnum.WebViewer)
		{
			this.O_ooo.0. = A_0;
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x060053D4 RID: 21460 RVA: 0x0025692B File Offset: 0x00254B2B
		public WebViewer WebViewer
		{
			get
			{
				return this.O_ooo.0.;
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x060053D5 RID: 21461 RVA: 0x00256933 File Offset: 0x00254B33
		// (set) Token: 0x060053D6 RID: 21462 RVA: 0x00256940 File Offset: 0x00254B40
		public bool AreDevToolsEnabled
		{
			get
			{
				return this.O_ooo.0..AreDevToolsEnabled;
			}
			set
			{
				this.O_ooo.0..AreDevToolsEnabled = value;
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x060053D7 RID: 21463 RVA: 0x0025694E File Offset: 0x00254B4E
		// (set) Token: 0x060053D8 RID: 21464 RVA: 0x0025695B File Offset: 0x00254B5B
		public bool AreSaveAsEnabled
		{
			get
			{
				return this.O_ooo.0..AreSaveAsEnabled;
			}
			set
			{
				this.O_ooo.0..AreSaveAsEnabled = value;
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x060053D9 RID: 21465 RVA: 0x00256969 File Offset: 0x00254B69
		// (set) Token: 0x060053DA RID: 21466 RVA: 0x00256976 File Offset: 0x00254B76
		public bool AreDefaultContextMenusEnabled
		{
			get
			{
				return this.O_ooo.0..AreDefaultContextMenusEnabled;
			}
			set
			{
				this.O_ooo.0..AreDefaultContextMenusEnabled = value;
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x060053DB RID: 21467 RVA: 0x00256984 File Offset: 0x00254B84
		// (set) Token: 0x060053DC RID: 21468 RVA: 0x00256991 File Offset: 0x00254B91
		public bool AreBrowserAcceleratorKeysEnabled
		{
			get
			{
				return this.O_ooo.0..AreBrowserAcceleratorKeysEnabled;
			}
			set
			{
				this.O_ooo.0..AreBrowserAcceleratorKeysEnabled = value;
			}
		}

		// Token: 0x040022AA RID: 8874
		private WebViewer <<EMPTY_NAME>>;
	}
}
