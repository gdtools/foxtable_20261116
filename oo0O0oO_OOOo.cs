using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.C1Pdf;
using C1.Win.C1Document;
using C1.Win.C1Ribbon;
using C1.Win.FlexViewer;
using C1.Win.Map;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Web.WebView2.WinForms;

namespace Foxtable
{
	// Token: 0x020000D2 RID: 210
	[DesignerGenerated]
	public partial class oo0O0oO_OOOo : Form
	{
		// Token: 0x06000952 RID: 2386 RVA: 0x0004CC1C File Offset: 0x0004AE1C
		public oo0O0oO_OOOo()
		{
			this.oo00O.o.();
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0004CC2C File Offset: 0x0004AE2C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O0o.O_O0. != null)
				{
					this.O0o.O_O0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0004CC6C File Offset: 0x0004AE6C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O0o.O_O0. = new Container();
			this.oo00O.o.(new C1PdfDocument());
			this.O0o.O_O0.(new C1PdfDocumentSource(this.O0o.O_O0.));
			this.oo00O.o.(new C1FlexViewerDialog(this.O0o.O_O0.));
			this.oo00O.o.(new C1Map());
			this.O0o.O_O0.(new WebView2());
			((ISupportInitialize)this.oo00O.o.()).BeginInit();
			((ISupportInitialize)this.oo00O.o.()).BeginInit();
			((ISupportInitialize)this.oo00O.o.()).BeginInit();
			base.SuspendLayout();
			this.oo00O.o.().DocumentInfo.Author = "";
			this.oo00O.o.().DocumentInfo.CreationDate = new DateTime(0L);
			this.oo00O.o.().DocumentInfo.Creator = "";
			this.oo00O.o.().DocumentInfo.Keywords = "";
			this.oo00O.o.().DocumentInfo.Producer = "ComponentOne C1Pdf";
			this.oo00O.o.().DocumentInfo.Subject = "";
			this.oo00O.o.().DocumentInfo.Title = "";
			this.oo00O.o.().MaxHeaderBookmarkLevel = 0;
			this.oo00O.o.().PdfVersion = "1.3";
			this.oo00O.o.().RefDC = null;
			this.oo00O.o.().RotateAngle = 0f;
			this.oo00O.o.().UseFastTextOut = true;
			this.oo00O.o.().UseFontShaping = true;
			this.oo00O.o.().AutoScaleDimensions = new SizeF(96f, 96f);
			this.oo00O.o.().AutoScaleMode = AutoScaleMode.Dpi;
			this.oo00O.o.().ClientSize = new Size(935, 603);
			this.oo00O.o.().Name = "C1FlexViewerDialog";
			this.oo00O.o.().Text = "C1FlexViewerDialog1";
			this.oo00O.o.().VisualStyleHolder = VisualStyle.Custom;
			this.oo00O.o.().DistanceScale.Alignment = ContentAlignment.BottomLeft;
			this.oo00O.o.().DistanceScale.BarStyle.BackColor = Color.Black;
			this.oo00O.o.().Enabled = false;
			this.oo00O.o.().Location = new Point(33, 12);
			this.oo00O.o.().Name = "C1Map1";
			this.oo00O.o.().PanTool.MarkerStyle.BackColor = Color.FromArgb(131, 176, 202);
			this.oo00O.o.().PanTool.MarkerStyle.BackColor2 = Color.FromArgb(185, 224, 245);
			this.oo00O.o.().PanTool.MarkerStyle.GradientStyle = GradientStyle.Vertical;
			this.oo00O.o.().PanTool.PanStyle.BackColor = Color.FromArgb(243, 243, 243);
			this.oo00O.o.().PanTool.PanStyle.BackColor2 = Color.FromArgb(204, 204, 204);
			this.oo00O.o.().PanTool.PanStyle.GradientStyle = GradientStyle.Vertical;
			this.oo00O.o.().PanTool.PanStyle.Stroke.Color = Color.FromArgb(168, 168, 168);
			this.oo00O.o.().PanTool.PanStyle.Stroke.Width = 1f;
			this.oo00O.o.().Proxy = null;
			this.oo00O.o.().Size = new Size(464, 294);
			this.oo00O.o.().TabIndex = 0;
			this.oo00O.o.().Text = "C1Map1";
			this.oo00O.o.().Viewport.Padding = new Padding(3);
			this.oo00O.o.().ZoomTool.ButtonStyle.BackColor = Color.FromArgb(243, 243, 243);
			this.oo00O.o.().ZoomTool.ButtonStyle.BackColor2 = Color.FromArgb(204, 204, 204);
			this.oo00O.o.().ZoomTool.ButtonStyle.Border.Bottom.Color = Color.FromArgb(168, 168, 168);
			this.oo00O.o.().ZoomTool.ButtonStyle.Border.Bottom.Width = 1f;
			this.oo00O.o.().ZoomTool.ButtonStyle.Border.Left.Color = Color.FromArgb(168, 168, 168);
			this.oo00O.o.().ZoomTool.ButtonStyle.Border.Left.Width = 1f;
			this.oo00O.o.().ZoomTool.ButtonStyle.Border.Right.Color = Color.FromArgb(168, 168, 168);
			this.oo00O.o.().ZoomTool.ButtonStyle.Border.Right.Width = 1f;
			this.oo00O.o.().ZoomTool.ButtonStyle.Border.RoundRadius.BottomLeft = 3;
			this.oo00O.o.().ZoomTool.ButtonStyle.Border.RoundRadius.BottomRight = 3;
			this.oo00O.o.().ZoomTool.ButtonStyle.Border.RoundRadius.TopLeft = 3;
			this.oo00O.o.().ZoomTool.ButtonStyle.Border.RoundRadius.TopRight = 3;
			this.oo00O.o.().ZoomTool.ButtonStyle.Border.Top.Color = Color.FromArgb(168, 168, 168);
			this.oo00O.o.().ZoomTool.ButtonStyle.Border.Top.Width = 1f;
			this.oo00O.o.().ZoomTool.ButtonStyle.GradientStyle = GradientStyle.Vertical;
			this.oo00O.o.().ZoomTool.Margin = new Padding(20, 70, 0, 0);
			this.oo00O.o.().ZoomTool.ThumbStyle.BackColor = Color.FromArgb(243, 243, 243);
			this.oo00O.o.().ZoomTool.ThumbStyle.BackColor2 = Color.FromArgb(131, 176, 202);
			this.oo00O.o.().ZoomTool.ThumbStyle.Border.Bottom.Color = Color.FromArgb(138, 176, 198);
			this.oo00O.o.().ZoomTool.ThumbStyle.Border.Bottom.Width = 1f;
			this.oo00O.o.().ZoomTool.ThumbStyle.Border.Left.Color = Color.FromArgb(138, 176, 198);
			this.oo00O.o.().ZoomTool.ThumbStyle.Border.Left.Width = 1f;
			this.oo00O.o.().ZoomTool.ThumbStyle.Border.Right.Color = Color.FromArgb(138, 176, 198);
			this.oo00O.o.().ZoomTool.ThumbStyle.Border.Right.Width = 1f;
			this.oo00O.o.().ZoomTool.ThumbStyle.Border.RoundRadius.BottomLeft = 3;
			this.oo00O.o.().ZoomTool.ThumbStyle.Border.RoundRadius.BottomRight = 3;
			this.oo00O.o.().ZoomTool.ThumbStyle.Border.RoundRadius.TopLeft = 3;
			this.oo00O.o.().ZoomTool.ThumbStyle.Border.RoundRadius.TopRight = 3;
			this.oo00O.o.().ZoomTool.ThumbStyle.Border.Top.Color = Color.FromArgb(138, 176, 198);
			this.oo00O.o.().ZoomTool.ThumbStyle.Border.Top.Width = 1f;
			this.oo00O.o.().ZoomTool.ThumbStyle.GradientStyle = GradientStyle.Vertical;
			this.oo00O.o.().ZoomTool.TrackStyle.BackColor = Color.FromArgb(203, 203, 203);
			this.oo00O.o.().ZoomTool.TrackStyle.Border.Bottom.Color = Color.FromArgb(168, 168, 168);
			this.oo00O.o.().ZoomTool.TrackStyle.Border.Bottom.Width = 1f;
			this.oo00O.o.().ZoomTool.TrackStyle.Border.Left.Color = Color.FromArgb(168, 168, 168);
			this.oo00O.o.().ZoomTool.TrackStyle.Border.Left.Width = 1f;
			this.oo00O.o.().ZoomTool.TrackStyle.Border.Right.Color = Color.FromArgb(168, 168, 168);
			this.oo00O.o.().ZoomTool.TrackStyle.Border.Right.Width = 1f;
			this.oo00O.o.().ZoomTool.TrackStyle.Border.RoundRadius.BottomLeft = 3;
			this.oo00O.o.().ZoomTool.TrackStyle.Border.RoundRadius.BottomRight = 3;
			this.oo00O.o.().ZoomTool.TrackStyle.Border.RoundRadius.TopLeft = 3;
			this.oo00O.o.().ZoomTool.TrackStyle.Border.RoundRadius.TopRight = 3;
			this.oo00O.o.().ZoomTool.TrackStyle.Border.Top.Color = Color.FromArgb(168, 168, 168);
			this.oo00O.o.().ZoomTool.TrackStyle.Border.Top.Width = 1f;
			this.oo00O.o.().AllowExternalDrop = true;
			this.oo00O.o.().CreationProperties = null;
			this.oo00O.o.().DefaultBackgroundColor = Color.White;
			this.oo00O.o.().Location = new Point(469, 335);
			this.oo00O.o.().Name = "WebView21";
			this.oo00O.o.().Size = new Size(124, 60);
			this.oo00O.o.().TabIndex = 1;
			this.oo00O.o.().ZoomFactor = 1.0;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(800, 450);
			base.Controls.Add(this.oo00O.o.());
			base.Controls.Add(this.oo00O.o.());
			base.Name = "Form4";
			this.Text = "Form4";
			((ISupportInitialize)this.oo00O.o.()).EndInit();
			((ISupportInitialize)this.oo00O.o.()).EndInit();
			((ISupportInitialize)this.oo00O.o.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0004D7D2 File Offset: 0x0004B9D2
		[CompilerGenerated]
		internal virtual C1PdfDocument <<EMPTY_NAME>>()
		{
			return this.O0o.O_O0.;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0004D7DA File Offset: 0x0004B9DA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1PdfDocument A_0)
		{
			this.O0o.O_O0. = A_0;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0004D7E3 File Offset: 0x0004B9E3
		[CompilerGenerated]
		internal virtual C1PdfDocumentSource <<EMPTY_NAME>>()
		{
			return this.O0o.O_O0.;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0004D7EB File Offset: 0x0004B9EB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1PdfDocumentSource A_0)
		{
			this.O0o.O_O0. = A_0;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0004D7F4 File Offset: 0x0004B9F4
		[CompilerGenerated]
		internal virtual C1FlexViewerDialog <<EMPTY_NAME>>()
		{
			return this.O0o.O_O0.;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0004D7FC File Offset: 0x0004B9FC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexViewerDialog A_0)
		{
			this.O0o.O_O0. = A_0;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0004D805 File Offset: 0x0004BA05
		[CompilerGenerated]
		internal virtual C1Map <<EMPTY_NAME>>()
		{
			return this.O0o.O_O0.;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0004D80D File Offset: 0x0004BA0D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Map A_0)
		{
			this.O0o.O_O0. = A_0;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0004D816 File Offset: 0x0004BA16
		[CompilerGenerated]
		internal virtual WebView2 <<EMPTY_NAME>>()
		{
			return this.O0o.O_O0.;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0004D81E File Offset: 0x0004BA1E
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(WebView2 A_0)
		{
			this.O0o.O_O0. = A_0;
		}

		// Token: 0x04000359 RID: 857
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400035A RID: 858
		[CompilerGenerated]
		private C1PdfDocument <<EMPTY_NAME>>;

		// Token: 0x0400035B RID: 859
		[CompilerGenerated]
		private C1PdfDocumentSource <<EMPTY_NAME>>;

		// Token: 0x0400035C RID: 860
		[CompilerGenerated]
		private C1FlexViewerDialog <<EMPTY_NAME>>;

		// Token: 0x0400035D RID: 861
		[CompilerGenerated]
		private C1Map <<EMPTY_NAME>>;

		// Token: 0x0400035E RID: 862
		[CompilerGenerated]
		private WebView2 <<EMPTY_NAME>>;
	}
}
