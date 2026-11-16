using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020003EE RID: 1006
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ControlKeyEventArgs : KeyEventArgs
	{
		// Token: 0x06004162 RID: 16738 RVA: 0x001D8879 File Offset: 0x001D6A79
		public ControlKeyEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, Keys A_2) : base(A_2)
		{
			if (A_0 is System.Windows.Forms.PictureBox && A_0.Parent is CustomPictureBox)
			{
				A_0 = A_0.Parent;
			}
			this.O_.0oo_O. = A_0;
			this.O_.0oo_O. = A_1;
		}

		/// <summary>
		/// 返回触发事件的控件
		/// </summary>
		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x001D88AD File Offset: 0x001D6AAD
		public object Sender
		{
			get
			{
				if (this.O_.0oo_O. == null)
				{
					this.O_.0oo_O. = ooO_0O.o_O0.O_.(this.O_.0oo_O.);
					this.O_.0oo_O..o.__O0O. = this.Form;
				}
				return this.O_.0oo_O.;
			}
		}

		/// <summary>
		/// 返回控件所在的窗口
		/// </summary>
		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x001D88DF File Offset: 0x001D6ADF
		public Foxtable.WinForm.Form Form
		{
			get
			{
				return this.O_.0oo_O.;
			}
		}

		/// <summary>
		/// Keys枚举型，表示按键的代码
		/// </summary>
		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06004165 RID: 16741 RVA: 0x001D88E7 File Offset: 0x001D6AE7
		public new Keys KeyCode
		{
			get
			{
				return base.KeyCode;
			}
		}

		/// <summary>
		/// 是否同时按下了Alt键
		/// </summary>
		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06004166 RID: 16742 RVA: 0x001D88EF File Offset: 0x001D6AEF
		public new bool Alt
		{
			get
			{
				return base.Alt;
			}
		}

		/// <summary>
		/// 是否同时按下了Control键
		/// </summary>
		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x001D88F7 File Offset: 0x001D6AF7
		public new bool Control
		{
			get
			{
				return base.Control;
			}
		}

		/// <summary>
		/// 是否同时按下了Shift键
		/// </summary>
		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06004168 RID: 16744 RVA: 0x001D88FF File Offset: 0x001D6AFF
		public new bool Shift
		{
			get
			{
				return base.Shift;
			}
		}

		/// <summary>
		/// 是否取消本次操作
		/// </summary>
		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x001D8907 File Offset: 0x001D6B07
		// (set) Token: 0x0600416A RID: 16746 RVA: 0x001D890F File Offset: 0x001D6B0F
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

		// Token: 0x04001A61 RID: 6753
		private System.Windows.Forms.Control <<EMPTY_NAME>>;

		// Token: 0x04001A62 RID: 6754
		private Foxtable.WinForm.Form <<EMPTY_NAME>>;

		// Token: 0x04001A63 RID: 6755
		private Foxtable.WinForm.Control <<EMPTY_NAME>>;
	}
}
