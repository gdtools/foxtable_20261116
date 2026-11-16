using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000210 RID: 528
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0084")]
	public class wActionMenu : wElement, o_oOOOoo_O_O
	{
		// Token: 0x060019BC RID: 6588 RVA: 0x000B7EE4 File Offset: 0x000B60E4
		internal wActionMenu(string A_0, string A_1, string A_2, string A_3, bool A_4) : base(A_0, A_1)
		{
			this.OO0.__ooO_. = true;
			this.oO.0oO0. = A_2;
			this.oO0._o___O. = A_3;
			this.OO.o_0oOoo0. = A_4;
		}

		/// <summary>
		/// 是否可见
		/// </summary>
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x000B7F0C File Offset: 0x000B610C
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x000B7F14 File Offset: 0x000B6114
		public bool Visible
		{
			get
			{
				return this.OO0.__ooO_.;
			}
			set
			{
				this.OO0.__ooO_. = value;
			}
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x000B7F20 File Offset: 0x000B6120
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			if (this.OO.o_0oOoo0.)
			{
				A_0.AppendLine("</div>");
				A_0.AppendLine("<div class='weui_actionsheet_action'>");
			}
			A_0.Append(string.Concat(new string[]
			{
				"<div id='",
				base.ID,
				"' name='",
				base.ID,
				"' class='weui_actionsheet_cell"
			}));
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				A_0.Append(" " + base.Class);
			}
			A_0.Append("'");
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			if (!this.Visible)
			{
				A_0.Append(" style='display:none;'");
			}
			A_0.Append(">");
			if (Operators.CompareString(this.oO0._o___O., "", true) > 0)
			{
				A_0.Append("<a href='" + this.oO0._o___O. + "'>");
			}
			A_0.Append(this.oO.0oO0.);
			if (Operators.CompareString(this.oO0._o___O., "", true) > 0)
			{
				A_0.Append("</a>");
			}
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000ACD RID: 2765
		private string <<EMPTY_NAME>>;

		// Token: 0x04000ACE RID: 2766
		private string <<EMPTY_NAME>>;

		// Token: 0x04000ACF RID: 2767
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000AD0 RID: 2768
		private bool <<EMPTY_NAME>>;
	}
}
