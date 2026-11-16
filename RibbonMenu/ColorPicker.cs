using System;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1Ribbon;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 颜色拾取按钮
	/// </summary>
	// Token: 0x02000018 RID: 24
	[ComVisible(true)]
	public class ColorPicker : RibbonItem
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x000030F3 File Offset: 0x000012F3
		internal ColorPicker(RibbonColorPicker A_0) : base(A_0)
		{
			this.oOoOoOoO._o0. = A_0;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003103 File Offset: 0x00001303
		public ColorPicker(string A_0)
		{
			this.oOoOoOoO._o0. = new RibbonColorPicker();
			this.oOo_.0o_O_O_0. = this.oOoOoOoO._o0.;
			this.oOoOoOoO._o0..ID = A_0;
		}

		/// <summary>
		/// 返回或设置颜色拾取按钮的标题
		/// </summary>
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000312E File Offset: 0x0000132E
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000313B File Offset: 0x0000133B
		public string Text
		{
			get
			{
				return this.oOoOoOoO._o0..Text;
			}
			set
			{
				this.oOoOoOoO._o0..Text = value;
			}
		}

		/// <summary>
		/// 返回或设置选定的颜色
		/// </summary>
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00003149 File Offset: 0x00001349
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00003156 File Offset: 0x00001356
		public Color Color
		{
			get
			{
				return this.oOoOoOoO._o0..Color;
			}
			set
			{
				this.oOoOoOoO._o0..Color = value;
			}
		}

		// Token: 0x04000021 RID: 33
		internal RibbonColorPicker <<EMPTY_NAME>>;
	}
}
