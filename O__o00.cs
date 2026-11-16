using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x02000433 RID: 1075
	internal class O__o00 : O_o_0o
	{
		// Token: 0x060048C1 RID: 18625 RVA: 0x001F546D File Offset: 0x001F366D
		internal O__o00(Control A_0)
		{
			this.o.oO0O0OO_o_. = new List<OoO>();
			this.o.oO0O0OO_o_. = A_0;
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x001F5487 File Offset: 0x001F3687
		internal void <<EMPTY_NAME>>(ControlHolder A_0)
		{
			this.o.oO0O0OO_o_..Add(new OoO(A_0));
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x001F549C File Offset: 0x001F369C
		internal void <<EMPTY_NAME>>()
		{
			try
			{
				foreach (OoO ooO in this.o.oO0O0OO_o_.)
				{
					if (ooO.OO00_O0_._OO0..Parent != this.o.oO0O0OO_o_.)
					{
						this.o.oO0O0OO_o_..Controls.Add(ooO.OO00_O0_._OO0.);
					}
					ooO.OO00_O0_._OO0..Location = ooO.OO00_O0_._OO0.;
					ooO.OO00_O0_._OO0..Selected = true;
				}
			}
			finally
			{
				List<OoO>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x04001D67 RID: 7527
		private Control <<EMPTY_NAME>>;

		// Token: 0x04001D68 RID: 7528
		private List<OoO> <<EMPTY_NAME>>;
	}
}
