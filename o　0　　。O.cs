using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Foxtable.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000379 RID: 889
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal partial class o\u30000\u3000\u3000\u3002O : Form
	{
		// Token: 0x06003927 RID: 14631 RVA: 0x00198808 File Offset: 0x00196A08
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O.OoO_. != null)
				{
					this.O.OoO_..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x00198848 File Offset: 0x00196A48
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O.OoO_. = new Container();
			this.O.Oo0OO.(new ProgressBar());
			this.O.Oo0OO.(new Timer(this.O.OoO_.));
			base.SuspendLayout();
			this.O.Oo0OO.().Anchor = AnchorStyles.Bottom;
			this.O.Oo0OO.().Location = new Point(178, 200);
			this.O.Oo0OO.().Name = "ProgressBar1";
			this.O.Oo0OO.().Size = new Size(140, 10);
			this.O.Oo0OO.().Style = ProgressBarStyle.Marquee;
			this.O.Oo0OO.().TabIndex = 1;
			this.O.Oo0OO.().Visible = false;
			this.O.Oo0OO.().Enabled = true;
			this.O.Oo0OO.().Interval = 20;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(496, 256);
			base.Controls.Add(this.O.Oo0OO.());
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "o_O.....";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "frmStart";
			base.ResumeLayout(false);
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x00198980 File Offset: 0x00196B80
		[CompilerGenerated]
		internal virtual ProgressBar <<EMPTY_NAME>>()
		{
			return this.O.OoO_.;
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x00198988 File Offset: 0x00196B88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ProgressBar A_0)
		{
			this.O.OoO_. = A_0;
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x00198991 File Offset: 0x00196B91
		[CompilerGenerated]
		internal virtual Timer <<EMPTY_NAME>>()
		{
			return this.O.OoO_.;
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x0019899C File Offset: 0x00196B9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Timer A_0)
		{
			EventHandler value = new EventHandler(this.o.oOO_O0.);
			Timer o.OoO_. = this.O.OoO_.;
			if (o.OoO_. != null)
			{
				o.OoO_..Tick -= value;
			}
			this.O.OoO_. = A_0;
			o.OoO_. = this.O.OoO_.;
			if (o.OoO_. != null)
			{
				o.OoO_..Tick += value;
			}
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x001989DF File Offset: 0x00196BDF
		public o\u30000\u3000\u3000\u3002O()
		{
			base.Load += this.O0O._Oo.;
			base.Shown += this.O.Oo0OO.;
			this.O.Oo0OO.();
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x00198A14 File Offset: 0x00196C14
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!base.Disposing && !base.IsDisposed)
			{
				if (!this.O.Oo0OO.().Visible)
				{
					this.O.Oo0OO.().Visible = true;
				}
				switch (Main.OO_O.o.)
				{
				case SplashFormStateEnum.Show:
					if (!base.Visible)
					{
						base.ShowDialog();
						return;
					}
					break;
				case SplashFormStateEnum.DelayClose:
				case SplashFormStateEnum.Close:
					this.O.Oo0OO.().Enabled = false;
					base.Close();
					Main.OO_O.o. = SplashFormStateEnum.Normal;
					break;
				case SplashFormStateEnum.Hide:
					if (OO_00oOO.SystemReady)
					{
						Main.OO_O.o. = SplashFormStateEnum.Close;
						this.O.Oo0OO.().Interval = 1000;
						return;
					}
					if (base.Top != -1000)
					{
						base.Top = -1000;
						return;
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x00198AD0 File Offset: 0x00196CD0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Image image = null;
			string text = "";
			string parentPath = c.OOOOO.o.().FileSystem.GetParentPath(Application.ExecutablePath);
			if (c.Oo.__O0.().CommandLineArgs.Count > 0 && c.OOOOO.o.().FileSystem.FileExists(c.Oo.__O0.().CommandLineArgs[0]))
			{
				text = OO_00oOO.FileSys.GetParentPath(c.Oo.__O0.().CommandLineArgs[0]);
			}
			if (Operators.CompareString(text, "", true) > 0)
			{
				if (c.OOOOO.o.().FileSystem.FileExists(text + "\\Splash.jpg"))
				{
					image = OO_00oOO.GetImage(text + "\\Splash.jpg");
				}
				else if (c.OOOOO.o.().FileSystem.FileExists(text + "\\Splash.png"))
				{
					image = OO_00oOO.GetImage(text + "\\Splash.png");
				}
				else if (c.OOOOO.o.().FileSystem.FileExists(text + "\\Splash.gif"))
				{
					image = OO_00oOO.GetImage(text + "\\Splash.gif");
				}
				else if (c.OOOOO.o.().FileSystem.FileExists(text + "\\Splash.bmp"))
				{
					image = OO_00oOO.GetImage(text + "\\Splash.bmp");
				}
			}
			if (image == null)
			{
				if (c.OOOOO.o.().FileSystem.FileExists(parentPath + "\\Splash.jpg"))
				{
					image = OO_00oOO.GetImage(parentPath + "\\Splash.jpg");
				}
				else if (c.OOOOO.o.().FileSystem.FileExists(parentPath + "\\Splash.png"))
				{
					image = OO_00oOO.GetImage(parentPath + "\\Splash.png");
				}
				else if (c.OOOOO.o.().FileSystem.FileExists(parentPath + "\\Splash.gif"))
				{
					image = OO_00oOO.GetImage(parentPath + "\\Splash.gif");
				}
				else if (c.OOOOO.o.().FileSystem.FileExists(parentPath + "\\Splash.bmp"))
				{
					image = OO_00oOO.GetImage(parentPath + "\\Splash.bmp");
				}
			}
			if (image != null)
			{
				base.Width = image.Width;
				base.Height = image.Height;
				this.BackgroundImage = image;
			}
			base.CenterToScreen();
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x00198D02 File Offset: 0x00196F02
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!OO_00oOO.HardWareInfo.Ready)
			{
				OO_00oOO.HardWareInfo.initialize();
			}
		}

		// Token: 0x04001769 RID: 5993
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400176A RID: 5994
		[CompilerGenerated]
		private ProgressBar <<EMPTY_NAME>>;

		// Token: 0x0400176B RID: 5995
		[CompilerGenerated]
		private Timer <<EMPTY_NAME>>;
	}
}
