using System;
using System.ComponentModel;
using System.Drawing;
using C1.C1Excel;

namespace Foxtable.XLS
{
	/// <summary>
	/// Excel工作表
	/// </summary>
	// Token: 0x020004FD RID: 1277
	public class Sheet
	{
		// Token: 0x0600536B RID: 21355 RVA: 0x00256124 File Offset: 0x00254324
		internal Sheet(XLSheet A_0)
		{
			this.Ooo_O__.0. = A_0;
			this.Ooo_O__.0. = new PrintSetting(A_0.PrintSettings);
		}

		/// <summary>
		/// 打印设置
		/// </summary>
		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x0600536C RID: 21356 RVA: 0x00256144 File Offset: 0x00254344
		[oO0oooo("1312")]
		public PrintSetting PrintSetting
		{
			get
			{
				return this.Ooo_O__.0.;
			}
		}

		/// <summary>
		/// 返回或设置默认列宽，单位为像素
		/// </summary>
		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x0600536D RID: 21357 RVA: 0x0025614C File Offset: 0x0025434C
		// (set) Token: 0x0600536E RID: 21358 RVA: 0x0025615F File Offset: 0x0025435F
		[oO0oooo("1152")]
		public int DefaultColumnWidth
		{
			get
			{
				return C1XLBook.TwipsToPixels((double)this.Ooo_O__.0..DefaultColumnWidth);
			}
			set
			{
				this.Ooo_O__.0..DefaultColumnWidth = C1XLBook.PixelsToTwips((double)value);
			}
		}

		/// <summary>
		/// 返回或设置默认行高，单位为像素
		/// </summary>
		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x0600536F RID: 21359 RVA: 0x00256173 File Offset: 0x00254373
		// (set) Token: 0x06005370 RID: 21360 RVA: 0x00256186 File Offset: 0x00254386
		[oO0oooo("1152")]
		public int DefaultRowHeight
		{
			get
			{
				return C1XLBook.TwipsToPixels((double)this.Ooo_O__.0..DefaultRowHeight);
			}
			set
			{
				this.Ooo_O__.0..DefaultRowHeight = C1XLBook.PixelsToTwips((double)value);
			}
		}

		/// <summary>
		/// 设置网格线颜色
		/// </summary>
		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06005371 RID: 21361 RVA: 0x0025619A File Offset: 0x0025439A
		// (set) Token: 0x06005372 RID: 21362 RVA: 0x002561A7 File Offset: 0x002543A7
		[oO0oooo("1152")]
		public Color GridColor
		{
			get
			{
				return this.Ooo_O__.0..GridColor;
			}
			set
			{
				this.Ooo_O__.0..GridColor = value;
			}
		}

		/// <summary>
		/// 是否显示网格线
		/// </summary>
		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06005373 RID: 21363 RVA: 0x002561B5 File Offset: 0x002543B5
		// (set) Token: 0x06005374 RID: 21364 RVA: 0x002561C2 File Offset: 0x002543C2
		[oO0oooo("1152")]
		public bool ShowGridLines
		{
			get
			{
				return this.Ooo_O__.0..ShowGridLines;
			}
			set
			{
				this.Ooo_O__.0..ShowGridLines = value;
			}
		}

		/// <summary>
		/// 是否显示表头
		/// </summary>
		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06005375 RID: 21365 RVA: 0x002561D0 File Offset: 0x002543D0
		// (set) Token: 0x06005376 RID: 21366 RVA: 0x002561DD File Offset: 0x002543DD
		[oO0oooo("1152")]
		public bool ShowHeaders
		{
			get
			{
				return this.Ooo_O__.0..ShowHeaders;
			}
			set
			{
				this.Ooo_O__.0..ShowHeaders = value;
			}
		}

		/// <summary>
		/// 是否显示此工作表
		/// </summary>
		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06005377 RID: 21367 RVA: 0x002561EB File Offset: 0x002543EB
		// (set) Token: 0x06005378 RID: 21368 RVA: 0x002561F8 File Offset: 0x002543F8
		[oO0oooo("1152")]
		public bool Visible
		{
			get
			{
				return this.Ooo_O__.0..Visible;
			}
			set
			{
				this.Ooo_O__.0..Visible = true;
			}
		}

		/// <summary>
		/// 是否锁定此工作表，禁止用户编辑
		/// </summary>
		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x06005379 RID: 21369 RVA: 0x00256206 File Offset: 0x00254406
		// (set) Token: 0x0600537A RID: 21370 RVA: 0x00256213 File Offset: 0x00254413
		[oO0oooo("1152")]
		public bool Locked
		{
			get
			{
				return this.Ooo_O__.0..Locked;
			}
			set
			{
				this.Ooo_O__.0..Locked = true;
			}
		}

		/// <summary>
		/// 返回行的集合，可以通过此集合获得指定位置的行
		/// </summary>
		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x0600537B RID: 21371 RVA: 0x00256221 File Offset: 0x00254421
		public RowCollection Rows
		{
			get
			{
				if (this.a == null)
				{
					this.a = new RowCollection(this.Ooo_O__.0..Rows);
				}
				return this.a;
			}
		}

		/// <summary>
		/// 返回列的集合，可以通过此集合获得指定位置的列
		/// </summary>
		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x0600537C RID: 21372 RVA: 0x00256247 File Offset: 0x00254447
		public ColColection Cols
		{
			get
			{
				if (this.a == null)
				{
					this.a = new ColColection(this.Ooo_O__.0..Columns);
				}
				return this.a;
			}
		}

		// Token: 0x1700123D RID: 4669
		[EditorBrowsable(EditorBrowsableState.Always)]
		public Cell this[int Row, int Col]
		{
			get
			{
				return new Cell(this.Ooo_O__.0., Row, Col);
			}
		}

		/// <summary>
		/// 合并单元格
		/// </summary>
		/// <param name="RowFrom">合并起始行</param>
		/// <param name="ColFrom">合并起始列</param>
		/// <param name="RowCount">合并行数</param>
		/// <param name="ColCount">合并列数</param>
		// Token: 0x0600537E RID: 21374 RVA: 0x0025627C File Offset: 0x0025447C
		[oO0oooo("1153")]
		public void MergeCell(int RowFrom, int ColFrom, int RowCount, int ColCount)
		{
			this.Ooo_O__.0..MergedCells.Add(RowFrom, ColFrom, RowCount, ColCount);
		}

		/// <summary>
		/// 用于取消所有合并单元格
		/// </summary>
		// Token: 0x0600537F RID: 21375 RVA: 0x00256294 File Offset: 0x00254494
		public void ClearMergedCells()
		{
			this.Ooo_O__.0..MergedCells.Clear();
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x06005380 RID: 21376 RVA: 0x002562A6 File Offset: 0x002544A6
		[EditorBrowsable(EditorBrowsableState.Never)]
		public XLPrintSettings PrintSettings
		{
			get
			{
				return this.Ooo_O__.0..PrintSettings;
			}
		}

		/// <summary>
		/// 返回或设置工作表名称
		/// </summary>
		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x06005381 RID: 21377 RVA: 0x002562B3 File Offset: 0x002544B3
		// (set) Token: 0x06005382 RID: 21378 RVA: 0x002562C0 File Offset: 0x002544C0
		public string Name
		{
			get
			{
				return this.Ooo_O__.0..Name;
			}
			set
			{
				this.Ooo_O__.0..Name = value;
			}
		}

		// Token: 0x040022A0 RID: 8864
		internal XLSheet <<EMPTY_NAME>>;

		// Token: 0x040022A1 RID: 8865
		private PrintSetting <<EMPTY_NAME>>;

		// Token: 0x040022A2 RID: 8866
		private RowCollection a;

		// Token: 0x040022A3 RID: 8867
		private ColColection a;
	}
}
