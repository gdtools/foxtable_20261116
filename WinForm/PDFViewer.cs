using System;
using System.IO;
using System.Runtime.InteropServices;
using C1.Win.C1Document;
using C1.Win.FlexViewer;

namespace Foxtable.WinForm
{
	// Token: 0x0200050C RID: 1292
	[ComVisible(true)]
	public class PDFViewer : Control
	{
		// Token: 0x06005457 RID: 21591 RVA: 0x00257B8C File Offset: 0x00255D8C
		internal PDFViewer(C1FlexViewer A_0) : base(A_0, ControlTypeEnum.PDFViewer)
		{
			this.Oo_.0_0O0o00o. = A_0;
			this.Oo_.0_0O0o00o..Ribbon.ConfigToolBar.Visible = false;
			this.Oo_.0_0O0o00o..Ribbon.TopToolBar.Visible = false;
			this.Oo_.0_0O0o00o..Ribbon.BottomToolBar.Visible = false;
			this.Oo_.0_0O0o00o..Ribbon.Qat.Visible = false;
			this.Oo_.0_0O0o00o..ShowOutlines = true;
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06005458 RID: 21592 RVA: 0x00257C0D File Offset: 0x00255E0D
		// (set) Token: 0x06005459 RID: 21593 RVA: 0x00257C1F File Offset: 0x00255E1F
		public bool RibbonVisible
		{
			get
			{
				return this.Oo_.0_0O0o00o..Ribbon.Visible;
			}
			set
			{
				this.Oo_.0_0O0o00o..Ribbon.Visible = value;
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x0600545A RID: 21594 RVA: 0x00257C32 File Offset: 0x00255E32
		// (set) Token: 0x0600545B RID: 21595 RVA: 0x00257C44 File Offset: 0x00255E44
		public bool StatusBarVisible
		{
			get
			{
				return this.Oo_.0_0O0o00o..StatusBar.Visible;
			}
			set
			{
				this.Oo_.0_0O0o00o..StatusBar.Visible = value;
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x0600545C RID: 21596 RVA: 0x00257C57 File Offset: 0x00255E57
		public C1FlexViewer BaseViewer
		{
			get
			{
				return this.Oo_.0_0O0o00o.;
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x0600545D RID: 21597 RVA: 0x00257C5F File Offset: 0x00255E5F
		public RibbonElements RibbonElements
		{
			get
			{
				return this.Oo_.0_0O0o00o..RibbonElements;
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x0600545E RID: 21598 RVA: 0x00257C6C File Offset: 0x00255E6C
		public StatusBarElements StatusBarElements
		{
			get
			{
				return this.Oo_.0_0O0o00o..StatusBarElements;
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x0600545F RID: 21599 RVA: 0x00257C79 File Offset: 0x00255E79
		public SearchBarElements SearchBarElements
		{
			get
			{
				return this.Oo_.0_0O0o00o..SearchBarElements;
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06005460 RID: 21600 RVA: 0x00257C86 File Offset: 0x00255E86
		public ContextMenuElements ContextMenuElements
		{
			get
			{
				return this.Oo_.0_0O0o00o..ContextMenuElements;
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06005461 RID: 21601 RVA: 0x00257C93 File Offset: 0x00255E93
		public ToolBarElements ToolBarElements
		{
			get
			{
				return this.Oo_.0_0O0o00o..ToolBarElements;
			}
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x00257CA0 File Offset: 0x00255EA0
		public void ExecuteAction(FlexViewerAction action)
		{
			this.Oo_.0_0O0o00o..ExecuteAction(action);
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06005463 RID: 21603 RVA: 0x00257CAE File Offset: 0x00255EAE
		// (set) Token: 0x06005464 RID: 21604 RVA: 0x00257CB8 File Offset: 0x00255EB8
		public PDFCreator SourceDocument
		{
			get
			{
				return this.Oo_.0_0O0o00o.;
			}
			set
			{
				this.Oo_.0_0O0o00o. = value;
				C1PdfDocumentSource c1PdfDocumentSource = new C1PdfDocumentSource();
				MemoryStream memoryStream = new MemoryStream();
				value.Save(memoryStream);
				c1PdfDocumentSource.LoadFromStream(memoryStream);
				memoryStream.Close();
				memoryStream.Dispose();
				this.Oo_.0_0O0o00o..DocumentSource = c1PdfDocumentSource;
			}
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x00257D00 File Offset: 0x00255F00
		public void LoadFromFile(string file)
		{
			C1PdfDocumentSource c1PdfDocumentSource = new C1PdfDocumentSource();
			c1PdfDocumentSource.LoadFromFile(file);
			this.Oo_.0_0O0o00o..DocumentSource = c1PdfDocumentSource;
		}

		// Token: 0x040022B3 RID: 8883
		private C1FlexViewer <<EMPTY_NAME>>;

		// Token: 0x040022B4 RID: 8884
		private PDFCreator <<EMPTY_NAME>>;
	}
}
