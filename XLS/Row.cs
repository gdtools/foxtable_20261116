using System;
using C1.C1Excel;

namespace Foxtable.XLS
{
	// Token: 0x020004FA RID: 1274
	[oO0oooo("1158")]
	public class Row
	{
		// Token: 0x0600534F RID: 21327 RVA: 0x00255F1C File Offset: 0x0025411C
		internal Row(XLRow A_0)
		{
			this.OoOoo.o. = A_0;
		}

		/// <summary>
		/// 行高
		/// </summary>
		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x06005350 RID: 21328 RVA: 0x00255F2B File Offset: 0x0025412B
		// (set) Token: 0x06005351 RID: 21329 RVA: 0x00255F3E File Offset: 0x0025413E
		public int Height
		{
			get
			{
				return C1XLBook.TwipsToPixels((double)this.OoOoo.o..Height);
			}
			set
			{
				this.OoOoo.o..Height = C1XLBook.PixelsToTwips((double)value);
			}
		}

		/// <summary>
		/// 是否在该行强制换页
		/// </summary>
		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x06005352 RID: 21330 RVA: 0x00255F52 File Offset: 0x00254152
		// (set) Token: 0x06005353 RID: 21331 RVA: 0x00255F5F File Offset: 0x0025415F
		public bool PageBreak
		{
			get
			{
				return this.OoOoo.o..PageBreak;
			}
			set
			{
				this.OoOoo.o..PageBreak = value;
			}
		}

		/// <summary>
		/// 是否显示该行
		/// </summary>
		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x06005354 RID: 21332 RVA: 0x00255F6D File Offset: 0x0025416D
		// (set) Token: 0x06005355 RID: 21333 RVA: 0x00255F7A File Offset: 0x0025417A
		public bool Visible
		{
			get
			{
				return this.OoOoo.o..Visible;
			}
			set
			{
				this.OoOoo.o..Visible = value;
			}
		}

		/// <summary>
		/// 设置行的样式
		/// </summary>
		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x06005356 RID: 21334 RVA: 0x00255F88 File Offset: 0x00254188
		// (set) Token: 0x06005357 RID: 21335 RVA: 0x00255F9A File Offset: 0x0025419A
		public Style Style
		{
			get
			{
				return new Style(this.OoOoo.o..Style);
			}
			set
			{
				if (value == null)
				{
					this.OoOoo.o..Style = null;
					return;
				}
				this.OoOoo.o..Style = value.Ooo_O__.0.;
			}
		}

		// Token: 0x0400229B RID: 8859
		internal XLRow <<EMPTY_NAME>>;
	}
}
