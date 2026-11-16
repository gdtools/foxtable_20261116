using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using C1.Win.Map;

namespace Foxtable
{
	// Token: 0x02000165 RID: 357
	[ComVisible(true)]
	public class MarkImageShape : CustomShape
	{
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x0007E56E File Offset: 0x0007C76E
		// (set) Token: 0x060010C7 RID: 4295 RVA: 0x0007E576 File Offset: 0x0007C776
		public Image Image { get; set; }

		// Token: 0x060010C8 RID: 4296 RVA: 0x0007E57F File Offset: 0x0007C77F
		public MarkImageShape(Image A_0)
		{
			this.Image = A_0;
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0007E590 File Offset: 0x0007C790
		public override void Draw(Graphics g, RectangleF bounds, Style style)
		{
			g.DrawImage(this.Image, bounds);
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

		// Token: 0x0400067B RID: 1659
		[CompilerGenerated]
		private Image <<EMPTY_NAME>>;
	}
}
