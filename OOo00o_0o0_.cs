using System;
using System.Drawing;
using System.Windows.Forms;
using Neodynamic.WinControls.BarcodeProfessional;

namespace Foxtable
{
	// Token: 0x020003A2 RID: 930
	internal class OOo00o_0o0_ : BarcodeProfessional
	{
		// Token: 0x06003CF8 RID: 15608 RVA: 0x001BC60C File Offset: 0x001BA80C
		public OOo00o_0o0_()
		{
			base.BarcodeUnit = BarcodeUnit.Millimeter;
			base.BorderStyle = Border3DStyle.Adjust;
			base.BorderWidth = 0.0;
			base.Symbology = Symbology.Code39;
			base.Code = "123456";
			base.Width = 1;
			base.Height = 1;
			base.QuietZoneWidth = 2.0;
			base.QRCodeByteEncodingName = "gb2312";
			Margin barcodePadding = base.BarcodePadding;
			barcodePadding.Left = 0.5;
			barcodePadding.Right = 0.5;
			barcodePadding.Bottom = 0.5;
			barcodePadding.Top = 0.5;
			base.BarWidth = 0.2642;
			base.BarHeight = 5.08;
			base.BearerBarWidth = 1.27;
			base.AztecCodeModuleSize = 1.0592;
			base.DataMatrixModuleSize = 1.0592;
			base.EanUpcSupplementSeparation = 3.81;
			base.EanUpcSupplementTopMargin = 3.81;
			base.GuardBarHeight = 6.35;
			base.PharmacodeBarsSpacing = 1.0592;
			base.PharmacodeThickBarWidth = 1.5875;
			base.PharmacodeThinBarWidth = 0.5283;
			base.PlanetHeightShortBar = 5.0;
			base.PlanetHeightTallBar = 10.0;
			base.Postal4StateBarsSpacing = 0.795;
			base.Postal4StateTrackerBarHeight = 2.032;
			base.Postal4StateTrackerBarWidth = 0.5283;
			base.PostnetHeightShortBar = 5.0;
			base.PostnetHeightTallBar = 10.0;
			base.QRCodeModuleSize = 1.0592;
			base.TextForeColor = Color.Black;
			this.ForeColor = Color.Black;
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x001BC7F0 File Offset: 0x001BA9F0
		static OOo00o_0o0_()
		{
			BarcodeProfessional.LicenseOwner = "Zhanjiang Huixun Software Co., Ltd-Ultimate Edition-Developer License";
			BarcodeProfessional.LicenseKey = "8C232EXH778ME8FD9E5KSRXUXFRVE74VZB5QU2TLU8WBZGAX3W8Q";
		}
	}
}
