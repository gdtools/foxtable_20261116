using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x0200030C RID: 780
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TableEventArgs
	{
		// Token: 0x06002A1C RID: 10780 RVA: 0x0012B97A File Offset: 0x00129B7A
		public TableEventArgs(Table A_0)
		{
			this.o0O0Oo.OoO_. = A_0;
		}

		/// <summary>
		/// 触发发事件的Table
		/// </summary>
		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x0012B989 File Offset: 0x00129B89
		public Table Table
		{
			get
			{
				return this.o0O0Oo.OoO_.;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002A1E RID: 10782 RVA: 0x0012B991 File Offset: 0x00129B91
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x0400116F RID: 4463
		private Table <<EMPTY_NAME>>;
	}
}
