using System;
using System.ComponentModel;
using System.Drawing;
using C1.Win.C1FlexGrid;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000301 RID: 769
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class DrawCellEventArgs
	{
		// Token: 0x060029B5 RID: 10677 RVA: 0x0012AED0 File Offset: 0x001290D0
		public DrawCellEventArgs(Table A_0, Row A_1, Col A_2, OwnerDrawCellEventArgs A_3, C1FlexGrid A_4, bool A_5)
		{
			this.ooo_OOO.O0O. = A_0;
			this.oOOo__O0O0.0O. = A_1;
			this.oOOo__O0O0.0O. = A_2;
			this.oOOo__O0O0.0O. = A_3;
			this.oOOo__O0O0.0O. = A_4;
			this.oOOo__O0O0.0O. = A_5;
		}

		/// <summary>
		/// 鼠标是否悬停在此单元格
		/// </summary>
		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x0012AF08 File Offset: 0x00129108
		public bool MouseHover
		{
			get
			{
				bool result;
				if (this.oOOo__O0O0.0O..MouseRow == this.oOOo__O0O0.0O..Row && this.oOOo__O0O0.0O..MouseCol == this.oOOo__O0O0.0O..Col)
				{
					result = true;
				}
				return result;
			}
		}

		/// <summary>
		/// 触发事件的Table
		/// </summary>
		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060029B7 RID: 10679 RVA: 0x0012AF48 File Offset: 0x00129148
		public Table Table
		{
			get
			{
				return this.ooo_OOO.O0O.;
			}
		}

		/// <summary>
		/// 触发事件的Row
		/// </summary>
		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060029B8 RID: 10680 RVA: 0x0012AF50 File Offset: 0x00129150
		public Row Row
		{
			get
			{
				return this.oOOo__O0O0.0O.;
			}
		}

		/// <summary>
		/// 触发事件的Col
		/// </summary>
		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x0012AF58 File Offset: 0x00129158
		public Col Col
		{
			get
			{
				return this.oOOo__O0O0.0O.;
			}
		}

		/// <summary>
		/// 获取或者设置要绘制的文本内容
		/// </summary>
		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x0012AF60 File Offset: 0x00129160
		// (set) Token: 0x060029BB RID: 10683 RVA: 0x0012AF6D File Offset: 0x0012916D
		public string Text
		{
			get
			{
				return this.oOOo__O0O0.0O..Text;
			}
			set
			{
				this.oOOo__O0O0.0O..Text = value;
			}
		}

		/// <summary>
		/// 是否是因为打印表而触发了DrawCell事件
		/// </summary>
		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x0012AF7B File Offset: 0x0012917B
		public bool IsPrint
		{
			get
			{
				return this.oOOo__O0O0.0O.;
			}
		}

		/// <summary>
		/// 获取或设置要打印的Image对象
		/// </summary>
		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x0012AF83 File Offset: 0x00129183
		// (set) Token: 0x060029BE RID: 10686 RVA: 0x0012AF90 File Offset: 0x00129190
		public Image Image
		{
			get
			{
				return this.oOOo__O0O0.0O..Image;
			}
			set
			{
				this.oOOo__O0O0.0O..Image = value;
			}
		}

		/// <summary>
		/// 设置自定义样式的名称
		/// </summary>
		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060029BF RID: 10687 RVA: 0x0012AF9E File Offset: 0x0012919E
		// (set) Token: 0x060029C0 RID: 10688 RVA: 0x0012AFA6 File Offset: 0x001291A6
		public string Style
		{
			get
			{
				return this.ooo_OOO.O0O.;
			}
			set
			{
				this.ooo_OOO.O0O. = value;
			}
		}

		/// <summary>
		/// 回一个Graphics对象，通过这个对象可以在单元格中绘制图形
		/// </summary>
		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060029C1 RID: 10689 RVA: 0x0012AFAF File Offset: 0x001291AF
		public Graphics Graphics
		{
			get
			{
				return this.oOOo__O0O0.0O..Graphics;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x0012AFBC File Offset: 0x001291BC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rectangle Bounds
		{
			get
			{
				return this.oOOo__O0O0.0O..Bounds;
			}
		}

		/// <summary>
		///  要绘制单元格的水平坐标位置，单位为像素
		/// </summary>
		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x0012AFCC File Offset: 0x001291CC
		public int X
		{
			get
			{
				return this.Bounds.X;
			}
		}

		/// <summary>
		///  要绘制单元格的水平垂直坐标位置，单位为像素
		/// </summary>
		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x0012AFE8 File Offset: 0x001291E8
		public int Y
		{
			get
			{
				return this.Bounds.Y;
			}
		}

		/// <summary>
		/// 要绘制单元格的宽度，单位为像素
		/// </summary>
		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x0012B004 File Offset: 0x00129204
		public int Width
		{
			get
			{
				return this.Bounds.Width;
			}
		}

		/// <summary>
		/// 要绘制单元格的高度，单位为像素
		/// </summary>
		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x0012B020 File Offset: 0x00129220
		public int Height
		{
			get
			{
				return this.Bounds.Height;
			}
		}

		/// <summary>
		/// 开始绘图
		/// </summary>
		// Token: 0x060029C7 RID: 10695 RVA: 0x0012B03B File Offset: 0x0012923B
		public void StartDraw()
		{
			if (!this.oOOo__O0O0.0O.)
			{
				this.oOOo__O0O0.0O..DrawCell(DrawCellFlags.Background | DrawCellFlags.Border);
			}
			this.O0O__O._0. = true;
		}

		/// <summary>
		/// 结束绘图
		/// </summary>
		// Token: 0x060029C8 RID: 10696 RVA: 0x0012B058 File Offset: 0x00129258
		public void EndDraw()
		{
			if (Operators.CompareString(this.Text, "", true) > 0)
			{
				this.oOOo__O0O0.0O..Text = this.Text;
			}
			if (!this.oOOo__O0O0.0O.)
			{
				if (Operators.CompareString(this.Style, "", true) > 0 && this.oOOo__O0O0.0O..Styles.Contains("User" + this.Style))
				{
					this.oOOo__O0O0.0O..Style = this.oOOo__O0O0.0O..Styles["User" + this.Style];
				}
				this.oOOo__O0O0.0O..DrawCell(DrawCellFlags.Content);
				this.oOOo__O0O0.0O..Handled = true;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060029C9 RID: 10697 RVA: 0x0012B10B File Offset: 0x0012930B
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		/// <summary>
		/// 单元格图表
		/// </summary>
		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060029CA RID: 10698 RVA: 0x0012B118 File Offset: 0x00129318
		[oO0oooo("3740")]
		public CellChart Chart
		{
			get
			{
				if (this.oOOo__O0O0.0O. == null)
				{
					this.oOOo__O0O0.0O. = new CellChart();
				}
				return this.oOOo__O0O0.0O.;
			}
		}

		/// <summary>
		/// 绘制单元格图表
		/// </summary>
		// Token: 0x060029CB RID: 10699 RVA: 0x0012B134 File Offset: 0x00129334
		[oO0oooo("3740")]
		public void DrawChart()
		{
			this.Text = "";
			if (this.oOOo__O0O0.0O..Values.Count < 2 || this.oOOo__O0O0.0O..Bounds.Width <= 0 || this.oOOo__O0O0.0O..Bounds.Height <= 0 || this.oOOo__O0O0.0O..Bounds.Width < this.oOOo__O0O0.0O..Space * 2 || this.oOOo__O0O0.0O..Bounds.Height < this.oOOo__O0O0.0O..Space * 2)
			{
				this.oOOo__O0O0.0O..DrawCell();
				this.oOOo__O0O0.0O..SetUserData(this.oOOo__O0O0.0O..Row, this.oOOo__O0O0.0O..Col, null);
				return;
			}
			this.oOOo__O0O0.0O..SetUserData(this.oOOo__O0O0.0O..Row, this.oOOo__O0O0.0O..Col, string.Concat(new string[]
			{
				"@{",
				Conversions.ToString(this.oOOo__O0O0.0O..Values.Count),
				",",
				Conversions.ToString(this.oOOo__O0O0.0O..Space),
				"}"
			}));
			Rectangle rectangle;
			if (this.oOOo__O0O0.0O..StartingValue == -1.7976931348623157E+308)
			{
				rectangle = this.oOOo__O0O0.0O..Bounds;
			}
			else
			{
				rectangle = this.Table.o.oO__OO_oo_0_.(this.oOOo__O0O0.0O..Bounds, this.oOOo__O0O0.0O..Row, this.oOOo__O0O0.0O..Col);
				int num = this.oOOo__O0O0.0O..Values.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					this.oOOo__O0O0.0O..Values[i] = this.oOOo__O0O0.0O..Values[i] - this.oOOo__O0O0.0O..StartingValue;
				}
				this.oOOo__O0O0.0O..AddValues(new object[]
				{
					0
				});
			}
			rectangle.Inflate(-this.Chart.Space, -this.Chart.Space);
			this.oOOo__O0O0.0O..Width = rectangle.Width;
			this.oOOo__O0O0.0O..Height = rectangle.Height;
			this.oOOo__O0O0.0O..BackColor = Color.White;
			this.StartDraw();
			this.Chart.Data = this.Chart.Values;
			Bitmap bitmap = new Bitmap(this.oOOo__O0O0.0O..Width, this.oOOo__O0O0.0O..Height);
			this.Chart.DrawToBitmap(bitmap, this.Chart.Bounds);
			this.oOOo__O0O0.0O..Graphics.DrawImageUnscaled(bitmap, new Point(this.oOOo__O0O0.0O..Bounds.X + this.Chart.Space, this.oOOo__O0O0.0O..Bounds.Y + this.Chart.Space));
			this.EndDraw();
			this.oOOo__O0O0.0O..Values.Clear();
			this.oOOo__O0O0.0O..Dispose();
		}

		// Token: 0x04001142 RID: 4418
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001143 RID: 4419
		private Row <<EMPTY_NAME>>;

		// Token: 0x04001144 RID: 4420
		private Col <<EMPTY_NAME>>;

		// Token: 0x04001145 RID: 4421
		private string <<EMPTY_NAME>>;

		// Token: 0x04001146 RID: 4422
		private OwnerDrawCellEventArgs <<EMPTY_NAME>>;

		// Token: 0x04001147 RID: 4423
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001148 RID: 4424
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001149 RID: 4425
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400114A RID: 4426
		private CellChart <<EMPTY_NAME>>;
	}
}
