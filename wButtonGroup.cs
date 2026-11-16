using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000214 RID: 532
	[oO0oooo("A0008")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wButtonGroup : wElement, o_oOOOoo_O_O
	{
		// Token: 0x060019DD RID: 6621 RVA: 0x000B8A72 File Offset: 0x000B6C72
		internal wButtonGroup(string A_0, string A_1, bool A_2) : base(A_0, A_1)
		{
			this.OO00000O0.0. = new List<wButton>();
			this.OO00000O0.0. = A_2;
		}

		/// <summary>
		/// 增加按钮
		/// </summary>
		/// <param name="ID">按钮ID</param>
		/// <param name="Text">按钮标题</param>
		// Token: 0x060019DE RID: 6622 RVA: 0x000B8A90 File Offset: 0x000B6C90
		public wButton Add(string ID, string Text)
		{
			wButton wButton = new wButton(base.ID, ID, Text);
			this.OO00000O0.0..Add(wButton);
			return wButton;
		}

		/// <summary>
		/// 增加按钮
		/// </summary>
		/// <param name="ID">按钮ID</param>
		/// <param name="Text">按钮标题</param>
		/// <param name="Type">可选参数，字符型，用于指定按钮类型，可用值有"submit"、"reset"、"button"</param>
		// Token: 0x060019DF RID: 6623 RVA: 0x000B8AB8 File Offset: 0x000B6CB8
		public wButton Add(string ID, string Text, string Type)
		{
			wButton wButton = new wButton(base.ID, ID, Text, Type);
			this.OO00000O0.0..Add(wButton);
			return wButton;
		}

		/// <summary>
		/// 增加按钮
		/// </summary>
		/// <param name="ID">按钮ID</param>
		/// <param name="Text">按钮标题</param>
		/// <param name="Type">可选参数，字符型，用于指定按钮类型，可用值有"submit"、"reset"、"button"</param>
		/// <param name="Href">可选参数，字符型，指定单击按钮之后跳转的目标网页的URL</param>
		// Token: 0x060019E0 RID: 6624 RVA: 0x000B8AE4 File Offset: 0x000B6CE4
		public wButton Add(string ID, string Text, string Type, string Href)
		{
			wButton wButton = new wButton(base.ID, ID, Text, Type, Href);
			this.OO00000O0.0..Add(wButton);
			return wButton;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x000B8B10 File Offset: 0x000B6D10
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			if (this.OO00000O0.0.)
			{
				if (Operators.CompareString(base.Class, "", true) == 0)
				{
					A_0.AppendLine("<div class='fox_v_button_group'>");
				}
				else
				{
					A_0.AppendLine("<div class='fox_v_button_group " + base.Class + "'>");
				}
				try
				{
					foreach (wButton wButton in this.OO00000O0.0.)
					{
						A_0.AppendLine("<div class = 'fox_v_button'>");
						wButton.o.oOo_oo0__O0_.(A_0, A_1);
						A_0.AppendLine("</div>");
					}
				}
				finally
				{
					List<wButton>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				A_0.AppendLine("</div>");
				return;
			}
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				A_0.AppendLine("<div class='fox_h_button_group'>");
			}
			else
			{
				A_0.AppendLine("<div class='fox_h_button_group " + base.Class + "'>");
			}
			try
			{
				foreach (wButton wButton2 in this.OO00000O0.0.)
				{
					A_0.AppendLine("<div class = 'fox_h_button'>");
					wButton2.o.oOo_oo0__O0_.(A_0, A_1);
					A_0.AppendLine("</div>");
				}
			}
			finally
			{
				List<wButton>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000AE0 RID: 2784
		private List<wButton> <<EMPTY_NAME>>;

		// Token: 0x04000AE1 RID: 2785
		private bool <<EMPTY_NAME>>;
	}
}
