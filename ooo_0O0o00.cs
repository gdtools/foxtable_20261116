using System;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000203 RID: 515
	internal class ooo_0O0o00
	{
		// Token: 0x06001997 RID: 6551 RVA: 0x000B6F3C File Offset: 0x000B513C
		public ooo_0O0o00(PrintDoc A_0, HttpListenerResponse A_1)
		{
			this.oO0o0o._0. = A_0;
			this.oO0o0o._0. = A_1;
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x000B6F54 File Offset: 0x000B5154
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
				this.oO0o0o._0..SavePDF(text, false);
			}
			catch (Exception ex)
			{
				text2 = ex.Message;
			}
			if (OO_00oOO.FileSys.FileExists(text) && Operators.CompareString(text2, "", true) == 0)
			{
				new o_o0O_Ooo__O(text, this.oO0o0o._0.).ooO0O.0.(null);
				return;
			}
			new oOo0_o0Oo_00(text2, this.oO0o0o._0., "utf-8").Oo000.o00.(null);
		}

		// Token: 0x04000A9E RID: 2718
		private PrintDoc <<EMPTY_NAME>>;

		// Token: 0x04000A9F RID: 2719
		private HttpListenerResponse <<EMPTY_NAME>>;
	}
}
