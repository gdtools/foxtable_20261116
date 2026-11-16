using System;
using System.ComponentModel;
using Foxtable.XLS;

namespace Foxtable
{
	// Token: 0x020002F5 RID: 757
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class BuildEventArgs
	{
		// Token: 0x06002962 RID: 10594 RVA: 0x0012AA04 File Offset: 0x00128C04
		public BuildEventArgs(Book A_0)
		{
			this.o._0__00_oo. = A_0;
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002963 RID: 10595 RVA: 0x0012AA13 File Offset: 0x00128C13
		public Book Book
		{
			get
			{
				return this.o._0__00_oo.;
			}
		}

		// Token: 0x04001116 RID: 4374
		private Book <<EMPTY_NAME>>;
	}
}
