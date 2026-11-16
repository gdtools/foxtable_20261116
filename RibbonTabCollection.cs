using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x020004A0 RID: 1184
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RibbonTabCollection
	{
		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06005004 RID: 20484 RVA: 0x0023911C File Offset: 0x0023731C
		// (set) Token: 0x06005005 RID: 20485 RVA: 0x00239123 File Offset: 0x00237323
		[DisplayName("功能区")]
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
