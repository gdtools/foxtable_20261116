using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200021E RID: 542
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wImage : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A1B RID: 6683 RVA: 0x000B9D70 File Offset: 0x000B7F70
		internal wImage(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.oo._00. = A_2;
		}

		/// <summary>
		/// 图片文件，含路径
		/// </summary>
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x000B9D81 File Offset: 0x000B7F81
		// (set) Token: 0x06001A1D RID: 6685 RVA: 0x000B9D89 File Offset: 0x000B7F89
		public string Image
		{
			get
			{
				return this.oo._00.;
			}
			set
			{
				this.oo._00. = value;
			}
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000B9D94 File Offset: 0x000B7F94
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void BuildHtml(StringBuilder sb, wui wui)
		{
			if (this.oo._00..StartsWith("weui_icon", StringComparison.CurrentCultureIgnoreCase))
			{
				sb.Append("<i id='" + base.ID + "' class='" + this.oo._00.);
				if (Operators.CompareString(base.Class, "", true) > 0)
				{
					sb.Append(" " + base.Class);
				}
				sb.Append("'");
				if (Operators.CompareString(base.Attribute, "", true) > 0)
				{
					sb.AppendLine(" " + base.Attribute);
				}
				sb.AppendLine("></i>");
				return;
			}
			sb.Append(string.Concat(new string[]
			{
				"<img id='",
				base.ID,
				"' src='",
				this.oo._00.,
				"'"
			}));
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				sb.Append(" class='" + base.Class + "'");
			}
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				sb.AppendLine(" " + base.Attribute);
			}
			sb.AppendLine("/>");
		}

		// Token: 0x04000AFB RID: 2811
		private string <<EMPTY_NAME>>;
	}
}
