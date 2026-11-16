using System;
using System.ComponentModel;
using Foxtable.RibbonMenu;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020002FC RID: 764
	[oO0oooo("0662")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class BeforeShowContextMenuEventArgs
	{
		// Token: 0x0600298C RID: 10636 RVA: 0x0012AC70 File Offset: 0x00128E70
		public BeforeShowContextMenuEventArgs(Table A_0, HitTypeEnum A_1)
		{
			this.O.O00. = A_0;
			this.O.O00. = A_1;
		}

		/// <summary>
		/// 触发事件的Table
		/// </summary>
		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x0600298D RID: 10637 RVA: 0x0012AC86 File Offset: 0x00128E86
		public Table Table
		{
			get
			{
				return this.O.O00.;
			}
		}

		/// <summary>
		/// 返回右击区域的类型
		/// </summary>
		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x0012AC8E File Offset: 0x00128E8E
		public HitTypeEnum HitType
		{
			get
			{
				return this.O.O00.;
			}
		}

		/// <summary>
		/// 设为True，取消显示快捷菜单
		/// </summary>
		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x0600298F RID: 10639 RVA: 0x0012AC96 File Offset: 0x00128E96
		// (set) Token: 0x06002990 RID: 10640 RVA: 0x0012AC9E File Offset: 0x00128E9E
		public bool Cancel
		{
			get
			{
				return this.O.O00.;
			}
			set
			{
				this.O.O00. = value;
			}
		}

		/// <summary>
		/// 设置即将显示的快捷菜单，如果不设置，将显示默认的菜单
		/// </summary>
		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x0012ACA7 File Offset: 0x00128EA7
		// (set) Token: 0x06002992 RID: 10642 RVA: 0x0012ACAF File Offset: 0x00128EAF
		public ContextMenu ContextMenu
		{
			get
			{
				return this.O.O00.;
			}
			set
			{
				this.O.O00. = value;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06002993 RID: 10643 RVA: 0x0012ACB8 File Offset: 0x00128EB8
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x0400112A RID: 4394
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400112B RID: 4395
		private HitTypeEnum <<EMPTY_NAME>>;

		// Token: 0x0400112C RID: 4396
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400112D RID: 4397
		private ContextMenu <<EMPTY_NAME>>;
	}
}
