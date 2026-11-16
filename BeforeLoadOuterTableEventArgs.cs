using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020002F9 RID: 761
	[oO0oooo("0670")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class BeforeLoadOuterTableEventArgs
	{
		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x0012ABCC File Offset: 0x00128DCC
		public UserInfo User
		{
			get
			{
				return this.o0__0_0O0.oO0.;
			}
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x0012ABD4 File Offset: 0x00128DD4
		public BeforeLoadOuterTableEventArgs(string A_0, string A_1, UserInfo A_2)
		{
			this.o.__0. = A_0;
			this.o0__0_0O0.oO0. = A_1;
			this.o0__0_0O0.oO0. = A_2;
		}

		/// <summary>
		/// 指定用于加载数据的Select语句
		/// </summary>
		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x0012ABF1 File Offset: 0x00128DF1
		// (set) Token: 0x0600297F RID: 10623 RVA: 0x0012ABF9 File Offset: 0x00128DF9
		public string SelectString
		{
			get
			{
				return this.o0__0_0O0.oO0.;
			}
			set
			{
				this.o0__0_0O0.oO0. = value;
			}
		}

		/// <summary>
		/// 正在加载的数据表名称
		/// </summary>
		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x0012AC02 File Offset: 0x00128E02
		public string DataTableName
		{
			get
			{
				return this.o.__0.;
			}
		}

		/// <summary>
		/// 设置为True，将不加载此表
		/// </summary>
		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06002981 RID: 10625 RVA: 0x0012AC0A File Offset: 0x00128E0A
		// (set) Token: 0x06002982 RID: 10626 RVA: 0x0012AC12 File Offset: 0x00128E12
		public bool Cancel
		{
			get
			{
				return this.o0__0_0O0.oO0.;
			}
			set
			{
				this.o0__0_0O0.oO0. = value;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x0012AC1B File Offset: 0x00128E1B
		// (set) Token: 0x06002984 RID: 10628 RVA: 0x0012AC23 File Offset: 0x00128E23
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool DataServer
		{
			get
			{
				return this.o.__0.;
			}
			set
			{
				this.o.__0. = value;
			}
		}

		/// <summary>
		/// 设为True，关闭Foxtable的启动封面
		/// </summary>
		// Token: 0x170008E0 RID: 2272
		// (set) Token: 0x06002985 RID: 10629 RVA: 0x0012AC2C File Offset: 0x00128E2C
		public bool HideSplashForm
		{
			set
			{
				if (value)
				{
					OO_00oOO.CloseSplashForm();
				}
			}
		}

		// Token: 0x04001123 RID: 4387
		private string <<EMPTY_NAME>>;

		// Token: 0x04001124 RID: 4388
		private string <<EMPTY_NAME>>;

		// Token: 0x04001125 RID: 4389
		private UserInfo <<EMPTY_NAME>>;

		// Token: 0x04001126 RID: 4390
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001127 RID: 4391
		private bool <<EMPTY_NAME>>;
	}
}
