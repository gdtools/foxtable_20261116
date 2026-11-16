using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200021F RID: 543
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("A0045")]
	public class wInput : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001A1F RID: 6687 RVA: 0x000B9EEB File Offset: 0x000B80EB
		internal wInput(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.O_ooo.0. = true;
			this.O.OO0O_Oo_O. = false;
			this.O_00o_.OO. = true;
			this.O.OO0O_Oo_O. = A_2;
		}

		/// <param name="ID">输入框的id</param>
		/// <param name="Label">输入框的标题</param>
		/// <param name="Type">输入框类型:
		/// 文本为"text"
		/// 密码为"password"
		/// 数值为"number"
		/// 日期为"date"
		/// 时间为"time"
		/// 日期时间为"datetime-local"</param>
		// Token: 0x06001A20 RID: 6688 RVA: 0x000B9F11 File Offset: 0x000B8111
		public wInput(string A_0, string A_1, string A_2, string A_3) : base(A_0, A_1)
		{
			this.O_ooo.0. = true;
			this.O.OO0O_Oo_O. = false;
			this.O_00o_.OO. = true;
			this.O.OO0O_Oo_O. = A_2;
			this.o_O__oo__.00oO. = A_3;
		}

		/// <summary>
		/// 逻辑型，输入框是否可用
		/// </summary>
		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x000B9F3F File Offset: 0x000B813F
		// (set) Token: 0x06001A22 RID: 6690 RVA: 0x000B9F47 File Offset: 0x000B8147
		public bool Enabled
		{
			get
			{
				return this.O_ooo.0.;
			}
			set
			{
				this.O_ooo.0. = value;
			}
		}

		/// <summary>
		/// 逻辑型，输入框是否只读
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x000B9F50 File Offset: 0x000B8150
		// (set) Token: 0x06001A24 RID: 6692 RVA: 0x000B9F58 File Offset: 0x000B8158
		public bool Readonly
		{
			get
			{
				return this.O.OO0O_Oo_O.;
			}
			set
			{
				this.O.OO0O_Oo_O. = value;
			}
		}

		/// <summary>
		/// 字符型，对输入框预期值的提示
		/// </summary>
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x000B9F61 File Offset: 0x000B8161
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x000B9F69 File Offset: 0x000B8169
		public string Placeholder
		{
			get
			{
				return this.oo_.0O_o0.;
			}
			set
			{
				this.oo_.0O_o0. = value;
			}
		}

		/// <summary>
		/// 字符型，输入框的初始值
		/// </summary>
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x000B9F72 File Offset: 0x000B8172
		// (set) Token: 0x06001A28 RID: 6696 RVA: 0x000B9F7A File Offset: 0x000B817A
		public string Value
		{
			get
			{
				return this.oo_.___.;
			}
			set
			{
				this.oo_.___. = value;
			}
		}

		/// <summary>
		/// 字符型，设置允许输入的最大值，目前基于iOS的多数浏览器暂不支持这个属性
		/// </summary>
		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x000B9F83 File Offset: 0x000B8183
		// (set) Token: 0x06001A2A RID: 6698 RVA: 0x000B9F8B File Offset: 0x000B818B
		[oO0oooo("A0047")]
		public string Max
		{
			get
			{
				return this.O_00o_.OO.;
			}
			set
			{
				this.O_00o_.OO. = value;
			}
		}

		/// <summary>
		/// 字符型，设置允许输入的最小值，目前基于iOS的多数浏览器暂不支持这个属性。
		/// </summary>
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x000B9F94 File Offset: 0x000B8194
		// (set) Token: 0x06001A2C RID: 6700 RVA: 0x000B9F9C File Offset: 0x000B819C
		[oO0oooo("A0047")]
		public string Min
		{
			get
			{
				return this.Oo.Oo0o__OO.;
			}
			set
			{
				this.Oo.Oo0o__OO. = value;
			}
		}

		/// <summary>
		/// 逻辑型，是否必须输入内容，目前基于iOS的多数浏览器暂不支持这个属性
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x000B9FA5 File Offset: 0x000B81A5
		// (set) Token: 0x06001A2E RID: 6702 RVA: 0x000B9FAD File Offset: 0x000B81AD
		public bool Required
		{
			get
			{
				return this.o_O__oo__.00oO.;
			}
			set
			{
				this.o_O__oo__.00oO. = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x000B9FB6 File Offset: 0x000B81B6
		private string baseClass
		{
			get
			{
				return "weui_input";
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x000B9FBD File Offset: 0x000B81BD
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x000B9FC5 File Offset: 0x000B81C5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string HID
		{
			get
			{
				return this.o_O0oo.OOo.;
			}
			set
			{
				this.o_O0oo.OOo. = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x000B9FCE File Offset: 0x000B81CE
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x000B9FD6 File Offset: 0x000B81D6
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string list
		{
			get
			{
				return this.O___.Oo.;
			}
			set
			{
				this.O___.Oo. = value;
			}
		}

		/// <summary>
		/// 字符型，指定输入精度，数值输入框默认只能输入整数，Step属性设置为"0.1"，可以输入一位小数，设置为"0.01"可以输入两位小数，依次类推
		/// </summary>
		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x000B9FDF File Offset: 0x000B81DF
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x000B9FE7 File Offset: 0x000B81E7
		[oO0oooo("A0047")]
		public string Step
		{
			get
			{
				return this.O0_.o_o.;
			}
			set
			{
				this.O0_.o_o. = value;
			}
		}

		/// <summary>
		/// 逻辑型，提示表单数据时是否包括此输入框的值，默认为True
		/// </summary>
		/// <returns></returns>
		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x000B9FF0 File Offset: 0x000B81F0
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x000B9FF8 File Offset: 0x000B81F8
		public bool Post
		{
			get
			{
				return this.O_00o_.OO.;
			}
			set
			{
				this.O_00o_.OO. = value;
			}
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x000BA004 File Offset: 0x000B8204
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			if (Operators.CompareString(this.HID, "", true) == 0)
			{
				A_0.AppendLine("<div class='weui_cell'>");
			}
			else
			{
				A_0.AppendLine(string.Concat(new string[]
				{
					"<div class='weui_cell' id='",
					this.HID,
					"' name='",
					this.HID,
					"'>"
				}));
			}
			if (Operators.CompareString(this.O.OO0O_Oo_O., "", true) > 0)
			{
				A_0.AppendLine("<div class='weui_cell_hd'><label class='weui_label'>" + this.O.OO0O_Oo_O. + "</label></div>");
			}
			A_0.AppendLine("<div class='weui_cell_bd weui_cell_primary'>");
			this.O_ooo.0.(A_0, A_1);
			A_0.AppendLine("</div>");
			A_0.AppendLine("</div>");
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x000BA0CC File Offset: 0x000B82CC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			string text = "<input id='" + base.ID + "'";
			if (this.Post)
			{
				text = text + " name='" + base.ID + "'";
			}
			if (Operators.CompareString(this.o_O__oo__.00oO., "", true) > 0)
			{
				text = text + " type='" + this.o_O__oo__.00oO. + "'";
			}
			if (Operators.CompareString(this.oo_.0O_o0., "", true) > 0)
			{
				text = text + " placeholder='" + this.oo_.0O_o0. + "'";
			}
			if (Operators.CompareString(this.O_00o_.OO., "", true) > 0)
			{
				text = text + " max='" + this.O_00o_.OO. + "'";
			}
			if (Operators.CompareString(this.Oo.Oo0o__OO., "", true) > 0)
			{
				text = text + " min='" + this.Oo.Oo0o__OO. + "'";
			}
			if (Operators.CompareString(this.O0_.o_o., "", true) > 0)
			{
				text = text + " step='" + this.O0_.o_o. + "'";
			}
			if (!this.O_ooo.0.)
			{
				text += " disabled";
			}
			if (this.O.OO0O_Oo_O.)
			{
				text += " readonly";
			}
			if (this.o_O__oo__.00oO.)
			{
				text += " required";
			}
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				text = text + " " + base.Attribute;
			}
			if (Operators.CompareString(base.Class, "", true) == 0)
			{
				text = text + " class='" + this.baseClass + "'";
			}
			else
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
			if (Operators.CompareString(this.oo_.___., "", true) > 0)
			{
				text = text + " value='" + this.oo_.___. + "'";
			}
			if (Operators.CompareString(this.O___.Oo., "", true) > 0)
			{
				text = text + " list='" + this.O___.Oo. + "'";
			}
			A_0.AppendLine(text + "/>");
		}

		// Token: 0x04000AFC RID: 2812
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000AFD RID: 2813
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000AFE RID: 2814
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000AFF RID: 2815
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B00 RID: 2816
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B01 RID: 2817
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B02 RID: 2818
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B03 RID: 2819
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B04 RID: 2820
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B05 RID: 2821
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B06 RID: 2822
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B07 RID: 2823
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B08 RID: 2824
		private bool <<EMPTY_NAME>>;
	}
}
