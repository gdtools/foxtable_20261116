using System;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000233 RID: 563
	[oO0oooo("A0050")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wTextArea : wElement, o_oOOOoo_O_O
	{
		// Token: 0x06001AD9 RID: 6873 RVA: 0x000BDF9D File Offset: 0x000BC19D
		internal wTextArea(string A_0, string A_1, int A_2) : base(A_0, A_1)
		{
			this.o0oO._0o0_O. = true;
			this.o0O_ooo0_00.0_. = false;
			this.O0O_O_oO_0.o. = true;
			this.o0oO._0o0_O. = A_2;
		}

		/// <summary>
		/// 是否可用
		/// </summary>
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x000BDFC3 File Offset: 0x000BC1C3
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x000BDFCB File Offset: 0x000BC1CB
		public bool Enabled
		{
			get
			{
				return this.o0oO._0o0_O.;
			}
			set
			{
				this.o0oO._0o0_O. = value;
			}
		}

		/// <summary>
		/// 是否只读
		/// </summary>
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x000BDFD4 File Offset: 0x000BC1D4
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x000BDFDC File Offset: 0x000BC1DC
		public bool Readonly
		{
			get
			{
				return this.o0O_ooo0_00.0_.;
			}
			set
			{
				this.o0O_ooo0_00.0_. = value;
			}
		}

		/// <summary>
		/// 字符型，对输入框预期值的提示
		/// </summary>
		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x000BDFE5 File Offset: 0x000BC1E5
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x000BDFED File Offset: 0x000BC1ED
		public string Placeholder
		{
			get
			{
				return this.o0oO._0o0_O.;
			}
			set
			{
				this.o0oO._0o0_O. = value;
			}
		}

		/// <summary>
		/// 字符型，输入框的初始值
		/// </summary>
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x000BDFF6 File Offset: 0x000BC1F6
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x000BDFFE File Offset: 0x000BC1FE
		public string Value
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
		/// 逻辑型，是否必须输入内容，目前基于iOS的多数浏览器暂不支持这个属性
		/// </summary>
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x000BE007 File Offset: 0x000BC207
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x000BE00F File Offset: 0x000BC20F
		public bool required
		{
			get
			{
				return this.Oo_o00oo.0o.;
			}
			set
			{
				this.Oo_o00oo.0o. = value;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x000BE018 File Offset: 0x000BC218
		internal string baseClass
		{
			get
			{
				return "weui_textarea";
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x000BE01F File Offset: 0x000BC21F
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x000BE027 File Offset: 0x000BC227
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string HID
		{
			get
			{
				return this.Oo_o00oo.0o.;
			}
			set
			{
				this.Oo_o00oo.0o. = value;
			}
		}

		/// <summary>
		/// 逻辑型，提示表单数据时是否包括此输入框的值，默认为True
		/// </summary>
		/// <returns></returns>
		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x000BE030 File Offset: 0x000BC230
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x000BE038 File Offset: 0x000BC238
		public bool Post
		{
			get
			{
				return this.O0O_O_oO_0.o.;
			}
			set
			{
				this.O0O_O_oO_0.o. = value;
			}
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x000BE044 File Offset: 0x000BC244
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
			A_0.AppendLine("<div class='weui_cell_bd weui_cell_primary'>");
			string text = "<textarea id='" + base.ID + "'";
			if (this.Post)
			{
				text = text + " name='" + base.ID + "'";
			}
			if (Operators.CompareString(this.Placeholder, "", true) > 0)
			{
				text = text + " placeholder='" + this.Placeholder + "'";
			}
			if (!this.Enabled)
			{
				text += " disabled";
			}
			if (this.Readonly)
			{
				text += " readonly";
			}
			if (this.required)
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
			if (this.o0oO._0o0_O. > 0)
			{
				text = text + " rows='" + Conversions.ToString(this.o0oO._0o0_O.) + "'";
			}
			A_0.AppendLine(text + ">" + this.Value + "</textarea>");
			A_0.AppendLine("</div>");
			A_0.AppendLine("</div>");
		}

		// Token: 0x04000B53 RID: 2899
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B54 RID: 2900
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B55 RID: 2901
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000B56 RID: 2902
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B57 RID: 2903
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B58 RID: 2904
		private int <<EMPTY_NAME>>;

		// Token: 0x04000B59 RID: 2905
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B5A RID: 2906
		private bool <<EMPTY_NAME>>;
	}
}
