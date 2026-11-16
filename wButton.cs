using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000213 RID: 531
	[oO0oooo("A0008")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wButton : wElement, o_oOOOoo_O_O
	{
		// Token: 0x060019CD RID: 6605 RVA: 0x000B86B4 File Offset: 0x000B68B4
		internal wButton(string A_0, string A_1, string A_2) : base(A_0, A_1)
		{
			this.o.oOo_oo0__O0_. = true;
			this.OOOO.__O__Oo. = A_2;
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x000B86CC File Offset: 0x000B68CC
		internal wButton(string A_0, string A_1, string A_2, string A_3) : base(A_0, A_1)
		{
			this.o.oOo_oo0__O0_. = true;
			this.OOOO.__O__Oo. = A_2;
			this.o_oOO_o._oOO. = A_3;
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x000B86EC File Offset: 0x000B68EC
		internal wButton(string A_0, string A_1, string A_2, string A_3, string A_4) : base(A_0, A_1)
		{
			this.o.oOo_oo0__O0_. = true;
			this.OOOO.__O__Oo. = A_2;
			this.o_oOO_o._oOO. = A_3;
			this.o.oOo_oo0__O0_. = A_4;
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x000B8714 File Offset: 0x000B6914
		private string TagName
		{
			get
			{
				string result;
				if (Operators.CompareString(this.o.oOo_oo0__O0_., "", true) > 0 || this.o_oOO_o._oOO.)
				{
					result = "a";
				}
				else
				{
					result = "button";
				}
				return result;
			}
		}

		/// <summary>
		/// 逻辑型，按钮是否可用
		/// </summary>
		/// <returns></returns>
		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x000B874C File Offset: 0x000B694C
		// (set) Token: 0x060019D2 RID: 6610 RVA: 0x000B8754 File Offset: 0x000B6954
		public bool Enabled
		{
			get
			{
				return this.o.oOo_oo0__O0_.;
			}
			set
			{
				this.o.oOo_oo0__O0_. = value;
			}
		}

		/// <summary>
		/// 用于设置按钮的颜色，默认为0，表示绿色，1表示灰色，2表示红色
		/// </summary>
		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x000B875D File Offset: 0x000B695D
		// (set) Token: 0x060019D4 RID: 6612 RVA: 0x000B8765 File Offset: 0x000B6965
		[oO0oooo("A0008")]
		public int Kind
		{
			get
			{
				return this.o.oOo_oo0__O0_.;
			}
			set
			{
				this.o.oOo_oo0__O0_. = value;
			}
		}

		/// <summary>
		/// 逻辑型，设置为True，将使用小尺寸按钮
		/// </summary>
		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x000B876E File Offset: 0x000B696E
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x000B8776 File Offset: 0x000B6976
		public bool Mini
		{
			get
			{
				return this.OOOO.__O__Oo.;
			}
			set
			{
				this.OOOO.__O__Oo. = value;
			}
		}

		/// <summary>
		/// 当按钮的类型为submit时，可以给按钮的Value设置一个值，此值将作为表单数据的一部分提交到服务器
		/// </summary>
		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x000B877F File Offset: 0x000B697F
		// (set) Token: 0x060019D8 RID: 6616 RVA: 0x000B8787 File Offset: 0x000B6987
		[oO0oooo("A0122")]
		public string Value
		{
			get
			{
				return this.o_0O.0OO__Oo.;
			}
			set
			{
				this.o_0O.0OO__Oo. = value;
			}
		}

		/// <summary>
		/// 当按钮的类型为submit时，可通过此属性设置接收表单数据的目标网页地址
		/// </summary>
		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x000B8790 File Offset: 0x000B6990
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x000B8798 File Offset: 0x000B6998
		[oO0oooo("A0122")]
		public string FormAction
		{
			get
			{
				return this.o0_oo0oO_0._00.;
			}
			set
			{
				this.o0_oo0oO_0._00. = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x000B87A4 File Offset: 0x000B69A4
		public string baseClass
		{
			get
			{
				string text = Interaction.IIf(this.o_oOO_o._oOO., "weui_btn_dialog", "weui_btn").ToString();
				if (!this.Enabled)
				{
					text += "  weui_btn_disabled";
				}
				switch (this.Kind)
				{
				case 0:
					if (this.o_oOO_o._oOO.)
					{
						text += " primary";
					}
					else
					{
						text += " weui_btn_primary";
					}
					break;
				case 1:
					if (this.o_oOO_o._oOO.)
					{
						text += " default";
					}
					else
					{
						text += " weui_btn_default";
					}
					break;
				case 2:
					text += " weui_btn_warn";
					break;
				}
				if (this.Mini)
				{
					text += " weui_btn_mini";
				}
				return text;
			}
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x000B8864 File Offset: 0x000B6A64
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, wui A_1)
		{
			A_0.Append(string.Concat(new string[]
			{
				"<",
				this.TagName,
				" id='",
				base.ID,
				"' name='",
				base.ID,
				"'"
			}));
			if (Operators.CompareString(this.o_oOO_o._oOO., "", true) > 0)
			{
				A_0.Append(" type='" + this.o_oOO_o._oOO. + "'");
			}
			if (Operators.CompareString(base.Class, "", true) > 0)
			{
				A_0.Append(string.Concat(new string[]
				{
					" class='",
					this.baseClass,
					" ",
					base.Class,
					"'"
				}));
			}
			else
			{
				A_0.Append(" class='" + this.baseClass + "'");
			}
			if (Operators.CompareString(this.o.oOo_oo0__O0_., "", true) > 0 || this.o_oOO_o._oOO.)
			{
				if (Operators.CompareString(this.o.oOo_oo0__O0_., "", true) == 0)
				{
					this.o.oOo_oo0__O0_. = "javascript:;";
				}
				A_0.Append(" href='" + this.o.oOo_oo0__O0_. + "'");
			}
			if (Operators.CompareString(this.o_0O.0OO__Oo., "", true) > 0)
			{
				A_0.Append(" value='" + this.o_0O.0OO__Oo. + "'");
			}
			if (Operators.CompareString(this.o0_oo0oO_0._00., "", true) > 0)
			{
				A_0.Append(" formaction='" + this.o0_oo0oO_0._00. + "'");
			}
			if (Operators.CompareString(base.Attribute, "", true) > 0)
			{
				A_0.Append(" " + base.Attribute);
			}
			A_0.Append(">");
			A_0.Append(this.OOOO.__O__Oo.);
			A_0.AppendLine("</" + this.TagName + ">");
		}

		// Token: 0x04000AD7 RID: 2775
		private string <<EMPTY_NAME>>;

		// Token: 0x04000AD8 RID: 2776
		private int <<EMPTY_NAME>>;

		// Token: 0x04000AD9 RID: 2777
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ADA RID: 2778
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000ADB RID: 2779
		private string <<EMPTY_NAME>>;

		// Token: 0x04000ADC RID: 2780
		private string <<EMPTY_NAME>>;

		// Token: 0x04000ADD RID: 2781
		private string <<EMPTY_NAME>>;

		// Token: 0x04000ADE RID: 2782
		private string <<EMPTY_NAME>>;

		// Token: 0x04000ADF RID: 2783
		internal bool <<EMPTY_NAME>>;
	}
}
