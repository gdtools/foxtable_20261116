using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x0200048F RID: 1167
	internal class RibbonGalleryItem : RibbonBase
	{
		// Token: 0x06004F4C RID: 20300 RVA: 0x00238914 File Offset: 0x00236B14
		public RibbonGalleryItem(DataRow A_0) : base(A_0)
		{
			this.O_oOO_.o0. = true;
			this.Ooo_0_.o0. = true;
			this.o0oO000O.OO. = true;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06004F4D RID: 20301 RVA: 0x0023893A File Offset: 0x00236B3A
		// (set) Token: 0x06004F4E RID: 20302 RVA: 0x00238942 File Offset: 0x00236B42
		[Category("属性")]
		[DisplayName("标题")]
		[O_Oo00Oo000O0(1.1)]
		public string Text
		{
			get
			{
				return this.O_oOO_.o0.;
			}
			set
			{
				this.O_oOO_.o0. = value;
			}
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06004F4F RID: 20303 RVA: 0x0023894B File Offset: 0x00236B4B
		// (set) Token: 0x06004F50 RID: 20304 RVA: 0x00238953 File Offset: 0x00236B53
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[Description("一个32*32尺寸的图标，或者对应大小的图片。")]
		[O_Oo00Oo000O0(2.0)]
		[Category("属性")]
		[DisplayName("图标")]
		public string Image
		{
			get
			{
				return this.OoO0O0o0O.oO0.;
			}
			set
			{
				this.OoO0O0o0O.oO0. = value;
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06004F51 RID: 20305 RVA: 0x0023895C File Offset: 0x00236B5C
		// (set) Token: 0x06004F52 RID: 20306 RVA: 0x00238964 File Offset: 0x00236B64
		[Category("属性")]
		[O_Oo00Oo000O0(5.0)]
		[DisplayName("提示")]
		public string ToolTip
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

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06004F53 RID: 20307 RVA: 0x0023896D File Offset: 0x00236B6D
		// (set) Token: 0x06004F54 RID: 20308 RVA: 0x00238975 File Offset: 0x00236B75
		[DisplayName("可用")]
		[O_Oo00Oo000O0(6.0)]
		[DefaultValue(true)]
		[Category("属性")]
		public bool Enabled
		{
			get
			{
				return this.O_oOO_.o0.;
			}
			set
			{
				this.O_oOO_.o0. = value;
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06004F55 RID: 20309 RVA: 0x0023897E File Offset: 0x00236B7E
		// (set) Token: 0x06004F56 RID: 20310 RVA: 0x00238986 File Offset: 0x00236B86
		[DefaultValue(true)]
		[O_Oo00Oo000O0(7.0)]
		[Category("属性")]
		[DisplayName("可见")]
		public bool Visible
		{
			get
			{
				return this.Ooo_0_.o0.;
			}
			set
			{
				this.Ooo_0_.o0. = value;
			}
		}

		// Token: 0x0400206D RID: 8301
		private string <<EMPTY_NAME>>;

		// Token: 0x0400206E RID: 8302
		private string <<EMPTY_NAME>>;

		// Token: 0x0400206F RID: 8303
		private string <<EMPTY_NAME>>;

		// Token: 0x04002070 RID: 8304
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002071 RID: 8305
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002072 RID: 8306
		private bool <<EMPTY_NAME>>;
	}
}
