using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000222 RID: 546
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0058")]
	public class wMsgPage : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A4A RID: 6730 RVA: 0x000BA7AC File Offset: 0x000B89AC
		internal wMsgPage(string A_0, string A_1, string A_2, string A_3) : base(A_0, A_1)
		{
			this.o0oO0_.o00O0. = "success";
			this.O___0.o_OO. = new List<wButton>();
			this.O___0.o_OO. = new List<string>();
			this.O___0.o_OO. = A_2;
			this.oO0Oo_.o0Oo_0o. = A_3;
		}

		/// <summary>
		/// 添加按钮
		/// </summary>
		/// <param name="ID">按钮ID</param>
		/// <param name="Text">按钮标题</param>
		/// <param name="href">可选参数，字符型，指定单击按钮之后跳转的目标网页的URL</param>
		/// <returns></returns>
		// Token: 0x06001A4B RID: 6731 RVA: 0x000BA7E8 File Offset: 0x000B89E8
		public wButton AddButton(string ID, string Text, string href = "")
		{
			wButton wButton = new wButton(base.ID, ID, Text, "button", href);
			this.O___0.o_OO..Add(wButton);
			return wButton;
		}

		/// <summary>
		/// 添加要在页面底部显示的内容
		/// </summary>
		/// <param name="text">内容</param>
		/// <param name="link">可选参数，指定单击底部内容后跳转的目标网页地址</param>
		// Token: 0x06001A4C RID: 6732 RVA: 0x000BA816 File Offset: 0x000B8A16
		public void AddExtra(string text, string link = "")
		{
			this.O___0.o_OO..Add(text + "\t" + link);
		}

		/// <summary>
		/// 字符型：指定显示的图标，可选值有"success","info","warn",
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x000BA82F File Offset: 0x000B8A2F
		// (set) Token: 0x06001A4E RID: 6734 RVA: 0x000BA837 File Offset: 0x000B8A37
		public string Icon
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

		// Token: 0x06001A4F RID: 6735 RVA: 0x000BA840 File Offset: 0x000B8A40
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void BuildHtml(StringBuilder sb, wui wui)
		{
			string left = this.o0oO0_.o00O0.;
			if (Operators.CompareString(left, "success", true) == 0)
			{
				this.o0oO0_.o00O0. = "weui_icon_success";
			}
			else if (Operators.CompareString(left, "warn", true) == 0)
			{
				this.o0oO0_.o00O0. = "weui_icon_warn";
			}
			else if (Operators.CompareString(left, "info", true) == 0)
			{
				this.o0oO0_.o00O0. = "weui_icon_info";
			}
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				sb.Append("<div class='weui_msg'");
			}
			else
			{
				sb.Append("<div class='weui_msg " + base.Class + "'");
			}
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				sb.Append(" " + base.Attribute);
			}
			sb.AppendLine(">");
			if (Operators.CompareString(this.o0oO0_.o00O0., "", true) > 0)
			{
				sb.AppendLine("<div class='weui_icon_area'>");
				if (this.o0oO0_.o00O0..StartsWith("weui_icon", StringComparison.CurrentCultureIgnoreCase))
				{
					sb.AppendLine("<i class='" + this.o0oO0_.o00O0. + " weui_icon_msg'></i>");
				}
				else
				{
					sb.AppendLine("<img class = 'weui_icon_msg' src='" + this.o0oO0_.o00O0. + "'/>");
				}
				sb.AppendLine("</div>");
			}
			sb.AppendLine(" <div class='weui_text_area'>");
			sb.AppendLine("<h2 class='weui_msg_title'>" + this.O___0.o_OO. + "</h2>");
			sb.AppendLine("<p class='weui_msg_desc'>" + this.oO0Oo_.o0Oo_0o. + "</p>");
			sb.AppendLine("</div>");
			if (this.O___0.o_OO..Count > 0)
			{
				sb.AppendLine(" <div class='weui_opr_area'>");
				sb.AppendLine("<p class='weui_btn_area'>");
				try
				{
					foreach (wButton wButton in this.O___0.o_OO.)
					{
						wButton.o.oOo_oo0__O0_.(sb, wui);
					}
				}
				finally
				{
					List<wButton>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				sb.AppendLine("</p>");
				sb.AppendLine("</div>");
			}
			if (this.O___0.o_OO..Count > 0)
			{
				sb.AppendLine("<div class='weui_extra_area'>");
				try
				{
					foreach (string text in this.O___0.o_OO.)
					{
						string[] array = text.Split(new char[]
						{
							'\t'
						});
						sb.AppendLine(string.Concat(new string[]
						{
							"<a href='",
							array[1],
							"'>",
							array[0],
							"</a>"
						}));
					}
				}
				finally
				{
					List<string>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				sb.AppendLine("</div>");
			}
			sb.AppendLine("</div>");
		}

		// Token: 0x04000B0C RID: 2828
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B0D RID: 2829
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B0E RID: 2830
		public string <<EMPTY_NAME>>;

		// Token: 0x04000B0F RID: 2831
		private List<wButton> <<EMPTY_NAME>>;

		// Token: 0x04000B10 RID: 2832
		private List<string> <<EMPTY_NAME>>;
	}
}
