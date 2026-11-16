using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Foxtable.RibbonMenu
{
	// Token: 0x0200001B RID: 27
	[ComVisible(true)]
	public class Gallery : RibbonItem
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x000032A0 File Offset: 0x000014A0
		internal Gallery(o_o_Oo0__o_0 A_0) : base(A_0)
		{
			this.o_.o0_o. = A_0;
		}

		/// <summary>
		/// 组件名称
		/// </summary>
		/// <param name="Name"></param>
		// Token: 0x060000CA RID: 202 RVA: 0x000032B0 File Offset: 0x000014B0
		public Gallery(string A_0)
		{
			this.o_.o0_o. = new o_o_Oo0__o_0();
			this.oOo_.0o_O_O_0. = this.o_.o0_o.;
			this.o_.o0_o..ID = A_0;
		}

		/// <summary>
		/// 组件是否处于展开状态
		/// </summary>
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000032DB File Offset: 0x000014DB
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000032E8 File Offset: 0x000014E8
		public bool Expanded
		{
			get
			{
				return this.o_.o0_o..Expanded;
			}
			set
			{
				this.o_.o0_o..Expanded = value;
			}
		}

		/// <summary>
		/// Gallery中项目的大小
		/// </summary>
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000032F6 File Offset: 0x000014F6
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00003303 File Offset: 0x00001503
		public Size ItemSize
		{
			get
			{
				return this.o_.o0_o..ItemSize;
			}
			set
			{
				this.o_.o0_o..ItemSize = value;
			}
		}

		/// <summary>
		/// 组件标题
		/// </summary>
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00003311 File Offset: 0x00001511
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000331E File Offset: 0x0000151E
		public string Text
		{
			get
			{
				return this.o_.o0_o..Text;
			}
			set
			{
				this.o_.o0_o..Text = value;
			}
		}

		/// <summary>
		/// Gallery中项目的标题是否位于图标之下
		/// </summary>
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000332C File Offset: 0x0000152C
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00003339 File Offset: 0x00001539
		public bool VerticalLayout
		{
			get
			{
				return this.o_.o0_o..oOoO0ooo_0O._.();
			}
			set
			{
				this.o_.o0_o..o.o_.(value);
			}
		}

		// Token: 0x1700005B RID: 91
		[EditorBrowsable(EditorBrowsableState.Never)]
		public GalleryItem this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003355 File Offset: 0x00001555
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object MenuItem
		{
			get
			{
				return this.MenuItems[Name];
			}
		}

		/// <summary>
		/// 一个项目，包括Gallery的所有项目
		/// </summary>
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00003363 File Offset: 0x00001563
		public GalleryItemCollection Items
		{
			get
			{
				if (this.o_.o0_o. == null)
				{
					this.o_.o0_o. = new GalleryItemCollection(this.o_.o0_o..Items, this.o_.o0_o..oOoO0ooo_0O._.());
				}
				return this.o_.o0_o.;
			}
		}

		/// <summary>
		/// 一个集合，包括Gallery的所有菜单项目
		/// </summary>
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00003394 File Offset: 0x00001594
		public RibbonItemCollection MenuItems
		{
			get
			{
				if (this.o_.o0_o. == null)
				{
					this.o_.o0_o. = new RibbonItemCollection(this.o_.o0_o..MenuItems);
				}
				return this.o_.o0_o.;
			}
		}

		// Token: 0x04000026 RID: 38
		internal o_o_Oo0__o_0 <<EMPTY_NAME>>;

		// Token: 0x04000027 RID: 39
		private RibbonItemCollection <<EMPTY_NAME>>;

		// Token: 0x04000028 RID: 40
		private GalleryItemCollection <<EMPTY_NAME>>;
	}
}
