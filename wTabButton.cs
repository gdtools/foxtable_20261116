using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200022F RID: 559
	[oO0oooo("A0081")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wTabButton : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A9C RID: 6812 RVA: 0x000BC91C File Offset: 0x000BAB1C
		internal wTabButton(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5) : base(A_0, A_1)
		{
			this.o__O0.oO_oo0. = A_2;
			this.o0OO0.oo0OO. = A_3;
			this.OoOoO0oO0o_.00. = A_4;
			this.OO_.o0O. = A_5;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x000BC948 File Offset: 0x000BAB48
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			if (Operators.CompareString(this.OoOoO0oO0o_.00., "", true) == 0)
			{
				A_0.Append(string.Concat(new string[]
				{
					"<div id='",
					base.ID,
					"' name='",
					base.ID,
					"' class='weui_navbar_item"
				}));
				if (this.o0OO0.oo0OO.)
				{
					A_0.Append(" weui_bar_item_on");
				}
				if (Operators.CompareString(base.Class, "", true) > 0)
				{
					A_0.Append(" " + base.Class);
				}
				A_0.Append("'");
				if (Operators.CompareString(base.Attribute, "", true) > 0)
				{
					A_0.Append(" " + base.Attribute);
				}
				if (Operators.CompareString(this.o0OO0.oo0OO., "", true) > 0)
				{
					A_0.Append(" data-tab-page='" + this.o0OO0.oo0OO. + "'");
					A_0.Append(" data-tab='" + base.PID + "'>");
				}
				else
				{
					A_0.AppendLine(">");
				}
				A_0.AppendLine("<p class='weui_tabbar_label'>" + this.o__O0.oO_oo0. + "</p>");
				A_0.AppendLine("</div>");
				return;
			}
			if (Operators.CompareString(this.OO_.o0O., "", true) == 0)
			{
				this.OO_.o0O. = "javascript:;";
			}
			A_0.Append(string.Concat(new string[]
			{
				"<a  id='",
				base.ID,
				"' name='",
				base.ID,
				"' href='",
				this.OO_.o0O.,
				"' class='weui_tabbar_item"
			}));
			if (this.o0OO0.oo0OO.)
			{
				A_0.Append(" weui_bar_item_on");
			}
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				A_0.Append(" " + base.Class);
			}
			A_0.Append("'");
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			if (Operators.CompareString(this.o0OO0.oo0OO., "", true) > 0)
			{
				A_0.Append(" data-tab-page='" + this.o0OO0.oo0OO. + "'");
				A_0.Append(" data-tab='" + base.PID + "'>");
			}
			else
			{
				A_0.AppendLine(">");
			}
			A_0.AppendLine("<div class='weui_tabbar_icon'>");
			A_0.AppendLine("<img src='" + this.OoOoO0oO0o_.00. + "'>");
			A_0.AppendLine(" </div>");
			A_0.AppendLine("<p class='weui_tabbar_label'>" + this.o__O0.oO_oo0. + "</p>");
			A_0.AppendLine("</a>");
		}

		// Token: 0x04000B3B RID: 2875
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B3C RID: 2876
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B3D RID: 2877
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B3E RID: 2878
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B3F RID: 2879
		internal bool <<EMPTY_NAME>>;
	}
}
