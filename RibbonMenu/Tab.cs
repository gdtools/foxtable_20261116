using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 功能区
	/// </summary>
	// Token: 0x0200001F RID: 31
	[ComVisible(true)]
	[oO0oooo("1085")]
	public class Tab
	{
		// Token: 0x060000FD RID: 253 RVA: 0x0000363E File Offset: 0x0000183E
		internal Tab(RibbonTab A_0)
		{
			this.OO0.0OOo__. = A_0;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000364D File Offset: 0x0000184D
		public Tab(string A_0)
		{
			this.OO0.0OOo__. = new RibbonTab();
			this.OO0.0OOo__..ID = A_0;
		}

		/// <summary>
		/// 名称
		/// </summary>
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000366C File Offset: 0x0000186C
		public string Name
		{
			get
			{
				return this.OO0.0OOo__..ID;
			}
		}

		/// <summary>
		/// 标题
		/// </summary>
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00003679 File Offset: 0x00001879
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00003686 File Offset: 0x00001886
		public string Text
		{
			get
			{
				return this.OO0.0OOo__..Text;
			}
			set
			{
				this.OO0.0OOo__..Text = value;
			}
		}

		/// <summary>
		/// 是否可用
		/// </summary>
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00003694 File Offset: 0x00001894
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000036A1 File Offset: 0x000018A1
		public bool Enabled
		{
			get
			{
				return this.OO0.0OOo__..Enabled;
			}
			set
			{
				this.OO0.0OOo__..Enabled = value;
			}
		}

		/// <summary>
		/// 图标
		/// </summary>
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000036AF File Offset: 0x000018AF
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000036BC File Offset: 0x000018BC
		public Image Image
		{
			get
			{
				return this.OO0.0OOo__..Image;
			}
			set
			{
				this.OO0.0OOo__..Image = value;
			}
		}

		/// <summary>
		/// 提示信息
		/// </summary>
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000036CA File Offset: 0x000018CA
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000036D7 File Offset: 0x000018D7
		public string ToolTip
		{
			get
			{
				return this.OO0.0OOo__..ToolTip;
			}
			set
			{
				this.OO0.0OOo__..ToolTip = value;
			}
		}

		/// <summary>
		/// 是否可见
		/// </summary>
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000036E5 File Offset: 0x000018E5
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000036F2 File Offset: 0x000018F2
		public bool Visible
		{
			get
			{
				return this.OO0.0OOo__..Visible;
			}
			set
			{
				this.OO0.0OOo__..Visible = value;
			}
		}

		/// <summary>
		/// 返回或设置此功能区是否为选定功能区
		/// </summary>
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00003700 File Offset: 0x00001900
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000370D File Offset: 0x0000190D
		public bool Selected
		{
			get
			{
				return this.OO0.0OOo__..Selected;
			}
			set
			{
				this.OO0.0OOo__..Selected = true;
			}
		}

		// Token: 0x17000079 RID: 121
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Group this[string Name]
		{
			get
			{
				return this.Groups[Name];
			}
		}

		/// <summary>
		/// 集合， 可获得功能区中指定名称的功能组
		/// </summary>
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00003729 File Offset: 0x00001929
		public RibbonGroupCollection Groups
		{
			get
			{
				if (this.OO0.0OOo__. == null)
				{
					this.OO0.0OOo__. = new RibbonGroupCollection(this.OO0.0OOo__..Groups);
				}
				return this.OO0.0OOo__.;
			}
		}

		// Token: 0x0400002E RID: 46
		internal RibbonTab <<EMPTY_NAME>>;

		// Token: 0x0400002F RID: 47
		private RibbonGroupCollection <<EMPTY_NAME>>;
	}
}
