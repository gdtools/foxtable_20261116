using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004B5 RID: 1205
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonDatePickerEventArgs
	{
		// Token: 0x06005047 RID: 20551 RVA: 0x0023943A File Offset: 0x0023763A
		public RibbonDatePickerEventArgs(DatePicker A_0)
		{
			this.OO_._O0. = A_0;
		}

		/// <summary>
		/// 返回触发事件的日期输入框
		/// </summary>
		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06005048 RID: 20552 RVA: 0x00239449 File Offset: 0x00237649
		public DatePicker DatePicker
		{
			get
			{
				return this.OO_._O0.;
			}
		}

		// Token: 0x04002108 RID: 8456
		private DatePicker <<EMPTY_NAME>>;
	}
}
