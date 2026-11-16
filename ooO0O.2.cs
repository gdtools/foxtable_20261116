using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200013E RID: 318
	[StandardModule]
	internal sealed class ooO0O
	{
		// Token: 0x06000FA2 RID: 4002 RVA: 0x00077F78 File Offset: 0x00076178
		public static List<PointF> <<EMPTY_NAME>>(PointF[] A_0, float A_1 = -1f, float A_2 = 2f, float A_3 = 8f, float A_4 = 0.5f, int A_5 = 3, bool A_6 = false)
		{
			List<PointF> result;
			if (A_0 == null || A_0.Length < 2)
			{
				result = new List<PointF>();
			}
			else
			{
				if (A_2 <= 0f)
				{
					throw new ArgumentException("采样距离必须大于0", "sampleDistance");
				}
				if (A_3 <= 0f)
				{
					throw new ArgumentException("箭头长度必须大于0", "arrowLength");
				}
				if ((double)A_1 >= 3.1415926535897931)
				{
					throw new ArgumentOutOfRangeException("arrowAngle", "箭头角度必须在0~π弧度之间（0~180°）");
				}
				if (A_4 < 0f || A_4 > 1f)
				{
					throw new ArgumentOutOfRangeException("tension", "张力必须在0~1之间");
				}
				if (A_5 < 2)
				{
					A_5 = 2;
				}
				List<PointF> list = ooO0O.O_O_.0oooo_oo.(A_0, A_2, A_4);
				if (list.Count < 2 || A_1 <= 0f)
				{
					result = list;
				}
				else
				{
					if (A_6)
					{
						PointF pointF = ooO0O.O.O00.(list, A_5);
						PointF a_ = new PointF(-pointF.X, -pointF.Y);
						List<PointF> collection = ooO0O.O_O_.0oooo_oo.(list[0], a_, A_3, A_1);
						list.InsertRange(0, collection);
					}
					PointF a_2 = ooO0O.O0.oo0O.(list, A_5);
					List<PointF> collection2 = ooO0O.O_O_.0oooo_oo.(list[list.Count - 1], a_2, A_3, A_1);
					list.AddRange(collection2);
					result = list;
				}
			}
			return result;
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0007809C File Offset: 0x0007629C
		private static List<PointF> <<EMPTY_NAME>>(PointF[] A_0, float A_1, float A_2 = 0.5f)
		{
			List<PointF> result;
			if (A_0 == null || A_0.Length < 2)
			{
				result = new List<PointF>();
			}
			else
			{
				using (GraphicsPath graphicsPath = new GraphicsPath())
				{
					if (A_0.Length == 2)
					{
						graphicsPath.AddLine(A_0[0], A_0[1]);
					}
					else
					{
						graphicsPath.AddCurve(A_0, A_2);
					}
					Matrix matrix = new Matrix();
					graphicsPath.Flatten(matrix, 0.1f);
					PointF[] pathPoints = graphicsPath.PathPoints;
					List<PointF> list = new List<PointF>();
					if (pathPoints.Length < 2)
					{
						result = list;
					}
					else
					{
						list.Add(pathPoints[0]);
						float num = 0f;
						PointF a_ = pathPoints[0];
						int num2 = pathPoints.Length - 1;
						for (int i = 1; i <= num2; i++)
						{
							PointF pointF = pathPoints[i];
							float num3 = ooO0O.O.O00.(a_, pointF);
							if ((double)num3 < 1E-06)
							{
								a_ = pointF;
							}
							else if ((double)(num + num3) < (double)A_1 - 1E-06)
							{
								num += num3;
								a_ = pointF;
							}
							else
							{
								float num4 = A_1 - num;
								float a_2 = num4 / num3;
								PointF pointF2 = ooO0O.O_O_.0oooo_oo.(a_, pointF, a_2);
								list.Add(pointF2);
								a_ = pointF2;
								float num5 = num3 - num4;
								while ((double)num5 >= (double)A_1 + 1E-06)
								{
									pointF2 = ooO0O.O_O_.0oooo_oo.(a_, pointF, A_1 / num5);
									list.Add(pointF2);
									a_ = pointF2;
									num5 -= A_1;
								}
								num = (((double)num5 > 1E-06) ? num5 : 0f);
								a_ = pointF;
							}
						}
						PointF pointF3 = pathPoints[pathPoints.Length - 1];
						if ((double)ooO0O.O.O00.(list[list.Count - 1], pointF3) > 1E-06)
						{
							list.Add(pointF3);
						}
						result = list;
					}
				}
			}
			return result;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00078290 File Offset: 0x00076490
		private static PointF <<EMPTY_NAME>>(List<PointF> A_0, int A_1)
		{
			int num = Math.Min(A_1, A_0.Count);
			PointF result;
			if (num < 2)
			{
				result = new PointF(1f, 0f);
			}
			else
			{
				float num2 = 0f;
				float num3 = 0f;
				int num4 = A_0.Count - num;
				int num5 = A_0.Count - 2;
				for (int i = num4; i <= num5; i++)
				{
					PointF pointF = A_0[i];
					PointF pointF2 = A_0[i + 1];
					float num6 = pointF2.X - pointF.X;
					float num7 = pointF2.Y - pointF.Y;
					float num8 = (float)Math.Sqrt((double)(num6 * num6 + num7 * num7));
					if ((double)num8 > 1E-06)
					{
						num2 += num6 / num8;
						num3 += num7 / num8;
					}
				}
				float num9 = (float)Math.Sqrt((double)(num2 * num2 + num3 * num3));
				if ((double)num9 > 1E-06)
				{
					result = new PointF(num2 / num9, num3 / num9);
				}
				else
				{
					result = new PointF(1f, 0f);
				}
			}
			return result;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000783A0 File Offset: 0x000765A0
		private static PointF <<EMPTY_NAME>>(List<PointF> A_0, int A_1)
		{
			int num = Math.Min(A_1, A_0.Count);
			PointF result;
			if (num < 2)
			{
				result = new PointF(1f, 0f);
			}
			else
			{
				float num2 = 0f;
				float num3 = 0f;
				int num4 = num - 1 - 1;
				for (int i = 0; i <= num4; i++)
				{
					PointF pointF = A_0[i];
					PointF pointF2 = A_0[i + 1];
					float num5 = pointF2.X - pointF.X;
					float num6 = pointF2.Y - pointF.Y;
					float num7 = (float)Math.Sqrt((double)(num5 * num5 + num6 * num6));
					if ((double)num7 > 1E-06)
					{
						num2 += num5 / num7;
						num3 += num6 / num7;
					}
				}
				float num8 = (float)Math.Sqrt((double)(num2 * num2 + num3 * num3));
				if ((double)num8 > 1E-06)
				{
					result = new PointF(num2 / num8, num3 / num8);
				}
				else
				{
					result = new PointF(1f, 0f);
				}
			}
			return result;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x000784A8 File Offset: 0x000766A8
		private static List<PointF> <<EMPTY_NAME>>(PointF A_0, PointF A_1, float A_2, float A_3)
		{
			List<PointF> list = new List<PointF>();
			float num = (float)Math.Cos((double)A_3);
			float num2 = (float)Math.Sin((double)A_3);
			float x = A_0.X - (A_1.X * num - A_1.Y * num2) * A_2;
			float y = A_0.Y - (A_1.X * num2 + A_1.Y * num) * A_2;
			PointF item = new PointF(x, y);
			float x2 = A_0.X - (A_1.X * num + A_1.Y * num2) * A_2;
			float y2 = A_0.Y - (-A_1.X * num2 + A_1.Y * num) * A_2;
			PointF item2 = new PointF(x2, y2);
			list.Add(item);
			list.Add(A_0);
			list.Add(item2);
			return list;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00078574 File Offset: 0x00076774
		private static float <<EMPTY_NAME>>(PointF A_0, PointF A_1)
		{
			float num = A_1.X - A_0.X;
			float num2 = A_1.Y - A_0.Y;
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000785B0 File Offset: 0x000767B0
		private static PointF <<EMPTY_NAME>>(PointF A_0, PointF A_1, float A_2)
		{
			float x = A_0.X + (A_1.X - A_0.X) * A_2;
			float y = A_0.Y + (A_1.Y - A_0.Y) * A_2;
			return new PointF(x, y);
		}
	}
}
