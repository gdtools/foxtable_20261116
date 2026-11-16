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
	// Token: 0x020003CD RID: 973
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class TopicLinkCollection : IEnumerable<TopicLink>
	{
		// Token: 0x06003F98 RID: 16280 RVA: 0x001D13A4 File Offset: 0x001CF5A4
		public TopicLinkCollection(C1TopicLinkCollection A_0)
		{
			this.O._oooo0__. = A_0;
		}

		// Token: 0x17000D64 RID: 3428
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TopicLink this[int Index]
		{
			get
			{
				return new TopicLink(this.O._oooo0__.[Index]);
			}
		}

		// Token: 0x17000D65 RID: 3429
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TopicLink this[string Name]
		{
			get
			{
				try
				{
					foreach (object obj in this.O._oooo0__.)
					{
						C1TopicLink c1TopicLink = (C1TopicLink)obj;
						if (Operators.CompareString(c1TopicLink.Tag.ToString(), Name, true) == 0)
						{
							return new TopicLink(c1TopicLink);
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
		/// 命令数量
		/// </summary>
		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06003F9B RID: 16283 RVA: 0x001D1440 File Offset: 0x001CF640
		public int Count
		{
			get
			{
				return this.O._oooo0__..Count;
			}
		}

		/// <summary>
		/// 删除所有命令
		/// </summary>
		// Token: 0x06003F9C RID: 16284 RVA: 0x001D144D File Offset: 0x001CF64D
		public void Clear()
		{
			this.O._oooo0__..Clear();
		}

		/// <summary>
		/// 增加命令
		/// </summary>
		/// <param name="Name">命令名称</param>
		/// <param name="Text">命令标题</param>
		// Token: 0x06003F9D RID: 16285 RVA: 0x001D145A File Offset: 0x001CF65A
		[oO0oooo("0860")]
		public TopicLink Add(string Name, string Text)
		{
			return this.Add(Name, Text, "");
		}

		/// <summary>
		/// 增加命令
		/// </summary>
		/// <param name="Name">命令名称</param>
		/// <param name="Text">命令标题</param>
		/// <param name="ImageFile">任务显示的图标文件，如果事先复制到项目文件的Images子目录下，则无需路径，否则必须包括路径</param>
		// Token: 0x06003F9E RID: 16286 RVA: 0x001D146C File Offset: 0x001CF66C
		[oO0oooo("0860")]
		public TopicLink Add(string Name, string Text, string ImageFile)
		{
			C1TopicLink c1TopicLink = new C1TopicLink();
			TopicLink topicLink = new TopicLink(c1TopicLink);
			this.O._oooo0__..Add(c1TopicLink);
			topicLink.Text = Text;
			topicLink.Name = Name;
			topicLink.Image = ImageFile;
			return topicLink;
		}

		/// <summary>
		/// 插入命令
		/// </summary>
		/// <param name="Name">命令名称</param>
		/// <param name="Text">命令标题</param>
		/// <param name="Index">插入位置</param>
		// Token: 0x06003F9F RID: 16287 RVA: 0x001D14A7 File Offset: 0x001CF6A7
		[oO0oooo("0861")]
		public TopicLink Insert(string Name, string Text, int Index)
		{
			return this.Insert(Name, Text, "", Index);
		}

		/// <summary>
		/// 插入命令
		/// </summary>
		/// <param name="Name">命令名称</param>
		/// <param name="Text">命令标题</param>
		/// <param name="ImageFile">任务显示的图标文件，如果事先复制到项目文件的Images子目录下，则无需路径，否则必须包括路径</param>
		/// <param name="Index">插入位置</param>
		// Token: 0x06003FA0 RID: 16288 RVA: 0x001D14B8 File Offset: 0x001CF6B8
		[oO0oooo("0861")]
		public TopicLink Insert(string Name, string Text, string ImageFile, int Index)
		{
			C1TopicLink c1TopicLink = new C1TopicLink();
			TopicLink topicLink = new TopicLink(c1TopicLink);
			this.O._oooo0__..Insert(Index, c1TopicLink);
			topicLink.Text = Text;
			topicLink.Name = Name;
			topicLink.Image = ImageFile;
			return topicLink;
		}

		/// <summary>
		/// 删除指定位置的命令
		/// </summary>
		/// <param name="Index">要删除命令的位置</param>
		// Token: 0x06003FA1 RID: 16289 RVA: 0x001D14F4 File Offset: 0x001CF6F4
		[oO0oooo("0868")]
		public void RemoveAt(int Index)
		{
			this.O._oooo0__..RemoveAt(Index);
		}

		/// <summary>
		/// 删除命令
		/// </summary>
		/// <param name="Link">要删除的命令</param>
		// Token: 0x06003FA2 RID: 16290 RVA: 0x001D1502 File Offset: 0x001CF702
		[oO0oooo("0866")]
		public void Remove(TopicLink Link)
		{
			this.O._oooo0__..Remove(Link.BaseLink);
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x001D1515 File Offset: 0x001CF715
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<TopicLink> GetEnumerator()
		{
			return new OoOoOO0O_O_o(this.O._oooo0__.);
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x001D1522 File Offset: 0x001CF722
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return new OoOoOO0O_O_o(this.O._oooo0__.);
		}

		// Token: 0x040019E6 RID: 6630
		private C1TopicLinkCollection <<EMPTY_NAME>>;
	}
}
