using System;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 文本输入框
	/// </summary>
	// Token: 0x0200000B RID: 11
	[ComVisible(true)]
	public class TextBox : RibbonItem
	{
		// Token: 0x0600003B RID: 59 RVA: 0x000027B4 File Offset: 0x000009B4
		internal TextBox(RibbonTextBox A_0) : base(A_0)
		{
			this.o__Oo__.O__. = A_0;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000027C4 File Offset: 0x000009C4
		public TextBox(string A_0)
		{
			this.o__Oo__.O__. = new RibbonTextBox();
			this.oOo_.0o_O_O_0. = this.o__Oo__.O__.;
			this.o__Oo__.O__..ID = A_0;
		}

		/// <summary>
		/// 返回或者设置文本框中的内容
		/// </summary>
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000027EF File Offset: 0x000009EF
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000027FC File Offset: 0x000009FC
		public string Text
		{
			get
			{
				return this.o__Oo__.O__..Text;
			}
			set
			{
				this.o__Oo__.O__..Text = value;
			}
		}

		/// <summary>
		/// 返回或者设置文本框的标题
		/// </summary>
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000280A File Offset: 0x00000A0A
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002817 File Offset: 0x00000A17
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
		/// 返回或设置文本框的宽度
		/// </summary>
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002825 File Offset: 0x00000A25
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002832 File Offset: 0x00000A32
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

		// Token: 0x04000010 RID: 16
		internal RibbonTextBox <<EMPTY_NAME>>;
	}
}
