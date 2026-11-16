using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000484 RID: 1156
	internal class RibbonItem : RibbonBase
	{
		// Token: 0x06004ED6 RID: 20182 RVA: 0x00238418 File Offset: 0x00236618
		public RibbonItem(DataRow A_0) : base(A_0)
		{
			this.O0o._0o_O. = true;
			this.O_0o_O.o0_O. = true;
			this.o_oo0.00OO0. = true;
			this.O0o._0o_O. = TextImageRelationEnum.Automatic;
			this.O0o._0o_O. = Color.Transparent;
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06004ED7 RID: 20183 RVA: 0x00238448 File Offset: 0x00236648
		// (set) Token: 0x06004ED8 RID: 20184 RVA: 0x00238450 File Offset: 0x00236650
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(2.0)]
		[Description("一个32*32尺寸的图标，或者对应大小的图片。")]
		[Category("属性")]
		[DisplayName("大图标")]
		public string LargeImage
		{
			get
			{
				return this.O0o._0o_O.;
			}
			set
			{
				this.O0o._0o_O. = value;
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06004ED9 RID: 20185 RVA: 0x00238459 File Offset: 0x00236659
		// (set) Token: 0x06004EDA RID: 20186 RVA: 0x00238461 File Offset: 0x00236661
		[Description("一个16*16尺寸的图标，或者对应大小的图片。")]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[Category("属性")]
		[DisplayName("小图标")]
		[O_Oo00Oo000O0(3.0)]
		public string SmallImage
		{
			get
			{
				return this.o._o0Oo00O.;
			}
			set
			{
				this.o._o0Oo00O. = value;
			}
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06004EDB RID: 20187 RVA: 0x0023846A File Offset: 0x0023666A
		// (set) Token: 0x06004EDC RID: 20188 RVA: 0x00238472 File Offset: 0x00236672
		[Description("图标和文本的相对位置。")]
		[DisplayName("图标位置")]
		[O_Oo00Oo000O0(4.0)]
		[Category("属性")]
		[DefaultValue(0)]
		public TextImageRelationEnum TextImageRelation
		{
			get
			{
				return this.O0o._0o_O.;
			}
			set
			{
				this.O0o._0o_O. = value;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06004EDD RID: 20189 RVA: 0x0023847B File Offset: 0x0023667B
		// (set) Token: 0x06004EDE RID: 20190 RVA: 0x00238483 File Offset: 0x00236683
		[DisplayName("提示")]
		[O_Oo00Oo000O0(5.0)]
		[Category("属性")]
		public string ToolTip
		{
			get
			{
				return this.o_oO.O00__.;
			}
			set
			{
				this.o_oO.O00__. = value;
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06004EDF RID: 20191 RVA: 0x0023848C File Offset: 0x0023668C
		// (set) Token: 0x06004EE0 RID: 20192 RVA: 0x00238494 File Offset: 0x00236694
		[Category("属性")]
		[O_Oo00Oo000O0(6.0)]
		[DisplayName("可用")]
		[DefaultValue(true)]
		public bool Enabled
		{
			get
			{
				return this.O0o._0o_O.;
			}
			set
			{
				this.O0o._0o_O. = value;
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06004EE1 RID: 20193 RVA: 0x0023849D File Offset: 0x0023669D
		// (set) Token: 0x06004EE2 RID: 20194 RVA: 0x002384A5 File Offset: 0x002366A5
		[DefaultValue(true)]
		[O_Oo00Oo000O0(7.0)]
		[Category("属性")]
		[DisplayName("可见")]
		public bool Visible
		{
			get
			{
				return this.O_0o_O.o0_O.;
			}
			set
			{
				this.O_0o_O.o0_O. = value;
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06004EE3 RID: 20195 RVA: 0x002384AE File Offset: 0x002366AE
		// (set) Token: 0x06004EE4 RID: 20196 RVA: 0x002384B6 File Offset: 0x002366B6
		[Category("属性")]
		[DefaultValue(16777215)]
		[O_Oo00Oo000O0(8.0)]
		[DisplayName("字体颜色")]
		public Color ForeColor
		{
			get
			{
				return this.O0o._0o_O.;
			}
			set
			{
				this.O0o._0o_O. = value;
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06004EE5 RID: 20197 RVA: 0x002384BF File Offset: 0x002366BF
		// (set) Token: 0x06004EE6 RID: 20198 RVA: 0x002384C7 File Offset: 0x002366C7
		[O_Oo00Oo000O0(8.0)]
		[Description("当屏幕分辨率不够时，是否允许自动隐藏此按钮标题，以节省空间。")]
		[Category("属性")]
		[DisplayName("自动隐藏标题")]
		[DefaultValue(true)]
		public virtual bool AutoHideText
		{
			get
			{
				return this.o_oo0.00OO0.;
			}
			set
			{
				this.o_oo0.00OO0. = value;
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06004EE7 RID: 20199 RVA: 0x002384D0 File Offset: 0x002366D0
		// (set) Token: 0x06004EE8 RID: 20200 RVA: 0x002384D8 File Offset: 0x002366D8
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("鼠标进入的时候执行。")]
		[O_Oo00Oo000O0(1.0)]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString MouseEnter
		{
			get
			{
				return this.O0o._0o_O.;
			}
			set
			{
				this.O0o._0o_O. = value;
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06004EE9 RID: 20201 RVA: 0x002384E1 File Offset: 0x002366E1
		// (set) Token: 0x06004EEA RID: 20202 RVA: 0x002384E9 File Offset: 0x002366E9
		[Category("事件")]
		[O_Oo00Oo000O0(2.0)]
		[Description("鼠标离开的时候执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString MouseLeave
		{
			get
			{
				return this.o._o0Oo00O.;
			}
			set
			{
				this.o._o0Oo00O. = value;
			}
		}

		// Token: 0x0400203E RID: 8254
		private string <<EMPTY_NAME>>;

		// Token: 0x0400203F RID: 8255
		private string <<EMPTY_NAME>>;

		// Token: 0x04002040 RID: 8256
		private string <<EMPTY_NAME>>;

		// Token: 0x04002041 RID: 8257
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002042 RID: 8258
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002043 RID: 8259
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002044 RID: 8260
		private TextImageRelationEnum <<EMPTY_NAME>>;

		// Token: 0x04002045 RID: 8261
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002046 RID: 8262
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002047 RID: 8263
		private Color <<EMPTY_NAME>>;
	}
}
