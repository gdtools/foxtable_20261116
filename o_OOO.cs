using System;
using C1.FlexMap;
using C1.Win.Interop;

namespace Foxtable
{
	// Token: 0x0200013F RID: 319
	internal abstract class o_OOO : IMapProjection
	{
		// Token: 0x06000FAA RID: 4010 RVA: 0x00078600 File Offset: 0x00076800
		public virtual bool <<EMPTY_NAME>>()
		{
			return false;
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00078603 File Offset: 0x00076803
		public virtual bool <<EMPTY_NAME>>()
		{
			return false;
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00078608 File Offset: 0x00076808
		public virtual Point <<EMPTY_NAME>>(Point A_0)
		{
			double x = A_0.X;
			double y = A_0.Y;
			double a_ = x * 0.017453292519943295;
			double a_2 = y * 0.017453292519943295;
			Point point = this.Ooo0.0O__0000O.(a_, a_2);
			double x2 = point.X / 6.2831853071795862 + 0.5;
			double y2 = -point.Y / 6.2831853071795862 + 0.5;
			return new Point(x2, y2);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00078688 File Offset: 0x00076888
		public virtual Point <<EMPTY_NAME>>(Point A_0)
		{
			double a_ = (A_0.X - 0.5) * 6.2831853071795862;
			double a_2 = -(A_0.Y - 0.5) * 6.2831853071795862;
			Point point = this.OO0o0_o._o_o.(a_, a_2);
			double x = point.X;
			double y = point.Y;
			return new Point(x * 57.295779513082323, y * 57.295779513082323);
		}

		// Token: 0x06000FAE RID: 4014
		protected abstract Point <<EMPTY_NAME>>(double A_0, double A_1);

		// Token: 0x06000FAF RID: 4015
		protected abstract Point <<EMPTY_NAME>>(double A_0, double A_1);

		// Token: 0x0400063B RID: 1595
		public const double <<EMPTY_NAME>> = 0.017453292519943295;

		// Token: 0x0400063C RID: 1596
		public const double <<EMPTY_NAME>> = 57.295779513082323;

		// Token: 0x0400063D RID: 1597
		public const double <<EMPTY_NAME>> = 6.2831853071795862;

		// Token: 0x0400063E RID: 1598
		public const double <<EMPTY_NAME>> = 6.2831853071795862;
	}
}
