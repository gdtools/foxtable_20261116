using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	// Token: 0x0200001C RID: 28
	[ComVisible(true)]
	public class GalleryItem
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x000033BA File Offset: 0x000015BA
		public GalleryItem(RibbonGalleryItem A_0)
		{
			this.OO0oOo.O_o0. = A_0;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000033C9 File Offset: 0x000015C9
		public GalleryItem(string A_0)
		{
			this.OO0oOo.O_o0. = new RibbonGalleryItem();
			this.OO0oOo.O_o0..ID = A_0;
		}

		/// <summary>
		/// 组件名称
		/// </summary>
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000033E8 File Offset: 0x000015E8
		public string Name
		{
			get
			{
				return this.OO0oOo.O_o0..ID;
			}
		}

		/// <summary>
		/// 返回组件标题
		/// </summary>
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000033F5 File Offset: 0x000015F5
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00003402 File Offset: 0x00001602
		public string Text
		{
			get
			{
				return this.OO0oOo.O_o0..Text;
			}
			set
			{
				this.OO0oOo.O_o0..Text = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00003410 File Offset: 0x00001610
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000341D File Offset: 0x0000161D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Color ForeColor
		{
			get
			{
				return this.OO0oOo.O_o0..ForeColorInner;
			}
			set
			{
				this.OO0oOo.O_o0..ForeColorInner = value;
				this.OO0oOo.O_o0..ForeColorOuter = value;
			}
		}

		/// <summary>
		/// 组件的附加信息
		/// </summary>
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00003437 File Offset: 0x00001637
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00003444 File Offset: 0x00001644
		public string UserData
		{
			get
			{
				return this.OO0oOo.O_o0..Description;
			}
			set
			{
				this.OO0oOo.O_o0..Description = value;
			}
		}

		/// <summary>
		/// 组件是否可用
		/// </summary>
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00003452 File Offset: 0x00001652
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000345F File Offset: 0x0000165F
		public virtual bool Enabled
		{
			get
			{
				return this.OO0oOo.O_o0..Enabled;
			}
			set
			{
				this.OO0oOo.O_o0..Enabled = value;
			}
		}

		/// <summary>
		/// 组件的提示信息
		/// </summary>
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000346D File Offset: 0x0000166D
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000347A File Offset: 0x0000167A
		public string ToolTip
		{
			get
			{
				return this.OO0oOo.O_o0..ToolTip;
			}
			set
			{
				this.OO0oOo.O_o0..ToolTip = value;
			}
		}

		/// <summary>
		/// 组件的图标
		/// </summary>
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00003488 File Offset: 0x00001688
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00003495 File Offset: 0x00001695
		public Image Image
		{
			get
			{
				return this.OO0oOo.O_o0..LargeImage;
			}
			set
			{
				this.OO0oOo.O_o0..LargeImage = value;
			}
		}

		/// <summary>
		/// 组件是否可见
		/// </summary>
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000034A3 File Offset: 0x000016A3
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000034B0 File Offset: 0x000016B0
		public virtual bool Visible
		{
			get
			{
				return this.OO0oOo.O_o0..Visible;
			}
			set
			{
				this.OO0oOo.O_o0..Visible = value;
			}
		}

		// Token: 0x04000029 RID: 41
		internal RibbonGalleryItem <<EMPTY_NAME>>;
	}
}
