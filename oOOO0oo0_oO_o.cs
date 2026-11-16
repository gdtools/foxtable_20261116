using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003B5 RID: 949
	[DesignerGenerated]
	internal class oOOO0oo0_oO_o : UserControl
	{
		// Token: 0x06003DA2 RID: 15778 RVA: 0x001BEE00 File Offset: 0x001BD000
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.o.Ooo_0__0Oo. != null)
				{
					this.o.Ooo_0__0Oo..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x001BEE40 File Offset: 0x001BD040
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Name = "O.o..o..";
			base.Size = new Size(9, 9);
			base.ResumeLayout(false);
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x001BEE9C File Offset: 0x001BD09C
		public oOOO0oo0_oO_o()
		{
			base.Click += this.O00___._OO_.;
			base.ParentChanged += this.o.Ooo_0__0Oo.;
			this.o.Ooo_0__0Oo.();
			this.BackgroundImage = OO_00oOO.GetImage("Operator.ico");
			this.BackgroundImageLayout = ImageLayout.Center;
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x001BEEF0 File Offset: 0x001BD0F0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			oOO0oo_o0.o0.Oo__.(base.FindForm().Controls);
			((ControlHolder)base.Parent).Selected = true;
			object obj = RuntimeHelpers.GetObjectValue(((o\u3000\u3002)base.FindForm().MdiParent).O0.0O00_O.().SelectedObject);
			if (obj is o_0oooo_OO)
			{
				obj = (o_0oooo_OO)obj;
				o_0oooo_OO o_0oooo_OO = (o_0oooo_OO)obj;
				if (o_0oooo_OO.Oo._o.() is TopicBarProperty)
				{
					O\u3002\u3002\u3000 o_u3002_u3002_u = new O\u3002\u3002\u3000();
					o_u3002_u3002_u.OoO_0_0._00_0.(((TopicBarProperty)o_0oooo_OO.Oo._o.()).Setting);
					if (o_u3002_u3002_u.ShowDialog() == DialogResult.OK)
					{
						((TopicBarProperty)o_0oooo_OO.Oo._o.()).Setting = o_u3002_u3002_u.OO_o.O_0.();
						((o\u3000\u3002)base.FindForm().MdiParent).OO_._oOo. = true;
					}
				}
			}
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x001BEFB4 File Offset: 0x001BD1B4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Location = new Point(base.Parent.Width - base.Width - 4, base.Parent.Height - base.Height - 4);
			this.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.BackColor = ((ControlHolder)base.Parent).ChildControl.BackColor;
			base.BringToFront();
		}

		// Token: 0x04001943 RID: 6467
		private IContainer <<EMPTY_NAME>>;
	}
}
