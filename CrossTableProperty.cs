using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000333 RID: 819
	internal class CrossTableProperty
	{
		// Token: 0x06002D98 RID: 11672 RVA: 0x0014FA99 File Offset: 0x0014DC99
		public CrossTableProperty(CrossTableBuilder A_0)
		{
			this.O0o__o0o.0. = 4;
			this.O0o__o0o.0. = A_0;
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x0014FAAF File Offset: 0x0014DCAF
		// (set) Token: 0x06002D9A RID: 11674 RVA: 0x0014FABC File Offset: 0x0014DCBC
		public string CrossTableName
		{
			get
			{
				return this.O0o__o0o.0..TableName;
			}
			set
			{
				this.Oo0.OOooO. = value;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x0014FAC5 File Offset: 0x0014DCC5
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x0014FAD2 File Offset: 0x0014DCD2
		public string CrossTableCaption
		{
			get
			{
				return this.O0o__o0o.0..Caption;
			}
			set
			{
				this.O.OooOo00. = value;
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06002D9D RID: 11677 RVA: 0x0014FADB File Offset: 0x0014DCDB
		// (set) Token: 0x06002D9E RID: 11678 RVA: 0x0014FAE8 File Offset: 0x0014DCE8
		public string CrossTableFilter
		{
			get
			{
				return this.O0o__o0o.0..Filter;
			}
			set
			{
				this.oOOO.o0Oo0__. = value;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06002D9F RID: 11679 RVA: 0x0014FAF1 File Offset: 0x0014DCF1
		// (set) Token: 0x06002DA0 RID: 11680 RVA: 0x0014FAFE File Offset: 0x0014DCFE
		public string ExtendFilter
		{
			get
			{
				return this.O0o__o0o.0..ExtendFilter;
			}
			set
			{
				this.O0o__o0o.0..ExtendFilter = value;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06002DA1 RID: 11681 RVA: 0x0014FB0C File Offset: 0x0014DD0C
		// (set) Token: 0x06002DA2 RID: 11682 RVA: 0x0014FB19 File Offset: 0x0014DD19
		public bool FromAll
		{
			get
			{
				return this.O0o__o0o.0..FromAll;
			}
			set
			{
				this.O0o__o0o.0..FromAll = value;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06002DA3 RID: 11683 RVA: 0x0014FB27 File Offset: 0x0014DD27
		// (set) Token: 0x06002DA4 RID: 11684 RVA: 0x0014FB34 File Offset: 0x0014DD34
		public bool FromServer
		{
			get
			{
				return this.O0o__o0o.0..FromServer;
			}
			set
			{
				this.o.OOO0__o_. = value;
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002DA5 RID: 11685 RVA: 0x0014FB3D File Offset: 0x0014DD3D
		// (set) Token: 0x06002DA6 RID: 11686 RVA: 0x0014FB4A File Offset: 0x0014DD4A
		public bool HorizontalProportion
		{
			get
			{
				return this.O0o__o0o.0..HorizontalProportion;
			}
			set
			{
				this.o__.__O_o__. = value;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002DA7 RID: 11687 RVA: 0x0014FB53 File Offset: 0x0014DD53
		// (set) Token: 0x06002DA8 RID: 11688 RVA: 0x0014FB60 File Offset: 0x0014DD60
		public bool VerticalProportion
		{
			get
			{
				return this.O0o__o0o.0..VerticalProportion;
			}
			set
			{
				this.oOO_.o_0OOO. = value;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06002DA9 RID: 11689 RVA: 0x0014FB69 File Offset: 0x0014DD69
		// (set) Token: 0x06002DAA RID: 11690 RVA: 0x0014FB76 File Offset: 0x0014DD76
		public string HorizontalProportionCaption
		{
			get
			{
				return this.O0o__o0o.0..HorizontalProportionCaption;
			}
			set
			{
				this.o.oo0. = value;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06002DAB RID: 11691 RVA: 0x0014FB7F File Offset: 0x0014DD7F
		// (set) Token: 0x06002DAC RID: 11692 RVA: 0x0014FB8C File Offset: 0x0014DD8C
		public string VerticalProportionCaption
		{
			get
			{
				return this.O0o__o0o.0..VerticalProportionCaption;
			}
			set
			{
				this.o.o_OO0. = value;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06002DAD RID: 11693 RVA: 0x0014FB95 File Offset: 0x0014DD95
		// (set) Token: 0x06002DAE RID: 11694 RVA: 0x0014FBA2 File Offset: 0x0014DDA2
		public int Decimals
		{
			get
			{
				return this.O0o__o0o.0..Decimals;
			}
			set
			{
				this.O0o__o0o.0. = value;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06002DAF RID: 11695 RVA: 0x0014FBAB File Offset: 0x0014DDAB
		// (set) Token: 0x06002DB0 RID: 11696 RVA: 0x0014FBB8 File Offset: 0x0014DDB8
		public bool Subtotal
		{
			get
			{
				return this.O0o__o0o.0..Subtotal;
			}
			set
			{
				this.o.oo0. = value;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06002DB1 RID: 11697 RVA: 0x0014FBC4 File Offset: 0x0014DDC4
		// (set) Token: 0x06002DB2 RID: 11698 RVA: 0x0014FC44 File Offset: 0x0014DE44
		public string CrossTableHGroups
		{
			get
			{
				string text = "";
				try
				{
					foreach (GroupOn a_ in this.O0o__o0o.0..HGroups)
					{
						if (Operators.CompareString(text, "", true) > 0)
						{
							text += "\r";
						}
						text += o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\n', false);
					}
				}
				finally
				{
					IEnumerator<GroupOn> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				return text;
			}
			set
			{
				this.o___0o.0OOOooO. = value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002DB3 RID: 11699 RVA: 0x0014FC50 File Offset: 0x0014DE50
		// (set) Token: 0x06002DB4 RID: 11700 RVA: 0x0014FCD0 File Offset: 0x0014DED0
		public string CrossTableVGroups
		{
			get
			{
				string text = "";
				try
				{
					foreach (CrossGroupOn a_ in this.O0o__o0o.0..VGroups)
					{
						if (Operators.CompareString(text, "", true) > 0)
						{
							text += "\r";
						}
						text += o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\n', false);
					}
				}
				finally
				{
					IEnumerator<CrossGroupOn> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				return text;
			}
			set
			{
				this.o0O0__Oo_O_0._. = value;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002DB5 RID: 11701 RVA: 0x0014FCD9 File Offset: 0x0014DED9
		// (set) Token: 0x06002DB6 RID: 11702 RVA: 0x0014FCE6 File Offset: 0x0014DEE6
		public bool CrossTableOrderByTotal
		{
			get
			{
				return this.O0o__o0o.0..OrderByTotal;
			}
			set
			{
				this.o___0o.0OOOooO. = value;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x0014FCEF File Offset: 0x0014DEEF
		// (set) Token: 0x06002DB8 RID: 11704 RVA: 0x0014FCFC File Offset: 0x0014DEFC
		public bool CrossTableHorizontalTotal
		{
			get
			{
				return this.O0o__o0o.0..HorizontalTotal;
			}
			set
			{
				this.oO.Oo0. = value;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002DB9 RID: 11705 RVA: 0x0014FD05 File Offset: 0x0014DF05
		// (set) Token: 0x06002DBA RID: 11706 RVA: 0x0014FD12 File Offset: 0x0014DF12
		public bool CrossTableVerticalTotal
		{
			get
			{
				return this.O0o__o0o.0..VerticalTotal;
			}
			set
			{
				this.oOo.00o_. = value;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002DBB RID: 11707 RVA: 0x0014FD1C File Offset: 0x0014DF1C
		// (set) Token: 0x06002DBC RID: 11708 RVA: 0x0014FD9C File Offset: 0x0014DF9C
		public string CrossTableTotals
		{
			get
			{
				string text = "";
				try
				{
					foreach (CrossTotalOn a_ in this.O0o__o0o.0..Totals)
					{
						if (Operators.CompareString(text, "", true) > 0)
						{
							text += "\r";
						}
						text += o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\n', false);
					}
				}
				finally
				{
					IEnumerator<CrossTotalOn> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				return text;
			}
			set
			{
				this.O_O.oo0_0_. = value;
			}
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x0014FDA8 File Offset: 0x0014DFA8
		internal void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.o___0o.0OOOooO., "", true) > 0 && Operators.CompareString(this.o0O0__Oo_O_0._., "", true) > 0 && Operators.CompareString(this.O_O.oo0_0_., "", true) > 0)
			{
				this.O0o__o0o.0..TableName = this.Oo0.OOooO.;
				this.O0o__o0o.0..Caption = this.O.OooOo00.;
				this.O0o__o0o.0..Filter = this.oOOO.o0Oo0__.;
				this.O0o__o0o.0..OrderByTotal = this.o___0o.0OOOooO.;
				this.O0o__o0o.0..HorizontalTotal = this.oO.Oo0.;
				this.O0o__o0o.0..VerticalTotal = this.oOo.00o_.;
				this.O0o__o0o.0..HorizontalProportion = this.o__.__O_o__.;
				this.O0o__o0o.0..HorizontalProportionCaption = this.o.oo0.;
				this.O0o__o0o.0..VerticalProportion = this.oOO_.o_0OOO.;
				this.O0o__o0o.0..VerticalProportionCaption = this.o.o_OO0.;
				this.O0o__o0o.0..Decimals = this.O0o__o0o.0.;
				this.O0o__o0o.0..FromServer = this.o.OOO0__o_.;
				this.O0o__o0o.0..Subtotal = this.o.oo0.;
				string[] array = this.o___0o.0OOOooO..Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				string[] array2 = this.o0O0__Oo_O_0._..Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				string[] array3 = this.O_O.oo0_0_..Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				foreach (string a_ in array)
				{
					GroupOn groupOn = new GroupOn();
					o_O_o_oOoo__.OOOO_OO._oo.(groupOn, a_, '\n');
					this.O0o__o0o.0..HGroups.Add(groupOn);
				}
				foreach (string a_2 in array2)
				{
					CrossGroupOn crossGroupOn = new CrossGroupOn();
					o_O_o_oOoo__.OOOO_OO._oo.(crossGroupOn, a_2, '\n');
					this.O0o__o0o.0..VGroups.Add(crossGroupOn);
				}
				foreach (string a_3 in array3)
				{
					CrossTotalOn crossTotalOn = new CrossTotalOn(false);
					o_O_o_oOoo__.OOOO_OO._oo.(crossTotalOn, a_3, '\n');
					this.O0o__o0o.0..Totals.Add(crossTotalOn);
				}
			}
		}

		// Token: 0x04001274 RID: 4724
		private CrossTableBuilder <<EMPTY_NAME>>;

		// Token: 0x04001275 RID: 4725
		private string <<EMPTY_NAME>>;

		// Token: 0x04001276 RID: 4726
		private string <<EMPTY_NAME>>;

		// Token: 0x04001277 RID: 4727
		private string <<EMPTY_NAME>>;

		// Token: 0x04001278 RID: 4728
		private string <<EMPTY_NAME>>;

		// Token: 0x04001279 RID: 4729
		private string <<EMPTY_NAME>>;

		// Token: 0x0400127A RID: 4730
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400127B RID: 4731
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400127C RID: 4732
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400127D RID: 4733
		private string <<EMPTY_NAME>>;

		// Token: 0x0400127E RID: 4734
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400127F RID: 4735
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001280 RID: 4736
		private string <<EMPTY_NAME>>;

		// Token: 0x04001281 RID: 4737
		private string <<EMPTY_NAME>>;

		// Token: 0x04001282 RID: 4738
		private int <<EMPTY_NAME>>;

		// Token: 0x04001283 RID: 4739
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001284 RID: 4740
		private bool <<EMPTY_NAME>>;
	}
}
