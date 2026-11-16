using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1Command;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 导航栏
	/// </summary>
	// Token: 0x0200052E RID: 1326
	[oO0oooo("0872")]
	[ComVisible(true)]
	public class NavBar : Control
	{
		// Token: 0x06005855 RID: 22613 RVA: 0x0025E945 File Offset: 0x0025CB45
		internal NavBar(O_OOO A_0) : base(A_0, ControlTypeEnum.NavBar)
		{
			this.o.oO_oo_O. = A_0;
		}

		/// <summary>
		/// 按钮字体
		/// </summary>
		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06005856 RID: 22614 RVA: 0x0025E957 File Offset: 0x0025CB57
		// (set) Token: 0x06005857 RID: 22615 RVA: 0x0025E964 File Offset: 0x0025CB64
		public Font ButtonFont
		{
			get
			{
				return this.o.oO_oo_O..ButtonFont;
			}
			set
			{
				this.o.oO_oo_O..ButtonFont = value;
			}
		}

		/// <summary>
		/// 按钮高度
		/// </summary>
		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06005858 RID: 22616 RVA: 0x0025E972 File Offset: 0x0025CB72
		// (set) Token: 0x06005859 RID: 22617 RVA: 0x0025E97F File Offset: 0x0025CB7F
		public int ButtonHeight
		{
			get
			{
				return this.o.oO_oo_O..ButtonHeight;
			}
			set
			{
				this.o.oO_oo_O..ButtonHeight = value;
			}
		}

		/// <summary>
		/// 按钮图标大小
		/// </summary>
		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x0600585A RID: 22618 RVA: 0x0025E98D File Offset: 0x0025CB8D
		// (set) Token: 0x0600585B RID: 22619 RVA: 0x0025E99A File Offset: 0x0025CB9A
		public Size ButtonImageSize
		{
			get
			{
				return this.o.oO_oo_O..ImageScalingSize;
			}
			set
			{
				this.o.oO_oo_O..ImageScalingSize = value;
			}
		}

		/// <summary>
		/// 标题字体
		/// </summary>
		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x0600585C RID: 22620 RVA: 0x0025E9A8 File Offset: 0x0025CBA8
		// (set) Token: 0x0600585D RID: 22621 RVA: 0x0025E9B5 File Offset: 0x0025CBB5
		public Font HeaderFont
		{
			get
			{
				return this.o.oO_oo_O..PanelHeaderFont;
			}
			set
			{
				this.o.oO_oo_O..PanelHeaderFont = value;
			}
		}

		/// <summary>
		/// 标题高度
		/// </summary>
		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x0600585E RID: 22622 RVA: 0x0025E9C3 File Offset: 0x0025CBC3
		// (set) Token: 0x0600585F RID: 22623 RVA: 0x0025E9D0 File Offset: 0x0025CBD0
		public int HeaderHeight
		{
			get
			{
				return this.o.oO_oo_O..PanelHeaderHeight;
			}
			set
			{
				this.o.oO_oo_O..PanelHeaderHeight = value;
			}
		}

		/// <summary>
		/// 显示按钮数
		/// </summary>
		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06005860 RID: 22624 RVA: 0x0025E9DE File Offset: 0x0025CBDE
		// (set) Token: 0x06005861 RID: 22625 RVA: 0x0025E9EB File Offset: 0x0025CBEB
		public int StackButtonCount
		{
			get
			{
				return this.o.oO_oo_O..StackButtonCount;
			}
			set
			{
				this.o.oO_oo_O..StackButtonCount = value;
			}
		}

		/// <summary>
		/// 水平栏高度
		/// </summary>
		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06005862 RID: 22626 RVA: 0x0025E9F9 File Offset: 0x0025CBF9
		// (set) Token: 0x06005863 RID: 22627 RVA: 0x0025EA06 File Offset: 0x0025CC06
		public int StripHeight
		{
			get
			{
				return this.o.oO_oo_O..StripHeight;
			}
			set
			{
				this.o.oO_oo_O..StripHeight = value;
			}
		}

		// Token: 0x1700147B RID: 5243
		// (set) Token: 0x06005864 RID: 22628 RVA: 0x0025EA14 File Offset: 0x0025CC14
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Panels
		{
			set
			{
				string[] array = value.Split(new char[]
				{
					'\f'
				});
				this.o.oO_oo_O..Panels.Clear();
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					NavPage navPage = new NavPage();
					this.o.oO_oo_O..Panels.Add(navPage);
					o_O_o_oOoo__.OOOO_OO._oo.(navPage, array[i], '\t');
				}
			}
		}

		/// <summary>
		/// 返回或者设置导航栏选定页面的位置
		/// </summary>
		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06005865 RID: 22629 RVA: 0x0025EA78 File Offset: 0x0025CC78
		// (set) Token: 0x06005866 RID: 22630 RVA: 0x0025EA85 File Offset: 0x0025CC85
		[oO0oooo("0874")]
		public int SelectedIndex
		{
			get
			{
				return this.o.oO_oo_O..SelectedButtonIndex;
			}
			set
			{
				this.o.oO_oo_O..SelectedButtonIndex = value;
			}
		}

		/// <summary>
		/// 返回或者设置导航栏选定的页面
		/// </summary>
		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06005867 RID: 22631 RVA: 0x0025EA93 File Offset: 0x0025CC93
		// (set) Token: 0x06005868 RID: 22632 RVA: 0x0025EAA5 File Offset: 0x0025CCA5
		[oO0oooo("0875")]
		public NavPage SelectedPage
		{
			get
			{
				return (NavPage)this.o.oO_oo_O..SelectedPanel;
			}
			set
			{
				this.o.oO_oo_O..SelectedButton = value.Button;
			}
		}

		/// <summary>
		/// 页面集合
		/// </summary>
		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06005869 RID: 22633 RVA: 0x0025EAB8 File Offset: 0x0025CCB8
		[oO0oooo("0873")]
		public NavPageCollection NavPages
		{
			get
			{
				return new NavPageCollection(this.o.oO_oo_O..Panels);
			}
		}

		/// <summary>
		/// 样式
		/// </summary>
		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x0600586A RID: 22634 RVA: 0x0025EACC File Offset: 0x0025CCCC
		// (set) Token: 0x0600586B RID: 22635 RVA: 0x0025EADA File Offset: 0x0025CCDA
		public VisualStyle VisualStyle
		{
			get
			{
				VisualStyle result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x04002308 RID: 8968
		private O_OOO <<EMPTY_NAME>>;
	}
}
