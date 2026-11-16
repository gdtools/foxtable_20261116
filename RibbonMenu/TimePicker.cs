using System;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 时间输入框
	/// </summary>
	// Token: 0x0200000C RID: 12
	[ComVisible(true)]
	public class TimePicker : RibbonItem
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002840 File Offset: 0x00000A40
		internal TimePicker(RibbonTimePicker A_0) : base(A_0)
		{
			this.o__Oo__.O__. = A_0;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002850 File Offset: 0x00000A50
		public TimePicker(string A_0)
		{
			this.o__Oo__.O__. = new RibbonTimePicker();
			this.oOo_.0o_O_O_0. = this.o__Oo__.O__.;
			this.o__Oo__.O__..ID = A_0;
		}

		/// <summary>
		/// 返回或者设置时间输入框的值
		/// </summary>
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000287B File Offset: 0x00000A7B
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002888 File Offset: 0x00000A88
		public TimeSpan Value
		{
			get
			{
				return this.o__Oo__.O__..Value;
			}
			set
			{
				this.o__Oo__.O__..Value = value;
			}
		}

		/// <summary>
		/// 返回或者设置时间输入框的标题
		/// </summary>
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002896 File Offset: 0x00000A96
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000028A3 File Offset: 0x00000AA3
		public string Label
		{
			get
			{
				return this.o__Oo__.O__..Label;
			}
			set
			{
				this.o__Oo__.O__..Label = value;
			}
		}

		/// <summary>
		/// 返回或设置时间输入框的宽度
		/// </summary>
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000028B1 File Offset: 0x00000AB1
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000028BE File Offset: 0x00000ABE
		public int TextAreaWidth
		{
			get
			{
				return this.o__Oo__.O__..TextAreaWidth;
			}
			set
			{
				this.o__Oo__.O__..TextAreaWidth = value;
			}
		}

		/// <summary>
		/// 输入框的值是否为空
		/// </summary>
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000028CC File Offset: 0x00000ACC
		public bool ValueIsNull
		{
			get
			{
				return this.o__Oo__.O__..ValueIsNull;
			}
		}

		/// <summary>
		/// 是否为长时间格式，长时间格式包括秒
		/// </summary>
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000028D9 File Offset: 0x00000AD9
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000028E9 File Offset: 0x00000AE9
		public bool LongTimeFormat
		{
			get
			{
				return this.o__Oo__.O__..StandardFormat == RibbonTimeFormat.LongTime;
			}
			set
			{
				if (value)
				{
					this.o__Oo__.O__..StandardFormat = RibbonTimeFormat.LongTime;
					return;
				}
				this.o__Oo__.O__..StandardFormat = RibbonTimeFormat.ShortTime;
			}
		}

		// Token: 0x04000011 RID: 17
		internal RibbonTimePicker <<EMPTY_NAME>>;
	}
}
