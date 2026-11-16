using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Foxtable.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000095 RID: 149
	[DesignerGenerated]
	internal class oOOoo_0_0o_ : UserControl
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x0002EE4C File Offset: 0x0002D04C
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.Oo0O0.o. != null)
				{
					this.Oo0O0.o..Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0002EE8C File Offset: 0x0002D08C
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Oo0O0.o. = new Container();
			this.o0_OOo___o.0O.(new Label());
			this.o._ooo.(new Label());
			this.o0_OOo___o.0O.(new TextBox());
			this.o0_OOo___o.0O.(new System.Windows.Forms.Timer(this.Oo0O0.o.));
			this.O_o_.O0o00o__0.(new Label());
			base.SuspendLayout();
			this.ooO00_0.0.().BackColor = Color.Transparent;
			this.ooO00_0.0.().Dock = DockStyle.Left;
			this.ooO00_0.0.().Image = a.Oo.ooO00OO.();
			this.ooO00_0.0.().Location = new Point(0, 0);
			this.ooO00_0.0.().Name = "_lblIcon";
			this.ooO00_0.0.().Size = new Size(24, 24);
			this.ooO00_0.0.().TabIndex = 1;
			this.OO0_OOo_.0o_.().BackColor = Color.Transparent;
			this.OO0_OOo_.0o_.().Dock = DockStyle.Right;
			this.OO0_OOo_.0o_.().Image = a.O00o_Ooo.0.();
			this.OO0_OOo_.0o_.().Location = new Point(106, 0);
			this.OO0_OOo_.0o_.().Name = "_lblClear";
			this.OO0_OOo_.0o_.().Size = new Size(22, 24);
			this.OO0_OOo_.0o_.().TabIndex = 3;
			this.ooO00_0.0.().BorderStyle = BorderStyle.None;
			this.ooO00_0.0.().Location = new Point(27, 0);
			this.ooO00_0.0.().Name = "_txtSearch";
			this.ooO00_0.0.().Size = new Size(86, 14);
			this.ooO00_0.0.().TabIndex = 0;
			this.ooO00_0.0.().Interval = 500;
			this.o.oOO_O.().AutoSize = true;
			this.o.oOO_O.().BackColor = Color.Transparent;
			this.o.oOO_O.().ForeColor = SystemColors.ControlDark;
			this.o.oOO_O.().Location = new Point(44, 5);
			this.o.oOO_O.().Name = "_lblWatermark";
			this.o.oOO_O.().Size = new Size(47, 12);
			this.o.oOO_O.().TabIndex = 2;
			this.o.oOO_O.().Text = "查找...";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.o.oOO_O.());
			base.Controls.Add(this.ooO00_0.0.());
			base.Controls.Add(this.OO0_OOo_.0o_.());
			base.Controls.Add(this.ooO00_0.0.());
			base.Name = "Search.Box";
			base.Size = new Size(128, 24);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0002F12C File Offset: 0x0002D32C
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo0O0.o.;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0002F134 File Offset: 0x0002D334
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			EventHandler value = new EventHandler(this.o.0o00oo_OOo.);
			Label oo0O0.o. = this.Oo0O0.o.;
			if (oo0O0.o. != null)
			{
				oo0O0.o..Click -= value;
			}
			this.Oo0O0.o. = A_0;
			oo0O0.o. = this.Oo0O0.o.;
			if (oo0O0.o. != null)
			{
				oo0O0.o..Click += value;
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0002F177 File Offset: 0x0002D377
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo_0oO.o_O0.;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0002F180 File Offset: 0x0002D380
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			EventHandler value = new EventHandler(this.O_0o_0_.oooOoO.);
			Label label = this.oo_0oO.o_O0.;
			if (label != null)
			{
				label.Click -= value;
			}
			this.oo_0oO.o_O0. = A_0;
			label = this.oo_0oO.o_O0.;
			if (label != null)
			{
				label.Click += value;
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0002F1C3 File Offset: 0x0002D3C3
		[CompilerGenerated]
		internal virtual TextBox <<EMPTY_NAME>>()
		{
			return this.Oo0O0.o.;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0002F1CC File Offset: 0x0002D3CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(TextBox A_0)
		{
			EventHandler value = new EventHandler(this.o__O0._OO00O.);
			EventHandler value2 = new EventHandler(this.OOOO_0.o_O_0O.);
			EventHandler value3 = new EventHandler(this.Oo0._0_o__0__.);
			TextBox oo0O0.o. = this.Oo0O0.o.;
			if (oo0O0.o. != null)
			{
				oo0O0.o..TextChanged -= value;
				oo0O0.o..Enter -= value2;
				oo0O0.o..Leave -= value3;
			}
			this.Oo0O0.o. = A_0;
			oo0O0.o. = this.Oo0O0.o.;
			if (oo0O0.o. != null)
			{
				oo0O0.o..TextChanged += value;
				oo0O0.o..Enter += value2;
				oo0O0.o..Leave += value3;
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0002F245 File Offset: 0x0002D445
		[CompilerGenerated]
		internal virtual System.Windows.Forms.Timer <<EMPTY_NAME>>()
		{
			return this.Oo0O0.o.;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0002F250 File Offset: 0x0002D450
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.Timer A_0)
		{
			EventHandler value = new EventHandler(this.OO0o._OOOO.);
			System.Windows.Forms.Timer oo0O0.o. = this.Oo0O0.o.;
			if (oo0O0.o. != null)
			{
				oo0O0.o..Tick -= value;
			}
			this.Oo0O0.o. = A_0;
			oo0O0.o. = this.Oo0O0.o.;
			if (oo0O0.o. != null)
			{
				oo0O0.o..Tick += value;
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0002F293 File Offset: 0x0002D493
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.ooo_o.0_OOO.;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0002F29C File Offset: 0x0002D49C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			EventHandler value = new EventHandler(this.o_o0.O_0O0OO0O.);
			Label label = this.ooo_o.0_OOO.;
			if (label != null)
			{
				label.Click -= value;
			}
			this.ooo_o.0_OOO. = A_0;
			label = this.ooo_o.0_OOO.;
			if (label != null)
			{
				label.Click += value;
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0002F2DF File Offset: 0x0002D4DF
		public oOOoo_0_0o_()
		{
			this.ooO00_0.0.();
			this.ooO00_0.0.().Image = OO_00oOO.GetImage("findn.ico");
			this.OO0_OOo_.0o_.().Image = OO_00oOO.GetImage("deleten.ico");
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0002F318 File Offset: 0x0002D518
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(EventHandler A_0)
		{
			EventHandler eventHandler = this.Oo0O0.o.;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.Oo0O0.o., value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0002F350 File Offset: 0x0002D550
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(EventHandler A_0)
		{
			EventHandler eventHandler = this.Oo0O0.o.;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.Oo0O0.o., value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0002F388 File Offset: 0x0002D588
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(EventHandler A_0)
		{
			EventHandler eventHandler = this.oo_0oO.o_O0.;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.oo_0oO.o_O0., value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0002F3C0 File Offset: 0x0002D5C0
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(EventHandler A_0)
		{
			EventHandler eventHandler = this.oo_0oO.o_O0.;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.oo_0oO.o_O0., value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0002F3F8 File Offset: 0x0002D5F8
		public virtual void <<EMPTY_NAME>>(EventArgs A_0)
		{
			EventHandler oo0O0.o. = this.Oo0O0.o.;
			if (oo0O0.o. != null)
			{
				oo0O0.o.(this, A_0);
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0002F418 File Offset: 0x0002D618
		public virtual void <<EMPTY_NAME>>(EventArgs A_0)
		{
			EventHandler eventHandler = this.oo_0oO.o_O0.;
			if (eventHandler != null)
			{
				eventHandler(this, A_0);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0002F437 File Offset: 0x0002D637
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x0002F444 File Offset: 0x0002D644
		public virtual string Text
		{
			get
			{
				return this.ooO00_0.0.().Text;
			}
			set
			{
				this.ooO00_0.0.().Text = value;
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0002F452 File Offset: 0x0002D652
		public int <<EMPTY_NAME>>()
		{
			return this.ooO00_0.0.().Interval;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0002F45F File Offset: 0x0002D65F
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.ooO00_0.0.().Interval = A_0;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0002F470 File Offset: 0x0002D670
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
			Rectangle clientRectangle = base.ClientRectangle;
			clientRectangle.Inflate(-1, -1);
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			oOOoo_0_0o_.ooO00_0.0.(e.Graphics, SystemPens.ControlDark, SystemBrushes.Window, clientRectangle);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0002F4B8 File Offset: 0x0002D6B8
		protected override void OnLayout(LayoutEventArgs e)
		{
			base.OnLayout(e);
			int height = base.ClientSize.Height;
			int width = base.ClientSize.Width - this.ooO00_0.0.().Width - this.OO0_OOo_.0o_.().Width;
			this.o.oOO_O.().Bounds = new Rectangle(this.ooO00_0.0.().Width, (int)Math.Round((double)(height - this.o.oOO_O.().Height) / 2.0 + 2.0), width, this.o.oOO_O.().Height);
			this.ooO00_0.0.().Bounds = new Rectangle(this.ooO00_0.0.().Width, (int)Math.Round((double)(height - this.ooO00_0.0.().Height) / 2.0 + 1.0), width, this.ooO00_0.0.().Height);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0002F5A0 File Offset: 0x0002D7A0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OO0_OOo_.0o_.().Visible = (this.ooO00_0.0.().Text.Length > 0);
			this.ooO00_0.0.().Stop();
			this.ooO00_0.0.().Start();
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0002F5D6 File Offset: 0x0002D7D6
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.ooO00_0.0.().Stop();
			this.O_o_.O0o00o__0.(EventArgs.Empty);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0002F5EE File Offset: 0x0002D7EE
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.ooO00_0.0.().Text = string.Empty;
			this.ooO00_0.0.().Stop();
			this.O_o_.O0o00o__0.(EventArgs.Empty);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0002F616 File Offset: 0x0002D816
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.ooO00_0.0.().Focus();
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0002F624 File Offset: 0x0002D824
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.oOO_O.().Visible = false;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0002F632 File Offset: 0x0002D832
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.oOO_O.().Visible = (this.ooO00_0.0.().Text.Length == 0);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0002F654 File Offset: 0x0002D854
		private static void <<EMPTY_NAME>>(Graphics A_0, Pen A_1, Brush A_2, Rectangle A_3)
		{
			Rectangle rectangle = A_3;
			rectangle.Width = Math.Min(A_3.Height, (int)Math.Round((double)A_3.Width / 3.0));
			Rectangle rect = rectangle;
			rect.X = A_3.Right - rectangle.Width;
			A_3.X += A_3.Height;
			A_3.Width -= 2 * A_3.Height;
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddLine(A_3.X, A_3.Y, A_3.Right, A_3.Y);
			graphicsPath.AddArc(rect, 270f, 180f);
			graphicsPath.AddLine(A_3.Right, A_3.Bottom, A_3.X, A_3.Bottom);
			graphicsPath.AddArc(rectangle, 90f, 180f);
			graphicsPath.CloseFigure();
			if (A_2 != null)
			{
				A_0.FillPath(A_2, graphicsPath);
			}
			if (A_1 != null)
			{
				A_0.DrawPath(A_1, graphicsPath);
			}
			graphicsPath.Dispose();
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0002F762 File Offset: 0x0002D962
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0_OOo___o.0O.(EventArgs.Empty);
		}

		// Token: 0x04000178 RID: 376
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000179 RID: 377
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400017A RID: 378
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400017B RID: 379
		[CompilerGenerated]
		private TextBox <<EMPTY_NAME>>;

		// Token: 0x0400017C RID: 380
		[CompilerGenerated]
		private System.Windows.Forms.Timer <<EMPTY_NAME>>;

		// Token: 0x0400017D RID: 381
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400017E RID: 382
		[CompilerGenerated]
		private EventHandler <<EMPTY_NAME>>;

		// Token: 0x0400017F RID: 383
		[CompilerGenerated]
		private EventHandler <<EMPTY_NAME>>;
	}
}
