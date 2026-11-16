using System;
using System.ComponentModel;

namespace Foxtable
{
	// Token: 0x02000293 RID: 659
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class DataColBuilder
	{
		// Token: 0x06002117 RID: 8471 RVA: 0x000E91CE File Offset: 0x000E73CE
		public DataColBuilder(string A_0, Type A_1)
		{
			this.O_0__o.o_0o. = 32;
			this.oo.O_0OOO_o. = "";
			this.OOo._oO00ooo. = "";
			this.O_0__o.o_0o. = A_0;
			this.O_0__o.o_0o. = A_1;
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x000E9202 File Offset: 0x000E7402
		public DataColBuilder(string A_0, Type A_1, string A_2)
		{
			this.O_0__o.o_0o. = 32;
			this.oo.O_0OOO_o. = "";
			this.OOo._oO00ooo. = "";
			this.O_0__o.o_0o. = A_0;
			this.O_0__o.o_0o. = A_1;
			this.OOo._oO00ooo. = A_2;
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x000E9240 File Offset: 0x000E7440
		public DataColBuilder(string A_0, Type A_1, string A_2, string A_3)
		{
			this.O_0__o.o_0o. = 32;
			this.oo.O_0OOO_o. = "";
			this.OOo._oO00ooo. = "";
			this.O_0__o.o_0o. = A_0;
			this.O_0__o.o_0o. = A_1;
			this.OOo._oO00ooo. = A_2;
			this.oo.O_0OOO_o. = A_3;
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x000E928E File Offset: 0x000E748E
		public DataColBuilder(string A_0, Type A_1, int A_2)
		{
			this.O_0__o.o_0o. = 32;
			this.oo.O_0OOO_o. = "";
			this.OOo._oO00ooo. = "";
			this.O_0__o.o_0o. = A_0;
			this.O_0__o.o_0o. = A_1;
			this.O_0__o.o_0o. = A_2;
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x000E92CC File Offset: 0x000E74CC
		public DataColBuilder(string A_0, Type A_1, int A_2, string A_3)
		{
			this.O_0__o.o_0o. = 32;
			this.oo.O_0OOO_o. = "";
			this.OOo._oO00ooo. = "";
			this.O_0__o.o_0o. = A_0;
			this.O_0__o.o_0o. = A_1;
			this.O_0__o.o_0o. = A_2;
			this.OOo._oO00ooo. = A_3;
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x000E931C File Offset: 0x000E751C
		public DataColBuilder(string A_0, Type A_1, int A_2, string A_3, string A_4)
		{
			this.O_0__o.o_0o. = 32;
			this.oo.O_0OOO_o. = "";
			this.OOo._oO00ooo. = "";
			this.O_0__o.o_0o. = A_0;
			this.O_0__o.o_0o. = A_1;
			this.O_0__o.o_0o. = A_2;
			this.OOo._oO00ooo. = A_3;
			this.oo.O_0OOO_o. = A_4;
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x000E9372 File Offset: 0x000E7572
		// (set) Token: 0x0600211E RID: 8478 RVA: 0x000E937A File Offset: 0x000E757A
		public string Name
		{
			get
			{
				return this.O_0__o.o_0o.;
			}
			set
			{
				this.O_0__o.o_0o. = value;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x000E9383 File Offset: 0x000E7583
		// (set) Token: 0x06002120 RID: 8480 RVA: 0x000E938B File Offset: 0x000E758B
		public Type Type
		{
			get
			{
				return this.O_0__o.o_0o.;
			}
			set
			{
				this.O_0__o.o_0o. = value;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x000E9394 File Offset: 0x000E7594
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x000E939C File Offset: 0x000E759C
		public string Caption
		{
			get
			{
				return this.oo.O_0OOO_o.;
			}
			set
			{
				this.oo.O_0OOO_o. = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x000E93A5 File Offset: 0x000E75A5
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x000E93AD File Offset: 0x000E75AD
		public int Maxlength
		{
			get
			{
				return this.O_0__o.o_0o.;
			}
			set
			{
				this.O_0__o.o_0o. = value;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x000E93B6 File Offset: 0x000E75B6
		// (set) Token: 0x06002126 RID: 8486 RVA: 0x000E93BE File Offset: 0x000E75BE
		public string Expression
		{
			get
			{
				return this.OOo._oO00ooo.;
			}
			set
			{
				this.OOo._oO00ooo. = value;
			}
		}

		// Token: 0x04000DDB RID: 3547
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DDC RID: 3548
		private Type <<EMPTY_NAME>>;

		// Token: 0x04000DDD RID: 3549
		private int <<EMPTY_NAME>>;

		// Token: 0x04000DDE RID: 3550
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DDF RID: 3551
		private string <<EMPTY_NAME>>;
	}
}
