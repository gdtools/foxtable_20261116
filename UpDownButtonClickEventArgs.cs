using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020002BC RID: 700
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class UpDownButtonClickEventArgs : ControlEventArgs
	{
		// Token: 0x06002622 RID: 9762 RVA: 0x0011A19D File Offset: 0x0011839D
		public UpDownButtonClickEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, int A_2) : base(A_0, A_1)
		{
			this.O__00.__0_O. = A_2;
		}

		/// <summary>
		/// 整数型，1表示按的是向上的微调按钮，-1表示按的是向下的微调按钮
		/// </summary>
		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x0011A1AE File Offset: 0x001183AE
		public int Direction
		{
			get
			{
				return this.O__00.__0_O.;
			}
		}

		// Token: 0x04000FD1 RID: 4049
		private int <<EMPTY_NAME>>;
	}
}
