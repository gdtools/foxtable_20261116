using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000472 RID: 1138
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ReportCollection : IEnumerable<Report>
	{
		// Token: 0x06004D76 RID: 19830 RVA: 0x0022EB07 File Offset: 0x0022CD07
		public ReportCollection()
		{
			this.o.0OoO. = new Dictionary<string, Report>();
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x0022EB1C File Offset: 0x0022CD1C
		internal void <<EMPTY_NAME>>()
		{
			this.o.0OoO..Clear();
			foreach (DataRow a_ in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Select("[Type] = " + Conversions.ToString(6)))
			{
				Report report = new Report(a_);
				this.o.0OoO..Add(report.Name, report);
			}
			Oo00.oO.0_o0o.();
		}

		// Token: 0x1700109D RID: 4253
		public Report this[string Name]
		{
			get
			{
				return this.o.0OoO.[Name];
			}
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x0022EB9C File Offset: 0x0022CD9C
		public IEnumerator<Report> GetEnumerator()
		{
			return (IEnumerator<Report>)this.o.0OoO..Values.GetEnumerator();
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x0022EBB8 File Offset: 0x0022CDB8
		public IEnumerator GetEnumerator1()
		{
			return (IEnumerator)this.o.0OoO..Values.GetEnumerator();
		}

		// Token: 0x04001FA3 RID: 8099
		private Dictionary<string, Report> <<EMPTY_NAME>>;
	}
}
