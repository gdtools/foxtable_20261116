using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020002FB RID: 763
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CancelEventArgs
	{
		/// <summary>
		/// 取消本次操作
		/// </summary>
		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x0012AC5F File Offset: 0x00128E5F
		// (set) Token: 0x0600298B RID: 10635 RVA: 0x0012AC67 File Offset: 0x00128E67
		public bool Cancel
		{
			get
			{
				return this.o.o___O0O_O.;
			}
			set
			{
				this.o.o___O0O_O. = value;
			}
		}

		// Token: 0x04001129 RID: 4393
		private bool <<EMPTY_NAME>>;
	}
}
