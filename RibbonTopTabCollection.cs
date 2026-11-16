using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000494 RID: 1172
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonTopTabCollection
	{
		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06004FA8 RID: 20392 RVA: 0x00238D1B File Offset: 0x00236F1B
		// (set) Token: 0x06004FA9 RID: 20393 RVA: 0x00238D22 File Offset: 0x00236F22
		[DisplayName("功能区组")]
		[O_Oo00Oo000O0(5.0)]
		[Editor(typeof(RibbonItemCollectionEditor), typeof(UITypeEditor))]
		[Category("属性")]
		public Hashtable Tabs
		{
			get
			{
				return new Hashtable();
			}
			set
			{
			}
		}
	}
}
