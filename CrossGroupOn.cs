using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200028F RID: 655
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CrossGroupOn
	{
		// Token: 0x060020A9 RID: 8361 RVA: 0x000E3109 File Offset: 0x000E1309
		internal CrossGroupOn()
		{
			this.o__.Ooo. = "";
			this.O0oo00.0O_oO_. = DateGroupEnum.Month;
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x000E3123 File Offset: 0x000E1323
		public CrossGroupOn(string A_0)
		{
			this.o__.Ooo. = "";
			this.O0oo00.0O_oO_. = DateGroupEnum.Month;
			this.O0oo00.0O_oO_. = A_0;
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x000E3144 File Offset: 0x000E1344
		public CrossGroupOn(string A_0, string A_1)
		{
			this.o__.Ooo. = "";
			this.O0oo00.0O_oO_. = DateGroupEnum.Month;
			this.O0oo00.0O_oO_. = A_0;
			this.O0O0oo._O00__o. = A_1;
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x000E316C File Offset: 0x000E136C
		public CrossGroupOn(string A_0, DateGroupEnum A_1)
		{
			this.o__.Ooo. = "";
			this.O0oo00.0O_oO_. = DateGroupEnum.Month;
			this.O0oo00.0O_oO_. = A_0;
			this.O0oo00.0O_oO_. = A_1;
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x000E3194 File Offset: 0x000E1394
		public CrossGroupOn(string A_0, DateGroupEnum A_1, string A_2)
		{
			this.o__.Ooo. = "";
			this.O0oo00.0O_oO_. = DateGroupEnum.Month;
			this.O0oo00.0O_oO_. = A_0;
			this.O0oo00.0O_oO_. = A_1;
			this.O0O0oo._O00__o. = A_2;
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x000E31C3 File Offset: 0x000E13C3
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x000E31CB File Offset: 0x000E13CB
		public string Name
		{
			get
			{
				return this.O0oo00.0O_oO_.;
			}
			set
			{
				this.O0oo00.0O_oO_. = value;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x000E31D4 File Offset: 0x000E13D4
		public string NewName
		{
			get
			{
				if (Operators.CompareString(this.o__.Ooo., "", true) == 0)
				{
					this.o__.Ooo. = "A" + OoOo0O.OO_o.0o_O.(6);
				}
				return this.o__.Ooo.;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x000E3205 File Offset: 0x000E1405
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x000E320D File Offset: 0x000E140D
		public DateGroupEnum DateGroup
		{
			get
			{
				return this.O0oo00.0O_oO_.;
			}
			set
			{
				this.O0oo00.0O_oO_. = value;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x000E3216 File Offset: 0x000E1416
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x000E321E File Offset: 0x000E141E
		public string Pattern
		{
			get
			{
				return this.O0O0oo._O00__o.;
			}
			set
			{
				this.O0O0oo._O00__o. = value;
			}
		}

		// Token: 0x04000DAF RID: 3503
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DB0 RID: 3504
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DB1 RID: 3505
		private DateGroupEnum <<EMPTY_NAME>>;

		// Token: 0x04000DB2 RID: 3506
		private string <<EMPTY_NAME>>;
	}
}
