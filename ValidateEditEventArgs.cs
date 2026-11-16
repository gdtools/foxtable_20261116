using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200030D RID: 781
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ValidateEditEventArgs
	{
		// Token: 0x06002A1F RID: 10783 RVA: 0x0012B99E File Offset: 0x00129B9E
		public ValidateEditEventArgs(Table A_0, Row A_1, Col A_2, string A_3, RecordGrid A_4)
		{
			this.o.O0o_O. = A_0;
			this.o.O0o_O. = A_1;
			this.o.O0o_O. = A_2;
			this.o.O0o_O. = A_3;
			this.o.O0o_O. = A_4;
		}

		/// <summary>
		/// 触发事件的Table
		/// </summary>
		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x0012B9CB File Offset: 0x00129BCB
		public Table Table
		{
			get
			{
				return this.o.O0o_O.;
			}
		}

		/// <summary>
		/// 触发事件的Row
		/// </summary>
		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002A21 RID: 10785 RVA: 0x0012B9D3 File Offset: 0x00129BD3
		public Row Row
		{
			get
			{
				return this.o.O0o_O.;
			}
		}

		/// <summary>
		/// 触发事件的Col
		/// </summary>
		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x0012B9DB File Offset: 0x00129BDB
		public Col Col
		{
			get
			{
				return this.o.O0o_O.;
			}
		}

		/// <summary>
		/// 输入的文本内容
		/// </summary>
		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x0012B9E3 File Offset: 0x00129BE3
		// (set) Token: 0x06002A24 RID: 10788 RVA: 0x0012B9EB File Offset: 0x00129BEB
		public string Text
		{
			get
			{
				return this.o.O0o_O.;
			}
			set
			{
				this.o.O0o_O. = value;
			}
		}

		/// <summary>
		/// 设为True表示无法通过验证，禁止退出编辑模式
		/// </summary>
		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x0012B9F4 File Offset: 0x00129BF4
		// (set) Token: 0x06002A26 RID: 10790 RVA: 0x0012B9FC File Offset: 0x00129BFC
		public bool Cancel
		{
			get
			{
				return this.o.O0o_O.;
			}
			set
			{
				this.o.O0o_O. = value;
			}
		}

		/// <summary>
		/// 如果是在记录窗口编辑，则返回RecordGrid对象
		/// </summary>
		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x0012BA05 File Offset: 0x00129C05
		public RecordGrid RecordGrid
		{
			get
			{
				return this.o.O0o_O.;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x0012BA0D File Offset: 0x00129C0D
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x04001170 RID: 4464
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001171 RID: 4465
		private Row <<EMPTY_NAME>>;

		// Token: 0x04001172 RID: 4466
		private Col <<EMPTY_NAME>>;

		// Token: 0x04001173 RID: 4467
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001174 RID: 4468
		private string <<EMPTY_NAME>>;

		// Token: 0x04001175 RID: 4469
		private RecordGrid <<EMPTY_NAME>>;
	}
}
