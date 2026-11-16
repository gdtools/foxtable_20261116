using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200040B RID: 1035
	internal class CheckBoxProperty : ControlPropertyBase
	{
		// Token: 0x06004459 RID: 17497 RVA: 0x001F07FA File Offset: 0x001EE9FA
		public CheckBoxProperty(ControlHolder A_0) : base(A_0)
		{
			this.O_oO0._o_0. = (C1CheckBox)A_0.ChildControl;
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x0600445A RID: 17498 RVA: 0x001F0814 File Offset: 0x001EEA14
		// (set) Token: 0x0600445B RID: 17499 RVA: 0x001F081C File Offset: 0x001EEA1C
		[O_Oo00Oo000O0(2.2)]
		[DisplayName("绑定到")]
		[Editor(typeof(oo0000o0oo), typeof(UITypeEditor))]
		[MergableProperty(false)]
		[Category("基本")]
		public string BindingField
		{
			get
			{
				return this.oOO00oo.O.;
			}
			set
			{
				this.oOO00oo.O. = value;
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x0600445C RID: 17500 RVA: 0x001F0825 File Offset: 0x001EEA25
		// (set) Token: 0x0600445D RID: 17501 RVA: 0x001F082D File Offset: 0x001EEA2D
		[O_Oo00Oo000O0(2.3)]
		[DisplayName("只读")]
		[Category("基本")]
		[Description("是否禁止用户修改。")]
		[MergableProperty(true)]
		[DefaultValue(0)]
		public BooleanEnum ReadOnly
		{
			get
			{
				return this.O_oO0._o_0.;
			}
			set
			{
				this.O_oO0._o_0. = value;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x0600445E RID: 17502 RVA: 0x001F0836 File Offset: 0x001EEA36
		// (set) Token: 0x0600445F RID: 17503 RVA: 0x001F0843 File Offset: 0x001EEA43
		[O_Oo00Oo000O0(2.4)]
		[MergableProperty(true)]
		[Category("基本")]
		[DisplayName("标题")]
		public virtual string Text
		{
			get
			{
				return this.O_oO0._o_0..Text;
			}
			set
			{
				this.O_oO0._o_0..Text = value;
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06004460 RID: 17504 RVA: 0x001F0851 File Offset: 0x001EEA51
		// (set) Token: 0x06004461 RID: 17505 RVA: 0x001F085E File Offset: 0x001EEA5E
		[Category("基本")]
		[O_Oo00Oo000O0(2.5)]
		[DefaultValue(false)]
		[MergableProperty(true)]
		[DisplayName("选中")]
		public bool Checked
		{
			get
			{
				return this.O_oO0._o_0..Checked;
			}
			set
			{
				this.O_oO0._o_0..Checked = value;
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06004462 RID: 17506 RVA: 0x001F086C File Offset: 0x001EEA6C
		// (set) Token: 0x06004463 RID: 17507 RVA: 0x001F0879 File Offset: 0x001EEA79
		[O_Oo00Oo000O0(0.01)]
		[DefaultValue(0)]
		[MergableProperty(true)]
		[DisplayName("外观")]
		[Category("外观")]
		public Appearance Appearance
		{
			get
			{
				return this.O_oO0._o_0..Appearance;
			}
			set
			{
				this.O_oO0._o_0..Appearance = value;
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06004464 RID: 17508 RVA: 0x001F0887 File Offset: 0x001EEA87
		// (set) Token: 0x06004465 RID: 17509 RVA: 0x001F0894 File Offset: 0x001EEA94
		[DisplayName("复选框位置")]
		[Category("外观")]
		[MergableProperty(true)]
		[O_Oo00Oo000O0(0.1)]
		[DefaultValue(16)]
		public ContentAlignment CheckAlign
		{
			get
			{
				return this.O_oO0._o_0..CheckAlign;
			}
			set
			{
				this.O_oO0._o_0..CheckAlign = value;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06004466 RID: 17510 RVA: 0x001F08A2 File Offset: 0x001EEAA2
		// (set) Token: 0x06004467 RID: 17511 RVA: 0x001F08AF File Offset: 0x001EEAAF
		[Category("外观")]
		[O_Oo00Oo000O0(0.2)]
		[DisplayName("文本位置")]
		[MergableProperty(true)]
		[DefaultValue(16)]
		public ContentAlignment TextAlign
		{
			get
			{
				return this.O_oO0._o_0..TextAlign;
			}
			set
			{
				this.O_oO0._o_0..TextAlign = value;
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06004468 RID: 17512 RVA: 0x001F08BD File Offset: 0x001EEABD
		// (set) Token: 0x06004469 RID: 17513 RVA: 0x001F08CA File Offset: 0x001EEACA
		[O_Oo00Oo000O0(0.3)]
		[MergableProperty(true)]
		[DefaultValue(32)]
		[DisplayName("图标位置")]
		[Category("外观")]
		public ContentAlignment ImageAlign
		{
			get
			{
				return this.O_oO0._o_0..ImageAlign;
			}
			set
			{
				this.O_oO0._o_0..ImageAlign = value;
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x0600446A RID: 17514 RVA: 0x001F08D8 File Offset: 0x001EEAD8
		// (set) Token: 0x0600446B RID: 17515 RVA: 0x001F08E5 File Offset: 0x001EEAE5
		[MergableProperty(true)]
		[O_Oo00Oo000O0(0.4)]
		[DefaultValue(0)]
		[Category("外观")]
		[Description("设置文本和图标的相对位置。")]
		[DisplayName("相对位置")]
		public TextImageRelation TextImageRelation
		{
			get
			{
				return this.O_oO0._o_0..TextImageRelation;
			}
			set
			{
				this.O_oO0._o_0..TextImageRelation = value;
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x0600446C RID: 17516 RVA: 0x001F08F3 File Offset: 0x001EEAF3
		// (set) Token: 0x0600446D RID: 17517 RVA: 0x001F08FC File Offset: 0x001EEAFC
		[O_Oo00Oo000O0(0.5)]
		[MergableProperty(true)]
		[DisplayName("图标")]
		[Category("外观")]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		public string ImageFile
		{
			get
			{
				return this.O_oO0._o_0.;
			}
			set
			{
				bool flag = Operators.CompareString(this.O_oO0._o_0., "", true) == 0 & Operators.CompareString(value, "", true) > 0;
				this.O_oO0._o_0. = value;
				this.O_oO0._o_0..Image = OO_00oOO.GetImage(this.O_oO0._o_0.);
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x0600446E RID: 17518 RVA: 0x001F094B File Offset: 0x001EEB4B
		// (set) Token: 0x0600446F RID: 17519 RVA: 0x001F0953 File Offset: 0x001EEB53
		[Category("事件")]
		[Description("选中属性发生变化后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("0781")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.1)]
		public EventString CheckedChanged
		{
			get
			{
				return this.O000.o.;
			}
			set
			{
				this.O000.o. = value;
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06004470 RID: 17520 RVA: 0x001F095C File Offset: 0x001EEB5C
		// (set) Token: 0x06004471 RID: 17521 RVA: 0x001F096A File Offset: 0x001EEB6A
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

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06004472 RID: 17522 RVA: 0x001F096C File Offset: 0x001EEB6C
		// (set) Token: 0x06004473 RID: 17523 RVA: 0x001F097E File Offset: 0x001EEB7E
		[Category("外观")]
		[O_Oo00Oo000O0(0.0)]
		[DisplayName("样式")]
		[DefaultValue("(default)")]
		[TypeConverter(typeof(o00))]
		public string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.O_oO0._o_0.);
			}
			set
			{
				Main.OO_O.o..Oo.oOo_o0Oo0.(value, new object[]
				{
					this.O_oO0._o_0.
				});
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06004474 RID: 17524 RVA: 0x001F099A File Offset: 0x001EEB9A
		// (set) Token: 0x06004475 RID: 17525 RVA: 0x001F09A7 File Offset: 0x001EEBA7
		[O_Oo00Oo000O0(1.0)]
		[DefaultValue(-986896)]
		[MergableProperty(true)]
		[DisplayName("背景颜色")]
		[Category("外观")]
		public virtual Color BackColor
		{
			get
			{
				return this.O_oO0._o_0..BackColor;
			}
			set
			{
				this.O_oO0._o_0..BackColor = value;
			}
		}

		// Token: 0x04001BD1 RID: 7121
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001BD2 RID: 7122
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BD3 RID: 7123
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04001BD4 RID: 7124
		private string <<EMPTY_NAME>>;

		// Token: 0x04001BD5 RID: 7125
		private EventString <<EMPTY_NAME>>;
	}
}
