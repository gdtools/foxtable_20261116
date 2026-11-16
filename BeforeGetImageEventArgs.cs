using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020002B7 RID: 695
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class BeforeGetImageEventArgs
	{
		// Token: 0x06002611 RID: 9745 RVA: 0x0011A06D File Offset: 0x0011826D
		public BeforeGetImageEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, string A_2)
		{
			if (A_0 is System.Windows.Forms.PictureBox && A_0.Parent is CustomPictureBox)
			{
				A_0 = A_0.Parent;
			}
			this.o0OOo.000Oo0. = A_0;
			this.o0OOo.000Oo0. = A_2;
			this.o0OOo.000Oo0. = A_1;
		}

		/// <summary>
		/// 返回触发事件的控件
		/// </summary>
		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x0011A0A7 File Offset: 0x001182A7
		public object Sender
		{
			get
			{
				if (this.o0.OO0OOOO000_. == null)
				{
					this.o0.OO0OOOO000_. = ooO_0O.o_O0.O_.(this.o0OOo.000Oo0.);
					this.o0.OO0OOOO000_..o.__O0O. = this.Form;
				}
				return this.o0.OO0OOOO000_.;
			}
		}

		/// <summary>
		/// 返回控件所在的窗口
		/// </summary>
		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x0011A0D9 File Offset: 0x001182D9
		public Foxtable.WinForm.Form Form
		{
			get
			{
				return this.o0OOo.000Oo0.;
			}
		}

		/// <summary>
		/// 返回或设置即将显示的图片文件名称
		/// </summary>
		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x0011A0E1 File Offset: 0x001182E1
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x0011A0E9 File Offset: 0x001182E9
		public string File
		{
			get
			{
				return this.o0OOo.000Oo0.;
			}
			set
			{
				this.o0OOo.000Oo0. = value;
			}
		}

		// Token: 0x04000FC7 RID: 4039
		private System.Windows.Forms.Control <<EMPTY_NAME>>;

		// Token: 0x04000FC8 RID: 4040
		private string <<EMPTY_NAME>>;

		// Token: 0x04000FC9 RID: 4041
		private Foxtable.WinForm.Form <<EMPTY_NAME>>;

		// Token: 0x04000FCA RID: 4042
		private Foxtable.WinForm.Control <<EMPTY_NAME>>;
	}
}
