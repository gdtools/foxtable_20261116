using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000226 RID: 550
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0078")]
	public class wPanelGroup : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A5B RID: 6747 RVA: 0x000BB158 File Offset: 0x000B9358
		internal wPanelGroup(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.OO_00o0O0.0__. = new List<wPanel>();
			this.OO_00o0O0.0__. = A_2;
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x000BB174 File Offset: 0x000B9374
		private string BaseClass
		{
			get
			{
				return "weui_panel weui_panel_access";
			}
		}

		/// <summary>
		/// 底部链接标题
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x000BB17B File Offset: 0x000B937B
		// (set) Token: 0x06001A5E RID: 6750 RVA: 0x000BB183 File Offset: 0x000B9383
		public string GroupFoot
		{
			get
			{
				return this.oOooOO_0OO.o_.;
			}
			set
			{
				this.oOooOO_0OO.o_. = value;
			}
		}

		/// <summary>
		/// 底部连接的目标地址
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001A5F RID: 6751 RVA: 0x000BB18C File Offset: 0x000B938C
		// (set) Token: 0x06001A60 RID: 6752 RVA: 0x000BB194 File Offset: 0x000B9394
		public string GroupHref
		{
			get
			{
				return this.o0o0._OOO_0.;
			}
			set
			{
				this.o0o0._OOO_0. = value;
			}
		}

		/// <summary>
		/// 增加组合列表项
		/// </summary>
		/// <param name="ID">列表ID</param>
		/// <param name="Title">列表标题</param>
		/// <param name="Content">列表内容</param>
		/// <param name="image">可选参数，列表图片</param>
		/// <param name="href">可选参数，单击列表要跳转到的目标URL</param>
		// Token: 0x06001A61 RID: 6753 RVA: 0x000BB1A0 File Offset: 0x000B93A0
		public wPanel Add(string ID, string Title, string Content, string image = "", string href = "")
		{
			wPanel wPanel = new wPanel(base.ID, ID, Title, Content, image, href);
			this.OO_00o0O0.0__..Add(wPanel);
			return wPanel;
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x000BB1D0 File Offset: 0x000B93D0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
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
			A_0.AppendLine(text);
			if (Operators.CompareString(this.OO_00o0O0.0__., "", true) > 0)
			{
				A_0.AppendLine("<div class='weui_panel_hd'>" + this.OO_00o0O0.0__. + "</div>");
			}
			A_0.AppendLine("<div class='weui_panel_bd'>");
			try
			{
				foreach (wPanel wPanel in this.OO_00o0O0.0__.)
				{
					wPanel.Oo.0_O___0.(A_0, A_1);
				}
			}
			finally
			{
				List<wPanel>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (Operators.CompareString(this.GroupFoot, "", true) > 0)
			{
				A_0.AppendLine(string.Concat(new string[]
				{
					"<a class='weui_panel_ft' href='",
					this.o0o0._OOO_0.,
					"'>",
					this.GroupFoot,
					" </a>"
				}));
			}
			A_0.AppendLine("</div>");
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000B1A RID: 2842
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B1B RID: 2843
		private List<wPanel> <<EMPTY_NAME>>;

		// Token: 0x04000B1C RID: 2844
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B1D RID: 2845
		private string <<EMPTY_NAME>>;
	}
}
