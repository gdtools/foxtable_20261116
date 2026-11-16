using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200008D RID: 141
	internal class Oo0__Oo : C1DockingTabPage
	{
		// Token: 0x0600056A RID: 1386 RVA: 0x0002D9A5 File Offset: 0x0002BBA5
		[CompilerGenerated]
		internal virtual Table <<EMPTY_NAME>>()
		{
			return this.OO0_0oOo.o.;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0002D9B0 File Offset: 0x0002BBB0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Table A_0)
		{
			Table.oO00_O_O a_ = new Table.oO00_O_O(this.O_000__.o.);
			Table oo0_0oOo.o. = this.OO0_0oOo.o.;
			if (oo0_0oOo.o. != null)
			{
				oo0_0oOo.o..NameChanged -= a_;
			}
			this.OO0_0oOo.o. = A_0;
			oo0_0oOo.o. = this.OO0_0oOo.o.;
			if (oo0_0oOo.o. != null)
			{
				oo0_0oOo.o..NameChanged += a_;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0002D9F3 File Offset: 0x0002BBF3
		[CompilerGenerated]
		internal virtual OO___OO0O_0 <<EMPTY_NAME>>()
		{
			return this.OO0_0oOo.o.;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0002D9FB File Offset: 0x0002BBFB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(OO___OO0O_0 A_0)
		{
			this.OO0_0oOo.o. = A_0;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0002DA04 File Offset: 0x0002BC04
		internal Oo0__Oo(Table A_0)
		{
			base.GotFocus += this.o.0O_O0o_.;
			this.O_000__.o.(new OO___OO0O_0());
			this.O_000__.o.(A_0);
			base.Name = A_0.Name;
			this.OO0O_o0o.0oOoo.();
			this.O_000__.o.().BorderStyle = BorderStyle.None;
			this.O_000__.o.().TabsCanFocus = false;
			this.O_000__.o.().Alignment = TabAlignment.Bottom;
			this.O_000__.o.().CanCloseTabs = false;
			this.O_000__.o.().SelectedTabBold = true;
			this.O_000__.o.().Dock = DockStyle.Fill;
			this.O_000__.o.().TabLook = ButtonLookFlags.TextAndImage;
			this.O_000__.o.().TabPages.Add(new O0o0(A_0));
			this.O_000__.o.().TabPages[0].Text = "主窗口";
			this.O_000__.o.().ShowSingleTab = false;
			this.O_000__.o.().TabsCanFocus = false;
			base.Controls.Add(this.O_000__.o.());
			if (O_O0OO.O0_00o.o0__o..ShowTableIcon)
			{
				base.Image = A_0._frdIcon;
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0002DB14 File Offset: 0x0002BD14
		private void <<EMPTY_NAME>>()
		{
			base.Name = this.O_000__.o.().Name;
			if (Operators.CompareString(OO_00oOO.DataTables[this.O_000__.o.().Name].Caption, "", true) > 0)
			{
				this.Text = OO_00oOO.DataTables[this.O_000__.o.().Name].Caption;
				return;
			}
			this.Text = this.O_000__.o.().Name;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0002DB8C File Offset: 0x0002BD8C
		internal bool <<EMPTY_NAME>>()
		{
			return this.OO0_0oOo.o. != null;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0002DB97 File Offset: 0x0002BD97
		internal bool <<EMPTY_NAME>>()
		{
			return this.oo.O00_. != null;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0002DBA2 File Offset: 0x0002BDA2
		internal bool <<EMPTY_NAME>>()
		{
			return this.O__O.o_oOO. != null;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0002DBAD File Offset: 0x0002BDAD
		internal bool <<EMPTY_NAME>>()
		{
			return this.o_o.oOOoo0oo. != null;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0002DBB8 File Offset: 0x0002BDB8
		internal o_O0_0O0 <<EMPTY_NAME>>()
		{
			if (this.OO0_0oOo.o. == null)
			{
				this.OO0_0oOo.o. = new o_O0_0O0(DockStyle.Left);
				this.OO0_0oOo.o..OoOoo_O0o0.0O_.(this.O_000__.o.().DataTable.frd_LeftDockSize);
				this.O_000__.o.().TabPages[0].Controls.Add(this.OO0_0oOo.o.);
				this.OO0_0oOo.o..SendToBack();
			}
			else if (this.OO0_0oOo.o..FindForm() == null)
			{
				this.O_000__.o.().TabPages[0].Controls.Add(this.OO0_0oOo.o.);
			}
			return this.OO0_0oOo.o.;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0002DC58 File Offset: 0x0002BE58
		internal o_O0_0O0 <<EMPTY_NAME>>()
		{
			if (this.oo.O00_. == null)
			{
				this.oo.O00_. = new o_O0_0O0(DockStyle.Right);
				this.oo.O00_..OoOoo_O0o0.0O_.(this.O_000__.o.().DataTable.frd_RightDockSize);
				this.O_000__.o.().TabPages[0].Controls.Add(this.oo.O00_.);
				this.oo.O00_..SendToBack();
			}
			return this.oo.O00_.;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0002DCC8 File Offset: 0x0002BEC8
		internal o_O0_0O0 <<EMPTY_NAME>>()
		{
			if (this.O__O.o_oOO. == null)
			{
				this.O__O.o_oOO. = new o_O0_0O0(DockStyle.Bottom);
				this.O__O.o_oOO..OoOoo_O0o0.0O_.(this.O_000__.o.().DataTable.frd_BottomDockSize);
				this.O_000__.o.().TabPages[0].Controls.Add(this.O__O.o_oOO.);
				this.O__O.o_oOO..SendToBack();
			}
			return this.O__O.o_oOO.;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0002DD38 File Offset: 0x0002BF38
		internal o_O0_0O0 <<EMPTY_NAME>>()
		{
			if (this.o_o.oOOoo0oo. == null)
			{
				this.o_o.oOOoo0oo. = new o_O0_0O0(DockStyle.Top);
				this.o_o.oOOoo0oo..OoOoo_O0o0.0O_.(this.O_000__.o.().DataTable.frd_TopDockSize);
				this.O_000__.o.().TabPages[0].Controls.Add(this.o_o.oOOoo0oo.);
				this.o_o.oOOoo0oo..SendToBack();
			}
			return this.o_o.oOOoo0oo.;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0002DDA8 File Offset: 0x0002BFA8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O_000__.o.().FindForm() != null && this.O_000__.o.().SelectedTab != null && this.O_000__.o.().SelectedTab.Controls.Count > 0 && this.O_000__.o.().SelectedTab.Controls[0] is FormPanel)
			{
				Foxtable.WinForm.Form form = OO_00oOO.Forms[this.O_000__.o.().SelectedTab.Controls[0].Name];
				if (form.OOOo._. != null)
				{
					try
					{
						foreach (Foxtable.WinForm.Control control in form.Controls)
						{
							if (Operators.CompareString(control.Name, form.OOOo._., true) == 0)
							{
								control.Select();
								if (control.BaseControl.CanFocus)
								{
									control.BaseControl.Focus();
									break;
								}
								break;
							}
						}
					}
					finally
					{
						IEnumerator<Foxtable.WinForm.Control> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0002DEAC File Offset: 0x0002C0AC
		private void <<EMPTY_NAME>>()
		{
			this.OO0O_o0o.0oOoo.();
		}

		// Token: 0x04000160 RID: 352
		[CompilerGenerated]
		private Table <<EMPTY_NAME>>;

		// Token: 0x04000161 RID: 353
		[CompilerGenerated]
		private OO___OO0O_0 <<EMPTY_NAME>>;

		// Token: 0x04000162 RID: 354
		private o_O0_0O0 <<EMPTY_NAME>>;

		// Token: 0x04000163 RID: 355
		private o_O0_0O0 <<EMPTY_NAME>>;

		// Token: 0x04000164 RID: 356
		private o_O0_0O0 <<EMPTY_NAME>>;

		// Token: 0x04000165 RID: 357
		private o_O0_0O0 <<EMPTY_NAME>>;
	}
}
