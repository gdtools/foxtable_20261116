using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200023B RID: 571
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wVcodeButton : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001B4D RID: 6989 RVA: 0x000C0048 File Offset: 0x000BE248
		internal wVcodeButton(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.OoOoo_o_.o_. = A_2;
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x000C0059 File Offset: 0x000BE259
		private string BaseClass
		{
			get
			{
				return "weui-vcode-btn";
			}
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x000C0060 File Offset: 0x000BE260
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			string text = "<a href='javascript:;'";
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
			text = text + ">" + this.OoOoo_o_.o_. + "</a>";
			A_0.AppendLine(text);
		}

		// Token: 0x04000B82 RID: 2946
		private string <<EMPTY_NAME>>;
	}
}
