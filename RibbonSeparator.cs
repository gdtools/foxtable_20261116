using System;
using System.ComponentModel;
using System.Data;

namespace Foxtable
{
	// Token: 0x0200049D RID: 1181
	[OoO0___o("RibbonSeparator")]
	[oO0oooo("1120")]
	internal class RibbonSeparator : RibbonItem
	{
		// Token: 0x06004FE0 RID: 20448 RVA: 0x00238FC9 File Offset: 0x002371C9
		public RibbonSeparator(DataRow A_0) : base(A_0)
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this, A_0, false);
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06004FE1 RID: 20449 RVA: 0x00238FDA File Offset: 0x002371DA
		// (set) Token: 0x06004FE2 RID: 20450 RVA: 0x00238FDD File Offset: 0x002371DD
		[OooO0(true)]
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

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x00238FDF File Offset: 0x002371DF
		// (set) Token: 0x06004FE4 RID: 20452 RVA: 0x00238FE2 File Offset: 0x002371E2
		[Browsable(false)]
		[OooO0(true)]
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

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x00238FE4 File Offset: 0x002371E4
		// (set) Token: 0x06004FE6 RID: 20454 RVA: 0x00238FE7 File Offset: 0x002371E7
		[OooO0(true)]
		[Browsable(false)]
		public new TextImageRelationEnum TextImageRelation
		{
			get
			{
				return TextImageRelationEnum.Automatic;
			}
			set
			{
			}
		}
	}
}
