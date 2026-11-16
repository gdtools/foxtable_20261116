using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004AE RID: 1198
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonButtonEventArgs
	{
		// Token: 0x06005037 RID: 20535 RVA: 0x00239382 File Offset: 0x00237582
		public RibbonButtonEventArgs(Button A_0)
		{
			this.o0o__0.OO0O. = A_0;
		}

		/// <summary>
		/// 触发事件的按钮
		/// </summary>
		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06005038 RID: 20536 RVA: 0x00239391 File Offset: 0x00237591
		public Button Button
		{
			get
			{
				return this.o0o__0.OO0O.;
			}
		}

		// Token: 0x04002100 RID: 8448
		private Button <<EMPTY_NAME>>;
	}
}
