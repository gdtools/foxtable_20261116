using System;
using System.ComponentModel;
using System.Drawing;
using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001C9 RID: 457
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class IMFontProperty
	{
		// Token: 0x0600160E RID: 5646 RVA: 0x00099C3A File Offset: 0x00097E3A
		public IMFontProperty(CellStyle A_0, CellStyle A_1)
		{
			this.O00.O0. = SystemColors.WindowText;
			this.OO0oo__._. = SystemColors.WindowText;
			this.o0O0OOo._ooO_O. = A_0;
			this.O_O0_o._O0o0O. = A_1;
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x00099C66 File Offset: 0x00097E66
		// (set) Token: 0x06001610 RID: 5648 RVA: 0x00099C78 File Offset: 0x00097E78
		public string MyFontName
		{
			get
			{
				return this.o0O0OOo._ooO_O..Font.Name;
			}
			set
			{
				this.o0O0OOo._ooO_O. = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x00099C81 File Offset: 0x00097E81
		// (set) Token: 0x06001612 RID: 5650 RVA: 0x00099C93 File Offset: 0x00097E93
		public float MyFontSize
		{
			get
			{
				return this.o0O0OOo._ooO_O..Font.Size;
			}
			set
			{
				this.o0O0OOo._ooO_O. = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x00099C9C File Offset: 0x00097E9C
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x00099CAE File Offset: 0x00097EAE
		public int MyFontStyle
		{
			get
			{
				return (int)this.o0O0OOo._ooO_O..Font.Style;
			}
			set
			{
				this.o0O0OOo._ooO_O. = value;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00099CB7 File Offset: 0x00097EB7
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x00099CC4 File Offset: 0x00097EC4
		public Color MyFontColor
		{
			get
			{
				return this.o0O0OOo._ooO_O..ForeColor;
			}
			set
			{
				this.O00.O0. = value;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x00099CCD File Offset: 0x00097ECD
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x00099CDF File Offset: 0x00097EDF
		public string budyFontName
		{
			get
			{
				return this.O_O0_o._O0o0O..Font.Name;
			}
			set
			{
				this.OO0oo__._. = value;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x00099CE8 File Offset: 0x00097EE8
		// (set) Token: 0x0600161A RID: 5658 RVA: 0x00099CFA File Offset: 0x00097EFA
		public float budyFontSize
		{
			get
			{
				return this.O_O0_o._O0o0O..Font.Size;
			}
			set
			{
				this.OO0oo__._. = value;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x00099D03 File Offset: 0x00097F03
		// (set) Token: 0x0600161C RID: 5660 RVA: 0x00099D15 File Offset: 0x00097F15
		public int budyFontStyle
		{
			get
			{
				return (int)this.O_O0_o._O0o0O..Font.Style;
			}
			set
			{
				this.OO0oo__._. = value;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x00099D1E File Offset: 0x00097F1E
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x00099D2B File Offset: 0x00097F2B
		public Color budyFontColor
		{
			get
			{
				return this.O_O0_o._O0o0O..ForeColor;
			}
			set
			{
				this.OO0oo__._. = value;
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00099D34 File Offset: 0x00097F34
		internal void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.o0O0OOo._ooO_O., "", true) > 0 && this.o0O0OOo._ooO_O. > 0f)
			{
				Font font = new Font(this.o0O0OOo._ooO_O., this.o0O0OOo._ooO_O., (FontStyle)this.o0O0OOo._ooO_O.);
				this.o0O0OOo._ooO_O..Font = font;
			}
			this.o0O0OOo._ooO_O..ForeColor = this.O00.O0.;
			if (Operators.CompareString(this.OO0oo__._., "", true) > 0 && this.OO0oo__._. > 0f)
			{
				Font font2 = new Font(this.OO0oo__._., this.OO0oo__._., (FontStyle)this.OO0oo__._.);
				this.O_O0_o._O0o0O..Font = font2;
			}
			this.O_O0_o._O0o0O..ForeColor = this.OO0oo__._.;
		}

		// Token: 0x040008B8 RID: 2232
		private CellStyle <<EMPTY_NAME>>;

		// Token: 0x040008B9 RID: 2233
		private CellStyle <<EMPTY_NAME>>;

		// Token: 0x040008BA RID: 2234
		private string <<EMPTY_NAME>>;

		// Token: 0x040008BB RID: 2235
		private float <<EMPTY_NAME>>;

		// Token: 0x040008BC RID: 2236
		private int <<EMPTY_NAME>>;

		// Token: 0x040008BD RID: 2237
		private Color <<EMPTY_NAME>>;

		// Token: 0x040008BE RID: 2238
		private string <<EMPTY_NAME>>;

		// Token: 0x040008BF RID: 2239
		private float <<EMPTY_NAME>>;

		// Token: 0x040008C0 RID: 2240
		private int <<EMPTY_NAME>>;

		// Token: 0x040008C1 RID: 2241
		private Color <<EMPTY_NAME>>;
	}
}
