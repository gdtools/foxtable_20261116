using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x0200025B RID: 603
	[ComVisible(true)]
	public class Camera
	{
		// Token: 0x06001CA3 RID: 7331 RVA: 0x000C58B4 File Offset: 0x000C3AB4
		public void Capture()
		{
			frmCamera frmCamera = new frmCamera();
			SendKeys.Send("{ENTER}");
			if (frmCamera.ShowDialog() == DialogResult.OK)
			{
				this.o.o___O0O_O. = frmCamera.picCapture.Image;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x000C58EB File Offset: 0x000C3AEB
		public Image Image
		{
			get
			{
				return this.o.o___O0O_O.;
			}
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x000C58F3 File Offset: 0x000C3AF3
		public void Save(string fl)
		{
			if (this.Image != null)
			{
				if (OO_00oOO.FileSys.FileExists(fl))
				{
					OO_00oOO.FileSys.DeleteFile(fl);
				}
				this.Image.Save(fl, O_O0OO.OoO_00._.(fl));
			}
		}

		// Token: 0x04000C27 RID: 3111
		private Image <<EMPTY_NAME>>;
	}
}
