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
	// Token: 0x020003C7 RID: 967
	[ComVisible(true)]
	[oO0oooo("0873")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class NavPageCollection : IEnumerable<NavPage>
	{
		// Token: 0x06003F58 RID: 16216 RVA: 0x001D0AC8 File Offset: 0x001CECC8
		public NavPageCollection(C1NavBarPanel.PanelCollection A_0)
		{
			this.O__0_0Oo.Oo000. = A_0;
		}

		// Token: 0x17000D55 RID: 3413
		public NavPage this[int Index]
		{
			get
			{
				return (NavPage)this.O__0_0Oo.Oo000.[Index];
			}
		}

		// Token: 0x17000D56 RID: 3414
		public NavPage this[string Name]
		{
			get
			{
				return (NavPage)this.O__0_0Oo.Oo000.[Name];
			}
		}

		/// <summary>
		/// 是否包含指定名称的页面
		/// </summary>
		/// <param name="Name"></param>
		// Token: 0x06003F5B RID: 16219 RVA: 0x001D0B00 File Offset: 0x001CED00
		public bool Contains(string Name)
		{
			try
			{
				IEnumerator enumerator = this.O__0_0Oo.Oo000..GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (Operators.CompareString(((C1NavBarPanel)enumerator.Current).Name, Name, true) == 0)
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

		/// <summary>
		/// 页面数量
		/// </summary>
		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06003F5C RID: 16220 RVA: 0x001D0B6C File Offset: 0x001CED6C
		public int Count
		{
			get
			{
				return this.O__0_0Oo.Oo000..Count;
			}
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x001D0B7C File Offset: 0x001CED7C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public NavPage AddNavPage()
		{
			NavPage navPage = new NavPage();
			this.O__0_0Oo.Oo000..Add(navPage);
			return navPage;
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x001D0B9D File Offset: 0x001CED9D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<NavPage> GetEnumerator()
		{
			return new OOO0O0(this.O__0_0Oo.Oo000.);
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x001D0BAA File Offset: 0x001CEDAA
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return new OOO0O0(this.O__0_0Oo.Oo000.);
		}

		/// <summary>
		/// 增加页面
		/// </summary>
		/// <param name="Name">页面名称</param>
		/// <param name="ButtonText">页面按钮的标题</param>
		/// <param name="ButtonImageFile">页面按钮的图标文件</param>
		// Token: 0x06003F60 RID: 16224 RVA: 0x001D0BB8 File Offset: 0x001CEDB8
		public NavPage Add(string Name, string ButtonText, string ButtonImageFile)
		{
			NavPage navPage = new NavPage();
			navPage.Name = Name;
			navPage.ButtonText = ButtonText;
			navPage.Button.Image = OO_00oOO.GetImage(ButtonImageFile);
			this.O__0_0Oo.Oo000..Add(navPage);
			return navPage;
		}

		/// <summary>
		/// 插入页面
		/// </summary>
		/// <param name="Name">页面名称</param>
		/// <param name="ButtonText">页面按钮的标题</param>
		/// <param name="ButtonImageFile">页面按钮的图标文件</param>
		/// <param name="Index">插入位置</param>
		// Token: 0x06003F61 RID: 16225 RVA: 0x001D0BF8 File Offset: 0x001CEDF8
		public NavPage Insert(string Name, string ButtonText, string ButtonImageFile, int Index)
		{
			NavPage navPage = new NavPage();
			navPage.Name = Name;
			navPage.ButtonText = ButtonText;
			navPage.Button.Image = OO_00oOO.GetImage(ButtonImageFile);
			this.O__0_0Oo.Oo000..Insert(Index, navPage);
			return navPage;
		}

		/// <summary>
		/// 删除指定名称的页面
		/// </summary>
		/// <param name="Name">要删除的页面的名称</param>
		// Token: 0x06003F62 RID: 16226 RVA: 0x001D0C3C File Offset: 0x001CEE3C
		public void Delete(string Name)
		{
			NavPage navPage = (NavPage)this.O__0_0Oo.Oo000.[Name];
			navPage.ClearControl();
			this.O__0_0Oo.Oo000..Remove(navPage);
		}

		/// <summary>
		/// 删除指定位置的页面
		/// </summary>
		/// <param name="index"></param>
		// Token: 0x06003F63 RID: 16227 RVA: 0x001D0C70 File Offset: 0x001CEE70
		public void Delete(int index)
		{
			NavPage navPage = (NavPage)this.O__0_0Oo.Oo000.[index];
			navPage.ClearControl();
			this.O__0_0Oo.Oo000..Remove(navPage);
		}

		/// <summary>
		/// 删除所有页面
		/// </summary>
		// Token: 0x06003F64 RID: 16228 RVA: 0x001D0CA4 File Offset: 0x001CEEA4
		public void Clear()
		{
			try
			{
				foreach (object obj in this.O__0_0Oo.Oo000.)
				{
					((NavPage)obj).ClearControl();
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
			this.O__0_0Oo.Oo000..Clear();
		}

		// Token: 0x040019DB RID: 6619
		private C1NavBarPanel.PanelCollection <<EMPTY_NAME>>;
	}
}
