using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020000B6 RID: 182
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("2716")]
	public class BeforeDeleteFileEventArgs
	{
		// Token: 0x060007AF RID: 1967 RVA: 0x000398B0 File Offset: 0x00037AB0
		public BeforeDeleteFileEventArgs(DataTable A_0, DataRow A_1, DataCol A_2, string A_3)
		{
			this.O_0O_._o. = false;
			if (A_3 == DBNull.Value)
			{
				A_3 = null;
			}
			this.o0.OO0OOOO000_. = A_0;
			this.o0.OO0OOOO000_. = A_1;
			this.o0.OO0OOOO000_. = A_2;
			this.o0.OO0OOOO000_. = A_3;
		}

		/// <summary>
		/// 触发事件的DataTable
		/// </summary>
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x000398E8 File Offset: 0x00037AE8
		public DataTable DataTable
		{
			get
			{
				return this.o0.OO0OOOO000_.;
			}
		}

		/// <summary>
		/// 触发事件的DataRow
		/// </summary>
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x000398F0 File Offset: 0x00037AF0
		public DataRow DataRow
		{
			get
			{
				return this.o0.OO0OOOO000_.;
			}
		}

		/// <summary>
		/// 触发事件的DataCol
		/// </summary>
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x000398F8 File Offset: 0x00037AF8
		public DataCol DataCol
		{
			get
			{
				return this.o0.OO0OOOO000_.;
			}
		}

		/// <summary>
		/// 即将删除的文件
		/// </summary>
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00039900 File Offset: 0x00037B00
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x00039908 File Offset: 0x00037B08
		public string FileName
		{
			get
			{
				return this.o0.OO0OOOO000_.;
			}
			set
			{
				this.o0.OO0OOOO000_. = value;
			}
		}

		/// <summary>
		/// 是否取消此次删除操作
		/// </summary>
		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00039911 File Offset: 0x00037B11
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00039919 File Offset: 0x00037B19
		public bool Cancel
		{
			get
			{
				return this.o0.OO0OOOO000_.;
			}
			set
			{
				this.o0.OO0OOOO000_. = value;
			}
		}

		/// <summary>
		/// 是否删除本地附件
		/// </summary>
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00039922 File Offset: 0x00037B22
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x0003992A File Offset: 0x00037B2A
		public bool DeleteLocalFile
		{
			get
			{
				return this.O_oo_O.__o00.;
			}
			set
			{
				this.O_0O_._o. = true;
				this.O_oo_O.__o00. = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0003993A File Offset: 0x00037B3A
		internal bool HaveSetDeleteMode
		{
			get
			{
				return this.O_0O_._o.;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>&gt;
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00039944 File Offset: 0x00037B44
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

		// Token: 0x04000249 RID: 585
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x0400024A RID: 586
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x0400024B RID: 587
		private DataCol <<EMPTY_NAME>>;

		// Token: 0x0400024C RID: 588
		private string <<EMPTY_NAME>>;

		// Token: 0x0400024D RID: 589
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400024E RID: 590
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400024F RID: 591
		private bool <<EMPTY_NAME>>;
	}
}
