using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000299 RID: 665
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class GroupOn
	{
		// Token: 0x06002179 RID: 8569 RVA: 0x000EA4F0 File Offset: 0x000E86F0
		internal GroupOn()
		{
			this.ooOo_0oo._0_. = DateGroupEnum.Month;
			this.oo_00o.00_0_. = true;
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x000EA506 File Offset: 0x000E8706
		public GroupOn(string A_0)
		{
			this.ooOo_0oo._0_. = DateGroupEnum.Month;
			this.oo_00o.00_0_. = true;
			this.OO0__0_.o00. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x000EA544 File Offset: 0x000E8744
		public GroupOn(string A_0, string A_1)
		{
			this.ooOo_0oo._0_. = DateGroupEnum.Month;
			this.oo_00o.00_0_. = true;
			this.OO0__0_.o00. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.oO0O.__o_OO_oo. = A_1;
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x000EA594 File Offset: 0x000E8794
		public GroupOn(string A_0, string A_1, string A_2)
		{
			this.ooOo_0oo._0_. = DateGroupEnum.Month;
			this.oo_00o.00_0_. = true;
			this.OO0__0_.o00. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.oO0O.__o_OO_oo. = A_1;
			this.OoO._0OO0O__. = A_2;
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x000EA5EC File Offset: 0x000E87EC
		public GroupOn(string A_0, DateGroupEnum A_1)
		{
			this.ooOo_0oo._0_. = DateGroupEnum.Month;
			this.oo_00o.00_0_. = true;
			this.OO0__0_.o00. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.ooOo_0oo._0_. = A_1;
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x000EA63C File Offset: 0x000E883C
		public GroupOn(string A_0, DateGroupEnum A_1, string A_2)
		{
			this.ooOo_0oo._0_. = DateGroupEnum.Month;
			this.oo_00o.00_0_. = true;
			this.OO0__0_.o00. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.ooOo_0oo._0_. = A_1;
			this.oO0O.__o_OO_oo. = A_2;
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x000EA694 File Offset: 0x000E8894
		public GroupOn(string A_0, DateGroupEnum A_1, string A_2, string A_3)
		{
			this.ooOo_0oo._0_. = DateGroupEnum.Month;
			this.oo_00o.00_0_. = true;
			this.OO0__0_.o00. = A_0.Trim(new char[]
			{
				'['
			}).Trim(new char[]
			{
				']'
			});
			this.ooOo_0oo._0_. = A_1;
			this.oO0O.__o_OO_oo. = A_2;
			this.OoO._0OO0O__. = A_3;
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x000EA6F2 File Offset: 0x000E88F2
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x000EA6FA File Offset: 0x000E88FA
		public string Name
		{
			get
			{
				return this.OO0__0_.o00.;
			}
			set
			{
				this.OO0__0_.o00. = value.Trim(new char[]
				{
					'['
				}).Trim(new char[]
				{
					']'
				});
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x000EA724 File Offset: 0x000E8924
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x000EA799 File Offset: 0x000E8999
		public string NewName
		{
			get
			{
				string result;
				if (Operators.CompareString(this.oO0O.__o_OO_oo., "", true) > 0)
				{
					result = this.oO0O.__o_OO_oo.;
				}
				else if (this.OO0__0_.o00..IndexOf(".") > 0)
				{
					result = this.OO0__0_.o00..Split(new char[]
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
					result = this.OO0__0_.o00.;
				}
				return result;
			}
			set
			{
				this.oO0O.__o_OO_oo. = value;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x000EA7A4 File Offset: 0x000E89A4
		internal string SourceName
		{
			get
			{
				string result;
				if (this.OO0__0_.o00..IndexOf(".") > 0)
				{
					result = this.OO0__0_.o00..Split(new char[]
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
					result = this.OO0__0_.o00.;
				}
				return result;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x000EA7FC File Offset: 0x000E89FC
		// (set) Token: 0x06002186 RID: 8582 RVA: 0x000EA804 File Offset: 0x000E8A04
		public string NewCaption
		{
			get
			{
				return this.OoO._0OO0O__.;
			}
			set
			{
				this.OoO._0OO0O__. = value;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x000EA80D File Offset: 0x000E8A0D
		// (set) Token: 0x06002188 RID: 8584 RVA: 0x000EA815 File Offset: 0x000E8A15
		public DateGroupEnum DateGroup
		{
			get
			{
				return this.ooOo_0oo._0_.;
			}
			set
			{
				this.ooOo_0oo._0_. = value;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x000EA81E File Offset: 0x000E8A1E
		// (set) Token: 0x0600218A RID: 8586 RVA: 0x000EA826 File Offset: 0x000E8A26
		internal bool IsValid
		{
			get
			{
				return this.oo_00o.00_0_.;
			}
			set
			{
				this.oo_00o.00_0_. = value;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x000EA82F File Offset: 0x000E8A2F
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x000EA837 File Offset: 0x000E8A37
		internal bool IsDate
		{
			get
			{
				return this.o0.0_.;
			}
			set
			{
				this.o0.0_. = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x0600218D RID: 8589 RVA: 0x000EA840 File Offset: 0x000E8A40
		// (set) Token: 0x0600218E RID: 8590 RVA: 0x000EA848 File Offset: 0x000E8A48
		internal string Pattern
		{
			get
			{
				return this.OO._0__O.;
			}
			set
			{
				this.OO._0__O. = value;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x000EA851 File Offset: 0x000E8A51
		// (set) Token: 0x06002190 RID: 8592 RVA: 0x000EA859 File Offset: 0x000E8A59
		internal bool Vertical
		{
			get
			{
				return this.OO0__0_.o00.;
			}
			set
			{
				this.OO0__0_.o00. = value;
			}
		}

		// Token: 0x04000DF9 RID: 3577
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DFA RID: 3578
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DFB RID: 3579
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DFC RID: 3580
		private DateGroupEnum <<EMPTY_NAME>>;

		// Token: 0x04000DFD RID: 3581
		private string <<EMPTY_NAME>>;

		// Token: 0x04000DFE RID: 3582
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000DFF RID: 3583
		private string <<EMPTY_NAME>>;

		// Token: 0x04000E00 RID: 3584
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000E01 RID: 3585
		private bool <<EMPTY_NAME>>;
	}
}
