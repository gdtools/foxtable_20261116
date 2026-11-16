using System;
using System.Drawing;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000096 RID: 150
	public class oo_ : Panel
	{
		// Token: 0x060005E5 RID: 1509 RVA: 0x0002F76F File Offset: 0x0002D96F
		public oo_()
		{
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.Opaque, false);
			this.BackColor = Color.Transparent;
			this.Dock = DockStyle.Fill;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0002F79D File Offset: 0x0002D99D
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			if (base.FindForm() == null)
			{
				base.OnPaintBackground(e);
			}
		}
	}
}
