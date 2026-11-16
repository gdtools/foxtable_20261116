using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x0200049C RID: 1180
	[oO0oooo("1095")]
	internal class RibbonQat : RibbonItemContainer
	{
		// Token: 0x06004FDC RID: 20444 RVA: 0x00238F8B File Offset: 0x0023718B
		public RibbonQat(DataRow A_0) : base(A_0)
		{
			base.Name = "快速访问栏";
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06004FDD RID: 20445 RVA: 0x00238FA8 File Offset: 0x002371A8
		[Browsable(false)]
		public new string Name
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06004FDE RID: 20446 RVA: 0x00238FB8 File Offset: 0x002371B8
		// (set) Token: 0x06004FDF RID: 20447 RVA: 0x00238FC0 File Offset: 0x002371C0
		[Description("快速访问菜单是否位于Ribbon的下方。")]
		[Category("属性")]
		[O_Oo00Oo000O0(100.0)]
		[DisplayName("处于下端")]
		public bool BelowRibbon
		{
			get
			{
				return this.O._oo0__0o.;
			}
			set
			{
				this.O._oo0__0o. = value;
			}
		}

		// Token: 0x040020A6 RID: 8358
		private bool <<EMPTY_NAME>>;
	}
}
