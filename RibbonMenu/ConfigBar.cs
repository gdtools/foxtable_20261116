using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 配置栏
	/// </summary>
	// Token: 0x02000021 RID: 33
	[oO0oooo("1094")]
	[ComVisible(true)]
	public class ConfigBar : RibbonItem
	{
		// Token: 0x06000113 RID: 275 RVA: 0x000037AE File Offset: 0x000019AE
		internal ConfigBar(RibbonConfigToolBar A_0) : base(A_0)
		{
			this.oo0OOOO_._. = A_0;
		}

		// Token: 0x1700007E RID: 126
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		/// <summary>
		/// 一个集合，包括快速访问栏的所有项目
		/// </summary>
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000037CC File Offset: 0x000019CC
		public RibbonItemCollection Items
		{
			get
			{
				if (this.oo0OOOO_._. == null)
				{
					this.oo0OOOO_._. = new RibbonItemCollection(this.oo0OOOO_._..Items);
				}
				return this.oo0OOOO_._.;
			}
		}

		// Token: 0x04000032 RID: 50
		private RibbonConfigToolBar <<EMPTY_NAME>>;

		// Token: 0x04000033 RID: 51
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}
