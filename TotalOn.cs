using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020002A2 RID: 674
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TotalOn
	{
		// Token: 0x06002247 RID: 8775 RVA: 0x000F611A File Offset: 0x000F431A
		public TotalOn()
		{
			this.O__.o__. = AggregateEnum.Sum;
			this.Oo_o0O00O.o0O. = new List<string>();
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x000F6134 File Offset: 0x000F4334
		public TotalOn(string A_0)
		{
			this.O__.o__. = AggregateEnum.Sum;
			this.Oo_o0O00O.o0O. = new List<string>();
			this.O__.o__. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x000F6180 File Offset: 0x000F4380
		public TotalOn(string A_0, string A_1)
		{
			this.O__.o__. = AggregateEnum.Sum;
			this.Oo_o0O00O.o0O. = new List<string>();
			this.O__.o__. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.o0_0_0O0oo0.o_. = A_1;
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x000F61D4 File Offset: 0x000F43D4
		public TotalOn(string A_0, string A_1, string A_2)
		{
			this.O__.o__. = AggregateEnum.Sum;
			this.Oo_o0O00O.o0O. = new List<string>();
			this.O__.o__. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.o0_0_0O0oo0.o_. = A_1;
			this.Ooo.oo. = A_2;
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x000F6230 File Offset: 0x000F4430
		public TotalOn(string A_0, AggregateEnum A_1)
		{
			this.O__.o__. = AggregateEnum.Sum;
			this.Oo_o0O00O.o0O. = new List<string>();
			this.O__.o__. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.O__.o__. = A_1;
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x000F6284 File Offset: 0x000F4484
		public TotalOn(string A_0, AggregateEnum A_1, string A_2)
		{
			this.O__.o__. = AggregateEnum.Sum;
			this.Oo_o0O00O.o0O. = new List<string>();
			this.O__.o__. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.O__.o__. = A_1;
			this.o0_0_0O0oo0.o_. = A_2;
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x000F62E0 File Offset: 0x000F44E0
		public TotalOn(string A_0, AggregateEnum A_1, string A_2, string A_3)
		{
			this.O__.o__. = AggregateEnum.Sum;
			this.Oo_o0O00O.o0O. = new List<string>();
			this.O__.o__. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.O__.o__. = A_1;
			this.o0_0_0O0oo0.o_. = A_2;
			this.Ooo.oo. = A_3;
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x000F6342 File Offset: 0x000F4542
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x000F634A File Offset: 0x000F454A
		public string Name
		{
			get
			{
				return this.O__.o__.;
			}
			set
			{
				this.O__.o__. = value.Trim(new char[]
				{
					'['
				}).Trim(new char[]
				{
					']'
				});
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x000F6374 File Offset: 0x000F4574
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x000F63E9 File Offset: 0x000F45E9
		public string NewName
		{
			get
			{
				string result;
				if (Operators.CompareString(this.o0_0_0O0oo0.o_., "", true) > 0)
				{
					result = this.o0_0_0O0oo0.o_.;
				}
				else if (this.O__.o__..IndexOf(".") > 0)
				{
					result = this.O__.o__..Split(new char[]
					{
						'.'
					})[1].Trim(new char[]
					{
						'[',
						']'
					});
				}
				else
				{
					result = this.O__.o__.;
				}
				return result;
			}
			set
			{
				this.o0_0_0O0oo0.o_. = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x000F63F2 File Offset: 0x000F45F2
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x000F63FA File Offset: 0x000F45FA
		public string NewCaption
		{
			get
			{
				return this.Ooo.oo.;
			}
			set
			{
				this.Ooo.oo. = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x000F6403 File Offset: 0x000F4603
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x000F640B File Offset: 0x000F460B
		public AggregateEnum Aggregate
		{
			get
			{
				return this.O__.o__.;
			}
			set
			{
				this.O__.o__. = value;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x000F6414 File Offset: 0x000F4614
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x000F641C File Offset: 0x000F461C
		public bool upto
		{
			get
			{
				return this.Oo_o0O00O.o0O.;
			}
			set
			{
				this.Oo_o0O00O.o0O. = value;
			}
		}

		// Token: 0x04000E3F RID: 3647
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E40 RID: 3648
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E41 RID: 3649
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E42 RID: 3650
		private AggregateEnum <<EMPTY_NAME>>;

		// Token: 0x04000E43 RID: 3651
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E44 RID: 3652
		internal int <<EMPTY_NAME>>;

		// Token: 0x04000E45 RID: 3653
		internal double <<EMPTY_NAME>>;

		// Token: 0x04000E46 RID: 3654
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000E47 RID: 3655
		internal List<string> <<EMPTY_NAME>>;
	}
}
