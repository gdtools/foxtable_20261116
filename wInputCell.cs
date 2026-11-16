using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200022A RID: 554
	[oO0oooo("A0051")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wInputCell : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A71 RID: 6769 RVA: 0x000BBAFC File Offset: 0x000B9CFC
		internal wInputCell(string A_0, string A_1, int A_2) : base(A_0, A_1)
		{
			this.OoOO0._00O0__o. = new List<wElement>[3];
			this.OoOO0._00O0__o. = 1;
			this.OO_.oO_OO0. = A_2;
			this.OoOO0._00O0__o.[0] = new List<wElement>();
			this.OoOO0._00O0__o.[1] = new List<wElement>();
			this.OoOO0._00O0__o.[2] = new List<wElement>();
			if (this.OO_.oO_OO0. == 2)
			{
				this.AddImage(A_1 + "_wicon", "weui_icon_warn", 2);
			}
		}

		/// <summary>
		/// 增加输入框
		/// </summary>
		/// <param name="id">输入框ID</param>
		/// <param name="type">输入框类型 
		/// 文本为"text"
		/// 密码为"password"
		/// 数值为"number"
		/// 日期为"date"
		/// 时间为"time"
		/// 日期时间为"datetime-local"</param>
		/// <param name="position">输入框位置，0靠左显示，1居中显示，2靠右显示</param>
		// Token: 0x06001A72 RID: 6770 RVA: 0x000BBB74 File Offset: 0x000B9D74
		public wInput AddInput(string id, string type, int position)
		{
			wInput result;
			if (position >= 0 && position <= 2)
			{
				wInput wInput = new wInput(base.ID, id, "", type);
				this.OoOO0._00O0__o.[position].Add(wInput);
				result = wInput;
			}
			else
			{
				result = null;
			}
			return result;
		}

		/// <summary>
		/// 增加列表框
		/// </summary>
		/// <param name="id">列表输入框ID</param>
		/// <param name="options">列表项目，用符号"|"隔开，例如"大专|本科|硕士|博士"</param>
		/// <param name="position">标签位置，0靠左显示，1居中显示，2靠右显示</param>
		// Token: 0x06001A73 RID: 6771 RVA: 0x000BBBB4 File Offset: 0x000B9DB4
		public wSelect AddSelect(string id, string options, int position)
		{
			wSelect result;
			if (position >= 0 && position <= 2)
			{
				wSelect wSelect = new wSelect(base.ID, id, "", options);
				this.OoOO0._00O0__o.[position].Add(wSelect);
				this.OoOO0._00O0__o. = true;
				if (position == 0)
				{
					this.OO_.oO_OO0. = true;
				}
				result = wSelect;
			}
			else
			{
				result = null;
			}
			return result;
		}

		/// <summary>
		/// 增加标签
		/// </summary>
		/// <param name="id">标签ID</param>
		/// <param name="text">标签内容</param>
		/// <param name="position">标签位置，0靠左显示，1居中显示，2靠右显示</param>
		// Token: 0x06001A74 RID: 6772 RVA: 0x000BBC04 File Offset: 0x000B9E04
		public wLabel AddLabel(string id, string text, int position)
		{
			wLabel result;
			if (position >= 0 && position <= 2)
			{
				wLabel wLabel = new wLabel(base.ID, id, text);
				this.OoOO0._00O0__o.[position].Add(wLabel);
				result = wLabel;
			}
			else
			{
				result = null;
			}
			return result;
		}

		/// <summary>
		/// 增加图片
		/// </summary>
		/// <param name="id">图片ID</param>
		/// <param name="image">图片文件，包括路径</param>
		/// <param name="position">图片位置，0靠左显示，1居中显示，2靠右显示</param>
		// Token: 0x06001A75 RID: 6773 RVA: 0x000BBC3C File Offset: 0x000B9E3C
		public wImage AddImage(string id, string image, int position)
		{
			wImage result;
			if (position >= 0 && position <= 2)
			{
				wImage wImage = new wImage(base.ID, id, image);
				this.OoOO0._00O0__o.[position].Add(wImage);
				result = wImage;
			}
			else
			{
				result = null;
			}
			return result;
		}

		/// <summary>
		/// 增加类似"获取验证码"的按钮
		/// </summary>
		/// <param name="id">按钮ID</param>
		/// <param name="text">按钮标题</param>
		/// <param name="position">按钮位置，0靠左显示，1居中显示，2靠右显示</param>
		// Token: 0x06001A76 RID: 6774 RVA: 0x000BBC74 File Offset: 0x000B9E74
		public wVcodeButton AddVcodeButton(string id, string text, int position)
		{
			wVcodeButton result;
			if (position >= 0 && position <= 2)
			{
				wVcodeButton wVcodeButton = new wVcodeButton(base.ID, id, text);
				this.OoOO0._00O0__o.[position].Add(wVcodeButton);
				result = wVcodeButton;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x000BBCAC File Offset: 0x000B9EAC
		private string <<EMPTY_NAME>>()
		{
			string text = "weui_cell";
			if (this.OoOO0._00O0__o.)
			{
				text += " weui_cell_select";
			}
			if (this.OO_.oO_OO0.)
			{
				text += " weui_select_before";
			}
			else
			{
				text += " weui_select_after";
			}
			int num = 0;
			bool flag;
			do
			{
				try
				{
					foreach (wElement wElement in this.OoOO0._00O0__o.[num])
					{
						if (wElement is wImage && !((wImage)wElement).Image.StartsWith("weui_icon"))
						{
							flag = true;
						}
						if (wElement is wVcodeButton)
						{
							flag = true;
						}
					}
				}
				finally
				{
					List<wElement>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				num++;
			}
			while (num <= 2);
			if (this.OO_.oO_OO0. == 1 || this.OO_.oO_OO0. == 2)
			{
				text += " weui_cell_warn";
			}
			if (flag)
			{
				text += " weui_vcode";
			}
			return text;
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x000BBDA0 File Offset: 0x000B9FA0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void BuildHtml(StringBuilder sb, wui wui)
		{
			sb.Append("<div class='" + this.OoOO0._00O0__o.());
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				sb.Append(" " + base.Class);
			}
			sb.Append("'");
			sb.Append(string.Concat(new string[]
			{
				" id='",
				base.ID,
				"' name='",
				base.ID,
				"'"
			}));
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				sb.Append(" " + base.Attribute);
			}
			sb.AppendLine(">");
			string[] array = new string[]
			{
				"weui_cell_hd",
				"weui_cell_bd",
				"weui_cell_ft"
			};
			int num = 0;
			do
			{
				if (this.OoOO0._00O0__o.[num].Count > 0)
				{
					sb.Append("<div class='" + array[num]);
					if (this.OoOO0._00O0__o. == num)
					{
						sb.AppendLine(" weui_cell_primary'>");
					}
					else
					{
						sb.AppendLine("'>");
					}
					try
					{
						foreach (wElement wElement in this.OoOO0._00O0__o.[num])
						{
							if (wElement is wInput)
							{
								((wInput)wElement).O_ooo.0.(sb, wui);
							}
							else if (wElement is wSelect)
							{
								((wSelect)wElement).OOOO0._0O.(sb, wui);
							}
							else
							{
								((o_oOOOoo_O_O)wElement).OOO.__O_oO_.(sb, wui);
							}
						}
					}
					finally
					{
						List<wElement>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					sb.AppendLine("</div>");
				}
				num++;
			}
			while (num <= 2);
			sb.AppendLine("</div>");
		}

		// Token: 0x04000B27 RID: 2855
		private List<wElement>[] <<EMPTY_NAME>>;

		// Token: 0x04000B28 RID: 2856
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B29 RID: 2857
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B2A RID: 2858
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B2B RID: 2859
		private bool <<EMPTY_NAME>>;
	}
}
