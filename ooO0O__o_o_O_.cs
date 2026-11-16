using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020004DA RID: 1242
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ooO0O__o_o_O_ : Oo0__O__O_0__
	{
		// Token: 0x0600518D RID: 20877 RVA: 0x00245364 File Offset: 0x00243564
		public ooO0O__o_o_O_(Table A_0)
		{
			this.O0oO.o_OOoO_. = new List<string>();
			this.O0oO.o_OOoO_. = A_0;
			O_oOooO_O o_oOooO_O = this.O0oO.o_OOoO_..foxGrid;
			int @fixed = o_oOooO_O.Cols.Fixed;
			int num = o_oOooO_O.Cols.Count - 1;
			for (int i = @fixed; i <= num; i++)
			{
				if (o_oOooO_O.Cols[i].Visible)
				{
					this.O0oO.o_OOoO_..Add(o_oOooO_O.Cols[i].Name);
				}
			}
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x002453EA File Offset: 0x002435EA
		public void <<EMPTY_NAME>>()
		{
			this.O0oO.o_OOoO_.();
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x002453F4 File Offset: 0x002435F4
		public void <<EMPTY_NAME>>()
		{
			O_oOooO_O o_oOooO_O = this.O0oO.o_OOoO_..foxGrid;
			o_oOooO_O.BeginUpdate();
			List<string> list = new List<string>();
			int @fixed = o_oOooO_O.Cols.Fixed;
			int num = o_oOooO_O.Cols.Count - 1;
			for (int i = @fixed; i <= num; i++)
			{
				if (o_oOooO_O.Cols[i].Visible)
				{
					list.Add(o_oOooO_O.Cols[i].Name);
				}
			}
			int fixed2 = o_oOooO_O.Cols.Fixed;
			int num2 = o_oOooO_O.Cols.Count - 1;
			for (int j = fixed2; j <= num2; j++)
			{
				if (this.O0oO.o_OOoO_..Contains(o_oOooO_O.Cols[j].Name))
				{
					o_oOooO_O.Cols[j].Visible = true;
				}
				else
				{
					o_oOooO_O.Cols[j].Visible = false;
				}
			}
			this.O0oO.o_OOoO_..Clear();
			this.O0oO.o_OOoO_..AddRange(list);
			o_oOooO_O.EndUpdate();
		}

		// Token: 0x04002187 RID: 8583
		private Table <<EMPTY_NAME>>;

		// Token: 0x04002188 RID: 8584
		private List<string> <<EMPTY_NAME>>;
	}
}
