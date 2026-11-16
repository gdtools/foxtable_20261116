using System;
using System.Drawing;
using C1.C1Excel;

namespace Foxtable.XLS
{
	// Token: 0x020004F5 RID: 1269
	public class Picture
	{
		// Token: 0x0600530F RID: 21263 RVA: 0x002558FC File Offset: 0x00253AFC
		public Picture(Image A_0, int A_1, int A_2, int A_3, int A_4)
		{
			A_1 = C1XLBook.PixelsToTwips((double)A_1);
			A_2 = C1XLBook.PixelsToTwips((double)A_2);
			A_3 = C1XLBook.PixelsToTwips((double)A_3);
			A_4 = C1XLBook.PixelsToTwips((double)A_4);
			this.o0_.O_o. = new XLPictureShape(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x0025593C File Offset: 0x00253B3C
		public Picture(Image A_0)
		{
			this.o0_.O_o. = new XLPictureShape(A_0);
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x00255950 File Offset: 0x00253B50
		public Picture(Image A_0, int A_1, int A_2)
		{
			A_1 = C1XLBook.PixelsToTwips((double)A_1);
			A_2 = C1XLBook.PixelsToTwips((double)A_2);
			this.o0_.O_o. = new XLPictureShape(A_0, A_1, A_2);
		}

		// Token: 0x04002290 RID: 8848
		internal XLPictureShape <<EMPTY_NAME>>;
	}
}
