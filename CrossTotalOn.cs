using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000292 RID: 658
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class CrossTotalOn
	{
		// Token: 0x0600210A RID: 8458 RVA: 0x000E8FB1 File Offset: 0x000E71B1
		internal CrossTotalOn(bool A_0 = false)
		{
			this.O_oO_O_0.0_o. = AggregateEnum.Sum;
			this.O_oO_O_0.0_o. = A_0;
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x000E8FC7 File Offset: 0x000E71C7
		public CrossTotalOn(string A_0, bool A_1 = false)
		{
			this.O_oO_O_0.0_o. = AggregateEnum.Sum;
			this.O_oO_O_0.0_o. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.O_oO_O_0.0_o. = A_1;
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x000E9004 File Offset: 0x000E7204
		public CrossTotalOn(string A_0, string A_1, bool A_2 = false)
		{
			this.O_oO_O_0.0_o. = AggregateEnum.Sum;
			this.O_oO_O_0.0_o. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.oO00._. = A_1;
			this.O_oO_O_0.0_o. = A_2;
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000E9054 File Offset: 0x000E7254
		public CrossTotalOn(string A_0, AggregateEnum A_1, bool A_2 = false)
		{
			this.O_oO_O_0.0_o. = AggregateEnum.Sum;
			this.O_oO_O_0.0_o. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.O_oO_O_0.0_o. = A_1;
			this.O_oO_O_0.0_o. = A_2;
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x000E90A4 File Offset: 0x000E72A4
		public CrossTotalOn(string A_0, AggregateEnum A_1, string A_2, bool A_3 = false)
		{
			this.O_oO_O_0.0_o. = AggregateEnum.Sum;
			this.O_oO_O_0.0_o. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.O_oO_O_0.0_o. = A_1;
			this.oO00._. = A_2;
			this.O_oO_O_0.0_o. = A_3;
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x000E90FB File Offset: 0x000E72FB
		// (set) Token: 0x06002110 RID: 8464 RVA: 0x000E9103 File Offset: 0x000E7303
		public string Name
		{
			get
			{
				return this.O_oO_O_0.0_o.;
			}
			set
			{
				this.O_oO_O_0.0_o. = value.Trim(new char[]
				{
					'['
				}).Trim(new char[]
				{
					']'
				});
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x000E912C File Offset: 0x000E732C
		// (set) Token: 0x06002112 RID: 8466 RVA: 0x000E91A3 File Offset: 0x000E73A3
		public string Caption
		{
			get
			{
				string result;
				if (Operators.CompareString(this.oO00._., "", true) > 0)
				{
					result = this.oO00._.;
				}
				else if (this.O_oO_O_0.0_o..StartsWith("{") && this.O_oO_O_0.0_o..IndexOf("}.") > 0)
				{
					result = this.O_oO_O_0.0_o..Substring(this.O_oO_O_0.0_o..IndexOf("}.") + 2);
				}
				else
				{
					result = this.O_oO_O_0.0_o.;
				}
				return result;
			}
			set
			{
				this.oO00._. = value;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x000E91AC File Offset: 0x000E73AC
		// (set) Token: 0x06002114 RID: 8468 RVA: 0x000E91B4 File Offset: 0x000E73B4
		public AggregateEnum Aggregate
		{
			get
			{
				return this.O_oO_O_0.0_o.;
			}
			set
			{
				this.O_oO_O_0.0_o. = value;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x000E91BD File Offset: 0x000E73BD
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x000E91C5 File Offset: 0x000E73C5
		public bool upto
		{
			get
			{
				return this.O_oO_O_0.0_o.;
			}
			set
			{
				this.O_oO_O_0.0_o. = value;
			}
		}

		// Token: 0x04000DD7 RID: 3543
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DD8 RID: 3544
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DD9 RID: 3545
		private AggregateEnum <<EMPTY_NAME>>;

		// Token: 0x04000DDA RID: 3546
		private bool <<EMPTY_NAME>>;
	}
}
