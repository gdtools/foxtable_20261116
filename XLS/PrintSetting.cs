using System;
using System.Drawing.Printing;
using C1.C1Excel;

namespace Foxtable.XLS
{
	/// <summary>
	/// 打印设置
	/// </summary>
	// Token: 0x020004F6 RID: 1270
	public class PrintSetting
	{
		// Token: 0x06005312 RID: 21266 RVA: 0x00255978 File Offset: 0x00253B78
		public PrintSetting(XLPrintSettings A_0)
		{
			this.o0_.O_o. = A_0;
		}

		/// <summary>
		/// 逻辑型，设为True将用黑白模式打印
		/// </summary>
		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x06005313 RID: 21267 RVA: 0x00255987 File Offset: 0x00253B87
		// (set) Token: 0x06005314 RID: 21268 RVA: 0x00255994 File Offset: 0x00253B94
		public bool BlackAndWhite
		{
			get
			{
				return this.o0_.O_o..BlackAndWhite;
			}
			set
			{
				this.o0_.O_o..BlackAndWhite = value;
			}
		}

		/// <summary>
		/// 逻辑型，表格是否在水平方向页面居中
		/// </summary>
		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x06005315 RID: 21269 RVA: 0x002559A2 File Offset: 0x00253BA2
		// (set) Token: 0x06005316 RID: 21270 RVA: 0x002559AF File Offset: 0x00253BAF
		public bool CenterHorizontal
		{
			get
			{
				return this.o0_.O_o..CenterHorizontal;
			}
			set
			{
				this.o0_.O_o..CenterHorizontal = value;
			}
		}

		/// <summary>
		/// 逻辑型，表格是否在垂直方向页面居中
		/// </summary>
		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x06005317 RID: 21271 RVA: 0x002559BD File Offset: 0x00253BBD
		// (set) Token: 0x06005318 RID: 21272 RVA: 0x002559CA File Offset: 0x00253BCA
		public bool CenterVertical
		{
			get
			{
				return this.o0_.O_o..CenterVertical;
			}
			set
			{
				this.o0_.O_o..CenterVertical = value;
			}
		}

		/// <summary>
		/// 是否打印网格线
		/// </summary>
		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x06005319 RID: 21273 RVA: 0x002559D8 File Offset: 0x00253BD8
		// (set) Token: 0x0600531A RID: 21274 RVA: 0x002559E5 File Offset: 0x00253BE5
		public bool PrintGridlines
		{
			get
			{
				return this.o0_.O_o..PrintGridlines;
			}
			set
			{
				this.o0_.O_o..PrintGridlines = value;
			}
		}

		/// <summary>
		/// 是否打印列标题
		/// </summary>
		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x0600531B RID: 21275 RVA: 0x002559F3 File Offset: 0x00253BF3
		// (set) Token: 0x0600531C RID: 21276 RVA: 0x00255A00 File Offset: 0x00253C00
		public bool PrintHeaders
		{
			get
			{
				return this.o0_.O_o..PrintHeaders;
			}
			set
			{
				this.o0_.O_o..PrintHeaders = value;
			}
		}

		/// <summary>
		/// 整数型，打印起始页号
		/// </summary>
		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x0600531D RID: 21277 RVA: 0x00255A0E File Offset: 0x00253C0E
		// (set) Token: 0x0600531E RID: 21278 RVA: 0x00255A1B File Offset: 0x00253C1B
		public int StartPage
		{
			get
			{
				return this.o0_.O_o..StartPage;
			}
			set
			{
				this.o0_.O_o..StartPage = value;
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x0600531F RID: 21279 RVA: 0x00255A29 File Offset: 0x00253C29
		// (set) Token: 0x06005320 RID: 21280 RVA: 0x00255A36 File Offset: 0x00253C36
		public bool PrintPagesInRows
		{
			get
			{
				return this.o0_.O_o..PrintPagesInRows;
			}
			set
			{
				this.o0_.O_o..PrintPagesInRows = value;
			}
		}

		/// <summary>
		/// 字符型，设置页眉
		/// </summary>
		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06005321 RID: 21281 RVA: 0x00255A44 File Offset: 0x00253C44
		// (set) Token: 0x06005322 RID: 21282 RVA: 0x00255A51 File Offset: 0x00253C51
		[oO0oooo("1315")]
		public string Header
		{
			get
			{
				return this.o0_.O_o..Header;
			}
			set
			{
				this.o0_.O_o..Header = value;
			}
		}

		/// <summary>
		/// 字符型，设置页脚
		/// </summary>
		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x06005323 RID: 21283 RVA: 0x00255A5F File Offset: 0x00253C5F
		// (set) Token: 0x06005324 RID: 21284 RVA: 0x00255A6C File Offset: 0x00253C6C
		[oO0oooo("1315")]
		public string Footer
		{
			get
			{
				return this.o0_.O_o..Footer;
			}
			set
			{
				this.o0_.O_o..Footer = value;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06005325 RID: 21285 RVA: 0x00255A7A File Offset: 0x00253C7A
		// (set) Token: 0x06005326 RID: 21286 RVA: 0x00255A91 File Offset: 0x00253C91
		public double MarginFooter
		{
			get
			{
				return this.o0_.O_o..MarginFooter * 25.4;
			}
			set
			{
				this.o0_.O_o..MarginFooter = value / 25.4;
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06005327 RID: 21287 RVA: 0x00255AA9 File Offset: 0x00253CA9
		// (set) Token: 0x06005328 RID: 21288 RVA: 0x00255AC0 File Offset: 0x00253CC0
		public double MarginHeader
		{
			get
			{
				return this.o0_.O_o..MarginHeader * 25.4;
			}
			set
			{
				this.o0_.O_o..MarginHeader = value / 25.4;
			}
		}

		/// <summary>
		///  逻辑型，是否横向打印
		/// </summary>
		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06005329 RID: 21289 RVA: 0x00255AD8 File Offset: 0x00253CD8
		// (set) Token: 0x0600532A RID: 21290 RVA: 0x00255AE5 File Offset: 0x00253CE5
		[oO0oooo("1312")]
		public bool Landscape
		{
			get
			{
				return this.o0_.O_o..Landscape;
			}
			set
			{
				this.o0_.O_o..Landscape = value;
			}
		}

		/// <summary>
		/// 纸张类型
		/// </summary>
		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x0600532B RID: 21291 RVA: 0x00255AF3 File Offset: 0x00253CF3
		// (set) Token: 0x0600532C RID: 21292 RVA: 0x00255B00 File Offset: 0x00253D00
		[oO0oooo("1312")]
		public int PaperKind
		{
			get
			{
				return (int)this.o0_.O_o..PaperKind;
			}
			set
			{
				if (Enum.IsDefined(typeof(PaperKind), value))
				{
					this.o0_.O_o..PaperKind = (PaperKind)value;
				}
			}
		}

		/// <summary>
		/// 下边距，单位为毫米
		/// </summary>
		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x0600532D RID: 21293 RVA: 0x00255B25 File Offset: 0x00253D25
		// (set) Token: 0x0600532E RID: 21294 RVA: 0x00255B3C File Offset: 0x00253D3C
		[oO0oooo("1312")]
		public double MarginBottom
		{
			get
			{
				return this.o0_.O_o..MarginBottom * 25.4;
			}
			set
			{
				this.o0_.O_o..MarginBottom = value / 25.4;
			}
		}

		/// <summary>
		/// 左边距，单位为毫米
		/// </summary>
		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x0600532F RID: 21295 RVA: 0x00255B54 File Offset: 0x00253D54
		// (set) Token: 0x06005330 RID: 21296 RVA: 0x00255B6B File Offset: 0x00253D6B
		[oO0oooo("1312")]
		public double MarginLeft
		{
			get
			{
				return this.o0_.O_o..MarginLeft * 25.4;
			}
			set
			{
				this.o0_.O_o..MarginLeft = value / 25.4;
			}
		}

		/// <summary>
		/// 右边距，单位为毫米
		/// </summary>
		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x06005331 RID: 21297 RVA: 0x00255B83 File Offset: 0x00253D83
		// (set) Token: 0x06005332 RID: 21298 RVA: 0x00255B9A File Offset: 0x00253D9A
		[oO0oooo("1312")]
		public double MarginRight
		{
			get
			{
				return this.o0_.O_o..MarginRight * 25.4;
			}
			set
			{
				this.o0_.O_o..MarginRight = value / 25.4;
			}
		}

		/// <summary>
		/// 上边距，单位为毫米
		/// </summary>
		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x06005333 RID: 21299 RVA: 0x00255BB2 File Offset: 0x00253DB2
		// (set) Token: 0x06005334 RID: 21300 RVA: 0x00255BC9 File Offset: 0x00253DC9
		[oO0oooo("1312")]
		public double MarginTop
		{
			get
			{
				return this.o0_.O_o..MarginTop * 25.4;
			}
			set
			{
				this.o0_.O_o..MarginTop = value / 25.4;
			}
		}

		/// <summary>
		/// 逻辑型，设为False按照比例缩放
		/// </summary>
		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06005335 RID: 21301 RVA: 0x00255BE1 File Offset: 0x00253DE1
		// (set) Token: 0x06005336 RID: 21302 RVA: 0x00255BEE File Offset: 0x00253DEE
		[oO0oooo("1313")]
		public bool AutoScale
		{
			get
			{
				return this.o0_.O_o..AutoScale;
			}
			set
			{
				this.o0_.O_o..AutoScale = value;
			}
		}

		/// <summary>
		/// 整数型，指定缩放百分比，例如50表示缩小一半，100表示不缩放，200表示放大一半
		/// </summary>
		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06005337 RID: 21303 RVA: 0x00255BFC File Offset: 0x00253DFC
		// (set) Token: 0x06005338 RID: 21304 RVA: 0x00255C09 File Offset: 0x00253E09
		[oO0oooo("1313")]
		public int ScalingFactor
		{
			get
			{
				return this.o0_.O_o..ScalingFactor;
			}
			set
			{
				this.o0_.O_o..ScalingFactor = value;
			}
		}

		/// <summary>
		/// 指定水平方向打印的页数
		/// </summary>
		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06005339 RID: 21305 RVA: 0x00255C17 File Offset: 0x00253E17
		// (set) Token: 0x0600533A RID: 21306 RVA: 0x00255C24 File Offset: 0x00253E24
		[oO0oooo("1313")]
		public int FitPagesAcross
		{
			get
			{
				return this.o0_.O_o..FitPagesAcross;
			}
			set
			{
				this.o0_.O_o..FitPagesAcross = value;
			}
		}

		/// <summary>
		/// 指定垂直方向打印的页数
		/// </summary>
		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x0600533B RID: 21307 RVA: 0x00255C32 File Offset: 0x00253E32
		// (set) Token: 0x0600533C RID: 21308 RVA: 0x00255C3F File Offset: 0x00253E3F
		[oO0oooo("1313")]
		public int FitPagesDown
		{
			get
			{
				return this.o0_.O_o..FitPagesDown;
			}
			set
			{
				this.o0_.O_o..FitPagesDown = value;
			}
		}

		// Token: 0x04002291 RID: 8849
		private XLPrintSettings <<EMPTY_NAME>>;
	}
}
