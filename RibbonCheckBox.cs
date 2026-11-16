using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace Foxtable
{
	// Token: 0x02000485 RID: 1157
	[oO0oooo("1118")]
	[OoO0___o("RibbonCheckBox")]
	internal class RibbonCheckBox : RibbonButton
	{
		// Token: 0x06004EEB RID: 20203 RVA: 0x002384F2 File Offset: 0x002366F2
		public RibbonCheckBox(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06004EEC RID: 20204 RVA: 0x00238503 File Offset: 0x00236703
		// (set) Token: 0x06004EED RID: 20205 RVA: 0x0023850B File Offset: 0x0023670B
		[O_Oo00Oo000O0(1.2)]
		[DefaultValue(false)]
		[Category("属性")]
		[DisplayName("选中")]
		public bool Checked
		{
			get
			{
				return this.o0o__0.OO0O.;
			}
			set
			{
				this.o0o__0.OO0O. = value;
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06004EEE RID: 20206 RVA: 0x00238514 File Offset: 0x00236714
		// (set) Token: 0x06004EEF RID: 20207 RVA: 0x0023851C File Offset: 0x0023671C
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(1.1)]
		[Description("选中状态改变后执行。")]
		[Category("事件")]
		[O0O0oOO00_0OO(true)]
		public EventString CheckedChanged
		{
			get
			{
				return this.o0o__0.OO0O.;
			}
			set
			{
				this.o0o__0.OO0O. = value;
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06004EF0 RID: 20208 RVA: 0x00238525 File Offset: 0x00236725
		// (set) Token: 0x06004EF1 RID: 20209 RVA: 0x00238528 File Offset: 0x00236728
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

		// Token: 0x04002048 RID: 8264
		private new bool <<EMPTY_NAME>>;

		// Token: 0x04002049 RID: 8265
		private new EventString <<EMPTY_NAME>>;
	}
}
