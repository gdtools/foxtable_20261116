using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020002B8 RID: 696
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class DropDownClosedEventArgs
	{
		// Token: 0x06002616 RID: 9750 RVA: 0x0011A0F2 File Offset: 0x001182F2
		public DropDownClosedEventArgs(Form A_0, bool A_1)
		{
			this.oO.0. = A_0;
			this.oO.0. = A_1;
		}

		/// <summary>
		/// 返回触发事件的窗口
		/// </summary>
		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x0011A108 File Offset: 0x00118308
		public Form Form
		{
			get
			{
				return this.oO.0.;
			}
		}

		/// <summary>
		/// 是否在下拉窗口选择了值
		/// </summary>
		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x0011A110 File Offset: 0x00118310
		public bool Selected
		{
			get
			{
				return this.oO.0.;
			}
		}

		// Token: 0x04000FCB RID: 4043
		private Form <<EMPTY_NAME>>;

		// Token: 0x04000FCC RID: 4044
		private bool <<EMPTY_NAME>>;
	}
}
