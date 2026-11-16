using System;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 日期输入框
	/// </summary>
	// Token: 0x0200000D RID: 13
	[ComVisible(true)]
	public class DatePicker : RibbonItem
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002907 File Offset: 0x00000B07
		internal DatePicker(RibbonDatePicker A_0) : base(A_0)
		{
			this.o_.o0_o. = A_0;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002917 File Offset: 0x00000B17
		public DatePicker(string A_0)
		{
			this.o_.o0_o. = new RibbonDatePicker();
			this.oOo_.0o_O_O_0. = this.o_.o0_o.;
			this.o_.o0_o..ID = A_0;
		}

		/// <summary>
		/// 返回或者设置日期框的值
		/// </summary>
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002944 File Offset: 0x00000B44
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000296F File Offset: 0x00000B6F
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
					result = this.o_.o0_o..Value;
				}
				return result;
			}
			set
			{
				if (value == null)
				{
					this.o_.o0_o..ValueIsNull = true;
					return;
				}
				this.o_.o0_o..Value = Conversions.ToDate(value);
			}
		}

		/// <summary>
		/// 返回或者设置日期框的标题
		/// </summary>
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002992 File Offset: 0x00000B92
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000299F File Offset: 0x00000B9F
		public string Label
		{
			get
			{
				return this.o_.o0_o..Label;
			}
			set
			{
				this.o_.o0_o..Label = value;
			}
		}

		/// <summary>
		/// 返回或设置日期框的宽度
		/// </summary>
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000029AD File Offset: 0x00000BAD
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000029BA File Offset: 0x00000BBA
		public int TextAreaWidth
		{
			get
			{
				return this.o_.o0_o..TextAreaWidth;
			}
			set
			{
				this.o_.o0_o..TextAreaWidth = value;
			}
		}

		/// <summary>
		/// 输入框的值是否为空
		/// </summary>
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000029C8 File Offset: 0x00000BC8
		public bool ValueIsNull
		{
			get
			{
				return this.o_.o0_o..ValueIsNull;
			}
		}

		// Token: 0x04000012 RID: 18
		internal RibbonDatePicker <<EMPTY_NAME>>;
	}
}
