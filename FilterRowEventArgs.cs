using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000303 RID: 771
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FilterRowEventArgs
	{
		// Token: 0x060029D2 RID: 10706 RVA: 0x0012B48F File Offset: 0x0012968F
		public FilterRowEventArgs(Table A_0, Row A_1, bool A_2)
		{
			this.O0o.0oo0_. = true;
			this.O0o.0oo0_. = A_0;
			this.O._00000. = A_1;
			this.O0o.0oo0_. = A_2;
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060029D3 RID: 10707 RVA: 0x0012B4B3 File Offset: 0x001296B3
		public Table Table
		{
			get
			{
				return this.O0o.0oo0_.;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x0012B4BB File Offset: 0x001296BB
		public Row Row
		{
			get
			{
				return this.O._00000.;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x060029D5 RID: 10709 RVA: 0x0012B4C3 File Offset: 0x001296C3
		// (set) Token: 0x060029D6 RID: 10710 RVA: 0x0012B4CB File Offset: 0x001296CB
		public bool Visible
		{
			get
			{
				return this.O0o.0oo0_.;
			}
			set
			{
				this.O0o.0oo0_. = value;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x0012B4D4 File Offset: 0x001296D4
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x0400114E RID: 4430
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400114F RID: 4431
		private Row <<EMPTY_NAME>>;

		// Token: 0x04001150 RID: 4432
		private bool <<EMPTY_NAME>>;
	}
}
