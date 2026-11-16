using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000177 RID: 375
	internal class PDFViewerProperty : ControlPropertyBase
	{
		// Token: 0x060011DE RID: 4574 RVA: 0x0007FF10 File Offset: 0x0007E110
		public PDFViewerProperty(ControlHolder A_0) : base(A_0)
		{
			this.O00oO_00O._. = true;
			this.OO.__0oOOO_Oo. = true;
			this.O00oO_00O._. = (o_O0)A_0.ChildControl;
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x0007FF38 File Offset: 0x0007E138
		// (set) Token: 0x060011E0 RID: 4576 RVA: 0x0007FF40 File Offset: 0x0007E140
		[DisplayName("显示工具栏")]
		[Category("基本")]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(3.0)]
		[Description("是否显示工具栏")]
		public bool RibbonVisible
		{
			get
			{
				return this.O00oO_00O._.;
			}
			set
			{
				this.O00oO_00O._. = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0007FF49 File Offset: 0x0007E149
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x0007FF51 File Offset: 0x0007E151
		[DisplayName("显示状态栏")]
		[O_Oo00Oo000O0(3.0)]
		[DefaultValue(true)]
		[Description("是否显示状态栏")]
		[Category("基本")]
		public bool StatusBarVisible
		{
			get
			{
				return this.OO.__0oOOO_Oo.;
			}
			set
			{
				this.OO.__0oOOO_Oo. = value;
			}
		}

		// Token: 0x040006D3 RID: 1747
		private o_O0 <<EMPTY_NAME>>;

		// Token: 0x040006D4 RID: 1748
		private bool <<EMPTY_NAME>>;

		// Token: 0x040006D5 RID: 1749
		private bool <<EMPTY_NAME>>;
	}
}
