using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020003B2 RID: 946
	internal class Oo0oo_O_O00__ : Label
	{
		// Token: 0x06003D8B RID: 15755 RVA: 0x001BE584 File Offset: 0x001BC784
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(Oo0oo_O_O00__.OOo0 A_0)
		{
			Oo0oo_O_O00__.OOo0 ooo = this.OOOOo._.;
			Oo0oo_O_O00__.OOo0 ooo2;
			do
			{
				ooo2 = ooo;
				Oo0oo_O_O00__.OOo0 value = (Oo0oo_O_O00__.OOo0)Delegate.Combine(ooo2, A_0);
				ooo = Interlocked.CompareExchange<Oo0oo_O_O00__.OOo0>(ref this.OOOOo._., value, ooo2);
			}
			while (ooo != ooo2);
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x001BE5BC File Offset: 0x001BC7BC
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(Oo0oo_O_O00__.OOo0 A_0)
		{
			Oo0oo_O_O00__.OOo0 ooo = this.OOOOo._.;
			Oo0oo_O_O00__.OOo0 ooo2;
			do
			{
				ooo2 = ooo;
				Oo0oo_O_O00__.OOo0 value = (Oo0oo_O_O00__.OOo0)Delegate.Remove(ooo2, A_0);
				ooo = Interlocked.CompareExchange<Oo0oo_O_O00__.OOo0>(ref this.OOOOo._., value, ooo2);
			}
			while (ooo != ooo2);
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x001BE5F4 File Offset: 0x001BC7F4
		internal Oo0oo_O_O00__(O0OO000oo0O A_0)
		{
			this.Text = "";
			this.BackColor = SystemColors.ControlLightLight;
			this.BorderStyle = BorderStyle.FixedSingle;
			base.FlatStyle = FlatStyle.Flat;
			base.Size = new Size(6, 6);
			this.Oo000Oo.Oo__O.(A_0);
			base.TabStop = false;
			base.Visible = false;
			this.OO.O0_O.(new Oo0oo_O_O00__.OOo0(oOO0oo_o0.O00OO_O_oO_.o.));
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x001BE65F File Offset: 0x001BC85F
		private O0OO000oo0O <<EMPTY_NAME>>()
		{
			return this.Oo000Oo.Oo__O.;
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x001BE667 File Offset: 0x001BC867
		private void <<EMPTY_NAME>>(O0OO000oo0O A_0)
		{
			this.Oo000Oo.Oo__O. = A_0;
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x001BE670 File Offset: 0x001BC870
		protected virtual void <<EMPTY_NAME>>(EventArgs A_0)
		{
			switch (this.Oo000Oo.Oo__O.())
			{
			case O0OO000oo0O.OOOOo._.:
				this.Cursor = Cursors.SizeWE;
				base.Location = new Point(0, Convert.ToInt32((double)(base.Parent.Height - base.Height) / 2.0));
				this.Anchor = AnchorStyles.Left;
				break;
			case O0OO000oo0O.ooo_O0o._.:
				this.Cursor = Cursors.SizeNS;
				base.Location = new Point(Convert.ToInt32((double)(base.Parent.Width - base.Width) / 2.0), 0);
				this.Anchor = AnchorStyles.Top;
				break;
			case O0OO000oo0O.o.00o000O00o__.:
				this.Cursor = Cursors.SizeWE;
				base.Location = new Point(base.Parent.Width - base.Width, Convert.ToInt32((double)(base.Parent.Height - base.Height) / 2.0));
				this.Anchor = AnchorStyles.Right;
				break;
			case O0OO000oo0O.o_.0_0O.:
				this.Cursor = Cursors.SizeNS;
				base.Location = new Point(Convert.ToInt32((double)(base.Parent.Width - base.Width) / 2.0), base.Parent.Height - base.Height);
				this.Anchor = AnchorStyles.Bottom;
				break;
			case O0OO000oo0O.o_oO._0O.:
				this.Cursor = Cursors.SizeNWSE;
				base.Location = new Point(0, 0);
				this.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
				break;
			case O0OO000oo0O.o0_OoOo.OO.:
				this.Cursor = Cursors.SizeNESW;
				base.Location = new Point(base.Parent.Width - base.Width, 0);
				this.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
				break;
			case O0OO000oo0O.Oo0ooo.OO.:
				this.Cursor = Cursors.SizeNESW;
				base.Location = new Point(0, base.Parent.Height - base.Height);
				this.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
				break;
			case O0OO000oo0O.OO_._O.:
				this.Cursor = Cursors.SizeNWSE;
				base.Location = new Point(base.Parent.Width - base.Width, base.Parent.Height - base.Height);
				this.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
				break;
			}
			((ControlHolder)base.Parent).ActivatedChanged += this.o0_Oo__O.OO0.;
			((ControlHolder)base.Parent).SelectedChanged += this.o_Oo_.0o_oO_oO.;
			((ControlHolder)base.Parent).LockedChanged += this.Oo000Oo.Oo__O.;
			((ControlHolder)base.Parent).DockStyleChanged += this.OoO0.O.;
			base.OnParentChanged(A_0);
			base.BringToFront();
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x001BE930 File Offset: 0x001BCB30
		protected override void OnMouseDown(MouseEventArgs e)
		{
			this.OOOOo._. = base.Parent.Size;
			if (e.Button == MouseButtons.Left & this.o0O_.00.())
			{
				this.OOOOo._. = true;
				this.OOOOo._. = new Point(e.X, e.Y);
				((ControlHolder)base.Parent).Activated = true;
				this.OOOOo._. = ((o\u3002\u3002\u3000\u3000\u3002)base.FindForm()).OO__oo0.0O___.("Size");
				return;
			}
			this.OOOOo._. = false;
			this.OOOOo._. = null;
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x001BE9C0 File Offset: 0x001BCBC0
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (this.OOOOo._. & e.Button == MouseButtons.Left)
			{
				this.oOOo_o._0o0. = new Point(e.X, e.Y);
				Oo0oo_O_O00__.OOo0 ooooo._. = this.OOOOo._.;
				if (ooooo._. != null)
				{
					ooooo._.(base.FindForm().Controls, this.Oo000Oo.Oo__O.(), this.oOOo_o._0o0..X - this.OOOOo._..X, this.oOOo_o._0o0..Y - this.OOOOo._..Y);
				}
				this.oOOo_o._0o0. = this.OOOOo._.;
				((o\u3000\u3002)base.FindForm().MdiParent).O0.0O00_O.().Refresh();
				if (((ControlHolder)base.Parent).ParentHolder != null && ((ControlHolder)base.Parent).ParentHolder.ControlType == ControlTypeEnum.PictureBox)
				{
					((CustomPictureBox)((ControlHolder)base.Parent).ParentHolder.ChildControl).PictureBox1.Refresh();
					return;
				}
			}
			else
			{
				this.OOOOo._. = false;
			}
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x001BEACC File Offset: 0x001BCCCC
		protected override void OnMouseUp(MouseEventArgs e)
		{
			this.OOOOo._. = false;
			if (this.OOOOo._. != base.Parent.Size && this.OOOOo._. != null)
			{
				((o\u3002\u3002\u3000\u3000\u3002)base.FindForm()).o_0O.OO0_0_..Add(this.OOOOo._.);
				this.OOOOo._. = null;
			}
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x001BEB22 File Offset: 0x001BCD22
		public void <<EMPTY_NAME>>(ControlHolder A_0)
		{
			if (((ControlHolder)base.Parent).Activated)
			{
				this.BackColor = SystemColors.Highlight;
				return;
			}
			this.BackColor = SystemColors.ControlLightLight;
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x001BEB50 File Offset: 0x001BCD50
		public void <<EMPTY_NAME>>(ControlHolder A_0)
		{
			ControlHolder controlHolder = (ControlHolder)base.Parent;
			base.Visible = (controlHolder.Selected & !controlHolder.Locked & this.o0_Oo__O.OO0.());
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x001BEB88 File Offset: 0x001BCD88
		public void <<EMPTY_NAME>>(ControlHolder A_0)
		{
			ControlHolder controlHolder = (ControlHolder)base.Parent;
			base.Visible = (controlHolder.Selected & !controlHolder.Locked & this.o0_Oo__O.OO0.());
		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x001BEBC0 File Offset: 0x001BCDC0
		public void <<EMPTY_NAME>>(ControlHolder A_0)
		{
			ControlHolder controlHolder = (ControlHolder)base.Parent;
			base.Visible = (controlHolder.Selected & !controlHolder.Locked & this.o0_Oo__O.OO0.());
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x001BEBF8 File Offset: 0x001BCDF8
		public bool <<EMPTY_NAME>>()
		{
			DockStyle dock = ((ControlHolder)base.Parent).Dock;
			bool result;
			if (dock == DockStyle.None)
			{
				result = true;
			}
			else if (dock == DockStyle.Fill)
			{
				result = false;
			}
			else if (dock == DockStyle.Left)
			{
				result = (this.Oo000Oo.Oo__O.() == O0OO000oo0O.o.00o000O00o__.);
			}
			else if (dock == DockStyle.Right)
			{
				result = (this.Oo000Oo.Oo__O.() == O0OO000oo0O.OOOOo._.);
			}
			else if (dock == DockStyle.Top)
			{
				result = (this.Oo000Oo.Oo__O.() == O0OO000oo0O.o_.0_0O.);
			}
			else if (dock == DockStyle.Bottom)
			{
				result = (this.Oo000Oo.Oo__O.() == O0OO000oo0O.ooo_O0o._.);
			}
			return result;
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x001BEC64 File Offset: 0x001BCE64
		private bool <<EMPTY_NAME>>()
		{
			base.BringToFront();
			ControlHolder controlHolder = (ControlHolder)base.Parent;
			bool flag = controlHolder.IsFixedWidth;
			bool flag2 = controlHolder.IsFixedHeight;
			return !(flag & this.Oo000Oo.Oo__O.() != O0OO000oo0O.ooo_O0o._. & this.Oo000Oo.Oo__O.() != O0OO000oo0O.o_.0_0O.) && !(flag2 & this.Oo000Oo.Oo__O.() > O0OO000oo0O.OOOOo._. & this.Oo000Oo.Oo__O.() != O0OO000oo0O.o.00o000O00o__.);
		}

		// Token: 0x0400193C RID: 6460
		private Point <<EMPTY_NAME>>;

		// Token: 0x0400193D RID: 6461
		private Point <<EMPTY_NAME>>;

		// Token: 0x0400193E RID: 6462
		private O0OO000oo0O <<EMPTY_NAME>>;

		// Token: 0x0400193F RID: 6463
		[CompilerGenerated]
		private Oo0oo_O_O00__.OOo0 <<EMPTY_NAME>>;

		// Token: 0x04001940 RID: 6464
		private O___O_ <<EMPTY_NAME>>;

		// Token: 0x04001941 RID: 6465
		private Size <<EMPTY_NAME>>;

		// Token: 0x04001942 RID: 6466
		private bool <<EMPTY_NAME>>;

		// Token: 0x020003B3 RID: 947
		// (Invoke) Token: 0x06003D9D RID: 15773
		public delegate void OOo0(Control.ControlCollection A_0, O0OO000oo0O A_1, int A_2, int A_3);
	}
}
