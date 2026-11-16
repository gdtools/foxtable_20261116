using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000078 RID: 120
	internal partial class oOo_O_0O : Form
	{
		// Token: 0x0600046E RID: 1134 RVA: 0x0001EC57 File Offset: 0x0001CE57
		public oOo_O_0O()
		{
			base.Load += this.O0o.0O.;
			base.FormClosing += this.O0o.0O.;
			base.ShowInTaskbar = false;
			base.TopMost = true;
		}

		// Token: 0x0600046F RID: 1135
		[DllImport("user32")]
		private static extern bool AnimateWindow(IntPtr A_0, int A_1, int A_2);

		// Token: 0x06000470 RID: 1136 RVA: 0x0001EC94 File Offset: 0x0001CE94
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int x = Screen.PrimaryScreen.WorkingArea.Right - base.Width;
			int y = Screen.PrimaryScreen.WorkingArea.Bottom - base.Height;
			base.Location = new Point(x, y);
			oOo_O_0O.AnimateWindow(base.Handle, 1000, 393224);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0001ECF8 File Offset: 0x0001CEF8
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
		}

		// Token: 0x04000128 RID: 296
		private const int <<EMPTY_NAME>> = 1;

		// Token: 0x04000129 RID: 297
		private const int <<EMPTY_NAME>> = 2;

		// Token: 0x0400012A RID: 298
		private const int <<EMPTY_NAME>> = 4;

		// Token: 0x0400012B RID: 299
		private const int <<EMPTY_NAME>> = 8;

		// Token: 0x0400012C RID: 300
		private const int <<EMPTY_NAME>> = 16;

		// Token: 0x0400012D RID: 301
		private const int <<EMPTY_NAME>> = 65536;

		// Token: 0x0400012E RID: 302
		private const int <<EMPTY_NAME>> = 131072;

		// Token: 0x0400012F RID: 303
		private const int <<EMPTY_NAME>> = 262144;

		// Token: 0x04000130 RID: 304
		private const int <<EMPTY_NAME>> = 524288;
	}
}
