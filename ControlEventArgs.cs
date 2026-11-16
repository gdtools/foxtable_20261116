using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020000F1 RID: 241
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ControlEventArgs
	{
		// Token: 0x06000DBE RID: 3518 RVA: 0x00071DB8 File Offset: 0x0006FFB8
		public ControlEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1)
		{
			if (A_0 is System.Windows.Forms.PictureBox && A_0.Parent is CustomPictureBox)
			{
				A_0 = A_0.Parent;
			}
			this.oo_.o_O. = A_0;
			this.O.OOO0000_0. = A_1;
		}

		/// <summary>
		/// 返回触发事件的控件
		/// </summary>
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00071DEB File Offset: 0x0006FFEB
		public object Sender
		{
			get
			{
				if (this.O.OOO0000_0. == null)
				{
					this.O.OOO0000_0. = ooO_0O.o_O0.O_.(this.oo_.o_O.);
					if (this.O.OOO0000_0. != null)
					{
						this.O.OOO0000_0..o.__O0O. = this.Form;
					}
				}
				return this.O.OOO0000_0.;
			}
		}

		/// <summary>
		/// 返回控件所在的窗口
		/// </summary>
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x00071E25 File Offset: 0x00070025
		public Foxtable.WinForm.Form Form
		{
			get
			{
				return this.O.OOO0000_0.;
			}
		}

		/// <summary>
		/// 是否取消本次操作
		/// </summary>
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00071E2D File Offset: 0x0007002D
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x00071E35 File Offset: 0x00070035
		public virtual bool Cancel
		{
			get
			{
				return this.O.OOO0000_0.;
			}
			set
			{
				this.O.OOO0000_0. = value;
			}
		}

		// Token: 0x04000555 RID: 1365
		private System.Windows.Forms.Control <<EMPTY_NAME>>;

		// Token: 0x04000556 RID: 1366
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000557 RID: 1367
		private Foxtable.WinForm.Form <<EMPTY_NAME>>;

		// Token: 0x04000558 RID: 1368
		private Foxtable.WinForm.Control <<EMPTY_NAME>>;
	}
}
