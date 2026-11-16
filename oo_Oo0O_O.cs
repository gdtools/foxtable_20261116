using System;
using C1.Win.Interop;

namespace Foxtable
{
	// Token: 0x02000140 RID: 320
	internal class oo_Oo0O_O : o_OOO
	{
		// Token: 0x06000FB1 RID: 4017 RVA: 0x0007870C File Offset: 0x0007690C
		protected virtual Point <<EMPTY_NAME>>(double A_0, double A_1)
		{
			double y = Math.Sin(A_1) * 3.1415926535897931;
			return new Point(A_0, y);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00078734 File Offset: 0x00076934
		protected virtual Point <<EMPTY_NAME>>(double A_0, double A_1)
		{
			double num = A_1 / 3.1415926535897931;
			num = Math.Max(-1.0, Math.Min(1.0, num));
			double y = Math.Asin(num);
			return new Point(A_0, y);
		}
	}
}
