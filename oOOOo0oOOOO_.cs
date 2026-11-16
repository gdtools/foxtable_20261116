using System;
using System.Reflection;
using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020004D8 RID: 1240
	internal class oOOOo0oOOOO_ : Oo0__O__O_0__
	{
		// Token: 0x06005187 RID: 20871 RVA: 0x00244E88 File Offset: 0x00243088
		public oOOOo0oOOOO_(Table A_0, CellRange A_1)
		{
			this.O_._0o00_. = A_0;
			this.O_._0o00_. = A_1;
			this.O_._0o00_. = A_0.foxGrid.OO_.00oO0Oo.(A_1);
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x00244EB0 File Offset: 0x002430B0
		public void <<EMPTY_NAME>>()
		{
			string o_._0o00_. = this.O_._0o00_..foxGrid.OO_.00oO0Oo.(this.O_._0o00_.);
			this.O_._0o00_..foxGrid.Select(this.O_._0o00_..r1, this.O_._0o00_..c1, this.O_._0o00_..r2, this.O_._0o00_..c2);
			string[,] array = new string[this.O_._0o00_..r2 - this.O_._0o00_..r1 + 1, this.O_._0o00_..c2 - this.O_._0o00_..c1 + 1];
			if (Operators.CompareString(this.O_._0o00_., "", true) == 0)
			{
				int upperBound = array.GetUpperBound(0);
				for (int i = 0; i <= upperBound; i++)
				{
					int upperBound2 = array.GetUpperBound(1);
					for (int j = 0; j <= upperBound2; j++)
					{
						array[i, j] = "";
					}
				}
			}
			else
			{
				string[] array2 = this.O_._0o00_..Split(new char[]
				{
					'\r'
				});
				int upperBound3 = array.GetUpperBound(0);
				for (int k = 0; k <= upperBound3; k++)
				{
					string[] array3 = array2[k].Split(new char[]
					{
						'\t'
					});
					int upperBound4 = array.GetUpperBound(1);
					for (int l = 0; l <= upperBound4; l++)
					{
						array[k, l] = array3[l];
					}
				}
			}
			int r = this.O_._0o00_..r1;
			int r2 = this.O_._0o00_..r2;
			for (int m = r; m <= r2; m++)
			{
				if (this.O_._0o00_..foxGrid.Rows[m].DataIndex != -1)
				{
					int c = this.O_._0o00_..c1;
					int c2 = this.O_._0o00_..c2;
					for (int n = c; n <= c2; n++)
					{
						if (Operators.CompareString(this.O_._0o00_..foxGrid[m, n].ToString(), array[m - this.O_._0o00_..r1, n - this.O_._0o00_..c1], true) != 0)
						{
							if (Operators.CompareString(array[m - this.O_._0o00_..r1, n - this.O_._0o00_..c1], "", true) == 0)
							{
								this.O_._0o00_..foxGrid[m, n] = DBNull.Value;
							}
							else
							{
								this.O_._0o00_..foxGrid[m, n] = array[m - this.O_._0o00_..r1, n - this.O_._0o00_..c1];
							}
							if (this.O_._0o00_..foxGrid.Rows[m].DataIndex != -1)
							{
								Oo00.o0_o._O_.(this.O_._0o00_..View.O0O_0_0__.0O.(this.O_._0o00_..foxGrid.Rows[m].DataIndex).Row);
								MethodInfo o0O00o_.0Oo. = this.O_._0o00_..DataTable.O0O00o_.0Oo.;
								if (o0O00o_.0Oo. != null && OO_00oOO.SystemReady)
								{
									RowColEventArgs rowColEventArgs = new RowColEventArgs(this.O_._0o00_., new Row(this.O_._0o00_., this.O_._0o00_..View.O0O_0_0__.0O.(this.O_._0o00_..foxGrid.Rows[m].DataIndex)), this.O_._0o00_..Cols[this.O_._0o00_..foxGrid.Cols[n].Name], null);
									try
									{
										o0O00o_.0Oo..Invoke(null, new object[]
										{
											rowColEventArgs
										});
									}
									catch (Exception a_)
									{
										ooO.oOo0Oo.o.(a_, "表，" + this.O_._0o00_..DataTable.Name + "，AfterEdit");
									}
								}
							}
						}
					}
				}
			}
			this.O_._0o00_. = o_._0o00_.;
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x002452A0 File Offset: 0x002434A0
		public void <<EMPTY_NAME>>()
		{
			this.oO0000.OO0oo.();
		}

		// Token: 0x04002180 RID: 8576
		private Table <<EMPTY_NAME>>;

		// Token: 0x04002181 RID: 8577
		private CellRange <<EMPTY_NAME>>;

		// Token: 0x04002182 RID: 8578
		private string <<EMPTY_NAME>>;
	}
}
