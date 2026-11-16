using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000218 RID: 536
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wCheck : wElement, o_oOOOoo_O_O
	{
		/// <summary>
		/// 复选框标题
		/// </summary>
		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x000B9350 File Offset: 0x000B7550
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x000B9358 File Offset: 0x000B7558
		public string Text
		{
			get
			{
				return this.o00.0Oo.;
			}
			set
			{
				this.o00.0Oo. = value;
			}
		}

		/// <summary>
		/// 复选框默认是否勾选
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x000B9361 File Offset: 0x000B7561
		// (set) Token: 0x060019F9 RID: 6649 RVA: 0x000B9369 File Offset: 0x000B7569
		public bool Checked
		{
			get
			{
				return this.OO00000O0.0.;
			}
			set
			{
				this.OO00000O0.0. = value;
			}
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x000B9372 File Offset: 0x000B7572
		internal wCheck(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.oo_O.oO_o0. = true;
			this.Text = A_2;
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x000B938A File Offset: 0x000B758A
		internal wCheck(string A_0, string A_1, string A_2, bool A_3) : base(A_0, A_1)
		{
			this.oo_O.oO_o0. = true;
			this.Checked = A_3;
			this.Text = A_2;
		}

		/// <summary>
		/// 逻辑型，设置为False，将无法勾选此列表项。
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x000B93AA File Offset: 0x000B75AA
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x000B93B2 File Offset: 0x000B75B2
		public bool Enabled
		{
			get
			{
				return this.oo_O.oO_o0.;
			}
			set
			{
				this.oo_O.oO_o0. = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x000B93BB File Offset: 0x000B75BB
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x000B93C3 File Offset: 0x000B75C3
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string HID
		{
			get
			{
				return this.o.0_0OO00Ooo_0.;
			}
			set
			{
				this.o.0_0OO00Ooo_0. = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x000B93CC File Offset: 0x000B75CC
		private string baseclass
		{
			get
			{
				return "weui_check";
			}
		}

		/// <summary>
		/// 字符型，勾选后传递给服务端的值，如果不设置，将传递"on"值给服务端
		/// </summary>
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x000B93D3 File Offset: 0x000B75D3
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x000B93DB File Offset: 0x000B75DB
		public string Value
		{
			get
			{
				return this.o_o0OOO_0.o0o.;
			}
			set
			{
				this.o_o0OOO_0.o0o. = value;
			}
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x000B93E4 File Offset: 0x000B75E4
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
			A_0.AppendLine("<div class='weui_cell_hd'>");
			string text;
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				text = "<input type='checkbox' class='" + this.baseclass + "'";
			}
			else
			{
				text = string.Concat(new string[]
				{
					"<input type='checkbox' class='",
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
				base.ID,
				"' id='",
				base.ID,
				"'"
			});
			if (Operators.CompareString(this.o_o0OOO_0.o0o., "", true) > 0)
			{
				text = text + " value='" + this.o_o0OOO_0.o0o. + "'";
			}
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
			A_0.AppendLine("<i class='weui_icon_checked'></i>");
			A_0.AppendLine("</div>");
			A_0.AppendLine("<div class='weui_cell_bd weui_cell_primary'>");
			A_0.AppendLine("<p>" + this.Text + "</p>");
			A_0.AppendLine("</div>");
			A_0.AppendLine("</label>");
		}

		// Token: 0x04000AEC RID: 2796
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AED RID: 2797
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000AEE RID: 2798
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000AEF RID: 2799
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AF0 RID: 2800
		private string <<EMPTY_NAME>>;
	}
}
