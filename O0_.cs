using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000AA RID: 170
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O0_ : IComparer
	{
		// Token: 0x0600069F RID: 1695 RVA: 0x00030D44 File Offset: 0x0002EF44
		public O0_(string A_0, bool A_1)
		{
			this.o.oOOOo___o_. = '\0';
			this.o.oOOOo___o_. = A_0;
			this.o.oOOOo___o_. = A_1;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00030D61 File Offset: 0x0002EF61
		public O0_(string A_0, bool A_1, char A_2)
		{
			this.o.oOOOo___o_. = '\0';
			this.o.oOOOo___o_. = A_0;
			this.o.oOOOo___o_. = A_1;
			this.o.oOOOo___o_. = A_2;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00030D88 File Offset: 0x0002EF88
		private int <<EMPTY_NAME>>(DataRowView A_0, DataRowView A_1)
		{
			int num = 0;
			if (A_0.Row.IsNull(this.o.oOOOo___o_.) || A_1.Row.IsNull(this.o.oOOOo___o_.))
			{
				if (!A_0.Row.IsNull(this.o.oOOOo___o_.))
				{
					num = 1;
				}
				else if (!A_1.Row.IsNull(this.o.oOOOo___o_.))
				{
					num = -1;
				}
			}
			else if (this.o.oOOOo___o_. > '\0' && A_0.DataView.Table.Columns[this.o.oOOOo___o_.].DataType == typeof(string))
			{
				string[] array = A_0[this.o.oOOOo___o_.].ToString().Split(new char[]
				{
					this.o.oOOOo___o_.
				});
				string[] array2 = A_1[this.o.oOOOo___o_.].ToString().Split(new char[]
				{
					this.o.oOOOo___o_.
				});
				if (array.All(new Func<string, bool>(this.Oo_00_oO.00O0O.)) && array2.All(new Func<string, bool>(this.Oo_00_oO.00O0O.)))
				{
					int num2 = Math.Min(array.Length, array2.Length) - 1;
					for (int i = 0; i <= num2; i++)
					{
						num = Comparer<int>.Default.Compare(Conversions.ToInteger(array[i]), Conversions.ToInteger(array2[i]));
						if (num != 0)
						{
							break;
						}
					}
					if (num == 0)
					{
						num = Comparer<int>.Default.Compare(array.Length, array2.Length);
					}
				}
				else
				{
					num = Comparer.DefaultInvariant.Compare(RuntimeHelpers.GetObjectValue(A_0[this.o.oOOOo___o_.]), RuntimeHelpers.GetObjectValue(A_1[this.o.oOOOo___o_.]));
				}
			}
			else
			{
				num = Comparer.DefaultInvariant.Compare(RuntimeHelpers.GetObjectValue(A_0[this.o.oOOOo___o_.]), RuntimeHelpers.GetObjectValue(A_1[this.o.oOOOo___o_.]));
			}
			int result;
			if (!this.o.oOOOo___o_.)
			{
				result = num;
			}
			else
			{
				result = -num;
			}
			return result;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00030F68 File Offset: 0x0002F168
		private bool <<EMPTY_NAME>>(string A_0)
		{
			int num;
			return int.TryParse(A_0, out num);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00030F80 File Offset: 0x0002F180
		public int <<EMPTY_NAME>>(object A_0, object A_1)
		{
			int result;
			if (A_0 == null || A_1 == null)
			{
				if (A_0 != null)
				{
					result = 1;
				}
				else if (A_1 != null)
				{
					result = -1;
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = this.Oo_00_oO.00O0O.((DataRowView)A_0, (DataRowView)A_1);
			}
			return result;
		}

		// Token: 0x040001D0 RID: 464
		private string <<EMPTY_NAME>>;

		// Token: 0x040001D1 RID: 465
		private bool <<EMPTY_NAME>>;

		// Token: 0x040001D2 RID: 466
		private char <<EMPTY_NAME>>;
	}
}
