using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200024C RID: 588
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("2209")]
	public class BeforeAttachFileEvents
	{
		// Token: 0x06001C2A RID: 7210 RVA: 0x000C486C File Offset: 0x000C2A6C
		public BeforeAttachFileEvents(DataTable A_0, DataRow A_1, DataCol A_2, string A_3, string A_4, string A_5)
		{
			if (A_4 == DBNull.Value)
			{
				A_4 = null;
			}
			this.oo00.0oOoO0o. = A_0;
			this.oo00.0oOoO0o. = A_1;
			this.oo00.0oOoO0o. = A_2;
			this.oO.O0O00oo_. = A_5;
			this.oo00.0oOoO0o. = A_4;
			this.o.0O. = A_3;
		}

		/// <summary>
		/// 触发事件的DataTable
		/// </summary>
		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x000C48B8 File Offset: 0x000C2AB8
		public DataTable DataTable
		{
			get
			{
				return this.oo00.0oOoO0o.;
			}
		}

		/// <summary>
		/// 触发事件的DataRow
		/// </summary>
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x000C48C0 File Offset: 0x000C2AC0
		public DataRow DataRow
		{
			get
			{
				return this.oo00.0oOoO0o.;
			}
		}

		/// <summary>
		/// 触发事件的DataCol
		/// </summary>
		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x000C48C8 File Offset: 0x000C2AC8
		public DataCol DataCol
		{
			get
			{
				return this.oo00.0oOoO0o.;
			}
		}

		/// <summary>
		/// 指定存放文件的子目录
		/// </summary>
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x000C48D0 File Offset: 0x000C2AD0
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x000C48D8 File Offset: 0x000C2AD8
		public string SubFolder
		{
			get
			{
				return this.oO.O0O00oo_.;
			}
			set
			{
				this.oO.O0O00oo_. = value;
			}
		}

		/// <summary>
		/// 获取要添加文件的来源目录
		/// </summary>
		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x000C48E1 File Offset: 0x000C2AE1
		public string SourceFolder
		{
			get
			{
				return this.o.0O.;
			}
		}

		/// <summary>
		/// 要添加文件的名称，你可以根据需要改名
		/// </summary>
		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x000C48E9 File Offset: 0x000C2AE9
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x000C48F1 File Offset: 0x000C2AF1
		public string FileName
		{
			get
			{
				return this.oo00.0oOoO0o.;
			}
			set
			{
				this.oo00.0oOoO0o. = value;
			}
		}

		/// <summary>
		/// 是否取消此次添加
		/// </summary>
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x000C48FA File Offset: 0x000C2AFA
		// (set) Token: 0x06001C34 RID: 7220 RVA: 0x000C4902 File Offset: 0x000C2B02
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
		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x000C490C File Offset: 0x000C2B0C
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

		// Token: 0x04000BEA RID: 3050
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000BEB RID: 3051
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04000BEC RID: 3052
		private DataCol <<EMPTY_NAME>>;

		// Token: 0x04000BED RID: 3053
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BEE RID: 3054
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BEF RID: 3055
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BF0 RID: 3056
		private bool <<EMPTY_NAME>>;
	}
}
