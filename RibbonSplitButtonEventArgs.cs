using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004B1 RID: 1201
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonSplitButtonEventArgs
	{
		// Token: 0x0600503E RID: 20542 RVA: 0x002393D6 File Offset: 0x002375D6
		public RibbonSplitButtonEventArgs(SplitButton A_0)
		{
			this.O._oo0__0o. = A_0;
		}

		/// <summary>
		/// 返回触发事件的组合按钮
		/// </summary>
		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x0600503F RID: 20543 RVA: 0x002393E5 File Offset: 0x002375E5
		public SplitButton SplitButton
		{
			get
			{
				return this.O._oo0__0o.;
			}
		}

		// Token: 0x04002104 RID: 8452
		private SplitButton <<EMPTY_NAME>>;
	}
}
