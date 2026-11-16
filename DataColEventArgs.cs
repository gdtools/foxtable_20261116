using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020002FF RID: 767
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class DataColEventArgs
	{
		// Token: 0x060029A2 RID: 10658 RVA: 0x0012AD7C File Offset: 0x00128F7C
		public DataColEventArgs(DataTable A_0, DataRow A_1, DataCol A_2, object A_3, object A_4)
		{
			if (A_3 == DBNull.Value)
			{
				A_3 = null;
			}
			if (A_4 == DBNull.Value)
			{
				A_4 = null;
			}
			this.o.0OoOo. = A_0;
			this.o.0OoOo. = A_1;
			this.o.0OoOo. = A_2;
			this.o.0OoOo. = RuntimeHelpers.GetObjectValue(A_3);
			this.OOO_00oooO_o._. = RuntimeHelpers.GetObjectValue(A_4);
		}

		/// <summary>
		/// 触发事件的DataTable
		/// </summary>
		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060029A3 RID: 10659 RVA: 0x0012ADD6 File Offset: 0x00128FD6
		public DataTable DataTable
		{
			get
			{
				return this.o.0OoOo.;
			}
		}

		/// <summary>
		/// 触发事件的DataRow
		/// </summary>
		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x0012ADDE File Offset: 0x00128FDE
		public DataRow DataRow
		{
			get
			{
				return this.o.0OoOo.;
			}
		}

		/// <summary>
		/// 触发事件的DataCol
		/// </summary>
		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x060029A5 RID: 10661 RVA: 0x0012ADE6 File Offset: 0x00128FE6
		public DataCol DataCol
		{
			get
			{
				return this.o.0OoOo.;
			}
		}

		/// <summary>
		/// 新值
		/// </summary>
		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x0012ADEE File Offset: 0x00128FEE
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x0012ADF6 File Offset: 0x00128FF6
		public object NewValue
		{
			get
			{
				return this.o.0OoOo.;
			}
			set
			{
				this.o.0OoOo. = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 原值
		/// </summary>
		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x0012AE04 File Offset: 0x00129004
		public object OldValue
		{
			get
			{
				return this.OOO_00oooO_o._.;
			}
		}

		/// <summary>
		/// 设置为True，可取消修改
		/// </summary>
		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x060029A9 RID: 10665 RVA: 0x0012AE0C File Offset: 0x0012900C
		// (set) Token: 0x060029AA RID: 10666 RVA: 0x0012AE14 File Offset: 0x00129014
		public bool Cancel
		{
			get
			{
				return this.o.0OoOo.;
			}
			set
			{
				this.o.0OoOo. = value;
			}
		}

		/// <summary>
		///  如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x0012AE20 File Offset: 0x00129020
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

		// Token: 0x04001137 RID: 4407
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04001138 RID: 4408
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04001139 RID: 4409
		private DataCol <<EMPTY_NAME>>;

		// Token: 0x0400113A RID: 4410
		private object <<EMPTY_NAME>>;

		// Token: 0x0400113B RID: 4411
		private object <<EMPTY_NAME>>;

		// Token: 0x0400113C RID: 4412
		private bool <<EMPTY_NAME>>;
	}
}
