using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using C1.Win.C1Ribbon;

namespace Foxtable
{
	// Token: 0x02000493 RID: 1171
	internal class RibbonTopTab : RibbonBase
	{
		// Token: 0x06004F9A RID: 20378 RVA: 0x00238C69 File Offset: 0x00236E69
		internal RibbonTopTab(DataRow A_0) : base(A_0)
		{
			this.o00o.0o0_0. = ContextualTabColor.Orange;
			this.o00o.0o0_0. = System.Drawing.Color.Transparent;
			this.o00o.0o0_0. = true;
			this.o0_o.o. = true;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06004F9B RID: 20379 RVA: 0x00238C9A File Offset: 0x00236E9A
		// (set) Token: 0x06004F9C RID: 20380 RVA: 0x00238CB5 File Offset: 0x00236EB5
		[DisplayName("标题")]
		[Category("属性")]
		[O_Oo00Oo000O0(2.0)]
		public string Text
		{
			get
			{
				if (this.o00o.0o0_0. == null)
				{
					this.o00o.0o0_0. = "";
				}
				return this.o00o.0o0_0.;
			}
			set
			{
				this.o00o.0o0_0. = value;
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06004F9D RID: 20381 RVA: 0x00238CBE File Offset: 0x00236EBE
		// (set) Token: 0x06004F9E RID: 20382 RVA: 0x00238CC6 File Offset: 0x00236EC6
		[DisplayName("提示")]
		[O_Oo00Oo000O0(3.0)]
		[Category("属性")]
		public string ToolTip
		{
			get
			{
				return this.o0_o.o.;
			}
			set
			{
				this.o0_o.o. = value;
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06004F9F RID: 20383 RVA: 0x00238CCF File Offset: 0x00236ECF
		// (set) Token: 0x06004FA0 RID: 20384 RVA: 0x00238CD7 File Offset: 0x00236ED7
		[DefaultValue(16777215)]
		[Category("属性")]
		[DisplayName("背景颜色")]
		[O_Oo00Oo000O0(4.0)]
		public ContextualTabColor Color
		{
			get
			{
				return this.o00o.0o0_0.;
			}
			set
			{
				this.o00o.0o0_0. = value;
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06004FA1 RID: 20385 RVA: 0x00238CE0 File Offset: 0x00236EE0
		// (set) Token: 0x06004FA2 RID: 20386 RVA: 0x00238CE8 File Offset: 0x00236EE8
		[O_Oo00Oo000O0(5.0)]
		[Category("属性")]
		[DisplayName("字体颜色")]
		public Color ForeColor
		{
			get
			{
				return this.o00o.0o0_0.;
			}
			set
			{
				this.o00o.0o0_0. = value;
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06004FA3 RID: 20387 RVA: 0x00238CF1 File Offset: 0x00236EF1
		// (set) Token: 0x06004FA4 RID: 20388 RVA: 0x00238CF9 File Offset: 0x00236EF9
		[DisplayName("可见")]
		[DefaultValue(true)]
		[Category("属性")]
		[O_Oo00Oo000O0(6.0)]
		public bool Visible
		{
			get
			{
				return this.o00o.0o0_0.;
			}
			set
			{
				this.o00o.0o0_0. = value;
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06004FA5 RID: 20389 RVA: 0x00238D02 File Offset: 0x00236F02
		// (set) Token: 0x06004FA6 RID: 20390 RVA: 0x00238D0A File Offset: 0x00236F0A
		[DisplayName("可选")]
		[O_Oo00Oo000O0(7.0)]
		[Category("属性")]
		[DefaultValue(true)]
		public bool Clickable
		{
			get
			{
				return this.o0_o.o.;
			}
			set
			{
				this.o0_o.o. = value;
			}
		}

		// Token: 0x0400208D RID: 8333
		private ContextualTabColor <<EMPTY_NAME>>;

		// Token: 0x0400208E RID: 8334
		private Color <<EMPTY_NAME>>;

		// Token: 0x0400208F RID: 8335
		private string <<EMPTY_NAME>>;

		// Token: 0x04002090 RID: 8336
		private string <<EMPTY_NAME>>;

		// Token: 0x04002091 RID: 8337
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002092 RID: 8338
		private bool <<EMPTY_NAME>>;
	}
}
