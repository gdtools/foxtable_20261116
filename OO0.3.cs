using System;
using System.Drawing;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020003AF RID: 943
	internal class OO0 : PictureBox
	{
		// Token: 0x06003D4D RID: 15693 RVA: 0x001BD4E0 File Offset: 0x001BB6E0
		internal OO0()
		{
			base.Size = new Size(9, 9);
			base.Image = OO_00oOO.GetImage("Drag.ico");
			base.SizeMode = PictureBoxSizeMode.Normal;
			base.BorderStyle = BorderStyle.None;
			base.TabStop = false;
			base.Visible = false;
			this.Cursor = Cursors.SizeAll;
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x001BD53C File Offset: 0x001BB73C
		protected virtual void <<EMPTY_NAME>>(EventArgs A_0)
		{
			base.Location = new Point(0, 0);
			this.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
			((ControlHolder)base.Parent).SelectedChanged += this.O0Oo0_0_.o.;
			((ControlHolder)base.Parent).LockedChanged += this.oOOo__O0O0.0O.;
			ControlHolder @object = (ControlHolder)base.Parent;
			base.MouseDown += @object.o0_.0O_O0O.;
			base.MouseMove += @object.oOO.O.;
			base.MouseUp += @object.O000_oo.o_.;
			base.BringToFront();
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x001BD5E0 File Offset: 0x001BB7E0
		public void <<EMPTY_NAME>>(ControlHolder A_0)
		{
			ControlHolder controlHolder = (ControlHolder)base.Parent;
			base.Visible = (controlHolder.Selected & !controlHolder.Locked & controlHolder.Dock == DockStyle.None);
			base.BringToFront();
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x001BD624 File Offset: 0x001BB824
		public void <<EMPTY_NAME>>(ControlHolder A_0)
		{
			ControlHolder controlHolder = (ControlHolder)base.Parent;
			base.Visible = (controlHolder.Selected & !controlHolder.Locked & controlHolder.Dock == DockStyle.None);
		}

		// Token: 0x04001925 RID: 6437
		private Point <<EMPTY_NAME>>;
	}
}
