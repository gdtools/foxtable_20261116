using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000490 RID: 1168
	[OoO0___o("RibbonNumericBox")]
	[oO0oooo("2037")]
	internal class RibbonNumericBox : RibbonItem
	{
		// Token: 0x06004F57 RID: 20311 RVA: 0x00238990 File Offset: 0x00236B90
		public RibbonNumericBox(DataRow A_0) : base(A_0)
		{
			this.O.oOOO. = "数值:";
			this.o0_.OO. = 50;
			this.o0_.OO. = 100m;
			this.OO_O0__oOo00.0. = 0m;
			this.O_.____0_O. = 1m;
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06004F58 RID: 20312 RVA: 0x002389E4 File Offset: 0x00236BE4
		// (set) Token: 0x06004F59 RID: 20313 RVA: 0x002389EC File Offset: 0x00236BEC
		[O_Oo00Oo000O0(1.1)]
		[Category("属性")]
		[DisplayName("标题")]
		[DefaultValue("数值:")]
		public string Label
		{
			get
			{
				return this.O.oOOO.;
			}
			set
			{
				this.O.oOOO. = value;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06004F5A RID: 20314 RVA: 0x002389F5 File Offset: 0x00236BF5
		// (set) Token: 0x06004F5B RID: 20315 RVA: 0x002389FD File Offset: 0x00236BFD
		[O_Oo00Oo000O0(1.3)]
		[Category("属性")]
		[DisplayName("宽度")]
		public int TextAreaWidth
		{
			get
			{
				return this.o0_.OO.;
			}
			set
			{
				this.o0_.OO. = value;
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06004F5C RID: 20316 RVA: 0x00238A06 File Offset: 0x00236C06
		// (set) Token: 0x06004F5D RID: 20317 RVA: 0x00238A0E File Offset: 0x00236C0E
		[O_Oo00Oo000O0(1.31)]
		[DefaultValue(0)]
		[Category("属性")]
		[DisplayName("最小值")]
		public decimal Minimum
		{
			get
			{
				return this.OO_O0__oOo00.0.;
			}
			set
			{
				this.OO_O0__oOo00.0. = value;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06004F5E RID: 20318 RVA: 0x00238A17 File Offset: 0x00236C17
		// (set) Token: 0x06004F5F RID: 20319 RVA: 0x00238A1F File Offset: 0x00236C1F
		[DisplayName("最大值")]
		[O_Oo00Oo000O0(1.32)]
		[DefaultValue(100)]
		[Category("属性")]
		public decimal Maximum
		{
			get
			{
				return this.o0_.OO.;
			}
			set
			{
				this.o0_.OO. = value;
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06004F60 RID: 20320 RVA: 0x00238A28 File Offset: 0x00236C28
		// (set) Token: 0x06004F61 RID: 20321 RVA: 0x00238A30 File Offset: 0x00236C30
		[O_Oo00Oo000O0(1.4)]
		[Category("属性")]
		[DisplayName("初始值")]
		public string Value
		{
			get
			{
				return this.OO_O0__oOo00.0.;
			}
			set
			{
				if (Versioned.IsNumeric(value))
				{
					this.OO_O0__oOo00.0. = Conversion.Val(value).ToString();
				}
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06004F62 RID: 20322 RVA: 0x00238A59 File Offset: 0x00236C59
		// (set) Token: 0x06004F63 RID: 20323 RVA: 0x00238A61 File Offset: 0x00236C61
		[DisplayName("微调增幅")]
		[O_Oo00Oo000O0(1.5)]
		[Category("属性")]
		[DefaultValue(1)]
		public decimal Increment
		{
			get
			{
				return this.O_.____0_O.;
			}
			set
			{
				this.O_.____0_O. = value;
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06004F64 RID: 20324 RVA: 0x00238A6A File Offset: 0x00236C6A
		// (set) Token: 0x06004F65 RID: 20325 RVA: 0x00238A72 File Offset: 0x00236C72
		[Description("取消修改后执行。")]
		[O_Oo00Oo000O0(0.1)]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString ChangeCanceled
		{
			get
			{
				return this.O.oOOO.;
			}
			set
			{
				this.O.oOOO. = value;
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06004F66 RID: 20326 RVA: 0x00238A7B File Offset: 0x00236C7B
		// (set) Token: 0x06004F67 RID: 20327 RVA: 0x00238A83 File Offset: 0x00236C83
		[Description("提交修改后执行。")]
		[O_Oo00Oo000O0(0.2)]
		[Category("事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString ChangeCommitted
		{
			get
			{
				return this.oo0o.0ooo.;
			}
			set
			{
				this.oo0o.0ooo. = value;
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06004F68 RID: 20328 RVA: 0x00238A8C File Offset: 0x00236C8C
		// (set) Token: 0x06004F69 RID: 20329 RVA: 0x00238A94 File Offset: 0x00236C94
		[Category("事件")]
		[O_Oo00Oo000O0(0.3)]
		[Description("值改变后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString ValueChanged
		{
			get
			{
				return this.O0o.00O_0.;
			}
			set
			{
				this.O0o.00O_0. = value;
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06004F6A RID: 20330 RVA: 0x00238A9D File Offset: 0x00236C9D
		// (set) Token: 0x06004F6B RID: 20331 RVA: 0x00238AA5 File Offset: 0x00236CA5
		[O_Oo00Oo000O0(0.4)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("事件")]
		[Description("获得输入焦点后执行。")]
		[O0O0oOO00_0OO(true)]
		public EventString GotFocus
		{
			get
			{
				return this.O._Oo_o_O_.;
			}
			set
			{
				this.O._Oo_o_O_. = value;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06004F6C RID: 20332 RVA: 0x00238AAE File Offset: 0x00236CAE
		// (set) Token: 0x06004F6D RID: 20333 RVA: 0x00238AB6 File Offset: 0x00236CB6
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("失去输入焦点后执行。")]
		[O_Oo00Oo000O0(0.5)]
		[O0O0oOO00_0OO(true)]
		[Category("事件")]
		public EventString LostFocus
		{
			get
			{
				return this.o_o.0_0_o.;
			}
			set
			{
				this.o_o.0_0_o. = value;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06004F6E RID: 20334 RVA: 0x00238ABF File Offset: 0x00236CBF
		// (set) Token: 0x06004F6F RID: 20335 RVA: 0x00238AC2 File Offset: 0x00236CC2
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

		// Token: 0x04002073 RID: 8307
		private string <<EMPTY_NAME>>;

		// Token: 0x04002074 RID: 8308
		private int <<EMPTY_NAME>>;

		// Token: 0x04002075 RID: 8309
		private string <<EMPTY_NAME>>;

		// Token: 0x04002076 RID: 8310
		private decimal <<EMPTY_NAME>>;

		// Token: 0x04002077 RID: 8311
		private decimal <<EMPTY_NAME>>;

		// Token: 0x04002078 RID: 8312
		private decimal <<EMPTY_NAME>>;

		// Token: 0x04002079 RID: 8313
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400207A RID: 8314
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400207B RID: 8315
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400207C RID: 8316
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400207D RID: 8317
		private EventString <<EMPTY_NAME>>;
	}
}
