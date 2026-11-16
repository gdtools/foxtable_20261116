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
	/// 任务栏命令
	/// </summary>
	// Token: 0x020003CE RID: 974
	[ComVisible(true)]
	public class TopicLink
	{
		// Token: 0x06003FA5 RID: 16293 RVA: 0x001D152F File Offset: 0x001CF72F
		public TopicLink(C1TopicLink A_0)
		{
			this.o.OOoo. = A_0;
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06003FA6 RID: 16294 RVA: 0x001D153E File Offset: 0x001CF73E
		internal C1TopicLink BaseLink
		{
			get
			{
				return this.o.OOoo.;
			}
		}

		/// <summary>
		/// 任务名称
		/// </summary>
		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06003FA7 RID: 16295 RVA: 0x001D1546 File Offset: 0x001CF746
		// (set) Token: 0x06003FA8 RID: 16296 RVA: 0x001D1558 File Offset: 0x001CF758
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
		/// 任务标题
		/// </summary>
		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06003FA9 RID: 16297 RVA: 0x001D1566 File Offset: 0x001CF766
		// (set) Token: 0x06003FAA RID: 16298 RVA: 0x001D1573 File Offset: 0x001CF773
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
		/// 任务提示
		/// </summary>
		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06003FAB RID: 16299 RVA: 0x001D1581 File Offset: 0x001CF781
		// (set) Token: 0x06003FAC RID: 16300 RVA: 0x001D158E File Offset: 0x001CF78E
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
		/// 逻辑型，默认设为True，设为False，将隐藏任务
		/// </summary>
		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06003FAD RID: 16301 RVA: 0x001D159C File Offset: 0x001CF79C
		// (set) Token: 0x06003FAE RID: 16302 RVA: 0x001D15A9 File Offset: 0x001CF7A9
		public bool Visible
		{
			get
			{
				return this.o.OOoo..Visible;
			}
			set
			{
				this.o.OOoo..Visible = value;
			}
		}

		/// <summary>
		/// 逻辑型，设置为False,将禁用任务
		/// </summary>
		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06003FAF RID: 16303 RVA: 0x001D15B7 File Offset: 0x001CF7B7
		// (set) Token: 0x06003FB0 RID: 16304 RVA: 0x001D15C4 File Offset: 0x001CF7C4
		public bool Enabled
		{
			get
			{
				return this.o.OOoo..Enabled;
			}
			set
			{
				this.o.OOoo..Enabled = value;
			}
		}

		/// <summary>
		/// 返回或设置任务显示的图标文件，如果事先复制到项目文件的Images子目录下，则无需路径，否则必须包括路径
		/// </summary>
		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06003FB1 RID: 16305 RVA: 0x001D15D2 File Offset: 0x001CF7D2
		// (set) Token: 0x06003FB2 RID: 16306 RVA: 0x001D15DA File Offset: 0x001CF7DA
		[oO0oooo("0859")]
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

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06003FB3 RID: 16307 RVA: 0x001D15E4 File Offset: 0x001CF7E4
		// (set) Token: 0x06003FB4 RID: 16308 RVA: 0x001D1630 File Offset: 0x001CF830
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Image
		{
			get
			{
				string result;
				if (this.o.OOoo..ImageIndex >= 0)
				{
					result = this.o.OOoo..TopicPage.ImageList.Images.Keys[this.o.OOoo..ImageIndex];
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
				if (this.o.OOoo..TopicPage.ImageList == null)
				{
					if (this.o.OOoo..TopicPage.TopicBar.ImageList == null)
					{
						this.o.OOoo..TopicPage.TopicBar.ImageList = new ImageList();
					}
					this.o.OOoo..TopicPage.ImageList = this.o.OOoo..TopicPage.TopicBar.ImageList;
				}
				if (this.o.OOoo..TopicPage.ImageList.Images.ContainsKey(value))
				{
					this.o.OOoo..ImageIndex = this.o.OOoo..TopicPage.ImageList.Images.IndexOfKey(value);
					return;
				}
				Image image = OO_00oOO.GetImage(value);
				if (image != null)
				{
					this.o.OOoo..TopicPage.ImageList.Images.Add(value, image);
				}
				this.o.OOoo..ImageIndex = this.o.OOoo..TopicPage.ImageList.Images.IndexOfKey(value);
			}
		}

		// Token: 0x040019E7 RID: 6631
		private C1TopicLink <<EMPTY_NAME>>;
	}
}
