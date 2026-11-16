using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;

namespace Foxtable
{
	// Token: 0x020004AF RID: 1199
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonGalleryEventArgs
	{
		// Token: 0x06005039 RID: 20537 RVA: 0x00239399 File Offset: 0x00237599
		public RibbonGalleryEventArgs(Gallery A_0, GalleryItem A_1)
		{
			this.O_oOO_.o0. = A_0;
			this.O_oOO_.o0. = A_1;
		}

		/// <summary>
		/// 返回触发事件的Gallery
		/// </summary>
		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x0600503A RID: 20538 RVA: 0x002393AF File Offset: 0x002375AF
		public Gallery Gallery
		{
			get
			{
				return this.O_oOO_.o0.;
			}
		}

		/// <summary>
		/// 返回所单击的项目
		/// </summary>
		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x0600503B RID: 20539 RVA: 0x002393B7 File Offset: 0x002375B7
		public GalleryItem GalleryItem
		{
			get
			{
				return this.O_oOO_.o0.;
			}
		}

		// Token: 0x04002101 RID: 8449
		private Gallery <<EMPTY_NAME>>;

		// Token: 0x04002102 RID: 8450
		private GalleryItem <<EMPTY_NAME>>;
	}
}
