using System;
using System.Collections.Generic;
using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000329 RID: 809
	internal class OOO0o
	{
		// Token: 0x06002D35 RID: 11573 RVA: 0x0014D3D5 File Offset: 0x0014B5D5
		internal OOO0o(Table A_0)
		{
			this.OOooOOo_.0_0_o. = new Dictionary<string, ColumnLayoutSetting>();
			this.O__OOo_.0O. = A_0;
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x0014D3F0 File Offset: 0x0014B5F0
		internal void <<EMPTY_NAME>>()
		{
			this.OOooOOo_.0_0_o. = this.O__OOo_.0O..foxGrid.Row;
			this.oOoOO_._0. = this.O__OOo_.0O..foxGrid.RowSel;
			this.oo.0OoO. = this.O__OOo_.0O..foxGrid.Col;
			this.oo.0_oOO0_O_. = this.O__OOo_.0O..foxGrid.ColSel;
			if (this.O__OOo_.0O..foxGrid.Cols.Contains("_Locked"))
			{
				this.O__OOo_.0O..oO_o_0o._0oooo.(true);
			}
			this.OOooOOo_.0_0_o..Clear();
			int @fixed = this.O__OOo_.0O..foxGrid.Cols.Fixed;
			int num = this.O__OOo_.0O..foxGrid.Cols.Count - 1;
			for (int i = @fixed; i <= num; i++)
			{
				Column column = this.O__OOo_.0O..foxGrid.Cols[i];
				if (Operators.CompareString(column.Name, "", true) != 0 && this.O__OOo_.0O..View.o_o.O0ooOo.().Columns.Contains(column.Name) && !this.OOooOOo_.0_0_o..ContainsKey(column.Name))
				{
					this.OOooOOo_.0_0_o..Add(column.Name, new ColumnLayoutSetting(column.Name, column.Width, this.O__OOo_.0O..View.o_o.O0ooOo.().Columns[column.Name].ReadOnly, column.Visible));
				}
			}
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x0014D578 File Offset: 0x0014B778
		internal void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			if (this.OOooOOo_.0_0_o..ContainsKey(A_0))
			{
				ColumnLayoutSetting columnLayoutSetting = this.OOooOOo_.0_0_o.[A_0];
				columnLayoutSetting.Name = A_1;
				this.OOooOOo_.0_0_o..Remove(A_0);
				this.OOooOOo_.0_0_o..Add(A_1, columnLayoutSetting);
			}
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x0014D5C4 File Offset: 0x0014B7C4
		internal void <<EMPTY_NAME>>()
		{
			this.O__OOo_.0O..ClearEditInfos();
			if (this.OOooOOo_.0_0_o..Count != 0)
			{
				int num = this.O__OOo_.0O..foxGrid.Cols.Fixed;
				try
				{
					foreach (ColumnLayoutSetting columnLayoutSetting in this.OOooOOo_.0_0_o..Values)
					{
						if (columnLayoutSetting != null && this.O__OOo_.0O..foxGrid.Cols.Contains(columnLayoutSetting.Name))
						{
							this.O__OOo_.0O..foxGrid.Cols[columnLayoutSetting.Name].Move(num);
							this.O__OOo_.0O..foxGrid.Cols[columnLayoutSetting.Name].Width = columnLayoutSetting.Width;
							this.O__OOo_.0O..foxGrid.Cols[columnLayoutSetting.Name].Visible = columnLayoutSetting.Visible;
							num++;
						}
					}
				}
				finally
				{
					Dictionary<string, ColumnLayoutSetting>.ValueCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				O_oOooO_O o_oOooO_O = this.O__OOo_.0O..foxGrid;
				this.oo.0_oOO0_O_. = Math.Min(o_oOooO_O.Cols.Count - 1, this.oo.0_oOO0_O_.);
				this.oo.0OoO. = Math.Min(o_oOooO_O.Cols.Count - 1, this.oo.0OoO.);
				this.oOoOO_._0. = Math.Min(o_oOooO_O.Rows.Count - 1, this.oOoOO_._0.);
				this.OOooOOo_.0_0_o. = Math.Min(o_oOooO_O.Rows.Count - 1, this.OOooOOo_.0_0_o.);
				this.O__OOo_.0O..foxGrid.Select(this.OOooOOo_.0_0_o., this.oo.0OoO., this.oOoOO_._0., this.oo.0_oOO0_O_.);
			}
		}

		// Token: 0x04001251 RID: 4689
		private Dictionary<string, ColumnLayoutSetting> <<EMPTY_NAME>>;

		// Token: 0x04001252 RID: 4690
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001253 RID: 4691
		private int <<EMPTY_NAME>>;

		// Token: 0x04001254 RID: 4692
		private int <<EMPTY_NAME>>;

		// Token: 0x04001255 RID: 4693
		private int <<EMPTY_NAME>>;

		// Token: 0x04001256 RID: 4694
		private int <<EMPTY_NAME>>;
	}
}
