using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000234 RID: 564
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wGroupTitle : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001AEA RID: 6890 RVA: 0x000BE23C File Offset: 0x000BC43C
		internal wGroupTitle(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.Text = A_2;
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x000BE24D File Offset: 0x000BC44D
		// (set) Token: 0x06001AEC RID: 6892 RVA: 0x000BE255 File Offset: 0x000BC455
		public string Text
		{
			get
			{
				return this.OooO_o0o0O.0_.;
			}
			set
			{
				this.OooO_o0o0O.0_. = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x000BE25E File Offset: 0x000BC45E
		public string baseClass
		{
			get
			{
				return "weui_cells_title";
			}
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x000BE268 File Offset: 0x000BC468
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			string text = string.Concat(new string[]
			{
				"<div id='",
				base.ID,
				"' name='",
				base.ID,
				"'"
			});
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				text = string.Concat(new string[]
				{
					text,
					" class='",
					this.baseClass,
					" ",
					base.Class,
					"'"
				});
			}
			else
			{
				text = text + " class='" + this.baseClass + "'";
			}
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				text = text + " " + base.Attribute;
			}
			text = text + ">" + this.Text + "</div>";
			A_0.AppendLine(text);
		}

		// Token: 0x04000B5B RID: 2907
		private string <<EMPTY_NAME>>;
	}
}
