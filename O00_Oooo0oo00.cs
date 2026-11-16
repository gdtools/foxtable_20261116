using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003B6 RID: 950
	[DesignerGenerated]
	internal class O00_Oooo0oo00 : UserControl
	{
		// Token: 0x06003DA7 RID: 15783 RVA: 0x001BF01D File Offset: 0x001BD21D
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.O_.oOO_oO_. != null)
			{
				this.O_.oOO_oO_..Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x001BF03C File Offset: 0x001BD23C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.Cursor = Cursors.Hand;
			base.Name = "oooo....";
			base.Size = new Size(9, 9);
			base.ResumeLayout(false);
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x001BF098 File Offset: 0x001BD298
		public O00_Oooo0oo00()
		{
			base.Click += this.o.O_O_O_O0.;
			base.ParentChanged += this.o_0_0.O_o__0o.;
			this.o_0_0.O_o__0o.();
			this.BackgroundImage = OO_00oOO.GetImage("Operator.ico");
			this.BackgroundImageLayout = ImageLayout.Center;
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x001BF0EC File Offset: 0x001BD2EC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			new O\u3002o((TreeView)((ControlHolder)base.Parent).ChildControl).ShowDialog();
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x001BF110 File Offset: 0x001BD310
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Location = new Point(base.Parent.Width - base.Width - 4, base.Parent.Height - base.Height - 4);
			this.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.BackColor = ((ControlHolder)base.Parent).ChildControl.BackColor;
			base.BringToFront();
		}

		// Token: 0x04001944 RID: 6468
		private IContainer <<EMPTY_NAME>>;
	}
}
