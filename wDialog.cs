using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic;

namespace Foxtable
{
	// Token: 0x0200021B RID: 539
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0080")]
	public class wDialog : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A0F RID: 6671 RVA: 0x000B9908 File Offset: 0x000B7B08
		internal wDialog(string A_0, string A_1, string A_2, string A_3) : base(A_0, A_1)
		{
			this.O___oOO0o.0o. = new List<wButton>();
			this.O___oOO0o.0o. = A_2;
			this.O.o__0. = A_3;
		}

		/// <summary>
		/// 打开网页后是否显示Dialog，默认为False
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x000B992C File Offset: 0x000B7B2C
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x000B9934 File Offset: 0x000B7B34
		public bool Visible
		{
			get
			{
				return this.O___oOO0o.0o.;
			}
			set
			{
				this.O___oOO0o.0o. = value;
			}
		}

		/// <summary>
		/// 添加对话框按钮
		/// </summary>
		/// <param name="ID">按钮ID</param>
		/// <param name="Text">按钮标题</param>
		/// <param name="href">可选参数，字符型，指定单击按钮之后跳转的目标网页的URL</param>
		/// <returns></returns>
		// Token: 0x06001A12 RID: 6674 RVA: 0x000B9940 File Offset: 0x000B7B40
		public wButton AddButton(string ID, string Text, string href = "")
		{
			wButton wButton = new wButton(base.ID, ID, Text, "button", href);
			wButton.o_oOO_o._oOO. = true;
			this.O___oOO0o.0o..Add(wButton);
			return wButton;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x000B9978 File Offset: 0x000B7B78
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			A_0.AppendLine(string.Concat(new string[]
			{
				"<div class='weui_dialog_confirm'",
				Interaction.IIf(this.Visible, "", " style='display: none;'").ToString(),
				" id='",
				base.ID,
				"' name='",
				base.ID,
				"'>"
			}));
			A_0.AppendLine(" <div class='weui_mask'></div>");
			A_0.AppendLine("<div class='weui_dialog'>");
			A_0.AppendLine("<div class='weui_dialog_hd'>");
			A_0.AppendLine("<strong class='weui_dialog_title'>" + this.O___oOO0o.0o. + "</strong>");
			A_0.AppendLine("</div>");
			A_0.AppendLine("<div class='weui_dialog_bd'>" + this.O.o__0. + "</div>");
			A_0.AppendLine("<div class='weui_dialog_ft'>");
			try
			{
				foreach (wButton wButton in this.O___oOO0o.0o.)
				{
					wButton.o.oOo_oo0__O0_.(A_0, A_1);
				}
			}
			finally
			{
				List<wButton>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			A_0.AppendLine("</div>");
			A_0.AppendLine("</div>");
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000AF4 RID: 2804
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AF5 RID: 2805
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AF6 RID: 2806
		private List<wButton> <<EMPTY_NAME>>;

		// Token: 0x04000AF7 RID: 2807
		private bool <<EMPTY_NAME>>;
	}
}
