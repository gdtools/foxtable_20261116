using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020000B7 RID: 183
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CellClickEventArgs : RowColEventArgs
	{
		// Token: 0x060007BB RID: 1979 RVA: 0x00039988 File Offset: 0x00037B88
		public CellClickEventArgs(Table A_0, Row A_1, Col A_2, RecordGrid A_3, string A_4) : base(A_0, A_1, A_2, A_3)
		{
			this.O.OoOo00O_. = A_4;
		}

		/// <summary>
		/// 引发事件的鼠标按键名称，左键为"Left"，右键为"Right"
		/// </summary>
		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x0003999D File Offset: 0x00037B9D
		public string Button
		{
			get
			{
				return this.O.OoOo00O_.;
			}
		}

		// Token: 0x04000250 RID: 592
		private string <<EMPTY_NAME>>;
	}
}
