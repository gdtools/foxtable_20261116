using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 分割条
	/// </summary>
	// Token: 0x02000012 RID: 18
	[ComVisible(true)]
	public class Separator : RibbonItem
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00002CE9 File Offset: 0x00000EE9
		internal Separator(RibbonSeparator A_0) : base(A_0)
		{
			this.OO0.0OOo__. = A_0;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002CF9 File Offset: 0x00000EF9
		public Separator(string A_0)
		{
			this.OO0.0OOo__. = new RibbonSeparator();
			this.oOo_.0o_O_O_0. = this.OO0.0OOo__.;
			this.OO0.0OOo__..ID = A_0;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002D24 File Offset: 0x00000F24
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002D2B File Offset: 0x00000F2B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Text
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		// Token: 0x04000017 RID: 23
		internal RibbonSeparator <<EMPTY_NAME>>;
	}
}
