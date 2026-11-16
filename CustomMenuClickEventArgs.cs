using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000193 RID: 403
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CustomMenuClickEventArgs : OpenQQMenuEventArgs
	{
		// Token: 0x0600131E RID: 4894 RVA: 0x00083D75 File Offset: 0x00081F75
		public CustomMenuClickEventArgs(string A_0, string A_1, string A_2, int A_3, string A_4, DateTime A_5) : base(A_1, A_2, A_3, A_4, A_5)
		{
			this.o0o0O._o0Oo. = A_0;
		}

		/// <summary>
		/// 所单击菜单项目的标题
		/// </summary>
		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x00083D8C File Offset: 0x00081F8C
		public string MenuText
		{
			get
			{
				return this.o0o0O._o0Oo.;
			}
		}

		// Token: 0x0400076C RID: 1900
		private string <<EMPTY_NAME>>;
	}
}
