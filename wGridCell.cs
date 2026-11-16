using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000215 RID: 533
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wGridCell : wElement, o_oOOOoo_O_O
	{
		// Token: 0x060019E2 RID: 6626 RVA: 0x000B8C74 File Offset: 0x000B6E74
		internal wGridCell(string A_0, string A_1, string A_2, string A_3, string A_4) : base(A_0, A_1)
		{
			this.OooO_o0o0O.0_. = A_2;
			this.oOo.Oo_00O. = A_3;
			this.O0.O_oO0. = A_4;
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x000B8C98 File Offset: 0x000B6E98
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			if (Operators.CompareString(this.O0.O_oO0., "", true) > 0)
			{
				A_0.Append(" <a href='" + this.O0.O_oO0. + "'");
			}
			else
			{
				A_0.Append(" <a");
			}
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				A_0.Append(" class='weui_grid'");
			}
			else
			{
				A_0.Append(" class='weui_grid " + base.Class + "'");
			}
			A_0.Append(string.Concat(new string[]
			{
				" id='",
				base.ID,
				"' name='",
				base.ID,
				"'"
			}));
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			A_0.AppendLine(">");
			A_0.AppendLine("<div class='weui_grid_icon'>");
			A_0.AppendLine(" <i class='fox_grid_icon' style='background-image:url(" + this.oOo.Oo_00O. + ")'></i>");
			A_0.AppendLine("</div>");
			A_0.AppendLine("<p class='weui_grid_label'>" + this.OooO_o0o0O.0_. + "</p>");
			A_0.AppendLine("</a>");
		}

		// Token: 0x04000AE2 RID: 2786
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AE3 RID: 2787
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AE4 RID: 2788
		private string <<EMPTY_NAME>>;
	}
}
