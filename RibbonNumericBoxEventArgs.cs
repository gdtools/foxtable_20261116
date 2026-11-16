using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004B6 RID: 1206
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonNumericBoxEventArgs
	{
		// Token: 0x06005049 RID: 20553 RVA: 0x00239451 File Offset: 0x00237651
		public RibbonNumericBoxEventArgs(NumericBox A_0)
		{
			this.o0_.OO. = A_0;
		}

		/// <summary>
		/// 返回触发事件的数值输入框
		/// </summary>
		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x0600504A RID: 20554 RVA: 0x00239460 File Offset: 0x00237660
		public NumericBox NumericBox
		{
			get
			{
				return this.o0_.OO.;
			}
		}

		// Token: 0x04002109 RID: 8457
		private NumericBox <<EMPTY_NAME>>;
	}
}
