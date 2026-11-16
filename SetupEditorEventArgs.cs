using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200030B RID: 779
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class SetupEditorEventArgs
	{
		// Token: 0x06002A13 RID: 10771 RVA: 0x0012B907 File Offset: 0x00129B07
		public SetupEditorEventArgs(Table A_0, Row A_1, Col A_2, System.Windows.Forms.Control A_3, RecordGrid A_4)
		{
			this.OoO.Oo0O0o. = A_0;
			this.OoO.Oo0O0o. = A_1;
			this.OoO.Oo0O0o. = A_2;
			this.OoO.Oo0O0o. = A_3;
			this.OoO.Oo0O0o. = A_4;
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002A14 RID: 10772 RVA: 0x0012B934 File Offset: 0x00129B34
		public Table Table
		{
			get
			{
				return this.OoO.Oo0O0o.;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x0012B93C File Offset: 0x00129B3C
		public Row Row
		{
			get
			{
				return this.OoO.Oo0O0o.;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06002A16 RID: 10774 RVA: 0x0012B944 File Offset: 0x00129B44
		public Col Col
		{
			get
			{
				return this.OoO.Oo0O0o.;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x0012B94C File Offset: 0x00129B4C
		public System.Windows.Forms.Control Editor
		{
			get
			{
				return this.OoO.Oo0O0o.;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002A18 RID: 10776 RVA: 0x0012B954 File Offset: 0x00129B54
		// (set) Token: 0x06002A19 RID: 10777 RVA: 0x0012B95C File Offset: 0x00129B5C
		public bool Cancel
		{
			get
			{
				return this.OoO.Oo0O0o.;
			}
			set
			{
				this.OoO.Oo0O0o. = value;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002A1A RID: 10778 RVA: 0x0012B965 File Offset: 0x00129B65
		public RecordGrid RecordGrid
		{
			get
			{
				return this.OoO.Oo0O0o.;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x0012B96D File Offset: 0x00129B6D
		public Foxtable.WinForm.Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x04001169 RID: 4457
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400116A RID: 4458
		private Row <<EMPTY_NAME>>;

		// Token: 0x0400116B RID: 4459
		private Col <<EMPTY_NAME>>;

		// Token: 0x0400116C RID: 4460
		private System.Windows.Forms.Control <<EMPTY_NAME>>;

		// Token: 0x0400116D RID: 4461
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400116E RID: 4462
		private RecordGrid <<EMPTY_NAME>>;
	}
}
