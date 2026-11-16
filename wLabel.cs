using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000221 RID: 545
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wLabel : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A47 RID: 6727 RVA: 0x000BA69C File Offset: 0x000B889C
		internal wLabel(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.O.__00oOO_o0O0. = A_2;
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001A48 RID: 6728 RVA: 0x000BA6AD File Offset: 0x000B88AD
		private string BaseClass
		{
			get
			{
				return "weui_label";
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x000BA6B4 File Offset: 0x000B88B4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			string text = "<label";
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
			text = text + ">" + this.O.__00oOO_o0O0. + "</label>";
			A_0.AppendLine(text);
		}

		// Token: 0x04000B0B RID: 2827
		private string <<EMPTY_NAME>>;
	}
}
