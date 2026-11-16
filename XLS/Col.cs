using System;
using C1.C1Excel;

namespace Foxtable.XLS
{
	// Token: 0x020004F0 RID: 1264
	[oO0oooo("1159")]
	public class Col
	{
		// Token: 0x060052F3 RID: 21235 RVA: 0x002556F2 File Offset: 0x002538F2
		internal Col(XLColumn A_0)
		{
			this.o0_.O_o. = A_0;
		}

		/// <summary>
		/// 列宽
		/// </summary>
		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060052F4 RID: 21236 RVA: 0x00255701 File Offset: 0x00253901
		// (set) Token: 0x060052F5 RID: 21237 RVA: 0x00255714 File Offset: 0x00253914
		public int Width
		{
			get
			{
				return C1XLBook.TwipsToPixels((double)this.o0_.O_o..Width);
			}
			set
			{
				this.o0_.O_o..Width = C1XLBook.PixelsToTwips((double)value);
			}
		}

		/// <summary>
		/// 打印工作表时，是否在该列强制水平分页
		/// </summary>
		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060052F6 RID: 21238 RVA: 0x00255728 File Offset: 0x00253928
		// (set) Token: 0x060052F7 RID: 21239 RVA: 0x00255735 File Offset: 0x00253935
		public bool PageBreak
		{
			get
			{
				return this.o0_.O_o..PageBreak;
			}
			set
			{
				this.o0_.O_o..PageBreak = value;
			}
		}

		/// <summary>
		/// 此列是否可见
		/// </summary>
		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060052F8 RID: 21240 RVA: 0x00255743 File Offset: 0x00253943
		// (set) Token: 0x060052F9 RID: 21241 RVA: 0x00255750 File Offset: 0x00253950
		public bool Visible
		{
			get
			{
				return this.o0_.O_o..Visible;
			}
			set
			{
				this.o0_.O_o..Visible = value;
			}
		}

		/// <summary>
		/// 设置列的样式
		/// </summary>
		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060052FA RID: 21242 RVA: 0x0025575E File Offset: 0x0025395E
		// (set) Token: 0x060052FB RID: 21243 RVA: 0x00255770 File Offset: 0x00253970
		public Style Style
		{
			get
			{
				return new Style(this.o0_.O_o..Style);
			}
			set
			{
				if (value == null)
				{
					this.o0_.O_o..Style = null;
					return;
				}
				this.o0_.O_o..Style = value.Ooo_O__.0.;
			}
		}

		// Token: 0x04002278 RID: 8824
		internal XLColumn <<EMPTY_NAME>>;
	}
}
