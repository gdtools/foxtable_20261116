using System;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1Command;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 快捷菜单命令
	/// </summary>
	// Token: 0x02000028 RID: 40
	[ComVisible(true)]
	public class ContextCommand
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00003B45 File Offset: 0x00001D45
		public ContextCommand(C1CommandLink A_0)
		{
			this.oo0OOOO_._. = A_0;
			this.oo0OOOO_._. = A_0.Command;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00003B60 File Offset: 0x00001D60
		public ContextCommand(C1Command A_0)
		{
			this.oo0OOOO_._. = A_0;
		}

		/// <summary>
		/// 名称
		/// </summary>
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00003B6F File Offset: 0x00001D6F
		public string Name
		{
			get
			{
				return this.oo0OOOO_._..Name;
			}
		}

		/// <summary>
		/// 标题
		/// </summary>
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00003B7C File Offset: 0x00001D7C
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00003B89 File Offset: 0x00001D89
		public string Text
		{
			get
			{
				return this.oo0OOOO_._..Text;
			}
			set
			{
				this.oo0OOOO_._..Text = value;
			}
		}

		/// <summary>
		/// 提示
		/// </summary>
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00003B97 File Offset: 0x00001D97
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00003BA4 File Offset: 0x00001DA4
		public string ToolTip
		{
			get
			{
				return this.oo0OOOO_._..ToolTipText;
			}
			set
			{
				this.oo0OOOO_._..ToolTipText = value;
			}
		}

		/// <summary>
		/// 是否可用
		/// </summary>
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00003BB2 File Offset: 0x00001DB2
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00003BBF File Offset: 0x00001DBF
		public bool Enabled
		{
			get
			{
				return this.oo0OOOO_._..Enabled;
			}
			set
			{
				this.oo0OOOO_._..Enabled = value;
			}
		}

		/// <summary>
		/// 图标
		/// </summary>
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00003BCD File Offset: 0x00001DCD
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00003BDA File Offset: 0x00001DDA
		public Image Image
		{
			get
			{
				return this.oo0OOOO_._..Image;
			}
			set
			{
				this.oo0OOOO_._..Image = value;
			}
		}

		/// <summary>
		/// 是否可见
		/// </summary>
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00003BE8 File Offset: 0x00001DE8
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00003BF5 File Offset: 0x00001DF5
		public bool Visible
		{
			get
			{
				return this.oo0OOOO_._..Visible;
			}
			set
			{
				this.oo0OOOO_._..Visible = value;
			}
		}

		/// <summary>
		/// 是否在命令左边显示一个选中标记
		/// </summary>
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00003C03 File Offset: 0x00001E03
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00003C10 File Offset: 0x00001E10
		public bool Checked
		{
			get
			{
				return this.oo0OOOO_._..Checked;
			}
			set
			{
				this.oo0OOOO_._..Checked = value;
			}
		}

		/// <summary>
		/// 是否可以自动切换其选中标记
		/// </summary>
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00003C1E File Offset: 0x00001E1E
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00003C2B File Offset: 0x00001E2B
		public bool CheckAutoToggle
		{
			get
			{
				return this.oo0OOOO_._..CheckAutoToggle;
			}
			set
			{
				this.oo0OOOO_._..CheckAutoToggle = value;
			}
		}

		/// <summary>
		/// 是否在该命令前显示一条分割线
		/// </summary>
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00003C3C File Offset: 0x00001E3C
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00003C5E File Offset: 0x00001E5E
		public bool Delimiter
		{
			get
			{
				bool delimiter;
				if (this.oo0OOOO_._. != null)
				{
					delimiter = this.oo0OOOO_._..Delimiter;
				}
				return delimiter;
			}
			set
			{
				if (this.oo0OOOO_._. != null)
				{
					this.oo0OOOO_._..Delimiter = value;
				}
			}
		}

		// Token: 0x04000041 RID: 65
		internal C1CommandLink <<EMPTY_NAME>>;

		// Token: 0x04000042 RID: 66
		private C1Command <<EMPTY_NAME>>;
	}
}
