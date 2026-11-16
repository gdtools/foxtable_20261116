using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200024E RID: 590
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("2637")]
	public class BeforeOpenFileEventArgs
	{
		// Token: 0x06001C3B RID: 7227 RVA: 0x000C497A File Offset: 0x000C2B7A
		public BeforeOpenFileEventArgs(DataTable A_0, DataRow A_1, DataCol A_2, string A_3, bool A_4)
		{
			if (A_3 == DBNull.Value)
			{
				A_3 = null;
			}
			this.O.O00. = A_0;
			this.o0__0_0O0.oO0. = A_1;
			this.o0__0_0O0.oO0. = A_2;
			this.O.O00. = A_3;
			this.o.__0. = A_4;
		}

		/// <summary>
		/// 触发事件的DataTable
		/// </summary>
		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x000C49B3 File Offset: 0x000C2BB3
		public DataTable DataTable
		{
			get
			{
				return this.O.O00.;
			}
		}

		/// <summary>
		/// 触发事件的DataRow
		/// </summary>
		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x000C49BB File Offset: 0x000C2BBB
		public DataRow DataRow
		{
			get
			{
				return this.o0__0_0O0.oO0.;
			}
		}

		/// <summary>
		/// 触发事件的DataCol
		/// </summary>
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x000C49C3 File Offset: 0x000C2BC3
		public DataCol DataCol
		{
			get
			{
				return this.o0__0_0O0.oO0.;
			}
		}

		/// <summary>
		/// 返回或设置即将打开的文件
		/// </summary>
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x000C49CB File Offset: 0x000C2BCB
		// (set) Token: 0x06001C40 RID: 7232 RVA: 0x000C49D3 File Offset: 0x000C2BD3
		public string FileName
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
		/// 是否取消此次打开操作
		/// </summary>
		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x000C49DC File Offset: 0x000C2BDC
		// (set) Token: 0x06001C42 RID: 7234 RVA: 0x000C49E4 File Offset: 0x000C2BE4
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

		/// <summary>
		/// 是否自动更新附件，仅在使用FTP管理远程文件的时候有效
		/// </summary>
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x000C49ED File Offset: 0x000C2BED
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x000C49F5 File Offset: 0x000C2BF5
		public bool AutoUpdate
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
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x000C4A00 File Offset: 0x000C2C00
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

		// Token: 0x04000BF3 RID: 3059
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000BF4 RID: 3060
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04000BF5 RID: 3061
		private DataCol <<EMPTY_NAME>>;

		// Token: 0x04000BF6 RID: 3062
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BF7 RID: 3063
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000BF8 RID: 3064
		private bool <<EMPTY_NAME>>;
	}
}
