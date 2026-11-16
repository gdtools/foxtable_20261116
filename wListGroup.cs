using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000217 RID: 535
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0076")]
	public class wListGroup : wElement, o_oOOOoo_O_O
	{
		// Token: 0x060019F1 RID: 6641 RVA: 0x000B90DD File Offset: 0x000B72DD
		internal wListGroup(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.O.__00oOO_o0O0. = new List<wListIem>();
			this.O.__00oOO_o0O0. = A_2;
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x000B90FC File Offset: 0x000B72FC
		private string BaseClass
		{
			get
			{
				string result;
				if (this.Link)
				{
					result = "weui_cells weui_cells_access";
				}
				else
				{
					result = "weui_cells";
				}
				return result;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x000B9120 File Offset: 0x000B7320
		private bool Link
		{
			get
			{
				try
				{
					List<wListIem>.Enumerator enumerator = this.O.__00oOO_o0O0..GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(enumerator.Current.Href, "", true) > 0)
						{
							return true;
						}
					}
				}
				finally
				{
					List<wListIem>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return false;
			}
		}

		/// <summary>
		/// 增加列表项
		/// </summary>
		/// <param name="ID">列表ID</param>
		/// <param name="Content">列表内容</param>
		/// <param name="Description">列表说明</param>
		/// <param name="href">链接地址</param>
		/// <param name="image">图表</param>
		// Token: 0x060019F4 RID: 6644 RVA: 0x000B9188 File Offset: 0x000B7388
		public wListIem Add(string ID, string Content, string Description = "", string href = "", string image = "")
		{
			wListIem wListIem = new wListIem(base.ID, ID, Content, Description, href, image);
			this.O.__00oOO_o0O0..Add(wListIem);
			return wListIem;
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x000B91B8 File Offset: 0x000B73B8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void BuildHtml(StringBuilder sb, wui wui)
		{
			if (Operators.CompareString(this.O.__00oOO_o0O0., "", true) > 0)
			{
				sb.AppendLine("<div class='fox_group'>");
				new wGroupTitle(base.ID, "", this.O.__00oOO_o0O0.).OooO_o0o0O.0_.(sb, wui);
			}
			string text;
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				text = "<div class='" + this.BaseClass + "'";
			}
			else
			{
				text = string.Concat(new string[]
				{
					"<div class='",
					this.BaseClass,
					" ",
					base.Class,
					"'"
				});
			}
			text = string.Concat(new string[]
			{
				text,
				" id='",
				base.ID,
				"' name='",
				base.ID,
				"'"
			});
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				text = text + " " + base.Attribute;
			}
			text += ">";
			sb.AppendLine(text);
			try
			{
				foreach (wListIem wListIem in this.O.__00oOO_o0O0.)
				{
					wListIem.O.__00oOO_o0O0.(sb, wui);
				}
			}
			finally
			{
				List<wListIem>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			sb.AppendLine("</div>");
			if (Operators.CompareString(this.O.__00oOO_o0O0., "", true) > 0)
			{
				sb.AppendLine("</div>");
			}
		}

		// Token: 0x04000AEA RID: 2794
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AEB RID: 2795
		private List<wListIem> <<EMPTY_NAME>>;
	}
}
