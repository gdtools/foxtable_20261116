using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.FlexMap;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000169 RID: 361
	public class CustomTileSource : ITileSource
	{
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x0007E970 File Offset: 0x0007CB70
		// (set) Token: 0x060010D5 RID: 4309 RVA: 0x0007E978 File Offset: 0x0007CB78
		internal GeoMap Map { get; set; }

		// Token: 0x060010D6 RID: 4310 RVA: 0x0007E981 File Offset: 0x0007CB81
		internal CustomTileSource(GeoMap A_0)
		{
			this.Map = A_0;
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0007E990 File Offset: 0x0007CB90
		public int TileWidth
		{
			get
			{
				return 256;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x0007E997 File Offset: 0x0007CB97
		public int TileHeight
		{
			get
			{
				return 256;
			}
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0007E9A0 File Offset: 0x0007CBA0
		public void GetTile(int level, int x, int y, ref string uri, ref object image)
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
			GetMapTileEventArgs getMapTileEventArgs = new GetMapTileEventArgs(a_, form, x, y, level, ref uri, ref image);
			string a_2 = "GetMapTile_" + Conversions.ToString(this.Map.Tag);
			O_O0OO.OoO_o.oO0o0O.(form.O_0.O00o_00_O., a_2, new object[]
			{
				getMapTileEventArgs
			}, false, form.mmname + "," + this.Map.Name, false);
			uri = getMapTileEventArgs.URI;
			image = RuntimeHelpers.GetObjectValue(getMapTileEventArgs.Image);
		}

		// Token: 0x04000684 RID: 1668
		[CompilerGenerated]
		private GeoMap <<EMPTY_NAME>>;
	}
}
