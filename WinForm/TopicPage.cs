using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 任务栏页面
	/// </summary>
	// Token: 0x020003D1 RID: 977
	[ComVisible(true)]
	public class TopicPage
	{
		// Token: 0x06003FC9 RID: 16329 RVA: 0x001D1997 File Offset: 0x001CFB97
		public TopicPage(C1TopicPage A_0)
		{
			this.o.OOoo. = A_0;
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06003FCA RID: 16330 RVA: 0x001D19A6 File Offset: 0x001CFBA6
		internal C1TopicPage BasePage
		{
			get
			{
				return this.o.OOoo.;
			}
		}

		/// <summary>
		/// 页面名称
		/// </summary>
		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06003FCB RID: 16331 RVA: 0x001D19AE File Offset: 0x001CFBAE
		// (set) Token: 0x06003FCC RID: 16332 RVA: 0x001D19C0 File Offset: 0x001CFBC0
		public string Name
		{
			get
			{
				return this.o.OOoo..Tag.ToString();
			}
			set
			{
				this.o.OOoo..Tag = value;
			}
		}

		/// <summary>
		/// 页面标题
		/// </summary>
		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06003FCD RID: 16333 RVA: 0x001D19CE File Offset: 0x001CFBCE
		// (set) Token: 0x06003FCE RID: 16334 RVA: 0x001D19DB File Offset: 0x001CFBDB
		public string Text
		{
			get
			{
				return this.o.OOoo..Text;
			}
			set
			{
				this.o.OOoo..Text = value;
			}
		}

		/// <summary>
		/// 页面提示
		/// </summary>
		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06003FCF RID: 16335 RVA: 0x001D19E9 File Offset: 0x001CFBE9
		// (set) Token: 0x06003FD0 RID: 16336 RVA: 0x001D19F6 File Offset: 0x001CFBF6
		public string ToolTip
		{
			get
			{
				return this.o.OOoo..ToolTipText;
			}
			set
			{
				this.o.OOoo..ToolTipText = value;
			}
		}

		/// <summary>
		/// 逻辑型，设为True，折叠页面，设为False，展开页面
		/// </summary>
		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06003FD1 RID: 16337 RVA: 0x001D1A04 File Offset: 0x001CFC04
		// (set) Token: 0x06003FD2 RID: 16338 RVA: 0x001D1A11 File Offset: 0x001CFC11
		public bool Collapsed
		{
			get
			{
				return this.o.OOoo..Collapsed;
			}
			set
			{
				this.o.OOoo..Collapsed = value;
			}
		}

		/// <summary>
		/// 逻辑型，默认设为True，设为False，将隐藏页面
		/// </summary>
		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06003FD3 RID: 16339 RVA: 0x001D1A1F File Offset: 0x001CFC1F
		// (set) Token: 0x06003FD4 RID: 16340 RVA: 0x001D1A2C File Offset: 0x001CFC2C
		public bool Visible
		{
			get
			{
				return this.o.OOoo..PageVisible;
			}
			set
			{
				this.o.OOoo..PageVisible = value;
			}
		}

		/// <summary>
		/// 返回或设置页面显示的图标文件，如果实现复制到项目文件的Images子目录下，则无需路径，否则必须包括路径
		/// </summary>
		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06003FD5 RID: 16341 RVA: 0x001D1A3A File Offset: 0x001CFC3A
		// (set) Token: 0x06003FD6 RID: 16342 RVA: 0x001D1A42 File Offset: 0x001CFC42
		public string ImageFile
		{
			get
			{
				return this.Image;
			}
			set
			{
				this.Image = value;
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06003FD7 RID: 16343 RVA: 0x001D1A4C File Offset: 0x001CFC4C
		// (set) Token: 0x06003FD8 RID: 16344 RVA: 0x001D1A94 File Offset: 0x001CFC94
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Image
		{
			get
			{
				string result;
				if (this.o.OOoo..ImageIndex >= 0)
				{
					result = this.o.OOoo..ImageList.Images.Keys[this.o.OOoo..ImageIndex];
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0)
				{
					this.o.OOoo..ImageIndex = -1;
					return;
				}
				if (this.o.OOoo..TopicBar.ImageList == null)
				{
					this.o.OOoo..TopicBar.ImageList = new ImageList();
				}
				if (this.o.OOoo..TopicBar.ImageList.Images.ContainsKey(value))
				{
					this.o.OOoo..ImageIndex = this.o.OOoo..TopicBar.ImageList.Images.IndexOfKey(value);
					return;
				}
				Image image = OO_00oOO.GetImage(value);
				if (image != null)
				{
					this.o.OOoo..TopicBar.ImageList.Images.Add(value, image);
				}
				this.o.OOoo..ImageIndex = this.o.OOoo..TopicBar.ImageList.Images.IndexOfKey(value);
			}
		}

		/// <summary>
		/// 此页面包含的命令集合
		/// </summary>
		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x001D1B73 File Offset: 0x001CFD73
		[oO0oooo("0853")]
		public TopicLinkCollection Links
		{
			get
			{
				if (this.a == null)
				{
					this.a = new TopicLinkCollection(this.o.OOoo..Links);
				}
				return this.a;
			}
		}

		// Token: 0x040019ED RID: 6637
		private C1TopicPage <<EMPTY_NAME>>;

		// Token: 0x040019EE RID: 6638
		private TopicLinkCollection a;
	}
}
