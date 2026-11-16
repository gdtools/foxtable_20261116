using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000225 RID: 549
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0078")]
	public class wPanel : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A55 RID: 6741 RVA: 0x000BAD19 File Offset: 0x000B8F19
		internal wPanel(string A_0, string A_1, string A_2, string A_3, string A_4, string A_5) : base(A_0, A_1)
		{
			this.Oo.0_O___0. = new List<string>();
			this.ooO_0o0.OooOO. = A_2;
			this.O0_OOooo.0O0O. = A_3;
			this.Oo.0_O___0. = A_4;
			this.O_00O0.00. = A_5;
		}

		/// <summary>
		/// 设置列表的徽章
		/// </summary>
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x000BAD4D File Offset: 0x000B8F4D
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x000BAD55 File Offset: 0x000B8F55
		[oO0oooo("A0142")]
		public string badge
		{
			get
			{
				return this.o.0OOoo.;
			}
			set
			{
				this.o.0OOoo. = value;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x000BAD60 File Offset: 0x000B8F60
		private string BaseClass
		{
			get
			{
				string result;
				if (Operators.CompareString(this.Oo.0_O___0., "", true) > 0 || Operators.CompareString(this.O_00O0.00., "", true) > 0)
				{
					result = "weui_media_box weui_media_text weui_media_appmsg";
				}
				else
				{
					result = "weui_media_box weui_media_text";
				}
				return result;
			}
		}

		/// <summary>
		/// 在列表项的下方添加脚注
		/// </summary>
		/// <param name="text">脚注内容</param>
		/// <param name="link">可选参数，单击脚注要跳转到的目标URL</param>
		// Token: 0x06001A59 RID: 6745 RVA: 0x000BADA4 File Offset: 0x000B8FA4
		public void AddFoot(string text, string link = "")
		{
			this.Oo.0_O___0..Add(text + "\t" + link);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x000BADC0 File Offset: 0x000B8FC0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			string text = Interaction.IIf(Operators.CompareString(this.O_00O0.00., "", true) > 0, "<a", "<div").ToString();
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				text = text + " class='" + this.BaseClass + "'";
			}
			else
			{
				text = string.Concat(new string[]
				{
					text,
					" class='",
					this.BaseClass,
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
			if (Operators.CompareString(this.O_00O0.00., "", true) > 0)
			{
				text = text + " href='" + this.O_00O0.00. + "'";
			}
			text += ">";
			A_0.AppendLine(text);
			if (Operators.CompareString(this.Oo.0_O___0., "", true) > 0)
			{
				A_0.AppendLine(" <div class='weui_media_hd'>");
				A_0.AppendLine("<img class='weui_media_appmsg_thumb' src='" + this.Oo.0_O___0. + "'/>");
				A_0.AppendLine("</div>");
			}
			A_0.AppendLine("<div class='weui_media_bd'>");
			if (Operators.CompareString(this.badge, "", true) > 0)
			{
				if (Operators.CompareString(this.badge.Trim(), "", true) == 0)
				{
					A_0.AppendLine("<h4 class='weui_media_title'>" + this.ooO_0o0.OooOO. + "<span class='weui-badge weui-badge_dot'></span></h4>");
				}
				else
				{
					A_0.AppendLine(string.Concat(new string[]
					{
						"<h4 class='weui_media_title'>",
						this.ooO_0o0.OooOO.,
						"<span class='weui-badge'>",
						this.badge,
						"</span></h4>"
					}));
				}
			}
			else
			{
				A_0.AppendLine("<h4 class='weui_media_title'>" + this.ooO_0o0.OooOO. + "</h4>");
			}
			A_0.AppendLine("<p class='weui_media_desc'>" + this.O0_OOooo.0O0O. + "</p>");
			if (this.Oo.0_O___0..Count > 0)
			{
				A_0.AppendLine(" <ul class='weui_media_info'>");
				try
				{
					foreach (string text2 in this.Oo.0_O___0.)
					{
						string[] array = text2.Split(new char[]
						{
							'\t'
						});
						string text3;
						if (array[0].StartsWith("|"))
						{
							text3 = "<li class='weui_media_info_meta weui_media_info_meta_extra'>";
							array[0] = array[0].Trim(new char[]
							{
								'|'
							});
						}
						else
						{
							text3 = "<li class='weui_media_info_meta'>";
						}
						if (Operators.CompareString(array[1], "", true) > 0)
						{
							text3 = string.Concat(new string[]
							{
								text3,
								"<a href='",
								array[1],
								"'>",
								array[0],
								"</a></li>"
							});
						}
						else
						{
							text3 = text3 + array[0] + "</li>";
						}
						A_0.AppendLine(text3);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				A_0.AppendLine("</ul>");
			}
			A_0.AppendLine("</div>");
			if (Operators.CompareString(this.O_00O0.00., "", true) == 0)
			{
				A_0.AppendLine("</div>");
				return;
			}
			A_0.AppendLine("</a>");
		}

		// Token: 0x04000B14 RID: 2836
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B15 RID: 2837
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B16 RID: 2838
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B17 RID: 2839
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B18 RID: 2840
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B19 RID: 2841
		private List<string> <<EMPTY_NAME>>;
	}
}
