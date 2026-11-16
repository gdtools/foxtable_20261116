using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.C1Pdf;
using C1.Win.C1Document;
using C1.Win.C1Document.Export;
using C1.Win.FlexViewer;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200046A RID: 1130
	[ComVisible(true)]
	public class PDFCreator : C1PdfDocument
	{
		// Token: 0x06004D29 RID: 19753 RVA: 0x0022CE46 File Offset: 0x0022B046
		public PDFCreator()
		{
			base.Security.AllowPrint = true;
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x0022CE5C File Offset: 0x0022B05C
		public void Show()
		{
			C1PdfDocumentSource c1PdfDocumentSource = new C1PdfDocumentSource();
			MemoryStream memoryStream = new MemoryStream();
			base.Save(memoryStream);
			c1PdfDocumentSource.LoadFromStream(memoryStream);
			memoryStream.Close();
			memoryStream.Dispose();
			C1FlexViewerDialog c1FlexViewerDialog = new C1FlexViewerDialog();
			c1FlexViewerDialog.DocumentSource = c1PdfDocumentSource;
			if (Operators.CompareString(this.PrintJobName, "", true) > 0)
			{
				c1FlexViewerDialog.PrintJobName = this.PrintJobName;
			}
			c1FlexViewerDialog.ShowDialog();
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x0022CEC4 File Offset: 0x0022B0C4
		public void Print()
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				C1PdfDocumentSource c1PdfDocumentSource = new C1PdfDocumentSource();
				IL_0F:
				num2 = 3;
				MemoryStream memoryStream = new MemoryStream();
				IL_18:
				num2 = 4;
				base.Save(memoryStream);
				IL_22:
				num2 = 5;
				c1PdfDocumentSource.LoadFromStream(memoryStream);
				IL_2C:
				num2 = 6;
				memoryStream.Close();
				IL_35:
				num2 = 7;
				memoryStream.Dispose();
				IL_3E:
				num2 = 8;
				C1FlexViewerDialog c1FlexViewerDialog = new C1FlexViewerDialog();
				IL_47:
				num2 = 9;
				c1FlexViewerDialog.DocumentSource = c1PdfDocumentSource;
				IL_52:
				num2 = 10;
				c1FlexViewerDialog.WindowState = FormWindowState.Minimized;
				IL_5D:
				num2 = 11;
				c1FlexViewerDialog.ShowInTaskbar = false;
				IL_68:
				num2 = 12;
				if (Operators.CompareString(this.PrintJobName, "", true) <= 0)
				{
					goto IL_8F;
				}
				IL_7F:
				num2 = 13;
				c1FlexViewerDialog.PrintJobName = this.PrintJobName;
				IL_8F:
				num2 = 14;
				c1FlexViewerDialog.Show();
				IL_99:
				num2 = 15;
				c1FlexViewerDialog.Hide();
				IL_A3:
				num2 = 16;
				c1FlexViewerDialog.Print();
				IL_AE:
				num2 = 17;
				c1FlexViewerDialog.Close();
				IL_B8:
				num2 = 18;
				c1FlexViewerDialog.Dispose();
				IL_C2:
				goto IL_160;
				IL_C7:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_121:
				goto IL_155;
				IL_123:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_133:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_123;
			}
			IL_155:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_160:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06004D2C RID: 19756 RVA: 0x0022D058 File Offset: 0x0022B258
		// (set) Token: 0x06004D2D RID: 19757 RVA: 0x0022D060 File Offset: 0x0022B260
		public string PrintJobName
		{
			get
			{
				return this.O_0o0.OoO_o.;
			}
			set
			{
				this.O_0o0.OoO_o. = value;
			}
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x0022D06C File Offset: 0x0022B26C
		public new void Save(string fileName)
		{
			string parentPath = OO_00oOO.FileSys.GetParentPath(fileName);
			if (OO_00oOO.FileSys.DirectoryExists(parentPath))
			{
				OO_00oOO.FileSys.CreateDirectory(parentPath);
			}
			base.Save(fileName);
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x0022D0A4 File Offset: 0x0022B2A4
		public void SaveToHtmL(string fileName)
		{
			string parentPath = OO_00oOO.FileSys.GetParentPath(fileName);
			if (OO_00oOO.FileSys.DirectoryExists(parentPath))
			{
				OO_00oOO.FileSys.CreateDirectory(parentPath);
			}
			this.HtmlFilter.FileName = fileName;
			C1PdfDocumentSource c1PdfDocumentSource = new C1PdfDocumentSource();
			MemoryStream stream = new MemoryStream();
			base.Save(stream);
			c1PdfDocumentSource.LoadFromStream(stream);
			c1PdfDocumentSource.Export(this.HtmlFilter);
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06004D30 RID: 19760 RVA: 0x0022D105 File Offset: 0x0022B305
		public HtmlFilter HtmlFilter
		{
			get
			{
				if (this.O_0o0.OoO_o. == null)
				{
					this.O_0o0.OoO_o. = new HtmlFilter();
					this.O_0o0.OoO_o..DocumentInfo = new DocumentInfo();
				}
				return this.O_0o0.OoO_o.;
			}
		}

		// Token: 0x04001F7D RID: 8061
		private string <<EMPTY_NAME>>;

		// Token: 0x04001F7E RID: 8062
		private HtmlFilter <<EMPTY_NAME>>;
	}
}
