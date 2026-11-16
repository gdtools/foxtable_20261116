using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 字体选择框
	/// </summary>
	// Token: 0x02000019 RID: 25
	[ComVisible(true)]
	public class FontComboBox : RibbonItem
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00003164 File Offset: 0x00001364
		internal FontComboBox(RibbonFontComboBox A_0) : base(A_0)
		{
			this.o_.o0_o. = A_0;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003174 File Offset: 0x00001374
		public FontComboBox(string A_0)
		{
			this.o_.o0_o. = new RibbonFontComboBox();
			this.oOo_.0o_O_O_0. = this.o_.o0_o.;
			this.o_.o0_o..ID = A_0;
		}

		/// <summary>
		/// 返回或设置字体组合框中的内容
		/// </summary>
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000319F File Offset: 0x0000139F
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000031AC File Offset: 0x000013AC
		public string Text
		{
			get
			{
				return this.o_.o0_o..Text;
			}
			set
			{
				this.o_.o0_o..Text = value;
			}
		}

		/// <summary>
		/// 返回或设置字体组合框的标题
		/// </summary>
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000031BA File Offset: 0x000013BA
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000031C7 File Offset: 0x000013C7
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
		/// 返回或设置组合框的宽度
		/// </summary>
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000031D5 File Offset: 0x000013D5
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000031E2 File Offset: 0x000013E2
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

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000031F0 File Offset: 0x000013F0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public RibbonItemCollection MenuItems
		{
			get
			{
				if (this.o_.o0_o. == null)
				{
					this.o_.o0_o. = new RibbonItemCollection(this.o_.o0_o..MenuItems);
				}
				return this.o_.o0_o.;
			}
		}

		// Token: 0x04000022 RID: 34
		internal RibbonFontComboBox <<EMPTY_NAME>>;

		// Token: 0x04000023 RID: 35
		private RibbonItemCollection <<EMPTY_NAME>>;
	}
}
