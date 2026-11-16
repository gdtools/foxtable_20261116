using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020002FE RID: 766
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ChangeEditEventArgs
	{
		// Token: 0x0600299B RID: 10651 RVA: 0x0012AD18 File Offset: 0x00128F18
		public ChangeEditEventArgs(Table A_0, Row A_1, Col A_2, string A_3, RecordGrid A_4)
		{
			this.o.0000OOo_. = A_0;
			this.o.0000OOo_. = A_1;
			this.o.0000OOo_. = A_2;
			this.o.OO. = A_3;
			this.o.0000OOo_. = A_4;
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x0600299C RID: 10652 RVA: 0x0012AD45 File Offset: 0x00128F45
		public Table Table
		{
			get
			{
				return this.o.0000OOo_.;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x0012AD4D File Offset: 0x00128F4D
		public Row Row
		{
			get
			{
				return this.o.0000OOo_.;
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x0012AD55 File Offset: 0x00128F55
		public Col Col
		{
			get
			{
				return this.o.0000OOo_.;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x0600299F RID: 10655 RVA: 0x0012AD5D File Offset: 0x00128F5D
		public string Text
		{
			get
			{
				return this.o.OO.;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x0012AD65 File Offset: 0x00128F65
		public RecordGrid RecordGrid
		{
			get
			{
				return this.o.0000OOo_.;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x060029A1 RID: 10657 RVA: 0x0012AD6D File Offset: 0x00128F6D
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x04001132 RID: 4402
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001133 RID: 4403
		private Row <<EMPTY_NAME>>;

		// Token: 0x04001134 RID: 4404
		private Col <<EMPTY_NAME>>;

		// Token: 0x04001135 RID: 4405
		private string <<EMPTY_NAME>>;

		// Token: 0x04001136 RID: 4406
		private RecordGrid <<EMPTY_NAME>>;
	}
}
