using System;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 进度条
	/// </summary>
	// Token: 0x0200000F RID: 15
	[ComVisible(true)]
	public class ProgressBar : RibbonItem
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00002AF4 File Offset: 0x00000CF4
		internal ProgressBar(RibbonProgressBar A_0) : base(A_0)
		{
			this.OOo.O_o. = A_0;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002B04 File Offset: 0x00000D04
		public ProgressBar(string A_0)
		{
			this.OOo.O_o. = new RibbonProgressBar();
			this.oOo_.0o_O_O_0. = this.OOo.O_o.;
			this.OOo.O_o..ID = A_0;
		}

		/// <summary>
		/// 返回或设置进度条的最小值
		/// </summary>
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002B2F File Offset: 0x00000D2F
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002B3C File Offset: 0x00000D3C
		public int Minimum
		{
			get
			{
				return this.OOo.O_o..Minimum;
			}
			set
			{
				this.OOo.O_o..Minimum = value;
			}
		}

		/// <summary>
		/// 返回或设置进度条的最大值
		/// </summary>
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002B4A File Offset: 0x00000D4A
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002B57 File Offset: 0x00000D57
		public int Maximum
		{
			get
			{
				return this.OOo.O_o..Maximum;
			}
			set
			{
				this.OOo.O_o..Maximum = value;
			}
		}

		/// <summary>
		/// 返回或设置进度条的当前值
		/// </summary>
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002B65 File Offset: 0x00000D65
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002B72 File Offset: 0x00000D72
		public int value
		{
			get
			{
				return this.OOo.O_o..Value;
			}
			set
			{
				this.OOo.O_o..Value = value;
			}
		}

		/// <summary>
		/// 返回或设置进度条的宽度
		/// </summary>
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002B80 File Offset: 0x00000D80
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002B8D File Offset: 0x00000D8D
		public int Width
		{
			get
			{
				return this.OOo.O_o..Width;
			}
			set
			{
				this.OOo.O_o..Width = value;
			}
		}

		/// <summary>
		/// 返回或设置进度条的高度
		/// </summary>
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002B9B File Offset: 0x00000D9B
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002BA8 File Offset: 0x00000DA8
		public int Height
		{
			get
			{
				return this.OOo.O_o..Height;
			}
			set
			{
				this.OOo.O_o..Height = value;
			}
		}

		// Token: 0x04000014 RID: 20
		internal RibbonProgressBar <<EMPTY_NAME>>;
	}
}
