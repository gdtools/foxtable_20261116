using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;
using C1.C1Preview;
using C1.C1Preview.Export;
using C1.Win.C1Preview;
using Foxtable.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 专业报表
	/// </summary>
	// Token: 0x02000470 RID: 1136
	[oO0oooo("1167")]
	public class PrintDoc : C1PrintDocument
	{
		// Token: 0x06004D59 RID: 19801 RVA: 0x0022DF5C File Offset: 0x0022C15C
		public PrintDoc()
		{
			base.PageAdded += this.Document_PageAdded;
			this.OoO0000.0. = true;
			this.OoO0000.0. = 12;
			base.DefaultUnit = UnitTypeEnum.Mm;
			base.ScriptingOptions.ExternalAssemblies.Add(Application.ExecutablePath);
			base.ScriptingOptions.Namespaces.Add("Foxtable");
		}

		/// <summary>
		/// 打印预览
		/// </summary>
		// Token: 0x06004D5A RID: 19802 RVA: 0x0022DFC3 File Offset: 0x0022C1C3
		[oO0oooo("3246")]
		public void Preview()
		{
			this.Preview(false);
		}

		/// <summary>
		/// 打印预览
		/// </summary>
		/// <param name="DisablePrintButton">是否禁止打印</param>
		// Token: 0x06004D5B RID: 19803 RVA: 0x0022DFCC File Offset: 0x0022C1CC
		[oO0oooo("3246")]
		public void Preview(bool DisablePrintButton)
		{
			this.OoO0000.0. = new o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000();
			this.OoO0000.0..Oo0._.("准备生成页面...");
			this.OoO0000.0..Show(Main.OO_O.o.);
			Application.DoEvents();
			try
			{
				if (O_O0OO.O00.00OO000___.())
				{
					ooO.O._oO_0O__o__o.(this);
				}
				base.Generate();
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
				this.OoO0000.0..Close();
			}
			if (base.Cancel)
			{
				this.OoO0000.0..Close();
				return;
			}
			this.OoO0000.0..Oo0._.("准备预览...");
			this.OoO0000.0..Ooo_oo._o.().Enabled = false;
			Application.DoEvents();
			C1PrintPreviewDialog c1PrintPreviewDialog = new C1PrintPreviewDialog();
			c1PrintPreviewDialog.ShowInTaskbar = false;
			c1PrintPreviewDialog.PreviewPane.ZoomMode = ZoomModeEnum.ActualSize;
			c1PrintPreviewDialog.PreviewPane.PrintOptions.AutoRotate = this.AutoRotate;
			c1PrintPreviewDialog.PreviewPane.PrintOptions.CenterPage = false;
			c1PrintPreviewDialog.PreviewPane.PrintOptions.PageScaling = PageScalingEnum.None;
			c1PrintPreviewDialog.Text = "打印预览";
			c1PrintPreviewDialog.Icon = a.O_.o_0oo_000_.();
			c1PrintPreviewDialog.Document = this;
			c1PrintPreviewDialog.PreviewPane.PrinterSettings = base.PageLayout.PageSettings.ToPageSettings().PrinterSettings;
			c1PrintPreviewDialog.PreviewPane.PrinterSettings.PrinterName = this.PrinterName;
			c1PrintPreviewDialog.PreviewPane.PrintOptions.AutoRotate = this.AutoRotate;
			if (Operators.CompareString(this.PaperSource, "", true) > 0)
			{
				try
				{
					foreach (object obj in c1PrintPreviewDialog.PreviewPane.PrinterSettings.PaperSources)
					{
						PaperSource paperSource = (PaperSource)obj;
						if (Operators.CompareString(paperSource.SourceName, this.PaperSource, true) == 0)
						{
							base.PageLayout.PageSettings.PaperSourceKind = paperSource.Kind;
							c1PrintPreviewDialog.PreviewPane.PageSettings.PaperSource = paperSource;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			c1PrintPreviewDialog.WindowState = FormWindowState.Maximized;
			Application.DoEvents();
			c1PrintPreviewDialog.PreviewPane.PrintOptions.AutoRotate = this.AutoRotate;
			this.OoO0000.0..Close();
			if (DisablePrintButton)
			{
				c1PrintPreviewDialog.Show();
				c1PrintPreviewDialog.Hide();
				O_O0OO.o00.0.(c1PrintPreviewDialog);
				c1PrintPreviewDialog.ShowDialog();
			}
			else
			{
				c1PrintPreviewDialog.ShowDialog();
			}
			this.OoO0000.0..Dispose();
			this.OoO0000.0. = null;
			c1PrintPreviewDialog.Dispose();
			base.Body.Children.Clear();
			base.Dispose();
			GC.Collect();
		}

		/// <summary>
		/// 打印
		/// </summary>
		// Token: 0x06004D5C RID: 19804 RVA: 0x0022E26C File Offset: 0x0022C46C
		public new void Print()
		{
			this.OoO0000.0. = new o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000();
			this.OoO0000.0..Oo0._.("准备生成页面...");
			this.OoO0000.0..Show(Main.OO_O.o.);
			Application.DoEvents();
			if (O_O0OO.O00.00OO000___.())
			{
				ooO.O._oO_0O__o__o.(this);
			}
			base.Generate();
			if (base.Cancel)
			{
				this.OoO0000.0..Close();
				return;
			}
			this.OoO0000.0..Oo0._.("开始打印...");
			this.OoO0000.0..Ooo_oo._o.().Enabled = false;
			Application.DoEvents();
			PrinterSettings printerSettings = base.PageLayout.PageSettings.ToPageSettings().PrinterSettings;
			C1PrintManager c1PrintManager = new C1PrintManager();
			c1PrintManager.PrintOptions.AutoRotate = this.AutoRotate;
			c1PrintManager.PrintOptions.CenterPage = false;
			c1PrintManager.PrintOptions.PageScaling = PageScalingEnum.None;
			if (Operators.CompareString(this.PrinterName, "", true) > 0)
			{
				printerSettings.PrinterName = this.PrinterName;
			}
			if (Operators.CompareString(this.PaperSource, "", true) > 0)
			{
				try
				{
					foreach (object obj in printerSettings.PaperSources)
					{
						PaperSource paperSource = (PaperSource)obj;
						if (Operators.CompareString(paperSource.SourceName, this.PaperSource, true) == 0)
						{
							base.PageLayout.PageSettings.PaperSourceKind = paperSource.Kind;
						}
					}
					goto IL_165;
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			c1PrintManager.PrintOptions.AutoPaperSource = true;
			IL_165:
			c1PrintManager.Document = this;
			c1PrintManager.Print(printerSettings);
			this.OoO0000.0..Close();
			this.OoO0000.0..Dispose();
			this.OoO0000.0. = null;
			base.Body.Children.Clear();
			base.Dispose();
			GC.Collect();
		}

		/// <summary>
		/// 将报表保存为HTML文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		/// <param name="ShowProcess">是否显示进度</param>
		// Token: 0x06004D5D RID: 19805 RVA: 0x0022E434 File Offset: 0x0022C634
		[oO0oooo("2450")]
		public void SaveHTM(string FileName, bool ShowProcess)
		{
			string parentPath = OO_00oOO.FileSys.GetParentPath(FileName);
			if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
			{
				OO_00oOO.FileSys.CreateDirectory(parentPath);
			}
			if (ShowProcess)
			{
				this.OoO0000.0. = new o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000();
				this.OoO0000.0..Text = "生成进度";
				this.OoO0000.0..Oo0._.("准备生成页面...");
				this.OoO0000.0..Show(Main.OO_O.o.);
			}
			Application.DoEvents();
			if (O_O0OO.O00.00OO000___.())
			{
				ooO.O._oO_0O__o__o.(this);
			}
			base.Generate();
			if (!base.Cancel)
			{
				if (ShowProcess)
				{
					this.OoO0000.0..Oo0._.("正在保存...");
					this.OoO0000.0..Ooo_oo._o.().Enabled = false;
				}
				Application.DoEvents();
				new HtmlExporter
				{
					Document = this,
					FixedPositioning = true,
					ShowOptions = false,
					Preview = false
				}.Export(FileName);
				if (ShowProcess)
				{
					this.OoO0000.0..Close();
					this.OoO0000.0..Dispose();
					this.OoO0000.0. = null;
				}
				base.Body.Children.Clear();
				base.Dispose();
				GC.Collect();
			}
		}

		/// <summary>
		/// 将报表保存为HTML文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		// Token: 0x06004D5E RID: 19806 RVA: 0x0022E552 File Offset: 0x0022C752
		[oO0oooo("2450")]
		public void SaveHTM(string FileName)
		{
			this.SaveHTM(FileName, false);
		}

		/// <summary>
		/// 将报表保存为PDF文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		/// <param name="ShowProcess">是否显示进度</param>
		// Token: 0x06004D5F RID: 19807 RVA: 0x0022E55C File Offset: 0x0022C75C
		[oO0oooo("2450")]
		public void SavePDF(string FileName, bool ShowProcess)
		{
			string parentPath = OO_00oOO.FileSys.GetParentPath(FileName);
			if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
			{
				OO_00oOO.FileSys.CreateDirectory(parentPath);
			}
			if (ShowProcess)
			{
				this.OoO0000.0. = new o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000();
				this.OoO0000.0..Text = "生成进度";
				this.OoO0000.0..Oo0._.("准备生成页面...");
				this.OoO0000.0..Show(Main.OO_O.o.);
			}
			Application.DoEvents();
			if (O_O0OO.O00.00OO000___.())
			{
				ooO.O._oO_0O__o__o.(this);
			}
			base.Generate();
			if (!base.Cancel)
			{
				if (ShowProcess)
				{
					this.OoO0000.0..Oo0._.("正在保存...");
					this.OoO0000.0..Ooo_oo._o.().Enabled = false;
				}
				Application.DoEvents();
				new PdfExporter
				{
					Document = this,
					ShowOptions = false,
					Preview = false
				}.Export(FileName);
				if (ShowProcess)
				{
					this.OoO0000.0..Close();
					this.OoO0000.0..Dispose();
					this.OoO0000.0. = null;
				}
				base.Body.Children.Clear();
				base.Dispose();
				GC.Collect();
			}
		}

		/// <summary>
		/// 将报表保存为PDF文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		// Token: 0x06004D60 RID: 19808 RVA: 0x0022E673 File Offset: 0x0022C873
		[oO0oooo("2450")]
		public void SavePDF(string FileName)
		{
			this.SavePDF(FileName, true);
		}

		/// <summary>
		/// 将报表保存为图片文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		/// <param name="Resolution">可选参数，用于设置图片分辨率，默认为150，数值越大，图片越清晰，当然文件尺寸也会越大</param>
		/// <param name="ShowProcess">是否显示进度</param>
		// Token: 0x06004D61 RID: 19809 RVA: 0x0022E680 File Offset: 0x0022C880
		[oO0oooo("2450")]
		public void SaveImage(string FileName, float Resolution, bool ShowProcess)
		{
			string parentPath = OO_00oOO.FileSys.GetParentPath(FileName);
			if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
			{
				OO_00oOO.FileSys.CreateDirectory(parentPath);
			}
			if (ShowProcess)
			{
				this.OoO0000.0. = new o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000();
				this.OoO0000.0..Text = "生成进度";
				this.OoO0000.0..Oo0._.("准备生成页面...");
				this.OoO0000.0..Show(Main.OO_O.o.);
			}
			Application.DoEvents();
			if (O_O0OO.O00.00OO000___.())
			{
				ooO.O._oO_0O__o__o.(this);
			}
			base.Generate();
			if (!base.Cancel)
			{
				if (ShowProcess)
				{
					this.OoO0000.0..Oo0._.("正在保存...");
					this.OoO0000.0..Ooo_oo._o.().Enabled = false;
				}
				Application.DoEvents();
				new ImageExporter
				{
					ImageFormat = O_O0OO.OoO_00._.(FileName),
					Resolution = Resolution,
					Document = this,
					ShowOptions = false,
					Preview = false
				}.Export(FileName);
				if (ShowProcess)
				{
					this.OoO0000.0..Close();
					this.OoO0000.0..Dispose();
					this.OoO0000.0. = null;
				}
				base.Body.Children.Clear();
				base.Dispose();
				GC.Collect();
			}
		}

		/// <summary>
		/// 将报表保存为图片文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		/// <param name="Resolution">可选参数，用于设置图片分辨率，默认为150，数值越大，图片越清晰，当然文件尺寸也会越大</param>
		// Token: 0x06004D62 RID: 19810 RVA: 0x0022E7AA File Offset: 0x0022C9AA
		[oO0oooo("2450")]
		public void SaveImage(string FileName, float Resolution = 150f)
		{
			this.SaveImage(FileName, Resolution, false);
		}

		/// <summary>
		/// 将报表保存为图片文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		/// <param name="ShowProcess">是否显示进度</param>
		// Token: 0x06004D63 RID: 19811 RVA: 0x0022E7B5 File Offset: 0x0022C9B5
		[oO0oooo("2450")]
		public void SaveImage(string FileName, bool showProcess)
		{
			this.SaveImage(FileName, 150f, showProcess);
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x0022E7C4 File Offset: 0x0022C9C4
		private void Document_PageAdded(C1PrintDocument sender, PageEventArgs e)
		{
			if (this.OoO0000.0. != null)
			{
				this.OoO0000.0..Oo0._.("正在生成第" + Conversions.ToString(base.Pages.Count) + "页...");
				Application.DoEvents();
				if (this.OoO0000.0..Ooo_oo._o.())
				{
					base.Cancel = true;
				}
			}
		}

		/// <summary>
		/// 指定打印机
		/// </summary>
		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06004D65 RID: 19813 RVA: 0x0022E81C File Offset: 0x0022CA1C
		// (set) Token: 0x06004D66 RID: 19814 RVA: 0x0022E824 File Offset: 0x0022CA24
		[oO0oooo("1588")]
		public string PrinterName
		{
			get
			{
				return this.OoO0000.0.;
			}
			set
			{
				try
				{
					List<string>.Enumerator enumerator = OO_00oOO.InstalledPrinters.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(enumerator.Current, value, true) == 0)
						{
							this.OoO0000.0. = value;
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		/// <summary>
		/// 是否自动旋转
		/// </summary>
		/// <returns></returns>
		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06004D67 RID: 19815 RVA: 0x0022E880 File Offset: 0x0022CA80
		// (set) Token: 0x06004D68 RID: 19816 RVA: 0x0022E888 File Offset: 0x0022CA88
		[oO0oooo("1589")]
		public bool AutoRotate
		{
			get
			{
				return this.OoO0000.0.;
			}
			set
			{
				this.OoO0000.0. = value;
			}
		}

		/// <summary>
		/// 页面设置
		/// </summary>
		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06004D69 RID: 19817 RVA: 0x0022E891 File Offset: 0x0022CA91
		[oO0oooo("1188")]
		public C1PageSettings PageSetting
		{
			get
			{
				return base.PageLayout.PageSettings;
			}
		}

		/// <summary>
		/// 页眉
		/// </summary>
		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06004D6A RID: 19818 RVA: 0x0022E89E File Offset: 0x0022CA9E
		// (set) Token: 0x06004D6B RID: 19819 RVA: 0x0022E8AB File Offset: 0x0022CAAB
		[oO0oooo("1197")]
		public RenderObject PageHeader
		{
			get
			{
				return base.PageLayout.PageHeader;
			}
			set
			{
				base.PageLayout.PageHeader = value;
			}
		}

		/// <summary>
		/// 页脚
		/// </summary>
		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06004D6C RID: 19820 RVA: 0x0022E8B9 File Offset: 0x0022CAB9
		// (set) Token: 0x06004D6D RID: 19821 RVA: 0x0022E8C6 File Offset: 0x0022CAC6
		[oO0oooo("1197")]
		public RenderObject PageFooter
		{
			get
			{
				return base.PageLayout.PageFooter;
			}
			set
			{
				base.PageLayout.PageFooter = value;
			}
		}

		/// <summary>
		/// 设置水印
		/// </summary>
		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06004D6E RID: 19822 RVA: 0x0022E8D4 File Offset: 0x0022CAD4
		// (set) Token: 0x06004D6F RID: 19823 RVA: 0x0022E8E1 File Offset: 0x0022CAE1
		[oO0oooo("1198")]
		public RenderObject WaterMark
		{
			get
			{
				return base.PageLayout.Watermark;
			}
			set
			{
				base.PageLayout.Watermark = value;
			}
		}

		/// <summary>
		/// 设置纸张来源纸盒
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06004D70 RID: 19824 RVA: 0x0022E8EF File Offset: 0x0022CAEF
		// (set) Token: 0x06004D71 RID: 19825 RVA: 0x0022E8F8 File Offset: 0x0022CAF8
		public string PaperSource
		{
			get
			{
				return this.oo00.0.;
			}
			set
			{
				PrinterSettings printerSettings = new PrinterSettings();
				if (Operators.CompareString(this.PrinterName, "", true) > 0)
				{
					printerSettings.PrinterName = this.PrinterName;
				}
				else
				{
					printerSettings.PrinterName = base.PageLayout.PageSettings.ToPageSettings().PrinterSettings.PrinterName;
				}
				try
				{
					IEnumerator enumerator = printerSettings.PaperSources.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(((PaperSource)enumerator.Current).SourceName, value, true) == 0)
						{
							this.oo00.0. = value;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 分栏打印
		/// </summary>
		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06004D72 RID: 19826 RVA: 0x0022E9AC File Offset: 0x0022CBAC
		[oO0oooo("1193")]
		public PageColumnDefCollection Columns
		{
			get
			{
				return base.PageLayout.Columns;
			}
		}

		// Token: 0x04001F9D RID: 8093
		private o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000 <<EMPTY_NAME>>;

		// Token: 0x04001F9E RID: 8094
		private string <<EMPTY_NAME>>;

		// Token: 0x04001F9F RID: 8095
		private string <<EMPTY_NAME>>;

		// Token: 0x04001FA0 RID: 8096
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001FA1 RID: 8097
		private int <<EMPTY_NAME>>;
	}
}
