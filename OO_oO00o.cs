using System;
using System.Net;
using Foxtable.XLS;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001FE RID: 510
	internal class OO_oO00o
	{
		// Token: 0x0600198D RID: 6541 RVA: 0x000B66F2 File Offset: 0x000B48F2
		internal OO_oO00o(HttpListenerResponse A_0, Book A_1)
		{
			this.OO.oO00. = true;
			this.O_0._00_. = A_0;
			this.OO.oO00. = A_1;
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x000B6710 File Offset: 0x000B4910
		internal void <<EMPTY_NAME>>(object A_0)
		{
			string text = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(10) + ".htm";
			string text2 = "";
			try
			{
				if (!OO_00oOO.FileSys.DirectoryExists(O_O0OO.OoO__.0oO0oo.()))
				{
					OO_00oOO.FileSys.CreateDirectory(O_O0OO.OoO__.0oO0oo.());
				}
				if (this.OO.oO00.)
				{
					if (this.O_0._00_. == null || this.O_0._00_..Length == 0)
					{
						this.OO.oO00..Build(new int[0]);
					}
					else
					{
						this.OO.oO00..Build(this.O_0._00_.);
					}
				}
				this.OO.oO00..SaveToHTML(text);
			}
			catch (Exception ex)
			{
				text2 = ex.Message;
			}
			if (OO_00oOO.FileSys.FileExists(text) && Operators.CompareString(text2, "", true) == 0)
			{
				new o_o0O_Ooo__O(text, this.O_0._00_.).ooO0O.0.(null);
				return;
			}
			new oOo0_o0Oo_00(text2, this.O_0._00_., "utf-8").Oo000.o00.(null);
		}

		// Token: 0x04000A87 RID: 2695
		private Book <<EMPTY_NAME>>;

		// Token: 0x04000A88 RID: 2696
		private HttpListenerResponse <<EMPTY_NAME>>;

		// Token: 0x04000A89 RID: 2697
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000A8A RID: 2698
		internal int[] <<EMPTY_NAME>>;
	}
}
