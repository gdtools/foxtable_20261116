using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 程序菜单
	/// </summary>
	// Token: 0x02000024 RID: 36
	[ComVisible(true)]
	public class ApplicationMenu : RibbonItem
	{
		// Token: 0x0600011C RID: 284 RVA: 0x0000387A File Offset: 0x00001A7A
		internal ApplicationMenu(RibbonApplicationMenu A_0) : base(A_0)
		{
			this.oOoOoOoO._o0. = A_0;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000388A File Offset: 0x00001A8A
		public ApplicationMenu()
		{
			this.oOoOoOoO._o0. = new RibbonApplicationMenu();
			this.oOo_.0o_O_O_0. = this.oOoOoOoO._o0.;
		}

		/// <summary>
		/// 标题
		/// </summary>
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000038A9 File Offset: 0x00001AA9
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000038B6 File Offset: 0x00001AB6
		public string Text
		{
			get
			{
				return this.oOoOoOoO._o0..Text;
			}
			set
			{
				this.oOoOoOoO._o0..Text = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000038C4 File Offset: 0x00001AC4
		// (set) Token: 0x06000121 RID: 289 RVA: 0x000038DA File Offset: 0x00001ADA
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int DropdownWidth
		{
			get
			{
				return Main.OO_O.o..O.OOO0_OOo.().ApplicationMenu.DropDownWidth;
			}
			set
			{
				Main.OO_O.o..O.OOO0_OOo.().ApplicationMenu.DropDownWidth = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000038F1 File Offset: 0x00001AF1
		// (set) Token: 0x06000123 RID: 291 RVA: 0x000038F8 File Offset: 0x00001AF8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int RecentFiles
		{
			get
			{
				return O_O0OO.o0OoO00OO.00O.;
			}
			set
			{
				O_O0OO.o0OoO00OO.00O. = value;
			}
		}

		/// <summary>
		/// 返回程序菜单左侧的项目集合
		/// </summary>
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00003900 File Offset: 0x00001B00
		public RibbonItemCollection LeftItems
		{
			get
			{
				if (this.oOoOoOoO._o0. == null)
				{
					this.oOoOoOoO._o0. = new RibbonItemCollection(this.oOoOoOoO._o0..LeftPaneItems);
				}
				return this.oOoOoOoO._o0.;
			}
		}

		/// <summary>
		/// 返回程序菜单右侧的项目集合
		/// </summary>
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00003926 File Offset: 0x00001B26
		public RibbonItemCollection RightItems
		{
			get
			{
				if (this.o0O__.O. == null)
				{
					this.o0O__.O. = new RibbonItemCollection(this.oOoOoOoO._o0..RightPaneItems);
				}
				return this.o0O__.O.;
			}
		}

		/// <summary>
		/// 返回程序菜单底部的项目集合
		/// </summary>
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000394C File Offset: 0x00001B4C
		public RibbonItemCollection BottomItems
		{
			get
			{
				if (this.Oo._o_0O. == null)
				{
					this.Oo._o_0O. = new RibbonItemCollection(this.oOoOoOoO._o0..BottomPaneItems);
				}
				return this.Oo._o_0O.;
			}
		}

		// Token: 0x04000038 RID: 56
		private RibbonApplicationMenu <<EMPTY_NAME>>;

		// Token: 0x04000039 RID: 57
		private RibbonItemCollection <<EMPTY_NAME>>;

		// Token: 0x0400003A RID: 58
		private RibbonItemCollection <<EMPTY_NAME>>;

		// Token: 0x0400003B RID: 59
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}
