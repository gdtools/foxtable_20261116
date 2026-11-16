using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 下工具栏
	/// </summary>
	// Token: 0x02000023 RID: 35
	[ComVisible(true)]
	public class BottomToolBar : RibbonItem
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00003836 File Offset: 0x00001A36
		internal BottomToolBar(RibbonBottomToolBar A_0) : base(A_0)
		{
			this.oOoOoOoO._o0. = A_0;
		}

		// Token: 0x17000082 RID: 130
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		/// <summary>
		/// 一个集合，包括下工具栏的所有项目
		/// </summary>
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00003854 File Offset: 0x00001A54
		public RibbonItemCollection Items
		{
			get
			{
				if (this.oOoOoOoO._o0. == null)
				{
					this.oOoOoOoO._o0. = new RibbonItemCollection(this.oOoOoOoO._o0..Items);
				}
				return this.oOoOoOoO._o0.;
			}
		}

		// Token: 0x04000036 RID: 54
		private RibbonBottomToolBar <<EMPTY_NAME>>;

		// Token: 0x04000037 RID: 55
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}
