using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	// Token: 0x0200002E RID: 46
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	[oO0oooo("3085")]
	public class GalleryItemCollection : IEnumerable
	{
		// Token: 0x06000164 RID: 356 RVA: 0x00003FFE File Offset: 0x000021FE
		public GalleryItemCollection(RibbonGalleryItemCollection A_0, bool A_1)
		{
			this.OO0oOo.O_o0. = A_0;
			this.OO0oOo.O_o0. = A_1;
		}

		/// <summary>
		/// 增加项目
		/// </summary>
		/// <param name="Item">要增加的项目</param>
		// Token: 0x06000165 RID: 357 RVA: 0x00004014 File Offset: 0x00002214
		public void Add(GalleryItem Item)
		{
			Item.OO0oOo.O_o0..VerticalLayout = this.OO0oOo.O_o0.;
			this.OO0oOo.O_o0..Add(Item.OO0oOo.O_o0.);
		}

		/// <summary>
		/// 插入项目
		/// </summary>
		/// <param name="Index">插入位置</param>
		/// <param name="Item">要插入的项目</param>
		// Token: 0x06000166 RID: 358 RVA: 0x00004039 File Offset: 0x00002239
		public void Insert(int Index, GalleryItem Item)
		{
			this.OO0oOo.O_o0..Insert(Index, Item.OO0oOo.O_o0.);
		}

		/// <summary>
		/// 删除指定名称的项目
		/// </summary>
		/// <param name="Name">要删除项目的名称</param>
		// Token: 0x06000167 RID: 359 RVA: 0x0000404D File Offset: 0x0000224D
		public void Remove(string Name)
		{
			this.OO0oOo.O_o0..Remove(Name);
		}

		/// <summary>
		/// 删除项目
		/// </summary>
		/// <param name="Item">要删除的项目</param>
		// Token: 0x06000168 RID: 360 RVA: 0x0000405B File Offset: 0x0000225B
		public void Remove(GalleryItem Item)
		{
			this.OO0oOo.O_o0..Remove(Item.OO0oOo.O_o0.);
		}

		/// <summary>
		/// 删除指定位置的项目
		/// </summary>
		/// <param name="Index">要删除项目所在位置</param>
		// Token: 0x06000169 RID: 361 RVA: 0x0000406E File Offset: 0x0000226E
		public void RemoveAt(int Index)
		{
			this.OO0oOo.O_o0..RemoveAt(Index);
		}

		/// <summary>
		/// 判断是否存在指定名称的项目
		/// </summary>
		/// <param name="Name">项目名称</param>
		// Token: 0x0600016A RID: 362 RVA: 0x0000407C File Offset: 0x0000227C
		public bool Contains(string Name)
		{
			return this.OO0oOo.O_o0..Contains(Name);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000408A File Offset: 0x0000228A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Contains(RibbonItem Item)
		{
			return this.OO0oOo.O_o0..Contains(Item.oOo_.0o_O_O_0.);
		}

		/// <summary>
		/// 清除所有项目
		/// </summary>
		// Token: 0x0600016C RID: 364 RVA: 0x0000409D File Offset: 0x0000229D
		public void Clear()
		{
			this.OO0oOo.O_o0..Clear();
		}

		/// <summary>
		/// 项目总数
		/// </summary>
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000040AA File Offset: 0x000022AA
		public int Count
		{
			get
			{
				return this.OO0oOo.O_o0..Count;
			}
		}

		// Token: 0x170000A6 RID: 166
		[EditorBrowsable(EditorBrowsableState.Never)]
		public GalleryItem this[object A_0]
		{
			get
			{
				GalleryItem result;
				if (A_0 is string)
				{
					result = this[Conversions.ToString(A_0)];
				}
				else
				{
					result = this[Conversions.ToInteger(A_0)];
				}
				return result;
			}
		}

		// Token: 0x170000A7 RID: 167
		[EditorBrowsable(EditorBrowsableState.Never)]
		public GalleryItem this[string A_0]
		{
			get
			{
				GalleryItem result;
				if (this.OO0oOo.O_o0..Contains(A_0))
				{
					result = new GalleryItem(this.OO0oOo.O_o0.[A_0]);
				}
				else
				{
					MessageBox.Show("Gallery中不存在名为\"" + A_0 + "\"的项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = null;
				}
				return result;
			}
		}

		// Token: 0x170000A8 RID: 168
		[EditorBrowsable(EditorBrowsableState.Never)]
		public GalleryItem this[int A_0]
		{
			get
			{
				GalleryItem result;
				if (A_0 < 0 | A_0 > this.OO0oOo.O_o0..Count - 1)
				{
					result = null;
				}
				else
				{
					result = new GalleryItem((RibbonGalleryItem)this.OO0oOo.O_o0.[A_0]);
				}
				return result;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000417C File Offset: 0x0000237C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator()
		{
			return new GalleryItemEnumerator(this);
		}

		// Token: 0x0400004C RID: 76
		private RibbonGalleryItemCollection <<EMPTY_NAME>>;

		// Token: 0x0400004D RID: 77
		private bool <<EMPTY_NAME>>;
	}
}
