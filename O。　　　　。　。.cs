using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Chart;
using C1.Win.C1Input;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002B4 RID: 692
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002 : System.Windows.Forms.Form
	{
		// Token: 0x060025C9 RID: 9673 RVA: 0x001165F0 File Offset: 0x001147F0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o.OO_. != null)
				{
					this.o.OO_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00116630 File Offset: 0x00114830
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002));
			this.o.OO_.(new C1Chart());
			this.o0_Oo.OO.(new C1Button());
			this.Oo.OOoO.(new C1Button());
			this.O_oO0o.O.(new C1Button());
			this.o.OO_.(new C1Button());
			((ISupportInitialize)this.oOoo.O0O_o.()).BeginInit();
			base.SuspendLayout();
			this.oOoo.O0O_o.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.oOoo.O0O_o.().Location = new Point(12, 12);
			this.oOoo.O0O_o.().Name = "C1Chart1";
			this.oOoo.O0O_o.().PropBag = componentResourceManager.GetString("C1Chart1.PropBag");
			this.oOoo.O0O_o.().Size = new Size(814, 428);
			this.oOoo.O0O_o.().TabIndex = 0;
			this.o0_Oo.OO.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.o0_Oo.OO.().Location = new Point(589, 459);
			this.o0_Oo.OO.().Name = "btnPrint";
			this.o0_Oo.OO.().Size = new Size(75, 23);
			this.o0_Oo.OO.().TabIndex = 1;
			this.o0_Oo.OO.().Text = "打印";
			this.o0_Oo.OO.().UseVisualStyleBackColor = true;
			this.Oo.OOoO.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.Oo.OOoO.().Location = new Point(670, 459);
			this.Oo.OOoO.().Name = "btnCopy";
			this.Oo.OOoO.().Size = new Size(75, 23);
			this.Oo.OOoO.().TabIndex = 2;
			this.Oo.OOoO.().Text = "复制";
			this.Oo.OOoO.().UseVisualStyleBackColor = true;
			this.oOoo.O0O_o.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.oOoo.O0O_o.().Location = new Point(751, 459);
			this.oOoo.O0O_o.().Name = "btnSave";
			this.oOoo.O0O_o.().Size = new Size(75, 23);
			this.oOoo.O0O_o.().TabIndex = 3;
			this.oOoo.O0O_o.().Text = "保存";
			this.oOoo.O0O_o.().UseVisualStyleBackColor = true;
			this.O_oO0o.O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.O_oO0o.O.().Location = new Point(13, 459);
			this.O_oO0o.O.().Name = "Button1";
			this.O_oO0o.O.().Size = new Size(97, 23);
			this.O_oO0o.O.().TabIndex = 4;
			this.O_oO0o.O.().Text = "改变配色方案";
			this.O_oO0o.O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(838, 494);
			base.Controls.Add(this.O_oO0o.O.());
			base.Controls.Add(this.oOoo.O0O_o.());
			base.Controls.Add(this.Oo.OOoO.());
			base.Controls.Add(this.o0_Oo.OO.());
			base.Controls.Add(this.oOoo.O0O_o.());
			base.MinimizeBox = false;
			base.Name = "O..O0oO.";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "图表";
			((ISupportInitialize)this.oOoo.O0O_o.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x0011698D File Offset: 0x00114B8D
		[CompilerGenerated]
		internal virtual C1Chart <<EMPTY_NAME>>()
		{
			return this.o.OO_.;
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00116998 File Offset: 0x00114B98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Chart A_0)
		{
			MouseEventHandler value = new MouseEventHandler(this.Oo._Oo.);
			C1Chart c1Chart = this.o.OO_.;
			if (c1Chart != null)
			{
				c1Chart.MouseUp -= value;
			}
			this.o.OO_. = A_0;
			c1Chart = this.o.OO_.;
			if (c1Chart != null)
			{
				c1Chart.MouseUp += value;
			}
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x001169DB File Offset: 0x00114BDB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.OO_.;
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x001169E4 File Offset: 0x00114BE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O000._O__.);
			C1Button c1Button = this.o.OO_.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.OO_. = A_0;
			c1Button = this.o.OO_.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x00116A27 File Offset: 0x00114C27
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0.0000_Oooo.;
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00116A30 File Offset: 0x00114C30
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.ooO.0O_oO0OOO.);
			C1Button c1Button = this.o0.0000_Oooo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0.0000_Oooo. = A_0;
			c1Button = this.o0.0000_Oooo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00116A73 File Offset: 0x00114C73
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.ooo._o.;
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00116A7C File Offset: 0x00114C7C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0_oO_00o0.o.);
			C1Button c1Button = this.ooo._o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.ooo._o. = A_0;
			c1Button = this.ooo._o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00116ABF File Offset: 0x00114CBF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OOO._00.;
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x00116AC8 File Offset: 0x00114CC8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo._Oo.);
			C1Button ooo._00. = this.OOO._00.;
			if (ooo._00. != null)
			{
				ooo._00..Click -= value;
			}
			this.OOO._00. = A_0;
			ooo._00. = this.OOO._00.;
			if (ooo._00. != null)
			{
				ooo._00..Click += value;
			}
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x00116B0B File Offset: 0x00114D0B
		public O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002()
		{
			base.FormClosed += this.oOoo.O0O_o.;
			this.oOoo.O0O_o.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00116B40 File Offset: 0x00114D40
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new Chart(this.oOoo.O0O_o.()).Print(false, true);
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x00116B54 File Offset: 0x00114D54
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new Chart(this.oOoo.O0O_o.()).CopyImage();
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00116B68 File Offset: 0x00114D68
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Chart chart = new Chart(this.oOoo.O0O_o.());
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "WMF|*.wmf|BMP|*.bmp|GIF|*.gif|JPEG|*.jpg|PNG|*.png|TIFF|*.tif|EMF|*.emf";
			saveFileDialog.FilterIndex = 0;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = saveFileDialog.FileName;
				ImageFormat imageFormat = ImageFormat.Bmp;
				string left = Path.GetExtension(fileName).TrimStart(new char[]
				{
					'.'
				});
				if (Operators.CompareString(left, "wmf", true) == 0)
				{
					imageFormat = ImageFormat.Wmf;
				}
				else if (Operators.CompareString(left, "bmp", true) == 0)
				{
					imageFormat = ImageFormat.Bmp;
				}
				else if (Operators.CompareString(left, "gif", true) == 0)
				{
					imageFormat = ImageFormat.Gif;
				}
				else if (Operators.CompareString(left, "jpg", true) == 0)
				{
					imageFormat = ImageFormat.Jpeg;
				}
				else if (Operators.CompareString(left, "png", true) == 0)
				{
					imageFormat = ImageFormat.Png;
				}
				else if (Operators.CompareString(left, "tif", true) == 0)
				{
					imageFormat = ImageFormat.Tiff;
				}
				else if (Operators.CompareString(left, "emf", true) == 0)
				{
					imageFormat = ImageFormat.Emf;
				}
				chart.SaveImage(fileName, imageFormat);
			}
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00116C74 File Offset: 0x00114E74
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			Chart chart = new Chart(this.oOoo.O0O_o.());
			int index;
			int num;
			ChartSeries chartSeries;
			ChartTypeEnum chartTypeEnum;
			if (chart.CoordToDataIndex(A_1.X, A_1.Y, ref index, ref num))
			{
				chartSeries = chart.SeriesList[index];
				chartTypeEnum = chart.ChartType;
			}
			else
			{
				if (!chart.CoordToDataIndex(A_1.X, A_1.Y, ref index, ref num))
				{
					return;
				}
				chartSeries = chart.SeriesList2[index];
				chartTypeEnum = chart.ChartType;
			}
			if (chartTypeEnum == ChartTypeEnum.Pie)
			{
				if (chartSeries.Offset == 20)
				{
					chartSeries.Offset = 0;
					return;
				}
				chartSeries.Offset = 20;
			}
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00116D08 File Offset: 0x00114F08
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string[] names = Enum.GetNames(typeof(ColorGeneration));
			string text = Enum.GetName(typeof(ColorGeneration), this.oOoo.O0O_o.().ColorGeneration);
			int num = names.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(names[i], text, true) == 0)
				{
					i++;
					if (i >= names.Length - 1)
					{
						i = 0;
					}
					text = names[i];
					this.oOoo.O0O_o.().ColorGeneration = (ColorGeneration)Conversions.ToInteger(Enum.Parse(typeof(ColorGeneration), text));
					return;
				}
			}
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00116D96 File Offset: 0x00114F96
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04000FAA RID: 4010
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000FAB RID: 4011
		[CompilerGenerated]
		private C1Chart <<EMPTY_NAME>>;

		// Token: 0x04000FAC RID: 4012
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000FAD RID: 4013
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000FAE RID: 4014
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000FAF RID: 4015
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
