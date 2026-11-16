using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Foxtable.XLS;

namespace Foxtable
{
	// Token: 0x0200045F RID: 1119
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class PageFooterEventArgs : BuildEventArgs
	{
		// Token: 0x06004B4B RID: 19275 RVA: 0x00221218 File Offset: 0x0021F418
		public PageFooterEventArgs(Book A_0, List<DataRow> A_1, List<DataRow> A_2) : base(A_0)
		{
			this.oo0oOoo00o.0_0. = new List<DataRow>();
			this.o0_Oo__0.0_oO_. = new List<DataRow>();
			try
			{
				foreach (DataRow a_ in A_1)
				{
					this.oo0oOoo00o.0_0..Add(new DataRow(a_));
				}
			}
			finally
			{
				List<DataRow>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			try
			{
				foreach (DataRow a_2 in A_2)
				{
					this.o0_Oo__0.0_oO_..Add(new DataRow(a_2));
				}
			}
			finally
			{
				List<DataRow>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06004B4C RID: 19276 RVA: 0x002212D8 File Offset: 0x0021F4D8
		public List<DataRow> PageRows
		{
			get
			{
				return this.oo0oOoo00o.0_0.;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06004B4D RID: 19277 RVA: 0x002212E0 File Offset: 0x0021F4E0
		public List<DataRow> TotalRows
		{
			get
			{
				return this.o0_Oo__0.0_oO_.;
			}
		}

		// Token: 0x04001E97 RID: 7831
		private List<DataRow> <<EMPTY_NAME>>;

		// Token: 0x04001E98 RID: 7832
		private List<DataRow> <<EMPTY_NAME>>;
	}
}
