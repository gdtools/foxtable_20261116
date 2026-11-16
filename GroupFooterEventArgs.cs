using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Foxtable.XLS;

namespace Foxtable
{
	// Token: 0x0200045D RID: 1117
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class GroupFooterEventArgs : BuildEventArgs
	{
		// Token: 0x06004B41 RID: 19265 RVA: 0x002210E0 File Offset: 0x0021F2E0
		public GroupFooterEventArgs(Book A_0, string A_1, string A_2, List<DataRow> A_3, List<DataRow> A_4) : base(A_0)
		{
			this.OO_000.oo. = new List<DataRow>();
			this.o00O0_.0. = new List<DataRow>();
			this.OO_000.oo. = A_1;
			this.OO_O.00_oo. = A_2;
			try
			{
				foreach (DataRow a_ in A_3)
				{
					this.OO_000.oo..Add(new DataRow(a_));
				}
			}
			finally
			{
				List<DataRow>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (DataRow a_2 in A_4)
				{
					this.o00O0_.0..Add(new DataRow(a_2));
				}
			}
			finally
			{
				List<DataRow>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06004B42 RID: 19266 RVA: 0x002211B0 File Offset: 0x0021F3B0
		public string TableName
		{
			get
			{
				return this.OO_000.oo.;
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06004B43 RID: 19267 RVA: 0x002211B8 File Offset: 0x0021F3B8
		public string ColumnName
		{
			get
			{
				return this.OO_O.00_oo.;
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06004B44 RID: 19268 RVA: 0x002211C0 File Offset: 0x0021F3C0
		public List<DataRow> GroupRows
		{
			get
			{
				return this.OO_000.oo.;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06004B45 RID: 19269 RVA: 0x002211C8 File Offset: 0x0021F3C8
		public List<DataRow> TotalRows
		{
			get
			{
				return this.o00O0_.0.;
			}
		}

		// Token: 0x04001E8E RID: 7822
		private string <<EMPTY_NAME>>;

		// Token: 0x04001E8F RID: 7823
		private string <<EMPTY_NAME>>;

		// Token: 0x04001E90 RID: 7824
		private List<DataRow> <<EMPTY_NAME>>;

		// Token: 0x04001E91 RID: 7825
		private List<DataRow> <<EMPTY_NAME>>;
	}
}
