using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200021D RID: 541
	[oO0oooo("A0077")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wGrid : wElement, o_oOOOoo_O_O
	{
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">网格ID</param>
		// Token: 0x06001A17 RID: 6679 RVA: 0x000B9C48 File Offset: 0x000B7E48
		public wGrid(string A_0, string A_1) : base(A_0, A_1)
		{
			this.OooO_o0o0O.0_. = new List<wGridCell>();
		}

		/// <summary>
		/// 添加单元格
		/// </summary>
		/// <param name="ID">单元格ID</param>
		/// <param name="Title">单元格文本</param>
		/// <param name="Image">单元格图片文件</param>
		/// <param name="href">可选参数，页面链接地址</param>
		// Token: 0x06001A18 RID: 6680 RVA: 0x000B9C60 File Offset: 0x000B7E60
		public wGridCell Add(string ID, string Title, string Image, string href)
		{
			wGridCell wGridCell = new wGridCell(base.ID, ID, Title, Image, href);
			this.OooO_o0o0O.0_..Add(wGridCell);
			return wGridCell;
		}

		/// <summary>
		/// 添加单元格
		/// </summary>
		/// <param name="ID">单元格ID</param>
		/// <param name="Title">单元格文本</param>
		/// <param name="Image">单元格图片文件</param>
		// Token: 0x06001A19 RID: 6681 RVA: 0x000B9C8B File Offset: 0x000B7E8B
		public wGridCell Add(string ID, string Title, string Image)
		{
			return this.Add(ID, Title, Image, "");
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x000B9C9C File Offset: 0x000B7E9C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				A_0.Append("<div class='weui_grids " + base.Class + "'");
			}
			else
			{
				A_0.Append("<div class='weui_grids'");
			}
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			A_0.AppendLine(">");
			try
			{
				foreach (wGridCell wGridCell in this.OooO_o0o0O.0_.)
				{
					wGridCell.OooO_o0o0O.0_.(A_0, A_1);
				}
			}
			finally
			{
				List<wGridCell>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000AFA RID: 2810
		private List<wGridCell> <<EMPTY_NAME>>;
	}
}
