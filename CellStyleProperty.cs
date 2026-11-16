using System;
using System.ComponentModel;
using System.Drawing;

namespace Foxtable
{
	// Token: 0x02000332 RID: 818
	internal class CellStyleProperty
	{
		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x0014FA33 File Offset: 0x0014DC33
		// (set) Token: 0x06002D8D RID: 11661 RVA: 0x0014FA3B File Offset: 0x0014DC3B
		[DefaultValue(false)]
		[DisplayName("加粗")]
		[Category("字体")]
		[O_Oo00Oo000O0(1.0)]
		public bool FontBold
		{
			get
			{
				return this.oOO.oO_____OO_.;
			}
			set
			{
				this.oOO.oO_____OO_. = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x0014FA44 File Offset: 0x0014DC44
		// (set) Token: 0x06002D8F RID: 11663 RVA: 0x0014FA4C File Offset: 0x0014DC4C
		[Category("字体")]
		[DefaultValue(false)]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("下划线")]
		public bool FontUnderLine
		{
			get
			{
				return this.O_.0oo_0oOO.;
			}
			set
			{
				this.O_.0oo_0oOO. = value;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x0014FA55 File Offset: 0x0014DC55
		// (set) Token: 0x06002D91 RID: 11665 RVA: 0x0014FA5D File Offset: 0x0014DC5D
		[DisplayName("删除线")]
		[O_Oo00Oo000O0(3.0)]
		[Category("字体")]
		[DefaultValue(false)]
		public bool FontStrikeout
		{
			get
			{
				return this.O_.o.;
			}
			set
			{
				this.O_.o. = value;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x0014FA66 File Offset: 0x0014DC66
		// (set) Token: 0x06002D93 RID: 11667 RVA: 0x0014FA6E File Offset: 0x0014DC6E
		[O_Oo00Oo000O0(4.0)]
		[DisplayName("字体颜色")]
		[Category("颜色")]
		public Color ForeColor
		{
			get
			{
				return this.oOO.oO_____OO_.;
			}
			set
			{
				this.oOO.oO_____OO_. = value;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x0014FA77 File Offset: 0x0014DC77
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x0014FA7F File Offset: 0x0014DC7F
		[DisplayName("背景颜色")]
		[Category("颜色")]
		[O_Oo00Oo000O0(5.0)]
		public Color BackColor
		{
			get
			{
				return this.O_.0oo_0oOO.;
			}
			set
			{
				this.O_.0oo_0oOO. = value;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x0014FA88 File Offset: 0x0014DC88
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x0014FA90 File Offset: 0x0014DC90
		[Category("基本")]
		[DisplayName("名称")]
		[O_Oo00Oo000O0(6.0)]
		public string Name
		{
			get
			{
				return this.oOO.oO_____OO_.;
			}
			set
			{
				this.oOO.oO_____OO_. = value;
			}
		}

		// Token: 0x0400126E RID: 4718
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400126F RID: 4719
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001270 RID: 4720
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001271 RID: 4721
		private Color <<EMPTY_NAME>>;

		// Token: 0x04001272 RID: 4722
		private Color <<EMPTY_NAME>>;

		// Token: 0x04001273 RID: 4723
		private string <<EMPTY_NAME>>;
	}
}
