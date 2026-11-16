using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 工具栏
	/// </summary>
	// Token: 0x0200001D RID: 29
	[ComVisible(true)]
	public class ToolBar : RibbonItem
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x000034BE File Offset: 0x000016BE
		internal ToolBar(RibbonToolBar A_0) : base(A_0)
		{
			this.o__Oo__.O__. = A_0;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000034CE File Offset: 0x000016CE
		public ToolBar(string A_0)
		{
			this.o__Oo__.O__. = new RibbonToolBar();
			this.oOo_.0o_O_O_0. = this.o__Oo__.O__.;
			this.o__Oo__.O__..ID = A_0;
		}

		// Token: 0x17000067 RID: 103
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		/// <summary>
		/// 一个集合，包括工具栏的所有项目
		/// </summary>
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00003507 File Offset: 0x00001707
		public RibbonItemCollection Items
		{
			get
			{
				if (this.o__Oo__.O__. == null)
				{
					this.o__Oo__.O__. = new RibbonItemCollection(this.o__Oo__.O__..Items);
				}
				return this.o__Oo__.O__.;
			}
		}

		// Token: 0x0400002A RID: 42
		internal RibbonToolBar <<EMPTY_NAME>>;

		// Token: 0x0400002B RID: 43
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}
