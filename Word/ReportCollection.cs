using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.Word
{
	// Token: 0x02000005 RID: 5
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ReportCollection : IEnumerable<Report>
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002410 File Offset: 0x00000610
		public ReportCollection()
		{
			this.O0oOOO._OOO. = new Dictionary<string, Report>();
			this.O0oOOO._OOO. = true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000242C File Offset: 0x0000062C
		internal void Load()
		{
			this.O0oOOO._OOO..Clear();
			foreach (DataRow a_ in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Select("[Type] = " + Conversions.ToString(9)))
			{
				Report report = new Report(a_);
				this.O0oOOO._OOO..Add(report.Name, report);
			}
		}

		// Token: 0x17000009 RID: 9
		public Report this[string Name]
		{
			get
			{
				return this.O0oOOO._OOO.[Name];
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024A8 File Offset: 0x000006A8
		public IEnumerator<Report> GetEnumerator()
		{
			return (IEnumerator<Report>)this.O0oOOO._OOO..Values.GetEnumerator();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000024C4 File Offset: 0x000006C4
		public IEnumerator GetEnumerator1()
		{
			return (IEnumerator)this.O0oOOO._OOO..Values.GetEnumerator();
		}

		// Token: 0x04000006 RID: 6
		private Dictionary<string, Report> <<EMPTY_NAME>>;

		// Token: 0x04000007 RID: 7
		private Assembly <<EMPTY_NAME>>;

		// Token: 0x04000008 RID: 8
		private Assembly <<EMPTY_NAME>>;

		// Token: 0x04000009 RID: 9
		internal bool <<EMPTY_NAME>>;
	}
}
