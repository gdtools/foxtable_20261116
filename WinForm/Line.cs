using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 线条
	/// </summary>
	// Token: 0x0200052C RID: 1324
	[ComVisible(true)]
	[oO0oooo("1598")]
	public class Line : Control
	{
		// Token: 0x06005829 RID: 22569 RVA: 0x0025E337 File Offset: 0x0025C537
		public Line(LineControl A_0) : base(A_0, ControlTypeEnum.Line)
		{
			this.o0_0oO.OooO. = A_0;
		}

		/// <summary>
		/// 线条方向
		/// </summary>
		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x0600582A RID: 22570 RVA: 0x0025E349 File Offset: 0x0025C549
		// (set) Token: 0x0600582B RID: 22571 RVA: 0x0025E356 File Offset: 0x0025C556
		public LineDirectionEnum Ditection
		{
			get
			{
				return this.o0_0oO.OooO..Direction;
			}
			set
			{
				this.o0_0oO.OooO..Direction = value;
			}
		}

		/// <summary>
		/// 线条宽度
		/// </summary>
		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x0600582C RID: 22572 RVA: 0x0025E364 File Offset: 0x0025C564
		// (set) Token: 0x0600582D RID: 22573 RVA: 0x0025E371 File Offset: 0x0025C571
		public int Thickness
		{
			get
			{
				return this.o0_0oO.OooO..Thickness;
			}
			set
			{
				this.o0_0oO.OooO..Thickness = value;
			}
		}

		/// <summary>
		/// 线条样式
		/// </summary>
		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x0600582E RID: 22574 RVA: 0x0025E37F File Offset: 0x0025C57F
		// (set) Token: 0x0600582F RID: 22575 RVA: 0x0025E38C File Offset: 0x0025C58C
		public DashStyleEnum DashStyle
		{
			get
			{
				return this.o0_0oO.OooO..DashStyle;
			}
			set
			{
				this.o0_0oO.OooO..DashStyle = value;
			}
		}

		/// <summary>
		/// 线条颜色
		/// </summary>
		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06005830 RID: 22576 RVA: 0x0025E39A File Offset: 0x0025C59A
		// (set) Token: 0x06005831 RID: 22577 RVA: 0x0025E3A7 File Offset: 0x0025C5A7
		public Color LineColor
		{
			get
			{
				return this.o0_0oO.OooO..ForeColor;
			}
			set
			{
				this.o0_0oO.OooO..ForeColor = value;
				this.o0_0oO.OooO..Invalidate();
			}
		}

		// Token: 0x04002306 RID: 8966
		private LineControl <<EMPTY_NAME>>;
	}
}
