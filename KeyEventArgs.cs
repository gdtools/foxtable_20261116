using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000306 RID: 774
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class KeyEventArgs : KeyEventArgs
	{
		// Token: 0x060029EA RID: 10730 RVA: 0x0012B66D File Offset: 0x0012986D
		public KeyEventArgs(Table A_0, Keys A_1) : base(A_1)
		{
			this.Oo0O0OO_0_.00. = A_0;
		}

		/// <summary>
		/// 触发事件的Table
		/// </summary>
		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x060029EB RID: 10731 RVA: 0x0012B67D File Offset: 0x0012987D
		public Table Table
		{
			get
			{
				return this.Oo0O0OO_0_.00.;
			}
		}

		/// <summary>
		/// 设置为True,取消本次按键操作
		/// </summary>
		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x060029EC RID: 10732 RVA: 0x0012B685 File Offset: 0x00129885
		// (set) Token: 0x060029ED RID: 10733 RVA: 0x0012B68D File Offset: 0x0012988D
		public bool Cancel
		{
			get
			{
				return base.Handled;
			}
			set
			{
				base.Handled = value;
				base.SuppressKeyPress = value;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x060029EE RID: 10734 RVA: 0x0012B69D File Offset: 0x0012989D
		public Foxtable.WinForm.Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x04001157 RID: 4439
		private Table <<EMPTY_NAME>>;
	}
}
