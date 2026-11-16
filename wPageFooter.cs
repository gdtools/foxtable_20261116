using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200020F RID: 527
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0086")]
	public class wPageFooter : wElement, o_oOOOoo_O_O
	{
		// Token: 0x060019B9 RID: 6585 RVA: 0x000B7CDE File Offset: 0x000B5EDE
		internal wPageFooter(string A_0, string A_1, string A_2, int A_3) : base(A_0, A_1)
		{
			this.o__o.OOoO_. = new List<string>();
			this.o__o.OOoO_. = A_2;
			this.o__o.OOoO_. = A_3;
		}

		/// <summary>
		/// 增加链接
		/// </summary>
		/// <param name="Text">链接的文本内容</param>
		/// <param name="Href">目标URL</param>
		/// <param name="Attribute">可选参数，用于设置链接属性</param>
		// Token: 0x060019BA RID: 6586 RVA: 0x000B7D04 File Offset: 0x000B5F04
		public void AddLink(string Text, string Href, string Attribute = "")
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (Operators.CompareString(Attribute, "", true) > 0)
			{
				Attribute = " " + Attribute;
			}
			stringBuilder.AppendLine(string.Concat(new string[]
			{
				" <a href='",
				Href,
				"' class='weui-footer__link'",
				Attribute,
				">",
				Text,
				"</a>"
			}));
			this.o__o.OOoO_..Add(stringBuilder.ToString());
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x000B7D84 File Offset: 0x000B5F84
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			A_0.Append("<div class='weui-footer");
			if (this.o__o.OOoO_. == 1)
			{
				A_0.Append(" weui-footer_fixed-bottom");
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
			A_0.AppendLine(">");
			if (this.o__o.OOoO_..Count > 0)
			{
				A_0.AppendLine("<p class='weui-footer__links'" + base.Attribute + ">");
				try
				{
					foreach (string value in this.o__o.OOoO_.)
					{
						A_0.Append(value);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				A_0.AppendLine("</p>");
			}
			if (Operators.CompareString(this.o__o.OOoO_., "", true) > 0)
			{
				A_0.Append("<p class='weui-footer__text'>");
				A_0.Append(this.o__o.OOoO_.);
				A_0.AppendLine("</p>");
			}
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000ACA RID: 2762
		private string <<EMPTY_NAME>>;

		// Token: 0x04000ACB RID: 2763
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000ACC RID: 2764
		private int <<EMPTY_NAME>>;
	}
}
