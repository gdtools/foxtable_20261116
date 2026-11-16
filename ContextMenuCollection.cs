using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x0200047D RID: 1149
	internal class ContextMenuCollection
	{
		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06004E5C RID: 20060 RVA: 0x00237868 File Offset: 0x00235A68
		// (set) Token: 0x06004E5D RID: 20061 RVA: 0x0023786F File Offset: 0x00235A6F
		[Category("属性")]
		[Editor(typeof(RibbonItemCollectionEditor), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("快捷菜单")]
		public Hashtable ContextMenus
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
