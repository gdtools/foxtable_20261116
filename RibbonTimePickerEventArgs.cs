using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004C4 RID: 1220
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonTimePickerEventArgs
	{
		// Token: 0x06005065 RID: 20581 RVA: 0x00239593 File Offset: 0x00237793
		public RibbonTimePickerEventArgs(TimePicker A_0)
		{
			this.o_000O_o.oOo0. = A_0;
		}

		/// <summary>
		/// 返回触发事件的时间输入框
		/// </summary>
		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06005066 RID: 20582 RVA: 0x002395A2 File Offset: 0x002377A2
		public TimePicker TimePicker
		{
			get
			{
				return this.o_000O_o.oOo0.;
			}
		}

		// Token: 0x04002117 RID: 8471
		private TimePicker <<EMPTY_NAME>>;
	}
}
