using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200009E RID: 158
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class o00_0__O
	{
		// Token: 0x0600063C RID: 1596 RVA: 0x0002FD4C File Offset: 0x0002DF4C
		[CompilerGenerated]
		public DataTable <<EMPTY_NAME>>()
		{
			return this.oOO.0_O0.;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0002FD54 File Offset: 0x0002DF54
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(DataTable A_0)
		{
			this.oOO.0_O0. = A_0;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0002FD5D File Offset: 0x0002DF5D
		[CompilerGenerated]
		public string <<EMPTY_NAME>>()
		{
			return this.oOO.0_O0.;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0002FD65 File Offset: 0x0002DF65
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.oOO.0_O0. = A_0;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0002FD6E File Offset: 0x0002DF6E
		[CompilerGenerated]
		public string <<EMPTY_NAME>>()
		{
			return this.O0oo_.0_o0o0oO.;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0002FD76 File Offset: 0x0002DF76
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.O0oo_.0_o0o0oO. = A_0;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0002FD7F File Offset: 0x0002DF7F
		[CompilerGenerated]
		public string <<EMPTY_NAME>>()
		{
			return this.o_Ooo0.o_oO.;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0002FD87 File Offset: 0x0002DF87
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.o_Ooo0.o_oO. = A_0;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0002FD90 File Offset: 0x0002DF90
		[CompilerGenerated]
		public bool <<EMPTY_NAME>>()
		{
			return this.oOO.0_O0.;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0002FD98 File Offset: 0x0002DF98
		[CompilerGenerated]
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.oOO.0_O0. = A_0;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0002FDA1 File Offset: 0x0002DFA1
		public DataView <<EMPTY_NAME>>()
		{
			if (this.oOO.0_O0. == null)
			{
				this.oOO.0_O0. = new DataView(this.oo__.0O00.().BaseTable, "", this.oooO00__.o0.(), DataViewRowState.CurrentRows);
			}
			return this.oOO.0_O0.;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0002FDD4 File Offset: 0x0002DFD4
		internal o00_0__O(DataTable A_0, string A_1, string A_2, string A_3)
		{
			this.oo__.0O00.(false);
			this.oo__.0O00.(A_0);
			this.oo__.0O00.(A_1);
			this.o_Ooo0.o_oO.(A_2);
			this.o.oOo_Oo0O.(A_3);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0002FE00 File Offset: 0x0002E000
		public string <<EMPTY_NAME>>()
		{
			string result;
			if (Operators.CompareString(this.o.oOo_Oo0O.(), "", true) > 0)
			{
				result = this.o.oOo_Oo0O.();
			}
			else
			{
				if (!this.oo__.0O00.())
				{
					throw new Exception("未指定扩展列名称！");
				}
				result = this.oooO00.o00O.();
			}
			return result;
		}

		// Token: 0x040001A3 RID: 419
		[CompilerGenerated]
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x040001A4 RID: 420
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001A5 RID: 421
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001A6 RID: 422
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040001A7 RID: 423
		[CompilerGenerated]
		private bool <<EMPTY_NAME>>;

		// Token: 0x040001A8 RID: 424
		private DataView <<EMPTY_NAME>>;
	}
}
