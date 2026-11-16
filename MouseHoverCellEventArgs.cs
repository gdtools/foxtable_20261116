using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020000A1 RID: 161
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class MouseHoverCellEventArgs : RowColEventArgs
	{
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0002FEF9 File Offset: 0x0002E0F9
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x0002FF01 File Offset: 0x0002E101
		public bool Hovering { get; set; }

		// Token: 0x06000657 RID: 1623 RVA: 0x0002FF0A File Offset: 0x0002E10A
		public MouseHoverCellEventArgs(Table A_0, Row A_1, Col A_2, RecordGrid A_3, bool A_4) : base(A_0, A_1, A_2, A_3)
		{
			this.Hovering = A_4;
		}

		// Token: 0x040001AB RID: 427
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;
	}
}
