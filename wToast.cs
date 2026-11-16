using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000237 RID: 567
	[oO0oooo("A0082")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wToast : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001AFD RID: 6909 RVA: 0x000BE7B4 File Offset: 0x000BC9B4
		internal wToast(string A_0, string A_1, string A_2, int A_3) : base(A_0, A_1)
		{
			this.O_._0o0. = "default";
			this.o00O_OO.O. = A_2;
			this.o00O_OO.O. = A_3;
		}

		/// <summary>
		/// 字符型，指定Toast显示的图标,可选值有"success","info","warn","default"
		/// </summary>
		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x000BE7D8 File Offset: 0x000BC9D8
		// (set) Token: 0x06001AFF RID: 6911 RVA: 0x000BE7E0 File Offset: 0x000BC9E0
		public string Icon
		{
			get
			{
				return this.O_._0o0.;
			}
			set
			{
				this.O_._0o0. = value;
			}
		}

		/// <summary>
		/// 逻辑型，打开网页后是否显示Toast，默认为False
		/// </summary>
		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x000BE7E9 File Offset: 0x000BC9E9
		// (set) Token: 0x06001B01 RID: 6913 RVA: 0x000BE7F1 File Offset: 0x000BC9F1
		public bool Visible
		{
			get
			{
				return this.o00O_OO.O.;
			}
			set
			{
				this.o00O_OO.O. = value;
			}
		}

		/// <summary>
		/// 整数型，默认为0，用于设置Toast初始显示的毫秒数
		/// </summary>
		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x000BE7FA File Offset: 0x000BC9FA
		// (set) Token: 0x06001B03 RID: 6915 RVA: 0x000BE802 File Offset: 0x000BCA02
		public int msec
		{
			get
			{
				return this.O_._0o0.;
			}
			set
			{
				this.O_._0o0. = value;
			}
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x000BE80C File Offset: 0x000BCA0C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			string o_._0o0. = this.O_._0o0.;
			if (Operators.CompareString(o_._0o0., "success", true) == 0)
			{
				this.O_._0o0. = "weui_icon_success";
			}
			else if (Operators.CompareString(o_._0o0., "warn", true) == 0)
			{
				this.O_._0o0. = "weui_icon_warn";
			}
			else if (Operators.CompareString(o_._0o0., "info", true) == 0)
			{
				this.O_._0o0. = "weui_icon_info";
			}
			if (this.o00O_OO.O. == 0)
			{
				A_0.AppendLine("<div id='" + base.ID + Interaction.IIf(this.Visible, "'>", "' style='display:none'>").ToString());
			}
			else
			{
				A_0.AppendLine("<div class='weui_loading_toast' id='" + base.ID + Interaction.IIf(this.Visible, "'>", "' style='display:none'>").ToString());
			}
			A_0.AppendLine("<div class='weui_mask_transparent'></div>");
			A_0.AppendLine(" <div class='weui_toast'>");
			if (this.o00O_OO.O. == 0)
			{
				if (Operators.CompareString(this.O_._0o0., "", true) > 0 && Operators.CompareString(this.O_._0o0., "default", true) != 0)
				{
					A_0.AppendLine(" <i class='fox_toast_icon " + this.O_._0o0. + "'></i>");
				}
				else
				{
					A_0.AppendLine(" <i class='weui_icon_toast'></i>");
				}
			}
			else
			{
				A_0.AppendLine(" <div class='weui_loading'>");
				int num = 0;
				do
				{
					A_0.AppendLine(" <div class='weui_loading_leaf weui_loading_leaf_" + Conversions.ToString(num) + "'></div>");
					num++;
				}
				while (num <= 11);
				A_0.AppendLine("</div>");
			}
			A_0.AppendLine("<p class='weui_toast_content'>" + this.o00O_OO.O. + "</p>");
			A_0.AppendLine("</div>");
			A_0.AppendLine("</div>");
			if (this.msec > 0)
			{
				A_1.Scripts.Add(string.Concat(new string[]
				{
					"show('",
					base.ID,
					"',",
					Conversions.ToString(this.msec),
					");"
				}));
			}
		}

		// Token: 0x04000B64 RID: 2916
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B65 RID: 2917
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B66 RID: 2918
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B67 RID: 2919
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B68 RID: 2920
		private int <<EMPTY_NAME>>;
	}
}
