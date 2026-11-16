using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000252 RID: 594
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class LoadEventArgs
	{
		// Token: 0x06001C53 RID: 7251 RVA: 0x000C4AFF File Offset: 0x000C2CFF
		public LoadEventArgs(DataTable A_0)
		{
			this.OO.oO0OO0_. = A_0;
		}

		/// <summary>
		/// 触发事件的DataTable
		/// </summary>
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x000C4B0E File Offset: 0x000C2D0E
		// (set) Token: 0x06001C55 RID: 7253 RVA: 0x000C4B16 File Offset: 0x000C2D16
		public DataTable DataTable
		{
			get
			{
				return this.OO.oO0OO0_.;
			}
			set
			{
				this.OO.oO0OO0_. = value;
			}
		}

		/// <summary>
		/// 如果设置为True，将取消本次加载
		/// </summary>
		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x000C4B1F File Offset: 0x000C2D1F
		// (set) Token: 0x06001C57 RID: 7255 RVA: 0x000C4B27 File Offset: 0x000C2D27
		public bool Cancel
		{
			get
			{
				return this.OO.oO0OO0_.;
			}
			set
			{
				this.OO.oO0OO0_. = value;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x000C4B30 File Offset: 0x000C2D30
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

		// Token: 0x04000BFF RID: 3071
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000C00 RID: 3072
		private bool <<EMPTY_NAME>>;
	}
}
