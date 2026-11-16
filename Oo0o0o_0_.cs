using System;
using System.Net;
using Foxtable.XLS;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020001FF RID: 511
	internal class Oo0o0o_0_
	{
		// Token: 0x0600198F RID: 6543 RVA: 0x000B6814 File Offset: 0x000B4A14
		internal Oo0o0o_0_(HttpListenerResponse A_0, Book A_1)
		{
			this.O_0._00_. = true;
			this.O_0._00_. = A_0;
			this.O_0._00_. = A_1;
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x000B6834 File Offset: 0x000B4A34
		internal void <<EMPTY_NAME>>(object A_0)
		{
			string text = O_O0OO.OoO__.0oO0oo.() + OoOo0O.OO_o.0o_O.(10) + ".pdf";
			string text2 = "";
			try
			{
				if (!OO_00oOO.FileSys.DirectoryExists(O_O0OO.OoO__.0oO0oo.()))
				{
					OO_00oOO.FileSys.CreateDirectory(O_O0OO.OoO__.0oO0oo.());
				}
				if (this.O_0._00_.)
				{
					if (this.O_0._00_. == null || this.O_0._00_..Length == 0)
					{
						this.O_0._00_..Build(new int[0]);
					}
					else
					{
						this.O_0._00_..Build(this.O_0._00_.);
					}
				}
				this.O_0._00_..SaveToPdf(text);
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

		// Token: 0x04000A8B RID: 2699
		private Book <<EMPTY_NAME>>;

		// Token: 0x04000A8C RID: 2700
		private HttpListenerResponse <<EMPTY_NAME>>;

		// Token: 0x04000A8D RID: 2701
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000A8E RID: 2702
		internal int[] <<EMPTY_NAME>>;
	}
}
