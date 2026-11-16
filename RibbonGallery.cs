using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x0200048E RID: 1166
	[OoO0___o("RibbonGallery")]
	internal class RibbonGallery : RibbonDropDownItem
	{
		// Token: 0x06004F37 RID: 20279 RVA: 0x0023881B File Offset: 0x00236A1B
		public RibbonGallery(DataRow A_0) : base(A_0)
		{
			this.oO_.OO__OOo_o0. = true;
			this.oO_.OO__OOo_o0. = 72;
			this.Oo_0O0.O_o. = 60;
			this.o0oO000O.OO. = 3;
			this.Oo_0O0.O_o. = true;
			this.o0oO000O.OO. = true;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06004F38 RID: 20280 RVA: 0x00238858 File Offset: 0x00236A58
		// (set) Token: 0x06004F39 RID: 20281 RVA: 0x00238873 File Offset: 0x00236A73
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		[DisplayName("标题")]
		public string Text
		{
			get
			{
				if (this.O_oOO_.o0. == null)
				{
					this.O_oOO_.o0. = "";
				}
				return this.O_oOO_.o0.;
			}
			set
			{
				this.O_oOO_.o0. = value;
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06004F3A RID: 20282 RVA: 0x0023887C File Offset: 0x00236A7C
		// (set) Token: 0x06004F3B RID: 20283 RVA: 0x00238884 File Offset: 0x00236A84
		[DisplayName("命令模式")]
		[O_Oo00Oo000O0(1.2)]
		[Category("属性")]
		[DefaultValue(true)]
		public bool CommandMode
		{
			get
			{
				return this.Oo_0O0.O_o.;
			}
			set
			{
				this.Oo_0O0.O_o. = value;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06004F3C RID: 20284 RVA: 0x0023888D File Offset: 0x00236A8D
		// (set) Token: 0x06004F3D RID: 20285 RVA: 0x00238895 File Offset: 0x00236A95
		[Category("属性")]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(1.21)]
		[DisplayName("默认展开")]
		public bool Expand
		{
			get
			{
				return this.oO_.OO__OOo_o0.;
			}
			set
			{
				this.oO_.OO__OOo_o0. = value;
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06004F3E RID: 20286 RVA: 0x0023889E File Offset: 0x00236A9E
		// (set) Token: 0x06004F3F RID: 20287 RVA: 0x002388A6 File Offset: 0x00236AA6
		[DefaultValue(true)]
		[Category("属性")]
		[DisplayName("项目宽度")]
		[O_Oo00Oo000O0(1.3)]
		[Description("项目宽度，单位为像素")]
		public int ItemWidth
		{
			get
			{
				return this.oO_.OO__OOo_o0.;
			}
			set
			{
				this.oO_.OO__OOo_o0. = value;
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06004F40 RID: 20288 RVA: 0x002388AF File Offset: 0x00236AAF
		// (set) Token: 0x06004F41 RID: 20289 RVA: 0x002388B7 File Offset: 0x00236AB7
		[Description("项目高度，单位为像素")]
		[DisplayName("项目高度")]
		[O_Oo00Oo000O0(1.31)]
		[DefaultValue(true)]
		[Category("属性")]
		public int ItemHeight
		{
			get
			{
				return this.Oo_0O0.O_o.;
			}
			set
			{
				this.Oo_0O0.O_o. = value;
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06004F42 RID: 20290 RVA: 0x002388C0 File Offset: 0x00236AC0
		// (set) Token: 0x06004F43 RID: 20291 RVA: 0x002388C8 File Offset: 0x00236AC8
		[O_Oo00Oo000O0(1.32)]
		[Category("属性")]
		[DisplayName("项目标题居下")]
		[Description("标题是否位于图标的下面")]
		[DefaultValue(true)]
		public bool VerticalLayout
		{
			get
			{
				return this.o0oO000O.OO.;
			}
			set
			{
				this.o0oO000O.OO. = value;
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06004F44 RID: 20292 RVA: 0x002388D1 File Offset: 0x00236AD1
		// (set) Token: 0x06004F45 RID: 20293 RVA: 0x002388D9 File Offset: 0x00236AD9
		[O_Oo00Oo000O0(1.4)]
		[Description("横向可见项目数")]
		[Category("属性")]
		[DisplayName("可见项目数")]
		[DefaultValue(true)]
		public int VisibleItems
		{
			get
			{
				return this.o0oO000O.OO.;
			}
			set
			{
				if (value < 1)
				{
					value = 1;
				}
				this.o0oO000O.OO. = value;
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06004F46 RID: 20294 RVA: 0x002388E9 File Offset: 0x00236AE9
		// (set) Token: 0x06004F47 RID: 20295 RVA: 0x002388F0 File Offset: 0x00236AF0
		[O_Oo00Oo000O0(100.0)]
		[Category("属性")]
		[DisplayName("菜单项目")]
		[Editor(typeof(RibbonItemCollectionEditor), typeof(UITypeEditor))]
		public Hashtable MenuItems
		{
			get
			{
				return new Hashtable();
			}
			set
			{
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06004F48 RID: 20296 RVA: 0x002388F2 File Offset: 0x00236AF2
		// (set) Token: 0x06004F49 RID: 20297 RVA: 0x002388FA File Offset: 0x00236AFA
		[oO0oooo("3083")]
		[Description("非命令模式查下，选择不同项目后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.1)]
		public EventString ItemSelected
		{
			get
			{
				return this.oO_.OO__OOo_o0.;
			}
			set
			{
				this.oO_.OO__OOo_o0. = value;
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06004F4A RID: 20298 RVA: 0x00238903 File Offset: 0x00236B03
		// (set) Token: 0x06004F4B RID: 20299 RVA: 0x0023890B File Offset: 0x00236B0B
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("3082")]
		[Description("命令模式查下，单击不同项目后执行。")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.2)]
		public EventString ItemClick
		{
			get
			{
				return this.Oo_0O0.O_o.;
			}
			set
			{
				this.Oo_0O0.O_o. = value;
			}
		}

		// Token: 0x04002064 RID: 8292
		private string <<EMPTY_NAME>>;

		// Token: 0x04002065 RID: 8293
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002066 RID: 8294
		private int <<EMPTY_NAME>>;

		// Token: 0x04002067 RID: 8295
		private int <<EMPTY_NAME>>;

		// Token: 0x04002068 RID: 8296
		private int <<EMPTY_NAME>>;

		// Token: 0x04002069 RID: 8297
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400206A RID: 8298
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400206B RID: 8299
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400206C RID: 8300
		private bool <<EMPTY_NAME>>;
	}
}
