using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 上工具栏
	/// </summary>
	// Token: 0x02000022 RID: 34
	[ComVisible(true)]
	public class TopToolBar : RibbonItem
	{
		// Token: 0x06000116 RID: 278 RVA: 0x000037F2 File Offset: 0x000019F2
		internal TopToolBar(RibbonTopToolBar A_0) : base(A_0)
		{
			this.O.oOOO. = A_0;
		}

		// Token: 0x17000080 RID: 128
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		/// <summary>
		/// 一个集合，包括上工具栏的所有项目
		/// </summary>
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00003810 File Offset: 0x00001A10
		public RibbonItemCollection Items
		{
			get
			{
				if (this.o__Oo__.O__. == null)
				{
					this.o__Oo__.O__. = new RibbonItemCollection(this.O.oOOO..Items);
				}
				return this.o__Oo__.O__.;
			}
		}

		// Token: 0x04000034 RID: 52
		private RibbonTopToolBar <<EMPTY_NAME>>;

		// Token: 0x04000035 RID: 53
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}
