using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200022E RID: 558
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0081")]
	public class wTabbar : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A98 RID: 6808 RVA: 0x000BC635 File Offset: 0x000BA835
		internal wTabbar(string A_0, string A_1, int A_2) : base(A_0, A_1)
		{
			this.o0O.00_o_0_o0. = new List<wTabButton>();
			this.o0OO0.oo0OO. = new List<wPage>();
			this.o0OO0.oo0OO. = A_2;
		}

		/// <summary>
		/// 增加页面
		/// </summary>
		/// <param name="id">页面ID</param>
		/// <param name="text">页面按钮标题</param>
		/// <param name="image">可选参数，页面按钮图片</param>
		/// <returns></returns>
		// Token: 0x06001A99 RID: 6809 RVA: 0x000BC65C File Offset: 0x000BA85C
		public wPage AddPage(string id, string text, string image = "")
		{
			wTabButton item = new wTabButton(base.ID, id + "_btn", text, id, image, "");
			this.o0O.00_o_0_o0..Add(item);
			wPage wPage = new wPage(base.ID, id, this.o0OO0.oo0OO..Count == 0);
			this.o0OO0.oo0OO..Add(wPage);
			return wPage;
		}

		/// <summary>
		/// 添加按钮
		/// </summary>
		/// <param name="id">按钮ID</param>
		/// <param name="text">按钮标题</param>
		/// <param name="image">按钮图片</param>
		/// <param name="href">可选参数，指定单击按钮之后跳转的目标网页的URL</param>
		/// <returns></returns>
		// Token: 0x06001A9A RID: 6810 RVA: 0x000BC6BC File Offset: 0x000BA8BC
		public wTabButton AddButton(string id, string text, string image = "", string href = "")
		{
			wTabButton wTabButton = new wTabButton(base.ID, id, text, "", image, href);
			this.o0O.00_o_0_o0..Add(wTabButton);
			return wTabButton;
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x000BC6EC File Offset: 0x000BA8EC
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
			A_0.Append(" class='weui_tab");
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				A_0.Append(" " + base.Class);
			}
			A_0.Append("'");
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			A_0.Append(">");
			if (this.o0OO0.oo0OO. == 0)
			{
				A_0.AppendLine("<div class='weui_tab_bd' id='" + base.ID + "_pages'>");
				try
				{
					foreach (wPage wPage in this.o0OO0.oo0OO.)
					{
						wPage.o__o.OOoO_.(A_0, A_1);
					}
				}
				finally
				{
					List<wPage>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				A_0.AppendLine("</div>");
				A_0.AppendLine(" <div class='weui_tabbar'>");
			}
			else
			{
				A_0.AppendLine("<div class='weui_navbar'>");
			}
			bool flag = true;
			try
			{
				foreach (wTabButton wTabButton in this.o0O.00_o_0_o0.)
				{
					if (flag)
					{
						wTabButton.o0OO0.oo0OO. = true;
						flag = false;
					}
					wTabButton.o0OO0.oo0OO.(A_0, A_1);
				}
			}
			finally
			{
				List<wTabButton>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			A_0.AppendLine("</div>");
			if (this.o0OO0.oo0OO. == 1)
			{
				A_0.AppendLine("<div class='weui_tab_bd' id='" + base.ID + "_pages'>");
				try
				{
					foreach (wPage wPage2 in this.o0OO0.oo0OO.)
					{
						wPage2.o__o.OOoO_.(A_0, A_1);
					}
				}
				finally
				{
					List<wPage>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				A_0.AppendLine("</div>");
			}
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000B38 RID: 2872
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B39 RID: 2873
		private List<wTabButton> <<EMPTY_NAME>>;

		// Token: 0x04000B3A RID: 2874
		private List<wPage> <<EMPTY_NAME>>;
	}
}
