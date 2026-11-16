using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1FlexGrid;

namespace Foxtable
{
	// Token: 0x02000330 RID: 816
	[ComVisible(true)]
	[oO0oooo("0656")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CellStyle
	{
		// Token: 0x06002D70 RID: 11632 RVA: 0x0014EBC6 File Offset: 0x0014CDC6
		public CellStyle(DataTable A_0, string A_1)
		{
			this.oOO.oO_____OO_. = A_0;
			this.oOO.oO_____OO_. = A_1;
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x0014EBDC File Offset: 0x0014CDDC
		// (set) Token: 0x06002D72 RID: 11634 RVA: 0x0014EC48 File Offset: 0x0014CE48
		public Color BackColor
		{
			get
			{
				Color backColor;
				if (OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
				{
					backColor = OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles[this.oOO.oO_____OO_.].BackColor;
				}
				return backColor;
			}
			set
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this.oOO.oO_____OO_. && table.foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
						{
							table.foxGrid.Styles[this.oOO.oO_____OO_.].BackColor = value;
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 字体颜色
		/// </summary>
		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002D73 RID: 11635 RVA: 0x0014ECD0 File Offset: 0x0014CED0
		// (set) Token: 0x06002D74 RID: 11636 RVA: 0x0014ED3C File Offset: 0x0014CF3C
		public Color ForeColor
		{
			get
			{
				Color foreColor;
				if (OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
				{
					foreColor = OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles[this.oOO.oO_____OO_.].ForeColor;
				}
				return foreColor;
			}
			set
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this.oOO.oO_____OO_. && table.foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
						{
							table.foxGrid.Styles[this.oOO.oO_____OO_.].ForeColor = value;
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 边框颜色
		/// </summary>
		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x0014EDC4 File Offset: 0x0014CFC4
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x0014EE34 File Offset: 0x0014D034
		public Color BorderColor
		{
			get
			{
				Color color;
				if (OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
				{
					color = OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles[this.oOO.oO_____OO_.].Border.Color;
				}
				return color;
			}
			set
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this.oOO.oO_____OO_. && table.foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
						{
							table.foxGrid.Styles[this.oOO.oO_____OO_.].Border.Color = value;
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 字体是否加粗
		/// </summary>
		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x0014EEC0 File Offset: 0x0014D0C0
		// (set) Token: 0x06002D78 RID: 11640 RVA: 0x0014EF30 File Offset: 0x0014D130
		public bool FontBold
		{
			get
			{
				bool bold;
				if (OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
				{
					bold = OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles[this.oOO.oO_____OO_.].Font.Bold;
				}
				return bold;
			}
			set
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this.oOO.oO_____OO_. && table.foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
						{
							CellStyle cellStyle = table.foxGrid.Styles[this.oOO.oO_____OO_.];
							if (value)
							{
								cellStyle.Font = new Font(cellStyle.Font, cellStyle.Font.Style | FontStyle.Bold);
							}
							else if ((cellStyle.Font.Style & FontStyle.Bold) == FontStyle.Bold)
							{
								cellStyle.Font = new Font(cellStyle.Font, cellStyle.Font.Style ^ FontStyle.Bold);
							}
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 字体是否斜体
		/// </summary>
		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x0014F010 File Offset: 0x0014D210
		// (set) Token: 0x06002D7A RID: 11642 RVA: 0x0014F080 File Offset: 0x0014D280
		public bool FontItalic
		{
			get
			{
				bool italic;
				if (OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
				{
					italic = OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles[this.oOO.oO_____OO_.].Font.Italic;
				}
				return italic;
			}
			set
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this.oOO.oO_____OO_. && table.foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
						{
							CellStyle cellStyle = table.foxGrid.Styles[this.oOO.oO_____OO_.];
							if (value)
							{
								cellStyle.Font = new Font(cellStyle.Font, cellStyle.Font.Style | FontStyle.Italic);
							}
							else if ((cellStyle.Font.Style & FontStyle.Italic) == FontStyle.Italic)
							{
								cellStyle.Font = new Font(cellStyle.Font, cellStyle.Font.Style ^ FontStyle.Italic);
							}
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 是否有下划线
		/// </summary>
		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x0014F160 File Offset: 0x0014D360
		// (set) Token: 0x06002D7C RID: 11644 RVA: 0x0014F1D0 File Offset: 0x0014D3D0
		public bool FontUnderline
		{
			get
			{
				bool underline;
				if (OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
				{
					underline = OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles[this.oOO.oO_____OO_.].Font.Underline;
				}
				return underline;
			}
			set
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this.oOO.oO_____OO_. && table.foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
						{
							CellStyle cellStyle = table.foxGrid.Styles[this.oOO.oO_____OO_.];
							if (value)
							{
								cellStyle.Font = new Font(cellStyle.Font, cellStyle.Font.Style | FontStyle.Underline);
							}
							else if ((cellStyle.Font.Style & FontStyle.Underline) == FontStyle.Underline)
							{
								cellStyle.Font = new Font(cellStyle.Font, cellStyle.Font.Style ^ FontStyle.Underline);
							}
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 是否显示删除线
		/// </summary>
		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x0014F2B0 File Offset: 0x0014D4B0
		// (set) Token: 0x06002D7E RID: 11646 RVA: 0x0014F320 File Offset: 0x0014D520
		public bool FontStrikeout
		{
			get
			{
				bool strikeout;
				if (OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
				{
					strikeout = OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles[this.oOO.oO_____OO_.].Font.Strikeout;
				}
				return strikeout;
			}
			set
			{
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (table.DataTable == this.oOO.oO_____OO_. && table.foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
						{
							CellStyle cellStyle = table.foxGrid.Styles[this.oOO.oO_____OO_.];
							if (value)
							{
								cellStyle.Font = new Font(cellStyle.Font, cellStyle.Font.Style | FontStyle.Strikeout);
							}
							else if ((cellStyle.Font.Style & FontStyle.Strikeout) == FontStyle.Strikeout)
							{
								cellStyle.Font = new Font(cellStyle.Font, cellStyle.Font.Style ^ FontStyle.Strikeout);
							}
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 初始化样式
		/// </summary>
		// Token: 0x06002D7F RID: 11647 RVA: 0x0014F400 File Offset: 0x0014D600
		public void Clear()
		{
			if (OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles.Contains(this.oOO.oO_____OO_.))
			{
				OO_00oOO.Tables[this.oOO.oO_____OO_..Name].foxGrid.Styles[this.oOO.oO_____OO_.].Clear();
			}
		}

		// Token: 0x0400126B RID: 4715
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x0400126C RID: 4716
		private string <<EMPTY_NAME>>;
	}
}
