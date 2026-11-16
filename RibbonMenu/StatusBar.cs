using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	// Token: 0x02000037 RID: 55
	public class StatusBar
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00004F3A File Offset: 0x0000313A
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00004F41 File Offset: 0x00003141
		public static string DefaultMessage
		{
			get
			{
				return StatusBar.OO0.0OOo__.;
			}
			set
			{
				if (Operators.CompareString(StatusBar.Message1, StatusBar.OO0.0OOo__., true) == 0)
				{
					StatusBar.Message1 = value;
				}
				StatusBar.OO0.0OOo__. = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00004F61 File Offset: 0x00003161
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00004F74 File Offset: 0x00003174
		public static string Message1
		{
			get
			{
				return Main.OO_O.o..OO_O_0Oo.___o.().Text;
			}
			set
			{
				if (Operators.CompareString(value, "", true) > 0)
				{
					Main.OO_O.o..OO_O_0Oo.___o.().Text = value;
				}
				else
				{
					Main.OO_O.o..OO_O_0Oo.___o.().Text = StatusBar.DefaultMessage;
				}
				Main.OO_O.o..OO_O_0Oo.___o.().Enabled = Main.OO_O.o..OO_O_0Oo.___o.().Enabled;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00004FD4 File Offset: 0x000031D4
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00004FE5 File Offset: 0x000031E5
		public static string Message2
		{
			get
			{
				return Main.OO_O.o..o__0_._oOooO_o.().Text;
			}
			set
			{
				Main.OO_O.o..o__0_._oOooO_o.().Text = value;
				Main.OO_O.o..o__0_._oOooO_o.().Enabled = Main.OO_O.o..o__0_._oOooO_o.().Enabled;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00005015 File Offset: 0x00003215
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00005028 File Offset: 0x00003228
		public static string Message3
		{
			get
			{
				return Main.OO_O.o..oO0_oO.0o.().Text;
			}
			set
			{
				C1StatusBar c1StatusBar = Main.OO_O.o..O.OOO0_OOo.();
				if (Operators.CompareString(value, "", true) > 0)
				{
					Graphics graphics = c1StatusBar.CreateGraphics();
					double a = (double)graphics.MeasureString(value, c1StatusBar.Font).Width;
					c1StatusBar.RightPaneWidth = (int)Math.Round((Math.Ceiling(a) + 10.0) * (double)graphics.DpiX / 96.0);
				}
				else
				{
					c1StatusBar.RightPaneWidth = Math.Min(c1StatusBar.RightPaneWidth, 350);
				}
				Main.OO_O.o..oO0_oO.0o.().Text = value;
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000050C5 File Offset: 0x000032C5
		public static void Refresh()
		{
			Application.DoEvents();
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000050CC File Offset: 0x000032CC
		public static void Reset()
		{
			StatusBar.Message1 = "";
			StatusBar.Message2 = "";
			StatusBar.Message3 = "";
			StatusBar.ProgressBar.Visible = false;
			StatusBar.ProgressBar.Value = 0;
			StatusBar.ProgressBar.Minimum = 0;
			StatusBar.ProgressBar.Maximum = 100;
		}

		// Token: 0x0400005A RID: 90
		private static string <<EMPTY_NAME>> = "就绪";

		// Token: 0x02000038 RID: 56
		public class ProgressBar
		{
			// Token: 0x170000CD RID: 205
			// (get) Token: 0x060001DB RID: 475 RVA: 0x0000510D File Offset: 0x0000330D
			// (set) Token: 0x060001DC RID: 476 RVA: 0x0000511E File Offset: 0x0000331E
			public static bool Visible
			{
				get
				{
					return Main.OO_O.o..OO_O_0Oo.___o.().Visible;
				}
				set
				{
					Main.OO_O.o..OO_O_0Oo.___o.().Visible = value;
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x060001DD RID: 477 RVA: 0x00005130 File Offset: 0x00003330
			// (set) Token: 0x060001DE RID: 478 RVA: 0x00005141 File Offset: 0x00003341
			public static int Value
			{
				get
				{
					return Main.OO_O.o..OO_O_0Oo.___o.().Value;
				}
				set
				{
					Main.OO_O.o..OO_O_0Oo.___o.().Value = Math.Min(Math.Max(value, Main.OO_O.o..OO_O_0Oo.___o.().Minimum), Main.OO_O.o..OO_O_0Oo.___o.().Maximum);
				}
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x060001DF RID: 479 RVA: 0x0000517B File Offset: 0x0000337B
			// (set) Token: 0x060001E0 RID: 480 RVA: 0x0000518C File Offset: 0x0000338C
			public static int Minimum
			{
				get
				{
					return Main.OO_O.o..OO_O_0Oo.___o.().Minimum;
				}
				set
				{
					Main.OO_O.o..OO_O_0Oo.___o.().Minimum = value;
				}
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000519E File Offset: 0x0000339E
			// (set) Token: 0x060001E2 RID: 482 RVA: 0x000051AF File Offset: 0x000033AF
			public static int Maximum
			{
				get
				{
					return Main.OO_O.o..OO_O_0Oo.___o.().Maximum;
				}
				set
				{
					Main.OO_O.o..OO_O_0Oo.___o.().Maximum = value;
				}
			}
		}
	}
}
