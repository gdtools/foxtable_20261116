using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020004DD RID: 1245
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o_o0_ : Oo0__O__O_0__
	{
		// Token: 0x06005196 RID: 20886 RVA: 0x002457A8 File Offset: 0x002439A8
		public o_o0_(Table A_0, int A_1, int A_2)
		{
			this.O_o_.oo. = A_0;
			this.O_o_.oo. = A_1;
			if (A_2 == -1)
			{
				this.o_.00o_o000o_0. = A_0.foxGrid.Rows.DefaultSize;
				return;
			}
			this.o_.00o_o000o_0. = A_2;
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x002457E0 File Offset: 0x002439E0
		public void <<EMPTY_NAME>>()
		{
			this.oo0Ooo.o_0__0_.();
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x002457E8 File Offset: 0x002439E8
		public void <<EMPTY_NAME>>()
		{
			O_oOooO_O o_oOooO_O = this.O_o_.oo..foxGrid;
			int num;
			if (o_oOooO_O.Rows[this.O_o_.oo.].Height == -1)
			{
				num = o_oOooO_O.Rows.DefaultSize;
			}
			else
			{
				num = o_oOooO_O.Rows[this.O_o_.oo.].Height;
			}
			if (o_oOooO_O.Row < o_oOooO_O.Rows.Fixed || this.O_o_.oo..AllowResizeSingleRow)
			{
				o_oOooO_O.Rows[this.O_o_.oo.].Height = this.o_.00o_o000o_0.;
			}
			else
			{
				o_oOooO_O.BeginUpdate();
				o_oOooO_O.Rows.DefaultSize = this.o_.00o_o000o_0.;
				int @fixed = o_oOooO_O.Rows.Fixed;
				int num2 = o_oOooO_O.Rows.Count - 1;
				for (int i = @fixed; i <= num2; i++)
				{
					o_oOooO_O.Rows[i].Height = -1;
				}
				o_oOooO_O.EndUpdate();
			}
			this.o_.00o_o000o_0. = num;
		}

		// Token: 0x0400218E RID: 8590
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400218F RID: 8591
		private int <<EMPTY_NAME>>;

		// Token: 0x04002190 RID: 8592
		private int <<EMPTY_NAME>>;
	}
}
