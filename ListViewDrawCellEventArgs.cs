using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020001AA RID: 426
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ListViewDrawCellEventArgs : ControlEventArgs
	{
		// Token: 0x060014E3 RID: 5347 RVA: 0x0009744B File Offset: 0x0009564B
		public ListViewDrawCellEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, ListViewRow A_2, ListViewColumn A_3, DrawListViewSubItemEventArgs A_4) : base(A_0, A_1)
		{
			this.oo.oO_. = A_2;
			this.oo.oO_. = A_3;
			this.oo.oO_. = A_4;
		}

		/// <summary>
		///  正在绘制的行
		/// </summary>
		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x0009746C File Offset: 0x0009566C
		public ListViewRow Row
		{
			get
			{
				return this.oo.oO_.;
			}
		}

		/// <summary>
		/// 正在绘制的列
		/// </summary>
		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x00097474 File Offset: 0x00095674
		public ListViewColumn Col
		{
			get
			{
				return this.oo.oO_.;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0009747C File Offset: 0x0009567C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int RowIndex
		{
			get
			{
				return this.oo.oO_..Index;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x00097489 File Offset: 0x00095689
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int ColIndex
		{
			get
			{
				return this.oo.oO_..Index;
			}
		}

		/// <summary>
		/// 用默认的方式绘制单元格的文本内容
		/// </summary>
		// Token: 0x060014E8 RID: 5352 RVA: 0x00097496 File Offset: 0x00095696
		public void DrawText()
		{
			this.oo.oO_..DrawText();
		}

		/// <summary>
		/// 用默认的当时绘制单元格背景
		/// </summary>
		// Token: 0x060014E9 RID: 5353 RVA: 0x000974A3 File Offset: 0x000956A3
		public void DrawBackground()
		{
			this.oo.oO_..DrawBackground();
		}

		/// <summary>
		/// 是否取消系统默认的绘制单元格动作，此属性默认为True，必须设置为False才能编码绘制单元格
		/// </summary>
		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x000974B0 File Offset: 0x000956B0
		// (set) Token: 0x060014EB RID: 5355 RVA: 0x000974BD File Offset: 0x000956BD
		public bool DrawDefault
		{
			get
			{
				return this.oo.oO_..DrawDefault;
			}
			set
			{
				this.oo.oO_..DrawDefault = value;
			}
		}

		/// <summary>
		/// 返回一个Graphics对象，通过这个对象可以在单元格中绘制图形
		/// </summary>
		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x000974CB File Offset: 0x000956CB
		public Graphics Graphics
		{
			get
			{
				return this.oo.oO_..Graphics;
			}
		}

		/// <summary>
		/// 要绘制单元格的水平坐标位置，单位为像素
		/// </summary>
		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x000974D8 File Offset: 0x000956D8
		public int x
		{
			get
			{
				return this.oo.oO_..Bounds.X;
			}
		}

		/// <summary>
		/// 要绘制单元格的垂直坐标位置，单位为像素
		/// </summary>
		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x000974F8 File Offset: 0x000956F8
		public int y
		{
			get
			{
				return this.oo.oO_..Bounds.Y;
			}
		}

		/// <summary>
		/// 要绘制单元格的宽度，单位为像素
		/// </summary>
		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x00097518 File Offset: 0x00095718
		public int Width
		{
			get
			{
				return this.oo.oO_..Bounds.Width;
			}
		}

		/// <summary>
		/// 要绘制单元格的高度，单位为像素
		/// </summary>
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00097538 File Offset: 0x00095738
		public int Height
		{
			get
			{
				return this.oo.oO_..Bounds.Height;
			}
		}

		// Token: 0x04000846 RID: 2118
		private ListViewRow <<EMPTY_NAME>>;

		// Token: 0x04000847 RID: 2119
		private ListViewColumn <<EMPTY_NAME>>;

		// Token: 0x04000848 RID: 2120
		private DrawListViewSubItemEventArgs <<EMPTY_NAME>>;
	}
}
