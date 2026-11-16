using System;
using System.Runtime.InteropServices;
using C1.Win.C1Command;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 子快捷菜单
	/// </summary>
	// Token: 0x02000029 RID: 41
	[ComVisible(true)]
	public class ContextCommandMenu : ContextCommand
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00003C74 File Offset: 0x00001E74
		public ContextCommandMenu(C1CommandMenu A_0) : base(A_0)
		{
			this.o_o_0oO_.o_o. = A_0;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00003C84 File Offset: 0x00001E84
		public ContextCommandMenu(C1CommandLink A_0) : base(A_0)
		{
			this.o_o_0oO_.o_o. = (C1CommandMenu)A_0.Command;
		}

		// Token: 0x1700009C RID: 156
		public object this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		/// <summary>
		/// 集合，包括子快捷菜单的所有项目
		/// </summary>
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00003CAC File Offset: 0x00001EAC
		public ContextCommandCollection Items
		{
			get
			{
				if (this.o_o_0oO_.o_o. == null)
				{
					this.o_o_0oO_.o_o. = new ContextCommandCollection(this.o_o_0oO_.o_o..CommandLinks);
				}
				return this.o_o_0oO_.o_o.;
			}
		}

		// Token: 0x04000043 RID: 67
		private ContextCommandCollection <<EMPTY_NAME>>;

		// Token: 0x04000044 RID: 68
		private C1CommandMenu <<EMPTY_NAME>>;
	}
}
