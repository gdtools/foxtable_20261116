using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.Map;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200016A RID: 362
	public class CustomMarkShape : CustomShape
	{
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x0007EA5E File Offset: 0x0007CC5E
		// (set) Token: 0x060010DB RID: 4315 RVA: 0x0007EA66 File Offset: 0x0007CC66
		internal GeoMap Map { get; set; }

		// Token: 0x060010DC RID: 4316 RVA: 0x0007EA6F File Offset: 0x0007CC6F
		internal CustomMarkShape(GeoMap A_0, object A_1)
		{
			this.Map = A_0;
			this.ShapeTag = RuntimeHelpers.GetObjectValue(A_1);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0007EA8C File Offset: 0x0007CC8C
		public override void Draw(Graphics g, RectangleF bounds, Style style)
		{
			Map a_ = new Map(this.Map);
			Foxtable.WinForm.Form form = null;
			System.Windows.Forms.Control parent = this.Map.Parent;
			while (parent != null)
			{
				if (parent is FormPanel)
				{
					form = OO_00oOO.Forms[parent.Name];
					break;
				}
			}
			OwerDrawMarkEventArgs owerDrawMarkEventArgs = new OwerDrawMarkEventArgs(a_, form, g, bounds, style, RuntimeHelpers.GetObjectValue(this.ShapeTag));
			string a_2 = "OwerDrawMark_" + Conversions.ToString(this.Map.Tag);
			O_O0OO.OoO_o.oO0o0O.(form.O_0.O00o_00_O., a_2, new object[]
			{
				owerDrawMarkEventArgs
			}, false, form.mmname + "," + this.Map.Name, false);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0007EB3C File Offset: 0x0007CD3C
		public override RectangleF GetDrawingBounds(Graphics g, RectangleF bounds, Style style)
		{
			Map a_ = new Map(this.Map);
			Foxtable.WinForm.Form form = null;
			System.Windows.Forms.Control parent = this.Map.Parent;
			while (parent != null)
			{
				if (parent is FormPanel)
				{
					form = OO_00oOO.Forms[parent.Name];
					break;
				}
			}
			OwerDrawMarkEventArgs owerDrawMarkEventArgs = new OwerDrawMarkEventArgs(a_, form, g, bounds, style, RuntimeHelpers.GetObjectValue(this.ShapeTag));
			string a_2 = "GetDrawingBounds_" + Conversions.ToString(this.Map.Tag);
			O_O0OO.OoO_o.oO0o0O.(form.O_0.O00o_00_O., a_2, new object[]
			{
				owerDrawMarkEventArgs
			}, false, form.mmname + "," + this.Map.Name, false);
			return owerDrawMarkEventArgs.Bounds;
		}

		// Token: 0x04000685 RID: 1669
		[CompilerGenerated]
		private GeoMap <<EMPTY_NAME>>;

		// Token: 0x04000686 RID: 1670
		internal object ShapeTag;
	}
}
