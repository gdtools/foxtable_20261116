using System;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 滑动条
	/// </summary>
	// Token: 0x02000010 RID: 16
	[ComVisible(true)]
	public class TrackBar : RibbonItem
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00002BB6 File Offset: 0x00000DB6
		internal TrackBar(RibbonTrackBar A_0) : base(A_0)
		{
			this.O.oOOO. = A_0;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002BC6 File Offset: 0x00000DC6
		public TrackBar(string A_0)
		{
			this.O.oOOO. = new RibbonTrackBar();
			this.oOo_.0o_O_O_0. = this.O.oOOO.;
			this.O.oOOO..ID = A_0;
		}

		/// <summary>
		/// 返回或设置进度条的最小值
		/// </summary>
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002BF1 File Offset: 0x00000DF1
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002BFE File Offset: 0x00000DFE
		public int Minimum
		{
			get
			{
				return this.O.oOOO..Minimum;
			}
			set
			{
				this.O.oOOO..Minimum = value;
			}
		}

		/// <summary>
		/// 返回或设置进度条的最大值
		/// </summary>
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002C0C File Offset: 0x00000E0C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002C19 File Offset: 0x00000E19
		public int Maximum
		{
			get
			{
				return this.O.oOOO..Maximum;
			}
			set
			{
				this.O.oOOO..Maximum = value;
			}
		}

		/// <summary>
		/// 返回或设置进度条的当前值
		/// </summary>
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002C27 File Offset: 0x00000E27
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002C34 File Offset: 0x00000E34
		public int value
		{
			get
			{
				return this.O.oOOO..Value;
			}
			set
			{
				this.O.oOOO..Value = value;
			}
		}

		/// <summary>
		/// 返回或设置进度条的宽度
		/// </summary>
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002C42 File Offset: 0x00000E42
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002C4F File Offset: 0x00000E4F
		public int Width
		{
			get
			{
				return this.O.oOOO..Width;
			}
			set
			{
				this.O.oOOO..Width = value;
			}
		}

		/// <summary>
		/// 每次单击加减按钮值的改变幅度
		/// </summary>
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002C5D File Offset: 0x00000E5D
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002C6A File Offset: 0x00000E6A
		public int StepFrequency
		{
			get
			{
				return this.O.oOOO..StepFrequency;
			}
			set
			{
				this.O.oOOO..StepFrequency = value;
			}
		}

		/// <summary>
		/// 刻度间隔值
		/// </summary>
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002C78 File Offset: 0x00000E78
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002C85 File Offset: 0x00000E85
		public int TickFrequency
		{
			get
			{
				return this.O.oOOO..TickFrequency;
			}
			set
			{
				this.O.oOOO..TickFrequency = value;
			}
		}

		// Token: 0x04000015 RID: 21
		internal RibbonTrackBar <<EMPTY_NAME>>;
	}
}
