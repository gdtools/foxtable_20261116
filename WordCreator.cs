using System;
using System.Drawing;
using C1.C1Word;
using C1.C1Word.Objects;

namespace Foxtable
{
	// Token: 0x02000477 RID: 1143
	public class WordCreator : C1WordDocument
	{
		// Token: 0x06004E04 RID: 19972 RVA: 0x00232CF8 File Offset: 0x00230EF8
		public new void Save(string Filename)
		{
			string parentPath = OO_00oOO.FileSys.GetParentPath(Filename);
			if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
			{
				OO_00oOO.FileSys.CreateDirectory(parentPath);
			}
			base.Save(Filename);
		}

		// Token: 0x06004E05 RID: 19973 RVA: 0x00232D30 File Offset: 0x00230F30
		public new void DrawLine(Pen pen, PointF pt1, PointF pt2)
		{
			if ((pt1.X < pt2.X && pt1.Y > pt2.Y) || (pt2.X < pt1.X && pt2.Y > pt1.Y))
			{
				PointF[] points = new PointF[]
				{
					pt1,
					pt2,
					pt1,
					pt2
				};
				base.DrawPolyline(pen, points);
				return;
			}
			base.DrawLine(pen, pt1, pt2);
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x00232DB8 File Offset: 0x00230FB8
		public new void DrawLine(Pen pen, float x1, float y1, float x2, float y2)
		{
			if ((x1 < x2 && y1 > y2) || (x2 < x1 && y2 > y1))
			{
				PointF pt = new PointF(x1, y1);
				PointF pt2 = new PointF(x2, y2);
				this.DrawLine(pen, pt, pt2);
				return;
			}
			base.DrawLine(pen, x1, y1, x2, y2);
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x00232E04 File Offset: 0x00231004
		public void NewPage()
		{
			base.Add(new RtfSection
			{
				AutoNewPage = true
			});
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06004E08 RID: 19976 RVA: 0x00232E25 File Offset: 0x00231025
		public RtfColumnCollection Columns
		{
			get
			{
				return base.MainSection.Columns;
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06004E09 RID: 19977 RVA: 0x00232E32 File Offset: 0x00231032
		public RtfHeader Header
		{
			get
			{
				return base.MainSection.Header;
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06004E0A RID: 19978 RVA: 0x00232E3F File Offset: 0x0023103F
		public RtfFooter Footer
		{
			get
			{
				return base.MainSection.Footer;
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06004E0B RID: 19979 RVA: 0x00232E4C File Offset: 0x0023104C
		// (set) Token: 0x06004E0C RID: 19980 RVA: 0x00232E59 File Offset: 0x00231059
		public new SizeF PageSize
		{
			get
			{
				return base.MainSection.PageSize;
			}
			set
			{
				base.MainSection.PageSize = value;
			}
		}
	}
}
