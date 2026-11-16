using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004B4 RID: 1204
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonTextBoxEventArgs
	{
		// Token: 0x06005044 RID: 20548 RVA: 0x0023941B File Offset: 0x0023761B
		public RibbonTextBoxEventArgs(TextBox A_0)
		{
			this.OOoo_o00.O___0. = A_0;
		}

		/// <summary>
		/// 返回触发事件的文本框
		/// </summary>
		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06005045 RID: 20549 RVA: 0x0023942A File Offset: 0x0023762A
		public TextBox TextBox
		{
			get
			{
				return this.OOoo_o00.O___0.;
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06005046 RID: 20550 RVA: 0x00239432 File Offset: 0x00237632
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TextBox EditBox
		{
			get
			{
				return this.TextBox;
			}
		}

		// Token: 0x04002107 RID: 8455
		private TextBox <<EMPTY_NAME>>;
	}
}
