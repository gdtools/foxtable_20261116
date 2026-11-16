using System;
using System.ComponentModel;
using System.Drawing;

namespace Foxtable
{
	// Token: 0x02000338 RID: 824
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class LookAndFeelProperty
	{
		// Token: 0x06002F4F RID: 12111 RVA: 0x001516F8 File Offset: 0x0014F8F8
		public LookAndFeelProperty()
		{
			this.Oo_.OOOO_Oo_. = true;
			this.O.oO0__. = Color.SteelBlue;
			this.o_O0_._O. = Color.Red;
			this.Oo.ooo00. = Color.Orange;
			this.ooO._O_. = Color.DarkGray;
			this.O0OOo._Oo00. = Color.Salmon;
			this.oOO0.o. = Color.BurlyWood;
			this.o00O__oo00O.0O. = GridLineDirectionEnum.Both;
			this.O.o_oO0_. = SystemColors.Control;
			this.o00O__oo00O.0O. = GridStyleEnum.Default;
			this.O_0O_O.0O0. = GridWidthEnum.Default;
			this.OoO00_Oo0o.o. = Color.Transparent;
			this.o00_.0ooOo. = Color.Transparent;
			this.oooO__.00_. = Color.Transparent;
			this.OOo0.OO_O000O. = Color.Transparent;
			this.o.oo0o0_0. = Color.Transparent;
			this.Oo00o.0O_o0O_o. = Color.Transparent;
			this.o0o.o0O0O0OOO0. = Color.Transparent;
			this.ooO0O0__o_.o0. = Color.Transparent;
			this.OO0O._Oo. = Color.Transparent;
			this.ooO.OOOoO. = Color.Transparent;
			this.oO.oO0ooO0_00o. = Color.Transparent;
			this.Oo.oo_0_. = Color.Transparent;
			this.o0O_o00O.0o_. = Color.Transparent;
			this.Oo0o.O0o0. = Color.Transparent;
			this.O.O_00O. = Color.PaleGreen;
			this.OooO0o_._0oOoO. = SystemColors.WindowText;
			this.Oo._oO0. = Color.LightYellow;
			this.Oooo_.oOoo0o. = SystemColors.WindowText;
			this.o__0.OO. = Color.Azure;
			this.oo.0o0OOoOOoo0. = SystemColors.WindowText;
			this.O0OO0.o_. = Color.Snow;
			this.OOOOo.O_. = SystemColors.WindowText;
			this.oo0_0O0._OO. = Color.Beige;
			this.O_o_0_._oO. = SystemColors.WindowText;
			this.ooO0.O0. = Color.AliceBlue;
			this.O_o.o_. = SystemColors.WindowText;
			this.O__O0o.o0. = Color.LightGoldenrodYellow;
			this.O.o0_oooo00. = SystemColors.WindowText;
			this.o._OO0. = Color.Transparent;
			this.o000OO0._oO_o. = Color.Transparent;
			this.O_oo.0O0__O_. = Color.Transparent;
			this.Oo0.0_O. = true;
			this.O_OO_0_0o__0.o. = true;
			this.OoOo000.O_. = true;
			this.O0_Oooo_.0O_0. = true;
			this.o0_.O_0_. = Color.Transparent;
			this.O.o_O_O. = Color.Transparent;
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002F50 RID: 12112 RVA: 0x001518FB File Offset: 0x0014FAFB
		// (set) Token: 0x06002F51 RID: 12113 RVA: 0x00151903 File Offset: 0x0014FB03
		[Browsable(false)]
		public string UserStyle
		{
			get
			{
				return this.O.oO0__.;
			}
			set
			{
				this.O.oO0__. = value;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002F52 RID: 12114 RVA: 0x0015190C File Offset: 0x0014FB0C
		// (set) Token: 0x06002F53 RID: 12115 RVA: 0x00151914 File Offset: 0x0014FB14
		[DefaultValue(true)]
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("显示行号")]
		[Description("如果显示了行号，则不显示锁定行标记。")]
		[Category("外观")]
		public bool ShowLineNumber
		{
			get
			{
				return this.Oo_.OOOO_Oo_.;
			}
			set
			{
				this.Oo_.OOOO_Oo_. = value;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002F54 RID: 12116 RVA: 0x0015191D File Offset: 0x0014FB1D
		// (set) Token: 0x06002F55 RID: 12117 RVA: 0x00151925 File Offset: 0x0014FB25
		[DefaultValue(-12156236)]
		[O_Oo00Oo000O0(3.0)]
		[Category("行号颜色")]
		[DisplayName("普通行")]
		public Color UnchangedRowHeaderForeColor
		{
			get
			{
				return this.O.oO0__.;
			}
			set
			{
				this.O.oO0__. = value;
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002F56 RID: 12118 RVA: 0x0015192E File Offset: 0x0014FB2E
		// (set) Token: 0x06002F57 RID: 12119 RVA: 0x00151936 File Offset: 0x0014FB36
		[DefaultValue(-65536)]
		[O_Oo00Oo000O0(4.0)]
		[Category("行号颜色")]
		[DisplayName("新增行")]
		public Color AddedRowHeaderForeColor
		{
			get
			{
				return this.o_O0_._O.;
			}
			set
			{
				this.o_O0_._O. = value;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002F58 RID: 12120 RVA: 0x0015193F File Offset: 0x0014FB3F
		// (set) Token: 0x06002F59 RID: 12121 RVA: 0x00151947 File Offset: 0x0014FB47
		[Category("行号颜色")]
		[DefaultValue(-23296)]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("已修改行")]
		public Color ModifiedRowHeaderForeColor
		{
			get
			{
				return this.Oo.ooo00.;
			}
			set
			{
				this.Oo.ooo00. = value;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002F5A RID: 12122 RVA: 0x00151950 File Offset: 0x0014FB50
		// (set) Token: 0x06002F5B RID: 12123 RVA: 0x00151958 File Offset: 0x0014FB58
		[DisplayName("普通行(锁定)")]
		[O_Oo00Oo000O0(6.0)]
		[DefaultValue(-5658199)]
		[Category("行号颜色")]
		public Color LockedRowHeaderForeColor
		{
			get
			{
				return this.ooO._O_.;
			}
			set
			{
				this.ooO._O_. = value;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002F5C RID: 12124 RVA: 0x00151961 File Offset: 0x0014FB61
		// (set) Token: 0x06002F5D RID: 12125 RVA: 0x00151969 File Offset: 0x0014FB69
		[Category("行号颜色")]
		[O_Oo00Oo000O0(7.0)]
		[Description("被锁定的新增行")]
		[DefaultValue(-360334)]
		[DisplayName("新增行(锁定)")]
		public Color LockedAddedRowHeaderForeColor
		{
			get
			{
				return this.O0OOo._Oo00.;
			}
			set
			{
				this.O0OOo._Oo00. = value;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002F5E RID: 12126 RVA: 0x00151972 File Offset: 0x0014FB72
		// (set) Token: 0x06002F5F RID: 12127 RVA: 0x0015197A File Offset: 0x0014FB7A
		[O_Oo00Oo000O0(8.0)]
		[DefaultValue(-2180985)]
		[Category("行号颜色")]
		[Description("被锁定的已修改行")]
		[DisplayName("已修改行(锁定)")]
		public Color LockedModifiedRowHeaderForeColor
		{
			get
			{
				return this.oOO0.o.;
			}
			set
			{
				this.oOO0.o. = value;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002F60 RID: 12128 RVA: 0x00151983 File Offset: 0x0014FB83
		// (set) Token: 0x06002F61 RID: 12129 RVA: 0x0015198B File Offset: 0x0014FB8B
		[O_Oo00Oo000O0(7.0)]
		[DisplayName("方向")]
		[DefaultValue(0)]
		[Category("网格线")]
		public GridLineDirectionEnum GridLineDirection
		{
			get
			{
				return this.o00O__oo00O.0O.;
			}
			set
			{
				this.o00O__oo00O.0O. = value;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002F62 RID: 12130 RVA: 0x00151994 File Offset: 0x0014FB94
		// (set) Token: 0x06002F63 RID: 12131 RVA: 0x0015199C File Offset: 0x0014FB9C
		[DefaultValue(0)]
		[O_Oo00Oo000O0(8.0)]
		[Category("网格线")]
		[DisplayName("类型")]
		public GridStyleEnum GridStyle
		{
			get
			{
				return this.o00O__oo00O.0O.;
			}
			set
			{
				this.o00O__oo00O.0O. = value;
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002F64 RID: 12132 RVA: 0x001519A5 File Offset: 0x0014FBA5
		// (set) Token: 0x06002F65 RID: 12133 RVA: 0x001519AD File Offset: 0x0014FBAD
		[O_Oo00Oo000O0(9.0)]
		[DefaultValue(0)]
		[Category("网格线")]
		[DisplayName("宽度")]
		public GridWidthEnum GridWidth
		{
			get
			{
				return this.O_0O_O.0O0.;
			}
			set
			{
				this.O_0O_O.0O0. = value;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002F66 RID: 12134 RVA: 0x001519B6 File Offset: 0x0014FBB6
		// (set) Token: 0x06002F67 RID: 12135 RVA: 0x001519BE File Offset: 0x0014FBBE
		[DefaultValue(16777215)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[Description("只有在网格类型为Flat、Dotted、Double的时候，网格线的颜色设置才有效。")]
		[O_Oo00Oo000O0(10.0)]
		[Category("网格线")]
		[DisplayName("颜色")]
		public Color GridColor
		{
			get
			{
				return this.O.o_oO0_.;
			}
			set
			{
				this.O.o_oO0_. = value;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002F68 RID: 12136 RVA: 0x001519C7 File Offset: 0x0014FBC7
		// (set) Token: 0x06002F69 RID: 12137 RVA: 0x001519CF File Offset: 0x0014FBCF
		[O_Oo00Oo000O0(11.0)]
		[Category("A.数据区")]
		[DisplayName("背景颜色")]
		[DefaultValue(16777215)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color BackColor
		{
			get
			{
				return this.OoO00_Oo0o.o.;
			}
			set
			{
				if (this.AlterRowBackColor == this.BackColor)
				{
					this.AlterRowBackColor = value;
				}
				this.OoO00_Oo0o.o. = value;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x001519F2 File Offset: 0x0014FBF2
		// (set) Token: 0x06002F6B RID: 12139 RVA: 0x001519FA File Offset: 0x0014FBFA
		[DisplayName("字体颜色")]
		[O_Oo00Oo000O0(12.0)]
		[Category("A.数据区")]
		[DefaultValue(16777215)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color ForeColor
		{
			get
			{
				return this.o00_.0ooOo.;
			}
			set
			{
				if (this.AlterRowForeColor == this.ForeColor)
				{
					this.AlterRowForeColor = value;
				}
				this.o00_.0ooOo. = value;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002F6C RID: 12140 RVA: 0x00151A1D File Offset: 0x0014FC1D
		// (set) Token: 0x06002F6D RID: 12141 RVA: 0x00151A25 File Offset: 0x0014FC25
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[O_Oo00Oo000O0(11.0)]
		[DefaultValue(16777215)]
		[Category("B.选定区")]
		[DisplayName("背景颜色")]
		public Color HighlightBackColor
		{
			get
			{
				return this.oooO__.00_.;
			}
			set
			{
				this.oooO__.00_. = value;
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002F6E RID: 12142 RVA: 0x00151A2E File Offset: 0x0014FC2E
		// (set) Token: 0x06002F6F RID: 12143 RVA: 0x00151A36 File Offset: 0x0014FC36
		[DefaultValue(16777215)]
		[O_Oo00Oo000O0(12.0)]
		[Category("B.选定区")]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[DisplayName("字体颜色")]
		public Color HighlightForeColor
		{
			get
			{
				return this.OOo0.OO_O000O.;
			}
			set
			{
				this.OOo0.OO_O000O. = value;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x00151A3F File Offset: 0x0014FC3F
		// (set) Token: 0x06002F71 RID: 12145 RVA: 0x00151A47 File Offset: 0x0014FC47
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[O_Oo00Oo000O0(12.0)]
		[DefaultValue(16777215)]
		[Category("C.标题区")]
		[DisplayName("背景颜色")]
		public Color FixedBackColor
		{
			get
			{
				return this.o.oo0o0_0.;
			}
			set
			{
				this.o.oo0o0_0. = value;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x00151A50 File Offset: 0x0014FC50
		// (set) Token: 0x06002F73 RID: 12147 RVA: 0x00151A58 File Offset: 0x0014FC58
		[O_Oo00Oo000O0(12.0)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[DefaultValue(16777215)]
		[Category("C.标题区")]
		[DisplayName("字体颜色")]
		public Color FixedForeColor
		{
			get
			{
				return this.Oo00o.0O_o0O_o.;
			}
			set
			{
				this.Oo00o.0O_o0O_o. = value;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x00151A61 File Offset: 0x0014FC61
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x00151A69 File Offset: 0x0014FC69
		[DisplayName("背景颜色")]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[O_Oo00Oo000O0(12.0)]
		[Category("D.选定标题区")]
		[DefaultValue(16777215)]
		public Color SelectedHeaderBackColor
		{
			get
			{
				return this.o0O_o00O.0o_.;
			}
			set
			{
				this.o0O_o00O.0o_. = value;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x00151A72 File Offset: 0x0014FC72
		// (set) Token: 0x06002F77 RID: 12151 RVA: 0x00151A7A File Offset: 0x0014FC7A
		[Category("D.选定标题区")]
		[O_Oo00Oo000O0(12.0)]
		[DisplayName("字体颜色")]
		[DefaultValue(16777215)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color SelectedHeaderForeColor
		{
			get
			{
				return this.Oo0o.O0o0.;
			}
			set
			{
				this.Oo0o.O0o0. = value;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x00151A83 File Offset: 0x0014FC83
		// (set) Token: 0x06002F79 RID: 12153 RVA: 0x00151A8B File Offset: 0x0014FC8B
		[O_Oo00Oo000O0(10.9)]
		[DefaultValue(0)]
		[Category("E.交替行")]
		[DisplayName("关闭交替显示")]
		public BooleanEnum DisableAlterRowMode
		{
			get
			{
				return this.O__O.ooO__.;
			}
			set
			{
				this.O__O.ooO__. = value;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002F7A RID: 12154 RVA: 0x00151A94 File Offset: 0x0014FC94
		// (set) Token: 0x06002F7B RID: 12155 RVA: 0x00151A9C File Offset: 0x0014FC9C
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[DefaultValue(16777215)]
		[O_Oo00Oo000O0(11.0)]
		[DisplayName("背景颜色")]
		[Category("E.交替行")]
		public Color AlterRowBackColor
		{
			get
			{
				return this.OO0O._Oo.;
			}
			set
			{
				this.OO0O._Oo. = value;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002F7C RID: 12156 RVA: 0x00151AA5 File Offset: 0x0014FCA5
		// (set) Token: 0x06002F7D RID: 12157 RVA: 0x00151AAD File Offset: 0x0014FCAD
		[O_Oo00Oo000O0(12.0)]
		[Category("E.交替行")]
		[DefaultValue(16777215)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[DisplayName("字体颜色")]
		public Color AlterRowForeColor
		{
			get
			{
				return this.ooO.OOOoO.;
			}
			set
			{
				this.ooO.OOOoO. = value;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002F7E RID: 12158 RVA: 0x00151AB6 File Offset: 0x0014FCB6
		// (set) Token: 0x06002F7F RID: 12159 RVA: 0x00151ABE File Offset: 0x0014FCBE
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[Category("F.冻结区")]
		[DefaultValue(16777215)]
		[O_Oo00Oo000O0(11.0)]
		[DisplayName("背景颜色")]
		public Color FrozenBackColor
		{
			get
			{
				return this.o0o.o0O0O0OOO0.;
			}
			set
			{
				this.o0o.o0O0O0OOO0. = value;
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002F80 RID: 12160 RVA: 0x00151AC7 File Offset: 0x0014FCC7
		// (set) Token: 0x06002F81 RID: 12161 RVA: 0x00151ACF File Offset: 0x0014FCCF
		[DisplayName("字体颜色")]
		[O_Oo00Oo000O0(12.0)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[DefaultValue(16777215)]
		[Category("F.冻结区")]
		public Color frozenForeColor
		{
			get
			{
				return this.ooO0O0__o_.o0.;
			}
			set
			{
				this.ooO0O0__o_.o0. = value;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002F82 RID: 12162 RVA: 0x00151AD8 File Offset: 0x0014FCD8
		// (set) Token: 0x06002F83 RID: 12163 RVA: 0x00151AE0 File Offset: 0x0014FCE0
		[DefaultValue(16777215)]
		[O_Oo00Oo000O0(11.0)]
		[Category("G.焦点单元格")]
		[DisplayName("背景颜色")]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color FocusBackColor
		{
			get
			{
				return this.oO.oO0ooO0_00o.;
			}
			set
			{
				this.oO.oO0ooO0_00o. = value;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002F84 RID: 12164 RVA: 0x00151AE9 File Offset: 0x0014FCE9
		// (set) Token: 0x06002F85 RID: 12165 RVA: 0x00151AF1 File Offset: 0x0014FCF1
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[O_Oo00Oo000O0(12.0)]
		[Category("G.焦点单元格")]
		[DisplayName("字体颜色")]
		[DefaultValue(16777215)]
		public Color FocusForeColor
		{
			get
			{
				return this.Oo.oo_0_.;
			}
			set
			{
				this.Oo.oo_0_. = value;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002F86 RID: 12166 RVA: 0x00151AFA File Offset: 0x0014FCFA
		// (set) Token: 0x06002F87 RID: 12167 RVA: 0x00151B02 File Offset: 0x0014FD02
		[DefaultValue(16777215)]
		[Category("H.已修改单元格")]
		[DisplayName("背景颜色")]
		[O_Oo00Oo000O0(11.0)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color ModifiedCellBackColor
		{
			get
			{
				return this.o000OO0._oO_o.;
			}
			set
			{
				this.o000OO0._oO_o. = value;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002F88 RID: 12168 RVA: 0x00151B0B File Offset: 0x0014FD0B
		// (set) Token: 0x06002F89 RID: 12169 RVA: 0x00151B13 File Offset: 0x0014FD13
		[DisplayName("字体颜色")]
		[Category("H.已修改单元格")]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[DefaultValue(16777215)]
		[O_Oo00Oo000O0(12.0)]
		public Color ModifiedCellForeColor
		{
			get
			{
				return this.O_oo.0O0__O_.;
			}
			set
			{
				this.O_oo.0O0__O_. = value;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002F8A RID: 12170 RVA: 0x00151B1C File Offset: 0x0014FD1C
		// (set) Token: 0x06002F8B RID: 12171 RVA: 0x00151B24 File Offset: 0x0014FD24
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[O_Oo00Oo000O0(11.0)]
		[Category("I.当前行")]
		[DisplayName("背景颜色")]
		[DefaultValue(16777215)]
		public Color CurrentRowBackColor
		{
			get
			{
				return this.o0_.O_0_.;
			}
			set
			{
				this.o0_.O_0_. = value;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002F8C RID: 12172 RVA: 0x00151B2D File Offset: 0x0014FD2D
		// (set) Token: 0x06002F8D RID: 12173 RVA: 0x00151B35 File Offset: 0x0014FD35
		[DisplayName("字体颜色")]
		[O_Oo00Oo000O0(12.0)]
		[Category("I.当前行")]
		[DefaultValue(16777215)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color CurrentRowForeColor
		{
			get
			{
				return this.O.o_O_O.;
			}
			set
			{
				this.O.o_O_O. = value;
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x00151B3E File Offset: 0x0014FD3E
		// (set) Token: 0x06002F8F RID: 12175 RVA: 0x00151B46 File Offset: 0x0014FD46
		[Category("J.总计行")]
		[DisplayName("背景颜色")]
		[DefaultValue(-6751336)]
		[O_Oo00Oo000O0(11.0)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color GrandTotalBackColor
		{
			get
			{
				return this.O.O_00O.;
			}
			set
			{
				this.O.O_00O. = value;
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002F90 RID: 12176 RVA: 0x00151B4F File Offset: 0x0014FD4F
		// (set) Token: 0x06002F91 RID: 12177 RVA: 0x00151B57 File Offset: 0x0014FD57
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[O_Oo00Oo000O0(12.0)]
		[Category("J.总计行")]
		[DisplayName("字体颜色")]
		[DefaultValue(-16777216)]
		public Color GrandTotalForeColor
		{
			get
			{
				return this.OooO0o_._0oOoO.;
			}
			set
			{
				this.OooO0o_._0oOoO. = value;
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002F92 RID: 12178 RVA: 0x00151B60 File Offset: 0x0014FD60
		// (set) Token: 0x06002F93 RID: 12179 RVA: 0x00151B68 File Offset: 0x0014FD68
		[DisplayName("背景颜色")]
		[O_Oo00Oo000O0(11.0)]
		[Category("K.小计行0")]
		[DefaultValue(-64)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color Subtotal0BackColor
		{
			get
			{
				return this.Oo._oO0.;
			}
			set
			{
				this.Oo._oO0. = value;
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002F94 RID: 12180 RVA: 0x00151B71 File Offset: 0x0014FD71
		// (set) Token: 0x06002F95 RID: 12181 RVA: 0x00151B79 File Offset: 0x0014FD79
		[Category("K.小计行0")]
		[DisplayName("字体颜色")]
		[DefaultValue(-16777216)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[O_Oo00Oo000O0(12.0)]
		public Color Subtotal0ForeColor
		{
			get
			{
				return this.Oooo_.oOoo0o.;
			}
			set
			{
				this.Oooo_.oOoo0o. = value;
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x00151B82 File Offset: 0x0014FD82
		// (set) Token: 0x06002F97 RID: 12183 RVA: 0x00151B8A File Offset: 0x0014FD8A
		[Category("L.小计行1")]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[O_Oo00Oo000O0(11.0)]
		[DisplayName("背景颜色")]
		[DefaultValue(-2031617)]
		public Color Subtotal1BackColor
		{
			get
			{
				return this.o__0.OO.;
			}
			set
			{
				this.o__0.OO. = value;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x00151B93 File Offset: 0x0014FD93
		// (set) Token: 0x06002F99 RID: 12185 RVA: 0x00151B9B File Offset: 0x0014FD9B
		[O_Oo00Oo000O0(12.0)]
		[Category("L.小计行1")]
		[DisplayName("字体颜色")]
		[DefaultValue(-16777216)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color Subtotal1ForeColor
		{
			get
			{
				return this.oo.0o0OOoOOoo0.;
			}
			set
			{
				this.oo.0o0OOoOOoo0. = value;
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002F9A RID: 12186 RVA: 0x00151BA4 File Offset: 0x0014FDA4
		// (set) Token: 0x06002F9B RID: 12187 RVA: 0x00151BAC File Offset: 0x0014FDAC
		[DisplayName("背景颜色")]
		[O_Oo00Oo000O0(11.0)]
		[Category("M.小计行2")]
		[DefaultValue(-5004601)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color Subtotal2BackColor
		{
			get
			{
				return this.O0OO0.o_.;
			}
			set
			{
				this.O0OO0.o_. = value;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x00151BB5 File Offset: 0x0014FDB5
		// (set) Token: 0x06002F9D RID: 12189 RVA: 0x00151BBD File Offset: 0x0014FDBD
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[O_Oo00Oo000O0(12.0)]
		[Category("M.小计行2")]
		[DisplayName("字体颜色")]
		[DefaultValue(-16777216)]
		public Color Subtotal2ForeColor
		{
			get
			{
				return this.OOOOo.O_.;
			}
			set
			{
				this.OOOOo.O_. = value;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x00151BC6 File Offset: 0x0014FDC6
		// (set) Token: 0x06002F9F RID: 12191 RVA: 0x00151BCE File Offset: 0x0014FDCE
		[DefaultValue(-2517356)]
		[O_Oo00Oo000O0(11.0)]
		[Category("N.小计行3")]
		[DisplayName("背景颜色")]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color Subtotal3BackColor
		{
			get
			{
				return this.oo0_0O0._OO.;
			}
			set
			{
				this.oo0_0O0._OO. = value;
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002FA0 RID: 12192 RVA: 0x00151BD7 File Offset: 0x0014FDD7
		// (set) Token: 0x06002FA1 RID: 12193 RVA: 0x00151BDF File Offset: 0x0014FDDF
		[DisplayName("字体颜色")]
		[O_Oo00Oo000O0(12.0)]
		[Category("N.小计行3")]
		[DefaultValue(-16777216)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color Subtotal3ForeColor
		{
			get
			{
				return this.O_o_0_._oO.;
			}
			set
			{
				this.O_o_0_._oO. = value;
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x00151BE8 File Offset: 0x0014FDE8
		// (set) Token: 0x06002FA3 RID: 12195 RVA: 0x00151BF0 File Offset: 0x0014FDF0
		[Category("O.小计行4")]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[DefaultValue(-343920)]
		[O_Oo00Oo000O0(11.0)]
		[DisplayName("背景颜色")]
		public Color Subtotal4BackColor
		{
			get
			{
				return this.ooO0.O0.;
			}
			set
			{
				this.ooO0.O0. = value;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002FA4 RID: 12196 RVA: 0x00151BF9 File Offset: 0x0014FDF9
		// (set) Token: 0x06002FA5 RID: 12197 RVA: 0x00151C01 File Offset: 0x0014FE01
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[O_Oo00Oo000O0(12.0)]
		[Category("O.小计行4")]
		[DisplayName("字体颜色")]
		[DefaultValue(-16777216)]
		public Color Subtotal4ForeColor
		{
			get
			{
				return this.O_o.o_.;
			}
			set
			{
				this.O_o.o_. = value;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002FA6 RID: 12198 RVA: 0x00151C0A File Offset: 0x0014FE0A
		// (set) Token: 0x06002FA7 RID: 12199 RVA: 0x00151C12 File Offset: 0x0014FE12
		[DefaultValue(-3942757)]
		[Category("P.小计行5")]
		[DisplayName("背景颜色")]
		[O_Oo00Oo000O0(11.0)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color Subtotal5BackColor
		{
			get
			{
				return this.O__O0o.o0.;
			}
			set
			{
				this.O__O0o.o0. = value;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002FA8 RID: 12200 RVA: 0x00151C1B File Offset: 0x0014FE1B
		// (set) Token: 0x06002FA9 RID: 12201 RVA: 0x00151C23 File Offset: 0x0014FE23
		[DisplayName("字体颜色")]
		[Category("P.小计行5")]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		[DefaultValue(-16777216)]
		[O_Oo00Oo000O0(12.0)]
		public Color Subtotal5ForeColor
		{
			get
			{
				return this.O.o0_oooo00.;
			}
			set
			{
				this.O.o0_oooo00. = value;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06002FAA RID: 12202 RVA: 0x00151C2C File Offset: 0x0014FE2C
		// (set) Token: 0x06002FAB RID: 12203 RVA: 0x00151C34 File Offset: 0x0014FE34
		[DisplayName("背景颜色")]
		[O_Oo00Oo000O0(11.0)]
		[Category("Q.空白区")]
		[DefaultValue(16777215)]
		[TypeConverter(typeof(o__oOOo00oo0_))]
		public Color EmptyBackColor
		{
			get
			{
				return this.o._OO0.;
			}
			set
			{
				this.o._OO0. = value;
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002FAC RID: 12204 RVA: 0x00151C3D File Offset: 0x0014FE3D
		// (set) Token: 0x06002FAD RID: 12205 RVA: 0x00151C45 File Offset: 0x0014FE45
		[Category("外观")]
		[O_Oo00Oo000O0(12.0)]
		[DisplayName("显示锁定表标记")]
		[DefaultValue(true)]
		public bool ShowLockTableIcon
		{
			get
			{
				return this.Oo0.0_O.;
			}
			set
			{
				this.Oo0.0_O. = value;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x00151C4E File Offset: 0x0014FE4E
		// (set) Token: 0x06002FAF RID: 12207 RVA: 0x00151C56 File Offset: 0x0014FE56
		[Category("外观")]
		[DisplayName("显示锁定列标记")]
		[O_Oo00Oo000O0(13.0)]
		[DefaultValue(true)]
		public bool ShowLockColumnIcon
		{
			get
			{
				return this.O_OO_0_0o__0.o.;
			}
			set
			{
				this.O_OO_0_0o__0.o. = value;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002FB0 RID: 12208 RVA: 0x00151C5F File Offset: 0x0014FE5F
		// (set) Token: 0x06002FB1 RID: 12209 RVA: 0x00151C67 File Offset: 0x0014FE67
		[DefaultValue(true)]
		[O_Oo00Oo000O0(14.0)]
		[Category("外观")]
		[DisplayName("显示锁定行标记")]
		[Description("在不显示行号的时候，是否在行标题处显示锁定行标记。")]
		public bool ShowLockRowIcon
		{
			get
			{
				return this.OoOo000.O_.;
			}
			set
			{
				this.OoOo000.O_. = value;
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x00151C70 File Offset: 0x0014FE70
		// (set) Token: 0x06002FB3 RID: 12211 RVA: 0x00151C78 File Offset: 0x0014FE78
		[DefaultValue(true)]
		[O_Oo00Oo000O0(13.0)]
		[Category("外观")]
		[DisplayName("显示排序标记")]
		public bool ShowSortIcon
		{
			get
			{
				return this.O0_Oooo_.0O_0.;
			}
			set
			{
				this.O0_Oooo_.0O_0. = value;
			}
		}

		// Token: 0x040012DC RID: 4828
		private bool <<EMPTY_NAME>>;

		// Token: 0x040012DD RID: 4829
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012DE RID: 4830
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012DF RID: 4831
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012E0 RID: 4832
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012E1 RID: 4833
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012E2 RID: 4834
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012E3 RID: 4835
		private GridLineDirectionEnum <<EMPTY_NAME>>;

		// Token: 0x040012E4 RID: 4836
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012E5 RID: 4837
		private GridStyleEnum <<EMPTY_NAME>>;

		// Token: 0x040012E6 RID: 4838
		private GridWidthEnum <<EMPTY_NAME>>;

		// Token: 0x040012E7 RID: 4839
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012E8 RID: 4840
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012E9 RID: 4841
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012EA RID: 4842
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012EB RID: 4843
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012EC RID: 4844
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012ED RID: 4845
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012EE RID: 4846
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012EF RID: 4847
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012F0 RID: 4848
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012F1 RID: 4849
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012F2 RID: 4850
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012F3 RID: 4851
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012F4 RID: 4852
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012F5 RID: 4853
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012F6 RID: 4854
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012F7 RID: 4855
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012F8 RID: 4856
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012F9 RID: 4857
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012FA RID: 4858
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012FB RID: 4859
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012FC RID: 4860
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012FD RID: 4861
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012FE RID: 4862
		private Color <<EMPTY_NAME>>;

		// Token: 0x040012FF RID: 4863
		private Color <<EMPTY_NAME>>;

		// Token: 0x04001300 RID: 4864
		private Color <<EMPTY_NAME>>;

		// Token: 0x04001301 RID: 4865
		private Color <<EMPTY_NAME>>;

		// Token: 0x04001302 RID: 4866
		private Color <<EMPTY_NAME>>;

		// Token: 0x04001303 RID: 4867
		private Color <<EMPTY_NAME>>;

		// Token: 0x04001304 RID: 4868
		private Color <<EMPTY_NAME>>;

		// Token: 0x04001305 RID: 4869
		private Color <<EMPTY_NAME>>;

		// Token: 0x04001306 RID: 4870
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001307 RID: 4871
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001308 RID: 4872
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001309 RID: 4873
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400130A RID: 4874
		private Color <<EMPTY_NAME>>;

		// Token: 0x0400130B RID: 4875
		private Color <<EMPTY_NAME>>;

		// Token: 0x0400130C RID: 4876
		private string <<EMPTY_NAME>>;

		// Token: 0x0400130D RID: 4877
		private BooleanEnum <<EMPTY_NAME>>;
	}
}
