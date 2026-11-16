using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000235 RID: 565
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0049")]
	public class wSwitch : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001AEF RID: 6895 RVA: 0x000BE357 File Offset: 0x000BC557
		internal wSwitch(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.O_____O.oo_oo. = true;
			this.O.000oO__0. = true;
			this.o0O.00_o_0_o0. = A_2;
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x000BE376 File Offset: 0x000BC576
		internal wSwitch(string A_0, string A_1, string A_2, bool A_3) : base(A_0, A_1)
		{
			this.O_____O.oo_oo. = true;
			this.O.000oO__0. = true;
			this.o0O.00_o_0_o0. = A_3;
			this.o0O.00_o_0_o0. = A_2;
		}

		/// <summary>
		/// 逻辑型，设置为False，将无法改变开关状态
		/// </summary>
		/// <returns></returns>
		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x000BE39D File Offset: 0x000BC59D
		// (set) Token: 0x06001AF2 RID: 6898 RVA: 0x000BE3A5 File Offset: 0x000BC5A5
		public bool Enabled
		{
			get
			{
				return this.O_____O.oo_oo.;
			}
			set
			{
				this.O_____O.oo_oo. = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x000BE3AE File Offset: 0x000BC5AE
		// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x000BE3B6 File Offset: 0x000BC5B6
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string HID
		{
			get
			{
				return this.O.000oO__0.;
			}
			set
			{
				this.O.000oO__0. = value;
			}
		}

		/// <summary>
		/// 字符型，开关开启后提交端到服务端的值，如果不设置，将传递"on"值给服务端
		/// </summary>
		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x000BE3BF File Offset: 0x000BC5BF
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x000BE3C7 File Offset: 0x000BC5C7
		public string Value
		{
			get
			{
				return this.O_____O.oo_oo.;
			}
			set
			{
				this.O_____O.oo_oo. = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001AF7 RID: 6903 RVA: 0x000BE3D0 File Offset: 0x000BC5D0
		private string BaseClass
		{
			get
			{
				return "weui_switch";
			}
		}

		/// <summary>
		/// 逻辑型，提示表单数据时是否包括此开发的值，默认为True
		/// </summary>
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x000BE3D7 File Offset: 0x000BC5D7
		// (set) Token: 0x06001AF9 RID: 6905 RVA: 0x000BE3DF File Offset: 0x000BC5DF
		public bool Post
		{
			get
			{
				return this.O.000oO__0.;
			}
			set
			{
				this.O.000oO__0. = value;
			}
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x000BE3E8 File Offset: 0x000BC5E8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			if (Operators.CompareString(this.HID, "", true) == 0)
			{
				A_0.AppendLine("<div class='weui_cell weui_cell_switch'>");
			}
			else
			{
				A_0.AppendLine(string.Concat(new string[]
				{
					"<div class='weui_cell weui_cell_switch' id='",
					this.HID,
					"' name='",
					this.HID,
					"'>"
				}));
			}
			A_0.AppendLine("<div class='weui_cell_hd weui_cell_primary'>" + this.o0O.00_o_0_o0. + "</div>");
			A_0.AppendLine("  <div class='weui_cell_ft'>");
			string text = "<input type='checkbox'";
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
			text = text + " id='" + base.ID + "'";
			if (this.Post)
			{
				text = text + " name='" + base.ID + "'";
			}
			if (Operators.CompareString(this.O_____O.oo_oo., "", true) > 0)
			{
				text = text + " value='" + this.O_____O.oo_oo. + "'";
			}
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				text = text + " " + base.Attribute;
			}
			if (this.o0O.00_o_0_o0.)
			{
				text += " checked";
			}
			if (!this.Enabled)
			{
				text += " disabled";
			}
			text += "/>";
			A_0.AppendLine(text);
			A_0.AppendLine("</div>");
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000B5C RID: 2908
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B5D RID: 2909
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B5E RID: 2910
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B5F RID: 2911
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B60 RID: 2912
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B61 RID: 2913
		private bool <<EMPTY_NAME>>;
	}
}
