using System;
using System.Drawing;
using C1.C1Excel;

namespace Foxtable.XLS
{
	// Token: 0x02000500 RID: 1280
	public class Style
	{
		// Token: 0x0600539C RID: 21404 RVA: 0x002564CC File Offset: 0x002546CC
		internal Style(XLStyle A_0)
		{
			this.Ooo_O__.0. = A_0;
		}

		/// <summary>
		/// 设置水平对齐方式
		/// </summary>
		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x0600539D RID: 21405 RVA: 0x002564DB File Offset: 0x002546DB
		// (set) Token: 0x0600539E RID: 21406 RVA: 0x002564E8 File Offset: 0x002546E8
		[oO0oooo("1161")]
		public AlignHorzEnum AlignHorz
		{
			get
			{
				return (AlignHorzEnum)this.Ooo_O__.0..AlignHorz;
			}
			set
			{
				this.Ooo_O__.0..AlignHorz = (XLAlignHorzEnum)value;
			}
		}

		/// <summary>
		/// 设置垂直对齐方式
		/// </summary>
		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x0600539F RID: 21407 RVA: 0x002564F6 File Offset: 0x002546F6
		// (set) Token: 0x060053A0 RID: 21408 RVA: 0x00256503 File Offset: 0x00254703
		[oO0oooo("1161")]
		public AlignVertEnum AlignVert
		{
			get
			{
				return (AlignVertEnum)this.Ooo_O__.0..AlignVert;
			}
			set
			{
				this.Ooo_O__.0..AlignVert = (XLAlignVertEnum)value;
			}
		}

		/// <summary>
		/// 背景颜色
		/// </summary>
		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x060053A1 RID: 21409 RVA: 0x00256511 File Offset: 0x00254711
		// (set) Token: 0x060053A2 RID: 21410 RVA: 0x0025651E File Offset: 0x0025471E
		public Color BackColor
		{
			get
			{
				return this.Ooo_O__.0..BackColor;
			}
			set
			{
				this.Ooo_O__.0..BackColor = value;
			}
		}

		/// <summary>
		/// 返回或设置下边框的类型
		/// </summary>
		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x060053A3 RID: 21411 RVA: 0x0025652C File Offset: 0x0025472C
		// (set) Token: 0x060053A4 RID: 21412 RVA: 0x00256539 File Offset: 0x00254739
		[oO0oooo("1163")]
		public LineStyleEnum BorderBottom
		{
			get
			{
				return (LineStyleEnum)this.Ooo_O__.0..BorderBottom;
			}
			set
			{
				this.Ooo_O__.0..BorderBottom = (XLLineStyleEnum)value;
			}
		}

		/// <summary>
		/// 返回或设置下边框的颜色
		/// </summary>
		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x060053A5 RID: 21413 RVA: 0x00256548 File Offset: 0x00254748
		// (set) Token: 0x060053A6 RID: 21414 RVA: 0x00256555 File Offset: 0x00254755
		[oO0oooo("1163")]
		public Color BorderColorBottom
		{
			get
			{
				return this.Ooo_O__.0..BorderColorBottom;
			}
			set
			{
				this.Ooo_O__.0..BorderColorBottom = value;
			}
		}

		/// <summary>
		/// 返回或设置左边框的类型
		/// </summary>
		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x060053A7 RID: 21415 RVA: 0x00256563 File Offset: 0x00254763
		// (set) Token: 0x060053A8 RID: 21416 RVA: 0x00256570 File Offset: 0x00254770
		[oO0oooo("1163")]
		public LineStyleEnum BorderLeft
		{
			get
			{
				return (LineStyleEnum)this.Ooo_O__.0..BorderLeft;
			}
			set
			{
				this.Ooo_O__.0..BorderLeft = (XLLineStyleEnum)value;
			}
		}

		/// <summary>
		/// 返回或设置左边框的颜色
		/// </summary>
		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x060053A9 RID: 21417 RVA: 0x0025657F File Offset: 0x0025477F
		// (set) Token: 0x060053AA RID: 21418 RVA: 0x0025658C File Offset: 0x0025478C
		[oO0oooo("1163")]
		public Color BorderColorLeft
		{
			get
			{
				return this.Ooo_O__.0..BorderColorLeft;
			}
			set
			{
				this.Ooo_O__.0..BorderColorLeft = value;
			}
		}

		/// <summary>
		/// 返回或设置上边框的类型
		/// </summary>
		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x060053AB RID: 21419 RVA: 0x0025659A File Offset: 0x0025479A
		// (set) Token: 0x060053AC RID: 21420 RVA: 0x002565A7 File Offset: 0x002547A7
		[oO0oooo("1163")]
		public LineStyleEnum BorderTop
		{
			get
			{
				return (LineStyleEnum)this.Ooo_O__.0..BorderTop;
			}
			set
			{
				this.Ooo_O__.0..BorderTop = (XLLineStyleEnum)value;
			}
		}

		/// <summary>
		/// 返回或设置上边框的颜色
		/// </summary>
		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x060053AD RID: 21421 RVA: 0x002565B6 File Offset: 0x002547B6
		// (set) Token: 0x060053AE RID: 21422 RVA: 0x002565C3 File Offset: 0x002547C3
		[oO0oooo("1163")]
		public Color BorderColorTop
		{
			get
			{
				return this.Ooo_O__.0..BorderColorTop;
			}
			set
			{
				this.Ooo_O__.0..BorderColorTop = value;
			}
		}

		/// <summary>
		/// 返回或设置右边框的类型
		/// </summary>
		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x060053AF RID: 21423 RVA: 0x002565D1 File Offset: 0x002547D1
		// (set) Token: 0x060053B0 RID: 21424 RVA: 0x002565DE File Offset: 0x002547DE
		[oO0oooo("1163")]
		public LineStyleEnum BorderRight
		{
			get
			{
				return (LineStyleEnum)this.Ooo_O__.0..BorderRight;
			}
			set
			{
				this.Ooo_O__.0..BorderRight = (XLLineStyleEnum)value;
			}
		}

		/// <summary>
		/// 返回或设置右边框的颜色
		/// </summary>
		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x060053B1 RID: 21425 RVA: 0x002565ED File Offset: 0x002547ED
		// (set) Token: 0x060053B2 RID: 21426 RVA: 0x002565FA File Offset: 0x002547FA
		[oO0oooo("1163")]
		public Color BorderColorRight
		{
			get
			{
				return this.Ooo_O__.0..BorderColorRight;
			}
			set
			{
				this.Ooo_O__.0..BorderColorRight = value;
			}
		}

		/// <summary>
		/// 返回或设置斜线的方向
		/// </summary>
		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x060053B3 RID: 21427 RVA: 0x00256608 File Offset: 0x00254808
		// (set) Token: 0x060053B4 RID: 21428 RVA: 0x00256615 File Offset: 0x00254815
		[oO0oooo("1164")]
		public DiagonalEnum Diagonal
		{
			get
			{
				return (DiagonalEnum)this.Ooo_O__.0..Diagonal;
			}
			set
			{
				this.Ooo_O__.0..Diagonal = (XLDiagonalFlags)value;
			}
		}

		/// <summary>
		/// 返回或设置斜线的颜色
		/// </summary>
		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x060053B5 RID: 21429 RVA: 0x00256624 File Offset: 0x00254824
		// (set) Token: 0x060053B6 RID: 21430 RVA: 0x00256631 File Offset: 0x00254831
		[oO0oooo("1164")]
		public Color DiagonalColor
		{
			get
			{
				return this.Ooo_O__.0..DiagonalColor;
			}
			set
			{
				this.Ooo_O__.0..DiagonalColor = value;
			}
		}

		/// <summary>
		/// 返回或设置斜线的类型
		/// </summary>
		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x060053B7 RID: 21431 RVA: 0x0025663F File Offset: 0x0025483F
		// (set) Token: 0x060053B8 RID: 21432 RVA: 0x0025664C File Offset: 0x0025484C
		[oO0oooo("1164")]
		public LineStyleEnum DiagonalStyle
		{
			get
			{
				return (LineStyleEnum)this.Ooo_O__.0..DiagonalStyle;
			}
			set
			{
				this.Ooo_O__.0..DiagonalStyle = (XLLineStyleEnum)value;
			}
		}

		/// <summary>
		/// 单元格字体
		/// </summary>
		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x060053B9 RID: 21433 RVA: 0x0025665C File Offset: 0x0025485C
		// (set) Token: 0x060053BA RID: 21434 RVA: 0x00256696 File Offset: 0x00254896
		public Font Font
		{
			get
			{
				Font result;
				if (this.Ooo_O__.0..Font != null)
				{
					result = this.Ooo_O__.0..Font;
				}
				else
				{
					result = new Font("宋体", 12f, FontStyle.Regular);
				}
				return result;
			}
			set
			{
				this.Ooo_O__.0..Font = value;
			}
		}

		/// <summary>
		/// 单元格字体名
		/// </summary>
		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x060053BB RID: 21435 RVA: 0x002566A4 File Offset: 0x002548A4
		// (set) Token: 0x060053BC RID: 21436 RVA: 0x002566B1 File Offset: 0x002548B1
		public string FontName
		{
			get
			{
				return this.Font.Name;
			}
			set
			{
				this.Font = new Font(value, this.Font.Size, this.Font.Style);
			}
		}

		/// <summary>
		/// 单元格字体大小
		/// </summary>
		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x060053BD RID: 21437 RVA: 0x002566D5 File Offset: 0x002548D5
		// (set) Token: 0x060053BE RID: 21438 RVA: 0x002566E2 File Offset: 0x002548E2
		public float FontSize
		{
			get
			{
				return this.Font.Size;
			}
			set
			{
				this.Font = new Font(this.Font.Name, value, this.Font.Style);
			}
		}

		/// <summary>
		/// 单元格字体是否加粗
		/// </summary>
		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x060053BF RID: 21439 RVA: 0x00256706 File Offset: 0x00254906
		// (set) Token: 0x060053C0 RID: 21440 RVA: 0x00256714 File Offset: 0x00254914
		public bool FontBold
		{
			get
			{
				return this.Font.Bold;
			}
			set
			{
				if (value)
				{
					this.Font = new Font(this.Font, this.Font.Style | FontStyle.Bold);
					return;
				}
				this.Font = new Font(this.Font, this.Font.Style ^ FontStyle.Bold);
			}
		}

		/// <summary>
		/// 单元格字体是否是斜体
		/// </summary>
		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x060053C1 RID: 21441 RVA: 0x00256761 File Offset: 0x00254961
		// (set) Token: 0x060053C2 RID: 21442 RVA: 0x00256770 File Offset: 0x00254970
		public bool FontItalic
		{
			get
			{
				return this.Font.Italic;
			}
			set
			{
				if (value)
				{
					this.Font = new Font(this.Font, this.Font.Style | FontStyle.Italic);
					return;
				}
				this.Font = new Font(this.Font, this.Font.Style ^ FontStyle.Italic);
			}
		}

		/// <summary>
		/// 单元格字体是否有删除线
		/// </summary>
		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x060053C3 RID: 21443 RVA: 0x002567BD File Offset: 0x002549BD
		// (set) Token: 0x060053C4 RID: 21444 RVA: 0x002567CC File Offset: 0x002549CC
		public bool FontStrikeout
		{
			get
			{
				return this.Font.Strikeout;
			}
			set
			{
				if (value)
				{
					this.Font = new Font(this.Font, this.Font.Style | FontStyle.Strikeout);
					return;
				}
				this.Font = new Font(this.Font, this.Font.Style ^ FontStyle.Strikeout);
			}
		}

		/// <summary>
		/// 单元格字体是否有下划线
		/// </summary>
		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x060053C5 RID: 21445 RVA: 0x00256819 File Offset: 0x00254A19
		// (set) Token: 0x060053C6 RID: 21446 RVA: 0x00256828 File Offset: 0x00254A28
		public bool FontUnderline
		{
			get
			{
				return this.Font.Underline;
			}
			set
			{
				if (value)
				{
					this.Font = new Font(this.Font, this.Font.Style | FontStyle.Underline);
					return;
				}
				this.Font = new Font(this.Font, this.Font.Style ^ FontStyle.Underline);
			}
		}

		/// <summary>
		/// 字体颜色
		/// </summary>
		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x060053C7 RID: 21447 RVA: 0x00256875 File Offset: 0x00254A75
		// (set) Token: 0x060053C8 RID: 21448 RVA: 0x00256882 File Offset: 0x00254A82
		public Color ForeColor
		{
			get
			{
				return this.Ooo_O__.0..ForeColor;
			}
			set
			{
				this.Ooo_O__.0..ForeColor = value;
			}
		}

		/// <summary>
		/// 单元格的显示格式字符
		/// </summary>
		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x060053C9 RID: 21449 RVA: 0x00256890 File Offset: 0x00254A90
		// (set) Token: 0x060053CA RID: 21450 RVA: 0x002568A2 File Offset: 0x00254AA2
		public string Format
		{
			get
			{
				return XLStyle.FormatXLToDotNet(this.Ooo_O__.0..Format);
			}
			set
			{
				this.Ooo_O__.0..Format = XLStyle.FormatDotNetToXL(value);
			}
		}

		/// <summary>
		/// 是否锁定单元格
		/// </summary>
		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x060053CB RID: 21451 RVA: 0x002568B5 File Offset: 0x00254AB5
		// (set) Token: 0x060053CC RID: 21452 RVA: 0x002568C2 File Offset: 0x00254AC2
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
		/// 单元格内容旋转的角度
		/// </summary>
		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x060053CD RID: 21453 RVA: 0x002568D0 File Offset: 0x00254AD0
		// (set) Token: 0x060053CE RID: 21454 RVA: 0x002568DD File Offset: 0x00254ADD
		public int Rotation
		{
			get
			{
				return this.Ooo_O__.0..Rotation;
			}
			set
			{
				this.Ooo_O__.0..Rotation = value;
			}
		}

		/// <summary>
		/// 单元格内容是否自动换行
		/// </summary>
		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x060053CF RID: 21455 RVA: 0x002568EB File Offset: 0x00254AEB
		// (set) Token: 0x060053D0 RID: 21456 RVA: 0x002568F8 File Offset: 0x00254AF8
		public bool WordWrap
		{
			get
			{
				return this.Ooo_O__.0..WordWrap;
			}
			set
			{
				this.Ooo_O__.0..WordWrap = true;
			}
		}

		// Token: 0x040022A8 RID: 8872
		internal readonly XLStyle <<EMPTY_NAME>>;
	}
}
