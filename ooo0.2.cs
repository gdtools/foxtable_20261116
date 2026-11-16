using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Foxtable
{
	// Token: 0x020001C7 RID: 455
	internal class ooo0 : IMBuddy
	{
		// Token: 0x060015EB RID: 5611 RVA: 0x0009984F File Offset: 0x00097A4F
		internal ooo0(string A_0, IPEndPoint A_1, string A_2, string A_3) : base(A_0, A_1, A_2)
		{
			this.O_oO._O. = A_0;
			this.o.OOOOo. = A_2;
			this.OO0_o.Oo0O. = A_3;
			this.O_oO._O. = DateTime.Now;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x0009987B File Offset: 0x00097A7B
		internal string <<EMPTY_NAME>>()
		{
			return this.O_oO._O.;
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00099883 File Offset: 0x00097A83
		public string <<EMPTY_NAME>>()
		{
			return this.o.OOOOo.;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x0009988B File Offset: 0x00097A8B
		public List<IMBuddy> <<EMPTY_NAME>>()
		{
			return this.O_oO._O.;
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00099893 File Offset: 0x00097A93
		public void <<EMPTY_NAME>>(List<IMBuddy> A_0)
		{
			this.O_oO._O. = A_0;
			this.O_oO._O. = true;
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x000998A3 File Offset: 0x00097AA3
		internal string <<EMPTY_NAME>>()
		{
			return this.OO0_o.Oo0O.;
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x000998AC File Offset: 0x00097AAC
		internal string <<EMPTY_NAME>>()
		{
			if (this.O_oO._O.)
			{
				this.O_oO._O. = false;
				StringBuilder stringBuilder = new StringBuilder();
				try
				{
					foreach (IMBuddy imbuddy in this.O_oO._O.)
					{
						stringBuilder.Append(imbuddy.Name + ",");
					}
				}
				finally
				{
					List<IMBuddy>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (stringBuilder.Length > 0)
				{
					this.O.o00o0OO_. = stringBuilder.ToString().Trim(new char[]
					{
						','
					});
				}
				else
				{
					this.O.o00o0OO_. = "";
				}
			}
			return this.O.o00o0OO_.;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00099960 File Offset: 0x00097B60
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.O.o00o0OO_. = A_0;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00099969 File Offset: 0x00097B69
		internal DateTime <<EMPTY_NAME>>()
		{
			return this.O_oO._O.;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00099971 File Offset: 0x00097B71
		internal void <<EMPTY_NAME>>(DateTime A_0)
		{
			this.O_oO._O. = A_0;
		}

		// Token: 0x0400089E RID: 2206
		private string <<EMPTY_NAME>>;

		// Token: 0x0400089F RID: 2207
		private string <<EMPTY_NAME>>;

		// Token: 0x040008A0 RID: 2208
		private List<IMBuddy> <<EMPTY_NAME>>;

		// Token: 0x040008A1 RID: 2209
		private string <<EMPTY_NAME>>;

		// Token: 0x040008A2 RID: 2210
		private string <<EMPTY_NAME>>;

		// Token: 0x040008A3 RID: 2211
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x040008A4 RID: 2212
		private bool <<EMPTY_NAME>>;
	}
}
