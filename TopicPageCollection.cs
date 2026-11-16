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
	// Token: 0x020003D0 RID: 976
	[oO0oooo("0841")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class TopicPageCollection : IEnumerable<TopicPage>
	{
		// Token: 0x06003FBC RID: 16316 RVA: 0x001D1800 File Offset: 0x001CFA00
		public TopicPageCollection(C1TopicBar A_0)
		{
			this.O._oooo0__. = A_0;
			this.O._oooo0__. = A_0.Pages;
		}

		// Token: 0x17000D6F RID: 3439
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TopicPage this[int Index]
		{
			get
			{
				return new TopicPage(this.O._oooo0__.[Index]);
			}
		}

		// Token: 0x17000D70 RID: 3440
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TopicPage this[string Name]
		{
			get
			{
				try
				{
					foreach (object obj in this.O._oooo0__.)
					{
						C1TopicPage c1TopicPage = (C1TopicPage)obj;
						if (Operators.CompareString(c1TopicPage.Tag.ToString(), Name, true) == 0)
						{
							return new TopicPage(c1TopicPage);
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
				return null;
			}
		}

		/// <summary>
		/// 页面数量
		/// </summary>
		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06003FBF RID: 16319 RVA: 0x001D18A8 File Offset: 0x001CFAA8
		public int Count
		{
			get
			{
				return this.O._oooo0__..Count;
			}
		}

		/// <summary>
		/// 删除所有页面
		/// </summary>
		// Token: 0x06003FC0 RID: 16320 RVA: 0x001D18B5 File Offset: 0x001CFAB5
		public void Clear()
		{
			this.O._oooo0__..Clear();
		}

		/// <summary>
		/// 增加页面
		/// </summary>
		/// <param name="Name">页面名称</param>
		/// <param name="Text">页面标题</param>
		// Token: 0x06003FC1 RID: 16321 RVA: 0x001D18C2 File Offset: 0x001CFAC2
		[oO0oooo("0842")]
		public TopicPage Add(string Name, string Text)
		{
			return this.Add(Name, Text, "");
		}

		/// <summary>
		/// 增加页面
		/// </summary>
		/// <param name="Name">页面名称</param>
		/// <param name="Text">页面标题</param>
		/// <param name="ImageFile">页面显示的图标文件</param>
		// Token: 0x06003FC2 RID: 16322 RVA: 0x001D18D4 File Offset: 0x001CFAD4
		[oO0oooo("0842")]
		public TopicPage Add(string Name, string Text, string ImageFile)
		{
			C1TopicPage c1TopicPage = new C1TopicPage();
			TopicPage topicPage = new TopicPage(c1TopicPage);
			this.O._oooo0__..Add(c1TopicPage);
			topicPage.Text = Text;
			topicPage.Name = Name;
			topicPage.Image = ImageFile;
			return topicPage;
		}

		/// <summary>
		/// 插入页面
		/// </summary>
		/// <param name="Name">页面名称</param>
		/// <param name="Text">页面标题</param>
		/// <param name="Index">插入位置</param>
		// Token: 0x06003FC3 RID: 16323 RVA: 0x001D190F File Offset: 0x001CFB0F
		[oO0oooo("0843")]
		public TopicPage Insert(string Name, string Text, int Index)
		{
			return this.Insert(Name, Text, "", Index);
		}

		/// <summary>
		/// 插入页面
		/// </summary>
		/// <param name="Name">页面名称</param>
		/// <param name="Text">页面标题</param>
		/// <param name="Index">插入位置</param>
		/// <param name="ImageFile">页面显示的图标文件</param>
		// Token: 0x06003FC4 RID: 16324 RVA: 0x001D1920 File Offset: 0x001CFB20
		[oO0oooo("0843")]
		public TopicPage Insert(string Name, string Text, string ImageFile, int Index)
		{
			C1TopicPage c1TopicPage = new C1TopicPage();
			TopicPage topicPage = new TopicPage(c1TopicPage);
			this.O._oooo0__..Insert(Index, c1TopicPage);
			topicPage.Text = Text;
			topicPage.Name = Name;
			topicPage.Image = ImageFile;
			return topicPage;
		}

		/// <summary>
		/// 删除指定位置的页面
		/// </summary>
		/// <param name="Index">页面显示的图标文件</param>
		// Token: 0x06003FC5 RID: 16325 RVA: 0x001D195C File Offset: 0x001CFB5C
		[oO0oooo("0845")]
		public void RemoveAt(int Index)
		{
			this.O._oooo0__..RemoveAt(Index);
		}

		/// <summary>
		/// 删除页面
		/// </summary>
		/// <param name="Page">要删除的页面</param>
		// Token: 0x06003FC6 RID: 16326 RVA: 0x001D196A File Offset: 0x001CFB6A
		[oO0oooo("0844")]
		public void Remove(TopicPage Page)
		{
			this.O._oooo0__..Remove(Page.BasePage);
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x001D197D File Offset: 0x001CFB7D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<TopicPage> GetEnumerator()
		{
			return new OO___(this.O._oooo0__.);
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x001D198A File Offset: 0x001CFB8A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return new OO___(this.O._oooo0__.);
		}

		// Token: 0x040019EB RID: 6635
		private C1TopicPageCollection <<EMPTY_NAME>>;

		// Token: 0x040019EC RID: 6636
		private C1TopicBar <<EMPTY_NAME>>;
	}
}
