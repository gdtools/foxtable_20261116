using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x020002F8 RID: 760
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("0669")]
	public class BeforeLoadInnerTableEventArgs
	{
		// Token: 0x06002970 RID: 10608 RVA: 0x0012AB1B File Offset: 0x00128D1B
		public BeforeLoadInnerTableEventArgs(string A_0, string A_1, string A_2, UserInfo A_3)
		{
			this.o0OOo.000Oo0. = A_0;
			this.o0._. = A_1;
			this.o._Oo. = A_2;
			this.o0OOo.000Oo0. = A_3;
		}

		/// <summary>
		/// 触发事件的DataTable
		/// </summary>
		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x0012AB40 File Offset: 0x00128D40
		public string DataTableName
		{
			get
			{
				string result;
				if (this.o0OOo.000Oo0..StartsWith("~TMPCLP"))
				{
					result = this.o0OOo.000Oo0..Substring(7);
				}
				else
				{
					result = this.o0OOo.000Oo0.;
				}
				return result;
			}
		}

		/// <summary>
		/// 指定加载的字段(列)，不同字段用逗号分割
		/// </summary>
		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x0012AB76 File Offset: 0x00128D76
		// (set) Token: 0x06002973 RID: 10611 RVA: 0x0012AB7E File Offset: 0x00128D7E
		public string Fields
		{
			get
			{
				return this.o0._.;
			}
			set
			{
				this.o0._. = value;
			}
		}

		/// <summary>
		/// 设置过滤条件，只加载符合此条件的数据
		/// </summary>
		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06002974 RID: 10612 RVA: 0x0012AB87 File Offset: 0x00128D87
		// (set) Token: 0x06002975 RID: 10613 RVA: 0x0012AB8F File Offset: 0x00128D8F
		public string Filter
		{
			get
			{
				return this.o._Oo.;
			}
			set
			{
				this.o._Oo. = value;
			}
		}

		/// <summary>
		/// 登录用户
		/// </summary>
		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002976 RID: 10614 RVA: 0x0012AB98 File Offset: 0x00128D98
		public UserInfo User
		{
			get
			{
				return this.o0OOo.000Oo0.;
			}
		}

		/// <summary>
		/// 直接指定用于加载数据的Select语句
		/// </summary>
		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x0012ABA0 File Offset: 0x00128DA0
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x0012ABA8 File Offset: 0x00128DA8
		public string SelectString
		{
			get
			{
				return this.o.00O_OO.;
			}
			set
			{
				this.o.00O_OO. = value;
			}
		}

		/// <summary>
		/// 设置为True，将不加载此表
		/// </summary>
		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x0012ABB1 File Offset: 0x00128DB1
		// (set) Token: 0x0600297A RID: 10618 RVA: 0x0012ABB9 File Offset: 0x00128DB9
		public bool Cancel
		{
			get
			{
				return this.o0OOo.000Oo0.;
			}
			set
			{
				this.o0OOo.000Oo0. = value;
			}
		}

		/// <summary>
		/// 设为True，关闭Foxtable的启动封面
		/// </summary>
		// Token: 0x170008DA RID: 2266
		// (set) Token: 0x0600297B RID: 10619 RVA: 0x0012ABC2 File Offset: 0x00128DC2
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

		// Token: 0x0400111D RID: 4381
		private string <<EMPTY_NAME>>;

		// Token: 0x0400111E RID: 4382
		private string <<EMPTY_NAME>>;

		// Token: 0x0400111F RID: 4383
		private string <<EMPTY_NAME>>;

		// Token: 0x04001120 RID: 4384
		private UserInfo <<EMPTY_NAME>>;

		// Token: 0x04001121 RID: 4385
		private string <<EMPTY_NAME>>;

		// Token: 0x04001122 RID: 4386
		private bool <<EMPTY_NAME>>;
	}
}
