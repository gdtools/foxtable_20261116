using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000304 RID: 772
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class GlobalVariableChangedEventArgs
	{
		// Token: 0x060029D8 RID: 10712 RVA: 0x0012B4E1 File Offset: 0x001296E1
		public GlobalVariableChangedEventArgs(string A_0)
		{
			this.o0o0OOO.OO0o. = A_0;
		}

		/// <summary>
		/// var变量名
		/// </summary>
		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x0012B4F0 File Offset: 0x001296F0
		public string Name
		{
			get
			{
				return this.o0o0OOO.OO0o.;
			}
		}

		// Token: 0x04001151 RID: 4433
		private string <<EMPTY_NAME>>;
	}
}
