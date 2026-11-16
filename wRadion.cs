using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200022C RID: 556
	[oO0oooo("A0052")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wRadion : wElement, o_oOOOoo_O_O
	{
		/// <summary>
		/// 标题
		/// </summary>
		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x000BBF9C File Offset: 0x000BA19C
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x000BBFA4 File Offset: 0x000BA1A4
		public string Text
		{
			get
			{
				return this.OO.oO00.;
			}
			set
			{
				this.OO.oO00. = value;
			}
		}

		/// <summary>
		/// 默认是否勾选
		/// </summary>
		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x000BBFAD File Offset: 0x000BA1AD
		// (set) Token: 0x06001A7E RID: 6782 RVA: 0x000BBFB5 File Offset: 0x000BA1B5
		public bool Checked
		{
			get
			{
				return this.OO.oO00.;
			}
			set
			{
				this.OO.oO00. = value;
			}
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x000BBFBE File Offset: 0x000BA1BE
		internal wRadion(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.o.OOo_0__o. = true;
			this.Text = A_2;
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x000BBFD6 File Offset: 0x000BA1D6
		internal wRadion(string A_0, string A_1, string A_2, bool A_3) : base(A_0, A_1)
		{
			this.o.OOo_0__o. = true;
			this.Checked = A_3;
			this.Text = A_2;
		}

		/// <summary>
		/// 逻辑型，设置为False，将无法勾选此列表项
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x000BBFF6 File Offset: 0x000BA1F6
		// (set) Token: 0x06001A82 RID: 6786 RVA: 0x000BBFFE File Offset: 0x000BA1FE
		public bool Enabled
		{
			get
			{
				return this.o.OOo_0__o.;
			}
			set
			{
				this.o.OOo_0__o. = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x000BC007 File Offset: 0x000BA207
		// (set) Token: 0x06001A84 RID: 6788 RVA: 0x000BC00F File Offset: 0x000BA20F
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string HID
		{
			get
			{
				return this.o0O0o0OoO0.0.;
			}
			set
			{
				this.o0O0o0OoO0.0. = value;
			}
		}

		/// <summary>
		/// 字符型，勾选后传递给服务端的值，如果不设置，将传递ID值给服务端
		/// </summary>
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x000BC018 File Offset: 0x000BA218
		// (set) Token: 0x06001A86 RID: 6790 RVA: 0x000BC020 File Offset: 0x000BA220
		public string Value
		{
			get
			{
				return this.o.OOo_0__o.;
			}
			set
			{
				this.o.OOo_0__o. = value;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x000BC029 File Offset: 0x000BA229
		private string baseclass
		{
			get
			{
				return "weui_check";
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x000BC030 File Offset: 0x000BA230
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			if (Operators.CompareString(this.HID, "", true) == 0)
			{
				A_0.AppendLine("<label class='weui_cell weui_check_label' for='" + base.ID + "'>");
			}
			else
			{
				A_0.AppendLine(string.Concat(new string[]
				{
					"<label id='",
					this.HID,
					"' name='",
					this.HID,
					"' class='weui_cell weui_check_label' for='",
					base.ID,
					"'>"
				}));
			}
			A_0.AppendLine("<div class='weui_cell_bd weui_cell_primary'>");
			A_0.AppendLine(" <p>" + this.Text + "</p>");
			A_0.AppendLine("</div>");
			A_0.AppendLine("<div class='weui_cell_ft'>");
			string text;
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				text = "<input type='radio' class='" + this.baseclass + "'";
			}
			else
			{
				text = string.Concat(new string[]
				{
					"<input type='radio' class='",
					this.baseclass,
					" ",
					base.Class,
					"'"
				});
			}
			text = string.Concat(new string[]
			{
				text,
				" name='",
				base.PID,
				"' id='",
				base.ID,
				"' value = '",
				Interaction.IIf(Operators.CompareString(this.o.OOo_0__o., "", true) > 0, this.o.OOo_0__o., base.ID).ToString(),
				"'"
			});
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				text = text + " " + base.Attribute;
			}
			if (this.Checked)
			{
				text += " checked";
			}
			if (!this.Enabled)
			{
				text += " disabled";
			}
			text += "/>";
			A_0.AppendLine(text);
			A_0.AppendLine(" <span class='weui_icon_checked'></span>");
			A_0.AppendLine("</div>");
			A_0.AppendLine("</label>");
		}

		// Token: 0x04000B2D RID: 2861
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B2E RID: 2862
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B2F RID: 2863
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B30 RID: 2864
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B31 RID: 2865
		private string <<EMPTY_NAME>>;
	}
}
