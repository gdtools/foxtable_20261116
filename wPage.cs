using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000223 RID: 547
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wPage : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A50 RID: 6736 RVA: 0x000BAB1C File Offset: 0x000B8D1C
		internal wPage(string A_0, string A_1) : base(A_0, A_1)
		{
			this.o__o.OOoO_. = true;
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x000BAB2D File Offset: 0x000B8D2D
		internal wPage(string A_0, string A_1, bool A_2) : base(A_0, A_1)
		{
			this.o__o.OOoO_. = true;
			this.o__o.OOoO_. = A_2;
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x000BAB48 File Offset: 0x000B8D48
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			A_0.Append(string.Concat(new string[]
			{
				"<div  id='",
				base.ID,
				"' name='",
				base.ID,
				"'"
			}));
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				A_0.Append(" class='fox_page" + base.Class + "'");
			}
			else
			{
				A_0.Append(" class='fox_page'");
			}
			if (!this.o__o.OOoO_.)
			{
				A_0.Append(" style='display:none'");
			}
			A_0.AppendLine(">");
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
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000B11 RID: 2833
		private bool <<EMPTY_NAME>>;
	}
}
