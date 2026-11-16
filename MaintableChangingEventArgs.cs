using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000308 RID: 776
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class MaintableChangingEventArgs
	{
		// Token: 0x06002A01 RID: 10753 RVA: 0x0012B839 File Offset: 0x00129A39
		public MaintableChangingEventArgs(string A_0, string A_1)
		{
			this.OO0o0_o._o_o. = A_0;
			this.Ooo0.0O__0000O. = A_1;
		}

		/// <summary>
		/// 原来的主表名称
		/// </summary>
		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x0012B84F File Offset: 0x00129A4F
		public string OldTableName
		{
			get
			{
				return this.OO0o0_o._o_o.;
			}
		}

		/// <summary>
		/// 新的主表名称
		/// </summary>
		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x0012B857 File Offset: 0x00129A57
		public string NewTableName
		{
			get
			{
				return this.Ooo0.0O__0000O.;
			}
		}

		/// <summary>
		/// 设为True，将禁止切换到新的主表
		/// </summary>
		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x0012B85F File Offset: 0x00129A5F
		// (set) Token: 0x06002A05 RID: 10757 RVA: 0x0012B867 File Offset: 0x00129A67
		public bool Cancel
		{
			get
			{
				return this.OO0o0_o._o_o.;
			}
			set
			{
				this.OO0o0_o._o_o. = value;
			}
		}

		// Token: 0x0400115F RID: 4447
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001160 RID: 4448
		private string <<EMPTY_NAME>>;

		// Token: 0x04001161 RID: 4449
		private string <<EMPTY_NAME>>;
	}
}
