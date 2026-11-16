using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using C1.Win.C1Chart;

namespace Foxtable.WinForm
{
	// Token: 0x02000515 RID: 1301
	[ComVisible(true)]
	public class ChartAxis
	{
		// Token: 0x060055F5 RID: 22005 RVA: 0x0025A4AF File Offset: 0x002586AF
		public ChartAxis(Axis A_0)
		{
			this.oOOO_.__oO0O. = A_0;
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x060055F6 RID: 22006 RVA: 0x0025A4BE File Offset: 0x002586BE
		// (set) Token: 0x060055F7 RID: 22007 RVA: 0x0025A4CB File Offset: 0x002586CB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AutoMax
		{
			get
			{
				return this.oOOO_.__oO0O..AutoMax;
			}
			set
			{
				this.oOOO_.__oO0O..AutoMax = value;
			}
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x060055F8 RID: 22008 RVA: 0x0025A4D9 File Offset: 0x002586D9
		// (set) Token: 0x060055F9 RID: 22009 RVA: 0x0025A4E6 File Offset: 0x002586E6
		[oO0oooo("1016")]
		public double Max
		{
			get
			{
				return this.oOOO_.__oO0O..Max;
			}
			set
			{
				this.AutoMax = false;
				this.oOOO_.__oO0O..Max = value;
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x060055FA RID: 22010 RVA: 0x0025A4FB File Offset: 0x002586FB
		// (set) Token: 0x060055FB RID: 22011 RVA: 0x0025A50D File Offset: 0x0025870D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DateTime MaxDate
		{
			get
			{
				return DateTime.FromOADate(this.oOOO_.__oO0O..Max);
			}
			set
			{
				this.AutoMax = false;
				this.oOOO_.__oO0O..Max = value.ToOADate();
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x060055FC RID: 22012 RVA: 0x0025A528 File Offset: 0x00258728
		// (set) Token: 0x060055FD RID: 22013 RVA: 0x0025A535 File Offset: 0x00258735
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AutoMin
		{
			get
			{
				return this.oOOO_.__oO0O..AutoMin;
			}
			set
			{
				this.oOOO_.__oO0O..AutoMin = value;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x060055FE RID: 22014 RVA: 0x0025A543 File Offset: 0x00258743
		// (set) Token: 0x060055FF RID: 22015 RVA: 0x0025A550 File Offset: 0x00258750
		[oO0oooo("1016")]
		public double Min
		{
			get
			{
				return this.oOOO_.__oO0O..Min;
			}
			set
			{
				this.AutoMin = false;
				this.oOOO_.__oO0O..Min = value;
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06005600 RID: 22016 RVA: 0x0025A565 File Offset: 0x00258765
		// (set) Token: 0x06005601 RID: 22017 RVA: 0x0025A577 File Offset: 0x00258777
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DateTime MinDate
		{
			get
			{
				return DateTime.FromOADate(this.oOOO_.__oO0O..Min);
			}
			set
			{
				this.AutoMin = false;
				this.oOOO_.__oO0O..Min = value.ToOADate();
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06005602 RID: 22018 RVA: 0x0025A592 File Offset: 0x00258792
		// (set) Token: 0x06005603 RID: 22019 RVA: 0x0025A59F File Offset: 0x0025879F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AutoOrigin
		{
			get
			{
				return this.oOOO_.__oO0O..AutoOrigin;
			}
			set
			{
				this.oOOO_.__oO0O..AutoOrigin = value;
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06005604 RID: 22020 RVA: 0x0025A5AD File Offset: 0x002587AD
		// (set) Token: 0x06005605 RID: 22021 RVA: 0x0025A5BA File Offset: 0x002587BA
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double Origin
		{
			get
			{
				return this.oOOO_.__oO0O..Origin;
			}
			set
			{
				this.oOOO_.__oO0O..Origin = value;
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06005606 RID: 22022 RVA: 0x0025A5C8 File Offset: 0x002587C8
		// (set) Token: 0x06005607 RID: 22023 RVA: 0x0025A5D5 File Offset: 0x002587D5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AutoMajor
		{
			get
			{
				return this.oOOO_.__oO0O..AutoMajor;
			}
			set
			{
				this.oOOO_.__oO0O..AutoMajor = value;
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06005608 RID: 22024 RVA: 0x0025A5E3 File Offset: 0x002587E3
		// (set) Token: 0x06005609 RID: 22025 RVA: 0x0025A5F0 File Offset: 0x002587F0
		[oO0oooo("1018")]
		public double Major
		{
			get
			{
				return this.oOOO_.__oO0O..UnitMajor;
			}
			set
			{
				this.oOOO_.__oO0O..UnitMajor = value;
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x0600560A RID: 22026 RVA: 0x0025A5FE File Offset: 0x002587FE
		// (set) Token: 0x0600560B RID: 22027 RVA: 0x0025A60E File Offset: 0x0025880E
		public bool MajorTick
		{
			get
			{
				return this.oOOO_.__oO0O..TickMajor > TickMarksEnum.None;
			}
			set
			{
				if (value)
				{
					this.oOOO_.__oO0O..TickMajor = TickMarksEnum.Outside;
					return;
				}
				this.oOOO_.__oO0O..TickMajor = TickMarksEnum.None;
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x0600560C RID: 22028 RVA: 0x0025A62C File Offset: 0x0025882C
		// (set) Token: 0x0600560D RID: 22029 RVA: 0x0025A63E File Offset: 0x0025883E
		public bool GridMajorVisible
		{
			get
			{
				return this.oOOO_.__oO0O..GridMajor.Visible;
			}
			set
			{
				this.oOOO_.__oO0O..GridMajor.Visible = value;
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x0600560E RID: 22030 RVA: 0x0025A651 File Offset: 0x00258851
		// (set) Token: 0x0600560F RID: 22031 RVA: 0x0025A663 File Offset: 0x00258863
		[oO0oooo("6003")]
		public Color GridMajorColor
		{
			get
			{
				return this.oOOO_.__oO0O..GridMajor.Color;
			}
			set
			{
				this.oOOO_.__oO0O..GridMajor.Color = value;
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06005610 RID: 22032 RVA: 0x0025A676 File Offset: 0x00258876
		// (set) Token: 0x06005611 RID: 22033 RVA: 0x0025A683 File Offset: 0x00258883
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AutoMinor
		{
			get
			{
				return this.oOOO_.__oO0O..AutoMinor;
			}
			set
			{
				this.oOOO_.__oO0O..AutoMinor = value;
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06005612 RID: 22034 RVA: 0x0025A691 File Offset: 0x00258891
		// (set) Token: 0x06005613 RID: 22035 RVA: 0x0025A69E File Offset: 0x0025889E
		public double Minor
		{
			get
			{
				return this.oOOO_.__oO0O..UnitMinor;
			}
			set
			{
				this.oOOO_.__oO0O..UnitMinor = value;
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06005614 RID: 22036 RVA: 0x0025A6AC File Offset: 0x002588AC
		// (set) Token: 0x06005615 RID: 22037 RVA: 0x0025A6BC File Offset: 0x002588BC
		public bool MinorTick
		{
			get
			{
				return this.oOOO_.__oO0O..TickMinor > TickMarksEnum.None;
			}
			set
			{
				if (value)
				{
					this.oOOO_.__oO0O..TickMinor = TickMarksEnum.Outside;
					return;
				}
				this.oOOO_.__oO0O..TickMinor = TickMarksEnum.None;
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06005616 RID: 22038 RVA: 0x0025A6DA File Offset: 0x002588DA
		// (set) Token: 0x06005617 RID: 22039 RVA: 0x0025A6EC File Offset: 0x002588EC
		public bool GridMinorVisible
		{
			get
			{
				return this.oOOO_.__oO0O..GridMinor.Visible;
			}
			set
			{
				this.oOOO_.__oO0O..GridMinor.Visible = value;
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06005618 RID: 22040 RVA: 0x0025A6FF File Offset: 0x002588FF
		// (set) Token: 0x06005619 RID: 22041 RVA: 0x0025A711 File Offset: 0x00258911
		public Color GridMinorColor
		{
			get
			{
				return this.oOOO_.__oO0O..GridMinor.Color;
			}
			set
			{
				this.oOOO_.__oO0O..GridMinor.Color = value;
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x0600561A RID: 22042 RVA: 0x0025A724 File Offset: 0x00258924
		// (set) Token: 0x0600561B RID: 22043 RVA: 0x0025A731 File Offset: 0x00258931
		[oO0oooo("1025")]
		public bool Reversed
		{
			get
			{
				return this.oOOO_.__oO0O..Reversed;
			}
			set
			{
				this.oOOO_.__oO0O..Reversed = value;
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x0600561C RID: 22044 RVA: 0x0025A73F File Offset: 0x0025893F
		// (set) Token: 0x0600561D RID: 22045 RVA: 0x0025A74C File Offset: 0x0025894C
		[oO0oooo("1024")]
		public CompassEnum Compass
		{
			get
			{
				return (CompassEnum)this.oOOO_.__oO0O..Compass;
			}
			set
			{
				this.oOOO_.__oO0O..Compass = (CompassEnum)value;
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x0600561E RID: 22046 RVA: 0x0025A75A File Offset: 0x0025895A
		// (set) Token: 0x0600561F RID: 22047 RVA: 0x0025A76A File Offset: 0x0025896A
		[oO0oooo("1029")]
		public bool AnnoWithLabels
		{
			get
			{
				return this.oOOO_.__oO0O..AnnoMethod == AnnotationMethodEnum.ValueLabels;
			}
			set
			{
				if (value)
				{
					this.oOOO_.__oO0O..AnnoMethod = AnnotationMethodEnum.ValueLabels;
					return;
				}
				this.oOOO_.__oO0O..AnnoMethod = AnnotationMethodEnum.Values;
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06005620 RID: 22048 RVA: 0x0025A788 File Offset: 0x00258988
		// (set) Token: 0x06005621 RID: 22049 RVA: 0x0025A795 File Offset: 0x00258995
		[oO0oooo("1030")]
		public int AnnoRotation
		{
			get
			{
				return this.oOOO_.__oO0O..AnnotationRotation;
			}
			set
			{
				this.oOOO_.__oO0O..AnnotationRotation = value;
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06005622 RID: 22050 RVA: 0x0025A7A3 File Offset: 0x002589A3
		// (set) Token: 0x06005623 RID: 22051 RVA: 0x0025A7B0 File Offset: 0x002589B0
		[oO0oooo("1031")]
		public string AnnoFormatString
		{
			get
			{
				return this.oOOO_.__oO0O..AnnoFormatString;
			}
			set
			{
				this.oOOO_.__oO0O..AnnoFormatString = value;
			}
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x0025A7BE File Offset: 0x002589BE
		[oO0oooo("1032")]
		public void SetValueLabel(object Value, string Label)
		{
			this.oOOO_.__oO0O..ValueLabels.Add(RuntimeHelpers.GetObjectValue(Value), Label);
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x0025A7D8 File Offset: 0x002589D8
		public void ClearValueLabel()
		{
			this.oOOO_.__oO0O..ValueLabels.Clear();
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06005626 RID: 22054 RVA: 0x0025A7EA File Offset: 0x002589EA
		// (set) Token: 0x06005627 RID: 22055 RVA: 0x0025A7F7 File Offset: 0x002589F7
		[oO0oooo("6006")]
		public StringAlignment Aligment
		{
			get
			{
				return this.oOOO_.__oO0O..Alignment;
			}
			set
			{
				this.oOOO_.__oO0O..Alignment = value;
			}
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06005628 RID: 22056 RVA: 0x0025A805 File Offset: 0x00258A05
		// (set) Token: 0x06005629 RID: 22057 RVA: 0x0025A812 File Offset: 0x00258A12
		public string Text
		{
			get
			{
				return this.oOOO_.__oO0O..Text;
			}
			set
			{
				this.oOOO_.__oO0O..Text = value;
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x0600562A RID: 22058 RVA: 0x0025A820 File Offset: 0x00258A20
		// (set) Token: 0x0600562B RID: 22059 RVA: 0x0025A82D File Offset: 0x00258A2D
		public Font Font
		{
			get
			{
				return this.oOOO_.__oO0O..Font;
			}
			set
			{
				this.oOOO_.__oO0O..Font = value;
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x0600562C RID: 22060 RVA: 0x0025A83C File Offset: 0x00258A3C
		// (set) Token: 0x0600562D RID: 22061 RVA: 0x0025A85E File Offset: 0x00258A5E
		public bool DateType
		{
			get
			{
				return this.oOOO_.__oO0O..AnnoFormat == FormatEnum.DateManual;
			}
			set
			{
				if (value)
				{
					this.oOOO_.__oO0O..AnnoFormat = FormatEnum.DateManual;
					return;
				}
				this.oOOO_.__oO0O..AnnoFormat = FormatEnum.NumericManual;
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x0600562E RID: 22062 RVA: 0x0025A87C File Offset: 0x00258A7C
		// (set) Token: 0x0600562F RID: 22063 RVA: 0x0025A889 File Offset: 0x00258A89
		public Color ForeColor
		{
			get
			{
				return this.oOOO_.__oO0O..ForeColor;
			}
			set
			{
				this.oOOO_.__oO0O..ForeColor = value;
			}
		}

		// Token: 0x040022BF RID: 8895
		private Axis <<EMPTY_NAME>>;
	}
}
