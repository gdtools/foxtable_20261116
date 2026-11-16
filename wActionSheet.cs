using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000211 RID: 529
	[oO0oooo("A0084")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wActionSheet : wElement, o_oOOOoo_O_O
	{
		// Token: 0x060019C0 RID: 6592 RVA: 0x000B8074 File Offset: 0x000B6274
		internal wActionSheet(string A_0, string A_1) : base(A_0, A_1)
		{
			this.oO.0oO0. = new List<wActionMenu>();
		}

		/// <summary>
		/// 增加菜单项
		/// </summary>
		/// <param name="id">菜单项的ID</param>
		/// <param name="text">菜单项的文本内容</param>
		/// <param name="href">可选参数，单击菜单项后要跳转到的目标URL</param>
		/// <param name="separator">可选参数，逻辑型，是否在此菜单项之前显示一个分割条</param>
		/// <returns></returns>
		// Token: 0x060019C1 RID: 6593 RVA: 0x000B808C File Offset: 0x000B628C
		public wActionMenu Add(string id, string text, string href = "", bool separator = false)
		{
			wActionMenu wActionMenu = new wActionMenu(base.ID, id, text, href, separator);
			this.oO.0oO0..Add(wActionMenu);
			return wActionMenu;
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x000B80B8 File Offset: 0x000B62B8
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
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				A_0.Append(" class='fox_actionsheet" + base.Class + "'");
			}
			else
			{
				A_0.Append(" class='fox_actionsheet'");
			}
			A_0.AppendLine(">");
			A_0.AppendLine("<div class='weui_mask_transition fox_mask_transition' style='display:none' id='" + base.ID + "_mask'></div>");
			A_0.AppendLine("<div class='weui_actionsheet' id='" + base.ID + "_sheet'>");
			A_0.AppendLine("<div class='weui_actionsheet_menu'>");
			try
			{
				foreach (wActionMenu wActionMenu in this.oO.0oO0.)
				{
					wActionMenu.OO.o_0oOoo0.(A_0, A_1);
				}
			}
			finally
			{
				List<wActionMenu>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			A_0.AppendLine("</div>");
			A_0.AppendLine("</div>");
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000AD1 RID: 2769
		private List<wActionMenu> <<EMPTY_NAME>>;
	}
}
