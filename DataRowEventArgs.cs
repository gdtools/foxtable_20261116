using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020000A4 RID: 164
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class DataRowEventArgs
	{
		// Token: 0x06000668 RID: 1640 RVA: 0x00030055 File Offset: 0x0002E255
		public DataRowEventArgs(DataTable A_0, DataRow A_1)
		{
			this.ooo.0. = true;
			this.o0_oo0._. = A_0;
			this.o0_oo0._. = A_1;
		}

		/// <summary>
		/// 触发事件的DataTable
		/// </summary>
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00030072 File Offset: 0x0002E272
		public DataTable DataTable
		{
			get
			{
				return this.o0_oo0._.;
			}
		}

		/// <summary>
		/// 触发事件的DataRow
		/// </summary>
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0003007A File Offset: 0x0002E27A
		public DataRow DataRow
		{
			get
			{
				return this.o0_oo0._.;
			}
		}

		/// <summary>
		/// 设置为True，可取消本次操作
		/// </summary>
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00030082 File Offset: 0x0002E282
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x0003008A File Offset: 0x0002E28A
		public bool Cancel
		{
			get
			{
				return this.o0_oo0._.;
			}
			set
			{
				this.o0_oo0._. = value;
			}
		}

		/// <summary>
		///  如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00030094 File Offset: 0x0002E294
		public Form Form
		{
			get
			{
				Form result;
				if (OO_00oOO.Tables.get_Contains(this.DataTable.Name))
				{
					result = OO_00oOO.Tables[this.DataTable.Name].Form;
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 逻辑型，设为False，取消后续删除行操作，仅对BeforeDeleteDataRow事件有效
		/// </summary>
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x000300D8 File Offset: 0x0002E2D8
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x000300E0 File Offset: 0x0002E2E0
		public bool Continue
		{
			get
			{
				return this.ooo.0.;
			}
			set
			{
				this.ooo.0. = value;
			}
		}

		// Token: 0x040001B6 RID: 438
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x040001B7 RID: 439
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x040001B8 RID: 440
		private bool <<EMPTY_NAME>>;

		// Token: 0x040001B9 RID: 441
		private bool <<EMPTY_NAME>>;
	}
}
