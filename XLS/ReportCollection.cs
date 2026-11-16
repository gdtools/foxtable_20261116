using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.XLS
{
	// Token: 0x020004F8 RID: 1272
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ReportCollection : IEnumerable<Report>
	{
		// Token: 0x06005343 RID: 21315 RVA: 0x00255DF7 File Offset: 0x00253FF7
		public ReportCollection()
		{
			this.OoOoo.o. = new Dictionary<string, Report>();
			this.OoOoo.o. = true;
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x00255E14 File Offset: 0x00254014
		internal void <<EMPTY_NAME>>()
		{
			this.OoOoo.o..Clear();
			foreach (DataRow a_ in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Select("[Type] = " + Conversions.ToString(5)))
			{
				Report report = new Report(a_);
				this.OoOoo.o..Add(report.Name, report);
			}
		}

		// Token: 0x17001228 RID: 4648
		public Report this[string Name]
		{
			get
			{
				return this.OoOoo.o.[Name];
			}
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x00255E8F File Offset: 0x0025408F
		public IEnumerator<Report> GetEnumerator()
		{
			return (IEnumerator<Report>)this.OoOoo.o..Values.GetEnumerator();
		}

		// Token: 0x06005347 RID: 21319 RVA: 0x00255EAB File Offset: 0x002540AB
		public IEnumerator GetEnumerator1()
		{
			return (IEnumerator)this.OoOoo.o..Values.GetEnumerator();
		}

		// Token: 0x04002294 RID: 8852
		private Dictionary<string, Report> <<EMPTY_NAME>>;

		// Token: 0x04002295 RID: 8853
		private Assembly <<EMPTY_NAME>>;

		// Token: 0x04002296 RID: 8854
		private Assembly <<EMPTY_NAME>>;

		// Token: 0x04002297 RID: 8855
		internal bool <<EMPTY_NAME>>;
	}
}
