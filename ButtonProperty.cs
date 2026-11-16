using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000409 RID: 1033
	internal class ButtonProperty : ControlPropertyBase
	{
		// Token: 0x0600442B RID: 17451 RVA: 0x001F050D File Offset: 0x001EE70D
		public ButtonProperty(ControlHolder A_0) : base(A_0)
		{
			this.OO_o0_oO.0. = (C1Button)A_0.ChildControl;
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x0600442C RID: 17452 RVA: 0x001F0527 File Offset: 0x001EE727
		// (set) Token: 0x0600442D RID: 17453 RVA: 0x001F053C File Offset: 0x001EE73C
		[DisplayName("样式")]
		[O_Oo00Oo000O0(0.0)]
		[Category("外观")]
		[DefaultValue("(default)")]
		[TypeConverter(typeof(o00))]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.OO_o0_oO.0.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.OO_o0_oO.0.
				});
				if (Operators.CompareString(value, "(none)", true) == 0)
				{
					if (this.OO_o0_oO.0..FlatStyle != FlatStyle.Flat)
					{
						this.OO_o0_oO.0..FlatStyle = FlatStyle.Flat;
						return;
					}
				}
				else if (this.FlatStyle != FlatStyle.Standard)
				{
					this.OO_o0_oO.0..FlatStyle = FlatStyle.Standard;
				}
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x0600442E RID: 17454 RVA: 0x001F05A0 File Offset: 0x001EE7A0
		// (set) Token: 0x0600442F RID: 17455 RVA: 0x001F05AD File Offset: 0x001EE7AD
		[O_Oo00Oo000O0(2.0)]
		[DisplayName("标题")]
		[Category("基本")]
		[MergableProperty(true)]
		public virtual string Text
		{
			get
			{
				return this.OO_o0_oO.0..Text;
			}
			set
			{
				this.OO_o0_oO.0..Text = value;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06004430 RID: 17456 RVA: 0x001F05BB File Offset: 0x001EE7BB
		// (set) Token: 0x06004431 RID: 17457 RVA: 0x001F05C3 File Offset: 0x001EE7C3
		[Browsable(false)]
		public new EventString DoubleClick
		{
			get
			{
				return base.DoubleClick;
			}
			set
			{
				base.DoubleClick = value;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06004432 RID: 17458 RVA: 0x001F05CC File Offset: 0x001EE7CC
		// (set) Token: 0x06004433 RID: 17459 RVA: 0x001F05D4 File Offset: 0x001EE7D4
		[Category("外观")]
		[DisplayName("图标")]
		[O_Oo00Oo000O0(3.2)]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[MergableProperty(true)]
		public string ImageFile
		{
			get
			{
				return this.OO_o0_oO.0.;
			}
			set
			{
				if (Operators.CompareString(this.OO_o0_oO.0., "", true) == 0 & Operators.CompareString(value, "", true) > 0)
				{
					this.ImageAlign = ContentAlignment.MiddleLeft;
				}
				this.OO_o0_oO.0. = value;
				this.OO_o0_oO.0..Image = OO_00oOO.GetImage(this.OO_o0_oO.0.);
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06004434 RID: 17460 RVA: 0x001F062C File Offset: 0x001EE82C
		// (set) Token: 0x06004435 RID: 17461 RVA: 0x001F0639 File Offset: 0x001EE839
		[O_Oo00Oo000O0(3.21)]
		[DisplayName("文本位置")]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(32)]
		public ContentAlignment TextAlign
		{
			get
			{
				return this.OO_o0_oO.0..TextAlign;
			}
			set
			{
				this.OO_o0_oO.0..TextAlign = value;
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06004436 RID: 17462 RVA: 0x001F0647 File Offset: 0x001EE847
		// (set) Token: 0x06004437 RID: 17463 RVA: 0x001F0654 File Offset: 0x001EE854
		[Category("外观")]
		[O_Oo00Oo000O0(3.3)]
		[DisplayName("图标位置")]
		[MergableProperty(true)]
		[DefaultValue(16)]
		public ContentAlignment ImageAlign
		{
			get
			{
				return this.OO_o0_oO.0..ImageAlign;
			}
			set
			{
				this.OO_o0_oO.0..ImageAlign = value;
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06004438 RID: 17464 RVA: 0x001F0662 File Offset: 0x001EE862
		// (set) Token: 0x06004439 RID: 17465 RVA: 0x001F066F File Offset: 0x001EE86F
		[O_Oo00Oo000O0(3.4)]
		[DisplayName("相对位置")]
		[Category("外观")]
		[MergableProperty(true)]
		[Description("设置文本和图标的相对位置。")]
		[DefaultValue(0)]
		public TextImageRelation TextImageRelation
		{
			get
			{
				return this.OO_o0_oO.0..TextImageRelation;
			}
			set
			{
				this.OO_o0_oO.0..TextImageRelation = value;
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x0600443A RID: 17466 RVA: 0x001F0680 File Offset: 0x001EE880
		// (set) Token: 0x0600443B RID: 17467 RVA: 0x001F068E File Offset: 0x001EE88E
		[OooO0(false)]
		[Browsable(false)]
		public VisualStyle VisualStyle
		{
			get
			{
				VisualStyle result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x0600443C RID: 17468 RVA: 0x001F0690 File Offset: 0x001EE890
		// (set) Token: 0x0600443D RID: 17469 RVA: 0x001F069D File Offset: 0x001EE89D
		[OooO0(true)]
		[Browsable(false)]
		public FlatStyle FlatStyle
		{
			get
			{
				return this.OO_o0_oO.0..FlatStyle;
			}
			set
			{
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x001F069F File Offset: 0x001EE89F
		// (set) Token: 0x0600443F RID: 17471 RVA: 0x001F06AC File Offset: 0x001EE8AC
		[MergableProperty(true)]
		[DisplayName("背景颜色")]
		[Category("外观")]
		[O_Oo00Oo000O0(1.0)]
		public override Color BackColor
		{
			get
			{
				return this.OO_o0_oO.0..BackColor;
			}
			set
			{
				this.OO_o0_oO.0..BackColor = value;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06004440 RID: 17472 RVA: 0x001F06BA File Offset: 0x001EE8BA
		// (set) Token: 0x06004441 RID: 17473 RVA: 0x001F06C7 File Offset: 0x001EE8C7
		[MergableProperty(true)]
		[O_Oo00Oo000O0(2.1)]
		[DisplayName("字体颜色")]
		[Category("外观")]
		public override Color ForeColor
		{
			get
			{
				return this.OO_o0_oO.0..ForeColor;
			}
			set
			{
				this.OO_o0_oO.0..ForeColor = value;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06004442 RID: 17474 RVA: 0x001F06D5 File Offset: 0x001EE8D5
		// (set) Token: 0x06004443 RID: 17475 RVA: 0x001F06E7 File Offset: 0x001EE8E7
		[O_Oo00Oo000O0(0.2)]
		[Category("外观")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		[DisplayName("边框颜色")]
		public Color BorderColor
		{
			get
			{
				return this.OO_o0_oO.0..FlatAppearance.BorderColor;
			}
			set
			{
				this.OO_o0_oO.0..FlatAppearance.BorderColor = value;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06004444 RID: 17476 RVA: 0x001F06FA File Offset: 0x001EE8FA
		// (set) Token: 0x06004445 RID: 17477 RVA: 0x001F070C File Offset: 0x001EE90C
		[Category("外观")]
		[O_Oo00Oo000O0(0.3)]
		[DefaultValue(1)]
		[MergableProperty(true)]
		[DisplayName("边框厚度")]
		public int BorderSize
		{
			get
			{
				return this.OO_o0_oO.0..FlatAppearance.BorderSize;
			}
			set
			{
				this.OO_o0_oO.0..FlatAppearance.BorderSize = value;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06004446 RID: 17478 RVA: 0x001F071F File Offset: 0x001EE91F
		// (set) Token: 0x06004447 RID: 17479 RVA: 0x001F0731 File Offset: 0x001EE931
		[MergableProperty(true)]
		[DefaultValue(0)]
		[Category("外观")]
		[O_Oo00Oo000O0(0.4)]
		[DisplayName("鼠标按下时的背景颜色")]
		public Color MouseDownBackColor
		{
			get
			{
				return this.OO_o0_oO.0..FlatAppearance.MouseDownBackColor;
			}
			set
			{
				this.OO_o0_oO.0..FlatAppearance.MouseDownBackColor = value;
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06004448 RID: 17480 RVA: 0x001F0744 File Offset: 0x001EE944
		// (set) Token: 0x06004449 RID: 17481 RVA: 0x001F0756 File Offset: 0x001EE956
		[DefaultValue(0)]
		[DisplayName("鼠标经过时的背景颜色")]
		[Category("外观")]
		[O_Oo00Oo000O0(0.5)]
		[MergableProperty(true)]
		public Color MouseOverBackColor
		{
			get
			{
				return this.OO_o0_oO.0..FlatAppearance.MouseOverBackColor;
			}
			set
			{
				this.OO_o0_oO.0..FlatAppearance.MouseOverBackColor = value;
			}
		}

		// Token: 0x04001BC7 RID: 7111
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001BC8 RID: 7112
		private string <<EMPTY_NAME>>;
	}
}
