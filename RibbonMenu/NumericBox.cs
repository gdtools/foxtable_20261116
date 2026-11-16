using System;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 数值输入框
	/// </summary>
	// Token: 0x0200000E RID: 14
	[ComVisible(true)]
	public class NumericBox : RibbonItem
	{
		// Token: 0x06000057 RID: 87 RVA: 0x000029D5 File Offset: 0x00000BD5
		internal NumericBox(RibbonNumericBox A_0) : base(A_0)
		{
			this.OOo.O_o. = A_0;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000029E5 File Offset: 0x00000BE5
		public NumericBox(string A_0)
		{
			this.OOo.O_o. = new RibbonNumericBox();
			this.oOo_.0o_O_O_0. = this.OOo.O_o.;
			this.OOo.O_o..ID = A_0;
		}

		/// <summary>
		/// 允许输入的最小值
		/// </summary>
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002A10 File Offset: 0x00000C10
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002A1D File Offset: 0x00000C1D
		public decimal Minimum
		{
			get
			{
				return this.OOo.O_o..Minimum;
			}
			set
			{
				this.OOo.O_o..Minimum = value;
			}
		}

		/// <summary>
		/// 允许输入的最大值
		/// </summary>
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002A2B File Offset: 0x00000C2B
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002A38 File Offset: 0x00000C38
		public decimal Maximum
		{
			get
			{
				return this.OOo.O_o..Maximum;
			}
			set
			{
				this.OOo.O_o..Maximum = value;
			}
		}

		/// <summary>
		/// 返回或者设置数值框的值
		/// </summary>
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002A48 File Offset: 0x00000C48
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00002A73 File Offset: 0x00000C73
		public object value
		{
			get
			{
				object result;
				if (this.ValueIsNull)
				{
					result = null;
				}
				else
				{
					result = this.OOo.O_o..Value;
				}
				return result;
			}
			set
			{
				if (value == null)
				{
					this.OOo.O_o..ValueIsNull = true;
					return;
				}
				this.OOo.O_o..Value = Conversions.ToDecimal(value);
			}
		}

		/// <summary>
		/// 返回或者是单击数值输入框的微调按钮时，数值改变的幅度
		/// </summary>
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002A96 File Offset: 0x00000C96
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002AA3 File Offset: 0x00000CA3
		public decimal Increment
		{
			get
			{
				return this.OOo.O_o..Increment;
			}
			set
			{
				this.OOo.O_o..Increment = value;
			}
		}

		/// <summary>
		/// 返回或者设置日期框的标题
		/// </summary>
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002AB1 File Offset: 0x00000CB1
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002ABE File Offset: 0x00000CBE
		public string Label
		{
			get
			{
				return this.OOo.O_o..Label;
			}
			set
			{
				this.OOo.O_o..Label = value;
			}
		}

		/// <summary>
		/// 返回或设置日期框的宽度
		/// </summary>
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002ACC File Offset: 0x00000CCC
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002AD9 File Offset: 0x00000CD9
		public int TextAreaWidth
		{
			get
			{
				return this.OOo.O_o..TextAreaWidth;
			}
			set
			{
				this.OOo.O_o..TextAreaWidth = value;
			}
		}

		/// <summary>
		/// 输入框的值是否为空
		/// </summary>
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002AE7 File Offset: 0x00000CE7
		public bool ValueIsNull
		{
			get
			{
				return this.OOo.O_o..ValueIsNull;
			}
		}

		// Token: 0x04000013 RID: 19
		internal RibbonNumericBox <<EMPTY_NAME>>;
	}
}
