using System;
using System.Collections.Generic;
using System.ComponentModel;
using C1.Win.C1FlexGrid;

namespace Foxtable
{
	// Token: 0x020004DF RID: 1247
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O_0_Oo : Oo0__O__O_0__
	{
		// Token: 0x0600519C RID: 20892 RVA: 0x0024592D File Offset: 0x00243B2D
		public O_0_Oo(Table A_0)
		{
			this.oOOo_o0o0O._. = new List<string>();
			this.oOOo_o0o0O._. = new List<TextAlignEnum>();
			this.oOOo_o0o0O._. = A_0;
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x00245952 File Offset: 0x00243B52
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.oOOo_o0o0O._..Add(A_0);
			this.oOOo_o0o0O._..Add(this.oOOo_o0o0O._..foxGrid.Cols[A_0].TextAlign);
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x00245986 File Offset: 0x00243B86
		public void <<EMPTY_NAME>>()
		{
			this.O_oo._o.();
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x00245990 File Offset: 0x00243B90
		public void <<EMPTY_NAME>>()
		{
			int num = this.oOOo_o0o0O._..Count - 1;
			for (int i = 0; i <= num; i++)
			{
				TextAlignEnum textAlign = this.oOOo_o0o0O._..foxGrid.Cols[this.oOOo_o0o0O._.[i]].TextAlign;
				TextAlignEnum textAlignEnum = this.oOOo_o0o0O._.[i];
				if (textAlignEnum != TextAlignEnum.LeftCenter)
				{
					if (textAlignEnum != TextAlignEnum.CenterCenter)
					{
						if (textAlignEnum != TextAlignEnum.RightCenter)
						{
							this.oOOo_o0o0O._..DataTable.DataCols[this.oOOo_o0o0O._.[i]].TextAlign = TextAlignEnum.Default;
						}
						else
						{
							this.oOOo_o0o0O._..DataTable.DataCols[this.oOOo_o0o0O._.[i]].TextAlign = TextAlignEnum.Right;
						}
					}
					else
					{
						this.oOOo_o0o0O._..DataTable.DataCols[this.oOOo_o0o0O._.[i]].TextAlign = TextAlignEnum.Center;
					}
				}
				else
				{
					this.oOOo_o0o0O._..DataTable.DataCols[this.oOOo_o0o0O._.[i]].TextAlign = TextAlignEnum.Left;
				}
				this.oOOo_o0o0O._..DataTable.DataCols[this.oOOo_o0o0O._.[i]].O.O_OO.(false);
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this.oOOo_o0o0O._..DataTable && table.foxGrid.Cols.Contains(this.oOOo_o0o0O._.[i]))
						{
							table.foxGrid.Cols[this.oOOo_o0o0O._.[i]].TextAlign = this.oOOo_o0o0O._.[i];
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.oOOo_o0o0O._.[i] = textAlign;
			}
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x00245B74 File Offset: 0x00243D74
		public int <<EMPTY_NAME>>()
		{
			return this.oOOo_o0o0O._..Count;
		}

		// Token: 0x04002193 RID: 8595
		private Table <<EMPTY_NAME>>;

		// Token: 0x04002194 RID: 8596
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04002195 RID: 8597
		private List<TextAlignEnum> <<EMPTY_NAME>>;
	}
}
