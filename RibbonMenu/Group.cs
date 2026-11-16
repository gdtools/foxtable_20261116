using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 功能组
	/// </summary>
	// Token: 0x0200001E RID: 30
	[ComVisible(true)]
	[oO0oooo("1088")]
	public class Group
	{
		// Token: 0x060000EC RID: 236 RVA: 0x0000352D File Offset: 0x0000172D
		internal Group(RibbonGroup A_0)
		{
			this.OO0oOo.O_o0. = A_0;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000353C File Offset: 0x0000173C
		public Group(string A_0)
		{
			this.OO0oOo.O_o0. = new RibbonGroup();
			this.OO0oOo.O_o0..ID = A_0;
		}

		/// <summary>
		/// 名称
		/// </summary>
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000355B File Offset: 0x0000175B
		public string Name
		{
			get
			{
				return this.OO0oOo.O_o0..ID;
			}
		}

		/// <summary>
		/// 标题
		/// </summary>
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00003568 File Offset: 0x00001768
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00003575 File Offset: 0x00001775
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

		/// <summary>
		/// 是否可用
		/// </summary>
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00003583 File Offset: 0x00001783
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00003590 File Offset: 0x00001790
		public bool Enabled
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
		/// 图标
		/// </summary>
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000359E File Offset: 0x0000179E
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000035AB File Offset: 0x000017AB
		public Image Image
		{
			get
			{
				return this.OO0oOo.O_o0..Image;
			}
			set
			{
				this.OO0oOo.O_o0..Image = value;
			}
		}

		/// <summary>
		/// 提示信息
		/// </summary>
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000035B9 File Offset: 0x000017B9
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000035C6 File Offset: 0x000017C6
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
		/// 是否可见
		/// </summary>
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000035D4 File Offset: 0x000017D4
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000035E1 File Offset: 0x000017E1
		public bool Visible
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

		// Token: 0x1700006F RID: 111
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[string Name]
		{
			get
			{
				return this.Items[Name];
			}
		}

		/// <summary>
		/// 一个集合，包括功能组的所有项目
		/// </summary>
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000035FD File Offset: 0x000017FD
		public RibbonItemCollection Items
		{
			get
			{
				if (this.OO0oOo.O_o0. == null)
				{
					this.OO0oOo.O_o0. = new RibbonItemCollection(this.OO0oOo.O_o0..Items);
				}
				return this.OO0oOo.O_o0.;
			}
		}

		/// <summary>
		/// 是否显示对话按钮
		/// </summary>
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00003623 File Offset: 0x00001823
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00003630 File Offset: 0x00001830
		public bool HasLauncherButton
		{
			get
			{
				return this.OO0oOo.O_o0..HasLauncherButton;
			}
			set
			{
				this.OO0oOo.O_o0..HasLauncherButton = value;
			}
		}

		// Token: 0x0400002C RID: 44
		internal RibbonGroup <<EMPTY_NAME>>;

		// Token: 0x0400002D RID: 45
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}
