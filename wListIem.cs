using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000216 RID: 534
	[oO0oooo("A0076")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wListIem : wElement, o_oOOOoo_O_O
	{
		// Token: 0x060019E4 RID: 6628 RVA: 0x000B8DEF File Offset: 0x000B6FEF
		internal wListIem(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5) : base(A_0, A_1)
		{
			this.oO0Oo_.o0Oo_0o. = A_2;
			this.o0oO0_.o00O0. = A_3;
			this.O_00o.o_0. = A_4;
			this.O___0.o_OO. = A_5;
		}

		/// <summary>
		/// 列表内容
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x000B8E18 File Offset: 0x000B7018
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x000B8E20 File Offset: 0x000B7020
		public string Content
		{
			get
			{
				return this.oO0Oo_.o0Oo_0o.;
			}
			set
			{
				this.oO0Oo_.o0Oo_0o. = value;
			}
		}

		/// <summary>
		/// 列表说明
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x000B8E29 File Offset: 0x000B7029
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x000B8E31 File Offset: 0x000B7031
		public string SubContent
		{
			get
			{
				return this.o0oO0_.o00O0.;
			}
			set
			{
				this.o0oO0_.o00O0. = value;
			}
		}

		/// <summary>
		/// 超链接地址
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x000B8E3A File Offset: 0x000B703A
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x000B8E42 File Offset: 0x000B7042
		public string Href
		{
			get
			{
				return this.O_00o.o_0.;
			}
			set
			{
				this.O_00o.o_0. = value;
			}
		}

		/// <summary>
		/// 列表图片，含路径
		/// </summary>
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x000B8E4B File Offset: 0x000B704B
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x000B8E53 File Offset: 0x000B7053
		public string Image
		{
			get
			{
				return this.O___0.o_OO.;
			}
			set
			{
				this.O___0.o_OO. = value;
			}
		}

		/// <summary>
		/// 徽章
		/// </summary>
		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x000B8E5C File Offset: 0x000B705C
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x000B8E64 File Offset: 0x000B7064
		[oO0oooo("A0141")]
		public string badge
		{
			get
			{
				return this.o.0oOOo.;
			}
			set
			{
				this.o.0oOOo. = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x000B8E6D File Offset: 0x000B706D
		private string baseClass
		{
			get
			{
				return "weui_cell";
			}
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x000B8E74 File Offset: 0x000B7074
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			string text = Interaction.IIf(Operators.CompareString(this.Href, "", true) > 0, "<a", "<div").ToString();
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				text = text + " class='" + this.baseClass + "'";
			}
			else
			{
				text = string.Concat(new string[]
				{
					text,
					" class='",
					this.baseClass,
					" ",
					base.Class,
					"'"
				});
			}
			text = string.Concat(new string[]
			{
				text,
				" name='",
				base.ID,
				"' id='",
				base.ID,
				"'"
			});
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				text = text + " " + base.Attribute;
			}
			if (Operators.CompareString(this.Href, "", true) > 0)
			{
				text = text + " href='" + this.Href + "'";
			}
			text += ">";
			A_0.AppendLine(text);
			if (Operators.CompareString(this.Image, "", true) > 0)
			{
				A_0.AppendLine("<div class='weui_cell_hd'><img src='" + this.Image + "' style='width:20px;margin-right:5px;display:block'/></div>");
			}
			if (Operators.CompareString(this.Content, "", true) > 0)
			{
				A_0.AppendLine("<div class='weui_cell_bd weui_cell_primary'>");
				A_0.AppendLine("<span>" + this.Content + "</span>");
				if (Operators.CompareString(this.badge, "", true) > 0)
				{
					if (Operators.CompareString(this.badge.Trim(), "", true) > 0)
					{
						A_0.AppendLine("<span class='weui-badge'>" + this.badge + "</span>");
					}
					else
					{
						A_0.AppendLine("<span class='weui-badge weui-badge_dot'></span>");
					}
				}
				A_0.AppendLine("</div>");
			}
			if (Operators.CompareString(this.SubContent, "", true) > 0)
			{
				A_0.AppendLine("  <div class='weui_cell_ft'>" + this.SubContent + "</div>");
			}
			if (Operators.CompareString(this.Href, "", true) == 0)
			{
				A_0.AppendLine("</div>");
				return;
			}
			A_0.AppendLine("</a>");
		}

		// Token: 0x04000AE5 RID: 2789
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AE6 RID: 2790
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AE7 RID: 2791
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AE8 RID: 2792
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AE9 RID: 2793
		private string <<EMPTY_NAME>>;
	}
}
