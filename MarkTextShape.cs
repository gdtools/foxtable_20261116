using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using C1.Win.Map;

namespace Foxtable
{
	// Token: 0x02000166 RID: 358
	[ComVisible(true)]
	public class MarkTextShape : CustomShape
	{
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x0007E64C File Offset: 0x0007C84C
		// (set) Token: 0x060010CB RID: 4299 RVA: 0x0007E654 File Offset: 0x0007C854
		public string Text { get; set; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x0007E65D File Offset: 0x0007C85D
		// (set) Token: 0x060010CD RID: 4301 RVA: 0x0007E665 File Offset: 0x0007C865
		public int Margin { get; set; }

		// Token: 0x060010CE RID: 4302 RVA: 0x0007E66E File Offset: 0x0007C86E
		internal MarkTextShape(string A_0)
		{
			this.Margin = 1;
			this.Text = A_0;
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0007E684 File Offset: 0x0007C884
		internal MarkTextShape(string A_0, int A_1)
		{
			this.Margin = 1;
			this.Text = A_0;
			this.Margin = A_1;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0007E6A4 File Offset: 0x0007C8A4
		public override RectangleF GetDrawingBounds(Graphics g, RectangleF bounds, Style style)
		{
			SizeF sizeF = g.MeasureString(this.Text, style.Font);
			bounds.Height = sizeF.Height + (float)(this.Margin * 2);
			bounds.Width = sizeF.Width + (float)(this.Margin * 2);
			float? width = style.Border.Width;
			if (((width != null) ? new bool?(width.GetValueOrDefault() > 0f) : null).GetValueOrDefault() && style.Border.Style != null)
			{
				bounds.Width += style.Border.Width.Value * 2f;
				bounds.Height += style.Border.Width.Value * 2f;
			}
			bounds.X = bounds.X - bounds.Width / 2f + 5f;
			bounds.Y = bounds.Y - bounds.Height / 2f + 5f;
			return bounds;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0007E7DC File Offset: 0x0007C9DC
		public override void Draw(Graphics g, RectangleF bounds, Style style)
		{
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			if (style.BackColor.ToArgb() != 0)
			{
				SolidBrush brush = new SolidBrush(style.BackColor);
				g.FillRectangle(brush, bounds);
			}
			SolidBrush brush2 = new SolidBrush(style.ForeColor);
			g.DrawString(this.Text, style.Font, brush2, bounds, stringFormat);
			float? width = style.Border.Width;
			if (((width != null) ? new bool?(width.GetValueOrDefault() > 0f) : null).GetValueOrDefault() && style.Border.Style != null)
			{
				g.DrawRectangle(new Pen(style.Border.Color)
				{
					Width = style.Border.Width.Value,
					DashStyle = (System.Drawing.Drawing2D.DashStyle)style.Border.Style.Value
				}, Rectangle.Round(bounds));
			}
		}

		// Token: 0x0400067C RID: 1660
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x0400067D RID: 1661
		[CompilerGenerated]
		private int <<EMPTY_NAME>>;
	}
}
