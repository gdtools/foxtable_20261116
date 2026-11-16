using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Command;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003CA RID: 970
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	[oO0oooo("0830")]
	public class TabPageCollection : IEnumerable<TabPage>
	{
		// Token: 0x06003F7B RID: 16251 RVA: 0x001D0F6C File Offset: 0x001CF16C
		public TabPageCollection(C1DockingTabPages A_0)
		{
			this.Oo_._O0oOOOo. = A_0;
		}

		// Token: 0x17000D5E RID: 3422
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TabPage this[int Index]
		{
			get
			{
				return (TabPage)this.Oo_._O0oOOOo.[Index];
			}
		}

		// Token: 0x17000D5F RID: 3423
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TabPage this[string Name]
		{
			get
			{
				return (TabPage)this.Oo_._O0oOOOo.[Name];
			}
		}

		/// <summary>
		/// 页面数量
		/// </summary>
		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06003F7E RID: 16254 RVA: 0x001D0FA1 File Offset: 0x001CF1A1
		public int Count
		{
			get
			{
				return this.Oo_._O0oOOOo..Count;
			}
		}

		/// <summary>
		/// 判断是否存在指定名称的页面
		/// </summary>
		/// <param name="name">页面名称</param>
		// Token: 0x06003F7F RID: 16255 RVA: 0x001D0FB0 File Offset: 0x001CF1B0
		public bool Contains(string name)
		{
			try
			{
				IEnumerator enumerator = this.Oo_._O0oOOOo..GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (Operators.CompareString(((C1DockingTabPage)enumerator.Current).Name, name, true) == 0)
					{
						return true;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return false;
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x001D101C File Offset: 0x001CF21C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<TabPage> GetEnumerator()
		{
			return new o0_0oo00_o(this.Oo_._O0oOOOo.);
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x001D1029 File Offset: 0x001CF229
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return new o0_0oo00_o(this.Oo_._O0oOOOo.);
		}

		/// <summary>
		/// 增加页面
		/// </summary>
		/// <param name="Name">页面名称</param>
		/// <param name="Text">页面标题</param>
		// Token: 0x06003F82 RID: 16258 RVA: 0x001D1038 File Offset: 0x001CF238
		public TabPage Add(string Name, string Text)
		{
			TabPage tabPage = new TabPage();
			tabPage.Name = Name;
			tabPage.Text = Text;
			this.Oo_._O0oOOOo..Add(tabPage);
			return tabPage;
		}

		/// <summary>
		/// 插入页面
		/// </summary>
		/// <param name="Name">页面名称</param>
		/// <param name="Text">页面标题</param>
		/// <param name="Index">插入位置</param>
		// Token: 0x06003F83 RID: 16259 RVA: 0x001D1068 File Offset: 0x001CF268
		public TabPage Insert(string Name, string Text, int Index)
		{
			TabPage tabPage = new TabPage();
			tabPage.Name = Name;
			tabPage.Text = Text;
			this.Oo_._O0oOOOo..Insert(Index, tabPage);
			return tabPage;
		}

		/// <summary>
		/// 删除指定名称的页面
		/// </summary>
		/// <param name="Name">要删除页面的名称</param>
		// Token: 0x06003F84 RID: 16260 RVA: 0x001D1098 File Offset: 0x001CF298
		public void Delete(string Name)
		{
			TabPage tabPage = (TabPage)this.Oo_._O0oOOOo.[Name];
			tabPage.ClearControl();
			this.Oo_._O0oOOOo..Remove(tabPage);
		}

		/// <summary>
		/// 删除指定位置的页面
		/// </summary>
		/// <param name="index">要删除页面的位置</param>
		// Token: 0x06003F85 RID: 16261 RVA: 0x001D10CC File Offset: 0x001CF2CC
		public void Delete(int index)
		{
			TabPage tabPage = (TabPage)this.Oo_._O0oOOOo.[index];
			tabPage.ClearControl();
			this.Oo_._O0oOOOo..Remove(tabPage);
		}

		/// <summary>
		/// 删除所有页面
		/// </summary>
		// Token: 0x06003F86 RID: 16262 RVA: 0x001D1100 File Offset: 0x001CF300
		public void Clear()
		{
			try
			{
				foreach (object obj in this.Oo_._O0oOOOo.)
				{
					((TabPage)obj).ClearControl();
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.Oo_._O0oOOOo..Clear();
		}

		// Token: 0x040019E1 RID: 6625
		private C1DockingTabPages <<EMPTY_NAME>>;
	}
}
