using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000A7 RID: 167
	internal class Oo0
	{
		// Token: 0x06000689 RID: 1673 RVA: 0x00030418 File Offset: 0x0002E618
		internal string <<EMPTY_NAME>>(Table A_0)
		{
			Row row = null;
			Row row2 = null;
			if (A_0.Rows.Count > 0)
			{
				row = A_0.Rows[0];
			}
			if (A_0.Rows.Count > 1)
			{
				row2 = A_0.Rows[1];
			}
			string result;
			if (row != null && !this.O_OOO.0o.(new Row[]
			{
				row,
				row2
			}))
			{
				result = this.o0o0OOO.OO0o.(A_0);
			}
			else if (A_0.Rows.Count == 0)
			{
				result = "1";
			}
			else
			{
				HashSet<int> hashSet = new HashSet<int>();
				int num;
				foreach (DataRow dataRow in A_0.DataTable.BaseTable.Select("sys_Hierarchy_Level= 0", "", DataViewRowState.CurrentRows))
				{
					if (!dataRow.IsNull(this.OOOO._.) && int.TryParse(dataRow[this.OOOO._.].ToString(), out num))
					{
						hashSet.Add(num);
					}
				}
				num = 1;
				while (hashSet.Contains(num))
				{
					num++;
				}
				if (Operators.CompareString(this.OOOO._., "", true) > 0 && this.O_OOO.0o. != null && this.O_OOO.0o..Length > 0)
				{
					result = Strings.Format(num, new string('0', this.O_OOO.0o.[0]));
				}
				else
				{
					result = num.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00030570 File Offset: 0x0002E770
		internal string <<EMPTY_NAME>>(Row A_0, Row A_1)
		{
			string str = A_0[this.OOOO._.].ToString();
			List<Row> children = A_0.GetChildren(false);
			HashSet<int> hashSet = new HashSet<int>();
			string result;
			if (Operators.CompareString(Conversions.ToString(this.O_OOO.0o.), "", true) > 0 && Operators.CompareString(this.OOOO._., "", true) > 0)
			{
				if (!this.O_OOO.0o.(new Row[]
				{
					A_0,
					A_1
				}))
				{
					result = this.o0o0OOO.OO0o.(A_0, A_1);
				}
				else if (children.Count > 0)
				{
					int num;
					try
					{
						foreach (Row row in children)
						{
							if (!row.get_IsNull(this.OOOO._.))
							{
								string[] array = row[this.OOOO._.].ToString().Split(new char[]
								{
									this.O_OOO.0o.
								});
								if (int.TryParse(array[array.Length - 1], out num))
								{
									hashSet.Add(num);
								}
							}
						}
					}
					finally
					{
						List<Row>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					num = 1;
					while (hashSet.Contains(num))
					{
						num++;
					}
					result = str + Conversions.ToString(this.O_OOO.0o.) + num.ToString();
				}
				else
				{
					result = str + Conversions.ToString(this.O_OOO.0o.) + "1";
				}
			}
			else if (Operators.CompareString(this.OOOO._., "", true) > 0 && this.O_OOO.0o. != null && this.O_OOO.0o..Length > 0)
			{
				int num2 = Conversions.ToInteger(A_0["sys_Hierarchy_Level"]) + 1;
				int num3;
				if (num2 <= this.O_OOO.0o..Length - 1)
				{
					num3 = this.O_OOO.0o.[num2];
				}
				else
				{
					num3 = this.O_OOO.0o.[this.O_OOO.0o..Length - 1];
				}
				if (children.Count > 0)
				{
					int num;
					try
					{
						foreach (Row row2 in children)
						{
							if (!row2.get_IsNull(this.OOOO._.) && int.TryParse(Strings.Right(row2[this.OOOO._.].ToString(), num3), out num))
							{
								hashSet.Add(num);
							}
						}
					}
					finally
					{
						List<Row>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					num = 1;
					while (hashSet.Contains(num))
					{
						num++;
					}
					result = str + Interaction.IIf(Operators.CompareString(Conversions.ToString(this.O_OOO.0o.), "\0", true) == 0, "", this.O_OOO.0o.).ToString() + Strings.Format(num, new string('0', num3));
				}
				else
				{
					result = str + Interaction.IIf(Operators.CompareString(Conversions.ToString(this.O_OOO.0o.), "\0", true) == 0, "", this.O_OOO.0o.).ToString() + Strings.Format(1, new string('0', num3));
				}
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00030880 File Offset: 0x0002EA80
		private string <<EMPTY_NAME>>(Row A_0, Row A_1)
		{
			string str = A_0[this.OOOO._.].ToString();
			string result;
			if (A_1 == null || A_1.get_IsNull(this.OOOO._.))
			{
				List<Row> children = A_0.GetChildren(false);
				HashSet<string> hashSet = new HashSet<string>();
				try
				{
					foreach (Row row in children)
					{
						string[] array = row[this.OOOO._.].ToString().Split(new char[]
						{
							this.O_OOO.0o.
						});
						hashSet.Add(array[array.Length - 1]);
					}
				}
				finally
				{
					List<Row>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				int num = 1;
				while (hashSet.Contains("新项目" + num.ToString()))
				{
					num++;
				}
				string str2 = "新项目" + num.ToString();
				result = str + Conversions.ToString(this.O_OOO.0o.) + str2;
			}
			else
			{
				string[] array2 = A_1[this.OOOO._.].ToString().Split(new char[]
				{
					this.O_OOO.0o.
				});
				result = str + Conversions.ToString(this.O_OOO.0o.) + array2[array2.Length - 1];
			}
			return result;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000309CC File Offset: 0x0002EBCC
		private string <<EMPTY_NAME>>(Table A_0)
		{
			HashSet<string> hashSet = new HashSet<string>();
			try
			{
				foreach (Row row in A_0.Rows)
				{
					if (row.Hierarchy == 0)
					{
						hashSet.Add(row[this.OOOO._.].ToString());
					}
				}
			}
			finally
			{
				IEnumerator<Row> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			int num = 1;
			while (hashSet.Contains("新项目" + num.ToString()))
			{
				num++;
			}
			return "新项目" + num.ToString();
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00030A74 File Offset: 0x0002EC74
		internal bool <<EMPTY_NAME>>(params Row[] A_0)
		{
			foreach (Row row in A_0)
			{
				if (row != null)
				{
					foreach (string text in row[this.OOOO._.].ToString().Split(new char[]
					{
						this.O_OOO.0o.
					}))
					{
						int num;
						if (Operators.CompareString(text, "", true) > 0 && !int.TryParse(text, out num))
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00030AFC File Offset: 0x0002ECFC
		internal string <<EMPTY_NAME>>(Table A_0)
		{
			HashSet<string> hashSet = new HashSet<string>();
			try
			{
				foreach (Row row in A_0.Rows)
				{
					hashSet.Add(row[this.O_OOO.0o.].ToString());
					hashSet.Add(row[this.OO._o0_o_OO0O.].ToString());
				}
			}
			finally
			{
				IEnumerator<Row> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			int num = 1;
			string result;
			if (A_0.DataTable.DataCols[this.O_OOO.0o.].IsNumeric)
			{
				while (hashSet.Contains(num.ToString()))
				{
					num++;
				}
				result = num.ToString();
			}
			else
			{
				while (hashSet.Contains("新项目" + num.ToString()))
				{
					num++;
				}
				result = "新项目" + num.ToString();
			}
			return result;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00030BF0 File Offset: 0x0002EDF0
		internal string <<EMPTY_NAME>>(Row A_0)
		{
			Table table = A_0.Table;
			return this.o0Oo.0_Oo0__O.(table);
		}

		// Token: 0x040001C3 RID: 451
		internal string <<EMPTY_NAME>>;

		// Token: 0x040001C4 RID: 452
		internal string <<EMPTY_NAME>>;

		// Token: 0x040001C5 RID: 453
		internal string <<EMPTY_NAME>>;

		// Token: 0x040001C6 RID: 454
		internal char <<EMPTY_NAME>>;

		// Token: 0x040001C7 RID: 455
		internal int[] <<EMPTY_NAME>>;

		// Token: 0x040001C8 RID: 456
		internal string[] <<EMPTY_NAME>>;
	}
}
