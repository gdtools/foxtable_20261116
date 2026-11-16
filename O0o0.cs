using System;
using C1.Win.C1Command;

namespace Foxtable
{
	// Token: 0x0200008E RID: 142
	internal class O0o0 : C1DockingTabPage
	{
		// Token: 0x0600057A RID: 1402 RVA: 0x0002DEB4 File Offset: 0x0002C0B4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OO0_0oOo.o..foxGrid != null && !this.OO0_0oOo.o..foxGrid.Disposing && !this.OO0_0oOo.o..foxGrid.IsDisposed && this.OO0_0oOo.o..foxGrid.CanFocus)
			{
				this.OO0_0oOo.o..foxGrid.Focus();
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0002DF18 File Offset: 0x0002C118
		internal O0o0(Table A_0)
		{
			base.GotFocus += this.OO0_0oOo.o.;
			this.OO0_0oOo.o. = A_0;
			base.Name = A_0.Name;
			if (A_0.foxGrid.Parent == null)
			{
				base.Controls.Clear();
				base.Controls.Add(A_0.foxGrid);
			}
		}

		// Token: 0x04000166 RID: 358
		internal Table <<EMPTY_NAME>>;
	}
}
