using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000155 RID: 341
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ControlMouseEventArgs : MouseEventArgs
	{
		// Token: 0x06001071 RID: 4209 RVA: 0x0007DF90 File Offset: 0x0007C190
		public ControlMouseEventArgs(System.Windows.Forms.Control A_0, MouseButtons A_1, int A_2, int A_3, int A_4, int A_5, Foxtable.WinForm.Form A_6) : base(A_1, A_2, A_3, A_4, A_5)
		{
			if (A_0 is System.Windows.Forms.PictureBox && A_0.Parent is CustomPictureBox)
			{
				A_0 = A_0.Parent;
			}
			this.oO_oOo_.O_Oo0. = A_0;
			this.oO_oOo_.O_Oo0. = A_6;
		}

		/// <summary>
		/// 返回触发事件的控件
		/// </summary>
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x0007DFCC File Offset: 0x0007C1CC
		public object Sender
		{
			get
			{
				if (this.OO00_O0_._OO0. == null)
				{
					this.OO00_O0_._OO0. = ooO_0O.o_O0.O_.(this.oO_oOo_.O_Oo0.);
					this.OO00_O0_._OO0..o.__O0O. = this.Form;
				}
				return this.OO00_O0_._OO0.;
			}
		}

		/// <summary>
		/// 返回控件所在的窗口
		/// </summary>
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0007DFFE File Offset: 0x0007C1FE
		public Foxtable.WinForm.Form Form
		{
			get
			{
				return this.oO_oOo_.O_Oo0.;
			}
		}

		/// <summary>
		/// 返回鼠标的水平位置
		/// </summary>
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x0007E006 File Offset: 0x0007C206
		public new int X
		{
			get
			{
				return base.X;
			}
		}

		/// <summary>
		/// 返回鼠标的垂直位置
		/// </summary>
		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0007E00E File Offset: 0x0007C20E
		public new int Y
		{
			get
			{
				return base.Y;
			}
		}

		/// <summary>
		/// 判断按下的是哪一个鼠标按钮
		/// </summary>
		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x0007E016 File Offset: 0x0007C216
		public new MouseButtons Button
		{
			get
			{
				return base.Button;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x0007E01E File Offset: 0x0007C21E
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x0007E026 File Offset: 0x0007C226
		public virtual bool Cancel
		{
			get
			{
				return this.OO00_O0_._OO0.;
			}
			set
			{
				this.OO00_O0_._OO0. = value;
			}
		}

		// Token: 0x04000660 RID: 1632
		private System.Windows.Forms.Control <<EMPTY_NAME>>;

		// Token: 0x04000661 RID: 1633
		private Foxtable.WinForm.Form <<EMPTY_NAME>>;

		// Token: 0x04000662 RID: 1634
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000663 RID: 1635
		private Foxtable.WinForm.Control <<EMPTY_NAME>>;
	}
}
