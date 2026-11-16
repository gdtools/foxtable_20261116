using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000497 RID: 1175
	[oO0oooo("1089")]
	[OoO0___o("RibbonGroup")]
	internal class RibbonGroup : RibbonBase
	{
		// Token: 0x06004FB7 RID: 20407 RVA: 0x00238DC6 File Offset: 0x00236FC6
		public RibbonGroup(DataRow A_0) : base(A_0)
		{
			this.o0.o00_. = true;
			this.Ooo_0_.o0. = true;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06004FB8 RID: 20408 RVA: 0x00238DE5 File Offset: 0x00236FE5
		// (set) Token: 0x06004FB9 RID: 20409 RVA: 0x00238E00 File Offset: 0x00237000
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		[DisplayName("标题")]
		public string Text
		{
			get
			{
				if (this.o0.o00_. == null)
				{
					this.o0.o00_. = "";
				}
				return this.o0.o00_.;
			}
			set
			{
				this.o0.o00_. = value;
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06004FBA RID: 20410 RVA: 0x00238E09 File Offset: 0x00237009
		// (set) Token: 0x06004FBB RID: 20411 RVA: 0x00238E11 File Offset: 0x00237011
		[O_Oo00Oo000O0(3.0)]
		[DisplayName("图标")]
		[Description("一个16*16尺寸的图标，或者对应大小的图片，该图标在分组处于收缩状态时显示。")]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[Category("属性")]
		public string Image
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

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06004FBC RID: 20412 RVA: 0x00238E1A File Offset: 0x0023701A
		// (set) Token: 0x06004FBD RID: 20413 RVA: 0x00238E22 File Offset: 0x00237022
		[DisplayName("提示")]
		[O_Oo00Oo000O0(4.0)]
		[Category("属性")]
		public string ToolTip
		{
			get
			{
				return this.OOo_.o__O_O0o_.;
			}
			set
			{
				this.OOo_.o__O_O0o_. = value;
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06004FBE RID: 20414 RVA: 0x00238E2B File Offset: 0x0023702B
		// (set) Token: 0x06004FBF RID: 20415 RVA: 0x00238E33 File Offset: 0x00237033
		[O_Oo00Oo000O0(5.0)]
		[DefaultValue(true)]
		[Category("属性")]
		[DisplayName("可用")]
		public bool Enabled
		{
			get
			{
				return this.o0.o00_.;
			}
			set
			{
				this.o0.o00_. = value;
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06004FC0 RID: 20416 RVA: 0x00238E3C File Offset: 0x0023703C
		// (set) Token: 0x06004FC1 RID: 20417 RVA: 0x00238E44 File Offset: 0x00237044
		[DefaultValue(true)]
		[O_Oo00Oo000O0(6.0)]
		[DisplayName("可见")]
		[Category("属性")]
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

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06004FC2 RID: 20418 RVA: 0x00238E4D File Offset: 0x0023704D
		// (set) Token: 0x06004FC3 RID: 20419 RVA: 0x00238E54 File Offset: 0x00237054
		[DisplayName("项目")]
		[O_Oo00Oo000O0(7.0)]
		[Editor(typeof(RibbonItemCollectionEditor), typeof(UITypeEditor))]
		[Category("属性")]
		public Hashtable Items
		{
			get
			{
				return new Hashtable();
			}
			set
			{
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06004FC4 RID: 20420 RVA: 0x00238E56 File Offset: 0x00237056
		// (set) Token: 0x06004FC5 RID: 20421 RVA: 0x00238E5E File Offset: 0x0023705E
		[O_Oo00Oo000O0(9.0)]
		[Category("属性")]
		[DisplayName("显示对话按钮")]
		public bool HasLauncherButton
		{
			get
			{
				return this.OOo_.o__O_O0o_.;
			}
			set
			{
				this.OOo_.o__O_O0o_. = value;
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06004FC6 RID: 20422 RVA: 0x00238E67 File Offset: 0x00237067
		// (set) Token: 0x06004FC7 RID: 20423 RVA: 0x00238E6F File Offset: 0x0023706F
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(0.1)]
		[Category("事件")]
		[Description("单击对话按钮后执行")]
		[O0O0oOO00_0OO(true)]
		public EventString DialogLauncherClick
		{
			get
			{
				return this.o0.o00_.;
			}
			set
			{
				this.o0.o00_. = value;
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06004FC8 RID: 20424 RVA: 0x00238E78 File Offset: 0x00237078
		// (set) Token: 0x06004FC9 RID: 20425 RVA: 0x00238E80 File Offset: 0x00237080
		[O_Oo00Oo000O0(4.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[Description("鼠标进入的时候执行。")]
		[O0O0oOO00_0OO(true)]
		public EventString MouseEnter
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

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06004FCA RID: 20426 RVA: 0x00238E89 File Offset: 0x00237089
		// (set) Token: 0x06004FCB RID: 20427 RVA: 0x00238E91 File Offset: 0x00237091
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(5.0)]
		[Category("事件")]
		[Description("鼠标离开的时候执行。")]
		[O0O0oOO00_0OO(true)]
		public EventString MouseLeave
		{
			get
			{
				return this.OOo_.o__O_O0o_.;
			}
			set
			{
				this.OOo_.o__O_O0o_. = value;
			}
		}

		// Token: 0x04002098 RID: 8344
		private string <<EMPTY_NAME>>;

		// Token: 0x04002099 RID: 8345
		private string <<EMPTY_NAME>>;

		// Token: 0x0400209A RID: 8346
		private string <<EMPTY_NAME>>;

		// Token: 0x0400209B RID: 8347
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400209C RID: 8348
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400209D RID: 8349
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400209E RID: 8350
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400209F RID: 8351
		private EventString <<EMPTY_NAME>>;

		// Token: 0x040020A0 RID: 8352
		private EventString <<EMPTY_NAME>>;
	}
}
