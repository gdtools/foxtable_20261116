using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000228 RID: 552
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0098")]
	public class wProgress : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A67 RID: 6759 RVA: 0x000BB730 File Offset: 0x000B9930
		internal wProgress(string A_0, string A_1, bool A_2, int A_3) : base(A_0, A_1)
		{
			this.O0.0O0OooO0. = A_2;
			this.O0.0O0OooO0. = A_3;
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x000BB749 File Offset: 0x000B9949
		private string BaseClass
		{
			get
			{
				return "weui_progress";
			}
		}

		/// <summary>
		/// 设置单击取消按钮时执行的js代码
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x000BB750 File Offset: 0x000B9950
		// (set) Token: 0x06001A6A RID: 6762 RVA: 0x000BB758 File Offset: 0x000B9958
		public string CancelCommand
		{
			get
			{
				return this.O0.0O0OooO0.;
			}
			set
			{
				this.O0.0O0OooO0. = value;
			}
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x000BB764 File Offset: 0x000B9964
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			A_0.Append("<div");
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				A_0.Append(" class='" + this.BaseClass + "'");
			}
			else
			{
				A_0.Append(string.Concat(new string[]
				{
					" class='",
					this.BaseClass,
					" ",
					base.Class,
					"'"
				}));
			}
			A_0.Append(string.Concat(new string[]
			{
				" name='",
				base.ID,
				"' id='",
				base.ID,
				"'"
			}));
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			if (!this.O0.0O0OooO0.)
			{
				A_0.Append(" style='display: none;'");
			}
			A_0.AppendLine(">");
			A_0.Append(" <div class='weui_progress_bar'>");
			A_0.AppendLine("<div class='weui_progress_inner_bar' style='width:" + Conversions.ToString(this.O0.0O0OooO0.) + "%;'></div>");
			A_0.AppendLine("</div>");
			if (Operators.CompareString(this.O0.0O0OooO0., "", true) > 0)
			{
				A_0.AppendLine("<a href='javascript:;' class='weui_progress_opr'" + this.O0.0O0OooO0. + ">");
				A_0.AppendLine("<i class='weui_icon_cancel'></i>");
				A_0.Append("</a>");
			}
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000B22 RID: 2850
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B23 RID: 2851
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B24 RID: 2852
		private int <<EMPTY_NAME>>;
	}
}
