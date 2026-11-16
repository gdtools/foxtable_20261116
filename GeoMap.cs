using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using C1.FlexMap;
using C1.Win.Interop;
using C1.Win.Map;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json.Linq;

namespace Foxtable
{
	// Token: 0x02000141 RID: 321
	[ComVisible(true)]
	public class GeoMap : C1Map, O0_0_0_0_
	{
		// Token: 0x06000FB3 RID: 4019 RVA: 0x0007877C File Offset: 0x0007697C
		public GeoMap()
		{
			base.DistanceScale.Alignment = ContentAlignment.BottomLeft;
			base.DistanceScale.BarStyle.BackColor = Color.Black;
			base.PanTool.MarkerStyle.BackColor = Color.FromArgb(131, 176, 202);
			base.PanTool.MarkerStyle.BackColor2 = Color.FromArgb(185, 224, 245);
			base.PanTool.MarkerStyle.GradientStyle = GradientStyle.Vertical;
			base.PanTool.PanStyle.BackColor = Color.FromArgb(243, 243, 243);
			base.PanTool.PanStyle.BackColor2 = Color.FromArgb(204, 204, 204);
			base.PanTool.PanStyle.GradientStyle = GradientStyle.Vertical;
			base.PanTool.PanStyle.Stroke.Color = Color.FromArgb(168, 168, 168);
			base.PanTool.PanStyle.Stroke.Width = 1f;
			base.Viewport.Padding = new Padding(3);
			base.ZoomTool.ButtonStyle.BackColor = Color.FromArgb(243, 243, 243);
			base.ZoomTool.ButtonStyle.BackColor2 = Color.FromArgb(204, 204, 204);
			base.ZoomTool.ButtonStyle.Border.Bottom.Color = Color.FromArgb(168, 168, 168);
			base.ZoomTool.ButtonStyle.Border.Bottom.Width = 1f;
			base.ZoomTool.ButtonStyle.Border.Left.Color = Color.FromArgb(168, 168, 168);
			base.ZoomTool.ButtonStyle.Border.Left.Width = 1f;
			base.ZoomTool.ButtonStyle.Border.Right.Color = Color.FromArgb(168, 168, 168);
			base.ZoomTool.ButtonStyle.Border.Right.Width = 1f;
			base.ZoomTool.ButtonStyle.Border.RoundRadius.BottomLeft = 3;
			base.ZoomTool.ButtonStyle.Border.RoundRadius.BottomRight = 3;
			base.ZoomTool.ButtonStyle.Border.RoundRadius.TopLeft = 3;
			base.ZoomTool.ButtonStyle.Border.RoundRadius.TopRight = 3;
			base.ZoomTool.ButtonStyle.Border.Top.Color = Color.FromArgb(168, 168, 168);
			base.ZoomTool.ButtonStyle.Border.Top.Width = 1f;
			base.ZoomTool.ButtonStyle.GradientStyle = GradientStyle.Vertical;
			base.ZoomTool.Margin = new Padding(20, 70, 0, 0);
			base.ZoomTool.ThumbStyle.BackColor = Color.FromArgb(243, 243, 243);
			base.ZoomTool.ThumbStyle.BackColor2 = Color.FromArgb(131, 176, 202);
			base.ZoomTool.ThumbStyle.Border.Bottom.Color = Color.FromArgb(138, 176, 198);
			base.ZoomTool.ThumbStyle.Border.Bottom.Width = 1f;
			base.ZoomTool.ThumbStyle.Border.Left.Color = Color.FromArgb(138, 176, 198);
			base.ZoomTool.ThumbStyle.Border.Left.Width = 1f;
			base.ZoomTool.ThumbStyle.Border.Right.Color = Color.FromArgb(138, 176, 198);
			base.ZoomTool.ThumbStyle.Border.Right.Width = 1f;
			base.ZoomTool.ThumbStyle.Border.RoundRadius.BottomLeft = 3;
			base.ZoomTool.ThumbStyle.Border.RoundRadius.BottomRight = 3;
			base.ZoomTool.ThumbStyle.Border.RoundRadius.TopLeft = 3;
			base.ZoomTool.ThumbStyle.Border.RoundRadius.TopRight = 3;
			base.ZoomTool.ThumbStyle.Border.Top.Color = Color.FromArgb(138, 176, 198);
			base.ZoomTool.ThumbStyle.Border.Top.Width = 1f;
			base.ZoomTool.ThumbStyle.GradientStyle = GradientStyle.Vertical;
			base.ZoomTool.TrackStyle.BackColor = Color.FromArgb(203, 203, 203);
			base.ZoomTool.TrackStyle.Border.Bottom.Color = Color.FromArgb(168, 168, 168);
			base.ZoomTool.TrackStyle.Border.Bottom.Width = 1f;
			base.ZoomTool.TrackStyle.Border.Left.Color = Color.FromArgb(168, 168, 168);
			base.ZoomTool.TrackStyle.Border.Left.Width = 1f;
			base.ZoomTool.TrackStyle.Border.Right.Color = Color.FromArgb(168, 168, 168);
			base.ZoomTool.TrackStyle.Border.Right.Width = 1f;
			base.ZoomTool.TrackStyle.Border.RoundRadius.BottomLeft = 3;
			base.ZoomTool.TrackStyle.Border.RoundRadius.BottomRight = 3;
			base.ZoomTool.TrackStyle.Border.RoundRadius.TopLeft = 3;
			base.ZoomTool.TrackStyle.Border.RoundRadius.TopRight = 3;
			base.ZoomTool.TrackStyle.Border.Top.Color = Color.FromArgb(168, 168, 168);
			base.ZoomTool.TrackStyle.Border.Top.Width = 1f;
			base.Viewport.Center = new C1.Win.Interop.Point(103.72, 34.5);
			base.Viewport.Zoom = 3.2;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00078EBC File Offset: 0x000770BC
		public C1.Win.Map.VectorPolygon CreatePolygon(IEnumerable<GeoPoint> points)
		{
			return this.CreatePolygon(new IEnumerable<GeoPoint>[]
			{
				points
			});
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00078ECE File Offset: 0x000770CE
		public C1.Win.Map.VectorPolygon CreatePolygon(string pointsString, int enclaves = -1)
		{
			return this.CreatePolygon(this.O0o000O._oo.(pointsString, enclaves));
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00078EE0 File Offset: 0x000770E0
		public C1.Win.Map.VectorPolygon CreatePolygon(IEnumerable<IEnumerable<GeoPoint>> pointsArray)
		{
			C1.Win.Map.VectorPolygon vectorPolygon = new C1.Win.Map.VectorPolygon();
			List<GeoLinearRing> list = new List<GeoLinearRing>();
			try
			{
				foreach (IEnumerable<GeoPoint> points in pointsArray)
				{
					list.Add(new GeoLinearRing(points));
				}
			}
			finally
			{
				IEnumerator<IEnumerable<GeoPoint>> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			vectorPolygon.Geometry = new GeoPolygon(list);
			return vectorPolygon;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00078F48 File Offset: 0x00077148
		public C1.Win.Map.VectorPolyline CreateLine(IEnumerable<GeoPoint> points)
		{
			return this.CreateLine(new IEnumerable<GeoPoint>[]
			{
				points
			});
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00078F5A File Offset: 0x0007715A
		public C1.Win.Map.VectorPolyline CreateLine(string pointsString, int enclaves = -1)
		{
			return this.CreateLine(this.O0o000O._oo.(pointsString, enclaves));
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00078F6C File Offset: 0x0007716C
		public C1.Win.Map.VectorPolyline CreateLine(IEnumerable<IEnumerable<GeoPoint>> pointss)
		{
			C1.Win.Map.VectorPolyline vectorPolyline = new C1.Win.Map.VectorPolyline();
			List<GeoLinearRing> list = new List<GeoLinearRing>();
			try
			{
				foreach (IEnumerable<GeoPoint> points in pointss)
				{
					list.Add(new GeoLinearRing(points));
				}
			}
			finally
			{
				IEnumerator<IEnumerable<GeoPoint>> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			vectorPolyline.Geometry = new GeoMultiLineString(list);
			return vectorPolyline;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00078FD4 File Offset: 0x000771D4
		public C1.Win.Map.VectorPolyline CreateLineWithArrow(GeoPoint p1, GeoPoint p2, double arrowLength = 8.0, double arrowAngle = 30.0)
		{
			return this.CreateLineWithArrow(new GeoPoint[]
			{
				p1,
				p2
			}, false, arrowLength, arrowAngle);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00078FEE File Offset: 0x000771EE
		public C1.Win.Map.VectorPolyline CreateLineWithArrow(GeoPoint p1, GeoPoint p2, bool Both, double arrowLength = 8.0, double arrowAngle = 30.0)
		{
			return this.CreateLineWithArrow(new GeoPoint[]
			{
				p1,
				p2
			}, Both, arrowLength, arrowAngle);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00079009 File Offset: 0x00077209
		public C1.Win.Map.VectorPolyline CreateLineWithArrow(IEnumerable<GeoPoint> points, double arrowLength = 8.0, double arrowAngle = 30.0)
		{
			return this.CreateLineWithArrow(points, false, arrowLength, arrowAngle);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00079018 File Offset: 0x00077218
		public C1.Win.Map.VectorPolyline CreateLineWithArrow(IEnumerable<GeoPoint> points, bool Both, double arrowLength = 8.0, double arrowAngle = 30.0)
		{
			List<GeoPoint> list = new List<GeoPoint>();
			list.AddRange(points);
			this.CreateArrowPoints(list, arrowLength, arrowAngle, Both);
			return this.CreateLine(list);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00079044 File Offset: 0x00077244
		public C1.Win.Map.VectorPolyline CreateLineWithArrow(string pointsString, double arrowLength = 8.0, double arrowAngle = 30.0)
		{
			return this.CreateLineWithArrow(pointsString, false, arrowLength, arrowAngle);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00079050 File Offset: 0x00077250
		public C1.Win.Map.VectorPolyline CreateLineWithArrow(string pointsString, bool Both, double arrowLength = 8.0, double arrowAngle = 30.0)
		{
			string[] array = pointsString.Split(new char[]
			{
				',',
				'，'
			});
			List<GeoPoint> list = new List<GeoPoint>();
			int num = array.Length - 1;
			for (int i = 0; i <= num; i += 2)
			{
				double x = Conversions.ToDouble(array[i]);
				double y = Conversions.ToDouble(array[i + 1]);
				GeoPoint item = new GeoPoint(x, y);
				list.Add(item);
			}
			this.CreateArrowPoints(list, arrowLength, arrowAngle, Both);
			return this.CreateLine(list);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x000790CA File Offset: 0x000772CA
		public C1.Win.Map.VectorPlacemark CreatePlaceMark(GeoPoint point)
		{
			return new C1.Win.Map.VectorPlacemark
			{
				Geometry = point
			};
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x000790D8 File Offset: 0x000772D8
		public C1.Win.Map.VectorPlacemark CreatePlaceMark(IEnumerable<GeoPoint> points)
		{
			C1.Win.Map.VectorPlacemark vectorPlacemark = new C1.Win.Map.VectorPlacemark();
			if (points.Count<GeoPoint>() == 1)
			{
				vectorPlacemark.Geometry = points.First<GeoPoint>();
			}
			else
			{
				vectorPlacemark.Geometry = new GeoMultiPoint(points);
			}
			return vectorPlacemark;
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00079110 File Offset: 0x00077310
		public C1.Win.Map.VectorPlacemark CreatePlaceMark(string pointsString)
		{
			string[] array = pointsString.Split(new char[]
			{
				','
			});
			List<GeoPoint> list = new List<GeoPoint>();
			int num = array.Length - 1;
			for (int i = 0; i <= num; i += 2)
			{
				double x = Conversions.ToDouble(array[i]);
				double y = Conversions.ToDouble(array[i + 1]);
				GeoPoint item = new GeoPoint(x, y);
				list.Add(item);
			}
			return this.CreatePlaceMark(list);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00079178 File Offset: 0x00077378
		public C1.Win.Map.VectorPolygon CreateCircle(GeoPoint p1, GeoPoint p2)
		{
			double num = p2.X - p1.X;
			double num2 = p2.Y - p1.Y;
			double num3 = Math.Sqrt(num * num + num2 * num2);
			List<GeoPoint> list = new List<GeoPoint>();
			int num4 = 0;
			do
			{
				double num5 = (double)num4 * 3.1415926535897931 / 180.0;
				double x = p1.X + num3 * Math.Cos(num5);
				double y = p1.Y + num3 * Math.Sin(num5);
				list.Add(new GeoPoint(x, y));
				num4++;
			}
			while (num4 <= 359);
			return this.CreatePolygon(list);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00079214 File Offset: 0x00077414
		public C1.Win.Map.VectorPolygon CreateCircle(GeoPoint p1, GeoPoint p2, bool Pixel)
		{
			C1.Win.Map.VectorPolygon result;
			if (!Pixel)
			{
				result = this.CreateCircle(p1, p2);
			}
			else
			{
				C1.Win.Interop.Point point = base.GeographicToScreen(p1.Location);
				C1.Win.Interop.Point point2 = base.GeographicToScreen(p2.Location);
				double num = point2.X - point.X;
				double num2 = point2.Y - point.Y;
				double num3 = Math.Sqrt(num * num + num2 * num2);
				List<GeoPoint> list = new List<GeoPoint>();
				int num4 = 0;
				do
				{
					double num5 = (double)num4 * 3.1415926535897931 / 180.0;
					double x = point.X + num3 * Math.Cos(num5);
					double y = point.Y + num3 * Math.Sin(num5);
					C1.Win.Interop.Point point3 = new C1.Win.Interop.Point(x, y);
					point3 = base.ScreenToGeographic(point3);
					list.Add(new GeoPoint(point3.X, point3.Y));
					num4++;
				}
				while (num4 <= 359);
				result = this.CreatePolygon(list);
			}
			return result;
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0007930C File Offset: 0x0007750C
		public C1.Win.Map.VectorPolygon CreateCircle(string pointsString, bool Pixel = false)
		{
			string[] array = pointsString.Split(new char[]
			{
				','
			});
			C1.Win.Map.VectorPolygon result;
			if (array.Length == 4)
			{
				GeoPoint p = new GeoPoint(Conversions.ToDouble(array[0]), Conversions.ToDouble(array[1]));
				GeoPoint p2 = new GeoPoint(Conversions.ToDouble(array[2]), Conversions.ToDouble(array[3]));
				result = this.CreateCircle(p, p2, Pixel);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0007936C File Offset: 0x0007756C
		public C1.Win.Map.VectorPolygon CreatePie(GeoPoint p1, GeoPoint p2, double sweepAngle)
		{
			C1.Win.Interop.Point a_ = base.GeographicToScreen(p1.Location);
			C1.Win.Interop.Point a_2 = base.GeographicToScreen(p2.Location);
			double num = a_2.X - a_.X;
			double num2 = a_2.Y - a_.Y;
			double num3 = Math.Sqrt(num * num + num2 * num2);
			List<GeoPoint> list = new List<GeoPoint>();
			double num4 = this.O0o000O._oo.(a_, a_2);
			double num5 = num4;
			double num6 = num4 + sweepAngle;
			int num7 = 1;
			if (sweepAngle < 0.0)
			{
				num7 = -1;
			}
			list.Add(p1);
			double num8 = num6;
			double num9 = (double)num7;
			bool flag = num9 >= 0.0;
			num4 = num5;
			while (flag ? (num4 <= num8) : (num4 >= num8))
			{
				double num10 = num4 * 3.1415926535897931 / 180.0;
				double x = a_.X + num3 * Math.Cos(num10);
				double y = a_.Y + num3 * Math.Sin(num10);
				C1.Win.Interop.Point point = new C1.Win.Interop.Point(x, y);
				point = base.ScreenToGeographic(point);
				list.Add(new GeoPoint(point.X, point.Y));
				num4 += num9;
			}
			return this.CreatePolygon(list);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000794AC File Offset: 0x000776AC
		public C1.Win.Map.VectorPolyline CreateArc(GeoPoint p1, GeoPoint p2, double sweepAngle)
		{
			C1.Win.Interop.Point a_ = base.GeographicToScreen(p1.Location);
			C1.Win.Interop.Point a_2 = base.GeographicToScreen(p2.Location);
			double num = a_2.X - a_.X;
			double num2 = a_2.Y - a_.Y;
			double num3 = Math.Sqrt(num * num + num2 * num2);
			List<GeoPoint> list = new List<GeoPoint>();
			double num4 = this.O0o000O._oo.(a_, a_2);
			double num5 = num4;
			double num6 = num4 + sweepAngle;
			int num7 = 1;
			if (sweepAngle < 0.0)
			{
				num7 = -1;
			}
			double num8 = num6;
			double num9 = (double)num7;
			bool flag = num9 >= 0.0;
			num4 = num5;
			while (flag ? (num4 <= num8) : (num4 >= num8))
			{
				double num10 = num4 * 3.1415926535897931 / 180.0;
				double x = a_.X + num3 * Math.Cos(num10);
				double y = a_.Y + num3 * Math.Sin(num10);
				C1.Win.Interop.Point point = new C1.Win.Interop.Point(x, y);
				point = base.ScreenToGeographic(point);
				list.Add(new GeoPoint(point.X, point.Y));
				num4 += num9;
			}
			return this.CreateLine(list);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x000795E4 File Offset: 0x000777E4
		private double <<EMPTY_NAME>>(C1.Win.Interop.Point A_0, C1.Win.Interop.Point A_1)
		{
			double x = A_1.X - A_0.X;
			double num = Math.Atan2(A_1.Y - A_0.Y, x) * 57.295779513082323;
			if (num < 0.0)
			{
				num += 360.0;
			}
			return num;
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0007963C File Offset: 0x0007783C
		public C1.Win.Map.VectorPolyline CreateLinkArc(GeoPoint gp1, GeoPoint gp2, double curvature)
		{
			PointF pointF = base.GeographicToScreen(gp1.Location).ToPointF();
			PointF pointF2 = base.GeographicToScreen(gp2.Location).ToPointF();
			C1.Win.Map.VectorPolyline result;
			if (Math.Abs(pointF.X - pointF2.X) < 1E-06f && Math.Abs(pointF.Y - pointF2.Y) < 1E-06f)
			{
				result = this.CreateLine(new GeoPoint[]
				{
					gp1,
					gp2
				});
			}
			else if (Math.Abs(curvature) < 9.9999999747524271E-07)
			{
				result = this.CreateLine(new GeoPoint[]
				{
					gp1,
					gp2
				});
			}
			else
			{
				float num = pointF2.X - pointF.X;
				float num2 = pointF2.Y - pointF.Y;
				float num3 = (float)Math.Sqrt((double)(num * num + num2 * num2));
				curvature = Math.Max(-10.0, Math.Min(10.0, curvature));
				curvature = curvature * (double)num3 / 2.0;
				double num4 = Math.Atan2((double)num2, (double)num);
				float num5 = (float)(-(float)Math.Sin(num4));
				float num6 = (float)Math.Cos(num4);
				float num7 = (pointF.X + pointF2.X) / 2f;
				double num8 = (double)((pointF.Y + pointF2.Y) / 2f);
				double num9 = (double)num7 + (double)num5 * curvature;
				double num10 = num8 + (double)num6 * curvature;
				double num11 = (double)pointF.X;
				double num12 = (double)pointF.Y;
				double num13 = (double)pointF2.X;
				double num14 = (double)pointF2.Y;
				double num15 = num9;
				double num16 = num10;
				double num17 = 2.0 * (num13 - num11);
				double num18 = 2.0 * (num14 - num12);
				double num19 = num13 * num13 - num11 * num11 + (num14 * num14 - num12 * num12);
				double num20 = 2.0 * (num15 - num11);
				double num21 = 2.0 * (num16 - num12);
				double num22 = num15 * num15 - num11 * num11 + (num16 * num16 - num12 * num12);
				double num23 = num17 * num21 - num20 * num18;
				if (Math.Abs(num23) < 9.9999999747524271E-07)
				{
					result = this.CreateLine(new GeoPoint[]
					{
						gp1,
						gp2
					});
				}
				else
				{
					double num24 = (num21 * num19 - num18 * num22) / num23;
					double num25 = (num17 * num22 - num20 * num19) / num23;
					double num26 = (double)((float)Math.Sqrt((num11 - num24) * (num11 - num24) + (num12 - num25) * (num12 - num25)));
					double num27 = (double)((float)(Math.Atan2(num12 - num25, num11 - num24) * 180.0 / 3.1415926535897931));
					double num28 = (double)((float)(Math.Atan2(num14 - num25, num13 - num24) * 180.0 / 3.1415926535897931));
					double num29 = Math.Atan2(num16 - num25, num15 - num24) * 180.0 / 3.1415926535897931;
					double num30 = (num28 - num27 + 360.0) % 360.0;
					double num31 = ((num29 - num27 + 360.0) % 360.0 <= num30) ? num30 : (-(360.0 - num30));
					List<GeoPoint> list = new List<GeoPoint>();
					list.Add(gp1);
					double num32 = Math.Abs(num31);
					int num33 = (int)Math.Round(Math.Max(10.0, Math.Abs(num31)));
					if (num32 < 1.0)
					{
						result = this.CreateLine(new GeoPoint[]
						{
							gp1,
							gp2
						});
					}
					else
					{
						double num34 = num31 / (double)num33;
						int num35 = num33 - 1;
						for (int i = 1; i <= num35; i++)
						{
							double num36 = (num27 + num34 * (double)i) * 3.1415926535897931 / 180.0;
							double x = num24 + num26 * Math.Cos(num36);
							double y = num25 + num26 * Math.Sin(num36);
							C1.Win.Interop.Point point = new C1.Win.Interop.Point(x, y);
							point = base.ScreenToGeographic(point);
							list.Add(new GeoPoint(point.X, point.Y));
						}
						list.Add(gp2);
						result = this.CreateLine(list);
					}
				}
			}
			return result;
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00079A79 File Offset: 0x00077C79
		public C1.Win.Map.VectorPolyline CreateBezierCurve(string GeoPointString)
		{
			return this.CreateBezierCurve(this.O0o000O._oo.(GeoPointString, 0)[0]);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00079A8F File Offset: 0x00077C8F
		public C1.Win.Map.VectorPolyline CreateBezierCurve(IEnumerable<GeoPoint> GeoPoints)
		{
			return this.O0o000O._oo.(GeoPoints, false, false);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00079A9A File Offset: 0x00077C9A
		public C1.Win.Map.VectorPolyline CreateBezierCurveArrow(string GeoPointString, bool Both = false)
		{
			return this.CreateBezierCurveArrow(this.O0o000O._oo.(GeoPointString, 0)[0], Both);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00079AB1 File Offset: 0x00077CB1
		public C1.Win.Map.VectorPolyline CreateBezierCurveArrow(IEnumerable<GeoPoint> GeoPoints, bool Both = false)
		{
			return this.O0o000O._oo.(GeoPoints, true, Both);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00079ABC File Offset: 0x00077CBC
		private C1.Win.Map.VectorPolyline <<EMPTY_NAME>>(IEnumerable<GeoPoint> A_0, bool A_1, bool A_2 = false)
		{
			List<PointF> list = new List<PointF>();
			try
			{
				foreach (GeoPoint geoPoint in A_0)
				{
					C1.Win.Interop.Point location = geoPoint.Location;
					list.Add(base.GeographicToScreen(location).ToPointF());
				}
			}
			finally
			{
				IEnumerator<GeoPoint> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			C1.Win.Map.VectorPolyline result;
			if (list.Count == 2)
			{
				if (A_1)
				{
					result = this.CreateLineWithArrow(A_0, A_2, 8.0, 30.0);
				}
				else
				{
					result = this.CreateLine(A_0);
				}
			}
			else if (list.Count > 2)
			{
				if (A_1)
				{
					list = ooO0O.O_O_.0oooo_oo.(list.ToArray(), 0.5235988f, 2f, 8f, 0.5f, 3, A_2);
				}
				else
				{
					list = ooO0O.O_O_.0oooo_oo.(list.ToArray(), -1f, 2f, 8f, 0.5f, 3, false);
				}
				List<GeoPoint> list2 = new List<GeoPoint>();
				try
				{
					foreach (PointF pointF in list)
					{
						C1.Win.Interop.Point point = new C1.Win.Interop.Point((double)pointF.X, (double)pointF.Y);
						point = base.ScreenToGeographic(point);
						list2.Add(new GeoPoint(point.X, point.Y));
					}
				}
				finally
				{
					List<PointF>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				result = this.CreateLine(list2);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00079C34 File Offset: 0x00077E34
		public C1.Win.Map.VectorPolyline CreateCurve(GeoPoint p1, GeoPoint p2, double curvature, float vault)
		{
			PointF pointF = base.GeographicToScreen(p1.Location).ToPointF();
			PointF pointF2 = base.GeographicToScreen(p2.Location).ToPointF();
			C1.Win.Map.VectorPolyline result;
			if (pointF.Equals(pointF2))
			{
				result = this.CreateLine(new GeoPoint[]
				{
					p1,
					p2
				});
			}
			else if (Math.Abs(curvature) < 0.001)
			{
				result = this.CreateLine(new GeoPoint[]
				{
					p1,
					p2
				});
			}
			else
			{
				vault = Math.Max(0f, Math.Min(1f, vault));
				double num = (double)(pointF2.X - pointF.X);
				double num2 = (double)(pointF2.Y - pointF.Y);
				double num3 = Math.Sqrt(num * num + num2 * num2);
				curvature = Math.Max(-10.0, Math.Min(10.0, curvature));
				curvature = curvature * num3 / 2.0;
				int num4 = (int)Math.Round(Math.Max(60.0, num3));
				double num5 = (double)pointF.X + num * (double)vault;
				double num6 = (double)pointF.Y + num2 * (double)vault;
				double num7 = -num2;
				double num8 = num;
				if (num3 > 0.001)
				{
					num7 /= num3;
					num8 /= num3;
				}
				double num9 = num5 + num7 * curvature * (num3 / 100.0);
				double num10 = num6 + num8 * curvature * (num3 / 100.0);
				PointF pointF3 = new PointF((float)num9, (float)num10);
				List<GeoPoint> list = new List<GeoPoint>();
				list.Add(p1);
				int num11 = num4 - 1;
				for (int i = 1; i <= num11; i++)
				{
					double num12 = (double)i / (double)num4;
					double x = (1.0 - num12) * (1.0 - num12) * (double)pointF.X + 2.0 * (1.0 - num12) * num12 * (double)pointF3.X + num12 * num12 * (double)pointF2.X;
					double y = (1.0 - num12) * (1.0 - num12) * (double)pointF.Y + 2.0 * (1.0 - num12) * num12 * (double)pointF3.Y + num12 * num12 * (double)pointF2.Y;
					C1.Win.Interop.Point point = new C1.Win.Interop.Point(x, y);
					point = base.ScreenToGeographic(point);
					list.Add(new GeoPoint(point.X, point.Y));
				}
				list.Add(p2);
				result = this.CreateLine(list);
			}
			return result;
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00079EF4 File Offset: 0x000780F4
		public C1.Win.Map.VectorPolyline CreateCurveWithArrow(GeoPoint p1, GeoPoint p2, double curvature, double vault, double arrowLength = 8.0, double arrowAngle = 30.0)
		{
			PointF pointF = base.GeographicToScreen(p1.Location).ToPointF();
			PointF pointF2 = base.GeographicToScreen(p2.Location).ToPointF();
			C1.Win.Map.VectorPolyline result;
			if (pointF.Equals(pointF2))
			{
				result = this.CreateLine(new GeoPoint[]
				{
					p1,
					p2
				});
			}
			else if (Math.Abs(curvature) < 0.001)
			{
				result = this.CreateLine(new GeoPoint[]
				{
					p1,
					p2
				});
			}
			else
			{
				vault = Math.Max(0.0, Math.Min(1.0, vault));
				double num = (double)(pointF2.X - pointF.X);
				double num2 = (double)(pointF2.Y - pointF.Y);
				double num3 = Math.Sqrt(num * num + num2 * num2);
				curvature = Math.Max(-10.0, Math.Min(10.0, curvature));
				curvature = curvature * num3 / 2.0;
				int num4 = (int)Math.Round(Math.Max(60.0, num3));
				double num5 = (double)pointF.X + num * vault;
				double num6 = (double)pointF.Y + num2 * vault;
				double num7 = -num2;
				double num8 = num;
				if (num3 > 0.001)
				{
					num7 /= num3;
					num8 /= num3;
				}
				double num9 = num5 + num7 * curvature * (num3 / 100.0);
				double num10 = num6 + num8 * curvature * (num3 / 100.0);
				PointF pointF3 = new PointF((float)num9, (float)num10);
				List<GeoPoint> list = new List<GeoPoint>();
				list.Add(p1);
				int num11 = num4 - 1;
				for (int i = 1; i <= num11; i++)
				{
					double num12 = (double)i / (double)num4;
					double x = (1.0 - num12) * (1.0 - num12) * (double)pointF.X + 2.0 * (1.0 - num12) * num12 * (double)pointF3.X + num12 * num12 * (double)pointF2.X;
					double y = (1.0 - num12) * (1.0 - num12) * (double)pointF.Y + 2.0 * (1.0 - num12) * num12 * (double)pointF3.Y + num12 * num12 * (double)pointF2.Y;
					C1.Win.Interop.Point point = new C1.Win.Interop.Point(x, y);
					point = base.ScreenToGeographic(point);
					list.Add(new GeoPoint(point.X, point.Y));
				}
				list.Add(p2);
				double num13 = (double)(pointF2.X - pointF3.X);
				double num14 = (double)(pointF2.Y - pointF3.Y);
				double num15 = (double)((float)Math.Sqrt(num13 * num13 + num14 * num14));
				if (num15 < 0.001)
				{
					result = this.CreateLine(new GeoPoint[]
					{
						p1,
						p2
					});
				}
				else
				{
					double num16 = num13 / num15;
					double num17 = num14 / num15;
					double num18 = arrowAngle * 3.1415926535897931 / 180.0;
					double num19 = (double)((float)Math.Cos(num18));
					double num20 = (double)((float)Math.Sin(num18));
					double num21 = num16 * num19 + num17 * num20;
					double num22 = -num16 * num20 + num17 * num19;
					double num23 = num16 * num19 - num17 * num20;
					double num24 = num16 * num20 + num17 * num19;
					PointF pointF4 = new PointF((float)((double)pointF2.X - num21 * arrowLength), (float)((double)pointF2.Y - num22 * arrowLength));
					PointF pointF5 = new PointF((float)((double)pointF2.X - num23 * arrowLength), (float)((double)pointF2.Y - num24 * arrowLength));
					C1.Win.Interop.Point point2 = new C1.Win.Interop.Point((double)pointF4.X, (double)pointF4.Y);
					C1.Win.Interop.Point point3 = new C1.Win.Interop.Point((double)pointF5.X, (double)pointF5.Y);
					point2 = base.ScreenToGeographic(point2);
					point3 = base.ScreenToGeographic(point3);
					list.Add(new GeoPoint(point2.X, point2.Y));
					list.Add(p2);
					list.Add(new GeoPoint(point3.X, point3.Y));
					result = this.CreateLine(list);
				}
			}
			return result;
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0007A346 File Offset: 0x00078546
		public void CreateArrowPoints(List<GeoPoint> LinePoints, double arrowLength, double arrowAngle)
		{
			this.CreateArrowPoints(LinePoints, arrowLength, arrowAngle, false);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0007A354 File Offset: 0x00078554
		public void CreateArrowPoints(List<GeoPoint> LinePoints, double arrowLength, double arrowAngle, bool isBothEnds)
		{
			GeoMap.O0OO0O0o o0OO0O0o = new GeoMap.O0OO0O0o();
			o0OO0O0o.O.oO_O_. = this;
			o0OO0O0o.OO0o._. = arrowLength;
			o0OO0O0o.O.oO_O_. = arrowAngle;
			if (LinePoints.Count < 2)
			{
				throw new ArgumentException("至少需要两个点才能绘制线条!");
			}
			Func<GeoPoint, GeoPoint, List<GeoPoint>> func = new Func<GeoPoint, GeoPoint, List<GeoPoint>>(o0OO0O0o.O.oO_O_.);
			GeoPoint arg = LinePoints[LinePoints.Count - 2];
			GeoPoint geoPoint = LinePoints[LinePoints.Count - 1];
			List<GeoPoint> list = func(arg, geoPoint);
			if (list.Count == 2)
			{
				LinePoints.Add(list[0]);
				LinePoints.Add(geoPoint);
				LinePoints.Add(list[1]);
			}
			if (isBothEnds)
			{
				GeoPoint arg2 = LinePoints[1];
				GeoPoint geoPoint2 = LinePoints[0];
				List<GeoPoint> list2 = func(arg2, geoPoint2);
				if (list2.Count == 2)
				{
					LinePoints.Insert(0, list2[1]);
					LinePoints.Insert(0, geoPoint2);
					LinePoints.Insert(0, list2[0]);
				}
			}
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0007A440 File Offset: 0x00078640
		public C1.Win.Map.VectorPolygon CreateRectangle(GeoPoint p1, GeoPoint p2)
		{
			GeoPoint geoPoint = new GeoPoint(p1.X, p2.Y);
			GeoPoint geoPoint2 = new GeoPoint(p2.X, p1.Y);
			return this.CreatePolygon(new GeoPoint[]
			{
				p1,
				geoPoint,
				p2,
				geoPoint2
			});
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0007A490 File Offset: 0x00078690
		public C1.Win.Map.VectorPolygon CreateRectangle(string pointsString)
		{
			string[] array = pointsString.Split(new char[]
			{
				','
			});
			C1.Win.Map.VectorPolygon result;
			if (array.Length == 4)
			{
				GeoPoint p = new GeoPoint(Conversions.ToDouble(array[0]), Conversions.ToDouble(array[1]));
				GeoPoint p2 = new GeoPoint(Conversions.ToDouble(array[2]), Conversions.ToDouble(array[3]));
				result = this.CreateRectangle(p, p2);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0007A4F0 File Offset: 0x000786F0
		private List<List<GeoPoint>> <<EMPTY_NAME>>(string A_0, int A_1)
		{
			List<List<GeoPoint>> list = new List<List<GeoPoint>>();
			string[] array = A_0.Split(new char[]
			{
				'\n',
				'|'
			});
			for (int i = 0; i < array.Length; i = checked(i + 1))
			{
				string[] array2 = array[i].Split(new char[]
				{
					',',
					'，'
				});
				List<GeoPoint> list2 = new List<GeoPoint>();
				int num = array2.Length - 1;
				for (int j = 0; j <= num; j += 2)
				{
					double x = Conversions.ToDouble(array2[j]);
					double y = Conversions.ToDouble(array2[j + 1]);
					GeoPoint item = new GeoPoint(x, y);
					list2.Add(item);
				}
				list.Add(list2);
				if (A_1 > 0 && list.Count > A_1 + 1)
				{
					break;
				}
			}
			return list;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0007A5B0 File Offset: 0x000787B0
		public VirtualLayer AddVirtualLayer(double minZoom)
		{
			VirtualLayer virtualLayer = new VirtualLayer(this, minZoom);
			base.Layers.Add(virtualLayer);
			return virtualLayer;
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0007A5D4 File Offset: 0x000787D4
		public VirtualLayer AddVirtualLayer(double minZoom, double maxZoom)
		{
			VirtualLayer virtualLayer = new VirtualLayer(this, minZoom, maxZoom);
			base.Layers.Add(virtualLayer);
			return virtualLayer;
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0007A5F8 File Offset: 0x000787F8
		public GeoPoint MouseGeoPosition
		{
			get
			{
				System.Drawing.Point value = base.PointToClient(Control.MousePosition);
				C1.Win.Interop.Point point = base.ScreenToGeographic(value);
				return new GeoPoint(point.X, point.Y);
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0007A631 File Offset: 0x00078831
		public void CenterTo(double X, double Y)
		{
			base.Viewport.Center = new C1.Win.Interop.Point(X, Y);
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0007A648 File Offset: 0x00078848
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x0007A680 File Offset: 0x00078880
		public GeoPoint Center
		{
			get
			{
				return new GeoPoint(base.Viewport.Center.X, base.Viewport.Center.X);
			}
			set
			{
				base.Viewport.Center = value.Location;
			}
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0007A694 File Offset: 0x00078894
		public C1.Win.Map.VectorItem CreatFromJsonObject(JObject FeatureItem, int MaxCount = -1)
		{
			string text = FeatureItem["geometry"]["type"].ToString();
			string left = text;
			C1.Win.Map.VectorItem result;
			if (Operators.CompareString(left, "Polygon", true) == 0)
			{
				List<GeoPoint> list = new List<GeoPoint>();
				try
				{
					foreach (JToken jtoken in ((IEnumerable<JToken>)FeatureItem["geometry"]["coordinates"]))
					{
						JArray jarray = (JArray)jtoken;
						try
						{
							foreach (JToken jtoken2 in jarray)
							{
								JArray jarray2 = (JArray)jtoken2;
								GeoPoint item = new GeoPoint((double)jarray2[0], (double)jarray2[1]);
								list.Add(item);
							}
						}
						finally
						{
							IEnumerator<JToken> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
				}
				finally
				{
					IEnumerator<JToken> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				result = this.CreatePolygon(list);
			}
			else if (Operators.CompareString(left, "MultiPolygon", true) == 0)
			{
				List<List<GeoPoint>> list2 = new List<List<GeoPoint>>();
				try
				{
					foreach (JToken jtoken3 in ((IEnumerable<JToken>)FeatureItem["geometry"]["coordinates"]))
					{
						JArray jarray3 = (JArray)jtoken3;
						List<GeoPoint> list3 = new List<GeoPoint>();
						try
						{
							foreach (JToken jtoken4 in jarray3)
							{
								JArray jarray4 = (JArray)jtoken4;
								try
								{
									foreach (JToken jtoken5 in jarray4)
									{
										JArray jarray5 = (JArray)jtoken5;
										GeoPoint item2 = new GeoPoint((double)jarray5[0], (double)jarray5[1]);
										list3.Add(item2);
									}
								}
								finally
								{
									IEnumerator<JToken> enumerator5;
									if (enumerator5 != null)
									{
										enumerator5.Dispose();
									}
								}
							}
						}
						finally
						{
							IEnumerator<JToken> enumerator4;
							if (enumerator4 != null)
							{
								enumerator4.Dispose();
							}
						}
						list2.Add(list3);
						if (MaxCount > 0 && list2.Count >= MaxCount)
						{
							break;
						}
					}
				}
				finally
				{
					IEnumerator<JToken> enumerator3;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
				}
				result = this.CreatePolygon(list2);
			}
			else if (Operators.CompareString(left, "Point", true) == 0)
			{
				JToken jtoken6 = FeatureItem["geometry"]["coordinates"];
				GeoPoint geometry = new GeoPoint((double)jtoken6[0], (double)jtoken6[1]);
				result = new C1.Win.Map.VectorPlacemark
				{
					Geometry = geometry
				};
			}
			else if (Operators.CompareString(left, "MultiPoint", true) == 0 || Operators.CompareString(left, "LineString", true) == 0)
			{
				new List<List<GeoPoint>>();
				List<GeoPoint> list4 = new List<GeoPoint>();
				try
				{
					foreach (JToken jtoken7 in ((IEnumerable<JToken>)FeatureItem["geometry"]["coordinates"]))
					{
						JArray jarray6 = (JArray)jtoken7;
						GeoPoint item3 = new GeoPoint((double)jarray6[0], (double)jarray6[1]);
						list4.Add(item3);
					}
				}
				finally
				{
					IEnumerator<JToken> enumerator6;
					if (enumerator6 != null)
					{
						enumerator6.Dispose();
					}
				}
				if (Operators.CompareString(text, "LineString", true) == 0)
				{
					result = this.CreateLine(list4);
				}
				else
				{
					result = this.CreatePlaceMark(list4);
				}
			}
			else if (Operators.CompareString(left, "MultiLineString", true) == 0)
			{
				List<List<GeoPoint>> list5 = new List<List<GeoPoint>>();
				try
				{
					foreach (JToken jtoken8 in ((IEnumerable<JToken>)FeatureItem["geometry"]["coordinates"]))
					{
						JArray jarray7 = (JArray)jtoken8;
						List<GeoPoint> list6 = new List<GeoPoint>();
						try
						{
							foreach (JToken jtoken9 in jarray7)
							{
								JArray jarray8 = (JArray)jtoken9;
								GeoPoint item4 = new GeoPoint((double)jarray8[0], (double)jarray8[1]);
								list6.Add(item4);
							}
						}
						finally
						{
							IEnumerator<JToken> enumerator8;
							if (enumerator8 != null)
							{
								enumerator8.Dispose();
							}
						}
						list5.Add(list6);
						if (MaxCount > 0 && list5.Count >= MaxCount)
						{
							break;
						}
					}
				}
				finally
				{
					IEnumerator<JToken> enumerator7;
					if (enumerator7 != null)
					{
						enumerator7.Dispose();
					}
				}
				result = this.CreateLine(list5);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x0007AB0C File Offset: 0x00078D0C
		public List<VectorRecord> CreateRecordsFromKML(string filepath)
		{
			List<VectorRecord> list = new List<VectorRecord>();
			using (Stream stream = File.OpenRead(filepath))
			{
				IEnumerable<GeoGeometryRecord> enumerable = KmlReader.Read(stream);
				try
				{
					foreach (GeoGeometryRecord geoGeometryRecord in enumerable)
					{
						C1.Win.Map.VectorItem a_ = GeoMap.O0o000O._oo.(geoGeometryRecord);
						list.Add(new VectorRecord(a_, geoGeometryRecord.Data));
					}
				}
				finally
				{
					IEnumerator<GeoGeometryRecord> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			return list;
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x0007AB98 File Offset: 0x00078D98
		public List<VectorRecord> CreateRecordsFromSHP(string shpFile, string dbfFile)
		{
			List<VectorRecord> list = new List<VectorRecord>();
			using (Stream stream = File.OpenRead(shpFile))
			{
				using (Stream stream2 = File.OpenRead(dbfFile))
				{
					IEnumerable<GeoGeometryRecord> enumerable = ShapeReader.Read(stream, stream2);
					try
					{
						foreach (GeoGeometryRecord geoGeometryRecord in enumerable)
						{
							C1.Win.Map.VectorItem a_ = GeoMap.O0o000O._oo.(geoGeometryRecord);
							list.Add(new VectorRecord(a_, geoGeometryRecord.Data));
						}
					}
					finally
					{
						IEnumerator<GeoGeometryRecord> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x0007AC48 File Offset: 0x00078E48
		private static C1.Win.Map.VectorItem <<EMPTY_NAME>>(GeoGeometryRecord A_0)
		{
			C1.Win.Map.VectorItem vectorItem;
			switch (A_0.Geometry.Type)
			{
			case GeoGeometryType.Point:
			case GeoGeometryType.MultiPoint:
				vectorItem = new C1.Win.Map.VectorPlacemark();
				break;
			case GeoGeometryType.LineString:
			case GeoGeometryType.MultiLineString:
				vectorItem = new C1.Win.Map.VectorPolyline();
				break;
			case GeoGeometryType.Polygon:
			case GeoGeometryType.MultiPolygon:
				vectorItem = new C1.Win.Map.VectorPolygon();
				break;
			default:
				return null;
			}
			vectorItem.GeometryData = WkCoder.ToBase64String(A_0.Geometry, WkCoder.WkbByteOrder.LittleEndian);
			return vectorItem;
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0007ACB4 File Offset: 0x00078EB4
		public Color GetKmlStyleColor(string s)
		{
			Color result;
			uint num;
			if (string.IsNullOrEmpty(s))
			{
				result = Color.Empty;
			}
			else if (!uint.TryParse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num))
			{
				result = Color.Empty;
			}
			else
			{
				int alpha = (int)((byte)((num & 4278190080u) >> 24));
				byte blue = (byte)((num & 16711680u) >> 16);
				byte green = (byte)((num & 65280u) >> 8);
				byte red = (byte)(num & 255u);
				result = Color.FromArgb(alpha, (int)red, (int)green, (int)blue);
			}
			return result;
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0007AD24 File Offset: 0x00078F24
		public CustomMarkShape CreateMarkShape()
		{
			return this.CreateMarkShape("");
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0007AD34 File Offset: 0x00078F34
		public CustomMarkShape CreateMarkShape(string ShapeTag)
		{
			if (this.O.oO_O_. == null)
			{
				this.O.oO_O_. = new Dictionary<string, CustomMarkShape>(StringComparer.OrdinalIgnoreCase);
			}
			CustomMarkShape result;
			if (this.O.oO_O_..ContainsKey(ShapeTag))
			{
				result = this.O.oO_O_.[ShapeTag];
			}
			else
			{
				CustomMarkShape customMarkShape = new CustomMarkShape(this, ShapeTag);
				this.O.oO_O_..Add(ShapeTag, customMarkShape);
				result = customMarkShape;
			}
			return result;
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x0007AD8E File Offset: 0x00078F8E
		public CustomMarkShape CreateMarkShape(object ShapeTag)
		{
			return new CustomMarkShape(this, RuntimeHelpers.GetObjectValue(ShapeTag));
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0007AD9C File Offset: 0x00078F9C
		public MarkTextShape CreateTextShape(string text)
		{
			return new MarkTextShape(text);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0007ADA4 File Offset: 0x00078FA4
		public MarkTextShape CreateTextShape(string text, int margin)
		{
			return new MarkTextShape(text, margin);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0007ADAD File Offset: 0x00078FAD
		public MarkImageShape CreateImageShape(string ImageFile)
		{
			return new MarkImageShape(OO_00oOO.GetImage(ImageFile));
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0007ADBA File Offset: 0x00078FBA
		public MarkImageShape CreateImageShape(Image image)
		{
			return new MarkImageShape(image);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0007ADC4 File Offset: 0x00078FC4
		private PointF <<EMPTY_NAME>>(System.Drawing.Point[] A_0)
		{
			double num = 0.0;
			double num2 = 0.0;
			foreach (System.Drawing.Point point in A_0)
			{
				num += (double)point.X;
				num2 += (double)point.Y;
			}
			return new PointF((float)(num / (double)A_0.Length), (float)(num2 / (double)A_0.Length));
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0007AE28 File Offset: 0x00079028
		private System.Drawing.Point[] <<EMPTY_NAME>>(System.Drawing.Point[] A_0, double A_1)
		{
			System.Drawing.Point[] result;
			if (A_0 == null || A_0.Length < 2)
			{
				result = ((A_0 == null) ? new System.Drawing.Point[0] : A_0);
			}
			else
			{
				PointF pointF = this.O0o000O._oo.(A_0);
				double num = A_1 * 3.1415926535897931 / 180.0;
				double num2 = Math.Cos(num);
				double num3 = Math.Sin(num);
				System.Drawing.Point[] array = new System.Drawing.Point[A_0.Length - 1 + 1];
				int num4 = A_0.Length - 1;
				for (int i = 0; i <= num4; i++)
				{
					double num5 = (double)((float)A_0[i].X - pointF.X);
					double num6 = (double)((float)A_0[i].Y - pointF.Y);
					double num7 = num5 * num2 - num6 * num3;
					double num8 = num5 * num3 + num6 * num2;
					array[i] = new System.Drawing.Point((int)Math.Round(num7 + (double)pointF.X), (int)Math.Round(num8 + (double)pointF.Y));
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0007AF18 File Offset: 0x00079118
		public List<GeoPoint> RolateGeoPoints(IEnumerable<GeoPoint> geoPoints, double angle)
		{
			List<System.Drawing.Point> list = new List<System.Drawing.Point>();
			try
			{
				foreach (GeoPoint geoPoint in geoPoints)
				{
					C1.Win.Interop.Point point = base.GeographicToScreen(geoPoint.Location);
					list.Add(new System.Drawing.Point((int)Math.Round(point.X), (int)Math.Round(point.Y)));
				}
			}
			finally
			{
				IEnumerator<GeoPoint> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			System.Drawing.Point[] array = this.O._O0O0_o.(list.ToArray(), angle);
			List<GeoPoint> list2 = new List<GeoPoint>();
			foreach (System.Drawing.Point point2 in array)
			{
				C1.Win.Interop.Point point3 = new C1.Win.Interop.Point((double)point2.X, (double)point2.Y);
				point3 = base.ScreenToGeographic(point3);
				list2.Add(new GeoPoint(point3.X, point3.Y));
			}
			list = null;
			return list2;
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0007B004 File Offset: 0x00079204
		public string RolateGeoPointString(string geoPointsString, double angle)
		{
			string[] array = geoPointsString.Split(new char[]
			{
				','
			});
			List<GeoPoint> list = new List<GeoPoint>();
			int num = array.Length - 2;
			for (int i = 0; i <= num; i += 2)
			{
				double x = Conversions.ToDouble(array[i]);
				double y = Conversions.ToDouble(array[i + 1]);
				list.Add(new GeoPoint(x, y));
			}
			list = this.RolateGeoPoints(list, angle);
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				foreach (GeoPoint geoPoint in list)
				{
					stringBuilder.Append(Conversions.ToString(geoPoint.X) + "," + Conversions.ToString(geoPoint.Y) + ",");
				}
			}
			finally
			{
				List<GeoPoint>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return stringBuilder.ToString().Trim(new char[]
			{
				','
			});
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0007B0F8 File Offset: 0x000792F8
		public string MoveGeoPointString(string geoPointsString, int dx, int dy)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string[] array = geoPointsString.Split(new char[]
			{
				','
			});
			int num = array.Length - 2;
			for (int i = 0; i <= num; i += 2)
			{
				double x = Conversions.ToDouble(array[i]);
				double y = Conversions.ToDouble(array[i + 1]);
				C1.Win.Interop.Point point = new C1.Win.Interop.Point(x, y);
				point = base.GeographicToScreen(point);
				PointF pointF = point.ToPointF();
				point = new C1.Win.Interop.Point((double)(pointF.X + (float)dx), (double)(pointF.Y + (float)dy));
				point = base.ScreenToGeographic(point);
				stringBuilder.Append(Conversions.ToString(point.X) + "," + Conversions.ToString(point.Y) + ",");
			}
			return stringBuilder.ToString().Trim(new char[]
			{
				','
			});
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0007B1D4 File Offset: 0x000793D4
		public string AlignGeoPointString(string TargettItemPointString, string TargetItemType, string ItemPointString, string ItemType, string Direction)
		{
			List<C1.Win.Interop.Point> list = new List<C1.Win.Interop.Point>();
			List<C1.Win.Interop.Point> list2 = new List<C1.Win.Interop.Point>();
			string[] array = TargettItemPointString.Split(new char[]
			{
				','
			});
			int num = array.Length - 2;
			for (int i = 0; i <= num; i += 2)
			{
				double x = Conversions.ToDouble(array[i]);
				double y = Conversions.ToDouble(array[i + 1]);
				list.Add(new C1.Win.Interop.Point(x, y));
			}
			array = ItemPointString.Split(new char[]
			{
				','
			});
			int num2 = array.Length - 2;
			for (int j = 0; j <= num2; j += 2)
			{
				double x2 = Conversions.ToDouble(array[j]);
				double y2 = Conversions.ToDouble(array[j + 1]);
				list2.Add(new C1.Win.Interop.Point(x2, y2));
			}
			C1.Win.Interop.Point[] array2 = this.o_0__oo.oo_.(list.ToArray(), TargetItemType, list2.ToArray(), ItemType, Direction);
			StringBuilder stringBuilder = new StringBuilder();
			int num3 = array2.Length - 1;
			for (int k = 0; k <= num3; k++)
			{
				stringBuilder.Append(Conversions.ToString(array2[k].X) + "," + Conversions.ToString(array2[k].Y) + ",");
			}
			return stringBuilder.ToString().Trim(new char[]
			{
				','
			});
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0007B318 File Offset: 0x00079518
		private C1.Win.Interop.Point[] <<EMPTY_NAME>>(C1.Win.Interop.Point[] A_0, string A_1, C1.Win.Interop.Point[] A_2, string A_3, string A_4)
		{
			if (Operators.CompareString(A_1, "Diamond", true) == 0)
			{
				C1.Win.Interop.Point point = A_0[0];
				C1.Win.Interop.Point point2 = A_0[1];
				A_0[0] = new C1.Win.Interop.Point(point.X, point2.Y);
				A_0[1] = new C1.Win.Interop.Point(point.X + (point2.X - point.X) * 2.0, point2.Y + (point.Y - point2.Y) * 2.0);
			}
			else if (Operators.CompareString(A_1, "Circle", true) == 0)
			{
				C1.Win.Interop.Point longLat = A_0[0];
				C1.Win.Interop.Point longLat2 = A_0[1];
				longLat = base.GeographicToScreen(longLat);
				longLat2 = base.GeographicToScreen(longLat2);
				double num = longLat2.X - longLat.X;
				double num2 = longLat2.Y - longLat.Y;
				double num3 = Math.Sqrt(num * num + num2 * num2);
				A_0[0] = new C1.Win.Interop.Point(longLat.X - num3, longLat.Y - num3);
				A_0[1] = new C1.Win.Interop.Point(longLat.X + num3, longLat.Y + num3);
				A_0[0] = base.ScreenToGeographic(A_0[0]);
				A_0[1] = base.ScreenToGeographic(A_0[1]);
			}
			if (Operators.CompareString(A_3, "Diamond", true) == 0)
			{
				C1.Win.Interop.Point point3 = A_2[0];
				C1.Win.Interop.Point point4 = A_2[1];
				A_2[0] = new C1.Win.Interop.Point(point3.X, point4.Y);
				A_2[1] = new C1.Win.Interop.Point(point3.X + (point4.X - point3.X) * 2.0, point4.Y + (point3.Y - point4.Y) * 2.0);
			}
			else if (Operators.CompareString(A_3, "Circle", true) == 0)
			{
				C1.Win.Interop.Point longLat3 = A_2[0];
				C1.Win.Interop.Point longLat4 = A_2[1];
				longLat3 = base.GeographicToScreen(longLat3);
				longLat4 = base.GeographicToScreen(longLat4);
				double num4 = longLat4.X - longLat3.X;
				double num5 = longLat4.Y - longLat3.Y;
				double num6 = Math.Sqrt(num4 * num4 + num5 * num5);
				A_2[0] = new C1.Win.Interop.Point(longLat3.X - num6, longLat3.Y - num6);
				A_2[1] = new C1.Win.Interop.Point(longLat3.X + num6, longLat3.Y + num6);
				A_2[0] = base.ScreenToGeographic(A_2[0]);
				A_2[1] = base.ScreenToGeographic(A_2[1]);
			}
			double num7;
			double num8;
			if (Operators.CompareString(A_4, "left", true) == 0)
			{
				num7 = this.O0o000O._oo.(A_2, true, false) - this.O0o000O._oo.(A_0, true, false);
			}
			else if (Operators.CompareString(A_4, "right", true) == 0)
			{
				num7 = this.O0o000O._oo.(A_2, true, true) - this.O0o000O._oo.(A_0, true, true);
			}
			else if (Operators.CompareString(A_4, "top", true) == 0)
			{
				num8 = this.O0o000O._oo.(A_2, false, true) - this.O0o000O._oo.(A_0, false, true);
			}
			else if (Operators.CompareString(A_4, "bottom", true) == 0)
			{
				num8 = this.O0o000O._oo.(A_2, false, false) - this.O0o000O._oo.(A_0, false, false);
			}
			int num9 = A_2.Length - 1;
			for (int i = 0; i <= num9; i++)
			{
				A_2[i].X = A_2[i].X - num7;
				A_2[i].Y = A_2[i].Y - num8;
			}
			if (Operators.CompareString(A_3, "Diamond", true) == 0)
			{
				C1.Win.Interop.Point point5 = A_2[0];
				C1.Win.Interop.Point point6 = A_2[1];
				A_2[0] = new C1.Win.Interop.Point(point5.X, (point5.Y + point6.Y) / 2.0);
				A_2[1] = new C1.Win.Interop.Point((point5.X + point6.X) / 2.0, point6.Y);
			}
			else if (Operators.CompareString(A_3, "Circle", true) == 0)
			{
				C1.Win.Interop.Point point7 = A_2[0];
				C1.Win.Interop.Point point8 = A_2[1];
				A_2[0] = new C1.Win.Interop.Point((point7.X + point8.X) / 2.0, (point7.Y + point8.Y) / 2.0);
				A_2[1] = new C1.Win.Interop.Point((point7.X + point8.X) / 2.0, point7.Y);
			}
			return A_2;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0007B7D8 File Offset: 0x000799D8
		private double <<EMPTY_NAME>>(C1.Win.Interop.Point[] A_0, bool A_1, bool A_2)
		{
			double num;
			if (A_2)
			{
				num = double.MinValue;
			}
			else
			{
				num = double.MaxValue;
			}
			int num2 = A_0.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (A_2)
				{
					if (A_1)
					{
						num = Math.Max(num, A_0[i].X);
					}
					else
					{
						num = Math.Max(num, A_0[i].Y);
					}
				}
				else if (A_1)
				{
					num = Math.Min(num, A_0[i].X);
				}
				else
				{
					num = Math.Min(num, A_0[i].Y);
				}
			}
			return num;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0007B86C File Offset: 0x00079A6C
		public string SameGeoPointString(string TargettItemPointString, string TargetItemType, string ItemPointString, string ItemType)
		{
			List<C1.Win.Interop.Point> list = new List<C1.Win.Interop.Point>();
			List<C1.Win.Interop.Point> list2 = new List<C1.Win.Interop.Point>();
			string[] array = TargettItemPointString.Split(new char[]
			{
				','
			});
			int num = array.Length - 2;
			for (int i = 0; i <= num; i += 2)
			{
				double x = Conversions.ToDouble(array[i]);
				double y = Conversions.ToDouble(array[i + 1]);
				list.Add(new C1.Win.Interop.Point(x, y));
			}
			array = ItemPointString.Split(new char[]
			{
				','
			});
			int num2 = array.Length - 2;
			for (int j = 0; j <= num2; j += 2)
			{
				double x2 = Conversions.ToDouble(array[j]);
				double y2 = Conversions.ToDouble(array[j + 1]);
				list2.Add(new C1.Win.Interop.Point(x2, y2));
			}
			C1.Win.Interop.Point[] array2 = this.O._O0O0_o.(list.ToArray(), TargetItemType, list2.ToArray(), ItemType);
			StringBuilder stringBuilder = new StringBuilder();
			int num3 = array2.Length - 1;
			for (int k = 0; k <= num3; k++)
			{
				stringBuilder.Append(Conversions.ToString(array2[k].X) + "," + Conversions.ToString(array2[k].Y) + ",");
			}
			return stringBuilder.ToString().Trim(new char[]
			{
				','
			});
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0007B9B0 File Offset: 0x00079BB0
		private C1.Win.Interop.Point[] <<EMPTY_NAME>>(C1.Win.Interop.Point[] A_0, string A_1, C1.Win.Interop.Point[] A_2, string A_3)
		{
			if (Operators.CompareString(A_1, "Diamond", true) == 0)
			{
				C1.Win.Interop.Point point = A_0[0];
				C1.Win.Interop.Point point2 = A_0[1];
				A_0[0] = new C1.Win.Interop.Point(point.X, point2.Y);
				A_0[1] = new C1.Win.Interop.Point(point.X + (point2.X - point.X) * 2.0, point2.Y + (point.Y - point2.Y) * 2.0);
			}
			else if (Operators.CompareString(A_1, "Circle", true) == 0)
			{
				C1.Win.Interop.Point longLat = A_0[0];
				C1.Win.Interop.Point longLat2 = A_0[1];
				longLat = base.GeographicToScreen(longLat);
				longLat2 = base.GeographicToScreen(longLat2);
				double num = longLat2.X - longLat.X;
				double num2 = longLat2.Y - longLat.Y;
				double num3 = Math.Sqrt(num * num + num2 * num2);
				A_0[0] = new C1.Win.Interop.Point(longLat.X - num3, longLat.Y - num3);
				A_0[1] = new C1.Win.Interop.Point(longLat.X + num3, longLat.Y + num3);
				A_0[0] = base.ScreenToGeographic(A_0[0]);
				A_0[1] = base.ScreenToGeographic(A_0[1]);
			}
			else if ((Operators.CompareString(A_1, "Line", true) == 0 || Operators.CompareString(A_1, "Bezier", true) == 0) && A_0.Length > 2)
			{
				return A_2;
			}
			if (Operators.CompareString(A_3, "Diamond", true) == 0)
			{
				C1.Win.Interop.Point point3 = A_2[0];
				C1.Win.Interop.Point point4 = A_2[1];
				A_2[0] = new C1.Win.Interop.Point(point3.X, point4.Y);
				A_2[1] = new C1.Win.Interop.Point(point3.X + (point4.X - point3.X) * 2.0, point4.Y + (point3.Y - point4.Y) * 2.0);
			}
			else if (Operators.CompareString(A_3, "Circle", true) == 0)
			{
				C1.Win.Interop.Point longLat3 = A_2[0];
				C1.Win.Interop.Point longLat4 = A_2[1];
				longLat3 = base.GeographicToScreen(longLat3);
				longLat4 = base.GeographicToScreen(longLat4);
				double num4 = longLat4.X - longLat3.X;
				double num5 = longLat4.Y - longLat3.Y;
				double num6 = Math.Sqrt(num4 * num4 + num5 * num5);
				A_2[0] = new C1.Win.Interop.Point(longLat3.X - num6, longLat3.Y - num6);
				A_2[1] = new C1.Win.Interop.Point(longLat3.X + num6, longLat3.Y + num6);
				A_2[0] = base.ScreenToGeographic(A_2[0]);
				A_2[1] = base.ScreenToGeographic(A_2[1]);
			}
			else if ((Operators.CompareString(A_3, "Line", true) == 0 || Operators.CompareString(A_3, "Bezier", true) == 0) && A_2.Length > 2)
			{
				return A_2;
			}
			double num7 = Math.Abs(A_0[1].X - A_0[0].X);
			double num8 = Math.Abs(A_0[1].Y - A_0[0].Y);
			if (Operators.CompareString(A_3, "Line", true) == 0 || Operators.CompareString(A_3, "Bezier", true) == 0)
			{
				if (Math.Round(A_2[0].X, 6) == Math.Round(A_2[1].X, 6))
				{
					if (A_2[1].Y > A_2[0].Y)
					{
						A_2[1].Y = A_2[0].Y + num8;
					}
					else
					{
						A_2[1].Y = A_2[0].Y - num8;
					}
				}
				else if (Math.Round(A_2[0].Y, 6) == Math.Round(A_2[1].Y, 6))
				{
					if (A_2[1].X > A_2[0].X)
					{
						A_2[1].X = A_2[0].X + num7;
					}
					else
					{
						A_2[1].X = A_2[0].X - num7;
					}
				}
				else
				{
					if (A_2[1].Y > A_2[0].Y)
					{
						A_2[1].Y = A_2[0].Y + num8;
					}
					else
					{
						A_2[1].Y = A_2[0].Y - num8;
					}
					if (A_2[1].X > A_2[0].X)
					{
						A_2[1].X = A_2[0].X + num7;
					}
					else
					{
						A_2[1].X = A_2[0].X - num7;
					}
				}
			}
			else
			{
				if (A_2[1].Y > A_2[0].Y)
				{
					A_2[1].Y = A_2[0].Y + num8;
				}
				else
				{
					A_2[1].Y = A_2[0].Y - num8;
				}
				if (A_2[1].X > A_2[0].X)
				{
					A_2[1].X = A_2[0].X + num7;
				}
				else
				{
					A_2[1].X = A_2[0].X - num7;
				}
			}
			if (Operators.CompareString(A_3, "Diamond", true) == 0)
			{
				C1.Win.Interop.Point point5 = A_2[0];
				C1.Win.Interop.Point point6 = A_2[1];
				A_2[0] = new C1.Win.Interop.Point(point5.X, (point5.Y + point6.Y) / 2.0);
				A_2[1] = new C1.Win.Interop.Point((point5.X + point6.X) / 2.0, point6.Y);
			}
			else if (Operators.CompareString(A_3, "Circle", true) == 0)
			{
				C1.Win.Interop.Point point7 = A_2[0];
				C1.Win.Interop.Point point8 = A_2[1];
				A_2[0] = new C1.Win.Interop.Point((point7.X + point8.X) / 2.0, (point7.Y + point8.Y) / 2.0);
				A_2[1] = new C1.Win.Interop.Point(point8.X, (point7.Y + point8.Y) / 2.0);
			}
			return A_2;
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0007C08C File Offset: 0x0007A28C
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x0007C108 File Offset: 0x0007A308
		public TileSoureEnum TileSource
		{
			get
			{
				TileSoureEnum result;
				if (base.TileLayer.TileSource == null)
				{
					result = TileSoureEnum.None;
				}
				else if (base.TileLayer.TileSource is VirtualEarthRoadSource)
				{
					result = TileSoureEnum.Road;
				}
				else if (base.TileLayer.TileSource is VirtualEarthAerialSource)
				{
					result = TileSoureEnum.Aerial;
				}
				else if (base.TileLayer.TileSource is VirtualEarthHybridSource)
				{
					result = TileSoureEnum.Hybrid;
				}
				else if (base.TileLayer.TileSource is CustomTileSource)
				{
					result = TileSoureEnum.Custom;
				}
				else
				{
					result = TileSoureEnum.None;
				}
				return result;
			}
			set
			{
				switch (value)
				{
				case TileSoureEnum.None:
					base.TileLayer.TileSource = null;
					return;
				case TileSoureEnum.Road:
					base.TileLayer.TileSource = new VirtualEarthRoadSource();
					return;
				case TileSoureEnum.Aerial:
					base.TileLayer.TileSource = new VirtualEarthAerialSource();
					return;
				case TileSoureEnum.Hybrid:
					base.TileLayer.TileSource = new VirtualEarthHybridSource();
					return;
				case TileSoureEnum.Custom:
					base.TileLayer.TileSource = new CustomTileSource(this);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0007C183 File Offset: 0x0007A383
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x0007C196 File Offset: 0x0007A396
		public double Zoom
		{
			get
			{
				return Math.Round(base.Viewport.Zoom, 6);
			}
			set
			{
				base.Viewport.Zoom = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x0007C1A4 File Offset: 0x0007A3A4
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x0007C1B1 File Offset: 0x0007A3B1
		public double MaxZoom
		{
			get
			{
				return base.Viewport.MaxZoom;
			}
			set
			{
				base.Viewport.MaxZoom = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0007C1BF File Offset: 0x0007A3BF
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x0007C1CC File Offset: 0x0007A3CC
		public double MinZoom
		{
			get
			{
				return base.Viewport.MinZoom;
			}
			set
			{
				base.Viewport.MinZoom = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x0007C1DA File Offset: 0x0007A3DA
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x0007C1E7 File Offset: 0x0007A3E7
		public bool ZoomToolVisible
		{
			get
			{
				return base.ZoomTool.Visible;
			}
			set
			{
				base.ZoomTool.Visible = value;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x0007C1F5 File Offset: 0x0007A3F5
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x0007C202 File Offset: 0x0007A402
		public bool PanToolVisible
		{
			get
			{
				return base.PanTool.Visible;
			}
			set
			{
				base.PanTool.Visible = value;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x0007C210 File Offset: 0x0007A410
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x0007C21D File Offset: 0x0007A41D
		public bool DistanceScaleVisible
		{
			get
			{
				return base.DistanceScale.Visible;
			}
			set
			{
				base.DistanceScale.Visible = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0007C22B File Offset: 0x0007A42B
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x0007C233 File Offset: 0x0007A433
		public int CurrentTabOrder
		{
			get
			{
				return this.O.oO_O_.;
			}
			set
			{
				this.O.oO_O_. = value;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x0007C23C File Offset: 0x0007A43C
		// (set) Token: 0x06001003 RID: 4099 RVA: 0x0007C244 File Offset: 0x0007A444
		public int MaxTabOrder
		{
			get
			{
				return this.OO0o._.;
			}
			set
			{
				this.OO0o._. = value;
			}
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0007C24D File Offset: 0x0007A44D
		public void StartSetTabOrder()
		{
			oOO0oo_o0.O00OO_O_oO_.o.(this, base.Controls);
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0007C25B File Offset: 0x0007A45B
		public void StopSetTabOrder()
		{
			oOO0oo_o0.O._0O0__o.(base.Controls);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0007C268 File Offset: 0x0007A468
		public GeoPoint GetGeoPointByDistanceAngle(GeoPoint startPoint, double distanceKm, double angleY)
		{
			angleY = -angleY;
			double num = startPoint.X * 3.1415926535897931 / 180.0;
			double num2 = startPoint.Y * 3.1415926535897931 / 180.0;
			double num3 = (90.0 - angleY) * 3.1415926535897931 / 180.0;
			double num4 = distanceKm / 6371.0;
			double num5 = Math.Asin(Math.Sin(num2) * Math.Cos(num4) + Math.Cos(num2) * Math.Sin(num4) * Math.Cos(num3));
			double num6 = num + Math.Atan2(Math.Sin(num3) * Math.Sin(num4) * Math.Cos(num2), Math.Cos(num4) - Math.Sin(num2) * Math.Sin(num5));
			double y = num5 * 180.0 / 3.1415926535897931;
			double num7;
			for (num7 = num6 * 180.0 / 3.1415926535897931; num7 > 180.0; num7 -= 360.0)
			{
			}
			while (num7 < -180.0)
			{
				num7 += 360.0;
			}
			return new GeoPoint(num7, y);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0007C3A0 File Offset: 0x0007A5A0
		public bool IsGeoPointInPolygon(GeoPoint gp, C1.Win.Map.VectorPolygon polygon)
		{
			C1.Win.Interop.Point longLat = new C1.Win.Interop.Point(gp.X, gp.Y);
			PointF a_ = base.GeographicToScreen(longLat).ToPointF();
			List<PointF> list = new List<PointF>();
			if (polygon.Geometry is GeoPolygon)
			{
				try
				{
					foreach (GeoLinearRing geoLinearRing in ((GeoPolygon)polygon.Geometry).Rings)
					{
						list.Clear();
						try
						{
							foreach (GeoPoint geoPoint in geoLinearRing.Points)
							{
								longLat = new C1.Win.Interop.Point(geoPoint.X, geoPoint.Y);
								list.Add(base.GeographicToScreen(longLat).ToPointF());
							}
						}
						finally
						{
							IEnumerator<GeoPoint> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
						if (this.OoO_0o.0O00.(a_, list))
						{
							return true;
						}
					}
				}
				finally
				{
					IEnumerator<GeoLinearRing> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			return false;
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0007C4B0 File Offset: 0x0007A6B0
		private bool <<EMPTY_NAME>>(PointF A_0, List<PointF> A_1)
		{
			bool result;
			if (A_1.Count < 3)
			{
				result = false;
			}
			else
			{
				int count = A_1.Count;
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					PointF a_ = A_1[i];
					PointF a_2 = A_1[(i + 1) % count];
					if (this.OoO_0o.0O00.(A_0, a_, a_2))
					{
						return true;
					}
				}
				bool flag = false;
				int num2 = count - 1;
				for (int j = 0; j <= num2; j++)
				{
					PointF pointF = A_1[j];
					PointF pointF2 = A_1[(j + 1) % count];
					float y = pointF.Y;
					float y2 = pointF2.Y;
					if (y != y2 && (y > A_0.Y ^ y2 > A_0.Y))
					{
						float num3 = (A_0.Y - y) / (y2 - y);
						if (pointF.X + num3 * (pointF2.X - pointF.X) > A_0.X)
						{
							flag = !flag;
						}
					}
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0007C5B8 File Offset: 0x0007A7B8
		private bool <<EMPTY_NAME>>(PointF A_0, PointF A_1, PointF A_2)
		{
			return A_0.X >= Math.Min(A_1.X, A_2.X) - 0.0001f && A_0.X <= Math.Max(A_1.X, A_2.X) + 0.0001f && A_0.Y >= Math.Min(A_1.Y, A_2.Y) - 0.0001f && A_0.Y <= Math.Max(A_1.Y, A_2.Y) + 0.0001f && Math.Abs((A_2.X - A_1.X) * (A_0.Y - A_1.Y) - (A_2.Y - A_1.Y) * (A_0.X - A_1.X)) < 0.0001f;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0007C6A8 File Offset: 0x0007A8A8
		public C1.Win.Map.VectorPolygon CreateEllipse(string PointsString)
		{
			string[] array = PointsString.Split(new char[]
			{
				','
			});
			C1.Win.Map.VectorPolygon result;
			if (array.Length == 4)
			{
				GeoPoint gp = new GeoPoint(Conversions.ToDouble(array[0]), Conversions.ToDouble(array[1]));
				GeoPoint gp2 = new GeoPoint(Conversions.ToDouble(array[2]), Conversions.ToDouble(array[3]));
				result = this.CreateEllipse(gp, gp2);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0007C708 File Offset: 0x0007A908
		public C1.Win.Map.VectorPolygon CreateEllipse(GeoPoint gp1, GeoPoint gp2)
		{
			List<GeoPoint> list = new List<GeoPoint>();
			double num = Math.Min(gp1.X, gp2.X);
			double num2 = Math.Max(gp1.X, gp2.X);
			double num3 = Math.Min(gp1.Y, gp2.Y);
			double num4 = Math.Max(gp1.Y, gp2.Y);
			C1.Win.Interop.Point longLat = new C1.Win.Interop.Point(num, num3);
			C1.Win.Interop.Point longLat2 = new C1.Win.Interop.Point(num2, num4);
			longLat = base.GeographicToScreen(longLat);
			longLat2 = base.GeographicToScreen(longLat2);
			num = Math.Min(longLat.X, longLat2.X);
			num2 = Math.Max(longLat.X, longLat2.X);
			num3 = Math.Min(longLat.Y, longLat2.Y);
			num4 = Math.Max(longLat.Y, longLat2.Y);
			double num5 = (num + num2) / 2.0;
			double num6 = (num3 + num4) / 2.0;
			double num7 = (num2 - num) / 2.0;
			double num8 = (num4 - num3) / 2.0;
			int num9 = 0;
			do
			{
				double num10 = (double)num9 * 3.1415926535897931 / 180.0;
				double x = num5 + num7 * Math.Cos(num10);
				double y = num6 + num8 * Math.Sin(num10);
				C1.Win.Interop.Point point = new C1.Win.Interop.Point(x, y);
				point = base.ScreenToGeographic(point);
				list.Add(new GeoPoint(point.X, point.Y));
				num9++;
			}
			while (num9 <= 359);
			return this.CreatePolygon(list);
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0007C898 File Offset: 0x0007AA98
		public C1.Win.Map.VectorPolygon CreateDiamond(GeoPoint gp1, GeoPoint gp2)
		{
			return this.CreateDiamond(gp1, gp2, false);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0007C8A4 File Offset: 0x0007AAA4
		public C1.Win.Map.VectorPolygon CreateDiamond(GeoPoint gp1, GeoPoint gp2, bool diagonal)
		{
			C1.Win.Map.VectorPolygon result;
			if (diagonal)
			{
				C1.Win.Interop.Point point = base.GeographicToScreen(gp1.Location);
				C1.Win.Interop.Point point2 = base.GeographicToScreen(gp2.Location);
				C1.Win.Interop.Point point3 = new C1.Win.Interop.Point(point2.X, point.Y);
				C1.Win.Interop.Point point4 = new C1.Win.Interop.Point(point.X, point2.Y);
				C1.Win.Interop.Point point5 = new C1.Win.Interop.Point((point.X + point3.X) / 2.0, point.Y);
				C1.Win.Interop.Point point6 = new C1.Win.Interop.Point(point3.X, (point.Y + point4.Y) / 2.0);
				C1.Win.Interop.Point point7 = new C1.Win.Interop.Point((point.X + point3.X) / 2.0, point2.Y);
				C1.Win.Interop.Point point8 = new C1.Win.Interop.Point(point.X, (point.Y + point4.Y) / 2.0);
				point5 = base.ScreenToGeographic(point5);
				point6 = base.ScreenToGeographic(point6);
				point7 = base.ScreenToGeographic(point7);
				point8 = base.ScreenToGeographic(point8);
				result = this.CreatePolygon(new GeoPoint[]
				{
					new GeoPoint(point5.X, point5.Y),
					new GeoPoint(point6.X, point6.Y),
					new GeoPoint(point7.X, point7.Y),
					new GeoPoint(point8.X, point8.Y)
				});
			}
			else
			{
				C1.Win.Interop.Point point9 = base.GeographicToScreen(gp1.Location);
				C1.Win.Interop.Point point10 = base.GeographicToScreen(gp2.Location);
				C1.Win.Interop.Point point11 = new C1.Win.Interop.Point(point9.X + (point10.X - point9.X) * 2.0, point9.Y);
				C1.Win.Interop.Point point12 = new C1.Win.Interop.Point(point10.X, point10.Y + (point9.Y - point10.Y) * 2.0);
				point11 = base.ScreenToGeographic(point11);
				point12 = base.ScreenToGeographic(point12);
				result = this.CreatePolygon(new GeoPoint[]
				{
					gp1,
					gp2,
					new GeoPoint(point11.X, point11.Y),
					new GeoPoint(point12.X, point12.Y)
				});
			}
			return result;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0007CAF9 File Offset: 0x0007ACF9
		public C1.Win.Map.VectorPolygon CreateDiamond(string PointsString)
		{
			return this.CreateDiamond(PointsString, false);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0007CB04 File Offset: 0x0007AD04
		public C1.Win.Map.VectorPolygon CreateDiamond(string PointsString, bool diagonal)
		{
			string[] array = PointsString.Split(new char[]
			{
				','
			});
			C1.Win.Map.VectorPolygon result;
			if (array.Length == 4)
			{
				GeoPoint gp = new GeoPoint(Conversions.ToDouble(array[0]), Conversions.ToDouble(array[1]));
				GeoPoint gp2 = new GeoPoint(Conversions.ToDouble(array[2]), Conversions.ToDouble(array[3]));
				result = this.CreateDiamond(gp, gp2, diagonal);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x0007CB64 File Offset: 0x0007AD64
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x0007CB90 File Offset: 0x0007AD90
		public bool UseGallPetersProjection
		{
			get
			{
				return ((GeographicCoordinateSystem)base.CoordinateSystem).Projection is oo_Oo0O_O;
			}
			set
			{
				GeographicCoordinateSystem geographicCoordinateSystem = (GeographicCoordinateSystem)base.CoordinateSystem;
				geographicCoordinateSystem.Projection = new oo_Oo0O_O();
			}
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0007CBB4 File Offset: 0x0007ADB4
		public System.Drawing.Point ToScreenPoint(GeoPoint point)
		{
			C1.Win.Interop.Point longLat = point.Location;
			longLat = base.GeographicToScreen(longLat);
			return new System.Drawing.Point((int)Math.Round(longLat.X), (int)Math.Round(longLat.Y));
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0007CBF0 File Offset: 0x0007ADF0
		public string ToScreenPointsString(string points)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string[] array = points.Split(new char[]
			{
				','
			});
			int num = array.Length - 1;
			for (int i = 0; i <= num; i += 2)
			{
				double x = Conversions.ToDouble(array[i]);
				double y = Conversions.ToDouble(array[i + 1]);
				C1.Win.Interop.Point longLat = new C1.Win.Interop.Point(x, y);
				longLat = base.GeographicToScreen(longLat);
				stringBuilder.Append(Conversions.ToString((int)Math.Round(longLat.X)) + "," + Conversions.ToString((int)Math.Round(longLat.Y)) + ",");
			}
			return stringBuilder.ToString().Trim(new char[]
			{
				','
			});
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0007CCA4 File Offset: 0x0007AEA4
		public GeoPoint ToGeoPoint(System.Drawing.Point point)
		{
			C1.Win.Interop.Point point2 = new C1.Win.Interop.Point((double)point.X, (double)point.Y);
			point2 = base.ScreenToGeographic(point2);
			return new GeoPoint(point2.X, point2.Y);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0007CCE4 File Offset: 0x0007AEE4
		public string ToGeoPointsString(string points)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string[] array = points.Split(new char[]
			{
				','
			});
			int num = array.Length - 1;
			for (int i = 0; i <= num; i += 2)
			{
				double x = Conversions.ToDouble(array[i]);
				double y = Conversions.ToDouble(array[i + 1]);
				C1.Win.Interop.Point point = new C1.Win.Interop.Point(x, y);
				point = base.ScreenToGeographic(point);
				stringBuilder.Append(Conversions.ToString(point.X) + "," + Conversions.ToString(point.Y) + ",");
			}
			return stringBuilder.ToString().Trim(new char[]
			{
				','
			});
		}

		// Token: 0x0400063F RID: 1599
		internal Dictionary<string, CustomMarkShape> <<EMPTY_NAME>>;

		// Token: 0x04000640 RID: 1600
		private int <<EMPTY_NAME>>;

		// Token: 0x04000641 RID: 1601
		private int <<EMPTY_NAME>>;

		// Token: 0x02000143 RID: 323
		[CompilerGenerated]
		internal sealed class O0OO0O0o
		{
			// Token: 0x0600101D RID: 4125 RVA: 0x0007CD94 File Offset: 0x0007AF94
			internal List<GeoPoint> <<EMPTY_NAME>>(GeoPoint A_0, GeoPoint A_1)
			{
				List<GeoPoint> list = new List<GeoPoint>();
				PointF pointF = this.O.oO_O_..GeographicToScreen(A_0.Location).ToPointF();
				PointF pointF2 = this.O.oO_O_..GeographicToScreen(A_1.Location).ToPointF();
				double num = (double)(pointF2.X - pointF.X);
				double num2 = (double)(pointF2.Y - pointF.Y);
				double num3 = Math.Sqrt(num * num + num2 * num2);
				List<GeoPoint> result;
				if (num3 <= 0.0)
				{
					result = list;
				}
				else
				{
					double num4 = num / num3;
					double num5 = num2 / num3;
					double num6 = -num4;
					double num7 = -num5;
					double num8 = this.O.oO_O_. / 180.0 * 3.1415926535897931;
					double num9 = Math.Cos(num8);
					double num10 = Math.Sin(num8);
					double x = (double)pointF2.X + (num6 * num9 - num7 * num10) * this.OO0o._.;
					double y = (double)pointF2.Y + (num6 * num10 + num7 * num9) * this.OO0o._.;
					double x2 = (double)pointF2.X + (num6 * num9 + num7 * num10) * this.OO0o._.;
					double y2 = (double)pointF2.Y + (-num6 * num10 + num7 * num9) * this.OO0o._.;
					C1.Win.Interop.Point point = new C1.Win.Interop.Point(x, y);
					C1.Win.Interop.Point point2 = new C1.Win.Interop.Point(x2, y2);
					point = this.O.oO_O_..ScreenToGeographic(point);
					point2 = this.O.oO_O_..ScreenToGeographic(point2);
					list.Add(new GeoPoint(point.X, point.Y));
					list.Add(new GeoPoint(point2.X, point2.Y));
					result = list;
				}
				return result;
			}

			// Token: 0x04000642 RID: 1602
			public double <<EMPTY_NAME>>;

			// Token: 0x04000643 RID: 1603
			public double <<EMPTY_NAME>>;

			// Token: 0x04000644 RID: 1604
			public GeoMap <<EMPTY_NAME>>;
		}
	}
}
