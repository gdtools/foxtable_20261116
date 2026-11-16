using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003F0 RID: 1008
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class FormEventArgs
	{
		// Token: 0x0600416E RID: 16750 RVA: 0x001D8941 File Offset: 0x001D6B41
		public FormEventArgs(Form A_0)
		{
			this.O.ooooo. = A_0;
		}

		/// <summary>
		/// 返回触发事件的窗口
		/// </summary>
		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x0600416F RID: 16751 RVA: 0x001D8950 File Offset: 0x001D6B50
		public Form Form
		{
			get
			{
				return this.O.ooooo.;
			}
		}

		/// <summary>
		/// 是否取消本次操作
		/// </summary>
		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x001D8958 File Offset: 0x001D6B58
		// (set) Token: 0x06004171 RID: 16753 RVA: 0x001D8960 File Offset: 0x001D6B60
		public bool Cancel
		{
			get
			{
				return this.O.ooooo.;
			}
			set
			{
				this.O.ooooo. = value;
			}
		}

		/// <summary>
		/// 返回窗口关闭方式，仅对BeforeClose事件有效
		/// </summary>
		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06004172 RID: 16754 RVA: 0x001D8969 File Offset: 0x001D6B69
		public int CloseMode
		{
			get
			{
				return this.O.ooooo..Pane.O00O00o_oOo.o_.;
			}
		}

		// Token: 0x04001A65 RID: 6757
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001A66 RID: 6758
		private Form <<EMPTY_NAME>>;
	}
}
