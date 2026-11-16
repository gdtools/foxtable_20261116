using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 快速访问栏
	/// </summary>
	// Token: 0x02000020 RID: 32
	[oO0oooo("1094")]
	[ComVisible(true)]
	public class Qat : RibbonItem
	{
		// Token: 0x0600010E RID: 270 RVA: 0x0000374F File Offset: 0x0000194F
		internal Qat(RibbonQat A_0) : base(A_0)
		{
			this.OOo.O_o. = A_0;
		}

		// Token: 0x1700007B RID: 123
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		/// <summary>
		/// 一个集合,包括快速访问栏的所有项目
		/// </summary>
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000376D File Offset: 0x0000196D
		public RibbonItemCollection Items
		{
			get
			{
				if (this.OOo.O_o. == null)
				{
					this.OOo.O_o. = new RibbonItemCollection(this.OOo.O_o..Items);
				}
				return this.OOo.O_o.;
			}
		}

		/// <summary>
		/// 返回或设置快速访问栏的位置
		/// </summary>
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00003793 File Offset: 0x00001993
		// (set) Token: 0x06000112 RID: 274 RVA: 0x000037A0 File Offset: 0x000019A0
		public bool BelowRibbon
		{
			get
			{
				return this.OOo.O_o..BelowRibbon;
			}
			set
			{
				this.OOo.O_o..BelowRibbon = value;
			}
		}

		// Token: 0x04000030 RID: 48
		private RibbonQat <<EMPTY_NAME>>;

		// Token: 0x04000031 RID: 49
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}
