using System;
using C1.Win.C1Document;
using C1.Win.C1Document.Export;

namespace Foxtable
{
	// Token: 0x0200046B RID: 1131
	public class PDFSource : C1PdfDocumentSource
	{
		// Token: 0x06004D32 RID: 19762 RVA: 0x0022D138 File Offset: 0x0022B338
		public void Save(string FileName)
		{
			string parentPath = OO_00oOO.FileSys.GetParentPath(FileName);
			if (OO_00oOO.FileSys.DirectoryExists(parentPath))
			{
				OO_00oOO.FileSys.CreateDirectory(parentPath);
			}
			this.PdfFilter.FileName = FileName;
			if (this.O00oO_00O._. != null)
			{
				this.PdfFilter.DocumentInfo = this.O00oO_00O._.;
			}
			base.Export(this.PdfFilter);
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x0022D19C File Offset: 0x0022B39C
		public void SaveToHTML(string FileName)
		{
			string parentPath = OO_00oOO.FileSys.GetParentPath(FileName);
			if (OO_00oOO.FileSys.DirectoryExists(parentPath))
			{
				OO_00oOO.FileSys.CreateDirectory(parentPath);
			}
			this.HtmlFilter.FileName = FileName;
			if (this.O00oO_00O._. != null)
			{
				this.HtmlFilter.DocumentInfo = this.O00oO_00O._.;
			}
			base.Export(this.HtmlFilter);
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06004D34 RID: 19764 RVA: 0x0022D1FE File Offset: 0x0022B3FE
		public PdfSecurityOptions Security
		{
			get
			{
				return this.PdfFilter.PdfSecurityOptions;
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06004D35 RID: 19765 RVA: 0x0022D20B File Offset: 0x0022B40B
		public DocumentInfo DocumentInfo
		{
			get
			{
				if (this.O00oO_00O._. == null)
				{
					this.O00oO_00O._. = new DocumentInfo();
				}
				return this.O00oO_00O._.;
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06004D36 RID: 19766 RVA: 0x0022D226 File Offset: 0x0022B426
		public PdfFilter PdfFilter
		{
			get
			{
				if (this.O00oO_00O._. == null)
				{
					this.O00oO_00O._. = new PdfFilter();
				}
				return this.O00oO_00O._.;
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06004D37 RID: 19767 RVA: 0x0022D241 File Offset: 0x0022B441
		public HtmlFilter HtmlFilter
		{
			get
			{
				if (this.O00oO_00O._. == null)
				{
					this.O00oO_00O._. = new HtmlFilter();
				}
				return this.O00oO_00O._.;
			}
		}

		// Token: 0x04001F7F RID: 8063
		private DocumentInfo <<EMPTY_NAME>>;

		// Token: 0x04001F80 RID: 8064
		private PdfFilter <<EMPTY_NAME>>;

		// Token: 0x04001F81 RID: 8065
		private HtmlFilter <<EMPTY_NAME>>;
	}
}
