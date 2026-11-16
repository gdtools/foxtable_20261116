using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Foxtable.WinForm
{
	// Token: 0x0200017B RID: 379
	[ComVisible(true)]
	[oO0oooo("3119")]
	public class Strip
	{
		// Token: 0x0600121B RID: 4635 RVA: 0x00080488 File Offset: 0x0007E688
		internal Strip(ToolStrip A_0, Form A_1)
		{
			this.oO.ooo. = A_0;
			this.oO.ooo. = A_1;
			this.oO.ooo. = new StripItemCollection(A_0.Items, this.oO.ooo.);
		}

		/// <summary>
		/// 菜单名称
		/// </summary>
		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x000804B5 File Offset: 0x0007E6B5
		public string Name
		{
			get
			{
				return this.oO.ooo..Name;
			}
		}

		/// <summary>
		/// 是否可见
		/// </summary>
		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x000804C2 File Offset: 0x0007E6C2
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x000804CF File Offset: 0x0007E6CF
		public bool Visible
		{
			get
			{
				return this.oO.ooo..Visible;
			}
			set
			{
				this.oO.ooo..Visible = value;
			}
		}

		/// <summary>
		/// 是否可用
		/// </summary>
		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x000804DD File Offset: 0x0007E6DD
		// (set) Token: 0x06001220 RID: 4640 RVA: 0x000804EA File Offset: 0x0007E6EA
		public bool Enabled
		{
			get
			{
				return this.oO.ooo..Enabled;
			}
			set
			{
				this.oO.ooo..Enabled = value;
			}
		}

		/// <summary>
		/// 一个集合，包括此菜单的所有菜单项目。
		/// </summary>
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x000804F8 File Offset: 0x0007E6F8
		public StripItemCollection Items
		{
			get
			{
				return this.oO.ooo.;
			}
		}

		/// <summary>
		/// 停止绘制菜单
		/// </summary>
		// Token: 0x06001222 RID: 4642 RVA: 0x00080500 File Offset: 0x0007E700
		public void StopRedraw()
		{
			this.oO.ooo..SuspendLayout();
		}

		/// <summary>
		/// 恢复绘制菜单
		/// </summary>
		// Token: 0x06001223 RID: 4643 RVA: 0x0008050D File Offset: 0x0007E70D
		public void ResumeRedraw()
		{
			this.oO.ooo..ResumeLayout();
		}

		/// <summary>
		/// 返回底层控件
		/// </summary>
		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x0008051A File Offset: 0x0007E71A
		public object BaseControl
		{
			get
			{
				return this.oO.ooo.;
			}
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00080522 File Offset: 0x0007E722
		public void Show()
		{
			if (this.BaseControl is ContextMenuStrip)
			{
				((ContextMenuStrip)this.BaseControl).Show(Cursor.Position);
			}
		}

		/// <summary>
		/// 关闭菜单，仅对快捷菜单有效
		/// </summary>
		// Token: 0x06001226 RID: 4646 RVA: 0x00080548 File Offset: 0x0007E748
		public void Close()
		{
			if (this.oO.ooo. is ContextMenuStrip)
			{
				((ContextMenuStrip)this.oO.ooo.).Close();
			}
		}

		/// <summary>
		/// 菜单样式
		/// </summary>
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x00080567 File Offset: 0x0007E767
		// (set) Token: 0x06001228 RID: 4648 RVA: 0x00080579 File Offset: 0x0007E779
		[oO0oooo("3305")]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.oO.ooo.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.oO.ooo.
				});
			}
		}

		// Token: 0x040006EE RID: 1774
		private ToolStrip <<EMPTY_NAME>>;

		// Token: 0x040006EF RID: 1775
		private StripItemCollection <<EMPTY_NAME>>;

		// Token: 0x040006F0 RID: 1776
		internal Form <<EMPTY_NAME>>;
	}
}
