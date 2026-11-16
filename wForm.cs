using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200021C RID: 540
	[oO0oooo("A0007")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wForm : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A14 RID: 6676 RVA: 0x000B9AC4 File Offset: 0x000B7CC4
		internal wForm(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.O_0.o0o_. = "post";
			this.o.O___oOOOOoo. = A_2;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x000B9AE0 File Offset: 0x000B7CE0
		internal wForm(string A_0, string A_1, string A_2, string A_3) : base(A_0, A_1)
		{
			this.O_0.o0o_. = "post";
			this.o.O___oOOOOoo. = A_2;
			this.O_0.o0o_. = A_3;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x000B9B04 File Offset: 0x000B7D04
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			A_0.Append("<form method='" + this.O_0.o0o_. + "' enctype='multipart/form-data'");
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				A_0.Append(" class='" + base.Class + "'");
			}
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			A_0.AppendLine(string.Concat(new string[]
			{
				" id='",
				base.ID,
				"' name ='",
				base.ID,
				"' action ='",
				this.o.O___oOOOOoo.,
				"'>"
			}));
			try
			{
				foreach (wElement wElement in A_1.o0_._00..Values)
				{
					if (Operators.CompareString(wElement.PID, base.ID, true) == 0)
					{
						((o_oOOOoo_O_O)wElement).OOO.__O_oO_.(A_0, A_1);
					}
				}
			}
			finally
			{
				Dictionary<string, wElement>.ValueCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			A_0.AppendLine("</form>");
		}

		// Token: 0x04000AF8 RID: 2808
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AF9 RID: 2809
		private string <<EMPTY_NAME>>;
	}
}
