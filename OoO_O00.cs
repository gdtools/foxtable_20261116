using System;
using System.Drawing;

namespace Foxtable
{
	// Token: 0x0200030E RID: 782
	internal class OoO_O00
	{
		// Token: 0x06002A29 RID: 10793 RVA: 0x0012BA1C File Offset: 0x00129C1C
		public OoO_O00(Table A_0)
		{
			this.O._00000. = A_0;
			this.O._00000. = A_0.View.oo_0._o.();
			this.O._00000. = A_0.Position;
			this.O._00000. = A_0.foxGrid.ScrollPosition;
			A_0.StopRedraw();
			A_0.View.O00o0.0_0O_.(false);
			A_0.View.Oo_oooOo._o0.("False");
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x0012BA88 File Offset: 0x00129C88
		internal void <<EMPTY_NAME>>(Table A_0 = null)
		{
			this.O._00000..View.Oo_oooOo._o0.(this.O._00000.);
			this.O._00000..View.O00o0.0_0O_.(true);
			if (this.O._00000..ooO__oo0O.0.(false) - 1 < this.O._00000. && this.O._00000..Position == this.O._00000..ooO__oo0O.0.(false) - 1)
			{
				this.O._00000..View.o_._0O0o_OoO.();
				this.O._00000..View.Oo._Oo0OO.();
			}
			this.O._00000..Position = this.O._00000.;
			this.O._00000..foxGrid.ScrollPosition = this.O._00000.;
			if (this.O._00000. != A_0)
			{
				this.O._00000..ResumeRedraw();
			}
		}

		// Token: 0x04001176 RID: 4470
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001177 RID: 4471
		private string <<EMPTY_NAME>>;

		// Token: 0x04001178 RID: 4472
		private int <<EMPTY_NAME>>;

		// Token: 0x04001179 RID: 4473
		private Point <<EMPTY_NAME>>;
	}
}
