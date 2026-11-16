using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000227 RID: 551
	[oO0oooo("A0085")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wPreview : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A63 RID: 6755 RVA: 0x000BB3A4 File Offset: 0x000B95A4
		internal wPreview(string A_0, string A_1, string A_2 = "", string A_3 = "") : base(A_0, A_1)
		{
			this.OO_00o0O0.0__. = new List<string>();
			this.oOooOO_0OO.o_. = new List<string>();
			this.OO_00o0O0.0__. = A_2;
			this.oOooOO_0OO.o_. = A_3;
		}

		/// <summary>
		/// 增加项目
		/// </summary>
		/// <param name="Label">项目标题</param>
		/// <param name="Value">项目值</param>
		/// <param name="Attribute">可选参数，项目属性</param>
		// Token: 0x06001A64 RID: 6756 RVA: 0x000BB3D4 File Offset: 0x000B95D4
		public void AddItem(string Label, string Value, string Attribute = "")
		{
			if (Operators.CompareString(Attribute, "", true) > 0)
			{
				Attribute = " " + Attribute;
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<div class='weui-form-preview__item'" + Attribute + ">");
			stringBuilder.AppendLine("<label class='weui-form-preview__label'>" + Label + "</label>");
			stringBuilder.AppendLine("<span class='weui-form-preview__value'>" + Value + "</span>");
			stringBuilder.AppendLine("</div>");
			this.OO_00o0O0.0__..Add(stringBuilder.ToString());
		}

		/// <summary>
		/// 在Preview底部增加操作按钮
		/// </summary>
		/// <param name="Text">按钮标题</param>
		/// <param name="Href">单击按钮后要跳转到的目标URL</param>
		/// <param name="Type">可选参数，设置为0按钮文字为灰色，设为1按钮文字为绿色</param>
		/// <param name="Attribute">可选参数，按钮属性</param>
		// Token: 0x06001A65 RID: 6757 RVA: 0x000BB468 File Offset: 0x000B9668
		public void AddButton(string Text, string Href, int Type = 1, string Attribute = "")
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (Operators.CompareString(Attribute, "", true) > 0)
			{
				Attribute = " " + Attribute;
			}
			if (Operators.CompareString(Href, "", true) > 0)
			{
				stringBuilder.Append("<a");
			}
			else
			{
				stringBuilder.Append("<button ");
			}
			stringBuilder.Append(" class='weui-form-preview__btn");
			if (Type == 0)
			{
				stringBuilder.Append(" weui-form-preview__btn_default'");
			}
			else
			{
				stringBuilder.Append(" weui-form-preview__btn_primary'");
			}
			stringBuilder.Append(Attribute);
			if (Operators.CompareString(Href, "", true) > 0)
			{
				stringBuilder.AppendLine(string.Concat(new string[]
				{
					" href='",
					Href,
					"'>",
					Text,
					"</a>"
				}));
			}
			else
			{
				stringBuilder.AppendLine(">" + Text + "</button>");
			}
			this.oOooOO_0OO.o_..Add(stringBuilder.ToString());
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x000BB560 File Offset: 0x000B9760
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			A_0.Append("<div class='weui-form-preview");
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				A_0.Append(" " + base.Class);
			}
			A_0.Append("'");
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			A_0.AppendLine(">");
			if (Operators.CompareString(this.OO_00o0O0.0__., "", true) > 0)
			{
				A_0.AppendLine("<div class='weui-form-preview__hd'>");
				A_0.AppendLine("<label class='weui-form-preview__label'>" + this.OO_00o0O0.0__. + "</label>");
				A_0.AppendLine("<em class='weui-form-preview__value'>" + this.oOooOO_0OO.o_. + "</em>");
				A_0.AppendLine("</div>");
			}
			if (this.OO_00o0O0.0__..Count > 0)
			{
				A_0.AppendLine("<div class='weui-form-preview__bd'>");
				try
				{
					foreach (string value in this.OO_00o0O0.0__.)
					{
						A_0.Append(value);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				A_0.AppendLine("</div>");
			}
			if (this.oOooOO_0OO.o_..Count > 0)
			{
				A_0.AppendLine("<div class='weui-form-preview__ft'>");
				try
				{
					foreach (string value2 in this.oOooOO_0OO.o_.)
					{
						A_0.Append(value2);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				A_0.AppendLine("</div>");
			}
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000B1E RID: 2846
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B1F RID: 2847
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B20 RID: 2848
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000B21 RID: 2849
		private List<string> <<EMPTY_NAME>>;
	}
}
