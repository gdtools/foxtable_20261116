using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.Interop;
using C1.Win.Map;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200016D RID: 365
	[ComVisible(true)]
	public class VirtualTileSource : IMapVirtualSource
	{
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0007ED13 File Offset: 0x0007CF13
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x0007ED1B File Offset: 0x0007CF1B
		internal GeoMap Map { get; set; }

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0007ED24 File Offset: 0x0007CF24
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x0007ED2C File Offset: 0x0007CF2C
		internal VirtualLayer layer { get; set; }

		// Token: 0x060010ED RID: 4333 RVA: 0x0007ED35 File Offset: 0x0007CF35
		internal VirtualTileSource(GeoMap A_0, VirtualLayer A_1)
		{
			this.Map = A_0;
			this.layer = A_1;
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0007ED4C File Offset: 0x0007CF4C
		public IEnumerable<VectorItem> Request(double minZoom, double maxZoom, Point lowerLeft, Point upperRight)
		{
			IEnumerable<VectorItem> result;
			if (this.Map.Viewport.Zoom < this.layer.MinZoom)
			{
				result = null;
			}
			else if (this.Map.Viewport.Zoom > this.layer.MaxZoom)
			{
				result = null;
			}
			else
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
				GetVirtualItemsEventArgs getVirtualItemsEventArgs = new GetVirtualItemsEventArgs(a_, this.layer, form, lowerLeft, upperRight);
				string a_2 = "GetVirtualItems_" + Conversions.ToString(this.Map.Tag);
				O_O0OO.OoO_o.oO0o0O.(form.O_0.O00o_00_O., a_2, new object[]
				{
					getVirtualItemsEventArgs
				}, false, form.mmname + "," + this.Map.Name, false);
				result = getVirtualItemsEventArgs.Items;
			}
			return result;
		}

		// Token: 0x0400068C RID: 1676
		[CompilerGenerated]
		private GeoMap <<EMPTY_NAME>>;

		// Token: 0x0400068D RID: 1677
		[CompilerGenerated]
		private VirtualLayer <<EMPTY_NAME>>;
	}
}
