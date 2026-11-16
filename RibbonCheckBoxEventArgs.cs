using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004B2 RID: 1202
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonCheckBoxEventArgs
	{
		// Token: 0x06005040 RID: 20544 RVA: 0x002393ED File Offset: 0x002375ED
		public RibbonCheckBoxEventArgs(CheckBox A_0)
		{
			this.O_o0oO.O00o. = A_0;
		}

		/// <summary>
		/// 返回触发事件的检查框
		/// </summary>
		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06005041 RID: 20545 RVA: 0x002393FC File Offset: 0x002375FC
		public CheckBox CheckBox
		{
			get
			{
				return this.O_o0oO.O00o.;
			}
		}

		// Token: 0x04002105 RID: 8453
		private CheckBox <<EMPTY_NAME>>;
	}
}
