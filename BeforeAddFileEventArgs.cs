using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200024B RID: 587
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("2638")]
	public class BeforeAddFileEventArgs
	{
		// Token: 0x06001C1F RID: 7199 RVA: 0x000C47A2 File Offset: 0x000C29A2
		public BeforeAddFileEventArgs(DataTable A_0, DataRow A_1, DataCol A_2)
		{
			this.ooO_0oo.oOo0o. = A_0;
			this.ooO_0oo.oOo0o. = A_1;
			this.ooO_0oo.oOo0o. = A_2;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000C47BF File Offset: 0x000C29BF
		public BeforeAddFileEventArgs(DataTable A_0, DataRow A_1, DataCol A_2, bool A_3)
		{
			this.ooO_0oo.oOo0o. = A_0;
			this.ooO_0oo.oOo0o. = A_1;
			this.ooO_0oo.oOo0o. = A_2;
			this.O__00_.0. = A_3;
		}

		/// <summary>
		/// 触发事件的DataTable
		/// </summary>
		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x000C47E4 File Offset: 0x000C29E4
		public DataTable DataTable
		{
			get
			{
				return this.ooO_0oo.oOo0o.;
			}
		}

		/// <summary>
		/// 触发事件的DataRow
		/// </summary>
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x000C47EC File Offset: 0x000C29EC
		public DataRow DataRow
		{
			get
			{
				return this.ooO_0oo.oOo0o.;
			}
		}

		/// <summary>
		/// 触发事件的DataCol
		/// </summary>
		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x000C47F4 File Offset: 0x000C29F4
		public DataCol DataCol
		{
			get
			{
				return this.ooO_0oo.oOo0o.;
			}
		}

		/// <summary>
		/// 用于设置打开文件对话框的初始目录
		/// </summary>
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x000C47FC File Offset: 0x000C29FC
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x000C4804 File Offset: 0x000C2A04
		public string Path
		{
			get
			{
				return this.ooO_0oo.oOo0o.;
			}
			set
			{
				this.ooO_0oo.oOo0o. = value;
			}
		}

		/// <summary>
		/// 是否是添加目录
		/// </summary>
		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x000C480D File Offset: 0x000C2A0D
		public bool IsDir
		{
			get
			{
				return this.O__00_.0.;
			}
		}

		/// <summary>
		/// 是否取消此次添加操作
		/// </summary>
		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x000C4815 File Offset: 0x000C2A15
		// (set) Token: 0x06001C28 RID: 7208 RVA: 0x000C481D File Offset: 0x000C2A1D
		public bool Cancel
		{
			get
			{
				return this.ooO_0oo.oOo0o.;
			}
			set
			{
				this.ooO_0oo.oOo0o. = value;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x000C4828 File Offset: 0x000C2A28
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

		// Token: 0x04000BE4 RID: 3044
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000BE5 RID: 3045
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04000BE6 RID: 3046
		private DataCol <<EMPTY_NAME>>;

		// Token: 0x04000BE7 RID: 3047
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BE8 RID: 3048
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000BE9 RID: 3049
		private bool <<EMPTY_NAME>>;
	}
}
