using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000300 RID: 768
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class DragColumnEventArgs
	{
		// Token: 0x060029AC RID: 10668 RVA: 0x0012AE64 File Offset: 0x00129064
		public DragColumnEventArgs(Table A_0, int A_1, int A_2, int A_3)
		{
			this.oOOo0_O.OO_. = A_0;
			this.oOOo0_O.OO_. = A_1;
			this.o0OO_0._. = A_2;
			this.o_0oO.OOo. = A_3;
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060029AD RID: 10669 RVA: 0x0012AE89 File Offset: 0x00129089
		public Table Table
		{
			get
			{
				return this.oOOo0_O.OO_.;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x0012AE91 File Offset: 0x00129091
		public int c1
		{
			get
			{
				return this.oOOo0_O.OO_.;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060029AF RID: 10671 RVA: 0x0012AE99 File Offset: 0x00129099
		public int c2
		{
			get
			{
				return this.o0OO_0._.;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x0012AEA1 File Offset: 0x001290A1
		// (set) Token: 0x060029B1 RID: 10673 RVA: 0x0012AEA9 File Offset: 0x001290A9
		public int Position
		{
			get
			{
				return this.o_0oO.OOo.;
			}
			set
			{
				this.o_0oO.OOo. = value;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x0012AEB2 File Offset: 0x001290B2
		// (set) Token: 0x060029B3 RID: 10675 RVA: 0x0012AEBA File Offset: 0x001290BA
		public bool Cancel
		{
			get
			{
				return this.oOOo0_O.OO_.;
			}
			set
			{
				this.oOOo0_O.OO_. = value;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x0012AEC3 File Offset: 0x001290C3
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x0400113D RID: 4413
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400113E RID: 4414
		private int <<EMPTY_NAME>>;

		// Token: 0x0400113F RID: 4415
		private int <<EMPTY_NAME>>;

		// Token: 0x04001140 RID: 4416
		private int <<EMPTY_NAME>>;

		// Token: 0x04001141 RID: 4417
		private bool <<EMPTY_NAME>>;
	}
}
