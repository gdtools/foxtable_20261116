using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000295 RID: 661
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ExpressionGroup
	{
		// Token: 0x0600213A RID: 8506 RVA: 0x000E9AB4 File Offset: 0x000E7CB4
		public ExpressionGroup(string A_0, string A_1, string A_2)
		{
			this.O_0_O.OoO_0_0O. = A_0;
			this.O.O_O. = A_1;
			this.OoOO0.00_O_o. = A_2;
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x000E9AD1 File Offset: 0x000E7CD1
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x000E9AD9 File Offset: 0x000E7CD9
		public string Name
		{
			get
			{
				return this.O_0_O.OoO_0_0O.;
			}
			set
			{
				this.O_0_O.OoO_0_0O. = value;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x000E9AE2 File Offset: 0x000E7CE2
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x000E9AEA File Offset: 0x000E7CEA
		public string Caption
		{
			get
			{
				return this.OoOO0.00_O_o.;
			}
			set
			{
				this.OoOO0.00_O_o. = value;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x000E9AF3 File Offset: 0x000E7CF3
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x000E9AFB File Offset: 0x000E7CFB
		public string Expression
		{
			get
			{
				return this.O.O_O.;
			}
			set
			{
				this.O.O_O. = value;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x000E9B04 File Offset: 0x000E7D04
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x000E9B0C File Offset: 0x000E7D0C
		internal string Pattern
		{
			get
			{
				return this.o.0_0o.;
			}
			set
			{
				if (Operators.CompareString(value, "", true) > 0 && value.IndexOf("{0}") >= 0)
				{
					this.o.0_0o. = value;
				}
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x000E9B32 File Offset: 0x000E7D32
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x000E9B3A File Offset: 0x000E7D3A
		internal bool Vertical
		{
			get
			{
				return this.O_0_O.OoO_0_0O.;
			}
			set
			{
				this.O_0_O.OoO_0_0O. = value;
			}
		}

		// Token: 0x04000DE4 RID: 3556
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DE5 RID: 3557
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DE6 RID: 3558
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DE7 RID: 3559
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DE8 RID: 3560
		private bool <<EMPTY_NAME>>;
	}
}
