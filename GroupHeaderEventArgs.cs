using System;
using System.ComponentModel;
using Foxtable.XLS;

namespace Foxtable
{
	// Token: 0x0200045E RID: 1118
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class GroupHeaderEventArgs : BuildEventArgs
	{
		// Token: 0x06004B46 RID: 19270 RVA: 0x002211D0 File Offset: 0x0021F3D0
		public GroupHeaderEventArgs(Book A_0, string A_1, string A_2, DataRow A_3, bool A_4) : base(A_0)
		{
			this.OO_000.oo. = A_1;
			this.o00O0_.0. = A_2;
			this.OO_000.oo. = A_3;
			this.OO_000.oo. = A_4;
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06004B47 RID: 19271 RVA: 0x002211F7 File Offset: 0x0021F3F7
		public string TableName
		{
			get
			{
				return this.OO_000.oo.;
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06004B48 RID: 19272 RVA: 0x002211FF File Offset: 0x0021F3FF
		public string ColumnName
		{
			get
			{
				return this.o00O0_.0.;
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06004B49 RID: 19273 RVA: 0x00221207 File Offset: 0x0021F407
		public DataRow DataRow
		{
			get
			{
				return this.OO_000.oo.;
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06004B4A RID: 19274 RVA: 0x0022120F File Offset: 0x0021F40F
		public bool NewPage
		{
			get
			{
				return this.OO_000.oo.;
			}
		}

		// Token: 0x04001E92 RID: 7826
		private Book <<EMPTY_NAME>>;

		// Token: 0x04001E93 RID: 7827
		private string <<EMPTY_NAME>>;

		// Token: 0x04001E94 RID: 7828
		private string <<EMPTY_NAME>>;

		// Token: 0x04001E95 RID: 7829
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04001E96 RID: 7830
		private bool <<EMPTY_NAME>>;
	}
}
