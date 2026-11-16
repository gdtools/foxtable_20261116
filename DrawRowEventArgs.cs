using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000302 RID: 770
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class DrawRowEventArgs
	{
		// Token: 0x060029CC RID: 10700 RVA: 0x0012B444 File Offset: 0x00129644
		public DrawRowEventArgs(Table A_0, Row A_1, int A_2)
		{
			this.ooo_OOO.O0O. = A_0;
			this.ooo_OOO.O0O. = A_1;
			this.ooo_OOO.O0O. = A_2;
		}

		/// <summary>
		/// 触发事件的Table
		/// </summary>
		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060029CD RID: 10701 RVA: 0x0012B461 File Offset: 0x00129661
		public Table Table
		{
			get
			{
				return this.ooo_OOO.O0O.;
			}
		}

		/// <summary>
		/// 触发事件的行
		/// </summary>
		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x0012B469 File Offset: 0x00129669
		public Row Row
		{
			get
			{
				return this.ooo_OOO.O0O.;
			}
		}

		/// <summary>
		/// 设置行高
		/// </summary>
		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060029CF RID: 10703 RVA: 0x0012B471 File Offset: 0x00129671
		// (set) Token: 0x060029D0 RID: 10704 RVA: 0x0012B479 File Offset: 0x00129679
		public int Height
		{
			get
			{
				return this.ooo_OOO.O0O.;
			}
			set
			{
				this.ooo_OOO.O0O. = value;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x0012B482 File Offset: 0x00129682
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x0400114B RID: 4427
		private Table <<EMPTY_NAME>>;

		// Token: 0x0400114C RID: 4428
		private Row <<EMPTY_NAME>>;

		// Token: 0x0400114D RID: 4429
		private int <<EMPTY_NAME>>;
	}
}
