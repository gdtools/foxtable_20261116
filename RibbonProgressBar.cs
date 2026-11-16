using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000491 RID: 1169
	[OoO0___o("RibbonProgressBar")]
	[oO0oooo("2039")]
	internal class RibbonProgressBar : RibbonItem
	{
		// Token: 0x06004F70 RID: 20336 RVA: 0x00238AC4 File Offset: 0x00236CC4
		public RibbonProgressBar(DataRow A_0) : base(A_0)
		{
			this.O.O_OO000_O0_0. = 80;
			this.o_.ooo. = 12;
			this.o0oOo_.o0. = 100;
			this.OOO_.0. = 0;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06004F71 RID: 20337 RVA: 0x00238AF4 File Offset: 0x00236CF4
		// (set) Token: 0x06004F72 RID: 20338 RVA: 0x00238AFC File Offset: 0x00236CFC
		[DisplayName("宽度")]
		[O_Oo00Oo000O0(1.3)]
		[Category("属性")]
		public int Width
		{
			get
			{
				return this.O.O_OO000_O0_0.;
			}
			set
			{
				this.O.O_OO000_O0_0. = value;
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06004F73 RID: 20339 RVA: 0x00238B05 File Offset: 0x00236D05
		// (set) Token: 0x06004F74 RID: 20340 RVA: 0x00238B0D File Offset: 0x00236D0D
		[DefaultValue(12)]
		[O_Oo00Oo000O0(1.301)]
		[Category("属性")]
		[DisplayName("高度")]
		public int Height
		{
			get
			{
				return this.o_.ooo.;
			}
			set
			{
				value = Math.Min(24, Math.Max(5, value));
				this.o_.ooo. = value;
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06004F75 RID: 20341 RVA: 0x00238B26 File Offset: 0x00236D26
		// (set) Token: 0x06004F76 RID: 20342 RVA: 0x00238B2E File Offset: 0x00236D2E
		[Category("属性")]
		[DefaultValue(0)]
		[O_Oo00Oo000O0(1.31)]
		[DisplayName("最小值")]
		public int Minimum
		{
			get
			{
				return this.OOO_.0.;
			}
			set
			{
				this.OOO_.0. = value;
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06004F77 RID: 20343 RVA: 0x00238B37 File Offset: 0x00236D37
		// (set) Token: 0x06004F78 RID: 20344 RVA: 0x00238B3F File Offset: 0x00236D3F
		[DisplayName("最大值")]
		[Category("属性")]
		[DefaultValue(100)]
		[O_Oo00Oo000O0(1.32)]
		public int Maximum
		{
			get
			{
				return this.o0oOo_.o0.;
			}
			set
			{
				this.o0oOo_.o0. = value;
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06004F79 RID: 20345 RVA: 0x00238B48 File Offset: 0x00236D48
		// (set) Token: 0x06004F7A RID: 20346 RVA: 0x00238B50 File Offset: 0x00236D50
		[Category("属性")]
		[O_Oo00Oo000O0(1.4)]
		[DisplayName("初始值")]
		[DefaultValue(0)]
		public int Value
		{
			get
			{
				return this.oOo0_O._0Oo.;
			}
			set
			{
				this.oOo0_O._0Oo. = value;
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06004F7B RID: 20347 RVA: 0x00238B59 File Offset: 0x00236D59
		// (set) Token: 0x06004F7C RID: 20348 RVA: 0x00238B61 File Offset: 0x00236D61
		[O_Oo00Oo000O0(0.3)]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[Description("当前值改变后执行。")]
		public EventString ValueChanged
		{
			get
			{
				return this.O.O_OO000_O0_0.;
			}
			set
			{
				this.O.O_OO000_O0_0. = value;
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06004F7D RID: 20349 RVA: 0x00238B6A File Offset: 0x00236D6A
		// (set) Token: 0x06004F7E RID: 20350 RVA: 0x00238B6D File Offset: 0x00236D6D
		[Browsable(false)]
		public new string LargeImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06004F7F RID: 20351 RVA: 0x00238B6F File Offset: 0x00236D6F
		// (set) Token: 0x06004F80 RID: 20352 RVA: 0x00238B72 File Offset: 0x00236D72
		[Browsable(false)]
		public new string SmallImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06004F81 RID: 20353 RVA: 0x00238B74 File Offset: 0x00236D74
		// (set) Token: 0x06004F82 RID: 20354 RVA: 0x00238B82 File Offset: 0x00236D82
		[Browsable(false)]
		public new bool AutoHideText
		{
			get
			{
				bool result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06004F83 RID: 20355 RVA: 0x00238B84 File Offset: 0x00236D84
		// (set) Token: 0x06004F84 RID: 20356 RVA: 0x00238B92 File Offset: 0x00236D92
		[Browsable(false)]
		public new TextImageRelationEnum TextImageRelation
		{
			get
			{
				TextImageRelationEnum result;
				return result;
			}
			set
			{
			}
		}

		// Token: 0x0400207E RID: 8318
		private int <<EMPTY_NAME>>;

		// Token: 0x0400207F RID: 8319
		private int <<EMPTY_NAME>>;

		// Token: 0x04002080 RID: 8320
		private int <<EMPTY_NAME>>;

		// Token: 0x04002081 RID: 8321
		private int <<EMPTY_NAME>>;

		// Token: 0x04002082 RID: 8322
		private int <<EMPTY_NAME>>;

		// Token: 0x04002083 RID: 8323
		private EventString <<EMPTY_NAME>>;
	}
}
