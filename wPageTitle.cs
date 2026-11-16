using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000224 RID: 548
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0075")]
	public class wPageTitle : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A53 RID: 6739 RVA: 0x000BAC8C File Offset: 0x000B8E8C
		internal wPageTitle(string A_0, string A_1, string A_2, string A_3) : base(A_0, A_1)
		{
			this.o__o.OOoO_. = A_2;
			this.OO0_OO0o0_._. = A_3;
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x000BACA8 File Offset: 0x000B8EA8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			A_0.AppendLine("<div class='fox_page_header'>");
			A_0.AppendLine("<h1 class='fox_page_title'>" + this.o__o.OOoO_. + "</h1>");
			if (Operators.CompareString(this.OO0_OO0o0_._., "", true) > 0)
			{
				A_0.AppendLine("<p class='fox_page_subtitle'>" + this.OO0_OO0o0_._. + "</p>");
			}
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000B12 RID: 2834
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B13 RID: 2835
		private string <<EMPTY_NAME>>;
	}
}
