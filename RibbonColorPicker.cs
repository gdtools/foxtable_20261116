using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000487 RID: 1159
	[oO0oooo("1122")]
	[OoO0___o("RibbonColorPicker")]
	internal class RibbonColorPicker : RibbonSplitButton
	{
		// Token: 0x06004EF5 RID: 20213 RVA: 0x0023855F File Offset: 0x0023675F
		public RibbonColorPicker(DataRow A_0) : base(A_0)
		{
			this.O_o0oO.O00o. = Color.Red;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x0023857B File Offset: 0x0023677B
		// (set) Token: 0x06004EF7 RID: 20215 RVA: 0x00238583 File Offset: 0x00236783
		[Category("属性")]
		[O_Oo00Oo000O0(1.2)]
		[DefaultValue(-65536)]
		[DisplayName("颜色")]
		public Color Color
		{
			get
			{
				return this.O_o0oO.O00o.;
			}
			set
			{
				this.O_o0oO.O00o. = value;
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06004EF8 RID: 20216 RVA: 0x0023858C File Offset: 0x0023678C
		// (set) Token: 0x06004EF9 RID: 20217 RVA: 0x00238594 File Offset: 0x00236794
		[Description("选择不同颜色后执行。")]
		[O_Oo00Oo000O0(0.1)]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString SelectedColorChanged
		{
			get
			{
				return this.O_o0oO.O00o.;
			}
			set
			{
				this.O_o0oO.O00o. = value;
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06004EFA RID: 20218 RVA: 0x0023859D File Offset: 0x0023679D
		// (set) Token: 0x06004EFB RID: 20219 RVA: 0x002385A0 File Offset: 0x002367A0
		[Browsable(false)]
		public new Hashtable Items
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x0400204B RID: 8267
		private Color <<EMPTY_NAME>>;

		// Token: 0x0400204C RID: 8268
		private EventString <<EMPTY_NAME>>;
	}
}
